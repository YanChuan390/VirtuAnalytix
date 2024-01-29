using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityStandardAssets.ImageEffects
{
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
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BEFC0", Offset = "0x9BEFC0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BEFC0", Offset = "0x9BEFC0")]
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
		[Address(RVA = "0x15C75BC", Offset = "0x15C75BC", VA = "0x15C75BC")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x15C7620", Offset = "0x15C7620", VA = "0x15C7620", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x15C7AD4", Offset = "0x15C7AD4", VA = "0x15C7AD4")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x15C801C", Offset = "0x15C801C", VA = "0x15C801C")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BF058", Offset = "0x9BF058")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF058", Offset = "0x9BF058")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x200004D")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x40002A3")]
			Ghosting,
			[Token(Token = "0x40002A4")]
			Anamorphic,
			[Token(Token = "0x40002A5")]
			Combined
		}

		[Token(Token = "0x200004E")]
		public enum TweakMode
		{
			[Token(Token = "0x40002A7")]
			Basic,
			[Token(Token = "0x40002A8")]
			Complex
		}

		[Token(Token = "0x200004F")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x40002AA")]
			Auto,
			[Token(Token = "0x40002AB")]
			On,
			[Token(Token = "0x40002AC")]
			Off
		}

		[Token(Token = "0x2000050")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x40002AE")]
			Screen,
			[Token(Token = "0x40002AF")]
			Add
		}

		[Token(Token = "0x2000051")]
		public enum BloomQuality
		{
			[Token(Token = "0x40002B1")]
			Cheap,
			[Token(Token = "0x40002B2")]
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
		[Address(RVA = "0x15C805C", Offset = "0x15C805C", VA = "0x15C805C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x15C8478", Offset = "0x15C8478", VA = "0x15C8478")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x15C9834", Offset = "0x15C9834", VA = "0x15C9834")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x15C9634", Offset = "0x15C9634", VA = "0x15C9634")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x15C933C", Offset = "0x15C933C", VA = "0x15C933C")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x15C9258", Offset = "0x15C9258", VA = "0x15C9258")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x15C9428", Offset = "0x15C9428", VA = "0x15C9428")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x15C98FC", Offset = "0x15C98FC", VA = "0x15C98FC")]
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
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BF0F0", Offset = "0x9BF0F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF0F0", Offset = "0x9BF0F0")]
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
		[Address(RVA = "0x15C9A44", Offset = "0x15C9A44", VA = "0x15C9A44", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x15C9AFC", Offset = "0x15C9AFC", VA = "0x15C9AFC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x15CAA48", Offset = "0x15CAA48", VA = "0x15CAA48")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x15CA858", Offset = "0x15CA858", VA = "0x15CA858")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x15CA5DC", Offset = "0x15CA5DC", VA = "0x15CA5DC")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x15CA704", Offset = "0x15CA704", VA = "0x15CA704")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x15CAAFC", Offset = "0x15CAAFC", VA = "0x15CAAFC")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x200000A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BF188", Offset = "0x9BF188")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF188", Offset = "0x9BF188")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000052")]
		public enum Resolution
		{
			[Token(Token = "0x40002B4")]
			Low,
			[Token(Token = "0x40002B5")]
			High
		}

		[Token(Token = "0x2000053")]
		public enum BlurType
		{
			[Token(Token = "0x40002B7")]
			Standard,
			[Token(Token = "0x40002B8")]
			Sgx
		}

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0644", Offset = "0x9C0644")]
		public float threshold;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C065C", Offset = "0x9C065C")]
		public float intensity;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0674", Offset = "0x9C0674")]
		public float blurSize;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x28")]
		private Resolution resolution;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C068C", Offset = "0x9C068C")]
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
		[Address(RVA = "0x15CAC38", Offset = "0x15CAC38", VA = "0x15CAC38", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x15CAC90", Offset = "0x15CAC90", VA = "0x15CAC90")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x15CAD40", Offset = "0x15CAD40", VA = "0x15CAD40")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x15CB11C", Offset = "0x15CB11C", VA = "0x15CB11C")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x200000B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF220", Offset = "0x9BF220")]
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
			[Address(RVA = "0x15CB148", Offset = "0x15CB148", VA = "0x15CB148")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x15CB280", Offset = "0x15CB280", VA = "0x15CB280")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x15CB37C", Offset = "0x15CB37C", VA = "0x15CB37C")]
		protected void Start()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x15CB43C", Offset = "0x15CB43C", VA = "0x15CB43C")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x15CB5E0", Offset = "0x15CB5E0", VA = "0x15CB5E0")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x15CB758", Offset = "0x15CB758", VA = "0x15CB758")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x15CB8C4", Offset = "0x15CB8C4", VA = "0x15CB8C4")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x200000C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BF26C", Offset = "0x9BF26C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF26C", Offset = "0x9BF26C")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000054")]
		public enum BlurType
		{
			[Token(Token = "0x40002BA")]
			StandardGauss,
			[Token(Token = "0x40002BB")]
			SgxGauss
		}

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C06A4", Offset = "0x9C06A4")]
		public int downsample;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C06BC", Offset = "0x9C06BC")]
		public float blurSize;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C06D4", Offset = "0x9C06D4")]
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
		[Address(RVA = "0x15CB8E0", Offset = "0x15CB8E0", VA = "0x15CB8E0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x15CB938", Offset = "0x15CB938", VA = "0x15CB938")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x15CB9E8", Offset = "0x15CB9E8", VA = "0x15CB9E8")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x15CBD8C", Offset = "0x15CBD8C", VA = "0x15CBD8C")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x200000D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BF304", Offset = "0x9BF304")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF304", Offset = "0x9BF304")]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x2000055")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x40002BD")]
			CameraMotion,
			[Token(Token = "0x40002BE")]
			LocalBlur,
			[Token(Token = "0x40002BF")]
			Reconstruction,
			[Token(Token = "0x40002C0")]
			ReconstructionDX11,
			[Token(Token = "0x40002C1")]
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
		[Address(RVA = "0x15CBDB4", Offset = "0x15CBDB4", VA = "0x15CBDB4")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x15CBF00", Offset = "0x15CBF00", VA = "0x15CBF00")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x15CC084", Offset = "0x15CC084", VA = "0x15CC084")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x15CC144", Offset = "0x15CC144", VA = "0x15CC144")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x15CC2A8", Offset = "0x15CC2A8", VA = "0x15CC2A8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x15CC38C", Offset = "0x15CC38C", VA = "0x15CC38C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x15CBFD8", Offset = "0x15CBFD8", VA = "0x15CBFD8")]
		private void Remember()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x15CD9B4", Offset = "0x15CD9B4", VA = "0x15CD9B4")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x15CD8C8", Offset = "0x15CD8C8", VA = "0x15CD8C8")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x15CD9A4", Offset = "0x15CD9A4", VA = "0x15CD9A4")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x15CDCF0", Offset = "0x15CDCF0", VA = "0x15CDCF0")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF39C", Offset = "0x9BF39C")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x2000056")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x40002C3")]
			Simple,
			[Token(Token = "0x40002C4")]
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
		[Address(RVA = "0x15CDE4C", Offset = "0x15CDE4C", VA = "0x15CDE4C")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x15CDE88", Offset = "0x15CDE88", VA = "0x15CDE88")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x15CDE8C", Offset = "0x15CDE8C", VA = "0x15CDE8C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x15CE0EC", Offset = "0x15CE0EC", VA = "0x15CE0EC")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x15CE4E0", Offset = "0x15CE4E0", VA = "0x15CE4E0")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x15CE4E4", Offset = "0x15CE4E4", VA = "0x15CE4E4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x15CE7E0", Offset = "0x15CE7E0", VA = "0x15CE7E0")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x200000F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF3E8", Offset = "0x9BF3E8")]
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
		[Address(RVA = "0x15CEE1C", Offset = "0x15CEE1C", VA = "0x15CEE1C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x15CEE70", Offset = "0x15CEE70", VA = "0x15CEE70")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x15CEF18", Offset = "0x15CEF18", VA = "0x15CEF18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x15CEFC0", Offset = "0x15CEFC0", VA = "0x15CEFC0")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x15CF1BC", Offset = "0x15CF1BC", VA = "0x15CF1BC")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x15CF2B0", Offset = "0x15CF2B0", VA = "0x15CF2B0")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x15CF5BC", Offset = "0x15CF5BC", VA = "0x15CF5BC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x15CF7A8", Offset = "0x15CF7A8", VA = "0x15CF7A8")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF434", Offset = "0x9BF434")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x15CF80C", Offset = "0x15CF80C", VA = "0x15CF80C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x15CF988", Offset = "0x15CF988", VA = "0x15CF988")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000011")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BF480", Offset = "0x9BF480")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF480", Offset = "0x9BF480")]
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
		[Address(RVA = "0x15CF998", Offset = "0x15CF998", VA = "0x15CF998", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x15CFA08", Offset = "0x15CFA08", VA = "0x15CFA08")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x15CFD70", Offset = "0x15CFD70", VA = "0x15CFD70")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000012")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF518", Offset = "0x9BF518")]
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
			[Address(RVA = "0x15CFD94", Offset = "0x15CFD94", VA = "0x15CFD94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		protected Material materialReduce
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x15CFE58", Offset = "0x15CFE58", VA = "0x15CFE58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		protected Material materialAdapt
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x15CFF1C", Offset = "0x15CFF1C", VA = "0x15CFF1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		protected Material materialApply
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x15CFFE0", Offset = "0x15CFFE0", VA = "0x15CFFE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x15D00A4", Offset = "0x15D00A4", VA = "0x15D00A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x15D0138", Offset = "0x15D0138", VA = "0x15D0138")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x15D0288", Offset = "0x15D0288", VA = "0x15D0288")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x15D04B0", Offset = "0x15D04B0", VA = "0x15D04B0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x15D070C", Offset = "0x15D070C", VA = "0x15D070C")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x15D091C", Offset = "0x15D091C", VA = "0x15D091C")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BF564", Offset = "0x9BF564")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF564", Offset = "0x9BF564")]
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
		[Address(RVA = "0x15D0994", Offset = "0x15D0994", VA = "0x15D0994", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x15D0A0C", Offset = "0x15D0A0C", VA = "0x15D0A0C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x15D0DB4", Offset = "0x15D0DB4", VA = "0x15D0DB4")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BF5FC", Offset = "0x9BF5FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF5FC", Offset = "0x9BF5FC")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x2000057")]
		public enum BlurType
		{
			[Token(Token = "0x40002C6")]
			DiscBlur,
			[Token(Token = "0x40002C7")]
			DX11
		}

		[Token(Token = "0x2000058")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x40002C9")]
			Low,
			[Token(Token = "0x40002CA")]
			Medium,
			[Token(Token = "0x40002CB")]
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
		[Address(RVA = "0x15D0DDC", Offset = "0x15D0DDC", VA = "0x15D0DDC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x15D0F7C", Offset = "0x15D0F7C", VA = "0x15D0F7C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x15D0FF0", Offset = "0x15D0FF0", VA = "0x15D0FF0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x15D10F8", Offset = "0x15D10F8", VA = "0x15D10F8")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x15D0E60", Offset = "0x15D0E60", VA = "0x15D0E60")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x15D113C", Offset = "0x15D113C", VA = "0x15D113C")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x15D12E0", Offset = "0x15D12E0", VA = "0x15D12E0")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x15D1600", Offset = "0x15D1600", VA = "0x15D1600")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x15D2C70", Offset = "0x15D2C70", VA = "0x15D2C70")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x2000015")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BF694", Offset = "0x9BF694")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF694", Offset = "0x9BF694")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x2000059")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x40002CD")]
			OnlyBackground = 1,
			[Token(Token = "0x40002CE")]
			BackgroundAndForeground
		}

		[Token(Token = "0x200005A")]
		public enum DofResolution
		{
			[Token(Token = "0x40002D0")]
			High = 2,
			[Token(Token = "0x40002D1")]
			Medium,
			[Token(Token = "0x40002D2")]
			Low
		}

		[Token(Token = "0x200005B")]
		public enum DofBlurriness
		{
			[Token(Token = "0x40002D4")]
			Low = 1,
			[Token(Token = "0x40002D5")]
			High = 2,
			[Token(Token = "0x40002D6")]
			VeryHigh = 4
		}

		[Token(Token = "0x200005C")]
		public enum BokehDestination
		{
			[Token(Token = "0x40002D8")]
			Background = 1,
			[Token(Token = "0x40002D9")]
			Foreground,
			[Token(Token = "0x40002DA")]
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
		[Address(RVA = "0x15D2CD4", Offset = "0x15D2CD4", VA = "0x15D2CD4")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x15D2DA8", Offset = "0x15D2DA8", VA = "0x15D2DA8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x15D2EAC", Offset = "0x15D2EAC", VA = "0x15D2EAC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x15D30D8", Offset = "0x15D30D8", VA = "0x15D30D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x15D3150", Offset = "0x15D3150", VA = "0x15D3150")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x15D32AC", Offset = "0x15D32AC", VA = "0x15D32AC")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x15D32D0", Offset = "0x15D32D0", VA = "0x15D32D0")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x15D32F4", Offset = "0x15D32F4", VA = "0x15D32F4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x15D40D8", Offset = "0x15D40D8", VA = "0x15D40D8")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x15D478C", Offset = "0x15D478C", VA = "0x15D478C")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x15D4BF4", Offset = "0x15D4BF4", VA = "0x15D4BF4")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x15D3F8C", Offset = "0x15D3F8C", VA = "0x15D3F8C")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x15D4374", Offset = "0x15D4374", VA = "0x15D4374")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x15D4A48", Offset = "0x15D4A48", VA = "0x15D4A48")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x15D3C58", Offset = "0x15D3C58", VA = "0x15D3C58")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x15D50DC", Offset = "0x15D50DC", VA = "0x15D50DC")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x2000016")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BF72C", Offset = "0x9BF72C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF72C", Offset = "0x9BF72C")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x200005D")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x40002DC")]
			TriangleDepthNormals,
			[Token(Token = "0x40002DD")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x40002DE")]
			SobelDepth,
			[Token(Token = "0x40002DF")]
			SobelDepthThin,
			[Token(Token = "0x40002E0")]
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
		[Address(RVA = "0x15D51C0", Offset = "0x15D51C0", VA = "0x15D51C0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x15D52F8", Offset = "0x15D52F8", VA = "0x15D52F8")]
		private new void Start()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x15D5238", Offset = "0x15D5238", VA = "0x15D5238")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x15D5304", Offset = "0x15D5304", VA = "0x15D5304")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x15D5308", Offset = "0x15D5308", VA = "0x15D5308")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x15D54F4", Offset = "0x15D54F4", VA = "0x15D54F4")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BF7C4", Offset = "0x9BF7C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF7C4", Offset = "0x9BF7C4")]
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
		[Address(RVA = "0x15D5554", Offset = "0x15D5554", VA = "0x15D5554", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x15D55AC", Offset = "0x15D55AC", VA = "0x15D55AC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x15D571C", Offset = "0x15D571C", VA = "0x15D571C")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BF85C", Offset = "0x9BF85C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF85C", Offset = "0x9BF85C")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x1B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C06EC", Offset = "0x9C06EC")]
		public bool distanceFog;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0724", Offset = "0x9C0724")]
		public bool useRadialDistance;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x1D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C075C", Offset = "0x9C075C")]
		public bool heightFog;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C0794", Offset = "0x9C0794")]
		public float height;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C07CC", Offset = "0x9C07CC")]
		public float heightDensity;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C07E8", Offset = "0x9C07E8")]
		public float startDistance;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x30")]
		public Shader fogShader;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x38")]
		private Material fogMaterial;

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x15D5740", Offset = "0x15D5740", VA = "0x15D5740", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x15D5798", Offset = "0x15D5798", VA = "0x15D5798")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x15D5FB4", Offset = "0x15D5FB4", VA = "0x15D5FB4")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x15D6124", Offset = "0x15D6124", VA = "0x15D6124")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000019")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF8F4", Offset = "0x9BF8F4")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x30")]
		public float rampOffset;

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x15D614C", Offset = "0x15D614C", VA = "0x15D614C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x15D6228", Offset = "0x15D6228", VA = "0x15D6228")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BF940", Offset = "0x9BF940")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF940", Offset = "0x9BF940")]
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
			[Address(RVA = "0x15CF8C4", Offset = "0x15CF8C4", VA = "0x15CF8C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x15D6230", Offset = "0x15D6230", VA = "0x15D6230", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x15D62E0", Offset = "0x15D62E0", VA = "0x15D62E0", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x15CF990", Offset = "0x15CF990", VA = "0x15CF990")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BF9C8", Offset = "0x9BF9C8")]
	public class ImageEffects
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x15D6390", Offset = "0x15D6390", VA = "0x15D6390")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x15D660C", Offset = "0x15D660C", VA = "0x15D660C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9C0F78", Offset = "0x9C0F78")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x15D6684", Offset = "0x15D6684", VA = "0x15D6684")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9C0FB0", Offset = "0x9C0FB0")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x15D6704", Offset = "0x15D6704", VA = "0x15D6704")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BFA00", Offset = "0x9BFA00")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BFA00", Offset = "0x9BFA00")]
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
		[Address(RVA = "0x15D670C", Offset = "0x15D670C", VA = "0x15D670C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x15D6750", Offset = "0x15D6750", VA = "0x15D6750", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x15D67C4", Offset = "0x15D67C4", VA = "0x15D67C4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x15D6B48", Offset = "0x15D6B48", VA = "0x15D6B48")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x200001D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BFA98", Offset = "0x9BFA98")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BFA98", Offset = "0x9BFA98")]
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
		[Address(RVA = "0x15D6B5C", Offset = "0x15D6B5C", VA = "0x15D6B5C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x15D6BD4", Offset = "0x15D6BD4", VA = "0x15D6BD4")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x15D7504", Offset = "0x15D7504", VA = "0x15D7504")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x15D7880", Offset = "0x15D7880", VA = "0x15D7880")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x200001E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BFB30", Offset = "0x9BFB30")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BFB30", Offset = "0x9BFB30")]
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
			[Address(RVA = "0x15D7AD8", Offset = "0x15D7AD8", VA = "0x15D7AD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x15D7998", Offset = "0x15D7998", VA = "0x15D7998")]
		protected void Start()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x15D7C34", Offset = "0x15D7C34", VA = "0x15D7C34")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x15D7D38", Offset = "0x15D7D38", VA = "0x15D7D38")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x15D7E74", Offset = "0x15D7E74", VA = "0x15D7E74")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x15D81BC", Offset = "0x15D81BC", VA = "0x15D81BC")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x200001F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BFBC8", Offset = "0x9BFBC8")]
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
		[Address(RVA = "0x15C80E4", Offset = "0x15C80E4", VA = "0x15C80E4")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x15C7810", Offset = "0x15C7810", VA = "0x15C7810")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x15D81F0", Offset = "0x15D81F0", VA = "0x15D81F0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x15D81FC", Offset = "0x15D81FC", VA = "0x15D81FC")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x15D8204", Offset = "0x15D8204", VA = "0x15D8204", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x15CDE7C", Offset = "0x15CDE7C", VA = "0x15CDE7C")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x15C76FC", Offset = "0x15C76FC", VA = "0x15C76FC")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x15CC330", Offset = "0x15CC330", VA = "0x15CC330")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x15D82B4", Offset = "0x15D82B4", VA = "0x15D82B4")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x15C7A2C", Offset = "0x15C7A2C", VA = "0x15C7A2C")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x15D82BC", Offset = "0x15D82BC", VA = "0x15D82BC")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x15C7A00", Offset = "0x15C7A00", VA = "0x15C7A00")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x15D84BC", Offset = "0x15D84BC", VA = "0x15D84BC")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x15C8048", Offset = "0x15C8048", VA = "0x15C8048")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BFC3C", Offset = "0x9BFC3C")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x15D8838", Offset = "0x15D8838", VA = "0x15D8838")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x15D88A4", Offset = "0x15D88A4", VA = "0x15D88A4")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x15D8B20", Offset = "0x15D8B20", VA = "0x15D8B20")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x15D8E98", Offset = "0x15D8E98", VA = "0x15D8E98")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x15D9044", Offset = "0x15D9044", VA = "0x15D9044")]
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
		[Address(RVA = "0x15D904C", Offset = "0x15D904C", VA = "0x15D904C")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x15D2F08", Offset = "0x15D2F08", VA = "0x15D2F08")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x15D4E1C", Offset = "0x15D4E1C", VA = "0x15D4E1C")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x15D9170", Offset = "0x15D9170", VA = "0x15D9170")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x15D96A4", Offset = "0x15D96A4", VA = "0x15D96A4")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BFCB0", Offset = "0x9BFCB0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BFCB0", Offset = "0x9BFCB0")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x200005E")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x40002E2")]
			Additive,
			[Token(Token = "0x40002E3")]
			ScreenBlend,
			[Token(Token = "0x40002E4")]
			Multiply,
			[Token(Token = "0x40002E5")]
			Overlay,
			[Token(Token = "0x40002E6")]
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
		[Address(RVA = "0x15D96B0", Offset = "0x15D96B0", VA = "0x15D96B0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x15D9708", Offset = "0x15D9708", VA = "0x15D9708")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x15D9870", Offset = "0x15D9870", VA = "0x15D9870")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BFD48", Offset = "0x9BFD48")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BFD48", Offset = "0x9BFD48")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0820", Offset = "0x9C0820")]
		public float intensity;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0838", Offset = "0x9C0838")]
		public float radius;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0854", Offset = "0x9C0854")]
		public int blurIterations;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C086C", Offset = "0x9C086C")]
		public float blurFilterDistance;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0884", Offset = "0x9C0884")]
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
		[Address(RVA = "0x15D9890", Offset = "0x15D9890", VA = "0x15D9890", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x15D98E8", Offset = "0x15D98E8", VA = "0x15D98E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x15D9990", Offset = "0x15D9990", VA = "0x15D9990")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x15D9F64", Offset = "0x15D9F64", VA = "0x15D9F64")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BFDE0", Offset = "0x9BFDE0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BFDE0", Offset = "0x9BFDE0")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x200005F")]
		public enum SSAOSamples
		{
			[Token(Token = "0x40002E8")]
			Low,
			[Token(Token = "0x40002E9")]
			Medium,
			[Token(Token = "0x40002EA")]
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
		[Address(RVA = "0x15D9F90", Offset = "0x15D9F90", VA = "0x15D9F90")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x15DA040", Offset = "0x15DA040", VA = "0x15DA040")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x15DA0DC", Offset = "0x15DA0DC", VA = "0x15DA0DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x15DA0E4", Offset = "0x15DA0E4", VA = "0x15DA0E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x15DA278", Offset = "0x15DA278", VA = "0x15DA278")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x15DA1BC", Offset = "0x15DA1BC", VA = "0x15DA1BC")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x15DA2EC", Offset = "0x15DA2EC", VA = "0x15DA2EC")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x15DA9A8", Offset = "0x15DA9A8", VA = "0x15DA9A8")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BFE78", Offset = "0x9BFE78")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x15DA9DC", Offset = "0x15DA9DC", VA = "0x15DA9DC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x15DAA6C", Offset = "0x15DAA6C", VA = "0x15DAA6C")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BFEC4", Offset = "0x9BFEC4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BFEC4", Offset = "0x9BFEC4")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x2000060")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x40002EC")]
			Low,
			[Token(Token = "0x40002ED")]
			Normal,
			[Token(Token = "0x40002EE")]
			High
		}

		[Token(Token = "0x2000061")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x40002F0")]
			Screen,
			[Token(Token = "0x40002F1")]
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
		[Address(RVA = "0x15DAA74", Offset = "0x15DAA74", VA = "0x15DAA74", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x15DAADC", Offset = "0x15DAADC", VA = "0x15DAADC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x15DB2C8", Offset = "0x15DB2C8", VA = "0x15DB2C8")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BFF5C", Offset = "0x9BFF5C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BFF5C", Offset = "0x9BFF5C")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x2000062")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x40002F3")]
			TiltShiftMode,
			[Token(Token = "0x40002F4")]
			IrisMode
		}

		[Token(Token = "0x2000063")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x40002F6")]
			Preview,
			[Token(Token = "0x40002F7")]
			Normal,
			[Token(Token = "0x40002F8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C089C", Offset = "0x9C089C")]
		public float blurArea;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C08B4", Offset = "0x9C08B4")]
		public float maxBlurSize;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C08CC", Offset = "0x9C08CC")]
		public int downsample;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x30")]
		public Shader tiltShiftShader;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x38")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x15DB368", Offset = "0x15DB368", VA = "0x15DB368", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x15DB3C0", Offset = "0x15DB3C0", VA = "0x15DB3C0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x15DB650", Offset = "0x15DB650", VA = "0x15DB650")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9BFFE4", Offset = "0x9BFFE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9BFFE4", Offset = "0x9BFFE4")]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x2000064")]
		public enum TonemapperType
		{
			[Token(Token = "0x40002FA")]
			SimpleReinhard,
			[Token(Token = "0x40002FB")]
			UserCurve,
			[Token(Token = "0x40002FC")]
			Hable,
			[Token(Token = "0x40002FD")]
			Photographic,
			[Token(Token = "0x40002FE")]
			OptimizedHejiDawson,
			[Token(Token = "0x40002FF")]
			AdaptiveReinhard,
			[Token(Token = "0x4000300")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x2000065")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x4000302")]
			Square16 = 0x10,
			[Token(Token = "0x4000303")]
			Square32 = 0x20,
			[Token(Token = "0x4000304")]
			Square64 = 0x40,
			[Token(Token = "0x4000305")]
			Square128 = 0x80,
			[Token(Token = "0x4000306")]
			Square256 = 0x100,
			[Token(Token = "0x4000307")]
			Square512 = 0x200,
			[Token(Token = "0x4000308")]
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
		[Address(RVA = "0x15DB674", Offset = "0x15DB674", VA = "0x15DB674", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x15DB7B0", Offset = "0x15DB7B0", VA = "0x15DB7B0")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x15DBA58", Offset = "0x15DBA58", VA = "0x15DBA58")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x15DBBB0", Offset = "0x15DBBB0", VA = "0x15DBBB0")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x15DBCA0", Offset = "0x15DBCA0", VA = "0x15DBCA0")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x15DC4AC", Offset = "0x15DC4AC", VA = "0x15DC4AC")]
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
		[Address(RVA = "0x15DC4E4", Offset = "0x15DC4E4", VA = "0x15DC4E4")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x15DC620", Offset = "0x15DC620", VA = "0x15DC620")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x15DC7F0", Offset = "0x15DC7F0", VA = "0x15DC7F0")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x15DCAB0", Offset = "0x15DCAB0", VA = "0x15DCAB0")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x15DCEE0", Offset = "0x15DCEE0", VA = "0x15DCEE0")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C007C", Offset = "0x9C007C")]
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
		[Address(RVA = "0x15DCEEC", Offset = "0x15DCEEC", VA = "0x15DCEEC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x15DCF30", Offset = "0x15DCF30", VA = "0x15DCF30")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C00C8", Offset = "0x9C00C8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C00C8", Offset = "0x9C00C8")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x2000066")]
		public enum AberrationMode
		{
			[Token(Token = "0x400030A")]
			Simple,
			[Token(Token = "0x400030B")]
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
		[Address(RVA = "0x15DCFAC", Offset = "0x15DCFAC", VA = "0x15DCFAC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x15DD030", Offset = "0x15DD030", VA = "0x15DD030")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x15DD63C", Offset = "0x15DD63C", VA = "0x15DD63C")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C0160", Offset = "0x9C0160")]
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
		[Address(RVA = "0x15DD678", Offset = "0x15DD678", VA = "0x15DD678")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x15DD6BC", Offset = "0x15DD6BC", VA = "0x15DD6BC")]
		public Vortex()
		{
		}
	}
}
namespace VLB
{
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C01AC", Offset = "0x9C01AC")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C01AC", Offset = "0x9C01AC")]
	public class BeamGeometry : MonoBehaviour
	{
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x18")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x20")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x60")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x68")]
		private Material m_CustomMaterial;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C08E4", Offset = "0x9C08E4")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C08F4", Offset = "0x9C08F4")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C0904", Offset = "0x9C0904")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x88")]
		private Plane m_ClippingPlaneWS;

		[Token(Token = "0x17000008")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x15DD738", Offset = "0x15DD738", VA = "0x15DD738")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C1018", Offset = "0x9C1018")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x15DD740", Offset = "0x15DD740", VA = "0x15DD740")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C1028", Offset = "0x9C1028")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x15DD748", Offset = "0x15DD748", VA = "0x15DD748")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C1038", Offset = "0x9C1038")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x15DD750", Offset = "0x15DD750", VA = "0x15DD750")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C1048", Offset = "0x9C1048")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Mesh coneMesh
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x15DD758", Offset = "0x15DD758", VA = "0x15DD758")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C1058", Offset = "0x9C1058")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x15DD760", Offset = "0x15DD760", VA = "0x15DD760")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C1068", Offset = "0x9C1068")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public bool visible
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x15DD768", Offset = "0x15DD768", VA = "0x15DD768")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x15DD784", Offset = "0x15DD784", VA = "0x15DD784")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public int sortingLayerID
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x15DD7A4", Offset = "0x15DD7A4", VA = "0x15DD7A4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x15DD7C0", Offset = "0x15DD7C0", VA = "0x15DD7C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public int sortingOrder
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x15DD7DC", Offset = "0x15DD7DC", VA = "0x15DD7DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x15DD7F8", Offset = "0x15DD7F8", VA = "0x15DD7F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x15DDBD0", Offset = "0x15DDBD0", VA = "0x15DDBD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x15DEADC", Offset = "0x15DEADC", VA = "0x15DEADC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		private bool isClippingPlaneEnabled
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x15DEB70", Offset = "0x15DEB70", VA = "0x15DEB70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000011")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x15DEBB0", Offset = "0x15DEBB0", VA = "0x15DEBB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x15DD814", Offset = "0x15DD814", VA = "0x15DD814")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x15DD8D4", Offset = "0x15DD8D4", VA = "0x15DD8D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x15DD97C", Offset = "0x15DD97C", VA = "0x15DD97C")]
		private static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x15DDA70", Offset = "0x15DDA70", VA = "0x15DDA70")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x15DDB20", Offset = "0x15DDB20", VA = "0x15DDB20")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x15DDBD8", Offset = "0x15DDBD8", VA = "0x15DDBD8")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x15DE11C", Offset = "0x15DE11C", VA = "0x15DE11C")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x15DE9EC", Offset = "0x15DE9EC", VA = "0x15DE9EC")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x15DDF1C", Offset = "0x15DDF1C", VA = "0x15DDF1C")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x15DEBF8", Offset = "0x15DEBF8", VA = "0x15DEBF8")]
		private void SetMaterialProp(string name, float value)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x15DECEC", Offset = "0x15DECEC", VA = "0x15DECEC")]
		private void SetMaterialProp(string name, Vector4 value)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x15DEE10", Offset = "0x15DEE10", VA = "0x15DEE10")]
		private void SetMaterialProp(string name, Color value)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x15DEF34", Offset = "0x15DEF34", VA = "0x15DEF34")]
		private void SetMaterialProp(string name, Matrix4x4 value)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x15DF060", Offset = "0x15DF060", VA = "0x15DF060")]
		private void SendMaterialClippingPlaneProp()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x15DE41C", Offset = "0x15DE41C", VA = "0x15DE41C")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x15DF134", Offset = "0x15DF134", VA = "0x15DF134")]
		public void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x15DF20C", Offset = "0x15DF20C", VA = "0x15DF20C")]
		public void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x15DF2B0", Offset = "0x15DF2B0", VA = "0x15DF2B0")]
		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x15DF5F4", Offset = "0x15DF5F4", VA = "0x15DF5F4")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x15DF2B8", Offset = "0x15DF2B8", VA = "0x15DF2B8")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x15DF694", Offset = "0x15DF694", VA = "0x15DF694")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C021C", Offset = "0x9C021C")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x2C")]
		public RenderPipeline renderPipeline;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9C0914", Offset = "0x9C0914")]
		public bool forceSinglePass;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x34")]
		public RenderingMode renderingMode;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader1Pass;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C0984", Offset = "0x9C0984")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C0984", Offset = "0x9C0984")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader2Pass;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x48")]
		public int sharedMeshSides;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x4C")]
		public int sharedMeshSegments;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0A04", Offset = "0x9C0A04")]
		public float globalNoiseScale;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x60")]
		[HighlightNull]
		public TextAsset noise3DData;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x68")]
		public int noise3DSize;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x70")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x0")]
		private static Config m_Instance;

		[Token(Token = "0x17000012")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1B7131C", Offset = "0x1B7131C", VA = "0x1B7131C")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000013")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1B71324", Offset = "0x1B71324", VA = "0x1B71324")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000014")]
		public Shader beamShader
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x1B71334", Offset = "0x1B71334", VA = "0x1B71334")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x1B71350", Offset = "0x1B71350", VA = "0x1B71350")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000016")]
		public static Config Instance
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x1B713F4", Offset = "0x1B713F4", VA = "0x1B713F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1B71388", Offset = "0x1B71388", VA = "0x1B71388")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9C1078", Offset = "0x9C1078")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1B71500", Offset = "0x1B71500", VA = "0x1B71500")]
		public static void OnRenderPipelineChanged(RenderPipeline pipeline)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1B715AC", Offset = "0x1B715AC", VA = "0x1B715AC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1B71770", Offset = "0x1B71770", VA = "0x1B71770")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1B71978", Offset = "0x1B71978", VA = "0x1B71978")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1B719A8", Offset = "0x1B719A8", VA = "0x1B719A8")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1B71A48", Offset = "0x1B71A48", VA = "0x1B71A48")]
		public Config()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public static class Consts
	{
		[Token(Token = "0x40001CB")]
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		[Token(Token = "0x40001CC")]
		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		[Token(Token = "0x40001CD")]
		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		[Token(Token = "0x40001CE")]
		public const string HelpUrlDynamicOcclusion = "http://saladgamer.com/vlb-doc/comp-dynocclusion/";

		[Token(Token = "0x40001CF")]
		public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

		[Token(Token = "0x40001D0")]
		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly bool ProceduralObjectsVisibleInEditor;

		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x4")]
		public static readonly Color FlatColor;

		[Token(Token = "0x40001D3")]
		public const ColorMode ColorModeDefault = ColorMode.Flat;

		[Token(Token = "0x40001D4")]
		public const float IntensityDefault = 1f;

		[Token(Token = "0x40001D5")]
		public const float IntensityMin = 0f;

		[Token(Token = "0x40001D6")]
		public const float IntensityMax = 8f;

		[Token(Token = "0x40001D7")]
		public const float SpotAngleDefault = 35f;

		[Token(Token = "0x40001D8")]
		public const float SpotAngleMin = 0.1f;

		[Token(Token = "0x40001D9")]
		public const float SpotAngleMax = 179.9f;

		[Token(Token = "0x40001DA")]
		public const float ConeRadiusStart = 0.1f;

		[Token(Token = "0x40001DB")]
		public const MeshType GeomMeshType = MeshType.Shared;

		[Token(Token = "0x40001DC")]
		public const int GeomSidesDefault = 18;

		[Token(Token = "0x40001DD")]
		public const int GeomSidesMin = 3;

		[Token(Token = "0x40001DE")]
		public const int GeomSidesMax = 256;

		[Token(Token = "0x40001DF")]
		public const int GeomSegmentsDefault = 5;

		[Token(Token = "0x40001E0")]
		public const int GeomSegmentsMin = 0;

		[Token(Token = "0x40001E1")]
		public const int GeomSegmentsMax = 64;

		[Token(Token = "0x40001E2")]
		public const bool GeomCap = false;

		[Token(Token = "0x40001E3")]
		public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

		[Token(Token = "0x40001E4")]
		public const float AttenuationCustomBlending = 0.5f;

		[Token(Token = "0x40001E5")]
		public const float FadeStart = 0f;

		[Token(Token = "0x40001E6")]
		public const float FadeEnd = 3f;

		[Token(Token = "0x40001E7")]
		public const float FadeMinThreshold = 0.01f;

		[Token(Token = "0x40001E8")]
		public const float DepthBlendDistance = 2f;

		[Token(Token = "0x40001E9")]
		public const float CameraClippingDistance = 0.5f;

		[Token(Token = "0x40001EA")]
		public const float FresnelPowMaxValue = 10f;

		[Token(Token = "0x40001EB")]
		public const float FresnelPow = 8f;

		[Token(Token = "0x40001EC")]
		public const float GlareFrontal = 0.5f;

		[Token(Token = "0x40001ED")]
		public const float GlareBehind = 0.5f;

		[Token(Token = "0x40001EE")]
		public const float NoiseIntensityMin = 0f;

		[Token(Token = "0x40001EF")]
		public const float NoiseIntensityMax = 1f;

		[Token(Token = "0x40001F0")]
		public const float NoiseIntensityDefault = 0.5f;

		[Token(Token = "0x40001F1")]
		public const float NoiseScaleMin = 0.01f;

		[Token(Token = "0x40001F2")]
		public const float NoiseScaleMax = 2f;

		[Token(Token = "0x40001F3")]
		public const float NoiseScaleDefault = 0.5f;

		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x14")]
		public static readonly Vector3 NoiseVelocityDefault;

		[Token(Token = "0x40001F5")]
		public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

		[Token(Token = "0x40001F6")]
		public const OccluderDimensions DynOcclusionDimensionsDefault = OccluderDimensions.Occluders3D;

		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x20")]
		public static readonly LayerMask DynOcclusionLayerMaskDefault;

		[Token(Token = "0x40001F8")]
		public const bool DynOcclusionConsiderTriggersDefault = false;

		[Token(Token = "0x40001F9")]
		public const float DynOcclusionMinOccluderAreaDefault = 0f;

		[Token(Token = "0x40001FA")]
		public const int DynOcclusionWaitFrameCountDefault = 3;

		[Token(Token = "0x40001FB")]
		public const float DynOcclusionMinSurfaceRatioDefault = 0.5f;

		[Token(Token = "0x40001FC")]
		public const float DynOcclusionMinSurfaceRatioMin = 50f;

		[Token(Token = "0x40001FD")]
		public const float DynOcclusionMinSurfaceRatioMax = 100f;

		[Token(Token = "0x40001FE")]
		public const float DynOcclusionMaxSurfaceDotDefault = 0.25f;

		[Token(Token = "0x40001FF")]
		public const float DynOcclusionMaxSurfaceAngleMin = 45f;

		[Token(Token = "0x4000200")]
		public const float DynOcclusionMaxSurfaceAngleMax = 90f;

		[Token(Token = "0x4000201")]
		public const PlaneAlignment DynOcclusionPlaneAlignmentDefault = PlaneAlignment.Surface;

		[Token(Token = "0x4000202")]
		public const float DynOcclusionPlaneOffsetDefault = 0.1f;

		[Token(Token = "0x4000203")]
		public const bool ConfigGeometryOverrideLayerDefault = true;

		[Token(Token = "0x4000204")]
		public const int ConfigGeometryLayerIDDefault = 1;

		[Token(Token = "0x4000205")]
		public const string ConfigGeometryTagDefault = "Untagged";

		[Token(Token = "0x4000206")]
		public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

		[Token(Token = "0x4000207")]
		public const RenderPipeline ConfigGeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

		[Token(Token = "0x4000208")]
		public const RenderingMode ConfigGeometryRenderingModeDefault = RenderingMode.MultiPass;

		[Token(Token = "0x4000209")]
		public const int ConfigNoise3DSizeDefault = 64;

		[Token(Token = "0x400020A")]
		public const int ConfigSharedMeshSides = 24;

		[Token(Token = "0x400020B")]
		public const int ConfigSharedMeshSegments = 5;

		[Token(Token = "0x17000017")]
		public static HideFlags ProceduralObjectsHideFlags
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x1B71904", Offset = "0x1B71904", VA = "0x1B71904")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x2000030")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C0254", Offset = "0x9C0254")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C0254", Offset = "0x9C0254")]
	public class DynamicOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000067")]
		public class HitResult
		{
			[Token(Token = "0x400030C")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x400030D")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 normal;

			[Token(Token = "0x400030E")]
			[FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x400030F")]
			[FieldOffset(Offset = "0x30")]
			private Collider2D collider2D;

			[Token(Token = "0x4000310")]
			[FieldOffset(Offset = "0x38")]
			private Collider collider3D;

			[Token(Token = "0x1700003B")]
			public bool hasCollider
			{
				[Token(Token = "0x60001AF")]
				[Address(RVA = "0x1B72E48", Offset = "0x1B72E48", VA = "0x1B72E48")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x1B72950", Offset = "0x1B72950", VA = "0x1B72950")]
			public HitResult(RaycastHit hit3D)
			{
			}

			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x1B72A54", Offset = "0x1B72A54", VA = "0x1B72A54")]
			public HitResult(RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x1B729C0", Offset = "0x1B729C0", VA = "0x1B729C0")]
			public HitResult()
			{
			}
		}

		[Token(Token = "0x2000068")]
		private enum Direction
		{
			[Token(Token = "0x4000312")]
			Up,
			[Token(Token = "0x4000313")]
			Right,
			[Token(Token = "0x4000314")]
			Down,
			[Token(Token = "0x4000315")]
			Left
		}

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x18")]
		public OccluderDimensions dimensions;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x1C")]
		public LayerMask layerMask;

		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x20")]
		public bool considerTriggers;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x24")]
		public float minOccluderArea;

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x28")]
		public int waitFrameCount;

		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x2C")]
		public float minSurfaceRatio;

		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x30")]
		public float maxSurfaceDot;

		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x34")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x38")]
		public float planeOffset;

		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x40")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x48")]
		private int m_FrameCountToWait;

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x4C")]
		private float m_RangeMultiplier;

		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x50")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x17000018")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x1B72300", Offset = "0x1B72300", VA = "0x1B72300")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x17000019")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x1B72314", Offset = "0x1B72314", VA = "0x1B72314")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1B71BE4", Offset = "0x1B71BE4", VA = "0x1B71BE4")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1B71C7C", Offset = "0x1B71C7C", VA = "0x1B71C7C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1B71CD4", Offset = "0x1B71CD4", VA = "0x1B71CD4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1B71D04", Offset = "0x1B71D04", VA = "0x1B71D04")]
		private void Start()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1B71DE4", Offset = "0x1B71DE4", VA = "0x1B71DE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1B72204", Offset = "0x1B72204", VA = "0x1B72204")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1B7235C", Offset = "0x1B7235C", VA = "0x1B7235C")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1B72370", Offset = "0x1B72370", VA = "0x1B72370")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1B725C0", Offset = "0x1B725C0", VA = "0x1B725C0")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1B72B3C", Offset = "0x1B72B3C", VA = "0x1B72B3C")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1B72D3C", Offset = "0x1B72D3C", VA = "0x1B72D3C")]
		private bool IsHitValid(HitResult hit)
		{
			return default(bool);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1B71E24", Offset = "0x1B71E24", VA = "0x1B71E24")]
		private void ProcessRaycasts()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1B72F88", Offset = "0x1B72F88", VA = "0x1B72F88")]
		private void SetHit(HitResult hit)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1B71CEC", Offset = "0x1B71CEC", VA = "0x1B71CEC")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1B73094", Offset = "0x1B73094", VA = "0x1B73094")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1B731CC", Offset = "0x1B731CC", VA = "0x1B731CC")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1B73450", Offset = "0x1B73450", VA = "0x1B73450")]
		public DynamicOcclusion()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public enum ColorMode
	{
		[Token(Token = "0x400021A")]
		Flat,
		[Token(Token = "0x400021B")]
		Gradient
	}
	[Token(Token = "0x2000032")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x400021D")]
		Linear,
		[Token(Token = "0x400021E")]
		Quadratic,
		[Token(Token = "0x400021F")]
		Blend
	}
	[Token(Token = "0x2000033")]
	public enum BlendingMode
	{
		[Token(Token = "0x4000221")]
		Additive,
		[Token(Token = "0x4000222")]
		SoftAdditive,
		[Token(Token = "0x4000223")]
		TraditionalTransparency
	}
	[Token(Token = "0x2000034")]
	public enum MeshType
	{
		[Token(Token = "0x4000225")]
		Shared,
		[Token(Token = "0x4000226")]
		Custom
	}
	[Token(Token = "0x2000035")]
	public enum RenderPipeline
	{
		[Token(Token = "0x4000228")]
		BuiltIn,
		[Token(Token = "0x4000229")]
		SRP_4_0_0_or_higher
	}
	[Token(Token = "0x2000036")]
	public enum RenderingMode
	{
		[Token(Token = "0x400022B")]
		MultiPass,
		[Token(Token = "0x400022C")]
		SinglePass,
		[Token(Token = "0x400022D")]
		GPUInstancing
	}
	[Token(Token = "0x2000037")]
	public enum RenderQueue
	{
		[Token(Token = "0x400022F")]
		Custom = 0,
		[Token(Token = "0x4000230")]
		Background = 1000,
		[Token(Token = "0x4000231")]
		Geometry = 2000,
		[Token(Token = "0x4000232")]
		AlphaTest = 2450,
		[Token(Token = "0x4000233")]
		GeometryLast = 2500,
		[Token(Token = "0x4000234")]
		Transparent = 3000,
		[Token(Token = "0x4000235")]
		Overlay = 4000
	}
	[Token(Token = "0x2000038")]
	public enum OccluderDimensions
	{
		[Token(Token = "0x4000237")]
		Occluders3D,
		[Token(Token = "0x4000238")]
		Occluders2D
	}
	[Token(Token = "0x2000039")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x400023A")]
		Surface,
		[Token(Token = "0x400023B")]
		Beam
	}
	[Token(Token = "0x200003A")]
	public static class GlobalMesh
	{
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1B734F0", Offset = "0x1B734F0", VA = "0x1B734F0")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1B73700", Offset = "0x1B73700", VA = "0x1B73700")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public static class GpuInstancing
	{
		[Token(Token = "0x400023E")]
		public const bool isSupported = true;

		[Token(Token = "0x1700001A")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x1B741E0", Offset = "0x1B741E0", VA = "0x1B741E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1B74254", Offset = "0x1B74254", VA = "0x1B74254")]
		public static void SetMaterialProperties(Material material, bool enableInstancing)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1B74314", Offset = "0x1B74314", VA = "0x1B74314")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1B74460", Offset = "0x1B74460", VA = "0x1B74460")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reason)
		{
			return default(bool);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1B74584", Offset = "0x1B74584", VA = "0x1B74584")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x200003C")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1B74630", Offset = "0x1B74630", VA = "0x1B74630")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class MaterialKeywordSRP
	{
		[Token(Token = "0x400023F")]
		public const string kKeyword = "VLB_SRP_API";

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1B74638", Offset = "0x1B74638", VA = "0x1B74638")]
		public MaterialKeywordSRP()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public static class MaterialManager
	{
		[Token(Token = "0x2000069")]
		public enum BlendingMode
		{
			[Token(Token = "0x4000317")]
			Additive,
			[Token(Token = "0x4000318")]
			SoftAdditive,
			[Token(Token = "0x4000319")]
			TraditionalTransparency,
			[Token(Token = "0x400031A")]
			Count
		}

		[Token(Token = "0x200006A")]
		public enum Noise3D
		{
			[Token(Token = "0x400031C")]
			Off,
			[Token(Token = "0x400031D")]
			On,
			[Token(Token = "0x400031E")]
			Count
		}

		[Token(Token = "0x200006B")]
		public enum DepthBlend
		{
			[Token(Token = "0x4000320")]
			Off,
			[Token(Token = "0x4000321")]
			On,
			[Token(Token = "0x4000322")]
			Count
		}

		[Token(Token = "0x200006C")]
		public enum ColorGradient
		{
			[Token(Token = "0x4000324")]
			Off,
			[Token(Token = "0x4000325")]
			MatrixLow,
			[Token(Token = "0x4000326")]
			MatrixHigh,
			[Token(Token = "0x4000327")]
			Count
		}

		[Token(Token = "0x200006D")]
		public enum ClippingPlane
		{
			[Token(Token = "0x4000329")]
			Off,
			[Token(Token = "0x400032A")]
			On,
			[Token(Token = "0x400032B")]
			Count
		}

		[Token(Token = "0x200006E")]
		public class StaticProperties
		{
			[Token(Token = "0x400032C")]
			[FieldOffset(Offset = "0x10")]
			public BlendingMode blendingMode;

			[Token(Token = "0x400032D")]
			[FieldOffset(Offset = "0x14")]
			public Noise3D noise3D;

			[Token(Token = "0x400032E")]
			[FieldOffset(Offset = "0x18")]
			public DepthBlend depthBlend;

			[Token(Token = "0x400032F")]
			[FieldOffset(Offset = "0x1C")]
			public ColorGradient colorGradient;

			[Token(Token = "0x4000330")]
			[FieldOffset(Offset = "0x20")]
			public ClippingPlane clippingPlane;

			[Token(Token = "0x1700003C")]
			public int materialID
			{
				[Token(Token = "0x60001B0")]
				[Address(RVA = "0x1B74AF0", Offset = "0x1B74AF0", VA = "0x1B74AF0")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x1B74B14", Offset = "0x1B74B14", VA = "0x1B74B14")]
			public void ApplyToMaterial(Material mat)
			{
			}

			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x1B74E78", Offset = "0x1B74E78", VA = "0x1B74E78")]
			public StaticProperties()
			{
			}
		}

		[Token(Token = "0x200006F")]
		private class MaterialsGroup
		{
			[Token(Token = "0x4000331")]
			[FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x1B74A68", Offset = "0x1B74A68", VA = "0x1B74A68")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x20")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1B74640", Offset = "0x1B74640", VA = "0x1B74640")]
		public static Material NewMaterial(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1B747D4", Offset = "0x1B747D4", VA = "0x1B747D4")]
		public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x200003F")]
	public static class MeshGenerator
	{
		[Token(Token = "0x4000246")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1B74E80", Offset = "0x1B74E80", VA = "0x1B74E80")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1B74E98", Offset = "0x1B74E98", VA = "0x1B74E98")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1B74F64", Offset = "0x1B74F64", VA = "0x1B74F64")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1B73800", Offset = "0x1B73800", VA = "0x1B73800")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1B74F78", Offset = "0x1B74F78", VA = "0x1B74F78")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1B74F94", Offset = "0x1B74F94", VA = "0x1B74F94")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1B74FBC", Offset = "0x1B74FBC", VA = "0x1B74FBC")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1B75058", Offset = "0x1B75058", VA = "0x1B75058")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000040")]
	public static class Noise3D
	{
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x400024A")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x400024B")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x1700001B")]
		public static bool isSupported
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x1B750F8", Offset = "0x1B750F8", VA = "0x1B750F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001C")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x1B752E8", Offset = "0x1B752E8", VA = "0x1B752E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001D")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x1B75248", Offset = "0x1B75248", VA = "0x1B75248")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1B75380", Offset = "0x1B75380", VA = "0x1B75380")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9C1088", Offset = "0x9C1088")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1B753DC", Offset = "0x1B753DC", VA = "0x1B753DC")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1B755FC", Offset = "0x1B755FC", VA = "0x1B755FC")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x2000041")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C02FC", Offset = "0x9C02FC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C02FC", Offset = "0x9C02FC")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x400024E")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x20")]
		private Mesh m_Mesh;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1B75944", Offset = "0x1B75944", VA = "0x1B75944")]
		private void Update()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1B75B64", Offset = "0x1B75B64", VA = "0x1B75B64")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public static class Utils
	{
		[Token(Token = "0x2000070")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x4000333")]
			High = 64,
			[Token(Token = "0x4000334")]
			Low = 8,
			[Token(Token = "0x4000335")]
			Undef = 0
		}

		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x4000251")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1B75B7C", Offset = "0x1B75B7C", VA = "0x1B75B7C")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		public static T NewWithComponent<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600013B")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600013C")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1B75CA0", Offset = "0x1B75CA0", VA = "0x1B75CA0")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1B75D84", Offset = "0x1B75D84", VA = "0x1B75D84")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1B75DB0", Offset = "0x1B75DB0", VA = "0x1B75DB0")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1B75DE0", Offset = "0x1B75DE0", VA = "0x1B75DE0")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1B75E14", Offset = "0x1B75E14", VA = "0x1B75E14")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1B75E4C", Offset = "0x1B75E4C", VA = "0x1B75E4C")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1B75E80", Offset = "0x1B75E80", VA = "0x1B75E80")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1B75EB0", Offset = "0x1B75EB0", VA = "0x1B75EB0")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1B72864", Offset = "0x1B72864", VA = "0x1B72864")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1B75F04", Offset = "0x1B75F04", VA = "0x1B75F04")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1B75F38", Offset = "0x1B75F38", VA = "0x1B75F38")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1B731E4", Offset = "0x1B731E4", VA = "0x1B731E4")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1B7634C", Offset = "0x1B7634C", VA = "0x1B7634C")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1B742F0", Offset = "0x1B742F0", VA = "0x1B742F0")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1B71598", Offset = "0x1B71598", VA = "0x1B71598")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1B76398", Offset = "0x1B76398", VA = "0x1B76398")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1B765E4", Offset = "0x1B765E4", VA = "0x1B765E4")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1B766EC", Offset = "0x1B766EC", VA = "0x1B766EC")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1B764E8", Offset = "0x1B764E8", VA = "0x1B764E8")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1B76798", Offset = "0x1B76798", VA = "0x1B76798")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1B76868", Offset = "0x1B76868", VA = "0x1B76868")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1B71A44", Offset = "0x1B71A44", VA = "0x1B71A44")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x2000043")]
	public static class Version
	{
		[Token(Token = "0x4000252")]
		public const int Current = 1630;
	}
	[Token(Token = "0x2000044")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C03A4", Offset = "0x9C03A4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C03A4", Offset = "0x9C03A4")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x2000071")]
		public enum Direction
		{
			[Token(Token = "0x4000337")]
			Beam,
			[Token(Token = "0x4000338")]
			Random
		}

		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0A50", Offset = "0x9C0A50")]
		public float alpha;

		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0A68", Offset = "0x9C0A68")]
		public float size;

		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x20")]
		public Direction direction;

		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x28")]
		public float density;

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0A88", Offset = "0x9C0A88")]
		public float spawnMaxDistance;

		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x30")]
		public bool cullingEnabled;

		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x34")]
		public float cullingMaxDistance;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C0AA0", Offset = "0x9C0AA0")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x40")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x48")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x50")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x1700001E")]
		public bool isCulled
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x1B76870", Offset = "0x1B76870", VA = "0x1B76870")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C11B8", Offset = "0x9C11B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1B76878", Offset = "0x1B76878", VA = "0x1B76878")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C11C8", Offset = "0x9C11C8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1B76884", Offset = "0x1B76884", VA = "0x1B76884")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x1B768F0", Offset = "0x1B768F0", VA = "0x1B768F0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000021")]
		public int particlesMaxCount
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x1B76984", Offset = "0x1B76984", VA = "0x1B76984")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000022")]
		public Camera mainCamera
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x1B76A30", Offset = "0x1B76A30", VA = "0x1B76A30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1B76C88", Offset = "0x1B76C88", VA = "0x1B76C88")]
		private void Start()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1B76CF0", Offset = "0x1B76CF0", VA = "0x1B76CF0")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1B76F5C", Offset = "0x1B76F5C", VA = "0x1B76F5C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1B76EA0", Offset = "0x1B76EA0", VA = "0x1B76EA0")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1B77520", Offset = "0x1B77520", VA = "0x1B77520")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1B775C0", Offset = "0x1B775C0", VA = "0x1B775C0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1B77680", Offset = "0x1B77680", VA = "0x1B77680")]
		private void Update()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1B76F60", Offset = "0x1B76F60", VA = "0x1B76F60")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1B776B4", Offset = "0x1B776B4", VA = "0x1B776B4")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1B77AB4", Offset = "0x1B77AB4", VA = "0x1B77AB4")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C044C", Offset = "0x9C044C")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x2000072")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C0634", Offset = "0x9C0634")]
		private sealed class <CoPlaytimeUpdate>d__111 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000339")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400033A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400033B")]
			[FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x1700003D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001B7")]
				[Address(RVA = "0x1B79318", Offset = "0x1B79318", VA = "0x1B79318", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001B9")]
				[Address(RVA = "0x1B79380", Offset = "0x1B79380", VA = "0x1B79380", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x1B78D9C", Offset = "0x1B78D9C", VA = "0x1B78D9C")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__111(int <>1__state)
			{
			}

			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x1B79290", Offset = "0x1B79290", VA = "0x1B79290", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x1B79294", Offset = "0x1B79294", VA = "0x1B79294", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x1B79320", Offset = "0x1B79320", VA = "0x1B79320", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x9C0AB0", Offset = "0x9C0AB0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C0AB0", Offset = "0x9C0AB0")]
		public Color color;

		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C0B04", Offset = "0x9C0B04")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0B04", Offset = "0x9C0B04")]
		public float intensityInside;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C0B58", Offset = "0x9C0B58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C0B58", Offset = "0x9C0B58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0B58", Offset = "0x9C0B58")]
		public float intensityOutside;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C0BD0", Offset = "0x9C0BD0")]
		public bool spotAngleFromLight;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0C08", Offset = "0x9C0C08")]
		public float spotAngle;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C0C28", Offset = "0x9C0C28")]
		public float coneRadiusStart;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x54")]
		public MeshType geomMeshType;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C0C60", Offset = "0x9C0C60")]
		public int geomCustomSides;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x5C")]
		public int geomCustomSegments;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x60")]
		public bool geomCap;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x61")]
		public bool fadeEndFromLight;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x64")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0C98", Offset = "0x9C0C98")]
		public float attenuationCustomBlending;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x6C")]
		public float fadeStart;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x70")]
		public float fadeEnd;

		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x74")]
		public float depthBlendDistance;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x78")]
		public float cameraClippingDistance;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0CB0", Offset = "0x9C0CB0")]
		public float glareFrontal;

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0CC8", Offset = "0x9C0CC8")]
		public float glareBehind;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9C0CE0", Offset = "0x9C0CE0")]
		public float boostDistanceInside;

		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9C0D18", Offset = "0x9C0D18")]
		public float fresnelPowInside;

		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C0D50", Offset = "0x9C0D50")]
		public float fresnelPow;

		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x90")]
		public bool noiseEnabled;

		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0D88", Offset = "0x9C0D88")]
		public float noiseIntensity;

		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x98")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0DA0", Offset = "0x9C0DA0")]
		public float noiseScaleLocal;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0xA0")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0xA4")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0xB0")]
		private Plane m_PlaneWS;

		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C0DCC", Offset = "0x9C0DCC")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C0E38", Offset = "0x9C0E38")]
		private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField;

		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0xD8")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0xE0")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0xE8")]
		private Light _CachedLight;

		[Token(Token = "0x17000023")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9C12E4", Offset = "0x9C12E4")]
		public float alphaInside
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x1B77B60", Offset = "0x1B77B60", VA = "0x1B77B60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x1B77B68", Offset = "0x1B77B68", VA = "0x1B77B68")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9C131C", Offset = "0x9C131C")]
		public float alphaOutside
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x1B77B70", Offset = "0x1B77B70", VA = "0x1B77B70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x1B77B78", Offset = "0x1B77B78", VA = "0x1B77B78")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public float intensityGlobal
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x1B77B80", Offset = "0x1B77B80", VA = "0x1B77B80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x1B77B88", Offset = "0x1B77B88", VA = "0x1B77B88")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public float coneAngle
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x1B77878", Offset = "0x1B77878", VA = "0x1B77878")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000027")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x1B72EFC", Offset = "0x1B72EFC", VA = "0x1B72EFC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000028")]
		public float coneVolume
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x1B77B90", Offset = "0x1B77B90", VA = "0x1B77B90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000029")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x1B77BE4", Offset = "0x1B77BE4", VA = "0x1B77BE4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002A")]
		public int geomSides
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x1B77C3C", Offset = "0x1B77C3C", VA = "0x1B77C3C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x1B77CC4", Offset = "0x1B77CC4", VA = "0x1B77CC4")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public int geomSegments
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x1B77D44", Offset = "0x1B77D44", VA = "0x1B77D44")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x1B77DCC", Offset = "0x1B77DCC", VA = "0x1B77DCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x1B77E4C", Offset = "0x1B77E4C", VA = "0x1B77E4C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x1B77E74", Offset = "0x1B77E74", VA = "0x1B77E74")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x1B77E7C", Offset = "0x1B77E7C", VA = "0x1B77E7C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public string sortingLayerName
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x1B77F24", Offset = "0x1B77F24", VA = "0x1B77F24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x1B77F30", Offset = "0x1B77F30", VA = "0x1B77F30")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public int sortingOrder
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x1B77F60", Offset = "0x1B77F60", VA = "0x1B77F60")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x1B77F68", Offset = "0x1B77F68", VA = "0x1B77F68")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x1B78010", Offset = "0x1B78010", VA = "0x1B78010")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x1B78018", Offset = "0x1B78018", VA = "0x1B78018")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x1B78078", Offset = "0x1B78078", VA = "0x1B78078")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000032")]
		public bool hasGeometry
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x1B77918", Offset = "0x1B77918", VA = "0x1B77918")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000033")]
		public Bounds bounds
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x1B77988", Offset = "0x1B77988", VA = "0x1B77988")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000034")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x1B781AC", Offset = "0x1B781AC", VA = "0x1B781AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000035")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x1B782A4", Offset = "0x1B782A4", VA = "0x1B782A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C11D8", Offset = "0x9C11D8")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x1B782AC", Offset = "0x1B782AC", VA = "0x1B782AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C11E8", Offset = "0x9C11E8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public string meshStats
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x1B782B4", Offset = "0x1B782B4", VA = "0x1B782B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public int meshVerticesCount
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x1B7843C", Offset = "0x1B7843C", VA = "0x1B7843C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000038")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x1B78518", Offset = "0x1B78518", VA = "0x1B78518")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000039")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x1B7860C", Offset = "0x1B7860C", VA = "0x1B7860C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1B73304", Offset = "0x1B73304", VA = "0x1B73304")]
		public void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1B733C4", Offset = "0x1B733C4", VA = "0x1B733C4")]
		public void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1B78088", Offset = "0x1B78088", VA = "0x1B78088")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1B78704", Offset = "0x1B78704", VA = "0x1B78704")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1B78764", Offset = "0x1B78764", VA = "0x1B78764")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1B78900", Offset = "0x1B78900", VA = "0x1B78900")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9C11F8", Offset = "0x9C11F8")]
		public void Generate()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1B7890C", Offset = "0x1B7890C", VA = "0x1B7890C", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1B78B68", Offset = "0x1B78B68", VA = "0x1B78B68", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1B78C00", Offset = "0x1B78C00", VA = "0x1B78C00")]
		private void Start()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1B78C0C", Offset = "0x1B78C0C", VA = "0x1B78C0C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1B78C9C", Offset = "0x1B78C9C", VA = "0x1B78C9C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1B78024", Offset = "0x1B78024", VA = "0x1B78024")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1B78D2C", Offset = "0x1B78D2C", VA = "0x1B78D2C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9C1230", Offset = "0x9C1230")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1B78DC8", Offset = "0x1B78DC8", VA = "0x1B78DC8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1B78DCC", Offset = "0x1B78DCC", VA = "0x1B78DCC")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1B78E8C", Offset = "0x1B78E8C", VA = "0x1B78E8C")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1B78F8C", Offset = "0x1B78F8C", VA = "0x1B78F8C")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1B78B38", Offset = "0x1B78B38", VA = "0x1B78B38")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1B78A28", Offset = "0x1B78A28", VA = "0x1B78A28")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1B79178", Offset = "0x1B79178", VA = "0x1B79178")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C04B8", Offset = "0x9C04B8")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1B79388", Offset = "0x1B79388", VA = "0x1B79388")]
		private void Update()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1B7947C", Offset = "0x1B7947C", VA = "0x1B7947C")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C051C", Offset = "0x9C051C")]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x18")]
		private bool isInsideBeam;

		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1B7948C", Offset = "0x1B7948C", VA = "0x1B7948C")]
		private void Start()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1B79548", Offset = "0x1B79548", VA = "0x1B79548")]
		private void Update()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1B79604", Offset = "0x1B79604", VA = "0x1B79604")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1B7960C", Offset = "0x1B7960C", VA = "0x1B7960C")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1B796C8", Offset = "0x1B796C8", VA = "0x1B796C8")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C05C0", Offset = "0x9C05C0")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1B796D0", Offset = "0x1B796D0", VA = "0x1B796D0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1B797A0", Offset = "0x1B797A0", VA = "0x1B797A0")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x1700003A")]
		private bool useMouseView
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x1B797A8", Offset = "0x1B797A8", VA = "0x1B797A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x1B797B0", Offset = "0x1B797B0", VA = "0x1B797B0")]
			set
			{
			}
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1B797EC", Offset = "0x1B797EC", VA = "0x1B797EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1B79884", Offset = "0x1B79884", VA = "0x1B79884")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1B79F24", Offset = "0x1B79F24", VA = "0x1B79F24")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0E58", Offset = "0x9C0E58")]
		[SerializeField]
		private int CountX;

		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C0E9C", Offset = "0x9C0E9C")]
		[SerializeField]
		private int CountY;

		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1B79F48", Offset = "0x1B79F48", VA = "0x1B79F48")]
		public void Generate()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1B7A770", Offset = "0x1B7A770", VA = "0x1B7A770")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C0F20", Offset = "0x9C0F20")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1B7A78C", Offset = "0x1B7A78C", VA = "0x1B7A78C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1B7A904", Offset = "0x1B7A904", VA = "0x1B7A904")]
		public Rotater()
		{
		}
	}
}
