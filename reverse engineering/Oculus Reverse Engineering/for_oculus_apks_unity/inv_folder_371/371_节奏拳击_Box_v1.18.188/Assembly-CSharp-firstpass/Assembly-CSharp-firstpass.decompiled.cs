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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA309DC", Offset = "0xA309DC")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xA309DC", Offset = "0xA309DC")]
	public class BeamGeometry : MonoBehaviour
	{
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA30EB0", Offset = "0xA30EB0")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA30EC0", Offset = "0xA30EC0")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA30ED0", Offset = "0xA30ED0")]
		private Material <material>k__BackingField;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA30EE0", Offset = "0xA30EE0")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x17000001")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x1661AE4", Offset = "0x1661AE4", VA = "0x1661AE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA3147C", Offset = "0xA3147C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x1661AEC", Offset = "0x1661AEC", VA = "0x1661AEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA3148C", Offset = "0xA3148C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x1661AF4", Offset = "0x1661AF4", VA = "0x1661AF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA3149C", Offset = "0xA3149C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x1661AFC", Offset = "0x1661AFC", VA = "0x1661AFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA314AC", Offset = "0xA314AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public Material material
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x1661B04", Offset = "0x1661B04", VA = "0x1661B04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA314BC", Offset = "0xA314BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x1661B0C", Offset = "0x1661B0C", VA = "0x1661B0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA314CC", Offset = "0xA314CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public Mesh coneMesh
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x1661B14", Offset = "0x1661B14", VA = "0x1661B14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA314DC", Offset = "0xA314DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x1661B1C", Offset = "0x1661B1C", VA = "0x1661B1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA314EC", Offset = "0xA314EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public bool visible
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x1661B24", Offset = "0x1661B24", VA = "0x1661B24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x1661B54", Offset = "0x1661B54", VA = "0x1661B54")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public int sortingLayerID
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x1661B8C", Offset = "0x1661B8C", VA = "0x1661B8C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x1661BBC", Offset = "0x1661BBC", VA = "0x1661BBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public int sortingOrder
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x1661BF4", Offset = "0x1661BF4", VA = "0x1661BF4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x1661C24", Offset = "0x1661C24", VA = "0x1661C24")]
			set
			{
			}
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1661C5C", Offset = "0x1661C5C", VA = "0x1661C5C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1661D1C", Offset = "0x1661D1C", VA = "0x1661D1C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1661DC4", Offset = "0x1661DC4", VA = "0x1661DC4")]
		private static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1661E54", Offset = "0x1661E54", VA = "0x1661E54")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1661EE4", Offset = "0x1661EE4", VA = "0x1661EE4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1661F74", Offset = "0x1661F74", VA = "0x1661F74")]
		public void Initialize(VolumetricLightBeam master, Shader shader)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x16624E0", Offset = "0x16624E0", VA = "0x16624E0")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1664494", Offset = "0x1664494", VA = "0x1664494")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1663830", Offset = "0x1663830", VA = "0x1663830")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1664E18", Offset = "0x1664E18", VA = "0x1664E18")]
		public void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1664F14", Offset = "0x1664F14", VA = "0x1664F14")]
		public void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1664F78", Offset = "0x1664F78", VA = "0x1664F78")]
		private void OnBeginCameraRendering(Camera cam)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x166538C", Offset = "0x166538C", VA = "0x166538C")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1664F7C", Offset = "0x1664F7C", VA = "0x1664F7C")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x16655C8", Offset = "0x16655C8", VA = "0x16655C8")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xA30A4C", Offset = "0xA30A4C")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x18")]
		public int geometryLayerID;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x2C")]
		public bool forceSinglePass;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader1Pass;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xA30F28", Offset = "0xA30F28")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xA30F28", Offset = "0xA30F28")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader2Pass;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x40")]
		public int sharedMeshSides;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x44")]
		public int sharedMeshSegments;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA30FA8", Offset = "0xA30FA8")]
		public float globalNoiseScale;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x58")]
		[HighlightNull]
		public TextAsset noise3DData;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x60")]
		public int noise3DSize;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x68")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x0")]
		private static Config m_Instance;

		[Token(Token = "0x17000008")]
		public Shader beamShader
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x16655D0", Offset = "0x16655D0", VA = "0x16655D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x16655EC", Offset = "0x16655EC", VA = "0x16655EC")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x1700000A")]
		public static Config Instance
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x16627D4", Offset = "0x16627D4", VA = "0x16627D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1665624", Offset = "0x1665624", VA = "0x1665624")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x16657D8", Offset = "0x16657D8", VA = "0x16657D8")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x16659D0", Offset = "0x16659D0", VA = "0x16659D0")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public static class Consts
	{
		[Token(Token = "0x4000016")]
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		[Token(Token = "0x4000017")]
		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		[Token(Token = "0x4000018")]
		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		[Token(Token = "0x4000019")]
		public const string HelpUrlDynamicOcclusion = "http://saladgamer.com/vlb-doc/comp-dynocclusion/";

		[Token(Token = "0x400001A")]
		public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

		[Token(Token = "0x400001B")]
		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly bool ProceduralObjectsVisibleInEditor;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x4")]
		public static readonly Color FlatColor;

		[Token(Token = "0x400001E")]
		public const ColorMode ColorModeDefault = ColorMode.Flat;

		[Token(Token = "0x400001F")]
		public const float Alpha = 1f;

		[Token(Token = "0x4000020")]
		public const float SpotAngleDefault = 35f;

		[Token(Token = "0x4000021")]
		public const float SpotAngleMin = 0.1f;

		[Token(Token = "0x4000022")]
		public const float SpotAngleMax = 179.9f;

		[Token(Token = "0x4000023")]
		public const float ConeRadiusStart = 0.1f;

		[Token(Token = "0x4000024")]
		public const MeshType GeomMeshType = MeshType.Shared;

		[Token(Token = "0x4000025")]
		public const int GeomSidesDefault = 18;

		[Token(Token = "0x4000026")]
		public const int GeomSidesMin = 3;

		[Token(Token = "0x4000027")]
		public const int GeomSidesMax = 256;

		[Token(Token = "0x4000028")]
		public const int GeomSegmentsDefault = 5;

		[Token(Token = "0x4000029")]
		public const int GeomSegmentsMin = 0;

		[Token(Token = "0x400002A")]
		public const int GeomSegmentsMax = 64;

		[Token(Token = "0x400002B")]
		public const bool GeomCap = false;

		[Token(Token = "0x400002C")]
		public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

		[Token(Token = "0x400002D")]
		public const float AttenuationCustomBlending = 0.5f;

		[Token(Token = "0x400002E")]
		public const float FadeStart = 0f;

		[Token(Token = "0x400002F")]
		public const float FadeEnd = 3f;

		[Token(Token = "0x4000030")]
		public const float FadeMinThreshold = 0.01f;

		[Token(Token = "0x4000031")]
		public const float DepthBlendDistance = 2f;

		[Token(Token = "0x4000032")]
		public const float CameraClippingDistance = 0.5f;

		[Token(Token = "0x4000033")]
		public const float FresnelPowMaxValue = 10f;

		[Token(Token = "0x4000034")]
		public const float FresnelPow = 8f;

		[Token(Token = "0x4000035")]
		public const float GlareFrontal = 0.5f;

		[Token(Token = "0x4000036")]
		public const float GlareBehind = 0.5f;

		[Token(Token = "0x4000037")]
		public const float NoiseIntensityMin = 0f;

		[Token(Token = "0x4000038")]
		public const float NoiseIntensityMax = 1f;

		[Token(Token = "0x4000039")]
		public const float NoiseIntensityDefault = 0.5f;

		[Token(Token = "0x400003A")]
		public const float NoiseScaleMin = 0.01f;

		[Token(Token = "0x400003B")]
		public const float NoiseScaleMax = 2f;

		[Token(Token = "0x400003C")]
		public const float NoiseScaleDefault = 0.5f;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x14")]
		public static readonly Vector3 NoiseVelocityDefault;

		[Token(Token = "0x400003E")]
		public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x20")]
		public static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x28")]
		public static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x30")]
		public static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x4000042")]
		public const float DynOcclusionMinSurfaceRatioDefault = 0.5f;

		[Token(Token = "0x4000043")]
		public const float DynOcclusionMinSurfaceRatioMin = 50f;

		[Token(Token = "0x4000044")]
		public const float DynOcclusionMinSurfaceRatioMax = 100f;

		[Token(Token = "0x4000045")]
		public const float DynOcclusionMaxSurfaceDotDefault = 0.25f;

		[Token(Token = "0x4000046")]
		public const float DynOcclusionMaxSurfaceAngleMin = 45f;

		[Token(Token = "0x4000047")]
		public const float DynOcclusionMaxSurfaceAngleMax = 90f;

		[Token(Token = "0x4000048")]
		public const int ConfigGeometryLayerIDDefault = 1;

		[Token(Token = "0x4000049")]
		public const string ConfigGeometryTagDefault = "Untagged";

		[Token(Token = "0x400004A")]
		public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

		[Token(Token = "0x400004B")]
		public const bool ConfigGeometryForceSinglePassDefault = false;

		[Token(Token = "0x400004C")]
		public const int ConfigNoise3DSizeDefault = 64;

		[Token(Token = "0x400004D")]
		public const int ConfigSharedMeshSides = 24;

		[Token(Token = "0x400004E")]
		public const int ConfigSharedMeshSegments = 5;

		[Token(Token = "0x1700000B")]
		public static HideFlags ProceduralObjectsHideFlags
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x1662314", Offset = "0x1662314", VA = "0x1662314")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x2000005")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA30A84", Offset = "0xA30A84")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xA30A84", Offset = "0xA30A84")]
	public class DynamicOcclusion : MonoBehaviour
	{
		[Token(Token = "0x200001F")]
		private enum Direction
		{
			[Token(Token = "0x40000CE")]
			Up,
			[Token(Token = "0x40000CF")]
			Right,
			[Token(Token = "0x40000D0")]
			Down,
			[Token(Token = "0x40000D1")]
			Left
		}

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x18")]
		public LayerMask layerMask;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x1C")]
		public float minOccluderArea;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x20")]
		public int waitFrameCount;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x24")]
		public float minSurfaceRatio;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x28")]
		public float maxSurfaceDot;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x2C")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x30")]
		public float planeOffset;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x38")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x40")]
		private int m_FrameCountToWait;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x44")]
		private float m_RangeMultiplier;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x48")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1665C24", Offset = "0x1665C24", VA = "0x1665C24")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1665CBC", Offset = "0x1665CBC", VA = "0x1665CBC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1665D14", Offset = "0x1665D14", VA = "0x1665D14")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1665D1C", Offset = "0x1665D1C", VA = "0x1665D1C")]
		private void Start()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1665E00", Offset = "0x1665E00", VA = "0x1665E00")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1666300", Offset = "0x1666300", VA = "0x1666300")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x16663FC", Offset = "0x16663FC", VA = "0x16663FC")]
		private RaycastHit GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1666798", Offset = "0x1666798", VA = "0x1666798")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x16669D0", Offset = "0x16669D0", VA = "0x16669D0")]
		private bool IsHitValid(RaycastHit hit)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1665E40", Offset = "0x1665E40", VA = "0x1665E40")]
		private void ProcessRaycasts()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1666B28", Offset = "0x1666B28", VA = "0x1666B28")]
		private void SetHit(RaycastHit hit)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1665D18", Offset = "0x1665D18", VA = "0x1665D18")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1666C5C", Offset = "0x1666C5C", VA = "0x1666C5C")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1666DBC", Offset = "0x1666DBC", VA = "0x1666DBC")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1667060", Offset = "0x1667060", VA = "0x1667060")]
		public DynamicOcclusion()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public enum ColorMode
	{
		[Token(Token = "0x400005B")]
		Flat,
		[Token(Token = "0x400005C")]
		Gradient
	}
	[Token(Token = "0x2000007")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x400005E")]
		Linear,
		[Token(Token = "0x400005F")]
		Quadratic,
		[Token(Token = "0x4000060")]
		Blend
	}
	[Token(Token = "0x2000008")]
	public enum BlendingMode
	{
		[Token(Token = "0x4000062")]
		Additive,
		[Token(Token = "0x4000063")]
		SoftAdditive,
		[Token(Token = "0x4000064")]
		TraditionalTransparency
	}
	[Token(Token = "0x2000009")]
	public enum MeshType
	{
		[Token(Token = "0x4000066")]
		Shared,
		[Token(Token = "0x4000067")]
		Custom
	}
	[Token(Token = "0x200000A")]
	public enum RenderQueue
	{
		[Token(Token = "0x4000069")]
		Custom = 0,
		[Token(Token = "0x400006A")]
		Background = 1000,
		[Token(Token = "0x400006B")]
		Geometry = 2000,
		[Token(Token = "0x400006C")]
		AlphaTest = 2450,
		[Token(Token = "0x400006D")]
		GeometryLast = 2500,
		[Token(Token = "0x400006E")]
		Transparent = 3000,
		[Token(Token = "0x400006F")]
		Overlay = 4000
	}
	[Token(Token = "0x200000B")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x4000071")]
		Surface,
		[Token(Token = "0x4000072")]
		Beam
	}
	[Token(Token = "0x200000C")]
	public static class GlobalMesh
	{
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x1700000C")]
		public static Mesh mesh
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1663688", Offset = "0x1663688", VA = "0x1663688")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x200000D")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x16670C0", Offset = "0x16670C0", VA = "0x16670C0")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public static class MeshGenerator
	{
		[Token(Token = "0x4000074")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x1700000D")]
		private static bool duplicateBackFaces
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x16670C8", Offset = "0x16670C8", VA = "0x16670C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1667138", Offset = "0x1667138", VA = "0x1667138")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x16671F4", Offset = "0x16671F4", VA = "0x16671F4")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1662900", Offset = "0x1662900", VA = "0x1662900")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1667204", Offset = "0x1667204", VA = "0x1667204")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap)
		{
			return default(int);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1667238", Offset = "0x1667238", VA = "0x1667238")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap)
		{
			return default(int);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1667278", Offset = "0x1667278", VA = "0x1667278")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1667314", Offset = "0x1667314", VA = "0x1667314")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Token(Token = "0x200000F")]
	public static class Noise3D
	{
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x4000078")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x4000079")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x1700000E")]
		public static bool isSupported
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x1664A88", Offset = "0x1664A88", VA = "0x1664A88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x1667454", Offset = "0x1667454", VA = "0x1667454")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x16673B4", Offset = "0x16673B4", VA = "0x16673B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x16674EC", Offset = "0x16674EC", VA = "0x16674EC")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xA314FC", Offset = "0xA314FC")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1664BD8", Offset = "0x1664BD8", VA = "0x1664BD8")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1667548", Offset = "0x1667548", VA = "0x1667548")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA30B2C", Offset = "0xA30B2C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xA30B2C", Offset = "0xA30B2C")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x400007C")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x20")]
		private Mesh m_Mesh;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x16678A4", Offset = "0x16678A4", VA = "0x16678A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1667B54", Offset = "0x1667B54", VA = "0x1667B54")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public static class Utils
	{
		[Token(Token = "0x2000020")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x40000D3")]
			High = 64,
			[Token(Token = "0x40000D4")]
			Low = 8,
			[Token(Token = "0x40000D5")]
			Undef = 0
		}

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x400007F")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1662390", Offset = "0x1662390", VA = "0x1662390")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1667B6C", Offset = "0x1667B6C", VA = "0x1667B6C")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1667BFC", Offset = "0x1667BFC", VA = "0x1667BFC")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1667C28", Offset = "0x1667C28", VA = "0x1667C28")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1667C58", Offset = "0x1667C58", VA = "0x1667C58")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1667C8C", Offset = "0x1667C8C", VA = "0x1667C8C")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1667CC4", Offset = "0x1667CC4", VA = "0x1667CC4")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1667CF8", Offset = "0x1667CF8", VA = "0x1667CF8")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1667D28", Offset = "0x1667D28", VA = "0x1667D28")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x16666AC", Offset = "0x16666AC", VA = "0x16666AC")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1667D7C", Offset = "0x1667D7C", VA = "0x1667D7C")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1667DB0", Offset = "0x1667DB0", VA = "0x1667DB0")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1666DE8", Offset = "0x1666DE8", VA = "0x1666DE8")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x16681B8", Offset = "0x16681B8", VA = "0x16681B8")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1664810", Offset = "0x1664810", VA = "0x1664810")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1668300", Offset = "0x1668300", VA = "0x1668300")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1668440", Offset = "0x1668440", VA = "0x1668440")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1668204", Offset = "0x1668204", VA = "0x1668204")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1664740", Offset = "0x1664740", VA = "0x1664740")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x16684EC", Offset = "0x16684EC", VA = "0x16684EC")]
		public static void MarkCurrentSceneDirty()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public static class Version
	{
		[Token(Token = "0x4000080")]
		public const int Current = 1510;
	}
	[Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA30BD4", Offset = "0xA30BD4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xA30BD4", Offset = "0xA30BD4")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x2000021")]
		public enum Direction
		{
			[Token(Token = "0x40000D7")]
			Beam,
			[Token(Token = "0x40000D8")]
			Random
		}

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA30FE4", Offset = "0xA30FE4")]
		public float alpha;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA30FFC", Offset = "0xA30FFC")]
		public float size;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x20")]
		public Direction direction;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x28")]
		public float density;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA3101C", Offset = "0xA3101C")]
		public float spawnMaxDistance;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x30")]
		public bool cullingEnabled;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x34")]
		public float cullingMaxDistance;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA31034", Offset = "0xA31034")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x40")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x48")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x50")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x17000011")]
		public bool isCulled
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x16684F4", Offset = "0x16684F4", VA = "0x16684F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA3161C", Offset = "0xA3161C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x16684FC", Offset = "0x16684FC", VA = "0x16684FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA3162C", Offset = "0xA3162C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x1668508", Offset = "0x1668508", VA = "0x1668508")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x1668574", Offset = "0x1668574", VA = "0x1668574")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000014")]
		public int particlesMaxCount
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x1668610", Offset = "0x1668610", VA = "0x1668610")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000015")]
		public Camera mainCamera
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x16686C4", Offset = "0x16686C4", VA = "0x16686C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x16688AC", Offset = "0x16688AC", VA = "0x16688AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1668914", Offset = "0x1668914", VA = "0x1668914")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1668BE4", Offset = "0x1668BE4", VA = "0x1668BE4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1668B08", Offset = "0x1668B08", VA = "0x1668B08")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x166927C", Offset = "0x166927C", VA = "0x166927C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1669330", Offset = "0x1669330", VA = "0x1669330")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x16693F8", Offset = "0x16693F8", VA = "0x16693F8")]
		private void Update()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1668BE8", Offset = "0x1668BE8", VA = "0x1668BE8")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x166942C", Offset = "0x166942C", VA = "0x166942C")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1669810", Offset = "0x1669810", VA = "0x1669810")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xA30C7C", Offset = "0xA30C7C")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x2000022")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA30EA0", Offset = "0xA30EA0")]
		private sealed class <CoPlaytimeUpdate>d__96 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000D9")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000DA")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000DB")]
			[FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x1700002A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000B8")]
				[Address(RVA = "0x166AE38", Offset = "0x166AE38", VA = "0x166AE38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000BA")]
				[Address(RVA = "0x166AEA8", Offset = "0x166AEA8", VA = "0x166AEA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x166A8B0", Offset = "0x166A8B0", VA = "0x166A8B0")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__96(int <>1__state)
			{
			}

			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x166ADAC", Offset = "0x166ADAC", VA = "0x166ADAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x166ADB0", Offset = "0x166ADB0", VA = "0x166ADB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x166AE40", Offset = "0x166AE40", VA = "0x166AE40", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xA31044", Offset = "0xA31044")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xA31044", Offset = "0xA31044")]
		public Color color;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA31098", Offset = "0xA31098")]
		public float alphaInside;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xA310B0", Offset = "0xA310B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA310B0", Offset = "0xA310B0")]
		public float alphaOutside;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x40")]
		public BlendingMode blendingMode;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xA31104", Offset = "0xA31104")]
		public bool spotAngleFromLight;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA3113C", Offset = "0xA3113C")]
		public float spotAngle;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xA3115C", Offset = "0xA3115C")]
		public float coneRadiusStart;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x50")]
		public MeshType geomMeshType;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xA31194", Offset = "0xA31194")]
		public int geomCustomSides;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x58")]
		public int geomCustomSegments;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x5C")]
		public bool geomCap;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x5D")]
		public bool fadeEndFromLight;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x60")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA311CC", Offset = "0xA311CC")]
		public float attenuationCustomBlending;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x68")]
		public float fadeStart;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x6C")]
		public float fadeEnd;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x70")]
		public float depthBlendDistance;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x74")]
		public float cameraClippingDistance;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA311E4", Offset = "0xA311E4")]
		public float glareFrontal;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA311FC", Offset = "0xA311FC")]
		public float glareBehind;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xA31214", Offset = "0xA31214")]
		public float boostDistanceInside;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xA3124C", Offset = "0xA3124C")]
		public float fresnelPowInside;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xA31284", Offset = "0xA31284")]
		public float fresnelPow;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x8C")]
		public bool noiseEnabled;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA312BC", Offset = "0xA312BC")]
		public float noiseIntensity;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x94")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA312D4", Offset = "0xA312D4")]
		public float noiseScaleLocal;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x9C")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0xAC")]
		private Plane m_PlaneWS;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xA31300", Offset = "0xA31300")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0xD0")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0xD8")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0xE0")]
		private Light _CachedLight;

		[Token(Token = "0x17000016")]
		public float coneAngle
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x1664648", Offset = "0x1664648", VA = "0x1664648")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000017")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x16645BC", Offset = "0x16645BC", VA = "0x16645BC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000018")]
		public float coneVolume
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x16698C0", Offset = "0x16698C0", VA = "0x16698C0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000019")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x16646E8", Offset = "0x16646E8", VA = "0x16646E8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001A")]
		public int geomSides
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x1669914", Offset = "0x1669914", VA = "0x1669914")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x16699A0", Offset = "0x16699A0", VA = "0x16699A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public int geomSegments
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x1669A20", Offset = "0x1669A20", VA = "0x1669A20")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x1669AAC", Offset = "0x1669AAC", VA = "0x1669AAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x1664A60", Offset = "0x1664A60", VA = "0x1664A60")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001D")]
		public int sortingLayerID
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x1662388", Offset = "0x1662388", VA = "0x1662388")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x1669B2C", Offset = "0x1669B2C", VA = "0x1669B2C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public string sortingLayerName
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x1669BD8", Offset = "0x1669BD8", VA = "0x1669BD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x1669BE4", Offset = "0x1669BE4", VA = "0x1669BE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public int sortingOrder
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x16624D8", Offset = "0x16624D8", VA = "0x16624D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x1669C14", Offset = "0x1669C14", VA = "0x1669C14")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x1669CC0", Offset = "0x1669CC0", VA = "0x1669CC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x1669CC8", Offset = "0x1669CC8", VA = "0x1669CC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x1669D28", Offset = "0x1669D28", VA = "0x1669D28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		public bool hasGeometry
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x1669664", Offset = "0x1669664", VA = "0x1669664")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000023")]
		public Bounds bounds
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x16696D4", Offset = "0x16696D4", VA = "0x16696D4")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000024")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x1664960", Offset = "0x1664960", VA = "0x1664960")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000025")]
		public string meshStats
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x1669E78", Offset = "0x1669E78", VA = "0x1669E78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public int meshVerticesCount
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x166A020", Offset = "0x166A020", VA = "0x166A020")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000027")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x166A114", Offset = "0x166A114", VA = "0x166A114")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000028")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x166A228", Offset = "0x166A228", VA = "0x166A228")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1666F08", Offset = "0x1666F08", VA = "0x1666F08")]
		public void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1666FCC", Offset = "0x1666FCC", VA = "0x1666FCC")]
		public void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1669D38", Offset = "0x1669D38", VA = "0x1669D38")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x166A328", Offset = "0x166A328", VA = "0x166A328")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x166542C", Offset = "0x166542C", VA = "0x166542C")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x166A390", Offset = "0x166A390", VA = "0x166A390")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xA3163C", Offset = "0xA3163C")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x166A39C", Offset = "0x166A39C", VA = "0x166A39C", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x166A66C", Offset = "0x166A66C", VA = "0x166A66C", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x166A708", Offset = "0x166A708", VA = "0x166A708")]
		private void Start()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x166A714", Offset = "0x166A714", VA = "0x166A714")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x166A7A8", Offset = "0x166A7A8", VA = "0x166A7A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1669CD4", Offset = "0x1669CD4", VA = "0x1669CD4")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x166A83C", Offset = "0x166A83C", VA = "0x166A83C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA31674", Offset = "0xA31674")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x166A8DC", Offset = "0x166A8DC", VA = "0x166A8DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x166A8E0", Offset = "0x166A8E0", VA = "0x166A8E0")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x166A9A8", Offset = "0x166A9A8", VA = "0x166A9A8")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x166AAB4", Offset = "0x166AAB4", VA = "0x166AAB4")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x166A63C", Offset = "0x166A63C", VA = "0x166A63C")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x166A588", Offset = "0x166A588", VA = "0x166A588")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x166AC8C", Offset = "0x166AC8C", VA = "0x166AC8C")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA30CE8", Offset = "0xA30CE8")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x166AEB0", Offset = "0x166AEB0", VA = "0x166AEB0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x166AFEC", Offset = "0x166AFEC", VA = "0x166AFEC")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA30D4C", Offset = "0xA30D4C")]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x18")]
		private bool isInsideBeam;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x166AFFC", Offset = "0x166AFFC", VA = "0x166AFFC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x166B0BC", Offset = "0x166B0BC", VA = "0x166B0BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x166B1B4", Offset = "0x166B1B4", VA = "0x166B1B4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x166B1BC", Offset = "0x166B1BC", VA = "0x166B1BC")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x166B288", Offset = "0x166B288", VA = "0x166B288")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA30DF0", Offset = "0xA30DF0")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x166B290", Offset = "0x166B290", VA = "0x166B290")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x166B368", Offset = "0x166B368", VA = "0x166B368")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x17000029")]
		private bool useMouseView
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x166B370", Offset = "0x166B370", VA = "0x166B370")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x166B378", Offset = "0x166B378", VA = "0x166B378")]
			set
			{
			}
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x166B3B4", Offset = "0x166B3B4", VA = "0x166B3B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x166B454", Offset = "0x166B454", VA = "0x166B454")]
		private void Update()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x166BC20", Offset = "0x166BC20", VA = "0x166BC20")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA3137C", Offset = "0xA3137C")]
		[SerializeField]
		private int CountX;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA313C0", Offset = "0xA313C0")]
		[SerializeField]
		private int CountY;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x166BC44", Offset = "0x166BC44", VA = "0x166BC44")]
		public void Generate()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x166C744", Offset = "0x166C744", VA = "0x166C744")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xA31444", Offset = "0xA31444")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x166C764", Offset = "0x166C764", VA = "0x166C764")]
		private void Update()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x166C90C", Offset = "0x166C90C", VA = "0x166C90C")]
		public Rotater()
		{
		}
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xA30E54", Offset = "0xA30E54")]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1661ACC", Offset = "0x1661ACC", VA = "0x1661ACC")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xA30E68", Offset = "0xA30E68")]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1661AD4", Offset = "0x1661AD4", VA = "0x1661AD4")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xA30E7C", Offset = "0xA30E7C")]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1661ADC", Offset = "0x1661ADC", VA = "0x1661ADC")]
		public RelatingAttribute()
		{
		}
	}
}
