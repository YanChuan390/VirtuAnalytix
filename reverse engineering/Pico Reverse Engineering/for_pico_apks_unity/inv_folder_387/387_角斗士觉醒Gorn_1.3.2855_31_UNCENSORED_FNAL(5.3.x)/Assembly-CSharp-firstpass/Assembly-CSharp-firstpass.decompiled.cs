using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
internal enum IsolatedArabicLetters
{
	[Token(Token = "0x4000002")]
	Hamza = 65152,
	[Token(Token = "0x4000003")]
	Alef = 65165,
	[Token(Token = "0x4000004")]
	AlefHamza = 65155,
	[Token(Token = "0x4000005")]
	WawHamza = 65157,
	[Token(Token = "0x4000006")]
	AlefMaksoor = 65159,
	[Token(Token = "0x4000007")]
	AlefMaksora = 64508,
	[Token(Token = "0x4000008")]
	HamzaNabera = 65161,
	[Token(Token = "0x4000009")]
	Ba = 65167,
	[Token(Token = "0x400000A")]
	Ta = 65173,
	[Token(Token = "0x400000B")]
	Tha2 = 65177,
	[Token(Token = "0x400000C")]
	Jeem = 65181,
	[Token(Token = "0x400000D")]
	H7aa = 65185,
	[Token(Token = "0x400000E")]
	Khaa2 = 65189,
	[Token(Token = "0x400000F")]
	Dal = 65193,
	[Token(Token = "0x4000010")]
	Thal = 65195,
	[Token(Token = "0x4000011")]
	Ra2 = 65197,
	[Token(Token = "0x4000012")]
	Zeen = 65199,
	[Token(Token = "0x4000013")]
	Seen = 65201,
	[Token(Token = "0x4000014")]
	Sheen = 65205,
	[Token(Token = "0x4000015")]
	S9a = 65209,
	[Token(Token = "0x4000016")]
	Dha = 65213,
	[Token(Token = "0x4000017")]
	T6a = 65217,
	[Token(Token = "0x4000018")]
	T6ha = 65221,
	[Token(Token = "0x4000019")]
	Ain = 65225,
	[Token(Token = "0x400001A")]
	Gain = 65229,
	[Token(Token = "0x400001B")]
	Fa = 65233,
	[Token(Token = "0x400001C")]
	Gaf = 65237,
	[Token(Token = "0x400001D")]
	Kaf = 65241,
	[Token(Token = "0x400001E")]
	Lam = 65245,
	[Token(Token = "0x400001F")]
	Meem = 65249,
	[Token(Token = "0x4000020")]
	Noon = 65253,
	[Token(Token = "0x4000021")]
	Ha = 65257,
	[Token(Token = "0x4000022")]
	Waw = 65261,
	[Token(Token = "0x4000023")]
	Ya = 65265,
	[Token(Token = "0x4000024")]
	AlefMad = 65153,
	[Token(Token = "0x4000025")]
	TaMarboota = 65171,
	[Token(Token = "0x4000026")]
	PersianPe = 64342,
	[Token(Token = "0x4000027")]
	PersianChe = 64378,
	[Token(Token = "0x4000028")]
	PersianZe = 64394,
	[Token(Token = "0x4000029")]
	PersianGaf = 64402,
	[Token(Token = "0x400002A")]
	PersianGaf2 = 64398
}
[Token(Token = "0x2000003")]
internal enum GeneralArabicLetters
{
	[Token(Token = "0x400002C")]
	Hamza = 1569,
	[Token(Token = "0x400002D")]
	Alef = 1575,
	[Token(Token = "0x400002E")]
	AlefHamza = 1571,
	[Token(Token = "0x400002F")]
	WawHamza = 1572,
	[Token(Token = "0x4000030")]
	AlefMaksoor = 1573,
	[Token(Token = "0x4000031")]
	AlefMagsora = 1609,
	[Token(Token = "0x4000032")]
	HamzaNabera = 1574,
	[Token(Token = "0x4000033")]
	Ba = 1576,
	[Token(Token = "0x4000034")]
	Ta = 1578,
	[Token(Token = "0x4000035")]
	Tha2 = 1579,
	[Token(Token = "0x4000036")]
	Jeem = 1580,
	[Token(Token = "0x4000037")]
	H7aa = 1581,
	[Token(Token = "0x4000038")]
	Khaa2 = 1582,
	[Token(Token = "0x4000039")]
	Dal = 1583,
	[Token(Token = "0x400003A")]
	Thal = 1584,
	[Token(Token = "0x400003B")]
	Ra2 = 1585,
	[Token(Token = "0x400003C")]
	Zeen = 1586,
	[Token(Token = "0x400003D")]
	Seen = 1587,
	[Token(Token = "0x400003E")]
	Sheen = 1588,
	[Token(Token = "0x400003F")]
	S9a = 1589,
	[Token(Token = "0x4000040")]
	Dha = 1590,
	[Token(Token = "0x4000041")]
	T6a = 1591,
	[Token(Token = "0x4000042")]
	T6ha = 1592,
	[Token(Token = "0x4000043")]
	Ain = 1593,
	[Token(Token = "0x4000044")]
	Gain = 1594,
	[Token(Token = "0x4000045")]
	Fa = 1601,
	[Token(Token = "0x4000046")]
	Gaf = 1602,
	[Token(Token = "0x4000047")]
	Kaf = 1603,
	[Token(Token = "0x4000048")]
	Lam = 1604,
	[Token(Token = "0x4000049")]
	Meem = 1605,
	[Token(Token = "0x400004A")]
	Noon = 1606,
	[Token(Token = "0x400004B")]
	Ha = 1607,
	[Token(Token = "0x400004C")]
	Waw = 1608,
	[Token(Token = "0x400004D")]
	Ya = 1610,
	[Token(Token = "0x400004E")]
	AlefMad = 1570,
	[Token(Token = "0x400004F")]
	TaMarboota = 1577,
	[Token(Token = "0x4000050")]
	PersianPe = 1662,
	[Token(Token = "0x4000051")]
	PersianChe = 1670,
	[Token(Token = "0x4000052")]
	PersianZe = 1688,
	[Token(Token = "0x4000053")]
	PersianGaf = 1711,
	[Token(Token = "0x4000054")]
	PersianGaf2 = 1705
}
[Token(Token = "0x2000004")]
internal class ArabicTable
{
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, int> mapList;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x8")]
	private static ArabicTable arabicMapper;

	[Token(Token = "0x17000001")]
	internal static ArabicTable ArabicMapper
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x793394", Offset = "0x793394", VA = "0x793394")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x792FA4", Offset = "0x792FA4", VA = "0x792FA4")]
	private ArabicTable()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x79340C", Offset = "0x79340C", VA = "0x79340C")]
	internal int Convert(int toBeConverted)
	{
		return default(int);
	}
}
[Token(Token = "0x2000005")]
internal class ArabicFixerTool
{
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x0")]
	internal static bool showTashkeel;

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x1")]
	internal static bool useHinduNumbers;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x8")]
	private static readonly HashSet<char> persianCharacters;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x10")]
	private static readonly HashSet<char> lettersThatCannotBeBeforeALeadingLetter;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x18")]
	private static readonly HashSet<char> lettersThatCannotBeBeforeOrAALeadingLetter;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x79349C", Offset = "0x79349C", VA = "0x79349C")]
	internal static string RemoveTashkeel(string str, out Dictionary<int, char> tashkeelLocation)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x793710", Offset = "0x793710", VA = "0x793710")]
	internal static string ReturnTashkeel(char[] letters, Dictionary<int, char> tashkeelLocation)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x79384C", Offset = "0x79384C", VA = "0x79384C")]
	private static bool IsEnglishLetterOrNumber(char c)
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x7938F4", Offset = "0x7938F4", VA = "0x7938F4")]
	internal static string FixLine(string str)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x794288", Offset = "0x794288", VA = "0x794288")]
	internal static bool IsIgnoredCharacter(char ch)
	{
		return default(bool);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x794820", Offset = "0x794820", VA = "0x794820")]
	internal static bool IsLeadingLetter(char[] letters, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x7946BC", Offset = "0x7946BC", VA = "0x7946BC")]
	internal static bool IsFinishingLetter(char[] letters, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x7943B0", Offset = "0x7943B0", VA = "0x7943B0")]
	internal static bool IsMiddleLetter(char[] letters, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x794AA0", Offset = "0x794AA0", VA = "0x794AA0")]
	public ArabicFixerTool()
	{
	}
}
[Token(Token = "0x2000007")]
[AddComponentMenu("Image Effects/Edge Detection (Color)")]
[ExecuteInEditMode]
public class EdgeDetectEffect : ImageEffectBase
{
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x28")]
	public float threshold;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x794DA8", Offset = "0x794DA8", VA = "0x794DA8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x794E68", Offset = "0x794E68", VA = "0x794E68")]
	public EdgeDetectEffect()
	{
	}
}
[Token(Token = "0x2000008")]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Glow")]
[ExecuteInEditMode]
public class GlowEffect : MonoBehaviour
{
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x18")]
	public float glowIntensity;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x1C")]
	public int blurIterations;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x20")]
	public float blurSpread;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x24")]
	public Color glowTint;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x38")]
	public Shader compositeShader;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x40")]
	private Material m_CompositeMaterial;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x48")]
	public Shader blurShader;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x50")]
	private Material m_BlurMaterial;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x58")]
	public Shader downsampleShader;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x60")]
	private Material m_DownsampleMaterial;

	[Token(Token = "0x17000002")]
	protected Material compositeMaterial
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x794E7C", Offset = "0x794E7C", VA = "0x794E7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	protected Material blurMaterial
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x794F50", Offset = "0x794F50", VA = "0x794F50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	protected Material downsampleMaterial
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x795024", Offset = "0x795024", VA = "0x795024")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x7950F8", Offset = "0x7950F8", VA = "0x7950F8")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x79520C", Offset = "0x79520C", VA = "0x79520C")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x795370", Offset = "0x795370", VA = "0x795370")]
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x795480", Offset = "0x795480", VA = "0x795480")]
	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x795528", Offset = "0x795528", VA = "0x795528")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x795788", Offset = "0x795788", VA = "0x795788")]
	public void BlitGlow(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x795840", Offset = "0x795840", VA = "0x795840")]
	public GlowEffect()
	{
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x2000009")]
	public enum AAMode
	{
		[Token(Token = "0x400006A")]
		FXAA2,
		[Token(Token = "0x400006B")]
		FXAA3Console,
		[Token(Token = "0x400006C")]
		FXAA1PresetA,
		[Token(Token = "0x400006D")]
		FXAA1PresetB,
		[Token(Token = "0x400006E")]
		NFAA,
		[Token(Token = "0x400006F")]
		SSAA,
		[Token(Token = "0x4000070")]
		DLAA
	}
	[Token(Token = "0x200000A")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Antialiasing")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x28")]
		public AAMode mode;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x30")]
		public float offsetScale;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x34")]
		public float blurRadius;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x50")]
		private Material ssaa;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x60")]
		private Material dlaa;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x70")]
		private Material nfaa;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x795864", Offset = "0x795864", VA = "0x795864")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x7958CC", Offset = "0x7958CC", VA = "0x7958CC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x795A3C", Offset = "0x795A3C", VA = "0x795A3C")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x795F00", Offset = "0x795F00", VA = "0x795F00")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x200000B")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x200000C")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x40000A6")]
			Ghosting,
			[Token(Token = "0x40000A7")]
			Anamorphic,
			[Token(Token = "0x40000A8")]
			Combined
		}

		[Token(Token = "0x200000D")]
		public enum TweakMode
		{
			[Token(Token = "0x40000AA")]
			Basic,
			[Token(Token = "0x40000AB")]
			Complex
		}

		[Token(Token = "0x200000E")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x40000AD")]
			Auto,
			[Token(Token = "0x40000AE")]
			On,
			[Token(Token = "0x40000AF")]
			Off
		}

		[Token(Token = "0x200000F")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x40000B1")]
			Screen,
			[Token(Token = "0x40000B2")]
			Add
		}

		[Token(Token = "0x2000010")]
		public enum BloomQuality
		{
			[Token(Token = "0x40000B4")]
			Cheap,
			[Token(Token = "0x40000B5")]
			High
		}

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x28")]
		public TweakMode tweakMode;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x3C")]
		public BloomQuality quality;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x48")]
		public Color bloomThresholdColor;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x58")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x5C")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x60")]
		public float flareRotation;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x64")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x68")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x6C")]
		public float lensflareIntensity;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x70")]
		public float lensflareThreshold;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x74")]
		public float lensFlareSaturation;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x78")]
		public Color flareColorA;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x88")]
		public Color flareColorB;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x98")]
		public Color flareColorC;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0xA8")]
		public Color flareColorD;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0xB8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0xC0")]
		public Shader lensFlareShader;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0xC8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0xD0")]
		public Shader screenBlendShader;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0xD8")]
		private Material screenBlend;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0xE0")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0xE8")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0xF0")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0xF8")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x795F24", Offset = "0x795F24", VA = "0x795F24", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x796010", Offset = "0x796010", VA = "0x796010")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x797180", Offset = "0x797180", VA = "0x797180")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x796FE8", Offset = "0x796FE8", VA = "0x796FE8")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x796D3C", Offset = "0x796D3C", VA = "0x796D3C")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x796C68", Offset = "0x796C68", VA = "0x796C68")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x796DFC", Offset = "0x796DFC", VA = "0x796DFC")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x797244", Offset = "0x797244", VA = "0x797244")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x40000B7")]
		Ghosting,
		[Token(Token = "0x40000B8")]
		Anamorphic,
		[Token(Token = "0x40000B9")]
		Combined
	}
	[Token(Token = "0x2000012")]
	public enum TweakMode34
	{
		[Token(Token = "0x40000BB")]
		Basic,
		[Token(Token = "0x40000BC")]
		Complex
	}
	[Token(Token = "0x2000013")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x40000BE")]
		Auto,
		[Token(Token = "0x40000BF")]
		On,
		[Token(Token = "0x40000C0")]
		Off
	}
	[Token(Token = "0x2000014")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x40000C2")]
		Screen,
		[Token(Token = "0x40000C3")]
		Add
	}
	[Token(Token = "0x2000015")]
	[AddComponentMenu("Image Effects/Bloom and Glow/BloomAndFlares (3.5, Deprecated)")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x28")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x3C")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x48")]
		public int bloomBlurIterations;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x4C")]
		public bool lensflares;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x54")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x58")]
		public float hollyStretchWidth;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x5C")]
		public float lensflareIntensity;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x60")]
		public float lensflareThreshold;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x64")]
		public Color flareColorA;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x74")]
		public Color flareColorB;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x84")]
		public Color flareColorC;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x94")]
		public Color flareColorD;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0xA8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0xB0")]
		public Shader lensFlareShader;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0xB8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0xC0")]
		public Shader vignetteShader;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0xC8")]
		private Material vignetteMaterial;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0xD0")]
		public Shader separableBlurShader;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0xD8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0xE0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0xE8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0xF0")]
		public Shader screenBlendShader;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0xF8")]
		private Material screenBlend;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x100")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x108")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x110")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x118")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x7972D0", Offset = "0x7972D0", VA = "0x7972D0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x79742C", Offset = "0x79742C", VA = "0x79742C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x7981EC", Offset = "0x7981EC", VA = "0x7981EC")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x798064", Offset = "0x798064", VA = "0x798064")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x797E0C", Offset = "0x797E0C", VA = "0x797E0C")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x797F14", Offset = "0x797F14", VA = "0x797F14")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x79829C", Offset = "0x79829C", VA = "0x79829C")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x2000016")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000017")]
		public enum Resolution
		{
			[Token(Token = "0x40000EF")]
			Low,
			[Token(Token = "0x40000F0")]
			High
		}

		[Token(Token = "0x2000018")]
		public enum BlurType
		{
			[Token(Token = "0x40000F2")]
			Standard,
			[Token(Token = "0x40000F3")]
			Sgx
		}

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1.5f)]
		public float threshold;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 2.5f)]
		public float intensity;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x30")]
		[Range(0.25f, 5.5f)]
		public float blurSize;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x38")]
		[Range(1f, 4f)]
		public int blurIterations;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x3C")]
		public BlurType blurType;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x798310", Offset = "0x798310", VA = "0x798310", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x798384", Offset = "0x798384", VA = "0x798384")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x798410", Offset = "0x798410", VA = "0x798410")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x798780", Offset = "0x798780", VA = "0x798780")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x2000019")]
	[AddComponentMenu("Image Effects/Blur/Blur")]
	[ExecuteInEditMode]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float blurSpread;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x17000005")]
		protected Material material
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x7987A4", Offset = "0x7987A4", VA = "0x7987A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x7988AC", Offset = "0x7988AC", VA = "0x7988AC")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x798958", Offset = "0x798958", VA = "0x798958")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x798A08", Offset = "0x798A08", VA = "0x798A08")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x798B18", Offset = "0x798B18", VA = "0x798B18")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x798C14", Offset = "0x798C14", VA = "0x798C14")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x798D70", Offset = "0x798D70", VA = "0x798D70")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x200001B")]
		public enum BlurType
		{
			[Token(Token = "0x40000FF")]
			StandardGauss,
			[Token(Token = "0x4000100")]
			SgxGauss
		}

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 2f)]
		public int downsample;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 10f)]
		public float blurSize;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x30")]
		[Range(1f, 4f)]
		public int blurIterations;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x34")]
		public BlurType blurType;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x798D88", Offset = "0x798D88", VA = "0x798D88", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x798DFC", Offset = "0x798DFC", VA = "0x798DFC")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x798E88", Offset = "0x798E88", VA = "0x798E88")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x7991B0", Offset = "0x7991B0", VA = "0x7991B0")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[AddComponentMenu("Image Effects/Camera/Camera Motion Blur")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x200001D")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x4000122")]
			CameraMotion,
			[Token(Token = "0x4000123")]
			LocalBlur,
			[Token(Token = "0x4000124")]
			Reconstruction,
			[Token(Token = "0x4000125")]
			ReconstructionDX11,
			[Token(Token = "0x4000126")]
			ReconstructionDisc
		}

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x28")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x2C")]
		public bool preview;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 previewScale;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x3C")]
		public float movementScale;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x40")]
		public float rotationScale;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x44")]
		public float maxVelocity;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x48")]
		public float minVelocity;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x4C")]
		public float velocityScale;

		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x50")]
		public float softZDistance;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x54")]
		public int velocityDownsample;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x58")]
		public LayerMask excludeLayers;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x60")]
		private GameObject tmpCam;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x68")]
		public Shader shader;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x70")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x78")]
		public Shader replacementClear;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x80")]
		private Material motionBlurMaterial;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x88")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x90")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x98")]
		public float jitter;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x9C")]
		public bool showVelocity;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0xA0")]
		public float showVelocityScale;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0xA4")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0xE8")]
		private Matrix4x4[] currentStereoViewProjMat;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0xF0")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x130")]
		private Matrix4x4[] prevStereoViewProjMat;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x138")]
		private int prevFrameCount;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x13C")]
		private bool wasActive;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x140")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x14C")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x158")]
		private Vector3 prevFramePos;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x168")]
		private Camera _camera;

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x7991CC", Offset = "0x7991CC", VA = "0x7991CC")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x79942C", Offset = "0x79942C", VA = "0x79942C")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x7996BC", Offset = "0x7996BC", VA = "0x7996BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x79977C", Offset = "0x79977C", VA = "0x79977C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x7998E0", Offset = "0x7998E0", VA = "0x7998E0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x799994", Offset = "0x799994", VA = "0x799994")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x79955C", Offset = "0x79955C", VA = "0x79955C")]
		private void Remember()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x79B4E8", Offset = "0x79B4E8", VA = "0x79B4E8")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x79B464", Offset = "0x79B464", VA = "0x79B464")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x79B4D8", Offset = "0x79B4D8", VA = "0x79B4D8")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x79B87C", Offset = "0x79B87C", VA = "0x79B87C")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x200001E")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x200001F")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x4000140")]
			Simple,
			[Token(Token = "0x4000141")]
			Advanced
		}

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x98")]
		public float saturation;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0xC0")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x79BA14", Offset = "0x79BA14", VA = "0x79BA14")]
		private new void Start()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x79BA34", Offset = "0x79BA34", VA = "0x79BA34")]
		private void Awake()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x79BA38", Offset = "0x79BA38", VA = "0x79BA38", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x79BCFC", Offset = "0x79BCFC", VA = "0x79BCFC")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x79BFF0", Offset = "0x79BFF0", VA = "0x79BFF0")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x79BFF4", Offset = "0x79BFF4", VA = "0x79BFF4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x79C300", Offset = "0x79C300", VA = "0x79C300")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
	[ExecuteInEditMode]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x30")]
		private Material material;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x79C98C", Offset = "0x79C98C", VA = "0x79C98C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x79C9FC", Offset = "0x79C9FC", VA = "0x79C9FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x79CA98", Offset = "0x79CA98", VA = "0x79CA98")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x79CB28", Offset = "0x79CB28", VA = "0x79CB28")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x79CD24", Offset = "0x79CD24", VA = "0x79CD24")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x79CE24", Offset = "0x79CE24", VA = "0x79CE24")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x79D16C", Offset = "0x79D16C", VA = "0x79D16C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x79D360", Offset = "0x79D360", VA = "0x79D360")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x79D3B8", Offset = "0x79D3B8", VA = "0x79D3B8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x79D474", Offset = "0x79D474", VA = "0x79D474")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
	[RequireComponent(typeof(Camera))]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float intensity;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 0.999f)]
		public float threshold;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float blurSpread;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x79D47C", Offset = "0x79D47C", VA = "0x79D47C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x79D518", Offset = "0x79D518", VA = "0x79D518")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x79D844", Offset = "0x79D844", VA = "0x79D844")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
	[ExecuteInEditMode]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x18")]
		[Range(0.0001f, 1f)]
		public float adaptationSpeed;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float limitMinimum;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float limitMaximum;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x17000006")]
		protected Material materialLum
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x79D85C", Offset = "0x79D85C", VA = "0x79D85C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		protected Material materialReduce
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x79D930", Offset = "0x79D930", VA = "0x79D930")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		protected Material materialAdapt
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x79DA04", Offset = "0x79DA04", VA = "0x79DA04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		protected Material materialApply
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x79DAD8", Offset = "0x79DAD8", VA = "0x79DAD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x79DBAC", Offset = "0x79DBAC", VA = "0x79DBAC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x79DC30", Offset = "0x79DC30", VA = "0x79DC30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x79DD7C", Offset = "0x79DD7C", VA = "0x79DD7C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x79DF58", Offset = "0x79DF58", VA = "0x79DF58")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x79E198", Offset = "0x79E198", VA = "0x79E198")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x79E350", Offset = "0x79E350", VA = "0x79E350")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
	[ExecuteInEditMode]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x28")]
		public float intensity;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x2C")]
		public int softness;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x30")]
		public float spread;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x79E3CC", Offset = "0x79E3CC", VA = "0x79E3CC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x79E490", Offset = "0x79E490", VA = "0x79E490")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x79E808", Offset = "0x79E808", VA = "0x79E808")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (Lens Blur, Scatter, DX11)")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x2000026")]
		public enum BlurType
		{
			[Token(Token = "0x400017E")]
			DiscBlur,
			[Token(Token = "0x400017F")]
			DX11
		}

		[Token(Token = "0x2000027")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x4000181")]
			Low,
			[Token(Token = "0x4000182")]
			Medium,
			[Token(Token = "0x4000183")]
			High
		}

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x2C")]
		public float focalLength;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x30")]
		public float focalSize;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x34")]
		public float aperture;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x44")]
		public bool highResolution;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x48")]
		public BlurType blurType;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x4C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x79E824", Offset = "0x79E824", VA = "0x79E824", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x79EA24", Offset = "0x79EA24", VA = "0x79EA24")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x79EAA4", Offset = "0x79EAA4", VA = "0x79EAA4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x79EB9C", Offset = "0x79EB9C", VA = "0x79EB9C")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x79E8DC", Offset = "0x79E8DC", VA = "0x79E8DC")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x79EBF4", Offset = "0x79EBF4", VA = "0x79EBF4")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x79ECE0", Offset = "0x79ECE0", VA = "0x79ECE0")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x79EFB0", Offset = "0x79EFB0", VA = "0x79EFB0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x7A02B0", Offset = "0x7A02B0", VA = "0x7A02B0")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (deprecated)")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x2000029")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x40001B0")]
			OnlyBackground = 1,
			[Token(Token = "0x40001B1")]
			BackgroundAndForeground
		}

		[Token(Token = "0x200002A")]
		public enum DofResolution
		{
			[Token(Token = "0x40001B3")]
			High = 2,
			[Token(Token = "0x40001B4")]
			Medium,
			[Token(Token = "0x40001B5")]
			Low
		}

		[Token(Token = "0x200002B")]
		public enum DofBlurriness
		{
			[Token(Token = "0x40001B7")]
			Low = 1,
			[Token(Token = "0x40001B8")]
			High = 2,
			[Token(Token = "0x40001B9")]
			VeryHigh = 4
		}

		[Token(Token = "0x200002C")]
		public enum BokehDestination
		{
			[Token(Token = "0x40001BB")]
			Background = 1,
			[Token(Token = "0x40001BC")]
			Foreground,
			[Token(Token = "0x40001BD")]
			BackgroundAndForeground
		}

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x28")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x2C")]
		public DofResolution resolution;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x30")]
		public bool simpleTweakMode;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x34")]
		public float focalPoint;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x38")]
		public float smoothness;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x3C")]
		public float focalZDistance;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x40")]
		public float focalZStartCurve;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x44")]
		public float focalZEndCurve;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x48")]
		private float focalStartCurve;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x4C")]
		private float focalEndCurve;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x50")]
		private float focalDistance01;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x58")]
		public Transform objectFocus;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x60")]
		public float focalSize;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x64")]
		public DofBlurriness bluriness;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x68")]
		public float maxBlurSpread;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x6C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x70")]
		public Shader dofBlurShader;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x78")]
		private Material dofBlurMaterial;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x80")]
		public Shader dofShader;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x88")]
		private Material dofMaterial;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x90")]
		public bool visualize;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x94")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x98")]
		private float widthOverHeight;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x9C")]
		private float oneOverBaseSize;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0xA0")]
		public bool bokeh;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0xA1")]
		public bool bokehSupport;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0xA8")]
		public Shader bokehShader;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0xB0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0xB8")]
		public float bokehScale;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0xBC")]
		public float bokehIntensity;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0xC0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0xC4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0xC8")]
		public int bokehDownsample;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0xD0")]
		private Material bokehMaterial;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0xD8")]
		private Camera _camera;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0xE0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0xE8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0xF0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0xF8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x100")]
		private RenderTexture bokehSource;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x108")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x7A0308", Offset = "0x7A0308", VA = "0x7A0308")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x7A0414", Offset = "0x7A0414", VA = "0x7A0414", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x7A0550", Offset = "0x7A0550", VA = "0x7A0550")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x7A0558", Offset = "0x7A0558", VA = "0x7A0558")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x7A05D8", Offset = "0x7A05D8", VA = "0x7A05D8")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x7A06C4", Offset = "0x7A06C4", VA = "0x7A06C4")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x7A06E8", Offset = "0x7A06E8", VA = "0x7A06E8")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x7A070C", Offset = "0x7A070C", VA = "0x7A070C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x7A1478", Offset = "0x7A1478", VA = "0x7A1478")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x7A1A2C", Offset = "0x7A1A2C", VA = "0x7A1A2C")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x7A1DA0", Offset = "0x7A1DA0", VA = "0x7A1DA0")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x7A1350", Offset = "0x7A1350", VA = "0x7A1350")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x7A1658", Offset = "0x7A1658", VA = "0x7A1658")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x7A1C38", Offset = "0x7A1C38", VA = "0x7A1C38")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x7A0FA0", Offset = "0x7A0FA0", VA = "0x7A0FA0")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x7A1F40", Offset = "0x7A1F40", VA = "0x7A1F40")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AddComponentMenu("Image Effects/Edge Detection/Edge Detection")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x200002E")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x40001CA")]
			TriangleDepthNormals,
			[Token(Token = "0x40001CB")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x40001CC")]
			SobelDepth,
			[Token(Token = "0x40001CD")]
			SobelDepthThin,
			[Token(Token = "0x40001CE")]
			TriangleLuminance
		}

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x28")]
		public EdgeDetectMode mode;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x2C")]
		public float sensitivityDepth;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x30")]
		public float sensitivityNormals;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x34")]
		public float lumThreshold;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x38")]
		public float edgeExp;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x3C")]
		public float sampleDist;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x40")]
		public float edgesOnly;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x44")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x58")]
		public Shader edgeDetectShader;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x60")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x68")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x7A2008", Offset = "0x7A2008", VA = "0x7A2008", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x7A2758", Offset = "0x7A2758", VA = "0x7A2758")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x7A25F0", Offset = "0x7A25F0", VA = "0x7A25F0")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x7A2764", Offset = "0x7A2764", VA = "0x7A2764")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x7A2768", Offset = "0x7A2768", VA = "0x7A2768")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x7A293C", Offset = "0x7A293C", VA = "0x7A293C")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Fade")]
	public class Fade : ImageEffectBase
	{
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Range(0f, 1f)]
		private float percent;

		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int Percent;

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x7A29FC", Offset = "0x7A29FC", VA = "0x7A29FC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x7A2BA8", Offset = "0x7A2BA8", VA = "0x7A2BA8")]
		public void SetVisibility(float percent)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x7A2BC4", Offset = "0x7A2BC4", VA = "0x7A2BC4")]
		public Fade()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AddComponentMenu("Image Effects/Displacement/Fisheye")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1.5f)]
		public float strengthX;

		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1.5f)]
		public float strengthY;

		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x7A2C3C", Offset = "0x7A2C3C", VA = "0x7A2C3C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x7A2CA4", Offset = "0x7A2CA4", VA = "0x7A2CA4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x7A2DD8", Offset = "0x7A2DD8", VA = "0x7A2DD8")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AddComponentMenu("Image Effects/Rendering/Global Fog")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Apply distance-based fog?")]
		public bool distanceFog;

		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x29")]
		[Tooltip("Exclude far plane pixels from distance-based fog? (Skybox or clear color)")]
		public bool excludeFarPixels;

		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x2A")]
		[Tooltip("Distance fog is based on radial distance from camera when checked")]
		public bool useRadialDistance;

		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x2B")]
		[Tooltip("Apply height-based fog?")]
		public bool heightFog;

		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Fog top Y coordinate")]
		public float height;

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x30")]
		[Range(0.001f, 10f)]
		public float heightDensity;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Push fog away from the camera by this amount")]
		public float startDistance;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x40")]
		private Material fogMaterial;

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x7A2DEC", Offset = "0x7A2DEC", VA = "0x7A2DEC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x7A2E54", Offset = "0x7A2E54", VA = "0x7A2E54")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x7A378C", Offset = "0x7A378C", VA = "0x7A378C")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x7A38EC", Offset = "0x7A38EC", VA = "0x7A38EC")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
	[ExecuteInEditMode]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x30")]
		[Range(-1f, 1f)]
		public float rampOffset;

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x7A390C", Offset = "0x7A390C", VA = "0x7A390C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x7A39F0", Offset = "0x7A39F0", VA = "0x7A39F0")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AddComponentMenu("")]
	[RequireComponent(typeof(Camera))]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x1700000A")]
		protected Material material
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x7A2AD4", Offset = "0x7A2AD4", VA = "0x7A2AD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x7A39F8", Offset = "0x7A39F8", VA = "0x7A39F8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x7A3A98", Offset = "0x7A3A98", VA = "0x7A3A98", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x7A2BCC", Offset = "0x7A2BCC", VA = "0x7A2BCC")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AddComponentMenu("")]
	public class ImageEffects
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x7A3B24", Offset = "0x7A3B24", VA = "0x7A3B24")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x7A3D94", Offset = "0x7A3D94", VA = "0x7A3D94")]
		[Obsolete("Use Graphics.Blit(source,dest) instead")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x7A3DFC", Offset = "0x7A3DFC", VA = "0x7A3DFC")]
		[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x7A3E6C", Offset = "0x7A3E6C", VA = "0x7A3E6C")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Blur/Motion Blur (Color Accumulation)")]
	[ExecuteInEditMode]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 0.92f)]
		public float blurAmount;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x7A3E74", Offset = "0x7A3E74", VA = "0x7A3E74", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x7A3EA8", Offset = "0x7A3EA8", VA = "0x7A3EA8", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x7A3F0C", Offset = "0x7A3F0C", VA = "0x7A3F0C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x7A4274", Offset = "0x7A4274", VA = "0x7A4274")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AddComponentMenu("Image Effects/Noise/Noise And Grain (Filmic)")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x28")]
		public float intensityMultiplier;

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x2C")]
		public float generalIntensity;

		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x30")]
		public float blackIntensity;

		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x34")]
		public float whiteIntensity;

		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x38")]
		public float midGrey;

		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x3C")]
		public bool dx11Grain;

		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x40")]
		public float softness;

		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x44")]
		public bool monochrome;

		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 intensities;

		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 tiling;

		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x60")]
		public float monochromeTiling;

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x64")]
		public FilterMode filterMode;

		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x68")]
		public Texture2D noiseTexture;

		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x70")]
		public Shader noiseShader;

		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x78")]
		private Material noiseMaterial;

		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x80")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x88")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x90")]
		private Mesh mesh;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x7A4288", Offset = "0x7A4288", VA = "0x7A4288")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x7A42F0", Offset = "0x7A42F0", VA = "0x7A42F0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x7A438C", Offset = "0x7A438C", VA = "0x7A438C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x7A4BA4", Offset = "0x7A4BA4", VA = "0x7A4BA4")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, Mesh mesh, int passNr)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x7A4E48", Offset = "0x7A4E48", VA = "0x7A4E48")]
		private static void BuildMesh(Mesh mesh, RenderTexture source, Texture2D noise)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x7A5288", Offset = "0x7A5288", VA = "0x7A5288")]
		private static void BuildMeshUV0(Mesh mesh, int width, int height, float noiseSize, int noiseWidth)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x7A5404", Offset = "0x7A5404", VA = "0x7A5404")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AddComponentMenu("Image Effects/Noise/Noise and Scratches")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 5f)]
		public float grainIntensityMin;

		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 5f)]
		public float grainIntensityMax;

		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x24")]
		[Range(0.1f, 50f)]
		public float grainSize;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 5f)]
		public float scratchIntensityMin;

		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 5f)]
		public float scratchIntensityMax;

		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x30")]
		[Range(1f, 30f)]
		public float scratchFPS;

		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float scratchJitter;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x1700000B")]
		protected Material material
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x7A55B8", Offset = "0x7A55B8", VA = "0x7A55B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x7A548C", Offset = "0x7A548C", VA = "0x7A548C")]
		protected void Start()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x7A5720", Offset = "0x7A5720", VA = "0x7A5720")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x7A57F0", Offset = "0x7A57F0", VA = "0x7A57F0")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x7A5894", Offset = "0x7A5894", VA = "0x7A5894")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x7A5BBC", Offset = "0x7A5BBC", VA = "0x7A5BBC")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x7A2194", Offset = "0x7A2194", VA = "0x7A2194")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x7A5C10", Offset = "0x7A5C10", VA = "0x7A5C10")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x7A5E48", Offset = "0x7A5E48", VA = "0x7A5E48")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x7A5E54", Offset = "0x7A5E54", VA = "0x7A5E54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x7A5E58", Offset = "0x7A5E58", VA = "0x7A5E58")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x7A5F38", Offset = "0x7A5F38", VA = "0x7A5F38")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x7A5F40", Offset = "0x7A5F40", VA = "0x7A5F40", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x7A6000", Offset = "0x7A6000", VA = "0x7A6000")]
		protected void Start()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x7A2090", Offset = "0x7A2090", VA = "0x7A2090")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x7A600C", Offset = "0x7A600C", VA = "0x7A600C")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x7A6064", Offset = "0x7A6064", VA = "0x7A6064")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x7A26A0", Offset = "0x7A26A0", VA = "0x7A26A0")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x7A606C", Offset = "0x7A606C", VA = "0x7A606C")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x7A5BF0", Offset = "0x7A5BF0", VA = "0x7A5BF0")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x7A62F0", Offset = "0x7A62F0", VA = "0x7A62F0")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x7A2968", Offset = "0x7A2968", VA = "0x7A2968")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x7A6668", Offset = "0x7A6668", VA = "0x7A6668")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x7A66D0", Offset = "0x7A66D0", VA = "0x7A66D0")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x7A691C", Offset = "0x7A691C", VA = "0x7A691C")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x7A6C90", Offset = "0x7A6C90", VA = "0x7A6C90")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x7A6E34", Offset = "0x7A6E34", VA = "0x7A6E34")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x200003A")]
	internal class Quads
	{
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x7A6E3C", Offset = "0x7A6E3C", VA = "0x7A6E3C")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x7A6F0C", Offset = "0x7A6F0C", VA = "0x7A6F0C")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x7A7070", Offset = "0x7A7070", VA = "0x7A7070")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x7A72A8", Offset = "0x7A72A8", VA = "0x7A72A8")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x7A762C", Offset = "0x7A762C", VA = "0x7A762C")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Screen Overlay")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x200003C")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x4000216")]
			Additive,
			[Token(Token = "0x4000217")]
			ScreenBlend,
			[Token(Token = "0x4000218")]
			Multiply,
			[Token(Token = "0x4000219")]
			Overlay,
			[Token(Token = "0x400021A")]
			AlphaBlend
		}

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x28")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x7A7634", Offset = "0x7A7634", VA = "0x7A7634", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x7A769C", Offset = "0x7A769C", VA = "0x7A769C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x7A77EC", Offset = "0x7A77EC", VA = "0x7A77EC")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 3f)]
		public float intensity;

		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0.1f, 3f)]
		public float radius;

		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 3f)]
		public int blurIterations;

		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 5f)]
		public float blurFilterDistance;

		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public int downsample;

		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x40")]
		public Texture2D rand;

		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x48")]
		public Shader aoShader;

		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x50")]
		private Material aoMaterial;

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x7A77FC", Offset = "0x7A77FC", VA = "0x7A77FC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x7A7864", Offset = "0x7A7864", VA = "0x7A7864")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x7A78F4", Offset = "0x7A78F4", VA = "0x7A78F4")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x7A80A8", Offset = "0x7A80A8", VA = "0x7A80A8")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Occlusion")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x200003F")]
		public enum SSAOSamples
		{
			[Token(Token = "0x400022F")]
			Low,
			[Token(Token = "0x4000230")]
			Medium,
			[Token(Token = "0x4000231")]
			High
		}

		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x18")]
		[Range(0.05f, 1f)]
		public float m_Radius;

		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x20")]
		[Range(0.5f, 4f)]
		public float m_OcclusionIntensity;

		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 4f)]
		public int m_Blur;

		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x28")]
		[Range(1f, 6f)]
		public int m_Downsampling;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0.2f, 2f)]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x30")]
		[Range(1E-05f, 0.5f)]
		public float m_MinZ;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x7A80C4", Offset = "0x7A80C4", VA = "0x7A80C4")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x7A8170", Offset = "0x7A8170", VA = "0x7A8170")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x7A81F4", Offset = "0x7A81F4", VA = "0x7A81F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x7A81FC", Offset = "0x7A81FC", VA = "0x7A81FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x7A839C", Offset = "0x7A839C", VA = "0x7A839C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x7A82C4", Offset = "0x7A82C4", VA = "0x7A82C4")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x7A8408", Offset = "0x7A8408", VA = "0x7A8408")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x7A89DC", Offset = "0x7A89DC", VA = "0x7A89DC")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Sepia Tone")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x7A8A10", Offset = "0x7A8A10", VA = "0x7A8A10")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x7A8A90", Offset = "0x7A8A90", VA = "0x7A8A90")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x2000042")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x4000241")]
			Low,
			[Token(Token = "0x4000242")]
			Normal,
			[Token(Token = "0x4000243")]
			High
		}

		[Token(Token = "0x2000043")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x4000245")]
			Screen,
			[Token(Token = "0x4000246")]
			Add
		}

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x28")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x2C")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x64")]
		public float maxRadius;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x7A8A98", Offset = "0x7A8A98", VA = "0x7A8A98", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x7A8B24", Offset = "0x7A8B24", VA = "0x7A8B24")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x7A91E0", Offset = "0x7A91E0", VA = "0x7A91E0")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x2000045")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x400024F")]
			TiltShiftMode,
			[Token(Token = "0x4000250")]
			IrisMode
		}

		[Token(Token = "0x2000046")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x4000252")]
			Preview,
			[Token(Token = "0x4000253")]
			Normal,
			[Token(Token = "0x4000254")]
			High
		}

		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x28")]
		public TiltShiftMode mode;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x2C")]
		public TiltShiftQuality quality;

		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 15f)]
		public float blurArea;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 25f)]
		public float maxBlurSize;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public int downsample;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x7A9224", Offset = "0x7A9224", VA = "0x7A9224", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x7A928C", Offset = "0x7A928C", VA = "0x7A928C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x7A951C", Offset = "0x7A951C", VA = "0x7A951C")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Color Adjustments/Tonemapping")]
	[ImageEffectAllowedInSceneView]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x2000048")]
		public enum TonemapperType
		{
			[Token(Token = "0x4000263")]
			SimpleReinhard,
			[Token(Token = "0x4000264")]
			UserCurve,
			[Token(Token = "0x4000265")]
			Hable,
			[Token(Token = "0x4000266")]
			Photographic,
			[Token(Token = "0x4000267")]
			OptimizedHejiDawson,
			[Token(Token = "0x4000268")]
			AdaptiveReinhard,
			[Token(Token = "0x4000269")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x2000049")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x400026B")]
			Square16 = 0x10,
			[Token(Token = "0x400026C")]
			Square32 = 0x20,
			[Token(Token = "0x400026D")]
			Square64 = 0x40,
			[Token(Token = "0x400026E")]
			Square128 = 0x80,
			[Token(Token = "0x400026F")]
			Square256 = 0x100,
			[Token(Token = "0x4000270")]
			Square512 = 0x200,
			[Token(Token = "0x4000271")]
			Square1024 = 0x400
		}

		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x28")]
		public TonemapperType type;

		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x2C")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x38")]
		private Texture2D curveTex;

		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x40")]
		public float exposureAdjustment;

		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x44")]
		public float middleGrey;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x48")]
		public float white;

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x4C")]
		public float adaptionSpeed;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x50")]
		public Shader tonemapper;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x58")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x60")]
		private Material tonemapMaterial;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x68")]
		private RenderTexture rt;

		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x70")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x7A9534", Offset = "0x7A9534", VA = "0x7A9534", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x7A9698", Offset = "0x7A9698", VA = "0x7A9698")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x7A9918", Offset = "0x7A9918", VA = "0x7A9918")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x7A9A70", Offset = "0x7A9A70", VA = "0x7A9A70")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x7A9B70", Offset = "0x7A9B70", VA = "0x7A9B70")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x7AA310", Offset = "0x7AA310", VA = "0x7AA310")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x200004A")]
	internal class Triangles
	{
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x7AA33C", Offset = "0x7AA33C", VA = "0x7AA33C")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x7AA410", Offset = "0x7AA410", VA = "0x7AA410")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x7AA574", Offset = "0x7AA574", VA = "0x7AA574")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x7AA7AC", Offset = "0x7AA7AC", VA = "0x7AA7AC")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x7AAAA0", Offset = "0x7AAAA0", VA = "0x7AAAA0")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AddComponentMenu("Image Effects/Displacement/Twirl")]
	[ExecuteInEditMode]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 360f)]
		public float angle;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x7AAAA8", Offset = "0x7AAAA8", VA = "0x7AAAA8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x7AAAE0", Offset = "0x7AAAE0", VA = "0x7AAAE0")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
	[RequireComponent(typeof(Camera))]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x200004D")]
		public enum AberrationMode
		{
			[Token(Token = "0x4000286")]
			Simple,
			[Token(Token = "0x4000287")]
			Advanced
		}

		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x28")]
		public AberrationMode mode;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x34")]
		public float axialAberration;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x38")]
		public float blur;

		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x44")]
		public float blurDistance;

		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x7AAB08", Offset = "0x7AAB08", VA = "0x7AAB08", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x7AABB8", Offset = "0x7AABB8", VA = "0x7AABB8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x7AB10C", Offset = "0x7AB10C", VA = "0x7AB10C")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Vortex")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x7AB138", Offset = "0x7AB138", VA = "0x7AB138")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x7AB170", Offset = "0x7AB170", VA = "0x7AB170")]
		public Vortex()
		{
		}
	}
}
namespace ArabicSupport
{
	[Token(Token = "0x200004F")]
	public class ArabicFixer
	{
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x7AB198", Offset = "0x7AB198", VA = "0x7AB198")]
		public static string Fix(string str)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x7AB424", Offset = "0x7AB424", VA = "0x7AB424")]
		public static string Fix(string str, bool rtl)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x7AB1A4", Offset = "0x7AB1A4", VA = "0x7AB1A4")]
		public static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x7AB624", Offset = "0x7AB624", VA = "0x7AB624")]
		public ArabicFixer()
		{
		}
	}
}
