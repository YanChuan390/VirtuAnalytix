using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Experimental.Animations;
using UnityEngine.Playables;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("3.7.1.6")]
[Token(Token = "0x2000002")]
public interface IFixedUpdateable
{
	[Token(Token = "0x6000001")]
	void CustomFixedUpdate();
}
[Token(Token = "0x2000003")]
public class PhysicsSimulator : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PhysicsSimulator instance;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2322C0", Offset = "0x2322C0")]
	private static float <timer>k__BackingField;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2322D0", Offset = "0x2322D0")]
	private static float <interpolationFactor>k__BackingField;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private List<IFixedUpdateable> monoBehaviors;

	[Token(Token = "0x17000001")]
	public static float timer
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xE046CC", Offset = "0xE046CC", VA = "0xE046CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D2E8", Offset = "0x23D2E8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xE04730", Offset = "0xE04730", VA = "0xE04730")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D2F8", Offset = "0x23D2F8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public static float interpolationFactor
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0xE0479C", Offset = "0xE0479C", VA = "0xE0479C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D308", Offset = "0x23D308")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000005")]
		[Address(RVA = "0xE04800", Offset = "0xE04800", VA = "0xE04800")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D318", Offset = "0x23D318")]
		private set
		{
		}
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xE0486C", Offset = "0xE0486C", VA = "0xE0486C")]
	public static void Register(IFixedUpdateable monoBehavior)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xE049C8", Offset = "0xE049C8", VA = "0xE049C8")]
	public static void Unregister(IFixedUpdateable monoBehavior)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xE04B24", Offset = "0xE04B24", VA = "0xE04B24")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xE04C68", Offset = "0xE04C68", VA = "0xE04C68")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xE04CD4", Offset = "0xE04CD4", VA = "0xE04CD4")]
	private void Update()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xE04948", Offset = "0xE04948", VA = "0xE04948")]
	private void RegisterInternal(IFixedUpdateable monoBehavior)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xE04AA4", Offset = "0xE04AA4", VA = "0xE04AA4")]
	private void UnregisterInternal(IFixedUpdateable monoBehavior)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xE05094", Offset = "0xE05094", VA = "0xE05094")]
	public PhysicsSimulator()
	{
	}
}
namespace VLB
{
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2305D8", Offset = "0x2305D8")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x2305D8", Offset = "0x2305D8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2305D8", Offset = "0x2305D8")]
	public class BeamGeometry : MonoBehaviour
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2322E0", Offset = "0x2322E0")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2322F0", Offset = "0x2322F0")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x232300", Offset = "0x232300")]
		private Material <material>k__BackingField;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x232310", Offset = "0x232310")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x17000003")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0xE76DE4", Offset = "0xE76DE4", VA = "0xE76DE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D328", Offset = "0x23D328")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0xE76DEC", Offset = "0xE76DEC", VA = "0xE76DEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D338", Offset = "0x23D338")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0xE76DF4", Offset = "0xE76DF4", VA = "0xE76DF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D348", Offset = "0x23D348")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0xE76DFC", Offset = "0xE76DFC", VA = "0xE76DFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D358", Offset = "0x23D358")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public Material material
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0xE76E04", Offset = "0xE76E04", VA = "0xE76E04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D368", Offset = "0x23D368")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0xE76E0C", Offset = "0xE76E0C", VA = "0xE76E0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D378", Offset = "0x23D378")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public Mesh coneMesh
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0xE76E14", Offset = "0xE76E14", VA = "0xE76E14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D388", Offset = "0x23D388")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0xE76E1C", Offset = "0xE76E1C", VA = "0xE76E1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D398", Offset = "0x23D398")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public bool visible
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0xE76E24", Offset = "0xE76E24", VA = "0xE76E24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0xE76E50", Offset = "0xE76E50", VA = "0xE76E50")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0xE76E84", Offset = "0xE76E84", VA = "0xE76E84")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0xE76EB0", Offset = "0xE76EB0", VA = "0xE76EB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public int sortingOrder
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0xE76EE4", Offset = "0xE76EE4", VA = "0xE76EE4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0xE76F10", Offset = "0xE76F10", VA = "0xE76F10")]
			set
			{
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xE76F44", Offset = "0xE76F44", VA = "0xE76F44")]
		private void Start()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xE7701C", Offset = "0xE7701C", VA = "0xE7701C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xE770F0", Offset = "0xE770F0", VA = "0xE770F0")]
		public void Initialize(VolumetricLightBeam master, Shader shader)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xE77730", Offset = "0xE77730", VA = "0xE77730")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xE79DB4", Offset = "0xE79DB4", VA = "0xE79DB4")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xE78F48", Offset = "0xE78F48", VA = "0xE78F48")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xE7AA5C", Offset = "0xE7AA5C", VA = "0xE7AA5C")]
		public void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xE7AB94", Offset = "0xE7AB94", VA = "0xE7AB94")]
		public void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xE7AC10", Offset = "0xE7AC10", VA = "0xE7AC10")]
		private void OnBeginCameraRendering(Camera cam)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xE7B180", Offset = "0xE7B180", VA = "0xE7B180")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xE7AC14", Offset = "0xE7AC14", VA = "0xE7AC14")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xE7B43C", Offset = "0xE7B43C", VA = "0xE7B43C")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x230648", Offset = "0x230648")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int geometryLayerID;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public string geometryTag;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int geometryRenderQueue;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool forceSinglePass;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "HighlightNullAttribute", RVA = "0x232320", Offset = "0x232320")]
		private Shader beamShader1Pass;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x232350", Offset = "0x232350")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x232350", Offset = "0x232350")]
		[SerializeField]
		[AttributeAttribute(Name = "HighlightNullAttribute", RVA = "0x232350", Offset = "0x232350")]
		private Shader beamShader2Pass;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int sharedMeshSides;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int sharedMeshSegments;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2323D8", Offset = "0x2323D8")]
		public float globalNoiseScale;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HighlightNullAttribute", RVA = "0x2323F4", Offset = "0x2323F4")]
		public TextAsset noise3DData;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int noise3DSize;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HighlightNullAttribute", RVA = "0x232404", Offset = "0x232404")]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Config m_Instance;

		[Token(Token = "0x1700000A")]
		public Shader beamShader
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0xE7B444", Offset = "0xE7B444", VA = "0xE7B444")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0xE7B45C", Offset = "0xE7B45C", VA = "0xE7B45C")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x1700000C")]
		public static Config Instance
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0xE77BD8", Offset = "0xE77BD8", VA = "0xE77BD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xE7B49C", Offset = "0xE7B49C", VA = "0xE7B49C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xE7B6B0", Offset = "0xE7B6B0", VA = "0xE7B6B0")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xE7B910", Offset = "0xE7B910", VA = "0xE7B910")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public static class Consts
	{
		[Token(Token = "0x400001B")]
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		[Token(Token = "0x400001C")]
		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		[Token(Token = "0x400001D")]
		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		[Token(Token = "0x400001E")]
		public const string HelpUrlDynamicOcclusion = "http://saladgamer.com/vlb-doc/comp-dynocclusion/";

		[Token(Token = "0x400001F")]
		public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

		[Token(Token = "0x4000020")]
		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly bool ProceduralObjectsVisibleInEditor;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly Color FlatColor;

		[Token(Token = "0x4000023")]
		public const ColorMode ColorModeDefault = ColorMode.Flat;

		[Token(Token = "0x4000024")]
		public const float Alpha = 1f;

		[Token(Token = "0x4000025")]
		public const float SpotAngleDefault = 35f;

		[Token(Token = "0x4000026")]
		public const float SpotAngleMin = 0.1f;

		[Token(Token = "0x4000027")]
		public const float SpotAngleMax = 179.9f;

		[Token(Token = "0x4000028")]
		public const float ConeRadiusStart = 0.1f;

		[Token(Token = "0x4000029")]
		public const MeshType GeomMeshType = MeshType.Shared;

		[Token(Token = "0x400002A")]
		public const int GeomSidesDefault = 18;

		[Token(Token = "0x400002B")]
		public const int GeomSidesMin = 3;

		[Token(Token = "0x400002C")]
		public const int GeomSidesMax = 256;

		[Token(Token = "0x400002D")]
		public const int GeomSegmentsDefault = 5;

		[Token(Token = "0x400002E")]
		public const int GeomSegmentsMin = 0;

		[Token(Token = "0x400002F")]
		public const int GeomSegmentsMax = 64;

		[Token(Token = "0x4000030")]
		public const bool GeomCap = false;

		[Token(Token = "0x4000031")]
		public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

		[Token(Token = "0x4000032")]
		public const float AttenuationCustomBlending = 0.5f;

		[Token(Token = "0x4000033")]
		public const float FadeStart = 0f;

		[Token(Token = "0x4000034")]
		public const float FadeEnd = 3f;

		[Token(Token = "0x4000035")]
		public const float FadeMinThreshold = 0.01f;

		[Token(Token = "0x4000036")]
		public const float DepthBlendDistance = 2f;

		[Token(Token = "0x4000037")]
		public const float CameraClippingDistance = 0.5f;

		[Token(Token = "0x4000038")]
		public const float FresnelPowMaxValue = 10f;

		[Token(Token = "0x4000039")]
		public const float FresnelPow = 8f;

		[Token(Token = "0x400003A")]
		public const float GlareFrontal = 0.5f;

		[Token(Token = "0x400003B")]
		public const float GlareBehind = 0.5f;

		[Token(Token = "0x400003C")]
		public const float NoiseIntensityMin = 0f;

		[Token(Token = "0x400003D")]
		public const float NoiseIntensityMax = 1f;

		[Token(Token = "0x400003E")]
		public const float NoiseIntensityDefault = 0.5f;

		[Token(Token = "0x400003F")]
		public const float NoiseScaleMin = 0.01f;

		[Token(Token = "0x4000040")]
		public const float NoiseScaleMax = 2f;

		[Token(Token = "0x4000041")]
		public const float NoiseScaleDefault = 0.5f;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly Vector3 NoiseVelocityDefault;

		[Token(Token = "0x4000043")]
		public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x4000047")]
		public const float DynOcclusionMinSurfaceRatioDefault = 0.5f;

		[Token(Token = "0x4000048")]
		public const float DynOcclusionMinSurfaceRatioMin = 50f;

		[Token(Token = "0x4000049")]
		public const float DynOcclusionMinSurfaceRatioMax = 100f;

		[Token(Token = "0x400004A")]
		public const float DynOcclusionMaxSurfaceDotDefault = 0.25f;

		[Token(Token = "0x400004B")]
		public const float DynOcclusionMaxSurfaceAngleMin = 45f;

		[Token(Token = "0x400004C")]
		public const float DynOcclusionMaxSurfaceAngleMax = 90f;

		[Token(Token = "0x400004D")]
		public const bool ConfigGeometryOverrideLayerDefault = true;

		[Token(Token = "0x400004E")]
		public const int ConfigGeometryLayerIDDefault = 1;

		[Token(Token = "0x400004F")]
		public const string ConfigGeometryTagDefault = "Untagged";

		[Token(Token = "0x4000050")]
		public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

		[Token(Token = "0x4000051")]
		public const bool ConfigGeometryForceSinglePassDefault = false;

		[Token(Token = "0x4000052")]
		public const int ConfigNoise3DSizeDefault = 64;

		[Token(Token = "0x4000053")]
		public const int ConfigSharedMeshSides = 24;

		[Token(Token = "0x4000054")]
		public const int ConfigSharedMeshSegments = 5;

		[Token(Token = "0x1700000D")]
		public static HideFlags ProceduralObjectsHideFlags
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0xE77524", Offset = "0xE77524", VA = "0xE77524")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x23069C", Offset = "0x23069C")]
	[AttributeAttribute(Name = "DisallowMultipleComponent", RVA = "0x23069C", Offset = "0x23069C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x23069C", Offset = "0x23069C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x23069C", Offset = "0x23069C")]
	public class DynamicOcclusion : MonoBehaviour
	{
		[Token(Token = "0x20000FE")]
		private enum Direction
		{
			[Token(Token = "0x4000690")]
			Up,
			[Token(Token = "0x4000691")]
			Right,
			[Token(Token = "0x4000692")]
			Down,
			[Token(Token = "0x4000693")]
			Left
		}

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public LayerMask layerMask;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minOccluderArea;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int waitFrameCount;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minSurfaceRatio;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxSurfaceDot;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float planeOffset;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_FrameCountToWait;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_RangeMultiplier;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xE7BBEC", Offset = "0xE7BBEC", VA = "0xE7BBEC")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xE7BCA0", Offset = "0xE7BCA0", VA = "0xE7BCA0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xE7BD08", Offset = "0xE7BD08", VA = "0xE7BD08")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xE7BD10", Offset = "0xE7BD10", VA = "0xE7BD10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xE7BE24", Offset = "0xE7BE24", VA = "0xE7BE24")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xE7C480", Offset = "0xE7C480", VA = "0xE7C480")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xE7C5AC", Offset = "0xE7C5AC", VA = "0xE7C5AC")]
		private RaycastHit GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xE7C9C0", Offset = "0xE7C9C0", VA = "0xE7C9C0")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xE7CC54", Offset = "0xE7CC54", VA = "0xE7CC54")]
		private bool IsHitValid(RaycastHit hit)
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xE7BE58", Offset = "0xE7BE58", VA = "0xE7BE58")]
		private void ProcessRaycasts()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xE7CDF4", Offset = "0xE7CDF4", VA = "0xE7CDF4")]
		private void SetHit(RaycastHit hit)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xE7BD0C", Offset = "0xE7BD0C", VA = "0xE7BD0C")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xE7CFBC", Offset = "0xE7CFBC", VA = "0xE7CFBC")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xE7D138", Offset = "0xE7D138", VA = "0xE7D138")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xE7D438", Offset = "0xE7D438", VA = "0xE7D438")]
		public DynamicOcclusion()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public enum ColorMode
	{
		[Token(Token = "0x4000061")]
		Flat,
		[Token(Token = "0x4000062")]
		Gradient
	}
	[Token(Token = "0x2000009")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x4000064")]
		Linear,
		[Token(Token = "0x4000065")]
		Quadratic,
		[Token(Token = "0x4000066")]
		Blend
	}
	[Token(Token = "0x200000A")]
	public enum BlendingMode
	{
		[Token(Token = "0x4000068")]
		Additive,
		[Token(Token = "0x4000069")]
		SoftAdditive,
		[Token(Token = "0x400006A")]
		TraditionalTransparency
	}
	[Token(Token = "0x200000B")]
	public enum MeshType
	{
		[Token(Token = "0x400006C")]
		Shared,
		[Token(Token = "0x400006D")]
		Custom
	}
	[Token(Token = "0x200000C")]
	public enum RenderQueue
	{
		[Token(Token = "0x400006F")]
		Custom = 0,
		[Token(Token = "0x4000070")]
		Background = 1000,
		[Token(Token = "0x4000071")]
		Geometry = 2000,
		[Token(Token = "0x4000072")]
		AlphaTest = 2450,
		[Token(Token = "0x4000073")]
		GeometryLast = 2500,
		[Token(Token = "0x4000074")]
		Transparent = 3000,
		[Token(Token = "0x4000075")]
		Overlay = 4000
	}
	[Token(Token = "0x200000D")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x4000077")]
		Surface,
		[Token(Token = "0x4000078")]
		Beam
	}
	[Token(Token = "0x200000E")]
	public static class GlobalMesh
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x1700000E")]
		public static Mesh mesh
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0xE78CD4", Offset = "0xE78CD4", VA = "0xE78CD4")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x200000F")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0xE7D490", Offset = "0xE7D490", VA = "0xE7D490")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public static class MeshGenerator
	{
		[Token(Token = "0x400007A")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xE7D498", Offset = "0xE7D498", VA = "0xE7D498")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xE7D58C", Offset = "0xE7D58C", VA = "0xE7D58C")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xE77D88", Offset = "0xE77D88", VA = "0xE77D88")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xE7D5C4", Offset = "0xE7D5C4", VA = "0xE7D5C4")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xE7D5E0", Offset = "0xE7D5E0", VA = "0xE7D5E0")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xE7D604", Offset = "0xE7D604", VA = "0xE7D604")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xE7D6DC", Offset = "0xE7D6DC", VA = "0xE7D6DC")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000011")]
	public static class Noise3D
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x400007E")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x400007F")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x1700000F")]
		public static bool isSupported
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0xE7A508", Offset = "0xE7A508", VA = "0xE7A508")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0xE7D868", Offset = "0xE7D868", VA = "0xE7D868")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000011")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0xE7D7B8", Offset = "0xE7D7B8", VA = "0xE7D7B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xE7D930", Offset = "0xE7D930", VA = "0xE7D930")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x23D3A8", Offset = "0x23D3A8")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xE7A700", Offset = "0xE7A700", VA = "0xE7A700")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xE7D9A8", Offset = "0xE7D9A8", VA = "0xE7D9A8")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "DisallowMultipleComponent", RVA = "0x230788", Offset = "0x230788")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x230788", Offset = "0x230788")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x230788", Offset = "0x230788")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool setIsTrigger;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float rangeMultiplier;

		[Token(Token = "0x4000082")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Mesh m_Mesh;

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xE7DE08", Offset = "0xE7DE08", VA = "0xE7DE08")]
		private void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xE7E110", Offset = "0xE7E110", VA = "0xE7E110")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public static class Utils
	{
		[Token(Token = "0x20000FF")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x4000695")]
			High = 64,
			[Token(Token = "0x4000696")]
			Low = 8,
			[Token(Token = "0x4000697")]
			Undef = 0
		}

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x4000085")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xE775BC", Offset = "0xE775BC", VA = "0xE775BC")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xE7E128", Offset = "0xE7E128", VA = "0xE7E128")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xE7E264", Offset = "0xE7E264", VA = "0xE7E264")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xE7E284", Offset = "0xE7E284", VA = "0xE7E284")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xE7E2A8", Offset = "0xE7E2A8", VA = "0xE7E2A8")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xE7E2D0", Offset = "0xE7E2D0", VA = "0xE7E2D0")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xE7E2FC", Offset = "0xE7E2FC", VA = "0xE7E2FC")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xE7E324", Offset = "0xE7E324", VA = "0xE7E324")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xE7E348", Offset = "0xE7E348", VA = "0xE7E348")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xE7C870", Offset = "0xE7C870", VA = "0xE7C870")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xE7E3C4", Offset = "0xE7E3C4", VA = "0xE7E3C4")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xE7E3F4", Offset = "0xE7E3F4", VA = "0xE7E3F4")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xE7D160", Offset = "0xE7D160", VA = "0xE7D160")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xE7E94C", Offset = "0xE7E94C", VA = "0xE7E94C")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xE7A204", Offset = "0xE7A204", VA = "0xE7A204")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xE7EAF8", Offset = "0xE7EAF8", VA = "0xE7EAF8")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xE7EC64", Offset = "0xE7EC64", VA = "0xE7EC64")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xE7E9BC", Offset = "0xE7E9BC", VA = "0xE7E9BC")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xE7A0D0", Offset = "0xE7A0D0", VA = "0xE7A0D0")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xE7ED48", Offset = "0xE7ED48", VA = "0xE7ED48")]
		public static void MarkCurrentSceneDirty()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public static class Version
	{
		[Token(Token = "0x4000086")]
		public const int Current = 1520;
	}
	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x230870", Offset = "0x230870")]
	[AttributeAttribute(Name = "DisallowMultipleComponent", RVA = "0x230870", Offset = "0x230870")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x230870", Offset = "0x230870")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x230870", Offset = "0x230870")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x2000100")]
		public enum Direction
		{
			[Token(Token = "0x4000699")]
			Beam,
			[Token(Token = "0x400069A")]
			Random
		}

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x232414", Offset = "0x232414")]
		public float alpha;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23242C", Offset = "0x23242C")]
		public float size;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Direction direction;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float density;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23244C", Offset = "0x23244C")]
		public float spawnMaxDistance;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool cullingEnabled;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float cullingMaxDistance;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x232464", Offset = "0x232464")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x17000012")]
		public bool isCulled
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0xE7ED50", Offset = "0xE7ED50", VA = "0xE7ED50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D4C8", Offset = "0x23D4C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600006C")]
			[Address(RVA = "0xE7ED58", Offset = "0xE7ED58", VA = "0xE7ED58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D4D8", Offset = "0x23D4D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0xE7ED60", Offset = "0xE7ED60", VA = "0xE7ED60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000014")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0xE7EDE8", Offset = "0xE7EDE8", VA = "0xE7EDE8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000015")]
		public int particlesMaxCount
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0xE7EE9C", Offset = "0xE7EE9C", VA = "0xE7EE9C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000016")]
		public Camera mainCamera
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0xE7EF74", Offset = "0xE7EF74", VA = "0xE7EF74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xE7F2B8", Offset = "0xE7F2B8", VA = "0xE7F2B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xE7F338", Offset = "0xE7F338", VA = "0xE7F338")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xE7F674", Offset = "0xE7F674", VA = "0xE7F674")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xE7F574", Offset = "0xE7F574", VA = "0xE7F574")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xE7FEE8", Offset = "0xE7FEE8", VA = "0xE7FEE8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xE7FFBC", Offset = "0xE7FFBC", VA = "0xE7FFBC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xE800B0", Offset = "0xE800B0", VA = "0xE800B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xE7F678", Offset = "0xE7F678", VA = "0xE7F678")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xE800DC", Offset = "0xE800DC", VA = "0xE800DC")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xE805A8", Offset = "0xE805A8", VA = "0xE805A8")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x23095C", Offset = "0x23095C")]
	[AttributeAttribute(Name = "DisallowMultipleComponent", RVA = "0x23095C", Offset = "0x23095C")]
	[AttributeAttribute(Name = "SelectionBaseAttribute", RVA = "0x23095C", Offset = "0x23095C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x23095C", Offset = "0x23095C")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2321F0", Offset = "0x2321F0")]
		private sealed class <CoPlaytimeUpdate>d__96 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x1700015B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000976")]
				[Address(RVA = "0xE81F74", Offset = "0xE81F74", VA = "0xE81F74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000978")]
				[Address(RVA = "0xE82004", Offset = "0xE82004", VA = "0xE82004", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000973")]
			[Address(RVA = "0xE81914", Offset = "0xE81914", VA = "0xE81914")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__96(int <>1__state)
			{
			}

			[Token(Token = "0x6000974")]
			[Address(RVA = "0xE81EE4", Offset = "0xE81EE4", VA = "0xE81EE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000975")]
			[Address(RVA = "0xE81EE8", Offset = "0xE81EE8", VA = "0xE81EE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000977")]
			[Address(RVA = "0xE81F7C", Offset = "0xE81F7C", VA = "0xE81F7C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool colorFromLight;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColorMode colorMode;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x232474", Offset = "0x232474")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x232474", Offset = "0x232474")]
		public Color color;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Gradient colorGradient;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2324C8", Offset = "0x2324C8")]
		public float alphaInside;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x2324E0", Offset = "0x2324E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2324E0", Offset = "0x2324E0")]
		public float alphaOutside;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BlendingMode blendingMode;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x232530", Offset = "0x232530")]
		public bool spotAngleFromLight;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23256C", Offset = "0x23256C")]
		public float spotAngle;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x23258C", Offset = "0x23258C")]
		public float coneRadiusStart;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MeshType geomMeshType;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x2325C4", Offset = "0x2325C4")]
		public int geomCustomSides;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int geomCustomSegments;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool geomCap;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool fadeEndFromLight;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2325FC", Offset = "0x2325FC")]
		public float attenuationCustomBlending;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float fadeStart;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float fadeEnd;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float depthBlendDistance;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float cameraClippingDistance;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x232614", Offset = "0x232614")]
		public float glareFrontal;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23262C", Offset = "0x23262C")]
		public float glareBehind;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x232644", Offset = "0x232644")]
		public float boostDistanceInside;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x23268C", Offset = "0x23268C")]
		public float fresnelPowInside;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x2326E8", Offset = "0x2326E8")]
		public float fresnelPow;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool noiseEnabled;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x232728", Offset = "0x232728")]
		public float noiseIntensity;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x232740", Offset = "0x232740")]
		public float noiseScaleLocal;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Plane m_PlaneWS;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x23276C", Offset = "0x23276C")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Light _CachedLight;

		[Token(Token = "0x17000017")]
		public float coneAngle
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0xE79FB8", Offset = "0xE79FB8", VA = "0xE79FB8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000018")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0xE79F08", Offset = "0xE79F08", VA = "0xE79F08")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000019")]
		public float coneVolume
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0xE80690", Offset = "0xE80690", VA = "0xE80690")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001A")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0xE7A078", Offset = "0xE7A078", VA = "0xE7A078")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001B")]
		public int geomSides
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0xE806E0", Offset = "0xE806E0", VA = "0xE806E0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0xE8078C", Offset = "0xE8078C", VA = "0xE8078C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public int geomSegments
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0xE80824", Offset = "0xE80824", VA = "0xE80824")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0xE808D0", Offset = "0xE808D0", VA = "0xE808D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0xE7A4DC", Offset = "0xE7A4DC", VA = "0xE7A4DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001E")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0xE80968", Offset = "0xE80968", VA = "0xE80968")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000086")]
			[Address(RVA = "0xE80970", Offset = "0xE80970", VA = "0xE80970")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public string sortingLayerName
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0xE80A28", Offset = "0xE80A28", VA = "0xE80A28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xE80A34", Offset = "0xE80A34", VA = "0xE80A34")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public int sortingOrder
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xE80A5C", Offset = "0xE80A5C", VA = "0xE80A5C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xE80A64", Offset = "0xE80A64", VA = "0xE80A64")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0xE80B1C", Offset = "0xE80B1C", VA = "0xE80B1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0xE80B24", Offset = "0xE80B24", VA = "0xE80B24")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0xE80B80", Offset = "0xE80B80", VA = "0xE80B80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000023")]
		public bool hasGeometry
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xE803B8", Offset = "0xE803B8", VA = "0xE803B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000024")]
		public Bounds bounds
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xE80444", Offset = "0xE80444", VA = "0xE80444")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000025")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0xE7A3A4", Offset = "0xE7A3A4", VA = "0xE7A3A4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000026")]
		public string meshStats
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0xE80CF4", Offset = "0xE80CF4", VA = "0xE80CF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public int meshVerticesCount
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0xE80EF0", Offset = "0xE80EF0", VA = "0xE80EF0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000028")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0xE81014", Offset = "0xE81014", VA = "0xE81014")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000029")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0xE81164", Offset = "0xE81164", VA = "0xE81164")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xE7D2A0", Offset = "0xE7D2A0", VA = "0xE7D2A0")]
		public void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xE7D380", Offset = "0xE7D380", VA = "0xE7D380")]
		public void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xE80B90", Offset = "0xE80B90", VA = "0xE80B90")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xE81294", Offset = "0xE81294", VA = "0xE81294")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xE7B228", Offset = "0xE7B228", VA = "0xE7B228")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xE81300", Offset = "0xE81300", VA = "0xE81300")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x23D4E8", Offset = "0x23D4E8")]
		public void Generate()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xE81310", Offset = "0xE81310", VA = "0xE81310", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xE81654", Offset = "0xE81654", VA = "0xE81654", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xE81708", Offset = "0xE81708", VA = "0xE81708")]
		private void Start()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xE81718", Offset = "0xE81718", VA = "0xE81718")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xE817D0", Offset = "0xE817D0", VA = "0xE817D0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xE80B2C", Offset = "0xE80B2C", VA = "0xE80B2C")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xE81888", Offset = "0xE81888", VA = "0xE81888")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x23D538", Offset = "0x23D538")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xE81934", Offset = "0xE81934", VA = "0xE81934")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xE81938", Offset = "0xE81938", VA = "0xE81938")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xE81A2C", Offset = "0xE81A2C", VA = "0xE81A2C")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xE81B88", Offset = "0xE81B88", VA = "0xE81B88")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xE8162C", Offset = "0xE8162C", VA = "0xE8162C")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xE81568", Offset = "0xE81568", VA = "0xE81568")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xE81D84", Offset = "0xE81D84", VA = "0xE81D84")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace RootMotion
{
	[Serializable]
	[Token(Token = "0x2000017")]
	public enum Axis
	{
		[Token(Token = "0x40000BF")]
		X,
		[Token(Token = "0x40000C0")]
		Y,
		[Token(Token = "0x40000C1")]
		Z
	}
	[Token(Token = "0x2000018")]
	public class AxisTools
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xE0509C", Offset = "0xE0509C", VA = "0xE0509C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xE0519C", Offset = "0xE0519C", VA = "0xE0519C")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xE05278", Offset = "0xE05278", VA = "0xE05278")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xE054C4", Offset = "0xE054C4", VA = "0xE054C4")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xE053D4", Offset = "0xE053D4", VA = "0xE053D4")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xE05620", Offset = "0xE05620", VA = "0xE05620")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xE05974", Offset = "0xE05974", VA = "0xE05974")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000102")]
		public class LimbOrientation
		{
			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000979")]
			[Address(RVA = "0xE05C08", Offset = "0xE05C08", VA = "0xE05C08")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x1700002A")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0xE059B4", Offset = "0xE059B4", VA = "0xE059B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0xE05C60", Offset = "0xE05C60", VA = "0xE05C60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xE0597C", Offset = "0xE0597C", VA = "0xE0597C")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200001A")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000103")]
		public enum BoneType
		{
			[Token(Token = "0x40006A2")]
			Unassigned,
			[Token(Token = "0x40006A3")]
			Spine,
			[Token(Token = "0x40006A4")]
			Head,
			[Token(Token = "0x40006A5")]
			Arm,
			[Token(Token = "0x40006A6")]
			Leg,
			[Token(Token = "0x40006A7")]
			Tail,
			[Token(Token = "0x40006A8")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000104")]
		public enum BoneSide
		{
			[Token(Token = "0x40006AA")]
			Center,
			[Token(Token = "0x40006AB")]
			Left,
			[Token(Token = "0x40006AC")]
			Right
		}

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static string[] typeRight;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeSpine;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static string[] typeHead;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeArm;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static string[] typeLeg;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeTail;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static string[] typeEye;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeExclude;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static string[] pelvis;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] hand;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static string[] foot;

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xE05EB4", Offset = "0xE05EB4", VA = "0xE05EB4")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xE062B4", Offset = "0xE062B4", VA = "0xE062B4")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xE065A0", Offset = "0xE065A0", VA = "0xE065A0")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xE06638", Offset = "0xE06638", VA = "0xE06638")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xE066EC", Offset = "0xE066EC", VA = "0xE066EC")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xE060D8", Offset = "0xE060D8", VA = "0xE060D8")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xE064D8", Offset = "0xE064D8", VA = "0xE064D8")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xE071CC", Offset = "0xE071CC", VA = "0xE071CC")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xE06F3C", Offset = "0xE06F3C", VA = "0xE06F3C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xE07084", Offset = "0xE07084", VA = "0xE07084")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xE0696C", Offset = "0xE0696C", VA = "0xE0696C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xE06A64", Offset = "0xE06A64", VA = "0xE06A64")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xE06B5C", Offset = "0xE06B5C", VA = "0xE06B5C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xE06C54", Offset = "0xE06C54", VA = "0xE06C54")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xE06D4C", Offset = "0xE06D4C", VA = "0xE06D4C")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xE06E44", Offset = "0xE06E44", VA = "0xE06E44")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xE07414", Offset = "0xE07414", VA = "0xE07414")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xE06848", Offset = "0xE06848", VA = "0xE06848")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xE07388", Offset = "0xE07388", VA = "0xE07388")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xE074AC", Offset = "0xE074AC", VA = "0xE074AC")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xE0758C", Offset = "0xE0758C", VA = "0xE0758C")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xE072F8", Offset = "0xE072F8", VA = "0xE072F8")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xE07268", Offset = "0xE07268", VA = "0xE07268")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200001B")]
	public class BipedReferences
	{
		[Token(Token = "0x2000105")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700015D")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x600097B")]
				[Address(RVA = "0x5F6A94", Offset = "0x5F6A94", VA = "0x5F6A94")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0x2C42EC", Offset = "0x2C42EC", VA = "0x2C42EC")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform root;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform pelvis;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform leftThigh;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform leftCalf;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftFoot;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Transform rightThigh;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightCalf;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Transform rightFoot;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Transform leftForearm;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHand;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightForearm;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Transform rightHand;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform head;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Transform[] spine;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform[] eyes;

		[Token(Token = "0x1700002C")]
		public virtual bool isFilled
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xE0AE50", Offset = "0xE0AE50", VA = "0xE0AE50", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002D")]
		public bool isEmpty
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xE0B3FC", Offset = "0xE0B3FC", VA = "0xE0B3FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xE0B410", Offset = "0xE0B410", VA = "0xE0B410", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xE0BA14", Offset = "0xE0BA14", VA = "0xE0BA14", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xE0BFE8", Offset = "0xE0BFE8", VA = "0xE0BFE8")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xE0C970", Offset = "0xE0C970", VA = "0xE0C970")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xE0C2D0", Offset = "0xE0C2D0", VA = "0xE0C2D0")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xE0D768", Offset = "0xE0D768", VA = "0xE0D768")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xE0D88C", Offset = "0xE0D88C", VA = "0xE0D88C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xE0DFA4", Offset = "0xE0DFA4", VA = "0xE0DFA4")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xE0DD1C", Offset = "0xE0DD1C", VA = "0xE0DD1C")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xE0DAE8", Offset = "0xE0DAE8", VA = "0xE0DAE8")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xE0D974", Offset = "0xE0D974", VA = "0xE0D974")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xE0DE68", Offset = "0xE0DE68", VA = "0xE0DE68")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xE0E0D8", Offset = "0xE0E0D8", VA = "0xE0E0D8")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xE0F0F4", Offset = "0xE0F0F4", VA = "0xE0F0F4")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xE0E988", Offset = "0xE0E988", VA = "0xE0E988")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xE0F520", Offset = "0xE0F520", VA = "0xE0F520")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xE0EE88", Offset = "0xE0EE88", VA = "0xE0EE88")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xE0F528", Offset = "0xE0F528", VA = "0xE0F528")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xE0F530", Offset = "0xE0F530", VA = "0xE0F530")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xE0F758", Offset = "0xE0F758", VA = "0xE0F758")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xE0FA00", Offset = "0xE0FA00", VA = "0xE0FA00")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xE0C24C", Offset = "0xE0C24C", VA = "0xE0C24C")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0x2327E8", Offset = "0x2327E8")]
		public string text;

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x5F6A9C", Offset = "0x5F6A9C", VA = "0x5F6A9C")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string text;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color color;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x5F6AA4", Offset = "0x5F6AA4", VA = "0x5F6AA4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x5F6C20", Offset = "0x5F6C20", VA = "0x5F6C20")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class Hierarchy
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xE714B0", Offset = "0xE714B0", VA = "0xE714B0")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xE7173C", Offset = "0xE7173C", VA = "0xE7173C")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xE71548", Offset = "0xE71548", VA = "0xE71548")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xE7189C", Offset = "0xE7189C", VA = "0xE7189C")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xE719FC", Offset = "0xE719FC", VA = "0xE719FC")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xE71D78", Offset = "0xE71D78", VA = "0xE71D78")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xE71EF8", Offset = "0xE71EF8", VA = "0xE71EF8")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xE72124", Offset = "0xE72124", VA = "0xE72124")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xE725B4", Offset = "0xE725B4", VA = "0xE725B4")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xE7230C", Offset = "0xE7230C", VA = "0xE7230C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xE727D8", Offset = "0xE727D8", VA = "0xE727D8")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string color;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xE727E0", Offset = "0xE727E0", VA = "0xE727E0")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xE7285C", Offset = "0xE7285C", VA = "0xE7285C")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000020")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000EF")]
		None,
		[Token(Token = "0x40000F0")]
		InOutCubic,
		[Token(Token = "0x40000F1")]
		InOutQuintic,
		[Token(Token = "0x40000F2")]
		InOutSine,
		[Token(Token = "0x40000F3")]
		InQuintic,
		[Token(Token = "0x40000F4")]
		InQuartic,
		[Token(Token = "0x40000F5")]
		InCubic,
		[Token(Token = "0x40000F6")]
		InQuadratic,
		[Token(Token = "0x40000F7")]
		InElastic,
		[Token(Token = "0x40000F8")]
		InElasticSmall,
		[Token(Token = "0x40000F9")]
		InElasticBig,
		[Token(Token = "0x40000FA")]
		InSine,
		[Token(Token = "0x40000FB")]
		InBack,
		[Token(Token = "0x40000FC")]
		OutQuintic,
		[Token(Token = "0x40000FD")]
		OutQuartic,
		[Token(Token = "0x40000FE")]
		OutCubic,
		[Token(Token = "0x40000FF")]
		OutInCubic,
		[Token(Token = "0x4000100")]
		OutInQuartic,
		[Token(Token = "0x4000101")]
		OutElastic,
		[Token(Token = "0x4000102")]
		OutElasticSmall,
		[Token(Token = "0x4000103")]
		OutElasticBig,
		[Token(Token = "0x4000104")]
		OutSine,
		[Token(Token = "0x4000105")]
		OutBack,
		[Token(Token = "0x4000106")]
		OutBackCubic,
		[Token(Token = "0x4000107")]
		OutBackQuartic,
		[Token(Token = "0x4000108")]
		BackInCubic,
		[Token(Token = "0x4000109")]
		BackInQuartic
	}
	[Token(Token = "0x2000021")]
	public class Interp
	{
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xE728D8", Offset = "0xE728D8", VA = "0xE728D8")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xE7357C", Offset = "0xE7357C", VA = "0xE7357C")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xE7369C", Offset = "0xE7369C", VA = "0xE7369C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xE72C9C", Offset = "0xE72C9C", VA = "0xE72C9C")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xE72CB8", Offset = "0xE72CB8", VA = "0xE72CB8")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xE72CF0", Offset = "0xE72CF0", VA = "0xE72CF0")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xE72D3C", Offset = "0xE72D3C", VA = "0xE72D3C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xE72D64", Offset = "0xE72D64", VA = "0xE72D64")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xE72D88", Offset = "0xE72D88", VA = "0xE72D88")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xE72DAC", Offset = "0xE72DAC", VA = "0xE72DAC")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xE72DCC", Offset = "0xE72DCC", VA = "0xE72DCC")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xE72E24", Offset = "0xE72E24", VA = "0xE72E24")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xE72E6C", Offset = "0xE72E6C", VA = "0xE72E6C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xE72EA4", Offset = "0xE72EA4", VA = "0xE72EA4")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xE737BC", Offset = "0xE737BC", VA = "0xE737BC")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xE72EE8", Offset = "0xE72EE8", VA = "0xE72EE8")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xE72F20", Offset = "0xE72F20", VA = "0xE72F20")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xE72F60", Offset = "0xE72F60", VA = "0xE72F60")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xE72FA4", Offset = "0xE72FA4", VA = "0xE72FA4")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xE72FF8", Offset = "0xE72FF8", VA = "0xE72FF8")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xE7306C", Offset = "0xE7306C", VA = "0xE7306C")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xE730E0", Offset = "0xE730E0", VA = "0xE730E0")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xE73144", Offset = "0xE73144", VA = "0xE73144")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xE731A8", Offset = "0xE731A8", VA = "0xE731A8")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xE73260", Offset = "0xE73260", VA = "0xE73260")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xE73314", Offset = "0xE73314", VA = "0xE73314")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xE73800", Offset = "0xE73800", VA = "0xE73800")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xE733D8", Offset = "0xE733D8", VA = "0xE733D8")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xE734EC", Offset = "0xE734EC", VA = "0xE734EC")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xE7352C", Offset = "0xE7352C", VA = "0xE7352C")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xE73918", Offset = "0xE73918", VA = "0xE73918")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string color;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xE73920", Offset = "0xE73920", VA = "0xE73920")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xE7399C", Offset = "0xE7399C", VA = "0xE7399C")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000023")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x6000114")]
		[Address(RVA = "0xE73A18", Offset = "0xE73A18", VA = "0xE73A18")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xE73A60", Offset = "0xE73A60", VA = "0xE73A60")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xE73B04", Offset = "0xE73B04", VA = "0xE73B04")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xE73A64", Offset = "0xE73A64", VA = "0xE73A64")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xE73B08", Offset = "0xE73B08", VA = "0xE73B08")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xE73B98", Offset = "0xE73B98", VA = "0xE73B98")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xE73BB8", Offset = "0xE73BB8", VA = "0xE73BB8")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xE73BF0", Offset = "0xE73BF0", VA = "0xE73BF0")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xE73C40", Offset = "0xE73C40", VA = "0xE73C40")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xE73D58", Offset = "0xE73D58", VA = "0xE73D58")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xE73E50", Offset = "0xE73E50", VA = "0xE73E50")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xE73EC4", Offset = "0xE73EC4", VA = "0xE73EC4")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000024")]
	public static class QuaTools
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0xE73EE8", Offset = "0xE73EE8", VA = "0xE73EE8")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xE74018", Offset = "0xE74018", VA = "0xE74018")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xE74148", Offset = "0xE74148", VA = "0xE74148")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xE7428C", Offset = "0xE7428C", VA = "0xE7428C")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xE743D0", Offset = "0xE743D0", VA = "0xE743D0")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xE745B8", Offset = "0xE745B8", VA = "0xE745B8")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xE746B8", Offset = "0xE746B8", VA = "0xE746B8")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xE74828", Offset = "0xE74828", VA = "0xE74828")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xE74B78", Offset = "0xE74B78", VA = "0xE74B78")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xE74E08", Offset = "0xE74E08", VA = "0xE74E08")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xE6E228", Offset = "0xE6E228", VA = "0xE6E228")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000025")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700002E")]
		public static T instance
		{
			[Token(Token = "0x600012B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600012C")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600012D")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2327F8", Offset = "0x2327F8")]
		public bool fixTransforms;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Animator animator;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Animation legacy;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool updateFrame;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool componentInitiated;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700002F")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0xE75118", Offset = "0xE75118", VA = "0xE75118")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000030")]
		private bool isAnimated
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0xE75530", Offset = "0xE75530", VA = "0xE75530")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xE74FD8", Offset = "0xE74FD8", VA = "0xE74FD8")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xE7508C", Offset = "0xE7508C", VA = "0xE7508C", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xE75090", Offset = "0xE75090", VA = "0xE75090", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xE75094", Offset = "0xE75094", VA = "0xE75094", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xE75098", Offset = "0xE75098", VA = "0xE75098")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xE75114", Offset = "0xE75114", VA = "0xE75114")]
		private void Start()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xE750C0", Offset = "0xE750C0", VA = "0xE750C0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xE754E0", Offset = "0xE754E0", VA = "0xE754E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xE75250", Offset = "0xE75250", VA = "0xE75250")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xE75608", Offset = "0xE75608", VA = "0xE75608")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xE75664", Offset = "0xE75664", VA = "0xE75664")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xE756C4", Offset = "0xE756C4", VA = "0xE756C4")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xE75700", Offset = "0xE75700", VA = "0xE75700")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public GameObject target;

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xE75710", Offset = "0xE75710", VA = "0xE75710")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xE757EC", Offset = "0xE757EC", VA = "0xE757EC")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xE758C8", Offset = "0xE758C8", VA = "0xE758C8")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xE759A4", Offset = "0xE759A4", VA = "0xE759A4")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public static class V3Tools
	{
		[Token(Token = "0x6000142")]
		[Address(RVA = "0xE759AC", Offset = "0xE759AC", VA = "0xE759AC")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xE75AC0", Offset = "0xE75AC0", VA = "0xE75AC0")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xE75BD4", Offset = "0xE75BD4", VA = "0xE75BD4")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xE75D00", Offset = "0xE75D00", VA = "0xE75D00")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xE75E60", Offset = "0xE75E60", VA = "0xE75E60")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xE76118", Offset = "0xE76118", VA = "0xE76118")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xE763C4", Offset = "0xE763C4", VA = "0xE763C4")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xE765DC", Offset = "0xE765DC", VA = "0xE765DC")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000029")]
	public static class Warning
	{
		[Token(Token = "0x2000106")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xE767F8", Offset = "0xE767F8", VA = "0xE767F8")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xE76CB4", Offset = "0xE76CB4", VA = "0xE76CB4")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Serializable]
	[Token(Token = "0x200002A")]
	public class Navigator
	{
		[Token(Token = "0x2000107")]
		public enum State
		{
			[Token(Token = "0x40006B0")]
			Idle,
			[Token(Token = "0x40006B1")]
			Seeking,
			[Token(Token = "0x40006B2")]
			OnPath
		}

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23282C", Offset = "0x23282C")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23288C", Offset = "0x23288C")]
		public float cornerRadius;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2328C0", Offset = "0x2328C0")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2328F4", Offset = "0x2328F4")]
		public float maxSampleDistance;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232954", Offset = "0x232954")]
		public float nextPathInterval;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2329A0", Offset = "0x2329A0")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2329B0", Offset = "0x2329B0")]
		private State <state>k__BackingField;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Transform transform;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int cornerIndex;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3[] corners;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private NavMeshPath path;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool initiated;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float nextPathTime;

		[Token(Token = "0x17000031")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x5F6C64", Offset = "0x5F6C64", VA = "0x5F6C64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D620", Offset = "0x23D620")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x5F6C78", Offset = "0x5F6C78", VA = "0x5F6C78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D630", Offset = "0x23D630")]
			private set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public State state
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x5F6C84", Offset = "0x5F6C84", VA = "0x5F6C84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D640", Offset = "0x23D640")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x5F6C8C", Offset = "0x5F6C8C", VA = "0x5F6C8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D650", Offset = "0x23D650")]
			private set
			{
			}
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x5F6C94", Offset = "0x5F6C94", VA = "0x5F6C94")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x5F6D7C", Offset = "0x5F6D7C", VA = "0x5F6D7C")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x5F7498", Offset = "0x5F7498", VA = "0x5F7498")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x5F7500", Offset = "0x5F7500", VA = "0x5F7500")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x5F7318", Offset = "0x5F7318", VA = "0x5F7318")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x5F73B8", Offset = "0x5F73B8", VA = "0x5F73B8")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x5F769C", Offset = "0x5F769C", VA = "0x5F769C")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x5F7998", Offset = "0x5F7998", VA = "0x5F7998")]
		public Navigator()
		{
		}
	}
}
namespace RootMotion.Dynamics
{
	[Token(Token = "0x200002B")]
	public class AnimationBlocker : MonoBehaviour
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x5F7A30", Offset = "0x5F7A30", VA = "0x5F7A30")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x5F7B68", Offset = "0x5F7B68", VA = "0x5F7B68")]
		public AnimationBlocker()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2309D4", Offset = "0x2309D4")]
	public class BehaviourAnimatedStagger : BehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000108")]
		public struct FallParams
		{
			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float startPinWeightMlp;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float startMuscleWeightMlp;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float losePinSpeed;
		}

		[Serializable]
		[Token(Token = "0x2000109")]
		public struct FallParamsGroup
		{
			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Muscle.Group[] groups;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public FallParams fallParams;
		}

		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x232200", Offset = "0x232200")]
		private sealed class <LoseBalance>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BehaviourAnimatedStagger <>4__this;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private bool <done>5__2;

			[Token(Token = "0x1700015E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000983")]
				[Address(RVA = "0x5F8D40", Offset = "0x5F8D40", VA = "0x5F8D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000985")]
				[Address(RVA = "0x5F8DD0", Offset = "0x5F8DD0", VA = "0x5F8DD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000980")]
			[Address(RVA = "0x5F7C60", Offset = "0x5F7C60", VA = "0x5F7C60")]
			[DebuggerHidden]
			public <LoseBalance>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000981")]
			[Address(RVA = "0x5F7DC8", Offset = "0x5F7DC8", VA = "0x5F7DC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000982")]
			[Address(RVA = "0x5F7DCC", Offset = "0x5F7DCC", VA = "0x5F7DCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000984")]
			[Address(RVA = "0x5F8D48", Offset = "0x5F8D48", VA = "0x5F8D48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2329C0", Offset = "0x2329C0")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float animationBlendSpeed;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float animationMag;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float momentumMag;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float unbalancedMuscleWeightMlp;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float unbalancedMuscleDamperAdd;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool dropProps;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxGetUpVelocity;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float minHipHeight;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public SubBehaviourCOM centerOfMass;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x232A00", Offset = "0x232A00")]
		public FallParams defaults;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public FallParamsGroup[] groupOverrides;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x232A34", Offset = "0x232A34")]
		public PuppetEvent onUngrounded;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public PuppetEvent onFallOver;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public PuppetEvent onRest;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x232A68", Offset = "0x232A68")]
		public Vector3 moveVector;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x232A78", Offset = "0x232A78")]
		public bool isGrounded;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x232A88", Offset = "0x232A88")]
		public Vector3 forward;

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x5F7B70", Offset = "0x5F7B70", VA = "0x5F7B70", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x5F7BAC", Offset = "0x5F7BAC", VA = "0x5F7BAC", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x5F7C5C", Offset = "0x5F7C5C", VA = "0x5F7C5C", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x5F7BD0", Offset = "0x5F7BD0", VA = "0x5F7BD0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x23D660", Offset = "0x23D660")]
		private IEnumerator LoseBalance()
		{
			return null;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x5F7C80", Offset = "0x5F7C80", VA = "0x5F7C80")]
		private FallParams GetFallParams(Muscle.Group group)
		{
			return default(FallParams);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x5F7D78", Offset = "0x5F7D78", VA = "0x5F7D78")]
		public BehaviourAnimatedStagger()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public abstract class BehaviourBase : MonoBehaviour
	{
		[Token(Token = "0x200010B")]
		public delegate void BehaviourDelegate();

		[Token(Token = "0x200010C")]
		public delegate void HitDelegate(MuscleHit hit);

		[Token(Token = "0x200010D")]
		public delegate void CollisionDelegate(MuscleCollision collision);

		[Serializable]
		[Token(Token = "0x200010E")]
		public struct PuppetEvent
		{
			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238B8C", Offset = "0x238B8C")]
			public string switchToBehaviour;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238BC0", Offset = "0x238BC0")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238BF4", Offset = "0x238BF4")]
			public UnityEvent unityEvent;

			[Token(Token = "0x40006BF")]
			private const string empty = "";

			[Token(Token = "0x17000160")]
			public bool switchBehaviour
			{
				[Token(Token = "0x6000992")]
				[Address(RVA = "0x2C4544", Offset = "0x2C4544", VA = "0x2C4544")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0x2C454C", Offset = "0x2C454C", VA = "0x2C454C")]
			public void Trigger(PuppetMaster puppetMaster, bool switchBehaviourEnabled = true)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010F")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string animationState;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float crossfadeTime;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int layer;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40006C4")]
			private const string empty = "";

			[Token(Token = "0x6000994")]
			[Address(RVA = "0x5FBF24", Offset = "0x5FBF24", VA = "0x5FBF24")]
			public void Activate(Animator animator, Animation animation)
			{
			}

			[Token(Token = "0x6000995")]
			[Address(RVA = "0x5FC018", Offset = "0x5FC018", VA = "0x5FC018")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000996")]
			[Address(RVA = "0x5FC188", Offset = "0x5FC188", VA = "0x5FC188")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000997")]
			[Address(RVA = "0x5FC2D4", Offset = "0x5FC2D4", VA = "0x5FC2D4")]
			public AnimatorEvent()
			{
			}
		}

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x232A98", Offset = "0x232A98")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BehaviourDelegate OnPreActivate;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BehaviourDelegate OnPreInitiate;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BehaviourDelegate OnPreFixedUpdate;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BehaviourDelegate OnPreUpdate;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BehaviourDelegate OnPreLateUpdate;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public BehaviourDelegate OnPreDeactivate;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BehaviourDelegate OnPreFixTransforms;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BehaviourDelegate OnPreRead;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BehaviourDelegate OnPreWrite;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public HitDelegate OnPreMuscleHit;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CollisionDelegate OnPreMuscleCollision;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public CollisionDelegate OnPreMuscleCollisionExit;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BehaviourDelegate OnHierarchyChanged;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public BehaviourDelegate OnPostActivate;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourDelegate OnPostInitiate;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public BehaviourDelegate OnPostFixedUpdate;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public BehaviourDelegate OnPostUpdate;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public BehaviourDelegate OnPostLateUpdate;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public BehaviourDelegate OnPostDeactivate;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public BehaviourDelegate OnPostDrawGizmos;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public BehaviourDelegate OnPostFixTransforms;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public BehaviourDelegate OnPostRead;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public BehaviourDelegate OnPostWrite;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public HitDelegate OnPostMuscleHit;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public CollisionDelegate OnPostMuscleCollision;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public CollisionDelegate OnPostMuscleCollisionExit;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x232AA8", Offset = "0x232AA8")]
		public bool deactivated;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x232AB8", Offset = "0x232AB8")]
		private bool <forceActive>k__BackingField;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		private bool initiated;

		[Token(Token = "0x17000033")]
		public bool forceActive
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x5F9088", Offset = "0x5F9088", VA = "0x5F9088")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D6D8", Offset = "0x23D6D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x5F9090", Offset = "0x5F9090", VA = "0x5F9090")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D6E8", Offset = "0x23D6E8")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000160")]
		public abstract void OnReactivate();

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x5F8DD8", Offset = "0x5F8DD8", VA = "0x5F8DD8", Slot = "5")]
		public virtual void Resurrect()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x5F8DDC", Offset = "0x5F8DDC", VA = "0x5F8DDC", Slot = "6")]
		public virtual void Freeze()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x5F8DE0", Offset = "0x5F8DE0", VA = "0x5F8DE0", Slot = "7")]
		public virtual void Unfreeze()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x5F8DE4", Offset = "0x5F8DE4", VA = "0x5F8DE4", Slot = "8")]
		public virtual void KillStart()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x5F8DE8", Offset = "0x5F8DE8", VA = "0x5F8DE8", Slot = "9")]
		public virtual void KillEnd()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x5F8DEC", Offset = "0x5F8DEC", VA = "0x5F8DEC", Slot = "10")]
		public virtual void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x5F8DF0", Offset = "0x5F8DF0", VA = "0x5F8DF0", Slot = "11")]
		public virtual void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x5F9044", Offset = "0x5F9044", VA = "0x5F9044", Slot = "12")]
		public virtual void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x5F9054", Offset = "0x5F9054", VA = "0x5F9054", Slot = "13")]
		protected virtual void OnActivate()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x5F9058", Offset = "0x5F9058", VA = "0x5F9058", Slot = "14")]
		protected virtual void OnDeactivate()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x5F905C", Offset = "0x5F905C", VA = "0x5F905C", Slot = "15")]
		protected virtual void OnInitiate()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x5F9060", Offset = "0x5F9060", VA = "0x5F9060", Slot = "16")]
		protected virtual void OnFixedUpdate()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x5F9064", Offset = "0x5F9064", VA = "0x5F9064", Slot = "17")]
		protected virtual void OnUpdate()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x5F9068", Offset = "0x5F9068", VA = "0x5F9068", Slot = "18")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x5F906C", Offset = "0x5F906C", VA = "0x5F906C", Slot = "19")]
		protected virtual void OnDrawGizmosBehaviour()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x5F9070", Offset = "0x5F9070", VA = "0x5F9070", Slot = "20")]
		protected virtual void OnFixTransformsBehaviour()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x5F9074", Offset = "0x5F9074", VA = "0x5F9074", Slot = "21")]
		protected virtual void OnReadBehaviour()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x5F9078", Offset = "0x5F9078", VA = "0x5F9078", Slot = "22")]
		protected virtual void OnWriteBehaviour()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x5F907C", Offset = "0x5F907C", VA = "0x5F907C", Slot = "23")]
		protected virtual void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x5F9080", Offset = "0x5F9080", VA = "0x5F9080", Slot = "24")]
		protected virtual void OnMuscleCollisionBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x5F9084", Offset = "0x5F9084", VA = "0x5F9084", Slot = "25")]
		protected virtual void OnMuscleCollisionExitBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x5F9098", Offset = "0x5F9098", VA = "0x5F9098")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x5F90E0", Offset = "0x5F90E0", VA = "0x5F90E0")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x5F9144", Offset = "0x5F9144", VA = "0x5F9144")]
		public void OnRead()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x5F91A8", Offset = "0x5F91A8", VA = "0x5F91A8")]
		public void OnWrite()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x5F920C", Offset = "0x5F920C", VA = "0x5F920C")]
		public void OnMuscleHit(MuscleHit hit)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x5F95E8", Offset = "0x5F95E8", VA = "0x5F95E8")]
		public void OnMuscleCollision(MuscleCollision collision)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x5F98E4", Offset = "0x5F98E4", VA = "0x5F98E4")]
		public void OnMuscleCollisionExit(MuscleCollision collision)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x5F9970", Offset = "0x5F9970", VA = "0x5F9970")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x5F9980", Offset = "0x5F9980", VA = "0x5F9980")]
		public void Activate()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x5F9AC8", Offset = "0x5F9AC8", VA = "0x5F9AC8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x5F9B18", Offset = "0x5F9B18", VA = "0x5F9B18")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x5F9BF8", Offset = "0x5F9BF8", VA = "0x5F9BF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x5F9CD8", Offset = "0x5F9CD8", VA = "0x5F9CD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x5F9DB8", Offset = "0x5F9DB8", VA = "0x5F9DB8", Slot = "26")]
		protected virtual void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x5F9DFC", Offset = "0x5F9DFC", VA = "0x5F9DFC")]
		protected void RotateTargetToRootMuscle()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x5FA090", Offset = "0x5FA090", VA = "0x5FA090")]
		protected void TranslateTargetToRootMuscle(float maintainY)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x5F8848", Offset = "0x5F8848", VA = "0x5F8848")]
		protected void RemoveMusclesOfGroup(Muscle.Group group)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x5FBCCC", Offset = "0x5FBCCC", VA = "0x5FBCCC", Slot = "27")]
		protected virtual void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x5FBC24", Offset = "0x5FBC24", VA = "0x5FBC24")]
		protected bool MusclesContainsGroup(Muscle.Group group)
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x5F7DC0", Offset = "0x5F7DC0", VA = "0x5F7DC0")]
		protected BehaviourBase()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x230A08", Offset = "0x230A08")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x230A08", Offset = "0x230A08")]
	public class BehaviourFall : BehaviourBase
	{
		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x232210", Offset = "0x232210")]
		private sealed class <SmoothActivate>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BehaviourFall <>4__this;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <fader>5__2;

			[Token(Token = "0x17000161")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600099B")]
				[Address(RVA = "0x5FD608", Offset = "0x5FD608", VA = "0x5FD608", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000162")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600099D")]
				[Address(RVA = "0x5FD698", Offset = "0x5FD698", VA = "0x5FD698", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000998")]
			[Address(RVA = "0x5FC858", Offset = "0x5FC858", VA = "0x5FC858")]
			[DebuggerHidden]
			public <SmoothActivate>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000999")]
			[Address(RVA = "0x5FD35C", Offset = "0x5FD35C", VA = "0x5FD35C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600099A")]
			[Address(RVA = "0x5FD360", Offset = "0x5FD360", VA = "0x5FD360", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600099C")]
			[Address(RVA = "0x5FD610", Offset = "0x5FD610", VA = "0x5FD610", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x232AC8", Offset = "0x232AC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232AC8", Offset = "0x232AC8")]
		public string stateName;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232B30", Offset = "0x232B30")]
		public float transitionDuration;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232B64", Offset = "0x232B64")]
		public int layer;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232B98", Offset = "0x232B98")]
		public float fixedTime;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x232BCC", Offset = "0x232BCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232BCC", Offset = "0x232BCC")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232C30", Offset = "0x232C30")]
		public string blendParameter;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232C64", Offset = "0x232C64")]
		public float writheHeight;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232C98", Offset = "0x232C98")]
		public float writheYVelocity;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232CCC", Offset = "0x232CCC")]
		public float blendSpeed;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232D34", Offset = "0x232D34")]
		public float blendMappingSpeed;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x232D90", Offset = "0x232D90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232D90", Offset = "0x232D90")]
		public bool canEnd;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232E14", Offset = "0x232E14")]
		public float minTime;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232E48", Offset = "0x232E48")]
		public float maxEndVelocity;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232E7C", Offset = "0x232E7C")]
		public PuppetEvent onEnd;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float timer;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool endTriggered;

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x5FC6B4", Offset = "0x5FC6B4", VA = "0x5FC6B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23D6F8", Offset = "0x23D6F8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x5FC714", Offset = "0x5FC714", VA = "0x5FC714")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23D72C", Offset = "0x23D72C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x5FC774", Offset = "0x5FC774", VA = "0x5FC774", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x5FC83C", Offset = "0x5FC83C", VA = "0x5FC83C", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x5FC848", Offset = "0x5FC848", VA = "0x5FC848", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x5FC7B0", Offset = "0x5FC7B0", VA = "0x5FC7B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x23D760", Offset = "0x23D760")]
		private IEnumerator SmoothActivate()
		{
			return null;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x5FC878", Offset = "0x5FC878", VA = "0x5FC878", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x5FCFE0", Offset = "0x5FCFE0", VA = "0x5FCFE0", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x5FD218", Offset = "0x5FD218", VA = "0x5FD218", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x5FCD5C", Offset = "0x5FCD5C", VA = "0x5FCD5C")]
		private float GetBlendTarget(float groundHeight)
		{
			return default(float);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x5FCB8C", Offset = "0x5FCB8C", VA = "0x5FCB8C")]
		private float GetGroundHeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x5FD2A0", Offset = "0x5FD2A0", VA = "0x5FD2A0")]
		public BehaviourFall()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x230A98", Offset = "0x230A98")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x230A98", Offset = "0x230A98")]
	public class BehaviourPuppet : BehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000111")]
		public enum State
		{
			[Token(Token = "0x40006CA")]
			Puppet,
			[Token(Token = "0x40006CB")]
			Unpinned,
			[Token(Token = "0x40006CC")]
			GetUp
		}

		[Serializable]
		[Token(Token = "0x2000112")]
		public enum NormalMode
		{
			[Token(Token = "0x40006CE")]
			Active,
			[Token(Token = "0x40006CF")]
			Unmapped,
			[Token(Token = "0x40006D0")]
			Kinematic
		}

		[Serializable]
		[Token(Token = "0x2000113")]
		public class MasterProps
		{
			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public NormalMode normalMode;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float mappingBlendSpeed;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool activateOnStaticCollisions;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float activateOnImpulse;

			[Token(Token = "0x600099E")]
			[Address(RVA = "0x603A28", Offset = "0x603A28", VA = "0x603A28")]
			public MasterProps()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000114")]
		public struct MuscleProps
		{
			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238C28", Offset = "0x238C28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x238C28", Offset = "0x238C28")]
			public float unpinParents;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238C78", Offset = "0x238C78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x238C78", Offset = "0x238C78")]
			public float unpinChildren;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238CC8", Offset = "0x238CC8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x238CC8", Offset = "0x238CC8")]
			public float unpinGroup;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238D18", Offset = "0x238D18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x238D18", Offset = "0x238D18")]
			public float minMappingWeight;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238D68", Offset = "0x238D68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x238D68", Offset = "0x238D68")]
			public float maxMappingWeight;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238DB8", Offset = "0x238DB8")]
			public bool disableColliders;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238DEC", Offset = "0x238DEC")]
			public float regainPinSpeed;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238E20", Offset = "0x238E20")]
			public float collisionResistance;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238E54", Offset = "0x238E54")]
			public float knockOutDistance;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238E88", Offset = "0x238E88")]
			public PhysicMaterial puppetMaterial;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238EBC", Offset = "0x238EBC")]
			public PhysicMaterial unpinnedMaterial;
		}

		[Serializable]
		[Token(Token = "0x2000115")]
		public struct MusclePropsGroup
		{
			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x238EF0", Offset = "0x238EF0")]
			public string name;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238F00", Offset = "0x238F00")]
			public Muscle.Group[] groups;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238F5C", Offset = "0x238F5C")]
			public MuscleProps props;
		}

		[Serializable]
		[Token(Token = "0x2000116")]
		public struct CollisionResistanceMultiplier
		{
			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LayerMask layers;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238FB8", Offset = "0x238FB8")]
			public float multiplier;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239020", Offset = "0x239020")]
			public float collisionThreshold;
		}

		[Token(Token = "0x2000117")]
		public delegate void CollisionImpulseDelegate(MuscleCollision m, float impulse);

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x232EDC", Offset = "0x232EDC")]
		public MasterProps masterProps;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232F20", Offset = "0x232F20")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232F84", Offset = "0x232F84")]
		public LayerMask collisionLayers;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x232FE8", Offset = "0x232FE8")]
		public float collisionThreshold;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public Weight collisionResistance;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23301C", Offset = "0x23301C")]
		public CollisionResistanceMultiplier[] collisionResistanceMultipliers;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233084", Offset = "0x233084")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x233084", Offset = "0x233084")]
		public int maxCollisions;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2330D8", Offset = "0x2330D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2330D8", Offset = "0x2330D8")]
		public float regainPinSpeed;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233130", Offset = "0x233130")]
		public float boostFalloff;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x233164", Offset = "0x233164")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233164", Offset = "0x233164")]
		public MuscleProps defaults;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2331C4", Offset = "0x2331C4")]
		public MusclePropsGroup[] groupOverrides;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2331F8", Offset = "0x2331F8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2331F8", Offset = "0x2331F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2331F8", Offset = "0x2331F8")]
		public float knockOutDistance;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233280", Offset = "0x233280")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x233280", Offset = "0x233280")]
		public float unpinnedMuscleWeightMlp;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2332D0", Offset = "0x2332D0")]
		public float maxRigidbodyVelocity;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233304", Offset = "0x233304")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x233304", Offset = "0x233304")]
		public float pinWeightThreshold;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233354", Offset = "0x233354")]
		public bool unpinnedMuscleKnockout;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233388", Offset = "0x233388")]
		public bool dropProps;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE2")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2333BC", Offset = "0x2333BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2333BC", Offset = "0x2333BC")]
		public bool canGetUp;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233420", Offset = "0x233420")]
		public float getUpDelay;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233454", Offset = "0x233454")]
		public float blendToAnimationTime;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233488", Offset = "0x233488")]
		public float maxGetUpVelocity;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2334BC", Offset = "0x2334BC")]
		public float minGetUpDuration;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2334F0", Offset = "0x2334F0")]
		public float getUpCollisionResistanceMlp;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233524", Offset = "0x233524")]
		public float getUpRegainPinSpeedMlp;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233558", Offset = "0x233558")]
		public float getUpKnockOutDistanceMlp;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23358C", Offset = "0x23358C")]
		public Vector3 getUpOffsetProne;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2335C0", Offset = "0x2335C0")]
		public Vector3 getUpOffsetSupine;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2335F4", Offset = "0x2335F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2335F4", Offset = "0x2335F4")]
		public PuppetEvent onGetUpProne;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233654", Offset = "0x233654")]
		public PuppetEvent onGetUpSupine;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233688", Offset = "0x233688")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2336BC", Offset = "0x2336BC")]
		public PuppetEvent onLoseBalanceFromPuppet;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2336F0", Offset = "0x2336F0")]
		public PuppetEvent onLoseBalanceFromGetUp;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233724", Offset = "0x233724")]
		public PuppetEvent onRegainBalance;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public CollisionImpulseDelegate OnCollisionImpulse;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233758", Offset = "0x233758")]
		private State <state>k__BackingField;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x233768", Offset = "0x233768")]
		public bool canMoveTarget;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float unpinnedTimer;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float getUpTimer;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private Vector3 hipsForward;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 hipsUp;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float getupAnimationBlendWeight;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private float getupAnimationBlendWeightV;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private bool getUpTargetFixed;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private NormalMode lastNormalMode;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private int collisions;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private bool eventsEnabled;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private float lastKnockOutDistance;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private float knockOutDistanceSqr;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private bool getupDisabled;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AD")]
		private bool hasCollidedSinceGetUp;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AE")]
		private bool hasBoosted;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector3 getUpPosition;

		[Token(Token = "0x17000034")]
		public State state
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x5FD760", Offset = "0x5FD760", VA = "0x5FD760")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D840", Offset = "0x23D840")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x5FD768", Offset = "0x5FD768", VA = "0x5FD768")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D850", Offset = "0x23D850")]
			private set
			{
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x5FD6A0", Offset = "0x5FD6A0", VA = "0x5FD6A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23D7D8", Offset = "0x23D7D8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x5FD700", Offset = "0x5FD700", VA = "0x5FD700")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23D80C", Offset = "0x23D80C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x5FD770", Offset = "0x5FD770", VA = "0x5FD770", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x5FDAFC", Offset = "0x5FDAFC", VA = "0x5FDAFC")]
		public void Reset(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x5FDB88", Offset = "0x5FDB88", VA = "0x5FDB88", Slot = "10")]
		public override void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x5FDD20", Offset = "0x5FDD20", VA = "0x5FDD20", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x5FE624", Offset = "0x5FE624", VA = "0x5FE624", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x5FF1E0", Offset = "0x5FF1E0", VA = "0x5FF1E0", Slot = "8")]
		public override void KillStart()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x5FF28C", Offset = "0x5FF28C", VA = "0x5FF28C", Slot = "9")]
		public override void KillEnd()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x5FF294", Offset = "0x5FF294", VA = "0x5FF294", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x5FF344", Offset = "0x5FF344", VA = "0x5FF344", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x5FF350", Offset = "0x5FF350", VA = "0x5FF350", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x5FFF14", Offset = "0x5FFF14", VA = "0x5FFF14", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x6003EC", Offset = "0x6003EC", VA = "0x6003EC")]
		private bool SetKinematic()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x600528", Offset = "0x600528", VA = "0x600528", Slot = "21")]
		protected override void OnReadBehaviour()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x600144", Offset = "0x600144", VA = "0x600144")]
		private void BlendMuscleMapping(int muscleIndex, ref bool to)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x601230", Offset = "0x601230", VA = "0x601230", Slot = "11")]
		public override void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x601268", Offset = "0x601268", VA = "0x601268", Slot = "12")]
		public override void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x6008CC", Offset = "0x6008CC", VA = "0x6008CC")]
		protected void MoveTarget(Vector3 position)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x601298", Offset = "0x601298", VA = "0x601298")]
		protected void RotateTarget(Quaternion rotation)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x601310", Offset = "0x601310", VA = "0x601310", Slot = "27")]
		protected override void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x601320", Offset = "0x601320", VA = "0x601320")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x601678", Offset = "0x601678", VA = "0x601678")]
		public void Boost(float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x6016FC", Offset = "0x6016FC", VA = "0x6016FC")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x6019F8", Offset = "0x6019F8", VA = "0x6019F8")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x601CF4", Offset = "0x601CF4", VA = "0x601CF4")]
		public void BoostImmunity(float immunity)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x601734", Offset = "0x601734", VA = "0x601734")]
		public void BoostImmunity(int muscleIndex, float immunity)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x601D70", Offset = "0x601D70", VA = "0x601D70")]
		public void BoostImmunity(int muscleIndex, float immunity, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x601E18", Offset = "0x601E18", VA = "0x601E18")]
		public void BoostImpulseMlp(float impulseMlp)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x601898", Offset = "0x601898", VA = "0x601898")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x601E84", Offset = "0x601E84", VA = "0x601E84")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x601F2C", Offset = "0x601F2C", VA = "0x601F2C")]
		public void Unpin()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x601FC8", Offset = "0x601FC8", VA = "0x601FC8", Slot = "23")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x6022C4", Offset = "0x6022C4", VA = "0x6022C4", Slot = "24")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x60286C", Offset = "0x60286C", VA = "0x60286C")]
		private float GetImpulse(MuscleCollision m, ref float layerThreshold)
		{
			return default(float);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x602158", Offset = "0x602158", VA = "0x602158")]
		private void UnPin(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x602FE8", Offset = "0x602FE8", VA = "0x602FE8")]
		private void UnPinMuscle(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x602D08", Offset = "0x602D08", VA = "0x602D08")]
		private bool Activate(Collision collision, float impulse)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x6033D0", Offset = "0x6033D0", VA = "0x6033D0")]
		public bool IsProne()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x601B08", Offset = "0x601B08", VA = "0x601B08")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren)
		{
			return default(float);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x602E00", Offset = "0x602E00", VA = "0x602E00")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren, float falloffGroup)
		{
			return default(float);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x60359C", Offset = "0x60359C", VA = "0x60359C")]
		private bool InGroup(Muscle.Group group1, Muscle.Group group2)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x5FFDC4", Offset = "0x5FFDC4", VA = "0x5FFDC4")]
		private MuscleProps GetProps(Muscle.Group group)
		{
			return default(MuscleProps);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x5FE6F0", Offset = "0x5FE6F0", VA = "0x5FE6F0")]
		public void SetState(State newState)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x603864", Offset = "0x603864", VA = "0x603864")]
		public void SetColliders(bool unpinned)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x5FD88C", Offset = "0x5FD88C", VA = "0x5FD88C")]
		private void SetColliders(Muscle m, bool unpinned)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x6038E8", Offset = "0x6038E8", VA = "0x6038E8")]
		public BehaviourPuppet()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x230B28", Offset = "0x230B28")]
	public class BehaviourTemplate : BehaviourBase
	{
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public SubBehaviourCOM centerOfMass;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public LayerMask groundLayers;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float loseBalanceAngle;

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x603B1C", Offset = "0x603B1C", VA = "0x603B1C", Slot = "15")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x603B58", Offset = "0x603B58", VA = "0x603B58", Slot = "13")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x603B5C", Offset = "0x603B5C", VA = "0x603B5C", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x603B60", Offset = "0x603B60", VA = "0x603B60", Slot = "14")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x603B64", Offset = "0x603B64", VA = "0x603B64", Slot = "16")]
		protected override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x603BAC", Offset = "0x603BAC", VA = "0x603BAC", Slot = "18")]
		protected override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x603BB0", Offset = "0x603BB0", VA = "0x603BB0", Slot = "23")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x603BB8", Offset = "0x603BB8", VA = "0x603BB8", Slot = "24")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x603BC0", Offset = "0x603BC0", VA = "0x603BC0")]
		public BehaviourTemplate()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public class SubBehaviourBalancer : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000118")]
		public class Settings
		{
			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239080", Offset = "0x239080")]
			public float damperForSpring;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2390B4", Offset = "0x2390B4")]
			public float maxForceMlp;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239100", Offset = "0x239100")]
			public float IMlp;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239134", Offset = "0x239134")]
			public float velocityF;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23917C", Offset = "0x23917C")]
			public Vector3 copOffset;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2391B0", Offset = "0x2391B0")]
			public float torqueMlp;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2391E4", Offset = "0x2391E4")]
			public float maxTorqueMag;

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x77CFB8", Offset = "0x77CFB8", VA = "0x77CFB8")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233778", Offset = "0x233778")]
		private ConfigurableJoint <joint>k__BackingField;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233788", Offset = "0x233788")]
		private Vector3 <dir>k__BackingField;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233798", Offset = "0x233798")]
		private Vector3 <dirVel>k__BackingField;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2337A8", Offset = "0x2337A8")]
		private Vector3 <cop>k__BackingField;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2337B8", Offset = "0x2337B8")]
		private Vector3 <com>k__BackingField;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2337C8", Offset = "0x2337C8")]
		private Vector3 <comV>k__BackingField;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Settings settings;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody[] rigidbodies;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Transform[] copPoints;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PressureSensor pressureSensor;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Rigidbody Ibody;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 I;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion toJointSpace;

		[Token(Token = "0x17000035")]
		public ConfigurableJoint joint
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x77C3B8", Offset = "0x77C3B8", VA = "0x77C3B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D860", Offset = "0x23D860")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x77C3C0", Offset = "0x77C3C0", VA = "0x77C3C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D870", Offset = "0x23D870")]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Vector3 dir
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x77C3C8", Offset = "0x77C3C8", VA = "0x77C3C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D880", Offset = "0x23D880")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x77C3DC", Offset = "0x77C3DC", VA = "0x77C3DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D890", Offset = "0x23D890")]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public Vector3 dirVel
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x77C3E8", Offset = "0x77C3E8", VA = "0x77C3E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D8A0", Offset = "0x23D8A0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x77C3FC", Offset = "0x77C3FC", VA = "0x77C3FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D8B0", Offset = "0x23D8B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public Vector3 cop
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x77C408", Offset = "0x77C408", VA = "0x77C408")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D8C0", Offset = "0x23D8C0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x77C41C", Offset = "0x77C41C", VA = "0x77C41C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D8D0", Offset = "0x23D8D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public Vector3 com
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x77C428", Offset = "0x77C428", VA = "0x77C428")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D8E0", Offset = "0x23D8E0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x77C43C", Offset = "0x77C43C", VA = "0x77C43C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D8F0", Offset = "0x23D8F0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public Vector3 comV
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x77C448", Offset = "0x77C448", VA = "0x77C448")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D900", Offset = "0x23D900")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x77C45C", Offset = "0x77C45C", VA = "0x77C45C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D910", Offset = "0x23D910")]
			private set
			{
			}
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x77C468", Offset = "0x77C468", VA = "0x77C468")]
		public void Initiate(BehaviourBase behaviour, Settings settings, Rigidbody Ibody, Rigidbody[] rigidbodies, ConfigurableJoint joint, Transform[] copPoints, PressureSensor pressureSensor)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x77C5BC", Offset = "0x77C5BC", VA = "0x77C5BC")]
		private void Solve()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x77CEC8", Offset = "0x77CEC8", VA = "0x77CEC8")]
		public SubBehaviourBalancer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000032")]
	public abstract class SubBehaviourBase
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected BehaviourBase behaviour;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x77CFF0", Offset = "0x77CFF0", VA = "0x77CFF0")]
		protected static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x77D014", Offset = "0x77D014", VA = "0x77D014")]
		protected static Vector3 XYZ(Vector2 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x77D048", Offset = "0x77D048", VA = "0x77D048")]
		protected static Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x77D078", Offset = "0x77D078", VA = "0x77D078")]
		protected static Vector3 SetY(Vector3 v, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x77CFAC", Offset = "0x77CFAC", VA = "0x77CFAC")]
		protected SubBehaviourBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000033")]
	public class SubBehaviourCOM : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000119")]
		public enum Mode
		{
			[Token(Token = "0x40006EE")]
			FeetCentroid,
			[Token(Token = "0x40006EF")]
			CenterOfPressure
		}

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Mode mode;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float velocityDamper;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float velocityLerpSpeed;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float velocityMax;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float centerOfPressureSpeed;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2337D8", Offset = "0x2337D8")]
		private Vector3 <position>k__BackingField;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2337E8", Offset = "0x2337E8")]
		private Vector3 <direction>k__BackingField;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2337F8", Offset = "0x2337F8")]
		private float <angle>k__BackingField;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233808", Offset = "0x233808")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233818", Offset = "0x233818")]
		private Vector3 <centerOfPressure>k__BackingField;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233828", Offset = "0x233828")]
		private Quaternion <rotation>k__BackingField;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233838", Offset = "0x233838")]
		private Quaternion <inverseRotation>k__BackingField;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233848", Offset = "0x233848")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233858", Offset = "0x233858")]
		private float <lastGroundedTime>k__BackingField;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x233868", Offset = "0x233868")]
		public bool[] groundContacts;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x233878", Offset = "0x233878")]
		public Vector3[] groundContactPoints;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private LayerMask groundLayers;

		[Token(Token = "0x1700003B")]
		public Vector3 position
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x77D0A8", Offset = "0x77D0A8", VA = "0x77D0A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D920", Offset = "0x23D920")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x77D0BC", Offset = "0x77D0BC", VA = "0x77D0BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D930", Offset = "0x23D930")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public Vector3 direction
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x77D0C8", Offset = "0x77D0C8", VA = "0x77D0C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D940", Offset = "0x23D940")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x77D0DC", Offset = "0x77D0DC", VA = "0x77D0DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D950", Offset = "0x23D950")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public float angle
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x77D0E8", Offset = "0x77D0E8", VA = "0x77D0E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D960", Offset = "0x23D960")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x77D0F0", Offset = "0x77D0F0", VA = "0x77D0F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D970", Offset = "0x23D970")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public Vector3 velocity
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x77D0F8", Offset = "0x77D0F8", VA = "0x77D0F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D980", Offset = "0x23D980")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x77D10C", Offset = "0x77D10C", VA = "0x77D10C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D990", Offset = "0x23D990")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public Vector3 centerOfPressure
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x77D118", Offset = "0x77D118", VA = "0x77D118")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D9A0", Offset = "0x23D9A0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x77D12C", Offset = "0x77D12C", VA = "0x77D12C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D9B0", Offset = "0x23D9B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public Quaternion rotation
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x77D138", Offset = "0x77D138", VA = "0x77D138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D9C0", Offset = "0x23D9C0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x77D148", Offset = "0x77D148", VA = "0x77D148")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D9D0", Offset = "0x23D9D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public Quaternion inverseRotation
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x77D158", Offset = "0x77D158", VA = "0x77D158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D9E0", Offset = "0x23D9E0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x77D168", Offset = "0x77D168", VA = "0x77D168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23D9F0", Offset = "0x23D9F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public bool isGrounded
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x77D178", Offset = "0x77D178", VA = "0x77D178")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DA00", Offset = "0x23DA00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x77D180", Offset = "0x77D180", VA = "0x77D180")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DA10", Offset = "0x23DA10")]
			private set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public float lastGroundedTime
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x77D188", Offset = "0x77D188", VA = "0x77D188")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DA20", Offset = "0x23DA20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x77D190", Offset = "0x77D190", VA = "0x77D190")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DA30", Offset = "0x23DA30")]
			private set
			{
			}
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x77D198", Offset = "0x77D198", VA = "0x77D198")]
		public void Initiate(BehaviourBase behaviour, LayerMask groundLayers)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x77D5B4", Offset = "0x77D5B4", VA = "0x77D5B4")]
		private void OnHierarchyChanged()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x77D6B8", Offset = "0x77D6B8", VA = "0x77D6B8")]
		private void OnPreMuscleCollision(MuscleCollision c)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x77DA20", Offset = "0x77DA20", VA = "0x77DA20")]
		private void OnPreMuscleCollisionExit(MuscleCollision c)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x77DB94", Offset = "0x77DB94", VA = "0x77DB94")]
		private void OnPreActivate()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x77E27C", Offset = "0x77E27C", VA = "0x77E27C")]
		private void OnPreLateUpdate()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x77ED0C", Offset = "0x77ED0C", VA = "0x77ED0C")]
		private void OnPreDeactivate()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x77D810", Offset = "0x77D810", VA = "0x77D810")]
		private Vector3 GetCollisionCOP(Collision collision)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x77E738", Offset = "0x77E738", VA = "0x77E738")]
		private bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x77DCD8", Offset = "0x77DCD8", VA = "0x77DCD8")]
		private Vector3 GetCenterOfMass()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x77E9F8", Offset = "0x77E9F8", VA = "0x77E9F8")]
		private Vector3 GetCenterOfMassVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x77EDA4", Offset = "0x77EDA4", VA = "0x77EDA4")]
		private Vector3 GetMomentum()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x77E7BC", Offset = "0x77E7BC", VA = "0x77E7BC")]
		private Vector3 GetCenterOfPressure()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x77DF7C", Offset = "0x77DF7C", VA = "0x77DF7C")]
		private Vector3 GetFeetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x77F068", Offset = "0x77F068", VA = "0x77F068")]
		public SubBehaviourCOM()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000034")]
	public class Booster
	{
		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233888", Offset = "0x233888")]
		public bool fullBody;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2338BC", Offset = "0x2338BC")]
		public ConfigurableJoint[] muscles;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233920", Offset = "0x233920")]
		public Muscle.Group[] groups;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23398C", Offset = "0x23398C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23398C", Offset = "0x23398C")]
		public float immunity;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2339DC", Offset = "0x2339DC")]
		public float impulseMlp;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233A10", Offset = "0x233A10")]
		public float boostParents;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233A74", Offset = "0x233A74")]
		public float boostChildren;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233AD8", Offset = "0x233AD8")]
		public float delay;

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x60A19C", Offset = "0x60A19C", VA = "0x60A19C")]
		public void Boost(BehaviourPuppet puppet)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x60A4F0", Offset = "0x60A4F0", VA = "0x60A4F0")]
		public Booster()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class JointBreakBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x233B0C", Offset = "0x233B0C")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x233B3C", Offset = "0x233B3C")]
		public int muscleIndex;

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x60A580", Offset = "0x60A580", VA = "0x60A580")]
		private void OnJointBreak()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x60A614", Offset = "0x60A614", VA = "0x60A614")]
		public JointBreakBroadcaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000036")]
	public class Muscle
	{
		[Serializable]
		[Token(Token = "0x200011A")]
		public enum Group
		{
			[Token(Token = "0x40006F1")]
			Hips,
			[Token(Token = "0x40006F2")]
			Spine,
			[Token(Token = "0x40006F3")]
			Head,
			[Token(Token = "0x40006F4")]
			Arm,
			[Token(Token = "0x40006F5")]
			Hand,
			[Token(Token = "0x40006F6")]
			Leg,
			[Token(Token = "0x40006F7")]
			Foot,
			[Token(Token = "0x40006F8")]
			Tail,
			[Token(Token = "0x40006F9")]
			Prop
		}

		[Serializable]
		[Token(Token = "0x200011B")]
		public class Props
		{
			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239218", Offset = "0x239218")]
			public Group group;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239270", Offset = "0x239270")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x239270", Offset = "0x239270")]
			public float mappingWeight;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2392C0", Offset = "0x2392C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2392C0", Offset = "0x2392C0")]
			public float pinWeight;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239310", Offset = "0x239310")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x239310", Offset = "0x239310")]
			public float muscleWeight;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23937C", Offset = "0x23937C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23937C", Offset = "0x23937C")]
			public float muscleDamper;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2393CC", Offset = "0x2393CC")]
			public bool mapPosition;

			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x610E34", Offset = "0x610E34", VA = "0x610E34")]
			public Props()
			{
			}

			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x610E60", Offset = "0x610E60", VA = "0x610E60")]
			public Props(float pinWeight, float muscleWeight, float mappingWeight, float muscleDamper, bool mapPosition, Group group = Group.Hips)
			{
			}

			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x60F968", Offset = "0x60F968", VA = "0x60F968")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x200011C")]
		public struct State
		{
			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float mappingWeightMlp;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float pinWeightMlp;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float muscleWeightMlp;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maxForceMlp;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float muscleDamperMlp;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float muscleDamperAdd;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float immunity;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float impulseMlp;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 velocity;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 angularVelocity;

			[Token(Token = "0x17000163")]
			public static State Default
			{
				[Token(Token = "0x60009A7")]
				[Address(RVA = "0x60D678", Offset = "0x60D678", VA = "0x60D678")]
				get
				{
					return default(State);
				}
			}

			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x2C4798", Offset = "0x2C4798", VA = "0x2C4798")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x233B6C", Offset = "0x233B6C")]
		public string name;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ConfigurableJoint joint;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform target;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Props props;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public State state;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x233B7C", Offset = "0x233B7C")]
		public int[] parentIndexes;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x233B8C", Offset = "0x233B8C")]
		public int[] childIndexes;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x233B9C", Offset = "0x233B9C")]
		public bool[] childFlags;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x233BAC", Offset = "0x233BAC")]
		public int[] kinshipDegrees;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x233BBC", Offset = "0x233BBC")]
		public MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x233BCC", Offset = "0x233BCC")]
		public JointBreakBroadcaster jointBreakBroadcaster;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x233BDC", Offset = "0x233BDC")]
		public Vector3 positionOffset;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233BEC", Offset = "0x233BEC")]
		private Transform <transform>k__BackingField;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233BFC", Offset = "0x233BFC")]
		private Rigidbody <rigidbody>k__BackingField;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233C0C", Offset = "0x233C0C")]
		private Transform <connectedBodyTarget>k__BackingField;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233C1C", Offset = "0x233C1C")]
		private Vector3 <targetAnimatedPosition>k__BackingField;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233C2C", Offset = "0x233C2C")]
		private Vector3 <targetVelocity>k__BackingField;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233C3C", Offset = "0x233C3C")]
		private Vector3 <targetAngularVelocity>k__BackingField;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233C4C", Offset = "0x233C4C")]
		private Vector3 <mappedVelocity>k__BackingField;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233C5C", Offset = "0x233C5C")]
		private Vector3 <mappedAngularVelocity>k__BackingField;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233C6C", Offset = "0x233C6C")]
		private Quaternion <targetRotationRelative>k__BackingField;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Vector3 lastRigidbodyPosition;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Quaternion lastRigidbodyRotation;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private JointDrive slerpDrive;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float lastJointDriveRotationWeight;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float lastRotationDamper;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 defaultTargetLocalPosition;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 lastMappedPosition;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Quaternion localRotationConvert;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Quaternion toParentSpace;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Quaternion toJointSpaceInverse;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Quaternion toJointSpaceDefault;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Quaternion targetAnimatedRotation;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Quaternion targetAnimatedWorldRotation;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Quaternion rotationRelativeToTarget;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Quaternion lastMappedRotation;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Transform targetParent;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Transform connectedBodyTransform;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private ConfigurableJointMotion angularXMotionDefault;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private ConfigurableJointMotion angularYMotionDefault;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private ConfigurableJointMotion angularZMotionDefault;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool directTargetParent;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool initiated;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Collider[] _colliders;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		private float lastReadTime;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private float lastWriteTime;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		private bool[] disabledColliders;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Vector3 targetLocalPosition;

		[Token(Token = "0x17000044")]
		public Transform transform
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x60BDE0", Offset = "0x60BDE0", VA = "0x60BDE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DA40", Offset = "0x23DA40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x60BDE8", Offset = "0x60BDE8", VA = "0x60BDE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DA50", Offset = "0x23DA50")]
			private set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x60BDF0", Offset = "0x60BDF0", VA = "0x60BDF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DA60", Offset = "0x23DA60")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x60BDF8", Offset = "0x60BDF8", VA = "0x60BDF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DA70", Offset = "0x23DA70")]
			private set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public Transform connectedBodyTarget
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x60BE00", Offset = "0x60BE00", VA = "0x60BE00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DA80", Offset = "0x23DA80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x60BE08", Offset = "0x60BE08", VA = "0x60BE08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DA90", Offset = "0x23DA90")]
			private set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public Vector3 targetAnimatedPosition
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x60BE10", Offset = "0x60BE10", VA = "0x60BE10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DAA0", Offset = "0x23DAA0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x60BE24", Offset = "0x60BE24", VA = "0x60BE24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DAB0", Offset = "0x23DAB0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public Collider[] colliders
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x60BE30", Offset = "0x60BE30", VA = "0x60BE30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public Vector3 targetVelocity
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x60BE38", Offset = "0x60BE38", VA = "0x60BE38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DAC0", Offset = "0x23DAC0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x60BE4C", Offset = "0x60BE4C", VA = "0x60BE4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DAD0", Offset = "0x23DAD0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public Vector3 targetAngularVelocity
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x60BE58", Offset = "0x60BE58", VA = "0x60BE58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DAE0", Offset = "0x23DAE0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x60BE6C", Offset = "0x60BE6C", VA = "0x60BE6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DAF0", Offset = "0x23DAF0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public Vector3 mappedVelocity
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x60BE78", Offset = "0x60BE78", VA = "0x60BE78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DB00", Offset = "0x23DB00")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x60BE8C", Offset = "0x60BE8C", VA = "0x60BE8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DB10", Offset = "0x23DB10")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public Vector3 mappedAngularVelocity
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x60BE98", Offset = "0x60BE98", VA = "0x60BE98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DB20", Offset = "0x23DB20")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x60BEAC", Offset = "0x60BEAC", VA = "0x60BEAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DB30", Offset = "0x23DB30")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public Quaternion targetRotationRelative
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x60BEB8", Offset = "0x60BEB8", VA = "0x60BEB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DB40", Offset = "0x23DB40")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x60BEC8", Offset = "0x60BEC8", VA = "0x60BEC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DB50", Offset = "0x23DB50")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		private Quaternion localRotation
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x60D938", Offset = "0x60D938", VA = "0x60D938")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x1700004F")]
		private Quaternion parentRotation
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x60DB38", Offset = "0x60DB38", VA = "0x60DB38")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000050")]
		private Quaternion targetParentRotation
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x60DA40", Offset = "0x60DA40", VA = "0x60DA40")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000051")]
		private Quaternion targetLocalRotation
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x60DD20", Offset = "0x60DD20", VA = "0x60DD20")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x60BED8", Offset = "0x60BED8", VA = "0x60BED8")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x60C120", Offset = "0x60C120", VA = "0x60C120", Slot = "4")]
		public virtual void Initiate(Muscle[] colleagues)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x60D6B8", Offset = "0x60D6B8", VA = "0x60D6B8")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x60E600", Offset = "0x60E600", VA = "0x60E600")]
		public void DisableColliders()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x60E724", Offset = "0x60E724", VA = "0x60E724")]
		public void EnableColliders()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x60E184", Offset = "0x60E184", VA = "0x60E184")]
		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x60E4BC", Offset = "0x60E4BC", VA = "0x60E4BC")]
		private void AddCompoundColliders(Transform t, ref Collider[] colliders)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x60E834", Offset = "0x60E834", VA = "0x60E834")]
		public void IgnoreCollisions(Muscle m, bool ignore)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x60EACC", Offset = "0x60EACC", VA = "0x60EACC")]
		public void IgnoreAngularLimits(bool ignore)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x60EB7C", Offset = "0x60EB7C", VA = "0x60EB7C")]
		public void FixTargetTransforms()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x60EC10", Offset = "0x60EC10", VA = "0x60EC10")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x60EF30", Offset = "0x60EF30", VA = "0x60EF30")]
		public void MoveToTarget()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x60DE58", Offset = "0x60DE58", VA = "0x60DE58")]
		public void Read()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x60F184", Offset = "0x60F184", VA = "0x60F184")]
		public void ClearVelocities()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x60F3B0", Offset = "0x60F3B0", VA = "0x60F3B0")]
		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x60F7F8", Offset = "0x60F7F8", VA = "0x60F7F8", Slot = "5")]
		public virtual void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, float pinPow, float pinDistanceFalloff, bool rotationTargetChanged)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x6101DC", Offset = "0x6101DC", VA = "0x6101DC")]
		public void Map(float mappingWeightMaster)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x610930", Offset = "0x610930", VA = "0x610930")]
		public void CalculateMappedVelocity()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x60FB5C", Offset = "0x60FB5C", VA = "0x60FB5C")]
		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x60FF58", Offset = "0x60FF58", VA = "0x60FF58")]
		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x610B84", Offset = "0x610B84", VA = "0x610B84")]
		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x60F6BC", Offset = "0x60F6BC", VA = "0x60F6BC")]
		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x60D83C", Offset = "0x60D83C", VA = "0x60D83C")]
		private Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x610CC8", Offset = "0x610CC8", VA = "0x610CC8")]
		public Muscle()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public struct MuscleCollision
	{
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Collision collision;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool isStay;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2C47FC", Offset = "0x2C47FC", VA = "0x2C47FC")]
		public MuscleCollision(int muscleIndex, Collision collision, bool isStay = false)
		{
		}
	}
	[Token(Token = "0x2000038")]
	public struct MuscleHit
	{
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float unPin;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 force;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 position;

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2C480C", Offset = "0x2C480C", VA = "0x2C480C")]
		public MuscleHit(int muscleIndex, float unPin, Vector3 force, Vector3 position)
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x230B5C", Offset = "0x230B5C")]
	public class MuscleCollisionBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x233C7C", Offset = "0x233C7C")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x233CAC", Offset = "0x233CAC")]
		public int muscleIndex;

		[Token(Token = "0x4000203")]
		private const string onMuscleHit = "OnMuscleHit";

		[Token(Token = "0x4000204")]
		private const string onMuscleCollision = "OnMuscleCollision";

		[Token(Token = "0x4000205")]
		private const string onMuscleCollisionExit = "OnMuscleCollisionExit";

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private MuscleCollisionBroadcaster otherBroadcaster;

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x610EC0", Offset = "0x610EC0", VA = "0x610EC0")]
		public void Hit(float unPin, Vector3 force, Vector3 position)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x610FC8", Offset = "0x610FC8", VA = "0x610FC8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x6111C4", Offset = "0x6111C4", VA = "0x6111C4")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x6114A8", Offset = "0x6114A8", VA = "0x6114A8")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x61178C", Offset = "0x61178C", VA = "0x61178C")]
		public MuscleCollisionBroadcaster()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public static class PhysXTools
	{
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x611794", Offset = "0x611794", VA = "0x611794")]
		public static Vector3 GetCenterOfMass(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x611A6C", Offset = "0x611A6C", VA = "0x611A6C")]
		public static Vector3 GetCenterOfMassVelocity(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x611D44", Offset = "0x611D44", VA = "0x611D44")]
		public static void DivByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x611F0C", Offset = "0x611F0C", VA = "0x611F0C")]
		public static void ScaleByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x612070", Offset = "0x612070", VA = "0x612070")]
		public static Vector3 GetFromToAcceleration(Vector3 fromV, Vector3 toV)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x612210", Offset = "0x612210", VA = "0x612210")]
		public static Vector3 GetAngularAcceleration(Quaternion fromR, Quaternion toR)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x6124BC", Offset = "0x6124BC", VA = "0x6124BC")]
		public static void AddFromToTorque(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x6128B0", Offset = "0x6128B0", VA = "0x6128B0")]
		public static Vector3 GetLinearAcceleration(Vector3 fromPoint, Vector3 toPoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x612990", Offset = "0x612990", VA = "0x612990")]
		public static void AddFromToForce(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x612D0C", Offset = "0x612D0C", VA = "0x612D0C")]
		public static Quaternion ToJointSpace(ConfigurableJoint joint)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x612E9C", Offset = "0x612E9C", VA = "0x612E9C")]
		public static Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x611EB0", Offset = "0x611EB0", VA = "0x611EB0")]
		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200003B")]
	public class PressureSensor : MonoBehaviour
	{
		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool visualize;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayerMask layers;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233CDC", Offset = "0x233CDC")]
		private Vector3 <center>k__BackingField;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233CEC", Offset = "0x233CEC")]
		private bool <inContact>k__BackingField;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233CFC", Offset = "0x233CFC")]
		private Vector3 <bottom>k__BackingField;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233D0C", Offset = "0x233D0C")]
		private Rigidbody <r>k__BackingField;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool fixedFrame;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 P;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int count;

		[Token(Token = "0x17000052")]
		public Vector3 center
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x612F98", Offset = "0x612F98", VA = "0x612F98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DB60", Offset = "0x23DB60")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x612FAC", Offset = "0x612FAC", VA = "0x612FAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DB70", Offset = "0x23DB70")]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool inContact
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x612FB8", Offset = "0x612FB8", VA = "0x612FB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DB80", Offset = "0x23DB80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x612FC0", Offset = "0x612FC0", VA = "0x612FC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DB90", Offset = "0x23DB90")]
			private set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public Vector3 bottom
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x612FC8", Offset = "0x612FC8", VA = "0x612FC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DBA0", Offset = "0x23DBA0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x612FDC", Offset = "0x612FDC", VA = "0x612FDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DBB0", Offset = "0x23DBB0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public Rigidbody r
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x612FE8", Offset = "0x612FE8", VA = "0x612FE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DBC0", Offset = "0x23DBC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x612FF0", Offset = "0x612FF0", VA = "0x612FF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DBD0", Offset = "0x23DBD0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x612FF8", Offset = "0x612FF8", VA = "0x612FF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x6130A4", Offset = "0x6130A4", VA = "0x6130A4")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x613360", Offset = "0x613360", VA = "0x613360")]
		private void OnCollisionStay(Collision c)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x613364", Offset = "0x613364", VA = "0x613364")]
		private void OnCollisionExit(Collision c)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x613370", Offset = "0x613370", VA = "0x613370")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x61343C", Offset = "0x61343C", VA = "0x61343C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x6130A8", Offset = "0x6130A8", VA = "0x6130A8")]
		private void ProcessCollision(Collision c)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x613520", Offset = "0x613520", VA = "0x613520")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x613564", Offset = "0x613564", VA = "0x613564")]
		public PressureSensor()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public abstract class Prop : MonoBehaviour
	{
		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233D1C", Offset = "0x233D1C")]
		public int propType;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x233D50", Offset = "0x233D50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233D50", Offset = "0x233D50")]
		public ConfigurableJoint muscle;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233DC4", Offset = "0x233DC4")]
		public Muscle.Props muscleProps;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233DF8", Offset = "0x233DF8")]
		public bool forceLayers;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x233E2C", Offset = "0x233E2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233E2C", Offset = "0x233E2C")]
		public ConfigurableJoint additionalPin;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233E94", Offset = "0x233E94")]
		public Transform additionalPinTarget;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233EEC", Offset = "0x233EEC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x233EEC", Offset = "0x233EEC")]
		public float additionalPinWeight;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x233F3C", Offset = "0x233F3C")]
		private PropRoot <propRoot>k__BackingField;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private ConfigurableJointMotion xMotion;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ConfigurableJointMotion yMotion;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private ConfigurableJointMotion zMotion;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ConfigurableJointMotion angularXMotion;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private ConfigurableJointMotion angularYMotion;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ConfigurableJointMotion angularZMotion;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Collider[] colliders;

		[Token(Token = "0x17000056")]
		public bool isPickedUp
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x61356C", Offset = "0x61356C", VA = "0x61356C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		public PropRoot propRoot
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x6135F8", Offset = "0x6135F8", VA = "0x6135F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DBE0", Offset = "0x23DBE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x613600", Offset = "0x613600", VA = "0x613600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DBF0", Offset = "0x23DBF0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x613608", Offset = "0x613608", VA = "0x613608")]
		public void PickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x6138BC", Offset = "0x6138BC", VA = "0x6138BC")]
		public void Drop()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x6138D4", Offset = "0x6138D4", VA = "0x6138D4")]
		public void StartPickedUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x6138DC", Offset = "0x6138DC", VA = "0x6138DC", Slot = "4")]
		protected virtual void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x6138E0", Offset = "0x6138E0", VA = "0x6138E0", Slot = "5")]
		protected virtual void OnDrop()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x6138E4", Offset = "0x6138E4", VA = "0x6138E4", Slot = "6")]
		protected virtual void OnStart()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x6138E8", Offset = "0x6138E8", VA = "0x6138E8", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x613B60", Offset = "0x613B60", VA = "0x613B60")]
		private void Start()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x613B94", Offset = "0x613B94", VA = "0x613B94")]
		private void ReleaseJoint()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x613DB0", Offset = "0x613DB0", VA = "0x613DB0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x614074", Offset = "0x614074", VA = "0x614074")]
		protected Prop()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x230B90", Offset = "0x230B90")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x230B90", Offset = "0x230B90")]
	public class PropRoot : MonoBehaviour
	{
		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233F4C", Offset = "0x233F4C")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x233FA4", Offset = "0x233FA4")]
		public Rigidbody connectTo;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234010", Offset = "0x234010")]
		public Prop currentProp;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Prop lastProp;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool fixedUpdateCalled;

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x614134", Offset = "0x614134", VA = "0x614134")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23DC00", Offset = "0x23DC00")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x614194", Offset = "0x614194", VA = "0x614194")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23DC34", Offset = "0x23DC34")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x6141F4", Offset = "0x6141F4", VA = "0x6141F4")]
		public void DropImmediate()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x61430C", Offset = "0x61430C", VA = "0x61430C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x6143B8", Offset = "0x6143B8", VA = "0x6143B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x614558", Offset = "0x614558", VA = "0x614558")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x6147FC", Offset = "0x6147FC", VA = "0x6147FC")]
		private void AttachProp(Prop prop)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x615A5C", Offset = "0x615A5C", VA = "0x615A5C")]
		public PropRoot()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x230C1C", Offset = "0x230C1C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x230C1C", Offset = "0x230C1C")]
	public class PropTemplate : Prop
	{
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x615A64", Offset = "0x615A64", VA = "0x615A64", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x615A68", Offset = "0x615A68", VA = "0x615A68", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x615A6C", Offset = "0x615A6C", VA = "0x615A6C", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x615A70", Offset = "0x615A70", VA = "0x615A70")]
		public PropTemplate()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x230CAC", Offset = "0x230CAC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x230CAC", Offset = "0x230CAC")]
	public class PuppetMaster : MonoBehaviour, IFixedUpdateable
	{
		[Serializable]
		[Token(Token = "0x200011D")]
		public enum Mode
		{
			[Token(Token = "0x400070B")]
			Active,
			[Token(Token = "0x400070C")]
			Kinematic,
			[Token(Token = "0x400070D")]
			Disabled
		}

		[Token(Token = "0x200011E")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x200011F")]
		public delegate void MuscleDelegate(Muscle muscle);

		[Serializable]
		[Token(Token = "0x2000120")]
		public enum UpdateMode
		{
			[Token(Token = "0x400070F")]
			Normal,
			[Token(Token = "0x4000710")]
			AnimatePhysics,
			[Token(Token = "0x4000711")]
			FixedUpdate
		}

		[Serializable]
		[Token(Token = "0x2000121")]
		public enum State
		{
			[Token(Token = "0x4000713")]
			Alive,
			[Token(Token = "0x4000714")]
			Dead,
			[Token(Token = "0x4000715")]
			Frozen
		}

		[Serializable]
		[Token(Token = "0x2000122")]
		public struct StateSettings
		{
			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239400", Offset = "0x239400")]
			public float killDuration;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239434", Offset = "0x239434")]
			public float deadMuscleWeight;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239490", Offset = "0x239490")]
			public float deadMuscleDamper;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2394EC", Offset = "0x2394EC")]
			public float maxFreezeSqrVelocity;

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239520", Offset = "0x239520")]
			public bool freezePermanently;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239554", Offset = "0x239554")]
			public bool enableAngularLimitsOnKill;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2395C0", Offset = "0x2395C0")]
			public bool enableInternalCollisionsOnKill;

			[Token(Token = "0x17000164")]
			public static StateSettings Default
			{
				[Token(Token = "0x60009B2")]
				[Address(RVA = "0x776C38", Offset = "0x776C38", VA = "0x776C38")]
				get
				{
					return default(StateSettings);
				}
			}

			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x2CCEA8", Offset = "0x2CCEA8", VA = "0x2CCEA8")]
			public StateSettings(float killDuration, float deadMuscleWeight = 0.01f, float deadMuscleDamper = 2f, float maxFreezeSqrVelocity = 0.02f, bool freezePermanently = false, bool enableAngularLimitsOnKill = true, bool enableInternalCollisionsOnKill = true)
			{
			}
		}

		[Token(Token = "0x2000123")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x232220", Offset = "0x232220")]
		private sealed class <DisabledToActive>d__131 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000165")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009B6")]
				[Address(RVA = "0x7762DC", Offset = "0x7762DC", VA = "0x7762DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000166")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009B8")]
				[Address(RVA = "0x77636C", Offset = "0x77636C", VA = "0x77636C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x775DD4", Offset = "0x775DD4", VA = "0x775DD4")]
			[DebuggerHidden]
			public <DisabledToActive>d__131(int <>1__state)
			{
			}

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x775DF4", Offset = "0x775DF4", VA = "0x775DF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x775DF8", Offset = "0x775DF8", VA = "0x775DF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x7762E4", Offset = "0x7762E4", VA = "0x7762E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x232230", Offset = "0x232230")]
		private sealed class <KinematicToActive>d__133 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000167")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009BC")]
				[Address(RVA = "0x776720", Offset = "0x776720", VA = "0x776720", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000168")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009BE")]
				[Address(RVA = "0x7767B0", Offset = "0x7767B0", VA = "0x7767B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x776374", Offset = "0x776374", VA = "0x776374")]
			[DebuggerHidden]
			public <KinematicToActive>d__133(int <>1__state)
			{
			}

			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x776394", Offset = "0x776394", VA = "0x776394", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x776398", Offset = "0x776398", VA = "0x776398", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x776728", Offset = "0x776728", VA = "0x776728", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000125")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x232240", Offset = "0x232240")]
		private sealed class <ActiveToDisabled>d__134 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000169")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C2")]
				[Address(RVA = "0x775140", Offset = "0x775140", VA = "0x775140", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700016A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009C4")]
				[Address(RVA = "0x7751D0", Offset = "0x7751D0", VA = "0x7751D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x774F08", Offset = "0x774F08", VA = "0x774F08")]
			[DebuggerHidden]
			public <ActiveToDisabled>d__134(int <>1__state)
			{
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x774F28", Offset = "0x774F28", VA = "0x774F28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x774F2C", Offset = "0x774F2C", VA = "0x774F2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x775148", Offset = "0x775148", VA = "0x775148", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000126")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x232250", Offset = "0x232250")]
		private sealed class <ActiveToKinematic>d__135 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x1700016B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C8")]
				[Address(RVA = "0x775468", Offset = "0x775468", VA = "0x775468", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700016C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009CA")]
				[Address(RVA = "0x7754F8", Offset = "0x7754F8", VA = "0x7754F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x7751D8", Offset = "0x7751D8", VA = "0x7751D8")]
			[DebuggerHidden]
			public <ActiveToKinematic>d__135(int <>1__state)
			{
			}

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x7751F8", Offset = "0x7751F8", VA = "0x7751F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x7751FC", Offset = "0x7751FC", VA = "0x7751FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x775470", Offset = "0x775470", VA = "0x775470", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x232260", Offset = "0x232260")]
		private sealed class <AliveToDead>d__185 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool freeze;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float <range>5__2;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private float <mW>5__3;

			[Token(Token = "0x1700016D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009CE")]
				[Address(RVA = "0x775D3C", Offset = "0x775D3C", VA = "0x775D3C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700016E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009D0")]
				[Address(RVA = "0x775DCC", Offset = "0x775DCC", VA = "0x775DCC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x775500", Offset = "0x775500", VA = "0x775500")]
			[DebuggerHidden]
			public <AliveToDead>d__185(int <>1__state)
			{
			}

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x775520", Offset = "0x775520", VA = "0x775520", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x775524", Offset = "0x775524", VA = "0x775524", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x775D44", Offset = "0x775D44", VA = "0x775D44", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234044", Offset = "0x234044")]
		public PuppetMasterHumanoidConfig humanoidConfig;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform targetRoot;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x234078", Offset = "0x234078")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234078", Offset = "0x234078")]
		public State state;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x2340D8", Offset = "0x2340D8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2340D8", Offset = "0x2340D8")]
		public StateSettings stateSettings;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234190", Offset = "0x234190")]
		public Mode mode;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2341C4", Offset = "0x2341C4")]
		public float blendTime;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2341F8", Offset = "0x2341F8")]
		public bool fixTargetTransforms;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23422C", Offset = "0x23422C")]
		public int solverIterationCount;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234298", Offset = "0x234298")]
		public bool visualizeTargetPose;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2342CC", Offset = "0x2342CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2342CC", Offset = "0x2342CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2342CC", Offset = "0x2342CC")]
		public float mappingWeight;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234344", Offset = "0x234344")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x234344", Offset = "0x234344")]
		public float pinWeight;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234394", Offset = "0x234394")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x234394", Offset = "0x234394")]
		public float muscleWeight;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x234404", Offset = "0x234404")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234404", Offset = "0x234404")]
		public float muscleSpring;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234498", Offset = "0x234498")]
		public float muscleDamper;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234500", Offset = "0x234500")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x234500", Offset = "0x234500")]
		public float pinPow;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234550", Offset = "0x234550")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x234550", Offset = "0x234550")]
		public float pinDistanceFalloff;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2345A4", Offset = "0x2345A4")]
		public bool updateJointAnchors;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2345D8", Offset = "0x2345D8")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23460C", Offset = "0x23460C")]
		public bool angularLimits;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234640", Offset = "0x234640")]
		public bool internalCollisions;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x234674", Offset = "0x234674")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234674", Offset = "0x234674")]
		public Muscle[] muscles;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UpdateDelegate OnRead;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public UpdateDelegate OnWrite;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UpdateDelegate OnPostLateUpdate;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public UpdateDelegate OnHierarchyChanged;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public MuscleDelegate OnMuscleRemoved;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Animator _targetAnimator;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2346F8", Offset = "0x2346F8")]
		private Animation <targetAnimation>k__BackingField;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x234708", Offset = "0x234708")]
		private BehaviourBase[] <behaviours>k__BackingField;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x234718", Offset = "0x234718")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x234728", Offset = "0x234728")]
		public List<SolverManager> solvers;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool internalCollisionsEnabled;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		private bool angularLimitsEnabled;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x96")]
		private bool fixedFrame;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int lastSolverIterationCount;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool isLegacy;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		private bool animatorDisabled;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E")]
		private bool awakeFailed;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9F")]
		private bool interpolated;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool freezeFlag;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool hasBeenDisabled;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		private bool hierarchyIsFlat;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		private bool teleport;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 teleportPosition;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion teleportRotation;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool teleportMoveToTarget;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x234738", Offset = "0x234738")]
		private bool <justTeleported>k__BackingField;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x234748", Offset = "0x234748")]
		private bool <isSwitchingMode>k__BackingField;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Mode activeMode;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Mode lastMode;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float mappingBlend;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x234758", Offset = "0x234758")]
		private bool <isKilling>k__BackingField;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public UpdateDelegate OnFreeze;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public UpdateDelegate OnUnfreeze;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public UpdateDelegate OnDeath;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public UpdateDelegate OnResurrection;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private State activeState;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private State lastState;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool angularLimitsEnabledOnKill;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
		private bool internalCollisionsEnabledOnKill;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEE")]
		private bool animationDisabledbyStates;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEF")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x234768", Offset = "0x234768")]
		public bool storeTargetMappedState;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Transform[] targetChildren;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Vector3[] targetMappedPositions;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion[] targetMappedRotations;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private Vector3[] targetSampledPositions;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Quaternion[] targetSampledRotations;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private bool targetMappedStateStored;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		private bool targetMappedStateSampled;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x106")]
		private bool sampleTargetMappedState;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x107")]
		private bool hasProp;

		[Token(Token = "0x17000058")]
		public Animator targetAnimator
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x5FC4E4", Offset = "0x5FC4E4", VA = "0x5FC4E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x615CF0", Offset = "0x615CF0", VA = "0x615CF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public Animation targetAnimation
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x615CF8", Offset = "0x615CF8", VA = "0x615CF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DDE4", Offset = "0x23DDE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x615D00", Offset = "0x615D00", VA = "0x615D00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DDF4", Offset = "0x23DDF4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public BehaviourBase[] behaviours
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x615D08", Offset = "0x615D08", VA = "0x615D08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DE04", Offset = "0x23DE04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x615D10", Offset = "0x615D10", VA = "0x615D10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DE14", Offset = "0x23DE14")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public bool isActive
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x5FFD50", Offset = "0x5FFD50", VA = "0x5FFD50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		public bool initiated
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x615D18", Offset = "0x615D18", VA = "0x615D18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DE24", Offset = "0x23DE24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x615D20", Offset = "0x615D20", VA = "0x615D20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DE34", Offset = "0x23DE34")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public UpdateMode updateMode
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x615D28", Offset = "0x615D28", VA = "0x615D28")]
			get
			{
				return default(UpdateMode);
			}
		}

		[Token(Token = "0x1700005E")]
		public bool controlsAnimator
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x615E8C", Offset = "0x615E8C", VA = "0x615E8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		public bool isBlending
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x5FCFB4", Offset = "0x5FCFB4", VA = "0x5FCFB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000060")]
		public bool justTeleported
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x615F44", Offset = "0x615F44", VA = "0x615F44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DE44", Offset = "0x23DE44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x615F4C", Offset = "0x615F4C", VA = "0x615F4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DE54", Offset = "0x23DE54")]
			private set
			{
			}
		}

		[Token(Token = "0x17000061")]
		private AnimatorUpdateMode targetUpdateMode
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x615D58", Offset = "0x615D58", VA = "0x615D58")]
			get
			{
				return default(AnimatorUpdateMode);
			}
		}

		[Token(Token = "0x17000062")]
		public bool isSwitchingMode
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x61D968", Offset = "0x61D968", VA = "0x61D968")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DF78", Offset = "0x23DF78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x61D970", Offset = "0x61D970", VA = "0x61D970")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23DF88", Offset = "0x23DF88")]
			private set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public bool isSwitchingState
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x615EF0", Offset = "0x615EF0", VA = "0x615EF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		public bool isKilling
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x622B94", Offset = "0x622B94", VA = "0x622B94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E178", Offset = "0x23E178")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x622B9C", Offset = "0x622B9C", VA = "0x622B9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E188", Offset = "0x23E188")]
			private set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public bool isAlive
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x5FFDB0", Offset = "0x5FFDB0", VA = "0x5FFDB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000066")]
		public bool isFrozen
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x6008B8", Offset = "0x6008B8", VA = "0x6008B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x615A74", Offset = "0x615A74", VA = "0x615A74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23DC68", Offset = "0x23DC68")]
		private void OpenUserManualSetup()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x615AD4", Offset = "0x615AD4", VA = "0x615AD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23DCA8", Offset = "0x23DCA8")]
		private void OpenUserManualComponent()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x615B34", Offset = "0x615B34", VA = "0x615B34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23DCEC", Offset = "0x23DCEC")]
		private void OpenUserManualPerformance()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x615B94", Offset = "0x615B94", VA = "0x615B94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23DD34", Offset = "0x23DD34")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x615BF4", Offset = "0x615BF4", VA = "0x615BF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23DD68", Offset = "0x23DD68")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x615C54", Offset = "0x615C54", VA = "0x615C54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23DD9C", Offset = "0x23DD9C")]
		private void OpenComponentTutorial()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x615CB4", Offset = "0x615CB4", VA = "0x615CB4")]
		private void ResetStateSettings()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x615F08", Offset = "0x615F08", VA = "0x615F08")]
		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x615F54", Offset = "0x615F54", VA = "0x615F54")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x616028", Offset = "0x616028", VA = "0x616028")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x616B0C", Offset = "0x616B0C", VA = "0x616B0C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x617BB4", Offset = "0x617BB4", VA = "0x617BB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x617C94", Offset = "0x617C94", VA = "0x617C94")]
		public Transform FindTargetRootRecursive(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x616B54", Offset = "0x616B54", VA = "0x616B54")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x619A5C", Offset = "0x619A5C", VA = "0x619A5C")]
		private void ActivateBehaviour(BehaviourBase behaviour)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x619BAC", Offset = "0x619BAC", VA = "0x619BAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x619CE4", Offset = "0x619CE4", VA = "0x619CE4")]
		private bool IsInterpolated()
		{
			return default(bool);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x619D88", Offset = "0x619D88", VA = "0x619D88", Slot = "4")]
		public void CustomFixedUpdate()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x61B224", Offset = "0x61B224", VA = "0x61B224")]
		public void PostSimulation()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x61B228", Offset = "0x61B228", VA = "0x61B228", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x61B2C0", Offset = "0x61B2C0", VA = "0x61B2C0", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x61B31C", Offset = "0x61B31C", VA = "0x61B31C", Slot = "7")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x61B680", Offset = "0x61B680", VA = "0x61B680")]
		private void MoveToTarget()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x61A578", Offset = "0x61A578", VA = "0x61A578")]
		private void Read()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x61A330", Offset = "0x61A330", VA = "0x61A330")]
		private void FixTargetTransforms()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x61BC80", Offset = "0x61BC80", VA = "0x61BC80")]
		private void VisualizeTargetPose()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x61C010", Offset = "0x61C010", VA = "0x61C010")]
		private void VisualizeHierarchy(Transform t, Color color)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x61B034", Offset = "0x61B034", VA = "0x61B034")]
		private void SetInternalCollisions(bool collide)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x61B174", Offset = "0x61B174", VA = "0x61B174")]
		private void SetAngularLimits(bool limited)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x614BCC", Offset = "0x614BCC", VA = "0x614BCC")]
		public void AddMuscle(ConfigurableJoint joint, Transform target, Rigidbody connectTo, Transform targetParent, [Optional] Muscle.Props muscleProps, bool forceTreeHierarchy = false, bool forceLayers = true)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x5FA3D8", Offset = "0x5FA3D8", VA = "0x5FA3D8")]
		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x61CD20", Offset = "0x61CD20", VA = "0x61CD20")]
		public void ReplaceMuscle(ConfigurableJoint oldJoint, ConfigurableJoint newJoint)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x61CDD4", Offset = "0x61CDD4", VA = "0x61CDD4")]
		public void SetMuscles(Muscle[] newMuscles)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x61CE88", Offset = "0x61CE88", VA = "0x61CE88")]
		public void DisableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x61CF3C", Offset = "0x61CF3C", VA = "0x61CF3C")]
		public void EnableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x61CFF0", Offset = "0x61CFF0", VA = "0x61CFF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23DE64", Offset = "0x23DE64")]
		public void FlattenHierarchy()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x61D144", Offset = "0x61D144", VA = "0x61D144")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23DEAC", Offset = "0x23DEAC")]
		public void TreeHierarchy()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x61D348", Offset = "0x61D348", VA = "0x61D348")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23DEF0", Offset = "0x23DEF0")]
		public void FixMusclePositions()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x61D4F8", Offset = "0x61D4F8", VA = "0x61D4F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23DF34", Offset = "0x23DF34")]
		public void FixMuscleRotations()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x61D6B0", Offset = "0x61D6B0", VA = "0x61D6B0")]
		private void AddIndexesRecursive(int index, ref int[] indexes)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x61932C", Offset = "0x61932C", VA = "0x61932C")]
		private bool HierarchyIsFlat()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x61CAC0", Offset = "0x61CAC0", VA = "0x61CAC0")]
		private void DisconnectJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x61CBF4", Offset = "0x61CBF4", VA = "0x61CBF4")]
		private void KillJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x61D978", Offset = "0x61D978", VA = "0x61D978")]
		public void DisableImmediately()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x61DA3C", Offset = "0x61DA3C", VA = "0x61DA3C", Slot = "8")]
		protected virtual void SwitchModes()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x61DBE8", Offset = "0x61DBE8", VA = "0x61DBE8")]
		private void DisabledToKinematic()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x61DDA8", Offset = "0x61DDA8", VA = "0x61DDA8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x23DF98", Offset = "0x23DF98")]
		private IEnumerator DisabledToActive()
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x61DE30", Offset = "0x61DE30", VA = "0x61DE30")]
		private void KinematicToDisabled()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x61DEF0", Offset = "0x61DEF0", VA = "0x61DEF0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x23E010", Offset = "0x23E010")]
		private IEnumerator KinematicToActive()
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x61DF78", Offset = "0x61DF78", VA = "0x61DF78")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x23E088", Offset = "0x23E088")]
		private IEnumerator ActiveToDisabled()
		{
			return null;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x61E000", Offset = "0x61E000", VA = "0x61E000")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x23E100", Offset = "0x23E100")]
		private IEnumerator ActiveToKinematic()
		{
			return null;
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x61E088", Offset = "0x61E088", VA = "0x61E088")]
		private void UpdateInternalCollisions()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x61E1A8", Offset = "0x61E1A8", VA = "0x61E1A8")]
		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x61E2C4", Offset = "0x61E2C4", VA = "0x61E2C4")]
		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x61E850", Offset = "0x61E850", VA = "0x61E850")]
		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x61EB50", Offset = "0x61EB50", VA = "0x61EB50")]
		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x61ECB4", Offset = "0x61ECB4", VA = "0x61ECB4")]
		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x61EE1C", Offset = "0x61EE1C", VA = "0x61EE1C")]
		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x61E584", Offset = "0x61E584", VA = "0x61E584")]
		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x61EE84", Offset = "0x61EE84", VA = "0x61EE84")]
		public Muscle GetMuscle(Transform target)
		{
			return null;
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x61C37C", Offset = "0x61C37C", VA = "0x61C37C")]
		public Muscle GetMuscle(Rigidbody rigidbody)
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x61F13C", Offset = "0x61F13C", VA = "0x61F13C")]
		public Muscle GetMuscle(ConfigurableJoint joint)
		{
			return null;
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x61C268", Offset = "0x61C268", VA = "0x61C268")]
		public bool ContainsJoint(ConfigurableJoint joint)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x61E8B8", Offset = "0x61E8B8", VA = "0x61E8B8")]
		public int GetMuscleIndex(HumanBodyBones humanBodyBone)
		{
			return default(int);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x61E32C", Offset = "0x61E32C", VA = "0x61E32C")]
		public int GetMuscleIndex(Transform target)
		{
			return default(int);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x61EEE4", Offset = "0x61EEE4", VA = "0x61EEE4")]
		public int GetMuscleIndex(Rigidbody rigidbody)
		{
			return default(int);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x61C868", Offset = "0x61C868", VA = "0x61C868")]
		public int GetMuscleIndex(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x61F19C", Offset = "0x61F19C", VA = "0x61F19C")]
		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x6204F0", Offset = "0x6204F0", VA = "0x6204F0")]
		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x61F2CC", Offset = "0x61F2CC", VA = "0x61F2CC")]
		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x6206D0", Offset = "0x6206D0", VA = "0x6206D0")]
		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x62136C", Offset = "0x62136C", VA = "0x62136C")]
		private void SetUpMuscles(Transform setUpTo)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x6224C0", Offset = "0x6224C0", VA = "0x6224C0")]
		private static Muscle.Group FindGroup(Animator animator, Transform t)
		{
			return default(Muscle.Group);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x620D3C", Offset = "0x620D3C", VA = "0x620D3C")]
		private void RemoveUnnecessaryBones()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x621FF8", Offset = "0x621FF8", VA = "0x621FF8")]
		private static bool IsClothCollider(Collider collider, Cloth[] cloths)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x622BA4", Offset = "0x622BA4", VA = "0x622BA4")]
		public void Kill(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x622BCC", Offset = "0x622BCC", VA = "0x622BCC")]
		public void Freeze(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x622BF4", Offset = "0x622BF4", VA = "0x622BF4")]
		public void Resurrect()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x622C00", Offset = "0x622C00", VA = "0x622C00", Slot = "9")]
		protected virtual void SwitchStates()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x622D1C", Offset = "0x622D1C", VA = "0x622D1C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x23E198", Offset = "0x23E198")]
		private IEnumerator AliveToDead(bool freeze)
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x61B8AC", Offset = "0x61B8AC", VA = "0x61B8AC")]
		private void OnFreezeFlag()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x622DC0", Offset = "0x622DC0", VA = "0x622DC0")]
		private void DeadToAlive()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x61672C", Offset = "0x61672C", VA = "0x61672C")]
		private void SetAnimationEnabled(bool to)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x622F34", Offset = "0x622F34", VA = "0x622F34")]
		private void DeadToFrozen()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x622F40", Offset = "0x622F40", VA = "0x622F40")]
		private void FrozenToAlive()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x623278", Offset = "0x623278", VA = "0x623278")]
		private void FrozenToDead()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x61686C", Offset = "0x61686C", VA = "0x61686C")]
		private void ActivateRagdoll(bool kinematic = false)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x623364", Offset = "0x623364", VA = "0x623364")]
		private bool CanFreeze()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x6036D0", Offset = "0x6036D0", VA = "0x6036D0")]
		public void SampleTargetMappedState()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x60093C", Offset = "0x60093C", VA = "0x60093C")]
		public void FixTargetToSampledState(float weight)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x619480", Offset = "0x619480", VA = "0x619480")]
		public void StoreTargetMappedState()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x6190A4", Offset = "0x6190A4", VA = "0x6190A4")]
		private void UpdateHierarchies()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x623D28", Offset = "0x623D28", VA = "0x623D28")]
		private bool HasProp()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x623BC4", Offset = "0x623BC4", VA = "0x623BC4")]
		private void UpdateBroadcasterMuscleIndexes()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x623448", Offset = "0x623448", VA = "0x623448")]
		private void AssignParentAndChildIndexes()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x623DB8", Offset = "0x623DB8", VA = "0x623DB8")]
		private void AddToParentsRecursive(ConfigurableJoint joint, ref int[] indexes)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x623FC4", Offset = "0x623FC4", VA = "0x623FC4")]
		private void AddToChildrenRecursive(ConfigurableJoint joint, ref int[] indexes, ref bool[] childFlags)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x623A18", Offset = "0x623A18", VA = "0x623A18")]
		private void AssignKinshipDegrees()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x6243C8", Offset = "0x6243C8", VA = "0x6243C8")]
		private void AssignKinshipsDownRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x6245B8", Offset = "0x6245B8", VA = "0x6245B8")]
		private void AssignKinshipsUpRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x6242B4", Offset = "0x6242B4", VA = "0x6242B4")]
		private int GetMuscleIndexLowLevel(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x6180FC", Offset = "0x6180FC", VA = "0x6180FC")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x61C3DC", Offset = "0x61C3DC", VA = "0x61C3DC")]
		private bool CheckMassVariation(float threshold, bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x61C1BC", Offset = "0x61C1BC", VA = "0x61C1BC")]
		private bool CheckIfInitiated()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x624948", Offset = "0x624948", VA = "0x624948")]
		public PuppetMaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public enum MuscleRemoveMode
	{
		[Token(Token = "0x400026E")]
		Sever,
		[Token(Token = "0x400026F")]
		Explode,
		[Token(Token = "0x4000270")]
		Numb
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x230D60", Offset = "0x230D60")]
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000128")]
		public class HumanoidMuscle
		{
			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x2395F4", Offset = "0x2395F4")]
			public string name;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Muscle.Props props;

			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x7773F8", Offset = "0x7773F8", VA = "0x7773F8")]
			public HumanoidMuscle()
			{
			}
		}

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x234778", Offset = "0x234778")]
		public PuppetMaster.State state;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public PuppetMaster.Mode mode;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float blendTime;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool fixTargetTransforms;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int solverIterationCount;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool visualizeTargetPose;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2347AC", Offset = "0x2347AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2347AC", Offset = "0x2347AC")]
		public float mappingWeight;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2347FC", Offset = "0x2347FC")]
		public float pinWeight;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x234814", Offset = "0x234814")]
		public float muscleWeight;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x23482C", Offset = "0x23482C")]
		public float muscleSpring;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float muscleDamper;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x234860", Offset = "0x234860")]
		public float pinPow;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x234878", Offset = "0x234878")]
		public float pinDistanceFalloff;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool updateJointAnchors;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
		public bool angularLimits;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
		public bool internalCollisions;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x234894", Offset = "0x234894")]
		public HumanoidMuscle[] muscles;

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x776CC4", Offset = "0x776CC4", VA = "0x776CC4")]
		public void ApplyTo(PuppetMaster p)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x777170", Offset = "0x777170", VA = "0x777170")]
		private Muscle GetMuscle(HumanBodyBones boneId, Animator animator, PuppetMaster puppetMaster)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x7772F8", Offset = "0x7772F8", VA = "0x7772F8")]
		public PuppetMasterHumanoidConfig()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x230DE0", Offset = "0x230DE0")]
	public class PuppetMasterSettings : Singleton<PuppetMasterSettings>
	{
		[Serializable]
		[Token(Token = "0x2000129")]
		public class PuppetUpdateLimit
		{
			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x239624", Offset = "0x239624")]
			public int puppetsPerFrame;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private int index;

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x777BAC", Offset = "0x777BAC", VA = "0x777BAC")]
			public PuppetUpdateLimit()
			{
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x7779D0", Offset = "0x7779D0", VA = "0x7779D0")]
			public void Step(int puppetCount)
			{
			}

			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x7775A8", Offset = "0x7775A8", VA = "0x7775A8")]
			public bool Update(List<PuppetMaster> puppets, PuppetMaster puppetMaster)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2348C8", Offset = "0x2348C8")]
		public PuppetUpdateLimit kinematicCollidersUpdateLimit;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PuppetUpdateLimit freeUpdateLimit;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public PuppetUpdateLimit fixedUpdateLimit;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool collisionStayMessages;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool collisionExitMessages;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float activePuppetCollisionThresholdMlp;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x234904", Offset = "0x234904")]
		private int <currentlyActivePuppets>k__BackingField;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x234914", Offset = "0x234914")]
		private int <currentlyKinematicPuppets>k__BackingField;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x234924", Offset = "0x234924")]
		private int <currentlyDisabledPuppets>k__BackingField;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private List<PuppetMaster> _puppets;

		[Token(Token = "0x17000067")]
		public int currentlyActivePuppets
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x777400", Offset = "0x777400", VA = "0x777400")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E210", Offset = "0x23E210")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x777408", Offset = "0x777408", VA = "0x777408")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E220", Offset = "0x23E220")]
			private set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public int currentlyKinematicPuppets
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x777410", Offset = "0x777410", VA = "0x777410")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E230", Offset = "0x23E230")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x777418", Offset = "0x777418", VA = "0x777418")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E240", Offset = "0x23E240")]
			private set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public int currentlyDisabledPuppets
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x777420", Offset = "0x777420", VA = "0x777420")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E250", Offset = "0x23E250")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x777428", Offset = "0x777428", VA = "0x777428")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E260", Offset = "0x23E260")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public List<PuppetMaster> puppets
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x777430", Offset = "0x777430", VA = "0x777430")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x777438", Offset = "0x777438", VA = "0x777438")]
		public void Register(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x7774F0", Offset = "0x7774F0", VA = "0x7774F0")]
		public void Unregister(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x777570", Offset = "0x777570", VA = "0x777570")]
		public bool UpdateMoveToTarget(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x7776D4", Offset = "0x7776D4", VA = "0x7776D4")]
		public bool UpdateFree(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x77770C", Offset = "0x77770C", VA = "0x77770C")]
		public bool UpdateFixed(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x777744", Offset = "0x777744", VA = "0x777744")]
		private void Update()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x7779EC", Offset = "0x7779EC", VA = "0x7779EC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x777A7C", Offset = "0x777A7C", VA = "0x777A7C")]
		public PuppetMasterSettings()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public static class PuppetMasterTools
	{
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x777BCC", Offset = "0x777BCC", VA = "0x777BCC")]
		public static void PositionRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x778694", Offset = "0x778694", VA = "0x778694")]
		public static void RealignRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x779780", Offset = "0x779780", VA = "0x779780")]
		private static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x779880", Offset = "0x779880", VA = "0x779880")]
		private static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class Weight
	{
		[Serializable]
		[Token(Token = "0x200012A")]
		public enum Mode
		{
			[Token(Token = "0x4000735")]
			Float,
			[Token(Token = "0x4000736")]
			Curve
		}

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Mode mode;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float floatValue;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public string tooltip;

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x77F090", Offset = "0x77F090", VA = "0x77F090")]
		public Weight(float floatValue)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x77F10C", Offset = "0x77F10C", VA = "0x77F10C")]
		public Weight(float floatValue, string tooltip)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x77F190", Offset = "0x77F190", VA = "0x77F190")]
		public float GetValue(float param)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x230E4C", Offset = "0x230E4C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x230E4C", Offset = "0x230E4C")]
	public class BipedRagdollCreator : RagdollCreator
	{
		[Serializable]
		[Token(Token = "0x200012B")]
		public struct Options
		{
			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float weight;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x239640", Offset = "0x239640")]
			public bool spine;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public bool chest;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public bool hands;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public bool feet;

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x23967C", Offset = "0x23967C")]
			public JointType joints;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float jointRange;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2396B0", Offset = "0x2396B0")]
			public float colliderLengthOverlap;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ColliderType torsoColliders;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ColliderType headCollider;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColliderType armColliders;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ColliderType handColliders;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public ColliderType legColliders;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ColliderType footColliders;

			[Token(Token = "0x1700016F")]
			public static Options Default
			{
				[Token(Token = "0x60009D5")]
				[Address(RVA = "0x603FF0", Offset = "0x603FF0", VA = "0x603FF0")]
				get
				{
					return default(Options);
				}
			}
		}

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool canBuild;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BipedRagdollReferences references;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Options options;

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x603BD4", Offset = "0x603BD4", VA = "0x603BD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E270", Offset = "0x23E270")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x603C34", Offset = "0x603C34", VA = "0x603C34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E2A4", Offset = "0x23E2A4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x603C94", Offset = "0x603C94", VA = "0x603C94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E2D8", Offset = "0x23E2D8")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x603CF8", Offset = "0x603CF8", VA = "0x603CF8")]
		public static Options AutodetectOptions(BipedRagdollReferences r)
		{
			return default(Options);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x604154", Offset = "0x604154", VA = "0x604154")]
		public static void Create(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x604850", Offset = "0x604850", VA = "0x604850")]
		private static void CreateColliders(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x607054", Offset = "0x607054", VA = "0x607054")]
		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, Options options)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x60744C", Offset = "0x60744C", VA = "0x60744C")]
		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, Options options)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x607D20", Offset = "0x607D20", VA = "0x607D20")]
		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x605A54", Offset = "0x605A54", VA = "0x605A54")]
		private static void MassDistribution(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x6062D8", Offset = "0x6062D8", VA = "0x6062D8")]
		private static void CreateJoints(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x607F88", Offset = "0x607F88", VA = "0x607F88")]
		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, JointType jointType, CreateJointParams.Limits limits1, CreateJointParams.Limits limits2, CreateJointParams.Limits limits3)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x608A5C", Offset = "0x608A5C", VA = "0x608A5C")]
		public static void ClearBipedRagdoll(BipedRagdollReferences r)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x609094", Offset = "0x609094", VA = "0x609094")]
		public static bool IsClear(BipedRagdollReferences r)
		{
			return default(bool);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x606EE0", Offset = "0x606EE0", VA = "0x606EE0")]
		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x604050", Offset = "0x604050", VA = "0x604050")]
		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x6091D0", Offset = "0x6091D0", VA = "0x6091D0")]
		public BipedRagdollCreator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public struct BipedRagdollReferences
	{
		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform root;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Transform hips;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform spine;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform chest;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform head;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform leftUpperLeg;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftLowerLeg;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Transform leftFoot;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperLeg;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Transform rightLowerLeg;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightFoot;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Transform leftUpperArm;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftLowerArm;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform leftHand;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightUpperArm;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Transform rightLowerArm;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightHand;

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x2C4778", Offset = "0x2C4778", VA = "0x2C4778")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x2C4780", Offset = "0x2C4780", VA = "0x2C4780")]
		public bool IsEmpty(bool considerRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x2C4788", Offset = "0x2C4788", VA = "0x2C4788")]
		public bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x2C4790", Offset = "0x2C4790", VA = "0x2C4790")]
		public Transform[] GetRagdollTransforms()
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x609C78", Offset = "0x609C78", VA = "0x609C78")]
		public static BipedRagdollReferences FromAvatar(Animator animator)
		{
			return default(BipedRagdollReferences);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x60A0D8", Offset = "0x60A0D8", VA = "0x60A0D8")]
		public static BipedRagdollReferences FromBipedReferences(BipedReferences biped)
		{
			return default(BipedRagdollReferences);
		}
	}
	[Token(Token = "0x2000047")]
	public static class JointConverter
	{
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x60A61C", Offset = "0x60A61C", VA = "0x60A61C")]
		public static void ToConfigurable(GameObject root)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x60AE84", Offset = "0x60AE84", VA = "0x60AE84")]
		public static void HingeToConfigurable(HingeJoint src)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x60B384", Offset = "0x60B384", VA = "0x60B384")]
		public static void FixedToConfigurable(FixedJoint src)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x60B5C0", Offset = "0x60B5C0", VA = "0x60B5C0")]
		public static void SpringToConfigurable(SpringJoint src)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x60A944", Offset = "0x60A944", VA = "0x60A944")]
		public static void CharacterToConfigurable(CharacterJoint src)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x60B8E0", Offset = "0x60B8E0", VA = "0x60B8E0")]
		private static void ConvertJoint(ref ConfigurableJoint conf, Joint src)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x60BB30", Offset = "0x60BB30", VA = "0x60BB30")]
		private static SoftJointLimit ConvertToHighSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x60BC4C", Offset = "0x60BC4C", VA = "0x60BC4C")]
		private static SoftJointLimit ConvertToLowSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x60BBD0", Offset = "0x60BBD0", VA = "0x60BBD0")]
		private static SoftJointLimitSpring ConvertToSoftJointLimitSpring(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimitSpring);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x60BCEC", Offset = "0x60BCEC", VA = "0x60BCEC")]
		private static SoftJointLimit CopyLimit(SoftJointLimit src)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x60BD6C", Offset = "0x60BD6C", VA = "0x60BD6C")]
		private static SoftJointLimitSpring CopyLimitSpring(SoftJointLimitSpring src)
		{
			return default(SoftJointLimitSpring);
		}
	}
	[Token(Token = "0x2000048")]
	public abstract class RagdollCreator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200012C")]
		public enum ColliderType
		{
			[Token(Token = "0x4000746")]
			Box,
			[Token(Token = "0x4000747")]
			Capsule
		}

		[Serializable]
		[Token(Token = "0x200012D")]
		public enum JointType
		{
			[Token(Token = "0x4000749")]
			Configurable,
			[Token(Token = "0x400074A")]
			Character
		}

		[Serializable]
		[Token(Token = "0x200012E")]
		public enum Direction
		{
			[Token(Token = "0x400074C")]
			X,
			[Token(Token = "0x400074D")]
			Y,
			[Token(Token = "0x400074E")]
			Z
		}

		[Token(Token = "0x200012F")]
		public struct CreateJointParams
		{
			[Token(Token = "0x2000191")]
			public struct Limits
			{
				[Token(Token = "0x4000962")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float minSwing;

				[Token(Token = "0x4000963")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public float maxSwing;

				[Token(Token = "0x4000964")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public float swing2;

				[Token(Token = "0x4000965")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public float twist;

				[Token(Token = "0x6000BDC")]
				[Address(RVA = "0x2CCF9C", Offset = "0x2CCF9C", VA = "0x2CCF9C")]
				public Limits(float minSwing, float maxSwing, float swing2, float twist)
				{
				}
			}

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rigidbody rigidbody;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Rigidbody connectedBody;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform child;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 worldSwingAxis;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Limits limits;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JointType type;

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x2CCF44", Offset = "0x2CCF44", VA = "0x2CCF44")]
			public CreateJointParams(Rigidbody rigidbody, Rigidbody connectedBody, Transform child, Vector3 worldSwingAxis, Limits limits, JointType type)
			{
			}
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x779A20", Offset = "0x779A20", VA = "0x779A20")]
		public static void ClearAll(Transform root)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x779CE8", Offset = "0x779CE8", VA = "0x779CE8")]
		protected static void ClearTransform(Transform transform)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x779FEC", Offset = "0x779FEC", VA = "0x779FEC")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x77A838", Offset = "0x77A838", VA = "0x77A838")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x77A640", Offset = "0x77A640", VA = "0x77A640")]
		protected static float GetScaleF(Transform t)
		{
			return default(float);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x77AD80", Offset = "0x77AD80", VA = "0x77AD80")]
		protected static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x77ADB4", Offset = "0x77ADB4", VA = "0x77ADB4")]
		protected static void Vector3Abs(ref Vector3 v)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x77AE58", Offset = "0x77AE58", VA = "0x77AE58")]
		protected static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x77AF58", Offset = "0x77AF58", VA = "0x77AF58")]
		protected static Vector3 DirectionToVector3(Direction dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x77A698", Offset = "0x77A698", VA = "0x77A698")]
		protected static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x77B058", Offset = "0x77B058", VA = "0x77B058")]
		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x77B454", Offset = "0x77B454", VA = "0x77B454")]
		protected static Rigidbody GetConnectedBody(Transform bone, ref Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x77B6B8", Offset = "0x77B6B8", VA = "0x77B6B8")]
		protected static void CreateJoint(CreateJointParams p)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x77C1DC", Offset = "0x77C1DC", VA = "0x77C1DC")]
		private static SoftJointLimit ToSoftJointLimit(float limit)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x77C220", Offset = "0x77C220", VA = "0x77C220")]
		protected RagdollCreator()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x230EAC", Offset = "0x230EAC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x230EAC", Offset = "0x230EAC")]
	public class RagdollEditor : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000130")]
		public enum Mode
		{
			[Token(Token = "0x4000756")]
			Colliders,
			[Token(Token = "0x4000757")]
			Joints
		}

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x234934", Offset = "0x234934")]
		public Rigidbody selectedRigidbody;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x234944", Offset = "0x234944")]
		public Collider selectedCollider;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x234954", Offset = "0x234954")]
		public bool symmetry;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x234964", Offset = "0x234964")]
		public Mode mode;

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x77C288", Offset = "0x77C288", VA = "0x77C288")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E30C", Offset = "0x23E30C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x77C2E8", Offset = "0x77C2E8", VA = "0x77C2E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E340", Offset = "0x23E340")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x77C348", Offset = "0x77C348", VA = "0x77C348")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E374", Offset = "0x23E374")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x77C3A8", Offset = "0x77C3A8", VA = "0x77C3A8")]
		public RagdollEditor()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x230F40", Offset = "0x230F40")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x230F40", Offset = "0x230F40")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BipedReferences references;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x786DE0", Offset = "0x786DE0", VA = "0x786DE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E3A8", Offset = "0x23E3A8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x786E40", Offset = "0x786E40", VA = "0x786E40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E3DC", Offset = "0x23E3DC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x786EA0", Offset = "0x786EA0", VA = "0x786EA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E410", Offset = "0x23E410")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x786F00", Offset = "0x786F00", VA = "0x786F00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E444", Offset = "0x23E444")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x786F60", Offset = "0x786F60", VA = "0x786F60")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x787030", Offset = "0x787030", VA = "0x787030")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x787058", Offset = "0x787058", VA = "0x787058")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x787090", Offset = "0x787090", VA = "0x787090")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x7870C8", Offset = "0x7870C8", VA = "0x7870C8")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x787104", Offset = "0x787104", VA = "0x787104")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x787144", Offset = "0x787144", VA = "0x787144")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x78718C", Offset = "0x78718C", VA = "0x78718C")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x7871C8", Offset = "0x7871C8", VA = "0x7871C8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x787254", Offset = "0x787254", VA = "0x787254")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x7872A0", Offset = "0x7872A0", VA = "0x7872A0")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x7872EC", Offset = "0x7872EC", VA = "0x7872EC")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x786F88", Offset = "0x786F88", VA = "0x786F88")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x787334", Offset = "0x787334", VA = "0x787334")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x787344", Offset = "0x787344", VA = "0x787344")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x787354", Offset = "0x787354", VA = "0x787354")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x787834", Offset = "0x787834", VA = "0x787834", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x787940", Offset = "0x787940", VA = "0x787940", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x787F14", Offset = "0x787F14", VA = "0x787F14", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x7886A0", Offset = "0x7886A0", VA = "0x7886A0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x7886CC", Offset = "0x7886CC", VA = "0x7886CC")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverAim aim;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Constraints pelvis;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700006B")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x78764C", Offset = "0x78764C", VA = "0x78764C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x7888CC", Offset = "0x7888CC", VA = "0x7888CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x787C18", Offset = "0x787C18", VA = "0x787C18")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x788768", Offset = "0x788768", VA = "0x788768")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public abstract class Constraint
	{
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform transform;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float weight;

		[Token(Token = "0x1700006D")]
		public bool isValid
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x78CE74", Offset = "0x78CE74", VA = "0x78CE74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000363")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x78CF00", Offset = "0x78CF00", VA = "0x78CF00")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x78CF08", Offset = "0x78CF08", VA = "0x78CF08", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x78D034", Offset = "0x78D034", VA = "0x78D034")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x78D03C", Offset = "0x78D03C", VA = "0x78D03C")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 offset;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x1700006E")]
		private bool positionChanged
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x78D2F0", Offset = "0x78D2F0", VA = "0x78D2F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x78D05C", Offset = "0x78D05C", VA = "0x78D05C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x78D3BC", Offset = "0x78D3BC", VA = "0x78D3BC")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x78D3C4", Offset = "0x78D3C4", VA = "0x78D3C4")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Quaternion rotation;

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x78D3E4", Offset = "0x78D3E4", VA = "0x78D3E4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x78D520", Offset = "0x78D520", VA = "0x78D520")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x78D528", Offset = "0x78D528", VA = "0x78D528")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Quaternion offset;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool initiated;

		[Token(Token = "0x1700006F")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x78D7E0", Offset = "0x78D7E0", VA = "0x78D7E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x78D548", Offset = "0x78D548", VA = "0x78D548", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x78D8B4", Offset = "0x78D8B4", VA = "0x78D8B4")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x78D8BC", Offset = "0x78D8BC", VA = "0x78D8BC")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public class Constraints
	{
		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform transform;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform target;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 positionOffset;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x234974", Offset = "0x234974")]
		public float positionWeight;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 rotation;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23498C", Offset = "0x23498C")]
		public float rotationWeight;

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x78D8DC", Offset = "0x78D8DC", VA = "0x78D8DC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x787E98", Offset = "0x787E98", VA = "0x787E98")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x788200", Offset = "0x788200", VA = "0x788200")]
		public void Update()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x788BB0", Offset = "0x788BB0", VA = "0x788BB0")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000131")]
		public enum DOF
		{
			[Token(Token = "0x4000759")]
			One,
			[Token(Token = "0x400075A")]
			Three
		}

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2349A4", Offset = "0x2349A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2349A4", Offset = "0x2349A4")]
		public float weight;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234A0C", Offset = "0x234A0C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x234A0C", Offset = "0x234A0C")]
		public float rotationWeight;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234A5C", Offset = "0x234A5C")]
		public DOF rotationDOF;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234A90", Offset = "0x234A90")]
		public Transform bone1;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234ADC", Offset = "0x234ADC")]
		public Transform bone2;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234B28", Offset = "0x234B28")]
		public Transform bone3;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234B5C", Offset = "0x234B5C")]
		public Transform tip;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234B90", Offset = "0x234B90")]
		public Transform target;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x234BC4", Offset = "0x234BC4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private IKSolverLimb solver;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 bone1Axis;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 tipAxis;

		[Token(Token = "0x17000070")]
		public bool initiated
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0xC21304", Offset = "0xC21304", VA = "0xC21304")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E478", Offset = "0x23E478")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000378")]
			[Address(RVA = "0xC2130C", Offset = "0xC2130C", VA = "0xC2130C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E488", Offset = "0x23E488")]
			private set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0xC21314", Offset = "0xC21314", VA = "0xC21314")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600037A")]
			[Address(RVA = "0xC21348", Offset = "0xC21348", VA = "0xC21348")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0xC21380", Offset = "0xC21380", VA = "0xC21380")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600037C")]
			[Address(RVA = "0xC213B0", Offset = "0xC213B0", VA = "0xC213B0")]
			set
			{
			}
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xC213F0", Offset = "0xC213F0", VA = "0xC213F0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xC21538", Offset = "0xC21538", VA = "0xC21538")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xC21CEC", Offset = "0xC21CEC", VA = "0xC21CEC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xC21E38", Offset = "0xC21E38", VA = "0xC21E38")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xC21F74", Offset = "0xC21F74", VA = "0xC21F74")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xC22594", Offset = "0xC22594", VA = "0xC22594")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234BD4", Offset = "0x234BD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x234BD4", Offset = "0x234BD4")]
		public float weight;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Finger[] fingers;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x234C40", Offset = "0x234C40")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000073")]
		public bool initiated
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0xC225A8", Offset = "0xC225A8", VA = "0xC225A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E498", Offset = "0x23E498")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000384")]
			[Address(RVA = "0xC225B0", Offset = "0xC225B0", VA = "0xC225B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E4A8", Offset = "0x23E4A8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xC225B8", Offset = "0xC225B8", VA = "0xC225B8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xC22640", Offset = "0xC22640", VA = "0xC22640")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E4B8", Offset = "0x23E4B8")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xC22AEC", Offset = "0xC22AEC", VA = "0xC22AEC")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xC22D2C", Offset = "0xC22D2C", VA = "0xC22D2C")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xC22998", Offset = "0xC22998", VA = "0xC22998")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xC22F24", Offset = "0xC22F24", VA = "0xC22F24", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xC23020", Offset = "0xC23020", VA = "0xC23020")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xC230A4", Offset = "0xC230A4", VA = "0xC230A4")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xC23124", Offset = "0xC23124", VA = "0xC23124")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xC23194", Offset = "0xC23194", VA = "0xC23194", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xC23198", Offset = "0xC23198", VA = "0xC23198", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xC231AC", Offset = "0xC231AC", VA = "0xC231AC")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000132")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234C50", Offset = "0x234C50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x234C50", Offset = "0x234C50")]
		public float weight;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234CA0", Offset = "0x234CA0")]
		public Grounding solver;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x234D04", Offset = "0x234D04")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000074")]
		public bool initiated
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0xC24798", Offset = "0xC24798", VA = "0xC24798")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E4F0", Offset = "0x23E4F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000393")]
			[Address(RVA = "0xC247A0", Offset = "0xC247A0", VA = "0xC247A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E500", Offset = "0x23E500")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000391")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xC247A8", Offset = "0xC247A8", VA = "0xC247A8")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xC24B68", Offset = "0xC24B68", VA = "0xC24B68")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xC24950", Offset = "0xC24950", VA = "0xC24950")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xC24B94", Offset = "0xC24B94", VA = "0xC24B94")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000398")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000399")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xC24E60", Offset = "0xC24E60", VA = "0xC24E60")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x230FF0", Offset = "0x230FF0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x230FF0", Offset = "0x230FF0")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234D14", Offset = "0x234D14")]
		public BipedIK ik;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234D58", Offset = "0x234D58")]
		public float spineBend;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234D8C", Offset = "0x234D8C")]
		public float spineSpeed;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Transform[] feet;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 spineOffset;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastWeight;

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xC25260", Offset = "0xC25260", VA = "0xC25260", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E510", Offset = "0x23E510")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xC252C0", Offset = "0xC252C0", VA = "0xC252C0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E544", Offset = "0x23E544")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xC25320", Offset = "0xC25320", VA = "0xC25320", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xC25474", Offset = "0xC25474", VA = "0xC25474")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xC25598", Offset = "0xC25598", VA = "0xC25598")]
		private void Update()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xC25670", Offset = "0xC25670", VA = "0xC25670")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xC25E9C", Offset = "0xC25E9C", VA = "0xC25E9C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xC25F40", Offset = "0xC25F40", VA = "0xC25F40")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xC26AA0", Offset = "0xC26AA0", VA = "0xC26AA0")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xC26CC4", Offset = "0xC26CC4", VA = "0xC26CC4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xC26F80", Offset = "0xC26F80", VA = "0xC26F80")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xC271B8", Offset = "0xC271B8", VA = "0xC271B8")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x23107C", Offset = "0x23107C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x23107C", Offset = "0x23107C")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000133")]
		public class SpineEffector
		{
			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2396E8", Offset = "0x2396E8")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239730", Offset = "0x239730")]
			public float horizontalWeight;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239794", Offset = "0x239794")]
			public float verticalWeight;

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0xC28668", Offset = "0xC28668", VA = "0xC28668")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60009DC")]
			[Address(RVA = "0xC28678", Offset = "0xC28678", VA = "0xC28678")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234DC0", Offset = "0x234DC0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234E10", Offset = "0x234E10")]
		public float spineBend;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234E44", Offset = "0x234E44")]
		public float spineSpeed;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public SpineEffector[] spine;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform[] feet;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 spineOffset;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool firstSolve;

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xC2725C", Offset = "0xC2725C", VA = "0xC2725C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E578", Offset = "0x23E578")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xC272BC", Offset = "0xC272BC", VA = "0xC272BC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E5AC", Offset = "0x23E5AC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xC2731C", Offset = "0xC2731C", VA = "0xC2731C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E5E0", Offset = "0x23E5E0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xC2737C", Offset = "0xC2737C", VA = "0xC2737C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xC27430", Offset = "0xC27430", VA = "0xC27430")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xC274F4", Offset = "0xC274F4", VA = "0xC274F4")]
		private void Update()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xC27950", Offset = "0xC27950", VA = "0xC27950")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xC2795C", Offset = "0xC2795C", VA = "0xC2795C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xC275D4", Offset = "0xC275D4", VA = "0xC275D4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xC27968", Offset = "0xC27968", VA = "0xC27968")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xC28078", Offset = "0xC28078", VA = "0xC28078")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xC282E8", Offset = "0xC282E8", VA = "0xC282E8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xC28470", Offset = "0xC28470", VA = "0xC28470")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xC285C8", Offset = "0xC285C8", VA = "0xC285C8")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x231114", Offset = "0x231114")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x231114", Offset = "0x231114")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IK[] legs;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234E78", Offset = "0x234E78")]
		public Transform pelvis;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234EDC", Offset = "0x234EDC")]
		public Transform characterRoot;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234F10", Offset = "0x234F10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x234F10", Offset = "0x234F10")]
		public float rootRotationWeight;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234F60", Offset = "0x234F60")]
		public float rootRotationSpeed;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234F94", Offset = "0x234F94")]
		public float maxRootRotationAngle;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform[] feet;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int solvedFeet;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool solved;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float lastWeight;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xC286B4", Offset = "0xC286B4", VA = "0xC286B4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E614", Offset = "0x23E614")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xC28714", Offset = "0xC28714", VA = "0xC28714", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E648", Offset = "0x23E648")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xC28774", Offset = "0xC28774", VA = "0xC28774", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xC2879C", Offset = "0xC2879C", VA = "0xC2879C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xC28A08", Offset = "0xC28A08", VA = "0xC28A08")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xC28B7C", Offset = "0xC28B7C", VA = "0xC28B7C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xC294B4", Offset = "0xC294B4", VA = "0xC294B4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xC29B5C", Offset = "0xC29B5C", VA = "0xC29B5C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xC29E70", Offset = "0xC29E70", VA = "0xC29E70")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xC2A458", Offset = "0xC2A458", VA = "0xC2A458")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xC2A708", Offset = "0xC2A708", VA = "0xC2A708")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xC2A9B8", Offset = "0xC2A9B8", VA = "0xC2A9B8")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x23119C", Offset = "0x23119C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x23119C", Offset = "0x23119C")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000134")]
		public struct Foot
		{
			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Transform transform;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Quaternion rotation;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Grounding.Leg leg;

			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x2D8560", Offset = "0x2D8560", VA = "0x2D8560")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x234FF4", Offset = "0x234FF4")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235048", Offset = "0x235048")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x235048", Offset = "0x235048")]
		public float rootRotationWeight;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235098", Offset = "0x235098")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x235098", Offset = "0x235098")]
		public float minRootRotation;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2350EC", Offset = "0x2350EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2350EC", Offset = "0x2350EC")]
		public float maxRootRotation;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235140", Offset = "0x235140")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235174", Offset = "0x235174")]
		public float maxLegOffset;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2351D8", Offset = "0x2351D8")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235240", Offset = "0x235240")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x235240", Offset = "0x235240")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235290", Offset = "0x235290")]
		public Transform characterRoot;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2352C4", Offset = "0x2352C4")]
		public Transform pelvis;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2352F8", Offset = "0x2352F8")]
		public Transform lastSpineBone;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23532C", Offset = "0x23532C")]
		public Transform head;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public IK[] legs;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public IK[] forelegs;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x235398", Offset = "0x235398")]
		public Vector3 gravity;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Foot[] feet;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int solvedFeet;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool solved;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float angle;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Transform forefeetRoot;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion headRotation;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float lastWeight;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xC2AA5C", Offset = "0xC2AA5C", VA = "0xC2AA5C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E67C", Offset = "0x23E67C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xC2AABC", Offset = "0xC2AABC", VA = "0xC2AABC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E6B0", Offset = "0x23E6B0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xC2AB1C", Offset = "0xC2AB1C", VA = "0xC2AB1C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xC2AB64", Offset = "0xC2AB64", VA = "0xC2AB64")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xC2ACF0", Offset = "0xC2ACF0", VA = "0xC2ACF0")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xC2AEE8", Offset = "0xC2AEE8", VA = "0xC2AEE8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xC2AFC0", Offset = "0xC2AFC0", VA = "0xC2AFC0")]
		private void Update()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xC2B0A0", Offset = "0xC2B0A0", VA = "0xC2B0A0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xC2B540", Offset = "0xC2B540", VA = "0xC2B540")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xC2BAB4", Offset = "0xC2BAB4", VA = "0xC2BAB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xC2BC0C", Offset = "0xC2BC0C", VA = "0xC2BC0C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xC2C26C", Offset = "0xC2C26C", VA = "0xC2C26C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xC2CD4C", Offset = "0xC2CD4C", VA = "0xC2CD4C")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xC2D114", Offset = "0xC2D114", VA = "0xC2D114")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xC2D2C0", Offset = "0xC2D2C0", VA = "0xC2D2C0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xC2D748", Offset = "0xC2D748", VA = "0xC2D748")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xC2D77C", Offset = "0xC2D77C", VA = "0xC2D77C")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xC2DA18", Offset = "0xC2DA18", VA = "0xC2DA18")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x23122C", Offset = "0x23122C")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2353A8", Offset = "0x2353A8")]
		public VRIK ik;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Transform[] feet;

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xC2DB98", Offset = "0xC2DB98", VA = "0xC2DB98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E6E4", Offset = "0x23E6E4")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xC2DB9C", Offset = "0xC2DB9C", VA = "0xC2DB9C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E718", Offset = "0x23E718")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xC2DBA0", Offset = "0xC2DBA0", VA = "0xC2DBA0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E74C", Offset = "0x23E74C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xC2DBA4", Offset = "0xC2DBA4", VA = "0xC2DBA4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xC2DBCC", Offset = "0xC2DBCC", VA = "0xC2DBCC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xC2DC90", Offset = "0xC2DC90", VA = "0xC2DC90")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xC2DD68", Offset = "0xC2DD68", VA = "0xC2DD68")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xC2E0BC", Offset = "0xC2E0BC", VA = "0xC2E0BC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xC2E4FC", Offset = "0xC2E4FC", VA = "0xC2E4FC")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xC2E648", Offset = "0xC2E648", VA = "0xC2E648")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xC2E9C0", Offset = "0xC2E9C0", VA = "0xC2E9C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xC2EB48", Offset = "0xC2EB48", VA = "0xC2EB48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xC2ED58", Offset = "0xC2ED58", VA = "0xC2ED58")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000135")]
		public enum Quality
		{
			[Token(Token = "0x4000763")]
			Fastest,
			[Token(Token = "0x4000764")]
			Simple,
			[Token(Token = "0x4000765")]
			Best
		}

		[Token(Token = "0x2000136")]
		public class Leg
		{
			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2397E4", Offset = "0x2397E4")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2397F4", Offset = "0x2397F4")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x239804", Offset = "0x239804")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x239814", Offset = "0x239814")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x239824", Offset = "0x239824")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x239834", Offset = "0x239834")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x239844", Offset = "0x239844")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool invertFootCenter;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Grounding grounding;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float deltaTime;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Quaternion r;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private RaycastHit heelHit;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private Vector3 up;

			[Token(Token = "0x17000170")]
			public bool isGrounded
			{
				[Token(Token = "0x60009DE")]
				[Address(RVA = "0xC30F34", Offset = "0xC30F34", VA = "0xC30F34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2401D8", Offset = "0x2401D8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60009DF")]
				[Address(RVA = "0xC30F3C", Offset = "0xC30F3C", VA = "0xC30F3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2401E8", Offset = "0x2401E8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000171")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60009E0")]
				[Address(RVA = "0xC30F44", Offset = "0xC30F44", VA = "0xC30F44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2401F8", Offset = "0x2401F8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60009E1")]
				[Address(RVA = "0xC30F58", Offset = "0xC30F58", VA = "0xC30F58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240208", Offset = "0x240208")]
				private set
				{
				}
			}

			[Token(Token = "0x17000172")]
			public bool initiated
			{
				[Token(Token = "0x60009E2")]
				[Address(RVA = "0xC30F64", Offset = "0xC30F64", VA = "0xC30F64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240218", Offset = "0x240218")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60009E3")]
				[Address(RVA = "0xC30F6C", Offset = "0xC30F6C", VA = "0xC30F6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240228", Offset = "0x240228")]
				private set
				{
				}
			}

			[Token(Token = "0x17000173")]
			public float heightFromGround
			{
				[Token(Token = "0x60009E4")]
				[Address(RVA = "0xC30F74", Offset = "0xC30F74", VA = "0xC30F74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240238", Offset = "0x240238")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009E5")]
				[Address(RVA = "0xC30F7C", Offset = "0xC30F7C", VA = "0xC30F7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240248", Offset = "0x240248")]
				private set
				{
				}
			}

			[Token(Token = "0x17000174")]
			public Vector3 velocity
			{
				[Token(Token = "0x60009E6")]
				[Address(RVA = "0xC30F84", Offset = "0xC30F84", VA = "0xC30F84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240258", Offset = "0x240258")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60009E7")]
				[Address(RVA = "0xC30F98", Offset = "0xC30F98", VA = "0xC30F98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240268", Offset = "0x240268")]
				private set
				{
				}
			}

			[Token(Token = "0x17000175")]
			public Transform transform
			{
				[Token(Token = "0x60009E8")]
				[Address(RVA = "0xC30FA4", Offset = "0xC30FA4", VA = "0xC30FA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240278", Offset = "0x240278")]
				get
				{
					return null;
				}
				[Token(Token = "0x60009E9")]
				[Address(RVA = "0xC30FAC", Offset = "0xC30FAC", VA = "0xC30FAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240288", Offset = "0x240288")]
				private set
				{
				}
			}

			[Token(Token = "0x17000176")]
			public float IKOffset
			{
				[Token(Token = "0x60009EA")]
				[Address(RVA = "0xC30FB4", Offset = "0xC30FB4", VA = "0xC30FB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240298", Offset = "0x240298")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009EB")]
				[Address(RVA = "0xC30FBC", Offset = "0xC30FBC", VA = "0xC30FBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2402A8", Offset = "0x2402A8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000177")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60009F0")]
				[Address(RVA = "0xC31E6C", Offset = "0xC31E6C", VA = "0xC31E6C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000178")]
			private float rootYOffset
			{
				[Token(Token = "0x60009F9")]
				[Address(RVA = "0xC32268", Offset = "0xC32268", VA = "0xC32268")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60009EC")]
			[Address(RVA = "0xC2F5D0", Offset = "0xC2F5D0", VA = "0xC2F5D0")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60009ED")]
			[Address(RVA = "0xC30FC4", Offset = "0xC30FC4", VA = "0xC30FC4")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0xC30934", Offset = "0xC30934", VA = "0xC30934")]
			public void Reset()
			{
			}

			[Token(Token = "0x60009EF")]
			[Address(RVA = "0xC2F738", Offset = "0xC2F738", VA = "0xC2F738")]
			public void Process()
			{
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0xC31820", Offset = "0xC31820", VA = "0xC31820")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60009F2")]
			[Address(RVA = "0xC31024", Offset = "0xC31024", VA = "0xC31024")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60009F3")]
			[Address(RVA = "0xC32084", Offset = "0xC32084", VA = "0xC32084")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009F4")]
			[Address(RVA = "0xC3147C", Offset = "0xC3147C", VA = "0xC3147C")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60009F5")]
			[Address(RVA = "0xC3157C", Offset = "0xC3157C", VA = "0xC3157C")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0xC321D4", Offset = "0xC321D4", VA = "0xC321D4")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0xC31F40", Offset = "0xC31F40", VA = "0xC31F40")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60009F8")]
			[Address(RVA = "0xC323F0", Offset = "0xC323F0", VA = "0xC323F0")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0xC2F4D8", Offset = "0xC2F4D8", VA = "0xC2F4D8")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000137")]
		public class Pelvis
		{
			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x239854", Offset = "0x239854")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x239864", Offset = "0x239864")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Grounding grounding;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float damperF;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private bool initiated;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float lastTime;

			[Token(Token = "0x17000179")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60009FB")]
				[Address(RVA = "0xC32578", Offset = "0xC32578", VA = "0xC32578")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2402B8", Offset = "0x2402B8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60009FC")]
				[Address(RVA = "0xC3258C", Offset = "0xC3258C", VA = "0xC3258C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2402C8", Offset = "0x2402C8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700017A")]
			public float heightOffset
			{
				[Token(Token = "0x60009FD")]
				[Address(RVA = "0xC32598", Offset = "0xC32598", VA = "0xC32598")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2402D8", Offset = "0x2402D8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60009FE")]
				[Address(RVA = "0xC325A0", Offset = "0xC325A0", VA = "0xC325A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2402E8", Offset = "0x2402E8")]
				private set
				{
				}
			}

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0xC2F710", Offset = "0xC2F710", VA = "0xC2F710")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000A00")]
			[Address(RVA = "0xC30824", Offset = "0xC30824", VA = "0xC30824")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0xC325A8", Offset = "0xC325A8", VA = "0xC325A8")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0xC304AC", Offset = "0xC304AC", VA = "0xC304AC")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0xC2F5C8", Offset = "0xC2F5C8", VA = "0xC2F5C8")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2353F4", Offset = "0x2353F4")]
		public LayerMask layers;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235428", Offset = "0x235428")]
		public float maxStep;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23545C", Offset = "0x23545C")]
		public float heightOffset;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2354A8", Offset = "0x2354A8")]
		public float footSpeed;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2354FC", Offset = "0x2354FC")]
		public float footRadius;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235530", Offset = "0x235530")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x235530", Offset = "0x235530")]
		public float footCenterOffset;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2355A8", Offset = "0x2355A8")]
		public float prediction;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235610", Offset = "0x235610")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x235610", Offset = "0x235610")]
		public float footRotationWeight;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235694", Offset = "0x235694")]
		public float footRotationSpeed;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2356F8", Offset = "0x2356F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2356F8", Offset = "0x2356F8")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23574C", Offset = "0x23574C")]
		public bool rotateSolver;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235780", Offset = "0x235780")]
		public float pelvisSpeed;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2357D8", Offset = "0x2357D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2357D8", Offset = "0x2357D8")]
		public float pelvisDamper;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235860", Offset = "0x235860")]
		public float lowerPelvisWeight;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2358C4", Offset = "0x2358C4")]
		public float liftPelvisWeight;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2358F8", Offset = "0x2358F8")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23592C", Offset = "0x23592C")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235960", Offset = "0x235960")]
		public Quality quality;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x235994", Offset = "0x235994")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2359A4", Offset = "0x2359A4")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2359B4", Offset = "0x2359B4")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2359C4", Offset = "0x2359C4")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2359D4", Offset = "0x2359D4")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool initiated;

		[Token(Token = "0x17000075")]
		public Leg[] legs
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0xC2EDC8", Offset = "0xC2EDC8", VA = "0xC2EDC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E780", Offset = "0x23E780")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0xC2EDD0", Offset = "0xC2EDD0", VA = "0xC2EDD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E790", Offset = "0x23E790")]
			private set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0xC2EDD8", Offset = "0xC2EDD8", VA = "0xC2EDD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E7A0", Offset = "0x23E7A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0xC2EDE0", Offset = "0xC2EDE0", VA = "0xC2EDE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E7B0", Offset = "0x23E7B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public bool isGrounded
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0xC2EDE8", Offset = "0xC2EDE8", VA = "0xC2EDE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E7C0", Offset = "0x23E7C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0xC2EDF0", Offset = "0xC2EDF0", VA = "0xC2EDF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E7D0", Offset = "0x23E7D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public Transform root
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0xC2EDF8", Offset = "0xC2EDF8", VA = "0xC2EDF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E7E0", Offset = "0x23E7E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xC2EE00", Offset = "0xC2EE00", VA = "0xC2EE00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E7F0", Offset = "0x23E7F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0xC2EE08", Offset = "0xC2EE08", VA = "0xC2EE08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E800", Offset = "0x23E800")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xC2EE28", Offset = "0xC2EE28", VA = "0xC2EE28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23E810", Offset = "0x23E810")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public bool rootGrounded
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xC2EE80", Offset = "0xC2EE80", VA = "0xC2EE80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007B")]
		public Vector3 up
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0xC26C04", Offset = "0xC26C04", VA = "0xC26C04")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007C")]
		private bool useRootRotation
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0xC30A50", Offset = "0xC30A50", VA = "0xC30A50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xC2EEDC", Offset = "0xC2EEDC", VA = "0xC2EEDC")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xC2F3D0", Offset = "0xC2F3D0", VA = "0xC2F3D0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xC25B4C", Offset = "0xC25B4C", VA = "0xC25B4C")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xC267D4", Offset = "0xC267D4", VA = "0xC267D4")]
		public void Update()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xC291C4", Offset = "0xC291C4", VA = "0xC291C4")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xC253D4", Offset = "0xC253D4", VA = "0xC253D4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xC2F720", Offset = "0xC2F720", VA = "0xC2F720")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xC30B38", Offset = "0xC30B38", VA = "0xC30B38")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xC30CBC", Offset = "0xC30CBC", VA = "0xC30CBC")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xC30DF8", Offset = "0xC30DF8", VA = "0xC30DF8")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xC24F58", Offset = "0xC24F58", VA = "0xC24F58")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x23128C", Offset = "0x23128C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x23128C", Offset = "0x23128C")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverAim solver;

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x780A2C", Offset = "0x780A2C", VA = "0x780A2C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E820", Offset = "0x23E820")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x780A8C", Offset = "0x780A8C", VA = "0x780A8C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E854", Offset = "0x23E854")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x780AEC", Offset = "0x780AEC", VA = "0x780AEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E888", Offset = "0x23E888")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x780B4C", Offset = "0x780B4C", VA = "0x780B4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E8BC", Offset = "0x23E8BC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x780BAC", Offset = "0x780BAC", VA = "0x780BAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E8F0", Offset = "0x23E8F0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x780C0C", Offset = "0x780C0C", VA = "0x780C0C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x780C14", Offset = "0x780C14", VA = "0x780C14")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x23130C", Offset = "0x23130C")]
	public class ArmIK : IK
	{
		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverArm solver;

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x786B84", Offset = "0x786B84", VA = "0x786B84", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E924", Offset = "0x23E924")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x786C10", Offset = "0x786C10", VA = "0x786C10", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E958", Offset = "0x23E958")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x786C9C", Offset = "0x786C9C", VA = "0x786C9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E98C", Offset = "0x23E98C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x786CFC", Offset = "0x786CFC", VA = "0x786CFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E9C0", Offset = "0x23E9C0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x786D5C", Offset = "0x786D5C", VA = "0x786D5C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x786D64", Offset = "0x786D64", VA = "0x786D64")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x231360", Offset = "0x231360")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x231360", Offset = "0x231360")]
	public class CCDIK : IK
	{
		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x788F0C", Offset = "0x788F0C", VA = "0x788F0C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23E9F4", Offset = "0x23E9F4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x788F6C", Offset = "0x788F6C", VA = "0x788F6C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EA28", Offset = "0x23EA28")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x788FCC", Offset = "0x788FCC", VA = "0x788FCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EA5C", Offset = "0x23EA5C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x78902C", Offset = "0x78902C", VA = "0x78902C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EA90", Offset = "0x23EA90")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x78908C", Offset = "0x78908C", VA = "0x78908C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x789094", Offset = "0x789094", VA = "0x789094")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x231410", Offset = "0x231410")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x231410", Offset = "0x231410")]
	public class FABRIK : IK
	{
		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x78D968", Offset = "0x78D968", VA = "0x78D968", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EAC4", Offset = "0x23EAC4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x78D9C8", Offset = "0x78D9C8", VA = "0x78D9C8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EAF8", Offset = "0x23EAF8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x78DA28", Offset = "0x78DA28", VA = "0x78DA28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EB2C", Offset = "0x23EB2C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x78DA88", Offset = "0x78DA88", VA = "0x78DA88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EB60", Offset = "0x23EB60")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x78DAE8", Offset = "0x78DAE8", VA = "0x78DAE8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x78DAF0", Offset = "0x78DAF0", VA = "0x78DAF0")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2314C0", Offset = "0x2314C0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2314C0", Offset = "0x2314C0")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x78E5B4", Offset = "0x78E5B4", VA = "0x78E5B4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EB94", Offset = "0x23EB94")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x78E614", Offset = "0x78E614", VA = "0x78E614", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EBC8", Offset = "0x23EBC8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x78E674", Offset = "0x78E674", VA = "0x78E674")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EBFC", Offset = "0x23EBFC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x78E6D4", Offset = "0x78E6D4", VA = "0x78E6D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EC30", Offset = "0x23EC30")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x78E734", Offset = "0x78E734", VA = "0x78E734", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x78E73C", Offset = "0x78E73C", VA = "0x78E73C")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x231574", Offset = "0x231574")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x231574", Offset = "0x231574")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BipedReferences references;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xC23228", Offset = "0xC23228", VA = "0xC23228", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EC64", Offset = "0x23EC64")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xC23288", Offset = "0xC23288", VA = "0xC23288", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EC98", Offset = "0x23EC98")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xC232E8", Offset = "0xC232E8", VA = "0xC232E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23ECCC", Offset = "0x23ECCC")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xC23348", Offset = "0xC23348", VA = "0xC23348")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23ED00", Offset = "0x23ED00")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xC233A8", Offset = "0xC233A8", VA = "0xC233A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23ED48", Offset = "0x23ED48")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xC23408", Offset = "0xC23408", VA = "0xC23408")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23ED7C", Offset = "0x23ED7C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xC23468", Offset = "0xC23468", VA = "0xC23468")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xC234A8", Offset = "0xC234A8", VA = "0xC234A8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xC234B0", Offset = "0xC234B0", VA = "0xC234B0")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xC23754", Offset = "0xC23754", VA = "0xC23754")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xC23BE0", Offset = "0xC23BE0", VA = "0xC23BE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EDB0", Offset = "0x23EDB0")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xC23C18", Offset = "0xC23C18", VA = "0xC23C18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EDE8", Offset = "0x23EDE8")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xC23D40", Offset = "0xC23D40", VA = "0xC23D40")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000424")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xC35F50", Offset = "0xC35F50", VA = "0xC35F50", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xC3600C", Offset = "0xC3600C", VA = "0xC3600C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xC36094", Offset = "0xC36094", VA = "0xC36094", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000428")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000429")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xC23DE0", Offset = "0xC23DE0", VA = "0xC23DE0")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2359E4", Offset = "0x2359E4")]
		public IK[] IKComponents;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235A18", Offset = "0x235A18")]
		public Animator animator;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool fixedFrame;

		[Token(Token = "0x1700007D")]
		private bool animatePhysics
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0xC3A6D4", Offset = "0xC3A6D4", VA = "0xC3A6D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xC3A79C", Offset = "0xC3A79C", VA = "0xC3A79C")]
		private void Start()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xC3A830", Offset = "0xC3A830", VA = "0xC3A830")]
		private void Update()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xC3A964", Offset = "0xC3A964", VA = "0xC3A964")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xC3A994", Offset = "0xC3A994", VA = "0xC3A994")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xC3A854", Offset = "0xC3A854", VA = "0xC3A854")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xC3AA64", Offset = "0xC3AA64", VA = "0xC3AA64")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x231600", Offset = "0x231600")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xB7AB68", Offset = "0xB7AB68", VA = "0xB7AB68", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EE1C", Offset = "0x23EE1C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xB7ABF4", Offset = "0xB7ABF4", VA = "0xB7ABF4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EE50", Offset = "0x23EE50")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xB7AC80", Offset = "0xB7AC80", VA = "0xB7AC80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EE84", Offset = "0x23EE84")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xB7ACE0", Offset = "0xB7ACE0", VA = "0xB7ACE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EEB8", Offset = "0x23EEB8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xB7AD40", Offset = "0xB7AD40", VA = "0xB7AD40", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xB7AD48", Offset = "0xB7AD48", VA = "0xB7AD48")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x231654", Offset = "0x231654")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x231654", Offset = "0x231654")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xB7ADC4", Offset = "0xB7ADC4", VA = "0xB7ADC4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EEEC", Offset = "0x23EEEC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xB7AE24", Offset = "0xB7AE24", VA = "0xB7AE24", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EF20", Offset = "0x23EF20")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xB7AE84", Offset = "0xB7AE84", VA = "0xB7AE84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EF54", Offset = "0x23EF54")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xB7AEE4", Offset = "0xB7AEE4", VA = "0xB7AEE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EF88", Offset = "0x23EF88")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xB7AF44", Offset = "0xB7AF44", VA = "0xB7AF44", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xB7AF4C", Offset = "0xB7AF4C", VA = "0xB7AF4C")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x231704", Offset = "0x231704")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x231704", Offset = "0x231704")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xB7C32C", Offset = "0xB7C32C", VA = "0xB7C32C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EFBC", Offset = "0x23EFBC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xB7C38C", Offset = "0xB7C38C", VA = "0xB7C38C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23EFF0", Offset = "0x23EFF0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xB7C3EC", Offset = "0xB7C3EC", VA = "0xB7C3EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F024", Offset = "0x23F024")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xB7C44C", Offset = "0xB7C44C", VA = "0xB7C44C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F058", Offset = "0x23F058")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xB7C4AC", Offset = "0xB7C4AC", VA = "0xB7C4AC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xB7C4B4", Offset = "0xB7C4B4", VA = "0xB7C4B4")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2317B8", Offset = "0x2317B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2317B8", Offset = "0x2317B8")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xE68D64", Offset = "0xE68D64", VA = "0xE68D64", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F08C", Offset = "0x23F08C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xE68DC4", Offset = "0xE68DC4", VA = "0xE68DC4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F0C0", Offset = "0x23F0C0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xE68E24", Offset = "0xE68E24", VA = "0xE68E24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F0F4", Offset = "0x23F0F4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xE68E84", Offset = "0xE68E84", VA = "0xE68E84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F128", Offset = "0x23F128")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xE68EE4", Offset = "0xE68EE4", VA = "0xE68EE4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xE68EEC", Offset = "0xE68EEC", VA = "0xE68EEC")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x231870", Offset = "0x231870")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000138")]
		public class References
		{
			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform root;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform pelvis;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform spine;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239874", Offset = "0x239874")]
			public Transform chest;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2398A8", Offset = "0x2398A8")]
			public Transform neck;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Transform head;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2398DC", Offset = "0x2398DC")]
			public Transform leftShoulder;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Transform leftUpperArm;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform leftForearm;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Transform leftHand;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239910", Offset = "0x239910")]
			public Transform rightShoulder;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Transform rightUpperArm;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform rightForearm;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Transform rightHand;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239944", Offset = "0x239944")]
			public Transform leftThigh;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239978", Offset = "0x239978")]
			public Transform leftCalf;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2399AC", Offset = "0x2399AC")]
			public Transform leftFoot;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2399E0", Offset = "0x2399E0")]
			public Transform leftToes;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239A14", Offset = "0x239A14")]
			public Transform rightThigh;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239A48", Offset = "0x239A48")]
			public Transform rightCalf;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239A7C", Offset = "0x239A7C")]
			public Transform rightFoot;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239AB0", Offset = "0x239AB0")]
			public Transform rightToes;

			[Token(Token = "0x1700017B")]
			public bool isFilled
			{
				[Token(Token = "0x6000A05")]
				[Address(RVA = "0xE6ADA8", Offset = "0xE6ADA8", VA = "0xE6ADA8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700017C")]
			public bool isEmpty
			{
				[Token(Token = "0x6000A06")]
				[Address(RVA = "0xE6A728", Offset = "0xE6A728", VA = "0xE6A728")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0xE6B6C8", Offset = "0xE6B6C8", VA = "0xE6B6C8")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000A07")]
			[Address(RVA = "0xE69FE4", Offset = "0xE69FE4", VA = "0xE69FE4")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0xE6B6C0", Offset = "0xE6B6C0", VA = "0xE6B6C0")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x235A4C", Offset = "0x235A4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235A4C", Offset = "0x235A4C")]
		public References references;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235AC4", Offset = "0x235AC4")]
		public IKSolverVR solver;

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xE69E4C", Offset = "0xE69E4C", VA = "0xE69E4C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F15C", Offset = "0x23F15C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xE69ED8", Offset = "0xE69ED8", VA = "0xE69ED8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F190", Offset = "0x23F190")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xE69F64", Offset = "0xE69F64", VA = "0xE69F64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F1C4", Offset = "0x23F1C4")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xE69FC4", Offset = "0xE69FC4", VA = "0xE69FC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F1F8", Offset = "0x23F1F8")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xE6A644", Offset = "0xE6A644", VA = "0xE6A644")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F22C", Offset = "0x23F22C")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xE6A67C", Offset = "0xE6A67C", VA = "0xE6A67C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xE6A684", Offset = "0xE6A684", VA = "0xE6A684", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xE6B464", Offset = "0xE6B464", VA = "0xE6B464", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xE6B620", Offset = "0xE6B620", VA = "0xE6B620")]
		public VRIK()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2318C0", Offset = "0x2318C0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2318C0", Offset = "0x2318C0")]
	public class AimIKJ : MonoBehaviour
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235AF8", Offset = "0x235AF8")]
		public Transform target;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235B2C", Offset = "0x235B2C")]
		public Transform poleTarget;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235B60", Offset = "0x235B60")]
		public Transform aimTransform;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x235B94", Offset = "0x235B94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235B94", Offset = "0x235B94")]
		public float axisX;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235BE4", Offset = "0x235BE4")]
		public float axisY;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235C18", Offset = "0x235C18")]
		public float axisZ;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x235C4C", Offset = "0x235C4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235C4C", Offset = "0x235C4C")]
		public float poleAxisX;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235C9C", Offset = "0x235C9C")]
		public float poleAxisY;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235CD0", Offset = "0x235CD0")]
		public float poleAxisZ;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x235D04", Offset = "0x235D04")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235D04", Offset = "0x235D04")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x235D04", Offset = "0x235D04")]
		public float weight;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235D6C", Offset = "0x235D6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x235D6C", Offset = "0x235D6C")]
		public float poleWeight;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235DD4", Offset = "0x235DD4")]
		public float tolerance;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235E08", Offset = "0x235E08")]
		public int maxIterations;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235E3C", Offset = "0x235E3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x235E3C", Offset = "0x235E3C")]
		public float clampWeight;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235E8C", Offset = "0x235E8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x235E8C", Offset = "0x235E8C")]
		public int clampSmoothing;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235EDC", Offset = "0x235EDC")]
		public bool useRotationLimits;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235F10", Offset = "0x235F10")]
		public bool XY;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x235F44", Offset = "0x235F44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235F44", Offset = "0x235F44")]
		public Transform[] bones;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x235F94", Offset = "0x235F94")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Animator animator;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PlayableGraph graph;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AnimationScriptPlayable IKPlayable;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AimIKJob job;

		[Token(Token = "0x1700007E")]
		public bool initiated
		{
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x780C90", Offset = "0x780C90", VA = "0x780C90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F260", Offset = "0x23F260")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x780C98", Offset = "0x780C98", VA = "0x780C98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F270", Offset = "0x23F270")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public Vector3 axis
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x780CA0", Offset = "0x780CA0", VA = "0x780CA0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x780CDC", Offset = "0x780CDC", VA = "0x780CDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public Vector3 poleAxis
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x780CE8", Offset = "0x780CE8", VA = "0x780CE8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x780D24", Offset = "0x780D24", VA = "0x780D24")]
			set
			{
			}
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x780D30", Offset = "0x780D30", VA = "0x780D30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x78216C", Offset = "0x78216C", VA = "0x78216C")]
		private void Update()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x782660", Offset = "0x782660", VA = "0x782660")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x78278C", Offset = "0x78278C", VA = "0x78278C")]
		public AimIKJ()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public struct AimIKJob : IAnimationJob
	{
		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public TransformSceneHandle _poleTarget;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TransformStreamHandle _transform;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PropertySceneHandle _IKPositionWeight;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public PropertySceneHandle _poleWeight;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public PropertySceneHandle _axisX;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public PropertySceneHandle _axisY;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public PropertySceneHandle _axisZ;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public PropertySceneHandle _poleAxisX;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public PropertySceneHandle _poleAxisY;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public PropertySceneHandle _poleAxisZ;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public PropertySceneHandle _clampWeight;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public PropertySceneHandle _clampSmoothing;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public PropertySceneHandle _maxIterations;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public PropertySceneHandle _tolerance;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public PropertySceneHandle _XY;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public PropertySceneHandle _useRotationLimits;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private NativeArray<TransformStreamHandle> bones;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private NativeArray<PropertySceneHandle> boneWeights;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 lastLocalDirection;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float step;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private NativeArray<Vector3> limitAxisArray;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private NativeArray<int> hingeFlags;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private NativeArray<Quaternion> hingeLastRotations;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private NativeArray<float> hingeLastAngles;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private NativeArray<int> angleFlags;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x2CD00C", Offset = "0x2CD00C", VA = "0x2CD00C")]
		public void Setup(Animator animator, Transform[] bones, Transform target, Transform poleTarget, Transform aimTransform)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x2CD034", Offset = "0x2CD034", VA = "0x2CD034")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x2CD03C", Offset = "0x2CD03C", VA = "0x2CD03C")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x2CD044", Offset = "0x2CD044", VA = "0x2CD044", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x2CD048", Offset = "0x2CD048", VA = "0x2CD048", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x2CD084", Offset = "0x2CD084", VA = "0x2CD084")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x2CD0C0", Offset = "0x2CD0C0", VA = "0x2CD0C0")]
		private void RotateToTarget(AnimationStream s, Vector3 targetPosition, Vector3 polePosition, int i, float weight, float poleWeight, bool XY, bool useRotationLimits, Vector3 axis, Vector3 poleAxis)
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x2CD178", Offset = "0x2CD178", VA = "0x2CD178")]
		public float GetAngle(AnimationStream s, Vector3 axis, Vector3 IKPosition)
		{
			return default(float);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x2CD1DC", Offset = "0x2CD1DC", VA = "0x2CD1DC")]
		private Vector3 GetClampedIKPosition(AnimationStream s, float clampWeight, int clampSmoothing, Vector3 IKPosition, Vector3 transformPosition, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x2CD240", Offset = "0x2CD240", VA = "0x2CD240")]
		private Vector3 GetLocalDirection(AnimationStream s, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x2CD290", Offset = "0x2CD290", VA = "0x2CD290")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x2CD2BC", Offset = "0x2CD2BC", VA = "0x2CD2BC")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x231984", Offset = "0x231984")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x231984", Offset = "0x231984")]
	public class CCDIKJ : MonoBehaviour
	{
		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235FA4", Offset = "0x235FA4")]
		public Transform target;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x235FD8", Offset = "0x235FD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x235FD8", Offset = "0x235FD8")]
		public float weight;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236028", Offset = "0x236028")]
		public float tolerance;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23605C", Offset = "0x23605C")]
		public int maxIterations;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236090", Offset = "0x236090")]
		public bool useRotationLimits;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2360C4", Offset = "0x2360C4")]
		public bool XY;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2360F8", Offset = "0x2360F8")]
		public Transform[] bones;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23612C", Offset = "0x23612C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator animator;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private PlayableGraph graph;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private AnimationScriptPlayable IKPlayable;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private CCDIKJob job;

		[Token(Token = "0x17000081")]
		public bool initiated
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x789110", Offset = "0x789110", VA = "0x789110")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F280", Offset = "0x23F280")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x789118", Offset = "0x789118", VA = "0x789118")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F290", Offset = "0x23F290")]
			private set
			{
			}
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x789120", Offset = "0x789120", VA = "0x789120")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x789CA0", Offset = "0x789CA0", VA = "0x789CA0")]
		private void Update()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x789E68", Offset = "0x789E68", VA = "0x789E68")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x789FAC", Offset = "0x789FAC", VA = "0x789FAC")]
		public CCDIKJ()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public struct CCDIKJob : IAnimationJob
	{
		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PropertySceneHandle _IKPositionWeight;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PropertySceneHandle _maxIterations;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PropertySceneHandle _tolerance;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PropertySceneHandle _XY;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PropertySceneHandle _useRotationLimits;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NativeArray<TransformStreamHandle> bones;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private NativeArray<PropertySceneHandle> boneWeights;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private NativeArray<float> boneSqrMags;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float chainSqrMag;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastLocalDirection;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private NativeArray<Vector3> limitAxisArray;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private NativeArray<int> hingeFlags;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private NativeArray<Quaternion> hingeLastRotations;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private NativeArray<float> hingeLastAngles;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private NativeArray<int> angleFlags;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x2CD320", Offset = "0x2CD320", VA = "0x2CD320")]
		public void Setup(Animator animator, Transform[] bones, Transform target)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x2CD33C", Offset = "0x2CD33C", VA = "0x2CD33C")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x2CD344", Offset = "0x2CD344", VA = "0x2CD344")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x2CD34C", Offset = "0x2CD34C", VA = "0x2CD34C", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x2CD350", Offset = "0x2CD350", VA = "0x2CD350", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x2CD38C", Offset = "0x2CD38C", VA = "0x2CD38C")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x2CD3C8", Offset = "0x2CD3C8", VA = "0x2CD3C8")]
		private void Read(AnimationStream s)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x2CD404", Offset = "0x2CD404", VA = "0x2CD404")]
		private void Solve(AnimationStream s, Vector3 targetPosition, bool XY, float weight, int it, bool useRotationLimits)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x2CD464", Offset = "0x2CD464", VA = "0x2CD464")]
		private Vector3 GetLocalDirection(AnimationStream s)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x2CD4A4", Offset = "0x2CD4A4", VA = "0x2CD4A4")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x2CD4D0", Offset = "0x2CD4D0", VA = "0x2CD4D0")]
		private Vector3 GetSingularityOffset(AnimationStream s, Vector3 IKPosition, bool useRotationLimits)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x2CD528", Offset = "0x2CD528", VA = "0x2CD528")]
		private bool SingularityDetected(AnimationStream s, Vector3 IKPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x2CD57C", Offset = "0x2CD57C", VA = "0x2CD57C")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class IKJBoneParams : MonoBehaviour
	{
		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23613C", Offset = "0x23613C")]
		public float weight;

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xC3AA6C", Offset = "0xC3AA6C", VA = "0xC3AA6C")]
		public IKJBoneParams()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public static class RotationLimitUtilities
	{
		[Token(Token = "0x600047D")]
		[Address(RVA = "0xE6772C", Offset = "0xE6772C", VA = "0xE6772C")]
		public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, ref Quaternion lastRotation, ref float lastAngle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xE67AE4", Offset = "0xE67AE4", VA = "0xE67AE4")]
		public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xE67BFC", Offset = "0xE67BFC", VA = "0xE67BFC")]
		public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xE67C70", Offset = "0xE67C70", VA = "0xE67C70")]
		public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xE67F4C", Offset = "0xE67F4C", VA = "0xE67F4C")]
		public static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class FABRIKChain
	{
		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public FABRIK ik;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236154", Offset = "0x236154")]
		public float pull;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23616C", Offset = "0x23616C")]
		public float pin;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int[] children;

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x78DB6C", Offset = "0x78DB6C", VA = "0x78DB6C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x78DC60", Offset = "0x78DC60", VA = "0x78DC60")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x78DC90", Offset = "0x78DC90", VA = "0x78DC90")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x78E338", Offset = "0x78E338", VA = "0x78E338")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x78DE24", Offset = "0x78DE24", VA = "0x78DE24")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x78E534", Offset = "0x78E534", VA = "0x78E534")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool initiated;

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x78E7B8", Offset = "0x78E7B8", VA = "0x78E7B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x78F094", Offset = "0x78F094", VA = "0x78F094")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x78F3D8", Offset = "0x78F3D8", VA = "0x78F3D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x78F528", Offset = "0x78F528", VA = "0x78F528")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000139")]
		public class BendBone
		{
			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239AE4", Offset = "0x239AE4")]
			public Transform transform;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239B30", Offset = "0x239B30")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x239B30", Offset = "0x239B30")]
			public float weight;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x794294", Offset = "0x794294", VA = "0x794294")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x794348", Offset = "0x794348", VA = "0x794348")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x7902AC", Offset = "0x7902AC", VA = "0x7902AC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x7909F0", Offset = "0x7909F0", VA = "0x7909F0")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236184", Offset = "0x236184")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2361B8", Offset = "0x2361B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2361B8", Offset = "0x2361B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2361B8", Offset = "0x2361B8")]
		public float positionWeight;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236254", Offset = "0x236254")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236254", Offset = "0x236254")]
		public float bodyWeight;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2362D0", Offset = "0x2362D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2362D0", Offset = "0x2362D0")]
		public float thighWeight;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23634C", Offset = "0x23634C")]
		public bool handsPullBody;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x236380", Offset = "0x236380")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236380", Offset = "0x236380")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236380", Offset = "0x236380")]
		public float rotationWeight;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236428", Offset = "0x236428")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236428", Offset = "0x236428")]
		public float bodyClampWeight;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236494", Offset = "0x236494")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236494", Offset = "0x236494")]
		public float headClampWeight;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236500", Offset = "0x236500")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236500", Offset = "0x236500")]
		public float bendWeight;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236550", Offset = "0x236550")]
		public BendBone[] bendBones;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x23659C", Offset = "0x23659C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23659C", Offset = "0x23659C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23659C", Offset = "0x23659C")]
		public float CCDWeight;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236610", Offset = "0x236610")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236610", Offset = "0x236610")]
		public float roll;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236690", Offset = "0x236690")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236690", Offset = "0x236690")]
		public float damper;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2366F8", Offset = "0x2366F8")]
		public Transform[] CCDBones;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x236764", Offset = "0x236764")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236764", Offset = "0x236764")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236764", Offset = "0x236764")]
		public float postStretchWeight;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2367E0", Offset = "0x2367E0")]
		public float maxStretch;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236828", Offset = "0x236828")]
		public float stretchDamper;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23687C", Offset = "0x23687C")]
		public bool fixHead;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2368B0", Offset = "0x2368B0")]
		public Transform[] stretchBones;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2368E4", Offset = "0x2368E4")]
		public Vector3 chestDirection;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236920", Offset = "0x236920")]
		public float chestDirectionWeight;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform[] chestBones;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 offset;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 headToBody;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float shoulderDist;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float leftShoulderDist;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float rightShoulderDist;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion chestRotation;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private int bendBonesCount;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private int ccdBonesCount;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int stretchBonesCount;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int chestBonesCount;

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x78F530", Offset = "0x78F530", VA = "0x78F530")]
		private void Start()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x78FA68", Offset = "0x78FA68", VA = "0x78FA68")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x7902FC", Offset = "0x7902FC", VA = "0x7902FC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x790A48", Offset = "0x790A48", VA = "0x790A48")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x7918B0", Offset = "0x7918B0", VA = "0x7918B0")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x791DCC", Offset = "0x791DCC", VA = "0x791DCC")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x7923A4", Offset = "0x7923A4", VA = "0x7923A4")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x793428", Offset = "0x793428", VA = "0x793428")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x7914D8", Offset = "0x7914D8", VA = "0x7914D8")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x79373C", Offset = "0x79373C", VA = "0x79373C")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x79326C", Offset = "0x79326C", VA = "0x79326C")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x79308C", Offset = "0x79308C", VA = "0x79308C")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x793C94", Offset = "0x793C94", VA = "0x793C94")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x7940D4", Offset = "0x7940D4", VA = "0x7940D4")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x200013A")]
		public class ChildConstraint
		{
			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float pushElasticity;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float pullElasticity;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x239BBC", Offset = "0x239BBC")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x239BCC", Offset = "0x239BCC")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float crossFade;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float inverseCrossFade;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int chain1Index;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int chain2Index;

			[Token(Token = "0x1700017D")]
			public float nominalDistance
			{
				[Token(Token = "0x6000A0D")]
				[Address(RVA = "0xC209F8", Offset = "0xC209F8", VA = "0xC209F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2402F8", Offset = "0x2402F8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A0E")]
				[Address(RVA = "0xC20A00", Offset = "0xC20A00", VA = "0xC20A00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240308", Offset = "0x240308")]
				private set
				{
				}
			}

			[Token(Token = "0x1700017E")]
			public bool isRigid
			{
				[Token(Token = "0x6000A0F")]
				[Address(RVA = "0xC20A08", Offset = "0xC20A08", VA = "0xC20A08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240318", Offset = "0x240318")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000A10")]
				[Address(RVA = "0xC20A10", Offset = "0xC20A10", VA = "0xC20A10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240328", Offset = "0x240328")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0xC20A18", Offset = "0xC20A18", VA = "0xC20A18")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000A12")]
			[Address(RVA = "0xC20A50", Offset = "0xC20A50", VA = "0xC20A50")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0xC20AC0", Offset = "0xC20AC0", VA = "0xC20AC0")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0xC20DF8", Offset = "0xC20DF8", VA = "0xC20DF8")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013B")]
		public enum Smoothing
		{
			[Token(Token = "0x40007A2")]
			None,
			[Token(Token = "0x40007A3")]
			Exponential,
			[Token(Token = "0x40007A4")]
			Cubic
		}

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236938", Offset = "0x236938")]
		public float pin;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236950", Offset = "0x236950")]
		public float pull;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236968", Offset = "0x236968")]
		public float push;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236980", Offset = "0x236980")]
		public float pushParent;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23699C", Offset = "0x23699C")]
		public float reach;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int[] children;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float rootLength;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool initiated;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float length;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float distance;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private IKSolver.Point p;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float reachForce;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float pullParentSum;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] crossFades;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float sqrMag1;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float sqrMag2;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float sqrMagDif;

		[Token(Token = "0x40003F4")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x794418", Offset = "0x794418", VA = "0x794418")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x794508", Offset = "0x794508", VA = "0x794508")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x794630", Offset = "0x794630", VA = "0x794630")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x794790", Offset = "0x794790", VA = "0x794790")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x7948A4", Offset = "0x7948A4", VA = "0x7948A4")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x7949EC", Offset = "0x7949EC", VA = "0x7949EC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x7957B0", Offset = "0x7957B0", VA = "0x7957B0")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x794CEC", Offset = "0x794CEC", VA = "0x794CEC")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x7961D0", Offset = "0x7961D0", VA = "0x7961D0")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x7967B8", Offset = "0x7967B8", VA = "0x7967B8")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x796E3C", Offset = "0x796E3C", VA = "0x796E3C")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x7976C8", Offset = "0x7976C8", VA = "0x7976C8")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x798308", Offset = "0x798308", VA = "0x798308")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x798814", Offset = "0x798814", VA = "0x798814")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x7981C8", Offset = "0x7981C8", VA = "0x7981C8")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x797440", Offset = "0x797440", VA = "0x797440")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x798130", Offset = "0x798130", VA = "0x798130")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x798A4C", Offset = "0x798A4C", VA = "0x798A4C")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x797EE4", Offset = "0x797EE4", VA = "0x797EE4")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x798548", Offset = "0x798548", VA = "0x798548")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform bone1;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform bone2;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone3;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform bendGoal;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 direction;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2369B4", Offset = "0x2369B4")]
		public float weight;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float clampF;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int chainIndex1;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int nodeIndex1;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int chainIndex2;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int nodeIndex2;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int chainIndex3;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int nodeIndex3;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2369CC", Offset = "0x2369CC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000082")]
		public bool initiated
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0xC363E8", Offset = "0xC363E8", VA = "0xC363E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F2A0", Offset = "0x23F2A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0xC363F0", Offset = "0xC363F0", VA = "0xC363F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F2B0", Offset = "0x23F2B0")]
			private set
			{
			}
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xC36114", Offset = "0xC36114", VA = "0xC36114")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xC363F8", Offset = "0xC363F8", VA = "0xC363F8")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xC364A8", Offset = "0xC364A8", VA = "0xC364A8")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xC36570", Offset = "0xC36570", VA = "0xC36570")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xC3657C", Offset = "0xC3657C", VA = "0xC3657C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xC36CB8", Offset = "0xC36CB8", VA = "0xC36CB8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xC36F90", Offset = "0xC36F90", VA = "0xC36F90")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xC37624", Offset = "0xC37624", VA = "0xC37624")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xC36988", Offset = "0xC36988", VA = "0xC36988")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xC36B20", Offset = "0xC36B20", VA = "0xC36B20")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class IKEffector
	{
		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform bone;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform target;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2369DC", Offset = "0x2369DC")]
		public float positionWeight;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2369F4", Offset = "0x2369F4")]
		public float rotationWeight;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 position;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Quaternion rotation;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 positionOffset;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x236A0C", Offset = "0x236A0C")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool effectChildNodes;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236A1C", Offset = "0x236A1C")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform[] childBones;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Transform planeBone1;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform planeBone2;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Transform planeBone3;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float posW;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float rotW;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool usePlaneNodes;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 animatedPosition;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool firstUpdate;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int chainIndex;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int nodeIndex;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000083")]
		public bool isEndEffector
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0xC37F04", Offset = "0xC37F04", VA = "0xC37F04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F2C0", Offset = "0x23F2C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0xC37F0C", Offset = "0xC37F0C", VA = "0xC37F0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F2D0", Offset = "0x23F2D0")]
			private set
			{
			}
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xC37E58", Offset = "0xC37E58", VA = "0xC37E58")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xC37F14", Offset = "0xC37F14", VA = "0xC37F14")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xC38038", Offset = "0xC38038", VA = "0xC38038")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xC381EC", Offset = "0xC381EC", VA = "0xC381EC")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xC383B0", Offset = "0xC383B0", VA = "0xC383B0")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xC388C0", Offset = "0xC388C0", VA = "0xC388C0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xC38D28", Offset = "0xC38D28", VA = "0xC38D28")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xC38F18", Offset = "0xC38F18", VA = "0xC38F18")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xC39020", Offset = "0xC39020", VA = "0xC39020")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xC399D8", Offset = "0xC399D8", VA = "0xC399D8")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xC39A70", Offset = "0xC39A70", VA = "0xC39A70")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xC39D4C", Offset = "0xC39D4C", VA = "0xC39D4C")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xC3A288", Offset = "0xC3A288", VA = "0xC3A288")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x200013C")]
		public class BoneMap
		{
			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int chainIndex;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int nodeIndex;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 planePosition;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 ikPosition;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public float length;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Transform planeBone1;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Transform planeBone2;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private Transform planeBone3;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private int plane1ChainIndex;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private int plane1NodeIndex;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private int plane2ChainIndex;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private int plane2NodeIndex;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int plane3ChainIndex;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int plane3NodeIndex;

			[Token(Token = "0x1700017F")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x6000A16")]
				[Address(RVA = "0xC3AD7C", Offset = "0xC3AD7C", VA = "0xC3AD7C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000180")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000A19")]
				[Address(RVA = "0xC3AF70", Offset = "0xC3AF70", VA = "0xC3AF70")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000181")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000A2D")]
				[Address(RVA = "0xC3B69C", Offset = "0xC3B69C", VA = "0xC3B69C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0xC3AD28", Offset = "0xC3AD28", VA = "0xC3AD28")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000A17")]
			[Address(RVA = "0xC3AE54", Offset = "0xC3AE54", VA = "0xC3AE54")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000A18")]
			[Address(RVA = "0xC3AED8", Offset = "0xC3AED8", VA = "0xC3AED8")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0xC3AF84", Offset = "0xC3AF84", VA = "0xC3AF84")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0xC3B080", Offset = "0xC3B080", VA = "0xC3B080")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0xC3B088", Offset = "0xC3B088", VA = "0xC3B088")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0xC3B24C", Offset = "0xC3B24C", VA = "0xC3B24C")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0xC3B39C", Offset = "0xC3B39C", VA = "0xC3B39C")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0xC3B494", Offset = "0xC3B494", VA = "0xC3B494")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0xC3B93C", Offset = "0xC3B93C", VA = "0xC3B93C")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000A21")]
			[Address(RVA = "0xC3B984", Offset = "0xC3B984", VA = "0xC3B984")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000A22")]
			[Address(RVA = "0xC3B9D4", Offset = "0xC3B9D4", VA = "0xC3B9D4")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0xC3BA20", Offset = "0xC3BA20", VA = "0xC3BA20")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0xC3BBD0", Offset = "0xC3BBD0", VA = "0xC3BBD0")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0xC3BFC8", Offset = "0xC3BFC8", VA = "0xC3BFC8")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000A26")]
			[Address(RVA = "0xC3C014", Offset = "0xC3C014", VA = "0xC3C014")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000A27")]
			[Address(RVA = "0xC3C1D8", Offset = "0xC3C1D8", VA = "0xC3C1D8")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000A28")]
			[Address(RVA = "0xC3C250", Offset = "0xC3C250", VA = "0xC3C250")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000A29")]
			[Address(RVA = "0xC3C51C", Offset = "0xC3C51C", VA = "0xC3C51C")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0xC3C7E0", Offset = "0xC3C7E0", VA = "0xC3C7E0")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0xC3C908", Offset = "0xC3C908", VA = "0xC3C908")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0xC3BD28", Offset = "0xC3BD28", VA = "0xC3BD28")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0xC3CB4C", Offset = "0xC3CB4C", VA = "0xC3CB4C")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xC3AA7C", Offset = "0xC3AA7C", VA = "0xC3AA7C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xC3AA84", Offset = "0xC3AA84", VA = "0xC3AA84", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xC3AA88", Offset = "0xC3AA88", VA = "0xC3AA88")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xC3ABE0", Offset = "0xC3ABE0", VA = "0xC3ABE0")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xC3AD20", Offset = "0xC3AD20", VA = "0xC3AD20")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform bone;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236A34", Offset = "0x236A34")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BoneMap boneMap;

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xC3CB84", Offset = "0xC3CB84", VA = "0xC3CB84", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xC3CC3C", Offset = "0xC3CC3C", VA = "0xC3CC3C")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xC3CCE0", Offset = "0xC3CCE0", VA = "0xC3CCE0")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xC3CD8C", Offset = "0xC3CD8C", VA = "0xC3CD8C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xC3CDB4", Offset = "0xC3CDB4", VA = "0xC3CDB4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xC3CDE0", Offset = "0xC3CDE0", VA = "0xC3CDE0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xC3CEB8", Offset = "0xC3CEB8", VA = "0xC3CEB8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xC3CEE0", Offset = "0xC3CEE0", VA = "0xC3CEE0")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x200013D")]
		public enum BoneMapType
		{
			[Token(Token = "0x40007BC")]
			Parent,
			[Token(Token = "0x40007BD")]
			Bone1,
			[Token(Token = "0x40007BE")]
			Bone2,
			[Token(Token = "0x40007BF")]
			Bone3
		}

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform parentBone;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform bone1;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone2;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform bone3;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236A4C", Offset = "0x236A4C")]
		public float maintainRotationWeight;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236A64", Offset = "0x236A64")]
		public float weight;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private BoneMap boneMap3;

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xC3CF20", Offset = "0xC3CF20", VA = "0xC3CF20", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xC3CFA0", Offset = "0xC3CFA0", VA = "0xC3CFA0")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xC3D090", Offset = "0xC3D090", VA = "0xC3D090")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xC3D4C0", Offset = "0xC3D4C0", VA = "0xC3D4C0")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xC3D600", Offset = "0xC3D600", VA = "0xC3D600")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xC3D764", Offset = "0xC3D764", VA = "0xC3D764")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xC3D778", Offset = "0xC3D778", VA = "0xC3D778")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xC3D87C", Offset = "0xC3D87C", VA = "0xC3D87C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xC3D990", Offset = "0xC3D990", VA = "0xC3D990", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xC3DD48", Offset = "0xC3DD48", VA = "0xC3DD48")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xC3DE48", Offset = "0xC3DE48", VA = "0xC3DE48")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform[] spineBones;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform leftThighBone;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform rightThighBone;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236A7C", Offset = "0x236A7C")]
		public int iterations;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236A98", Offset = "0x236A98")]
		public float twistWeight;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int rootNodeIndex;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private BoneMap[] spine;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool useFABRIK;

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xC3E0D4", Offset = "0xC3E0D4", VA = "0xC3E0D4", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xC3E4CC", Offset = "0xC3E4CC", VA = "0xC3E4CC")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xC3E630", Offset = "0xC3E630", VA = "0xC3E630")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xC3E7C4", Offset = "0xC3E7C4", VA = "0xC3E7C4")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xC3E7EC", Offset = "0xC3E7EC", VA = "0xC3E7EC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xC3E878", Offset = "0xC3E878", VA = "0xC3E878")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xC3E940", Offset = "0xC3E940", VA = "0xC3E940", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xC3F46C", Offset = "0xC3F46C", VA = "0xC3F46C")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xC3F4B0", Offset = "0xC3F4B0", VA = "0xC3F4B0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xC3F9C4", Offset = "0xC3F9C4", VA = "0xC3F9C4")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xC400FC", Offset = "0xC400FC", VA = "0xC400FC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xC40358", Offset = "0xC40358", VA = "0xC40358")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xC4058C", Offset = "0xC4058C", VA = "0xC4058C")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x200013E")]
		public class Point
		{
			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x239BDC", Offset = "0x239BDC")]
			public float weight;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 solverPosition;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion solverRotation;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0xC42C6C", Offset = "0xC42C6C", VA = "0xC42C6C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000A30")]
			[Address(RVA = "0xC42CF0", Offset = "0xC42CF0", VA = "0xC42CF0")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0xC42EC4", Offset = "0xC42EC4", VA = "0xC42EC4")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000A32")]
			[Address(RVA = "0xC42F0C", Offset = "0xC42F0C", VA = "0xC42F0C")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000A33")]
			[Address(RVA = "0xC42F54", Offset = "0xC42F54", VA = "0xC42F54")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000A34")]
			[Address(RVA = "0xC42FD8", Offset = "0xC42FD8", VA = "0xC42FD8")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0xC426A4", Offset = "0xC426A4", VA = "0xC426A4")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013F")]
		public class Bone : Point
		{
			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool isLimited;

			[Token(Token = "0x17000182")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000A36")]
				[Address(RVA = "0xC4192C", Offset = "0xC4192C", VA = "0xC4192C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A37")]
				[Address(RVA = "0xC41A58", Offset = "0xC41A58", VA = "0xC41A58")]
				set
				{
				}
			}

			[Token(Token = "0x6000A38")]
			[Address(RVA = "0xC41AEC", Offset = "0xC41AEC", VA = "0xC41AEC")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000A39")]
			[Address(RVA = "0xC41E28", Offset = "0xC41E28", VA = "0xC41E28")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0xC422E4", Offset = "0xC422E4", VA = "0xC422E4")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0xC42594", Offset = "0xC42594", VA = "0xC42594")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0xC425E0", Offset = "0xC425E0", VA = "0xC425E0")]
			public Bone()
			{
			}

			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0xC42758", Offset = "0xC42758", VA = "0xC42758")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0xC42824", Offset = "0xC42824", VA = "0xC42824")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000140")]
		public class Node : Point
		{
			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float effectorPositionWeight;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public float effectorRotationWeight;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 offset;

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0xC42C28", Offset = "0xC42C28", VA = "0xC42C28")]
			public Node()
			{
			}

			[Token(Token = "0x6000A40")]
			[Address(RVA = "0xC42C2C", Offset = "0xC42C2C", VA = "0xC42C2C")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000A41")]
			[Address(RVA = "0xC42C48", Offset = "0xC42C48", VA = "0xC42C48")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000141")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000142")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x236AB0", Offset = "0x236AB0")]
		public Vector3 IKPosition;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236AC0", Offset = "0x236AC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236AC0", Offset = "0x236AC0")]
		public float IKPositionWeight;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x236B3C", Offset = "0x236B3C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		protected bool firstInitiation;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x236B4C", Offset = "0x236B4C")]
		protected Transform root;

		[Token(Token = "0x17000084")]
		public bool initiated
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0xC40EE4", Offset = "0xC40EE4", VA = "0xC40EE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F2E0", Offset = "0x23F2E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0xC40EEC", Offset = "0xC40EEC", VA = "0xC40EEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F2F0", Offset = "0x23F2F0")]
			private set
			{
			}
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xC40B4C", Offset = "0xC40B4C", VA = "0xC40B4C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EF")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xC21B54", Offset = "0xC21B54", VA = "0xC21B54")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xC22530", Offset = "0xC22530", VA = "0xC22530")]
		public void Update()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xC40E20", Offset = "0xC40E20", VA = "0xC40E20", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xC40E34", Offset = "0xC40E34", VA = "0xC40E34")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xC40E40", Offset = "0xC40E40", VA = "0xC40E40")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xC40E48", Offset = "0xC40E48", VA = "0xC40E48")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xC40EDC", Offset = "0xC40EDC", VA = "0xC40EDC")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60004FA")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60004FB")]
		public abstract void FixTransforms();

		[Token(Token = "0x60004FC")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60004FD")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60004FE")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xC40EF4", Offset = "0xC40EF4", VA = "0xC40EF4")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xC40F0C", Offset = "0xC40F0C", VA = "0xC40F0C")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xC410A8", Offset = "0xC410A8", VA = "0xC410A8")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xC41170", Offset = "0xC41170", VA = "0xC41170")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xC41914", Offset = "0xC41914", VA = "0xC41914")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform transform;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 axis;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector3 poleAxis;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 polePosition;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236B7C", Offset = "0x236B7C")]
		public float poleWeight;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Transform poleTarget;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236B94", Offset = "0x236B94")]
		public float clampWeight;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236BAC", Offset = "0x236BAC")]
		public int clampSmoothing;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float step;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform lastTransform;

		[Token(Token = "0x17000085")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0xC43190", Offset = "0xC43190", VA = "0xC43190")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000086")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0xC43268", Offset = "0xC43268", VA = "0xC43268")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000087")]
		protected override int minBones
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0xC4454C", Offset = "0xC4454C", VA = "0xC4454C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000088")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0xC44D64", Offset = "0xC44D64", VA = "0xC44D64", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xC43094", Offset = "0xC43094", VA = "0xC43094")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xC43340", Offset = "0xC43340", VA = "0xC43340", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xC436C4", Offset = "0xC436C4", VA = "0xC436C4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xC44364", Offset = "0xC44364", VA = "0xC44364")]
		private void Solve()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xC43EA8", Offset = "0xC43EA8", VA = "0xC43EA8")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xC44554", Offset = "0xC44554", VA = "0xC44554")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xC44E70", Offset = "0xC44E70", VA = "0xC44E70")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236BC4", Offset = "0x236BC4")]
		public float IKRotationWeight;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Quaternion IKRotation;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Point chest;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Point shoulder;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Point upperArm;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Point forearm;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Point hand;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool isLeft;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3[] positions;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] rotations;

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xC44F44", Offset = "0xC44F44", VA = "0xC44F44", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xC45490", Offset = "0xC45490", VA = "0xC45490")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xC45540", Offset = "0xC45540", VA = "0xC45540", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xC45760", Offset = "0xC45760", VA = "0xC45760", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xC459A0", Offset = "0xC459A0", VA = "0xC459A0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xC45A20", Offset = "0xC45A20", VA = "0xC45A20", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xC45AAC", Offset = "0xC45AAC", VA = "0xC45AAC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xC461D0", Offset = "0xC461D0", VA = "0xC461D0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xC461F4", Offset = "0xC461F4", VA = "0xC461F4")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xC45B60", Offset = "0xC45B60", VA = "0xC45B60")]
		private void Read()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xC462AC", Offset = "0xC462AC", VA = "0xC462AC")]
		private void Write()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xC46610", Offset = "0xC46610", VA = "0xC46610")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xE0FB48", Offset = "0xE0FB48", VA = "0xE0FB48")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xE0FCA0", Offset = "0xE0FCA0", VA = "0xE0FCA0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xE106BC", Offset = "0xE106BC", VA = "0xE106BC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xE11130", Offset = "0xE11130", VA = "0xE11130")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xE11D70", Offset = "0xE11D70", VA = "0xE11D70")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007C")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool[] limitedBones;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000089")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0xE13B48", Offset = "0xE13B48", VA = "0xE13B48", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xE11DF8", Offset = "0xE11DF8", VA = "0xE11DF8")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xE12B0C", Offset = "0xE12B0C", VA = "0xE12B0C")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xE12C68", Offset = "0xE12C68", VA = "0xE12C68", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xE12D38", Offset = "0xE12D38", VA = "0xE12D38", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xE13688", Offset = "0xE13688", VA = "0xE13688", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xE13B50", Offset = "0xE13B50", VA = "0xE13B50")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xE11EC8", Offset = "0xE11EC8", VA = "0xE11EC8")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xE12C0C", Offset = "0xE12C0C", VA = "0xE12C0C")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xE13AB8", Offset = "0xE13AB8", VA = "0xE13AB8")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xE12728", Offset = "0xE12728", VA = "0xE12728")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xE14A40", Offset = "0xE14A40", VA = "0xE14A40")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xE14B84", Offset = "0xE14B84", VA = "0xE14B84")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xE14D28", Offset = "0xE14D28", VA = "0xE14D28")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xE14ECC", Offset = "0xE14ECC", VA = "0xE14ECC")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xE1325C", Offset = "0xE1325C", VA = "0xE1325C")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xE13470", Offset = "0xE13470", VA = "0xE13470")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xE151B4", Offset = "0xE151B4", VA = "0xE151B4")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xE140AC", Offset = "0xE140AC", VA = "0xE140AC")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xE12BDC", Offset = "0xE12BDC", VA = "0xE12BDC")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xE15F84", Offset = "0xE15F84", VA = "0xE15F84")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xE1540C", Offset = "0xE1540C", VA = "0xE1540C")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xE13C9C", Offset = "0xE13C9C", VA = "0xE13C9C")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xE13EAC", Offset = "0xE13EAC", VA = "0xE13EAC")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xE161BC", Offset = "0xE161BC", VA = "0xE161BC")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007D")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int iterations;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236BDC", Offset = "0x236BDC")]
		public float rootPin;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public FABRIKChain[] chains;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool zeroWeightApplied;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool[] isRoot;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xE16248", Offset = "0xE16248", VA = "0xE16248", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xE17444", Offset = "0xE17444", VA = "0xE17444", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xE1753C", Offset = "0xE1753C", VA = "0xE1753C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xE17648", Offset = "0xE17648", VA = "0xE17648", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xE177BC", Offset = "0xE177BC", VA = "0xE177BC")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xE17904", Offset = "0xE17904", VA = "0xE17904", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xE18150", Offset = "0xE18150", VA = "0xE18150", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xE18400", Offset = "0xE18400", VA = "0xE18400", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xE18234", Offset = "0xE18234", VA = "0xE18234")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xE17C9C", Offset = "0xE17C9C", VA = "0xE17C9C")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xE184D4", Offset = "0xE184D4", VA = "0xE184D4")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007E")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236BF4", Offset = "0x236BF4")]
		public int iterations;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public FBIKChain[] chain;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool FABRIKPass;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xE18550", Offset = "0xE18550", VA = "0xE18550")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xE18698", Offset = "0xE18698", VA = "0xE18698")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xE186F8", Offset = "0xE186F8", VA = "0xE186F8")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xE188C8", Offset = "0xE188C8", VA = "0xE188C8")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xE1895C", Offset = "0xE1895C", VA = "0xE1895C")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xE189F0", Offset = "0xE189F0", VA = "0xE189F0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xE18C70", Offset = "0xE18C70", VA = "0xE18C70", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xE18EC4", Offset = "0xE18EC4", VA = "0xE18EC4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xE191B8", Offset = "0xE191B8", VA = "0xE191B8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xE192FC", Offset = "0xE192FC", VA = "0xE192FC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xE1945C", Offset = "0xE1945C", VA = "0xE1945C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xE19670", Offset = "0xE19670", VA = "0xE19670", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xE19900", Offset = "0xE19900", VA = "0xE19900", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xE19D90", Offset = "0xE19D90", VA = "0xE19D90", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xE1A3F0", Offset = "0xE1A3F0", VA = "0xE1A3F0", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xE1A458", Offset = "0xE1A458", VA = "0xE1A458", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xE1A5CC", Offset = "0xE1A5CC", VA = "0xE1A5CC")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x400047D")]
		Body,
		[Token(Token = "0x400047E")]
		LeftShoulder,
		[Token(Token = "0x400047F")]
		RightShoulder,
		[Token(Token = "0x4000480")]
		LeftThigh,
		[Token(Token = "0x4000481")]
		RightThigh,
		[Token(Token = "0x4000482")]
		LeftHand,
		[Token(Token = "0x4000483")]
		RightHand,
		[Token(Token = "0x4000484")]
		LeftFoot,
		[Token(Token = "0x4000485")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000487")]
		LeftArm,
		[Token(Token = "0x4000488")]
		RightArm,
		[Token(Token = "0x4000489")]
		LeftLeg,
		[Token(Token = "0x400048A")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rootNode;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236C10", Offset = "0x236C10")]
		public float spineStiffness;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236C28", Offset = "0x236C28")]
		public float pullBodyVertical;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236C44", Offset = "0x236C44")]
		public float pullBodyHorizontal;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x236C60", Offset = "0x236C60")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 offset;

		[Token(Token = "0x1700008A")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000555")]
			[Address(RVA = "0xE1A6C8", Offset = "0xE1A6C8", VA = "0xE1A6C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0xE1A914", Offset = "0xE1A914", VA = "0xE1A914")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000557")]
			[Address(RVA = "0xE1A91C", Offset = "0xE1A91C", VA = "0xE1A91C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0xE1A924", Offset = "0xE1A924", VA = "0xE1A924")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0xE1A92C", Offset = "0xE1A92C", VA = "0xE1A92C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0xE1A934", Offset = "0xE1A934", VA = "0xE1A934")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0xE1A93C", Offset = "0xE1A93C", VA = "0xE1A93C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000091")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0xE1A944", Offset = "0xE1A944", VA = "0xE1A944")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000092")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0xE1A94C", Offset = "0xE1A94C", VA = "0xE1A94C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000093")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0xE1A954", Offset = "0xE1A954", VA = "0xE1A954")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0xE1A994", Offset = "0xE1A994", VA = "0xE1A994")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xE1A9D4", Offset = "0xE1A9D4", VA = "0xE1A9D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0xE1AA14", Offset = "0xE1AA14", VA = "0xE1AA14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0xE1AA54", Offset = "0xE1AA54", VA = "0xE1AA54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0xE1AA94", Offset = "0xE1AA94", VA = "0xE1AA94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0xE1AAD4", Offset = "0xE1AAD4", VA = "0xE1AAD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0xE1AB14", Offset = "0xE1AB14", VA = "0xE1AB14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0xE1AB54", Offset = "0xE1AB54", VA = "0xE1AB54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0xE1E224", Offset = "0xE1E224", VA = "0xE1E224")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F300", Offset = "0x23F300")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000577")]
			[Address(RVA = "0xE1E238", Offset = "0xE1E238", VA = "0xE1E238")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F310", Offset = "0x23F310")]
			private set
			{
			}
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xE1AB94", Offset = "0xE1AB94", VA = "0xE1AB94")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xE1AD18", Offset = "0xE1AD18", VA = "0xE1AD18")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xE1AC00", Offset = "0xE1AC00", VA = "0xE1AC00")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xE1AE1C", Offset = "0xE1AE1C", VA = "0xE1AE1C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xE1A6D0", Offset = "0xE1A6D0", VA = "0xE1A6D0")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xE1AF80", Offset = "0xE1AF80", VA = "0xE1AF80")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xE1B098", Offset = "0xE1B098", VA = "0xE1B098")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xE1B1B0", Offset = "0xE1B1B0", VA = "0xE1B1B0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xE1B2DC", Offset = "0xE1B2DC", VA = "0xE1B2DC")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xE1B2E4", Offset = "0xE1B2E4", VA = "0xE1B2E4")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xE1B324", Offset = "0xE1B324", VA = "0xE1B324")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xE1B450", Offset = "0xE1B450", VA = "0xE1B450", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xE1B788", Offset = "0xE1B788", VA = "0xE1B788")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xE1D818", Offset = "0xE1D818", VA = "0xE1D818")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xE1DEBC", Offset = "0xE1DEBC", VA = "0xE1DEBC")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xE1DF78", Offset = "0xE1DF78", VA = "0xE1DF78")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xE1DCB4", Offset = "0xE1DCB4", VA = "0xE1DCB4")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xE1DDB8", Offset = "0xE1DDB8", VA = "0xE1DDB8")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xE1E244", Offset = "0xE1E244", VA = "0xE1E244")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xE1E328", Offset = "0xE1E328", VA = "0xE1E328", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xE1E578", Offset = "0xE1E578", VA = "0xE1E578")]
		private void PullBody()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xE1E780", Offset = "0xE1E780", VA = "0xE1E780")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xE1E9A8", Offset = "0xE1E9A8", VA = "0xE1E9A8")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xE1ECA4", Offset = "0xE1ECA4", VA = "0xE1ECA4", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xE1F2A4", Offset = "0xE1F2A4", VA = "0xE1F2A4", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xE1F3F4", Offset = "0xE1F3F4", VA = "0xE1F3F4")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform target;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float tolerance;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int maxIterations;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useRotationLimits;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool XY;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Bone[] bones;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected float chainLength;

		[Token(Token = "0x1700009D")]
		protected virtual int minBones
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0xE1FF5C", Offset = "0xE1FF5C", VA = "0xE1FF5C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009E")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0xE1FF64", Offset = "0xE1FF64", VA = "0xE1FF64", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009F")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0xE1FF6C", Offset = "0xE1FF6C", VA = "0xE1FF6C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A0")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0xE1FF7C", Offset = "0xE1FF7C", VA = "0xE1FF7C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A1")]
		protected float positionOffset
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0xE1105C", Offset = "0xE1105C", VA = "0xE1105C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xE1F404", Offset = "0xE1F404", VA = "0xE1F404")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xE1F63C", Offset = "0xE1F63C", VA = "0xE1F63C")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xE1F818", Offset = "0xE1F818", VA = "0xE1F818", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xE1F8A8", Offset = "0xE1F8A8", VA = "0xE1F8A8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xE1F950", Offset = "0xE1F950", VA = "0xE1F950", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xE1FE0C", Offset = "0xE1FE0C", VA = "0xE1FE0C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xE1FE14", Offset = "0xE1FE14", VA = "0xE1FE14", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xE1FF74", Offset = "0xE1FF74", VA = "0xE1FF74", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xE1FF78", Offset = "0xE1FF78", VA = "0xE1FF78", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xE0FD60", Offset = "0xE0FD60", VA = "0xE0FD60")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xE10B04", Offset = "0xE10B04", VA = "0xE10B04")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xE20184", Offset = "0xE20184", VA = "0xE20184")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xE11D74", Offset = "0xE11D74", VA = "0xE11D74")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236C70", Offset = "0x236C70")]
		public float IKRotationWeight;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Quaternion IKRotation;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Point pelvis;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Point thigh;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Point calf;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Point foot;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Point toe;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 heelOffset;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3[] positions;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xE20560", Offset = "0xE20560", VA = "0xE20560", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xE20AAC", Offset = "0xE20AAC", VA = "0xE20AAC")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xE20B60", Offset = "0xE20B60", VA = "0xE20B60", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xE20D80", Offset = "0xE20D80", VA = "0xE20D80", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xE20FC0", Offset = "0xE20FC0", VA = "0xE20FC0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xE21050", Offset = "0xE21050", VA = "0xE21050", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xE210EC", Offset = "0xE210EC", VA = "0xE210EC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xE21810", Offset = "0xE21810", VA = "0xE21810", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xE21834", Offset = "0xE21834", VA = "0xE21834")]
		private void Solve()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xE211A0", Offset = "0xE211A0", VA = "0xE211A0")]
		private void Read()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xE219A8", Offset = "0xE219A8", VA = "0xE219A8")]
		private void Write()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xE21E44", Offset = "0xE21E44", VA = "0xE21E44")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x2000143")]
		public enum BendModifier
		{
			[Token(Token = "0x40007D0")]
			Animation,
			[Token(Token = "0x40007D1")]
			Target,
			[Token(Token = "0x40007D2")]
			Parent,
			[Token(Token = "0x40007D3")]
			Arm,
			[Token(Token = "0x40007D4")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000144")]
		public struct AxisDirection
		{
			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x2DF030", Offset = "0x2DF030", VA = "0x2DF030")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public AvatarIKGoal goal;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public BendModifier bendModifier;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236C88", Offset = "0x236C88")]
		public float maintainRotationWeight;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236CA0", Offset = "0x236CA0")]
		public float bendModifierWeight;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Transform bendGoal;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 animationNormal;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x170000A2")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xE23F88", Offset = "0xE23F88", VA = "0xE23F88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xE21FD8", Offset = "0xE21FD8", VA = "0xE21FD8")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xE22050", Offset = "0xE22050", VA = "0xE22050")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xE22180", Offset = "0xE22180", VA = "0xE22180", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xE22A44", Offset = "0xE22A44", VA = "0xE22A44", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xE23B94", Offset = "0xE23B94", VA = "0xE23B94", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xE23D1C", Offset = "0xE23D1C", VA = "0xE23D1C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xE23EF8", Offset = "0xE23EF8", VA = "0xE23EF8")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xE2265C", Offset = "0xE2265C", VA = "0xE2265C")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xE22BCC", Offset = "0xE22BCC", VA = "0xE22BCC")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000145")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x17000183")]
			public Vector3 forward
			{
				[Token(Token = "0x6000A4F")]
				[Address(RVA = "0xE26A3C", Offset = "0xE26A3C", VA = "0xE26A3C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0xE273E8", Offset = "0xE273E8", VA = "0xE273E8")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0xE257A4", Offset = "0xE257A4", VA = "0xE257A4")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0xE25D40", Offset = "0xE25D40", VA = "0xE25D40")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0xE27004", Offset = "0xE27004", VA = "0xE27004")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform target;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public LookAtBone[] spine;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public LookAtBone head;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236CB8", Offset = "0x236CB8")]
		public float bodyWeight;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236CD0", Offset = "0x236CD0")]
		public float headWeight;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236CE8", Offset = "0x236CE8")]
		public float eyesWeight;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236D00", Offset = "0x236D00")]
		public float clampWeight;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236D18", Offset = "0x236D18")]
		public float clampWeightHead;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236D30", Offset = "0x236D30")]
		public float clampWeightEyes;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236D48", Offset = "0x236D48")]
		public int clampSmoothing;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] spineForwards;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3[] headForwards;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] eyeForward;

		[Token(Token = "0x170000A3")]
		private bool spineIsValid
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xE24B58", Offset = "0xE24B58", VA = "0xE24B58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A4")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xE24E48", Offset = "0xE24E48", VA = "0xE24E48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A5")]
		private bool headIsValid
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xE24CC8", Offset = "0xE24CC8", VA = "0xE24CC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A6")]
		private bool headIsEmpty
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xE24E78", Offset = "0xE24E78", VA = "0xE24E78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A7")]
		private bool eyesIsValid
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xE24CD8", Offset = "0xE24CD8", VA = "0xE24CD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A8")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xE24F18", Offset = "0xE24F18", VA = "0xE24F18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xE24014", Offset = "0xE24014", VA = "0xE24014")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xE240A8", Offset = "0xE240A8", VA = "0xE240A8")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xE24158", Offset = "0xE24158", VA = "0xE24158")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xE24224", Offset = "0xE24224", VA = "0xE24224")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xE24318", Offset = "0xE24318", VA = "0xE24318")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xE24434", Offset = "0xE24434", VA = "0xE24434")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xE24588", Offset = "0xE24588", VA = "0xE24588", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xE2474C", Offset = "0xE2474C", VA = "0xE2474C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xE24928", Offset = "0xE24928", VA = "0xE24928", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xE24F48", Offset = "0xE24F48", VA = "0xE24F48", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xE252A8", Offset = "0xE252A8", VA = "0xE252A8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xE254B8", Offset = "0xE254B8", VA = "0xE254B8")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xE257C4", Offset = "0xE257C4", VA = "0xE257C4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xE25EAC", Offset = "0xE25EAC", VA = "0xE25EAC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xE25FEC", Offset = "0xE25FEC", VA = "0xE25FEC")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xE2633C", Offset = "0xE2633C", VA = "0xE2633C")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xE266C0", Offset = "0xE266C0", VA = "0xE266C0")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xE26B14", Offset = "0xE26B14", VA = "0xE26B14")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xE25568", Offset = "0xE25568", VA = "0xE25568")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xE271A0", Offset = "0xE271A0", VA = "0xE271A0")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000146")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000A50")]
			[Address(RVA = "0xE29178", Offset = "0xE29178", VA = "0xE29178")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0xE2A264", Offset = "0xE2A264", VA = "0xE2A264")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000A52")]
			[Address(RVA = "0xE220A8", Offset = "0xE220A8", VA = "0xE220A8")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A53")]
			[Address(RVA = "0xE2A370", Offset = "0xE2A370", VA = "0xE2A370")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform target;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236D60", Offset = "0x236D60")]
		public float IKRotationWeight;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 bendNormal;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected bool directHierarchy;

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xE273F0", Offset = "0xE273F0", VA = "0xE273F0")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xE27664", Offset = "0xE27664", VA = "0xE27664")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xE27890", Offset = "0xE27890", VA = "0xE27890")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xE278A0", Offset = "0xE278A0", VA = "0xE278A0")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xE27934", Offset = "0xE27934", VA = "0xE27934")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xE27944", Offset = "0xE27944", VA = "0xE27944")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xE2794C", Offset = "0xE2794C", VA = "0xE2794C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xE27AC4", Offset = "0xE27AC4", VA = "0xE27AC4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xE27C44", Offset = "0xE27C44", VA = "0xE27C44", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xE27CB4", Offset = "0xE27CB4", VA = "0xE27CB4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xE27D30", Offset = "0xE27D30", VA = "0xE27D30", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xE282AC", Offset = "0xE282AC", VA = "0xE282AC")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xE28328", Offset = "0xE28328", VA = "0xE28328")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xE28AB0", Offset = "0xE28AB0", VA = "0xE28AB0")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xE28D38", Offset = "0xE28D38", VA = "0xE28D38", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xE29000", Offset = "0xE29000", VA = "0xE29000")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xE28F00", Offset = "0xE28F00", VA = "0xE28F00")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xE29398", Offset = "0xE29398", VA = "0xE29398", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xE2A364", Offset = "0xE2A364", VA = "0xE2A364", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xE2A368", Offset = "0xE2A368", VA = "0xE2A368", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xE2A36C", Offset = "0xE2A36C", VA = "0xE2A36C", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xE29EA0", Offset = "0xE29EA0", VA = "0xE29EA0")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xE23DA4", Offset = "0xE23DA4", VA = "0xE23DA4")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000147")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000192")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000967")]
				YawPitch,
				[Token(Token = "0x4000968")]
				FromTo
			}

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239BF4", Offset = "0x239BF4")]
			public Transform target;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239C28", Offset = "0x239C28")]
			public Transform bendGoal;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239C5C", Offset = "0x239C5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x239C5C", Offset = "0x239C5C")]
			public float positionWeight;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239CAC", Offset = "0x239CAC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x239CAC", Offset = "0x239CAC")]
			public float rotationWeight;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239CFC", Offset = "0x239CFC")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239D5C", Offset = "0x239D5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x239D5C", Offset = "0x239D5C")]
			public float shoulderRotationWeight;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239DC4", Offset = "0x239DC4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x239DC4", Offset = "0x239DC4")]
			public float shoulderTwistWeight;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239E14", Offset = "0x239E14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x239E14", Offset = "0x239E14")]
			public float bendGoalWeight;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239E64", Offset = "0x239E64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x239E64", Offset = "0x239E64")]
			public float swivelOffset;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239EBC", Offset = "0x239EBC")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239EF0", Offset = "0x239EF0")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239F24", Offset = "0x239F24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x239F24", Offset = "0x239F24")]
			public float armLengthMlp;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x239F9C", Offset = "0x239F9C")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x239FD0", Offset = "0x239FD0")]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x239FE0", Offset = "0x239FE0")]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x239FF0", Offset = "0x239FF0")]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23A000", Offset = "0x23A000")]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23A010", Offset = "0x23A010")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23A020", Offset = "0x23A020")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private bool hasShoulder;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Quaternion chestRotation;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestForward;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Vector3 chestUp;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40007F4")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x40007F5")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000184")]
			public Vector3 position
			{
				[Token(Token = "0x6000A54")]
				[Address(RVA = "0xE32B68", Offset = "0xE32B68", VA = "0xE32B68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240338", Offset = "0x240338")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A55")]
				[Address(RVA = "0xE32B7C", Offset = "0xE32B7C", VA = "0xE32B7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240348", Offset = "0x240348")]
				private set
				{
				}
			}

			[Token(Token = "0x17000185")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000A56")]
				[Address(RVA = "0xE32B88", Offset = "0xE32B88", VA = "0xE32B88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240358", Offset = "0x240358")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000A57")]
				[Address(RVA = "0xE32B98", Offset = "0xE32B98", VA = "0xE32B98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240368", Offset = "0x240368")]
				private set
				{
				}
			}

			[Token(Token = "0x17000186")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000A58")]
				[Address(RVA = "0xE32BA8", Offset = "0xE32BA8", VA = "0xE32BA8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000187")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000A59")]
				[Address(RVA = "0xE32BE8", Offset = "0xE32BE8", VA = "0xE32BE8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000188")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000A5A")]
				[Address(RVA = "0xE32C30", Offset = "0xE32C30", VA = "0xE32C30")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000189")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000A5B")]
				[Address(RVA = "0xE32C84", Offset = "0xE32C84", VA = "0xE32C84")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0xE32CD8", Offset = "0xE32CD8", VA = "0xE32CD8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0xE339B0", Offset = "0xE339B0", VA = "0xE339B0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0xE33CAC", Offset = "0xE33CAC", VA = "0xE33CAC", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0xE33D64", Offset = "0xE33D64", VA = "0xE33D64")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000A60")]
			[Address(RVA = "0xE2FF9C", Offset = "0xE2FF9C", VA = "0xE2FF9C")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0xE34E88", Offset = "0xE34E88", VA = "0xE34E88", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000A62")]
			[Address(RVA = "0xE34F20", Offset = "0xE34F20", VA = "0xE34F20", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000A63")]
			[Address(RVA = "0xE343A4", Offset = "0xE343A4", VA = "0xE343A4")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000A64")]
			[Address(RVA = "0xE344A4", Offset = "0xE344A4", VA = "0xE344A4")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A65")]
			[Address(RVA = "0xE352CC", Offset = "0xE352CC", VA = "0xE352CC")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000A66")]
			[Address(RVA = "0xE329D0", Offset = "0xE329D0", VA = "0xE329D0")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000148")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23A030", Offset = "0x23A030")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23A040", Offset = "0x23A040")]
			private float <mag>k__BackingField;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23A050", Offset = "0x23A050")]
			public VirtualBone[] bones;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			protected bool initiated;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			protected int index;

			[Token(Token = "0x1700018A")]
			public float sqrMag
			{
				[Token(Token = "0x6000A6C")]
				[Address(RVA = "0xE35524", Offset = "0xE35524", VA = "0xE35524")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240378", Offset = "0x240378")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A6D")]
				[Address(RVA = "0xE3552C", Offset = "0xE3552C", VA = "0xE3552C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240388", Offset = "0x240388")]
				private set
				{
				}
			}

			[Token(Token = "0x1700018B")]
			public float mag
			{
				[Token(Token = "0x6000A6E")]
				[Address(RVA = "0xE35534", Offset = "0xE35534", VA = "0xE35534")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240398", Offset = "0x240398")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A6F")]
				[Address(RVA = "0xE3553C", Offset = "0xE3553C", VA = "0xE3553C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2403A8", Offset = "0x2403A8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A67")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000A68")]
			public abstract void PreSolve();

			[Token(Token = "0x6000A69")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000A6A")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x6000A6B")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000A70")]
			[Address(RVA = "0xE21D0C", Offset = "0xE21D0C", VA = "0xE21D0C")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000A71")]
			[Address(RVA = "0xE35544", Offset = "0xE35544", VA = "0xE35544")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000A72")]
			[Address(RVA = "0xE35738", Offset = "0xE35738", VA = "0xE35738")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A73")]
			[Address(RVA = "0xE35848", Offset = "0xE35848", VA = "0xE35848")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A74")]
			[Address(RVA = "0xE2FD48", Offset = "0xE2FD48", VA = "0xE2FD48")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000A75")]
			[Address(RVA = "0xE34C28", Offset = "0xE34C28", VA = "0xE34C28")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000A76")]
			[Address(RVA = "0xE3587C", Offset = "0xE3587C", VA = "0xE3587C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000A77")]
			[Address(RVA = "0xE35A30", Offset = "0xE35A30", VA = "0xE35A30")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000A78")]
			[Address(RVA = "0xE35454", Offset = "0xE35454", VA = "0xE35454")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000149")]
		public class Footstep
		{
			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float stepSpeed;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 position;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion rotation;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool isSupportLeg;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23A060", Offset = "0x23A060")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 stepTo;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private float supportLegW;

			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private float supportLegWV;

			[Token(Token = "0x1700018C")]
			public bool isStepping
			{
				[Token(Token = "0x6000A79")]
				[Address(RVA = "0xE35A6C", Offset = "0xE35A6C", VA = "0xE35A6C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700018D")]
			public float stepProgress
			{
				[Token(Token = "0x6000A7A")]
				[Address(RVA = "0xE35A88", Offset = "0xE35A88", VA = "0xE35A88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2403B8", Offset = "0x2403B8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A7B")]
				[Address(RVA = "0xE35A90", Offset = "0xE35A90", VA = "0xE35A90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2403C8", Offset = "0x2403C8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0xE35A98", Offset = "0xE35A98", VA = "0xE35A98")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0xE35C98", Offset = "0xE35C98", VA = "0xE35C98")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000A7E")]
			[Address(RVA = "0xE35D18", Offset = "0xE35D18", VA = "0xE35D18")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0xE35E68", Offset = "0xE35E68", VA = "0xE35E68")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000A80")]
			[Address(RVA = "0xE36078", Offset = "0xE36078", VA = "0xE36078")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000A81")]
			[Address(RVA = "0xE3629C", Offset = "0xE3629C", VA = "0xE3629C")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200014A")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A070", Offset = "0x23A070")]
			public Transform target;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A0B4", Offset = "0x23A0B4")]
			public Transform bendGoal;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A0E8", Offset = "0x23A0E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23A0E8", Offset = "0x23A0E8")]
			public float positionWeight;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A15C", Offset = "0x23A15C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23A15C", Offset = "0x23A15C")]
			public float rotationWeight;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A1D0", Offset = "0x23A1D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23A1D0", Offset = "0x23A1D0")]
			public float bendGoalWeight;

			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A220", Offset = "0x23A220")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23A220", Offset = "0x23A220")]
			public float swivelOffset;

			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A278", Offset = "0x23A278")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23A278", Offset = "0x23A278")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A2C8", Offset = "0x23A2C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23A2C8", Offset = "0x23A2C8")]
			public float legLengthMlp;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A340", Offset = "0x23A340")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23A374", Offset = "0x23A374")]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23A384", Offset = "0x23A384")]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23A394", Offset = "0x23A394")]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23A3A4", Offset = "0x23A3A4")]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23A3B4", Offset = "0x23A3B4")]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23A3C4", Offset = "0x23A3C4")]
			public float currentMag;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23A3D4", Offset = "0x23A3D4")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23A3E4", Offset = "0x23A3E4")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23A3F4", Offset = "0x23A3F4")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23A404", Offset = "0x23A404")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private Vector3 footPosition;

			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion footRotation;

			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 bendNormal;

			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x1700018E")]
			public Vector3 position
			{
				[Token(Token = "0x6000A82")]
				[Address(RVA = "0xB5DB78", Offset = "0xB5DB78", VA = "0xB5DB78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2403D8", Offset = "0x2403D8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A83")]
				[Address(RVA = "0xB5DB8C", Offset = "0xB5DB8C", VA = "0xB5DB8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2403E8", Offset = "0x2403E8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700018F")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000A84")]
				[Address(RVA = "0xB5DB98", Offset = "0xB5DB98", VA = "0xB5DB98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2403F8", Offset = "0x2403F8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000A85")]
				[Address(RVA = "0xB5DBA8", Offset = "0xB5DBA8", VA = "0xB5DBA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240408", Offset = "0x240408")]
				private set
				{
				}
			}

			[Token(Token = "0x17000190")]
			public bool hasToes
			{
				[Token(Token = "0x6000A86")]
				[Address(RVA = "0xB5DBB8", Offset = "0xB5DBB8", VA = "0xB5DBB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240418", Offset = "0x240418")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000A87")]
				[Address(RVA = "0xB5DBC0", Offset = "0xB5DBC0", VA = "0xB5DBC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240428", Offset = "0x240428")]
				private set
				{
				}
			}

			[Token(Token = "0x17000191")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000A88")]
				[Address(RVA = "0xB5DBC8", Offset = "0xB5DBC8", VA = "0xB5DBC8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000192")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000A89")]
				[Address(RVA = "0xB5DC08", Offset = "0xB5DC08", VA = "0xB5DC08")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000193")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000A8A")]
				[Address(RVA = "0xB5DC48", Offset = "0xB5DC48", VA = "0xB5DC48")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000194")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000A8B")]
				[Address(RVA = "0xB5DC88", Offset = "0xB5DC88", VA = "0xB5DC88")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000195")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000A8C")]
				[Address(RVA = "0xB5DCC8", Offset = "0xB5DCC8", VA = "0xB5DCC8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000196")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000A8D")]
				[Address(RVA = "0xB5DD18", Offset = "0xB5DD18", VA = "0xB5DD18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240438", Offset = "0x240438")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A8E")]
				[Address(RVA = "0xB5DD2C", Offset = "0xB5DD2C", VA = "0xB5DD2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240448", Offset = "0x240448")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0xB5DD38", Offset = "0xB5DD38", VA = "0xB5DD38", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000A90")]
			[Address(RVA = "0xB5E7DC", Offset = "0xB5E7DC", VA = "0xB5E7DC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000A91")]
			[Address(RVA = "0xB5F2B8", Offset = "0xB5F2B8", VA = "0xB5F2B8", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000A92")]
			[Address(RVA = "0xB5F188", Offset = "0xB5F188", VA = "0xB5F188")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000A93")]
			[Address(RVA = "0xB5EEAC", Offset = "0xB5EEAC", VA = "0xB5EEAC")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000A94")]
			[Address(RVA = "0xB5FA80", Offset = "0xB5FA80", VA = "0xB5FA80")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000A95")]
			[Address(RVA = "0xB602B4", Offset = "0xB602B4", VA = "0xB602B4")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000A96")]
			[Address(RVA = "0xB6132C", Offset = "0xB6132C", VA = "0xB6132C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000A97")]
			[Address(RVA = "0xB616DC", Offset = "0xB616DC", VA = "0xB616DC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000A98")]
			[Address(RVA = "0xB617DC", Offset = "0xB617DC", VA = "0xB617DC")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200014B")]
		public class Locomotion
		{
			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A414", Offset = "0x23A414")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23A414", Offset = "0x23A414")]
			public float weight;

			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A464", Offset = "0x23A464")]
			public float footDistance;

			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A498", Offset = "0x23A498")]
			public float stepThreshold;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A4CC", Offset = "0x23A4CC")]
			public float angleThreshold;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A500", Offset = "0x23A500")]
			public float comAngleMlp;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A534", Offset = "0x23A534")]
			public float maxVelocity;

			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A568", Offset = "0x23A568")]
			public float velocityFactor;

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A59C", Offset = "0x23A59C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23A59C", Offset = "0x23A59C")]
			public float maxLegStretch;

			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A5F0", Offset = "0x23A5F0")]
			public float rootSpeed;

			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A624", Offset = "0x23A624")]
			public float stepSpeed;

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A658", Offset = "0x23A658")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A68C", Offset = "0x23A68C")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A6C0", Offset = "0x23A6C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23A6C0", Offset = "0x23A6C0")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A714", Offset = "0x23A714")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A748", Offset = "0x23A748")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A77C", Offset = "0x23A77C")]
			public Vector3 offset;

			[Token(Token = "0x4000835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23A7B0", Offset = "0x23A7B0")]
			public bool blockingEnabled;

			[Token(Token = "0x4000836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23A7C0", Offset = "0x23A7C0")]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23A7D0", Offset = "0x23A7D0")]
			public float raycastRadius;

			[Token(Token = "0x4000838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23A7E0", Offset = "0x23A7E0")]
			public float raycastHeight;

			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A7F0", Offset = "0x23A7F0")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A824", Offset = "0x23A824")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23A858", Offset = "0x23A858")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Footstep[] footsteps;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Vector3 lastComPosition;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 comVelocity;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private int leftFootIndex;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private int rightFootIndex;

			[Token(Token = "0x17000197")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000A99")]
				[Address(RVA = "0xB6192C", Offset = "0xB6192C", VA = "0xB6192C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240458", Offset = "0x240458")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A9A")]
				[Address(RVA = "0xB61940", Offset = "0xB61940", VA = "0xB61940")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240468", Offset = "0x240468")]
				private set
				{
				}
			}

			[Token(Token = "0x17000198")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000AA0")]
				[Address(RVA = "0xB651DC", Offset = "0xB651DC", VA = "0xB651DC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000199")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000AA1")]
				[Address(RVA = "0xB65240", Offset = "0xB65240", VA = "0xB65240")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700019A")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000AA2")]
				[Address(RVA = "0xB652A4", Offset = "0xB652A4", VA = "0xB652A4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x1700019B")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000AA3")]
				[Address(RVA = "0xB65304", Offset = "0xB65304", VA = "0xB65304")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0xB6194C", Offset = "0xB6194C", VA = "0xB6194C")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0xB61DC8", Offset = "0xB61DC8", VA = "0xB61DC8")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0xB62248", Offset = "0xB62248", VA = "0xB62248")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0xB62770", Offset = "0xB62770", VA = "0xB62770")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0xB629AC", Offset = "0xB629AC", VA = "0xB629AC")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0xB64D24", Offset = "0xB64D24", VA = "0xB64D24")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0xB64EFC", Offset = "0xB64EFC", VA = "0xB64EFC")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0xB64FB4", Offset = "0xB64FB4", VA = "0xB64FB4")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0xB65368", Offset = "0xB65368", VA = "0xB65368")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200014C")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A868", Offset = "0x23A868")]
			public Transform headTarget;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A89C", Offset = "0x23A89C")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A8F4", Offset = "0x23A8F4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23A8F4", Offset = "0x23A8F4")]
			public float positionWeight;

			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A944", Offset = "0x23A944")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23A944", Offset = "0x23A944")]
			public float rotationWeight;

			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23A994", Offset = "0x23A994")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23A994", Offset = "0x23A994")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23AA04", Offset = "0x23AA04")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23AA04", Offset = "0x23AA04")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23AA74", Offset = "0x23AA74")]
			public Transform chestGoal;

			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23AAA8", Offset = "0x23AAA8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23AAA8", Offset = "0x23AAA8")]
			public float chestGoalWeight;

			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23AB18", Offset = "0x23AB18")]
			public float minHeadHeight;

			[Token(Token = "0x400084A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23AB80", Offset = "0x23AB80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23AB80", Offset = "0x23AB80")]
			public float bodyPosStiffness;

			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23ABD0", Offset = "0x23ABD0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23ABD0", Offset = "0x23ABD0")]
			public float bodyRotStiffness;

			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23AC20", Offset = "0x23AC20")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x23AC20", Offset = "0x23AC20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23AC20", Offset = "0x23AC20")]
			public float neckStiffness;

			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23ACA4", Offset = "0x23ACA4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23ACA4", Offset = "0x23ACA4")]
			public float rotateChestByHands;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23ACF4", Offset = "0x23ACF4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23ACF4", Offset = "0x23ACF4")]
			public float chestClampWeight;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23AD54", Offset = "0x23AD54")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23AD54", Offset = "0x23AD54")]
			public float headClampWeight;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23ADB4", Offset = "0x23ADB4")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23ADE8", Offset = "0x23ADE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23ADE8", Offset = "0x23ADE8")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23AE6C", Offset = "0x23AE6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23AE6C", Offset = "0x23AE6C")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23AEC0", Offset = "0x23AEC0")]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23AED0", Offset = "0x23AED0")]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23AEE0", Offset = "0x23AEE0")]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23AEF0", Offset = "0x23AEF0")]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23AF00", Offset = "0x23AF00")]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23AF10", Offset = "0x23AF10")]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23AF20", Offset = "0x23AF20")]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400085A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23AF30", Offset = "0x23AF30")]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400085B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23AF40", Offset = "0x23AF40")]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400085C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23AF50", Offset = "0x23AF50")]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400085D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23AF60", Offset = "0x23AF60")]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400085E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23AF70", Offset = "0x23AF70")]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x400085F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23AF80", Offset = "0x23AF80")]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23AF90", Offset = "0x23AF90")]
			public Vector3 headPosition;

			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23AFA0", Offset = "0x23AFA0")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			private Quaternion headRotation;

			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private int pelvisIndex;

			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			private int spineIndex;

			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private int chestIndex;

			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private int neckIndex;

			[Token(Token = "0x400086F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private int headIndex;

			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
			private float length;

			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private bool hasChest;

			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F1")]
			private bool hasNeck;

			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F2")]
			private bool hasLegs;

			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private float headHeight;

			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private float sizeMlp;

			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private Vector3 chestForward;

			[Token(Token = "0x1700019C")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000AA8")]
				[Address(RVA = "0xB64C94", Offset = "0xB64C94", VA = "0xB64C94")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700019D")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000AA9")]
				[Address(RVA = "0xB65494", Offset = "0xB65494", VA = "0xB65494")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700019E")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000AAA")]
				[Address(RVA = "0xB654DC", Offset = "0xB654DC", VA = "0xB654DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700019F")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000AAB")]
				[Address(RVA = "0xB65530", Offset = "0xB65530", VA = "0xB65530")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A0")]
			public VirtualBone head
			{
				[Token(Token = "0x6000AAC")]
				[Address(RVA = "0xB64CDC", Offset = "0xB64CDC", VA = "0xB64CDC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A1")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000AAD")]
				[Address(RVA = "0xB65578", Offset = "0xB65578", VA = "0xB65578")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240478", Offset = "0x240478")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000AAE")]
				[Address(RVA = "0xB65588", Offset = "0xB65588", VA = "0xB65588")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240488", Offset = "0x240488")]
				private set
				{
				}
			}

			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0xB65598", Offset = "0xB65598", VA = "0xB65598", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0xB66700", Offset = "0xB66700", VA = "0xB66700", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0xB66A60", Offset = "0xB66A60", VA = "0xB66A60", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0xB671C4", Offset = "0xB671C4", VA = "0xB671C4")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0xB678DC", Offset = "0xB678DC", VA = "0xB678DC")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0xB68590", Offset = "0xB68590", VA = "0xB68590")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0xB6909C", Offset = "0xB6909C", VA = "0xB6909C")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0xB69CC4", Offset = "0xB69CC4", VA = "0xB69CC4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0xB6A08C", Offset = "0xB6A08C", VA = "0xB6A08C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0xB67420", Offset = "0xB67420", VA = "0xB67420")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0xB68B94", Offset = "0xB68B94", VA = "0xB68B94")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0xB68068", Offset = "0xB68068", VA = "0xB68068")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0xB6A1E4", Offset = "0xB6A1E4", VA = "0xB6A1E4")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0xB68D78", Offset = "0xB68D78", VA = "0xB68D78")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0xB68818", Offset = "0xB68818", VA = "0xB68818")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0xB6A988", Offset = "0xB6A988", VA = "0xB6A988")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200014D")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000878")]
			Pelvis,
			[Token(Token = "0x4000879")]
			Chest,
			[Token(Token = "0x400087A")]
			Head,
			[Token(Token = "0x400087B")]
			LeftHand,
			[Token(Token = "0x400087C")]
			RightHand,
			[Token(Token = "0x400087D")]
			LeftFoot,
			[Token(Token = "0x400087E")]
			RightFoot,
			[Token(Token = "0x400087F")]
			LeftHeel,
			[Token(Token = "0x4000880")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x200014E")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000882")]
			Pelvis,
			[Token(Token = "0x4000883")]
			Chest,
			[Token(Token = "0x4000884")]
			Head
		}

		[Serializable]
		[Token(Token = "0x200014F")]
		public class VirtualBone
		{
			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 readPosition;

			[Token(Token = "0x4000886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Quaternion readRotation;

			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float length;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float sqrMag;

			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 axis;

			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0xB5E720", Offset = "0xB5E720", VA = "0xB5E720")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0xB5E788", Offset = "0xB5E788", VA = "0xB5E788")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0xB6AC08", Offset = "0xB6AC08", VA = "0xB6AC08")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0xB6B014", Offset = "0xB6B014", VA = "0xB6B014")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0xB6A6B8", Offset = "0xB6A6B8", VA = "0xB6A6B8")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0xB6B5FC", Offset = "0xB6B5FC", VA = "0xB6B5FC")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0xB6B970", Offset = "0xB6B970", VA = "0xB6B970")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0xB6BD20", Offset = "0xB6BD20", VA = "0xB6BD20")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0xB60A74", Offset = "0xB60A74", VA = "0xB60A74")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0xB6BE18", Offset = "0xB6BE18", VA = "0xB6BE18")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0xB69534", Offset = "0xB69534", VA = "0xB69534")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0xB6C0A0", Offset = "0xB6C0A0", VA = "0xB6C0A0")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000ACB")]
			[Address(RVA = "0xB6C1E0", Offset = "0xB6C1E0", VA = "0xB6C1E0")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool hasChest;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool hasNeck;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool hasShoulders;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		private bool hasToes;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool hasLegs;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3[] readPositions;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 rootV;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int supportLegIndex;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236D78", Offset = "0x236D78")]
		public bool plantFeet;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x236DAC", Offset = "0x236DAC")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236DBC", Offset = "0x236DBC")]
		public Spine spine;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236DF0", Offset = "0x236DF0")]
		public Arm leftArm;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236E24", Offset = "0x236E24")]
		public Arm rightArm;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236E58", Offset = "0x236E58")]
		public Leg leftLeg;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236E8C", Offset = "0x236E8C")]
		public Leg rightLeg;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236EC0", Offset = "0x236EC0")]
		public Locomotion locomotion;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Leg[] legs;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Arm[] arms;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 headPosition;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Vector3 lastOffset;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 debugPos1;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 debugPos2;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 debugPos3;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private Vector3 debugPos4;

		[Token(Token = "0x170000A9")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x240788", Offset = "0x240788")]
		public VirtualBone rootBone
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xE327DC", Offset = "0xE327DC", VA = "0xE327DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F320", Offset = "0x23F320")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0xE327E4", Offset = "0xE327E4", VA = "0xE327E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F330", Offset = "0x23F330")]
			private set
			{
			}
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xE2A378", Offset = "0xE2A378", VA = "0xE2A378")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xE2A9E4", Offset = "0xE2A9E4", VA = "0xE2A9E4")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xE2A7B0", Offset = "0xE2A7B0", VA = "0xE2A7B0")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xE2B7A4", Offset = "0xE2B7A4", VA = "0xE2B7A4")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xE2BBCC", Offset = "0xE2BBCC", VA = "0xE2BBCC")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xE2BC98", Offset = "0xE2BC98", VA = "0xE2BC98")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xE2BE78", Offset = "0xE2BE78", VA = "0xE2BE78")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xE2C050", Offset = "0xE2C050", VA = "0xE2C050")]
		public void Reset()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xE2CC74", Offset = "0xE2CC74", VA = "0xE2CC74", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xE2CF00", Offset = "0xE2CF00", VA = "0xE2CF00", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xE2D198", Offset = "0xE2D198", VA = "0xE2D198", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xE2D228", Offset = "0xE2D228", VA = "0xE2D228", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xE2D2B8", Offset = "0xE2D2B8", VA = "0xE2D2B8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xE2D59C", Offset = "0xE2D59C", VA = "0xE2D59C")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xE2AE54", Offset = "0xE2AE54", VA = "0xE2AE54")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xE2B088", Offset = "0xE2B088", VA = "0xE2B088")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xE2B614", Offset = "0xE2B614", VA = "0xE2B614")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xE2C23C", Offset = "0xE2C23C", VA = "0xE2C23C")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xE2D974", Offset = "0xE2D974", VA = "0xE2D974", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xE2D9BC", Offset = "0xE2D9BC", VA = "0xE2D9BC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xE2F86C", Offset = "0xE2F86C", VA = "0xE2F86C")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xE2C4B0", Offset = "0xE2C4B0", VA = "0xE2C4B0")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xE2DA34", Offset = "0xE2DA34", VA = "0xE2DA34")]
		private void Solve()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xE2FC98", Offset = "0xE2FC98", VA = "0xE2FC98")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xE2FCF4", Offset = "0xE2FCF4", VA = "0xE2FCF4")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xE2F654", Offset = "0xE2F654", VA = "0xE2F654")]
		private void Write()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xE31ECC", Offset = "0xE31ECC", VA = "0xE31ECC")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xE327EC", Offset = "0xE327EC", VA = "0xE327EC")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public IK ik;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236EF4", Offset = "0x236EF4")]
		public Transform parent;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236F28", Offset = "0x236F28")]
		public Transform child;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236F5C", Offset = "0x236F5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236F5C", Offset = "0x236F5C")]
		public float weight;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x236FD8", Offset = "0x236FD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x236FD8", Offset = "0x236FD8")]
		public float parentChildCrossfade;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237028", Offset = "0x237028")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x237028", Offset = "0x237028")]
		public float twistAngleOffset;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 twistAxis;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 axis;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xE68F68", Offset = "0xE68F68", VA = "0xE68F68")]
		public void Relax()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xE694CC", Offset = "0xE694CC", VA = "0xE694CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xE69AE0", Offset = "0xE69AE0", VA = "0xE69AE0")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xE69B7C", Offset = "0xE69B7C", VA = "0xE69B7C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xE69C18", Offset = "0xE69C18", VA = "0xE69C18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xE69D7C", Offset = "0xE69D7C", VA = "0xE69D7C")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000089")]
	public class InteractionEffector
	{
		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2370A0", Offset = "0x2370A0")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2370B0", Offset = "0x2370B0")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2370C0", Offset = "0x2370C0")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Poser poser;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IKEffector effector;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float timer;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float length;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float weight;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float fadeInSpeed;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float defaultPull;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float defaultReach;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float defaultPush;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPushParent;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float resetTimer;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool positionWeightUsed;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool rotationWeightUsed;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		private bool pullUsed;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		private bool reachUsed;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool pushUsed;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		private bool pushParentUsed;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		private bool pickedUp;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		private bool defaults;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform target;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private List<bool> triggered;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool started;

		[Token(Token = "0x170000AA")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000600")]
			[Address(RVA = "0xB6CE2C", Offset = "0xB6CE2C", VA = "0xB6CE2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F340", Offset = "0x23F340")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000601")]
			[Address(RVA = "0xB6CE34", Offset = "0xB6CE34", VA = "0xB6CE34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F350", Offset = "0x23F350")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public bool isPaused
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0xB6CE3C", Offset = "0xB6CE3C", VA = "0xB6CE3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F360", Offset = "0x23F360")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000603")]
			[Address(RVA = "0xB6CE44", Offset = "0xB6CE44", VA = "0xB6CE44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F370", Offset = "0x23F370")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0xB6CE4C", Offset = "0xB6CE4C", VA = "0xB6CE4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F380", Offset = "0x23F380")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000605")]
			[Address(RVA = "0xB6CE54", Offset = "0xB6CE54", VA = "0xB6CE54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F390", Offset = "0x23F390")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public bool inInteraction
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0xB6CE5C", Offset = "0xB6CE5C", VA = "0xB6CE5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AE")]
		public float progress
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0xB70EE4", Offset = "0xB70EE4", VA = "0xB70EE4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xB6CEE8", Offset = "0xB6CEE8", VA = "0xB6CEE8")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xB6CF7C", Offset = "0xB6CF7C", VA = "0xB6CF7C")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xB6D078", Offset = "0xB6D078", VA = "0xB6D078")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xB6D310", Offset = "0xB6D310", VA = "0xB6D310")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xB6D9C4", Offset = "0xB6D9C4", VA = "0xB6D9C4")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xB6DE4C", Offset = "0xB6DE4C", VA = "0xB6DE4C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xB6DEDC", Offset = "0xB6DEDC", VA = "0xB6DEDC")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xB6EE9C", Offset = "0xB6EE9C", VA = "0xB6EE9C")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xB700CC", Offset = "0xB700CC", VA = "0xB700CC")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xB7062C", Offset = "0xB7062C", VA = "0xB7062C")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xB70CEC", Offset = "0xB70CEC", VA = "0xB70CEC")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xB7142C", Offset = "0xB7142C", VA = "0xB7142C")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008A")]
	public class InteractionLookAt
	{
		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2370D0", Offset = "0x2370D0")]
		public LookAtIK ik;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237104", Offset = "0x237104")]
		public float lerpSpeed;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23715C", Offset = "0x23715C")]
		public float weightSpeed;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x2371B4", Offset = "0x2371B4")]
		public bool isPaused;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float stopLookTime;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float weight;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xB71814", Offset = "0xB71814", VA = "0xB71814")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xB71A48", Offset = "0xB71A48", VA = "0xB71A48")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xB71B3C", Offset = "0xB71B3C", VA = "0xB71B3C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xB71E94", Offset = "0xB71E94", VA = "0xB71E94")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xB72078", Offset = "0xB72078", VA = "0xB72078")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xB721DC", Offset = "0xB721DC", VA = "0xB721DC")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x231A48", Offset = "0x231A48")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x231A48", Offset = "0x231A48")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000150")]
		public class InteractionEvent
		{
			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23AFB0", Offset = "0x23AFB0")]
			public float time;

			[Token(Token = "0x400088D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B00C", Offset = "0x23B00C")]
			public bool pause;

			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B040", Offset = "0x23B040")]
			public bool pickUp;

			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B074", Offset = "0x23B074")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B0C8", Offset = "0x23B0C8")]
			public Message[] messages;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B134", Offset = "0x23B134")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0xB70F24", Offset = "0xB70F24", VA = "0xB70F24")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0xB73C8C", Offset = "0xB73C8C", VA = "0xB73C8C")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000151")]
		public class Message
		{
			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B168", Offset = "0x23B168")]
			public string function;

			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B1B8", Offset = "0x23B1B8")]
			public GameObject recipient;

			[Token(Token = "0x4000894")]
			private const string empty = "";

			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0xB73B68", Offset = "0xB73B68", VA = "0xB73B68")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0xB73C94", Offset = "0xB73C94", VA = "0xB73C94")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000152")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B200", Offset = "0x23B200")]
			public Animator animator;

			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B26C", Offset = "0x23B26C")]
			public Animation animation;

			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B2A0", Offset = "0x23B2A0")]
			public string animationState;

			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B2F0", Offset = "0x23B2F0")]
			public float crossfadeTime;

			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B334", Offset = "0x23B334")]
			public int layer;

			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B368", Offset = "0x23B368")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400089B")]
			private const string empty = "";

			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0xB73800", Offset = "0xB73800", VA = "0xB73800")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0xB73924", Offset = "0xB73924", VA = "0xB73924")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0xB73A08", Offset = "0xB73A08", VA = "0xB73A08")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0xB73B54", Offset = "0xB73B54", VA = "0xB73B54")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000153")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000193")]
			public enum Type
			{
				[Token(Token = "0x400096A")]
				PositionWeight,
				[Token(Token = "0x400096B")]
				RotationWeight,
				[Token(Token = "0x400096C")]
				PositionOffsetX,
				[Token(Token = "0x400096D")]
				PositionOffsetY,
				[Token(Token = "0x400096E")]
				PositionOffsetZ,
				[Token(Token = "0x400096F")]
				Pull,
				[Token(Token = "0x4000970")]
				Reach,
				[Token(Token = "0x4000971")]
				RotateBoneWeight,
				[Token(Token = "0x4000972")]
				Push,
				[Token(Token = "0x4000973")]
				PushParent,
				[Token(Token = "0x4000974")]
				PoserWeight
			}

			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B3D0", Offset = "0x23B3D0")]
			public Type type;

			[Token(Token = "0x400089D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B438", Offset = "0x23B438")]
			public AnimationCurve curve;

			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0xB72C20", Offset = "0xB72C20", VA = "0xB72C20")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0xB73CAC", Offset = "0xB73CAC", VA = "0xB73CAC")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000154")]
		public class Multiplier
		{
			[Token(Token = "0x400089E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B478", Offset = "0x23B478")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400089F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B4C0", Offset = "0x23B4C0")]
			public float multiplier;

			[Token(Token = "0x40008A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B514", Offset = "0x23B514")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0xB735E8", Offset = "0xB735E8", VA = "0xB735E8")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0xB73C9C", Offset = "0xB73C9C", VA = "0xB73C9C")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2371C4", Offset = "0x2371C4")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2371F8", Offset = "0x2371F8")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23722C", Offset = "0x23722C")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x237260", Offset = "0x237260")]
		private float <length>k__BackingField;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x237270", Offset = "0x237270")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private InteractionTarget[] targets;

		[Token(Token = "0x170000AF")]
		public float length
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0xB72438", Offset = "0xB72438", VA = "0xB72438")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F4D8", Offset = "0x23F4D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000621")]
			[Address(RVA = "0xB72440", Offset = "0xB72440", VA = "0xB72440")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F4E8", Offset = "0x23F4E8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0xB72448", Offset = "0xB72448", VA = "0xB72448")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F4F8", Offset = "0x23F4F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000623")]
			[Address(RVA = "0xB72450", Offset = "0xB72450", VA = "0xB72450")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F508", Offset = "0x23F508")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0xB727A4", Offset = "0xB727A4", VA = "0xB727A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		public Transform targetsRoot
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0xB712AC", Offset = "0xB712AC", VA = "0xB712AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xB721F8", Offset = "0xB721F8", VA = "0xB721F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F3A0", Offset = "0x23F3A0")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xB72258", Offset = "0xB72258", VA = "0xB72258")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F3D4", Offset = "0x23F3D4")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xB722B8", Offset = "0xB722B8", VA = "0xB722B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F408", Offset = "0x23F408")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xB72318", Offset = "0xB72318", VA = "0xB72318")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F43C", Offset = "0x23F43C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xB72378", Offset = "0xB72378", VA = "0xB72378")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F470", Offset = "0x23F470")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xB723D8", Offset = "0xB723D8", VA = "0xB723D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F4A4", Offset = "0x23F4A4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xB72458", Offset = "0xB72458", VA = "0xB72458")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xB72848", Offset = "0xB72848", VA = "0xB72848")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xB6E714", Offset = "0xB6E714", VA = "0xB6E714")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xB72A40", Offset = "0xB72A40", VA = "0xB72A40")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xB6E520", Offset = "0xB6E520", VA = "0xB6E520")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xB6E70C", Offset = "0xB6E70C", VA = "0xB6E70C")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xB6F93C", Offset = "0xB6F93C", VA = "0xB6F93C")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xB70974", Offset = "0xB70974", VA = "0xB70974")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xB7362C", Offset = "0xB7362C", VA = "0xB7362C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xB72C54", Offset = "0xB72C54", VA = "0xB72C54")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xB72A48", Offset = "0xB72A48", VA = "0xB72A48")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xB7354C", Offset = "0xB7354C", VA = "0xB7354C")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xB73630", Offset = "0xB73630", VA = "0xB73630")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xB736CC", Offset = "0xB736CC", VA = "0xB736CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F518", Offset = "0x23F518")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xB7372C", Offset = "0xB7372C", VA = "0xB7372C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F54C", Offset = "0x23F54C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xB7378C", Offset = "0xB7378C", VA = "0xB7378C")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x231AA8", Offset = "0x231AA8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x231AA8", Offset = "0x231AA8")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x2000155")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x2000156")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237280", Offset = "0x237280")]
		public string targetTag;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2372B4", Offset = "0x2372B4")]
		public float fadeInTime;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237308", Offset = "0x237308")]
		public float speed;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23735C", Offset = "0x23735C")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x237390", Offset = "0x237390")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237390", Offset = "0x237390")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x237390", Offset = "0x237390")]
		public Collider characterCollider;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23741C", Offset = "0x23741C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x23741C", Offset = "0x23741C")]
		public Transform FPSCamera;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23747C", Offset = "0x23747C")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2374B0", Offset = "0x2374B0")]
		public float camRaycastDistance;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x237508", Offset = "0x237508")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RaycastHit raycastHit;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x237518", Offset = "0x237518")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237518", Offset = "0x237518")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237578", Offset = "0x237578")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool initiated;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Collider lastCollider;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Collider c;

		[Token(Token = "0x170000B3")]
		public bool inInteraction
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0xB73EF4", Offset = "0xB73EF4", VA = "0xB73EF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B4")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0xB76AEC", Offset = "0xB76AEC", VA = "0xB76AEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000657")]
			[Address(RVA = "0xB76AF4", Offset = "0xB76AF4", VA = "0xB76AF4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0xB76AFC", Offset = "0xB76AFC", VA = "0xB76AFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F6B8", Offset = "0x23F6B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000659")]
			[Address(RVA = "0xB76B04", Offset = "0xB76B04", VA = "0xB76B04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23F6C8", Offset = "0x23F6C8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xB73CB4", Offset = "0xB73CB4", VA = "0xB73CB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F580", Offset = "0x23F580")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xB73D14", Offset = "0xB73D14", VA = "0xB73D14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F5B4", Offset = "0x23F5B4")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xB73D74", Offset = "0xB73D74", VA = "0xB73D74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F5E8", Offset = "0x23F5E8")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xB73DD4", Offset = "0xB73DD4", VA = "0xB73DD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F61C", Offset = "0x23F61C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xB73E34", Offset = "0xB73E34", VA = "0xB73E34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F650", Offset = "0x23F650")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xB73E94", Offset = "0xB73E94", VA = "0xB73E94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F684", Offset = "0x23F684")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xB74110", Offset = "0xB74110", VA = "0xB74110")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xB7426C", Offset = "0xB7426C", VA = "0xB7426C")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xB743C4", Offset = "0xB743C4", VA = "0xB743C4")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xB744CC", Offset = "0xB744CC", VA = "0xB744CC")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xB74660", Offset = "0xB74660", VA = "0xB74660")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xB74814", Offset = "0xB74814", VA = "0xB74814")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xB7490C", Offset = "0xB7490C", VA = "0xB7490C")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xB74A04", Offset = "0xB74A04", VA = "0xB74A04")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xB74AFC", Offset = "0xB74AFC", VA = "0xB74AFC")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xB74B98", Offset = "0xB74B98", VA = "0xB74B98")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xB74C34", Offset = "0xB74C34", VA = "0xB74C34")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xB74CC0", Offset = "0xB74CC0", VA = "0xB74CC0")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xB74DBC", Offset = "0xB74DBC", VA = "0xB74DBC")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xB74EE4", Offset = "0xB74EE4", VA = "0xB74EE4")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xB75038", Offset = "0xB75038", VA = "0xB75038")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xB75474", Offset = "0xB75474", VA = "0xB75474")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xB7575C", Offset = "0xB7575C", VA = "0xB7575C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xB75B80", Offset = "0xB75B80", VA = "0xB75B80")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xB75F68", Offset = "0xB75F68", VA = "0xB75F68")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xB75FD0", Offset = "0xB75FD0", VA = "0xB75FD0")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xB760D8", Offset = "0xB760D8", VA = "0xB760D8")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xB76264", Offset = "0xB76264", VA = "0xB76264")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xB76454", Offset = "0xB76454", VA = "0xB76454")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xB76974", Offset = "0xB76974", VA = "0xB76974")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xB75CD0", Offset = "0xB75CD0", VA = "0xB75CD0")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xB76B0C", Offset = "0xB76B0C", VA = "0xB76B0C")]
		private void Start()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xB774D4", Offset = "0xB774D4", VA = "0xB774D4")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xB774FC", Offset = "0xB774FC", VA = "0xB774FC")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xB77524", Offset = "0xB77524", VA = "0xB77524")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xB7754C", Offset = "0xB7754C", VA = "0xB7754C")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xB775D4", Offset = "0xB775D4", VA = "0xB775D4")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xB77748", Offset = "0xB77748", VA = "0xB77748")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xB77880", Offset = "0xB77880", VA = "0xB77880")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xB77D34", Offset = "0xB77D34", VA = "0xB77D34")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xB77E58", Offset = "0xB77E58", VA = "0xB77E58")]
		private void Update()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xB781B8", Offset = "0xB781B8", VA = "0xB781B8")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xB7712C", Offset = "0xB7712C", VA = "0xB7712C")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xB78300", Offset = "0xB78300", VA = "0xB78300")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xB784C0", Offset = "0xB784C0", VA = "0xB784C0")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xB78590", Offset = "0xB78590", VA = "0xB78590")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xB786D0", Offset = "0xB786D0", VA = "0xB786D0")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xB786F8", Offset = "0xB786F8", VA = "0xB786F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xB73FFC", Offset = "0xB73FFC", VA = "0xB73FFC")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xB75318", Offset = "0xB75318", VA = "0xB75318")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xB78BA0", Offset = "0xB78BA0", VA = "0xB78BA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F6D8", Offset = "0x23F6D8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xB78C00", Offset = "0xB78C00", VA = "0xB78C00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F70C", Offset = "0x23F70C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xB78C60", Offset = "0xB78C60", VA = "0xB78C60")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x231B08", Offset = "0x231B08")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x231B08", Offset = "0x231B08")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000157")]
		public class Multiplier
		{
			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B578", Offset = "0x23B578")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40008A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B5DC", Offset = "0x23B5DC")]
			public float multiplier;

			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0xB796C0", Offset = "0xB796C0", VA = "0xB796C0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2375CC", Offset = "0x2375CC")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237618", Offset = "0x237618")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23764C", Offset = "0x23764C")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237680", Offset = "0x237680")]
		public Transform pivot;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2376B4", Offset = "0x2376B4")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23771C", Offset = "0x23771C")]
		public float twistWeight;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237750", Offset = "0x237750")]
		public float swingWeight;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237784", Offset = "0x237784")]
		public bool rotateOnce;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Transform lastPivot;

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xB7930C", Offset = "0xB7930C", VA = "0xB7930C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F740", Offset = "0x23F740")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xB7936C", Offset = "0xB7936C", VA = "0xB7936C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F774", Offset = "0x23F774")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xB793CC", Offset = "0xB793CC", VA = "0xB793CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F7A8", Offset = "0x23F7A8")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xB7942C", Offset = "0xB7942C", VA = "0xB7942C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F7DC", Offset = "0x23F7DC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xB7948C", Offset = "0xB7948C", VA = "0xB7948C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F810", Offset = "0x23F810")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xB794EC", Offset = "0xB794EC", VA = "0xB794EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F844", Offset = "0x23F844")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xB72B30", Offset = "0xB72B30", VA = "0xB72B30")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xB71350", Offset = "0xB71350", VA = "0xB71350")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xB6E800", Offset = "0xB6E800", VA = "0xB6E800")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xB7954C", Offset = "0xB7954C", VA = "0xB7954C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F878", Offset = "0x23F878")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xB795AC", Offset = "0xB795AC", VA = "0xB795AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F8AC", Offset = "0x23F8AC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xB7960C", Offset = "0xB7960C", VA = "0xB7960C")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x231B68", Offset = "0x231B68")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x231B68", Offset = "0x231B68")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000158")]
		public class CharacterPosition
		{
			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B62C", Offset = "0x23B62C")]
			public bool use;

			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B660", Offset = "0x23B660")]
			public Vector2 offset;

			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B694", Offset = "0x23B694")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23B694", Offset = "0x23B694")]
			public float angleOffset;

			[Token(Token = "0x40008A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B718", Offset = "0x23B718")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23B718", Offset = "0x23B718")]
			public float maxAngle;

			[Token(Token = "0x40008A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B76C", Offset = "0x23B76C")]
			public float radius;

			[Token(Token = "0x40008A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B7A0", Offset = "0x23B7A0")]
			public bool orbit;

			[Token(Token = "0x40008A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B7D4", Offset = "0x23B7D4")]
			public bool fixYAxis;

			[Token(Token = "0x170001A2")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000AE1")]
				[Address(RVA = "0xB7A0B0", Offset = "0xB7A0B0", VA = "0xB7A0B0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170001A3")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000AE2")]
				[Address(RVA = "0xB7A0EC", Offset = "0xB7A0EC", VA = "0xB7A0EC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000AE3")]
			[Address(RVA = "0xB7A204", Offset = "0xB7A204", VA = "0xB7A204")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0xB7AB34", Offset = "0xB7AB34", VA = "0xB7AB34")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000159")]
		public class CameraPosition
		{
			[Token(Token = "0x40008AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B808", Offset = "0x23B808")]
			public Collider lookAtTarget;

			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B83C", Offset = "0x23B83C")]
			public Vector3 direction;

			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B870", Offset = "0x23B870")]
			public float maxDistance;

			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B8D0", Offset = "0x23B8D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23B8D0", Offset = "0x23B8D0")]
			public float maxAngle;

			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B924", Offset = "0x23B924")]
			public bool fixYAxis;

			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0xB79A0C", Offset = "0xB79A0C", VA = "0xB79A0C")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0xB79C48", Offset = "0xB79C48", VA = "0xB79C48")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AE7")]
			[Address(RVA = "0xB79FE0", Offset = "0xB79FE0", VA = "0xB79FE0")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200015A")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000194")]
			public class Interaction
			{
				[Token(Token = "0x4000975")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23CE88", Offset = "0x23CE88")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000976")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23CEDC", Offset = "0x23CEDC")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000BDD")]
				[Address(RVA = "0xB7AB60", Offset = "0xB7AB60", VA = "0xB7AB60")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23B958", Offset = "0x23B958")]
			[SerializeField]
			public string name;

			[Token(Token = "0x40008B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "HideInInspector", RVA = "0x23B988", Offset = "0x23B988")]
			[SerializeField]
			public bool show;

			[Token(Token = "0x40008B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23B9B8", Offset = "0x23B9B8")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BA1C", Offset = "0x23BA1C")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40008B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BA84", Offset = "0x23BA84")]
			public Interaction[] interactions;

			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0xB797EC", Offset = "0xB797EC", VA = "0xB797EC")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0xB7AB50", Offset = "0xB7AB50", VA = "0xB7AB50")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2377B8", Offset = "0x2377B8")]
		public Range[] ranges;

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xB796C8", Offset = "0xB796C8", VA = "0xB796C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F8E0", Offset = "0x23F8E0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xB79728", Offset = "0xB79728", VA = "0xB79728")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F914", Offset = "0x23F914")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xB79788", Offset = "0xB79788", VA = "0xB79788")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F948", Offset = "0x23F948")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xB797E8", Offset = "0xB797E8", VA = "0xB797E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xB77AF8", Offset = "0xB77AF8", VA = "0xB77AF8")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xB79998", Offset = "0xB79998", VA = "0xB79998")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x200015B")]
		public class Map
		{
			[Token(Token = "0x40008B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform bone;

			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform target;

			[Token(Token = "0x40008B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40008B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0xC241B4", Offset = "0xC241B4", VA = "0xC241B4")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0xC2470C", Offset = "0xC2470C", VA = "0xC2470C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0xC24684", Offset = "0xC24684", VA = "0xC24684")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000AED")]
			[Address(RVA = "0xC243D8", Offset = "0xC243D8", VA = "0xC243D8")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Map[] maps;

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xC23DE8", Offset = "0xC23DE8", VA = "0xC23DE8", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23F97C", Offset = "0x23F97C")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xC24270", Offset = "0xC24270", VA = "0xC24270", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xC24274", Offset = "0xC24274", VA = "0xC24274", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xC245F8", Offset = "0xC245F8", VA = "0xC245F8", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xC241E4", Offset = "0xC241E4", VA = "0xC241E4")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xC24100", Offset = "0xC24100", VA = "0xC24100")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xC24790", Offset = "0xC24790", VA = "0xC24790")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform[] children;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Transform _poseRoot;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xC3263C", Offset = "0xC3263C", VA = "0xC3263C", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xC32724", Offset = "0xC32724", VA = "0xC32724", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xC329E0", Offset = "0xC329E0", VA = "0xC329E0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xC32B84", Offset = "0xC32B84", VA = "0xC32B84", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xC32794", Offset = "0xC32794", VA = "0xC32794")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xC330F4", Offset = "0xC330F4", VA = "0xC330F4")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Transform poseRoot;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2377EC", Offset = "0x2377EC")]
		public float weight;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x237804", Offset = "0x237804")]
		public float localRotationWeight;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23781C", Offset = "0x23781C")]
		public float localPositionWeight;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool initiated;

		[Token(Token = "0x600068F")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xB7E404", Offset = "0xB7E404", VA = "0xB7E404")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000691")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000692")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000693")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xB7E414", Offset = "0xB7E414", VA = "0xB7E414", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xB7E464", Offset = "0xB7E464", VA = "0xB7E464", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xB7E49C", Offset = "0xB7E49C", VA = "0xB7E49C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xB7E4B8", Offset = "0xB7E4B8", VA = "0xB7E4B8")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x231BC8", Offset = "0x231BC8")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x200015C")]
		public class Rigidbone
		{
			[Token(Token = "0x40008B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Rigidbody r;

			[Token(Token = "0x40008B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform t;

			[Token(Token = "0x40008BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Collider collider;

			[Token(Token = "0x40008BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Joint joint;

			[Token(Token = "0x40008BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody c;

			[Token(Token = "0x40008BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool updateAnchor;

			[Token(Token = "0x40008BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40008BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40008C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float deltaTime;

			[Token(Token = "0x40008C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vector3 lastPosition;

			[Token(Token = "0x40008C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0xB7EC08", Offset = "0xB7EC08", VA = "0xB7EC08")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0xB7FD88", Offset = "0xB7FD88", VA = "0xB7FD88")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0xB7FA60", Offset = "0xB7FA60", VA = "0xB7FA60")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x200015D")]
		public class Child
		{
			[Token(Token = "0x40008C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform t;

			[Token(Token = "0x40008C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 localPosition;

			[Token(Token = "0x40008C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Quaternion localRotation;

			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0xB7EE0C", Offset = "0xB7EE0C", VA = "0xB7EE0C")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0xB7FFC8", Offset = "0xB7FFC8", VA = "0xB7FFC8")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0xB7FF44", Offset = "0xB7FF44", VA = "0xB7FF44")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200015E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x232270", Offset = "0x232270")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40008C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40008C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170001A4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AF7")]
				[Address(RVA = "0xB807E8", Offset = "0xB807E8", VA = "0xB807E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AF9")]
				[Address(RVA = "0xB80878", Offset = "0xB80878", VA = "0xB80878", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0xB7EE9C", Offset = "0xB7EE9C", VA = "0xB7EE9C")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000AF5")]
			[Address(RVA = "0xB80468", Offset = "0xB80468", VA = "0xB80468", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0xB8046C", Offset = "0xB8046C", VA = "0xB8046C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0xB807F0", Offset = "0xB807F0", VA = "0xB807F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237834", Offset = "0x237834")]
		public IK ik;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237868", Offset = "0x237868")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2378D0", Offset = "0x2378D0")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23793C", Offset = "0x23793C")]
		public float applyVelocity;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2379A0", Offset = "0x2379A0")]
		public float applyAngularVelocity;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Child[] children;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private IK[] allIKComponents;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float ragdollWeight;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float ragdollWeightV;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool fixedFrame;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x170000B6")]
		private bool isRagdoll
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0xB7E4FC", Offset = "0xB7E4FC", VA = "0xB7E4FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B7")]
		private bool ikUsed
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xB7F408", Offset = "0xB7F408", VA = "0xB7F408")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xB7E4CC", Offset = "0xB7E4CC", VA = "0xB7E4CC")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xB7E5A4", Offset = "0xB7E5A4", VA = "0xB7E5A4")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xB7E6E8", Offset = "0xB7E6E8", VA = "0xB7E6E8")]
		public void Start()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xB7E65C", Offset = "0xB7E65C", VA = "0xB7E65C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x23F9B8", Offset = "0x23F9B8")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xB7EEBC", Offset = "0xB7EEBC", VA = "0xB7EEBC")]
		private void Update()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xB7F290", Offset = "0xB7F290", VA = "0xB7F290")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xB7F340", Offset = "0xB7F340", VA = "0xB7F340")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xB7F614", Offset = "0xB7F614", VA = "0xB7F614")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xB7F3D4", Offset = "0xB7F3D4", VA = "0xB7F3D4")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xB7F5E0", Offset = "0xB7F5E0", VA = "0xB7F5E0")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xB7F6A8", Offset = "0xB7F6A8", VA = "0xB7F6A8")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xB7F638", Offset = "0xB7F638", VA = "0xB7F638")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xB7E5EC", Offset = "0xB7E5EC", VA = "0xB7E5EC")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xB7F2C8", Offset = "0xB7F2C8", VA = "0xB7F2C8")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xB80214", Offset = "0xB80214", VA = "0xB80214")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xB80378", Offset = "0xB80378", VA = "0xB80378")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 axis;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x2379D4", Offset = "0x2379D4")]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool initiated;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool applicationQuit;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x170000B8")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0xB82A44", Offset = "0xB82A44", VA = "0xB82A44")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B9")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0xB82A80", Offset = "0xB82A80", VA = "0xB82A80")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xB825C8", Offset = "0xB825C8", VA = "0xB825C8")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xB82628", Offset = "0xB82628", VA = "0xB82628")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xB82960", Offset = "0xB82960", VA = "0xB82960")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xB82A14", Offset = "0xB82A14", VA = "0xB82A14")]
		public void Disable()
		{
		}

		[Token(Token = "0x60006B0")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xB82844", Offset = "0xB82844", VA = "0xB82844")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xB82B54", Offset = "0xB82B54", VA = "0xB82B54")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xB82B58", Offset = "0xB82B58", VA = "0xB82B58")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xB82B84", Offset = "0xB82B84", VA = "0xB82B84")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xB82C9C", Offset = "0xB82C9C", VA = "0xB82C9C")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xB82FB4", Offset = "0xB82FB4", VA = "0xB82FB4")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xB830B0", Offset = "0xB830B0", VA = "0xB830B0")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x231C40", Offset = "0x231C40")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x231C40", Offset = "0x231C40")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2379E4", Offset = "0x2379E4")]
		public float limit;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x237A00", Offset = "0x237A00")]
		public float twistLimit;

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xE63994", Offset = "0xE63994", VA = "0xE63994")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23FA30", Offset = "0x23FA30")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xE639F4", Offset = "0xE639F4", VA = "0xE639F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23FA64", Offset = "0x23FA64")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xE63A54", Offset = "0xE63A54", VA = "0xE63A54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23FA98", Offset = "0x23FA98")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xE63AB4", Offset = "0xE63AB4", VA = "0xE63AB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23FACC", Offset = "0x23FACC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xE63B14", Offset = "0xE63B14", VA = "0xE63B14", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xE63BA8", Offset = "0xE63BA8", VA = "0xE63BA8")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xE63E9C", Offset = "0xE63E9C", VA = "0xE63E9C")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x231CD8", Offset = "0x231CD8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x231CD8", Offset = "0x231CD8")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool useLimits;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float min;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float max;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x237A1C", Offset = "0x237A1C")]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xE63EBC", Offset = "0xE63EBC", VA = "0xE63EBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23FB00", Offset = "0x23FB00")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xE63F1C", Offset = "0xE63F1C", VA = "0xE63F1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23FB34", Offset = "0x23FB34")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xE63F7C", Offset = "0xE63F7C", VA = "0xE63F7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23FB68", Offset = "0x23FB68")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xE63FDC", Offset = "0xE63FDC", VA = "0xE63FDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23FB9C", Offset = "0x23FB9C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xE6403C", Offset = "0xE6403C", VA = "0xE6403C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xE64088", Offset = "0xE64088", VA = "0xE64088")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xE64438", Offset = "0xE64438", VA = "0xE64438")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x231D70", Offset = "0x231D70")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x231D70", Offset = "0x231D70")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x200015F")]
		public class ReachCone
		{
			[Token(Token = "0x40008C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40008CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float volume;

			[Token(Token = "0x40008CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 S;

			[Token(Token = "0x40008CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 B;

			[Token(Token = "0x170001A6")]
			public Vector3 o
			{
				[Token(Token = "0x6000AFA")]
				[Address(RVA = "0xE66F68", Offset = "0xE66F68", VA = "0xE66F68")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170001A7")]
			public Vector3 a
			{
				[Token(Token = "0x6000AFB")]
				[Address(RVA = "0xE66FB8", Offset = "0xE66FB8", VA = "0xE66FB8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170001A8")]
			public Vector3 b
			{
				[Token(Token = "0x6000AFC")]
				[Address(RVA = "0xE67008", Offset = "0xE67008", VA = "0xE67008")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170001A9")]
			public Vector3 c
			{
				[Token(Token = "0x6000AFD")]
				[Address(RVA = "0xE67058", Offset = "0xE67058", VA = "0xE67058")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170001AA")]
			public bool isValid
			{
				[Token(Token = "0x6000AFF")]
				[Address(RVA = "0xE65C30", Offset = "0xE65C30", VA = "0xE65C30")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0xE664F8", Offset = "0xE664F8", VA = "0xE664F8")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000B00")]
			[Address(RVA = "0xE666EC", Offset = "0xE666EC", VA = "0xE666EC")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000160")]
		public class LimitPoint
		{
			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 point;

			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float tangentWeight;

			[Token(Token = "0x6000B01")]
			[Address(RVA = "0xE65C48", Offset = "0xE65C48", VA = "0xE65C48")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x237A2C", Offset = "0x237A2C")]
		public float twistLimit;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x237A48", Offset = "0x237A48")]
		public int smoothIterations;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x237A64", Offset = "0x237A64")]
		public LimitPoint[] points;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x237A94", Offset = "0x237A94")]
		public Vector3[] P;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x237AC4", Offset = "0x237AC4")]
		public ReachCone[] reachCones;

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xE64504", Offset = "0xE64504", VA = "0xE64504")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23FBD0", Offset = "0x23FBD0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xE64564", Offset = "0xE64564", VA = "0xE64564")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23FC04", Offset = "0x23FC04")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xE645C4", Offset = "0xE645C4", VA = "0xE645C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23FC38", Offset = "0x23FC38")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xE64624", Offset = "0xE64624", VA = "0xE64624")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23FC6C", Offset = "0x23FC6C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xE64684", Offset = "0xE64684", VA = "0xE64684")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xE64D90", Offset = "0xE64D90", VA = "0xE64D90", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xE64E60", Offset = "0xE64E60", VA = "0xE64E60")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xE656C4", Offset = "0xE656C4", VA = "0xE656C4")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xE6471C", Offset = "0xE6471C", VA = "0xE6471C")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xE65CF0", Offset = "0xE65CF0", VA = "0xE65CF0")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xE668E4", Offset = "0xE668E4", VA = "0xE668E4")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xE6692C", Offset = "0xE6692C", VA = "0xE6692C")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xE66A94", Offset = "0xE66A94", VA = "0xE66A94")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xE65270", Offset = "0xE65270", VA = "0xE65270")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xE66C40", Offset = "0xE66C40", VA = "0xE66C40")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xE66EE8", Offset = "0xE66EE8", VA = "0xE66EE8")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x231DD0", Offset = "0x231DD0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x231DD0", Offset = "0x231DD0")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x237AF4", Offset = "0x237AF4")]
		public float twistLimit;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x237B10", Offset = "0x237B10")]
		public AnimationCurve spline;

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xE670A8", Offset = "0xE670A8", VA = "0xE670A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23FCA0", Offset = "0x23FCA0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xE67108", Offset = "0xE67108", VA = "0xE67108")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23FCD4", Offset = "0x23FCD4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xE67168", Offset = "0xE67168", VA = "0xE67168")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23FD08", Offset = "0x23FD08")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xE671C8", Offset = "0xE671C8", VA = "0xE671C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x23FD3C", Offset = "0x23FD3C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xE67228", Offset = "0xE67228", VA = "0xE67228")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xE6725C", Offset = "0xE6725C", VA = "0xE6725C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xE672F0", Offset = "0xE672F0", VA = "0xE672F0")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xE67718", Offset = "0xE67718", VA = "0xE67718")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x232280", Offset = "0x232280")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AimController <>4__this;

			[Token(Token = "0x170001AB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B05")]
				[Address(RVA = "0x780994", Offset = "0x780994", VA = "0x780994", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001AC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B07")]
				[Address(RVA = "0x780A24", Offset = "0x780A24", VA = "0x780A24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B02")]
			[Address(RVA = "0x7806BC", Offset = "0x7806BC", VA = "0x7806BC")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000B03")]
			[Address(RVA = "0x7807EC", Offset = "0x7807EC", VA = "0x7807EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B04")]
			[Address(RVA = "0x7807F0", Offset = "0x7807F0", VA = "0x7807F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B06")]
			[Address(RVA = "0x78099C", Offset = "0x78099C", VA = "0x78099C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237B40", Offset = "0x237B40")]
		public AimIK ik;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237B90", Offset = "0x237B90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x237B90", Offset = "0x237B90")]
		public float weight;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x237BF8", Offset = "0x237BF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237BF8", Offset = "0x237BF8")]
		public Transform target;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237C58", Offset = "0x237C58")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237C8C", Offset = "0x237C8C")]
		public float weightSmoothTime;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x237CEC", Offset = "0x237CEC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237CEC", Offset = "0x237CEC")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237D4C", Offset = "0x237D4C")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237D80", Offset = "0x237D80")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237DB4", Offset = "0x237DB4")]
		public float slerpSpeed;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237DE8", Offset = "0x237DE8")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237E1C", Offset = "0x237E1C")]
		public float minDistance;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237E50", Offset = "0x237E50")]
		public Vector3 offset;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x237E84", Offset = "0x237E84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237E84", Offset = "0x237E84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x237E84", Offset = "0x237E84")]
		public float maxRootAngle;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237F00", Offset = "0x237F00")]
		public bool turnToTarget;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237F34", Offset = "0x237F34")]
		public float turnToTargetTime;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x237F68", Offset = "0x237F68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237F68", Offset = "0x237F68")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237FC8", Offset = "0x237FC8")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float switchWeight;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeightV;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float weightV;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 dir;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool turningToTarget;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float turnToTargetMlpV;

		[Token(Token = "0x170000BA")]
		private Vector3 pivot
		{
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x77F32C", Offset = "0x77F32C", VA = "0x77F32C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x77F1D4", Offset = "0x77F1D4", VA = "0x77F1D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x77F4C0", Offset = "0x77F4C0", VA = "0x77F4C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x77FFB8", Offset = "0x77FFB8", VA = "0x77FFB8")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x7801B8", Offset = "0x7801B8", VA = "0x7801B8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x780630", Offset = "0x780630", VA = "0x780630")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x23FD70", Offset = "0x23FD70")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x7806DC", Offset = "0x7806DC", VA = "0x7806DC")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000162")]
		public class Pose
		{
			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool visualize;

			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public string name;

			[Token(Token = "0x40008D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 direction;

			[Token(Token = "0x40008D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float yaw;

			[Token(Token = "0x40008D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float pitch;

			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float angleBuffer;

			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x785E20", Offset = "0x785E20", VA = "0x785E20")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B09")]
			[Address(RVA = "0x7862F4", Offset = "0x7862F4", VA = "0x7862F4")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0x7862FC", Offset = "0x7862FC", VA = "0x7862FC")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float angleBuffer;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Pose[] poses;

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x785CC0", Offset = "0x785CC0", VA = "0x785CC0")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x786198", Offset = "0x786198", VA = "0x786198")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x786274", Offset = "0x786274", VA = "0x786274")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000163")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000195")]
			public class EffectorLink
			{
				[Token(Token = "0x4000977")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23CF28", Offset = "0x23CF28")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000978")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23CF5C", Offset = "0x23CF5C")]
				public float weight;

				[Token(Token = "0x6000BDE")]
				[Address(RVA = "0x786B7C", Offset = "0x786B7C", VA = "0x786B7C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BAEC", Offset = "0x23BAEC")]
			public Transform transform;

			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BB44", Offset = "0x23BB44")]
			public Transform relativeTo;

			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BBB0", Offset = "0x23BBB0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BBE4", Offset = "0x23BBE4")]
			public float verticalWeight;

			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BC4C", Offset = "0x23BC4C")]
			public float horizontalWeight;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BC80", Offset = "0x23BC80")]
			public float speed;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 smoothDelta;

			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool firstUpdate;

			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0x7864A4", Offset = "0x7864A4", VA = "0x7864A4")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0x786B28", Offset = "0x786B28", VA = "0x786B28")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x786B5C", Offset = "0x786B5C", VA = "0x786B5C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x237FFC", Offset = "0x237FFC")]
		public Body[] bodies;

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x786324", Offset = "0x786324", VA = "0x786324", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x786B20", Offset = "0x786B20", VA = "0x786B20")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238040", Offset = "0x238040")]
		public float tiltSpeed;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238080", Offset = "0x238080")]
		public float tiltSensitivity;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2380C4", Offset = "0x2380C4")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2380F8", Offset = "0x2380F8")]
		public OffsetPose poseRight;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float tiltAngle;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 lastForward;

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x788BB8", Offset = "0x788BB8", VA = "0x788BB8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x788C14", Offset = "0x788C14", VA = "0x788C14", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x788EEC", Offset = "0x788EEC", VA = "0x788EEC")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000164")]
		public abstract class HitPoint
		{
			[Token(Token = "0x40008E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BCD8", Offset = "0x23BCD8")]
			public string name;

			[Token(Token = "0x40008E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BD0C", Offset = "0x23BD0C")]
			public Collider collider;

			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BD40", Offset = "0x23BD40")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23BD88", Offset = "0x23BD88")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23BD98", Offset = "0x23BD98")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23BDA8", Offset = "0x23BDA8")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23BDB8", Offset = "0x23BDB8")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float length;

			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float crossFadeSpeed;

			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170001AD")]
			public bool inProgress
			{
				[Token(Token = "0x6000B0E")]
				[Address(RVA = "0xC331F4", Offset = "0xC331F4", VA = "0xC331F4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170001AE")]
			protected float crossFader
			{
				[Token(Token = "0x6000B0F")]
				[Address(RVA = "0xC338C0", Offset = "0xC338C0", VA = "0xC338C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240538", Offset = "0x240538")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000B10")]
				[Address(RVA = "0xC338C8", Offset = "0xC338C8", VA = "0xC338C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240548", Offset = "0x240548")]
				private set
				{
				}
			}

			[Token(Token = "0x170001AF")]
			protected float timer
			{
				[Token(Token = "0x6000B11")]
				[Address(RVA = "0xC338D0", Offset = "0xC338D0", VA = "0xC338D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240558", Offset = "0x240558")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000B12")]
				[Address(RVA = "0xC338D8", Offset = "0xC338D8", VA = "0xC338D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240568", Offset = "0x240568")]
				private set
				{
				}
			}

			[Token(Token = "0x170001B0")]
			protected Vector3 force
			{
				[Token(Token = "0x6000B13")]
				[Address(RVA = "0xC338E0", Offset = "0xC338E0", VA = "0xC338E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240578", Offset = "0x240578")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000B14")]
				[Address(RVA = "0xC338F4", Offset = "0xC338F4", VA = "0xC338F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240588", Offset = "0x240588")]
				private set
				{
				}
			}

			[Token(Token = "0x170001B1")]
			protected Vector3 point
			{
				[Token(Token = "0x6000B15")]
				[Address(RVA = "0xC33900", Offset = "0xC33900", VA = "0xC33900")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240598", Offset = "0x240598")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000B16")]
				[Address(RVA = "0xC33914", Offset = "0xC33914", VA = "0xC33914")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2405A8", Offset = "0x2405A8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000B17")]
			[Address(RVA = "0xC33760", Offset = "0xC33760", VA = "0xC33760")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000B18")]
			[Address(RVA = "0xC33338", Offset = "0xC33338", VA = "0xC33338")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000B19")]
			protected abstract float GetLength();

			[Token(Token = "0x6000B1A")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000B1B")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0xC33920", Offset = "0xC33920", VA = "0xC33920")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000165")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000196")]
			public class EffectorLink
			{
				[Token(Token = "0x4000979")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23CF90", Offset = "0x23CF90")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400097A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23CFC4", Offset = "0x23CFC4")]
				public float weight;

				[Token(Token = "0x400097B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Vector3 lastValue;

				[Token(Token = "0x400097C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Vector3 current;

				[Token(Token = "0x6000BDF")]
				[Address(RVA = "0xC345A8", Offset = "0xC345A8", VA = "0xC345A8")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000BE0")]
				[Address(RVA = "0xC3430C", Offset = "0xC3430C", VA = "0xC3430C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000BE1")]
				[Address(RVA = "0xC3475C", Offset = "0xC3475C", VA = "0xC3475C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BDC8", Offset = "0x23BDC8")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BDFC", Offset = "0x23BDFC")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BE30", Offset = "0x23BE30")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0xC3404C", Offset = "0xC3404C", VA = "0xC3404C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0xC34294", Offset = "0xC34294", VA = "0xC34294", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0xC34320", Offset = "0xC34320", VA = "0xC34320", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000B20")]
			[Address(RVA = "0xC34748", Offset = "0xC34748", VA = "0xC34748")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000166")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000197")]
			public class BoneLink
			{
				[Token(Token = "0x400097D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23CFF8", Offset = "0x23CFF8")]
				public Transform bone;

				[Token(Token = "0x400097E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23D02C", Offset = "0x23D02C")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23D02C", Offset = "0x23D02C")]
				public float weight;

				[Token(Token = "0x400097F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Quaternion lastValue;

				[Token(Token = "0x4000980")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private Quaternion current;

				[Token(Token = "0x6000BE2")]
				[Address(RVA = "0xC33DAC", Offset = "0xC33DAC", VA = "0xC33DAC")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000BE3")]
				[Address(RVA = "0xC33A90", Offset = "0xC33A90", VA = "0xC33A90")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000BE4")]
				[Address(RVA = "0xC33F84", Offset = "0xC33F84", VA = "0xC33F84")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BE88", Offset = "0x23BE88")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BEBC", Offset = "0x23BEBC")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000B21")]
			[Address(RVA = "0xC33934", Offset = "0xC33934", VA = "0xC33934", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000B22")]
			[Address(RVA = "0xC33A18", Offset = "0xC33A18", VA = "0xC33A18", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000B23")]
			[Address(RVA = "0xC33AA4", Offset = "0xC33AA4", VA = "0xC33AA4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000B24")]
			[Address(RVA = "0xC33F70", Offset = "0xC33F70", VA = "0xC33F70")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23812C", Offset = "0x23812C")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238160", Offset = "0x238160")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000BB")]
		public bool inProgress
		{
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0xC330FC", Offset = "0xC330FC", VA = "0xC330FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xC33210", Offset = "0xC33210", VA = "0xC33210", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xC334A4", Offset = "0xC334A4", VA = "0xC334A4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xC338B8", Offset = "0xC338B8", VA = "0xC338B8")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x2000167")]
		public abstract class Offset
		{
			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BEF0", Offset = "0x23BEF0")]
			public string name;

			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BF24", Offset = "0x23BF24")]
			public Collider collider;

			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BF58", Offset = "0x23BF58")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23BFA0", Offset = "0x23BFA0")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23BFB0", Offset = "0x23BFB0")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40008F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23BFC0", Offset = "0x23BFC0")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23BFD0", Offset = "0x23BFD0")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float length;

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float crossFadeSpeed;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170001B2")]
			protected float crossFader
			{
				[Token(Token = "0x6000B25")]
				[Address(RVA = "0xC34E38", Offset = "0xC34E38", VA = "0xC34E38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2405B8", Offset = "0x2405B8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000B26")]
				[Address(RVA = "0xC34E40", Offset = "0xC34E40", VA = "0xC34E40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2405C8", Offset = "0x2405C8")]
				private set
				{
				}
			}

			[Token(Token = "0x170001B3")]
			protected float timer
			{
				[Token(Token = "0x6000B27")]
				[Address(RVA = "0xC34E48", Offset = "0xC34E48", VA = "0xC34E48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2405D8", Offset = "0x2405D8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000B28")]
				[Address(RVA = "0xC34E50", Offset = "0xC34E50", VA = "0xC34E50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2405E8", Offset = "0x2405E8")]
				private set
				{
				}
			}

			[Token(Token = "0x170001B4")]
			protected Vector3 force
			{
				[Token(Token = "0x6000B29")]
				[Address(RVA = "0xC34E58", Offset = "0xC34E58", VA = "0xC34E58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2405F8", Offset = "0x2405F8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000B2A")]
				[Address(RVA = "0xC34E6C", Offset = "0xC34E6C", VA = "0xC34E6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240608", Offset = "0x240608")]
				private set
				{
				}
			}

			[Token(Token = "0x170001B5")]
			protected Vector3 point
			{
				[Token(Token = "0x6000B2B")]
				[Address(RVA = "0xC34E78", Offset = "0xC34E78", VA = "0xC34E78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240618", Offset = "0x240618")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000B2C")]
				[Address(RVA = "0xC34E8C", Offset = "0xC34E8C", VA = "0xC34E8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x240628", Offset = "0x240628")]
				private set
				{
				}
			}

			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0xC34CD0", Offset = "0xC34CD0", VA = "0xC34CD0")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0xC34884", Offset = "0xC34884", VA = "0xC34884")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000B2F")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000B30")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000B31")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000B32")]
			[Address(RVA = "0xC34E98", Offset = "0xC34E98", VA = "0xC34E98")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000168")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000198")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000981")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23D07C", Offset = "0x23D07C")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000982")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23D0B0", Offset = "0x23D0B0")]
				public float weight;

				[Token(Token = "0x4000983")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Vector3 lastValue;

				[Token(Token = "0x4000984")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Vector3 current;

				[Token(Token = "0x6000BE5")]
				[Address(RVA = "0xC35564", Offset = "0xC35564", VA = "0xC35564")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000BE6")]
				[Address(RVA = "0xC35258", Offset = "0xC35258", VA = "0xC35258")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000BE7")]
				[Address(RVA = "0xC356EC", Offset = "0xC356EC", VA = "0xC356EC")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23BFE0", Offset = "0x23BFE0")]
			public int forceDirCurveIndex;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C014", Offset = "0x23C014")]
			public int upDirCurveIndex;

			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C048", Offset = "0x23C048")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000B33")]
			[Address(RVA = "0xC34EAC", Offset = "0xC34EAC", VA = "0xC34EAC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000B34")]
			[Address(RVA = "0xC351E0", Offset = "0xC351E0", VA = "0xC351E0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000B35")]
			[Address(RVA = "0xC3526C", Offset = "0xC3526C", VA = "0xC3526C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000B36")]
			[Address(RVA = "0xC356D0", Offset = "0xC356D0", VA = "0xC356D0")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000169")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000199")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000985")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23D0E4", Offset = "0x23D0E4")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000986")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23D118", Offset = "0x23D118")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23D118", Offset = "0x23D118")]
				public float weight;

				[Token(Token = "0x4000987")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Quaternion lastValue;

				[Token(Token = "0x4000988")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private Quaternion current;

				[Token(Token = "0x6000BE8")]
				[Address(RVA = "0xC35CD0", Offset = "0xC35CD0", VA = "0xC35CD0")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000BE9")]
				[Address(RVA = "0xC358D0", Offset = "0xC358D0", VA = "0xC358D0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000BEA")]
				[Address(RVA = "0xC35E88", Offset = "0xC35E88", VA = "0xC35E88")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C0A8", Offset = "0x23C0A8")]
			public int curveIndex;

			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C0DC", Offset = "0x23C0DC")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000B37")]
			[Address(RVA = "0xC356F4", Offset = "0xC356F4", VA = "0xC356F4", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000B38")]
			[Address(RVA = "0xC35858", Offset = "0xC35858", VA = "0xC35858", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000B39")]
			[Address(RVA = "0xC358E4", Offset = "0xC358E4", VA = "0xC358E4", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0xC35E74", Offset = "0xC35E74", VA = "0xC35E74")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238194", Offset = "0x238194")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2381C8", Offset = "0x2381C8")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xC34764", Offset = "0xC34764", VA = "0xC34764", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xC349FC", Offset = "0xC349FC", VA = "0xC349FC")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xC34E30", Offset = "0xC34E30", VA = "0xC34E30")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200016A")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x200019A")]
			public class EffectorLink
			{
				[Token(Token = "0x4000989")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23D168", Offset = "0x23D168")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400098A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23D19C", Offset = "0x23D19C")]
				public float weight;

				[Token(Token = "0x6000BEB")]
				[Address(RVA = "0xB6CE24", Offset = "0xB6CE24", VA = "0xB6CE24")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C110", Offset = "0x23C110")]
			public Transform transform;

			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C178", Offset = "0x23C178")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C1AC", Offset = "0x23C1AC")]
			public float speed;

			[Token(Token = "0x4000904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C1FC", Offset = "0x23C1FC")]
			public float acceleration;

			[Token(Token = "0x4000905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C260", Offset = "0x23C260")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23C260", Offset = "0x23C260")]
			public float matchVelocity;

			[Token(Token = "0x4000906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C2C4", Offset = "0x23C2C4")]
			public float gravity;

			[Token(Token = "0x4000907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 delta;

			[Token(Token = "0x4000908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3 direction;

			[Token(Token = "0x400090A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 lastPosition;

			[Token(Token = "0x400090B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private bool firstUpdate;

			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0xB6C58C", Offset = "0xB6C58C", VA = "0xB6C58C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0xB6C7C8", Offset = "0xB6C7C8", VA = "0xB6C7C8")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0xB6CDFC", Offset = "0xB6CDFC", VA = "0xB6CDFC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2381FC", Offset = "0x2381FC")]
		public Body[] bodies;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23823C", Offset = "0x23823C")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xB6C50C", Offset = "0xB6C50C", VA = "0xB6C50C")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xB6C6D4", Offset = "0xB6C6D4", VA = "0xB6C6D4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xB6CDDC", Offset = "0xB6CDDC", VA = "0xB6CDDC")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public LookAtIK ik;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x238284", Offset = "0x238284")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238284", Offset = "0x238284")]
		public Transform target;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2382E4", Offset = "0x2382E4")]
		public float weight;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 offset;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2382FC", Offset = "0x2382FC")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238330", Offset = "0x238330")]
		public float weightSmoothTime;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x238394", Offset = "0x238394")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238394", Offset = "0x238394")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2383F4", Offset = "0x2383F4")]
		public float maxRadiansDelta;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238428", Offset = "0x238428")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23845C", Offset = "0x23845C")]
		public float slerpSpeed;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238490", Offset = "0x238490")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2384C4", Offset = "0x2384C4")]
		public float minDistance;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2384F8", Offset = "0x2384F8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2384F8", Offset = "0x2384F8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2384F8", Offset = "0x2384F8")]
		public float maxRootAngle;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform lastTarget;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float switchWeight;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float switchWeightV;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float weightV;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 dir;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000BC")]
		private Vector3 pivot
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0xB7B0F0", Offset = "0xB7B0F0", VA = "0xB7B0F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xB7AFC8", Offset = "0xB7AFC8", VA = "0xB7AFC8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xB7B284", Offset = "0xB7B284", VA = "0xB7B284")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xB7BC3C", Offset = "0xB7BC3C", VA = "0xB7BC3C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xB7BE3C", Offset = "0xB7BE3C", VA = "0xB7BE3C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xB7C248", Offset = "0xB7C248", VA = "0xB7C248")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200016B")]
		public class OffsetLimits
		{
			[Token(Token = "0x400090C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C30C", Offset = "0x23C30C")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C364", Offset = "0x23C364")]
			public float spring;

			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C398", Offset = "0x23C398")]
			public bool x;

			[Token(Token = "0x400090F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C3CC", Offset = "0x23C3CC")]
			public bool y;

			[Token(Token = "0x4000910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C400", Offset = "0x23C400")]
			public bool z;

			[Token(Token = "0x4000911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C434", Offset = "0x23C434")]
			public float minX;

			[Token(Token = "0x4000912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C468", Offset = "0x23C468")]
			public float maxX;

			[Token(Token = "0x4000913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C49C", Offset = "0x23C49C")]
			public float minY;

			[Token(Token = "0x4000914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C4D0", Offset = "0x23C4D0")]
			public float maxY;

			[Token(Token = "0x4000915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C504", Offset = "0x23C504")]
			public float minZ;

			[Token(Token = "0x4000916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C538", Offset = "0x23C538")]
			public float maxZ;

			[Token(Token = "0x6000B3E")]
			[Address(RVA = "0xB7C748", Offset = "0xB7C748", VA = "0xB7C748")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0xB7CDD4", Offset = "0xB7CDD4", VA = "0xB7CDD4")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000B40")]
			[Address(RVA = "0xB7CE30", Offset = "0xB7CE30", VA = "0xB7CE30")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000B41")]
			[Address(RVA = "0xB7CF34", Offset = "0xB7CF34", VA = "0xB7CF34")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x200016C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x232290", Offset = "0x232290")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x4000918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x4000919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170001B6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B45")]
				[Address(RVA = "0xB7CD3C", Offset = "0xB7CD3C", VA = "0xB7CD3C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001B7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B47")]
				[Address(RVA = "0xB7CDCC", Offset = "0xB7CDCC", VA = "0xB7CDCC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B42")]
			[Address(RVA = "0xB7C5E0", Offset = "0xB7C5E0", VA = "0xB7C5E0")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000B43")]
			[Address(RVA = "0xB7CB94", Offset = "0xB7CB94", VA = "0xB7CB94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B44")]
			[Address(RVA = "0xB7CB98", Offset = "0xB7CB98", VA = "0xB7CB98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B46")]
			[Address(RVA = "0xB7CD44", Offset = "0xB7CD44", VA = "0xB7CD44", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238574", Offset = "0x238574")]
		public float weight;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2385A8", Offset = "0x2385A8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected float lastTime;

		[Token(Token = "0x170000BD")]
		protected float deltaTime
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0xB6C7A0", Offset = "0xB6C7A0", VA = "0xB6C7A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006FE")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xB7C530", Offset = "0xB7C530", VA = "0xB7C530", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xB7C554", Offset = "0xB7C554", VA = "0xB7C554")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x23FDE8", Offset = "0x23FDE8")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xB7C600", Offset = "0xB7C600", VA = "0xB7C600")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xB6CCD8", Offset = "0xB6CCD8", VA = "0xB6CCD8")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xB7CA44", Offset = "0xB7CA44", VA = "0xB7CA44", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xB6CDEC", Offset = "0xB6CDEC", VA = "0xB6CDEC")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x200016D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2322A0", Offset = "0x2322A0")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400091A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x400091B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x400091C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170001B8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B4B")]
				[Address(RVA = "0xB7D484", Offset = "0xB7D484", VA = "0xB7D484", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001B9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B4D")]
				[Address(RVA = "0xB7D514", Offset = "0xB7D514", VA = "0xB7D514", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B48")]
			[Address(RVA = "0xB7D014", Offset = "0xB7D014", VA = "0xB7D014")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000B49")]
			[Address(RVA = "0xB7D2DC", Offset = "0xB7D2DC", VA = "0xB7D2DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0xB7D2E0", Offset = "0xB7D2E0", VA = "0xB7D2E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B4C")]
			[Address(RVA = "0xB7D48C", Offset = "0xB7D48C", VA = "0xB7D48C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2385F8", Offset = "0x2385F8")]
		public float weight;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23862C", Offset = "0x23862C")]
		public VRIK ik;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float lastTime;

		[Token(Token = "0x170000BE")]
		protected float deltaTime
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0xB7CF3C", Offset = "0xB7CF3C", VA = "0xB7CF3C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000706")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xB7CF64", Offset = "0xB7CF64", VA = "0xB7CF64", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xB7CF88", Offset = "0xB7CF88", VA = "0xB7CF88")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x23FE60", Offset = "0x23FE60")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xB7D034", Offset = "0xB7D034", VA = "0xB7D034")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xB7D17C", Offset = "0xB7D17C", VA = "0xB7D17C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xB7D2CC", Offset = "0xB7D2CC", VA = "0xB7D2CC")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200016E")]
		public class EffectorLink
		{
			[Token(Token = "0x400091D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 offset;

			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 pin;

			[Token(Token = "0x4000920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000B4E")]
			[Address(RVA = "0xB7D608", Offset = "0xB7D608", VA = "0xB7D608")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000B4F")]
			[Address(RVA = "0xB7DB5C", Offset = "0xB7DB5C", VA = "0xB7DB5C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xB7D51C", Offset = "0xB7D51C", VA = "0xB7D51C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xB7DA24", Offset = "0xB7DA24", VA = "0xB7DA24")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xB7DAE8", Offset = "0xB7DAE8", VA = "0xB7DAE8")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200016F")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x200019B")]
			public class EffectorLink
			{
				[Token(Token = "0x400098B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23D1D0", Offset = "0x23D1D0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400098C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23D220", Offset = "0x23D220")]
				public float weight;

				[Token(Token = "0x6000BEC")]
				[Address(RVA = "0xB7E3FC", Offset = "0xB7E3FC", VA = "0xB7E3FC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C56C", Offset = "0x23C56C")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C5A0", Offset = "0x23C5A0")]
			public Transform raycastTo;

			[Token(Token = "0x4000923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C5D4", Offset = "0x23C5D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23C5D4", Offset = "0x23C5D4")]
			public float raycastRadius;

			[Token(Token = "0x4000924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C624", Offset = "0x23C624")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C674", Offset = "0x23C674")]
			public float smoothTimeIn;

			[Token(Token = "0x4000926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C6A8", Offset = "0x23C6A8")]
			public float smoothTimeOut;

			[Token(Token = "0x4000927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C6DC", Offset = "0x23C6DC")]
			public LayerMask layers;

			[Token(Token = "0x4000928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Vector3 offset;

			[Token(Token = "0x4000929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 offsetTarget;

			[Token(Token = "0x400092A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offsetV;

			[Token(Token = "0x6000B50")]
			[Address(RVA = "0xB7DC04", Offset = "0xB7DC04", VA = "0xB7DC04")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000B51")]
			[Address(RVA = "0xB7DED0", Offset = "0xB7DED0", VA = "0xB7DED0")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000B52")]
			[Address(RVA = "0xB7E0D4", Offset = "0xB7E0D4", VA = "0xB7E0D4")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000B53")]
			[Address(RVA = "0xB7E3DC", Offset = "0xB7E3DC", VA = "0xB7E3DC")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238678", Offset = "0x238678")]
		public Avoider[] avoiders;

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xB7DB64", Offset = "0xB7DB64", VA = "0xB7DB64", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xB7DEC0", Offset = "0xB7DEC0", VA = "0xB7DEC0")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000170")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x200019C")]
			public class EffectorLink
			{
				[Token(Token = "0x400098D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23D280", Offset = "0x23D280")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400098E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23D2B4", Offset = "0x23D2B4")]
				public float weight;

				[Token(Token = "0x6000BED")]
				[Address(RVA = "0xB825C0", Offset = "0xB825C0", VA = "0xB825C0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400092B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C72C", Offset = "0x23C72C")]
			public Vector3 offset;

			[Token(Token = "0x400092C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C798", Offset = "0x23C798")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23C798", Offset = "0x23C798")]
			public float additivity;

			[Token(Token = "0x400092D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C7E8", Offset = "0x23C7E8")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x400092E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C83C", Offset = "0x23C83C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400092F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000B54")]
			[Address(RVA = "0xB80B60", Offset = "0xB80B60", VA = "0xB80B60")]
			public void Start()
			{
			}

			[Token(Token = "0x6000B55")]
			[Address(RVA = "0xB81C20", Offset = "0xB81C20", VA = "0xB81C20")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000B56")]
			[Address(RVA = "0xB825A4", Offset = "0xB825A4", VA = "0xB825A4")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000171")]
		public enum Handedness
		{
			[Token(Token = "0x4000932")]
			Right,
			[Token(Token = "0x4000933")]
			Left
		}

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2386CC", Offset = "0x2386CC")]
		public AimIK aimIK;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238700", Offset = "0x238700")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238734", Offset = "0x238734")]
		public Handedness handedness;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238784", Offset = "0x238784")]
		public bool twoHanded;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2387CC", Offset = "0x2387CC")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238800", Offset = "0x238800")]
		public float magnitudeRandom;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238834", Offset = "0x238834")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2388A0", Offset = "0x2388A0")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23890C", Offset = "0x23890C")]
		public float blendTime;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x238978", Offset = "0x238978")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238978", Offset = "0x238978")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x2389C8", Offset = "0x2389C8")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float magnitudeMlp;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float endTime;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion handRotation;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion randomRotation;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float length;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool initiated;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float blendWeight;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float w;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool handRotationsSet;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000BF")]
		public bool isFinished
		{
			[Token(Token = "0x6000711")]
			[Address(RVA = "0xB80880", Offset = "0xB80880", VA = "0xB80880")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C0")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000717")]
			[Address(RVA = "0xB81FB0", Offset = "0xB81FB0", VA = "0xB81FB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0xB82004", Offset = "0xB82004", VA = "0xB82004")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000719")]
			[Address(RVA = "0xB81F60", Offset = "0xB81F60", VA = "0xB81F60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0xB81F88", Offset = "0xB81F88", VA = "0xB81F88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xB808B4", Offset = "0xB808B4", VA = "0xB808B4")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xB8090C", Offset = "0xB8090C", VA = "0xB8090C")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xB80C4C", Offset = "0xB80C4C", VA = "0xB80C4C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xB82058", Offset = "0xB82058", VA = "0xB82058")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xB821E8", Offset = "0xB821E8", VA = "0xB821E8")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xB82244", Offset = "0xB82244", VA = "0xB82244", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xB824AC", Offset = "0xB824AC", VA = "0xB824AC")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2389D8", Offset = "0x2389D8")]
		public float weight;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x238A20", Offset = "0x238A20")]
		public float offset;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool skip;

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xE68264", Offset = "0xE68264", VA = "0xE68264")]
		private void Start()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xE68388", Offset = "0xE68388", VA = "0xE68388")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xE684DC", Offset = "0xE684DC", VA = "0xE684DC")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xE68B8C", Offset = "0xE68B8C", VA = "0xE68B8C")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xE68BF8", Offset = "0xE68BF8", VA = "0xE68BF8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xE68D48", Offset = "0xE68D48", VA = "0xE68D48")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x2000172")]
		public class Settings
		{
			[Token(Token = "0x4000934")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C898", Offset = "0x23C898")]
			public float scaleMlp;

			[Token(Token = "0x4000935")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C8E0", Offset = "0x23C8E0")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000936")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C934", Offset = "0x23C934")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000937")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C984", Offset = "0x23C984")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000938")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23C9B8", Offset = "0x23C9B8")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000939")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23CA20", Offset = "0x23CA20")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x400093A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23CA54", Offset = "0x23CA54")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x400093B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23CA88", Offset = "0x23CA88")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x400093C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23CABC", Offset = "0x23CABC")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x400093D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x23CB24", Offset = "0x23CB24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23CB24", Offset = "0x23CB24")]
			public Vector3 headOffset;

			[Token(Token = "0x400093E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23CB74", Offset = "0x23CB74")]
			public Vector3 handOffset;

			[Token(Token = "0x400093F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23CBA8", Offset = "0x23CBA8")]
			public float footForwardOffset;

			[Token(Token = "0x4000940")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23CC10", Offset = "0x23CC10")]
			public float footInwardOffset;

			[Token(Token = "0x4000941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x23CC74", Offset = "0x23CC74")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23CC74", Offset = "0x23CC74")]
			public float footHeadingOffset;

			[Token(Token = "0x4000942")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23CD04", Offset = "0x23CD04")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x23CD1C", Offset = "0x23CD1C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000B57")]
			[Address(RVA = "0xE70928", Offset = "0xE70928", VA = "0xE70928")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000173")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x200019D")]
			public class Target
			{
				[Token(Token = "0x400098F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public bool used;

				[Token(Token = "0x4000990")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public Vector3 localPosition;

				[Token(Token = "0x4000991")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Quaternion localRotation;

				[Token(Token = "0x6000BEE")]
				[Address(RVA = "0xE6F1B0", Offset = "0xE6F1B0", VA = "0xE6F1B0")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000BEF")]
				[Address(RVA = "0xE703BC", Offset = "0xE703BC", VA = "0xE703BC")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float scale;

			[Token(Token = "0x4000945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Target head;

			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Target leftHand;

			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Target rightHand;

			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target pelvis;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Target leftFoot;

			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target rightFoot;

			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Target leftLegGoal;

			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightLegGoal;

			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000B58")]
			[Address(RVA = "0xE6E220", Offset = "0xE6E220", VA = "0xE6E220")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xE6BE7C", Offset = "0xE6BE7C", VA = "0xE6BE7C")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xE6C0B8", Offset = "0xE6C0B8", VA = "0xE6C0B8")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xE6E3A8", Offset = "0xE6E3A8", VA = "0xE6E3A8")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xE6F2C0", Offset = "0xE6F2C0", VA = "0xE6F2C0")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xE7044C", Offset = "0xE7044C", VA = "0xE7044C")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x238A54", Offset = "0x238A54")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform pelvisTarget;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Transform leftFootTarget;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform rightFootTarget;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private VRIK ik;

		[Token(Token = "0x170000C4")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x6000728")]
			[Address(RVA = "0xE70AA0", Offset = "0xE70AA0", VA = "0xE70AA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23FED8", Offset = "0x23FED8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000729")]
			[Address(RVA = "0xE70AB4", Offset = "0xE70AB4", VA = "0xE70AB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23FEE8", Offset = "0x23FEE8")]
			private set
			{
			}
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xE70AC0", Offset = "0xE70AC0", VA = "0xE70AC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xE6EEB4", Offset = "0xE6EEB4", VA = "0xE6EEB4")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xE70700", Offset = "0xE70700", VA = "0xE70700")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xE70BEC", Offset = "0xE70BEC", VA = "0xE70BEC")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xE71358", Offset = "0xE71358", VA = "0xE71358")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xE714A8", Offset = "0xE714A8", VA = "0xE714A8")]
		public VRIKRootController()
		{
		}
	}
}
namespace AdvancedInspector
{
	[Token(Token = "0x20000A8")]
	public delegate void AdvancedInspectorForceRefresh(bool rebuil);
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231E30", Offset = "0x231E30")]
	public class AdvancedInspectorAttribute : Attribute
	{
		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool inspectDefaultItems;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private bool showScript;

		[Token(Token = "0x170000C5")]
		public bool InspectDefaultItems
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0xDED370", Offset = "0xDED370", VA = "0xDED370")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000738")]
			[Address(RVA = "0xDED378", Offset = "0xDED378", VA = "0xDED378")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public bool ShowScript
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0xDED380", Offset = "0xDED380", VA = "0xDED380")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600073A")]
			[Address(RVA = "0xDED388", Offset = "0xDED388", VA = "0xDED388")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public static event AdvancedInspectorForceRefresh OnForceRefresh
		{
			[Token(Token = "0x6000734")]
			[Address(RVA = "0xDECEE4", Offset = "0xDECEE4", VA = "0xDECEE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23FEF8", Offset = "0x23FEF8")]
			add
			{
			}
			[Token(Token = "0x6000735")]
			[Address(RVA = "0xDECFBC", Offset = "0xDECFBC", VA = "0xDECFBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23FF08", Offset = "0x23FF08")]
			remove
			{
			}
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xDED094", Offset = "0xDED094", VA = "0xDED094")]
		public static void Refresh(bool rebuild = false)
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xDED390", Offset = "0xDED390", VA = "0xDED390")]
		public AdvancedInspectorAttribute()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xDED3A0", Offset = "0xDED3A0", VA = "0xDED3A0")]
		public AdvancedInspectorAttribute(bool inspectDefaultItems)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xDED3CC", Offset = "0xDED3CC", VA = "0xDED3CC")]
		public AdvancedInspectorAttribute(bool inspectDefaultItems, bool showScript)
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231E5C", Offset = "0x231E5C")]
	public class AngleAttribute : Attribute, IListAttribute
	{
		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private float snap;

		[Token(Token = "0x170000C7")]
		public float Snap
		{
			[Token(Token = "0x600073E")]
			[Address(RVA = "0xDED4BC", Offset = "0xDED4BC", VA = "0xDED4BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600073F")]
			[Address(RVA = "0xDED4C4", Offset = "0xDED4C4", VA = "0xDED4C4")]
			set
			{
			}
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xDED4CC", Offset = "0xDED4CC", VA = "0xDED4CC")]
		public AngleAttribute()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xDED4E0", Offset = "0xDED4E0", VA = "0xDED4E0")]
		public AngleAttribute(float snap)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231E70", Offset = "0x231E70")]
	public class BackgroundAttribute : Attribute, IRuntimeAttribute<Color>, IRuntimeAttribute
	{
		[Token(Token = "0x2000174")]
		public delegate Color BackgroundDelegate();

		[Token(Token = "0x2000175")]
		public delegate Color BackgroundStaticDelegate(BackgroundAttribute background, object instance, object value);

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private Color color;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string methodName;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private List<Delegate> delegates;

		[Token(Token = "0x170000C8")]
		public Color Color
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0xDED510", Offset = "0xDED510", VA = "0xDED510")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000743")]
			[Address(RVA = "0xDED520", Offset = "0xDED520", VA = "0xDED520")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public string MethodName
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0xDED530", Offset = "0xDED530", VA = "0xDED530", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000745")]
			[Address(RVA = "0xDED538", Offset = "0xDED538", VA = "0xDED538")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public Type Template
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0xDED540", Offset = "0xDED540", VA = "0xDED540", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CB")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0xDED5D0", Offset = "0xDED5D0", VA = "0xDED5D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0xDED660", Offset = "0xDED660", VA = "0xDED660", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000749")]
			[Address(RVA = "0xDED668", Offset = "0xDED668", VA = "0xDED668", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xDED670", Offset = "0xDED670", VA = "0xDED670", Slot = "6")]
		public Color Invoke(int index, object instance, object value)
		{
			return default(Color);
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xDEDC04", Offset = "0xDEDC04", VA = "0xDEDC04")]
		public BackgroundAttribute(string methodName)
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xDEDCD4", Offset = "0xDEDCD4", VA = "0xDEDCD4")]
		public BackgroundAttribute(Delegate method)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xDEDDD0", Offset = "0xDEDDD0", VA = "0xDEDDD0")]
		public BackgroundAttribute(float r, float g, float b)
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xDEDDF0", Offset = "0xDEDDF0", VA = "0xDEDDF0")]
		public BackgroundAttribute(float r, float g, float b, float a)
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231E84", Offset = "0x231E84")]
	public class BypassAttribute : Attribute, IListAttribute
	{
		[Token(Token = "0x600074F")]
		[Address(RVA = "0xDEEC2C", Offset = "0xDEEC2C", VA = "0xDEEC2C")]
		public BypassAttribute()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231E98", Offset = "0x231E98")]
	public class CollectionAttribute : Attribute, IListAttribute, IRuntimeAttribute<string[]>, IRuntimeAttribute
	{
		[Token(Token = "0x2000176")]
		public delegate string[] CollectionDelegate();

		[Token(Token = "0x2000177")]
		public delegate string[] CollectionStaticDelegate(CollectionAttribute collection, object instance, object value);

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int size;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private bool sortable;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CollectionDisplay display;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int maxDisplayedItems;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int maxItemsPerRow;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool alwaysExpanded;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private bool expandElements;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Type enumType;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private string methodName;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Delegate> delegates;

		[Token(Token = "0x170000CD")]
		public int Size
		{
			[Token(Token = "0x6000750")]
			[Address(RVA = "0xDEEC34", Offset = "0xDEEC34", VA = "0xDEEC34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000751")]
			[Address(RVA = "0xDEEC3C", Offset = "0xDEEC3C", VA = "0xDEEC3C")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public bool Sortable
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0xDEEC44", Offset = "0xDEEC44", VA = "0xDEEC44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000753")]
			[Address(RVA = "0xDEEC4C", Offset = "0xDEEC4C", VA = "0xDEEC4C")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public CollectionDisplay Display
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0xDEEC54", Offset = "0xDEEC54", VA = "0xDEEC54")]
			get
			{
				return default(CollectionDisplay);
			}
			[Token(Token = "0x6000755")]
			[Address(RVA = "0xDEEC5C", Offset = "0xDEEC5C", VA = "0xDEEC5C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public int MaxDisplayedItems
		{
			[Token(Token = "0x6000756")]
			[Address(RVA = "0xDEEC64", Offset = "0xDEEC64", VA = "0xDEEC64")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000757")]
			[Address(RVA = "0xDEEC6C", Offset = "0xDEEC6C", VA = "0xDEEC6C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public int MaxItemsPerRow
		{
			[Token(Token = "0x6000758")]
			[Address(RVA = "0xDEEC74", Offset = "0xDEEC74", VA = "0xDEEC74")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000759")]
			[Address(RVA = "0xDEEC7C", Offset = "0xDEEC7C", VA = "0xDEEC7C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public bool AlwaysExpanded
		{
			[Token(Token = "0x600075A")]
			[Address(RVA = "0xDEEC84", Offset = "0xDEEC84", VA = "0xDEEC84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600075B")]
			[Address(RVA = "0xDEEC8C", Offset = "0xDEEC8C", VA = "0xDEEC8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public bool ExpandElements
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0xDEEC94", Offset = "0xDEEC94", VA = "0xDEEC94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600075D")]
			[Address(RVA = "0xDEEC9C", Offset = "0xDEEC9C", VA = "0xDEEC9C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public Type EnumType
		{
			[Token(Token = "0x600075E")]
			[Address(RVA = "0xDEECA4", Offset = "0xDEECA4", VA = "0xDEECA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600075F")]
			[Address(RVA = "0xDEECAC", Offset = "0xDEECAC", VA = "0xDEECAC")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public string MethodName
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0xDEF06C", Offset = "0xDEF06C", VA = "0xDEF06C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000761")]
			[Address(RVA = "0xDEF074", Offset = "0xDEF074", VA = "0xDEF074")]
			set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public Type Template
		{
			[Token(Token = "0x6000762")]
			[Address(RVA = "0xDEF07C", Offset = "0xDEF07C", VA = "0xDEF07C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D7")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000763")]
			[Address(RVA = "0xDEF10C", Offset = "0xDEF10C", VA = "0xDEF10C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D8")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x6000764")]
			[Address(RVA = "0xDEF19C", Offset = "0xDEF19C", VA = "0xDEF19C", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000765")]
			[Address(RVA = "0xDEF1A4", Offset = "0xDEF1A4", VA = "0xDEF1A4", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xDEF1AC", Offset = "0xDEF1AC", VA = "0xDEF1AC", Slot = "6")]
		public string[] Invoke(int index, object instance, object value)
		{
			return null;
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xDEF71C", Offset = "0xDEF71C", VA = "0xDEF71C")]
		public CollectionAttribute()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xDEF7DC", Offset = "0xDEF7DC", VA = "0xDEF7DC")]
		public CollectionAttribute(int size)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xDEF868", Offset = "0xDEF868", VA = "0xDEF868")]
		public CollectionAttribute(Type enumType)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xDEF8A4", Offset = "0xDEF8A4", VA = "0xDEF8A4")]
		public CollectionAttribute(bool sortable)
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xDEF8B0", Offset = "0xDEF8B0", VA = "0xDEF8B0")]
		public CollectionAttribute(string methodName)
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xDEF9B8", Offset = "0xDEF9B8", VA = "0xDEF9B8")]
		public CollectionAttribute(CollectionDisplay display)
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xDEF7E4", Offset = "0xDEF7E4", VA = "0xDEF7E4")]
		public CollectionAttribute(int size, bool sortable)
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xDEF888", Offset = "0xDEF888", VA = "0xDEF888")]
		public CollectionAttribute(Type enumType, bool sortable)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xDEFB0C", Offset = "0xDEFB0C", VA = "0xDEFB0C")]
		public CollectionAttribute(int size, CollectionDisplay display)
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xDEFB8C", Offset = "0xDEFB8C", VA = "0xDEFB8C")]
		public CollectionAttribute(Type enumType, CollectionDisplay display)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xDEF8D8", Offset = "0xDEF8D8", VA = "0xDEF8D8")]
		public CollectionAttribute(string methodName, int size, bool sortable, CollectionDisplay display)
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xDEFA34", Offset = "0xDEFA34", VA = "0xDEFA34")]
		public CollectionAttribute(Type enumType, bool sortable, CollectionDisplay display)
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xDEFBAC", Offset = "0xDEFBAC", VA = "0xDEFBAC")]
		public CollectionAttribute(Delegate method)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xDEFCE0", Offset = "0xDEFCE0", VA = "0xDEFCE0")]
		public CollectionAttribute(Delegate method, int size)
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xDEFD04", Offset = "0xDEFD04", VA = "0xDEFD04")]
		public CollectionAttribute(Delegate method, bool sortable)
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xDEFD2C", Offset = "0xDEFD2C", VA = "0xDEFD2C")]
		public CollectionAttribute(Delegate method, CollectionDisplay display)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xDEFBD4", Offset = "0xDEFBD4", VA = "0xDEFBD4")]
		public CollectionAttribute(Delegate method, int size, bool sortable, CollectionDisplay display)
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231EAC", Offset = "0x231EAC")]
	public class ConstructorAttribute : Attribute, IRuntimeAttribute<object>, IRuntimeAttribute
	{
		[Token(Token = "0x2000178")]
		public delegate object ConstructorDelegate();

		[Token(Token = "0x2000179")]
		public delegate object ConstructorStaticDelegate(ConstructorAttribute constructor, object instance, object value);

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string methodName;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private List<Delegate> delegates;

		[Token(Token = "0x170000D9")]
		public string MethodName
		{
			[Token(Token = "0x6000778")]
			[Address(RVA = "0xDF2440", Offset = "0xDF2440", VA = "0xDF2440", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DA")]
		public Type Template
		{
			[Token(Token = "0x6000779")]
			[Address(RVA = "0xDF2448", Offset = "0xDF2448", VA = "0xDF2448", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DB")]
		public Type TemplateStatic
		{
			[Token(Token = "0x600077A")]
			[Address(RVA = "0xDF24D8", Offset = "0xDF24D8", VA = "0xDF24D8", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0xDF2568", Offset = "0xDF2568", VA = "0xDF2568", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600077C")]
			[Address(RVA = "0xDF2570", Offset = "0xDF2570", VA = "0xDF2570", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xDF2578", Offset = "0xDF2578", VA = "0xDF2578", Slot = "6")]
		public object Invoke(int index, object instance, object value)
		{
			return null;
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xDF2A34", Offset = "0xDF2A34", VA = "0xDF2A34")]
		public ConstructorAttribute(string methodName)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xDF2ADC", Offset = "0xDF2ADC", VA = "0xDF2ADC")]
		public ConstructorAttribute(Delegate method)
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231EC0", Offset = "0x231EC0")]
	public class CreateDerivedAttribute : Attribute, IListAttribute
	{
		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool hideClassName;

		[Token(Token = "0x170000DD")]
		public bool HideClassName
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0xDF32E4", Offset = "0xDF32E4", VA = "0xDF32E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000781")]
			[Address(RVA = "0xDF32EC", Offset = "0xDF32EC", VA = "0xDF32EC")]
			set
			{
			}
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xDF32F4", Offset = "0xDF32F4", VA = "0xDF32F4")]
		public CreateDerivedAttribute()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xDF32FC", Offset = "0xDF32FC", VA = "0xDF32FC")]
		public CreateDerivedAttribute(bool hideClassName)
		{
		}
	}
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231ED4", Offset = "0x231ED4")]
	public class DescriptorAttribute : Attribute, IRuntimeAttribute, IDescriptor
	{
		[Token(Token = "0x200017A")]
		public delegate Description DescriptorDelegate();

		[Token(Token = "0x200017B")]
		public delegate Description DescriptorStaticDelegate(DescriptorAttribute descriptor, object instance, object value);

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Color TRANSPARENT;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string name;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private string comment;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string url;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Texture icon;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Color color;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string methodName;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private List<Delegate> delegates;

		[Token(Token = "0x170000DE")]
		public string Name
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0xDF40A0", Offset = "0xDF40A0", VA = "0xDF40A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000785")]
			[Address(RVA = "0xDF40A8", Offset = "0xDF40A8", VA = "0xDF40A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public string Comment
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0xDF40B0", Offset = "0xDF40B0", VA = "0xDF40B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000787")]
			[Address(RVA = "0xDF40B8", Offset = "0xDF40B8", VA = "0xDF40B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public string URL
		{
			[Token(Token = "0x6000788")]
			[Address(RVA = "0xDF40C0", Offset = "0xDF40C0", VA = "0xDF40C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000789")]
			[Address(RVA = "0xDF40C8", Offset = "0xDF40C8", VA = "0xDF40C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public Texture Icon
		{
			[Token(Token = "0x600078A")]
			[Address(RVA = "0xDF40D0", Offset = "0xDF40D0", VA = "0xDF40D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600078B")]
			[Address(RVA = "0xDF40D8", Offset = "0xDF40D8", VA = "0xDF40D8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public Color Color
		{
			[Token(Token = "0x600078C")]
			[Address(RVA = "0xDF40E0", Offset = "0xDF40E0", VA = "0xDF40E0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600078D")]
			[Address(RVA = "0xDF40F0", Offset = "0xDF40F0", VA = "0xDF40F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public string MethodName
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0xDF46A4", Offset = "0xDF46A4", VA = "0xDF46A4", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E4")]
		public Type Template
		{
			[Token(Token = "0x6000790")]
			[Address(RVA = "0xDF46AC", Offset = "0xDF46AC", VA = "0xDF46AC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000791")]
			[Address(RVA = "0xDF473C", Offset = "0xDF473C", VA = "0xDF473C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E6")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x6000792")]
			[Address(RVA = "0xDF47CC", Offset = "0xDF47CC", VA = "0xDF47CC", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000793")]
			[Address(RVA = "0xDF47D4", Offset = "0xDF47D4", VA = "0xDF47D4", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xDF4100", Offset = "0xDF4100", VA = "0xDF4100", Slot = "11")]
		public Description GetDescription(object[] instances, object[] values)
		{
			return null;
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xDF47DC", Offset = "0xDF47DC", VA = "0xDF47DC")]
		public DescriptorAttribute()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xDF48B4", Offset = "0xDF48B4", VA = "0xDF48B4")]
		public DescriptorAttribute(string methodName)
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xDF4994", Offset = "0xDF4994", VA = "0xDF4994")]
		public DescriptorAttribute(float r, float g, float b)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xDF4B74", Offset = "0xDF4B74", VA = "0xDF4B74")]
		public DescriptorAttribute(string name, string description)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xDF4C04", Offset = "0xDF4C04", VA = "0xDF4C04")]
		public DescriptorAttribute(string name, string description, string url)
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xDF4C30", Offset = "0xDF4C30", VA = "0xDF4C30")]
		public DescriptorAttribute(string name, string description, string url, float r, float g, float b)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xDF4A30", Offset = "0xDF4A30", VA = "0xDF4A30")]
		private DescriptorAttribute(string name, string description, string url, float r, float g, float b, float a)
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xDF4C68", Offset = "0xDF4C68", VA = "0xDF4C68")]
		public DescriptorAttribute(string name, string description, Texture icon)
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xDF4D2C", Offset = "0xDF4D2C", VA = "0xDF4D2C")]
		public DescriptorAttribute(string name, string description, Texture icon, Color color)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xDF4E3C", Offset = "0xDF4E3C", VA = "0xDF4E3C")]
		public static Description GetDescriptor(Type type)
		{
			return null;
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xDF4FE8", Offset = "0xDF4FE8", VA = "0xDF4FE8")]
		public static List<Description> GetDescriptors(List<Type> types)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231F00", Offset = "0x231F00")]
	public class DisplayAsParentAttribute : Attribute
	{
		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool hideParent;

		[Token(Token = "0x170000E7")]
		public bool HideParent
		{
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0xDF5970", Offset = "0xDF5970", VA = "0xDF5970")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0xDF5978", Offset = "0xDF5978", VA = "0xDF5978")]
			set
			{
			}
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xDF5980", Offset = "0xDF5980", VA = "0xDF5980")]
		public DisplayAsParentAttribute()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xDF5990", Offset = "0xDF5990", VA = "0xDF5990")]
		public DisplayAsParentAttribute(bool hideParent)
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231F14", Offset = "0x231F14")]
	public class DontAllowSceneObjectAttribute : Attribute, IListAttribute
	{
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xDF59BC", Offset = "0xDF59BC", VA = "0xDF59BC")]
		public DontAllowSceneObjectAttribute()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231F28", Offset = "0x231F28")]
	public class EnumAttribute : Attribute, IListAttribute
	{
		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool masked;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private EnumDisplay display;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int maxItemsPerRow;

		[Token(Token = "0x170000E8")]
		public bool Masked
		{
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0xDF59C4", Offset = "0xDF59C4", VA = "0xDF59C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0xDF59CC", Offset = "0xDF59CC", VA = "0xDF59CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public EnumDisplay Display
		{
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0xDF59D4", Offset = "0xDF59D4", VA = "0xDF59D4")]
			get
			{
				return default(EnumDisplay);
			}
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0xDF59DC", Offset = "0xDF59DC", VA = "0xDF59DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public int MaxItemsPerRow
		{
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0xDF59E4", Offset = "0xDF59E4", VA = "0xDF59E4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0xDF59EC", Offset = "0xDF59EC", VA = "0xDF59EC")]
			set
			{
			}
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xDF59F4", Offset = "0xDF59F4", VA = "0xDF59F4")]
		public EnumAttribute(bool masked)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xDF5A20", Offset = "0xDF5A20", VA = "0xDF5A20")]
		public EnumAttribute(EnumDisplay display)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xDF5A4C", Offset = "0xDF5A4C", VA = "0xDF5A4C")]
		public EnumAttribute(bool masked, EnumDisplay display)
		{
		}
	}
	[Token(Token = "0x20000B4")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231F3C", Offset = "0x231F3C")]
	public class ExpandableAttribute : Attribute, IExpandable, IListAttribute
	{
		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool expanded;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private bool expandable;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private bool alwaysExpanded;

		[Token(Token = "0x170000EB")]
		public bool Expanded
		{
			[Token(Token = "0x60007AE")]
			[Address(RVA = "0xDF5A80", Offset = "0xDF5A80", VA = "0xDF5A80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0xDF5A88", Offset = "0xDF5A88", VA = "0xDF5A88")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public bool Expandable
		{
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0xDF5A90", Offset = "0xDF5A90", VA = "0xDF5A90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xDF5A98", Offset = "0xDF5A98", VA = "0xDF5A98")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public bool AlwaysExpanded
		{
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0xDF5AA0", Offset = "0xDF5AA0", VA = "0xDF5AA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xDF5AA8", Offset = "0xDF5AA8", VA = "0xDF5AA8")]
			set
			{
			}
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xDF5AB0", Offset = "0xDF5AB0", VA = "0xDF5AB0")]
		public ExpandableAttribute()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xDF5AC0", Offset = "0xDF5AC0", VA = "0xDF5AC0")]
		public ExpandableAttribute(bool expandable)
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xDF5AEC", Offset = "0xDF5AEC", VA = "0xDF5AEC")]
		public ExpandableAttribute(bool expandable, bool expanded)
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xDF5B20", Offset = "0xDF5B20", VA = "0xDF5B20", Slot = "6")]
		public bool IsExpandable(object[] instances, object[] values)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xDF5B28", Offset = "0xDF5B28", VA = "0xDF5B28", Slot = "7")]
		public bool IsExpanded(object[] instances, object[] values)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xDF5B30", Offset = "0xDF5B30", VA = "0xDF5B30", Slot = "8")]
		public bool IsAlwaysExpanded(object[] instances, object[] values)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231F68", Offset = "0x231F68")]
	public abstract class FieldAttribute : Attribute
	{
		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int order;

		[Token(Token = "0x170000EE")]
		public int Order
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0xDF5B38", Offset = "0xDF5B38", VA = "0xDF5B38")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0xDF5B40", Offset = "0xDF5B40", VA = "0xDF5B40")]
			set
			{
			}
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xDF5B48", Offset = "0xDF5B48", VA = "0xDF5B48")]
		protected FieldAttribute()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231F7C", Offset = "0x231F7C")]
	public class FieldEditorAttribute : Attribute, IListAttribute
	{
		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string type;

		[Token(Token = "0x170000EF")]
		public string Type
		{
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0xDF5B50", Offset = "0xDF5B50", VA = "0xDF5B50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xDF5B58", Offset = "0xDF5B58", VA = "0xDF5B58")]
		public FieldEditorAttribute(string type)
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231F90", Offset = "0x231F90")]
	public class GroupAttribute : Attribute
	{
		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string name;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private string description;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string style;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int priority;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool expandable;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Color color;

		[Token(Token = "0x170000F0")]
		public string Name
		{
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0xDF6334", Offset = "0xDF6334", VA = "0xDF6334")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0xDF633C", Offset = "0xDF633C", VA = "0xDF633C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public string Description
		{
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0xDF6344", Offset = "0xDF6344", VA = "0xDF6344")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0xDF634C", Offset = "0xDF634C", VA = "0xDF634C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public string Style
		{
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0xDF6354", Offset = "0xDF6354", VA = "0xDF6354")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0xDF635C", Offset = "0xDF635C", VA = "0xDF635C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public int Priority
		{
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0xDF6364", Offset = "0xDF6364", VA = "0xDF6364")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0xDF636C", Offset = "0xDF636C", VA = "0xDF636C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public bool Expandable
		{
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0xDF6374", Offset = "0xDF6374", VA = "0xDF6374")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0xDF637C", Offset = "0xDF637C", VA = "0xDF637C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public Color Color
		{
			[Token(Token = "0x60007C9")]
			[Address(RVA = "0xDF6384", Offset = "0xDF6384", VA = "0xDF6384")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60007CA")]
			[Address(RVA = "0xDF6394", Offset = "0xDF6394", VA = "0xDF6394")]
			set
			{
			}
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xDF63A4", Offset = "0xDF63A4", VA = "0xDF63A4")]
		public GroupAttribute(string name)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xDF64B4", Offset = "0xDF64B4", VA = "0xDF64B4")]
		public GroupAttribute(string name, int priority)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xDF6530", Offset = "0xDF6530", VA = "0xDF6530")]
		public GroupAttribute(string name, string style)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xDF654C", Offset = "0xDF654C", VA = "0xDF654C")]
		public GroupAttribute(string name, float r, float g, float b)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xDF670C", Offset = "0xDF670C", VA = "0xDF670C")]
		public GroupAttribute(string name, float r, float g, float b, float a)
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xDF641C", Offset = "0xDF641C", VA = "0xDF641C")]
		public GroupAttribute(string name, string style, int priority)
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xDF67B4", Offset = "0xDF67B4", VA = "0xDF67B4")]
		public GroupAttribute(string name, string style, float r, float g, float b)
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xDF6860", Offset = "0xDF6860", VA = "0xDF6860")]
		public GroupAttribute(string name, string style, float r, float g, float b, float a)
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xDF690C", Offset = "0xDF690C", VA = "0xDF690C")]
		public GroupAttribute(string name, string style, int priority, float r, float g, float b)
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xDF69B8", Offset = "0xDF69B8", VA = "0xDF69B8")]
		public GroupAttribute(string name, string style, int priority, float r, float g, float b, float a)
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xDF65F4", Offset = "0xDF65F4", VA = "0xDF65F4")]
		public GroupAttribute(string name, string description, string style, int priority, float r, float g, float b, float a)
		{
		}
	}
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231FA4", Offset = "0x231FA4")]
	public class HelpAttribute : Attribute, IRuntimeAttribute, IHelp
	{
		[Token(Token = "0x200017C")]
		public delegate HelpItem HelpDelegate();

		[Token(Token = "0x200017D")]
		public delegate HelpItem HelpStaticDelegate(HelpAttribute help, object instance, object value);

		[Token(Token = "0x4000610")]
		public const string IsNull = "HelpAttribute.IsValueNull";

		[Token(Token = "0x4000611")]
		public const string IsNullOrEmpty = "HelpAttribute.IsStringNullOrEmpty";

		[Token(Token = "0x4000612")]
		public const string IsMatch = "HelpAttribute.IsRegexMatch";

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private HelpType type;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private string message;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HelpPosition position;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private string regex;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string methodName;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private List<Delegate> delegates;

		[Token(Token = "0x170000F6")]
		public HelpType Type
		{
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0xDF6A64", Offset = "0xDF6A64", VA = "0xDF6A64")]
			get
			{
				return default(HelpType);
			}
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0xDF6A6C", Offset = "0xDF6A6C", VA = "0xDF6A6C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public string Message
		{
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0xDF6A74", Offset = "0xDF6A74", VA = "0xDF6A74")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0xDF6A7C", Offset = "0xDF6A7C", VA = "0xDF6A7C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public HelpPosition Position
		{
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0xDF6A84", Offset = "0xDF6A84", VA = "0xDF6A84")]
			get
			{
				return default(HelpPosition);
			}
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0xDF6A8C", Offset = "0xDF6A8C", VA = "0xDF6A8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public string Regex
		{
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0xDF6A94", Offset = "0xDF6A94", VA = "0xDF6A94")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0xDF6A9C", Offset = "0xDF6A9C", VA = "0xDF6A9C")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public string MethodName
		{
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0xDF71F4", Offset = "0xDF71F4", VA = "0xDF71F4", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FB")]
		public Type Template
		{
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0xDF71FC", Offset = "0xDF71FC", VA = "0xDF71FC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		public Type TemplateStatic
		{
			[Token(Token = "0x60007E1")]
			[Address(RVA = "0xDF728C", Offset = "0xDF728C", VA = "0xDF728C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FD")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x60007E2")]
			[Address(RVA = "0xDF731C", Offset = "0xDF731C", VA = "0xDF731C", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007E3")]
			[Address(RVA = "0xDF7324", Offset = "0xDF7324", VA = "0xDF7324", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xDF6AA4", Offset = "0xDF6AA4", VA = "0xDF6AA4", Slot = "11")]
		public IList<HelpItem> GetHelp(object[] instances, object[] values)
		{
			return null;
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xDF732C", Offset = "0xDF732C", VA = "0xDF732C")]
		public HelpAttribute(string methodName)
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xDF746C", Offset = "0xDF746C", VA = "0xDF746C")]
		public HelpAttribute(string methodName, HelpType type, string message)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xDF748C", Offset = "0xDF748C", VA = "0xDF748C")]
		public HelpAttribute(HelpType type, string message)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xDF750C", Offset = "0xDF750C", VA = "0xDF750C")]
		public HelpAttribute(HelpType type, HelpPosition position, string message)
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xDF73AC", Offset = "0xDF73AC", VA = "0xDF73AC")]
		public HelpAttribute(string methodName, HelpType type, HelpPosition position, string message)
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xDF7590", Offset = "0xDF7590", VA = "0xDF7590")]
		public HelpAttribute(Delegate method)
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xDF7664", Offset = "0xDF7664", VA = "0xDF7664")]
		private static HelpItem IsValueNull(HelpAttribute help, object instance, object value)
		{
			return null;
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xDF7808", Offset = "0xDF7808", VA = "0xDF7808")]
		private static HelpItem IsStringNullOrEmpty(HelpAttribute help, object instance, object value)
		{
			return null;
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xDF78F8", Offset = "0xDF78F8", VA = "0xDF78F8")]
		private static HelpItem IsRegexMatch(HelpAttribute help, object instance, object value)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B9")]
	public enum HelpType
	{
		[Token(Token = "0x400061A")]
		None,
		[Token(Token = "0x400061B")]
		Info,
		[Token(Token = "0x400061C")]
		Warning,
		[Token(Token = "0x400061D")]
		Error
	}
	[Token(Token = "0x20000BA")]
	public enum HelpPosition
	{
		[Token(Token = "0x400061F")]
		After,
		[Token(Token = "0x4000620")]
		Before
	}
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231FD0", Offset = "0x231FD0")]
	public class IgnoreBase : Attribute
	{
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xDF82A4", Offset = "0xDF82A4", VA = "0xDF82A4")]
		public IgnoreBase()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231FE4", Offset = "0x231FE4")]
	public class InspectAttribute : Attribute, IRuntimeAttribute, IVisibility
	{
		[Token(Token = "0x200017E")]
		public delegate bool InspectDelegate();

		[Token(Token = "0x200017F")]
		public delegate bool InspectStaticDelegate(InspectAttribute inspect, object instance, object value);

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private InspectorLevel level;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private bool condition;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int priority;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private string methodName;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<Delegate> delegates;

		[Token(Token = "0x170000FE")]
		public InspectorLevel Level
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0xDF82AC", Offset = "0xDF82AC", VA = "0xDF82AC")]
			get
			{
				return default(InspectorLevel);
			}
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0xDF82B4", Offset = "0xDF82B4", VA = "0xDF82B4")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public bool Condition
		{
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0xDF82BC", Offset = "0xDF82BC", VA = "0xDF82BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0xDF82C4", Offset = "0xDF82C4", VA = "0xDF82C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public int Priority
		{
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0xDF82CC", Offset = "0xDF82CC", VA = "0xDF82CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0xDF82D4", Offset = "0xDF82D4", VA = "0xDF82D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public string MethodName
		{
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0xDF8CF8", Offset = "0xDF8CF8", VA = "0xDF8CF8", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0xDF8D00", Offset = "0xDF8D00", VA = "0xDF8D00")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public Type Template
		{
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0xDF8D08", Offset = "0xDF8D08", VA = "0xDF8D08", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000103")]
		public Type TemplateStatic
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0xDF8D98", Offset = "0xDF8D98", VA = "0xDF8D98", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000104")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0xDF8E28", Offset = "0xDF8E28", VA = "0xDF8E28", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0xDF8E30", Offset = "0xDF8E30", VA = "0xDF8E30", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xDF82DC", Offset = "0xDF82DC", VA = "0xDF82DC", Slot = "11")]
		public bool IsItemVisible(object[] instances, object[] values)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xDF8CE8", Offset = "0xDF8CE8", VA = "0xDF8CE8", Slot = "12")]
		public InspectorLevel GetItemLevel(object[] parents, object[] values)
		{
			return default(InspectorLevel);
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xDF8CF0", Offset = "0xDF8CF0", VA = "0xDF8CF0", Slot = "13")]
		public int GetItemPriority(object[] parents, object[] values)
		{
			return default(int);
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xDF8E38", Offset = "0xDF8E38", VA = "0xDF8E38")]
		public InspectAttribute()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xDF8F7C", Offset = "0xDF8F7C", VA = "0xDF8F7C")]
		public InspectAttribute(int priority)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xDF8FF8", Offset = "0xDF8FF8", VA = "0xDF8FF8")]
		public InspectAttribute(InspectorLevel level)
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xDF9078", Offset = "0xDF9078", VA = "0xDF9078")]
		public InspectAttribute(InspectorLevel level, int priority)
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xDF90F8", Offset = "0xDF90F8", VA = "0xDF90F8")]
		public InspectAttribute(InspectorLevel level, string methodName)
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xDF911C", Offset = "0xDF911C", VA = "0xDF911C")]
		public InspectAttribute(InspectorLevel level, string methodName, int priority)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xDF913C", Offset = "0xDF913C", VA = "0xDF913C")]
		public InspectAttribute(InspectorLevel level, string methodName, bool condition)
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xDF915C", Offset = "0xDF915C", VA = "0xDF915C")]
		public InspectAttribute(string methodName)
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xDF9188", Offset = "0xDF9188", VA = "0xDF9188")]
		public InspectAttribute(string methodName, int priority)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xDF91B4", Offset = "0xDF91B4", VA = "0xDF91B4")]
		public InspectAttribute(string methodName, bool condition)
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xDF91E0", Offset = "0xDF91E0", VA = "0xDF91E0")]
		public InspectAttribute(string methodName, bool condition, int priority)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xDF8EB4", Offset = "0xDF8EB4", VA = "0xDF8EB4")]
		public InspectAttribute(InspectorLevel level, string methodName, bool condition, int priority)
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xDF920C", Offset = "0xDF920C", VA = "0xDF920C")]
		public InspectAttribute(Delegate method)
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xDF932C", Offset = "0xDF932C", VA = "0xDF932C")]
		public InspectAttribute(Delegate method, int priority)
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xDF9358", Offset = "0xDF9358", VA = "0xDF9358")]
		public InspectAttribute(Delegate method, bool condition)
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xDF9384", Offset = "0xDF9384", VA = "0xDF9384")]
		public InspectAttribute(Delegate method, bool condition, int priority)
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xDF93B0", Offset = "0xDF93B0", VA = "0xDF93B0")]
		public InspectAttribute(InspectorLevel level, Delegate method)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xDF93D4", Offset = "0xDF93D4", VA = "0xDF93D4")]
		public InspectAttribute(InspectorLevel level, Delegate method, int priority)
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xDF9238", Offset = "0xDF9238", VA = "0xDF9238")]
		public InspectAttribute(InspectorLevel level, Delegate method, bool condition, int priority)
		{
		}
	}
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x231FF8", Offset = "0x231FF8")]
	public class MenuAttribute : Attribute, IListAttribute, IMenu, IRuntimeAttribute
	{
		[Token(Token = "0x2000180")]
		public delegate void MenuDelegate();

		[Token(Token = "0x2000181")]
		public delegate void MenuStaticDelegate(MenuAttribute fieldMenuItem, object instance, object value);

		[Token(Token = "0x2000182")]
		public delegate bool MenuEnabledDelegate();

		[Token(Token = "0x2000183")]
		public delegate bool MenuIsOnDelegate();

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string menuItemName;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private bool enabled;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private MenuEnabledDelegate enabledDelegate;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool isOn;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MenuIsOnDelegate isOnDelegate;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private string methodName;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Delegate> delegates;

		[Token(Token = "0x17000105")]
		public string MenuItemName
		{
			[Token(Token = "0x6000810")]
			[Address(RVA = "0xDFA050", Offset = "0xDFA050", VA = "0xDFA050", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		public bool Enabled
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0xDFA058", Offset = "0xDFA058", VA = "0xDFA058", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000107")]
		public bool IsOn
		{
			[Token(Token = "0x6000812")]
			[Address(RVA = "0xDFA2BC", Offset = "0xDFA2BC", VA = "0xDFA2BC", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000108")]
		public string MethodName
		{
			[Token(Token = "0x6000813")]
			[Address(RVA = "0xDFA520", Offset = "0xDFA520", VA = "0xDFA520", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000109")]
		public Type Template
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0xDFA528", Offset = "0xDFA528", VA = "0xDFA528", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010A")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000815")]
			[Address(RVA = "0xDFA5B8", Offset = "0xDFA5B8", VA = "0xDFA5B8", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010B")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0xDFA648", Offset = "0xDFA648", VA = "0xDFA648", Slot = "13")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000817")]
			[Address(RVA = "0xDFA650", Offset = "0xDFA650", VA = "0xDFA650", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xDFA658", Offset = "0xDFA658", VA = "0xDFA658", Slot = "6")]
		public void Invoke(int index, object instance, object value)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xDFAB04", Offset = "0xDFAB04", VA = "0xDFAB04")]
		public MenuAttribute(string menuItemName, string methodName)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xDFABC0", Offset = "0xDFABC0", VA = "0xDFABC0")]
		public MenuAttribute(string menuItemName, Delegate method)
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xDFACDC", Offset = "0xDFACDC", VA = "0xDFACDC")]
		public MenuAttribute(string menuItemName, Delegate method, MenuEnabledDelegate enabledDelegate)
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xDFABE4", Offset = "0xDFABE4", VA = "0xDFABE4")]
		public MenuAttribute(string menuItemName, Delegate method, MenuEnabledDelegate enabledDelegate, MenuIsOnDelegate isOnDelegate)
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x23200C", Offset = "0x23200C")]
	public class MethodAttribute : Attribute
	{
		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private MethodDisplay display;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private string undoMessageOnClick;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool isCoroutine;

		[Token(Token = "0x1700010C")]
		public MethodDisplay Display
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0xDFB508", Offset = "0xDFB508", VA = "0xDFB508")]
			get
			{
				return default(MethodDisplay);
			}
			[Token(Token = "0x600081E")]
			[Address(RVA = "0xDFB510", Offset = "0xDFB510", VA = "0xDFB510")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public string UndoMessageOnClick
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0xDFB518", Offset = "0xDFB518", VA = "0xDFB518")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000820")]
			[Address(RVA = "0xDFB520", Offset = "0xDFB520", VA = "0xDFB520")]
			set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public bool IsCoroutine
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0xDFB528", Offset = "0xDFB528", VA = "0xDFB528")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000822")]
			[Address(RVA = "0xDFB530", Offset = "0xDFB530", VA = "0xDFB530")]
			set
			{
			}
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xDFB538", Offset = "0xDFB538", VA = "0xDFB538")]
		public MethodAttribute()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xDFB5A4", Offset = "0xDFB5A4", VA = "0xDFB5A4")]
		public MethodAttribute(MethodDisplay display)
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xDFB618", Offset = "0xDFB618", VA = "0xDFB618")]
		public MethodAttribute(bool isCoroutine)
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xDFB708", Offset = "0xDFB708", VA = "0xDFB708")]
		public MethodAttribute(string undoMessageOnClick)
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xDFB684", Offset = "0xDFB684", VA = "0xDFB684")]
		public MethodAttribute(bool isCoroutine, string undoMessageOnClick)
		{
		}
	}
	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x232020", Offset = "0x232020")]
	public class NoPicker : Attribute, IPicker, IListAttribute
	{
		[Token(Token = "0x6000828")]
		[Address(RVA = "0xDFB714", Offset = "0xDFB714", VA = "0xDFB714", Slot = "6")]
		public bool IsPickingAvailable(object[] instances, object[] values)
		{
			return default(bool);
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xDFB71C", Offset = "0xDFB71C", VA = "0xDFB71C")]
		public NoPicker()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x232034", Offset = "0x232034")]
	public class RangeValueAttribute : Attribute, IListAttribute
	{
		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private float min;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private float max;

		[Token(Token = "0x1700010F")]
		public float Min
		{
			[Token(Token = "0x600082A")]
			[Address(RVA = "0xDFBBA4", Offset = "0xDFBBA4", VA = "0xDFBBA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600082B")]
			[Address(RVA = "0xDFBBAC", Offset = "0xDFBBAC", VA = "0xDFBBAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public float Max
		{
			[Token(Token = "0x600082C")]
			[Address(RVA = "0xDFBBB4", Offset = "0xDFBBB4", VA = "0xDFBBB4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600082D")]
			[Address(RVA = "0xDFBBBC", Offset = "0xDFBBBC", VA = "0xDFBBBC")]
			set
			{
			}
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xDFBBC4", Offset = "0xDFBBC4", VA = "0xDFBBC4")]
		public RangeValueAttribute(float min, float max)
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x232048", Offset = "0x232048")]
	public class ReadOnlyAttribute : Attribute, IReadOnly, IListAttribute, IRuntimeAttribute<bool>, IRuntimeAttribute
	{
		[Token(Token = "0x2000184")]
		public delegate bool ReadOnlyDelegate();

		[Token(Token = "0x2000185")]
		public delegate bool ReadOnlyStaticDelegate(ReadOnlyAttribute readOnly, object instance, object value);

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool condition;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private string methodName;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<Delegate> delegates;

		[Token(Token = "0x17000111")]
		public bool Condition
		{
			[Token(Token = "0x600082F")]
			[Address(RVA = "0xDFBBEC", Offset = "0xDFBBEC", VA = "0xDFBBEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000830")]
			[Address(RVA = "0xDFBBF4", Offset = "0xDFBBF4", VA = "0xDFBBF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000112")]
		public string MethodName
		{
			[Token(Token = "0x6000831")]
			[Address(RVA = "0xDFBBFC", Offset = "0xDFBBFC", VA = "0xDFBBFC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000113")]
		public Type Template
		{
			[Token(Token = "0x6000832")]
			[Address(RVA = "0xDFBC04", Offset = "0xDFBC04", VA = "0xDFBC04", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000114")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000833")]
			[Address(RVA = "0xDFBC94", Offset = "0xDFBC94", VA = "0xDFBC94", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000115")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x6000834")]
			[Address(RVA = "0xDFBD24", Offset = "0xDFBD24", VA = "0xDFBD24", Slot = "11")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000835")]
			[Address(RVA = "0xDFBD2C", Offset = "0xDFBD2C", VA = "0xDFBD2C", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xDFBD34", Offset = "0xDFBD34", VA = "0xDFBD34", Slot = "7")]
		public bool Invoke(int index, object instance, object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xDFC60C", Offset = "0xDFC60C", VA = "0xDFC60C", Slot = "6")]
		public bool IsReadOnly(object[] instances, object[] values)
		{
			return default(bool);
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xDFC7F8", Offset = "0xDFC7F8", VA = "0xDFC7F8")]
		public ReadOnlyAttribute()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xDFC8A0", Offset = "0xDFC8A0", VA = "0xDFC8A0")]
		public ReadOnlyAttribute(bool condition)
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xDFC950", Offset = "0xDFC950", VA = "0xDFC950")]
		public ReadOnlyAttribute(Delegate method)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xDFC958", Offset = "0xDFC958", VA = "0xDFC958")]
		public ReadOnlyAttribute(Delegate method, bool condition)
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xDFCA3C", Offset = "0xDFCA3C", VA = "0xDFCA3C")]
		public ReadOnlyAttribute(string methodName)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xDFCA44", Offset = "0xDFCA44", VA = "0xDFCA44")]
		public ReadOnlyAttribute(string methodName, bool condition)
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x232074", Offset = "0x232074")]
	public class RestrictAttribute : Attribute, IRestrict, IListAttribute, IRuntimeAttribute
	{
		[Token(Token = "0x2000186")]
		public delegate IList RestrictDelegate();

		[Token(Token = "0x2000187")]
		public delegate IList RestrictStaticDelegate(RestrictAttribute restrict, object instance, object value);

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private RestrictDisplay display;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int maxItemsPerRow;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string methodName;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private List<Delegate> delegates;

		[Token(Token = "0x17000116")]
		public RestrictDisplay Display
		{
			[Token(Token = "0x600083E")]
			[Address(RVA = "0xDFD280", Offset = "0xDFD280", VA = "0xDFD280")]
			get
			{
				return default(RestrictDisplay);
			}
			[Token(Token = "0x600083F")]
			[Address(RVA = "0xDFD288", Offset = "0xDFD288", VA = "0xDFD288")]
			set
			{
			}
		}

		[Token(Token = "0x17000117")]
		public int MaxItemsPerRow
		{
			[Token(Token = "0x6000840")]
			[Address(RVA = "0xDFD290", Offset = "0xDFD290", VA = "0xDFD290")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000841")]
			[Address(RVA = "0xDFD298", Offset = "0xDFD298", VA = "0xDFD298")]
			set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public string MethodName
		{
			[Token(Token = "0x6000845")]
			[Address(RVA = "0xDFD7D8", Offset = "0xDFD7D8", VA = "0xDFD7D8", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000119")]
		public Type Template
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0xDFD7E0", Offset = "0xDFD7E0", VA = "0xDFD7E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011A")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000847")]
			[Address(RVA = "0xDFD870", Offset = "0xDFD870", VA = "0xDFD870", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011B")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0xDFD900", Offset = "0xDFD900", VA = "0xDFD900", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000849")]
			[Address(RVA = "0xDFD908", Offset = "0xDFD908", VA = "0xDFD908", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xDFD2A0", Offset = "0xDFD2A0", VA = "0xDFD2A0", Slot = "6")]
		public IList GetRestricted(object[] instances, object[] values)
		{
			return null;
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xDFD7C8", Offset = "0xDFD7C8", VA = "0xDFD7C8", Slot = "7")]
		public RestrictDisplay GetDisplay(object[] instances, object[] values)
		{
			return default(RestrictDisplay);
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xDFD7D0", Offset = "0xDFD7D0", VA = "0xDFD7D0", Slot = "8")]
		public int GetItemsPerRow(object[] instances, object[] values)
		{
			return default(int);
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xDFD910", Offset = "0xDFD910", VA = "0xDFD910")]
		public RestrictAttribute(string methodName)
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xDFD918", Offset = "0xDFD918", VA = "0xDFD918")]
		public RestrictAttribute(string methodName, RestrictDisplay display)
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xDFD9D0", Offset = "0xDFD9D0", VA = "0xDFD9D0")]
		public RestrictAttribute(Delegate method)
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xDFD9D8", Offset = "0xDFD9D8", VA = "0xDFD9D8")]
		public RestrictAttribute(Delegate method, RestrictDisplay display)
		{
		}
	}
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x232088", Offset = "0x232088")]
	public class RuntimeResolveAttribute : Attribute, IListAttribute, IRuntimeAttribute<Type>, IRuntimeAttribute, IRuntimeType
	{
		[Token(Token = "0x2000188")]
		public delegate Type RuntimeResolveDelegate();

		[Token(Token = "0x2000189")]
		public delegate Type RuntimeResolveStaticDelegate(RuntimeResolveAttribute runtimeResolve, object instance, object value);

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string methodName;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private List<Delegate> delegates;

		[Token(Token = "0x1700011C")]
		public string MethodName
		{
			[Token(Token = "0x600084F")]
			[Address(RVA = "0xDFE988", Offset = "0xDFE988", VA = "0xDFE988", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011D")]
		public Type Template
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0xDFE990", Offset = "0xDFE990", VA = "0xDFE990", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011E")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000851")]
			[Address(RVA = "0xDFEA20", Offset = "0xDFEA20", VA = "0xDFEA20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011F")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0xDFEAB0", Offset = "0xDFEAB0", VA = "0xDFEAB0", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000853")]
			[Address(RVA = "0xDFEAB8", Offset = "0xDFEAB8", VA = "0xDFEAB8", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xDFE1E8", Offset = "0xDFE1E8", VA = "0xDFE1E8", Slot = "12")]
		public Type GetType(object[] instances, object[] values)
		{
			return null;
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xDFE474", Offset = "0xDFE474", VA = "0xDFE474", Slot = "6")]
		public Type Invoke(int index, object instance, object value)
		{
			return null;
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xDFEAC0", Offset = "0xDFEAC0", VA = "0xDFEAC0")]
		public RuntimeResolveAttribute()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xDFEB60", Offset = "0xDFEB60", VA = "0xDFEB60")]
		public RuntimeResolveAttribute(string methodName)
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xDFEC08", Offset = "0xDFEC08", VA = "0xDFEC08")]
		public RuntimeResolveAttribute(Delegate method)
		{
		}
	}
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x23209C", Offset = "0x23209C")]
	public class SpacingAttribute : Attribute, ISpacing
	{
		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int before;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int after;

		[Token(Token = "0x17000120")]
		public int Before
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0xE00B50", Offset = "0xE00B50", VA = "0xE00B50")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000859")]
			[Address(RVA = "0xE00B58", Offset = "0xE00B58", VA = "0xE00B58")]
			set
			{
			}
		}

		[Token(Token = "0x17000121")]
		public int After
		{
			[Token(Token = "0x600085A")]
			[Address(RVA = "0xE00B60", Offset = "0xE00B60", VA = "0xE00B60")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600085B")]
			[Address(RVA = "0xE00B68", Offset = "0xE00B68", VA = "0xE00B68")]
			set
			{
			}
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xE00B70", Offset = "0xE00B70", VA = "0xE00B70")]
		public SpacingAttribute()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xE00B78", Offset = "0xE00B78", VA = "0xE00B78")]
		public SpacingAttribute(int after)
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xE00B98", Offset = "0xE00B98", VA = "0xE00B98")]
		public SpacingAttribute(int before, int after)
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xE00BC0", Offset = "0xE00BC0", VA = "0xE00BC0", Slot = "6")]
		public int GetAfter(object[] instances, object[] values)
		{
			return default(int);
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xE00BC8", Offset = "0xE00BC8", VA = "0xE00BC8", Slot = "7")]
		public int GetBefore(object[] instances, object[] values)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x2320B0", Offset = "0x2320B0")]
	public class StyleAttribute : Attribute
	{
		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string style;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private bool label;

		[Token(Token = "0x17000122")]
		public string Style
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0xE01040", Offset = "0xE01040", VA = "0xE01040")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000862")]
			[Address(RVA = "0xE01048", Offset = "0xE01048", VA = "0xE01048")]
			set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public bool Label
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0xE01050", Offset = "0xE01050", VA = "0xE01050")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000864")]
			[Address(RVA = "0xE01058", Offset = "0xE01058", VA = "0xE01058")]
			set
			{
			}
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xE01060", Offset = "0xE01060", VA = "0xE01060")]
		public StyleAttribute(string style)
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xE01068", Offset = "0xE01068", VA = "0xE01068")]
		public StyleAttribute(string style, bool label)
		{
		}
	}
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x2320C4", Offset = "0x2320C4")]
	public class TabAttribute : Attribute, IRuntimeAttribute<Enum>, IRuntimeAttribute
	{
		[Token(Token = "0x200018A")]
		public delegate Enum DescriptorDelegate();

		[Token(Token = "0x200018B")]
		public delegate Enum DescriptorStaticDelegate(TabAttribute descriptor, object instance, object value);

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private Enum tab;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private string methodName;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<Delegate> delegates;

		[Token(Token = "0x17000124")]
		public Enum Tab
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0xE010EC", Offset = "0xE010EC", VA = "0xE010EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000868")]
			[Address(RVA = "0xE010F4", Offset = "0xE010F4", VA = "0xE010F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public string MethodName
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0xE010FC", Offset = "0xE010FC", VA = "0xE010FC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000126")]
		public Type Template
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0xE01104", Offset = "0xE01104", VA = "0xE01104", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000127")]
		public Type TemplateStatic
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0xE01194", Offset = "0xE01194", VA = "0xE01194", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000128")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0xE01224", Offset = "0xE01224", VA = "0xE01224", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086D")]
			[Address(RVA = "0xE0122C", Offset = "0xE0122C", VA = "0xE0122C", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xE01234", Offset = "0xE01234", VA = "0xE01234", Slot = "6")]
		public Enum Invoke(int index, object instance, object value)
		{
			return null;
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xE0178C", Offset = "0xE0178C", VA = "0xE0178C")]
		public TabAttribute(object tab)
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xE01888", Offset = "0xE01888", VA = "0xE01888")]
		public TabAttribute(string methodName)
		{
		}
	}
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x2320D8", Offset = "0x2320D8")]
	public class TextFieldAttribute : Attribute, IListAttribute
	{
		[Token(Token = "0x4000642")]
		private const string TITLE = "Select Path...";

		[Token(Token = "0x4000643")]
		private const string PATH = "";

		[Token(Token = "0x4000644")]
		private const string EXTENSION = "";

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string title;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private string path;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string extension;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private TextFieldType type;

		[Token(Token = "0x17000129")]
		public string Title
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0xE0205C", Offset = "0xE0205C", VA = "0xE0205C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000872")]
			[Address(RVA = "0xE02064", Offset = "0xE02064", VA = "0xE02064")]
			set
			{
			}
		}

		[Token(Token = "0x1700012A")]
		public string Path
		{
			[Token(Token = "0x6000873")]
			[Address(RVA = "0xE0206C", Offset = "0xE0206C", VA = "0xE0206C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000874")]
			[Address(RVA = "0xE02074", Offset = "0xE02074", VA = "0xE02074")]
			set
			{
			}
		}

		[Token(Token = "0x1700012B")]
		public string Extension
		{
			[Token(Token = "0x6000875")]
			[Address(RVA = "0xE0207C", Offset = "0xE0207C", VA = "0xE0207C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000876")]
			[Address(RVA = "0xE02084", Offset = "0xE02084", VA = "0xE02084")]
			set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		public TextFieldType Type
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0xE0208C", Offset = "0xE0208C", VA = "0xE0208C")]
			get
			{
				return default(TextFieldType);
			}
			[Token(Token = "0x6000878")]
			[Address(RVA = "0xE02094", Offset = "0xE02094", VA = "0xE02094")]
			set
			{
			}
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xE0209C", Offset = "0xE0209C", VA = "0xE0209C")]
		public TextFieldAttribute(TextFieldType type)
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xE021C8", Offset = "0xE021C8", VA = "0xE021C8")]
		public TextFieldAttribute(TextFieldType type, string title)
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xE02248", Offset = "0xE02248", VA = "0xE02248")]
		public TextFieldAttribute(TextFieldType type, string title, string path)
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xE02124", Offset = "0xE02124", VA = "0xE02124")]
		public TextFieldAttribute(TextFieldType type, string title, string path, string extension)
		{
		}
	}
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x2320EC", Offset = "0x2320EC")]
	public class TitleAttribute : Attribute, IRuntimeAttribute<TitleAttribute>, IRuntimeAttribute
	{
		[Token(Token = "0x200018C")]
		public delegate TitleAttribute TitleDelegate();

		[Token(Token = "0x200018D")]
		public delegate TitleAttribute TitleStaticDelegate(TitleAttribute title, object instance, object value);

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string message;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private FontStyle style;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string methodName;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private List<Delegate> delegates;

		[Token(Token = "0x1700012D")]
		public string Message
		{
			[Token(Token = "0x600087D")]
			[Address(RVA = "0xE022D0", Offset = "0xE022D0", VA = "0xE022D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600087E")]
			[Address(RVA = "0xE022D8", Offset = "0xE022D8", VA = "0xE022D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700012E")]
		public FontStyle Style
		{
			[Token(Token = "0x600087F")]
			[Address(RVA = "0xE022E0", Offset = "0xE022E0", VA = "0xE022E0")]
			get
			{
				return default(FontStyle);
			}
			[Token(Token = "0x6000880")]
			[Address(RVA = "0xE022E8", Offset = "0xE022E8", VA = "0xE022E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700012F")]
		public string MethodName
		{
			[Token(Token = "0x6000881")]
			[Address(RVA = "0xE022F0", Offset = "0xE022F0", VA = "0xE022F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000130")]
		public Type Template
		{
			[Token(Token = "0x6000882")]
			[Address(RVA = "0xE022F8", Offset = "0xE022F8", VA = "0xE022F8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000131")]
		public Type TemplateStatic
		{
			[Token(Token = "0x6000883")]
			[Address(RVA = "0xE02388", Offset = "0xE02388", VA = "0xE02388", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000132")]
		public List<Delegate> Delegates
		{
			[Token(Token = "0x6000884")]
			[Address(RVA = "0xE02418", Offset = "0xE02418", VA = "0xE02418", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000885")]
			[Address(RVA = "0xE02420", Offset = "0xE02420", VA = "0xE02420", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xE02428", Offset = "0xE02428", VA = "0xE02428", Slot = "6")]
		public TitleAttribute Invoke(int index, object instance, object value)
		{
			return null;
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xE02928", Offset = "0xE02928", VA = "0xE02928")]
		public TitleAttribute(string methodName)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xE029D8", Offset = "0xE029D8", VA = "0xE029D8")]
		public TitleAttribute(FontStyle style, string message)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0xE02A90", Offset = "0xE02A90", VA = "0xE02A90")]
		public TitleAttribute(Delegate method)
		{
		}
	}
	[Token(Token = "0x20000C9")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x232100", Offset = "0x232100")]
	public class ToolbarAttribute : Attribute
	{
		[Token(Token = "0x400064D")]
		public const string ToolbarStyle = "Toolbar";

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string name;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private string style;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool label;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool flexible;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int priority;

		[Token(Token = "0x17000133")]
		public string Name
		{
			[Token(Token = "0x600088A")]
			[Address(RVA = "0xE03298", Offset = "0xE03298", VA = "0xE03298")]
			get
			{
				return null;
			}
			[Token(Token = "0x600088B")]
			[Address(RVA = "0xE032A0", Offset = "0xE032A0", VA = "0xE032A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public string Style
		{
			[Token(Token = "0x600088C")]
			[Address(RVA = "0xE032A8", Offset = "0xE032A8", VA = "0xE032A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600088D")]
			[Address(RVA = "0xE032B0", Offset = "0xE032B0", VA = "0xE032B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public bool Label
		{
			[Token(Token = "0x600088E")]
			[Address(RVA = "0xE032B8", Offset = "0xE032B8", VA = "0xE032B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600088F")]
			[Address(RVA = "0xE032C0", Offset = "0xE032C0", VA = "0xE032C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public bool Flexible
		{
			[Token(Token = "0x6000890")]
			[Address(RVA = "0xE032C8", Offset = "0xE032C8", VA = "0xE032C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000891")]
			[Address(RVA = "0xE032D0", Offset = "0xE032D0", VA = "0xE032D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public int Priority
		{
			[Token(Token = "0x6000892")]
			[Address(RVA = "0xE032D8", Offset = "0xE032D8", VA = "0xE032D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000893")]
			[Address(RVA = "0xE032E0", Offset = "0xE032E0", VA = "0xE032E0")]
			set
			{
			}
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xE032E8", Offset = "0xE032E8", VA = "0xE032E8")]
		public ToolbarAttribute(string name)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0xE03404", Offset = "0xE03404", VA = "0xE03404")]
		public ToolbarAttribute(string name, int priority)
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xE03488", Offset = "0xE03488", VA = "0xE03488")]
		public ToolbarAttribute(string name, string style)
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xE034B0", Offset = "0xE034B0", VA = "0xE034B0")]
		public ToolbarAttribute(string name, string style, int priority)
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xE034D8", Offset = "0xE034D8", VA = "0xE034D8")]
		public ToolbarAttribute(string name, bool label)
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xE03560", Offset = "0xE03560", VA = "0xE03560")]
		public ToolbarAttribute(string name, bool label, int priority)
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xE035E8", Offset = "0xE035E8", VA = "0xE035E8")]
		public ToolbarAttribute(string name, string style, bool label)
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xE0360C", Offset = "0xE0360C", VA = "0xE0360C")]
		public ToolbarAttribute(string name, string style, bool label, int priority)
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xE03634", Offset = "0xE03634", VA = "0xE03634")]
		public ToolbarAttribute(string name, string style, bool label, bool flexible)
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xE0336C", Offset = "0xE0336C", VA = "0xE0336C")]
		public ToolbarAttribute(string name, string style, bool label, bool flexible, int priority)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "AdvancedInspectorAttribute", RVA = "0x232114", Offset = "0x232114")]
	public class ActionBinding : ICopiable
	{
		[Serializable]
		[Token(Token = "0x200018E")]
		[AttributeAttribute(Name = "AdvancedInspectorAttribute", RVA = "0x2322B0", Offset = "0x2322B0")]
		public class BindingParameter : ICopy, ICopiable
		{
			[Token(Token = "0x200019E")]
			public enum BindingType
			{
				[Token(Token = "0x4000993")]
				Internal,
				[Token(Token = "0x4000994")]
				Static,
				[Token(Token = "0x4000995")]
				External
			}

			[Token(Token = "0x200019F")]
			private enum BindingValueType
			{
				[Token(Token = "0x4000997")]
				None,
				[Token(Token = "0x4000998")]
				Boolean,
				[Token(Token = "0x4000999")]
				Integer,
				[Token(Token = "0x400099A")]
				Float,
				[Token(Token = "0x400099B")]
				String,
				[Token(Token = "0x400099C")]
				Vector2,
				[Token(Token = "0x400099D")]
				Vector3,
				[Token(Token = "0x400099E")]
				Vector4,
				[Token(Token = "0x400099F")]
				Color,
				[Token(Token = "0x40009A0")]
				Rect,
				[Token(Token = "0x40009A1")]
				Bounds,
				[Token(Token = "0x40009A2")]
				Reference
			}

			[Token(Token = "0x4000950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "InspectAttribute", RVA = "0x23CD34", Offset = "0x23CD34")]
			[AttributeAttribute(Name = "RestrictAttribute", RVA = "0x23CD34", Offset = "0x23CD34")]
			public BindingType binding;

			[Token(Token = "0x4000951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private bool canBeInternal;

			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private BindingValueType type;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			private string qualifiedTypeName;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private bool boolValue;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private int intValue;

			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float floatValue;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[SerializeField]
			private string stringValue;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Vector2 vector2Value;

			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Vector3 vector3Value;

			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[SerializeField]
			private Vector4 vector4Value;

			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[SerializeField]
			private Color colorValue;

			[Token(Token = "0x400095C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[SerializeField]
			private Rect rectValue;

			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[SerializeField]
			private Bounds boundsValue;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[SerializeField]
			private UnityEngine.Object referenceValue;

			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[SerializeField]
			private GameObject gameObject;

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[SerializeField]
			private Component component;

			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[SerializeField]
			private string method;

			[Token(Token = "0x170001BA")]
			private bool CanBeInternal
			{
				[Token(Token = "0x6000BC2")]
				[Address(RVA = "0xDEB3F4", Offset = "0xDEB3F4", VA = "0xDEB3F4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170001BB")]
			public Type Type
			{
				[Token(Token = "0x6000BC3")]
				[Address(RVA = "0xDE9E24", Offset = "0xDE9E24", VA = "0xDE9E24")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000BC4")]
				[Address(RVA = "0xDE8950", Offset = "0xDE8950", VA = "0xDE8950")]
				set
				{
				}
			}

			[Token(Token = "0x170001BC")]
			[AttributeAttribute(Name = "InspectAttribute", RVA = "0x24083C", Offset = "0x24083C")]
			public string BoundType
			{
				[Token(Token = "0x6000BC5")]
				[Address(RVA = "0xDEB3FC", Offset = "0xDEB3FC", VA = "0xDEB3FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001BD")]
			[AttributeAttribute(Name = "InspectAttribute", RVA = "0x240850", Offset = "0x240850")]
			[AttributeAttribute(Name = "RuntimeResolveAttribute", RVA = "0x240850", Offset = "0x240850")]
			public object Value
			{
				[Token(Token = "0x6000BC6")]
				[Address(RVA = "0xDEA58C", Offset = "0xDEA58C", VA = "0xDEA58C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000BC7")]
				[Address(RVA = "0xDEB638", Offset = "0xDEB638", VA = "0xDEB638")]
				set
				{
				}
			}

			[Token(Token = "0x170001BE")]
			[AttributeAttribute(Name = "InspectAttribute", RVA = "0x2408BC", Offset = "0x2408BC")]
			public GameObject GameObject
			{
				[Token(Token = "0x6000BC8")]
				[Address(RVA = "0xDEB998", Offset = "0xDEB998", VA = "0xDEB998")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000BC9")]
				[Address(RVA = "0xDEB9A0", Offset = "0xDEB9A0", VA = "0xDEB9A0")]
				set
				{
				}
			}

			[Token(Token = "0x170001BF")]
			[AttributeAttribute(Name = "InspectAttribute", RVA = "0x2408F0", Offset = "0x2408F0")]
			[AttributeAttribute(Name = "RestrictAttribute", RVA = "0x2408F0", Offset = "0x2408F0")]
			public Component Component
			{
				[Token(Token = "0x6000BCA")]
				[Address(RVA = "0xDEBAF0", Offset = "0xDEBAF0", VA = "0xDEBAF0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000BCB")]
				[Address(RVA = "0xDEBA48", Offset = "0xDEBA48", VA = "0xDEBA48")]
				set
				{
				}
			}

			[Token(Token = "0x170001C0")]
			[AttributeAttribute(Name = "InspectAttribute", RVA = "0x240950", Offset = "0x240950")]
			[AttributeAttribute(Name = "RestrictAttribute", RVA = "0x240950", Offset = "0x240950")]
			public MethodInfo Method
			{
				[Token(Token = "0x6000BCD")]
				[Address(RVA = "0xDEBE34", Offset = "0xDEBE34", VA = "0xDEBE34")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000BCE")]
				[Address(RVA = "0xDEBAF8", Offset = "0xDEBAF8", VA = "0xDEBAF8")]
				set
				{
				}
			}

			[Token(Token = "0x6000BC1")]
			[Address(RVA = "0xDEB270", Offset = "0xDEB270", VA = "0xDEB270")]
			private IList RestrictBinding()
			{
				return null;
			}

			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0xDEBBB8", Offset = "0xDEBBB8", VA = "0xDEBBB8")]
			private IList GetComponents()
			{
				return null;
			}

			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0xDEBF7C", Offset = "0xDEBF7C", VA = "0xDEBF7C")]
			private IList GetMethods()
			{
				return null;
			}

			[Token(Token = "0x6000BD0")]
			[Address(RVA = "0xDEC548", Offset = "0xDEC548", VA = "0xDEC548")]
			private bool IsMethodValid(MethodInfo info)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BD1")]
			[Address(RVA = "0xDEBE38", Offset = "0xDEBE38", VA = "0xDEBE38")]
			private MethodInfo GetMethodInfo()
			{
				return null;
			}

			[Token(Token = "0x6000BD2")]
			[Address(RVA = "0xDEC7A8", Offset = "0xDEC7A8", VA = "0xDEC7A8")]
			private bool IsStatic()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0xDEC7B8", Offset = "0xDEC7B8", VA = "0xDEC7B8")]
			private bool IsExternal()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0xDEC7CC", Offset = "0xDEC7CC", VA = "0xDEC7CC")]
			private Type GetRuntimeType()
			{
				return null;
			}

			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0xDEC7D0", Offset = "0xDEC7D0", VA = "0xDEC7D0")]
			public BindingParameter()
			{
			}

			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0xDE86F8", Offset = "0xDE86F8", VA = "0xDE86F8")]
			public BindingParameter(bool canBeInternal)
			{
			}

			[Token(Token = "0x6000BD7")]
			[Address(RVA = "0xDE999C", Offset = "0xDE999C", VA = "0xDE999C")]
			public static bool IsValidType(Type type)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BD8")]
			[Address(RVA = "0xDEB4DC", Offset = "0xDEB4DC", VA = "0xDEB4DC")]
			private object Invoke()
			{
				return null;
			}

			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0xDECA18", Offset = "0xDECA18", VA = "0xDECA18", Slot = "5")]
			public bool Copiable(object destination)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0xDECAF0", Offset = "0xDECAF0", VA = "0xDECAF0", Slot = "4")]
			public object Copy(object destination)
			{
				return null;
			}

			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0xDECDD4", Offset = "0xDECDD4", VA = "0xDECDD4", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private string[] internalParameters;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private GameObject gameObject;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Component component;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private string method;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "InspectAttribute", RVA = "0x238AB4", Offset = "0x238AB4")]
		[AttributeAttribute(Name = "CollectionAttribute", RVA = "0x238AB4", Offset = "0x238AB4")]
		[SerializeField]
		private BindingParameter[] parameters;

		[Token(Token = "0x17000138")]
		[AttributeAttribute(Name = "InspectAttribute", RVA = "0x240798", Offset = "0x240798")]
		public GameObject GameObject
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0xDE7CC0", Offset = "0xDE7CC0", VA = "0xDE7CC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600089F")]
			[Address(RVA = "0xDE7CC8", Offset = "0xDE7CC8", VA = "0xDE7CC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000139")]
		[AttributeAttribute(Name = "InspectAttribute", RVA = "0x2407A8", Offset = "0x2407A8")]
		[AttributeAttribute(Name = "RestrictAttribute", RVA = "0x2407A8", Offset = "0x2407A8")]
		public Component Component
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0xDE7E18", Offset = "0xDE7E18", VA = "0xDE7E18")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0xDE7D70", Offset = "0xDE7D70", VA = "0xDE7D70")]
			set
			{
			}
		}

		[Token(Token = "0x1700013A")]
		[AttributeAttribute(Name = "InspectAttribute", RVA = "0x2407F0", Offset = "0x2407F0")]
		[AttributeAttribute(Name = "RestrictAttribute", RVA = "0x2407F0", Offset = "0x2407F0")]
		public MethodInfo Method
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0xDE8488", Offset = "0xDE8488", VA = "0xDE8488")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0xDE7E20", Offset = "0xDE7E20", VA = "0xDE7E20")]
			set
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event ActionEventHandler OnInvoke
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0xDE9EEC", Offset = "0xDE9EEC", VA = "0xDE9EEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23FF18", Offset = "0x23FF18")]
			add
			{
			}
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0xDE9FA4", Offset = "0xDE9FA4", VA = "0xDE9FA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x23FF28", Offset = "0x23FF28")]
			remove
			{
			}
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xDE8140", Offset = "0xDE8140", VA = "0xDE8140")]
		private IList GetComponents()
		{
			return null;
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xDE8E50", Offset = "0xDE8E50", VA = "0xDE8E50")]
		private IList GetMethods()
		{
			return null;
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xDE95FC", Offset = "0xDE95FC", VA = "0xDE95FC")]
		private bool IsMethodValid(MethodInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xDE9838", Offset = "0xDE9838", VA = "0xDE9838")]
		private string GetParamNames(string name, ParameterInfo[] param)
		{
			return null;
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xDE848C", Offset = "0xDE848C", VA = "0xDE848C")]
		private MethodInfo GetMethodInfo()
		{
			return null;
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xDEA05C", Offset = "0xDEA05C", VA = "0xDEA05C")]
		public ActionBinding()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xDEA0EC", Offset = "0xDEA0EC", VA = "0xDEA0EC")]
		public ActionBinding(Type[] types)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xDEA284", Offset = "0xDEA284", VA = "0xDEA284")]
		public void Invoke(params object[] args)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xDEAC60", Offset = "0xDEAC60", VA = "0xDEAC60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xDEB0D4", Offset = "0xDEB0D4", VA = "0xDEB0D4", Slot = "4")]
		public bool Copiable(object destination)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000CB")]
	public enum CollectionDisplay
	{
		[Token(Token = "0x400065A")]
		List,
		[Token(Token = "0x400065B")]
		DropDown,
		[Token(Token = "0x400065C")]
		Button
	}
	[Token(Token = "0x20000CC")]
	public abstract class ComponentMonoBehaviour : MonoBehaviour
	{
		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x238B0C", Offset = "0x238B0C")]
		private MonoBehaviour owner;

		[Token(Token = "0x1700013B")]
		public MonoBehaviour Owner
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0xDF0D5C", Offset = "0xDF0D5C", VA = "0xDF0D5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0xDF0D64", Offset = "0xDF0D64", VA = "0xDF0D64")]
			set
			{
			}
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xDF0DF8", Offset = "0xDF0DF8", VA = "0xDF0DF8", Slot = "4")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xDF0E04", Offset = "0xDF0E04", VA = "0xDF0E04")]
		public void Erase()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xDF1384", Offset = "0xDF1384", VA = "0xDF1384")]
		public ComponentMonoBehaviour Instantiate()
		{
			return null;
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xDF145C", Offset = "0xDF145C", VA = "0xDF145C")]
		public ComponentMonoBehaviour Instantiate(MonoBehaviour owner)
		{
			return null;
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xDF13AC", Offset = "0xDF13AC", VA = "0xDF13AC")]
		public ComponentMonoBehaviour Instantiate(GameObject go, MonoBehaviour owner)
		{
			return null;
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xDF1488", Offset = "0xDF1488", VA = "0xDF1488")]
		private static object CopyObject(GameObject go, MonoBehaviour owner, object original)
		{
			return null;
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xDF1AA0", Offset = "0xDF1AA0", VA = "0xDF1AA0")]
		private static IList CopyList(GameObject go, MonoBehaviour owner, IList original)
		{
			return null;
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xDF1FF4", Offset = "0xDF1FF4", VA = "0xDF1FF4")]
		private static ComponentMonoBehaviour CopyComponent(GameObject go, MonoBehaviour owner, ComponentMonoBehaviour original)
		{
			return null;
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xDF2250", Offset = "0xDF2250", VA = "0xDF2250")]
		private static object CopyClass(GameObject go, MonoBehaviour owner, object original)
		{
			return null;
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xDF2438", Offset = "0xDF2438", VA = "0xDF2438")]
		protected ComponentMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x232124", Offset = "0x232124")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x232124", Offset = "0x232124")]
	public class CoroutineMonoBehaviour : MonoBehaviour
	{
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xDF32DC", Offset = "0xDF32DC", VA = "0xDF32DC")]
		public CoroutineMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class Description
	{
		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string name;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private string comment;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string url;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Texture icon;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Color color;

		[Token(Token = "0x1700013C")]
		public string Name
		{
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0xDF331C", Offset = "0xDF331C", VA = "0xDF331C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013D")]
		public string Comment
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0xDF3324", Offset = "0xDF3324", VA = "0xDF3324")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013E")]
		public string URL
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0xDF332C", Offset = "0xDF332C", VA = "0xDF332C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013F")]
		public Texture Icon
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0xDF3334", Offset = "0xDF3334", VA = "0xDF3334")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000140")]
		public Color Color
		{
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0xDF333C", Offset = "0xDF333C", VA = "0xDF333C")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xDF334C", Offset = "0xDF334C", VA = "0xDF334C")]
		public Description(string name)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xDF34B8", Offset = "0xDF34B8", VA = "0xDF34B8")]
		public Description(string name, Texture icon)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xDF3550", Offset = "0xDF3550", VA = "0xDF3550")]
		public Description(string name, Color color)
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xDF35EC", Offset = "0xDF35EC", VA = "0xDF35EC")]
		public Description(string name, Texture icon, Color color)
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xDE83BC", Offset = "0xDE83BC", VA = "0xDE83BC")]
		public Description(string name, string comment)
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xDF3688", Offset = "0xDF3688", VA = "0xDF3688")]
		public Description(string name, string comment, Texture icon)
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xDF3724", Offset = "0xDF3724", VA = "0xDF3724")]
		public Description(string name, string comment, Color color)
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xDF37C0", Offset = "0xDF37C0", VA = "0xDF37C0")]
		public Description(string name, string comment, Texture icon, Color color)
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0xDF3860", Offset = "0xDF3860", VA = "0xDF3860")]
		public Description(string name, string comment, string url)
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xDF38B8", Offset = "0xDF38B8", VA = "0xDF38B8")]
		public Description(string name, string comment, string url, Texture icon)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xDF3910", Offset = "0xDF3910", VA = "0xDF3910")]
		public Description(string name, string comment, string url, Color color)
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xDF33E4", Offset = "0xDF33E4", VA = "0xDF33E4")]
		public Description(string name, string comment, string url, Texture icon, Color color)
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class DescriptionPair
	{
		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private object value;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Description description;

		[Token(Token = "0x17000141")]
		public object Value
		{
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0xDF394C", Offset = "0xDF394C", VA = "0xDF394C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000142")]
		public Description Description
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0xDF3954", Offset = "0xDF3954", VA = "0xDF3954")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xDE8460", Offset = "0xDE8460", VA = "0xDE8460")]
		public DescriptionPair(object value, Description descriptor)
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xDF395C", Offset = "0xDF395C", VA = "0xDF395C")]
		public DescriptionPair(object value, string name)
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xDF39F8", Offset = "0xDF39F8", VA = "0xDF39F8")]
		public DescriptionPair(object value, string name, string description)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xDF3A88", Offset = "0xDF3A88", VA = "0xDF3A88")]
		public static bool operator ==(DescriptionPair a, DescriptionPair b)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xDF3ABC", Offset = "0xDF3ABC", VA = "0xDF3ABC")]
		public static bool operator !=(DescriptionPair a, DescriptionPair b)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xDF3B04", Offset = "0xDF3B04", VA = "0xDF3B04", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xDF3BCC", Offset = "0xDF3BCC", VA = "0xDF3BCC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xDF3BD4", Offset = "0xDF3BD4", VA = "0xDF3BD4")]
		public static DescriptionPair GetDescription(object item)
		{
			return null;
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xDF3D40", Offset = "0xDF3D40", VA = "0xDF3D40")]
		public static IList<DescriptionPair> GetDescriptions(IList items)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D0")]
	public enum EnumDisplay
	{
		[Token(Token = "0x4000666")]
		DropDown,
		[Token(Token = "0x4000667")]
		Button,
		[Token(Token = "0x4000668")]
		Checkbox
	}
	[Token(Token = "0x20000D1")]
	public class HelpItem : IEquatable<HelpItem>
	{
		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private HelpType type;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private string message;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HelpPosition position;

		[Token(Token = "0x17000143")]
		public HelpType Type
		{
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0xDF8134", Offset = "0xDF8134", VA = "0xDF8134")]
			get
			{
				return default(HelpType);
			}
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0xDF813C", Offset = "0xDF813C", VA = "0xDF813C")]
			set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public string Message
		{
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0xDF8144", Offset = "0xDF8144", VA = "0xDF8144")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0xDF814C", Offset = "0xDF814C", VA = "0xDF814C")]
			set
			{
			}
		}

		[Token(Token = "0x17000145")]
		public HelpPosition Position
		{
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0xDF8154", Offset = "0xDF8154", VA = "0xDF8154")]
			get
			{
				return default(HelpPosition);
			}
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0xDF815C", Offset = "0xDF815C", VA = "0xDF815C")]
			set
			{
			}
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xDF77D8", Offset = "0xDF77D8", VA = "0xDF77D8")]
		public HelpItem(HelpType type, string message)
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xDF71C4", Offset = "0xDF71C4", VA = "0xDF71C4")]
		public HelpItem(HelpType type, string message, HelpPosition position)
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xDF8164", Offset = "0xDF8164", VA = "0xDF8164", Slot = "4")]
		public bool Equals(HelpItem help)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xDF81C0", Offset = "0xDF81C0", VA = "0xDF81C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xDF829C", Offset = "0xDF829C", VA = "0xDF829C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000D2")]
	public enum IconPreviewSize
	{
		[Token(Token = "0x400066D")]
		Smallest,
		[Token(Token = "0x400066E")]
		Small,
		[Token(Token = "0x400066F")]
		Normal,
		[Token(Token = "0x4000670")]
		Large,
		[Token(Token = "0x4000671")]
		Largest
	}
	[Token(Token = "0x20000D3")]
	public enum InspectorLevel
	{
		[Token(Token = "0x4000673")]
		Basic,
		[Token(Token = "0x4000674")]
		Advanced,
		[Token(Token = "0x4000675")]
		Debug
	}
	[Token(Token = "0x20000D4")]
	public enum MethodDisplay
	{
		[Token(Token = "0x4000677")]
		Button,
		[Token(Token = "0x4000678")]
		Invoke
	}
	[Serializable]
	[Token(Token = "0x20000D5")]
	public struct RangeFloat
	{
		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float min;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float max;

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x2DEF40", Offset = "0x2DEF40", VA = "0x2DEF40")]
		public RangeFloat(float min, float max)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D6")]
	public struct RangeInt
	{
		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int min;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int max;

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x2DEF4C", Offset = "0x2DEF4C", VA = "0x2DEF4C")]
		public RangeInt(int min, int max)
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public enum RestrictDisplay
	{
		[Token(Token = "0x400067E")]
		DropDown,
		[Token(Token = "0x400067F")]
		Toolbox,
		[Token(Token = "0x4000680")]
		Button
	}
	[Token(Token = "0x20000D8")]
	public class ScriptableComponent : ScriptableObject
	{
		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		[AttributeAttribute(Name = "HideInInspector", RVA = "0x238B3C", Offset = "0x238B3C")]
		private ScriptableObject owner;

		[Token(Token = "0x17000146")]
		public ScriptableObject Owner
		{
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0xDFF408", Offset = "0xDFF408", VA = "0xDFF408")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0xDFF410", Offset = "0xDFF410", VA = "0xDFF410")]
			set
			{
			}
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xDFF4A4", Offset = "0xDFF4A4", VA = "0xDFF4A4", Slot = "4")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xDFF4B0", Offset = "0xDFF4B0", VA = "0xDFF4B0")]
		public void Erase()
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xDFF6FC", Offset = "0xDFF6FC", VA = "0xDFF6FC")]
		public ScriptableComponent Instantiate()
		{
			return null;
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0xDFF704", Offset = "0xDFF704", VA = "0xDFF704")]
		public ScriptableComponent Instantiate(ScriptableObject owner)
		{
			return null;
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xDFF7AC", Offset = "0xDFF7AC", VA = "0xDFF7AC")]
		private static object CopyObject(ScriptableObject owner, object original)
		{
			return null;
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0xDFFDB4", Offset = "0xDFFDB4", VA = "0xDFFDB4")]
		private static IList CopyList(ScriptableObject owner, IList original)
		{
			return null;
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xE002FC", Offset = "0xE002FC", VA = "0xE002FC")]
		private static ScriptableComponent CopyComponent(ScriptableObject owner, ScriptableComponent original)
		{
			return null;
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0xE0051C", Offset = "0xE0051C", VA = "0xE0051C")]
		private static object CopyClass(ScriptableObject owner, object original)
		{
			return null;
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0xE006FC", Offset = "0xE006FC", VA = "0xE006FC")]
		public ScriptableComponent()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public abstract class AIStateMachineBehaviour : StateMachineBehaviour
	{
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0xDE7CB8", Offset = "0xDE7CB8", VA = "0xDE7CB8")]
		protected AIStateMachineBehaviour()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public enum TextFieldType
	{
		[Token(Token = "0x4000683")]
		Standard,
		[Token(Token = "0x4000684")]
		Password,
		[Token(Token = "0x4000685")]
		Area,
		[Token(Token = "0x4000686")]
		Tag,
		[Token(Token = "0x4000687")]
		File,
		[Token(Token = "0x4000688")]
		Folder
	}
	[Serializable]
	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x23216C", Offset = "0x23216C")]
	[AttributeAttribute(Name = "ComVisibleAttribute", RVA = "0x23216C", Offset = "0x23216C")]
	[AttributeAttribute(Name = "DebuggerDisplayAttribute", RVA = "0x23216C", Offset = "0x23216C")]
	public class UDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, ISerializable, IDeserializationCallback, ISerializationCallbackReceiver
	{
		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TKey> keys;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<TValue> values;

		[NonSerialized]
		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue> dictionary;

		[Token(Token = "0x17000147")]
		public bool IsFixedSize
		{
			[Token(Token = "0x60008FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000148")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x60008FD")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000149")]
		private ICollection System.Collections.IDictionary.Keys
		{
			[Token(Token = "0x60008FE")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014A")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x60008FF")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014B")]
		private ICollection System.Collections.IDictionary.Values
		{
			[Token(Token = "0x6000900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014C")]
		public TValue Item
		{
			[Token(Token = "0x6000901")]
			get
			{
				return (TValue)null;
			}
			[Token(Token = "0x6000902")]
			set
			{
			}
		}

		[Token(Token = "0x1700014D")]
		private object System.Collections.IDictionary.Item
		{
			[Token(Token = "0x6000903")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000904")]
			set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		public int Count
		{
			[Token(Token = "0x600090D")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700014F")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600090E")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000150")]
		public bool IsSynchronized
		{
			[Token(Token = "0x600090F")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000151")]
		public object SyncRoot
		{
			[Token(Token = "0x6000910")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008F2")]
		public UDictionary()
		{
		}

		[Token(Token = "0x60008F3")]
		public UDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x60008F4")]
		public UDictionary(IDictionary<TKey, TValue> dictionary)
		{
		}

		[Token(Token = "0x60008F5")]
		public UDictionary(int capacity)
		{
		}

		[Token(Token = "0x60008F6")]
		public UDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x60008F7")]
		public UDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x60008F8")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60008F9")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60008FA")]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60008FB")]
		public void OnDeserialization(object sender)
		{
		}

		[Token(Token = "0x6000905")]
		public void Add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x6000906")]
		private void System.Collections.IDictionary.Add(object key, object value)
		{
		}

		[Token(Token = "0x6000907")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000908")]
		private bool System.Collections.IDictionary.Contains(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000909")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x600090A")]
		private void System.Collections.IDictionary.Remove(object key)
		{
		}

		[Token(Token = "0x600090B")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		[Token(Token = "0x600090C")]
		private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000911")]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		[Token(Token = "0x6000912")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000913")]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000914")]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x6000915")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000916")]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000917")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000918")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x20000DC")]
	public delegate void GenericEventHandler();
	[Token(Token = "0x20000DD")]
	public delegate void SenderEventHandler(object sender);
	[Token(Token = "0x20000DE")]
	public delegate void BoolEventHandler(object sender, bool value);
	[Token(Token = "0x20000DF")]
	public delegate void IntEventHandler(object sender, int value);
	[Token(Token = "0x20000E0")]
	public delegate void FloatEventHandler(object sender, float value);
	[Token(Token = "0x20000E1")]
	public delegate void StringEventHandler(object sender, string value);
	[Token(Token = "0x20000E2")]
	public delegate void ObjectEventHandler(object sender, object value);
	[Token(Token = "0x20000E3")]
	public delegate void Vector2EventHandler(object sender, Vector2 value);
	[Token(Token = "0x20000E4")]
	public delegate void Vector3EventHandler(object sender, Vector3 value);
	[Token(Token = "0x20000E5")]
	public delegate void Vector4EventHandler(object sender, Vector4 value);
	[Token(Token = "0x20000E6")]
	public delegate void CollisionEventHandler(object sender, Collision value);
	[Token(Token = "0x20000E7")]
	public delegate void ColliderEventHandler(object sender, Collider value);
	[Token(Token = "0x20000E8")]
	public delegate void ActionEventHandler(object sender, object[] args);
	[Token(Token = "0x20000E9")]
	public interface ICopiable
	{
		[Token(Token = "0x600094D")]
		bool Copiable(object destination);
	}
	[Token(Token = "0x20000EA")]
	public interface ICopy
	{
		[Token(Token = "0x600094E")]
		object Copy(object destination);
	}
	[Token(Token = "0x20000EB")]
	public interface IDataChanged
	{
		[Token(Token = "0x14000003")]
		event GenericEventHandler OnDataChanged;

		[Token(Token = "0x600094F")]
		void DataChanged();
	}
	[Token(Token = "0x20000EC")]
	public interface IDescriptor
	{
		[Token(Token = "0x6000952")]
		Description GetDescription(object[] instances, object[] values);
	}
	[Token(Token = "0x20000ED")]
	public interface IExpandable
	{
		[Token(Token = "0x6000953")]
		bool IsExpandable(object[] instances, object[] values);

		[Token(Token = "0x6000954")]
		bool IsExpanded(object[] instances, object[] values);

		[Token(Token = "0x6000955")]
		bool IsAlwaysExpanded(object[] instances, object[] values);
	}
	[Token(Token = "0x20000EE")]
	public interface IHelp
	{
		[Token(Token = "0x6000956")]
		IList<HelpItem> GetHelp(object[] instances, object[] values);
	}
	[Token(Token = "0x20000EF")]
	public interface IInspect
	{
		[Token(Token = "0x17000152")]
		object[] Inspect
		{
			[Token(Token = "0x6000957")]
			get;
		}
	}
	[Token(Token = "0x20000F0")]
	public interface IInspectorRunning
	{
		[Token(Token = "0x6000958")]
		void OnHeaderGUI();

		[Token(Token = "0x6000959")]
		void OnFooterGUI();
	}
	[Token(Token = "0x20000F1")]
	public interface IListAttribute
	{
	}
	[Token(Token = "0x20000F2")]
	public interface IMenu : IRuntimeAttribute
	{
		[Token(Token = "0x17000153")]
		string MenuItemName
		{
			[Token(Token = "0x600095B")]
			get;
		}

		[Token(Token = "0x17000154")]
		bool Enabled
		{
			[Token(Token = "0x600095C")]
			get;
		}

		[Token(Token = "0x17000155")]
		bool IsOn
		{
			[Token(Token = "0x600095D")]
			get;
		}

		[Token(Token = "0x600095A")]
		void Invoke(int index, object instance, object value);
	}
	[Token(Token = "0x20000F3")]
	public interface IPicker
	{
		[Token(Token = "0x600095E")]
		bool IsPickingAvailable(object[] instances, object[] values);
	}
	[Token(Token = "0x20000F4")]
	public interface IPreview
	{
		[Token(Token = "0x17000156")]
		UnityEngine.Object[] Preview
		{
			[Token(Token = "0x600095F")]
			get;
		}
	}
	[Token(Token = "0x20000F5")]
	public interface IReadOnly
	{
		[Token(Token = "0x6000960")]
		bool IsReadOnly(object[] instances, object[] values);
	}
	[Token(Token = "0x20000F6")]
	public interface IRestrict
	{
		[Token(Token = "0x6000961")]
		IList GetRestricted(object[] instances, object[] values);

		[Token(Token = "0x6000962")]
		RestrictDisplay GetDisplay(object[] instances, object[] values);

		[Token(Token = "0x6000963")]
		int GetItemsPerRow(object[] instances, object[] values);
	}
	[Token(Token = "0x20000F7")]
	public interface IRuntimeAttribute<T> : IRuntimeAttribute
	{
		[Token(Token = "0x6000964")]
		T Invoke(int index, object instance, object value);
	}
	[Token(Token = "0x20000F8")]
	public interface IRuntimeAttribute
	{
		[Token(Token = "0x17000157")]
		string MethodName
		{
			[Token(Token = "0x6000965")]
			get;
		}

		[Token(Token = "0x17000158")]
		Type Template
		{
			[Token(Token = "0x6000966")]
			get;
		}

		[Token(Token = "0x17000159")]
		Type TemplateStatic
		{
			[Token(Token = "0x6000967")]
			get;
		}

		[Token(Token = "0x1700015A")]
		List<Delegate> Delegates
		{
			[Token(Token = "0x6000968")]
			get;
			[Token(Token = "0x6000969")]
			set;
		}
	}
	[Token(Token = "0x20000F9")]
	public interface IRuntimeType
	{
		[Token(Token = "0x600096A")]
		Type GetType(object[] instances, object[] values);
	}
	[Token(Token = "0x20000FA")]
	public interface ISpacing
	{
		[Token(Token = "0x600096B")]
		int GetAfter(object[] instances, object[] values);

		[Token(Token = "0x600096C")]
		int GetBefore(object[] instances, object[] values);
	}
	[Token(Token = "0x20000FB")]
	public interface IVisibility
	{
		[Token(Token = "0x600096D")]
		bool IsItemVisible(object[] instances, object[] values);

		[Token(Token = "0x600096E")]
		InspectorLevel GetItemLevel(object[] instances, object[] values);

		[Token(Token = "0x600096F")]
		int GetItemPriority(object[] instances, object[] values);
	}
	[Token(Token = "0x20000FC")]
	public class TypeUtility
	{
		[Token(Token = "0x6000970")]
		[Address(RVA = "0xE03658", Offset = "0xE03658", VA = "0xE03658")]
		public static Type GetTypeByName(string name)
		{
			return null;
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0xDF1044", Offset = "0xDF1044", VA = "0xDF1044")]
		public static List<FieldInfo> GetFields(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0xE03794", Offset = "0xE03794", VA = "0xE03794")]
		public TypeUtility()
		{
		}
	}
}
