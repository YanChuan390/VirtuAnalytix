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
	[Address(RVA = "0xB369DC", Offset = "0xB369DC", VA = "0xB369DC")]
	public Material CurrentAAMaterial()
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xB36A44", Offset = "0xB36A44", VA = "0xB36A44", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xB36B24", Offset = "0xB36B24", VA = "0xB36B24")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xB36FE8", Offset = "0xB36FE8", VA = "0xB36FE8")]
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
	[Address(RVA = "0xB3700C", Offset = "0xB3700C", VA = "0xB3700C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xB3716C", Offset = "0xB3716C", VA = "0xB3716C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xB37200", Offset = "0xB37200", VA = "0xB37200")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xB38370", Offset = "0xB38370", VA = "0xB38370")]
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xB381D8", Offset = "0xB381D8", VA = "0xB381D8")]
	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xB37F2C", Offset = "0xB37F2C", VA = "0xB37F2C")]
	private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xB37E58", Offset = "0xB37E58", VA = "0xB37E58")]
	private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xB37FEC", Offset = "0xB37FEC", VA = "0xB37FEC")]
	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xB38434", Offset = "0xB38434", VA = "0xB38434")]
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
	[Address(RVA = "0xB384BC", Offset = "0xB384BC", VA = "0xB384BC", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xB3858C", Offset = "0xB3858C", VA = "0xB3858C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xB3934C", Offset = "0xB3934C", VA = "0xB3934C")]
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xB391C4", Offset = "0xB391C4", VA = "0xB391C4")]
	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xB38F6C", Offset = "0xB38F6C", VA = "0xB38F6C")]
	private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xB39074", Offset = "0xB39074", VA = "0xB39074")]
	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xB393FC", Offset = "0xB393FC", VA = "0xB393FC")]
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
	[Address(RVA = "0xB39470", Offset = "0xB39470", VA = "0xB39470", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xB394C8", Offset = "0xB394C8", VA = "0xB394C8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xB39554", Offset = "0xB39554", VA = "0xB39554")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xB398C4", Offset = "0xB398C4", VA = "0xB398C4")]
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
		[Address(RVA = "0xB398E8", Offset = "0xB398E8", VA = "0xB398E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xB399E0", Offset = "0xB399E0", VA = "0xB399E0")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xB39A8C", Offset = "0xB39A8C", VA = "0xB39A8C")]
	protected void Start()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xB39B3C", Offset = "0xB39B3C", VA = "0xB39B3C")]
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xB39C4C", Offset = "0xB39C4C", VA = "0xB39C4C")]
	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xB39D48", Offset = "0xB39D48", VA = "0xB39D48")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xB39EA4", Offset = "0xB39EA4", VA = "0xB39EA4")]
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
	[Address(RVA = "0xB39EBC", Offset = "0xB39EBC", VA = "0xB39EBC", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xB39F14", Offset = "0xB39F14", VA = "0xB39F14")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xB39FA0", Offset = "0xB39FA0", VA = "0xB39FA0")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xB3A2C8", Offset = "0xB3A2C8", VA = "0xB3A2C8")]
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
	[Address(RVA = "0xB3A2E4", Offset = "0xB3A2E4", VA = "0xB3A2E4")]
	private void CalculateViewProjection()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xB3A3E8", Offset = "0xB3A3E8", VA = "0xB3A3E8")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xB3A55C", Offset = "0xB3A55C", VA = "0xB3A55C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xB3A618", Offset = "0xB3A618", VA = "0xB3A618")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xB3A73C", Offset = "0xB3A73C", VA = "0xB3A73C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xB3A7C8", Offset = "0xB3A7C8", VA = "0xB3A7C8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xB3A4BC", Offset = "0xB3A4BC", VA = "0xB3A4BC")]
	private void Remember()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xB3BF78", Offset = "0xB3BF78", VA = "0xB3BF78")]
	private Camera GetTmpCam()
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xB3BEF4", Offset = "0xB3BEF4", VA = "0xB3BEF4")]
	private void StartFrame()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xB3BF68", Offset = "0xB3BF68", VA = "0xB3BF68")]
	private static int divRoundUp(int x, int d)
	{
		return default(int);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xB3C2E4", Offset = "0xB3C2E4", VA = "0xB3C2E4")]
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
	[Address(RVA = "0xB3C484", Offset = "0xB3C484", VA = "0xB3C484")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xB3C4A4", Offset = "0xB3C4A4", VA = "0xB3C4A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xB3C4A8", Offset = "0xB3C4A8", VA = "0xB3C4A8", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xB3C704", Offset = "0xB3C704", VA = "0xB3C704")]
	public void UpdateParameters()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xB3C9F8", Offset = "0xB3C9F8", VA = "0xB3C9F8")]
	private void UpdateTextures()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xB3C9FC", Offset = "0xB3C9FC", VA = "0xB3C9FC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xB3CD08", Offset = "0xB3CD08", VA = "0xB3CD08")]
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
	[Address(RVA = "0xB3D344", Offset = "0xB3D344", VA = "0xB3D344", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xB3D398", Offset = "0xB3D398", VA = "0xB3D398")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xB3D420", Offset = "0xB3D420", VA = "0xB3D420")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xB3D4A8", Offset = "0xB3D4A8", VA = "0xB3D4A8")]
	public void SetIdentityLut()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xB3D68C", Offset = "0xB3D68C", VA = "0xB3D68C")]
	public bool ValidDimensions(Texture2D tex2d)
	{
		return default(bool);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xB3D78C", Offset = "0xB3D78C", VA = "0xB3D78C")]
	public void Convert(Texture2D temp2DTex, string path)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xB3DAA8", Offset = "0xB3DAA8", VA = "0xB3DAA8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xB3DC9C", Offset = "0xB3DC9C", VA = "0xB3DC9C")]
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
	[Address(RVA = "0xB3DCEC", Offset = "0xB3DCEC", VA = "0xB3DCEC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xB3DE58", Offset = "0xB3DE58", VA = "0xB3DE58")]
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
	[Address(RVA = "0xB3DE68", Offset = "0xB3DE68", VA = "0xB3DE68", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xB3DEDC", Offset = "0xB3DEDC", VA = "0xB3DEDC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xB3E208", Offset = "0xB3E208", VA = "0xB3E208")]
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
		[Address(RVA = "0xB3E220", Offset = "0xB3E220", VA = "0xB3E220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	protected Material materialReduce
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0xB3E2D8", Offset = "0xB3E2D8", VA = "0xB3E2D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	protected Material materialAdapt
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0xB3E390", Offset = "0xB3E390", VA = "0xB3E390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	protected Material materialApply
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0xB3E448", Offset = "0xB3E448", VA = "0xB3E448")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xB3E500", Offset = "0xB3E500", VA = "0xB3E500")]
	private void Start()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xB3E584", Offset = "0xB3E584", VA = "0xB3E584")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xB3E6C0", Offset = "0xB3E6C0", VA = "0xB3E6C0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xB3E88C", Offset = "0xB3E88C", VA = "0xB3E88C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xB3EACC", Offset = "0xB3EACC", VA = "0xB3EACC")]
	private void CalculateAdaptation(Texture curTexture)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xB3EC84", Offset = "0xB3EC84", VA = "0xB3EC84")]
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
	[Address(RVA = "0xB3ECF4", Offset = "0xB3ECF4", VA = "0xB3ECF4", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xB3ED7C", Offset = "0xB3ED7C", VA = "0xB3ED7C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xB3F0F4", Offset = "0xB3F0F4", VA = "0xB3F0F4")]
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
	[Address(RVA = "0xB3F110", Offset = "0xB3F110", VA = "0xB3F110", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xB3F2B8", Offset = "0xB3F2B8", VA = "0xB3F2B8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xB3F324", Offset = "0xB3F324", VA = "0xB3F324")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xB3F3FC", Offset = "0xB3F3FC", VA = "0xB3F3FC")]
	private void ReleaseComputeResources()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xB3F198", Offset = "0xB3F198", VA = "0xB3F198")]
	private void CreateComputeResources()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xB3F434", Offset = "0xB3F434", VA = "0xB3F434")]
	private float FocalDistance01(float worldDist)
	{
		return default(float);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xB3F580", Offset = "0xB3F580", VA = "0xB3F580")]
	private void WriteCoc(RenderTexture fromTo, bool fgDilate)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xB3F850", Offset = "0xB3F850", VA = "0xB3F850")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xB40B74", Offset = "0xB40B74", VA = "0xB40B74")]
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
	[Address(RVA = "0xB40BCC", Offset = "0xB40BCC", VA = "0xB40BCC")]
	private void CreateMaterials()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xB40C9C", Offset = "0xB40C9C", VA = "0xB40C9C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xB40DA4", Offset = "0xB40DA4", VA = "0xB40DA4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xB40DAC", Offset = "0xB40DAC", VA = "0xB40DAC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xB40E1C", Offset = "0xB40E1C", VA = "0xB40E1C")]
	private float FocalDistance01(float worldDist)
	{
		return default(float);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xB40F08", Offset = "0xB40F08", VA = "0xB40F08")]
	private int GetDividerBasedOnQuality()
	{
		return default(int);
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xB40F2C", Offset = "0xB40F2C", VA = "0xB40F2C")]
	private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
	{
		return default(int);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xB40F50", Offset = "0xB40F50", VA = "0xB40F50")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xB41C20", Offset = "0xB41C20", VA = "0xB41C20")]
	private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xB421D4", Offset = "0xB421D4", VA = "0xB421D4")]
	private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xB42548", Offset = "0xB42548", VA = "0xB42548")]
	private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xB41AF8", Offset = "0xB41AF8", VA = "0xB41AF8")]
	private void Downsample(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xB41E00", Offset = "0xB41E00", VA = "0xB41E00")]
	private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xB423E0", Offset = "0xB423E0", VA = "0xB423E0")]
	private void ReleaseTextures()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xB417E4", Offset = "0xB417E4", VA = "0xB417E4")]
	private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xB426E8", Offset = "0xB426E8", VA = "0xB426E8")]
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
	[Address(RVA = "0xB427B0", Offset = "0xB427B0", VA = "0xB427B0", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xB428D8", Offset = "0xB428D8", VA = "0xB428D8")]
	private new void Start()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xB42828", Offset = "0xB42828", VA = "0xB42828")]
	private void SetCameraFlag()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xB428E4", Offset = "0xB428E4", VA = "0xB428E4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xB428E8", Offset = "0xB428E8", VA = "0xB428E8")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xB42ABC", Offset = "0xB42ABC", VA = "0xB42ABC")]
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
	[Address(RVA = "0xB42AEC", Offset = "0xB42AEC", VA = "0xB42AEC", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xB42B44", Offset = "0xB42B44", VA = "0xB42B44")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xB42C78", Offset = "0xB42C78", VA = "0xB42C78")]
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
	[Address(RVA = "0xB42C90", Offset = "0xB42C90", VA = "0xB42C90", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xB42CF0", Offset = "0xB42CF0", VA = "0xB42CF0")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xB43618", Offset = "0xB43618", VA = "0xB43618")]
	private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xB43778", Offset = "0xB43778", VA = "0xB43778")]
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
	[Address(RVA = "0xB43798", Offset = "0xB43798", VA = "0xB43798")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xB4387C", Offset = "0xB4387C", VA = "0xB4387C")]
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
		[Address(RVA = "0xB3DDA0", Offset = "0xB3DDA0", VA = "0xB3DDA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xB43884", Offset = "0xB43884", VA = "0xB43884", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xB43924", Offset = "0xB43924", VA = "0xB43924", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xB3DE60", Offset = "0xB3DE60", VA = "0xB3DE60")]
	public ImageEffectBase()
	{
	}
}
[Token(Token = "0x200002C")]
[AddComponentMenu("")]
public class ImageEffects
{
	[Token(Token = "0x600007E")]
	[Address(RVA = "0xB439B0", Offset = "0xB439B0", VA = "0xB439B0")]
	public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xB43C20", Offset = "0xB43C20", VA = "0xB43C20")]
	[Obsolete("Use Graphics.Blit(source,dest) instead")]
	public static void Blit(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xB43C88", Offset = "0xB43C88", VA = "0xB43C88")]
	[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
	public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xB43CF8", Offset = "0xB43CF8", VA = "0xB43CF8")]
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
	[Address(RVA = "0xB43D00", Offset = "0xB43D00", VA = "0xB43D00", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xB43D04", Offset = "0xB43D04", VA = "0xB43D04", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xB43D68", Offset = "0xB43D68", VA = "0xB43D68")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xB440B4", Offset = "0xB440B4", VA = "0xB440B4")]
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
	[Address(RVA = "0xB440C8", Offset = "0xB440C8", VA = "0xB440C8", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xB44144", Offset = "0xB44144", VA = "0xB44144")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xB44944", Offset = "0xB44944", VA = "0xB44944")]
	private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xB44C84", Offset = "0xB44C84", VA = "0xB44C84")]
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
		[Address(RVA = "0xB45E40", Offset = "0xB45E40", VA = "0xB45E40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xB45D14", Offset = "0xB45D14", VA = "0xB45D14")]
	protected void Start()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xB45F88", Offset = "0xB45F88", VA = "0xB45F88")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xB46058", Offset = "0xB46058", VA = "0xB46058")]
	private void SanitizeParameters()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xB460FC", Offset = "0xB460FC", VA = "0xB460FC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xB46424", Offset = "0xB46424", VA = "0xB46424")]
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
	[Address(RVA = "0xB46458", Offset = "0xB46458", VA = "0xB46458")]
	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xB46818", Offset = "0xB46818", VA = "0xB46818")]
	protected Material CreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xB469FC", Offset = "0xB469FC", VA = "0xB469FC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xB46A08", Offset = "0xB46A08", VA = "0xB46A08")]
	protected bool CheckSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xB46AC4", Offset = "0xB46AC4", VA = "0xB46AC4", Slot = "4")]
	public virtual bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xB46B84", Offset = "0xB46B84", VA = "0xB46B84")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xB46A10", Offset = "0xB46A10", VA = "0xB46A10")]
	protected bool CheckSupport(bool needDepth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xB46BF0", Offset = "0xB46BF0", VA = "0xB46BF0")]
	protected bool CheckSupport(bool needDepth, bool needHdr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xB46C48", Offset = "0xB46C48", VA = "0xB46C48")]
	public bool Dx11Support()
	{
		return default(bool);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xB46C50", Offset = "0xB46C50", VA = "0xB46C50")]
	protected void ReportAutoDisable()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xB46D08", Offset = "0xB46D08", VA = "0xB46D08")]
	private bool CheckShader(Shader s)
	{
		return default(bool);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xB467F8", Offset = "0xB467F8", VA = "0xB467F8")]
	protected void NotSupported()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xB46F20", Offset = "0xB46F20", VA = "0xB46F20")]
	protected void DrawBorder(RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xB47298", Offset = "0xB47298", VA = "0xB47298")]
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
	[Address(RVA = "0xB472B0", Offset = "0xB472B0", VA = "0xB472B0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xB47318", Offset = "0xB47318", VA = "0xB47318")]
	private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xB47564", Offset = "0xB47564", VA = "0xB47564")]
	private static void DrawBorder(RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xB478D8", Offset = "0xB478D8", VA = "0xB478D8")]
	private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xB47A7C", Offset = "0xB47A7C", VA = "0xB47A7C")]
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
	[Address(RVA = "0xB47A84", Offset = "0xB47A84", VA = "0xB47A84")]
	private static bool HasMeshes()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xB47B54", Offset = "0xB47B54", VA = "0xB47B54")]
	public static void Cleanup()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xB47C90", Offset = "0xB47C90", VA = "0xB47C90")]
	public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xB47EAC", Offset = "0xB47EAC", VA = "0xB47EAC")]
	private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xB48230", Offset = "0xB48230", VA = "0xB48230")]
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
	[Address(RVA = "0xB48238", Offset = "0xB48238", VA = "0xB48238", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xB48284", Offset = "0xB48284", VA = "0xB48284")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xB483D4", Offset = "0xB483D4", VA = "0xB483D4")]
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
	[Address(RVA = "0xB483F8", Offset = "0xB483F8", VA = "0xB483F8", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xB4844C", Offset = "0xB4844C", VA = "0xB4844C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xB484D4", Offset = "0xB484D4", VA = "0xB484D4")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xB48A84", Offset = "0xB48A84", VA = "0xB48A84")]
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
	[Address(RVA = "0xB48AB4", Offset = "0xB48AB4", VA = "0xB48AB4")]
	private static Material CreateMaterial(Shader shader)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xB48B60", Offset = "0xB48B60", VA = "0xB48B60")]
	private static void DestroyMaterial(Material mat)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xB48BE4", Offset = "0xB48BE4", VA = "0xB48BE4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xB48BEC", Offset = "0xB48BEC", VA = "0xB48BEC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xB48D6C", Offset = "0xB48D6C", VA = "0xB48D6C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xB48CB4", Offset = "0xB48CB4", VA = "0xB48CB4")]
	private void CreateMaterials()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xB48DD8", Offset = "0xB48DD8", VA = "0xB48DD8")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xB493AC", Offset = "0xB493AC", VA = "0xB493AC")]
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
	[Address(RVA = "0xB493E0", Offset = "0xB493E0", VA = "0xB493E0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xB49464", Offset = "0xB49464", VA = "0xB49464")]
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
	[Address(RVA = "0xB4946C", Offset = "0xB4946C", VA = "0xB4946C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xB494C8", Offset = "0xB494C8", VA = "0xB494C8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xB49B84", Offset = "0xB49B84", VA = "0xB49B84")]
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
	[Address(RVA = "0xB49BD8", Offset = "0xB49BD8", VA = "0xB49BD8", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xB49C2C", Offset = "0xB49C2C", VA = "0xB49C2C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xB49EBC", Offset = "0xB49EBC", VA = "0xB49EBC")]
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
	[Address(RVA = "0xB49EE4", Offset = "0xB49EE4", VA = "0xB49EE4", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xB4A01C", Offset = "0xB4A01C", VA = "0xB4A01C")]
	public float UpdateCurve()
	{
		return default(float);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xB4A294", Offset = "0xB4A294", VA = "0xB4A294")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xB4A3AC", Offset = "0xB4A3AC", VA = "0xB4A3AC")]
	private bool CreateInternalRenderTexture()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xB4A49C", Offset = "0xB4A49C", VA = "0xB4A49C")]
	[ImageEffectTransformsToLDR]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xB4AC24", Offset = "0xB4AC24", VA = "0xB4AC24")]
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
	[Address(RVA = "0xB4AC60", Offset = "0xB4AC60", VA = "0xB4AC60")]
	private static bool HasMeshes()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xB4AD34", Offset = "0xB4AD34", VA = "0xB4AD34")]
	private static void Cleanup()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xB4AE70", Offset = "0xB4AE70", VA = "0xB4AE70")]
	private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xB4B08C", Offset = "0xB4B08C", VA = "0xB4B08C")]
	private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xB4B380", Offset = "0xB4B380", VA = "0xB4B380")]
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
	[Address(RVA = "0xB4B388", Offset = "0xB4B388", VA = "0xB4B388")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xB4B3C8", Offset = "0xB4B3C8", VA = "0xB4B3C8")]
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
	[Address(RVA = "0xB4B3F0", Offset = "0xB4B3F0", VA = "0xB4B3F0", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xB4B468", Offset = "0xB4B468", VA = "0xB4B468")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xB4B9A4", Offset = "0xB4B9A4", VA = "0xB4B9A4")]
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
	[Address(RVA = "0xB4B9E4", Offset = "0xB4B9E4", VA = "0xB4B9E4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xB4BA24", Offset = "0xB4BA24", VA = "0xB4BA24")]
	public Vortex()
	{
	}
}
