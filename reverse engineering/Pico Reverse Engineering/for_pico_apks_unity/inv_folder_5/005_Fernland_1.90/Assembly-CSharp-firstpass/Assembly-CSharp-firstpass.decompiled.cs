using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace VLB
{
	[Token(Token = "0x2000002")]
	public static class BatchingHelper
	{
		[Token(Token = "0x4000001")]
		public const bool isGpuInstancingSupported = true;

		[Token(Token = "0x17000001")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x1127CE0", Offset = "0x1127CE0", VA = "0x1127CE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1127E84", Offset = "0x1127E84", VA = "0x1127E84")]
		public static bool IsGpuInstancingEnabled(Material material)
		{
			return default(bool);
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1127EAC", Offset = "0x1127EAC", VA = "0x1127EAC")]
		public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1127EDC", Offset = "0x1127EDC", VA = "0x1127EDC")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x11285C4", Offset = "0x11285C4", VA = "0x11285C4")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x11287A4", Offset = "0x11287A4", VA = "0x11287A4")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x30370C", Offset = "0x30370C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x30370C", Offset = "0x30370C")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
	{
		[Token(Token = "0x2000037")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x303D40", Offset = "0x303D40")]
		private sealed class <CoUpdateFadeOut>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000140")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x4000141")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x4000142")]
			[FieldOffset(Offset = "0x10")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x1700005D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000181")]
				[Address(RVA = "0x112F718", Offset = "0x112F718", VA = "0x112F718", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000183")]
				[Address(RVA = "0x112F798", Offset = "0x112F798", VA = "0x112F798", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600017E")]
			[Address(RVA = "0x1128C88", Offset = "0x1128C88", VA = "0x1128C88")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x600017F")]
			[Address(RVA = "0x112F67C", Offset = "0x112F67C", VA = "0x112F67C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000180")]
			[Address(RVA = "0x112F680", Offset = "0x112F680", VA = "0x112F680", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000182")]
			[Address(RVA = "0x112F720", Offset = "0x112F720", VA = "0x112F720", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0xC")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x50")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x54")]
		private Material m_CustomMaterial;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x58")]
		private MaterialModifier.Callback m_MaterialModifierCallback;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x5C")]
		private Coroutine m_CoFadeOut;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x303DC0", Offset = "0x303DC0")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x303DD0", Offset = "0x303DD0")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x303DE0", Offset = "0x303DE0")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x6C")]
		private Camera m_CurrentCameraRenderingSRP;

		[Token(Token = "0x17000002")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x1128864", Offset = "0x1128864", VA = "0x1128864")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30469C", Offset = "0x30469C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x112886C", Offset = "0x112886C", VA = "0x112886C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3046AC", Offset = "0x3046AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x1128874", Offset = "0x1128874", VA = "0x1128874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3046BC", Offset = "0x3046BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x112887C", Offset = "0x112887C", VA = "0x112887C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3046CC", Offset = "0x3046CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public Mesh coneMesh
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x1128884", Offset = "0x1128884", VA = "0x1128884")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3046DC", Offset = "0x3046DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x112888C", Offset = "0x112888C", VA = "0x112888C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3046EC", Offset = "0x3046EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public bool visible
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x1128894", Offset = "0x1128894", VA = "0x1128894")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x11288BC", Offset = "0x11288BC", VA = "0x11288BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public int sortingLayerID
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x11288EC", Offset = "0x11288EC", VA = "0x11288EC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x1128914", Offset = "0x1128914", VA = "0x1128914")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public int sortingOrder
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x1128944", Offset = "0x1128944", VA = "0x1128944")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x112896C", Offset = "0x112896C", VA = "0x112896C")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x112899C", Offset = "0x112899C", VA = "0x112899C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x11295E8", Offset = "0x11295E8", VA = "0x11295E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		private bool shouldUseGPUInstancedMaterial
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x11295F0", Offset = "0x11295F0", VA = "0x11295F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x112C9C0", Offset = "0x112C9C0", VA = "0x112C9C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x112CC08", Offset = "0x112CC08", VA = "0x112CC08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x11289AC", Offset = "0x11289AC", VA = "0x11289AC")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1128C08", Offset = "0x1128C08", VA = "0x1128C08")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3046FC", Offset = "0x3046FC")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1128CA8", Offset = "0x1128CA8", VA = "0x1128CA8")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1128E34", Offset = "0x1128E34", VA = "0x1128E34")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x11291F4", Offset = "0x11291F4", VA = "0x11291F4")]
		public void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x11292E8", Offset = "0x11292E8", VA = "0x11292E8")]
		private void Start()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x11293B0", Offset = "0x11293B0", VA = "0x11293B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1129470", Offset = "0x1129470", VA = "0x1129470")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1129744", Offset = "0x1129744", VA = "0x1129744")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x11298C8", Offset = "0x11298C8", VA = "0x11298C8")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x112A318", Offset = "0x112A318", VA = "0x112A318")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x112C588", Offset = "0x112C588", VA = "0x112C588")]
		private Vector3 ComputeLocalMatrix()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1129F10", Offset = "0x1129F10", VA = "0x1129F10")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1129000", Offset = "0x1129000", VA = "0x1129000", Slot = "4")]
		public void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x112D4E0", Offset = "0x112D4E0", VA = "0x112D4E0", Slot = "5")]
		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x112D628", Offset = "0x112D628", VA = "0x112D628", Slot = "6")]
		public void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x112D770", Offset = "0x112D770", VA = "0x112D770", Slot = "7")]
		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x112D978", Offset = "0x112D978", VA = "0x112D978", Slot = "8")]
		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1128F1C", Offset = "0x1128F1C", VA = "0x1128F1C")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1129110", Offset = "0x1129110", VA = "0x1129110")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x112DA74", Offset = "0x112DA74", VA = "0x112DA74")]
		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x112B78C", Offset = "0x112B78C", VA = "0x112B78C")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x112E99C", Offset = "0x112E99C", VA = "0x112E99C")]
		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x112ED4C", Offset = "0x112ED4C", VA = "0x112ED4C")]
		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x112ED54", Offset = "0x112ED54", VA = "0x112ED54")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x112EDEC", Offset = "0x112EDEC", VA = "0x112EDEC")]
		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x112EF00", Offset = "0x112EF00", VA = "0x112EF00")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x112F674", Offset = "0x112F674", VA = "0x112F674")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x30377C", Offset = "0x30377C")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x400000C")]
		public const string ClassName = "Config";

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0xC")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x10")]
		public int geometryLayerID;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x14")]
		public string geometryTag;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x18")]
		public int geometryRenderQueue;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x303DF0", Offset = "0x303DF0")]
		[SerializeField]
		private RenderPipeline _RenderPipeline;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x303E38", Offset = "0x303E38")]
		[SerializeField]
		private RenderingMode _RenderingMode;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x24")]
		public float ditheringFactor;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x28")]
		public int sharedMeshSides;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x2C")]
		public int sharedMeshSegments;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x303E80", Offset = "0x303E80")]
		public float globalNoiseScale;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x40")]
		public string fadeOutCameraTag;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x44")]
		[HighlightNull]
		public Texture3D noiseTexture3D;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x48")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x4C")]
		public Texture2D ditheringNoiseTexture;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x50")]
		public FeatureEnabledColorGradient featureEnabledColorGradient;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x54")]
		public bool featureEnabledDepthBlend;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x55")]
		public bool featureEnabledNoise3D;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x56")]
		public bool featureEnabledDynamicOcclusion;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x57")]
		public bool featureEnabledMeshSkewing;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x58")]
		public bool featureEnabledShaderAccuracyHigh;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Material _DummyMaterial;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Shader _BeamShader;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x68")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x0")]
		private static Config ms_Instance;

		[Token(Token = "0x1700000D")]
		public RenderPipeline renderPipeline
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x112F7A0", Offset = "0x112F7A0", VA = "0x112F7A0")]
			get
			{
				return default(RenderPipeline);
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x112F7A8", Offset = "0x112F7A8", VA = "0x112F7A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public RenderingMode renderingMode
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x112F82C", Offset = "0x112F82C", VA = "0x112F82C")]
			get
			{
				return default(RenderingMode);
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x112F834", Offset = "0x112F834", VA = "0x112F834")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x1127E34", Offset = "0x1127E34", VA = "0x1127E34")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000010")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x112FA34", Offset = "0x112FA34", VA = "0x112FA34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000011")]
		public bool requiresDoubleSidedMesh
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x112A758", Offset = "0x112A758", VA = "0x112A758")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000012")]
		public Shader beamShader
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x112FA4C", Offset = "0x112FA4C", VA = "0x112FA4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x1128DA0", Offset = "0x1128DA0", VA = "0x1128DA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public bool hasRenderPipelineMismatch
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x112FB04", Offset = "0x112FB04", VA = "0x112FB04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public static Config Instance
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x1127DC0", Offset = "0x1127DC0", VA = "0x1127DC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x112F8B8", Offset = "0x112F8B8", VA = "0x112F8B8")]
		public bool IsSRPBatcherSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x112FA54", Offset = "0x112FA54", VA = "0x112FA54")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x112FB94", Offset = "0x112FB94", VA = "0x112FB94")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x30476C", Offset = "0x30476C")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x112FDC4", Offset = "0x112FDC4", VA = "0x112FDC4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x112FCCC", Offset = "0x112FCCC", VA = "0x112FCCC")]
		private void RefreshGlobalShaderProperties()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x112FED0", Offset = "0x112FED0", VA = "0x112FED0")]
		public void ResetInternalData()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1130054", Offset = "0x1130054", VA = "0x1130054")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1130288", Offset = "0x1130288", VA = "0x1130288")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1130294", Offset = "0x1130294", VA = "0x1130294")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1130298", Offset = "0x1130298", VA = "0x1130298")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x113048C", Offset = "0x113048C", VA = "0x113048C")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3037B0", Offset = "0x3037B0")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x4000027")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x113059C", Offset = "0x113059C", VA = "0x113059C")]
		public ConfigOverride()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public static class Consts
	{
		[Token(Token = "0x2000038")]
		public static class Help
		{
			[Token(Token = "0x4000143")]
			private const string UrlBase = "http://saladgamer.com/vlb-doc/";

			[Token(Token = "0x4000144")]
			public const string UrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

			[Token(Token = "0x4000145")]
			public const string UrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

			[Token(Token = "0x4000146")]
			public const string UrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/";

			[Token(Token = "0x4000147")]
			public const string UrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-depthbuffer/";

			[Token(Token = "0x4000148")]
			public const string UrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

			[Token(Token = "0x4000149")]
			public const string UrlSkewingHandle = "http://saladgamer.com/vlb-doc/comp-skewinghandle/";

			[Token(Token = "0x400014A")]
			public const string UrlEffectFlicker = "http://saladgamer.com/vlb-doc/comp-effect-flicker/";

			[Token(Token = "0x400014B")]
			public const string UrlEffectPulse = "http://saladgamer.com/vlb-doc/comp-effect-pulse/";

			[Token(Token = "0x400014C")]
			public const string UrlConfig = "http://saladgamer.com/vlb-doc/config/";
		}

		[Token(Token = "0x2000039")]
		public static class Internal
		{
			[Token(Token = "0x400014D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly bool ProceduralObjectsVisibleInEditor;

			[Token(Token = "0x1700005F")]
			public static HideFlags ProceduralObjectsHideFlags
			{
				[Token(Token = "0x6000184")]
				[Address(RVA = "0x1129CE0", Offset = "0x1129CE0", VA = "0x1129CE0")]
				get
				{
					return default(HideFlags);
				}
			}
		}

		[Token(Token = "0x200003A")]
		public static class Beam
		{
			[Token(Token = "0x400014E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Color FlatColor;

			[Token(Token = "0x400014F")]
			public const ColorMode ColorModeDefault = ColorMode.Flat;

			[Token(Token = "0x4000150")]
			public const float IntensityDefault = 1f;

			[Token(Token = "0x4000151")]
			public const float IntensityMin = 0f;

			[Token(Token = "0x4000152")]
			public const float SpotAngleDefault = 35f;

			[Token(Token = "0x4000153")]
			public const float SpotAngleMin = 0.1f;

			[Token(Token = "0x4000154")]
			public const float SpotAngleMax = 179.9f;

			[Token(Token = "0x4000155")]
			public const float ConeRadiusStart = 0.1f;

			[Token(Token = "0x4000156")]
			public const MeshType GeomMeshType = MeshType.Shared;

			[Token(Token = "0x4000157")]
			public const int GeomSidesDefault = 18;

			[Token(Token = "0x4000158")]
			public const int GeomSidesMin = 3;

			[Token(Token = "0x4000159")]
			public const int GeomSidesMax = 256;

			[Token(Token = "0x400015A")]
			public const int GeomSegmentsDefault = 5;

			[Token(Token = "0x400015B")]
			public const int GeomSegmentsMin = 0;

			[Token(Token = "0x400015C")]
			public const int GeomSegmentsMax = 64;

			[Token(Token = "0x400015D")]
			public const bool GeomCap = false;

			[Token(Token = "0x400015E")]
			public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

			[Token(Token = "0x400015F")]
			public const float AttenuationCustomBlending = 0.5f;

			[Token(Token = "0x4000160")]
			public const float FallOffStart = 0f;

			[Token(Token = "0x4000161")]
			public const float FallOffEnd = 3f;

			[Token(Token = "0x4000162")]
			public const float FallOffDistancesMinThreshold = 0.01f;

			[Token(Token = "0x4000163")]
			public const float DepthBlendDistance = 2f;

			[Token(Token = "0x4000164")]
			public const float CameraClippingDistance = 0.5f;

			[Token(Token = "0x4000165")]
			public const float FresnelPowMaxValue = 10f;

			[Token(Token = "0x4000166")]
			public const float FresnelPow = 8f;

			[Token(Token = "0x4000167")]
			public const float GlareFrontal = 0.5f;

			[Token(Token = "0x4000168")]
			public const float GlareBehind = 0.5f;

			[Token(Token = "0x4000169")]
			public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

			[Token(Token = "0x400016A")]
			public const float NoiseIntensityMin = 0f;

			[Token(Token = "0x400016B")]
			public const float NoiseIntensityMax = 1f;

			[Token(Token = "0x400016C")]
			public const float NoiseIntensityDefault = 0.5f;

			[Token(Token = "0x400016D")]
			public const float NoiseScaleMin = 0.01f;

			[Token(Token = "0x400016E")]
			public const float NoiseScaleMax = 2f;

			[Token(Token = "0x400016F")]
			public const float NoiseScaleDefault = 0.5f;

			[Token(Token = "0x4000170")]
			[FieldOffset(Offset = "0x10")]
			public static readonly Vector3 NoiseVelocityDefault;

			[Token(Token = "0x4000171")]
			public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

			[Token(Token = "0x4000172")]
			public const ShaderAccuracy ShaderAccuracyDefault = ShaderAccuracy.Fast;

			[Token(Token = "0x4000173")]
			public const float FadeOutBeginDefault = -150f;

			[Token(Token = "0x4000174")]
			public const float FadeOutEndDefault = -200f;

			[Token(Token = "0x4000175")]
			public const Dimensions DimensionsDefault = Dimensions.Dim3D;

			[Token(Token = "0x4000176")]
			[FieldOffset(Offset = "0x1C")]
			public static readonly Vector2 TiltDefault;

			[Token(Token = "0x4000177")]
			[FieldOffset(Offset = "0x24")]
			public static readonly Vector3 SkewingLocalForwardDirectionDefault;

			[Token(Token = "0x4000178")]
			public const Transform ClippingPlaneTransformDefault = null;
		}

		[Token(Token = "0x200003B")]
		public static class DustParticles
		{
			[Token(Token = "0x4000179")]
			public const float AlphaDefault = 0.5f;

			[Token(Token = "0x400017A")]
			public const float SizeDefault = 0.01f;

			[Token(Token = "0x400017B")]
			public const ParticlesDirection DirectionDefault = ParticlesDirection.Random;

			[Token(Token = "0x400017C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly Vector3 VelocityDefault;

			[Token(Token = "0x400017D")]
			public const float DensityDefault = 5f;

			[Token(Token = "0x400017E")]
			public const float DensityMin = 0f;

			[Token(Token = "0x400017F")]
			public const float DensityMax = 1000f;

			[Token(Token = "0x4000180")]
			[FieldOffset(Offset = "0xC")]
			public static readonly MinMaxRangeFloat SpawnDistanceRangeDefault;

			[Token(Token = "0x4000181")]
			public const bool CullingEnabledDefault = false;

			[Token(Token = "0x4000182")]
			public const float CullingMaxDistanceDefault = 10f;

			[Token(Token = "0x4000183")]
			public const float CullingMaxDistanceMin = 1f;
		}

		[Token(Token = "0x200003C")]
		public static class DynOcclusion
		{
			[Token(Token = "0x4000184")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LayerMask LayerMaskDefault;

			[Token(Token = "0x4000185")]
			public const float FadeDistanceToSurfaceDefault = 0.25f;

			[Token(Token = "0x4000186")]
			public const DynamicOcclusionUpdateRate UpdateRateDefault = DynamicOcclusionUpdateRate.EveryXFrames;

			[Token(Token = "0x4000187")]
			public const int WaitFramesCountDefault = 3;

			[Token(Token = "0x4000188")]
			public const Dimensions RaycastingDimensionsDefault = Dimensions.Dim3D;

			[Token(Token = "0x4000189")]
			public const bool RaycastingConsiderTriggersDefault = false;

			[Token(Token = "0x400018A")]
			public const float RaycastingMinOccluderAreaDefault = 0f;

			[Token(Token = "0x400018B")]
			public const float RaycastingMinSurfaceRatioDefault = 0.5f;

			[Token(Token = "0x400018C")]
			public const float RaycastingMinSurfaceRatioMin = 50f;

			[Token(Token = "0x400018D")]
			public const float RaycastingMinSurfaceRatioMax = 100f;

			[Token(Token = "0x400018E")]
			public const float RaycastingMaxSurfaceDotDefault = 0.25f;

			[Token(Token = "0x400018F")]
			public const float RaycastingMaxSurfaceAngleMin = 45f;

			[Token(Token = "0x4000190")]
			public const float RaycastingMaxSurfaceAngleMax = 90f;

			[Token(Token = "0x4000191")]
			public const PlaneAlignment RaycastingPlaneAlignmentDefault = PlaneAlignment.Surface;

			[Token(Token = "0x4000192")]
			public const float RaycastingPlaneOffsetDefault = 0.1f;

			[Token(Token = "0x4000193")]
			public const int DepthBufferDepthMapResolutionDefault = 32;

			[Token(Token = "0x4000194")]
			public const bool DepthBufferOcclusionCullingDefault = true;
		}

		[Token(Token = "0x200003D")]
		public static class Effects
		{
			[Token(Token = "0x4000195")]
			public const EffectAbstractBase.ComponentsToChange ComponentsToChangeDefault = (EffectAbstractBase.ComponentsToChange)2147483647;

			[Token(Token = "0x4000196")]
			public const bool RestoreBaseIntensityDefault = true;

			[Token(Token = "0x4000197")]
			public const float FrequencyDefault = 10f;

			[Token(Token = "0x4000198")]
			public const bool PerformPausesDefault = false;

			[Token(Token = "0x4000199")]
			[FieldOffset(Offset = "0x0")]
			public static readonly MinMaxRangeFloat FlickeringDurationDefault;

			[Token(Token = "0x400019A")]
			[FieldOffset(Offset = "0x8")]
			public static readonly MinMaxRangeFloat PauseDurationDefault;

			[Token(Token = "0x400019B")]
			[FieldOffset(Offset = "0x10")]
			public static readonly MinMaxRangeFloat IntensityAmplitudeDefault;

			[Token(Token = "0x400019C")]
			public const float SmoothingDefault = 0.05f;
		}

		[Token(Token = "0x200003E")]
		public static class Config
		{
			[Token(Token = "0x400019D")]
			public const bool GeometryOverrideLayerDefault = true;

			[Token(Token = "0x400019E")]
			public const int GeometryLayerIDDefault = 1;

			[Token(Token = "0x400019F")]
			public const string GeometryTagDefault = "Untagged";

			[Token(Token = "0x40001A0")]
			public const string FadeOutCameraTagDefault = "MainCamera";

			[Token(Token = "0x40001A1")]
			public const RenderQueue GeometryRenderQueueDefault = RenderQueue.Transparent;

			[Token(Token = "0x40001A2")]
			public const RenderPipeline GeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

			[Token(Token = "0x40001A3")]
			public const RenderingMode GeometryRenderingModeDefault = RenderingMode.SinglePass;

			[Token(Token = "0x40001A4")]
			public const int Noise3DSizeDefault = 64;

			[Token(Token = "0x40001A5")]
			public const int SharedMeshSides = 24;

			[Token(Token = "0x40001A6")]
			public const int SharedMeshSegments = 5;

			[Token(Token = "0x40001A7")]
			public const float DitheringFactor = 0f;

			[Token(Token = "0x40001A8")]
			public const bool FeatureEnabledDefault = true;

			[Token(Token = "0x40001A9")]
			public const FeatureEnabledColorGradient FeatureEnabledColorGradientDefault = FeatureEnabledColorGradient.HighOnly;
		}

		[Token(Token = "0x4000028")]
		public const string PluginFolder = "Plugins/VolumetricLightBeam";
	}
	[Token(Token = "0x2000007")]
	public static class DummyMaterial
	{
	}
	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x3037E4", Offset = "0x3037E4")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x3037E4", Offset = "0x3037E4")]
	public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x200003F")]
		protected enum ProcessOcclusionSource
		{
			[Token(Token = "0x40001AB")]
			RenderLoop,
			[Token(Token = "0x40001AC")]
			OnEnable,
			[Token(Token = "0x40001AD")]
			EditorUpdate,
			[Token(Token = "0x40001AE")]
			User
		}

		[Token(Token = "0x4000029")]
		public const string ClassName = "DynamicOcclusionAbstractBase";

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0xC")]
		public DynamicOcclusionUpdateRate updateRate;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x303EEC", Offset = "0x303EEC")]
		public int waitXFrames;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x0")]
		public static bool _INTERNAL_ApplyRandomFrameOffset;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x18")]
		private TransformUtils.Packed m_TransformPacked;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x40")]
		private int m_LastFrameRendered;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x44")]
		protected VolumetricLightBeam m_Master;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x48")]
		protected MaterialModifier.Callback m_MaterialModifierCallbackCached;

		[Token(Token = "0x17000016")]
		public int _INTERNAL_LastFrameRendered
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x1130EBC", Offset = "0x1130EBC", VA = "0x1130EBC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action onOcclusionProcessed
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x1130BF4", Offset = "0x1130BF4", VA = "0x1130BF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30477C", Offset = "0x30477C")]
			add
			{
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x1130CA4", Offset = "0x1130CA4", VA = "0x1130CA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30478C", Offset = "0x30478C")]
			remove
			{
			}
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1130980", Offset = "0x1130980", VA = "0x1130980")]
		public void ProcessOcclusionManually()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1130988", Offset = "0x1130988", VA = "0x1130988")]
		protected void ProcessOcclusion(ProcessOcclusionSource source)
		{
		}

		[Token(Token = "0x6000051")]
		protected abstract string GetShaderKeyword();

		[Token(Token = "0x6000052")]
		protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

		[Token(Token = "0x6000053")]
		protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

		[Token(Token = "0x6000054")]
		protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

		[Token(Token = "0x6000055")]
		protected abstract void OnEnablePostValidate();

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1130EC4", Offset = "0x1130EC4", VA = "0x1130EC4", Slot = "9")]
		protected virtual void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1130F50", Offset = "0x1130F50", VA = "0x1130F50", Slot = "10")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1130FDC", Offset = "0x1130FDC", VA = "0x1130FDC", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x113104C", Offset = "0x113104C", VA = "0x113104C", Slot = "12")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x11313D8", Offset = "0x11313D8", VA = "0x11313D8", Slot = "13")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1131528", Offset = "0x1131528", VA = "0x1131528")]
		private void OnWillCameraRender(Camera cam)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x113100C", Offset = "0x113100C", VA = "0x113100C")]
		private void DisableOcclusion()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x11318A4", Offset = "0x11318A4", VA = "0x11318A4")]
		protected DynamicOcclusionAbstractBase()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1131920", Offset = "0x1131920", VA = "0x1131920")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30479C", Offset = "0x30479C")]
		private void <OnEnable>b__24_0()
		{
		}
	}
	[Token(Token = "0x2000009")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x30388C", Offset = "0x30388C")]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x4000032")]
		public new const string ClassName = "DynamicOcclusionDepthBuffer";

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x4C")]
		public LayerMask layerMask;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x50")]
		public bool useOcclusionCulling;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x54")]
		public int depthMapResolution;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x58")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x5C")]
		private Camera m_DepthCamera;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x60")]
		private bool m_NeedToUpdateOcclusionNextFrame;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1131928", Offset = "0x1131928", VA = "0x1131928", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1131978", Offset = "0x1131978", VA = "0x1131978", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1131980", Offset = "0x1131980", VA = "0x1131980")]
		private void ProcessOcclusionInternal()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1131CA8", Offset = "0x1131CA8", VA = "0x1131CA8", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1131D48", Offset = "0x1131D48", VA = "0x1131D48")]
		private void Update()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x11319B0", Offset = "0x11319B0", VA = "0x11319B0")]
		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1131FD4", Offset = "0x1131FD4", VA = "0x1131FD4")]
		public bool HasLayerMaskIssues()
		{
			return default(bool);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x11320C4", Offset = "0x11320C4", VA = "0x11320C4", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1132178", Offset = "0x1132178", VA = "0x1132178")]
		private void InstantiateOrActivateDepthCamera()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1132524", Offset = "0x1132524", VA = "0x1132524", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1132528", Offset = "0x1132528", VA = "0x1132528", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x11325F4", Offset = "0x11325F4", VA = "0x11325F4", Slot = "10")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x11325F8", Offset = "0x11325F8", VA = "0x11325F8", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1132614", Offset = "0x1132614", VA = "0x1132614")]
		private void DestroyDepthCamera()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x11327E8", Offset = "0x11327E8", VA = "0x11327E8", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x11329CC", Offset = "0x11329CC", VA = "0x11329CC")]
		public DynamicOcclusionDepthBuffer()
		{
		}
	}
	[Token(Token = "0x200000A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3038D4", Offset = "0x3038D4")]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		[Token(Token = "0x2000040")]
		public struct HitResult
		{
			[Token(Token = "0x40001AF")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 point;

			[Token(Token = "0x40001B0")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 normal;

			[Token(Token = "0x40001B1")]
			[FieldOffset(Offset = "0x18")]
			public float distance;

			[Token(Token = "0x40001B2")]
			[FieldOffset(Offset = "0x1C")]
			private Collider2D collider2D;

			[Token(Token = "0x40001B3")]
			[FieldOffset(Offset = "0x20")]
			private Collider collider3D;

			[Token(Token = "0x17000060")]
			public bool hasCollider
			{
				[Token(Token = "0x600018C")]
				[Address(RVA = "0x3AD0A8", Offset = "0x3AD0A8", VA = "0x3AD0A8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000061")]
			public string name
			{
				[Token(Token = "0x600018D")]
				[Address(RVA = "0x3AD0B0", Offset = "0x3AD0B0", VA = "0x3AD0B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000062")]
			public Bounds bounds
			{
				[Token(Token = "0x600018E")]
				[Address(RVA = "0x3AD0B8", Offset = "0x3AD0B8", VA = "0x3AD0B8")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x600018A")]
			[Address(RVA = "0x3AD098", Offset = "0x3AD098", VA = "0x3AD098")]
			public HitResult(ref RaycastHit hit3D)
			{
			}

			[Token(Token = "0x600018B")]
			[Address(RVA = "0x3AD0A0", Offset = "0x3AD0A0", VA = "0x3AD0A0")]
			public HitResult(ref RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x600018F")]
			[Address(RVA = "0x3AD0CC", Offset = "0x3AD0CC", VA = "0x3AD0CC")]
			public void SetNull()
			{
			}
		}

		[Token(Token = "0x2000041")]
		private enum Direction
		{
			[Token(Token = "0x40001B5")]
			Up = 0,
			[Token(Token = "0x40001B6")]
			Down = 1,
			[Token(Token = "0x40001B7")]
			Left = 2,
			[Token(Token = "0x40001B8")]
			Right = 3,
			[Token(Token = "0x40001B9")]
			Max2D = 1,
			[Token(Token = "0x40001BA")]
			Max3D = 3
		}

		[Token(Token = "0x4000039")]
		public new const string ClassName = "DynamicOcclusionRaycasting";

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x4C")]
		public Dimensions dimensions;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x50")]
		public LayerMask layerMask;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x54")]
		public bool considerTriggers;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x58")]
		public float minOccluderArea;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x5C")]
		public float minSurfaceRatio;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x60")]
		public float maxSurfaceDot;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x64")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x68")]
		public float planeOffset;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x303F30", Offset = "0x303F30")]
		public float fadeDistanceToSurface;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x70")]
		private HitResult m_CurrentHit;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x94")]
		private float m_RangeMultiplier;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x303F64", Offset = "0x303F64")]
		private Plane <planeEquationWS>k__BackingField;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0xA8")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x17000017")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x304F00", Offset = "0x304F00")]
		public float fadeDistanceToPlane
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x1132AB4", Offset = "0x1132AB4", VA = "0x1132AB4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x1132ABC", Offset = "0x1132ABC", VA = "0x1132ABC")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x1132CDC", Offset = "0x1132CDC", VA = "0x1132CDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3047AC", Offset = "0x3047AC")]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x1132CEC", Offset = "0x1132CEC", VA = "0x1132CEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3047BC", Offset = "0x3047BC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x1133040", Offset = "0x1133040", VA = "0x1133040")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x1700001A")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x1133054", Offset = "0x1133054", VA = "0x1133054")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1132AC4", Offset = "0x1132AC4", VA = "0x1132AC4")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1132C84", Offset = "0x1132C84", VA = "0x1132C84", Slot = "4")]
		protected override string GetShaderKeyword()
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1132CD4", Offset = "0x1132CD4", VA = "0x1132CD4", Slot = "5")]
		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1132CFC", Offset = "0x1132CFC", VA = "0x1132CFC", Slot = "9")]
		protected override void OnValidateProperties()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1132DAC", Offset = "0x1132DAC", VA = "0x1132DAC", Slot = "8")]
		protected override void OnEnablePostValidate()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1132DCC", Offset = "0x1132DCC", VA = "0x1132DCC", Slot = "13")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1132E14", Offset = "0x1132E14", VA = "0x1132E14")]
		private void Start()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1132F1C", Offset = "0x1132F1C", VA = "0x1132F1C")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x11331A4", Offset = "0x11331A4", VA = "0x11331A4")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x11331FC", Offset = "0x11331FC", VA = "0x11331FC")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x11334F0", Offset = "0x11334F0", VA = "0x11334F0")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1133B4C", Offset = "0x1133B4C", VA = "0x1133B4C")]
		private uint GetDirectionCount()
		{
			return default(uint);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1133B60", Offset = "0x1133B60", VA = "0x1133B60")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1133E50", Offset = "0x1133E50", VA = "0x1133E50")]
		private bool IsHitValid(ref HitResult hit, Vector3 forwardVec)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1134014", Offset = "0x1134014", VA = "0x1134014", Slot = "6")]
		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1134660", Offset = "0x1134660", VA = "0x1134660")]
		private void SetHit(ref HitResult hit)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1132DF4", Offset = "0x1132DF4", VA = "0x1132DF4")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x11349C0", Offset = "0x11349C0", VA = "0x11349C0", Slot = "7")]
		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x11347F4", Offset = "0x11347F4", VA = "0x11347F4")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1134974", Offset = "0x1134974", VA = "0x1134974")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1134D80", Offset = "0x1134D80", VA = "0x1134D80")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1134D90", Offset = "0x1134D90", VA = "0x1134D90")]
		public DynamicOcclusionRaycasting()
		{
		}
	}
	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x30391C", Offset = "0x30391C")]
	[DisallowMultipleComponent]
	public class EffectAbstractBase : MonoBehaviour
	{
		[Token(Token = "0x2000042")]
		[Flags]
		public enum ComponentsToChange
		{
			[Token(Token = "0x40001BC")]
			UnityLight = 1,
			[Token(Token = "0x40001BD")]
			VolumetricLightBeam = 2,
			[Token(Token = "0x40001BE")]
			VolumetricDustParticles = 4
		}

		[Token(Token = "0x4000047")]
		public const string ClassName = "EffectAbstractBase";

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0xC")]
		public ComponentsToChange componentsToChange;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x10")]
		public bool restoreBaseIntensity;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x14")]
		protected VolumetricLightBeam m_Beam;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x18")]
		protected Light m_Light;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x1C")]
		protected VolumetricDustParticles m_Particles;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x20")]
		protected float m_BaseIntensityBeamInside;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x24")]
		protected float m_BaseIntensityBeamOutside;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x28")]
		protected float m_BaseIntensityLight;

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x11350A4", Offset = "0x11350A4", VA = "0x11350A4")]
		protected void SetAdditiveIntensity(float additive)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1135418", Offset = "0x1135418", VA = "0x1135418")]
		private void Awake()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x11355D4", Offset = "0x11355D4", VA = "0x11355D4", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x11355DC", Offset = "0x11355DC", VA = "0x11355DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1135610", Offset = "0x1135610", VA = "0x1135610")]
		public EffectAbstractBase()
		{
		}
	}
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x303964", Offset = "0x303964")]
	public class EffectFlicker : EffectAbstractBase
	{
		[Token(Token = "0x2000043")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x303D60", Offset = "0x303D60")]
		private sealed class <CoUpdate>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001BF")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40001C0")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40001C1")]
			[FieldOffset(Offset = "0x10")]
			public EffectFlicker <>4__this;

			[Token(Token = "0x40001C2")]
			[FieldOffset(Offset = "0x14")]
			private float <remaining>5__2;

			[Token(Token = "0x17000063")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000193")]
				[Address(RVA = "0x1135DC4", Offset = "0x1135DC4", VA = "0x1135DC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000064")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000195")]
				[Address(RVA = "0x1135E44", Offset = "0x1135E44", VA = "0x1135E44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000190")]
			[Address(RVA = "0x11356D8", Offset = "0x11356D8", VA = "0x11356D8")]
			[DebuggerHidden]
			public <CoUpdate>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000191")]
			[Address(RVA = "0x1135CC8", Offset = "0x1135CC8", VA = "0x1135CC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000192")]
			[Address(RVA = "0x1135CCC", Offset = "0x1135CCC", VA = "0x1135CCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000194")]
			[Address(RVA = "0x1135DCC", Offset = "0x1135DCC", VA = "0x1135DCC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000044")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x303D70", Offset = "0x303D70")]
		private sealed class <CoFlicker>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001C3")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40001C4")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40001C5")]
			[FieldOffset(Offset = "0x10")]
			public EffectFlicker <>4__this;

			[Token(Token = "0x40001C6")]
			[FieldOffset(Offset = "0x14")]
			private float <remainingDuration>5__2;

			[Token(Token = "0x40001C7")]
			[FieldOffset(Offset = "0x18")]
			private float <freqDuration>5__3;

			[Token(Token = "0x17000065")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000199")]
				[Address(RVA = "0x1135C40", Offset = "0x1135C40", VA = "0x1135C40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600019B")]
				[Address(RVA = "0x1135CC0", Offset = "0x1135CC0", VA = "0x1135CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1135778", Offset = "0x1135778", VA = "0x1135778")]
			[DebuggerHidden]
			public <CoFlicker>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000197")]
			[Address(RVA = "0x1135B40", Offset = "0x1135B40", VA = "0x1135B40", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000198")]
			[Address(RVA = "0x1135B44", Offset = "0x1135B44", VA = "0x1135B44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600019A")]
			[Address(RVA = "0x1135C48", Offset = "0x1135C48", VA = "0x1135C48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000045")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x303D80", Offset = "0x303D80")]
		private sealed class <CoChangeIntensity>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001C8")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40001C9")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40001CA")]
			[FieldOffset(Offset = "0x10")]
			public EffectFlicker <>4__this;

			[Token(Token = "0x40001CB")]
			[FieldOffset(Offset = "0x14")]
			public float nextIntensity;

			[Token(Token = "0x40001CC")]
			[FieldOffset(Offset = "0x18")]
			public float expectedDuration;

			[Token(Token = "0x40001CD")]
			[FieldOffset(Offset = "0x1C")]
			private float <velocity>5__2;

			[Token(Token = "0x40001CE")]
			[FieldOffset(Offset = "0x20")]
			private float <t>5__3;

			[Token(Token = "0x17000067")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600019F")]
				[Address(RVA = "0x1135AB8", Offset = "0x1135AB8", VA = "0x1135AB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001A1")]
				[Address(RVA = "0x1135B38", Offset = "0x1135B38", VA = "0x1135B38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600019C")]
			[Address(RVA = "0x1135854", Offset = "0x1135854", VA = "0x1135854")]
			[DebuggerHidden]
			public <CoChangeIntensity>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x600019D")]
			[Address(RVA = "0x1135958", Offset = "0x1135958", VA = "0x1135958", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600019E")]
			[Address(RVA = "0x113595C", Offset = "0x113595C", VA = "0x113595C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x1135AC0", Offset = "0x1135AC0", VA = "0x1135AC0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000050")]
		public new const string ClassName = "EffectFlicker";

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x303F74", Offset = "0x303F74")]
		public float frequency;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x30")]
		public bool performPauses;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x303F90", Offset = "0x303F90")]
		public MinMaxRangeFloat flickeringDuration;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x303FAC", Offset = "0x303FAC")]
		public MinMaxRangeFloat pauseDuration;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x303FC8", Offset = "0x303FC8")]
		public MinMaxRangeFloat intensityAmplitude;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x303FE8", Offset = "0x303FE8")]
		public float smoothing;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x50")]
		private float m_CurrentAdditiveIntensity;

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1135628", Offset = "0x1135628", VA = "0x1135628", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1135658", Offset = "0x1135658", VA = "0x1135658")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3047CC", Offset = "0x3047CC")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x11356F8", Offset = "0x11356F8", VA = "0x11356F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x30483C", Offset = "0x30483C")]
		private IEnumerator CoFlicker()
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1135798", Offset = "0x1135798", VA = "0x1135798")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3048AC", Offset = "0x3048AC")]
		private IEnumerator CoChangeIntensity(float expectedDuration, float nextIntensity)
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1135874", Offset = "0x1135874", VA = "0x1135874")]
		public EffectFlicker()
		{
		}
	}
	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x303998", Offset = "0x303998")]
	public class EffectPulse : EffectAbstractBase
	{
		[Token(Token = "0x2000046")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x303D90", Offset = "0x303D90")]
		private sealed class <CoUpdate>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001CF")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40001D0")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40001D1")]
			[FieldOffset(Offset = "0x10")]
			public EffectPulse <>4__this;

			[Token(Token = "0x40001D2")]
			[FieldOffset(Offset = "0x14")]
			private float <t>5__2;

			[Token(Token = "0x17000069")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001A5")]
				[Address(RVA = "0x113618C", Offset = "0x113618C", VA = "0x113618C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001A7")]
				[Address(RVA = "0x113620C", Offset = "0x113620C", VA = "0x113620C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x1135EFC", Offset = "0x1135EFC", VA = "0x1135EFC")]
			[DebuggerHidden]
			public <CoUpdate>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x1135FCC", Offset = "0x1135FCC", VA = "0x1135FCC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x1135FD0", Offset = "0x1135FD0", VA = "0x1135FD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x1136194", Offset = "0x1136194", VA = "0x1136194", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000058")]
		public new const string ClassName = "EffectPulse";

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x304000", Offset = "0x304000")]
		public float frequency;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x304020", Offset = "0x304020")]
		public MinMaxRangeFloat intensityAmplitude;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1135E4C", Offset = "0x1135E4C", VA = "0x1135E4C", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1135E7C", Offset = "0x1135E7C", VA = "0x1135E7C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x30491C", Offset = "0x30491C")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1135F1C", Offset = "0x1135F1C", VA = "0x1135F1C")]
		public EffectPulse()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public enum FeatureEnabledColorGradient
	{
		[Token(Token = "0x400005C")]
		Off,
		[Token(Token = "0x400005D")]
		HighOnly,
		[Token(Token = "0x400005E")]
		HighAndLow
	}
	[Token(Token = "0x200000F")]
	public enum ColorMode
	{
		[Token(Token = "0x4000060")]
		Flat,
		[Token(Token = "0x4000061")]
		Gradient
	}
	[Token(Token = "0x2000010")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x4000063")]
		Linear,
		[Token(Token = "0x4000064")]
		Quadratic,
		[Token(Token = "0x4000065")]
		Blend
	}
	[Token(Token = "0x2000011")]
	public enum BlendingMode
	{
		[Token(Token = "0x4000067")]
		Additive,
		[Token(Token = "0x4000068")]
		SoftAdditive,
		[Token(Token = "0x4000069")]
		TraditionalTransparency
	}
	[Token(Token = "0x2000012")]
	public enum ShaderAccuracy
	{
		[Token(Token = "0x400006B")]
		Fast,
		[Token(Token = "0x400006C")]
		High
	}
	[Token(Token = "0x2000013")]
	public enum NoiseMode
	{
		[Token(Token = "0x400006E")]
		Disabled,
		[Token(Token = "0x400006F")]
		WorldSpace,
		[Token(Token = "0x4000070")]
		LocalSpace
	}
	[Token(Token = "0x2000014")]
	public enum MeshType
	{
		[Token(Token = "0x4000072")]
		Shared,
		[Token(Token = "0x4000073")]
		Custom
	}
	[Token(Token = "0x2000015")]
	public enum RenderPipeline
	{
		[Token(Token = "0x4000075")]
		BuiltIn,
		[Token(Token = "0x4000076")]
		URP,
		[Token(Token = "0x4000077")]
		HDRP
	}
	[Token(Token = "0x2000016")]
	public enum RenderingMode
	{
		[Token(Token = "0x4000079")]
		MultiPass,
		[Token(Token = "0x400007A")]
		SinglePass,
		[Token(Token = "0x400007B")]
		GPUInstancing,
		[Token(Token = "0x400007C")]
		SRPBatcher
	}
	[Token(Token = "0x2000017")]
	public enum RenderQueue
	{
		[Token(Token = "0x400007E")]
		Custom = 0,
		[Token(Token = "0x400007F")]
		Background = 1000,
		[Token(Token = "0x4000080")]
		Geometry = 2000,
		[Token(Token = "0x4000081")]
		AlphaTest = 2450,
		[Token(Token = "0x4000082")]
		GeometryLast = 2500,
		[Token(Token = "0x4000083")]
		Transparent = 3000,
		[Token(Token = "0x4000084")]
		Overlay = 4000
	}
	[Token(Token = "0x2000018")]
	public enum Dimensions
	{
		[Token(Token = "0x4000086")]
		Dim3D,
		[Token(Token = "0x4000087")]
		Dim2D
	}
	[Token(Token = "0x2000019")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x4000089")]
		Surface,
		[Token(Token = "0x400008A")]
		Beam
	}
	[Token(Token = "0x200001A")]
	[Flags]
	public enum DynamicOcclusionUpdateRate
	{
		[Token(Token = "0x400008C")]
		Never = 1,
		[Token(Token = "0x400008D")]
		OnEnable = 2,
		[Token(Token = "0x400008E")]
		OnBeamMove = 4,
		[Token(Token = "0x400008F")]
		EveryXFrames = 8,
		[Token(Token = "0x4000090")]
		OnBeamMoveAndEveryXFrames = 0xC
	}
	[Token(Token = "0x200001B")]
	public enum ParticlesDirection
	{
		[Token(Token = "0x4000092")]
		Random,
		[Token(Token = "0x4000093")]
		LocalSpace,
		[Token(Token = "0x4000094")]
		WorldSpace
	}
	[Token(Token = "0x200001C")]
	public static class GlobalMesh
	{
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x4")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x112B4EC", Offset = "0x112B4EC", VA = "0x112B4EC")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1136214", Offset = "0x1136214", VA = "0x1136214")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1136344", Offset = "0x1136344", VA = "0x1136344")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public static class MaterialManager
	{
		[Token(Token = "0x2000047")]
		public enum BlendingMode
		{
			[Token(Token = "0x40001D4")]
			Additive,
			[Token(Token = "0x40001D5")]
			SoftAdditive,
			[Token(Token = "0x40001D6")]
			TraditionalTransparency,
			[Token(Token = "0x40001D7")]
			Count
		}

		[Token(Token = "0x2000048")]
		public enum Noise3D
		{
			[Token(Token = "0x40001D9")]
			Off,
			[Token(Token = "0x40001DA")]
			On,
			[Token(Token = "0x40001DB")]
			Count
		}

		[Token(Token = "0x2000049")]
		public enum DepthBlend
		{
			[Token(Token = "0x40001DD")]
			Off,
			[Token(Token = "0x40001DE")]
			On,
			[Token(Token = "0x40001DF")]
			Count
		}

		[Token(Token = "0x200004A")]
		public enum ColorGradient
		{
			[Token(Token = "0x40001E1")]
			Off,
			[Token(Token = "0x40001E2")]
			MatrixLow,
			[Token(Token = "0x40001E3")]
			MatrixHigh,
			[Token(Token = "0x40001E4")]
			Count
		}

		[Token(Token = "0x200004B")]
		public enum DynamicOcclusion
		{
			[Token(Token = "0x40001E6")]
			Off,
			[Token(Token = "0x40001E7")]
			ClippingPlane,
			[Token(Token = "0x40001E8")]
			DepthTexture,
			[Token(Token = "0x40001E9")]
			Count
		}

		[Token(Token = "0x200004C")]
		public enum MeshSkewing
		{
			[Token(Token = "0x40001EB")]
			Off,
			[Token(Token = "0x40001EC")]
			On,
			[Token(Token = "0x40001ED")]
			Count
		}

		[Token(Token = "0x200004D")]
		public enum ShaderAccuracy
		{
			[Token(Token = "0x40001EF")]
			Fast,
			[Token(Token = "0x40001F0")]
			High,
			[Token(Token = "0x40001F1")]
			Count
		}

		[Token(Token = "0x200004E")]
		public struct StaticProperties
		{
			[Token(Token = "0x40001F2")]
			[FieldOffset(Offset = "0x0")]
			public BlendingMode blendingMode;

			[Token(Token = "0x40001F3")]
			[FieldOffset(Offset = "0x4")]
			public Noise3D noise3D;

			[Token(Token = "0x40001F4")]
			[FieldOffset(Offset = "0x8")]
			public DepthBlend depthBlend;

			[Token(Token = "0x40001F5")]
			[FieldOffset(Offset = "0xC")]
			public ColorGradient colorGradient;

			[Token(Token = "0x40001F6")]
			[FieldOffset(Offset = "0x10")]
			public DynamicOcclusion dynamicOcclusion;

			[Token(Token = "0x40001F7")]
			[FieldOffset(Offset = "0x14")]
			public MeshSkewing meshSkewing;

			[Token(Token = "0x40001F8")]
			[FieldOffset(Offset = "0x18")]
			public ShaderAccuracy shaderAccuracy;

			[Token(Token = "0x1700006B")]
			private int blendingModeID
			{
				[Token(Token = "0x60001A8")]
				[Address(RVA = "0x3AD0DC", Offset = "0x3AD0DC", VA = "0x3AD0DC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700006C")]
			private int noise3DID
			{
				[Token(Token = "0x60001A9")]
				[Address(RVA = "0x3AD0E4", Offset = "0x3AD0E4", VA = "0x3AD0E4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700006D")]
			private int depthBlendID
			{
				[Token(Token = "0x60001AA")]
				[Address(RVA = "0x3AD0EC", Offset = "0x3AD0EC", VA = "0x3AD0EC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700006E")]
			private int colorGradientID
			{
				[Token(Token = "0x60001AB")]
				[Address(RVA = "0x3AD0F4", Offset = "0x3AD0F4", VA = "0x3AD0F4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700006F")]
			private int dynamicOcclusionID
			{
				[Token(Token = "0x60001AC")]
				[Address(RVA = "0x3AD0FC", Offset = "0x3AD0FC", VA = "0x3AD0FC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000070")]
			private int meshSkewingID
			{
				[Token(Token = "0x60001AD")]
				[Address(RVA = "0x3AD104", Offset = "0x3AD104", VA = "0x3AD104")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000071")]
			private int shaderAccuracyID
			{
				[Token(Token = "0x60001AE")]
				[Address(RVA = "0x3AD10C", Offset = "0x3AD10C", VA = "0x3AD10C")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x17000072")]
			public int materialID
			{
				[Token(Token = "0x60001AF")]
				[Address(RVA = "0x3AD114", Offset = "0x3AD114", VA = "0x3AD114")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x3AD11C", Offset = "0x3AD11C", VA = "0x3AD11C")]
			public void ApplyToMaterial(Material mat)
			{
			}
		}

		[Token(Token = "0x200004F")]
		private class MaterialsGroup
		{
			[Token(Token = "0x40001F9")]
			[FieldOffset(Offset = "0x8")]
			public Material[] materials;

			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x1136464", Offset = "0x1136464", VA = "0x1136464")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x4")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0xC")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x10")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x14")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1129D64", Offset = "0x1129D64", VA = "0x1129D64")]
		public static Material NewMaterialTransient(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x113634C", Offset = "0x113634C", VA = "0x113634C")]
		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x112D1F4", Offset = "0x112D1F4", VA = "0x112D1F4")]
		public static Material GetInstancedMaterial(uint groupID, ref StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x200001F")]
	public static class MaterialModifier
	{
		[Token(Token = "0x2000050")]
		public interface Interface
		{
			[Token(Token = "0x60001B2")]
			void SetMaterialProp(int nameID, float value);

			[Token(Token = "0x60001B3")]
			void SetMaterialProp(int nameID, Vector4 value);

			[Token(Token = "0x60001B4")]
			void SetMaterialProp(int nameID, Color value);

			[Token(Token = "0x60001B5")]
			void SetMaterialProp(int nameID, Matrix4x4 value);

			[Token(Token = "0x60001B6")]
			void SetMaterialProp(int nameID, Texture value);
		}

		[Token(Token = "0x2000051")]
		public delegate void Callback(Interface owner);
	}
	[Token(Token = "0x2000020")]
	public static class MeshGenerator
	{
		[Token(Token = "0x400009D")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1136AB8", Offset = "0x1136AB8", VA = "0x1136AB8")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1136AD4", Offset = "0x1136AD4", VA = "0x1136AD4")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1136BC0", Offset = "0x1136BC0", VA = "0x1136BC0")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x112A770", Offset = "0x112A770", VA = "0x112A770")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x112E85C", Offset = "0x112E85C", VA = "0x112E85C")]
		public static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1136BF8", Offset = "0x1136BF8", VA = "0x1136BF8")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1136C14", Offset = "0x1136C14", VA = "0x1136C14")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1136C38", Offset = "0x1136C38", VA = "0x1136C38")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1136D08", Offset = "0x1136D08", VA = "0x1136D08")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000021")]
	public struct MinMaxRangeFloat
	{
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float m_MinValue;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private float m_MaxValue;

		[Token(Token = "0x1700001B")]
		public float minValue
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x3AD124", Offset = "0x3AD124", VA = "0x3AD124")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001C")]
		public float maxValue
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x3AD12C", Offset = "0x3AD12C", VA = "0x3AD12C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001D")]
		public float randomValue
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x3AD134", Offset = "0x3AD134", VA = "0x3AD134")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001E")]
		public Vector2 asVector2
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x3AD148", Offset = "0x3AD148", VA = "0x3AD148")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x3AD174", Offset = "0x3AD174", VA = "0x3AD174")]
		public float GetLerpedValue(float lerp01)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x3AD17C", Offset = "0x3AD17C", VA = "0x3AD17C")]
		public MinMaxRangeFloat(float min, float max)
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class MinMaxRangeAttribute : Attribute
	{
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x304060", Offset = "0x304060")]
		private float <minValue>k__BackingField;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x304070", Offset = "0x304070")]
		private float <maxValue>k__BackingField;

		[Token(Token = "0x1700001F")]
		public float minValue
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x1136DDC", Offset = "0x1136DDC", VA = "0x1136DDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30498C", Offset = "0x30498C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x1136DE4", Offset = "0x1136DE4", VA = "0x1136DE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30499C", Offset = "0x30499C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public float maxValue
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x1136DEC", Offset = "0x1136DEC", VA = "0x1136DEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3049AC", Offset = "0x3049AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x1136DF4", Offset = "0x1136DF4", VA = "0x1136DF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3049BC", Offset = "0x3049BC")]
			private set
			{
			}
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1136DFC", Offset = "0x1136DFC", VA = "0x1136DFC")]
		public MinMaxRangeAttribute(float min, float max)
		{
		}
	}
	[Token(Token = "0x2000023")]
	public static class Noise3D
	{
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x4")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x40000A5")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x17000021")]
		public static bool isSupported
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x112CA78", Offset = "0x112CA78", VA = "0x112CA78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x1136F08", Offset = "0x1136F08", VA = "0x1136F08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000023")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x1136E60", Offset = "0x1136E60", VA = "0x1136E60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1136FC0", Offset = "0x1136FC0", VA = "0x1136FC0")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x3049CC", Offset = "0x3049CC")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x112E4DC", Offset = "0x112E4DC", VA = "0x112E4DC")]
		public static void LoadIfNeeded()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class PlatformHelper
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1130474", Offset = "0x1130474", VA = "0x1130474")]
		public static string GetCurrentPlatformSuffix()
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1137034", Offset = "0x1137034", VA = "0x1137034")]
		private static string GetPlatformSuffix(RuntimePlatform platform)
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x11370D8", Offset = "0x11370D8", VA = "0x11370D8")]
		public PlatformHelper()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class PolygonHelper : MonoBehaviour
	{
		[Token(Token = "0x2000052")]
		public struct Plane2D
		{
			[Token(Token = "0x40001FA")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 normal;

			[Token(Token = "0x40001FB")]
			[FieldOffset(Offset = "0x8")]
			public float distance;

			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x3AD188", Offset = "0x3AD188", VA = "0x3AD188")]
			public float Distance(Vector2 point)
			{
				return default(float);
			}

			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x3AD190", Offset = "0x3AD190", VA = "0x3AD190")]
			public Vector2 ClosestPoint(Vector2 pt)
			{
				return default(Vector2);
			}

			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x3AD1AC", Offset = "0x3AD1AC", VA = "0x3AD1AC")]
			public Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				return default(Vector2);
			}

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x3AD1D4", Offset = "0x3AD1D4", VA = "0x3AD1D4")]
			public bool GetSide(Vector2 point)
			{
				return default(bool);
			}

			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x1137564", Offset = "0x1137564", VA = "0x1137564")]
			public static Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x1137698", Offset = "0x1137698", VA = "0x1137698")]
			public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				return default(Plane2D);
			}

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x3AD1FC", Offset = "0x3AD1FC", VA = "0x3AD1FC")]
			public void Flip()
			{
			}

			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x3AD204", Offset = "0x3AD204", VA = "0x3AD204")]
			public Vector2[] CutConvex(Vector2[] poly)
			{
				return null;
			}

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x3AD20C", Offset = "0x3AD20C", VA = "0x3AD20C", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x11370E0", Offset = "0x11370E0", VA = "0x11370E0")]
		public PolygonHelper()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public static class SRPHelper
	{
		[Token(Token = "0x2000053")]
		public enum RenderPipeline
		{
			[Token(Token = "0x40001FD")]
			Undefined,
			[Token(Token = "0x40001FE")]
			BuiltIn,
			[Token(Token = "0x40001FF")]
			URP,
			[Token(Token = "0x4000200")]
			LWRP,
			[Token(Token = "0x4000201")]
			HDRP
		}

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x0")]
		private static RenderPipeline m_RenderPipelineCached;

		[Token(Token = "0x17000024")]
		public static RenderPipeline renderPipelineType
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x112F95C", Offset = "0x112F95C", VA = "0x112F95C")]
			get
			{
				return default(RenderPipeline);
			}
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1137B98", Offset = "0x1137B98", VA = "0x1137B98")]
		private static RenderPipeline ComputeRenderPipeline()
		{
			return default(RenderPipeline);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x112EC2C", Offset = "0x112EC2C", VA = "0x112EC2C")]
		public static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1129808", Offset = "0x1129808", VA = "0x1129808")]
		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1129534", Offset = "0x1129534", VA = "0x1129534")]
		public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}
	}
	[Token(Token = "0x2000027")]
	public static class ShaderKeywords
	{
		[Token(Token = "0x40000A7")]
		public const string AlphaAsBlack = "VLB_ALPHA_AS_BLACK";

		[Token(Token = "0x40000A8")]
		public const string ColorGradientMatrixLow = "VLB_COLOR_GRADIENT_MATRIX_LOW";

		[Token(Token = "0x40000A9")]
		public const string ColorGradientMatrixHigh = "VLB_COLOR_GRADIENT_MATRIX_HIGH";

		[Token(Token = "0x40000AA")]
		public const string DepthBlend = "VLB_DEPTH_BLEND";

		[Token(Token = "0x40000AB")]
		public const string Noise3D = "VLB_NOISE_3D";

		[Token(Token = "0x40000AC")]
		public const string OcclusionClippingPlane = "VLB_OCCLUSION_CLIPPING_PLANE";

		[Token(Token = "0x40000AD")]
		public const string OcclusionDepthTexture = "VLB_OCCLUSION_DEPTH_TEXTURE";

		[Token(Token = "0x40000AE")]
		public const string MeshSkewing = "VLB_MESH_SKEWING";

		[Token(Token = "0x40000AF")]
		public const string ShaderAccuracyHigh = "VLB_SHADER_ACCURACY_HIGH";
	}
	[Token(Token = "0x2000028")]
	public static class ShaderProperties
	{
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int FadeOutFactor;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int ConeSlopeCosSin;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int ConeRadius;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int ConeApexOffsetZ;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int ColorFlat;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int AlphaInside;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int AlphaOutside;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly int AttenuationLerpLinearQuad;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x20")]
		public static readonly int DistanceFallOff;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x24")]
		public static readonly int DistanceCamClipping;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x28")]
		public static readonly int FresnelPow;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly int GlareBehind;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x30")]
		public static readonly int GlareFrontal;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x34")]
		public static readonly int DrawCap;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x38")]
		public static readonly int DepthBlendDistance;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x3C")]
		public static readonly int NoiseVelocityAndScale;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x40")]
		public static readonly int NoiseParam;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x44")]
		public static readonly int CameraParams;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x48")]
		public static readonly int ColorGradientMatrix;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x4C")]
		public static readonly int LocalToWorldMatrix;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x50")]
		public static readonly int WorldToLocalMatrix;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x54")]
		public static readonly int BlendSrcFactor;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x58")]
		public static readonly int BlendDstFactor;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x5C")]
		public static readonly int DynamicOcclusionClippingPlaneWS;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x60")]
		public static readonly int DynamicOcclusionClippingPlaneProps;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x64")]
		public static readonly int DynamicOcclusionDepthTexture;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x68")]
		public static readonly int DynamicOcclusionDepthProps;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x6C")]
		public static readonly int LocalForwardDirection;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x70")]
		public static readonly int TiltVector;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x74")]
		public static readonly int AdditionalClippingPlaneWS;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x78")]
		public static readonly int ParticlesTintColor;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x7C")]
		public static readonly int GlobalUsesReversedZBuffer;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x80")]
		public static readonly int GlobalNoiseTex3D;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x84")]
		public static readonly int GlobalNoiseCustomTime;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x88")]
		public static readonly int GlobalDitheringFactor;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x8C")]
		public static readonly int GlobalDitheringNoiseTex;
	}
	[Token(Token = "0x2000029")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x3039DC", Offset = "0x3039DC")]
	public class SkewingHandle : MonoBehaviour
	{
		[Token(Token = "0x2000054")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x303DA0", Offset = "0x303DA0")]
		private sealed class <CoUpdate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000202")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x4000203")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x4000204")]
			[FieldOffset(Offset = "0x10")]
			public SkewingHandle <>4__this;

			[Token(Token = "0x17000073")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001C7")]
				[Address(RVA = "0x11386C8", Offset = "0x11386C8", VA = "0x11386C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001C9")]
				[Address(RVA = "0x1138748", Offset = "0x1138748", VA = "0x1138748", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x113862C", Offset = "0x113862C", VA = "0x113862C")]
			[DebuggerHidden]
			public <CoUpdate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x1138654", Offset = "0x1138654", VA = "0x1138654", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x1138658", Offset = "0x1138658", VA = "0x1138658", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x11386D0", Offset = "0x11386D0", VA = "0x11386D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0xC")]
		public VolumetricLightBeam volumetricLightBeam;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x10")]
		public bool shouldUpdateEachFrame;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1138274", Offset = "0x1138274", VA = "0x1138274")]
		public bool IsAttachedToSelf()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1138368", Offset = "0x1138368", VA = "0x1138368")]
		public bool CanSetSkewingVector()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1138430", Offset = "0x1138430", VA = "0x1138430")]
		public bool CanUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1138470", Offset = "0x1138470", VA = "0x1138470")]
		private bool ShouldUpdateEachFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1138484", Offset = "0x1138484", VA = "0x1138484")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1138558", Offset = "0x1138558", VA = "0x1138558")]
		private void Start()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x11385AC", Offset = "0x11385AC", VA = "0x11385AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x3049DC", Offset = "0x3049DC")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x11384A8", Offset = "0x11384A8", VA = "0x11384A8")]
		private void SetSkewingVector()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x113864C", Offset = "0x113864C", VA = "0x113864C")]
		public SkewingHandle()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public static class TransformUtils
	{
		[Token(Token = "0x2000055")]
		public struct Packed
		{
			[Token(Token = "0x4000205")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x4000206")]
			[FieldOffset(Offset = "0xC")]
			public Quaternion rotation;

			[Token(Token = "0x4000207")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 lossyScale;

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x3AD214", Offset = "0x3AD214", VA = "0x3AD214")]
			public bool IsSame(Transform transf)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1130E18", Offset = "0x1130E18", VA = "0x1130E18")]
		public static Packed GetWorldPacked(this Transform self)
		{
			return default(Packed);
		}
	}
	[Token(Token = "0x200002B")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x303A34", Offset = "0x303A34")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x303A34", Offset = "0x303A34")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x2000056")]
		private enum TriggerZoneUpdateRate
		{
			[Token(Token = "0x4000209")]
			OnEnable,
			[Token(Token = "0x400020A")]
			OnOcclusionChange
		}

		[Token(Token = "0x40000D6")]
		public const string ClassName = "TriggerZone";

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0xC")]
		public bool setIsTrigger;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x10")]
		public float rangeMultiplier;

		[Token(Token = "0x40000D9")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x14")]
		private VolumetricLightBeam m_Beam;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x18")]
		private DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x1C")]
		private PolygonCollider2D m_PolygonCollider2D;

		[Token(Token = "0x17000025")]
		private TriggerZoneUpdateRate updateRate
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x1138750", Offset = "0x1138750", VA = "0x1138750")]
			get
			{
				return default(TriggerZoneUpdateRate);
			}
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x11387F8", Offset = "0x11387F8", VA = "0x11387F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x113928C", Offset = "0x113928C", VA = "0x113928C")]
		private void OnOcclusionProcessed()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1138944", Offset = "0x1138944", VA = "0x1138944")]
		private void ComputeZone()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1139438", Offset = "0x1139438", VA = "0x1139438")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public static class Utils
	{
		[Token(Token = "0x2000057")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x400020C")]
			High = 64,
			[Token(Token = "0x400020D")]
			Low = 8,
			[Token(Token = "0x400020E")]
			Undef = 0
		}

		[Token(Token = "0x40000DD")]
		private const float kEpsilon = 1E-05f;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x40000DF")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1139450", Offset = "0x1139450", VA = "0x1139450")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x60000D6")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x112A1B8", Offset = "0x112A1B8", VA = "0x112A1B8")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x11394FC", Offset = "0x11394FC", VA = "0x11394FC")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1139604", Offset = "0x1139604", VA = "0x1139604")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1139624", Offset = "0x1139624", VA = "0x1139624")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1139648", Offset = "0x1139648", VA = "0x1139648")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1139670", Offset = "0x1139670", VA = "0x1139670")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x113969C", Offset = "0x113969C", VA = "0x113969C")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x11396C4", Offset = "0x11396C4", VA = "0x11396C4")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x11396E8", Offset = "0x11396E8", VA = "0x11396E8")]
		public static bool Approximately(float a, float b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x113978C", Offset = "0x113978C", VA = "0x113978C")]
		public static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1139860", Offset = "0x1139860", VA = "0x1139860")]
		public static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1139948", Offset = "0x1139948", VA = "0x1139948")]
		public static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1139A4C", Offset = "0x1139A4C", VA = "0x1139A4C")]
		public static Vector4 AsVector4(this Vector3 vec3, float w)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1139A7C", Offset = "0x1139A7C", VA = "0x1139A7C")]
		public static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1139B9C", Offset = "0x1139B9C", VA = "0x1139B9C")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x113388C", Offset = "0x113388C", VA = "0x113388C")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1139C14", Offset = "0x1139C14", VA = "0x1139C14")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1134C48", Offset = "0x1134C48", VA = "0x1134C48")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1139330", Offset = "0x1139330", VA = "0x1139330")]
		public static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x11374A8", Offset = "0x11374A8", VA = "0x11374A8")]
		public static bool IsAlmostZero(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1132C14", Offset = "0x1132C14", VA = "0x1132C14")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x112DB74", Offset = "0x112DB74", VA = "0x112DB74")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1139C44", Offset = "0x1139C44", VA = "0x1139C44")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x112E190", Offset = "0x112E190", VA = "0x112E190")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1139D84", Offset = "0x1139D84", VA = "0x1139D84")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1139ED0", Offset = "0x1139ED0", VA = "0x1139ED0")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1139C5C", Offset = "0x1139C5C", VA = "0x1139C5C")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x112CC50", Offset = "0x112CC50", VA = "0x112CC50")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1139FAC", Offset = "0x1139FAC", VA = "0x1139FAC")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1139FB0", Offset = "0x1139FB0", VA = "0x1139FB0")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x200002D")]
	public static class Version
	{
		[Token(Token = "0x40000E0")]
		public const int Current = 1950;
	}
	[Token(Token = "0x200002E")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x303AEC", Offset = "0x303AEC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x303AEC", Offset = "0x303AEC")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x40000E1")]
		public const string ClassName = "VolumetricDustParticles";

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x304080", Offset = "0x304080")]
		public float alpha;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x304098", Offset = "0x304098")]
		public float size;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x14")]
		public ParticlesDirection direction;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 velocity;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x3040B8", Offset = "0x3040B8")]
		public float speed;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x28")]
		public float density;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "MinMaxRangeAttribute", RVA = "0x3040EC", Offset = "0x3040EC")]
		public MinMaxRangeFloat spawnDistanceRange;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x304104", Offset = "0x304104")]
		public float spawnMinDistance;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x304138", Offset = "0x304138")]
		public float spawnMaxDistance;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x3C")]
		public bool cullingEnabled;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x40")]
		public float cullingMaxDistance;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x30416C", Offset = "0x30416C")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float m_AlphaAdditionalRuntime;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x4C")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x50")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x54")]
		private Material m_Material;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x58")]
		private Gradient m_GradientCached;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_RuntimePropertiesDirty;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x0")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x4")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x60")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x17000026")]
		public bool isCulled
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1139FB8", Offset = "0x1139FB8", VA = "0x1139FB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x304BCC", Offset = "0x304BCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1139FC0", Offset = "0x1139FC0", VA = "0x1139FC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x304BDC", Offset = "0x304BDC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public float alphaAdditionalRuntime
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x1139FC8", Offset = "0x1139FC8", VA = "0x1139FC8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x11353F8", Offset = "0x11353F8", VA = "0x11353F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x1139FD0", Offset = "0x1139FD0", VA = "0x1139FD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000029")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x113A050", Offset = "0x113A050", VA = "0x113A050")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002A")]
		public int particlesMaxCount
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x113A0FC", Offset = "0x113A0FC", VA = "0x113A0FC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002B")]
		public Camera mainCamera
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x113A1C8", Offset = "0x113A1C8", VA = "0x113A1C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x113A490", Offset = "0x113A490", VA = "0x113A490")]
		private void Start()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x113A638", Offset = "0x113A638", VA = "0x113A638")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x113A944", Offset = "0x113A944", VA = "0x113A944")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x113A964", Offset = "0x113A964", VA = "0x113A964")]
		private void SetActive(bool active)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x113A924", Offset = "0x113A924", VA = "0x113A924")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x113AA30", Offset = "0x113AA30", VA = "0x113AA30")]
		private void Play()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x113B4A0", Offset = "0x113B4A0", VA = "0x113B4A0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x113B4A8", Offset = "0x113B4A8", VA = "0x113B4A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x113B5F4", Offset = "0x113B5F4", VA = "0x113B5F4")]
		private void Update()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x113AB00", Offset = "0x113AB00", VA = "0x113AB00")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x113A534", Offset = "0x113A534", VA = "0x113A534")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x113B754", Offset = "0x113B754", VA = "0x113B754")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x113BC60", Offset = "0x113BC60", VA = "0x113BC60")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x303BA4", Offset = "0x303BA4")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x2000058")]
		public delegate void OnWillCameraRenderCB(Camera cam);

		[Token(Token = "0x2000059")]
		public delegate void OnBeamGeometryInitialized();

		[Token(Token = "0x200005A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x303DB0", Offset = "0x303DB0")]
		private sealed class <CoPlaytimeUpdate>d__187 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400020F")]
			[FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x4000210")]
			[FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x4000211")]
			[FieldOffset(Offset = "0x10")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x17000075")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x113DE88", Offset = "0x113DE88", VA = "0x113DE88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000076")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0x113DF08", Offset = "0x113DF08", VA = "0x113DF08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x113D7F8", Offset = "0x113D7F8", VA = "0x113D7F8")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__187(int <>1__state)
			{
			}

			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x113DDFC", Offset = "0x113DDFC", VA = "0x113DDFC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x113DE00", Offset = "0x113DE00", VA = "0x113DE00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x113DE90", Offset = "0x113DE90", VA = "0x113DE90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000F7")]
		public const string ClassName = "VolumetricLightBeam";

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0xC")]
		public bool colorFromLight;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x10")]
		public ColorMode colorMode;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x30418C", Offset = "0x30418C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x30418C", Offset = "0x30418C")]
		public Color color;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x24")]
		public Gradient colorGradient;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x28")]
		public bool intensityFromLight;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x29")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x3041DC", Offset = "0x3041DC")]
		public float intensityInside;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x304210", Offset = "0x304210")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x304210", Offset = "0x304210")]
		public float intensityOutside;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x34")]
		public BlendingMode blendingMode;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x304270", Offset = "0x304270")]
		public bool spotAngleFromLight;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3042A4", Offset = "0x3042A4")]
		public float spotAngle;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x3042C4", Offset = "0x3042C4")]
		public float coneRadiusStart;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x44")]
		public ShaderAccuracy shaderAccuracy;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x48")]
		public MeshType geomMeshType;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x3042F8", Offset = "0x3042F8")]
		public int geomCustomSides;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x50")]
		public int geomCustomSegments;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 skewingLocalForwardDirection;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x60")]
		public Transform clippingPlaneTransform;

		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x64")]
		public bool geomCap;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x65")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x30432C", Offset = "0x30432C")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x68")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x304360", Offset = "0x304360")]
		public float attenuationCustomBlending;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x304378", Offset = "0x304378")]
		public float fallOffStart;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x3043AC", Offset = "0x3043AC")]
		public float fallOffEnd;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x78")]
		public float depthBlendDistance;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x7C")]
		public float cameraClippingDistance;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3043E0", Offset = "0x3043E0")]
		public float glareFrontal;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3043F8", Offset = "0x3043F8")]
		public float glareBehind;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x304410", Offset = "0x304410")]
		public float fresnelPow;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x8C")]
		public NoiseMode noiseMode;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x304444", Offset = "0x304444")]
		public float noiseIntensity;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x94")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x30445C", Offset = "0x30445C")]
		public float noiseScaleLocal;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x9C")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0xAC")]
		public Dimensions dimensions;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0xB0")]
		public Vector2 tiltFactor;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0xB8")]
		private MaterialManager.DynamicOcclusion m_INTERNAL_DynamicOcclusionMode;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0xBC")]
		private bool m_INTERNAL_DynamicOcclusionMode_Runtime;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0xC4")]
		private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x304498", Offset = "0x304498")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x304500", Offset = "0x304500")]
		[SerializeField]
		private float _FadeOutBegin;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x304548", Offset = "0x304548")]
		[SerializeField]
		private float _FadeOutEnd;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x304590", Offset = "0x304590")]
		private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0xE4")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0xE8")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0xEC")]
		private Light m_CachedLight;

		[Token(Token = "0x1700002C")]
		public ColorMode usedColorMode
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x112E0FC", Offset = "0x112E0FC", VA = "0x112E0FC")]
			get
			{
				return default(ColorMode);
			}
		}

		[Token(Token = "0x1700002D")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x304F34", Offset = "0x304F34")]
		public float alphaInside
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x113BD84", Offset = "0x113BD84", VA = "0x113BD84")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x113BD8C", Offset = "0x113BD8C", VA = "0x113BD8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x304F68", Offset = "0x304F68")]
		public float alphaOutside
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x113BD94", Offset = "0x113BD94", VA = "0x113BD94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x113BD9C", Offset = "0x113BD9C", VA = "0x113BD9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public float intensityGlobal
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x113BDA4", Offset = "0x113BDA4", VA = "0x113BDA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x113BDAC", Offset = "0x113BDAC", VA = "0x113BDAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public float coneAngle
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x112DFDC", Offset = "0x112DFDC", VA = "0x112DFDC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000031")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x112C750", Offset = "0x112C750", VA = "0x112C750")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000032")]
		public float coneVolume
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x113BDB8", Offset = "0x113BDB8", VA = "0x113BDB8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000033")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x112E09C", Offset = "0x112E09C", VA = "0x112E09C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000034")]
		public int geomSides
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x1139290", Offset = "0x1139290", VA = "0x1139290")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x113BE00", Offset = "0x113BE00", VA = "0x113BE00")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public int geomSegments
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x113BE90", Offset = "0x113BE90", VA = "0x113BE90")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x113BF30", Offset = "0x113BF30", VA = "0x113BF30")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Vector3 skewingLocalForwardDirectionNormalized
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x112E6AC", Offset = "0x112E6AC", VA = "0x112E6AC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000037")]
		public Vector4 additionalClippingPlane
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x112E374", Offset = "0x112E374", VA = "0x112E374")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000038")]
		public bool canHaveMeshSkewing
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x113841C", Offset = "0x113841C", VA = "0x113841C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public bool hasMeshSkewing
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x112CD54", Offset = "0x112CD54", VA = "0x112CD54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003A")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x304F9C", Offset = "0x304F9C")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x113BFC0", Offset = "0x113BFC0", VA = "0x113BFC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x113BFC8", Offset = "0x113BFC8", VA = "0x113BFC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x112E348", Offset = "0x112E348", VA = "0x112E348")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x304FD0", Offset = "0x304FD0")]
		public float fadeStart
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x113BFD0", Offset = "0x113BFD0", VA = "0x113BFD0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x113BFD8", Offset = "0x113BFD8", VA = "0x113BFD8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x305004", Offset = "0x305004")]
		public float fadeEnd
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x113BFE0", Offset = "0x113BFE0", VA = "0x113BFE0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x113BFE8", Offset = "0x113BFE8", VA = "0x113BFE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public float maxGeometryDistance
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x112C7E4", Offset = "0x112C7E4", VA = "0x112C7E4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003F")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x1128854", Offset = "0x1128854", VA = "0x1128854")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x305038", Offset = "0x305038")]
		public bool noiseEnabled
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x113BFF0", Offset = "0x113BFF0", VA = "0x113BFF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x113C000", Offset = "0x113C000", VA = "0x113C000")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public float fadeOutBegin
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x113C024", Offset = "0x113C024", VA = "0x113C024")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x113C02C", Offset = "0x113C02C", VA = "0x113C02C")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public float fadeOutEnd
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x113C0AC", Offset = "0x113C0AC", VA = "0x113C0AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x113C0B4", Offset = "0x113C0B4", VA = "0x113C0B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x1128BD8", Offset = "0x1128BD8", VA = "0x1128BD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		public bool isTilted
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x113C0C0", Offset = "0x113C0C0", VA = "0x113C0C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x113C19C", Offset = "0x113C19C", VA = "0x113C19C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x113C1A4", Offset = "0x113C1A4", VA = "0x113C1A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public string sortingLayerName
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x113C268", Offset = "0x113C268", VA = "0x113C268")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x113C274", Offset = "0x113C274", VA = "0x113C274")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public int sortingOrder
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x113C29C", Offset = "0x113C29C", VA = "0x113C29C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x113C2A4", Offset = "0x113C2A4", VA = "0x113C2A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x113C368", Offset = "0x113C368", VA = "0x113C368")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x113C370", Offset = "0x113C370", VA = "0x113C370")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x113C3CC", Offset = "0x113C3CC", VA = "0x113C3CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		public bool hasGeometry
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x113BA84", Offset = "0x113BA84", VA = "0x113BA84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		public Bounds bounds
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x113BB08", Offset = "0x113BB08", VA = "0x113BB08")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x1700004C")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x113C3DC", Offset = "0x113C3DC", VA = "0x113C3DC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004D")]
		public Quaternion beamInternalLocalRotation
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x112C888", Offset = "0x112C888", VA = "0x112C888")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700004E")]
		public Vector3 beamLocalForward
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1131E24", Offset = "0x1131E24", VA = "0x1131E24")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004F")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1131EDC", Offset = "0x1131EDC", VA = "0x1131EDC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000050")]
		public float raycastDistance
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x11330C0", Offset = "0x11330C0", VA = "0x11330C0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000051")]
		public Vector3 raycastGlobalForward
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x1134518", Offset = "0x1134518", VA = "0x1134518")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000052")]
		public Vector3 raycastGlobalUp
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x1133CA0", Offset = "0x1133CA0", VA = "0x1133CA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 raycastGlobalRight
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x1133D78", Offset = "0x1133D78", VA = "0x1133D78")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000054")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x11296B0", Offset = "0x11296B0", VA = "0x11296B0")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x113C508", Offset = "0x113C508", VA = "0x113C508")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x112CD40", Offset = "0x112CD40", VA = "0x112CD40")]
			get
			{
				return default(MaterialManager.DynamicOcclusion);
			}
		}

		[Token(Token = "0x17000056")]
		public int _INTERNAL_pluginVersion
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x113CB94", Offset = "0x113CB94", VA = "0x113CB94")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000057")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x113CC60", Offset = "0x113CC60", VA = "0x113CC60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x304C0C", Offset = "0x304C0C")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x113CC68", Offset = "0x113CC68", VA = "0x113CC68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x304C1C", Offset = "0x304C1C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public string meshStats
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x113CC70", Offset = "0x113CC70", VA = "0x113CC70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public int meshVerticesCount
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x113CE3C", Offset = "0x113CE3C", VA = "0x113CE3C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005A")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x113CF40", Offset = "0x113CF40", VA = "0x113CF40")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005B")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x113D14C", Offset = "0x113D14C", VA = "0x113D14C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x1131230", Offset = "0x1131230", VA = "0x1131230")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x304BEC", Offset = "0x304BEC")]
			add
			{
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x1131478", Offset = "0x1131478", VA = "0x1131478")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x304BFC", Offset = "0x304BFC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x112E318", Offset = "0x112E318", VA = "0x112E318")]
		public void GetInsideAndOutsideIntensity(out float inside, out float outside)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1130D54", Offset = "0x1130D54", VA = "0x1130D54")]
		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x112F35C", Offset = "0x112F35C", VA = "0x112F35C")]
		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x11312F4", Offset = "0x11312F4", VA = "0x11312F4")]
		public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x113C934", Offset = "0x113C934", VA = "0x113C934")]
		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x113C038", Offset = "0x113C038", VA = "0x113C038")]
		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x113CB9C", Offset = "0x113CB9C", VA = "0x113CB9C")]
		private void OnFadeOutStateChanged()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x113D06C", Offset = "0x113D06C", VA = "0x113D06C")]
		private Light GetLightSpotAttached()
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x113D134", Offset = "0x113D134", VA = "0x113D134")]
		private void InitLightSpotAttachedCached()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x113D154", Offset = "0x113D154", VA = "0x113D154")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x112F36C", Offset = "0x112F36C", VA = "0x112F36C")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x113D1BC", Offset = "0x113D1BC", VA = "0x113D1BC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x304C2C", Offset = "0x304C2C")]
		public void Generate()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x113D1CC", Offset = "0x113D1CC", VA = "0x113D1CC", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x113D518", Offset = "0x113D518", VA = "0x113D518", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x113D5CC", Offset = "0x113D5CC", VA = "0x113D5CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x113D5F8", Offset = "0x113D5F8", VA = "0x113D5F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x113D6B8", Offset = "0x113D6B8", VA = "0x113D6B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x113C378", Offset = "0x113C378", VA = "0x113C378")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x113D778", Offset = "0x113D778", VA = "0x113D778")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x304C60", Offset = "0x304C60")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x113D818", Offset = "0x113D818", VA = "0x113D818")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x113D81C", Offset = "0x113D81C", VA = "0x113D81C")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x113D8F8", Offset = "0x113D8F8", VA = "0x113D8F8")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x113DA70", Offset = "0x113DA70", VA = "0x113DA70")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x113D4F8", Offset = "0x113D4F8", VA = "0x113D4F8")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x113D364", Offset = "0x113D364", VA = "0x113D364")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x113DC70", Offset = "0x113DC70", VA = "0x113DC70")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x303C0C", Offset = "0x303C0C")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x113DF78", Offset = "0x113DF78", VA = "0x113DF78")]
		private void Update()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x113E0B0", Offset = "0x113E0B0", VA = "0x113E0B0")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x303C7C", Offset = "0x303C7C")]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0xC")]
		private bool isInsideBeam;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x10")]
		private Material m_Material;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x14")]
		private Collider m_Collider;

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x113E0C0", Offset = "0x113E0C0", VA = "0x113E0C0")]
		private void Start()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x113E198", Offset = "0x113E198", VA = "0x113E198")]
		private void Update()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x113E2A0", Offset = "0x113E2A0", VA = "0x113E2A0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x113E2AC", Offset = "0x113E2AC", VA = "0x113E2AC")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x113E384", Offset = "0x113E384", VA = "0x113E384")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x113E38C", Offset = "0x113E38C", VA = "0x113E38C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x113E464", Offset = "0x113E464", VA = "0x113E464")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0xC")]
		public float cameraSensitivity;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x10")]
		public float speedNormal;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x14")]
		public float speedFactorSlow;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x18")]
		public float speedFactorFast;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x1C")]
		public float speedClimb;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x20")]
		private float rotationH;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x24")]
		private float rotationV;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x28")]
		private bool m_UseMouseView;

		[Token(Token = "0x1700005C")]
		private bool useMouseView
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x113E46C", Offset = "0x113E46C", VA = "0x113E46C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x113E474", Offset = "0x113E474", VA = "0x113E474")]
			set
			{
			}
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x113E4A0", Offset = "0x113E4A0", VA = "0x113E4A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x113E55C", Offset = "0x113E55C", VA = "0x113E55C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x113ED30", Offset = "0x113ED30", VA = "0x113ED30")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3045B0", Offset = "0x3045B0")]
		[SerializeField]
		private int CountX;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3045EC", Offset = "0x3045EC")]
		[SerializeField]
		private int CountY;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x1D")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x113ED70", Offset = "0x113ED70", VA = "0x113ED70")]
		public void Generate()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x113FA60", Offset = "0x113FA60", VA = "0x113FA60")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x304668", Offset = "0x304668")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x113FA88", Offset = "0x113FA88", VA = "0x113FA88")]
		private void Update()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x113FC50", Offset = "0x113FC50", VA = "0x113FC50")]
		public Rotater()
		{
		}
	}
}
