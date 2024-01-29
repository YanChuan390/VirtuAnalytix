using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x452660", Offset = "0x452660")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x452660", Offset = "0x452660")]
[ExecuteInEditMode]
public class Bloom : PostEffectsBase
{
	[Serializable]
	[Token(Token = "0x2000003")]
	public enum LensFlareStyle
	{
		[Token(Token = "0x4000021")]
		Ghosting,
		[Token(Token = "0x4000022")]
		Anamorphic,
		[Token(Token = "0x4000023")]
		Combined
	}

	[Serializable]
	[Token(Token = "0x2000004")]
	public enum TweakMode
	{
		[Token(Token = "0x4000025")]
		Basic,
		[Token(Token = "0x4000026")]
		Complex
	}

	[Serializable]
	[Token(Token = "0x2000005")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x4000028")]
		Auto,
		[Token(Token = "0x4000029")]
		On,
		[Token(Token = "0x400002A")]
		Off
	}

	[Serializable]
	[Token(Token = "0x2000006")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x400002C")]
		Screen,
		[Token(Token = "0x400002D")]
		Add
	}

	[Serializable]
	[Token(Token = "0x2000007")]
	public enum BloomQuality
	{
		[Token(Token = "0x400002F")]
		Cheap,
		[Token(Token = "0x4000030")]
		High
	}

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x10")]
	public TweakMode tweakMode;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x14")]
	public BloomScreenBlendMode screenBlendMode;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x18")]
	public HDRBloomMode hdr;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x1C")]
	private bool doHdr;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x20")]
	public float sepBlurSpread;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x24")]
	public BloomQuality quality;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x28")]
	public float bloomIntensity;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x2C")]
	public float bloomThreshhold;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x30")]
	public Color bloomThreshholdColor;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x40")]
	public int bloomBlurIterations;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x44")]
	public int hollywoodFlareBlurIterations;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x48")]
	public float flareRotation;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x4C")]
	public LensFlareStyle lensflareMode;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x50")]
	public float hollyStretchWidth;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x54")]
	public float lensflareIntensity;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x58")]
	public float lensflareThreshhold;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x5C")]
	public float lensFlareSaturation;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x60")]
	public Color flareColorA;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x70")]
	public Color flareColorB;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x80")]
	public Color flareColorC;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x90")]
	public Color flareColorD;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0xA0")]
	public float blurWidth;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0xA4")]
	public Texture2D lensFlareVignetteMask;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0xA8")]
	public Shader lensFlareShader;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0xAC")]
	private Material lensFlareMaterial;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0xB0")]
	public Shader screenBlendShader;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0xB4")]
	private Material screenBlend;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0xB8")]
	public Shader blurAndFlaresShader;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0xBC")]
	private Material blurAndFlaresMaterial;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0xC0")]
	public Shader brightPassFilterShader;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0xC4")]
	private Material brightPassFilterMaterial;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1DCD390", Offset = "0x1DCD390", VA = "0x1DCD390")]
	public Bloom()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1DCD554", Offset = "0x1DCD554", VA = "0x1DCD554", Slot = "8")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1DCD628", Offset = "0x1DCD628", VA = "0x1DCD628", Slot = "18")]
	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1DCF338", Offset = "0x1DCF338", VA = "0x1DCF338")]
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1DCEFF0", Offset = "0x1DCEFF0", VA = "0x1DCEFF0")]
	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1DCEC18", Offset = "0x1DCEC18", VA = "0x1DCEC18")]
	private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1DCEB04", Offset = "0x1DCEB04", VA = "0x1DCEB04")]
	private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1DCED44", Offset = "0x1DCED44", VA = "0x1DCED44")]
	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1DCF430", Offset = "0x1DCF430", VA = "0x1DCF430", Slot = "17")]
	public override void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x2000008")]
public enum LensflareStyle34
{
	[Token(Token = "0x4000032")]
	Ghosting,
	[Token(Token = "0x4000033")]
	Anamorphic,
	[Token(Token = "0x4000034")]
	Combined
}
[Serializable]
[Token(Token = "0x2000009")]
public enum TweakMode34
{
	[Token(Token = "0x4000036")]
	Basic,
	[Token(Token = "0x4000037")]
	Complex
}
[Serializable]
[Token(Token = "0x200000A")]
public enum HDRBloomMode
{
	[Token(Token = "0x4000039")]
	Auto,
	[Token(Token = "0x400003A")]
	On,
	[Token(Token = "0x400003B")]
	Off
}
[Serializable]
[Token(Token = "0x200000B")]
public enum BloomScreenBlendMode
{
	[Token(Token = "0x400003D")]
	Screen,
	[Token(Token = "0x400003E")]
	Add
}
[Serializable]
[Token(Token = "0x200000C")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x452710", Offset = "0x452710")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x452710", Offset = "0x452710")]
public class BloomAndLensFlares : PostEffectsBase
{
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x10")]
	public TweakMode34 tweakMode;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x14")]
	public BloomScreenBlendMode screenBlendMode;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x18")]
	public HDRBloomMode hdr;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x1C")]
	private bool doHdr;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x20")]
	public float sepBlurSpread;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x24")]
	public float useSrcAlphaAsMask;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x28")]
	public float bloomIntensity;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x2C")]
	public float bloomThreshhold;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x30")]
	public int bloomBlurIterations;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x34")]
	public bool lensflares;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x38")]
	public int hollywoodFlareBlurIterations;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x3C")]
	public LensflareStyle34 lensflareMode;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x40")]
	public float hollyStretchWidth;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x44")]
	public float lensflareIntensity;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x48")]
	public float lensflareThreshhold;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x4C")]
	public Color flareColorA;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x5C")]
	public Color flareColorB;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x6C")]
	public Color flareColorC;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x7C")]
	public Color flareColorD;

	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x8C")]
	public float blurWidth;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x90")]
	public Texture2D lensFlareVignetteMask;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x94")]
	public Shader lensFlareShader;

	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x98")]
	private Material lensFlareMaterial;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x9C")]
	public Shader vignetteShader;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0xA0")]
	private Material vignetteMaterial;

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0xA4")]
	public Shader separableBlurShader;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0xA8")]
	private Material separableBlurMaterial;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0xAC")]
	public Shader addBrightStuffOneOneShader;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0xB0")]
	private Material addBrightStuffBlendOneOneMaterial;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0xB4")]
	public Shader screenBlendShader;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0xB8")]
	private Material screenBlend;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0xBC")]
	public Shader hollywoodFlaresShader;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0xC0")]
	private Material hollywoodFlaresMaterial;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0xC4")]
	public Shader brightPassFilterShader;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0xC8")]
	private Material brightPassFilterMaterial;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1DCF434", Offset = "0x1DCF434", VA = "0x1DCF434")]
	public BloomAndLensFlares()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1DCF5B4", Offset = "0x1DCF5B4", VA = "0x1DCF5B4", Slot = "8")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1DCF6E8", Offset = "0x1DCF6E8", VA = "0x1DCF6E8", Slot = "18")]
	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1DD0DF8", Offset = "0x1DD0DF8", VA = "0x1DD0DF8")]
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1DD0AC8", Offset = "0x1DD0AC8", VA = "0x1DD0AC8")]
	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1DD074C", Offset = "0x1DD074C", VA = "0x1DD074C")]
	private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1DD0918", Offset = "0x1DD0918", VA = "0x1DD0918")]
	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1DD0ED4", Offset = "0x1DD0ED4", VA = "0x1DD0ED4", Slot = "17")]
	public override void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x200000D")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x4527C0", Offset = "0x4527C0")]
[ExecuteInEditMode]
public class PostEffectsBase : MonoBehaviour
{
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0xC")]
	protected bool supportHDRTextures;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0xD")]
	protected bool supportDX11;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0xE")]
	protected bool isSupported;

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1DCD530", Offset = "0x1DCD530", VA = "0x1DCD530")]
	public PostEffectsBase()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1DD0ED8", Offset = "0x1DD0ED8", VA = "0x1DD0ED8", Slot = "4")]
	public virtual Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1DD12D4", Offset = "0x1DD12D4", VA = "0x1DD12D4", Slot = "5")]
	public virtual Material CreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1DD158C", Offset = "0x1DD158C", VA = "0x1DD158C", Slot = "6")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1DD1598", Offset = "0x1DD1598", VA = "0x1DD1598", Slot = "7")]
	public virtual bool CheckSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1DD15AC", Offset = "0x1DD15AC", VA = "0x1DD15AC", Slot = "8")]
	public virtual bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1DD16C0", Offset = "0x1DD16C0", VA = "0x1DD16C0", Slot = "9")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1DD16D0", Offset = "0x1DD16D0", VA = "0x1DD16D0", Slot = "10")]
	public virtual bool CheckSupport(bool needDepth)
	{
		return default(bool);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1DD1848", Offset = "0x1DD1848", VA = "0x1DD1848", Slot = "11")]
	public virtual bool CheckSupport(bool needDepth, bool needHdr)
	{
		return default(bool);
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1DD18A4", Offset = "0x1DD18A4", VA = "0x1DD18A4", Slot = "12")]
	public virtual bool Dx11Support()
	{
		return default(bool);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1DD18AC", Offset = "0x1DD18AC", VA = "0x1DD18AC", Slot = "13")]
	public virtual void ReportAutoDisable()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1DD19BC", Offset = "0x1DD19BC", VA = "0x1DD19BC", Slot = "14")]
	public virtual bool CheckShader(Shader s)
	{
		return default(bool);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1DD1B60", Offset = "0x1DD1B60", VA = "0x1DD1B60", Slot = "15")]
	public virtual void NotSupported()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1DD1B84", Offset = "0x1DD1B84", VA = "0x1DD1B84", Slot = "16")]
	public virtual void DrawBorder(RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1DD1FFC", Offset = "0x1DD1FFC", VA = "0x1DD1FFC", Slot = "17")]
	public virtual void Main()
	{
	}
}
[Serializable]
[Token(Token = "0x200000E")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x452848", Offset = "0x452848")]
[ExecuteInEditMode]
public class PostEffectsHelper : MonoBehaviour
{
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1DD2000", Offset = "0x1DD2000", VA = "0x1DD2000")]
	public PostEffectsHelper()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1DD2008", Offset = "0x1DD2008", VA = "0x1DD2008", Slot = "4")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1DD200C", Offset = "0x1DD200C", VA = "0x1DD200C", Slot = "5")]
	public virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1DD209C", Offset = "0x1DD209C", VA = "0x1DD209C")]
	public static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1DD2434", Offset = "0x1DD2434", VA = "0x1DD2434")]
	public static void DrawBorder(RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1DD28AC", Offset = "0x1DD28AC", VA = "0x1DD28AC")]
	public static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1DD2AC0", Offset = "0x1DD2AC0", VA = "0x1DD2AC0", Slot = "6")]
	public virtual void Main()
	{
	}
}
