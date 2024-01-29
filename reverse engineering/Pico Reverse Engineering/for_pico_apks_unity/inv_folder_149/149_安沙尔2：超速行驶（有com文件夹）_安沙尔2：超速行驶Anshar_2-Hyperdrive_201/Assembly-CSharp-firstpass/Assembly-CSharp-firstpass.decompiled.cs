using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class BatcherCSharp : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<MeshFilter> meshFilters;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Vector3> totalVertices;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Vector3> initialVerticesPositions;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector2> totalUvs;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Vector3> totalNormals;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<int> totalTriangles;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Mesh thisMesh;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 position;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion rotation;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3[] vertices;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3[] initVertices;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int vertexCount;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Matrix4x4 m;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1C57EE8", Offset = "0x1C57EE8", VA = "0x1C57EE8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1C584C8", Offset = "0x1C584C8", VA = "0x1C584C8")]
	private void GenerateTriangles()
	{
	}

	[PreserveSig]
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1C5881C", Offset = "0x1C5881C", VA = "0x1C5881C")]
	private static extern void TestMultiply([In][Out] ref Vector3 outputVertices, [In] ref Matrix4x4 localToWorldMatrix, [In] ref Vector3 inputVector, int count, int indexStart);

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1C58684", Offset = "0x1C58684", VA = "0x1C58684")]
	private void UpdateMeshValuesVertexPositions()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1C588CC", Offset = "0x1C588CC", VA = "0x1C588CC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1C588D0", Offset = "0x1C588D0", VA = "0x1C588D0")]
	private void Update2()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1C589E0", Offset = "0x1C589E0", VA = "0x1C589E0")]
	public BatcherCSharp()
	{
	}
}
[Token(Token = "0x2000003")]
public class RangedTooltipAttribute : PropertyAttribute
{
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly float min;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public readonly float max;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly string text;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1AEDB30", Offset = "0x1AEDB30", VA = "0x1AEDB30")]
	public RangedTooltipAttribute(string text, float min, float max)
	{
	}
}
[Token(Token = "0x2000004")]
public class TooltipAttribute : PropertyAttribute
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly string text;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xED7BB0", Offset = "0xED7BB0", VA = "0xED7BB0")]
	public TooltipAttribute(string text)
	{
	}
}
[Token(Token = "0x2000005")]
public class Field
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly string parameter;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1CA0944", Offset = "0x1CA0944", VA = "0x1CA0944")]
	public Field(string parameter)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1CA0978", Offset = "0x1CA0978", VA = "0x1CA0978", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000006")]
public class Fields
{
	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly Field ANONYMIZE_IP;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly Field HIT_TYPE;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly Field SESSION_CONTROL;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly Field SCREEN_NAME;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly Field LOCATION;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly Field REFERRER;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly Field PAGE;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static readonly Field HOSTNAME;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static readonly Field TITLE;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static readonly Field LANGUAGE;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static readonly Field ENCODING;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static readonly Field SCREEN_COLORS;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static readonly Field SCREEN_RESOLUTION;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static readonly Field VIEWPORT_SIZE;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static readonly Field APP_NAME;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static readonly Field APP_ID;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static readonly Field APP_INSTALLER_ID;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static readonly Field APP_VERSION;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static readonly Field CLIENT_ID;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static readonly Field USER_ID;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static readonly Field CAMPAIGN_NAME;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static readonly Field CAMPAIGN_SOURCE;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public static readonly Field CAMPAIGN_MEDIUM;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public static readonly Field CAMPAIGN_KEYWORD;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public static readonly Field CAMPAIGN_CONTENT;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public static readonly Field CAMPAIGN_ID;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public static readonly Field GCLID;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public static readonly Field DCLID;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public static readonly Field EVENT_CATEGORY;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public static readonly Field EVENT_ACTION;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public static readonly Field EVENT_LABEL;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public static readonly Field EVENT_VALUE;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public static readonly Field SOCIAL_NETWORK;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public static readonly Field SOCIAL_ACTION;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public static readonly Field SOCIAL_TARGET;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public static readonly Field TIMING_VAR;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public static readonly Field TIMING_VALUE;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public static readonly Field TIMING_CATEGORY;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public static readonly Field TIMING_LABEL;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public static readonly Field EX_DESCRIPTION;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public static readonly Field EX_FATAL;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public static readonly Field CURRENCY_CODE;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public static readonly Field TRANSACTION_ID;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public static readonly Field TRANSACTION_AFFILIATION;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public static readonly Field TRANSACTION_SHIPPING;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public static readonly Field TRANSACTION_TAX;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public static readonly Field TRANSACTION_REVENUE;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public static readonly Field ITEM_SKU;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public static readonly Field ITEM_NAME;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public static readonly Field ITEM_CATEGORY;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public static readonly Field ITEM_PRICE;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public static readonly Field ITEM_QUANTITY;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public static readonly Field TRACKING_ID;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public static readonly Field SAMPLE_RATE;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public static readonly Field DEVELOPER_ID;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public static readonly Field CUSTOM_METRIC;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public static readonly Field CUSTOM_DIMENSION;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1CA0980", Offset = "0x1CA0980", VA = "0x1CA0980")]
	public Fields()
	{
	}
}
[Token(Token = "0x2000007")]
public class GAIHandler
{
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x19D0104", Offset = "0x19D0104", VA = "0x19D0104")]
	public GAIHandler()
	{
	}
}
[Token(Token = "0x2000008")]
public class GoogleAnalyticsAndroidV3 : IDisposable
{
	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string trackingCode;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string appVersion;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string appName;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string bundleIdentifier;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int dispatchPeriod;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int sampleFrequency;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GoogleAnalyticsV3.DebugMode logLevel;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool anonymizeIP;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	private bool dryRun;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int sessionTimeout;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AndroidJavaObject tracker;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AndroidJavaObject logger;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AndroidJavaObject currentActivityObject;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private AndroidJavaObject googleAnalyticsSingleton;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private AndroidJavaObject gaServiceManagerSingleton;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private AndroidJavaClass analyticsTrackingFields;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool startSessionOnNextHit;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	private bool endSessionOnNextHit;

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x19D1814", Offset = "0x19D1814", VA = "0x19D1814")]
	internal void InitializeTracker()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x19D2140", Offset = "0x19D2140", VA = "0x19D2140")]
	internal void SetTrackerVal(Field fieldName, object value)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x19D2C58", Offset = "0x19D2C58", VA = "0x19D2C58")]
	public void SetSampleFrequency(int sampleFrequency)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x19D228C", Offset = "0x19D228C", VA = "0x19D228C")]
	private void SetLogLevel(GoogleAnalyticsV3.DebugMode logLevel)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x19D2C60", Offset = "0x19D2C60", VA = "0x19D2C60")]
	private void SetSessionOnBuilder(AndroidJavaObject hitBuilder)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x19D2F14", Offset = "0x19D2F14", VA = "0x19D2F14")]
	private AndroidJavaObject BuildMap(string methodName)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x19D32DC", Offset = "0x19D32DC", VA = "0x19D32DC")]
	private AndroidJavaObject BuildMap(string methodName, object[] args)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x19D3620", Offset = "0x19D3620", VA = "0x19D3620")]
	private AndroidJavaObject BuildMap(string methodName, Dictionary<AndroidJavaObject, string> parameters)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x19D362C", Offset = "0x19D362C", VA = "0x19D362C")]
	private AndroidJavaObject BuildMap(string methodName, object[] simpleArgs, Dictionary<AndroidJavaObject, string> parameters)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	private Dictionary<AndroidJavaObject, string> AddCustomVariablesAndCampaignParameters<T>(HitBuilder<T> builder)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x19D442C", Offset = "0x19D442C", VA = "0x19D442C")]
	internal void StartSession()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x19D4438", Offset = "0x19D4438", VA = "0x19D4438")]
	internal void StopSession()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x19D4444", Offset = "0x19D4444", VA = "0x19D4444")]
	public void SetOptOut(bool optOut)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x19D454C", Offset = "0x19D454C", VA = "0x19D454C")]
	internal void LogScreen(AppViewHitBuilder builder)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x19D4984", Offset = "0x19D4984", VA = "0x19D4984")]
	internal void LogEvent(EventHitBuilder builder)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x19D4E5C", Offset = "0x19D4E5C", VA = "0x19D4E5C")]
	internal void LogTransaction(TransactionHitBuilder builder)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x19D5460", Offset = "0x19D5460", VA = "0x19D5460")]
	internal void LogItem(ItemHitBuilder builder)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x19D5918", Offset = "0x19D5918", VA = "0x19D5918")]
	public void LogException(ExceptionHitBuilder builder)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x19D5BF8", Offset = "0x19D5BF8", VA = "0x19D5BF8")]
	public void DispatchHits()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x19D5CF4", Offset = "0x19D5CF4", VA = "0x19D5CF4")]
	public void LogSocial(SocialHitBuilder builder)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x19D5F50", Offset = "0x19D5F50", VA = "0x19D5F50")]
	public void LogTiming(TimingHitBuilder builder)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x19D6428", Offset = "0x19D6428", VA = "0x19D6428")]
	public void ClearUserIDOverride()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x19D6498", Offset = "0x19D6498", VA = "0x19D6498")]
	public void SetTrackingCode(string trackingCode)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x19D64A0", Offset = "0x19D64A0", VA = "0x19D64A0")]
	public void SetAppName(string appName)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x19D64A8", Offset = "0x19D64A8", VA = "0x19D64A8")]
	public void SetBundleIdentifier(string bundleIdentifier)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x19D64B0", Offset = "0x19D64B0", VA = "0x19D64B0")]
	public void SetAppVersion(string appVersion)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x19D64B8", Offset = "0x19D64B8", VA = "0x19D64B8")]
	public void SetDispatchPeriod(int dispatchPeriod)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x19D64C0", Offset = "0x19D64C0", VA = "0x19D64C0")]
	public void SetLogLevelValue(GoogleAnalyticsV3.DebugMode logLevel)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x19D64C8", Offset = "0x19D64C8", VA = "0x19D64C8")]
	public void SetAnonymizeIP(bool anonymizeIP)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x19D64D4", Offset = "0x19D64D4", VA = "0x19D64D4")]
	public void SetDryRun(bool dryRun)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x19D64E0", Offset = "0x19D64E0", VA = "0x19D64E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x19D652C", Offset = "0x19D652C", VA = "0x19D652C")]
	public GoogleAnalyticsAndroidV3()
	{
	}
}
[Token(Token = "0x2000009")]
public class GoogleAnalyticsMPV3
{
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x19D6534", Offset = "0x19D6534", VA = "0x19D6534")]
	public GoogleAnalyticsMPV3()
	{
	}
}
[Token(Token = "0x200000A")]
public class GoogleAnalyticsV3 : MonoBehaviour
{
	[Token(Token = "0x200000B")]
	public enum DebugMode
	{
		[Token(Token = "0x400007C")]
		ERROR,
		[Token(Token = "0x400007D")]
		WARNING,
		[Token(Token = "0x400007E")]
		INFO,
		[Token(Token = "0x400007F")]
		VERBOSE
	}

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string uncaughtExceptionStackTrace;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool initialized;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E87E8", Offset = "0x7E87E8")]
	public string androidTrackingCode;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8820", Offset = "0x7E8820")]
	public string IOSTrackingCode;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8858", Offset = "0x7E8858")]
	public string otherTrackingCode;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8890", Offset = "0x7E8890")]
	public string productName;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E88C8", Offset = "0x7E88C8")]
	public string bundleIdentifier;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8900", Offset = "0x7E8900")]
	public string bundleVersion;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "RangedTooltipAttribute", RVA = "0x7E8938", Offset = "0x7E8938")]
	public int dispatchPeriod;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "RangedTooltipAttribute", RVA = "0x7E897C", Offset = "0x7E897C")]
	public int sampleFrequency;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E89C0", Offset = "0x7E89C0")]
	public DebugMode logLevel;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E89F8", Offset = "0x7E89F8")]
	public bool anonymizeIP;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8A30", Offset = "0x7E8A30")]
	public bool UncaughtExceptionReporting;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8A68", Offset = "0x7E8A68")]
	public bool sendLaunchEvent;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8AA0", Offset = "0x7E8AA0")]
	public bool dryRun;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8AD8", Offset = "0x7E8AD8")]
	public int sessionTimeout;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static GoogleAnalyticsV3 instance;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[HideInInspector]
	public static readonly string currencySymbol;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string EVENT_HIT;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string APP_VIEW;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly string SET;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly string SET_ALL;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly string SEND;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static readonly string ITEM_HIT;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static readonly string TRANSACTION_HIT;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static readonly string SOCIAL_HIT;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static readonly string TIMING_HIT;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static readonly string EXCEPTION_HIT;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GoogleAnalyticsAndroidV3 androidTracker;

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x19D653C", Offset = "0x19D653C", VA = "0x19D653C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x19D69F0", Offset = "0x19D69F0", VA = "0x19D69F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x19D6AD0", Offset = "0x19D6AD0", VA = "0x19D6AD0")]
	private void HandleException(string condition, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x19D66B4", Offset = "0x19D66B4", VA = "0x19D66B4")]
	private void InitializeTracker()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x19D6BE8", Offset = "0x19D6BE8", VA = "0x19D6BE8")]
	public void SetAppLevelOptOut(bool optOut)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x19D6C1C", Offset = "0x19D6C1C", VA = "0x19D6C1C")]
	public void SetUserIDOverride(string userID)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x19D6C98", Offset = "0x19D6C98", VA = "0x19D6C98")]
	public void ClearUserIDOverride()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x19D6CC4", Offset = "0x19D6CC4", VA = "0x19D6CC4")]
	public void DispatchHits()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x19D6CF0", Offset = "0x19D6CF0", VA = "0x19D6CF0")]
	public void StartSession()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x19D6D24", Offset = "0x19D6D24", VA = "0x19D6D24")]
	public void StopSession()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x19D6BA4", Offset = "0x19D6BA4", VA = "0x19D6BA4")]
	public void SetOnTracker(Field fieldName, object value)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x19D6D58", Offset = "0x19D6D58", VA = "0x19D6D58")]
	public void LogScreen(string title)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x19D6DDC", Offset = "0x19D6DDC", VA = "0x19D6DDC")]
	public void LogScreen(AppViewHitBuilder builder)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x19D68D4", Offset = "0x19D68D4", VA = "0x19D68D4")]
	public void LogEvent(string eventCategory, string eventAction, string eventLabel, long value)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x19D6EDC", Offset = "0x19D6EDC", VA = "0x19D6EDC")]
	public void LogEvent(EventHitBuilder builder)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x19D6FDC", Offset = "0x19D6FDC", VA = "0x19D6FDC")]
	public void LogTransaction(string transID, string affiliation, double revenue, double tax, double shipping)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x19D7068", Offset = "0x19D7068", VA = "0x19D7068")]
	public void LogTransaction(string transID, string affiliation, double revenue, double tax, double shipping, string currencyCode)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x19D7168", Offset = "0x19D7168", VA = "0x19D7168")]
	public void LogTransaction(TransactionHitBuilder builder)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x19D7268", Offset = "0x19D7268", VA = "0x19D7268")]
	public void LogItem(string transID, string name, string sku, string category, double price, long quantity)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x19D7270", Offset = "0x19D7270", VA = "0x19D7270")]
	public void LogItem(string transID, string name, string sku, string category, double price, long quantity, string currencyCode)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x19D7384", Offset = "0x19D7384", VA = "0x19D7384")]
	public void LogItem(ItemHitBuilder builder)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x19D6A38", Offset = "0x19D6A38", VA = "0x19D6A38")]
	public void LogException(string exceptionDescription, bool isFatal)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x19D7484", Offset = "0x19D7484", VA = "0x19D7484")]
	public void LogException(ExceptionHitBuilder builder)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x19D7584", Offset = "0x19D7584", VA = "0x19D7584")]
	public void LogSocial(string socialNetwork, string socialAction, string socialTarget)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x19D7638", Offset = "0x19D7638", VA = "0x19D7638")]
	public void LogSocial(SocialHitBuilder builder)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x19D7738", Offset = "0x19D7738", VA = "0x19D7738")]
	public void LogTiming(string timingCategory, long timingInterval, string timingName, string timingLabel)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x19D7800", Offset = "0x19D7800", VA = "0x19D7800")]
	public void LogTiming(TimingHitBuilder builder)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x19D7900", Offset = "0x19D7900", VA = "0x19D7900")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x19D699C", Offset = "0x19D699C", VA = "0x19D699C")]
	public static bool belowThreshold(DebugMode userLogLevel, DebugMode comparelogLevel)
	{
		return default(bool);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x19D7920", Offset = "0x19D7920", VA = "0x19D7920")]
	public static GoogleAnalyticsV3 getInstance()
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x19D7984", Offset = "0x19D7984", VA = "0x19D7984")]
	public GoogleAnalyticsV3()
	{
	}
}
[Token(Token = "0x200000C")]
public class GoogleAnalyticsiOSV3
{
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x19D7C18", Offset = "0x19D7C18", VA = "0x19D7C18")]
	public GoogleAnalyticsiOSV3()
	{
	}
}
[Token(Token = "0x200000D")]
public class AppViewHitBuilder : HitBuilder<AppViewHitBuilder>
{
	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string screenName;

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1C5328C", Offset = "0x1C5328C", VA = "0x1C5328C")]
	public string GetScreenName()
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1C53294", Offset = "0x1C53294", VA = "0x1C53294")]
	public AppViewHitBuilder SetScreenName(string screenName)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1C532C4", Offset = "0x1C532C4", VA = "0x1C532C4", Slot = "4")]
	public override AppViewHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1C532C8", Offset = "0x1C532C8", VA = "0x1C532C8", Slot = "5")]
	public override AppViewHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1C5335C", Offset = "0x1C5335C", VA = "0x1C5335C")]
	public AppViewHitBuilder()
	{
	}
}
[Token(Token = "0x200000E")]
public class EventHitBuilder : HitBuilder<EventHitBuilder>
{
	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string eventCategory;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string eventAction;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string eventLabel;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private long eventValue;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1C98530", Offset = "0x1C98530", VA = "0x1C98530")]
	public string GetEventCategory()
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1C98538", Offset = "0x1C98538", VA = "0x1C98538")]
	public EventHitBuilder SetEventCategory(string eventCategory)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1C98568", Offset = "0x1C98568", VA = "0x1C98568")]
	public string GetEventAction()
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1C98570", Offset = "0x1C98570", VA = "0x1C98570")]
	public EventHitBuilder SetEventAction(string eventAction)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1C985A0", Offset = "0x1C985A0", VA = "0x1C985A0")]
	public string GetEventLabel()
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1C985A8", Offset = "0x1C985A8", VA = "0x1C985A8")]
	public EventHitBuilder SetEventLabel(string eventLabel)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1C985D8", Offset = "0x1C985D8", VA = "0x1C985D8")]
	public long GetEventValue()
	{
		return default(long);
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1C985E0", Offset = "0x1C985E0", VA = "0x1C985E0")]
	public EventHitBuilder SetEventValue(long eventValue)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1C985E8", Offset = "0x1C985E8", VA = "0x1C985E8", Slot = "4")]
	public override EventHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1C985EC", Offset = "0x1C985EC", VA = "0x1C985EC", Slot = "5")]
	public override EventHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1C986C8", Offset = "0x1C986C8", VA = "0x1C986C8")]
	public EventHitBuilder()
	{
	}
}
[Token(Token = "0x200000F")]
public class ExceptionHitBuilder : HitBuilder<ExceptionHitBuilder>
{
	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string exceptionDescription;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool fatal;

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1C98758", Offset = "0x1C98758", VA = "0x1C98758")]
	public string GetExceptionDescription()
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1C98760", Offset = "0x1C98760", VA = "0x1C98760")]
	public ExceptionHitBuilder SetExceptionDescription(string exceptionDescription)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1C98790", Offset = "0x1C98790", VA = "0x1C98790")]
	public bool IsFatal()
	{
		return default(bool);
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1C98798", Offset = "0x1C98798", VA = "0x1C98798")]
	public ExceptionHitBuilder SetFatal(bool fatal)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1C987A4", Offset = "0x1C987A4", VA = "0x1C987A4", Slot = "4")]
	public override ExceptionHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1C987A8", Offset = "0x1C987A8", VA = "0x1C987A8", Slot = "5")]
	public override ExceptionHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1C987AC", Offset = "0x1C987AC", VA = "0x1C987AC")]
	public ExceptionHitBuilder()
	{
	}
}
[Token(Token = "0x2000010")]
public abstract class HitBuilder<T>
{
	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Dictionary<int, string> customDimensions;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Dictionary<int, string> customMetrics;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private string campaignName;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private string campaignSource;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private string campaignMedium;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private string campaignKeyword;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private string campaignContent;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private string campaignID;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private string gclid;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private string dclid;

	[Token(Token = "0x6000068")]
	public abstract T GetThis();

	[Token(Token = "0x6000069")]
	public abstract T Validate();

	[Token(Token = "0x600006A")]
	public T SetCustomDimension(int dimensionNumber, string value)
	{
		return (T)null;
	}

	[Token(Token = "0x600006B")]
	public Dictionary<int, string> GetCustomDimensions()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	public T SetCustomMetric(int metricNumber, string value)
	{
		return (T)null;
	}

	[Token(Token = "0x600006D")]
	public Dictionary<int, string> GetCustomMetrics()
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	public string GetCampaignName()
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	public T SetCampaignName(string campaignName)
	{
		return (T)null;
	}

	[Token(Token = "0x6000070")]
	public string GetCampaignSource()
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	public T SetCampaignSource(string campaignSource)
	{
		return (T)null;
	}

	[Token(Token = "0x6000072")]
	public string GetCampaignMedium()
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	public T SetCampaignMedium(string campaignMedium)
	{
		return (T)null;
	}

	[Token(Token = "0x6000074")]
	public string GetCampaignKeyword()
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	public T SetCampaignKeyword(string campaignKeyword)
	{
		return (T)null;
	}

	[Token(Token = "0x6000076")]
	public string GetCampaignContent()
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	public T SetCampaignContent(string campaignContent)
	{
		return (T)null;
	}

	[Token(Token = "0x6000078")]
	public string GetCampaignID()
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	public T SetCampaignID(string campaignID)
	{
		return (T)null;
	}

	[Token(Token = "0x600007A")]
	public string GetGclid()
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	public T SetGclid(string gclid)
	{
		return (T)null;
	}

	[Token(Token = "0x600007C")]
	public string GetDclid()
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	public T SetDclid(string dclid)
	{
		return (T)null;
	}

	[Token(Token = "0x600007E")]
	protected HitBuilder()
	{
	}
}
[Token(Token = "0x2000011")]
public class ItemHitBuilder : HitBuilder<ItemHitBuilder>
{
	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string transactionID;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string name;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string SKU;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private double price;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private string category;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private long quantity;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string currencyCode;

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1BB94E8", Offset = "0x1BB94E8", VA = "0x1BB94E8")]
	public string GetTransactionID()
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1BB94F0", Offset = "0x1BB94F0", VA = "0x1BB94F0")]
	public ItemHitBuilder SetTransactionID(string transactionID)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1BB9520", Offset = "0x1BB9520", VA = "0x1BB9520")]
	public string GetName()
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1BB9528", Offset = "0x1BB9528", VA = "0x1BB9528")]
	public ItemHitBuilder SetName(string name)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1BB9558", Offset = "0x1BB9558", VA = "0x1BB9558")]
	public string GetSKU()
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1BB9560", Offset = "0x1BB9560", VA = "0x1BB9560")]
	public ItemHitBuilder SetSKU(string SKU)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1BB9590", Offset = "0x1BB9590", VA = "0x1BB9590")]
	public double GetPrice()
	{
		return default(double);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1BB9598", Offset = "0x1BB9598", VA = "0x1BB9598")]
	public ItemHitBuilder SetPrice(double price)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1BB95A0", Offset = "0x1BB95A0", VA = "0x1BB95A0")]
	public string GetCategory()
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1BB95A8", Offset = "0x1BB95A8", VA = "0x1BB95A8")]
	public ItemHitBuilder SetCategory(string category)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1BB95D8", Offset = "0x1BB95D8", VA = "0x1BB95D8")]
	public long GetQuantity()
	{
		return default(long);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1BB95E0", Offset = "0x1BB95E0", VA = "0x1BB95E0")]
	public ItemHitBuilder SetQuantity(long quantity)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1BB95E8", Offset = "0x1BB95E8", VA = "0x1BB95E8")]
	public string GetCurrencyCode()
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1BB95F0", Offset = "0x1BB95F0", VA = "0x1BB95F0")]
	public ItemHitBuilder SetCurrencyCode(string currencyCode)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1BB9620", Offset = "0x1BB9620", VA = "0x1BB9620", Slot = "4")]
	public override ItemHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1BB9624", Offset = "0x1BB9624", VA = "0x1BB9624", Slot = "5")]
	public override ItemHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1BB97E0", Offset = "0x1BB97E0", VA = "0x1BB97E0")]
	public ItemHitBuilder()
	{
	}
}
[Token(Token = "0x2000012")]
public class SocialHitBuilder : HitBuilder<SocialHitBuilder>
{
	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string socialNetwork;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string socialAction;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string socialTarget;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1AF4038", Offset = "0x1AF4038", VA = "0x1AF4038")]
	public string GetSocialNetwork()
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1AF4040", Offset = "0x1AF4040", VA = "0x1AF4040")]
	public SocialHitBuilder SetSocialNetwork(string socialNetwork)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1AF4070", Offset = "0x1AF4070", VA = "0x1AF4070")]
	public string GetSocialAction()
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1AF4078", Offset = "0x1AF4078", VA = "0x1AF4078")]
	public SocialHitBuilder SetSocialAction(string socialAction)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1AF40A8", Offset = "0x1AF40A8", VA = "0x1AF40A8")]
	public string GetSocialTarget()
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1AF40B0", Offset = "0x1AF40B0", VA = "0x1AF40B0")]
	public SocialHitBuilder SetSocialTarget(string socialTarget)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1AF40E0", Offset = "0x1AF40E0", VA = "0x1AF40E0", Slot = "4")]
	public override SocialHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1AF40E4", Offset = "0x1AF40E4", VA = "0x1AF40E4", Slot = "5")]
	public override SocialHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1AF4208", Offset = "0x1AF4208", VA = "0x1AF4208")]
	public SocialHitBuilder()
	{
	}
}
[Token(Token = "0x2000013")]
public class TimingHitBuilder : HitBuilder<TimingHitBuilder>
{
	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string timingCategory;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private long timingInterval;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string timingName;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string timingLabel;

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xED7984", Offset = "0xED7984", VA = "0xED7984")]
	public string GetTimingCategory()
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xED798C", Offset = "0xED798C", VA = "0xED798C")]
	public TimingHitBuilder SetTimingCategory(string timingCategory)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xED79BC", Offset = "0xED79BC", VA = "0xED79BC")]
	public long GetTimingInterval()
	{
		return default(long);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xED79C4", Offset = "0xED79C4", VA = "0xED79C4")]
	public TimingHitBuilder SetTimingInterval(long timingInterval)
	{
		return null;
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xED79CC", Offset = "0xED79CC", VA = "0xED79CC")]
	public string GetTimingName()
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xED79D4", Offset = "0xED79D4", VA = "0xED79D4")]
	public TimingHitBuilder SetTimingName(string timingName)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xED7A04", Offset = "0xED7A04", VA = "0xED7A04")]
	public string GetTimingLabel()
	{
		return null;
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xED7A0C", Offset = "0xED7A0C", VA = "0xED7A0C")]
	public TimingHitBuilder SetTimingLabel(string timingLabel)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xED7A3C", Offset = "0xED7A3C", VA = "0xED7A3C", Slot = "4")]
	public override TimingHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xED7A40", Offset = "0xED7A40", VA = "0xED7A40", Slot = "5")]
	public override TimingHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xED7B20", Offset = "0xED7B20", VA = "0xED7B20")]
	public TimingHitBuilder()
	{
	}
}
[Token(Token = "0x2000014")]
public class TransactionHitBuilder : HitBuilder<TransactionHitBuilder>
{
	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string transactionID;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string affiliation;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private double revenue;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private double tax;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private double shipping;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private string currencyCode;

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xED7DA0", Offset = "0xED7DA0", VA = "0xED7DA0")]
	public string GetTransactionID()
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xED7DA8", Offset = "0xED7DA8", VA = "0xED7DA8")]
	public TransactionHitBuilder SetTransactionID(string transactionID)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xED7DD8", Offset = "0xED7DD8", VA = "0xED7DD8")]
	public string GetAffiliation()
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xED7DE0", Offset = "0xED7DE0", VA = "0xED7DE0")]
	public TransactionHitBuilder SetAffiliation(string affiliation)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xED7E10", Offset = "0xED7E10", VA = "0xED7E10")]
	public double GetRevenue()
	{
		return default(double);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xED7E18", Offset = "0xED7E18", VA = "0xED7E18")]
	public TransactionHitBuilder SetRevenue(double revenue)
	{
		return null;
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xED7E20", Offset = "0xED7E20", VA = "0xED7E20")]
	public double GetTax()
	{
		return default(double);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xED7E28", Offset = "0xED7E28", VA = "0xED7E28")]
	public TransactionHitBuilder SetTax(double tax)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xED7E30", Offset = "0xED7E30", VA = "0xED7E30")]
	public double GetShipping()
	{
		return default(double);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xED7E38", Offset = "0xED7E38", VA = "0xED7E38")]
	public TransactionHitBuilder SetShipping(double shipping)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xED7E40", Offset = "0xED7E40", VA = "0xED7E40")]
	public string GetCurrencyCode()
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xED7E48", Offset = "0xED7E48", VA = "0xED7E48")]
	public TransactionHitBuilder SetCurrencyCode(string currencyCode)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xED7E78", Offset = "0xED7E78", VA = "0xED7E78", Slot = "4")]
	public override TransactionHitBuilder GetThis()
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xED7E7C", Offset = "0xED7E7C", VA = "0xED7E7C", Slot = "5")]
	public override TransactionHitBuilder Validate()
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xED8040", Offset = "0xED8040", VA = "0xED8040")]
	public TransactionHitBuilder()
	{
	}
}
[Token(Token = "0x2000015")]
public class MoveSample : MonoBehaviour
{
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1AE7418", Offset = "0x1AE7418", VA = "0x1AE7418")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1AE779C", Offset = "0x1AE779C", VA = "0x1AE779C")]
	public MoveSample()
	{
	}
}
[Token(Token = "0x2000016")]
public class RotateSample : MonoBehaviour
{
	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1AEEE94", Offset = "0x1AEEE94", VA = "0x1AEEE94")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1AEF204", Offset = "0x1AEF204", VA = "0x1AEF204")]
	public RotateSample()
	{
	}
}
[Token(Token = "0x2000017")]
public class SampleInfo : MonoBehaviour
{
	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1AF22DC", Offset = "0x1AF22DC", VA = "0x1AF22DC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1AF25B0", Offset = "0x1AF25B0", VA = "0x1AF25B0")]
	public SampleInfo()
	{
	}
}
[Token(Token = "0x2000018")]
public class iTween : MonoBehaviour
{
	[Token(Token = "0x2000019")]
	private delegate float EasingFunction(float start, float end, float Value);

	[Token(Token = "0x200001A")]
	private delegate void ApplyTween();

	[Token(Token = "0x200001B")]
	public enum EaseType
	{
		[Token(Token = "0x40000CB")]
		easeInQuad,
		[Token(Token = "0x40000CC")]
		easeOutQuad,
		[Token(Token = "0x40000CD")]
		easeInOutQuad,
		[Token(Token = "0x40000CE")]
		easeInCubic,
		[Token(Token = "0x40000CF")]
		easeOutCubic,
		[Token(Token = "0x40000D0")]
		easeInOutCubic,
		[Token(Token = "0x40000D1")]
		easeInQuart,
		[Token(Token = "0x40000D2")]
		easeOutQuart,
		[Token(Token = "0x40000D3")]
		easeInOutQuart,
		[Token(Token = "0x40000D4")]
		easeInQuint,
		[Token(Token = "0x40000D5")]
		easeOutQuint,
		[Token(Token = "0x40000D6")]
		easeInOutQuint,
		[Token(Token = "0x40000D7")]
		easeInSine,
		[Token(Token = "0x40000D8")]
		easeOutSine,
		[Token(Token = "0x40000D9")]
		easeInOutSine,
		[Token(Token = "0x40000DA")]
		easeInExpo,
		[Token(Token = "0x40000DB")]
		easeOutExpo,
		[Token(Token = "0x40000DC")]
		easeInOutExpo,
		[Token(Token = "0x40000DD")]
		easeInCirc,
		[Token(Token = "0x40000DE")]
		easeOutCirc,
		[Token(Token = "0x40000DF")]
		easeInOutCirc,
		[Token(Token = "0x40000E0")]
		linear,
		[Token(Token = "0x40000E1")]
		spring,
		[Token(Token = "0x40000E2")]
		easeInBounce,
		[Token(Token = "0x40000E3")]
		easeOutBounce,
		[Token(Token = "0x40000E4")]
		easeInOutBounce,
		[Token(Token = "0x40000E5")]
		easeInBack,
		[Token(Token = "0x40000E6")]
		easeOutBack,
		[Token(Token = "0x40000E7")]
		easeInOutBack,
		[Token(Token = "0x40000E8")]
		easeInElastic,
		[Token(Token = "0x40000E9")]
		easeOutElastic,
		[Token(Token = "0x40000EA")]
		easeInOutElastic,
		[Token(Token = "0x40000EB")]
		punch
	}

	[Token(Token = "0x200001C")]
	public enum LoopType
	{
		[Token(Token = "0x40000ED")]
		none,
		[Token(Token = "0x40000EE")]
		loop,
		[Token(Token = "0x40000EF")]
		pingPong
	}

	[Token(Token = "0x200001D")]
	public enum NamedValueColor
	{
		[Token(Token = "0x40000F1")]
		_Color,
		[Token(Token = "0x40000F2")]
		_SpecColor,
		[Token(Token = "0x40000F3")]
		_Emission,
		[Token(Token = "0x40000F4")]
		_ReflectColor
	}

	[Token(Token = "0x200001E")]
	public static class Defaults
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float time;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float delay;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static NamedValueColor namedColorValue;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static LoopType loopType;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static EaseType easeType;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float lookSpeed;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool isLocal;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static Space space;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool orientToPath;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static Color color;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static float updateTimePercentage;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static float updateTime;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static float lookAhead;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static bool useRealTime;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static Vector3 up;
	}

	[Token(Token = "0x200001F")]
	private class CRSpline
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3[] pts;

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2006308", Offset = "0x2006308", VA = "0x2006308")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2006398", Offset = "0x2006398", VA = "0x2006398")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E775C", Offset = "0x7E775C")]
	private sealed class <TweenDelay>d__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x2005EFC", Offset = "0x2005EFC", VA = "0x2005EFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x2005F44", Offset = "0x2005F44", VA = "0x2005F44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2005DF0", Offset = "0x2005DF0", VA = "0x2005DF0")]
		[DebuggerHidden]
		public <TweenDelay>d__145(int <>1__state)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2005E1C", Offset = "0x2005E1C", VA = "0x2005E1C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2005E20", Offset = "0x2005E20", VA = "0x2005E20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2005F04", Offset = "0x2005F04", VA = "0x2005F04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E776C", Offset = "0x7E776C")]
	private sealed class <TweenRestart>d__147 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x2006060", Offset = "0x2006060", VA = "0x2006060", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x20060A8", Offset = "0x20060A8", VA = "0x20060A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2005F4C", Offset = "0x2005F4C", VA = "0x2005F4C")]
		[DebuggerHidden]
		public <TweenRestart>d__147(int <>1__state)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2005F78", Offset = "0x2005F78", VA = "0x2005F78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2005F7C", Offset = "0x2005F7C", VA = "0x2005F7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2006068", Offset = "0x2006068", VA = "0x2006068", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E777C", Offset = "0x7E777C")]
	private sealed class <Start>d__229 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x2005DA0", Offset = "0x2005DA0", VA = "0x2005DA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x2005DE8", Offset = "0x2005DE8", VA = "0x2005DE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2005CBC", Offset = "0x2005CBC", VA = "0x2005CBC")]
		[DebuggerHidden]
		public <Start>d__229(int <>1__state)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2005CE8", Offset = "0x2005CE8", VA = "0x2005CE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2005CEC", Offset = "0x2005CEC", VA = "0x2005CEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2005DA8", Offset = "0x2005DA8", VA = "0x2005DA8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<Hashtable> tweens;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string id;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string type;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string method;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public EaseType easeType;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float time;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float delay;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public LoopType loopType;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isRunning;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool isPaused;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string _name;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float runningTime;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float percentage;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float delayStarted;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool kinematic;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	private bool isLocal;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
	private bool loop;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
	private bool reverse;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool wasPaused;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool physics;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Hashtable tweenArguments;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Space space;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private EasingFunction ease;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private ApplyTween apply;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private AudioSource audioSource;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3[] vector3s;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector2[] vector2s;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Color[,] colors;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float[] floats;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Rect[] rects;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private CRSpline path;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Vector3 preUpdate;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private Vector3 postUpdate;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private NamedValueColor namedcolorvalue;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float lastRealTime;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool useRealTime;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Transform thisTransform;

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xEE1270", Offset = "0xEE1270", VA = "0xEE1270")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xEE1540", Offset = "0xEE1540", VA = "0xEE1540")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xEE26BC", Offset = "0xEE26BC", VA = "0xEE26BC")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xEE2A14", Offset = "0xEE2A14", VA = "0xEE2A14")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xEE35B4", Offset = "0xEE35B4", VA = "0xEE35B4")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xEE37C8", Offset = "0xEE37C8", VA = "0xEE37C8")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xEE3DEC", Offset = "0xEE3DEC", VA = "0xEE3DEC")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xEE2A84", Offset = "0xEE2A84", VA = "0xEE2A84")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xEE4038", Offset = "0xEE4038", VA = "0xEE4038")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xEE3838", Offset = "0xEE3838", VA = "0xEE3838")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xEE4284", Offset = "0xEE4284", VA = "0xEE4284")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xEE453C", Offset = "0xEE453C", VA = "0xEE453C")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xEE49F4", Offset = "0xEE49F4", VA = "0xEE49F4")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xEE4CAC", Offset = "0xEE4CAC", VA = "0xEE4CAC")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xEE4E4C", Offset = "0xEE4E4C", VA = "0xEE4E4C")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xEE5044", Offset = "0xEE5044", VA = "0xEE5044")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xEE5108", Offset = "0xEE5108", VA = "0xEE5108")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xEE5344", Offset = "0xEE5344", VA = "0xEE5344")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xEE5AC4", Offset = "0xEE5AC4", VA = "0xEE5AC4")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xEE5D00", Offset = "0xEE5D00", VA = "0xEE5D00")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xEE6058", Offset = "0xEE6058", VA = "0xEE6058")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xEE6294", Offset = "0xEE6294", VA = "0xEE6294")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xEE6648", Offset = "0xEE6648", VA = "0xEE6648")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xEE6884", Offset = "0xEE6884", VA = "0xEE6884")]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xEE7250", Offset = "0xEE7250", VA = "0xEE7250")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xEE748C", Offset = "0xEE748C", VA = "0xEE748C")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xEE1304", Offset = "0xEE1304", VA = "0xEE1304")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xEE7594", Offset = "0xEE7594", VA = "0xEE7594")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xEE769C", Offset = "0xEE769C", VA = "0xEE769C")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xEE78D8", Offset = "0xEE78D8", VA = "0xEE78D8")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xEE7C78", Offset = "0xEE7C78", VA = "0xEE7C78")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xEE7EB4", Offset = "0xEE7EB4", VA = "0xEE7EB4")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xEE83F8", Offset = "0xEE83F8", VA = "0xEE83F8")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xEE8634", Offset = "0xEE8634", VA = "0xEE8634")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xEE873C", Offset = "0xEE873C", VA = "0xEE873C")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xEE8978", Offset = "0xEE8978", VA = "0xEE8978")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xEE8A80", Offset = "0xEE8A80", VA = "0xEE8A80")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xEE8CBC", Offset = "0xEE8CBC", VA = "0xEE8CBC")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xEE9070", Offset = "0xEE9070", VA = "0xEE9070")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xEE92AC", Offset = "0xEE92AC", VA = "0xEE92AC")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xEE98D8", Offset = "0xEE98D8", VA = "0xEE98D8")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xEE9B14", Offset = "0xEE9B14", VA = "0xEE9B14")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xEE9C1C", Offset = "0xEE9C1C", VA = "0xEE9C1C")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xEE9E58", Offset = "0xEE9E58", VA = "0xEE9E58")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xEE9F60", Offset = "0xEE9F60", VA = "0xEE9F60")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xEEA19C", Offset = "0xEEA19C", VA = "0xEEA19C")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xEEA2A4", Offset = "0xEEA2A4", VA = "0xEEA2A4")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xEEA4E0", Offset = "0xEEA4E0", VA = "0xEEA4E0")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xEEA5E8", Offset = "0xEEA5E8", VA = "0xEEA5E8")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xEEA824", Offset = "0xEEA824", VA = "0xEEA824")]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xEEA92C", Offset = "0xEEA92C", VA = "0xEEA92C")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xEEAB68", Offset = "0xEEAB68", VA = "0xEEAB68")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xEEACCC", Offset = "0xEEACCC", VA = "0xEEACCC")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xEEAF08", Offset = "0xEEAF08", VA = "0xEEAF08")]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xEEB06C", Offset = "0xEEB06C", VA = "0xEEB06C")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xEEB2A8", Offset = "0xEEB2A8", VA = "0xEEB2A8")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xEEB40C", Offset = "0xEEB40C", VA = "0xEEB40C")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xEEC700", Offset = "0xEEC700", VA = "0xEEC700")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xEEC568", Offset = "0xEEC568", VA = "0xEEC568")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xEEC2F8", Offset = "0xEEC2F8", VA = "0xEEC2F8")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xEEC094", Offset = "0xEEC094", VA = "0xEEC094")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xEEBE5C", Offset = "0xEEBE5C", VA = "0xEEBE5C")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xEEC868", Offset = "0xEEC868", VA = "0xEEC868")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xEED280", Offset = "0xEED280", VA = "0xEED280")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xEF244C", Offset = "0xEF244C", VA = "0xEF244C")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xEF1AF0", Offset = "0xEF1AF0", VA = "0xEF1AF0")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xEED5F4", Offset = "0xEED5F4", VA = "0xEED5F4")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xEEDD08", Offset = "0xEEDD08", VA = "0xEEDD08")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xEEE3C0", Offset = "0xEEE3C0", VA = "0xEEE3C0")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xEEE9D0", Offset = "0xEEE9D0", VA = "0xEEE9D0")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xEEEF70", Offset = "0xEEEF70", VA = "0xEEEF70")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xEEF3B4", Offset = "0xEEF3B4", VA = "0xEEF3B4")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xEEF7EC", Offset = "0xEEF7EC", VA = "0xEEF7EC")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xEEFED0", Offset = "0xEEFED0", VA = "0xEEFED0")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xEF0310", Offset = "0xEF0310", VA = "0xEF0310")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xEF078C", Offset = "0xEF078C", VA = "0xEF078C")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xEF0AD0", Offset = "0xEF0AD0", VA = "0xEF0AD0")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xEF0DE8", Offset = "0xEF0DE8", VA = "0xEF0DE8")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xEF1100", Offset = "0xEF1100", VA = "0xEF1100")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xEF1470", Offset = "0xEF1470", VA = "0xEF1470")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xEF17B4", Offset = "0xEF17B4", VA = "0xEF17B4")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xEF2B74", Offset = "0xEF2B74", VA = "0xEF2B74")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xEF2E7C", Offset = "0xEF2E7C", VA = "0xEF2E7C")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xEF30B4", Offset = "0xEF30B4", VA = "0xEF30B4")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xEF32B0", Offset = "0xEF32B0", VA = "0xEF32B0")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xEF3458", Offset = "0xEF3458", VA = "0xEF3458")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xEF35B8", Offset = "0xEF35B8", VA = "0xEF35B8")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xEF3B38", Offset = "0xEF3B38", VA = "0xEF3B38")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xEF3CA4", Offset = "0xEF3CA4", VA = "0xEF3CA4")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xEF3CA8", Offset = "0xEF3CA8", VA = "0xEF3CA8")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xEF3FD8", Offset = "0xEF3FD8", VA = "0xEF3FD8")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xEF41E0", Offset = "0xEF41E0", VA = "0xEF41E0")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xEF44CC", Offset = "0xEF44CC", VA = "0xEF44CC")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xEF4634", Offset = "0xEF4634", VA = "0xEF4634")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xEF4774", Offset = "0xEF4774", VA = "0xEF4774")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xEF49B0", Offset = "0xEF49B0", VA = "0xEF49B0")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xEF4BB8", Offset = "0xEF4BB8", VA = "0xEF4BB8")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xEF4F30", Offset = "0xEF4F30", VA = "0xEF4F30")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xEF50D0", Offset = "0xEF50D0", VA = "0xEF50D0")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xEF5300", Offset = "0xEF5300", VA = "0xEF5300")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xEF5864", Offset = "0xEF5864", VA = "0xEF5864")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xEF5C7C", Offset = "0xEF5C7C", VA = "0xEF5C7C")]
	private void ApplyPunchScaleTargets()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xEF5FBC", Offset = "0xEF5FBC", VA = "0xEF5FBC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F2F08", Offset = "0x7F2F08")]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xEF6034", Offset = "0xEF6034", VA = "0xEF6034")]
	private void TweenStart()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xEF6AC4", Offset = "0xEF6AC4", VA = "0xEF6AC4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F2F68", Offset = "0x7F2F68")]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xEF6B3C", Offset = "0xEF6B3C", VA = "0xEF6B3C")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xEF6C1C", Offset = "0xEF6C1C", VA = "0xEF6C1C")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xEF6D00", Offset = "0xEF6D00", VA = "0xEF6D00")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xEF6DA0", Offset = "0xEF6DA0", VA = "0xEF6DA0")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xEF6F64", Offset = "0xEF6F64", VA = "0xEF6F64")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xEF6FD0", Offset = "0xEF6FD0", VA = "0xEF6FD0")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xEF6F24", Offset = "0xEF6F24", VA = "0xEF6F24")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xEF7020", Offset = "0xEF7020", VA = "0xEF7020")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xEF7B54", Offset = "0xEF7B54", VA = "0xEF7B54")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xEF70F4", Offset = "0xEF70F4", VA = "0xEF70F4")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xEF7D68", Offset = "0xEF7D68", VA = "0xEF7D68")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xEF7FB4", Offset = "0xEF7FB4", VA = "0xEF7FB4")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xEF8490", Offset = "0xEF8490", VA = "0xEF8490")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xEF8748", Offset = "0xEF8748", VA = "0xEF8748")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xEF8DC8", Offset = "0xEF8DC8", VA = "0xEF8DC8")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xEF9004", Offset = "0xEF9004", VA = "0xEF9004")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xEF9654", Offset = "0xEF9654", VA = "0xEF9654")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xEF9890", Offset = "0xEF9890", VA = "0xEF9890")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xEFAB88", Offset = "0xEFAB88", VA = "0xEFAB88")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xEFA1AC", Offset = "0xEFA1AC", VA = "0xEFA1AC")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xEFADC4", Offset = "0xEFADC4", VA = "0xEFADC4")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xEFB000", Offset = "0xEFB000", VA = "0xEFB000")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xEF2A2C", Offset = "0xEF2A2C", VA = "0xEF2A2C")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xEFB59C", Offset = "0xEFB59C", VA = "0xEFB59C")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xEFB648", Offset = "0xEFB648", VA = "0xEFB648")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xEFB6DC", Offset = "0xEFB6DC", VA = "0xEFB6DC")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xEFB81C", Offset = "0xEFB81C", VA = "0xEFB81C")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xEFB944", Offset = "0xEFB944", VA = "0xEFB944")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xEFBA58", Offset = "0xEFBA58", VA = "0xEFBA58")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xEFBCF0", Offset = "0xEFBCF0", VA = "0xEFBCF0")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xEFBDBC", Offset = "0xEFBDBC", VA = "0xEFBDBC")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xEFBF50", Offset = "0xEFBF50", VA = "0xEFBF50")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xEFC0B8", Offset = "0xEFC0B8", VA = "0xEFC0B8")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xEFC1B0", Offset = "0xEFC1B0", VA = "0xEFC1B0")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xEFC27C", Offset = "0xEFC27C", VA = "0xEFC27C")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xEFC410", Offset = "0xEFC410", VA = "0xEFC410")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xEFC578", Offset = "0xEFC578", VA = "0xEFC578")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xEFC670", Offset = "0xEFC670", VA = "0xEFC670")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xEFC73C", Offset = "0xEFC73C", VA = "0xEFC73C")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xEFC8D0", Offset = "0xEFC8D0", VA = "0xEFC8D0")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xEFCA38", Offset = "0xEFCA38", VA = "0xEFCA38")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xEFCAAC", Offset = "0xEFCAAC", VA = "0xEFCAAC")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xEFCDC4", Offset = "0xEFCDC4", VA = "0xEFCDC4")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xEFCE90", Offset = "0xEFCE90", VA = "0xEFCE90")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xEFD024", Offset = "0xEFD024", VA = "0xEFD024")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xEFD18C", Offset = "0xEFD18C", VA = "0xEFD18C")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xEFD284", Offset = "0xEFD284", VA = "0xEFD284")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xEFD350", Offset = "0xEFD350", VA = "0xEFD350")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xEFD4E4", Offset = "0xEFD4E4", VA = "0xEFD4E4")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xEFD64C", Offset = "0xEFD64C", VA = "0xEFD64C")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xEFD744", Offset = "0xEFD744", VA = "0xEFD744")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xEFD810", Offset = "0xEFD810", VA = "0xEFD810")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xEFD9A4", Offset = "0xEFD9A4", VA = "0xEFD9A4")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xEFDB0C", Offset = "0xEFDB0C", VA = "0xEFDB0C")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xEFDC04", Offset = "0xEFDC04", VA = "0xEFDC04")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xEFDF04", Offset = "0xEFDF04", VA = "0xEFDF04")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xEFE064", Offset = "0xEFE064", VA = "0xEFE064")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xEFE468", Offset = "0xEFE468", VA = "0xEFE468")]
	public static void Resume()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xEFE5B4", Offset = "0xEFE5B4", VA = "0xEFE5B4")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xEFE81C", Offset = "0xEFE81C", VA = "0xEFE81C")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xEFE97C", Offset = "0xEFE97C", VA = "0xEFE97C")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xEFEC7C", Offset = "0xEFEC7C", VA = "0xEFEC7C")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xEFEE3C", Offset = "0xEFEE3C", VA = "0xEFEE3C")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xEFF298", Offset = "0xEFF298", VA = "0xEFF298")]
	public static void Pause()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xEFF3E4", Offset = "0xEFF3E4", VA = "0xEFF3E4")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xEFF64C", Offset = "0xEFF64C", VA = "0xEFF64C")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xEFF6C8", Offset = "0xEFF6C8", VA = "0xEFF6C8")]
	public static int Count(string type)
	{
		return default(int);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xEFF8DC", Offset = "0xEFF8DC", VA = "0xEFF8DC")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xEFF93C", Offset = "0xEFF93C", VA = "0xEFF93C")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xEFFAA0", Offset = "0xEFFAA0", VA = "0xEFFAA0")]
	public static void Stop()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xEFFD18", Offset = "0xEFFD18", VA = "0xEFFD18")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xF000D8", Offset = "0xF000D8", VA = "0xF000D8")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xEFFC28", Offset = "0xEFFC28", VA = "0xEFFC28")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xF00458", Offset = "0xF00458", VA = "0xF00458")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xEFFF80", Offset = "0xEFFF80", VA = "0xEFFF80")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xF00340", Offset = "0xF00340", VA = "0xF00340")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xF00758", Offset = "0xF00758", VA = "0xF00758")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xF00B54", Offset = "0xF00B54", VA = "0xF00B54")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xEE28D0", Offset = "0xEE28D0", VA = "0xEE28D0")]
	public static Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xF00F08", Offset = "0xF00F08", VA = "0xF00F08")]
	private iTween(Hashtable h)
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xF00F3C", Offset = "0xF00F3C", VA = "0xF00F3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xF02324", Offset = "0xF02324", VA = "0xF02324")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F2FC8", Offset = "0x7F2FC8")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xF0239C", Offset = "0xF0239C", VA = "0xF0239C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xF023DC", Offset = "0xF023DC", VA = "0xF023DC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xF0241C", Offset = "0xF0241C", VA = "0xF0241C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xF0255C", Offset = "0xF0255C", VA = "0xF0255C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xF025D4", Offset = "0xF025D4", VA = "0xF025D4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xEFBB50", Offset = "0xEFBB50", VA = "0xEFBB50")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xEFCBA4", Offset = "0xEFCBA4", VA = "0xEFCBA4")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xEFB1D8", Offset = "0xEFB1D8", VA = "0xEFB1D8")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xEFB3E8", Offset = "0xEFB3E8", VA = "0xEFB3E8")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xEE253C", Offset = "0xEE253C", VA = "0xEE253C")]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xEE1B20", Offset = "0xEE1B20", VA = "0xEE1B20")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xF025D8", Offset = "0xF025D8", VA = "0xF025D8")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xF00F84", Offset = "0xF00F84", VA = "0xF00F84")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xF02654", Offset = "0xF02654", VA = "0xF02654")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xEF6BA4", Offset = "0xEF6BA4", VA = "0xEF6BA4")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xEF6208", Offset = "0xEF6208", VA = "0xEF6208")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xEF27E8", Offset = "0xEF27E8", VA = "0xEF27E8")]
	private void Dispose()
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xEF6548", Offset = "0xEF6548", VA = "0xEF6548")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xEF6AC0", Offset = "0xEF6AC0", VA = "0xEF6AC0")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xEF6D9C", Offset = "0xEF6D9C", VA = "0xEF6D9C")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xF02584", Offset = "0xF02584", VA = "0xF02584")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xF02BD8", Offset = "0xF02BD8", VA = "0xF02BD8")]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xEF29C8", Offset = "0xEF29C8", VA = "0xEF29C8")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xF02BE0", Offset = "0xF02BE0", VA = "0xF02BE0")]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xF02C94", Offset = "0xF02C94", VA = "0xF02C94")]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xF02CA8", Offset = "0xF02CA8", VA = "0xF02CA8")]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xF02CC4", Offset = "0xF02CC4", VA = "0xF02CC4")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xF02D18", Offset = "0xF02D18", VA = "0xF02D18")]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xF02D30", Offset = "0xF02D30", VA = "0xF02D30")]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xF02D58", Offset = "0xF02D58", VA = "0xF02D58")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xF02DB0", Offset = "0xF02DB0", VA = "0xF02DB0")]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xF02DCC", Offset = "0xF02DCC", VA = "0xF02DCC")]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xF02DF4", Offset = "0xF02DF4", VA = "0xF02DF4")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xF02E50", Offset = "0xF02E50", VA = "0xF02E50")]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xF02E70", Offset = "0xF02E70", VA = "0xF02E70")]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xF02EA0", Offset = "0xF02EA0", VA = "0xF02EA0")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0xF02F08", Offset = "0xF02F08", VA = "0xF02F08")]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xF02F44", Offset = "0xF02F44", VA = "0xF02F44")]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xF02F7C", Offset = "0xF02F7C", VA = "0xF02F7C")]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xF02FC4", Offset = "0xF02FC4", VA = "0xF02FC4")]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xF03000", Offset = "0xF03000", VA = "0xF03000")]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xF0303C", Offset = "0xF0303C", VA = "0xF0303C")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xF030B0", Offset = "0xF030B0", VA = "0xF030B0")]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xF03100", Offset = "0xF03100", VA = "0xF03100")]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xF03150", Offset = "0xF03150", VA = "0xF03150")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xF031D4", Offset = "0xF031D4", VA = "0xF031D4")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xF03210", Offset = "0xF03210", VA = "0xF03210")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xF032DC", Offset = "0xF032DC", VA = "0xF032DC")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xF03360", Offset = "0xF03360", VA = "0xF03360")]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xF03390", Offset = "0xF03390", VA = "0xF03390")]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xF033D0", Offset = "0xF033D0", VA = "0xF033D0")]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xEF57F0", Offset = "0xEF57F0", VA = "0xEF57F0")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xF03454", Offset = "0xF03454", VA = "0xF03454")]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xF034E8", Offset = "0xF034E8", VA = "0xF034E8")]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xF0357C", Offset = "0xF0357C", VA = "0xF0357C")]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}
}
[Token(Token = "0x2000023")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E778C", Offset = "0x7E778C")]
public class MouseLook : MonoBehaviour
{
	[Token(Token = "0x2000024")]
	public enum RotationAxes
	{
		[Token(Token = "0x4000117")]
		MouseXAndY,
		[Token(Token = "0x4000118")]
		MouseX,
		[Token(Token = "0x4000119")]
		MouseY
	}

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RotationAxes axes;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sensitivityX;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sensitivityY;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float minimumX;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maximumX;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float minimumY;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float maximumY;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float rotationY;

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x1AE7158", Offset = "0x1AE7158", VA = "0x1AE7158")]
	private void Update()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x1AE7330", Offset = "0x1AE7330", VA = "0x1AE7330")]
	private void Start()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x1AE73F8", Offset = "0x1AE73F8", VA = "0x1AE73F8")]
	public MouseLook()
	{
	}
}
[Token(Token = "0x2000025")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E77C4", Offset = "0x7E77C4")]
[ExecuteInEditMode]
public class BlurEffect : MonoBehaviour
{
	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int iterations;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float blurSpread;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Shader blurShader;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Material m_Material;

	[Token(Token = "0x17000007")]
	protected Material material
	{
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1C61708", Offset = "0x1C61708", VA = "0x1C61708")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x1C6185C", Offset = "0x1C6185C", VA = "0x1C6185C")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x1C61960", Offset = "0x1C61960", VA = "0x1C61960")]
	protected void Start()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x1C61A1C", Offset = "0x1C61A1C", VA = "0x1C61A1C")]
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x1C61B40", Offset = "0x1C61B40", VA = "0x1C61B40")]
	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x1C61C50", Offset = "0x1C61C50", VA = "0x1C61C50")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x1C61DB8", Offset = "0x1C61DB8", VA = "0x1C61DB8")]
	public BlurEffect()
	{
	}
}
[Token(Token = "0x2000026")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E7810", Offset = "0x7E7810")]
[ExecuteInEditMode]
public class ColorCorrectionEffect : ImageEffectBase
{
	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture textureRamp;

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x1C95BD0", Offset = "0x1C95BD0", VA = "0x1C95BD0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x1C95C98", Offset = "0x1C95C98", VA = "0x1C95C98")]
	public ColorCorrectionEffect()
	{
	}
}
[Token(Token = "0x2000027")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E785C", Offset = "0x7E785C")]
public class ContrastStretchEffect : MonoBehaviour
{
	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float adaptationSpeed;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float limitMinimum;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float limitMaximum;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RenderTexture[] adaptRenderTex;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int curAdaptIndex;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Shader shaderLum;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material m_materialLum;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Shader shaderReduce;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material m_materialReduce;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Shader shaderAdapt;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material m_materialAdapt;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Shader shaderApply;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Material m_materialApply;

	[Token(Token = "0x17000008")]
	protected Material materialLum
	{
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1C96550", Offset = "0x1C96550", VA = "0x1C96550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000009")]
	protected Material materialReduce
	{
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1C9662C", Offset = "0x1C9662C", VA = "0x1C9662C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000A")]
	protected Material materialAdapt
	{
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1C96708", Offset = "0x1C96708", VA = "0x1C96708")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000B")]
	protected Material materialApply
	{
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1C967E4", Offset = "0x1C967E4", VA = "0x1C967E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x1C968C0", Offset = "0x1C968C0", VA = "0x1C968C0")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x1C96954", Offset = "0x1C96954", VA = "0x1C96954")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x1C96AB4", Offset = "0x1C96AB4", VA = "0x1C96AB4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x1C96CE0", Offset = "0x1C96CE0", VA = "0x1C96CE0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x1C96F44", Offset = "0x1C96F44", VA = "0x1C96F44")]
	private void CalculateAdaptation(Texture curTexture)
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x1C97140", Offset = "0x1C97140", VA = "0x1C97140")]
	public ContrastStretchEffect()
	{
	}
}
[Token(Token = "0x2000028")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7E78A8", Offset = "0x7E78A8")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E78A8", Offset = "0x7E78A8")]
public class GlowEffect : MonoBehaviour
{
	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float glowIntensity;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int blurIterations;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float blurSpread;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Color glowTint;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Shader compositeShader;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material m_CompositeMaterial;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Shader blurShader;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material m_BlurMaterial;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Shader downsampleShader;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material m_DownsampleMaterial;

	[Token(Token = "0x1700000C")]
	protected Material compositeMaterial
	{
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x19D0D1C", Offset = "0x19D0D1C", VA = "0x19D0D1C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000D")]
	protected Material blurMaterial
	{
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x19D0DF8", Offset = "0x19D0DF8", VA = "0x19D0DF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	protected Material downsampleMaterial
	{
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x19D0ED4", Offset = "0x19D0ED4", VA = "0x19D0ED4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x19D0FB0", Offset = "0x19D0FB0", VA = "0x19D0FB0")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x19D1104", Offset = "0x19D1104", VA = "0x19D1104")]
	protected void Start()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x19D127C", Offset = "0x19D127C", VA = "0x19D127C")]
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x19D13A0", Offset = "0x19D13A0", VA = "0x19D13A0")]
	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x19D1480", Offset = "0x19D1480", VA = "0x19D1480")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x19D16B8", Offset = "0x19D16B8", VA = "0x19D16B8")]
	public void BlitGlow(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x19D17A4", Offset = "0x19D17A4", VA = "0x19D17A4")]
	public GlowEffect()
	{
	}
}
[Token(Token = "0x2000029")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E793C", Offset = "0x7E793C")]
public class GrayscaleEffect : ImageEffectBase
{
	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture textureRamp;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float rampOffset;

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x19D7C20", Offset = "0x19D7C20", VA = "0x19D7C20")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x19D7D1C", Offset = "0x19D7D1C", VA = "0x19D7D1C")]
	public GrayscaleEffect()
	{
	}
}
[Token(Token = "0x200002A")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E7988", Offset = "0x7E7988")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7E7988", Offset = "0x7E7988")]
public class ImageEffectBase : MonoBehaviour
{
	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Shader shader;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material m_Material;

	[Token(Token = "0x1700000F")]
	protected Material material
	{
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1BAF47C", Offset = "0x1BAF47C", VA = "0x1BAF47C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x1BAF3D0", Offset = "0x1BAF3D0", VA = "0x1BAF3D0", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x1BAF558", Offset = "0x1BAF558", VA = "0x1BAF558", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x1BAF604", Offset = "0x1BAF604", VA = "0x1BAF604")]
	public ImageEffectBase()
	{
	}
}
[Token(Token = "0x200002B")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E7A0C", Offset = "0x7E7A0C")]
public class ImageEffects
{
	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x1BAF60C", Offset = "0x1BAF60C", VA = "0x1BAF60C")]
	public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x1BAF858", Offset = "0x1BAF858", VA = "0x1BAF858")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7F4118", Offset = "0x7F4118")]
	public static void Blit(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x1BAF8CC", Offset = "0x1BAF8CC", VA = "0x1BAF8CC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x7F4150", Offset = "0x7F4150")]
	public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x1BAF948", Offset = "0x1BAF948", VA = "0x1BAF948")]
	public ImageEffects()
	{
	}
}
[Token(Token = "0x200002C")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E7A44", Offset = "0x7E7A44")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7E7A44", Offset = "0x7E7A44")]
public class MotionBlur : ImageEffectBase
{
	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float blurAmount;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool extraBlur;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTexture accumTexture;

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x1AE6CE0", Offset = "0x1AE6CE0", VA = "0x1AE6CE0", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x1AE6D28", Offset = "0x1AE6D28", VA = "0x1AE6D28", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x1AE6D9C", Offset = "0x1AE6D9C", VA = "0x1AE6D9C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x1AE7144", Offset = "0x1AE7144", VA = "0x1AE7144")]
	public MotionBlur()
	{
	}
}
[Token(Token = "0x200002D")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7E7AD8", Offset = "0x7E7AD8")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E7AD8", Offset = "0x7E7AD8")]
public class NoiseEffect : MonoBehaviour
{
	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool monochrome;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool rgbFallback;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float grainIntensityMin;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float grainIntensityMax;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float grainSize;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float scratchIntensityMin;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float scratchIntensityMax;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float scratchFPS;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float scratchJitter;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture grainTexture;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture scratchTexture;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Shader shaderRGB;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Shader shaderYUV;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material m_MaterialRGB;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material m_MaterialYUV;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float scratchTimeLeft;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float scratchX;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float scratchY;

	[Token(Token = "0x17000010")]
	protected Material material
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1AE81E0", Offset = "0x1AE81E0", VA = "0x1AE81E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x1AE808C", Offset = "0x1AE808C", VA = "0x1AE808C")]
	protected void Start()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x1AE835C", Offset = "0x1AE835C", VA = "0x1AE835C")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x1AE845C", Offset = "0x1AE845C", VA = "0x1AE845C")]
	private void SanitizeParameters()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x1AE8550", Offset = "0x1AE8550", VA = "0x1AE8550")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x1AE88D0", Offset = "0x1AE88D0", VA = "0x1AE88D0")]
	public NoiseEffect()
	{
	}
}
[Token(Token = "0x200002E")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E7B6C", Offset = "0x7E7B6C")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7E7B6C", Offset = "0x7E7B6C")]
public class SSAOEffect : MonoBehaviour
{
	[Token(Token = "0x200002F")]
	public enum SSAOSamples
	{
		[Token(Token = "0x400015B")]
		Low,
		[Token(Token = "0x400015C")]
		Medium,
		[Token(Token = "0x400015D")]
		High
	}

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float m_Radius;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SSAOSamples m_SampleCount;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float m_OcclusionIntensity;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_Blur;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_Downsampling;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float m_OcclusionAttenuation;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float m_MinZ;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Shader m_SSAOShader;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material m_SSAOMaterial;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D m_RandomTexture;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool m_Supported;

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x1AF18B0", Offset = "0x1AF18B0", VA = "0x1AF18B0")]
	private static Material CreateMaterial(Shader shader)
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x1AF1968", Offset = "0x1AF1968", VA = "0x1AF1968")]
	private static void DestroyMaterial(Material mat)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x1AF1A00", Offset = "0x1AF1A00", VA = "0x1AF1A00")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x1AF1A08", Offset = "0x1AF1A08", VA = "0x1AF1A08")]
	private void Start()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x1AF1BC0", Offset = "0x1AF1BC0", VA = "0x1AF1BC0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x1AF1ADC", Offset = "0x1AF1ADC", VA = "0x1AF1ADC")]
	private void CreateMaterials()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x1AF1C30", Offset = "0x1AF1C30", VA = "0x1AF1C30")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x1AF22A8", Offset = "0x1AF22A8", VA = "0x1AF22A8")]
	public SSAOEffect()
	{
	}
}
[Token(Token = "0x2000030")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E7C00", Offset = "0x7E7C00")]
public class SepiaToneEffect : ImageEffectBase
{
	[Token(Token = "0x6000206")]
	[Address(RVA = "0x1AF28B0", Offset = "0x1AF28B0", VA = "0x1AF28B0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x1AF2940", Offset = "0x1AF2940", VA = "0x1AF2940")]
	public SepiaToneEffect()
	{
	}
}
[Token(Token = "0x2000031")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E7C4C", Offset = "0x7E7C4C")]
public class TwirlEffect : ImageEffectBase
{
	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 radius;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float angle;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector2 center;

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xED8638", Offset = "0xED8638", VA = "0xED8638")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xED8684", Offset = "0xED8684", VA = "0xED8684")]
	public TwirlEffect()
	{
	}
}
[Token(Token = "0x2000032")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E7C98", Offset = "0x7E7C98")]
public class VortexEffect : ImageEffectBase
{
	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 radius;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float angle;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector2 center;

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xEE10B0", Offset = "0xEE10B0", VA = "0xEE10B0")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xEE10FC", Offset = "0xEE10FC", VA = "0xEE10FC")]
	public VortexEffect()
	{
	}
}
[Token(Token = "0x2000033")]
[ExecuteInEditMode]
public class Lava3 : MonoBehaviour
{
	[Token(Token = "0x2000034")]
	public enum WaterMode
	{
		[Token(Token = "0x400018D")]
		Indie,
		[Token(Token = "0x400018E")]
		FastAndNoRefraction,
		[Token(Token = "0x400018F")]
		Optimized,
		[Token(Token = "0x4000190")]
		Everything
	}

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector2 uvAnimationRate1;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string textureName1;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 uvAnimationRate2;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string textureName2;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector2 m_UVOffsetA;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector2 m_UVOffsetB;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector2 temp_UVOffsetA;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector2 temp_UVOffsetB;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public WaterMode m_WaterMode;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public LavaManager m_WaterManager;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool m_DisablePixelLights;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int m_TextureSize;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float m_ClipPlaneOffset;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public LayerMask m_ReflectLayers;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Hashtable m_ReflectionCameras;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private RenderTexture m_ReflectionTexture;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private WaterMode m_HardwareWaterSupport;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int m_OldReflectionTextureSize;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool s_InsideWater;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool realtime2DReflection;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	public bool autoEdgeBlend;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
	public bool waterDisplacement;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
	public bool refractionMask;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float m_Shininess;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float m_WaveScale;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform lightTransform;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Vector3 m_FoamWaveParams;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public Vector2 m_WaveSpeedBumpA;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public Vector2 m_WaveSpeedBumpB;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public Vector3 m_DistortParams;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public float m_FadeExp;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public float m_InvFade;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public float m_InvFadeFoam;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public float m_InvFadeDepthFade;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Vector2 m_ShoreTilingBumpA;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Vector2 m_ShoreTilingBumpB;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public float m_UnderwaterCheckOffset;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Material m_Water3Material;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool m_IsDirty;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
	private bool m_DepthTexturesSupported;

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x1BB9A60", Offset = "0x1BB9A60", VA = "0x1BB9A60")]
	public void Start()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x1BB9B48", Offset = "0x1BB9B48", VA = "0x1BB9B48")]
	public Mesh GetMesh()
	{
		return null;
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x1BB9C78", Offset = "0x1BB9C78", VA = "0x1BB9C78")]
	public bool IsUnderwater(Camera cam)
	{
		return default(bool);
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x1BB9C80", Offset = "0x1BB9C80", VA = "0x1BB9C80")]
	public void OnWillRenderObject()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x1BBB63C", Offset = "0x1BBB63C", VA = "0x1BBB63C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x1BBBB94", Offset = "0x1BBBB94", VA = "0x1BBBB94")]
	public Vector3 GetNormalAt(Vector3 pos, float scale = 1f)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x1BBBC94", Offset = "0x1BBBC94", VA = "0x1BBBC94")]
	public Vector3 GetHeightOffsetAt(Vector3 pos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x1BBBF54", Offset = "0x1BBBF54", VA = "0x1BBBF54")]
	private void Update()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x1BBAD60", Offset = "0x1BBAD60", VA = "0x1BBAD60")]
	private void UpdateCameraModes(Camera src, Camera dest)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x1BBA7D0", Offset = "0x1BBA7D0", VA = "0x1BBA7D0")]
	private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera)
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x1BBA7BC", Offset = "0x1BBA7BC", VA = "0x1BBA7BC")]
	private WaterMode GetWaterMode()
	{
		return default(WaterMode);
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x1BBA6A4", Offset = "0x1BBA6A4", VA = "0x1BBA6A4")]
	private WaterMode FindHardwareWaterSupport()
	{
		return default(WaterMode);
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x1BBC5F8", Offset = "0x1BBC5F8", VA = "0x1BBC5F8")]
	private static float sgn(float a)
	{
		return default(float);
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x1BBB320", Offset = "0x1BBB320", VA = "0x1BBB320")]
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default(Vector4);
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x1BBB44C", Offset = "0x1BBB44C", VA = "0x1BBB44C")]
	private static void CalculateObliqueMatrix(ref Matrix4x4 projection, Vector4 clipPlane)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x1BBB07C", Offset = "0x1BBB07C", VA = "0x1BBB07C")]
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x1BBC618", Offset = "0x1BBC618", VA = "0x1BBC618")]
	public Lava3()
	{
	}
}
[Token(Token = "0x2000035")]
public class Lava3Float : MonoBehaviour
{
	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Lava3 m_Water;

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x1AE1FE4", Offset = "0x1AE1FE4", VA = "0x1AE1FE4")]
	private void Start()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x1AE2108", Offset = "0x1AE2108", VA = "0x1AE2108")]
	private void Update()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x1AE2310", Offset = "0x1AE2310", VA = "0x1AE2310")]
	public Lava3Float()
	{
	}
}
[Token(Token = "0x2000036")]
[ExecuteInEditMode]
public class Lava3UnderwaterEffect : MonoBehaviour
{
	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float m_UnderwaterColorFade;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Shader m_UnderwaterShader;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Lava3 m_Water;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color m_BlendColor;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material m_UnderwaterMaterial;

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x1AE2318", Offset = "0x1AE2318", VA = "0x1AE2318")]
	private void Start()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x1AE23F4", Offset = "0x1AE23F4", VA = "0x1AE23F4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x1AE2AA4", Offset = "0x1AE2AA4", VA = "0x1AE2AA4")]
	public Lava3UnderwaterEffect()
	{
	}
}
[Token(Token = "0x2000037")]
[ExecuteInEditMode]
public class LavaManager : MonoBehaviour
{
	[Token(Token = "0x2000038")]
	public enum CpuDisplacementModel
	{
		[Token(Token = "0x40001A2")]
		None,
		[Token(Token = "0x40001A3")]
		NoiseBump,
		[Token(Token = "0x40001A4")]
		FFT
	}

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public CpuDisplacementModel m_CpuDisplacementModel;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public float m_DisplacementTiling;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public float m_NormalsDisplacement;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public float m_HeightDisplacement;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public float m_SmallWavesSpeed;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	private Texture2D m_DisplacementHeightMap;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	private Texture2D m_2ndDisplacementHeightMap;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Material m_SharedWaterMaterial;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LavaManager s_Instance;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public float m_Timer;

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x1AE2AE0", Offset = "0x1AE2AE0", VA = "0x1AE2AE0")]
	public void SetDisplacementHeightMap(Texture2D map, int index)
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x1AE2D84", Offset = "0x1AE2D84", VA = "0x1AE2D84")]
	public Texture2D GetDisplacementHeightMap(int index)
	{
		return null;
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x1AE2648", Offset = "0x1AE2648", VA = "0x1AE2648")]
	public static LavaManager Instance()
	{
		return null;
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x1AE2D9C", Offset = "0x1AE2D9C", VA = "0x1AE2D9C")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x1AE2DA4", Offset = "0x1AE2DA4", VA = "0x1AE2DA4")]
	public void Start()
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x1AE2EAC", Offset = "0x1AE2EAC", VA = "0x1AE2EAC")]
	public void Update()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x1AE2A88", Offset = "0x1AE2A88", VA = "0x1AE2A88")]
	public Color GetMaterialColor(string name)
	{
		return default(Color);
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x1AE2F84", Offset = "0x1AE2F84", VA = "0x1AE2F84")]
	public void SetMaterialColor(string name, Color color)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x1AE2FA0", Offset = "0x1AE2FA0", VA = "0x1AE2FA0")]
	public Vector4 GetMaterialVector(string name)
	{
		return default(Vector4);
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x1AE2FBC", Offset = "0x1AE2FBC", VA = "0x1AE2FBC")]
	public void SetMaterialVector(string name, Vector4 vector)
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x1AE2E90", Offset = "0x1AE2E90", VA = "0x1AE2E90")]
	public Texture GetMaterialTexture(string theName)
	{
		return null;
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x1AE2FD8", Offset = "0x1AE2FD8", VA = "0x1AE2FD8")]
	public void SetMaterialTexture(string theName, Texture parameter)
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x1AE2FF4", Offset = "0x1AE2FF4", VA = "0x1AE2FF4")]
	public float GetDisplaceMeshAmountAt(Vector3 pos, Transform t)
	{
		return default(float);
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x1AE2C14", Offset = "0x1AE2C14", VA = "0x1AE2C14")]
	public void FillWithGradiant(Texture2D tex)
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x1AE30E4", Offset = "0x1AE30E4", VA = "0x1AE30E4")]
	public bool DisplaceMesh(Mesh m, Transform t)
	{
		return default(bool);
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x1AE3008", Offset = "0x1AE3008", VA = "0x1AE3008")]
	private float DisplaceMeshAmountAt(Vector3 pos, Transform t)
	{
		return default(float);
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x1AE3400", Offset = "0x1AE3400", VA = "0x1AE3400")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x1AE3468", Offset = "0x1AE3468", VA = "0x1AE3468")]
	public LavaManager()
	{
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E7D14", Offset = "0x7E7D14")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E7D14", Offset = "0x7E7D14")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200003A")]
		public enum Mode
		{
			[Token(Token = "0x40001B8")]
			AnimationClips,
			[Token(Token = "0x40001B9")]
			AnimationStates,
			[Token(Token = "0x40001BA")]
			PlayableDirector,
			[Token(Token = "0x40001BB")]
			Realtime
		}

		[Token(Token = "0x200003B")]
		public delegate void BakerDelegate(AnimationClip clip, float time);

		[Serializable]
		[Token(Token = "0x200003C")]
		public class ClipSettings
		{
			[Serializable]
			[Token(Token = "0x200003D")]
			public enum BasedUponRotation
			{
				[Token(Token = "0x40001C9")]
				Original,
				[Token(Token = "0x40001CA")]
				BodyOrientation
			}

			[Serializable]
			[Token(Token = "0x200003E")]
			public enum BasedUponY
			{
				[Token(Token = "0x40001CC")]
				Original,
				[Token(Token = "0x40001CD")]
				CenterOfMass,
				[Token(Token = "0x40001CE")]
				Feet
			}

			[Serializable]
			[Token(Token = "0x200003F")]
			public enum BasedUponXZ
			{
				[Token(Token = "0x40001D0")]
				Original,
				[Token(Token = "0x40001D1")]
				CenterOfMass
			}

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool loopTime;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool loopBlend;

			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float cycleOffset;

			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool loopBlendOrientation;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public BasedUponRotation basedUponRotation;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float orientationOffsetY;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool loopBlendPositionY;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BasedUponY basedUponY;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float level;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool loopBlendPositionXZ;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public BasedUponXZ basedUponXZ;

			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool mirror;

			[Token(Token = "0x600024E")]
			[Address(RVA = "0x1BE3CF8", Offset = "0x1BE3CF8", VA = "0x1BE3CF8")]
			public ClipSettings()
			{
			}
		}

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E8BB0", Offset = "0x7E8BB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8BB0", Offset = "0x7E8BB0")]
		public int frameRate;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E8C08", Offset = "0x7E8C08")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8C08", Offset = "0x7E8C08")]
		public float keyReductionError;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8C60", Offset = "0x7E8C60")]
		public Mode mode;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8C98", Offset = "0x7E8C98")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8CD0", Offset = "0x7E8CD0")]
		public string[] animationStates;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8D08", Offset = "0x7E8D08")]
		public string saveToFolder;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8D40", Offset = "0x7E8D40")]
		public string appendName;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8D78", Offset = "0x7E8D78")]
		public string saveName;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E8DB0", Offset = "0x7E8DB0")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E8DC0", Offset = "0x7E8DC0")]
		private float <bakingProgress>k__BackingField;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public BakerDelegate OnStartClip;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public BakerDelegate OnUpdateClip;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8DF0", Offset = "0x7E8DF0")]
		public bool inheritClipSettings;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8E28", Offset = "0x7E8E28")]
		public ClipSettings clipSettings;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E8E60", Offset = "0x7E8E60")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected bool addLoopFrame;

		[Token(Token = "0x17000011")]
		public bool isBaking
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x1C54CB8", Offset = "0x1C54CB8", VA = "0x1C54CB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4278", Offset = "0x7F4278")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x1C54CC0", Offset = "0x1C54CC0", VA = "0x1C54CC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4288", Offset = "0x7F4288")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public float bakingProgress
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x1C54CCC", Offset = "0x1C54CCC", VA = "0x1C54CCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4298", Offset = "0x7F4298")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x1C54CD4", Offset = "0x1C54CD4", VA = "0x1C54CD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F42A8", Offset = "0x7F42A8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		protected float clipLength
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x1C54CDC", Offset = "0x1C54CDC", VA = "0x1C54CDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F42B8", Offset = "0x7F42B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x1C54CE4", Offset = "0x1C54CE4", VA = "0x1C54CE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F42C8", Offset = "0x7F42C8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1C54B98", Offset = "0x1C54B98", VA = "0x1C54B98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4198", Offset = "0x7F4198")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1C54BE0", Offset = "0x1C54BE0", VA = "0x1C54BE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F41D0", Offset = "0x7F41D0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1C54C28", Offset = "0x1C54C28", VA = "0x1C54C28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4208", Offset = "0x7F4208")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1C54C70", Offset = "0x1C54C70", VA = "0x1C54C70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4240", Offset = "0x7F4240")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023F")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x6000240")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x6000241")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x6000242")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x6000243")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1C54CEC", Offset = "0x1C54CEC", VA = "0x1C54CEC")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1C54CF0", Offset = "0x1C54CF0", VA = "0x1C54CF0")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1C54CF4", Offset = "0x1C54CF4", VA = "0x1C54CF4")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1C54CF8", Offset = "0x1C54CF8", VA = "0x1C54CF8")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8E70", Offset = "0x7E8E70")]
		public bool markAsLegacy;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8EA8", Offset = "0x7E8EA8")]
		public Transform root;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8EE0", Offset = "0x7E8EE0")]
		public Transform rootNode;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8F18", Offset = "0x7E8F18")]
		public Transform[] ignoreList;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8F50", Offset = "0x7E8F50")]
		public Transform[] bakePositionList;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private BakerTransform[] children;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private BakerTransform rootChild;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int rootChildIndex;

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x19D010C", Offset = "0x19D010C", VA = "0x19D010C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x19D0510", Offset = "0x19D0510", VA = "0x19D0510", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x19D0518", Offset = "0x19D0518", VA = "0x19D0518", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x19D0628", Offset = "0x19D0628", VA = "0x19D0628", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x19D06A4", Offset = "0x19D06A4", VA = "0x19D06A4", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x19D0720", Offset = "0x19D0720", VA = "0x19D0720", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x19D0368", Offset = "0x19D0368", VA = "0x19D0368")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x19D043C", Offset = "0x19D043C", VA = "0x19D043C")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x19D079C", Offset = "0x19D079C", VA = "0x19D079C")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class TQ
	{
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xED75D8", Offset = "0xED75D8", VA = "0xED75D8")]
		public TQ()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xED75E0", Offset = "0xED75E0", VA = "0xED75E0")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class AvatarUtility
	{
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1C53944", Offset = "0x1C53944", VA = "0x1C53944")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1C53BAC", Offset = "0x1C53BAC", VA = "0x1C53BAC")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1C54170", Offset = "0x1C54170", VA = "0x1C54170")]
		public static TQ WorldSpaceIKGoalToBone(TQ goalTQ, Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1C5461C", Offset = "0x1C5461C", VA = "0x1C5461C")]
		public static TQ GetWorldSpaceIKGoal(BakerHumanoidQT ikQT, BakerHumanoidQT rootQT, float time, float humanScale)
		{
			return null;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1C53B8C", Offset = "0x1C53B8C", VA = "0x1C53B8C")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1C547B0", Offset = "0x1C547B0", VA = "0x1C547B0")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1C561E8", Offset = "0x1C561E8", VA = "0x1C561E8")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1C57B18", Offset = "0x1C57B18", VA = "0x1C57B18")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1C55C38", Offset = "0x1C55C38", VA = "0x1C55C38")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1C56230", Offset = "0x1C56230", VA = "0x1C56230")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1C55768", Offset = "0x1C55768", VA = "0x1C55768")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1C54E0C", Offset = "0x1C54E0C", VA = "0x1C54E0C")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1C55120", Offset = "0x1C55120", VA = "0x1C55120")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1C552FC", Offset = "0x1C552FC", VA = "0x1C552FC")]
		public Quaternion EvaluateRotation(float time)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1C553B8", Offset = "0x1C553B8", VA = "0x1C553B8")]
		public Vector3 EvaluatePosition(float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1C546E0", Offset = "0x1C546E0", VA = "0x1C546E0")]
		public TQ Evaluate(float time)
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1C55438", Offset = "0x1C55438", VA = "0x1C55438")]
		public void GetCurvesFromClip(AnimationClip clip, Animator animator)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1C54FC4", Offset = "0x1C54FC4", VA = "0x1C54FC4")]
		public void Reset()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1C5543C", Offset = "0x1C5543C", VA = "0x1C5543C")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1C559CC", Offset = "0x1C559CC", VA = "0x1C559CC")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1C55AC8", Offset = "0x1C55AC8", VA = "0x1C55AC8")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1C55BC4", Offset = "0x1C55BC4", VA = "0x1C55BC4")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1C55E30", Offset = "0x1C55E30", VA = "0x1C55E30")]
		public void SetRootLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1C55B3C", Offset = "0x1C55B3C", VA = "0x1C55B3C")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1C55E34", Offset = "0x1C55E34", VA = "0x1C55E34")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1C55EE8", Offset = "0x1C55EE8", VA = "0x1C55EE8")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class BakerMuscle
	{
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1C56234", Offset = "0x1C56234", VA = "0x1C56234")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1C562B0", Offset = "0x1C562B0", VA = "0x1C562B0")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1C56D4C", Offset = "0x1C56D4C", VA = "0x1C56D4C")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1C56E00", Offset = "0x1C56E00", VA = "0x1C56E00")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1C56CE8", Offset = "0x1C56CE8", VA = "0x1C56CE8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1C56EF8", Offset = "0x1C56EF8", VA = "0x1C56EF8")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1C56F40", Offset = "0x1C56F40", VA = "0x1C56F40")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class BakerTransform
	{
		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1C56F48", Offset = "0x1C56F48", VA = "0x1C56F48")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1C57138", Offset = "0x1C57138", VA = "0x1C57138")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1C5714C", Offset = "0x1C5714C", VA = "0x1C5714C")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1C57438", Offset = "0x1C57438", VA = "0x1C57438")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1C56FF4", Offset = "0x1C56FF4", VA = "0x1C56FF4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1C576EC", Offset = "0x1C576EC", VA = "0x1C576EC")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1C57760", Offset = "0x1C57760", VA = "0x1C57760")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1C57914", Offset = "0x1C57914", VA = "0x1C57914")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8F88", Offset = "0x7E8F88")]
		public bool bakeHandIK;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E8FC0", Offset = "0x7E8FC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E8FC0", Offset = "0x7E8FC0")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E9018", Offset = "0x7E9018")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9018", Offset = "0x7E9018")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float[] muscles;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private HumanPose pose;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private HumanPoseHandler handler;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Vector3 bodyPosition;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Quaternion bodyRotation;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int mN;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x19E0E94", Offset = "0x19E0E94", VA = "0x19E0E94")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x19E1428", Offset = "0x19E1428", VA = "0x19E1428", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x19E1444", Offset = "0x19E1444", VA = "0x19E1444", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x19E1520", Offset = "0x19E1520", VA = "0x19E1520", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x19E15FC", Offset = "0x19E15FC", VA = "0x19E15FC", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x19E17CC", Offset = "0x19E17CC", VA = "0x19E17CC", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x19E1B14", Offset = "0x19E1B14", VA = "0x19E1B14")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x19E1C00", Offset = "0x19E1C00", VA = "0x19E1C00")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000049")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000235")]
			Update,
			[Token(Token = "0x4000236")]
			FixedUpdate,
			[Token(Token = "0x4000237")]
			LateUpdate,
			[Token(Token = "0x4000238")]
			FixedLateUpdate
		}

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7E906C", Offset = "0x7E906C")]
		public bool smoothFollow;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7E90A4", Offset = "0x7E90A4")]
		public float rotationSensitivity;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7E90DC", Offset = "0x7E90DC")]
		public float distance;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7E9114", Offset = "0x7E9114")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float blockingOriginOffset;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E914C", Offset = "0x7E914C")]
		public float blockedOffset;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E9164", Offset = "0x7E9164")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E9174", Offset = "0x7E9174")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E9184", Offset = "0x7E9184")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 targetDistance;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 position;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion rotation;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 smoothPosition;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000014")]
		public float x
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x1C625C0", Offset = "0x1C625C0", VA = "0x1C625C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F42D8", Offset = "0x7F42D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x1C625C8", Offset = "0x1C625C8", VA = "0x1C625C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F42E8", Offset = "0x7F42E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public float y
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x1C625D0", Offset = "0x1C625D0", VA = "0x1C625D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F42F8", Offset = "0x7F42F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x1C625D8", Offset = "0x1C625D8", VA = "0x1C625D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4308", Offset = "0x7F4308")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public float distanceTarget
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x1C625E0", Offset = "0x1C625E0", VA = "0x1C625E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4318", Offset = "0x7F4318")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x1C625E8", Offset = "0x1C625E8", VA = "0x1C625E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4328", Offset = "0x7F4328")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		private float zoomAdd
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x1C62ED0", Offset = "0x1C62ED0", VA = "0x1C62ED0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1C625F0", Offset = "0x1C625F0", VA = "0x1C625F0")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1C6262C", Offset = "0x1C6262C", VA = "0x1C6262C")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1C62634", Offset = "0x1C62634", VA = "0x1C62634", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1C62744", Offset = "0x1C62744", VA = "0x1C62744", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1C627A0", Offset = "0x1C627A0", VA = "0x1C627A0", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1C62808", Offset = "0x1C62808", VA = "0x1C62808", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1C6286C", Offset = "0x1C6286C", VA = "0x1C6286C")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1C62778", Offset = "0x1C62778", VA = "0x1C62778")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1C629EC", Offset = "0x1C629EC", VA = "0x1C629EC")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1C62EA0", Offset = "0x1C62EA0", VA = "0x1C62EA0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1C62F40", Offset = "0x1C62F40", VA = "0x1C62F40")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1C62FEC", Offset = "0x1C62FEC", VA = "0x1C62FEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1C63024", Offset = "0x1C63024", VA = "0x1C63024")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1C631CC", Offset = "0x1C631CC", VA = "0x1C631CC")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1C631FC", Offset = "0x1C631FC", VA = "0x1C631FC")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public enum Axis
	{
		[Token(Token = "0x400023F")]
		X,
		[Token(Token = "0x4000240")]
		Y,
		[Token(Token = "0x4000241")]
		Z
	}
	[Token(Token = "0x200004C")]
	public class AxisTools
	{
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1C547B8", Offset = "0x1C547B8", VA = "0x1C547B8")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1C547DC", Offset = "0x1C547DC", VA = "0x1C547DC")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1C54814", Offset = "0x1C54814", VA = "0x1C54814")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1C54904", Offset = "0x1C54904", VA = "0x1C54904")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1C548AC", Offset = "0x1C548AC", VA = "0x1C548AC")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1C5499C", Offset = "0x1C5499C", VA = "0x1C5499C")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1C549E4", Offset = "0x1C549E4", VA = "0x1C549E4")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1C54B90", Offset = "0x1C54B90", VA = "0x1C54B90")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x200004E")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x1BE3D00", Offset = "0x1BE3D00", VA = "0x1BE3D00")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000018")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x1C5A230", Offset = "0x1C5A230", VA = "0x1C5A230")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x1C5A4A0", Offset = "0x1C5A4A0", VA = "0x1C5A4A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1C5A1B0", Offset = "0x1C5A1B0", VA = "0x1C5A1B0")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200004F")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000050")]
		public enum BoneType
		{
			[Token(Token = "0x400025C")]
			Unassigned,
			[Token(Token = "0x400025D")]
			Spine,
			[Token(Token = "0x400025E")]
			Head,
			[Token(Token = "0x400025F")]
			Arm,
			[Token(Token = "0x4000260")]
			Leg,
			[Token(Token = "0x4000261")]
			Tail,
			[Token(Token = "0x4000262")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000051")]
		public enum BoneSide
		{
			[Token(Token = "0x4000264")]
			Center,
			[Token(Token = "0x4000265")]
			Left,
			[Token(Token = "0x4000266")]
			Right
		}

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1C5A710", Offset = "0x1C5A710", VA = "0x1C5A710")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1C5AA34", Offset = "0x1C5AA34", VA = "0x1C5AA34")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1C5ACA8", Offset = "0x1C5ACA8", VA = "0x1C5ACA8")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1C5AD28", Offset = "0x1C5AD28", VA = "0x1C5AD28")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1C5ADD0", Offset = "0x1C5ADD0", VA = "0x1C5ADD0")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1C5A8E8", Offset = "0x1C5A8E8", VA = "0x1C5A8E8")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1C5AC0C", Offset = "0x1C5AC0C", VA = "0x1C5AC0C")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1C5B600", Offset = "0x1C5B600", VA = "0x1C5B600")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1C5B408", Offset = "0x1C5B408", VA = "0x1C5B408")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1C5B504", Offset = "0x1C5B504", VA = "0x1C5B504")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1C5AFE8", Offset = "0x1C5AFE8", VA = "0x1C5AFE8")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1C5B098", Offset = "0x1C5B098", VA = "0x1C5B098")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1C5B148", Offset = "0x1C5B148", VA = "0x1C5B148")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1C5B1F8", Offset = "0x1C5B1F8", VA = "0x1C5B1F8")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1C5B2A8", Offset = "0x1C5B2A8", VA = "0x1C5B2A8")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1C5B358", Offset = "0x1C5B358", VA = "0x1C5B358")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1C5B808", Offset = "0x1C5B808", VA = "0x1C5B808")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1C5AF00", Offset = "0x1C5AF00", VA = "0x1C5AF00")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1C5B778", Offset = "0x1C5B778", VA = "0x1C5B778")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1C5B874", Offset = "0x1C5B874", VA = "0x1C5B874")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1C5B948", Offset = "0x1C5B948", VA = "0x1C5B948")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1C5B700", Offset = "0x1C5B700", VA = "0x1C5B700")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1C5B68C", Offset = "0x1C5B68C", VA = "0x1C5B68C")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class BipedReferences
	{
		[Token(Token = "0x2000053")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x4000278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700001C")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60002DE")]
				[Address(RVA = "0x1BE3D8C", Offset = "0x1BE3D8C", VA = "0x1BE3D8C")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x1BE3D78", Offset = "0x1BE3D78", VA = "0x1BE3D78")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700001A")]
		public virtual bool isFilled
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x1C5E1B0", Offset = "0x1C5E1B0", VA = "0x1C5E1B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		public bool isEmpty
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1C5E598", Offset = "0x1C5E598", VA = "0x1C5E598")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1C5E5A8", Offset = "0x1C5E5A8", VA = "0x1C5E5A8", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1C5E9D0", Offset = "0x1C5E9D0", VA = "0x1C5E9D0", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1C5EE04", Offset = "0x1C5EE04", VA = "0x1C5EE04")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1C5F4D4", Offset = "0x1C5F4D4", VA = "0x1C5F4D4")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1C5F030", Offset = "0x1C5F030", VA = "0x1C5F030")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1C59484", Offset = "0x1C59484", VA = "0x1C59484")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1C5FD58", Offset = "0x1C5FD58", VA = "0x1C5FD58")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1C60314", Offset = "0x1C60314", VA = "0x1C60314")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1C600F4", Offset = "0x1C600F4", VA = "0x1C600F4")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1C5FF70", Offset = "0x1C5FF70", VA = "0x1C5FF70")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1C5FDF8", Offset = "0x1C5FDF8", VA = "0x1C5FDF8")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1C60200", Offset = "0x1C60200", VA = "0x1C60200")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1C6040C", Offset = "0x1C6040C", VA = "0x1C6040C")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1C60FF4", Offset = "0x1C60FF4", VA = "0x1C60FF4")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1C60A64", Offset = "0x1C60A64", VA = "0x1C60A64")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1C612F0", Offset = "0x1C612F0", VA = "0x1C612F0")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1C60DDC", Offset = "0x1C60DDC", VA = "0x1C60DDC")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1C612F8", Offset = "0x1C612F8", VA = "0x1C612F8")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1C61300", Offset = "0x1C61300", VA = "0x1C61300")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1C614D4", Offset = "0x1C614D4", VA = "0x1C614D4")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1C6169C", Offset = "0x1C6169C", VA = "0x1C6169C")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1C59904", Offset = "0x1C59904", VA = "0x1C59904")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0x7E9194", Offset = "0x7E9194")]
		public string text;

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1C95CA0", Offset = "0x1C95CA0", VA = "0x1C95CA0")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1C971C0", Offset = "0x1C971C0", VA = "0x1C971C0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1C97308", Offset = "0x1C97308", VA = "0x1C97308")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class Hierarchy
	{
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x19DED50", Offset = "0x19DED50", VA = "0x19DED50")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x19DEF3C", Offset = "0x19DEF3C", VA = "0x19DEF3C")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x19DEDE8", Offset = "0x19DEDE8", VA = "0x19DEDE8")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x19DF05C", Offset = "0x19DF05C", VA = "0x19DF05C")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x19DF188", Offset = "0x19DF188", VA = "0x19DF188")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x19DF3DC", Offset = "0x19DF3DC", VA = "0x19DF3DC")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x19DF4E4", Offset = "0x19DF4E4", VA = "0x19DF4E4")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x19DF658", Offset = "0x19DF658", VA = "0x19DF658")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x19DFA34", Offset = "0x19DFA34", VA = "0x19DFA34")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x19DF7F8", Offset = "0x19DF7F8", VA = "0x19DF7F8")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x19DFBE8", Offset = "0x19DFBE8", VA = "0x19DFBE8")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1BAFA94", Offset = "0x1BAFA94", VA = "0x1BAFA94")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1BAFB20", Offset = "0x1BAFB20", VA = "0x1BAFB20")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000280")]
		None,
		[Token(Token = "0x4000281")]
		InOutCubic,
		[Token(Token = "0x4000282")]
		InOutQuintic,
		[Token(Token = "0x4000283")]
		InOutSine,
		[Token(Token = "0x4000284")]
		InQuintic,
		[Token(Token = "0x4000285")]
		InQuartic,
		[Token(Token = "0x4000286")]
		InCubic,
		[Token(Token = "0x4000287")]
		InQuadratic,
		[Token(Token = "0x4000288")]
		InElastic,
		[Token(Token = "0x4000289")]
		InElasticSmall,
		[Token(Token = "0x400028A")]
		InElasticBig,
		[Token(Token = "0x400028B")]
		InSine,
		[Token(Token = "0x400028C")]
		InBack,
		[Token(Token = "0x400028D")]
		OutQuintic,
		[Token(Token = "0x400028E")]
		OutQuartic,
		[Token(Token = "0x400028F")]
		OutCubic,
		[Token(Token = "0x4000290")]
		OutInCubic,
		[Token(Token = "0x4000291")]
		OutInQuartic,
		[Token(Token = "0x4000292")]
		OutElastic,
		[Token(Token = "0x4000293")]
		OutElasticSmall,
		[Token(Token = "0x4000294")]
		OutElasticBig,
		[Token(Token = "0x4000295")]
		OutSine,
		[Token(Token = "0x4000296")]
		OutBack,
		[Token(Token = "0x4000297")]
		OutBackCubic,
		[Token(Token = "0x4000298")]
		OutBackQuartic,
		[Token(Token = "0x4000299")]
		BackInCubic,
		[Token(Token = "0x400029A")]
		BackInQuartic
	}
	[Token(Token = "0x2000059")]
	public class Interp
	{
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1BB35E0", Offset = "0x1BB35E0", VA = "0x1BB35E0")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1BB9318", Offset = "0x1BB9318", VA = "0x1BB9318")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1BB938C", Offset = "0x1BB938C", VA = "0x1BB938C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1BB8D80", Offset = "0x1BB8D80", VA = "0x1BB8D80")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1BB8D8C", Offset = "0x1BB8D8C", VA = "0x1BB8D8C")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1BB8DB0", Offset = "0x1BB8DB0", VA = "0x1BB8DB0")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1BB8DEC", Offset = "0x1BB8DEC", VA = "0x1BB8DEC")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1BB8E04", Offset = "0x1BB8E04", VA = "0x1BB8E04")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1BB8E18", Offset = "0x1BB8E18", VA = "0x1BB8E18")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1BB8E2C", Offset = "0x1BB8E2C", VA = "0x1BB8E2C")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1BB8E3C", Offset = "0x1BB8E3C", VA = "0x1BB8E3C")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1BB8E84", Offset = "0x1BB8E84", VA = "0x1BB8E84")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1BB8EBC", Offset = "0x1BB8EBC", VA = "0x1BB8EBC")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1BB8EE4", Offset = "0x1BB8EE4", VA = "0x1BB8EE4")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1BB9418", Offset = "0x1BB9418", VA = "0x1BB9418")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1BB8F18", Offset = "0x1BB8F18", VA = "0x1BB8F18")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1BB8F40", Offset = "0x1BB8F40", VA = "0x1BB8F40")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1BB8F70", Offset = "0x1BB8F70", VA = "0x1BB8F70")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1BB8FA4", Offset = "0x1BB8FA4", VA = "0x1BB8FA4")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1BB8FE8", Offset = "0x1BB8FE8", VA = "0x1BB8FE8")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1BB904C", Offset = "0x1BB904C", VA = "0x1BB904C")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1BB90B0", Offset = "0x1BB90B0", VA = "0x1BB90B0")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1BB9104", Offset = "0x1BB9104", VA = "0x1BB9104")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1BB9158", Offset = "0x1BB9158", VA = "0x1BB9158")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1BB9194", Offset = "0x1BB9194", VA = "0x1BB9194")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1BB91CC", Offset = "0x1BB91CC", VA = "0x1BB91CC")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1BB944C", Offset = "0x1BB944C", VA = "0x1BB944C")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1BB9214", Offset = "0x1BB9214", VA = "0x1BB9214")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1BB92A8", Offset = "0x1BB92A8", VA = "0x1BB92A8")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1BB92D8", Offset = "0x1BB92D8", VA = "0x1BB92D8")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1BB94E0", Offset = "0x1BB94E0", VA = "0x1BB94E0")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1AE3488", Offset = "0x1AE3488", VA = "0x1AE3488")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1AE34E0", Offset = "0x1AE34E0", VA = "0x1AE34E0")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1AE35AC", Offset = "0x1AE35AC", VA = "0x1AE35AC")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1AE34F8", Offset = "0x1AE34F8", VA = "0x1AE34F8")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1AE35C4", Offset = "0x1AE35C4", VA = "0x1AE35C4")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1AE3668", Offset = "0x1AE3668", VA = "0x1AE3668")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1AE3694", Offset = "0x1AE3694", VA = "0x1AE3694")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1AE36E4", Offset = "0x1AE36E4", VA = "0x1AE36E4")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1AE3750", Offset = "0x1AE3750", VA = "0x1AE3750")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1AE3864", Offset = "0x1AE3864", VA = "0x1AE3864")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1AE395C", Offset = "0x1AE395C", VA = "0x1AE395C")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1AE39B8", Offset = "0x1AE39B8", VA = "0x1AE39B8")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200005B")]
	public abstract class LazySingleton<T> : MonoBehaviour where T : LazySingleton<T>
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700001D")]
		public static bool hasInstance
		{
			[Token(Token = "0x600031A")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		public static T instance
		{
			[Token(Token = "0x600031B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031C")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600031D")]
		protected LazySingleton()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public enum ShowIfMode
	{
		[Token(Token = "0x400029D")]
		Disabled,
		[Token(Token = "0x400029E")]
		Hidden
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x7E7D84", Offset = "0x7E7D84")]
	public class ShowIfAttribute : PropertyAttribute
	{
		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E91A4", Offset = "0x7E91A4")]
		private string <propName>k__BackingField;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E91B4", Offset = "0x7E91B4")]
		private object <propValue>k__BackingField;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E91C4", Offset = "0x7E91C4")]
		private object <otherPropValue>k__BackingField;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E91D4", Offset = "0x7E91D4")]
		private bool <indent>k__BackingField;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E91E4", Offset = "0x7E91E4")]
		private ShowIfMode <mode>k__BackingField;

		[Token(Token = "0x1700001F")]
		public string propName
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x1AF3008", Offset = "0x1AF3008", VA = "0x1AF3008")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F43A8", Offset = "0x7F43A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x1AF3010", Offset = "0x1AF3010", VA = "0x1AF3010")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F43B8", Offset = "0x7F43B8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public object propValue
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x1AF3018", Offset = "0x1AF3018", VA = "0x1AF3018")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F43C8", Offset = "0x7F43C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x1AF3020", Offset = "0x1AF3020", VA = "0x1AF3020")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F43D8", Offset = "0x7F43D8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public object otherPropValue
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x1AF3028", Offset = "0x1AF3028", VA = "0x1AF3028")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F43E8", Offset = "0x7F43E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x1AF3030", Offset = "0x1AF3030", VA = "0x1AF3030")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F43F8", Offset = "0x7F43F8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public bool indent
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x1AF3038", Offset = "0x1AF3038", VA = "0x1AF3038")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4408", Offset = "0x7F4408")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x1AF3040", Offset = "0x1AF3040", VA = "0x1AF3040")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4418", Offset = "0x7F4418")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public ShowIfMode mode
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x1AF304C", Offset = "0x1AF304C", VA = "0x1AF304C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4428", Offset = "0x7F4428")]
			get
			{
				return default(ShowIfMode);
			}
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x1AF3054", Offset = "0x1AF3054", VA = "0x1AF3054")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4438", Offset = "0x7F4438")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1AF305C", Offset = "0x1AF305C", VA = "0x1AF305C")]
		public ShowIfAttribute(string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x7E7DBC", Offset = "0x7E7DBC")]
	public class ShowRangeIfAttribute : ShowIfAttribute
	{
		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E91F4", Offset = "0x7E91F4")]
		private float <min>k__BackingField;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E9204", Offset = "0x7E9204")]
		private float <max>k__BackingField;

		[Token(Token = "0x17000024")]
		public float min
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x1AF3274", Offset = "0x1AF3274", VA = "0x1AF3274")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4448", Offset = "0x7F4448")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x1AF327C", Offset = "0x1AF327C", VA = "0x1AF327C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4458", Offset = "0x7F4458")]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public float max
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1AF3284", Offset = "0x1AF3284", VA = "0x1AF3284")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4468", Offset = "0x7F4468")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x1AF328C", Offset = "0x1AF328C", VA = "0x1AF328C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4478", Offset = "0x7F4478")]
			private set
			{
			}
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1AF3294", Offset = "0x1AF3294", VA = "0x1AF3294")]
		public ShowRangeIfAttribute(float min, float max, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class ShowLargeHeaderIf : ShowIfAttribute
	{
		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string name;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string color;

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1AF30E0", Offset = "0x1AF30E0", VA = "0x1AF30E0")]
		public ShowLargeHeaderIf(string name, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1AF31A8", Offset = "0x1AF31A8", VA = "0x1AF31A8")]
		public ShowLargeHeaderIf(string name, string color, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1BB9944", Offset = "0x1BB9944", VA = "0x1BB9944")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1BB99D0", Offset = "0x1BB99D0", VA = "0x1BB99D0")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000061")]
	public static class QuaTools
	{
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1AEB7D8", Offset = "0x1AEB7D8", VA = "0x1AEB7D8")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1AEB834", Offset = "0x1AEB834", VA = "0x1AEB834")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1AEB8C4", Offset = "0x1AEB8C4", VA = "0x1AEB8C4")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1AEBA24", Offset = "0x1AEBA24", VA = "0x1AEBA24")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1AEBAE0", Offset = "0x1AEBAE0", VA = "0x1AEBAE0")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1AEBB9C", Offset = "0x1AEBB9C", VA = "0x1AEBB9C")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1AEBD48", Offset = "0x1AEBD48", VA = "0x1AEBD48")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1AEBD98", Offset = "0x1AEBD98", VA = "0x1AEBD98")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1AEBDE8", Offset = "0x1AEBDE8", VA = "0x1AEBDE8")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1AEBE90", Offset = "0x1AEBE90", VA = "0x1AEBE90")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1AEBF38", Offset = "0x1AEBF38", VA = "0x1AEBF38")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1AEC018", Offset = "0x1AEC018", VA = "0x1AEC018")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1AEC06C", Offset = "0x1AEC06C", VA = "0x1AEC06C")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1AEAFF0", Offset = "0x1AEAFF0", VA = "0x1AEAFF0")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1AEC140", Offset = "0x1AEC140", VA = "0x1AEC140")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1AEC2D0", Offset = "0x1AEC2D0", VA = "0x1AEC2D0")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1AEC3C4", Offset = "0x1AEC3C4", VA = "0x1AEC3C4")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetAxis1, Vector3 targetAxis2, Vector3 axis1, Vector3 axis2)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1AEC4D0", Offset = "0x1AEC4D0", VA = "0x1AEC4D0")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1AEC5BC", Offset = "0x1AEC5BC", VA = "0x1AEC5BC")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1AEC618", Offset = "0x1AEC618", VA = "0x1AEC618")]
		public static Quaternion MirrorYZ(Quaternion r, Quaternion space)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1AEC754", Offset = "0x1AEC754", VA = "0x1AEC754")]
		public static Quaternion MirrorYZ(Quaternion r)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000062")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000026")]
		public static T instance
		{
			[Token(Token = "0x6000348")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000349")]
		public static void Clear()
		{
		}

		[Token(Token = "0x600034A")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600034B")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9214", Offset = "0x7E9214")]
		public bool fixTransforms;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000027")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0xED70C4", Offset = "0xED70C4", VA = "0xED70C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000028")]
		private bool isAnimated
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0xED7410", Offset = "0xED7410", VA = "0xED7410")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xED6F84", Offset = "0xED6F84", VA = "0xED6F84")]
		public void Disable()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xED7024", Offset = "0xED7024", VA = "0xED7024", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xED7028", Offset = "0xED7028", VA = "0xED7028", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xED702C", Offset = "0xED702C", VA = "0xED702C", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xED7030", Offset = "0xED7030", VA = "0xED7030")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xED70C0", Offset = "0xED70C0", VA = "0xED70C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xED7068", Offset = "0xED7068", VA = "0xED7068")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xED73C4", Offset = "0xED73C4", VA = "0xED73C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xED71B0", Offset = "0xED71B0", VA = "0xED71B0")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xED74C8", Offset = "0xED74C8", VA = "0xED74C8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xED7524", Offset = "0xED7524", VA = "0xED7524")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xED7580", Offset = "0xED7580", VA = "0xED7580")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xED75C8", Offset = "0xED75C8", VA = "0xED75C8")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xED81D4", Offset = "0xED81D4", VA = "0xED81D4")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xED8294", Offset = "0xED8294", VA = "0xED8294")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xED8354", Offset = "0xED8354", VA = "0xED8354")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xED8414", Offset = "0xED8414", VA = "0xED8414")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public static class V2Tools
	{
		[Token(Token = "0x6000360")]
		[Address(RVA = "0xEDA740", Offset = "0xEDA740", VA = "0xEDA740")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xEDA748", Offset = "0xEDA748", VA = "0xEDA748")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xEDA798", Offset = "0xEDA798", VA = "0xEDA798")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xEDA7EC", Offset = "0xEDA7EC", VA = "0xEDA7EC")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xEDA8C4", Offset = "0xEDA8C4", VA = "0xEDA8C4")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000066")]
	public static class V3Tools
	{
		[Token(Token = "0x6000365")]
		[Address(RVA = "0xEDA958", Offset = "0xEDA958", VA = "0xEDA958")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xEDA97C", Offset = "0xEDA97C", VA = "0xEDA97C")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xEDA9C4", Offset = "0xEDA9C4", VA = "0xEDA9C4")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xEDAA50", Offset = "0xEDAA50", VA = "0xEDAA50")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xEDAAB0", Offset = "0xEDAAB0", VA = "0xEDAAB0")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xEDAB10", Offset = "0xEDAB10", VA = "0xEDAB10")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xEDAC2C", Offset = "0xEDAC2C", VA = "0xEDAC2C")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xEDACCC", Offset = "0xEDACCC", VA = "0xEDACCC")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xEDAD08", Offset = "0xEDAD08", VA = "0xEDAD08")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xEDADD8", Offset = "0xEDADD8", VA = "0xEDADD8")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xEDAED0", Offset = "0xEDAED0", VA = "0xEDAED0")]
		public static Vector3 Flatten(Vector3 v, Vector3 normal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xEDAF78", Offset = "0xEDAF78", VA = "0xEDAF78")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xEDB0D4", Offset = "0xEDB0D4", VA = "0xEDB0D4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xEDB250", Offset = "0xEDB250", VA = "0xEDB250")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xEDB3D4", Offset = "0xEDB3D4", VA = "0xEDB3D4")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xEDB490", Offset = "0xEDB490", VA = "0xEDB490")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xEDB590", Offset = "0xEDB590", VA = "0xEDB590")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xEDB618", Offset = "0xEDB618", VA = "0xEDB618")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xEDB6B4", Offset = "0xEDB6B4", VA = "0xEDB6B4")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xEDB758", Offset = "0xEDB758", VA = "0xEDB758")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xEDB748", Offset = "0xEDB748", VA = "0xEDB748")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000067")]
	public static class Warning
	{
		[Token(Token = "0x2000068")]
		public delegate void Logger(string message);

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xEE1118", Offset = "0xEE1118", VA = "0xEE1118")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xEE11B0", Offset = "0xEE11B0", VA = "0xEE11B0")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E7DF4", Offset = "0x7E7DF4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E7DF4", Offset = "0x7E7DF4")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1C58B24", Offset = "0x1C58B24", VA = "0x1C58B24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4488", Offset = "0x7F4488")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1C58B6C", Offset = "0x1C58B6C", VA = "0x1C58B6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F44C0", Offset = "0x7F44C0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1C58BB4", Offset = "0x1C58BB4", VA = "0x1C58BB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F44F8", Offset = "0x7F44F8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1C58BFC", Offset = "0x1C58BFC", VA = "0x1C58BFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4530", Offset = "0x7F4530")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1C58C44", Offset = "0x1C58C44", VA = "0x1C58C44")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1C58CE0", Offset = "0x1C58CE0", VA = "0x1C58CE0")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1C58D00", Offset = "0x1C58D00", VA = "0x1C58D00")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1C58D30", Offset = "0x1C58D30", VA = "0x1C58D30")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1C58D60", Offset = "0x1C58D60", VA = "0x1C58D60")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1C58DA0", Offset = "0x1C58DA0", VA = "0x1C58DA0")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1C58DE4", Offset = "0x1C58DE4", VA = "0x1C58DE4")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1C58E08", Offset = "0x1C58E08", VA = "0x1C58E08")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1C58E2C", Offset = "0x1C58E2C", VA = "0x1C58E2C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1C58E54", Offset = "0x1C58E54", VA = "0x1C58E54")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1C58E80", Offset = "0x1C58E80", VA = "0x1C58E80")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1C58EAC", Offset = "0x1C58EAC", VA = "0x1C58EAC")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1C58C64", Offset = "0x1C58C64", VA = "0x1C58C64")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1C58ED4", Offset = "0x1C58ED4", VA = "0x1C58ED4")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1C58EE0", Offset = "0x1C58EE0", VA = "0x1C58EE0")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1C58EEC", Offset = "0x1C58EEC", VA = "0x1C58EEC")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1C59210", Offset = "0x1C59210", VA = "0x1C59210", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1C592B8", Offset = "0x1C592B8", VA = "0x1C592B8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1C596A4", Offset = "0x1C596A4", VA = "0x1C596A4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1C59830", Offset = "0x1C59830", VA = "0x1C59830")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1C59864", Offset = "0x1C59864", VA = "0x1C59864")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000029")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x1C5908C", Offset = "0x1C5908C", VA = "0x1C5908C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x1C59B5C", Offset = "0x1C59B5C", VA = "0x1C59B5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1C59580", Offset = "0x1C59580", VA = "0x1C59580")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1C59988", Offset = "0x1C59988", VA = "0x1C59988")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public abstract class Constraint
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700002B")]
		public bool isValid
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x1C95CA8", Offset = "0x1C95CA8", VA = "0x1C95CA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600039E")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1C95D14", Offset = "0x1C95D14", VA = "0x1C95D14")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1C95D1C", Offset = "0x1C95D1C", VA = "0x1C95D1C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1C95DDC", Offset = "0x1C95DDC", VA = "0x1C95DDC")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1C95DE4", Offset = "0x1C95DE4", VA = "0x1C95DE4")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700002C")]
		private bool positionChanged
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x1C95F20", Offset = "0x1C95F20", VA = "0x1C95F20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1C95E18", Offset = "0x1C95E18", VA = "0x1C95E18", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1C95F5C", Offset = "0x1C95F5C", VA = "0x1C95F5C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1C95F64", Offset = "0x1C95F64", VA = "0x1C95F64")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1C95F98", Offset = "0x1C95F98", VA = "0x1C95F98", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1C96018", Offset = "0x1C96018", VA = "0x1C96018")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1C96020", Offset = "0x1C96020", VA = "0x1C96020")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700002D")]
		private bool rotationChanged
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x1C9615C", Offset = "0x1C9615C", VA = "0x1C9615C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1C96054", Offset = "0x1C96054", VA = "0x1C96054", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1C96198", Offset = "0x1C96198", VA = "0x1C96198")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1C961A0", Offset = "0x1C961A0", VA = "0x1C961A0")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000070")]
	public class Constraints
	{
		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E924C", Offset = "0x7E924C")]
		public float positionWeight;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E9264", Offset = "0x7E9264")]
		public float rotationWeight;

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1C961D4", Offset = "0x1C961D4", VA = "0x1C961D4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1C96240", Offset = "0x1C96240", VA = "0x1C96240")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1C96298", Offset = "0x1C96298", VA = "0x1C96298")]
		public void Update()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1C96548", Offset = "0x1C96548", VA = "0x1C96548")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000072")]
		public enum DOF
		{
			[Token(Token = "0x40002E8")]
			One,
			[Token(Token = "0x40002E9")]
			Three
		}

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E927C", Offset = "0x7E927C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E927C", Offset = "0x7E927C")]
		public float weight;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E92D0", Offset = "0x7E92D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E92D0", Offset = "0x7E92D0")]
		public float rotationWeight;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9324", Offset = "0x7E9324")]
		public DOF rotationDOF;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E935C", Offset = "0x7E935C")]
		public bool fixBone1Twist;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9394", Offset = "0x7E9394")]
		public Transform bone1;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E93CC", Offset = "0x7E93CC")]
		public Transform bone2;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9404", Offset = "0x7E9404")]
		public Transform bone3;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E943C", Offset = "0x7E943C")]
		public Transform tip;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9474", Offset = "0x7E9474")]
		public Transform target;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E94AC", Offset = "0x7E94AC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 defaultBendNormal;

		[Token(Token = "0x1700002E")]
		public bool initiated
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x19CE140", Offset = "0x19CE140", VA = "0x19CE140")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4568", Offset = "0x7F4568")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x19CE148", Offset = "0x19CE148", VA = "0x19CE148")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4578", Offset = "0x7F4578")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x19CE154", Offset = "0x19CE154", VA = "0x19CE154")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x19CE174", Offset = "0x19CE174", VA = "0x19CE174")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x19CE194", Offset = "0x19CE194", VA = "0x19CE194")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x19CE1B4", Offset = "0x19CE1B4", VA = "0x19CE1B4")]
			set
			{
			}
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x19CE1D4", Offset = "0x19CE1D4", VA = "0x19CE1D4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x19CE2E8", Offset = "0x19CE2E8", VA = "0x19CE2E8")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x19CE878", Offset = "0x19CE878", VA = "0x19CE878")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x19CE950", Offset = "0x19CE950", VA = "0x19CE950")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x19CEA14", Offset = "0x19CEA14", VA = "0x19CEA14")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x19CEE9C", Offset = "0x19CEE9C", VA = "0x19CEE9C")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E94BC", Offset = "0x7E94BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E94BC", Offset = "0x7E94BC")]
		public float weight;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E9510", Offset = "0x7E9510")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000031")]
		public bool initiated
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x19CEEAC", Offset = "0x19CEEAC", VA = "0x19CEEAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4588", Offset = "0x7F4588")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x19CEEB4", Offset = "0x19CEEB4", VA = "0x19CEEB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4598", Offset = "0x7F4598")]
			private set
			{
			}
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x19CEEC0", Offset = "0x19CEEC0", VA = "0x19CEEC0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x19CEF48", Offset = "0x19CEF48", VA = "0x19CEF48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F45A8", Offset = "0x7F45A8")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x19CF2D4", Offset = "0x19CF2D4", VA = "0x19CF2D4")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x19CF498", Offset = "0x19CF498", VA = "0x19CF498")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x19CF1D0", Offset = "0x19CF1D0", VA = "0x19CF1D0")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x19CF624", Offset = "0x19CF624", VA = "0x19CF624", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x19CF6E4", Offset = "0x19CF6E4", VA = "0x19CF6E4")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x19CF75C", Offset = "0x19CF75C", VA = "0x19CF75C")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x19CF7D0", Offset = "0x19CF7D0", VA = "0x19CF7D0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x19CF838", Offset = "0x19CF838", VA = "0x19CF838", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x19CF83C", Offset = "0x19CF83C", VA = "0x19CF83C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x19CF850", Offset = "0x19CF850", VA = "0x19CF850")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000075")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E9520", Offset = "0x7E9520")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9520", Offset = "0x7E9520")]
		public float weight;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9574", Offset = "0x7E9574")]
		public Grounding solver;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GrounderDelegate OnPostIK;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E95AC", Offset = "0x7E95AC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000032")]
		public bool initiated
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x19D7D24", Offset = "0x19D7D24", VA = "0x19D7D24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F45E0", Offset = "0x7F45E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x19D7D2C", Offset = "0x19D7D2C", VA = "0x19D7D2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F45F0", Offset = "0x7F45F0")]
			protected set
			{
			}
		}

		[Token(Token = "0x60003CC")]
		public abstract void ResetPosition();

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x19D7D38", Offset = "0x19D7D38", VA = "0x19D7D38")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x19D7EE4", Offset = "0x19D7EE4", VA = "0x19D7EE4")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x19D7DE4", Offset = "0x19D7DE4", VA = "0x19D7DE4")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x19D7F18", Offset = "0x19D7F18", VA = "0x19D7F18")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D3")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60003D4")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x19D8054", Offset = "0x19D8054", VA = "0x19D8054")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E7E54", Offset = "0x7E7E54")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E7E54", Offset = "0x7E7E54")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E95BC", Offset = "0x7E95BC")]
		public BipedIK ik;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E95F4", Offset = "0x7E95F4")]
		public float spineBend;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E962C", Offset = "0x7E962C")]
		public float spineSpeed;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 spineOffset;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float lastWeight;

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x19D8248", Offset = "0x19D8248", VA = "0x19D8248", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4600", Offset = "0x7F4600")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x19D8290", Offset = "0x19D8290", VA = "0x19D8290", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4638", Offset = "0x7F4638")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x19D82D8", Offset = "0x19D82D8", VA = "0x19D82D8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x19D83A0", Offset = "0x19D83A0", VA = "0x19D83A0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x19D844C", Offset = "0x19D844C", VA = "0x19D844C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x19D84AC", Offset = "0x19D84AC", VA = "0x19D84AC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x19D8A98", Offset = "0x19D8A98", VA = "0x19D8A98")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x19D8AEC", Offset = "0x19D8AEC", VA = "0x19D8AEC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x19D9170", Offset = "0x19D9170", VA = "0x19D9170")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x19D9288", Offset = "0x19D9288", VA = "0x19D9288")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x19D93E8", Offset = "0x19D93E8", VA = "0x19D93E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x19D95AC", Offset = "0x19D95AC", VA = "0x19D95AC")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E7EB4", Offset = "0x7E7EB4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E7EB4", Offset = "0x7E7EB4")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000078")]
		public class SpineEffector
		{
			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E970C", Offset = "0x7E970C")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9744", Offset = "0x7E9744")]
			public float horizontalWeight;

			[Token(Token = "0x4000305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E977C", Offset = "0x7E977C")]
			public float verticalWeight;

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x1BE4B40", Offset = "0x1BE4B40", VA = "0x1BE4B40")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x1BE4B50", Offset = "0x1BE4B50", VA = "0x1BE4B50")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9664", Offset = "0x7E9664")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E969C", Offset = "0x7E969C")]
		public float spineBend;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E96D4", Offset = "0x7E96D4")]
		public float spineSpeed;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] feet;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool firstSolve;

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x19D99FC", Offset = "0x19D99FC", VA = "0x19D99FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4670", Offset = "0x7F4670")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x19D9A44", Offset = "0x19D9A44", VA = "0x19D9A44", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F46A8", Offset = "0x7F46A8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x19D9A8C", Offset = "0x19D9A8C", VA = "0x19D9A8C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F46E0", Offset = "0x7F46E0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x19D9AD4", Offset = "0x19D9AD4", VA = "0x19D9AD4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x19D9B10", Offset = "0x19D9B10", VA = "0x19D9B10")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x19D9BA4", Offset = "0x19D9BA4", VA = "0x19D9BA4")]
		private void Update()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x19D9ED8", Offset = "0x19D9ED8", VA = "0x19D9ED8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x19D9EE4", Offset = "0x19D9EE4", VA = "0x19D9EE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x19D9C0C", Offset = "0x19D9C0C", VA = "0x19D9C0C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x19D9EF0", Offset = "0x19D9EF0", VA = "0x19D9EF0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x19DA20C", Offset = "0x19DA20C", VA = "0x19DA20C")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x19DA31C", Offset = "0x19DA31C", VA = "0x19DA31C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x19DA498", Offset = "0x19DA498", VA = "0x19DA498")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x19DA4AC", Offset = "0x19DA4AC", VA = "0x19DA4AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x19DA660", Offset = "0x19DA660", VA = "0x19DA660")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E7F14", Offset = "0x7E7F14")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E7F14", Offset = "0x7E7F14")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IK[] legs;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E97B4", Offset = "0x7E97B4")]
		public Transform pelvis;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E97EC", Offset = "0x7E97EC")]
		public Transform characterRoot;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9824", Offset = "0x7E9824")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E9824", Offset = "0x7E9824")]
		public float rootRotationWeight;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9878", Offset = "0x7E9878")]
		public float rootRotationSpeed;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E98B0", Offset = "0x7E98B0")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform[] feet;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int solvedFeet;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool solved;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float lastWeight;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x19DA700", Offset = "0x19DA700", VA = "0x19DA700", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4718", Offset = "0x7F4718")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x19DA748", Offset = "0x19DA748", VA = "0x19DA748", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4750", Offset = "0x7F4750")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x19DA790", Offset = "0x19DA790", VA = "0x19DA790", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x19DA98C", Offset = "0x19DA98C", VA = "0x19DA98C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x19DABC0", Offset = "0x19DABC0", VA = "0x19DABC0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x19DACBC", Offset = "0x19DACBC", VA = "0x19DACBC")]
		private void Update()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x19DB26C", Offset = "0x19DB26C", VA = "0x19DB26C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x19DB6D0", Offset = "0x19DB6D0", VA = "0x19DB6D0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x19DB85C", Offset = "0x19DB85C", VA = "0x19DB85C")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x19DBB60", Offset = "0x19DBB60", VA = "0x19DBB60")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x19DBCCC", Offset = "0x19DBCCC", VA = "0x19DBCCC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x19DBED8", Offset = "0x19DBED8", VA = "0x19DBED8")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E7F74", Offset = "0x7E7F74")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E7F74", Offset = "0x7E7F74")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x200007B")]
		public struct Foot
		{
			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x1BE4B98", Offset = "0x1BE4B98", VA = "0x1BE4B98")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E98E8", Offset = "0x7E98E8")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9920", Offset = "0x7E9920")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E9920", Offset = "0x7E9920")]
		public float rootRotationWeight;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E9974", Offset = "0x7E9974")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9974", Offset = "0x7E9974")]
		public float minRootRotation;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E99CC", Offset = "0x7E99CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E99CC", Offset = "0x7E99CC")]
		public float maxRootRotation;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9A24", Offset = "0x7E9A24")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9A5C", Offset = "0x7E9A5C")]
		public float maxLegOffset;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9A94", Offset = "0x7E9A94")]
		public float maxForeLegOffset;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9ACC", Offset = "0x7E9ACC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E9ACC", Offset = "0x7E9ACC")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9B20", Offset = "0x7E9B20")]
		public Transform characterRoot;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9B58", Offset = "0x7E9B58")]
		public Transform pelvis;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9B90", Offset = "0x7E9B90")]
		public Transform lastSpineBone;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9BC8", Offset = "0x7E9BC8")]
		public Transform head;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] legs;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IK[] forelegs;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Foot[] feet;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int solvedFeet;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private bool solved;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float angle;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Transform forefeetRoot;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Quaternion headRotation;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float lastWeight;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x19DBF78", Offset = "0x19DBF78", VA = "0x19DBF78", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4788", Offset = "0x7F4788")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x19DBFC0", Offset = "0x19DBFC0", VA = "0x19DBFC0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F47C0", Offset = "0x7F47C0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x19DC008", Offset = "0x19DC008", VA = "0x19DC008", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x19DC190", Offset = "0x19DC190", VA = "0x19DC190")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x19DC2BC", Offset = "0x19DC2BC", VA = "0x19DC2BC")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x19DC4C0", Offset = "0x19DC4C0", VA = "0x19DC4C0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x19DC528", Offset = "0x19DC528", VA = "0x19DC528")]
		private void Update()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x19DC58C", Offset = "0x19DC58C", VA = "0x19DC58C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x19DC8EC", Offset = "0x19DC8EC", VA = "0x19DC8EC")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x19DCC84", Offset = "0x19DCC84", VA = "0x19DCC84")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x19DCD7C", Offset = "0x19DCD7C", VA = "0x19DCD7C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x19DD148", Offset = "0x19DD148", VA = "0x19DD148")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x19DD768", Offset = "0x19DD768", VA = "0x19DD768")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x19DD938", Offset = "0x19DD938", VA = "0x19DD938")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x19DDA14", Offset = "0x19DDA14", VA = "0x19DDA14")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x19DDC80", Offset = "0x19DDC80", VA = "0x19DDC80")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x19DDCB8", Offset = "0x19DDCB8", VA = "0x19DDCB8")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x19DDEBC", Offset = "0x19DDEBC", VA = "0x19DDEBC")]
		public GrounderQuadruped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007C")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x200007D")]
		public enum Quality
		{
			[Token(Token = "0x4000351")]
			Fastest,
			[Token(Token = "0x4000352")]
			Simple,
			[Token(Token = "0x4000353")]
			Best
		}

		[Token(Token = "0x200007E")]
		public delegate bool OnRaycastDelegate(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		[Token(Token = "0x200007F")]
		public delegate bool OnCapsuleCastDelegate(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		[Token(Token = "0x2000080")]
		public delegate bool OnSphereCastDelegate(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		[Token(Token = "0x2000081")]
		public class Leg
		{
			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EA0BC", Offset = "0x7EA0BC")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EA0CC", Offset = "0x7EA0CC")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EA0DC", Offset = "0x7EA0DC")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EA0EC", Offset = "0x7EA0EC")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EA0FC", Offset = "0x7EA0FC")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EA10C", Offset = "0x7EA10C")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EA11C", Offset = "0x7EA11C")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EA12C", Offset = "0x7EA12C")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EA13C", Offset = "0x7EA13C")]
			private RaycastHit <capsuleHit>k__BackingField;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x1700003B")]
			public bool isGrounded
			{
				[Token(Token = "0x600043A")]
				[Address(RVA = "0x1BE4BFC", Offset = "0x1BE4BFC", VA = "0x1BE4BFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4898", Offset = "0x7F4898")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600043B")]
				[Address(RVA = "0x1BE4C04", Offset = "0x1BE4C04", VA = "0x1BE4C04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F48A8", Offset = "0x7F48A8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700003C")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x600043C")]
				[Address(RVA = "0x1BE4C10", Offset = "0x1BE4C10", VA = "0x1BE4C10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F48B8", Offset = "0x7F48B8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600043D")]
				[Address(RVA = "0x1BE4C1C", Offset = "0x1BE4C1C", VA = "0x1BE4C1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F48C8", Offset = "0x7F48C8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700003D")]
			public bool initiated
			{
				[Token(Token = "0x600043E")]
				[Address(RVA = "0x1BE4C28", Offset = "0x1BE4C28", VA = "0x1BE4C28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F48D8", Offset = "0x7F48D8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600043F")]
				[Address(RVA = "0x1BE4C30", Offset = "0x1BE4C30", VA = "0x1BE4C30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F48E8", Offset = "0x7F48E8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700003E")]
			public float heightFromGround
			{
				[Token(Token = "0x6000440")]
				[Address(RVA = "0x1BE4C3C", Offset = "0x1BE4C3C", VA = "0x1BE4C3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F48F8", Offset = "0x7F48F8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000441")]
				[Address(RVA = "0x1BE4C44", Offset = "0x1BE4C44", VA = "0x1BE4C44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4908", Offset = "0x7F4908")]
				private set
				{
				}
			}

			[Token(Token = "0x1700003F")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000442")]
				[Address(RVA = "0x1BE4C4C", Offset = "0x1BE4C4C", VA = "0x1BE4C4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4918", Offset = "0x7F4918")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000443")]
				[Address(RVA = "0x1BE4C58", Offset = "0x1BE4C58", VA = "0x1BE4C58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4928", Offset = "0x7F4928")]
				private set
				{
				}
			}

			[Token(Token = "0x17000040")]
			public Transform transform
			{
				[Token(Token = "0x6000444")]
				[Address(RVA = "0x1BE4C64", Offset = "0x1BE4C64", VA = "0x1BE4C64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4938", Offset = "0x7F4938")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000445")]
				[Address(RVA = "0x1BE4C6C", Offset = "0x1BE4C6C", VA = "0x1BE4C6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4948", Offset = "0x7F4948")]
				private set
				{
				}
			}

			[Token(Token = "0x17000041")]
			public float IKOffset
			{
				[Token(Token = "0x6000446")]
				[Address(RVA = "0x1BE4C74", Offset = "0x1BE4C74", VA = "0x1BE4C74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4958", Offset = "0x7F4958")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000447")]
				[Address(RVA = "0x1BE4C7C", Offset = "0x1BE4C7C", VA = "0x1BE4C7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4968", Offset = "0x7F4968")]
				private set
				{
				}
			}

			[Token(Token = "0x17000042")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x6000448")]
				[Address(RVA = "0x1BE4C84", Offset = "0x1BE4C84", VA = "0x1BE4C84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4978", Offset = "0x7F4978")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000449")]
				[Address(RVA = "0x1BE4C9C", Offset = "0x1BE4C9C", VA = "0x1BE4C9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4988", Offset = "0x7F4988")]
				private set
				{
				}
			}

			[Token(Token = "0x17000043")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x600044A")]
				[Address(RVA = "0x1BE4CBC", Offset = "0x1BE4CBC", VA = "0x1BE4CBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4998", Offset = "0x7F4998")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x600044B")]
				[Address(RVA = "0x1BE4CD4", Offset = "0x1BE4CD4", VA = "0x1BE4CD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F49A8", Offset = "0x7F49A8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000044")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x600044C")]
				[Address(RVA = "0x1BE4CF4", Offset = "0x1BE4CF4", VA = "0x1BE4CF4")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x17000045")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x1BE5EA8", Offset = "0x1BE5EA8", VA = "0x1BE5EA8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000046")]
			private float rootYOffset
			{
				[Token(Token = "0x600045B")]
				[Address(RVA = "0x1BE6710", Offset = "0x1BE6710", VA = "0x1BE6710")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x1BE4D3C", Offset = "0x1BE4D3C", VA = "0x1BE4D3C")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x1BE4D50", Offset = "0x1BE4D50", VA = "0x1BE4D50")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x600044F")]
			[Address(RVA = "0x1BE4DE0", Offset = "0x1BE4DE0", VA = "0x1BE4DE0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000450")]
			[Address(RVA = "0x1BE4E2C", Offset = "0x1BE4E2C", VA = "0x1BE4E2C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000451")]
			[Address(RVA = "0x1BE4E9C", Offset = "0x1BE4E9C", VA = "0x1BE4E9C")]
			public void Process()
			{
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x1BE5B34", Offset = "0x1BE5B34", VA = "0x1BE5B34")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x1BE56E8", Offset = "0x1BE56E8", VA = "0x1BE56E8")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x1BE6640", Offset = "0x1BE6640", VA = "0x1BE6640")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x1BE5970", Offset = "0x1BE5970", VA = "0x1BE5970")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x1BE59FC", Offset = "0x1BE59FC", VA = "0x1BE59FC")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x1BE66B0", Offset = "0x1BE66B0", VA = "0x1BE66B0")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x1BE5ED0", Offset = "0x1BE5ED0", VA = "0x1BE5ED0")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0x1BE67A4", Offset = "0x1BE67A4", VA = "0x1BE67A4")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x1BE6830", Offset = "0x1BE6830", VA = "0x1BE6830")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000082")]
		public class Pelvis
		{
			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EA14C", Offset = "0x7EA14C")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EA15C", Offset = "0x7EA15C")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x17000047")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x600045D")]
				[Address(RVA = "0x1BE711C", Offset = "0x1BE711C", VA = "0x1BE711C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F49B8", Offset = "0x7F49B8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600045E")]
				[Address(RVA = "0x1BE7128", Offset = "0x1BE7128", VA = "0x1BE7128")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F49C8", Offset = "0x7F49C8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000048")]
			public float heightOffset
			{
				[Token(Token = "0x600045F")]
				[Address(RVA = "0x1BE7134", Offset = "0x1BE7134", VA = "0x1BE7134")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F49D8", Offset = "0x7F49D8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000460")]
				[Address(RVA = "0x1BE713C", Offset = "0x1BE713C", VA = "0x1BE713C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F49E8", Offset = "0x7F49E8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x1BE7144", Offset = "0x1BE7144", VA = "0x1BE7144")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x1BE71D4", Offset = "0x1BE71D4", VA = "0x1BE71D4")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x1BE7174", Offset = "0x1BE7174", VA = "0x1BE7174")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x1BE7240", Offset = "0x1BE7240", VA = "0x1BE7240")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x1BE73E0", Offset = "0x1BE73E0", VA = "0x1BE73E0")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9C10", Offset = "0x7E9C10")]
		public LayerMask layers;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9C48", Offset = "0x7E9C48")]
		public float maxStep;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9C80", Offset = "0x7E9C80")]
		public float heightOffset;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9CB8", Offset = "0x7E9CB8")]
		public float footSpeed;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9CF0", Offset = "0x7E9CF0")]
		public float footRadius;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9D28", Offset = "0x7E9D28")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9D74", Offset = "0x7E9D74")]
		public float prediction;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9DAC", Offset = "0x7E9DAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E9DAC", Offset = "0x7E9DAC")]
		public float footRotationWeight;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9E00", Offset = "0x7E9E00")]
		public float footRotationSpeed;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E9E38", Offset = "0x7E9E38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9E38", Offset = "0x7E9E38")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9E90", Offset = "0x7E9E90")]
		public bool rotateSolver;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9EC8", Offset = "0x7E9EC8")]
		public float pelvisSpeed;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9F00", Offset = "0x7E9F00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7E9F00", Offset = "0x7E9F00")]
		public float pelvisDamper;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9F54", Offset = "0x7E9F54")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9F8C", Offset = "0x7E9F8C")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9FC4", Offset = "0x7E9FC4")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7E9FFC", Offset = "0x7E9FFC")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA034", Offset = "0x7EA034")]
		public Quality quality;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EA06C", Offset = "0x7EA06C")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EA07C", Offset = "0x7EA07C")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EA08C", Offset = "0x7EA08C")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EA09C", Offset = "0x7EA09C")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EA0AC", Offset = "0x7EA0AC")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public OnRaycastDelegate Raycast;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public OnCapsuleCastDelegate CapsuleCast;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public OnSphereCastDelegate SphereCast;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool initiated;

		[Token(Token = "0x17000033")]
		public Leg[] legs
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x19DDF80", Offset = "0x19DDF80", VA = "0x19DDF80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F47F8", Offset = "0x7F47F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x19DDF88", Offset = "0x19DDF88", VA = "0x19DDF88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4808", Offset = "0x7F4808")]
			private set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x19DDF90", Offset = "0x19DDF90", VA = "0x19DDF90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4818", Offset = "0x7F4818")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x19DDF98", Offset = "0x19DDF98", VA = "0x19DDF98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4828", Offset = "0x7F4828")]
			private set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public bool isGrounded
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x19DDFA0", Offset = "0x19DDFA0", VA = "0x19DDFA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4838", Offset = "0x7F4838")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x19DDFA8", Offset = "0x19DDFA8", VA = "0x19DDFA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4848", Offset = "0x7F4848")]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Transform root
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x19DDFB4", Offset = "0x19DDFB4", VA = "0x19DDFB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4858", Offset = "0x7F4858")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x19DDFBC", Offset = "0x19DDFBC", VA = "0x19DDFBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4868", Offset = "0x7F4868")]
			private set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x19DDFC4", Offset = "0x19DDFC4", VA = "0x19DDFC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4878", Offset = "0x7F4878")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x19DDFDC", Offset = "0x19DDFDC", VA = "0x19DDFDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F4888", Offset = "0x7F4888")]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x19DDFFC", Offset = "0x19DDFFC", VA = "0x19DDFFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public Vector3 up
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x19D9244", Offset = "0x19D9244", VA = "0x19D9244")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003A")]
		private bool useRootRotation
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x19DE3E0", Offset = "0x19DE3E0", VA = "0x19DE3E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x19DE050", Offset = "0x19DE050", VA = "0x19DE050")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x19DE2B4", Offset = "0x19DE2B4", VA = "0x19DE2B4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x19D87C8", Offset = "0x19D87C8", VA = "0x19D87C8")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x19D8F00", Offset = "0x19D8F00", VA = "0x19D8F00")]
		public void Update()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x19DB10C", Offset = "0x19DB10C", VA = "0x19DB10C")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x19D8314", Offset = "0x19D8314", VA = "0x19D8314")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x19DE3C8", Offset = "0x19DE3C8", VA = "0x19DE3C8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x19DE460", Offset = "0x19DE460", VA = "0x19DE460")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x19DE4F0", Offset = "0x19DE4F0", VA = "0x19DE4F0")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x19DE5AC", Offset = "0x19DE5AC", VA = "0x19DE5AC")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x19D80C8", Offset = "0x19D80C8", VA = "0x19D80C8")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E7FD4", Offset = "0x7E7FD4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E7FD4", Offset = "0x7E7FD4")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1C517EC", Offset = "0x1C517EC", VA = "0x1C517EC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F49F8", Offset = "0x7F49F8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1C51834", Offset = "0x1C51834", VA = "0x1C51834", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4A30", Offset = "0x7F4A30")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1C5187C", Offset = "0x1C5187C", VA = "0x1C5187C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4A68", Offset = "0x7F4A68")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1C518C4", Offset = "0x1C518C4", VA = "0x1C518C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4AA0", Offset = "0x7F4AA0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1C5190C", Offset = "0x1C5190C", VA = "0x1C5190C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4AD8", Offset = "0x7F4AD8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1C51954", Offset = "0x1C51954", VA = "0x1C51954", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1C5195C", Offset = "0x1C5195C", VA = "0x1C5195C")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E8034", Offset = "0x7E8034")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E8034", Offset = "0x7E8034")]
	public class ArmIK : IK
	{
		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1C53410", Offset = "0x1C53410", VA = "0x1C53410", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4B10", Offset = "0x7F4B10")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1C53458", Offset = "0x1C53458", VA = "0x1C53458", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4B48", Offset = "0x7F4B48")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1C534A0", Offset = "0x1C534A0", VA = "0x1C534A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4B80", Offset = "0x7F4B80")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1C534E8", Offset = "0x1C534E8", VA = "0x1C534E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4BB8", Offset = "0x7F4BB8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1C53530", Offset = "0x1C53530", VA = "0x1C53530", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1C53538", Offset = "0x1C53538", VA = "0x1C53538")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E8094", Offset = "0x7E8094")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E8094", Offset = "0x7E8094")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1C62428", Offset = "0x1C62428", VA = "0x1C62428", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4BF0", Offset = "0x7F4BF0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1C62470", Offset = "0x1C62470", VA = "0x1C62470", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4C28", Offset = "0x7F4C28")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1C624B8", Offset = "0x1C624B8", VA = "0x1C624B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4C60", Offset = "0x7F4C60")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1C62500", Offset = "0x1C62500", VA = "0x1C62500")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4C98", Offset = "0x7F4C98")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1C62548", Offset = "0x1C62548", VA = "0x1C62548", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1C62550", Offset = "0x1C62550", VA = "0x1C62550")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E80F4", Offset = "0x7E80F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E80F4", Offset = "0x7E80F4")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1C98D4C", Offset = "0x1C98D4C", VA = "0x1C98D4C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4CD0", Offset = "0x7F4CD0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1C98D94", Offset = "0x1C98D94", VA = "0x1C98D94", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4D08", Offset = "0x7F4D08")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1C98DDC", Offset = "0x1C98DDC", VA = "0x1C98DDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4D40", Offset = "0x7F4D40")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1C98E24", Offset = "0x1C98E24", VA = "0x1C98E24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4D78", Offset = "0x7F4D78")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1C98E6C", Offset = "0x1C98E6C", VA = "0x1C98E6C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1C98E74", Offset = "0x1C98E74", VA = "0x1C98E74")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E8154", Offset = "0x7E8154")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E8154", Offset = "0x7E8154")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1C993BC", Offset = "0x1C993BC", VA = "0x1C993BC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4DB0", Offset = "0x7F4DB0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1C99404", Offset = "0x1C99404", VA = "0x1C99404", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4DE8", Offset = "0x7F4DE8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1C9944C", Offset = "0x1C9944C", VA = "0x1C9944C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4E20", Offset = "0x7F4E20")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1C99494", Offset = "0x1C99494", VA = "0x1C99494")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4E58", Offset = "0x7F4E58")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1C994DC", Offset = "0x1C994DC", VA = "0x1C994DC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1C994E4", Offset = "0x1C994E4", VA = "0x1C994E4")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E81B4", Offset = "0x7E81B4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E81B4", Offset = "0x7E81B4")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x19CF8C0", Offset = "0x19CF8C0", VA = "0x19CF8C0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4E90", Offset = "0x7F4E90")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x19CF908", Offset = "0x19CF908", VA = "0x19CF908", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4EC8", Offset = "0x7F4EC8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x19CF950", Offset = "0x19CF950", VA = "0x19CF950")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4F00", Offset = "0x7F4F00")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x19CF998", Offset = "0x19CF998", VA = "0x19CF998")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4F38", Offset = "0x7F4F38")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x19CF9E0", Offset = "0x19CF9E0", VA = "0x19CF9E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4F70", Offset = "0x7F4F70")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x19CFA28", Offset = "0x19CFA28", VA = "0x19CFA28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4FA8", Offset = "0x7F4FA8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x19CFA70", Offset = "0x19CFA70", VA = "0x19CFA70")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x19CFAB4", Offset = "0x19CFAB4", VA = "0x19CFAB4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x19CFABC", Offset = "0x19CFABC", VA = "0x19CFABC")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x19CFCA4", Offset = "0x19CFCA4", VA = "0x19CFCA4")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x19CFF44", Offset = "0x19CFF44", VA = "0x19CFF44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F4FE0", Offset = "0x7F4FE0")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x19CFF64", Offset = "0x19CFF64", VA = "0x19CFF64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5018", Offset = "0x7F5018")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x19D0054", Offset = "0x19D0054", VA = "0x19D0054")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000492")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x19E1CA4", Offset = "0x19E1CA4", VA = "0x19E1CA4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x19E1D2C", Offset = "0x19E1D2C", VA = "0x19E1D2C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x19E1DA0", Offset = "0x19E1DA0", VA = "0x19E1DA0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000496")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000497")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x19D00FC", Offset = "0x19D00FC", VA = "0x19D00FC")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA16C", Offset = "0x7EA16C")]
		public IK[] IKComponents;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA1A4", Offset = "0x7EA1A4")]
		public Animator animator;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000049")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x1E46238", Offset = "0x1E46238", VA = "0x1E46238")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1E462D0", Offset = "0x1E462D0", VA = "0x1E462D0")]
		private void Start()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1E46340", Offset = "0x1E46340", VA = "0x1E46340")]
		private void Update()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1E463FC", Offset = "0x1E463FC", VA = "0x1E463FC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1E46438", Offset = "0x1E46438", VA = "0x1E46438")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1E46374", Offset = "0x1E46374", VA = "0x1E46374")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1E46534", Offset = "0x1E46534", VA = "0x1E46534")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E8214", Offset = "0x7E8214")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E8214", Offset = "0x7E8214")]
	public class LegIK : IK
	{
		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1AE39E8", Offset = "0x1AE39E8", VA = "0x1AE39E8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5050", Offset = "0x7F5050")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1AE3A30", Offset = "0x1AE3A30", VA = "0x1AE3A30", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5088", Offset = "0x7F5088")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1AE3A78", Offset = "0x1AE3A78", VA = "0x1AE3A78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F50C0", Offset = "0x7F50C0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1AE3AC0", Offset = "0x1AE3AC0", VA = "0x1AE3AC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F50F8", Offset = "0x7F50F8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1AE3B08", Offset = "0x1AE3B08", VA = "0x1AE3B08", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1AE3B10", Offset = "0x1AE3B10", VA = "0x1AE3B10")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E8274", Offset = "0x7E8274")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E8274", Offset = "0x7E8274")]
	public class LimbIK : IK
	{
		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1AE3B80", Offset = "0x1AE3B80", VA = "0x1AE3B80", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5130", Offset = "0x7F5130")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1AE3BC8", Offset = "0x1AE3BC8", VA = "0x1AE3BC8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5168", Offset = "0x7F5168")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1AE3C10", Offset = "0x1AE3C10", VA = "0x1AE3C10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F51A0", Offset = "0x7F51A0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1AE3C58", Offset = "0x1AE3C58", VA = "0x1AE3C58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F51D8", Offset = "0x7F51D8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1AE3CA0", Offset = "0x1AE3CA0", VA = "0x1AE3CA0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1AE3CA8", Offset = "0x1AE3CA8", VA = "0x1AE3CA8")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E82D4", Offset = "0x7E82D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E82D4", Offset = "0x7E82D4")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1AE46B4", Offset = "0x1AE46B4", VA = "0x1AE46B4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5210", Offset = "0x7F5210")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1AE46FC", Offset = "0x1AE46FC", VA = "0x1AE46FC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5248", Offset = "0x7F5248")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1AE4744", Offset = "0x1AE4744", VA = "0x1AE4744")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5280", Offset = "0x7F5280")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1AE478C", Offset = "0x1AE478C", VA = "0x1AE478C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F52B8", Offset = "0x7F52B8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1AE47D4", Offset = "0x1AE47D4", VA = "0x1AE47D4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1AE47DC", Offset = "0x1AE47DC", VA = "0x1AE47DC")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E8334", Offset = "0x7E8334")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E8334", Offset = "0x7E8334")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xED841C", Offset = "0xED841C", VA = "0xED841C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F52F0", Offset = "0x7F52F0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xED8464", Offset = "0xED8464", VA = "0xED8464", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5328", Offset = "0x7F5328")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xED84AC", Offset = "0xED84AC", VA = "0xED84AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5360", Offset = "0x7F5360")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xED84F4", Offset = "0xED84F4", VA = "0xED84F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5398", Offset = "0x7F5398")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xED853C", Offset = "0xED853C", VA = "0xED853C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xED8544", Offset = "0xED8544", VA = "0xED8544")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E8394", Offset = "0x7E8394")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000090")]
		public class References
		{
			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EA290", Offset = "0x7EA290")]
			public Transform pelvis;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA2C8", Offset = "0x7EA2C8")]
			public Transform chest;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA300", Offset = "0x7EA300")]
			public Transform neck;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA338", Offset = "0x7EA338")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EA338", Offset = "0x7EA338")]
			public Transform leftShoulder;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA398", Offset = "0x7EA398")]
			public Transform leftUpperArm;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA3D0", Offset = "0x7EA3D0")]
			public Transform leftForearm;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA408", Offset = "0x7EA408")]
			public Transform leftHand;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EA440", Offset = "0x7EA440")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA440", Offset = "0x7EA440")]
			public Transform rightShoulder;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA4A0", Offset = "0x7EA4A0")]
			public Transform rightUpperArm;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA4D8", Offset = "0x7EA4D8")]
			public Transform rightForearm;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA510", Offset = "0x7EA510")]
			public Transform rightHand;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA548", Offset = "0x7EA548")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EA548", Offset = "0x7EA548")]
			public Transform leftThigh;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA5A8", Offset = "0x7EA5A8")]
			public Transform leftCalf;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA5E0", Offset = "0x7EA5E0")]
			public Transform leftFoot;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA618", Offset = "0x7EA618")]
			public Transform leftToes;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA650", Offset = "0x7EA650")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EA650", Offset = "0x7EA650")]
			public Transform rightThigh;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA6B0", Offset = "0x7EA6B0")]
			public Transform rightCalf;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA6E8", Offset = "0x7EA6E8")]
			public Transform rightFoot;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA720", Offset = "0x7EA720")]
			public Transform rightToes;

			[Token(Token = "0x1700004A")]
			public bool isFilled
			{
				[Token(Token = "0x60004C4")]
				[Address(RVA = "0x2004964", Offset = "0x2004964", VA = "0x2004964")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700004B")]
			public bool isEmpty
			{
				[Token(Token = "0x60004C5")]
				[Address(RVA = "0x2004F44", Offset = "0x2004F44", VA = "0x2004F44")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x20041F4", Offset = "0x20041F4", VA = "0x20041F4")]
			public References()
			{
			}

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x20041FC", Offset = "0x20041FC", VA = "0x20041FC")]
			public References(BipedReferences b)
			{
			}

			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x2004414", Offset = "0x2004414", VA = "0x2004414")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x20053BC", Offset = "0x20053BC", VA = "0x20053BC")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x7EA1DC", Offset = "0x7EA1DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA1DC", Offset = "0x7EA1DC")]
		public References references;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA258", Offset = "0x7EA258")]
		public IKSolverVR solver;

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xEDBB3C", Offset = "0xEDBB3C", VA = "0xEDBB3C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F53D0", Offset = "0x7F53D0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xEDBB84", Offset = "0xEDBB84", VA = "0xEDBB84", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5408", Offset = "0x7F5408")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xEDBBCC", Offset = "0xEDBBCC", VA = "0xEDBBCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5440", Offset = "0x7F5440")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xEDBC14", Offset = "0xEDBC14", VA = "0xEDBC14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5478", Offset = "0x7F5478")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xEDBC40", Offset = "0xEDBC40", VA = "0xEDBC40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F54B0", Offset = "0x7F54B0")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xEDBC68", Offset = "0xEDBC68", VA = "0xEDBC68", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xEDBC70", Offset = "0xEDBC70", VA = "0xEDBC70", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xEDBCF0", Offset = "0xEDBCF0", VA = "0xEDBCF0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xEDBE5C", Offset = "0xEDBE5C", VA = "0xEDBE5C")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000091")]
	public class FABRIKChain
	{
		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EA758", Offset = "0x7EA758")]
		public float pull;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EA770", Offset = "0x7EA770")]
		public float pin;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1C98EE4", Offset = "0x1C98EE4", VA = "0x1C98EE4")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1C98FC0", Offset = "0x1C98FC0", VA = "0x1C98FC0")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1C98FE0", Offset = "0x1C98FE0", VA = "0x1C98FE0")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1C99254", Offset = "0x1C99254", VA = "0x1C99254")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1C990B4", Offset = "0x1C990B4", VA = "0x1C990B4")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1C9934C", Offset = "0x1C9934C", VA = "0x1C9934C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1C99554", Offset = "0x1C99554", VA = "0x1C99554")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1C999CC", Offset = "0x1C999CC", VA = "0x1C999CC")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1C99B88", Offset = "0x1C99B88", VA = "0x1C99B88")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1C99CB8", Offset = "0x1C99CB8", VA = "0x1C99CB8")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000094")]
		public class BendBone
		{
			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EADC8", Offset = "0x7EADC8")]
			public Transform transform;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EAE00", Offset = "0x7EAE00")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAE00", Offset = "0x7EAE00")]
			public float weight;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x1BE3F14", Offset = "0x1BE3F14", VA = "0x1BE3F14")]
			public BendBone()
			{
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x1BE3F50", Offset = "0x1BE3F50", VA = "0x1BE3F50")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x1BE3FB4", Offset = "0x1BE3FB4", VA = "0x1BE3FB4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x1BE3FEC", Offset = "0x1BE3FEC", VA = "0x1BE3FEC")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA788", Offset = "0x7EA788")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EA7C0", Offset = "0x7EA7C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA7C0", Offset = "0x7EA7C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EA7C0", Offset = "0x7EA7C0")]
		public float positionWeight;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EA838", Offset = "0x7EA838")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA838", Offset = "0x7EA838")]
		public float bodyWeight;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EA88C", Offset = "0x7EA88C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA88C", Offset = "0x7EA88C")]
		public float thighWeight;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA8E0", Offset = "0x7EA8E0")]
		public bool handsPullBody;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EA918", Offset = "0x7EA918")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EA918", Offset = "0x7EA918")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA918", Offset = "0x7EA918")]
		public float rotationWeight;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EA990", Offset = "0x7EA990")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA990", Offset = "0x7EA990")]
		public float bodyClampWeight;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EA9E4", Offset = "0x7EA9E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EA9E4", Offset = "0x7EA9E4")]
		public float headClampWeight;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EAA38", Offset = "0x7EAA38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAA38", Offset = "0x7EAA38")]
		public float bendWeight;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EAA8C", Offset = "0x7EAA8C")]
		public BendBone[] bendBones;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EAAC4", Offset = "0x7EAAC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EAAC4", Offset = "0x7EAAC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAAC4", Offset = "0x7EAAC4")]
		public float CCDWeight;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EAB3C", Offset = "0x7EAB3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAB3C", Offset = "0x7EAB3C")]
		public float roll;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EAB90", Offset = "0x7EAB90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAB90", Offset = "0x7EAB90")]
		public float damper;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EABE8", Offset = "0x7EABE8")]
		public Transform[] CCDBones;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAC20", Offset = "0x7EAC20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EAC20", Offset = "0x7EAC20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EAC20", Offset = "0x7EAC20")]
		public float postStretchWeight;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EAC98", Offset = "0x7EAC98")]
		public float maxStretch;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EACD0", Offset = "0x7EACD0")]
		public float stretchDamper;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EAD08", Offset = "0x7EAD08")]
		public bool fixHead;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EAD40", Offset = "0x7EAD40")]
		public Transform[] stretchBones;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EAD78", Offset = "0x7EAD78")]
		public Vector3 chestDirection;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EADB0", Offset = "0x7EADB0")]
		public float chestDirectionWeight;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1C99CC0", Offset = "0x1C99CC0", VA = "0x1C99CC0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1C9A048", Offset = "0x1C9A048", VA = "0x1C9A048")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1C9A524", Offset = "0x1C9A524", VA = "0x1C9A524")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1C9A8F0", Offset = "0x1C9A8F0", VA = "0x1C9A8F0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1C9B07C", Offset = "0x1C9B07C", VA = "0x1C9B07C")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1C9B35C", Offset = "0x1C9B35C", VA = "0x1C9B35C")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1C9B660", Offset = "0x1C9B660", VA = "0x1C9B660")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1C9BE34", Offset = "0x1C9BE34", VA = "0x1C9BE34")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1C9AE60", Offset = "0x1C9AE60", VA = "0x1C9AE60")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1C9BFFC", Offset = "0x1C9BFFC", VA = "0x1C9BFFC")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1C9BD4C", Offset = "0x1C9BD4C", VA = "0x1C9BD4C")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1C9BC80", Offset = "0x1C9BC80", VA = "0x1C9BC80")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1C9C280", Offset = "0x1C9C280", VA = "0x1C9C280")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1C9C5B4", Offset = "0x1C9C5B4", VA = "0x1C9C5B4")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000095")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000096")]
		public class ChildConstraint
		{
			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EAEEC", Offset = "0x7EAEEC")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EAEFC", Offset = "0x7EAEFC")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x1700004C")]
			public float nominalDistance
			{
				[Token(Token = "0x60004F7")]
				[Address(RVA = "0x1BE40A8", Offset = "0x1BE40A8", VA = "0x1BE40A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F54E8", Offset = "0x7F54E8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004F8")]
				[Address(RVA = "0x1BE40B0", Offset = "0x1BE40B0", VA = "0x1BE40B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F54F8", Offset = "0x7F54F8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700004D")]
			public bool isRigid
			{
				[Token(Token = "0x60004F9")]
				[Address(RVA = "0x1BE40B8", Offset = "0x1BE40B8", VA = "0x1BE40B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5508", Offset = "0x7F5508")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60004FA")]
				[Address(RVA = "0x1BE40C0", Offset = "0x1BE40C0", VA = "0x1BE40C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5518", Offset = "0x7F5518")]
				private set
				{
				}
			}

			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x1BE40CC", Offset = "0x1BE40CC", VA = "0x1BE40CC")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x1BE4134", Offset = "0x1BE4134", VA = "0x1BE4134")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x1BE418C", Offset = "0x1BE418C", VA = "0x1BE418C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x1BE4330", Offset = "0x1BE4330", VA = "0x1BE4330")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000097")]
		public enum Smoothing
		{
			[Token(Token = "0x40003F5")]
			None,
			[Token(Token = "0x40003F6")]
			Exponential,
			[Token(Token = "0x40003F7")]
			Cubic
		}

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAE54", Offset = "0x7EAE54")]
		public float pin;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAE6C", Offset = "0x7EAE6C")]
		public float pull;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAE84", Offset = "0x7EAE84")]
		public float push;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAE9C", Offset = "0x7EAE9C")]
		public float pushParent;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAEB4", Offset = "0x7EAEB4")]
		public float reach;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40003E9")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1C9CD10", Offset = "0x1C9CD10", VA = "0x1C9CD10")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1C9CE2C", Offset = "0x1C9CE2C", VA = "0x1C9CE2C")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1C9CF9C", Offset = "0x1C9CF9C", VA = "0x1C9CF9C")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1C9D0D8", Offset = "0x1C9D0D8", VA = "0x1C9D0D8")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1C9D1B0", Offset = "0x1C9D1B0", VA = "0x1C9D1B0")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1C9D2D4", Offset = "0x1C9D2D4", VA = "0x1C9D2D4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1C9D9A4", Offset = "0x1C9D9A4", VA = "0x1C9D9A4")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1C9D470", Offset = "0x1C9D470", VA = "0x1C9D470")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1C9DD94", Offset = "0x1C9DD94", VA = "0x1C9DD94")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1C9DFF4", Offset = "0x1C9DFF4", VA = "0x1C9DFF4")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1C9E260", Offset = "0x1C9E260", VA = "0x1C9E260")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1C9E604", Offset = "0x1C9E604", VA = "0x1C9E604")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1C9EA98", Offset = "0x1C9EA98", VA = "0x1C9EA98")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1C9ECBC", Offset = "0x1C9ECBC", VA = "0x1C9ECBC")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1C9EA28", Offset = "0x1C9EA28", VA = "0x1C9EA28")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1C9E490", Offset = "0x1C9E490", VA = "0x1C9E490")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x1C9E9AC", Offset = "0x1C9E9AC", VA = "0x1C9E9AC")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1C9EDA4", Offset = "0x1C9EDA4", VA = "0x1C9EDA4")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1C9E8CC", Offset = "0x1C9E8CC", VA = "0x1C9E8CC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1C9EBA4", Offset = "0x1C9EBA4", VA = "0x1C9EBA4")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000098")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAF0C", Offset = "0x7EAF0C")]
		public float weight;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EAF24", Offset = "0x7EAF24")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x1700004E")]
		public bool initiated
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x19E1FE8", Offset = "0x19E1FE8", VA = "0x19E1FE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5528", Offset = "0x7F5528")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x19E1FF0", Offset = "0x19E1FF0", VA = "0x19E1FF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5538", Offset = "0x7F5538")]
			private set
			{
			}
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x19E1E00", Offset = "0x19E1E00", VA = "0x19E1E00")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x19E1FFC", Offset = "0x19E1FFC", VA = "0x19E1FFC")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x19E203C", Offset = "0x19E203C", VA = "0x19E203C")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x19E20A4", Offset = "0x19E20A4", VA = "0x19E20A4")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x19E20F4", Offset = "0x19E20F4", VA = "0x19E20F4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x19E2408", Offset = "0x19E2408", VA = "0x19E2408")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x19E25F8", Offset = "0x19E25F8", VA = "0x19E25F8")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x19E2944", Offset = "0x19E2944", VA = "0x19E2944")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x19E22B8", Offset = "0x19E22B8", VA = "0x19E22B8")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x19E2360", Offset = "0x19E2360", VA = "0x19E2360")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000099")]
	public class IKEffector
	{
		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAF34", Offset = "0x7EAF34")]
		public float positionWeight;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAF4C", Offset = "0x7EAF4C")]
		public float rotationWeight;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EAF64", Offset = "0x7EAF64")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAF74", Offset = "0x7EAF74")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x1700004F")]
		public bool isEndEffector
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x19E2DE0", Offset = "0x19E2DE0", VA = "0x19E2DE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5548", Offset = "0x7F5548")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x19E2DE8", Offset = "0x19E2DE8", VA = "0x19E2DE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5558", Offset = "0x7F5558")]
			private set
			{
			}
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x19E2D78", Offset = "0x19E2D78", VA = "0x19E2D78")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x19E2DF4", Offset = "0x19E2DF4", VA = "0x19E2DF4")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x19E2E84", Offset = "0x19E2E84", VA = "0x19E2E84")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x19E2FC8", Offset = "0x19E2FC8", VA = "0x19E2FC8")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x19E3148", Offset = "0x19E3148", VA = "0x19E3148")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x19E3470", Offset = "0x19E3470", VA = "0x19E3470")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x19E373C", Offset = "0x19E373C", VA = "0x19E373C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x19E3810", Offset = "0x19E3810", VA = "0x19E3810")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x19E38B8", Offset = "0x19E38B8", VA = "0x19E38B8")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x19E3DF4", Offset = "0x19E3DF4", VA = "0x19E3DF4")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x19E3E20", Offset = "0x19E3E20", VA = "0x19E3E20")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x19E3F80", Offset = "0x19E3F80", VA = "0x19E3F80")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x19E420C", Offset = "0x19E420C", VA = "0x19E420C")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200009A")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x200009B")]
		public class BoneMap
		{
			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000050")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x6000520")]
				[Address(RVA = "0x1BE88A4", Offset = "0x1BE88A4", VA = "0x1BE88A4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000051")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000523")]
				[Address(RVA = "0x1BE8980", Offset = "0x1BE8980", VA = "0x1BE8980")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000052")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000537")]
				[Address(RVA = "0x1BE8D50", Offset = "0x1BE8D50", VA = "0x1BE8D50")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600051F")]
			[Address(RVA = "0x1BE8854", Offset = "0x1BE8854", VA = "0x1BE8854")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000521")]
			[Address(RVA = "0x1BE88E0", Offset = "0x1BE88E0", VA = "0x1BE88E0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000522")]
			[Address(RVA = "0x1BE8930", Offset = "0x1BE8930", VA = "0x1BE8930")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0x1BE8990", Offset = "0x1BE8990", VA = "0x1BE8990")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000525")]
			[Address(RVA = "0x1BE8A18", Offset = "0x1BE8A18", VA = "0x1BE8A18")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0x1BE8A20", Offset = "0x1BE8A20", VA = "0x1BE8A20")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000527")]
			[Address(RVA = "0x1BE8AF8", Offset = "0x1BE8AF8", VA = "0x1BE8AF8")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000528")]
			[Address(RVA = "0x1BE8B70", Offset = "0x1BE8B70", VA = "0x1BE8B70")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000529")]
			[Address(RVA = "0x1BE8C34", Offset = "0x1BE8C34", VA = "0x1BE8C34")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x600052A")]
			[Address(RVA = "0x1BE8E90", Offset = "0x1BE8E90", VA = "0x1BE8E90")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x600052B")]
			[Address(RVA = "0x1BE8EC8", Offset = "0x1BE8EC8", VA = "0x1BE8EC8")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x600052C")]
			[Address(RVA = "0x1BE8F00", Offset = "0x1BE8F00", VA = "0x1BE8F00")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x600052D")]
			[Address(RVA = "0x1BE8F28", Offset = "0x1BE8F28", VA = "0x1BE8F28")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x600052E")]
			[Address(RVA = "0x1BE9014", Offset = "0x1BE9014", VA = "0x1BE9014")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600052F")]
			[Address(RVA = "0x1BE91A0", Offset = "0x1BE91A0", VA = "0x1BE91A0")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000530")]
			[Address(RVA = "0x1BE91D0", Offset = "0x1BE91D0", VA = "0x1BE91D0")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000531")]
			[Address(RVA = "0x1BE9298", Offset = "0x1BE9298", VA = "0x1BE9298")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000532")]
			[Address(RVA = "0x1BE9308", Offset = "0x1BE9308", VA = "0x1BE9308")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0x1BE9458", Offset = "0x1BE9458", VA = "0x1BE9458")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0x1BE95A8", Offset = "0x1BE95A8", VA = "0x1BE95A8")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0x1BE9628", Offset = "0x1BE9628", VA = "0x1BE9628")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x1BE9090", Offset = "0x1BE9090", VA = "0x1BE9090")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0x1BE9760", Offset = "0x1BE9760", VA = "0x1BE9760")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1E4653C", Offset = "0x1E4653C", VA = "0x1E4653C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1E46544", Offset = "0x1E46544", VA = "0x1E46544", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1E46548", Offset = "0x1E46548", VA = "0x1E46548")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1E46698", Offset = "0x1E46698", VA = "0x1E46698")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1E46708", Offset = "0x1E46708", VA = "0x1E46708")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009C")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAF8C", Offset = "0x7EAF8C")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1E46710", Offset = "0x1E46710", VA = "0x1E46710", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1E467C4", Offset = "0x1E467C4", VA = "0x1E467C4")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1E4683C", Offset = "0x1E4683C", VA = "0x1E4683C")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1E468D0", Offset = "0x1E468D0", VA = "0x1E468D0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1E468EC", Offset = "0x1E468EC", VA = "0x1E468EC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1E4690C", Offset = "0x1E4690C", VA = "0x1E4690C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1E469A4", Offset = "0x1E469A4", VA = "0x1E469A4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1E469C0", Offset = "0x1E469C0", VA = "0x1E469C0")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009D")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x200009E")]
		public enum BoneMapType
		{
			[Token(Token = "0x400044F")]
			Parent,
			[Token(Token = "0x4000450")]
			Bone1,
			[Token(Token = "0x4000451")]
			Bone2,
			[Token(Token = "0x4000452")]
			Bone3
		}

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAFA4", Offset = "0x7EAFA4")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAFBC", Offset = "0x7EAFBC")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1E469E8", Offset = "0x1E469E8", VA = "0x1E469E8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1E46A6C", Offset = "0x1E46A6C", VA = "0x1E46A6C")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1E46B48", Offset = "0x1E46B48", VA = "0x1E46B48")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1E46D6C", Offset = "0x1E46D6C", VA = "0x1E46D6C")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1E46E60", Offset = "0x1E46E60", VA = "0x1E46E60")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1E46F8C", Offset = "0x1E46F8C", VA = "0x1E46F8C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1E46FF0", Offset = "0x1E46FF0", VA = "0x1E46FF0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1E470A4", Offset = "0x1E470A4", VA = "0x1E470A4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1E47168", Offset = "0x1E47168", VA = "0x1E47168", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1E47400", Offset = "0x1E47400", VA = "0x1E47400")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1E47474", Offset = "0x1E47474", VA = "0x1E47474")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009F")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAFD4", Offset = "0x7EAFD4")]
		public int iterations;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EAFEC", Offset = "0x7EAFEC")]
		public float twistWeight;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1E4764C", Offset = "0x1E4764C", VA = "0x1E4764C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1E479B8", Offset = "0x1E479B8", VA = "0x1E479B8")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1E47AD8", Offset = "0x1E47AD8", VA = "0x1E47AD8")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1E47C38", Offset = "0x1E47C38", VA = "0x1E47C38")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1E47CB8", Offset = "0x1E47CB8", VA = "0x1E47CB8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1E47D24", Offset = "0x1E47D24", VA = "0x1E47D24")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1E47DA8", Offset = "0x1E47DA8", VA = "0x1E47DA8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1E483EC", Offset = "0x1E483EC", VA = "0x1E483EC")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1E48424", Offset = "0x1E48424", VA = "0x1E48424")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1E486A8", Offset = "0x1E486A8", VA = "0x1E486A8")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1E489A8", Offset = "0x1E489A8", VA = "0x1E489A8")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1E48A94", Offset = "0x1E48A94", VA = "0x1E48A94")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1E48B5C", Offset = "0x1E48B5C", VA = "0x1E48B5C")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A0")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000A1")]
		public class Point
		{
			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB0C0", Offset = "0x7EB0C0")]
			public float weight;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x600056F")]
			[Address(RVA = "0x1BEA2AC", Offset = "0x1BEA2AC", VA = "0x1BEA2AC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0x1BEA2FC", Offset = "0x1BEA2FC", VA = "0x1BEA2FC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000571")]
			[Address(RVA = "0x1BEA39C", Offset = "0x1BEA39C", VA = "0x1BEA39C")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000572")]
			[Address(RVA = "0x1BEA3D4", Offset = "0x1BEA3D4", VA = "0x1BEA3D4")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000573")]
			[Address(RVA = "0x1BEA40C", Offset = "0x1BEA40C", VA = "0x1BEA40C")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0x1BEA45C", Offset = "0x1BEA45C", VA = "0x1BEA45C")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000575")]
			[Address(RVA = "0x1BE9E60", Offset = "0x1BE9E60", VA = "0x1BE9E60")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A2")]
		public class Bone : Point
		{
			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000054")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000576")]
				[Address(RVA = "0x1BE977C", Offset = "0x1BE977C", VA = "0x1BE977C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000577")]
				[Address(RVA = "0x1BE9880", Offset = "0x1BE9880", VA = "0x1BE9880")]
				set
				{
				}
			}

			[Token(Token = "0x6000578")]
			[Address(RVA = "0x1BE9910", Offset = "0x1BE9910", VA = "0x1BE9910")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0x1BE9AC0", Offset = "0x1BE9AC0", VA = "0x1BE9AC0")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600057A")]
			[Address(RVA = "0x1BE9C94", Offset = "0x1BE9C94", VA = "0x1BE9C94")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600057B")]
			[Address(RVA = "0x1BE9DF4", Offset = "0x1BE9DF4", VA = "0x1BE9DF4")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600057C")]
			[Address(RVA = "0x1BE9E1C", Offset = "0x1BE9E1C", VA = "0x1BE9E1C")]
			public Bone()
			{
			}

			[Token(Token = "0x600057D")]
			[Address(RVA = "0x1BE9E9C", Offset = "0x1BE9E9C", VA = "0x1BE9E9C")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600057E")]
			[Address(RVA = "0x1BE9EF4", Offset = "0x1BE9EF4", VA = "0x1BE9EF4")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A3")]
		public class Node : Point
		{
			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x600057F")]
			[Address(RVA = "0x1BEA234", Offset = "0x1BEA234", VA = "0x1BEA234")]
			public Node()
			{
			}

			[Token(Token = "0x6000580")]
			[Address(RVA = "0x1BEA238", Offset = "0x1BEA238", VA = "0x1BEA238")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000581")]
			[Address(RVA = "0x1BEA268", Offset = "0x1BEA268", VA = "0x1BEA268")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000A4")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000A5")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public bool executedInEditor;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB024", Offset = "0x7EB024")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB024", Offset = "0x7EB024")]
		public float IKPositionWeight;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EB078", Offset = "0x7EB078")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000053")]
		public bool initiated
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x1E49014", Offset = "0x1E49014", VA = "0x1E49014")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5568", Offset = "0x7F5568")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x1E4901C", Offset = "0x1E4901C", VA = "0x1E4901C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5578", Offset = "0x7F5578")]
			private set
			{
			}
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1E48DBC", Offset = "0x1E48DBC", VA = "0x1E48DBC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600055A")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1E48E34", Offset = "0x1E48E34", VA = "0x1E48E34")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1E464C4", Offset = "0x1E464C4", VA = "0x1E464C4")]
		public void Update()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1E48FBC", Offset = "0x1E48FBC", VA = "0x1E48FBC", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1E48FC8", Offset = "0x1E48FC8", VA = "0x1E48FC8")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1E48FD4", Offset = "0x1E48FD4", VA = "0x1E48FD4")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1E48FDC", Offset = "0x1E48FDC", VA = "0x1E48FDC")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1E4900C", Offset = "0x1E4900C", VA = "0x1E4900C")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000564")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000565")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000566")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000567")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000568")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000569")]
		protected abstract void OnUpdate();

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1E49028", Offset = "0x1E49028", VA = "0x1E49028")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1E49040", Offset = "0x1E49040", VA = "0x1E49040")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1E49178", Offset = "0x1E49178", VA = "0x1E49178")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1E49224", Offset = "0x1E49224", VA = "0x1E49224")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1E494AC", Offset = "0x1E494AC", VA = "0x1E494AC")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A6")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB0D8", Offset = "0x7EB0D8")]
		public float poleWeight;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB0F0", Offset = "0x7EB0F0")]
		public float clampWeight;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB108", Offset = "0x7EB108")]
		public int clampSmoothing;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000055")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x1E49540", Offset = "0x1E49540", VA = "0x1E49540")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000056")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x1E4957C", Offset = "0x1E4957C", VA = "0x1E4957C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000057")]
		protected override int minBones
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x1E4A02C", Offset = "0x1E4A02C", VA = "0x1E4A02C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000058")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x1E4A410", Offset = "0x1E4A410", VA = "0x1E4A410", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1E494C4", Offset = "0x1E494C4", VA = "0x1E494C4")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1E495B8", Offset = "0x1E495B8", VA = "0x1E495B8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1E497D8", Offset = "0x1E497D8", VA = "0x1E497D8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x1E49F78", Offset = "0x1E49F78", VA = "0x1E49F78")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1E49D08", Offset = "0x1E49D08", VA = "0x1E49D08")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1E4A034", Offset = "0x1E4A034", VA = "0x1E4A034")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1E4A484", Offset = "0x1E4A484", VA = "0x1E4A484")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A7")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB120", Offset = "0x7EB120")]
		public float IKRotationWeight;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1E4A558", Offset = "0x1E4A558", VA = "0x1E4A558", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1E4A940", Offset = "0x1E4A940", VA = "0x1E4A940")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1E4A9F4", Offset = "0x1E4A9F4", VA = "0x1E4A9F4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1E4AB88", Offset = "0x1E4AB88", VA = "0x1E4AB88", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1E4AD1C", Offset = "0x1E4AD1C", VA = "0x1E4AD1C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1E4AD78", Offset = "0x1E4AD78", VA = "0x1E4AD78", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1E4ADE8", Offset = "0x1E4ADE8", VA = "0x1E4ADE8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1E4B158", Offset = "0x1E4B158", VA = "0x1E4B158", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1E4B184", Offset = "0x1E4B184", VA = "0x1E4B184")]
		private void Solve()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1E4AE4C", Offset = "0x1E4AE4C", VA = "0x1E4AE4C")]
		private void Read()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1E4B1F8", Offset = "0x1E4B1F8", VA = "0x1E4B1F8")]
		private void Write()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1E4B384", Offset = "0x1E4B384", VA = "0x1E4B384")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A8")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1E4B548", Offset = "0x1E4B548", VA = "0x1E4B548")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1E4B5F8", Offset = "0x1E4B5F8", VA = "0x1E4B5F8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1E4BAF0", Offset = "0x1E4BAF0", VA = "0x1E4BAF0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1E4C0E8", Offset = "0x1E4C0E8", VA = "0x1E4C0E8")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1E4C6C4", Offset = "0x1E4C6C4", VA = "0x1E4C6C4")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A9")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000059")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x1E4D614", Offset = "0x1E4D614", VA = "0x1E4D614", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1E4C6C8", Offset = "0x1E4C6C8", VA = "0x1E4C6C8")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1E4CC8C", Offset = "0x1E4CC8C", VA = "0x1E4CC8C")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1E4CDCC", Offset = "0x1E4CDCC", VA = "0x1E4CDCC", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1E4CE60", Offset = "0x1E4CE60", VA = "0x1E4CE60", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1E4D354", Offset = "0x1E4D354", VA = "0x1E4D354", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1E4D61C", Offset = "0x1E4D61C", VA = "0x1E4D61C")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1E4C7A4", Offset = "0x1E4C7A4", VA = "0x1E4C7A4")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1E4CD78", Offset = "0x1E4CD78", VA = "0x1E4CD78")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1E4D5B8", Offset = "0x1E4D5B8", VA = "0x1E4D5B8")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1E4CB00", Offset = "0x1E4CB00", VA = "0x1E4CB00")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1E4DC6C", Offset = "0x1E4DC6C", VA = "0x1E4DC6C")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1E4DCE0", Offset = "0x1E4DCE0", VA = "0x1E4DCE0")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1E4DDA8", Offset = "0x1E4DDA8", VA = "0x1E4DDA8")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1E4DE58", Offset = "0x1E4DE58", VA = "0x1E4DE58")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1E4D104", Offset = "0x1E4D104", VA = "0x1E4D104")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1E4D22C", Offset = "0x1E4D22C", VA = "0x1E4D22C")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1E4DF5C", Offset = "0x1E4DF5C", VA = "0x1E4DF5C")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1E4D83C", Offset = "0x1E4D83C", VA = "0x1E4D83C")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1E4CD68", Offset = "0x1E4CD68", VA = "0x1E4CD68")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1E4E4EC", Offset = "0x1E4E4EC", VA = "0x1E4E4EC")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1E4E0A0", Offset = "0x1E4E0A0", VA = "0x1E4E0A0")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1E4D698", Offset = "0x1E4D698", VA = "0x1E4D698")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1E4D778", Offset = "0x1E4D778", VA = "0x1E4D778")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1E4E5B8", Offset = "0x1E4E5B8", VA = "0x1E4E5B8")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AA")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB138", Offset = "0x7EB138")]
		public float rootPin;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1E4E64C", Offset = "0x1E4E64C", VA = "0x1E4E64C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1E4ECD8", Offset = "0x1E4ECD8", VA = "0x1E4ECD8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1E4ED70", Offset = "0x1E4ED70", VA = "0x1E4ED70", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1E4EE10", Offset = "0x1E4EE10", VA = "0x1E4EE10", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1E4EF1C", Offset = "0x1E4EF1C", VA = "0x1E4EF1C")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1E4EFB8", Offset = "0x1E4EFB8", VA = "0x1E4EFB8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1E4F3E8", Offset = "0x1E4F3E8", VA = "0x1E4F3E8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1E4F5F8", Offset = "0x1E4F5F8", VA = "0x1E4F5F8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1E4F494", Offset = "0x1E4F494", VA = "0x1E4F494")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1E4F1A4", Offset = "0x1E4F1A4", VA = "0x1E4F1A4")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1E4F690", Offset = "0x1E4F690", VA = "0x1E4F690")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB150", Offset = "0x7EB150")]
		public int iterations;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1E4F710", Offset = "0x1E4F710", VA = "0x1E4F710")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1E4F800", Offset = "0x1E4F800", VA = "0x1E4F800")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x1E4F85C", Offset = "0x1E4F85C", VA = "0x1E4F85C")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1E475F0", Offset = "0x1E475F0", VA = "0x1E475F0")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1E4F98C", Offset = "0x1E4F98C", VA = "0x1E4F98C")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1E4FA0C", Offset = "0x1E4FA0C", VA = "0x1E4FA0C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x1E4FBB8", Offset = "0x1E4FBB8", VA = "0x1E4FBB8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1E4FD28", Offset = "0x1E4FD28", VA = "0x1E4FD28", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x1E4FF38", Offset = "0x1E4FF38", VA = "0x1E4FF38", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x1E50010", Offset = "0x1E50010", VA = "0x1E50010", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1E500F0", Offset = "0x1E500F0", VA = "0x1E500F0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x1E50264", Offset = "0x1E50264", VA = "0x1E50264", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x1E503BC", Offset = "0x1E503BC", VA = "0x1E503BC", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x1E50608", Offset = "0x1E50608", VA = "0x1E50608", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1E508E4", Offset = "0x1E508E4", VA = "0x1E508E4", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1E50928", Offset = "0x1E50928", VA = "0x1E50928", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x1E50A0C", Offset = "0x1E50A0C", VA = "0x1E50A0C")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AC")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40004AC")]
		Body,
		[Token(Token = "0x40004AD")]
		LeftShoulder,
		[Token(Token = "0x40004AE")]
		RightShoulder,
		[Token(Token = "0x40004AF")]
		LeftThigh,
		[Token(Token = "0x40004B0")]
		RightThigh,
		[Token(Token = "0x40004B1")]
		LeftHand,
		[Token(Token = "0x40004B2")]
		RightHand,
		[Token(Token = "0x40004B3")]
		LeftFoot,
		[Token(Token = "0x40004B4")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x20000AD")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40004B6")]
		LeftArm,
		[Token(Token = "0x40004B7")]
		RightArm,
		[Token(Token = "0x40004B8")]
		LeftLeg,
		[Token(Token = "0x40004B9")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB168", Offset = "0x7EB168")]
		public float spineStiffness;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB180", Offset = "0x7EB180")]
		public float pullBodyVertical;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB198", Offset = "0x7EB198")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EB1B0", Offset = "0x7EB1B0")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700005A")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x1E50B54", Offset = "0x1E50B54", VA = "0x1E50B54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x1E50C9C", Offset = "0x1E50C9C", VA = "0x1E50C9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x1E50CA4", Offset = "0x1E50CA4", VA = "0x1E50CA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x1E50CAC", Offset = "0x1E50CAC", VA = "0x1E50CAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x1E50CB4", Offset = "0x1E50CB4", VA = "0x1E50CB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x1E50CBC", Offset = "0x1E50CBC", VA = "0x1E50CBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x1E50CC4", Offset = "0x1E50CC4", VA = "0x1E50CC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x1E50CCC", Offset = "0x1E50CCC", VA = "0x1E50CCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x1E50CD4", Offset = "0x1E50CD4", VA = "0x1E50CD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x1E50CDC", Offset = "0x1E50CDC", VA = "0x1E50CDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x1E50D14", Offset = "0x1E50D14", VA = "0x1E50D14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x1E50D4C", Offset = "0x1E50D4C", VA = "0x1E50D4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x1E50D84", Offset = "0x1E50D84", VA = "0x1E50D84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x1E50DBC", Offset = "0x1E50DBC", VA = "0x1E50DBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x1E50DF0", Offset = "0x1E50DF0", VA = "0x1E50DF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x1E50E28", Offset = "0x1E50E28", VA = "0x1E50E28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x1E50E60", Offset = "0x1E50E60", VA = "0x1E50E60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x1E50E98", Offset = "0x1E50E98", VA = "0x1E50E98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x1E52FF4", Offset = "0x1E52FF4", VA = "0x1E52FF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5588", Offset = "0x7F5588")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x1E53000", Offset = "0x1E53000", VA = "0x1E53000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5598", Offset = "0x7F5598")]
			private set
			{
			}
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1E50ECC", Offset = "0x1E50ECC", VA = "0x1E50ECC")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1E50FD8", Offset = "0x1E50FD8", VA = "0x1E50FD8")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x1E50F20", Offset = "0x1E50F20", VA = "0x1E50F20")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1E51064", Offset = "0x1E51064", VA = "0x1E51064")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1E50B5C", Offset = "0x1E50B5C", VA = "0x1E50B5C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1E51134", Offset = "0x1E51134", VA = "0x1E51134")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1E511EC", Offset = "0x1E511EC", VA = "0x1E511EC")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1E512A0", Offset = "0x1E512A0", VA = "0x1E512A0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1E51354", Offset = "0x1E51354", VA = "0x1E51354")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x1E5135C", Offset = "0x1E5135C", VA = "0x1E5135C")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1E51390", Offset = "0x1E51390", VA = "0x1E51390")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1E51458", Offset = "0x1E51458", VA = "0x1E51458", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1E51600", Offset = "0x1E51600", VA = "0x1E51600")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1E52A74", Offset = "0x1E52A74", VA = "0x1E52A74")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1E52E88", Offset = "0x1E52E88", VA = "0x1E52E88")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x1E52EE8", Offset = "0x1E52EE8", VA = "0x1E52EE8")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1E52D10", Offset = "0x1E52D10", VA = "0x1E52D10")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1E52DCC", Offset = "0x1E52DCC", VA = "0x1E52DCC")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1E5300C", Offset = "0x1E5300C", VA = "0x1E5300C")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1E530E4", Offset = "0x1E530E4", VA = "0x1E530E4", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1E531E0", Offset = "0x1E531E0", VA = "0x1E531E0")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x1E53308", Offset = "0x1E53308", VA = "0x1E53308")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1E5344C", Offset = "0x1E5344C", VA = "0x1E5344C")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1E5357C", Offset = "0x1E5357C", VA = "0x1E5357C", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1E537BC", Offset = "0x1E537BC", VA = "0x1E537BC", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1E53840", Offset = "0x1E53840", VA = "0x1E53840")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AF")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x1700006D")]
		protected virtual int minBones
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x1E540F4", Offset = "0x1E540F4", VA = "0x1E540F4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006E")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x1E540FC", Offset = "0x1E540FC", VA = "0x1E540FC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x1E54104", Offset = "0x1E54104", VA = "0x1E54104", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x1E54114", Offset = "0x1E54114", VA = "0x1E54114", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000071")]
		protected float positionOffset
		{
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x1E4C094", Offset = "0x1E4C094", VA = "0x1E4C094")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x1E5384C", Offset = "0x1E5384C", VA = "0x1E5384C")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1E53A04", Offset = "0x1E53A04", VA = "0x1E53A04")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1E53B64", Offset = "0x1E53B64", VA = "0x1E53B64", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1E53BD0", Offset = "0x1E53BD0", VA = "0x1E53BD0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x1E53C50", Offset = "0x1E53C50", VA = "0x1E53C50", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x1E53FFC", Offset = "0x1E53FFC", VA = "0x1E53FFC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x1E54004", Offset = "0x1E54004", VA = "0x1E54004", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x1E5410C", Offset = "0x1E5410C", VA = "0x1E5410C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x1E54110", Offset = "0x1E54110", VA = "0x1E54110", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x1E4B678", Offset = "0x1E4B678", VA = "0x1E4B678")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1E4BD7C", Offset = "0x1E4BD7C", VA = "0x1E4BD7C")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1E541DC", Offset = "0x1E541DC", VA = "0x1E541DC")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1E4A4D4", Offset = "0x1E4A4D4", VA = "0x1E4A4D4")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB1C0", Offset = "0x7EB1C0")]
		public float IKRotationWeight;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1E543D0", Offset = "0x1E543D0", VA = "0x1E543D0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x1E547B8", Offset = "0x1E547B8", VA = "0x1E547B8")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1E5486C", Offset = "0x1E5486C", VA = "0x1E5486C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x1E54A00", Offset = "0x1E54A00", VA = "0x1E54A00", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x1E54B94", Offset = "0x1E54B94", VA = "0x1E54B94", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x1E54BF0", Offset = "0x1E54BF0", VA = "0x1E54BF0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x1E54C60", Offset = "0x1E54C60", VA = "0x1E54C60", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x1E54FD0", Offset = "0x1E54FD0", VA = "0x1E54FD0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x1E54FFC", Offset = "0x1E54FFC", VA = "0x1E54FFC")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x1E54CC4", Offset = "0x1E54CC4", VA = "0x1E54CC4")]
		private void Read()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x1E55098", Offset = "0x1E55098", VA = "0x1E55098")]
		private void Write()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1E55224", Offset = "0x1E55224", VA = "0x1E55224")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000B2")]
		public enum BendModifier
		{
			[Token(Token = "0x40004E4")]
			Animation,
			[Token(Token = "0x40004E5")]
			Target,
			[Token(Token = "0x40004E6")]
			Parent,
			[Token(Token = "0x40004E7")]
			Arm,
			[Token(Token = "0x40004E8")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000B3")]
		public struct AxisDirection
		{
			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x1BEA704", Offset = "0x1BEA704", VA = "0x1BEA704")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB1D8", Offset = "0x7EB1D8")]
		public float maintainRotationWeight;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB1F0", Offset = "0x7EB1F0")]
		public float bendModifierWeight;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000072")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x1E5647C", Offset = "0x1E5647C", VA = "0x1E5647C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x1E553E8", Offset = "0x1E553E8", VA = "0x1E553E8")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x1E55438", Offset = "0x1E55438", VA = "0x1E55438")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x1E55484", Offset = "0x1E55484", VA = "0x1E55484", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x1E55958", Offset = "0x1E55958", VA = "0x1E55958", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x1E562A4", Offset = "0x1E562A4", VA = "0x1E562A4", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1E56350", Offset = "0x1E56350", VA = "0x1E56350")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x1E563DC", Offset = "0x1E563DC", VA = "0x1E563DC")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1E55780", Offset = "0x1E55780", VA = "0x1E55780")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x1E55A3C", Offset = "0x1E55A3C", VA = "0x1E55A3C")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000B4")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x17000079")]
			public Vector3 forward
			{
				[Token(Token = "0x6000651")]
				[Address(RVA = "0x1BEA998", Offset = "0x1BEA998", VA = "0x1BEA998")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x1BEA764", Offset = "0x1BEA764", VA = "0x1BEA764")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x1BEA768", Offset = "0x1BEA768", VA = "0x1BEA768")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x1BEA798", Offset = "0x1BEA798", VA = "0x1BEA798")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x1BEA890", Offset = "0x1BEA890", VA = "0x1BEA890")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB208", Offset = "0x7EB208")]
		public float bodyWeight;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB220", Offset = "0x7EB220")]
		public float headWeight;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB238", Offset = "0x7EB238")]
		public float eyesWeight;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB250", Offset = "0x7EB250")]
		public float clampWeight;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB268", Offset = "0x7EB268")]
		public float clampWeightHead;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB280", Offset = "0x7EB280")]
		public float clampWeightEyes;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB298", Offset = "0x7EB298")]
		public int clampSmoothing;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool isDirty;

		[Token(Token = "0x17000073")]
		protected bool spineIsValid
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x1E56C30", Offset = "0x1E56C30", VA = "0x1E56C30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000074")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x1E56E00", Offset = "0x1E56E00", VA = "0x1E56E00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000075")]
		protected bool headIsValid
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x1E56D10", Offset = "0x1E56D10", VA = "0x1E56D10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000076")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x1E56E24", Offset = "0x1E56E24", VA = "0x1E56E24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x1E56D20", Offset = "0x1E56D20", VA = "0x1E56D20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000078")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x1E56E9C", Offset = "0x1E56E9C", VA = "0x1E56E9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x1E56498", Offset = "0x1E56498", VA = "0x1E56498")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x1E564C8", Offset = "0x1E564C8", VA = "0x1E564C8")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x1E56520", Offset = "0x1E56520", VA = "0x1E56520")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1E5659C", Offset = "0x1E5659C", VA = "0x1E5659C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1E56634", Offset = "0x1E56634", VA = "0x1E56634")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1E566F4", Offset = "0x1E566F4", VA = "0x1E566F4")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1E567F0", Offset = "0x1E567F0", VA = "0x1E567F0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x1E5691C", Offset = "0x1E5691C", VA = "0x1E5691C")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1E56928", Offset = "0x1E56928", VA = "0x1E56928", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x1E56A6C", Offset = "0x1E56A6C", VA = "0x1E56A6C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1E56EC0", Offset = "0x1E56EC0", VA = "0x1E56EC0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1E57130", Offset = "0x1E57130", VA = "0x1E57130", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1E572CC", Offset = "0x1E572CC", VA = "0x1E572CC")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1E5752C", Offset = "0x1E5752C", VA = "0x1E5752C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1E57840", Offset = "0x1E57840", VA = "0x1E57840", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1E57910", Offset = "0x1E57910", VA = "0x1E57910")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1E57AB0", Offset = "0x1E57AB0", VA = "0x1E57AB0")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1E57CD4", Offset = "0x1E57CD4", VA = "0x1E57CD4")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1E58088", Offset = "0x1E58088", VA = "0x1E58088")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1E57380", Offset = "0x1E57380", VA = "0x1E57380")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1E582F8", Offset = "0x1E582F8", VA = "0x1E582F8")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000B7")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x1BEA9D4", Offset = "0x1BEA9D4", VA = "0x1BEA9D4")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x1BEAAD0", Offset = "0x1BEAAD0", VA = "0x1BEAAD0")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x1BEAB00", Offset = "0x1BEAB00", VA = "0x1BEAB00")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x1BEAB3C", Offset = "0x1BEAB3C", VA = "0x1BEAB3C")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB2B0", Offset = "0x7EB2B0")]
		public float IKRotationWeight;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x1BA9BE4", Offset = "0x1BA9BE4", VA = "0x1BA9BE4")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x1BA9D40", Offset = "0x1BA9D40", VA = "0x1BA9D40")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x1BA9E84", Offset = "0x1BA9E84", VA = "0x1BA9E84")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1BA9E90", Offset = "0x1BA9E90", VA = "0x1BA9E90")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1BA9EC0", Offset = "0x1BA9EC0", VA = "0x1BA9EC0")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x1BA9ECC", Offset = "0x1BA9ECC", VA = "0x1BA9ECC")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1BA9ED4", Offset = "0x1BA9ED4", VA = "0x1BA9ED4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1BA9FF8", Offset = "0x1BA9FF8", VA = "0x1BA9FF8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1BAA114", Offset = "0x1BAA114", VA = "0x1BAA114", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1BAA160", Offset = "0x1BAA160", VA = "0x1BAA160", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1BAA1C0", Offset = "0x1BAA1C0", VA = "0x1BAA1C0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1BAA5B8", Offset = "0x1BAA5B8", VA = "0x1BAA5B8")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1BAA638", Offset = "0x1BAA638", VA = "0x1BAA638")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1BAA9F4", Offset = "0x1BAA9F4", VA = "0x1BAA9F4")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1BAAB5C", Offset = "0x1BAAB5C", VA = "0x1BAAB5C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1BAACC4", Offset = "0x1BAACC4", VA = "0x1BAACC4")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1BAAC38", Offset = "0x1BAAC38", VA = "0x1BAAC38")]
		public void InitiateBones()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1BAADC8", Offset = "0x1BAADC8", VA = "0x1BAADC8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1BAB59C", Offset = "0x1BAB59C", VA = "0x1BAB59C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1BAB5A0", Offset = "0x1BAB5A0", VA = "0x1BAB5A0", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1BAB5A4", Offset = "0x1BAB5A4", VA = "0x1BAB5A4", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x1BAB3B4", Offset = "0x1BAB3B4", VA = "0x1BAB3B4")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1BAB5A8", Offset = "0x1BAB5A8", VA = "0x1BAB5A8")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B8")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000B9")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20000BA")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x400054F")]
				YawPitch,
				[Token(Token = "0x4000550")]
				FromTo
			}

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EB4FC", Offset = "0x7EB4FC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB4FC", Offset = "0x7EB4FC")]
			public Transform target;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB55C", Offset = "0x7EB55C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB55C", Offset = "0x7EB55C")]
			public float positionWeight;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB5B0", Offset = "0x7EB5B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB5B0", Offset = "0x7EB5B0")]
			public float rotationWeight;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB604", Offset = "0x7EB604")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EB604", Offset = "0x7EB604")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB604", Offset = "0x7EB604")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7EB67C", Offset = "0x7EB67C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB67C", Offset = "0x7EB67C")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB758", Offset = "0x7EB758")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x7EB758", Offset = "0x7EB758")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB834", Offset = "0x7EB834")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7EB834", Offset = "0x7EB834")]
			public float shoulderYawOffset;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB908", Offset = "0x7EB908")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7EB908", Offset = "0x7EB908")]
			public float shoulderPitchOffset;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB9DC", Offset = "0x7EB9DC")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EB9DC", Offset = "0x7EB9DC")]
			public Transform bendGoal;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EBA3C", Offset = "0x7EBA3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBA3C", Offset = "0x7EBA3C")]
			public float bendGoalWeight;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EBA90", Offset = "0x7EBA90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBA90", Offset = "0x7EBA90")]
			public float swivelOffset;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBAEC", Offset = "0x7EBAEC")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBB24", Offset = "0x7EBB24")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EBB5C", Offset = "0x7EBB5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBB5C", Offset = "0x7EBB5C")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EBB5C", Offset = "0x7EBB5C")]
			public float armLengthMlp;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBBD8", Offset = "0x7EBBD8")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EBC50", Offset = "0x7EBC50")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EBC60", Offset = "0x7EBC60")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool hasShoulder;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Quaternion chestRotation;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Vector3 chestForward;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private Vector3 chestUp;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x1700007C")]
			public Vector3 position
			{
				[Token(Token = "0x600068B")]
				[Address(RVA = "0x1BEAB40", Offset = "0x1BEAB40", VA = "0x1BEAB40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F55E8", Offset = "0x7F55E8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600068C")]
				[Address(RVA = "0x1BEAB4C", Offset = "0x1BEAB4C", VA = "0x1BEAB4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F55F8", Offset = "0x7F55F8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007D")]
			public Quaternion rotation
			{
				[Token(Token = "0x600068D")]
				[Address(RVA = "0x1BEAB58", Offset = "0x1BEAB58", VA = "0x1BEAB58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5608", Offset = "0x7F5608")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600068E")]
				[Address(RVA = "0x1BEAB64", Offset = "0x1BEAB64", VA = "0x1BEAB64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5618", Offset = "0x7F5618")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007E")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600068F")]
				[Address(RVA = "0x1BEAB70", Offset = "0x1BEAB70", VA = "0x1BEAB70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000690")]
				[Address(RVA = "0x1BEABA4", Offset = "0x1BEABA4", VA = "0x1BEABA4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000080")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000691")]
				[Address(RVA = "0x1BEABE4", Offset = "0x1BEABE4", VA = "0x1BEABE4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000081")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000692")]
				[Address(RVA = "0x1BEAC30", Offset = "0x1BEAC30", VA = "0x1BEAC30")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x1BEAC7C", Offset = "0x1BEAC7C", VA = "0x1BEAC7C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x1BEB590", Offset = "0x1BEB590", VA = "0x1BEB590", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x1BEB74C", Offset = "0x1BEB74C", VA = "0x1BEB74C", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x1BEB770", Offset = "0x1BEB770", VA = "0x1BEB770")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x1BEBA10", Offset = "0x1BEBA10", VA = "0x1BEBA10")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x1BECF90", Offset = "0x1BECF90", VA = "0x1BECF90", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x1BECFBC", Offset = "0x1BECFBC", VA = "0x1BECFBC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x1BEC9CC", Offset = "0x1BEC9CC", VA = "0x1BEC9CC")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x1BECA48", Offset = "0x1BECA48", VA = "0x1BECA48")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x1BED1DC", Offset = "0x1BED1DC", VA = "0x1BED1DC")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x1BED300", Offset = "0x1BED300", VA = "0x1BED300")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BB")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EBC70", Offset = "0x7EBC70")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EBC80", Offset = "0x7EBC80")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000082")]
			public float sqrMag
			{
				[Token(Token = "0x60006A3")]
				[Address(RVA = "0x1BED484", Offset = "0x1BED484", VA = "0x1BED484")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5628", Offset = "0x7F5628")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006A4")]
				[Address(RVA = "0x1BED48C", Offset = "0x1BED48C", VA = "0x1BED48C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5638", Offset = "0x7F5638")]
				private set
				{
				}
			}

			[Token(Token = "0x17000083")]
			public float mag
			{
				[Token(Token = "0x60006A5")]
				[Address(RVA = "0x1BED494", Offset = "0x1BED494", VA = "0x1BED494")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5648", Offset = "0x7F5648")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006A6")]
				[Address(RVA = "0x1BED49C", Offset = "0x1BED49C", VA = "0x1BED49C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5658", Offset = "0x7F5658")]
				private set
				{
				}
			}

			[Token(Token = "0x600069E")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x600069F")]
			public abstract void PreSolve(float scale);

			[Token(Token = "0x60006A0")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x60006A1")]
			public abstract void ApplyOffsets(float scale);

			[Token(Token = "0x60006A2")]
			public abstract void ResetOffsets();

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x1BED4A4", Offset = "0x1BED4A4", VA = "0x1BED4A4")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x1BED4AC", Offset = "0x1BED4AC", VA = "0x1BED4AC")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x1BED580", Offset = "0x1BED580", VA = "0x1BED580")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x1BED614", Offset = "0x1BED614", VA = "0x1BED614")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x1BED6C0", Offset = "0x1BED6C0", VA = "0x1BED6C0")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x1BED714", Offset = "0x1BED714", VA = "0x1BED714")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x1BECE4C", Offset = "0x1BECE4C", VA = "0x1BECE4C")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x1BED850", Offset = "0x1BED850", VA = "0x1BED850")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x1BED990", Offset = "0x1BED990", VA = "0x1BED990")]
			public void Visualize()
			{
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x1BED404", Offset = "0x1BED404", VA = "0x1BED404")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BC")]
		public class Footstep
		{
			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool relaxFlag;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EBCA0", Offset = "0x7EBCA0")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x17000084")]
			public bool isStepping
			{
				[Token(Token = "0x60006B1")]
				[Address(RVA = "0x1BED9B8", Offset = "0x1BED9B8", VA = "0x1BED9B8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000085")]
			public float stepProgress
			{
				[Token(Token = "0x60006B2")]
				[Address(RVA = "0x1BED9CC", Offset = "0x1BED9CC", VA = "0x1BED9CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5668", Offset = "0x7F5668")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006B3")]
				[Address(RVA = "0x1BED9D4", Offset = "0x1BED9D4", VA = "0x1BED9D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5678", Offset = "0x7F5678")]
				private set
				{
				}
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x1BED9DC", Offset = "0x1BED9DC", VA = "0x1BED9DC")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x1BEDB14", Offset = "0x1BEDB14", VA = "0x1BEDB14")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x1BEDB5C", Offset = "0x1BEDB5C", VA = "0x1BEDB5C")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x1BEDD28", Offset = "0x1BEDD28", VA = "0x1BEDD28")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x1BEDE70", Offset = "0x1BEDE70", VA = "0x1BEDE70")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x1BEDFC4", Offset = "0x1BEDFC4", VA = "0x1BEDFC4")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep, float deltaTime)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BD")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBCB0", Offset = "0x7EBCB0")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EBCB0", Offset = "0x7EBCB0")]
			public Transform target;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EBD10", Offset = "0x7EBD10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBD10", Offset = "0x7EBD10")]
			public float positionWeight;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBD64", Offset = "0x7EBD64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EBD64", Offset = "0x7EBD64")]
			public float rotationWeight;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBDB8", Offset = "0x7EBDB8")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EBDB8", Offset = "0x7EBDB8")]
			public Transform bendGoal;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EBE18", Offset = "0x7EBE18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBE18", Offset = "0x7EBE18")]
			public float bendGoalWeight;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBE6C", Offset = "0x7EBE6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EBE6C", Offset = "0x7EBE6C")]
			public float swivelOffset;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBEC8", Offset = "0x7EBEC8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EBEC8", Offset = "0x7EBEC8")]
			public float bendToTargetWeight;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBF1C", Offset = "0x7EBF1C")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EBF1C", Offset = "0x7EBF1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EBF1C", Offset = "0x7EBF1C")]
			public float legLengthMlp;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EBF98", Offset = "0x7EBF98")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EC040", Offset = "0x7EC040")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EC050", Offset = "0x7EC050")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EC060", Offset = "0x7EC060")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EC070", Offset = "0x7EC070")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EC080", Offset = "0x7EC080")]
			private Vector3 <bendNormalRelToPelvis>k__BackingField;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EC090", Offset = "0x7EC090")]
			private Vector3 <bendNormalRelToTarget>k__BackingField;

			[Token(Token = "0x17000086")]
			public Vector3 position
			{
				[Token(Token = "0x60006BA")]
				[Address(RVA = "0x1BEE0FC", Offset = "0x1BEE0FC", VA = "0x1BEE0FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5688", Offset = "0x7F5688")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006BB")]
				[Address(RVA = "0x1BEE108", Offset = "0x1BEE108", VA = "0x1BEE108")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5698", Offset = "0x7F5698")]
				private set
				{
				}
			}

			[Token(Token = "0x17000087")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006BC")]
				[Address(RVA = "0x1BEE114", Offset = "0x1BEE114", VA = "0x1BEE114")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F56A8", Offset = "0x7F56A8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006BD")]
				[Address(RVA = "0x1BEE120", Offset = "0x1BEE120", VA = "0x1BEE120")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F56B8", Offset = "0x7F56B8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000088")]
			public bool hasToes
			{
				[Token(Token = "0x60006BE")]
				[Address(RVA = "0x1BEE12C", Offset = "0x1BEE12C", VA = "0x1BEE12C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F56C8", Offset = "0x7F56C8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006BF")]
				[Address(RVA = "0x1BEE134", Offset = "0x1BEE134", VA = "0x1BEE134")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F56D8", Offset = "0x7F56D8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000089")]
			public VirtualBone thigh
			{
				[Token(Token = "0x60006C0")]
				[Address(RVA = "0x1BEE140", Offset = "0x1BEE140", VA = "0x1BEE140")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private VirtualBone calf
			{
				[Token(Token = "0x60006C1")]
				[Address(RVA = "0x1BEE174", Offset = "0x1BEE174", VA = "0x1BEE174")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			private VirtualBone foot
			{
				[Token(Token = "0x60006C2")]
				[Address(RVA = "0x1BEE1AC", Offset = "0x1BEE1AC", VA = "0x1BEE1AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private VirtualBone toes
			{
				[Token(Token = "0x60006C3")]
				[Address(RVA = "0x1BEE1E4", Offset = "0x1BEE1E4", VA = "0x1BEE1E4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008D")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x60006C4")]
				[Address(RVA = "0x1BEE21C", Offset = "0x1BEE21C", VA = "0x1BEE21C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60006C5")]
				[Address(RVA = "0x1BEE25C", Offset = "0x1BEE25C", VA = "0x1BEE25C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F56E8", Offset = "0x7F56E8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006C6")]
				[Address(RVA = "0x1BEE268", Offset = "0x1BEE268", VA = "0x1BEE268")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F56F8", Offset = "0x7F56F8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008F")]
			public Vector3 bendNormalRelToPelvis
			{
				[Token(Token = "0x60006C7")]
				[Address(RVA = "0x1BEE274", Offset = "0x1BEE274", VA = "0x1BEE274")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5708", Offset = "0x7F5708")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006C8")]
				[Address(RVA = "0x1BEE284", Offset = "0x1BEE284", VA = "0x1BEE284")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5718", Offset = "0x7F5718")]
				set
				{
				}
			}

			[Token(Token = "0x17000090")]
			public Vector3 bendNormalRelToTarget
			{
				[Token(Token = "0x60006C9")]
				[Address(RVA = "0x1BEE294", Offset = "0x1BEE294", VA = "0x1BEE294")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5728", Offset = "0x7F5728")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006CA")]
				[Address(RVA = "0x1BEE2A4", Offset = "0x1BEE2A4", VA = "0x1BEE2A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5738", Offset = "0x7F5738")]
				set
				{
				}
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x1BEE2B4", Offset = "0x1BEE2B4", VA = "0x1BEE2B4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x1BEE92C", Offset = "0x1BEE92C", VA = "0x1BEE92C", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x1BEEF00", Offset = "0x1BEEF00", VA = "0x1BEEF00", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x1BEEEB0", Offset = "0x1BEEEB0", VA = "0x1BEEEB0")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x1BEED40", Offset = "0x1BEED40", VA = "0x1BEED40")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x1BEF2E8", Offset = "0x1BEF2E8", VA = "0x1BEF2E8")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x1BEF764", Offset = "0x1BEF764", VA = "0x1BEF764")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x1BEF48C", Offset = "0x1BEF48C", VA = "0x1BEF48C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x1BEFA5C", Offset = "0x1BEFA5C", VA = "0x1BEFA5C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x1BEFC78", Offset = "0x1BEFC78", VA = "0x1BEFC78", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x1BEFCC4", Offset = "0x1BEFCC4", VA = "0x1BEFCC4")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BE")]
		public class Locomotion
		{
			[Serializable]
			[Token(Token = "0x20000BF")]
			public enum Mode
			{
				[Token(Token = "0x40005C9")]
				Procedural,
				[Token(Token = "0x40005CA")]
				Animated
			}

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC0A0", Offset = "0x7EC0A0")]
			public Mode mode;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EC0D8", Offset = "0x7EC0D8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC0D8", Offset = "0x7EC0D8")]
			public float weight;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7EC12C", Offset = "0x7EC12C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC12C", Offset = "0x7EC12C")]
			public float moveThreshold;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[SerializeField]
			[AttributeAttribute(Name = "ShowLargeHeaderIf", RVA = "0x7EC1EC", Offset = "0x7EC1EC")]
			private byte animationHeader;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x7EC2AC", Offset = "0x7EC2AC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC2AC", Offset = "0x7EC2AC")]
			public float minAnimationSpeed;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC378", Offset = "0x7EC378")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x7EC378", Offset = "0x7EC378")]
			public float maxAnimationSpeed;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC440", Offset = "0x7EC440")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x7EC440", Offset = "0x7EC440")]
			public float animationSmoothTime;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "ShowLargeHeaderIf", RVA = "0x7EC510", Offset = "0x7EC510")]
			[SerializeField]
			private byte rootPositionHeader;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC5D8", Offset = "0x7EC5D8")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7EC5D8", Offset = "0x7EC5D8")]
			public Vector2 standOffset;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC698", Offset = "0x7EC698")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x7EC698", Offset = "0x7EC698")]
			public float rootLerpSpeedWhileMoving;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC764", Offset = "0x7EC764")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x7EC764", Offset = "0x7EC764")]
			public float rootLerpSpeedWhileStopping;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC830", Offset = "0x7EC830")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x7EC830", Offset = "0x7EC830")]
			public float rootLerpSpeedWhileTurning;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7EC8FC", Offset = "0x7EC8FC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EC8FC", Offset = "0x7EC8FC")]
			public float maxRootOffset;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[SerializeField]
			[AttributeAttribute(Name = "ShowLargeHeaderIf", RVA = "0x7EC9BC", Offset = "0x7EC9BC")]
			private byte rootRotationHeader;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x7ECA7C", Offset = "0x7ECA7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECA7C", Offset = "0x7ECA7C")]
			public float maxRootAngleMoving;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECB48", Offset = "0x7ECB48")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x7ECB48", Offset = "0x7ECB48")]
			public float maxRootAngleStanding;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[HideInInspector]
			[SerializeField]
			public float stepLengthMlp;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Animator animator;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 velocityLocal;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private Vector3 velocityLocalV;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Vector3 lastCorrection;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 lastHeadTargetPos;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Vector3 lastSpeedRootPos;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private Vector3 lastEndRootPos;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float rootLerpSpeed;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float rootVelocityV;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private float animSpeed;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private float animSpeedV;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float stopMoveTimer;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float turn;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private float maxRootAngleV;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private float currentAnimationSmoothTime;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private bool isMoving;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
			private bool firstFrame;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static int VRIK_Horizontal;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private static int VRIK_Vertical;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static int VRIK_IsMoving;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private static int VRIK_Speed;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static int VRIK_Turn;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private static bool isHashed;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private float lastVelLocalMag;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7ECC4C", Offset = "0x7ECC4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECC4C", Offset = "0x7ECC4C")]
			public float footDistance;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7ECD08", Offset = "0x7ECD08")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECD08", Offset = "0x7ECD08")]
			public float stepThreshold;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7ECDC4", Offset = "0x7ECDC4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECDC4", Offset = "0x7ECDC4")]
			public float angleThreshold;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECE80", Offset = "0x7ECE80")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7ECE80", Offset = "0x7ECE80")]
			public float comAngleMlp;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECF3C", Offset = "0x7ECF3C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7ECF3C", Offset = "0x7ECF3C")]
			public float maxVelocity;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ECFF8", Offset = "0x7ECFF8")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7ECFF8", Offset = "0x7ECFF8")]
			public float velocityFactor;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED0B4", Offset = "0x7ED0B4")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x7ED0B4", Offset = "0x7ED0B4")]
			public float maxLegStretch;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7ED17C", Offset = "0x7ED17C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED17C", Offset = "0x7ED17C")]
			public float rootSpeed;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED238", Offset = "0x7ED238")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7ED238", Offset = "0x7ED238")]
			public float stepSpeed;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED2F4", Offset = "0x7ED2F4")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7ED2F4", Offset = "0x7ED2F4")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED3B0", Offset = "0x7ED3B0")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7ED3B0", Offset = "0x7ED3B0")]
			public float maxBodyYOffset;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED46C", Offset = "0x7ED46C")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7ED46C", Offset = "0x7ED46C")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED528", Offset = "0x7ED528")]
			[AttributeAttribute(Name = "ShowRangeIfAttribute", RVA = "0x7ED528", Offset = "0x7ED528")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7ED5F0", Offset = "0x7ED5F0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED5F0", Offset = "0x7ED5F0")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7ED6AC", Offset = "0x7ED6AC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED6AC", Offset = "0x7ED6AC")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED768", Offset = "0x7ED768")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7ED768", Offset = "0x7ED768")]
			public Vector3 offset;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			[SerializeField]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			[SerializeField]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7ED8D4", Offset = "0x7ED8D4")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private Footstep[] footsteps;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			private Vector3 comVelocity;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private int leftFootIndex;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private int rightFootIndex;

			[Token(Token = "0x17000091")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60006E1")]
				[Address(RVA = "0x1BF167C", Offset = "0x1BF167C", VA = "0x1BF167C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5748", Offset = "0x7F5748")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006E2")]
				[Address(RVA = "0x1BF168C", Offset = "0x1BF168C", VA = "0x1BF168C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5758", Offset = "0x7F5758")]
				private set
				{
				}
			}

			[Token(Token = "0x17000092")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60006E9")]
				[Address(RVA = "0x1BF2AB8", Offset = "0x1BF2AB8", VA = "0x1BF2AB8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000093")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60006EA")]
				[Address(RVA = "0x1BF2AF8", Offset = "0x1BF2AF8", VA = "0x1BF2AF8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000094")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60006EB")]
				[Address(RVA = "0x1BF2B3C", Offset = "0x1BF2B3C", VA = "0x1BF2B3C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000095")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60006EC")]
				[Address(RVA = "0x1BF2B7C", Offset = "0x1BF2B7C", VA = "0x1BF2B7C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x1BEFDA0", Offset = "0x1BEFDA0", VA = "0x1BEFDA0")]
			public void Initiate(Animator animator, Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x1BF01BC", Offset = "0x1BF01BC", VA = "0x1BF01BC")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x1BF060C", Offset = "0x1BF060C", VA = "0x1BF060C")]
			public void Relax()
			{
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x1BF0674", Offset = "0x1BF0674", VA = "0x1BF0674")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x1BF0A54", Offset = "0x1BF0A54", VA = "0x1BF0A54")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x1BF00CC", Offset = "0x1BF00CC", VA = "0x1BF00CC")]
			public void Initiate_Animated(Animator animator, Vector3[] positions)
			{
			}

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x1BF0BB4", Offset = "0x1BF0BB4", VA = "0x1BF0BB4")]
			private void ResetParams(Vector3[] positions)
			{
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x1BF03C0", Offset = "0x1BF03C0", VA = "0x1BF03C0")]
			public void Reset_Animated(Vector3[] positions)
			{
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x1BF0940", Offset = "0x1BF0940", VA = "0x1BF0940")]
			private void AddDeltaRotation_Animated(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x1BF0B64", Offset = "0x1BF0B64", VA = "0x1BF0B64")]
			private void AddDeltaPosition_Animated(Vector3 delta)
			{
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x1BF0C44", Offset = "0x1BF0C44", VA = "0x1BF0C44")]
			public void Solve_Animated(IKSolverVR solver, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x1BEFDEC", Offset = "0x1BEFDEC", VA = "0x1BEFDEC")]
			private void Initiate_Procedural(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x1BF01E8", Offset = "0x1BF01E8", VA = "0x1BF01E8")]
			private void Reset_Procedural(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x1BF0610", Offset = "0x1BF0610", VA = "0x1BF0610")]
			private void Relax_Procedural()
			{
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x1BF06F0", Offset = "0x1BF06F0", VA = "0x1BF06F0")]
			private void AddDeltaRotation_Procedural(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x1BF0AA0", Offset = "0x1BF0AA0", VA = "0x1BF0AA0")]
			private void AddDeltaPosition_Procedural(Vector3 delta)
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x1BF169C", Offset = "0x1BF169C", VA = "0x1BF169C")]
			public void Solve_Procedural(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x1BF282C", Offset = "0x1BF282C", VA = "0x1BF282C")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x1BF2968", Offset = "0x1BF2968", VA = "0x1BF2968")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x1BF29EC", Offset = "0x1BF29EC", VA = "0x1BF29EC")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x1BF2BC0", Offset = "0x1BF2BC0", VA = "0x1BF2BC0")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C0")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x7ED8E4", Offset = "0x7ED8E4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED8E4", Offset = "0x7ED8E4")]
			public Transform headTarget;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED944", Offset = "0x7ED944")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ED944", Offset = "0x7ED944")]
			public float positionWeight;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED998", Offset = "0x7ED998")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ED998", Offset = "0x7ED998")]
			public float rotationWeight;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7ED9EC", Offset = "0x7ED9EC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7ED9EC", Offset = "0x7ED9EC")]
			public float headClampWeight;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDA40", Offset = "0x7EDA40")]
			public float minHeadHeight;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDA78", Offset = "0x7EDA78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EDA78", Offset = "0x7EDA78")]
			public float useAnimatedHeadHeightWeight;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7EDACC", Offset = "0x7EDACC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDACC", Offset = "0x7EDACC")]
			public float useAnimatedHeadHeightRange;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDBA8", Offset = "0x7EDBA8")]
			[AttributeAttribute(Name = "ShowIfAttribute", RVA = "0x7EDBA8", Offset = "0x7EDBA8")]
			public float animatedHeadHeightBlend;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EDC7C", Offset = "0x7EDC7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDC7C", Offset = "0x7EDC7C")]
			public Transform pelvisTarget;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EDCDC", Offset = "0x7EDCDC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDCDC", Offset = "0x7EDCDC")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDD30", Offset = "0x7EDD30")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EDD30", Offset = "0x7EDD30")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDD84", Offset = "0x7EDD84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EDD84", Offset = "0x7EDD84")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDDD8", Offset = "0x7EDDD8")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EDDD8", Offset = "0x7EDDD8")]
			public Transform chestGoal;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDE38", Offset = "0x7EDE38")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EDE38", Offset = "0x7EDE38")]
			public float chestGoalWeight;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDE8C", Offset = "0x7EDE8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EDE8C", Offset = "0x7EDE8C")]
			public float chestClampWeight;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDEE0", Offset = "0x7EDEE0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EDEE0", Offset = "0x7EDEE0")]
			public float rotateChestByHands;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EDF34", Offset = "0x7EDF34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDF34", Offset = "0x7EDF34")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EDF34", Offset = "0x7EDF34")]
			public float bodyPosStiffness;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EDFAC", Offset = "0x7EDFAC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EDFAC", Offset = "0x7EDFAC")]
			public float bodyRotStiffness;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7EE000", Offset = "0x7EE000")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EE000", Offset = "0x7EE000")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE000", Offset = "0x7EE000")]
			public float neckStiffness;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE078", Offset = "0x7EE078")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[AttributeAttribute(Name = "LargeHeader", RVA = "0x7EE0B0", Offset = "0x7EE0B0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE0B0", Offset = "0x7EE0B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EE0B0", Offset = "0x7EE0B0")]
			public float maxRootAngle;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EE12C", Offset = "0x7EE12C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE12C", Offset = "0x7EE12C")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[HideInInspector]
			internal Vector3 headPosition;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EE258", Offset = "0x7EE258")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EE268", Offset = "0x7EE268")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
			private Quaternion headRotation;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int pelvisIndex;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int spineIndex;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int chestIndex;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private int neckIndex;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private int headIndex;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float length;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private bool hasChest;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x219")]
			private bool hasNeck;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21A")]
			private bool hasLegs;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private float headHeight;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			private float sizeMlp;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
			private Vector3 chestForward;

			[Token(Token = "0x17000096")]
			internal VirtualBone pelvis
			{
				[Token(Token = "0x60006F1")]
				[Address(RVA = "0x1BF27AC", Offset = "0x1BF27AC", VA = "0x1BF27AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000097")]
			internal VirtualBone firstSpineBone
			{
				[Token(Token = "0x60006F2")]
				[Address(RVA = "0x1BF2D34", Offset = "0x1BF2D34", VA = "0x1BF2D34")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			internal VirtualBone chest
			{
				[Token(Token = "0x60006F3")]
				[Address(RVA = "0x1BF2D74", Offset = "0x1BF2D74", VA = "0x1BF2D74")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000099")]
			internal VirtualBone head
			{
				[Token(Token = "0x60006F4")]
				[Address(RVA = "0x1BF27EC", Offset = "0x1BF27EC", VA = "0x1BF27EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009A")]
			private VirtualBone neck
			{
				[Token(Token = "0x60006F5")]
				[Address(RVA = "0x1BF2DC8", Offset = "0x1BF2DC8", VA = "0x1BF2DC8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009B")]
			internal Quaternion anchorRotation
			{
				[Token(Token = "0x60006F6")]
				[Address(RVA = "0x1BF2E08", Offset = "0x1BF2E08", VA = "0x1BF2E08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5768", Offset = "0x7F5768")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006F7")]
				[Address(RVA = "0x1BF2E1C", Offset = "0x1BF2E1C", VA = "0x1BF2E1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5778", Offset = "0x7F5778")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009C")]
			internal Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x1BF2E30", Offset = "0x1BF2E30", VA = "0x1BF2E30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5788", Offset = "0x7F5788")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006F9")]
				[Address(RVA = "0x1BF2E44", Offset = "0x1BF2E44", VA = "0x1BF2E44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5798", Offset = "0x7F5798")]
				private set
				{
				}
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x1BF2E58", Offset = "0x1BF2E58", VA = "0x1BF2E58", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x1BF3874", Offset = "0x1BF3874", VA = "0x1BF3874", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x1BF3C48", Offset = "0x1BF3C48", VA = "0x1BF3C48", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x1BF4094", Offset = "0x1BF4094", VA = "0x1BF4094")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x1BF44F0", Offset = "0x1BF44F0", VA = "0x1BF44F0")]
			public void Solve(Animator animator, VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x1BF4D54", Offset = "0x1BF4D54", VA = "0x1BF4D54")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x1BF53E4", Offset = "0x1BF53E4", VA = "0x1BF53E4")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x1BF55E0", Offset = "0x1BF55E0", VA = "0x1BF55E0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x1BF57BC", Offset = "0x1BF57BC", VA = "0x1BF57BC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x1BF424C", Offset = "0x1BF424C", VA = "0x1BF424C")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x1BF5130", Offset = "0x1BF5130", VA = "0x1BF5130")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x1BF49F8", Offset = "0x1BF49F8", VA = "0x1BF49F8")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x1BF5858", Offset = "0x1BF5858", VA = "0x1BF5858")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x1BF520C", Offset = "0x1BF520C", VA = "0x1BF520C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x1BF4ED8", Offset = "0x1BF4ED8", VA = "0x1BF4ED8")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x1BF5A58", Offset = "0x1BF5A58", VA = "0x1BF5A58")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C1")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000605")]
			Pelvis,
			[Token(Token = "0x4000606")]
			Chest,
			[Token(Token = "0x4000607")]
			Head,
			[Token(Token = "0x4000608")]
			LeftHand,
			[Token(Token = "0x4000609")]
			RightHand,
			[Token(Token = "0x400060A")]
			LeftFoot,
			[Token(Token = "0x400060B")]
			RightFoot,
			[Token(Token = "0x400060C")]
			LeftHeel,
			[Token(Token = "0x400060D")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000C2")]
		public enum RotationOffset
		{
			[Token(Token = "0x400060F")]
			Pelvis,
			[Token(Token = "0x4000610")]
			Chest,
			[Token(Token = "0x4000611")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000C3")]
		public class VirtualBone
		{
			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x1FFD96C", Offset = "0x1FFD96C", VA = "0x1FFD96C")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x1FFD9E8", Offset = "0x1FFD9E8", VA = "0x1FFD9E8")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x1FFDA08", Offset = "0x1FFDA08", VA = "0x1FFDA08")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x1FFDB8C", Offset = "0x1FFDB8C", VA = "0x1FFDB8C")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x1FFDD7C", Offset = "0x1FFDD7C", VA = "0x1FFDD7C")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x1FFDEA4", Offset = "0x1FFDEA4", VA = "0x1FFDEA4")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x1FFE004", Offset = "0x1FFE004", VA = "0x1FFE004")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x1FFE140", Offset = "0x1FFE140", VA = "0x1FFE140")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x1FFE1F8", Offset = "0x1FFE1F8", VA = "0x1FFE1F8")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x1FFE5FC", Offset = "0x1FFE5FC", VA = "0x1FFE5FC")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x1FFE764", Offset = "0x1FFE764", VA = "0x1FFE764")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x1FFEAF4", Offset = "0x1FFEAF4", VA = "0x1FFEAF4")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x1FFEB64", Offset = "0x1FFEB64", VA = "0x1FFEB64")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EB2C8", Offset = "0x7EB2C8")]
		private Animator <animator>k__BackingField;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool hasChest;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool hasNeck;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool hasShoulders;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool hasToes;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool hasLegs;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool hasArms;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 rootV;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 bodyOffset;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int supportLegIndex;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int lastLOD;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float lastLocomotionWeight;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB2D8", Offset = "0x7EB2D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EB2D8", Offset = "0x7EB2D8")]
		public int LOD;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB32C", Offset = "0x7EB32C")]
		public float scale;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB364", Offset = "0x7EB364")]
		public bool plantFeet;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EB39C", Offset = "0x7EB39C")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB3AC", Offset = "0x7EB3AC")]
		public Spine spine;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB3E4", Offset = "0x7EB3E4")]
		public Arm leftArm;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB41C", Offset = "0x7EB41C")]
		public Arm rightArm;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB454", Offset = "0x7EB454")]
		public Leg leftLeg;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB48C", Offset = "0x7EB48C")]
		public Leg rightLeg;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EB4C4", Offset = "0x7EB4C4")]
		public Locomotion locomotion;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Leg[] legs;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Arm[] arms;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 headPosition;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 lastOffset;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos1;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos2;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 debugPos4;

		[Token(Token = "0x1700007A")]
		public Animator animator
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x1BAB698", Offset = "0x1BAB698", VA = "0x1BAB698")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F55A8", Offset = "0x7F55A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x1BAB6A0", Offset = "0x1BAB6A0", VA = "0x1BAB6A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F55B8", Offset = "0x7F55B8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x1BAF0E8", Offset = "0x1BAF0E8", VA = "0x1BAF0E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F55C8", Offset = "0x7F55C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x1BAF0F0", Offset = "0x1BAF0F0", VA = "0x1BAF0F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F55D8", Offset = "0x7F55D8")]
			private set
			{
			}
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1BAB6A8", Offset = "0x1BAB6A8", VA = "0x1BAB6A8")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1BABBC8", Offset = "0x1BABBC8", VA = "0x1BABBC8")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1BABA54", Offset = "0x1BABA54", VA = "0x1BABA54")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1BABF2C", Offset = "0x1BABF2C", VA = "0x1BABF2C")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1BAC074", Offset = "0x1BAC074", VA = "0x1BAC074")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1BAC0A4", Offset = "0x1BAC0A4", VA = "0x1BAC0A4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1BAC154", Offset = "0x1BAC154", VA = "0x1BAC154")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x1BAC23C", Offset = "0x1BAC23C", VA = "0x1BAC23C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x1BACA1C", Offset = "0x1BACA1C", VA = "0x1BACA1C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1BACB8C", Offset = "0x1BACB8C", VA = "0x1BACB8C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1BACD90", Offset = "0x1BACD90", VA = "0x1BACD90", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1BACE0C", Offset = "0x1BACE0C", VA = "0x1BACE0C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1BACE88", Offset = "0x1BACE88", VA = "0x1BACE88", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1BAD06C", Offset = "0x1BAD06C", VA = "0x1BAD06C")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1BABE0C", Offset = "0x1BABE0C", VA = "0x1BABE0C")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1BAC338", Offset = "0x1BAC338", VA = "0x1BAC338")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1BAD22C", Offset = "0x1BAD22C", VA = "0x1BAD22C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1BAD27C", Offset = "0x1BAD27C", VA = "0x1BAD27C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1BAE804", Offset = "0x1BAE804", VA = "0x1BAE804")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1BAC49C", Offset = "0x1BAC49C", VA = "0x1BAC49C")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, bool hasArms)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1BAD600", Offset = "0x1BAD600", VA = "0x1BAD600")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1BAEBB4", Offset = "0x1BAEBB4", VA = "0x1BAEBB4")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1BAEBFC", Offset = "0x1BAEBFC", VA = "0x1BAEBFC")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1BAE6AC", Offset = "0x1BAE6AC", VA = "0x1BAE6AC")]
		private void Write()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1BAEC40", Offset = "0x1BAEC40", VA = "0x1BAEC40")]
		private Vector3 GetPelvisOffset(float deltaTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1BAF0F8", Offset = "0x1BAF0F8", VA = "0x1BAF0F8")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE278", Offset = "0x7EE278")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xED86A0", Offset = "0xED86A0", VA = "0xED86A0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xED8E44", Offset = "0xED8E44", VA = "0xED8E44")]
		private void Update()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xED8FD8", Offset = "0xED8FD8", VA = "0xED8FD8")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xED9468", Offset = "0xED9468", VA = "0xED9468")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xED952C", Offset = "0xED952C", VA = "0xED952C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xED9668", Offset = "0xED9668", VA = "0xED9668")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C5")]
	public class TwistSolver
	{
		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE2B0", Offset = "0x7EE2B0")]
		public Transform transform;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE2E8", Offset = "0x7EE2E8")]
		public Transform parent;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE320", Offset = "0x7EE320")]
		public Transform[] children;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE358", Offset = "0x7EE358")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EE358", Offset = "0x7EE358")]
		public float weight;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE3AC", Offset = "0x7EE3AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EE3AC", Offset = "0x7EE3AC")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE400", Offset = "0x7EE400")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EE400", Offset = "0x7EE400")]
		public float twistAngleOffset;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultChildLocalRotations;

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xED96D0", Offset = "0xED96D0", VA = "0xED96D0")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xED88A0", Offset = "0xED88A0", VA = "0xED88A0")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xED8F18", Offset = "0xED8F18", VA = "0xED8F18")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xED909C", Offset = "0xED909C", VA = "0xED909C")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C6")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EE45C", Offset = "0x7EE45C")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EE46C", Offset = "0x7EE46C")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EE47C", Offset = "0x7EE47C")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x1700009D")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x1BB072C", Offset = "0x1BB072C", VA = "0x1BB072C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F57A8", Offset = "0x7F57A8")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x1BB0734", Offset = "0x1BB0734", VA = "0x1BB0734")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F57B8", Offset = "0x7F57B8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public bool isPaused
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1BB073C", Offset = "0x1BB073C", VA = "0x1BB073C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F57C8", Offset = "0x7F57C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x1BB0744", Offset = "0x1BB0744", VA = "0x1BB0744")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F57D8", Offset = "0x7F57D8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x1BB0750", Offset = "0x1BB0750", VA = "0x1BB0750")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F57E8", Offset = "0x7F57E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x1BB0758", Offset = "0x1BB0758", VA = "0x1BB0758")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F57F8", Offset = "0x7F57F8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public bool inInteraction
		{
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x1BB0760", Offset = "0x1BB0760", VA = "0x1BB0760")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A1")]
		public float progress
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x1BB2E5C", Offset = "0x1BB2E5C", VA = "0x1BB2E5C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x1BB07CC", Offset = "0x1BB07CC", VA = "0x1BB07CC")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x1BB0864", Offset = "0x1BB0864", VA = "0x1BB0864")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x1BB0924", Offset = "0x1BB0924", VA = "0x1BB0924")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x1BB0A9C", Offset = "0x1BB0A9C", VA = "0x1BB0A9C")]
		public bool ResetToDefaults(float speed, float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x1BB0DF8", Offset = "0x1BB0DF8", VA = "0x1BB0DF8")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x1BB0EB4", Offset = "0x1BB0EB4", VA = "0x1BB0EB4")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1BB0F0C", Offset = "0x1BB0F0C", VA = "0x1BB0F0C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x1BB1180", Offset = "0x1BB1180", VA = "0x1BB1180")]
		public bool Start(InteractionObject interactionObject, InteractionTarget interactionTarget, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x1BB1B84", Offset = "0x1BB1B84", VA = "0x1BB1B84")]
		public void Update(Transform root, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x1BB2654", Offset = "0x1BB2654", VA = "0x1BB2654")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x1BB2898", Offset = "0x1BB2898", VA = "0x1BB2898")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x1BB2D38", Offset = "0x1BB2D38", VA = "0x1BB2D38")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x1BB2FBC", Offset = "0x1BB2FBC", VA = "0x1BB2FBC")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C7")]
	public class InteractionLookAt
	{
		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE48C", Offset = "0x7EE48C")]
		public LookAtIK ik;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE4C4", Offset = "0x7EE4C4")]
		public float lerpSpeed;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE4FC", Offset = "0x7EE4FC")]
		public float weightSpeed;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x1BB31E0", Offset = "0x1BB31E0", VA = "0x1BB31E0")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x1BB3308", Offset = "0x1BB3308", VA = "0x1BB3308")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x1BB33AC", Offset = "0x1BB33AC", VA = "0x1BB33AC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x1BB39F4", Offset = "0x1BB39F4", VA = "0x1BB39F4")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x1BB3AE8", Offset = "0x1BB3AE8", VA = "0x1BB3AE8")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x1BB3BB0", Offset = "0x1BB3BB0", VA = "0x1BB3BB0")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E83CC", Offset = "0x7E83CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E83CC", Offset = "0x7E83CC")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C9")]
		public class InteractionEvent
		{
			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE60C", Offset = "0x7EE60C")]
			public float time;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE644", Offset = "0x7EE644")]
			public bool pause;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE67C", Offset = "0x7EE67C")]
			public bool pickUp;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE6B4", Offset = "0x7EE6B4")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE6EC", Offset = "0x7EE6EC")]
			public Message[] messages;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE724", Offset = "0x7EE724")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x1FFF310", Offset = "0x1FFF310", VA = "0x1FFF310")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x1FFF4E4", Offset = "0x1FFF4E4", VA = "0x1FFF4E4")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CA")]
		public class Message
		{
			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE75C", Offset = "0x7EE75C")]
			public string function;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE794", Offset = "0x7EE794")]
			public GameObject recipient;

			[Token(Token = "0x4000666")]
			private const string empty = "";

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x1FFF3E0", Offset = "0x1FFF3E0", VA = "0x1FFF3E0")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x1FFF4EC", Offset = "0x1FFF4EC", VA = "0x1FFF4EC")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CB")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE7CC", Offset = "0x7EE7CC")]
			public Animator animator;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE804", Offset = "0x7EE804")]
			public Animation animation;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE83C", Offset = "0x7EE83C")]
			public string animationState;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE874", Offset = "0x7EE874")]
			public float crossfadeTime;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE8AC", Offset = "0x7EE8AC")]
			public int layer;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE8E4", Offset = "0x7EE8E4")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400066D")]
			private const string empty = "";

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x1FFF07C", Offset = "0x1FFF07C", VA = "0x1FFF07C")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x1FFF16C", Offset = "0x1FFF16C", VA = "0x1FFF16C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x1FFF220", Offset = "0x1FFF220", VA = "0x1FFF220")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0x1FFF2FC", Offset = "0x1FFF2FC", VA = "0x1FFF2FC")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CC")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20000CD")]
			public enum Type
			{
				[Token(Token = "0x4000671")]
				PositionWeight,
				[Token(Token = "0x4000672")]
				RotationWeight,
				[Token(Token = "0x4000673")]
				PositionOffsetX,
				[Token(Token = "0x4000674")]
				PositionOffsetY,
				[Token(Token = "0x4000675")]
				PositionOffsetZ,
				[Token(Token = "0x4000676")]
				Pull,
				[Token(Token = "0x4000677")]
				Reach,
				[Token(Token = "0x4000678")]
				RotateBoneWeight,
				[Token(Token = "0x4000679")]
				Push,
				[Token(Token = "0x400067A")]
				PushParent,
				[Token(Token = "0x400067B")]
				PoserWeight,
				[Token(Token = "0x400067C")]
				BendGoalWeight
			}

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE91C", Offset = "0x7EE91C")]
			public Type type;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE954", Offset = "0x7EE954")]
			public AnimationCurve curve;

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x1FFF530", Offset = "0x1FFF530", VA = "0x1FFF530")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000761")]
			[Address(RVA = "0x1FFF55C", Offset = "0x1FFF55C", VA = "0x1FFF55C")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CE")]
		public class Multiplier
		{
			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE98C", Offset = "0x7EE98C")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE9C4", Offset = "0x7EE9C4")]
			public float multiplier;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE9FC", Offset = "0x7EE9FC")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000762")]
			[Address(RVA = "0x1FFF4F4", Offset = "0x1FFF4F4", VA = "0x1FFF4F4")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0x1FFF54C", Offset = "0x1FFF54C", VA = "0x1FFF54C")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE544", Offset = "0x7EE544")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE57C", Offset = "0x7EE57C")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EE5B4", Offset = "0x7EE5B4")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EE5EC", Offset = "0x7EE5EC")]
		private float <length>k__BackingField;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EE5FC", Offset = "0x7EE5FC")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x170000A2")]
		public float length
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x1BB3E04", Offset = "0x1BB3E04", VA = "0x1BB3E04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F59C8", Offset = "0x7F59C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x1BB3E0C", Offset = "0x1BB3E0C", VA = "0x1BB3E0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F59D8", Offset = "0x7F59D8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x1BB3E14", Offset = "0x1BB3E14", VA = "0x1BB3E14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F59E8", Offset = "0x7F59E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x1BB3E1C", Offset = "0x1BB3E1C", VA = "0x1BB3E1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F59F8", Offset = "0x7F59F8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x1BB3FEC", Offset = "0x1BB3FEC", VA = "0x1BB3FEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x1BB2E98", Offset = "0x1BB2E98", VA = "0x1BB2E98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x1BB3BC4", Offset = "0x1BB3BC4", VA = "0x1BB3BC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5808", Offset = "0x7F5808")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x1BB3C0C", Offset = "0x1BB3C0C", VA = "0x1BB3C0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5840", Offset = "0x7F5840")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x1BB3C54", Offset = "0x1BB3C54", VA = "0x1BB3C54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5878", Offset = "0x7F5878")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x1BB3C9C", Offset = "0x1BB3C9C", VA = "0x1BB3C9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F58B0", Offset = "0x7F58B0")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1BB3CE4", Offset = "0x1BB3CE4", VA = "0x1BB3CE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F58E8", Offset = "0x7F58E8")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x1BB3D2C", Offset = "0x1BB3D2C", VA = "0x1BB3D2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5920", Offset = "0x7F5920")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x1BB3D74", Offset = "0x1BB3D74", VA = "0x1BB3D74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5958", Offset = "0x7F5958")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x1BB3DBC", Offset = "0x1BB3DBC", VA = "0x1BB3DBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5990", Offset = "0x7F5990")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x1BB3E24", Offset = "0x1BB3E24", VA = "0x1BB3E24")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x1BB4078", Offset = "0x1BB4078", VA = "0x1BB4078")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x1BB15A4", Offset = "0x1BB15A4", VA = "0x1BB15A4")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x1BB41E4", Offset = "0x1BB41E4", VA = "0x1BB41E4")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x1BB103C", Offset = "0x1BB103C", VA = "0x1BB103C")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x1BB159C", Offset = "0x1BB159C", VA = "0x1BB159C")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x1BB21F8", Offset = "0x1BB21F8", VA = "0x1BB21F8")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1BB2B18", Offset = "0x1BB2B18", VA = "0x1BB2B18")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1BB4794", Offset = "0x1BB4794", VA = "0x1BB4794")]
		private void Start()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x1BB42CC", Offset = "0x1BB42CC", VA = "0x1BB42CC")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1BB41EC", Offset = "0x1BB41EC", VA = "0x1BB41EC")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1BB472C", Offset = "0x1BB472C", VA = "0x1BB472C")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1BB4798", Offset = "0x1BB4798", VA = "0x1BB4798")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x1BB4800", Offset = "0x1BB4800", VA = "0x1BB4800")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E842C", Offset = "0x7E842C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E842C", Offset = "0x7E842C")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000D0")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000D1")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEA34", Offset = "0x7EEA34")]
		public string targetTag;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEA6C", Offset = "0x7EEA6C")]
		public float fadeInTime;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEAA4", Offset = "0x7EEAA4")]
		public float speed;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEADC", Offset = "0x7EEADC")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EEB14", Offset = "0x7EEB14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEB14", Offset = "0x7EEB14")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7EEB14", Offset = "0x7EEB14")]
		public Collider characterCollider;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEB98", Offset = "0x7EEB98")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7EEB98", Offset = "0x7EEB98")]
		public Transform FPSCamera;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEBF8", Offset = "0x7EEBF8")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEC30", Offset = "0x7EEC30")]
		public float camRaycastDistance;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EEC68", Offset = "0x7EEC68")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEC78", Offset = "0x7EEC78")]
		[SerializeField]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7EEC78", Offset = "0x7EEC78")]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EECD8", Offset = "0x7EECD8")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EED10", Offset = "0x7EED10")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float lastTime;

		[Token(Token = "0x170000A6")]
		public bool inInteraction
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x1BB0604", Offset = "0x1BB0604", VA = "0x1BB0604")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A7")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000787")]
			[Address(RVA = "0x1BB6678", Offset = "0x1BB6678", VA = "0x1BB6678")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000788")]
			[Address(RVA = "0x1BB6680", Offset = "0x1BB6680", VA = "0x1BB6680")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000789")]
			[Address(RVA = "0x1BB6688", Offset = "0x1BB6688", VA = "0x1BB6688")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5BC8", Offset = "0x7F5BC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600078A")]
			[Address(RVA = "0x1BB6690", Offset = "0x1BB6690", VA = "0x1BB6690")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5BD8", Offset = "0x7F5BD8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public bool initiated
		{
			[Token(Token = "0x600078B")]
			[Address(RVA = "0x1BB6698", Offset = "0x1BB6698", VA = "0x1BB6698")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5BE8", Offset = "0x7F5BE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600078C")]
			[Address(RVA = "0x1BB66A0", Offset = "0x1BB66A0", VA = "0x1BB66A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5BF8", Offset = "0x7F5BF8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x1BB4868", Offset = "0x1BB4868", VA = "0x1BB4868")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5A08", Offset = "0x7F5A08")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1BB48B0", Offset = "0x1BB48B0", VA = "0x1BB48B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5A40", Offset = "0x7F5A40")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x1BB48F8", Offset = "0x1BB48F8", VA = "0x1BB48F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5A78", Offset = "0x7F5A78")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1BB4940", Offset = "0x1BB4940", VA = "0x1BB4940")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5AB0", Offset = "0x7F5AB0")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x1BB4988", Offset = "0x1BB4988", VA = "0x1BB4988")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5AE8", Offset = "0x7F5AE8")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1BB49D0", Offset = "0x1BB49D0", VA = "0x1BB49D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5B20", Offset = "0x7F5B20")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1BB4A18", Offset = "0x1BB4A18", VA = "0x1BB4A18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5B58", Offset = "0x7F5B58")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1BB4A60", Offset = "0x1BB4A60", VA = "0x1BB4A60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5B90", Offset = "0x7F5B90")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x1BB4BA0", Offset = "0x1BB4BA0", VA = "0x1BB4BA0")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1BB4C6C", Offset = "0x1BB4C6C", VA = "0x1BB4C6C")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x1BB4D38", Offset = "0x1BB4D38", VA = "0x1BB4D38")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x1BB4DE4", Offset = "0x1BB4DE4", VA = "0x1BB4DE4")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1BAFCE4", Offset = "0x1BAFCE4", VA = "0x1BAFCE4")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x1BB4EDC", Offset = "0x1BB4EDC", VA = "0x1BB4EDC")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionTarget target, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1BB4FF8", Offset = "0x1BB4FF8", VA = "0x1BB4FF8")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x1BB5088", Offset = "0x1BB5088", VA = "0x1BB5088")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1BB5118", Offset = "0x1BB5118", VA = "0x1BB5118")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1BB51A8", Offset = "0x1BB51A8", VA = "0x1BB51A8")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1BB06B0", Offset = "0x1BB06B0", VA = "0x1BB06B0")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1BB521C", Offset = "0x1BB521C", VA = "0x1BB521C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1BB5284", Offset = "0x1BB5284", VA = "0x1BB5284")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1BB5310", Offset = "0x1BB5310", VA = "0x1BB5310")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1BB53C4", Offset = "0x1BB53C4", VA = "0x1BB53C4")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1BB54A8", Offset = "0x1BB54A8", VA = "0x1BB54A8")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x1BB5780", Offset = "0x1BB5780", VA = "0x1BB5780")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1BB5978", Offset = "0x1BB5978", VA = "0x1BB5978")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1BB5C1C", Offset = "0x1BB5C1C", VA = "0x1BB5C1C")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1BB5EF4", Offset = "0x1BB5EF4", VA = "0x1BB5EF4")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1BB5F38", Offset = "0x1BB5F38", VA = "0x1BB5F38")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1BB5FB0", Offset = "0x1BB5FB0", VA = "0x1BB5FB0")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1BB60E4", Offset = "0x1BB60E4", VA = "0x1BB60E4")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1BB6288", Offset = "0x1BB6288", VA = "0x1BB6288")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1BB652C", Offset = "0x1BB652C", VA = "0x1BB652C")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1BB5D30", Offset = "0x1BB5D30", VA = "0x1BB5D30")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1BB66AC", Offset = "0x1BB66AC", VA = "0x1BB66AC")]
		public void Start()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1BB6ED4", Offset = "0x1BB6ED4", VA = "0x1BB6ED4")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1BB6EF4", Offset = "0x1BB6EF4", VA = "0x1BB6EF4")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1BB6F10", Offset = "0x1BB6F10", VA = "0x1BB6F10")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1BB6F2C", Offset = "0x1BB6F2C", VA = "0x1BB6F2C")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1BB6F8C", Offset = "0x1BB6F8C", VA = "0x1BB6F8C")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1BB70C8", Offset = "0x1BB70C8", VA = "0x1BB70C8")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1BB71D8", Offset = "0x1BB71D8", VA = "0x1BB71D8")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1BB757C", Offset = "0x1BB757C", VA = "0x1BB757C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1BB76A8", Offset = "0x1BB76A8", VA = "0x1BB76A8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1BB7904", Offset = "0x1BB7904", VA = "0x1BB7904")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1BB6C20", Offset = "0x1BB6C20", VA = "0x1BB6C20")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x1BB7A40", Offset = "0x1BB7A40", VA = "0x1BB7A40")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x1BB7A68", Offset = "0x1BB7A68", VA = "0x1BB7A68")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x1BB7BC0", Offset = "0x1BB7BC0", VA = "0x1BB7BC0")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x1BB7C54", Offset = "0x1BB7C54", VA = "0x1BB7C54")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1BB7D28", Offset = "0x1BB7D28", VA = "0x1BB7D28")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x1BB7D40", Offset = "0x1BB7D40", VA = "0x1BB7D40")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x1BB4AA8", Offset = "0x1BB4AA8", VA = "0x1BB4AA8")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x1BB5650", Offset = "0x1BB5650", VA = "0x1BB5650")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1BB813C", Offset = "0x1BB813C", VA = "0x1BB813C")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E848C", Offset = "0x7E848C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E848C", Offset = "0x7E848C")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D3")]
		public enum RotationMode
		{
			[Token(Token = "0x40006A6")]
			TwoDOF,
			[Token(Token = "0x40006A7")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x20000D4")]
		public class Multiplier
		{
			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEF6C", Offset = "0x7EEF6C")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEFA4", Offset = "0x7EEFA4")]
			public float multiplier;

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x1FFFBD0", Offset = "0x1FFFBD0", VA = "0x1FFFBD0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EED20", Offset = "0x7EED20")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EED58", Offset = "0x7EED58")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EED90", Offset = "0x7EED90")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEDC8", Offset = "0x7EEDC8")]
		public Transform pivot;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEE00", Offset = "0x7EEE00")]
		public RotationMode rotationMode;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEE38", Offset = "0x7EEE38")]
		public Vector3 twistAxis;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEE70", Offset = "0x7EEE70")]
		public float twistWeight;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEEA8", Offset = "0x7EEEA8")]
		public float swingWeight;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EEEE0", Offset = "0x7EEEE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEEE0", Offset = "0x7EEEE0")]
		public float threeDOFWeight;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEF34", Offset = "0x7EEF34")]
		public bool rotateOnce;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x1BB8924", Offset = "0x1BB8924", VA = "0x1BB8924")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5C08", Offset = "0x7F5C08")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1BB896C", Offset = "0x1BB896C", VA = "0x1BB896C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5C40", Offset = "0x7F5C40")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1BB89B4", Offset = "0x1BB89B4", VA = "0x1BB89B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5C78", Offset = "0x7F5C78")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x1BB89FC", Offset = "0x1BB89FC", VA = "0x1BB89FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5CB0", Offset = "0x7F5CB0")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x1BB8A44", Offset = "0x1BB8A44", VA = "0x1BB8A44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5CE8", Offset = "0x7F5CE8")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x1BB8A8C", Offset = "0x1BB8A8C", VA = "0x1BB8A8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5D20", Offset = "0x7F5D20")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x1BB8AD4", Offset = "0x1BB8AD4", VA = "0x1BB8AD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5D58", Offset = "0x7F5D58")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x1BB8B1C", Offset = "0x1BB8B1C", VA = "0x1BB8B1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5D90", Offset = "0x7F5D90")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x1BB425C", Offset = "0x1BB425C", VA = "0x1BB425C")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x1BB2F24", Offset = "0x1BB2F24", VA = "0x1BB2F24")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x1BB1658", Offset = "0x1BB1658", VA = "0x1BB1658")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x1BB8B64", Offset = "0x1BB8B64", VA = "0x1BB8B64")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E84EC", Offset = "0x7E84EC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E84EC", Offset = "0x7E84EC")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D6")]
		public class CharacterPosition
		{
			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF014", Offset = "0x7EF014")]
			public bool use;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF04C", Offset = "0x7EF04C")]
			public Vector2 offset;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF084", Offset = "0x7EF084")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EF084", Offset = "0x7EF084")]
			public float angleOffset;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EF0E0", Offset = "0x7EF0E0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF0E0", Offset = "0x7EF0E0")]
			public float maxAngle;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF138", Offset = "0x7EF138")]
			public float radius;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF170", Offset = "0x7EF170")]
			public bool orbit;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF1A8", Offset = "0x7EF1A8")]
			public bool fixYAxis;

			[Token(Token = "0x170000AA")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60007BE")]
				[Address(RVA = "0x1FFFF40", Offset = "0x1FFFF40", VA = "0x1FFFF40")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AB")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60007BF")]
				[Address(RVA = "0x1FFFF4C", Offset = "0x1FFFF4C", VA = "0x1FFFF4C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x1FFFFD4", Offset = "0x1FFFFD4", VA = "0x1FFFFD4")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x2000418", Offset = "0x2000418", VA = "0x2000418")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D7")]
		public class CameraPosition
		{
			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF1E0", Offset = "0x7EF1E0")]
			public Collider lookAtTarget;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF218", Offset = "0x7EF218")]
			public Vector3 direction;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF250", Offset = "0x7EF250")]
			public float maxDistance;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EF288", Offset = "0x7EF288")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF288", Offset = "0x7EF288")]
			public float maxAngle;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF2E0", Offset = "0x7EF2E0")]
			public bool fixYAxis;

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x1FFFBD8", Offset = "0x1FFFBD8", VA = "0x1FFFBD8")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x1FFFCCC", Offset = "0x1FFFCCC", VA = "0x1FFFCCC")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x1FFFEF4", Offset = "0x1FFFEF4", VA = "0x1FFFEF4")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D8")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000D9")]
			public class Interaction
			{
				[Token(Token = "0x40006BC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF3E0", Offset = "0x7EF3E0")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40006BD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF418", Offset = "0x7EF418")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60007C7")]
				[Address(RVA = "0x2006DD4", Offset = "0x2006DD4", VA = "0x2006DD4")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF338", Offset = "0x7EF338")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF370", Offset = "0x7EF370")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF3A8", Offset = "0x7EF3A8")]
			public Interaction[] interactions;

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x200042C", Offset = "0x200042C", VA = "0x200042C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x20004E0", Offset = "0x20004E0", VA = "0x20004E0")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EEFDC", Offset = "0x7EEFDC")]
		public Range[] ranges;

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x1BB8BB0", Offset = "0x1BB8BB0", VA = "0x1BB8BB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5DC8", Offset = "0x7F5DC8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1BB8BF8", Offset = "0x1BB8BF8", VA = "0x1BB8BF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5E00", Offset = "0x7F5E00")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x1BB8C40", Offset = "0x1BB8C40", VA = "0x1BB8C40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5E38", Offset = "0x7F5E38")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1BB8C88", Offset = "0x1BB8C88", VA = "0x1BB8C88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5E70", Offset = "0x7F5E70")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x1BB8CD0", Offset = "0x1BB8CD0", VA = "0x1BB8CD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5EA8", Offset = "0x7F5EA8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x1BB73A8", Offset = "0x1BB73A8", VA = "0x1BB73A8")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1BB8D18", Offset = "0x1BB8D18", VA = "0x1BB8D18")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000DB")]
		public class Map
		{
			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x1BE46C4", Offset = "0x1BE46C4", VA = "0x1BE46C4")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x1BE471C", Offset = "0x1BE471C", VA = "0x1BE471C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x1BE476C", Offset = "0x1BE476C", VA = "0x1BE476C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x1BE47B8", Offset = "0x1BE47B8", VA = "0x1BE47B8")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x19D080C", Offset = "0x19D080C", VA = "0x19D080C", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5EE0", Offset = "0x7F5EE0")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x19D0B9C", Offset = "0x19D0B9C", VA = "0x19D0B9C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x19D0BA0", Offset = "0x19D0BA0", VA = "0x19D0BA0", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x19D0CA8", Offset = "0x19D0CA8", VA = "0x19D0CA8", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x19D0B30", Offset = "0x19D0B30", VA = "0x19D0B30")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x19D0A90", Offset = "0x19D0A90", VA = "0x19D0A90")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x19D0D14", Offset = "0x19D0D14", VA = "0x19D0D14")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x19DE628", Offset = "0x19DE628", VA = "0x19DE628", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x19DE704", Offset = "0x19DE704", VA = "0x19DE704", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x19DE8EC", Offset = "0x19DE8EC", VA = "0x19DE8EC", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x19DE9E8", Offset = "0x19DE9E8", VA = "0x19DE9E8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x19DE768", Offset = "0x19DE768", VA = "0x19DE768")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x19DED48", Offset = "0x19DED48", VA = "0x19DED48")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EF450", Offset = "0x7EF450")]
		public float weight;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EF468", Offset = "0x7EF468")]
		public float localRotationWeight;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EF480", Offset = "0x7EF480")]
		public float localPositionWeight;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60007D9")]
		public abstract void AutoMapping();

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x1AEB714", Offset = "0x1AEB714", VA = "0x1AEB714")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x60007DB")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60007DC")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60007DD")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x1AEB720", Offset = "0x1AEB720", VA = "0x1AEB720", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x1AEB774", Offset = "0x1AEB774", VA = "0x1AEB774", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1AEB7B0", Offset = "0x1AEB7B0", VA = "0x1AEB7B0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x1AEB7C8", Offset = "0x1AEB7C8", VA = "0x1AEB7C8")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000DF")]
		public class Rigidbone
		{
			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x20024F4", Offset = "0x20024F4", VA = "0x20024F4")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x20026B8", Offset = "0x20026B8", VA = "0x20026B8")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x2002798", Offset = "0x2002798", VA = "0x2002798")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000E0")]
		public class Child
		{
			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x20022EC", Offset = "0x20022EC", VA = "0x20022EC")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x2002364", Offset = "0x2002364", VA = "0x2002364")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x20024A4", Offset = "0x20024A4", VA = "0x20024A4")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E854C", Offset = "0x7E854C")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000AE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007FD")]
				[Address(RVA = "0x200229C", Offset = "0x200229C", VA = "0x200229C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007FF")]
				[Address(RVA = "0x20022E4", Offset = "0x20022E4", VA = "0x20022E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x2002060", Offset = "0x2002060", VA = "0x2002060")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x200208C", Offset = "0x200208C", VA = "0x200208C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x2002090", Offset = "0x2002090", VA = "0x2002090", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x20022A4", Offset = "0x20022A4", VA = "0x20022A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF498", Offset = "0x7EF498")]
		public IK ik;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF4D0", Offset = "0x7EF4D0")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF508", Offset = "0x7EF508")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF540", Offset = "0x7EF540")]
		public float applyVelocity;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF578", Offset = "0x7EF578")]
		public float applyAngularVelocity;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x170000AC")]
		private bool isRagdoll
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x1AEC850", Offset = "0x1AEC850", VA = "0x1AEC850")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AD")]
		private bool ikUsed
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x1AED284", Offset = "0x1AED284", VA = "0x1AED284")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x1AEC818", Offset = "0x1AEC818", VA = "0x1AEC818")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1AEC8C8", Offset = "0x1AEC8C8", VA = "0x1AEC8C8")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x1AECA04", Offset = "0x1AECA04", VA = "0x1AECA04")]
		public void Start()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x1AEC98C", Offset = "0x1AEC98C", VA = "0x1AEC98C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F5F18", Offset = "0x7F5F18")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x1AECEC0", Offset = "0x1AECEC0", VA = "0x1AECEC0")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1AED10C", Offset = "0x1AED10C", VA = "0x1AED10C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1AED1C8", Offset = "0x1AED1C8", VA = "0x1AED1C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1AED404", Offset = "0x1AED404", VA = "0x1AED404")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x1AED248", Offset = "0x1AED248", VA = "0x1AED248")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1AED3C0", Offset = "0x1AED3C0", VA = "0x1AED3C0")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1AED4A4", Offset = "0x1AED4A4", VA = "0x1AED4A4")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x1AED438", Offset = "0x1AED438", VA = "0x1AED438")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x1AEC920", Offset = "0x1AEC920", VA = "0x1AEC920")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x1AED14C", Offset = "0x1AED14C", VA = "0x1AED14C")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x1AED6D0", Offset = "0x1AED6D0", VA = "0x1AED6D0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1AED80C", Offset = "0x1AED80C", VA = "0x1AED80C")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EF5C0", Offset = "0x7EF5C0")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x170000B0")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x1AEF50C", Offset = "0x1AEF50C", VA = "0x1AEF50C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B1")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x1AEF518", Offset = "0x1AEF518", VA = "0x1AEF518")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B2")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x1AEF534", Offset = "0x1AEF534", VA = "0x1AEF534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5FC8", Offset = "0x7F5FC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000808")]
			[Address(RVA = "0x1AEF53C", Offset = "0x1AEF53C", VA = "0x1AEF53C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F5FD8", Offset = "0x7F5FD8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x1AEF20C", Offset = "0x1AEF20C", VA = "0x1AEF20C")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x1AEF254", Offset = "0x1AEF254", VA = "0x1AEF254")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x1AEF26C", Offset = "0x1AEF26C", VA = "0x1AEF26C")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x1AEF464", Offset = "0x1AEF464", VA = "0x1AEF464")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x1AEF4D4", Offset = "0x1AEF4D4", VA = "0x1AEF4D4")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000809")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x1AEF38C", Offset = "0x1AEF38C", VA = "0x1AEF38C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1AEF548", Offset = "0x1AEF548", VA = "0x1AEF548")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1AEF54C", Offset = "0x1AEF54C", VA = "0x1AEF54C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x1AEF580", Offset = "0x1AEF580", VA = "0x1AEF580")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1AEF5FC", Offset = "0x1AEF5FC", VA = "0x1AEF5FC")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x1AEF790", Offset = "0x1AEF790", VA = "0x1AEF790")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x1AEF800", Offset = "0x1AEF800", VA = "0x1AEF800")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E855C", Offset = "0x7E855C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E855C", Offset = "0x7E855C")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EF5D0", Offset = "0x7EF5D0")]
		public float limit;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EF5EC", Offset = "0x7EF5EC")]
		public float twistLimit;

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x1AEF834", Offset = "0x1AEF834", VA = "0x1AEF834")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F5FE8", Offset = "0x7F5FE8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x1AEF87C", Offset = "0x1AEF87C", VA = "0x1AEF87C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F6020", Offset = "0x7F6020")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1AEF8C4", Offset = "0x1AEF8C4", VA = "0x1AEF8C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F6058", Offset = "0x7F6058")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1AEF90C", Offset = "0x1AEF90C", VA = "0x1AEF90C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F6090", Offset = "0x7F6090")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1AEF954", Offset = "0x1AEF954", VA = "0x1AEF954", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x1AEF998", Offset = "0x1AEF998", VA = "0x1AEF998")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x1AEFB58", Offset = "0x1AEFB58", VA = "0x1AEFB58")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E85BC", Offset = "0x7E85BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E85BC", Offset = "0x7E85BC")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1AEFB98", Offset = "0x1AEFB98", VA = "0x1AEFB98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F60C8", Offset = "0x7F60C8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1AEFBE0", Offset = "0x1AEFBE0", VA = "0x1AEFBE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F6100", Offset = "0x7F6100")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x1AEFC28", Offset = "0x1AEFC28", VA = "0x1AEFC28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F6138", Offset = "0x7F6138")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x1AEFC70", Offset = "0x1AEFC70", VA = "0x1AEFC70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F6170", Offset = "0x7F6170")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x1AEFCB8", Offset = "0x1AEFCB8", VA = "0x1AEFCB8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1AEFCBC", Offset = "0x1AEFCBC", VA = "0x1AEFCBC")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1AEFE40", Offset = "0x1AEFE40", VA = "0x1AEFE40")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E861C", Offset = "0x7E861C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E861C", Offset = "0x7E861C")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000E6")]
		public class ReachCone
		{
			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000B3")]
			public Vector3 o
			{
				[Token(Token = "0x600082F")]
				[Address(RVA = "0x2002DE4", Offset = "0x2002DE4", VA = "0x2002DE4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B4")]
			public Vector3 a
			{
				[Token(Token = "0x6000830")]
				[Address(RVA = "0x2002E1C", Offset = "0x2002E1C", VA = "0x2002E1C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B5")]
			public Vector3 b
			{
				[Token(Token = "0x6000831")]
				[Address(RVA = "0x2002E58", Offset = "0x2002E58", VA = "0x2002E58")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B6")]
			public Vector3 c
			{
				[Token(Token = "0x6000832")]
				[Address(RVA = "0x2002E94", Offset = "0x2002E94", VA = "0x2002E94")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B7")]
			public bool isValid
			{
				[Token(Token = "0x6000834")]
				[Address(RVA = "0x2003020", Offset = "0x2003020", VA = "0x2003020")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000833")]
			[Address(RVA = "0x2002ED0", Offset = "0x2002ED0", VA = "0x2002ED0")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000835")]
			[Address(RVA = "0x2003030", Offset = "0x2003030", VA = "0x2003030")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E7")]
		public class LimitPoint
		{
			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000836")]
			[Address(RVA = "0x2002DA8", Offset = "0x2002DA8", VA = "0x2002DA8")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EF618", Offset = "0x7EF618")]
		public float twistLimit;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EF634", Offset = "0x7EF634")]
		public int smoothIterations;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x1AEFE88", Offset = "0x1AEFE88", VA = "0x1AEFE88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F61A8", Offset = "0x7F61A8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x1AEFED0", Offset = "0x1AEFED0", VA = "0x1AEFED0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F61E0", Offset = "0x7F61E0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x1AEFF18", Offset = "0x1AEFF18", VA = "0x1AEFF18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F6218", Offset = "0x7F6218")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x1AEFF60", Offset = "0x1AEFF60", VA = "0x1AEFF60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F6250", Offset = "0x7F6250")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x1AEFFA8", Offset = "0x1AEFFA8", VA = "0x1AEFFA8")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x1AF04A4", Offset = "0x1AF04A4", VA = "0x1AF04A4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x1AF0538", Offset = "0x1AF0538", VA = "0x1AF0538")]
		private void Start()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x1AF0AAC", Offset = "0x1AF0AAC", VA = "0x1AF0AAC")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x1AF0050", Offset = "0x1AF0050", VA = "0x1AF0050")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x1AF0E58", Offset = "0x1AF0E58", VA = "0x1AF0E58")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x1AF1264", Offset = "0x1AF1264", VA = "0x1AF1264")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x1AF12A8", Offset = "0x1AF12A8", VA = "0x1AF12A8")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x1AF1308", Offset = "0x1AF1308", VA = "0x1AF1308")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x1AF083C", Offset = "0x1AF083C", VA = "0x1AF083C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x1AF1374", Offset = "0x1AF1374", VA = "0x1AF1374")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x1AF1450", Offset = "0x1AF1450", VA = "0x1AF1450")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7E867C", Offset = "0x7E867C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x7E867C", Offset = "0x7E867C")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EF67C", Offset = "0x7EF67C")]
		public float twistLimit;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x1AF14D0", Offset = "0x1AF14D0", VA = "0x1AF14D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F6288", Offset = "0x7F6288")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x1AF1518", Offset = "0x1AF1518", VA = "0x1AF1518")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F62C0", Offset = "0x7F62C0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x1AF1560", Offset = "0x1AF1560", VA = "0x1AF1560")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F62F8", Offset = "0x7F62F8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x1AF15A8", Offset = "0x1AF15A8", VA = "0x1AF15A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7F6330", Offset = "0x7F6330")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x1AF15F0", Offset = "0x1AF15F0", VA = "0x1AF15F0")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x1AF160C", Offset = "0x1AF160C", VA = "0x1AF160C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x1AF1650", Offset = "0x1AF1650", VA = "0x1AF1650")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x1AF1874", Offset = "0x1AF1874", VA = "0x1AF1874")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E86DC", Offset = "0x7E86DC")]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000849")]
				[Address(RVA = "0x1BE335C", Offset = "0x1BE335C", VA = "0x1BE335C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600084B")]
				[Address(RVA = "0x1BE33A4", Offset = "0x1BE33A4", VA = "0x1BE33A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000846")]
			[Address(RVA = "0x1BE3260", Offset = "0x1BE3260", VA = "0x1BE3260")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x6000847")]
			[Address(RVA = "0x1BE328C", Offset = "0x1BE328C", VA = "0x1BE328C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000848")]
			[Address(RVA = "0x1BE3290", Offset = "0x1BE3290", VA = "0x1BE3290", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600084A")]
			[Address(RVA = "0x1BE3364", Offset = "0x1BE3364", VA = "0x1BE3364", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF6A8", Offset = "0x7EF6A8")]
		public AimIK ik;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF6E0", Offset = "0x7EF6E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EF6E0", Offset = "0x7EF6E0")]
		public float weight;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF734", Offset = "0x7EF734")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EF734", Offset = "0x7EF734")]
		public Transform target;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF794", Offset = "0x7EF794")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF7CC", Offset = "0x7EF7CC")]
		public float weightSmoothTime;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF804", Offset = "0x7EF804")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EF804", Offset = "0x7EF804")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF864", Offset = "0x7EF864")]
		public float maxRadiansDelta;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF89C", Offset = "0x7EF89C")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF8D4", Offset = "0x7EF8D4")]
		public float slerpSpeed;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF90C", Offset = "0x7EF90C")]
		public float smoothDampTime;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF944", Offset = "0x7EF944")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF97C", Offset = "0x7EF97C")]
		public float minDistance;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF9B4", Offset = "0x7EF9B4")]
		public Vector3 offset;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EF9EC", Offset = "0x7EF9EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EF9EC", Offset = "0x7EF9EC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EF9EC", Offset = "0x7EF9EC")]
		public float maxRootAngle;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFA68", Offset = "0x7EFA68")]
		public bool turnToTarget;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFAA0", Offset = "0x7EFAA0")]
		public float turnToTargetTime;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFAD8", Offset = "0x7EFAD8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7EFAD8", Offset = "0x7EFAD8")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFB38", Offset = "0x7EFB38")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x170000B8")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x1C50C34", Offset = "0x1C50C34", VA = "0x1C50C34")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x1C50BA8", Offset = "0x1C50BA8", VA = "0x1C50BA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x1C50CC4", Offset = "0x1C50CC4", VA = "0x1C50CC4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x1C513A8", Offset = "0x1C513A8", VA = "0x1C513A8")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x1C51494", Offset = "0x1C51494", VA = "0x1C51494")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x1C516E4", Offset = "0x1C516E4", VA = "0x1C516E4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F6368", Offset = "0x7F6368")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x1C5175C", Offset = "0x1C5175C", VA = "0x1C5175C")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EC")]
		public class Pose
		{
			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x600084F")]
			[Address(RVA = "0x1BE33AC", Offset = "0x1BE33AC", VA = "0x1BE33AC")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000850")]
			[Address(RVA = "0x1BE3538", Offset = "0x1BE3538", VA = "0x1BE3538")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0x1BE3540", Offset = "0x1BE3540", VA = "0x1BE3540")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x1C519CC", Offset = "0x1C519CC", VA = "0x1C519CC")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x1C51AAC", Offset = "0x1C51AAC", VA = "0x1C51AAC")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x1C51B18", Offset = "0x1C51B18", VA = "0x1C51B18")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000EE")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000EF")]
			public class EffectorLink
			{
				[Token(Token = "0x400073C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFCF8", Offset = "0x7EFCF8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400073D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFD30", Offset = "0x7EFD30")]
				public float weight;

				[Token(Token = "0x6000857")]
				[Address(RVA = "0x20069B8", Offset = "0x20069B8", VA = "0x20069B8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFBA8", Offset = "0x7EFBA8")]
			public Transform transform;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFBE0", Offset = "0x7EFBE0")]
			public Transform relativeTo;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFC18", Offset = "0x7EFC18")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFC50", Offset = "0x7EFC50")]
			public float verticalWeight;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFC88", Offset = "0x7EFC88")]
			public float horizontalWeight;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFCC0", Offset = "0x7EFCC0")]
			public float speed;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000854")]
			[Address(RVA = "0x1BE355C", Offset = "0x1BE355C", VA = "0x1BE355C")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x1BE3888", Offset = "0x1BE3888", VA = "0x1BE3888")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000856")]
			[Address(RVA = "0x1BE3898", Offset = "0x1BE3898", VA = "0x1BE3898")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFB70", Offset = "0x7EFB70")]
		public Body[] bodies;

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x1C51C34", Offset = "0x1C51C34", VA = "0x1C51C34", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x1C51D80", Offset = "0x1C51D80", VA = "0x1C51D80")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFD68", Offset = "0x7EFD68")]
		public float tiltSpeed;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFDA0", Offset = "0x7EFDA0")]
		public float tiltSensitivity;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFDD8", Offset = "0x7EFDD8")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFE10", Offset = "0x7EFE10")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x1C61DD4", Offset = "0x1C61DD4", VA = "0x1C61DD4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x1C61E1C", Offset = "0x1C61E1C", VA = "0x1C61E1C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x1C61FD4", Offset = "0x1C61FD4", VA = "0x1C61FD4")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7EFE48", Offset = "0x7EFE48")]
		public float weight;

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x1C61FE8", Offset = "0x1C61FE8", VA = "0x1C61FE8")]
		private void Start()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x1C620C0", Offset = "0x1C620C0", VA = "0x1C620C0")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x1C622E8", Offset = "0x1C622E8", VA = "0x1C622E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x1C62418", Offset = "0x1C62418", VA = "0x1C62418")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFE60", Offset = "0x7EFE60")]
		public Animator animator;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFE98", Offset = "0x7EFE98")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7EFEE0", Offset = "0x7EFEE0")]
		private IK <ik>k__BackingField;

		[Token(Token = "0x170000BB")]
		public IK ik
		{
			[Token(Token = "0x600085F")]
			[Address(RVA = "0x1C9733C", Offset = "0x1C9733C", VA = "0x1C9733C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6418", Offset = "0x7F6418")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x1C97344", Offset = "0x1C97344", VA = "0x1C97344")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6428", Offset = "0x7F6428")]
			private set
			{
			}
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x1C9734C", Offset = "0x1C9734C", VA = "0x1C9734C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x1C97508", Offset = "0x1C97508", VA = "0x1C97508")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x1C97794", Offset = "0x1C97794", VA = "0x1C97794")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x1C978EC", Offset = "0x1C978EC", VA = "0x1C978EC")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x1C97ADC", Offset = "0x1C97ADC", VA = "0x1C97ADC")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x1C97D14", Offset = "0x1C97D14", VA = "0x1C97D14")]
		public void Update()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x1C97FC0", Offset = "0x1C97FC0", VA = "0x1C97FC0")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x7E86FC", Offset = "0x7E86FC")]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x170000BC")]
		public bool poseStored
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x1C97600", Offset = "0x1C97600", VA = "0x1C97600")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x1C9796C", Offset = "0x1C9796C", VA = "0x1C9796C")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x1C97624", Offset = "0x1C97624", VA = "0x1C97624")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x1C98028", Offset = "0x1C98028", VA = "0x1C98028")]
		public EditorIKPose()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F5")]
		public abstract class HitPoint
		{
			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFF60", Offset = "0x7EFF60")]
			public string name;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFF98", Offset = "0x7EFF98")]
			public Collider collider;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFFD0", Offset = "0x7EFFD0")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F001C", Offset = "0x7F001C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F002C", Offset = "0x7F002C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F003C", Offset = "0x7F003C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float length;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float lastTime;

			[Token(Token = "0x170000BE")]
			public bool inProgress
			{
				[Token(Token = "0x6000870")]
				[Address(RVA = "0x1BE73E8", Offset = "0x1BE73E8", VA = "0x1BE73E8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BF")]
			protected float crossFader
			{
				[Token(Token = "0x6000871")]
				[Address(RVA = "0x1BE73FC", Offset = "0x1BE73FC", VA = "0x1BE73FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6438", Offset = "0x7F6438")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000872")]
				[Address(RVA = "0x1BE7404", Offset = "0x1BE7404", VA = "0x1BE7404")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6448", Offset = "0x7F6448")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			protected float timer
			{
				[Token(Token = "0x6000873")]
				[Address(RVA = "0x1BE740C", Offset = "0x1BE740C", VA = "0x1BE740C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6458", Offset = "0x7F6458")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000874")]
				[Address(RVA = "0x1BE7414", Offset = "0x1BE7414", VA = "0x1BE7414")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6468", Offset = "0x7F6468")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			protected Vector3 force
			{
				[Token(Token = "0x6000875")]
				[Address(RVA = "0x1BE741C", Offset = "0x1BE741C", VA = "0x1BE741C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6478", Offset = "0x7F6478")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000876")]
				[Address(RVA = "0x1BE7428", Offset = "0x1BE7428", VA = "0x1BE7428")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6488", Offset = "0x7F6488")]
				private set
				{
				}
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x1BE7434", Offset = "0x1BE7434", VA = "0x1BE7434", Slot = "4")]
			public virtual void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000878")]
			[Address(RVA = "0x1BE754C", Offset = "0x1BE754C", VA = "0x1BE754C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000879")]
			protected abstract float GetLength();

			[Token(Token = "0x600087A")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600087B")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x600087C")]
			[Address(RVA = "0x1BE7620", Offset = "0x1BE7620", VA = "0x1BE7620")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F6")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000F7")]
			public class EffectorLink
			{
				[Token(Token = "0x400075A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F00F4", Offset = "0x7F00F4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400075B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F012C", Offset = "0x7F012C")]
				public float weight;

				[Token(Token = "0x400075C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400075D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000881")]
				[Address(RVA = "0x2006B28", Offset = "0x2006B28", VA = "0x2006B28")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000882")]
				[Address(RVA = "0x2006BD8", Offset = "0x2006BD8", VA = "0x2006BD8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000883")]
				[Address(RVA = "0x2006BEC", Offset = "0x2006BEC", VA = "0x2006BEC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F004C", Offset = "0x7F004C")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0084", Offset = "0x7F0084")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F00BC", Offset = "0x7F00BC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600087D")]
			[Address(RVA = "0x1BE79BC", Offset = "0x1BE79BC", VA = "0x1BE79BC", Slot = "5")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600087E")]
			[Address(RVA = "0x1BE7AEC", Offset = "0x1BE7AEC", VA = "0x1BE7AEC", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x1BE7B58", Offset = "0x1BE7B58", VA = "0x1BE7B58", Slot = "7")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0x1BE7CC0", Offset = "0x1BE7CC0", VA = "0x1BE7CC0")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F8")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000F9")]
			public class BoneLink
			{
				[Token(Token = "0x4000762")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F01D4", Offset = "0x7F01D4")]
				public Transform bone;

				[Token(Token = "0x4000763")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F020C", Offset = "0x7F020C")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F020C", Offset = "0x7F020C")]
				public float weight;

				[Token(Token = "0x4000764")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000765")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000889")]
				[Address(RVA = "0x20069C0", Offset = "0x20069C0", VA = "0x20069C0")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600088A")]
				[Address(RVA = "0x2006AD8", Offset = "0x2006AD8", VA = "0x2006AD8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600088B")]
				[Address(RVA = "0x2006AE4", Offset = "0x2006AE4", VA = "0x2006AE4")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0164", Offset = "0x7F0164")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F019C", Offset = "0x7F019C")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Rigidbody rigidbody;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 comAxis;

			[Token(Token = "0x6000884")]
			[Address(RVA = "0x1BE7634", Offset = "0x1BE7634", VA = "0x1BE7634", Slot = "4")]
			public override void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0x1BE77B8", Offset = "0x1BE77B8", VA = "0x1BE77B8", Slot = "5")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000886")]
			[Address(RVA = "0x1BE785C", Offset = "0x1BE785C", VA = "0x1BE785C", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000887")]
			[Address(RVA = "0x1BE78C8", Offset = "0x1BE78C8", VA = "0x1BE78C8", Slot = "7")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000888")]
			[Address(RVA = "0x1BE79A8", Offset = "0x1BE79A8", VA = "0x1BE79A8")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFEF0", Offset = "0x7EFEF0")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7EFF28", Offset = "0x7EFF28")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000BD")]
		public bool inProgress
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x19DFBF0", Offset = "0x19DFBF0", VA = "0x19DFBF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x19DFCC0", Offset = "0x19DFCC0", VA = "0x19DFCC0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x19DFD9C", Offset = "0x19DFD9C", VA = "0x19DFD9C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x19E0000", Offset = "0x19E0000", VA = "0x19E0000")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000FB")]
		public abstract class Offset
		{
			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F02D0", Offset = "0x7F02D0")]
			public string name;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0308", Offset = "0x7F0308")]
			public Collider collider;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0340", Offset = "0x7F0340")]
			private float crossFadeTime;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F038C", Offset = "0x7F038C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F039C", Offset = "0x7F039C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F03AC", Offset = "0x7F03AC")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float length;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float lastTime;

			[Token(Token = "0x170000C2")]
			protected float crossFader
			{
				[Token(Token = "0x600088F")]
				[Address(RVA = "0x1BE7CD4", Offset = "0x1BE7CD4", VA = "0x1BE7CD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6498", Offset = "0x7F6498")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000890")]
				[Address(RVA = "0x1BE7CDC", Offset = "0x1BE7CDC", VA = "0x1BE7CDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F64A8", Offset = "0x7F64A8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C3")]
			protected float timer
			{
				[Token(Token = "0x6000891")]
				[Address(RVA = "0x1BE7CE4", Offset = "0x1BE7CE4", VA = "0x1BE7CE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F64B8", Offset = "0x7F64B8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000892")]
				[Address(RVA = "0x1BE7CEC", Offset = "0x1BE7CEC", VA = "0x1BE7CEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F64C8", Offset = "0x7F64C8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C4")]
			protected Vector3 force
			{
				[Token(Token = "0x6000893")]
				[Address(RVA = "0x1BE7CF4", Offset = "0x1BE7CF4", VA = "0x1BE7CF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F64D8", Offset = "0x7F64D8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000894")]
				[Address(RVA = "0x1BE7D00", Offset = "0x1BE7D00", VA = "0x1BE7D00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F64E8", Offset = "0x7F64E8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000895")]
			[Address(RVA = "0x1BE7D0C", Offset = "0x1BE7D0C", VA = "0x1BE7D0C", Slot = "4")]
			public virtual void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x1BE7E38", Offset = "0x1BE7E38", VA = "0x1BE7E38")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000897")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000898")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000899")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x1BE7F20", Offset = "0x1BE7F20", VA = "0x1BE7F20")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FC")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000FD")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000775")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0464", Offset = "0x7F0464")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000776")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F049C", Offset = "0x7F049C")]
				public float weight;

				[Token(Token = "0x4000777")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000778")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600089F")]
				[Address(RVA = "0x2006BF4", Offset = "0x2006BF4", VA = "0x2006BF4")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60008A0")]
				[Address(RVA = "0x2006C84", Offset = "0x2006C84", VA = "0x2006C84")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60008A1")]
				[Address(RVA = "0x2006C98", Offset = "0x2006C98", VA = "0x2006C98")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F03BC", Offset = "0x7F03BC")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F03F4", Offset = "0x7F03F4")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F042C", Offset = "0x7F042C")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600089B")]
			[Address(RVA = "0x1BE7F34", Offset = "0x1BE7F34", VA = "0x1BE7F34", Slot = "5")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600089C")]
			[Address(RVA = "0x1BE80E4", Offset = "0x1BE80E4", VA = "0x1BE80E4", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0x1BE8150", Offset = "0x1BE8150", VA = "0x1BE8150", Slot = "7")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0x1BE82F0", Offset = "0x1BE82F0", VA = "0x1BE82F0")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FE")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000FF")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x400077D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0544", Offset = "0x7F0544")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x400077E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F057C", Offset = "0x7F057C")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F057C", Offset = "0x7F057C")]
				public float weight;

				[Token(Token = "0x400077F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000780")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x60008A7")]
				[Address(RVA = "0x2006CA0", Offset = "0x2006CA0", VA = "0x2006CA0")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60008A8")]
				[Address(RVA = "0x2006D7C", Offset = "0x2006D7C", VA = "0x2006D7C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60008A9")]
				[Address(RVA = "0x2006D88", Offset = "0x2006D88", VA = "0x2006D88")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F04D4", Offset = "0x7F04D4")]
			public int curveIndex;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F050C", Offset = "0x7F050C")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Rigidbody rigidbody;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Vector3 comAxis;

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x1BE830C", Offset = "0x1BE830C", VA = "0x1BE830C", Slot = "4")]
			public override void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x1BE8498", Offset = "0x1BE8498", VA = "0x1BE8498", Slot = "5")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x1BE857C", Offset = "0x1BE857C", VA = "0x1BE857C", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x1BE85E8", Offset = "0x1BE85E8", VA = "0x1BE85E8", Slot = "7")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x1BE8840", Offset = "0x1BE8840", VA = "0x1BE8840")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0260", Offset = "0x7F0260")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0298", Offset = "0x7F0298")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x19E0360", Offset = "0x19E0360", VA = "0x19E0360", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x19E0434", Offset = "0x19E0434", VA = "0x19E0434")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x19E06A0", Offset = "0x19E06A0", VA = "0x19E06A0")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000101")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000102")]
			public class EffectorLink
			{
				[Token(Token = "0x400078E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F07AC", Offset = "0x7F07AC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400078F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F07E4", Offset = "0x7F07E4")]
				public float weight;

				[Token(Token = "0x60008B0")]
				[Address(RVA = "0x2006DCC", Offset = "0x2006DCC", VA = "0x2006DCC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0640", Offset = "0x7F0640")]
			public Transform transform;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0678", Offset = "0x7F0678")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F06B0", Offset = "0x7F06B0")]
			public float speed;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F06E8", Offset = "0x7F06E8")]
			public float acceleration;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0720", Offset = "0x7F0720")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0720", Offset = "0x7F0720")]
			public float matchVelocity;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0774", Offset = "0x7F0774")]
			public float gravity;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x1FFECEC", Offset = "0x1FFECEC", VA = "0x1FFECEC")]
			public void Reset()
			{
			}

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x1FFEDA4", Offset = "0x1FFEDA4", VA = "0x1FFEDA4")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x1FFF060", Offset = "0x1FFF060", VA = "0x1FFF060")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F05D0", Offset = "0x7F05D0")]
		public Body[] bodies;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0608", Offset = "0x7F0608")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x1BAF950", Offset = "0x1BAF950", VA = "0x1BAF950")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x1BAF9CC", Offset = "0x1BAF9CC", VA = "0x1BAF9CC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x1BAFA8C", Offset = "0x1BAFA8C", VA = "0x1BAFA8C")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F081C", Offset = "0x7F081C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F081C", Offset = "0x7F081C")]
		public Transform target;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F087C", Offset = "0x7F087C")]
		public float weight;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0894", Offset = "0x7F0894")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F08CC", Offset = "0x7F08CC")]
		public float weightSmoothTime;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0904", Offset = "0x7F0904")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F0904", Offset = "0x7F0904")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0964", Offset = "0x7F0964")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F099C", Offset = "0x7F099C")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F09D4", Offset = "0x7F09D4")]
		public float slerpSpeed;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0A0C", Offset = "0x7F0A0C")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0A44", Offset = "0x7F0A44")]
		public float minDistance;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F0A7C", Offset = "0x7F0A7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0A7C", Offset = "0x7F0A7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0A7C", Offset = "0x7F0A7C")]
		public float maxRootAngle;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000C5")]
		private Vector3 pivot
		{
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x1AE3D8C", Offset = "0x1AE3D8C", VA = "0x1AE3D8C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x1AE3D18", Offset = "0x1AE3D18", VA = "0x1AE3D18")]
		private void Start()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x1AE3E1C", Offset = "0x1AE3E1C", VA = "0x1AE3E1C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x1AE4360", Offset = "0x1AE4360", VA = "0x1AE4360")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x1AE444C", Offset = "0x1AE444C", VA = "0x1AE444C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x1AE4644", Offset = "0x1AE4644", VA = "0x1AE4644")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000105")]
		public class OffsetLimits
		{
			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0B68", Offset = "0x7F0B68")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0BA0", Offset = "0x7F0BA0")]
			public float spring;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0BD8", Offset = "0x7F0BD8")]
			public bool x;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0C10", Offset = "0x7F0C10")]
			public bool y;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0C48", Offset = "0x7F0C48")]
			public bool z;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0C80", Offset = "0x7F0C80")]
			public float minX;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0CB8", Offset = "0x7F0CB8")]
			public float maxX;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0CF0", Offset = "0x7F0CF0")]
			public float minY;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0D28", Offset = "0x7F0D28")]
			public float maxY;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0D60", Offset = "0x7F0D60")]
			public float minZ;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0D98", Offset = "0x7F0D98")]
			public float maxZ;

			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x2001460", Offset = "0x2001460", VA = "0x2001460")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x20015B8", Offset = "0x20015B8", VA = "0x20015B8")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x2001630", Offset = "0x2001630", VA = "0x2001630")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x2001688", Offset = "0x2001688", VA = "0x2001688")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E8768", Offset = "0x7E8768")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000C7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008C6")]
				[Address(RVA = "0x2001410", Offset = "0x2001410", VA = "0x2001410", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008C8")]
				[Address(RVA = "0x2001458", Offset = "0x2001458", VA = "0x2001458", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x2001270", Offset = "0x2001270", VA = "0x2001270")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x200129C", Offset = "0x200129C", VA = "0x200129C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x20012A0", Offset = "0x20012A0", VA = "0x20012A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x2001418", Offset = "0x2001418", VA = "0x2001418", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0AF8", Offset = "0x7F0AF8")]
		public float weight;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0B30", Offset = "0x7F0B30")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000C6")]
		protected float deltaTime
		{
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x1AE8DEC", Offset = "0x1AE8DEC", VA = "0x1AE8DEC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60008B8")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x1AE65CC", Offset = "0x1AE65CC", VA = "0x1AE65CC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x1AE8E18", Offset = "0x1AE8E18", VA = "0x1AE8E18")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F64F8", Offset = "0x7F64F8")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x1AE8E90", Offset = "0x1AE8E90", VA = "0x1AE8E90")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x1AE8F6C", Offset = "0x1AE8F6C", VA = "0x1AE8F6C")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x1AE6960", Offset = "0x1AE6960", VA = "0x1AE6960", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x1AE6AA4", Offset = "0x1AE6AA4", VA = "0x1AE6AA4")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E8778", Offset = "0x7E8778")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000CA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008D3")]
				[Address(RVA = "0x2001830", Offset = "0x2001830", VA = "0x2001830", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008D5")]
				[Address(RVA = "0x2001878", Offset = "0x2001878", VA = "0x2001878", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x2001690", Offset = "0x2001690", VA = "0x2001690")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x20016BC", Offset = "0x20016BC", VA = "0x20016BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x20016C0", Offset = "0x20016C0", VA = "0x20016C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x2001838", Offset = "0x2001838", VA = "0x2001838", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0DD0", Offset = "0x7F0DD0")]
		public float weight;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0E08", Offset = "0x7F0E08")]
		public VRIK ik;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000C9")]
		protected float deltaTime
		{
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x1AE902C", Offset = "0x1AE902C", VA = "0x1AE902C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60008CA")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x1AE9058", Offset = "0x1AE9058", VA = "0x1AE9058", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x1AE9084", Offset = "0x1AE9084", VA = "0x1AE9084")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F65A8", Offset = "0x7F65A8")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x1AE90FC", Offset = "0x1AE90FC", VA = "0x1AE90FC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x1AE91D8", Offset = "0x1AE91D8", VA = "0x1AE91D8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x1AE9308", Offset = "0x1AE9308", VA = "0x1AE9308")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010A")]
		public class EffectorLink
		{
			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x2001880", Offset = "0x2001880", VA = "0x2001880")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x2001A9C", Offset = "0x2001A9C", VA = "0x2001A9C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x1AE9318", Offset = "0x1AE9318", VA = "0x1AE9318")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x1AE93DC", Offset = "0x1AE93DC", VA = "0x1AE93DC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x1AE9498", Offset = "0x1AE9498", VA = "0x1AE9498")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010C")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x200010D")]
			public class EffectorLink
			{
				[Token(Token = "0x40007CB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F101C", Offset = "0x7F101C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40007CC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1054", Offset = "0x7F1054")]
				public float weight;

				[Token(Token = "0x60008E1")]
				[Address(RVA = "0x2006DDC", Offset = "0x2006DDC", VA = "0x2006DDC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0E78", Offset = "0x7F0E78")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0EB0", Offset = "0x7F0EB0")]
			public Transform raycastTo;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0EE8", Offset = "0x7F0EE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F0EE8", Offset = "0x7F0EE8")]
			public float raycastRadius;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0F3C", Offset = "0x7F0F3C")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0F74", Offset = "0x7F0F74")]
			public float smoothTimeIn;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0FAC", Offset = "0x7F0FAC")]
			public float smoothTimeOut;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0FE4", Offset = "0x7F0FE4")]
			public LayerMask layers;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x2001AA4", Offset = "0x2001AA4", VA = "0x2001AA4")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x2001BE8", Offset = "0x2001BE8", VA = "0x2001BE8")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x2001CE0", Offset = "0x2001CE0", VA = "0x2001CE0")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x2001EB0", Offset = "0x2001EB0", VA = "0x2001EB0")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F0E40", Offset = "0x7F0E40")]
		public Avoider[] avoiders;

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x1AE9E60", Offset = "0x1AE9E60", VA = "0x1AE9E60", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x1AE9EE8", Offset = "0x1AE9EE8", VA = "0x1AE9EE8")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010F")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x2000110")]
			public class EffectorLink
			{
				[Token(Token = "0x40007EB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1418", Offset = "0x7F1418")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40007EC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1450", Offset = "0x7F1450")]
				public float weight;

				[Token(Token = "0x60008F1")]
				[Address(RVA = "0x2006DE4", Offset = "0x2006DE4", VA = "0x2006DE4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F131C", Offset = "0x7F131C")]
			public Vector3 offset;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1354", Offset = "0x7F1354")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1354", Offset = "0x7F1354")]
			public float additivity;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F13A8", Offset = "0x7F13A8")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F13E0", Offset = "0x7F13E0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x200293C", Offset = "0x200293C", VA = "0x200293C")]
			public void Start()
			{
			}

			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x200298C", Offset = "0x200298C", VA = "0x200298C")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x2002B50", Offset = "0x2002B50", VA = "0x2002B50")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000111")]
		public enum Handedness
		{
			[Token(Token = "0x40007EE")]
			Right,
			[Token(Token = "0x40007EF")]
			Left
		}

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F108C", Offset = "0x7F108C")]
		public AimIK aimIK;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F10C4", Offset = "0x7F10C4")]
		public AimIK headIK;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F10FC", Offset = "0x7F10FC")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1134", Offset = "0x7F1134")]
		public Handedness handedness;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F116C", Offset = "0x7F116C")]
		public bool twoHanded;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F11A4", Offset = "0x7F11A4")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F11DC", Offset = "0x7F11DC")]
		public float magnitudeRandom;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1214", Offset = "0x7F1214")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F124C", Offset = "0x7F124C")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1284", Offset = "0x7F1284")]
		public float blendTime;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7F12BC", Offset = "0x7F12BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F12BC", Offset = "0x7F12BC")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float magnitudeMlp;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float endTime;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion handRotation;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion randomRotation;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float length;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool initiated;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float blendWeight;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float w;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool handRotationsSet;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000CC")]
		public bool isFinished
		{
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x1AEDB7C", Offset = "0x1AEDB7C", VA = "0x1AEDB7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CD")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x1AEE65C", Offset = "0x1AEE65C", VA = "0x1AEE65C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CE")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x1AEE69C", Offset = "0x1AEE69C", VA = "0x1AEE69C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CF")]
		private Transform primaryHand
		{
			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x1AEE61C", Offset = "0x1AEE61C", VA = "0x1AEE61C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D0")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x1AEE63C", Offset = "0x1AEE63C", VA = "0x1AEE63C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x1AEDBAC", Offset = "0x1AEDBAC", VA = "0x1AEDBAC")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x1AEDBD8", Offset = "0x1AEDBD8", VA = "0x1AEDBD8")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x1AEDD20", Offset = "0x1AEDD20", VA = "0x1AEDD20", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x1AEE6DC", Offset = "0x1AEE6DC", VA = "0x1AEE6DC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x1AEE808", Offset = "0x1AEE808", VA = "0x1AEE808")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x1AEE8D0", Offset = "0x1AEE8D0", VA = "0x1AEE8D0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x1AEEABC", Offset = "0x1AEEABC", VA = "0x1AEEABC")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1488", Offset = "0x7F1488")]
		public float weight;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F14C0", Offset = "0x7F14C0")]
		public float offset;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x1AF2948", Offset = "0x1AF2948", VA = "0x1AF2948")]
		private void Start()
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x1AF2A50", Offset = "0x1AF2A50", VA = "0x1AF2A50")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x1AF2B38", Offset = "0x1AF2B38", VA = "0x1AF2B38")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x1AF2E8C", Offset = "0x1AF2E8C", VA = "0x1AF2E8C")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x1AF2EC4", Offset = "0x1AF2EC4", VA = "0x1AF2EC4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x1AF2FF4", Offset = "0x1AF2FF4", VA = "0x1AF2FF4")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x2000114")]
		public class Settings
		{
			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F14F8", Offset = "0x7F14F8")]
			public float scaleMlp;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1530", Offset = "0x7F1530")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1568", Offset = "0x7F1568")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F15A0", Offset = "0x7F15A0")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F15D8", Offset = "0x7F15D8")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1610", Offset = "0x7F1610")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1648", Offset = "0x7F1648")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7F1680", Offset = "0x7F1680")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1680", Offset = "0x7F1680")]
			public Vector3 headOffset;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F16D0", Offset = "0x7F16D0")]
			public Vector3 handOffset;

			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1708", Offset = "0x7F1708")]
			public float footForwardOffset;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1740", Offset = "0x7F1740")]
			public float footInwardOffset;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1778", Offset = "0x7F1778")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1778", Offset = "0x7F1778")]
			public float footHeadingOffset;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F17D4", Offset = "0x7F17D4")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F17EC", Offset = "0x7F17EC")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000907")]
			[Address(RVA = "0x2005870", Offset = "0x2005870", VA = "0x2005870")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000115")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x2000116")]
			public class Target
			{
				[Token(Token = "0x400080E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x400080F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000810")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000909")]
				[Address(RVA = "0x2006DEC", Offset = "0x2006DEC", VA = "0x2006DEC")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x600090A")]
				[Address(RVA = "0x2006EAC", Offset = "0x2006EAC", VA = "0x2006EAC")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000908")]
			[Address(RVA = "0x2005868", Offset = "0x2005868", VA = "0x2005868")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0xEDE2B8", Offset = "0xEDE2B8", VA = "0xEDE2B8")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0xEDCDE8", Offset = "0xEDCDE8", VA = "0xEDCDE8")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0xEDE42C", Offset = "0xEDE42C", VA = "0xEDE42C")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xEDE340", Offset = "0xEDE340", VA = "0xEDE340")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xEDD02C", Offset = "0xEDD02C", VA = "0xEDD02C")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xEDE444", Offset = "0xEDE444", VA = "0xEDE444")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xEDC2E0", Offset = "0xEDC2E0", VA = "0xEDC2E0")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xEDEC88", Offset = "0xEDEC88", VA = "0xEDEC88")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xEDC0A8", Offset = "0xEDC0A8", VA = "0xEDC0A8")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xEDF0F8", Offset = "0xEDF0F8", VA = "0xEDF0F8")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0xEDF788", Offset = "0xEDF788", VA = "0xEDF788")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xEDF554", Offset = "0xEDF554", VA = "0xEDF554")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xEDFA04", Offset = "0xEDFA04", VA = "0xEDFA04")]
		private static void CalibrateHand(VRIK ik, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0xEDFD54", Offset = "0xEDFD54", VA = "0xEDFD54")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0xEDFE44", Offset = "0xEDFE44", VA = "0xEDFE44")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000117")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x600090B")]
		[Address(RVA = "0xEE0160", Offset = "0xEE0160", VA = "0xEE0160")]
		private void Start()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xEE01BC", Offset = "0xEE01BC", VA = "0xEE01BC")]
		private void Update()
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xEE01F0", Offset = "0xEE01F0", VA = "0xEE01F0")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xEE032C", Offset = "0xEE032C", VA = "0xEE032C")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F1804", Offset = "0x7F1804")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000D1")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x600090F")]
			[Address(RVA = "0xEE0A34", Offset = "0xEE0A34", VA = "0xEE0A34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6658", Offset = "0x7F6658")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000910")]
			[Address(RVA = "0xEE0A40", Offset = "0xEE0A40", VA = "0xEE0A40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6668", Offset = "0x7F6668")]
			private set
			{
			}
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xEE0A4C", Offset = "0xEE0A4C", VA = "0xEE0A4C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xEDEA58", Offset = "0xEDEA58", VA = "0xEDEA58")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xEDEF3C", Offset = "0xEDEF3C", VA = "0xEDEF3C")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xEE0B5C", Offset = "0xEE0B5C", VA = "0xEE0B5C")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xEE0F78", Offset = "0xEE0F78", VA = "0xEE0F78")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xEE10A8", Offset = "0xEE10A8", VA = "0xEE10A8")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000119")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011A")]
		public class Offset
		{
			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x600091B")]
			[Address(RVA = "0x1BE4548", Offset = "0x1BE4548", VA = "0x1BE4548")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x600091C")]
			[Address(RVA = "0x1BE46BC", Offset = "0x1BE46BC", VA = "0x1BE46BC")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x1C9F508", Offset = "0x1C9F508", VA = "0x1C9F508")]
		private void Start()
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x1C9F564", Offset = "0x1C9F564", VA = "0x1C9F564")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x1C9F5E0", Offset = "0x1C9F5E0", VA = "0x1C9F5E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x1C9F6C4", Offset = "0x1C9F6C4", VA = "0x1C9F6C4")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x1C50B1C", Offset = "0x1C50B1C", VA = "0x1C50B1C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x1C50BA0", Offset = "0x1C50BA0", VA = "0x1C50BA0")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1824", Offset = "0x7F1824")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x1C51B88", Offset = "0x1C51B88", VA = "0x1C51B88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x1C51C00", Offset = "0x1C51C00", VA = "0x1C51C00")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GrounderFBBIK grounder;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x1AF25B8", Offset = "0x1AF25B8", VA = "0x1AF25B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x1AF267C", Offset = "0x1AF267C", VA = "0x1AF267C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x1AF28A8", Offset = "0x1AF28A8", VA = "0x1AF28A8")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F185C", Offset = "0x7F185C")]
		public AimPoser aimPoser;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1894", Offset = "0x7F1894")]
		public AimIK aim;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F18CC", Offset = "0x7F18CC")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1904", Offset = "0x7F1904")]
		public Animator animator;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F193C", Offset = "0x7F193C")]
		public float crossfadeTime;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1974", Offset = "0x7F1974")]
		public float minAimDistance;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x1AF32CC", Offset = "0x1AF32CC", VA = "0x1AF32CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x1AF3310", Offset = "0x1AF3310", VA = "0x1AF3310")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x1AF33C8", Offset = "0x1AF33C8", VA = "0x1AF33C8")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x1AF3550", Offset = "0x1AF3550", VA = "0x1AF3550")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x1AF367C", Offset = "0x1AF367C", VA = "0x1AF367C")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x1AF36F8", Offset = "0x1AF36F8", VA = "0x1AF36F8")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xED7650", Offset = "0xED7650", VA = "0xED7650")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xED77C0", Offset = "0xED77C0", VA = "0xED77C0")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xED7954", Offset = "0xED7954", VA = "0xED7954")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7F19AC", Offset = "0x7F19AC")]
		public Animator animator;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7F19E4", Offset = "0x7F19E4")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1A1C", Offset = "0x7F1A1C")]
		public float lookAtWeight;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1A34", Offset = "0x7F1A34")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1A4C", Offset = "0x7F1A4C")]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1A64", Offset = "0x7F1A64")]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1A7C", Offset = "0x7F1A7C")]
		public float lookAtClampWeight;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1A94", Offset = "0x7F1A94")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1AAC", Offset = "0x7F1AAC")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7F1AC4", Offset = "0x7F1AC4")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1AFC", Offset = "0x7F1AFC")]
		public float footPositionWeight;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1B14", Offset = "0x7F1B14")]
		public float footRotationWeight;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7F1B2C", Offset = "0x7F1B2C")]
		public Transform handTargetBiped;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1B64", Offset = "0x7F1B64")]
		public float handPositionWeight;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1B7C", Offset = "0x7F1B7C")]
		public float handRotationWeight;

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x1C59D88", Offset = "0x1C59D88", VA = "0x1C59D88")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x1C5A190", Offset = "0x1C5A190", VA = "0x1C5A190")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F1B94", Offset = "0x7F1B94")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sine;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit rootHit;

		[Token(Token = "0x170000D2")]
		public Vector3 velocity
		{
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x1AE484C", Offset = "0x1AE484C", VA = "0x1AE484C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6678", Offset = "0x7F6678")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x1AE4858", Offset = "0x1AE4858", VA = "0x1AE4858")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6688", Offset = "0x7F6688")]
			private set
			{
			}
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x1AE4864", Offset = "0x1AE4864", VA = "0x1AE4864")]
		private void Start()
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x1AE48A0", Offset = "0x1AE48A0", VA = "0x1AE48A0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x1AE5114", Offset = "0x1AE5114", VA = "0x1AE5114")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x1AE4EC4", Offset = "0x1AE4EC4", VA = "0x1AE4EC4")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x1AE5210", Offset = "0x1AE5210", VA = "0x1AE5210")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000D3")]
		public Vector3 inputVector
		{
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x1AE523C", Offset = "0x1AE523C", VA = "0x1AE523C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x1AE52C0", Offset = "0x1AE52C0", VA = "0x1AE52C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x1AE54E4", Offset = "0x1AE54E4", VA = "0x1AE54E4")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x2000124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E8788", Offset = "0x7E8788")]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000D6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000947")]
				[Address(RVA = "0x2000FA4", Offset = "0x2000FA4", VA = "0x2000FA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000949")]
				[Address(RVA = "0x2000FEC", Offset = "0x2000FEC", VA = "0x2000FEC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000944")]
			[Address(RVA = "0x2000CA8", Offset = "0x2000CA8", VA = "0x2000CA8")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000945")]
			[Address(RVA = "0x2000CD4", Offset = "0x2000CD4", VA = "0x2000CD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000946")]
			[Address(RVA = "0x2000CD8", Offset = "0x2000CD8", VA = "0x2000CD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000948")]
			[Address(RVA = "0x2000FAC", Offset = "0x2000FAC", VA = "0x2000FAC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000D4")]
		public bool isStepping
		{
			[Token(Token = "0x6000939")]
			[Address(RVA = "0x1AE54F8", Offset = "0x1AE54F8", VA = "0x1AE54F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D5")]
		public Vector3 position
		{
			[Token(Token = "0x600093A")]
			[Address(RVA = "0x1AE51DC", Offset = "0x1AE51DC", VA = "0x1AE51DC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x1AE550C", Offset = "0x1AE550C", VA = "0x1AE550C")]
			set
			{
			}
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x1AE555C", Offset = "0x1AE555C", VA = "0x1AE555C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x1AE5788", Offset = "0x1AE5788", VA = "0x1AE5788")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x1AE5924", Offset = "0x1AE5924", VA = "0x1AE5924")]
		private void Start()
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x1AE5B58", Offset = "0x1AE5B58", VA = "0x1AE5B58")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x1AE5DCC", Offset = "0x1AE5DCC", VA = "0x1AE5DCC")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x1AE5F44", Offset = "0x1AE5F44", VA = "0x1AE5F44")]
		private void Update()
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x1AE5AA4", Offset = "0x1AE5AA4", VA = "0x1AE5AA4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F6698", Offset = "0x7F6698")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x1AE6140", Offset = "0x1AE6140", VA = "0x1AE6140")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x1AE61A4", Offset = "0x1AE61A4", VA = "0x1AE61A4")]
		private void Start()
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x1AE6274", Offset = "0x1AE6274", VA = "0x1AE6274")]
		private void Update()
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x1AE64C8", Offset = "0x1AE64C8", VA = "0x1AE64C8")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000127")]
		public struct Warp
		{
			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1C64", Offset = "0x7F1C64")]
			public int animationLayer;

			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1C9C", Offset = "0x7F1C9C")]
			public string animationState;

			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1CD4", Offset = "0x7F1CD4")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1D0C", Offset = "0x7F1D0C")]
			public Transform warpFrom;

			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1D44", Offset = "0x7F1D44")]
			public Transform warpTo;

			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1D7C", Offset = "0x7F1D7C")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x2000128")]
		public enum EffectorMode
		{
			[Token(Token = "0x400088E")]
			PositionOffset,
			[Token(Token = "0x400088F")]
			Position
		}

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1BA4", Offset = "0x7F1BA4")]
		public Animator animator;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1BDC", Offset = "0x7F1BDC")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7F1C14", Offset = "0x7F1C14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1C14", Offset = "0x7F1C14")]
		public Warp[] warps;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x1C51D88", Offset = "0x1C51D88", VA = "0x1C51D88", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x1C51DB4", Offset = "0x1C51DB4", VA = "0x1C51DB4")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x1C51FF4", Offset = "0x1C51FF4", VA = "0x1C51FF4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x1C522B8", Offset = "0x1C522B8", VA = "0x1C522B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x1C52358", Offset = "0x1C52358", VA = "0x1C52358")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x1C52360", Offset = "0x1C52360", VA = "0x1C52360", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x1C523BC", Offset = "0x1C523BC", VA = "0x1C523BC")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x1C52558", Offset = "0x1C52558", VA = "0x1C52558", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x1C52760", Offset = "0x1C52760", VA = "0x1C52760")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1DB4", Offset = "0x7F1DB4")]
		public float headLookWeight;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x1C52774", Offset = "0x1C52774", VA = "0x1C52774", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x1C52940", Offset = "0x1C52940", VA = "0x1C52940", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x1C529BC", Offset = "0x1C529BC", VA = "0x1C529BC")]
		private void Read()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x1C52AB0", Offset = "0x1C52AB0", VA = "0x1C52AB0")]
		private void AimIK()
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x1C52AF8", Offset = "0x1C52AF8", VA = "0x1C52AF8")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x1C52EE4", Offset = "0x1C52EE4", VA = "0x1C52EE4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x1C52D6C", Offset = "0x1C52D6C", VA = "0x1C52D6C")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x1C53140", Offset = "0x1C53140", VA = "0x1C53140")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x1C53270", Offset = "0x1C53270", VA = "0x1C53270")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x1C64040", Offset = "0x1C64040", VA = "0x1C64040", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x1C640A4", Offset = "0x1C640A4", VA = "0x1C640A4", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x1C642E0", Offset = "0x1C642E0", VA = "0x1C642E0")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x1C643D4", Offset = "0x1C643D4", VA = "0x1C643D4")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000D8")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x1C64E30", Offset = "0x1C64E30", VA = "0x1C64E30")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D9")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000966")]
			[Address(RVA = "0x1C64EB4", Offset = "0x1C64EB4", VA = "0x1C64EB4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x1C64C30", Offset = "0x1C64C30", VA = "0x1C64C30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x1C64CA4", Offset = "0x1C64CA4", VA = "0x1C64CA4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x1C64F38", Offset = "0x1C64F38", VA = "0x1C64F38")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1DCC", Offset = "0x7F1DCC")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x1C980C0", Offset = "0x1C980C0", VA = "0x1C980C0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x1C98520", Offset = "0x1C98520", VA = "0x1C98520")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x1C9881C", Offset = "0x1C9881C", VA = "0x1C9881C")]
		private void Start()
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x1C988D8", Offset = "0x1C988D8", VA = "0x1C988D8")]
		private void Update()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x1C98C5C", Offset = "0x1C98C5C", VA = "0x1C98C5C")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x1C98D08", Offset = "0x1C98D08", VA = "0x1C98D08")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000130")]
		public class Limb
		{
			[Token(Token = "0x40008C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40008C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40008C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000972")]
			[Address(RVA = "0x1BE4014", Offset = "0x1BE4014", VA = "0x1BE4014")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000973")]
			[Address(RVA = "0x1BE4098", Offset = "0x1BE4098", VA = "0x1BE4098")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x1C9C79C", Offset = "0x1C9C79C", VA = "0x1C9C79C")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x1C9C8F4", Offset = "0x1C9C8F4", VA = "0x1C9C8F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x1C9C998", Offset = "0x1C9C998", VA = "0x1C9C998")]
		private void Update()
		{
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x1C9C99C", Offset = "0x1C9C99C", VA = "0x1C9C99C")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x1C9C9AC", Offset = "0x1C9C9AC", VA = "0x1C9C9AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x1C9CA20", Offset = "0x1C9CA20", VA = "0x1C9CA20")]
		private void Update()
		{
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x1C9CB00", Offset = "0x1C9CB00", VA = "0x1C9CB00")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1DE4", Offset = "0x7F1DE4")]
		public Transform target;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1E1C", Offset = "0x7F1E1C")]
		public Transform pin;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1E54", Offset = "0x7F1E54")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1E8C", Offset = "0x7F1E8C")]
		public AimIK aim;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1EC4", Offset = "0x7F1EC4")]
		public float weight;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1EFC", Offset = "0x7F1EFC")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1F34", Offset = "0x7F1F34")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x1C9CB08", Offset = "0x1C9CB08", VA = "0x1C9CB08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x1C9CB64", Offset = "0x1C9CB64", VA = "0x1C9CB64")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x1C9CD08", Offset = "0x1C9CD08", VA = "0x1C9CD08")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x1C9EE90", Offset = "0x1C9EE90", VA = "0x1C9EE90")]
		private void Awake()
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x1C9EF68", Offset = "0x1C9EF68", VA = "0x1C9EF68")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x1C9EFF8", Offset = "0x1C9EFF8", VA = "0x1C9EFF8")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x1C9F3D0", Offset = "0x1C9F3D0", VA = "0x1C9F3D0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x1C9F500", Offset = "0x1C9F500", VA = "0x1C9F500")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1F6C", Offset = "0x7F1F6C")]
		public float aimWeight;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1F84", Offset = "0x7F1F84")]
		public float sightWeight;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1F9C", Offset = "0x7F1F9C")]
		public float maxAngle;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AimIK headAim;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CameraControllerFPS cam;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Recoil recoil;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1FB8", Offset = "0x7F1FB8")]
		public float cameraRecoilWeight;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool updateFrame;

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x1C9F6CC", Offset = "0x1C9F6CC", VA = "0x1C9F6CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x1C9F890", Offset = "0x1C9F890", VA = "0x1C9F890")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x1C9F89C", Offset = "0x1C9F89C", VA = "0x1C9F89C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x1C9FB1C", Offset = "0x1C9FB1C", VA = "0x1C9FB1C")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x1C9FDF0", Offset = "0x1C9FDF0", VA = "0x1C9FDF0")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x1C9F964", Offset = "0x1C9F964", VA = "0x1C9F964")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x1CA06E4", Offset = "0x1CA06E4", VA = "0x1CA06E4")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F1FD0", Offset = "0x7F1FD0")]
		public float walkSpeed;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x1CA0704", Offset = "0x1CA0704", VA = "0x1CA0704")]
		private void Start()
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x1CA0790", Offset = "0x1CA0790", VA = "0x1CA0790")]
		private void Update()
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x1CA087C", Offset = "0x1CA087C", VA = "0x1CA087C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x1CA0934", Offset = "0x1CA0934", VA = "0x1CA0934")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x19E0008", Offset = "0x19E0008", VA = "0x19E0008")]
		private void Update()
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x19E016C", Offset = "0x19E016C", VA = "0x19E016C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x19E0350", Offset = "0x19E0350", VA = "0x19E0350")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x19E0A00", Offset = "0x19E0A00", VA = "0x19E0A00")]
		private void Start()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x19E0B48", Offset = "0x19E0B48", VA = "0x19E0B48")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x19E0E84", Offset = "0x19E0E84", VA = "0x19E0E84")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x1BAFBB0", Offset = "0x1BAFBB0", VA = "0x1BAFBB0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x1BAFDFC", Offset = "0x1BAFDFC", VA = "0x1BAFDFC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x1BAFF08", Offset = "0x1BAFF08", VA = "0x1BAFF08")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x1BAFF10", Offset = "0x1BAFF10", VA = "0x1BAFF10")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x1BB0724", Offset = "0x1BB0724", VA = "0x1BB0724")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F1FE8", Offset = "0x7F1FE8")]
		public InteractionObject interactionObject;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2020", Offset = "0x7F2020")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x1BB8588", Offset = "0x1BB8588", VA = "0x1BB8588")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x1BB85E4", Offset = "0x1BB85E4", VA = "0x1BB85E4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x1BB891C", Offset = "0x1BB891C", VA = "0x1BB891C")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200013C")]
		public class Partner
		{
			[Token(Token = "0x4000908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x400090A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x400090B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x400090C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x400090F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000910")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000DA")]
			private Transform neck
			{
				[Token(Token = "0x600099D")]
				[Address(RVA = "0x2000C3C", Offset = "0x2000C3C", VA = "0x2000C3C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600099B")]
			[Address(RVA = "0x20004F0", Offset = "0x20004F0", VA = "0x20004F0")]
			public void Initiate()
			{
			}

			[Token(Token = "0x600099C")]
			[Address(RVA = "0x2000510", Offset = "0x2000510", VA = "0x2000510")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x600099E")]
			[Address(RVA = "0x2000AA8", Offset = "0x2000AA8", VA = "0x2000AA8")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x600099F")]
			[Address(RVA = "0x2000C94", Offset = "0x2000C94", VA = "0x2000C94")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x1BB9890", Offset = "0x1BB9890", VA = "0x1BB9890")]
		private void Start()
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x1BB98CC", Offset = "0x1BB98CC", VA = "0x1BB98CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x1BB9934", Offset = "0x1BB9934", VA = "0x1BB9934")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200013E")]
		public enum Mode
		{
			[Token(Token = "0x400091B")]
			Position,
			[Token(Token = "0x400091C")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x200013F")]
		public class Absorber
		{
			[Token(Token = "0x400091D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2138", Offset = "0x7F2138")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2170", Offset = "0x7F2170")]
			public float weight;

			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x2000FF4", Offset = "0x2000FF4", VA = "0x2000FF4")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x20010DC", Offset = "0x20010DC", VA = "0x20010DC")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x2001118", Offset = "0x2001118", VA = "0x2001118")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x20011B0", Offset = "0x20011B0", VA = "0x20011B0")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x2001224", Offset = "0x2001224", VA = "0x2001224")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2058", Offset = "0x7F2058")]
		public Mode mode;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2090", Offset = "0x7F2090")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F20C8", Offset = "0x7F20C8")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2100", Offset = "0x7F2100")]
		public float falloffSpeed;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x1AE64D0", Offset = "0x1AE64D0", VA = "0x1AE64D0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x1AE65F8", Offset = "0x1AE65F8", VA = "0x1AE65F8")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x1AE6688", Offset = "0x1AE6688", VA = "0x1AE6688", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x1AE679C", Offset = "0x1AE679C", VA = "0x1AE679C")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x1AE6828", Offset = "0x1AE6828", VA = "0x1AE6828", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x1AE6A90", Offset = "0x1AE6A90", VA = "0x1AE6A90")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x1AE6AB4", Offset = "0x1AE6AB4", VA = "0x1AE6AB4")]
		private void Start()
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x1AE6B30", Offset = "0x1AE6B30", VA = "0x1AE6B30")]
		private void Update()
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x1AE6C0C", Offset = "0x1AE6C0C", VA = "0x1AE6C0C")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x1AE6CCC", Offset = "0x1AE6CCC", VA = "0x1AE6CCC")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000142")]
		public class EffectorLink
		{
			[Token(Token = "0x400092E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400092F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x4000930")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x2001260", Offset = "0x2001260", VA = "0x2001260")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F21A8", Offset = "0x7F21A8")]
		public Transform anchor;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 posRelToAnchor;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion rotRelToAnchor;

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x1AE8904", Offset = "0x1AE8904", VA = "0x1AE8904", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x1AE8B24", Offset = "0x1AE8B24", VA = "0x1AE8B24", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x1AE8CB0", Offset = "0x1AE8CB0", VA = "0x1AE8CB0")]
		public void Anchor()
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x1AE8DB0", Offset = "0x1AE8DB0", VA = "0x1AE8DB0")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F21F0", Offset = "0x7F21F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F21F0", Offset = "0x7F21F0")]
		public float weight;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2244", Offset = "0x7F2244")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F227C", Offset = "0x7F227C")]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F22C8", Offset = "0x7F22C8")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x1AE9508", Offset = "0x1AE9508", VA = "0x1AE9508")]
		private void Start()
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x1AE97D8", Offset = "0x1AE97D8", VA = "0x1AE97D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x1AE9E20", Offset = "0x1AE9E20", VA = "0x1AE9E20")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000DB")]
		private bool holding
		{
			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x1AEA410", Offset = "0x1AEA410", VA = "0x1AEA410")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DC")]
		private bool holdingLeft
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x1AEA4FC", Offset = "0x1AEA4FC", VA = "0x1AEA4FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DD")]
		private bool holdingRight
		{
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x1AEA448", Offset = "0x1AEA448", VA = "0x1AEA448")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x1AE9EF8", Offset = "0x1AE9EF8", VA = "0x1AE9EF8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60009B8")]
		protected abstract void RotatePivot();

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x1AEA5B0", Offset = "0x1AEA5B0", VA = "0x1AEA5B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x1AEA768", Offset = "0x1AEA768", VA = "0x1AEA768")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x1AEA8EC", Offset = "0x1AEA8EC", VA = "0x1AEA8EC")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x1AEA9C8", Offset = "0x1AEA9C8", VA = "0x1AEA9C8")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x1AEAB08", Offset = "0x1AEAB08", VA = "0x1AEAB08")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x1AEAC78", Offset = "0x1AEAC78", VA = "0x1AEAC78")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x1AEAE88", Offset = "0x1AEAE88", VA = "0x1AEAE88")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x1AEAE9C", Offset = "0x1AEAE9C", VA = "0x1AEAE9C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x1AEB100", Offset = "0x1AEB100", VA = "0x1AEB100")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000146")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x1AEB114", Offset = "0x1AEB114", VA = "0x1AEB114", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x1AEB248", Offset = "0x1AEB248", VA = "0x1AEB248")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000147")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x1AED934", Offset = "0x1AED934", VA = "0x1AED934")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x1AEDA14", Offset = "0x1AEDA14", VA = "0x1AEDA14")]
		private void Update()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x1AEDB28", Offset = "0x1AEDB28", VA = "0x1AEDB28")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000148")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x1AEEB2C", Offset = "0x1AEEB2C", VA = "0x1AEEB2C")]
		private void Start()
		{
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x1AEEB88", Offset = "0x1AEEB88", VA = "0x1AEEB88")]
		private void Update()
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x1AEEBE0", Offset = "0x1AEEBE0", VA = "0x1AEEBE0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x1AEECC0", Offset = "0x1AEECC0", VA = "0x1AEECC0")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000149")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x200014A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E8798", Offset = "0x7E8798")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009D5")]
				[Address(RVA = "0x2002D58", Offset = "0x2002D58", VA = "0x2002D58", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009D7")]
				[Address(RVA = "0x2002DA0", Offset = "0x2002DA0", VA = "0x2002DA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x2002B64", Offset = "0x2002B64", VA = "0x2002B64")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x2002B90", Offset = "0x2002B90", VA = "0x2002B90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x2002B94", Offset = "0x2002B94", VA = "0x2002B94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x2002D60", Offset = "0x2002D60", VA = "0x2002D60", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x1AEECD0", Offset = "0x1AEECD0", VA = "0x1AEECD0")]
		private void Start()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x1AEED98", Offset = "0x1AEED98", VA = "0x1AEED98")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x1AEEDFC", Offset = "0x1AEEDFC", VA = "0x1AEEDFC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F6748", Offset = "0x7F6748")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x1AEEE84", Offset = "0x1AEEE84", VA = "0x1AEEE84")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x200014B")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x200014C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E87A8", Offset = "0x7E87A8")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000E0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009DE")]
				[Address(RVA = "0x20032F0", Offset = "0x20032F0", VA = "0x20032F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009E0")]
				[Address(RVA = "0x2003338", Offset = "0x2003338", VA = "0x2003338", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x2003180", Offset = "0x2003180", VA = "0x2003180")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x20031AC", Offset = "0x20031AC", VA = "0x20031AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x20031B0", Offset = "0x20031B0", VA = "0x20031B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x20032F8", Offset = "0x20032F8", VA = "0x20032F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x1AF3F00", Offset = "0x1AF3F00", VA = "0x1AF3F00")]
		private void Start()
		{
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x1AF3FB8", Offset = "0x1AF3FB8", VA = "0x1AF3FB8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F67F8", Offset = "0x7F67F8")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x1AF4030", Offset = "0x1AF4030", VA = "0x1AF4030")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x200014D")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014E")]
		public class EffectorLink
		{
			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float distanceMlp;

			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public LayerMask touchLayers;

			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float lerpSpeed;

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float minSwitchTime;

			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float releaseDistance;

			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool sliding;

			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float raycastDistance;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool inTouch;

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RaycastHit hit;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private bool initiated;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float nextSwitchTime;

			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float speedF;

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x2003340", Offset = "0x2003340", VA = "0x2003340")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x200364C", Offset = "0x200364C", VA = "0x200364C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x2003738", Offset = "0x2003738", VA = "0x2003738")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x2003BCC", Offset = "0x2003BCC", VA = "0x2003BCC")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x2003CC0", Offset = "0x2003CC0", VA = "0x2003CC0")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x2003D58", Offset = "0x2003D58", VA = "0x2003D58")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x2003DEC", Offset = "0x2003DEC", VA = "0x2003DEC")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x2003E80", Offset = "0x2003E80", VA = "0x2003E80")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x2004070", Offset = "0x2004070", VA = "0x2004070")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0xED7BE4", Offset = "0xED7BE4", VA = "0xED7BE4")]
		private void Start()
		{
		}

		[Token(Token = "0x60009E2")]
		[Address(RVA = "0xED7C60", Offset = "0xED7C60", VA = "0xED7C60")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60009E3")]
		[Address(RVA = "0xED7CD0", Offset = "0xED7CD0", VA = "0xED7CD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xED7D98", Offset = "0xED7D98", VA = "0xED7D98")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200014F")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2314", Offset = "0x7F2314")]
		public Transform to;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F234C", Offset = "0x7F234C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F234C", Offset = "0x7F234C")]
		public float transferMotion;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0xED80D0", Offset = "0xED80D0", VA = "0xED80D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0xED810C", Offset = "0xED810C", VA = "0xED810C")]
		private void Update()
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0xED81C0", Offset = "0xED81C0", VA = "0xED81C0")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000150")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F23A0", Offset = "0x7F23A0")]
		public float weight;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F23B8", Offset = "0x7F23B8")]
		public Transform leftHandTarget;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F23F0", Offset = "0x7F23F0")]
		public Poser leftHandPoser;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F2428", Offset = "0x7F2428")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2428", Offset = "0x7F2428")]
		public float leftHandWeight;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0xED9784", Offset = "0xED9784", VA = "0xED9784")]
		private void Start()
		{
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0xED9954", Offset = "0xED9954", VA = "0xED9954")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0xED9BA0", Offset = "0xED9BA0", VA = "0xED9BA0")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0xED9D44", Offset = "0xED9D44", VA = "0xED9D44")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0xED9E74", Offset = "0xED9E74", VA = "0xED9E74")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x2000151")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0xEDA124", Offset = "0xEDA124", VA = "0xEDA124", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0xEDA4B0", Offset = "0xEDA4B0", VA = "0xEDA4B0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0xEDA71C", Offset = "0xEDA71C", VA = "0xEDA71C")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000152")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x19D964C", Offset = "0x19D964C", VA = "0x19D964C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x19D9974", Offset = "0x19D9974", VA = "0x19D9974")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x19D99F4", Offset = "0x19D99F4", VA = "0x19D99F4")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E87B8", Offset = "0x7E87B8")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000E2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A05")]
				[Address(RVA = "0x2002010", Offset = "0x2002010", VA = "0x2002010", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A07")]
				[Address(RVA = "0x2002058", Offset = "0x2002058", VA = "0x2002058", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x2001EC4", Offset = "0x2001EC4", VA = "0x2001EC4")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x2001EF0", Offset = "0x2001EF0", VA = "0x2001EF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x2001EF4", Offset = "0x2001EF4", VA = "0x2001EF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x2002018", Offset = "0x2002018", VA = "0x2002018", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x1AEB25C", Offset = "0x1AEB25C", VA = "0x1AEB25C")]
		private void Start()
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x1AEB3A0", Offset = "0x1AEB3A0", VA = "0x1AEB3A0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x1AEB328", Offset = "0x1AEB328", VA = "0x1AEB328")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F68A8", Offset = "0x7F68A8")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x1AEB524", Offset = "0x1AEB524", VA = "0x1AEB524")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x1AEB610", Offset = "0x1AEB610", VA = "0x1AEB610")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x1AEB6F8", Offset = "0x1AEB6F8", VA = "0x1AEB6F8")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000155")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F247C", Offset = "0x7F247C")]
		public float weight;

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x1C589E8", Offset = "0x1C589E8", VA = "0x1C589E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x1C58A5C", Offset = "0x1C58A5C", VA = "0x1C58A5C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x1C58B14", Offset = "0x1C58B14", VA = "0x1C58B14")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x2000156")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000157")]
		public class Part
		{
			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x20040AC", Offset = "0x20040AC", VA = "0x20040AC")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x20041EC", Offset = "0x20041EC", VA = "0x20041EC")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0xED85B4", Offset = "0xED85B4", VA = "0xED85B4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0xED8630", Offset = "0xED8630", VA = "0xED8630")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x19E06A8", Offset = "0x19E06A8", VA = "0x19E06A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x19E080C", Offset = "0x19E080C", VA = "0x19E080C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x19E09F0", Offset = "0x19E09F0", VA = "0x19E09F0")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000159")]
	public class VRController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200015A")]
		public enum InputMode
		{
			[Token(Token = "0x40009A8")]
			Input,
			[Token(Token = "0x40009A9")]
			WASDOnly
		}

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputMode inputMode;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRIK ik;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float walkSpeed;

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float runSpeed;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float walkForwardSpeedMlp;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float runForwardSpeedMlp;

		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 smoothInput;

		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 smoothInputV;

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0xEDB7D8", Offset = "0xEDB7D8", VA = "0xEDB7D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0xEDB968", Offset = "0xEDB968", VA = "0xEDB968")]
		private Vector3 GetInput()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xEDBB28", Offset = "0xEDBB28", VA = "0xEDBB28")]
		public VRController()
		{
		}
	}
	[Token(Token = "0x200015B")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2494", Offset = "0x7F2494")]
		public VRIK ik;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F24CC", Offset = "0x7F24CC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F24CC", Offset = "0x7F24CC")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F252C", Offset = "0x7F252C")]
		public Vector3 headAnchorPositionOffset;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2564", Offset = "0x7F2564")]
		public Vector3 headAnchorRotationOffset;

		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F259C", Offset = "0x7F259C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F259C", Offset = "0x7F259C")]
		public Transform leftHandAnchor;

		[Token(Token = "0x40009AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F25FC", Offset = "0x7F25FC")]
		public Transform rightHandAnchor;

		[Token(Token = "0x40009B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2634", Offset = "0x7F2634")]
		public Vector3 handAnchorPositionOffset;

		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F266C", Offset = "0x7F266C")]
		public Vector3 handAnchorRotationOffset;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F26A4", Offset = "0x7F26A4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F26A4", Offset = "0x7F26A4")]
		public float scaleMlp;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F2704", Offset = "0x7F2704")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0xEDBF04", Offset = "0xEDBF04", VA = "0xEDBF04")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0xEDCE34", Offset = "0xEDCE34", VA = "0xEDCE34")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Token(Token = "0x200015C")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F273C", Offset = "0x7F273C")]
		public VRIK ik;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2774", Offset = "0x7F2774")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F27AC", Offset = "0x7F27AC")]
		public Transform headTracker;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F27E4", Offset = "0x7F27E4")]
		public Transform bodyTracker;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F281C", Offset = "0x7F281C")]
		public Transform leftHandTracker;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2854", Offset = "0x7F2854")]
		public Transform rightHandTracker;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F288C", Offset = "0x7F288C")]
		public Transform leftFootTracker;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F28C4", Offset = "0x7F28C4")]
		public Transform rightFootTracker;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F28FC", Offset = "0x7F28FC")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0xEDCEAC", Offset = "0xEDCEAC", VA = "0xEDCEAC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xEDE2D0", Offset = "0xEDE2D0", VA = "0xEDE2D0")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x200015D")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xEE0344", Offset = "0xEE0344", VA = "0xEE0344")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0xEE03A0", Offset = "0xEE03A0", VA = "0xEE03A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0xEE0528", Offset = "0xEE0528", VA = "0xEE0528")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x200015E")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0xEE055C", Offset = "0xEE055C", VA = "0xEE055C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0xEE09F8", Offset = "0xEE09F8", VA = "0xEE09F8")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x200015F")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40009CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000E4")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x1C6323C", Offset = "0x1C6323C", VA = "0x1C6323C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x1C63218", Offset = "0x1C63218", VA = "0x1C63218", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x1C63244", Offset = "0x1C63244", VA = "0x1C63244")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x1C632A8", Offset = "0x1C632A8", VA = "0x1C632A8", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x1C63440", Offset = "0x1C63440", VA = "0x1C63440", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x1C63664", Offset = "0x1C63664", VA = "0x1C63664", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x1C63450", Offset = "0x1C63450", VA = "0x1C63450")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x1C63674", Offset = "0x1C63674", VA = "0x1C63674")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000160")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x1C6368C", Offset = "0x1C6368C", VA = "0x1C6368C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x1C636F0", Offset = "0x1C636F0", VA = "0x1C636F0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x1C6378C", Offset = "0x1C6378C", VA = "0x1C6378C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x1C638A4", Offset = "0x1C638A4", VA = "0x1C638A4")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000161")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7F2964", Offset = "0x7F2964")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40009D9")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40009DA")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x40009DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x170000E5")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x1C63964", Offset = "0x1C63964", VA = "0x1C63964", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x1C638BC", Offset = "0x1C638BC", VA = "0x1C638BC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x1C63948", Offset = "0x1C63948", VA = "0x1C63948", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x1C63A5C", Offset = "0x1C63A5C", VA = "0x1C63A5C", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x1C63E40", Offset = "0x1C63E40", VA = "0x1C63E40")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x1C6401C", Offset = "0x1C6401C", VA = "0x1C6401C")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000162")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40009DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F29A8", Offset = "0x7F29A8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F29A8", Offset = "0x7F29A8")]
		public Transform gravityTarget;

		[Token(Token = "0x40009DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2A08", Offset = "0x7F2A08")]
		public float gravityMultiplier;

		[Token(Token = "0x40009E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40009E8")]
		protected const float half = 0.5f;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x6000A30")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x1C643F8", Offset = "0x1C643F8", VA = "0x1C643F8")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x1C64528", Offset = "0x1C64528", VA = "0x1C64528", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x1C64710", Offset = "0x1C64710", VA = "0x1C64710", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x1C648C0", Offset = "0x1C648C0", VA = "0x1C648C0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x1C64924", Offset = "0x1C64924", VA = "0x1C64924")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x1C64A44", Offset = "0x1C64A44", VA = "0x1C64A44")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x1C64B68", Offset = "0x1C64B68", VA = "0x1C64B68")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x1C64B8C", Offset = "0x1C64B8C", VA = "0x1C64B8C")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x1C64BB0", Offset = "0x1C64BB0", VA = "0x1C64BB0")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x1C64C10", Offset = "0x1C64C10", VA = "0x1C64C10")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000163")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000164")]
		public enum MoveMode
		{
			[Token(Token = "0x4000A27")]
			Directional,
			[Token(Token = "0x4000A28")]
			Strafe
		}

		[Token(Token = "0x2000165")]
		public struct AnimState
		{
			[Token(Token = "0x4000A29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000A2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000A2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000A2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000A2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x4000A2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x2000166")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7E87C8", Offset = "0x7E87C8")]
		private sealed class <JumpSmooth>d__79 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x4000A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x4000A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x4000A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x170000E8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A52")]
				[Address(RVA = "0x1BE3EC4", Offset = "0x1BE3EC4", VA = "0x1BE3EC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A54")]
				[Address(RVA = "0x1BE3F0C", Offset = "0x1BE3F0C", VA = "0x1BE3F0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x1BE3D94", Offset = "0x1BE3D94", VA = "0x1BE3D94")]
			[DebuggerHidden]
			public <JumpSmooth>d__79(int <>1__state)
			{
			}

			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x1BE3DC0", Offset = "0x1BE3DC0", VA = "0x1BE3DC0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x1BE3DC4", Offset = "0x1BE3DC4", VA = "0x1BE3DC4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x1BE3ECC", Offset = "0x1BE3ECC", VA = "0x1BE3ECC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F2A40", Offset = "0x7F2A40")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F2A78", Offset = "0x7F2A78")]
		public MoveMode moveMode;

		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F2AB0", Offset = "0x7F2AB0")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F2AE8", Offset = "0x7F2AE8")]
		public bool smoothJump;

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F2B20", Offset = "0x7F2B20")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7F2B58", Offset = "0x7F2B58")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F2B90", Offset = "0x7F2B90")]
		private bool <fullRootMotion>k__BackingField;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F2BA0", Offset = "0x7F2BA0")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x4000A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x170000E6")]
		public bool fullRootMotion
		{
			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x1C8FD98", Offset = "0x1C8FD98", VA = "0x1C8FD98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6958", Offset = "0x7F6958")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x1C8FDA0", Offset = "0x1C8FDA0", VA = "0x1C8FDA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6968", Offset = "0x7F6968")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public bool onGround
		{
			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x1C8FDAC", Offset = "0x1C8FDAC", VA = "0x1C8FDAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6978", Offset = "0x7F6978")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x1C8FDB4", Offset = "0x1C8FDB4", VA = "0x1C8FDB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6988", Offset = "0x7F6988")]
			private set
			{
			}
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x1C8FDC0", Offset = "0x1C8FDC0", VA = "0x1C8FDC0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x1C8FF2C", Offset = "0x1C8FF2C", VA = "0x1C8FF2C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x1C8FFBC", Offset = "0x1C8FFBC", VA = "0x1C8FFBC", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x1C90084", Offset = "0x1C90084", VA = "0x1C90084")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x1C90CE0", Offset = "0x1C90CE0", VA = "0x1C90CE0", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x1C90F38", Offset = "0x1C90F38", VA = "0x1C90F38", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x1C905A8", Offset = "0x1C905A8", VA = "0x1C905A8")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x1C9101C", Offset = "0x1C9101C", VA = "0x1C9101C")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x1C914C4", Offset = "0x1C914C4", VA = "0x1C914C4")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x1C90D68", Offset = "0x1C90D68", VA = "0x1C90D68")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x1C9156C", Offset = "0x1C9156C", VA = "0x1C9156C", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x1C918AC", Offset = "0x1C918AC", VA = "0x1C918AC")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x1C9199C", Offset = "0x1C9199C", VA = "0x1C9199C", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x1C91AFC", Offset = "0x1C91AFC", VA = "0x1C91AFC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7F6998", Offset = "0x7F6998")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x1C9092C", Offset = "0x1C9092C", VA = "0x1C9092C")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x1C91B98", Offset = "0x1C91B98", VA = "0x1C91B98")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000167")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000168")]
		public enum RotationMode
		{
			[Token(Token = "0x4000A44")]
			Smooth,
			[Token(Token = "0x4000A45")]
			Linear
		}

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2BB0", Offset = "0x7F2BB0")]
		public CameraController cameraController;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2BE8", Offset = "0x7F2BE8")]
		public float accelerationTime;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2C20", Offset = "0x7F2C20")]
		public float turnTime;

		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2C58", Offset = "0x7F2C58")]
		public bool walkByDefault;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2C90", Offset = "0x7F2C90")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2CC8", Offset = "0x7F2CC8")]
		public float moveSpeed;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F2D00", Offset = "0x7F2D00")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x4000A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000EA")]
		public bool isGrounded
		{
			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x1AF370C", Offset = "0x1AF370C", VA = "0x1AF370C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6A48", Offset = "0x7F6A48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x1AF3714", Offset = "0x1AF3714", VA = "0x1AF3714")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6A58", Offset = "0x7F6A58")]
			private set
			{
			}
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x1AF3720", Offset = "0x1AF3720", VA = "0x1AF3720")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x1AF37C4", Offset = "0x1AF37C4", VA = "0x1AF37C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x1AF3C84", Offset = "0x1AF3C84", VA = "0x1AF3C84")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x1AF3818", Offset = "0x1AF3818", VA = "0x1AF3818")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x1AF3A98", Offset = "0x1AF3A98", VA = "0x1AF3A98")]
		private void Move()
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x1AF3CC0", Offset = "0x1AF3CC0", VA = "0x1AF3CC0")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x1AF3D5C", Offset = "0x1AF3D5C", VA = "0x1AF3D5C")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x1AF3DE0", Offset = "0x1AF3DE0", VA = "0x1AF3DE0")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000169")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0xED9E88", Offset = "0xED9E88", VA = "0xED9E88", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0xED9F0C", Offset = "0xED9F0C", VA = "0xED9F0C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0xEDA0D0", Offset = "0xEDA0D0", VA = "0xEDA0D0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0xEDA0F8", Offset = "0xEDA0F8", VA = "0xEDA0F8")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x200016A")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x200016B")]
		public struct State
		{
			[Token(Token = "0x4000A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000A4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000A4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000A4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0xED9ECC", Offset = "0xED9ECC", VA = "0xED9ECC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0xEDA214", Offset = "0xEDA214", VA = "0xEDA214", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0xEDA114", Offset = "0xEDA114", VA = "0xEDA114")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x200016C")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x1C533CC", Offset = "0x1C533CC", VA = "0x1C533CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x1C53408", Offset = "0x1C53408", VA = "0x1C53408")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x200016D")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x4000A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x4000A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x4000A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x1AF3E08", Offset = "0x1AF3E08", VA = "0x1AF3E08")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x1AF3E3C", Offset = "0x1AF3E3C", VA = "0x1AF3E3C")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x1AF3EEC", Offset = "0x1AF3EEC", VA = "0x1AF3EEC")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016E")]
	public class Navigator
	{
		[Token(Token = "0x200016F")]
		public enum State
		{
			[Token(Token = "0x4000A67")]
			Idle,
			[Token(Token = "0x4000A68")]
			Seeking,
			[Token(Token = "0x4000A69")]
			OnPath
		}

		[Token(Token = "0x4000A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2D10", Offset = "0x7F2D10")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2D48", Offset = "0x7F2D48")]
		public float cornerRadius;

		[Token(Token = "0x4000A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2D80", Offset = "0x7F2D80")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2DB8", Offset = "0x7F2DB8")]
		public float maxSampleDistance;

		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7F2DF0", Offset = "0x7F2DF0")]
		public float nextPathInterval;

		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F2E28", Offset = "0x7F2E28")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F2E38", Offset = "0x7F2E38")]
		private State <state>k__BackingField;

		[Token(Token = "0x4000A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x4000A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x4000A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x4000A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000EB")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x1AE77A4", Offset = "0x1AE77A4", VA = "0x1AE77A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6A68", Offset = "0x7F6A68")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x1AE77B0", Offset = "0x1AE77B0", VA = "0x1AE77B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6A78", Offset = "0x7F6A78")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public State state
		{
			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x1AE77BC", Offset = "0x1AE77BC", VA = "0x1AE77BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6A88", Offset = "0x7F6A88")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x1AE77C4", Offset = "0x1AE77C4", VA = "0x1AE77C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6A98", Offset = "0x7F6A98")]
			private set
			{
			}
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x1AE77CC", Offset = "0x1AE77CC", VA = "0x1AE77CC")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x1AE78A0", Offset = "0x1AE78A0", VA = "0x1AE78A0")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x1AE7CA0", Offset = "0x1AE7CA0", VA = "0x1AE7CA0")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x1AE7D1C", Offset = "0x1AE7D1C", VA = "0x1AE7D1C")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x1AE7C5C", Offset = "0x1AE7C5C", VA = "0x1AE7C5C")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x1AE7C8C", Offset = "0x1AE7C8C", VA = "0x1AE7C8C")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x1AE7E68", Offset = "0x1AE7E68", VA = "0x1AE7E68")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x1AE8018", Offset = "0x1AE8018", VA = "0x1AE8018")]
		public Navigator()
		{
		}
	}
}
namespace ExitGames.Client.Photon.Chat
{
	[Token(Token = "0x2000170")]
	public class ChatChannel
	{
		[Token(Token = "0x4000A6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Name;

		[Token(Token = "0x4000A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly List<string> Senders;

		[Token(Token = "0x4000A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly List<object> Messages;

		[Token(Token = "0x4000A6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F2E48", Offset = "0x7F2E48")]
		private bool <IsPrivate>k__BackingField;

		[Token(Token = "0x170000ED")]
		public bool IsPrivate
		{
			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x1C91C50", Offset = "0x1C91C50", VA = "0x1C91C50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6AA8", Offset = "0x7F6AA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x1C91C58", Offset = "0x1C91C58", VA = "0x1C91C58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6AB8", Offset = "0x7F6AB8")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public int MessageCount
		{
			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x1C91C64", Offset = "0x1C91C64", VA = "0x1C91C64")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x1C91CB0", Offset = "0x1C91CB0", VA = "0x1C91CB0")]
		public ChatChannel(string name)
		{
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x1C91D9C", Offset = "0x1C91D9C", VA = "0x1C91D9C")]
		public void Add(string sender, object message)
		{
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x1C91E2C", Offset = "0x1C91E2C", VA = "0x1C91E2C")]
		public void Add(string[] senders, object[] messages)
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x1C91EBC", Offset = "0x1C91EBC", VA = "0x1C91EBC")]
		public void ClearMessages()
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x1C91F34", Offset = "0x1C91F34", VA = "0x1C91F34")]
		public string ToStringMessages()
		{
			return null;
		}
	}
	[Token(Token = "0x2000171")]
	public class ChatClient : IPhotonPeerListener
	{
		[Token(Token = "0x4000A6E")]
		private const int FriendRequestListMax = 1024;

		[Token(Token = "0x4000A6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F2E58", Offset = "0x7F2E58")]
		private string <NameServerAddress>k__BackingField;

		[Token(Token = "0x4000A70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F2E68", Offset = "0x7F2E68")]
		private string <FrontendAddress>k__BackingField;

		[Token(Token = "0x4000A71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string chatRegion;

		[Token(Token = "0x4000A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F2E78", Offset = "0x7F2E78")]
		private ChatState <State>k__BackingField;

		[Token(Token = "0x4000A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F2E88", Offset = "0x7F2E88")]
		private ChatDisconnectCause <DisconnectedCause>k__BackingField;

		[Token(Token = "0x4000A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F2E98", Offset = "0x7F2E98")]
		private string <AppVersion>k__BackingField;

		[Token(Token = "0x4000A75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F2EA8", Offset = "0x7F2EA8")]
		private string <AppId>k__BackingField;

		[Token(Token = "0x4000A76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F2EB8", Offset = "0x7F2EB8")]
		private AuthenticationValues <AuthValues>k__BackingField;

		[Token(Token = "0x4000A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly Dictionary<string, ChatChannel> PublicChannels;

		[Token(Token = "0x4000A78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly Dictionary<string, ChatChannel> PrivateChannels;

		[Token(Token = "0x4000A79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly IChatClientListener listener;

		[Token(Token = "0x4000A7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal ChatPeer chatPeer;

		[Token(Token = "0x4000A7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool didAuthenticate;

		[Token(Token = "0x4000A7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int msDeltaForServiceCalls;

		[Token(Token = "0x4000A7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int msTimestampOfLastServiceCall;

		[Token(Token = "0x4000A7E")]
		private const string ChatApppName = "chat";

		[Token(Token = "0x170000EF")]
		public string NameServerAddress
		{
			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x1C92088", Offset = "0x1C92088", VA = "0x1C92088")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6AC8", Offset = "0x7F6AC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x1C92090", Offset = "0x1C92090", VA = "0x1C92090")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6AD8", Offset = "0x7F6AD8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public string FrontendAddress
		{
			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x1C92098", Offset = "0x1C92098", VA = "0x1C92098")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6AE8", Offset = "0x7F6AE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x1C920A0", Offset = "0x1C920A0", VA = "0x1C920A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6AF8", Offset = "0x7F6AF8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public string ChatRegion
		{
			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x1C920A8", Offset = "0x1C920A8", VA = "0x1C920A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x1C920B0", Offset = "0x1C920B0", VA = "0x1C920B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public ChatState State
		{
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x1C920B8", Offset = "0x1C920B8", VA = "0x1C920B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6B08", Offset = "0x7F6B08")]
			get
			{
				return default(ChatState);
			}
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x1C920C0", Offset = "0x1C920C0", VA = "0x1C920C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6B18", Offset = "0x7F6B18")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public ChatDisconnectCause DisconnectedCause
		{
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x1C920C8", Offset = "0x1C920C8", VA = "0x1C920C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6B28", Offset = "0x7F6B28")]
			get
			{
				return default(ChatDisconnectCause);
			}
			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x1C920D0", Offset = "0x1C920D0", VA = "0x1C920D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6B38", Offset = "0x7F6B38")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public bool CanChat
		{
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x1C920D8", Offset = "0x1C920D8", VA = "0x1C920D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F5")]
		private bool HasPeer
		{
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x1C920FC", Offset = "0x1C920FC", VA = "0x1C920FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F6")]
		public string AppVersion
		{
			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x1C9210C", Offset = "0x1C9210C", VA = "0x1C9210C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6B48", Offset = "0x7F6B48")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x1C92114", Offset = "0x1C92114", VA = "0x1C92114")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6B58", Offset = "0x7F6B58")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public string AppId
		{
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x1C9211C", Offset = "0x1C9211C", VA = "0x1C9211C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6B68", Offset = "0x7F6B68")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x1C92124", Offset = "0x1C92124", VA = "0x1C92124")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6B78", Offset = "0x7F6B78")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public AuthenticationValues AuthValues
		{
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x1C9212C", Offset = "0x1C9212C", VA = "0x1C9212C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6B88", Offset = "0x7F6B88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x1C92134", Offset = "0x1C92134", VA = "0x1C92134")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6B98", Offset = "0x7F6B98")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public string UserId
		{
			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x1C9213C", Offset = "0x1C9213C", VA = "0x1C9213C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x1C92154", Offset = "0x1C92154", VA = "0x1C92154")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public DebugLevel DebugOut
		{
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x1C93AAC", Offset = "0x1C93AAC", VA = "0x1C93AAC")]
			get
			{
				return default(DebugLevel);
			}
			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x1C93A90", Offset = "0x1C93A90", VA = "0x1C93A90")]
			set
			{
			}
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x1C921E4", Offset = "0x1C921E4", VA = "0x1C921E4")]
		public ChatClient(IChatClientListener listener, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x1C92324", Offset = "0x1C92324", VA = "0x1C92324")]
		public bool Connect(string appId, string appVersion, AuthenticationValues authValues)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x1C926D8", Offset = "0x1C926D8", VA = "0x1C926D8")]
		public void Service()
		{
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x1C9274C", Offset = "0x1C9274C", VA = "0x1C9274C")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x1C927A0", Offset = "0x1C927A0", VA = "0x1C927A0")]
		public void StopThread()
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x1C927B8", Offset = "0x1C927B8", VA = "0x1C927B8")]
		public bool Subscribe(string[] channels)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x1C927C0", Offset = "0x1C927C0", VA = "0x1C927C0")]
		public bool Subscribe(string[] channels, int messagesFromHistory)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x1C92A90", Offset = "0x1C92A90", VA = "0x1C92A90")]
		public bool Unsubscribe(string[] channels)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x1C92C38", Offset = "0x1C92C38", VA = "0x1C92C38")]
		public bool PublishMessage(string channelName, object message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x1C92E84", Offset = "0x1C92E84", VA = "0x1C92E84")]
		public bool SendPrivateMessage(string target, object message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x1C92E8C", Offset = "0x1C92E8C", VA = "0x1C92E8C")]
		public bool SendPrivateMessage(string target, object message, bool encrypt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x1C930E4", Offset = "0x1C930E4", VA = "0x1C930E4")]
		private bool SetOnlineStatus(int status, object message, bool skipMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x1C9330C", Offset = "0x1C9330C", VA = "0x1C9330C")]
		public bool SetOnlineStatus(int status)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x1C93318", Offset = "0x1C93318", VA = "0x1C93318")]
		public bool SetOnlineStatus(int status, object message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x1C93320", Offset = "0x1C93320", VA = "0x1C93320")]
		public bool AddFriends(string[] friends)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x1C93604", Offset = "0x1C93604", VA = "0x1C93604")]
		public bool RemoveFriends(string[] friends)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x1C938E8", Offset = "0x1C938E8", VA = "0x1C938E8")]
		public string GetPrivateChannelNameByUser(string userName)
		{
			return null;
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x1C93958", Offset = "0x1C93958", VA = "0x1C93958")]
		public bool TryGetChannel(string channelName, bool isPrivate, out ChatChannel channel)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x1C939DC", Offset = "0x1C939DC", VA = "0x1C939DC")]
		public bool TryGetChannel(string channelName, out ChatChannel channel)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x1C93A78", Offset = "0x1C93A78", VA = "0x1C93A78")]
		public void SendAcksOnly()
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x1C93AC8", Offset = "0x1C93AC8", VA = "0x1C93AC8", Slot = "4")]
		private void ExitGames.Client.Photon.IPhotonPeerListener.DebugReturn(DebugLevel level, string message)
		{
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x1C93B8C", Offset = "0x1C93B8C", VA = "0x1C93B8C", Slot = "7")]
		private void ExitGames.Client.Photon.IPhotonPeerListener.OnEvent(EventData eventData)
		{
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x1C94700", Offset = "0x1C94700", VA = "0x1C94700", Slot = "5")]
		private void ExitGames.Client.Photon.IPhotonPeerListener.OnOperationResponse(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x1C94EB8", Offset = "0x1C94EB8", VA = "0x1C94EB8", Slot = "6")]
		private void ExitGames.Client.Photon.IPhotonPeerListener.OnStatusChanged(StatusCode statusCode)
		{
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x1C9296C", Offset = "0x1C9296C", VA = "0x1C9296C")]
		private bool SendChannelOperation(string[] channels, byte operation, int historyLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x1C93EBC", Offset = "0x1C93EBC", VA = "0x1C93EBC")]
		private void HandlePrivateMessageEvent(EventData eventData)
		{
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x1C93BD4", Offset = "0x1C93BD4", VA = "0x1C93BD4")]
		private void HandleChatMessagesEvent(EventData eventData)
		{
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x1C94304", Offset = "0x1C94304", VA = "0x1C94304")]
		private void HandleSubscribeEvent(EventData eventData)
		{
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x1C94584", Offset = "0x1C94584", VA = "0x1C94584")]
		private void HandleUnsubscribeEvent(EventData eventData)
		{
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x1C9491C", Offset = "0x1C9491C", VA = "0x1C9491C")]
		private void HandleAuthResponse(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x1C94130", Offset = "0x1C94130", VA = "0x1C94130")]
		private void HandleStatusUpdate(EventData eventData)
		{
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x1C957FC", Offset = "0x1C957FC", VA = "0x1C957FC")]
		private void ConnectToFrontEnd()
		{
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x1C955F4", Offset = "0x1C955F4", VA = "0x1C955F4")]
		private bool AuthenticateOnFrontEnd()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000172")]
	public enum ChatDisconnectCause
	{
		[Token(Token = "0x4000A80")]
		None,
		[Token(Token = "0x4000A81")]
		DisconnectByServerUserLimit,
		[Token(Token = "0x4000A82")]
		ExceptionOnConnect,
		[Token(Token = "0x4000A83")]
		DisconnectByServer,
		[Token(Token = "0x4000A84")]
		TimeoutDisconnect,
		[Token(Token = "0x4000A85")]
		Exception,
		[Token(Token = "0x4000A86")]
		InvalidAuthentication,
		[Token(Token = "0x4000A87")]
		MaxCcuReached,
		[Token(Token = "0x4000A88")]
		InvalidRegion,
		[Token(Token = "0x4000A89")]
		OperationNotAllowedInCurrentState,
		[Token(Token = "0x4000A8A")]
		CustomAuthenticationFailed
	}
	[Token(Token = "0x2000173")]
	public class ChatEventCode
	{
		[Token(Token = "0x4000A8B")]
		public const byte ChatMessages = 0;

		[Token(Token = "0x4000A8C")]
		public const byte Users = 1;

		[Token(Token = "0x4000A8D")]
		public const byte PrivateMessage = 2;

		[Token(Token = "0x4000A8E")]
		public const byte FriendsList = 3;

		[Token(Token = "0x4000A8F")]
		public const byte StatusUpdate = 4;

		[Token(Token = "0x4000A90")]
		public const byte Subscribe = 5;

		[Token(Token = "0x4000A91")]
		public const byte Unsubscribe = 6;

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x1C95918", Offset = "0x1C95918", VA = "0x1C95918")]
		public ChatEventCode()
		{
		}
	}
	[Token(Token = "0x2000174")]
	public class ChatOperationCode
	{
		[Token(Token = "0x4000A92")]
		public const byte Authenticate = 230;

		[Token(Token = "0x4000A93")]
		public const byte Subscribe = 0;

		[Token(Token = "0x4000A94")]
		public const byte Unsubscribe = 1;

		[Token(Token = "0x4000A95")]
		public const byte Publish = 2;

		[Token(Token = "0x4000A96")]
		public const byte SendPrivate = 3;

		[Token(Token = "0x4000A97")]
		public const byte ChannelHistory = 4;

		[Token(Token = "0x4000A98")]
		public const byte UpdateStatus = 5;

		[Token(Token = "0x4000A99")]
		public const byte AddFriends = 6;

		[Token(Token = "0x4000A9A")]
		public const byte RemoveFriends = 7;

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x1C95920", Offset = "0x1C95920", VA = "0x1C95920")]
		public ChatOperationCode()
		{
		}
	}
	[Token(Token = "0x2000175")]
	public class ChatParameterCode
	{
		[Token(Token = "0x4000A9B")]
		public const byte Channels = 0;

		[Token(Token = "0x4000A9C")]
		public const byte Channel = 1;

		[Token(Token = "0x4000A9D")]
		public const byte Messages = 2;

		[Token(Token = "0x4000A9E")]
		public const byte Message = 3;

		[Token(Token = "0x4000A9F")]
		public const byte Senders = 4;

		[Token(Token = "0x4000AA0")]
		public const byte Sender = 5;

		[Token(Token = "0x4000AA1")]
		public const byte ChannelUserCount = 6;

		[Token(Token = "0x4000AA2")]
		public const byte UserId = 225;

		[Token(Token = "0x4000AA3")]
		public const byte MsgId = 8;

		[Token(Token = "0x4000AA4")]
		public const byte MsgIds = 9;

		[Token(Token = "0x4000AA5")]
		public const byte Secret = 221;

		[Token(Token = "0x4000AA6")]
		public const byte SubscribeResults = 15;

		[Token(Token = "0x4000AA7")]
		public const byte Status = 10;

		[Token(Token = "0x4000AA8")]
		public const byte Friends = 11;

		[Token(Token = "0x4000AA9")]
		public const byte SkipMessage = 12;

		[Token(Token = "0x4000AAA")]
		public const byte HistoryLength = 14;

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x1C95928", Offset = "0x1C95928", VA = "0x1C95928")]
		public ChatParameterCode()
		{
		}
	}
	[Token(Token = "0x2000176")]
	internal class ChatPeer : PhotonPeer
	{
		[Token(Token = "0x4000AAB")]
		public const string NameServerHost = "ns.exitgames.com";

		[Token(Token = "0x4000AAC")]
		public const string NameServerHttp = "http://ns.exitgamescloud.com:80/photon/n";

		[Token(Token = "0x4000AAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		[Token(Token = "0x170000FB")]
		public string NameServerAddress
		{
			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x1C925A4", Offset = "0x1C925A4", VA = "0x1C925A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		internal virtual bool IsProtocolSecure
		{
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x1C95AB4", Offset = "0x1C95AB4", VA = "0x1C95AB4", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x1C9231C", Offset = "0x1C9231C", VA = "0x1C9231C")]
		public ChatPeer(IPhotonPeerListener listener, ConnectionProtocol protocol)
		{
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x1C95930", Offset = "0x1C95930", VA = "0x1C95930")]
		private string GetNameServerAddress()
		{
			return null;
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x1C925A8", Offset = "0x1C925A8", VA = "0x1C925A8")]
		public bool Connect()
		{
			return default(bool);
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x1C95348", Offset = "0x1C95348", VA = "0x1C95348")]
		public bool AuthenticateOnNameServer(string appId, string appVersion, string region, AuthenticationValues authValues)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000177")]
	public enum CustomAuthenticationType : byte
	{
		[Token(Token = "0x4000AAF")]
		Custom = 0,
		[Token(Token = "0x4000AB0")]
		Steam = 1,
		[Token(Token = "0x4000AB1")]
		Facebook = 2,
		[Token(Token = "0x4000AB2")]
		None = byte.MaxValue
	}
	[Token(Token = "0x2000178")]
	public class AuthenticationValues
	{
		[Token(Token = "0x4000AB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CustomAuthenticationType authType;

		[Token(Token = "0x4000AB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F2EC8", Offset = "0x7F2EC8")]
		private string <AuthGetParameters>k__BackingField;

		[Token(Token = "0x4000AB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F2ED8", Offset = "0x7F2ED8")]
		private object <AuthPostData>k__BackingField;

		[Token(Token = "0x4000AB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F2EE8", Offset = "0x7F2EE8")]
		private string <Token>k__BackingField;

		[Token(Token = "0x4000AB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F2EF8", Offset = "0x7F2EF8")]
		private string <UserId>k__BackingField;

		[Token(Token = "0x170000FD")]
		public CustomAuthenticationType AuthType
		{
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x1C535A8", Offset = "0x1C535A8", VA = "0x1C535A8")]
			get
			{
				return default(CustomAuthenticationType);
			}
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x1C535B0", Offset = "0x1C535B0", VA = "0x1C535B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public string AuthGetParameters
		{
			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x1C535B8", Offset = "0x1C535B8", VA = "0x1C535B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6BA8", Offset = "0x7F6BA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x1C535C0", Offset = "0x1C535C0", VA = "0x1C535C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6BB8", Offset = "0x7F6BB8")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public object AuthPostData
		{
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x1C535C8", Offset = "0x1C535C8", VA = "0x1C535C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6BC8", Offset = "0x7F6BC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0x1C535D0", Offset = "0x1C535D0", VA = "0x1C535D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6BD8", Offset = "0x7F6BD8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public string Token
		{
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x1C535D8", Offset = "0x1C535D8", VA = "0x1C535D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6BE8", Offset = "0x7F6BE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x1C535E0", Offset = "0x1C535E0", VA = "0x1C535E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6BF8", Offset = "0x7F6BF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public string UserId
		{
			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x1C535E8", Offset = "0x1C535E8", VA = "0x1C535E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6C08", Offset = "0x7F6C08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x1C535F0", Offset = "0x1C535F0", VA = "0x1C535F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7F6C18", Offset = "0x7F6C18")]
			set
			{
			}
		}

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x1C535F8", Offset = "0x1C535F8", VA = "0x1C535F8")]
		public AuthenticationValues()
		{
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x1C53608", Offset = "0x1C53608", VA = "0x1C53608")]
		public AuthenticationValues(string userId)
		{
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x1C53644", Offset = "0x1C53644", VA = "0x1C53644", Slot = "4")]
		public virtual void SetAuthPostData(string stringData)
		{
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x1C53688", Offset = "0x1C53688", VA = "0x1C53688", Slot = "5")]
		public virtual void SetAuthPostData(byte[] byteData)
		{
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x1C53690", Offset = "0x1C53690", VA = "0x1C53690", Slot = "6")]
		public virtual void AddAuthParameter(string key, string value)
		{
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x1C538A8", Offset = "0x1C538A8", VA = "0x1C538A8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000179")]
	public class ParameterCode
	{
		[Token(Token = "0x4000AB8")]
		public const byte ApplicationId = 224;

		[Token(Token = "0x4000AB9")]
		public const byte Secret = 221;

		[Token(Token = "0x4000ABA")]
		public const byte AppVersion = 220;

		[Token(Token = "0x4000ABB")]
		public const byte ClientAuthenticationType = 217;

		[Token(Token = "0x4000ABC")]
		public const byte ClientAuthenticationParams = 216;

		[Token(Token = "0x4000ABD")]
		public const byte ClientAuthenticationData = 214;

		[Token(Token = "0x4000ABE")]
		public const byte Region = 210;

		[Token(Token = "0x4000ABF")]
		public const byte Address = 230;

		[Token(Token = "0x4000AC0")]
		public const byte UserId = 225;

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x1AE9500", Offset = "0x1AE9500", VA = "0x1AE9500")]
		public ParameterCode()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public class ErrorCode
	{
		[Token(Token = "0x4000AC1")]
		public const int Ok = 0;

		[Token(Token = "0x4000AC2")]
		public const int OperationNotAllowedInCurrentState = -3;

		[Token(Token = "0x4000AC3")]
		public const int InvalidOperationCode = -2;

		[Token(Token = "0x4000AC4")]
		public const int InternalServerError = -1;

		[Token(Token = "0x4000AC5")]
		public const int InvalidAuthentication = 32767;

		[Token(Token = "0x4000AC6")]
		public const int GameIdAlreadyExists = 32766;

		[Token(Token = "0x4000AC7")]
		public const int GameFull = 32765;

		[Token(Token = "0x4000AC8")]
		public const int GameClosed = 32764;

		[Token(Token = "0x4000AC9")]
		public const int ServerFull = 32762;

		[Token(Token = "0x4000ACA")]
		public const int UserBlocked = 32761;

		[Token(Token = "0x4000ACB")]
		public const int NoRandomMatchFound = 32760;

		[Token(Token = "0x4000ACC")]
		public const int GameDoesNotExist = 32758;

		[Token(Token = "0x4000ACD")]
		public const int MaxCcuReached = 32757;

		[Token(Token = "0x4000ACE")]
		public const int InvalidRegion = 32756;

		[Token(Token = "0x4000ACF")]
		public const int CustomAuthenticationFailed = 32755;

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x1C98528", Offset = "0x1C98528", VA = "0x1C98528")]
		public ErrorCode()
		{
		}
	}
	[Token(Token = "0x200017B")]
	public enum ChatState
	{
		[Token(Token = "0x4000AD1")]
		Uninitialized,
		[Token(Token = "0x4000AD2")]
		ConnectingToNameServer,
		[Token(Token = "0x4000AD3")]
		ConnectedToNameServer,
		[Token(Token = "0x4000AD4")]
		Authenticating,
		[Token(Token = "0x4000AD5")]
		Authenticated,
		[Token(Token = "0x4000AD6")]
		DisconnectingFromNameServer,
		[Token(Token = "0x4000AD7")]
		ConnectingToFrontEnd,
		[Token(Token = "0x4000AD8")]
		ConnectedToFrontEnd,
		[Token(Token = "0x4000AD9")]
		DisconnectingFromFrontEnd,
		[Token(Token = "0x4000ADA")]
		QueuedComingFromFrontEnd,
		[Token(Token = "0x4000ADB")]
		Disconnecting,
		[Token(Token = "0x4000ADC")]
		Disconnected
	}
	[Token(Token = "0x200017C")]
	public static class ChatUserStatus
	{
		[Token(Token = "0x4000ADD")]
		public const int Offline = 0;

		[Token(Token = "0x4000ADE")]
		public const int Invisible = 1;

		[Token(Token = "0x4000ADF")]
		public const int Online = 2;

		[Token(Token = "0x4000AE0")]
		public const int Away = 3;

		[Token(Token = "0x4000AE1")]
		public const int DND = 4;

		[Token(Token = "0x4000AE2")]
		public const int LFG = 5;

		[Token(Token = "0x4000AE3")]
		public const int Playing = 6;
	}
	[Token(Token = "0x200017D")]
	public interface IChatClientListener
	{
		[Token(Token = "0x6000AD2")]
		void DebugReturn(DebugLevel level, string message);

		[Token(Token = "0x6000AD3")]
		void OnDisconnected();

		[Token(Token = "0x6000AD4")]
		void OnConnected();

		[Token(Token = "0x6000AD5")]
		void OnChatStateChange(ChatState state);

		[Token(Token = "0x6000AD6")]
		void OnGetMessages(string channelName, string[] senders, object[] messages);

		[Token(Token = "0x6000AD7")]
		void OnPrivateMessage(string sender, object message, string channelName);

		[Token(Token = "0x6000AD8")]
		void OnSubscribed(string[] channels, bool[] results);

		[Token(Token = "0x6000AD9")]
		void OnUnsubscribed(string[] channels);

		[Token(Token = "0x6000ADA")]
		void OnStatusUpdate(string user, int status, bool gotMessage, object message);
	}
}
