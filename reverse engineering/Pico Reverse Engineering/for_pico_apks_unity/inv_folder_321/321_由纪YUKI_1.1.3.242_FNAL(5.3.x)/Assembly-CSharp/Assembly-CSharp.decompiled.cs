using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Oculus.Platform;
using Oculus.Platform.Models;
using Oculus.Spatializer.Propagation;
using TMPro;
using TweenSystem.Movement;
using UI.Button;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Timeline;
using UnityEngine.UI;
using UnityEngine.Video;
using VR.HandOffsets;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xA6C50C", Offset = "0xA6C50C")]
[ImageEffectAllowedInSceneView]
[ExecuteInEditMode]
public class Pixelize : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Shader _screenAndMaskShader;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material _screenAndMaskMaterial;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RenderTexture _temporaryRenderTexture;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Shader _combineLayersShader;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Material _combineLayersMaterial;

	[Token(Token = "0x17000001")]
	private Shader ScreenAndMaskShader
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xDBC618", Offset = "0xDBC618", VA = "0xDBC618")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	private Material ScreenAndMaskMaterial
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xDBC6B8", Offset = "0xDBC6B8", VA = "0xDBC6B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	private RenderTexture TemporaryRenderTarget
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xDBC780", Offset = "0xDBC780", VA = "0xDBC780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	private Shader CombineLayersShader
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0xDBC908", Offset = "0xDBC908", VA = "0xDBC908")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	private Material CombineLayersMaterial
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0xDBC9A8", Offset = "0xDBC9A8", VA = "0xDBC9A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xDBCA70", Offset = "0xDBCA70", VA = "0xDBCA70")]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xDBC804", Offset = "0xDBC804", VA = "0xDBC804")]
	private void CreateTemporaryRenderTarget()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xDBCB44", Offset = "0xDBCB44", VA = "0xDBCB44")]
	private void CheckTemporaryRenderTarget()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xDBCBC8", Offset = "0xDBCBC8", VA = "0xDBCBC8")]
	private void ReleaseTemporaryRenderTarget()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xDBCC04", Offset = "0xDBCC04", VA = "0xDBCC04")]
	public Pixelize()
	{
	}
}
[Token(Token = "0x2000003")]
[ExecuteInEditMode]
public class VolumetricSphere : MonoBehaviour
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6D11C", Offset = "0xA6D11C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D11C", Offset = "0xA6D11C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6D11C", Offset = "0xA6D11C")]
	public float radius;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D198", Offset = "0xA6D198")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6D198", Offset = "0xA6D198")]
	public float density;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D1EC", Offset = "0xA6D1EC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6D1EC", Offset = "0xA6D1EC")]
	public float exponent;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D244", Offset = "0xA6D244")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6D244", Offset = "0xA6D244")]
	public int maxPixelizationLevel;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D298", Offset = "0xA6D298")]
	public bool enableLayersInterpolation;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6D2D0", Offset = "0xA6D2D0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D2D0", Offset = "0xA6D2D0")]
	public bool debugSphere;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xDCCE18", Offset = "0xDCCE18", VA = "0xDCCE18")]
	private void Update()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xDCCF88", Offset = "0xDCCF88", VA = "0xDCCF88")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xDCCFD8", Offset = "0xDCCFD8", VA = "0xDCCFD8")]
	public VolumetricSphere()
	{
	}
}
[Token(Token = "0x2000004")]
public class SimpleGPUInstancingExample : MonoBehaviour
{
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform Prefab;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material InstancedMaterial;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xDC1CF4", Offset = "0xDC1CF4", VA = "0xDC1CF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xDC1F54", Offset = "0xDC1F54", VA = "0xDC1F54")]
	public SimpleGPUInstancingExample()
	{
	}
}
[Token(Token = "0x2000005")]
public class SimpleMoveExample : MonoBehaviour
{
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 m_previous;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 m_target;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 m_originalPosition;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 BoundingVolume;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float Speed;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xDC1F5C", Offset = "0xDC1F5C", VA = "0xDC1F5C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xDC1FD8", Offset = "0xDC1FD8", VA = "0xDC1FD8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xDC2294", Offset = "0xDC2294", VA = "0xDC2294")]
	public SimpleMoveExample()
	{
	}
}
[Token(Token = "0x2000006")]
public class Smear : MonoBehaviour
{
	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Queue<Vector3> m_recentPositions;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int FramesBufferSize;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Renderer Renderer;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material m_instancedMaterial;

	[Token(Token = "0x17000006")]
	private Material InstancedMaterial
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0xDC22F8", Offset = "0xDC22F8", VA = "0xDC22F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000014")]
		[Address(RVA = "0xDC2300", Offset = "0xDC2300", VA = "0xDC2300")]
		set
		{
		}
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xDC2308", Offset = "0xDC2308", VA = "0xDC2308")]
	private void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xDC2344", Offset = "0xDC2344", VA = "0xDC2344")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xDC24C8", Offset = "0xDC24C8", VA = "0xDC24C8")]
	public Smear()
	{
	}
}
[Token(Token = "0x2000007")]
[ExecuteInEditMode]
public class PostProcessExample : MonoBehaviour
{
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material PostProcessMat;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xDBD8EC", Offset = "0xDBD8EC", VA = "0xDBD8EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xDBD9A0", Offset = "0xDBD9A0", VA = "0xDBD9A0")]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xDBDA24", Offset = "0xDBDA24", VA = "0xDBDA24")]
	public PostProcessExample()
	{
	}
}
[Token(Token = "0x2000008")]
[ExecuteInEditMode]
public class SpriteMaskController : MonoBehaviour
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private SpriteRenderer m_spriteRenderer;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector4 m_uvs;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xDC4D48", Offset = "0xDC4D48", VA = "0xDC4D48")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xDC4DFC", Offset = "0xDC4DFC", VA = "0xDC4DFC")]
	public SpriteMaskController()
	{
	}
}
[Serializable]
[Token(Token = "0x2000009")]
public class LightControlBehaviour : PlayableBehaviour
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float intensity;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float bounceIntensity;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float range;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xDA71A0", Offset = "0xDA71A0", VA = "0xDA71A0")]
	public LightControlBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x200000A")]
public class LightControlClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LightControlBehaviour template;

	[Token(Token = "0x17000007")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0xDA71E4", Offset = "0xDA71E4", VA = "0xDA71E4", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xDA71EC", Offset = "0xDA71EC", VA = "0xDA71EC", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xDA728C", Offset = "0xDA728C", VA = "0xDA728C")]
	public LightControlClip()
	{
	}
}
[Token(Token = "0x200000B")]
public class LightControlMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Color m_DefaultColor;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float m_DefaultIntensity;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float m_DefaultBounceIntensity;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float m_DefaultRange;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Light m_TrackBinding;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xDA72FC", Offset = "0xDA72FC", VA = "0xDA72FC", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xDA76E0", Offset = "0xDA76E0", VA = "0xDA76E0", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xDA77BC", Offset = "0xDA77BC", VA = "0xDA77BC")]
	public LightControlMixerBehaviour()
	{
	}
}
[Token(Token = "0x200000C")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xA6C5C0", Offset = "0xA6C5C0")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xA6C5C0", Offset = "0xA6C5C0")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0xA6C5C0", Offset = "0xA6C5C0")]
public class LightControlTrack : TrackAsset
{
	[Token(Token = "0x6000024")]
	[Address(RVA = "0xDA77C4", Offset = "0xDA77C4", VA = "0xDA77C4", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xDA785C", Offset = "0xDA785C", VA = "0xDA785C", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xDA7864", Offset = "0xDA7864", VA = "0xDA7864")]
	public LightControlTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x200000D")]
public class NavMeshAgentControlBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform destination;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool destinationSet;

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xDB0880", Offset = "0xDB0880", VA = "0xDB0880", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xDB0888", Offset = "0xDB0888", VA = "0xDB0888")]
	public NavMeshAgentControlBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x200000E")]
public class NavMeshAgentControlClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ExposedReference<Transform> destination;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public NavMeshAgentControlBehaviour template;

	[Token(Token = "0x17000008")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0xDB0890", Offset = "0xDB0890", VA = "0xDB0890", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xDB0898", Offset = "0xDB0898", VA = "0xDB0898", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xDB09B0", Offset = "0xDB09B0", VA = "0xDB09B0")]
	public NavMeshAgentControlClip()
	{
	}
}
[Token(Token = "0x200000F")]
public class NavMeshAgentControlMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x600002C")]
	[Address(RVA = "0xDB0A24", Offset = "0xDB0A24", VA = "0xDB0A24", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xDB0C54", Offset = "0xDB0C54", VA = "0xDB0C54")]
	public NavMeshAgentControlMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000010")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xA6C674", Offset = "0xA6C674")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xA6C674", Offset = "0xA6C674")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0xA6C674", Offset = "0xA6C674")]
public class NavMeshAgentControlTrack : TrackAsset
{
	[Token(Token = "0x600002E")]
	[Address(RVA = "0xDB0C5C", Offset = "0xDB0C5C", VA = "0xDB0C5C", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xDB0CF4", Offset = "0xDB0CF4", VA = "0xDB0CF4")]
	public NavMeshAgentControlTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x2000011")]
public class ScreenFaderBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xDC0C88", Offset = "0xDC0C88", VA = "0xDC0C88")]
	public ScreenFaderBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000012")]
public class ScreenFaderClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ScreenFaderBehaviour template;

	[Token(Token = "0x17000009")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0xDC0CBC", Offset = "0xDC0CBC", VA = "0xDC0CBC", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xDC0CC4", Offset = "0xDC0CC4", VA = "0xDC0CC4", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xDC0D64", Offset = "0xDC0D64", VA = "0xDC0D64")]
	public ScreenFaderClip()
	{
	}
}
[Token(Token = "0x2000013")]
public class ScreenFaderMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Color m_DefaultColor;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Image m_TrackBinding;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xDC0DD4", Offset = "0xDC0DD4", VA = "0xDC0DD4", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xDC10F8", Offset = "0xDC10F8", VA = "0xDC10F8", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xDC11A0", Offset = "0xDC11A0", VA = "0xDC11A0")]
	public ScreenFaderMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000014")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xA6C728", Offset = "0xA6C728")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xA6C728", Offset = "0xA6C728")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0xA6C728", Offset = "0xA6C728")]
public class ScreenFaderTrack : TrackAsset
{
	[Token(Token = "0x6000037")]
	[Address(RVA = "0xDC11A8", Offset = "0xDC11A8", VA = "0xDC11A8", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xDC1240", Offset = "0xDC1240", VA = "0xDC1240", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xDC1248", Offset = "0xDC1248", VA = "0xDC1248")]
	public ScreenFaderTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x2000015")]
public class TextSwitcherBehaviour : PlayableBehaviour
{
	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int fontSize;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string text;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xDC99DC", Offset = "0xDC99DC", VA = "0xDC99DC")]
	public TextSwitcherBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x2000016")]
public class TextSwitcherClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextSwitcherBehaviour template;

	[Token(Token = "0x1700000A")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0xDC9A18", Offset = "0xDC9A18", VA = "0xDC9A18", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xDC9A20", Offset = "0xDC9A20", VA = "0xDC9A20", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xDC9AC0", Offset = "0xDC9AC0", VA = "0xDC9AC0")]
	public TextSwitcherClip()
	{
	}
}
[Token(Token = "0x2000017")]
public class TextSwitcherMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Color m_DefaultColor;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int m_DefaultFontSize;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string m_DefaultText;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Text m_TrackBinding;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xDC9B30", Offset = "0xDC9B30", VA = "0xDC9B30", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xDC9F9C", Offset = "0xDC9F9C", VA = "0xDC9F9C", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xDCA074", Offset = "0xDCA074", VA = "0xDCA074")]
	public TextSwitcherMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000018")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xA6C7D8", Offset = "0xA6C7D8")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xA6C7D8", Offset = "0xA6C7D8")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0xA6C7D8", Offset = "0xA6C7D8")]
public class TextSwitcherTrack : TrackAsset
{
	[Token(Token = "0x6000041")]
	[Address(RVA = "0xDCA07C", Offset = "0xDCA07C", VA = "0xDCA07C", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xDCA114", Offset = "0xDCA114", VA = "0xDCA114", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xDCA11C", Offset = "0xDCA11C", VA = "0xDCA11C")]
	public TextSwitcherTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x2000019")]
public class TimeDilationBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float timeScale;

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xDCA184", Offset = "0xDCA184", VA = "0xDCA184")]
	public TimeDilationBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x200001A")]
public class TimeDilationClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TimeDilationBehaviour template;

	[Token(Token = "0x1700000B")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0xDCA194", Offset = "0xDCA194", VA = "0xDCA194", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xDCA19C", Offset = "0xDCA19C", VA = "0xDCA19C", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xDCA23C", Offset = "0xDCA23C", VA = "0xDCA23C")]
	public TimeDilationClip()
	{
	}
}
[Token(Token = "0x200001B")]
public class TimeDilationMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly float defaultTimeScale;

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xDCA2B8", Offset = "0xDCA2B8", VA = "0xDCA2B8", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xDCA484", Offset = "0xDCA484", VA = "0xDCA484", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xDCA490", Offset = "0xDCA490", VA = "0xDCA490", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xDCA49C", Offset = "0xDCA49C", VA = "0xDCA49C", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xDCA4A8", Offset = "0xDCA4A8", VA = "0xDCA4A8")]
	public TimeDilationMixerBehaviour()
	{
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xA6C88C", Offset = "0xA6C88C")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xA6C88C", Offset = "0xA6C88C")]
public class TimeDilationTrack : TrackAsset
{
	[Token(Token = "0x600004D")]
	[Address(RVA = "0xDCA4B8", Offset = "0xDCA4B8", VA = "0xDCA4B8", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xDCA550", Offset = "0xDCA550", VA = "0xDCA550")]
	public TimeDilationTrack()
	{
	}
}
[Serializable]
[Token(Token = "0x200001D")]
public class TransformTweenBehaviour : PlayableBehaviour
{
	[Token(Token = "0x2000127")]
	public enum TweenType
	{
		[Token(Token = "0x40006A5")]
		Linear,
		[Token(Token = "0x40006A6")]
		Deceleration,
		[Token(Token = "0x40006A7")]
		Harmonic,
		[Token(Token = "0x40006A8")]
		Custom
	}

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Transform startLocation;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform endLocation;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool tweenPosition;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool tweenRotation;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public TweenType tweenType;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve customCurve;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 startingPosition;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Quaternion startingRotation;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AnimationCurve m_LinearCurve;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AnimationCurve m_DecelerationCurve;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private AnimationCurve m_HarmonicCurve;

	[Token(Token = "0x4000045")]
	private const float k_RightAngleInRads = (float)Math.PI / 2f;

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xDCA5B8", Offset = "0xDCA5B8", VA = "0xDCA5B8", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xDCA660", Offset = "0xDCA660", VA = "0xDCA660")]
	public float EvaluateCurrentCurve(float time)
	{
		return default(float);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xDCA758", Offset = "0xDCA758", VA = "0xDCA758")]
	private bool IsCustomCurveNormalised()
	{
		return default(bool);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xDCA980", Offset = "0xDCA980", VA = "0xDCA980")]
	public TransformTweenBehaviour()
	{
	}
}
[Serializable]
[Token(Token = "0x200001E")]
public class TransformTweenClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TransformTweenBehaviour template;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ExposedReference<Transform> startLocation;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ExposedReference<Transform> endLocation;

	[Token(Token = "0x1700000C")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0xDCAB94", Offset = "0xDCAB94", VA = "0xDCAB94", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xDCAB9C", Offset = "0xDCAB9C", VA = "0xDCAB9C", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xDCACE4", Offset = "0xDCACE4", VA = "0xDCACE4")]
	public TransformTweenClip()
	{
	}
}
[Token(Token = "0x200001F")]
public class TransformTweenMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool m_FirstFrameHappened;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xDCAD54", Offset = "0xDCAD54", VA = "0xDCAD54", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xDCB47C", Offset = "0xDCB47C", VA = "0xDCB47C", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xDCB468", Offset = "0xDCB468", VA = "0xDCB468")]
	private static Quaternion AddQuaternions(Quaternion first, Quaternion second)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xDCB454", Offset = "0xDCB454", VA = "0xDCB454")]
	private static Quaternion ScaleQuaternion(Quaternion rotation, float multiplier)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xDCB484", Offset = "0xDCB484", VA = "0xDCB484")]
	private static float QuaternionMagnitude(Quaternion rotation)
	{
		return default(float);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xDCB364", Offset = "0xDCB364", VA = "0xDCB364")]
	private static Quaternion NormalizeQuaternion(Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xDCB570", Offset = "0xDCB570", VA = "0xDCB570")]
	public TransformTweenMixerBehaviour()
	{
	}
}
[Token(Token = "0x2000020")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xA6C918", Offset = "0xA6C918")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xA6C918", Offset = "0xA6C918")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0xA6C918", Offset = "0xA6C918")]
public class TransformTweenTrack : TrackAsset
{
	[Token(Token = "0x600005D")]
	[Address(RVA = "0xDCB578", Offset = "0xDCB578", VA = "0xDCB578", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xDCB610", Offset = "0xDCB610", VA = "0xDCB610", Slot = "29")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xDCB618", Offset = "0xDCB618", VA = "0xDCB618")]
	public TransformTweenTrack()
	{
	}
}
[Token(Token = "0x2000021")]
public class LookAtGradually : MonoBehaviour
{
	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LookAt lookAt;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve angularSpeedByTime;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float timer;

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xDAB6A8", Offset = "0xDAB6A8", VA = "0xDAB6A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xDAB708", Offset = "0xDAB708", VA = "0xDAB708")]
	private void Update()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xDAB760", Offset = "0xDAB760", VA = "0xDAB760")]
	public LookAtGradually()
	{
	}
}
[Token(Token = "0x2000022")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA6C9CC", Offset = "0xA6C9CC")]
public class FastList<T>
{
	[Token(Token = "0x2000128")]
	public delegate int CompareFunc(T left, T right);

	[Token(Token = "0x2000129")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CE34", Offset = "0xA6CE34")]
	private sealed class <GetEnumerator>d__25 : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T <>2__current;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FastList<T> <>4__this;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <i>5__2;

		[Token(Token = "0x170000AA")]
		private T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Token(Token = "0x60006E1")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x170000AB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006E3")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006DE")]
		[DebuggerHidden]
		public <GetEnumerator>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x60006DF")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006E0")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E2")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T[] array;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int size;

	[Token(Token = "0x1700000D")]
	public int Count
	{
		[Token(Token = "0x6000065")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000066")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public T Item
	{
		[Token(Token = "0x6000067")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x6000068")]
		set
		{
		}
	}

	[Token(Token = "0x6000063")]
	public FastList()
	{
	}

	[Token(Token = "0x6000064")]
	public FastList(int size)
	{
	}

	[Token(Token = "0x6000069")]
	public void Add(T item)
	{
	}

	[Token(Token = "0x600006A")]
	public void AddUnique(T item)
	{
	}

	[Token(Token = "0x600006B")]
	public void AddRange(IEnumerable<T> items)
	{
	}

	[Token(Token = "0x600006C")]
	public void Insert(int index, T item)
	{
	}

	[Token(Token = "0x600006D")]
	public bool Remove(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x600006E")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x600006F")]
	public bool RemoveFast(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000070")]
	public void RemoveAtFast(int index)
	{
	}

	[Token(Token = "0x6000071")]
	public bool Contains(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000072")]
	public int IndexOf(T item)
	{
		return default(int);
	}

	[Token(Token = "0x6000073")]
	public T Pop()
	{
		return (T)null;
	}

	[Token(Token = "0x6000074")]
	public T[] ToArray()
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	public void Sort(CompareFunc comparer)
	{
	}

	[Token(Token = "0x6000076")]
	public void InsertionSort(CompareFunc comparer)
	{
	}

	[Token(Token = "0x6000077")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA702F8", Offset = "0xA702F8")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	public T Find(Predicate<T> match)
	{
		return (T)null;
	}

	[Token(Token = "0x6000079")]
	private void Allocate()
	{
	}

	[Token(Token = "0x600007A")]
	private void Trim()
	{
	}

	[Token(Token = "0x600007B")]
	public void Clear()
	{
	}

	[Token(Token = "0x600007C")]
	public void Release()
	{
	}
}
[Token(Token = "0x2000023")]
public class InspectorNoteAttribute : PropertyAttribute
{
	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly string header;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public readonly string message;

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xDA66B0", Offset = "0xDA66B0", VA = "0xDA66B0")]
	public InspectorNoteAttribute(string header, string message = "")
	{
	}
}
[Token(Token = "0x2000024")]
public class InspectorCommentAttribute : PropertyAttribute
{
	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly string message;

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xDA667C", Offset = "0xDA667C", VA = "0xDA667C")]
	public InspectorCommentAttribute(string message = "")
	{
	}
}
[Token(Token = "0x2000025")]
public class OvrAvatarTestDriver : OvrAvatarDriver
{
	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 headPos;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion headRot;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xDB96D8", Offset = "0xDB96D8", VA = "0xDB96D8")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xDB9844", Offset = "0xDB9844", VA = "0xDB9844")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xDB9BE8", Offset = "0xDB9BE8", VA = "0xDB9BE8")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xDB9D90", Offset = "0xDB9D90", VA = "0xDB9D90", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xDB9DC0", Offset = "0xDB9DC0", VA = "0xDB9DC0")]
	public OvrAvatarTestDriver()
	{
	}
}
[Token(Token = "0x2000026")]
public class PoseEditHelper : MonoBehaviour
{
	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform poseRoot;

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xDBD6EC", Offset = "0xDBD6EC", VA = "0xDBD6EC")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xDBD778", Offset = "0xDBD778", VA = "0xDBD778")]
	private void DrawJoints(Transform joint)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xDBD8E4", Offset = "0xDBD8E4", VA = "0xDBD8E4")]
	public PoseEditHelper()
	{
	}
}
[Token(Token = "0x2000027")]
public class GazeTargetSpawner : MonoBehaviour
{
	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject GazeTargetPrefab;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int NumberOfDummyTargets;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int RadiusMultiplier;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isVisible;

	[Token(Token = "0x1700000F")]
	public bool IsVisible
	{
		[Token(Token = "0x6000087")]
		[Address(RVA = "0xDA5C6C", Offset = "0xDA5C6C", VA = "0xDA5C6C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000088")]
		[Address(RVA = "0xDA5C74", Offset = "0xDA5C74", VA = "0xDA5C74")]
		set
		{
		}
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xDA5D9C", Offset = "0xDA5D9C", VA = "0xDA5D9C")]
	private void Start()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xDA5FB8", Offset = "0xDA5FB8", VA = "0xDA5FB8")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xDA5FC0", Offset = "0xDA5FC0", VA = "0xDA5FC0")]
	public GazeTargetSpawner()
	{
	}
}
[Token(Token = "0x2000028")]
public class RemoteLoopbackManager : MonoBehaviour
{
	[Token(Token = "0x200012A")]
	private class PacketLatencyPair
	{
		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] PacketData;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float FakeLatency;

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xDBE3AC", Offset = "0xDBE3AC", VA = "0xDBE3AC")]
		public PacketLatencyPair()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200012B")]
	public class SimulatedLatencySettings
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA70288", Offset = "0xA70288")]
		public float FakeLatencyMax;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA702A0", Offset = "0xA702A0")]
		public float FakeLatencyMin;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA702B8", Offset = "0xA702B8")]
		public float LatencyWeight;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA702D0", Offset = "0xA702D0")]
		public int MaxSamples;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal float AverageWindow;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal float LatencySum;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal LinkedList<float> LatencyValues;

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xDBE3B4", Offset = "0xDBE3B4", VA = "0xDBE3B4")]
		public float NextValue()
		{
			return default(float);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xDBE564", Offset = "0xDBE564", VA = "0xDBE564")]
		public SimulatedLatencySettings()
		{
		}
	}

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OvrAvatar LocalAvatar;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar LoopbackAvatar;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimulatedLatencySettings LatencySettings;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int PacketSequence;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LinkedList<PacketLatencyPair> packetQueue;

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xDBDA2C", Offset = "0xDBDA2C", VA = "0xDBDA2C")]
	private void Start()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xDBDB64", Offset = "0xDBDB64", VA = "0xDBDB64")]
	private void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xDBDED4", Offset = "0xDBDED4", VA = "0xDBDED4")]
	private void Update()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xDBDE2C", Offset = "0xDBDE2C", VA = "0xDBDE2C")]
	private void SendPacketData(byte[] data)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xDBE130", Offset = "0xDBE130", VA = "0xDBE130")]
	private void ReceivePacketData(byte[] data)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xDBE4C0", Offset = "0xDBE4C0", VA = "0xDBE4C0")]
	public RemoteLoopbackManager()
	{
	}
}
[Token(Token = "0x2000029")]
public class P2PManager
{
	[Token(Token = "0x200012C")]
	private enum MessageType : byte
	{
		[Token(Token = "0x40006B7")]
		Update = 1
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xDBB3A0", Offset = "0xDBB3A0", VA = "0xDBB3A0")]
	public P2PManager()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xDBB460", Offset = "0xDBB460", VA = "0xDBB460")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xDBB6D0", Offset = "0xDBB6D0", VA = "0xDBB6D0")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xDBB818", Offset = "0xDBB818", VA = "0xDBB818")]
	private void PeerConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xDBB968", Offset = "0xDBB968", VA = "0xDBB968")]
	private void ConnectionStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xDBBC40", Offset = "0xDBBC40", VA = "0xDBBC40")]
	public void SendAvatarUpdate(ulong userID, Transform rootTransform, uint sequence, byte[] avatarPacket)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xDBC030", Offset = "0xDBC030", VA = "0xDBC030")]
	public void GetRemotePackets()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xDBC2CC", Offset = "0xDBC2CC", VA = "0xDBC2CC")]
	public void processAvatarPacket(RemotePlayer remote, ref byte[] packet, ref int offset)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xDBBE00", Offset = "0xDBBE00", VA = "0xDBBE00")]
	private void PackByte(byte b, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xDBC1FC", Offset = "0xDBC1FC", VA = "0xDBC1FC")]
	private byte ReadByte(byte[] buf, ref int offset)
	{
		return default(byte);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xDBBEE8", Offset = "0xDBBEE8", VA = "0xDBBEE8")]
	private void PackFloat(float f, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xDBC4EC", Offset = "0xDBC4EC", VA = "0xDBC4EC")]
	private float ReadFloat(byte[] buf, ref int offset)
	{
		return default(float);
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xDBBE48", Offset = "0xDBBE48", VA = "0xDBBE48")]
	private void PackULong(ulong u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xDBC240", Offset = "0xDBC240", VA = "0xDBC240")]
	private ulong ReadULong(byte[] buf, ref int offset)
	{
		return default(ulong);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xDBBF90", Offset = "0xDBBF90", VA = "0xDBBF90")]
	private void PackUInt32(uint u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xDBC578", Offset = "0xDBC578", VA = "0xDBC578")]
	private uint ReadUInt32(byte[] buf, ref int offset)
	{
		return default(uint);
	}
}
[Token(Token = "0x200002A")]
public class PlayerController : SocialPlatformManager
{
	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Camera spyCamera;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject cameraRig;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool showUI;

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xDBCC0C", Offset = "0xDBCC0C", VA = "0xDBCC0C", Slot = "5")]
	public override void Awake()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xDBCFA4", Offset = "0xDBCFA4", VA = "0xDBCFA4", Slot = "6")]
	public override void Start()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xDBCFC8", Offset = "0xDBCFC8", VA = "0xDBCFC8", Slot = "4")]
	public override void Update()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xDBD390", Offset = "0xDBD390", VA = "0xDBD390")]
	private void checkInput()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xDBD530", Offset = "0xDBD530", VA = "0xDBD530")]
	private void ToggleCamera()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xDBD5B0", Offset = "0xDBD5B0", VA = "0xDBD5B0")]
	private void ToggleUI()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xDBD604", Offset = "0xDBD604", VA = "0xDBD604")]
	public PlayerController()
	{
	}
}
[Token(Token = "0x200002B")]
public class RemotePlayer
{
	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong remoteUserID;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool stillInRoom;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public PeerConnectionState p2pConnectionState;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PeerConnectionState voipConnectionState;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar RemoteAvatar;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 receivedRootPosition;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 receivedRootPositionPrior;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Quaternion receivedRootRotation;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Quaternion receivedRootRotationPrior;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public VoipAudioSourceHiLevel voipSource;

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xDBE5F8", Offset = "0xDBE5F8", VA = "0xDBE5F8")]
	public RemotePlayer()
	{
	}
}
[Token(Token = "0x200002C")]
public class RoomManager
{
	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong roomID;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ulong invitedRoomID;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool amIServer;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool startupDone;

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xDBE600", Offset = "0xDBE600", VA = "0xDBE600")]
	public RoomManager()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xDBE6CC", Offset = "0xDBE6CC", VA = "0xDBE6CC")]
	private void AcceptingInviteCallback(Message<string> msg)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xDBE8D4", Offset = "0xDBE8D4", VA = "0xDBE8D4")]
	public bool CheckForInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xDBE9E0", Offset = "0xDBE9E0", VA = "0xDBE9E0")]
	public void CreateRoom()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xDBEA94", Offset = "0xDBEA94", VA = "0xDBEA94")]
	private void CreateAndJoinPrivateRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xDBF000", Offset = "0xDBF000", VA = "0xDBF000")]
	private void OnLaunchInviteWorkflowComplete(Message msg)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xDBE904", Offset = "0xDBE904", VA = "0xDBE904")]
	public void JoinExistingRoom(ulong roomID)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xDBF088", Offset = "0xDBF088", VA = "0xDBF088")]
	private void JoinRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xDBF750", Offset = "0xDBF750", VA = "0xDBF750")]
	private void RoomUpdateCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xDBFA6C", Offset = "0xDBFA6C", VA = "0xDBFA6C")]
	public void LeaveCurrentRoom()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xDBF378", Offset = "0xDBF378", VA = "0xDBF378")]
	private void ProcessRoomData(Message<Room> msg)
	{
	}
}
[Token(Token = "0x200002D")]
public class SocialPlatformManager : MonoBehaviour
{
	[Token(Token = "0x200012D")]
	public enum State
	{
		[Token(Token = "0x40006B9")]
		INITIALIZING,
		[Token(Token = "0x40006BA")]
		CHECKING_LAUNCH_STATE,
		[Token(Token = "0x40006BB")]
		CREATING_A_ROOM,
		[Token(Token = "0x40006BC")]
		WAITING_IN_A_ROOM,
		[Token(Token = "0x40006BD")]
		JOINING_A_ROOM,
		[Token(Token = "0x40006BE")]
		CONNECTED_IN_A_ROOM,
		[Token(Token = "0x40006BF")]
		LEAVING_A_ROOM,
		[Token(Token = "0x40006C0")]
		SHUTDOWN
	}

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 START_ROTATION_ONE;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly Vector3 START_POSITION_ONE;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 START_ROTATION_TWO;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static readonly Vector3 START_POSITION_TWO;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly Vector3 START_ROTATION_THREE;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static readonly Vector3 START_POSITION_THREE;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly Vector3 START_ROTATION_FOUR;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static readonly Vector3 START_POSITION_FOUR;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static readonly Color BLACK;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static readonly Color WHITE;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static readonly Color CYAN;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static readonly Color BLUE;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static readonly Color GREEN;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float voiceCurrent;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private uint packetSequence;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar localAvatarPrefab;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar remoteAvatarPrefab;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject helpPanel;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected MeshRenderer helpMesh;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material riftMaterial;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material gearMaterial;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected OvrAvatar localAvatar;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected GameObject localTrackingSpace;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected GameObject localPlayerHead;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Dictionary<ulong, RemotePlayer> remoteUsers;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject roomSphere;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected MeshRenderer sphereMesh;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject roomFloor;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected MeshRenderer floorMesh;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected State currentState;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected static SocialPlatformManager s_instance;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected RoomManager roomManager;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected P2PManager p2pManager;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected VoipManager voipManager;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected ulong myID;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected string myOculusID;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public static readonly float VOIP_SCALE;

	[Token(Token = "0x17000010")]
	public static State CurrentState
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xDC39D0", Offset = "0xDC39D0", VA = "0xDC39D0")]
		get
		{
			return default(State);
		}
	}

	[Token(Token = "0x17000011")]
	public static ulong MyID
	{
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xDBB53C", Offset = "0xDBB53C", VA = "0xDBB53C")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17000012")]
	public static string MyOculusID
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xDC3A44", Offset = "0xDC3A44", VA = "0xDC3A44")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xDBCFEC", Offset = "0xDBCFEC", VA = "0xDBCFEC", Slot = "4")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xDBCC4C", Offset = "0xDBCC4C", VA = "0xDBCC4C", Slot = "5")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xDC2740", Offset = "0xDC2740", VA = "0xDC2740")]
	private void InitCallback(Message<PlatformInitialize> msg)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xDBCFC4", Offset = "0xDBCFC4", VA = "0xDBCFC4", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xDC289C", Offset = "0xDC289C", VA = "0xDC289C")]
	private void IsEntitledCallback(Message msg)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xDC2990", Offset = "0xDC2990", VA = "0xDC2990")]
	private void GetLoggedInUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xDC30E4", Offset = "0xDC30E4", VA = "0xDC30E4")]
	private void GetLoggedInUserFriendsAndRoomsCallback(Message<UserAndRoomList> msg)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xDC35D4", Offset = "0xDC35D4", VA = "0xDC35D4")]
	public void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xDC379C", Offset = "0xDC379C", VA = "0xDC379C")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xDC3960", Offset = "0xDC3960", VA = "0xDC3960")]
	public void AddUser(ulong userID, ref RemotePlayer remoteUser)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xDC25CC", Offset = "0xDC25CC", VA = "0xDC25CC")]
	public void LogOutputLine(string line)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xDBE824", Offset = "0xDBE824", VA = "0xDBE824")]
	public static void TerminateWithError(Message msg)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xDBEBB8", Offset = "0xDBEBB8", VA = "0xDBEBB8")]
	public static void TransitionToState(State newState)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xDC3B58", Offset = "0xDC3B58", VA = "0xDC3B58")]
	private static void SetSphereColorForState()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xDBEF18", Offset = "0xDBEF18", VA = "0xDBEF18")]
	public static void SetFloorColorForState(bool host)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xDBFAE4", Offset = "0xDBFAE4", VA = "0xDBFAE4")]
	public static void MarkAllRemoteUsersAsNotInRoom()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xDBFE7C", Offset = "0xDBFE7C", VA = "0xDBFE7C")]
	public static void MarkRemoteUserInRoom(ulong userID)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xDBFF4C", Offset = "0xDBFF4C", VA = "0xDBFF4C")]
	public static void ForgetRemoteUsersNotInRoom()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xDBB614", Offset = "0xDBB614", VA = "0xDBB614")]
	public static void LogOutput(string line)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xDBFC08", Offset = "0xDBFC08", VA = "0xDBFC08")]
	public static bool IsUserInRoom(ulong userID)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xDBFC94", Offset = "0xDBFC94", VA = "0xDBFC94")]
	public static void AddRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xDC3CD8", Offset = "0xDC3CD8", VA = "0xDC3CD8")]
	public static void RemoveRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xDC3F90", Offset = "0xDC3F90", VA = "0xDC3F90")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xDC2544", Offset = "0xDC2544", VA = "0xDC2544")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA7035C", Offset = "0xA7035C")]
	public static void MicFilter(short[] pcmData, UIntPtr pcmDataLength, int frequency, int numChannels)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xDBB750", Offset = "0xDBB750", VA = "0xDBB750")]
	public static RemotePlayer GetRemoteUser(ulong userID)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xDBD670", Offset = "0xDBD670", VA = "0xDBD670")]
	public SocialPlatformManager()
	{
	}
}
[Token(Token = "0x200002E")]
public class VoipManager
{
	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xDC2680", Offset = "0xDC2680", VA = "0xDC2680")]
	public VoipManager()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xDC3EB4", Offset = "0xDC3EB4", VA = "0xDC3EB4")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xDC38E0", Offset = "0xDC38E0", VA = "0xDC38E0")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xDCC9F0", Offset = "0xDCC9F0", VA = "0xDCC9F0")]
	private void VoipConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xDCCB40", Offset = "0xDCCB40", VA = "0xDCCB40")]
	private void VoipStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}
}
[Token(Token = "0x200002F")]
public class GazeTarget : MonoBehaviour
{
	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarGazeTargetType Type;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ovrAvatarGazeTargets RuntimeTargetList;

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xDA58E8", Offset = "0xDA58E8", VA = "0xDA58E8")]
	static GazeTarget()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xDA5968", Offset = "0xDA5968", VA = "0xDA5968")]
	private void Start()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xDA5AE4", Offset = "0xDA5AE4", VA = "0xDA5AE4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xDA5B48", Offset = "0xDA5B48", VA = "0xDA5B48")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xDA59A4", Offset = "0xDA59A4", VA = "0xDA59A4")]
	private void UpdateGazeTarget()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xDA5C04", Offset = "0xDA5C04", VA = "0xDA5C04")]
	private ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xDA5C64", Offset = "0xDA5C64", VA = "0xDA5C64")]
	public GazeTarget()
	{
	}
}
[Serializable]
[Token(Token = "0x2000030")]
public class AvatarLayer
{
	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int layerIndex;

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xD9F760", Offset = "0xD9F760", VA = "0xD9F760")]
	public AvatarLayer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000031")]
public class PacketRecordSettings
{
	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal bool RecordingFrames;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float UpdateRate;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal float AccumulatedTime;

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xDBC604", Offset = "0xDBC604", VA = "0xDBC604")]
	public PacketRecordSettings()
	{
	}
}
[Token(Token = "0x2000032")]
public class OvrAvatar : MonoBehaviour
{
	[Token(Token = "0x200012E")]
	public class PacketEventArgs : EventArgs
	{
		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly OvrAvatarPacket Packet;

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xFA4438", Offset = "0xFA4438", VA = "0xFA4438")]
		public PacketEventArgs(OvrAvatarPacket packet)
		{
		}
	}

	[Token(Token = "0x200012F")]
	public enum HandType
	{
		[Token(Token = "0x40006C3")]
		Right,
		[Token(Token = "0x40006C4")]
		Left,
		[Token(Token = "0x40006C5")]
		Max
	}

	[Token(Token = "0x2000130")]
	public enum HandJoint
	{
		[Token(Token = "0x40006C7")]
		HandBase,
		[Token(Token = "0x40006C8")]
		IndexBase,
		[Token(Token = "0x40006C9")]
		IndexTip,
		[Token(Token = "0x40006CA")]
		ThumbBase,
		[Token(Token = "0x40006CB")]
		ThumbTip,
		[Token(Token = "0x40006CC")]
		Max
	}

	[Token(Token = "0x2000131")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CE44", Offset = "0xA6CE44")]
	private sealed class <WaitForMouthAudioSource>d__137 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatar <>4__this;

		[Token(Token = "0x170000AC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006EB")]
			[Address(RVA = "0xFA68E8", Offset = "0xFA68E8", VA = "0xFA68E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0xFA6950", Offset = "0xFA6950", VA = "0xFA6950", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xFA62D4", Offset = "0xFA62D4", VA = "0xFA62D4")]
		[DebuggerHidden]
		public <WaitForMouthAudioSource>d__137(int <>1__state)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xFA674C", Offset = "0xFA674C", VA = "0xFA674C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xFA6750", Offset = "0xFA6750", VA = "0xFA6750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xFA68F0", Offset = "0xFA68F0", VA = "0xFA68F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6D350", Offset = "0xA6D350")]
	public IntPtr sdkAvatar;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string oculusUserID;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatarDriver Driver;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6D388", Offset = "0xA6D388")]
	public bool EnableBody;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool EnableHands;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool EnableBase;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool EnableExpressive;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6D3C0", Offset = "0xA6D3C0")]
	public bool RecordPackets;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool UseSDKPackets;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public PacketRecordSettings PacketSettings;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6D3F8", Offset = "0xA6D3F8")]
	public bool StartWithControllers;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AvatarLayer FirstPersonLayer;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AvatarLayer ThirdPersonLayer;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool ShowFirstPerson;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool ShowThirdPerson;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	internal ovrAvatarCapabilities Capabilities;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6D430", Offset = "0xA6D430")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D430", Offset = "0xA6D430")]
	[SerializeField]
	internal ovrAvatarAssetLevelOfDetail LevelOfDetail;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D4A0", Offset = "0xA6D4A0")]
	private bool CombineMeshes;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D4D8", Offset = "0xA6D4D8")]
	public bool UseTransparentRenderQueue;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6D510", Offset = "0xA6D510")]
	public Shader Monochrome_SurfaceShader;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Shader Monochrome_SurfaceShader_SelfOccluding;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Shader Monochrome_SurfaceShader_PBS;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Shader Skinshaded_SurfaceShader_SingleComponent;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Shader Skinshaded_VertFrag_SingleComponent;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Shader Skinshaded_VertFrag_CombinedMesh;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Shader Skinshaded_Expressive_SurfaceShader_SingleComponent;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Shader Skinshaded_Expressive_VertFrag_SingleComponent;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Shader Skinshaded_Expressive_VertFrag_CombinedMesh;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Shader Loader_VertFrag_CombinedMesh;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Shader EyeLens;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Shader ControllerShader;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6D548", Offset = "0xA6D548")]
	public bool CanOwnMicrophone;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D580", Offset = "0xA6D580")]
	public bool EnableLaughter;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject MouthAnchor;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Transform LeftHandCustomPose;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform RightHandCustomPose;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private HashSet<ulong> assetLoadingIds;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool assetsFinishedLoading;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private OvrAvatarMaterialManager materialManager;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool waitingForCombinedMesh;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool doneExpressiveGlobalInit;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Vector4 clothingAlphaOffset;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ulong clothingAlphaTexture;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private OVRLipSyncMicInput micInput;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private OVRLipSyncContext lipsyncContext;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private OVRLipSync.Frame currentFrame;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private float[] visemes;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private AudioSource audioSource;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private ONSPAudioSource spatializedSource;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private List<float[]> voiceUpdates;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ovrAvatarVisemes RuntimeVisemes;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Transform cachedLeftHandCustomPose;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Transform[] cachedCustomLeftHandJoints;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private ovrAvatarTransform[] cachedLeftHandTransforms;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private Transform cachedRightHandCustomPose;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Transform[] cachedCustomRightHandJoints;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private ovrAvatarTransform[] cachedRightHandTransforms;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private bool showLeftController;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x189")]
	private bool showRightController;

	[Token(Token = "0x40000D6")]
	private const bool USE_MOBILE_TEXTURE_FORMAT = true;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 MOUTH_HEAD_OFFSET;

	[Token(Token = "0x40000D8")]
	private const string MOUTH_HELPER_NAME = "MouthAnchor";

	[Token(Token = "0x40000D9")]
	private const int VISEME_COUNT = 16;

	[Token(Token = "0x40000DA")]
	private const float ACTION_UNIT_ONSET_SPEED = 30f;

	[Token(Token = "0x40000DB")]
	private const float ACTION_UNIT_FALLOFF_SPEED = 20f;

	[Token(Token = "0x40000DC")]
	private const float VISEME_LEVEL_MULTIPLIER = 1.5f;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	internal ulong oculusUserIDInternal;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	internal OvrAvatarBase Base;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	internal OvrAvatarTouchController ControllerLeft;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	internal OvrAvatarTouchController ControllerRight;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	internal OvrAvatarBody Body;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	internal OvrAvatarHand HandLeft;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	internal OvrAvatarHand HandRight;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	internal ovrAvatarLookAndFeelVersion LookAndFeelVersion;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	internal ovrAvatarLookAndFeelVersion FallbackLookAndFeelVersion;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private OvrAvatarPacket CurrentUnityPacket;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public EventHandler<PacketEventArgs> PacketRecorded;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string[,] HandJoints;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static Vector3 MOUTH_POSITION_OFFSET;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static string VOICE_PROPERTY;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static string MOUTH_POSITION_PROPERTY;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static string MOUTH_DIRECTION_PROPERTY;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static string MOUTH_SCALE_PROPERTY;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static float MOUTH_SCALE_GLOBAL;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private static float MOUTH_MAX_GLOBAL;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static string NECK_JONT;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public float VoiceAmplitude;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	public bool EnableMouthVertexAnimation;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static ovrAvatarLights ovrLights;

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xF9FF70", Offset = "0xF9FF70", VA = "0xF9FF70")]
	static OvrAvatar()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xFA0388", Offset = "0xFA0388", VA = "0xFA0388")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xFA0414", Offset = "0xFA0414", VA = "0xFA0414")]
	public void AssetLoadedCallback(OvrAvatarAsset asset)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xFA0480", Offset = "0xFA0480", VA = "0xFA0480")]
	public void CombinedMeshLoadedCallback(IntPtr assetPtr)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xFA05A8", Offset = "0xFA05A8", VA = "0xFA05A8")]
	private OvrAvatarSkinnedMeshRenderComponent AddSkinnedMeshRenderComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xFA068C", Offset = "0xFA068C", VA = "0xFA068C")]
	private OvrAvatarSkinnedMeshRenderPBSComponent AddSkinnedMeshRenderPBSComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xFA076C", Offset = "0xFA076C", VA = "0xFA076C")]
	private OvrAvatarSkinnedMeshPBSV2RenderComponent AddSkinnedMeshRenderPBSV2Component(IntPtr renderPart, GameObject go, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRenderPBSV2, bool isBodyPartZero, bool isControllerModel)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xFA0D5C", Offset = "0xFA0D5C", VA = "0xFA0D5C")]
	public static IntPtr GetRenderPart(ovrAvatarComponent component, uint renderPartIndex)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xFA0E24", Offset = "0xFA0E24", VA = "0xFA0E24")]
	private static string GetRenderPartName(ovrAvatarComponent component, uint renderPartIndex)
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xFA0EA8", Offset = "0xFA0EA8", VA = "0xFA0EA8")]
	internal static void ConvertTransform(float[] transform, ref ovrAvatarTransform target)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xFA0F90", Offset = "0xFA0F90", VA = "0xFA0F90")]
	internal static void ConvertTransform(ovrAvatarTransform transform, Transform target)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xFA101C", Offset = "0xFA101C", VA = "0xFA101C")]
	public static ovrAvatarTransform CreateOvrAvatarTransform(Vector3 position, Quaternion orientation)
	{
		return default(ovrAvatarTransform);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xFA1138", Offset = "0xFA1138", VA = "0xFA1138")]
	private static ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xFA1198", Offset = "0xFA1198", VA = "0xFA1198")]
	private void BuildRenderComponents()
	{
	}

	[Token(Token = "0x60000EF")]
	private void AddAvatarComponent<T>(ref T root, ovrAvatarComponent nativeComponent) where T : OvrAvatarComponent
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xFA161C", Offset = "0xFA161C", VA = "0xFA161C")]
	private void UpdateCustomPoses()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xFA197C", Offset = "0xFA197C", VA = "0xFA197C")]
	private static bool UpdatePoseRoot(Transform poseRoot, ref Transform cachedPoseRoot, ref Transform[] cachedPoseJoints, ref ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xFA1B24", Offset = "0xFA1B24", VA = "0xFA1B24")]
	private static bool UpdateTransforms(Transform[] joints, ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xFA1DEC", Offset = "0xFA1DEC", VA = "0xFA1DEC")]
	private static void OrderJoints(Transform transform, List<Transform> joints)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xFA1ED8", Offset = "0xFA1ED8", VA = "0xFA1ED8")]
	private void AvatarSpecificationCallback(IntPtr avatarSpecification)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xFA28F8", Offset = "0xFA28F8", VA = "0xFA28F8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xFA2D84", Offset = "0xFA2D84", VA = "0xFA2D84")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xFA380C", Offset = "0xFA380C", VA = "0xFA380C")]
	public static ovrAvatarHandInputState CreateInputState(ovrAvatarTransform transform, OvrAvatarDriver.ControllerPose pose)
	{
		return default(ovrAvatarHandInputState);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xFA3860", Offset = "0xFA3860", VA = "0xFA3860")]
	public void ShowControllers(bool show)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xFA213C", Offset = "0xFA213C", VA = "0xFA213C")]
	public void ShowLeftController(bool show)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xFA21D8", Offset = "0xFA21D8", VA = "0xFA21D8")]
	public void ShowRightController(bool show)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xFA3890", Offset = "0xFA3890", VA = "0xFA3890")]
	public void UpdateVoiceVisualization(float[] voiceSamples)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xFA30EC", Offset = "0xFA30EC", VA = "0xFA30EC")]
	private void RecordFrame()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xFA3AD4", Offset = "0xFA3AD4", VA = "0xFA3AD4")]
	private void RecordUnityFrame()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xFA38F8", Offset = "0xFA38F8", VA = "0xFA38F8")]
	private void RecordSDKFrame()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xFA45A4", Offset = "0xFA45A4", VA = "0xFA45A4")]
	private void AddRenderParts(OvrAvatarComponent ovrComponent, ovrAvatarComponent component, Transform parent)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xFA49A8", Offset = "0xFA49A8", VA = "0xFA49A8")]
	public void RefreshBodyParts()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xFA4D30", Offset = "0xFA4D30", VA = "0xFA4D30")]
	public ovrAvatarBodyComponent? GetBodyComponent()
	{
		return null;
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xFA4E70", Offset = "0xFA4E70", VA = "0xFA4E70")]
	public Transform GetHandTransform(HandType hand, HandJoint joint)
	{
		return null;
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xFA5028", Offset = "0xFA5028", VA = "0xFA5028")]
	public void GetPointingDirection(HandType hand, ref Vector3 forward, ref Vector3 up)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xFA3308", Offset = "0xFA3308", VA = "0xFA3308")]
	private void UpdateVoiceBehavior()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xFA5100", Offset = "0xFA5100", VA = "0xFA5100")]
	private bool IsValidMic()
	{
		return default(bool);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xFA30FC", Offset = "0xFA30FC", VA = "0xFA30FC")]
	private void InitPostLoad()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xFA51F4", Offset = "0xFA51F4", VA = "0xFA51F4")]
	private static void ExpressiveGlobalInit()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xFA57FC", Offset = "0xFA57FC", VA = "0xFA57FC")]
	private static void InitializeLights()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xFA5CBC", Offset = "0xFA5CBC", VA = "0xFA5CBC")]
	private static ovrAvatarLight CreateLightDirectional(uint id, Vector3 direction, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xFA5D34", Offset = "0xFA5D34", VA = "0xFA5D34")]
	private static ovrAvatarLight CreateLightPoint(uint id, Vector3 position, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xFA5DB0", Offset = "0xFA5DB0", VA = "0xFA5DB0")]
	private static ovrAvatarLight CreateLightSpot(uint id, Vector3 position, Vector3 direction, float spotAngleDeg, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xFA36A0", Offset = "0xFA36A0", VA = "0xFA36A0")]
	private void UpdateExpressive()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xFA52BC", Offset = "0xFA52BC", VA = "0xFA52BC")]
	private void ConfigureHelpers()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xFA6258", Offset = "0xFA6258", VA = "0xFA6258")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA703C0", Offset = "0xA703C0")]
	private IEnumerator WaitForMouthAudioSource()
	{
		return null;
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xFA6300", Offset = "0xFA6300", VA = "0xFA6300")]
	public void DestroyHelperObjects()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xFA60FC", Offset = "0xFA60FC", VA = "0xFA60FC")]
	public GameObject CreateHelperObject(Transform parent, Vector3 localPositionOffset, string helperName, string helperTag = "")
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xFA63C8", Offset = "0xFA63C8", VA = "0xFA63C8")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xFA64B4", Offset = "0xFA64B4", VA = "0xFA64B4")]
	public void UpdateVoiceData(float[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xFA5E80", Offset = "0xFA5E80", VA = "0xFA5E80")]
	private void UpdateFacewave()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xFA65A0", Offset = "0xFA65A0", VA = "0xFA65A0")]
	public OvrAvatar()
	{
	}
}
[Token(Token = "0x2000033")]
public class OvrAvatarAsset
{
	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong assetID;

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xFA6958", Offset = "0xFA6958", VA = "0xFA6958")]
	public OvrAvatarAsset()
	{
	}
}
[Token(Token = "0x2000034")]
public class OvrAvatarAssetMesh : OvrAvatarAsset
{
	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mesh mesh;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ovrAvatarSkinnedMeshPose skinnedBindPose;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string[] jointNames;

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xFA6A14", Offset = "0xFA6A14", VA = "0xFA6A14")]
	public OvrAvatarAssetMesh(ulong _assetId, IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xFA7D1C", Offset = "0xFA7D1C", VA = "0xFA7D1C")]
	private void LoadSubmeshes(IntPtr asset, IntPtr indexBufferPtr, ulong indexCount)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xFA78C0", Offset = "0xFA78C0", VA = "0xFA78C0")]
	private void LoadBlendShapes(IntPtr asset, long vertexCount)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xFA7658", Offset = "0xFA7658", VA = "0xFA7658")]
	private void SetSkinnedBindPose(IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xFA7734", Offset = "0xFA7734", VA = "0xFA7734")]
	private void GetVertexAndIndexData(IntPtr asset, ovrAvatarAssetType meshType, out long vertexCount, out IntPtr vertexBuffer, out uint indexCount, out IntPtr indexBuffer)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xFA7F80", Offset = "0xFA7F80", VA = "0xFA7F80")]
	public SkinnedMeshRenderer CreateSkinnedMeshRendererOnObject(GameObject target)
	{
		return null;
	}
}
[Token(Token = "0x2000035")]
public class OvrAvatarAssetTexture : OvrAvatarAsset
{
	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D texture;

	[Token(Token = "0x40000F9")]
	private const int ASTCHeaderSize = 16;

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xFA8540", Offset = "0xFA8540", VA = "0xFA8540")]
	public OvrAvatarAssetTexture(ulong _assetId, IntPtr asset)
	{
	}
}
[Token(Token = "0x2000036")]
public class OvrAvatarBase : OvrAvatarComponent
{
	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ovrAvatarBaseComponent component;

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xFA87B8", Offset = "0xFA87B8", VA = "0xFA87B8")]
	private void Update()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xFA8BC4", Offset = "0xFA8BC4", VA = "0xFA8BC4")]
	public OvrAvatarBase()
	{
	}
}
[Token(Token = "0x2000037")]
public class OvrAvatarBody : OvrAvatarComponent
{
	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ovrAvatarBodyComponent component;

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xFA4BD4", Offset = "0xFA4BD4", VA = "0xFA4BD4")]
	public ovrAvatarComponent? GetNativeAvatarComponent()
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xFA8CD8", Offset = "0xFA8CD8", VA = "0xFA8CD8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xFA8E00", Offset = "0xFA8E00", VA = "0xFA8E00")]
	public OvrAvatarBody()
	{
	}
}
[Token(Token = "0x2000038")]
public class OvrAvatarComponent : MonoBehaviour
{
	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string[] LayerKeywords;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string[] LayerSampleModeParameters;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string[] LayerBlendModeParameters;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string[] LayerMaskTypeParameters;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly string[] LayerColorParameters;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly string[] LayerSurfaceParameters;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly string[] LayerSampleParametersParameters;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static readonly string[] LayerMaskParametersParameters;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static readonly string[] LayerMaskAxisParameters;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<Material, ovrAvatarMaterialState> materialStates;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<OvrAvatarRenderComponent> RenderParts;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected OvrAvatar owner;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected ovrAvatarComponent nativeAvatarComponent;

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xFA8E64", Offset = "0xFA8E64", VA = "0xFA8E64")]
	public void SetOvrAvatarOwner(OvrAvatar ovrAvatarOwner)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xFA88E0", Offset = "0xFA88E0", VA = "0xFA88E0")]
	public void UpdateAvatar(IntPtr nativeComponent)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xFA9088", Offset = "0xFA9088", VA = "0xFA9088")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xFA90E8", Offset = "0xFA90E8", VA = "0xFA90E8")]
	public void UpdateAvatarMaterial(Material mat, ovrAvatarMaterialState matState)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xFA98CC", Offset = "0xFA98CC", VA = "0xFA98CC")]
	public static Texture2D GetLoadedTexture(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xFA8C28", Offset = "0xFA8C28", VA = "0xFA8C28")]
	public OvrAvatarComponent()
	{
	}
}
[Token(Token = "0x2000039")]
public abstract class OvrAvatarDriver : MonoBehaviour
{
	[Token(Token = "0x2000132")]
	public enum PacketMode
	{
		[Token(Token = "0x40006D1")]
		SDK,
		[Token(Token = "0x40006D2")]
		Unity
	}

	[Token(Token = "0x2000133")]
	public struct ControllerPose
	{
		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarButton buttons;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ovrAvatarTouch touches;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 joystickPosition;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float indexTrigger;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float handTrigger;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isActive;

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xFAAF40", Offset = "0xFAAF40", VA = "0xFAAF40")]
		public static ControllerPose Interpolate(ControllerPose a, ControllerPose b, float t)
		{
			return default(ControllerPose);
		}
	}

	[Token(Token = "0x2000134")]
	public struct PoseFrame
	{
		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 headPosition;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Quaternion headRotation;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 handLeftPosition;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Quaternion handLeftRotation;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 handRightPosition;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Quaternion handRightRotation;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float voiceAmplitude;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ControllerPose controllerLeftPose;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public ControllerPose controllerRightPose;

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xFA4080", Offset = "0xFA4080", VA = "0xFA4080")]
		public static PoseFrame Interpolate(PoseFrame a, PoseFrame b, float t)
		{
			return default(PoseFrame);
		}
	}

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PacketMode Mode;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected PoseFrame CurrentPose;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private ovrAvatarControllerType ControllerType;

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xFAAE8C", Offset = "0xFAAE8C", VA = "0xFAAE8C")]
	public PoseFrame GetCurrentPose()
	{
		return default(PoseFrame);
	}

	[Token(Token = "0x600012A")]
	public abstract void UpdateTransforms(IntPtr sdkAvatar);

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xFAAE9C", Offset = "0xFAAE9C", VA = "0xFAAE9C")]
	private void Start()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xFA2274", Offset = "0xFA2274", VA = "0xFA2274")]
	public void UpdateTransformsFromPose(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xFAAF28", Offset = "0xFAAF28", VA = "0xFAAF28")]
	public static bool GetIsTrackedRemote()
	{
		return default(bool);
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xFAAF30", Offset = "0xFAAF30", VA = "0xFAAF30")]
	protected OvrAvatarDriver()
	{
	}
}
[Token(Token = "0x200003A")]
public class OvrAvatarHand : OvrAvatarComponent
{
	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarHandComponent component;

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xFAB09C", Offset = "0xFAB09C", VA = "0xFAB09C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xFAB204", Offset = "0xFAB204", VA = "0xFAB204")]
	public OvrAvatarHand()
	{
	}
}
[Token(Token = "0x200003B")]
public class OvrAvatarLocalDriver : OvrAvatarDriver
{
	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 centerEyePosition;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion centerEyeRotation;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xFAB270", Offset = "0xFAB270", VA = "0xFAB270")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xFAB3DC", Offset = "0xFAB3DC", VA = "0xFAB3DC")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xFAB780", Offset = "0xFAB780", VA = "0xFAB780")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xFAB99C", Offset = "0xFAB99C", VA = "0xFAB99C", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xFAB9C8", Offset = "0xFAB9C8", VA = "0xFAB9C8")]
	public OvrAvatarLocalDriver()
	{
	}
}
[Token(Token = "0x200003C")]
public class OvrAvatarMaterialManager : MonoBehaviour
{
	[Token(Token = "0x2000135")]
	public enum TextureType
	{
		[Token(Token = "0x40006E3")]
		DiffuseTextures,
		[Token(Token = "0x40006E4")]
		NormalMaps,
		[Token(Token = "0x40006E5")]
		RoughnessMaps,
		[Token(Token = "0x40006E6")]
		Count
	}

	[Token(Token = "0x2000136")]
	public struct AvatarComponentMaterialProperties
	{
		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarBodyPartType TypeIndex;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Color Color;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D[] Textures;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DiffuseIntensity;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RimIntensity;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ReflectionIntensity;
	}

	[Token(Token = "0x2000137")]
	public struct AvatarTextureArrayProperties
	{
		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture2D[] Textures;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2DArray TextureArray;
	}

	[Token(Token = "0x2000138")]
	public struct AvatarMaterialPropertyBlock
	{
		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector4[] Colors;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] DiffuseIntensities;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] RimIntensities;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] ReflectionIntensities;
	}

	[Serializable]
	[Token(Token = "0x2000139")]
	public class AvatarMaterialConfig
	{
		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AvatarComponentMaterialProperties[] ComponentMaterialProperties;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AvatarMaterialPropertyBlock MaterialPropertyBlock;

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xFADA3C", Offset = "0xFADA3C", VA = "0xFADA3C")]
		public AvatarMaterialConfig()
		{
		}
	}

	[Token(Token = "0x200013A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CE54", Offset = "0xA6CE54")]
	private sealed class <RunLoadingAnimation>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatarMaterialManager <>4__this;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action callBack;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <srcBlend>5__2;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <dstBlend>5__3;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string <lightModeTag>5__4;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <renderTypeTag>5__5;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <renderQueueTag>5__6;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string <ignoreProjectorTag>5__7;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int <renderQueue>5__8;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool <transparentQueue>5__9;

		[Token(Token = "0x170000AE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0xFAE3EC", Offset = "0xFAE3EC", VA = "0xFAE3EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0xFAE454", Offset = "0xFAE454", VA = "0xFAE454", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xFAD850", Offset = "0xFAD850", VA = "0xFAD850")]
		[DebuggerHidden]
		public <RunLoadingAnimation>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xFADD78", Offset = "0xFADD78", VA = "0xFADD78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xFADD7C", Offset = "0xFADD7C", VA = "0xFADD7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xFAE3F4", Offset = "0xFAE3F4", VA = "0xFAE3F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer TargetRenderer;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AvatarTextureArrayProperties[] TextureArrays;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string[] TextureTypeToShaderProperties;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AvatarMaterialConfig LocalAvatarConfig;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<ReflectionProbeBlendInfo> ReflectionProbes;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader CombinedShader;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string AVATAR_SHADER_LOADER;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string AVATAR_SHADER_MAINTEX;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string AVATAR_SHADER_NORMALMAP;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string AVATAR_SHADER_ROUGHNESSMAP;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static string AVATAR_SHADER_COLOR;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string AVATAR_SHADER_DIFFUSEINTENSITY;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static string AVATAR_SHADER_RIMINTENSITY;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string AVATAR_SHADER_REFLECTIONINTENSITY;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string AVATAR_SHADER_CUBEMAP;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static string AVATAR_SHADER_ALPHA;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static string AVATAR_SHADER_LOADING_DIMMER;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static string AVATAR_SHADER_IRIS_COLOR;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static string AVATAR_SHADER_LIP_COLOR;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static string AVATAR_SHADER_BROW_COLOR;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static string AVATAR_SHADER_LASH_COLOR;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static string AVATAR_SHADER_SCLERA_COLOR;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static string AVATAR_SHADER_GUM_COLOR;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static string AVATAR_SHADER_TEETH_COLOR;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static string AVATAR_SHADER_LIP_SMOOTHNESS;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static float[] DiffuseIntensities;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static float[] RimIntensities;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static float[] ReflectionIntensities;

	[Token(Token = "0x400012D")]
	private const float LOADING_ANIMATION_AMPLITUDE = 0.5f;

	[Token(Token = "0x400012E")]
	private const float LOADING_ANIMATION_PERIOD = 0.35f;

	[Token(Token = "0x400012F")]
	private const float LOADING_ANIMATION_CURVE_SCALE = 0.25f;

	[Token(Token = "0x4000130")]
	private const float LOADING_ANIMATION_DIMMER_MIN = 0.3f;

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xFABA78", Offset = "0xFABA78", VA = "0xFABA78")]
	public void CreateTextureArrays()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xFABC2C", Offset = "0xFABC2C", VA = "0xFABC2C")]
	public void SetRenderer(Renderer renderer)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xFABC6C", Offset = "0xFABC6C", VA = "0xFABC6C")]
	public void OnCombinedMeshReady()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xFAC3BC", Offset = "0xFAC3BC", VA = "0xFAC3BC")]
	public void AddTextureIDToTextureManager(ulong assetID, bool isSingleComponent)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xFAC4A4", Offset = "0xFAC4A4", VA = "0xFAC4A4")]
	private void DeleteTextureSet()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xFABD00", Offset = "0xFABD00", VA = "0xFABD00")]
	public void InitTextureArrays()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xFAC4F0", Offset = "0xFAC4F0", VA = "0xFAC4F0")]
	private void ProcessTexturesWithMips(Texture2D[] textures, int texArrayResolution, Texture2DArray texArray)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xFAC11C", Offset = "0xFAC11C", VA = "0xFAC11C")]
	private void SetMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xFAC5D8", Offset = "0xFAC5D8", VA = "0xFAC5D8")]
	private void ApplyMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xFAC850", Offset = "0xFAC850", VA = "0xFAC850")]
	public static ovrAvatarBodyPartType GetComponentType(string objectName)
	{
		return default(ovrAvatarBodyPartType);
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xFAC94C", Offset = "0xFAC94C", VA = "0xFAC94C")]
	private ulong GetTextureIDForType(ovrAvatarPBSMaterialState materialState, TextureType type)
	{
		return default(ulong);
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xFAC984", Offset = "0xFAC984", VA = "0xFAC984")]
	public void ValidateTextures(ovrAvatarPBSMaterialState[] materialStates)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xFAC324", Offset = "0xFAC324", VA = "0xFAC324")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA70424", Offset = "0xA70424")]
	private IEnumerator RunLoadingAnimation(Action callBack)
	{
		return null;
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xFAD87C", Offset = "0xFAD87C", VA = "0xFAD87C")]
	public OvrAvatarMaterialManager()
	{
	}
}
[Token(Token = "0x200003D")]
public class OvrAvatarPacket
{
	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr ovrNativePacket;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<float> frameTimes;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<OvrAvatarDriver.PoseFrame> frames;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<byte[]> encodedAudioPackets;

	[Token(Token = "0x17000013")]
	public float Duration
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0xFA3EC0", Offset = "0xFA3EC0", VA = "0xFA3EC0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000014")]
	public OvrAvatarDriver.PoseFrame FinalFrame
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0xFA3FFC", Offset = "0xFA3FFC", VA = "0xFA3FFC")]
		get
		{
			return default(OvrAvatarDriver.PoseFrame);
		}
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xFA44BC", Offset = "0xFA44BC", VA = "0xFA44BC")]
	public OvrAvatarPacket()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xFA3D50", Offset = "0xFA3D50", VA = "0xFA3D50")]
	public OvrAvatarPacket(OvrAvatarDriver.PoseFrame initialPose)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xFAE45C", Offset = "0xFAE45C", VA = "0xFAE45C")]
	private OvrAvatarPacket(List<float> frameTimes, List<OvrAvatarDriver.PoseFrame> frames, List<byte[]> audioPackets)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xFA3F2C", Offset = "0xFA3F2C", VA = "0xFA3F2C")]
	public void AddFrame(OvrAvatarDriver.PoseFrame frame, float deltaSeconds)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xFAE584", Offset = "0xFAE584", VA = "0xFAE584")]
	public OvrAvatarDriver.PoseFrame GetPoseFrame(float seconds)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xFAE78C", Offset = "0xFAE78C", VA = "0xFAE78C")]
	public static OvrAvatarPacket Read(Stream stream)
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xFAE9E4", Offset = "0xFAE9E4", VA = "0xFAE9E4")]
	public void Write(Stream stream)
	{
	}
}
[Token(Token = "0x200003E")]
internal static class BinaryWriterExtensions
{
	[Token(Token = "0x600014E")]
	[Address(RVA = "0xD9FB68", Offset = "0xD9FB68", VA = "0xD9FB68")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.PoseFrame frame)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xD9FC7C", Offset = "0xD9FC7C", VA = "0xD9FC7C")]
	public static void Write(this BinaryWriter writer, Vector3 vec3)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xD9FE28", Offset = "0xD9FE28", VA = "0xD9FE28")]
	public static void Write(this BinaryWriter writer, Vector2 vec2)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xD9FCEC", Offset = "0xD9FCEC", VA = "0xD9FCEC")]
	public static void Write(this BinaryWriter writer, Quaternion quat)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xD9FD80", Offset = "0xD9FD80", VA = "0xD9FD80")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.ControllerPose pose)
	{
	}
}
[Token(Token = "0x200003F")]
internal static class BinaryReaderExtensions
{
	[Token(Token = "0x6000153")]
	[Address(RVA = "0xD9F768", Offset = "0xD9F768", VA = "0xD9F768")]
	public static OvrAvatarDriver.PoseFrame ReadPoseFrame(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xD9FB0C", Offset = "0xD9FB0C", VA = "0xD9FB0C")]
	public static Vector2 ReadVector2(this BinaryReader reader)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xD9F908", Offset = "0xD9F908", VA = "0xD9F908")]
	public static Vector3 ReadVector3(this BinaryReader reader)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xD9F980", Offset = "0xD9F980", VA = "0xD9F980")]
	public static Quaternion ReadQuaternion(this BinaryReader reader)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xD9FA1C", Offset = "0xD9FA1C", VA = "0xD9FA1C")]
	public static OvrAvatarDriver.ControllerPose ReadControllerPose(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.ControllerPose);
	}
}
[Token(Token = "0x2000040")]
public class OvrAvatarRemoteDriver : OvrAvatarDriver
{
	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Queue<OvrAvatarPacket> packetQueue;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private IntPtr CurrentSDKPacket;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float CurrentPacketTime;

	[Token(Token = "0x4000138")]
	private const int MinPacketQueue = 1;

	[Token(Token = "0x4000139")]
	private const int MaxPacketQueue = 4;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int CurrentSequence;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool isStreaming;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private OvrAvatarPacket currentPacket;

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xFAEBD4", Offset = "0xFAEBD4", VA = "0xFAEBD4")]
	public void QueuePacket(int sequence, OvrAvatarPacket packet)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xFAEC60", Offset = "0xFAEC60", VA = "0xFAEC60", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xFAEC7C", Offset = "0xFAEC7C", VA = "0xFAEC7C")]
	private void UpdateFromSDKPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xFAEE28", Offset = "0xFAEE28", VA = "0xFAEE28")]
	private void UpdateFromUnityPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xFAF00C", Offset = "0xFAF00C", VA = "0xFAF00C")]
	public OvrAvatarRemoteDriver()
	{
	}
}
[Token(Token = "0x2000041")]
public class OvrAvatarRenderComponent : MonoBehaviour
{
	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool firstSkinnedUpdate;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SkinnedMeshRenderer mesh;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] bones;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isBodyComponent;

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xFAF09C", Offset = "0xFAF09C", VA = "0xFAF09C")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xFAF180", Offset = "0xFAF180", VA = "0xFAF180")]
	protected SkinnedMeshRenderer CreateSkinnedMesh(ulong assetID, ovrAvatarVisibilityFlags visibilityMask, int thirdPersonLayer, int firstPersonLayer)
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xFAF374", Offset = "0xFAF374", VA = "0xFAF374")]
	protected void UpdateSkinnedMesh(OvrAvatar avatar, Transform[] bones, ovrAvatarTransform localTransform, ovrAvatarVisibilityFlags visibilityMask, IntPtr renderPart)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xFAF700", Offset = "0xFAF700", VA = "0xFAF700")]
	protected Material CreateAvatarMaterial(string name, Shader shader)
	{
		return null;
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xFAF7F8", Offset = "0xFAF7F8", VA = "0xFAF7F8")]
	public OvrAvatarRenderComponent()
	{
	}
}
[Token(Token = "0x2000042")]
[Flags]
public enum ovrAvatarCapabilities
{
	[Token(Token = "0x4000142")]
	Body = 1,
	[Token(Token = "0x4000143")]
	Hands = 2,
	[Token(Token = "0x4000144")]
	Base = 4,
	[Token(Token = "0x4000145")]
	BodyTilt = 0x10,
	[Token(Token = "0x4000146")]
	Expressive = 0x20,
	[Token(Token = "0x4000147")]
	All = -1
}
[Token(Token = "0x2000043")]
public enum ovrAvatarMessageType
{
	[Token(Token = "0x4000149")]
	AvatarSpecification,
	[Token(Token = "0x400014A")]
	AssetLoaded,
	[Token(Token = "0x400014B")]
	Count
}
[Token(Token = "0x2000044")]
public struct ovrAvatarMessage_AvatarSpecification
{
	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public IntPtr avatarSpec;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ulong oculusUserID;
}
[Token(Token = "0x2000045")]
public struct ovrAvatarMessage_AssetLoaded
{
	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ulong assetID;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr asset;
}
[Token(Token = "0x2000046")]
public enum ovrAvatarAssetType
{
	[Token(Token = "0x4000151")]
	Mesh,
	[Token(Token = "0x4000152")]
	Texture,
	[Token(Token = "0x4000153")]
	Pose,
	[Token(Token = "0x4000154")]
	Material,
	[Token(Token = "0x4000155")]
	CombinedMesh,
	[Token(Token = "0x4000156")]
	PBSMaterial,
	[Token(Token = "0x4000157")]
	FailedLoad,
	[Token(Token = "0x4000158")]
	Count
}
[Token(Token = "0x2000047")]
public struct ovrAvatarMeshVertex
{
	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public byte[] blendIndices;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float[] blendWeights;
}
[Token(Token = "0x2000048")]
public struct ovrAvatarMeshVertexV2
{
	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float r;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float g;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float b;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float a;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public byte[] blendIndices;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float[] blendWeights;
}
[Token(Token = "0x2000049")]
public struct ovrAvatarBlendVertex
{
	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;
}
[Token(Token = "0x200004A")]
public struct ovrAvatarMeshAssetData
{
	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x200004B")]
public struct ovrAvatarMeshAssetDataV2
{
	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x200004C")]
public enum ovrAvatarTextureFormat
{
	[Token(Token = "0x400018D")]
	RGB24,
	[Token(Token = "0x400018E")]
	DXT1,
	[Token(Token = "0x400018F")]
	DXT5,
	[Token(Token = "0x4000190")]
	ASTC_RGB_6x6,
	[Token(Token = "0x4000191")]
	ASTC_RGB_6x6_MIPMAPS,
	[Token(Token = "0x4000192")]
	Count
}
[Token(Token = "0x200004D")]
public struct ovrAvatarTextureAssetData
{
	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTextureFormat format;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint sizeX;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public uint sizeY;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public uint mipCount;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong textureDataSize;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr textureData;
}
[Token(Token = "0x200004E")]
public enum ovrAvatarRenderPartType
{
	[Token(Token = "0x400019A")]
	SkinnedMeshRender,
	[Token(Token = "0x400019B")]
	SkinnedMeshRenderPBS,
	[Token(Token = "0x400019C")]
	ProjectorRender,
	[Token(Token = "0x400019D")]
	SkinnedMeshRenderPBS_V2,
	[Token(Token = "0x400019E")]
	Count
}
[Token(Token = "0x200004F")]
public enum ovrAvatarLogLevel
{
	[Token(Token = "0x40001A0")]
	Unknown,
	[Token(Token = "0x40001A1")]
	Default,
	[Token(Token = "0x40001A2")]
	Verbose,
	[Token(Token = "0x40001A3")]
	Debug,
	[Token(Token = "0x40001A4")]
	Info,
	[Token(Token = "0x40001A5")]
	Warn,
	[Token(Token = "0x40001A6")]
	Error,
	[Token(Token = "0x40001A7")]
	Fatal,
	[Token(Token = "0x40001A8")]
	Silent
}
[Token(Token = "0x2000050")]
public struct ovrAvatarTransform
{
	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 position;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Quaternion orientation;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 scale;
}
[Token(Token = "0x2000051")]
[Flags]
public enum ovrAvatarButton
{
	[Token(Token = "0x40001AD")]
	One = 1,
	[Token(Token = "0x40001AE")]
	Two = 2,
	[Token(Token = "0x40001AF")]
	Three = 4,
	[Token(Token = "0x40001B0")]
	Joystick = 8
}
[Token(Token = "0x2000052")]
[Flags]
public enum ovrAvatarTouch
{
	[Token(Token = "0x40001B2")]
	One = 1,
	[Token(Token = "0x40001B3")]
	Two = 2,
	[Token(Token = "0x40001B4")]
	Joystick = 4,
	[Token(Token = "0x40001B5")]
	ThumbRest = 8,
	[Token(Token = "0x40001B6")]
	Index = 0x10,
	[Token(Token = "0x40001B7")]
	Pointing = 0x40,
	[Token(Token = "0x40001B8")]
	ThumbUp = 0x80
}
[Token(Token = "0x2000053")]
public struct ovrAvatarHandInputState
{
	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarButton buttonMask;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public ovrAvatarTouch touchMask;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float joystickX;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float joystickY;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float indexTrigger;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float handTrigger;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isActive;
}
[Token(Token = "0x2000054")]
public struct ovrAvatarComponent
{
	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint renderPartCount;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr renderParts;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string name;
}
[Token(Token = "0x2000055")]
internal struct ovrAvatarComponent_Offsets
{
	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long transform;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int renderPartCount;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int renderParts;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int name;
}
[Token(Token = "0x2000056")]
public struct ovrAvatarBaseComponent
{
	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 basePosition;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr renderComponent;
}
[Token(Token = "0x2000057")]
public struct ovrAvatarBodyComponent
{
	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform leftEyeTransform;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarTransform rightEyeTransform;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ovrAvatarTransform centerEyeTransform;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public IntPtr renderComponent;
}
[Token(Token = "0x2000058")]
public struct ovrAvatarBodyComponent_Offsets
{
	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long leftEyeTransform;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long rightEyeTransform;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long centerEyeTransform;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long renderComponent;
}
[Token(Token = "0x2000059")]
public struct ovrAvatarControllerComponent
{
	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200005A")]
public struct ovrAvatarHandComponent
{
	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200005B")]
public enum ovrAvatarMaterialLayerBlendMode
{
	[Token(Token = "0x40001D8")]
	Add,
	[Token(Token = "0x40001D9")]
	Multiply,
	[Token(Token = "0x40001DA")]
	Count
}
[Token(Token = "0x200005C")]
public enum ovrAvatarMaterialLayerSampleMode
{
	[Token(Token = "0x40001DC")]
	Color,
	[Token(Token = "0x40001DD")]
	Texture,
	[Token(Token = "0x40001DE")]
	TextureSingleChannel,
	[Token(Token = "0x40001DF")]
	Parallax,
	[Token(Token = "0x40001E0")]
	Count
}
[Token(Token = "0x200005D")]
public enum ovrAvatarMaterialMaskType
{
	[Token(Token = "0x40001E2")]
	None,
	[Token(Token = "0x40001E3")]
	Positional,
	[Token(Token = "0x40001E4")]
	ViewReflection,
	[Token(Token = "0x40001E5")]
	Fresnel,
	[Token(Token = "0x40001E6")]
	Pulse,
	[Token(Token = "0x40001E7")]
	Count
}
[Token(Token = "0x200005E")]
public enum ovrAvatarControllerType
{
	[Token(Token = "0x40001E9")]
	Touch,
	[Token(Token = "0x40001EA")]
	Malibu,
	[Token(Token = "0x40001EB")]
	Go,
	[Token(Token = "0x40001EC")]
	Quest,
	[Token(Token = "0x40001ED")]
	Count
}
[Token(Token = "0x200005F")]
public enum ovrAvatarAssetLevelOfDetail
{
	[Token(Token = "0x40001EF")]
	Lowest = 1,
	[Token(Token = "0x40001F0")]
	Medium = 3,
	[Token(Token = "0x40001F1")]
	Highest = 5
}
[Token(Token = "0x2000060")]
public enum ovrAvatarLookAndFeelVersion
{
	[Token(Token = "0x40001F3")]
	Unknown = -1,
	[Token(Token = "0x40001F4")]
	One,
	[Token(Token = "0x40001F5")]
	Two
}
[Token(Token = "0x2000061")]
public struct ovrAvatarMaterialLayerState
{
	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarMaterialLayerBlendMode blendMode;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarMaterialMaskType maskType;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector4 layerColor;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector4 sampleParameters;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong sampleTexture;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector4 sampleScaleOffset;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector4 maskParameters;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 maskAxis;

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xDCE474", Offset = "0xDCE474", VA = "0xDCE474")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xB4CC94", Offset = "0xB4CC94", VA = "0xB4CC94", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xB4CC9C", Offset = "0xB4CC9C", VA = "0xB4CC9C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000062")]
public struct ovrAvatarMaterialState
{
	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarMaterialMaskType baseMaskType;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector4 baseMaskParameters;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector4 baseMaskAxis;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong alphaMaskTextureID;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 alphaMaskScaleOffset;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong normalMapTextureID;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 normalMapScaleOffset;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong parallaxMapTextureID;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Vector4 parallaxMapScaleOffset;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ulong roughnessMapTextureID;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector4 roughnessMapScaleOffset;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public uint layerCount;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public ovrAvatarMaterialLayerState[] layers;

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xDCE7A8", Offset = "0xDCE7A8", VA = "0xDCE7A8")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xB4CED8", Offset = "0xB4CED8", VA = "0xB4CED8", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xB4CEE0", Offset = "0xB4CEE0", VA = "0xB4CEE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000063")]
public struct ovrAvatarExpressiveParameters
{
	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 irisColor;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector4 scleraColor;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector4 lashColor;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector4 browColor;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 lipColor;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector4 teethColor;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector4 gumColor;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float browLashIntensity;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float lipSmoothness;

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xDCDB1C", Offset = "0xDCDB1C", VA = "0xDCDB1C")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xB4C9F4", Offset = "0xB4C9F4", VA = "0xB4C9F4", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xB4C9FC", Offset = "0xB4C9FC", VA = "0xB4C9FC", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000064")]
public struct ovrAvatarPBSMaterialState
{
	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong albedoTextureID;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector4 albedoMultiplier;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ulong metallicnessTextureID;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float glossinessScale;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong normalTextureID;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong heightTextureID;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ulong occlusionTextureID;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong emissionTextureID;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 emissionMultiplier;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong detailMaskTextureID;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ulong detailAlbedoTextureID;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ulong detailNormalTextureID;

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1C5BED4", Offset = "0x1C5BED4", VA = "0x1C5BED4")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xBA5338", Offset = "0xBA5338", VA = "0xBA5338", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xBA5340", Offset = "0xBA5340", VA = "0xBA5340", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000065")]
public class OvrAvatarAssetMaterial : OvrAvatarAsset
{
	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarMaterialState material;

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xFA6960", Offset = "0xFA6960", VA = "0xFA6960")]
	public OvrAvatarAssetMaterial(ulong id, IntPtr mat)
	{
	}
}
[Token(Token = "0x2000066")]
public struct ovrAvatarSkinnedMeshPose
{
	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint jointCount;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarTransform[] jointTransform;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int[] jointParents;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr[] jointNames;
}
[Token(Token = "0x2000067")]
[Flags]
public enum ovrAvatarVisibilityFlags
{
	[Token(Token = "0x400022A")]
	FirstPerson = 1,
	[Token(Token = "0x400022B")]
	ThirdPerson = 2,
	[Token(Token = "0x400022C")]
	SelfOccluding = 4
}
[Token(Token = "0x2000068")]
public struct ovrAvatarRenderPart_SkinnedMeshRender
{
	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarMaterialState materialState;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x2000069")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS
{
	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong albedoTextureAssetID;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong surfaceTextureAssetID;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x200006A")]
public struct ovrAvatarRenderPart_ProjectorRender
{
	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint componentIndex;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public uint renderPartIndex;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ovrAvatarMaterialState materialState;
}
[Token(Token = "0x200006B")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2
{
	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarPBSMaterialState materialState;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x200006C")]
public enum ovrAvatarHandGesture
{
	[Token(Token = "0x4000242")]
	Default,
	[Token(Token = "0x4000243")]
	GripSphere,
	[Token(Token = "0x4000244")]
	GripCube,
	[Token(Token = "0x4000245")]
	Count
}
[Token(Token = "0x200006D")]
public enum ovrAvatarBodyPartType
{
	[Token(Token = "0x4000247")]
	Body,
	[Token(Token = "0x4000248")]
	Clothing,
	[Token(Token = "0x4000249")]
	Eyewear,
	[Token(Token = "0x400024A")]
	Hair,
	[Token(Token = "0x400024B")]
	Beard,
	[Token(Token = "0x400024C")]
	Count
}
[Token(Token = "0x200006E")]
public struct ovrAvatarBlendShapeParams
{
	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint blendShapeParamCount;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] blendShapeParams;
}
[Token(Token = "0x200006F")]
internal struct ovrAvatarBlendShapeParams_Offsets
{
	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int blendShapeParamCount;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long blendShapeParams;
}
[Token(Token = "0x2000070")]
public struct ovrAvatarVisemes
{
	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint visemeParamCount;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] visemeParams;
}
[Token(Token = "0x2000071")]
internal struct ovrAvatarVisemes_Offsets
{
	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int visemeParamCount;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long visemeParams;
}
[Token(Token = "0x2000072")]
public enum ovrAvatarGazeTargetType
{
	[Token(Token = "0x4000256")]
	AvatarHead,
	[Token(Token = "0x4000257")]
	AvatarHand,
	[Token(Token = "0x4000258")]
	Object,
	[Token(Token = "0x4000259")]
	ObjectStatic,
	[Token(Token = "0x400025A")]
	Count
}
[Token(Token = "0x2000073")]
public struct ovrAvatarGazeTarget
{
	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public Vector3 worldPosition;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarGazeTargetType type;
}
[Token(Token = "0x2000074")]
internal struct ovrAvatarGazeTarget_Offsets
{
	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int id;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int worldPosition;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int type;
}
[Token(Token = "0x2000075")]
public struct ovrAvatarGazeTargets
{
	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint targetCount;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarGazeTarget[] targets;
}
[Token(Token = "0x2000076")]
internal struct ovrAvatarGazeTargets_Offsets
{
	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int targetCount;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long targets;
}
[Token(Token = "0x2000077")]
public enum ovrAvatarLightType
{
	[Token(Token = "0x4000266")]
	Point,
	[Token(Token = "0x4000267")]
	Direction,
	[Token(Token = "0x4000268")]
	Spot,
	[Token(Token = "0x4000269")]
	Count
}
[Token(Token = "0x2000078")]
public struct ovrAvatarLight
{
	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarLightType type;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float intensity;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 worldDirection;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 worldPosition;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float range;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float spotAngleDeg;
}
[Token(Token = "0x2000079")]
internal struct ovrAvatarLight_Offsets
{
	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long id;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long type;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long intensity;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long worldDirection;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static long worldPosition;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static long range;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static long spotAngleDeg;
}
[Token(Token = "0x200007A")]
public struct ovrAvatarLights
{
	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float ambientIntensity;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint lightCount;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarLight[] lights;
}
[Token(Token = "0x200007B")]
internal struct ovrAvatarLights_Offsets
{
	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long ambientIntensity;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long lightCount;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long lights;
}
[Token(Token = "0x200007C")]
[Flags]
public enum ovrAvatarDebugContext : uint
{
	[Token(Token = "0x400027F")]
	None = 0u,
	[Token(Token = "0x4000280")]
	GazeTarget = 1u,
	[Token(Token = "0x4000281")]
	Any = uint.MaxValue
}
[Token(Token = "0x200007D")]
public struct ovrAvatarDebugLine
{
	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 startPoint;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 endPoint;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 color;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ovrAvatarDebugContext context;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public IntPtr text;
}
[Token(Token = "0x200007E")]
public struct ovrAvatarDebugTransform
{
	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarDebugContext context;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr text;
}
[Token(Token = "0x200007F")]
public delegate void specificationCallback(IntPtr specification);
[Token(Token = "0x2000080")]
public delegate void assetLoadedCallback(OvrAvatarAsset asset);
[Token(Token = "0x2000081")]
public delegate void combinedMeshLoadedCallback(IntPtr asset);
[Token(Token = "0x2000082")]
public class OvrAvatarSDKManager : MonoBehaviour
{
	[Token(Token = "0x200013B")]
	public struct AvatarSpecRequestParams
	{
		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong _userId;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public specificationCallback _callback;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool _useCombinedMesh;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ovrAvatarAssetLevelOfDetail _lod;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool _forceMobileTextureFormat;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ovrAvatarLookAndFeelVersion _lookVersion;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ovrAvatarLookAndFeelVersion _fallbackVersion;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool _enableExpressive;

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xB56660", Offset = "0xB56660", VA = "0xB56660")]
		public AvatarSpecRequestParams(ulong userId, specificationCallback callback, bool useCombinedMesh, ovrAvatarAssetLevelOfDetail lod, bool forceMobileTextureFormat, ovrAvatarLookAndFeelVersion lookVersion, ovrAvatarLookAndFeelVersion fallbackVersion, bool enableExpressive)
		{
		}
	}

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSDKManager _instance;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool initialized;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<ulong, HashSet<specificationCallback>> specificationCallbacks;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<ulong, HashSet<assetLoadedCallback>> assetLoadedCallbacks;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<IntPtr, combinedMeshLoadedCallback> combinedMeshLoadedCallbacks;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<ulong, OvrAvatarAsset> assetCache;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OvrAvatarTextureCopyManager textureCopyManager;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarLogLevel LoggingLevel;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Queue<AvatarSpecRequestParams> avatarSpecificationQueue;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<int> loadingAvatars;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool avatarSpecRequestAvailable;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float lastDispatchedAvatarSpecRequestTime;

	[Token(Token = "0x4000296")]
	private const float AVATAR_SPEC_REQUEST_TIMEOUT = 5f;

	[Token(Token = "0x17000015")]
	public static OvrAvatarSDKManager Instance
	{
		[Token(Token = "0x6000183")]
		[Address(RVA = "0xFA24C8", Offset = "0xFA24C8", VA = "0xFA24C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xFAF808", Offset = "0xFAF808", VA = "0xFAF808")]
	private bool Initialize()
	{
		return default(bool);
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xFAFA9C", Offset = "0xFAFA9C", VA = "0xFAFA9C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xFAFB10", Offset = "0xFAFB10", VA = "0xFAFB10")]
	private void Update()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xFB0358", Offset = "0xFB0358", VA = "0xFB0358")]
	public bool IsAvatarSpecWaiting()
	{
		return default(bool);
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xFB03B0", Offset = "0xFB03B0", VA = "0xFB03B0")]
	public bool IsAvatarLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xFA2D1C", Offset = "0xFA2D1C", VA = "0xFA2D1C")]
	public void AddLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xFA32A0", Offset = "0xFA32A0", VA = "0xFA32A0")]
	public void RemoveLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xFA2C88", Offset = "0xFA2C88", VA = "0xFA2C88")]
	public void RequestAvatarSpecification(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xFB018C", Offset = "0xFB018C", VA = "0xFB018C")]
	private void DispatchAvatarSpecificationRequest(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xFA26FC", Offset = "0xFA26FC", VA = "0xFA26FC")]
	public void BeginLoadingAsset(ulong assetId, ovrAvatarAssetLevelOfDetail lod, assetLoadedCallback callback)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xFA2818", Offset = "0xFA2818", VA = "0xFA2818")]
	public void RegisterCombinedMeshCallback(IntPtr sdkAvatar, combinedMeshLoadedCallback callback)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xFA267C", Offset = "0xFA267C", VA = "0xFA267C")]
	public OvrAvatarAsset GetAsset(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xFB0408", Offset = "0xFB0408", VA = "0xFB0408")]
	public void DeleteAssetFromCache(ulong assetId)
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xFAFA50", Offset = "0xFAFA50", VA = "0xFAFA50")]
	public string GetAppId()
	{
		return null;
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xFAC420", Offset = "0xFAC420", VA = "0xFAC420")]
	public OvrAvatarTextureCopyManager GetTextureCopyManager()
	{
		return null;
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xFB04E0", Offset = "0xFB04E0", VA = "0xFB04E0")]
	public OvrAvatarSDKManager()
	{
	}
}
[Token(Token = "0x2000083")]
public sealed class OvrAvatarSettings : ScriptableObject
{
	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSettings instance;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string ovrAppID;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string ovrGearAppID;

	[Token(Token = "0x17000016")]
	public static string AppID
	{
		[Token(Token = "0x6000194")]
		[Address(RVA = "0xFB04A0", Offset = "0xFB04A0", VA = "0xFB04A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000195")]
		[Address(RVA = "0xFB0624", Offset = "0xFB0624", VA = "0xFB0624")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public static string MobileAppID
	{
		[Token(Token = "0x6000196")]
		[Address(RVA = "0xFB04C0", Offset = "0xFB04C0", VA = "0xFB04C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000197")]
		[Address(RVA = "0xFB0654", Offset = "0xFB0654", VA = "0xFB0654")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public static OvrAvatarSettings Instance
	{
		[Token(Token = "0x6000198")]
		[Address(RVA = "0xFB04F8", Offset = "0xFB04F8", VA = "0xFB04F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000199")]
		[Address(RVA = "0xFB0684", Offset = "0xFB0684", VA = "0xFB0684")]
		set
		{
		}
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xFB06DC", Offset = "0xFB06DC", VA = "0xFB06DC")]
	public OvrAvatarSettings()
	{
	}
}
[Token(Token = "0x2000084")]
public class OvrAvatarSkinnedMeshRenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Shader surface;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader surfaceSelfOccluding;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool previouslyActive;

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xDB8EBC", Offset = "0xDB8EBC", VA = "0xDB8EBC")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender, Shader surface, Shader surfaceSelfOccluding, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xDB91A0", Offset = "0xDB91A0", VA = "0xDB91A0")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xDB9038", Offset = "0xDB9038", VA = "0xDB9038")]
	private void UpdateMeshMaterial(ovrAvatarVisibilityFlags visibilityMask, SkinnedMeshRenderer rootMesh)
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xDB93D0", Offset = "0xDB93D0", VA = "0xDB93D0")]
	public OvrAvatarSkinnedMeshRenderComponent()
	{
	}
}
[Token(Token = "0x2000085")]
public class OvrAvatarSkinnedMeshRenderPBSComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool isMaterialInitilized;

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xDB93D8", Offset = "0xDB93D8", VA = "0xDB93D8")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS, Shader shader, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xDB952C", Offset = "0xDB952C", VA = "0xDB952C")]
	internal void UpdateSkinnedMeshRenderPBS(OvrAvatar avatar, IntPtr renderPart, Material mat)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xDB96D0", Offset = "0xDB96D0", VA = "0xDB96D0")]
	public OvrAvatarSkinnedMeshRenderPBSComponent()
	{
	}
}
[Token(Token = "0x2000086")]
public class OvrAvatarSkinnedMeshPBSV2RenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private OvrAvatarMaterialManager avatarMaterialManager;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool previouslyActive;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool isCombinedMaterial;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private ovrAvatarExpressiveParameters ExpressiveParameters;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private bool EnableExpressive;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int blendShapeCount;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private ovrAvatarBlendShapeParams blendShapeParams;

	[Token(Token = "0x40002A5")]
	private const string MAIN_MATERIAL_NAME = "main_material";

	[Token(Token = "0x40002A6")]
	private const string EYE_MATERIAL_NAME = "eye_material";

	[Token(Token = "0x40002A7")]
	private const string DEFAULT_MATERIAL_NAME = "_material";

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xFA0950", Offset = "0xFA0950", VA = "0xFA0950")]
	internal void Initialize(IntPtr renderPart, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRender, OvrAvatarMaterialManager materialManager, int thirdPersonLayer, int firstPersonLayer, bool combinedMesh, ovrAvatarAssetLevelOfDetail lod, bool assignExpressiveParams, OvrAvatar avatar, bool isControllerModel)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xFA8E6C", Offset = "0xFA8E6C", VA = "0xFA8E6C")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xFB1244", Offset = "0xFB1244", VA = "0xFB1244")]
	private void InitializeSingleComponentMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xFB097C", Offset = "0xFB097C", VA = "0xFB097C")]
	private void InitializeCombinedMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xFB074C", Offset = "0xFB074C", VA = "0xFB074C")]
	private void SetMaterialTransparent(Material mat)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xFB0860", Offset = "0xFB0860", VA = "0xFB0860")]
	private void SetMaterialOpaque(Material mat)
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xFB1A78", Offset = "0xFB1A78", VA = "0xFB1A78")]
	public OvrAvatarSkinnedMeshPBSV2RenderComponent()
	{
	}
}
[Token(Token = "0x2000087")]
public class OvrAvatarTextureCopyManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200013C")]
	public struct FallbackTextureSet
	{
		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool Initialized;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2D DiffuseRoughness;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D Normal;
	}

	[Token(Token = "0x200013D")]
	private struct CopyTextureParams
	{
		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture Src;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture Dst;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Mip;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int SrcSize;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int DstElement;

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xB4C5F0", Offset = "0xB4C5F0", VA = "0xB4C5F0")]
		public CopyTextureParams(Texture src, Texture dst, int mip, int srcSize, int dstElement)
		{
		}
	}

	[Token(Token = "0x200013E")]
	public struct TextureSet
	{
		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<ulong, bool> TextureIDSingleMeshPair;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool IsProcessed;

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xB4C6C4", Offset = "0xB4C6C4", VA = "0xB4C6C4")]
		public TextureSet(Dictionary<ulong, bool> textureIDSingleMeshPair, bool isProcessed)
		{
		}
	}

	[Token(Token = "0x200013F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CE64", Offset = "0xA6CE64")]
	private sealed class <DeleteTextureSetCoroutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextureSet textureSetToDelete;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public OvrAvatarTextureCopyManager <>4__this;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int gameobjectID;

		[Token(Token = "0x170000B0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0xDBB154", Offset = "0xDBB154", VA = "0xDBB154", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0xDBB1BC", Offset = "0xDBB1BC", VA = "0xDBB1BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xDBAA60", Offset = "0xDBAA60", VA = "0xDBAA60")]
		[DebuggerHidden]
		public <DeleteTextureSetCoroutine>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xDBAC54", Offset = "0xDBAC54", VA = "0xDBAC54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xDBAC58", Offset = "0xDBAC58", VA = "0xDBAC58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xDBB15C", Offset = "0xDBB15C", VA = "0xDBB15C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FallbackTextureSet[] FallbackTextureSets;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Queue<CopyTextureParams> texturesToCopy;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, TextureSet> textureSets;

	[Token(Token = "0x40002AB")]
	private const int TEXTURES_TO_COPY_QUEUE_CAPACITY = 256;

	[Token(Token = "0x40002AC")]
	private const int COPIES_PER_FRAME = 8;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_DIFFUSE_ROUGHNESS;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_NORMAL;

	[Token(Token = "0x40002AF")]
	private const string PATH_HIGHEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_2048";

	[Token(Token = "0x40002B0")]
	private const string PATH_MEDIUM_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_1024";

	[Token(Token = "0x40002B1")]
	private const string PATH_LOWEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_256";

	[Token(Token = "0x40002B2")]
	private const string PATH_HIGHEST_NORMAL = "FallbackTextures/fallback_normal_2048";

	[Token(Token = "0x40002B3")]
	private const string PATH_MEDIUM_NORMAL = "FallbackTextures/fallback_normal_1024";

	[Token(Token = "0x40002B4")]
	private const string PATH_LOWEST_NORMAL = "FallbackTextures/fallback_normal_256";

	[Token(Token = "0x40002B5")]
	private const int GPU_TEXTURE_COPY_WAIT_TIME = 10;

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xDB9E78", Offset = "0xDB9E78", VA = "0xDB9E78")]
	public OvrAvatarTextureCopyManager()
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xDBA2CC", Offset = "0xDBA2CC", VA = "0xDBA2CC")]
	public void Update()
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xDBA4C4", Offset = "0xDBA4C4", VA = "0xDBA4C4")]
	public int GetTextureCount()
	{
		return default(int);
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xDBA514", Offset = "0xDBA514", VA = "0xDBA514")]
	public void CopyTexture(Texture src, Texture dst, int mipLevel, int mipSize, int dstElement, bool useQueue = true)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xDBA434", Offset = "0xDBA434", VA = "0xDBA434")]
	private void CopyTexture(CopyTextureParams copyTextureParams)
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xDBA720", Offset = "0xDBA720", VA = "0xDBA720")]
	public void AddTextureIDToTextureSet(int gameobjectID, ulong textureID, bool isSingleMesh)
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xDBA908", Offset = "0xDBA908", VA = "0xDBA908")]
	public void DeleteTextureSet(int gameobjectID)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xDBA9B0", Offset = "0xDBA9B0", VA = "0xDBA9B0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA70528", Offset = "0xA70528")]
	private IEnumerator DeleteTextureSetCoroutine(TextureSet textureSetToDelete, int gameobjectID)
	{
		return null;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xDBAA8C", Offset = "0xDBAA8C", VA = "0xDBAA8C")]
	public void CheckFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0xDBAAD8", Offset = "0xDBAAD8", VA = "0xDBAAD8")]
	private void InitFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}
}
[Token(Token = "0x2000088")]
public class OvrAvatarTouchController : OvrAvatarComponent
{
	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarControllerComponent component;

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xDBB1C4", Offset = "0xDBB1C4", VA = "0xDBB1C4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xDBB330", Offset = "0xDBB330", VA = "0xDBB330")]
	public OvrAvatarTouchController()
	{
	}
}
[Token(Token = "0x2000089")]
public class EnableSwitch : MonoBehaviour
{
	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] SwitchTargets;

	[Token(Token = "0x60001B5")]
	public bool SetActive<T>(int target) where T : MonoBehaviour
	{
		return default(bool);
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xDA58D0", Offset = "0xDA58D0", VA = "0xDA58D0")]
	public EnableSwitch()
	{
	}
}
[Token(Token = "0x200008A")]
public class LipSyncDemo_Control : MonoBehaviour
{
	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D5D8", Offset = "0xA6D5D8")]
	public KeyCode rotateLeftKey;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D610", Offset = "0xA6D610")]
	public KeyCode rotateRightKey;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D648", Offset = "0xA6D648")]
	public KeyCode resetRotationKey;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float resetRotation;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float rotationAmount;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float rotationMax;

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xDA78CC", Offset = "0xDA78CC", VA = "0xDA78CC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xDA78D0", Offset = "0xDA78D0", VA = "0xDA78D0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0xDA7950", Offset = "0xDA7950", VA = "0xDA7950")]
	private void RotateObject(float amountDegrees, bool absolute = false)
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0xDA7B3C", Offset = "0xDA7B3C", VA = "0xDA7B3C")]
	public LipSyncDemo_Control()
	{
	}
}
[Token(Token = "0x200008B")]
public class LipSyncDemo_SetCurrentTarget : MonoBehaviour
{
	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public EnableSwitch[] SwitchTargets;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int targetSet;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int maxTarget;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool XRButtonBeingPressed;

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0xDA7B6C", Offset = "0xDA7B6C", VA = "0xDA7B6C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xDA7C70", Offset = "0xDA7C70", VA = "0xDA7C70")]
	private void Update()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0xDA7F84", Offset = "0xDA7F84", VA = "0xDA7F84")]
	private void SetCurrentTarget()
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xDA8210", Offset = "0xDA8210", VA = "0xDA8210")]
	private void LocalTouchEventCallback(OVRTouchpad.TouchEvent touchEvent)
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xDA8260", Offset = "0xDA8260", VA = "0xDA8260")]
	public LipSyncDemo_SetCurrentTarget()
	{
	}
}
[Token(Token = "0x200008C")]
public class OVRLipSyncDebugConsole : MonoBehaviour
{
	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ArrayList messages;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int maxMessages;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text textMsg;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OVRLipSyncDebugConsole s_Instance;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool clearTimeoutOn;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float clearTimeout;

	[Token(Token = "0x17000019")]
	public static OVRLipSyncDebugConsole instance
	{
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x158A950", Offset = "0x158A950", VA = "0x158A950")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x158AC10", Offset = "0x158AC10", VA = "0x158AC10")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x158AD54", Offset = "0x158AD54", VA = "0x158AD54")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x158AC88", Offset = "0x158AC88", VA = "0x158AC88")]
	public void Init()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x1588B88", Offset = "0x1588B88", VA = "0x1588B88")]
	public static void Log(string message)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x158AEDC", Offset = "0x158AEDC", VA = "0x158AEDC")]
	public static void Log(string message, Color color)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x1588B20", Offset = "0x1588B20", VA = "0x1588B20")]
	public static void Clear()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x1588C08", Offset = "0x1588C08", VA = "0x1588C08")]
	public static void ClearTimeout(float timeToClear)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x158ADEC", Offset = "0x158ADEC", VA = "0x158ADEC")]
	public void AddMessage(string message, Color color)
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x158AF7C", Offset = "0x158AF7C", VA = "0x158AF7C")]
	public void ClearMessages()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x158AFB8", Offset = "0x158AFB8", VA = "0x158AFB8")]
	public void SetClearTimeout(float timeout)
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x158B1AC", Offset = "0x158B1AC", VA = "0x158B1AC")]
	private void Prune()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x158AFC8", Offset = "0x158AFC8", VA = "0x158AFC8")]
	private void Display()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x158B25C", Offset = "0x158B25C", VA = "0x158B25C")]
	public OVRLipSyncDebugConsole()
	{
	}
}
[Token(Token = "0x200008D")]
public class OVRNamedArrayAttribute : PropertyAttribute
{
	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly string[] names;

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x158BD64", Offset = "0x158BD64", VA = "0x158BD64")]
	public OVRNamedArrayAttribute(string[] names)
	{
	}
}
[Token(Token = "0x200008E")]
public static class OVRTouchpad
{
	[Token(Token = "0x2000140")]
	public enum TouchEvent
	{
		[Token(Token = "0x4000719")]
		SingleTap,
		[Token(Token = "0x400071A")]
		DoubleTap,
		[Token(Token = "0x400071B")]
		Left,
		[Token(Token = "0x400071C")]
		Right,
		[Token(Token = "0x400071D")]
		Up,
		[Token(Token = "0x400071E")]
		Down
	}

	[Token(Token = "0x2000141")]
	public delegate void OVRTouchpadCallback<TouchEvent>(TouchEvent arg);

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector3 moveAmountMouse;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static float minMovMagnitudeMouse;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Delegate touchPadCallbacks;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static OVRTouchpadHelper touchpadHelper;

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xF82500", Offset = "0xF82500", VA = "0xF82500")]
	public static void Create()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xF82504", Offset = "0xF82504", VA = "0xF82504")]
	public static void Update()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xF82824", Offset = "0xF82824", VA = "0xF82824")]
	public static void OnDisable()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xF82674", Offset = "0xF82674", VA = "0xF82674")]
	private static void HandleInputMouse(ref Vector3 move)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xF82828", Offset = "0xF82828", VA = "0xF82828")]
	public static void AddListener(OVRTouchpadCallback<TouchEvent> handler)
	{
	}
}
[Token(Token = "0x200008F")]
public sealed class OVRTouchpadHelper : MonoBehaviour
{
	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xF829B8", Offset = "0xF829B8", VA = "0xF829B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xF82A34", Offset = "0xF82A34", VA = "0xF82A34")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xF82ACC", Offset = "0xF82ACC", VA = "0xF82ACC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xF82B28", Offset = "0xF82B28", VA = "0xF82B28")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xF82B8C", Offset = "0xF82B8C", VA = "0xF82B8C")]
	private void LocalTouchEventCallback(OVRTouchpad.TouchEvent touchEvent)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xF82B90", Offset = "0xF82B90", VA = "0xF82B90")]
	public OVRTouchpadHelper()
	{
	}
}
[Token(Token = "0x2000090")]
public class OVRLipSync : MonoBehaviour
{
	[Token(Token = "0x2000142")]
	public enum Result
	{
		[Token(Token = "0x4000720")]
		Success = 0,
		[Token(Token = "0x4000721")]
		Unknown = -2200,
		[Token(Token = "0x4000722")]
		CannotCreateContext = -2201,
		[Token(Token = "0x4000723")]
		InvalidParam = -2202,
		[Token(Token = "0x4000724")]
		BadSampleRate = -2203,
		[Token(Token = "0x4000725")]
		MissingDLL = -2204,
		[Token(Token = "0x4000726")]
		BadVersion = -2205,
		[Token(Token = "0x4000727")]
		UndefinedFunction = -2206
	}

	[Token(Token = "0x2000143")]
	public enum AudioDataType
	{
		[Token(Token = "0x4000729")]
		S16_Mono,
		[Token(Token = "0x400072A")]
		S16_Stereo,
		[Token(Token = "0x400072B")]
		F32_Mono,
		[Token(Token = "0x400072C")]
		F32_Stereo
	}

	[Token(Token = "0x2000144")]
	public enum Viseme
	{
		[Token(Token = "0x400072E")]
		sil,
		[Token(Token = "0x400072F")]
		PP,
		[Token(Token = "0x4000730")]
		FF,
		[Token(Token = "0x4000731")]
		TH,
		[Token(Token = "0x4000732")]
		DD,
		[Token(Token = "0x4000733")]
		kk,
		[Token(Token = "0x4000734")]
		CH,
		[Token(Token = "0x4000735")]
		SS,
		[Token(Token = "0x4000736")]
		nn,
		[Token(Token = "0x4000737")]
		RR,
		[Token(Token = "0x4000738")]
		aa,
		[Token(Token = "0x4000739")]
		E,
		[Token(Token = "0x400073A")]
		ih,
		[Token(Token = "0x400073B")]
		oh,
		[Token(Token = "0x400073C")]
		ou
	}

	[Token(Token = "0x2000145")]
	public enum Signals
	{
		[Token(Token = "0x400073E")]
		VisemeOn,
		[Token(Token = "0x400073F")]
		VisemeOff,
		[Token(Token = "0x4000740")]
		VisemeAmount,
		[Token(Token = "0x4000741")]
		VisemeSmoothing,
		[Token(Token = "0x4000742")]
		LaughterAmount
	}

	[Token(Token = "0x2000146")]
	public enum ContextProviders
	{
		[Token(Token = "0x4000744")]
		Original,
		[Token(Token = "0x4000745")]
		Enhanced,
		[Token(Token = "0x4000746")]
		Enhanced_with_Laughter
	}

	[Serializable]
	[Token(Token = "0x2000147")]
	public class Frame
	{
		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int frameNumber;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int frameDelay;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] Visemes;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float laughterScore;

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1588494", Offset = "0x1588494", VA = "0x1588494")]
		public void CopyInput(Frame input)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x15884EC", Offset = "0x15884EC", VA = "0x15884EC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x158857C", Offset = "0x158857C", VA = "0x158857C")]
		public Frame()
		{
		}
	}

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly int VisemeCount;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static readonly int SignalCount;

	[Token(Token = "0x40002D0")]
	public const string strOVRLS = "OVRLipSync";

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Result sInitialized;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static OVRLipSync sInstance;

	[PreserveSig]
	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x1586E18", Offset = "0x1586E18", VA = "0x1586E18")]
	private static extern int ovrLipSyncDll_Initialize(int samplerate, int buffersize);

	[PreserveSig]
	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x1586EA8", Offset = "0x1586EA8", VA = "0x1586EA8")]
	private static extern void ovrLipSyncDll_Shutdown();

	[PreserveSig]
	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x1586F18", Offset = "0x1586F18", VA = "0x1586F18")]
	private static extern IntPtr ovrLipSyncDll_GetVersion(ref int Major, ref int Minor, ref int Patch);

	[PreserveSig]
	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x1586FAC", Offset = "0x1586FAC", VA = "0x1586FAC")]
	private static extern int ovrLipSyncDll_CreateContextEx(ref uint context, ContextProviders provider, int sampleRate, bool enableAcceleration);

	[PreserveSig]
	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x1587054", Offset = "0x1587054", VA = "0x1587054")]
	private static extern int ovrLipSyncDll_CreateContextWithModelFile(ref uint context, ContextProviders provider, string modelPath, int sampleRate, bool enableAcceleration);

	[PreserveSig]
	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x1587120", Offset = "0x1587120", VA = "0x1587120")]
	private static extern int ovrLipSyncDll_DestroyContext(uint context);

	[PreserveSig]
	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x15871A0", Offset = "0x15871A0", VA = "0x15871A0")]
	private static extern int ovrLipSyncDll_ResetContext(uint context);

	[PreserveSig]
	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x1587220", Offset = "0x1587220", VA = "0x1587220")]
	private static extern int ovrLipSyncDll_SendSignal(uint context, Signals signal, int arg1, int arg2);

	[PreserveSig]
	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x15872C8", Offset = "0x15872C8", VA = "0x15872C8")]
	private static extern int ovrLipSyncDll_ProcessFrameEx(uint context, IntPtr audioBuffer, uint bufferSize, AudioDataType dataType, ref int frameNumber, ref int frameDelay, float[] visemes, int visemeCount, ref float laughterScore, float[] laughterCategories, int laughterCategoriesLength);

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x15873D0", Offset = "0x15873D0", VA = "0x15873D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x158784C", Offset = "0x158784C", VA = "0x158784C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x1587714", Offset = "0x1587714", VA = "0x1587714")]
	public static Result Initialize()
	{
		return default(Result);
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x158792C", Offset = "0x158792C", VA = "0x158792C")]
	public static Result Initialize(int sampleRate, int bufferSize)
	{
		return default(Result);
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x1587A40", Offset = "0x1587A40", VA = "0x1587A40")]
	public static void Shutdown()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x1587AB0", Offset = "0x1587AB0", VA = "0x1587AB0")]
	public static Result IsInitialized()
	{
		return default(Result);
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x1587B18", Offset = "0x1587B18", VA = "0x1587B18")]
	public static Result CreateContext(ref uint context, ContextProviders provider, int sampleRate = 0, bool enableAcceleration = false)
	{
		return default(Result);
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x1587C3C", Offset = "0x1587C3C", VA = "0x1587C3C")]
	public static Result CreateContextWithModelFile(ref uint context, ContextProviders provider, string modelPath, int sampleRate = 0, bool enableAcceleration = false)
	{
		return default(Result);
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x1587D74", Offset = "0x1587D74", VA = "0x1587D74")]
	public static Result DestroyContext(uint context)
	{
		return default(Result);
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x1587E54", Offset = "0x1587E54", VA = "0x1587E54")]
	public static Result ResetContext(uint context)
	{
		return default(Result);
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x1587F34", Offset = "0x1587F34", VA = "0x1587F34")]
	public static Result SendSignal(uint context, Signals signal, int arg1, int arg2)
	{
		return default(Result);
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x1588038", Offset = "0x1588038", VA = "0x1588038")]
	public static Result ProcessFrame(uint context, float[] audioBuffer, Frame frame, bool stereo = true)
	{
		return default(Result);
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x15881DC", Offset = "0x15881DC", VA = "0x15881DC")]
	public static Result ProcessFrame(uint context, short[] audioBuffer, Frame frame, bool stereo = true)
	{
		return default(Result);
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x1588378", Offset = "0x1588378", VA = "0x1588378")]
	public OVRLipSync()
	{
	}
}
[Token(Token = "0x2000091")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xA6CA74", Offset = "0xA6CA74")]
public class OVRLipSyncContext : OVRLipSyncContextBase
{
	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D680", Offset = "0xA6D680")]
	public bool enableKeyboardInput;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D6B8", Offset = "0xA6D6B8")]
	public bool enableTouchInput;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D6F0", Offset = "0xA6D6F0")]
	public bool audioLoopback;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D728", Offset = "0xA6D728")]
	public KeyCode loopbackKey;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D760", Offset = "0xA6D760")]
	public bool showVisemes;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D798", Offset = "0xA6D798")]
	public KeyCode debugVisemesKey;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D7D0", Offset = "0xA6D7D0")]
	public bool skipAudioSource;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D808", Offset = "0xA6D808")]
	public float gain;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool hasDebugConsole;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public KeyCode debugLaughterKey;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool showLaughter;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float laughterScore;

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x1588610", Offset = "0x1588610", VA = "0x1588610")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x158873C", Offset = "0x158873C", VA = "0x158873C")]
	private void HandleKeyboard()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x1588C88", Offset = "0x1588C88", VA = "0x1588C88")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x1588F34", Offset = "0x1588F34", VA = "0x1588F34")]
	public void PreprocessAudioSamples(float[] data, int channels)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x1588F98", Offset = "0x1588F98", VA = "0x1588F98")]
	public void PostprocessAudioSamples(float[] data, int channels)
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x1589004", Offset = "0x1589004", VA = "0x1589004")]
	public void ProcessAudioSamplesRaw(float[] data, int channels)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x1589168", Offset = "0x1589168", VA = "0x1589168")]
	public void ProcessAudioSamplesRaw(short[] data, int channels)
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x15892CC", Offset = "0x15892CC", VA = "0x15892CC")]
	public void ProcessAudioSamples(float[] data, int channels)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x1589400", Offset = "0x1589400", VA = "0x1589400")]
	private void OnAudioFilterRead(float[] data, int channels)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x1588CCC", Offset = "0x1588CCC", VA = "0x1588CCC")]
	private void DebugShowVisemesAndLaughter()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x1588A4C", Offset = "0x1588A4C", VA = "0x1588A4C")]
	private void ToggleAudioLoopback()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x1589410", Offset = "0x1589410", VA = "0x1589410")]
	private void LocalTouchEventCallback(OVRTouchpad.TouchEvent touchEvent)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x158953C", Offset = "0x158953C", VA = "0x158953C")]
	public OVRLipSyncContext()
	{
	}
}
[Token(Token = "0x2000092")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xA6CAD8", Offset = "0xA6CAD8")]
public class OVRLipSyncContextBase : MonoBehaviour
{
	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource audioSource;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D840", Offset = "0xA6D840")]
	public OVRLipSync.ContextProviders provider;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D878", Offset = "0xA6D878")]
	public bool enableAcceleration;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRLipSync.Frame frame;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private uint context;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int _smoothing;

	[Token(Token = "0x1700001A")]
	public int Smoothing
	{
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x15896C8", Offset = "0x15896C8", VA = "0x15896C8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x15895DC", Offset = "0x15895DC", VA = "0x15895DC")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public uint Context
	{
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x15896D0", Offset = "0x15896D0", VA = "0x15896D0")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x1700001C")]
	protected OVRLipSync.Frame Frame
	{
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x15896D8", Offset = "0x15896D8", VA = "0x15896D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x15896E0", Offset = "0x15896E0", VA = "0x15896E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x1589880", Offset = "0x1589880", VA = "0x1589880")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x158999C", Offset = "0x158999C", VA = "0x158999C")]
	public OVRLipSync.Frame GetCurrentPhonemeFrame()
	{
		return null;
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x15899A4", Offset = "0x15899A4", VA = "0x15899A4")]
	public void SetVisemeBlend(int viseme, int amount)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x1589A98", Offset = "0x1589A98", VA = "0x1589A98")]
	public void SetLaughterBlend(int amount)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x1589B60", Offset = "0x1589B60", VA = "0x1589B60")]
	public OVRLipSync.Result ResetContext()
	{
		return default(OVRLipSync.Result);
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x1589560", Offset = "0x1589560", VA = "0x1589560")]
	public OVRLipSyncContextBase()
	{
	}
}
[Token(Token = "0x2000093")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xA6CB3C", Offset = "0xA6CB3C")]
public class OVRLipSyncContextCanned : OVRLipSyncContextBase
{
	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D8B0", Offset = "0xA6D8B0")]
	public OVRLipSyncSequence currentSequence;

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x1589BD8", Offset = "0x1589BD8", VA = "0x1589BD8")]
	private void Update()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x1589D48", Offset = "0x1589D48", VA = "0x1589D48")]
	public OVRLipSyncContextCanned()
	{
	}
}
[Token(Token = "0x2000094")]
public class OVRLipSyncContextMorphTarget : MonoBehaviour
{
	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D8E8", Offset = "0xA6D8E8")]
	public SkinnedMeshRenderer skinnedMeshRenderer;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D920", Offset = "0xA6D920")]
	public int[] visemeToBlendTargets;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D958", Offset = "0xA6D958")]
	public bool enableVisemeTestKeys;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D990", Offset = "0xA6D990")]
	public KeyCode[] visemeTestKeys;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6D9C8", Offset = "0xA6D9C8")]
	public KeyCode laughterKey;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6DA00", Offset = "0xA6DA00")]
	public int laughterBlendTarget;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6DA38", Offset = "0xA6DA38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6DA38", Offset = "0xA6DA38")]
	public float laughterThreshold;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6DA8C", Offset = "0xA6DA8C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6DA8C", Offset = "0xA6DA8C")]
	public float laughterMultiplier;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6DAE0", Offset = "0xA6DAE0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6DAE0", Offset = "0xA6DAE0")]
	public int smoothAmount;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private OVRLipSyncContextBase lipsyncContext;

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x1589D4C", Offset = "0x1589D4C", VA = "0x1589D4C")]
	private void Start()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x1589EA0", Offset = "0x1589EA0", VA = "0x1589EA0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x158A150", Offset = "0x158A150", VA = "0x158A150")]
	private void CheckForKeys()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x1589FAC", Offset = "0x1589FAC", VA = "0x1589FAC")]
	private void SetVisemeToMorphTarget(OVRLipSync.Frame frame)
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x158A060", Offset = "0x158A060", VA = "0x158A060")]
	private void SetLaughterToMorphTarget(OVRLipSync.Frame frame)
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x158A220", Offset = "0x158A220", VA = "0x158A220")]
	private void CheckVisemeKey(KeyCode key, int viseme, int amount)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x158A2E4", Offset = "0x158A2E4", VA = "0x158A2E4")]
	private void CheckLaughterKey()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x158A34C", Offset = "0x158A34C", VA = "0x158A34C")]
	public OVRLipSyncContextMorphTarget()
	{
	}
}
[Token(Token = "0x2000095")]
public class OVRLipSyncContextTextureFlip : MonoBehaviour
{
	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material material;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6DB38", Offset = "0xA6DB38")]
	[AttributeAttribute(Name = "OVRNamedArrayAttribute", RVA = "0xA6DB38", Offset = "0xA6DB38")]
	public Texture[] Textures;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6DD68", Offset = "0xA6DD68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6DD68", Offset = "0xA6DD68")]
	public int smoothAmount;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private OVRLipSyncContextBase lipsyncContext;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private OVRLipSync.Frame oldFrame;

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x158A45C", Offset = "0x158A45C", VA = "0x158A45C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x158A5C0", Offset = "0x158A5C0", VA = "0x158A5C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x158A768", Offset = "0x158A768", VA = "0x158A768")]
	private void SetVisemeToTexture()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x158A88C", Offset = "0x158A88C", VA = "0x158A88C")]
	public OVRLipSyncContextTextureFlip()
	{
	}
}
[Token(Token = "0x2000096")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xA6CBA0", Offset = "0xA6CBA0")]
public class OVRLipSyncMicInput : MonoBehaviour
{
	[Token(Token = "0x2000148")]
	public enum micActivation
	{
		[Token(Token = "0x400074C")]
		HoldToSpeak,
		[Token(Token = "0x400074D")]
		PushToSpeak,
		[Token(Token = "0x400074E")]
		ConstantSpeak
	}

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6DDC0", Offset = "0xA6DDC0")]
	public AudioSource audioSource;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6DDF8", Offset = "0xA6DDF8")]
	public bool enableMicSelectionGUI;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6DE30", Offset = "0xA6DE30")]
	public KeyCode micSelectionGUIKey;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6DE68", Offset = "0xA6DE68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6DE68", Offset = "0xA6DE68")]
	private float micInputVolume;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6DED0", Offset = "0xA6DED0")]
	private int micFrequency;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6DF1C", Offset = "0xA6DF1C")]
	public micActivation micControl;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6DF54", Offset = "0xA6DF54")]
	public KeyCode micActivationKey;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6DF8C", Offset = "0xA6DF8C")]
	public string selectedDevice;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool micSelected;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int minFreq;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int maxFreq;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool focused;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	private bool initialized;

	[Token(Token = "0x1700001D")]
	public float MicFrequency
	{
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x158B2DC", Offset = "0x158B2DC", VA = "0x158B2DC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x158B2E8", Offset = "0x158B2E8", VA = "0x158B2E8")]
		set
		{
		}
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x158B374", Offset = "0x158B374", VA = "0x158B374")]
	private void Awake()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x158B43C", Offset = "0x158B43C", VA = "0x158B43C")]
	private void Start()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x158B488", Offset = "0x158B488", VA = "0x158B488")]
	private void InitializeMicrophone()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x158B5D8", Offset = "0x158B5D8", VA = "0x158B5D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x158BA10", Offset = "0x158BA10", VA = "0x158BA10")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x158BA24", Offset = "0x158BA24", VA = "0x158BA24")]
	private void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x158BA3C", Offset = "0x158BA3C", VA = "0x158BA3C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x158BA40", Offset = "0x158BA40", VA = "0x158BA40")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x158BAB8", Offset = "0x158BAB8", VA = "0x158BAB8")]
	public void MicDeviceGUI(float left, float top, float width, float height, float buttonSpaceTop, float buttonSpaceLeft)
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x158B51C", Offset = "0x158B51C", VA = "0x158B51C")]
	public void GetMicCaps()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x158B87C", Offset = "0x158B87C", VA = "0x158B87C")]
	public void StartMicrophone()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x158B734", Offset = "0x158B734", VA = "0x158B734")]
	public void StopMicrophone()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x158BCB0", Offset = "0x158BCB0", VA = "0x158BCB0")]
	private float GetAveragedVolume()
	{
		return default(float);
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x158BCB8", Offset = "0x158BCB8", VA = "0x158BCB8")]
	public OVRLipSyncMicInput()
	{
	}
}
[Serializable]
[Token(Token = "0x2000097")]
public class OVRLipSyncSequence : ScriptableObject
{
	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<OVRLipSync.Frame> entries;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float length;

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x1589CA4", Offset = "0x1589CA4", VA = "0x1589CA4")]
	public OVRLipSync.Frame GetFrameAtTime(float time)
	{
		return null;
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x158BCE8", Offset = "0x158BCE8", VA = "0x158BCE8")]
	public OVRLipSyncSequence()
	{
	}
}
[Token(Token = "0x2000098")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x2000149")]
	public delegate void OnClick();

	[Token(Token = "0x200014A")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x200014B")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x200014C")]
	public delegate bool ActiveUpdate();

	[Token(Token = "0x200014D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CE74", Offset = "0xA6CE74")]
	private sealed class <>c__DisplayClass35_0
	{
		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnClick handler;

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xDA2A54", Offset = "0xDA2A54", VA = "0xDA2A54")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xDA3468", Offset = "0xDA3468", VA = "0xDA3468")]
		internal void <AddButton>b__0()
		{
		}
	}

	[Token(Token = "0x200014E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CE84", Offset = "0xA6CE84")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnSlider onValueChanged;

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xDA2CD4", Offset = "0xDA2CD4", VA = "0xDA2CD4")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xDA368C", Offset = "0xDA368C", VA = "0xDA368C")]
		internal void <AddSlider>b__0(float f)
		{
		}
	}

	[Token(Token = "0x200014F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CE94", Offset = "0xA6CE94")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xDA2F0C", Offset = "0xDA2F0C", VA = "0xDA2F0C")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xDA3904", Offset = "0xDA3904", VA = "0xDA3904")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x2000150")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CEA4", Offset = "0xA6CEA4")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xDA30C0", Offset = "0xDA30C0", VA = "0xDA30C0")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xDA3CB8", Offset = "0xDA3CB8", VA = "0xDA3CB8")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x2000151")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CEB4", Offset = "0xA6CEB4")]
	private sealed class <>c__DisplayClass41_0
	{
		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange handler;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle tb;

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xDA3334", Offset = "0xDA3334", VA = "0xDA3334")]
		public <>c__DisplayClass41_0()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xDA3CD8", Offset = "0xDA3CD8", VA = "0xDA3CD8")]
		internal void <AddRadio>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x4000304")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x4000305")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x4000306")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool[] reEnable;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x4000313")]
	private const float elementSpacing = 16f;

	[Token(Token = "0x4000314")]
	private const float marginH = 16f;

	[Token(Token = "0x4000315")]
	private const float marginV = 16f;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector2[] insertPositions;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3 menuOffset;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private OVRCameraRig rig;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private LaserPointer lp;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private LineRenderer lr;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xDA18E0", Offset = "0xDA18E0", VA = "0xDA18E0")]
	public void Awake()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0xDA1DA0", Offset = "0xDA1DA0", VA = "0xDA1DA0")]
	public void Show()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xDA2380", Offset = "0xDA2380", VA = "0xDA2380")]
	public void Hide()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xDA212C", Offset = "0xDA212C", VA = "0xDA212C")]
	private void Relayout()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xDA2528", Offset = "0xDA2528", VA = "0xDA2528")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xDA2820", Offset = "0xDA2820", VA = "0xDA2820")]
	public RectTransform AddButton(string label, OnClick handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xDA2A5C", Offset = "0xDA2A5C", VA = "0xDA2A5C")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xDA2B40", Offset = "0xDA2B40", VA = "0xDA2B40")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xDA2CDC", Offset = "0xDA2CDC", VA = "0xDA2CDC")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xDA2D78", Offset = "0xDA2D78", VA = "0xDA2D78")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0xDA2F14", Offset = "0xDA2F14", VA = "0xDA2F14")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0xDA30C8", Offset = "0xDA30C8", VA = "0xDA30C8")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xDA333C", Offset = "0xDA333C", VA = "0xDA333C")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xDA33EC", Offset = "0xDA33EC", VA = "0xDA33EC")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x2000099")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xDA5FD4", Offset = "0xDA5FD4", VA = "0xDA5FD4")]
	private void Start()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xDA6070", Offset = "0xDA6070", VA = "0xDA6070")]
	private void Update()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xDA6138", Offset = "0xDA6138", VA = "0xDA6138")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xDA6174", Offset = "0xDA6174", VA = "0xDA6174")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x200009A")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x2000152")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x4000758")]
		On,
		[Token(Token = "0x4000759")]
		Off,
		[Token(Token = "0x400075A")]
		OnWhenHitTarget
	}

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x1700001E")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x600023F")]
		[Address(RVA = "0xDA6948", Offset = "0xDA6948", VA = "0xDA6948")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x600023E")]
		[Address(RVA = "0xDA1D5C", Offset = "0xDA1D5C", VA = "0xDA1D5C")]
		set
		{
		}
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xDA6950", Offset = "0xDA6950", VA = "0xDA6950")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xDA69B0", Offset = "0xDA69B0", VA = "0xDA69B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0xDA6AC8", Offset = "0xDA6AC8", VA = "0xDA6AC8", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xDA6AE4", Offset = "0xDA6AE4", VA = "0xDA6AE4", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0xDA6B38", Offset = "0xDA6B38", VA = "0xDA6B38")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xDA6D94", Offset = "0xDA6D94", VA = "0xDA6D94")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xDA6EA8", Offset = "0xDA6EA8", VA = "0xDA6EA8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0xDA6F3C", Offset = "0xDA6F3C", VA = "0xDA6F3C")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xDA700C", Offset = "0xDA700C", VA = "0xDA700C")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0xDA70C4", Offset = "0xDA70C4", VA = "0xDA70C4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xDA7190", Offset = "0xDA7190", VA = "0xDA7190")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x200009B")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x4000329")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x400032A")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x400032B")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E064", Offset = "0xA6E064")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E09C", Offset = "0xA6E09C")]
	public LayerMask CollideLayers;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E0D4", Offset = "0xA6E0D4")]
	public float HeightOffset;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E10C", Offset = "0xA6E10C")]
	public float MinimumHeight;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E144", Offset = "0xA6E144")]
	public float MaximumHeight;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x600024B")]
	[Address(RVA = "0xD9FFE0", Offset = "0xD9FFE0", VA = "0xD9FFE0")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0xD9FFE8", Offset = "0xD9FFE8", VA = "0xD9FFE8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0xDA006C", Offset = "0xDA006C", VA = "0xDA006C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0xDA00F8", Offset = "0xDA00F8", VA = "0xDA00F8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xDA0184", Offset = "0xDA0184", VA = "0xDA0184")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xDA058C", Offset = "0xDA058C", VA = "0xDA058C")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xDA0834", Offset = "0xDA0834", VA = "0xDA0834")]
	private bool CheckCameraNearClipping(out float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x200009C")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xDA8270", Offset = "0xDA8270", VA = "0xDA8270")]
	private void Start()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xDA8334", Offset = "0xDA8334", VA = "0xDA8334")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x200009D")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x2000153")]
	public enum States
	{
		[Token(Token = "0x400075C")]
		Ready,
		[Token(Token = "0x400075D")]
		Aim,
		[Token(Token = "0x400075E")]
		CancelAim,
		[Token(Token = "0x400075F")]
		PreTeleport,
		[Token(Token = "0x4000760")]
		CancelTeleport,
		[Token(Token = "0x4000761")]
		Teleporting,
		[Token(Token = "0x4000762")]
		PostTeleport
	}

	[Token(Token = "0x2000154")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x4000764")]
		None,
		[Token(Token = "0x4000765")]
		Aim,
		[Token(Token = "0x4000766")]
		PreTeleport,
		[Token(Token = "0x4000767")]
		Teleport
	}

	[Token(Token = "0x2000155")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x4000769")]
		Point,
		[Token(Token = "0x400076A")]
		Sphere,
		[Token(Token = "0x400076B")]
		Capsule
	}

	[Token(Token = "0x2000156")]
	public class AimData
	{
		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA702E8", Offset = "0xA702E8")]
		private List<Vector3> <Points>k__BackingField;

		[Token(Token = "0x170000B2")]
		public List<Vector3> Points
		{
			[Token(Token = "0x6000722")]
			[Address(RVA = "0xDAB634", Offset = "0xDAB634", VA = "0xDAB634")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71AF8", Offset = "0xA71AF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000723")]
			[Address(RVA = "0xDAB63C", Offset = "0xDAB63C", VA = "0xDAB63C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71B08", Offset = "0xA71B08")]
			private set
			{
			}
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xDAB5B8", Offset = "0xDAB5B8", VA = "0xDAB5B8")]
		public AimData()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xDAB644", Offset = "0xDAB644", VA = "0xDAB644")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000157")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CEC4", Offset = "0xA6CEC4")]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x170000B3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000728")]
			[Address(RVA = "0xDAB3F8", Offset = "0xDAB3F8", VA = "0xDAB3F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600072A")]
			[Address(RVA = "0xDAB460", Offset = "0xDAB460", VA = "0xDAB460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xDA9840", Offset = "0xDA9840", VA = "0xDA9840")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xDAB2F0", Offset = "0xDAB2F0", VA = "0xDAB2F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xDAB2F4", Offset = "0xDAB2F4", VA = "0xDAB2F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xDAB400", Offset = "0xDAB400", VA = "0xDAB400", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000158")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CED4", Offset = "0xA6CED4")]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x170000B5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0xDAAD7C", Offset = "0xDAAD7C", VA = "0xDAAD7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0xDAADE4", Offset = "0xDAADE4", VA = "0xDAADE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xDA9D34", Offset = "0xDA9D34", VA = "0xDA9D34")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xDAAC2C", Offset = "0xDAAC2C", VA = "0xDAAC2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xDAAC30", Offset = "0xDAAC30", VA = "0xDAAC30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xDAAD84", Offset = "0xDAAD84", VA = "0xDAAD84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CEE4", Offset = "0xA6CEE4")]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x170000B7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000734")]
			[Address(RVA = "0xDAAE9C", Offset = "0xDAAE9C", VA = "0xDAAE9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0xDAAF04", Offset = "0xDAAF04", VA = "0xDAAF04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xDA9F24", Offset = "0xDA9F24", VA = "0xDA9F24")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xDAADEC", Offset = "0xDAADEC", VA = "0xDAADEC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xDAADF0", Offset = "0xDAADF0", VA = "0xDAADF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xDAAEA4", Offset = "0xDAAEA4", VA = "0xDAAEA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CEF4", Offset = "0xA6CEF4")]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x170000B9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600073A")]
			[Address(RVA = "0xDAB280", Offset = "0xDAB280", VA = "0xDAB280", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0xDAB2E8", Offset = "0xDAB2E8", VA = "0xDAB2E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xDAA114", Offset = "0xDAA114", VA = "0xDAA114")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xDAB19C", Offset = "0xDAB19C", VA = "0xDAB19C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xDAB1A0", Offset = "0xDAB1A0", VA = "0xDAB1A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xDAB288", Offset = "0xDAB288", VA = "0xDAB288", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CF04", Offset = "0xA6CF04")]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x170000BB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000740")]
			[Address(RVA = "0xDAAFBC", Offset = "0xDAAFBC", VA = "0xDAAFBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0xDAB024", Offset = "0xDAB024", VA = "0xDAB024", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xDAA304", Offset = "0xDAA304", VA = "0xDAA304")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xDAAF0C", Offset = "0xDAAF0C", VA = "0xDAAF0C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xDAAF10", Offset = "0xDAAF10", VA = "0xDAAF10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xDAAFC4", Offset = "0xDAAFC4", VA = "0xDAAFC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CF14", Offset = "0xA6CF14")]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x170000BD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0xDAB548", Offset = "0xDAB548", VA = "0xDAB548", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0xDAB5B0", Offset = "0xDAB5B0", VA = "0xDAB5B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xDAA4F4", Offset = "0xDAA4F4", VA = "0xDAA4F4")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xDAB468", Offset = "0xDAB468", VA = "0xDAB468", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xDAB46C", Offset = "0xDAB46C", VA = "0xDAB46C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xDAB550", Offset = "0xDAB550", VA = "0xDAB550", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CF24", Offset = "0xA6CF24")]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x170000BF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0xDAB12C", Offset = "0xDAB12C", VA = "0xDAB12C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0xDAB194", Offset = "0xDAB194", VA = "0xDAB194", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xDAA6E4", Offset = "0xDAA6E4", VA = "0xDAA6E4")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xDAB02C", Offset = "0xDAB02C", VA = "0xDAB02C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xDAB030", Offset = "0xDAB030", VA = "0xDAB030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xDAB134", Offset = "0xDAB134", VA = "0xDAB134", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E17C", Offset = "0xA6E17C")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E1B4", Offset = "0xA6E1B4")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E1EC", Offset = "0xA6E1EC")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E224", Offset = "0xA6E224")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E25C", Offset = "0xA6E25C")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E294", Offset = "0xA6E294")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E2CC", Offset = "0xA6E2CC")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E304", Offset = "0xA6E304")]
	public bool EnableRotationDuringPostTeleport;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6E33C", Offset = "0xA6E33C")]
	private States <CurrentState>k__BackingField;

	[NonSerialized]
	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E34C", Offset = "0xA6E34C")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E384", Offset = "0xA6E384")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6E3CC", Offset = "0xA6E3CC")]
	private LocomotionController <LocomotionController>k__BackingField;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E3DC", Offset = "0xA6E3DC")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E414", Offset = "0xA6E414")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E44C", Offset = "0xA6E44C")]
	public float AimCollisionRadius;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E484", Offset = "0xA6E484")]
	public float AimCollisionHeight;

	[Token(Token = "0x1700001F")]
	public States CurrentState
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0xDA8D3C", Offset = "0xDA8D3C", VA = "0xDA8D3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7058C", Offset = "0xA7058C")]
		get
		{
			return default(States);
		}
		[Token(Token = "0x6000257")]
		[Address(RVA = "0xDA8D44", Offset = "0xDA8D44", VA = "0xDA8D44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7059C", Offset = "0xA7059C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x600025B")]
		[Address(RVA = "0xDA8F74", Offset = "0xDA8F74", VA = "0xDA8F74")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x17000021")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x600025C")]
		[Address(RVA = "0xDA8F9C", Offset = "0xDA8F9C", VA = "0xDA8F9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA705CC", Offset = "0xA705CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600025D")]
		[Address(RVA = "0xDA8FA4", Offset = "0xDA8FA4", VA = "0xDA8FA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA705DC", Offset = "0xA705DC")]
		private set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x6000258")]
		[Address(RVA = "0xDA8D4C", Offset = "0xDA8D4C", VA = "0xDA8D4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA705AC", Offset = "0xA705AC")]
		add
		{
		}
		[Token(Token = "0x6000259")]
		[Address(RVA = "0xDA8DF0", Offset = "0xDA8DF0", VA = "0xDA8DF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA705BC", Offset = "0xA705BC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x6000267")]
		[Address(RVA = "0xDA96F8", Offset = "0xDA96F8", VA = "0xDA96F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70624", Offset = "0xA70624")]
		add
		{
		}
		[Token(Token = "0x6000268")]
		[Address(RVA = "0xDA979C", Offset = "0xDA979C", VA = "0xDA979C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70634", Offset = "0xA70634")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x600026A")]
		[Address(RVA = "0xDA986C", Offset = "0xDA986C", VA = "0xDA986C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA706A8", Offset = "0xA706A8")]
		add
		{
		}
		[Token(Token = "0x600026B")]
		[Address(RVA = "0xDA9910", Offset = "0xDA9910", VA = "0xDA9910")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA706B8", Offset = "0xA706B8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x600026C")]
		[Address(RVA = "0xDA99B4", Offset = "0xDA99B4", VA = "0xDA99B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA706C8", Offset = "0xA706C8")]
		add
		{
		}
		[Token(Token = "0x600026D")]
		[Address(RVA = "0xDA9A58", Offset = "0xDA9A58", VA = "0xDA9A58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA706D8", Offset = "0xA706D8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x600026F")]
		[Address(RVA = "0xDA9B70", Offset = "0xDA9B70", VA = "0xDA9B70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA706E8", Offset = "0xA706E8")]
		add
		{
		}
		[Token(Token = "0x6000270")]
		[Address(RVA = "0xDA9C14", Offset = "0xDA9C14", VA = "0xDA9C14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA706F8", Offset = "0xA706F8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0xDA9D60", Offset = "0xDA9D60", VA = "0xDA9D60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7076C", Offset = "0xA7076C")]
		add
		{
		}
		[Token(Token = "0x6000273")]
		[Address(RVA = "0xDA9E04", Offset = "0xDA9E04", VA = "0xDA9E04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7077C", Offset = "0xA7077C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x6000275")]
		[Address(RVA = "0xDA9F50", Offset = "0xDA9F50", VA = "0xDA9F50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA707F0", Offset = "0xA707F0")]
		add
		{
		}
		[Token(Token = "0x6000276")]
		[Address(RVA = "0xDA9FF4", Offset = "0xDA9FF4", VA = "0xDA9FF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70800", Offset = "0xA70800")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x6000278")]
		[Address(RVA = "0xDAA140", Offset = "0xDAA140", VA = "0xDAA140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70874", Offset = "0xA70874")]
		add
		{
		}
		[Token(Token = "0x6000279")]
		[Address(RVA = "0xDAA1E4", Offset = "0xDAA1E4", VA = "0xDAA1E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70884", Offset = "0xA70884")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x600027B")]
		[Address(RVA = "0xDAA330", Offset = "0xDAA330", VA = "0xDAA330")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA708F8", Offset = "0xA708F8")]
		add
		{
		}
		[Token(Token = "0x600027C")]
		[Address(RVA = "0xDAA3D4", Offset = "0xDAA3D4", VA = "0xDAA3D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70908", Offset = "0xA70908")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x600027E")]
		[Address(RVA = "0xDAA520", Offset = "0xDAA520", VA = "0xDAA520")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7097C", Offset = "0xA7097C")]
		add
		{
		}
		[Token(Token = "0x600027F")]
		[Address(RVA = "0xDAA5C4", Offset = "0xDAA5C4", VA = "0xDAA5C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7098C", Offset = "0xA7098C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x6000281")]
		[Address(RVA = "0xDAA710", Offset = "0xDAA710", VA = "0xDAA710")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70A00", Offset = "0xA70A00")]
		add
		{
		}
		[Token(Token = "0x6000282")]
		[Address(RVA = "0xDAA7B4", Offset = "0xDAA7B4", VA = "0xDAA7B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70A10", Offset = "0xA70A10")]
		remove
		{
		}
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xDA8A0C", Offset = "0xDA8A0C", VA = "0xDA8A0C")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xDA8A30", Offset = "0xDA8A30", VA = "0xDA8A30")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xDA8E94", Offset = "0xDA8E94", VA = "0xDA8E94")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0xDA8FAC", Offset = "0xDA8FAC", VA = "0xDA8FAC")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xDA9304", Offset = "0xDA9304", VA = "0xDA9304")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA705EC", Offset = "0xA705EC")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xDA93BC", Offset = "0xDA93BC", VA = "0xDA93BC")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xDA94B4", Offset = "0xDA94B4", VA = "0xDA94B4")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0xDA94D0", Offset = "0xDA94D0", VA = "0xDA94D0")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xDA9598", Offset = "0xDA9598", VA = "0xDA9598")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xDA95DC", Offset = "0xDA95DC", VA = "0xDA95DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0xDA9644", Offset = "0xDA9644", VA = "0xDA9644", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xDA96F0", Offset = "0xDA96F0", VA = "0xDA96F0", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xDA9674", Offset = "0xDA9674", VA = "0xDA9674")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA70644", Offset = "0xA70644")]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xDA9AFC", Offset = "0xDA9AFC", VA = "0xDA9AFC")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0xDA9CB8", Offset = "0xDA9CB8", VA = "0xDA9CB8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA70708", Offset = "0xA70708")]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0xDA9EA8", Offset = "0xDA9EA8", VA = "0xDA9EA8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA7078C", Offset = "0xA7078C")]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0xDAA098", Offset = "0xDAA098", VA = "0xDAA098")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA70810", Offset = "0xA70810")]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0xDAA288", Offset = "0xDAA288", VA = "0xDAA288")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA70894", Offset = "0xA70894")]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0xDAA478", Offset = "0xDAA478", VA = "0xDAA478")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA70918", Offset = "0xA70918")]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0xDAA668", Offset = "0xDAA668", VA = "0xDAA668")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA7099C", Offset = "0xA7099C")]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0xDAA858", Offset = "0xDAA858", VA = "0xDAA858")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0xDAA99C", Offset = "0xDAA99C", VA = "0xDAA99C")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0xDAA9D0", Offset = "0xDAA9D0", VA = "0xDAA9D0")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0xDAAAF0", Offset = "0xDAAAF0", VA = "0xDAAAF0")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xDAAC1C", Offset = "0xDAAC1C", VA = "0xDAAC1C")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x200009E")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x1400000C")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x6000288")]
		[Address(RVA = "0xDC12B0", Offset = "0xDC12B0", VA = "0xDC12B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70A20", Offset = "0xA70A20")]
		add
		{
		}
		[Token(Token = "0x6000289")]
		[Address(RVA = "0xDC1354", Offset = "0xDC1354", VA = "0xDC1354")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70A30", Offset = "0xA70A30")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x600028A")]
		[Address(RVA = "0xDC13F8", Offset = "0xDC13F8", VA = "0xDC13F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70A40", Offset = "0xA70A40")]
		add
		{
		}
		[Token(Token = "0x600028B")]
		[Address(RVA = "0xDC149C", Offset = "0xDC149C", VA = "0xDC149C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70A50", Offset = "0xA70A50")]
		remove
		{
		}
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xDC1540", Offset = "0xDC1540", VA = "0xDC1540")]
	private void Awake()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xDC1618", Offset = "0xDC1618", VA = "0xDC1618")]
	private void Start()
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0xDC161C", Offset = "0xDC161C", VA = "0xDC161C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0xDC1690", Offset = "0xDC1690", VA = "0xDC1690")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xDC1800", Offset = "0xDC1800", VA = "0xDC1800")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0xDC1AE4", Offset = "0xDC1AE4", VA = "0xDC1AE4")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0xDC1CD4", Offset = "0xDC1CD4", VA = "0xDC1CD4")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x200009F")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x6000293")]
	[Address(RVA = "0xDC5794", Offset = "0xDC5794", VA = "0xDC5794", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0xDC5838", Offset = "0xDC5838", VA = "0xDC5838", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000295")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xDC592C", Offset = "0xDC592C", VA = "0xDC592C")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x20000A0")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E57C", Offset = "0xA6E57C")]
	public float Range;

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xDC593C", Offset = "0xDC593C", VA = "0xDC593C", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xDC5A98", Offset = "0xDC5A98", VA = "0xDC5A98")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x20000A1")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E5B4", Offset = "0xA6E5B4")]
	public float Range;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E5EC", Offset = "0xA6E5EC")]
	public float MinimumElevation;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E624", Offset = "0xA6E624")]
	public float Gravity;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E65C", Offset = "0xA6E65C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6E65C", Offset = "0xA6E65C")]
	public float AimVelocity;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E6B8", Offset = "0xA6E6B8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6E6B8", Offset = "0xA6E6B8")]
	public float AimStep;

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xDC5AA8", Offset = "0xDC5AA8", VA = "0xDC5AA8", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xDC5CF4", Offset = "0xDC5CF4", VA = "0xDC5CF4")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x20000A2")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E710", Offset = "0xA6E710")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xDC5D08", Offset = "0xDC5D08", VA = "0xDC5D08")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0xDC5E0C", Offset = "0xDC5E0C", VA = "0xDC5E0C")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0xDC5E3C", Offset = "0xDC5E3C", VA = "0xDC5E3C")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0xDC5E6C", Offset = "0xDC5E6C", VA = "0xDC5E6C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0xDC5F14", Offset = "0xDC5F14", VA = "0xDC5F14", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xDC5F80", Offset = "0xDC5F80", VA = "0xDC5F80", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xDC5FE8", Offset = "0xDC5FE8", VA = "0xDC5FE8")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x20000A3")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6E748", Offset = "0xA6E748")]
	private bool <IsValidDestination>k__BackingField;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E758", Offset = "0xA6E758")]
	public Transform PositionIndicator;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E790", Offset = "0xA6E790")]
	public Transform OrientationIndicator;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E7C8", Offset = "0xA6E7C8")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x17000022")]
	public bool IsValidDestination
	{
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xDC6104", Offset = "0xDC6104", VA = "0xDC6104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70A60", Offset = "0xA70A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xDC610C", Offset = "0xDC610C", VA = "0xDC610C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70A70", Offset = "0xA70A70")]
		private set
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xDC62C4", Offset = "0xDC62C4", VA = "0xDC62C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70A80", Offset = "0xA70A80")]
		add
		{
		}
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xDC6368", Offset = "0xDC6368", VA = "0xDC6368")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70A90", Offset = "0xA70A90")]
		remove
		{
		}
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xDC6118", Offset = "0xDC6118", VA = "0xDC6118")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xDC61A8", Offset = "0xDC61A8", VA = "0xDC61A8")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xDC6280", Offset = "0xDC6280", VA = "0xDC6280")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xDC62C0", Offset = "0xDC62C0", VA = "0xDC62C0")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xDC640C", Offset = "0xDC640C", VA = "0xDC640C")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xDC6474", Offset = "0xDC6474", VA = "0xDC6474")]
	public void Recycle()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xDC6494", Offset = "0xDC6494", VA = "0xDC6494", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x20000A4")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x200015E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CF34", Offset = "0xA6CF34")]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x170000C1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0xDC6BAC", Offset = "0xDC6BAC", VA = "0xDC6BAC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0xDC6C14", Offset = "0xDC6C14", VA = "0xDC6C14", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xDC68D4", Offset = "0xDC68D4", VA = "0xDC68D4")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xDC6B10", Offset = "0xDC6B10", VA = "0xDC6B10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xDC6B14", Offset = "0xDC6B14", VA = "0xDC6B14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xDC6BB4", Offset = "0xDC6BB4", VA = "0xDC6BB4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CF44", Offset = "0xA6CF44")]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x170000C3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000758")]
			[Address(RVA = "0xDC6AA0", Offset = "0xDC6AA0", VA = "0xDC6AA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600075A")]
			[Address(RVA = "0xDC6B08", Offset = "0xDC6B08", VA = "0xDC6B08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xDC697C", Offset = "0xDC697C", VA = "0xDC697C")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xDC6A00", Offset = "0xDC6A00", VA = "0xDC6A00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xDC6A04", Offset = "0xDC6A04", VA = "0xDC6A04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xDC6AA8", Offset = "0xDC6AA8", VA = "0xDC6AA8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xDC6674", Offset = "0xDC6674", VA = "0xDC6674")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xDC6734", Offset = "0xDC6734", VA = "0xDC6734", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xDC6794", Offset = "0xDC6794", VA = "0xDC6794", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0xDC6858", Offset = "0xDC6858", VA = "0xDC6858")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA70AA0", Offset = "0xA70AA0")]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xDC6900", Offset = "0xDC6900", VA = "0xDC6900")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA70B04", Offset = "0xA70B04")]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002B2")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x60002B3")]
	public abstract void GetAimData(out Ray aimRay);

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0xDC69A8", Offset = "0xDC69A8", VA = "0xDC69A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70B68", Offset = "0xA70B68")]
	private void <.ctor>b__2_0()
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0xDC69D4", Offset = "0xDC69D4", VA = "0xDC69D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70B78", Offset = "0xA70B78")]
	private void <.ctor>b__2_1()
	{
	}
}
[Token(Token = "0x20000A5")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6E810", Offset = "0xA6E810")]
	private Transform <Pointer>k__BackingField;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E820", Offset = "0xA6E820")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E858", Offset = "0xA6E858")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E890", Offset = "0xA6E890")]
	public bool FastTeleport;

	[Token(Token = "0x17000023")]
	public Transform Pointer
	{
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xDC6C1C", Offset = "0xDC6C1C", VA = "0xDC6C1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70B88", Offset = "0xA70B88")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xDC6C24", Offset = "0xDC6C24", VA = "0xDC6C24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70B98", Offset = "0xA70B98")]
		private set
		{
		}
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xDC6C2C", Offset = "0xDC6C2C", VA = "0xDC6C2C", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xDC6D88", Offset = "0xDC6D88", VA = "0xDC6D88", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xDC6E40", Offset = "0xDC6E40", VA = "0xDC6E40")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x20000A6")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x2000160")]
	public enum InputModes
	{
		[Token(Token = "0x400078D")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x400078E")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x400078F")]
		ThumbstickTeleport,
		[Token(Token = "0x4000790")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x2000161")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x4000792")]
		A,
		[Token(Token = "0x4000793")]
		B,
		[Token(Token = "0x4000794")]
		LeftTrigger,
		[Token(Token = "0x4000795")]
		LeftThumbstick,
		[Token(Token = "0x4000796")]
		RightTrigger,
		[Token(Token = "0x4000797")]
		RightThumbstick,
		[Token(Token = "0x4000798")]
		X,
		[Token(Token = "0x4000799")]
		Y
	}

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E8C8", Offset = "0xA6E8C8")]
	public InputModes InputMode;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E900", Offset = "0xA6E900")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E938", Offset = "0xA6E938")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E970", Offset = "0xA6E970")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xDC6E44", Offset = "0xDC6E44", VA = "0xDC6E44")]
	private void Start()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xDC6E48", Offset = "0xDC6E48", VA = "0xDC6E48", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xDC7290", Offset = "0xDC7290", VA = "0xDC7290", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xDC7350", Offset = "0xDC7350", VA = "0xDC7350")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x20000A7")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x2000162")]
	public enum OrientationModes
	{
		[Token(Token = "0x400079B")]
		HeadRelative,
		[Token(Token = "0x400079C")]
		ForwardFacing
	}

	[Token(Token = "0x2000163")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CF54", Offset = "0xA6CF54")]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x170000C5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600075E")]
			[Address(RVA = "0xDC7824", Offset = "0xDC7824", VA = "0xDC7824", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0xDC788C", Offset = "0xDC788C", VA = "0xDC788C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xDC75F4", Offset = "0xDC75F4", VA = "0xDC75F4")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xDC7770", Offset = "0xDC7770", VA = "0xDC7770", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xDC7774", Offset = "0xDC7774", VA = "0xDC7774", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xDC782C", Offset = "0xDC782C", VA = "0xDC782C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xDC7414", Offset = "0xDC7414", VA = "0xDC7414")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xDC74DC", Offset = "0xDC74DC", VA = "0xDC74DC")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xDC74E4", Offset = "0xDC74E4", VA = "0xDC74E4", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xDC7530", Offset = "0xDC7530", VA = "0xDC7530", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xDC7578", Offset = "0xDC7578", VA = "0xDC7578")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA70BA8", Offset = "0xA70BA8")]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002C4")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x60002C5")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0xDC7620", Offset = "0xDC7620", VA = "0xDC7620")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0xDC7744", Offset = "0xDC7744", VA = "0xDC7744")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70C0C", Offset = "0xA70C0C")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x20000A8")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x60002C8")]
	[Address(RVA = "0xDC7894", Offset = "0xDC7894", VA = "0xDC7894", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0xDC7898", Offset = "0xDC7898", VA = "0xDC7898", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0xDC7914", Offset = "0xDC7914", VA = "0xDC7914")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x20000A9")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E9A8", Offset = "0xA6E9A8")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6E9E0", Offset = "0xA6E9E0")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6EA18", Offset = "0xA6EA18")]
	public float AimDistanceThreshold;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6EA50", Offset = "0xA6EA50")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0xDC7918", Offset = "0xDC7918", VA = "0xDC7918", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0xDC7988", Offset = "0xDC7988", VA = "0xDC7988", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0xDC7E00", Offset = "0xDC7E00", VA = "0xDC7E00")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x20000AA")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6EA88", Offset = "0xA6EA88")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6EAC0", Offset = "0xA6EAC0")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6EAF8", Offset = "0xA6EAF8")]
	public float RotateStickThreshold;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0xDC7E04", Offset = "0xDC7E04", VA = "0xDC7E04", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0xDC7E48", Offset = "0xDC7E48", VA = "0xDC7E48", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0xDC82B8", Offset = "0xDC82B8", VA = "0xDC82B8")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x20000AB")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xDC82C8", Offset = "0xDC82C8", VA = "0xDC82C8")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0xDC82CC", Offset = "0xDC82CC", VA = "0xDC82CC")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0xDC82D4", Offset = "0xDC82D4", VA = "0xDC82D4")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xDC83BC", Offset = "0xDC83BC", VA = "0xDC83BC")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xDC83E4", Offset = "0xDC83E4", VA = "0xDC83E4")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x20000AC")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6EB30", Offset = "0xA6EB30")]
	private LocomotionTeleport <LocomotionTeleport>k__BackingField;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x17000024")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xDC83FC", Offset = "0xDC83FC", VA = "0xDC83FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70C1C", Offset = "0xA70C1C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xDC8404", Offset = "0xDC8404", VA = "0xDC8404")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70C2C", Offset = "0xA70C2C")]
		private set
		{
		}
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xDC57C8", Offset = "0xDC57C8", VA = "0xDC57C8", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xDC58F8", Offset = "0xDC58F8", VA = "0xDC58F8", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xDC840C", Offset = "0xDC840C", VA = "0xDC840C")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA70C3C", Offset = "0xA70C3C")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xDC5F74", Offset = "0xDC5F74", VA = "0xDC5F74", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xDC5FE0", Offset = "0xDC5FE0", VA = "0xDC5FE0", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xDC5934", Offset = "0xDC5934", VA = "0xDC5934")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x20000AD")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x2000164")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CF64", Offset = "0xA6CF64")]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x170000C7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000764")]
			[Address(RVA = "0xDC8A98", Offset = "0xDC8A98", VA = "0xDC8A98", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0xDC8B00", Offset = "0xDC8B00", VA = "0xDC8B00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xDC8688", Offset = "0xDC8688", VA = "0xDC8688")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xDC8820", Offset = "0xDC8820", VA = "0xDC8820", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xDC8824", Offset = "0xDC8824", VA = "0xDC8824", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xDC8AA0", Offset = "0xDC8AA0", VA = "0xDC8AA0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6EB40", Offset = "0xA6EB40")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x40003A0")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xDC84D4", Offset = "0xDC84D4", VA = "0xDC84D4")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0xDC85B8", Offset = "0xDC85B8", VA = "0xDC85B8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0xDC85E4", Offset = "0xDC85E4", VA = "0xDC85E4", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xDC860C", Offset = "0xDC860C", VA = "0xDC860C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA70C74", Offset = "0xA70C74")]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xDC86B4", Offset = "0xDC86B4", VA = "0xDC86B4", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x60002E3")]
	protected abstract bool ConsiderTeleport(Vector3 start, ref Vector3 end);

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0xDC86D0", Offset = "0xDC86D0", VA = "0xDC86D0", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0xDC87F4", Offset = "0xDC87F4", VA = "0xDC87F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70CD8", Offset = "0xA70CD8")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x20000AE")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xDC8B08", Offset = "0xDC8B08", VA = "0xDC8B08")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xDC8B70", Offset = "0xDC8B70", VA = "0xDC8B70", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xDC8CF4", Offset = "0xDC8CF4", VA = "0xDC8CF4", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xDC8DE4", Offset = "0xDC8DE4", VA = "0xDC8DE4")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA70CE8", Offset = "0xA70CE8")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0xDC8DE8", Offset = "0xDC8DE8", VA = "0xDC8DE8")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x20000AF")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6EB78", Offset = "0xA6EB78")]
	public float LOSOffset;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6EBB0", Offset = "0xA6EBB0")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0xDC8DF4", Offset = "0xDC8DF4", VA = "0xDC8DF4", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0xDC9024", Offset = "0xDC9024", VA = "0xDC9024")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x20000B0")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x60002ED")]
	[Address(RVA = "0xDC9030", Offset = "0xDC9030", VA = "0xDC9030", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xDC91B4", Offset = "0xDC91B4", VA = "0xDC91B4")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x20000B1")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x60002EF")]
	[Address(RVA = "0xDC91B8", Offset = "0xDC91B8", VA = "0xDC91B8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xDC9250", Offset = "0xDC9250", VA = "0xDC9250", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002F1")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xDC92E4", Offset = "0xDC92E4", VA = "0xDC92E4")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x20000B2")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x2000165")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CF74", Offset = "0xA6CF74")]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x170000C9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0xDC9670", Offset = "0xDC9670", VA = "0xDC9670", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0xDC96D8", Offset = "0xDC96D8", VA = "0xDC96D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xDC9394", Offset = "0xDC9394", VA = "0xDC9394")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xDC9564", Offset = "0xDC9564", VA = "0xDC9564", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xDC9568", Offset = "0xDC9568", VA = "0xDC9568", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xDC9678", Offset = "0xDC9678", VA = "0xDC9678", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6EBE8", Offset = "0xA6EBE8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6EBE8", Offset = "0xA6EBE8")]
	public float TransitionDuration;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6EC40", Offset = "0xA6EC40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6EC40", Offset = "0xA6EC40")]
	public float TeleportDelay;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6EC94", Offset = "0xA6EC94")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0xDC92EC", Offset = "0xDC92EC", VA = "0xDC92EC", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xDC9318", Offset = "0xDC9318", VA = "0xDC9318")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA70D20", Offset = "0xA70D20")]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0xDC93C0", Offset = "0xDC93C0", VA = "0xDC93C0")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x20000B3")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x60002F6")]
	[Address(RVA = "0xDC96E0", Offset = "0xDC96E0", VA = "0xDC96E0", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0xDC96FC", Offset = "0xDC96FC", VA = "0xDC96FC")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x20000B4")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x2000166")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CF84", Offset = "0xA6CF84")]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x170000CB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000770")]
			[Address(RVA = "0xDC996C", Offset = "0xDC996C", VA = "0xDC996C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000772")]
			[Address(RVA = "0xDC99D4", Offset = "0xDC99D4", VA = "0xDC99D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xDC97AC", Offset = "0xDC97AC", VA = "0xDC97AC")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xDC982C", Offset = "0xDC982C", VA = "0xDC982C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xDC9830", Offset = "0xDC9830", VA = "0xDC9830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xDC9974", Offset = "0xDC9974", VA = "0xDC9974", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6ECCC", Offset = "0xA6ECCC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6ECCC", Offset = "0xA6ECCC")]
	public float TransitionDuration;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xDC9704", Offset = "0xDC9704", VA = "0xDC9704", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xDC9730", Offset = "0xDC9730", VA = "0xDC9730")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA70D84", Offset = "0xA70D84")]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xDC97D8", Offset = "0xDC97D8", VA = "0xDC97D8")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x20000B5")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x2000167")]
	public enum PlabackState
	{
		[Token(Token = "0x40007AF")]
		Idle = 1,
		[Token(Token = "0x40007B0")]
		Preparing,
		[Token(Token = "0x40007B1")]
		Buffering,
		[Token(Token = "0x40007B2")]
		Ready,
		[Token(Token = "0x40007B3")]
		Ended
	}

	[Token(Token = "0x2000168")]
	public enum StereoMode
	{
		[Token(Token = "0x40007B5")]
		Unknown = -1,
		[Token(Token = "0x40007B6")]
		Mono,
		[Token(Token = "0x40007B7")]
		TopBottom,
		[Token(Token = "0x40007B8")]
		LeftRight,
		[Token(Token = "0x40007B9")]
		Mesh
	}

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getCurrentPlaybackStateMethodId;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x17000025")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xDB0220", Offset = "0xDB0220", VA = "0xDB0220")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17000026")]
	private static IntPtr Activity
	{
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xDB04DC", Offset = "0xDB04DC", VA = "0xDB04DC")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17000027")]
	public static bool IsAvailable
	{
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xDAD288", Offset = "0xDAD288", VA = "0xDAD288")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000028")]
	public static bool IsPlaying
	{
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xDAE8F0", Offset = "0xDAE8F0", VA = "0xDAE8F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000029")]
	public static PlabackState CurrentPlaybackState
	{
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xDB0720", Offset = "0xDB0720", VA = "0xDB0720")]
		get
		{
			return default(PlabackState);
		}
	}

	[Token(Token = "0x1700002A")]
	public static long Duration
	{
		[Token(Token = "0x6000300")]
		[Address(RVA = "0xDAEAD4", Offset = "0xDAEAD4", VA = "0xDAEAD4")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700002B")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x6000301")]
		[Address(RVA = "0xDAD870", Offset = "0xDAD870", VA = "0xDAD870")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x1700002C")]
	public static int VideoWidth
	{
		[Token(Token = "0x6000302")]
		[Address(RVA = "0xDAD688", Offset = "0xDAD688", VA = "0xDAD688")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700002D")]
	public static int VideoHeight
	{
		[Token(Token = "0x6000303")]
		[Address(RVA = "0xDAD77C", Offset = "0xDAD77C", VA = "0xDAD77C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700002E")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x6000304")]
		[Address(RVA = "0xDAE9E0", Offset = "0xDAE9E0", VA = "0xDAE9E0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000305")]
		[Address(RVA = "0xDAE098", Offset = "0xDAE098", VA = "0xDAE098")]
		set
		{
		}
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0xDAF13C", Offset = "0xDAF13C", VA = "0xDAF13C")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xDAEE80", Offset = "0xDAEE80", VA = "0xDAEE80")]
	public static void Stop()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xDADD28", Offset = "0xDADD28", VA = "0xDADD28")]
	public static void Play()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0xDADEAC", Offset = "0xDADEAC", VA = "0xDADEAC")]
	public static void Pause()
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0xDAECA0", Offset = "0xDAECA0", VA = "0xDAECA0")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0xDAF33C", Offset = "0xDAF33C", VA = "0xDAF33C")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0xDAE72C", Offset = "0xDAE72C", VA = "0xDAE72C")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x20000B6")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x1400000F")]
	public event Action onButtonDown
	{
		[Token(Token = "0x600030E")]
		[Address(RVA = "0xD9FE7C", Offset = "0xD9FE7C", VA = "0xD9FE7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70DE8", Offset = "0xA70DE8")]
		add
		{
		}
		[Token(Token = "0x600030F")]
		[Address(RVA = "0xD9FF20", Offset = "0xD9FF20", VA = "0xD9FF20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70DF8", Offset = "0xA70DF8")]
		remove
		{
		}
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0xD9FFC4", Offset = "0xD9FFC4", VA = "0xD9FFC4", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0xD9FFD8", Offset = "0xD9FFD8", VA = "0xD9FFD8")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x20000B7")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x2000169")]
	public enum ButtonType
	{
		[Token(Token = "0x40007BB")]
		Play,
		[Token(Token = "0x40007BC")]
		Pause,
		[Token(Token = "0x40007BD")]
		FastForward,
		[Token(Token = "0x40007BE")]
		Rewind,
		[Token(Token = "0x40007BF")]
		SkipForward,
		[Token(Token = "0x40007C0")]
		SkipBack,
		[Token(Token = "0x40007C1")]
		Stop
	}

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x1700002F")]
	public ButtonType buttonType
	{
		[Token(Token = "0x6000312")]
		[Address(RVA = "0xDAB768", Offset = "0xDAB768", VA = "0xDAB768")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x6000313")]
		[Address(RVA = "0xDAB770", Offset = "0xDAB770", VA = "0xDAB770")]
		set
		{
		}
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0xDAB794", Offset = "0xDAB794", VA = "0xDAB794", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0xDACC60", Offset = "0xDACC60", VA = "0xDACC60")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x20000B8")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x200016A")]
	public enum VideoShape
	{
		[Token(Token = "0x40007C3")]
		_360,
		[Token(Token = "0x40007C4")]
		_180,
		[Token(Token = "0x40007C5")]
		Quad
	}

	[Token(Token = "0x200016B")]
	public enum VideoStereo
	{
		[Token(Token = "0x40007C7")]
		Mono,
		[Token(Token = "0x40007C8")]
		TopBottom,
		[Token(Token = "0x40007C9")]
		LeftRight,
		[Token(Token = "0x40007CA")]
		BottomTop
	}

	[Token(Token = "0x200016C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CF94", Offset = "0xA6CF94")]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x170000CD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000776")]
			[Address(RVA = "0xDAF618", Offset = "0xDAF618", VA = "0xDAF618", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000778")]
			[Address(RVA = "0xDAF680", Offset = "0xDAF680", VA = "0xDAF680", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xDAD9E0", Offset = "0xDAD9E0", VA = "0xDAD9E0")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xDAF488", Offset = "0xDAF488", VA = "0xDAF488", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xDAF48C", Offset = "0xDAF48C", VA = "0xDAF48C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xDAF620", Offset = "0xDAF620", VA = "0xDAF620", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200016D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CFA4", Offset = "0xA6CFA4")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string moviePath;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string drmLicencesUrl;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xDADC8C", Offset = "0xDADC8C", VA = "0xDADC8C")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xDAF068", Offset = "0xDAF068", VA = "0xDAF068")]
		internal void <Play>b__0()
		{
		}
	}

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6ED54", Offset = "0xA6ED54")]
	private bool <IsPlaying>k__BackingField;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6ED64", Offset = "0xA6ED64")]
	private long <Duration>k__BackingField;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6ED74", Offset = "0xA6ED74")]
	private long <PlaybackPosition>k__BackingField;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x17000030")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000316")]
		[Address(RVA = "0xDAD008", Offset = "0xDAD008", VA = "0xDAD008")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70E08", Offset = "0xA70E08")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000317")]
		[Address(RVA = "0xDAD010", Offset = "0xDAD010", VA = "0xDAD010")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70E18", Offset = "0xA70E18")]
		private set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public long Duration
	{
		[Token(Token = "0x6000318")]
		[Address(RVA = "0xDAD01C", Offset = "0xDAD01C", VA = "0xDAD01C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70E28", Offset = "0xA70E28")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000319")]
		[Address(RVA = "0xDAD024", Offset = "0xDAD024", VA = "0xDAD024")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70E38", Offset = "0xA70E38")]
		private set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public long PlaybackPosition
	{
		[Token(Token = "0x600031A")]
		[Address(RVA = "0xDAD02C", Offset = "0xDAD02C", VA = "0xDAD02C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70E48", Offset = "0xA70E48")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600031B")]
		[Address(RVA = "0xDAD034", Offset = "0xDAD034", VA = "0xDAD034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70E58", Offset = "0xA70E58")]
		private set
		{
		}
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xDAD03C", Offset = "0xDAD03C", VA = "0xDAD03C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0xDAD2F0", Offset = "0xDAD2F0", VA = "0xDAD2F0")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xDAD358", Offset = "0xDAD358", VA = "0xDAD358")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xDAD964", Offset = "0xDAD964", VA = "0xDAD964")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA70E68", Offset = "0xA70E68")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xDADA0C", Offset = "0xDADA0C", VA = "0xDADA0C")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0xDADC94", Offset = "0xDADC94", VA = "0xDADC94")]
	public void Play()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0xDADE1C", Offset = "0xDADE1C", VA = "0xDADE1C")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0xDADFA0", Offset = "0xDADFA0", VA = "0xDADFA0")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0xDAE1E0", Offset = "0xDAE1E0", VA = "0xDAE1E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0xDAEBC8", Offset = "0xDAEBC8", VA = "0xDAEBC8")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0xDAEDF0", Offset = "0xDAEDF0", VA = "0xDAEDF0")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0xDAEF74", Offset = "0xDAEF74", VA = "0xDAEF74")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0xDAF058", Offset = "0xDAF058", VA = "0xDAF058")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x20000B9")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x200016E")]
	private enum PlaybackState
	{
		[Token(Token = "0x40007D2")]
		Playing,
		[Token(Token = "0x40007D3")]
		Paused,
		[Token(Token = "0x40007D4")]
		Rewinding,
		[Token(Token = "0x40007D5")]
		FastForwarding
	}

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x6000329")]
	[Address(RVA = "0xDAF688", Offset = "0xDAF688", VA = "0xDAF688")]
	private void Start()
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0xDAF978", Offset = "0xDAF978", VA = "0xDAF978")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xDAFB54", Offset = "0xDAFB54", VA = "0xDAFB54")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0xDAFC88", Offset = "0xDAFC88", VA = "0xDAFC88")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0xDAFD90", Offset = "0xDAFD90", VA = "0xDAFD90")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0xDAFC5C", Offset = "0xDAFC5C", VA = "0xDAFC5C")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0xDAFE58", Offset = "0xDAFE58", VA = "0xDAFE58")]
	private void Update()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0xDAF86C", Offset = "0xDAF86C", VA = "0xDAF86C")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0xDB0210", Offset = "0xDB0210", VA = "0xDB0210")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x20000BA")]
public static class VectorUtil
{
	[Token(Token = "0x6000332")]
	[Address(RVA = "0xDCC95C", Offset = "0xDCC95C", VA = "0xDCC95C")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x20000BB")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x6000333")]
	[Address(RVA = "0xDA40B8", Offset = "0xDA40B8", VA = "0xDA40B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0xDA4510", Offset = "0xDA4510", VA = "0xDA4510")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0xDA45C8", Offset = "0xDA45C8", VA = "0xDA45C8")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0xDA481C", Offset = "0xDA481C", VA = "0xDA481C")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0xDA4904", Offset = "0xDA4904", VA = "0xDA4904")]
	private void Update()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0xDA49E0", Offset = "0xDA49E0", VA = "0xDA49E0")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0xDA4A4C", Offset = "0xDA4A4C", VA = "0xDA4A4C")]
	public DebugUISample()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0xDA4A54", Offset = "0xDA4A54", VA = "0xDA4A54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70EDC", Offset = "0xA70EDC")]
	private void <Start>b__2_0(Toggle t)
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0xDA4AB0", Offset = "0xDA4AB0", VA = "0xDA4AB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70EEC", Offset = "0xA70EEC")]
	private void <Start>b__2_1(Toggle t)
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0xDA4B0C", Offset = "0xDA4B0C", VA = "0xDA4B0C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70EFC", Offset = "0xA70EFC")]
	private void <Start>b__2_2(Toggle t)
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0xDA4B68", Offset = "0xDA4B68", VA = "0xDA4B68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA70F0C", Offset = "0xA70F0C")]
	private void <Start>b__2_3(Toggle t)
	{
	}
}
[Token(Token = "0x20000BC")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x200016F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CFB4", Offset = "0xA6CFB4")]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x170000CF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600077E")]
			[Address(RVA = "0xDA660C", Offset = "0xDA660C", VA = "0xDA660C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0xDA6674", Offset = "0xDA6674", VA = "0xDA6674", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xDA6490", Offset = "0xDA6490", VA = "0xDA6490")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xDA64C4", Offset = "0xDA64C4", VA = "0xDA64C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xDA64C8", Offset = "0xDA64C8", VA = "0xDA64C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xDA6614", Offset = "0xDA6614", VA = "0xDA6614", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xDA617C", Offset = "0xDA617C", VA = "0xDA617C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xDA6294", Offset = "0xDA6294", VA = "0xDA6294")]
	private void Update()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xDA6218", Offset = "0xDA6218", VA = "0xDA6218")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA70F1C", Offset = "0xA70F1C")]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xDA64BC", Offset = "0xDA64BC", VA = "0xDA64BC")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x20000BD")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6ED94", Offset = "0xA6ED94")]
	public int SubdivisionsU;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6EDB0", Offset = "0xA6EDB0")]
	public int SubdivisionsV;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xDA0DE4", Offset = "0xDA0DE4", VA = "0xDA0DE4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xDA18D8", Offset = "0xDA18D8", VA = "0xDA18D8")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x20000BE")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x17000033")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x6000344")]
		[Address(RVA = "0xDA833C", Offset = "0xDA833C", VA = "0xDA833C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xDA8394", Offset = "0xDA8394", VA = "0xDA8394")]
	public void Start()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xDA8704", Offset = "0xDA8704", VA = "0xDA8704")]
	public void Update()
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0xDA87E0", Offset = "0xDA87E0", VA = "0xDA87E0")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA70F80", Offset = "0xA70F80")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x6000348")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000349")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x600034A")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x600034B")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x600034C")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x600034D")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x600034E")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x600034F")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xDA8848", Offset = "0xDA8848", VA = "0xDA8848")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xDA8884", Offset = "0xDA8884", VA = "0xDA8884")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xDA88F8", Offset = "0xDA88F8", VA = "0xDA88F8")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0xDA8A54", Offset = "0xDA8A54", VA = "0xDA8A54")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0xDA8B28", Offset = "0xDA8B28", VA = "0xDA8B28")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0xDA8610", Offset = "0xDA8610", VA = "0xDA8610")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0xDA8BE8", Offset = "0xDA8BE8", VA = "0xDA8BE8")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0xDA8C50", Offset = "0xDA8C50", VA = "0xDA8C50")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0xDA8D34", Offset = "0xDA8D34", VA = "0xDA8D34")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x20000BF")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xA6CC24", Offset = "0xA6CC24")]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x2000170")]
	public enum DrawMode
	{
		[Token(Token = "0x40007DA")]
		Opaque,
		[Token(Token = "0x40007DB")]
		OpaqueWithClip,
		[Token(Token = "0x40007DC")]
		TransparentDefaultAlpha,
		[Token(Token = "0x40007DD")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[HideInInspector]
	private Shader _transparentShader;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[HideInInspector]
	private Shader _opaqueShader;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x17000034")]
	public bool overlayEnabled
	{
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x158D4BC", Offset = "0x158D4BC", VA = "0x158D4BC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x158D550", Offset = "0x158D550", VA = "0x158D550")]
		set
		{
		}
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x158BD98", Offset = "0x158BD98", VA = "0x158BD98")]
	private void Start()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x158CABC", Offset = "0x158CABC", VA = "0x158CABC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x158CB40", Offset = "0x158CB40", VA = "0x158CB40")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x158CC34", Offset = "0x158CC34", VA = "0x158CC34")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x158CD28", Offset = "0x158CD28", VA = "0x158CD28", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x158CF2C", Offset = "0x158CF2C", VA = "0x158CF2C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x158D620", Offset = "0x158D620", VA = "0x158D620")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x20000C0")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x2000171")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6CFC4", Offset = "0xA6CFC4")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int sceneIndex;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StartMenu <>4__this;

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xDC4FD4", Offset = "0xDC4FD4", VA = "0xDC4FD4")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xDC50E4", Offset = "0xDC50E4", VA = "0xDC50E4")]
		internal void <Start>b__0()
		{
		}
	}

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x6000363")]
	[Address(RVA = "0xDC4E04", Offset = "0xDC4E04", VA = "0xDC4E04")]
	private void Start()
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0xDC4FDC", Offset = "0xDC4FDC", VA = "0xDC4FDC")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0xDC50DC", Offset = "0xDC50DC", VA = "0xDC50DC")]
	public StartMenu()
	{
	}
}
[Token(Token = "0x20000C1")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA6CC88", Offset = "0xA6CC88")]
public class MouseLook : MonoBehaviour
{
	[Token(Token = "0x2000172")]
	public enum RotationAxes
	{
		[Token(Token = "0x40007E1")]
		MouseXAndY,
		[Token(Token = "0x40007E2")]
		MouseX,
		[Token(Token = "0x40007E3")]
		MouseY
	}

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RotationAxes axes;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sensitivityX;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sensitivityY;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float minimumX;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maximumX;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float minimumY;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float maximumY;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float rotationY;

	[Token(Token = "0x6000366")]
	[Address(RVA = "0xDACCC8", Offset = "0xDACCC8", VA = "0xDACCC8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0xDACF28", Offset = "0xDACF28", VA = "0xDACF28")]
	private void Start()
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0xDACFE8", Offset = "0xDACFE8", VA = "0xDACFE8")]
	public MouseLook()
	{
	}
}
[Token(Token = "0x20000C2")]
public class ONSPAmbisonicsNative : MonoBehaviour
{
	[Token(Token = "0x2000173")]
	public enum ovrAmbisonicsNativeStatus
	{
		[Token(Token = "0x40007E5")]
		Uninitialized = -1,
		[Token(Token = "0x40007E6")]
		NotEnabled,
		[Token(Token = "0x40007E7")]
		Success,
		[Token(Token = "0x40007E8")]
		StreamError,
		[Token(Token = "0x40007E9")]
		ProcessError,
		[Token(Token = "0x40007EA")]
		MaxStatValue
	}

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource source;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int numFOAChannels;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int paramAmbiStat;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ovrAmbisonicsNativeStatus currentStatus;

	[Token(Token = "0x6000369")]
	[Address(RVA = "0xDB0D5C", Offset = "0xDB0D5C", VA = "0xDB0D5C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0xDB0FA0", Offset = "0xDB0FA0", VA = "0xDB0FA0")]
	private void Update()
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0xDB118C", Offset = "0xDB118C", VA = "0xDB118C")]
	public ONSPAmbisonicsNative()
	{
	}
}
[Token(Token = "0x20000C3")]
public class ONSPAudioSource : MonoBehaviour
{
	[Token(Token = "0x2000174")]
	private enum Parameters
	{
		[Token(Token = "0x40007EC")]
		P_GAIN,
		[Token(Token = "0x40007ED")]
		P_USEINVSQR,
		[Token(Token = "0x40007EE")]
		P_NEAR,
		[Token(Token = "0x40007EF")]
		P_FAR,
		[Token(Token = "0x40007F0")]
		P_RADIUS,
		[Token(Token = "0x40007F1")]
		P_DISABLE_RFL,
		[Token(Token = "0x40007F2")]
		P_AMBISTAT,
		[Token(Token = "0x40007F3")]
		P_READONLY_GLOBAL_RFL_ENABLED,
		[Token(Token = "0x40007F4")]
		P_READONLY_NUM_VOICES,
		[Token(Token = "0x40007F5")]
		P_SENDLEVEL,
		[Token(Token = "0x40007F6")]
		P_NUM
	}

	[Token(Token = "0x4000420")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool enableSpatialization;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float gain;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool useInvSqr;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float near;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float far;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float volumetricRadius;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float reverbSend;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool enableRfl;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ONSPAudioSource RoomReflectionGizmoAS;

	[Token(Token = "0x17000035")]
	public bool EnableSpatialization
	{
		[Token(Token = "0x600036F")]
		[Address(RVA = "0xDB13D8", Offset = "0xDB13D8", VA = "0xDB13D8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000370")]
		[Address(RVA = "0xDB13E0", Offset = "0xDB13E0", VA = "0xDB13E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public float Gain
	{
		[Token(Token = "0x6000371")]
		[Address(RVA = "0xDB13EC", Offset = "0xDB13EC", VA = "0xDB13EC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000372")]
		[Address(RVA = "0xDB13F4", Offset = "0xDB13F4", VA = "0xDB13F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000037")]
	public bool UseInvSqr
	{
		[Token(Token = "0x6000373")]
		[Address(RVA = "0xDB1478", Offset = "0xDB1478", VA = "0xDB1478")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000374")]
		[Address(RVA = "0xDB1480", Offset = "0xDB1480", VA = "0xDB1480")]
		set
		{
		}
	}

	[Token(Token = "0x17000038")]
	public float Near
	{
		[Token(Token = "0x6000375")]
		[Address(RVA = "0xDB148C", Offset = "0xDB148C", VA = "0xDB148C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000376")]
		[Address(RVA = "0xDB1494", Offset = "0xDB1494", VA = "0xDB1494")]
		set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public float Far
	{
		[Token(Token = "0x6000377")]
		[Address(RVA = "0xDB151C", Offset = "0xDB151C", VA = "0xDB151C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000378")]
		[Address(RVA = "0xDB1524", Offset = "0xDB1524", VA = "0xDB1524")]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public float VolumetricRadius
	{
		[Token(Token = "0x6000379")]
		[Address(RVA = "0xDB15AC", Offset = "0xDB15AC", VA = "0xDB15AC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600037A")]
		[Address(RVA = "0xDB15B4", Offset = "0xDB15B4", VA = "0xDB15B4")]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	public float ReverbSend
	{
		[Token(Token = "0x600037B")]
		[Address(RVA = "0xDB163C", Offset = "0xDB163C", VA = "0xDB163C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600037C")]
		[Address(RVA = "0xDB1644", Offset = "0xDB1644", VA = "0xDB1644")]
		set
		{
		}
	}

	[Token(Token = "0x1700003C")]
	public bool EnableRfl
	{
		[Token(Token = "0x600037D")]
		[Address(RVA = "0xDB16CC", Offset = "0xDB16CC", VA = "0xDB16CC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600037E")]
		[Address(RVA = "0xDB16D4", Offset = "0xDB16D4", VA = "0xDB16D4")]
		set
		{
		}
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0xDB1200", Offset = "0xDB1200", VA = "0xDB1200")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xA70FB8", Offset = "0xA70FB8")]
	private static void OnBeforeSceneLoadRuntimeMethod()
	{
	}

	[PreserveSig]
	[Token(Token = "0x600036E")]
	[Address(RVA = "0xDB12F8", Offset = "0xDB12F8", VA = "0xDB12F8")]
	private static extern void ONSP_GetGlobalRoomReflectionValues(ref bool reflOn, ref bool reverbOn, ref float width, ref float height, ref float length);

	[Token(Token = "0x600037F")]
	[Address(RVA = "0xDB16E0", Offset = "0xDB16E0", VA = "0xDB16E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0xDB1854", Offset = "0xDB1854", VA = "0xDB1854")]
	private void Start()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0xDB1858", Offset = "0xDB1858", VA = "0xDB1858")]
	private void Update()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0xDB174C", Offset = "0xDB174C", VA = "0xDB174C")]
	public void SetParameters(ref AudioSource source)
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0xDB1920", Offset = "0xDB1920", VA = "0xDB1920")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0xDB1D88", Offset = "0xDB1D88", VA = "0xDB1D88")]
	private void OnDestroy()
	{
	}

	[PreserveSig]
	[Token(Token = "0x6000385")]
	[Address(RVA = "0xDB1278", Offset = "0xDB1278", VA = "0xDB1278")]
	private static extern int OSP_SetGlobalVoiceLimit(int VoiceLimit);

	[Token(Token = "0x6000386")]
	[Address(RVA = "0xDB1E6C", Offset = "0xDB1E6C", VA = "0xDB1E6C")]
	public ONSPAudioSource()
	{
	}
}
[Token(Token = "0x20000C4")]
public class ONSPProfiler : MonoBehaviour
{
	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool profilerEnabled;

	[Token(Token = "0x400042B")]
	private const int DEFAULT_PORT = 2121;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int port;

	[Token(Token = "0x400042D")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[Token(Token = "0x6000388")]
	[Address(RVA = "0xDB1E8C", Offset = "0xDB1E8C", VA = "0xDB1E8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0xDB1E98", Offset = "0xDB1E98", VA = "0xDB1E98")]
	private void Update()
	{
	}

	[PreserveSig]
	[Token(Token = "0x600038A")]
	[Address(RVA = "0xDB1F50", Offset = "0xDB1F50", VA = "0xDB1F50")]
	private static extern int ONSP_SetProfilerEnabled(bool enabled);

	[PreserveSig]
	[Token(Token = "0x600038B")]
	[Address(RVA = "0xDB1ED0", Offset = "0xDB1ED0", VA = "0xDB1ED0")]
	private static extern int ONSP_SetProfilerPort(int port);

	[Token(Token = "0x600038C")]
	[Address(RVA = "0xDB1FD0", Offset = "0xDB1FD0", VA = "0xDB1FD0")]
	public ONSPProfiler()
	{
	}
}
[Token(Token = "0x20000C5")]
public class ONSPPropagationGeometry : MonoBehaviour
{
	[Token(Token = "0x2000175")]
	private struct MeshMaterial
	{
		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MeshFilter meshFilter;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ONSPPropagationMaterial[] materials;
	}

	[Token(Token = "0x2000176")]
	private struct TerrainMaterial
	{
		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Terrain terrain;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ONSPPropagationMaterial[] materials;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh[] treePrototypeMeshes;
	}

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string GeometryAssetDirectory;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string filePathRelative;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool fileEnabled;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool includeChildMeshes;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IntPtr geometryHandle;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int OSPSuccess;

	[Token(Token = "0x4000434")]
	public const string GEOMETRY_FILE_EXTENSION = "ovramesh";

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static int terrainDecimation;

	[Token(Token = "0x1700003D")]
	public static string GeometryAssetPath
	{
		[Token(Token = "0x600038D")]
		[Address(RVA = "0xDB4A70", Offset = "0xDB4A70", VA = "0xDB4A70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003E")]
	public string filePath
	{
		[Token(Token = "0x600038E")]
		[Address(RVA = "0xDB4AFC", Offset = "0xDB4AFC", VA = "0xDB4AFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0xDB4B74", Offset = "0xDB4B74", VA = "0xDB4B74")]
	private static string GetPath(Transform current)
	{
		return null;
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0xDB4CBC", Offset = "0xDB4CBC", VA = "0xDB4CBC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0xDB4CC0", Offset = "0xDB4CC0", VA = "0xDB4CC0")]
	private void CreatePropagationGeometry()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0xDB5220", Offset = "0xDB5220", VA = "0xDB5220")]
	private void Update()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0xDB55B8", Offset = "0xDB55B8", VA = "0xDB55B8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0xDB5714", Offset = "0xDB5714", VA = "0xDB5714")]
	private static void traverseMeshHierarchy(GameObject obj, ONSPPropagationMaterial[] currentMaterials, bool includeChildren, List<MeshMaterial> meshMaterials, List<TerrainMaterial> terrainMaterials, bool ignoreStatic, ref int ignoredMeshCount)
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0xDB5E58", Offset = "0xDB5E58", VA = "0xDB5E58")]
	private int uploadMesh(IntPtr geometryHandle, GameObject meshObject, Matrix4x4 worldToLocal)
	{
		return default(int);
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0xDB5E94", Offset = "0xDB5E94", VA = "0xDB5E94")]
	private int uploadMesh(IntPtr geometryHandle, GameObject meshObject, Matrix4x4 worldToLocal, bool ignoreStatic, ref int ignoredMeshCount)
	{
		return default(int);
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0xDB74F0", Offset = "0xDB74F0", VA = "0xDB74F0")]
	private static void uploadMeshFilter(List<Vector3> tempVertices, List<int> tempIndices, MeshGroup[] groups, float[] vertices, int[] indices, ref int vertexOffset, ref int indexOffset, ref int groupOffset, Mesh mesh, ONSPPropagationMaterial[] materials, Matrix4x4 matrix)
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0xDB73C8", Offset = "0xDB73C8", VA = "0xDB73C8")]
	private static void updateCountsForMesh(ref int totalVertexCount, ref uint totalIndexCount, ref int totalFaceCount, ref int totalMaterialCount, Mesh mesh)
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0xDB5058", Offset = "0xDB5058", VA = "0xDB5058")]
	public void UploadGeometry()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0xDB4E8C", Offset = "0xDB4E8C", VA = "0xDB4E8C")]
	public bool ReadFile()
	{
		return default(bool);
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xDB799C", Offset = "0xDB799C", VA = "0xDB799C")]
	public bool WriteToObj()
	{
		return default(bool);
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0xDB7DD8", Offset = "0xDB7DD8", VA = "0xDB7DD8")]
	public ONSPPropagationGeometry()
	{
	}
}
[Token(Token = "0x20000C6")]
internal class ONSPPropagation
{
	[Token(Token = "0x2000177")]
	public enum ovrAudioScalarType : uint
	{
		[Token(Token = "0x40007FD")]
		Int8,
		[Token(Token = "0x40007FE")]
		UInt8,
		[Token(Token = "0x40007FF")]
		Int16,
		[Token(Token = "0x4000800")]
		UInt16,
		[Token(Token = "0x4000801")]
		Int32,
		[Token(Token = "0x4000802")]
		UInt32,
		[Token(Token = "0x4000803")]
		Int64,
		[Token(Token = "0x4000804")]
		UInt64,
		[Token(Token = "0x4000805")]
		Float16,
		[Token(Token = "0x4000806")]
		Float32,
		[Token(Token = "0x4000807")]
		Float64
	}

	[Token(Token = "0x2000178")]
	public class ClientType
	{
		[Token(Token = "0x4000808")]
		public const uint OVRA_CLIENT_TYPE_NATIVE = 0u;

		[Token(Token = "0x4000809")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2016 = 1u;

		[Token(Token = "0x400080A")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2017_1 = 2u;

		[Token(Token = "0x400080B")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2017_2 = 3u;

		[Token(Token = "0x400080C")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2018_1 = 4u;

		[Token(Token = "0x400080D")]
		public const uint OVRA_CLIENT_TYPE_FMOD = 5u;

		[Token(Token = "0x400080E")]
		public const uint OVRA_CLIENT_TYPE_UNITY = 6u;

		[Token(Token = "0x400080F")]
		public const uint OVRA_CLIENT_TYPE_UE4 = 7u;

		[Token(Token = "0x4000810")]
		public const uint OVRA_CLIENT_TYPE_VST = 8u;

		[Token(Token = "0x4000811")]
		public const uint OVRA_CLIENT_TYPE_AAX = 9u;

		[Token(Token = "0x4000812")]
		public const uint OVRA_CLIENT_TYPE_TEST = 10u;

		[Token(Token = "0x4000813")]
		public const uint OVRA_CLIENT_TYPE_OTHER = 11u;

		[Token(Token = "0x4000814")]
		public const uint OVRA_CLIENT_TYPE_WWISE_UNKNOWN = 12u;

		[Token(Token = "0x4000815")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2019_1 = 13u;

		[Token(Token = "0x4000816")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2019_2 = 14u;

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xDB2490", Offset = "0xDB2490", VA = "0xDB2490")]
		public ClientType()
		{
		}
	}

	[Token(Token = "0x2000179")]
	public interface PropagationInterface
	{
		[Token(Token = "0x6000784")]
		int SetPropagationQuality(float quality);

		[Token(Token = "0x6000785")]
		int SetPropagationThreadAffinity(ulong cpuMask);

		[Token(Token = "0x6000786")]
		int CreateAudioGeometry(out IntPtr geometry);

		[Token(Token = "0x6000787")]
		int DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x6000788")]
		int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount);

		[Token(Token = "0x6000789")]
		int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x600078A")]
		int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4);

		[Token(Token = "0x600078B")]
		int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x600078C")]
		int AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x600078D")]
		int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x600078E")]
		int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value);

		[Token(Token = "0x600078F")]
		int CreateAudioMaterial(out IntPtr material);

		[Token(Token = "0x6000790")]
		int DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x6000791")]
		int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x6000792")]
		int AudioMaterialReset(IntPtr material, MaterialProperty property);
	}

	[Token(Token = "0x200017A")]
	public class UnityNativeInterface : PropagationInterface
	{
		[Token(Token = "0x4000817")]
		public const string strOSPS = "AudioPluginOculusSpatializer";

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x170000D1")]
		private IntPtr context
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0xDB3108", Offset = "0xDB3108", VA = "0xDB3108")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000794")]
		[Address(RVA = "0xDB316C", Offset = "0xDB316C", VA = "0xDB316C")]
		public static extern int ovrAudio_GetPluginContext(out IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x6000795")]
		[Address(RVA = "0xDB31FC", Offset = "0xDB31FC", VA = "0xDB31FC")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xDB328C", Offset = "0xDB328C", VA = "0xDB328C", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000797")]
		[Address(RVA = "0xDB32B0", Offset = "0xDB32B0", VA = "0xDB32B0")]
		private static extern int ovrAudio_SetPropagationThreadAffinity(IntPtr context, ulong cpuMask);

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xDB3340", Offset = "0xDB3340", VA = "0xDB3340", Slot = "5")]
		public int SetPropagationThreadAffinity(ulong cpuMask)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000799")]
		[Address(RVA = "0xDB3364", Offset = "0xDB3364", VA = "0xDB3364")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry);

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xDB33F0", Offset = "0xDB33F0", VA = "0xDB33F0", Slot = "6")]
		public int CreateAudioGeometry(out IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600079B")]
		[Address(RVA = "0xDB3414", Offset = "0xDB3414", VA = "0xDB3414")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xDB3494", Offset = "0xDB3494", VA = "0xDB3494", Slot = "7")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600079D")]
		[Address(RVA = "0xDB349C", Offset = "0xDB349C", VA = "0xDB349C")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xDB35BC", Offset = "0xDB35BC", VA = "0xDB35BC", Slot = "8")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600079F")]
		[Address(RVA = "0xDB36B4", Offset = "0xDB36B4", VA = "0xDB36B4")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xDB374C", Offset = "0xDB374C", VA = "0xDB374C", Slot = "9")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xDB3758", Offset = "0xDB3758", VA = "0xDB3758")]
		private static extern int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4);

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xDB388C", Offset = "0xDB388C", VA = "0xDB388C", Slot = "10")]
		public int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xDB3898", Offset = "0xDB3898", VA = "0xDB3898")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xDB3944", Offset = "0xDB3944", VA = "0xDB3944", Slot = "11")]
		public int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xDB3950", Offset = "0xDB3950", VA = "0xDB3950")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xDB39FC", Offset = "0xDB39FC", VA = "0xDB39FC", Slot = "12")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xDB3A08", Offset = "0xDB3A08", VA = "0xDB3A08")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xDB3AB4", Offset = "0xDB3AB4", VA = "0xDB3AB4", Slot = "13")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xDB3AC0", Offset = "0xDB3AC0", VA = "0xDB3AC0")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material);

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xDB3B4C", Offset = "0xDB3B4C", VA = "0xDB3B4C", Slot = "15")]
		public int CreateAudioMaterial(out IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xDB3B70", Offset = "0xDB3B70", VA = "0xDB3B70")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xDB3BF0", Offset = "0xDB3BF0", VA = "0xDB3BF0", Slot = "16")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xDB3BF8", Offset = "0xDB3BF8", VA = "0xDB3BF8")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xDB3CA0", Offset = "0xDB3CA0", VA = "0xDB3CA0", Slot = "17")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xDB3CAC", Offset = "0xDB3CAC", VA = "0xDB3CAC")]
		private static extern int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value);

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xDB3D54", Offset = "0xDB3D54", VA = "0xDB3D54", Slot = "14")]
		public int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xDB3D64", Offset = "0xDB3D64", VA = "0xDB3D64")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xDB3DF4", Offset = "0xDB3DF4", VA = "0xDB3DF4", Slot = "18")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xDB243C", Offset = "0xDB243C", VA = "0xDB243C")]
		public UnityNativeInterface()
		{
		}
	}

	[Token(Token = "0x200017B")]
	public class WwisePluginInterface : PropagationInterface
	{
		[Token(Token = "0x4000819")]
		public const string strOSPS = "OculusSpatializerWwise";

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x170000D2")]
		private IntPtr context
		{
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0xDB3E00", Offset = "0xDB3E00", VA = "0xDB3E00")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xDB2284", Offset = "0xDB2284", VA = "0xDB2284")]
		public static extern int ovrAudio_GetPluginContext(out IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xDB3E64", Offset = "0xDB3E64", VA = "0xDB3E64")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xDB3EF4", Offset = "0xDB3EF4", VA = "0xDB3EF4", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xDB3F18", Offset = "0xDB3F18", VA = "0xDB3F18")]
		private static extern int ovrAudio_SetPropagationThreadAffinity(IntPtr context, ulong cpuMask);

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xDB3FA8", Offset = "0xDB3FA8", VA = "0xDB3FA8", Slot = "5")]
		public int SetPropagationThreadAffinity(ulong cpuMask)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xDB3FCC", Offset = "0xDB3FCC", VA = "0xDB3FCC")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry);

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xDB405C", Offset = "0xDB405C", VA = "0xDB405C", Slot = "6")]
		public int CreateAudioGeometry(out IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xDB4080", Offset = "0xDB4080", VA = "0xDB4080")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xDB4100", Offset = "0xDB4100", VA = "0xDB4100", Slot = "7")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xDB4108", Offset = "0xDB4108", VA = "0xDB4108")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xDB4228", Offset = "0xDB4228", VA = "0xDB4228", Slot = "8")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xDB4320", Offset = "0xDB4320", VA = "0xDB4320")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xDB43B8", Offset = "0xDB43B8", VA = "0xDB43B8", Slot = "9")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xDB43C4", Offset = "0xDB43C4", VA = "0xDB43C4")]
		private static extern int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4);

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xDB44F8", Offset = "0xDB44F8", VA = "0xDB44F8", Slot = "10")]
		public int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xDB4504", Offset = "0xDB4504", VA = "0xDB4504")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xDB45B0", Offset = "0xDB45B0", VA = "0xDB45B0", Slot = "11")]
		public int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xDB45BC", Offset = "0xDB45BC", VA = "0xDB45BC")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xDB4668", Offset = "0xDB4668", VA = "0xDB4668", Slot = "12")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xDB4674", Offset = "0xDB4674", VA = "0xDB4674")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xDB4720", Offset = "0xDB4720", VA = "0xDB4720", Slot = "13")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xDB472C", Offset = "0xDB472C", VA = "0xDB472C")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material);

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xDB47BC", Offset = "0xDB47BC", VA = "0xDB47BC", Slot = "15")]
		public int CreateAudioMaterial(out IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xDB47E0", Offset = "0xDB47E0", VA = "0xDB47E0")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xDB4860", Offset = "0xDB4860", VA = "0xDB4860", Slot = "16")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xDB4868", Offset = "0xDB4868", VA = "0xDB4868")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xDB4910", Offset = "0xDB4910", VA = "0xDB4910", Slot = "17")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xDB491C", Offset = "0xDB491C", VA = "0xDB491C")]
		private static extern int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value);

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xDB49C4", Offset = "0xDB49C4", VA = "0xDB49C4", Slot = "14")]
		public int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xDB49D4", Offset = "0xDB49D4", VA = "0xDB49D4")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xDB4A64", Offset = "0xDB4A64", VA = "0xDB4A64", Slot = "18")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xDB2314", Offset = "0xDB2314", VA = "0xDB2314")]
		public WwisePluginInterface()
		{
		}
	}

	[Token(Token = "0x200017C")]
	public class FMODPluginInterface : PropagationInterface
	{
		[Token(Token = "0x400081B")]
		public const string strOSPS = "OculusSpatializerFMOD";

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x170000D3")]
		private IntPtr context
		{
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0xDB2498", Offset = "0xDB2498", VA = "0xDB2498")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xDB2360", Offset = "0xDB2360", VA = "0xDB2360")]
		public static extern int ovrAudio_GetPluginContext(out IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xDB24FC", Offset = "0xDB24FC", VA = "0xDB24FC")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xDB258C", Offset = "0xDB258C", VA = "0xDB258C", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xDB25B0", Offset = "0xDB25B0", VA = "0xDB25B0")]
		private static extern int ovrAudio_SetPropagationThreadAffinity(IntPtr context, ulong cpuMask);

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xDB2640", Offset = "0xDB2640", VA = "0xDB2640", Slot = "5")]
		public int SetPropagationThreadAffinity(ulong cpuMask)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xDB2664", Offset = "0xDB2664", VA = "0xDB2664")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry);

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xDB26F4", Offset = "0xDB26F4", VA = "0xDB26F4", Slot = "6")]
		public int CreateAudioGeometry(out IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xDB2718", Offset = "0xDB2718", VA = "0xDB2718")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xDB2798", Offset = "0xDB2798", VA = "0xDB2798", Slot = "7")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xDB27A0", Offset = "0xDB27A0", VA = "0xDB27A0")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xDB28C0", Offset = "0xDB28C0", VA = "0xDB28C0", Slot = "8")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xDB29B8", Offset = "0xDB29B8", VA = "0xDB29B8")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xDB2A50", Offset = "0xDB2A50", VA = "0xDB2A50", Slot = "9")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xDB2A5C", Offset = "0xDB2A5C", VA = "0xDB2A5C")]
		private static extern int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4);

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xDB2B90", Offset = "0xDB2B90", VA = "0xDB2B90", Slot = "10")]
		public int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xDB2B9C", Offset = "0xDB2B9C", VA = "0xDB2B9C")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xDB2C48", Offset = "0xDB2C48", VA = "0xDB2C48", Slot = "11")]
		public int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xDB2C54", Offset = "0xDB2C54", VA = "0xDB2C54")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xDB2D00", Offset = "0xDB2D00", VA = "0xDB2D00", Slot = "12")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xDB2D0C", Offset = "0xDB2D0C", VA = "0xDB2D0C")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xDB2DB8", Offset = "0xDB2DB8", VA = "0xDB2DB8", Slot = "13")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xDB2DC4", Offset = "0xDB2DC4", VA = "0xDB2DC4")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material);

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xDB2E54", Offset = "0xDB2E54", VA = "0xDB2E54", Slot = "15")]
		public int CreateAudioMaterial(out IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xDB2E78", Offset = "0xDB2E78", VA = "0xDB2E78")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xDB2EF8", Offset = "0xDB2EF8", VA = "0xDB2EF8", Slot = "16")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xDB2F00", Offset = "0xDB2F00", VA = "0xDB2F00")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xDB2FA8", Offset = "0xDB2FA8", VA = "0xDB2FA8", Slot = "17")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xDB2FB4", Offset = "0xDB2FB4", VA = "0xDB2FB4")]
		private static extern int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value);

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xDB305C", Offset = "0xDB305C", VA = "0xDB305C", Slot = "14")]
		public int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xDB306C", Offset = "0xDB306C", VA = "0xDB306C")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xDB30FC", Offset = "0xDB30FC", VA = "0xDB30FC", Slot = "18")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xDB23F0", Offset = "0xDB23F0", VA = "0xDB23F0")]
		public FMODPluginInterface()
		{
		}
	}

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PropagationInterface CachedInterface;

	[Token(Token = "0x1700003F")]
	public static PropagationInterface Interface
	{
		[Token(Token = "0x600039E")]
		[Address(RVA = "0xDB1FE0", Offset = "0xDB1FE0", VA = "0xDB1FE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0xDB205C", Offset = "0xDB205C", VA = "0xDB205C")]
	private static PropagationInterface FindInterface()
	{
		return null;
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0xDB2488", Offset = "0xDB2488", VA = "0xDB2488")]
	public ONSPPropagation()
	{
	}
}
[Token(Token = "0x20000C7")]
public sealed class ONSPPropagationMaterial : MonoBehaviour
{
	[Token(Token = "0x200017D")]
	public enum Preset
	{
		[Token(Token = "0x400081E")]
		Custom,
		[Token(Token = "0x400081F")]
		AcousticTile,
		[Token(Token = "0x4000820")]
		Brick,
		[Token(Token = "0x4000821")]
		BrickPainted,
		[Token(Token = "0x4000822")]
		Carpet,
		[Token(Token = "0x4000823")]
		CarpetHeavy,
		[Token(Token = "0x4000824")]
		CarpetHeavyPadded,
		[Token(Token = "0x4000825")]
		CeramicTile,
		[Token(Token = "0x4000826")]
		Concrete,
		[Token(Token = "0x4000827")]
		ConcreteRough,
		[Token(Token = "0x4000828")]
		ConcreteBlock,
		[Token(Token = "0x4000829")]
		ConcreteBlockPainted,
		[Token(Token = "0x400082A")]
		Curtain,
		[Token(Token = "0x400082B")]
		Foliage,
		[Token(Token = "0x400082C")]
		Glass,
		[Token(Token = "0x400082D")]
		GlassHeavy,
		[Token(Token = "0x400082E")]
		Grass,
		[Token(Token = "0x400082F")]
		Gravel,
		[Token(Token = "0x4000830")]
		GypsumBoard,
		[Token(Token = "0x4000831")]
		PlasterOnBrick,
		[Token(Token = "0x4000832")]
		PlasterOnConcreteBlock,
		[Token(Token = "0x4000833")]
		Soil,
		[Token(Token = "0x4000834")]
		SoundProof,
		[Token(Token = "0x4000835")]
		Snow,
		[Token(Token = "0x4000836")]
		Steel,
		[Token(Token = "0x4000837")]
		Water,
		[Token(Token = "0x4000838")]
		WoodThin,
		[Token(Token = "0x4000839")]
		WoodThick,
		[Token(Token = "0x400083A")]
		WoodFloor,
		[Token(Token = "0x400083B")]
		WoodOnConcrete
	}

	[Serializable]
	[Token(Token = "0x200017E")]
	public sealed class Point
	{
		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float frequency;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float data;

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x157C8E8", Offset = "0x157C8E8", VA = "0x157C8E8")]
		public Point(float frequency = 0f, float data = 0f)
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x157CA60", Offset = "0x157CA60", VA = "0x157CA60")]
		public static implicit operator Point(Vector2 v)
		{
			return null;
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x157CAD0", Offset = "0x157CAD0", VA = "0x157CAD0")]
		public static implicit operator Vector2(Point point)
		{
			return default(Vector2);
		}
	}

	[Serializable]
	[Token(Token = "0x200017F")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA6CFD4", Offset = "0xA6CFD4")]
	public sealed class Spectrum
	{
		[Serializable]
		[Token(Token = "0x20001A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6D10C", Offset = "0xA6D10C")]
		private sealed class <>c
		{
			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Point, float> <>9__3_0;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Point, float> <>9__3_1;

			[Token(Token = "0x600085E")]
			[Address(RVA = "0x157CF3C", Offset = "0x157CF3C", VA = "0x157CF3C")]
			public <>c()
			{
			}

			[Token(Token = "0x600085F")]
			[Address(RVA = "0x157CF44", Offset = "0x157CF44", VA = "0x157CF44")]
			internal float <get_Item>b__3_0(Point p)
			{
				return default(float);
			}

			[Token(Token = "0x6000860")]
			[Address(RVA = "0x157CF5C", Offset = "0x157CF5C", VA = "0x157CF5C")]
			internal float <get_Item>b__3_1(Point p)
			{
				return default(float);
			}
		}

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int selection;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Point> points;

		[Token(Token = "0x170000D4")]
		public float Item
		{
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x157CB08", Offset = "0x157CB08", VA = "0x157CB08")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x157C9DC", Offset = "0x157C9DC", VA = "0x157C9DC")]
		public Spectrum()
		{
		}
	}

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr materialHandle;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6EEBC", Offset = "0xA6EEBC")]
	public Spectrum absorption;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6EEF4", Offset = "0xA6EEF4")]
	public Spectrum transmission;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6EF2C", Offset = "0xA6EF2C")]
	public Spectrum scattering;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Preset preset_;

	[Token(Token = "0x17000040")]
	public Preset preset
	{
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x157442C", Offset = "0x157442C", VA = "0x157442C")]
		get
		{
			return default(Preset);
		}
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1574434", Offset = "0x1574434", VA = "0x1574434")]
		set
		{
		}
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x15745F0", Offset = "0x15745F0", VA = "0x15745F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x15745F4", Offset = "0x15745F4", VA = "0x15745F4")]
	public void StartInternal()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x1574D28", Offset = "0x1574D28", VA = "0x1574D28")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x1574D2C", Offset = "0x1574D2C", VA = "0x1574D2C")]
	public void DestroyInternal()
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x1574764", Offset = "0x1574764", VA = "0x1574764")]
	public void UploadMaterial()
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x157445C", Offset = "0x157445C", VA = "0x157445C")]
	public void SetPreset(Preset preset)
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x1574E14", Offset = "0x1574E14", VA = "0x1574E14")]
	private static void AcousticTile(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x1575294", Offset = "0x1575294", VA = "0x1575294")]
	private static void Brick(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x1575714", Offset = "0x1575714", VA = "0x1575714")]
	private static void BrickPainted(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x1575B94", Offset = "0x1575B94", VA = "0x1575B94")]
	private static void Carpet(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x1576014", Offset = "0x1576014", VA = "0x1576014")]
	private static void CarpetHeavy(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x1576494", Offset = "0x1576494", VA = "0x1576494")]
	private static void CarpetHeavyPadded(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x1576914", Offset = "0x1576914", VA = "0x1576914")]
	private static void CeramicTile(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x1576D94", Offset = "0x1576D94", VA = "0x1576D94")]
	private static void Concrete(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x1577214", Offset = "0x1577214", VA = "0x1577214")]
	private static void ConcreteRough(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x1577694", Offset = "0x1577694", VA = "0x1577694")]
	private static void ConcreteBlock(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x1577B14", Offset = "0x1577B14", VA = "0x1577B14")]
	private static void ConcreteBlockPainted(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x1577F94", Offset = "0x1577F94", VA = "0x1577F94")]
	private static void Curtain(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x1578414", Offset = "0x1578414", VA = "0x1578414")]
	private static void Foliage(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x1578894", Offset = "0x1578894", VA = "0x1578894")]
	private static void Glass(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x1578D0C", Offset = "0x1578D0C", VA = "0x1578D0C")]
	private static void GlassHeavy(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x157918C", Offset = "0x157918C", VA = "0x157918C")]
	private static void Grass(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x15794E8", Offset = "0x15794E8", VA = "0x15794E8")]
	private static void Gravel(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x1579844", Offset = "0x1579844", VA = "0x1579844")]
	private static void GypsumBoard(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x1579CC4", Offset = "0x1579CC4", VA = "0x1579CC4")]
	private static void PlasterOnBrick(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x157A144", Offset = "0x157A144", VA = "0x157A144")]
	private static void PlasterOnConcreteBlock(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x157A5C4", Offset = "0x157A5C4", VA = "0x157A5C4")]
	private static void Soil(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x157A920", Offset = "0x157A920", VA = "0x157A920")]
	private static void SoundProof(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x157AA9C", Offset = "0x157AA9C", VA = "0x157AA9C")]
	private static void Snow(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x157ADF8", Offset = "0x157ADF8", VA = "0x157ADF8")]
	private static void Steel(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x157B270", Offset = "0x157B270", VA = "0x157B270")]
	private static void Water(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x157B6F0", Offset = "0x157B6F0", VA = "0x157B6F0")]
	private static void WoodThin(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x157BB68", Offset = "0x157BB68", VA = "0x157BB68")]
	private static void WoodThick(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x157BFE8", Offset = "0x157BFE8", VA = "0x157BFE8")]
	private static void WoodFloor(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x157C468", Offset = "0x157C468", VA = "0x157C468")]
	private static void WoodOnConcrete(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x157C920", Offset = "0x157C920", VA = "0x157C920")]
	public ONSPPropagationMaterial()
	{
	}
}
[Token(Token = "0x20000C8")]
public class ONSPPropagationSettings : MonoBehaviour
{
	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float quality;

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x157CF74", Offset = "0x157CF74", VA = "0x157CF74")]
	private void Update()
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x157D048", Offset = "0x157D048", VA = "0x157D048")]
	public ONSPPropagationSettings()
	{
	}
}
[Token(Token = "0x20000C9")]
public sealed class ONSPSettings : ScriptableObject
{
	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int voiceLimit;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ONSPSettings instance;

	[Token(Token = "0x17000041")]
	public static ONSPSettings Instance
	{
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x157D61C", Offset = "0x157D61C", VA = "0x157D61C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x157D748", Offset = "0x157D748", VA = "0x157D748")]
	public ONSPSettings()
	{
	}
}
[Token(Token = "0x20000CA")]
public class ONSPVersion : MonoBehaviour
{
	[Token(Token = "0x400043F")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[PreserveSig]
	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x157D758", Offset = "0x157D758", VA = "0x157D758")]
	private static extern void ONSP_GetVersion(ref int Major, ref int Minor, ref int Patch);

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x157D7F0", Offset = "0x157D7F0", VA = "0x157D7F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x157D8FC", Offset = "0x157D8FC", VA = "0x157D8FC")]
	private void Start()
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x157D900", Offset = "0x157D900", VA = "0x157D900")]
	private void Update()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x157D904", Offset = "0x157D904", VA = "0x157D904")]
	public ONSPVersion()
	{
	}
}
[Token(Token = "0x20000CB")]
public class OculusSpatializerUnity : MonoBehaviour
{
	[Token(Token = "0x2000180")]
	public delegate void AudioRaycastCallback(Vector3 origin, Vector3 direction, out Vector3 point, out Vector3 normal, IntPtr data);

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LayerMask layerMask;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool visualizeRoom;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	private bool roomVisualizationInitialized;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int raysPerSecond;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float roomInterpSpeed;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maxWallDistance;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int rayCacheSize;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool dynamicReflectionsEnabled;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float particleSize;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float particleOffset;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject room;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Renderer[] wallRenderer;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float[] dims;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float[] coefs;

	[Token(Token = "0x400044E")]
	private const int HIT_COUNT = 2048;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3[] points;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] normals;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ParticleSystem sys;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LayerMask gLayerMask;

	[Token(Token = "0x4000454")]
	private const string strOSP = "AudioPluginOculusSpatializer";

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0xF9DD2C", Offset = "0xF9DD2C", VA = "0xF9DD2C")]
	private static Vector3 swapHandedness(Vector3 vec)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0xF9DB5C", Offset = "0xF9DB5C", VA = "0xF9DB5C")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA70FCC", Offset = "0xA70FCC")]
	private static void AudioRaycast(Vector3 origin, Vector3 direction, out Vector3 point, out Vector3 normal, IntPtr data)
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0xF9DD64", Offset = "0xF9DD64", VA = "0xF9DD64")]
	private void Start()
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0xF9DEA8", Offset = "0xF9DEA8", VA = "0xF9DEA8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0xF9DF9C", Offset = "0xF9DF9C", VA = "0xF9DF9C")]
	private void Update()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0xF9E960", Offset = "0xF9E960", VA = "0xF9E960")]
	private void inititalizeRoomVisualization()
	{
	}

	[PreserveSig]
	[Token(Token = "0x60003D6")]
	[Address(RVA = "0xF9DE14", Offset = "0xF9DE14", VA = "0xF9DE14")]
	private static extern int OSP_Unity_AssignRaycastCallback(AudioRaycastCallback callback, IntPtr data);

	[PreserveSig]
	[Token(Token = "0x60003D7")]
	[Address(RVA = "0xF9DF0C", Offset = "0xF9DF0C", VA = "0xF9DF0C")]
	private static extern int OSP_Unity_AssignRaycastCallback(IntPtr callback, IntPtr data);

	[PreserveSig]
	[Token(Token = "0x60003D8")]
	[Address(RVA = "0xF9E6C8", Offset = "0xF9E6C8", VA = "0xF9E6C8")]
	private static extern int OSP_Unity_SetDynamicRoomRaysPerSecond(int RaysPerSecond);

	[PreserveSig]
	[Token(Token = "0x60003D9")]
	[Address(RVA = "0xF9E748", Offset = "0xF9E748", VA = "0xF9E748")]
	private static extern int OSP_Unity_SetDynamicRoomInterpSpeed(float InterpSpeed);

	[PreserveSig]
	[Token(Token = "0x60003DA")]
	[Address(RVA = "0xF9E7D0", Offset = "0xF9E7D0", VA = "0xF9E7D0")]
	private static extern int OSP_Unity_SetDynamicRoomMaxWallDistance(float MaxWallDistance);

	[PreserveSig]
	[Token(Token = "0x60003DB")]
	[Address(RVA = "0xF9E858", Offset = "0xF9E858", VA = "0xF9E858")]
	private static extern int OSP_Unity_SetDynamicRoomRaysRayCacheSize(int RayCacheSize);

	[PreserveSig]
	[Token(Token = "0x60003DC")]
	[Address(RVA = "0xF9E8D8", Offset = "0xF9E8D8", VA = "0xF9E8D8")]
	private static extern int OSP_Unity_UpdateRoomModel(float wetLevel);

	[PreserveSig]
	[Token(Token = "0x60003DD")]
	[Address(RVA = "0xF9F7D4", Offset = "0xF9F7D4", VA = "0xF9F7D4")]
	private static extern int OSP_Unity_GetRoomDimensions(float[] roomDimensions, float[] reflectionsCoefs, out Vector3 position);

	[PreserveSig]
	[Token(Token = "0x60003DE")]
	[Address(RVA = "0xF9F87C", Offset = "0xF9F87C", VA = "0xF9F87C")]
	private static extern int OSP_Unity_GetRaycastHits(Vector3[] points, Vector3[] normals, int length);

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0xF9F924", Offset = "0xF9F924", VA = "0xF9F924")]
	public OculusSpatializerUnity()
	{
	}
}
[Token(Token = "0x20000CC")]
public struct ReflectionSnapshot
{
	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public AudioMixerSnapshot mixerSnapshot;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float fadeTime;
}
[Token(Token = "0x20000CD")]
public class ONSPReflectionZone : MonoBehaviour
{
	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioMixerSnapshot mixerSnapshot;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float fadeTime;

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Stack<ReflectionSnapshot> snapshotList;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ReflectionSnapshot currentSnapshot;

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x157D058", Offset = "0x157D058", VA = "0x157D058")]
	private void Start()
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x157D05C", Offset = "0x157D05C", VA = "0x157D05C")]
	private void Update()
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x157D060", Offset = "0x157D060", VA = "0x157D060")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x157D1C8", Offset = "0x157D1C8", VA = "0x157D1C8")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x157D0AC", Offset = "0x157D0AC", VA = "0x157D0AC")]
	private bool CheckForAudioListener(GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x157D13C", Offset = "0x157D13C", VA = "0x157D13C")]
	private void PushCurrentMixerShapshot()
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x157D214", Offset = "0x157D214", VA = "0x157D214")]
	private void PopCurrentMixerSnapshot()
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x157D2AC", Offset = "0x157D2AC", VA = "0x157D2AC")]
	private void SetReflectionValues()
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x157D41C", Offset = "0x157D41C", VA = "0x157D41C")]
	private void SetReflectionValues(ref ReflectionSnapshot mss)
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x157D58C", Offset = "0x157D58C", VA = "0x157D58C")]
	public ONSPReflectionZone()
	{
	}
}
[Token(Token = "0x20000CE")]
public class SaveSettingsOnClose : MonoBehaviour
{
	[Token(Token = "0x60003EC")]
	[Address(RVA = "0xDC0BDC", Offset = "0xDC0BDC", VA = "0xDC0BDC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0xDC0C80", Offset = "0xDC0C80", VA = "0xDC0C80")]
	public SaveSettingsOnClose()
	{
	}
}
[Token(Token = "0x20000CF")]
public class SpectatorCameraFovUI : MonoBehaviour
{
	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button3D minus;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Button3D plus;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro text;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float step;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SpectatorCameraSettings _settings;

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0xDC4400", Offset = "0xDC4400", VA = "0xDC4400")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0xDC46B8", Offset = "0xDC46B8", VA = "0xDC46B8")]
	private void Minus()
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0xDC46FC", Offset = "0xDC46FC", VA = "0xDC46FC")]
	private void Plus()
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0xDC4740", Offset = "0xDC4740", VA = "0xDC4740")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0xDC4598", Offset = "0xDC4598", VA = "0xDC4598")]
	private void OnSettingsChanged(SpectatorCameraSettings settings)
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0xDC4894", Offset = "0xDC4894", VA = "0xDC4894")]
	public SpectatorCameraFovUI()
	{
	}
}
[Token(Token = "0x20000D0")]
public class SpectatorCameraSmoothUI : MonoBehaviour
{
	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button3D minus;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Button3D plus;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro text;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float step;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SpectatorCameraSettings _settings;

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0xDC48A4", Offset = "0xDC48A4", VA = "0xDC48A4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0xDC4B58", Offset = "0xDC4B58", VA = "0xDC4B58")]
	private void Minus()
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0xDC4B9C", Offset = "0xDC4B9C", VA = "0xDC4B9C")]
	private void Plus()
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0xDC4BE0", Offset = "0xDC4BE0", VA = "0xDC4BE0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0xDC4A3C", Offset = "0xDC4A3C", VA = "0xDC4A3C")]
	private void OnSettingsChanged(SpectatorCameraSettings settings)
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0xDC4D34", Offset = "0xDC4D34", VA = "0xDC4D34")]
	public SpectatorCameraSmoothUI()
	{
	}
}
[Token(Token = "0x20000D1")]
public class DeviceDebug : MonoBehaviour
{
	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform xrRig;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform ghost;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform unoffsettedHand;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshPro deviceInfo;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshPro offsetInfo;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshPro offsetInfo2;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TrackingOffsets offsetManager;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Action<Transform, string, string> OnHitBack;

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0xDA4BC4", Offset = "0xDA4BC4", VA = "0xDA4BC4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0xDA4C98", Offset = "0xDA4C98", VA = "0xDA4C98")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0xDA4D74", Offset = "0xDA4D74", VA = "0xDA4D74")]
	private void SendHitBack()
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0xDA4EB4", Offset = "0xDA4EB4", VA = "0xDA4EB4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0xDA4EB8", Offset = "0xDA4EB8", VA = "0xDA4EB8")]
	private void Update()
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0xDA5350", Offset = "0xDA5350", VA = "0xDA5350")]
	public DeviceDebug()
	{
	}
}
[Token(Token = "0x20000D2")]
public class DeviceOffsetChanger : MonoBehaviour
{
	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isRotate;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject selectedFX;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject handlingFX;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TrackingOffsets offsetManager;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform infoText;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float infoTextDist;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool isSelecting;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	private bool isHandling;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform hand;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool isLeftHand;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 startPos;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 offset;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Quaternion startRot;

	[Token(Token = "0x6000400")]
	[Address(RVA = "0xDA5358", Offset = "0xDA5358", VA = "0xDA5358")]
	private void Update()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0xDA565C", Offset = "0xDA565C", VA = "0xDA565C")]
	private void SetOffset()
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0xDA5754", Offset = "0xDA5754", VA = "0xDA5754")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0xDA5834", Offset = "0xDA5834", VA = "0xDA5834")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0xDA58BC", Offset = "0xDA58BC", VA = "0xDA58BC")]
	public DeviceOffsetChanger()
	{
	}
}
[Token(Token = "0x20000D3")]
public class ExitCube : MonoBehaviour
{
	[Token(Token = "0x6000405")]
	[Address(RVA = "0xDA58D8", Offset = "0xDA58D8", VA = "0xDA58D8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0xDA58E0", Offset = "0xDA58E0", VA = "0xDA58E0")]
	public ExitCube()
	{
	}
}
[Token(Token = "0x20000D4")]
public class KimiHandsToggleCube : MonoBehaviour
{
	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> HandsObj;

	[Token(Token = "0x6000407")]
	[Address(RVA = "0xDA6700", Offset = "0xDA6700", VA = "0xDA6700")]
	private void Start()
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0xDA67B8", Offset = "0xDA67B8", VA = "0xDA67B8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0xDA67BC", Offset = "0xDA67BC", VA = "0xDA67BC")]
	private void ToggleHands()
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0xDA68CC", Offset = "0xDA68CC", VA = "0xDA68CC")]
	public KimiHandsToggleCube()
	{
	}
}
[Token(Token = "0x20000D5")]
public class SaveOffsets_Debug : MonoBehaviour
{
	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshPro savedText;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string pathFolder;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Action OnHit;

	[Token(Token = "0x600040B")]
	[Address(RVA = "0xDC019C", Offset = "0xDC019C", VA = "0xDC019C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0xDC0278", Offset = "0xDC0278", VA = "0xDC0278")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0xDC0354", Offset = "0xDC0354", VA = "0xDC0354")]
	private void Update()
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0xDC040C", Offset = "0xDC040C", VA = "0xDC040C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0xDC0470", Offset = "0xDC0470", VA = "0xDC0470")]
	private void OnHitBack(Transform trans, string device, string platform)
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0xDC0988", Offset = "0xDC0988", VA = "0xDC0988")]
	public bool SaveFile(string path, string fileName, string data)
	{
		return default(bool);
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0xDC0BD4", Offset = "0xDC0BD4", VA = "0xDC0BD4")]
	public SaveOffsets_Debug()
	{
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x20000D6")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x17000042")]
		public bool Highlight
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0xF8BFDC", Offset = "0xF8BFDC", VA = "0xF8BFDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0xF8BFE4", Offset = "0xF8BFE4", VA = "0xF8BFE4")]
			set
			{
			}
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xF8BFF0", Offset = "0xF8BFF0", VA = "0xF8BFF0")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xF8C1BC", Offset = "0xF8C1BC", VA = "0xF8C1BC", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xF8C1E4", Offset = "0xF8C1E4", VA = "0xF8C1E4", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xF8C20C", Offset = "0xF8C20C", VA = "0xF8C20C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xF8C0BC", Offset = "0xF8C0BC", VA = "0xF8C0BC")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xF8C49C", Offset = "0xF8C49C", VA = "0xF8C49C")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x17000043")]
		public bool InRange
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0xF8C8FC", Offset = "0xF8C8FC", VA = "0xF8C8FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600041C")]
			[Address(RVA = "0xF8C904", Offset = "0xF8C904", VA = "0xF8C904")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public bool Targeted
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0xF8CA80", Offset = "0xF8CA80", VA = "0xF8CA80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600041E")]
			[Address(RVA = "0xF8CA88", Offset = "0xF8CA88", VA = "0xF8CA88")]
			set
			{
			}
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xF8CA94", Offset = "0xF8CA94", VA = "0xF8CA94", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xF8C910", Offset = "0xF8C910", VA = "0xF8C910")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xF8CC70", Offset = "0xF8CC70", VA = "0xF8CC70")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA6CCC0", Offset = "0xA6CCC0")]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x17000045")]
		public bool UseSpherecast
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0xF8CC78", Offset = "0xF8CC78", VA = "0xF8CC78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000423")]
			[Address(RVA = "0xF8CC80", Offset = "0xF8CC80", VA = "0xF8CC80")]
			set
			{
			}
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xF8CC9C", Offset = "0xF8CC9C", VA = "0xF8CC9C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xF8CEB4", Offset = "0xF8CEB4", VA = "0xF8CEB4", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xF8D828", Offset = "0xF8D828", VA = "0xF8D828", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xF8DE00", Offset = "0xF8DE00", VA = "0xF8DE00", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xF8E1E0", Offset = "0xF8E1E0", VA = "0xF8E1E0")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xF8D120", Offset = "0xF8D120", VA = "0xF8D120")]
		protected bool FindTarget(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xF8E2BC", Offset = "0xF8E2BC", VA = "0xF8E2BC")]
		protected bool FindTargetWithSpherecast(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xF8E758", Offset = "0xF8E758", VA = "0xF8E758", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xF8E770", Offset = "0xF8E770", VA = "0xF8E770", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xF8E778", Offset = "0xF8E778", VA = "0xF8E778")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xF90368", Offset = "0xF90368", VA = "0xF90368")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xF90418", Offset = "0xF90418", VA = "0xF90418")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xF904C4", Offset = "0xF904C4", VA = "0xF904C4")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x2000181")]
		public enum CrosshairState
		{
			[Token(Token = "0x4000841")]
			Disabled,
			[Token(Token = "0x4000842")]
			Enabled,
			[Token(Token = "0x4000843")]
			Targeted
		}

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xF904CC", Offset = "0xF904CC", VA = "0xF904CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xF8CBD4", Offset = "0xF8CBD4", VA = "0xF8CBD4")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xF9053C", Offset = "0xF9053C", VA = "0xF9053C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xF90584", Offset = "0xF90584", VA = "0xF90584")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x6000435")]
		[Address(RVA = "0xF95644", Offset = "0xF95644", VA = "0xF95644")]
		private void Start()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xF95710", Offset = "0xF95710", VA = "0xF95710")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xF9571C", Offset = "0xF9571C", VA = "0xF9571C")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xF95728", Offset = "0xF95728", VA = "0xF95728")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xF8ABC4", Offset = "0xF8ABC4", VA = "0xF8ABC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xF8AC1C", Offset = "0xF8AC1C", VA = "0xF8AC1C")]
		private void Update()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xF8AEC0", Offset = "0xF8AEC0", VA = "0xF8AEC0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xF8AFB0", Offset = "0xF8AFB0", VA = "0xF8AFB0")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xF8AC20", Offset = "0xF8AC20", VA = "0xF8AC20")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xF8B0A0", Offset = "0xF8B0A0", VA = "0xF8B0A0")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x2000182")]
		public enum ContactTest
		{
			[Token(Token = "0x4000845")]
			PerpenTest,
			[Token(Token = "0x4000846")]
			BackwardsPress
		}

		[Token(Token = "0x40004A2")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x40004A3")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private InteractableState _currentButtonState;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x17000046")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0xF8B150", Offset = "0xF8B150", VA = "0xF8B150", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000047")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0xF8B158", Offset = "0xF8B158", VA = "0xF8B158")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xF8B164", Offset = "0xF8B164", VA = "0xF8B164", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xF8B2DC", Offset = "0xF8B2DC", VA = "0xF8B2DC")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xF8B4FC", Offset = "0xF8B4FC", VA = "0xF8B4FC", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xF8BA40", Offset = "0xF8BA40", VA = "0xF8BA40")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xF8B958", Offset = "0xF8B958", VA = "0xF8B958")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xF8BBB4", Offset = "0xF8BBB4", VA = "0xF8BBB4")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xF8BCA8", Offset = "0xF8BCA8", VA = "0xF8BCA8")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xF8BDD4", Offset = "0xF8BDD4", VA = "0xF8BDD4")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F0B4", Offset = "0xA6F0B4")]
		private Collider <Collider>k__BackingField;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F0C4", Offset = "0xA6F0C4")]
		private Interactable <ParentInteractable>k__BackingField;

		[Token(Token = "0x17000048")]
		public Collider Collider
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0xF8BED8", Offset = "0xF8BED8", VA = "0xF8BED8", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71030", Offset = "0xA71030")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044A")]
			[Address(RVA = "0xF8BEE0", Offset = "0xF8BEE0", VA = "0xF8BEE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71040", Offset = "0xA71040")]
			private set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0xF8BEE8", Offset = "0xF8BEE8", VA = "0xF8BEE8", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71050", Offset = "0xA71050")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044C")]
			[Address(RVA = "0xF8BEF0", Offset = "0xF8BEF0", VA = "0xF8BEF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71060", Offset = "0xA71060")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0xF8BEF8", Offset = "0xF8BEF8", VA = "0xF8BEF8", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xF8BF48", Offset = "0xF8BF48", VA = "0xF8BF48")]
		private void Awake()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xF8BFD4", Offset = "0xF8BFD4", VA = "0xF8BFD4")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public interface ColliderZone
	{
		[Token(Token = "0x1700004B")]
		Collider Collider
		{
			[Token(Token = "0x6000450")]
			get;
		}

		[Token(Token = "0x1700004C")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x6000451")]
			get;
		}

		[Token(Token = "0x1700004D")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000452")]
			get;
		}
	}
	[Token(Token = "0x20000E0")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xF8B440", Offset = "0xF8B440", VA = "0xF8B440")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public enum InteractionType
	{
		[Token(Token = "0x40004B7")]
		Enter,
		[Token(Token = "0x40004B8")]
		Stay,
		[Token(Token = "0x40004B9")]
		Exit
	}
	[Token(Token = "0x20000E2")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x2000183")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x4000848")]
			Mesh,
			[Token(Token = "0x4000849")]
			Skeleton,
			[Token(Token = "0x400084A")]
			Both
		}

		[Token(Token = "0x2000184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6D00C", Offset = "0xA6D00C")]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x170000D5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000802")]
				[Address(RVA = "0xF91568", Offset = "0xF91568", VA = "0xF91568", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000804")]
				[Address(RVA = "0xF915D0", Offset = "0xF915D0", VA = "0xF915D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0xF90FEC", Offset = "0xF90FEC", VA = "0xF90FEC")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0xF91314", Offset = "0xF91314", VA = "0xF91314", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000801")]
			[Address(RVA = "0xF91318", Offset = "0xF91318", VA = "0xF91318", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000803")]
			[Address(RVA = "0xF91570", Offset = "0xF91570", VA = "0xF91570", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004BA")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F0F4", Offset = "0xA6F0F4")]
		private static HandsManager <Instance>k__BackingField;

		[Token(Token = "0x1700004E")]
		public OVRHand RightHand
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0xF8F3F4", Offset = "0xF8F3F4", VA = "0xF8F3F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000455")]
			[Address(RVA = "0xF9058C", Offset = "0xF9058C", VA = "0xF9058C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0xF8FFEC", Offset = "0xF8FFEC", VA = "0xF8FFEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000457")]
			[Address(RVA = "0xF905FC", Offset = "0xF905FC", VA = "0xF905FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0xF9066C", Offset = "0xF9066C", VA = "0xF9066C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000459")]
			[Address(RVA = "0xF906A4", Offset = "0xF906A4", VA = "0xF906A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0xF90714", Offset = "0xF90714", VA = "0xF90714")]
			get
			{
				return null;
			}
			[Token(Token = "0x600045B")]
			[Address(RVA = "0xF9074C", Offset = "0xF9074C", VA = "0xF9074C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0xF907BC", Offset = "0xF907BC", VA = "0xF907BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600045D")]
			[Address(RVA = "0xF907F4", Offset = "0xF907F4", VA = "0xF907F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0xF8F3C0", Offset = "0xF8F3C0", VA = "0xF8F3C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600045F")]
			[Address(RVA = "0xF90864", Offset = "0xF90864", VA = "0xF90864")]
			private set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0xF8FFB8", Offset = "0xF8FFB8", VA = "0xF8FFB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000461")]
			[Address(RVA = "0xF908D0", Offset = "0xF908D0", VA = "0xF908D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0xF9093C", Offset = "0xF9093C", VA = "0xF9093C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000463")]
			[Address(RVA = "0xF90970", Offset = "0xF90970", VA = "0xF90970")]
			private set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0xF909DC", Offset = "0xF909DC", VA = "0xF909DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000465")]
			[Address(RVA = "0xF90A10", Offset = "0xF90A10", VA = "0xF90A10")]
			private set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0xF90A7C", Offset = "0xF90A7C", VA = "0xF90A7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000467")]
			[Address(RVA = "0xF90AB0", Offset = "0xF90AB0", VA = "0xF90AB0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public static HandsManager Instance
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0xF90B1C", Offset = "0xF90B1C", VA = "0xF90B1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71070", Offset = "0xA71070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000469")]
			[Address(RVA = "0xF90B6C", Offset = "0xF90B6C", VA = "0xF90B6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71080", Offset = "0xA71080")]
			private set
			{
			}
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xF90BC4", Offset = "0xF90BC4", VA = "0xF90BC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xF90F64", Offset = "0xF90F64", VA = "0xF90F64")]
		private void Update()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xF90EE8", Offset = "0xF90EE8", VA = "0xF90EE8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA71090", Offset = "0xA71090")]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xF8C750", Offset = "0xF8C750", VA = "0xF8C750")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xF91018", Offset = "0xF91018", VA = "0xF91018")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xF90024", Offset = "0xF90024", VA = "0xF90024")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xF8F230", Offset = "0xF8F230", VA = "0xF8F230")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xF911F8", Offset = "0xF911F8", VA = "0xF911F8")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000185")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0xF91D20", Offset = "0xF91D20", VA = "0xF91D20")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x17000059")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0xF915D8", Offset = "0xF915D8", VA = "0xF915D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x6000473")]
			[Address(RVA = "0xF915E0", Offset = "0xF915E0", VA = "0xF915E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0xF915E8", Offset = "0xF915E8", VA = "0xF915E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0xF915F0", Offset = "0xF915F0", VA = "0xF915F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x6000476")]
			[Address(RVA = "0xF915F8", Offset = "0xF915F8", VA = "0xF915F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA710F4", Offset = "0xA710F4")]
			add
			{
			}
			[Token(Token = "0x6000477")]
			[Address(RVA = "0xF9169C", Offset = "0xF9169C", VA = "0xF9169C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71104", Offset = "0xA71104")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0xF917B4", Offset = "0xF917B4", VA = "0xF917B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71114", Offset = "0xA71114")]
			add
			{
			}
			[Token(Token = "0x600047A")]
			[Address(RVA = "0xF91858", Offset = "0xF91858", VA = "0xF91858")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71124", Offset = "0xA71124")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0xF91970", Offset = "0xF91970", VA = "0xF91970")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71134", Offset = "0xA71134")]
			add
			{
			}
			[Token(Token = "0x600047D")]
			[Address(RVA = "0xF91A14", Offset = "0xF91A14", VA = "0xF91A14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71144", Offset = "0xA71144")]
			remove
			{
			}
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xF91740", Offset = "0xF91740", VA = "0xF91740", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xF918FC", Offset = "0xF918FC", VA = "0xF918FC", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xF91AB8", Offset = "0xF91AB8", VA = "0xF91AB8", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x600047F")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xF8B278", Offset = "0xF8B278", VA = "0xF8B278", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xF91BF4", Offset = "0xF91BF4", VA = "0xF91BF4", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xF8BED0", Offset = "0xF8BED0", VA = "0xF8BED0")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x40004D2")]
		None,
		[Token(Token = "0x40004D3")]
		Proximity,
		[Token(Token = "0x40004D4")]
		Contact,
		[Token(Token = "0x40004D5")]
		Action
	}
	[Token(Token = "0x20000E5")]
	public enum InteractableState
	{
		[Token(Token = "0x40004D7")]
		Default,
		[Token(Token = "0x40004D8")]
		ProximityState,
		[Token(Token = "0x40004D9")]
		ContactState,
		[Token(Token = "0x40004DA")]
		ActionState
	}
	[Token(Token = "0x20000E6")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xF8BAEC", Offset = "0xF8BAEC", VA = "0xF8BAEC")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x1700005D")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0xF91D70", Offset = "0xF91D70", VA = "0xF91D70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xF91B2C", Offset = "0xF91B2C", VA = "0xF91B2C")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xF91C58", Offset = "0xF91C58", VA = "0xF91C58")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xF91DD8", Offset = "0xF91DD8", VA = "0xF91DD8")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x2000186")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6D01C", Offset = "0xA6D01C")]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x170000D7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600080A")]
				[Address(RVA = "0xF92EE0", Offset = "0xF92EE0", VA = "0xF92EE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600080C")]
				[Address(RVA = "0xF92F48", Offset = "0xF92F48", VA = "0xF92F48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0xF9292C", Offset = "0xF9292C", VA = "0xF9292C")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000807")]
			[Address(RVA = "0xF92A58", Offset = "0xF92A58", VA = "0xF92A58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000808")]
			[Address(RVA = "0xF92ACC", Offset = "0xF92ACC", VA = "0xF92ACC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000809")]
			[Address(RVA = "0xF92A74", Offset = "0xF92A74", VA = "0xF92A74")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600080B")]
			[Address(RVA = "0xF92EE8", Offset = "0xF92EE8", VA = "0xF92EE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xF9280C", Offset = "0xF9280C", VA = "0xF9280C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xF92888", Offset = "0xF92888", VA = "0xF92888")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA71154", Offset = "0xA71154")]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xF92958", Offset = "0xF92958", VA = "0xF92958")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xF92A50", Offset = "0xF92A50", VA = "0xF92A50")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x1700005E")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0xF8EC5C", Offset = "0xF8EC5C", VA = "0xF8EC5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xF8EDC8", Offset = "0xF8EDC8", VA = "0xF8EDC8")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xF92F50", Offset = "0xF92F50", VA = "0xF92F50")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xF92FFC", Offset = "0xF92FFC", VA = "0xF92FFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xF932C4", Offset = "0xF932C4", VA = "0xF932C4")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xF9330C", Offset = "0xF9330C", VA = "0xF9330C")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xF93578", Offset = "0xF93578", VA = "0xF93578")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xF936A4", Offset = "0xF936A4", VA = "0xF936A4")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x2000187")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6D02C", Offset = "0xA6D02C")]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x170000D9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000810")]
				[Address(RVA = "0xF90234", Offset = "0xF90234", VA = "0xF90234", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000812")]
				[Address(RVA = "0xF9029C", Offset = "0xF9029C", VA = "0xF9029C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600080D")]
			[Address(RVA = "0xF8EEF0", Offset = "0xF8EEF0", VA = "0xF8EEF0")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600080E")]
			[Address(RVA = "0xF8FC30", Offset = "0xF8FC30", VA = "0xF8FC30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600080F")]
			[Address(RVA = "0xF8FC34", Offset = "0xF8FC34", VA = "0xF8FC34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0xF9023C", Offset = "0xF9023C", VA = "0xF9023C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004EA")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x1700005F")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0xF8EB28", Offset = "0xF8EB28", VA = "0xF8EB28", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x17000060")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0xF8EB30", Offset = "0xF8EB30", VA = "0xF8EB30", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x17000061")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0xF8EB38", Offset = "0xF8EB38", VA = "0xF8EB38", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000062")]
		public override bool EnableState
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0xF8EB40", Offset = "0xF8EB40", VA = "0xF8EB40", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0xF8EB6C", Offset = "0xF8EB6C", VA = "0xF8EB6C", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xF8EBA8", Offset = "0xF8EBA8", VA = "0xF8EBA8", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xF8EE74", Offset = "0xF8EE74", VA = "0xF8EE74")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA711B8", Offset = "0xA711B8")]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xF8EF1C", Offset = "0xF8EF1C", VA = "0xF8EF1C")]
		private void Update()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xF8F42C", Offset = "0xF8F42C", VA = "0xF8F42C")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xF8F6A4", Offset = "0xF8F6A4", VA = "0xF8F6A4")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xF8F7E4", Offset = "0xF8F7E4", VA = "0xF8F7E4", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xF8FABC", Offset = "0xF8FABC", VA = "0xF8FABC", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xF8FAC0", Offset = "0xF8FAC0", VA = "0xF8FAC0", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xF8FAC4", Offset = "0xF8FAC4", VA = "0xF8FAC4")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class FingerTipPokeToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F184", Offset = "0xA6F184")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F194", Offset = "0xA6F194")]
		private bool <ToolActivateState>k__BackingField;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F1A4", Offset = "0xA6F1A4")]
		private float <SphereRadius>k__BackingField;

		[Token(Token = "0x17000063")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xF902A4", Offset = "0xF902A4", VA = "0xF902A4", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7121C", Offset = "0xA7121C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xF902AC", Offset = "0xF902AC", VA = "0xF902AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7122C", Offset = "0xA7122C")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public bool EnableState
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xF902B4", Offset = "0xF902B4", VA = "0xF902B4", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xF902D0", Offset = "0xF902D0", VA = "0xF902D0", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0xF902F0", Offset = "0xF902F0", VA = "0xF902F0", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7123C", Offset = "0xA7123C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0xF902F8", Offset = "0xF902F8", VA = "0xF902F8", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7124C", Offset = "0xA7124C")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public float SphereRadius
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0xF90304", Offset = "0xF90304", VA = "0xF90304")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7125C", Offset = "0xA7125C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0xF9030C", Offset = "0xF9030C", VA = "0xF9030C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7126C", Offset = "0xA7126C")]
			private set
			{
			}
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xF90314", Offset = "0xF90314", VA = "0xF90314")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xF9035C", Offset = "0xF9035C", VA = "0xF9035C", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xF90360", Offset = "0xF90360", VA = "0xF90360")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x40004FA")]
		None = 0,
		[Token(Token = "0x40004FB")]
		Ray = 1,
		[Token(Token = "0x40004FC")]
		Poke = 4,
		[Token(Token = "0x40004FD")]
		All = -1
	}
	[Token(Token = "0x20000ED")]
	public enum ToolInputState
	{
		[Token(Token = "0x40004FF")]
		Inactive,
		[Token(Token = "0x4000500")]
		PrimaryInputDown,
		[Token(Token = "0x4000501")]
		PrimaryInputDownStay,
		[Token(Token = "0x4000502")]
		PrimaryInputUp
	}
	[Token(Token = "0x20000EE")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xF8FA64", Offset = "0xF8FA64", VA = "0xF8FA64")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F1B4", Offset = "0xA6F1B4")]
		private bool <IsRightHandedTool>k__BackingField;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F1C4", Offset = "0xA6F1C4")]
		private Vector3 <Velocity>k__BackingField;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F1D4", Offset = "0xA6F1D4")]
		private Vector3 <InteractionPosition>k__BackingField;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x17000067")]
		public Transform ToolTransform
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0xF8BDCC", Offset = "0xF8BDCC", VA = "0xF8BDCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0xF91E58", Offset = "0xF91E58", VA = "0xF91E58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7127C", Offset = "0xA7127C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0xF91E60", Offset = "0xF91E60", VA = "0xF91E60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7128C", Offset = "0xA7128C")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x60004B2")]
			get;
		}

		[Token(Token = "0x1700006A")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x60004B3")]
			get;
		}

		[Token(Token = "0x1700006B")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x60004B4")]
			get;
		}

		[Token(Token = "0x1700006C")]
		public Vector3 Velocity
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0xF91E6C", Offset = "0xF91E6C", VA = "0xF91E6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA7129C", Offset = "0xA7129C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0xF91E78", Offset = "0xF91E78", VA = "0xF91E78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA712AC", Offset = "0xA712AC")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0xF91E84", Offset = "0xF91E84", VA = "0xF91E84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA712BC", Offset = "0xA712BC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0xF91E90", Offset = "0xF91E90", VA = "0xF91E90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA712CC", Offset = "0xA712CC")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public abstract bool EnableState
		{
			[Token(Token = "0x60004BD")]
			get;
			[Token(Token = "0x60004BE")]
			set;
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xF91E9C", Offset = "0xF91E9C", VA = "0xF91E9C")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x60004BB")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x60004BC")]
		public abstract void DeFocus();

		[Token(Token = "0x60004BF")]
		public abstract void Initialize();

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xF91EA4", Offset = "0xF91EA4", VA = "0xF91EA4")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xF91EF4", Offset = "0xF91EF4", VA = "0xF91EF4")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xF91F4C", Offset = "0xF91F4C", VA = "0xF91F4C", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xF921AC", Offset = "0xF921AC", VA = "0xF921AC", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xF8FAD8", Offset = "0xF8FAD8", VA = "0xF8FAD8")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public interface InteractableToolView
	{
		[Token(Token = "0x1700006F")]
		InteractableTool InteractableTool
		{
			[Token(Token = "0x60004C5")]
			get;
		}

		[Token(Token = "0x17000070")]
		bool EnableState
		{
			[Token(Token = "0x60004C7")]
			get;
			[Token(Token = "0x60004C8")]
			set;
		}

		[Token(Token = "0x17000071")]
		bool ToolActivateState
		{
			[Token(Token = "0x60004C9")]
			get;
			[Token(Token = "0x60004CA")]
			set;
		}

		[Token(Token = "0x60004C6")]
		void SetFocusedInteractable(Interactable interactable);
	}
	[Token(Token = "0x20000F1")]
	public class PinchStateModule
	{
		[Token(Token = "0x2000188")]
		private enum PinchState
		{
			[Token(Token = "0x400085B")]
			None,
			[Token(Token = "0x400085C")]
			PinchDown,
			[Token(Token = "0x400085D")]
			PinchStay,
			[Token(Token = "0x400085E")]
			PinchUp
		}

		[Token(Token = "0x400050F")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x17000072")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0xF95730", Offset = "0xF95730", VA = "0xF95730")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000073")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0xF957BC", Offset = "0xF957BC", VA = "0xF957BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000074")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0xF95848", Offset = "0xF95848", VA = "0xF95848")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xF958D4", Offset = "0xF958D4", VA = "0xF958D4")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xF95908", Offset = "0xF95908", VA = "0xF95908")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x4000512")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x4000513")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x4000514")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x4000515")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x4000516")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6F1F4", Offset = "0xA6F1F4")]
		[SerializeField]
		private float _coneAngleDegrees;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x17000075")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0xF95BD8", Offset = "0xF95BD8", VA = "0xF95BD8", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x17000076")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0xF95BE0", Offset = "0xF95BE0", VA = "0xF95BE0", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x17000077")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0xF95C48", Offset = "0xF95C48", VA = "0xF95C48", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000078")]
		public override bool EnableState
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0xF95C50", Offset = "0xF95C50", VA = "0xF95C50", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0xF95C94", Offset = "0xF95C94", VA = "0xF95C94", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xF95D08", Offset = "0xF95D08", VA = "0xF95D08", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xF95D68", Offset = "0xF95D68", VA = "0xF95D68")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xF95E04", Offset = "0xF95E04", VA = "0xF95E04")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xF96104", Offset = "0xF96104", VA = "0xF96104")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xF96200", Offset = "0xF96200", VA = "0xF96200", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xF96588", Offset = "0xF96588", VA = "0xF96588")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xF9672C", Offset = "0xF9672C", VA = "0xF9672C")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xF96854", Offset = "0xF96854", VA = "0xF96854")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xF96B8C", Offset = "0xF96B8C", VA = "0xF96B8C")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xF96F9C", Offset = "0xF96F9C", VA = "0xF96F9C", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xF97088", Offset = "0xF97088", VA = "0xF97088", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xF970C4", Offset = "0xF970C4", VA = "0xF970C4")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class RayToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x4000522")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x4000523")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F268", Offset = "0xA6F268")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x17000079")]
		public bool EnableState
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0xF95C78", Offset = "0xF95C78", VA = "0xF95C78", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0xF95CB0", Offset = "0xF95CB0", VA = "0xF95CB0", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0xF971B8", Offset = "0xF971B8", VA = "0xF971B8", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0xF960C8", Offset = "0xF960C8", VA = "0xF960C8", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0xF97404", Offset = "0xF97404", VA = "0xF97404", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA712DC", Offset = "0xA712DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0xF9740C", Offset = "0xF9740C", VA = "0xF9740C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA712EC", Offset = "0xA712EC")]
			set
			{
			}
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xF971C0", Offset = "0xF971C0", VA = "0xF971C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xF96FD8", Offset = "0xF96FD8", VA = "0xF96FD8", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xF97414", Offset = "0xF97414", VA = "0xF97414")]
		private void Update()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xF97740", Offset = "0xF97740", VA = "0xF97740")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xF97930", Offset = "0xF97930", VA = "0xF97930")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x1700007C")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0xF8E798", Offset = "0xF8E798", VA = "0xF8E798")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0xF8E7A0", Offset = "0xF8E7A0", VA = "0xF8E7A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0xF8E828", Offset = "0xF8E828", VA = "0xF8E828")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0xF8E830", Offset = "0xF8E830", VA = "0xF8E830")]
			set
			{
			}
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xF8E89C", Offset = "0xF8E89C", VA = "0xF8E89C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xF8EB00", Offset = "0xF8EB00", VA = "0xF8EB00")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xF8EB10", Offset = "0xF8EB10", VA = "0xF8EB10")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xF8EB20", Offset = "0xF8EB20", VA = "0xF8EB20")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xF8C588", Offset = "0xF8C588", VA = "0xF8C588")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xF8C58C", Offset = "0xF8C58C", VA = "0xF8C58C")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xF8C5C4", Offset = "0xF8C5C4", VA = "0xF8C5C4")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xF8C5FC", Offset = "0xF8C5FC", VA = "0xF8C5FC")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xF8C634", Offset = "0xF8C634", VA = "0xF8C634")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xF8C66C", Offset = "0xF8C66C", VA = "0xF8C66C")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xF8C6A4", Offset = "0xF8C6A4", VA = "0xF8C6A4")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xF8C6DC", Offset = "0xF8C6DC", VA = "0xF8C6DC")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xF8C838", Offset = "0xF8C838", VA = "0xF8C838")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xF8C8A8", Offset = "0xF8C8A8", VA = "0xF8C8A8")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xF8C8B0", Offset = "0xF8C8B0", VA = "0xF8C8B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xF8C8B4", Offset = "0xF8C8B4", VA = "0xF8C8B4")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xF8C86C", Offset = "0xF8C86C", VA = "0xF8C86C")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xF8C8F4", Offset = "0xF8C8F4", VA = "0xF8C8F4")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x2000189")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6D03C", Offset = "0xA6D03C")]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400085F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x170000DB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000816")]
				[Address(RVA = "0xF955D4", Offset = "0xF955D4", VA = "0xF955D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000818")]
				[Address(RVA = "0xF9563C", Offset = "0xF9563C", VA = "0xF9563C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000813")]
			[Address(RVA = "0xF952F8", Offset = "0xF952F8", VA = "0xF952F8")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000814")]
			[Address(RVA = "0xF953D4", Offset = "0xF953D4", VA = "0xF953D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000815")]
			[Address(RVA = "0xF953D8", Offset = "0xF953D8", VA = "0xF953D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0xF955DC", Offset = "0xF955DC", VA = "0xF955DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000533")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x4000534")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xF94EE8", Offset = "0xF94EE8", VA = "0xF94EE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xF94F8C", Offset = "0xF94F8C", VA = "0xF94F8C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xF95234", Offset = "0xF95234", VA = "0xF95234")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xF951B8", Offset = "0xF951B8", VA = "0xF951B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA712FC", Offset = "0xA712FC")]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xF95324", Offset = "0xF95324", VA = "0xF95324")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x200018A")]
		public enum SelectionState
		{
			[Token(Token = "0x4000866")]
			Off,
			[Token(Token = "0x4000867")]
			Selected,
			[Token(Token = "0x4000868")]
			Highlighted
		}

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x1700007E")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0xF9799C", Offset = "0xF9799C", VA = "0xF9799C")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x6000508")]
			[Address(RVA = "0xF979A4", Offset = "0xF979A4", VA = "0xF979A4")]
			set
			{
			}
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xF97B2C", Offset = "0xF97B2C", VA = "0xF97B2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xF97D28", Offset = "0xF97D28", VA = "0xF97D28")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xF97A2C", Offset = "0xF97A2C", VA = "0xF97A2C")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xF97E18", Offset = "0xF97E18", VA = "0xF97E18")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x200018B")]
		public enum SegmentType
		{
			[Token(Token = "0x400086A")]
			Straight,
			[Token(Token = "0x400086B")]
			LeftTurn,
			[Token(Token = "0x400086C")]
			RightTurn,
			[Token(Token = "0x400086D")]
			Switch
		}

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x4000549")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x400054A")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F348", Offset = "0xA6F348")]
		private float <StartDistance>k__BackingField;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x1700007F")]
		public float StartDistance
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0xF97E84", Offset = "0xF97E84", VA = "0xF97E84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71360", Offset = "0xA71360")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600050F")]
			[Address(RVA = "0xF97E8C", Offset = "0xF97E8C", VA = "0xF97E8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71370", Offset = "0xA71370")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public float GridSize
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0xF97E94", Offset = "0xF97E94", VA = "0xF97E94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000511")]
			[Address(RVA = "0xF97E9C", Offset = "0xF97E9C", VA = "0xF97E9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public int SubDivCount
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0xF97EA4", Offset = "0xF97EA4", VA = "0xF97EA4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000513")]
			[Address(RVA = "0xF97EAC", Offset = "0xF97EAC", VA = "0xF97EAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public SegmentType Type
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0xF97EB4", Offset = "0xF97EB4", VA = "0xF97EB4")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x17000083")]
		public Pose EndPose
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0xF97EBC", Offset = "0xF97EBC", VA = "0xF97EBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public float Radius
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0xF98350", Offset = "0xF98350", VA = "0xF98350")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000085")]
		public float SegmentLength
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0xF97F24", Offset = "0xF97F24", VA = "0xF97F24")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xF98360", Offset = "0xF98360", VA = "0xF98360")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xF98378", Offset = "0xF98378", VA = "0xF98378")]
		private void Awake()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xF97F64", Offset = "0xF97F64", VA = "0xF97F64")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xF9837C", Offset = "0xF9837C", VA = "0xF9837C")]
		private void Update()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xF98380", Offset = "0xF98380", VA = "0xF98380")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xF983EC", Offset = "0xF983EC", VA = "0xF983EC")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xF98F74", Offset = "0xF98F74", VA = "0xF98F74")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xF992A0", Offset = "0xF992A0", VA = "0xF992A0")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x200018C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6D04C", Offset = "0xA6D04C")]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400086F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x170000DD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600081C")]
				[Address(RVA = "0xF9AF1C", Offset = "0xF9AF1C", VA = "0xF9AF1C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600081E")]
				[Address(RVA = "0xF9AF84", Offset = "0xF9AF84", VA = "0xF9AF84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0xF9AC84", Offset = "0xF9AC84", VA = "0xF9AC84")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0xF9AD60", Offset = "0xF9AD60", VA = "0xF9AD60", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0xF9AD64", Offset = "0xF9AD64", VA = "0xF9AD64", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0xF9AF24", Offset = "0xF9AF24", VA = "0xF9AF24", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000550")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x4000551")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xF9A368", Offset = "0xF9A368", VA = "0xF9A368")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xF9A428", Offset = "0xF9A428", VA = "0xF9A428")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xF9A4DC", Offset = "0xF9A4DC", VA = "0xF9A4DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xF9A610", Offset = "0xF9A610", VA = "0xF9A610")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xF9A788", Offset = "0xF9A788", VA = "0xF9A788")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xF9A924", Offset = "0xF9A924", VA = "0xF9A924")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xF9ABB0", Offset = "0xF9ABB0", VA = "0xF9ABB0")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xF9AA38", Offset = "0xF9AA38", VA = "0xF9AA38")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xF9AA4C", Offset = "0xF9AA4C", VA = "0xF9AA4C")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xF9AC08", Offset = "0xF9AC08", VA = "0xF9AC08")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA71380", Offset = "0xA71380")]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xF9ACB0", Offset = "0xF9ACB0", VA = "0xF9ACB0")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x17000086")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0xF9AF8C", Offset = "0xF9AF8C", VA = "0xF9AF8C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xF9AF9C", Offset = "0xF9AF9C", VA = "0xF9AF9C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xF9AFA4", Offset = "0xF9AFA4", VA = "0xF9AFA4", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xF9B410", Offset = "0xF9B410", VA = "0xF9B410")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x4000564")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x4000565")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F448", Offset = "0xA6F448")]
		private float <Distance>k__BackingField;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x17000087")]
		public float Distance
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0xF9B528", Offset = "0xF9B528", VA = "0xF9B528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA713E4", Offset = "0xA713E4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000530")]
			[Address(RVA = "0xF9B530", Offset = "0xF9B530", VA = "0xF9B530")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA713F4", Offset = "0xA713F4")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public float Scale
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0xF9B538", Offset = "0xF9B538", VA = "0xF9B538")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000532")]
			[Address(RVA = "0xF9B540", Offset = "0xF9B540", VA = "0xF9B540")]
			set
			{
			}
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xF9AFA0", Offset = "0xF9AFA0", VA = "0xF9AFA0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xF9B548", Offset = "0xF9B548", VA = "0xF9B548")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xF9AFEC", Offset = "0xF9AFEC", VA = "0xF9AFEC")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xF9B2C4", Offset = "0xF9B2C4", VA = "0xF9B2C4")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x6000537")]
		public abstract void UpdatePosition();

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xF9B480", Offset = "0xF9B480", VA = "0xF9B480")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x200018D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6D05C", Offset = "0xA6D05C")]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x170000DF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000822")]
				[Address(RVA = "0xF9BF48", Offset = "0xF9BF48", VA = "0xF9BF48", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000824")]
				[Address(RVA = "0xF9BFB0", Offset = "0xF9BFB0", VA = "0xF9BFB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0xF9BB4C", Offset = "0xF9BB4C", VA = "0xF9BB4C")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0xF9BCE4", Offset = "0xF9BCE4", VA = "0xF9BCE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0xF9BCE8", Offset = "0xF9BCE8", VA = "0xF9BCE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000823")]
			[Address(RVA = "0xF9BF50", Offset = "0xF9BF50", VA = "0xF9BF50", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xF9B71C", Offset = "0xF9B71C", VA = "0xF9B71C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xF9B77C", Offset = "0xF9B77C", VA = "0xF9B77C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xF9B888", Offset = "0xF9B888", VA = "0xF9B888")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xF9B9E0", Offset = "0xF9B9E0", VA = "0xF9B9E0")]
		private void Update()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xF9B8E8", Offset = "0xF9B8E8", VA = "0xF9B8E8")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xF9BAC0", Offset = "0xF9BAC0", VA = "0xF9BAC0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA71404", Offset = "0xA71404")]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xF9BB78", Offset = "0xF9BB78", VA = "0xF9BB78")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xF9BC24", Offset = "0xF9BC24", VA = "0xF9BC24")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xF9BC84", Offset = "0xF9BC84", VA = "0xF9BC84")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x200018E")]
		private enum EngineSoundState
		{
			[Token(Token = "0x4000880")]
			Start,
			[Token(Token = "0x4000881")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x4000882")]
			Stop
		}

		[Token(Token = "0x200018F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6D06C", Offset = "0xA6D06C")]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x4000886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x170000E1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000828")]
				[Address(RVA = "0xF9CC38", Offset = "0xF9CC38", VA = "0xF9CC38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600082A")]
				[Address(RVA = "0xF9CCA0", Offset = "0xF9CCA0", VA = "0xF9CCA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000825")]
			[Address(RVA = "0xF9C2E8", Offset = "0xF9C2E8", VA = "0xF9C2E8")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x6000826")]
			[Address(RVA = "0xF9C9FC", Offset = "0xF9C9FC", VA = "0xF9C9FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000827")]
			[Address(RVA = "0xF9CA00", Offset = "0xF9CA00", VA = "0xF9CA00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000829")]
			[Address(RVA = "0xF9CC40", Offset = "0xF9CC40", VA = "0xF9CC40", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000578")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x4000579")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x400057A")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x400057B")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6F4A8", Offset = "0xA6F4A8")]
		protected float _initialSpeed;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xF9BFB8", Offset = "0xF9BFB8", VA = "0xF9BFB8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xF9C128", Offset = "0xF9C128", VA = "0xF9C128")]
		private void Update()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xF9C134", Offset = "0xF9C134", VA = "0xF9C134", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xF9C288", Offset = "0xF9C288", VA = "0xF9C288")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xF9C098", Offset = "0xF9C098", VA = "0xF9C098")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA71468", Offset = "0xA71468")]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xF9C314", Offset = "0xF9C314", VA = "0xF9C314")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xF9C224", Offset = "0xF9C224", VA = "0xF9C224")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xF9C548", Offset = "0xF9C548", VA = "0xF9C548")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xF9C6F4", Offset = "0xF9C6F4", VA = "0xF9C6F4")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xF9C604", Offset = "0xF9C604", VA = "0xF9C604")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xF9C7B0", Offset = "0xF9C7B0", VA = "0xF9C7B0")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xF9C838", Offset = "0xF9C838", VA = "0xF9C838")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xF9C8C4", Offset = "0xF9C8C4", VA = "0xF9C8C4")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xF9C980", Offset = "0xF9C980", VA = "0xF9C980")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xF9C990", Offset = "0xF9C990", VA = "0xF9C990")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x17000089")]
		public float TrackLength
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0xF9CCA8", Offset = "0xF9CCA8", VA = "0xF9CCA8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000553")]
			[Address(RVA = "0xF9CCB0", Offset = "0xF9CCB0", VA = "0xF9CCB0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xF9CCB8", Offset = "0xF9CCB8", VA = "0xF9CCB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xF9B5CC", Offset = "0xF9B5CC", VA = "0xF9B5CC")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xF9CCBC", Offset = "0xF9CCBC", VA = "0xF9CCBC")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xF9CE9C", Offset = "0xF9CE9C", VA = "0xF9CE9C")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xF9CFB8", Offset = "0xF9CFB8", VA = "0xF9CFB8")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class Pose
	{
		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xF95ABC", Offset = "0xF95ABC", VA = "0xF95ABC")]
		public Pose()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xF95B68", Offset = "0xF95B68", VA = "0xF95B68")]
		public Pose(Vector3 position, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x2000190")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6D07C", Offset = "0xA6D07C")]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400088D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x170000E3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600082E")]
				[Address(RVA = "0xF9D604", Offset = "0xF9D604", VA = "0xF9D604", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000830")]
				[Address(RVA = "0xF9D66C", Offset = "0xF9D66C", VA = "0xF9D66C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600082B")]
			[Address(RVA = "0xF9D278", Offset = "0xF9D278", VA = "0xF9D278")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x600082C")]
			[Address(RVA = "0xF9D400", Offset = "0xF9D400", VA = "0xF9D400", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600082D")]
			[Address(RVA = "0xF9D404", Offset = "0xF9D404", VA = "0xF9D404", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600082F")]
			[Address(RVA = "0xF9D60C", Offset = "0xF9D60C", VA = "0xF9D60C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000191")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6D08C", Offset = "0xA6D08C")]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x170000E5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000834")]
				[Address(RVA = "0xF9D74C", Offset = "0xF9D74C", VA = "0xF9D74C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000836")]
				[Address(RVA = "0xF9D7B4", Offset = "0xF9D7B4", VA = "0xF9D7B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000831")]
			[Address(RVA = "0xF9D360", Offset = "0xF9D360", VA = "0xF9D360")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000832")]
			[Address(RVA = "0xF9D674", Offset = "0xF9D674", VA = "0xF9D674", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000833")]
			[Address(RVA = "0xF9D678", Offset = "0xF9D678", VA = "0xF9D678", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000835")]
			[Address(RVA = "0xF9D754", Offset = "0xF9D754", VA = "0xF9D754", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400059E")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6F690", Offset = "0xA6F690")]
		private bool <IsMoving>k__BackingField;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x1700008A")]
		public bool IsMoving
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0xF9CFD4", Offset = "0xF9CFD4", VA = "0xF9CFD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA714CC", Offset = "0xA714CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600055C")]
			[Address(RVA = "0xF9CFDC", Offset = "0xF9CFDC", VA = "0xF9CFDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA714DC", Offset = "0xA714DC")]
			private set
			{
			}
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xF9CFE8", Offset = "0xF9CFE8", VA = "0xF9CFE8")]
		private void Start()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xF9D024", Offset = "0xF9D024", VA = "0xF9D024")]
		private void Update()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xF9D178", Offset = "0xF9D178", VA = "0xF9D178")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xF9D1EC", Offset = "0xF9D1EC", VA = "0xF9D1EC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA714EC", Offset = "0xA714EC")]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xF9D2A4", Offset = "0xF9D2A4", VA = "0xF9D2A4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA71550", Offset = "0xA71550")]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xF9D38C", Offset = "0xF9D38C", VA = "0xF9D38C")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xF9D3F8", Offset = "0xF9D3F8", VA = "0xF9D3F8")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xF9D7BC", Offset = "0xF9D7BC", VA = "0xF9D7BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xF9D834", Offset = "0xF9D834", VA = "0xF9D834")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xF9D8EC", Offset = "0xF9D8EC", VA = "0xF9D8EC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xF9D9EC", Offset = "0xF9D9EC", VA = "0xF9D9EC")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xF9DA6C", Offset = "0xF9DA6C", VA = "0xF9DA6C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xF9DB4C", Offset = "0xF9DB4C", VA = "0xF9DB4C")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public enum EUiDisplayType
	{
		[Token(Token = "0x40005AF")]
		EUDT_WorldGeoQuad,
		[Token(Token = "0x40005B0")]
		EUDT_OverlayQuad,
		[Token(Token = "0x40005B1")]
		EUDT_None,
		[Token(Token = "0x40005B2")]
		EUDT_MaxDislayTypes
	}
	[Token(Token = "0x2000104")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x2000192")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6D09C", Offset = "0xA6D09C")]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x170000E7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600083A")]
				[Address(RVA = "0xF94E78", Offset = "0xF94E78", VA = "0xF94E78", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600083C")]
				[Address(RVA = "0xF94EE0", Offset = "0xF94EE0", VA = "0xF94EE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000837")]
			[Address(RVA = "0xF944CC", Offset = "0xF944CC", VA = "0xF944CC")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000838")]
			[Address(RVA = "0xF94C10", Offset = "0xF94C10", VA = "0xF94C10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000839")]
			[Address(RVA = "0xF94C14", Offset = "0xF94C14", VA = "0xF94C14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600083B")]
			[Address(RVA = "0xF94E80", Offset = "0xF94E80", VA = "0xF94E80", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x40005B4")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x40005B5")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x40005B6")]
		private const string noneID = "NoneID";

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6F6D0", Offset = "0xA6F6D0")]
		public GameObject mainCamera;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6F708", Offset = "0xA6F708")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xF93794", Offset = "0xF93794", VA = "0xF93794")]
		private void Start()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xF93FD0", Offset = "0xF93FD0", VA = "0xF93FD0")]
		private void Update()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xF94110", Offset = "0xF94110", VA = "0xF94110")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xF94244", Offset = "0xF94244", VA = "0xF94244")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xF94378", Offset = "0xF94378", VA = "0xF94378")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xF940E4", Offset = "0xF940E4", VA = "0xF940E4")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xF94450", Offset = "0xF94450", VA = "0xF94450")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA715B4", Offset = "0xA715B4")]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xF944F8", Offset = "0xF944F8", VA = "0xF944F8")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xF93B18", Offset = "0xF93B18", VA = "0xF93B18")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xF94620", Offset = "0xF94620", VA = "0xF94620")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xF9452C", Offset = "0xF9452C", VA = "0xF9452C")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xF949BC", Offset = "0xF949BC", VA = "0xF949BC")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xF94A98", Offset = "0xF94A98", VA = "0xF94A98")]
		public OVROverlaySample()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xF94B20", Offset = "0xF94B20", VA = "0xF94B20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71618", Offset = "0xA71618")]
		private void <Start>b__24_0(Toggle t)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xF94B70", Offset = "0xF94B70", VA = "0xF94B70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71628", Offset = "0xA71628")]
		private void <Start>b__24_1(Toggle t)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xF94BC0", Offset = "0xF94BC0", VA = "0xF94BC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA71638", Offset = "0xA71638")]
		private void <Start>b__24_2(Toggle t)
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x2000105")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA6CD34", Offset = "0xA6CD34")]
	public class Hand : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000193")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6D0AC", Offset = "0xA6D0AC")]
		private sealed class <>c
		{
			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Collider, bool> <>9__28_0;

			[Token(Token = "0x600083E")]
			[Address(RVA = "0xF82190", Offset = "0xF82190", VA = "0xF82190")]
			public <>c()
			{
			}

			[Token(Token = "0x600083F")]
			[Address(RVA = "0xF82198", Offset = "0xF82198", VA = "0xF82198")]
			internal bool <Start>b__28_0(Collider childCollider)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40005CB")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x40005CC")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x40005CD")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x40005CE")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x40005CF")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x40005D0")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x40005D1")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x40005D2")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x40005D3")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x40005D4")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x40005D5")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xF813A8", Offset = "0xF813A8", VA = "0xF813A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xF81408", Offset = "0xF81408", VA = "0xF81408")]
		private void Start()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xF81830", Offset = "0xF81830", VA = "0xF81830")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xF818FC", Offset = "0xF818FC", VA = "0xF818FC")]
		private void Update()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xF81A08", Offset = "0xF81A08", VA = "0xF81A08")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xF81D40", Offset = "0xF81D40", VA = "0xF81D40")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xF81EA8", Offset = "0xF81EA8", VA = "0xF81EA8")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xF81FF4", Offset = "0xF81FF4", VA = "0xF81FF4")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xF81AA4", Offset = "0xF81AA4", VA = "0xF81AA4")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xF81B44", Offset = "0xF81B44", VA = "0xF81B44")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xF81684", Offset = "0xF81684", VA = "0xF81684")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xF82110", Offset = "0xF82110", VA = "0xF82110")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public enum HandPoseId
	{
		[Token(Token = "0x40005E8")]
		Default,
		[Token(Token = "0x40005E9")]
		Generic,
		[Token(Token = "0x40005EA")]
		PingPongBall,
		[Token(Token = "0x40005EB")]
		Controller
	}
	[Token(Token = "0x2000107")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x1700008B")]
		public bool AllowPointing
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0xF821C4", Offset = "0xF821C4", VA = "0xF821C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008C")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0xF821CC", Offset = "0xF821CC", VA = "0xF821CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008D")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0xF821D4", Offset = "0xF821D4", VA = "0xF821D4")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xF821DC", Offset = "0xF821DC", VA = "0xF821DC")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xF821E4", Offset = "0xF821E4", VA = "0xF821E4")]
		private void Update()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xF82458", Offset = "0xF82458", VA = "0xF82458")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xF824B4", Offset = "0xF824B4", VA = "0xF824B4")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xF824F8", Offset = "0xF824F8", VA = "0xF824F8")]
		public TouchController()
		{
		}
	}
}
namespace Oculus.Spatializer.Propagation
{
	[Token(Token = "0x2000109")]
	public enum FaceType : uint
	{
		[Token(Token = "0x40005F3")]
		TRIANGLES,
		[Token(Token = "0x40005F4")]
		QUADS
	}
	[Token(Token = "0x200010A")]
	public enum MaterialProperty : uint
	{
		[Token(Token = "0x40005F6")]
		ABSORPTION,
		[Token(Token = "0x40005F7")]
		TRANSMISSION,
		[Token(Token = "0x40005F8")]
		SCATTERING
	}
	[Token(Token = "0x200010B")]
	public struct MeshGroup
	{
		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UIntPtr indexOffset;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public UIntPtr faceCount;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FaceType faceType;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public IntPtr material;
	}
}
namespace Oculus.Avatar
{
	[Token(Token = "0x200010C")]
	public static class AvatarLogger
	{
		[Token(Token = "0x40005FD")]
		public const string LogAvatar = "[Avatars] - ";

		[Token(Token = "0x40005FE")]
		public const string Tab = "    ";

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xF82B98", Offset = "0xF82B98", VA = "0xF82B98")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA71648", Offset = "0xA71648")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA71648", Offset = "0xA71648")]
		public static void Log(string logMsg)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xF82C20", Offset = "0xF82C20", VA = "0xF82C20")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA716A8", Offset = "0xA716A8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA716A8", Offset = "0xA716A8")]
		public static void Log(string logMsg, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xF82CB8", Offset = "0xF82CB8", VA = "0xF82CB8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA71708", Offset = "0xA71708")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA71708", Offset = "0xA71708")]
		public static void LogWarning(string logMsg)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xF82D40", Offset = "0xF82D40", VA = "0xF82D40")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA71768", Offset = "0xA71768")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA71768", Offset = "0xA71768")]
		public static void LogError(string logMsg)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xF82DC8", Offset = "0xF82DC8", VA = "0xF82DC8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA717C8", Offset = "0xA717C8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA717C8", Offset = "0xA717C8")]
		public static void LogError(string logMsg, UnityEngine.Object context)
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class CAPI
	{
		[Token(Token = "0x2000194")]
		public delegate void LoggingDelegate(IntPtr str);

		[Token(Token = "0x2000195")]
		public enum Result
		{
			[Token(Token = "0x400089E")]
			Success = 0,
			[Token(Token = "0x400089F")]
			Failure = -1000,
			[Token(Token = "0x40008A0")]
			Failure_InvalidParameter = -1001,
			[Token(Token = "0x40008A1")]
			Failure_NotInitialized = -1002,
			[Token(Token = "0x40008A2")]
			Failure_InvalidOperation = -1003,
			[Token(Token = "0x40008A3")]
			Failure_Unsupported = -1004,
			[Token(Token = "0x40008A4")]
			Failure_NotYetImplemented = -1005,
			[Token(Token = "0x40008A5")]
			Failure_OperationFailed = -1006,
			[Token(Token = "0x40008A6")]
			Failure_InsufficientSize = -1007
		}

		[Token(Token = "0x2000196")]
		private static class OVRP_1_30_0
		{
			[Token(Token = "0x40008A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Version version;

			[PreserveSig]
			[Token(Token = "0x6000844")]
			[Address(RVA = "0xF8A638", Offset = "0xF8A638", VA = "0xF8A638")]
			public static extern Result ovrp_SendEvent2(string name, string param, string source);
		}

		[Token(Token = "0x40005FF")]
		private const string LibFile = "ovravatarloader";

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IntPtr nativeVisemeData;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IntPtr nativeGazeTargetsData;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IntPtr nativeAvatarLightsData;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IntPtr DebugLineCountData;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float[] scratchBufferFloat;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GameObject debugLineGo;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string SDKRuntimePrefix;

		[Token(Token = "0x4000607")]
		private const string ovrPluginDLL = "OVRPlugin";

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Version ovrPluginVersion;

		[PreserveSig]
		[Token(Token = "0x6000593")]
		[Address(RVA = "0xF82EC8", Offset = "0xF82EC8", VA = "0xF82EC8")]
		public static extern void ovrAvatar_InitializeAndroidUnity(string appID);

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xF82F58", Offset = "0xF82F58", VA = "0xF82F58")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xF83120", Offset = "0xF83120", VA = "0xF83120")]
		public static void Shutdown()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000596")]
		[Address(RVA = "0xF83204", Offset = "0xF83204", VA = "0xF83204")]
		public static extern void ovrAvatar_Shutdown();

		[PreserveSig]
		[Token(Token = "0x6000597")]
		[Address(RVA = "0xF83274", Offset = "0xF83274", VA = "0xF83274")]
		public static extern IntPtr ovrAvatarMessage_Pop();

		[PreserveSig]
		[Token(Token = "0x6000598")]
		[Address(RVA = "0xF832E8", Offset = "0xF832E8", VA = "0xF832E8")]
		public static extern ovrAvatarMessageType ovrAvatarMessage_GetType(IntPtr msg);

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xF83368", Offset = "0xF83368", VA = "0xF83368")]
		public static ovrAvatarMessage_AvatarSpecification ovrAvatarMessage_GetAvatarSpecification(IntPtr msg)
		{
			return default(ovrAvatarMessage_AvatarSpecification);
		}

		[PreserveSig]
		[Token(Token = "0x600059A")]
		[Address(RVA = "0xF83480", Offset = "0xF83480", VA = "0xF83480")]
		private static extern IntPtr ovrAvatarMessage_GetAvatarSpecification_Native(IntPtr msg);

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xF83500", Offset = "0xF83500", VA = "0xF83500")]
		public static ovrAvatarMessage_AssetLoaded ovrAvatarMessage_GetAssetLoaded(IntPtr msg)
		{
			return default(ovrAvatarMessage_AssetLoaded);
		}

		[PreserveSig]
		[Token(Token = "0x600059C")]
		[Address(RVA = "0xF83618", Offset = "0xF83618", VA = "0xF83618")]
		private static extern IntPtr ovrAvatarMessage_GetAssetLoaded_Native(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x600059D")]
		[Address(RVA = "0xF83698", Offset = "0xF83698", VA = "0xF83698")]
		public static extern void ovrAvatarMessage_Free(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x600059E")]
		[Address(RVA = "0xF83718", Offset = "0xF83718", VA = "0xF83718")]
		public static extern IntPtr ovrAvatarSpecificationRequest_Create(ulong userID);

		[PreserveSig]
		[Token(Token = "0x600059F")]
		[Address(RVA = "0xF83798", Offset = "0xF83798", VA = "0xF83798")]
		public static extern void ovrAvatarSpecificationRequest_Destroy(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xF83818", Offset = "0xF83818", VA = "0xF83818")]
		public static extern void ovrAvatarSpecificationRequest_SetCombineMeshes(IntPtr specificationRequest, bool useCombinedMesh);

		[PreserveSig]
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xF838A8", Offset = "0xF838A8", VA = "0xF838A8")]
		public static extern void ovrAvatarSpecificationRequest_SetLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xF83938", Offset = "0xF83938", VA = "0xF83938")]
		public static extern void ovrAvatarSpecificationRequest_SetLevelOfDetail(IntPtr specificationRequest, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xF839C8", Offset = "0xF839C8", VA = "0xF839C8")]
		public static extern void ovrAvatar_RequestAvatarSpecification(ulong userID);

		[PreserveSig]
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xF83A48", Offset = "0xF83A48", VA = "0xF83A48")]
		public static extern void ovrAvatar_RequestAvatarSpecificationFromSpecRequest(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xF83AC8", Offset = "0xF83AC8", VA = "0xF83AC8")]
		public static extern void ovrAvatarSpecificationRequest_SetFallbackLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xF83B58", Offset = "0xF83B58", VA = "0xF83B58")]
		public static extern void ovrAvatarSpecificationRequest_SetExpressiveFlag(IntPtr specificationRequest, bool enable);

		[PreserveSig]
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xF83BE8", Offset = "0xF83BE8", VA = "0xF83BE8")]
		public static extern IntPtr ovrAvatar_Create(IntPtr avatarSpecification, ovrAvatarCapabilities capabilities);

		[PreserveSig]
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xF83C78", Offset = "0xF83C78", VA = "0xF83C78")]
		public static extern void ovrAvatar_Destroy(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xF83CF8", Offset = "0xF83CF8", VA = "0xF83CF8")]
		public static extern void ovrAvatarPose_UpdateBody(IntPtr avatar, ovrAvatarTransform headPose);

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xF83D98", Offset = "0xF83D98", VA = "0xF83D98")]
		public static void ovrAvatarPose_UpdateVoiceVisualization(IntPtr avatar, float[] pcmData)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xF83E18", Offset = "0xF83E18", VA = "0xF83E18")]
		private static extern void ovrAvatarPose_UpdateVoiceVisualization_Native(IntPtr avatar, uint pcmDataSize, [In] float[] pcmData);

		[PreserveSig]
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xF83EB8", Offset = "0xF83EB8", VA = "0xF83EB8")]
		public static extern void ovrAvatarPose_UpdateHands(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight);

		[PreserveSig]
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xF83F78", Offset = "0xF83F78", VA = "0xF83F78")]
		public static extern void ovrAvatarPose_UpdateHandsWithType(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight, ovrAvatarControllerType type);

		[PreserveSig]
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xF84048", Offset = "0xF84048", VA = "0xF84048")]
		public static extern void ovrAvatarPose_Finalize(IntPtr avatar, float elapsedSeconds);

		[PreserveSig]
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xF840D8", Offset = "0xF840D8", VA = "0xF840D8")]
		public static extern void ovrAvatar_SetLeftControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xF84168", Offset = "0xF84168", VA = "0xF84168")]
		public static extern void ovrAvatar_SetRightControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xF841F8", Offset = "0xF841F8", VA = "0xF841F8")]
		public static extern void ovrAvatar_SetLeftHandVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xF84288", Offset = "0xF84288", VA = "0xF84288")]
		public static extern void ovrAvatar_SetRightHandVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xF84318", Offset = "0xF84318", VA = "0xF84318")]
		public static extern uint ovrAvatarComponent_Count(IntPtr avatar);

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xF84398", Offset = "0xF84398", VA = "0xF84398")]
		public static void ovrAvatarComponent_Get(IntPtr avatar, uint index, bool includeName, ref ovrAvatarComponent component)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xF844B8", Offset = "0xF844B8", VA = "0xF844B8")]
		public static void ovrAvatarComponent_Get(IntPtr componentPtr, bool includeName, ref ovrAvatarComponent component)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xF84428", Offset = "0xF84428", VA = "0xF84428")]
		public static extern IntPtr ovrAvatarComponent_Get_Native(IntPtr avatar, uint index);

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xF846B8", Offset = "0xF846B8", VA = "0xF846B8")]
		public static bool ovrAvatarPose_GetBaseComponent(IntPtr avatar, ref ovrAvatarBaseComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xF847F0", Offset = "0xF847F0", VA = "0xF847F0")]
		private static extern IntPtr ovrAvatarPose_GetBaseComponent_Native(IntPtr avatar);

		[Token(Token = "0x60005B9")]
		public static IntPtr MarshalRenderComponent<T>(IntPtr ptr) where T : struct
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xF84870", Offset = "0xF84870", VA = "0xF84870")]
		public static bool ovrAvatarPose_GetBodyComponent(IntPtr avatar, ref ovrAvatarBodyComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xF84AE0", Offset = "0xF84AE0", VA = "0xF84AE0")]
		private static extern IntPtr ovrAvatarPose_GetBodyComponent_Native(IntPtr avatar);

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xF84B60", Offset = "0xF84B60", VA = "0xF84B60")]
		public static bool ovrAvatarPose_GetLeftControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xF84C98", Offset = "0xF84C98", VA = "0xF84C98")]
		private static extern IntPtr ovrAvatarPose_GetLeftControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xF84D18", Offset = "0xF84D18", VA = "0xF84D18")]
		public static bool ovrAvatarPose_GetRightControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xF84E50", Offset = "0xF84E50", VA = "0xF84E50")]
		private static extern IntPtr ovrAvatarPose_GetRightControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xF84ED0", Offset = "0xF84ED0", VA = "0xF84ED0")]
		public static bool ovrAvatarPose_GetLeftHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xF85008", Offset = "0xF85008", VA = "0xF85008")]
		private static extern IntPtr ovrAvatarPose_GetLeftHandComponent_Native(IntPtr avatar);

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xF85088", Offset = "0xF85088", VA = "0xF85088")]
		public static bool ovrAvatarPose_GetRightHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xF851C0", Offset = "0xF851C0", VA = "0xF851C0")]
		private static extern IntPtr ovrAvatarPose_GetRightHandComponent_Native(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xF85240", Offset = "0xF85240", VA = "0xF85240")]
		public static extern void ovrAvatarAsset_BeginLoading(ulong assetID);

		[PreserveSig]
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xF852C0", Offset = "0xF852C0", VA = "0xF852C0")]
		public static extern bool ovrAvatarAsset_BeginLoadingLOD(ulong assetId, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xF85358", Offset = "0xF85358", VA = "0xF85358")]
		public static extern ovrAvatarAssetType ovrAvatarAsset_GetType(IntPtr assetHandle);

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xF853D8", Offset = "0xF853D8", VA = "0xF853D8")]
		public static ovrAvatarMeshAssetData ovrAvatarAsset_GetMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetData);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xF85584", Offset = "0xF85584", VA = "0xF85584")]
		public static ovrAvatarMeshAssetDataV2 ovrAvatarAsset_GetCombinedMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetDataV2);
		}

		[PreserveSig]
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xF856B0", Offset = "0xF856B0", VA = "0xF856B0")]
		private static extern IntPtr ovrAvatarAsset_GetCombinedMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xF85504", Offset = "0xF85504", VA = "0xF85504")]
		private static extern IntPtr ovrAvatarAsset_GetMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xF85730", Offset = "0xF85730", VA = "0xF85730")]
		public static extern uint ovrAvatarAsset_GetMeshBlendShapeCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xF857B0", Offset = "0xF857B0", VA = "0xF857B0")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeName(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xF85840", Offset = "0xF85840", VA = "0xF85840")]
		public static extern uint ovrAvatarAsset_GetSubmeshCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xF858C0", Offset = "0xF858C0", VA = "0xF858C0")]
		public static extern uint ovrAvatarAsset_GetSubmeshLastIndex(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xF85950", Offset = "0xF85950", VA = "0xF85950")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeVertices(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xF859D0", Offset = "0xF859D0", VA = "0xF859D0")]
		public static extern IntPtr ovrAvatarAsset_GetAvatar(IntPtr assetHandle);

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xF85A50", Offset = "0xF85A50", VA = "0xF85A50")]
		public static ulong[] ovrAvatarAsset_GetCombinedMeshIDs(IntPtr assetHandle)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xF85C8C", Offset = "0xF85C8C", VA = "0xF85C8C")]
		public static extern IntPtr ovrAvatarAsset_GetCombinedMeshIDs_Native(IntPtr assetHandle, IntPtr count);

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xF85D1C", Offset = "0xF85D1C", VA = "0xF85D1C")]
		public static void ovrAvatar_GetCombinedMeshAlphaData(IntPtr avatar, ref ulong textureID, ref Vector4 offset)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xF85F08", Offset = "0xF85F08", VA = "0xF85F08")]
		public static extern IntPtr ovrAvatar_GetCombinedMeshAlphaData_Native(IntPtr avatar, IntPtr textureIDPtr, IntPtr offsetPtr);

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xF85FA0", Offset = "0xF85FA0", VA = "0xF85FA0")]
		public static ovrAvatarTextureAssetData ovrAvatarAsset_GetTextureData(IntPtr assetPtr)
		{
			return default(ovrAvatarTextureAssetData);
		}

		[PreserveSig]
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xF860C4", Offset = "0xF860C4", VA = "0xF860C4")]
		private static extern IntPtr ovrAvatarAsset_GetTextureData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xF86144", Offset = "0xF86144", VA = "0xF86144")]
		private static extern IntPtr ovrAvatarAsset_GetMaterialData_Native(IntPtr assetPtr);

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xF861C4", Offset = "0xF861C4", VA = "0xF861C4")]
		public static ovrAvatarMaterialState ovrAvatarAsset_GetMaterialState(IntPtr assetPtr)
		{
			return default(ovrAvatarMaterialState);
		}

		[PreserveSig]
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xF862EC", Offset = "0xF862EC", VA = "0xF862EC")]
		public static extern ovrAvatarRenderPartType ovrAvatarRenderPart_GetType(IntPtr renderPart);

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xF8636C", Offset = "0xF8636C", VA = "0xF8636C")]
		public static ovrAvatarRenderPart_SkinnedMeshRender ovrAvatarRenderPart_GetSkinnedMeshRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRender);
		}

		[PreserveSig]
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xF86494", Offset = "0xF86494", VA = "0xF86494")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xF86514", Offset = "0xF86514", VA = "0xF86514")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xF865A4", Offset = "0xF865A4", VA = "0xF865A4")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xF86634", Offset = "0xF86634", VA = "0xF86634")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xF866C4", Offset = "0xF866C4", VA = "0xF866C4")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRender_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xF86744", Offset = "0xF86744", VA = "0xF86744")]
		public static extern bool ovrAvatarSkinnedMeshRender_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xF867CC", Offset = "0xF867CC", VA = "0xF867CC")]
		public static extern bool ovrAvatarSkinnedMeshRenderPBSV2_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xF86854", Offset = "0xF86854", VA = "0xF86854")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBS_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xF868D4", Offset = "0xF868D4", VA = "0xF868D4")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBSV2_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xF86954", Offset = "0xF86954", VA = "0xF86954")]
		public static extern ovrAvatarMaterialState ovrAvatarSkinnedMeshRender_GetMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xF86A08", Offset = "0xF86A08", VA = "0xF86A08")]
		public static extern ovrAvatarPBSMaterialState ovrAvatarSkinnedMeshRenderPBSV2_GetPBSMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xF86A98", Offset = "0xF86A98", VA = "0xF86A98")]
		public static extern ovrAvatarExpressiveParameters ovrAvatar_GetExpressiveParameters(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xF86B28", Offset = "0xF86B28", VA = "0xF86B28")]
		public static extern ulong ovrAvatarSkinnedMeshRender_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xF86BA8", Offset = "0xF86BA8", VA = "0xF86BA8")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xF86C28", Offset = "0xF86C28", VA = "0xF86C28")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBSV2_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xF86CA8", Offset = "0xF86CA8", VA = "0xF86CA8")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xF86D40", Offset = "0xF86D40", VA = "0xF86D40")]
		public static extern void ovrAvatar_SetActionUnitOnsetSpeed(IntPtr avatar, float onsetSpeed);

		[PreserveSig]
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xF86DD0", Offset = "0xF86DD0", VA = "0xF86DD0")]
		public static extern void ovrAvatar_SetActionUnitFalloffSpeed(IntPtr avatar, float falloffSpeed);

		[PreserveSig]
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xF86E60", Offset = "0xF86E60", VA = "0xF86E60")]
		public static extern void ovrAvatar_SetVisemeMultiplier(IntPtr avatar, float visemeMultiplier);

		[PreserveSig]
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xF86EF0", Offset = "0xF86EF0", VA = "0xF86EF0")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xF86F88", Offset = "0xF86F88", VA = "0xF86F88")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xF87020", Offset = "0xF87020", VA = "0xF87020")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetAlbedoTextureAssetID(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xF870A0", Offset = "0xF870A0", VA = "0xF870A0")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetSurfaceTextureAssetID(IntPtr renderPart);

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xF87120", Offset = "0xF87120", VA = "0xF87120")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS ovrAvatarRenderPart_GetSkinnedMeshRenderPBS(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS);
		}

		[PreserveSig]
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xF87248", Offset = "0xF87248", VA = "0xF87248")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBS_Native(IntPtr renderPart);

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xF872C8", Offset = "0xF872C8", VA = "0xF872C8")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2);
		}

		[PreserveSig]
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xF873F0", Offset = "0xF873F0", VA = "0xF873F0")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2_Native(IntPtr renderPart);

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xF87470", Offset = "0xF87470", VA = "0xF87470")]
		public static void ovrAvatarSkinnedMeshRender_GetBlendShapeParams(IntPtr renderPart, ref ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xF87598", Offset = "0xF87598", VA = "0xF87598")]
		private static extern IntPtr ovrAvatarSkinnedMeshRender_GetBlendShapeParams_Native(IntPtr renderPart);

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xF87618", Offset = "0xF87618", VA = "0xF87618")]
		public static ovrAvatarRenderPart_ProjectorRender ovrAvatarRenderPart_GetProjectorRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_ProjectorRender);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xF877C0", Offset = "0xF877C0", VA = "0xF877C0")]
		public static ovrAvatarPBSMaterialState[] ovrAvatar_GetBodyPBSMaterialStates(IntPtr renderPart)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xF87A5C", Offset = "0xF87A5C", VA = "0xF87A5C")]
		private static extern IntPtr ovrAvatar_GetBodyPBSMaterialStates_Native(IntPtr avatar, IntPtr count);

		[PreserveSig]
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xF87740", Offset = "0xF87740", VA = "0xF87740")]
		private static extern IntPtr ovrAvatarRenderPart_GetProjectorRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xF87AEC", Offset = "0xF87AEC", VA = "0xF87AEC")]
		public static extern uint ovrAvatar_GetReferencedAssetCount(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xF87B6C", Offset = "0xF87B6C", VA = "0xF87B6C")]
		public static extern ulong ovrAvatar_GetReferencedAsset(IntPtr avatar, uint index);

		[PreserveSig]
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xF87BFC", Offset = "0xF87BFC", VA = "0xF87BFC")]
		public static extern void ovrAvatar_SetLeftHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xF87C8C", Offset = "0xF87C8C", VA = "0xF87C8C")]
		public static extern void ovrAvatar_SetRightHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x6000600")]
		[Address(RVA = "0xF87D1C", Offset = "0xF87D1C", VA = "0xF87D1C")]
		public static extern void ovrAvatar_SetLeftHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x6000601")]
		[Address(RVA = "0xF87DBC", Offset = "0xF87DBC", VA = "0xF87DBC")]
		public static extern void ovrAvatar_SetRightHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x6000602")]
		[Address(RVA = "0xF87E5C", Offset = "0xF87E5C", VA = "0xF87E5C")]
		public static extern void ovrAvatar_UpdatePoseFromPacket(IntPtr avatar, IntPtr packet, float secondsFromStart);

		[PreserveSig]
		[Token(Token = "0x6000603")]
		[Address(RVA = "0xF87EFC", Offset = "0xF87EFC", VA = "0xF87EFC")]
		public static extern void ovrAvatarPacket_BeginRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000604")]
		[Address(RVA = "0xF87F7C", Offset = "0xF87F7C", VA = "0xF87F7C")]
		public static extern IntPtr ovrAvatarPacket_EndRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000605")]
		[Address(RVA = "0xF87FFC", Offset = "0xF87FFC", VA = "0xF87FFC")]
		public static extern uint ovrAvatarPacket_GetSize(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x6000606")]
		[Address(RVA = "0xF8807C", Offset = "0xF8807C", VA = "0xF8807C")]
		public static extern float ovrAvatarPacket_GetDurationSeconds(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x6000607")]
		[Address(RVA = "0xF880FC", Offset = "0xF880FC", VA = "0xF880FC")]
		public static extern void ovrAvatarPacket_Free(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x6000608")]
		[Address(RVA = "0xF8817C", Offset = "0xF8817C", VA = "0xF8817C")]
		public static extern bool ovrAvatarPacket_Write(IntPtr packet, uint bufferSize, [Out] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x6000609")]
		[Address(RVA = "0xF882A4", Offset = "0xF882A4", VA = "0xF882A4")]
		public static extern IntPtr ovrAvatarPacket_Read(uint bufferSize, [In] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x600060A")]
		[Address(RVA = "0xF8833C", Offset = "0xF8833C", VA = "0xF8833C")]
		private static extern void ovrAvatar_SetInternalForceASTCTextures(bool value);

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xF883BC", Offset = "0xF883BC", VA = "0xF883BC")]
		public static void ovrAvatar_SetForceASTCTextures(bool value)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xF88420", Offset = "0xF88420", VA = "0xF88420")]
		public static void ovrAvatar_OverrideExpressiveLogic(IntPtr avatar, ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600060D")]
		[Address(RVA = "0xF8853C", Offset = "0xF8853C", VA = "0xF8853C")]
		private static extern void ovrAvatar_OverrideExpressiveLogic_Native(IntPtr avatar, IntPtr state);

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xF885CC", Offset = "0xF885CC", VA = "0xF885CC")]
		public static void ovrAvatar_SetVisemes(IntPtr avatar, ovrAvatarVisemes visemes)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600060F")]
		[Address(RVA = "0xF88710", Offset = "0xF88710", VA = "0xF88710")]
		private static extern void ovrAvatar_SetVisemes_Native(IntPtr avatar, IntPtr visemes);

		[PreserveSig]
		[Token(Token = "0x6000610")]
		[Address(RVA = "0xF887A0", Offset = "0xF887A0", VA = "0xF887A0")]
		public static extern void ovrAvatar_UpdateWorldTransform(IntPtr avatar, ovrAvatarTransform transform);

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xF88840", Offset = "0xF88840", VA = "0xF88840")]
		public static void ovrAvatar_UpdateGazeTargets(ovrAvatarGazeTargets targets)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000612")]
		[Address(RVA = "0xF88BD8", Offset = "0xF88BD8", VA = "0xF88BD8")]
		private static extern void ovrAvatar_UpdateGazeTargets_Native(IntPtr targets);

		[PreserveSig]
		[Token(Token = "0x6000613")]
		[Address(RVA = "0xF88C58", Offset = "0xF88C58", VA = "0xF88C58")]
		public static extern void ovrAvatar_RemoveGazeTargets(uint targetCount, uint[] ids);

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xF88CF0", Offset = "0xF88CF0", VA = "0xF88CF0")]
		public static void ovrAvatar_UpdateLights(ovrAvatarLights lights)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000615")]
		[Address(RVA = "0xF894B8", Offset = "0xF894B8", VA = "0xF894B8")]
		private static extern void ovrAvatar_UpdateLights_Native(IntPtr lights);

		[PreserveSig]
		[Token(Token = "0x6000616")]
		[Address(RVA = "0xF89538", Offset = "0xF89538", VA = "0xF89538")]
		public static extern void ovrAvatar_RemoveLights(uint lightCount, uint[] ids);

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xF82E60", Offset = "0xF82E60", VA = "0xF82E60")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xA71828", Offset = "0xA71828")]
		public static void LoggingCallback(IntPtr str)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000618")]
		[Address(RVA = "0xF895D0", Offset = "0xF895D0", VA = "0xF895D0")]
		public static extern void ovrAvatar_RegisterLoggingCallback(LoggingDelegate callback);

		[PreserveSig]
		[Token(Token = "0x6000619")]
		[Address(RVA = "0xF89654", Offset = "0xF89654", VA = "0xF89654")]
		public static extern void ovrAvatar_SetLoggingLevel(ovrAvatarLogLevel level);

		[PreserveSig]
		[Token(Token = "0x600061A")]
		[Address(RVA = "0xF896D4", Offset = "0xF896D4", VA = "0xF896D4")]
		public static extern IntPtr ovrAvatar_GetDebugTransforms_Native(IntPtr count);

		[PreserveSig]
		[Token(Token = "0x600061B")]
		[Address(RVA = "0xF89754", Offset = "0xF89754", VA = "0xF89754")]
		public static extern IntPtr ovrAvatar_GetDebugLines_Native(IntPtr count);

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xF897D4", Offset = "0xF897D4", VA = "0xF897D4")]
		public static void ovrAvatar_DrawDebugLines()
		{
		}

		[PreserveSig]
		[Token(Token = "0x600061D")]
		[Address(RVA = "0xF8A1B4", Offset = "0xF8A1B4", VA = "0xF8A1B4")]
		public static extern void ovrAvatar_SetDebugDrawContext(uint context);

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xF8A234", Offset = "0xF8A234", VA = "0xF8A234")]
		public static bool SendEvent(string name, string param = "", string source = "")
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x600061F")]
		[Address(RVA = "0xF8A714", Offset = "0xF8A714", VA = "0xF8A714")]
		private static extern IntPtr _ovrp_GetVersion();

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xF8A5A8", Offset = "0xF8A5A8", VA = "0xF8A5A8")]
		public static string ovrp_GetVersion()
		{
			return null;
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xF8A788", Offset = "0xF8A788", VA = "0xF8A788")]
		public CAPI()
		{
		}
	}
}
namespace OVR
{
	[Token(Token = "0x200010E")]
	public class TestScript : MonoBehaviour
	{
		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "InspectorNoteAttribute", RVA = "0xA6F7C0", Offset = "0xA6F7C0")]
		public SoundFXRef testSound1;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoundFXRef testSound2;

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x1586D4C", Offset = "0x1586D4C", VA = "0x1586D4C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x1586D50", Offset = "0x1586D50", VA = "0x1586D50")]
		private void Update()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x1586E10", Offset = "0x1586E10", VA = "0x1586E10")]
		public TestScript()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class AmbienceEmitter : MonoBehaviour
	{
		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SoundFXRef[] ambientSounds;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool autoActivate;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6F80C", Offset = "0xA6F80C")]
		public bool autoRetrigger;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0xA6F844", Offset = "0xA6F844")]
		public Vector2 randomRetriggerDelaySecs;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6F868", Offset = "0xA6F868")]
		public Transform[] playPositions;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool activated;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int playingIdx;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float nextPlayTime;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float fadeTime;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int lastPosIdx;

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x157D90C", Offset = "0x157D90C", VA = "0x157D90C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x157DABC", Offset = "0x157DABC", VA = "0x157DABC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x157DC98", Offset = "0x157DC98", VA = "0x157DC98")]
		public void OnTriggerEnter(Collider col)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x157DB1C", Offset = "0x157DB1C", VA = "0x157DB1C")]
		public void Play()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x157DDD8", Offset = "0x157DDD8", VA = "0x157DDD8")]
		public void EnableEmitter(bool enable)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x157DF4C", Offset = "0x157DF4C", VA = "0x157DF4C")]
		public AmbienceEmitter()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public enum PreloadSounds
	{
		[Token(Token = "0x4000616")]
		Default,
		[Token(Token = "0x4000617")]
		Preload,
		[Token(Token = "0x4000618")]
		ManualPreload
	}
	[Token(Token = "0x2000111")]
	public enum Fade
	{
		[Token(Token = "0x400061A")]
		In,
		[Token(Token = "0x400061B")]
		Out
	}
	[Serializable]
	[Token(Token = "0x2000112")]
	public class SoundGroup
	{
		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SoundFX[] soundList;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioMixerGroup mixerGroup;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6F8A0", Offset = "0xA6F8A0")]
		public int maxPlayingSounds;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public PreloadSounds preloadAudio;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float volumeOverride;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public int playingSoundCount;

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1586BDC", Offset = "0x1586BDC", VA = "0x1586BDC")]
		public SoundGroup(string name)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x1586C90", Offset = "0x1586C90", VA = "0x1586C90")]
		public SoundGroup()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x158559C", Offset = "0x158559C", VA = "0x158559C")]
		public void IncrementPlayCount()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x15856DC", Offset = "0x15856DC", VA = "0x15856DC")]
		public void DecrementPlayCount()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x15861F8", Offset = "0x15861F8", VA = "0x15861F8")]
		public bool CanPlaySound()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000113")]
	public class AudioManager : MonoBehaviour
	{
		[Token(Token = "0x2000197")]
		public enum Fade
		{
			[Token(Token = "0x40008A9")]
			In,
			[Token(Token = "0x40008AA")]
			Out
		}

		[Token(Token = "0x2000198")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6D0BC", Offset = "0xA6D0BC")]
		private sealed class <>c__DisplayClass77_0
		{
			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SoundPriority priority;

			[Token(Token = "0x6000846")]
			[Address(RVA = "0x15823F8", Offset = "0x15823F8", VA = "0x15823F8")]
			public <>c__DisplayClass77_0()
			{
			}

			[Token(Token = "0x6000847")]
			[Address(RVA = "0x1585020", Offset = "0x1585020", VA = "0x1585020")]
			internal bool <FindFreeEmitter>b__0(SoundEmitter item)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000199")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6D0CC", Offset = "0xA6D0CC")]
		private sealed class <>c
		{
			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<SoundEmitter> <>9__77_1;

			[Token(Token = "0x6000849")]
			[Address(RVA = "0x1584F88", Offset = "0x1584F88", VA = "0x1584F88")]
			public <>c()
			{
			}

			[Token(Token = "0x600084A")]
			[Address(RVA = "0x1584F90", Offset = "0x1584F90", VA = "0x1584F90")]
			internal bool <FindFreeEmitter>b__77_1(SoundEmitter item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6F8CC", Offset = "0xA6F8CC")]
		public bool makePersistent;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6F904", Offset = "0xA6F904")]
		public bool enableSpatializedAudio;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6F93C", Offset = "0xA6F93C")]
		public bool enableSpatializedFastOverride;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6F974", Offset = "0xA6F974")]
		public AudioMixer audioMixer;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6F9AC", Offset = "0xA6F9AC")]
		public AudioMixerGroup defaultMixerGroup;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6F9E4", Offset = "0xA6F9E4")]
		public AudioMixerGroup reservedMixerGroup;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FA1C", Offset = "0xA6FA1C")]
		public AudioMixerGroup voiceChatMixerGroup;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FA54", Offset = "0xA6FA54")]
		public bool verboseLogging;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FA8C", Offset = "0xA6FA8C")]
		public int maxSoundEmitters;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FAC4", Offset = "0xA6FAC4")]
		public float volumeSoundFX;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FAFC", Offset = "0xA6FAFC")]
		public float soundFxFadeSecs;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float audioMinFallOffDistance;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float audioMaxFallOffDistance;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public SoundGroup[] soundGroupings;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<string, SoundFX> soundFXCache;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AudioManager theAudioManager;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static FastList<string> names;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string[] defaultSound;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static SoundFX nullSound;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool hideWarnings;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float audioMaxFallOffDistanceSqr;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private SoundEmitter[] soundEmitters;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private FastList<SoundEmitter> playingEmitters;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private FastList<SoundEmitter> nextFreeEmitters;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private MixerSnapshot currentSnapshot;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GameObject soundEmitterParent;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Transform staticListenerPosition;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static bool showPlayingEmitterCount;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private static bool forceShowEmitterCount;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private static bool soundEnabled;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly AnimationCurve defaultReverbZoneMix;

		[Token(Token = "0x1700008E")]
		public static bool enableSpatialization
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x157E024", Offset = "0x157E024", VA = "0x157E024")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008F")]
		public static AudioManager Instance
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x157E104", Offset = "0x157E104", VA = "0x157E104")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		public static float NearFallOff
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x157E16C", Offset = "0x157E16C", VA = "0x157E16C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000091")]
		public static float FarFallOff
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x157E1E0", Offset = "0x157E1E0", VA = "0x157E1E0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000092")]
		public static AudioMixerGroup EmitterGroup
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x157E254", Offset = "0x157E254", VA = "0x157E254")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000093")]
		public static AudioMixerGroup ReservedGroup
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x157E2C8", Offset = "0x157E2C8", VA = "0x157E2C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public static AudioMixerGroup VoipGroup
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x157E33C", Offset = "0x157E33C", VA = "0x157E33C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public static bool SoundEnabled
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x15801EC", Offset = "0x15801EC", VA = "0x15801EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x157E3B0", Offset = "0x157E3B0", VA = "0x157E3B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x157E5E4", Offset = "0x157E5E4", VA = "0x157E5E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x157E3B4", Offset = "0x157E3B4", VA = "0x157E3B4")]
		private void Init()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x157F310", Offset = "0x157F310", VA = "0x157F310")]
		private void Update()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x157E73C", Offset = "0x157E73C", VA = "0x157E73C")]
		private void RebuildSoundFXCache()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x157F988", Offset = "0x157F988", VA = "0x157F988")]
		public static SoundFX FindSoundFX(string name, bool rebuildCache = false)
		{
			return null;
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x157FB08", Offset = "0x157FB08", VA = "0x157FB08")]
		private static bool FindAudioManager()
		{
			return default(bool);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x157FCA4", Offset = "0x157FCA4", VA = "0x157FCA4")]
		public static GameObject GetGameObject()
		{
			return null;
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x157FDA4", Offset = "0x157FDA4", VA = "0x157FDA4")]
		public static string NameMinusGroup(string name)
		{
			return null;
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x157FE34", Offset = "0x157FE34", VA = "0x157FE34")]
		public static string[] GetSoundFXNames(string currentValue, out int currentIdx)
		{
			return null;
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1580254", Offset = "0x1580254", VA = "0x1580254")]
		private static int CalculateMaxEmittersSize()
		{
			return default(int);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x15802CC", Offset = "0x15802CC", VA = "0x15802CC")]
		private static bool ValidateEmitterIndex(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x157EBF0", Offset = "0x157EBF0", VA = "0x157EBF0")]
		private void InitializeSoundSystem()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x157F314", Offset = "0x157F314", VA = "0x157F314")]
		private void UpdateFreeEmitters()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1580590", Offset = "0x1580590", VA = "0x1580590")]
		private string Fmt(int count)
		{
			return null;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1580694", Offset = "0x1580694", VA = "0x1580694")]
		private string FmtFree(int count)
		{
			return null;
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x158079C", Offset = "0x158079C", VA = "0x158079C")]
		private void OnPreSceneLoad()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1580458", Offset = "0x1580458", VA = "0x1580458")]
		private void ResetFreeEmitters()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1580910", Offset = "0x1580910", VA = "0x1580910")]
		public static void FadeOutSoundChannel(int channel, float delaySecs, float fadeTime)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1580A64", Offset = "0x1580A64", VA = "0x1580A64")]
		public static bool StopSound(int idx, bool fadeOut = true, bool stopReserved = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1580C14", Offset = "0x1580C14", VA = "0x1580C14")]
		public static void FadeInSound(int idx, float fadeTime, float volume)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x157DD28", Offset = "0x157DD28", VA = "0x157DD28")]
		public static void FadeInSound(int idx, float fadeTime)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x157DE9C", Offset = "0x157DE9C", VA = "0x157DE9C")]
		public static void FadeOutSound(int idx, float fadeTime)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1580DC0", Offset = "0x1580DC0", VA = "0x1580DC0")]
		public static void StopAllSounds(bool fadeOut, bool stopReserved = false)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1580E8C", Offset = "0x1580E8C", VA = "0x1580E8C")]
		public void MuteAllSounds(bool mute, bool muteReserved = false)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x1580F20", Offset = "0x1580F20", VA = "0x1580F20")]
		public void UnMuteAllSounds(bool unmute, bool unmuteReserved = false)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x1580FE4", Offset = "0x1580FE4", VA = "0x1580FE4")]
		public static float GetEmitterEndTime(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x1581088", Offset = "0x1581088", VA = "0x1581088")]
		public static float SetEmitterTime(int idx, float time)
		{
			return default(float);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1581168", Offset = "0x1581168", VA = "0x1581168")]
		public static int PlaySound(AudioClip clip, float volume, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float pitchVariance = 1f, bool loop = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1581D00", Offset = "0x1581D00", VA = "0x1581D00")]
		private static int FindFreeEmitter(EmitterChannel src, SoundPriority priority)
		{
			return default(int);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x1582400", Offset = "0x1582400", VA = "0x1582400")]
		public static int PlaySound(SoundFX soundFX, EmitterChannel src = EmitterChannel.Any, float delay = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x15825E0", Offset = "0x15825E0", VA = "0x15825E0")]
		public static int PlaySoundAt(Vector3 position, SoundFX soundFX, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float volumeOverride = 1f, float pitchMultiplier = 1f)
		{
			return default(int);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x15833EC", Offset = "0x15833EC", VA = "0x15833EC")]
		public static int PlayRandomSoundAt(Vector3 position, AudioClip[] clips, float volume, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float pitch = 1f, bool loop = false)
		{
			return default(int);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1581370", Offset = "0x1581370", VA = "0x1581370")]
		public static int PlaySoundAt(Vector3 position, AudioClip clip, float volume = 1f, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float pitch = 1f, bool loop = false)
		{
			return default(int);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x158350C", Offset = "0x158350C", VA = "0x158350C")]
		public static void SetOnFinished(int emitterIdx, Action onFinished)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x15835F4", Offset = "0x15835F4", VA = "0x15835F4")]
		public static void SetOnFinished(int emitterIdx, Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1583728", Offset = "0x1583728", VA = "0x1583728")]
		public static void AttachSoundToParent(int idx, Transform parent)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1583B28", Offset = "0x1583B28", VA = "0x1583B28")]
		public static void DetachSoundFromParent(int idx)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1583D3C", Offset = "0x1583D3C", VA = "0x1583D3C")]
		public static void DetachSoundsFromParent(SoundEmitter[] emitters, bool stopSounds = true)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1583E58", Offset = "0x1583E58", VA = "0x1583E58")]
		public static void SetEmitterMixerGroup(int idx, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1584020", Offset = "0x1584020", VA = "0x1584020")]
		public static MixerSnapshot GetActiveSnapshot()
		{
			return null;
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x15840F8", Offset = "0x15840F8", VA = "0x15840F8")]
		public static void SetCurrentSnapshot(MixerSnapshot mixerSnapshot)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1584240", Offset = "0x1584240", VA = "0x1584240")]
		public static void BlendWithCurrentSnapshot(MixerSnapshot blendSnapshot, float weight, float blendTime = 0f)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1584644", Offset = "0x1584644", VA = "0x1584644")]
		public AudioManager()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public enum EmitterChannel
	{
		[Token(Token = "0x4000643")]
		None = -1,
		[Token(Token = "0x4000644")]
		Reserved,
		[Token(Token = "0x4000645")]
		Any
	}
	[Serializable]
	[Token(Token = "0x2000115")]
	public class MixerSnapshot
	{
		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixerSnapshot snapshot;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float transitionTime;

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x158511C", Offset = "0x158511C", VA = "0x158511C")]
		public MixerSnapshot()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class MinMaxAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float minDefaultVal;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxDefaultVal;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float min;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float max;

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x15850C0", Offset = "0x15850C0", VA = "0x15850C0")]
		public MinMaxAttribute(float minDefaultVal, float maxDefaultVal, float min, float max)
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class SoundEmitter : MonoBehaviour
	{
		[Token(Token = "0x200019A")]
		public enum FadeState
		{
			[Token(Token = "0x40008AF")]
			Null,
			[Token(Token = "0x40008B0")]
			FadingIn,
			[Token(Token = "0x40008B1")]
			FadingOut,
			[Token(Token = "0x40008B2")]
			Ducking
		}

		[Token(Token = "0x200019B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6D0DC", Offset = "0xA6D0DC")]
		private sealed class <DelayedSyncTo>d__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundEmitter <>4__this;

			[Token(Token = "0x40008B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundEmitter other;

			[Token(Token = "0x40008B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float fadeTime;

			[Token(Token = "0x40008B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float toVolume;

			[Token(Token = "0x170000E9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600084E")]
				[Address(RVA = "0x1585BE0", Offset = "0x1585BE0", VA = "0x1585BE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000850")]
				[Address(RVA = "0x1585C48", Offset = "0x1585C48", VA = "0x1585C48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600084B")]
			[Address(RVA = "0x158589C", Offset = "0x158589C", VA = "0x158589C")]
			[DebuggerHidden]
			public <DelayedSyncTo>d__57(int <>1__state)
			{
			}

			[Token(Token = "0x600084C")]
			[Address(RVA = "0x1585AE4", Offset = "0x1585AE4", VA = "0x1585AE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600084D")]
			[Address(RVA = "0x1585AE8", Offset = "0x1585AE8", VA = "0x1585AE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600084F")]
			[Address(RVA = "0x1585BE8", Offset = "0x1585BE8", VA = "0x1585BE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200019C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6D0EC", Offset = "0xA6D0EC")]
		private sealed class <FadeSoundChannelTo>d__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundEmitter <>4__this;

			[Token(Token = "0x40008BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float toVolume;

			[Token(Token = "0x40008BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float fadeTime;

			[Token(Token = "0x40008BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <start>5__2;

			[Token(Token = "0x40008BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <end>5__3;

			[Token(Token = "0x40008C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x40008C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <elapsedTime>5__5;

			[Token(Token = "0x170000EB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000854")]
				[Address(RVA = "0x15860B8", Offset = "0x15860B8", VA = "0x15860B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000856")]
				[Address(RVA = "0x1586120", Offset = "0x1586120", VA = "0x1586120", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0x1585A74", Offset = "0x1585A74", VA = "0x1585A74")]
			[DebuggerHidden]
			public <FadeSoundChannelTo>d__63(int <>1__state)
			{
			}

			[Token(Token = "0x6000852")]
			[Address(RVA = "0x1585F40", Offset = "0x1585F40", VA = "0x1585F40", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000853")]
			[Address(RVA = "0x1585F44", Offset = "0x1585F44", VA = "0x1585F44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x15860C0", Offset = "0x15860C0", VA = "0x15860C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200019D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6D0FC", Offset = "0xA6D0FC")]
		private sealed class <FadeSoundChannel>d__64 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delaySecs;

			[Token(Token = "0x40008C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Fade fadeType;

			[Token(Token = "0x40008C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float defaultVolume;

			[Token(Token = "0x40008C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SoundEmitter <>4__this;

			[Token(Token = "0x40008C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float fadeTime;

			[Token(Token = "0x40008C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <start>5__2;

			[Token(Token = "0x40008CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <end>5__3;

			[Token(Token = "0x40008CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private bool <restartPlay>5__4;

			[Token(Token = "0x40008CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <startTime>5__5;

			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float <elapsedTime>5__6;

			[Token(Token = "0x170000ED")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600085A")]
				[Address(RVA = "0x1585ED0", Offset = "0x1585ED0", VA = "0x1585ED0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600085C")]
				[Address(RVA = "0x1585F38", Offset = "0x1585F38", VA = "0x1585F38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0x1585AA0", Offset = "0x1585AA0", VA = "0x1585AA0")]
			[DebuggerHidden]
			public <FadeSoundChannel>d__64(int <>1__state)
			{
			}

			[Token(Token = "0x6000858")]
			[Address(RVA = "0x1585C50", Offset = "0x1585C50", VA = "0x1585C50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000859")]
			[Address(RVA = "0x1585C54", Offset = "0x1585C54", VA = "0x1585C54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600085B")]
			[Address(RVA = "0x1585ED8", Offset = "0x1585ED8", VA = "0x1585ED8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EmitterChannel channel;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disableSpatialization;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FadeState state;

		[NonSerialized]
		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public AudioSource audioSource;

		[NonSerialized]
		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public SoundPriority priority;

		[NonSerialized]
		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public ONSPAudioSource osp;

		[NonSerialized]
		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float endPlayTime;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform lastParentTransform;

		[NonSerialized]
		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public float defaultVolume;

		[NonSerialized]
		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public Transform defaultParent;

		[NonSerialized]
		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public int originalIdx;

		[NonSerialized]
		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public Action onFinished;

		[NonSerialized]
		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public Action<object> onFinishedObject;

		[NonSerialized]
		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public object onFinishedParam;

		[NonSerialized]
		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public SoundGroup playingSoundGroup;

		[Token(Token = "0x17000096")]
		public float volume
		{
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x15833D0", Offset = "0x15833D0", VA = "0x15833D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x15851BC", Offset = "0x15851BC", VA = "0x15851BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public float pitch
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x15851D8", Offset = "0x15851D8", VA = "0x15851D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x15851F4", Offset = "0x15851F4", VA = "0x15851F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public AudioClip clip
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x1585210", Offset = "0x1585210", VA = "0x1585210")]
			get
			{
				return null;
			}
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x158522C", Offset = "0x158522C", VA = "0x158522C")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public float time
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x1585248", Offset = "0x1585248", VA = "0x1585248")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x158114C", Offset = "0x158114C", VA = "0x158114C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public float length
		{
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x1585264", Offset = "0x1585264", VA = "0x1585264")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009B")]
		public bool loop
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x158531C", Offset = "0x158531C", VA = "0x158531C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x1585338", Offset = "0x1585338", VA = "0x1585338")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public bool mute
		{
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x1585358", Offset = "0x1585358", VA = "0x1585358")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x1585374", Offset = "0x1585374", VA = "0x1585374")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public AudioVelocityUpdateMode velocityUpdateMode
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x1585394", Offset = "0x1585394", VA = "0x1585394")]
			get
			{
				return default(AudioVelocityUpdateMode);
			}
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x15853B0", Offset = "0x15853B0", VA = "0x15853B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public bool isPlaying
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x15853CC", Offset = "0x15853CC", VA = "0x15853CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x15853E8", Offset = "0x15853E8", VA = "0x15853E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1583398", Offset = "0x1583398", VA = "0x1583398")]
		public void SetPlayingSoundGroup(SoundGroup soundGroup)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x158562C", Offset = "0x158562C", VA = "0x158562C")]
		public void SetOnFinished(Action onFinished)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x15836F4", Offset = "0x15836F4", VA = "0x15836F4")]
		public void SetOnFinished(Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1585634", Offset = "0x1585634", VA = "0x1585634")]
		public void SetChannel(int _channel)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x158563C", Offset = "0x158563C", VA = "0x158563C")]
		public void SetDefaultParent(Transform parent)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1583F78", Offset = "0x1583F78", VA = "0x1583F78")]
		public void SetAudioMixer(AudioMixerGroup _mixer)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1580524", Offset = "0x1580524", VA = "0x1580524")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1585644", Offset = "0x1585644", VA = "0x1585644")]
		public void Play()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x15856A4", Offset = "0x15856A4", VA = "0x15856A4")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1580344", Offset = "0x1580344", VA = "0x1580344")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x158576C", Offset = "0x158576C", VA = "0x158576C")]
		private int GetSampleTime()
		{
			return default(int);
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1583A1C", Offset = "0x1583A1C", VA = "0x1583A1C")]
		public void ParentTo(Transform parent)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1583C6C", Offset = "0x1583C6C", VA = "0x1583C6C")]
		public void DetachFromParent()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x15808C8", Offset = "0x15808C8", VA = "0x15808C8")]
		public void ResetParent(Transform parent)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x15857C4", Offset = "0x15857C4", VA = "0x15857C4")]
		public void SyncTo(SoundEmitter other, float fadeTime, float toVolume)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x15857F0", Offset = "0x15857F0", VA = "0x15857F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA7188C", Offset = "0xA7188C")]
		private IEnumerator DelayedSyncTo(SoundEmitter other, float fadeTime, float toVolume)
		{
			return null;
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x15858C8", Offset = "0x15858C8", VA = "0x15858C8")]
		public void FadeTo(float fadeTime, float toVolume)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1580CCC", Offset = "0x1580CCC", VA = "0x1580CCC")]
		public void FadeIn(float fadeTime, float defaultVolume)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1580D48", Offset = "0x1580D48", VA = "0x1580D48")]
		public void FadeIn(float fadeTime)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1580B7C", Offset = "0x1580B7C", VA = "0x1580B7C")]
		public void FadeOut(float fadeTime)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x15809C8", Offset = "0x15809C8", VA = "0x15809C8")]
		public void FadeOutDelayed(float delayedSecs, float fadeTime)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1585930", Offset = "0x1585930", VA = "0x1585930")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA718F0", Offset = "0xA718F0")]
		private IEnumerator FadeSoundChannelTo(float fadeTime, float toVolume)
		{
			return null;
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x15859C0", Offset = "0x15859C0", VA = "0x15859C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA71954", Offset = "0xA71954")]
		private IEnumerator FadeSoundChannel(float delaySecs, float fadeTime, Fade fadeType, float defaultVolume)
		{
			return null;
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1585ACC", Offset = "0x1585ACC", VA = "0x1585ACC")]
		public SoundEmitter()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public enum SoundFXNext
	{
		[Token(Token = "0x400065C")]
		Random,
		[Token(Token = "0x400065D")]
		Sequential
	}
	[Token(Token = "0x2000119")]
	public enum FreqHint
	{
		[Token(Token = "0x400065F")]
		None,
		[Token(Token = "0x4000660")]
		Wide,
		[Token(Token = "0x4000661")]
		Narrow
	}
	[Token(Token = "0x200011A")]
	public enum SoundPriority
	{
		[Token(Token = "0x4000663")]
		VeryLow = -2,
		[Token(Token = "0x4000664")]
		Low,
		[Token(Token = "0x4000665")]
		Default,
		[Token(Token = "0x4000666")]
		High,
		[Token(Token = "0x4000667")]
		VeryHigh
	}
	[Serializable]
	[Token(Token = "0x200011B")]
	public class OSPProps
	{
		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FBE4", Offset = "0xA6FBE4")]
		public bool enableSpatialization;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FC1C", Offset = "0xA6FC1C")]
		public bool useFastOverride;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FC54", Offset = "0xA6FC54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6FC54", Offset = "0xA6FC54")]
		public float gain;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FCA8", Offset = "0xA6FCA8")]
		public bool enableInvSquare;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FCE0", Offset = "0xA6FCE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6FCE0", Offset = "0xA6FCE0")]
		public float volumetric;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FD38", Offset = "0xA6FD38")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0xA6FD38", Offset = "0xA6FD38")]
		public Vector2 invSquareFalloff;

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x158512C", Offset = "0x158512C", VA = "0x158512C")]
		public OSPProps()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011C")]
	public class SoundFX
	{
		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FD98", Offset = "0xA6FD98")]
		public string name;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FDD0", Offset = "0xA6FDD0")]
		public SoundFXNext playback;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FE08", Offset = "0xA6FE08")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6FE08", Offset = "0xA6FE08")]
		public float volume;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FE5C", Offset = "0xA6FE5C")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0xA6FE5C", Offset = "0xA6FE5C")]
		public Vector2 pitchVariance;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FEB8", Offset = "0xA6FEB8")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0xA6FEB8", Offset = "0xA6FEB8")]
		public Vector2 falloffDistance;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FF18", Offset = "0xA6FF18")]
		public AudioRolloffMode falloffCurve;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FF50", Offset = "0xA6FF50")]
		public AnimationCurve volumeFalloffCurve;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FF88", Offset = "0xA6FF88")]
		public AnimationCurve reverbZoneMix;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA6FFC0", Offset = "0xA6FFC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA6FFC0", Offset = "0xA6FFC0")]
		public float spread;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA70018", Offset = "0xA70018")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA70018", Offset = "0xA70018")]
		public float pctChanceToPlay;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA7006C", Offset = "0xA7006C")]
		public SoundPriority priority;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA700A4", Offset = "0xA700A4")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0xA700A4", Offset = "0xA700A4")]
		public Vector2 delay;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA70100", Offset = "0xA70100")]
		public bool looping;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public OSPProps ospProps;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA70138", Offset = "0xA70138")]
		public AudioClip[] soundClips;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool visibilityToggle;

		[NonSerialized]
		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private SoundGroup soundGroup;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int lastIdx;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int playingIdx;

		[Token(Token = "0x1700009F")]
		public int Length
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x1586128", Offset = "0x1586128", VA = "0x1586128")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A0")]
		public bool IsValid
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x1586144", Offset = "0x1586144", VA = "0x1586144")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A1")]
		public SoundGroup Group
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x15861E8", Offset = "0x15861E8", VA = "0x15861E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x15861F0", Offset = "0x15861F0", VA = "0x15861F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public float MaxFalloffDistSquared
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x15832A0", Offset = "0x15832A0", VA = "0x15832A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A3")]
		public float GroupVolumeOverride
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x15832D4", Offset = "0x15832D4", VA = "0x15832D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x15849C4", Offset = "0x15849C4", VA = "0x15849C4")]
		public SoundFX()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x15831D0", Offset = "0x15831D0", VA = "0x15831D0")]
		public AudioClip GetClip()
		{
			return null;
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x15832F8", Offset = "0x15832F8", VA = "0x15832F8")]
		public AudioMixerGroup GetMixerGroup(AudioMixerGroup defaultMixerGroup)
		{
			return null;
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x15832AC", Offset = "0x15832AC", VA = "0x15832AC")]
		public bool ReachedGroupPlayLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x1586218", Offset = "0x1586218", VA = "0x1586218")]
		public float GetClipLength(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x15832EC", Offset = "0x15832EC", VA = "0x15832EC")]
		public float GetPitch()
		{
			return default(float);
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1586314", Offset = "0x1586314", VA = "0x1586314")]
		public int PlaySound(float delaySecs = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x15863F0", Offset = "0x15863F0", VA = "0x15863F0")]
		public int PlaySoundAt(Vector3 pos, float delaySecs = 0f, float volumeOverride = 1f, float pitchMultiplier = 1f)
		{
			return default(int);
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1586504", Offset = "0x1586504", VA = "0x1586504")]
		public void SetOnFinished(Action onFinished)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1586590", Offset = "0x1586590", VA = "0x1586590")]
		public void SetOnFinished(Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1586624", Offset = "0x1586624", VA = "0x1586624")]
		public bool StopSound()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x15866B0", Offset = "0x15866B0", VA = "0x15866B0")]
		public void AttachToParent(Transform parent)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x158673C", Offset = "0x158673C", VA = "0x158673C")]
		public void DetachFromParent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011D")]
	public class SoundFXRef
	{
		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundFXName;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool initialized;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SoundFX soundFXCached;

		[Token(Token = "0x170000A4")]
		public SoundFX soundFX
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x15867B4", Offset = "0x15867B4", VA = "0x15867B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public string name
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x15868C8", Offset = "0x15868C8", VA = "0x15868C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x15868D0", Offset = "0x15868D0", VA = "0x15868D0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public int Length
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x15868F8", Offset = "0x15868F8", VA = "0x15868F8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A7")]
		public bool IsValid
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x158693C", Offset = "0x158693C", VA = "0x158693C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x15867E4", Offset = "0x15867E4", VA = "0x15867E4")]
		private void Init()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1586974", Offset = "0x1586974", VA = "0x1586974")]
		public AudioClip GetClip()
		{
			return null;
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x15869AC", Offset = "0x15869AC", VA = "0x15869AC")]
		public float GetClipLength(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x15869EC", Offset = "0x15869EC", VA = "0x15869EC")]
		public int PlaySound(float delaySecs = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x157DCA8", Offset = "0x157DCA8", VA = "0x157DCA8")]
		public int PlaySoundAt(Vector3 pos, float delaySecs = 0f, float volume = 1f, float pitchMultiplier = 1f)
		{
			return default(int);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1586A34", Offset = "0x1586A34", VA = "0x1586A34")]
		public void SetOnFinished(Action onFinished)
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1586A74", Offset = "0x1586A74", VA = "0x1586A74")]
		public void SetOnFinished(Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1586AC4", Offset = "0x1586AC4", VA = "0x1586AC4")]
		public bool StopSound()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1586AFC", Offset = "0x1586AFC", VA = "0x1586AFC")]
		public void AttachToParent(Transform parent)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1586B3C", Offset = "0x1586B3C", VA = "0x1586B3C")]
		public void DetachFromParent()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1586B74", Offset = "0x1586B74", VA = "0x1586B74")]
		public SoundFXRef()
		{
		}
	}
}
namespace UnityEngine.Timeline
{
	[Token(Token = "0x200011E")]
	public class VideoPlayableBehaviour : PlayableBehaviour
	{
		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public VideoPlayer videoPlayer;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VideoClip videoClip;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mute;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool loop;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double preloadTime;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public double clipInTime;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool playedOnce;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool preparing;

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xDCB680", Offset = "0xDCB680", VA = "0xDCB680")]
		public void PrepareVideo()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xDCBA38", Offset = "0xDCBA38", VA = "0xDCBA38")]
		private void LoopPointReached(VideoPlayer vp)
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xDCBA48", Offset = "0xDCBA48", VA = "0xDCBA48", Slot = "19")]
		public override void PrepareFrame(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xDCBD34", Offset = "0xDCBD34", VA = "0xDCBD34", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xDCBE94", Offset = "0xDCBE94", VA = "0xDCBE94", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xDCBFC8", Offset = "0xDCBFC8", VA = "0xDCBFC8", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xDCC1BC", Offset = "0xDCC1BC", VA = "0xDCC1BC", Slot = "13")]
		public override void OnGraphStart(Playable playable)
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xDCC1C4", Offset = "0xDCC1C4", VA = "0xDCC1C4", Slot = "14")]
		public override void OnGraphStop(Playable playable)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xDCC1FC", Offset = "0xDCC1FC", VA = "0xDCC1FC", Slot = "16")]
		public override void OnPlayableDestroy(Playable playable)
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xDCBDE8", Offset = "0xDCBDE8", VA = "0xDCBDE8")]
		public void PlayVideo()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xDCBF38", Offset = "0xDCBF38", VA = "0xDCBF38")]
		public void PauseVideo()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xDCB9A4", Offset = "0xDCB9A4", VA = "0xDCB9A4")]
		public void StopVideo()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xDCBBBC", Offset = "0xDCBBBC", VA = "0xDCBBBC")]
		private void SyncVideoToPlayable(Playable playable)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xDCC200", Offset = "0xDCC200", VA = "0xDCC200")]
		public VideoPlayableBehaviour()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public sealed class VideoSchedulerPlayableBehaviour : PlayableBehaviour
	{
		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IEnumerable<TimelineClip> m_Clips;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlayableDirector m_Director;

		[Token(Token = "0x170000A8")]
		internal PlayableDirector director
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0xDCC21C", Offset = "0xDCC21C", VA = "0xDCC21C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0xDCC224", Offset = "0xDCC224", VA = "0xDCC224")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		internal IEnumerable<TimelineClip> clips
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0xDCC22C", Offset = "0xDCC22C", VA = "0xDCC22C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0xDCC234", Offset = "0xDCC234", VA = "0xDCC234")]
			set
			{
			}
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xDCC23C", Offset = "0xDCC23C", VA = "0xDCC23C", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xDCC63C", Offset = "0xDCC63C", VA = "0xDCC63C")]
		public VideoSchedulerPlayableBehaviour()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000120")]
	public class VideoScriptPlayableAsset : PlayableAsset
	{
		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ExposedReference<VideoPlayer> videoPlayer;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[NotKeyable]
		public VideoClip videoClip;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[NotKeyable]
		public bool mute;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[SerializeField]
		[NotKeyable]
		public bool loop;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[NotKeyable]
		public double preloadTime;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[NotKeyable]
		public double clipInTime;

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xDCC644", Offset = "0xDCC644", VA = "0xDCC644", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xDCC784", Offset = "0xDCC784", VA = "0xDCC784")]
		public VideoScriptPlayableAsset()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000121")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0xA6CD98", Offset = "0xA6CD98")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0xA6CD98", Offset = "0xA6CD98")]
	public class VideoScriptPlayableTrack : TrackAsset
	{
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xDCC7A0", Offset = "0xDCC7A0", VA = "0xDCC7A0", Slot = "24")]
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xDCC8F4", Offset = "0xDCC8F4", VA = "0xDCC8F4")]
		public VideoScriptPlayableTrack()
		{
		}
	}
}
namespace TFHC_Shader_Samples
{
	[Token(Token = "0x2000122")]
	public class highlightAnimated : MonoBehaviour
	{
		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Material mat;

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xDC5694", Offset = "0xDC5694", VA = "0xDC5694")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xDC5704", Offset = "0xDC5704", VA = "0xDC5704")]
		private void OnMouseEnter()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xDC5784", Offset = "0xDC5784", VA = "0xDC5784")]
		private void OnMouseExit()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xDC570C", Offset = "0xDC570C", VA = "0xDC570C")]
		private void switchhighlighted(bool highlighted)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xDC578C", Offset = "0xDC578C", VA = "0xDC578C")]
		public highlightAnimated()
		{
		}
	}
}
namespace TFHC_ForceShield_Shader_Sample
{
	[Token(Token = "0x2000123")]
	public class ForceShieldDestroyBall : MonoBehaviour
	{
		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float lifetime;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xDC5100", Offset = "0xDC5100", VA = "0xDC5100")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xDC518C", Offset = "0xDC518C", VA = "0xDC518C")]
		public ForceShieldDestroyBall()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class ForceShieldImpactDetection : MonoBehaviour
	{
		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float hitTime;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material mat;

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xDC519C", Offset = "0xDC519C", VA = "0xDC519C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xDC520C", Offset = "0xDC520C", VA = "0xDC520C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xDC52B0", Offset = "0xDC52B0", VA = "0xDC52B0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xDC5460", Offset = "0xDC5460", VA = "0xDC5460")]
		public ForceShieldImpactDetection()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class ForceShieldShootBall : MonoBehaviour
	{
		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody bullet;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform origshoot;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float distance;

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xDC5468", Offset = "0xDC5468", VA = "0xDC5468")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xDC5680", Offset = "0xDC5680", VA = "0xDC5680")]
		public ForceShieldShootBall()
		{
		}
	}
}
