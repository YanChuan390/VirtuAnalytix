using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[Attribute(Name = "RequireComponent", RVA = "0xBD69F8", Offset = "0xBD69F8")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD69F8", Offset = "0xBD69F8")]
public class ImageEffectBase : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public Shader shader;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	private Material m_Material;

	[Token(Token = "0x17000001")]
	protected Material material
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2BCEEA8", Offset = "0x2BCEEA8", VA = "0x2BCEEA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2BCEDFC", Offset = "0x2BCEDFC", VA = "0x2BCEDFC", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2BCEF84", Offset = "0x2BCEF84", VA = "0x2BCEF84", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2BCF030", Offset = "0x2BCF030", VA = "0x2BCF030")]
	public ImageEffectBase()
	{
	}
}
[Token(Token = "0x2000003")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD6A84", Offset = "0xBD6A84")]
public class ImageEffects
{
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2BCF190", Offset = "0x2BCF190", VA = "0x2BCF190")]
	public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2BCF3E4", Offset = "0x2BCF3E4", VA = "0x2BCF3E4")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0xBD90D0", Offset = "0xBD90D0")]
	public static void Blit(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2BCF458", Offset = "0x2BCF458", VA = "0x2BCF458")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0xBD9108", Offset = "0xBD9108")]
	public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2BCF4DC", Offset = "0x2BCF4DC", VA = "0x2BCF4DC")]
	public ImageEffects()
	{
	}
}
[Token(Token = "0x2000004")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xBD6ABC", Offset = "0xBD6ABC")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD6ABC", Offset = "0xBD6ABC")]
public class TonemappingLog : PostEffectsBase
{
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	public bool enableAdaptive;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x29")]
	public bool debugClamp;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x2C")]
	public float middleGrey;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x30")]
	public float adaptionSpeed;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x34")]
	public float adaptiveMin;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x38")]
	public float adaptiveMax;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x3C")]
	public float logMid;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x40")]
	public float linearMid;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x44")]
	public float dynamicRange;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve remapCurve;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x50")]
	private Texture2D curveTex;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x58")]
	public Texture2D lutTex;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x60")]
	public Texture3D converted3DLut;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x68")]
	private string lutTexName;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x70")]
	public Shader tonemapperLog;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x78")]
	public bool validRenderTextureFormat;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x80")]
	private Material tonemapMaterial;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x88")]
	private RenderTexture rt;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x90")]
	private RenderTextureFormat rtFormat;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x94")]
	private int curveLen;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x98")]
	private float[] curveData;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2BD78C0", Offset = "0x2BD78C0", VA = "0x2BD78C0", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2BD7A20", Offset = "0x2BD7A20", VA = "0x2BD7A20")]
	public void UpdateCurve()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2BD7D68", Offset = "0x2BD7D68", VA = "0x2BD7D68")]
	public bool ValidDimensions(Texture2D tex2d)
	{
		return default(bool);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2BD7E28", Offset = "0x2BD7E28", VA = "0x2BD7E28")]
	public void SetIdentityLut()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2BD8038", Offset = "0x2BD8038", VA = "0x2BD8038")]
	public void Convert(Texture2D temp2DTex)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2BD8384", Offset = "0x2BD8384", VA = "0x2BD8384")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2BD8578", Offset = "0x2BD8578", VA = "0x2BD8578")]
	private bool CreateInternalRenderTexture()
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2BD8680", Offset = "0x2BD8680", VA = "0x2BD8680")]
	[ImageEffectTransformsToLDR]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2BD8E70", Offset = "0x2BD8E70", VA = "0x2BD8E70")]
	public TonemappingLog()
	{
	}
}
[Token(Token = "0x2000005")]
[Attribute(Name = "RequireComponent", RVA = "0xBD6B58", Offset = "0xBD6B58")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD6B58", Offset = "0xBD6B58")]
[ExecuteInEditMode]
public class TonemappingLut : PostEffectsBase
{
	[Token(Token = "0x2000006")]
	private struct SimplePolyFunc
	{
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x0")]
		public float A;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x4")]
		public float B;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x8")]
		public float x0;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0xC")]
		public float y0;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x10")]
		public float signX;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x14")]
		public float signY;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x18")]
		public float logA;

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2C9C4B4", Offset = "0x2C9C4B4", VA = "0x2C9C4B4")]
		public float Eval(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2C9C510", Offset = "0x2C9C510", VA = "0x2C9C510")]
		public void Initialize(float x_end, float y_end, float m)
		{
		}
	}

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x28")]
	public bool enableAdaptive;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x29")]
	public bool enableFilmicCurve;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x2A")]
	public bool enableUserLut;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x2B")]
	public bool enableColorGrading;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x2C")]
	public bool enableColorCurve;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x2D")]
	public bool debugClamp;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x30")]
	private Texture3D lutTex;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x38")]
	private Texture2D lutCurveTex1D;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x40")]
	public float adaptiveGreyOffset;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x44")]
	public float adaptionSpeed;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x48")]
	public float adaptiveMin;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x4C")]
	public float adaptiveMax;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x50")]
	public float lutExposureBias;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x54")]
	public Color lutWhiteBalance;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x64")]
	public float lutContrast;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x68")]
	public float lutSaturation;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x6C")]
	public float lutGamma;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x70")]
	public float lutToe;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x74")]
	public float lutShoulder;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve remapCurve;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x80")]
	public Texture2D userLutTex;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x88")]
	private string userLutName;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x90")]
	public Color lutShadows;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0xA0")]
	public Color lutMidtones;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0xB0")]
	public Color lutHighlights;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0xC0")]
	private float cache_lutContrast;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0xC4")]
	private float cache_lutSaturation;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0xC8")]
	private float cache_lutGamma;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0xCC")]
	private float cache_lutLowY;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0xD0")]
	private float cache_lutHighY;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0xD4")]
	private bool cache_enableAdaptive;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0xD5")]
	private bool cache_enableFilmicCurve;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0xD6")]
	private bool cache_enableColorGrading;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0xD7")]
	private bool cache_enableUserLut;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0xD8")]
	private bool cache_enableColorCurve;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0xDC")]
	private Color cache_lutWhiteBalance;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0xEC")]
	private Color cache_lutHighlights;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0xFC")]
	private Color cache_lutMidtones;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x10C")]
	private Color cache_lutShadows;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x120")]
	private Keyframe[] cache_remapCurve;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x128")]
	private string cache_userLutName;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x130")]
	public Shader tonemapperLut;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x138")]
	public bool validRenderTextureFormat;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x140")]
	private Material tonemapMaterial;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x148")]
	private RenderTexture rt;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x150")]
	private RenderTextureFormat rtFormat;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x154")]
	private int curveLen;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x158")]
	private float[] curveData;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x160")]
	private int userLutDim;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x168")]
	private Color[] userLutData;

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2BD9008", Offset = "0x2BD9008", VA = "0x2BD9008")]
	private bool HasCacheChanged()
	{
		return default(bool);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2BD942C", Offset = "0x2BD942C", VA = "0x2BD942C")]
	private void UpdateCache()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2BD9640", Offset = "0x2BD9640", VA = "0x2BD9640", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2BD96B8", Offset = "0x2BD96B8", VA = "0x2BD96B8")]
	private float GetHighlightRecovery()
	{
		return default(float);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2BD96D0", Offset = "0x2BD96D0", VA = "0x2BD96D0")]
	private float GetWhitePoint()
	{
		return default(float);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2BD9708", Offset = "0x2BD9708", VA = "0x2BD9708")]
	private float LutToLin(float x, float lutA)
	{
		return default(float);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2BD9720", Offset = "0x2BD9720", VA = "0x2BD9720")]
	private float LinToLut(float x, float lutA)
	{
		return default(float);
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2BD9730", Offset = "0x2BD9730", VA = "0x2BD9730")]
	private float LiftGammaGain(float x, float lift, float invGamma, float gain)
	{
		return default(float);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2BD9780", Offset = "0x2BD9780", VA = "0x2BD9780")]
	private float LogContrast(float x, float linRef, float contrast)
	{
		return default(float);
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2BD97DC", Offset = "0x2BD97DC", VA = "0x2BD97DC")]
	private Color NormalizeColor(Color c)
	{
		return default(Color);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2BD9858", Offset = "0x2BD9858", VA = "0x2BD9858")]
	private float GetLutA()
	{
		return default(float);
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2BD9864", Offset = "0x2BD9864", VA = "0x2BD9864")]
	public void UpdateCurve()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2BD9B3C", Offset = "0x2BD9B3C", VA = "0x2BD9B3C")]
	private float EvaluateCurve(float srcVal)
	{
		return default(float);
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2BD9C1C", Offset = "0x2BD9C1C", VA = "0x2BD9C1C")]
	public void SetIdentityLut()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2BD9D88", Offset = "0x2BD9D88", VA = "0x2BD9D88")]
	private int ClampDim(int srcX)
	{
		return default(int);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2BD9DA0", Offset = "0x2BD9DA0", VA = "0x2BD9DA0")]
	private Color SampleLutNearest(int r, int g, int b)
	{
		return default(Color);
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2BD9E18", Offset = "0x2BD9E18", VA = "0x2BD9E18")]
	private Color SampleLutNearestUnsafe(int r, int g, int b)
	{
		return default(Color);
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2BD9E68", Offset = "0x2BD9E68", VA = "0x2BD9E68")]
	private Color SampleLutLinear(float srcR, float srcG, float srcB)
	{
		return default(Color);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2BDA1B4", Offset = "0x2BDA1B4", VA = "0x2BDA1B4")]
	private void UpdateUserLut()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2BDA4C0", Offset = "0x2BDA4C0", VA = "0x2BDA4C0")]
	private float EvalFilmicHelper(float srcR, float lutA, SimplePolyFunc polyToe, SimplePolyFunc polyLinear, SimplePolyFunc polyShoulder, float x0, float x1, float linearW)
	{
		return default(float);
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2BDA5C8", Offset = "0x2BDA5C8", VA = "0x2BDA5C8")]
	private float EvalCurveGradingHelper(float srcR, float liftR, float invGammaR, float gainR)
	{
		return default(float);
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2BDA660", Offset = "0x2BDA660", VA = "0x2BDA660")]
	private void CreateFilmicCurveHelper(float lutA, SimplePolyFunc polyToe, SimplePolyFunc polyLinear, SimplePolyFunc polyShoulder, float x0, float x1, float linearW, float liftR, float invGammaR, float gainR, float liftG, float invGammaG, float gainG, float liftB, float invGammaB, float gainB)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x2BDAB00", Offset = "0x2BDAB00", VA = "0x2BDAB00")]
	private void UpdateLut()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x2BDA400", Offset = "0x2BDA400", VA = "0x2BDA400")]
	public bool ValidDimensions(Texture2D tex2d)
	{
		return default(bool);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2BDB254", Offset = "0x2BDB254", VA = "0x2BDB254")]
	public void Convert(Texture2D temp2DTex)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2BDB258", Offset = "0x2BDB258", VA = "0x2BDB258")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x2BDB44C", Offset = "0x2BDB44C", VA = "0x2BDB44C")]
	private bool CreateInternalRenderTexture()
	{
		return default(bool);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2BDB554", Offset = "0x2BDB554", VA = "0x2BDB554")]
	[ImageEffectTransformsToLDR]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x2BDBDF8", Offset = "0x2BDBDF8", VA = "0x2BDBDF8")]
	public TonemappingLut()
	{
	}
}
namespace UnityStandardAssets.ImageEffects;

[Token(Token = "0x2000007")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD6BF4", Offset = "0xBD6BF4")]
[Attribute(Name = "RequireComponent", RVA = "0xBD6BF4", Offset = "0xBD6BF4")]
[ExecuteInEditMode]
public class FilmicBloom : PostEffectsBase
{
	[Token(Token = "0x2000008")]
	public enum TweakMode
	{
		[Token(Token = "0x4000061")]
		Basic,
		[Token(Token = "0x4000062")]
		Advanced
	}

	[Token(Token = "0x2000009")]
	public enum BlendingMode
	{
		[Token(Token = "0x4000064")]
		Add,
		[Token(Token = "0x4000065")]
		Screen
	}

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x28")]
	public TweakMode tweakMode;

	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8154", Offset = "0xBD8154")]
	public float Threshold;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD816C", Offset = "0xBD816C")]
	public float Intensity;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8184", Offset = "0xBD8184")]
	public float BlurAmount;

	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD819C", Offset = "0xBD819C")]
	public float SpreadAmount;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x3C")]
	public Color Tint;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD81B8", Offset = "0xBD81B8")]
	public float KernelSize;

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD81D4", Offset = "0xBD81D4")]
	public float BlurKernelScale;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x54")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD81EC", Offset = "0xBD81EC")]
	public float SpreadKernelScale;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x58")]
	public BlendingMode BlendMode;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x5C")]
	public bool HighQuality;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x60")]
	public Texture2D DirtTexture;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x68")]
	public float Dirtiness;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x70")]
	public Shader filmicBloomShader;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x78")]
	private Material filmicBloomMaterial;

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2BB9D7C", Offset = "0x2BB9D7C", VA = "0x2BB9D7C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2BB9E00", Offset = "0x2BB9E00", VA = "0x2BB9E00")]
	private float videoBlurGetMaxScaleFor(float radius)
	{
		return default(float);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x2BB9EE0", Offset = "0x2BB9EE0", VA = "0x2BB9EE0")]
	private void BloomBlit(RenderTexture source, RenderTexture blur1, RenderTexture blur2, float radius1, float radius2)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x2BBA538", Offset = "0x2BBA538", VA = "0x2BBA538")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x2BBAB84", Offset = "0x2BBAB84", VA = "0x2BBAB84")]
	public FilmicBloom()
	{
	}
}
[Token(Token = "0x200000A")]
[Attribute(Name = "RequireComponent", RVA = "0xBD6C90", Offset = "0xBD6C90")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD6C90", Offset = "0xBD6C90")]
[ExecuteInEditMode]
public class FilmicDepthOfField : PostEffectsBase
{
	[Token(Token = "0x200000B")]
	public enum TweakMode
	{
		[Token(Token = "0x4000077")]
		Basic,
		[Token(Token = "0x4000078")]
		Advanced,
		[Token(Token = "0x4000079")]
		Explicit
	}

	[Token(Token = "0x200000C")]
	public enum ApertureShape
	{
		[Token(Token = "0x400007B")]
		Hexagon,
		[Token(Token = "0x400007C")]
		Octogon,
		[Token(Token = "0x400007D")]
		Circle,
		[Token(Token = "0x400007E")]
		DX11
	}

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x28")]
	public bool Visualize;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8204", Offset = "0xBD8204")]
	public float NearPlane;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD821C", Offset = "0xBD821C")]
	public float NearRadius;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8234", Offset = "0xBD8234")]
	public float FocusPlane;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD824C", Offset = "0xBD824C")]
	public float FocusRange;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8264", Offset = "0xBD8264")]
	public float FarPlane;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD827C", Offset = "0xBD827C")]
	public float FarRadius;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8294", Offset = "0xBD8294")]
	public float BoostPoint;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD82AC", Offset = "0xBD82AC")]
	public float NearBoostAmount;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD82C4", Offset = "0xBD82C4")]
	public float FarBoostAmount;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD82DC", Offset = "0xBD82DC")]
	public float FStops;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x54")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD82F4", Offset = "0xBD82F4")]
	public float Radius;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x58")]
	public ApertureShape Shape;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x5C")]
	public TweakMode tweakMode;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x60")]
	public Shader filmicDepthOfFieldShader;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x68")]
	private Material filmicDepthOfFieldMaterial;

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2BBAC08", Offset = "0x2BBAC08", VA = "0x2BBAC08", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x2BBAC8C", Offset = "0x2BBAC8C", VA = "0x2BBAC8C")]
	private void WhiteBoost(RenderTexture source, RenderTexture bluriness, RenderTexture tmp, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x2BBAF24", Offset = "0x2BBAF24", VA = "0x2BBAF24")]
	private void Bluriness(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x2BBB2C4", Offset = "0x2BBB2C4", VA = "0x2BBB2C4")]
	private void DoCircle(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2BBB6D4", Offset = "0x2BBB6D4", VA = "0x2BBB6D4")]
	private void DoDX11(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x2BBB748", Offset = "0x2BBB748", VA = "0x2BBB748")]
	private void DoHexagon(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2BBBC0C", Offset = "0x2BBBC0C", VA = "0x2BBBC0C")]
	private void DoOctogon(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x2BBC150", Offset = "0x2BBC150", VA = "0x2BBC150")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x2BBC2A0", Offset = "0x2BBC2A0", VA = "0x2BBC2A0")]
	public FilmicDepthOfField()
	{
	}
}
[Token(Token = "0x200000D")]
[Attribute(Name = "RequireComponent", RVA = "0xBD6D2C", Offset = "0xBD6D2C")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD6D2C", Offset = "0xBD6D2C")]
[ExecuteInEditMode]
public class LensDistort : PostEffectsBase
{
	[Token(Token = "0x200000E")]
	public enum Mode
	{
		[Token(Token = "0x400008B")]
		Distort,
		[Token(Token = "0x400008C")]
		Undistort
	}

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x28")]
	public Mode tweakMode;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD830C", Offset = "0xBD830C")]
	public float Amount;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8328", Offset = "0xBD8328")]
	public float CenterX;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8340", Offset = "0xBD8340")]
	public float CenterY;

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8358", Offset = "0xBD8358")]
	public float AmountX;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8370", Offset = "0xBD8370")]
	public float AmountY;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8388", Offset = "0xBD8388")]
	public float ChromaticAberration;

	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD83A0", Offset = "0xBD83A0")]
	public float Scale;

	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x48")]
	public bool OverSampling;

	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x50")]
	public Shader LensDistortShader;

	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x58")]
	private Material LensDistortMaterial;

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x2BCF838", Offset = "0x2BCF838", VA = "0x2BCF838", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2BCF8B0", Offset = "0x2BCF8B0", VA = "0x2BCF8B0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2BCFB84", Offset = "0x2BCFB84", VA = "0x2BCFB84")]
	public LensDistort()
	{
	}
}
[Token(Token = "0x200000F")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD6DC8", Offset = "0xBD6DC8")]
[Attribute(Name = "RequireComponent", RVA = "0xBD6DC8", Offset = "0xBD6DC8")]
public class FilmicVignette : PostEffectsBase
{
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD83B8", Offset = "0xBD83B8")]
	public float Radius;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD83D0", Offset = "0xBD83D0")]
	public float Spread;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD83E8", Offset = "0xBD83E8")]
	public float Darken;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8400", Offset = "0xBD8400")]
	public float Desaturate;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8418", Offset = "0xBD8418")]
	public float Blur;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x40")]
	public Shader FilmicVignetteShader;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x48")]
	private Material FilmicVignetteMaterial;

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2BCD528", Offset = "0x2BCD528", VA = "0x2BCD528", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2BCDB08", Offset = "0x2BCDB08", VA = "0x2BCDB08")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x2BCE1D8", Offset = "0x2BCE1D8", VA = "0x2BCE1D8")]
	public FilmicVignette()
	{
	}
}
[Token(Token = "0x2000010")]
public enum AAMode
{
	[Token(Token = "0x4000095")]
	FXAA2,
	[Token(Token = "0x4000096")]
	FXAA3Console,
	[Token(Token = "0x4000097")]
	FXAA1PresetA,
	[Token(Token = "0x4000098")]
	FXAA1PresetB,
	[Token(Token = "0x4000099")]
	NFAA,
	[Token(Token = "0x400009A")]
	SSAA,
	[Token(Token = "0x400009B")]
	DLAA
}
[Token(Token = "0x2000011")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD6E64", Offset = "0xBD6E64")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xBD6E64", Offset = "0xBD6E64")]
public class Antialiasing : PostEffectsBase
{
	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x28")]
	public AAMode mode;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x2C")]
	public bool showGeneratedNormals;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x30")]
	public float offsetScale;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x34")]
	public float blurRadius;

	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x38")]
	public float edgeThresholdMin;

	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x3C")]
	public float edgeThreshold;

	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x40")]
	public float edgeSharpness;

	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x44")]
	public bool dlaaSharp;

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x48")]
	public Shader ssaaShader;

	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x50")]
	private Material ssaa;

	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x58")]
	public Shader dlaaShader;

	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x60")]
	private Material dlaa;

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x68")]
	public Shader nfaaShader;

	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x70")]
	private Material nfaa;

	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x78")]
	public Shader shaderFXAAPreset2;

	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x80")]
	private Material materialFXAAPreset2;

	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x88")]
	public Shader shaderFXAAPreset3;

	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x90")]
	private Material materialFXAAPreset3;

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x98")]
	public Shader shaderFXAAII;

	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0xA0")]
	private Material materialFXAAII;

	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0xA8")]
	public Shader shaderFXAAIII;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0xB0")]
	private Material materialFXAAIII;

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2BABE38", Offset = "0x2BABE38", VA = "0x2BABE38")]
	public Material CurrentAAMaterial()
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2BABEA0", Offset = "0x2BABEA0", VA = "0x2BABEA0", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x2BAC014", Offset = "0x2BAC014", VA = "0x2BAC014")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x2BAC544", Offset = "0x2BAC544", VA = "0x2BAC544")]
	public Antialiasing()
	{
	}
}
[Token(Token = "0x2000012")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD6F00", Offset = "0xBD6F00")]
[Attribute(Name = "RequireComponent", RVA = "0xBD6F00", Offset = "0xBD6F00")]
[ExecuteInEditMode]
public class Bloom : PostEffectsBase
{
	[Token(Token = "0x2000013")]
	public enum LensFlareStyle
	{
		[Token(Token = "0x40000D1")]
		Ghosting,
		[Token(Token = "0x40000D2")]
		Anamorphic,
		[Token(Token = "0x40000D3")]
		Combined
	}

	[Token(Token = "0x2000014")]
	public enum TweakMode
	{
		[Token(Token = "0x40000D5")]
		Basic,
		[Token(Token = "0x40000D6")]
		Complex
	}

	[Token(Token = "0x2000015")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x40000D8")]
		Auto,
		[Token(Token = "0x40000D9")]
		On,
		[Token(Token = "0x40000DA")]
		Off
	}

	[Token(Token = "0x2000016")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x40000DC")]
		Screen,
		[Token(Token = "0x40000DD")]
		Add
	}

	[Token(Token = "0x2000017")]
	public enum BloomQuality
	{
		[Token(Token = "0x40000DF")]
		Cheap,
		[Token(Token = "0x40000E0")]
		High
	}

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x28")]
	public TweakMode tweakMode;

	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x2C")]
	public BloomScreenBlendMode screenBlendMode;

	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x30")]
	public HDRBloomMode hdr;

	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x34")]
	private bool doHdr;

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x38")]
	public float sepBlurSpread;

	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x3C")]
	public BloomQuality quality;

	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x40")]
	public float bloomIntensity;

	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x44")]
	public float bloomThreshold;

	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x48")]
	public Color bloomThresholdColor;

	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x58")]
	public int bloomBlurIterations;

	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x5C")]
	public int hollywoodFlareBlurIterations;

	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x60")]
	public float flareRotation;

	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x64")]
	public LensFlareStyle lensflareMode;

	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x68")]
	public float hollyStretchWidth;

	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x6C")]
	public float lensflareIntensity;

	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x70")]
	public float lensflareThreshold;

	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x74")]
	public float lensFlareSaturation;

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x78")]
	public Color flareColorA;

	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x88")]
	public Color flareColorB;

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x98")]
	public Color flareColorC;

	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0xA8")]
	public Color flareColorD;

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0xB8")]
	public Texture2D lensFlareVignetteMask;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0xC0")]
	public Shader lensFlareShader;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0xC8")]
	private Material lensFlareMaterial;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0xD0")]
	public Shader screenBlendShader;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0xD8")]
	private Material screenBlend;

	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0xE0")]
	public Shader blurAndFlaresShader;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0xE8")]
	private Material blurAndFlaresMaterial;

	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0xF0")]
	public Shader brightPassFilterShader;

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0xF8")]
	private Material brightPassFilterMaterial;

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2BAC568", Offset = "0x2BAC568", VA = "0x2BAC568", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x2BAC658", Offset = "0x2BAC658", VA = "0x2BAC658")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x2BADB40", Offset = "0x2BADB40", VA = "0x2BADB40")]
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x2BAD8C0", Offset = "0x2BAD8C0", VA = "0x2BAD8C0")]
	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2BAD5AC", Offset = "0x2BAD5AC", VA = "0x2BAD5AC")]
	private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x2BAD4B8", Offset = "0x2BAD4B8", VA = "0x2BAD4B8")]
	private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x2BAD6A8", Offset = "0x2BAD6A8", VA = "0x2BAD6A8")]
	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2BADC10", Offset = "0x2BADC10", VA = "0x2BADC10")]
	public Bloom()
	{
	}
}
[Token(Token = "0x2000018")]
public enum LensflareStyle34
{
	[Token(Token = "0x40000E2")]
	Ghosting,
	[Token(Token = "0x40000E3")]
	Anamorphic,
	[Token(Token = "0x40000E4")]
	Combined
}
[Token(Token = "0x2000019")]
public enum TweakMode34
{
	[Token(Token = "0x40000E6")]
	Basic,
	[Token(Token = "0x40000E7")]
	Complex
}
[Token(Token = "0x200001A")]
public enum HDRBloomMode
{
	[Token(Token = "0x40000E9")]
	Auto,
	[Token(Token = "0x40000EA")]
	On,
	[Token(Token = "0x40000EB")]
	Off
}
[Token(Token = "0x200001B")]
public enum BloomScreenBlendMode
{
	[Token(Token = "0x40000ED")]
	Screen,
	[Token(Token = "0x40000EE")]
	Add
}
[Token(Token = "0x200001C")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD6F9C", Offset = "0xBD6F9C")]
[Attribute(Name = "RequireComponent", RVA = "0xBD6F9C", Offset = "0xBD6F9C")]
[ExecuteInEditMode]
public class BloomAndFlares : PostEffectsBase
{
	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x28")]
	public TweakMode34 tweakMode;

	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x2C")]
	public BloomScreenBlendMode screenBlendMode;

	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x30")]
	public HDRBloomMode hdr;

	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x34")]
	private bool doHdr;

	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x38")]
	public float sepBlurSpread;

	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0x3C")]
	public float useSrcAlphaAsMask;

	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0x40")]
	public float bloomIntensity;

	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x44")]
	public float bloomThreshold;

	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x48")]
	public int bloomBlurIterations;

	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x4C")]
	public bool lensflares;

	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x50")]
	public int hollywoodFlareBlurIterations;

	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x54")]
	public LensflareStyle34 lensflareMode;

	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x58")]
	public float hollyStretchWidth;

	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x5C")]
	public float lensflareIntensity;

	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x60")]
	public float lensflareThreshold;

	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x64")]
	public Color flareColorA;

	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x74")]
	public Color flareColorB;

	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x84")]
	public Color flareColorC;

	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x94")]
	public Color flareColorD;

	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0xA8")]
	public Texture2D lensFlareVignetteMask;

	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0xB0")]
	public Shader lensFlareShader;

	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0xB8")]
	private Material lensFlareMaterial;

	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0xC0")]
	public Shader vignetteShader;

	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0xC8")]
	private Material vignetteMaterial;

	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0xD0")]
	public Shader separableBlurShader;

	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0xD8")]
	private Material separableBlurMaterial;

	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0xE0")]
	public Shader addBrightStuffOneOneShader;

	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0xE8")]
	private Material addBrightStuffBlendOneOneMaterial;

	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0xF0")]
	public Shader screenBlendShader;

	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0xF8")]
	private Material screenBlend;

	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x100")]
	public Shader hollywoodFlaresShader;

	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x108")]
	private Material hollywoodFlaresMaterial;

	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x110")]
	public Shader brightPassFilterShader;

	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x118")]
	private Material brightPassFilterMaterial;

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x2BADD50", Offset = "0x2BADD50", VA = "0x2BADD50", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x2BADEB0", Offset = "0x2BADEB0", VA = "0x2BADEB0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x2BAEF4C", Offset = "0x2BAEF4C", VA = "0x2BAEF4C")]
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x2BAECD4", Offset = "0x2BAECD4", VA = "0x2BAECD4")]
	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x2BAEA14", Offset = "0x2BAEA14", VA = "0x2BAEA14")]
	private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x2BAEB5C", Offset = "0x2BAEB5C", VA = "0x2BAEB5C")]
	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x2BAF008", Offset = "0x2BAF008", VA = "0x2BAF008")]
	public BloomAndFlares()
	{
	}
}
[Token(Token = "0x200001D")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD7038", Offset = "0xBD7038")]
[Attribute(Name = "RequireComponent", RVA = "0xBD7038", Offset = "0xBD7038")]
[ExecuteInEditMode]
public class BloomOptimized : PostEffectsBase
{
	[Token(Token = "0x200001E")]
	public enum Resolution
	{
		[Token(Token = "0x400011A")]
		Low,
		[Token(Token = "0x400011B")]
		High
	}

	[Token(Token = "0x200001F")]
	public enum BlurType
	{
		[Token(Token = "0x400011D")]
		Standard,
		[Token(Token = "0x400011E")]
		Sgx
	}

	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8430", Offset = "0xBD8430")]
	public float threshold;

	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8448", Offset = "0xBD8448")]
	public float intensity;

	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8460", Offset = "0xBD8460")]
	public float blurSize;

	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x34")]
	private Resolution resolution;

	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8478", Offset = "0xBD8478")]
	public int blurIterations;

	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x3C")]
	public BlurType blurType;

	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x40")]
	public Shader fastBloomShader;

	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x48")]
	private Material fastBloomMaterial;

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x2BAF138", Offset = "0x2BAF138", VA = "0x2BAF138", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x2BAF1B0", Offset = "0x2BAF1B0", VA = "0x2BAF1B0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x2BAF25C", Offset = "0x2BAF25C", VA = "0x2BAF25C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x2BAF630", Offset = "0x2BAF630", VA = "0x2BAF630")]
	public BloomOptimized()
	{
	}
}
[Token(Token = "0x2000020")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD70D4", Offset = "0xBD70D4")]
public class Blur : MonoBehaviour
{
	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8490", Offset = "0xBD8490")]
	public int iterations;

	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD84A8", Offset = "0xBD84A8")]
	public float blurSpread;

	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x20")]
	public Shader blurShader;

	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x0")]
	private static Material m_Material;

	[Token(Token = "0x17000002")]
	protected Material material
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2BAF654", Offset = "0x2BAF654", VA = "0x2BAF654")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x2BAF7A8", Offset = "0x2BAF7A8", VA = "0x2BAF7A8")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x2BAF8AC", Offset = "0x2BAF8AC", VA = "0x2BAF8AC")]
	protected void Start()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x2BAF968", Offset = "0x2BAF968", VA = "0x2BAF968")]
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x2BAFA8C", Offset = "0x2BAFA8C", VA = "0x2BAFA8C")]
	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x2BAFBA4", Offset = "0x2BAFBA4", VA = "0x2BAFBA4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x2BAFD0C", Offset = "0x2BAFD0C", VA = "0x2BAFD0C")]
	public Blur()
	{
	}
}
[Token(Token = "0x2000021")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD7120", Offset = "0xBD7120")]
[Attribute(Name = "RequireComponent", RVA = "0xBD7120", Offset = "0xBD7120")]
[ExecuteInEditMode]
public class BlurOptimized : PostEffectsBase
{
	[Token(Token = "0x2000022")]
	public enum BlurType
	{
		[Token(Token = "0x400012A")]
		StandardGauss,
		[Token(Token = "0x400012B")]
		SgxGauss
	}

	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD84C0", Offset = "0xBD84C0")]
	public int downsample;

	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD84D8", Offset = "0xBD84D8")]
	public float blurSize;

	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD84F0", Offset = "0xBD84F0")]
	public int blurIterations;

	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x34")]
	public BlurType blurType;

	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x38")]
	public Shader blurShader;

	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x40")]
	private Material blurMaterial;

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x2BAFD28", Offset = "0x2BAFD28", VA = "0x2BAFD28", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x2BAFDA0", Offset = "0x2BAFDA0", VA = "0x2BAFDA0")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x2BAFE4C", Offset = "0x2BAFE4C", VA = "0x2BAFE4C")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x2BB01EC", Offset = "0x2BB01EC", VA = "0x2BB01EC")]
	public BlurOptimized()
	{
	}
}
[Token(Token = "0x2000023")]
[Attribute(Name = "RequireComponent", RVA = "0xBD71BC", Offset = "0xBD71BC")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD71BC", Offset = "0xBD71BC")]
[ExecuteInEditMode]
public class CameraMotionBlur : PostEffectsBase
{
	[Token(Token = "0x2000024")]
	public enum MotionBlurFilter
	{
		[Token(Token = "0x400014D")]
		CameraMotion,
		[Token(Token = "0x400014E")]
		LocalBlur,
		[Token(Token = "0x400014F")]
		Reconstruction,
		[Token(Token = "0x4000150")]
		ReconstructionDX11,
		[Token(Token = "0x4000151")]
		ReconstructionDisc
	}

	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x0")]
	private static float MAX_RADIUS;

	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x28")]
	public MotionBlurFilter filterType;

	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x2C")]
	public bool preview;

	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 previewScale;

	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x3C")]
	public float movementScale;

	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x40")]
	public float rotationScale;

	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x44")]
	public float maxVelocity;

	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x48")]
	public float minVelocity;

	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x4C")]
	public float velocityScale;

	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x50")]
	public float softZDistance;

	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0x54")]
	public int velocityDownsample;

	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x58")]
	public LayerMask excludeLayers;

	[Token(Token = "0x4000138")]
	[FieldOffset(Offset = "0x60")]
	private GameObject tmpCam;

	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0x68")]
	public Shader shader;

	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x70")]
	public Shader dx11MotionBlurShader;

	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x78")]
	public Shader replacementClear;

	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0x80")]
	private Material motionBlurMaterial;

	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0x88")]
	private Material dx11MotionBlurMaterial;

	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x90")]
	public Texture2D noiseTexture;

	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0x98")]
	public float jitter;

	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0x9C")]
	public bool showVelocity;

	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0xA0")]
	public float showVelocityScale;

	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0xA4")]
	private Matrix4x4 currentViewProjMat;

	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0xE8")]
	private Matrix4x4[] currentStereoViewProjMat;

	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0xF0")]
	private Matrix4x4 prevViewProjMat;

	[Token(Token = "0x4000145")]
	[FieldOffset(Offset = "0x130")]
	private Matrix4x4[] prevStereoViewProjMat;

	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0x138")]
	private int prevFrameCount;

	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0x13C")]
	private bool wasActive;

	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x140")]
	private Vector3 prevFrameForward;

	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0x14C")]
	private Vector3 prevFrameUp;

	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0x158")]
	private Vector3 prevFramePos;

	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x168")]
	private Camera _camera;

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x2BB0208", Offset = "0x2BB0208", VA = "0x2BB0208")]
	private void CalculateViewProjection()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x2BB047C", Offset = "0x2BB047C", VA = "0x2BB047C")]
	private new void Start()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x2BB072C", Offset = "0x2BB072C", VA = "0x2BB072C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x2BB0800", Offset = "0x2BB0800", VA = "0x2BB0800")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x2BB0998", Offset = "0x2BB0998", VA = "0x2BB0998", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x2BB0A50", Offset = "0x2BB0A50", VA = "0x2BB0A50")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x2BB05C0", Offset = "0x2BB05C0", VA = "0x2BB05C0")]
	private void Remember()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x2BB2374", Offset = "0x2BB2374", VA = "0x2BB2374")]
	private Camera GetTmpCam()
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x2BB22E4", Offset = "0x2BB22E4", VA = "0x2BB22E4")]
	private void StartFrame()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x2BB2364", Offset = "0x2BB2364", VA = "0x2BB2364")]
	private static int divRoundUp(int x, int d)
	{
		return default(int);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x2BB2724", Offset = "0x2BB2724", VA = "0x2BB2724")]
	public CameraMotionBlur()
	{
	}
}
[Token(Token = "0x2000025")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD7258", Offset = "0xBD7258")]
[ExecuteInEditMode]
public class ColorCorrectionCurves : PostEffectsBase
{
	[Token(Token = "0x2000026")]
	public enum ColorCorrectionMode
	{
		[Token(Token = "0x400016B")]
		Simple,
		[Token(Token = "0x400016C")]
		Advanced
	}

	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve redChannel;

	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve greenChannel;

	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve blueChannel;

	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x40")]
	public bool useDepthCorrection;

	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve zCurve;

	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve depthRedChannel;

	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve depthGreenChannel;

	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x60")]
	public AnimationCurve depthBlueChannel;

	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0x68")]
	private Material ccMaterial;

	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0x70")]
	private Material ccDepthMaterial;

	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x78")]
	private Material selectiveCcMaterial;

	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x80")]
	private Texture2D rgbChannelTex;

	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x88")]
	private Texture2D rgbDepthChannelTex;

	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x90")]
	private Texture2D zCurveTex;

	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x98")]
	public float saturation;

	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0x9C")]
	public bool selectiveCc;

	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0xA0")]
	public Color selectiveFromColor;

	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0xB0")]
	public Color selectiveToColor;

	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0xC0")]
	public ColorCorrectionMode mode;

	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0xC4")]
	public bool updateTextures;

	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0xC8")]
	public Shader colorCorrectionCurvesShader;

	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0xD0")]
	public Shader simpleColorCorrectionCurvesShader;

	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0xD8")]
	public Shader colorCorrectionSelectiveShader;

	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0xE0")]
	private bool updateTexturesOnStartup;

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x2BB282C", Offset = "0x2BB282C", VA = "0x2BB282C")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x2BB2858", Offset = "0x2BB2858", VA = "0x2BB2858")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x2BB285C", Offset = "0x2BB285C", VA = "0x2BB285C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x2BB2B38", Offset = "0x2BB2B38", VA = "0x2BB2B38")]
	public void UpdateParameters()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2BB2EF8", Offset = "0x2BB2EF8", VA = "0x2BB2EF8")]
	private void UpdateTextures()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x2BB2EFC", Offset = "0x2BB2EFC", VA = "0x2BB2EFC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2BB3224", Offset = "0x2BB3224", VA = "0x2BB3224")]
	public ColorCorrectionCurves()
	{
	}
}
[Token(Token = "0x2000027")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD72A4", Offset = "0xBD72A4")]
[ExecuteInEditMode]
public class ColorCorrectionLookup : PostEffectsBase
{
	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x28")]
	public Shader shader;

	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x30")]
	private Material material;

	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x38")]
	public Texture3D converted3DLut;

	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0x40")]
	public string basedOnTempTex;

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x2BB38B4", Offset = "0x2BB38B4", VA = "0x2BB38B4", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2BB3928", Offset = "0x2BB3928", VA = "0x2BB3928")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2BB39E4", Offset = "0x2BB39E4", VA = "0x2BB39E4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x2BB3A90", Offset = "0x2BB3A90", VA = "0x2BB3A90")]
	public void SetIdentityLut()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x2BB3CC8", Offset = "0x2BB3CC8", VA = "0x2BB3CC8")]
	public bool ValidDimensions(Texture2D tex2d)
	{
		return default(bool);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x2BB3D88", Offset = "0x2BB3D88", VA = "0x2BB3D88")]
	public void Convert(Texture2D temp2DTex, string path)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x2BB4100", Offset = "0x2BB4100", VA = "0x2BB4100")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x2BB431C", Offset = "0x2BB431C", VA = "0x2BB431C")]
	public ColorCorrectionLookup()
	{
	}
}
[Token(Token = "0x2000028")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD72F0", Offset = "0xBD72F0")]
[ExecuteInEditMode]
public class ColorCorrectionRamp : ImageEffectBase
{
	[Token(Token = "0x4000171")]
	[FieldOffset(Offset = "0x28")]
	public Texture textureRamp;

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x2BB4380", Offset = "0x2BB4380", VA = "0x2BB4380")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x2BB4448", Offset = "0x2BB4448", VA = "0x2BB4448")]
	public ColorCorrectionRamp()
	{
	}
}
[Token(Token = "0x2000029")]
[Attribute(Name = "RequireComponent", RVA = "0xBD733C", Offset = "0xBD733C")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD733C", Offset = "0xBD733C")]
public class ContrastEnhance : PostEffectsBase
{
	[Token(Token = "0x4000172")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8508", Offset = "0xBD8508")]
	public float intensity;

	[Token(Token = "0x4000173")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8520", Offset = "0xBD8520")]
	public float threshold;

	[Token(Token = "0x4000174")]
	[FieldOffset(Offset = "0x30")]
	private Material separableBlurMaterial;

	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0x38")]
	private Material contrastCompositeMaterial;

	[Token(Token = "0x4000176")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD853C", Offset = "0xBD853C")]
	public float blurSpread;

	[Token(Token = "0x4000177")]
	[FieldOffset(Offset = "0x48")]
	public Shader separableBlurShader;

	[Token(Token = "0x4000178")]
	[FieldOffset(Offset = "0x50")]
	public Shader contrastCompositeShader;

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x2BB4450", Offset = "0x2BB4450", VA = "0x2BB4450", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x2BB44F0", Offset = "0x2BB44F0", VA = "0x2BB44F0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x2BB487C", Offset = "0x2BB487C", VA = "0x2BB487C")]
	public ContrastEnhance()
	{
	}
}
[Token(Token = "0x200002A")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD73D8", Offset = "0xBD73D8")]
public class ContrastStretch : MonoBehaviour
{
	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8554", Offset = "0xBD8554")]
	public float adaptationSpeed;

	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8570", Offset = "0xBD8570")]
	public float limitMinimum;

	[Token(Token = "0x400017B")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8588", Offset = "0xBD8588")]
	public float limitMaximum;

	[Token(Token = "0x400017C")]
	[FieldOffset(Offset = "0x28")]
	private RenderTexture[] adaptRenderTex;

	[Token(Token = "0x400017D")]
	[FieldOffset(Offset = "0x30")]
	private int curAdaptIndex;

	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x38")]
	public Shader shaderLum;

	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x40")]
	private Material m_materialLum;

	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x48")]
	public Shader shaderReduce;

	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x50")]
	private Material m_materialReduce;

	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x58")]
	public Shader shaderAdapt;

	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x60")]
	private Material m_materialAdapt;

	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x68")]
	public Shader shaderApply;

	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x70")]
	private Material m_materialApply;

	[Token(Token = "0x17000003")]
	protected Material materialLum
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2BB4894", Offset = "0x2BB4894", VA = "0x2BB4894")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	protected Material materialReduce
	{
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2BB4970", Offset = "0x2BB4970", VA = "0x2BB4970")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	protected Material materialAdapt
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2BB4A4C", Offset = "0x2BB4A4C", VA = "0x2BB4A4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	protected Material materialApply
	{
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2BB4B28", Offset = "0x2BB4B28", VA = "0x2BB4B28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x2BB4C04", Offset = "0x2BB4C04", VA = "0x2BB4C04")]
	private void Start()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x2BB4C98", Offset = "0x2BB4C98", VA = "0x2BB4C98")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x2BB4DFC", Offset = "0x2BB4DFC", VA = "0x2BB4DFC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x2BB5038", Offset = "0x2BB5038", VA = "0x2BB5038")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x2BB529C", Offset = "0x2BB529C", VA = "0x2BB529C")]
	private void CalculateAdaptation(Texture curTexture)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x2BB5498", Offset = "0x2BB5498", VA = "0x2BB5498")]
	public ContrastStretch()
	{
	}
}
[Token(Token = "0x200002B")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD7424", Offset = "0xBD7424")]
[Attribute(Name = "RequireComponent", RVA = "0xBD7424", Offset = "0xBD7424")]
public class CreaseShading : PostEffectsBase
{
	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x28")]
	public float intensity;

	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x2C")]
	public int softness;

	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0x30")]
	public float spread;

	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0x38")]
	public Shader blurShader;

	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x40")]
	private Material blurMaterial;

	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x48")]
	public Shader depthFetchShader;

	[Token(Token = "0x400018C")]
	[FieldOffset(Offset = "0x50")]
	private Material depthFetchMaterial;

	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x58")]
	public Shader creaseApplyShader;

	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x60")]
	private Material creaseApplyMaterial;

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x2BB5520", Offset = "0x2BB5520", VA = "0x2BB5520", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x2BB55F0", Offset = "0x2BB55F0", VA = "0x2BB55F0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x2BB59C4", Offset = "0x2BB59C4", VA = "0x2BB59C4")]
	public CreaseShading()
	{
	}
}
[Token(Token = "0x200002C")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xBD74C0", Offset = "0xBD74C0")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD74C0", Offset = "0xBD74C0")]
public class DepthOfField : PostEffectsBase
{
	[Token(Token = "0x200002D")]
	public enum BlurType
	{
		[Token(Token = "0x40001A9")]
		DiscBlur,
		[Token(Token = "0x40001AA")]
		DX11
	}

	[Token(Token = "0x200002E")]
	public enum BlurSampleCount
	{
		[Token(Token = "0x40001AC")]
		Low,
		[Token(Token = "0x40001AD")]
		Medium,
		[Token(Token = "0x40001AE")]
		High
	}

	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x28")]
	public bool visualizeFocus;

	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x2C")]
	public float focalLength;

	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x30")]
	public float focalSize;

	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x34")]
	public float aperture;

	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x38")]
	public Transform focalTransform;

	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x40")]
	public float maxBlurSize;

	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x44")]
	public bool highResolution;

	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x48")]
	public BlurType blurType;

	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x4C")]
	public BlurSampleCount blurSampleCount;

	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x50")]
	public bool nearBlur;

	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x54")]
	public float foregroundOverlap;

	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x58")]
	public Shader dofHdrShader;

	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x60")]
	private Material dofHdrMaterial;

	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x68")]
	public Shader dx11BokehShader;

	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x70")]
	private Material dx11bokehMaterial;

	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x78")]
	public float dx11BokehThreshold;

	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0x7C")]
	public float dx11SpawnHeuristic;

	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x80")]
	public Texture2D dx11BokehTexture;

	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x88")]
	public float dx11BokehScale;

	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x8C")]
	public float dx11BokehIntensity;

	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x90")]
	private float focalDistance01;

	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x98")]
	private ComputeBuffer cbDrawArgs;

	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0xA0")]
	private ComputeBuffer cbPoints;

	[Token(Token = "0x40001A6")]
	[FieldOffset(Offset = "0xA8")]
	private float internalBlurWidth;

	[Token(Token = "0x40001A7")]
	[FieldOffset(Offset = "0xB0")]
	private Camera cachedCamera;

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x2BB59E0", Offset = "0x2BB59E0", VA = "0x2BB59E0", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x2BB5BF4", Offset = "0x2BB5BF4", VA = "0x2BB5BF4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x2BB5C80", Offset = "0x2BB5C80", VA = "0x2BB5C80")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x2BB5D9C", Offset = "0x2BB5D9C", VA = "0x2BB5D9C")]
	private void ReleaseComputeResources()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x2BB5A9C", Offset = "0x2BB5A9C", VA = "0x2BB5A9C")]
	private void CreateComputeResources()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x2BB5DF8", Offset = "0x2BB5DF8", VA = "0x2BB5DF8")]
	private float FocalDistance01(float worldDist)
	{
		return default(float);
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2BB5EE8", Offset = "0x2BB5EE8", VA = "0x2BB5EE8")]
	private void WriteCoc(RenderTexture fromTo, bool fgDilate)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x2BB6214", Offset = "0x2BB6214", VA = "0x2BB6214")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x2BB7810", Offset = "0x2BB7810", VA = "0x2BB7810")]
	public DepthOfField()
	{
	}
}
[Token(Token = "0x200002F")]
[Attribute(Name = "RequireComponent", RVA = "0xBD755C", Offset = "0xBD755C")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD755C", Offset = "0xBD755C")]
public class DepthOfFieldDeprecated : PostEffectsBase
{
	[Token(Token = "0x2000030")]
	public enum Dof34QualitySetting
	{
		[Token(Token = "0x40001DB")]
		OnlyBackground = 1,
		[Token(Token = "0x40001DC")]
		BackgroundAndForeground
	}

	[Token(Token = "0x2000031")]
	public enum DofResolution
	{
		[Token(Token = "0x40001DE")]
		High = 2,
		[Token(Token = "0x40001DF")]
		Medium,
		[Token(Token = "0x40001E0")]
		Low
	}

	[Token(Token = "0x2000032")]
	public enum DofBlurriness
	{
		[Token(Token = "0x40001E2")]
		Low = 1,
		[Token(Token = "0x40001E3")]
		High = 2,
		[Token(Token = "0x40001E4")]
		VeryHigh = 4
	}

	[Token(Token = "0x2000033")]
	public enum BokehDestination
	{
		[Token(Token = "0x40001E6")]
		Background = 1,
		[Token(Token = "0x40001E7")]
		Foreground,
		[Token(Token = "0x40001E8")]
		BackgroundAndForeground
	}

	[Token(Token = "0x40001AF")]
	[FieldOffset(Offset = "0x0")]
	private static int SMOOTH_DOWNSAMPLE_PASS;

	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x4")]
	private static float BOKEH_EXTRA_BLUR;

	[Token(Token = "0x40001B1")]
	[FieldOffset(Offset = "0x28")]
	public Dof34QualitySetting quality;

	[Token(Token = "0x40001B2")]
	[FieldOffset(Offset = "0x2C")]
	public DofResolution resolution;

	[Token(Token = "0x40001B3")]
	[FieldOffset(Offset = "0x30")]
	public bool simpleTweakMode;

	[Token(Token = "0x40001B4")]
	[FieldOffset(Offset = "0x34")]
	public float focalPoint;

	[Token(Token = "0x40001B5")]
	[FieldOffset(Offset = "0x38")]
	public float smoothness;

	[Token(Token = "0x40001B6")]
	[FieldOffset(Offset = "0x3C")]
	public float focalZDistance;

	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0x40")]
	public float focalZStartCurve;

	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0x44")]
	public float focalZEndCurve;

	[Token(Token = "0x40001B9")]
	[FieldOffset(Offset = "0x48")]
	private float focalStartCurve;

	[Token(Token = "0x40001BA")]
	[FieldOffset(Offset = "0x4C")]
	private float focalEndCurve;

	[Token(Token = "0x40001BB")]
	[FieldOffset(Offset = "0x50")]
	private float focalDistance01;

	[Token(Token = "0x40001BC")]
	[FieldOffset(Offset = "0x58")]
	public Transform objectFocus;

	[Token(Token = "0x40001BD")]
	[FieldOffset(Offset = "0x60")]
	public float focalSize;

	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0x64")]
	public DofBlurriness bluriness;

	[Token(Token = "0x40001BF")]
	[FieldOffset(Offset = "0x68")]
	public float maxBlurSpread;

	[Token(Token = "0x40001C0")]
	[FieldOffset(Offset = "0x6C")]
	public float foregroundBlurExtrude;

	[Token(Token = "0x40001C1")]
	[FieldOffset(Offset = "0x70")]
	public Shader dofBlurShader;

	[Token(Token = "0x40001C2")]
	[FieldOffset(Offset = "0x78")]
	private Material dofBlurMaterial;

	[Token(Token = "0x40001C3")]
	[FieldOffset(Offset = "0x80")]
	public Shader dofShader;

	[Token(Token = "0x40001C4")]
	[FieldOffset(Offset = "0x88")]
	private Material dofMaterial;

	[Token(Token = "0x40001C5")]
	[FieldOffset(Offset = "0x90")]
	public bool visualize;

	[Token(Token = "0x40001C6")]
	[FieldOffset(Offset = "0x94")]
	public BokehDestination bokehDestination;

	[Token(Token = "0x40001C7")]
	[FieldOffset(Offset = "0x98")]
	private float widthOverHeight;

	[Token(Token = "0x40001C8")]
	[FieldOffset(Offset = "0x9C")]
	private float oneOverBaseSize;

	[Token(Token = "0x40001C9")]
	[FieldOffset(Offset = "0xA0")]
	public bool bokeh;

	[Token(Token = "0x40001CA")]
	[FieldOffset(Offset = "0xA1")]
	public bool bokehSupport;

	[Token(Token = "0x40001CB")]
	[FieldOffset(Offset = "0xA8")]
	public Shader bokehShader;

	[Token(Token = "0x40001CC")]
	[FieldOffset(Offset = "0xB0")]
	public Texture2D bokehTexture;

	[Token(Token = "0x40001CD")]
	[FieldOffset(Offset = "0xB8")]
	public float bokehScale;

	[Token(Token = "0x40001CE")]
	[FieldOffset(Offset = "0xBC")]
	public float bokehIntensity;

	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0xC0")]
	public float bokehThresholdContrast;

	[Token(Token = "0x40001D0")]
	[FieldOffset(Offset = "0xC4")]
	public float bokehThresholdLuminance;

	[Token(Token = "0x40001D1")]
	[FieldOffset(Offset = "0xC8")]
	public int bokehDownsample;

	[Token(Token = "0x40001D2")]
	[FieldOffset(Offset = "0xD0")]
	private Material bokehMaterial;

	[Token(Token = "0x40001D3")]
	[FieldOffset(Offset = "0xD8")]
	private Camera _camera;

	[Token(Token = "0x40001D4")]
	[FieldOffset(Offset = "0xE0")]
	private RenderTexture foregroundTexture;

	[Token(Token = "0x40001D5")]
	[FieldOffset(Offset = "0xE8")]
	private RenderTexture mediumRezWorkTexture;

	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0xF0")]
	private RenderTexture finalDefocus;

	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0xF8")]
	private RenderTexture lowRezWorkTexture;

	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x100")]
	private RenderTexture bokehSource;

	[Token(Token = "0x40001D9")]
	[FieldOffset(Offset = "0x108")]
	private RenderTexture bokehSource2;

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x2BB7868", Offset = "0x2BB7868", VA = "0x2BB7868")]
	private void CreateMaterials()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x2BB7980", Offset = "0x2BB7980", VA = "0x2BB7980", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x2BB7AC8", Offset = "0x2BB7AC8", VA = "0x2BB7AC8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x2BB7B24", Offset = "0x2BB7B24", VA = "0x2BB7B24")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x2BB7BB0", Offset = "0x2BB7BB0", VA = "0x2BB7BB0")]
	private float FocalDistance01(float worldDist)
	{
		return default(float);
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x2BB7CA0", Offset = "0x2BB7CA0", VA = "0x2BB7CA0")]
	private int GetDividerBasedOnQuality()
	{
		return default(int);
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x2BB7CC4", Offset = "0x2BB7CC4", VA = "0x2BB7CC4")]
	private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
	{
		return default(int);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x2BB7CE8", Offset = "0x2BB7CE8", VA = "0x2BB7CE8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x2BB8BAC", Offset = "0x2BB8BAC", VA = "0x2BB8BAC")]
	private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x2BB926C", Offset = "0x2BB926C", VA = "0x2BB926C")]
	private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x2BB9698", Offset = "0x2BB9698", VA = "0x2BB9698")]
	private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x2BB8A4C", Offset = "0x2BB8A4C", VA = "0x2BB8A4C")]
	private void Downsample(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x2BB8E14", Offset = "0x2BB8E14", VA = "0x2BB8E14")]
	private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x2BB94F0", Offset = "0x2BB94F0", VA = "0x2BB94F0")]
	private void ReleaseTextures()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x2BB8680", Offset = "0x2BB8680", VA = "0x2BB8680")]
	private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x2BB98C8", Offset = "0x2BB98C8", VA = "0x2BB98C8")]
	public DepthOfFieldDeprecated()
	{
	}
}
[Token(Token = "0x2000034")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xBD75F8", Offset = "0xBD75F8")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD75F8", Offset = "0xBD75F8")]
public class EdgeDetection : PostEffectsBase
{
	[Token(Token = "0x2000035")]
	public enum EdgeDetectMode
	{
		[Token(Token = "0x40001F5")]
		TriangleDepthNormals,
		[Token(Token = "0x40001F6")]
		RobertsCrossDepthNormals,
		[Token(Token = "0x40001F7")]
		SobelDepth,
		[Token(Token = "0x40001F8")]
		SobelDepthThin,
		[Token(Token = "0x40001F9")]
		TriangleLuminance
	}

	[Token(Token = "0x40001E9")]
	[FieldOffset(Offset = "0x28")]
	public EdgeDetectMode mode;

	[Token(Token = "0x40001EA")]
	[FieldOffset(Offset = "0x2C")]
	public float sensitivityDepth;

	[Token(Token = "0x40001EB")]
	[FieldOffset(Offset = "0x30")]
	public float sensitivityNormals;

	[Token(Token = "0x40001EC")]
	[FieldOffset(Offset = "0x34")]
	public float lumThreshold;

	[Token(Token = "0x40001ED")]
	[FieldOffset(Offset = "0x38")]
	public float edgeExp;

	[Token(Token = "0x40001EE")]
	[FieldOffset(Offset = "0x3C")]
	public float sampleDist;

	[Token(Token = "0x40001EF")]
	[FieldOffset(Offset = "0x40")]
	public float edgesOnly;

	[Token(Token = "0x40001F0")]
	[FieldOffset(Offset = "0x44")]
	public Color edgesOnlyBgColor;

	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x58")]
	public Shader edgeDetectShader;

	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x60")]
	private Material edgeDetectMaterial;

	[Token(Token = "0x40001F3")]
	[FieldOffset(Offset = "0x68")]
	private EdgeDetectMode oldMode;

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x2BB99A0", Offset = "0x2BB99A0", VA = "0x2BB99A0", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x2BB9AEC", Offset = "0x2BB9AEC", VA = "0x2BB9AEC")]
	private new void Start()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x2BB9A38", Offset = "0x2BB9A38", VA = "0x2BB9A38")]
	private void SetCameraFlag()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x2BB9AF8", Offset = "0x2BB9AF8", VA = "0x2BB9AF8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x2BB9AFC", Offset = "0x2BB9AFC", VA = "0x2BB9AFC")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x2BB9D28", Offset = "0x2BB9D28", VA = "0x2BB9D28")]
	public EdgeDetection()
	{
	}
}
[Token(Token = "0x2000036")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xBD7694", Offset = "0xBD7694")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD7694", Offset = "0xBD7694")]
public class Fisheye : PostEffectsBase
{
	[Token(Token = "0x40001FA")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD85A0", Offset = "0xBD85A0")]
	public float strengthX;

	[Token(Token = "0x40001FB")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD85B8", Offset = "0xBD85B8")]
	public float strengthY;

	[Token(Token = "0x40001FC")]
	[FieldOffset(Offset = "0x30")]
	public Shader fishEyeShader;

	[Token(Token = "0x40001FD")]
	[FieldOffset(Offset = "0x38")]
	private Material fisheyeMaterial;

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x2BCE27C", Offset = "0x2BCE27C", VA = "0x2BCE27C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x2BCE3EC", Offset = "0x2BCE3EC", VA = "0x2BCE3EC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x2BCE568", Offset = "0x2BCE568", VA = "0x2BCE568")]
	public Fisheye()
	{
	}
}
[Token(Token = "0x2000037")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xBD7730", Offset = "0xBD7730")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD7730", Offset = "0xBD7730")]
public class GlobalFog : PostEffectsBase
{
	[Token(Token = "0x40001FE")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD85D0", Offset = "0xBD85D0")]
	public bool distanceFog;

	[Token(Token = "0x40001FF")]
	[FieldOffset(Offset = "0x29")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8608", Offset = "0xBD8608")]
	public bool excludeFarPixels;

	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0x2A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8640", Offset = "0xBD8640")]
	public bool useRadialDistance;

	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x2B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8678", Offset = "0xBD8678")]
	public bool heightFog;

	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD86B0", Offset = "0xBD86B0")]
	public float height;

	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD86E8", Offset = "0xBD86E8")]
	public float heightDensity;

	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8704", Offset = "0xBD8704")]
	public float startDistance;

	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x38")]
	public Shader fogShader;

	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0x40")]
	private Material fogMaterial;

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x2BCE57C", Offset = "0x2BCE57C", VA = "0x2BCE57C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x2BCE600", Offset = "0x2BCE600", VA = "0x2BCE600")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x2BCEC00", Offset = "0x2BCEC00", VA = "0x2BCEC00")]
	public GlobalFog()
	{
	}
}
[Token(Token = "0x2000038")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD77CC", Offset = "0xBD77CC")]
[ExecuteInEditMode]
public class Grayscale : ImageEffectBase
{
	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x28")]
	public Texture textureRamp;

	[Token(Token = "0x4000208")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD873C", Offset = "0xBD873C")]
	public float rampOffset;

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x2BCEC20", Offset = "0x2BCEC20", VA = "0x2BCEC20")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x2BCEDEC", Offset = "0x2BCEDEC", VA = "0x2BCEDEC")]
	public Grayscale()
	{
	}
}
[Token(Token = "0x2000039")]
[Attribute(Name = "RequireComponent", RVA = "0xBD7818", Offset = "0xBD7818")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD7818", Offset = "0xBD7818")]
public class ImageEffectBase : MonoBehaviour
{
	[Token(Token = "0x4000209")]
	[FieldOffset(Offset = "0x18")]
	public Shader shader;

	[Token(Token = "0x400020A")]
	[FieldOffset(Offset = "0x20")]
	private Material m_Material;

	[Token(Token = "0x17000007")]
	protected Material material
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2BCED10", Offset = "0x2BCED10", VA = "0x2BCED10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x2BCF038", Offset = "0x2BCF038", VA = "0x2BCF038", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x2BCF0E4", Offset = "0x2BCF0E4", VA = "0x2BCF0E4", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x2BCEDF4", Offset = "0x2BCEDF4", VA = "0x2BCEDF4")]
	public ImageEffectBase()
	{
	}
}
[Token(Token = "0x200003A")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD78A4", Offset = "0xBD78A4")]
public class ImageEffects
{
	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x2BCF4E4", Offset = "0x2BCF4E4", VA = "0x2BCF4E4")]
	public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x2BCF738", Offset = "0x2BCF738", VA = "0x2BCF738")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0xBD9190", Offset = "0xBD9190")]
	public static void Blit(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x2BCF7AC", Offset = "0x2BCF7AC", VA = "0x2BCF7AC")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0xBD91C8", Offset = "0xBD91C8")]
	public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x2BCF830", Offset = "0x2BCF830", VA = "0x2BCF830")]
	public ImageEffects()
	{
	}
}
[Token(Token = "0x200003B")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xBD78DC", Offset = "0xBD78DC")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD78DC", Offset = "0xBD78DC")]
public class MotionBlur : ImageEffectBase
{
	[Token(Token = "0x400020B")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8754", Offset = "0xBD8754")]
	public float blurAmount;

	[Token(Token = "0x400020C")]
	[FieldOffset(Offset = "0x2C")]
	public bool extraBlur;

	[Token(Token = "0x400020D")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture accumTexture;

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x2BCFB9C", Offset = "0x2BCFB9C", VA = "0x2BCFB9C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x2BCFBA0", Offset = "0x2BCFBA0", VA = "0x2BCFBA0", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x2BCFC18", Offset = "0x2BCFC18", VA = "0x2BCFC18")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x2BCFFA4", Offset = "0x2BCFFA4", VA = "0x2BCFFA4")]
	public MotionBlur()
	{
	}
}
[Token(Token = "0x200003C")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xBD7978", Offset = "0xBD7978")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD7978", Offset = "0xBD7978")]
public class NoiseAndGrain : PostEffectsBase
{
	[Token(Token = "0x400020E")]
	[FieldOffset(Offset = "0x28")]
	public float intensityMultiplier;

	[Token(Token = "0x400020F")]
	[FieldOffset(Offset = "0x2C")]
	public float generalIntensity;

	[Token(Token = "0x4000210")]
	[FieldOffset(Offset = "0x30")]
	public float blackIntensity;

	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x34")]
	public float whiteIntensity;

	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x38")]
	public float midGrey;

	[Token(Token = "0x4000213")]
	[FieldOffset(Offset = "0x3C")]
	public bool dx11Grain;

	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0x40")]
	public float softness;

	[Token(Token = "0x4000215")]
	[FieldOffset(Offset = "0x44")]
	public bool monochrome;

	[Token(Token = "0x4000216")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 intensities;

	[Token(Token = "0x4000217")]
	[FieldOffset(Offset = "0x54")]
	public Vector3 tiling;

	[Token(Token = "0x4000218")]
	[FieldOffset(Offset = "0x60")]
	public float monochromeTiling;

	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0x64")]
	public FilterMode filterMode;

	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0x68")]
	public Texture2D noiseTexture;

	[Token(Token = "0x400021B")]
	[FieldOffset(Offset = "0x70")]
	public Shader noiseShader;

	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0x78")]
	private Material noiseMaterial;

	[Token(Token = "0x400021D")]
	[FieldOffset(Offset = "0x80")]
	public Shader dx11NoiseShader;

	[Token(Token = "0x400021E")]
	[FieldOffset(Offset = "0x88")]
	private Material dx11NoiseMaterial;

	[Token(Token = "0x400021F")]
	[FieldOffset(Offset = "0x0")]
	private static float TILE_AMOUNT;

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x2BCFFB8", Offset = "0x2BCFFB8", VA = "0x2BCFFB8", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x2BD0058", Offset = "0x2BD0058", VA = "0x2BD0058")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x2BD0848", Offset = "0x2BD0848", VA = "0x2BD0848")]
	private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x2BD0B9C", Offset = "0x2BD0B9C", VA = "0x2BD0B9C")]
	public NoiseAndGrain()
	{
	}
}
[Token(Token = "0x200003D")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xBD7A14", Offset = "0xBD7A14")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD7A14", Offset = "0xBD7A14")]
public class NoiseAndScratches : MonoBehaviour
{
	[Token(Token = "0x4000220")]
	[FieldOffset(Offset = "0x18")]
	public bool monochrome;

	[Token(Token = "0x4000221")]
	[FieldOffset(Offset = "0x19")]
	private bool rgbFallback;

	[Token(Token = "0x4000222")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8770", Offset = "0xBD8770")]
	public float grainIntensityMin;

	[Token(Token = "0x4000223")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8788", Offset = "0xBD8788")]
	public float grainIntensityMax;

	[Token(Token = "0x4000224")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD87A0", Offset = "0xBD87A0")]
	public float grainSize;

	[Token(Token = "0x4000225")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD87C0", Offset = "0xBD87C0")]
	public float scratchIntensityMin;

	[Token(Token = "0x4000226")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD87D8", Offset = "0xBD87D8")]
	public float scratchIntensityMax;

	[Token(Token = "0x4000227")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD87F0", Offset = "0xBD87F0")]
	public float scratchFPS;

	[Token(Token = "0x4000228")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8808", Offset = "0xBD8808")]
	public float scratchJitter;

	[Token(Token = "0x4000229")]
	[FieldOffset(Offset = "0x38")]
	public Texture grainTexture;

	[Token(Token = "0x400022A")]
	[FieldOffset(Offset = "0x40")]
	public Texture scratchTexture;

	[Token(Token = "0x400022B")]
	[FieldOffset(Offset = "0x48")]
	public Shader shaderRGB;

	[Token(Token = "0x400022C")]
	[FieldOffset(Offset = "0x50")]
	public Shader shaderYUV;

	[Token(Token = "0x400022D")]
	[FieldOffset(Offset = "0x58")]
	private Material m_MaterialRGB;

	[Token(Token = "0x400022E")]
	[FieldOffset(Offset = "0x60")]
	private Material m_MaterialYUV;

	[Token(Token = "0x400022F")]
	[FieldOffset(Offset = "0x68")]
	private float scratchTimeLeft;

	[Token(Token = "0x4000230")]
	[FieldOffset(Offset = "0x6C")]
	private float scratchX;

	[Token(Token = "0x4000231")]
	[FieldOffset(Offset = "0x70")]
	private float scratchY;

	[Token(Token = "0x17000008")]
	protected Material material
	{
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2BD0D7C", Offset = "0x2BD0D7C", VA = "0x2BD0D7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x2BD0C28", Offset = "0x2BD0C28", VA = "0x2BD0C28")]
	protected void Start()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x2BD0EF0", Offset = "0x2BD0EF0", VA = "0x2BD0EF0")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x2BD0FF0", Offset = "0x2BD0FF0", VA = "0x2BD0FF0")]
	private void SanitizeParameters()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x2BD10E4", Offset = "0x2BD10E4", VA = "0x2BD10E4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x2BD146C", Offset = "0x2BD146C", VA = "0x2BD146C")]
	public NoiseAndScratches()
	{
	}
}
[Token(Token = "0x200003E")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xBD7AB0", Offset = "0xBD7AB0")]
public class PostEffectsBase : MonoBehaviour
{
	[Token(Token = "0x4000232")]
	[FieldOffset(Offset = "0x18")]
	protected bool supportHDRTextures;

	[Token(Token = "0x4000233")]
	[FieldOffset(Offset = "0x19")]
	protected bool supportDX11;

	[Token(Token = "0x4000234")]
	[FieldOffset(Offset = "0x1A")]
	protected bool isSupported;

	[Token(Token = "0x4000235")]
	[FieldOffset(Offset = "0x20")]
	private List<Material> createdMaterials;

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x2BCD5FC", Offset = "0x2BCD5FC", VA = "0x2BCD5FC")]
	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x2BD14CC", Offset = "0x2BD14CC", VA = "0x2BD14CC")]
	protected Material CreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x2BD16DC", Offset = "0x2BD16DC", VA = "0x2BD16DC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x2BD16E8", Offset = "0x2BD16E8", VA = "0x2BD16E8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x2BD16EC", Offset = "0x2BD16EC", VA = "0x2BD16EC")]
	private void RemoveCreatedMaterials()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x2BD17BC", Offset = "0x2BD17BC", VA = "0x2BD17BC")]
	protected bool CheckSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x2BD17C4", Offset = "0x2BD17C4", VA = "0x2BD17C4", Slot = "4")]
	public virtual bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x2BD1898", Offset = "0x2BD1898", VA = "0x2BD1898")]
	protected void Start()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x2BCE2E8", Offset = "0x2BCE2E8", VA = "0x2BCE2E8")]
	protected bool CheckSupport(bool needDepth)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x2BCD5A0", Offset = "0x2BCD5A0", VA = "0x2BCD5A0")]
	protected bool CheckSupport(bool needDepth, bool needHdr)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x2BD18A4", Offset = "0x2BD18A4", VA = "0x2BD18A4")]
	public bool Dx11Support()
	{
		return default(bool);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x2BCDA3C", Offset = "0x2BCDA3C", VA = "0x2BCDA3C")]
	protected void ReportAutoDisable()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x2BD18AC", Offset = "0x2BD18AC", VA = "0x2BD18AC")]
	private bool CheckShader(Shader s)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x2BD14A0", Offset = "0x2BD14A0", VA = "0x2BD14A0")]
	protected void NotSupported()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x2BD1B48", Offset = "0x2BD1B48", VA = "0x2BD1B48")]
	protected void DrawBorder(RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x2BCE1E4", Offset = "0x2BCE1E4", VA = "0x2BCE1E4")]
	public PostEffectsBase()
	{
	}
}
[Token(Token = "0x200003F")]
[Attribute(Name = "RequireComponent", RVA = "0xBD7B28", Offset = "0xBD7B28")]
[ExecuteInEditMode]
internal class PostEffectsHelper : MonoBehaviour
{
	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x2BD1EC4", Offset = "0x2BD1EC4", VA = "0x2BD1EC4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x2BD1F38", Offset = "0x2BD1F38", VA = "0x2BD1F38")]
	private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x2BD2190", Offset = "0x2BD2190", VA = "0x2BD2190")]
	private static void DrawBorder(RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x2BD2508", Offset = "0x2BD2508", VA = "0x2BD2508")]
	private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x2BD26B0", Offset = "0x2BD26B0", VA = "0x2BD26B0")]
	public PostEffectsHelper()
	{
	}
}
[Token(Token = "0x2000040")]
internal class Quads
{
	[Token(Token = "0x4000236")]
	[FieldOffset(Offset = "0x0")]
	private static Mesh[] meshes;

	[Token(Token = "0x4000237")]
	[FieldOffset(Offset = "0x8")]
	private static int currentQuads;

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x2BD26B8", Offset = "0x2BD26B8", VA = "0x2BD26B8")]
	private static bool HasMeshes()
	{
		return default(bool);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x2BD27E4", Offset = "0x2BD27E4", VA = "0x2BD27E4")]
	public static void Cleanup()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x2BD29DC", Offset = "0x2BD29DC", VA = "0x2BD29DC")]
	public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x2BD2C74", Offset = "0x2BD2C74", VA = "0x2BD2C74")]
	private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x2BD3020", Offset = "0x2BD3020", VA = "0x2BD3020")]
	public Quads()
	{
	}
}
[Token(Token = "0x2000041")]
[Attribute(Name = "RequireComponent", RVA = "0xBD7BA0", Offset = "0xBD7BA0")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD7BA0", Offset = "0xBD7BA0")]
[ExecuteInEditMode]
public class ScreenOverlay : PostEffectsBase
{
	[Token(Token = "0x2000042")]
	public enum OverlayBlendMode
	{
		[Token(Token = "0x400023E")]
		Additive,
		[Token(Token = "0x400023F")]
		ScreenBlend,
		[Token(Token = "0x4000240")]
		Multiply,
		[Token(Token = "0x4000241")]
		Overlay,
		[Token(Token = "0x4000242")]
		AlphaBlend
	}

	[Token(Token = "0x4000238")]
	[FieldOffset(Offset = "0x28")]
	public OverlayBlendMode blendMode;

	[Token(Token = "0x4000239")]
	[FieldOffset(Offset = "0x2C")]
	public float intensity;

	[Token(Token = "0x400023A")]
	[FieldOffset(Offset = "0x30")]
	public Texture2D texture;

	[Token(Token = "0x400023B")]
	[FieldOffset(Offset = "0x38")]
	public Shader overlayShader;

	[Token(Token = "0x400023C")]
	[FieldOffset(Offset = "0x40")]
	private Material overlayMaterial;

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x2BD302C", Offset = "0x2BD302C", VA = "0x2BD302C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x2BD3098", Offset = "0x2BD3098", VA = "0x2BD3098")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x2BD3218", Offset = "0x2BD3218", VA = "0x2BD3218")]
	public ScreenOverlay()
	{
	}
}
[Token(Token = "0x2000043")]
[Attribute(Name = "RequireComponent", RVA = "0xBD7C3C", Offset = "0xBD7C3C")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD7C3C", Offset = "0xBD7C3C")]
[ExecuteInEditMode]
internal class ScreenSpaceAmbientObscurance : PostEffectsBase
{
	[Token(Token = "0x4000243")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8820", Offset = "0xBD8820")]
	public float intensity;

	[Token(Token = "0x4000244")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8838", Offset = "0xBD8838")]
	public float radius;

	[Token(Token = "0x4000245")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8854", Offset = "0xBD8854")]
	public int blurIterations;

	[Token(Token = "0x4000246")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD886C", Offset = "0xBD886C")]
	public float blurFilterDistance;

	[Token(Token = "0x4000247")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8884", Offset = "0xBD8884")]
	public int downsample;

	[Token(Token = "0x4000248")]
	[FieldOffset(Offset = "0x40")]
	public Texture2D rand;

	[Token(Token = "0x4000249")]
	[FieldOffset(Offset = "0x48")]
	public Shader aoShader;

	[Token(Token = "0x400024A")]
	[FieldOffset(Offset = "0x50")]
	private Material aoMaterial;

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x2BD3228", Offset = "0x2BD3228", VA = "0x2BD3228", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x2BD329C", Offset = "0x2BD329C", VA = "0x2BD329C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x2BD3348", Offset = "0x2BD3348", VA = "0x2BD3348")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x2BD3B90", Offset = "0x2BD3B90", VA = "0x2BD3B90")]
	public ScreenSpaceAmbientObscurance()
	{
	}
}
[Token(Token = "0x2000044")]
[Attribute(Name = "RequireComponent", RVA = "0xBD7CD8", Offset = "0xBD7CD8")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD7CD8", Offset = "0xBD7CD8")]
public class ScreenSpaceAmbientOcclusion : MonoBehaviour
{
	[Token(Token = "0x2000045")]
	public enum SSAOSamples
	{
		[Token(Token = "0x4000257")]
		Low,
		[Token(Token = "0x4000258")]
		Medium,
		[Token(Token = "0x4000259")]
		High
	}

	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD889C", Offset = "0xBD889C")]
	public float m_Radius;

	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0x1C")]
	public SSAOSamples m_SampleCount;

	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD88B8", Offset = "0xBD88B8")]
	public float m_OcclusionIntensity;

	[Token(Token = "0x400024E")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD88D0", Offset = "0xBD88D0")]
	public int m_Blur;

	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD88E8", Offset = "0xBD88E8")]
	public int m_Downsampling;

	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8900", Offset = "0xBD8900")]
	public float m_OcclusionAttenuation;

	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD891C", Offset = "0xBD891C")]
	public float m_MinZ;

	[Token(Token = "0x4000252")]
	[FieldOffset(Offset = "0x38")]
	public Shader m_SSAOShader;

	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0x40")]
	private Material m_SSAOMaterial;

	[Token(Token = "0x4000254")]
	[FieldOffset(Offset = "0x48")]
	public Texture2D m_RandomTexture;

	[Token(Token = "0x4000255")]
	[FieldOffset(Offset = "0x50")]
	private bool m_Supported;

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x2BD3BAC", Offset = "0x2BD3BAC", VA = "0x2BD3BAC")]
	private static Material CreateMaterial(Shader shader)
	{
		return null;
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x2BD3C6C", Offset = "0x2BD3C6C", VA = "0x2BD3C6C")]
	private static void DestroyMaterial(Material mat)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x2BD3D10", Offset = "0x2BD3D10", VA = "0x2BD3D10")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x2BD3D18", Offset = "0x2BD3D18", VA = "0x2BD3D18")]
	private void Start()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x2BD3ED0", Offset = "0x2BD3ED0", VA = "0x2BD3ED0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x2BD3DEC", Offset = "0x2BD3DEC", VA = "0x2BD3DEC")]
	private void CreateMaterials()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x2BD3F48", Offset = "0x2BD3F48", VA = "0x2BD3F48")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x2BD45B8", Offset = "0x2BD45B8", VA = "0x2BD45B8")]
	public ScreenSpaceAmbientOcclusion()
	{
	}
}
[Token(Token = "0x2000046")]
public enum SSRDebugMode
{
	[Token(Token = "0x400025B")]
	None,
	[Token(Token = "0x400025C")]
	IncomingRadiance,
	[Token(Token = "0x400025D")]
	SSRResult,
	[Token(Token = "0x400025E")]
	FinalGlossyTerm,
	[Token(Token = "0x400025F")]
	SSRMask,
	[Token(Token = "0x4000260")]
	Roughness,
	[Token(Token = "0x4000261")]
	BaseColor,
	[Token(Token = "0x4000262")]
	SpecColor,
	[Token(Token = "0x4000263")]
	Reflectivity,
	[Token(Token = "0x4000264")]
	ReflectionProbeOnly,
	[Token(Token = "0x4000265")]
	ReflectionProbeMinusSSR,
	[Token(Token = "0x4000266")]
	SSRMinusReflectionProbe,
	[Token(Token = "0x4000267")]
	NoGlossy,
	[Token(Token = "0x4000268")]
	NegativeNoGlossy,
	[Token(Token = "0x4000269")]
	MipLevel
}
[Token(Token = "0x2000047")]
public enum PassIndex
{
	[Token(Token = "0x400026B")]
	RayTraceStep1,
	[Token(Token = "0x400026C")]
	RayTraceStep2,
	[Token(Token = "0x400026D")]
	RayTraceStep4,
	[Token(Token = "0x400026E")]
	RayTraceStep8,
	[Token(Token = "0x400026F")]
	RayTraceStep16,
	[Token(Token = "0x4000270")]
	CompositeFinal,
	[Token(Token = "0x4000271")]
	Blur,
	[Token(Token = "0x4000272")]
	CompositeSSR,
	[Token(Token = "0x4000273")]
	Blit,
	[Token(Token = "0x4000274")]
	EdgeGeneration,
	[Token(Token = "0x4000275")]
	MinMipGeneration,
	[Token(Token = "0x4000276")]
	HitPointToReflections,
	[Token(Token = "0x4000277")]
	BilateralKeyPack
}
[Token(Token = "0x2000048")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD7D74", Offset = "0xBD7D74")]
[Attribute(Name = "RequireComponent", RVA = "0xBD7D74", Offset = "0xBD7D74")]
[ExecuteInEditMode]
public class ScreenSpaceReflection : PostEffectsBase
{
	[Token(Token = "0x4000278")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8938", Offset = "0xBD8938")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8938", Offset = "0xBD8938")]
	public int maxSteps;

	[Token(Token = "0x4000279")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8990", Offset = "0xBD8990")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8990", Offset = "0xBD8990")]
	public int rayPixelsStep;

	[Token(Token = "0x400027A")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD89E4", Offset = "0xBD89E4")]
	public bool halfResolution;

	[Token(Token = "0x400027B")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8A1C", Offset = "0xBD8A1C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8A1C", Offset = "0xBD8A1C")]
	public float maxDistance;

	[Token(Token = "0x400027C")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8A74", Offset = "0xBD8A74")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8A74", Offset = "0xBD8A74")]
	public float fadeDistance;

	[Token(Token = "0x400027D")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8ACC", Offset = "0xBD8ACC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8ACC", Offset = "0xBD8ACC")]
	public float expectedWallThicknessMeters;

	[Token(Token = "0x400027E")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8B24", Offset = "0xBD8B24")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8B24", Offset = "0xBD8B24")]
	public float screenEdgeFading;

	[Token(Token = "0x400027F")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8B78", Offset = "0xBD8B78")]
	public bool additiveReflection;

	[Token(Token = "0x4000280")]
	[FieldOffset(Offset = "0x45")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8BB0", Offset = "0xBD8BB0")]
	public bool improveCorners;

	[Token(Token = "0x4000281")]
	[FieldOffset(Offset = "0x46")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8BE8", Offset = "0xBD8BE8")]
	public bool reduceBanding;

	[Token(Token = "0x4000282")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8C20", Offset = "0xBD8C20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8C20", Offset = "0xBD8C20")]
	public float reflectionMultiplier;

	[Token(Token = "0x4000283")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8C74", Offset = "0xBD8C74")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8C74", Offset = "0xBD8C74")]
	private float mipBias;

	[Token(Token = "0x4000284")]
	[FieldOffset(Offset = "0x50")]
	private bool useOcclusion;

	[Token(Token = "0x4000285")]
	[FieldOffset(Offset = "0x51")]
	private bool fullResolutionFiltering;

	[Token(Token = "0x4000286")]
	[FieldOffset(Offset = "0x52")]
	private bool fallbackToSky;

	[Token(Token = "0x4000287")]
	[FieldOffset(Offset = "0x53")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8CC8", Offset = "0xBD8CC8")]
	public bool treatBackfaceHitAsMiss;

	[Token(Token = "0x4000288")]
	[FieldOffset(Offset = "0x54")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8D00", Offset = "0xBD8D00")]
	public bool suppressBackwardsRays;

	[Token(Token = "0x4000289")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8D38", Offset = "0xBD8D38")]
	public SSRDebugMode m_DebugMode;

	[Token(Token = "0x400028A")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8D70", Offset = "0xBD8D70")]
	public bool enableSSR;

	[Token(Token = "0x400028B")]
	[FieldOffset(Offset = "0x5D")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8DA8", Offset = "0xBD8DA8")]
	private bool useEdgeDetector;

	[Token(Token = "0x400028C")]
	[FieldOffset(Offset = "0x5E")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8DE0", Offset = "0xBD8DE0")]
	public bool useHDRIntermediates;

	[Token(Token = "0x400028D")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8E18", Offset = "0xBD8E18")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8E18", Offset = "0xBD8E18")]
	public float minSmoothness;

	[Token(Token = "0x400028E")]
	[FieldOffset(Offset = "0x64")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8E6C", Offset = "0xBD8E6C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8E6C", Offset = "0xBD8E6C")]
	public float smoothnessFalloffRange;

	[Token(Token = "0x400028F")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8EC4", Offset = "0xBD8EC4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8EC4", Offset = "0xBD8EC4")]
	public float distanceBlur;

	[Token(Token = "0x4000290")]
	[FieldOffset(Offset = "0x6C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8F18", Offset = "0xBD8F18")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8F18", Offset = "0xBD8F18")]
	public float fresnelFade;

	[Token(Token = "0x4000291")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD8F6C", Offset = "0xBD8F6C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8F6C", Offset = "0xBD8F6C")]
	public float fresnelFadePower;

	[Token(Token = "0x4000292")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8FC4", Offset = "0xBD8FC4")]
	public bool bilateralUpsample;

	[Token(Token = "0x4000293")]
	[FieldOffset(Offset = "0x75")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD8FFC", Offset = "0xBD8FFC")]
	public bool fullResResolve;

	[Token(Token = "0x4000294")]
	[FieldOffset(Offset = "0x76")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xBD9034", Offset = "0xBD9034")]
	public bool traceEverywhere;

	[Token(Token = "0x4000295")]
	[FieldOffset(Offset = "0x78")]
	public Shader ssrShader;

	[Token(Token = "0x4000296")]
	[FieldOffset(Offset = "0x80")]
	private Material ssrMaterial;

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x2BD45EC", Offset = "0x2BD45EC", VA = "0x2BD45EC", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x2BD4660", Offset = "0x2BD4660", VA = "0x2BD4660")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x2BD470C", Offset = "0x2BD470C", VA = "0x2BD470C")]
	[ImageEffectOpaque]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x2BD5CB8", Offset = "0x2BD5CB8", VA = "0x2BD5CB8")]
	public ScreenSpaceReflection()
	{
	}
}
[Token(Token = "0x2000049")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD7E10", Offset = "0xBD7E10")]
[ExecuteInEditMode]
public class SepiaTone : ImageEffectBase
{
	[Token(Token = "0x6000102")]
	[Address(RVA = "0x2BD5D18", Offset = "0x2BD5D18", VA = "0x2BD5D18")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x2BD5DAC", Offset = "0x2BD5DAC", VA = "0x2BD5DAC")]
	public SepiaTone()
	{
	}
}
[Token(Token = "0x200004A")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD7E5C", Offset = "0xBD7E5C")]
[Attribute(Name = "RequireComponent", RVA = "0xBD7E5C", Offset = "0xBD7E5C")]
[ExecuteInEditMode]
public class SunShafts : PostEffectsBase
{
	[Token(Token = "0x200004B")]
	public enum SunShaftsResolution
	{
		[Token(Token = "0x40002A6")]
		Low,
		[Token(Token = "0x40002A7")]
		Normal,
		[Token(Token = "0x40002A8")]
		High
	}

	[Token(Token = "0x200004C")]
	public enum ShaftsScreenBlendMode
	{
		[Token(Token = "0x40002AA")]
		Screen,
		[Token(Token = "0x40002AB")]
		Add
	}

	[Token(Token = "0x4000297")]
	[FieldOffset(Offset = "0x28")]
	public SunShaftsResolution resolution;

	[Token(Token = "0x4000298")]
	[FieldOffset(Offset = "0x2C")]
	public ShaftsScreenBlendMode screenBlendMode;

	[Token(Token = "0x4000299")]
	[FieldOffset(Offset = "0x30")]
	public Transform sunTransform;

	[Token(Token = "0x400029A")]
	[FieldOffset(Offset = "0x38")]
	public int radialBlurIterations;

	[Token(Token = "0x400029B")]
	[FieldOffset(Offset = "0x3C")]
	public Color sunColor;

	[Token(Token = "0x400029C")]
	[FieldOffset(Offset = "0x4C")]
	public Color sunThreshold;

	[Token(Token = "0x400029D")]
	[FieldOffset(Offset = "0x5C")]
	public float sunShaftBlurRadius;

	[Token(Token = "0x400029E")]
	[FieldOffset(Offset = "0x60")]
	public float sunShaftIntensity;

	[Token(Token = "0x400029F")]
	[FieldOffset(Offset = "0x64")]
	public float maxRadius;

	[Token(Token = "0x40002A0")]
	[FieldOffset(Offset = "0x68")]
	public bool useDepthTexture;

	[Token(Token = "0x40002A1")]
	[FieldOffset(Offset = "0x70")]
	public Shader sunShaftsShader;

	[Token(Token = "0x40002A2")]
	[FieldOffset(Offset = "0x78")]
	private Material sunShaftsMaterial;

	[Token(Token = "0x40002A3")]
	[FieldOffset(Offset = "0x80")]
	public Shader simpleClearShader;

	[Token(Token = "0x40002A4")]
	[FieldOffset(Offset = "0x88")]
	private Material simpleClearMaterial;

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x2BD5DB4", Offset = "0x2BD5DB4", VA = "0x2BD5DB4", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x2BD5E44", Offset = "0x2BD5E44", VA = "0x2BD5E44")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x2BD6614", Offset = "0x2BD6614", VA = "0x2BD6614")]
	public SunShafts()
	{
	}
}
[Token(Token = "0x200004D")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD7EF8", Offset = "0xBD7EF8")]
[Attribute(Name = "RequireComponent", RVA = "0xBD7EF8", Offset = "0xBD7EF8")]
internal class TiltShift : PostEffectsBase
{
	[Token(Token = "0x200004E")]
	public enum TiltShiftMode
	{
		[Token(Token = "0x40002B4")]
		TiltShiftMode,
		[Token(Token = "0x40002B5")]
		IrisMode
	}

	[Token(Token = "0x200004F")]
	public enum TiltShiftQuality
	{
		[Token(Token = "0x40002B7")]
		Preview,
		[Token(Token = "0x40002B8")]
		Low,
		[Token(Token = "0x40002B9")]
		Normal,
		[Token(Token = "0x40002BA")]
		High
	}

	[Token(Token = "0x40002AC")]
	[FieldOffset(Offset = "0x28")]
	public TiltShiftMode mode;

	[Token(Token = "0x40002AD")]
	[FieldOffset(Offset = "0x2C")]
	public TiltShiftQuality quality;

	[Token(Token = "0x40002AE")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD906C", Offset = "0xBD906C")]
	public float blurArea;

	[Token(Token = "0x40002AF")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD9084", Offset = "0xBD9084")]
	public float maxBlurSize;

	[Token(Token = "0x40002B0")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD909C", Offset = "0xBD909C")]
	public int downsample;

	[Token(Token = "0x40002B1")]
	[FieldOffset(Offset = "0x40")]
	public Shader tiltShiftShader;

	[Token(Token = "0x40002B2")]
	[FieldOffset(Offset = "0x48")]
	private Material tiltShiftMaterial;

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x2BD66A8", Offset = "0x2BD66A8", VA = "0x2BD66A8", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x2BD6714", Offset = "0x2BD6714", VA = "0x2BD6714")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x2BD69C8", Offset = "0x2BD69C8", VA = "0x2BD69C8")]
	public TiltShift()
	{
	}
}
[Token(Token = "0x2000050")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD7F84", Offset = "0xBD7F84")]
[Attribute(Name = "RequireComponent", RVA = "0xBD7F84", Offset = "0xBD7F84")]
public class Tonemapping : PostEffectsBase
{
	[Token(Token = "0x2000051")]
	public enum TonemapperType
	{
		[Token(Token = "0x40002C9")]
		SimpleReinhard,
		[Token(Token = "0x40002CA")]
		UserCurve,
		[Token(Token = "0x40002CB")]
		Hable,
		[Token(Token = "0x40002CC")]
		Photographic,
		[Token(Token = "0x40002CD")]
		OptimizedHejiDawson,
		[Token(Token = "0x40002CE")]
		AdaptiveReinhard,
		[Token(Token = "0x40002CF")]
		AdaptiveReinhardAutoWhite
	}

	[Token(Token = "0x2000052")]
	public enum AdaptiveTexSize
	{
		[Token(Token = "0x40002D1")]
		Square16 = 0x10,
		[Token(Token = "0x40002D2")]
		Square32 = 0x20,
		[Token(Token = "0x40002D3")]
		Square64 = 0x40,
		[Token(Token = "0x40002D4")]
		Square128 = 0x80,
		[Token(Token = "0x40002D5")]
		Square256 = 0x100,
		[Token(Token = "0x40002D6")]
		Square512 = 0x200,
		[Token(Token = "0x40002D7")]
		Square1024 = 0x400
	}

	[Token(Token = "0x40002BB")]
	[FieldOffset(Offset = "0x28")]
	public TonemapperType type;

	[Token(Token = "0x40002BC")]
	[FieldOffset(Offset = "0x2C")]
	public AdaptiveTexSize adaptiveTextureSize;

	[Token(Token = "0x40002BD")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve remapCurve;

	[Token(Token = "0x40002BE")]
	[FieldOffset(Offset = "0x38")]
	private Texture2D curveTex;

	[Token(Token = "0x40002BF")]
	[FieldOffset(Offset = "0x40")]
	public float exposureAdjustment;

	[Token(Token = "0x40002C0")]
	[FieldOffset(Offset = "0x44")]
	public float middleGrey;

	[Token(Token = "0x40002C1")]
	[FieldOffset(Offset = "0x48")]
	public float white;

	[Token(Token = "0x40002C2")]
	[FieldOffset(Offset = "0x4C")]
	public float adaptionSpeed;

	[Token(Token = "0x40002C3")]
	[FieldOffset(Offset = "0x50")]
	public Shader tonemapper;

	[Token(Token = "0x40002C4")]
	[FieldOffset(Offset = "0x58")]
	public bool validRenderTextureFormat;

	[Token(Token = "0x40002C5")]
	[FieldOffset(Offset = "0x60")]
	private Material tonemapMaterial;

	[Token(Token = "0x40002C6")]
	[FieldOffset(Offset = "0x68")]
	private RenderTexture rt;

	[Token(Token = "0x40002C7")]
	[FieldOffset(Offset = "0x70")]
	private RenderTextureFormat rtFormat;

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x2BD69E0", Offset = "0x2BD69E0", VA = "0x2BD69E0", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x2BD6B4C", Offset = "0x2BD6B4C", VA = "0x2BD6B4C")]
	public float UpdateCurve()
	{
		return default(float);
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x2BD6DF8", Offset = "0x2BD6DF8", VA = "0x2BD6DF8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x2BD6F84", Offset = "0x2BD6F84", VA = "0x2BD6F84")]
	private bool CreateInternalRenderTexture()
	{
		return default(bool);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x2BD708C", Offset = "0x2BD708C", VA = "0x2BD708C")]
	[ImageEffectTransformsToLDR]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x2BD7894", Offset = "0x2BD7894", VA = "0x2BD7894")]
	public Tonemapping()
	{
	}
}
[Token(Token = "0x2000053")]
internal class Triangles
{
	[Token(Token = "0x40002D8")]
	[FieldOffset(Offset = "0x0")]
	private static Mesh[] meshes;

	[Token(Token = "0x40002D9")]
	[FieldOffset(Offset = "0x8")]
	private static int currentTris;

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x2BDC128", Offset = "0x2BDC128", VA = "0x2BDC128")]
	private static bool HasMeshes()
	{
		return default(bool);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x2BDC26C", Offset = "0x2BDC26C", VA = "0x2BDC26C")]
	private static void Cleanup()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x2BDC464", Offset = "0x2BDC464", VA = "0x2BDC464")]
	private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x2BDC6FC", Offset = "0x2BDC6FC", VA = "0x2BDC6FC")]
	private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x2BDCA04", Offset = "0x2BDCA04", VA = "0x2BDCA04")]
	public Triangles()
	{
	}
}
[Token(Token = "0x2000054")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD8020", Offset = "0xBD8020")]
[ExecuteInEditMode]
public class Twirl : ImageEffectBase
{
	[Token(Token = "0x40002DA")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 radius;

	[Token(Token = "0x40002DB")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "RangeAttribute", RVA = "0xBD90B4", Offset = "0xBD90B4")]
	public float angle;

	[Token(Token = "0x40002DC")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 center;

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x2C9BD0C", Offset = "0x2C9BD0C", VA = "0x2C9BD0C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x2C9BD58", Offset = "0x2C9BD58", VA = "0x2C9BD58")]
	public Twirl()
	{
	}
}
[Token(Token = "0x2000055")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xBD806C", Offset = "0xBD806C")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD806C", Offset = "0xBD806C")]
public class VignetteAndChromaticAberration : PostEffectsBase
{
	[Token(Token = "0x2000056")]
	public enum AberrationMode
	{
		[Token(Token = "0x40002EC")]
		Simple,
		[Token(Token = "0x40002ED")]
		Advanced
	}

	[Token(Token = "0x40002DD")]
	[FieldOffset(Offset = "0x28")]
	public AberrationMode mode;

	[Token(Token = "0x40002DE")]
	[FieldOffset(Offset = "0x2C")]
	public float intensity;

	[Token(Token = "0x40002DF")]
	[FieldOffset(Offset = "0x30")]
	public float chromaticAberration;

	[Token(Token = "0x40002E0")]
	[FieldOffset(Offset = "0x34")]
	public float axialAberration;

	[Token(Token = "0x40002E1")]
	[FieldOffset(Offset = "0x38")]
	public float blur;

	[Token(Token = "0x40002E2")]
	[FieldOffset(Offset = "0x3C")]
	public float blurSpread;

	[Token(Token = "0x40002E3")]
	[FieldOffset(Offset = "0x40")]
	public float luminanceDependency;

	[Token(Token = "0x40002E4")]
	[FieldOffset(Offset = "0x44")]
	public float blurDistance;

	[Token(Token = "0x40002E5")]
	[FieldOffset(Offset = "0x48")]
	public Shader vignetteShader;

	[Token(Token = "0x40002E6")]
	[FieldOffset(Offset = "0x50")]
	public Shader separableBlurShader;

	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x58")]
	public Shader chromAberrationShader;

	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x60")]
	private Material m_VignetteMaterial;

	[Token(Token = "0x40002E9")]
	[FieldOffset(Offset = "0x68")]
	private Material m_SeparableBlurMaterial;

	[Token(Token = "0x40002EA")]
	[FieldOffset(Offset = "0x70")]
	private Material m_ChromAberrationMaterial;

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x2C9BD74", Offset = "0x2C9BD74", VA = "0x2C9BD74", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x2C9BE3C", Offset = "0x2C9BE3C", VA = "0x2C9BE3C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x2C9C41C", Offset = "0x2C9C41C", VA = "0x2C9C41C")]
	public VignetteAndChromaticAberration()
	{
	}
}
[Token(Token = "0x2000057")]
[Attribute(Name = "AddComponentMenu", RVA = "0xBD8108", Offset = "0xBD8108")]
[ExecuteInEditMode]
public class Vortex : ImageEffectBase
{
	[Token(Token = "0x40002EE")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 radius;

	[Token(Token = "0x40002EF")]
	[FieldOffset(Offset = "0x30")]
	public float angle;

	[Token(Token = "0x40002F0")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 center;

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x2C9C44C", Offset = "0x2C9C44C", VA = "0x2C9C44C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x2C9C498", Offset = "0x2C9C498", VA = "0x2C9C498")]
	public Vortex()
	{
	}
}
