using System;
using System.Collections.Generic;
using System.Reflection;
using BugsnagUnity.Payload;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class AdvertiserOptInAttribute : PropertyAttribute
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1BEA3A8", Offset = "0x1BEA3A8", VA = "0x1BEA3A8")]
	public AdvertiserOptInAttribute()
	{
	}
}
[Token(Token = "0x2000003")]
public class RangedTooltipAttribute : PropertyAttribute
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x10")]
	public readonly float min;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x14")]
	public readonly float max;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x18")]
	public readonly string text;

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1BF1480", Offset = "0x1BF1480", VA = "0x1BF1480")]
	public RangedTooltipAttribute(string text, float min, float max)
	{
	}
}
[Token(Token = "0x2000004")]
public class TooltipAttribute : PropertyAttribute
{
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x10")]
	public readonly string text;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1BF16F8", Offset = "0x1BF16F8", VA = "0x1BF16F8")]
	public TooltipAttribute(string text)
	{
	}
}
[Token(Token = "0x2000005")]
public class Field
{
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x10")]
	private readonly string parameter;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1BEB1DC", Offset = "0x1BEB1DC", VA = "0x1BEB1DC")]
	public Field(string parameter)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1BEB210", Offset = "0x1BEB210", VA = "0x1BEB210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000006")]
public class Fields
{
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Field ANONYMIZE_IP;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x8")]
	public static readonly Field HIT_TYPE;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x10")]
	public static readonly Field SESSION_CONTROL;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x18")]
	public static readonly Field SCREEN_NAME;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x20")]
	public static readonly Field LOCATION;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x28")]
	public static readonly Field REFERRER;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x30")]
	public static readonly Field PAGE;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x38")]
	public static readonly Field HOSTNAME;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x40")]
	public static readonly Field TITLE;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x48")]
	public static readonly Field LANGUAGE;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x50")]
	public static readonly Field ENCODING;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x58")]
	public static readonly Field SCREEN_COLORS;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x60")]
	public static readonly Field SCREEN_RESOLUTION;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x68")]
	public static readonly Field VIEWPORT_SIZE;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x70")]
	public static readonly Field APP_NAME;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x78")]
	public static readonly Field APP_ID;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x80")]
	public static readonly Field APP_INSTALLER_ID;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x88")]
	public static readonly Field APP_VERSION;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x90")]
	public static readonly Field CLIENT_ID;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x98")]
	public static readonly Field USER_ID;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0xA0")]
	public static readonly Field CAMPAIGN_NAME;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0xA8")]
	public static readonly Field CAMPAIGN_SOURCE;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0xB0")]
	public static readonly Field CAMPAIGN_MEDIUM;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0xB8")]
	public static readonly Field CAMPAIGN_KEYWORD;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0xC0")]
	public static readonly Field CAMPAIGN_CONTENT;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0xC8")]
	public static readonly Field CAMPAIGN_ID;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0xD0")]
	public static readonly Field GCLID;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0xD8")]
	public static readonly Field DCLID;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0xE0")]
	public static readonly Field EVENT_CATEGORY;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0xE8")]
	public static readonly Field EVENT_ACTION;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0xF0")]
	public static readonly Field EVENT_LABEL;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0xF8")]
	public static readonly Field EVENT_VALUE;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x100")]
	public static readonly Field SOCIAL_NETWORK;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x108")]
	public static readonly Field SOCIAL_ACTION;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x110")]
	public static readonly Field SOCIAL_TARGET;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x118")]
	public static readonly Field TIMING_VAR;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x120")]
	public static readonly Field TIMING_VALUE;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x128")]
	public static readonly Field TIMING_CATEGORY;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x130")]
	public static readonly Field TIMING_LABEL;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x138")]
	public static readonly Field EX_DESCRIPTION;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x140")]
	public static readonly Field EX_FATAL;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x148")]
	public static readonly Field CURRENCY_CODE;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x150")]
	public static readonly Field TRANSACTION_ID;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x158")]
	public static readonly Field TRANSACTION_AFFILIATION;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x160")]
	public static readonly Field TRANSACTION_SHIPPING;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x168")]
	public static readonly Field TRANSACTION_TAX;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x170")]
	public static readonly Field TRANSACTION_REVENUE;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x178")]
	public static readonly Field ITEM_SKU;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x180")]
	public static readonly Field ITEM_NAME;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x188")]
	public static readonly Field ITEM_CATEGORY;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x190")]
	public static readonly Field ITEM_PRICE;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x198")]
	public static readonly Field ITEM_QUANTITY;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x1A0")]
	public static readonly Field TRACKING_ID;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x1A8")]
	public static readonly Field SAMPLE_RATE;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x1B0")]
	public static readonly Field DEVELOPER_ID;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x1B8")]
	public static readonly Field CUSTOM_METRIC;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x1C0")]
	public static readonly Field CUSTOM_DIMENSION;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x1C8")]
	public static readonly Field ADID;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x1D0")]
	public static readonly Field IDFA;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x1D8")]
	public static readonly Field ATE;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1BEB218", Offset = "0x1BEB218", VA = "0x1BEB218")]
	public Fields()
	{
	}
}
[Token(Token = "0x2000007")]
public class GAIHandler
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1BEC59C", Offset = "0x1BEC59C", VA = "0x1BEC59C")]
	public GAIHandler()
	{
	}
}
[Token(Token = "0x2000008")]
public class GoogleAnalyticsAndroidV4 : IDisposable
{
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x10")]
	private string trackingCode;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x18")]
	private string appVersion;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x20")]
	private string appName;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x28")]
	private string bundleIdentifier;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x30")]
	private int dispatchPeriod;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x34")]
	private int sampleFrequency;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x38")]
	private bool anonymizeIP;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x39")]
	private bool adIdCollection;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x3A")]
	private bool dryRun;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x3C")]
	private int sessionTimeout;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x40")]
	private AndroidJavaObject tracker;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x48")]
	private AndroidJavaObject logger;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x50")]
	private AndroidJavaObject currentActivityObject;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x58")]
	private AndroidJavaObject googleAnalyticsSingleton;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1BEC5A4", Offset = "0x1BEC5A4", VA = "0x1BEC5A4")]
	internal void InitializeTracker()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1BECFC8", Offset = "0x1BECFC8", VA = "0x1BECFC8")]
	internal void SetTrackerVal(Field fieldName, object value)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1BED0F4", Offset = "0x1BED0F4", VA = "0x1BED0F4")]
	private void SetSessionOnBuilder(AndroidJavaObject hitBuilder)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1BED0F8", Offset = "0x1BED0F8", VA = "0x1BED0F8")]
	internal void StartSession()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1BED0FC", Offset = "0x1BED0FC", VA = "0x1BED0FC")]
	internal void StopSession()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1BED100", Offset = "0x1BED100", VA = "0x1BED100")]
	public void SetOptOut(bool optOut)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1BED20C", Offset = "0x1BED20C", VA = "0x1BED20C")]
	internal void LogScreen(AppViewHitBuilder builder)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1BED4E0", Offset = "0x1BED4E0", VA = "0x1BED4E0")]
	internal void LogEvent(EventHitBuilder builder)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1BEDDEC", Offset = "0x1BEDDEC", VA = "0x1BEDDEC")]
	internal void LogTransaction(TransactionHitBuilder builder)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1BEE354", Offset = "0x1BEE354", VA = "0x1BEE354")]
	internal void LogItem(ItemHitBuilder builder)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1BEE92C", Offset = "0x1BEE92C", VA = "0x1BEE92C")]
	public void LogException(ExceptionHitBuilder builder)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1BEECA4", Offset = "0x1BEECA4", VA = "0x1BEECA4")]
	public void LogSocial(SocialHitBuilder builder)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1BEF060", Offset = "0x1BEF060", VA = "0x1BEF060")]
	public void LogTiming(TimingHitBuilder builder)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1BEF4C0", Offset = "0x1BEF4C0", VA = "0x1BEF4C0")]
	public void DispatchHits()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1BEF4C4", Offset = "0x1BEF4C4", VA = "0x1BEF4C4")]
	public void SetSampleFrequency(int sampleFrequency)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1BEF4CC", Offset = "0x1BEF4CC", VA = "0x1BEF4CC")]
	public void ClearUserIDOverride()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1BEF544", Offset = "0x1BEF544", VA = "0x1BEF544")]
	public void SetTrackingCode(string trackingCode)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1BEF54C", Offset = "0x1BEF54C", VA = "0x1BEF54C")]
	public void SetAppName(string appName)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1BEF554", Offset = "0x1BEF554", VA = "0x1BEF554")]
	public void SetBundleIdentifier(string bundleIdentifier)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1BEF55C", Offset = "0x1BEF55C", VA = "0x1BEF55C")]
	public void SetAppVersion(string appVersion)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1BEF564", Offset = "0x1BEF564", VA = "0x1BEF564")]
	public void SetDispatchPeriod(int dispatchPeriod)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1BEF56C", Offset = "0x1BEF56C", VA = "0x1BEF56C")]
	public void SetLogLevelValue(GoogleAnalyticsV4.DebugMode logLevel)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1BEF570", Offset = "0x1BEF570", VA = "0x1BEF570")]
	public void SetAnonymizeIP(bool anonymizeIP)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1BEF57C", Offset = "0x1BEF57C", VA = "0x1BEF57C")]
	public void SetAdIdCollection(bool adIdCollection)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1BEF588", Offset = "0x1BEF588", VA = "0x1BEF588")]
	public void SetDryRun(bool dryRun)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1BEF594", Offset = "0x1BEF594", VA = "0x1BEF594", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1BEF5D0", Offset = "0x1BEF5D0", VA = "0x1BEF5D0")]
	public GoogleAnalyticsAndroidV4()
	{
	}
}
[Token(Token = "0x2000009")]
public class GoogleAnalyticsiOSV3
{
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1BF12B0", Offset = "0x1BF12B0", VA = "0x1BF12B0")]
	public GoogleAnalyticsiOSV3()
	{
	}
}
[Token(Token = "0x200000A")]
public class GoogleAnalyticsMPV3
{
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1BEF5D8", Offset = "0x1BEF5D8", VA = "0x1BEF5D8")]
	public GoogleAnalyticsMPV3()
	{
	}
}
[Token(Token = "0x200000B")]
public class GoogleAnalyticsV4 : MonoBehaviour
{
	[Token(Token = "0x2000015")]
	public enum DebugMode
	{
		[Token(Token = "0x400009D")]
		ERROR,
		[Token(Token = "0x400009E")]
		WARNING,
		[Token(Token = "0x400009F")]
		INFO,
		[Token(Token = "0x40000A0")]
		VERBOSE
	}

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x18")]
	private string uncaughtExceptionStackTrace;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x20")]
	private bool initialized;

	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x807720", Offset = "0x807720")]
	public string androidTrackingCode;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x807758", Offset = "0x807758")]
	public string IOSTrackingCode;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x807790", Offset = "0x807790")]
	public string otherTrackingCode;

	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8077C8", Offset = "0x8077C8")]
	public string productName;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x807800", Offset = "0x807800")]
	public string bundleIdentifier;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x807838", Offset = "0x807838")]
	public string bundleVersion;

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "RangedTooltipAttribute", RVA = "0x807870", Offset = "0x807870")]
	public int dispatchPeriod;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "RangedTooltipAttribute", RVA = "0x8078B4", Offset = "0x8078B4")]
	public int sampleFrequency;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8078F8", Offset = "0x8078F8")]
	public DebugMode logLevel;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x807930", Offset = "0x807930")]
	public bool anonymizeIP;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x65")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x807968", Offset = "0x807968")]
	public bool UncaughtExceptionReporting;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x66")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8079A0", Offset = "0x8079A0")]
	public bool sendLaunchEvent;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x67")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8079D8", Offset = "0x8079D8")]
	public bool dryRun;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x807A10", Offset = "0x807A10")]
	public int sessionTimeout;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x6C")]
	[AdvertiserOptIn]
	public bool enableAdId;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x0")]
	public static GoogleAnalyticsV4 instance;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x8")]
	[HideInInspector]
	public static readonly string currencySymbol;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string EVENT_HIT;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string APP_VIEW;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string SET;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string SET_ALL;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string SEND;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string ITEM_HIT;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x40")]
	public static readonly string TRANSACTION_HIT;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x48")]
	public static readonly string SOCIAL_HIT;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x50")]
	public static readonly string TIMING_HIT;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x58")]
	public static readonly string EXCEPTION_HIT;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x70")]
	private GoogleAnalyticsAndroidV4 androidTracker;

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1BEF5E0", Offset = "0x1BEF5E0", VA = "0x1BEF5E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1BEFB18", Offset = "0x1BEFB18", VA = "0x1BEFB18")]
	private void Update()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1BEFC08", Offset = "0x1BEFC08", VA = "0x1BEFC08")]
	private void HandleException(string condition, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1BEF764", Offset = "0x1BEF764", VA = "0x1BEF764")]
	private void InitializeTracker()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1BEFD20", Offset = "0x1BEFD20", VA = "0x1BEFD20")]
	public void SetAppLevelOptOut(bool optOut)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1BEFD54", Offset = "0x1BEFD54", VA = "0x1BEFD54")]
	public void SetUserIDOverride(string userID)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1BEFDD0", Offset = "0x1BEFDD0", VA = "0x1BEFDD0")]
	public void ClearUserIDOverride()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1BEFDFC", Offset = "0x1BEFDFC", VA = "0x1BEFDFC")]
	public void DispatchHits()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1BEFE28", Offset = "0x1BEFE28", VA = "0x1BEFE28")]
	public void StartSession()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1BEFE54", Offset = "0x1BEFE54", VA = "0x1BEFE54")]
	public void StopSession()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1BEFCDC", Offset = "0x1BEFCDC", VA = "0x1BEFCDC")]
	public void SetOnTracker(Field fieldName, object value)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1BEFE80", Offset = "0x1BEFE80", VA = "0x1BEFE80")]
	public void LogScreen(string title)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1BEFF04", Offset = "0x1BEFF04", VA = "0x1BEFF04")]
	public void LogScreen(AppViewHitBuilder builder)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1BEF9F4", Offset = "0x1BEF9F4", VA = "0x1BEF9F4")]
	public void LogEvent(string eventCategory, string eventAction, string eventLabel, long value)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1BF0004", Offset = "0x1BF0004", VA = "0x1BF0004")]
	public void LogEvent(EventHitBuilder builder)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1BF0104", Offset = "0x1BF0104", VA = "0x1BF0104")]
	public void LogTransaction(string transID, string affiliation, double revenue, double tax, double shipping)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1BF0198", Offset = "0x1BF0198", VA = "0x1BF0198")]
	public void LogTransaction(string transID, string affiliation, double revenue, double tax, double shipping, string currencyCode)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1BF03B8", Offset = "0x1BF03B8", VA = "0x1BF03B8")]
	public void LogTransaction(TransactionHitBuilder builder)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1BF04B8", Offset = "0x1BF04B8", VA = "0x1BF04B8")]
	public void LogItem(string transID, string name, string sku, string category, double price, long quantity)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1BF04C0", Offset = "0x1BF04C0", VA = "0x1BF04C0")]
	public void LogItem(string transID, string name, string sku, string category, double price, long quantity, string currencyCode)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1BF078C", Offset = "0x1BF078C", VA = "0x1BF078C")]
	public void LogItem(ItemHitBuilder builder)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1BEFB70", Offset = "0x1BEFB70", VA = "0x1BEFB70")]
	public void LogException(string exceptionDescription, bool isFatal)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1BF088C", Offset = "0x1BF088C", VA = "0x1BF088C")]
	public void LogException(ExceptionHitBuilder builder)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1BF098C", Offset = "0x1BF098C", VA = "0x1BF098C")]
	public void LogSocial(string socialNetwork, string socialAction, string socialTarget)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1BF0B70", Offset = "0x1BF0B70", VA = "0x1BF0B70")]
	public void LogSocial(SocialHitBuilder builder)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1BF0C70", Offset = "0x1BF0C70", VA = "0x1BF0C70")]
	public void LogTiming(string timingCategory, long timingInterval, string timingName, string timingLabel)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1BF0E6C", Offset = "0x1BF0E6C", VA = "0x1BF0E6C")]
	public void LogTiming(TimingHitBuilder builder)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1BF0F6C", Offset = "0x1BF0F6C", VA = "0x1BF0F6C")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1BEFAC0", Offset = "0x1BEFAC0", VA = "0x1BEFAC0")]
	public static bool belowThreshold(DebugMode userLogLevel, DebugMode comparelogLevel)
	{
		return default(bool);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1BF0F90", Offset = "0x1BF0F90", VA = "0x1BF0F90")]
	public static GoogleAnalyticsV4 getInstance()
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1BF0FF4", Offset = "0x1BF0FF4", VA = "0x1BF0FF4")]
	public GoogleAnalyticsV4()
	{
	}
}
[Token(Token = "0x200000C")]
public class AppViewHitBuilder : HitBuilder<AppViewHitBuilder>
{
	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x60")]
	private string screenName;

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1BEA3B0", Offset = "0x1BEA3B0", VA = "0x1BEA3B0")]
	public string GetScreenName()
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1BEA3B8", Offset = "0x1BEA3B8", VA = "0x1BEA3B8")]
	public AppViewHitBuilder SetScreenName(string screenName)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1BEA3E8", Offset = "0x1BEA3E8", VA = "0x1BEA3E8", Slot = "4")]
	public override AppViewHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1BEA3EC", Offset = "0x1BEA3EC", VA = "0x1BEA3EC", Slot = "5")]
	public override AppViewHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1BEA480", Offset = "0x1BEA480", VA = "0x1BEA480")]
	public AppViewHitBuilder()
	{
	}
}
[Token(Token = "0x200000D")]
public class EventHitBuilder : HitBuilder<EventHitBuilder>
{
	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x60")]
	private string eventCategory;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x68")]
	private string eventAction;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x70")]
	private string eventLabel;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x78")]
	private long eventValue;

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1BEAEE8", Offset = "0x1BEAEE8", VA = "0x1BEAEE8")]
	public string GetEventCategory()
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1BEAEF0", Offset = "0x1BEAEF0", VA = "0x1BEAEF0")]
	public EventHitBuilder SetEventCategory(string eventCategory)
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1BEAF20", Offset = "0x1BEAF20", VA = "0x1BEAF20")]
	public string GetEventAction()
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1BEAF28", Offset = "0x1BEAF28", VA = "0x1BEAF28")]
	public EventHitBuilder SetEventAction(string eventAction)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1BEAF58", Offset = "0x1BEAF58", VA = "0x1BEAF58")]
	public string GetEventLabel()
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1BEAF60", Offset = "0x1BEAF60", VA = "0x1BEAF60")]
	public EventHitBuilder SetEventLabel(string eventLabel)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1BEAF90", Offset = "0x1BEAF90", VA = "0x1BEAF90")]
	public long GetEventValue()
	{
		return default(long);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1BEAF98", Offset = "0x1BEAF98", VA = "0x1BEAF98")]
	public EventHitBuilder SetEventValue(long eventValue)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1BEAFA0", Offset = "0x1BEAFA0", VA = "0x1BEAFA0", Slot = "4")]
	public override EventHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1BEAFA4", Offset = "0x1BEAFA4", VA = "0x1BEAFA4", Slot = "5")]
	public override EventHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1BEB078", Offset = "0x1BEB078", VA = "0x1BEB078")]
	public EventHitBuilder()
	{
	}
}
[Token(Token = "0x200000E")]
public class ExceptionHitBuilder : HitBuilder<ExceptionHitBuilder>
{
	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x60")]
	private string exceptionDescription;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x68")]
	private bool fatal;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1BEB110", Offset = "0x1BEB110", VA = "0x1BEB110")]
	public string GetExceptionDescription()
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1BEB118", Offset = "0x1BEB118", VA = "0x1BEB118")]
	public ExceptionHitBuilder SetExceptionDescription(string exceptionDescription)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1BEB148", Offset = "0x1BEB148", VA = "0x1BEB148")]
	public bool IsFatal()
	{
		return default(bool);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1BEB150", Offset = "0x1BEB150", VA = "0x1BEB150")]
	public ExceptionHitBuilder SetFatal(bool fatal)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1BEB15C", Offset = "0x1BEB15C", VA = "0x1BEB15C", Slot = "4")]
	public override ExceptionHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1BEB160", Offset = "0x1BEB160", VA = "0x1BEB160", Slot = "5")]
	public override ExceptionHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1BEB164", Offset = "0x1BEB164", VA = "0x1BEB164")]
	public ExceptionHitBuilder()
	{
	}
}
[Token(Token = "0x200000F")]
public abstract class HitBuilder<T>
{
	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<int, string> customDimensions;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<int, float> customMetrics;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x0")]
	private string campaignName;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x0")]
	private string campaignSource;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x0")]
	private string campaignMedium;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x0")]
	private string campaignKeyword;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x0")]
	private string campaignContent;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x0")]
	private string campaignID;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x0")]
	private string gclid;

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x0")]
	private string dclid;

	[Token(Token = "0x600005D")]
	public abstract T GetThis();

	[Token(Token = "0x600005E")]
	public abstract T Validate();

	[Token(Token = "0x600005F")]
	public T SetCustomDimension(int dimensionNumber, string value)
	{
		return (T)null;
	}

	[Token(Token = "0x6000060")]
	public Dictionary<int, string> GetCustomDimensions()
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	public T SetCustomMetric(int metricNumber, float value)
	{
		return (T)null;
	}

	[Token(Token = "0x6000062")]
	public Dictionary<int, float> GetCustomMetrics()
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	public string GetCampaignName()
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	public T SetCampaignName(string campaignName)
	{
		return (T)null;
	}

	[Token(Token = "0x6000065")]
	public string GetCampaignSource()
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	public T SetCampaignSource(string campaignSource)
	{
		return (T)null;
	}

	[Token(Token = "0x6000067")]
	public string GetCampaignMedium()
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	public T SetCampaignMedium(string campaignMedium)
	{
		return (T)null;
	}

	[Token(Token = "0x6000069")]
	public string GetCampaignKeyword()
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	public T SetCampaignKeyword(string campaignKeyword)
	{
		return (T)null;
	}

	[Token(Token = "0x600006B")]
	public string GetCampaignContent()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	public T SetCampaignContent(string campaignContent)
	{
		return (T)null;
	}

	[Token(Token = "0x600006D")]
	public string GetCampaignID()
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	public T SetCampaignID(string campaignID)
	{
		return (T)null;
	}

	[Token(Token = "0x600006F")]
	public string GetGclid()
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	public T SetGclid(string gclid)
	{
		return (T)null;
	}

	[Token(Token = "0x6000071")]
	public string GetDclid()
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	public T SetDclid(string dclid)
	{
		return (T)null;
	}

	[Token(Token = "0x6000073")]
	protected HitBuilder()
	{
	}
}
[Token(Token = "0x2000010")]
public class ItemHitBuilder : HitBuilder<ItemHitBuilder>
{
	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x60")]
	private string transactionID;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x68")]
	private string name;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x70")]
	private string SKU;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x78")]
	private double price;

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x80")]
	private string category;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x88")]
	private long quantity;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x90")]
	private string currencyCode;

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1BF12B8", Offset = "0x1BF12B8", VA = "0x1BF12B8")]
	public string GetTransactionID()
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1BF068C", Offset = "0x1BF068C", VA = "0x1BF068C")]
	public ItemHitBuilder SetTransactionID(string transactionID)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1BF12C0", Offset = "0x1BF12C0", VA = "0x1BF12C0")]
	public string GetName()
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1BF06BC", Offset = "0x1BF06BC", VA = "0x1BF06BC")]
	public ItemHitBuilder SetName(string name)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1BF12C8", Offset = "0x1BF12C8", VA = "0x1BF12C8")]
	public string GetSKU()
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1BF06EC", Offset = "0x1BF06EC", VA = "0x1BF06EC")]
	public ItemHitBuilder SetSKU(string SKU)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1BF12D0", Offset = "0x1BF12D0", VA = "0x1BF12D0")]
	public double GetPrice()
	{
		return default(double);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1BF074C", Offset = "0x1BF074C", VA = "0x1BF074C")]
	public ItemHitBuilder SetPrice(double price)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1BF12D8", Offset = "0x1BF12D8", VA = "0x1BF12D8")]
	public string GetCategory()
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1BF071C", Offset = "0x1BF071C", VA = "0x1BF071C")]
	public ItemHitBuilder SetCategory(string category)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1BF12E0", Offset = "0x1BF12E0", VA = "0x1BF12E0")]
	public long GetQuantity()
	{
		return default(long);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1BF0754", Offset = "0x1BF0754", VA = "0x1BF0754")]
	public ItemHitBuilder SetQuantity(long quantity)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1BF12E8", Offset = "0x1BF12E8", VA = "0x1BF12E8")]
	public string GetCurrencyCode()
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1BF075C", Offset = "0x1BF075C", VA = "0x1BF075C")]
	public ItemHitBuilder SetCurrencyCode(string currencyCode)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1BF12F0", Offset = "0x1BF12F0", VA = "0x1BF12F0", Slot = "4")]
	public override ItemHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1BF12F4", Offset = "0x1BF12F4", VA = "0x1BF12F4", Slot = "5")]
	public override ItemHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1BF05D4", Offset = "0x1BF05D4", VA = "0x1BF05D4")]
	public ItemHitBuilder()
	{
	}
}
[Token(Token = "0x2000011")]
public class SocialHitBuilder : HitBuilder<SocialHitBuilder>
{
	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x60")]
	private string socialNetwork;

	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x68")]
	private string socialAction;

	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x70")]
	private string socialTarget;

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1BF14CC", Offset = "0x1BF14CC", VA = "0x1BF14CC")]
	public string GetSocialNetwork()
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1BF0AE0", Offset = "0x1BF0AE0", VA = "0x1BF0AE0")]
	public SocialHitBuilder SetSocialNetwork(string socialNetwork)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1BF14D4", Offset = "0x1BF14D4", VA = "0x1BF14D4")]
	public string GetSocialAction()
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1BF0B10", Offset = "0x1BF0B10", VA = "0x1BF0B10")]
	public SocialHitBuilder SetSocialAction(string socialAction)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1BF14DC", Offset = "0x1BF14DC", VA = "0x1BF14DC")]
	public string GetSocialTarget()
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1BF0B40", Offset = "0x1BF0B40", VA = "0x1BF0B40")]
	public SocialHitBuilder SetSocialTarget(string socialTarget)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1BF14E4", Offset = "0x1BF14E4", VA = "0x1BF14E4", Slot = "4")]
	public override SocialHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1BF14E8", Offset = "0x1BF14E8", VA = "0x1BF14E8", Slot = "5")]
	public override SocialHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1BF0A48", Offset = "0x1BF0A48", VA = "0x1BF0A48")]
	public SocialHitBuilder()
	{
	}
}
[Token(Token = "0x2000012")]
public class TimingHitBuilder : HitBuilder<TimingHitBuilder>
{
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x60")]
	private string timingCategory;

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x68")]
	private long timingInterval;

	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x70")]
	private string timingName;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x78")]
	private string timingLabel;

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1BF15FC", Offset = "0x1BF15FC", VA = "0x1BF15FC")]
	public string GetTimingCategory()
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1BF0DD4", Offset = "0x1BF0DD4", VA = "0x1BF0DD4")]
	public TimingHitBuilder SetTimingCategory(string timingCategory)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1BF1604", Offset = "0x1BF1604", VA = "0x1BF1604")]
	public long GetTimingInterval()
	{
		return default(long);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1BF0E04", Offset = "0x1BF0E04", VA = "0x1BF0E04")]
	public TimingHitBuilder SetTimingInterval(long timingInterval)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1BF160C", Offset = "0x1BF160C", VA = "0x1BF160C")]
	public string GetTimingName()
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1BF0E0C", Offset = "0x1BF0E0C", VA = "0x1BF0E0C")]
	public TimingHitBuilder SetTimingName(string timingName)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1BF1614", Offset = "0x1BF1614", VA = "0x1BF1614")]
	public string GetTimingLabel()
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1BF0E3C", Offset = "0x1BF0E3C", VA = "0x1BF0E3C")]
	public TimingHitBuilder SetTimingLabel(string timingLabel)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1BF161C", Offset = "0x1BF161C", VA = "0x1BF161C", Slot = "4")]
	public override TimingHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1BF1620", Offset = "0x1BF1620", VA = "0x1BF1620", Slot = "5")]
	public override TimingHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1BF0D3C", Offset = "0x1BF0D3C", VA = "0x1BF0D3C")]
	public TimingHitBuilder()
	{
	}
}
[Token(Token = "0x2000013")]
public class TransactionHitBuilder : HitBuilder<TransactionHitBuilder>
{
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x60")]
	private string transactionID;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x68")]
	private string affiliation;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x70")]
	private double revenue;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x78")]
	private double tax;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x80")]
	private double shipping;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x88")]
	private string currencyCode;

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1BF172C", Offset = "0x1BF172C", VA = "0x1BF172C")]
	public string GetTransactionID()
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1BF0310", Offset = "0x1BF0310", VA = "0x1BF0310")]
	public TransactionHitBuilder SetTransactionID(string transactionID)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1BF1734", Offset = "0x1BF1734", VA = "0x1BF1734")]
	public string GetAffiliation()
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1BF0340", Offset = "0x1BF0340", VA = "0x1BF0340")]
	public TransactionHitBuilder SetAffiliation(string affiliation)
	{
		return null;
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x1BF173C", Offset = "0x1BF173C", VA = "0x1BF173C")]
	public double GetRevenue()
	{
		return default(double);
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1BF0370", Offset = "0x1BF0370", VA = "0x1BF0370")]
	public TransactionHitBuilder SetRevenue(double revenue)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1BF1744", Offset = "0x1BF1744", VA = "0x1BF1744")]
	public double GetTax()
	{
		return default(double);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1BF0378", Offset = "0x1BF0378", VA = "0x1BF0378")]
	public TransactionHitBuilder SetTax(double tax)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1BF174C", Offset = "0x1BF174C", VA = "0x1BF174C")]
	public double GetShipping()
	{
		return default(double);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1BF0380", Offset = "0x1BF0380", VA = "0x1BF0380")]
	public TransactionHitBuilder SetShipping(double shipping)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1BF1754", Offset = "0x1BF1754", VA = "0x1BF1754")]
	public string GetCurrencyCode()
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1BF0388", Offset = "0x1BF0388", VA = "0x1BF0388")]
	public TransactionHitBuilder SetCurrencyCode(string currencyCode)
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1BF175C", Offset = "0x1BF175C", VA = "0x1BF175C", Slot = "4")]
	public override TransactionHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1BF1760", Offset = "0x1BF1760", VA = "0x1BF1760", Slot = "5")]
	public override TransactionHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1BF0278", Offset = "0x1BF0278", VA = "0x1BF0278")]
	public TransactionHitBuilder()
	{
	}
}
namespace BugsnagUnity;

[Token(Token = "0x2000014")]
public class BugsnagBehaviour : MonoBehaviour
{
	[Token(Token = "0x2000016")]
	private class LabelOverride : PropertyAttribute
	{
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1BF1908", Offset = "0x1BF1908", VA = "0x1BF1908")]
		public LabelOverride(string label)
		{
		}
	}

	[Token(Token = "0x2000017")]
	public class EnumFlagsAttribute : PropertyAttribute
	{
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1BF1900", Offset = "0x1BF1900", VA = "0x1BF1900")]
		public EnumFlagsAttribute()
		{
		}
	}

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x807A68", Offset = "0x807A68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x807A68", Offset = "0x807A68")]
	public string APIKey;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x807AC8", Offset = "0x807AC8")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x807AC8", Offset = "0x807AC8")]
	public bool AutoDetectErrors;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x21")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x807B28", Offset = "0x807B28")]
	[AttributeAttribute(Name = "LabelOverride", RVA = "0x807B28", Offset = "0x807B28")]
	public bool AutoDetectAnrs;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x22")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x807B88", Offset = "0x807B88")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x807B88", Offset = "0x807B88")]
	public bool AutoTrackSessions;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x807BE8", Offset = "0x807BE8")]
	public LogType NotifyLogLevel;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x807C20", Offset = "0x807C20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x807C20", Offset = "0x807C20")]
	public int SecondsPerUniqueLog;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x807C80", Offset = "0x807C80")]
	public int MaximumBreadcrumbs;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x30")]
	[EnumFlags]
	public BreadcrumbType EnabledBreadcrumbTypes;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x34")]
	[EnumFlags]
	public ErrorTypes EnabledErrorTypes;

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1BEA4F8", Offset = "0x1BEA4F8", VA = "0x1BEA4F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1BEAB90", Offset = "0x1BEAB90", VA = "0x1BEAB90")]
	private ErrorTypes[] GetEnabledErrorTypes()
	{
		return null;
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1BEA8C0", Offset = "0x1BEA8C0", VA = "0x1BEA8C0")]
	private BreadcrumbType[] GetEnabledBreadcrumbTypes()
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1BEA7F4", Offset = "0x1BEA7F4", VA = "0x1BEA7F4")]
	private static string FindScriptingBackend()
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1BEA838", Offset = "0x1BEA838", VA = "0x1BEA838")]
	private static string FindDotnetScriptingRuntime()
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1BEA87C", Offset = "0x1BEA87C", VA = "0x1BEA87C")]
	private static string FindDotnetApiCompatibility()
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1BEAE60", Offset = "0x1BEAE60", VA = "0x1BEAE60")]
	public BugsnagBehaviour()
	{
	}
}
