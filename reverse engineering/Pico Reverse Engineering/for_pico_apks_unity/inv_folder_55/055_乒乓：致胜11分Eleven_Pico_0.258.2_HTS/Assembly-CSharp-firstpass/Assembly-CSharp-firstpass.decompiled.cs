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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB0F0E0", Offset = "0xB0F0E0")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB0F0E0", Offset = "0xB0F0E0")]
	public class BeamGeometry : MonoBehaviour
	{
		[Token(Token = "0x2000028")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0F5E8", Offset = "0xB0F5E8")]
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
				[Address(RVA = "0x187C5C8", Offset = "0x187C5C8", VA = "0x187C5C8", Slot = "4")]
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
				[Address(RVA = "0x187C610", Offset = "0x187C610", VA = "0x187C610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000114")]
			[Address(RVA = "0x186E2E0", Offset = "0x186E2E0", VA = "0x186E2E0")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000115")]
			[Address(RVA = "0x187C548", Offset = "0x187C548", VA = "0x187C548", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000116")]
			[Address(RVA = "0x187C54C", Offset = "0x187C54C", VA = "0x187C54C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000118")]
			[Address(RVA = "0x187C5D0", Offset = "0x187C5D0", VA = "0x187C5D0", Slot = "8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0F608", Offset = "0xB0F608")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0F618", Offset = "0xB0F618")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0F628", Offset = "0xB0F628")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x88")]
		private DynamicOcclusion _dynamicOcclusion;

		[Token(Token = "0x17000001")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x186E094", Offset = "0x186E094", VA = "0x186E094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0FD38", Offset = "0xB0FD38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x186E09C", Offset = "0x186E09C", VA = "0x186E09C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0FD48", Offset = "0xB0FD48")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x186E0A4", Offset = "0x186E0A4", VA = "0x186E0A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0FD58", Offset = "0xB0FD58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x186E0AC", Offset = "0x186E0AC", VA = "0x186E0AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0FD68", Offset = "0xB0FD68")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public Mesh coneMesh
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x186E0B4", Offset = "0x186E0B4", VA = "0x186E0B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0FD78", Offset = "0xB0FD78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x186E0BC", Offset = "0x186E0BC", VA = "0x186E0BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0FD88", Offset = "0xB0FD88")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public bool visible
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x186E0C4", Offset = "0x186E0C4", VA = "0x186E0C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x186E0E0", Offset = "0x186E0E0", VA = "0x186E0E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x186E100", Offset = "0x186E100", VA = "0x186E100")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x186E11C", Offset = "0x186E11C", VA = "0x186E11C")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public int sortingOrder
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x186E138", Offset = "0x186E138", VA = "0x186E138")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x186E154", Offset = "0x186E154", VA = "0x186E154")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x186EC0C", Offset = "0x186EC0C", VA = "0x186EC0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x1870C28", Offset = "0x1870C28", VA = "0x1870C28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		private bool isClippingPlaneEnabled
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x1870E1C", Offset = "0x1870E1C", VA = "0x1870E1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x1870EE8", Offset = "0x1870EE8", VA = "0x1870EE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public DynamicOcclusion dynamicOcclusion
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x1871E90", Offset = "0x1871E90", VA = "0x1871E90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x1871E98", Offset = "0x1871E98", VA = "0x1871E98")]
			set
			{
			}
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x186E170", Offset = "0x186E170", VA = "0x186E170")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x186E268", Offset = "0x186E268", VA = "0x186E268")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB0FD98", Offset = "0xB0FD98")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x186E30C", Offset = "0x186E30C", VA = "0x186E30C")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x186E4F8", Offset = "0x186E4F8", VA = "0x186E4F8")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x186E818", Offset = "0x186E818", VA = "0x186E818")]
		private void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x186E8CC", Offset = "0x186E8CC", VA = "0x186E8CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x186E988", Offset = "0x186E988", VA = "0x186E988")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x186EA44", Offset = "0x186EA44", VA = "0x186EA44")]
		private static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x186EB3C", Offset = "0x186EB3C", VA = "0x186EB3C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x186EC14", Offset = "0x186EC14", VA = "0x186EC14")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x186ECEC", Offset = "0x186ECEC", VA = "0x186ECEC")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x186F660", Offset = "0x186F660", VA = "0x186F660")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1870B2C", Offset = "0x1870B2C", VA = "0x1870B2C")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x186F310", Offset = "0x186F310", VA = "0x186F310")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x186E650", Offset = "0x186E650", VA = "0x186E650")]
		private void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1871594", Offset = "0x1871594", VA = "0x1871594")]
		private void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x18716C0", Offset = "0x18716C0", VA = "0x18716C0")]
		private void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x18717EC", Offset = "0x18717EC", VA = "0x18717EC")]
		private void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x186E584", Offset = "0x186E584", VA = "0x186E584")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x186E74C", Offset = "0x186E74C", VA = "0x186E74C")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1871920", Offset = "0x1871920", VA = "0x1871920")]
		private void SendMaterialClippingPlaneProp()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1870428", Offset = "0x1870428", VA = "0x1870428")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1872000", Offset = "0x1872000", VA = "0x1872000")]
		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1872334", Offset = "0x1872334", VA = "0x1872334")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x18723D0", Offset = "0x18723D0", VA = "0x18723D0")]
		private static bool IsEditorCamera(Camera cam)
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1872008", Offset = "0x1872008", VA = "0x1872008")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1872530", Offset = "0x1872530", VA = "0x1872530")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB0F150", Offset = "0xB0F150")]
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
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB0F638", Offset = "0xB0F638")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB0F6A8", Offset = "0xB0F6A8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB0F6A8", Offset = "0xB0F6A8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB0F728", Offset = "0xB0F728")]
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
			[Address(RVA = "0x186F13C", Offset = "0x186F13C", VA = "0x186F13C")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x1700000D")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x186F998", Offset = "0x186F998", VA = "0x186F998")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		public Shader beamShader
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x1872A78", Offset = "0x1872A78", VA = "0x1872A78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x1872A94", Offset = "0x1872A94", VA = "0x1872A94")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000010")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x186E478", Offset = "0x186E478", VA = "0x186E478")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public static Config Instance
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x186E41C", Offset = "0x186E41C", VA = "0x186E41C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1872ACC", Offset = "0x1872ACC", VA = "0x1872ACC")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1872B78", Offset = "0x1872B78", VA = "0x1872B78")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xB0FDF8", Offset = "0xB0FDF8")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1872BF4", Offset = "0x1872BF4", VA = "0x1872BF4")]
		public static void OnRenderPipelineChanged(RenderPipeline pipeline)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1872C98", Offset = "0x1872C98", VA = "0x1872C98")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1872EF8", Offset = "0x1872EF8", VA = "0x1872EF8")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x18730C4", Offset = "0x18730C4", VA = "0x18730C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x18730F4", Offset = "0x18730F4", VA = "0x18730F4")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1873190", Offset = "0x1873190", VA = "0x1873190")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1873354", Offset = "0x1873354", VA = "0x1873354")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB0F188", Offset = "0xB0F188")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x400001E")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1873454", Offset = "0x1873454", VA = "0x1873454")]
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
			[Address(RVA = "0x186F0CC", Offset = "0x186F0CC", VA = "0x186F0CC")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x2000006")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB0F1C0", Offset = "0xB0F1C0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB0F1C0", Offset = "0xB0F1C0")]
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
				[Address(RVA = "0x1876C6C", Offset = "0x1876C6C", VA = "0x1876C6C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000041")]
			public string name
			{
				[Token(Token = "0x600011E")]
				[Address(RVA = "0x187C618", Offset = "0x187C618", VA = "0x187C618")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000042")]
			public Bounds bounds
			{
				[Token(Token = "0x600011F")]
				[Address(RVA = "0x187C6FC", Offset = "0x187C6FC", VA = "0x187C6FC")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x600011A")]
			[Address(RVA = "0x18768E8", Offset = "0x18768E8", VA = "0x18768E8")]
			public HitResult(RaycastHit hit3D)
			{
			}

			[Token(Token = "0x600011B")]
			[Address(RVA = "0x18769D4", Offset = "0x18769D4", VA = "0x18769D4")]
			public HitResult(RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x600011C")]
			[Address(RVA = "0x1876970", Offset = "0x1876970", VA = "0x1876970")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0F774", Offset = "0xB0F774")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0F784", Offset = "0xB0F784")]
		private Plane <planeEquationWS>k__BackingField;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x68")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x17000013")]
		public HitResult currentHit
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x1875C74", Offset = "0x1875C74", VA = "0x1875C74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0FE08", Offset = "0xB0FE08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x1875C7C", Offset = "0x1875C7C", VA = "0x1875C7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0FE18", Offset = "0xB0FE18")]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x1875C84", Offset = "0x1875C84", VA = "0x1875C84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0FE28", Offset = "0xB0FE28")]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x1875C90", Offset = "0x1875C90", VA = "0x1875C90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0FE38", Offset = "0xB0FE38")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x18762C0", Offset = "0x18762C0", VA = "0x18762C0")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x17000016")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x18762D4", Offset = "0x18762D4", VA = "0x18762D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1875C9C", Offset = "0x1875C9C", VA = "0x1875C9C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1875CF8", Offset = "0x1875CF8", VA = "0x1875CF8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1875D64", Offset = "0x1875D64", VA = "0x1875D64")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1875DBC", Offset = "0x1875DBC", VA = "0x1875DBC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1875E78", Offset = "0x1875E78", VA = "0x1875E78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1876218", Offset = "0x1876218", VA = "0x1876218")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x187631C", Offset = "0x187631C", VA = "0x187631C")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1876330", Offset = "0x1876330", VA = "0x1876330")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x18765A0", Offset = "0x18765A0", VA = "0x18765A0")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1876A5C", Offset = "0x1876A5C", VA = "0x1876A5C")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1876BE0", Offset = "0x1876BE0", VA = "0x1876BE0")]
		private bool IsHitValid(HitResult hit)
		{
			return default(bool);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1875EB8", Offset = "0x1875EB8", VA = "0x1875EB8")]
		private void ProcessRaycasts()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1876D1C", Offset = "0x1876D1C", VA = "0x1876D1C")]
		private void SetHit(HitResult hit)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1875D90", Offset = "0x1875D90", VA = "0x1875D90")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1876DC8", Offset = "0x1876DC8", VA = "0x1876DC8")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1876EC4", Offset = "0x1876EC4", VA = "0x1876EC4")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1876F90", Offset = "0x1876F90", VA = "0x1876F90")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1877038", Offset = "0x1877038", VA = "0x1877038")]
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
		[Address(RVA = "0x18701EC", Offset = "0x18701EC", VA = "0x18701EC")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x187787C", Offset = "0x187787C", VA = "0x187787C")]
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
			[Address(RVA = "0x1870F2C", Offset = "0x1870F2C", VA = "0x1870F2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x187799C", Offset = "0x187799C", VA = "0x187799C")]
		public static void SetMaterialProperties(Material material, bool enableInstancing)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1877A40", Offset = "0x1877A40", VA = "0x1877A40")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1877BAC", Offset = "0x1877BAC", VA = "0x1877BAC")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reason)
		{
			return default(bool);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1877CF0", Offset = "0x1877CF0", VA = "0x1877CF0")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x2000014")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1877DBC", Offset = "0x1877DBC", VA = "0x1877DBC")]
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
		[Address(RVA = "0x18784D0", Offset = "0x18784D0", VA = "0x18784D0")]
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
				[Address(RVA = "0x1878574", Offset = "0x1878574", VA = "0x1878574")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000121")]
			[Address(RVA = "0x1871070", Offset = "0x1871070", VA = "0x1871070")]
			public void ApplyToMaterial(Material mat)
			{
			}

			[Token(Token = "0x6000122")]
			[Address(RVA = "0x1871068", Offset = "0x1871068", VA = "0x1871068")]
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
			[Address(RVA = "0x18784D8", Offset = "0x18784D8", VA = "0x18784D8")]
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
		[Address(RVA = "0x186F144", Offset = "0x186F144", VA = "0x186F144")]
		public static Material NewMaterial(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x18712D8", Offset = "0x18712D8", VA = "0x18712D8")]
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
		[Address(RVA = "0x1878768", Offset = "0x1878768", VA = "0x1878768")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1878780", Offset = "0x1878780", VA = "0x1878780")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x18787F4", Offset = "0x18787F4", VA = "0x18787F4")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x186F9A8", Offset = "0x186F9A8", VA = "0x186F9A8")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1878864", Offset = "0x1878864", VA = "0x1878864")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1878880", Offset = "0x1878880", VA = "0x1878880")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x18788A8", Offset = "0x18788A8", VA = "0x18788A8")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1878940", Offset = "0x1878940", VA = "0x1878940")]
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
			[Address(RVA = "0x1870CC4", Offset = "0x1870CC4", VA = "0x1870CC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000019")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x18789DC", Offset = "0x18789DC", VA = "0x18789DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x18771B8", Offset = "0x18771B8", VA = "0x18771B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1878A7C", Offset = "0x1878A7C", VA = "0x1878A7C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xB0FE48", Offset = "0xB0FE48")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1871C34", Offset = "0x1871C34", VA = "0x1871C34")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1878AD4", Offset = "0x1878AD4", VA = "0x1878AD4")]
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
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB0F264", Offset = "0xB0F264")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB0F264", Offset = "0xB0F264")]
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
		[Address(RVA = "0x18793F8", Offset = "0x18793F8", VA = "0x18793F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x187961C", Offset = "0x187961C", VA = "0x187961C")]
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
		[Address(RVA = "0x1879634", Offset = "0x1879634", VA = "0x1879634")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x186F528", Offset = "0x186F528", VA = "0x186F528")]
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
		[Address(RVA = "0x187966C", Offset = "0x187966C", VA = "0x187966C")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x187974C", Offset = "0x187974C", VA = "0x187974C")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1879750", Offset = "0x1879750", VA = "0x1879750")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1879758", Offset = "0x1879758", VA = "0x1879758")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1879764", Offset = "0x1879764", VA = "0x1879764")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1879774", Offset = "0x1879774", VA = "0x1879774")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1879780", Offset = "0x1879780", VA = "0x1879780")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1879788", Offset = "0x1879788", VA = "0x1879788")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1876848", Offset = "0x1876848", VA = "0x1876848")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x18797DC", Offset = "0x18797DC", VA = "0x18797DC")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1879810", Offset = "0x1879810", VA = "0x1879810")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1876EE8", Offset = "0x1876EE8", VA = "0x1876EE8")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1879A9C", Offset = "0x1879A9C", VA = "0x1879A9C")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1871FDC", Offset = "0x1871FDC", VA = "0x1871FDC")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1872C84", Offset = "0x1872C84", VA = "0x1872C84")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1871AE8", Offset = "0x1871AE8", VA = "0x1871AE8")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1879BE0", Offset = "0x1879BE0", VA = "0x1879BE0")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1879CC4", Offset = "0x1879CC4", VA = "0x1879CC4")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1879AE8", Offset = "0x1879AE8", VA = "0x1879AE8")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1870F9C", Offset = "0x1870F9C", VA = "0x1870F9C")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1879D04", Offset = "0x1879D04", VA = "0x1879D04")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x187318C", Offset = "0x187318C", VA = "0x187318C")]
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
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB0F308", Offset = "0xB0F308")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB0F308", Offset = "0xB0F308")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB0F794", Offset = "0xB0F794")]
		public float alpha;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB0F7AC", Offset = "0xB0F7AC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB0F7CC", Offset = "0xB0F7CC")]
		public float spawnMinDistance;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB0F7E4", Offset = "0xB0F7E4")]
		public float spawnMaxDistance;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x34")]
		public bool cullingEnabled;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x38")]
		public float cullingMaxDistance;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0F7FC", Offset = "0xB0F7FC")]
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
			[Address(RVA = "0x1879D0C", Offset = "0x1879D0C", VA = "0x1879D0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0FF78", Offset = "0xB0FF78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x1879D14", Offset = "0x1879D14", VA = "0x1879D14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0FF88", Offset = "0xB0FF88")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x1879D20", Offset = "0x1879D20", VA = "0x1879D20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001D")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x1879D88", Offset = "0x1879D88", VA = "0x1879D88")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001E")]
		public int particlesMaxCount
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x1879E18", Offset = "0x1879E18", VA = "0x1879E18")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001F")]
		public Camera mainCamera
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x1879EC0", Offset = "0x1879EC0", VA = "0x1879EC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x187A150", Offset = "0x187A150", VA = "0x187A150")]
		private void Start()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x187A1C0", Offset = "0x187A1C0", VA = "0x187A1C0")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x187A474", Offset = "0x187A474", VA = "0x187A474")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x187A3BC", Offset = "0x187A3BC", VA = "0x187A3BC")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x187AB24", Offset = "0x187AB24", VA = "0x187AB24")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x187ABC0", Offset = "0x187ABC0", VA = "0x187ABC0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x187AC84", Offset = "0x187AC84", VA = "0x187AC84")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x187A478", Offset = "0x187A478", VA = "0x187A478")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x187ACB8", Offset = "0x187ACB8", VA = "0x187ACB8")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x187B00C", Offset = "0x187B00C", VA = "0x187B00C")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x200001E")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB0F3AC", Offset = "0xB0F3AC")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x2000034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0F5F8", Offset = "0xB0F5F8")]
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
				[Address(RVA = "0x187C890", Offset = "0x187C890", VA = "0x187C890", Slot = "4")]
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
				[Address(RVA = "0x187C8D8", Offset = "0x187C8D8", VA = "0x187C8D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000124")]
			[Address(RVA = "0x187C0A0", Offset = "0x187C0A0", VA = "0x187C0A0")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__126(int <>1__state)
			{
			}

			[Token(Token = "0x6000125")]
			[Address(RVA = "0x187C7F8", Offset = "0x187C7F8", VA = "0x187C7F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000126")]
			[Address(RVA = "0x187C7FC", Offset = "0x187C7FC", VA = "0x187C7FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x187C898", Offset = "0x187C898", VA = "0x187C898", Slot = "8")]
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
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xB0F80C", Offset = "0xB0F80C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB0F80C", Offset = "0xB0F80C")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB0F860", Offset = "0xB0F860")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB0F860", Offset = "0xB0F860")]
		public float intensityInside;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB0F8B4", Offset = "0xB0F8B4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB0F8B4", Offset = "0xB0F8B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB0F8B4", Offset = "0xB0F8B4")]
		public float intensityOutside;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB0F92C", Offset = "0xB0F92C")]
		public bool spotAngleFromLight;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB0F964", Offset = "0xB0F964")]
		public float spotAngle;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB0F984", Offset = "0xB0F984")]
		public float coneRadiusStart;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x54")]
		public MeshType geomMeshType;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB0F9BC", Offset = "0xB0F9BC")]
		public int geomCustomSides;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x5C")]
		public int geomCustomSegments;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x60")]
		public bool geomCap;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB0F9F4", Offset = "0xB0F9F4")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x64")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB0FA2C", Offset = "0xB0FA2C")]
		public float attenuationCustomBlending;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB0FA44", Offset = "0xB0FA44")]
		public float fallOffStart;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB0FA7C", Offset = "0xB0FA7C")]
		public float fallOffEnd;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x74")]
		public float depthBlendDistance;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x78")]
		public float cameraClippingDistance;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB0FAB4", Offset = "0xB0FAB4")]
		public float glareFrontal;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB0FACC", Offset = "0xB0FACC")]
		public float glareBehind;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB0FAE4", Offset = "0xB0FAE4")]
		public float fresnelPow;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x88")]
		public NoiseMode noiseMode;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB0FB1C", Offset = "0xB0FB1C")]
		[SerializeField]
		private bool _DEPRECATED_NoiseEnabled;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB0FB68", Offset = "0xB0FB68")]
		public float noiseIntensity;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x94")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB0FB80", Offset = "0xB0FB80")]
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
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB0FBAC", Offset = "0xB0FBAC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0FC18", Offset = "0xB0FC18")]
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
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB10110", Offset = "0xB10110")]
		public float alphaInside
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x187B0B8", Offset = "0x187B0B8", VA = "0x187B0B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x187B0C0", Offset = "0x187B0C0", VA = "0x187B0C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB10148", Offset = "0xB10148")]
		public float alphaOutside
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x187B0C8", Offset = "0x187B0C8", VA = "0x187B0C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x187B0D0", Offset = "0x187B0D0", VA = "0x187B0D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public float intensityGlobal
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x187B0D8", Offset = "0x187B0D8", VA = "0x187B0D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x187B0E0", Offset = "0x187B0E0", VA = "0x187B0E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public float coneAngle
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x1871A50", Offset = "0x1871A50", VA = "0x1871A50")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000024")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x1870BA0", Offset = "0x1870BA0", VA = "0x1870BA0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000025")]
		public float coneVolume
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x187B0E8", Offset = "0x187B0E8", VA = "0x187B0E8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000026")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x1871A90", Offset = "0x1871A90", VA = "0x1871A90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000027")]
		public int geomSides
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x187B13C", Offset = "0x187B13C", VA = "0x187B13C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x187B1C0", Offset = "0x187B1C0", VA = "0x187B1C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public int geomSegments
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x187B248", Offset = "0x187B248", VA = "0x187B248")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x187B2CC", Offset = "0x187B2CC", VA = "0x187B2CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB10180", Offset = "0xB10180")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x187B354", Offset = "0x187B354", VA = "0x187B354")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x187B35C", Offset = "0x187B35C", VA = "0x187B35C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x1871C0C", Offset = "0x1871C0C", VA = "0x1871C0C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002B")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB101B8", Offset = "0xB101B8")]
		public float fadeStart
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x187B368", Offset = "0x187B368", VA = "0x187B368")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x187B370", Offset = "0x187B370", VA = "0x187B370")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB101F0", Offset = "0xB101F0")]
		public float fadeEnd
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x187B378", Offset = "0x187B378", VA = "0x187B378")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x187B380", Offset = "0x187B380", VA = "0x187B380")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x1870CB4", Offset = "0x1870CB4", VA = "0x1870CB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB10228", Offset = "0xB10228")]
		public bool noiseEnabled
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x187B388", Offset = "0x187B388", VA = "0x187B388")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x187B398", Offset = "0x187B398", VA = "0x187B398")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x186E258", Offset = "0x186E258", VA = "0x186E258")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000030")]
		public int sortingLayerID
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x187B3B4", Offset = "0x187B3B4", VA = "0x187B3B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x187B3BC", Offset = "0x187B3BC", VA = "0x187B3BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public string sortingLayerName
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x187B468", Offset = "0x187B468", VA = "0x187B468")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x187B474", Offset = "0x187B474", VA = "0x187B474")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public int sortingOrder
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x187B4A4", Offset = "0x187B4A4", VA = "0x187B4A4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x187B4AC", Offset = "0x187B4AC", VA = "0x187B4AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x187B558", Offset = "0x187B558", VA = "0x187B558")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x187B560", Offset = "0x187B560", VA = "0x187B560")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x187B5D8", Offset = "0x187B5D8", VA = "0x187B5D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		public bool hasGeometry
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x187AE78", Offset = "0x187AE78", VA = "0x187AE78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000036")]
		public Bounds bounds
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x187AEE4", Offset = "0x187AEE4", VA = "0x187AEE4")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000037")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x187B5E8", Offset = "0x187B5E8", VA = "0x187B5E8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000038")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x187B6CC", Offset = "0x187B6CC", VA = "0x187B6CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0FF98", Offset = "0xB0FF98")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x187B6D4", Offset = "0x187B6D4", VA = "0x187B6D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB0FFA8", Offset = "0xB0FFA8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public string meshStats
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x187B6DC", Offset = "0x187B6DC", VA = "0x187B6DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public int meshVerticesCount
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x187B8B0", Offset = "0x187B8B0", VA = "0x187B8B0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003B")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x187B988", Offset = "0x187B988", VA = "0x187B988")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003C")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x187BA78", Offset = "0x187BA78", VA = "0x187BA78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1876F9C", Offset = "0x1876F9C", VA = "0x1876F9C")]
		public void SetDynamicOcclusion(DynamicOcclusion dynamicOcclusion)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x18728C4", Offset = "0x18728C4", VA = "0x18728C4")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x187BB80", Offset = "0x187BB80", VA = "0x187BB80")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x18723D8", Offset = "0x18723D8", VA = "0x18723D8")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x187BBE0", Offset = "0x187BBE0", VA = "0x187BBE0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB0FFB8", Offset = "0xB0FFB8")]
		public void Generate()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x187BBEC", Offset = "0x187BBEC", VA = "0x187BBEC", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x187BE5C", Offset = "0x187BE5C", VA = "0x187BE5C", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x187BEEC", Offset = "0x187BEEC", VA = "0x187BEEC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x187BEF8", Offset = "0x187BEF8", VA = "0x187BEF8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x187BF8C", Offset = "0x187BF8C", VA = "0x187BF8C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x187B56C", Offset = "0x187B56C", VA = "0x187B56C")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x187C028", Offset = "0x187C028", VA = "0x187C028")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB0FFF0", Offset = "0xB0FFF0")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x187C0CC", Offset = "0x187C0CC", VA = "0x187C0CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x187C0D0", Offset = "0x187C0D0", VA = "0x187C0D0")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x187C194", Offset = "0x187C194", VA = "0x187C194")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x187C290", Offset = "0x187C290", VA = "0x187C290")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x187BE2C", Offset = "0x187BE2C", VA = "0x187BE2C")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x187BD44", Offset = "0x187BD44", VA = "0x187BD44")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x187C434", Offset = "0x187C434", VA = "0x187C434")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB0F418", Offset = "0xB0F418")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1872538", Offset = "0x1872538", VA = "0x1872538")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1872634", Offset = "0x1872634", VA = "0x1872634")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB0F478", Offset = "0xB0F478")]
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
		[Address(RVA = "0x1872644", Offset = "0x1872644", VA = "0x1872644")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1872734", Offset = "0x1872734", VA = "0x1872734")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x18727F8", Offset = "0x18727F8", VA = "0x18727F8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1872800", Offset = "0x1872800", VA = "0x1872800")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1872A70", Offset = "0x1872A70", VA = "0x1872A70")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB0F530", Offset = "0xB0F530")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x18770D4", Offset = "0x18770D4", VA = "0x18770D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1877260", Offset = "0x1877260", VA = "0x1877260")]
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
			[Address(RVA = "0x1877268", Offset = "0x1877268", VA = "0x1877268")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x1877270", Offset = "0x1877270", VA = "0x1877270")]
			set
			{
			}
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x18772AC", Offset = "0x18772AC", VA = "0x18772AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1877344", Offset = "0x1877344", VA = "0x1877344")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1877858", Offset = "0x1877858", VA = "0x1877858")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB0FC38", Offset = "0xB0FC38")]
		[SerializeField]
		private int CountX;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB0FC7C", Offset = "0xB0FC7C")]
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
		[Address(RVA = "0x1877DC4", Offset = "0x1877DC4", VA = "0x1877DC4")]
		public void Generate()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x18784B4", Offset = "0x18784B4", VA = "0x18784B4")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB0FD00", Offset = "0xB0FD00")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1878E64", Offset = "0x1878E64", VA = "0x1878E64")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1878F38", Offset = "0x1878F38", VA = "0x1878F38")]
		public Rotater()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB0F590", Offset = "0xB0F590")]
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
		[Address(RVA = "0x1873554", Offset = "0x1873554", VA = "0x1873554")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1874A58", Offset = "0x1874A58", VA = "0x1874A58")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1874A9C", Offset = "0x1874A9C", VA = "0x1874A9C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x18735A4", Offset = "0x18735A4", VA = "0x18735A4")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1874C9C", Offset = "0x1874C9C", VA = "0x1874C9C", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1874D14", Offset = "0x1874D14", VA = "0x1874D14", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1874D8C", Offset = "0x1874D8C", VA = "0x1874D8C", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1874E04", Offset = "0x1874E04", VA = "0x1874E04", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1874E7C", Offset = "0x1874E7C", VA = "0x1874E7C", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1874EF4", Offset = "0x1874EF4", VA = "0x1874EF4", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1874FEC", Offset = "0x1874FEC", VA = "0x1874FEC", Slot = "10")]
		public override void DORestart(bool fromHere = false)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1875240", Offset = "0x1875240", VA = "0x1875240", Slot = "11")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x18752BC", Offset = "0x18752BC", VA = "0x18752BC", Slot = "12")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1875348", Offset = "0x1875348", VA = "0x1875348")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x18753D0", Offset = "0x18753D0", VA = "0x18753D0")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1875434", Offset = "0x1875434", VA = "0x1875434")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1875498", Offset = "0x1875498", VA = "0x1875498")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1875520", Offset = "0x1875520", VA = "0x1875520")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1875584", Offset = "0x1875584", VA = "0x1875584")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x187560C", Offset = "0x187560C", VA = "0x187560C")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1875670", Offset = "0x1875670", VA = "0x1875670")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x18757B8", Offset = "0x18757B8", VA = "0x18757B8")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1875844", Offset = "0x1875844", VA = "0x1875844")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x18758DC", Offset = "0x18758DC", VA = "0x18758DC")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x187595C", Offset = "0x187595C", VA = "0x187595C")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1874AE0", Offset = "0x1874AE0", VA = "0x1874AE0")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x18750EC", Offset = "0x18750EC", VA = "0x18750EC")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1875A68", Offset = "0x1875A68", VA = "0x1875A68")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1875C68", Offset = "0x1875C68", VA = "0x1875C68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB10050", Offset = "0xB10050")]
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
