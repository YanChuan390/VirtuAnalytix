using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace CrazyMinnow.SALSA.OneClicks;

[Token(Token = "0x2000002")]
public class OneClickBase : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	public const string RESOURCE_CLIP = "Assets/Crazy Minnow Studio/Examples/Audio/Promo-male.mp3";

	[Token(Token = "0x4000002")]
	public const string PREFAB_ALERT_TITLE = "Prefab Unpack Warning";

	[Token(Token = "0x4000003")]
	public const string PREFAB_ALERT_MSG = "Your selection is a prefab and must be unpacked to apply this setup. You can create a new prefab once the setup is complete. Do you want to proceed?";

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x0")]
	protected static List<SkinnedMeshRenderer> requiredSmrs;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x8")]
	protected static List<OneClickConfiguration> oneClickConfigurations;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x10")]
	protected static Salsa salsa;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x18")]
	protected static Emoter emoter;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x20")]
	protected static UmaUepProxy uepProxy;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x28")]
	protected static GameObject selectedObject;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x30")]
	protected static float emphasizerTrigger;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x34")]
	protected static bool autoAdjustAnalysis;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x35")]
	protected static bool autoAdjustMicrophone;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x38")]
	protected static float audioUpdateDelay;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x3C")]
	protected static float loCutoff;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x40")]
	protected static float hiCutoff;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x44")]
	protected static bool useAdvDyn;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x48")]
	protected static float advDynPrimaryBias;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x4C")]
	protected static bool useAdvDynJitter;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x50")]
	protected static float advDynJitterAmount;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x54")]
	protected static float advDynJitterProb;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x58")]
	protected static float advDynSecondaryMix;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x5C")]
	protected static float emphasisChance;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x60")]
	protected static bool useRandomEmotes;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x61")]
	protected static bool isChancePerEmote;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x64")]
	protected static int numRandomEmotesPerCycle;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x68")]
	protected static float randomEmoteMinTimer;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x6C")]
	protected static float randomEmoteMaxTimer;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x70")]
	protected static float randomChance;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x74")]
	protected static bool useRandomFrac;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x78")]
	protected static float randomFracBias;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x7C")]
	protected static bool useRandomHoldDuration;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x80")]
	protected static float randomHoldDurationMin;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x84")]
	protected static float randomHoldDurationMax;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x88")]
	protected static LerpEasings.EasingType easingType;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x90")]
	private static OneClickConfiguration currentConfiguration;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xD70C40", Offset = "0xD70C40", VA = "0xD70C40")]
	protected static void NewConfiguration(OneClickConfiguration.ConfigType configType)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xD70EE0", Offset = "0xD70EE0", VA = "0xD70EE0")]
	protected static void AddSmrSearch(string search)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xD70FB8", Offset = "0xD70FB8", VA = "0xD70FB8")]
	protected static void NewExpression(string expressionName)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xD711C8", Offset = "0xD711C8", VA = "0xD711C8")]
	protected static void AddShapeComponent(string[] blendshapeNames, float durOn, float durHold, float durOff, string componentName = "", float amount = 1f, bool useRegex = false)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xD713DC", Offset = "0xD713DC", VA = "0xD713DC")]
	protected static void AddUepPoseComponent(string poseName, float durOn, float durHold, float durOff, string componentName = "", float amount = 1f)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xD715E0", Offset = "0xD715E0", VA = "0xD715E0")]
	protected static void AddAnimatorComponent(string componentName, string animatorSearch, float durOn, float durHold, float durOff, int parmIndex, bool isTriggereParmBiDir = false)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xD7180C", Offset = "0xD7180C", VA = "0xD7180C")]
	protected static void AddBoneComponent(string componentSearchName, TformBase maxTform, float durOn, float durHold, float durOff, string componentName = "", bool constrainPos = false, bool constrainRot = true, bool constrainScl = false)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xD71A94", Offset = "0xD71A94", VA = "0xD71A94")]
	protected static void AddEmoteFlags(bool isRandom, bool isEmph, bool isRepeater, float frac = 1f, bool isAlwaysEmph = false)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xD71BEC", Offset = "0xD71BEC", VA = "0xD71BEC")]
	protected static void DoOneClickiness(GameObject go, AudioClip clip)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xD71EE8", Offset = "0xD71EE8", VA = "0xD71EE8")]
	private static bool FindSkinnedMeshRenderers(OneClickConfiguration configuration)
	{
		return default(bool);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xD72744", Offset = "0xD72744", VA = "0xD72744")]
	private static void ConfigEmoterSettings(QueueProcessor qp)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xD72430", Offset = "0xD72430", VA = "0xD72430")]
	private static void ConfigureSalsaSettings(AudioClip clip, QueueProcessor qp)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xD73360", Offset = "0xD73360", VA = "0xD73360")]
	protected static void Init()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xD72998", Offset = "0xD72998", VA = "0xD72998")]
	private static void ConfigureModuleExpressions(OneClickConfiguration configuration)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xD73438", Offset = "0xD73438", VA = "0xD73438")]
	private static Expression InitializeExpressionType(OneClickConfiguration configuration, int exp)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xD73890", Offset = "0xD73890", VA = "0xD73890")]
	private static int RegexFindBlendshapeName(SkinnedMeshRenderer smr, string bName)
	{
		return default(int);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xD73F80", Offset = "0xD73F80", VA = "0xD73F80")]
	private static string[] GetBlendshapeNames(SkinnedMeshRenderer smr)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xD73D38", Offset = "0xD73D38", VA = "0xD73D38")]
	private static TformBase ConvertBoneToTform(Transform bone)
	{
		return default(TformBase);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xD73C10", Offset = "0xD73C10", VA = "0xD73C10")]
	private static Transform FindBone(string componentSearchName)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xD73E58", Offset = "0xD73E58", VA = "0xD73E58")]
	private static Animator FindAnimator(string componentSearchName)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xD73B30", Offset = "0xD73B30", VA = "0xD73B30")]
	private static void ApplyCommonSettingsToComponent(ExpressionComponent component, OneClickComponent oneClickComponent, int componentNumber)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xD73984", Offset = "0xD73984", VA = "0xD73984")]
	private static int CreateNewComponent(int componentCount, Expression expression)
	{
		return default(int);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xD74098", Offset = "0xD74098", VA = "0xD74098")]
	public OneClickBase()
	{
	}
}
[Token(Token = "0x2000003")]
public class OneClickBoxHead : OneClickBase
{
	[Token(Token = "0x6000019")]
	[Address(RVA = "0xD741F0", Offset = "0xD741F0", VA = "0xD741F0")]
	public static void Setup(GameObject gameObject, AudioClip clip)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xD748A8", Offset = "0xD748A8", VA = "0xD748A8")]
	public OneClickBoxHead()
	{
	}
}
[Token(Token = "0x2000004")]
public class OneClickBoxHeadEyes : MonoBehaviour
{
	[Token(Token = "0x600001B")]
	[Address(RVA = "0xD74900", Offset = "0xD74900", VA = "0xD74900")]
	public static void Setup(GameObject go)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xD751BC", Offset = "0xD751BC", VA = "0xD751BC")]
	public OneClickBoxHeadEyes()
	{
	}
}
[Token(Token = "0x2000005")]
public class OneClickComponent
{
	[Token(Token = "0x2000006")]
	public enum ComponentType
	{
		[Token(Token = "0x400002A")]
		Shape,
		[Token(Token = "0x400002B")]
		UMA,
		[Token(Token = "0x400002C")]
		Bone,
		[Token(Token = "0x400002D")]
		Animator
	}

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x10")]
	public ComponentType type;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x18")]
	public string componentName;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x20")]
	public float durOn;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x24")]
	public float durHold;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x28")]
	public float durOff;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xD751C4", Offset = "0xD751C4", VA = "0xD751C4")]
	public OneClickComponent()
	{
	}
}
[Token(Token = "0x2000007")]
public class OneClickShapeComponent : OneClickComponent
{
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x30")]
	public string[] blendshapeNames;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x38")]
	public float maxAmount;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x3C")]
	public bool useRegex;

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xD71368", Offset = "0xD71368", VA = "0xD71368")]
	public OneClickShapeComponent(string componentName, string[] blendshapeNames, float maxAmount, float durOn, float durHold, float durOff, ComponentType type, bool useRegex)
	{
	}
}
[Token(Token = "0x2000008")]
public class OneClickBoneComponent : OneClickComponent
{
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x30")]
	public string componentSearchName;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x38")]
	public TformBase max;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x60")]
	public bool usePos;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x61")]
	public bool useRot;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x62")]
	public bool useScl;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xD719F0", Offset = "0xD719F0", VA = "0xD719F0")]
	public OneClickBoneComponent(string componentName, string boneSearchName, TformBase max, bool usePos, bool useRot, bool useScl, float durOn, float durHold, float durOff, ComponentType type)
	{
	}
}
[Token(Token = "0x2000009")]
public class OneClickUepComponent : OneClickComponent
{
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x30")]
	public string poseName;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x38")]
	public float maxAmount;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xD71574", Offset = "0xD71574", VA = "0xD71574")]
	public OneClickUepComponent(string componentName, string poseName, float maxAmount, float durOn, float durHold, float durOff, ComponentType type)
	{
	}
}
[Token(Token = "0x200000A")]
public class OneClickAnimatorComponent : OneClickComponent
{
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x30")]
	public string componentSearchName;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x38")]
	public int animationParmIndex;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x3C")]
	public bool isTriggerParmBiDirectional;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xD71790", Offset = "0xD71790", VA = "0xD71790")]
	public OneClickAnimatorComponent(string componentName, string animatorSearchName, int animationParmIndex, bool isTriggerParmBiDirectional, float durOn, float durHold, float durOff, ComponentType type)
	{
	}
}
[Token(Token = "0x200000B")]
public class OneClickConfiguration
{
	[Token(Token = "0x200000C")]
	public enum ConfigType
	{
		[Token(Token = "0x400003F")]
		Salsa,
		[Token(Token = "0x4000040")]
		Emoter
	}

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x10")]
	public ConfigType type;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x18")]
	public List<string> smrSearches;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x20")]
	public List<OneClickExpression> oneClickExpressions;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xD70D90", Offset = "0xD70D90", VA = "0xD70D90")]
	public OneClickConfiguration(ConfigType type)
	{
	}
}
[Token(Token = "0x200000D")]
public class OneClickExpression
{
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x18")]
	public List<OneClickComponent> components;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xD751CC", Offset = "0xD751CC", VA = "0xD751CC")]
	public OneClickExpression()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xD71168", Offset = "0xD71168", VA = "0xD71168")]
	public OneClickExpression(string name, List<OneClickComponent> components)
	{
	}
}
[Token(Token = "0x200000E")]
public class OneClickEmoterExpression : OneClickExpression
{
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x20")]
	public bool isRandom;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x21")]
	public bool isEmphasis;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x22")]
	public bool isAlwaysEmphasis;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x23")]
	public bool isRepeater;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x24")]
	public float expressionDynamics;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xD71194", Offset = "0xD71194", VA = "0xD71194")]
	public OneClickEmoterExpression(string name, List<OneClickComponent> components)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xD71BC4", Offset = "0xD71BC4", VA = "0xD71BC4")]
	public void SetEmoterBools(bool isRand, bool isEmph, bool isRep, float frac, bool isAlwaysEmph = false)
	{
	}
}
