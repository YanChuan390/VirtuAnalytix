using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class AppLovin
{
	[Token(Token = "0x4000001")]
	public const float AD_POSITION_CENTER = -10000f;

	[Token(Token = "0x4000002")]
	public const float AD_POSITION_LEFT = -20000f;

	[Token(Token = "0x4000003")]
	public const float AD_POSITION_RIGHT = -30000f;

	[Token(Token = "0x4000004")]
	public const float AD_POSITION_TOP = -40000f;

	[Token(Token = "0x4000005")]
	public const float AD_POSITION_BOTTOM = -50000f;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x10")]
	public AndroidJavaClass applovinFacade;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x18")]
	public AndroidJavaObject currentActivity;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x0")]
	public static AppLovin DefaultPlugin;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x20")]
	public AppLovinTargetingData targetingData;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x13D740C", Offset = "0x13D740C", VA = "0x13D740C")]
	public static AppLovin getDefaultPlugin()
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x13D7534", Offset = "0x13D7534", VA = "0x13D7534")]
	public AppLovin(AndroidJavaObject activity)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x13D76E4", Offset = "0x13D76E4", VA = "0x13D76E4")]
	public AppLovin()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x13D77EC", Offset = "0x13D77EC", VA = "0x13D77EC")]
	public AppLovinTargetingData getTargetingData()
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x13D77F4", Offset = "0x13D77F4", VA = "0x13D77F4")]
	public void initializeSdk()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x13D78BC", Offset = "0x13D78BC", VA = "0x13D78BC")]
	public void showAd()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x13D7984", Offset = "0x13D7984", VA = "0x13D7984")]
	public void showInterstitial()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x13D7A4C", Offset = "0x13D7A4C", VA = "0x13D7A4C")]
	public void hideAd()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x13D7B14", Offset = "0x13D7B14", VA = "0x13D7B14")]
	public void setAdPosition(float x, float y)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x13D7C78", Offset = "0x13D7C78", VA = "0x13D7C78")]
	public void setAdWidth(int width)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x13D7D94", Offset = "0x13D7D94", VA = "0x13D7D94")]
	public void setVerboseLoggingOn(string sdkKey)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x13D7E64", Offset = "0x13D7E64", VA = "0x13D7E64")]
	public void setSdkKey(string sdkKey)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x13D7F58", Offset = "0x13D7F58", VA = "0x13D7F58")]
	public void preloadInterstitial()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x13D8020", Offset = "0x13D8020", VA = "0x13D8020")]
	public bool hasPreloadedInterstitial()
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x13D8124", Offset = "0x13D8124", VA = "0x13D8124")]
	public bool isInterstitialShowing()
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x13D8228", Offset = "0x13D8228", VA = "0x13D8228")]
	public void setAdListener(string gameObjectToNotify)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x13D82F0", Offset = "0x13D82F0", VA = "0x13D82F0")]
	public void setRewardedVideoUsername(string username)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x13D83E4", Offset = "0x13D83E4", VA = "0x13D83E4")]
	public void loadIncentInterstitial()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x13D84AC", Offset = "0x13D84AC", VA = "0x13D84AC")]
	public void showIncentInterstitial()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x13D8574", Offset = "0x13D8574", VA = "0x13D8574")]
	public bool isIncentInterstitialReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x13D8678", Offset = "0x13D8678", VA = "0x13D8678")]
	public bool isPreloadedInterstitialVideo()
	{
		return default(bool);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x13D877C", Offset = "0x13D877C", VA = "0x13D877C")]
	public static void ShowAd()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x13D87E4", Offset = "0x13D87E4", VA = "0x13D87E4")]
	public static void ShowAd(float x, float y)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x13D88DC", Offset = "0x13D88DC", VA = "0x13D88DC")]
	public static void ShowInterstitial()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x13D8944", Offset = "0x13D8944", VA = "0x13D8944")]
	public static void LoadRewardedInterstitial()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x13D89AC", Offset = "0x13D89AC", VA = "0x13D89AC")]
	public static void ShowRewardedInterstitial()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x13D8A14", Offset = "0x13D8A14", VA = "0x13D8A14")]
	public static void HideAd()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x13D885C", Offset = "0x13D885C", VA = "0x13D885C")]
	public static void SetAdPosition(float x, float y)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x13D8A7C", Offset = "0x13D8A7C", VA = "0x13D8A7C")]
	public static void SetAdWidth(int width)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x13D8AEC", Offset = "0x13D8AEC", VA = "0x13D8AEC")]
	public static void SetSdkKey(string sdkKey)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x13D8B5C", Offset = "0x13D8B5C", VA = "0x13D8B5C")]
	public static void SetVerboseLoggingOn(string verboseLogging)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x13D8BC4", Offset = "0x13D8BC4", VA = "0x13D8BC4")]
	public static AppLovinTargetingData GetTargetingData()
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x13D8C30", Offset = "0x13D8C30", VA = "0x13D8C30")]
	public static void PreloadInterstitial()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x13D8C98", Offset = "0x13D8C98", VA = "0x13D8C98")]
	public static bool HasPreloadedInterstitial()
	{
		return default(bool);
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x13D8D00", Offset = "0x13D8D00", VA = "0x13D8D00")]
	public static bool IsInterstitialShowing()
	{
		return default(bool);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x13D8D68", Offset = "0x13D8D68", VA = "0x13D8D68")]
	public static bool IsIncentInterstitialReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x13D8DD0", Offset = "0x13D8DD0", VA = "0x13D8DD0")]
	public static bool IsPreloadedInterstitialVideo()
	{
		return default(bool);
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x13D8E38", Offset = "0x13D8E38", VA = "0x13D8E38")]
	public static void InitializeSdk()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x13D8EA0", Offset = "0x13D8EA0", VA = "0x13D8EA0")]
	public static void SetUnityAdListener(string gameObjectToNotify)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x13D8F10", Offset = "0x13D8F10", VA = "0x13D8F10")]
	public static void SetRewardedVideoUsername(string username)
	{
	}
}
[Token(Token = "0x2000003")]
public class AppLovinTargetingData
{
	[Token(Token = "0x400000A")]
	public const string GENDER_MALE = "m";

	[Token(Token = "0x400000B")]
	public const string GENDER_FEMALE = "f";

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x10")]
	public AndroidJavaObject currentActivity;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x18")]
	public AndroidJavaClass applovinFacade;

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x13D7778", Offset = "0x13D7778", VA = "0x13D7778")]
	public AppLovinTargetingData()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x13D761C", Offset = "0x13D761C", VA = "0x13D761C")]
	public AppLovinTargetingData(AndroidJavaObject activity)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x13D8F84", Offset = "0x13D8F84", VA = "0x13D8F84")]
	public void setGender(string gender)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x13D9078", Offset = "0x13D9078", VA = "0x13D9078")]
	public void setBirthYear(int birthYear)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x13D9194", Offset = "0x13D9194", VA = "0x13D9194")]
	public void setLanguage(string language)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x13D9288", Offset = "0x13D9288", VA = "0x13D9288")]
	public void setCountry(string country)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x13D937C", Offset = "0x13D937C", VA = "0x13D937C")]
	public void setCarrier(string carrier)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x13D9470", Offset = "0x13D9470", VA = "0x13D9470")]
	public void setInterests(params string[] interests)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x13D9564", Offset = "0x13D9564", VA = "0x13D9564")]
	public void setKeywords(params string[] keywords)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x13D9658", Offset = "0x13D9658", VA = "0x13D9658")]
	public void putExtra(string key, string val)
	{
	}
}
[Token(Token = "0x2000004")]
public class GooglePlayDownloader
{
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x0")]
	private static AndroidJavaClass detectAndroidJNI;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x8")]
	private static AndroidJavaClass Environment;

	[Token(Token = "0x4000010")]
	private const string Environment_MEDIA_MOUNTED = "mounted";

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x10")]
	private static string obb_package;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x18")]
	private static int obb_version;

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x13DB998", Offset = "0x13DB998", VA = "0x13DB998")]
	public static bool RunningOnAndroid()
	{
		return default(bool);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x13DBAAC", Offset = "0x13DBAAC", VA = "0x13DBAAC")]
	static GooglePlayDownloader()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x13DBC74", Offset = "0x13DBC74", VA = "0x13DBC74")]
	public static string GetExpansionFilePath()
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x13DC474", Offset = "0x13DC474", VA = "0x13DC474")]
	public static string GetMainOBBPath(string expansionFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x13DC568", Offset = "0x13DC568", VA = "0x13DC568")]
	public static string GetPatchOBBPath(string expansionFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x13DC65C", Offset = "0x13DC65C", VA = "0x13DC65C")]
	public static void FetchOBB()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x13DC03C", Offset = "0x13DC03C", VA = "0x13DC03C")]
	private static void populateOBBData()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x13DCC68", Offset = "0x13DCC68", VA = "0x13DCC68")]
	public GooglePlayDownloader()
	{
	}
}
[Token(Token = "0x2000005")]
public class OpenClikManager : MonoBehaviour
{
	[Token(Token = "0x2000015")]
	public enum AdType
	{
		[Token(Token = "0x400005D")]
		bannerBottom,
		[Token(Token = "0x400005E")]
		interstitial,
		[Token(Token = "0x400005F")]
		bannerTop,
		[Token(Token = "0x4000060")]
		iconTopLeft,
		[Token(Token = "0x4000061")]
		iconTopRight,
		[Token(Token = "0x4000062")]
		iconBottomLeft,
		[Token(Token = "0x4000063")]
		iconBottomRight
	}

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x18")]
	public string _appKey;

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x13DDEB8", Offset = "0x13DDEB8", VA = "0x13DDEB8")]
	public OpenClikManager()
	{
	}
}
[Token(Token = "0x2000006")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x6BFF3C", Offset = "0x6BFF3C")]
public class BlurEffect : MonoBehaviour
{
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x18")]
	public int iterations;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x1C")]
	public float blurSpread;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x20")]
	public Shader blurShader;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x0")]
	private static Material m_Material;

	[Token(Token = "0x17000001")]
	protected Material material
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x13D9780", Offset = "0x13D9780", VA = "0x13D9780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x13D98B8", Offset = "0x13D98B8", VA = "0x13D98B8")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x13D99B4", Offset = "0x13D99B4", VA = "0x13D99B4")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x13D9A74", Offset = "0x13D9A74", VA = "0x13D9A74")]
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x13D9C18", Offset = "0x13D9C18", VA = "0x13D9C18")]
	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x13D9D90", Offset = "0x13D9D90", VA = "0x13D9D90")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x13D9F78", Offset = "0x13D9F78", VA = "0x13D9F78")]
	public BlurEffect()
	{
	}
}
[Token(Token = "0x2000007")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x6BFF88", Offset = "0x6BFF88")]
public class ColorCorrectionEffect : ImageEffectBase
{
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x28")]
	public Texture textureRamp;

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x13D9F94", Offset = "0x13D9F94", VA = "0x13D9F94")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x13DA110", Offset = "0x13DA110", VA = "0x13DA110")]
	public ColorCorrectionEffect()
	{
	}
}
[Token(Token = "0x2000008")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x6BFFD4", Offset = "0x6BFFD4")]
public class ContrastStretchEffect : MonoBehaviour
{
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x18")]
	public float adaptationSpeed;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x1C")]
	public float limitMinimum;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x20")]
	public float limitMaximum;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x28")]
	private RenderTexture[] adaptRenderTex;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x30")]
	private int curAdaptIndex;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x38")]
	public Shader shaderLum;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x40")]
	private Material m_materialLum;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x48")]
	public Shader shaderReduce;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x50")]
	private Material m_materialReduce;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x58")]
	public Shader shaderAdapt;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x60")]
	private Material m_materialAdapt;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x68")]
	public Shader shaderApply;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x70")]
	private Material m_materialApply;

	[Token(Token = "0x17000002")]
	protected Material materialLum
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x13DA120", Offset = "0x13DA120", VA = "0x13DA120")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	protected Material materialReduce
	{
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x13DA1E4", Offset = "0x13DA1E4", VA = "0x13DA1E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	protected Material materialAdapt
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x13DA2A8", Offset = "0x13DA2A8", VA = "0x13DA2A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	protected Material materialApply
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x13DA36C", Offset = "0x13DA36C", VA = "0x13DA36C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x13DA430", Offset = "0x13DA430", VA = "0x13DA430")]
	private void Start()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x13DA4C4", Offset = "0x13DA4C4", VA = "0x13DA4C4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x13DA614", Offset = "0x13DA614", VA = "0x13DA614")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x13DA83C", Offset = "0x13DA83C", VA = "0x13DA83C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x13DAA98", Offset = "0x13DAA98", VA = "0x13DAA98")]
	private void CalculateAdaptation(Texture curTexture)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x13DAC70", Offset = "0x13DAC70", VA = "0x13DAC70")]
	public ContrastStretchEffect()
	{
	}
}
[Token(Token = "0x2000009")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x6C0020", Offset = "0x6C0020")]
public class EdgeDetectEffect : ImageEffectBase
{
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x28")]
	public float threshold;

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x13DACE8", Offset = "0x13DACE8", VA = "0x13DACE8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x13DADA4", Offset = "0x13DADA4", VA = "0x13DADA4")]
	public EdgeDetectEffect()
	{
	}
}
[Token(Token = "0x200000A")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0x6C006C", Offset = "0x6C006C")]
[Attribute(Name = "AddComponentMenu", RVA = "0x6C006C", Offset = "0x6C006C")]
public class GlowEffect : MonoBehaviour
{
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x18")]
	public float glowIntensity;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x1C")]
	public int blurIterations;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x20")]
	public float blurSpread;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x24")]
	public Color glowTint;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x38")]
	public Shader compositeShader;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x40")]
	private Material m_CompositeMaterial;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x48")]
	public Shader blurShader;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x50")]
	private Material m_BlurMaterial;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x58")]
	public Shader downsampleShader;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x60")]
	private Material m_DownsampleMaterial;

	[Token(Token = "0x17000006")]
	protected Material compositeMaterial
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x13DADB8", Offset = "0x13DADB8", VA = "0x13DADB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000007")]
	protected Material blurMaterial
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x13DAE7C", Offset = "0x13DAE7C", VA = "0x13DAE7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000008")]
	protected Material downsampleMaterial
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x13DAF40", Offset = "0x13DAF40", VA = "0x13DAF40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x13DB004", Offset = "0x13DB004", VA = "0x13DB004")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x13DB15C", Offset = "0x13DB15C", VA = "0x13DB15C")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x13DB2C0", Offset = "0x13DB2C0", VA = "0x13DB2C0")]
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x13DB464", Offset = "0x13DB464", VA = "0x13DB464")]
	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x13DB548", Offset = "0x13DB548", VA = "0x13DB548")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x13DB808", Offset = "0x13DB808", VA = "0x13DB808")]
	public void BlitGlow(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x13DB928", Offset = "0x13DB928", VA = "0x13DB928")]
	public GlowEffect()
	{
	}
}
[Token(Token = "0x200000B")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x6C0104", Offset = "0x6C0104")]
public class GrayscaleEffect : ImageEffectBase
{
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x28")]
	public Texture textureRamp;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x30")]
	public float rampOffset;

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x13DCC70", Offset = "0x13DCC70", VA = "0x13DCC70")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x13DCD4C", Offset = "0x13DCD4C", VA = "0x13DCD4C")]
	public GrayscaleEffect()
	{
	}
}
[Token(Token = "0x200000C")]
[Attribute(Name = "RequireComponent", RVA = "0x6C0150", Offset = "0x6C0150")]
[Attribute(Name = "AddComponentMenu", RVA = "0x6C0150", Offset = "0x6C0150")]
public class ImageEffectBase : MonoBehaviour
{
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x18")]
	public Shader shader;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x20")]
	private Material m_Material;

	[Token(Token = "0x17000009")]
	protected Material material
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x13DA04C", Offset = "0x13DA04C", VA = "0x13DA04C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x13DCD54", Offset = "0x13DCD54", VA = "0x13DCD54", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x13DCE04", Offset = "0x13DCE04", VA = "0x13DCE04", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x13DA118", Offset = "0x13DA118", VA = "0x13DA118")]
	public ImageEffectBase()
	{
	}
}
[Token(Token = "0x200000D")]
[Attribute(Name = "AddComponentMenu", RVA = "0x6C01D8", Offset = "0x6C01D8")]
public class ImageEffects
{
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x13DCEB4", Offset = "0x13DCEB4", VA = "0x13DCEB4")]
	public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x13DD130", Offset = "0x13DD130", VA = "0x13DD130")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x6C04CC", Offset = "0x6C04CC")]
	public static void Blit(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x13DD1A8", Offset = "0x13DD1A8", VA = "0x13DD1A8")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x6C0504", Offset = "0x6C0504")]
	public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x13DD228", Offset = "0x13DD228", VA = "0x13DD228")]
	public ImageEffects()
	{
	}
}
[Token(Token = "0x200000E")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x6C0210", Offset = "0x6C0210")]
[Attribute(Name = "RequireComponent", RVA = "0x6C0210", Offset = "0x6C0210")]
public class MotionBlur : ImageEffectBase
{
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x28")]
	public float blurAmount;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x2C")]
	public bool extraBlur;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture accumTexture;

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x13DD230", Offset = "0x13DD230", VA = "0x13DD230", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x13DD274", Offset = "0x13DD274", VA = "0x13DD274", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x13DD2E8", Offset = "0x13DD2E8", VA = "0x13DD2E8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x13DD64C", Offset = "0x13DD64C", VA = "0x13DD64C")]
	public MotionBlur()
	{
	}
}
[Token(Token = "0x200000F")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0x6C02A8", Offset = "0x6C02A8")]
[Attribute(Name = "AddComponentMenu", RVA = "0x6C02A8", Offset = "0x6C02A8")]
public class NoiseEffect : MonoBehaviour
{
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x18")]
	public bool monochrome;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x19")]
	private bool rgbFallback;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x1C")]
	public float grainIntensityMin;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x20")]
	public float grainIntensityMax;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x24")]
	public float grainSize;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x28")]
	public float scratchIntensityMin;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x2C")]
	public float scratchIntensityMax;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x30")]
	public float scratchFPS;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x34")]
	public float scratchJitter;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x38")]
	public Texture grainTexture;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x40")]
	public Texture scratchTexture;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x48")]
	public Shader shaderRGB;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x50")]
	public Shader shaderYUV;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x58")]
	private Material m_MaterialRGB;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x60")]
	private Material m_MaterialYUV;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x68")]
	private float scratchTimeLeft;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x6C")]
	private float scratchX;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x70")]
	private float scratchY;

	[Token(Token = "0x1700000A")]
	protected Material material
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x13DD7A0", Offset = "0x13DD7A0", VA = "0x13DD7A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x13DD660", Offset = "0x13DD660", VA = "0x13DD660")]
	protected void Start()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x13DD8FC", Offset = "0x13DD8FC", VA = "0x13DD8FC")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x13DDA00", Offset = "0x13DDA00", VA = "0x13DDA00")]
	private void SanitizeParameters()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x13DDB3C", Offset = "0x13DDB3C", VA = "0x13DDB3C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x13DDE84", Offset = "0x13DDE84", VA = "0x13DDE84")]
	public NoiseEffect()
	{
	}
}
[Token(Token = "0x2000010")]
[ExecuteInEditMode]
[Attribute(Name = "RequireComponent", RVA = "0x6C0340", Offset = "0x6C0340")]
[Attribute(Name = "AddComponentMenu", RVA = "0x6C0340", Offset = "0x6C0340")]
public class SSAOEffect : MonoBehaviour
{
	[Token(Token = "0x2000016")]
	public enum SSAOSamples
	{
		[Token(Token = "0x4000065")]
		Low,
		[Token(Token = "0x4000066")]
		Medium,
		[Token(Token = "0x4000067")]
		High
	}

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x18")]
	public float m_Radius;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x1C")]
	public SSAOSamples m_SampleCount;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x20")]
	public float m_OcclusionIntensity;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x24")]
	public int m_Blur;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x28")]
	public int m_Downsampling;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x2C")]
	public float m_OcclusionAttenuation;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x30")]
	public float m_MinZ;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x38")]
	public Shader m_SSAOShader;

	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x40")]
	private Material m_SSAOMaterial;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x48")]
	public Texture2D m_RandomTexture;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x50")]
	private bool m_Supported;

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x13DDEC0", Offset = "0x13DDEC0", VA = "0x13DDEC0")]
	private static Material CreateMaterial(Shader shader)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x13DDF70", Offset = "0x13DDF70", VA = "0x13DDF70")]
	private static void DestroyMaterial(Material mat)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x13DE00C", Offset = "0x13DE00C", VA = "0x13DE00C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x13DE014", Offset = "0x13DE014", VA = "0x13DE014")]
	private void Start()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x13DE1A8", Offset = "0x13DE1A8", VA = "0x13DE1A8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x13DE0EC", Offset = "0x13DE0EC", VA = "0x13DE0EC")]
	private void CreateMaterials()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x13DE21C", Offset = "0x13DE21C", VA = "0x13DE21C")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x13DE8D8", Offset = "0x13DE8D8", VA = "0x13DE8D8")]
	public SSAOEffect()
	{
	}
}
[Token(Token = "0x2000011")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x6C03D8", Offset = "0x6C03D8")]
public class SepiaToneEffect : ImageEffectBase
{
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x13DE90C", Offset = "0x13DE90C", VA = "0x13DE90C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x13DE99C", Offset = "0x13DE99C", VA = "0x13DE99C")]
	public SepiaToneEffect()
	{
	}
}
[Token(Token = "0x2000012")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x6C0424", Offset = "0x6C0424")]
public class TwirlEffect : ImageEffectBase
{
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 radius;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x30")]
	public float angle;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 center;

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x13DE9A4", Offset = "0x13DE9A4", VA = "0x13DE9A4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x13DE9E8", Offset = "0x13DE9E8", VA = "0x13DE9E8")]
	public TwirlEffect()
	{
	}
}
[Token(Token = "0x2000013")]
[ExecuteInEditMode]
[Attribute(Name = "AddComponentMenu", RVA = "0x6C0470", Offset = "0x6C0470")]
public class VortexEffect : ImageEffectBase
{
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 radius;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x30")]
	public float angle;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 center;

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x13DEA64", Offset = "0x13DEA64", VA = "0x13DEA64")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x13DEAA8", Offset = "0x13DEAA8", VA = "0x13DEAA8")]
	public VortexEffect()
	{
	}
}
