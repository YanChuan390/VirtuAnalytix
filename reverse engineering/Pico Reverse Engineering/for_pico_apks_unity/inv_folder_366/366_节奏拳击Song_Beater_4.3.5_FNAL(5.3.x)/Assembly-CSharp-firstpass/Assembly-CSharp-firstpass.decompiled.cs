using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[assembly: AssemblyVersion("0.0.0.0")]
namespace VLB
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E9BD4", Offset = "0x7E9BD4")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E9BD4", Offset = "0x7E9BD4")]
	public class BeamGeometry : MonoBehaviour
	{
		[Token(Token = "0x4000001")]
		private const int kNbSegments = 0;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EAE70", Offset = "0x7EAE70")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EAE80", Offset = "0x7EAE80")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EAE90", Offset = "0x7EAE90")]
		private Material <material>k__BackingField;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EAEA0", Offset = "0x7EAEA0")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x17000001")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x18F4B70", Offset = "0x18F4B70", VA = "0x18F4B70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F31CC", Offset = "0x7F31CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x18F4B78", Offset = "0x18F4B78", VA = "0x18F4B78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F31DC", Offset = "0x7F31DC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x18F4B80", Offset = "0x18F4B80", VA = "0x18F4B80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F31EC", Offset = "0x7F31EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x18F4B88", Offset = "0x18F4B88", VA = "0x18F4B88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F31FC", Offset = "0x7F31FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public Material material
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x18F4B90", Offset = "0x18F4B90", VA = "0x18F4B90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F320C", Offset = "0x7F320C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x18F4B98", Offset = "0x18F4B98", VA = "0x18F4B98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F321C", Offset = "0x7F321C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public Mesh coneMesh
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x18F4BA0", Offset = "0x18F4BA0", VA = "0x18F4BA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F322C", Offset = "0x7F322C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x18F4BA8", Offset = "0x18F4BA8", VA = "0x18F4BA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F323C", Offset = "0x7F323C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public bool visible
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x18F4BB0", Offset = "0x18F4BB0", VA = "0x18F4BB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x18F4BCC", Offset = "0x18F4BCC", VA = "0x18F4BCC")]
			set
			{
			}
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x18F4BEC", Offset = "0x18F4BEC", VA = "0x18F4BEC")]
		private void Start()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x18F4CAC", Offset = "0x18F4CAC", VA = "0x18F4CAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x18F4D54", Offset = "0x18F4D54", VA = "0x18F4D54")]
		public void Initialize(VolumetricLightBeam master, Shader shader)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x18F4F8C", Offset = "0x18F4F8C", VA = "0x18F4F8C")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x18F5E48", Offset = "0x18F5E48", VA = "0x18F5E48")]
		private void ComputeBounds()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x18F58E4", Offset = "0x18F58E4", VA = "0x18F58E4")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x18F64E0", Offset = "0x18F64E0", VA = "0x18F64E0")]
		public void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x18F65D4", Offset = "0x18F65D4", VA = "0x18F65D4")]
		public void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x18F6630", Offset = "0x18F6630", VA = "0x18F6630")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x18F69C4", Offset = "0x18F69C4", VA = "0x18F69C4")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E9C44", Offset = "0x7E9C44")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int geometryLayerID;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HighlightNull]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7EAEB0", Offset = "0x7EAEB0")]
		public Shader beamShader;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAEFC", Offset = "0x7EAEFC")]
		public float globalNoiseScale;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HighlightNull]
		public TextAsset noise3DData;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int noise3DSize;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Config m_Instance;

		[Token(Token = "0x17000006")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x18F69CC", Offset = "0x18F69CC", VA = "0x18F69CC")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000007")]
		public static Config Instance
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x18F5108", Offset = "0x18F5108", VA = "0x18F5108")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x18F6A04", Offset = "0x18F6A04", VA = "0x18F6A04")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x18F6B80", Offset = "0x18F6B80", VA = "0x18F6B80")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x18F6D20", Offset = "0x18F6D20", VA = "0x18F6D20")]
		public Config()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public static class Consts
	{
		[Token(Token = "0x400000F")]
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		[Token(Token = "0x4000010")]
		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		[Token(Token = "0x4000011")]
		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		[Token(Token = "0x4000012")]
		public const string HelpUrlDynamicOcclusion = "http://saladgamer.com/vlb-doc/comp-dynocclusion/";

		[Token(Token = "0x4000013")]
		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool ProceduralObjectsVisibleInEditor;

		[Token(Token = "0x4000015")]
		public const float Alpha = 1f;

		[Token(Token = "0x4000016")]
		public const float SpotAngleDefault = 35f;

		[Token(Token = "0x4000017")]
		public const float SpotAngleMin = 0.1f;

		[Token(Token = "0x4000018")]
		public const float SpotAngleMax = 179.9f;

		[Token(Token = "0x4000019")]
		public const float ConeRadiusStart = 0.1f;

		[Token(Token = "0x400001A")]
		public const int GeomSidesDefault = 18;

		[Token(Token = "0x400001B")]
		public const int GeomSidesMin = 3;

		[Token(Token = "0x400001C")]
		public const int GeomSidesMax = 256;

		[Token(Token = "0x400001D")]
		public const bool GeomCap = false;

		[Token(Token = "0x400001E")]
		public const VolumetricLightBeam.AttenuationEquation AttenuationEquation = VolumetricLightBeam.AttenuationEquation.Quadratic;

		[Token(Token = "0x400001F")]
		public const float AttenuationCustomBlending = 0.5f;

		[Token(Token = "0x4000020")]
		public const float FadeStart = 0f;

		[Token(Token = "0x4000021")]
		public const float FadeEnd = 3f;

		[Token(Token = "0x4000022")]
		public const float FadeMinThreshold = 0.01f;

		[Token(Token = "0x4000023")]
		public const float DepthBlendDistance = 2f;

		[Token(Token = "0x4000024")]
		public const float CameraClippingDistance = 0.5f;

		[Token(Token = "0x4000025")]
		public const float FresnelPowMaxValue = 10f;

		[Token(Token = "0x4000026")]
		public const float FresnelPow = 8f;

		[Token(Token = "0x4000027")]
		public const float GlareFrontal = 0.5f;

		[Token(Token = "0x4000028")]
		public const float GlareBehind = 0.5f;

		[Token(Token = "0x4000029")]
		public const float NoiseIntensityDefault = 0.5f;

		[Token(Token = "0x400002A")]
		public const float NoiseScaleMin = 0.01f;

		[Token(Token = "0x400002B")]
		public const float NoiseScaleMax = 2f;

		[Token(Token = "0x400002C")]
		public const float NoiseScaleDefault = 0.5f;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static Vector3 NoiseVelocityDefault;

		[Token(Token = "0x17000008")]
		public static HideFlags ProceduralObjectsHideFlags
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x18F4F18", Offset = "0x18F4F18", VA = "0x18F4F18")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x2000005")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7E9C7C", Offset = "0x7E9C7C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E9C7C", Offset = "0x7E9C7C")]
	public class DynamicOcclusion : MonoBehaviour
	{
		[Token(Token = "0x20000C0")]
		public enum PlaneAlignment
		{
			[Token(Token = "0x4000591")]
			Surface,
			[Token(Token = "0x4000592")]
			Beam
		}

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask layerMask;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minOccluderArea;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int waitFrameCount;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float planeOffset;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_FrameCountToWait;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x18F6E5C", Offset = "0x18F6E5C", VA = "0x18F6E5C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x18F6EF4", Offset = "0x18F6EF4", VA = "0x18F6EF4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x18F6F4C", Offset = "0x18F6F4C", VA = "0x18F6F4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x18F6F54", Offset = "0x18F6F54", VA = "0x18F6F54")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x18F7064", Offset = "0x18F7064", VA = "0x18F7064")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x18F7160", Offset = "0x18F7160", VA = "0x18F7160")]
		private RaycastHit GetBestHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x18F6F94", Offset = "0x18F6F94", VA = "0x18F6F94")]
		private void ProcessRaycasts()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x18F745C", Offset = "0x18F745C", VA = "0x18F745C")]
		private void SetHit(RaycastHit hit)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x18F6F50", Offset = "0x18F6F50", VA = "0x18F6F50")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x18F7588", Offset = "0x18F7588", VA = "0x18F7588")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x18F7694", Offset = "0x18F7694", VA = "0x18F7694")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x18F791C", Offset = "0x18F791C", VA = "0x18F791C")]
		public DynamicOcclusion()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x18F7964", Offset = "0x18F7964", VA = "0x18F7964")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class MeshGenerator
	{
		[Token(Token = "0x4000035")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x18F796C", Offset = "0x18F796C", VA = "0x18F796C")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x18F7A28", Offset = "0x18F7A28", VA = "0x18F7A28")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap)
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x18F5234", Offset = "0x18F5234", VA = "0x18F5234")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap)
		{
			return null;
		}
	}
	[Token(Token = "0x2000008")]
	public static class Noise3D
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x4000039")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x400003A")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x17000009")]
		public static bool isSupported
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x18F6170", Offset = "0x18F6170", VA = "0x18F6170")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x18F7AD8", Offset = "0x18F7AD8", VA = "0x18F7AD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x18F7A38", Offset = "0x18F7A38", VA = "0x18F7A38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x18F62C0", Offset = "0x18F62C0", VA = "0x18F62C0")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x18F7B70", Offset = "0x18F7B70", VA = "0x18F7B70")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x2000009")]
	public static class Utils
	{
		[Token(Token = "0x6000033")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x18F923C", Offset = "0x18F923C", VA = "0x18F923C")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x18F9324", Offset = "0x18F9324", VA = "0x18F9324")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x18F9350", Offset = "0x18F9350", VA = "0x18F9350")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x18F9380", Offset = "0x18F9380", VA = "0x18F9380")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x18F93B4", Offset = "0x18F93B4", VA = "0x18F93B4")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x18F93EC", Offset = "0x18F93EC", VA = "0x18F93EC")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x18F9420", Offset = "0x18F9420", VA = "0x18F9420")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x18F9450", Offset = "0x18F9450", VA = "0x18F9450")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x18F7370", Offset = "0x18F7370", VA = "0x18F7370")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x18F94A4", Offset = "0x18F94A4", VA = "0x18F94A4")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x18F94D8", Offset = "0x18F94D8", VA = "0x18F94D8")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x18F76AC", Offset = "0x18F76AC", VA = "0x18F76AC")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}
	}
	[Token(Token = "0x200000A")]
	public static class Version
	{
		[Token(Token = "0x400003B")]
		public const int Current = 1340;
	}
	[Token(Token = "0x200000B")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7E9D34", Offset = "0x7E9D34")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E9D34", Offset = "0x7E9D34")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x20000C1")]
		public enum Direction
		{
			[Token(Token = "0x4000594")]
			Beam,
			[Token(Token = "0x4000595")]
			Random
		}

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAF38", Offset = "0x7EAF38")]
		public float alpha;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAF50", Offset = "0x7EAF50")]
		public float size;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Direction direction;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float density;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAF70", Offset = "0x7EAF70")]
		public float spawnMaxDistance;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool cullingEnabled;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float cullingMaxDistance;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EAF88", Offset = "0x7EAF88")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x1700000C")]
		public bool isCulled
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x18F98E0", Offset = "0x18F98E0", VA = "0x18F98E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F331C", Offset = "0x7F331C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x18F98E8", Offset = "0x18F98E8", VA = "0x18F98E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F332C", Offset = "0x7F332C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x18F98F4", Offset = "0x18F98F4", VA = "0x18F98F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x18F9960", Offset = "0x18F9960", VA = "0x18F9960")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000F")]
		public int particlesMaxCount
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x18F99F4", Offset = "0x18F99F4", VA = "0x18F99F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000010")]
		public Camera mainCamera
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x18F9AA0", Offset = "0x18F9AA0", VA = "0x18F9AA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x18F9CF8", Offset = "0x18F9CF8", VA = "0x18F9CF8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x18F9D60", Offset = "0x18F9D60", VA = "0x18F9D60")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x18F9FC4", Offset = "0x18F9FC4", VA = "0x18F9FC4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x18F9F08", Offset = "0x18F9F08", VA = "0x18F9F08")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x18FA42C", Offset = "0x18FA42C", VA = "0x18FA42C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x18FA4CC", Offset = "0x18FA4CC", VA = "0x18FA4CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x18FA58C", Offset = "0x18FA58C", VA = "0x18FA58C")]
		private void Update()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x18F9FC8", Offset = "0x18F9FC8", VA = "0x18F9FC8")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x18FA5C0", Offset = "0x18FA5C0", VA = "0x18FA5C0")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x18FA924", Offset = "0x18FA924", VA = "0x18FA924")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x200000C")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E9DDC", Offset = "0x7E9DDC")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x20000C2")]
		public enum AttenuationEquation
		{
			[Token(Token = "0x4000597")]
			Linear,
			[Token(Token = "0x4000598")]
			Quadratic,
			[Token(Token = "0x4000599")]
			Blend
		}

		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EADE0", Offset = "0x7EADE0")]
		private sealed class <CoPlaytimeUpdate>d__66 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x1700008A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600060A")]
				[Address(RVA = "0x18FB60C", Offset = "0x18FB60C", VA = "0x18FB60C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600060C")]
				[Address(RVA = "0x18FB678", Offset = "0x18FB678", VA = "0x18FB678", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x18FB108", Offset = "0x18FB108", VA = "0x18FB108")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__66(int <>1__state)
			{
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x18FB588", Offset = "0x18FB588", VA = "0x18FB588", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x18FB58C", Offset = "0x18FB58C", VA = "0x18FB58C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x18FB614", Offset = "0x18FB614", VA = "0x18FB614", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x7EAF98", Offset = "0x7EAF98")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7EAF98", Offset = "0x7EAF98")]
		public Color color;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAFEC", Offset = "0x7EAFEC")]
		public float alphaInside;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB004", Offset = "0x7EB004")]
		public float alphaOutside;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7EB01C", Offset = "0x7EB01C")]
		public bool spotAngleFromLight;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB054", Offset = "0x7EB054")]
		public float spotAngle;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7EB074", Offset = "0x7EB074")]
		public float coneRadiusStart;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int geomSides;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool geomCap;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		public bool fadeEndFromLight;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB0AC", Offset = "0x7EB0AC")]
		public float attenuationCustomBlending;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float fadeStart;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float fadeEnd;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float depthBlendDistance;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float cameraClippingDistance;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB0C4", Offset = "0x7EB0C4")]
		public float glareFrontal;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB0DC", Offset = "0x7EB0DC")]
		public float glareBehind;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7EB0F4", Offset = "0x7EB0F4")]
		public float boostDistanceInside;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7EB12C", Offset = "0x7EB12C")]
		public float fresnelPowInside;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7EB164", Offset = "0x7EB164")]
		public float fresnelPow;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool noiseEnabled;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB19C", Offset = "0x7EB19C")]
		public float noiseIntensity;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB1B4", Offset = "0x7EB1B4")]
		public float noiseScaleLocal;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7EB1E0", Offset = "0x7EB1E0")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Light _CachedLight;

		[Token(Token = "0x17000011")]
		public float coneAngle
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x18F6054", Offset = "0x18F6054", VA = "0x18F6054")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000012")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x18F5FC8", Offset = "0x18F5FC8", VA = "0x18F5FC8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000013")]
		public float coneVolume
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x18FA9D4", Offset = "0x18FA9D4", VA = "0x18FA9D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000014")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x18F60F4", Offset = "0x18F60F4", VA = "0x18F60F4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000015")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x18F6148", Offset = "0x18F6148", VA = "0x18F6148")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000016")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x18FAA28", Offset = "0x18FAA28", VA = "0x18FAA28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x18FAA30", Offset = "0x18FAA30", VA = "0x18FAA30")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x18FAA90", Offset = "0x18FAA90", VA = "0x18FAA90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		public bool hasGeometry
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x18FA784", Offset = "0x18FA784", VA = "0x18FA784")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000019")]
		public Bounds bounds
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x18FA7F4", Offset = "0x18FA7F4", VA = "0x18FA7F4")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x1700001A")]
		public string meshStats
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x18FAAA0", Offset = "0x18FAAA0", VA = "0x18FAAA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x18FAC2C", Offset = "0x18FAC2C", VA = "0x18FAC2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x18F77CC", Offset = "0x18F77CC", VA = "0x18F77CC")]
		public void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x18F7890", Offset = "0x18F7890", VA = "0x18F7890")]
		public void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x18F6828", Offset = "0x18F6828", VA = "0x18F6828")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x18FAD24", Offset = "0x18FAD24", VA = "0x18FAD24")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7F333C", Offset = "0x7F333C")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x18FAD28", Offset = "0x18FAD28", VA = "0x18FAD28")]
		public void GenerateGeometry()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x18FAEE4", Offset = "0x18FAEE4", VA = "0x18FAEE4")]
		public void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x18FAF78", Offset = "0x18FAF78", VA = "0x18FAF78")]
		private void Start()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x18FAF7C", Offset = "0x18FAF7C", VA = "0x18FAF7C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x18FB008", Offset = "0x18FB008", VA = "0x18FB008")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x18FAA3C", Offset = "0x18FAA3C", VA = "0x18FAA3C")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x18FB094", Offset = "0x18FB094", VA = "0x18FB094")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F3374", Offset = "0x7F3374")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x18FB134", Offset = "0x18FB134", VA = "0x18FB134")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x18FB1F4", Offset = "0x18FB1F4", VA = "0x18FB1F4")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x18FB2D8", Offset = "0x18FB2D8", VA = "0x18FB2D8")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x18FAEB4", Offset = "0x18FAEB4", VA = "0x18FAEB4")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x18FB48C", Offset = "0x18FB48C", VA = "0x18FB48C")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB.Samples
{
	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7E9E48", Offset = "0x7E9E48")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x18F7EBC", Offset = "0x18F7EBC", VA = "0x18F7EBC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x18F7FBC", Offset = "0x18F7FBC", VA = "0x18F7FBC")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7E9EAC", Offset = "0x7E9EAC")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x18F7FCC", Offset = "0x18F7FCC", VA = "0x18F7FCC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x18F80A0", Offset = "0x18F80A0", VA = "0x18F80A0")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x1700001C")]
		private bool useMouseView
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x18F80A8", Offset = "0x18F80A8", VA = "0x18F80A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x18F80B0", Offset = "0x18F80B0", VA = "0x18F80B0")]
			set
			{
			}
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x18F80EC", Offset = "0x18F80EC", VA = "0x18F80EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x18F8184", Offset = "0x18F8184", VA = "0x18F8184")]
		private void Update()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x18F8840", Offset = "0x18F8840", VA = "0x18F8840")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB23C", Offset = "0x7EB23C")]
		[SerializeField]
		private int CountX;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB280", Offset = "0x7EB280")]
		[SerializeField]
		private int CountY;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x18F8864", Offset = "0x18F8864", VA = "0x18F8864")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x18F9024", Offset = "0x18F9024", VA = "0x18F9024")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7EB304", Offset = "0x7EB304")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x18F9044", Offset = "0x18F9044", VA = "0x18F9044")]
		private void Update()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x18F91C4", Offset = "0x18F91C4", VA = "0x18F91C4")]
		public Rotater()
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000012")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C4")]
		public enum UpdateMode
		{
			[Token(Token = "0x400059E")]
			Update,
			[Token(Token = "0x400059F")]
			FixedUpdate,
			[Token(Token = "0x40005A0")]
			LateUpdate,
			[Token(Token = "0x40005A1")]
			FixedLateUpdate
		}

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EB33C", Offset = "0x7EB33C")]
		public bool smoothFollow;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EB374", Offset = "0x7EB374")]
		public float rotationSensitivity;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EB3AC", Offset = "0x7EB3AC")]
		public float distance;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EB3E4", Offset = "0x7EB3E4")]
		public LayerMask blockingLayers;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB41C", Offset = "0x7EB41C")]
		public float blockedOffset;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EB434", Offset = "0x7EB434")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EB444", Offset = "0x7EB444")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EB454", Offset = "0x7EB454")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 targetDistance;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 position;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rotation;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 smoothPosition;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x1700001D")]
		public float x
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0xF39C90", Offset = "0xF39C90", VA = "0xF39C90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F33D8", Offset = "0x7F33D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0xF39C98", Offset = "0xF39C98", VA = "0xF39C98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F33E8", Offset = "0x7F33E8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public float y
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0xF39CA0", Offset = "0xF39CA0", VA = "0xF39CA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F33F8", Offset = "0x7F33F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0xF39CA8", Offset = "0xF39CA8", VA = "0xF39CA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F3408", Offset = "0x7F3408")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public float distanceTarget
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0xF39CB0", Offset = "0xF39CB0", VA = "0xF39CB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F3418", Offset = "0x7F3418")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0xF39CB8", Offset = "0xF39CB8", VA = "0xF39CB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F3428", Offset = "0x7F3428")]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		private float zoomAdd
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xF3A728", Offset = "0xF3A728", VA = "0xF3A728")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xF39CC0", Offset = "0xF39CC0", VA = "0xF39CC0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xF39DDC", Offset = "0xF39DDC", VA = "0xF39DDC", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xF39E40", Offset = "0xF39E40", VA = "0xF39E40", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xF39EA8", Offset = "0xF39EA8", VA = "0xF39EA8", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xF39F0C", Offset = "0xF39F0C", VA = "0xF39F0C")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xF39E18", Offset = "0xF39E18", VA = "0xF39E18")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xF3A08C", Offset = "0xF3A08C", VA = "0xF3A08C")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xF3A678", Offset = "0xF3A678", VA = "0xF3A678")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xF3A79C", Offset = "0xF3A79C", VA = "0xF3A79C")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xF3A8B4", Offset = "0xF3A8B4", VA = "0xF3A8B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xF3A8EC", Offset = "0xF3A8EC", VA = "0xF3A8EC")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xF3AAA8", Offset = "0xF3AAA8", VA = "0xF3AAA8")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xF3AB58", Offset = "0xF3AB58", VA = "0xF3AB58")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000014")]
	public enum Axis
	{
		[Token(Token = "0x40000A5")]
		X,
		[Token(Token = "0x40000A6")]
		Y,
		[Token(Token = "0x40000A7")]
		Z
	}
	[Token(Token = "0x2000015")]
	public class AxisTools
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0xF32DF8", Offset = "0xF32DF8", VA = "0xF32DF8")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xF32EB8", Offset = "0xF32EB8", VA = "0xF32EB8")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xF32F64", Offset = "0xF32F64", VA = "0xF32F64")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xF3314C", Offset = "0xF3314C", VA = "0xF3314C")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xF33080", Offset = "0xF33080", VA = "0xF33080")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xF33268", Offset = "0xF33268", VA = "0xF33268")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xF33498", Offset = "0xF33498", VA = "0xF33498")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000016")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x20000C5")]
		public class LimbOrientation
		{
			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x600060D")]
			[Address(RVA = "0xF33760", Offset = "0xF33760", VA = "0xF33760")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000021")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0xF334EC", Offset = "0xF334EC", VA = "0xF334EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0xF337DC", Offset = "0xF337DC", VA = "0xF337DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xF334A0", Offset = "0xF334A0", VA = "0xF334A0")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000017")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x20000C6")]
		public enum BoneType
		{
			[Token(Token = "0x40005A6")]
			Unassigned,
			[Token(Token = "0x40005A7")]
			Spine,
			[Token(Token = "0x40005A8")]
			Head,
			[Token(Token = "0x40005A9")]
			Arm,
			[Token(Token = "0x40005AA")]
			Leg,
			[Token(Token = "0x40005AB")]
			Tail,
			[Token(Token = "0x40005AC")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x20000C7")]
		public enum BoneSide
		{
			[Token(Token = "0x40005AE")]
			Center,
			[Token(Token = "0x40005AF")]
			Left,
			[Token(Token = "0x40005B0")]
			Right
		}

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xF33A50", Offset = "0xF33A50", VA = "0xF33A50")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xF33D48", Offset = "0xF33D48", VA = "0xF33D48")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xF33F90", Offset = "0xF33F90", VA = "0xF33F90")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xF34014", Offset = "0xF34014", VA = "0xF34014")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xF340C4", Offset = "0xF340C4", VA = "0xF340C4")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xF33BF8", Offset = "0xF33BF8", VA = "0xF33BF8")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xF33EF0", Offset = "0xF33EF0", VA = "0xF33EF0")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xF34904", Offset = "0xF34904", VA = "0xF34904")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xF3471C", Offset = "0xF3471C", VA = "0xF3471C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xF34810", Offset = "0xF34810", VA = "0xF34810")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xF342E4", Offset = "0xF342E4", VA = "0xF342E4")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xF34398", Offset = "0xF34398", VA = "0xF34398")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xF3444C", Offset = "0xF3444C", VA = "0xF3444C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xF34500", Offset = "0xF34500", VA = "0xF34500")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xF345B4", Offset = "0xF345B4", VA = "0xF345B4")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xF34668", Offset = "0xF34668", VA = "0xF34668")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xF34B24", Offset = "0xF34B24", VA = "0xF34B24")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xF341F4", Offset = "0xF341F4", VA = "0xF341F4")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xF34A90", Offset = "0xF34A90", VA = "0xF34A90")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xF34B94", Offset = "0xF34B94", VA = "0xF34B94")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xF34C70", Offset = "0xF34C70", VA = "0xF34C70")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xF34A10", Offset = "0xF34A10", VA = "0xF34A10")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xF34994", Offset = "0xF34994", VA = "0xF34994")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public class BipedReferences
	{
		[Token(Token = "0x20000C8")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700008C")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x600060F")]
				[Address(RVA = "0xF39C88", Offset = "0xF39C88", VA = "0xF39C88")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x89562C", Offset = "0x89562C", VA = "0x89562C")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000023")]
		public virtual bool isFilled
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0xF367CC", Offset = "0xF367CC", VA = "0xF367CC", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000024")]
		public bool isEmpty
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0xF36BB8", Offset = "0xF36BB8", VA = "0xF36BB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xF36BC8", Offset = "0xF36BC8", VA = "0xF36BC8", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xF36FF4", Offset = "0xF36FF4", VA = "0xF36FF4", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xF37424", Offset = "0xF37424", VA = "0xF37424")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xF37A3C", Offset = "0xF37A3C", VA = "0xF37A3C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xF37674", Offset = "0xF37674", VA = "0xF37674")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xF381F4", Offset = "0xF381F4", VA = "0xF381F4")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xF382EC", Offset = "0xF382EC", VA = "0xF382EC")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xF38854", Offset = "0xF38854", VA = "0xF38854")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xF38650", Offset = "0xF38650", VA = "0xF38650")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xF384C4", Offset = "0xF384C4", VA = "0xF384C4")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xF3838C", Offset = "0xF3838C", VA = "0xF3838C")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xF38758", Offset = "0xF38758", VA = "0xF38758")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xF38954", Offset = "0xF38954", VA = "0xF38954")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xF39468", Offset = "0xF39468", VA = "0xF39468")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xF38EE0", Offset = "0xF38EE0", VA = "0xF38EE0")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xF39760", Offset = "0xF39760", VA = "0xF39760")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xF39284", Offset = "0xF39284", VA = "0xF39284")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xF39768", Offset = "0xF39768", VA = "0xF39768")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xF39770", Offset = "0xF39770", VA = "0xF39770")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xF39934", Offset = "0xF39934", VA = "0xF39934")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xF39B50", Offset = "0xF39B50", VA = "0xF39B50")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xF37604", Offset = "0xF37604", VA = "0xF37604")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xF3AB74", Offset = "0xF3AB74", VA = "0xF3AB74")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xF3AB7C", Offset = "0xF3AB7C", VA = "0xF3AB7C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xF3ACBC", Offset = "0xF3ACBC", VA = "0xF3ACBC")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class Hierarchy
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x10BE7C0", Offset = "0x10BE7C0", VA = "0x10BE7C0")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x10BE9C4", Offset = "0x10BE9C4", VA = "0x10BE9C4")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x10BE858", Offset = "0x10BE858", VA = "0x10BE858")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x10BEAE4", Offset = "0x10BEAE4", VA = "0x10BEAE4")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x10BEC10", Offset = "0x10BEC10", VA = "0x10BEC10")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x10BEEBC", Offset = "0x10BEEBC", VA = "0x10BEEBC")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x10BEFDC", Offset = "0x10BEFDC", VA = "0x10BEFDC")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x10BF168", Offset = "0x10BF168", VA = "0x10BF168")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x10BF500", Offset = "0x10BF500", VA = "0x10BF500")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x10BF2E8", Offset = "0x10BF2E8", VA = "0x10BF2E8")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x10BF6A4", Offset = "0x10BF6A4", VA = "0x10BF6A4")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x10BF6AC", Offset = "0x10BF6AC", VA = "0x10BF6AC")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x10BF71C", Offset = "0x10BF71C", VA = "0x10BF71C")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000D5")]
		None,
		[Token(Token = "0x40000D6")]
		InOutCubic,
		[Token(Token = "0x40000D7")]
		InOutQuintic,
		[Token(Token = "0x40000D8")]
		InOutSine,
		[Token(Token = "0x40000D9")]
		InQuintic,
		[Token(Token = "0x40000DA")]
		InQuartic,
		[Token(Token = "0x40000DB")]
		InCubic,
		[Token(Token = "0x40000DC")]
		InQuadratic,
		[Token(Token = "0x40000DD")]
		InElastic,
		[Token(Token = "0x40000DE")]
		InElasticSmall,
		[Token(Token = "0x40000DF")]
		InElasticBig,
		[Token(Token = "0x40000E0")]
		InSine,
		[Token(Token = "0x40000E1")]
		InBack,
		[Token(Token = "0x40000E2")]
		OutQuintic,
		[Token(Token = "0x40000E3")]
		OutQuartic,
		[Token(Token = "0x40000E4")]
		OutCubic,
		[Token(Token = "0x40000E5")]
		OutInCubic,
		[Token(Token = "0x40000E6")]
		OutInQuartic,
		[Token(Token = "0x40000E7")]
		OutElastic,
		[Token(Token = "0x40000E8")]
		OutElasticSmall,
		[Token(Token = "0x40000E9")]
		OutElasticBig,
		[Token(Token = "0x40000EA")]
		OutSine,
		[Token(Token = "0x40000EB")]
		OutBack,
		[Token(Token = "0x40000EC")]
		OutBackCubic,
		[Token(Token = "0x40000ED")]
		OutBackQuartic,
		[Token(Token = "0x40000EE")]
		BackInCubic,
		[Token(Token = "0x40000EF")]
		BackInQuartic
	}
	[Token(Token = "0x200001E")]
	public class Interp
	{
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x10BF78C", Offset = "0x10BF78C", VA = "0x10BF78C")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x10C01FC", Offset = "0x10C01FC", VA = "0x10C01FC")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x10C0304", Offset = "0x10C0304", VA = "0x10C0304")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x10BFAFC", Offset = "0x10BFAFC", VA = "0x10BFAFC")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x10BFB08", Offset = "0x10BFB08", VA = "0x10BFB08")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x10BFB30", Offset = "0x10BFB30", VA = "0x10BFB30")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x10BFB6C", Offset = "0x10BFB6C", VA = "0x10BFB6C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x10BFB84", Offset = "0x10BFB84", VA = "0x10BFB84")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x10BFB98", Offset = "0x10BFB98", VA = "0x10BFB98")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x10BFBAC", Offset = "0x10BFBAC", VA = "0x10BFBAC")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x10BFBBC", Offset = "0x10BFBBC", VA = "0x10BFBBC")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x10BFC04", Offset = "0x10BFC04", VA = "0x10BFC04")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x10BFC3C", Offset = "0x10BFC3C", VA = "0x10BFC3C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x10BFC64", Offset = "0x10BFC64", VA = "0x10BFC64")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x10C0400", Offset = "0x10C0400", VA = "0x10C0400")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x10BFC98", Offset = "0x10BFC98", VA = "0x10BFC98")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x10BFCC0", Offset = "0x10BFCC0", VA = "0x10BFCC0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x10BFCF0", Offset = "0x10BFCF0", VA = "0x10BFCF0")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x10BFD24", Offset = "0x10BFD24", VA = "0x10BFD24")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x10BFD68", Offset = "0x10BFD68", VA = "0x10BFD68")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x10BFDCC", Offset = "0x10BFDCC", VA = "0x10BFDCC")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x10BFE30", Offset = "0x10BFE30", VA = "0x10BFE30")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x10BFE84", Offset = "0x10BFE84", VA = "0x10BFE84")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x10BFED8", Offset = "0x10BFED8", VA = "0x10BFED8")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x10BFF70", Offset = "0x10BFF70", VA = "0x10BFF70")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x10C0004", Offset = "0x10C0004", VA = "0x10C0004")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x10C0434", Offset = "0x10C0434", VA = "0x10C0434")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x10C00A8", Offset = "0x10C00A8", VA = "0x10C00A8")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x10C018C", Offset = "0x10C018C", VA = "0x10C018C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x10C01BC", Offset = "0x10C01BC", VA = "0x10C01BC")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x10C051C", Offset = "0x10C051C", VA = "0x10C051C")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x10C0524", Offset = "0x10C0524", VA = "0x10C0524")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x10C0594", Offset = "0x10C0594", VA = "0x10C0594")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000020")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x10C0604", Offset = "0x10C0604", VA = "0x10C0604")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x10C0660", Offset = "0x10C0660", VA = "0x10C0660")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x10C0734", Offset = "0x10C0734", VA = "0x10C0734")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x10C0678", Offset = "0x10C0678", VA = "0x10C0678")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x10C074C", Offset = "0x10C074C", VA = "0x10C074C")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x10C07F0", Offset = "0x10C07F0", VA = "0x10C07F0")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x10C081C", Offset = "0x10C081C", VA = "0x10C081C")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x10C086C", Offset = "0x10C086C", VA = "0x10C086C")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x10C08D8", Offset = "0x10C08D8", VA = "0x10C08D8")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x10C09D0", Offset = "0x10C09D0", VA = "0x10C09D0")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x10C0AAC", Offset = "0x10C0AAC", VA = "0x10C0AAC")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x10C0B0C", Offset = "0x10C0B0C", VA = "0x10C0B0C")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000021")]
	public static class QuaTools
	{
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x10C0B3C", Offset = "0x10C0B3C", VA = "0x10C0B3C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x10C0C88", Offset = "0x10C0C88", VA = "0x10C0C88")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x10C0DD4", Offset = "0x10C0DD4", VA = "0x10C0DD4")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x10C0EE8", Offset = "0x10C0EE8", VA = "0x10C0EE8")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x10AD7A4", Offset = "0x10AD7A4", VA = "0x10AD7A4")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x10C0FFC", Offset = "0x10C0FFC", VA = "0x10C0FFC")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x10B3184", Offset = "0x10B3184", VA = "0x10B3184")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x10C10CC", Offset = "0x10C10CC", VA = "0x10C10CC")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x10C1350", Offset = "0x10C1350", VA = "0x10C1350")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x10C1564", Offset = "0x10C1564", VA = "0x10C1564")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x10BC594", Offset = "0x10BC594", VA = "0x10BC594")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000022")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000025")]
		public static T instance
		{
			[Token(Token = "0x6000112")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000113")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000114")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB474", Offset = "0x7EB474")]
		public bool fixTransforms;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000026")]
		private bool animatePhysics
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x10C181C", Offset = "0x10C181C", VA = "0x10C181C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		private bool isAnimated
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x10C1B20", Offset = "0x10C1B20", VA = "0x10C1B20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x10C16E4", Offset = "0x10C16E4", VA = "0x10C16E4")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x10C177C", Offset = "0x10C177C", VA = "0x10C177C", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x10C1780", Offset = "0x10C1780", VA = "0x10C1780", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x10C1784", Offset = "0x10C1784", VA = "0x10C1784", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x10C1788", Offset = "0x10C1788", VA = "0x10C1788")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x10C1818", Offset = "0x10C1818", VA = "0x10C1818")]
		private void Start()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x10C17C0", Offset = "0x10C17C0", VA = "0x10C17C0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x10C1AD0", Offset = "0x10C1AD0", VA = "0x10C1AD0")]
		private void Update()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x10C190C", Offset = "0x10C190C", VA = "0x10C190C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x10C1BDC", Offset = "0x10C1BDC", VA = "0x10C1BDC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x10C1C38", Offset = "0x10C1C38", VA = "0x10C1C38")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x10C1C98", Offset = "0x10C1C98", VA = "0x10C1C98")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x10B17C0", Offset = "0x10B17C0", VA = "0x10B17C0")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x10C1CE0", Offset = "0x10C1CE0", VA = "0x10C1CE0")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x10C1D98", Offset = "0x10C1D98", VA = "0x10C1D98")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x10C1E50", Offset = "0x10C1E50", VA = "0x10C1E50")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x10C1F08", Offset = "0x10C1F08", VA = "0x10C1F08")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public static class V3Tools
	{
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x10C1F10", Offset = "0x10C1F10", VA = "0x10C1F10")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x10C2008", Offset = "0x10C2008", VA = "0x10C2008")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x10C2100", Offset = "0x10C2100", VA = "0x10C2100")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x10C21F8", Offset = "0x10C21F8", VA = "0x10C21F8")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x10C22F8", Offset = "0x10C22F8", VA = "0x10C22F8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x10C2534", Offset = "0x10C2534", VA = "0x10C2534")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x10C2784", Offset = "0x10C2784", VA = "0x10C2784")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x10C2994", Offset = "0x10C2994", VA = "0x10C2994")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000026")]
	public static class Warning
	{
		[Token(Token = "0x20000C9")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x10C2B70", Offset = "0x10C2B70", VA = "0x10C2B70")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x10AACC4", Offset = "0x10AACC4", VA = "0x10AACC4")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E9F20", Offset = "0x7E9F20")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E9F20", Offset = "0x7E9F20")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xEEA81C", Offset = "0xEEA81C", VA = "0xEEA81C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F34A8", Offset = "0x7F34A8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xEEA868", Offset = "0xEEA868", VA = "0xEEA868")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F34E0", Offset = "0x7F34E0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xEEA8B4", Offset = "0xEEA8B4", VA = "0xEEA8B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3518", Offset = "0x7F3518")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xEEA900", Offset = "0xEEA900", VA = "0xEEA900")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3550", Offset = "0x7F3550")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xEEA94C", Offset = "0xEEA94C", VA = "0xEEA94C")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xEEA9EC", Offset = "0xEEA9EC", VA = "0xEEA9EC")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xEEAA0C", Offset = "0xEEAA0C", VA = "0xEEAA0C")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xEEAA3C", Offset = "0xEEAA3C", VA = "0xEEAA3C")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xEEAA6C", Offset = "0xEEAA6C", VA = "0xEEAA6C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xEEAAAC", Offset = "0xEEAAAC", VA = "0xEEAAAC")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xEEAAF0", Offset = "0xEEAAF0", VA = "0xEEAAF0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xEEAB14", Offset = "0xEEAB14", VA = "0xEEAB14")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xEEAB38", Offset = "0xEEAB38", VA = "0xEEAB38")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xEEAB64", Offset = "0xEEAB64", VA = "0xEEAB64")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xEEAB94", Offset = "0xEEAB94", VA = "0xEEAB94")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xEEABC4", Offset = "0xEEABC4", VA = "0xEEABC4")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xEEA96C", Offset = "0xEEA96C", VA = "0xEEA96C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xEEABF0", Offset = "0xEEABF0", VA = "0xEEABF0")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xEEABFC", Offset = "0xEEABFC", VA = "0xEEABFC")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xEEAC08", Offset = "0xEEAC08", VA = "0xEEAC08")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xEEAEFC", Offset = "0xEEAEFC", VA = "0xEEAEFC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xEEAFAC", Offset = "0xEEAFAC", VA = "0xEEAFAC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xEEB300", Offset = "0xEEB300", VA = "0xEEB300", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xEEB804", Offset = "0xEEB804", VA = "0xEEB804")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xEEB838", Offset = "0xEEB838", VA = "0xEEB838")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000028")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000028")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0xEEADB4", Offset = "0xEEADB4", VA = "0xEEADB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0xEEBA04", Offset = "0xEEBA04", VA = "0xEEBA04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xEEB184", Offset = "0xEEB184", VA = "0xEEB184")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xEEB8BC", Offset = "0xEEB8BC", VA = "0xEEB8BC")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000029")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700002A")]
		public bool isValid
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0xEEC010", Offset = "0xEEC010", VA = "0xEEC010")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000151")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xEEC080", Offset = "0xEEC080", VA = "0xEEC080")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002A")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xEEC088", Offset = "0xEEC088", VA = "0xEEC088", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xEEC198", Offset = "0xEEC198", VA = "0xEEC198")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xEEC1A0", Offset = "0xEEC1A0", VA = "0xEEC1A0")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700002B")]
		private bool positionChanged
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0xEEC370", Offset = "0xEEC370", VA = "0xEEC370")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xEEC1CC", Offset = "0xEEC1CC", VA = "0xEEC1CC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xEEC42C", Offset = "0xEEC42C", VA = "0xEEC42C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xEEC434", Offset = "0xEEC434", VA = "0xEEC434")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xEEC460", Offset = "0xEEC460", VA = "0xEEC460", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xEEC58C", Offset = "0xEEC58C", VA = "0xEEC58C")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xEEC594", Offset = "0xEEC594", VA = "0xEEC594")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700002C")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0xEEC768", Offset = "0xEEC768", VA = "0xEEC768")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xEEC5C0", Offset = "0xEEC5C0", VA = "0xEEC5C0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xEEC838", Offset = "0xEEC838", VA = "0xEEC838")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xEEC840", Offset = "0xEEC840", VA = "0xEEC840")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class Constraints
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB4AC", Offset = "0x7EB4AC")]
		public float positionWeight;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB4C4", Offset = "0x7EB4C4")]
		public float rotationWeight;

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xEEC86C", Offset = "0xEEC86C", VA = "0xEEC86C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xEEB2A8", Offset = "0xEEB2A8", VA = "0xEEB2A8")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xEEB49C", Offset = "0xEEB49C", VA = "0xEEB49C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xEEBBD0", Offset = "0xEEBBD0", VA = "0xEEBBD0")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x20000CA")]
		public enum DOF
		{
			[Token(Token = "0x40005B4")]
			One,
			[Token(Token = "0x40005B5")]
			Three
		}

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB4DC", Offset = "0x7EB4DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB4DC", Offset = "0x7EB4DC")]
		public float weight;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB530", Offset = "0x7EB530")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB530", Offset = "0x7EB530")]
		public float rotationWeight;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB584", Offset = "0x7EB584")]
		public DOF rotationDOF;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB5BC", Offset = "0x7EB5BC")]
		public Transform bone1;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB5F4", Offset = "0x7EB5F4")]
		public Transform bone2;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB62C", Offset = "0x7EB62C")]
		public Transform bone3;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB664", Offset = "0x7EB664")]
		public Transform tip;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB69C", Offset = "0x7EB69C")]
		public Transform target;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EB6D4", Offset = "0x7EB6D4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x1700002D")]
		public bool initiated
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0xEF3B7C", Offset = "0xEF3B7C", VA = "0xEF3B7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F3588", Offset = "0x7F3588")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0xEF3B84", Offset = "0xEF3B84", VA = "0xEF3B84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F3598", Offset = "0x7F3598")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0xEF3B90", Offset = "0xEF3B90", VA = "0xEF3B90")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000168")]
			[Address(RVA = "0xEF3BB4", Offset = "0xEF3BB4", VA = "0xEF3BB4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0xEF3BD8", Offset = "0xEF3BD8", VA = "0xEF3BD8")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0xEF3BFC", Offset = "0xEF3BFC", VA = "0xEF3BFC")]
			set
			{
			}
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xEF3C20", Offset = "0xEF3C20", VA = "0xEF3C20")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xEF3D20", Offset = "0xEF3D20", VA = "0xEF3D20")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xEF4140", Offset = "0xEF4140", VA = "0xEF4140")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xEF421C", Offset = "0xEF421C", VA = "0xEF421C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xEF42E4", Offset = "0xEF42E4", VA = "0xEF42E4")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xEF46D8", Offset = "0xEF46D8", VA = "0xEF46D8")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB6E4", Offset = "0x7EB6E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB6E4", Offset = "0x7EB6E4")]
		public float weight;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EB738", Offset = "0x7EB738")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000030")]
		public bool initiated
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xEF46E8", Offset = "0xEF46E8", VA = "0xEF46E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F35A8", Offset = "0x7F35A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0xEF46F0", Offset = "0xEF46F0", VA = "0xEF46F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F35B8", Offset = "0x7F35B8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xEF46FC", Offset = "0xEF46FC", VA = "0xEF46FC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xEF4790", Offset = "0xEF4790", VA = "0xEF4790")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F35C8", Offset = "0x7F35C8")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xEF4AC0", Offset = "0xEF4AC0", VA = "0xEF4AC0")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xEF4C34", Offset = "0xEF4C34", VA = "0xEF4C34")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xEF49B4", Offset = "0xEF49B4", VA = "0xEF49B4")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xEF4DB8", Offset = "0xEF4DB8", VA = "0xEF4DB8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xEF4E80", Offset = "0xEF4E80", VA = "0xEF4E80")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xEF4F04", Offset = "0xEF4F04", VA = "0xEF4F04")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xEF4F84", Offset = "0xEF4F84", VA = "0xEF4F84")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xEF4FF8", Offset = "0xEF4FF8", VA = "0xEF4FF8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xEF4FFC", Offset = "0xEF4FFC", VA = "0xEF4FFC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xEF5010", Offset = "0xEF5010", VA = "0xEF5010")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x20000CB")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB748", Offset = "0x7EB748")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB748", Offset = "0x7EB748")]
		public float weight;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB79C", Offset = "0x7EB79C")]
		public Grounding solver;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EB7D4", Offset = "0x7EB7D4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000031")]
		public bool initiated
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0xEF6088", Offset = "0xEF6088", VA = "0xEF6088")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F3600", Offset = "0x7F3600")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000181")]
			[Address(RVA = "0xEF6090", Offset = "0xEF6090", VA = "0xEF6090")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F3610", Offset = "0x7F3610")]
			protected set
			{
			}
		}

		[Token(Token = "0x600017F")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xEF609C", Offset = "0xEF609C", VA = "0xEF609C")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xEF6378", Offset = "0xEF6378", VA = "0xEF6378")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xEF61E4", Offset = "0xEF61E4", VA = "0xEF61E4")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xEF63AC", Offset = "0xEF63AC", VA = "0xEF63AC")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000186")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000187")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xEF65B8", Offset = "0xEF65B8", VA = "0xEF65B8")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E9F80", Offset = "0x7E9F80")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E9F80", Offset = "0x7E9F80")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB7E4", Offset = "0x7EB7E4")]
		public BipedIK ik;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB81C", Offset = "0x7EB81C")]
		public float spineBend;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB854", Offset = "0x7EB854")]
		public float spineSpeed;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xEF6940", Offset = "0xEF6940", VA = "0xEF6940", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3620", Offset = "0x7F3620")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xEF698C", Offset = "0xEF698C", VA = "0xEF698C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3658", Offset = "0x7F3658")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xEF69D8", Offset = "0xEF69D8", VA = "0xEF69D8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xEF6AEC", Offset = "0xEF6AEC", VA = "0xEF6AEC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xEF6BA0", Offset = "0xEF6BA0", VA = "0xEF6BA0")]
		private void Update()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xEF6C54", Offset = "0xEF6C54", VA = "0xEF6C54")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xEF7194", Offset = "0xEF7194", VA = "0xEF7194")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xEF71EC", Offset = "0xEF71EC", VA = "0xEF71EC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xEF79BC", Offset = "0xEF79BC", VA = "0xEF79BC")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xEF7B28", Offset = "0xEF7B28", VA = "0xEF7B28")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xEF7CB8", Offset = "0xEF7CB8", VA = "0xEF7CB8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xEF7E30", Offset = "0xEF7E30", VA = "0xEF7E30")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E9FE0", Offset = "0x7E9FE0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E9FE0", Offset = "0x7E9FE0")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000CC")]
		public class SpineEffector
		{
			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFC58", Offset = "0x7EFC58")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFC90", Offset = "0x7EFC90")]
			public float horizontalWeight;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFCC8", Offset = "0x7EFCC8")]
			public float verticalWeight;

			[Token(Token = "0x6000618")]
			[Address(RVA = "0xEF8CC0", Offset = "0xEF8CC0", VA = "0xEF8CC0")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0xEF8CD0", Offset = "0xEF8CD0", VA = "0xEF8CD0")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB88C", Offset = "0x7EB88C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB8C4", Offset = "0x7EB8C4")]
		public float spineBend;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB8FC", Offset = "0x7EB8FC")]
		public float spineSpeed;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xEF7EB0", Offset = "0xEF7EB0", VA = "0xEF7EB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3690", Offset = "0x7F3690")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xEF7EFC", Offset = "0xEF7EFC", VA = "0xEF7EFC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F36C8", Offset = "0x7F36C8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xEF7F48", Offset = "0xEF7F48", VA = "0xEF7F48", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3700", Offset = "0x7F3700")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xEF7F94", Offset = "0xEF7F94", VA = "0xEF7F94", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xEF8014", Offset = "0xEF8014", VA = "0xEF8014")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xEF80B0", Offset = "0xEF80B0", VA = "0xEF80B0")]
		private void Update()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xEF8370", Offset = "0xEF8370", VA = "0xEF8370")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xEF837C", Offset = "0xEF837C", VA = "0xEF837C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xEF816C", Offset = "0xEF816C", VA = "0xEF816C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xEF8388", Offset = "0xEF8388", VA = "0xEF8388")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xEF8840", Offset = "0xEF8840", VA = "0xEF8840")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xEF8A04", Offset = "0xEF8A04", VA = "0xEF8A04")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xEF8B3C", Offset = "0xEF8B3C", VA = "0xEF8B3C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xEF8C40", Offset = "0xEF8C40", VA = "0xEF8C40")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA040", Offset = "0x7EA040")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA040", Offset = "0x7EA040")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB934", Offset = "0x7EB934")]
		public Transform pelvis;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB96C", Offset = "0x7EB96C")]
		public Transform characterRoot;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB9A4", Offset = "0x7EB9A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB9A4", Offset = "0x7EB9A4")]
		public float rootRotationWeight;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB9F8", Offset = "0x7EB9F8")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBA30", Offset = "0x7EBA30")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xEF8D18", Offset = "0xEF8D18", VA = "0xEF8D18", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3738", Offset = "0x7F3738")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xEF8D64", Offset = "0xEF8D64", VA = "0xEF8D64", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3770", Offset = "0x7F3770")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xEF8DB0", Offset = "0xEF8DB0", VA = "0xEF8DB0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xEF8DC8", Offset = "0xEF8DC8", VA = "0xEF8DC8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xEF8FB8", Offset = "0xEF8FB8", VA = "0xEF8FB8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xEF90C8", Offset = "0xEF90C8", VA = "0xEF90C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xEF9820", Offset = "0xEF9820", VA = "0xEF9820")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xEF9C30", Offset = "0xEF9C30", VA = "0xEF9C30")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xEF9EA8", Offset = "0xEF9EA8", VA = "0xEF9EA8")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xEFA1D4", Offset = "0xEFA1D4", VA = "0xEFA1D4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xEFA36C", Offset = "0xEFA36C", VA = "0xEFA36C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xEFA538", Offset = "0xEFA538", VA = "0xEFA538")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA0A0", Offset = "0x7EA0A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA0A0", Offset = "0x7EA0A0")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x20000CD")]
		public struct Foot
		{
			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x895364", Offset = "0x895364", VA = "0x895364")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBA68", Offset = "0x7EBA68")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBAA0", Offset = "0x7EBAA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EBAA0", Offset = "0x7EBAA0")]
		public float rootRotationWeight;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBAF4", Offset = "0x7EBAF4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EBAF4", Offset = "0x7EBAF4")]
		public float minRootRotation;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBB4C", Offset = "0x7EBB4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EBB4C", Offset = "0x7EBB4C")]
		public float maxRootRotation;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBBA4", Offset = "0x7EBBA4")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBBDC", Offset = "0x7EBBDC")]
		public float maxLegOffset;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBC14", Offset = "0x7EBC14")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBC4C", Offset = "0x7EBC4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EBC4C", Offset = "0x7EBC4C")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBCA0", Offset = "0x7EBCA0")]
		public Transform characterRoot;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBCD8", Offset = "0x7EBCD8")]
		public Transform pelvis;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBD10", Offset = "0x7EBD10")]
		public Transform lastSpineBone;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBD48", Offset = "0x7EBD48")]
		public Transform head;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xEFA5B8", Offset = "0xEFA5B8", VA = "0xEFA5B8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F37A8", Offset = "0x7F37A8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xEFA604", Offset = "0xEFA604", VA = "0xEFA604", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F37E0", Offset = "0x7F37E0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xEFA650", Offset = "0xEFA650", VA = "0xEFA650", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xEFA684", Offset = "0xEFA684", VA = "0xEFA684")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xEFA7B8", Offset = "0xEFA7B8", VA = "0xEFA7B8")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xEFA974", Offset = "0xEFA974", VA = "0xEFA974")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xEFA9EC", Offset = "0xEFA9EC", VA = "0xEFA9EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xEFAAA4", Offset = "0xEFAAA4", VA = "0xEFAAA4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xEFADB4", Offset = "0xEFADB4", VA = "0xEFADB4")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xEFB0FC", Offset = "0xEFB0FC", VA = "0xEFB0FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xEFB248", Offset = "0xEFB248", VA = "0xEFB248")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xEFB6F8", Offset = "0xEFB6F8", VA = "0xEFB6F8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xEFBEFC", Offset = "0xEFBEFC", VA = "0xEFBEFC")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xEFC1C0", Offset = "0xEFC1C0", VA = "0xEFC1C0")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xEFC324", Offset = "0xEFC324", VA = "0xEFC324")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xEFC60C", Offset = "0xEFC60C", VA = "0xEFC60C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xEFC650", Offset = "0xEFC650", VA = "0xEFC650")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xEFC814", Offset = "0xEFC814", VA = "0xEFC814")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA100", Offset = "0x7EA100")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBD90", Offset = "0x7EBD90")]
		public VRIK ik;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xEFC930", Offset = "0xEFC930", VA = "0xEFC930")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3818", Offset = "0x7F3818")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xEFC934", Offset = "0xEFC934", VA = "0xEFC934", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3850", Offset = "0x7F3850")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xEFC938", Offset = "0xEFC938", VA = "0xEFC938", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3888", Offset = "0x7F3888")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xEFC93C", Offset = "0xEFC93C", VA = "0xEFC93C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xEFC954", Offset = "0xEFC954", VA = "0xEFC954")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xEFC9F0", Offset = "0xEFC9F0", VA = "0xEFC9F0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xEFCAA4", Offset = "0xEFCAA4", VA = "0xEFCAA4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xEFCCB0", Offset = "0xEFCCB0", VA = "0xEFCCB0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xEFCF50", Offset = "0xEFCF50", VA = "0xEFCF50")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xEFD05C", Offset = "0xEFD05C", VA = "0xEFD05C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xEFD268", Offset = "0xEFD268", VA = "0xEFD268")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xEFD3A0", Offset = "0xEFD3A0", VA = "0xEFD3A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xEFD508", Offset = "0xEFD508", VA = "0xEFD508")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000037")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x20000CE")]
		public enum Quality
		{
			[Token(Token = "0x40005BE")]
			Fastest,
			[Token(Token = "0x40005BF")]
			Simple,
			[Token(Token = "0x40005C0")]
			Best
		}

		[Token(Token = "0x20000CF")]
		public class Leg
		{
			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EFD00", Offset = "0x7EFD00")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EFD10", Offset = "0x7EFD10")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EFD20", Offset = "0x7EFD20")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EFD30", Offset = "0x7EFD30")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EFD40", Offset = "0x7EFD40")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EFD50", Offset = "0x7EFD50")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EFD60", Offset = "0x7EFD60")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x1700008D")]
			public bool isGrounded
			{
				[Token(Token = "0x600061B")]
				[Address(RVA = "0xEFEA08", Offset = "0xEFEA08", VA = "0xEFEA08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5360", Offset = "0x7F5360")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600061C")]
				[Address(RVA = "0xEFEA10", Offset = "0xEFEA10", VA = "0xEFEA10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5370", Offset = "0x7F5370")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008E")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x600061D")]
				[Address(RVA = "0xEFEA1C", Offset = "0xEFEA1C", VA = "0xEFEA1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5380", Offset = "0x7F5380")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600061E")]
				[Address(RVA = "0xEFEA28", Offset = "0xEFEA28", VA = "0xEFEA28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5390", Offset = "0x7F5390")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008F")]
			public bool initiated
			{
				[Token(Token = "0x600061F")]
				[Address(RVA = "0xEFEA34", Offset = "0xEFEA34", VA = "0xEFEA34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F53A0", Offset = "0x7F53A0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000620")]
				[Address(RVA = "0xEFEA3C", Offset = "0xEFEA3C", VA = "0xEFEA3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F53B0", Offset = "0x7F53B0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000090")]
			public float heightFromGround
			{
				[Token(Token = "0x6000621")]
				[Address(RVA = "0xEFEA48", Offset = "0xEFEA48", VA = "0xEFEA48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F53C0", Offset = "0x7F53C0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000622")]
				[Address(RVA = "0xEFEA50", Offset = "0xEFEA50", VA = "0xEFEA50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F53D0", Offset = "0x7F53D0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000091")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000623")]
				[Address(RVA = "0xEFEA58", Offset = "0xEFEA58", VA = "0xEFEA58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F53E0", Offset = "0x7F53E0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000624")]
				[Address(RVA = "0xEFEA64", Offset = "0xEFEA64", VA = "0xEFEA64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F53F0", Offset = "0x7F53F0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000092")]
			public Transform transform
			{
				[Token(Token = "0x6000625")]
				[Address(RVA = "0xEFEA70", Offset = "0xEFEA70", VA = "0xEFEA70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5400", Offset = "0x7F5400")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000626")]
				[Address(RVA = "0xEFEA78", Offset = "0xEFEA78", VA = "0xEFEA78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5410", Offset = "0x7F5410")]
				private set
				{
				}
			}

			[Token(Token = "0x17000093")]
			public float IKOffset
			{
				[Token(Token = "0x6000627")]
				[Address(RVA = "0xEFEA80", Offset = "0xEFEA80", VA = "0xEFEA80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5420", Offset = "0x7F5420")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000628")]
				[Address(RVA = "0xEFEA88", Offset = "0xEFEA88", VA = "0xEFEA88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5430", Offset = "0x7F5430")]
				private set
				{
				}
			}

			[Token(Token = "0x17000094")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x600062D")]
				[Address(RVA = "0xEFF600", Offset = "0xEFF600", VA = "0xEFF600")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000095")]
			private float rootYOffset
			{
				[Token(Token = "0x6000636")]
				[Address(RVA = "0xEFF908", Offset = "0xEFF908", VA = "0xEFF908")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0xEFDBA8", Offset = "0xEFDBA8", VA = "0xEFDBA8")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0xEFEA90", Offset = "0xEFEA90", VA = "0xEFEA90")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0xEFE528", Offset = "0xEFE528", VA = "0xEFE528")]
			public void Reset()
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0xEFDCA8", Offset = "0xEFDCA8", VA = "0xEFDCA8")]
			public void Process()
			{
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0xEFF180", Offset = "0xEFF180", VA = "0xEFF180")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0xEFEADC", Offset = "0xEFEADC", VA = "0xEFEADC")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0xEFF788", Offset = "0xEFF788", VA = "0xEFF788")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0xEFEE08", Offset = "0xEFEE08", VA = "0xEFEE08")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0xEFEF10", Offset = "0xEFEF10", VA = "0xEFEF10")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0xEFF888", Offset = "0xEFF888", VA = "0xEFF888")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000634")]
			[Address(RVA = "0xEFF690", Offset = "0xEFF690", VA = "0xEFF690")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000635")]
			[Address(RVA = "0xEFFA44", Offset = "0xEFFA44", VA = "0xEFFA44")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000637")]
			[Address(RVA = "0xEFDB00", Offset = "0xEFDB00", VA = "0xEFDB00")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000D0")]
		public class Pelvis
		{
			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EFD70", Offset = "0x7EFD70")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EFD80", Offset = "0x7EFD80")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x17000096")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000638")]
				[Address(RVA = "0x146B084", Offset = "0x146B084", VA = "0x146B084")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5440", Offset = "0x7F5440")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000639")]
				[Address(RVA = "0x146B090", Offset = "0x146B090", VA = "0x146B090")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5450", Offset = "0x7F5450")]
				private set
				{
				}
			}

			[Token(Token = "0x17000097")]
			public float heightOffset
			{
				[Token(Token = "0x600063A")]
				[Address(RVA = "0x146B09C", Offset = "0x146B09C", VA = "0x146B09C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5460", Offset = "0x7F5460")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600063B")]
				[Address(RVA = "0x146B0A4", Offset = "0x146B0A4", VA = "0x146B0A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5470", Offset = "0x7F5470")]
				private set
				{
				}
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x146B0AC", Offset = "0x146B0AC", VA = "0x146B0AC")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x146B120", Offset = "0x146B120", VA = "0x146B120")]
			public void Reset()
			{
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0x146B0BC", Offset = "0x146B0BC", VA = "0x146B0BC")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0x146B1D4", Offset = "0x146B1D4", VA = "0x146B1D4")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x146B428", Offset = "0x146B428", VA = "0x146B428")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBDC8", Offset = "0x7EBDC8")]
		public LayerMask layers;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBE00", Offset = "0x7EBE00")]
		public float maxStep;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBE38", Offset = "0x7EBE38")]
		public float heightOffset;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBE70", Offset = "0x7EBE70")]
		public float footSpeed;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBEA8", Offset = "0x7EBEA8")]
		public float footRadius;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBEE0", Offset = "0x7EBEE0")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBF2C", Offset = "0x7EBF2C")]
		public float prediction;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBF64", Offset = "0x7EBF64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EBF64", Offset = "0x7EBF64")]
		public float footRotationWeight;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBFB8", Offset = "0x7EBFB8")]
		public float footRotationSpeed;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBFF0", Offset = "0x7EBFF0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EBFF0", Offset = "0x7EBFF0")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC048", Offset = "0x7EC048")]
		public bool rotateSolver;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC080", Offset = "0x7EC080")]
		public float pelvisSpeed;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC0B8", Offset = "0x7EC0B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EC0B8", Offset = "0x7EC0B8")]
		public float pelvisDamper;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC10C", Offset = "0x7EC10C")]
		public float lowerPelvisWeight;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC144", Offset = "0x7EC144")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC17C", Offset = "0x7EC17C")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC1B4", Offset = "0x7EC1B4")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC1EC", Offset = "0x7EC1EC")]
		public Quality quality;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EC224", Offset = "0x7EC224")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EC234", Offset = "0x7EC234")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EC244", Offset = "0x7EC244")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EC254", Offset = "0x7EC254")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EC264", Offset = "0x7EC264")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000032")]
		public Leg[] legs
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0xEFD564", Offset = "0xEFD564", VA = "0xEFD564")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F38C0", Offset = "0x7F38C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0xEFD56C", Offset = "0xEFD56C", VA = "0xEFD56C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F38D0", Offset = "0x7F38D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0xEFD574", Offset = "0xEFD574", VA = "0xEFD574")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F38E0", Offset = "0x7F38E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0xEFD57C", Offset = "0xEFD57C", VA = "0xEFD57C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F38F0", Offset = "0x7F38F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public bool isGrounded
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0xEFD584", Offset = "0xEFD584", VA = "0xEFD584")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F3900", Offset = "0x7F3900")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0xEFD58C", Offset = "0xEFD58C", VA = "0xEFD58C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F3910", Offset = "0x7F3910")]
			private set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public Transform root
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0xEFD598", Offset = "0xEFD598", VA = "0xEFD598")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F3920", Offset = "0x7F3920")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0xEFD5A0", Offset = "0xEFD5A0", VA = "0xEFD5A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F3930", Offset = "0x7F3930")]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0xEFD5A8", Offset = "0xEFD5A8", VA = "0xEFD5A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F3940", Offset = "0x7F3940")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0xEFD5C4", Offset = "0xEFD5C4", VA = "0xEFD5C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F3950", Offset = "0x7F3950")]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0xEFD5E4", Offset = "0xEFD5E4", VA = "0xEFD5E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public Vector3 up
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xEF7A9C", Offset = "0xEF7A9C", VA = "0xEF7A9C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000039")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xEFE5DC", Offset = "0xEFE5DC", VA = "0xEFE5DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xEFD63C", Offset = "0xEFD63C", VA = "0xEFD63C")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xEFDA24", Offset = "0xEFDA24", VA = "0xEFDA24")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xEF6F14", Offset = "0xEF6F14", VA = "0xEF6F14")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xEF7744", Offset = "0xEF7744", VA = "0xEF7744")]
		public void Update()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xEF9604", Offset = "0xEF9604", VA = "0xEF9604")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xEF6A58", Offset = "0xEF6A58", VA = "0xEF6A58")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xEFDC90", Offset = "0xEFDC90", VA = "0xEFDC90")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xEFE6AC", Offset = "0xEFE6AC", VA = "0xEFE6AC")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xEFE814", Offset = "0xEFE814", VA = "0xEFE814")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xEFE918", Offset = "0xEFE918", VA = "0xEFE918")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xEF667C", Offset = "0xEF667C", VA = "0xEF667C")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA138", Offset = "0x7EA138")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA138", Offset = "0x7EA138")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xEE99D4", Offset = "0xEE99D4", VA = "0xEE99D4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3960", Offset = "0x7F3960")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xEE9A20", Offset = "0xEE9A20", VA = "0xEE9A20", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3998", Offset = "0x7F3998")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xEE9A6C", Offset = "0xEE9A6C", VA = "0xEE9A6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F39D0", Offset = "0x7F39D0")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xEE9AB8", Offset = "0xEE9AB8", VA = "0xEE9AB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3A08", Offset = "0x7F3A08")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xEE9B04", Offset = "0xEE9B04", VA = "0xEE9B04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3A40", Offset = "0x7F3A40")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xEE9B50", Offset = "0xEE9B50", VA = "0xEE9B50", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xEE9B58", Offset = "0xEE9B58", VA = "0xEE9B58")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA198", Offset = "0x7EA198")]
	public class ArmIK : IK
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xEEA63C", Offset = "0xEEA63C", VA = "0xEEA63C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3A78", Offset = "0x7F3A78")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xEEA6A8", Offset = "0xEEA6A8", VA = "0xEEA6A8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3AB0", Offset = "0x7F3AB0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xEEA714", Offset = "0xEEA714", VA = "0xEEA714")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3AE8", Offset = "0x7F3AE8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xEEA760", Offset = "0xEEA760", VA = "0xEEA760")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3B20", Offset = "0x7F3B20")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xEEA7AC", Offset = "0xEEA7AC", VA = "0xEEA7AC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xEEA7B4", Offset = "0xEEA7B4", VA = "0xEEA7B4")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA1D0", Offset = "0x7EA1D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA1D0", Offset = "0x7EA1D0")]
	public class CCDIK : IK
	{
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xEEBE70", Offset = "0xEEBE70", VA = "0xEEBE70", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3B58", Offset = "0x7F3B58")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xEEBEBC", Offset = "0xEEBEBC", VA = "0xEEBEBC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3B90", Offset = "0x7F3B90")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xEEBF08", Offset = "0xEEBF08", VA = "0xEEBF08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3BC8", Offset = "0x7F3BC8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xEEBF54", Offset = "0xEEBF54", VA = "0xEEBF54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3C00", Offset = "0x7F3C00")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xEEBFA0", Offset = "0xEEBFA0", VA = "0xEEBFA0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xEEBFA8", Offset = "0xEEBFA8", VA = "0xEEBFA8")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA230", Offset = "0x7EA230")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA230", Offset = "0x7EA230")]
	public class FABRIK : IK
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xEEC8DC", Offset = "0xEEC8DC", VA = "0xEEC8DC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3C38", Offset = "0x7F3C38")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xEEC928", Offset = "0xEEC928", VA = "0xEEC928", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3C70", Offset = "0x7F3C70")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xEEC974", Offset = "0xEEC974", VA = "0xEEC974")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3CA8", Offset = "0x7F3CA8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xEEC9C0", Offset = "0xEEC9C0", VA = "0xEEC9C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3CE0", Offset = "0x7F3CE0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xEECA0C", Offset = "0xEECA0C", VA = "0xEECA0C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xEECA14", Offset = "0xEECA14", VA = "0xEECA14")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA290", Offset = "0x7EA290")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA290", Offset = "0x7EA290")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xEED0A8", Offset = "0xEED0A8", VA = "0xEED0A8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3D18", Offset = "0x7F3D18")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xEED0F4", Offset = "0xEED0F4", VA = "0xEED0F4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3D50", Offset = "0x7F3D50")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xEED140", Offset = "0xEED140", VA = "0xEED140")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3D88", Offset = "0x7F3D88")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xEED18C", Offset = "0xEED18C", VA = "0xEED18C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3DC0", Offset = "0x7F3DC0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xEED1D8", Offset = "0xEED1D8", VA = "0xEED1D8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xEED1E0", Offset = "0xEED1E0", VA = "0xEED1E0")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA2F0", Offset = "0x7EA2F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA2F0", Offset = "0x7EA2F0")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xEF5078", Offset = "0xEF5078", VA = "0xEF5078", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3DF8", Offset = "0x7F3DF8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xEF50C4", Offset = "0xEF50C4", VA = "0xEF50C4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3E30", Offset = "0x7F3E30")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xEF5110", Offset = "0xEF5110", VA = "0xEF5110")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3E68", Offset = "0x7F3E68")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xEF515C", Offset = "0xEF515C", VA = "0xEF515C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3EA0", Offset = "0x7F3EA0")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xEF51A8", Offset = "0xEF51A8", VA = "0xEF51A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3ED8", Offset = "0x7F3ED8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xEF51F4", Offset = "0xEF51F4", VA = "0xEF51F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3F10", Offset = "0x7F3F10")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xEF5240", Offset = "0xEF5240", VA = "0xEF5240")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xEF5264", Offset = "0xEF5264", VA = "0xEF5264", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xEF526C", Offset = "0xEF526C", VA = "0xEF526C")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xEF5430", Offset = "0xEF5430", VA = "0xEF5430")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xEF5788", Offset = "0xEF5788", VA = "0xEF5788")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3F48", Offset = "0x7F3F48")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xEF57AC", Offset = "0xEF57AC", VA = "0xEF57AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3F80", Offset = "0x7F3F80")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xEF588C", Offset = "0xEF588C", VA = "0xEF588C")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000212")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x146E100", Offset = "0x146E100", VA = "0x146E100", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x146E1EC", Offset = "0x146E1EC", VA = "0x146E1EC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x146E3B0", Offset = "0x146E3B0", VA = "0x146E3B0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000216")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000217")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x146E410", Offset = "0x146E410", VA = "0x146E410")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC274", Offset = "0x7EC274")]
		public IK[] IKComponents;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC2AC", Offset = "0x7EC2AC")]
		public Animator animator;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700003A")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x1471450", Offset = "0x1471450", VA = "0x1471450")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x14714EC", Offset = "0x14714EC", VA = "0x14714EC")]
		private void Start()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1471564", Offset = "0x1471564", VA = "0x1471564")]
		private void Update()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1471634", Offset = "0x1471634", VA = "0x1471634")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1471670", Offset = "0x1471670", VA = "0x1471670")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1471598", Offset = "0x1471598", VA = "0x1471598")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1471704", Offset = "0x1471704", VA = "0x1471704")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA350", Offset = "0x7EA350")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x10AE9C8", Offset = "0x10AE9C8", VA = "0x10AE9C8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3FB8", Offset = "0x7F3FB8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x10AEA34", Offset = "0x10AEA34", VA = "0x10AEA34", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F3FF0", Offset = "0x7F3FF0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x10AEAA0", Offset = "0x10AEAA0", VA = "0x10AEAA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4028", Offset = "0x7F4028")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x10AEAEC", Offset = "0x10AEAEC", VA = "0x10AEAEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4060", Offset = "0x7F4060")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x10AEB38", Offset = "0x10AEB38", VA = "0x10AEB38", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x10AEB40", Offset = "0x10AEB40", VA = "0x10AEB40")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA388", Offset = "0x7EA388")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA388", Offset = "0x7EA388")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x10AEBA8", Offset = "0x10AEBA8", VA = "0x10AEBA8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4098", Offset = "0x7F4098")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x10AEBF4", Offset = "0x10AEBF4", VA = "0x10AEBF4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F40D0", Offset = "0x7F40D0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x10AEC40", Offset = "0x10AEC40", VA = "0x10AEC40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4108", Offset = "0x7F4108")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x10AEC8C", Offset = "0x10AEC8C", VA = "0x10AEC8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4140", Offset = "0x7F4140")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x10AECD8", Offset = "0x10AECD8", VA = "0x10AECD8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x10AECE0", Offset = "0x10AECE0", VA = "0x10AECE0")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA3E8", Offset = "0x7EA3E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA3E8", Offset = "0x7EA3E8")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x10AFB8C", Offset = "0x10AFB8C", VA = "0x10AFB8C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4178", Offset = "0x7F4178")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x10AFBD8", Offset = "0x10AFBD8", VA = "0x10AFBD8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F41B0", Offset = "0x7F41B0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x10AFC24", Offset = "0x10AFC24", VA = "0x10AFC24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F41E8", Offset = "0x7F41E8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x10AFC70", Offset = "0x10AFC70", VA = "0x10AFC70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4220", Offset = "0x7F4220")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x10AFCBC", Offset = "0x10AFCBC", VA = "0x10AFCBC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x10AFCC4", Offset = "0x10AFCC4", VA = "0x10AFCC4")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA448", Offset = "0x7EA448")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA448", Offset = "0x7EA448")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x10B9004", Offset = "0x10B9004", VA = "0x10B9004", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4258", Offset = "0x7F4258")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x10B9050", Offset = "0x10B9050", VA = "0x10B9050", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4290", Offset = "0x7F4290")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x10B909C", Offset = "0x10B909C", VA = "0x10B909C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F42C8", Offset = "0x7F42C8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x10B90E8", Offset = "0x10B90E8", VA = "0x10B90E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4300", Offset = "0x7F4300")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x10B9134", Offset = "0x10B9134", VA = "0x10B9134", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x10B913C", Offset = "0x10B913C", VA = "0x10B913C")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA4A8", Offset = "0x7EA4A8")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000D1")]
		public class References
		{
			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFD90", Offset = "0x7EFD90")]
			public Transform chest;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFDC8", Offset = "0x7EFDC8")]
			public Transform neck;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFE00", Offset = "0x7EFE00")]
			public Transform leftShoulder;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFE38", Offset = "0x7EFE38")]
			public Transform rightShoulder;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFE70", Offset = "0x7EFE70")]
			public Transform leftThigh;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFEA8", Offset = "0x7EFEA8")]
			public Transform leftCalf;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFEE0", Offset = "0x7EFEE0")]
			public Transform leftFoot;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFF18", Offset = "0x7EFF18")]
			public Transform leftToes;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFF50", Offset = "0x7EFF50")]
			public Transform rightThigh;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFF88", Offset = "0x7EFF88")]
			public Transform rightCalf;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFFC0", Offset = "0x7EFFC0")]
			public Transform rightFoot;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFFF8", Offset = "0x7EFFF8")]
			public Transform rightToes;

			[Token(Token = "0x17000098")]
			public bool isFilled
			{
				[Token(Token = "0x6000642")]
				[Address(RVA = "0x10BA690", Offset = "0x10BA690", VA = "0x10BA690")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000099")]
			public bool isEmpty
			{
				[Token(Token = "0x6000643")]
				[Address(RVA = "0x10BA214", Offset = "0x10BA214", VA = "0x10BA214")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x10BAD20", Offset = "0x10BAD20", VA = "0x10BAD20")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x10B9DFC", Offset = "0x10B9DFC", VA = "0x10B9DFC")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x10BAD18", Offset = "0x10BAD18", VA = "0x10BAD18")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x7EC2E4", Offset = "0x7EC2E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC2E4", Offset = "0x7EC2E4")]
		public References references;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC360", Offset = "0x7EC360")]
		public IKSolverVR solver;

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x10B9CB0", Offset = "0x10B9CB0", VA = "0x10B9CB0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4338", Offset = "0x7F4338")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x10B9D1C", Offset = "0x10B9D1C", VA = "0x10B9D1C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4370", Offset = "0x7F4370")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x10B9D88", Offset = "0x10B9D88", VA = "0x10B9D88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F43A8", Offset = "0x7F43A8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x10B9DD4", Offset = "0x10B9DD4", VA = "0x10B9DD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F43E0", Offset = "0x7F43E0")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x10BA170", Offset = "0x10BA170", VA = "0x10BA170")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4418", Offset = "0x7F4418")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x10BA198", Offset = "0x10BA198", VA = "0x10BA198", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x10BA1A0", Offset = "0x10BA1A0", VA = "0x10BA1A0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x10BAB14", Offset = "0x10BAB14", VA = "0x10BAB14", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x10BAC90", Offset = "0x10BAC90", VA = "0x10BAC90")]
		public VRIK()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class IKJBoneParams : MonoBehaviour
	{
		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EC398", Offset = "0x7EC398")]
		public float weight;

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x147170C", Offset = "0x147170C", VA = "0x147170C")]
		public IKJBoneParams()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public static class RotationLimitUtilities
	{
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x10B7F78", Offset = "0x10B7F78", VA = "0x10B7F78")]
		public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, ref Quaternion lastRotation, ref float lastAngle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x10B8298", Offset = "0x10B8298", VA = "0x10B8298")]
		public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x10B837C", Offset = "0x10B837C", VA = "0x10B837C")]
		public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x10B83E4", Offset = "0x10B83E4", VA = "0x10B83E4")]
		public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x10B8618", Offset = "0x10B8618", VA = "0x10B8618")]
		public static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class FABRIKChain
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EC3B0", Offset = "0x7EC3B0")]
		public float pull;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EC3C8", Offset = "0x7EC3C8")]
		public float pin;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xEECA7C", Offset = "0xEECA7C", VA = "0xEECA7C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xEECB48", Offset = "0xEECB48", VA = "0xEECB48")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xEECB68", Offset = "0xEECB68", VA = "0xEECB68")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xEECF44", Offset = "0xEECF44", VA = "0xEECF44")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xEECC40", Offset = "0xEECC40", VA = "0xEECC40")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xEED040", Offset = "0xEED040", VA = "0xEED040")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xEED248", Offset = "0xEED248", VA = "0xEED248")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xEED7B8", Offset = "0xEED7B8", VA = "0xEED7B8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xEED97C", Offset = "0xEED97C", VA = "0xEED97C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xEEDA78", Offset = "0xEEDA78", VA = "0xEEDA78")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D2")]
		public class BendBone
		{
			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0030", Offset = "0x7F0030")]
			public Transform transform;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0068", Offset = "0x7F0068")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0068", Offset = "0x7F0068")]
			public float weight;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000646")]
			[Address(RVA = "0xEF0B10", Offset = "0xEF0B10", VA = "0xEF0B10")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0xEF0B90", Offset = "0xEF0B90", VA = "0xEF0B90")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0xEEE240", Offset = "0xEEE240", VA = "0xEEE240")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0xEEE63C", Offset = "0xEEE63C", VA = "0xEEE63C")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC3E0", Offset = "0x7EC3E0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EC418", Offset = "0x7EC418")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC418", Offset = "0x7EC418")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EC418", Offset = "0x7EC418")]
		public float positionWeight;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC490", Offset = "0x7EC490")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EC490", Offset = "0x7EC490")]
		public float bodyWeight;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC4E4", Offset = "0x7EC4E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EC4E4", Offset = "0x7EC4E4")]
		public float thighWeight;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC538", Offset = "0x7EC538")]
		public bool handsPullBody;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EC570", Offset = "0x7EC570")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC570", Offset = "0x7EC570")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EC570", Offset = "0x7EC570")]
		public float rotationWeight;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC5E8", Offset = "0x7EC5E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EC5E8", Offset = "0x7EC5E8")]
		public float bodyClampWeight;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC63C", Offset = "0x7EC63C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EC63C", Offset = "0x7EC63C")]
		public float headClampWeight;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC690", Offset = "0x7EC690")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EC690", Offset = "0x7EC690")]
		public float bendWeight;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC6E4", Offset = "0x7EC6E4")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EC71C", Offset = "0x7EC71C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC71C", Offset = "0x7EC71C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EC71C", Offset = "0x7EC71C")]
		public float CCDWeight;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC794", Offset = "0x7EC794")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EC794", Offset = "0x7EC794")]
		public float roll;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC7E8", Offset = "0x7EC7E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EC7E8", Offset = "0x7EC7E8")]
		public float damper;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC840", Offset = "0x7EC840")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EC878", Offset = "0x7EC878")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC878", Offset = "0x7EC878")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EC878", Offset = "0x7EC878")]
		public float postStretchWeight;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC8F0", Offset = "0x7EC8F0")]
		public float maxStretch;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC928", Offset = "0x7EC928")]
		public float stretchDamper;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC960", Offset = "0x7EC960")]
		public bool fixHead;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC998", Offset = "0x7EC998")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EC9D0", Offset = "0x7EC9D0")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECA08", Offset = "0x7ECA08")]
		public float chestDirectionWeight;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xEEDA80", Offset = "0xEEDA80", VA = "0xEEDA80")]
		private void Start()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xEEDDC0", Offset = "0xEEDDC0", VA = "0xEEDDC0")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xEEE278", Offset = "0xEEE278", VA = "0xEEE278")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xEEE664", Offset = "0xEEE664", VA = "0xEEE664")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xEEEFEC", Offset = "0xEEEFEC", VA = "0xEEEFEC")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xEEF340", Offset = "0xEEF340", VA = "0xEEF340")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xEEF6EC", Offset = "0xEEF6EC", VA = "0xEEF6EC")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xEF0170", Offset = "0xEF0170", VA = "0xEF0170")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xEEED10", Offset = "0xEEED10", VA = "0xEEED10")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xEF0388", Offset = "0xEF0388", VA = "0xEF0388")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xEF0024", Offset = "0xEF0024", VA = "0xEF0024")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xEEFE88", Offset = "0xEEFE88", VA = "0xEEFE88")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xEF0704", Offset = "0xEF0704", VA = "0xEF0704")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xEF0990", Offset = "0xEF0990", VA = "0xEF0990")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000D3")]
		public class ChildConstraint
		{
			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F00DC", Offset = "0x7F00DC")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F00EC", Offset = "0x7F00EC")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x1700009A")]
			public float nominalDistance
			{
				[Token(Token = "0x600064A")]
				[Address(RVA = "0xEF3B0C", Offset = "0xEF3B0C", VA = "0xEF3B0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5480", Offset = "0x7F5480")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600064B")]
				[Address(RVA = "0xEF3B14", Offset = "0xEF3B14", VA = "0xEF3B14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5490", Offset = "0x7F5490")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009B")]
			public bool isRigid
			{
				[Token(Token = "0x600064C")]
				[Address(RVA = "0xEF3B1C", Offset = "0xEF3B1C", VA = "0xEF3B1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F54A0", Offset = "0x7F54A0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600064D")]
				[Address(RVA = "0xEF3B24", Offset = "0xEF3B24", VA = "0xEF3B24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F54B0", Offset = "0x7F54B0")]
				private set
				{
				}
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0xEF3B30", Offset = "0xEF3B30", VA = "0xEF3B30")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0xEF17EC", Offset = "0xEF17EC", VA = "0xEF17EC")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0xEF1D4C", Offset = "0xEF1D4C", VA = "0xEF1D4C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0xEF37F4", Offset = "0xEF37F4", VA = "0xEF37F4")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D4")]
		public enum Smoothing
		{
			[Token(Token = "0x40005FD")]
			None,
			[Token(Token = "0x40005FE")]
			Exponential,
			[Token(Token = "0x40005FF")]
			Cubic
		}

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECA20", Offset = "0x7ECA20")]
		public float pin;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECA38", Offset = "0x7ECA38")]
		public float pull;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECA50", Offset = "0x7ECA50")]
		public float push;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECA68", Offset = "0x7ECA68")]
		public float pushParent;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECA80", Offset = "0x7ECA80")]
		public float reach;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40001EA")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xEF0C34", Offset = "0xEF0C34", VA = "0xEF0C34")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xEF0D00", Offset = "0xEF0D00", VA = "0xEF0D00")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xEF0E0C", Offset = "0xEF0E0C", VA = "0xEF0E0C")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xEF0F30", Offset = "0xEF0F30", VA = "0xEF0F30")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xEF1010", Offset = "0xEF1010", VA = "0xEF1010")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xEF1118", Offset = "0xEF1118", VA = "0xEF1118")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xEF1848", Offset = "0xEF1848", VA = "0xEF1848")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xEF12B0", Offset = "0xEF12B0", VA = "0xEF12B0")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xEF1F5C", Offset = "0xEF1F5C", VA = "0xEF1F5C")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xEF2310", Offset = "0xEF2310", VA = "0xEF2310")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xEF2700", Offset = "0xEF2700", VA = "0xEF2700")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xEF2C8C", Offset = "0xEF2C8C", VA = "0xEF2C8C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xEF3280", Offset = "0xEF3280", VA = "0xEF3280")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xEF3520", Offset = "0xEF3520", VA = "0xEF3520")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xEF3178", Offset = "0xEF3178", VA = "0xEF3178")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xEF2A74", Offset = "0xEF2A74", VA = "0xEF2A74")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xEF30F8", Offset = "0xEF30F8", VA = "0xEF30F8")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xEF3618", Offset = "0xEF3618", VA = "0xEF3618")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xEF3010", Offset = "0xEF3010", VA = "0xEF3010")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xEF3408", Offset = "0xEF3408", VA = "0xEF3408")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECA98", Offset = "0x7ECA98")]
		public float weight;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ECAB0", Offset = "0x7ECAB0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x1700003B")]
		public bool initiated
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x146E5E8", Offset = "0x146E5E8", VA = "0x146E5E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4450", Offset = "0x7F4450")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x146E5F0", Offset = "0x146E5F0", VA = "0x146E5F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4460", Offset = "0x7F4460")]
			private set
			{
			}
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x146E418", Offset = "0x146E418", VA = "0x146E418")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x146E5FC", Offset = "0x146E5FC", VA = "0x146E5FC")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x146E680", Offset = "0x146E680", VA = "0x146E680")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x146E72C", Offset = "0x146E72C", VA = "0x146E72C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x146E738", Offset = "0x146E738", VA = "0x146E738")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x146ECA4", Offset = "0x146ECA4", VA = "0x146ECA4")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x146EEDC", Offset = "0x146EEDC", VA = "0x146EEDC")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x146F380", Offset = "0x146F380", VA = "0x146F380")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x146EA6C", Offset = "0x146EA6C", VA = "0x146EA6C")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x146EB88", Offset = "0x146EB88", VA = "0x146EB88")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public class IKEffector
	{
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECAC0", Offset = "0x7ECAC0")]
		public float positionWeight;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECAD8", Offset = "0x7ECAD8")]
		public float rotationWeight;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ECAF0", Offset = "0x7ECAF0")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECB00", Offset = "0x7ECB00")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x1700003C")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x146FA44", Offset = "0x146FA44", VA = "0x146FA44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4470", Offset = "0x7F4470")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x146FA4C", Offset = "0x146FA4C", VA = "0x146FA4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4480", Offset = "0x7F4480")]
			private set
			{
			}
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x146F9D4", Offset = "0x146F9D4", VA = "0x146F9D4")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x146FA58", Offset = "0x146FA58", VA = "0x146FA58")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x146FB2C", Offset = "0x146FB2C", VA = "0x146FB2C")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x146FC68", Offset = "0x146FC68", VA = "0x146FC68")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x146FDC0", Offset = "0x146FDC0", VA = "0x146FDC0")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x14700B4", Offset = "0x14700B4", VA = "0x14700B4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x147034C", Offset = "0x147034C", VA = "0x147034C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x1470494", Offset = "0x1470494", VA = "0x1470494")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1470540", Offset = "0x1470540", VA = "0x1470540")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1470B9C", Offset = "0x1470B9C", VA = "0x1470B9C")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1470C0C", Offset = "0x1470C0C", VA = "0x1470C0C")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1470E1C", Offset = "0x1470E1C", VA = "0x1470E1C")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1471160", Offset = "0x1471160", VA = "0x1471160")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000D5")]
		public class BoneMap
		{
			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x1700009C")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x6000653")]
				[Address(RVA = "0x1471994", Offset = "0x1471994", VA = "0x1471994")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009D")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000656")]
				[Address(RVA = "0x1471B00", Offset = "0x1471B00", VA = "0x1471B00")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700009E")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x600066A")]
				[Address(RVA = "0x14720F4", Offset = "0x14720F4", VA = "0x14720F4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x1471968", Offset = "0x1471968", VA = "0x1471968")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x1471A60", Offset = "0x1471A60", VA = "0x1471A60")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x1471AB0", Offset = "0x1471AB0", VA = "0x1471AB0")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x1471B10", Offset = "0x1471B10", VA = "0x1471B10")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x1471C00", Offset = "0x1471C00", VA = "0x1471C00")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x1471C08", Offset = "0x1471C08", VA = "0x1471C08")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x1471DA8", Offset = "0x1471DA8", VA = "0x1471DA8")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x1471EB4", Offset = "0x1471EB4", VA = "0x1471EB4")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x1471F44", Offset = "0x1471F44", VA = "0x1471F44")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x1472318", Offset = "0x1472318", VA = "0x1472318")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x1472350", Offset = "0x1472350", VA = "0x1472350")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x1472388", Offset = "0x1472388", VA = "0x1472388")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x14723B0", Offset = "0x14723B0", VA = "0x14723B0")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x14724DC", Offset = "0x14724DC", VA = "0x14724DC")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x1472820", Offset = "0x1472820", VA = "0x1472820")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x1472854", Offset = "0x1472854", VA = "0x1472854")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x14729F0", Offset = "0x14729F0", VA = "0x14729F0")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x1472A60", Offset = "0x1472A60", VA = "0x1472A60")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x1472CAC", Offset = "0x1472CAC", VA = "0x1472CAC")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x1472EDC", Offset = "0x1472EDC", VA = "0x1472EDC")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x1472FF8", Offset = "0x1472FF8", VA = "0x1472FF8")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x1472624", Offset = "0x1472624", VA = "0x1472624")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x147318C", Offset = "0x147318C", VA = "0x147318C")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x147171C", Offset = "0x147171C", VA = "0x147171C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1471724", Offset = "0x1471724", VA = "0x1471724", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1471728", Offset = "0x1471728", VA = "0x1471728")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1471858", Offset = "0x1471858", VA = "0x1471858")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1471960", Offset = "0x1471960", VA = "0x1471960")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECB18", Offset = "0x7ECB18")]
		public float maintainRotationWeight;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x14731A4", Offset = "0x14731A4", VA = "0x14731A4", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1473244", Offset = "0x1473244", VA = "0x1473244")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x14732C8", Offset = "0x14732C8", VA = "0x14732C8")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1473360", Offset = "0x1473360", VA = "0x1473360")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1473378", Offset = "0x1473378", VA = "0x1473378")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1473394", Offset = "0x1473394", VA = "0x1473394", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1473434", Offset = "0x1473434", VA = "0x1473434")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x147344C", Offset = "0x147344C", VA = "0x147344C")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000D6")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000617")]
			Parent,
			[Token(Token = "0x4000618")]
			Bone1,
			[Token(Token = "0x4000619")]
			Bone2,
			[Token(Token = "0x400061A")]
			Bone3
		}

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECB30", Offset = "0x7ECB30")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECB48", Offset = "0x7ECB48")]
		public float weight;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1473470", Offset = "0x1473470", VA = "0x1473470", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x14734F4", Offset = "0x14734F4", VA = "0x14734F4")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x14735C8", Offset = "0x14735C8", VA = "0x14735C8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1473928", Offset = "0x1473928", VA = "0x1473928")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1473A28", Offset = "0x1473A28", VA = "0x1473A28")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1473B54", Offset = "0x1473B54", VA = "0x1473B54")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1473B60", Offset = "0x1473B60", VA = "0x1473B60")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1473C08", Offset = "0x1473C08", VA = "0x1473C08")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1473CC0", Offset = "0x1473CC0", VA = "0x1473CC0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1473F38", Offset = "0x1473F38", VA = "0x1473F38")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1473FF0", Offset = "0x1473FF0", VA = "0x1473FF0")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECB60", Offset = "0x7ECB60")]
		public int iterations;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECB78", Offset = "0x7ECB78")]
		public float twistWeight;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x147415C", Offset = "0x147415C", VA = "0x147415C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1474444", Offset = "0x1474444", VA = "0x1474444")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1474560", Offset = "0x1474560", VA = "0x1474560")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x14746B0", Offset = "0x14746B0", VA = "0x14746B0")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x14746C0", Offset = "0x14746C0", VA = "0x14746C0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1474730", Offset = "0x1474730", VA = "0x1474730")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x14747B8", Offset = "0x14747B8", VA = "0x14747B8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1474E48", Offset = "0x1474E48", VA = "0x1474E48")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1474E84", Offset = "0x1474E84", VA = "0x1474E84")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x147517C", Offset = "0x147517C", VA = "0x147517C")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1475530", Offset = "0x1475530", VA = "0x1475530")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1475624", Offset = "0x1475624", VA = "0x1475624")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x14756EC", Offset = "0x14756EC", VA = "0x14756EC")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000D7")]
		public class Point
		{
			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F00FC", Offset = "0x7F00FC")]
			public float weight;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x1477238", Offset = "0x1477238", VA = "0x1477238")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x1477288", Offset = "0x1477288", VA = "0x1477288")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x1477410", Offset = "0x1477410", VA = "0x1477410")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x1477448", Offset = "0x1477448", VA = "0x1477448")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x1477480", Offset = "0x1477480", VA = "0x1477480")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x14774D0", Offset = "0x14774D0", VA = "0x14774D0")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x1476D28", Offset = "0x1476D28", VA = "0x1476D28")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D8")]
		public class Bone : Point
		{
			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x1700009F")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000673")]
				[Address(RVA = "0x14762EC", Offset = "0x14762EC", VA = "0x14762EC")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000674")]
				[Address(RVA = "0x14763E0", Offset = "0x14763E0", VA = "0x14763E0")]
				set
				{
				}
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x1476468", Offset = "0x1476468", VA = "0x1476468")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x1476730", Offset = "0x1476730", VA = "0x1476730")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x1476A0C", Offset = "0x1476A0C", VA = "0x1476A0C")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x1476C7C", Offset = "0x1476C7C", VA = "0x1476C7C")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x1476CA4", Offset = "0x1476CA4", VA = "0x1476CA4")]
			public Bone()
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x1476DA8", Offset = "0x1476DA8", VA = "0x1476DA8")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x1476E40", Offset = "0x1476E40", VA = "0x1476E40")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D9")]
		public class Node : Point
		{
			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x14771D4", Offset = "0x14771D4", VA = "0x14771D4")]
			public Node()
			{
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x14771D8", Offset = "0x14771D8", VA = "0x14771D8")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x1477200", Offset = "0x1477200", VA = "0x1477200")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000DA")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000DB")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECBA0", Offset = "0x7ECBA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECBA0", Offset = "0x7ECBA0")]
		public float IKPositionWeight;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ECBF4", Offset = "0x7ECBF4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x1700003D")]
		public bool initiated
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x1475D30", Offset = "0x1475D30", VA = "0x1475D30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4490", Offset = "0x7F4490")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x1475D38", Offset = "0x1475D38", VA = "0x1475D38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F44A0", Offset = "0x7F44A0")]
			private set
			{
			}
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x14759EC", Offset = "0x14759EC", VA = "0x14759EC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B4")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x146E264", Offset = "0x146E264", VA = "0x146E264")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x146E184", Offset = "0x146E184", VA = "0x146E184")]
		public void Update()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1475C84", Offset = "0x1475C84", VA = "0x1475C84", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1475C90", Offset = "0x1475C90", VA = "0x1475C90")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1475C9C", Offset = "0x1475C9C", VA = "0x1475C9C")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1475CA4", Offset = "0x1475CA4", VA = "0x1475CA4")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1475D28", Offset = "0x1475D28", VA = "0x1475D28")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60002BF")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60002C0")]
		public abstract void FixTransforms();

		[Token(Token = "0x60002C1")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60002C2")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60002C3")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1475D44", Offset = "0x1475D44", VA = "0x1475D44")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1475D5C", Offset = "0x1475D5C", VA = "0x1475D5C")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1475E94", Offset = "0x1475E94", VA = "0x1475E94")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1475F4C", Offset = "0x1475F4C", VA = "0x1475F4C")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x14762D4", Offset = "0x14762D4", VA = "0x14762D4")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECC3C", Offset = "0x7ECC3C")]
		public float poleWeight;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECC54", Offset = "0x7ECC54")]
		public float clampWeight;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECC6C", Offset = "0x7ECC6C")]
		public int clampSmoothing;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700003E")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x1477670", Offset = "0x1477670", VA = "0x1477670")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003F")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x147773C", Offset = "0x147773C", VA = "0x147773C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000040")]
		protected override int minBones
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x14784D8", Offset = "0x14784D8", VA = "0x14784D8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000041")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x1478A84", Offset = "0x1478A84", VA = "0x1478A84", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1477570", Offset = "0x1477570", VA = "0x1477570")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1477808", Offset = "0x1477808", VA = "0x1477808", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1477A9C", Offset = "0x1477A9C", VA = "0x1477A9C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x147841C", Offset = "0x147841C", VA = "0x147841C")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1478044", Offset = "0x1478044", VA = "0x1478044")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x14784E0", Offset = "0x14784E0", VA = "0x14784E0")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1478B04", Offset = "0x1478B04", VA = "0x1478B04")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECC84", Offset = "0x7ECC84")]
		public float IKRotationWeight;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1478C14", Offset = "0x1478C14", VA = "0x1478C14", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1478F8C", Offset = "0x1478F8C", VA = "0x1478F8C")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1478FFC", Offset = "0x1478FFC", VA = "0x1478FFC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1479158", Offset = "0x1479158", VA = "0x1479158", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x14792F4", Offset = "0x14792F4", VA = "0x14792F4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1479340", Offset = "0x1479340", VA = "0x1479340", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x14793A0", Offset = "0x14793A0", VA = "0x14793A0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x147972C", Offset = "0x147972C", VA = "0x147972C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1479758", Offset = "0x1479758", VA = "0x1479758")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1479408", Offset = "0x1479408", VA = "0x1479408")]
		private void Read()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x14797C4", Offset = "0x14797C4", VA = "0x14797C4")]
		private void Write()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x147995C", Offset = "0x147995C", VA = "0x147995C")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1479AAC", Offset = "0x1479AAC", VA = "0x1479AAC")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1479B64", Offset = "0x1479B64", VA = "0x1479B64", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x147A17C", Offset = "0x147A17C", VA = "0x147A17C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x147A918", Offset = "0x147A918", VA = "0x147A918")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x147B074", Offset = "0x147B074", VA = "0x147B074")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000042")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x147C32C", Offset = "0x147C32C", VA = "0x147C32C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x147B078", Offset = "0x147B078", VA = "0x147B078")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x147B7E8", Offset = "0x147B7E8", VA = "0x147B7E8")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x147B920", Offset = "0x147B920", VA = "0x147B920", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x147B9BC", Offset = "0x147B9BC", VA = "0x147B9BC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x147BFB0", Offset = "0x147BFB0", VA = "0x147BFB0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x147C334", Offset = "0x147C334", VA = "0x147C334")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x147B14C", Offset = "0x147B14C", VA = "0x147B14C")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x147B8CC", Offset = "0x147B8CC", VA = "0x147B8CC")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x147C2C4", Offset = "0x147C2C4", VA = "0x147C2C4")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x147B60C", Offset = "0x147B60C", VA = "0x147B60C")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x147CBB0", Offset = "0x147CBB0", VA = "0x147CBB0")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x147CCB8", Offset = "0x147CCB8", VA = "0x147CCB8")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x147CDE4", Offset = "0x147CDE4", VA = "0x147CDE4")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x147CF04", Offset = "0x147CF04", VA = "0x147CF04")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x147BCE0", Offset = "0x147BCE0", VA = "0x147BCE0")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x147BE48", Offset = "0x147BE48", VA = "0x147BE48")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x147D0F8", Offset = "0x147D0F8", VA = "0x147D0F8")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x147C60C", Offset = "0x147C60C", VA = "0x147C60C")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x147B8BC", Offset = "0x147B8BC", VA = "0x147B8BC")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x147D8AC", Offset = "0x147D8AC", VA = "0x147D8AC")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x147D2D8", Offset = "0x147D2D8", VA = "0x147D2D8")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x147C44C", Offset = "0x147C44C", VA = "0x147C44C")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x147C534", Offset = "0x147C534", VA = "0x147C534")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x147D978", Offset = "0x147D978", VA = "0x147D978")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECC9C", Offset = "0x7ECC9C")]
		public float rootPin;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x147D9EC", Offset = "0x147D9EC", VA = "0x147D9EC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x147E2F4", Offset = "0x147E2F4", VA = "0x147E2F4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x147E394", Offset = "0x147E394", VA = "0x147E394", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x147E43C", Offset = "0x147E43C", VA = "0x147E43C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x147E544", Offset = "0x147E544", VA = "0x147E544")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x147E5F0", Offset = "0x147E5F0", VA = "0x147E5F0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x147EB88", Offset = "0x147EB88", VA = "0x147EB88", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x147ED80", Offset = "0x147ED80", VA = "0x147ED80", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x147EC3C", Offset = "0x147EC3C", VA = "0x147EC3C")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x147E84C", Offset = "0x147E84C", VA = "0x147E84C")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x147EE1C", Offset = "0x147EE1C", VA = "0x147EE1C")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECCB4", Offset = "0x7ECCB4")]
		public int iterations;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x147EE94", Offset = "0x147EE94", VA = "0x147EE94")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x147EF98", Offset = "0x147EF98", VA = "0x147EF98")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x147EFFC", Offset = "0x147EFFC", VA = "0x147EFFC")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x146F970", Offset = "0x146F970", VA = "0x146F970")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x146E9E0", Offset = "0x146E9E0", VA = "0x146E9E0")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x147F130", Offset = "0x147F130", VA = "0x147F130", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x147F2B0", Offset = "0x147F2B0", VA = "0x147F2B0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x147F424", Offset = "0x147F424", VA = "0x147F424", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x147F630", Offset = "0x147F630", VA = "0x147F630", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x147F6FC", Offset = "0x147F6FC", VA = "0x147F6FC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x147F7DC", Offset = "0x147F7DC", VA = "0x147F7DC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x147F950", Offset = "0x147F950", VA = "0x147F950", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x147FB08", Offset = "0x147FB08", VA = "0x147FB08", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x147FD40", Offset = "0x147FD40", VA = "0x147FD40", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x148002C", Offset = "0x148002C", VA = "0x148002C", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1480080", Offset = "0x1480080", VA = "0x1480080", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1480168", Offset = "0x1480168", VA = "0x1480168")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000273")]
		Body,
		[Token(Token = "0x4000274")]
		LeftShoulder,
		[Token(Token = "0x4000275")]
		RightShoulder,
		[Token(Token = "0x4000276")]
		LeftThigh,
		[Token(Token = "0x4000277")]
		RightThigh,
		[Token(Token = "0x4000278")]
		LeftHand,
		[Token(Token = "0x4000279")]
		RightHand,
		[Token(Token = "0x400027A")]
		LeftFoot,
		[Token(Token = "0x400027B")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x400027D")]
		LeftArm,
		[Token(Token = "0x400027E")]
		RightArm,
		[Token(Token = "0x400027F")]
		LeftLeg,
		[Token(Token = "0x4000280")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECCCC", Offset = "0x7ECCCC")]
		public float spineStiffness;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECCE4", Offset = "0x7ECCE4")]
		public float pullBodyVertical;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECCFC", Offset = "0x7ECCFC")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ECD14", Offset = "0x7ECD14")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000043")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x1480248", Offset = "0x1480248", VA = "0x1480248")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x1480250", Offset = "0x1480250", VA = "0x1480250")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x1480258", Offset = "0x1480258", VA = "0x1480258")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x1480260", Offset = "0x1480260", VA = "0x1480260")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x1480268", Offset = "0x1480268", VA = "0x1480268")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x1480270", Offset = "0x1480270", VA = "0x1480270")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x1480278", Offset = "0x1480278", VA = "0x1480278")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x1480280", Offset = "0x1480280", VA = "0x1480280")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x1480288", Offset = "0x1480288", VA = "0x1480288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x1480290", Offset = "0x1480290", VA = "0x1480290")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x14802D0", Offset = "0x14802D0", VA = "0x14802D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x1480310", Offset = "0x1480310", VA = "0x1480310")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x1480350", Offset = "0x1480350", VA = "0x1480350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x1480390", Offset = "0x1480390", VA = "0x1480390")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x14803CC", Offset = "0x14803CC", VA = "0x14803CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x148040C", Offset = "0x148040C", VA = "0x148040C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x148044C", Offset = "0x148044C", VA = "0x148044C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x148048C", Offset = "0x148048C", VA = "0x148048C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x1482428", Offset = "0x1482428", VA = "0x1482428")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F44B0", Offset = "0x7F44B0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x1482434", Offset = "0x1482434", VA = "0x1482434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F44C0", Offset = "0x7F44C0")]
			private set
			{
			}
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x14804C8", Offset = "0x14804C8", VA = "0x14804C8")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x14805DC", Offset = "0x14805DC", VA = "0x14805DC")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x148051C", Offset = "0x148051C", VA = "0x148051C")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x14806BC", Offset = "0x14806BC", VA = "0x14806BC")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x146CD30", Offset = "0x146CD30", VA = "0x146CD30")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1480794", Offset = "0x1480794", VA = "0x1480794")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1480854", Offset = "0x1480854", VA = "0x1480854")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1480910", Offset = "0x1480910", VA = "0x1480910")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x14809CC", Offset = "0x14809CC", VA = "0x14809CC")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x14809D4", Offset = "0x14809D4", VA = "0x14809D4")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1480A10", Offset = "0x1480A10", VA = "0x1480A10")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1480AE0", Offset = "0x1480AE0", VA = "0x1480AE0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1480C74", Offset = "0x1480C74", VA = "0x1480C74")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1481D30", Offset = "0x1481D30", VA = "0x1481D30")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x14821D4", Offset = "0x14821D4", VA = "0x14821D4")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x148223C", Offset = "0x148223C", VA = "0x148223C")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x148204C", Offset = "0x148204C", VA = "0x148204C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1482110", Offset = "0x1482110", VA = "0x1482110")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1482440", Offset = "0x1482440", VA = "0x1482440")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1482520", Offset = "0x1482520", VA = "0x1482520", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x148266C", Offset = "0x148266C", VA = "0x148266C")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x14827FC", Offset = "0x14827FC", VA = "0x14827FC")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x14829FC", Offset = "0x14829FC", VA = "0x14829FC")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1482C0C", Offset = "0x1482C0C", VA = "0x1482C0C", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1482F84", Offset = "0x1482F84", VA = "0x1482F84", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x148308C", Offset = "0x148308C", VA = "0x148308C")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000056")]
		protected virtual int minBones
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x1483900", Offset = "0x1483900", VA = "0x1483900", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000057")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x1483908", Offset = "0x1483908", VA = "0x1483908", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x1483910", Offset = "0x1483910", VA = "0x1483910", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000059")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x1483920", Offset = "0x1483920", VA = "0x1483920", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700005A")]
		protected float positionOffset
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x147A854", Offset = "0x147A854", VA = "0x147A854")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1483098", Offset = "0x1483098", VA = "0x1483098")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1483228", Offset = "0x1483228", VA = "0x1483228")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1483370", Offset = "0x1483370", VA = "0x1483370", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x14833E0", Offset = "0x14833E0", VA = "0x14833E0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1483464", Offset = "0x1483464", VA = "0x1483464", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x14837F4", Offset = "0x14837F4", VA = "0x14837F4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x14837FC", Offset = "0x14837FC", VA = "0x14837FC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1483918", Offset = "0x1483918", VA = "0x1483918", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x148391C", Offset = "0x148391C", VA = "0x148391C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1479BF0", Offset = "0x1479BF0", VA = "0x1479BF0")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x147A4B0", Offset = "0x147A4B0", VA = "0x147A4B0")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1483A60", Offset = "0x1483A60", VA = "0x1483A60")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1478B98", Offset = "0x1478B98", VA = "0x1478B98")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECD24", Offset = "0x7ECD24")]
		public float IKRotationWeight;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1483D20", Offset = "0x1483D20", VA = "0x1483D20", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1484098", Offset = "0x1484098", VA = "0x1484098")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1484108", Offset = "0x1484108", VA = "0x1484108", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1484264", Offset = "0x1484264", VA = "0x1484264", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1484400", Offset = "0x1484400", VA = "0x1484400", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x148444C", Offset = "0x148444C", VA = "0x148444C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x14844AC", Offset = "0x14844AC", VA = "0x14844AC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1484838", Offset = "0x1484838", VA = "0x1484838", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1484864", Offset = "0x1484864", VA = "0x1484864")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1484514", Offset = "0x1484514", VA = "0x1484514")]
		private void Read()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1484970", Offset = "0x1484970", VA = "0x1484970")]
		private void Write()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1484B08", Offset = "0x1484B08", VA = "0x1484B08")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000DC")]
		public enum BendModifier
		{
			[Token(Token = "0x400062B")]
			Animation,
			[Token(Token = "0x400062C")]
			Target,
			[Token(Token = "0x400062D")]
			Parent,
			[Token(Token = "0x400062E")]
			Arm,
			[Token(Token = "0x400062F")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000DD")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x8A1E48", Offset = "0x8A1E48", VA = "0x8A1E48")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECD3C", Offset = "0x7ECD3C")]
		public float maintainRotationWeight;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECD54", Offset = "0x7ECD54")]
		public float bendModifierWeight;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x1700005B")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x13B6F94", Offset = "0x13B6F94", VA = "0x13B6F94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x13B58AC", Offset = "0x13B58AC", VA = "0x13B58AC")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x13B5900", Offset = "0x13B5900", VA = "0x13B5900")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x13B5A14", Offset = "0x13B5A14", VA = "0x13B5A14", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x13B6094", Offset = "0x13B6094", VA = "0x13B6094", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x13B6C3C", Offset = "0x13B6C3C", VA = "0x13B6C3C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x13B6D88", Offset = "0x13B6D88", VA = "0x13B6D88")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x13B6F0C", Offset = "0x13B6F0C", VA = "0x13B6F0C")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x13B5D98", Offset = "0x13B5D98", VA = "0x13B5D98")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x13B61C4", Offset = "0x13B61C4", VA = "0x13B61C4")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000DE")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x170000A0")]
			public Vector3 forward
			{
				[Token(Token = "0x600068C")]
				[Address(RVA = "0x13B8EB4", Offset = "0x13B8EB4", VA = "0x13B8EB4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x13B9618", Offset = "0x13B9618", VA = "0x13B9618")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x13B8228", Offset = "0x13B8228", VA = "0x13B8228")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x13B8570", Offset = "0x13B8570", VA = "0x13B8570")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x13B92C0", Offset = "0x13B92C0", VA = "0x13B92C0")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECD6C", Offset = "0x7ECD6C")]
		public float bodyWeight;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECD84", Offset = "0x7ECD84")]
		public float headWeight;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECD9C", Offset = "0x7ECD9C")]
		public float eyesWeight;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECDB4", Offset = "0x7ECDB4")]
		public float clampWeight;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECDCC", Offset = "0x7ECDCC")]
		public float clampWeightHead;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECDE4", Offset = "0x7ECDE4")]
		public float clampWeightEyes;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECDFC", Offset = "0x7ECDFC")]
		public int clampSmoothing;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x1700005C")]
		private bool spineIsValid
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x13B7954", Offset = "0x13B7954", VA = "0x13B7954")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x13B7B3C", Offset = "0x13B7B3C", VA = "0x13B7B3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		private bool headIsValid
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x13B7A40", Offset = "0x13B7A40", VA = "0x13B7A40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		private bool headIsEmpty
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x13B7B64", Offset = "0x13B7B64", VA = "0x13B7B64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000060")]
		private bool eyesIsValid
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x13B7A50", Offset = "0x13B7A50", VA = "0x13B7A50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x13B7BE4", Offset = "0x13B7BE4", VA = "0x13B7BE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x13B7010", Offset = "0x13B7010", VA = "0x13B7010")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x13B7094", Offset = "0x13B7094", VA = "0x13B7094")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x13B7140", Offset = "0x13B7140", VA = "0x13B7140")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x13B7208", Offset = "0x13B7208", VA = "0x13B7208")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x13B72F4", Offset = "0x13B72F4", VA = "0x13B72F4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x13B7400", Offset = "0x13B7400", VA = "0x13B7400")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x13B7548", Offset = "0x13B7548", VA = "0x13B7548", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x13B7678", Offset = "0x13B7678", VA = "0x13B7678", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x13B77BC", Offset = "0x13B77BC", VA = "0x13B77BC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x13B7C0C", Offset = "0x13B7C0C", VA = "0x13B7C0C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x13B7E44", Offset = "0x13B7E44", VA = "0x13B7E44", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x13B7FEC", Offset = "0x13B7FEC", VA = "0x13B7FEC")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x13B8254", Offset = "0x13B8254", VA = "0x13B8254", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x13B86B4", Offset = "0x13B86B4", VA = "0x13B86B4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x13B87B8", Offset = "0x13B87B8", VA = "0x13B87B8")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x13B89E8", Offset = "0x13B89E8", VA = "0x13B89E8")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x13B8C48", Offset = "0x13B8C48", VA = "0x13B8C48")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x13B8F80", Offset = "0x13B8F80", VA = "0x13B8F80")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x13B809C", Offset = "0x13B809C", VA = "0x13B809C")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x13B9430", Offset = "0x13B9430", VA = "0x13B9430")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000DF")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x13BAC18", Offset = "0x13BAC18", VA = "0x13BAC18")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x13BB7CC", Offset = "0x13BB7CC", VA = "0x13BB7CC")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0x13B5948", Offset = "0x13B5948", VA = "0x13B5948")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x13BB894", Offset = "0x13BB894", VA = "0x13BB894")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ECE14", Offset = "0x7ECE14")]
		public float IKRotationWeight;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x13B9620", Offset = "0x13B9620", VA = "0x13B9620")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x13B9814", Offset = "0x13B9814", VA = "0x13B9814")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x13B99CC", Offset = "0x13B99CC", VA = "0x13B99CC")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x13B99D8", Offset = "0x13B99D8", VA = "0x13B99D8")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x13B9A5C", Offset = "0x13B9A5C", VA = "0x13B9A5C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x13B9A68", Offset = "0x13B9A68", VA = "0x13B9A68")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x13B9A70", Offset = "0x13B9A70", VA = "0x13B9A70", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x13B9B74", Offset = "0x13B9B74", VA = "0x13B9B74", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x13B9C98", Offset = "0x13B9C98", VA = "0x13B9C98", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x13B9CE4", Offset = "0x13B9CE4", VA = "0x13B9CE4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x13B9D44", Offset = "0x13B9D44", VA = "0x13B9D44", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x13BA128", Offset = "0x13BA128", VA = "0x13BA128")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x13BA184", Offset = "0x13BA184", VA = "0x13BA184")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x13BA730", Offset = "0x13BA730", VA = "0x13BA730")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x13BA948", Offset = "0x13BA948", VA = "0x13BA948", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x13BAB0C", Offset = "0x13BAB0C", VA = "0x13BAB0C")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x13BAA84", Offset = "0x13BAA84", VA = "0x13BAA84")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x13BADB8", Offset = "0x13BADB8", VA = "0x13BADB8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x13BB888", Offset = "0x13BB888", VA = "0x13BB888", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x13BB88C", Offset = "0x13BB88C", VA = "0x13BB88C", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x13BB890", Offset = "0x13BB890", VA = "0x13BB890", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x13BB4CC", Offset = "0x13BB4CC", VA = "0x13BB4CC")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x13B6DFC", Offset = "0x13B6DFC", VA = "0x13B6DFC")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000E0")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000120")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000809")]
				YawPitch,
				[Token(Token = "0x400080A")]
				FromTo
			}

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0114", Offset = "0x7F0114")]
			public Transform target;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F014C", Offset = "0x7F014C")]
			public Transform bendGoal;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0184", Offset = "0x7F0184")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0184", Offset = "0x7F0184")]
			public float positionWeight;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F01D8", Offset = "0x7F01D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F01D8", Offset = "0x7F01D8")]
			public float rotationWeight;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F022C", Offset = "0x7F022C")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0264", Offset = "0x7F0264")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0264", Offset = "0x7F0264")]
			public float shoulderRotationWeight;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F02B8", Offset = "0x7F02B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F02B8", Offset = "0x7F02B8")]
			public float shoulderTwistWeight;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F030C", Offset = "0x7F030C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F030C", Offset = "0x7F030C")]
			public float bendGoalWeight;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0360", Offset = "0x7F0360")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0360", Offset = "0x7F0360")]
			public float swivelOffset;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F03BC", Offset = "0x7F03BC")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F03F4", Offset = "0x7F03F4")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F042C", Offset = "0x7F042C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F042C", Offset = "0x7F042C")]
			public float armLengthMlp;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0484", Offset = "0x7F0484")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F04FC", Offset = "0x7F04FC")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F050C", Offset = "0x7F050C")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x400064F")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000650")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000A1")]
			public Vector3 position
			{
				[Token(Token = "0x6000691")]
				[Address(RVA = "0x13C42F4", Offset = "0x13C42F4", VA = "0x13C42F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F54C0", Offset = "0x7F54C0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000692")]
				[Address(RVA = "0x13C4300", Offset = "0x13C4300", VA = "0x13C4300")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F54D0", Offset = "0x7F54D0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000693")]
				[Address(RVA = "0x13C430C", Offset = "0x13C430C", VA = "0x13C430C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F54E0", Offset = "0x7F54E0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000694")]
				[Address(RVA = "0x13C4318", Offset = "0x13C4318", VA = "0x13C4318")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F54F0", Offset = "0x7F54F0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000695")]
				[Address(RVA = "0x13C4324", Offset = "0x13C4324", VA = "0x13C4324")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000696")]
				[Address(RVA = "0x13C4360", Offset = "0x13C4360", VA = "0x13C4360")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A5")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000697")]
				[Address(RVA = "0x13C43A8", Offset = "0x13C43A8", VA = "0x13C43A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A6")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000698")]
				[Address(RVA = "0x13C43FC", Offset = "0x13C43FC", VA = "0x13C43FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x13C4450", Offset = "0x13C4450", VA = "0x13C4450", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x13C4BC4", Offset = "0x13C4BC4", VA = "0x13C4BC4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x13C4DC0", Offset = "0x13C4DC0", VA = "0x13C4DC0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x13C4E6C", Offset = "0x13C4E6C", VA = "0x13C4E6C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x13C22D4", Offset = "0x13C22D4", VA = "0x13C22D4")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x13C62BC", Offset = "0x13C62BC", VA = "0x13C62BC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x13C632C", Offset = "0x13C632C", VA = "0x13C632C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x13C5284", Offset = "0x13C5284", VA = "0x13C5284")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x13C558C", Offset = "0x13C558C", VA = "0x13C558C")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x13C6584", Offset = "0x13C6584", VA = "0x13C6584")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x13C3FF0", Offset = "0x13C3FF0", VA = "0x13C3FF0")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E1")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F051C", Offset = "0x7F051C")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F052C", Offset = "0x7F052C")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x170000A7")]
			public float sqrMag
			{
				[Token(Token = "0x60006A9")]
				[Address(RVA = "0x13C6748", Offset = "0x13C6748", VA = "0x13C6748")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5500", Offset = "0x7F5500")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006AA")]
				[Address(RVA = "0x13C6750", Offset = "0x13C6750", VA = "0x13C6750")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5510", Offset = "0x7F5510")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			public float mag
			{
				[Token(Token = "0x60006AB")]
				[Address(RVA = "0x13C6758", Offset = "0x13C6758", VA = "0x13C6758")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5520", Offset = "0x7F5520")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006AC")]
				[Address(RVA = "0x13C6760", Offset = "0x13C6760", VA = "0x13C6760")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5530", Offset = "0x7F5530")]
				private set
				{
				}
			}

			[Token(Token = "0x60006A4")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x60006A5")]
			public abstract void PreSolve();

			[Token(Token = "0x60006A6")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x60006A7")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x60006A8")]
			public abstract void ResetOffsets();

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x13BFB8C", Offset = "0x13BFB8C", VA = "0x13BFB8C")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x13C6A64", Offset = "0x13C6A64", VA = "0x13C6A64")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x13C6BD8", Offset = "0x13C6BD8", VA = "0x13C6BD8")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x13C6E74", Offset = "0x13C6E74", VA = "0x13C6E74")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x13C1A9C", Offset = "0x13C1A9C", VA = "0x13C1A9C")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x13C6110", Offset = "0x13C6110", VA = "0x13C6110")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x13C6EC8", Offset = "0x13C6EC8", VA = "0x13C6EC8")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x13C7010", Offset = "0x13C7010", VA = "0x13C7010")]
			public void Visualize()
			{
			}

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x13C66B0", Offset = "0x13C66B0", VA = "0x13C66B0")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E2")]
		public class Footstep
		{
			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F054C", Offset = "0x7F054C")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000A9")]
			public bool isStepping
			{
				[Token(Token = "0x60006B6")]
				[Address(RVA = "0x13C7038", Offset = "0x13C7038", VA = "0x13C7038")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000AA")]
			public float stepProgress
			{
				[Token(Token = "0x60006B7")]
				[Address(RVA = "0x13C704C", Offset = "0x13C704C", VA = "0x13C704C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5540", Offset = "0x7F5540")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006B8")]
				[Address(RVA = "0x13C7054", Offset = "0x13C7054", VA = "0x13C7054")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5550", Offset = "0x7F5550")]
				private set
				{
				}
			}

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x13C705C", Offset = "0x13C705C", VA = "0x13C705C")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x13C71F0", Offset = "0x13C71F0", VA = "0x13C71F0")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x13C7238", Offset = "0x13C7238", VA = "0x13C7238")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x13C7344", Offset = "0x13C7344", VA = "0x13C7344")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x13C751C", Offset = "0x13C751C", VA = "0x13C751C")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x13C7708", Offset = "0x13C7708", VA = "0x13C7708")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E3")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F055C", Offset = "0x7F055C")]
			public Transform target;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0594", Offset = "0x7F0594")]
			public Transform bendGoal;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F05CC", Offset = "0x7F05CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F05CC", Offset = "0x7F05CC")]
			public float positionWeight;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0620", Offset = "0x7F0620")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0620", Offset = "0x7F0620")]
			public float rotationWeight;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0674", Offset = "0x7F0674")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0674", Offset = "0x7F0674")]
			public float bendGoalWeight;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F06C8", Offset = "0x7F06C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F06C8", Offset = "0x7F06C8")]
			public float swivelOffset;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0724", Offset = "0x7F0724")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0724", Offset = "0x7F0724")]
			public float bendToTargetWeight;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0778", Offset = "0x7F0778")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0778", Offset = "0x7F0778")]
			public float legLengthMlp;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F07D0", Offset = "0x7F07D0")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F0868", Offset = "0x7F0868")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F0878", Offset = "0x7F0878")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F0888", Offset = "0x7F0888")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F0898", Offset = "0x7F0898")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 footPosition;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Quaternion footRotation;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 bendNormal;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x170000AB")]
			public Vector3 position
			{
				[Token(Token = "0x60006BF")]
				[Address(RVA = "0x13C7928", Offset = "0x13C7928", VA = "0x13C7928")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5560", Offset = "0x7F5560")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006C0")]
				[Address(RVA = "0x13C7934", Offset = "0x13C7934", VA = "0x13C7934")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5570", Offset = "0x7F5570")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AC")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006C1")]
				[Address(RVA = "0x13C7940", Offset = "0x13C7940", VA = "0x13C7940")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5580", Offset = "0x7F5580")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006C2")]
				[Address(RVA = "0x13C794C", Offset = "0x13C794C", VA = "0x13C794C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5590", Offset = "0x7F5590")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AD")]
			public bool hasToes
			{
				[Token(Token = "0x60006C3")]
				[Address(RVA = "0x13C7958", Offset = "0x13C7958", VA = "0x13C7958")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F55A0", Offset = "0x7F55A0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006C4")]
				[Address(RVA = "0x13C7960", Offset = "0x13C7960", VA = "0x13C7960")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F55B0", Offset = "0x7F55B0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AE")]
			public VirtualBone thigh
			{
				[Token(Token = "0x60006C5")]
				[Address(RVA = "0x13C796C", Offset = "0x13C796C", VA = "0x13C796C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			private VirtualBone calf
			{
				[Token(Token = "0x60006C6")]
				[Address(RVA = "0x13C79A8", Offset = "0x13C79A8", VA = "0x13C79A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			private VirtualBone foot
			{
				[Token(Token = "0x60006C7")]
				[Address(RVA = "0x13C79E8", Offset = "0x13C79E8", VA = "0x13C79E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B1")]
			private VirtualBone toes
			{
				[Token(Token = "0x60006C8")]
				[Address(RVA = "0x13C7A28", Offset = "0x13C7A28", VA = "0x13C7A28")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B2")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x60006C9")]
				[Address(RVA = "0x13C18E8", Offset = "0x13C18E8", VA = "0x13C18E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B3")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60006CA")]
				[Address(RVA = "0x13C7A68", Offset = "0x13C7A68", VA = "0x13C7A68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F55C0", Offset = "0x7F55C0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006CB")]
				[Address(RVA = "0x13C7A74", Offset = "0x13C7A74", VA = "0x13C7A74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F55D0", Offset = "0x7F55D0")]
				private set
				{
				}
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x13C7A80", Offset = "0x13C7A80", VA = "0x13C7A80", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x13C80BC", Offset = "0x13C80BC", VA = "0x13C80BC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x13C88F0", Offset = "0x13C88F0", VA = "0x13C88F0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x13C87EC", Offset = "0x13C87EC", VA = "0x13C87EC")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x13C85B4", Offset = "0x13C85B4", VA = "0x13C85B4")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x13C1C90", Offset = "0x13C1C90", VA = "0x13C1C90")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x13C8EB0", Offset = "0x13C8EB0", VA = "0x13C8EB0")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x13C93B0", Offset = "0x13C93B0", VA = "0x13C93B0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x13C9604", Offset = "0x13C9604", VA = "0x13C9604", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x13C4118", Offset = "0x13C4118", VA = "0x13C4118")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public class Locomotion
		{
			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F08A8", Offset = "0x7F08A8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F08A8", Offset = "0x7F08A8")]
			public float weight;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F08FC", Offset = "0x7F08FC")]
			public float footDistance;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0934", Offset = "0x7F0934")]
			public float stepThreshold;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F096C", Offset = "0x7F096C")]
			public float angleThreshold;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F09A4", Offset = "0x7F09A4")]
			public float comAngleMlp;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F09DC", Offset = "0x7F09DC")]
			public float maxVelocity;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0A14", Offset = "0x7F0A14")]
			public float velocityFactor;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0A4C", Offset = "0x7F0A4C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0A4C", Offset = "0x7F0A4C")]
			public float maxLegStretch;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0AA4", Offset = "0x7F0AA4")]
			public float rootSpeed;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0ADC", Offset = "0x7F0ADC")]
			public float stepSpeed;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0B14", Offset = "0x7F0B14")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0B4C", Offset = "0x7F0B4C")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0B84", Offset = "0x7F0B84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0B84", Offset = "0x7F0B84")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0BDC", Offset = "0x7F0BDC")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0C14", Offset = "0x7F0C14")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0C4C", Offset = "0x7F0C4C")]
			public Vector3 offset;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0CC4", Offset = "0x7F0CC4")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0CFC", Offset = "0x7F0CFC")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F0D34", Offset = "0x7F0D34")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000B4")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x13C96B4", Offset = "0x13C96B4", VA = "0x13C96B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F55E0", Offset = "0x7F55E0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006D7")]
				[Address(RVA = "0x13C96C0", Offset = "0x13C96C0", VA = "0x13C96C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F55F0", Offset = "0x7F55F0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B5")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60006DD")]
				[Address(RVA = "0x13C9B10", Offset = "0x13C9B10", VA = "0x13C9B10")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B6")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60006DE")]
				[Address(RVA = "0x13C9B58", Offset = "0x13C9B58", VA = "0x13C9B58")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B7")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60006DF")]
				[Address(RVA = "0x13C9BA4", Offset = "0x13C9BA4", VA = "0x13C9BA4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000B8")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60006E0")]
				[Address(RVA = "0x13C9BEC", Offset = "0x13C9BEC", VA = "0x13C9BEC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x13BFC74", Offset = "0x13BFC74", VA = "0x13BFC74")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x13BD9DC", Offset = "0x13BD9DC", VA = "0x13BD9DC")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x13BCDD0", Offset = "0x13BCDD0", VA = "0x13BCDD0")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x13BCC18", Offset = "0x13BCC18", VA = "0x13BCC18")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x13C04D4", Offset = "0x13C04D4", VA = "0x13C04D4")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x13C9714", Offset = "0x13C9714", VA = "0x13C9714")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x13C98B8", Offset = "0x13C98B8", VA = "0x13C98B8")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x13C9944", Offset = "0x13C9944", VA = "0x13C9944")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x13C420C", Offset = "0x13C420C", VA = "0x13C420C")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E5")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0D44", Offset = "0x7F0D44")]
			public Transform headTarget;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0D7C", Offset = "0x7F0D7C")]
			public Transform pelvisTarget;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0DB4", Offset = "0x7F0DB4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0DB4", Offset = "0x7F0DB4")]
			public float positionWeight;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0E08", Offset = "0x7F0E08")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0E08", Offset = "0x7F0E08")]
			public float rotationWeight;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0E5C", Offset = "0x7F0E5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0E5C", Offset = "0x7F0E5C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0EB0", Offset = "0x7F0EB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0EB0", Offset = "0x7F0EB0")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0F04", Offset = "0x7F0F04")]
			public Transform chestGoal;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0F3C", Offset = "0x7F0F3C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0F3C", Offset = "0x7F0F3C")]
			public float chestGoalWeight;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0F90", Offset = "0x7F0F90")]
			public float minHeadHeight;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0FC8", Offset = "0x7F0FC8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0FC8", Offset = "0x7F0FC8")]
			public float bodyPosStiffness;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F101C", Offset = "0x7F101C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F101C", Offset = "0x7F101C")]
			public float bodyRotStiffness;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1070", Offset = "0x7F1070")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7F1070", Offset = "0x7F1070")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1070", Offset = "0x7F1070")]
			public float neckStiffness;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F10E8", Offset = "0x7F10E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F10E8", Offset = "0x7F10E8")]
			public float rotateChestByHands;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F113C", Offset = "0x7F113C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F113C", Offset = "0x7F113C")]
			public float chestClampWeight;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1190", Offset = "0x7F1190")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1190", Offset = "0x7F1190")]
			public float headClampWeight;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F11E4", Offset = "0x7F11E4")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F121C", Offset = "0x7F121C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F121C", Offset = "0x7F121C")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1270", Offset = "0x7F1270")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1270", Offset = "0x7F1270")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F13A8", Offset = "0x7F13A8")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private Quaternion headRotation;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private int pelvisIndex;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int spineIndex;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int chestIndex;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int neckIndex;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int headIndex;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private float length;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private bool hasChest;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20D")]
			private bool hasNeck;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20E")]
			private bool hasLegs;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private float headHeight;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float sizeMlp;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private Vector3 chestForward;

			[Token(Token = "0x170000B9")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x60006E5")]
				[Address(RVA = "0x13BDC5C", Offset = "0x13BDC5C", VA = "0x13BDC5C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x60006E6")]
				[Address(RVA = "0x13C9C38", Offset = "0x13C9C38", VA = "0x13C9C38")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BB")]
			public VirtualBone chest
			{
				[Token(Token = "0x60006E7")]
				[Address(RVA = "0x13C2274", Offset = "0x13C2274", VA = "0x13C2274")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			private VirtualBone neck
			{
				[Token(Token = "0x60006E8")]
				[Address(RVA = "0x13C9C80", Offset = "0x13C9C80", VA = "0x13C9C80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BD")]
			public VirtualBone head
			{
				[Token(Token = "0x60006E9")]
				[Address(RVA = "0x13C96CC", Offset = "0x13C96CC", VA = "0x13C96CC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BE")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x60006EA")]
				[Address(RVA = "0x13C9CC8", Offset = "0x13C9CC8", VA = "0x13C9CC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5600", Offset = "0x7F5600")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006EB")]
				[Address(RVA = "0x13C9CDC", Offset = "0x13C9CDC", VA = "0x13C9CDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5610", Offset = "0x7F5610")]
				private set
				{
				}
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x13C9CF0", Offset = "0x13C9CF0", VA = "0x13C9CF0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x13CA7E4", Offset = "0x13CA7E4", VA = "0x13CA7E4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x13CA9F4", Offset = "0x13CA9F4", VA = "0x13CA9F4", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x13CAFAC", Offset = "0x13CAFAC", VA = "0x13CAFAC")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x13BFF70", Offset = "0x13BFF70", VA = "0x13BFF70")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x13CB974", Offset = "0x13CB974", VA = "0x13CB974")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x13CC060", Offset = "0x13CC060", VA = "0x13CC060")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x13CC80C", Offset = "0x13CC80C", VA = "0x13CC80C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x13CCA28", Offset = "0x13CCA28", VA = "0x13CCA28", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x13CB1E0", Offset = "0x13CB1E0", VA = "0x13CB1E0")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x13C1930", Offset = "0x13C1930", VA = "0x13C1930")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x13CB56C", Offset = "0x13CB56C", VA = "0x13CB56C")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x13CCB20", Offset = "0x13CCB20", VA = "0x13CCB20")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x13CBDFC", Offset = "0x13CBDFC", VA = "0x13CBDFC")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x13CBB2C", Offset = "0x13CBB2C", VA = "0x13CBB2C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x13C3E24", Offset = "0x13C3E24", VA = "0x13C3E24")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E6")]
		public enum PositionOffset
		{
			[Token(Token = "0x40006D3")]
			Pelvis,
			[Token(Token = "0x40006D4")]
			Chest,
			[Token(Token = "0x40006D5")]
			Head,
			[Token(Token = "0x40006D6")]
			LeftHand,
			[Token(Token = "0x40006D7")]
			RightHand,
			[Token(Token = "0x40006D8")]
			LeftFoot,
			[Token(Token = "0x40006D9")]
			RightFoot,
			[Token(Token = "0x40006DA")]
			LeftHeel,
			[Token(Token = "0x40006DB")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000E7")]
		public enum RotationOffset
		{
			[Token(Token = "0x40006DD")]
			Pelvis,
			[Token(Token = "0x40006DE")]
			Chest,
			[Token(Token = "0x40006DF")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000E8")]
		public class VirtualBone
		{
			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x13BFAF0", Offset = "0x13BFAF0", VA = "0x13BFAF0")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x13BFB6C", Offset = "0x13BFB6C", VA = "0x13BFB6C")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x13CCE48", Offset = "0x13CCE48", VA = "0x13CCE48")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x13C6768", Offset = "0x13C6768", VA = "0x13C6768")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x13C6C8C", Offset = "0x13C6C8C", VA = "0x13C6C8C")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x13CD0D0", Offset = "0x13CD0D0", VA = "0x13CD0D0")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x13C535C", Offset = "0x13C535C", VA = "0x13C535C")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x13CD2F0", Offset = "0x13CD2F0", VA = "0x13CD2F0")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x13C5B50", Offset = "0x13C5B50", VA = "0x13C5B50")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x13CD3B4", Offset = "0x13CD3B4", VA = "0x13CD3B4")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x13CC3D8", Offset = "0x13CC3D8", VA = "0x13CC3D8")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x13CD5CC", Offset = "0x13CD5CC", VA = "0x13CD5CC")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x13CD6D4", Offset = "0x13CD6D4", VA = "0x13CD6D4")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECE2C", Offset = "0x7ECE2C")]
		public bool plantFeet;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ECE64", Offset = "0x7ECE64")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECE74", Offset = "0x7ECE74")]
		public Spine spine;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECEAC", Offset = "0x7ECEAC")]
		public Arm leftArm;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECEE4", Offset = "0x7ECEE4")]
		public Arm rightArm;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECF1C", Offset = "0x7ECF1C")]
		public Leg leftLeg;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECF54", Offset = "0x7ECF54")]
		public Leg rightLeg;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECF8C", Offset = "0x7ECF8C")]
		public Locomotion locomotion;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000062")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x13C3C6C", Offset = "0x13C3C6C", VA = "0x13C3C6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F44D0", Offset = "0x7F44D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x13C3C74", Offset = "0x13C3C74", VA = "0x13C3C74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F44E0", Offset = "0x7F44E0")]
			private set
			{
			}
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x13BB89C", Offset = "0x13BB89C", VA = "0x13BB89C")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x13BBCE4", Offset = "0x13BBCE4", VA = "0x13BBCE4")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x13BBB88", Offset = "0x13BBB88", VA = "0x13BBB88")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x13BC6E0", Offset = "0x13BC6E0", VA = "0x13BC6E0")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x13BC850", Offset = "0x13BC850", VA = "0x13BC850")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x13BC8F4", Offset = "0x13BC8F4", VA = "0x13BC8F4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x13BCA8C", Offset = "0x13BCA8C", VA = "0x13BCA8C")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x13BD1B0", Offset = "0x13BD1B0", VA = "0x13BD1B0")]
		public void Reset()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x13BDCA4", Offset = "0x13BDCA4", VA = "0x13BDCA4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x13BDE1C", Offset = "0x13BDE1C", VA = "0x13BDE1C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x13BDFC4", Offset = "0x13BDFC4", VA = "0x13BDFC4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x13BE038", Offset = "0x13BE038", VA = "0x13BE038", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x13BE0AC", Offset = "0x13BE0AC", VA = "0x13BE0AC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x13BE2C4", Offset = "0x13BE2C4", VA = "0x13BE2C4")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x13BBF88", Offset = "0x13BBF88", VA = "0x13BBF88")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x13BC164", Offset = "0x13BC164", VA = "0x13BC164")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x13BC5B8", Offset = "0x13BC5B8", VA = "0x13BC5B8")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x13BD324", Offset = "0x13BD324", VA = "0x13BD324")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x13BE5AC", Offset = "0x13BE5AC", VA = "0x13BE5AC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x13BE5F4", Offset = "0x13BE5F4", VA = "0x13BE5F4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x13BF7E0", Offset = "0x13BF7E0", VA = "0x13BF7E0")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x13BD48C", Offset = "0x13BD48C", VA = "0x13BD48C")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x13BE670", Offset = "0x13BE670", VA = "0x13BE670")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x13BFA54", Offset = "0x13BFA54", VA = "0x13BFA54")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x13BFAA4", Offset = "0x13BFAA4", VA = "0x13BFAA4")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x13BF67C", Offset = "0x13BF67C", VA = "0x13BF67C")]
		private void Write()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x13C3680", Offset = "0x13C3680", VA = "0x13C3680")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x13C3C7C", Offset = "0x13C3C7C", VA = "0x13C3C7C")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECFC4", Offset = "0x7ECFC4")]
		public Transform parent;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECFFC", Offset = "0x7ECFFC")]
		public Transform child;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED034", Offset = "0x7ED034")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ED034", Offset = "0x7ED034")]
		public float weight;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED088", Offset = "0x7ED088")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ED088", Offset = "0x7ED088")]
		public float parentChildCrossfade;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED0DC", Offset = "0x7ED0DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ED0DC", Offset = "0x7ED0DC")]
		public float twistAngleOffset;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x10B91A4", Offset = "0x10B91A4", VA = "0x10B91A4")]
		public void Relax()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x10B9590", Offset = "0x10B9590", VA = "0x10B9590")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x10B9A08", Offset = "0x10B9A08", VA = "0x10B9A08")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x10B9A90", Offset = "0x10B9A90", VA = "0x10B9A90")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x10B9B18", Offset = "0x10B9B18", VA = "0x10B9B18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x10B9C1C", Offset = "0x10B9C1C", VA = "0x10B9C1C")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public class InteractionEffector
	{
		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ED138", Offset = "0x7ED138")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ED148", Offset = "0x7ED148")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ED158", Offset = "0x7ED158")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x17000063")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x13CDF28", Offset = "0x13CDF28", VA = "0x13CDF28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F44F0", Offset = "0x7F44F0")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x13CDF30", Offset = "0x13CDF30", VA = "0x13CDF30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4500", Offset = "0x7F4500")]
			private set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public bool isPaused
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x13CDF38", Offset = "0x13CDF38", VA = "0x13CDF38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4510", Offset = "0x7F4510")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x13CDF40", Offset = "0x13CDF40", VA = "0x13CDF40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4520", Offset = "0x7F4520")]
			private set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x13CDF4C", Offset = "0x13CDF4C", VA = "0x13CDF4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4530", Offset = "0x7F4530")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x13CDF54", Offset = "0x13CDF54", VA = "0x13CDF54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4540", Offset = "0x7F4540")]
			private set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public bool inInteraction
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x13CDF5C", Offset = "0x13CDF5C", VA = "0x13CDF5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		public float progress
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x13D0138", Offset = "0x13D0138", VA = "0x13D0138")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x13CDFCC", Offset = "0x13CDFCC", VA = "0x13CDFCC")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x13CE050", Offset = "0x13CE050", VA = "0x13CE050")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x13CE0F8", Offset = "0x13CE0F8", VA = "0x13CE0F8")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x13CE23C", Offset = "0x13CE23C", VA = "0x13CE23C")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x13CE644", Offset = "0x13CE644", VA = "0x13CE644")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x13CE77C", Offset = "0x13CE77C", VA = "0x13CE77C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x13CE7D8", Offset = "0x13CE7D8", VA = "0x13CE7D8")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x13CEE18", Offset = "0x13CEE18", VA = "0x13CEE18")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x13CF930", Offset = "0x13CF930", VA = "0x13CF930")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x13CFB6C", Offset = "0x13CFB6C", VA = "0x13CFB6C")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x13CFFD8", Offset = "0x13CFFD8", VA = "0x13CFFD8")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x13D0204", Offset = "0x13D0204", VA = "0x13D0204")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED168", Offset = "0x7ED168")]
		public LookAtIK ik;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED1A0", Offset = "0x7ED1A0")]
		public float lerpSpeed;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED1D8", Offset = "0x7ED1D8")]
		public float weightSpeed;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x13D0470", Offset = "0x13D0470", VA = "0x13D0470")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x13D05EC", Offset = "0x13D05EC", VA = "0x13D05EC")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x13D0698", Offset = "0x13D0698", VA = "0x13D0698")]
		public void Update()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x13D08E4", Offset = "0x13D08E4", VA = "0x13D08E4")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x13D09E0", Offset = "0x13D09E0", VA = "0x13D09E0")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x13D0AB0", Offset = "0x13D0AB0", VA = "0x13D0AB0")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA4E0", Offset = "0x7EA4E0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA4E0", Offset = "0x7EA4E0")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E9")]
		public class InteractionEvent
		{
			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F13B8", Offset = "0x7F13B8")]
			public float time;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F13F0", Offset = "0x7F13F0")]
			public bool pause;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1428", Offset = "0x7F1428")]
			public bool pickUp;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1460", Offset = "0x7F1460")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1498", Offset = "0x7F1498")]
			public Message[] messages;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F14D0", Offset = "0x7F14D0")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x10A8B40", Offset = "0x10A8B40", VA = "0x10A8B40")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x10A8D0C", Offset = "0x10A8D0C", VA = "0x10A8D0C")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EA")]
		public class Message
		{
			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1508", Offset = "0x7F1508")]
			public string function;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1540", Offset = "0x7F1540")]
			public GameObject recipient;

			[Token(Token = "0x40006EF")]
			private const string empty = "";

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x10A8C1C", Offset = "0x10A8C1C", VA = "0x10A8C1C")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x10A8D14", Offset = "0x10A8D14", VA = "0x10A8D14")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EB")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1578", Offset = "0x7F1578")]
			public Animator animator;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F15B0", Offset = "0x7F15B0")]
			public Animation animation;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F15E8", Offset = "0x7F15E8")]
			public string animationState;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1620", Offset = "0x7F1620")]
			public float crossfadeTime;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1658", Offset = "0x7F1658")]
			public int layer;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1690", Offset = "0x7F1690")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40006F6")]
			private const string empty = "";

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x10A8898", Offset = "0x10A8898", VA = "0x10A8898")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x10A898C", Offset = "0x10A898C", VA = "0x10A898C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x10A8A48", Offset = "0x10A8A48", VA = "0x10A8A48")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x10A8B2C", Offset = "0x10A8B2C", VA = "0x10A8B2C")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EC")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000121")]
			public enum Type
			{
				[Token(Token = "0x400080C")]
				PositionWeight,
				[Token(Token = "0x400080D")]
				RotationWeight,
				[Token(Token = "0x400080E")]
				PositionOffsetX,
				[Token(Token = "0x400080F")]
				PositionOffsetY,
				[Token(Token = "0x4000810")]
				PositionOffsetZ,
				[Token(Token = "0x4000811")]
				Pull,
				[Token(Token = "0x4000812")]
				Reach,
				[Token(Token = "0x4000813")]
				RotateBoneWeight,
				[Token(Token = "0x4000814")]
				Push,
				[Token(Token = "0x4000815")]
				PushParent,
				[Token(Token = "0x4000816")]
				PoserWeight
			}

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F16C8", Offset = "0x7F16C8")]
			public Type type;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1700", Offset = "0x7F1700")]
			public AnimationCurve curve;

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x10A8D54", Offset = "0x10A8D54", VA = "0x10A8D54")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x10A8D80", Offset = "0x10A8D80", VA = "0x10A8D80")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000ED")]
		public class Multiplier
		{
			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1738", Offset = "0x7F1738")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1770", Offset = "0x7F1770")]
			public float multiplier;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F17A8", Offset = "0x7F17A8")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x10A8D1C", Offset = "0x10A8D1C", VA = "0x10A8D1C")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x10A8D70", Offset = "0x10A8D70", VA = "0x10A8D70")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED220", Offset = "0x7ED220")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED258", Offset = "0x7ED258")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED290", Offset = "0x7ED290")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ED2C8", Offset = "0x7ED2C8")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ED2D8", Offset = "0x7ED2D8")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000068")]
		public float length
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x13D0C8C", Offset = "0x13D0C8C", VA = "0x13D0C8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F46A0", Offset = "0x7F46A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x13D0C94", Offset = "0x13D0C94", VA = "0x13D0C94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F46B0", Offset = "0x7F46B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x13D0C9C", Offset = "0x13D0C9C", VA = "0x13D0C9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F46C0", Offset = "0x7F46C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x13D0CA4", Offset = "0x13D0CA4", VA = "0x13D0CA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F46D0", Offset = "0x7F46D0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x13D0ECC", Offset = "0x13D0ECC", VA = "0x13D0ECC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x13D0174", Offset = "0x13D0174", VA = "0x13D0174")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x13D0AC4", Offset = "0x13D0AC4", VA = "0x13D0AC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4550", Offset = "0x7F4550")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x13D0B10", Offset = "0x13D0B10", VA = "0x13D0B10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4588", Offset = "0x7F4588")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x13D0B5C", Offset = "0x13D0B5C", VA = "0x13D0B5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F45C0", Offset = "0x7F45C0")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x13D0BA8", Offset = "0x13D0BA8", VA = "0x13D0BA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F45F8", Offset = "0x7F45F8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x13D0BF4", Offset = "0x13D0BF4", VA = "0x13D0BF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4630", Offset = "0x7F4630")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x13D0C40", Offset = "0x13D0C40", VA = "0x13D0C40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4668", Offset = "0x7F4668")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x13D0CAC", Offset = "0x13D0CAC", VA = "0x13D0CAC")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x13D0F5C", Offset = "0x13D0F5C", VA = "0x13D0F5C")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x13CED5C", Offset = "0x13CED5C", VA = "0x13CED5C")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x13D10E8", Offset = "0x13D10E8", VA = "0x13D10E8")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x13CEC00", Offset = "0x13CEC00", VA = "0x13CEC00")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x13CED54", Offset = "0x13CED54", VA = "0x13CED54")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x13CF4E8", Offset = "0x13CF4E8", VA = "0x13CF4E8")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x13CFD84", Offset = "0x13CFD84", VA = "0x13CFD84")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x13D17BC", Offset = "0x13D17BC", VA = "0x13D17BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x13D1168", Offset = "0x13D1168", VA = "0x13D1168")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x13D10F0", Offset = "0x13D10F0", VA = "0x13D10F0")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x13D174C", Offset = "0x13D174C", VA = "0x13D174C")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x13D17C0", Offset = "0x13D17C0", VA = "0x13D17C0")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x13D1830", Offset = "0x13D1830", VA = "0x13D1830")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F46E0", Offset = "0x7F46E0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x13D187C", Offset = "0x13D187C", VA = "0x13D187C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4718", Offset = "0x7F4718")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x13D18C8", Offset = "0x13D18C8", VA = "0x13D18C8")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA540", Offset = "0x7EA540")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA540", Offset = "0x7EA540")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000EE")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000EF")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED2E8", Offset = "0x7ED2E8")]
		public string targetTag;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED320", Offset = "0x7ED320")]
		public float fadeInTime;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED358", Offset = "0x7ED358")]
		public float speed;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED390", Offset = "0x7ED390")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7ED3C8", Offset = "0x7ED3C8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED3C8", Offset = "0x7ED3C8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7ED3C8", Offset = "0x7ED3C8")]
		public Collider characterCollider;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED44C", Offset = "0x7ED44C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7ED44C", Offset = "0x7ED44C")]
		public Transform FPSCamera;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED4AC", Offset = "0x7ED4AC")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED4E4", Offset = "0x7ED4E4")]
		public float camRaycastDistance;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ED51C", Offset = "0x7ED51C")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7ED52C", Offset = "0x7ED52C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED52C", Offset = "0x7ED52C")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED58C", Offset = "0x7ED58C")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700006C")]
		public bool inInteraction
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x10A8F50", Offset = "0x10A8F50", VA = "0x10A8F50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x10AAD7C", Offset = "0x10AAD7C", VA = "0x10AAD7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x10AAD84", Offset = "0x10AAD84", VA = "0x10AAD84")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x10AAD8C", Offset = "0x10AAD8C", VA = "0x10AAD8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F48A0", Offset = "0x7F48A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x10AAD94", Offset = "0x10AAD94", VA = "0x10AAD94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F48B0", Offset = "0x7F48B0")]
			private set
			{
			}
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x10A8D88", Offset = "0x10A8D88", VA = "0x10A8D88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4750", Offset = "0x7F4750")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x10A8DD4", Offset = "0x10A8DD4", VA = "0x10A8DD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4788", Offset = "0x7F4788")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x10A8E20", Offset = "0x10A8E20", VA = "0x10A8E20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F47C0", Offset = "0x7F47C0")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x10A8E6C", Offset = "0x10A8E6C", VA = "0x10A8E6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F47F8", Offset = "0x7F47F8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x10A8EB8", Offset = "0x10A8EB8", VA = "0x10A8EB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4830", Offset = "0x7F4830")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x10A8F04", Offset = "0x10A8F04", VA = "0x10A8F04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4868", Offset = "0x7F4868")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x10A90FC", Offset = "0x10A90FC", VA = "0x10A90FC")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x10A91D8", Offset = "0x10A91D8", VA = "0x10A91D8")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x10A92B4", Offset = "0x10A92B4", VA = "0x10A92B4")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x10A9380", Offset = "0x10A9380", VA = "0x10A9380")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x10A9490", Offset = "0x10A9490", VA = "0x10A9490")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x10A95BC", Offset = "0x10A95BC", VA = "0x10A95BC")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x10A965C", Offset = "0x10A965C", VA = "0x10A965C")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x10A96FC", Offset = "0x10A96FC", VA = "0x10A96FC")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x10A979C", Offset = "0x10A979C", VA = "0x10A979C")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x10A981C", Offset = "0x10A981C", VA = "0x10A981C")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x10A989C", Offset = "0x10A989C", VA = "0x10A989C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x10A9910", Offset = "0x10A9910", VA = "0x10A9910")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x10A99A4", Offset = "0x10A99A4", VA = "0x10A99A4")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x10A9A44", Offset = "0x10A9A44", VA = "0x10A9A44")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x10A9B24", Offset = "0x10A9B24", VA = "0x10A9B24")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x10A9DD4", Offset = "0x10A9DD4", VA = "0x10A9DD4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x10A9FBC", Offset = "0x10A9FBC", VA = "0x10A9FBC")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x10AA250", Offset = "0x10AA250", VA = "0x10AA250")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x10AA55C", Offset = "0x10AA55C", VA = "0x10AA55C")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x10AA5A8", Offset = "0x10AA5A8", VA = "0x10AA5A8")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x10AA630", Offset = "0x10AA630", VA = "0x10AA630")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x10AA75C", Offset = "0x10AA75C", VA = "0x10AA75C")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x10AA8D4", Offset = "0x10AA8D4", VA = "0x10AA8D4")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x10AAB94", Offset = "0x10AAB94", VA = "0x10AAB94")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x10AA358", Offset = "0x10AA358", VA = "0x10AA358")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x10AAD9C", Offset = "0x10AAD9C", VA = "0x10AAD9C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x10AB478", Offset = "0x10AB478", VA = "0x10AB478")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x10AB49C", Offset = "0x10AB49C", VA = "0x10AB49C")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x10AB4BC", Offset = "0x10AB4BC", VA = "0x10AB4BC")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x10AB4DC", Offset = "0x10AB4DC", VA = "0x10AB4DC")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x10AB548", Offset = "0x10AB548", VA = "0x10AB548")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x10AB668", Offset = "0x10AB668", VA = "0x10AB668")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x10AB768", Offset = "0x10AB768", VA = "0x10AB768")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x10ABAD8", Offset = "0x10ABAD8", VA = "0x10ABAD8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x10ABBC4", Offset = "0x10ABBC4", VA = "0x10ABBC4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x10ABE24", Offset = "0x10ABE24", VA = "0x10ABE24")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x10AB1E8", Offset = "0x10AB1E8", VA = "0x10AB1E8")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x10ABF64", Offset = "0x10ABF64", VA = "0x10ABF64")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x10AC09C", Offset = "0x10AC09C", VA = "0x10AC09C")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x10AC148", Offset = "0x10AC148", VA = "0x10AC148")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x10AC240", Offset = "0x10AC240", VA = "0x10AC240")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x10AC25C", Offset = "0x10AC25C", VA = "0x10AC25C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x10A901C", Offset = "0x10A901C", VA = "0x10A901C")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x10A9CD0", Offset = "0x10A9CD0", VA = "0x10A9CD0")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x10AC564", Offset = "0x10AC564", VA = "0x10AC564")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F48C0", Offset = "0x7F48C0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x10AC5B0", Offset = "0x10AC5B0", VA = "0x10AC5B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F48F8", Offset = "0x7F48F8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x10AC5FC", Offset = "0x10AC5FC", VA = "0x10AC5FC")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA5A0", Offset = "0x7EA5A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA5A0", Offset = "0x7EA5A0")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F0")]
		public class Multiplier
		{
			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F17E0", Offset = "0x7F17E0")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1818", Offset = "0x7F1818")]
			public float multiplier;

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x10ADA54", Offset = "0x10ADA54", VA = "0x10ADA54")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED5C4", Offset = "0x7ED5C4")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED5FC", Offset = "0x7ED5FC")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED634", Offset = "0x7ED634")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED66C", Offset = "0x7ED66C")]
		public Transform pivot;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED6A4", Offset = "0x7ED6A4")]
		public Vector3 twistAxis;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED6DC", Offset = "0x7ED6DC")]
		public float twistWeight;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED714", Offset = "0x7ED714")]
		public float swingWeight;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED74C", Offset = "0x7ED74C")]
		public bool rotateOnce;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x10ACFA4", Offset = "0x10ACFA4", VA = "0x10ACFA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4930", Offset = "0x7F4930")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x10ACFF0", Offset = "0x10ACFF0", VA = "0x10ACFF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4968", Offset = "0x7F4968")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x10AD03C", Offset = "0x10AD03C", VA = "0x10AD03C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F49A0", Offset = "0x7F49A0")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x10AD088", Offset = "0x10AD088", VA = "0x10AD088")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F49D8", Offset = "0x7F49D8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x10AD0D4", Offset = "0x10AD0D4", VA = "0x10AD0D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4A10", Offset = "0x7F4A10")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x10AD120", Offset = "0x10AD120", VA = "0x10AD120")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4A48", Offset = "0x7F4A48")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x10AD16C", Offset = "0x10AD16C", VA = "0x10AD16C")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x10AD1E4", Offset = "0x10AD1E4", VA = "0x10AD1E4")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x10AD280", Offset = "0x10AD280", VA = "0x10AD280")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x10AD930", Offset = "0x10AD930", VA = "0x10AD930")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4A80", Offset = "0x7F4A80")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x10AD97C", Offset = "0x10AD97C", VA = "0x10AD97C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4AB8", Offset = "0x7F4AB8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x10AD9C8", Offset = "0x10AD9C8", VA = "0x10AD9C8")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA600", Offset = "0x7EA600")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA600", Offset = "0x7EA600")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F1")]
		public class CharacterPosition
		{
			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1850", Offset = "0x7F1850")]
			public bool use;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1888", Offset = "0x7F1888")]
			public Vector2 offset;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F18C0", Offset = "0x7F18C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F18C0", Offset = "0x7F18C0")]
			public float angleOffset;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F191C", Offset = "0x7F191C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F191C", Offset = "0x7F191C")]
			public float maxAngle;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1974", Offset = "0x7F1974")]
			public float radius;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F19AC", Offset = "0x7F19AC")]
			public bool orbit;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F19E4", Offset = "0x7F19E4")]
			public bool fixYAxis;

			[Token(Token = "0x170000BF")]
			public Vector3 offset3D
			{
				[Token(Token = "0x600071E")]
				[Address(RVA = "0x10AE1E8", Offset = "0x10AE1E8", VA = "0x10AE1E8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C0")]
			public Vector3 direction3D
			{
				[Token(Token = "0x600071F")]
				[Address(RVA = "0x10AE224", Offset = "0x10AE224", VA = "0x10AE224")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000720")]
			[Address(RVA = "0x10AE31C", Offset = "0x10AE31C", VA = "0x10AE31C")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x10AE99C", Offset = "0x10AE99C", VA = "0x10AE99C")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F2")]
		public class CameraPosition
		{
			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1A1C", Offset = "0x7F1A1C")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1A54", Offset = "0x7F1A54")]
			public Vector3 direction;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1A8C", Offset = "0x7F1A8C")]
			public float maxDistance;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1AC4", Offset = "0x7F1AC4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1AC4", Offset = "0x7F1AC4")]
			public float maxAngle;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1B1C", Offset = "0x7F1B1C")]
			public bool fixYAxis;

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x10ADCD0", Offset = "0x10ADCD0", VA = "0x10ADCD0")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x10ADE78", Offset = "0x10ADE78", VA = "0x10ADE78")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x10AE15C", Offset = "0x10AE15C", VA = "0x10AE15C")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F3")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000122")]
			public class Interaction
			{
				[Token(Token = "0x4000817")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2DA4", Offset = "0x7F2DA4")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000818")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2DDC", Offset = "0x7F2DDC")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60007C6")]
				[Address(RVA = "0x10AE9C0", Offset = "0x10AE9C0", VA = "0x10AE9C0")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1BC4", Offset = "0x7F1BC4")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1BFC", Offset = "0x7F1BFC")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1C34", Offset = "0x7F1C34")]
			public Interaction[] interactions;

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x10ADB44", Offset = "0x10ADB44", VA = "0x10ADB44")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0x10AE9B0", Offset = "0x10AE9B0", VA = "0x10AE9B0")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED784", Offset = "0x7ED784")]
		public Range[] ranges;

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x10ADA5C", Offset = "0x10ADA5C", VA = "0x10ADA5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4AF0", Offset = "0x7F4AF0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x10ADAA8", Offset = "0x10ADAA8", VA = "0x10ADAA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4B28", Offset = "0x7F4B28")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x10ADAF4", Offset = "0x10ADAF4", VA = "0x10ADAF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4B60", Offset = "0x7F4B60")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x10ADB40", Offset = "0x10ADB40", VA = "0x10ADB40")]
		private void Start()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x10AB914", Offset = "0x10AB914", VA = "0x10AB914")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x10ADC70", Offset = "0x10ADC70", VA = "0x10ADC70")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000F4")]
		public class Map
		{
			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000727")]
			[Address(RVA = "0xEF5C10", Offset = "0xEF5C10", VA = "0xEF5C10")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0xEF6030", Offset = "0xEF6030", VA = "0xEF6030")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0xEF5FE4", Offset = "0xEF5FE4", VA = "0xEF5FE4")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0xEF5DD0", Offset = "0xEF5DD0", VA = "0xEF5DD0")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xEF5914", Offset = "0xEF5914", VA = "0xEF5914", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4B98", Offset = "0x7F4B98")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xEF5CBC", Offset = "0xEF5CBC", VA = "0xEF5CBC", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xEF5CC0", Offset = "0xEF5CC0", VA = "0xEF5CC0", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xEF5F74", Offset = "0xEF5F74", VA = "0xEF5F74", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xEF5C4C", Offset = "0xEF5C4C", VA = "0xEF5C4C")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xEF5B64", Offset = "0xEF5B64", VA = "0xEF5B64")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xEF6080", Offset = "0xEF6080", VA = "0xEF6080")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x146B430", Offset = "0x146B430", VA = "0x146B430", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x146B4E4", Offset = "0x146B4E4", VA = "0x146B4E4", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x146B69C", Offset = "0x146B69C", VA = "0x146B69C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x146B788", Offset = "0x146B788", VA = "0x146B788", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x146B540", Offset = "0x146B540", VA = "0x146B540")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x146BB50", Offset = "0x146BB50", VA = "0x146BB50")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ED7BC", Offset = "0x7ED7BC")]
		public float weight;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ED7D4", Offset = "0x7ED7D4")]
		public float localRotationWeight;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ED7EC", Offset = "0x7ED7EC")]
		public float localPositionWeight;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000454")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x10B16F4", Offset = "0x10B16F4", VA = "0x10B16F4")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000456")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000457")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000458")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x10B1700", Offset = "0x10B1700", VA = "0x10B1700", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x10B1754", Offset = "0x10B1754", VA = "0x10B1754", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x10B1790", Offset = "0x10B1790", VA = "0x10B1790", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x10B17A8", Offset = "0x10B17A8", VA = "0x10B17A8")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EA660", Offset = "0x7EA660")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000F5")]
		public class Rigidbone
		{
			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x10B1D40", Offset = "0x10B1D40", VA = "0x10B1D40")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x10B2994", Offset = "0x10B2994", VA = "0x10B2994")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x10B2770", Offset = "0x10B2770", VA = "0x10B2770")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000F6")]
		public class Child
		{
			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x10B1EA0", Offset = "0x10B1EA0", VA = "0x10B1EA0")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x600072F")]
			[Address(RVA = "0x10B2B2C", Offset = "0x10B2B2C", VA = "0x10B2B2C")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000730")]
			[Address(RVA = "0x10B2ADC", Offset = "0x10B2ADC", VA = "0x10B2ADC")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EADF0", Offset = "0x7EADF0")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000C1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000734")]
				[Address(RVA = "0x10B3110", Offset = "0x10B3110", VA = "0x10B3110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000736")]
				[Address(RVA = "0x10B317C", Offset = "0x10B317C", VA = "0x10B317C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0x10B1F04", Offset = "0x10B1F04", VA = "0x10B1F04")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000732")]
			[Address(RVA = "0x10B2EC8", Offset = "0x10B2EC8", VA = "0x10B2EC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x10B2ECC", Offset = "0x10B2ECC", VA = "0x10B2ECC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x10B3118", Offset = "0x10B3118", VA = "0x10B3118", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED804", Offset = "0x7ED804")]
		public IK ik;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED83C", Offset = "0x7ED83C")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED874", Offset = "0x7ED874")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED8AC", Offset = "0x7ED8AC")]
		public float applyVelocity;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED8E4", Offset = "0x7ED8E4")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700006F")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x10B1808", Offset = "0x10B1808", VA = "0x10B1808")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		private bool ikUsed
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x10B2308", Offset = "0x10B2308", VA = "0x10B2308")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x10B17D0", Offset = "0x10B17D0", VA = "0x10B17D0")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x10B188C", Offset = "0x10B188C", VA = "0x10B188C")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x10B19CC", Offset = "0x10B19CC", VA = "0x10B19CC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x10B1958", Offset = "0x10B1958", VA = "0x10B1958")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F4BD0", Offset = "0x7F4BD0")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x10B1F30", Offset = "0x10B1F30", VA = "0x10B1F30")]
		private void Update()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x10B2188", Offset = "0x10B2188", VA = "0x10B2188")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x10B224C", Offset = "0x10B224C", VA = "0x10B224C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x10B2498", Offset = "0x10B2498", VA = "0x10B2498")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x10B22CC", Offset = "0x10B22CC", VA = "0x10B22CC")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x10B2454", Offset = "0x10B2454", VA = "0x10B2454")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x10B2540", Offset = "0x10B2540", VA = "0x10B2540")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x10B24CC", Offset = "0x10B24CC", VA = "0x10B24CC")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x10B18E4", Offset = "0x10B18E4", VA = "0x10B18E4")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x10B21C8", Offset = "0x10B21C8", VA = "0x10B21C8")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x10B2CF8", Offset = "0x10B2CF8", VA = "0x10B2CF8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x10B2DFC", Offset = "0x10B2DFC", VA = "0x10B2DFC")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000071")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x10B4B34", Offset = "0x10B4B34", VA = "0x10B4B34")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000072")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x10B4B70", Offset = "0x10B4B70", VA = "0x10B4B70")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x10B47B0", Offset = "0x10B47B0", VA = "0x10B47B0")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x10B47F4", Offset = "0x10B47F4", VA = "0x10B47F4")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x10B4A84", Offset = "0x10B4A84", VA = "0x10B4A84")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x10B4AFC", Offset = "0x10B4AFC", VA = "0x10B4AFC")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000475")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x10B4994", Offset = "0x10B4994", VA = "0x10B4994")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x10B4C40", Offset = "0x10B4C40", VA = "0x10B4C40")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x10B4C44", Offset = "0x10B4C44", VA = "0x10B4C44")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x10B4C74", Offset = "0x10B4C74", VA = "0x10B4C74")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x10B4D58", Offset = "0x10B4D58", VA = "0x10B4D58")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x10B4FD8", Offset = "0x10B4FD8", VA = "0x10B4FD8")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x10B5094", Offset = "0x10B5094", VA = "0x10B5094")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA6C4", Offset = "0x7EA6C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA6C4", Offset = "0x7EA6C4")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ED92C", Offset = "0x7ED92C")]
		public float limit;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ED948", Offset = "0x7ED948")]
		public float twistLimit;

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x10B510C", Offset = "0x10B510C", VA = "0x10B510C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4C34", Offset = "0x7F4C34")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x10B5158", Offset = "0x10B5158", VA = "0x10B5158")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4C6C", Offset = "0x7F4C6C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x10B51A4", Offset = "0x10B51A4", VA = "0x10B51A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4CA4", Offset = "0x7F4CA4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x10B51F0", Offset = "0x10B51F0", VA = "0x10B51F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4CDC", Offset = "0x7F4CDC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x10B523C", Offset = "0x10B523C", VA = "0x10B523C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x10B52F4", Offset = "0x10B52F4", VA = "0x10B52F4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x10B553C", Offset = "0x10B553C", VA = "0x10B553C")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA724", Offset = "0x7EA724")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA724", Offset = "0x7EA724")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x10B554C", Offset = "0x10B554C", VA = "0x10B554C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4D14", Offset = "0x7F4D14")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x10B5598", Offset = "0x10B5598", VA = "0x10B5598")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4D4C", Offset = "0x7F4D4C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x10B55E4", Offset = "0x10B55E4", VA = "0x10B55E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4D84", Offset = "0x7F4D84")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x10B5630", Offset = "0x10B5630", VA = "0x10B5630")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4DBC", Offset = "0x7F4DBC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x10B567C", Offset = "0x10B567C", VA = "0x10B567C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x10B56A4", Offset = "0x10B56A4", VA = "0x10B56A4")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x10B59A4", Offset = "0x10B59A4", VA = "0x10B59A4")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA784", Offset = "0x7EA784")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA784", Offset = "0x7EA784")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000F8")]
		public class ReachCone
		{
			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000C3")]
			public Vector3 o
			{
				[Token(Token = "0x6000737")]
				[Address(RVA = "0x10B7930", Offset = "0x10B7930", VA = "0x10B7930")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C4")]
			public Vector3 a
			{
				[Token(Token = "0x6000738")]
				[Address(RVA = "0x10B7970", Offset = "0x10B7970", VA = "0x10B7970")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C5")]
			public Vector3 b
			{
				[Token(Token = "0x6000739")]
				[Address(RVA = "0x10B79B4", Offset = "0x10B79B4", VA = "0x10B79B4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C6")]
			public Vector3 c
			{
				[Token(Token = "0x600073A")]
				[Address(RVA = "0x10B79F8", Offset = "0x10B79F8", VA = "0x10B79F8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000C7")]
			public bool isValid
			{
				[Token(Token = "0x600073C")]
				[Address(RVA = "0x10B6AA0", Offset = "0x10B6AA0", VA = "0x10B6AA0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x10B70E8", Offset = "0x10B70E8", VA = "0x10B70E8")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x10B7254", Offset = "0x10B7254", VA = "0x10B7254")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F9")]
		public class LimitPoint
		{
			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x600073E")]
			[Address(RVA = "0x10B6AB0", Offset = "0x10B6AB0", VA = "0x10B6AB0")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ED974", Offset = "0x7ED974")]
		public float twistLimit;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ED990", Offset = "0x7ED990")]
		public int smoothIterations;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x10B5A2C", Offset = "0x10B5A2C", VA = "0x10B5A2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4DF4", Offset = "0x7F4DF4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x10B5A78", Offset = "0x10B5A78", VA = "0x10B5A78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4E2C", Offset = "0x7F4E2C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x10B5AC4", Offset = "0x10B5AC4", VA = "0x10B5AC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4E64", Offset = "0x7F4E64")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x10B5B10", Offset = "0x10B5B10", VA = "0x10B5B10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4E9C", Offset = "0x7F4E9C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x10B5B5C", Offset = "0x10B5B5C", VA = "0x10B5B5C")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x10B602C", Offset = "0x10B602C", VA = "0x10B602C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x10B6128", Offset = "0x10B6128", VA = "0x10B6128")]
		private void Start()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x10B66E8", Offset = "0x10B66E8", VA = "0x10B66E8")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x10B5BFC", Offset = "0x10B5BFC", VA = "0x10B5BFC")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x10B6B34", Offset = "0x10B6B34", VA = "0x10B6B34")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x10B7414", Offset = "0x10B7414", VA = "0x10B7414")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x10B7458", Offset = "0x10B7458", VA = "0x10B7458")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x10B75A0", Offset = "0x10B75A0", VA = "0x10B75A0")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x10B63A8", Offset = "0x10B63A8", VA = "0x10B63A8")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x10B7730", Offset = "0x10B7730", VA = "0x10B7730")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x10B78CC", Offset = "0x10B78CC", VA = "0x10B78CC")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7EA7E4", Offset = "0x7EA7E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7EA7E4", Offset = "0x7EA7E4")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EDA50", Offset = "0x7EDA50")]
		public float twistLimit;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x10B7A3C", Offset = "0x10B7A3C", VA = "0x10B7A3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4ED4", Offset = "0x7F4ED4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x10B7A88", Offset = "0x10B7A88", VA = "0x10B7A88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4F0C", Offset = "0x7F4F0C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x10B7AD4", Offset = "0x10B7AD4", VA = "0x10B7AD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4F44", Offset = "0x7F4F44")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x10B7B20", Offset = "0x10B7B20", VA = "0x10B7B20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4F7C", Offset = "0x7F4F7C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x10B7B6C", Offset = "0x10B7B6C", VA = "0x10B7B6C")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x10B7B88", Offset = "0x10B7B88", VA = "0x10B7B88", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x10B7C40", Offset = "0x10B7C40", VA = "0x10B7C40")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x10B7F6C", Offset = "0x10B7F6C", VA = "0x10B7F6C")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EAE00", Offset = "0x7EAE00")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000C8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000742")]
				[Address(RVA = "0xEE9960", Offset = "0xEE9960", VA = "0xEE9960", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000744")]
				[Address(RVA = "0xEE99CC", Offset = "0xEE99CC", VA = "0xEE99CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0xEE9740", Offset = "0xEE9740", VA = "0xEE9740")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0xEE9838", Offset = "0xEE9838", VA = "0xEE9838", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0xEE983C", Offset = "0xEE983C", VA = "0xEE983C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0xEE9968", Offset = "0xEE9968", VA = "0xEE9968", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDAA4", Offset = "0x7EDAA4")]
		public AimIK ik;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDADC", Offset = "0x7EDADC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EDADC", Offset = "0x7EDADC")]
		public float weight;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EDB30", Offset = "0x7EDB30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDB30", Offset = "0x7EDB30")]
		public Transform target;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDB90", Offset = "0x7EDB90")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDBC8", Offset = "0x7EDBC8")]
		public float weightSmoothTime;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EDC00", Offset = "0x7EDC00")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDC00", Offset = "0x7EDC00")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDC60", Offset = "0x7EDC60")]
		public float maxRadiansDelta;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDC98", Offset = "0x7EDC98")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDCD0", Offset = "0x7EDCD0")]
		public float slerpSpeed;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDD08", Offset = "0x7EDD08")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDD40", Offset = "0x7EDD40")]
		public float minDistance;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDD78", Offset = "0x7EDD78")]
		public Vector3 offset;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EDDB0", Offset = "0x7EDDB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDDB0", Offset = "0x7EDDB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EDDB0", Offset = "0x7EDDB0")]
		public float maxRootAngle;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDE2C", Offset = "0x7EDE2C")]
		public bool turnToTarget;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDE64", Offset = "0x7EDE64")]
		public float turnToTargetTime;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EDE9C", Offset = "0x7EDE9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDE9C", Offset = "0x7EDE9C")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDEFC", Offset = "0x7EDEFC")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x17000073")]
		private Vector3 pivot
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xEE8948", Offset = "0xEE8948", VA = "0xEE8948")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xEE8848", Offset = "0xEE8848", VA = "0xEE8848")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xEE8A94", Offset = "0xEE8A94", VA = "0xEE8A94")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xEE91B8", Offset = "0xEE91B8", VA = "0xEE91B8")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xEE9358", Offset = "0xEE9358", VA = "0xEE9358")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xEE96CC", Offset = "0xEE96CC", VA = "0xEE96CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F4FB4", Offset = "0x7F4FB4")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xEE976C", Offset = "0xEE976C", VA = "0xEE976C")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FB")]
		public class Pose
		{
			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000745")]
			[Address(RVA = "0xEE9CA8", Offset = "0xEE9CA8", VA = "0xEE9CA8")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0xEEA01C", Offset = "0xEEA01C", VA = "0xEEA01C")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0xEEA024", Offset = "0xEEA024", VA = "0xEEA024")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xEE9BC0", Offset = "0xEE9BC0", VA = "0xEE9BC0")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xEE9F44", Offset = "0xEE9F44", VA = "0xEE9F44")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xEE9FB4", Offset = "0xEE9FB4", VA = "0xEE9FB4")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FC")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000123")]
			public class EffectorLink
			{
				[Token(Token = "0x4000819")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2E14", Offset = "0x7F2E14")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400081A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2E4C", Offset = "0x7F2E4C")]
				public float weight;

				[Token(Token = "0x60007C7")]
				[Address(RVA = "0xEEA634", Offset = "0xEEA634", VA = "0xEEA634")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1C6C", Offset = "0x7F1C6C")]
			public Transform transform;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1CA4", Offset = "0x7F1CA4")]
			public Transform relativeTo;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1CDC", Offset = "0x7F1CDC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1D14", Offset = "0x7F1D14")]
			public float verticalWeight;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1D4C", Offset = "0x7F1D4C")]
			public float horizontalWeight;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1D84", Offset = "0x7F1D84")]
			public float speed;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000748")]
			[Address(RVA = "0xEEA188", Offset = "0xEEA188", VA = "0xEEA188")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0xEEA60C", Offset = "0xEEA60C", VA = "0xEEA60C")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0xEEA61C", Offset = "0xEEA61C", VA = "0xEEA61C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDF34", Offset = "0x7EDF34")]
		public Body[] bodies;

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xEEA040", Offset = "0xEEA040", VA = "0xEEA040", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xEEA604", Offset = "0xEEA604", VA = "0xEEA604")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDF6C", Offset = "0x7EDF6C")]
		public float tiltSpeed;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDFA4", Offset = "0x7EDFA4")]
		public float tiltSensitivity;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDFDC", Offset = "0x7EDFDC")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE014", Offset = "0x7EE014")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xEEBBD8", Offset = "0xEEBBD8", VA = "0xEEBBD8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xEEBC20", Offset = "0xEEBC20", VA = "0xEEBC20", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xEEBE58", Offset = "0xEEBE58", VA = "0xEEBE58")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FD")]
		public abstract class HitPoint
		{
			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1DBC", Offset = "0x7F1DBC")]
			public string name;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1DF4", Offset = "0x7F1DF4")]
			public Collider collider;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1E2C", Offset = "0x7F1E2C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F1E78", Offset = "0x7F1E78")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F1E88", Offset = "0x7F1E88")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F1E98", Offset = "0x7F1E98")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F1EA8", Offset = "0x7F1EA8")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000CA")]
			public bool inProgress
			{
				[Token(Token = "0x600074B")]
				[Address(RVA = "0x146BC1C", Offset = "0x146BC1C", VA = "0x146BC1C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000CB")]
			protected float crossFader
			{
				[Token(Token = "0x600074C")]
				[Address(RVA = "0x146C1D4", Offset = "0x146C1D4", VA = "0x146C1D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F56C0", Offset = "0x7F56C0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600074D")]
				[Address(RVA = "0x146C1DC", Offset = "0x146C1DC", VA = "0x146C1DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F56D0", Offset = "0x7F56D0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CC")]
			protected float timer
			{
				[Token(Token = "0x600074E")]
				[Address(RVA = "0x146C1E4", Offset = "0x146C1E4", VA = "0x146C1E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F56E0", Offset = "0x7F56E0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600074F")]
				[Address(RVA = "0x146C1EC", Offset = "0x146C1EC", VA = "0x146C1EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F56F0", Offset = "0x7F56F0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CD")]
			protected Vector3 force
			{
				[Token(Token = "0x6000750")]
				[Address(RVA = "0x146C1F4", Offset = "0x146C1F4", VA = "0x146C1F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5700", Offset = "0x7F5700")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000751")]
				[Address(RVA = "0x146C200", Offset = "0x146C200", VA = "0x146C200")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5710", Offset = "0x7F5710")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CE")]
			protected Vector3 point
			{
				[Token(Token = "0x6000752")]
				[Address(RVA = "0x146C20C", Offset = "0x146C20C", VA = "0x146C20C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5720", Offset = "0x7F5720")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000753")]
				[Address(RVA = "0x146C218", Offset = "0x146C218", VA = "0x146C218")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5730", Offset = "0x7F5730")]
				private set
				{
				}
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0x146C0A0", Offset = "0x146C0A0", VA = "0x146C0A0")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x146BD0C", Offset = "0x146BD0C", VA = "0x146BD0C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000756")]
			protected abstract float GetLength();

			[Token(Token = "0x6000757")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000758")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x146C224", Offset = "0x146C224", VA = "0x146C224")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FE")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000124")]
			public class EffectorLink
			{
				[Token(Token = "0x400081B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2E84", Offset = "0x7F2E84")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400081C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2EBC", Offset = "0x7F2EBC")]
				public float weight;

				[Token(Token = "0x400081D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400081E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60007C8")]
				[Address(RVA = "0x146CBF4", Offset = "0x146CBF4", VA = "0x146CBF4")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60007C9")]
				[Address(RVA = "0x146C9E0", Offset = "0x146C9E0", VA = "0x146C9E0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007CA")]
				[Address(RVA = "0x146CE78", Offset = "0x146CE78", VA = "0x146CE78")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1EB8", Offset = "0x7F1EB8")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1EF0", Offset = "0x7F1EF0")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1F28", Offset = "0x7F1F28")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x146C7E8", Offset = "0x146C7E8", VA = "0x146C7E8", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x146C96C", Offset = "0x146C96C", VA = "0x146C96C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x146C9F4", Offset = "0x146C9F4", VA = "0x146C9F4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x146CD1C", Offset = "0x146CD1C", VA = "0x146CD1C")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FF")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000125")]
			public class BoneLink
			{
				[Token(Token = "0x400081F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2EF4", Offset = "0x7F2EF4")]
				public Transform bone;

				[Token(Token = "0x4000820")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2F2C", Offset = "0x7F2F2C")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F2F2C", Offset = "0x7F2F2C")]
				public float weight;

				[Token(Token = "0x4000821")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000822")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60007CB")]
				[Address(RVA = "0x146C5EC", Offset = "0x146C5EC", VA = "0x146C5EC")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60007CC")]
				[Address(RVA = "0x146C364", Offset = "0x146C364", VA = "0x146C364")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007CD")]
				[Address(RVA = "0x146C760", Offset = "0x146C760", VA = "0x146C760")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1F60", Offset = "0x7F1F60")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1F98", Offset = "0x7F1F98")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x146C238", Offset = "0x146C238", VA = "0x146C238", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0x146C2E8", Offset = "0x146C2E8", VA = "0x146C2E8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x146C380", Offset = "0x146C380", VA = "0x146C380", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000761")]
			[Address(RVA = "0x146C74C", Offset = "0x146C74C", VA = "0x146C74C")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE04C", Offset = "0x7EE04C")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE084", Offset = "0x7EE084")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000074")]
		public bool inProgress
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x146BB58", Offset = "0x146BB58", VA = "0x146BB58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x146BC30", Offset = "0x146BC30", VA = "0x146BC30", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x146BE58", Offset = "0x146BE58", VA = "0x146BE58")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x146C1CC", Offset = "0x146C1CC", VA = "0x146C1CC")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x2000100")]
		public abstract class Offset
		{
			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1FD0", Offset = "0x7F1FD0")]
			public string name;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2008", Offset = "0x7F2008")]
			public Collider collider;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2040", Offset = "0x7F2040")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F208C", Offset = "0x7F208C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F209C", Offset = "0x7F209C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F20AC", Offset = "0x7F20AC")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F20BC", Offset = "0x7F20BC")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000CF")]
			protected float crossFader
			{
				[Token(Token = "0x6000762")]
				[Address(RVA = "0x146D444", Offset = "0x146D444", VA = "0x146D444")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5740", Offset = "0x7F5740")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000763")]
				[Address(RVA = "0x146D44C", Offset = "0x146D44C", VA = "0x146D44C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5750", Offset = "0x7F5750")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D0")]
			protected float timer
			{
				[Token(Token = "0x6000764")]
				[Address(RVA = "0x146D454", Offset = "0x146D454", VA = "0x146D454")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5760", Offset = "0x7F5760")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000765")]
				[Address(RVA = "0x146D45C", Offset = "0x146D45C", VA = "0x146D45C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5770", Offset = "0x7F5770")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D1")]
			protected Vector3 force
			{
				[Token(Token = "0x6000766")]
				[Address(RVA = "0x146D464", Offset = "0x146D464", VA = "0x146D464")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5780", Offset = "0x7F5780")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000767")]
				[Address(RVA = "0x146D470", Offset = "0x146D470", VA = "0x146D470")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5790", Offset = "0x7F5790")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D2")]
			protected Vector3 point
			{
				[Token(Token = "0x6000768")]
				[Address(RVA = "0x146D47C", Offset = "0x146D47C", VA = "0x146D47C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F57A0", Offset = "0x7F57A0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000769")]
				[Address(RVA = "0x146D488", Offset = "0x146D488", VA = "0x146D488")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F57B0", Offset = "0x7F57B0")]
				private set
				{
				}
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x146D2FC", Offset = "0x146D2FC", VA = "0x146D2FC")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x146CF58", Offset = "0x146CF58", VA = "0x146CF58")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600076C")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x600076D")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600076E")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600076F")]
			[Address(RVA = "0x146D494", Offset = "0x146D494", VA = "0x146D494")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000101")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000126")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000823")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2F80", Offset = "0x7F2F80")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000824")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2FB8", Offset = "0x7F2FB8")]
				public float weight;

				[Token(Token = "0x4000825")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000826")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60007CE")]
				[Address(RVA = "0x146D96C", Offset = "0x146D96C", VA = "0x146D96C")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60007CF")]
				[Address(RVA = "0x146D720", Offset = "0x146D720", VA = "0x146D720")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007D0")]
				[Address(RVA = "0x146DA8C", Offset = "0x146DA8C", VA = "0x146DA8C")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F20CC", Offset = "0x7F20CC")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2104", Offset = "0x7F2104")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F213C", Offset = "0x7F213C")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x146D4A8", Offset = "0x146D4A8", VA = "0x146D4A8", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x146D6AC", Offset = "0x146D6AC", VA = "0x146D6AC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x146D734", Offset = "0x146D734", VA = "0x146D734", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x146DA70", Offset = "0x146DA70", VA = "0x146DA70")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000102")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000127")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000827")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2FF0", Offset = "0x7F2FF0")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000828")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F3028", Offset = "0x7F3028")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F3028", Offset = "0x7F3028")]
				public float weight;

				[Token(Token = "0x4000829")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x400082A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x60007D1")]
				[Address(RVA = "0x146DF38", Offset = "0x146DF38", VA = "0x146DF38")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60007D2")]
				[Address(RVA = "0x146DC00", Offset = "0x146DC00", VA = "0x146DC00")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007D3")]
				[Address(RVA = "0x146E078", Offset = "0x146E078", VA = "0x146E078")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2174", Offset = "0x7F2174")]
			public int curveIndex;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F21AC", Offset = "0x7F21AC")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x146DA94", Offset = "0x146DA94", VA = "0x146DA94", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x146DB84", Offset = "0x146DB84", VA = "0x146DB84", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x146DC1C", Offset = "0x146DC1C", VA = "0x146DC1C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x146E064", Offset = "0x146E064", VA = "0x146E064")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE0BC", Offset = "0x7EE0BC")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE0F4", Offset = "0x7EE0F4")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x146CE80", Offset = "0x146CE80", VA = "0x146CE80", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x146D0AC", Offset = "0x146D0AC", VA = "0x146D0AC")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x146D43C", Offset = "0x146D43C", VA = "0x146D43C")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000103")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000128")]
			public class EffectorLink
			{
				[Token(Token = "0x400082B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F307C", Offset = "0x7F307C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400082C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F30B4", Offset = "0x7F30B4")]
				public float weight;

				[Token(Token = "0x60007D4")]
				[Address(RVA = "0x13CDF20", Offset = "0x13CDF20", VA = "0x13CDF20")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F21E4", Offset = "0x7F21E4")]
			public Transform transform;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F221C", Offset = "0x7F221C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2254", Offset = "0x7F2254")]
			public float speed;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F228C", Offset = "0x7F228C")]
			public float acceleration;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F22C4", Offset = "0x7F22C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F22C4", Offset = "0x7F22C4")]
			public float matchVelocity;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2318", Offset = "0x7F2318")]
			public float gravity;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000778")]
			[Address(RVA = "0x13CD9D4", Offset = "0x13CD9D4", VA = "0x13CD9D4")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x13CDB74", Offset = "0x13CDB74", VA = "0x13CDB74")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0x13CDF04", Offset = "0x13CDF04", VA = "0x13CDF04")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE12C", Offset = "0x7EE12C")]
		public Body[] bodies;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE164", Offset = "0x7EE164")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x13CD950", Offset = "0x13CD950", VA = "0x13CD950")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x13CDAB0", Offset = "0x13CDAB0", VA = "0x13CDAB0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x13CDEFC", Offset = "0x13CDEFC", VA = "0x13CDEFC")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EE19C", Offset = "0x7EE19C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE19C", Offset = "0x7EE19C")]
		public Transform target;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EE1FC", Offset = "0x7EE1FC")]
		public float weight;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE214", Offset = "0x7EE214")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE24C", Offset = "0x7EE24C")]
		public float weightSmoothTime;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EE284", Offset = "0x7EE284")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE284", Offset = "0x7EE284")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE2E4", Offset = "0x7EE2E4")]
		public float maxRadiansDelta;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE31C", Offset = "0x7EE31C")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE354", Offset = "0x7EE354")]
		public float slerpSpeed;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE38C", Offset = "0x7EE38C")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE3C4", Offset = "0x7EE3C4")]
		public float minDistance;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EE3FC", Offset = "0x7EE3FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE3FC", Offset = "0x7EE3FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EE3FC", Offset = "0x7EE3FC")]
		public float maxRootAngle;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x17000075")]
		private Vector3 pivot
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x10AEE34", Offset = "0x10AEE34", VA = "0x10AEE34")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x10AED48", Offset = "0x10AED48", VA = "0x10AED48")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x10AEF80", Offset = "0x10AEF80", VA = "0x10AEF80")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x10AF620", Offset = "0x10AF620", VA = "0x10AF620")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x10AF7C0", Offset = "0x10AF7C0", VA = "0x10AF7C0")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x10AFAE0", Offset = "0x10AFAE0", VA = "0x10AFAE0")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000104")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2350", Offset = "0x7F2350")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2388", Offset = "0x7F2388")]
			public float spring;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F23C0", Offset = "0x7F23C0")]
			public bool x;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F23F8", Offset = "0x7F23F8")]
			public bool y;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2430", Offset = "0x7F2430")]
			public bool z;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2468", Offset = "0x7F2468")]
			public float minX;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F24A0", Offset = "0x7F24A0")]
			public float maxX;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F24D8", Offset = "0x7F24D8")]
			public float minY;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2510", Offset = "0x7F2510")]
			public float maxY;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2548", Offset = "0x7F2548")]
			public float minZ;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2580", Offset = "0x7F2580")]
			public float maxZ;

			[Token(Token = "0x600077B")]
			[Address(RVA = "0x10AFFF4", Offset = "0x10AFFF4", VA = "0x10AFFF4")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600077C")]
			[Address(RVA = "0x10B051C", Offset = "0x10B051C", VA = "0x10B051C")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600077D")]
			[Address(RVA = "0x10B054C", Offset = "0x10B054C", VA = "0x10B054C")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600077E")]
			[Address(RVA = "0x10B0624", Offset = "0x10B0624", VA = "0x10B0624")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EAE10", Offset = "0x7EAE10")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000D3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000782")]
				[Address(RVA = "0x10B04A8", Offset = "0x10B04A8", VA = "0x10B04A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000784")]
				[Address(RVA = "0x10B0514", Offset = "0x10B0514", VA = "0x10B0514", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600077F")]
			[Address(RVA = "0x10AFDF8", Offset = "0x10AFDF8", VA = "0x10AFDF8")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000780")]
			[Address(RVA = "0x10B0364", Offset = "0x10B0364", VA = "0x10B0364", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000781")]
			[Address(RVA = "0x10B0368", Offset = "0x10B0368", VA = "0x10B0368", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000783")]
			[Address(RVA = "0x10B04B0", Offset = "0x10B04B0", VA = "0x10B04B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE478", Offset = "0x7EE478")]
		public float weight;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE4B0", Offset = "0x7EE4B0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000076")]
		protected float deltaTime
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x10AFD2C", Offset = "0x10AFD2C", VA = "0x10AFD2C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004C3")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x10AFD58", Offset = "0x10AFD58", VA = "0x10AFD58", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x10AFD84", Offset = "0x10AFD84", VA = "0x10AFD84")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F5018", Offset = "0x7F5018")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x10AFE24", Offset = "0x10AFE24", VA = "0x10AFE24")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x10AFF30", Offset = "0x10AFF30", VA = "0x10AFF30")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x10B0258", Offset = "0x10B0258", VA = "0x10B0258", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x10B0354", Offset = "0x10B0354", VA = "0x10B0354")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EAE20", Offset = "0x7EAE20")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000D5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000788")]
				[Address(RVA = "0x10B0A80", Offset = "0x10B0A80", VA = "0x10B0A80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600078A")]
				[Address(RVA = "0x10B0AEC", Offset = "0x10B0AEC", VA = "0x10B0AEC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0x10B06F8", Offset = "0x10B06F8", VA = "0x10B06F8")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0x10B093C", Offset = "0x10B093C", VA = "0x10B093C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000787")]
			[Address(RVA = "0x10B0940", Offset = "0x10B0940", VA = "0x10B0940", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000789")]
			[Address(RVA = "0x10B0A88", Offset = "0x10B0A88", VA = "0x10B0A88", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE4E8", Offset = "0x7EE4E8")]
		public float weight;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE520", Offset = "0x7EE520")]
		public VRIK ik;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000077")]
		protected float deltaTime
		{
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x10B062C", Offset = "0x10B062C", VA = "0x10B062C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004CB")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x10B0658", Offset = "0x10B0658", VA = "0x10B0658", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x10B0684", Offset = "0x10B0684", VA = "0x10B0684")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F507C", Offset = "0x7F507C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x10B0724", Offset = "0x10B0724", VA = "0x10B0724")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x10B0830", Offset = "0x10B0830", VA = "0x10B0830", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x10B092C", Offset = "0x10B092C", VA = "0x10B092C")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000107")]
		public class EffectorLink
		{
			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x600078B")]
			[Address(RVA = "0x10B0BB8", Offset = "0x10B0BB8", VA = "0x10B0BB8")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x600078C")]
			[Address(RVA = "0x10B1008", Offset = "0x10B1008", VA = "0x10B1008")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x10B0AF4", Offset = "0x10B0AF4", VA = "0x10B0AF4")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x10B0EE8", Offset = "0x10B0EE8", VA = "0x10B0EE8")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x10B0FA8", Offset = "0x10B0FA8", VA = "0x10B0FA8")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000108")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x2000129")]
			public class EffectorLink
			{
				[Token(Token = "0x400082D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F30EC", Offset = "0x7F30EC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400082E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F3124", Offset = "0x7F3124")]
				public float weight;

				[Token(Token = "0x60007D5")]
				[Address(RVA = "0x10B16EC", Offset = "0x10B16EC", VA = "0x10B16EC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F25B8", Offset = "0x7F25B8")]
			public Transform[] raycastFrom;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F25F0", Offset = "0x7F25F0")]
			public Transform raycastTo;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2628", Offset = "0x7F2628")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F2628", Offset = "0x7F2628")]
			public float raycastRadius;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F267C", Offset = "0x7F267C")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F26B4", Offset = "0x7F26B4")]
			public float smoothTimeIn;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F26EC", Offset = "0x7F26EC")]
			public float smoothTimeOut;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2724", Offset = "0x7F2724")]
			public LayerMask layers;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x600078D")]
			[Address(RVA = "0x10B109C", Offset = "0x10B109C", VA = "0x10B109C")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x10B12B0", Offset = "0x10B12B0", VA = "0x10B12B0")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x10B145C", Offset = "0x10B145C", VA = "0x10B145C")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x10B16D0", Offset = "0x10B16D0", VA = "0x10B16D0")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE558", Offset = "0x7EE558")]
		public Avoider[] avoiders;

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x10B1010", Offset = "0x10B1010", VA = "0x10B1010", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x10B12A0", Offset = "0x10B12A0", VA = "0x10B12A0")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000109")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x200012A")]
			public class EffectorLink
			{
				[Token(Token = "0x400082F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F315C", Offset = "0x7F315C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000830")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F3194", Offset = "0x7F3194")]
				public float weight;

				[Token(Token = "0x60007D6")]
				[Address(RVA = "0x10B47A8", Offset = "0x10B47A8", VA = "0x10B47A8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F275C", Offset = "0x7F275C")]
			public Vector3 offset;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2794", Offset = "0x7F2794")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F2794", Offset = "0x7F2794")]
			public float additivity;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F27E8", Offset = "0x7F27E8")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2820", Offset = "0x7F2820")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x10B350C", Offset = "0x10B350C", VA = "0x10B350C")]
			public void Start()
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x10B4070", Offset = "0x10B4070", VA = "0x10B4070")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0x10B4790", Offset = "0x10B4790", VA = "0x10B4790")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010A")]
		public enum Handedness
		{
			[Token(Token = "0x400078D")]
			Right,
			[Token(Token = "0x400078E")]
			Left
		}

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE590", Offset = "0x7EE590")]
		public AimIK aimIK;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE5C8", Offset = "0x7EE5C8")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE600", Offset = "0x7EE600")]
		public Handedness handedness;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE638", Offset = "0x7EE638")]
		public bool twoHanded;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE670", Offset = "0x7EE670")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE6A8", Offset = "0x7EE6A8")]
		public float magnitudeRandom;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE6E0", Offset = "0x7EE6E0")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE718", Offset = "0x7EE718")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE750", Offset = "0x7EE750")]
		public float blendTime;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7EE788", Offset = "0x7EE788")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE788", Offset = "0x7EE788")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x17000078")]
		public bool isFinished
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x10B32D8", Offset = "0x10B32D8", VA = "0x10B32D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000079")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x10B432C", Offset = "0x10B432C", VA = "0x10B432C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x10B4370", Offset = "0x10B4370", VA = "0x10B4370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		private Transform primaryHand
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x10B42EC", Offset = "0x10B42EC", VA = "0x10B42EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x10B430C", Offset = "0x10B430C", VA = "0x10B430C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x10B3308", Offset = "0x10B3308", VA = "0x10B3308")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x10B3334", Offset = "0x10B3334", VA = "0x10B3334")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x10B35BC", Offset = "0x10B35BC", VA = "0x10B35BC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x10B43B4", Offset = "0x10B43B4", VA = "0x10B43B4")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x10B4500", Offset = "0x10B4500", VA = "0x10B4500")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x10B4540", Offset = "0x10B4540", VA = "0x10B4540", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x10B46DC", Offset = "0x10B46DC", VA = "0x10B46DC")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE7E8", Offset = "0x7EE7E8")]
		public float weight;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE820", Offset = "0x7EE820")]
		public float offset;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x10B8898", Offset = "0x10B8898", VA = "0x10B8898")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x10B8974", Offset = "0x10B8974", VA = "0x10B8974")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x10B8A64", Offset = "0x10B8A64", VA = "0x10B8A64")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x10B8EB4", Offset = "0x10B8EB4", VA = "0x10B8EB4")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x10B8EF0", Offset = "0x10B8EF0", VA = "0x10B8EF0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x10B8FEC", Offset = "0x10B8FEC", VA = "0x10B8FEC")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x200010B")]
		public class Settings
		{
			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2858", Offset = "0x7F2858")]
			public float scaleMlp;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2890", Offset = "0x7F2890")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F28C8", Offset = "0x7F28C8")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2900", Offset = "0x7F2900")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2938", Offset = "0x7F2938")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2970", Offset = "0x7F2970")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F29A8", Offset = "0x7F29A8")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F29E0", Offset = "0x7F29E0")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2A18", Offset = "0x7F2A18")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7F2A50", Offset = "0x7F2A50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2A50", Offset = "0x7F2A50")]
			public Vector3 headOffset;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2AA0", Offset = "0x7F2AA0")]
			public Vector3 handOffset;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2AD8", Offset = "0x7F2AD8")]
			public float footForwardOffset;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2B10", Offset = "0x7F2B10")]
			public float footInwardOffset;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2B48", Offset = "0x7F2B48")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F2B48", Offset = "0x7F2B48")]
			public float footHeadingOffset;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F2BA4", Offset = "0x7F2BA4")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F2BBC", Offset = "0x7F2BBC")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x10BE024", Offset = "0x10BE024", VA = "0x10BE024")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010C")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x200012B")]
			public class Target
			{
				[Token(Token = "0x4000831")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000832")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000833")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x60007D7")]
				[Address(RVA = "0x10BD0F0", Offset = "0x10BD0F0", VA = "0x10BD0F0")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x60007D8")]
				[Address(RVA = "0x10BDC14", Offset = "0x10BDC14", VA = "0x10BDC14")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000795")]
			[Address(RVA = "0x10BC58C", Offset = "0x10BC58C", VA = "0x10BC58C")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x10BB168", Offset = "0x10BB168", VA = "0x10BB168")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x10BB2D4", Offset = "0x10BB2D4", VA = "0x10BB2D4")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x10BC704", Offset = "0x10BC704", VA = "0x10BC704")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x10BD1B8", Offset = "0x10BD1B8", VA = "0x10BD1B8")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x10BDC78", Offset = "0x10BDC78", VA = "0x10BDC78")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EE858", Offset = "0x7EE858")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x1700007D")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x10BE11C", Offset = "0x10BE11C", VA = "0x10BE11C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F50E0", Offset = "0x7F50E0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x10BE128", Offset = "0x10BE128", VA = "0x10BE128")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F50F0", Offset = "0x7F50F0")]
			private set
			{
			}
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x10BE134", Offset = "0x10BE134", VA = "0x10BE134")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x10BCEC8", Offset = "0x10BCEC8", VA = "0x10BCEC8")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x10BDEB0", Offset = "0x10BDEB0", VA = "0x10BDEB0")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x10BE214", Offset = "0x10BE214", VA = "0x10BE214")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x10BE6BC", Offset = "0x10BE6BC", VA = "0x10BE6BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x10BE7B8", Offset = "0x10BE7B8", VA = "0x10BE7B8")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000081")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xF3ACF0", Offset = "0xF3ACF0", VA = "0xF3ACF0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xF3AD78", Offset = "0xF3AD78", VA = "0xF3AD78")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE868", Offset = "0x7EE868")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xF3AD80", Offset = "0xF3AD80", VA = "0xF3AD80")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xF3AE90", Offset = "0xF3AE90", VA = "0xF3AE90")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE8A0", Offset = "0x7EE8A0")]
		public AimPoser aimPoser;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE8D8", Offset = "0x7EE8D8")]
		public AimIK aim;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE910", Offset = "0x7EE910")]
		public LookAtIK lookAt;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE948", Offset = "0x7EE948")]
		public Animator animator;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE980", Offset = "0x7EE980")]
		public float crossfadeTime;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE9B8", Offset = "0x7EE9B8")]
		public float minAimDistance;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xF4D1D4", Offset = "0xF4D1D4", VA = "0xF4D1D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xF4D218", Offset = "0xF4D218", VA = "0xF4D218")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xF4D370", Offset = "0xF4D370", VA = "0xF4D370")]
		private void Pose()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xF4D580", Offset = "0xF4D580", VA = "0xF4D580")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xF4D784", Offset = "0xF4D784", VA = "0xF4D784")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xF4D85C", Offset = "0xF4D85C", VA = "0xF4D85C")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xEE52B0", Offset = "0xEE52B0", VA = "0xEE52B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xEE5528", Offset = "0xEE5528", VA = "0xEE5528")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xEE5778", Offset = "0xEE5778", VA = "0xEE5778")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EE9F0", Offset = "0x7EE9F0")]
		public Animator animator;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EEA28", Offset = "0x7EEA28")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEA60", Offset = "0x7EEA60")]
		public float lookAtWeight;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEA78", Offset = "0x7EEA78")]
		public float lookAtBodyWeight;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEA90", Offset = "0x7EEA90")]
		public float lookAtHeadWeight;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEAA8", Offset = "0x7EEAA8")]
		public float lookAtEyesWeight;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEAC0", Offset = "0x7EEAC0")]
		public float lookAtClampWeight;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEAD8", Offset = "0x7EEAD8")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEAF0", Offset = "0x7EEAF0")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EEB08", Offset = "0x7EEB08")]
		public Transform footTargetBiped;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEB40", Offset = "0x7EEB40")]
		public float footPositionWeight;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEB58", Offset = "0x7EEB58")]
		public float footRotationWeight;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EEB70", Offset = "0x7EEB70")]
		public Transform handTargetBiped;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEBA8", Offset = "0x7EEBA8")]
		public float handPositionWeight;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEBC0", Offset = "0x7EEBC0")]
		public float handRotationWeight;

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xF3CA4C", Offset = "0xF3CA4C", VA = "0xF3CA4C")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xF3CF00", Offset = "0xF3CF00", VA = "0xF3CF00")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xF46F04", Offset = "0xF46F04", VA = "0xF46F04")]
		private void Update()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xF47948", Offset = "0xF47948", VA = "0xF47948")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xF4762C", Offset = "0xF4762C", VA = "0xF4762C")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xF47AFC", Offset = "0xF47AFC", VA = "0xF47AFC")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x1700007E")]
		public Vector3 inputVector
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0xF47B28", Offset = "0xF47B28", VA = "0xF47B28")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xF47BC8", Offset = "0xF47BC8", VA = "0xF47BC8")]
		private void Update()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xF47E68", Offset = "0xF47E68", VA = "0xF47E68")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EAE30", Offset = "0x7EAE30")]
		private sealed class <Step>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000D7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000799")]
				[Address(RVA = "0xF48B94", Offset = "0xF48B94", VA = "0xF48B94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600079B")]
				[Address(RVA = "0xF48C00", Offset = "0xF48C00", VA = "0xF48C00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0xF48820", Offset = "0xF48820", VA = "0xF48820")]
			[DebuggerHidden]
			public <Step>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0xF4887C", Offset = "0xF4887C", VA = "0xF4887C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0xF48880", Offset = "0xF48880", VA = "0xF48880", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0xF48B9C", Offset = "0xF48B9C", VA = "0xF48B9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem sand;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IK ik;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float stepProgress;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastStepTime;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit hit;

		[Token(Token = "0x1700007F")]
		public bool isStepping
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0xF47E7C", Offset = "0xF47E7C", VA = "0xF47E7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000080")]
		public Vector3 position
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0xF47AC8", Offset = "0xF47AC8", VA = "0xF47AC8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600050D")]
			[Address(RVA = "0xF47E90", Offset = "0xF47E90", VA = "0xF47E90")]
			set
			{
			}
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xF47EE0", Offset = "0xF47EE0", VA = "0xF47EE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xF47F38", Offset = "0xF47F38", VA = "0xF47F38")]
		private void Start()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xF480F0", Offset = "0xF480F0", VA = "0xF480F0")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xF484D4", Offset = "0xF484D4", VA = "0xF484D4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xF485F4", Offset = "0xF485F4", VA = "0xF485F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xF48544", Offset = "0xF48544", VA = "0xF48544")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F5100", Offset = "0x7F5100")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xF4884C", Offset = "0xF4884C", VA = "0xF4884C")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xF48C08", Offset = "0xF48C08", VA = "0xF48C08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xF48CB4", Offset = "0xF48CB4", VA = "0xF48CB4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xF48F4C", Offset = "0xF48F4C", VA = "0xF48F4C")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010E")]
		public struct Warp
		{
			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2BD4", Offset = "0x7F2BD4")]
			public int animationLayer;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2C0C", Offset = "0x7F2C0C")]
			public string animationState;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2C44", Offset = "0x7F2C44")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2C7C", Offset = "0x7F2C7C")]
			public Transform warpFrom;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2CB4", Offset = "0x7F2CB4")]
			public Transform warpTo;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2CEC", Offset = "0x7F2CEC")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x200010F")]
		public enum EffectorMode
		{
			[Token(Token = "0x40007B7")]
			PositionOffset,
			[Token(Token = "0x40007B8")]
			Position
		}

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEBD8", Offset = "0x7EEBD8")]
		public Animator animator;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEC10", Offset = "0x7EEC10")]
		public EffectorMode effectorMode;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7EEC48", Offset = "0x7EEC48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEC48", Offset = "0x7EEC48")]
		public Warp[] warps;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xF3AF08", Offset = "0xF3AF08", VA = "0xF3AF08", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xF3AF34", Offset = "0xF3AF34", VA = "0xF3AF34")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xF3B148", Offset = "0xF3B148", VA = "0xF3B148", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xF3B504", Offset = "0xF3B504", VA = "0xF3B504")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xF3B5A8", Offset = "0xF3B5A8", VA = "0xF3B5A8")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EA844", Offset = "0x7EA844")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xF3B5B0", Offset = "0xF3B5B0", VA = "0xF3B5B0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xF3B608", Offset = "0xF3B608", VA = "0xF3B608")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xF3B848", Offset = "0xF3B848", VA = "0xF3B848", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xF3BAB4", Offset = "0xF3BAB4", VA = "0xF3BAB4")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EA8A8", Offset = "0x7EA8A8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EA8A8", Offset = "0x7EA8A8")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEC98", Offset = "0x7EEC98")]
		public float headLookWeight;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xF3BAC8", Offset = "0xF3BAC8", VA = "0xF3BAC8", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xF3BC3C", Offset = "0xF3BC3C", VA = "0xF3BC3C", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xF3BCB0", Offset = "0xF3BCB0", VA = "0xF3BCB0")]
		private void Read()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xF3BE0C", Offset = "0xF3BE0C", VA = "0xF3BE0C")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xF3BE58", Offset = "0xF3BE58", VA = "0xF3BE58")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xF3C458", Offset = "0xF3C458", VA = "0xF3C458")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xF3C218", Offset = "0xF3C218", VA = "0xF3C218")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xF3C7B4", Offset = "0xF3C7B4", VA = "0xF3C7B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xF3C8B0", Offset = "0xF3C8B0", VA = "0xF3C8B0")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EA934", Offset = "0x7EA934")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xF3DF70", Offset = "0xF3DF70", VA = "0xF3DF70", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xF3DFD0", Offset = "0xF3DFD0", VA = "0xF3DFD0", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xF3E29C", Offset = "0xF3E29C", VA = "0xF3E29C")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xF3E45C", Offset = "0xF3E45C", VA = "0xF3E45C")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EA998", Offset = "0x7EA998")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000081")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0xF3F2B0", Offset = "0xF3F2B0", VA = "0xF3F2B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000082")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0xF3F350", Offset = "0xF3F350", VA = "0xF3F350")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xF3EFF0", Offset = "0xF3EFF0", VA = "0xF3EFF0")]
		private void Start()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xF3F064", Offset = "0xF3F064", VA = "0xF3F064")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xF3F3F0", Offset = "0xF3F3F0", VA = "0xF3F3F0")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EECC0", Offset = "0x7EECC0")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xF41AE4", Offset = "0xF41AE4", VA = "0xF41AE4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xF420D0", Offset = "0xF420D0", VA = "0xF420D0")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xF420D8", Offset = "0xF420D8", VA = "0xF420D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xF42180", Offset = "0xF42180", VA = "0xF42180")]
		private void Update()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xF42600", Offset = "0xF42600", VA = "0xF42600")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xF426B0", Offset = "0xF426B0", VA = "0xF426B0")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000110")]
		public class Limb
		{
			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x600079C")]
			[Address(RVA = "0xF4288C", Offset = "0xF4288C", VA = "0xF4288C")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0xF429C8", Offset = "0xF429C8", VA = "0xF429C8")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xF42738", Offset = "0xF42738", VA = "0xF42738")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xF42918", Offset = "0xF42918", VA = "0xF42918")]
		private void Start()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xF429B4", Offset = "0xF429B4", VA = "0xF429B4")]
		private void Update()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xF429B8", Offset = "0xF429B8", VA = "0xF429B8")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xF429D8", Offset = "0xF429D8", VA = "0xF429D8")]
		private void Start()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xF42A44", Offset = "0xF42A44", VA = "0xF42A44")]
		private void Update()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xF42B20", Offset = "0xF42B20", VA = "0xF42B20")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EECD8", Offset = "0x7EECD8")]
		public Transform target;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EED10", Offset = "0x7EED10")]
		public Transform pin;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EED48", Offset = "0x7EED48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EED80", Offset = "0x7EED80")]
		public AimIK aim;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEDB8", Offset = "0x7EEDB8")]
		public float weight;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEDF0", Offset = "0x7EEDF0")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEE28", Offset = "0x7EEE28")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xF42B28", Offset = "0xF42B28", VA = "0xF42B28")]
		private void Start()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xF42B80", Offset = "0xF42B80", VA = "0xF42B80")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xF42D24", Offset = "0xF42D24", VA = "0xF42D24")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xF42D2C", Offset = "0xF42D2C", VA = "0xF42D2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xF42DF0", Offset = "0xF42DF0", VA = "0xF42DF0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xF42E84", Offset = "0xF42E84", VA = "0xF42E84")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xF433A0", Offset = "0xF433A0", VA = "0xF433A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xF4349C", Offset = "0xF4349C", VA = "0xF4349C")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEE60", Offset = "0x7EEE60")]
		public float aimWeight;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEE78", Offset = "0x7EEE78")]
		public float sightWeight;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEE90", Offset = "0x7EEE90")]
		public float maxAngle;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEF1C", Offset = "0x7EEF1C")]
		private float cameraRecoilWeight;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool updateFrame;

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xF434A4", Offset = "0xF434A4", VA = "0xF434A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xF4360C", Offset = "0xF4360C", VA = "0xF4360C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xF43618", Offset = "0xF43618", VA = "0xF43618")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xF43964", Offset = "0xF43964", VA = "0xF43964")]
		private void Aiming()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xF43BD4", Offset = "0xF43BD4", VA = "0xF43BD4")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xF436E4", Offset = "0xF436E4", VA = "0xF436E4")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xF445F4", Offset = "0xF445F4", VA = "0xF445F4")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EA9FC", Offset = "0x7EA9FC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EA9FC", Offset = "0x7EA9FC")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEF5C", Offset = "0x7EEF5C")]
		public float walkSpeed;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xF44614", Offset = "0xF44614", VA = "0xF44614")]
		private void Start()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xF44684", Offset = "0xF44684", VA = "0xF44684")]
		private void Update()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xF447AC", Offset = "0xF447AC", VA = "0xF447AC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xF4485C", Offset = "0xF4485C", VA = "0xF4485C")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xF44BF8", Offset = "0xF44BF8", VA = "0xF44BF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xF44DC4", Offset = "0xF44DC4", VA = "0xF44DC4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xF44F88", Offset = "0xF44F88", VA = "0xF44F88")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xF45338", Offset = "0xF45338", VA = "0xF45338")]
		private void Start()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xF454E8", Offset = "0xF454E8", VA = "0xF454E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xF458A8", Offset = "0xF458A8", VA = "0xF458A8")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xF458B8", Offset = "0xF458B8", VA = "0xF458B8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xF459EC", Offset = "0xF459EC", VA = "0xF459EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xF45B40", Offset = "0xF45B40", VA = "0xF45B40")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xF45B48", Offset = "0xF45B48", VA = "0xF45B48")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xF46218", Offset = "0xF46218", VA = "0xF46218")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EAA88", Offset = "0x7EAA88")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEF94", Offset = "0x7EEF94")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEFE0", Offset = "0x7EEFE0")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xF46220", Offset = "0xF46220", VA = "0xF46220")]
		private void Awake()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xF46278", Offset = "0xF46278", VA = "0xF46278")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xF4658C", Offset = "0xF4658C", VA = "0xF4658C")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000111")]
		public class Partner
		{
			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000D9")]
			private Transform neck
			{
				[Token(Token = "0x60007A0")]
				[Address(RVA = "0xF46E90", Offset = "0xF46E90", VA = "0xF46E90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0xF465C8", Offset = "0xF465C8", VA = "0xF465C8")]
			public void Initiate()
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0xF46648", Offset = "0xF46648", VA = "0xF46648")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0xF46CAC", Offset = "0xF46CAC", VA = "0xF46CAC")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0xF46EF0", Offset = "0xF46EF0", VA = "0xF46EF0")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xF46594", Offset = "0xF46594", VA = "0xF46594")]
		private void Start()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xF465E8", Offset = "0xF465E8", VA = "0xF465E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xF46C9C", Offset = "0xF46C9C", VA = "0xF46C9C")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000112")]
		public enum Mode
		{
			[Token(Token = "0x40007C8")]
			Position,
			[Token(Token = "0x40007C9")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x2000113")]
		public class Absorber
		{
			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2D24", Offset = "0x7F2D24")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2D5C", Offset = "0x7F2D5C")]
			public float weight;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0xF490BC", Offset = "0xF490BC", VA = "0xF490BC")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0xF492A4", Offset = "0xF492A4", VA = "0xF492A4")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0xF492E4", Offset = "0xF492E4", VA = "0xF492E4")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0xF494A4", Offset = "0xF494A4", VA = "0xF494A4")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0xF496D0", Offset = "0xF496D0", VA = "0xF496D0")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF02C", Offset = "0x7EF02C")]
		public Mode mode;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF064", Offset = "0x7EF064")]
		public Absorber[] absorbers;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF09C", Offset = "0x7EF09C")]
		public AnimationCurve falloff;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF0D4", Offset = "0x7EF0D4")]
		public float falloffSpeed;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xF48F54", Offset = "0xF48F54", VA = "0xF48F54", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xF4902C", Offset = "0xF4902C", VA = "0xF4902C")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xF49194", Offset = "0xF49194", VA = "0xF49194", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xF49414", Offset = "0xF49414", VA = "0xF49414")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xF495B8", Offset = "0xF495B8", VA = "0xF495B8", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xF496C0", Offset = "0xF496C0", VA = "0xF496C0")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xF49750", Offset = "0xF49750", VA = "0xF49750")]
		private void Start()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xF497C8", Offset = "0xF497C8", VA = "0xF497C8")]
		private void Update()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xF49884", Offset = "0xF49884", VA = "0xF49884")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xF499E8", Offset = "0xF499E8", VA = "0xF499E8")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000114")]
		public class EffectorLink
		{
			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0xF4A770", Offset = "0xF4A770", VA = "0xF4A770")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xF4A42C", Offset = "0xF4A42C", VA = "0xF4A42C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xF4A534", Offset = "0xF4A534", VA = "0xF4A534", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xF4A768", Offset = "0xF4A768", VA = "0xF4A768")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EAAEC", Offset = "0x7EAAEC")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF10C", Offset = "0x7EF10C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EF10C", Offset = "0x7EF10C")]
		public float weight;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF160", Offset = "0x7EF160")]
		public float hangingDistanceMlp;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF198", Offset = "0x7EF198")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF1E4", Offset = "0x7EF1E4")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xF4A780", Offset = "0xF4A780", VA = "0xF4A780")]
		private void Start()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xF4AAC8", Offset = "0xF4AAC8", VA = "0xF4AAC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xF4B224", Offset = "0xF4B224", VA = "0xF4B224")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000083")]
		private bool holding
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0xF4B570", Offset = "0xF4B570", VA = "0xF4B570")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xF4B2AC", Offset = "0xF4B2AC", VA = "0xF4B2AC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000575")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xF4B590", Offset = "0xF4B590", VA = "0xF4B590")]
		private void Start()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xF4B700", Offset = "0xF4B700", VA = "0xF4B700")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xF4B884", Offset = "0xF4B884", VA = "0xF4B884")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xF4B96C", Offset = "0xF4B96C", VA = "0xF4B96C")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xF4BA98", Offset = "0xF4BA98", VA = "0xF4BA98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xF4BCB4", Offset = "0xF4BCB4", VA = "0xF4BCB4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xF4BE5C", Offset = "0xF4BE5C", VA = "0xF4BE5C")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600057E")]
		[Address(RVA = "0xF4BE70", Offset = "0xF4BE70", VA = "0xF4BE70", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xF4C06C", Offset = "0xF4C06C", VA = "0xF4C06C")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000580")]
		[Address(RVA = "0xF4C080", Offset = "0xF4C080", VA = "0xF4C080", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xF4C230", Offset = "0xF4C230", VA = "0xF4C230")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xF4C9C4", Offset = "0xF4C9C4", VA = "0xF4C9C4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xF4CA9C", Offset = "0xF4CA9C", VA = "0xF4CA9C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xF4CC50", Offset = "0xF4CC50", VA = "0xF4CC50")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EAB50", Offset = "0x7EAB50")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xF4CC58", Offset = "0xF4CC58", VA = "0xF4CC58")]
		private void Start()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xF4CCB0", Offset = "0xF4CCB0", VA = "0xF4CCB0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xF4CD0C", Offset = "0xF4CD0C", VA = "0xF4CD0C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xF4CDE4", Offset = "0xF4CDE4", VA = "0xF4CDE4")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000115")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EAE40", Offset = "0x7EAE40")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000DA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007AC")]
				[Address(RVA = "0xF4D160", Offset = "0xF4D160", VA = "0xF4D160", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007AE")]
				[Address(RVA = "0xF4D1CC", Offset = "0xF4D1CC", VA = "0xF4D1CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0xF4CF78", Offset = "0xF4CF78", VA = "0xF4CF78")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0xF4CFB4", Offset = "0xF4CFB4", VA = "0xF4CFB4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0xF4CFB8", Offset = "0xF4CFB8", VA = "0xF4CFB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0xF4D168", Offset = "0xF4D168", VA = "0xF4D168", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xF4CDF4", Offset = "0xF4CDF4", VA = "0xF4CDF4")]
		private void Start()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xF4CEAC", Offset = "0xF4CEAC", VA = "0xF4CEAC")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xF4CEF4", Offset = "0xF4CEF4", VA = "0xF4CEF4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F5164", Offset = "0x7F5164")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xF4CFA4", Offset = "0xF4CFA4", VA = "0xF4CFA4")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EABB4", Offset = "0x7EABB4")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EAE50", Offset = "0x7EAE50")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000DC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007B2")]
				[Address(RVA = "0xEE523C", Offset = "0xEE523C", VA = "0xEE523C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007B4")]
				[Address(RVA = "0xEE52A8", Offset = "0xEE52A8", VA = "0xEE52A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0xEE50E0", Offset = "0xEE50E0", VA = "0xEE50E0")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0xEE5114", Offset = "0xEE5114", VA = "0xEE5114", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xEE5118", Offset = "0xEE5118", VA = "0xEE5118", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xEE5244", Offset = "0xEE5244", VA = "0xEE5244", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xEE4FBC", Offset = "0xEE4FBC", VA = "0xEE4FBC")]
		private void Start()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xEE506C", Offset = "0xEE506C", VA = "0xEE506C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F51C8", Offset = "0x7F51C8")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xEE510C", Offset = "0xEE510C", VA = "0xEE510C")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000117")]
		public class EffectorLink
		{
			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0xEE5870", Offset = "0xEE5870", VA = "0xEE5870")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0xEE6524", Offset = "0xEE6524", VA = "0xEE6524")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0xEE5BC4", Offset = "0xEE5BC4", VA = "0xEE5BC4")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0xEE660C", Offset = "0xEE660C", VA = "0xEE660C")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0xEE67B0", Offset = "0xEE67B0", VA = "0xEE67B0")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0xEE684C", Offset = "0xEE684C", VA = "0xEE684C")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0xEE68E4", Offset = "0xEE68E4", VA = "0xEE68E4")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0xEE63B4", Offset = "0xEE63B4", VA = "0xEE63B4")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0xEE697C", Offset = "0xEE697C", VA = "0xEE697C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xEE57EC", Offset = "0xEE57EC", VA = "0xEE57EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xEE5B50", Offset = "0xEE5B50", VA = "0xEE5B50")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xEE62E4", Offset = "0xEE62E4", VA = "0xEE62E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xEE651C", Offset = "0xEE651C", VA = "0xEE651C")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF2D0", Offset = "0x7EF2D0")]
		public Transform to;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF308", Offset = "0x7EF308")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EF308", Offset = "0x7EF308")]
		public float transferMotion;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xEE69BC", Offset = "0xEE69BC", VA = "0xEE69BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xEE69F8", Offset = "0xEE69F8", VA = "0xEE69F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xEE6B58", Offset = "0xEE6B58", VA = "0xEE6B58")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF35C", Offset = "0x7EF35C")]
		public Transform leftHandTarget;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xEE6D28", Offset = "0xEE6D28", VA = "0xEE6D28")]
		private void Start()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xEE6EE8", Offset = "0xEE6EE8", VA = "0xEE6EE8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xEE7188", Offset = "0xEE7188", VA = "0xEE7188")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xEE7258", Offset = "0xEE7258", VA = "0xEE7258")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xEE7354", Offset = "0xEE7354", VA = "0xEE7354")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xEE76CC", Offset = "0xEE76CC", VA = "0xEE76CC", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xEE7B3C", Offset = "0xEE7B3C", VA = "0xEE7B3C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xEE7D98", Offset = "0xEE7D98", VA = "0xEE7D98")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xF4486C", Offset = "0xF4486C", VA = "0xF4486C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xF44B68", Offset = "0xF44B68", VA = "0xF44B68")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xF44BF0", Offset = "0xF44BF0", VA = "0xF44BF0")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EAE60", Offset = "0x7EAE60")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007C1")]
				[Address(RVA = "0xF4C950", Offset = "0xF4C950", VA = "0xF4C950", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007C3")]
				[Address(RVA = "0xF4C9BC", Offset = "0xF4C9BC", VA = "0xF4C9BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0xF4C600", Offset = "0xF4C600", VA = "0xF4C600")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0xF4C814", Offset = "0xF4C814", VA = "0xF4C814", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0xF4C818", Offset = "0xF4C818", VA = "0xF4C818", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0xF4C958", Offset = "0xF4C958", VA = "0xF4C958", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xF4C244", Offset = "0xF4C244", VA = "0xF4C244")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xF4C3D4", Offset = "0xF4C3D4", VA = "0xF4C3D4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xF4C360", Offset = "0xF4C360", VA = "0xF4C360")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F522C", Offset = "0x7F522C")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xF4C62C", Offset = "0xF4C62C", VA = "0xF4C62C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xF4C714", Offset = "0xF4C714", VA = "0xF4C714")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xF4C7F8", Offset = "0xF4C7F8", VA = "0xF4C7F8")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EF3C4", Offset = "0x7EF3C4")]
		public float weight;

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xF3C910", Offset = "0xF3C910", VA = "0xF3C910")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xF3C97C", Offset = "0xF3C97C", VA = "0xF3C97C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xF3CA3C", Offset = "0xF3CA3C", VA = "0xF3CA3C")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000119")]
		public class Part
		{
			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0xEE6BF0", Offset = "0xEE6BF0", VA = "0xEE6BF0")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0xEE6D20", Offset = "0xEE6D20", VA = "0xEE6D20")]
			public Part()
			{
			}
		}

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xEE6B6C", Offset = "0xEE6B6C", VA = "0xEE6B6C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xEE6D18", Offset = "0xEE6D18", VA = "0xEE6D18")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xF44F98", Offset = "0xF44F98", VA = "0xF44F98")]
		private void Update()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xF45164", Offset = "0xF45164", VA = "0xF45164")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xF45328", Offset = "0xF45328", VA = "0xF45328")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF3FC", Offset = "0x7EF3FC")]
		public VRIK ik;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF434", Offset = "0x7EF434")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF46C", Offset = "0x7EF46C")]
		public Transform headTracker;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF4A4", Offset = "0x7EF4A4")]
		public Transform bodyTracker;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF4DC", Offset = "0x7EF4DC")]
		public Transform leftHandTracker;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF514", Offset = "0x7EF514")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF54C", Offset = "0x7EF54C")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF584", Offset = "0x7EF584")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EF5BC", Offset = "0x7EF5BC")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xEE7DBC", Offset = "0xEE7DBC", VA = "0xEE7DBC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xEE7F1C", Offset = "0xEE7F1C", VA = "0xEE7F1C")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xEE7F84", Offset = "0xEE7F84", VA = "0xEE7F84")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xEE7FE0", Offset = "0xEE7FE0", VA = "0xEE7FE0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xEE81F8", Offset = "0xEE81F8", VA = "0xEE81F8")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xEE8270", Offset = "0xEE8270", VA = "0xEE8270")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xEE87C8", Offset = "0xEE87C8", VA = "0xEE87C8")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x17000084")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0xF3CF44", Offset = "0xF3CF44", VA = "0xF3CF44", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xF3CF20", Offset = "0xF3CF20", VA = "0xF3CF20", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xF3CF4C", Offset = "0xF3CF4C", VA = "0xF3CF4C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xF3D010", Offset = "0xF3D010", VA = "0xF3D010", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xF3D270", Offset = "0xF3D270", VA = "0xF3D270", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xF3D4E8", Offset = "0xF3D4E8", VA = "0xF3D4E8", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xF3D280", Offset = "0xF3D280", VA = "0xF3D280")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xF3D4F8", Offset = "0xF3D4F8", VA = "0xF3D4F8")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EAC18", Offset = "0x7EAC18")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xF3D510", Offset = "0xF3D510", VA = "0xF3D510", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xF3D570", Offset = "0xF3D570", VA = "0xF3D570", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xF3D6A8", Offset = "0xF3D6A8", VA = "0xF3D6A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xF3D82C", Offset = "0xF3D82C", VA = "0xF3D82C")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EAC7C", Offset = "0x7EAC7C")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EF654", Offset = "0x7EF654")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x400051F")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000520")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x17000085")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xF3D8E4", Offset = "0xF3D8E4", VA = "0xF3D8E4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xF3D844", Offset = "0xF3D844", VA = "0xF3D844", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xF3D8C8", Offset = "0xF3D8C8", VA = "0xF3D8C8", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xF3D9D4", Offset = "0xF3D9D4", VA = "0xF3D9D4", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xF3DD90", Offset = "0xF3DD90", VA = "0xF3DD90")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xF3DF4C", Offset = "0xF3DF4C", VA = "0xF3DF4C")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EACE0", Offset = "0x7EACE0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EACE0", Offset = "0x7EACE0")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EF698", Offset = "0x7EF698")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF698", Offset = "0x7EF698")]
		public Transform gravityTarget;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF6F8", Offset = "0x7EF6F8")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x400052C")]
		protected const float half = 0.5f;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60005C9")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xF3E480", Offset = "0xF3E480", VA = "0xF3E480")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xF3E604", Offset = "0xF3E604", VA = "0xF3E604", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xF3E7A0", Offset = "0xF3E7A0", VA = "0xF3E7A0", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xF3EA18", Offset = "0xF3EA18", VA = "0xF3EA18")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xF3EADC", Offset = "0xF3EADC", VA = "0xF3EADC")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xF3ECCC", Offset = "0xF3ECCC", VA = "0xF3ECCC")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xF3EE84", Offset = "0xF3EE84", VA = "0xF3EE84")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xF3EEA8", Offset = "0xF3EEA8", VA = "0xF3EEA8")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xF3EECC", Offset = "0xF3EECC", VA = "0xF3EECC")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xF3EFD0", Offset = "0xF3EFD0", VA = "0xF3EFD0")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x200011A")]
		public enum MoveMode
		{
			[Token(Token = "0x40007F3")]
			Directional,
			[Token(Token = "0x40007F4")]
			Strafe
		}

		[Token(Token = "0x200011B")]
		public struct AnimState
		{
			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EF794", Offset = "0x7EF794")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EF7CC", Offset = "0x7EF7CC")]
		public MoveMode moveMode;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EF804", Offset = "0x7EF804")]
		public bool lookInCameraDirection;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EF83C", Offset = "0x7EF83C")]
		public float airSpeed;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EF874", Offset = "0x7EF874")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMaxLength;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EF8C0", Offset = "0x7EF8C0")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EF8F8", Offset = "0x7EF8F8")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AnimState animState;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected Vector3 moveDirection;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool fixedFrame;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float wallRunEndTime;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private Vector3 gravity;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float velocityY;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool doubleJumped;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		private bool jumpReleased;

		[Token(Token = "0x17000086")]
		public bool onGround
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0xF3F3F8", Offset = "0xF3F3F8", VA = "0xF3F3F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5290", Offset = "0x7F5290")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0xF3F400", Offset = "0xF3F400", VA = "0xF3F400")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F52A0", Offset = "0x7F52A0")]
			private set
			{
			}
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xF3F40C", Offset = "0xF3F40C", VA = "0xF3F40C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xF3F590", Offset = "0xF3F590", VA = "0xF3F590")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xF3F620", Offset = "0xF3F620", VA = "0xF3F620", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xF3F75C", Offset = "0xF3F75C", VA = "0xF3F75C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xF406B4", Offset = "0xF406B4", VA = "0xF406B4", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xF40A54", Offset = "0xF40A54", VA = "0xF40A54", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xF3FD70", Offset = "0xF3FD70", VA = "0xF3FD70")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xF40B3C", Offset = "0xF40B3C", VA = "0xF40B3C")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xF41134", Offset = "0xF41134", VA = "0xF41134")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xF40794", Offset = "0xF40794", VA = "0xF40794")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xF411D8", Offset = "0xF411D8", VA = "0xF411D8", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xF41658", Offset = "0xF41658", VA = "0xF41658")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xF41818", Offset = "0xF41818", VA = "0xF41818", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xF40288", Offset = "0xF40288", VA = "0xF40288")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xF419BC", Offset = "0xF419BC", VA = "0xF419BC")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x7EAD6C", Offset = "0x7EAD6C")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011C")]
		public enum RotationMode
		{
			[Token(Token = "0x40007FD")]
			Smooth,
			[Token(Token = "0x40007FE")]
			Linear
		}

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF908", Offset = "0x7EF908")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF954", Offset = "0x7EF954")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF9A0", Offset = "0x7EF9A0")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF9EC", Offset = "0x7EF9EC")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFA38", Offset = "0x7EFA38")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFA84", Offset = "0x7EFA84")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EFAD0", Offset = "0x7EFAD0")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x17000087")]
		public bool isGrounded
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xF4D874", Offset = "0xF4D874", VA = "0xF4D874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F52B0", Offset = "0x7F52B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xF4D87C", Offset = "0xF4D87C", VA = "0xF4D87C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F52C0", Offset = "0x7F52C0")]
			private set
			{
			}
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xF4D888", Offset = "0xF4D888", VA = "0xF4D888")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xF4D914", Offset = "0xF4D914", VA = "0xF4D914")]
		private void Update()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xF4E018", Offset = "0xF4E018", VA = "0xF4E018")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xF4D968", Offset = "0xF4D968", VA = "0xF4D968")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xF4DD6C", Offset = "0xF4DD6C", VA = "0xF4DD6C")]
		private void Move()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xF4E060", Offset = "0xF4E060", VA = "0xF4E060")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xF4E158", Offset = "0xF4E158", VA = "0xF4E158")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xF4E1F8", Offset = "0xF4E1F8", VA = "0xF4E1F8")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xEE735C", Offset = "0xEE735C", VA = "0xEE735C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xEE73DC", Offset = "0xEE73DC", VA = "0xEE73DC", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xEE7678", Offset = "0xEE7678", VA = "0xEE7678")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xEE76A0", Offset = "0xEE76A0", VA = "0xEE76A0")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x200011D")]
		public struct State
		{
			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xEE73A4", Offset = "0xEE73A4", VA = "0xEE73A4", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xEE77E0", Offset = "0xEE77E0", VA = "0xEE77E0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xEE76BC", Offset = "0xEE76BC", VA = "0xEE76BC")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xF3C8CC", Offset = "0xF3C8CC", VA = "0xF3C8CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xF3C908", Offset = "0xF3C908", VA = "0xF3C908")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xEE4EC0", Offset = "0xEE4EC0", VA = "0xEE4EC0")]
		private void Update()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xEE4EF4", Offset = "0xEE4EF4", VA = "0xEE4EF4")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xEE4FA8", Offset = "0xEE4FA8", VA = "0xEE4FA8")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BE")]
	public class Navigator
	{
		[Token(Token = "0x200011E")]
		public enum State
		{
			[Token(Token = "0x4000805")]
			Idle,
			[Token(Token = "0x4000806")]
			Seeking,
			[Token(Token = "0x4000807")]
			OnPath
		}

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFB20", Offset = "0x7EFB20")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFB58", Offset = "0x7EFB58")]
		public float cornerRadius;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFB90", Offset = "0x7EFB90")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFBC8", Offset = "0x7EFBC8")]
		public float maxSampleDistance;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFC00", Offset = "0x7EFC00")]
		public float nextPathInterval;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EFC38", Offset = "0x7EFC38")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EFC48", Offset = "0x7EFC48")]
		private State <state>k__BackingField;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x17000088")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0xF499FC", Offset = "0xF499FC", VA = "0xF499FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F52D0", Offset = "0x7F52D0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0xF49A08", Offset = "0xF49A08", VA = "0xF49A08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F52E0", Offset = "0x7F52E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public State state
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0xF49A14", Offset = "0xF49A14", VA = "0xF49A14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F52F0", Offset = "0x7F52F0")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xF49A1C", Offset = "0xF49A1C", VA = "0xF49A1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5300", Offset = "0x7F5300")]
			private set
			{
			}
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xF49A24", Offset = "0xF49A24", VA = "0xF49A24")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xF49AF8", Offset = "0xF49AF8", VA = "0xF49AF8")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xF4A04C", Offset = "0xF4A04C", VA = "0xF4A04C")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xF4A0BC", Offset = "0xF4A0BC", VA = "0xF4A0BC")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xF49F14", Offset = "0xF49F14", VA = "0xF49F14")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xF49F88", Offset = "0xF49F88", VA = "0xF49F88")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xF4A204", Offset = "0xF4A204", VA = "0xF4A204")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xF4A3C0", Offset = "0xF4A3C0", VA = "0xF4A3C0")]
		public Navigator()
		{
		}
	}
}
