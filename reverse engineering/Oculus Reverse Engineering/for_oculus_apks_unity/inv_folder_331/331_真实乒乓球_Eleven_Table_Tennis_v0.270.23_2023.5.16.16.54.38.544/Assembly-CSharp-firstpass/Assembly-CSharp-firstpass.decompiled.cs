using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using DG.Tweening.Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace VLB
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xEB747C", Offset = "0xEB747C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xEB747C", Offset = "0xEB747C")]
	public class BeamGeometry : MonoBehaviour
	{
		[Token(Token = "0x2000028")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB7984", Offset = "0xEB7984")]
		private sealed class <CoUpdateFadeOut>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400013F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000140")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000141")]
			[FieldOffset(Offset = "0x20")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x1700003E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000117")]
				[Address(RVA = "0x38D0648", Offset = "0x38D0648", VA = "0x38D0648", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000119")]
				[Address(RVA = "0x38D0690", Offset = "0x38D0690", VA = "0x38D0690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000114")]
			[Address(RVA = "0x38C2360", Offset = "0x38C2360", VA = "0x38C2360")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000115")]
			[Address(RVA = "0x38D05C8", Offset = "0x38D05C8", VA = "0x38D05C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000116")]
			[Address(RVA = "0x38D05CC", Offset = "0x38D05CC", VA = "0x38D05CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000118")]
			[Address(RVA = "0x38D0650", Offset = "0x38D0650", VA = "0x38D0650", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB79A4", Offset = "0xEB79A4")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB79B4", Offset = "0xEB79B4")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB79C4", Offset = "0xEB79C4")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x88")]
		private DynamicOcclusion _dynamicOcclusion;

		[Token(Token = "0x17000001")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x38C2114", Offset = "0x38C2114", VA = "0x38C2114")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB80D4", Offset = "0xEB80D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x38C211C", Offset = "0x38C211C", VA = "0x38C211C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB80E4", Offset = "0xEB80E4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x38C2124", Offset = "0x38C2124", VA = "0x38C2124")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB80F4", Offset = "0xEB80F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x38C212C", Offset = "0x38C212C", VA = "0x38C212C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB8104", Offset = "0xEB8104")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public Mesh coneMesh
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x38C2134", Offset = "0x38C2134", VA = "0x38C2134")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB8114", Offset = "0xEB8114")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x38C213C", Offset = "0x38C213C", VA = "0x38C213C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB8124", Offset = "0xEB8124")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public bool visible
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x38C2144", Offset = "0x38C2144", VA = "0x38C2144")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x38C2160", Offset = "0x38C2160", VA = "0x38C2160")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x38C2180", Offset = "0x38C2180", VA = "0x38C2180")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x38C219C", Offset = "0x38C219C", VA = "0x38C219C")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public int sortingOrder
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x38C21B8", Offset = "0x38C21B8", VA = "0x38C21B8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x38C21D4", Offset = "0x38C21D4", VA = "0x38C21D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x38C2C8C", Offset = "0x38C2C8C", VA = "0x38C2C8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x38C4CA8", Offset = "0x38C4CA8", VA = "0x38C4CA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		private bool isClippingPlaneEnabled
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x38C4E9C", Offset = "0x38C4E9C", VA = "0x38C4E9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x38C4F68", Offset = "0x38C4F68", VA = "0x38C4F68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public DynamicOcclusion dynamicOcclusion
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x38C5F10", Offset = "0x38C5F10", VA = "0x38C5F10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x38C5F18", Offset = "0x38C5F18", VA = "0x38C5F18")]
			set
			{
			}
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x38C21F0", Offset = "0x38C21F0", VA = "0x38C21F0")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x38C22E8", Offset = "0x38C22E8", VA = "0x38C22E8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xEB8134", Offset = "0xEB8134")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x38C238C", Offset = "0x38C238C", VA = "0x38C238C")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x38C2578", Offset = "0x38C2578", VA = "0x38C2578")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x38C2898", Offset = "0x38C2898", VA = "0x38C2898")]
		private void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x38C294C", Offset = "0x38C294C", VA = "0x38C294C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x38C2A08", Offset = "0x38C2A08", VA = "0x38C2A08")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x38C2AC4", Offset = "0x38C2AC4", VA = "0x38C2AC4")]
		private static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x38C2BBC", Offset = "0x38C2BBC", VA = "0x38C2BBC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x38C2C94", Offset = "0x38C2C94", VA = "0x38C2C94")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x38C2D6C", Offset = "0x38C2D6C", VA = "0x38C2D6C")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x38C36E0", Offset = "0x38C36E0", VA = "0x38C36E0")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x38C4BAC", Offset = "0x38C4BAC", VA = "0x38C4BAC")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x38C3390", Offset = "0x38C3390", VA = "0x38C3390")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x38C26D0", Offset = "0x38C26D0", VA = "0x38C26D0")]
		private void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x38C5614", Offset = "0x38C5614", VA = "0x38C5614")]
		private void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x38C5740", Offset = "0x38C5740", VA = "0x38C5740")]
		private void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x38C586C", Offset = "0x38C586C", VA = "0x38C586C")]
		private void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x38C2604", Offset = "0x38C2604", VA = "0x38C2604")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x38C27CC", Offset = "0x38C27CC", VA = "0x38C27CC")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x38C59A0", Offset = "0x38C59A0", VA = "0x38C59A0")]
		private void SendMaterialClippingPlaneProp()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x38C44A8", Offset = "0x38C44A8", VA = "0x38C44A8")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x38C6080", Offset = "0x38C6080", VA = "0x38C6080")]
		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x38C63B4", Offset = "0x38C63B4", VA = "0x38C63B4")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x38C6450", Offset = "0x38C6450", VA = "0x38C6450")]
		private static bool IsEditorCamera(Camera cam)
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x38C6088", Offset = "0x38C6088", VA = "0x38C6088")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x38C65B0", Offset = "0x38C65B0", VA = "0x38C65B0")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xEB74EC", Offset = "0xEB74EC")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x2C")]
		public RenderPipeline renderPipeline;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xEB79D4", Offset = "0xEB79D4")]
		public bool forceSinglePass;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x34")]
		public RenderingMode renderingMode;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader1Pass;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xEB7A44", Offset = "0xEB7A44")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xEB7A44", Offset = "0xEB7A44")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader2Pass;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x48")]
		public int sharedMeshSides;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x4C")]
		public int sharedMeshSegments;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xEB7AC4", Offset = "0xEB7AC4")]
		public float globalNoiseScale;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x60")]
		public string fadeOutCameraTag;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x68")]
		[HighlightNull]
		public TextAsset noise3DData;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x70")]
		public int noise3DSize;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x78")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x88")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x400001C")]
		private const string kAssetName = "Config";

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x0")]
		private static Config m_Instance;

		[Token(Token = "0x1700000C")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x38C31BC", Offset = "0x38C31BC", VA = "0x38C31BC")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x1700000D")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x38C3A18", Offset = "0x38C3A18", VA = "0x38C3A18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		public Shader beamShader
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x38C6AF8", Offset = "0x38C6AF8", VA = "0x38C6AF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x38C6B14", Offset = "0x38C6B14", VA = "0x38C6B14")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000010")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x38C24F8", Offset = "0x38C24F8", VA = "0x38C24F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public static Config Instance
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x38C249C", Offset = "0x38C249C", VA = "0x38C249C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x38C6B4C", Offset = "0x38C6B4C", VA = "0x38C6B4C")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x38C6BF8", Offset = "0x38C6BF8", VA = "0x38C6BF8")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xEB8194", Offset = "0xEB8194")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x38C6C74", Offset = "0x38C6C74", VA = "0x38C6C74")]
		public static void OnRenderPipelineChanged(RenderPipeline pipeline)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x38C6D18", Offset = "0x38C6D18", VA = "0x38C6D18")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x38C6F78", Offset = "0x38C6F78", VA = "0x38C6F78")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x38C7144", Offset = "0x38C7144", VA = "0x38C7144")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x38C7174", Offset = "0x38C7174", VA = "0x38C7174")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x38C7210", Offset = "0x38C7210", VA = "0x38C7210")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x38C73D4", Offset = "0x38C73D4", VA = "0x38C73D4")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xEB7524", Offset = "0xEB7524")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x400001E")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x38C74D4", Offset = "0x38C74D4", VA = "0x38C74D4")]
		public ConfigOverride()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public static class Consts
	{
		[Token(Token = "0x400001F")]
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		[Token(Token = "0x4000020")]
		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		[Token(Token = "0x4000021")]
		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		[Token(Token = "0x4000022")]
		public const string HelpUrlDynamicOcclusion = "http://saladgamer.com/vlb-doc/comp-dynocclusion/";

		[Token(Token = "0x4000023")]
		public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

		[Token(Token = "0x4000024")]
		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x0")]
		public static readonly bool ProceduralObjectsVisibleInEditor;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x4")]
		public static readonly Color FlatColor;

		[Token(Token = "0x4000027")]
		public const ColorMode ColorModeDefault = ColorMode.Flat;

		[Token(Token = "0x4000028")]
		public const float IntensityDefault = 1f;

		[Token(Token = "0x4000029")]
		public const float IntensityMin = 0f;

		[Token(Token = "0x400002A")]
		public const float IntensityMax = 8f;

		[Token(Token = "0x400002B")]
		public const float SpotAngleDefault = 35f;

		[Token(Token = "0x400002C")]
		public const float SpotAngleMin = 0.1f;

		[Token(Token = "0x400002D")]
		public const float SpotAngleMax = 179.9f;

		[Token(Token = "0x400002E")]
		public const float ConeRadiusStart = 0.1f;

		[Token(Token = "0x400002F")]
		public const MeshType GeomMeshType = MeshType.Shared;

		[Token(Token = "0x4000030")]
		public const int GeomSidesDefault = 18;

		[Token(Token = "0x4000031")]
		public const int GeomSidesMin = 3;

		[Token(Token = "0x4000032")]
		public const int GeomSidesMax = 256;

		[Token(Token = "0x4000033")]
		public const int GeomSegmentsDefault = 5;

		[Token(Token = "0x4000034")]
		public const int GeomSegmentsMin = 0;

		[Token(Token = "0x4000035")]
		public const int GeomSegmentsMax = 64;

		[Token(Token = "0x4000036")]
		public const bool GeomCap = false;

		[Token(Token = "0x4000037")]
		public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

		[Token(Token = "0x4000038")]
		public const float AttenuationCustomBlending = 0.5f;

		[Token(Token = "0x4000039")]
		public const float FallOffStart = 0f;

		[Token(Token = "0x400003A")]
		public const float FallOffEnd = 3f;

		[Token(Token = "0x400003B")]
		public const float FallOffDistancesMinThreshold = 0.01f;

		[Token(Token = "0x400003C")]
		public const float DepthBlendDistance = 2f;

		[Token(Token = "0x400003D")]
		public const float CameraClippingDistance = 0.5f;

		[Token(Token = "0x400003E")]
		public const float FresnelPowMaxValue = 10f;

		[Token(Token = "0x400003F")]
		public const float FresnelPow = 8f;

		[Token(Token = "0x4000040")]
		public const float GlareFrontal = 0.5f;

		[Token(Token = "0x4000041")]
		public const float GlareBehind = 0.5f;

		[Token(Token = "0x4000042")]
		public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

		[Token(Token = "0x4000043")]
		public const float NoiseIntensityMin = 0f;

		[Token(Token = "0x4000044")]
		public const float NoiseIntensityMax = 1f;

		[Token(Token = "0x4000045")]
		public const float NoiseIntensityDefault = 0.5f;

		[Token(Token = "0x4000046")]
		public const float NoiseScaleMin = 0.01f;

		[Token(Token = "0x4000047")]
		public const float NoiseScaleMax = 2f;

		[Token(Token = "0x4000048")]
		public const float NoiseScaleDefault = 0.5f;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x14")]
		public static readonly Vector3 NoiseVelocityDefault;

		[Token(Token = "0x400004A")]
		public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

		[Token(Token = "0x400004B")]
		public const OccluderDimensions DynOcclusionDimensionsDefault = OccluderDimensions.Occluders3D;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x20")]
		public static readonly LayerMask DynOcclusionLayerMaskDefault;

		[Token(Token = "0x400004D")]
		public const bool DynOcclusionConsiderTriggersDefault = false;

		[Token(Token = "0x400004E")]
		public const float DynOcclusionMinOccluderAreaDefault = 0f;

		[Token(Token = "0x400004F")]
		public const int DynOcclusionWaitFrameCountDefault = 3;

		[Token(Token = "0x4000050")]
		public const float DynOcclusionMinSurfaceRatioDefault = 0.5f;

		[Token(Token = "0x4000051")]
		public const float DynOcclusionMinSurfaceRatioMin = 50f;

		[Token(Token = "0x4000052")]
		public const float DynOcclusionMinSurfaceRatioMax = 100f;

		[Token(Token = "0x4000053")]
		public const float DynOcclusionMaxSurfaceDotDefault = 0.25f;

		[Token(Token = "0x4000054")]
		public const float DynOcclusionMaxSurfaceAngleMin = 45f;

		[Token(Token = "0x4000055")]
		public const float DynOcclusionMaxSurfaceAngleMax = 90f;

		[Token(Token = "0x4000056")]
		public const PlaneAlignment DynOcclusionPlaneAlignmentDefault = PlaneAlignment.Surface;

		[Token(Token = "0x4000057")]
		public const float DynOcclusionPlaneOffsetDefault = 0.1f;

		[Token(Token = "0x4000058")]
		public const float DynOcclusionFadeDistanceToPlaneDefault = 0.25f;

		[Token(Token = "0x4000059")]
		public const bool ConfigGeometryOverrideLayerDefault = true;

		[Token(Token = "0x400005A")]
		public const int ConfigGeometryLayerIDDefault = 1;

		[Token(Token = "0x400005B")]
		public const string ConfigGeometryTagDefault = "Untagged";

		[Token(Token = "0x400005C")]
		public const string ConfigFadeOutCameraTagDefault = "MainCamera";

		[Token(Token = "0x400005D")]
		public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

		[Token(Token = "0x400005E")]
		public const RenderPipeline ConfigGeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

		[Token(Token = "0x400005F")]
		public const RenderingMode ConfigGeometryRenderingModeDefault = RenderingMode.MultiPass;

		[Token(Token = "0x4000060")]
		public const int ConfigNoise3DSizeDefault = 64;

		[Token(Token = "0x4000061")]
		public const int ConfigSharedMeshSides = 24;

		[Token(Token = "0x4000062")]
		public const int ConfigSharedMeshSegments = 5;

		[Token(Token = "0x17000012")]
		public static HideFlags ProceduralObjectsHideFlags
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x38C314C", Offset = "0x38C314C", VA = "0x38C314C")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x2000006")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xEB755C", Offset = "0xEB755C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xEB755C", Offset = "0xEB755C")]
	public class DynamicOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000029")]
		public class HitResult
		{
			[Token(Token = "0x4000142")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000143")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 normal;

			[Token(Token = "0x4000144")]
			[FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000145")]
			[FieldOffset(Offset = "0x30")]
			private Collider2D collider2D;

			[Token(Token = "0x4000146")]
			[FieldOffset(Offset = "0x38")]
			private Collider collider3D;

			[Token(Token = "0x17000040")]
			public bool hasCollider
			{
				[Token(Token = "0x600011D")]
				[Address(RVA = "0x38CACEC", Offset = "0x38CACEC", VA = "0x38CACEC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000041")]
			public string name
			{
				[Token(Token = "0x600011E")]
				[Address(RVA = "0x38D0698", Offset = "0x38D0698", VA = "0x38D0698")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000042")]
			public Bounds bounds
			{
				[Token(Token = "0x600011F")]
				[Address(RVA = "0x38D077C", Offset = "0x38D077C", VA = "0x38D077C")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x600011A")]
			[Address(RVA = "0x38CA968", Offset = "0x38CA968", VA = "0x38CA968")]
			public HitResult(RaycastHit hit3D)
			{
			}

			[Token(Token = "0x600011B")]
			[Address(RVA = "0x38CAA54", Offset = "0x38CAA54", VA = "0x38CAA54")]
			public HitResult(RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x600011C")]
			[Address(RVA = "0x38CA9F0", Offset = "0x38CA9F0", VA = "0x38CA9F0")]
			public HitResult()
			{
			}
		}

		[Token(Token = "0x200002A")]
		private enum Direction
		{
			[Token(Token = "0x4000148")]
			Up,
			[Token(Token = "0x4000149")]
			Right,
			[Token(Token = "0x400014A")]
			Down,
			[Token(Token = "0x400014B")]
			Left
		}

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x18")]
		public OccluderDimensions dimensions;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x1C")]
		public LayerMask layerMask;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x20")]
		public bool considerTriggers;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x24")]
		public float minOccluderArea;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x28")]
		public int waitFrameCount;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x2C")]
		public float minSurfaceRatio;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x30")]
		public float maxSurfaceDot;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x34")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x38")]
		public float planeOffset;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x3C")]
		public float fadeDistanceToPlane;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB7B10", Offset = "0xEB7B10")]
		private HitResult <currentHit>k__BackingField;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x48")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x50")]
		private int m_FrameCountToWait;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x54")]
		private float m_RangeMultiplier;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB7B20", Offset = "0xEB7B20")]
		private Plane <planeEquationWS>k__BackingField;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x68")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x17000013")]
		public HitResult currentHit
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x38C9CF4", Offset = "0x38C9CF4", VA = "0x38C9CF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB81A4", Offset = "0xEB81A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x38C9CFC", Offset = "0x38C9CFC", VA = "0x38C9CFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB81B4", Offset = "0xEB81B4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x38C9D04", Offset = "0x38C9D04", VA = "0x38C9D04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB81C4", Offset = "0xEB81C4")]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x38C9D10", Offset = "0x38C9D10", VA = "0x38C9D10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB81D4", Offset = "0xEB81D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x38CA340", Offset = "0x38CA340", VA = "0x38CA340")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x17000016")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x38CA354", Offset = "0x38CA354", VA = "0x38CA354")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x38C9D1C", Offset = "0x38C9D1C", VA = "0x38C9D1C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x38C9D78", Offset = "0x38C9D78", VA = "0x38C9D78")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x38C9DE4", Offset = "0x38C9DE4", VA = "0x38C9DE4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x38C9E3C", Offset = "0x38C9E3C", VA = "0x38C9E3C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x38C9EF8", Offset = "0x38C9EF8", VA = "0x38C9EF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x38CA298", Offset = "0x38CA298", VA = "0x38CA298")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x38CA39C", Offset = "0x38CA39C", VA = "0x38CA39C")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x38CA3B0", Offset = "0x38CA3B0", VA = "0x38CA3B0")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x38CA620", Offset = "0x38CA620", VA = "0x38CA620")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x38CAADC", Offset = "0x38CAADC", VA = "0x38CAADC")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x38CAC60", Offset = "0x38CAC60", VA = "0x38CAC60")]
		private bool IsHitValid(HitResult hit)
		{
			return default(bool);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x38C9F38", Offset = "0x38C9F38", VA = "0x38C9F38")]
		private void ProcessRaycasts()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x38CAD9C", Offset = "0x38CAD9C", VA = "0x38CAD9C")]
		private void SetHit(HitResult hit)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x38C9E10", Offset = "0x38C9E10", VA = "0x38C9E10")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x38CAE48", Offset = "0x38CAE48", VA = "0x38CAE48")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x38CAF44", Offset = "0x38CAF44", VA = "0x38CAF44")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x38CB010", Offset = "0x38CB010", VA = "0x38CB010")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x38CB0B8", Offset = "0x38CB0B8", VA = "0x38CB0B8")]
		public DynamicOcclusion()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public enum ColorMode
	{
		[Token(Token = "0x4000074")]
		Flat,
		[Token(Token = "0x4000075")]
		Gradient
	}
	[Token(Token = "0x2000008")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x4000077")]
		Linear,
		[Token(Token = "0x4000078")]
		Quadratic,
		[Token(Token = "0x4000079")]
		Blend
	}
	[Token(Token = "0x2000009")]
	public enum BlendingMode
	{
		[Token(Token = "0x400007B")]
		Additive,
		[Token(Token = "0x400007C")]
		SoftAdditive,
		[Token(Token = "0x400007D")]
		TraditionalTransparency
	}
	[Token(Token = "0x200000A")]
	public enum NoiseMode
	{
		[Token(Token = "0x400007F")]
		Disabled,
		[Token(Token = "0x4000080")]
		WorldSpace,
		[Token(Token = "0x4000081")]
		LocalSpace
	}
	[Token(Token = "0x200000B")]
	public enum MeshType
	{
		[Token(Token = "0x4000083")]
		Shared,
		[Token(Token = "0x4000084")]
		Custom
	}
	[Token(Token = "0x200000C")]
	public enum RenderPipeline
	{
		[Token(Token = "0x4000086")]
		BuiltIn,
		[Token(Token = "0x4000087")]
		SRP_4_0_0_or_higher
	}
	[Token(Token = "0x200000D")]
	public enum RenderingMode
	{
		[Token(Token = "0x4000089")]
		MultiPass,
		[Token(Token = "0x400008A")]
		SinglePass,
		[Token(Token = "0x400008B")]
		GPUInstancing
	}
	[Token(Token = "0x200000E")]
	public enum RenderQueue
	{
		[Token(Token = "0x400008D")]
		Custom = 0,
		[Token(Token = "0x400008E")]
		Background = 1000,
		[Token(Token = "0x400008F")]
		Geometry = 2000,
		[Token(Token = "0x4000090")]
		AlphaTest = 2450,
		[Token(Token = "0x4000091")]
		GeometryLast = 2500,
		[Token(Token = "0x4000092")]
		Transparent = 3000,
		[Token(Token = "0x4000093")]
		Overlay = 4000
	}
	[Token(Token = "0x200000F")]
	public enum OccluderDimensions
	{
		[Token(Token = "0x4000095")]
		Occluders3D,
		[Token(Token = "0x4000096")]
		Occluders2D
	}
	[Token(Token = "0x2000010")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x4000098")]
		Surface,
		[Token(Token = "0x4000099")]
		Beam
	}
	[Token(Token = "0x2000011")]
	public enum FadeOutCameraMode
	{
		[Token(Token = "0x400009B")]
		MainCamera,
		[Token(Token = "0x400009C")]
		CustomObject
	}
	[Token(Token = "0x2000012")]
	public static class GlobalMesh
	{
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x38C426C", Offset = "0x38C426C", VA = "0x38C426C")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x38CB8FC", Offset = "0x38CB8FC", VA = "0x38CB8FC")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public static class GpuInstancing
	{
		[Token(Token = "0x400009F")]
		public const bool isSupported = true;

		[Token(Token = "0x17000017")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x38C4FAC", Offset = "0x38C4FAC", VA = "0x38C4FAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x38CBA1C", Offset = "0x38CBA1C", VA = "0x38CBA1C")]
		public static void SetMaterialProperties(Material material, bool enableInstancing)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x38CBAC0", Offset = "0x38CBAC0", VA = "0x38CBAC0")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x38CBC2C", Offset = "0x38CBC2C", VA = "0x38CBC2C")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reason)
		{
			return default(bool);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x38CBD70", Offset = "0x38CBD70", VA = "0x38CBD70")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x2000014")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x38CBE3C", Offset = "0x38CBE3C", VA = "0x38CBE3C")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class MaterialKeywordSRP
	{
		[Token(Token = "0x40000A0")]
		public const string kKeyword = "VLB_SRP_API";

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x38CC550", Offset = "0x38CC550", VA = "0x38CC550")]
		public MaterialKeywordSRP()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public static class MaterialManager
	{
		[Token(Token = "0x200002B")]
		public enum BlendingMode
		{
			[Token(Token = "0x400014D")]
			Additive,
			[Token(Token = "0x400014E")]
			SoftAdditive,
			[Token(Token = "0x400014F")]
			TraditionalTransparency,
			[Token(Token = "0x4000150")]
			Count
		}

		[Token(Token = "0x200002C")]
		public enum Noise3D
		{
			[Token(Token = "0x4000152")]
			Off,
			[Token(Token = "0x4000153")]
			On,
			[Token(Token = "0x4000154")]
			Count
		}

		[Token(Token = "0x200002D")]
		public enum DepthBlend
		{
			[Token(Token = "0x4000156")]
			Off,
			[Token(Token = "0x4000157")]
			On,
			[Token(Token = "0x4000158")]
			Count
		}

		[Token(Token = "0x200002E")]
		public enum ColorGradient
		{
			[Token(Token = "0x400015A")]
			Off,
			[Token(Token = "0x400015B")]
			MatrixLow,
			[Token(Token = "0x400015C")]
			MatrixHigh,
			[Token(Token = "0x400015D")]
			Count
		}

		[Token(Token = "0x200002F")]
		public enum ClippingPlane
		{
			[Token(Token = "0x400015F")]
			Off,
			[Token(Token = "0x4000160")]
			On,
			[Token(Token = "0x4000161")]
			Count
		}

		[Token(Token = "0x2000030")]
		public class StaticProperties
		{
			[Token(Token = "0x4000162")]
			[FieldOffset(Offset = "0x10")]
			public BlendingMode blendingMode;

			[Token(Token = "0x4000163")]
			[FieldOffset(Offset = "0x14")]
			public Noise3D noise3D;

			[Token(Token = "0x4000164")]
			[FieldOffset(Offset = "0x18")]
			public DepthBlend depthBlend;

			[Token(Token = "0x4000165")]
			[FieldOffset(Offset = "0x1C")]
			public ColorGradient colorGradient;

			[Token(Token = "0x4000166")]
			[FieldOffset(Offset = "0x20")]
			public ClippingPlane clippingPlane;

			[Token(Token = "0x17000043")]
			public int materialID
			{
				[Token(Token = "0x6000120")]
				[Address(RVA = "0x38CC5F4", Offset = "0x38CC5F4", VA = "0x38CC5F4")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000121")]
			[Address(RVA = "0x38C50F0", Offset = "0x38C50F0", VA = "0x38C50F0")]
			public void ApplyToMaterial(Material mat)
			{
			}

			[Token(Token = "0x6000122")]
			[Address(RVA = "0x38C50E8", Offset = "0x38C50E8", VA = "0x38C50E8")]
			public StaticProperties()
			{
			}
		}

		[Token(Token = "0x2000031")]
		private class MaterialsGroup
		{
			[Token(Token = "0x4000167")]
			[FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x6000123")]
			[Address(RVA = "0x38CC558", Offset = "0x38CC558", VA = "0x38CC558")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x20")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x38C31C4", Offset = "0x38C31C4", VA = "0x38C31C4")]
		public static Material NewMaterial(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x38C5358", Offset = "0x38C5358", VA = "0x38C5358")]
		public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x2000017")]
	public static class MeshGenerator
	{
		[Token(Token = "0x40000A7")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x38CC7E8", Offset = "0x38CC7E8", VA = "0x38CC7E8")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x38CC800", Offset = "0x38CC800", VA = "0x38CC800")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x38CC874", Offset = "0x38CC874", VA = "0x38CC874")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x38C3A28", Offset = "0x38C3A28", VA = "0x38C3A28")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x38CC8E4", Offset = "0x38CC8E4", VA = "0x38CC8E4")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x38CC900", Offset = "0x38CC900", VA = "0x38CC900")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x38CC928", Offset = "0x38CC928", VA = "0x38CC928")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x38CC9C0", Offset = "0x38CC9C0", VA = "0x38CC9C0")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000018")]
	public static class Noise3D
	{
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x40000AB")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x40000AC")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x17000018")]
		public static bool isSupported
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x38C4D44", Offset = "0x38C4D44", VA = "0x38C4D44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000019")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x38CCA5C", Offset = "0x38CCA5C", VA = "0x38CCA5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x38CB238", Offset = "0x38CB238", VA = "0x38CB238")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x38CCAFC", Offset = "0x38CCAFC", VA = "0x38CCAFC")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xEB81E4", Offset = "0xEB81E4")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x38C5CB4", Offset = "0x38C5CB4", VA = "0x38C5CB4")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x38CCB54", Offset = "0x38CCB54", VA = "0x38CCB54")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x2000019")]
	public static class ShaderProperties
	{
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int FadeOutFactor;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int ClippingPlaneWS;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int ClippingPlaneProps;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int ConeSlopeCosSin;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int ConeRadius;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int ConeApexOffsetZ;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int ColorFlat;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly int AlphaInside;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x20")]
		public static readonly int AlphaOutside;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x24")]
		public static readonly int AttenuationLerpLinearQuad;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x28")]
		public static readonly int DistanceFadeStart;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly int DistanceFadeEnd;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x30")]
		public static readonly int DistanceCamClipping;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x34")]
		public static readonly int FresnelPow;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x38")]
		public static readonly int GlareBehind;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x3C")]
		public static readonly int GlareFrontal;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x40")]
		public static readonly int DrawCap;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x44")]
		public static readonly int DepthBlendDistance;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x48")]
		public static readonly int NoiseLocal;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x4C")]
		public static readonly int NoiseParam;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x50")]
		public static readonly int CameraParams;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x54")]
		public static readonly int CameraBufferSizeSRP;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x58")]
		public static readonly int ColorGradientMatrix;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x5C")]
		public static readonly int LocalToWorldMatrix;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x60")]
		public static readonly int WorldToLocalMatrix;
	}
	[Token(Token = "0x200001A")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xEB7600", Offset = "0xEB7600")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xEB7600", Offset = "0xEB7600")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x40000C8")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x20")]
		private Mesh m_Mesh;

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x38CD478", Offset = "0x38CD478", VA = "0x38CD478")]
		private void Update()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x38CD69C", Offset = "0x38CD69C", VA = "0x38CD69C")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public static class Utils
	{
		[Token(Token = "0x2000032")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x4000169")]
			High = 64,
			[Token(Token = "0x400016A")]
			Low = 8,
			[Token(Token = "0x400016B")]
			Undef = 0
		}

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x40000CB")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x38CD6B4", Offset = "0x38CD6B4", VA = "0x38CD6B4")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x38C35A8", Offset = "0x38C35A8", VA = "0x38C35A8")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600007D")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x38CD6EC", Offset = "0x38CD6EC", VA = "0x38CD6EC")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x38CD7CC", Offset = "0x38CD7CC", VA = "0x38CD7CC")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x38CD7D0", Offset = "0x38CD7D0", VA = "0x38CD7D0")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x38CD7D8", Offset = "0x38CD7D8", VA = "0x38CD7D8")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x38CD7E4", Offset = "0x38CD7E4", VA = "0x38CD7E4")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x38CD7F4", Offset = "0x38CD7F4", VA = "0x38CD7F4")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x38CD800", Offset = "0x38CD800", VA = "0x38CD800")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x38CD808", Offset = "0x38CD808", VA = "0x38CD808")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x38CA8C8", Offset = "0x38CA8C8", VA = "0x38CA8C8")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x38CD85C", Offset = "0x38CD85C", VA = "0x38CD85C")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x38CD890", Offset = "0x38CD890", VA = "0x38CD890")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x38CAF68", Offset = "0x38CAF68", VA = "0x38CAF68")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x38CDB1C", Offset = "0x38CDB1C", VA = "0x38CDB1C")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x38C605C", Offset = "0x38C605C", VA = "0x38C605C")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x38C6D04", Offset = "0x38C6D04", VA = "0x38C6D04")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x38C5B68", Offset = "0x38C5B68", VA = "0x38C5B68")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x38CDC60", Offset = "0x38CDC60", VA = "0x38CDC60")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x38CDD44", Offset = "0x38CDD44", VA = "0x38CDD44")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x38CDB68", Offset = "0x38CDB68", VA = "0x38CDB68")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x38C501C", Offset = "0x38C501C", VA = "0x38C501C")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x38CDD84", Offset = "0x38CDD84", VA = "0x38CDD84")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x38C720C", Offset = "0x38C720C", VA = "0x38C720C")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x200001C")]
	public static class Version
	{
		[Token(Token = "0x40000CC")]
		public const int Current = 1750;
	}
	[Token(Token = "0x200001D")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xEB76A4", Offset = "0xEB76A4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xEB76A4", Offset = "0xEB76A4")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x2000033")]
		public enum Direction
		{
			[Token(Token = "0x400016D")]
			Beam,
			[Token(Token = "0x400016E")]
			Random
		}

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xEB7B30", Offset = "0xEB7B30")]
		public float alpha;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xEB7B48", Offset = "0xEB7B48")]
		public float size;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x20")]
		public Direction direction;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x28")]
		public float density;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xEB7B68", Offset = "0xEB7B68")]
		public float spawnMinDistance;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xEB7B80", Offset = "0xEB7B80")]
		public float spawnMaxDistance;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x34")]
		public bool cullingEnabled;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x38")]
		public float cullingMaxDistance;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB7B98", Offset = "0xEB7B98")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x40")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x48")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x50")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x1700001B")]
		public bool isCulled
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x38CDD8C", Offset = "0x38CDD8C", VA = "0x38CDD8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB8314", Offset = "0xEB8314")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x38CDD94", Offset = "0x38CDD94", VA = "0x38CDD94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB8324", Offset = "0xEB8324")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x38CDDA0", Offset = "0x38CDDA0", VA = "0x38CDDA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001D")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x38CDE08", Offset = "0x38CDE08", VA = "0x38CDE08")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001E")]
		public int particlesMaxCount
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x38CDE98", Offset = "0x38CDE98", VA = "0x38CDE98")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001F")]
		public Camera mainCamera
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x38CDF40", Offset = "0x38CDF40", VA = "0x38CDF40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x38CE1D0", Offset = "0x38CE1D0", VA = "0x38CE1D0")]
		private void Start()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x38CE240", Offset = "0x38CE240", VA = "0x38CE240")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x38CE4F4", Offset = "0x38CE4F4", VA = "0x38CE4F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x38CE43C", Offset = "0x38CE43C", VA = "0x38CE43C")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x38CEBA4", Offset = "0x38CEBA4", VA = "0x38CEBA4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x38CEC40", Offset = "0x38CEC40", VA = "0x38CEC40")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x38CED04", Offset = "0x38CED04", VA = "0x38CED04")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x38CE4F8", Offset = "0x38CE4F8", VA = "0x38CE4F8")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x38CED38", Offset = "0x38CED38", VA = "0x38CED38")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x38CF08C", Offset = "0x38CF08C", VA = "0x38CF08C")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x200001E")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xEB7748", Offset = "0xEB7748")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x2000034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB7994", Offset = "0xEB7994")]
		private sealed class <CoPlaytimeUpdate>d__126 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400016F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000170")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000171")]
			[FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x17000044")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000127")]
				[Address(RVA = "0x38D0910", Offset = "0x38D0910", VA = "0x38D0910", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000045")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000129")]
				[Address(RVA = "0x38D0958", Offset = "0x38D0958", VA = "0x38D0958", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000124")]
			[Address(RVA = "0x38D0120", Offset = "0x38D0120", VA = "0x38D0120")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__126(int <>1__state)
			{
			}

			[Token(Token = "0x6000125")]
			[Address(RVA = "0x38D0878", Offset = "0x38D0878", VA = "0x38D0878", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000126")]
			[Address(RVA = "0x38D087C", Offset = "0x38D087C", VA = "0x38D087C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x38D0918", Offset = "0x38D0918", VA = "0x38D0918", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xEB7BA8", Offset = "0xEB7BA8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xEB7BA8", Offset = "0xEB7BA8")]
		public Color color;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xEB7BFC", Offset = "0xEB7BFC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xEB7BFC", Offset = "0xEB7BFC")]
		public float intensityInside;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xEB7C50", Offset = "0xEB7C50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xEB7C50", Offset = "0xEB7C50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xEB7C50", Offset = "0xEB7C50")]
		public float intensityOutside;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xEB7CC8", Offset = "0xEB7CC8")]
		public bool spotAngleFromLight;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xEB7D00", Offset = "0xEB7D00")]
		public float spotAngle;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xEB7D20", Offset = "0xEB7D20")]
		public float coneRadiusStart;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x54")]
		public MeshType geomMeshType;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xEB7D58", Offset = "0xEB7D58")]
		public int geomCustomSides;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x5C")]
		public int geomCustomSegments;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x60")]
		public bool geomCap;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xEB7D90", Offset = "0xEB7D90")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x64")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xEB7DC8", Offset = "0xEB7DC8")]
		public float attenuationCustomBlending;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xEB7DE0", Offset = "0xEB7DE0")]
		public float fallOffStart;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xEB7E18", Offset = "0xEB7E18")]
		public float fallOffEnd;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x74")]
		public float depthBlendDistance;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x78")]
		public float cameraClippingDistance;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xEB7E50", Offset = "0xEB7E50")]
		public float glareFrontal;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xEB7E68", Offset = "0xEB7E68")]
		public float glareBehind;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xEB7E80", Offset = "0xEB7E80")]
		public float fresnelPow;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x88")]
		public NoiseMode noiseMode;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xEB7EB8", Offset = "0xEB7EB8")]
		[SerializeField]
		private bool _DEPRECATED_NoiseEnabled;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xEB7F04", Offset = "0xEB7F04")]
		public float noiseIntensity;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x94")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xEB7F1C", Offset = "0xEB7F1C")]
		public float noiseScaleLocal;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x9C")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0xAC")]
		public float fadeOutBegin;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0xB0")]
		public float fadeOutEnd;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xEB7F48", Offset = "0xEB7F48")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB7FB4", Offset = "0xEB7FB4")]
		private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0xC8")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0xD0")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0xD8")]
		private Light _CachedLight;

		[Token(Token = "0x17000020")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xEB84AC", Offset = "0xEB84AC")]
		public float alphaInside
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x38CF138", Offset = "0x38CF138", VA = "0x38CF138")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x38CF140", Offset = "0x38CF140", VA = "0x38CF140")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xEB84E4", Offset = "0xEB84E4")]
		public float alphaOutside
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x38CF148", Offset = "0x38CF148", VA = "0x38CF148")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x38CF150", Offset = "0x38CF150", VA = "0x38CF150")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public float intensityGlobal
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x38CF158", Offset = "0x38CF158", VA = "0x38CF158")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x38CF160", Offset = "0x38CF160", VA = "0x38CF160")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public float coneAngle
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x38C5AD0", Offset = "0x38C5AD0", VA = "0x38C5AD0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000024")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x38C4C20", Offset = "0x38C4C20", VA = "0x38C4C20")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000025")]
		public float coneVolume
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x38CF168", Offset = "0x38CF168", VA = "0x38CF168")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000026")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x38C5B10", Offset = "0x38C5B10", VA = "0x38C5B10")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000027")]
		public int geomSides
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x38CF1BC", Offset = "0x38CF1BC", VA = "0x38CF1BC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x38CF240", Offset = "0x38CF240", VA = "0x38CF240")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public int geomSegments
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x38CF2C8", Offset = "0x38CF2C8", VA = "0x38CF2C8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x38CF34C", Offset = "0x38CF34C", VA = "0x38CF34C")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xEB851C", Offset = "0xEB851C")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x38CF3D4", Offset = "0x38CF3D4", VA = "0x38CF3D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x38CF3DC", Offset = "0x38CF3DC", VA = "0x38CF3DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x38C5C8C", Offset = "0x38C5C8C", VA = "0x38C5C8C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002B")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xEB8554", Offset = "0xEB8554")]
		public float fadeStart
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x38CF3E8", Offset = "0x38CF3E8", VA = "0x38CF3E8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x38CF3F0", Offset = "0x38CF3F0", VA = "0x38CF3F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xEB858C", Offset = "0xEB858C")]
		public float fadeEnd
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x38CF3F8", Offset = "0x38CF3F8", VA = "0x38CF3F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x38CF400", Offset = "0x38CF400", VA = "0x38CF400")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x38C4D34", Offset = "0x38C4D34", VA = "0x38C4D34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xEB85C4", Offset = "0xEB85C4")]
		public bool noiseEnabled
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x38CF408", Offset = "0x38CF408", VA = "0x38CF408")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x38CF418", Offset = "0x38CF418", VA = "0x38CF418")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x38C22D8", Offset = "0x38C22D8", VA = "0x38C22D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000030")]
		public int sortingLayerID
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x38CF434", Offset = "0x38CF434", VA = "0x38CF434")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x38CF43C", Offset = "0x38CF43C", VA = "0x38CF43C")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public string sortingLayerName
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x38CF4E8", Offset = "0x38CF4E8", VA = "0x38CF4E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x38CF4F4", Offset = "0x38CF4F4", VA = "0x38CF4F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public int sortingOrder
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x38CF524", Offset = "0x38CF524", VA = "0x38CF524")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x38CF52C", Offset = "0x38CF52C", VA = "0x38CF52C")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x38CF5D8", Offset = "0x38CF5D8", VA = "0x38CF5D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x38CF5E0", Offset = "0x38CF5E0", VA = "0x38CF5E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x38CF658", Offset = "0x38CF658", VA = "0x38CF658")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		public bool hasGeometry
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x38CEEF8", Offset = "0x38CEEF8", VA = "0x38CEEF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000036")]
		public Bounds bounds
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x38CEF64", Offset = "0x38CEF64", VA = "0x38CEF64")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000037")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x38CF668", Offset = "0x38CF668", VA = "0x38CF668")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000038")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x38CF74C", Offset = "0x38CF74C", VA = "0x38CF74C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB8334", Offset = "0xEB8334")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x38CF754", Offset = "0x38CF754", VA = "0x38CF754")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB8344", Offset = "0xEB8344")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public string meshStats
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x38CF75C", Offset = "0x38CF75C", VA = "0x38CF75C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public int meshVerticesCount
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x38CF930", Offset = "0x38CF930", VA = "0x38CF930")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003B")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x38CFA08", Offset = "0x38CFA08", VA = "0x38CFA08")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003C")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x38CFAF8", Offset = "0x38CFAF8", VA = "0x38CFAF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x38CB01C", Offset = "0x38CB01C", VA = "0x38CB01C")]
		public void SetDynamicOcclusion(DynamicOcclusion dynamicOcclusion)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x38C6944", Offset = "0x38C6944", VA = "0x38C6944")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x38CFC00", Offset = "0x38CFC00", VA = "0x38CFC00")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x38C6458", Offset = "0x38C6458", VA = "0x38C6458")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x38CFC60", Offset = "0x38CFC60", VA = "0x38CFC60")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xEB8354", Offset = "0xEB8354")]
		public void Generate()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x38CFC6C", Offset = "0x38CFC6C", VA = "0x38CFC6C", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x38CFEDC", Offset = "0x38CFEDC", VA = "0x38CFEDC", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x38CFF6C", Offset = "0x38CFF6C", VA = "0x38CFF6C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x38CFF78", Offset = "0x38CFF78", VA = "0x38CFF78")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x38D000C", Offset = "0x38D000C", VA = "0x38D000C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x38CF5EC", Offset = "0x38CF5EC", VA = "0x38CF5EC")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x38D00A8", Offset = "0x38D00A8", VA = "0x38D00A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xEB838C", Offset = "0xEB838C")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x38D014C", Offset = "0x38D014C", VA = "0x38D014C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x38D0150", Offset = "0x38D0150", VA = "0x38D0150")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x38D0214", Offset = "0x38D0214", VA = "0x38D0214")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x38D0310", Offset = "0x38D0310", VA = "0x38D0310")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x38CFEAC", Offset = "0x38CFEAC", VA = "0x38CFEAC")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x38CFDC4", Offset = "0x38CFDC4", VA = "0x38CFDC4")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x38D04B4", Offset = "0x38D04B4", VA = "0x38D04B4")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xEB77B4", Offset = "0xEB77B4")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x38C65B8", Offset = "0x38C65B8", VA = "0x38C65B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x38C66B4", Offset = "0x38C66B4", VA = "0x38C66B4")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xEB7814", Offset = "0xEB7814")]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x18")]
		private bool isInsideBeam;

		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x38C66C4", Offset = "0x38C66C4", VA = "0x38C66C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x38C67B4", Offset = "0x38C67B4", VA = "0x38C67B4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x38C6878", Offset = "0x38C6878", VA = "0x38C6878")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x38C6880", Offset = "0x38C6880", VA = "0x38C6880")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x38C6AF0", Offset = "0x38C6AF0", VA = "0x38C6AF0")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xEB78CC", Offset = "0xEB78CC")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x38CB154", Offset = "0x38CB154", VA = "0x38CB154")]
		private void Start()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x38CB2E0", Offset = "0x38CB2E0", VA = "0x38CB2E0")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x1700003D")]
		private bool useMouseView
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x38CB2E8", Offset = "0x38CB2E8", VA = "0x38CB2E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x38CB2F0", Offset = "0x38CB2F0", VA = "0x38CB2F0")]
			set
			{
			}
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x38CB32C", Offset = "0x38CB32C", VA = "0x38CB32C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x38CB3C4", Offset = "0x38CB3C4", VA = "0x38CB3C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x38CB8D8", Offset = "0x38CB8D8", VA = "0x38CB8D8")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xEB7FD4", Offset = "0xEB7FD4")]
		[SerializeField]
		private int CountX;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xEB8018", Offset = "0xEB8018")]
		[SerializeField]
		private int CountY;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x38CBE44", Offset = "0x38CBE44", VA = "0x38CBE44")]
		public void Generate()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x38CC534", Offset = "0x38CC534", VA = "0x38CC534")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xEB809C", Offset = "0xEB809C")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x38CCEE4", Offset = "0x38CCEE4", VA = "0x38CCEE4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x38CCFB8", Offset = "0x38CCFB8", VA = "0x38CCFB8")]
		public Rotater()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xEB792C", Offset = "0xEB792C")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x68")]
		public float delay;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x6C")]
		public float duration;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x70")]
		public Ease easeType;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x78")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x80")]
		public LoopType loopType;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x84")]
		public int loops;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x88")]
		public string id;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x90")]
		public bool isRelative;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x91")]
		public bool isFrom;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x92")]
		public bool isIndependentUpdate;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x93")]
		public bool autoKill;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x94")]
		public bool isActive;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x95")]
		public bool isValid;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x98")]
		public Component target;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0xA0")]
		public DOTweenAnimationType animationType;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0xA4")]
		public TargetType targetType;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0xA8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0xAC")]
		public bool autoPlay;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0xAD")]
		public bool useTargetAsV3;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0xB0")]
		public float endValueFloat;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0xB4")]
		public Vector3 endValueV3;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0xC0")]
		public Vector2 endValueV2;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0xC8")]
		public Color endValueColor;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0xD8")]
		public string endValueString;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0xE0")]
		public Rect endValueRect;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0xF0")]
		public Transform endValueTransform;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0xF8")]
		public bool optionalBool0;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0xFC")]
		public float optionalFloat0;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x100")]
		public int optionalInt0;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x104")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x108")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x110")]
		public string optionalString;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x118")]
		private bool _tweenCreated;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x11C")]
		private int _playCount;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x38C75D4", Offset = "0x38C75D4", VA = "0x38C75D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x38C8AD8", Offset = "0x38C8AD8", VA = "0x38C8AD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x38C8B1C", Offset = "0x38C8B1C", VA = "0x38C8B1C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x38C7624", Offset = "0x38C7624", VA = "0x38C7624")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x38C8D1C", Offset = "0x38C8D1C", VA = "0x38C8D1C", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x38C8D94", Offset = "0x38C8D94", VA = "0x38C8D94", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x38C8E0C", Offset = "0x38C8E0C", VA = "0x38C8E0C", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x38C8E84", Offset = "0x38C8E84", VA = "0x38C8E84", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x38C8EFC", Offset = "0x38C8EFC", VA = "0x38C8EFC", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x38C8F74", Offset = "0x38C8F74", VA = "0x38C8F74", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x38C906C", Offset = "0x38C906C", VA = "0x38C906C", Slot = "10")]
		public override void DORestart(bool fromHere = false)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x38C92C0", Offset = "0x38C92C0", VA = "0x38C92C0", Slot = "11")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x38C933C", Offset = "0x38C933C", VA = "0x38C933C", Slot = "12")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x38C93C8", Offset = "0x38C93C8", VA = "0x38C93C8")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x38C9450", Offset = "0x38C9450", VA = "0x38C9450")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x38C94B4", Offset = "0x38C94B4", VA = "0x38C94B4")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x38C9518", Offset = "0x38C9518", VA = "0x38C9518")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x38C95A0", Offset = "0x38C95A0", VA = "0x38C95A0")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x38C9604", Offset = "0x38C9604", VA = "0x38C9604")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x38C968C", Offset = "0x38C968C", VA = "0x38C968C")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x38C96F0", Offset = "0x38C96F0", VA = "0x38C96F0")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x38C9838", Offset = "0x38C9838", VA = "0x38C9838")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x38C98C4", Offset = "0x38C98C4", VA = "0x38C98C4")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x38C995C", Offset = "0x38C995C", VA = "0x38C995C")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x38C99DC", Offset = "0x38C99DC", VA = "0x38C99DC")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x38C8B60", Offset = "0x38C8B60", VA = "0x38C8B60")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x38C916C", Offset = "0x38C916C", VA = "0x38C916C")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x38C9AE8", Offset = "0x38C9AE8", VA = "0x38C9AE8")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x38C9CE8", Offset = "0x38C9CE8", VA = "0x38C9CE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xEB83EC", Offset = "0xEB83EC")]
		private void <CreateTween>b__37_0()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x6000113")]
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return default(bool);
		}
	}
}
