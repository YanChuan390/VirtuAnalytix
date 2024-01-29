using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000002")]
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x14682E8", Offset = "0x14682E8", VA = "0x14682E8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1468560", Offset = "0x1468560", VA = "0x1468560")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x2000003")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x633AE8", Offset = "0x633AE8")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1205914", Offset = "0x1205914", VA = "0x1205914")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1205938", Offset = "0x1205938", VA = "0x1205938")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1205998", Offset = "0x1205998", VA = "0x1205998")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x12059F8", Offset = "0x12059F8", VA = "0x12059F8")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x633B5C", Offset = "0x633B5C")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x1205A00", Offset = "0x1205A00", VA = "0x1205A00")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class MeshContainer
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1205A08", Offset = "0x1205A08", VA = "0x1205A08")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1205A7C", Offset = "0x1205A7C", VA = "0x1205A7C")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000006")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x633BD0", Offset = "0x633BD0")]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1205AE0", Offset = "0x1205AE0", VA = "0x1205AE0")]
		public void Start()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1205C90", Offset = "0x1205C90", VA = "0x1205C90")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1206050", Offset = "0x1206050", VA = "0x1206050")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1206174", Offset = "0x1206174", VA = "0x1206174")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1206294", Offset = "0x1206294", VA = "0x1206294")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1206EE8", Offset = "0x1206EE8", VA = "0x1206EE8")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1206F48", Offset = "0x1206F48", VA = "0x1206F48")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1207050", Offset = "0x1207050", VA = "0x1207050")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x12070B0", Offset = "0x12070B0", VA = "0x12070B0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1206424", Offset = "0x1206424", VA = "0x1206424")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1207110", Offset = "0x1207110", VA = "0x1207110")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x12076A0", Offset = "0x12076A0", VA = "0x12076A0")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x12071F4", Offset = "0x12071F4", VA = "0x12071F4")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x12078E8", Offset = "0x12078E8", VA = "0x12078E8")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x12074B8", Offset = "0x12074B8", VA = "0x12074B8")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1207908", Offset = "0x1207908", VA = "0x1207908")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x633C44", Offset = "0x633C44")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x120797C", Offset = "0x120797C", VA = "0x120797C")]
		public void Start()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1207AB4", Offset = "0x1207AB4", VA = "0x1207AB4")]
		public void Update()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1207D6C", Offset = "0x1207D6C", VA = "0x1207D6C")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x2000008")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x200003B")]
		public enum WaterMode
		{
			[Token(Token = "0x40001E3")]
			Simple,
			[Token(Token = "0x40001E4")]
			Reflective,
			[Token(Token = "0x40001E5")]
			Refractive
		}

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1207D74", Offset = "0x1207D74", VA = "0x1207D74")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1209F18", Offset = "0x1209F18", VA = "0x1209F18")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x120A2C4", Offset = "0x120A2C4", VA = "0x120A2C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x12096B8", Offset = "0x12096B8", VA = "0x12096B8")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1208934", Offset = "0x1208934", VA = "0x1208934")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1208920", Offset = "0x1208920", VA = "0x1208920")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x12087BC", Offset = "0x12087BC", VA = "0x12087BC")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1209D30", Offset = "0x1209D30", VA = "0x1209D30")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1209A8C", Offset = "0x1209A8C", VA = "0x1209A8C")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x120A5A4", Offset = "0x120A5A4", VA = "0x120A5A4")]
		public Water()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public enum WaterQuality
	{
		[Token(Token = "0x400001E")]
		High = 2,
		[Token(Token = "0x400001F")]
		Medium = 1,
		[Token(Token = "0x4000020")]
		Low = 0
	}
	[Token(Token = "0x200000A")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1467F94", Offset = "0x1467F94", VA = "0x1467F94")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1468174", Offset = "0x1468174", VA = "0x1468174")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x146824C", Offset = "0x146824C", VA = "0x146824C")]
		public void Update()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x14682D0", Offset = "0x14682D0", VA = "0x14682D0")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x200000B")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1468568", Offset = "0x1468568", VA = "0x1468568")]
		public void Start()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x146856C", Offset = "0x146856C", VA = "0x146856C")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1468764", Offset = "0x1468764", VA = "0x1468764")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1468898", Offset = "0x1468898", VA = "0x1468898")]
		public WaterTile()
		{
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x200000C")]
	public enum AAMode
	{
		[Token(Token = "0x4000027")]
		FXAA2,
		[Token(Token = "0x4000028")]
		FXAA3Console,
		[Token(Token = "0x4000029")]
		FXAA1PresetA,
		[Token(Token = "0x400002A")]
		FXAA1PresetB,
		[Token(Token = "0x400002B")]
		NFAA,
		[Token(Token = "0x400002C")]
		SSAA,
		[Token(Token = "0x400002D")]
		DLAA
	}
	[Token(Token = "0x200000D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x633CE8", Offset = "0x633CE8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x633CE8", Offset = "0x633CE8")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x28")]
		public AAMode mode;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x30")]
		public float offsetScale;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x34")]
		public float blurRadius;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x50")]
		private Material ssaa;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x60")]
		private Material dlaa;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x70")]
		private Material nfaa;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x11EBE84", Offset = "0x11EBE84", VA = "0x11EBE84")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x11EBEE8", Offset = "0x11EBEE8", VA = "0x11EBEE8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x11EC3D4", Offset = "0x11EC3D4", VA = "0x11EC3D4")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x11EC9D4", Offset = "0x11EC9D4", VA = "0x11EC9D4")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x633D80", Offset = "0x633D80")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x633D80", Offset = "0x633D80")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x200003C")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x40001E7")]
			Ghosting,
			[Token(Token = "0x40001E8")]
			Anamorphic,
			[Token(Token = "0x40001E9")]
			Combined
		}

		[Token(Token = "0x200003D")]
		public enum TweakMode
		{
			[Token(Token = "0x40001EB")]
			Basic,
			[Token(Token = "0x40001EC")]
			Complex
		}

		[Token(Token = "0x200003E")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x40001EE")]
			Auto,
			[Token(Token = "0x40001EF")]
			On,
			[Token(Token = "0x40001F0")]
			Off
		}

		[Token(Token = "0x200003F")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x40001F2")]
			Screen,
			[Token(Token = "0x40001F3")]
			Add
		}

		[Token(Token = "0x2000040")]
		public enum BloomQuality
		{
			[Token(Token = "0x40001F5")]
			Cheap,
			[Token(Token = "0x40001F6")]
			High
		}

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x28")]
		public TweakMode tweakMode;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x3C")]
		public BloomQuality quality;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x48")]
		public Color bloomThresholdColor;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x58")]
		public int bloomBlurIterations;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x5C")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x60")]
		public float flareRotation;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x64")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x68")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x6C")]
		public float lensflareIntensity;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x70")]
		public float lensflareThreshold;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x74")]
		public float lensFlareSaturation;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x78")]
		public Color flareColorA;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x88")]
		public Color flareColorB;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x98")]
		public Color flareColorC;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0xA8")]
		public Color flareColorD;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0xB8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0xC0")]
		public Shader lensFlareShader;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0xC8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0xD0")]
		public Shader screenBlendShader;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0xD8")]
		private Material screenBlend;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0xE0")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0xE8")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0xF0")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0xF8")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x11ECA70", Offset = "0x11ECA70", VA = "0x11ECA70", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x11ECF38", Offset = "0x11ECF38", VA = "0x11ECF38")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x11EE568", Offset = "0x11EE568", VA = "0x11EE568")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x11EE2BC", Offset = "0x11EE2BC", VA = "0x11EE2BC")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x11EDFAC", Offset = "0x11EDFAC", VA = "0x11EDFAC")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x11EDEA4", Offset = "0x11EDEA4", VA = "0x11EDEA4")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x11EE09C", Offset = "0x11EE09C", VA = "0x11EE09C")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x11EE640", Offset = "0x11EE640", VA = "0x11EE640")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x4000063")]
		Ghosting,
		[Token(Token = "0x4000064")]
		Anamorphic,
		[Token(Token = "0x4000065")]
		Combined
	}
	[Token(Token = "0x2000010")]
	public enum TweakMode34
	{
		[Token(Token = "0x4000067")]
		Basic,
		[Token(Token = "0x4000068")]
		Complex
	}
	[Token(Token = "0x2000011")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x400006A")]
		Auto,
		[Token(Token = "0x400006B")]
		On,
		[Token(Token = "0x400006C")]
		Off
	}
	[Token(Token = "0x2000012")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x400006E")]
		Screen,
		[Token(Token = "0x400006F")]
		Add
	}
	[Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x633E18", Offset = "0x633E18")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x633E18", Offset = "0x633E18")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x28")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x3C")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x48")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x4C")]
		public bool lensflares;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x54")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x58")]
		public float hollyStretchWidth;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x5C")]
		public float lensflareIntensity;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x60")]
		public float lensflareThreshold;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x64")]
		public Color flareColorA;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x74")]
		public Color flareColorB;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x84")]
		public Color flareColorC;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x94")]
		public Color flareColorD;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0xA8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0xB0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0xB8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0xC0")]
		public Shader vignetteShader;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0xC8")]
		private Material vignetteMaterial;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0xD0")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0xD8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0xE0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0xE8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0xF0")]
		public Shader screenBlendShader;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0xF8")]
		private Material screenBlend;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x100")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x108")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x110")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x118")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x11EE7BC", Offset = "0x11EE7BC", VA = "0x11EE7BC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x11EE874", Offset = "0x11EE874", VA = "0x11EE874")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x11EFA6C", Offset = "0x11EFA6C", VA = "0x11EFA6C")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x11EF7D8", Offset = "0x11EF7D8", VA = "0x11EF7D8")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x11EF528", Offset = "0x11EF528", VA = "0x11EF528")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x11EF660", Offset = "0x11EF660", VA = "0x11EF660")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x11EFB28", Offset = "0x11EFB28", VA = "0x11EFB28")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x633EB0", Offset = "0x633EB0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x633EB0", Offset = "0x633EB0")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000041")]
		public enum Resolution
		{
			[Token(Token = "0x40001F8")]
			Low,
			[Token(Token = "0x40001F9")]
			High
		}

		[Token(Token = "0x2000042")]
		public enum BlurType
		{
			[Token(Token = "0x40001FB")]
			Standard,
			[Token(Token = "0x40001FC")]
			Sgx
		}

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x634F8C", Offset = "0x634F8C")]
		public float threshold;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x634FA4", Offset = "0x634FA4")]
		public float intensity;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x634FBC", Offset = "0x634FBC")]
		public float blurSize;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x634FD4", Offset = "0x634FD4")]
		public int blurIterations;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x3C")]
		public BlurType blurType;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x11EFC90", Offset = "0x11EFC90", VA = "0x11EFC90", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x11EFCE8", Offset = "0x11EFCE8", VA = "0x11EFCE8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x11EFD98", Offset = "0x11EFD98", VA = "0x11EFD98")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x11F01F4", Offset = "0x11F01F4", VA = "0x11F01F4")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x2000015")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x633F48", Offset = "0x633F48")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x634FEC", Offset = "0x634FEC")]
		public int iterations;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x635004", Offset = "0x635004")]
		public float blurSpread;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x17000001")]
		protected Material material
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x11F0214", Offset = "0x11F0214", VA = "0x11F0214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x11F0354", Offset = "0x11F0354", VA = "0x11F0354")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x11F0450", Offset = "0x11F0450", VA = "0x11F0450")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x11F0524", Offset = "0x11F0524", VA = "0x11F0524")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x11F0700", Offset = "0x11F0700", VA = "0x11F0700")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x11F08B8", Offset = "0x11F08B8", VA = "0x11F08B8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x11F0A34", Offset = "0x11F0A34", VA = "0x11F0A34")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x2000016")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x633F94", Offset = "0x633F94")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x633F94", Offset = "0x633F94")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000043")]
		public enum BlurType
		{
			[Token(Token = "0x40001FE")]
			StandardGauss,
			[Token(Token = "0x40001FF")]
			SgxGauss
		}

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63501C", Offset = "0x63501C")]
		public int downsample;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x635034", Offset = "0x635034")]
		public float blurSize;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63504C", Offset = "0x63504C")]
		public int blurIterations;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x34")]
		public BlurType blurType;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x11F0A50", Offset = "0x11F0A50", VA = "0x11F0A50", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x11F0AA8", Offset = "0x11F0AA8", VA = "0x11F0AA8")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x11F0B58", Offset = "0x11F0B58", VA = "0x11F0B58")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x11F0F88", Offset = "0x11F0F88", VA = "0x11F0F88")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x63402C", Offset = "0x63402C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63402C", Offset = "0x63402C")]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x2000044")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x4000201")]
			CameraMotion,
			[Token(Token = "0x4000202")]
			LocalBlur,
			[Token(Token = "0x4000203")]
			Reconstruction,
			[Token(Token = "0x4000204")]
			ReconstructionDX11,
			[Token(Token = "0x4000205")]
			ReconstructionDisc
		}

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x28")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x2C")]
		public bool preview;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 previewScale;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x3C")]
		public float movementScale;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x40")]
		public float rotationScale;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x44")]
		public float maxVelocity;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x48")]
		public float minVelocity;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x4C")]
		public float velocityScale;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x50")]
		public float softZDistance;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x54")]
		public int velocityDownsample;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x58")]
		public LayerMask excludeLayers;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x60")]
		private GameObject tmpCam;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x68")]
		public Shader shader;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x70")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x78")]
		public Shader replacementClear;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x80")]
		private Material motionBlurMaterial;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x88")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x90")]
		public Texture2D noiseTexture;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x98")]
		public float jitter;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x9C")]
		public bool showVelocity;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0xA0")]
		public float showVelocityScale;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0xA4")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0xE4")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x124")]
		private int prevFrameCount;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x128")]
		private bool wasActive;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x12C")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x138")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x144")]
		private Vector3 prevFramePos;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x150")]
		private Camera _camera;

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x11F0FA0", Offset = "0x11F0FA0", VA = "0x11F0FA0")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x11F1108", Offset = "0x11F1108", VA = "0x11F1108")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x11F12B8", Offset = "0x11F12B8", VA = "0x11F12B8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x11F1398", Offset = "0x11F1398", VA = "0x11F1398")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x11F14FC", Offset = "0x11F14FC", VA = "0x11F14FC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x11F15E0", Offset = "0x11F15E0", VA = "0x11F15E0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x11F11E8", Offset = "0x11F11E8", VA = "0x11F11E8")]
		private void Remember()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x11F2F70", Offset = "0x11F2F70", VA = "0x11F2F70")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x11F2E7C", Offset = "0x11F2E7C", VA = "0x11F2E7C")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x11F2F60", Offset = "0x11F2F60", VA = "0x11F2F60")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x11F3414", Offset = "0x11F3414", VA = "0x11F3414")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6340C4", Offset = "0x6340C4")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x2000045")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x4000207")]
			Simple,
			[Token(Token = "0x4000208")]
			Advanced
		}

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x98")]
		public float saturation;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0xC0")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x11F3560", Offset = "0x11F3560", VA = "0x11F3560")]
		private new void Start()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x11F359C", Offset = "0x11F359C", VA = "0x11F359C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x11F35A0", Offset = "0x11F35A0", VA = "0x11F35A0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x11F3844", Offset = "0x11F3844", VA = "0x11F3844")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x11F3CE8", Offset = "0x11F3CE8", VA = "0x11F3CE8")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x11F3CEC", Offset = "0x11F3CEC", VA = "0x11F3CEC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x11F40D8", Offset = "0x11F40D8", VA = "0x11F40D8")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000019")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634110", Offset = "0x634110")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x30")]
		private Material material;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x11F4810", Offset = "0x11F4810", VA = "0x11F4810", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x11F4864", Offset = "0x11F4864", VA = "0x11F4864")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x11F490C", Offset = "0x11F490C", VA = "0x11F490C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x11F49B4", Offset = "0x11F49B4", VA = "0x11F49B4")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x11F4BFC", Offset = "0x11F4BFC", VA = "0x11F4BFC")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x11F4D00", Offset = "0x11F4D00", VA = "0x11F4D00")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x11F5100", Offset = "0x11F5100", VA = "0x11F5100")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x11F532C", Offset = "0x11F532C", VA = "0x11F532C")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63415C", Offset = "0x63415C")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x11F5380", Offset = "0x11F5380", VA = "0x11F5380")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x11F5514", Offset = "0x11F5514", VA = "0x11F5514")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6341A8", Offset = "0x6341A8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6341A8", Offset = "0x6341A8")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x635064", Offset = "0x635064")]
		public float intensity;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63507C", Offset = "0x63507C")]
		public float threshold;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x635098", Offset = "0x635098")]
		public float blurSpread;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x11F5524", Offset = "0x11F5524", VA = "0x11F5524", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x11F5594", Offset = "0x11F5594", VA = "0x11F5594")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x11F5950", Offset = "0x11F5950", VA = "0x11F5950")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634240", Offset = "0x634240")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6350B0", Offset = "0x6350B0")]
		public float adaptationSpeed;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6350CC", Offset = "0x6350CC")]
		public float limitMinimum;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6350E4", Offset = "0x6350E4")]
		public float limitMaximum;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x17000002")]
		protected Material materialLum
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x11F5964", Offset = "0x11F5964", VA = "0x11F5964")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		protected Material materialReduce
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x11F5A2C", Offset = "0x11F5A2C", VA = "0x11F5A2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		protected Material materialAdapt
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x11F5AF4", Offset = "0x11F5AF4", VA = "0x11F5AF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		protected Material materialApply
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x11F5BBC", Offset = "0x11F5BBC", VA = "0x11F5BBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x11F5C84", Offset = "0x11F5C84", VA = "0x11F5C84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x11F5D44", Offset = "0x11F5D44", VA = "0x11F5D44")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x11F5EE4", Offset = "0x11F5EE4", VA = "0x11F5EE4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x11F6134", Offset = "0x11F6134", VA = "0x11F6134")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x11F63C8", Offset = "0x11F63C8", VA = "0x11F63C8")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x11F6634", Offset = "0x11F6634", VA = "0x11F6634")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x200001D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x63428C", Offset = "0x63428C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63428C", Offset = "0x63428C")]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x28")]
		public float intensity;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x2C")]
		public int softness;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x30")]
		public float spread;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x11F66B4", Offset = "0x11F66B4", VA = "0x11F66B4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x11F672C", Offset = "0x11F672C", VA = "0x11F672C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x11F6B1C", Offset = "0x11F6B1C", VA = "0x11F6B1C")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x200001E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x634324", Offset = "0x634324")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634324", Offset = "0x634324")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x2000046")]
		public enum BlurType
		{
			[Token(Token = "0x400020A")]
			DiscBlur,
			[Token(Token = "0x400020B")]
			DX11
		}

		[Token(Token = "0x2000047")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x400020D")]
			Low,
			[Token(Token = "0x400020E")]
			Medium,
			[Token(Token = "0x400020F")]
			High
		}

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x2C")]
		public float focalLength;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x30")]
		public float focalSize;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x34")]
		public float aperture;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x44")]
		public bool highResolution;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x48")]
		public BlurType blurType;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x4C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x11F6B34", Offset = "0x11F6B34", VA = "0x11F6B34", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x11F6D2C", Offset = "0x11F6D2C", VA = "0x11F6D2C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x11F6DC8", Offset = "0x11F6DC8", VA = "0x11F6DC8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x11F6ED0", Offset = "0x11F6ED0", VA = "0x11F6ED0")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x11F6BB8", Offset = "0x11F6BB8", VA = "0x11F6BB8")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x11F6F14", Offset = "0x11F6F14", VA = "0x11F6F14")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x11F70E8", Offset = "0x11F70E8", VA = "0x11F70E8")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x11F747C", Offset = "0x11F747C", VA = "0x11F747C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x11F8ED8", Offset = "0x11F8ED8", VA = "0x11F8ED8")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x200001F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6343BC", Offset = "0x6343BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6343BC", Offset = "0x6343BC")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x2000048")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x4000211")]
			OnlyBackground = 1,
			[Token(Token = "0x4000212")]
			BackgroundAndForeground
		}

		[Token(Token = "0x2000049")]
		public enum DofResolution
		{
			[Token(Token = "0x4000214")]
			High = 2,
			[Token(Token = "0x4000215")]
			Medium,
			[Token(Token = "0x4000216")]
			Low
		}

		[Token(Token = "0x200004A")]
		public enum DofBlurriness
		{
			[Token(Token = "0x4000218")]
			Low = 1,
			[Token(Token = "0x4000219")]
			High = 2,
			[Token(Token = "0x400021A")]
			VeryHigh = 4
		}

		[Token(Token = "0x200004B")]
		public enum BokehDestination
		{
			[Token(Token = "0x400021C")]
			Background = 1,
			[Token(Token = "0x400021D")]
			Foreground,
			[Token(Token = "0x400021E")]
			BackgroundAndForeground
		}

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x28")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x2C")]
		public DofResolution resolution;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x30")]
		public bool simpleTweakMode;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x34")]
		public float focalPoint;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x38")]
		public float smoothness;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x3C")]
		public float focalZDistance;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x40")]
		public float focalZStartCurve;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x44")]
		public float focalZEndCurve;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x48")]
		private float focalStartCurve;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x4C")]
		private float focalEndCurve;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x50")]
		private float focalDistance01;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x58")]
		public Transform objectFocus;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x60")]
		public float focalSize;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x64")]
		public DofBlurriness bluriness;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x68")]
		public float maxBlurSpread;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x6C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x70")]
		public Shader dofBlurShader;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x78")]
		private Material dofBlurMaterial;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x80")]
		public Shader dofShader;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x88")]
		private Material dofMaterial;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x90")]
		public bool visualize;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x94")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x98")]
		private float widthOverHeight;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x9C")]
		private float oneOverBaseSize;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0xA0")]
		public bool bokeh;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0xA1")]
		public bool bokehSupport;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0xA8")]
		public Shader bokehShader;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0xB0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0xB8")]
		public float bokehScale;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0xBC")]
		public float bokehIntensity;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0xC0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0xC4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0xC8")]
		public int bokehDownsample;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0xD0")]
		private Material bokehMaterial;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0xD8")]
		private Camera _camera;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0xE0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0xE8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0xF0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0xF8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x100")]
		private RenderTexture bokehSource;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x108")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x11F8F38", Offset = "0x11F8F38", VA = "0x11F8F38")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x11F9010", Offset = "0x11F9010", VA = "0x11F9010", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x11F9118", Offset = "0x11F9118", VA = "0x11F9118")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x11F9394", Offset = "0x11F9394", VA = "0x11F9394")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x11F9430", Offset = "0x11F9430", VA = "0x11F9430")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x11F9604", Offset = "0x11F9604", VA = "0x11F9604")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x11F9628", Offset = "0x11F9628", VA = "0x11F9628")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x11F964C", Offset = "0x11F964C", VA = "0x11F964C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x11FA624", Offset = "0x11FA624", VA = "0x11FA624")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x11FADA0", Offset = "0x11FADA0", VA = "0x11FADA0")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x11FB244", Offset = "0x11FB244", VA = "0x11FB244")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x11FA4C0", Offset = "0x11FA4C0", VA = "0x11FA4C0")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x11FA8F0", Offset = "0x11FA8F0", VA = "0x11FA8F0")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x11FB098", Offset = "0x11FB098", VA = "0x11FB098")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x11FA0E0", Offset = "0x11FA0E0", VA = "0x11FA0E0")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x11FB760", Offset = "0x11FB760", VA = "0x11FB760")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x634454", Offset = "0x634454")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634454", Offset = "0x634454")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x200004C")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x4000220")]
			TriangleDepthNormals,
			[Token(Token = "0x4000221")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x4000222")]
			SobelDepth,
			[Token(Token = "0x4000223")]
			SobelDepthThin,
			[Token(Token = "0x4000224")]
			TriangleLuminance
		}

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x28")]
		public EdgeDetectMode mode;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x2C")]
		public float sensitivityDepth;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x30")]
		public float sensitivityNormals;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x34")]
		public float lumThreshold;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x38")]
		public float edgeExp;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x3C")]
		public float sampleDist;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x40")]
		public float edgesOnly;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x44")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x58")]
		public Shader edgeDetectShader;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x60")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x68")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x11FB83C", Offset = "0x11FB83C", VA = "0x11FB83C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x11FB9C0", Offset = "0x11FB9C0", VA = "0x11FB9C0")]
		private new void Start()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x11FB8B4", Offset = "0x11FB8B4", VA = "0x11FB8B4")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x11FB9CC", Offset = "0x11FB9CC", VA = "0x11FB9CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x11FB9D0", Offset = "0x11FB9D0", VA = "0x11FB9D0")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x11FBC38", Offset = "0x11FBC38", VA = "0x11FBC38")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6344EC", Offset = "0x6344EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6344EC", Offset = "0x6344EC")]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6350FC", Offset = "0x6350FC")]
		public float strengthX;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x635114", Offset = "0x635114")]
		public float strengthY;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x11FBC88", Offset = "0x11FBC88", VA = "0x11FBC88", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x11FBCE0", Offset = "0x11FBCE0", VA = "0x11FBCE0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x11FBE68", Offset = "0x11FBE68", VA = "0x11FBE68")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x634584", Offset = "0x634584")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634584", Offset = "0x634584")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63512C", Offset = "0x63512C")]
		public bool distanceFog;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x635164", Offset = "0x635164")]
		public bool excludeFarPixels;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x2A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63519C", Offset = "0x63519C")]
		public bool useRadialDistance;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x2B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6351D4", Offset = "0x6351D4")]
		public bool heightFog;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63520C", Offset = "0x63520C")]
		public float height;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x635244", Offset = "0x635244")]
		public float heightDensity;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x635260", Offset = "0x635260")]
		public float startDistance;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x40")]
		private Material fogMaterial;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x11FBE80", Offset = "0x11FBE80", VA = "0x11FBE80", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x11FBED8", Offset = "0x11FBED8", VA = "0x11FBED8")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x11FC81C", Offset = "0x11FC81C", VA = "0x11FC81C")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x11FC9C8", Offset = "0x11FC9C8", VA = "0x11FC9C8")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63461C", Offset = "0x63461C")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x635298", Offset = "0x635298")]
		public float rampOffset;

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x11FC9E8", Offset = "0x11FC9E8", VA = "0x11FC9E8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x11FCAF0", Offset = "0x11FCAF0", VA = "0x11FCAF0")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x634668", Offset = "0x634668")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634668", Offset = "0x634668")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x17000006")]
		protected Material material
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x11F544C", Offset = "0x11F544C", VA = "0x11F544C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x11FCAF8", Offset = "0x11FCAF8", VA = "0x11FCAF8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x11FCBB0", Offset = "0x11FCBB0", VA = "0x11FCBB0", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x11F551C", Offset = "0x11F551C", VA = "0x11F551C")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6346F0", Offset = "0x6346F0")]
	public class ImageEffects
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x11FCC60", Offset = "0x11FCC60", VA = "0x11FCC60")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x11FCEF0", Offset = "0x11FCEF0", VA = "0x11FCEF0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x635758", Offset = "0x635758")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x11FCF68", Offset = "0x11FCF68", VA = "0x11FCF68")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x635790", Offset = "0x635790")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x11FCFE8", Offset = "0x11FCFE8", VA = "0x11FCFE8")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634728", Offset = "0x634728")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x634728", Offset = "0x634728")]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6352B0", Offset = "0x6352B0")]
		public float blurAmount;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x11FCFF0", Offset = "0x11FCFF0", VA = "0x11FCFF0", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x11FD034", Offset = "0x11FD034", VA = "0x11FD034", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x11FD0A8", Offset = "0x11FD0A8", VA = "0x11FD0A8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x11FD494", Offset = "0x11FD494", VA = "0x11FD494")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6347C0", Offset = "0x6347C0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6347C0", Offset = "0x6347C0")]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x28")]
		public float intensityMultiplier;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x2C")]
		public float generalIntensity;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x30")]
		public float blackIntensity;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x34")]
		public float whiteIntensity;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x38")]
		public float midGrey;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x3C")]
		public bool dx11Grain;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x40")]
		public float softness;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x44")]
		public bool monochrome;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 intensities;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 tiling;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x60")]
		public float monochromeTiling;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x64")]
		public FilterMode filterMode;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x68")]
		public Texture2D noiseTexture;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x70")]
		public Shader noiseShader;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x78")]
		private Material noiseMaterial;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x80")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x88")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x90")]
		private Mesh mesh;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x11FD4A8", Offset = "0x11FD4A8", VA = "0x11FD4A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x11FD508", Offset = "0x11FD508", VA = "0x11FD508", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x11FD580", Offset = "0x11FD580", VA = "0x11FD580")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x11FE06C", Offset = "0x11FE06C", VA = "0x11FE06C")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, Mesh mesh, int passNr)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x11FE3B0", Offset = "0x11FE3B0", VA = "0x11FE3B0")]
		private static void BuildMesh(Mesh mesh, RenderTexture source, Texture2D noise)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x11FEAEC", Offset = "0x11FEAEC", VA = "0x11FEAEC")]
		private static void BuildMeshUV0(Mesh mesh, int width, int height, float noiseSize, int noiseWidth)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x11FED70", Offset = "0x11FED70", VA = "0x11FED70")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x634858", Offset = "0x634858")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634858", Offset = "0x634858")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6352CC", Offset = "0x6352CC")]
		public float grainIntensityMin;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6352E4", Offset = "0x6352E4")]
		public float grainIntensityMax;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6352FC", Offset = "0x6352FC")]
		public float grainSize;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63531C", Offset = "0x63531C")]
		public float scratchIntensityMin;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x635334", Offset = "0x635334")]
		public float scratchIntensityMax;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63534C", Offset = "0x63534C")]
		public float scratchFPS;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x635364", Offset = "0x635364")]
		public float scratchJitter;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x17000007")]
		protected Material material
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x11FEFCC", Offset = "0x11FEFCC", VA = "0x11FEFCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x11FEE78", Offset = "0x11FEE78", VA = "0x11FEE78")]
		protected void Start()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x11FF134", Offset = "0x11FF134", VA = "0x11FF134")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x11FF238", Offset = "0x11FF238", VA = "0x11FF238")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x11FF374", Offset = "0x11FF374", VA = "0x11FF374")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x11FF718", Offset = "0x11FF718", VA = "0x11FF718")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6348F0", Offset = "0x6348F0")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x11ECAF8", Offset = "0x11ECAF8", VA = "0x11ECAF8")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x11EC100", Offset = "0x11EC100", VA = "0x11EC100")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x11FF74C", Offset = "0x11FF74C", VA = "0x11FF74C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x11FF758", Offset = "0x11FF758", VA = "0x11FF758")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x11FF75C", Offset = "0x11FF75C", VA = "0x11FF75C")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x11FF854", Offset = "0x11FF854", VA = "0x11FF854")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x11FF85C", Offset = "0x11FF85C", VA = "0x11FF85C", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x11F3590", Offset = "0x11F3590", VA = "0x11F3590")]
		protected void Start()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x11EBFC8", Offset = "0x11EBFC8", VA = "0x11EBFC8")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x11F1584", Offset = "0x11F1584", VA = "0x11F1584")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x11FF90C", Offset = "0x11FF90C", VA = "0x11FF90C")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x11EC32C", Offset = "0x11EC32C", VA = "0x11EC32C")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x11FF914", Offset = "0x11FF914", VA = "0x11FF914")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x11EC300", Offset = "0x11EC300", VA = "0x11EC300")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x11FFBA4", Offset = "0x11FFBA4", VA = "0x11FFBA4")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x11EC9F4", Offset = "0x11EC9F4", VA = "0x11EC9F4")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x634964", Offset = "0x634964")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x11FFF4C", Offset = "0x11FFF4C", VA = "0x11FFF4C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x11FFFB8", Offset = "0x11FFFB8", VA = "0x11FFFB8")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1200250", Offset = "0x1200250", VA = "0x1200250")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x12005F4", Offset = "0x12005F4", VA = "0x12005F4")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x12007AC", Offset = "0x12007AC", VA = "0x12007AC")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x200002B")]
	internal class Quads
	{
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x12007B4", Offset = "0x12007B4", VA = "0x12007B4")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x11F9174", Offset = "0x11F9174", VA = "0x11F9174")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x11FB488", Offset = "0x11FB488", VA = "0x11FB488")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x12008CC", Offset = "0x12008CC", VA = "0x12008CC")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1200FE0", Offset = "0x1200FE0", VA = "0x1200FE0")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6349D8", Offset = "0x6349D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6349D8", Offset = "0x6349D8")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x200004D")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x4000226")]
			Additive,
			[Token(Token = "0x4000227")]
			ScreenBlend,
			[Token(Token = "0x4000228")]
			Multiply,
			[Token(Token = "0x4000229")]
			Overlay,
			[Token(Token = "0x400022A")]
			AlphaBlend
		}

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x28")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1200FEC", Offset = "0x1200FEC", VA = "0x1200FEC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1201044", Offset = "0x1201044", VA = "0x1201044")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x12011FC", Offset = "0x12011FC", VA = "0x12011FC")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x634A70", Offset = "0x634A70")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634A70", Offset = "0x634A70")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63537C", Offset = "0x63537C")]
		public float intensity;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x635394", Offset = "0x635394")]
		public float radius;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6353B0", Offset = "0x6353B0")]
		public int blurIterations;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6353C8", Offset = "0x6353C8")]
		public float blurFilterDistance;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6353E0", Offset = "0x6353E0")]
		public int downsample;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x40")]
		public Texture2D rand;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x48")]
		public Shader aoShader;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x50")]
		private Material aoMaterial;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x120120C", Offset = "0x120120C", VA = "0x120120C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1201264", Offset = "0x1201264", VA = "0x1201264")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x120130C", Offset = "0x120130C", VA = "0x120130C")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x12019CC", Offset = "0x12019CC", VA = "0x12019CC")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x634B08", Offset = "0x634B08")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634B08", Offset = "0x634B08")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x200004E")]
		public enum SSAOSamples
		{
			[Token(Token = "0x400022C")]
			Low,
			[Token(Token = "0x400022D")]
			Medium,
			[Token(Token = "0x400022E")]
			High
		}

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6353F8", Offset = "0x6353F8")]
		public float m_Radius;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x635414", Offset = "0x635414")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63542C", Offset = "0x63542C")]
		public int m_Blur;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x635444", Offset = "0x635444")]
		public int m_Downsampling;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63545C", Offset = "0x63545C")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x635478", Offset = "0x635478")]
		public float m_MinZ;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x12019E8", Offset = "0x12019E8", VA = "0x12019E8")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1201A9C", Offset = "0x1201A9C", VA = "0x1201A9C")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1201B38", Offset = "0x1201B38", VA = "0x1201B38")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1201B40", Offset = "0x1201B40", VA = "0x1201B40")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1201D00", Offset = "0x1201D00", VA = "0x1201D00")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1201C20", Offset = "0x1201C20", VA = "0x1201C20")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1201D98", Offset = "0x1201D98", VA = "0x1201D98")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1202550", Offset = "0x1202550", VA = "0x1202550")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634BA0", Offset = "0x634BA0")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1202588", Offset = "0x1202588", VA = "0x1202588")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1202618", Offset = "0x1202618", VA = "0x1202618")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x634BEC", Offset = "0x634BEC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634BEC", Offset = "0x634BEC")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x200004F")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x4000230")]
			Low,
			[Token(Token = "0x4000231")]
			Normal,
			[Token(Token = "0x4000232")]
			High
		}

		[Token(Token = "0x2000050")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x4000234")]
			Screen,
			[Token(Token = "0x4000235")]
			Add
		}

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x28")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x2C")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x64")]
		public float maxRadius;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1202620", Offset = "0x1202620", VA = "0x1202620", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1202688", Offset = "0x1202688", VA = "0x1202688")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1202F9C", Offset = "0x1202F9C", VA = "0x1202F9C")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x634C84", Offset = "0x634C84")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634C84", Offset = "0x634C84")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x2000051")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x4000237")]
			TiltShiftMode,
			[Token(Token = "0x4000238")]
			IrisMode
		}

		[Token(Token = "0x2000052")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x400023A")]
			Preview,
			[Token(Token = "0x400023B")]
			Normal,
			[Token(Token = "0x400023C")]
			High
		}

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x28")]
		public TiltShiftMode mode;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x2C")]
		public TiltShiftQuality quality;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x635494", Offset = "0x635494")]
		public float blurArea;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6354AC", Offset = "0x6354AC")]
		public float maxBlurSize;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6354C4", Offset = "0x6354C4")]
		public int downsample;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1203044", Offset = "0x1203044", VA = "0x1203044", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x120309C", Offset = "0x120309C", VA = "0x120309C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x12033A4", Offset = "0x12033A4", VA = "0x12033A4")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x634D0C", Offset = "0x634D0C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634D0C", Offset = "0x634D0C")]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x2000053")]
		public enum TonemapperType
		{
			[Token(Token = "0x400023E")]
			SimpleReinhard,
			[Token(Token = "0x400023F")]
			UserCurve,
			[Token(Token = "0x4000240")]
			Hable,
			[Token(Token = "0x4000241")]
			Photographic,
			[Token(Token = "0x4000242")]
			OptimizedHejiDawson,
			[Token(Token = "0x4000243")]
			AdaptiveReinhard,
			[Token(Token = "0x4000244")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x2000054")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x4000246")]
			Square16 = 0x10,
			[Token(Token = "0x4000247")]
			Square32 = 0x20,
			[Token(Token = "0x4000248")]
			Square64 = 0x40,
			[Token(Token = "0x4000249")]
			Square128 = 0x80,
			[Token(Token = "0x400024A")]
			Square256 = 0x100,
			[Token(Token = "0x400024B")]
			Square512 = 0x200,
			[Token(Token = "0x400024C")]
			Square1024 = 0x400
		}

		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x28")]
		public TonemapperType type;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x2C")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x38")]
		private Texture2D curveTex;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x40")]
		public float exposureAdjustment;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x44")]
		public float middleGrey;

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x48")]
		public float white;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x4C")]
		public float adaptionSpeed;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x50")]
		public Shader tonemapper;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x58")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x60")]
		private Material tonemapMaterial;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x68")]
		private RenderTexture rt;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x70")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x12033BC", Offset = "0x12033BC", VA = "0x12033BC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1203514", Offset = "0x1203514", VA = "0x1203514")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1203834", Offset = "0x1203834", VA = "0x1203834")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x120398C", Offset = "0x120398C", VA = "0x120398C")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1203A80", Offset = "0x1203A80", VA = "0x1203A80")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x12043D0", Offset = "0x12043D0", VA = "0x12043D0")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x2000033")]
	internal class Triangles
	{
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x12043FC", Offset = "0x12043FC", VA = "0x12043FC")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1204558", Offset = "0x1204558", VA = "0x1204558")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1204778", Offset = "0x1204778", VA = "0x1204778")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1204A50", Offset = "0x1204A50", VA = "0x1204A50")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1204FD8", Offset = "0x1204FD8", VA = "0x1204FD8")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634DB4", Offset = "0x634DB4")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6354DC", Offset = "0x6354DC")]
		public float angle;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1204FE4", Offset = "0x1204FE4", VA = "0x1204FE4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1205028", Offset = "0x1205028", VA = "0x1205028")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x634E00", Offset = "0x634E00")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634E00", Offset = "0x634E00")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x2000055")]
		public enum AberrationMode
		{
			[Token(Token = "0x400024E")]
			Simple,
			[Token(Token = "0x400024F")]
			Advanced
		}

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x28")]
		public AberrationMode mode;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x34")]
		public float axialAberration;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x38")]
		public float blur;

		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x44")]
		public float blurDistance;

		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x12050A4", Offset = "0x12050A4", VA = "0x12050A4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1205128", Offset = "0x1205128", VA = "0x1205128")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1205820", Offset = "0x1205820", VA = "0x1205820")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634E98", Offset = "0x634E98")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1205854", Offset = "0x1205854", VA = "0x1205854")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1205898", Offset = "0x1205898", VA = "0x1205898")]
		public Vortex()
		{
		}
	}
}
namespace UnityStandardAssets.CinematicEffects
{
	[Token(Token = "0x2000037")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x634EE4", Offset = "0x634EE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x634EE4", Offset = "0x634EE4")]
	[ImageEffectAllowedInSceneView]
	public class Bloom : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000056")]
		public struct Settings
		{
			[Token(Token = "0x4000250")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x635540", Offset = "0x635540")]
			public float threshold;

			[Token(Token = "0x4000251")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63558C", Offset = "0x63558C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63558C", Offset = "0x63558C")]
			public float softKnee;

			[Token(Token = "0x4000252")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6355F0", Offset = "0x6355F0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6355F0", Offset = "0x6355F0")]
			public float radius;

			[Token(Token = "0x4000253")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x635654", Offset = "0x635654")]
			public float intensity;

			[Token(Token = "0x4000254")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6356A0", Offset = "0x6356A0")]
			public bool highQuality;

			[Token(Token = "0x4000255")]
			[FieldOffset(Offset = "0x11")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6356EC", Offset = "0x6356EC")]
			public bool antiFlicker;

			[Token(Token = "0x1700000B")]
			public float thresholdGamma
			{
				[Token(Token = "0x6000116")]
				[Address(RVA = "0x6AD264", Offset = "0x6AD264", VA = "0x6AD264")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000115")]
				[Address(RVA = "0x6AD25C", Offset = "0x6AD25C", VA = "0x6AD25C")]
				set
				{
				}
			}

			[Token(Token = "0x1700000C")]
			public float thresholdLinear
			{
				[Token(Token = "0x6000118")]
				[Address(RVA = "0x6AD274", Offset = "0x6AD274", VA = "0x6AD274")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000117")]
				[Address(RVA = "0x6AD26C", Offset = "0x6AD26C", VA = "0x6AD26C")]
				set
				{
				}
			}

			[Token(Token = "0x1700000D")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x6000119")]
				[Address(RVA = "0x11EB914", Offset = "0x11EB914", VA = "0x11EB914")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Settings settings;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private Shader m_Shader;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x38")]
		private Material m_Material;

		[Token(Token = "0x40001DD")]
		private const int kMaxIterations = 16;

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture[] m_blurBuffer1;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x48")]
		private RenderTexture[] m_blurBuffer2;

		[Token(Token = "0x17000008")]
		public Shader shader
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x11EA824", Offset = "0x11EA824", VA = "0x11EA824")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public Material material
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x11EA8BC", Offset = "0x11EA8BC", VA = "0x11EA8BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x11EAA24", Offset = "0x11EAA24", VA = "0x11EAA24")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x11EADB4", Offset = "0x11EADB4", VA = "0x11EADB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x11EAE60", Offset = "0x11EAE60", VA = "0x11EAE60")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x11EB890", Offset = "0x11EB890", VA = "0x11EB890")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public static class ImageEffectHelper
	{
		[Token(Token = "0x1700000A")]
		public static bool supportsDX11
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x11EBA28", Offset = "0x11EBA28", VA = "0x11EBA28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x11EAA70", Offset = "0x11EAA70", VA = "0x11EAA70")]
		public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect)
		{
			return default(bool);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x11EA94C", Offset = "0x11EA94C", VA = "0x11EA94C")]
		public static Material CheckShaderAndCreateMaterial(Shader s)
		{
			return null;
		}
	}
	[Token(Token = "0x2000039")]
	public sealed class MinAttribute : PropertyAttribute
	{
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x10")]
		public readonly float min;

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x11EBA58", Offset = "0x11EBA58", VA = "0x11EBA58")]
		public MinAttribute(float min)
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class RenderTextureUtility
	{
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x10")]
		private List<RenderTexture> m_TemporaryRTs;

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x11EBA8C", Offset = "0x11EBA8C", VA = "0x11EBA8C")]
		public RenderTexture GetTemporaryRenderTexture(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, FilterMode filterMode = FilterMode.Bilinear)
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x11EBBB4", Offset = "0x11EBBB4", VA = "0x11EBBB4")]
		public void ReleaseTemporaryRenderTexture(RenderTexture rt)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x11EBD48", Offset = "0x11EBD48", VA = "0x11EBD48")]
		public void ReleaseAllTemporaryRenderTextures()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x11EBE14", Offset = "0x11EBE14", VA = "0x11EBE14")]
		public RenderTextureUtility()
		{
		}
	}
}
