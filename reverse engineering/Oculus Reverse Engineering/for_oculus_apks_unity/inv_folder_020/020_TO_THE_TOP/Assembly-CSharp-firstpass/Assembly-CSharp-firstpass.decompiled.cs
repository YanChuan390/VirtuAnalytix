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
[Attribute(Name = "RequireComponent", RVA = "0xAF3F04", Offset = "0xAF3F04")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF3F04", Offset = "0xAF3F04")]
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
	[Address(RVA = "0x1DB32E0", Offset = "0x1DB32E0", VA = "0x1DB32E0")]
	public Material CurrentAAMaterial()
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1DB3344", Offset = "0x1DB3344", VA = "0x1DB3344", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1DB3834", Offset = "0x1DB3834", VA = "0x1DB3834")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1DB3E34", Offset = "0x1DB3E34", VA = "0x1DB3E34")]
	public Antialiasing()
	{
	}
}
[Token(Token = "0x2000004")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF3F9C", Offset = "0xAF3F9C")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF3F9C", Offset = "0xAF3F9C")]
public class Bloom : PostEffectsBase
{
	[Token(Token = "0x200002D")]
	public enum LensFlareStyle
	{
		[Token(Token = "0x40001B2")]
		Ghosting,
		[Token(Token = "0x40001B3")]
		Anamorphic,
		[Token(Token = "0x40001B4")]
		Combined
	}

	[Token(Token = "0x200002E")]
	public enum TweakMode
	{
		[Token(Token = "0x40001B6")]
		Basic,
		[Token(Token = "0x40001B7")]
		Complex
	}

	[Token(Token = "0x200002F")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x40001B9")]
		Auto,
		[Token(Token = "0x40001BA")]
		On,
		[Token(Token = "0x40001BB")]
		Off
	}

	[Token(Token = "0x2000030")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x40001BD")]
		Screen,
		[Token(Token = "0x40001BE")]
		Add
	}

	[Token(Token = "0x2000031")]
	public enum BloomQuality
	{
		[Token(Token = "0x40001C0")]
		Cheap,
		[Token(Token = "0x40001C1")]
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
	[Address(RVA = "0x1DB3E74", Offset = "0x1DB3E74", VA = "0x1DB3E74", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1DB4348", Offset = "0x1DB4348", VA = "0x1DB4348")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1DB5978", Offset = "0x1DB5978", VA = "0x1DB5978")]
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1DB56CC", Offset = "0x1DB56CC", VA = "0x1DB56CC")]
	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1DB53BC", Offset = "0x1DB53BC", VA = "0x1DB53BC")]
	private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1DB52B4", Offset = "0x1DB52B4", VA = "0x1DB52B4")]
	private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1DB54AC", Offset = "0x1DB54AC", VA = "0x1DB54AC")]
	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1DB5A50", Offset = "0x1DB5A50", VA = "0x1DB5A50")]
	public Bloom()
	{
	}
}
[Token(Token = "0x2000005")]
public enum LensflareStyle34
{
	[Token(Token = "0x400003E")]
	Ghosting,
	[Token(Token = "0x400003F")]
	Anamorphic,
	[Token(Token = "0x4000040")]
	Combined
}
[Token(Token = "0x2000006")]
public enum TweakMode34
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
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF4034", Offset = "0xAF4034")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4034", Offset = "0xAF4034")]
public class BloomAndFlares : PostEffectsBase
{
	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x1C")]
	public TweakMode34 tweakMode;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x20")]
	public BloomScreenBlendMode screenBlendMode;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x24")]
	public HDRBloomMode hdr;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x28")]
	private bool doHdr;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x2C")]
	public float sepBlurSpread;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x30")]
	public float useSrcAlphaAsMask;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x34")]
	public float bloomIntensity;

	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x38")]
	public float bloomThreshold;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x3C")]
	public int bloomBlurIterations;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x40")]
	public bool lensflares;

	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x44")]
	public int hollywoodFlareBlurIterations;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x48")]
	public LensflareStyle34 lensflareMode;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x4C")]
	public float hollyStretchWidth;

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x50")]
	public float lensflareIntensity;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x54")]
	public float lensflareThreshold;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x58")]
	public Color flareColorA;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x68")]
	public Color flareColorB;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x78")]
	public Color flareColorC;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x88")]
	public Color flareColorD;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x98")]
	public Texture2D lensFlareVignetteMask;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0xA0")]
	public Shader lensFlareShader;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0xA8")]
	private Material lensFlareMaterial;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0xB0")]
	public Shader vignetteShader;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0xB8")]
	private Material vignetteMaterial;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0xC0")]
	public Shader separableBlurShader;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0xC8")]
	private Material separableBlurMaterial;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0xD0")]
	public Shader addBrightStuffOneOneShader;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0xD8")]
	private Material addBrightStuffBlendOneOneMaterial;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0xE0")]
	public Shader screenBlendShader;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0xE8")]
	private Material screenBlend;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0xF0")]
	public Shader hollywoodFlaresShader;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0xF8")]
	private Material hollywoodFlaresMaterial;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x100")]
	public Shader brightPassFilterShader;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x108")]
	private Material brightPassFilterMaterial;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1DB5BD8", Offset = "0x1DB5BD8", VA = "0x1DB5BD8", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1DB5C90", Offset = "0x1DB5C90", VA = "0x1DB5C90")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1DB6E88", Offset = "0x1DB6E88", VA = "0x1DB6E88")]
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1DB6BF4", Offset = "0x1DB6BF4", VA = "0x1DB6BF4")]
	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1DB6944", Offset = "0x1DB6944", VA = "0x1DB6944")]
	private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1DB6A7C", Offset = "0x1DB6A7C", VA = "0x1DB6A7C")]
	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1DB6F44", Offset = "0x1DB6F44", VA = "0x1DB6F44")]
	public BloomAndFlares()
	{
	}
}
[Token(Token = "0x200000A")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF40CC", Offset = "0xAF40CC")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF40CC", Offset = "0xAF40CC")]
public class BloomOptimized : PostEffectsBase
{
	[Token(Token = "0x2000032")]
	public enum Resolution
	{
		[Token(Token = "0x40001C3")]
		Low,
		[Token(Token = "0x40001C4")]
		High
	}

	[Token(Token = "0x2000033")]
	public enum BlurType
	{
		[Token(Token = "0x40001C6")]
		Standard,
		[Token(Token = "0x40001C7")]
		Sgx
	}

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xAF50F0", Offset = "0xAF50F0")]
	public float threshold;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0xAF5108", Offset = "0xAF5108")]
	public float intensity;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0xAF5120", Offset = "0xAF5120")]
	public float blurSize;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x28")]
	private Resolution resolution;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xAF5138", Offset = "0xAF5138")]
	public int blurIterations;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x30")]
	public BlurType blurType;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x38")]
	public Shader fastBloomShader;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x40")]
	private Material fastBloomMaterial;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1DB70B8", Offset = "0x1DB70B8", VA = "0x1DB70B8", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1DB7110", Offset = "0x1DB7110", VA = "0x1DB7110")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1DB71C0", Offset = "0x1DB71C0", VA = "0x1DB71C0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1DB761C", Offset = "0x1DB761C", VA = "0x1DB761C")]
	public BloomOptimized()
	{
	}
}
[Token(Token = "0x200000B")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4164", Offset = "0xAF4164")]
public class Blur : MonoBehaviour
{
	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x18")]
	public int iterations;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x1C")]
	public float blurSpread;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x20")]
	public Shader blurShader;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x0")]
	private static Material m_Material;

	[Token(Token = "0x17000001")]
	protected Material material
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1DB7648", Offset = "0x1DB7648", VA = "0x1DB7648")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1DB7788", Offset = "0x1DB7788", VA = "0x1DB7788")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1DB7884", Offset = "0x1DB7884", VA = "0x1DB7884")]
	protected void Start()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1DB7958", Offset = "0x1DB7958", VA = "0x1DB7958")]
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1DB7B34", Offset = "0x1DB7B34", VA = "0x1DB7B34")]
	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1DB7CEC", Offset = "0x1DB7CEC", VA = "0x1DB7CEC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1DB7E68", Offset = "0x1DB7E68", VA = "0x1DB7E68")]
	public Blur()
	{
	}
}
[Token(Token = "0x200000C")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF41B0", Offset = "0xAF41B0")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF41B0", Offset = "0xAF41B0")]
public class BlurOptimized : PostEffectsBase
{
	[Token(Token = "0x2000034")]
	public enum BlurType
	{
		[Token(Token = "0x40001C9")]
		StandardGauss,
		[Token(Token = "0x40001CA")]
		SgxGauss
	}

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xAF5150", Offset = "0xAF5150")]
	public int downsample;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0xAF5168", Offset = "0xAF5168")]
	public float blurSize;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0xAF5180", Offset = "0xAF5180")]
	public int blurIterations;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x28")]
	public BlurType blurType;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x30")]
	public Shader blurShader;

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x38")]
	private Material blurMaterial;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1DB7E84", Offset = "0x1DB7E84", VA = "0x1DB7E84", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1DB7EDC", Offset = "0x1DB7EDC", VA = "0x1DB7EDC")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1DB7F8C", Offset = "0x1DB7F8C", VA = "0x1DB7F8C")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1DB83BC", Offset = "0x1DB83BC", VA = "0x1DB83BC")]
	public BlurOptimized()
	{
	}
}
[Token(Token = "0x200000D")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF4248", Offset = "0xAF4248")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4248", Offset = "0xAF4248")]
public class CameraMotionBlur : PostEffectsBase
{
	[Token(Token = "0x2000035")]
	public enum MotionBlurFilter
	{
		[Token(Token = "0x40001CC")]
		CameraMotion,
		[Token(Token = "0x40001CD")]
		LocalBlur,
		[Token(Token = "0x40001CE")]
		Reconstruction,
		[Token(Token = "0x40001CF")]
		ReconstructionDX11,
		[Token(Token = "0x40001D0")]
		ReconstructionDisc
	}

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x0")]
	private static float MAX_RADIUS;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x1C")]
	public MotionBlurFilter filterType;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x20")]
	public bool preview;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 previewScale;

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x30")]
	public float movementScale;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x34")]
	public float rotationScale;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x38")]
	public float maxVelocity;

	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x3C")]
	public float minVelocity;

	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x40")]
	public float velocityScale;

	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x44")]
	public float softZDistance;

	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x48")]
	public int velocityDownsample;

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x4C")]
	public LayerMask excludeLayers;

	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x50")]
	private GameObject tmpCam;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x58")]
	public Shader shader;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x60")]
	public Shader dx11MotionBlurShader;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x68")]
	public Shader replacementClear;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x70")]
	private Material motionBlurMaterial;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x78")]
	private Material dx11MotionBlurMaterial;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x80")]
	public Texture2D noiseTexture;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x88")]
	public float jitter;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x8C")]
	public bool showVelocity;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x90")]
	public float showVelocityScale;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x94")]
	private Matrix4x4 currentViewProjMat;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0xD4")]
	private Matrix4x4 prevViewProjMat;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x114")]
	private int prevFrameCount;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x118")]
	private bool wasActive;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x11C")]
	private Vector3 prevFrameForward;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x128")]
	private Vector3 prevFrameUp;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x134")]
	private Vector3 prevFramePos;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x140")]
	private Camera _camera;

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1DB83E4", Offset = "0x1DB83E4", VA = "0x1DB83E4")]
	private void CalculateViewProjection()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1DB854C", Offset = "0x1DB854C", VA = "0x1DB854C")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1DB86F8", Offset = "0x1DB86F8", VA = "0x1DB86F8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1DB87D8", Offset = "0x1DB87D8", VA = "0x1DB87D8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1DB893C", Offset = "0x1DB893C", VA = "0x1DB893C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1DB8A20", Offset = "0x1DB8A20", VA = "0x1DB8A20")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1DB862C", Offset = "0x1DB862C", VA = "0x1DB862C")]
	private void Remember()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1DBA3AC", Offset = "0x1DBA3AC", VA = "0x1DBA3AC")]
	private Camera GetTmpCam()
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1DBA2B8", Offset = "0x1DBA2B8", VA = "0x1DBA2B8")]
	private void StartFrame()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1DBA39C", Offset = "0x1DBA39C", VA = "0x1DBA39C")]
	private static int divRoundUp(int x, int d)
	{
		return default(int);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1DBA850", Offset = "0x1DBA850", VA = "0x1DBA850")]
	public CameraMotionBlur()
	{
	}
}
[Token(Token = "0x200000E")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF42E0", Offset = "0xAF42E0")]
public class ColorCorrectionCurves : PostEffectsBase
{
	[Token(Token = "0x2000036")]
	public enum ColorCorrectionMode
	{
		[Token(Token = "0x40001D2")]
		Simple,
		[Token(Token = "0x40001D3")]
		Advanced
	}

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve redChannel;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve greenChannel;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve blueChannel;

	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x38")]
	public bool useDepthCorrection;

	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x40")]
	public AnimationCurve zCurve;

	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve depthRedChannel;

	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve depthGreenChannel;

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve depthBlueChannel;

	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x60")]
	private Material ccMaterial;

	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x68")]
	private Material ccDepthMaterial;

	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x70")]
	private Material selectiveCcMaterial;

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x78")]
	private Texture2D rgbChannelTex;

	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x80")]
	private Texture2D rgbDepthChannelTex;

	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x88")]
	private Texture2D zCurveTex;

	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x90")]
	public float saturation;

	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x94")]
	public bool selectiveCc;

	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x98")]
	public Color selectiveFromColor;

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0xA8")]
	public Color selectiveToColor;

	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0xB8")]
	public ColorCorrectionMode mode;

	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0xBC")]
	public bool updateTextures;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0xC0")]
	public Shader colorCorrectionCurvesShader;

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0xC8")]
	public Shader simpleColorCorrectionCurvesShader;

	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0xD0")]
	public Shader colorCorrectionSelectiveShader;

	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0xD8")]
	private bool updateTexturesOnStartup;

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1DBA9AC", Offset = "0x1DBA9AC", VA = "0x1DBA9AC")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1DBA9E8", Offset = "0x1DBA9E8", VA = "0x1DBA9E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1DBA9EC", Offset = "0x1DBA9EC", VA = "0x1DBA9EC", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1DBAC90", Offset = "0x1DBAC90", VA = "0x1DBAC90")]
	public void UpdateParameters()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1DBB134", Offset = "0x1DBB134", VA = "0x1DBB134")]
	private void UpdateTextures()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1DBB138", Offset = "0x1DBB138", VA = "0x1DBB138")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1DBB524", Offset = "0x1DBB524", VA = "0x1DBB524")]
	public ColorCorrectionCurves()
	{
	}
}
[Token(Token = "0x200000F")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF432C", Offset = "0xAF432C")]
public class ColorCorrectionLookup : PostEffectsBase
{
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x20")]
	public Shader shader;

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x28")]
	private Material material;

	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x30")]
	public Texture3D converted3DLut;

	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x38")]
	public string basedOnTempTex;

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1DBBC68", Offset = "0x1DBBC68", VA = "0x1DBBC68", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1DBBCBC", Offset = "0x1DBBCBC", VA = "0x1DBBCBC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1DBBD64", Offset = "0x1DBBD64", VA = "0x1DBBD64")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1DBBE0C", Offset = "0x1DBBE0C", VA = "0x1DBBE0C")]
	public void SetIdentityLut()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1DBC054", Offset = "0x1DBC054", VA = "0x1DBC054")]
	public bool ValidDimensions(Texture2D tex2d)
	{
		return default(bool);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1DBC158", Offset = "0x1DBC158", VA = "0x1DBC158")]
	public void Convert(Texture2D temp2DTex, string path)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1DBC558", Offset = "0x1DBC558", VA = "0x1DBC558")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1DBC784", Offset = "0x1DBC784", VA = "0x1DBC784")]
	public ColorCorrectionLookup()
	{
	}
}
[Token(Token = "0x2000010")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4378", Offset = "0xAF4378")]
public class ColorCorrectionRamp : ImageEffectBase
{
	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x28")]
	public Texture textureRamp;

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1DBC7E8", Offset = "0x1DBC7E8", VA = "0x1DBC7E8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1DBC97C", Offset = "0x1DBC97C", VA = "0x1DBC97C")]
	public ColorCorrectionRamp()
	{
	}
}
[Token(Token = "0x2000011")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF43C4", Offset = "0xAF43C4")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF43C4", Offset = "0xAF43C4")]
internal class ContrastEnhance : PostEffectsBase
{
	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x1C")]
	public float intensity;

	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x20")]
	public float threshold;

	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x28")]
	private Material separableBlurMaterial;

	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x30")]
	private Material contrastCompositeMaterial;

	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x38")]
	public float blurSpread;

	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x40")]
	public Shader separableBlurShader;

	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x48")]
	public Shader contrastCompositeShader;

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1DBC98C", Offset = "0x1DBC98C", VA = "0x1DBC98C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1DBC9FC", Offset = "0x1DBC9FC", VA = "0x1DBC9FC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1DBCDB8", Offset = "0x1DBCDB8", VA = "0x1DBCDB8")]
	public ContrastEnhance()
	{
	}
}
[Token(Token = "0x2000012")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF445C", Offset = "0xAF445C")]
public class ContrastStretch : MonoBehaviour
{
	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x18")]
	public float adaptationSpeed;

	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x1C")]
	public float limitMinimum;

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x20")]
	public float limitMaximum;

	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x28")]
	private RenderTexture[] adaptRenderTex;

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x30")]
	private int curAdaptIndex;

	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x38")]
	public Shader shaderLum;

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x40")]
	private Material m_materialLum;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x48")]
	public Shader shaderReduce;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x50")]
	private Material m_materialReduce;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x58")]
	public Shader shaderAdapt;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x60")]
	private Material m_materialAdapt;

	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x68")]
	public Shader shaderApply;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x70")]
	private Material m_materialApply;

	[Token(Token = "0x17000002")]
	protected Material materialLum
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1DBCDDC", Offset = "0x1DBCDDC", VA = "0x1DBCDDC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	protected Material materialReduce
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1DBCEA4", Offset = "0x1DBCEA4", VA = "0x1DBCEA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	protected Material materialAdapt
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1DBCF6C", Offset = "0x1DBCF6C", VA = "0x1DBCF6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	protected Material materialApply
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1DBD034", Offset = "0x1DBD034", VA = "0x1DBD034")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1DBD0FC", Offset = "0x1DBD0FC", VA = "0x1DBD0FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1DBD1BC", Offset = "0x1DBD1BC", VA = "0x1DBD1BC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1DBD35C", Offset = "0x1DBD35C", VA = "0x1DBD35C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1DBD5AC", Offset = "0x1DBD5AC", VA = "0x1DBD5AC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1DBD840", Offset = "0x1DBD840", VA = "0x1DBD840")]
	private void CalculateAdaptation(Texture curTexture)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1DBDAAC", Offset = "0x1DBDAAC", VA = "0x1DBDAAC")]
	public ContrastStretch()
	{
	}
}
[Token(Token = "0x2000013")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF44A8", Offset = "0xAF44A8")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF44A8", Offset = "0xAF44A8")]
internal class CreaseShading : PostEffectsBase
{
	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x1C")]
	public float intensity;

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x20")]
	public int softness;

	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x24")]
	public float spread;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x28")]
	public Shader blurShader;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x30")]
	private Material blurMaterial;

	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x38")]
	public Shader depthFetchShader;

	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0x40")]
	private Material depthFetchMaterial;

	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x48")]
	public Shader creaseApplyShader;

	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x50")]
	private Material creaseApplyMaterial;

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1DBDB2C", Offset = "0x1DBDB2C", VA = "0x1DBDB2C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1DBDBA4", Offset = "0x1DBDBA4", VA = "0x1DBDBA4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1DBDF94", Offset = "0x1DBDF94", VA = "0x1DBDF94")]
	public CreaseShading()
	{
	}
}
[Token(Token = "0x2000014")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF4540", Offset = "0xAF4540")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4540", Offset = "0xAF4540")]
public class DepthOfField : PostEffectsBase
{
	[Token(Token = "0x2000037")]
	public enum BlurType
	{
		[Token(Token = "0x40001D5")]
		DiscBlur,
		[Token(Token = "0x40001D6")]
		DX11
	}

	[Token(Token = "0x2000038")]
	public enum BlurSampleCount
	{
		[Token(Token = "0x40001D8")]
		Low,
		[Token(Token = "0x40001D9")]
		Medium,
		[Token(Token = "0x40001DA")]
		High
	}

	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x1B")]
	public bool visualizeFocus;

	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x1C")]
	public float focalLength;

	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x20")]
	public float focalSize;

	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x24")]
	public float aperture;

	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x28")]
	public Transform focalTransform;

	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x30")]
	public float maxBlurSize;

	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x34")]
	public bool highResolution;

	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x38")]
	public BlurType blurType;

	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x3C")]
	public BlurSampleCount blurSampleCount;

	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x40")]
	public bool nearBlur;

	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x44")]
	public float foregroundOverlap;

	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x48")]
	public Shader dofHdrShader;

	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x50")]
	private Material dofHdrMaterial;

	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x58")]
	public Shader dx11BokehShader;

	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x60")]
	private Material dx11bokehMaterial;

	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x68")]
	public float dx11BokehThreshold;

	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x6C")]
	public float dx11SpawnHeuristic;

	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x70")]
	public Texture2D dx11BokehTexture;

	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x78")]
	public float dx11BokehScale;

	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x7C")]
	public float dx11BokehIntensity;

	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x80")]
	private float focalDistance01;

	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x88")]
	private ComputeBuffer cbDrawArgs;

	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x90")]
	private ComputeBuffer cbPoints;

	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x98")]
	private float internalBlurWidth;

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1DBDFBC", Offset = "0x1DBDFBC", VA = "0x1DBDFBC", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1DBE1B4", Offset = "0x1DBE1B4", VA = "0x1DBE1B4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1DBE24C", Offset = "0x1DBE24C", VA = "0x1DBE24C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1DBE354", Offset = "0x1DBE354", VA = "0x1DBE354")]
	private void ReleaseComputeResources()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1DBE040", Offset = "0x1DBE040", VA = "0x1DBE040")]
	private void CreateComputeResources()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1DBE398", Offset = "0x1DBE398", VA = "0x1DBE398")]
	private float FocalDistance01(float worldDist)
	{
		return default(float);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1DBE5AC", Offset = "0x1DBE5AC", VA = "0x1DBE5AC")]
	private void WriteCoc(RenderTexture fromTo, bool fgDilate)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1DBE940", Offset = "0x1DBE940", VA = "0x1DBE940")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1DC03B0", Offset = "0x1DC03B0", VA = "0x1DC03B0")]
	public DepthOfField()
	{
	}
}
[Token(Token = "0x2000015")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF45D8", Offset = "0xAF45D8")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF45D8", Offset = "0xAF45D8")]
public class DepthOfFieldDeprecated : PostEffectsBase
{
	[Token(Token = "0x2000039")]
	public enum Dof34QualitySetting
	{
		[Token(Token = "0x40001DC")]
		OnlyBackground = 1,
		[Token(Token = "0x40001DD")]
		BackgroundAndForeground
	}

	[Token(Token = "0x200003A")]
	public enum DofResolution
	{
		[Token(Token = "0x40001DF")]
		High = 2,
		[Token(Token = "0x40001E0")]
		Medium,
		[Token(Token = "0x40001E1")]
		Low
	}

	[Token(Token = "0x200003B")]
	public enum DofBlurriness
	{
		[Token(Token = "0x40001E3")]
		Low = 1,
		[Token(Token = "0x40001E4")]
		High = 2,
		[Token(Token = "0x40001E5")]
		VeryHigh = 4
	}

	[Token(Token = "0x200003C")]
	public enum BokehDestination
	{
		[Token(Token = "0x40001E7")]
		Background = 1,
		[Token(Token = "0x40001E8")]
		Foreground,
		[Token(Token = "0x40001E9")]
		BackgroundAndForeground
	}

	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x0")]
	private static int SMOOTH_DOWNSAMPLE_PASS;

	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x4")]
	private static float BOKEH_EXTRA_BLUR;

	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x1C")]
	public Dof34QualitySetting quality;

	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x20")]
	public DofResolution resolution;

	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x24")]
	public bool simpleTweakMode;

	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0x28")]
	public float focalPoint;

	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0x2C")]
	public float smoothness;

	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x30")]
	public float focalZDistance;

	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x34")]
	public float focalZStartCurve;

	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x38")]
	public float focalZEndCurve;

	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x3C")]
	private float focalStartCurve;

	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x40")]
	private float focalEndCurve;

	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x44")]
	private float focalDistance01;

	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x48")]
	public Transform objectFocus;

	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x50")]
	public float focalSize;

	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x54")]
	public DofBlurriness bluriness;

	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x58")]
	public float maxBlurSpread;

	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x5C")]
	public float foregroundBlurExtrude;

	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x60")]
	public Shader dofBlurShader;

	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x68")]
	private Material dofBlurMaterial;

	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x70")]
	public Shader dofShader;

	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x78")]
	private Material dofMaterial;

	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x80")]
	public bool visualize;

	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x84")]
	public BokehDestination bokehDestination;

	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x88")]
	private float widthOverHeight;

	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x8C")]
	private float oneOverBaseSize;

	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x90")]
	public bool bokeh;

	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x91")]
	public bool bokehSupport;

	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x98")]
	public Shader bokehShader;

	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0xA0")]
	public Texture2D bokehTexture;

	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0xA8")]
	public float bokehScale;

	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0xAC")]
	public float bokehIntensity;

	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0xB0")]
	public float bokehThresholdContrast;

	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0xB4")]
	public float bokehThresholdLuminance;

	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0xB8")]
	public int bokehDownsample;

	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0xC0")]
	private Material bokehMaterial;

	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0xC8")]
	private Camera _camera;

	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0xD0")]
	private RenderTexture foregroundTexture;

	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0xD8")]
	private RenderTexture mediumRezWorkTexture;

	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0xE0")]
	private RenderTexture finalDefocus;

	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0xE8")]
	private RenderTexture lowRezWorkTexture;

	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0xF0")]
	private RenderTexture bokehSource;

	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0xF8")]
	private RenderTexture bokehSource2;

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1DC0420", Offset = "0x1DC0420", VA = "0x1DC0420")]
	private void CreateMaterials()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1DC04F8", Offset = "0x1DC04F8", VA = "0x1DC04F8", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1DC0600", Offset = "0x1DC0600", VA = "0x1DC0600")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1DC087C", Offset = "0x1DC087C", VA = "0x1DC087C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1DC0918", Offset = "0x1DC0918", VA = "0x1DC0918")]
	private float FocalDistance01(float worldDist)
	{
		return default(float);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1DC0AEC", Offset = "0x1DC0AEC", VA = "0x1DC0AEC")]
	private int GetDividerBasedOnQuality()
	{
		return default(int);
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1DC0B10", Offset = "0x1DC0B10", VA = "0x1DC0B10")]
	private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
	{
		return default(int);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1DC0B34", Offset = "0x1DC0B34", VA = "0x1DC0B34")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1DC1B0C", Offset = "0x1DC1B0C", VA = "0x1DC1B0C")]
	private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1DC2288", Offset = "0x1DC2288", VA = "0x1DC2288")]
	private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1DC272C", Offset = "0x1DC272C", VA = "0x1DC272C")]
	private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1DC19A8", Offset = "0x1DC19A8", VA = "0x1DC19A8")]
	private void Downsample(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1DC1DD8", Offset = "0x1DC1DD8", VA = "0x1DC1DD8")]
	private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1DC2580", Offset = "0x1DC2580", VA = "0x1DC2580")]
	private void ReleaseTextures()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1DC15C8", Offset = "0x1DC15C8", VA = "0x1DC15C8")]
	private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1DC2C48", Offset = "0x1DC2C48", VA = "0x1DC2C48")]
	public DepthOfFieldDeprecated()
	{
	}
}
[Token(Token = "0x2000016")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF4670", Offset = "0xAF4670")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4670", Offset = "0xAF4670")]
public class EdgeDetection : PostEffectsBase
{
	[Token(Token = "0x200003D")]
	public enum EdgeDetectMode
	{
		[Token(Token = "0x40001EB")]
		TriangleDepthNormals,
		[Token(Token = "0x40001EC")]
		RobertsCrossDepthNormals,
		[Token(Token = "0x40001ED")]
		SobelDepth,
		[Token(Token = "0x40001EE")]
		SobelDepthThin,
		[Token(Token = "0x40001EF")]
		TriangleLuminance
	}

	[Token(Token = "0x400011A")]
	[FieldOffset(Offset = "0x1C")]
	public EdgeDetectMode mode;

	[Token(Token = "0x400011B")]
	[FieldOffset(Offset = "0x20")]
	public float sensitivityDepth;

	[Token(Token = "0x400011C")]
	[FieldOffset(Offset = "0x24")]
	public float sensitivityNormals;

	[Token(Token = "0x400011D")]
	[FieldOffset(Offset = "0x28")]
	public float lumThreshold;

	[Token(Token = "0x400011E")]
	[FieldOffset(Offset = "0x2C")]
	public float edgeExp;

	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x30")]
	public float sampleDist;

	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x34")]
	public float edgesOnly;

	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x38")]
	public Color edgesOnlyBgColor;

	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x48")]
	public Shader edgeDetectShader;

	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x50")]
	private Material edgeDetectMaterial;

	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x58")]
	private EdgeDetectMode oldMode;

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1DC2D30", Offset = "0x1DC2D30", VA = "0x1DC2D30", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1DC2EB4", Offset = "0x1DC2EB4", VA = "0x1DC2EB4")]
	private new void Start()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1DC2DA8", Offset = "0x1DC2DA8", VA = "0x1DC2DA8")]
	private void SetCameraFlag()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1DC2EC0", Offset = "0x1DC2EC0", VA = "0x1DC2EC0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1DC2EC4", Offset = "0x1DC2EC4", VA = "0x1DC2EC4")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1DC312C", Offset = "0x1DC312C", VA = "0x1DC312C")]
	public EdgeDetection()
	{
	}
}
[Token(Token = "0x2000017")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF4708", Offset = "0xAF4708")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4708", Offset = "0xAF4708")]
internal class Fisheye : PostEffectsBase
{
	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x1C")]
	public float strengthX;

	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x20")]
	public float strengthY;

	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x28")]
	public Shader fishEyeShader;

	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x30")]
	private Material fisheyeMaterial;

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1DC318C", Offset = "0x1DC318C", VA = "0x1DC318C", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1DC31E4", Offset = "0x1DC31E4", VA = "0x1DC31E4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1DC336C", Offset = "0x1DC336C", VA = "0x1DC336C")]
	public Fisheye()
	{
	}
}
[Token(Token = "0x2000018")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF47A0", Offset = "0xAF47A0")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF47A0", Offset = "0xAF47A0")]
internal class GlobalFog : PostEffectsBase
{
	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x1B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xAF5198", Offset = "0xAF5198")]
	public bool distanceFog;

	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xAF51D0", Offset = "0xAF51D0")]
	public bool useRadialDistance;

	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x1D")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xAF5208", Offset = "0xAF5208")]
	public bool heightFog;

	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xAF5240", Offset = "0xAF5240")]
	public float height;

	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0xAF5278", Offset = "0xAF5278")]
	public float heightDensity;

	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "TooltipAttribute", RVA = "0xAF5294", Offset = "0xAF5294")]
	public float startDistance;

	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x30")]
	public Shader fogShader;

	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x38")]
	private Material fogMaterial;

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1DC3394", Offset = "0x1DC3394", VA = "0x1DC3394", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1DC33EC", Offset = "0x1DC33EC", VA = "0x1DC33EC")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1DC3D24", Offset = "0x1DC3D24", VA = "0x1DC3D24")]
	private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1DC3ED0", Offset = "0x1DC3ED0", VA = "0x1DC3ED0")]
	public GlobalFog()
	{
	}
}
[Token(Token = "0x2000019")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4838", Offset = "0xAF4838")]
public class Grayscale : ImageEffectBase
{
	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x28")]
	public Texture textureRamp;

	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x30")]
	public float rampOffset;

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1DC3EF8", Offset = "0x1DC3EF8", VA = "0x1DC3EF8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1DC4000", Offset = "0x1DC4000", VA = "0x1DC4000")]
	public Grayscale()
	{
	}
}
[Token(Token = "0x200001A")]
[Attribute(Name = "RequireComponent", RVA = "0xAF4884", Offset = "0xAF4884")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4884", Offset = "0xAF4884")]
public class ImageEffectBase : MonoBehaviour
{
	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x18")]
	public Shader shader;

	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x20")]
	private Material m_Material;

	[Token(Token = "0x17000006")]
	protected Material material
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1DBC8B4", Offset = "0x1DBC8B4", VA = "0x1DBC8B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1DC4008", Offset = "0x1DC4008", VA = "0x1DC4008", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1DC40C0", Offset = "0x1DC40C0", VA = "0x1DC40C0", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1DBC984", Offset = "0x1DBC984", VA = "0x1DBC984")]
	public ImageEffectBase()
	{
	}
}
[Token(Token = "0x200001B")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF490C", Offset = "0xAF490C")]
public class ImageEffects
{
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1DC4170", Offset = "0x1DC4170", VA = "0x1DC4170")]
	public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1DC4400", Offset = "0x1DC4400", VA = "0x1DC4400")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0xAF53B0", Offset = "0xAF53B0")]
	public static void Blit(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1DC4478", Offset = "0x1DC4478", VA = "0x1DC4478")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0xAF53E8", Offset = "0xAF53E8")]
	public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1DC44F8", Offset = "0x1DC44F8", VA = "0x1DC44F8")]
	public ImageEffects()
	{
	}
}
[Token(Token = "0x200001C")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4944", Offset = "0xAF4944")]
[Attribute(Name = "RequireComponent", RVA = "0xAF4944", Offset = "0xAF4944")]
public class MotionBlur : ImageEffectBase
{
	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x28")]
	public float blurAmount;

	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0x2C")]
	public bool extraBlur;

	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture accumTexture;

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1DC4500", Offset = "0x1DC4500", VA = "0x1DC4500", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1DC4544", Offset = "0x1DC4544", VA = "0x1DC4544", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1DC45B8", Offset = "0x1DC45B8", VA = "0x1DC45B8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1DC49A4", Offset = "0x1DC49A4", VA = "0x1DC49A4")]
	public MotionBlur()
	{
	}
}
[Token(Token = "0x200001D")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF49DC", Offset = "0xAF49DC")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF49DC", Offset = "0xAF49DC")]
public class NoiseAndGrain : PostEffectsBase
{
	[Token(Token = "0x4000138")]
	[FieldOffset(Offset = "0x1C")]
	public float intensityMultiplier;

	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0x20")]
	public float generalIntensity;

	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x24")]
	public float blackIntensity;

	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x28")]
	public float whiteIntensity;

	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0x2C")]
	public float midGrey;

	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0x30")]
	public bool dx11Grain;

	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x34")]
	public float softness;

	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0x38")]
	public bool monochrome;

	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 intensities;

	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 tiling;

	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0x54")]
	public float monochromeTiling;

	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0x58")]
	public FilterMode filterMode;

	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0x60")]
	public Texture2D noiseTexture;

	[Token(Token = "0x4000145")]
	[FieldOffset(Offset = "0x68")]
	public Shader noiseShader;

	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0x70")]
	private Material noiseMaterial;

	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0x78")]
	public Shader dx11NoiseShader;

	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x80")]
	private Material dx11NoiseMaterial;

	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0x0")]
	private static float TILE_AMOUNT;

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1DC49B8", Offset = "0x1DC49B8", VA = "0x1DC49B8", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1DC4A30", Offset = "0x1DC4A30", VA = "0x1DC4A30")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1DC54F8", Offset = "0x1DC54F8", VA = "0x1DC54F8")]
	private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1DC5898", Offset = "0x1DC5898", VA = "0x1DC5898")]
	public NoiseAndGrain()
	{
	}
}
[Token(Token = "0x200001E")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF4A74", Offset = "0xAF4A74")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4A74", Offset = "0xAF4A74")]
public class NoiseAndScratches : MonoBehaviour
{
	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0x18")]
	public bool monochrome;

	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x19")]
	private bool rgbFallback;

	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x1C")]
	public float grainIntensityMin;

	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x20")]
	public float grainIntensityMax;

	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x24")]
	public float grainSize;

	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x28")]
	public float scratchIntensityMin;

	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x2C")]
	public float scratchIntensityMax;

	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x30")]
	public float scratchFPS;

	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x34")]
	public float scratchJitter;

	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x38")]
	public Texture grainTexture;

	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x40")]
	public Texture scratchTexture;

	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x48")]
	public Shader shaderRGB;

	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x50")]
	public Shader shaderYUV;

	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x58")]
	private Material m_MaterialRGB;

	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x60")]
	private Material m_MaterialYUV;

	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x68")]
	private float scratchTimeLeft;

	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0x6C")]
	private float scratchX;

	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0x70")]
	private float scratchY;

	[Token(Token = "0x17000007")]
	protected Material material
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1DC5B04", Offset = "0x1DC5B04", VA = "0x1DC5B04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1DC59B0", Offset = "0x1DC59B0", VA = "0x1DC59B0")]
	protected void Start()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1DC5C6C", Offset = "0x1DC5C6C", VA = "0x1DC5C6C")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1DC5D70", Offset = "0x1DC5D70", VA = "0x1DC5D70")]
	private void SanitizeParameters()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1DC5EAC", Offset = "0x1DC5EAC", VA = "0x1DC5EAC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1DC6250", Offset = "0x1DC6250", VA = "0x1DC6250")]
	public NoiseAndScratches()
	{
	}
}
[Token(Token = "0x200001F")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF4B0C", Offset = "0xAF4B0C")]
public class PostEffectsBase : MonoBehaviour
{
	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x18")]
	protected bool supportHDRTextures;

	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x19")]
	protected bool supportDX11;

	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x1A")]
	protected bool isSupported;

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1DB3EFC", Offset = "0x1DB3EFC", VA = "0x1DB3EFC")]
	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1DB355C", Offset = "0x1DB355C", VA = "0x1DB355C")]
	protected Material CreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1DC6284", Offset = "0x1DC6284", VA = "0x1DC6284")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1DC6290", Offset = "0x1DC6290", VA = "0x1DC6290")]
	protected bool CheckSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1DC6298", Offset = "0x1DC6298", VA = "0x1DC6298", Slot = "4")]
	public virtual bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1DBA9DC", Offset = "0x1DBA9DC", VA = "0x1DBA9DC")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1DB3424", Offset = "0x1DB3424", VA = "0x1DB3424")]
	protected bool CheckSupport(bool needDepth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1DB89C4", Offset = "0x1DB89C4", VA = "0x1DB89C4")]
	protected bool CheckSupport(bool needDepth, bool needHdr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1DC6348", Offset = "0x1DC6348", VA = "0x1DC6348")]
	public bool Dx11Support()
	{
		return default(bool);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1DB378C", Offset = "0x1DB378C", VA = "0x1DB378C")]
	protected void ReportAutoDisable()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1DC6350", Offset = "0x1DC6350", VA = "0x1DC6350")]
	private bool CheckShader(Shader s)
	{
		return default(bool);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1DB3760", Offset = "0x1DB3760", VA = "0x1DB3760")]
	protected void NotSupported()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x1DC65E0", Offset = "0x1DC65E0", VA = "0x1DC65E0")]
	protected void DrawBorder(RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1DB3E60", Offset = "0x1DB3E60", VA = "0x1DB3E60")]
	public PostEffectsBase()
	{
	}
}
[Token(Token = "0x2000020")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF4B80", Offset = "0xAF4B80")]
internal class PostEffectsHelper : MonoBehaviour
{
	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1DC6988", Offset = "0x1DC6988", VA = "0x1DC6988")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1DC69F4", Offset = "0x1DC69F4", VA = "0x1DC69F4")]
	private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1DC6C8C", Offset = "0x1DC6C8C", VA = "0x1DC6C8C")]
	private static void DrawBorder(RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1DC7030", Offset = "0x1DC7030", VA = "0x1DC7030")]
	private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1DC71E8", Offset = "0x1DC71E8", VA = "0x1DC71E8")]
	public PostEffectsHelper()
	{
	}
}
[Token(Token = "0x2000021")]
internal class Quads
{
	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x0")]
	private static Mesh[] meshes;

	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x8")]
	private static int currentQuads;

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1DC71F0", Offset = "0x1DC71F0", VA = "0x1DC71F0")]
	private static bool HasMeshes()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1DC065C", Offset = "0x1DC065C", VA = "0x1DC065C")]
	public static void Cleanup()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1DC2970", Offset = "0x1DC2970", VA = "0x1DC2970")]
	public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1DC7308", Offset = "0x1DC7308", VA = "0x1DC7308")]
	private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1DC7A1C", Offset = "0x1DC7A1C", VA = "0x1DC7A1C")]
	public Quads()
	{
	}
}
[Token(Token = "0x2000022")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF4BF4", Offset = "0xAF4BF4")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4BF4", Offset = "0xAF4BF4")]
public class ScreenOverlay : PostEffectsBase
{
	[Token(Token = "0x200003E")]
	public enum OverlayBlendMode
	{
		[Token(Token = "0x40001F1")]
		Additive,
		[Token(Token = "0x40001F2")]
		ScreenBlend,
		[Token(Token = "0x40001F3")]
		Multiply,
		[Token(Token = "0x40001F4")]
		Overlay,
		[Token(Token = "0x40001F5")]
		AlphaBlend
	}

	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0x1C")]
	public OverlayBlendMode blendMode;

	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0x20")]
	public float intensity;

	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0x28")]
	public Texture2D texture;

	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0x30")]
	public Shader overlayShader;

	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x38")]
	private Material overlayMaterial;

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1DC7A28", Offset = "0x1DC7A28", VA = "0x1DC7A28", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1DC7A80", Offset = "0x1DC7A80", VA = "0x1DC7A80")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1DC7C38", Offset = "0x1DC7C38", VA = "0x1DC7C38")]
	public ScreenOverlay()
	{
	}
}
[Token(Token = "0x2000023")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF4C8C", Offset = "0xAF4C8C")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4C8C", Offset = "0xAF4C8C")]
internal class ScreenSpaceAmbientObscurance : PostEffectsBase
{
	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xAF52CC", Offset = "0xAF52CC")]
	public float intensity;

	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0xAF52E4", Offset = "0xAF52E4")]
	public float radius;

	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0xAF5300", Offset = "0xAF5300")]
	public int blurIterations;

	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0xAF5318", Offset = "0xAF5318")]
	public float blurFilterDistance;

	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xAF5330", Offset = "0xAF5330")]
	public int downsample;

	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x30")]
	public Texture2D rand;

	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x38")]
	public Shader aoShader;

	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x40")]
	private Material aoMaterial;

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1DC7C58", Offset = "0x1DC7C58", VA = "0x1DC7C58", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1DC7CB0", Offset = "0x1DC7CB0", VA = "0x1DC7CB0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1DC7D58", Offset = "0x1DC7D58", VA = "0x1DC7D58")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1DC8418", Offset = "0x1DC8418", VA = "0x1DC8418")]
	public ScreenSpaceAmbientObscurance()
	{
	}
}
[Token(Token = "0x2000024")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF4D24", Offset = "0xAF4D24")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4D24", Offset = "0xAF4D24")]
public class ScreenSpaceAmbientOcclusion : MonoBehaviour
{
	[Token(Token = "0x200003F")]
	public enum SSAOSamples
	{
		[Token(Token = "0x40001F7")]
		Low,
		[Token(Token = "0x40001F8")]
		Medium,
		[Token(Token = "0x40001F9")]
		High
	}

	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x18")]
	public float m_Radius;

	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x1C")]
	public SSAOSamples m_SampleCount;

	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0x20")]
	public float m_OcclusionIntensity;

	[Token(Token = "0x4000171")]
	[FieldOffset(Offset = "0x24")]
	public int m_Blur;

	[Token(Token = "0x4000172")]
	[FieldOffset(Offset = "0x28")]
	public int m_Downsampling;

	[Token(Token = "0x4000173")]
	[FieldOffset(Offset = "0x2C")]
	public float m_OcclusionAttenuation;

	[Token(Token = "0x4000174")]
	[FieldOffset(Offset = "0x30")]
	public float m_MinZ;

	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0x38")]
	public Shader m_SSAOShader;

	[Token(Token = "0x4000176")]
	[FieldOffset(Offset = "0x40")]
	private Material m_SSAOMaterial;

	[Token(Token = "0x4000177")]
	[FieldOffset(Offset = "0x48")]
	public Texture2D m_RandomTexture;

	[Token(Token = "0x4000178")]
	[FieldOffset(Offset = "0x50")]
	private bool m_Supported;

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1DC8448", Offset = "0x1DC8448", VA = "0x1DC8448")]
	private static Material CreateMaterial(Shader shader)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1DC84FC", Offset = "0x1DC84FC", VA = "0x1DC84FC")]
	private static void DestroyMaterial(Material mat)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1DC8598", Offset = "0x1DC8598", VA = "0x1DC8598")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1DC85A0", Offset = "0x1DC85A0", VA = "0x1DC85A0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1DC8760", Offset = "0x1DC8760", VA = "0x1DC8760")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1DC8680", Offset = "0x1DC8680", VA = "0x1DC8680")]
	private void CreateMaterials()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1DC87F8", Offset = "0x1DC87F8", VA = "0x1DC87F8")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1DC8FB0", Offset = "0x1DC8FB0", VA = "0x1DC8FB0")]
	public ScreenSpaceAmbientOcclusion()
	{
	}
}
[Token(Token = "0x2000025")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4DBC", Offset = "0xAF4DBC")]
public class SepiaTone : ImageEffectBase
{
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1DC8FE8", Offset = "0x1DC8FE8", VA = "0x1DC8FE8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1DC9078", Offset = "0x1DC9078", VA = "0x1DC9078")]
	public SepiaTone()
	{
	}
}
[Token(Token = "0x2000026")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF4E08", Offset = "0xAF4E08")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4E08", Offset = "0xAF4E08")]
public class SunShafts : PostEffectsBase
{
	[Token(Token = "0x2000040")]
	public enum SunShaftsResolution
	{
		[Token(Token = "0x40001FB")]
		Low,
		[Token(Token = "0x40001FC")]
		Normal,
		[Token(Token = "0x40001FD")]
		High
	}

	[Token(Token = "0x2000041")]
	public enum ShaftsScreenBlendMode
	{
		[Token(Token = "0x40001FF")]
		Screen,
		[Token(Token = "0x4000200")]
		Add
	}

	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x1C")]
	public SunShaftsResolution resolution;

	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0x20")]
	public ShaftsScreenBlendMode screenBlendMode;

	[Token(Token = "0x400017B")]
	[FieldOffset(Offset = "0x28")]
	public Transform sunTransform;

	[Token(Token = "0x400017C")]
	[FieldOffset(Offset = "0x30")]
	public int radialBlurIterations;

	[Token(Token = "0x400017D")]
	[FieldOffset(Offset = "0x34")]
	public Color sunColor;

	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x44")]
	public Color sunThreshold;

	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x54")]
	public float sunShaftBlurRadius;

	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x58")]
	public float sunShaftIntensity;

	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x5C")]
	public float maxRadius;

	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x60")]
	public bool useDepthTexture;

	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x68")]
	public Shader sunShaftsShader;

	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x70")]
	private Material sunShaftsMaterial;

	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x78")]
	public Shader simpleClearShader;

	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x80")]
	private Material simpleClearMaterial;

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1DC9080", Offset = "0x1DC9080", VA = "0x1DC9080", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1DC90E8", Offset = "0x1DC90E8", VA = "0x1DC90E8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1DC99FC", Offset = "0x1DC99FC", VA = "0x1DC99FC")]
	public SunShafts()
	{
	}
}
[Token(Token = "0x2000027")]
[Attribute(Name = "RequireComponent", RVA = "0xAF4EA0", Offset = "0xAF4EA0")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4EA0", Offset = "0xAF4EA0")]
internal class TiltShift : PostEffectsBase
{
	[Token(Token = "0x2000042")]
	public enum TiltShiftMode
	{
		[Token(Token = "0x4000202")]
		TiltShiftMode,
		[Token(Token = "0x4000203")]
		IrisMode
	}

	[Token(Token = "0x2000043")]
	public enum TiltShiftQuality
	{
		[Token(Token = "0x4000205")]
		Preview,
		[Token(Token = "0x4000206")]
		Normal,
		[Token(Token = "0x4000207")]
		High
	}

	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x1C")]
	public TiltShiftMode mode;

	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0x20")]
	public TiltShiftQuality quality;

	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0xAF5348", Offset = "0xAF5348")]
	public float blurArea;

	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0xAF5360", Offset = "0xAF5360")]
	public float maxBlurSize;

	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "RangeAttribute", RVA = "0xAF5378", Offset = "0xAF5378")]
	public int downsample;

	[Token(Token = "0x400018C")]
	[FieldOffset(Offset = "0x30")]
	public Shader tiltShiftShader;

	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x38")]
	private Material tiltShiftMaterial;

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x1DC9AB0", Offset = "0x1DC9AB0", VA = "0x1DC9AB0", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x1DC9B08", Offset = "0x1DC9B08", VA = "0x1DC9B08")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1DC9E10", Offset = "0x1DC9E10", VA = "0x1DC9E10")]
	public TiltShift()
	{
	}
}
[Token(Token = "0x2000028")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF4F28", Offset = "0xAF4F28")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4F28", Offset = "0xAF4F28")]
public class Tonemapping : PostEffectsBase
{
	[Token(Token = "0x2000044")]
	public enum TonemapperType
	{
		[Token(Token = "0x4000209")]
		SimpleReinhard,
		[Token(Token = "0x400020A")]
		UserCurve,
		[Token(Token = "0x400020B")]
		Hable,
		[Token(Token = "0x400020C")]
		Photographic,
		[Token(Token = "0x400020D")]
		OptimizedHejiDawson,
		[Token(Token = "0x400020E")]
		AdaptiveReinhard,
		[Token(Token = "0x400020F")]
		AdaptiveReinhardAutoWhite
	}

	[Token(Token = "0x2000045")]
	public enum AdaptiveTexSize
	{
		[Token(Token = "0x4000211")]
		Square16 = 0x10,
		[Token(Token = "0x4000212")]
		Square32 = 0x20,
		[Token(Token = "0x4000213")]
		Square64 = 0x40,
		[Token(Token = "0x4000214")]
		Square128 = 0x80,
		[Token(Token = "0x4000215")]
		Square256 = 0x100,
		[Token(Token = "0x4000216")]
		Square512 = 0x200,
		[Token(Token = "0x4000217")]
		Square1024 = 0x400
	}

	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x1C")]
	public TonemapperType type;

	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x20")]
	public AdaptiveTexSize adaptiveTextureSize;

	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve remapCurve;

	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x30")]
	private Texture2D curveTex;

	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x38")]
	public float exposureAdjustment;

	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x3C")]
	public float middleGrey;

	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x40")]
	public float white;

	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x44")]
	public float adaptionSpeed;

	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x48")]
	public Shader tonemapper;

	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x50")]
	public bool validRenderTextureFormat;

	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x58")]
	private Material tonemapMaterial;

	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x60")]
	private RenderTexture rt;

	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x68")]
	private RenderTextureFormat rtFormat;

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1DC9E34", Offset = "0x1DC9E34", VA = "0x1DC9E34", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1DC9F8C", Offset = "0x1DC9F8C", VA = "0x1DC9F8C")]
	public float UpdateCurve()
	{
		return default(float);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1DCA2AC", Offset = "0x1DCA2AC", VA = "0x1DCA2AC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1DCA404", Offset = "0x1DCA404", VA = "0x1DCA404")]
	private bool CreateInternalRenderTexture()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1DCA4F8", Offset = "0x1DCA4F8", VA = "0x1DCA4F8")]
	[ImageEffectTransformsToLDR]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1DCAE48", Offset = "0x1DCAE48", VA = "0x1DCAE48")]
	public Tonemapping()
	{
	}
}
[Token(Token = "0x2000029")]
internal class Triangles
{
	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x0")]
	private static Mesh[] meshes;

	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x8")]
	private static int currentTris;

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1DCAE80", Offset = "0x1DCAE80", VA = "0x1DCAE80")]
	private static bool HasMeshes()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1DCAFDC", Offset = "0x1DCAFDC", VA = "0x1DCAFDC")]
	private static void Cleanup()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1DCB1FC", Offset = "0x1DCB1FC", VA = "0x1DCB1FC")]
	private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1DCB4D4", Offset = "0x1DCB4D4", VA = "0x1DCB4D4")]
	private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1DCBA5C", Offset = "0x1DCBA5C", VA = "0x1DCBA5C")]
	public Triangles()
	{
	}
}
[Token(Token = "0x200002A")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF4FC0", Offset = "0xAF4FC0")]
public class Twirl : ImageEffectBase
{
	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 radius;

	[Token(Token = "0x400019E")]
	[FieldOffset(Offset = "0x30")]
	public float angle;

	[Token(Token = "0x400019F")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 center;

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1DCBA68", Offset = "0x1DCBA68", VA = "0x1DCBA68")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1DCBAAC", Offset = "0x1DCBAAC", VA = "0x1DCBAAC")]
	public Twirl()
	{
	}
}
[Token(Token = "0x200002B")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0xAF500C", Offset = "0xAF500C")]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF500C", Offset = "0xAF500C")]
public class VignetteAndChromaticAberration : PostEffectsBase
{
	[Token(Token = "0x2000046")]
	public enum AberrationMode
	{
		[Token(Token = "0x4000219")]
		Simple,
		[Token(Token = "0x400021A")]
		Advanced
	}

	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x1C")]
	public AberrationMode mode;

	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x20")]
	public float intensity;

	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x24")]
	public float chromaticAberration;

	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x28")]
	public float axialAberration;

	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x2C")]
	public float blur;

	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x30")]
	public float blurSpread;

	[Token(Token = "0x40001A6")]
	[FieldOffset(Offset = "0x34")]
	public float luminanceDependency;

	[Token(Token = "0x40001A7")]
	[FieldOffset(Offset = "0x38")]
	public float blurDistance;

	[Token(Token = "0x40001A8")]
	[FieldOffset(Offset = "0x40")]
	public Shader vignetteShader;

	[Token(Token = "0x40001A9")]
	[FieldOffset(Offset = "0x48")]
	public Shader separableBlurShader;

	[Token(Token = "0x40001AA")]
	[FieldOffset(Offset = "0x50")]
	public Shader chromAberrationShader;

	[Token(Token = "0x40001AB")]
	[FieldOffset(Offset = "0x58")]
	private Material m_VignetteMaterial;

	[Token(Token = "0x40001AC")]
	[FieldOffset(Offset = "0x60")]
	private Material m_SeparableBlurMaterial;

	[Token(Token = "0x40001AD")]
	[FieldOffset(Offset = "0x68")]
	private Material m_ChromAberrationMaterial;

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1DCBB28", Offset = "0x1DCBB28", VA = "0x1DCBB28", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1DCBBAC", Offset = "0x1DCBBAC", VA = "0x1DCBBAC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1DCC28C", Offset = "0x1DCC28C", VA = "0x1DCC28C")]
	public VignetteAndChromaticAberration()
	{
	}
}
[Token(Token = "0x200002C")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0xAF50A4", Offset = "0xAF50A4")]
public class Vortex : ImageEffectBase
{
	[Token(Token = "0x40001AE")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 radius;

	[Token(Token = "0x40001AF")]
	[FieldOffset(Offset = "0x30")]
	public float angle;

	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 center;

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1DCC2CC", Offset = "0x1DCC2CC", VA = "0x1DCC2CC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1DCC310", Offset = "0x1DCC310", VA = "0x1DCC310")]
	public Vortex()
	{
	}
}
