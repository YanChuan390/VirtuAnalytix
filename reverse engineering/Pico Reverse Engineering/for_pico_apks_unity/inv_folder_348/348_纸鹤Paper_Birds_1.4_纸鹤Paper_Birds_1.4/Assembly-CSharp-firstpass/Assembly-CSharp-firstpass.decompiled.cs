using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace VLB;

[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x87EF9C", Offset = "0x87EF9C")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87EF9C", Offset = "0x87EF9C")]
[ExecuteInEditMode]
public class BeamGeometry : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F00C", Offset = "0x87F00C")]
	private sealed class <CoUpdateFadeOut>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		public BeamGeometry <>4__this;

		[Token(Token = "0x1700000D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x16BF71C", Offset = "0x16BF71C", VA = "0x16BF71C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x16BF784", Offset = "0x16BF784", VA = "0x16BF784", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x16BB70C", Offset = "0x16BB70C", VA = "0x16BB70C")]
		[DebuggerHidden]
		public <CoUpdateFadeOut>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x16BF688", Offset = "0x16BF688", VA = "0x16BF688", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x16BF68C", Offset = "0x16BF68C", VA = "0x16BF68C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x16BF724", Offset = "0x16BF724", VA = "0x16BF724", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	private VolumetricLightBeam m_Master;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	private Matrix4x4 m_ColorGradientMatrix;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x60")]
	private MeshType m_CurrentMeshType;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x68")]
	private Material m_CustomMaterial;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x70")]
	private Coroutine m_CoFadeOut;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F310", Offset = "0x87F310")]
	private MeshRenderer <meshRenderer>k__BackingField;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F320", Offset = "0x87F320")]
	private MeshFilter <meshFilter>k__BackingField;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F330", Offset = "0x87F330")]
	private Mesh <coneMesh>k__BackingField;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x90")]
	private DynamicOcclusion _dynamicOcclusion;

	[Token(Token = "0x17000001")]
	public MeshRenderer meshRenderer
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x16BB40C", Offset = "0x16BB40C", VA = "0x16BB40C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FA00", Offset = "0x87FA00")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x16BB414", Offset = "0x16BB414", VA = "0x16BB414")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FA10", Offset = "0x87FA10")]
		private set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public MeshFilter meshFilter
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x16BB41C", Offset = "0x16BB41C", VA = "0x16BB41C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FA20", Offset = "0x87FA20")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x16BB424", Offset = "0x16BB424", VA = "0x16BB424")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FA30", Offset = "0x87FA30")]
		private set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public Mesh coneMesh
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x16BB42C", Offset = "0x16BB42C", VA = "0x16BB42C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FA40", Offset = "0x87FA40")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x16BB434", Offset = "0x16BB434", VA = "0x16BB434")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FA50", Offset = "0x87FA50")]
		private set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public bool visible
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x16BB43C", Offset = "0x16BB43C", VA = "0x16BB43C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x16BB458", Offset = "0x16BB458", VA = "0x16BB458")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public int sortingLayerID
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x16BB478", Offset = "0x16BB478", VA = "0x16BB478")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x16BB494", Offset = "0x16BB494", VA = "0x16BB494")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public int sortingOrder
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x16BB4B0", Offset = "0x16BB4B0", VA = "0x16BB4B0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x16BB4CC", Offset = "0x16BB4CC", VA = "0x16BB4CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public bool _INTERNAL_IsFadeOutCoroutineRunning
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x16BB4E8", Offset = "0x16BB4E8", VA = "0x16BB4E8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000008")]
	public static bool isCustomRenderPipelineSupported
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x16BBFF8", Offset = "0x16BBFF8", VA = "0x16BBFF8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000009")]
	private bool isNoiseEnabled
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x16BDE64", Offset = "0x16BDE64", VA = "0x16BDE64")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000A")]
	private bool isClippingPlaneEnabled
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x16BE054", Offset = "0x16BE054", VA = "0x16BE054")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000B")]
	private bool isDepthBlendEnabled
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x16BE124", Offset = "0x16BE124", VA = "0x16BE124")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000C")]
	public DynamicOcclusion dynamicOcclusion
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x16BEFDC", Offset = "0x16BEFDC", VA = "0x16BEFDC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x16BEFE4", Offset = "0x16BEFE4", VA = "0x16BEFE4")]
		set
		{
		}
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x16BB4F8", Offset = "0x16BB4F8", VA = "0x16BB4F8")]
	private float ComputeFadeOutFactor(Transform camTransform)
	{
		return default(float);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x16BB69C", Offset = "0x16BB69C", VA = "0x16BB69C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x87FA60", Offset = "0x87FA60")]
	private IEnumerator CoUpdateFadeOut()
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x16BB738", Offset = "0x16BB738", VA = "0x16BB738")]
	private void ComputeFadeOutFactor()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x16BB8DC", Offset = "0x16BB8DC", VA = "0x16BB8DC")]
	private void SetFadeOutFactorProp(float value)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x16BBC20", Offset = "0x16BBC20", VA = "0x16BBC20")]
	public void RestartFadeOutCoroutine()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x16BBCEC", Offset = "0x16BBCEC", VA = "0x16BBCEC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x16BBDAC", Offset = "0x16BBDAC", VA = "0x16BBDAC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x16BBE54", Offset = "0x16BBE54", VA = "0x16BBE54")]
	private static bool IsUsingCustomRenderPipeline()
	{
		return default(bool);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x16BBF48", Offset = "0x16BBF48", VA = "0x16BBF48")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x16BC000", Offset = "0x16BC000", VA = "0x16BC000")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x16BC0B8", Offset = "0x16BC0B8", VA = "0x16BC0B8")]
	public void Initialize(VolumetricLightBeam master)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x16BC854", Offset = "0x16BC854", VA = "0x16BC854")]
	public void RegenerateMesh()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x16BDD68", Offset = "0x16BDD68", VA = "0x16BDD68")]
	private void ComputeLocalMatrix()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x16BC590", Offset = "0x16BC590", VA = "0x16BC590")]
	private bool ApplyMaterial()
	{
		return default(bool);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x16BBA68", Offset = "0x16BBA68", VA = "0x16BBA68")]
	private void SetMaterialProp(int nameID, float value)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x16BE6F4", Offset = "0x16BE6F4", VA = "0x16BE6F4")]
	private void SetMaterialProp(int nameID, Vector4 value)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x16BE818", Offset = "0x16BE818", VA = "0x16BE818")]
	private void SetMaterialProp(int nameID, Color value)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x16BE93C", Offset = "0x16BE93C", VA = "0x16BE93C")]
	private void SetMaterialProp(int nameID, Matrix4x4 value)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x16BB9A4", Offset = "0x16BB9A4", VA = "0x16BB9A4")]
	private void MaterialChangeStart()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x16BBB5C", Offset = "0x16BBB5C", VA = "0x16BBB5C")]
	private void MaterialChangeStop()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x16BEA68", Offset = "0x16BEA68", VA = "0x16BEA68")]
	private void SendMaterialClippingPlaneProp()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x16BD6A4", Offset = "0x16BD6A4", VA = "0x16BD6A4")]
	public void UpdateMaterialAndBounds()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x16BF104", Offset = "0x16BF104", VA = "0x16BF104")]
	private void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x16BF48C", Offset = "0x16BF48C", VA = "0x16BF48C")]
	private void OnWillRenderObject()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x16BF52C", Offset = "0x16BF52C", VA = "0x16BF52C")]
	private static bool IsEditorCamera(Camera cam)
	{
		return default(bool);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x16BF10C", Offset = "0x16BF10C", VA = "0x16BF10C")]
	private void UpdateCameraRelatedProperties(Camera cam)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x16BF680", Offset = "0x16BF680", VA = "0x16BF680")]
	public BeamGeometry()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87F01C", Offset = "0x87F01C")]
public class Config : ScriptableObject
{
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x18")]
	public bool geometryOverrideLayer;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x1C")]
	public int geometryLayerID;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x20")]
	public string geometryTag;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x28")]
	public int geometryRenderQueue;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x2C")]
	public RenderPipeline renderPipeline;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87F340", Offset = "0x87F340")]
	public bool forceSinglePass;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x34")]
	public RenderingMode renderingMode;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[HighlightNull]
	private Shader beamShader1Pass;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x87F3B0", Offset = "0x87F3B0")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x87F3B0", Offset = "0x87F3B0")]
	[HighlightNull]
	[SerializeField]
	private Shader beamShader2Pass;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x48")]
	[HighlightNull]
	[SerializeField]
	private Shader beamShaderSRP;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x50")]
	public int sharedMeshSides;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x54")]
	public int sharedMeshSegments;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F468", Offset = "0x87F468")]
	public float globalNoiseScale;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x5C")]
	public Vector3 globalNoiseVelocity;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x68")]
	public string fadeOutCameraTag;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x70")]
	[HighlightNull]
	public TextAsset noise3DData;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x78")]
	public int noise3DSize;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x80")]
	[HighlightNull]
	public ParticleSystem dustParticlesPrefab;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private int pluginVersion;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x90")]
	private Transform m_CachedFadeOutCamera;

	[Token(Token = "0x4000021")]
	private const string kAssetName = "Config";

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x0")]
	private static Config m_Instance;

	[Token(Token = "0x1700000F")]
	public RenderingMode actualRenderingMode
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x16BC404", Offset = "0x16BC404", VA = "0x16BC404")]
		get
		{
			return default(RenderingMode);
		}
	}

	[Token(Token = "0x17000010")]
	public bool useSinglePassShader
	{
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x16BCB14", Offset = "0x16BCB14", VA = "0x16BCB14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000011")]
	public Shader beamShader
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x16BF78C", Offset = "0x16BF78C", VA = "0x16BF78C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000012")]
	public Vector4 globalNoiseParam
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x16BF824", Offset = "0x16BF824", VA = "0x16BF824")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x17000013")]
	public Transform fadeOutCameraTransform
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x16BB858", Offset = "0x16BB858", VA = "0x16BB858")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000014")]
	public static Config Instance
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x16BB7F8", Offset = "0x16BB7F8", VA = "0x16BB7F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x16BF85C", Offset = "0x16BF85C", VA = "0x16BF85C")]
	public void ForceUpdateFadeOutCamera()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x16BF8F8", Offset = "0x16BF8F8", VA = "0x16BF8F8")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x87FB14", Offset = "0x87FB14")]
	private static void OnStartup()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x16BF818", Offset = "0x16BF818", VA = "0x16BF818")]
	private static bool ShouldEnableSrpApi(RenderPipeline pipeline)
	{
		return default(bool);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x16BF970", Offset = "0x16BF970", VA = "0x16BF970")]
	public static void OnRenderPipelineChanged(RenderPipeline pipeline)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x16BFA0C", Offset = "0x16BFA0C", VA = "0x16BFA0C")]
	public void Reset()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x16BFACC", Offset = "0x16BFACC", VA = "0x16BFACC")]
	public void ResetInternalData()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x16BFC30", Offset = "0x16BFC30", VA = "0x16BFC30")]
	public ParticleSystem NewVolumetricDustParticles()
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x16BFDC4", Offset = "0x16BFDC4", VA = "0x16BFDC4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x16BFDF4", Offset = "0x16BFDF4", VA = "0x16BFDF4")]
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x16BFE8C", Offset = "0x16BFE8C", VA = "0x16BFE8C")]
	private static Config GetInstance(bool assertIfNotFound)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x16BFFF4", Offset = "0x16BFFF4", VA = "0x16BFFF4")]
	public Config()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87F054", Offset = "0x87F054")]
public class ConfigOverride : Config
{
	[Token(Token = "0x4000023")]
	public const string kAssetName = "VLBConfigOverride";

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x16C00D0", Offset = "0x16C00D0", VA = "0x16C00D0")]
	public ConfigOverride()
	{
	}
}
[Token(Token = "0x2000006")]
public static class Consts
{
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x0")]
	public static readonly bool ProceduralObjectsVisibleInEditor;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x4")]
	public static readonly Color FlatColor;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x14")]
	public static readonly Vector3 NoiseVelocityDefault;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x20")]
	public static readonly LayerMask DynOcclusionLayerMaskDefault;

	[Token(Token = "0x17000015")]
	public static HideFlags ProceduralObjectsHideFlags
	{
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x16BC390", Offset = "0x16BC390", VA = "0x16BC390")]
		get
		{
			return default(HideFlags);
		}
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87F08C", Offset = "0x87F08C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x87F08C", Offset = "0x87F08C")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
public class DynamicOcclusion : MonoBehaviour
{
	[Token(Token = "0x2000008")]
	public class HitResult
	{
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 point;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 normal;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x28")]
		public float distance;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x30")]
		private Collider2D collider2D;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x38")]
		private Collider collider3D;

		[Token(Token = "0x1700001A")]
		public bool hasCollider
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x16C15B0", Offset = "0x16C15B0", VA = "0x16C15B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x16C10B8", Offset = "0x16C10B8", VA = "0x16C10B8")]
		public HitResult(RaycastHit hit3D)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x16C11BC", Offset = "0x16C11BC", VA = "0x16C11BC")]
		public HitResult(RaycastHit2D hit2D)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x16C1128", Offset = "0x16C1128", VA = "0x16C1128")]
		public HitResult()
		{
		}
	}

	[Token(Token = "0x2000009")]
	private enum Direction
	{
		[Token(Token = "0x400003E")]
		Up,
		[Token(Token = "0x400003F")]
		Right,
		[Token(Token = "0x4000040")]
		Down,
		[Token(Token = "0x4000041")]
		Left
	}

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x18")]
	public OccluderDimensions dimensions;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x1C")]
	public LayerMask layerMask;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x20")]
	public bool considerTriggers;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x24")]
	public float minOccluderArea;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x28")]
	public int waitFrameCount;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x2C")]
	public float minSurfaceRatio;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x30")]
	public float maxSurfaceDot;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x34")]
	public PlaneAlignment planeAlignment;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x38")]
	public float planeOffset;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x3C")]
	public float fadeDistanceToPlane;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F4B4", Offset = "0x87F4B4")]
	private HitResult <currentHit>k__BackingField;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x48")]
	private VolumetricLightBeam m_Master;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x50")]
	private int m_FrameCountToWait;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x54")]
	private float m_RangeMultiplier;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F4C4", Offset = "0x87F4C4")]
	private Plane <planeEquationWS>k__BackingField;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x68")]
	private uint m_PrevNonSubHitDirectionId;

	[Token(Token = "0x17000016")]
	public HitResult currentHit
	{
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x16C0334", Offset = "0x16C0334", VA = "0x16C0334")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FB24", Offset = "0x87FB24")]
		get
		{
			return null;
		}
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x16C033C", Offset = "0x16C033C", VA = "0x16C033C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FB34", Offset = "0x87FB34")]
		private set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public Plane planeEquationWS
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x16C0344", Offset = "0x16C0344", VA = "0x16C0344")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FB44", Offset = "0x87FB44")]
		get
		{
			return default(Plane);
		}
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x16C0350", Offset = "0x16C0350", VA = "0x16C0350")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FB54", Offset = "0x87FB54")]
		private set
		{
		}
	}

	[Token(Token = "0x17000018")]
	private QueryTriggerInteraction queryTriggerInteraction
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x16C0AA8", Offset = "0x16C0AA8", VA = "0x16C0AA8")]
		get
		{
			return default(QueryTriggerInteraction);
		}
	}

	[Token(Token = "0x17000019")]
	private float raycastMaxDistance
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x16C0ABC", Offset = "0x16C0ABC", VA = "0x16C0ABC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x16C0204", Offset = "0x16C0204", VA = "0x16C0204")]
	public bool IsColliderHiddenByDynamicOccluder(Collider collider)
	{
		return default(bool);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x16C035C", Offset = "0x16C035C", VA = "0x16C035C")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x16C0408", Offset = "0x16C0408", VA = "0x16C0408")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x16C0460", Offset = "0x16C0460", VA = "0x16C0460")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x16C04A8", Offset = "0x16C04A8", VA = "0x16C04A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x16C0588", Offset = "0x16C0588", VA = "0x16C0588")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x16C09AC", Offset = "0x16C09AC", VA = "0x16C09AC")]
	private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x16C0B04", Offset = "0x16C0B04", VA = "0x16C0B04")]
	private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x16C0B18", Offset = "0x16C0B18", VA = "0x16C0B18")]
	private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x16C0D48", Offset = "0x16C0D48", VA = "0x16C0D48")]
	private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x16C12A4", Offset = "0x16C12A4", VA = "0x16C12A4")]
	private Vector3 GetDirection(uint dirInt)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x16C14A4", Offset = "0x16C14A4", VA = "0x16C14A4")]
	private bool IsHitValid(HitResult hit)
	{
		return default(bool);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x16C05C8", Offset = "0x16C05C8", VA = "0x16C05C8")]
	private void ProcessRaycasts()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x16C1664", Offset = "0x16C1664", VA = "0x16C1664")]
	private void SetHit(HitResult hit)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x16C0484", Offset = "0x16C0484", VA = "0x16C0484")]
	private void SetHitNull()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x16C1774", Offset = "0x16C1774", VA = "0x16C1774")]
	private void SetClippingPlane(Plane planeWS)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x16C188C", Offset = "0x16C188C", VA = "0x16C188C")]
	private void SetClippingPlaneOff()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x16C19D0", Offset = "0x16C19D0", VA = "0x16C19D0")]
	private void SetPlaneWS(Plane planeWS)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x16C1A7C", Offset = "0x16C1A7C", VA = "0x16C1A7C")]
	public DynamicOcclusion()
	{
	}
}
[Token(Token = "0x200000A")]
public enum ColorMode
{
	[Token(Token = "0x4000043")]
	Flat,
	[Token(Token = "0x4000044")]
	Gradient
}
[Token(Token = "0x200000B")]
public enum AttenuationEquation
{
	[Token(Token = "0x4000046")]
	Linear,
	[Token(Token = "0x4000047")]
	Quadratic,
	[Token(Token = "0x4000048")]
	Blend
}
[Token(Token = "0x200000C")]
public enum BlendingMode
{
	[Token(Token = "0x400004A")]
	Additive,
	[Token(Token = "0x400004B")]
	SoftAdditive,
	[Token(Token = "0x400004C")]
	TraditionalTransparency
}
[Token(Token = "0x200000D")]
public enum NoiseMode
{
	[Token(Token = "0x400004E")]
	Disabled,
	[Token(Token = "0x400004F")]
	WorldSpace,
	[Token(Token = "0x4000050")]
	LocalSpace
}
[Token(Token = "0x200000E")]
public enum MeshType
{
	[Token(Token = "0x4000052")]
	Shared,
	[Token(Token = "0x4000053")]
	Custom
}
[Token(Token = "0x200000F")]
public enum RenderPipeline
{
	[Token(Token = "0x4000055")]
	BuiltIn,
	[Token(Token = "0x4000056")]
	SRP_4_0_0_or_higher
}
[Token(Token = "0x2000010")]
public enum RenderingMode
{
	[Token(Token = "0x4000058")]
	MultiPass,
	[Token(Token = "0x4000059")]
	SinglePass,
	[Token(Token = "0x400005A")]
	GPUInstancing
}
[Token(Token = "0x2000011")]
public enum OccluderDimensions
{
	[Token(Token = "0x400005C")]
	Occluders3D,
	[Token(Token = "0x400005D")]
	Occluders2D
}
[Token(Token = "0x2000012")]
public enum PlaneAlignment
{
	[Token(Token = "0x400005F")]
	Surface,
	[Token(Token = "0x4000060")]
	Beam
}
[Token(Token = "0x2000013")]
public static class GlobalMesh
{
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x0")]
	private static Mesh ms_Mesh;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x8")]
	private static bool ms_DoubleSided;

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x16BD500", Offset = "0x16BD500", VA = "0x16BD500")]
	public static Mesh Get()
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x16C1B1C", Offset = "0x16C1B1C", VA = "0x16C1B1C")]
	public static void Destroy()
	{
	}
}
[Token(Token = "0x2000014")]
public static class GpuInstancing
{
	[Token(Token = "0x1700001B")]
	public static bool forceEnableDepthBlend
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x16BE168", Offset = "0x16BE168", VA = "0x16BE168")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x16C1BE4", Offset = "0x16C1BE4", VA = "0x16C1BE4")]
	public static void SetMaterialProperties(Material material, bool enableInstancing)
	{
	}
}
[Token(Token = "0x2000015")]
public sealed class HighlightNullAttribute : PropertyAttribute
{
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x16C1C60", Offset = "0x16C1C60", VA = "0x16C1C60")]
	public HighlightNullAttribute()
	{
	}
}
[Token(Token = "0x2000016")]
public static class MaterialManager
{
	[Token(Token = "0x2000017")]
	public enum BlendingMode
	{
		[Token(Token = "0x400006A")]
		Additive,
		[Token(Token = "0x400006B")]
		SoftAdditive,
		[Token(Token = "0x400006C")]
		TraditionalTransparency,
		[Token(Token = "0x400006D")]
		Count
	}

	[Token(Token = "0x2000018")]
	public enum Noise3D
	{
		[Token(Token = "0x400006F")]
		Off,
		[Token(Token = "0x4000070")]
		On,
		[Token(Token = "0x4000071")]
		Count
	}

	[Token(Token = "0x2000019")]
	public enum DepthBlend
	{
		[Token(Token = "0x4000073")]
		Off,
		[Token(Token = "0x4000074")]
		On,
		[Token(Token = "0x4000075")]
		Count
	}

	[Token(Token = "0x200001A")]
	public enum ColorGradient
	{
		[Token(Token = "0x4000077")]
		Off,
		[Token(Token = "0x4000078")]
		MatrixLow,
		[Token(Token = "0x4000079")]
		MatrixHigh,
		[Token(Token = "0x400007A")]
		Count
	}

	[Token(Token = "0x200001B")]
	public enum ClippingPlane
	{
		[Token(Token = "0x400007C")]
		Off,
		[Token(Token = "0x400007D")]
		On,
		[Token(Token = "0x400007E")]
		Count
	}

	[Token(Token = "0x200001C")]
	public class StaticProperties
	{
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x10")]
		public BlendingMode blendingMode;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x14")]
		public Noise3D noise3D;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x18")]
		public DepthBlend depthBlend;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x1C")]
		public ColorGradient colorGradient;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x20")]
		public ClippingPlane clippingPlane;

		[Token(Token = "0x1700001C")]
		public int materialID
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x16C1CF0", Offset = "0x16C1CF0", VA = "0x16C1CF0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x16BE268", Offset = "0x16BE268", VA = "0x16BE268")]
		public void ApplyToMaterial(Material mat)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x16BE260", Offset = "0x16BE260", VA = "0x16BE260")]
		public StaticProperties()
		{
		}
	}

	[Token(Token = "0x200001D")]
	private class MaterialsGroup
	{
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x10")]
		public Material[] materials;

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x16C1C68", Offset = "0x16C1C68", VA = "0x16C1C68")]
		public MaterialsGroup()
		{
		}
	}

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x0")]
	public static MaterialPropertyBlock materialPropertyBlock;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x8")]
	private static readonly BlendMode[] BlendingMode_SrcFactor;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x10")]
	private static readonly BlendMode[] BlendingMode_DstFactor;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x18")]
	private static readonly bool[] BlendingMode_AlphaAsBlack;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x20")]
	private static int kStaticPropertiesCount;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x28")]
	private static Hashtable ms_MaterialsGroup;

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x16BC40C", Offset = "0x16BC40C", VA = "0x16BC40C")]
	public static Material NewMaterial(bool gpuInstanced)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x16BE460", Offset = "0x16BE460", VA = "0x16BE460")]
	public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
	{
		return null;
	}
}
[Token(Token = "0x200001E")]
public static class MeshGenerator
{
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x16C1E78", Offset = "0x16C1E78", VA = "0x16C1E78")]
	private static float GetAngleOffset(int numSides)
	{
		return default(float);
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x16BCB24", Offset = "0x16BCB24", VA = "0x16BCB24")]
	public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
	{
		return null;
	}
}
[Token(Token = "0x200001F")]
public static class Noise3D
{
	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x0")]
	private static bool ms_IsSupportedChecked;

	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x1")]
	private static bool ms_IsSupported;

	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x8")]
	private static Texture3D ms_NoiseTexture;

	[Token(Token = "0x4000088")]
	private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

	[Token(Token = "0x4000089")]
	private const int kMinShaderLevel = 35;

	[Token(Token = "0x1700001D")]
	public static bool isSupported
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x16BDF04", Offset = "0x16BDF04", VA = "0x16BDF04")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001E")]
	public static bool isProperlyLoaded
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x16C1F30", Offset = "0x16C1F30", VA = "0x16C1F30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001F")]
	public static string isNotSupportedString
	{
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x16C1E90", Offset = "0x16C1E90", VA = "0x16C1E90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x16C1FC8", Offset = "0x16C1FC8", VA = "0x16C1FC8")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x87FB64", Offset = "0x87FB64")]
	private static void OnStartUp()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x16BEDBC", Offset = "0x16BEDBC", VA = "0x16BEDBC")]
	public static void LoadIfNeeded()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x16C2024", Offset = "0x16C2024", VA = "0x16C2024")]
	private static Texture3D LoadTexture3D(TextAsset textData, int size)
	{
		return null;
	}
}
[Token(Token = "0x2000020")]
public static class ShaderProperties
{
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int FadeOutFactor;

	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x4")]
	public static readonly int ClippingPlaneWS;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x8")]
	public static readonly int ClippingPlaneProps;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0xC")]
	public static readonly int ConeSlopeCosSin;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x10")]
	public static readonly int ConeRadius;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x14")]
	public static readonly int ConeApexOffsetZ;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x18")]
	public static readonly int ColorFlat;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x1C")]
	public static readonly int AlphaInside;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x20")]
	public static readonly int AlphaOutside;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x24")]
	public static readonly int AttenuationLerpLinearQuad;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x28")]
	public static readonly int DistanceFadeStart;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x2C")]
	public static readonly int DistanceFadeEnd;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x30")]
	public static readonly int DistanceCamClipping;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x34")]
	public static readonly int FresnelPow;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x38")]
	public static readonly int GlareBehind;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x3C")]
	public static readonly int GlareFrontal;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x40")]
	public static readonly int DrawCap;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x44")]
	public static readonly int DepthBlendDistance;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x48")]
	public static readonly int NoiseLocal;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x4C")]
	public static readonly int NoiseParam;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x50")]
	public static readonly int CameraParams;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x54")]
	public static readonly int CameraBufferSizeSRP;

	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x58")]
	public static readonly int ColorGradientMatrix;

	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x5C")]
	public static readonly int LocalToWorldMatrix;

	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x60")]
	public static readonly int WorldToLocalMatrix;

	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x64")]
	public static readonly int BlendSrcFactor;

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x68")]
	public static readonly int BlendDstFactor;
}
[Token(Token = "0x2000021")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87F134", Offset = "0x87F134")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x87F134", Offset = "0x87F134")]
public class TriggerZone : MonoBehaviour
{
	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x18")]
	public bool setIsTrigger;

	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x1C")]
	public float rangeMultiplier;

	[Token(Token = "0x40000A7")]
	private const int kMeshColliderNumSides = 8;

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x20")]
	private Mesh m_Mesh;

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x16C2710", Offset = "0x16C2710", VA = "0x16C2710")]
	private void Update()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x16C2900", Offset = "0x16C2900", VA = "0x16C2900")]
	public TriggerZone()
	{
	}
}
[Token(Token = "0x2000022")]
public static class Utils
{
	[Token(Token = "0x2000023")]
	public enum FloatPackingPrecision
	{
		[Token(Token = "0x40000AB")]
		High = 64,
		[Token(Token = "0x40000AC")]
		Low = 8,
		[Token(Token = "0x40000AD")]
		Undef = 0
	}

	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x0")]
	private static FloatPackingPrecision ms_FloatPackingPrecision;

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x16C2918", Offset = "0x16C2918", VA = "0x16C2918")]
	public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
	{
		return default(float);
	}

	[Token(Token = "0x6000080")]
	public static void Swap<T>(ref T a, ref T b)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x16BC75C", Offset = "0x16BC75C", VA = "0x16BC75C")]
	public static string GetPath(Transform current)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	public static T NewWithComponent<T>(string name) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	public static T GetOrAddComponent<T>(this GameObject self) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x16C29A0", Offset = "0x16C29A0", VA = "0x16C29A0")]
	public static Vector2 xy(this Vector3 aVector)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x16C0FCC", Offset = "0x16C0FCC", VA = "0x16C0FCC")]
	public static float GetMaxArea2D(this Bounds self)
	{
		return default(float);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x16C18B0", Offset = "0x16C18B0", VA = "0x16C18B0")]
	public static Plane TranslateCustom(this Plane plane, Vector3 translation)
	{
		return default(Plane);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x16C02E8", Offset = "0x16C02E8", VA = "0x16C02E8")]
	public static bool IsValid(this Plane plane)
	{
		return default(bool);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x16BF0E0", Offset = "0x16BF0E0", VA = "0x16BF0E0")]
	public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x16BF9F8", Offset = "0x16BF9F8", VA = "0x16BF9F8")]
	public static void SetShaderKeywordEnabled(string name, bool enabled)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x16BEC9C", Offset = "0x16BEC9C", VA = "0x16BEC9C")]
	public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x16C2A34", Offset = "0x16C2A34", VA = "0x16C2A34")]
	private static Vector4 Vector4_Floor(Vector4 vec)
	{
		return default(Vector4);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x16C29CC", Offset = "0x16C29CC", VA = "0x16C29CC")]
	public static float PackToFloat(this Color color, int floatPackingPrecision)
	{
		return default(float);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x16BE1DC", Offset = "0x16BE1DC", VA = "0x16BE1DC")]
	public static FloatPackingPrecision GetFloatPackingPrecision()
	{
		return default(FloatPackingPrecision);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x16C2AE0", Offset = "0x16C2AE0", VA = "0x16C2AE0")]
	public static void MarkCurrentSceneDirty()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x16BFE88", Offset = "0x16BFE88", VA = "0x16BFE88")]
	public static void MarkObjectDirty(UnityEngine.Object obj)
	{
	}
}
[Token(Token = "0x2000024")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x87F1DC", Offset = "0x87F1DC")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87F1DC", Offset = "0x87F1DC")]
public class VolumetricDustParticles : MonoBehaviour
{
	[Token(Token = "0x2000025")]
	public enum Direction
	{
		[Token(Token = "0x40000BF")]
		Beam,
		[Token(Token = "0x40000C0")]
		Random
	}

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F4D4", Offset = "0x87F4D4")]
	public float alpha;

	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F4EC", Offset = "0x87F4EC")]
	public float size;

	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x20")]
	public Direction direction;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x24")]
	public float speed;

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x28")]
	public float density;

	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F50C", Offset = "0x87F50C")]
	public float spawnMinDistance;

	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F524", Offset = "0x87F524")]
	public float spawnMaxDistance;

	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x34")]
	public bool cullingEnabled;

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x38")]
	public float cullingMaxDistance;

	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F53C", Offset = "0x87F53C")]
	private bool <isCulled>k__BackingField;

	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x0")]
	public static bool isFeatureSupported;

	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x40")]
	private ParticleSystem m_Particles;

	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x48")]
	private ParticleSystemRenderer m_Renderer;

	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x1")]
	private static bool ms_NoMainCameraLogged;

	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x8")]
	private static Camera ms_MainCamera;

	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x50")]
	private VolumetricLightBeam m_Master;

	[Token(Token = "0x17000020")]
	public bool isCulled
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x16C2AE4", Offset = "0x16C2AE4", VA = "0x16C2AE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FBF4", Offset = "0x87FBF4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x16C2AEC", Offset = "0x16C2AEC", VA = "0x16C2AEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FC04", Offset = "0x87FC04")]
		private set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public bool particlesAreInstantiated
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x16C2AF8", Offset = "0x16C2AF8", VA = "0x16C2AF8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000022")]
	public int particlesCurrentCount
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x16C2B64", Offset = "0x16C2B64", VA = "0x16C2B64")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000023")]
	public int particlesMaxCount
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x16C2BF8", Offset = "0x16C2BF8", VA = "0x16C2BF8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000024")]
	public Camera mainCamera
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x16C2CA4", Offset = "0x16C2CA4", VA = "0x16C2CA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x16C2EFC", Offset = "0x16C2EFC", VA = "0x16C2EFC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x16C2F64", Offset = "0x16C2F64", VA = "0x16C2F64")]
	private void InstantiateParticleSystem()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x16C31D0", Offset = "0x16C31D0", VA = "0x16C31D0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x16C3114", Offset = "0x16C3114", VA = "0x16C3114")]
	private void SetActiveAndPlay()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x16C3838", Offset = "0x16C3838", VA = "0x16C3838")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x16C38D8", Offset = "0x16C38D8", VA = "0x16C38D8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x16C3998", Offset = "0x16C3998", VA = "0x16C3998")]
	private void Update()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x16C31D4", Offset = "0x16C31D4", VA = "0x16C31D4")]
	private void SetParticleProperties()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x16C39CC", Offset = "0x16C39CC", VA = "0x16C39CC")]
	private void UpdateCulling()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x16C3DA4", Offset = "0x16C3DA4", VA = "0x16C3DA4")]
	public VolumetricDustParticles()
	{
	}
}
[Token(Token = "0x2000026")]
[SelectionBase]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x87F284", Offset = "0x87F284")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class VolumetricLightBeam : MonoBehaviour
{
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F2F0", Offset = "0x87F2F0")]
	private sealed class <CoPlaytimeUpdate>d__133 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x20")]
		public VolumetricLightBeam <>4__this;

		[Token(Token = "0x17000044")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x16C541C", Offset = "0x16C541C", VA = "0x16C541C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x16C5484", Offset = "0x16C5484", VA = "0x16C5484", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x16C4EA4", Offset = "0x16C4EA4", VA = "0x16C4EA4")]
		[DebuggerHidden]
		public <CoPlaytimeUpdate>d__133(int <>1__state)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x16C5394", Offset = "0x16C5394", VA = "0x16C5394", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x16C5398", Offset = "0x16C5398", VA = "0x16C5398", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x16C5424", Offset = "0x16C5424", VA = "0x16C5424", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x18")]
	public bool colorFromLight;

	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x1C")]
	public ColorMode colorMode;

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x87F54C", Offset = "0x87F54C")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x87F54C", Offset = "0x87F54C")]
	public Color color;

	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x30")]
	public Gradient colorGradient;

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x38")]
	public bool intensityFromLight;

	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x39")]
	public bool intensityModeAdvanced;

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F5A0", Offset = "0x87F5A0")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x87F5A0", Offset = "0x87F5A0")]
	public float intensityInside;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F5F4", Offset = "0x87F5F4")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x87F5F4", Offset = "0x87F5F4")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x87F5F4", Offset = "0x87F5F4")]
	public float intensityOutside;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x44")]
	public BlendingMode blendingMode;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x87F66C", Offset = "0x87F66C")]
	public bool spotAngleFromLight;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F6A4", Offset = "0x87F6A4")]
	public float spotAngle;

	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x87F6C4", Offset = "0x87F6C4")]
	public float coneRadiusStart;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x54")]
	public MeshType geomMeshType;

	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x87F6FC", Offset = "0x87F6FC")]
	public int geomCustomSides;

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x5C")]
	public int geomCustomSegments;

	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x60")]
	public bool geomCap;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x61")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x87F734", Offset = "0x87F734")]
	public bool fallOffEndFromLight;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x64")]
	public AttenuationEquation attenuationEquation;

	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F76C", Offset = "0x87F76C")]
	public float attenuationCustomBlending;

	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x87F784", Offset = "0x87F784")]
	public float fallOffStart;

	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x87F7BC", Offset = "0x87F7BC")]
	public float fallOffEnd;

	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x74")]
	public float depthBlendDistance;

	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x78")]
	public float cameraClippingDistance;

	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x7C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F7F4", Offset = "0x87F7F4")]
	public float glareFrontal;

	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F80C", Offset = "0x87F80C")]
	public float glareBehind;

	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x87F824", Offset = "0x87F824")]
	public float fresnelPow;

	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x88")]
	public NoiseMode noiseMode;

	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x87F85C", Offset = "0x87F85C")]
	private bool _DEPRECATED_NoiseEnabled;

	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F8A8", Offset = "0x87F8A8")]
	public float noiseIntensity;

	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x94")]
	public bool noiseScaleUseGlobal;

	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87F8C0", Offset = "0x87F8C0")]
	public float noiseScaleLocal;

	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x9C")]
	public bool noiseVelocityUseGlobal;

	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0xA0")]
	public Vector3 noiseVelocityLocal;

	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0xAC")]
	[SerializeField]
	private int pluginVersion;

	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x87F8EC", Offset = "0x87F8EC")]
	private bool _TrackChangesDuringPlaytime;

	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	private int _SortingLayerID;

	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private int _SortingOrder;

	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0xBC")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x87F958", Offset = "0x87F958")]
	private float _FadeOutBegin;

	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x87F9A4", Offset = "0x87F9A4")]
	[SerializeField]
	private float _FadeOutEnd;

	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0xC4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87F9F0", Offset = "0x87F9F0")]
	private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField;

	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0xC8")]
	private BeamGeometry m_BeamGeom;

	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0xD0")]
	private Coroutine m_CoPlaytimeUpdate;

	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0xD8")]
	private Light _CachedLight;

	[Token(Token = "0x17000025")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87FD20", Offset = "0x87FD20")]
	public float alphaInside
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x16C3E50", Offset = "0x16C3E50", VA = "0x16C3E50")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x16C3E58", Offset = "0x16C3E58", VA = "0x16C3E58")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87FD58", Offset = "0x87FD58")]
	public float alphaOutside
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x16C3E60", Offset = "0x16C3E60", VA = "0x16C3E60")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x16C3E68", Offset = "0x16C3E68", VA = "0x16C3E68")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public float intensityGlobal
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x16C3E70", Offset = "0x16C3E70", VA = "0x16C3E70")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x16C3E78", Offset = "0x16C3E78", VA = "0x16C3E78")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public float coneAngle
	{
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x16BEB9C", Offset = "0x16BEB9C", VA = "0x16BEB9C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000029")]
	public float coneRadiusEnd
	{
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x16BDE58", Offset = "0x16BDE58", VA = "0x16BDE58")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700002A")]
	public float coneVolume
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x16C3E80", Offset = "0x16C3E80", VA = "0x16C3E80")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700002B")]
	public float coneApexOffsetZ
	{
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x16BEC40", Offset = "0x16BEC40", VA = "0x16BEC40")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700002C")]
	public int geomSides
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x16C3ED8", Offset = "0x16C3ED8", VA = "0x16C3ED8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x16C3F60", Offset = "0x16C3F60", VA = "0x16C3F60")]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public int geomSegments
	{
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x16C3FE0", Offset = "0x16C3FE0", VA = "0x16C3FE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x16C4068", Offset = "0x16C4068", VA = "0x16C4068")]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87FD90", Offset = "0x87FD90")]
	public bool fadeEndFromLight
	{
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x16C40E8", Offset = "0x16C40E8", VA = "0x16C40E8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x16C40F0", Offset = "0x16C40F0", VA = "0x16C40F0")]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	public float attenuationLerpLinearQuad
	{
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x16BED94", Offset = "0x16BED94", VA = "0x16BED94")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000030")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87FDC8", Offset = "0x87FDC8")]
	public float fadeStart
	{
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x16C40FC", Offset = "0x16C40FC", VA = "0x16C40FC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x16C4104", Offset = "0x16C4104", VA = "0x16C4104")]
		set
		{
		}
	}

	[Token(Token = "0x17000031")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87FE00", Offset = "0x87FE00")]
	public float fadeEnd
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x16C410C", Offset = "0x16C410C", VA = "0x16C410C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x16C4114", Offset = "0x16C4114", VA = "0x16C4114")]
		set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public bool isNoiseEnabled
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x16BDEF4", Offset = "0x16BDEF4", VA = "0x16BDEF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000033")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87FE38", Offset = "0x87FE38")]
	public bool noiseEnabled
	{
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x16C411C", Offset = "0x16C411C", VA = "0x16C411C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x16C412C", Offset = "0x16C412C", VA = "0x16C412C")]
		set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public float fadeOutBegin
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x16C4148", Offset = "0x16C4148", VA = "0x16C4148")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x16C4150", Offset = "0x16C4150", VA = "0x16C4150")]
		set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public float fadeOutEnd
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x16C41AC", Offset = "0x16C41AC", VA = "0x16C41AC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x16C41B4", Offset = "0x16C41B4", VA = "0x16C41B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public bool isFadeOutEnabled
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x16BB678", Offset = "0x16BB678", VA = "0x16BB678")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000037")]
	public int sortingLayerID
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x16C41BC", Offset = "0x16C41BC", VA = "0x16C41BC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x16C41C4", Offset = "0x16C41C4", VA = "0x16C41C4")]
		set
		{
		}
	}

	[Token(Token = "0x17000038")]
	public string sortingLayerName
	{
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x16C4274", Offset = "0x16C4274", VA = "0x16C4274")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x16C4280", Offset = "0x16C4280", VA = "0x16C4280")]
		set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public int sortingOrder
	{
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x16C42B0", Offset = "0x16C42B0", VA = "0x16C42B0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x16C42B8", Offset = "0x16C42B8", VA = "0x16C42B8")]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public bool trackChangesDuringPlaytime
	{
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x16C4368", Offset = "0x16C4368", VA = "0x16C4368")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x16C4370", Offset = "0x16C4370", VA = "0x16C4370")]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	public bool isCurrentlyTrackingChanges
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x16C43D0", Offset = "0x16C43D0", VA = "0x16C43D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003C")]
	public bool hasGeometry
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x16C3C08", Offset = "0x16C3C08", VA = "0x16C3C08")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003D")]
	public Bounds bounds
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x16C3C78", Offset = "0x16C3C78", VA = "0x16C3C78")]
		get
		{
			return default(Bounds);
		}
	}

	[Token(Token = "0x1700003E")]
	public int blendingModeAsInt
	{
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x16C43E0", Offset = "0x16C43E0", VA = "0x16C43E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003F")]
	public uint _INTERNAL_InstancedMaterialGroupID
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x16C457C", Offset = "0x16C457C", VA = "0x16C457C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FC14", Offset = "0x87FC14")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x16C4584", Offset = "0x16C4584", VA = "0x16C4584")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87FC24", Offset = "0x87FC24")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000040")]
	public string meshStats
	{
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x16C458C", Offset = "0x16C458C", VA = "0x16C458C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000041")]
	public int meshVerticesCount
	{
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x16C4714", Offset = "0x16C4714", VA = "0x16C4714")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000042")]
	public int meshTrianglesCount
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x16C47F0", Offset = "0x16C47F0", VA = "0x16C47F0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000043")]
	private Light lightSpotAttached
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x16C48E4", Offset = "0x16C48E4", VA = "0x16C48E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x16C19DC", Offset = "0x16C19DC", VA = "0x16C19DC")]
	public void SetDynamicOcclusion(DynamicOcclusion dynamicOcclusion)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x16C4158", Offset = "0x16C4158", VA = "0x16C4158")]
	private void SetFadeOutValue(ref float propToChange, float value)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x16C44D8", Offset = "0x16C44D8", VA = "0x16C44D8")]
	private void OnFadeOutStateChanged()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x16C49DC", Offset = "0x16C49DC", VA = "0x16C49DC")]
	public float GetInsideBeamFactor(Vector3 posWS)
	{
		return default(float);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x16BF534", Offset = "0x16BF534", VA = "0x16BF534")]
	public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
	{
		return default(float);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x16C4A3C", Offset = "0x16C4A3C", VA = "0x16C4A3C")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87FC34", Offset = "0x87FC34")]
	public void Generate()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x16C4A48", Offset = "0x16C4A48", VA = "0x16C4A48", Slot = "4")]
	public virtual void GenerateGeometry()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x16C4C64", Offset = "0x16C4C64", VA = "0x16C4C64", Slot = "5")]
	public virtual void UpdateAfterManualPropertyChange()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x16C4CF8", Offset = "0x16C4CF8", VA = "0x16C4CF8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x16C4D04", Offset = "0x16C4D04", VA = "0x16C4D04")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x16C4D9C", Offset = "0x16C4D9C", VA = "0x16C4D9C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x16C437C", Offset = "0x16C437C", VA = "0x16C437C")]
	private void StartPlaytimeUpdateIfNeeded()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x16C4E34", Offset = "0x16C4E34", VA = "0x16C4E34")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x87FC6C", Offset = "0x87FC6C")]
	private IEnumerator CoPlaytimeUpdate()
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x16C4ED0", Offset = "0x16C4ED0", VA = "0x16C4ED0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x16C4ED4", Offset = "0x16C4ED4", VA = "0x16C4ED4")]
	private void DestroyBeam()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x16C4F94", Offset = "0x16C4F94", VA = "0x16C4F94")]
	private void AssignPropertiesFromSpotLight(Light lightSpot)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x16C5094", Offset = "0x16C5094", VA = "0x16C5094")]
	private void ClampProperties()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x16C4C34", Offset = "0x16C4C34", VA = "0x16C4C34")]
	private void ValidateProperties()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x16C4B44", Offset = "0x16C4B44", VA = "0x16C4B44")]
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x16C5280", Offset = "0x16C5280", VA = "0x16C5280")]
	public VolumetricLightBeam()
	{
	}
}
