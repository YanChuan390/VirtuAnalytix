using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class AdvertiserOptInAttribute : PropertyAttribute
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2971AE8", Offset = "0x2971AE8", VA = "0x2971AE8")]
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
	[Address(RVA = "0x297B58C", Offset = "0x297B58C", VA = "0x297B58C")]
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
	[Address(RVA = "0x297B81C", Offset = "0x297B81C", VA = "0x297B81C")]
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
	[Address(RVA = "0x2971F1C", Offset = "0x2971F1C", VA = "0x2971F1C")]
	public Field(string parameter)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2971F50", Offset = "0x2971F50", VA = "0x2971F50", Slot = "3")]
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
	[Address(RVA = "0x2971F58", Offset = "0x2971F58", VA = "0x2971F58")]
	public Fields()
	{
	}
}
[Token(Token = "0x2000007")]
public class GAIHandler
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x29732C8", Offset = "0x29732C8", VA = "0x29732C8")]
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
	[Address(RVA = "0x29732D0", Offset = "0x29732D0", VA = "0x29732D0")]
	internal void InitializeTracker()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2973D0C", Offset = "0x2973D0C", VA = "0x2973D0C")]
	internal void SetTrackerVal(Field fieldName, object value)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2973E34", Offset = "0x2973E34", VA = "0x2973E34")]
	private void SetSessionOnBuilder(AndroidJavaObject hitBuilder)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2973E38", Offset = "0x2973E38", VA = "0x2973E38")]
	internal void StartSession()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2973E3C", Offset = "0x2973E3C", VA = "0x2973E3C")]
	internal void StopSession()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2973E40", Offset = "0x2973E40", VA = "0x2973E40")]
	public void SetOptOut(bool optOut)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2973F48", Offset = "0x2973F48", VA = "0x2973F48")]
	internal void LogScreen(AppViewHitBuilder builder)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2974244", Offset = "0x2974244", VA = "0x2974244")]
	internal void LogEvent(EventHitBuilder builder)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2974B78", Offset = "0x2974B78", VA = "0x2974B78")]
	internal void LogTransaction(TransactionHitBuilder builder)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2975108", Offset = "0x2975108", VA = "0x2975108")]
	internal void LogItem(ItemHitBuilder builder)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2975700", Offset = "0x2975700", VA = "0x2975700")]
	public void LogException(ExceptionHitBuilder builder)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2975A98", Offset = "0x2975A98", VA = "0x2975A98")]
	public void LogSocial(SocialHitBuilder builder)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2975E74", Offset = "0x2975E74", VA = "0x2975E74")]
	public void LogTiming(TimingHitBuilder builder)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x29762F4", Offset = "0x29762F4", VA = "0x29762F4")]
	public void DispatchHits()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x29762F8", Offset = "0x29762F8", VA = "0x29762F8")]
	public void SetSampleFrequency(int sampleFrequency)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2976300", Offset = "0x2976300", VA = "0x2976300")]
	public void ClearUserIDOverride()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2976370", Offset = "0x2976370", VA = "0x2976370")]
	public void SetTrackingCode(string trackingCode)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2976378", Offset = "0x2976378", VA = "0x2976378")]
	public void SetAppName(string appName)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2976380", Offset = "0x2976380", VA = "0x2976380")]
	public void SetBundleIdentifier(string bundleIdentifier)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2976388", Offset = "0x2976388", VA = "0x2976388")]
	public void SetAppVersion(string appVersion)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2976390", Offset = "0x2976390", VA = "0x2976390")]
	public void SetDispatchPeriod(int dispatchPeriod)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2976398", Offset = "0x2976398", VA = "0x2976398")]
	public void SetLogLevelValue(GoogleAnalyticsV4.DebugMode logLevel)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x297639C", Offset = "0x297639C", VA = "0x297639C")]
	public void SetAnonymizeIP(bool anonymizeIP)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x29763A8", Offset = "0x29763A8", VA = "0x29763A8")]
	public void SetAdIdCollection(bool adIdCollection)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x29763B4", Offset = "0x29763B4", VA = "0x29763B4")]
	public void SetDryRun(bool dryRun)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x29763C0", Offset = "0x29763C0", VA = "0x29763C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x29763FC", Offset = "0x29763FC", VA = "0x29763FC")]
	public GoogleAnalyticsAndroidV4()
	{
	}
}
[Token(Token = "0x2000009")]
public class GoogleAnalyticsMPV3
{
	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADC360", Offset = "0xADC360")]
	private sealed class <HandleWWW>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x20")]
		public WWW request;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x28")]
		public GoogleAnalyticsMPV3 <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x297BD10", Offset = "0x297BD10", VA = "0x297BD10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x297BD58", Offset = "0x297BD58", VA = "0x297BD58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x29776FC", Offset = "0x29776FC", VA = "0x29776FC")]
		[DebuggerHidden]
		public <HandleWWW>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x297BA48", Offset = "0x297BA48", VA = "0x297BA48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x297BA4C", Offset = "0x297BA4C", VA = "0x297BA4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x297BD18", Offset = "0x297BD18", VA = "0x297BD18", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x10")]
	private string trackingCode;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x18")]
	private string bundleIdentifier;

	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x20")]
	private string appName;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x28")]
	private string appVersion;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x30")]
	private GoogleAnalyticsV4.DebugMode logLevel;

	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x34")]
	private bool anonymizeIP;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x35")]
	private bool dryRun;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x36")]
	private bool optOut;

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x38")]
	private int sessionTimeout;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x40")]
	private string screenRes;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x48")]
	private string clientId;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x50")]
	private string url;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x58")]
	private float timeStarted;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<Field, object> trackerValues;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x68")]
	private bool startSessionOnNextHit;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x69")]
	private bool endSessionOnNextHit;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x6A")]
	private bool trackingCodeSet;

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2976404", Offset = "0x2976404", VA = "0x2976404")]
	public void InitializeTracker()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2977018", Offset = "0x2977018", VA = "0x2977018")]
	public void SetTrackerVal(Field field, object value)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2977084", Offset = "0x2977084", VA = "0x2977084")]
	private string AddTrackerVals()
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2977200", Offset = "0x2977200", VA = "0x2977200")]
	internal void StartSession()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x297720C", Offset = "0x297720C", VA = "0x297720C")]
	internal void StopSession()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x2977218", Offset = "0x2977218", VA = "0x2977218")]
	private void SendGaHitWithMeasurementProtocol(string url)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2977668", Offset = "0x2977668", VA = "0x2977668")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADC6B8", Offset = "0xADC6B8")]
	public IEnumerator HandleWWW(WWW request)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2977728", Offset = "0x2977728", VA = "0x2977728")]
	private string AddRequiredMPParameter(Field parameter, object value)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x2976D7C", Offset = "0x2976D7C", VA = "0x2976D7C")]
	private string AddRequiredMPParameter(Field parameter, string value)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2976F50", Offset = "0x2976F50", VA = "0x2976F50")]
	private string AddOptionalMPParameter(Field parameter, object value)
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x29775A0", Offset = "0x29775A0", VA = "0x29775A0")]
	private string AddOptionalMPParameter(Field parameter, string value)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	private string AddCustomVariables<T>(HitBuilder<T> builder)
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	private string AddCampaignParameters<T>(HitBuilder<T> builder)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2977908", Offset = "0x2977908", VA = "0x2977908")]
	public void LogScreen(AppViewHitBuilder builder)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2977BEC", Offset = "0x2977BEC", VA = "0x2977BEC")]
	public void LogEvent(EventHitBuilder builder)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x2978050", Offset = "0x2978050", VA = "0x2978050")]
	public void LogTransaction(TransactionHitBuilder builder)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x29785CC", Offset = "0x29785CC", VA = "0x29785CC")]
	public void LogItem(ItemHitBuilder builder)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x2978BB4", Offset = "0x2978BB4", VA = "0x2978BB4")]
	public void LogException(ExceptionHitBuilder builder)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2978E80", Offset = "0x2978E80", VA = "0x2978E80")]
	public void LogSocial(SocialHitBuilder builder)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x2979244", Offset = "0x2979244", VA = "0x2979244")]
	public void LogTiming(TimingHitBuilder builder)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x29796A8", Offset = "0x29796A8", VA = "0x29796A8")]
	public void ClearUserIDOverride()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x2979718", Offset = "0x2979718", VA = "0x2979718")]
	public void SetTrackingCode(string trackingCode)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2979720", Offset = "0x2979720", VA = "0x2979720")]
	public void SetBundleIdentifier(string bundleIdentifier)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x2979728", Offset = "0x2979728", VA = "0x2979728")]
	public void SetAppName(string appName)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2979730", Offset = "0x2979730", VA = "0x2979730")]
	public void SetAppVersion(string appVersion)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x2979738", Offset = "0x2979738", VA = "0x2979738")]
	public void SetLogLevelValue(GoogleAnalyticsV4.DebugMode logLevel)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x2979740", Offset = "0x2979740", VA = "0x2979740")]
	public void SetAnonymizeIP(bool anonymizeIP)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x297974C", Offset = "0x297974C", VA = "0x297974C")]
	public void SetDryRun(bool dryRun)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2979758", Offset = "0x2979758", VA = "0x2979758")]
	public void SetOptOut(bool optOut)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2979764", Offset = "0x2979764", VA = "0x2979764")]
	public GoogleAnalyticsMPV3()
	{
	}
}
[Token(Token = "0x200000B")]
public class GoogleAnalyticsV4 : MonoBehaviour
{
	[Token(Token = "0x200000C")]
	public enum DebugMode
	{
		[Token(Token = "0x4000084")]
		ERROR,
		[Token(Token = "0x4000085")]
		WARNING,
		[Token(Token = "0x4000086")]
		INFO,
		[Token(Token = "0x4000087")]
		VERBOSE
	}

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x18")]
	private string uncaughtExceptionStackTrace;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x20")]
	private bool initialized;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADC370", Offset = "0xADC370")]
	public string androidTrackingCode;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADC3A8", Offset = "0xADC3A8")]
	public string IOSTrackingCode;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADC3E0", Offset = "0xADC3E0")]
	public string otherTrackingCode;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADC418", Offset = "0xADC418")]
	public string productName;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADC450", Offset = "0xADC450")]
	public string bundleIdentifier;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADC488", Offset = "0xADC488")]
	public string bundleVersion;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "RangedTooltipAttribute", RVA = "0xADC4C0", Offset = "0xADC4C0")]
	public int dispatchPeriod;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "RangedTooltipAttribute", RVA = "0xADC504", Offset = "0xADC504")]
	public int sampleFrequency;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADC548", Offset = "0xADC548")]
	public DebugMode logLevel;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADC580", Offset = "0xADC580")]
	public bool anonymizeIP;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x65")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADC5B8", Offset = "0xADC5B8")]
	public bool UncaughtExceptionReporting;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x66")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADC5F0", Offset = "0xADC5F0")]
	public bool sendLaunchEvent;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x67")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADC628", Offset = "0xADC628")]
	public bool dryRun;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADC660", Offset = "0xADC660")]
	public int sessionTimeout;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x6C")]
	[AdvertiserOptIn]
	public bool enableAdId;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x0")]
	public static GoogleAnalyticsV4 instance;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x8")]
	[HideInInspector]
	public static readonly string currencySymbol;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string EVENT_HIT;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string APP_VIEW;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string SET;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string SET_ALL;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string SEND;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string ITEM_HIT;

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x40")]
	public static readonly string TRANSACTION_HIT;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x48")]
	public static readonly string SOCIAL_HIT;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x50")]
	public static readonly string TIMING_HIT;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x58")]
	public static readonly string EXCEPTION_HIT;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x70")]
	private GoogleAnalyticsMPV3 mpTracker;

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x29797F0", Offset = "0x29797F0", VA = "0x29797F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2979C90", Offset = "0x2979C90", VA = "0x2979C90")]
	private void Update()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x2979D78", Offset = "0x2979D78", VA = "0x2979D78")]
	private void HandleException(string condition, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x2979968", Offset = "0x2979968", VA = "0x2979968")]
	private void InitializeTracker()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x2979E90", Offset = "0x2979E90", VA = "0x2979E90")]
	public void SetAppLevelOptOut(bool optOut)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2979EC8", Offset = "0x2979EC8", VA = "0x2979EC8")]
	public void SetUserIDOverride(string userID)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x2979F44", Offset = "0x2979F44", VA = "0x2979F44")]
	public void ClearUserIDOverride()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x2979F70", Offset = "0x2979F70", VA = "0x2979F70")]
	public void DispatchHits()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2979F74", Offset = "0x2979F74", VA = "0x2979F74")]
	public void StartSession()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x2979FA8", Offset = "0x2979FA8", VA = "0x2979FA8")]
	public void StopSession()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x2979E4C", Offset = "0x2979E4C", VA = "0x2979E4C")]
	public void SetOnTracker(Field fieldName, object value)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x2979FDC", Offset = "0x2979FDC", VA = "0x2979FDC")]
	public void LogScreen(string title)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x297A060", Offset = "0x297A060", VA = "0x297A060")]
	public void LogScreen(AppViewHitBuilder builder)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x2979BCC", Offset = "0x2979BCC", VA = "0x2979BCC")]
	public void LogEvent(string eventCategory, string eventAction, string eventLabel, long value)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x297A160", Offset = "0x297A160", VA = "0x297A160")]
	public void LogEvent(EventHitBuilder builder)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x297A260", Offset = "0x297A260", VA = "0x297A260")]
	public void LogTransaction(string transID, string affiliation, double revenue, double tax, double shipping)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x297A2EC", Offset = "0x297A2EC", VA = "0x297A2EC")]
	public void LogTransaction(string transID, string affiliation, double revenue, double tax, double shipping, string currencyCode)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x297A504", Offset = "0x297A504", VA = "0x297A504")]
	public void LogTransaction(TransactionHitBuilder builder)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x297A604", Offset = "0x297A604", VA = "0x297A604")]
	public void LogItem(string transID, string name, string sku, string category, double price, long quantity)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x297A60C", Offset = "0x297A60C", VA = "0x297A60C")]
	public void LogItem(string transID, string name, string sku, string category, double price, long quantity, string currencyCode)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x297A8C8", Offset = "0x297A8C8", VA = "0x297A8C8")]
	public void LogItem(ItemHitBuilder builder)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x2979CE8", Offset = "0x2979CE8", VA = "0x2979CE8")]
	public void LogException(string exceptionDescription, bool isFatal)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x297A9C8", Offset = "0x297A9C8", VA = "0x297A9C8")]
	public void LogException(ExceptionHitBuilder builder)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x297AAC8", Offset = "0x297AAC8", VA = "0x297AAC8")]
	public void LogSocial(string socialNetwork, string socialAction, string socialTarget)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x297ACA4", Offset = "0x297ACA4", VA = "0x297ACA4")]
	public void LogSocial(SocialHitBuilder builder)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x297ADA4", Offset = "0x297ADA4", VA = "0x297ADA4")]
	public void LogTiming(string timingCategory, long timingInterval, string timingName, string timingLabel)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x297AF90", Offset = "0x297AF90", VA = "0x297AF90")]
	public void LogTiming(TimingHitBuilder builder)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x297B090", Offset = "0x297B090", VA = "0x297B090")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x2976D28", Offset = "0x2976D28", VA = "0x2976D28")]
	public static bool belowThreshold(DebugMode userLogLevel, DebugMode comparelogLevel)
	{
		return default(bool);
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x297B098", Offset = "0x297B098", VA = "0x297B098")]
	public static GoogleAnalyticsV4 getInstance()
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x297B0FC", Offset = "0x297B0FC", VA = "0x297B0FC")]
	public GoogleAnalyticsV4()
	{
	}
}
[Token(Token = "0x200000D")]
public class GoogleAnalyticsiOSV3
{
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x297B38C", Offset = "0x297B38C", VA = "0x297B38C")]
	public GoogleAnalyticsiOSV3()
	{
	}
}
[Token(Token = "0x200000E")]
public class AppViewHitBuilder : HitBuilder<AppViewHitBuilder>
{
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x60")]
	private string screenName;

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x2971AF0", Offset = "0x2971AF0", VA = "0x2971AF0")]
	public string GetScreenName()
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x2971AF8", Offset = "0x2971AF8", VA = "0x2971AF8")]
	public AppViewHitBuilder SetScreenName(string screenName)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x2971B28", Offset = "0x2971B28", VA = "0x2971B28", Slot = "4")]
	public override AppViewHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x2971B2C", Offset = "0x2971B2C", VA = "0x2971B2C", Slot = "5")]
	public override AppViewHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x2971BC0", Offset = "0x2971BC0", VA = "0x2971BC0")]
	public AppViewHitBuilder()
	{
	}
}
[Token(Token = "0x200000F")]
public class EventHitBuilder : HitBuilder<EventHitBuilder>
{
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x60")]
	private string eventCategory;

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x68")]
	private string eventAction;

	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x70")]
	private string eventLabel;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x78")]
	private long eventValue;

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x2971C30", Offset = "0x2971C30", VA = "0x2971C30")]
	public string GetEventCategory()
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x2971C38", Offset = "0x2971C38", VA = "0x2971C38")]
	public EventHitBuilder SetEventCategory(string eventCategory)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x2971C68", Offset = "0x2971C68", VA = "0x2971C68")]
	public string GetEventAction()
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x2971C70", Offset = "0x2971C70", VA = "0x2971C70")]
	public EventHitBuilder SetEventAction(string eventAction)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x2971CA0", Offset = "0x2971CA0", VA = "0x2971CA0")]
	public string GetEventLabel()
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x2971CA8", Offset = "0x2971CA8", VA = "0x2971CA8")]
	public EventHitBuilder SetEventLabel(string eventLabel)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x2971CD8", Offset = "0x2971CD8", VA = "0x2971CD8")]
	public long GetEventValue()
	{
		return default(long);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x2971CE0", Offset = "0x2971CE0", VA = "0x2971CE0")]
	public EventHitBuilder SetEventValue(long eventValue)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x2971CE8", Offset = "0x2971CE8", VA = "0x2971CE8", Slot = "4")]
	public override EventHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x2971CEC", Offset = "0x2971CEC", VA = "0x2971CEC", Slot = "5")]
	public override EventHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2971DC8", Offset = "0x2971DC8", VA = "0x2971DC8")]
	public EventHitBuilder()
	{
	}
}
[Token(Token = "0x2000010")]
public class ExceptionHitBuilder : HitBuilder<ExceptionHitBuilder>
{
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x60")]
	private string exceptionDescription;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x68")]
	private bool fatal;

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x2971E58", Offset = "0x2971E58", VA = "0x2971E58")]
	public string GetExceptionDescription()
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2971E60", Offset = "0x2971E60", VA = "0x2971E60")]
	public ExceptionHitBuilder SetExceptionDescription(string exceptionDescription)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x2971E90", Offset = "0x2971E90", VA = "0x2971E90")]
	public bool IsFatal()
	{
		return default(bool);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2971E98", Offset = "0x2971E98", VA = "0x2971E98")]
	public ExceptionHitBuilder SetFatal(bool fatal)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2971EA4", Offset = "0x2971EA4", VA = "0x2971EA4", Slot = "4")]
	public override ExceptionHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x2971EA8", Offset = "0x2971EA8", VA = "0x2971EA8", Slot = "5")]
	public override ExceptionHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x2971EAC", Offset = "0x2971EAC", VA = "0x2971EAC")]
	public ExceptionHitBuilder()
	{
	}
}
[Token(Token = "0x2000011")]
public abstract class HitBuilder<T>
{
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<int, string> customDimensions;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x0")]
	private Dictionary<int, float> customMetrics;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x0")]
	private string campaignName;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x0")]
	private string campaignSource;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x0")]
	private string campaignMedium;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x0")]
	private string campaignKeyword;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x0")]
	private string campaignContent;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x0")]
	private string campaignID;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x0")]
	private string gclid;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x0")]
	private string dclid;

	[Token(Token = "0x6000080")]
	public abstract T GetThis();

	[Token(Token = "0x6000081")]
	public abstract T Validate();

	[Token(Token = "0x6000082")]
	public T SetCustomDimension(int dimensionNumber, string value)
	{
		return (T)null;
	}

	[Token(Token = "0x6000083")]
	public Dictionary<int, string> GetCustomDimensions()
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	public T SetCustomMetric(int metricNumber, float value)
	{
		return (T)null;
	}

	[Token(Token = "0x6000085")]
	public Dictionary<int, float> GetCustomMetrics()
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	public string GetCampaignName()
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	public T SetCampaignName(string campaignName)
	{
		return (T)null;
	}

	[Token(Token = "0x6000088")]
	public string GetCampaignSource()
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	public T SetCampaignSource(string campaignSource)
	{
		return (T)null;
	}

	[Token(Token = "0x600008A")]
	public string GetCampaignMedium()
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	public T SetCampaignMedium(string campaignMedium)
	{
		return (T)null;
	}

	[Token(Token = "0x600008C")]
	public string GetCampaignKeyword()
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	public T SetCampaignKeyword(string campaignKeyword)
	{
		return (T)null;
	}

	[Token(Token = "0x600008E")]
	public string GetCampaignContent()
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	public T SetCampaignContent(string campaignContent)
	{
		return (T)null;
	}

	[Token(Token = "0x6000090")]
	public string GetCampaignID()
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	public T SetCampaignID(string campaignID)
	{
		return (T)null;
	}

	[Token(Token = "0x6000092")]
	public string GetGclid()
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	public T SetGclid(string gclid)
	{
		return (T)null;
	}

	[Token(Token = "0x6000094")]
	public string GetDclid()
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	public T SetDclid(string dclid)
	{
		return (T)null;
	}

	[Token(Token = "0x6000096")]
	protected HitBuilder()
	{
	}
}
[Token(Token = "0x2000012")]
public class ItemHitBuilder : HitBuilder<ItemHitBuilder>
{
	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x60")]
	private string transactionID;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x68")]
	private string name;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x70")]
	private string SKU;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x78")]
	private double price;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x80")]
	private string category;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x88")]
	private long quantity;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x90")]
	private string currencyCode;

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x297B394", Offset = "0x297B394", VA = "0x297B394")]
	public string GetTransactionID()
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x297A7C8", Offset = "0x297A7C8", VA = "0x297A7C8")]
	public ItemHitBuilder SetTransactionID(string transactionID)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x297B39C", Offset = "0x297B39C", VA = "0x297B39C")]
	public string GetName()
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x297A7F8", Offset = "0x297A7F8", VA = "0x297A7F8")]
	public ItemHitBuilder SetName(string name)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x297B3A4", Offset = "0x297B3A4", VA = "0x297B3A4")]
	public string GetSKU()
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x297A828", Offset = "0x297A828", VA = "0x297A828")]
	public ItemHitBuilder SetSKU(string SKU)
	{
		return null;
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x297B3AC", Offset = "0x297B3AC", VA = "0x297B3AC")]
	public double GetPrice()
	{
		return default(double);
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x297A888", Offset = "0x297A888", VA = "0x297A888")]
	public ItemHitBuilder SetPrice(double price)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x297B3B4", Offset = "0x297B3B4", VA = "0x297B3B4")]
	public string GetCategory()
	{
		return null;
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x297A858", Offset = "0x297A858", VA = "0x297A858")]
	public ItemHitBuilder SetCategory(string category)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x297B3BC", Offset = "0x297B3BC", VA = "0x297B3BC")]
	public long GetQuantity()
	{
		return default(long);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x297A890", Offset = "0x297A890", VA = "0x297A890")]
	public ItemHitBuilder SetQuantity(long quantity)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x297B3C4", Offset = "0x297B3C4", VA = "0x297B3C4")]
	public string GetCurrencyCode()
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x297A898", Offset = "0x297A898", VA = "0x297A898")]
	public ItemHitBuilder SetCurrencyCode(string currencyCode)
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x297B3CC", Offset = "0x297B3CC", VA = "0x297B3CC", Slot = "4")]
	public override ItemHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x297B3D0", Offset = "0x297B3D0", VA = "0x297B3D0", Slot = "5")]
	public override ItemHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x297A718", Offset = "0x297A718", VA = "0x297A718")]
	public ItemHitBuilder()
	{
	}
}
[Token(Token = "0x2000013")]
public class SocialHitBuilder : HitBuilder<SocialHitBuilder>
{
	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x60")]
	private string socialNetwork;

	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x68")]
	private string socialAction;

	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x70")]
	private string socialTarget;

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x297B5D8", Offset = "0x297B5D8", VA = "0x297B5D8")]
	public string GetSocialNetwork()
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x297AC14", Offset = "0x297AC14", VA = "0x297AC14")]
	public SocialHitBuilder SetSocialNetwork(string socialNetwork)
	{
		return null;
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x297B5E0", Offset = "0x297B5E0", VA = "0x297B5E0")]
	public string GetSocialAction()
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x297AC44", Offset = "0x297AC44", VA = "0x297AC44")]
	public SocialHitBuilder SetSocialAction(string socialAction)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x297B5E8", Offset = "0x297B5E8", VA = "0x297B5E8")]
	public string GetSocialTarget()
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x297AC74", Offset = "0x297AC74", VA = "0x297AC74")]
	public SocialHitBuilder SetSocialTarget(string socialTarget)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x297B5F0", Offset = "0x297B5F0", VA = "0x297B5F0", Slot = "4")]
	public override SocialHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x297B5F4", Offset = "0x297B5F4", VA = "0x297B5F4", Slot = "5")]
	public override SocialHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x297AB84", Offset = "0x297AB84", VA = "0x297AB84")]
	public SocialHitBuilder()
	{
	}
}
[Token(Token = "0x2000014")]
public class TimingHitBuilder : HitBuilder<TimingHitBuilder>
{
	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x60")]
	private string timingCategory;

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x68")]
	private long timingInterval;

	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x70")]
	private string timingName;

	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x78")]
	private string timingLabel;

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x297B718", Offset = "0x297B718", VA = "0x297B718")]
	public string GetTimingCategory()
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x297AEF8", Offset = "0x297AEF8", VA = "0x297AEF8")]
	public TimingHitBuilder SetTimingCategory(string timingCategory)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x297B720", Offset = "0x297B720", VA = "0x297B720")]
	public long GetTimingInterval()
	{
		return default(long);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x297AF28", Offset = "0x297AF28", VA = "0x297AF28")]
	public TimingHitBuilder SetTimingInterval(long timingInterval)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x297B728", Offset = "0x297B728", VA = "0x297B728")]
	public string GetTimingName()
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x297AF30", Offset = "0x297AF30", VA = "0x297AF30")]
	public TimingHitBuilder SetTimingName(string timingName)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x297B730", Offset = "0x297B730", VA = "0x297B730")]
	public string GetTimingLabel()
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x297AF60", Offset = "0x297AF60", VA = "0x297AF60")]
	public TimingHitBuilder SetTimingLabel(string timingLabel)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x297B738", Offset = "0x297B738", VA = "0x297B738", Slot = "4")]
	public override TimingHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x297B73C", Offset = "0x297B73C", VA = "0x297B73C", Slot = "5")]
	public override TimingHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x297AE68", Offset = "0x297AE68", VA = "0x297AE68")]
	public TimingHitBuilder()
	{
	}
}
[Token(Token = "0x2000015")]
public class TransactionHitBuilder : HitBuilder<TransactionHitBuilder>
{
	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x60")]
	private string transactionID;

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x68")]
	private string affiliation;

	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x70")]
	private double revenue;

	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x78")]
	private double tax;

	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x80")]
	private double shipping;

	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x88")]
	private string currencyCode;

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x297B850", Offset = "0x297B850", VA = "0x297B850")]
	public string GetTransactionID()
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x297A45C", Offset = "0x297A45C", VA = "0x297A45C")]
	public TransactionHitBuilder SetTransactionID(string transactionID)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x297B858", Offset = "0x297B858", VA = "0x297B858")]
	public string GetAffiliation()
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x297A48C", Offset = "0x297A48C", VA = "0x297A48C")]
	public TransactionHitBuilder SetAffiliation(string affiliation)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x297B860", Offset = "0x297B860", VA = "0x297B860")]
	public double GetRevenue()
	{
		return default(double);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x297A4BC", Offset = "0x297A4BC", VA = "0x297A4BC")]
	public TransactionHitBuilder SetRevenue(double revenue)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x297B868", Offset = "0x297B868", VA = "0x297B868")]
	public double GetTax()
	{
		return default(double);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x297A4C4", Offset = "0x297A4C4", VA = "0x297A4C4")]
	public TransactionHitBuilder SetTax(double tax)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x297B870", Offset = "0x297B870", VA = "0x297B870")]
	public double GetShipping()
	{
		return default(double);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x297A4CC", Offset = "0x297A4CC", VA = "0x297A4CC")]
	public TransactionHitBuilder SetShipping(double shipping)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x297B878", Offset = "0x297B878", VA = "0x297B878")]
	public string GetCurrencyCode()
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x297A4D4", Offset = "0x297A4D4", VA = "0x297A4D4")]
	public TransactionHitBuilder SetCurrencyCode(string currencyCode)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x297B880", Offset = "0x297B880", VA = "0x297B880", Slot = "4")]
	public override TransactionHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x297B884", Offset = "0x297B884", VA = "0x297B884", Slot = "5")]
	public override TransactionHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x297A3CC", Offset = "0x297A3CC", VA = "0x297A3CC")]
	public TransactionHitBuilder()
	{
	}
}
