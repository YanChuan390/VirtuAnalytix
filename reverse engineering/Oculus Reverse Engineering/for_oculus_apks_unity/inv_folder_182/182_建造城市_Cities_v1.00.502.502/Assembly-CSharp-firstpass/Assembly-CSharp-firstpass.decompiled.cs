using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityStandardAssets.ImageEffects;

[Token(Token = "0x2000002")]
public enum AAMode
{
	[Token(Token = "0x4000002")]
	FXAA2,
	[Token(Token = "0x4000003")]
	FXAA3Console,
	[Token(Token = "0x4000004")]
	FXAA1PresetA,
	[Token(Token = "0x4000005")]
	FXAA1PresetB,
	[Token(Token = "0x4000006")]
	NFAA,
	[Token(Token = "0x4000007")]
	SSAA,
	[Token(Token = "0x4000008")]
	DLAA
}
[Token(Token = "0x2000003")]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Other/Antialiasing")]
[RequireComponent(typeof(Camera))]
public class Antialiasing : PostEffectsBase
{
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x1C")]
	public AAMode mode;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x20")]
	public bool showGeneratedNormals;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x24")]
	public float offsetScale;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x28")]
	public float blurRadius;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x2C")]
	public float edgeThresholdMin;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x30")]
	public float edgeThreshold;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x34")]
	public float edgeSharpness;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x38")]
	public bool dlaaSharp;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x40")]
	public Shader ssaaShader;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x48")]
	private Material ssaa;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x50")]
	public Shader dlaaShader;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x58")]
	private Material dlaa;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x60")]
	public Shader nfaaShader;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x68")]
	private Material nfaa;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x70")]
	public Shader shaderFXAAPreset2;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x78")]
	private Material materialFXAAPreset2;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x80")]
	public Shader shaderFXAAPreset3;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x88")]
	private Material materialFXAAPreset3;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x90")]
	public Shader shaderFXAAII;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x98")]
	private Material materialFXAAII;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0xA0")]
	public Shader shaderFXAAIII;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0xA8")]
	private Material materialFXAAIII;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xB3966C", Offset = "0xB3966C", VA = "0xB3966C")]
	public Material CurrentAAMaterial()
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xB396D4", Offset = "0xB396D4", VA = "0xB396D4", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xB397B4", Offset = "0xB397B4", VA = "0xB397B4")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xB39C78", Offset = "0xB39C78", VA = "0xB39C78")]
	public Antialiasing()
	{
	}
}
[Token(Token = "0x2000004")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
public class Bloom : PostEffectsBase
{
	[Token(Token = "0x2000005")]
	public enum LensFlareStyle
	{
		[Token(Token = "0x400003E")]
		Ghosting,
		[Token(Token = "0x400003F")]
		Anamorphic,
		[Token(Token = "0x4000040")]
		Combined
	}

	[Token(Token = "0x2000006")]
	public enum TweakMode
	{
		[Token(Token = "0x4000042")]
		Basic,
		[Token(Token = "0x4000043")]
		Complex
	}

	[Token(Token = "0x2000007")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x4000045")]
		Auto,
		[Token(Token = "0x4000046")]
		On,
		[Token(Token = "0x4000047")]
		Off
	}

	[Token(Token = "0x2000008")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x4000049")]
		Screen,
		[Token(Token = "0x400004A")]
		Add
	}

	[Token(Token = "0x2000009")]
	public enum BloomQuality
	{
		[Token(Token = "0x400004C")]
		Cheap,
		[Token(Token = "0x400004D")]
		High
	}

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x1C")]
	public TweakMode tweakMode;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x20")]
	public BloomScreenBlendMode screenBlendMode;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x24")]
	public HDRBloomMode hdr;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x28")]
	private bool doHdr;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x2C")]
	public float sepBlurSpread;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x30")]
	public BloomQuality quality;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x34")]
	public float bloomIntensity;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x38")]
	public float bloomThreshold;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x3C")]
	public Color bloomThresholdColor;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x4C")]
	public int bloomBlurIterations;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x50")]
	public int hollywoodFlareBlurIterations;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x54")]
	public float flareRotation;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x58")]
	public LensFlareStyle lensflareMode;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x5C")]
	public float hollyStretchWidth;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x60")]
	public float lensflareIntensity;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x64")]
	public float lensflareThreshold;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x68")]
	public float lensFlareSaturation;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x6C")]
	public Color flareColorA;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x7C")]
	public Color flareColorB;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x8C")]
	public Color flareColorC;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x9C")]
	public Color flareColorD;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0xB0")]
	public Texture2D lensFlareVignetteMask;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0xB8")]
	public Shader lensFlareShader;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0xC0")]
	private Material lensFlareMaterial;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0xC8")]
	public Shader screenBlendShader;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0xD0")]
	private Material screenBlend;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0xD8")]
	public Shader blurAndFlaresShader;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0xE0")]
	private Material blurAndFlaresMaterial;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0xE8")]
	public Shader brightPassFilterShader;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0xF0")]
	private Material brightPassFilterMaterial;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xB39C9C", Offset = "0xB39C9C", VA = "0xB39C9C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xB39DFC", Offset = "0xB39DFC", VA = "0xB39DFC", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xB39E90", Offset = "0xB39E90", VA = "0xB39E90")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xB3B000", Offset = "0xB3B000", VA = "0xB3B000")]
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xB3AE68", Offset = "0xB3AE68", VA = "0xB3AE68")]
	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xB3ABBC", Offset = "0xB3ABBC", VA = "0xB3ABBC")]
	private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xB3AAE8", Offset = "0xB3AAE8", VA = "0xB3AAE8")]
	private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xB3AC7C", Offset = "0xB3AC7C", VA = "0xB3AC7C")]
	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xB3B0C4", Offset = "0xB3B0C4", VA = "0xB3B0C4")]
	public Bloom()
	{
	}
}
[Token(Token = "0x200000A")]
public enum LensflareStyle34
{
	[Token(Token = "0x400004F")]
	Ghosting,
	[Token(Token = "0x4000050")]
	Anamorphic,
	[Token(Token = "0x4000051")]
	Combined
}
[Token(Token = "0x200000B")]
public enum TweakMode34
{
	[Token(Token = "0x4000053")]
	Basic,
	[Token(Token = "0x4000054")]
	Complex
}
[Token(Token = "0x200000C")]
public enum HDRBloomMode
{
	[Token(Token = "0x4000056")]
	Auto,
	[Token(Token = "0x4000057")]
	On,
	[Token(Token = "0x4000058")]
	Off
}
[Token(Token = "0x200000D")]
public enum BloomScreenBlendMode
{
	[Token(Token = "0x400005A")]
	Screen,
	[Token(Token = "0x400005B")]
	Add
}
[Token(Token = "0x200000E")]
[AddComponentMenu("Image Effects/Bloom and Glow/BloomAndFlares (3.5, Deprecated)")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class BloomAndFlares : PostEffectsBase
{
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x1C")]
	public TweakMode34 tweakMode;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x20")]
	public BloomScreenBlendMode screenBlendMode;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x24")]
	public HDRBloomMode hdr;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x28")]
	private bool doHdr;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x2C")]
	public float sepBlurSpread;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x30")]
	public float useSrcAlphaAsMask;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x34")]
	public float bloomIntensity;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x38")]
	public float bloomThreshold;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x3C")]
	public int bloomBlurIterations;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x40")]
	public bool lensflares;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x44")]
	public int hollywoodFlareBlurIterations;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x48")]
	public LensflareStyle34 lensflareMode;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x4C")]
	public float hollyStretchWidth;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x50")]
	public float lensflareIntensity;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x54")]
	public float lensflareThreshold;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x58")]
	public Color flareColorA;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x68")]
	public Color flareColorB;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x78")]
	public Color flareColorC;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x88")]
	public Color flareColorD;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x98")]
	public Texture2D lensFlareVignetteMask;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0xA0")]
	public Shader lensFlareShader;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0xA8")]
	private Material lensFlareMaterial;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0xB0")]
	public Shader vignetteShader;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0xB8")]
	private Material vignetteMaterial;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0xC0")]
	public Shader separableBlurShader;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0xC8")]
	private Material separableBlurMaterial;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0xD0")]
	public Shader addBrightStuffOneOneShader;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0xD8")]
	private Material addBrightStuffBlendOneOneMaterial;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0xE0")]
	public Shader screenBlendShader;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0xE8")]
	private Material screenBlend;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0xF0")]
	public Shader hollywoodFlaresShader;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0xF8")]
	private Material hollywoodFlaresMaterial;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x100")]
	public Shader brightPassFilterShader;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x108")]
	private Material brightPassFilterMaterial;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xB3B14C", Offset = "0xB3B14C", VA = "0xB3B14C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xB3B21C", Offset = "0xB3B21C", VA = "0xB3B21C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xB3BFDC", Offset = "0xB3BFDC", VA = "0xB3BFDC")]
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xB3BE54", Offset = "0xB3BE54", VA = "0xB3BE54")]
	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xB3BBFC", Offset = "0xB3BBFC", VA = "0xB3BBFC")]
	private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xB3BD04", Offset = "0xB3BD04", VA = "0xB3BD04")]
	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xB3C08C", Offset = "0xB3C08C", VA = "0xB3C08C")]
	public BloomAndFlares()
	{
	}
}
[Token(Token = "0x200000F")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
public class BloomOptimized : PostEffectsBase
{
	[Token(Token = "0x2000010")]
	public enum Resolution
	{
		[Token(Token = "0x4000087")]
		Low,
		[Token(Token = "0x4000088")]
		High
	}

	[Token(Token = "0x2000011")]
	public enum BlurType
	{
		[Token(Token = "0x400008A")]
		Standard,
		[Token(Token = "0x400008B")]
		Sgx
	}

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x1C")]
	[Range(0f, 1.5f)]
	public float threshold;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x20")]
	[Range(0f, 2.5f)]
	public float intensity;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x24")]
	[Range(0.25f, 5.5f)]
	public float blurSize;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x28")]
	private Resolution resolution;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x2C")]
	[Range(1f, 4f)]
	public int blurIterations;

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x30")]
	public BlurType blurType;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x38")]
	public Shader fastBloomShader;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x40")]
	private Material fastBloomMaterial;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xB3C100", Offset = "0xB3C100", VA = "0xB3C100", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xB3C158", Offset = "0xB3C158", VA = "0xB3C158")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xB3C1E4", Offset = "0xB3C1E4", VA = "0xB3C1E4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xB3C554", Offset = "0xB3C554", VA = "0xB3C554")]
	public BloomOptimized()
	{
	}
}
[Token(Token = "0x2000012")]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Blur/Blur")]
public class Blur : MonoBehaviour
{
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x18")]
	public int iterations;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x1C")]
	public float blurSpread;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x20")]
	public Shader blurShader;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x0")]
	private static Material m_Material;

	[Token(Token = "0x17000001")]
	protected Material material
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0xB3C578", Offset = "0xB3C578", VA = "0xB3C578")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xB3C670", Offset = "0xB3C670", VA = "0xB3C670")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xB3C71C", Offset = "0xB3C71C", VA = "0xB3C71C")]
	protected void Start()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xB3C7CC", Offset = "0xB3C7CC", VA = "0xB3C7CC")]
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xB3C8DC", Offset = "0xB3C8DC", VA = "0xB3C8DC")]
	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xB3C9D8", Offset = "0xB3C9D8", VA = "0xB3C9D8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xB3CB34", Offset = "0xB3CB34", VA = "0xB3CB34")]
	public Blur()
	{
	}
}
[Token(Token = "0x2000013")]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
[ExecuteInEditMode]
public class BlurOptimized : PostEffectsBase
{
	[Token(Token = "0x2000014")]
	public enum BlurType
	{
		[Token(Token = "0x4000097")]
		StandardGauss,
		[Token(Token = "0x4000098")]
		SgxGauss
	}

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x1C")]
	[Range(0f, 2f)]
	public int downsample;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x20")]
	[Range(0f, 10f)]
	public float blurSize;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x24")]
	[Range(1f, 4f)]
	public int blurIterations;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x28")]
	public BlurType blurType;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x30")]
	public Shader blurShader;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x38")]
	private Material blurMaterial;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xB3CB4C", Offset = "0xB3CB4C", VA = "0xB3CB4C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xB3CBA4", Offset = "0xB3CBA4", VA = "0xB3CBA4")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xB3CC30", Offset = "0xB3CC30", VA = "0xB3CC30")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xB3CF58", Offset = "0xB3CF58", VA = "0xB3CF58")]
	public BlurOptimized()
	{
	}
}
[Token(Token = "0x2000015")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Camera/Camera Motion Blur")]
public class CameraMotionBlur : PostEffectsBase
{
	[Token(Token = "0x2000016")]
	public enum MotionBlurFilter
	{
		[Token(Token = "0x40000B8")]
		CameraMotion,
		[Token(Token = "0x40000B9")]
		LocalBlur,
		[Token(Token = "0x40000BA")]
		Reconstruction,
		[Token(Token = "0x40000BB")]
		ReconstructionDX11,
		[Token(Token = "0x40000BC")]
		ReconstructionDisc
	}

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x0")]
	private static float MAX_RADIUS;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x1C")]
	public MotionBlurFilter filterType;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x20")]
	public bool preview;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 previewScale;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x30")]
	public float movementScale;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x34")]
	public float rotationScale;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x38")]
	public float maxVelocity;

	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x3C")]
	public float minVelocity;

	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x40")]
	public float velocityScale;

	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x44")]
	public float softZDistance;

	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x48")]
	public int velocityDownsample;

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x4C")]
	public LayerMask excludeLayers;

	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x50")]
	private GameObject tmpCam;

	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x58")]
	public Shader shader;

	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x60")]
	public Shader dx11MotionBlurShader;

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x68")]
	public Shader replacementClear;

	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x70")]
	private Material motionBlurMaterial;

	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x78")]
	private Material dx11MotionBlurMaterial;

	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x80")]
	public Texture2D noiseTexture;

	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x88")]
	public float jitter;

	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x8C")]
	public bool showVelocity;

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x90")]
	public float showVelocityScale;

	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x94")]
	private Matrix4x4 currentViewProjMat;

	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0xD4")]
	private Matrix4x4 prevViewProjMat;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x114")]
	private int prevFrameCount;

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x118")]
	private bool wasActive;

	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x11C")]
	private Vector3 prevFrameForward;

	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x128")]
	private Vector3 prevFrameUp;

	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x134")]
	private Vector3 prevFramePos;

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x140")]
	private Camera _camera;

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xB3CF74", Offset = "0xB3CF74", VA = "0xB3CF74")]
	private void CalculateViewProjection()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xB3D078", Offset = "0xB3D078", VA = "0xB3D078")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xB3D1EC", Offset = "0xB3D1EC", VA = "0xB3D1EC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xB3D2A8", Offset = "0xB3D2A8", VA = "0xB3D2A8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xB3D3CC", Offset = "0xB3D3CC", VA = "0xB3D3CC", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xB3D458", Offset = "0xB3D458", VA = "0xB3D458")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xB3D14C", Offset = "0xB3D14C", VA = "0xB3D14C")]
	private void Remember()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xB3EC08", Offset = "0xB3EC08", VA = "0xB3EC08")]
	private Camera GetTmpCam()
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xB3EB84", Offset = "0xB3EB84", VA = "0xB3EB84")]
	private void StartFrame()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xB3EBF8", Offset = "0xB3EBF8", VA = "0xB3EBF8")]
	private static int divRoundUp(int x, int d)
	{
		return default(int);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xB3EF74", Offset = "0xB3EF74", VA = "0xB3EF74")]
	public CameraMotionBlur()
	{
	}
}
[Token(Token = "0x2000017")]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
public class ColorCorrectionCurves : PostEffectsBase
{
	[Token(Token = "0x2000018")]
	public enum ColorCorrectionMode
	{
		[Token(Token = "0x40000D6")]
		Simple,
		[Token(Token = "0x40000D7")]
		Advanced
	}

	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve redChannel;

	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve greenChannel;

	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve blueChannel;

	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x38")]
	public bool useDepthCorrection;

	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x40")]
	public AnimationCurve zCurve;

	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve depthRedChannel;

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve depthGreenChannel;

	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve depthBlueChannel;

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x60")]
	private Material ccMaterial;

	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x68")]
	private Material ccDepthMaterial;

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x70")]
	private Material selectiveCcMaterial;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x78")]
	private Texture2D rgbChannelTex;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x80")]
	private Texture2D rgbDepthChannelTex;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x88")]
	private Texture2D zCurveTex;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x90")]
	public float saturation;

	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x94")]
	public bool selectiveCc;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x98")]
	public Color selectiveFromColor;

	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0xA8")]
	public Color selectiveToColor;

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0xB8")]
	public ColorCorrectionMode mode;

	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0xBC")]
	public bool updateTextures;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0xC0")]
	public Shader colorCorrectionCurvesShader;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0xC8")]
	public Shader simpleColorCorrectionCurvesShader;

	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0xD0")]
	public Shader colorCorrectionSelectiveShader;

	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0xD8")]
	private bool updateTexturesOnStartup;

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xB3F114", Offset = "0xB3F114", VA = "0xB3F114")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xB3F134", Offset = "0xB3F134", VA = "0xB3F134")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xB3F138", Offset = "0xB3F138", VA = "0xB3F138", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xB3F394", Offset = "0xB3F394", VA = "0xB3F394")]
	public void UpdateParameters()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xB3F688", Offset = "0xB3F688", VA = "0xB3F688")]
	private void UpdateTextures()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xB3F68C", Offset = "0xB3F68C", VA = "0xB3F68C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xB3F998", Offset = "0xB3F998", VA = "0xB3F998")]
	public ColorCorrectionCurves()
	{
	}
}
[Token(Token = "0x2000019")]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
public class ColorCorrectionLookup : PostEffectsBase
{
	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x20")]
	public Shader shader;

	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x28")]
	private Material material;

	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x30")]
	public Texture3D converted3DLut;

	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x38")]
	public string basedOnTempTex;

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xB3FFD4", Offset = "0xB3FFD4", VA = "0xB3FFD4", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xB40028", Offset = "0xB40028", VA = "0xB40028")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xB400B0", Offset = "0xB400B0", VA = "0xB400B0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xB40138", Offset = "0xB40138", VA = "0xB40138")]
	public void SetIdentityLut()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xB4031C", Offset = "0xB4031C", VA = "0xB4031C")]
	public bool ValidDimensions(Texture2D tex2d)
	{
		return default(bool);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xB4041C", Offset = "0xB4041C", VA = "0xB4041C")]
	public void Convert(Texture2D temp2DTex, string path)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xB40738", Offset = "0xB40738", VA = "0xB40738")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xB4092C", Offset = "0xB4092C", VA = "0xB4092C")]
	public ColorCorrectionLookup()
	{
	}
}
[Token(Token = "0x200001A")]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
public class ColorCorrectionRamp : ImageEffectBase
{
	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x28")]
	public Texture textureRamp;

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xB4097C", Offset = "0xB4097C", VA = "0xB4097C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xB40AE8", Offset = "0xB40AE8", VA = "0xB40AE8")]
	public ColorCorrectionRamp()
	{
	}
}
[Token(Token = "0x200001B")]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
[RequireComponent(typeof(Camera))]
internal class ContrastEnhance : PostEffectsBase
{
	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x1C")]
	public float intensity;

	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x20")]
	public float threshold;

	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x28")]
	private Material separableBlurMaterial;

	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x30")]
	private Material contrastCompositeMaterial;

	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x38")]
	public float blurSpread;

	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x40")]
	public Shader separableBlurShader;

	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x48")]
	public Shader contrastCompositeShader;

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xB40AF8", Offset = "0xB40AF8", VA = "0xB40AF8", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xB40B6C", Offset = "0xB40B6C", VA = "0xB40B6C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xB40E98", Offset = "0xB40E98", VA = "0xB40E98")]
	public ContrastEnhance()
	{
	}
}
[Token(Token = "0x200001C")]
[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
[ExecuteInEditMode]
public class ContrastStretch : MonoBehaviour
{
	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x18")]
	public float adaptationSpeed;

	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x1C")]
	public float limitMinimum;

	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x20")]
	public float limitMaximum;

	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x28")]
	private RenderTexture[] adaptRenderTex;

	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x30")]
	private int curAdaptIndex;

	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x38")]
	public Shader shaderLum;

	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x40")]
	private Material m_materialLum;

	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x48")]
	public Shader shaderReduce;

	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x50")]
	private Material m_materialReduce;

	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x58")]
	public Shader shaderAdapt;

	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x60")]
	private Material m_materialAdapt;

	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x68")]
	public Shader shaderApply;

	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x70")]
	private Material m_materialApply;

	[Token(Token = "0x17000002")]
	protected Material materialLum
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0xB40EB0", Offset = "0xB40EB0", VA = "0xB40EB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	protected Material materialReduce
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0xB40F68", Offset = "0xB40F68", VA = "0xB40F68")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	protected Material materialAdapt
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0xB41020", Offset = "0xB41020", VA = "0xB41020")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	protected Material materialApply
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0xB410D8", Offset = "0xB410D8", VA = "0xB410D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xB41190", Offset = "0xB41190", VA = "0xB41190")]
	private void Start()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xB41214", Offset = "0xB41214", VA = "0xB41214")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xB41350", Offset = "0xB41350", VA = "0xB41350")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xB4151C", Offset = "0xB4151C", VA = "0xB4151C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xB4175C", Offset = "0xB4175C", VA = "0xB4175C")]
	private void CalculateAdaptation(Texture curTexture)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xB41914", Offset = "0xB41914", VA = "0xB41914")]
	public ContrastStretch()
	{
	}
}
[Token(Token = "0x200001D")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
internal class CreaseShading : PostEffectsBase
{
	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x1C")]
	public float intensity;

	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x20")]
	public int softness;

	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x24")]
	public float spread;

	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0x28")]
	public Shader blurShader;

	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0x30")]
	private Material blurMaterial;

	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x38")]
	public Shader depthFetchShader;

	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x40")]
	private Material depthFetchMaterial;

	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x48")]
	public Shader creaseApplyShader;

	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x50")]
	private Material creaseApplyMaterial;

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xB41984", Offset = "0xB41984", VA = "0xB41984", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xB41A0C", Offset = "0xB41A0C", VA = "0xB41A0C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xB41D84", Offset = "0xB41D84", VA = "0xB41D84")]
	public CreaseShading()
	{
	}
}
[Token(Token = "0x200001E")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Camera/Depth of Field (Lens Blur, Scatter, DX11)")]
public class DepthOfField : PostEffectsBase
{
	[Token(Token = "0x200001F")]
	public enum BlurType
	{
		[Token(Token = "0x4000113")]
		DiscBlur,
		[Token(Token = "0x4000114")]
		DX11
	}

	[Token(Token = "0x2000020")]
	public enum BlurSampleCount
	{
		[Token(Token = "0x4000116")]
		Low,
		[Token(Token = "0x4000117")]
		Medium,
		[Token(Token = "0x4000118")]
		High
	}

	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x1C")]
	public bool visualizeFocus;

	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x20")]
	public float focalLength;

	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x24")]
	public float focalSize;

	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x28")]
	public float aperture;

	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x30")]
	public Transform focalTransform;

	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x38")]
	public float maxBlurSize;

	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x3C")]
	public bool highResolution;

	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x40")]
	public BlurType blurType;

	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x44")]
	public BlurSampleCount blurSampleCount;

	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x48")]
	public bool nearBlur;

	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x4C")]
	public float foregroundOverlap;

	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x50")]
	public Shader dofHdrShader;

	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x58")]
	private Material dofHdrMaterial;

	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x60")]
	public Shader dx11BokehShader;

	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x68")]
	private Material dx11bokehMaterial;

	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x70")]
	public float dx11BokehThreshold;

	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x74")]
	public float dx11SpawnHeuristic;

	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x78")]
	public Texture2D dx11BokehTexture;

	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x80")]
	public float dx11BokehScale;

	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x84")]
	public float dx11BokehIntensity;

	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x88")]
	private float focalDistance01;

	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x90")]
	private ComputeBuffer cbDrawArgs;

	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x98")]
	private ComputeBuffer cbPoints;

	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0xA0")]
	private float internalBlurWidth;

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xB41DA0", Offset = "0xB41DA0", VA = "0xB41DA0", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xB41F48", Offset = "0xB41F48", VA = "0xB41F48")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xB41FB4", Offset = "0xB41FB4", VA = "0xB41FB4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xB4208C", Offset = "0xB4208C", VA = "0xB4208C")]
	private void ReleaseComputeResources()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xB41E28", Offset = "0xB41E28", VA = "0xB41E28")]
	private void CreateComputeResources()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xB420C4", Offset = "0xB420C4", VA = "0xB420C4")]
	private float FocalDistance01(float worldDist)
	{
		return default(float);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xB42210", Offset = "0xB42210", VA = "0xB42210")]
	private void WriteCoc(RenderTexture fromTo, bool fgDilate)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xB424E0", Offset = "0xB424E0", VA = "0xB424E0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xB43804", Offset = "0xB43804", VA = "0xB43804")]
	public DepthOfField()
	{
	}
}
[Token(Token = "0x2000021")]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Camera/Depth of Field (deprecated)")]
[ExecuteInEditMode]
public class DepthOfFieldDeprecated : PostEffectsBase
{
	[Token(Token = "0x2000022")]
	public enum Dof34QualitySetting
	{
		[Token(Token = "0x4000145")]
		OnlyBackground = 1,
		[Token(Token = "0x4000146")]
		BackgroundAndForeground
	}

	[Token(Token = "0x2000023")]
	public enum DofResolution
	{
		[Token(Token = "0x4000148")]
		High = 2,
		[Token(Token = "0x4000149")]
		Medium,
		[Token(Token = "0x400014A")]
		Low
	}

	[Token(Token = "0x2000024")]
	public enum DofBlurriness
	{
		[Token(Token = "0x400014C")]
		Low = 1,
		[Token(Token = "0x400014D")]
		High = 2,
		[Token(Token = "0x400014E")]
		VeryHigh = 4
	}

	[Token(Token = "0x2000025")]
	public enum BokehDestination
	{
		[Token(Token = "0x4000150")]
		Background = 1,
		[Token(Token = "0x4000151")]
		Foreground,
		[Token(Token = "0x4000152")]
		BackgroundAndForeground
	}

	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0x0")]
	private static int SMOOTH_DOWNSAMPLE_PASS;

	[Token(Token = "0x400011A")]
	[FieldOffset(Offset = "0x4")]
	private static float BOKEH_EXTRA_BLUR;

	[Token(Token = "0x400011B")]
	[FieldOffset(Offset = "0x1C")]
	public Dof34QualitySetting quality;

	[Token(Token = "0x400011C")]
	[FieldOffset(Offset = "0x20")]
	public DofResolution resolution;

	[Token(Token = "0x400011D")]
	[FieldOffset(Offset = "0x24")]
	public bool simpleTweakMode;

	[Token(Token = "0x400011E")]
	[FieldOffset(Offset = "0x28")]
	public float focalPoint;

	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x2C")]
	public float smoothness;

	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x30")]
	public float focalZDistance;

	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x34")]
	public float focalZStartCurve;

	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x38")]
	public float focalZEndCurve;

	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x3C")]
	private float focalStartCurve;

	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x40")]
	private float focalEndCurve;

	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x44")]
	private float focalDistance01;

	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x48")]
	public Transform objectFocus;

	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x50")]
	public float focalSize;

	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x54")]
	public DofBlurriness bluriness;

	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x58")]
	public float maxBlurSpread;

	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x5C")]
	public float foregroundBlurExtrude;

	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x60")]
	public Shader dofBlurShader;

	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x68")]
	private Material dofBlurMaterial;

	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x70")]
	public Shader dofShader;

	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x78")]
	private Material dofMaterial;

	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x80")]
	public bool visualize;

	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x84")]
	public BokehDestination bokehDestination;

	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x88")]
	private float widthOverHeight;

	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x8C")]
	private float oneOverBaseSize;

	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x90")]
	public bool bokeh;

	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x91")]
	public bool bokehSupport;

	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x98")]
	public Shader bokehShader;

	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0xA0")]
	public Texture2D bokehTexture;

	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0xA8")]
	public float bokehScale;

	[Token(Token = "0x4000138")]
	[FieldOffset(Offset = "0xAC")]
	public float bokehIntensity;

	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0xB0")]
	public float bokehThresholdContrast;

	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0xB4")]
	public float bokehThresholdLuminance;

	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0xB8")]
	public int bokehDownsample;

	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0xC0")]
	private Material bokehMaterial;

	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0xC8")]
	private Camera _camera;

	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0xD0")]
	private RenderTexture foregroundTexture;

	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0xD8")]
	private RenderTexture mediumRezWorkTexture;

	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0xE0")]
	private RenderTexture finalDefocus;

	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0xE8")]
	private RenderTexture lowRezWorkTexture;

	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0xF0")]
	private RenderTexture bokehSource;

	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0xF8")]
	private RenderTexture bokehSource2;

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xB4385C", Offset = "0xB4385C", VA = "0xB4385C")]
	private void CreateMaterials()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xB4392C", Offset = "0xB4392C", VA = "0xB4392C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xB43A34", Offset = "0xB43A34", VA = "0xB43A34")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xB43A3C", Offset = "0xB43A3C", VA = "0xB43A3C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xB43AAC", Offset = "0xB43AAC", VA = "0xB43AAC")]
	private float FocalDistance01(float worldDist)
	{
		return default(float);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xB43B98", Offset = "0xB43B98", VA = "0xB43B98")]
	private int GetDividerBasedOnQuality()
	{
		return default(int);
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xB43BBC", Offset = "0xB43BBC", VA = "0xB43BBC")]
	private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
	{
		return default(int);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xB43BE0", Offset = "0xB43BE0", VA = "0xB43BE0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xB448B0", Offset = "0xB448B0", VA = "0xB448B0")]
	private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xB44E64", Offset = "0xB44E64", VA = "0xB44E64")]
	private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xB451D8", Offset = "0xB451D8", VA = "0xB451D8")]
	private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xB44788", Offset = "0xB44788", VA = "0xB44788")]
	private void Downsample(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xB44A90", Offset = "0xB44A90", VA = "0xB44A90")]
	private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xB45070", Offset = "0xB45070", VA = "0xB45070")]
	private void ReleaseTextures()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xB44474", Offset = "0xB44474", VA = "0xB44474")]
	private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xB45378", Offset = "0xB45378", VA = "0xB45378")]
	public DepthOfFieldDeprecated()
	{
	}
}
[Token(Token = "0x2000026")]
[AddComponentMenu("Image Effects/Edge Detection/Edge Detection")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class EdgeDetection : PostEffectsBase
{
	[Token(Token = "0x2000027")]
	public enum EdgeDetectMode
	{
		[Token(Token = "0x400015F")]
		TriangleDepthNormals,
		[Token(Token = "0x4000160")]
		RobertsCrossDepthNormals,
		[Token(Token = "0x4000161")]
		SobelDepth,
		[Token(Token = "0x4000162")]
		SobelDepthThin,
		[Token(Token = "0x4000163")]
		TriangleLuminance
	}

	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x1C")]
	public EdgeDetectMode mode;

	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x20")]
	public float sensitivityDepth;

	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x24")]
	public float sensitivityNormals;

	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x28")]
	public float lumThreshold;

	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x2C")]
	public float edgeExp;

	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x30")]
	public float sampleDist;

	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x34")]
	public float edgesOnly;

	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0x38")]
	public Color edgesOnlyBgColor;

	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0x48")]
	public Shader edgeDetectShader;

	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x50")]
	private Material edgeDetectMaterial;

	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x58")]
	private EdgeDetectMode oldMode;

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xB45440", Offset = "0xB45440", VA = "0xB45440", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xB45568", Offset = "0xB45568", VA = "0xB45568")]
	private new void Start()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xB454B8", Offset = "0xB454B8", VA = "0xB454B8")]
	private void SetCameraFlag()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xB45574", Offset = "0xB45574", VA = "0xB45574")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xB45578", Offset = "0xB45578", VA = "0xB45578")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xB4574C", Offset = "0xB4574C", VA = "0xB4574C")]
	public EdgeDetection()
	{
	}
}
[Token(Token = "0x2000028")]
[AddComponentMenu("Image Effects/Displacement/Fisheye")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class Fisheye : PostEffectsBase
{
	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0x1C")]
	public float strengthX;

	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x20")]
	public float strengthY;

	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x28")]
	public Shader fishEyeShader;

	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x30")]
	private Material fisheyeMaterial;

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xB4577C", Offset = "0xB4577C", VA = "0xB4577C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xB457D4", Offset = "0xB457D4", VA = "0xB457D4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xB45908", Offset = "0xB45908", VA = "0xB45908")]
	public Fisheye()
	{
	}
}
[Token(Token = "0x2000029")]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Rendering/Global Fog")]
[ExecuteInEditMode]
internal class GlobalFog : PostEffectsBase
{
	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x1C")]
	[Tooltip("Apply distance-based fog?")]
	public bool distanceFog;

	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x1D")]
	[Tooltip("Distance fog is based on radial distance from camera when checked")]
	public bool useRadialDistance;

	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x1E")]
	[Tooltip("Apply height-based fog?")]
	public bool heightFog;

	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x20")]
	[Tooltip("Fog top Y coordinate")]
	public float height;

	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x24")]
	[Range(0.001f, 10f)]
	public float heightDensity;

	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x28")]
	[Tooltip("Push fog away from the camera by this amount")]
	public float startDistance;

	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x30")]
	public Shader fogShader;

	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x38")]
	private Material fogMaterial;

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xB45920", Offset = "0xB45920", VA = "0xB45920", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xB45980", Offset = "0xB45980", VA = "0xB45980")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xB462A8", Offset = "0xB462A8", VA = "0xB462A8")]
	private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xB46408", Offset = "0xB46408", VA = "0xB46408")]
	public GlobalFog()
	{
	}
}
[Token(Token = "0x200002A")]
[AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
[ExecuteInEditMode]
public class Grayscale : ImageEffectBase
{
	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0x28")]
	public Texture textureRamp;

	[Token(Token = "0x4000171")]
	[FieldOffset(Offset = "0x30")]
	public float rampOffset;

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xB46428", Offset = "0xB46428", VA = "0xB46428")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xB4650C", Offset = "0xB4650C", VA = "0xB4650C")]
	public Grayscale()
	{
	}
}
[Token(Token = "0x200002B")]
[AddComponentMenu("")]
[RequireComponent(typeof(Camera))]
public class ImageEffectBase : MonoBehaviour
{
	[Token(Token = "0x4000172")]
	[FieldOffset(Offset = "0x18")]
	public Shader shader;

	[Token(Token = "0x4000173")]
	[FieldOffset(Offset = "0x20")]
	private Material m_Material;

	[Token(Token = "0x17000006")]
	protected Material material
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0xB40A30", Offset = "0xB40A30", VA = "0xB40A30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xB46514", Offset = "0xB46514", VA = "0xB46514", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xB465B4", Offset = "0xB465B4", VA = "0xB465B4", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xB40AF0", Offset = "0xB40AF0", VA = "0xB40AF0")]
	public ImageEffectBase()
	{
	}
}
[Token(Token = "0x200002C")]
[AddComponentMenu("")]
public class ImageEffects
{
	[Token(Token = "0x600007E")]
	[Address(RVA = "0xB46640", Offset = "0xB46640", VA = "0xB46640")]
	public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xB468B0", Offset = "0xB468B0", VA = "0xB468B0")]
	[Obsolete("Use Graphics.Blit(source,dest) instead")]
	public static void Blit(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xB46918", Offset = "0xB46918", VA = "0xB46918")]
	[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
	public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xB46988", Offset = "0xB46988", VA = "0xB46988")]
	public ImageEffects()
	{
	}
}
[Token(Token = "0x200002D")]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Blur/Motion Blur (Color Accumulation)")]
[ExecuteInEditMode]
public class MotionBlur : ImageEffectBase
{
	[Token(Token = "0x4000174")]
	[FieldOffset(Offset = "0x28")]
	public float blurAmount;

	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0x2C")]
	public bool extraBlur;

	[Token(Token = "0x4000176")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture accumTexture;

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xB46990", Offset = "0xB46990", VA = "0xB46990", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xB46994", Offset = "0xB46994", VA = "0xB46994", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xB469F8", Offset = "0xB469F8", VA = "0xB469F8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xB46D44", Offset = "0xB46D44", VA = "0xB46D44")]
	public MotionBlur()
	{
	}
}
[Token(Token = "0x200002E")]
[AddComponentMenu("Image Effects/Noise/Noise And Grain (Filmic)")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class NoiseAndGrain : PostEffectsBase
{
	[Token(Token = "0x4000177")]
	[FieldOffset(Offset = "0x1C")]
	public float intensityMultiplier;

	[Token(Token = "0x4000178")]
	[FieldOffset(Offset = "0x20")]
	public float generalIntensity;

	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x24")]
	public float blackIntensity;

	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0x28")]
	public float whiteIntensity;

	[Token(Token = "0x400017B")]
	[FieldOffset(Offset = "0x2C")]
	public float midGrey;

	[Token(Token = "0x400017C")]
	[FieldOffset(Offset = "0x30")]
	public bool dx11Grain;

	[Token(Token = "0x400017D")]
	[FieldOffset(Offset = "0x34")]
	public float softness;

	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x38")]
	public bool monochrome;

	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 intensities;

	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 tiling;

	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x54")]
	public float monochromeTiling;

	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x58")]
	public FilterMode filterMode;

	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x60")]
	public Texture2D noiseTexture;

	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x68")]
	public Shader noiseShader;

	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x70")]
	private Material noiseMaterial;

	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x78")]
	public Shader dx11NoiseShader;

	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x80")]
	private Material dx11NoiseMaterial;

	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0x0")]
	private static float TILE_AMOUNT;

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xB46D58", Offset = "0xB46D58", VA = "0xB46D58", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xB46DD4", Offset = "0xB46DD4", VA = "0xB46DD4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xB475D4", Offset = "0xB475D4", VA = "0xB475D4")]
	private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xB47914", Offset = "0xB47914", VA = "0xB47914")]
	public NoiseAndGrain()
	{
	}
}
[Token(Token = "0x200002F")]
[AddComponentMenu("Image Effects/Noise/Noise and Scratches")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class NoiseAndScratches : MonoBehaviour
{
	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0x18")]
	public bool monochrome;

	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x19")]
	private bool rgbFallback;

	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x1C")]
	public float grainIntensityMin;

	[Token(Token = "0x400018C")]
	[FieldOffset(Offset = "0x20")]
	public float grainIntensityMax;

	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x24")]
	public float grainSize;

	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x28")]
	public float scratchIntensityMin;

	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x2C")]
	public float scratchIntensityMax;

	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x30")]
	public float scratchFPS;

	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x34")]
	public float scratchJitter;

	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x38")]
	public Texture grainTexture;

	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x40")]
	public Texture scratchTexture;

	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x48")]
	public Shader shaderRGB;

	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x50")]
	public Shader shaderYUV;

	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x58")]
	private Material m_MaterialRGB;

	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x60")]
	private Material m_MaterialYUV;

	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x68")]
	private float scratchTimeLeft;

	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x6C")]
	private float scratchX;

	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x70")]
	private float scratchY;

	[Token(Token = "0x17000007")]
	protected Material material
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0xB47AD0", Offset = "0xB47AD0", VA = "0xB47AD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xB479A4", Offset = "0xB479A4", VA = "0xB479A4")]
	protected void Start()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xB47C18", Offset = "0xB47C18", VA = "0xB47C18")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xB47CE8", Offset = "0xB47CE8", VA = "0xB47CE8")]
	private void SanitizeParameters()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xB47D8C", Offset = "0xB47D8C", VA = "0xB47D8C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xB480B4", Offset = "0xB480B4", VA = "0xB480B4")]
	public NoiseAndScratches()
	{
	}
}
[Token(Token = "0x2000030")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class PostEffectsBase : MonoBehaviour
{
	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x18")]
	protected bool supportHDRTextures;

	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x19")]
	protected bool supportDepth;

	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x1A")]
	protected bool supportDX11;

	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x1B")]
	protected bool isSupported;

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xB480E8", Offset = "0xB480E8", VA = "0xB480E8")]
	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xB484A8", Offset = "0xB484A8", VA = "0xB484A8")]
	protected Material CreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xB4868C", Offset = "0xB4868C", VA = "0xB4868C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xB48698", Offset = "0xB48698", VA = "0xB48698")]
	protected bool CheckSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xB48754", Offset = "0xB48754", VA = "0xB48754", Slot = "4")]
	public virtual bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xB48814", Offset = "0xB48814", VA = "0xB48814")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xB486A0", Offset = "0xB486A0", VA = "0xB486A0")]
	protected bool CheckSupport(bool needDepth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xB48880", Offset = "0xB48880", VA = "0xB48880")]
	protected bool CheckSupport(bool needDepth, bool needHdr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xB488D8", Offset = "0xB488D8", VA = "0xB488D8")]
	public bool Dx11Support()
	{
		return default(bool);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xB488E0", Offset = "0xB488E0", VA = "0xB488E0")]
	protected void ReportAutoDisable()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xB48998", Offset = "0xB48998", VA = "0xB48998")]
	private bool CheckShader(Shader s)
	{
		return default(bool);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xB48488", Offset = "0xB48488", VA = "0xB48488")]
	protected void NotSupported()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xB48BB0", Offset = "0xB48BB0", VA = "0xB48BB0")]
	protected void DrawBorder(RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xB48F28", Offset = "0xB48F28", VA = "0xB48F28")]
	public PostEffectsBase()
	{
	}
}
[Token(Token = "0x2000031")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
internal class PostEffectsHelper : MonoBehaviour
{
	[Token(Token = "0x600009F")]
	[Address(RVA = "0xB48F40", Offset = "0xB48F40", VA = "0xB48F40")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xB48FA8", Offset = "0xB48FA8", VA = "0xB48FA8")]
	private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xB491F4", Offset = "0xB491F4", VA = "0xB491F4")]
	private static void DrawBorder(RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xB49568", Offset = "0xB49568", VA = "0xB49568")]
	private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xB4970C", Offset = "0xB4970C", VA = "0xB4970C")]
	public PostEffectsHelper()
	{
	}
}
[Token(Token = "0x2000032")]
internal class Quads
{
	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0x0")]
	private static Mesh[] meshes;

	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x8")]
	private static int currentQuads;

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xB49714", Offset = "0xB49714", VA = "0xB49714")]
	private static bool HasMeshes()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xB497E4", Offset = "0xB497E4", VA = "0xB497E4")]
	public static void Cleanup()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xB49920", Offset = "0xB49920", VA = "0xB49920")]
	public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xB49B3C", Offset = "0xB49B3C", VA = "0xB49B3C")]
	private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xB49EC0", Offset = "0xB49EC0", VA = "0xB49EC0")]
	public Quads()
	{
	}
}
[Token(Token = "0x2000033")]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Other/Screen Overlay")]
[ExecuteInEditMode]
public class ScreenOverlay : PostEffectsBase
{
	[Token(Token = "0x2000034")]
	public enum OverlayBlendMode
	{
		[Token(Token = "0x40001A7")]
		Additive,
		[Token(Token = "0x40001A8")]
		ScreenBlend,
		[Token(Token = "0x40001A9")]
		Multiply,
		[Token(Token = "0x40001AA")]
		Overlay,
		[Token(Token = "0x40001AB")]
		AlphaBlend
	}

	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x1C")]
	public OverlayBlendMode blendMode;

	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x20")]
	public float intensity;

	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x28")]
	public Texture2D texture;

	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x30")]
	public Shader overlayShader;

	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x38")]
	private Material overlayMaterial;

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xB49EC8", Offset = "0xB49EC8", VA = "0xB49EC8", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xB49F14", Offset = "0xB49F14", VA = "0xB49F14")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xB4A064", Offset = "0xB4A064", VA = "0xB4A064")]
	public ScreenOverlay()
	{
	}
}
[Token(Token = "0x2000035")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
internal class ScreenSpaceAmbientObscurance : PostEffectsBase
{
	[Token(Token = "0x40001AC")]
	[FieldOffset(Offset = "0x1C")]
	[Range(0f, 3f)]
	public float intensity;

	[Token(Token = "0x40001AD")]
	[FieldOffset(Offset = "0x20")]
	[Range(0.1f, 3f)]
	public float radius;

	[Token(Token = "0x40001AE")]
	[FieldOffset(Offset = "0x24")]
	[Range(0f, 3f)]
	public int blurIterations;

	[Token(Token = "0x40001AF")]
	[FieldOffset(Offset = "0x28")]
	[Range(0f, 5f)]
	public float blurFilterDistance;

	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x2C")]
	[Range(0f, 1f)]
	public int downsample;

	[Token(Token = "0x40001B1")]
	[FieldOffset(Offset = "0x30")]
	public Texture2D rand;

	[Token(Token = "0x40001B2")]
	[FieldOffset(Offset = "0x38")]
	public Shader aoShader;

	[Token(Token = "0x40001B3")]
	[FieldOffset(Offset = "0x40")]
	private Material aoMaterial;

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xB4A088", Offset = "0xB4A088", VA = "0xB4A088", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xB4A0DC", Offset = "0xB4A0DC", VA = "0xB4A0DC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xB4A164", Offset = "0xB4A164", VA = "0xB4A164")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xB4A714", Offset = "0xB4A714", VA = "0xB4A714")]
	public ScreenSpaceAmbientObscurance()
	{
	}
}
[Token(Token = "0x2000036")]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Occlusion")]
[RequireComponent(typeof(Camera))]
public class ScreenSpaceAmbientOcclusion : MonoBehaviour
{
	[Token(Token = "0x2000037")]
	public enum SSAOSamples
	{
		[Token(Token = "0x40001C0")]
		Low,
		[Token(Token = "0x40001C1")]
		Medium,
		[Token(Token = "0x40001C2")]
		High
	}

	[Token(Token = "0x40001B4")]
	[FieldOffset(Offset = "0x18")]
	public float m_Radius;

	[Token(Token = "0x40001B5")]
	[FieldOffset(Offset = "0x1C")]
	public SSAOSamples m_SampleCount;

	[Token(Token = "0x40001B6")]
	[FieldOffset(Offset = "0x20")]
	public float m_OcclusionIntensity;

	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0x24")]
	public int m_Blur;

	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0x28")]
	public int m_Downsampling;

	[Token(Token = "0x40001B9")]
	[FieldOffset(Offset = "0x2C")]
	public float m_OcclusionAttenuation;

	[Token(Token = "0x40001BA")]
	[FieldOffset(Offset = "0x30")]
	public float m_MinZ;

	[Token(Token = "0x40001BB")]
	[FieldOffset(Offset = "0x38")]
	public Shader m_SSAOShader;

	[Token(Token = "0x40001BC")]
	[FieldOffset(Offset = "0x40")]
	private Material m_SSAOMaterial;

	[Token(Token = "0x40001BD")]
	[FieldOffset(Offset = "0x48")]
	public Texture2D m_RandomTexture;

	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0x50")]
	private bool m_Supported;

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xB4A744", Offset = "0xB4A744", VA = "0xB4A744")]
	private static Material CreateMaterial(Shader shader)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xB4A7F0", Offset = "0xB4A7F0", VA = "0xB4A7F0")]
	private static void DestroyMaterial(Material mat)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xB4A874", Offset = "0xB4A874", VA = "0xB4A874")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xB4A87C", Offset = "0xB4A87C", VA = "0xB4A87C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xB4A9FC", Offset = "0xB4A9FC", VA = "0xB4A9FC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xB4A944", Offset = "0xB4A944", VA = "0xB4A944")]
	private void CreateMaterials()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xB4AA68", Offset = "0xB4AA68", VA = "0xB4AA68")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xB4B03C", Offset = "0xB4B03C", VA = "0xB4B03C")]
	public ScreenSpaceAmbientOcclusion()
	{
	}
}
[Token(Token = "0x2000038")]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Color Adjustments/Sepia Tone")]
public class SepiaTone : ImageEffectBase
{
	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xB4B070", Offset = "0xB4B070", VA = "0xB4B070")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xB4B0F4", Offset = "0xB4B0F4", VA = "0xB4B0F4")]
	public SepiaTone()
	{
	}
}
[Token(Token = "0x2000039")]
[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class SunShafts : PostEffectsBase
{
	[Token(Token = "0x200003A")]
	public enum SunShaftsResolution
	{
		[Token(Token = "0x40001D2")]
		Low,
		[Token(Token = "0x40001D3")]
		Normal,
		[Token(Token = "0x40001D4")]
		High
	}

	[Token(Token = "0x200003B")]
	public enum ShaftsScreenBlendMode
	{
		[Token(Token = "0x40001D6")]
		Screen,
		[Token(Token = "0x40001D7")]
		Add
	}

	[Token(Token = "0x40001C3")]
	[FieldOffset(Offset = "0x1C")]
	public SunShaftsResolution resolution;

	[Token(Token = "0x40001C4")]
	[FieldOffset(Offset = "0x20")]
	public ShaftsScreenBlendMode screenBlendMode;

	[Token(Token = "0x40001C5")]
	[FieldOffset(Offset = "0x28")]
	public Transform sunTransform;

	[Token(Token = "0x40001C6")]
	[FieldOffset(Offset = "0x30")]
	public int radialBlurIterations;

	[Token(Token = "0x40001C7")]
	[FieldOffset(Offset = "0x34")]
	public Color sunColor;

	[Token(Token = "0x40001C8")]
	[FieldOffset(Offset = "0x44")]
	public Color sunThreshold;

	[Token(Token = "0x40001C9")]
	[FieldOffset(Offset = "0x54")]
	public float sunShaftBlurRadius;

	[Token(Token = "0x40001CA")]
	[FieldOffset(Offset = "0x58")]
	public float sunShaftIntensity;

	[Token(Token = "0x40001CB")]
	[FieldOffset(Offset = "0x5C")]
	public float maxRadius;

	[Token(Token = "0x40001CC")]
	[FieldOffset(Offset = "0x60")]
	public bool useDepthTexture;

	[Token(Token = "0x40001CD")]
	[FieldOffset(Offset = "0x68")]
	public Shader sunShaftsShader;

	[Token(Token = "0x40001CE")]
	[FieldOffset(Offset = "0x70")]
	private Material sunShaftsMaterial;

	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0x78")]
	public Shader simpleClearShader;

	[Token(Token = "0x40001D0")]
	[FieldOffset(Offset = "0x80")]
	private Material simpleClearMaterial;

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xB4B0FC", Offset = "0xB4B0FC", VA = "0xB4B0FC", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xB4B158", Offset = "0xB4B158", VA = "0xB4B158")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xB4B814", Offset = "0xB4B814", VA = "0xB4B814")]
	public SunShafts()
	{
	}
}
[Token(Token = "0x200003C")]
[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
[RequireComponent(typeof(Camera))]
internal class TiltShift : PostEffectsBase
{
	[Token(Token = "0x200003D")]
	public enum TiltShiftMode
	{
		[Token(Token = "0x40001E0")]
		TiltShiftMode,
		[Token(Token = "0x40001E1")]
		IrisMode
	}

	[Token(Token = "0x200003E")]
	public enum TiltShiftQuality
	{
		[Token(Token = "0x40001E3")]
		Preview,
		[Token(Token = "0x40001E4")]
		Normal,
		[Token(Token = "0x40001E5")]
		High
	}

	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x1C")]
	public TiltShiftMode mode;

	[Token(Token = "0x40001D9")]
	[FieldOffset(Offset = "0x20")]
	public TiltShiftQuality quality;

	[Token(Token = "0x40001DA")]
	[FieldOffset(Offset = "0x24")]
	[Range(0f, 15f)]
	public float blurArea;

	[Token(Token = "0x40001DB")]
	[FieldOffset(Offset = "0x28")]
	[Range(0f, 25f)]
	public float maxBlurSize;

	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0x2C")]
	[Range(0f, 1f)]
	public int downsample;

	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0x30")]
	public Shader tiltShiftShader;

	[Token(Token = "0x40001DE")]
	[FieldOffset(Offset = "0x38")]
	private Material tiltShiftMaterial;

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xB4B868", Offset = "0xB4B868", VA = "0xB4B868", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xB4B8BC", Offset = "0xB4B8BC", VA = "0xB4B8BC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xB4BB4C", Offset = "0xB4BB4C", VA = "0xB4BB4C")]
	public TiltShift()
	{
	}
}
[Token(Token = "0x200003F")]
[AddComponentMenu("Image Effects/Color Adjustments/Tonemapping")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class Tonemapping : PostEffectsBase
{
	[Token(Token = "0x2000040")]
	public enum TonemapperType
	{
		[Token(Token = "0x40001F4")]
		SimpleReinhard,
		[Token(Token = "0x40001F5")]
		UserCurve,
		[Token(Token = "0x40001F6")]
		Hable,
		[Token(Token = "0x40001F7")]
		Photographic,
		[Token(Token = "0x40001F8")]
		OptimizedHejiDawson,
		[Token(Token = "0x40001F9")]
		AdaptiveReinhard,
		[Token(Token = "0x40001FA")]
		AdaptiveReinhardAutoWhite
	}

	[Token(Token = "0x2000041")]
	public enum AdaptiveTexSize
	{
		[Token(Token = "0x40001FC")]
		Square16 = 0x10,
		[Token(Token = "0x40001FD")]
		Square32 = 0x20,
		[Token(Token = "0x40001FE")]
		Square64 = 0x40,
		[Token(Token = "0x40001FF")]
		Square128 = 0x80,
		[Token(Token = "0x4000200")]
		Square256 = 0x100,
		[Token(Token = "0x4000201")]
		Square512 = 0x200,
		[Token(Token = "0x4000202")]
		Square1024 = 0x400
	}

	[Token(Token = "0x40001E6")]
	[FieldOffset(Offset = "0x1C")]
	public TonemapperType type;

	[Token(Token = "0x40001E7")]
	[FieldOffset(Offset = "0x20")]
	public AdaptiveTexSize adaptiveTextureSize;

	[Token(Token = "0x40001E8")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve remapCurve;

	[Token(Token = "0x40001E9")]
	[FieldOffset(Offset = "0x30")]
	private Texture2D curveTex;

	[Token(Token = "0x40001EA")]
	[FieldOffset(Offset = "0x38")]
	public float exposureAdjustment;

	[Token(Token = "0x40001EB")]
	[FieldOffset(Offset = "0x3C")]
	public float middleGrey;

	[Token(Token = "0x40001EC")]
	[FieldOffset(Offset = "0x40")]
	public float white;

	[Token(Token = "0x40001ED")]
	[FieldOffset(Offset = "0x44")]
	public float adaptionSpeed;

	[Token(Token = "0x40001EE")]
	[FieldOffset(Offset = "0x48")]
	public Shader tonemapper;

	[Token(Token = "0x40001EF")]
	[FieldOffset(Offset = "0x50")]
	public bool validRenderTextureFormat;

	[Token(Token = "0x40001F0")]
	[FieldOffset(Offset = "0x58")]
	private Material tonemapMaterial;

	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x60")]
	private RenderTexture rt;

	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x68")]
	private RenderTextureFormat rtFormat;

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xB4BB74", Offset = "0xB4BB74", VA = "0xB4BB74", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xB4BCAC", Offset = "0xB4BCAC", VA = "0xB4BCAC")]
	public float UpdateCurve()
	{
		return default(float);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xB4BF24", Offset = "0xB4BF24", VA = "0xB4BF24")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xB4C03C", Offset = "0xB4C03C", VA = "0xB4C03C")]
	private bool CreateInternalRenderTexture()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xB4C12C", Offset = "0xB4C12C", VA = "0xB4C12C")]
	[ImageEffectTransformsToLDR]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xB4C8B4", Offset = "0xB4C8B4", VA = "0xB4C8B4")]
	public Tonemapping()
	{
	}
}
[Token(Token = "0x2000042")]
internal class Triangles
{
	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x0")]
	private static Mesh[] meshes;

	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x8")]
	private static int currentTris;

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xB4C8F0", Offset = "0xB4C8F0", VA = "0xB4C8F0")]
	private static bool HasMeshes()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xB4C9C4", Offset = "0xB4C9C4", VA = "0xB4C9C4")]
	private static void Cleanup()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xB4CB00", Offset = "0xB4CB00", VA = "0xB4CB00")]
	private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xB4CD1C", Offset = "0xB4CD1C", VA = "0xB4CD1C")]
	private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xB4D010", Offset = "0xB4D010", VA = "0xB4D010")]
	public Triangles()
	{
	}
}
[Token(Token = "0x2000043")]
[AddComponentMenu("Image Effects/Displacement/Twirl")]
[ExecuteInEditMode]
public class Twirl : ImageEffectBase
{
	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 radius;

	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0x30")]
	public float angle;

	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 center;

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xB4D018", Offset = "0xB4D018", VA = "0xB4D018")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xB4D058", Offset = "0xB4D058", VA = "0xB4D058")]
	public Twirl()
	{
	}
}
[Token(Token = "0x2000044")]
[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class VignetteAndChromaticAberration : PostEffectsBase
{
	[Token(Token = "0x2000045")]
	public enum AberrationMode
	{
		[Token(Token = "0x4000217")]
		Simple,
		[Token(Token = "0x4000218")]
		Advanced
	}

	[Token(Token = "0x4000208")]
	[FieldOffset(Offset = "0x1C")]
	public AberrationMode mode;

	[Token(Token = "0x4000209")]
	[FieldOffset(Offset = "0x20")]
	public float intensity;

	[Token(Token = "0x400020A")]
	[FieldOffset(Offset = "0x24")]
	public float chromaticAberration;

	[Token(Token = "0x400020B")]
	[FieldOffset(Offset = "0x28")]
	public float axialAberration;

	[Token(Token = "0x400020C")]
	[FieldOffset(Offset = "0x2C")]
	public float blur;

	[Token(Token = "0x400020D")]
	[FieldOffset(Offset = "0x30")]
	public float blurSpread;

	[Token(Token = "0x400020E")]
	[FieldOffset(Offset = "0x34")]
	public float luminanceDependency;

	[Token(Token = "0x400020F")]
	[FieldOffset(Offset = "0x38")]
	public float blurDistance;

	[Token(Token = "0x4000210")]
	[FieldOffset(Offset = "0x40")]
	public Shader vignetteShader;

	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x48")]
	public Shader separableBlurShader;

	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x50")]
	public Shader chromAberrationShader;

	[Token(Token = "0x4000213")]
	[FieldOffset(Offset = "0x58")]
	private Material m_VignetteMaterial;

	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0x60")]
	private Material m_SeparableBlurMaterial;

	[Token(Token = "0x4000215")]
	[FieldOffset(Offset = "0x68")]
	private Material m_ChromAberrationMaterial;

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xB4D080", Offset = "0xB4D080", VA = "0xB4D080", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xB4D0F8", Offset = "0xB4D0F8", VA = "0xB4D0F8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xB4D634", Offset = "0xB4D634", VA = "0xB4D634")]
	public VignetteAndChromaticAberration()
	{
	}
}
[Token(Token = "0x2000046")]
[AddComponentMenu("Image Effects/Displacement/Vortex")]
[ExecuteInEditMode]
public class Vortex : ImageEffectBase
{
	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 radius;

	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0x30")]
	public float angle;

	[Token(Token = "0x400021B")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 center;

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xB4D674", Offset = "0xB4D674", VA = "0xB4D674")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xB4D6B4", Offset = "0xB4D6B4", VA = "0xB4D6B4")]
	public Vortex()
	{
	}
}
