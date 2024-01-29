using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CodeStage.AntiCheat.Common;
using CodeStage.AntiCheat.Detectors;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.Tweening.Core;
using Il2CppDummyDll;
using Sword;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public enum LogSeverity
{
	[Token(Token = "0x4000002")]
	Log,
	[Token(Token = "0x4000003")]
	LogDebug,
	[Token(Token = "0x4000004")]
	LogInfo,
	[Token(Token = "0x4000005")]
	LogWarning,
	[Token(Token = "0x4000006")]
	LogAssert,
	[Token(Token = "0x4000007")]
	LogError,
	[Token(Token = "0x4000008")]
	LogException
}
[Token(Token = "0x2000003")]
public sealed class BuglyAgent
{
	[Token(Token = "0x20000CD")]
	public delegate void LogCallbackDelegate(string condition, string stackTrace, LogType type);

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string GAME_AGENT_CLASS;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly int TYPE_U3D_CRASH;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly int GAME_TYPE_UNITY;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static bool hasSetGameType;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static AndroidJavaClass _gameAgentClass;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static string _configChannel;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string _configVersion;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static string _configUser;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static long _configDelayTime;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static bool _configCrashReporterPackage;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static bool _isInitialized;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static LogSeverity _autoReportLogLevel;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static int _crashReporterType;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static string _crashReporterPackage;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static bool _debugMode;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	private static bool _autoQuitApplicationAfterReport;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private static readonly int EXCEPTION_TYPE_UNCAUGHT;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static readonly int EXCEPTION_TYPE_CAUGHT;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static readonly string _pluginVersion;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static Func<Dictionary<string, string>> _LogCallbackExtrasHandler;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static bool _uncaughtAutoReportOnce;

	[Token(Token = "0x17000001")]
	public static AndroidJavaClass GameAgent
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x11C11C4", Offset = "0x11C11C4", VA = "0x11C11C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public static string PluginVersion
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x11C1A3C", Offset = "0x11C1A3C", VA = "0x11C1A3C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public static bool IsInitialized
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x11C1AA4", Offset = "0x11C1AA4", VA = "0x11C1AA4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000004")]
	public static bool AutoQuitApplicationAfterReport
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x11C1B0C", Offset = "0x11C1B0C", VA = "0x11C1B0C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000001")]
	private static event LogCallbackDelegate _LogCallbackEventHandler
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x11BE8A0", Offset = "0x11BE8A0", VA = "0x11BE8A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95CFDC", Offset = "0x95CFDC")]
		add
		{
		}
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x11BFDE8", Offset = "0x11BFDE8", VA = "0x11BFDE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95CFEC", Offset = "0x95CFEC")]
		remove
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x11BDC7C", Offset = "0x11BDC7C", VA = "0x11BDC7C")]
	public static void ConfigCrashReporter(int type, int logLevel)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x11BDD8C", Offset = "0x11BDD8C", VA = "0x11BDD8C")]
	public static void InitWithAppId(string appId)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x11BE61C", Offset = "0x11BE61C", VA = "0x11BE61C")]
	public static void EnableExceptionHandler()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x11BE7BC", Offset = "0x11BE7BC", VA = "0x11BE7BC")]
	public static void RegisterLogCallback(LogCallbackDelegate handler)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x11BE990", Offset = "0x11BE990", VA = "0x11BE990")]
	public static void SetLogCallbackExtrasHandler(Func<Dictionary<string, string>> handler)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x11BEA78", Offset = "0x11BEA78", VA = "0x11BEA78")]
	public static void ReportException(Exception e, string message)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x11BF150", Offset = "0x11BF150", VA = "0x11BF150")]
	public static void ReportException(string name, string message, string stackTrace)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x11BFCC4", Offset = "0x11BFCC4", VA = "0x11BFCC4")]
	public static void UnregisterLogCallback(LogCallbackDelegate handler)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x11BFED8", Offset = "0x11BFED8", VA = "0x11BFED8")]
	public static void SetUserId(string userId)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x11C01BC", Offset = "0x11C01BC", VA = "0x11C01BC")]
	public static void SetScene(int sceneId)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x11C04CC", Offset = "0x11C04CC", VA = "0x11C04CC")]
	public static void AddSceneData(string key, string value)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x11C0828", Offset = "0x11C0828", VA = "0x11C0828")]
	public static void ConfigDebugMode(bool enable)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x11C0AF0", Offset = "0x11C0AF0", VA = "0x11C0AF0")]
	public static void ConfigAutoQuitApplication(bool autoQuit)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x11C0B60", Offset = "0x11C0B60", VA = "0x11C0B60")]
	public static void ConfigAutoReportLogLevel(LogSeverity level)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x11C0BCC", Offset = "0x11C0BCC", VA = "0x11C0BCC")]
	public static void ConfigDefault(string channel, string version, string user, long delay)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x11BDFBC", Offset = "0x11BDFBC", VA = "0x11BDFBC")]
	public static void DebugLog(string tag, string format, params object[] args)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x11C0E0C", Offset = "0x11C0E0C", VA = "0x11C0E0C")]
	public static void PrintLog(LogSeverity level, string format, params object[] args)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x11C0D6C", Offset = "0x11C0D6C", VA = "0x11C0D6C")]
	private static void ConfigDefaultBeforeInit(string channel, string version, string user, long delay)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x11C13A4", Offset = "0x11C13A4", VA = "0x11C13A4")]
	private static void ConfigCrashReporterPackage()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x11BE0AC", Offset = "0x11BE0AC", VA = "0x11BE0AC")]
	private static void InitBuglyAgent(string appId)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x11C0940", Offset = "0x11C0940", VA = "0x11C0940")]
	private static void EnableDebugMode(bool enable)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x11C002C", Offset = "0x11C002C", VA = "0x11C002C")]
	private static void SetUserInfo(string userInfo)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x11C1554", Offset = "0x11C1554", VA = "0x11C1554")]
	private static void ReportException(int type, string name, string reason, string stackTrace, bool quitProgram)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x11C0328", Offset = "0x11C0328", VA = "0x11C0328")]
	private static void SetCurrentScene(int sceneId)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x11C1850", Offset = "0x11C1850", VA = "0x11C1850")]
	private static void SetUnityVersion()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x11C0650", Offset = "0x11C0650", VA = "0x11C0650")]
	private static void AddKeyAndValueInScene(string key, string value)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x11C1A38", Offset = "0x11C1A38", VA = "0x11C1A38")]
	private static void AddExtraDataWithException(string key, string value)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x11C0EBC", Offset = "0x11C0EBC", VA = "0x11C0EBC")]
	private static void LogRecord(LogSeverity level, string message)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x11BDCE0", Offset = "0x11BDCE0", VA = "0x11BDCE0")]
	private static void _SetCrashReporterType(int type)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x11BDD88", Offset = "0x11BDD88", VA = "0x11BDD88")]
	private static void _SetCrashReporterLogLevel(int logLevel)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x11BE408", Offset = "0x11BE408", VA = "0x11BE408")]
	private static void _RegisterExceptionHandler()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x11C1B74", Offset = "0x11C1B74", VA = "0x11C1B74")]
	private static void _UnregisterExceptionHandler()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x11C1D30", Offset = "0x11C1D30", VA = "0x11C1D30")]
	private static void _OnLogCallbackHandler(string condition, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x11C2310", Offset = "0x11C2310", VA = "0x11C2310")]
	private static void _OnUncaughtExceptionHandler(object sender, UnhandledExceptionEventArgs args)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x11BEC00", Offset = "0x11BEC00", VA = "0x11BEC00")]
	private static void _HandleException(Exception e, string message, bool uncaught)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x11C259C", Offset = "0x11C259C", VA = "0x11C259C")]
	private static void _reportException(bool uncaught, string name, string reason, string stackTrace)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x11BF318", Offset = "0x11BF318", VA = "0x11BF318")]
	private static void _HandleException(LogSeverity logLevel, string name, string message, string stackTrace, bool uncaught)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x11C2CBC", Offset = "0x11C2CBC", VA = "0x11C2CBC")]
	public BuglyAgent()
	{
	}
}
[Token(Token = "0x2000004")]
public abstract class BuglyCallback
{
	[Token(Token = "0x600002E")]
	public abstract void OnApplicationLogCallbackHandler(string condition, string stackTrace, LogType type);

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x11C2E80", Offset = "0x11C2E80", VA = "0x11C2E80")]
	protected BuglyCallback()
	{
	}
}
[Token(Token = "0x2000005")]
[ExecuteInEditMode]
public class OffsetMaskShaderAnimation : MonoBehaviour
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float Size;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector4 Offset;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material mat;

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1184820", Offset = "0x1184820", VA = "0x1184820")]
	private void Start()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1184890", Offset = "0x1184890", VA = "0x1184890")]
	private void Update()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1184914", Offset = "0x1184914", VA = "0x1184914")]
	public OffsetMaskShaderAnimation()
	{
	}
}
[Token(Token = "0x2000006")]
public class ReYunGame : MonoBehaviour
{
	[Token(Token = "0x20000CE")]
	public enum Gender
	{
		[Token(Token = "0x40006A8")]
		reyun_m,
		[Token(Token = "0x40006A9")]
		reyun_f,
		[Token(Token = "0x40006AA")]
		reyun_o
	}

	[Token(Token = "0x20000CF")]
	public enum QuestStatus
	{
		[Token(Token = "0x40006AC")]
		reyun_start,
		[Token(Token = "0x40006AD")]
		reyun_done,
		[Token(Token = "0x40006AE")]
		reyun_fail
	}

	[Token(Token = "0x20000D0")]
	public struct strutDict
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string key;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string value;
	}

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ReYunGame _instance;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ReyunHttp mReyunHttp;

	[Token(Token = "0x17000005")]
	public static ReYunGame Instance
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1184994", Offset = "0x1184994", VA = "0x1184994")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1184C08", Offset = "0x1184C08", VA = "0x1184C08")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1184C70", Offset = "0x1184C70", VA = "0x1184C70")]
	public static AndroidJavaObject getApplicationContext()
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1184F18", Offset = "0x1184F18", VA = "0x1184F18")]
	public void Game_Init(string appId, string channelId)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1184FEC", Offset = "0x1184FEC", VA = "0x1184FEC")]
	public void Game_Register(string account, Gender gender, string age, string serverId, string accountType, string rolename)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x11850BC", Offset = "0x11850BC", VA = "0x11850BC")]
	public void Game_Login(string account, Gender genders, string age, string serverId, int level, string rolename)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x118518C", Offset = "0x118518C", VA = "0x118518C")]
	public void Game_SetPaymentStart(string transactionId, string paymentType, string currencyType, float currencyAmount, float virtualCoinAmount, string iapName, int iapAmount)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1185190", Offset = "0x1185190", VA = "0x1185190")]
	public void Game_SetPayment(string transactionId, string paymentType, string currencyType, float currencyAmount, float virtualCoinAmount, string iapName, int iapAmount, int level)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x11852B8", Offset = "0x11852B8", VA = "0x11852B8")]
	public void Game_SetEconomy(string itemName, int itemAmount, float itemTotalPrice)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1185388", Offset = "0x1185388", VA = "0x1185388")]
	public void Game_Quest(string questId, QuestStatus questStatu, string questType)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x118538C", Offset = "0x118538C", VA = "0x118538C")]
	public void Game_SetEvent(string eventName, Dictionary<string, string> dict)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x118545C", Offset = "0x118545C", VA = "0x118545C")]
	public string Game_getDeviceId()
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x11856FC", Offset = "0x11856FC", VA = "0x11856FC")]
	public void Game_setPrintLog(bool print)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1185700", Offset = "0x1185700", VA = "0x1185700")]
	public ReYunGame()
	{
	}
}
[Token(Token = "0x2000007")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x95A0E0", Offset = "0x95A0E0")]
public class GaussianBlur : PostEffectsBase
{
	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material gaussianBlurMaterial;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float scale;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTexture Rtex;

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x11846A0", Offset = "0x11846A0", VA = "0x11846A0")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1184810", Offset = "0x1184810", VA = "0x1184810")]
	public GaussianBlur()
	{
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x2000008")]
	public enum AAMode
	{
		[Token(Token = "0x4000028")]
		FXAA2,
		[Token(Token = "0x4000029")]
		FXAA3Console,
		[Token(Token = "0x400002A")]
		FXAA1PresetA,
		[Token(Token = "0x400002B")]
		FXAA1PresetB,
		[Token(Token = "0x400002C")]
		NFAA,
		[Token(Token = "0x400002D")]
		SSAA,
		[Token(Token = "0x400002E")]
		DLAA
	}
	[Token(Token = "0x2000009")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95A154", Offset = "0x95A154")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A154", Offset = "0x95A154")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AAMode mode;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool showGeneratedNormals;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float offsetScale;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float blurRadius;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float edgeThresholdMin;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float edgeThreshold;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float edgeSharpness;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool dlaaSharp;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader ssaaShader;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material ssaa;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader dlaaShader;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material dlaa;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Shader nfaaShader;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material nfaa;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Shader shaderFXAAII;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Material materialFXAAII;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Material materialFXAAIII;

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x17DAE18", Offset = "0x17DAE18", VA = "0x17DAE18")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x17DAE7C", Offset = "0x17DAE7C", VA = "0x17DAE7C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x17DB340", Offset = "0x17DB340", VA = "0x17DB340")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x17DB888", Offset = "0x17DB888", VA = "0x17DB888")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x200000A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95A1EC", Offset = "0x95A1EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A1EC", Offset = "0x95A1EC")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x20000D1")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x40006B2")]
			Ghosting,
			[Token(Token = "0x40006B3")]
			Anamorphic,
			[Token(Token = "0x40006B4")]
			Combined
		}

		[Token(Token = "0x20000D2")]
		public enum TweakMode
		{
			[Token(Token = "0x40006B6")]
			Basic,
			[Token(Token = "0x40006B7")]
			Complex
		}

		[Token(Token = "0x20000D3")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x40006B9")]
			Auto,
			[Token(Token = "0x40006BA")]
			On,
			[Token(Token = "0x40006BB")]
			Off
		}

		[Token(Token = "0x20000D4")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x40006BD")]
			Screen,
			[Token(Token = "0x40006BE")]
			Add
		}

		[Token(Token = "0x20000D5")]
		public enum BloomQuality
		{
			[Token(Token = "0x40006C0")]
			Cheap,
			[Token(Token = "0x40006C1")]
			High
		}

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TweakMode tweakMode;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool doHdr;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sepBlurSpread;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BloomQuality quality;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float bloomIntensity;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float bloomThreshold;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color bloomThresholdColor;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int bloomBlurIterations;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float flareRotation;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensflareIntensity;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float lensflareThreshold;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float lensFlareSaturation;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Color flareColorA;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Color flareColorB;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public Color flareColorC;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Color flareColorD;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Shader lensFlareShader;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Material lensFlareMaterial;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader screenBlendShader;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material screenBlend;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x17DB8C8", Offset = "0x17DB8C8", VA = "0x17DB8C8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x17DBCE4", Offset = "0x17DBCE4", VA = "0x17DBCE4")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x17DD0A0", Offset = "0x17DD0A0", VA = "0x17DD0A0")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x17DCEA0", Offset = "0x17DCEA0", VA = "0x17DCEA0")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x17DCBA8", Offset = "0x17DCBA8", VA = "0x17DCBA8")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x17DCAC4", Offset = "0x17DCAC4", VA = "0x17DCAC4")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x17DCC94", Offset = "0x17DCC94", VA = "0x17DCC94")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x17DD168", Offset = "0x17DD168", VA = "0x17DD168")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x4000064")]
		Ghosting,
		[Token(Token = "0x4000065")]
		Anamorphic,
		[Token(Token = "0x4000066")]
		Combined
	}
	[Token(Token = "0x200000C")]
	public enum TweakMode34
	{
		[Token(Token = "0x4000068")]
		Basic,
		[Token(Token = "0x4000069")]
		Complex
	}
	[Token(Token = "0x200000D")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x400006B")]
		Auto,
		[Token(Token = "0x400006C")]
		On,
		[Token(Token = "0x400006D")]
		Off
	}
	[Token(Token = "0x200000E")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x400006F")]
		Screen,
		[Token(Token = "0x4000070")]
		Add
	}
	[Token(Token = "0x200000F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95A284", Offset = "0x95A284")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A284", Offset = "0x95A284")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool doHdr;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sepBlurSpread;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float bloomIntensity;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float bloomThreshold;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int bloomBlurIterations;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool lensflares;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float hollyStretchWidth;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float lensflareIntensity;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float lensflareThreshold;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Color flareColorA;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Color flareColorB;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color flareColorC;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color flareColorD;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader vignetteShader;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material vignetteMaterial;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader separableBlurShader;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader screenBlendShader;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material screenBlend;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x17DD2B0", Offset = "0x17DD2B0", VA = "0x17DD2B0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x17DD368", Offset = "0x17DD368", VA = "0x17DD368")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x17DE2B4", Offset = "0x17DE2B4", VA = "0x17DE2B4")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x17DE0C4", Offset = "0x17DE0C4", VA = "0x17DE0C4")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x17DDE48", Offset = "0x17DDE48", VA = "0x17DDE48")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x17DDF70", Offset = "0x17DDF70", VA = "0x17DDF70")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x17DE368", Offset = "0x17DE368", VA = "0x17DE368")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95A31C", Offset = "0x95A31C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A31C", Offset = "0x95A31C")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x20000D6")]
		public enum Resolution
		{
			[Token(Token = "0x40006C3")]
			Low,
			[Token(Token = "0x40006C4")]
			High
		}

		[Token(Token = "0x20000D7")]
		public enum BlurType
		{
			[Token(Token = "0x40006C6")]
			Standard,
			[Token(Token = "0x40006C7")]
			Sgx
		}

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BA10", Offset = "0x95BA10")]
		public float threshold;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BA28", Offset = "0x95BA28")]
		public float intensity;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BA40", Offset = "0x95BA40")]
		public float blurSize;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Resolution resolution;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BA58", Offset = "0x95BA58")]
		public int blurIterations;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BlurType blurType;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader fastBloomShader;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fastBloomMaterial;

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x17DE4A4", Offset = "0x17DE4A4", VA = "0x17DE4A4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x17DE4FC", Offset = "0x17DE4FC", VA = "0x17DE4FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x17DE5AC", Offset = "0x17DE5AC", VA = "0x17DE5AC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x17DE978", Offset = "0x17DE978", VA = "0x17DE978")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x2000011")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A3B4", Offset = "0x95A3B4")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BA70", Offset = "0x95BA70")]
		public int iterations;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BA88", Offset = "0x95BA88")]
		public float blurSpread;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x17000006")]
		protected Material material
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x17DE9A4", Offset = "0x17DE9A4", VA = "0x17DE9A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x17DEADC", Offset = "0x17DEADC", VA = "0x17DEADC")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x17DEBD8", Offset = "0x17DEBD8", VA = "0x17DEBD8")]
		protected void Start()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x17DEC98", Offset = "0x17DEC98", VA = "0x17DEC98")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x17DEE3C", Offset = "0x17DEE3C", VA = "0x17DEE3C")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x17DEFB4", Offset = "0x17DEFB4", VA = "0x17DEFB4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x17DF120", Offset = "0x17DF120", VA = "0x17DF120")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x2000012")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95A400", Offset = "0x95A400")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A400", Offset = "0x95A400")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x20000D8")]
		public enum BlurType
		{
			[Token(Token = "0x40006C9")]
			StandardGauss,
			[Token(Token = "0x40006CA")]
			SgxGauss
		}

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BAA0", Offset = "0x95BAA0")]
		public int downsample;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BAB8", Offset = "0x95BAB8")]
		public float blurSize;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BAD0", Offset = "0x95BAD0")]
		public int blurIterations;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BlurType blurType;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader blurShader;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material blurMaterial;

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x17DF13C", Offset = "0x17DF13C", VA = "0x17DF13C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x17DF194", Offset = "0x17DF194", VA = "0x17DF194")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x17DF244", Offset = "0x17DF244", VA = "0x17DF244")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x17DF5E8", Offset = "0x17DF5E8", VA = "0x17DF5E8")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95A498", Offset = "0x95A498")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A498", Offset = "0x95A498")]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x20000D9")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x40006CC")]
			CameraMotion,
			[Token(Token = "0x40006CD")]
			LocalBlur,
			[Token(Token = "0x40006CE")]
			Reconstruction,
			[Token(Token = "0x40006CF")]
			ReconstructionDX11,
			[Token(Token = "0x40006D0")]
			ReconstructionDisc
		}

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool preview;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 previewScale;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float movementScale;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rotationScale;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxVelocity;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float minVelocity;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float velocityScale;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float softZDistance;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int velocityDownsample;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LayerMask excludeLayers;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject tmpCam;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shader;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader replacementClear;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material motionBlurMaterial;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D noiseTexture;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float jitter;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool showVelocity;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float showVelocityScale;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private int prevFrameCount;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool wasActive;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 prevFramePos;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Camera _camera;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x17DF610", Offset = "0x17DF610", VA = "0x17DF610")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x17DF75C", Offset = "0x17DF75C", VA = "0x17DF75C")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x17DF8E0", Offset = "0x17DF8E0", VA = "0x17DF8E0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x17DF9A0", Offset = "0x17DF9A0", VA = "0x17DF9A0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x17DFB04", Offset = "0x17DFB04", VA = "0x17DFB04", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x17DFBE8", Offset = "0x17DFBE8", VA = "0x17DFBE8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x17DF834", Offset = "0x17DF834", VA = "0x17DF834")]
		private void Remember()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x17E1270", Offset = "0x17E1270", VA = "0x17E1270")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x17E1184", Offset = "0x17E1184", VA = "0x17E1184")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x17E1260", Offset = "0x17E1260", VA = "0x17E1260")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x17E15AC", Offset = "0x17E15AC", VA = "0x17E15AC")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A530", Offset = "0x95A530")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x20000DA")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x40006D2")]
			Simple,
			[Token(Token = "0x40006D3")]
			Advanced
		}

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve redChannel;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useDepthCorrection;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve zCurve;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material ccMaterial;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material ccDepthMaterial;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Texture2D zCurveTex;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float saturation;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool selectiveCc;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color selectiveFromColor;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color selectiveToColor;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool updateTextures;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x17E1708", Offset = "0x17E1708", VA = "0x17E1708")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x17E1744", Offset = "0x17E1744", VA = "0x17E1744")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x17E1748", Offset = "0x17E1748", VA = "0x17E1748", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x17E19A8", Offset = "0x17E19A8", VA = "0x17E19A8")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x17E1DB8", Offset = "0x17E1DB8", VA = "0x17E1DB8")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x17E1DBC", Offset = "0x17E1DBC", VA = "0x17E1DBC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x17E20B8", Offset = "0x17E20B8", VA = "0x17E20B8")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000015")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A57C", Offset = "0x95A57C")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader shader;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material material;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture3D converted3DLut;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string basedOnTempTex;

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x17E26F4", Offset = "0x17E26F4", VA = "0x17E26F4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x17E2748", Offset = "0x17E2748", VA = "0x17E2748")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x17E27F0", Offset = "0x17E27F0", VA = "0x17E27F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x17E2898", Offset = "0x17E2898", VA = "0x17E2898")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x17E2A94", Offset = "0x17E2A94", VA = "0x17E2A94")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x17E2B88", Offset = "0x17E2B88", VA = "0x17E2B88")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x17E2E94", Offset = "0x17E2E94", VA = "0x17E2E94")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x17E3080", Offset = "0x17E3080", VA = "0x17E3080")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000016")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A5C8", Offset = "0x95A5C8")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x17E30E4", Offset = "0x17E30E4", VA = "0x17E30E4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x17E3260", Offset = "0x17E3260", VA = "0x17E3260")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95A614", Offset = "0x95A614")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A614", Offset = "0x95A614")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BAE8", Offset = "0x95BAE8")]
		public float intensity;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BB00", Offset = "0x95BB00")]
		public float threshold;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BB1C", Offset = "0x95BB1C")]
		public float blurSpread;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader separableBlurShader;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x17E3270", Offset = "0x17E3270", VA = "0x17E3270", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x17E32E0", Offset = "0x17E32E0", VA = "0x17E32E0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x17E3648", Offset = "0x17E3648", VA = "0x17E3648")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A6AC", Offset = "0x95A6AC")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BB34", Offset = "0x95BB34")]
		public float adaptationSpeed;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BB50", Offset = "0x95BB50")]
		public float limitMinimum;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BB68", Offset = "0x95BB68")]
		public float limitMaximum;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x17000007")]
		protected Material materialLum
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x17E366C", Offset = "0x17E366C", VA = "0x17E366C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		protected Material materialReduce
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x17E3730", Offset = "0x17E3730", VA = "0x17E3730")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		protected Material materialAdapt
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x17E37F4", Offset = "0x17E37F4", VA = "0x17E37F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		protected Material materialApply
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x17E38B8", Offset = "0x17E38B8", VA = "0x17E38B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x17E397C", Offset = "0x17E397C", VA = "0x17E397C")]
		private void Start()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x17E3A10", Offset = "0x17E3A10", VA = "0x17E3A10")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x17E3B60", Offset = "0x17E3B60", VA = "0x17E3B60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x17E3D88", Offset = "0x17E3D88", VA = "0x17E3D88")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x17E3FE4", Offset = "0x17E3FE4", VA = "0x17E3FE4")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x17E41F4", Offset = "0x17E41F4", VA = "0x17E41F4")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000019")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95A6F8", Offset = "0x95A6F8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A6F8", Offset = "0x95A6F8")]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float intensity;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int softness;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float spread;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader blurShader;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material blurMaterial;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader depthFetchShader;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material depthFetchMaterial;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader creaseApplyShader;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x17E426C", Offset = "0x17E426C", VA = "0x17E426C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x17E42E4", Offset = "0x17E42E4", VA = "0x17E42E4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x17E468C", Offset = "0x17E468C", VA = "0x17E468C")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95A790", Offset = "0x95A790")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A790", Offset = "0x95A790")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x20000DB")]
		public enum BlurType
		{
			[Token(Token = "0x40006D5")]
			DiscBlur,
			[Token(Token = "0x40006D6")]
			DX11
		}

		[Token(Token = "0x20000DC")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x40006D8")]
			Low,
			[Token(Token = "0x40006D9")]
			Medium,
			[Token(Token = "0x40006DA")]
			High
		}

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool visualizeFocus;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float focalLength;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float focalSize;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float aperture;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform focalTransform;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxBlurSize;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool highResolution;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BlurType blurType;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool nearBlur;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float foregroundOverlap;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader dofHdrShader;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material dofHdrMaterial;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dx11BokehShader;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float dx11BokehThreshold;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float dx11BokehScale;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float focalDistance01;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float internalBlurWidth;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Camera cachedCamera;

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x17E46B4", Offset = "0x17E46B4", VA = "0x17E46B4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x17E4854", Offset = "0x17E4854", VA = "0x17E4854")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x17E48CC", Offset = "0x17E48CC", VA = "0x17E48CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x17E49D4", Offset = "0x17E49D4", VA = "0x17E49D4")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x17E4738", Offset = "0x17E4738", VA = "0x17E4738")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x17E4A18", Offset = "0x17E4A18", VA = "0x17E4A18")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x17E4B74", Offset = "0x17E4B74", VA = "0x17E4B74")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x17E4E94", Offset = "0x17E4E94", VA = "0x17E4E94")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x17E64EC", Offset = "0x17E64EC", VA = "0x17E64EC")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95A828", Offset = "0x95A828")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A828", Offset = "0x95A828")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x20000DD")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x40006DC")]
			OnlyBackground = 1,
			[Token(Token = "0x40006DD")]
			BackgroundAndForeground
		}

		[Token(Token = "0x20000DE")]
		public enum DofResolution
		{
			[Token(Token = "0x40006DF")]
			High = 2,
			[Token(Token = "0x40006E0")]
			Medium,
			[Token(Token = "0x40006E1")]
			Low
		}

		[Token(Token = "0x20000DF")]
		public enum DofBlurriness
		{
			[Token(Token = "0x40006E3")]
			Low = 1,
			[Token(Token = "0x40006E4")]
			High = 2,
			[Token(Token = "0x40006E5")]
			VeryHigh = 4
		}

		[Token(Token = "0x20000E0")]
		public enum BokehDestination
		{
			[Token(Token = "0x40006E7")]
			Background = 1,
			[Token(Token = "0x40006E8")]
			Foreground,
			[Token(Token = "0x40006E9")]
			BackgroundAndForeground
		}

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DofResolution resolution;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool simpleTweakMode;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float focalPoint;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float smoothness;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalZDistance;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float focalZStartCurve;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float focalZEndCurve;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float focalStartCurve;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float focalEndCurve;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float focalDistance01;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform objectFocus;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float focalSize;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public DofBlurriness bluriness;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxBlurSpread;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Shader dofBlurShader;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material dofBlurMaterial;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dofShader;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dofMaterial;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool visualize;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float widthOverHeight;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float oneOverBaseSize;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool bokeh;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool bokehSupport;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Shader bokehShader;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float bokehScale;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float bokehIntensity;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public int bokehDownsample;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Material bokehMaterial;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Camera _camera;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTexture bokehSource;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x17E6550", Offset = "0x17E6550", VA = "0x17E6550")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x17E6624", Offset = "0x17E6624", VA = "0x17E6624", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x17E6728", Offset = "0x17E6728", VA = "0x17E6728")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x17E6954", Offset = "0x17E6954", VA = "0x17E6954")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x17E69CC", Offset = "0x17E69CC", VA = "0x17E69CC")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x17E6B28", Offset = "0x17E6B28", VA = "0x17E6B28")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x17E6B4C", Offset = "0x17E6B4C", VA = "0x17E6B4C")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x17E6B70", Offset = "0x17E6B70", VA = "0x17E6B70")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x17E7954", Offset = "0x17E7954", VA = "0x17E7954")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x17E8008", Offset = "0x17E8008", VA = "0x17E8008")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x17E8470", Offset = "0x17E8470", VA = "0x17E8470")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x17E7808", Offset = "0x17E7808", VA = "0x17E7808")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x17E7BF0", Offset = "0x17E7BF0", VA = "0x17E7BF0")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x17E82C4", Offset = "0x17E82C4", VA = "0x17E82C4")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x17E74D4", Offset = "0x17E74D4", VA = "0x17E74D4")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x17E8958", Offset = "0x17E8958", VA = "0x17E8958")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95A8C0", Offset = "0x95A8C0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A8C0", Offset = "0x95A8C0")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x20000E1")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x40006EB")]
			TriangleDepthNormals,
			[Token(Token = "0x40006EC")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x40006ED")]
			SobelDepth,
			[Token(Token = "0x40006EE")]
			SobelDepthThin,
			[Token(Token = "0x40006EF")]
			TriangleLuminance
		}

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public EdgeDetectMode mode;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sensitivityDepth;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sensitivityNormals;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float lumThreshold;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float edgeExp;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sampleDist;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float edgesOnly;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader edgeDetectShader;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x17E8A3C", Offset = "0x17E8A3C", VA = "0x17E8A3C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x17E8B74", Offset = "0x17E8B74", VA = "0x17E8B74")]
		private new void Start()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x17E8AB4", Offset = "0x17E8AB4", VA = "0x17E8AB4")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x17E8B80", Offset = "0x17E8B80", VA = "0x17E8B80")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x17E8B84", Offset = "0x17E8B84", VA = "0x17E8B84")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x17E8D70", Offset = "0x17E8D70", VA = "0x17E8D70")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x200001D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95A958", Offset = "0x95A958")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A958", Offset = "0x95A958")]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BB80", Offset = "0x95BB80")]
		public float strengthX;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BB98", Offset = "0x95BB98")]
		public float strengthY;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader fishEyeShader;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material fisheyeMaterial;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x17E8DD0", Offset = "0x17E8DD0", VA = "0x17E8DD0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x17E8E28", Offset = "0x17E8E28", VA = "0x17E8E28")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x17E8F98", Offset = "0x17E8F98", VA = "0x17E8F98")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x200001E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95A9F0", Offset = "0x95A9F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95A9F0", Offset = "0x95A9F0")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95BBB0", Offset = "0x95BBB0")]
		public bool distanceFog;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95BBE8", Offset = "0x95BBE8")]
		public bool excludeFarPixels;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95BC20", Offset = "0x95BC20")]
		public bool useRadialDistance;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95BC58", Offset = "0x95BC58")]
		public bool heightFog;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95BC90", Offset = "0x95BC90")]
		public float height;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BCC8", Offset = "0x95BCC8")]
		public float heightDensity;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95BCE4", Offset = "0x95BCE4")]
		public float startDistance;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fogShader;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fogMaterial;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x17E8FBC", Offset = "0x17E8FBC", VA = "0x17E8FBC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x17E9014", Offset = "0x17E9014", VA = "0x17E9014")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x17E983C", Offset = "0x17E983C", VA = "0x17E983C")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x17E99AC", Offset = "0x17E99AC", VA = "0x17E99AC")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x200001F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95AA88", Offset = "0x95AA88")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BD1C", Offset = "0x95BD1C")]
		public float rampOffset;

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x17E99D8", Offset = "0x17E99D8", VA = "0x17E99D8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x17E9AB4", Offset = "0x17E9AB4", VA = "0x17E9AB4")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95AAD4", Offset = "0x95AAD4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95AAD4", Offset = "0x95AAD4")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x1700000B")]
		protected Material material
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x17E319C", Offset = "0x17E319C", VA = "0x17E319C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x17E9ABC", Offset = "0x17E9ABC", VA = "0x17E9ABC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x17E9B6C", Offset = "0x17E9B6C", VA = "0x17E9B6C", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x17E3268", Offset = "0x17E3268", VA = "0x17E3268")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95AB5C", Offset = "0x95AB5C")]
	public class ImageEffects
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x17E9C1C", Offset = "0x17E9C1C", VA = "0x17E9C1C")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x17E9E98", Offset = "0x17E9E98", VA = "0x17E9E98")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95D01C", Offset = "0x95D01C")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x17E9F10", Offset = "0x17E9F10", VA = "0x17E9F10")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95D054", Offset = "0x95D054")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x17E9F90", Offset = "0x17E9F90", VA = "0x17E9F90")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95AB94", Offset = "0x95AB94")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95AB94", Offset = "0x95AB94")]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BD34", Offset = "0x95BD34")]
		public float blurAmount;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool IsLearp;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float AnimatDuration;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float TargetAmount;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float OriAmount;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float timer;

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x17E9F98", Offset = "0x17E9F98", VA = "0x17E9F98", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x17E9FDC", Offset = "0x17E9FDC", VA = "0x17E9FDC", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x17EA050", Offset = "0x17EA050", VA = "0x17EA050")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x17EA3D4", Offset = "0x17EA3D4", VA = "0x17EA3D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x17EA464", Offset = "0x17EA464", VA = "0x17EA464")]
		public void PlayBlurAnimation(float duration, float ori, float target)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x17EA480", Offset = "0x17EA480", VA = "0x17EA480")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95AC2C", Offset = "0x95AC2C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95AC2C", Offset = "0x95AC2C")]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float intensityMultiplier;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float generalIntensity;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float blackIntensity;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float whiteIntensity;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float midGrey;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool dx11Grain;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float softness;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool monochrome;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 intensities;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 tiling;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float monochromeTiling;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public FilterMode filterMode;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader noiseShader;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material noiseMaterial;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x17EA4A0", Offset = "0x17EA4A0", VA = "0x17EA4A0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x17EA518", Offset = "0x17EA518", VA = "0x17EA518")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x17EAE80", Offset = "0x17EAE80", VA = "0x17EAE80")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x17EB1FC", Offset = "0x17EB1FC", VA = "0x17EB1FC")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95ACC4", Offset = "0x95ACC4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95ACC4", Offset = "0x95ACC4")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BD50", Offset = "0x95BD50")]
		public float grainIntensityMin;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BD68", Offset = "0x95BD68")]
		public float grainIntensityMax;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BD80", Offset = "0x95BD80")]
		public float grainSize;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BDA0", Offset = "0x95BDA0")]
		public float scratchIntensityMin;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BDB8", Offset = "0x95BDB8")]
		public float scratchIntensityMax;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BDD0", Offset = "0x95BDD0")]
		public float scratchFPS;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BDE8", Offset = "0x95BDE8")]
		public float scratchJitter;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x1700000C")]
		protected Material material
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x17EB454", Offset = "0x17EB454", VA = "0x17EB454")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x17EB314", Offset = "0x17EB314", VA = "0x17EB314")]
		protected void Start()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x17EB5B0", Offset = "0x17EB5B0", VA = "0x17EB5B0")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x17EB6B4", Offset = "0x17EB6B4", VA = "0x17EB6B4")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x17EB7F0", Offset = "0x17EB7F0", VA = "0x17EB7F0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x17EBB38", Offset = "0x17EBB38", VA = "0x17EBB38")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95AD5C", Offset = "0x95AD5C")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x17DB950", Offset = "0x17DB950", VA = "0x17DB950")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x17DB07C", Offset = "0x17DB07C", VA = "0x17DB07C")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x17EBB6C", Offset = "0x17EBB6C", VA = "0x17EBB6C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x17EBB78", Offset = "0x17EBB78", VA = "0x17EBB78")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x17EBB80", Offset = "0x17EBB80", VA = "0x17EBB80", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x17E1738", Offset = "0x17E1738", VA = "0x17E1738")]
		protected void Start()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x17DAF58", Offset = "0x17DAF58", VA = "0x17DAF58")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x17DFB8C", Offset = "0x17DFB8C", VA = "0x17DFB8C")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x17EBC30", Offset = "0x17EBC30", VA = "0x17EBC30")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x17DB298", Offset = "0x17DB298", VA = "0x17DB298")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x17EBC38", Offset = "0x17EBC38", VA = "0x17EBC38")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x17DB26C", Offset = "0x17DB26C", VA = "0x17DB26C")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x17EBE38", Offset = "0x17EBE38", VA = "0x17EBE38")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x17DB8B4", Offset = "0x17DB8B4", VA = "0x17DB8B4")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95ADD0", Offset = "0x95ADD0")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x17EC1B4", Offset = "0x17EC1B4", VA = "0x17EC1B4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x17EC220", Offset = "0x17EC220", VA = "0x17EC220")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x17EC49C", Offset = "0x17EC49C", VA = "0x17EC49C")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x17EC814", Offset = "0x17EC814", VA = "0x17EC814")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x17EC9C0", Offset = "0x17EC9C0", VA = "0x17EC9C0")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x2000027")]
	internal class Quads
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x17EC9C8", Offset = "0x17EC9C8", VA = "0x17EC9C8")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x17E6784", Offset = "0x17E6784", VA = "0x17E6784")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x17E8698", Offset = "0x17E8698", VA = "0x17E8698")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x17ECAEC", Offset = "0x17ECAEC", VA = "0x17ECAEC")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x17ED020", Offset = "0x17ED020", VA = "0x17ED020")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95AE44", Offset = "0x95AE44")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95AE44", Offset = "0x95AE44")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x20000E2")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x40006F1")]
			Additive,
			[Token(Token = "0x40006F2")]
			ScreenBlend,
			[Token(Token = "0x40006F3")]
			Multiply,
			[Token(Token = "0x40006F4")]
			Overlay,
			[Token(Token = "0x40006F5")]
			AlphaBlend
		}

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float intensity;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D texture;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader overlayShader;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material overlayMaterial;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture2D result;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int x;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int y;

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x17ED02C", Offset = "0x17ED02C", VA = "0x17ED02C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x17ED2C8", Offset = "0x17ED2C8", VA = "0x17ED2C8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x17ED0F0", Offset = "0x17ED0F0", VA = "0x17ED0F0")]
		private Texture2D ScaleTexture(Texture2D source, int targetWidth, int targetHeight)
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x17ED430", Offset = "0x17ED430", VA = "0x17ED430")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95AEDC", Offset = "0x95AEDC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95AEDC", Offset = "0x95AEDC")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BE00", Offset = "0x95BE00")]
		public float intensity;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BE18", Offset = "0x95BE18")]
		public float radius;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BE34", Offset = "0x95BE34")]
		public int blurIterations;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BE4C", Offset = "0x95BE4C")]
		public float blurFilterDistance;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BE64", Offset = "0x95BE64")]
		public int downsample;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D rand;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader aoShader;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material aoMaterial;

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x17ED45C", Offset = "0x17ED45C", VA = "0x17ED45C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x17ED4B4", Offset = "0x17ED4B4", VA = "0x17ED4B4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x17ED55C", Offset = "0x17ED55C", VA = "0x17ED55C")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x17EDB30", Offset = "0x17EDB30", VA = "0x17EDB30")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95AF74", Offset = "0x95AF74")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95AF74", Offset = "0x95AF74")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x20000E3")]
		public enum SSAOSamples
		{
			[Token(Token = "0x40006F7")]
			Low,
			[Token(Token = "0x40006F8")]
			Medium,
			[Token(Token = "0x40006F9")]
			High
		}

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BE7C", Offset = "0x95BE7C")]
		public float m_Radius;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BE98", Offset = "0x95BE98")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BEB0", Offset = "0x95BEB0")]
		public int m_Blur;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BEC8", Offset = "0x95BEC8")]
		public int m_Downsampling;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BEE0", Offset = "0x95BEE0")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BEFC", Offset = "0x95BEFC")]
		public float m_MinZ;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x17EDB5C", Offset = "0x17EDB5C", VA = "0x17EDB5C")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x17EDC0C", Offset = "0x17EDC0C", VA = "0x17EDC0C")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x17EDCA8", Offset = "0x17EDCA8", VA = "0x17EDCA8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x17EDCB0", Offset = "0x17EDCB0", VA = "0x17EDCB0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x17EDE44", Offset = "0x17EDE44", VA = "0x17EDE44")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x17EDD88", Offset = "0x17EDD88", VA = "0x17EDD88")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x17EDEB8", Offset = "0x17EDEB8", VA = "0x17EDEB8")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x17EE574", Offset = "0x17EE574", VA = "0x17EE574")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95B00C", Offset = "0x95B00C")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x17EE5A8", Offset = "0x17EE5A8", VA = "0x17EE5A8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x17EE638", Offset = "0x17EE638", VA = "0x17EE638")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95B058", Offset = "0x95B058")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95B058", Offset = "0x95B058")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x20000E4")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x40006FB")]
			Low,
			[Token(Token = "0x40006FC")]
			Normal,
			[Token(Token = "0x40006FD")]
			High
		}

		[Token(Token = "0x20000E5")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x40006FF")]
			Screen,
			[Token(Token = "0x4000700")]
			Add
		}

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform sunTransform;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int radialBlurIterations;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color sunColor;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Color sunThreshold;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float sunShaftIntensity;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float maxRadius;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool useDepthTexture;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader sunShaftsShader;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader simpleClearShader;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material simpleClearMaterial;

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x17EE640", Offset = "0x17EE640", VA = "0x17EE640", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x17EE6A8", Offset = "0x17EE6A8", VA = "0x17EE6A8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x17EEE94", Offset = "0x17EEE94", VA = "0x17EEE94")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95B0F0", Offset = "0x95B0F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95B0F0", Offset = "0x95B0F0")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x20000E6")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x4000702")]
			TiltShiftMode,
			[Token(Token = "0x4000703")]
			IrisMode
		}

		[Token(Token = "0x20000E7")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x4000705")]
			Preview,
			[Token(Token = "0x4000706")]
			Normal,
			[Token(Token = "0x4000707")]
			High
		}

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TiltShiftMode mode;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TiltShiftQuality quality;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BF18", Offset = "0x95BF18")]
		public float blurArea;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BF30", Offset = "0x95BF30")]
		public float maxBlurSize;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BF48", Offset = "0x95BF48")]
		public int downsample;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader tiltShiftShader;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x17EEF34", Offset = "0x17EEF34", VA = "0x17EEF34", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x17EEF8C", Offset = "0x17EEF8C", VA = "0x17EEF8C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x17EF21C", Offset = "0x17EF21C", VA = "0x17EF21C")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95B178", Offset = "0x95B178")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95B178", Offset = "0x95B178")]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x20000E8")]
		public enum TonemapperType
		{
			[Token(Token = "0x4000709")]
			SimpleReinhard,
			[Token(Token = "0x400070A")]
			UserCurve,
			[Token(Token = "0x400070B")]
			Hable,
			[Token(Token = "0x400070C")]
			Photographic,
			[Token(Token = "0x400070D")]
			OptimizedHejiDawson,
			[Token(Token = "0x400070E")]
			AdaptiveReinhard,
			[Token(Token = "0x400070F")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x20000E9")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x4000711")]
			Square16 = 0x10,
			[Token(Token = "0x4000712")]
			Square32 = 0x20,
			[Token(Token = "0x4000713")]
			Square64 = 0x40,
			[Token(Token = "0x4000714")]
			Square128 = 0x80,
			[Token(Token = "0x4000715")]
			Square256 = 0x100,
			[Token(Token = "0x4000716")]
			Square512 = 0x200,
			[Token(Token = "0x4000717")]
			Square1024 = 0x400
		}

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TonemapperType type;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Texture2D curveTex;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float exposureAdjustment;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float middleGrey;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float white;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float adaptionSpeed;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader tonemapper;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material tonemapMaterial;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RenderTexture rt;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x17EF240", Offset = "0x17EF240", VA = "0x17EF240", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x17EF37C", Offset = "0x17EF37C", VA = "0x17EF37C")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x17EF640", Offset = "0x17EF640", VA = "0x17EF640")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x17EF798", Offset = "0x17EF798", VA = "0x17EF798")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x17EF888", Offset = "0x17EF888", VA = "0x17EF888")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x17F00AC", Offset = "0x17F00AC", VA = "0x17F00AC")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x200002F")]
	internal class Triangles
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x17F00E4", Offset = "0x17F00E4", VA = "0x17F00E4")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x17F0220", Offset = "0x17F0220", VA = "0x17F0220")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x17F03F0", Offset = "0x17F03F0", VA = "0x17F03F0")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x17F06B0", Offset = "0x17F06B0", VA = "0x17F06B0")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x17F0AE0", Offset = "0x17F0AE0", VA = "0x17F0AE0")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95B210", Offset = "0x95B210")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BF60", Offset = "0x95BF60")]
		public float angle;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x17F0AEC", Offset = "0x17F0AEC", VA = "0x17F0AEC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x17F0B30", Offset = "0x17F0B30", VA = "0x17F0B30")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95B25C", Offset = "0x95B25C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95B25C", Offset = "0x95B25C")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x20000EA")]
		public enum AberrationMode
		{
			[Token(Token = "0x4000719")]
			Simple,
			[Token(Token = "0x400071A")]
			Advanced
		}

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AberrationMode mode;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float intensity;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float chromaticAberration;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float axialAberration;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float blur;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float blurSpread;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float luminanceDependency;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blurDistance;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader vignetteShader;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader chromAberrationShader;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x17F0BAC", Offset = "0x17F0BAC", VA = "0x17F0BAC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x17F0C30", Offset = "0x17F0C30", VA = "0x17F0C30")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x17F125C", Offset = "0x17F125C", VA = "0x17F125C")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95B2F4", Offset = "0x95B2F4")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1D2B870", Offset = "0x1D2B870", VA = "0x1D2B870")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1D2B8BC", Offset = "0x1D2B8BC", VA = "0x1D2B8BC")]
		public Vortex()
		{
		}
	}
}
namespace Sword
{
	[Token(Token = "0x2000033")]
	public class Delay : SBehaviour
	{
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float delayTime;

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x11857C4", Offset = "0x11857C4", VA = "0x11857C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x118583C", Offset = "0x118583C", VA = "0x118583C")]
		private void DelayFunc()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1185864", Offset = "0x1185864", VA = "0x1185864", Slot = "5")]
		protected override void InitMono()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1185868", Offset = "0x1185868", VA = "0x1185868", Slot = "6")]
		public override void DestroyMono()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x118586C", Offset = "0x118586C", VA = "0x118586C")]
		public Delay()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class EffectDelayActive : SBehaviourForUpdate
	{
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject[] objs;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float[] Delays;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DateTime last;

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x118587C", Offset = "0x118587C", VA = "0x118587C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1185950", Offset = "0x1185950", VA = "0x1185950", Slot = "7")]
		public override void OnFrame()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1185A84", Offset = "0x1185A84", VA = "0x1185A84", Slot = "5")]
		protected override void InitMono()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1185A88", Offset = "0x1185A88", VA = "0x1185A88", Slot = "6")]
		public override void DestroyMono()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1185A8C", Offset = "0x1185A8C", VA = "0x1185A8C")]
		public EffectDelayActive()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class EffectDelayHide : SBehaviour
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float Delay;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 Scale;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1185A94", Offset = "0x1185A94", VA = "0x1185A94", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1185AD0", Offset = "0x1185AD0", VA = "0x1185AD0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1185B4C", Offset = "0x1185B4C", VA = "0x1185B4C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1185BA0", Offset = "0x1185BA0", VA = "0x1185BA0")]
		private void Hide()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1185C08", Offset = "0x1185C08", VA = "0x1185C08", Slot = "5")]
		protected override void InitMono()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1185C0C", Offset = "0x1185C0C", VA = "0x1185C0C", Slot = "6")]
		public override void DestroyMono()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1185C10", Offset = "0x1185C10", VA = "0x1185C10")]
		public EffectDelayHide()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class UvAnimator : SBehaviour
	{
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float tileX;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float tileY;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float fps;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float delayTime;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool isLoop;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int playTimes;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool isPlay;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _playCount;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool _isStartOff;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _offsetIndex;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Renderer mRender;

		[Token(Token = "0x1700000D")]
		private Renderer Render
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x17DA8E4", Offset = "0x17DA8E4", VA = "0x17DA8E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x17DA84C", Offset = "0x17DA84C", VA = "0x17DA84C")]
		private void Start()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x17DA944", Offset = "0x17DA944", VA = "0x17DA944")]
		private void Update()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x17DAB64", Offset = "0x17DAB64", VA = "0x17DAB64")]
		private void DelayFunc()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x17DAB8C", Offset = "0x17DAB8C", VA = "0x17DAB8C", Slot = "5")]
		protected override void InitMono()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x17DAB90", Offset = "0x17DAB90", VA = "0x17DAB90", Slot = "6")]
		public override void DestroyMono()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x17DAB94", Offset = "0x17DAB94", VA = "0x17DAB94")]
		public UvAnimator()
		{
		}
	}
	[Token(Token = "0x2000037")]
	internal class UvFlow : SBehaviour
	{
		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float xSpeed;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float ySpeed;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector2 Start;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector2 End;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 mUV;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material mMat;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float curX;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float curY;

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x17DABB8", Offset = "0x17DABB8", VA = "0x17DABB8", Slot = "5")]
		protected override void InitMono()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x17DAC50", Offset = "0x17DAC50", VA = "0x17DAC50")]
		public void Update()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x17DADA0", Offset = "0x17DADA0", VA = "0x17DADA0", Slot = "6")]
		public override void DestroyMono()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x17DADA4", Offset = "0x17DADA4", VA = "0x17DADA4")]
		public UvFlow()
		{
		}
	}
	[Token(Token = "0x2000038")]
	internal class ReyunHttp
	{
		[Serializable]
		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95B940", Offset = "0x95B940")]
		private sealed class <>c
		{
			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static HttpHandler <>9__7_0;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static HttpHandler <>9__8_0;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static HttpHandler <>9__9_0;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static HttpHandler <>9__10_0;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static HttpHandler <>9__11_0;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static HttpHandler <>9__12_0;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static HttpHandler <>9__13_0;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static HttpHandler <>9__14_0;

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x1185CE8", Offset = "0x1185CE8", VA = "0x1185CE8")]
			public <>c()
			{
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x1185CF0", Offset = "0x1185CF0", VA = "0x1185CF0")]
			internal void <Init>b__7_0(HttpInfo info)
			{
			}

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x1185D98", Offset = "0x1185D98", VA = "0x1185D98")]
			internal void <StartUp>b__8_0(HttpInfo info)
			{
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x1185E40", Offset = "0x1185E40", VA = "0x1185E40")]
			internal void <Register>b__9_0(HttpInfo info)
			{
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x1185EE8", Offset = "0x1185EE8", VA = "0x1185EE8")]
			internal void <Loggedin>b__10_0(HttpInfo info)
			{
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x1185F90", Offset = "0x1185F90", VA = "0x1185F90")]
			internal void <Payment>b__11_0(HttpInfo info)
			{
			}

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x1186038", Offset = "0x1186038", VA = "0x1186038")]
			internal void <Heartbeat>b__12_0(HttpInfo info)
			{
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x11860E0", Offset = "0x11860E0", VA = "0x11860E0")]
			internal void <SetEvent>b__13_0(HttpInfo info)
			{
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x1186188", Offset = "0x1186188", VA = "0x1186188")]
			internal void <SetEconomy>b__14_0(HttpInfo info)
			{
			}
		}

		[Token(Token = "0x40001FA")]
		public const int TIME_OUT_INTTERVAL = 30000;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string root;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string appid;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string channelId;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string pid;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string serverid;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int level;

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1184FE4", Offset = "0x1184FE4", VA = "0x1184FE4")]
		public void Init(string appid, string channelId)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1184FE8", Offset = "0x1184FE8", VA = "0x1184FE8")]
		public void StartUp()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x11850B8", Offset = "0x11850B8", VA = "0x11850B8")]
		public void Register(string pid, string serverid)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1185188", Offset = "0x1185188", VA = "0x1185188")]
		public void Loggedin(string pid, string serverid, int level)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x11852AC", Offset = "0x11852AC", VA = "0x11852AC")]
		public void Payment(string transactionid, string paymenttype, string currencytype, string currencyamount, string virtualcoinamount, string iapname, string iapamount, int level)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1185C20", Offset = "0x1185C20", VA = "0x1185C20")]
		public void Heartbeat()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1185458", Offset = "0x1185458", VA = "0x1185458")]
		public void SetEvent(string eventName, Dictionary<string, string> dict)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1185384", Offset = "0x1185384", VA = "0x1185384")]
		public void SetEconomy(string itemName, int itemAmount, float itemTotalPrice)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1185764", Offset = "0x1185764", VA = "0x1185764")]
		public ReyunHttp()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1185C80", Offset = "0x1185C80", VA = "0x1185C80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D0BC", Offset = "0x95D0BC")]
		private void <Init>b__7_1(object o)
		{
		}
	}
}
namespace DragonBones
{
	[Token(Token = "0x2000039")]
	public class Animation : BaseObject
	{
		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float timeScale;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _lockUpdate;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _animationDirty;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float _inheritTimeScale;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<string> _animationNames;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<AnimationState> _animationStates;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Dictionary<string, AnimationData> _animations;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Armature _armature;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AnimationConfig _animationConfig;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AnimationState _lastAnimationState;

		[Token(Token = "0x1700000E")]
		public bool isPlaying
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0xE99054", Offset = "0xE99054", VA = "0xE99054")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		public bool isCompleted
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0xE99170", Offset = "0xE99170", VA = "0xE99170")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		public string lastAnimationName
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0xE992A4", Offset = "0xE992A4", VA = "0xE992A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public List<string> animationNames
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0xE99300", Offset = "0xE99300", VA = "0xE99300")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public Dictionary<string, AnimationData> animations
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0xE99308", Offset = "0xE99308", VA = "0xE99308")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0xE99310", Offset = "0xE99310", VA = "0xE99310")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public AnimationConfig animationConfig
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0xE994C0", Offset = "0xE994C0", VA = "0xE994C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public AnimationState lastAnimationState
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0xE994F8", Offset = "0xE994F8", VA = "0xE994F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xE96044", Offset = "0xE96044", VA = "0xE96044", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xE961AC", Offset = "0xE961AC", VA = "0xE961AC")]
		private void _FadeOut(AnimationConfig animationConfig)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xE968E0", Offset = "0xE968E0", VA = "0xE968E0")]
		internal void Init(Armature armature)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xE9696C", Offset = "0xE9696C", VA = "0xE9696C")]
		internal void AdvanceTime(float passedTime)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xE9766C", Offset = "0xE9766C", VA = "0xE9766C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xE977A4", Offset = "0xE977A4", VA = "0xE977A4")]
		public void Stop([Optional] string animationName)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xE97990", Offset = "0xE97990", VA = "0xE97990")]
		public AnimationState PlayConfig(AnimationConfig animationConfig)
		{
			return null;
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xE98B4C", Offset = "0xE98B4C", VA = "0xE98B4C")]
		public AnimationState Play([Optional] string animationName, int playTimes = -1)
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xE984C0", Offset = "0xE984C0", VA = "0xE984C0")]
		public AnimationState FadeIn(string animationName, float fadeInTime = -1f, int playTimes = -1, int layer = 0, [Optional] string group, AnimationFadeOutMode fadeOutMode = AnimationFadeOutMode.SameLayerAndGroup)
		{
			return null;
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xE98D14", Offset = "0xE98D14", VA = "0xE98D14")]
		public AnimationState GotoAndPlayByTime(string animationName, float time = 0f, int playTimes = -1)
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xE98DAC", Offset = "0xE98DAC", VA = "0xE98DAC")]
		public AnimationState GotoAndPlayByFrame(string animationName, uint frame = 0u, int playTimes = -1)
		{
			return null;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xE98EC8", Offset = "0xE98EC8", VA = "0xE98EC8")]
		public AnimationState GotoAndPlayByProgress(string animationName, float progress = 0f, int playTimes = -1)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xE98FD4", Offset = "0xE98FD4", VA = "0xE98FD4")]
		public AnimationState GotoAndStopByTime(string animationName, float time = 0f)
		{
			return null;
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xE98FFC", Offset = "0xE98FFC", VA = "0xE98FFC")]
		public AnimationState GotoAndStopByFrame(string animationName, uint frame = 0u)
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xE99024", Offset = "0xE99024", VA = "0xE99024")]
		public AnimationState GotoAndStopByProgress(string animationName, float progress = 0f)
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xE978CC", Offset = "0xE978CC", VA = "0xE978CC")]
		public AnimationState GetState(string animationName)
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xE98458", Offset = "0xE98458", VA = "0xE98458")]
		public bool HasAnimation(string animationName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xE9904C", Offset = "0xE9904C", VA = "0xE9904C")]
		public List<AnimationState> GetStates()
		{
			return null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xE99500", Offset = "0xE99500", VA = "0xE99500")]
		public Animation()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class AnimationState : BaseObject
	{
		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool actionEnabled;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool additiveBlending;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public bool displayControl;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
		public bool resetToPose;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int playTimes;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int layer;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float timeScale;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float autoFadeOutTime;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float fadeTotalTime;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string name;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string group;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _timelineDirty;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal int _playheadState;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal int _fadeState;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		internal int _subFadeState;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal float _position;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		internal float _duration;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _fadeTime;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _time;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal float _fadeProgress;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float _weightResult;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal readonly BlendState _blendState;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly List<string> _boneMask;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly List<BoneTimelineState> _boneTimelines;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly List<SlotTimelineState> _slotTimelines;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly List<ConstraintTimelineState> _constraintTimelines;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly List<TimelineState> _poseTimelines;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly Dictionary<string, BonePose> _bonePoses;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AnimationData _animationData;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Armature _armature;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal ActionTimelineState _actionTimeline;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ZOrderTimelineState _zOrderTimeline;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public AnimationState _parent;

		[Token(Token = "0x17000015")]
		public bool isFadeIn
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0xE9D7A8", Offset = "0xE9D7A8", VA = "0xE9D7A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000016")]
		public bool isFadeOut
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0xE9D7B4", Offset = "0xE9D7B4", VA = "0xE9D7B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public bool isFadeComplete
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0xE9D7C4", Offset = "0xE9D7C4", VA = "0xE9D7C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		public bool isPlaying
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0xE98CB0", Offset = "0xE98CB0", VA = "0xE98CB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000019")]
		public bool isCompleted
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0xE98CE4", Offset = "0xE98CE4", VA = "0xE98CE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		public int currentPlayTimes
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xE9D7D4", Offset = "0xE9D7D4", VA = "0xE9D7D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001B")]
		public float totalTime
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0xE9D7F0", Offset = "0xE9D7F0", VA = "0xE9D7F0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001C")]
		public float currentTime
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0xE9D7F8", Offset = "0xE9D7F8", VA = "0xE9D7F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xE9D814", Offset = "0xE9D814", VA = "0xE9D814")]
			set
			{
			}
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xE9ACD4", Offset = "0xE9ACD4", VA = "0xE9ACD4", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xE9B278", Offset = "0xE9B278", VA = "0xE9B278")]
		private void _UpdateTimelines()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xE9B62C", Offset = "0xE9B62C", VA = "0xE9B62C")]
		private void _UpdateBoneAndSlotTimelines()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xE9CF24", Offset = "0xE9CF24", VA = "0xE9CF24")]
		private void _AdvanceFadeTime(float passedTime)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xE980FC", Offset = "0xE980FC", VA = "0xE980FC")]
		internal void Init(Armature armature, AnimationData animationData, AnimationConfig animationConfig)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xE96F80", Offset = "0xE96F80", VA = "0xE96F80")]
		internal void AdvanceTime(float passedTime, float cacheFrameRate)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xE98D08", Offset = "0xE98D08", VA = "0xE98D08")]
		public void Play()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xE97980", Offset = "0xE97980", VA = "0xE97980")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xE965C0", Offset = "0xE965C0", VA = "0xE965C0")]
		public void FadeOut(float fadeOutTime, bool pausePlayhead = true)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xE9CEA0", Offset = "0xE9CEA0", VA = "0xE9CEA0")]
		public bool ContainsBoneMask(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xE9D224", Offset = "0xE9D224", VA = "0xE9D224")]
		public void AddBoneMask(string boneName, bool recursive = true)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xE9D438", Offset = "0xE9D438", VA = "0xE9D438")]
		public void RemoveBoneMask(string boneName, bool recursive = true)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xE9D744", Offset = "0xE9D744", VA = "0xE9D744")]
		public void RemoveAllBoneMask()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xE9DA7C", Offset = "0xE9DA7C", VA = "0xE9DA7C")]
		public AnimationState()
		{
		}
	}
	[Token(Token = "0x200003B")]
	internal class BonePose : BaseObject
	{
		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly Transform current;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly Transform delta;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly Transform result;

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xEE5474", Offset = "0xEE5474", VA = "0xEE5474", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xEE54C0", Offset = "0xEE54C0", VA = "0xEE54C0")]
		public BonePose()
		{
		}
	}
	[Token(Token = "0x200003C")]
	internal class BlendState
	{
		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool dirty;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int layer;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float leftWeight;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float layerWeight;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float blendWeight;

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xEE3EC4", Offset = "0xEE3EC4", VA = "0xEE3EC4")]
		public int Update(float weight, int p_layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xEE3F48", Offset = "0xEE3F48", VA = "0xEE3F48")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xEE3F58", Offset = "0xEE3F58", VA = "0xEE3F58")]
		public BlendState()
		{
		}
	}
	[Token(Token = "0x200003D")]
	internal enum TweenState
	{
		[Token(Token = "0x4000236")]
		None,
		[Token(Token = "0x4000237")]
		Once,
		[Token(Token = "0x4000238")]
		Always
	}
	[Token(Token = "0x200003E")]
	internal abstract class TimelineState : BaseObject
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int playState;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int currentPlayTimes;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float currentTime;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected TweenState _tweenState;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		protected uint _frameRate;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected int _frameValueOffset;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		protected uint _frameCount;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected uint _frameOffset;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected int _frameIndex;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected float _frameRateR;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float _position;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected float _duration;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected float _timeScale;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected float _timeOffset;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected DragonBonesData _dragonBonesData;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected AnimationData _animationData;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected TimelineData _timelineData;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected Armature _armature;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected AnimationState _animationState;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected TimelineState _actionTimeline;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected short[] _frameArray;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected short[] _frameIntArray;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected float[] _frameFloatArray;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected ushort[] _timelineArray;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected List<uint> _frameIndices;

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x11791BC", Offset = "0x11791BC", VA = "0x11791BC", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000179")]
		protected abstract void _OnArriveAtFrame();

		[Token(Token = "0x600017A")]
		protected abstract void _OnUpdateFrame();

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1179208", Offset = "0x1179208", VA = "0x1179208")]
		protected bool _SetCurrentTime(float passedTime)
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1179418", Offset = "0x1179418", VA = "0x1179418", Slot = "7")]
		public virtual void Init(Armature armature, AnimationState animationState, TimelineData timelineData)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x117957C", Offset = "0x117957C", VA = "0x117957C", Slot = "8")]
		public virtual void FadeOut()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1178344", Offset = "0x1178344", VA = "0x1178344", Slot = "9")]
		public virtual void Update(float passedTime)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1179580", Offset = "0x1179580", VA = "0x1179580")]
		protected TimelineState()
		{
		}
	}
	[Token(Token = "0x200003F")]
	internal abstract class TweenTimelineState : TimelineState
	{
		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected TweenType _tweenType;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		protected int _curveCount;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected float _framePosition;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		protected float _frameDurationR;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected float _tweenProgress;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		protected float _tweenEasing;

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1179CCC", Offset = "0x1179CCC", VA = "0x1179CCC")]
		private static float _GetEasingValue(TweenType tweenType, float progress, float easing)
		{
			return default(float);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1179E10", Offset = "0x1179E10", VA = "0x1179E10")]
		private static float _GetEasingCurveValue(float progress, short[] samples, int count, int offset)
		{
			return default(float);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1178808", Offset = "0x1178808", VA = "0x1178808", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x11777B8", Offset = "0x11777B8", VA = "0x11777B8", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1177CE8", Offset = "0x1177CE8", VA = "0x1177CE8", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1178854", Offset = "0x1178854", VA = "0x1178854")]
		protected TweenTimelineState()
		{
		}
	}
	[Token(Token = "0x2000040")]
	internal abstract class BoneTimelineState : TweenTimelineState
	{
		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Bone bone;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public BonePose bonePose;

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xEE5ABC", Offset = "0xEE5ABC", VA = "0xEE5ABC", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xEE5AE4", Offset = "0xEE5AE4", VA = "0xEE5AE4")]
		public void Blend(int state)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xEE536C", Offset = "0xEE536C", VA = "0xEE536C")]
		protected BoneTimelineState()
		{
		}
	}
	[Token(Token = "0x2000041")]
	internal abstract class SlotTimelineState : TweenTimelineState
	{
		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Slot slot;

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1177118", Offset = "0x1177118", VA = "0x1177118", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x11785C4", Offset = "0x11785C4", VA = "0x11785C4")]
		protected SlotTimelineState()
		{
		}
	}
	[Token(Token = "0x2000042")]
	internal abstract class ConstraintTimelineState : TweenTimelineState
	{
		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Constraint constraint;

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xEE66B4", Offset = "0xEE66B4", VA = "0xEE66B4", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xEE66DC", Offset = "0xEE66DC", VA = "0xEE66DC")]
		protected ConstraintTimelineState()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public interface IAnimatable
	{
		[Token(Token = "0x1700001D")]
		WorldClock clock
		{
			[Token(Token = "0x600018E")]
			get;
			[Token(Token = "0x600018F")]
			set;
		}

		[Token(Token = "0x600018D")]
		void AdvanceTime(float passedTime);
	}
	[Token(Token = "0x2000044")]
	internal class ActionTimelineState : TimelineState
	{
		[Token(Token = "0x6000190")]
		[Address(RVA = "0xE951F0", Offset = "0xE951F0", VA = "0xE951F0")]
		private void _OnCrossFrame(int frameIndex)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xE955F8", Offset = "0xE955F8", VA = "0xE955F8", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xE955FC", Offset = "0xE955FC", VA = "0xE955FC", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xE95600", Offset = "0xE95600", VA = "0xE95600", Slot = "9")]
		public override void Update(float passedTime)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xE96010", Offset = "0xE96010", VA = "0xE96010")]
		public void SetCurrentTime(float value)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xE9603C", Offset = "0xE9603C", VA = "0xE9603C")]
		public ActionTimelineState()
		{
		}
	}
	[Token(Token = "0x2000045")]
	internal class ZOrderTimelineState : TimelineState
	{
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x118461C", Offset = "0x118461C", VA = "0x118461C", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1184698", Offset = "0x1184698", VA = "0x1184698", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x118469C", Offset = "0x118469C", VA = "0x118469C")]
		public ZOrderTimelineState()
		{
		}
	}
	[Token(Token = "0x2000046")]
	internal class BoneAllTimelineState : BoneTimelineState
	{
		[Token(Token = "0x6000199")]
		[Address(RVA = "0xEE4F34", Offset = "0xEE4F34", VA = "0xEE4F34", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xEE51CC", Offset = "0xEE51CC", VA = "0xEE51CC", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xEE52C0", Offset = "0xEE52C0", VA = "0xEE52C0", Slot = "8")]
		public override void FadeOut()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xEE5364", Offset = "0xEE5364", VA = "0xEE5364")]
		public BoneAllTimelineState()
		{
		}
	}
	[Token(Token = "0x2000047")]
	internal class BoneTranslateTimelineState : BoneTimelineState
	{
		[Token(Token = "0x600019D")]
		[Address(RVA = "0xEE5C70", Offset = "0xEE5C70", VA = "0xEE5C70", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xEE5E18", Offset = "0xEE5E18", VA = "0xEE5E18", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xEE5EAC", Offset = "0xEE5EAC", VA = "0xEE5EAC")]
		public BoneTranslateTimelineState()
		{
		}
	}
	[Token(Token = "0x2000048")]
	internal class BoneRotateTimelineState : BoneTimelineState
	{
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xEE557C", Offset = "0xEE557C", VA = "0xEE557C", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xEE5758", Offset = "0xEE5758", VA = "0xEE5758", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xEE57EC", Offset = "0xEE57EC", VA = "0xEE57EC", Slot = "8")]
		public override void FadeOut()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xEE5890", Offset = "0xEE5890", VA = "0xEE5890")]
		public BoneRotateTimelineState()
		{
		}
	}
	[Token(Token = "0x2000049")]
	internal class BoneScaleTimelineState : BoneTimelineState
	{
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xEE5898", Offset = "0xEE5898", VA = "0xEE5898", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xEE5A20", Offset = "0xEE5A20", VA = "0xEE5A20", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xEE5AB4", Offset = "0xEE5AB4", VA = "0xEE5AB4")]
		public BoneScaleTimelineState()
		{
		}
	}
	[Token(Token = "0x200004A")]
	internal class SlotDislayTimelineState : SlotTimelineState
	{
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1178764", Offset = "0x1178764", VA = "0x1178764", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1178804", Offset = "0x1178804", VA = "0x1178804")]
		public SlotDislayTimelineState()
		{
		}
	}
	[Token(Token = "0x200004B")]
	internal class SlotColorTimelineState : SlotTimelineState
	{
		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool _dirty;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly int[] _current;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly int[] _delta;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly float[] _result;

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x11770CC", Offset = "0x11770CC", VA = "0x11770CC", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1177164", Offset = "0x1177164", VA = "0x1177164", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x11779B4", Offset = "0x11779B4", VA = "0x11779B4", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1177D64", Offset = "0x1177D64", VA = "0x1177D64", Slot = "8")]
		public override void FadeOut()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1177D70", Offset = "0x1177D70", VA = "0x1177D70", Slot = "9")]
		public override void Update(float passedTime)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1178540", Offset = "0x1178540", VA = "0x1178540")]
		public SlotColorTimelineState()
		{
		}
	}
	[Token(Token = "0x200004C")]
	internal class DeformTimelineState : SlotTimelineState
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int vertexOffset;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool _dirty;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int _frameFloatOffset;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int _valueCount;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int _deformCount;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private int _valueOffset;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly List<float> _current;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly List<float> _delta;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly List<float> _result;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public bool test;

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xEE6EA8", Offset = "0xEE6EA8", VA = "0xEE6EA8", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xEE6F38", Offset = "0xEE6F38", VA = "0xEE6F38", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xEE7198", Offset = "0xEE7198", VA = "0xEE7198", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xEE72B4", Offset = "0xEE72B4", VA = "0xEE72B4", Slot = "7")]
		public override void Init(Armature armature, AnimationState animationState, TimelineData timelineData)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xEE74FC", Offset = "0xEE74FC", VA = "0xEE74FC", Slot = "8")]
		public override void FadeOut()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xEE7508", Offset = "0xEE7508", VA = "0xEE7508", Slot = "9")]
		public override void Update(float passedTime)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xEE7974", Offset = "0xEE7974", VA = "0xEE7974")]
		public DeformTimelineState()
		{
		}
	}
	[Token(Token = "0x200004D")]
	internal class IKConstraintTimelineState : ConstraintTimelineState
	{
		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _current;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _delta;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xEE9818", Offset = "0xEE9818", VA = "0xEE9818", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xEE9840", Offset = "0xEE9840", VA = "0xEE9840", Slot = "5")]
		protected override void _OnArriveAtFrame()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xEE9A0C", Offset = "0xEE9A0C", VA = "0xEE9A0C", Slot = "6")]
		protected override void _OnUpdateFrame()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xEE9AC4", Offset = "0xEE9AC4", VA = "0xEE9AC4")]
		public IKConstraintTimelineState()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class WorldClock : IAnimatable
	{
		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float time;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float timeScale;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _systemTime;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<IAnimatable> _animatebles;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WorldClock _clock;

		[Token(Token = "0x1700001E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95DA74", Offset = "0x95DA74")]
		public WorldClock clock
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x11845C0", Offset = "0x11845C0", VA = "0x11845C0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x11845C8", Offset = "0x11845C8", VA = "0x11845C8", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1183ECC", Offset = "0x1183ECC", VA = "0x1183ECC")]
		public WorldClock(float time = -1f)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1183FB4", Offset = "0x1183FB4", VA = "0x1183FB4", Slot = "4")]
		public void AdvanceTime(float passedTime)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x118429C", Offset = "0x118429C", VA = "0x118429C")]
		public bool Contains(IAnimatable value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x117E5BC", Offset = "0x117E5BC", VA = "0x117E5BC")]
		public void Add(IAnimatable value)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1184378", Offset = "0x1184378", VA = "0x1184378")]
		public void Remove(IAnimatable value)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1184488", Offset = "0x1184488", VA = "0x1184488")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class Armature : BaseObject, IAnimatable
	{
		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool inheritAnimation;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object userData;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _lockUpdate;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool _slotsDirty;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		private bool _zOrderDirty;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		private bool _flipX;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool _flipY;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int _cacheFrameIndex;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly List<Bone> _bones;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<Slot> _slots;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal readonly List<Constraint> _constraints;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<EventObject> _actions;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ArmatureData _armatureData;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Animation _animation;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IArmatureProxy _proxy;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private object _display;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal TextureAtlasData _replaceTextureAtlasData;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private object _replacedTexture;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal DragonBones _dragonBones;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private WorldClock _clock;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal Slot _parent;

		[Token(Token = "0x1700001F")]
		public bool flipX
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0xE9EBE0", Offset = "0xE9EBE0", VA = "0xE9EBE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0xE9EBE8", Offset = "0xE9EBE8", VA = "0xE9EBE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public bool flipY
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0xE9EC14", Offset = "0xE9EC14", VA = "0xE9EC14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0xE9EC1C", Offset = "0xE9EC1C", VA = "0xE9EC1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public uint cacheFrameRate
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0xE9EC48", Offset = "0xE9EC48", VA = "0xE9EC48")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xE9EC64", Offset = "0xE9EC64", VA = "0xE9EC64")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public string name
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xE980E0", Offset = "0xE980E0", VA = "0xE980E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public ArmatureData armatureData
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0xE9EEDC", Offset = "0xE9EEDC", VA = "0xE9EEDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public Animation animation
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xE9EEE4", Offset = "0xE9EEE4", VA = "0xE9EEE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public IArmatureProxy proxy
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xE9EEEC", Offset = "0xE9EEEC", VA = "0xE9EEEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public IEventDispatcher<EventObject> eventDispatcher
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0xE9EEF4", Offset = "0xE9EEF4", VA = "0xE9EEF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public object display
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xE9EEFC", Offset = "0xE9EEFC", VA = "0xE9EEFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public object replacedTexture
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xE9EF04", Offset = "0xE9EF04", VA = "0xE9EF04")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xE9EF0C", Offset = "0xE9EF0C", VA = "0xE9EF0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public WorldClock clock
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xE9F048", Offset = "0xE9F048", VA = "0xE9F048", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xE9F050", Offset = "0xE9F050", VA = "0xE9F050", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public Slot parent
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xE9F190", Offset = "0xE9F190", VA = "0xE9F190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xE9DBF4", Offset = "0xE9DBF4", VA = "0xE9DBF4")]
		private static int _OnSortSlots(Slot a, Slot b)
		{
			return default(int);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xE9DC30", Offset = "0xE9DC30", VA = "0xE9DC30", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xE95EDC", Offset = "0xE95EDC", VA = "0xE95EDC")]
		internal void _SortZOrder(short[] slotIndices, int offset)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xE9E0F4", Offset = "0xE9E0F4", VA = "0xE9E0F4")]
		internal void _AddBone(Bone value)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xE9E18C", Offset = "0xE9E18C", VA = "0xE9E18C")]
		internal void _AddSlot(Slot value)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xE9E22C", Offset = "0xE9E22C", VA = "0xE9E22C")]
		internal void _AddConstraint(Constraint value)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xE95534", Offset = "0xE95534", VA = "0xE95534")]
		internal void _BufferAction(EventObject action, bool append)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xE9E2C4", Offset = "0xE9E2C4", VA = "0xE9E2C4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xE9E2EC", Offset = "0xE9E2EC", VA = "0xE9E2EC")]
		internal void Init(ArmatureData armatureData, IArmatureProxy proxy, object display, DragonBones dragonBones)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xE985B4", Offset = "0xE985B4", VA = "0xE985B4", Slot = "5")]
		public void AdvanceTime(float passedTime)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xE9E440", Offset = "0xE9E440", VA = "0xE9E440")]
		public void InvalidUpdate([Optional] string boneName, bool updateSlot = false)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xE9E6E8", Offset = "0xE9E6E8", VA = "0xE9E6E8")]
		public Slot ContainsPoint(float x, float y)
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE9E808", Offset = "0xE9E808", VA = "0xE9E808")]
		public Slot IntersectsSegment(float xA, float yA, float xB, float yB, [Optional] Point intersectionPointA, [Optional] Point intersectionPointB, [Optional] Point normalRadians)
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE99A6C", Offset = "0xE99A6C", VA = "0xE99A6C")]
		public Bone GetBone(string name)
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xE9EA9C", Offset = "0xE9EA9C", VA = "0xE9EA9C")]
		public Bone GetBoneByDisplay(object display)
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xE9DFC8", Offset = "0xE9DFC8", VA = "0xE9DFC8")]
		public Slot GetSlot(string name)
		{
			return null;
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xE9EAB8", Offset = "0xE9EAB8", VA = "0xE9EAB8")]
		public Slot GetSlotByDisplay(object display)
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xE9EBD0", Offset = "0xE9EBD0", VA = "0xE9EBD0")]
		public List<Bone> GetBones()
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xE9EBD8", Offset = "0xE9EBD8", VA = "0xE9EBD8")]
		public List<Slot> GetSlots()
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xE9F198", Offset = "0xE9F198", VA = "0xE9F198")]
		public Armature()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class Bone : TransformObject
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal OffsetMode offsetMode;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal readonly Transform animationPose;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal bool _transformDirty;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		internal bool _childrenTransformDirty;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool _localDirty;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		internal bool _hasConstraint;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _visible;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _cachedFrameIndex;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal readonly BlendState _blendState;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal BoneData _boneData;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected Bone _parent;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal List<int> _cachedFrameIndices;

		[Token(Token = "0x1700002B")]
		public BoneData boneData
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0xEE4BDC", Offset = "0xEE4BDC", VA = "0xEE4BDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public bool visible
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xEE4BE4", Offset = "0xEE4BE4", VA = "0xEE4BE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xEE4BEC", Offset = "0xEE4BEC", VA = "0xEE4BEC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public string name
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xEE4D28", Offset = "0xEE4D28", VA = "0xEE4D28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public Bone parent
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xEE4D44", Offset = "0xEE4D44", VA = "0xEE4D44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95DAAC", Offset = "0x95DAAC")]
		public Slot slot
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xEE4D4C", Offset = "0xEE4D4C", VA = "0xEE4D4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xEE3F60", Offset = "0xEE3F60", VA = "0xEE3F60", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xEE3FD0", Offset = "0xEE3FD0", VA = "0xEE3FD0")]
		private void _UpdateGlobalTransformMatrix(bool isCache)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xEE4730", Offset = "0xEE4730", VA = "0xEE4730")]
		internal void Init(BoneData boneData, Armature armatureValue)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xEE47AC", Offset = "0xEE47AC", VA = "0xEE47AC")]
		internal void Update(int cacheFrameIndex)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xEE4B4C", Offset = "0xEE4B4C", VA = "0xEE4B4C")]
		internal void UpdateByConstraint()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xEE4BA4", Offset = "0xEE4BA4", VA = "0xEE4BA4")]
		public void InvalidUpdate()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xEE4BB0", Offset = "0xEE4BB0", VA = "0xEE4BB0")]
		public bool Contains(Bone value)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xEE4E64", Offset = "0xEE4E64", VA = "0xEE4E64")]
		public Bone()
		{
		}
	}
	[Token(Token = "0x2000051")]
	internal abstract class Constraint : BaseObject
	{
		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static readonly Matrix _helpMatrix;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static readonly Transform _helpTransform;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static readonly Point _helpPoint;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal ConstraintData _constraintData;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Armature _armature;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal Bone _target;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal Bone _root;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal Bone _bone;

		[Token(Token = "0x17000030")]
		public string name
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0xEE6494", Offset = "0xEE6494", VA = "0xEE6494")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xEE6488", Offset = "0xEE6488", VA = "0xEE6488", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60001F6")]
		public abstract void Init(ConstraintData constraintData, Armature armature);

		[Token(Token = "0x60001F7")]
		public abstract void Update();

		[Token(Token = "0x60001F8")]
		public abstract void InvalidUpdate();

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xEE64B0", Offset = "0xEE64B0", VA = "0xEE64B0")]
		protected Constraint()
		{
		}
	}
	[Token(Token = "0x2000052")]
	internal class IKConstraint : Constraint
	{
		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal bool _scaleEnabled;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		internal bool _bendPositive;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal float _weight;

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xEE8FE8", Offset = "0xEE8FE8", VA = "0xEE8FE8", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xEE9008", Offset = "0xEE9008", VA = "0xEE9008")]
		private void _ComputeA()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xEE9128", Offset = "0xEE9128", VA = "0xEE9128")]
		private void _ComputeB()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xEE958C", Offset = "0xEE958C", VA = "0xEE958C", Slot = "5")]
		public override void Init(ConstraintData constraintData, Armature armature)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xEE96CC", Offset = "0xEE96CC", VA = "0xEE96CC", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xEE9718", Offset = "0xEE9718", VA = "0xEE9718", Slot = "7")]
		public override void InvalidUpdate()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xEE9744", Offset = "0xEE9744", VA = "0xEE9744")]
		public IKConstraint()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class DeformVertices : BaseObject
	{
		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool verticesDirty;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly List<float> vertices;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly List<Bone> bones;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VerticesData verticesData;

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xEE7A1C", Offset = "0xEE7A1C", VA = "0xEE7A1C", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xEE7A98", Offset = "0xEE7A98", VA = "0xEE7A98")]
		public void init(VerticesData verticesDataValue, Armature armature)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xEE7CCC", Offset = "0xEE7CCC", VA = "0xEE7CCC")]
		public bool isBonesUpdate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xEE7DC4", Offset = "0xEE7DC4", VA = "0xEE7DC4")]
		public DeformVertices()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public interface IArmatureProxy : IEventDispatcher<EventObject>
	{
		[Token(Token = "0x17000031")]
		Armature armature
		{
			[Token(Token = "0x600020B")]
			get;
		}

		[Token(Token = "0x17000032")]
		Animation animation
		{
			[Token(Token = "0x600020C")]
			get;
		}

		[Token(Token = "0x6000207")]
		void DBInit(Armature armature);

		[Token(Token = "0x6000208")]
		void DBClear();

		[Token(Token = "0x6000209")]
		void DBUpdate();

		[Token(Token = "0x600020A")]
		void Dispose(bool disposeProxy);
	}
	[Token(Token = "0x2000055")]
	public abstract class Slot : TransformObject
	{
		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string displayController;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected bool _displayDirty;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		protected bool _zOrderDirty;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		protected bool _visibleDirty;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		protected bool _blendModeDirty;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		internal bool _colorDirty;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		internal bool _transformDirty;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		protected bool _visible;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal BlendMode _blendMode;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected int _displayIndex;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected int _animationDisplayIndex;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		internal int _zOrder;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected int _cachedFrameIndex;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		internal float _pivotX;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal float _pivotY;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected readonly Matrix _localMatrix;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal readonly ColorTransform _colorTransform;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal readonly List<DisplayData> _displayDatas;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected readonly List<object> _displayList;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		internal SlotData _slotData;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected List<DisplayData> _rawDisplayDatas;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected DisplayData _displayData;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected BoundingBoxData _boundingBoxData;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected TextureData _textureData;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public DeformVertices _deformVertices;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected object _rawDisplay;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected object _meshDisplay;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected object _display;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected Armature _childArmature;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected Bone _parent;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		internal List<int> _cachedFrameIndices;

		[Token(Token = "0x17000033")]
		public bool visible
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x1176A68", Offset = "0x1176A68", VA = "0x1176A68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x1176A70", Offset = "0x1176A70", VA = "0x1176A70")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public int displayIndex
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x1176A9C", Offset = "0x1176A9C", VA = "0x1176A9C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x1176AA4", Offset = "0x1176AA4", VA = "0x1176AA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public string name
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x1176AF8", Offset = "0x1176AF8", VA = "0x1176AF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public List<object> displayList
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x1176B14", Offset = "0x1176B14", VA = "0x1176B14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x1176BA4", Offset = "0x1176BA4", VA = "0x1176BA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public SlotData slotData
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x1176E10", Offset = "0x1176E10", VA = "0x1176E10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public List<DisplayData> rawDisplayDatas
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x1176E18", Offset = "0x1176E18", VA = "0x1176E18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x1176E20", Offset = "0x1176E20", VA = "0x1176E20")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public BoundingBoxData boundingBoxData
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x1176F7C", Offset = "0x1176F7C", VA = "0x1176F7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public object rawDisplay
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x1176F84", Offset = "0x1176F84", VA = "0x1176F84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public object meshDisplay
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x1176F8C", Offset = "0x1176F8C", VA = "0x1176F8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public object display
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x1176F94", Offset = "0x1176F94", VA = "0x1176F94")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x1176F9C", Offset = "0x1176F9C", VA = "0x1176F9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public Armature childArmature
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x11770A8", Offset = "0x11770A8", VA = "0x11770A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x11770B0", Offset = "0x11770B0", VA = "0x11770B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public Bone parent
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x11770C4", Offset = "0x11770C4", VA = "0x11770C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1174668", Offset = "0x1174668", VA = "0x1174668")]
		public Slot()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1174860", Offset = "0x1174860", VA = "0x1174860", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600020F")]
		protected abstract void _InitDisplay(object value, bool isRetain);

		[Token(Token = "0x6000210")]
		protected abstract void _DisposeDisplay(object value, bool isRelease);

		[Token(Token = "0x6000211")]
		protected abstract void _OnUpdateDisplay();

		[Token(Token = "0x6000212")]
		protected abstract void _AddDisplay();

		[Token(Token = "0x6000213")]
		protected abstract void _ReplaceDisplay(object value);

		[Token(Token = "0x6000214")]
		protected abstract void _RemoveDisplay();

		[Token(Token = "0x6000215")]
		protected abstract void _UpdateZOrder();

		[Token(Token = "0x6000216")]
		internal abstract void _UpdateVisible();

		[Token(Token = "0x6000217")]
		internal abstract void _UpdateBlendMode();

		[Token(Token = "0x6000218")]
		protected abstract void _UpdateColor();

		[Token(Token = "0x6000219")]
		protected abstract void _UpdateFrame();

		[Token(Token = "0x600021A")]
		protected abstract void _UpdateMesh();

		[Token(Token = "0x600021B")]
		protected abstract void _UpdateTransform();

		[Token(Token = "0x600021C")]
		protected abstract void _IdentityTransform();

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1174B78", Offset = "0x1174B78", VA = "0x1174B78")]
		protected DisplayData _GetDefaultRawDisplayData(int displayIndex)
		{
			return null;
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1174C24", Offset = "0x1174C24", VA = "0x1174C24")]
		protected void _UpdateDisplayData()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1175538", Offset = "0x1175538", VA = "0x1175538")]
		protected void _UpdateDisplay()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x117594C", Offset = "0x117594C", VA = "0x117594C")]
		protected void _UpdateGlobalTransformMatrix(bool isCache)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1175CE8", Offset = "0x1175CE8", VA = "0x1175CE8")]
		internal bool _SetDisplayIndex(int value, bool isAnimation = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1175D4C", Offset = "0x1175D4C", VA = "0x1175D4C")]
		internal bool _SetZorder(int value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1175D64", Offset = "0x1175D64", VA = "0x1175D64")]
		internal bool _SetColor(ColorTransform value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1175DA0", Offset = "0x1175DA0", VA = "0x1175DA0")]
		internal bool _SetDisplayList(List<object> value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1175FD4", Offset = "0x1175FD4", VA = "0x1175FD4", Slot = "19")]
		internal virtual void Init(SlotData slotData, Armature armatureValue, object rawDisplay, object meshDisplay)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x11760F8", Offset = "0x11760F8", VA = "0x11760F8")]
		internal void Update(int cacheFrameIndex)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x11764AC", Offset = "0x11764AC", VA = "0x11764AC")]
		public void UpdateTransformAndMatrix()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x11764C4", Offset = "0x11764C4", VA = "0x11764C4")]
		internal void ReplaceDisplayData(DisplayData value, int displayIndex = -1)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x11765E8", Offset = "0x11765E8", VA = "0x11765E8")]
		public bool ContainsPoint(float x, float y)
		{
			return default(bool);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1176710", Offset = "0x1176710", VA = "0x1176710")]
		public int IntersectsSegment(float xA, float yA, float xB, float yB, [Optional] Point intersectionPointA, [Optional] Point intersectionPointB, [Optional] Point normalRadians)
		{
			return default(int);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1176A58", Offset = "0x1176A58", VA = "0x1176A58")]
		public void InvalidUpdate()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public abstract class TransformObject : BaseObject
	{
		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static readonly Matrix _helpMatrix;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static readonly Transform _helpTransform;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static readonly Point _helpPoint;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly Matrix globalTransformMatrix;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly Transform global;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly Transform offset;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform origin;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public object userData;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected bool _globalDirty;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal Armature _armature;

		[Token(Token = "0x1700003F")]
		public Armature armature
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x1179C00", Offset = "0x1179C00", VA = "0x1179C00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1174B18", Offset = "0x1174B18", VA = "0x1174B18", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1179BD0", Offset = "0x1179BD0", VA = "0x1179BD0")]
		public void UpdateGlobalTransform()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1174784", Offset = "0x1174784", VA = "0x1174784")]
		protected TransformObject()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public abstract class BaseObject
	{
		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint _hashCode;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static uint _defaultMaxCount;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<Type, uint> _maxCountMap;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<Type, List<BaseObject>> _poolsMap;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly uint hashCode;

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xEDF17C", Offset = "0xEDF17C", VA = "0xEDF17C")]
		private static void _ReturnObject(BaseObject obj)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xEDF414", Offset = "0xEDF414", VA = "0xEDF414")]
		public static void SetMaxCount(Type classType, uint maxCount)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xEDF7FC", Offset = "0xEDF7FC", VA = "0xEDF7FC")]
		public static void ClearPool(Type classType)
		{
		}

		[Token(Token = "0x6000246")]
		public static T BorrowObject<T>() where T : BaseObject, new()
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xEDFA48", Offset = "0xEDFA48", VA = "0xEDFA48")]
		protected BaseObject()
		{
		}

		[Token(Token = "0x6000248")]
		protected abstract void _OnClear();

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xEDFAC8", Offset = "0xEDFAC8", VA = "0xEDFAC8")]
		public void ReturnToPool()
		{
		}
	}
	[Token(Token = "0x2000058")]
	internal enum BinaryOffset
	{
		[Token(Token = "0x40002D0")]
		WeigthBoneCount = 0,
		[Token(Token = "0x40002D1")]
		WeigthFloatOffset = 1,
		[Token(Token = "0x40002D2")]
		WeigthBoneIndices = 2,
		[Token(Token = "0x40002D3")]
		MeshVertexCount = 0,
		[Token(Token = "0x40002D4")]
		MeshTriangleCount = 1,
		[Token(Token = "0x40002D5")]
		MeshFloatOffset = 2,
		[Token(Token = "0x40002D6")]
		MeshWeightOffset = 3,
		[Token(Token = "0x40002D7")]
		MeshVertexIndices = 4,
		[Token(Token = "0x40002D8")]
		TimelineScale = 0,
		[Token(Token = "0x40002D9")]
		TimelineOffset = 1,
		[Token(Token = "0x40002DA")]
		TimelineKeyFrameCount = 2,
		[Token(Token = "0x40002DB")]
		TimelineFrameValueCount = 3,
		[Token(Token = "0x40002DC")]
		TimelineFrameValueOffset = 4,
		[Token(Token = "0x40002DD")]
		TimelineFrameOffset = 5,
		[Token(Token = "0x40002DE")]
		FramePosition = 0,
		[Token(Token = "0x40002DF")]
		FrameTweenType = 1,
		[Token(Token = "0x40002E0")]
		FrameTweenEasingOrCurveSampleCount = 2,
		[Token(Token = "0x40002E1")]
		FrameCurveSamples = 3,
		[Token(Token = "0x40002E2")]
		DeformVertexOffset = 0,
		[Token(Token = "0x40002E3")]
		DeformCount = 1,
		[Token(Token = "0x40002E4")]
		DeformValueCount = 2,
		[Token(Token = "0x40002E5")]
		DeformValueOffset = 3,
		[Token(Token = "0x40002E6")]
		DeformFloatOffset = 4
	}
	[Token(Token = "0x2000059")]
	public enum ArmatureType
	{
		[Token(Token = "0x40002E8")]
		None = -1,
		[Token(Token = "0x40002E9")]
		Armature,
		[Token(Token = "0x40002EA")]
		MovieClip,
		[Token(Token = "0x40002EB")]
		Stage
	}
	[Token(Token = "0x200005A")]
	public enum DisplayType
	{
		[Token(Token = "0x40002ED")]
		None = -1,
		[Token(Token = "0x40002EE")]
		Image,
		[Token(Token = "0x40002EF")]
		Armature,
		[Token(Token = "0x40002F0")]
		Mesh,
		[Token(Token = "0x40002F1")]
		BoundingBox,
		[Token(Token = "0x40002F2")]
		Path
	}
	[Token(Token = "0x200005B")]
	public enum BoundingBoxType
	{
		[Token(Token = "0x40002F4")]
		None = -1,
		[Token(Token = "0x40002F5")]
		Rectangle,
		[Token(Token = "0x40002F6")]
		Ellipse,
		[Token(Token = "0x40002F7")]
		Polygon
	}
	[Token(Token = "0x200005C")]
	public enum ActionType
	{
		[Token(Token = "0x40002F9")]
		Play = 0,
		[Token(Token = "0x40002FA")]
		Frame = 10,
		[Token(Token = "0x40002FB")]
		Sound = 11
	}
	[Token(Token = "0x200005D")]
	public enum BlendMode
	{
		[Token(Token = "0x40002FD")]
		Normal,
		[Token(Token = "0x40002FE")]
		Add,
		[Token(Token = "0x40002FF")]
		Alpha,
		[Token(Token = "0x4000300")]
		Darken,
		[Token(Token = "0x4000301")]
		Difference,
		[Token(Token = "0x4000302")]
		Erase,
		[Token(Token = "0x4000303")]
		HardLight,
		[Token(Token = "0x4000304")]
		Invert,
		[Token(Token = "0x4000305")]
		Layer,
		[Token(Token = "0x4000306")]
		Lighten,
		[Token(Token = "0x4000307")]
		Multiply,
		[Token(Token = "0x4000308")]
		Overlay,
		[Token(Token = "0x4000309")]
		Screen,
		[Token(Token = "0x400030A")]
		Subtract
	}
	[Token(Token = "0x200005E")]
	public enum TweenType
	{
		[Token(Token = "0x400030C")]
		None,
		[Token(Token = "0x400030D")]
		Line,
		[Token(Token = "0x400030E")]
		Curve,
		[Token(Token = "0x400030F")]
		QuadIn,
		[Token(Token = "0x4000310")]
		QuadOut,
		[Token(Token = "0x4000311")]
		QuadInOut
	}
	[Token(Token = "0x200005F")]
	public enum TimelineType
	{
		[Token(Token = "0x4000313")]
		Action = 0,
		[Token(Token = "0x4000314")]
		ZOrder = 1,
		[Token(Token = "0x4000315")]
		BoneAll = 10,
		[Token(Token = "0x4000316")]
		BoneTranslate = 11,
		[Token(Token = "0x4000317")]
		BoneRotate = 12,
		[Token(Token = "0x4000318")]
		BoneScale = 13,
		[Token(Token = "0x4000319")]
		SlotDisplay = 20,
		[Token(Token = "0x400031A")]
		SlotColor = 21,
		[Token(Token = "0x400031B")]
		SlotDeform = 22,
		[Token(Token = "0x400031C")]
		IKConstraint = 30,
		[Token(Token = "0x400031D")]
		AnimationTime = 40,
		[Token(Token = "0x400031E")]
		AnimationWeight = 41
	}
	[Token(Token = "0x2000060")]
	public enum OffsetMode
	{
		[Token(Token = "0x4000320")]
		None,
		[Token(Token = "0x4000321")]
		Additive,
		[Token(Token = "0x4000322")]
		Override
	}
	[Token(Token = "0x2000061")]
	public enum AnimationFadeOutMode
	{
		[Token(Token = "0x4000324")]
		None,
		[Token(Token = "0x4000325")]
		SameLayer,
		[Token(Token = "0x4000326")]
		SameGroup,
		[Token(Token = "0x4000327")]
		SameLayerAndGroup,
		[Token(Token = "0x4000328")]
		All,
		[Token(Token = "0x4000329")]
		Single
	}
	[Token(Token = "0x2000062")]
	internal static class Helper
	{
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int INT16_SIZE;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int UINT16_SIZE;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int FLOAT_SIZE;

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xEDF410", Offset = "0xEDF410", VA = "0xEDF410")]
		internal static void Assert(bool condition, string message)
		{
		}

		[Token(Token = "0x600024C")]
		internal static void ResizeList<T>(this List<T> list, int count, [Optional] T value)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xEE8E10", Offset = "0xEE8E10", VA = "0xEE8E10")]
		internal static List<float> Convert(this List<object> list)
		{
			return null;
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xEE8EF8", Offset = "0xEE8EF8", VA = "0xEE8EF8")]
		internal static bool FloatEqual(float f0, float f1)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000063")]
	public class DragonBones
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool yDown;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool debug;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public static bool debugDraw;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly string VERSION;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly WorldClock _clock;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<EventObject> _events;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<BaseObject> _objects;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IEventDispatcher<EventObject> _eventManager;

		[Token(Token = "0x17000040")]
		public WorldClock clock
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0xEE826C", Offset = "0xEE826C", VA = "0xEE826C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public IEventDispatcher<EventObject> eventManager
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0xEE8274", Offset = "0xEE8274", VA = "0xEE8274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xEE8060", Offset = "0xEE8060", VA = "0xEE8060")]
		public DragonBones(IEventDispatcher<EventObject> eventManager)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xEE6198", Offset = "0xEE6198", VA = "0xEE6198")]
		public void AdvanceTime(float passedTime)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xEE81C8", Offset = "0xEE81C8", VA = "0xEE81C8")]
		public void BufferEvent(EventObject value)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xEE8130", Offset = "0xEE8130", VA = "0xEE8130")]
		public void BufferObject(BaseObject value)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xEE8260", Offset = "0xEE8260", VA = "0xEE8260")]
		public static implicit operator bool(DragonBones exists)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000064")]
	public class EventObject : BaseObject
	{
		[Token(Token = "0x4000335")]
		public const string START = "start";

		[Token(Token = "0x4000336")]
		public const string LOOP_COMPLETE = "loopComplete";

		[Token(Token = "0x4000337")]
		public const string COMPLETE = "complete";

		[Token(Token = "0x4000338")]
		public const string FADE_IN = "fadeIn";

		[Token(Token = "0x4000339")]
		public const string FADE_IN_COMPLETE = "fadeInComplete";

		[Token(Token = "0x400033A")]
		public const string FADE_OUT = "fadeOut";

		[Token(Token = "0x400033B")]
		public const string FADE_OUT_COMPLETE = "fadeOutComplete";

		[Token(Token = "0x400033C")]
		public const string FRAME_EVENT = "frameEvent";

		[Token(Token = "0x400033D")]
		public const string SOUND_EVENT = "soundEvent";

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float time;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string type;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Armature armature;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Bone bone;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Slot slot;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationState animationState;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ActionData actionData;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UserData data;

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xEE8C50", Offset = "0xEE8C50", VA = "0xEE8C50")]
		public static void ActionDataToInstance(ActionData data, EventObject instance, Armature armature)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xEE8D38", Offset = "0xEE8D38", VA = "0xEE8D38", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xEE8DAC", Offset = "0xEE8DAC", VA = "0xEE8DAC")]
		public EventObject()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public delegate void ListenerDelegate<T>(string type, T eventObject);
	[Token(Token = "0x2000066")]
	public interface IEventDispatcher<T>
	{
		[Token(Token = "0x600025F")]
		bool HasDBEventListener(string type);

		[Token(Token = "0x6000260")]
		void DispatchDBEvent(string type, T eventObject);

		[Token(Token = "0x6000261")]
		void AddDBEventListener(string type, ListenerDelegate<T> listener);

		[Token(Token = "0x6000262")]
		void RemoveDBEventListener(string type, ListenerDelegate<T> listener);
	}
	[Token(Token = "0x2000067")]
	public class BuildArmaturePackage
	{
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string dataName;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string textureAtlasName;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DragonBonesData data;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ArmatureData armature;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SkinData skin;

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xEE604C", Offset = "0xEE604C", VA = "0xEE604C")]
		public BuildArmaturePackage()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public abstract class BaseFactory
	{
		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static ObjectDataParser _objectParser;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static BinaryDataParser _binaryParser;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool autoSearch;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly Dictionary<string, DragonBonesData> _dragonBonesDataMap;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected readonly Dictionary<string, List<TextureAtlasData>> _textureAtlasDataMap;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DragonBones _dragonBones;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected DataParser _dataParser;

		[Token(Token = "0x17000042")]
		public WorldClock clock
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0xEA402C", Offset = "0xEA402C", VA = "0xEA402C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xEA1068", Offset = "0xEA1068", VA = "0xEA1068")]
		public BaseFactory([Optional] DataParser dataParser)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xEA1218", Offset = "0xEA1218", VA = "0xEA1218")]
		protected bool _IsSupportMesh()
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xEA1220", Offset = "0xEA1220", VA = "0xEA1220")]
		protected TextureData _GetTextureData(string textureAtlasName, string textureName)
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xEA15E0", Offset = "0xEA15E0", VA = "0xEA15E0")]
		protected bool _FillBuildArmaturePackage(BuildArmaturePackage dataPackage, string dragonBonesName, string armatureName, string skinName, string textureAtlasName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xEA197C", Offset = "0xEA197C", VA = "0xEA197C")]
		protected void _BuildBones(BuildArmaturePackage dataPackage, Armature armature)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xEA1A78", Offset = "0xEA1A78", VA = "0xEA1A78")]
		protected void _BuildSlots(BuildArmaturePackage dataPackage, Armature armature)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xEA22F8", Offset = "0xEA22F8", VA = "0xEA22F8")]
		protected void _BuildConstraints(BuildArmaturePackage dataPackage, Armature armature)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xEA248C", Offset = "0xEA248C", VA = "0xEA248C", Slot = "4")]
		protected virtual Armature _BuildChildArmature(BuildArmaturePackage dataPackage, Slot slot, DisplayData displayData)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xEA1F48", Offset = "0xEA1F48", VA = "0xEA1F48")]
		protected object _GetSlotDisplay(BuildArmaturePackage dataPackage, DisplayData displayData, DisplayData rawDisplayData, Slot slot)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		protected abstract TextureAtlasData _BuildTextureAtlasData(TextureAtlasData textureAtlasData, object textureAtlas);

		[Token(Token = "0x600026E")]
		protected abstract Armature _BuildArmature(BuildArmaturePackage dataPackage);

		[Token(Token = "0x600026F")]
		protected abstract Slot _BuildSlot(BuildArmaturePackage dataPackage, SlotData slotData, Armature armature);

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xEA2514", Offset = "0xEA2514", VA = "0xEA2514")]
		public DragonBonesData ParseDragonBonesData(object rawData, [Optional] string name, float scale = 1f)
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xEA28DC", Offset = "0xEA28DC", VA = "0xEA28DC")]
		public TextureAtlasData ParseTextureAtlasData(Dictionary<string, object> rawData, object textureAtlas, [Optional] string name, float scale = 1f)
		{
			return null;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xEA298C", Offset = "0xEA298C", VA = "0xEA298C")]
		public void UpdateTextureAtlasData(string name, List<object> textureAtlases)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xEA2B10", Offset = "0xEA2B10", VA = "0xEA2B10")]
		public DragonBonesData GetDragonBonesData(string name)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xEA27A4", Offset = "0xEA27A4", VA = "0xEA27A4")]
		public void AddDragonBonesData(DragonBonesData data, [Optional] string name)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xEA2BA4", Offset = "0xEA2BA4", VA = "0xEA2BA4", Slot = "8")]
		public virtual void RemoveDragonBonesData(string name, bool disposeData = true)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xEA2A7C", Offset = "0xEA2A7C", VA = "0xEA2A7C")]
		public List<TextureAtlasData> GetTextureAtlasData(string name)
		{
			return null;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xEA2664", Offset = "0xEA2664", VA = "0xEA2664")]
		public void AddTextureAtlasData(TextureAtlasData data, [Optional] string name)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xEA2C78", Offset = "0xEA2C78", VA = "0xEA2C78", Slot = "9")]
		public virtual void RemoveTextureAtlasData(string name, bool disposeData = true)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xEA2DDC", Offset = "0xEA2DDC", VA = "0xEA2DDC", Slot = "10")]
		public virtual ArmatureData GetArmatureData(string name, string dragonBonesName = "")
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xEA2E84", Offset = "0xEA2E84", VA = "0xEA2E84", Slot = "11")]
		public virtual void Clear(bool disposeData = true)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xEA31C8", Offset = "0xEA31C8", VA = "0xEA31C8", Slot = "12")]
		public virtual Armature BuildArmature(string armatureName, string dragonBonesName = "", [Optional] string skinName, [Optional] string textureAtlasName)
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xEA3358", Offset = "0xEA3358", VA = "0xEA3358", Slot = "13")]
		public virtual void ReplaceDisplay(Slot slot, DisplayData displayData, int displayIndex = -1)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xEA3510", Offset = "0xEA3510", VA = "0xEA3510")]
		public bool ReplaceSlotDisplay(string dragonBonesName, string armatureName, string slotName, string displayName, Slot slot, int displayIndex = -1)
		{
			return default(bool);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xEA35A8", Offset = "0xEA35A8", VA = "0xEA35A8")]
		public bool ReplaceSlotDisplayList(string dragonBonesName, string armatureName, string slotName, Slot slot)
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xEA36A4", Offset = "0xEA36A4", VA = "0xEA36A4")]
		public bool ReplaceSkin(Armature armature, SkinData skin, bool isOverride = false, [Optional] List<string> exclude)
		{
			return default(bool);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xEA3A38", Offset = "0xEA3A38", VA = "0xEA3A38")]
		public bool ReplaceAnimation(Armature armature, ArmatureData armatureData, bool isOverride = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xEA401C", Offset = "0xEA401C", VA = "0xEA401C")]
		public Dictionary<string, DragonBonesData> GetAllDragonBonesData()
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xEA4024", Offset = "0xEA4024", VA = "0xEA4024")]
		public Dictionary<string, List<TextureAtlasData>> GetAllTextureAtlasData()
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xEA4048", Offset = "0xEA4048", VA = "0xEA4048")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95D0EC", Offset = "0x95D0EC")]
		public bool ChangeSkin(Armature armature, SkinData skin, [Optional] List<string> exclude)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000069")]
	public class ColorTransform
	{
		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float alphaMultiplier;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float redMultiplier;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float greenMultiplier;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blueMultiplier;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int alphaOffset;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int redOffset;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int greenOffset;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int blueOffset;

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xEE6414", Offset = "0xEE6414", VA = "0xEE6414")]
		public ColorTransform()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xEE6424", Offset = "0xEE6424", VA = "0xEE6424")]
		public void CopyFrom(ColorTransform value)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xEE6478", Offset = "0xEE6478", VA = "0xEE6478")]
		public void Identity()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class Matrix
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float a;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float b;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float c;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float d;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float tx;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float ty;

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xEE65DC", Offset = "0xEE65DC", VA = "0xEE65DC")]
		public Matrix()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xEE9BF4", Offset = "0xEE9BF4", VA = "0xEE9BF4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xEE9F44", Offset = "0xEE9F44", VA = "0xEE9F44")]
		public Matrix CopyFrom(Matrix value)
		{
			return null;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xEE9F88", Offset = "0xEE9F88", VA = "0xEE9F88")]
		public Matrix CopyFromArray(List<float> value, int offset = 0)
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xEEA0D0", Offset = "0xEEA0D0", VA = "0xEEA0D0")]
		public Matrix Identity()
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xEE4664", Offset = "0xEE4664", VA = "0xEE4664")]
		public Matrix Concat(Matrix value)
		{
			return null;
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xEEA0E4", Offset = "0xEEA0E4", VA = "0xEEA0E4")]
		public Matrix Invert()
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xEEA1BC", Offset = "0xEEA1BC", VA = "0xEEA1BC")]
		public void TransformPoint(float x, float y, Point result, bool delta = false)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xEEA21C", Offset = "0xEEA21C", VA = "0xEEA21C")]
		public void TransformRectangle(Rectangle rectangle, bool delta = false)
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class Point
	{
		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float x;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float y;

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1173310", Offset = "0x1173310", VA = "0x1173310")]
		public Point()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1173318", Offset = "0x1173318", VA = "0x1173318")]
		public void CopyFrom(Point value)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x117333C", Offset = "0x117333C", VA = "0x117333C")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class Rectangle
	{
		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float x;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float y;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float width;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float height;

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1173F3C", Offset = "0x1173F3C", VA = "0x1173F3C")]
		public Rectangle()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1173F44", Offset = "0x1173F44", VA = "0x1173F44")]
		public void CopyFrom(Rectangle value)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1173F78", Offset = "0x1173F78", VA = "0x1173F78")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class Transform
	{
		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float PI;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly float PI_D;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly float PI_H;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly float PI_Q;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly float RAD_DEG;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly float DEG_RAD;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float x;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float y;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float skew;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rotation;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float scaleX;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float scaleY;

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x11795E8", Offset = "0x11795E8", VA = "0x11795E8")]
		public static float NormalizeRadian(float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x11796C0", Offset = "0x11796C0", VA = "0x11796C0")]
		public Transform()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x11796D0", Offset = "0x11796D0", VA = "0x11796D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1176400", Offset = "0x1176400", VA = "0x1176400")]
		public Transform CopyFrom(Transform value)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1179A98", Offset = "0x1179A98", VA = "0x1179A98")]
		public Transform Identity()
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1176444", Offset = "0x1176444", VA = "0x1176444")]
		public Transform Add(Transform value)
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1179AA8", Offset = "0x1179AA8", VA = "0x1179AA8")]
		public Transform Minus(Transform value)
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x11759C4", Offset = "0x11759C4", VA = "0x11759C4")]
		public Transform FromMatrix(Matrix matrix)
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x11753A0", Offset = "0x11753A0", VA = "0x11753A0")]
		public Transform ToMatrix(Matrix matrix)
		{
			return null;
		}
	}
	[Token(Token = "0x200006E")]
	public class AnimationConfig : BaseObject
	{
		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool pauseFadeOut;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationFadeOutMode fadeOutMode;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TweenType fadeOutTweenType;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeOutTime;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool pauseFadeIn;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool actionEnabled;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool additiveBlending;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool displayControl;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool resetToPose;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public TweenType fadeInTweenType;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int playTimes;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int layer;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float position;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float duration;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float timeScale;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float weight;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float fadeInTime;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float autoFadeOutTime;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string name;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string animation;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string group;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public readonly List<string> boneMask;

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xE995E0", Offset = "0xE995E0", VA = "0xE995E0", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xE97798", Offset = "0xE97798", VA = "0xE97798")]
		public void Clear()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xE99698", Offset = "0xE99698", VA = "0xE99698")]
		public void CopyFrom(AnimationConfig value)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xE99864", Offset = "0xE99864", VA = "0xE99864")]
		public bool ContainsBoneMask(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xE998E8", Offset = "0xE998E8", VA = "0xE998E8")]
		public void AddBoneMask(Armature armature, string boneName, bool recursive = false)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xE99B98", Offset = "0xE99B98", VA = "0xE99B98")]
		public void RemoveBoneMask(Armature armature, string name, bool recursive = true)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xE99DC0", Offset = "0xE99DC0", VA = "0xE99DC0")]
		public AnimationConfig()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class AnimationData : BaseObject
	{
		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint frameIntOffset;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint frameFloatOffset;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint frameOffset;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint frameCount;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint playTimes;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float scale;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float fadeInTime;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float cacheFrameRate;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string name;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly List<bool> cachedFrames;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly Dictionary<string, List<TimelineData>> boneTimelines;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly Dictionary<string, List<TimelineData>> slotTimelines;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public readonly Dictionary<string, List<TimelineData>> constraintTimelines;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public readonly Dictionary<string, List<int>> boneCachedFrameIndices;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public readonly Dictionary<string, List<int>> slotCachedFrameIndices;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public TimelineData actionTimeline;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public TimelineData zOrderTimeline;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public ArmatureData parent;

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xE99E50", Offset = "0xE99E50", VA = "0xE99E50")]
		public AnimationData()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xE99F80", Offset = "0xE99F80", VA = "0xE99F80", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xE9A380", Offset = "0xE9A380", VA = "0xE9A380")]
		public void CacheFrames(float frameRate)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xE9A77C", Offset = "0xE9A77C", VA = "0xE9A77C")]
		public void AddBoneTimeline(BoneData bone, TimelineData tiemline)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xE9A8B0", Offset = "0xE9A8B0", VA = "0xE9A8B0")]
		public void AddSlotTimeline(SlotData slot, TimelineData timeline)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xE9A9E4", Offset = "0xE9A9E4", VA = "0xE9A9E4")]
		public void AddConstraintTimeline(ConstraintData constraint, TimelineData timeline)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xE9AB18", Offset = "0xE9AB18", VA = "0xE9AB18")]
		public List<TimelineData> GetBoneTimelines(string timelineName)
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xE9ABAC", Offset = "0xE9ABAC", VA = "0xE9ABAC")]
		public List<TimelineData> GetSlotTimelines(string timelineName)
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xE9AC40", Offset = "0xE9AC40", VA = "0xE9AC40")]
		public List<TimelineData> GetConstraintTimelines(string timelineName)
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xE96E58", Offset = "0xE96E58", VA = "0xE96E58")]
		public List<int> GetBoneCachedFrameIndices(string boneName)
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xE96EEC", Offset = "0xE96EEC", VA = "0xE96EEC")]
		public List<int> GetSlotCachedFrameIndices(string slotName)
		{
			return null;
		}
	}
	[Token(Token = "0x2000070")]
	public class TimelineData : BaseObject
	{
		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public TimelineType type;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint offset;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int frameIndicesOffset;

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x117913C", Offset = "0x117913C", VA = "0x117913C", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1179154", Offset = "0x1179154", VA = "0x1179154")]
		public TimelineData()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class ArmatureData : BaseObject
	{
		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ArmatureType type;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint frameRate;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint cacheFrameRate;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float scale;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly Rectangle aabb;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly List<string> animationNames;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly List<BoneData> sortedBones;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly List<SlotData> sortedSlots;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly List<ActionData> defaultActions;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public readonly List<ActionData> actions;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public readonly Dictionary<string, BoneData> bones;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public readonly Dictionary<string, SlotData> slots;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public readonly Dictionary<string, ConstraintData> constraints;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public readonly Dictionary<string, SkinData> skins;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public readonly Dictionary<string, AnimationData> animations;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public SkinData defaultSkin;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AnimationData defaultAnimation;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public CanvasData canvas;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UserData userData;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public DragonBonesData parent;

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xE9F2A0", Offset = "0xE9F2A0", VA = "0xE9F2A0", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xE9FB50", Offset = "0xE9FB50", VA = "0xE9FB50")]
		public void SortBones()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xE9ED8C", Offset = "0xE9ED8C", VA = "0xE9ED8C")]
		public void CacheFrames(uint frameRate)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xE9FDFC", Offset = "0xE9FDFC", VA = "0xE9FDFC")]
		public int SetCacheFrame(Matrix globalTransformMatrix, Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xE9FF84", Offset = "0xE9FF84", VA = "0xE9FF84")]
		public void GetCacheFrame(Matrix globalTransformMatrix, Transform transform, int arrayOffset)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xEA0198", Offset = "0xEA0198", VA = "0xEA0198")]
		public void AddBone(BoneData value)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xEA02DC", Offset = "0xEA02DC", VA = "0xEA02DC")]
		public void AddSlot(SlotData value)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xEA0420", Offset = "0xEA0420", VA = "0xEA0420")]
		public void AddConstraint(ConstraintData value)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xEA0548", Offset = "0xEA0548", VA = "0xEA0548")]
		public void AddSkin(SkinData value)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xEA0694", Offset = "0xEA0694", VA = "0xEA0694")]
		public void AddAnimation(AnimationData value)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xEA07DC", Offset = "0xEA07DC", VA = "0xEA07DC")]
		internal void AddAction(ActionData value, bool isDefault)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xEA0854", Offset = "0xEA0854", VA = "0xEA0854")]
		public BoneData GetBone(string boneName)
		{
			return null;
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xEA0900", Offset = "0xEA0900", VA = "0xEA0900")]
		public SlotData GetSlot(string slotName)
		{
			return null;
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xEA09AC", Offset = "0xEA09AC", VA = "0xEA09AC")]
		public ConstraintData GetConstraint(string constraintName)
		{
			return null;
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xEA0A40", Offset = "0xEA0A40", VA = "0xEA0A40")]
		public SkinData GetSkin(string skinName)
		{
			return null;
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xEA0AEC", Offset = "0xEA0AEC", VA = "0xEA0AEC")]
		public MeshDisplayData GetMesh(string skinName, string slotName, string meshName)
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xEA0BA8", Offset = "0xEA0BA8", VA = "0xEA0BA8")]
		public AnimationData GetAnimation(string animationName)
		{
			return null;
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xEA0C54", Offset = "0xEA0C54", VA = "0xEA0C54")]
		public ArmatureData()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class BoneData : BaseObject
	{
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool inheritTranslation;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool inheritRotation;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public bool inheritScale;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
		public bool inheritReflection;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float length;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly Transform transform;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UserData userData;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BoneData parent;

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xEE5374", Offset = "0xEE5374", VA = "0xEE5374", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xEE53F0", Offset = "0xEE53F0", VA = "0xEE53F0")]
		public BoneData()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class SurfaceData : BoneData
	{
		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float vertexCountX;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float vertexCountY;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly List<float> vertices;

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1178858", Offset = "0x1178858", VA = "0x1178858", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x11788C0", Offset = "0x11788C0", VA = "0x11788C0")]
		public SurfaceData()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class SlotData : BaseObject
	{
		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ColorTransform DEFAULT_COLOR;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BlendMode blendMode;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int displayIndex;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int zOrder;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ColorTransform color;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UserData userData;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BoneData parent;

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x11785C8", Offset = "0x11785C8", VA = "0x11785C8")]
		public static ColorTransform CreateColor()
		{
			return null;
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1178624", Offset = "0x1178624", VA = "0x1178624", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1178690", Offset = "0x1178690", VA = "0x1178690")]
		public SlotData()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public abstract class BoundingBoxData : BaseObject
	{
		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BoundingBoxType type;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint color;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float width;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float height;

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xEE5EB4", Offset = "0xEE5EB4", VA = "0xEE5EB4", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002D1")]
		public abstract bool ContainsPoint(float pX, float pY);

		[Token(Token = "0x60002D2")]
		public abstract int IntersectsSegment(float xA, float yA, float xB, float yB, [Optional] Point intersectionPointA, [Optional] Point intersectionPointB, [Optional] Point normalRadians);

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xEE5EC0", Offset = "0xEE5EC0", VA = "0xEE5EC0")]
		protected BoundingBoxData()
		{
		}
	}
	[Token(Token = "0x2000076")]
	internal enum OutCode
	{
		[Token(Token = "0x40003CD")]
		InSide = 0,
		[Token(Token = "0x40003CE")]
		Left = 1,
		[Token(Token = "0x40003CF")]
		Right = 2,
		[Token(Token = "0x40003D0")]
		Top = 4,
		[Token(Token = "0x40003D1")]
		Bottom = 8
	}
	[Token(Token = "0x2000077")]
	public class RectangleBoundingBoxData : BoundingBoxData
	{
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1173F80", Offset = "0x1173F80", VA = "0x1173F80")]
		private static int _ComputeOutCode(float x, float y, float xMin, float yMin, float xMax, float yMax)
		{
			return default(int);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1173BBC", Offset = "0x1173BBC", VA = "0x1173BBC")]
		public static int RectangleIntersectsSegment(float xA, float yA, float xB, float yB, float xMin, float yMin, float xMax, float yMax, [Optional] Point intersectionPointA, [Optional] Point intersectionPointB, [Optional] Point normalRadians)
		{
			return default(int);
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1173FC4", Offset = "0x1173FC4", VA = "0x1173FC4", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1173FEC", Offset = "0x1173FEC", VA = "0x1173FEC", Slot = "5")]
		public override bool ContainsPoint(float pX, float pY)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x117403C", Offset = "0x117403C", VA = "0x117403C", Slot = "6")]
		public override int IntersectsSegment(float xA, float yA, float xB, float yB, [Optional] Point intersectionPointA, [Optional] Point intersectionPointB, [Optional] Point normalRadians)
		{
			return default(int);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1174068", Offset = "0x1174068", VA = "0x1174068")]
		public RectangleBoundingBoxData()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class EllipseBoundingBoxData : BoundingBoxData
	{
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xEE8770", Offset = "0xEE8770", VA = "0xEE8770")]
		public static int EllipseIntersectsSegment(float xA, float yA, float xB, float yB, float xC, float yC, float widthH, float heightH, [Optional] Point intersectionPointA, [Optional] Point intersectionPointB, [Optional] Point normalRadians)
		{
			return default(int);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xEE8B18", Offset = "0xEE8B18", VA = "0xEE8B18", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xEE8B2C", Offset = "0xEE8B2C", VA = "0xEE8B2C", Slot = "5")]
		public override bool ContainsPoint(float pX, float pY)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xEE8C24", Offset = "0xEE8C24", VA = "0xEE8C24", Slot = "6")]
		public override int IntersectsSegment(float xA, float yA, float xB, float yB, Point intersectionPointA, Point intersectionPointB, Point normalRadians)
		{
			return default(int);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xEE8C4C", Offset = "0xEE8C4C", VA = "0xEE8C4C")]
		public EllipseBoundingBoxData()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class PolygonBoundingBoxData : BoundingBoxData
	{
		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float x;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float y;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly List<float> vertices;

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1173344", Offset = "0x1173344", VA = "0x1173344")]
		public static int PolygonIntersectsSegment(float xA, float yA, float xB, float yB, List<float> vertices, [Optional] Point intersectionPointA, [Optional] Point intersectionPointB, [Optional] Point normalRadians)
		{
			return default(int);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x117387C", Offset = "0x117387C", VA = "0x117387C", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x11738EC", Offset = "0x11738EC", VA = "0x11738EC", Slot = "5")]
		public override bool ContainsPoint(float pX, float pY)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1173B08", Offset = "0x1173B08", VA = "0x1173B08", Slot = "6")]
		public override int IntersectsSegment(float xA, float yA, float xB, float yB, [Optional] Point intersectionPointA, [Optional] Point intersectionPointB, [Optional] Point normalRadians)
		{
			return default(int);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1173ECC", Offset = "0x1173ECC", VA = "0x1173ECC")]
		public PolygonBoundingBoxData()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class CanvasData : BaseObject
	{
		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool hasBackground;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int color;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float x;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float y;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float width;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float height;

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xEE60A4", Offset = "0xEE60A4", VA = "0xEE60A4", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xEE60B4", Offset = "0xEE60B4", VA = "0xEE60B4")]
		public CanvasData()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public abstract class ConstraintData : BaseObject
	{
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int order;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BoneData target;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BoneData root;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BoneData bone;

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xEE65F0", Offset = "0xEE65F0", VA = "0xEE65F0", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xEE6650", Offset = "0xEE6650", VA = "0xEE6650")]
		protected ConstraintData()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class IKConstraintData : ConstraintData
	{
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool scaleEnabled;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool bendPositive;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float weight;

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xEE97A8", Offset = "0xEE97A8", VA = "0xEE97A8", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xEE9814", Offset = "0xEE9814", VA = "0xEE9814")]
		public IKConstraintData()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class VerticesData
	{
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isShared;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool inheritDeform;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int offset;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DragonBonesData data;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WeightData weight;

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1173238", Offset = "0x1173238", VA = "0x1173238")]
		public void Clear()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1183D4C", Offset = "0x1183D4C", VA = "0x1183D4C")]
		public void ShareFrom(VerticesData value)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1173308", Offset = "0x1173308", VA = "0x1173308")]
		public VerticesData()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public abstract class DisplayData : BaseObject
	{
		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public DisplayType type;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string path;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SkinData parent;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly Transform transform;

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xEE5F5C", Offset = "0xEE5F5C", VA = "0xEE5F5C", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xEE5FC8", Offset = "0xEE5FC8", VA = "0xEE5FC8")]
		protected DisplayData()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class ImageDisplayData : DisplayData
	{
		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly Point pivot;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextureData texture;

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xEE9ACC", Offset = "0xEE9ACC", VA = "0xEE9ACC", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xEE9B08", Offset = "0xEE9B08", VA = "0xEE9B08")]
		public ImageDisplayData()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class ArmatureDisplayData : DisplayData
	{
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool inheritAnimation;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly List<ActionData> actions;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ArmatureData armature;

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xEA0E64", Offset = "0xEA0E64", VA = "0xEA0E64", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xEA0F90", Offset = "0xEA0F90", VA = "0xEA0F90")]
		internal void AddAction(ActionData value)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xEA0FF8", Offset = "0xEA0FF8", VA = "0xEA0FF8")]
		public ArmatureDisplayData()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class MeshDisplayData : DisplayData
	{
		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly VerticesData vertices;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextureData texture;

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xEEADAC", Offset = "0xEEADAC", VA = "0xEEADAC", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xEEADEC", Offset = "0xEEADEC", VA = "0xEEADEC")]
		public MeshDisplayData()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class BoundingBoxDisplayData : DisplayData
	{
		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BoundingBoxData boundingBox;

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xEE5F24", Offset = "0xEE5F24", VA = "0xEE5F24", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xEE5FC4", Offset = "0xEE5FC4", VA = "0xEE5FC4")]
		public BoundingBoxDisplayData()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class PathDisplayData : DisplayData
	{
		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool closed;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool constantSpeed;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly VerticesData vertices;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly List<float> curveLengths;

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x11731BC", Offset = "0x11731BC", VA = "0x11731BC", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1173278", Offset = "0x1173278", VA = "0x1173278")]
		public PathDisplayData()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class WeightData : BaseObject
	{
		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int count;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int offset;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly List<BoneData> bones;

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1183D78", Offset = "0x1183D78", VA = "0x1183D78", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1183DD4", Offset = "0x1183DD4", VA = "0x1183DD4")]
		internal void AddBone(BoneData value)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1183E3C", Offset = "0x1183E3C", VA = "0x1183E3C")]
		public WeightData()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class DragonBonesData : BaseObject
	{
		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool autoSearch;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint frameRate;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string version;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ArmatureData stage;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly List<uint> frameIndices;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly List<float> cachedFrames;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly List<string> armatureNames;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly Dictionary<string, ArmatureData> armatures;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal byte[] binary;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal short[] intArray;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal float[] floatArray;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal short[] frameIntArray;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal float[] frameFloatArray;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal short[] frameArray;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal ushort[] timelineArray;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal UserData userData;

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xEE8300", Offset = "0xEE8300", VA = "0xEE8300", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xEE84CC", Offset = "0xEE84CC", VA = "0xEE84CC")]
		public void AddArmature(ArmatureData value)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xEE85D8", Offset = "0xEE85D8", VA = "0xEE85D8")]
		public ArmatureData GetArmature(string armatureName)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xEE866C", Offset = "0xEE866C", VA = "0xEE866C")]
		public DragonBonesData()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class SkinData : BaseObject
	{
		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly Dictionary<string, List<DisplayData>> displays;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ArmatureData parent;

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1174070", Offset = "0x1174070", VA = "0x1174070", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x11742DC", Offset = "0x11742DC", VA = "0x11742DC")]
		public void AddDisplay(string slotName, DisplayData value)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x117440C", Offset = "0x117440C", VA = "0x117440C")]
		public DisplayData GetDisplay(string slotName, string displayName)
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x117452C", Offset = "0x117452C", VA = "0x117452C")]
		public List<DisplayData> GetDisplays(string slotName)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x11745D8", Offset = "0x11745D8", VA = "0x11745D8")]
		public SkinData()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public abstract class TextureAtlasData : BaseObject
	{
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool autoSearch;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint width;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint height;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float scale;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string name;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string imagePath;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly Dictionary<string, TextureData> textures;

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1178930", Offset = "0x1178930", VA = "0x1178930")]
		public TextureAtlasData()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x11789C0", Offset = "0x11789C0", VA = "0x11789C0", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1178B04", Offset = "0x1178B04", VA = "0x1178B04")]
		public void CopyFrom(TextureAtlasData value)
		{
		}

		[Token(Token = "0x6000309")]
		public abstract TextureData CreateTexture();

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1178D80", Offset = "0x1178D80", VA = "0x1178D80")]
		public void AddTexture(TextureData value)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1178E9C", Offset = "0x1178E9C", VA = "0x1178E9C")]
		public TextureData GetTexture(string name)
		{
			return null;
		}
	}
	[Token(Token = "0x2000088")]
	public abstract class TextureData : BaseObject
	{
		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool rotated;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly Rectangle region;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextureAtlasData parent;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Rectangle frame;

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1178F30", Offset = "0x1178F30", VA = "0x1178F30")]
		public static Rectangle CreateRectangle()
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1178F8C", Offset = "0x1178F8C", VA = "0x1178F8C", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1178FF4", Offset = "0x1178FF4", VA = "0x1178FF4", Slot = "5")]
		public virtual void CopyFrom(TextureData value)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x11790B4", Offset = "0x11790B4", VA = "0x11790B4")]
		protected TextureData()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class UserData : BaseObject
	{
		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly List<int> ints;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly List<float> floats;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly List<string> strings;

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1183908", Offset = "0x1183908", VA = "0x1183908", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1183990", Offset = "0x1183990", VA = "0x1183990")]
		internal void AddInt(int value)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x11839F8", Offset = "0x11839F8", VA = "0x11839F8")]
		internal void AddFloat(float value)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1183A60", Offset = "0x1183A60", VA = "0x1183A60")]
		internal void AddString(string value)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1183AC8", Offset = "0x1183AC8", VA = "0x1183AC8")]
		public int GetInt(int index = 0)
		{
			return default(int);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1183B50", Offset = "0x1183B50", VA = "0x1183B50")]
		public float GetFloat(int index = 0)
		{
			return default(float);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1183BD4", Offset = "0x1183BD4", VA = "0x1183BD4")]
		public string GetString(int index = 0)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1183C6C", Offset = "0x1183C6C", VA = "0x1183C6C")]
		public UserData()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class ActionData : BaseObject
	{
		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ActionType type;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BoneData bone;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SlotData slot;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UserData data;

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xE950B0", Offset = "0xE950B0", VA = "0xE950B0", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xE95118", Offset = "0xE95118", VA = "0xE95118")]
		public ActionData()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class BinaryDataParser : ObjectDataParser
	{
		[Token(Token = "0x20000EC")]
		public delegate object JsonParseDelegate(string json);

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static JsonParseDelegate jsonParseDelegate;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int _binaryOffset;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private byte[] _binary;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private short[] _intArrayBuffer;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float[] _floatArrayBuffer;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private short[] _frameIntArrayBuffer;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private float[] _frameFloatArrayBuffer;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private short[] _frameArrayBuffer;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private ushort[] _timelineArrayBuffer;

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xEDFBFC", Offset = "0xEDFBFC", VA = "0xEDFBFC")]
		private TimelineData _ParseBinaryTimeline(TimelineType type, uint offset, [Optional] TimelineData timelineData)
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xEDFE64", Offset = "0xEDFE64", VA = "0xEDFE64")]
		private void _ParseVertices(Dictionary<string, object> rawData, VerticesData vertices)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xEE0098", Offset = "0xEE0098", VA = "0xEE0098", Slot = "6")]
		protected override void _ParseMesh(Dictionary<string, object> rawData, MeshDisplayData mesh)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xEE00B0", Offset = "0xEE00B0", VA = "0xEE00B0", Slot = "7")]
		protected override AnimationData _ParseAnimation(Dictionary<string, object> rawData)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xEE0F1C", Offset = "0xEE0F1C", VA = "0xEE0F1C", Slot = "8")]
		protected override void _ParseArray(Dictionary<string, object> rawData)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xEE15FC", Offset = "0xEE15FC", VA = "0xEE15FC", Slot = "4")]
		public override DragonBonesData ParseDragonBonesData(object rawObj, float scale = 1f)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xEE16FC", Offset = "0xEE16FC", VA = "0xEE16FC")]
		public static Dictionary<string, object> DeserializeBinaryJsonData(byte[] bytes, out int headerLength, [Optional] JsonParseDelegate jsonParse)
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xEE2498", Offset = "0xEE2498", VA = "0xEE2498")]
		public BinaryDataParser()
		{
		}
	}
	[Token(Token = "0x200008C")]
	internal class BinaryDataReader : BinaryReader
	{
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int i;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int readLength;

		[Token(Token = "0x17000043")]
		private long Length
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0xEE3580", Offset = "0xEE3580", VA = "0xEE3580")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xEE15F4", Offset = "0xEE15F4", VA = "0xEE15F4")]
		internal BinaryDataReader(Stream stream)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xEE2840", Offset = "0xEE2840", VA = "0xEE2840")]
		internal BinaryDataReader(Stream stream, Encoding encoding)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xEE2848", Offset = "0xEE2848", VA = "0xEE2848", Slot = "27")]
		public virtual void Seek(int offset, SeekOrigin origin = SeekOrigin.Current)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xEE28A0", Offset = "0xEE28A0", VA = "0xEE28A0", Slot = "28")]
		public virtual bool[] ReadBooleans(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xEE298C", Offset = "0xEE298C", VA = "0xEE298C", Slot = "29")]
		public virtual byte[] ReadBytes(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xEE2A74", Offset = "0xEE2A74", VA = "0xEE2A74", Slot = "30")]
		public virtual char[] ReadChars(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xEE2B5C", Offset = "0xEE2B5C", VA = "0xEE2B5C", Slot = "31")]
		public virtual decimal[] ReadDecimals(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xEE2C48", Offset = "0xEE2C48", VA = "0xEE2C48", Slot = "32")]
		public virtual double[] ReadDoubles(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xEE2D30", Offset = "0xEE2D30", VA = "0xEE2D30", Slot = "33")]
		public virtual short[] ReadInt16s(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xEE2E18", Offset = "0xEE2E18", VA = "0xEE2E18", Slot = "34")]
		public virtual int[] ReadInt32s(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xEE2F00", Offset = "0xEE2F00", VA = "0xEE2F00", Slot = "35")]
		public virtual long[] ReadInt64s(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xEE2FE8", Offset = "0xEE2FE8", VA = "0xEE2FE8", Slot = "36")]
		public virtual sbyte[] ReadSBytes(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xEE30D0", Offset = "0xEE30D0", VA = "0xEE30D0", Slot = "37")]
		public virtual float[] ReadSingles(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xEE31B8", Offset = "0xEE31B8", VA = "0xEE31B8", Slot = "38")]
		public virtual string[] ReadStrings(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xEE32C8", Offset = "0xEE32C8", VA = "0xEE32C8", Slot = "39")]
		public virtual ushort[] ReadUInt16s(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xEE33B0", Offset = "0xEE33B0", VA = "0xEE33B0", Slot = "40")]
		public virtual uint[] ReadUInt32s(int offset, int readLength)
		{
			return null;
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xEE3498", Offset = "0xEE3498", VA = "0xEE3498", Slot = "41")]
		public virtual ulong[] ReadUInt64s(int offset, int readLength)
		{
			return null;
		}
	}
	[Token(Token = "0x200008D")]
	internal class BinaryDataWriter : BinaryWriter
	{
		[Token(Token = "0x17000044")]
		private long Length
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0xEE3E98", Offset = "0xEE3E98", VA = "0xEE3E98")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xEE35AC", Offset = "0xEE35AC", VA = "0xEE35AC")]
		public BinaryDataWriter()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xEE3638", Offset = "0xEE3638", VA = "0xEE3638")]
		internal BinaryDataWriter(Stream stream)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xEE36B0", Offset = "0xEE36B0", VA = "0xEE36B0")]
		public BinaryDataWriter(Encoding encoding)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xEE374C", Offset = "0xEE374C", VA = "0xEE374C")]
		internal BinaryDataWriter(Stream stream, Encoding encoding)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xEE37CC", Offset = "0xEE37CC", VA = "0xEE37CC", Slot = "25")]
		public virtual void Write(bool[] value)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xEE3848", Offset = "0xEE3848", VA = "0xEE3848", Slot = "11")]
		public override void Write(byte[] value)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xEE38C4", Offset = "0xEE38C4", VA = "0xEE38C4", Slot = "14")]
		public override void Write(char[] value)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xEE3940", Offset = "0xEE3940", VA = "0xEE3940", Slot = "26")]
		public virtual void Write(decimal[] value)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xEE39C0", Offset = "0xEE39C0", VA = "0xEE39C0", Slot = "27")]
		public virtual void Write(double[] value)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xEE3A3C", Offset = "0xEE3A3C", VA = "0xEE3A3C", Slot = "28")]
		public virtual void Write(short[] value)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xEE3AB8", Offset = "0xEE3AB8", VA = "0xEE3AB8", Slot = "29")]
		public virtual void Write(int[] value)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xEE3B34", Offset = "0xEE3B34", VA = "0xEE3B34", Slot = "30")]
		public virtual void Write(long[] value)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xEE3BB0", Offset = "0xEE3BB0", VA = "0xEE3BB0", Slot = "31")]
		public virtual void Write(sbyte[] value)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xEE3C2C", Offset = "0xEE3C2C", VA = "0xEE3C2C", Slot = "32")]
		public virtual void Write(float[] value)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xEE3CA8", Offset = "0xEE3CA8", VA = "0xEE3CA8", Slot = "33")]
		public virtual void Write(string[] value)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xEE3D24", Offset = "0xEE3D24", VA = "0xEE3D24", Slot = "34")]
		public virtual void Write(ushort[] value)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xEE3DA0", Offset = "0xEE3DA0", VA = "0xEE3DA0", Slot = "35")]
		public virtual void Write(uint[] value)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xEE3E1C", Offset = "0xEE3E1C", VA = "0xEE3E1C", Slot = "36")]
		public virtual void Write(ulong[] value)
		{
		}
	}
	[Token(Token = "0x200008E")]
	public abstract class DataParser
	{
		[Token(Token = "0x400042F")]
		protected const string DATA_VERSION_2_3 = "2.3";

		[Token(Token = "0x4000430")]
		protected const string DATA_VERSION_3_0 = "3.0";

		[Token(Token = "0x4000431")]
		protected const string DATA_VERSION_4_0 = "4.0";

		[Token(Token = "0x4000432")]
		protected const string DATA_VERSION_4_5 = "4.5";

		[Token(Token = "0x4000433")]
		protected const string DATA_VERSION_5_0 = "5.0";

		[Token(Token = "0x4000434")]
		protected const string DATA_VERSION_5_5 = "5.5";

		[Token(Token = "0x4000435")]
		protected const string DATA_VERSION = "5.5";

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static readonly List<string> DATA_VERSIONS;

		[Token(Token = "0x4000437")]
		protected const string TEXTURE_ATLAS = "textureAtlas";

		[Token(Token = "0x4000438")]
		protected const string SUB_TEXTURE = "SubTexture";

		[Token(Token = "0x4000439")]
		protected const string FORMAT = "format";

		[Token(Token = "0x400043A")]
		protected const string IMAGE_PATH = "imagePath";

		[Token(Token = "0x400043B")]
		protected const string WIDTH = "width";

		[Token(Token = "0x400043C")]
		protected const string HEIGHT = "height";

		[Token(Token = "0x400043D")]
		protected const string ROTATED = "rotated";

		[Token(Token = "0x400043E")]
		protected const string FRAME_X = "frameX";

		[Token(Token = "0x400043F")]
		protected const string FRAME_Y = "frameY";

		[Token(Token = "0x4000440")]
		protected const string FRAME_WIDTH = "frameWidth";

		[Token(Token = "0x4000441")]
		protected const string FRAME_HEIGHT = "frameHeight";

		[Token(Token = "0x4000442")]
		protected const string DRADON_BONES = "dragonBones";

		[Token(Token = "0x4000443")]
		protected const string USER_DATA = "userData";

		[Token(Token = "0x4000444")]
		protected const string ARMATURE = "armature";

		[Token(Token = "0x4000445")]
		protected const string BONE = "bone";

		[Token(Token = "0x4000446")]
		protected const string SLOT = "slot";

		[Token(Token = "0x4000447")]
		protected const string CONSTRAINT = "constraint";

		[Token(Token = "0x4000448")]
		protected const string IK = "ik";

		[Token(Token = "0x4000449")]
		protected const string SKIN = "skin";

		[Token(Token = "0x400044A")]
		protected const string DISPLAY = "display";

		[Token(Token = "0x400044B")]
		protected const string ANIMATION = "animation";

		[Token(Token = "0x400044C")]
		protected const string Z_ORDER = "zOrder";

		[Token(Token = "0x400044D")]
		protected const string FFD = "ffd";

		[Token(Token = "0x400044E")]
		protected const string FRAME = "frame";

		[Token(Token = "0x400044F")]
		protected const string TRANSLATE_FRAME = "translateFrame";

		[Token(Token = "0x4000450")]
		protected const string ROTATE_FRAME = "rotateFrame";

		[Token(Token = "0x4000451")]
		protected const string SCALE_FRAME = "scaleFrame";

		[Token(Token = "0x4000452")]
		protected const string DISPLAY_FRAME = "displayFrame";

		[Token(Token = "0x4000453")]
		protected const string COLOR_FRAME = "colorFrame";

		[Token(Token = "0x4000454")]
		protected const string DEFAULT_ACTIONS = "defaultActions";

		[Token(Token = "0x4000455")]
		protected const string ACTIONS = "actions";

		[Token(Token = "0x4000456")]
		protected const string EVENTS = "events";

		[Token(Token = "0x4000457")]
		protected const string INTS = "ints";

		[Token(Token = "0x4000458")]
		protected const string FLOATS = "floats";

		[Token(Token = "0x4000459")]
		protected const string STRINGS = "strings";

		[Token(Token = "0x400045A")]
		protected const string CANVAS = "canvas";

		[Token(Token = "0x400045B")]
		protected const string TRANSFORM = "transform";

		[Token(Token = "0x400045C")]
		protected const string PIVOT = "pivot";

		[Token(Token = "0x400045D")]
		protected const string AABB = "aabb";

		[Token(Token = "0x400045E")]
		protected const string COLOR = "color";

		[Token(Token = "0x400045F")]
		protected const string VERSION = "version";

		[Token(Token = "0x4000460")]
		protected const string COMPATIBLE_VERSION = "compatibleVersion";

		[Token(Token = "0x4000461")]
		protected const string FRAME_RATE = "frameRate";

		[Token(Token = "0x4000462")]
		protected const string TYPE = "type";

		[Token(Token = "0x4000463")]
		protected const string SUB_TYPE = "subType";

		[Token(Token = "0x4000464")]
		protected const string NAME = "name";

		[Token(Token = "0x4000465")]
		protected const string PARENT = "parent";

		[Token(Token = "0x4000466")]
		protected const string TARGET = "target";

		[Token(Token = "0x4000467")]
		protected const string STAGE = "stage";

		[Token(Token = "0x4000468")]
		protected const string SHARE = "share";

		[Token(Token = "0x4000469")]
		protected const string PATH = "path";

		[Token(Token = "0x400046A")]
		protected const string LENGTH = "length";

		[Token(Token = "0x400046B")]
		protected const string DISPLAY_INDEX = "displayIndex";

		[Token(Token = "0x400046C")]
		protected const string BLEND_MODE = "blendMode";

		[Token(Token = "0x400046D")]
		protected const string INHERIT_TRANSLATION = "inheritTranslation";

		[Token(Token = "0x400046E")]
		protected const string INHERIT_ROTATION = "inheritRotation";

		[Token(Token = "0x400046F")]
		protected const string INHERIT_SCALE = "inheritScale";

		[Token(Token = "0x4000470")]
		protected const string INHERIT_REFLECTION = "inheritReflection";

		[Token(Token = "0x4000471")]
		protected const string INHERIT_ANIMATION = "inheritAnimation";

		[Token(Token = "0x4000472")]
		protected const string INHERIT_DEFORM = "inheritDeform";

		[Token(Token = "0x4000473")]
		protected const string BEND_POSITIVE = "bendPositive";

		[Token(Token = "0x4000474")]
		protected const string CHAIN = "chain";

		[Token(Token = "0x4000475")]
		protected const string WEIGHT = "weight";

		[Token(Token = "0x4000476")]
		protected const string FADE_IN_TIME = "fadeInTime";

		[Token(Token = "0x4000477")]
		protected const string PLAY_TIMES = "playTimes";

		[Token(Token = "0x4000478")]
		protected const string SCALE = "scale";

		[Token(Token = "0x4000479")]
		protected const string OFFSET = "offset";

		[Token(Token = "0x400047A")]
		protected const string POSITION = "position";

		[Token(Token = "0x400047B")]
		protected const string DURATION = "duration";

		[Token(Token = "0x400047C")]
		protected const string TWEEN_TYPE = "tweenType";

		[Token(Token = "0x400047D")]
		protected const string TWEEN_EASING = "tweenEasing";

		[Token(Token = "0x400047E")]
		protected const string TWEEN_ROTATE = "tweenRotate";

		[Token(Token = "0x400047F")]
		protected const string TWEEN_SCALE = "tweenScale";

		[Token(Token = "0x4000480")]
		protected const string CLOCK_WISE = "clockwise";

		[Token(Token = "0x4000481")]
		protected const string CURVE = "curve";

		[Token(Token = "0x4000482")]
		protected const string SOUND = "sound";

		[Token(Token = "0x4000483")]
		protected const string EVENT = "event";

		[Token(Token = "0x4000484")]
		protected const string ACTION = "action";

		[Token(Token = "0x4000485")]
		protected const string X = "x";

		[Token(Token = "0x4000486")]
		protected const string Y = "y";

		[Token(Token = "0x4000487")]
		protected const string SKEW_X = "skX";

		[Token(Token = "0x4000488")]
		protected const string SKEW_Y = "skY";

		[Token(Token = "0x4000489")]
		protected const string SCALE_X = "scX";

		[Token(Token = "0x400048A")]
		protected const string SCALE_Y = "scY";

		[Token(Token = "0x400048B")]
		protected const string VALUE = "value";

		[Token(Token = "0x400048C")]
		protected const string ROTATE = "rotate";

		[Token(Token = "0x400048D")]
		protected const string SKEW = "skew";

		[Token(Token = "0x400048E")]
		protected const string ALPHA_OFFSET = "aO";

		[Token(Token = "0x400048F")]
		protected const string RED_OFFSET = "rO";

		[Token(Token = "0x4000490")]
		protected const string GREEN_OFFSET = "gO";

		[Token(Token = "0x4000491")]
		protected const string BLUE_OFFSET = "bO";

		[Token(Token = "0x4000492")]
		protected const string ALPHA_MULTIPLIER = "aM";

		[Token(Token = "0x4000493")]
		protected const string RED_MULTIPLIER = "rM";

		[Token(Token = "0x4000494")]
		protected const string GREEN_MULTIPLIER = "gM";

		[Token(Token = "0x4000495")]
		protected const string BLUE_MULTIPLIER = "bM";

		[Token(Token = "0x4000496")]
		protected const string UVS = "uvs";

		[Token(Token = "0x4000497")]
		protected const string VERTICES = "vertices";

		[Token(Token = "0x4000498")]
		protected const string TRIANGLES = "triangles";

		[Token(Token = "0x4000499")]
		protected const string WEIGHTS = "weights";

		[Token(Token = "0x400049A")]
		protected const string SLOT_POSE = "slotPose";

		[Token(Token = "0x400049B")]
		protected const string BONE_POSE = "bonePose";

		[Token(Token = "0x400049C")]
		protected const string GOTO_AND_PLAY = "gotoAndPlay";

		[Token(Token = "0x400049D")]
		protected const string DEFAULT_NAME = "default";

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xEE66E4", Offset = "0xEE66E4", VA = "0xEE66E4")]
		protected static ArmatureType _GetArmatureType(string value)
		{
			return default(ArmatureType);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xEE67A4", Offset = "0xEE67A4", VA = "0xEE67A4")]
		protected static DisplayType _GetDisplayType(string value)
		{
			return default(DisplayType);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xEE6888", Offset = "0xEE6888", VA = "0xEE6888")]
		protected static BoundingBoxType _GetBoundingBoxType(string value)
		{
			return default(BoundingBoxType);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xEE6948", Offset = "0xEE6948", VA = "0xEE6948")]
		protected static ActionType _GetActionType(string value)
		{
			return default(ActionType);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xEE6A08", Offset = "0xEE6A08", VA = "0xEE6A08")]
		protected static BlendMode _GetBlendMode(string value)
		{
			return default(BlendMode);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xEE6D8C", Offset = "0xEE6D8C", VA = "0xEE6D8C")]
		public DataParser()
		{
		}

		[Token(Token = "0x600034D")]
		public abstract DragonBonesData ParseDragonBonesData(object rawData, float scale);

		[Token(Token = "0x600034E")]
		public abstract bool ParseTextureAtlasData(object rawData, TextureAtlasData textureAtlasData, float scale);
	}
	[Token(Token = "0x200008F")]
	public class ObjectDataParser : DataParser
	{
		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected int _rawTextureAtlasIndex;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly List<BoneData> _rawBones;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected DragonBonesData _data;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ArmatureData _armature;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected BoneData _bone;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected SlotData _slot;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected SkinData _skin;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected MeshDisplayData _mesh;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected AnimationData _animation;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected TimelineData _timeline;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected List<object> _rawTextureAtlases;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _defaultColorOffset;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int _prevClockwise;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _prevRotation;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly Matrix _helpMatrixA;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Matrix _helpMatrixB;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly Transform _helpTransform;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly ColorTransform _helpColorTransform;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly Point _helpPoint;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly List<float> _helpArray;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly List<short> _intArray;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly List<float> _floatArray;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<short> _frameIntArray;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private readonly List<float> _frameFloatArray;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly List<short> _frameArray;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly List<ushort> _timelineArray;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<object> _cacheRawMeshes;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly List<MeshDisplayData> _cacheMeshes;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly List<ActionFrame> _actionFrames;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly Dictionary<string, List<float>> _weightSlotPose;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly Dictionary<string, List<float>> _weightBonePoses;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private readonly Dictionary<string, List<uint>> _weightBoneIndices;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly Dictionary<string, List<BoneData>> _cacheBones;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private readonly Dictionary<string, List<ActionData>> _slotChildActions;

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xEEC8C0", Offset = "0xEEC8C0", VA = "0xEEC8C0")]
		protected static bool _GetBoolean(Dictionary<string, object> rawData, string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xEECA74", Offset = "0xEECA74", VA = "0xEECA74")]
		protected static uint _GetNumber(Dictionary<string, object> rawData, string key, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xEE0C30", Offset = "0xEE0C30", VA = "0xEE0C30")]
		protected static int _GetNumber(Dictionary<string, object> rawData, string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xEE0D24", Offset = "0xEE0D24", VA = "0xEE0D24")]
		protected static float _GetNumber(Dictionary<string, object> rawData, string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xEE0E24", Offset = "0xEE0E24", VA = "0xEE0E24")]
		protected static string _GetString(Dictionary<string, object> rawData, string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xEE249C", Offset = "0xEE249C", VA = "0xEE249C")]
		public ObjectDataParser()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xEECB68", Offset = "0xEECB68", VA = "0xEECB68")]
		private void _GetCurvePoint(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4, float t, Point result)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xEECBEC", Offset = "0xEECBEC", VA = "0xEECBEC")]
		private void _SamplingEasingCurve(float[] curve, List<float> samples)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xEECED4", Offset = "0xEECED4", VA = "0xEECED4")]
		private void _ParseActionDataInFrame(object rawData, int frameStart, [Optional] BoneData bone, [Optional] SlotData slot)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xEED12C", Offset = "0xEED12C", VA = "0xEED12C")]
		private void _MergeActionFrame(object rawData, int frameStart, ActionType type, [Optional] BoneData bone, [Optional] SlotData slot)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xEEE174", Offset = "0xEEE174", VA = "0xEEE174")]
		private int _ParseCacheActionFrame(ActionFrame frame)
		{
			return default(int);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xEEE2D0", Offset = "0xEEE2D0", VA = "0xEEE2D0")]
		private ArmatureData _ParseArmature(Dictionary<string, object> rawData, float scale)
		{
			return null;
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xEEF860", Offset = "0xEEF860", VA = "0xEEF860")]
		protected BoneData _ParseBone(Dictionary<string, object> rawData)
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xEEFA54", Offset = "0xEEFA54", VA = "0xEEFA54")]
		protected ConstraintData _ParseIKConstraint(Dictionary<string, object> rawData)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xEEFC18", Offset = "0xEEFC18", VA = "0xEEFC18")]
		private SlotData _ParseSlot(Dictionary<string, object> rawData, int zOrder)
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xEEFF44", Offset = "0xEEFF44", VA = "0xEEFF44")]
		protected SkinData _ParseSkin(Dictionary<string, object> rawData)
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xEF07DC", Offset = "0xEF07DC", VA = "0xEF07DC")]
		protected DisplayData _ParseDisplay(Dictionary<string, object> rawData)
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xEF0E74", Offset = "0xEF0E74", VA = "0xEF0E74")]
		protected void _ParsePivot(Dictionary<string, object> rawData, ImageDisplayData display)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xEF11D0", Offset = "0xEF11D0", VA = "0xEF11D0", Slot = "6")]
		protected virtual void _ParseMesh(Dictionary<string, object> rawData, MeshDisplayData mesh)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xEF0FB8", Offset = "0xEF0FB8", VA = "0xEF0FB8")]
		protected BoundingBoxData _ParseBoundingBox(Dictionary<string, object> rawData)
		{
			return null;
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xEF2148", Offset = "0xEF2148", VA = "0xEF2148")]
		protected PolygonBoundingBoxData _ParsePolygonBoundingBox(Dictionary<string, object> rawData)
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xEF24A8", Offset = "0xEF24A8", VA = "0xEF24A8", Slot = "7")]
		protected virtual AnimationData _ParseAnimation(Dictionary<string, object> rawData)
		{
			return null;
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xEF3554", Offset = "0xEF3554", VA = "0xEF3554")]
		protected TimelineData _ParseTimeline(Dictionary<string, object> rawData, List<object> rawFrames, string framesKey, TimelineType type, bool addIntOffset, bool addFloatOffset, uint frameValueCount, Func<Dictionary<string, object>, int, int, int> frameParser)
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xEF3C70", Offset = "0xEF3C70", VA = "0xEF3C70")]
		protected void _ParseBoneTimeline(Dictionary<string, object> rawData)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xEF3F98", Offset = "0xEF3F98", VA = "0xEF3F98")]
		protected void _ParseSlotTimeline(Dictionary<string, object> rawData)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xEF4194", Offset = "0xEF4194", VA = "0xEF4194")]
		protected int _ParseFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xEF4250", Offset = "0xEF4250", VA = "0xEF4250")]
		protected int _ParseTweenFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xEF49A8", Offset = "0xEF49A8", VA = "0xEF49A8")]
		private int _ParseZOrderFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xEF4EA8", Offset = "0xEF4EA8", VA = "0xEF4EA8")]
		protected int _ParseBoneAllFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xEF51CC", Offset = "0xEF51CC", VA = "0xEF51CC")]
		protected int _ParseBoneTranslateFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xEF52F8", Offset = "0xEF52F8", VA = "0xEF52F8")]
		protected int _ParseBoneRotateFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xEF5558", Offset = "0xEF5558", VA = "0xEF5558")]
		protected int _ParseBoneScaleFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xEF5684", Offset = "0xEF5684", VA = "0xEF5684")]
		protected int _ParseSlotDisplayFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xEF57C4", Offset = "0xEF57C4", VA = "0xEF57C4")]
		protected int _ParseSlotColorFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xEF61E8", Offset = "0xEF61E8", VA = "0xEF61E8")]
		protected int _ParseSlotFFDFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xEF6A4C", Offset = "0xEF6A4C", VA = "0xEF6A4C")]
		protected int _ParseIKConstraintFrame(Dictionary<string, object> rawData, int frameStart, int frameCount)
		{
			return default(int);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xEED464", Offset = "0xEED464", VA = "0xEED464")]
		protected List<ActionData> _ParseActionData(object rawData, ActionType type, [Optional] BoneData bone, [Optional] SlotData slot)
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xEF0410", Offset = "0xEF0410", VA = "0xEF0410")]
		protected void _ParseTransform(Dictionary<string, object> rawData, Transform transform, float scale)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xEF0678", Offset = "0xEF0678", VA = "0xEF0678")]
		protected void _ParseColorTransform(Dictionary<string, object> rawData, ColorTransform color)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xEF6C3C", Offset = "0xEF6C3C", VA = "0xEF6C3C", Slot = "8")]
		protected virtual void _ParseArray(Dictionary<string, object> rawData)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xEF6CFC", Offset = "0xEF6CFC", VA = "0xEF6CFC")]
		protected void _ModifyArray()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xEE1BDC", Offset = "0xEE1BDC", VA = "0xEE1BDC", Slot = "4")]
		public override DragonBonesData ParseDragonBonesData(object rawObj, float scale = 1f)
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xEF74D8", Offset = "0xEF74D8", VA = "0xEF74D8", Slot = "5")]
		public override bool ParseTextureAtlasData(object rawObj, TextureAtlasData textureAtlasData, float scale = 1f)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000090")]
	internal class ActionFrame
	{
		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int frameStart;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly List<int> actions;

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xE95180", Offset = "0xE95180", VA = "0xE95180")]
		public ActionFrame()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class MeshBuffer : IDisposable
	{
		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly List<UnitySlot> combineSlots;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mesh sharedMesh;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int vertexCount;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3[] rawVertextBuffers;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector2[] uvBuffers;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3[] vertexBuffers;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color32[] color32Buffers;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int[] triangleBuffers;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool vertexDirty;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool zorderDirty;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool enabled;

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xEEA40C", Offset = "0xEEA40C", VA = "0xEEA40C")]
		public static Mesh GenerateMesh()
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xEEA48C", Offset = "0xEEA48C", VA = "0xEEA48C")]
		private static int _OnSortSlots(Slot a, Slot b)
		{
			return default(int);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xEEA4C8", Offset = "0xEEA4C8", VA = "0xEEA4C8", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xEEA594", Offset = "0xEEA594", VA = "0xEEA594")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xEEA69C", Offset = "0xEEA69C", VA = "0xEEA69C")]
		public void CombineMeshes(CombineInstance[] combines)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xEEA7F4", Offset = "0xEEA7F4", VA = "0xEEA7F4")]
		public void InitMesh()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xEEA8E0", Offset = "0xEEA8E0", VA = "0xEEA8E0")]
		public void UpdateVertices()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xEEA920", Offset = "0xEEA920", VA = "0xEEA920")]
		public void UpdateColors()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xEEA944", Offset = "0xEEA944", VA = "0xEEA944")]
		public void UpdateOrder()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xEEAD3C", Offset = "0xEEAD3C", VA = "0xEEAD3C")]
		public MeshBuffer()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public enum SortingMode
	{
		[Token(Token = "0x40004CF")]
		SortByZ,
		[Token(Token = "0x40004D0")]
		SortByOrder
	}
	[Token(Token = "0x2000093")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class UnityArmatureComponent : DragonBoneEventDispatcher, IArmatureProxy, IEventDispatcher<EventObject>
	{
		[Token(Token = "0x40004D1")]
		public const int ORDER_SPACE = 10;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityDragonBonesData unityData;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string armatureName;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isUGUI;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool debugDraw;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal readonly ColorTransform _colorTransform;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string animationName;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _disposeProxy;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal Armature _armature;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95BF7C", Offset = "0x95BF7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BF7C", Offset = "0x95BF7C")]
		[SerializeField]
		protected int _playTimes;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95BFE4", Offset = "0x95BFE4")]
		[SerializeField]
		protected float _timeScale;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		internal SortingMode _sortingMode;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		internal string _sortingLayerName;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		internal int _sortingOrder;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		internal float _zSpace;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected bool _flipX;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[SerializeField]
		protected bool _flipY;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		[SerializeField]
		protected bool _closeCombineMeshs;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
		private bool _hasSortingGroup;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material _debugDrawer;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal int _armatureZ;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal SortingGroup _sortingGroup;

		[Token(Token = "0x17000045")]
		public Armature armature
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x117AB20", Offset = "0x117AB20", VA = "0x117AB20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public Animation animation
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x117AB28", Offset = "0x117AB28", VA = "0x117AB28", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public SortingMode sortingMode
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x117AB40", Offset = "0x117AB40", VA = "0x117AB40")]
			get
			{
				return default(SortingMode);
			}
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x117AB48", Offset = "0x117AB48", VA = "0x117AB48")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public string sortingLayerName
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x117AFD8", Offset = "0x117AFD8", VA = "0x117AFD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x117AFE0", Offset = "0x117AFE0", VA = "0x117AFE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public int sortingOrder
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x117B014", Offset = "0x117B014", VA = "0x117B014")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x117B01C", Offset = "0x117B01C", VA = "0x117B01C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public float zSpace
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x117B024", Offset = "0x117B024", VA = "0x117B024")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x117B02C", Offset = "0x117B02C", VA = "0x117B02C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public ColorTransform color
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x117B090", Offset = "0x117B090", VA = "0x117B090")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x117B098", Offset = "0x117B098", VA = "0x117B098")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public SortingGroup sortingGroup
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x117B1B4", Offset = "0x117B1B4", VA = "0x117B1B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1179F64", Offset = "0x1179F64", VA = "0x1179F64", Slot = "9")]
		public void DBClear()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x117A140", Offset = "0x117A140", VA = "0x117A140", Slot = "8")]
		public void DBInit(Armature armature)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x117A148", Offset = "0x117A148", VA = "0x117A148", Slot = "10")]
		public void DBUpdate()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x117A14C", Offset = "0x117A14C", VA = "0x117A14C")]
		private void CreateLineMaterial()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x117A2AC", Offset = "0x117A2AC", VA = "0x117A2AC")]
		private void OnRenderObject()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x117AB00", Offset = "0x117AB00", VA = "0x117AB00", Slot = "11")]
		public void Dispose(bool disposeProxy = true)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x117B1BC", Offset = "0x117B1BC", VA = "0x117B1BC")]
		private void _UpdateSortingGroup()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x117AC88", Offset = "0x117AC88", VA = "0x117AC88")]
		private void _UpdateSlotsSorting()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x117B8B0", Offset = "0x117B8B0", VA = "0x117B8B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x117BEAC", Offset = "0x117BEAC", VA = "0x117BEAC")]
		private void Start()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x117C2C0", Offset = "0x117C2C0", VA = "0x117C2C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x117C390", Offset = "0x117C390", VA = "0x117C390")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x117C0C4", Offset = "0x117C0C4", VA = "0x117C0C4")]
		private void OpenCombineMeshs()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x117BEBC", Offset = "0x117BEBC", VA = "0x117BEBC")]
		public void CloseCombineMeshs()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x117C43C", Offset = "0x117C43C", VA = "0x117C43C")]
		public UnityArmatureComponent()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95B388", Offset = "0x95B388")]
	public class UnityCombineMeshs : MonoBehaviour
	{
		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public List<string> slotNames;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public MeshBuffer[] meshBuffers;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool dirty;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityArmatureComponent _unityArmature;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _subSlotCount;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _verticeOffset;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _isCanCombineMesh;

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x117C4C4", Offset = "0x117C4C4", VA = "0x117C4C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x117C528", Offset = "0x117C528", VA = "0x117C528")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x117C618", Offset = "0x117C618", VA = "0x117C618")]
		private void RestoreArmature(Armature armature)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x117C944", Offset = "0x117C944", VA = "0x117C944")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x117C9F8", Offset = "0x117C9F8", VA = "0x117C9F8")]
		public void BeginCombineMesh()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x117CEA0", Offset = "0x117CEA0", VA = "0x117CEA0")]
		public void CollectMesh(Armature armature, List<CombineMeshInfo> combineSlots)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x117D424", Offset = "0x117D424", VA = "0x117D424")]
		public UnityCombineMeshs()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public struct CombineMeshInfo
	{
		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UnitySlot proxySlot;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public List<CombineInstance> combines;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<UnitySlot> slots;
	}
	[Serializable]
	[Token(Token = "0x2000096")]
	public class UnityDragonBonesData : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20000ED")]
		public class TextureAtlas
		{
			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TextAsset textureAtlasJSON;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Texture2D texture;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Material material;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Material uiMaterial;

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x117D60C", Offset = "0x117D60C", VA = "0x117D60C")]
			public TextureAtlas()
			{
			}
		}

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string dataName;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextAsset dragonBonesJSON;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextureAtlas[] textureAtlas;

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x117D494", Offset = "0x117D494", VA = "0x117D494")]
		public void RemoveFromFactory(bool disposeData = true)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x117D604", Offset = "0x117D604", VA = "0x117D604")]
		public UnityDragonBonesData()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class UnityEventDispatcher<T> : MonoBehaviour
	{
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Dictionary<string, ListenerDelegate<T>> _listeners;

		[Token(Token = "0x60003AB")]
		public UnityEventDispatcher()
		{
		}

		[Token(Token = "0x60003AC")]
		public void DispatchEvent(string type, T eventObject)
		{
		}

		[Token(Token = "0x60003AD")]
		public bool HasEventListener(string type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		public void AddEventListener(string type, ListenerDelegate<T> listener)
		{
		}

		[Token(Token = "0x60003AF")]
		public void RemoveEventListener(string type, ListenerDelegate<T> listener)
		{
		}
	}
	[Token(Token = "0x2000098")]
	[DisallowMultipleComponent]
	public class DragonBoneEventDispatcher : UnityEventDispatcher<EventObject>, IEventDispatcher<EventObject>
	{
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xEE7E78", Offset = "0xEE7E78", VA = "0xEE7E78", Slot = "6")]
		public void AddDBEventListener(string type, ListenerDelegate<EventObject> listener)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xEE7EE0", Offset = "0xEE7EE0", VA = "0xEE7EE0", Slot = "5")]
		public void DispatchDBEvent(string type, EventObject eventObject)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xEE7F48", Offset = "0xEE7F48", VA = "0xEE7F48", Slot = "4")]
		public bool HasDBEventListener(string type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xEE7FA8", Offset = "0xEE7FA8", VA = "0xEE7FA8", Slot = "7")]
		public void RemoveDBEventListener(string type, ListenerDelegate<EventObject> listener)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xEE8010", Offset = "0xEE8010", VA = "0xEE8010")]
		public DragonBoneEventDispatcher()
		{
		}
	}
	[Token(Token = "0x2000099")]
	internal class ClockHandler : MonoBehaviour
	{
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xEE6118", Offset = "0xEE6118", VA = "0xEE6118")]
		private void Update()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xEE640C", Offset = "0xEE640C", VA = "0xEE640C")]
		public ClockHandler()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class UnityFactory : BaseFactory
	{
		[Token(Token = "0x40004F5")]
		internal const string defaultShaderName = "Sprites/Default";

		[Token(Token = "0x40004F6")]
		internal const string defaultUIShaderName = "UI/Default";

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static DragonBones _dragonBonesInstance;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static UnityFactory _factory;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static GameObject _gameObject;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject _armatureGameObject;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _isUGUI;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<UnityDragonBonesData> _cacheUnityDragonBonesData;

		[Token(Token = "0x1700004D")]
		public static UnityFactory factory
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x117BADC", Offset = "0x117BADC", VA = "0x117BADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IEventDispatcher<EventObject> soundEventManager
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x117EAE8", Offset = "0x117EAE8", VA = "0x117EAE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x117D614", Offset = "0x117D614", VA = "0x117D614")]
		public UnityFactory([Optional] DataParser dataParser)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x117D6BC", Offset = "0x117D6BC", VA = "0x117D6BC")]
		private void Init()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x117DBA4", Offset = "0x117DBA4", VA = "0x117DBA4", Slot = "5")]
		protected override TextureAtlasData _BuildTextureAtlasData(TextureAtlasData textureAtlasData, object textureAtlas)
		{
			return null;
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x117DCFC", Offset = "0x117DCFC", VA = "0x117DCFC", Slot = "6")]
		protected override Armature _BuildArmature(BuildArmaturePackage dataPackage)
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x117E01C", Offset = "0x117E01C", VA = "0x117E01C", Slot = "4")]
		protected override Armature _BuildChildArmature(BuildArmaturePackage dataPackage, Slot slot, DisplayData displayData)
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x117E310", Offset = "0x117E310", VA = "0x117E310", Slot = "7")]
		protected override Slot _BuildSlot(BuildArmaturePackage dataPackage, SlotData slotData, Armature armature)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x117BDBC", Offset = "0x117BDBC", VA = "0x117BDBC")]
		public UnityArmatureComponent BuildArmatureComponent(string armatureName, string dragonBonesName = "", string skinName = "", string textureAtlasName = "", [Optional] GameObject gameObject, bool isUGUI = false)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x117E6C8", Offset = "0x117E6C8", VA = "0x117E6C8")]
		public GameObject GetTextureDisplay(string textureName, [Optional] string textureAtlasName)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x117E6D0", Offset = "0x117E6D0", VA = "0x117E6D0")]
		protected void _RefreshTextureAtlas(UnityTextureAtlasData textureAtlasData, bool isUGUI, bool isEditor = false)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x117EA6C", Offset = "0x117EA6C", VA = "0x117EA6C", Slot = "11")]
		public override void Clear(bool disposeData = true)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x117BB9C", Offset = "0x117BB9C", VA = "0x117BB9C")]
		public DragonBonesData LoadData(UnityDragonBonesData data, bool isUGUI = false, float armatureScale = 0.01f, float texScale = 1f)
		{
			return null;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x117EF44", Offset = "0x117EF44", VA = "0x117EF44")]
		public DragonBonesData LoadDragonBonesData(string dragonBonesJSONPath, string name = "", float scale = 0.01f)
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x117EB5C", Offset = "0x117EB5C", VA = "0x117EB5C")]
		public DragonBonesData LoadDragonBonesData(TextAsset dragonBonesJSON, string name = "", float scale = 0.01f)
		{
			return null;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x117F080", Offset = "0x117F080", VA = "0x117F080")]
		public UnityTextureAtlasData LoadTextureAtlasData(string textureAtlasJSONPath, string name = "", float scale = 1f, bool isUGUI = false)
		{
			return null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x117ED4C", Offset = "0x117ED4C", VA = "0x117ED4C")]
		public UnityTextureAtlasData LoadTextureAtlasData(UnityDragonBonesData.TextureAtlas textureAtlas, string name, float scale = 1f, bool isUGUI = false)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x117F344", Offset = "0x117F344", VA = "0x117F344")]
		public void RefreshAllTextureAtlas(UnityArmatureComponent unityArmature)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x117F5D0", Offset = "0x117F5D0", VA = "0x117F5D0", Slot = "13")]
		public override void ReplaceDisplay(Slot slot, DisplayData displayData, int displayIndex = -1)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x117F794", Offset = "0x117F794", VA = "0x117F794")]
		public void ReplaceSlotDisplay(string dragonBonesName, string armatureName, string slotName, string displayName, Slot slot, Texture2D texture, [Optional] Material material, bool isUGUI = false, int displayIndex = -1)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1180040", Offset = "0x1180040", VA = "0x1180040")]
		public UnityDragonBonesData GetCacheUnityDragonBonesData(string draonBonesName)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1180138", Offset = "0x1180138", VA = "0x1180138")]
		public void AddCacheUnityDragonBonesData(UnityDragonBonesData unityData)
		{
		}
	}
	[Token(Token = "0x200009B")]
	internal static class UnityFactoryHelper
	{
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x117E9BC", Offset = "0x117E9BC", VA = "0x117E9BC")]
		internal static Material GenerateMaterial(string shaderName, string materialName, Texture texture)
		{
			return null;
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x117EFC0", Offset = "0x117EFC0", VA = "0x117EFC0")]
		internal static string CheckResourecdPath(string path)
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x117F22C", Offset = "0x117F22C", VA = "0x117F22C")]
		internal static string GetTextureAtlasImagePath(string textureAtlasJSONPath, string textureAtlasImageName)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x118022C", Offset = "0x118022C", VA = "0x118022C")]
		internal static string GetTextureAtlasNameByPath(string textureAtlasJSONPath)
		{
			return null;
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x117A0A0", Offset = "0x117A0A0", VA = "0x117A0A0")]
		internal static void DestroyUnityObject(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x200009C")]
	internal static class LogHelper
	{
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xEE9B6C", Offset = "0xEE9B6C", VA = "0xEE9B6C")]
		internal static void LogWarning(object message)
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class UnitySlot : Slot
	{
		[Token(Token = "0x40004FD")]
		internal const float Z_OFFSET = 0.001f;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] TRIANGLES;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Vector3 _helpVector3;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		internal GameObject _renderDisplay;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		internal UnityUGUIDisplay _uiDisplay;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		internal MeshBuffer _meshBuffer;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		internal MeshRenderer _meshRenderer;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		internal MeshFilter _meshFilter;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal bool _isIgnoreCombineMesh;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		internal bool _isCombineMesh;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		internal int _sumMeshIndex;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		internal int _verticeOrder;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		internal int _verticeOffset;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		internal UnityCombineMeshs _combineMesh;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal bool _isActive;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		private bool _skewed;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private UnityArmatureComponent _proxy;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private BlendMode _currentBlendMode;

		[Token(Token = "0x1700004F")]
		public Mesh mesh
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x1182ED0", Offset = "0x1182ED0", VA = "0x1182ED0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x1182EE8", Offset = "0x1182EE8", VA = "0x1182EE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public UnityTextureAtlasData currentTextureAtlasData
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x1181DB4", Offset = "0x1181DB4", VA = "0x1181DB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public GameObject renderDisplay
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x1182EF0", Offset = "0x1182EF0", VA = "0x1182EF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public UnityArmatureComponent proxy
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x1182EF8", Offset = "0x1182EF8", VA = "0x1182EF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public bool isIgnoreCombineMesh
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x1182F00", Offset = "0x1182F00", VA = "0x1182F00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1180310", Offset = "0x1180310", VA = "0x1180310")]
		public UnitySlot()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1180328", Offset = "0x1180328", VA = "0x1180328", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x118038C", Offset = "0x118038C", VA = "0x118038C", Slot = "5")]
		protected override void _InitDisplay(object value, bool isRetain)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1180390", Offset = "0x1180390", VA = "0x1180390", Slot = "6")]
		protected override void _DisposeDisplay(object value, bool isRelease)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1180418", Offset = "0x1180418", VA = "0x1180418", Slot = "7")]
		protected override void _OnUpdateDisplay()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x11806FC", Offset = "0x11806FC", VA = "0x11806FC", Slot = "8")]
		protected override void _AddDisplay()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x118089C", Offset = "0x118089C", VA = "0x118089C", Slot = "9")]
		protected override void _ReplaceDisplay(object value)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x11809DC", Offset = "0x11809DC", VA = "0x11809DC", Slot = "10")]
		protected override void _RemoveDisplay()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1180A0C", Offset = "0x1180A0C", VA = "0x1180A0C", Slot = "11")]
		protected override void _UpdateZOrder()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x117B64C", Offset = "0x117B64C", VA = "0x117B64C")]
		internal void _SetZorder(Vector3 zorderPos)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x117E594", Offset = "0x117E594", VA = "0x117E594")]
		public void DisallowCombineMesh()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x117C754", Offset = "0x117C754", VA = "0x117C754")]
		internal void CancelCombineMesh()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1180A70", Offset = "0x1180A70", VA = "0x1180A70")]
		private void _CombineMesh()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1180B44", Offset = "0x1180B44", VA = "0x1180B44", Slot = "12")]
		internal override void _UpdateVisible()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1180BA8", Offset = "0x1180BA8", VA = "0x1180BA8", Slot = "13")]
		internal override void _UpdateBlendMode()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1180E60", Offset = "0x1180E60", VA = "0x1180E60", Slot = "14")]
		protected override void _UpdateColor()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x11812B4", Offset = "0x11812B4", VA = "0x11812B4", Slot = "15")]
		protected override void _UpdateFrame()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1181EE8", Offset = "0x1181EE8", VA = "0x1181EE8", Slot = "18")]
		protected override void _IdentityTransform()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1181FCC", Offset = "0x1181FCC", VA = "0x1181FCC", Slot = "16")]
		protected override void _UpdateMesh()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x118272C", Offset = "0x118272C", VA = "0x118272C", Slot = "17")]
		protected override void _UpdateTransform()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class UnityTextureAtlasData : TextureAtlasData
	{
		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal bool _disposeEnabled;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Material texture;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Material uiTexture;

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x118003C", Offset = "0x118003C", VA = "0x118003C")]
		public UnityTextureAtlasData()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1182F94", Offset = "0x1182F94", VA = "0x1182F94", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1183074", Offset = "0x1183074", VA = "0x1183074", Slot = "5")]
		public override TextureData CreateTexture()
		{
			return null;
		}
	}
	[Token(Token = "0x200009F")]
	internal class UnityTextureData : TextureData
	{
		[Token(Token = "0x4000512")]
		public const string SHADER_PATH = "Shaders/";

		[Token(Token = "0x4000513")]
		public const string SHADER_GRAP = "DB_BlendMode_Grab";

		[Token(Token = "0x4000514")]
		public const string SHADER_FRAME_BUFFER = "DB_BlendMode_Framebuffer";

		[Token(Token = "0x4000515")]
		public const string UI_SHADER_GRAP = "DB_BlendMode_UIGrab";

		[Token(Token = "0x4000516")]
		public const string UI_SHADER_FRAME_BUFFER = "DB_BlendMode_UIFramebuffer";

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal Dictionary<string, Material> _cacheBlendModeMats;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x117FFD0", Offset = "0x117FFD0", VA = "0x117FFD0")]
		public UnityTextureData()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x11830DC", Offset = "0x11830DC", VA = "0x11830DC", Slot = "4")]
		protected override void _OnClear()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1183270", Offset = "0x1183270", VA = "0x1183270")]
		private Material _GetMaterial(BlendMode blendMode)
		{
			return null;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x11834A0", Offset = "0x11834A0", VA = "0x11834A0")]
		private Material _GetUIMaterial(BlendMode blendMode)
		{
			return null;
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1180E54", Offset = "0x1180E54", VA = "0x1180E54")]
		internal Material GetMaterial(BlendMode blendMode, bool isUGUI = false)
		{
			return null;
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x11836F0", Offset = "0x11836F0", VA = "0x11836F0", Slot = "5")]
		public override void CopyFrom(TextureData value)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x95B41C", Offset = "0x95B41C")]
	public class UnityUGUIDisplay : MaskableGraphic
	{
		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[HideInInspector]
		public Mesh sharedMesh;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Texture _texture;

		[Token(Token = "0x17000055")]
		public override Texture mainTexture
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x118378C", Offset = "0x118378C", VA = "0x118378C", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public Texture texture
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x1183834", Offset = "0x1183834", VA = "0x1183834")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x1181E40", Offset = "0x1181E40", VA = "0x1181E40")]
			set
			{
			}
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x118383C", Offset = "0x118383C", VA = "0x118383C", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1183858", Offset = "0x1183858", VA = "0x1183858", Slot = "37")]
		public override void Rebuild(CanvasUpdate update)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x11838CC", Offset = "0x11838CC", VA = "0x11838CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1183900", Offset = "0x1183900", VA = "0x1183900")]
		public UnityUGUIDisplay()
		{
		}
	}
}
namespace DragonBones.MiniJSON
{
	[Token(Token = "0x20000A1")]
	public static class Json
	{
		[Token(Token = "0x20000EE")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x200010D")]
			private enum TOKEN
			{
				[Token(Token = "0x400079E")]
				NONE,
				[Token(Token = "0x400079F")]
				CURLY_OPEN,
				[Token(Token = "0x40007A0")]
				CURLY_CLOSE,
				[Token(Token = "0x40007A1")]
				SQUARED_OPEN,
				[Token(Token = "0x40007A2")]
				SQUARED_CLOSE,
				[Token(Token = "0x40007A3")]
				COLON,
				[Token(Token = "0x40007A4")]
				COMMA,
				[Token(Token = "0x40007A5")]
				STRING,
				[Token(Token = "0x40007A6")]
				NUMBER,
				[Token(Token = "0x40007A7")]
				TRUE,
				[Token(Token = "0x40007A8")]
				FALSE,
				[Token(Token = "0x40007A9")]
				NULL
			}

			[Token(Token = "0x4000728")]
			private const string WORD_BREAK = "{}[],:\"";

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x17000081")]
			private char PeekChar
			{
				[Token(Token = "0x60007D5")]
				[Address(RVA = "0xEEBBE0", Offset = "0xEEBBE0", VA = "0xEEBBE0")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000082")]
			private char NextChar
			{
				[Token(Token = "0x60007D6")]
				[Address(RVA = "0xEEB9E8", Offset = "0xEEB9E8", VA = "0xEEB9E8")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x17000083")]
			private string NextWord
			{
				[Token(Token = "0x60007D7")]
				[Address(RVA = "0xEEBA70", Offset = "0xEEBA70", VA = "0xEEBA70")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000084")]
			private TOKEN NextToken
			{
				[Token(Token = "0x60007D8")]
				[Address(RVA = "0xEEB288", Offset = "0xEEB288", VA = "0xEEB288")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0xEEAFFC", Offset = "0xEEAFFC", VA = "0xEEAFFC")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0xEEB09C", Offset = "0xEEB09C", VA = "0xEEB09C")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0xEEAE50", Offset = "0xEEAE50", VA = "0xEEAE50")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0xEEB140", Offset = "0xEEB140", VA = "0xEEB140", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0xEEB174", Offset = "0xEEB174", VA = "0xEEB174")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0xEEB6B8", Offset = "0xEEB6B8", VA = "0xEEB6B8")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0xEEB118", Offset = "0xEEB118", VA = "0xEEB118")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0xEEB78C", Offset = "0xEEB78C", VA = "0xEEB78C")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0xEEB438", Offset = "0xEEB438", VA = "0xEEB438")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0xEEB868", Offset = "0xEEB868", VA = "0xEEB868")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0xEEBB2C", Offset = "0xEEBB2C", VA = "0xEEBB2C")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x20000EF")]
		private sealed class Serializer
		{
			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0xEEBC68", Offset = "0xEEBC68", VA = "0xEEBC68")]
			private Serializer()
			{
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0xEEAF80", Offset = "0xEEAF80", VA = "0xEEAF80")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0xEEBCD4", Offset = "0xEEBCD4", VA = "0xEEBCD4")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0xEEC274", Offset = "0xEEC274", VA = "0xEEC274")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0xEEC0D0", Offset = "0xEEC0D0", VA = "0xEEC0D0")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0xEEBE70", Offset = "0xEEBE70", VA = "0xEEBE70")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0xEEC65C", Offset = "0xEEC65C", VA = "0xEEC65C")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xEE20F0", Offset = "0xEE20F0", VA = "0xEE20F0")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xEEAF7C", Offset = "0xEEAF7C", VA = "0xEEAF7C")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95B4BC", Offset = "0x95B4BC")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float delay;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float duration;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Ease easeType;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LoopType loopType;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int loops;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string id;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool isRelative;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool isFrom;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		public bool isIndependentUpdate;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
		public bool autoKill;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool isActive;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
		public bool isValid;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Component target;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public DOTweenAnimationType animationType;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool autoPlay;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float endValueFloat;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Vector3 endValueV3;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color endValueColor;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string endValueString;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Rect endValueRect;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool optionalBool0;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float optionalFloat0;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public int optionalInt0;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public string optionalString;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int _playCount;

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xE92E60", Offset = "0xE92E60", VA = "0xE92E60")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xE94298", Offset = "0xE94298", VA = "0xE94298")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xE92E78", Offset = "0xE92E78", VA = "0xE92E78")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xE94384", Offset = "0xE94384", VA = "0xE94384", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xE94400", Offset = "0xE94400", VA = "0xE94400", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xE9447C", Offset = "0xE9447C", VA = "0xE9447C", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xE944F8", Offset = "0xE944F8", VA = "0xE944F8", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xE94574", Offset = "0xE94574", VA = "0xE94574", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xE945F0", Offset = "0xE945F0", VA = "0xE945F0", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xE946EC", Offset = "0xE946EC", VA = "0xE946EC", Slot = "10")]
		public override void DORestart(bool fromHere = false)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xE94984", Offset = "0xE94984", VA = "0xE94984", Slot = "11")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xE94A00", Offset = "0xE94A00", VA = "0xE94A00", Slot = "12")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xE94A88", Offset = "0xE94A88", VA = "0xE94A88")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xE94B14", Offset = "0xE94B14", VA = "0xE94B14")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xE94B7C", Offset = "0xE94B7C", VA = "0xE94B7C")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xE94CB0", Offset = "0xE94CB0", VA = "0xE94CB0")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xE94D40", Offset = "0xE94D40", VA = "0xE94D40")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xE94DD8", Offset = "0xE94DD8", VA = "0xE94DD8")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xE94E58", Offset = "0xE94E58", VA = "0xE94E58")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xE947E0", Offset = "0xE947E0", VA = "0xE947E0")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xE94ED8", Offset = "0xE94ED8", VA = "0xE94ED8")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xE950A8", Offset = "0xE950A8", VA = "0xE950A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D124", Offset = "0x95D124")]
		private void <CreateTween>b__30_0()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x6000417")]
		[Address(RVA = "0xE942D4", Offset = "0xE942D4", VA = "0xE942D4")]
		public static bool IsSameOrSubclassOf(this Type t, Type tBase)
		{
			return default(bool);
		}
	}
}
namespace CodeStage.AntiCheat.Utils
{
	[Token(Token = "0x20000A4")]
	public class ThreadSafeRandom
	{
		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly System.Random Global;

		[Token(Token = "0x4000537")]
		[ThreadStatic]
		private static System.Random local;

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xE927FC", Offset = "0xE927FC", VA = "0xE927FC")]
		public static int Next(int minInclusive, int maxExclusive)
		{
			return default(int);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xE8F70C", Offset = "0xE8F70C", VA = "0xE8F70C")]
		public static int Next()
		{
			return default(int);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xE929BC", Offset = "0xE929BC", VA = "0xE929BC")]
		public static int Next(int maxExclusive)
		{
			return default(int);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xE92A24", Offset = "0xE92A24", VA = "0xE92A24")]
		public ThreadSafeRandom()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	internal class xxHash
	{
		[Token(Token = "0x4000538")]
		private const uint PRIME32_1 = 2654435761u;

		[Token(Token = "0x4000539")]
		private const uint PRIME32_2 = 2246822519u;

		[Token(Token = "0x400053A")]
		private const uint PRIME32_3 = 3266489917u;

		[Token(Token = "0x400053B")]
		private const uint PRIME32_4 = 668265263u;

		[Token(Token = "0x400053C")]
		private const uint PRIME32_5 = 374761393u;

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xE92A98", Offset = "0xE92A98", VA = "0xE92A98")]
		public static uint CalculateHash(byte[] buf, int len, uint seed)
		{
			return default(uint);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xE92E58", Offset = "0xE92E58", VA = "0xE92E58")]
		public xxHash()
		{
		}
	}
}
namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	[Token(Token = "0x20000A6")]
	public struct ObscuredBool : IEquatable<ObscuredBool>, IComparable<ObscuredBool>, IComparable<bool>, IComparable
	{
		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static byte cryptoKey;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private byte currentCryptoKey;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int hiddenValue;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		[SerializeField]
		private bool fakeValue;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x95C124", Offset = "0x95C124")]
		private bool fakeValueActive;

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x11DA714", Offset = "0x11DA714", VA = "0x11DA714")]
		private ObscuredBool(bool value)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x11DA824", Offset = "0x11DA824", VA = "0x11DA824")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x11DA7BC", Offset = "0x11DA7BC", VA = "0x11DA7BC")]
		public static int Encrypt(bool value)
		{
			return default(int);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x11DA890", Offset = "0x11DA890", VA = "0x11DA890")]
		public static int Encrypt(bool value, byte key)
		{
			return default(int);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x11DA928", Offset = "0x11DA928", VA = "0x11DA928")]
		public static bool Decrypt(int value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x11DA990", Offset = "0x11DA990", VA = "0x11DA990")]
		public static bool Decrypt(int value, byte key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x11DAA20", Offset = "0x11DAA20", VA = "0x11DAA20")]
		public static ObscuredBool FromEncrypted(int encrypted)
		{
			return default(ObscuredBool);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x11DAB08", Offset = "0x11DAB08", VA = "0x11DAB08")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x11DAD08", Offset = "0x11DAD08", VA = "0x11DAD08")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x11DADC4", Offset = "0x11DADC4", VA = "0x11DADC4")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x11DAA54", Offset = "0x11DAA54", VA = "0x11DAA54")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x11DADE8", Offset = "0x11DADE8", VA = "0x11DADE8")]
		public bool GetDecrypted()
		{
			return default(bool);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x11DABD8", Offset = "0x11DABD8", VA = "0x11DABD8")]
		private bool InternalDecrypt()
		{
			return default(bool);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x11D9128", Offset = "0x11D9128", VA = "0x11D9128")]
		public static implicit operator ObscuredBool(bool value)
		{
			return default(ObscuredBool);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x11D915C", Offset = "0x11D915C", VA = "0x11D915C")]
		public static implicit operator bool(ObscuredBool value)
		{
			return default(bool);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x11DADEC", Offset = "0x11DADEC", VA = "0x11DADEC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x11DAE1C", Offset = "0x11DAE1C", VA = "0x11DAE1C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x11DAE4C", Offset = "0x11DAE4C", VA = "0x11DAE4C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x11DAEDC", Offset = "0x11DAEDC", VA = "0x11DAEDC", Slot = "4")]
		public bool Equals(ObscuredBool obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x11DAF90", Offset = "0x11DAF90", VA = "0x11DAF90", Slot = "5")]
		public int CompareTo(ObscuredBool other)
		{
			return default(int);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x11DAFD4", Offset = "0x11DAFD4", VA = "0x11DAFD4", Slot = "6")]
		public int CompareTo(bool other)
		{
			return default(int);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x11DB00C", Offset = "0x11DB00C", VA = "0x11DB00C", Slot = "7")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000A7")]
	public struct ObscuredByte : IFormattable, IEquatable<ObscuredByte>, IComparable<ObscuredByte>, IComparable<byte>, IComparable
	{
		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static byte cryptoKey;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte currentCryptoKey;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private byte hiddenValue;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private bool inited;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		private byte fakeValue;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private bool fakeValueActive;

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1952594", Offset = "0x1952594", VA = "0x1952594")]
		private ObscuredByte(byte value)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x19526A8", Offset = "0x19526A8", VA = "0x19526A8")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1952640", Offset = "0x1952640", VA = "0x1952640")]
		public static byte EncryptDecrypt(byte value)
		{
			return default(byte);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1952798", Offset = "0x1952798", VA = "0x1952798")]
		public static void EncryptDecrypt(byte[] value)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1952714", Offset = "0x1952714", VA = "0x1952714")]
		public static byte EncryptDecrypt(byte value, byte key)
		{
			return default(byte);
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1952800", Offset = "0x1952800", VA = "0x1952800")]
		public static void EncryptDecrypt(byte[] value, byte key)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x19528F4", Offset = "0x19528F4", VA = "0x19528F4")]
		public static ObscuredByte FromEncrypted(byte encrypted)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x19529E0", Offset = "0x19529E0", VA = "0x19529E0")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1952BFC", Offset = "0x1952BFC", VA = "0x1952BFC")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1952CB8", Offset = "0x1952CB8", VA = "0x1952CB8")]
		public byte GetEncrypted()
		{
			return default(byte);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x195292C", Offset = "0x195292C", VA = "0x195292C")]
		public void SetEncrypted(byte encrypted)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1952CDC", Offset = "0x1952CDC", VA = "0x1952CDC")]
		public byte GetDecrypted()
		{
			return default(byte);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1952AB0", Offset = "0x1952AB0", VA = "0x1952AB0")]
		private byte InternalDecrypt()
		{
			return default(byte);
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1952CE0", Offset = "0x1952CE0", VA = "0x1952CE0")]
		public static implicit operator ObscuredByte(byte value)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1952D18", Offset = "0x1952D18", VA = "0x1952D18")]
		public static implicit operator byte(ObscuredByte value)
		{
			return default(byte);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1952D44", Offset = "0x1952D44", VA = "0x1952D44")]
		public static ObscuredByte operator ++(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1952E04", Offset = "0x1952E04", VA = "0x1952E04")]
		public static ObscuredByte operator --(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1952EC4", Offset = "0x1952EC4", VA = "0x1952EC4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1952EF0", Offset = "0x1952EF0", VA = "0x1952EF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1952F1C", Offset = "0x1952F1C", VA = "0x1952F1C")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1952F50", Offset = "0x1952F50", VA = "0x1952F50")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1952F84", Offset = "0x1952F84", VA = "0x1952F84", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1952FC8", Offset = "0x1952FC8", VA = "0x1952FC8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x195305C", Offset = "0x195305C", VA = "0x195305C", Slot = "5")]
		public bool Equals(ObscuredByte obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x195310C", Offset = "0x195310C", VA = "0x195310C", Slot = "6")]
		public int CompareTo(ObscuredByte other)
		{
			return default(int);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1953150", Offset = "0x1953150", VA = "0x1953150", Slot = "7")]
		public int CompareTo(byte other)
		{
			return default(int);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1953184", Offset = "0x1953184", VA = "0x1953184", Slot = "8")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000A8")]
	public struct ObscuredChar : IEquatable<ObscuredChar>, IComparable<ObscuredChar>, IComparable<char>, IComparable
	{
		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static char cryptoKey;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private char currentCryptoKey;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private char hiddenValue;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private bool inited;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		private char fakeValue;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool fakeValueActive;

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x195320C", Offset = "0x195320C", VA = "0x195320C")]
		private ObscuredChar(char value)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1953320", Offset = "0x1953320", VA = "0x1953320")]
		public static void SetNewCryptoKey(char newKey)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x19532B8", Offset = "0x19532B8", VA = "0x19532B8")]
		public static char EncryptDecrypt(char value)
		{
			return default(char);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x195338C", Offset = "0x195338C", VA = "0x195338C")]
		public static char EncryptDecrypt(char value, char key)
		{
			return default(char);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1953410", Offset = "0x1953410", VA = "0x1953410")]
		public static ObscuredChar FromEncrypted(char encrypted)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x19534F8", Offset = "0x19534F8", VA = "0x19534F8")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1953718", Offset = "0x1953718", VA = "0x1953718")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x19537D4", Offset = "0x19537D4", VA = "0x19537D4")]
		public char GetEncrypted()
		{
			return default(char);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1953444", Offset = "0x1953444", VA = "0x1953444")]
		public void SetEncrypted(char encrypted)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x19537F8", Offset = "0x19537F8", VA = "0x19537F8")]
		public char GetDecrypted()
		{
			return default(char);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x19535C8", Offset = "0x19535C8", VA = "0x19535C8")]
		private char InternalDecrypt()
		{
			return default(char);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x19537FC", Offset = "0x19537FC", VA = "0x19537FC")]
		public static implicit operator ObscuredChar(char value)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1953830", Offset = "0x1953830", VA = "0x1953830")]
		public static implicit operator char(ObscuredChar value)
		{
			return default(char);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1953858", Offset = "0x1953858", VA = "0x1953858")]
		public static ObscuredChar operator ++(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1953910", Offset = "0x1953910", VA = "0x1953910")]
		public static ObscuredChar operator --(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x19539C8", Offset = "0x19539C8", VA = "0x19539C8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x19539F4", Offset = "0x19539F4", VA = "0x19539F4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1953A20", Offset = "0x1953A20", VA = "0x1953A20")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1953A54", Offset = "0x1953A54", VA = "0x1953A54", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1953AE4", Offset = "0x1953AE4", VA = "0x1953AE4", Slot = "4")]
		public bool Equals(ObscuredChar obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1953B90", Offset = "0x1953B90", VA = "0x1953B90", Slot = "5")]
		public int CompareTo(ObscuredChar other)
		{
			return default(int);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1953BD0", Offset = "0x1953BD0", VA = "0x1953BD0", Slot = "6")]
		public int CompareTo(char other)
		{
			return default(int);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1953C04", Offset = "0x1953C04", VA = "0x1953C04", Slot = "7")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000A9")]
	public struct ObscuredDecimal : IFormattable, IEquatable<ObscuredDecimal>, IComparable<ObscuredDecimal>, IComparable<decimal>, IComparable
	{
		[StructLayout(LayoutKind.Explicit)]
		[Token(Token = "0x20000F0")]
		private struct DecimalLongBytesUnion
		{
			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public decimal d;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long l1;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long l2;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ACTkByte16 b16;
		}

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private long currentCryptoKey;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private ACTkByte16 hiddenValue;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private decimal fakeValue;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool fakeValueActive;

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1953C8C", Offset = "0x1953C8C", VA = "0x1953C8C")]
		private ObscuredDecimal(decimal value)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1953DE8", Offset = "0x1953DE8", VA = "0x1953DE8")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1953E54", Offset = "0x1953E54", VA = "0x1953E54")]
		public static decimal Encrypt(decimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1953ED4", Offset = "0x1953ED4", VA = "0x1953ED4")]
		public static decimal Encrypt(decimal value, long key)
		{
			return default(decimal);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1953D70", Offset = "0x1953D70", VA = "0x1953D70")]
		private static ACTkByte16 InternalEncrypt(decimal value)
		{
			return default(ACTkByte16);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1953EE0", Offset = "0x1953EE0", VA = "0x1953EE0")]
		private static ACTkByte16 InternalEncrypt(decimal value, long key)
		{
			return default(ACTkByte16);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1953F68", Offset = "0x1953F68", VA = "0x1953F68")]
		public static decimal Decrypt(decimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1953FE8", Offset = "0x1953FE8", VA = "0x1953FE8")]
		public static decimal Decrypt(decimal value, long key)
		{
			return default(decimal);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1953FF4", Offset = "0x1953FF4", VA = "0x1953FF4")]
		public static ObscuredDecimal FromEncrypted(decimal encrypted)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1954100", Offset = "0x1954100", VA = "0x1954100")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1954368", Offset = "0x1954368", VA = "0x1954368")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1954424", Offset = "0x1954424", VA = "0x1954424")]
		public decimal GetEncrypted()
		{
			return default(decimal);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1954044", Offset = "0x1954044", VA = "0x1954044")]
		public void SetEncrypted(decimal encrypted)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1954448", Offset = "0x1954448", VA = "0x1954448")]
		public decimal GetDecrypted()
		{
			return default(decimal);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x19541D4", Offset = "0x19541D4", VA = "0x19541D4")]
		private decimal InternalDecrypt()
		{
			return default(decimal);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x195444C", Offset = "0x195444C", VA = "0x195444C")]
		public static implicit operator ObscuredDecimal(decimal value)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1954468", Offset = "0x1954468", VA = "0x1954468")]
		public static implicit operator decimal(ObscuredDecimal value)
		{
			return default(decimal);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x195446C", Offset = "0x195446C", VA = "0x195446C")]
		public static explicit operator ObscuredDecimal(ObscuredFloat f)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1954588", Offset = "0x1954588", VA = "0x1954588")]
		public static ObscuredDecimal operator ++(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x195469C", Offset = "0x195469C", VA = "0x195469C")]
		public static ObscuredDecimal operator --(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x19547B0", Offset = "0x19547B0", VA = "0x19547B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x19547DC", Offset = "0x19547DC", VA = "0x19547DC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1954808", Offset = "0x1954808", VA = "0x1954808")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1954844", Offset = "0x1954844", VA = "0x1954844")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1954880", Offset = "0x1954880", VA = "0x1954880", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x19548C4", Offset = "0x19548C4", VA = "0x19548C4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1954964", Offset = "0x1954964", VA = "0x1954964", Slot = "5")]
		public bool Equals(ObscuredDecimal obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x19549BC", Offset = "0x19549BC", VA = "0x19549BC", Slot = "6")]
		public int CompareTo(ObscuredDecimal other)
		{
			return default(int);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1954A0C", Offset = "0x1954A0C", VA = "0x1954A0C", Slot = "7")]
		public int CompareTo(decimal other)
		{
			return default(int);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1954A50", Offset = "0x1954A50", VA = "0x1954A50", Slot = "8")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000AA")]
	public struct ObscuredDouble : IFormattable, IEquatable<ObscuredDouble>, IComparable<ObscuredDouble>, IComparable<double>, IComparable
	{
		[StructLayout(LayoutKind.Explicit)]
		[Token(Token = "0x20000F1")]
		private struct DoubleLongBytesUnion
		{
			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double d;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long l;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ACTkByte8 b8;
		}

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private long currentCryptoKey;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private long hiddenValue;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x95C1D0", Offset = "0x95C1D0")]
		private ACTkByte8 hiddenValueOldByte8;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private double fakeValue;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool fakeValueActive;

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1954AE4", Offset = "0x1954AE4", VA = "0x1954AE4")]
		private ObscuredDouble(double value)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1954C44", Offset = "0x1954C44", VA = "0x1954C44")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1954CB0", Offset = "0x1954CB0", VA = "0x1954CB0")]
		public static long Encrypt(double value)
		{
			return default(long);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1954D48", Offset = "0x1954D48", VA = "0x1954D48")]
		public static long Encrypt(double value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1954B98", Offset = "0x1954B98", VA = "0x1954B98")]
		private static long InternalEncrypt(double value, long key = 0L)
		{
			return default(long);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1954D7C", Offset = "0x1954D7C", VA = "0x1954D7C")]
		public static double Decrypt(long value)
		{
			return default(double);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1954E0C", Offset = "0x1954E0C", VA = "0x1954E0C")]
		public static double Decrypt(long value, long key)
		{
			return default(double);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1954E44", Offset = "0x1954E44", VA = "0x1954E44")]
		public static long MigrateEncrypted(long encrypted, byte fromVersion = 0, byte toVersion = 2)
		{
			return default(long);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1954E88", Offset = "0x1954E88", VA = "0x1954E88")]
		public static ObscuredDouble FromEncrypted(long encrypted)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1954F88", Offset = "0x1954F88", VA = "0x1954F88")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x19551E4", Offset = "0x19551E4", VA = "0x19551E4")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x19552A8", Offset = "0x19552A8", VA = "0x19552A8")]
		public long GetEncrypted()
		{
			return default(long);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x1954ED4", Offset = "0x1954ED4", VA = "0x1954ED4")]
		public void SetEncrypted(long encrypted)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x19552CC", Offset = "0x19552CC", VA = "0x19552CC")]
		public double GetDecrypted()
		{
			return default(double);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x195505C", Offset = "0x195505C", VA = "0x195505C")]
		private double InternalDecrypt()
		{
			return default(double);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x19552D0", Offset = "0x19552D0", VA = "0x19552D0")]
		public static implicit operator ObscuredDouble(double value)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x19552E4", Offset = "0x19552E4", VA = "0x19552E4")]
		public static implicit operator double(ObscuredDouble value)
		{
			return default(double);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x19552E8", Offset = "0x19552E8", VA = "0x19552E8")]
		public static explicit operator ObscuredDouble(ObscuredFloat f)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x19553C8", Offset = "0x19553C8", VA = "0x19553C8")]
		public static ObscuredDouble operator ++(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1955490", Offset = "0x1955490", VA = "0x1955490")]
		public static ObscuredDouble operator --(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1955558", Offset = "0x1955558", VA = "0x1955558", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1955584", Offset = "0x1955584", VA = "0x1955584", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x19555B0", Offset = "0x19555B0", VA = "0x19555B0")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x19555E4", Offset = "0x19555E4", VA = "0x19555E4")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1955618", Offset = "0x1955618", VA = "0x1955618", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x195565C", Offset = "0x195565C", VA = "0x195565C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x19556FC", Offset = "0x19556FC", VA = "0x19556FC", Slot = "5")]
		public bool Equals(ObscuredDouble obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x195573C", Offset = "0x195573C", VA = "0x195573C", Slot = "6")]
		public int CompareTo(ObscuredDouble other)
		{
			return default(int);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1955774", Offset = "0x1955774", VA = "0x1955774", Slot = "7")]
		public int CompareTo(double other)
		{
			return default(int);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x19557A8", Offset = "0x19557A8", VA = "0x19557A8", Slot = "8")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public struct ObscuredFloat : IFormattable, IEquatable<ObscuredFloat>, IComparable<ObscuredFloat>, IComparable<float>, IComparable
	{
		[StructLayout(LayoutKind.Explicit)]
		[Token(Token = "0x20000F2")]
		internal struct FloatIntBytesUnion
		{
			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float f;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int i;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ACTkByte4 b4;
		}

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int hiddenValue;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x95C26C", Offset = "0x95C26C")]
		private ACTkByte4 hiddenValueOldByte4;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float fakeValue;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool fakeValueActive;

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1955834", Offset = "0x1955834", VA = "0x1955834")]
		private ObscuredFloat(float value)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1955994", Offset = "0x1955994", VA = "0x1955994")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1955A00", Offset = "0x1955A00", VA = "0x1955A00")]
		public static int Encrypt(float value)
		{
			return default(int);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1955A98", Offset = "0x1955A98", VA = "0x1955A98")]
		public static int Encrypt(float value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x19558E8", Offset = "0x19558E8", VA = "0x19558E8")]
		private static int InternalEncrypt(float value, int key = 0)
		{
			return default(int);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1955ACC", Offset = "0x1955ACC", VA = "0x1955ACC")]
		public static float Decrypt(int value)
		{
			return default(float);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1955B5C", Offset = "0x1955B5C", VA = "0x1955B5C")]
		public static float Decrypt(int value, int key)
		{
			return default(float);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1955B94", Offset = "0x1955B94", VA = "0x1955B94")]
		public static int MigrateEncrypted(int encrypted, byte fromVersion = 0, byte toVersion = 2)
		{
			return default(int);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1955BD8", Offset = "0x1955BD8", VA = "0x1955BD8")]
		public static ObscuredFloat FromEncrypted(int encrypted)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1955CD0", Offset = "0x1955CD0", VA = "0x1955CD0")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1955F2C", Offset = "0x1955F2C", VA = "0x1955F2C")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1955FF0", Offset = "0x1955FF0", VA = "0x1955FF0")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1955C1C", Offset = "0x1955C1C", VA = "0x1955C1C")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1956014", Offset = "0x1956014", VA = "0x1956014")]
		public float GetDecrypted()
		{
			return default(float);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1955DA4", Offset = "0x1955DA4", VA = "0x1955DA4")]
		private float InternalDecrypt()
		{
			return default(float);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1956018", Offset = "0x1956018", VA = "0x1956018")]
		public static implicit operator ObscuredFloat(float value)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1954584", Offset = "0x1954584", VA = "0x1954584")]
		public static implicit operator float(ObscuredFloat value)
		{
			return default(float);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1956028", Offset = "0x1956028", VA = "0x1956028")]
		public static ObscuredFloat operator ++(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x19560F0", Offset = "0x19560F0", VA = "0x19560F0")]
		public static ObscuredFloat operator --(ObscuredFloat input)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x19561B8", Offset = "0x19561B8", VA = "0x19561B8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x19561E4", Offset = "0x19561E4", VA = "0x19561E4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1956210", Offset = "0x1956210", VA = "0x1956210")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1956244", Offset = "0x1956244", VA = "0x1956244")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1956278", Offset = "0x1956278", VA = "0x1956278", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x19562BC", Offset = "0x19562BC", VA = "0x19562BC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x195635C", Offset = "0x195635C", VA = "0x195635C", Slot = "5")]
		public bool Equals(ObscuredFloat obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x195639C", Offset = "0x195639C", VA = "0x195639C", Slot = "6")]
		public int CompareTo(ObscuredFloat other)
		{
			return default(int);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x19563D4", Offset = "0x19563D4", VA = "0x19563D4", Slot = "7")]
		public int CompareTo(float other)
		{
			return default(int);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1956408", Offset = "0x1956408", VA = "0x1956408", Slot = "8")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000AC")]
	public struct ObscuredInt : IFormattable, IEquatable<ObscuredInt>, IComparable<ObscuredInt>, IComparable<int>, IComparable
	{
		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int hiddenValue;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private int fakeValue;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool fakeValueActive;

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1956494", Offset = "0x1956494", VA = "0x1956494")]
		private ObscuredInt(int value)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x19565A8", Offset = "0x19565A8", VA = "0x19565A8")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1956540", Offset = "0x1956540", VA = "0x1956540")]
		public static int Encrypt(int value)
		{
			return default(int);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1956614", Offset = "0x1956614", VA = "0x1956614")]
		public static int Encrypt(int value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1956694", Offset = "0x1956694", VA = "0x1956694")]
		public static int Decrypt(int value)
		{
			return default(int);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x19566FC", Offset = "0x19566FC", VA = "0x19566FC")]
		public static int Decrypt(int value, int key)
		{
			return default(int);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x195677C", Offset = "0x195677C", VA = "0x195677C")]
		public static ObscuredInt FromEncrypted(int encrypted)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1956878", Offset = "0x1956878", VA = "0x1956878")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1956A90", Offset = "0x1956A90", VA = "0x1956A90")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1956B48", Offset = "0x1956B48", VA = "0x1956B48")]
		public int GetEncrypted()
		{
			return default(int);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x19567C4", Offset = "0x19567C4", VA = "0x19567C4")]
		public void SetEncrypted(int encrypted)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1956B6C", Offset = "0x1956B6C", VA = "0x1956B6C")]
		public int GetDecrypted()
		{
			return default(int);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1956948", Offset = "0x1956948", VA = "0x1956948")]
		private int InternalDecrypt()
		{
			return default(int);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1956B70", Offset = "0x1956B70", VA = "0x1956B70")]
		public static implicit operator ObscuredInt(int value)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1956B84", Offset = "0x1956B84", VA = "0x1956B84")]
		public static implicit operator int(ObscuredInt value)
		{
			return default(int);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1956B88", Offset = "0x1956B88", VA = "0x1956B88")]
		public static implicit operator ObscuredFloat(ObscuredInt value)
		{
			return default(ObscuredFloat);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1956C14", Offset = "0x1956C14", VA = "0x1956C14")]
		public static implicit operator ObscuredDouble(ObscuredInt value)
		{
			return default(ObscuredDouble);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1956CA4", Offset = "0x1956CA4", VA = "0x1956CA4")]
		public static explicit operator ObscuredUInt(ObscuredInt value)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1956D44", Offset = "0x1956D44", VA = "0x1956D44")]
		public static ObscuredInt operator ++(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1956E04", Offset = "0x1956E04", VA = "0x1956E04")]
		public static ObscuredInt operator --(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1956EC4", Offset = "0x1956EC4", VA = "0x1956EC4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1956EF0", Offset = "0x1956EF0", VA = "0x1956EF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1956F1C", Offset = "0x1956F1C", VA = "0x1956F1C")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1956F50", Offset = "0x1956F50", VA = "0x1956F50")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1956F84", Offset = "0x1956F84", VA = "0x1956F84", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1956FC8", Offset = "0x1956FC8", VA = "0x1956FC8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1957068", Offset = "0x1957068", VA = "0x1957068", Slot = "5")]
		public bool Equals(ObscuredInt obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1957114", Offset = "0x1957114", VA = "0x1957114", Slot = "6")]
		public int CompareTo(ObscuredInt other)
		{
			return default(int);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1957150", Offset = "0x1957150", VA = "0x1957150", Slot = "7")]
		public int CompareTo(int other)
		{
			return default(int);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1957184", Offset = "0x1957184", VA = "0x1957184", Slot = "8")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000AD")]
	public struct ObscuredLong : IFormattable, IEquatable<ObscuredLong>, IComparable<ObscuredLong>, IComparable<long>, IComparable
	{
		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private long currentCryptoKey;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private long hiddenValue;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private long fakeValue;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool fakeValueActive;

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1957210", Offset = "0x1957210", VA = "0x1957210")]
		private ObscuredLong(long value)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1957324", Offset = "0x1957324", VA = "0x1957324")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x19572BC", Offset = "0x19572BC", VA = "0x19572BC")]
		public static long Encrypt(long value)
		{
			return default(long);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1957410", Offset = "0x1957410", VA = "0x1957410")]
		public static long Decrypt(long value)
		{
			return default(long);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1957390", Offset = "0x1957390", VA = "0x1957390")]
		public static long Encrypt(long value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1957478", Offset = "0x1957478", VA = "0x1957478")]
		public static long Decrypt(long value, long key)
		{
			return default(long);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x19574F8", Offset = "0x19574F8", VA = "0x19574F8")]
		public static ObscuredLong FromEncrypted(long encrypted)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x19575FC", Offset = "0x19575FC", VA = "0x19575FC")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1957814", Offset = "0x1957814", VA = "0x1957814")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x19578CC", Offset = "0x19578CC", VA = "0x19578CC")]
		public long GetEncrypted()
		{
			return default(long);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1957548", Offset = "0x1957548", VA = "0x1957548")]
		public void SetEncrypted(long encrypted)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x19578F0", Offset = "0x19578F0", VA = "0x19578F0")]
		public long GetDecrypted()
		{
			return default(long);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x19576CC", Offset = "0x19576CC", VA = "0x19576CC")]
		private long InternalDecrypt()
		{
			return default(long);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x19578F4", Offset = "0x19578F4", VA = "0x19578F4")]
		public static implicit operator ObscuredLong(long value)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x195790C", Offset = "0x195790C", VA = "0x195790C")]
		public static implicit operator long(ObscuredLong value)
		{
			return default(long);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1957910", Offset = "0x1957910", VA = "0x1957910")]
		public static ObscuredLong operator ++(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x19579D0", Offset = "0x19579D0", VA = "0x19579D0")]
		public static ObscuredLong operator --(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1957A90", Offset = "0x1957A90", VA = "0x1957A90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1957ABC", Offset = "0x1957ABC", VA = "0x1957ABC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1957AE8", Offset = "0x1957AE8", VA = "0x1957AE8")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1957B1C", Offset = "0x1957B1C", VA = "0x1957B1C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1957B50", Offset = "0x1957B50", VA = "0x1957B50", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1957B94", Offset = "0x1957B94", VA = "0x1957B94", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1957C34", Offset = "0x1957C34", VA = "0x1957C34", Slot = "5")]
		public bool Equals(ObscuredLong obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1957CE0", Offset = "0x1957CE0", VA = "0x1957CE0", Slot = "6")]
		public int CompareTo(ObscuredLong other)
		{
			return default(int);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1957D1C", Offset = "0x1957D1C", VA = "0x1957D1C", Slot = "7")]
		public int CompareTo(long other)
		{
			return default(int);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1957D50", Offset = "0x1957D50", VA = "0x1957D50", Slot = "8")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000AE")]
	public static class ObscuredPrefs
	{
		[Token(Token = "0x20000F3")]
		public enum DataType : byte
		{
			[Token(Token = "0x4000736")]
			Unknown = 0,
			[Token(Token = "0x4000737")]
			Int = 5,
			[Token(Token = "0x4000738")]
			UInt = 10,
			[Token(Token = "0x4000739")]
			String = 15,
			[Token(Token = "0x400073A")]
			Float = 20,
			[Token(Token = "0x400073B")]
			Double = 25,
			[Token(Token = "0x400073C")]
			Decimal = 27,
			[Token(Token = "0x400073D")]
			Long = 30,
			[Token(Token = "0x400073E")]
			ULong = 32,
			[Token(Token = "0x400073F")]
			Bool = 35,
			[Token(Token = "0x4000740")]
			ByteArray = 40,
			[Token(Token = "0x4000741")]
			Vector2 = 45,
			[Token(Token = "0x4000742")]
			Vector3 = 50,
			[Token(Token = "0x4000743")]
			Quaternion = 55,
			[Token(Token = "0x4000744")]
			Color = 60,
			[Token(Token = "0x4000745")]
			Rect = 65
		}

		[Token(Token = "0x20000F4")]
		public enum DeviceLockLevel : byte
		{
			[Token(Token = "0x4000747")]
			None,
			[Token(Token = "0x4000748")]
			Soft,
			[Token(Token = "0x4000749")]
			Strict
		}

		[Token(Token = "0x400056F")]
		private const byte Version = 2;

		[Token(Token = "0x4000570")]
		private const string RawNotFound = "{not_found}";

		[Token(Token = "0x4000571")]
		private const string DataSeparator = "|";

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool alterationReported;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool foreignSavesReported;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string cryptoKey;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string deviceId;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static uint deviceIdHash;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95C388", Offset = "0x95C388")]
		public static Action onAlterationDetected;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95C3D0", Offset = "0x95C3D0")]
		public static Action onPossibleForeignSavesDetected;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static bool preservePlayerPrefs;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public static DeviceLockLevel lockToDevice;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public static bool readForeignSaves;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
		public static bool emergencyMode;

		[Token(Token = "0x400057F")]
		private const char DEPRECATED_RAW_SEPARATOR = ':';

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static string deprecatedDeviceId;

		[Token(Token = "0x17000057")]
		public static string CryptoKey
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x1957E48", Offset = "0x1957E48", VA = "0x1957E48")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x1957DDC", Offset = "0x1957DDC", VA = "0x1957DDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public static string DeviceId
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x1957EB0", Offset = "0x1957EB0", VA = "0x1957EB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x1957FE0", Offset = "0x1957FE0", VA = "0x1957FE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95DAE4", Offset = "0x95DAE4")]
		internal static string DeviceID
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x195804C", Offset = "0x195804C", VA = "0x195804C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x19580A8", Offset = "0x19580A8", VA = "0x19580A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		private static uint DeviceIdHash
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x1958158", Offset = "0x1958158", VA = "0x1958158")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700005B")]
		private static string DeprecatedDeviceId
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x195E38C", Offset = "0x195E38C", VA = "0x195E38C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public static event Action OnAlterationDetected
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x19582D8", Offset = "0x19582D8", VA = "0x19582D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D144", Offset = "0x95D144")]
			add
			{
			}
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x19583C8", Offset = "0x19583C8", VA = "0x19583C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D154", Offset = "0x95D154")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public static event Action OnPossibleForeignSavesDetected
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x19584B8", Offset = "0x19584B8", VA = "0x19584B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D164", Offset = "0x95D164")]
			add
			{
			}
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x19585A8", Offset = "0x19585A8", VA = "0x19585A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D174", Offset = "0x95D174")]
			remove
			{
			}
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1958698", Offset = "0x1958698", VA = "0x1958698")]
		public static void ForceLockToDeviceInit()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1958788", Offset = "0x1958788", VA = "0x1958788")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95D184", Offset = "0x95D184")]
		internal static void SetNewCryptoKey(string newKey)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1958838", Offset = "0x1958838", VA = "0x1958838")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1958A68", Offset = "0x1958A68", VA = "0x1958A68")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1958AD0", Offset = "0x1958AD0", VA = "0x1958AD0")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x19589BC", Offset = "0x19589BC", VA = "0x19589BC")]
		public static string EncryptIntValue(string key, int value)
		{
			return null;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1958D34", Offset = "0x1958D34", VA = "0x1958D34")]
		public static int DecryptIntValue(string key, string encryptedInput, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1959A24", Offset = "0x1959A24", VA = "0x1959A24")]
		public static void SetUInt(string key, uint value)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1959B60", Offset = "0x1959B60", VA = "0x1959B60")]
		public static uint GetUInt(string key)
		{
			return default(uint);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1959BC8", Offset = "0x1959BC8", VA = "0x1959BC8")]
		public static uint GetUInt(string key, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1959AB4", Offset = "0x1959AB4", VA = "0x1959AB4")]
		public static string EncryptUIntValue(string key, uint value)
		{
			return null;
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1959C9C", Offset = "0x1959C9C", VA = "0x1959C9C")]
		public static uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1959DFC", Offset = "0x1959DFC", VA = "0x1959DFC")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1959F88", Offset = "0x1959F88", VA = "0x1959F88")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1959FF8", Offset = "0x1959FF8", VA = "0x1959FF8")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1959EE4", Offset = "0x1959EE4", VA = "0x1959EE4")]
		public static string EncryptStringValue(string key, string value)
		{
			return null;
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x195A178", Offset = "0x195A178", VA = "0x195A178")]
		public static string DecryptStringValue(string key, string encryptedInput, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x195A2B8", Offset = "0x195A2B8", VA = "0x195A2B8")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x195A3F4", Offset = "0x195A3F4", VA = "0x195A3F4")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x195A45C", Offset = "0x195A45C", VA = "0x195A45C")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x195A348", Offset = "0x195A348", VA = "0x195A348")]
		public static string EncryptFloatValue(string key, float value)
		{
			return null;
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x195A5E0", Offset = "0x195A5E0", VA = "0x195A5E0")]
		public static float DecryptFloatValue(string key, string encryptedInput, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x195A748", Offset = "0x195A748", VA = "0x195A748")]
		public static void SetDouble(string key, double value)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x195A884", Offset = "0x195A884", VA = "0x195A884")]
		public static double GetDouble(string key)
		{
			return default(double);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x195A8EC", Offset = "0x195A8EC", VA = "0x195A8EC")]
		public static double GetDouble(string key, double defaultValue)
		{
			return default(double);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x195A7D8", Offset = "0x195A7D8", VA = "0x195A7D8")]
		private static string EncryptDoubleValue(string key, double value)
		{
			return null;
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x195A9CC", Offset = "0x195A9CC", VA = "0x195A9CC")]
		private static double DecryptDoubleValue(string key, string encryptedInput, double defaultValue)
		{
			return default(double);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x195AB54", Offset = "0x195AB54", VA = "0x195AB54")]
		public static void SetDecimal(string key, decimal value)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x195AC80", Offset = "0x195AC80", VA = "0x195AC80")]
		public static decimal GetDecimal(string key)
		{
			return default(decimal);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x195AD24", Offset = "0x195AD24", VA = "0x195AD24")]
		public static decimal GetDecimal(string key, decimal defaultValue)
		{
			return default(decimal);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x195ABEC", Offset = "0x195ABEC", VA = "0x195ABEC")]
		private static string EncryptDecimalValue(string key, decimal value)
		{
			return null;
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x195AE08", Offset = "0x195AE08", VA = "0x195AE08")]
		private static decimal DecryptDecimalValue(string key, string encryptedInput, decimal defaultValue)
		{
			return default(decimal);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x195AF74", Offset = "0x195AF74", VA = "0x195AF74")]
		public static void SetLong(string key, long value)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x195B0B0", Offset = "0x195B0B0", VA = "0x195B0B0")]
		public static long GetLong(string key)
		{
			return default(long);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x195B118", Offset = "0x195B118", VA = "0x195B118")]
		public static long GetLong(string key, long defaultValue)
		{
			return default(long);
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x195B004", Offset = "0x195B004", VA = "0x195B004")]
		private static string EncryptLongValue(string key, long value)
		{
			return null;
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x195B1EC", Offset = "0x195B1EC", VA = "0x195B1EC")]
		private static long DecryptLongValue(string key, string encryptedInput, long defaultValue)
		{
			return default(long);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x195B34C", Offset = "0x195B34C", VA = "0x195B34C")]
		public static void SetULong(string key, ulong value)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x195B488", Offset = "0x195B488", VA = "0x195B488")]
		public static ulong GetULong(string key)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x195B4F0", Offset = "0x195B4F0", VA = "0x195B4F0")]
		public static ulong GetULong(string key, ulong defaultValue)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x195B3DC", Offset = "0x195B3DC", VA = "0x195B3DC")]
		private static string EncryptULongValue(string key, ulong value)
		{
			return null;
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x195B5C4", Offset = "0x195B5C4", VA = "0x195B5C4")]
		private static ulong DecryptULongValue(string key, string encryptedInput, ulong defaultValue)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x195B724", Offset = "0x195B724", VA = "0x195B724")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x195B860", Offset = "0x195B860", VA = "0x195B860")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x195B8C8", Offset = "0x195B8C8", VA = "0x195B8C8")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x195B7B4", Offset = "0x195B7B4", VA = "0x195B7B4")]
		private static string EncryptBoolValue(string key, bool value)
		{
			return null;
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x195B99C", Offset = "0x195B99C", VA = "0x195B99C")]
		private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x195BB08", Offset = "0x195BB08", VA = "0x195BB08")]
		public static void SetByteArray(string key, byte[] value)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x195BC10", Offset = "0x195BC10", VA = "0x195BC10")]
		public static byte[] GetByteArray(string key)
		{
			return null;
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x195BC7C", Offset = "0x195BC7C", VA = "0x195BC7C")]
		public static byte[] GetByteArray(string key, byte defaultValue, int defaultLength)
		{
			return null;
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x195BB98", Offset = "0x195BB98", VA = "0x195BB98")]
		private static string EncryptByteArrayValue(string key, byte[] value)
		{
			return null;
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x195BE24", Offset = "0x195BE24", VA = "0x195BE24")]
		private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength)
		{
			return null;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x195BD80", Offset = "0x195BD80", VA = "0x195BD80")]
		private static byte[] ConstructByteArray(byte value, int length)
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x195BF94", Offset = "0x195BF94", VA = "0x195BF94")]
		public static void SetVector2(string key, Vector2 value)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x195C12C", Offset = "0x195C12C", VA = "0x195C12C")]
		public static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x195C1D0", Offset = "0x195C1D0", VA = "0x195C1D0")]
		public static Vector2 GetVector2(string key, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x195C02C", Offset = "0x195C02C", VA = "0x195C02C")]
		private static string EncryptVector2Value(string key, Vector2 value)
		{
			return null;
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x195C2B4", Offset = "0x195C2B4", VA = "0x195C2B4")]
		private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x195C4E0", Offset = "0x195C4E0", VA = "0x195C4E0")]
		public static void SetVector3(string key, Vector3 value)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x195C6B8", Offset = "0x195C6B8", VA = "0x195C6B8")]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x195C76C", Offset = "0x195C76C", VA = "0x195C76C")]
		public static Vector3 GetVector3(string key, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x195C588", Offset = "0x195C588", VA = "0x195C588")]
		private static string EncryptVector3Value(string key, Vector3 value)
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x195C868", Offset = "0x195C868", VA = "0x195C868")]
		private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x195CAE8", Offset = "0x195CAE8", VA = "0x195CAE8")]
		public static void SetQuaternion(string key, Quaternion value)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x195CCF0", Offset = "0x195CCF0", VA = "0x195CCF0")]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x195CDAC", Offset = "0x195CDAC", VA = "0x195CDAC")]
		public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x195CB98", Offset = "0x195CB98", VA = "0x195CB98")]
		private static string EncryptQuaternionValue(string key, Quaternion value)
		{
			return null;
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x195CEB8", Offset = "0x195CEB8", VA = "0x195CEB8")]
		private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x195D174", Offset = "0x195D174", VA = "0x195D174")]
		public static void SetColor(string key, Color32 value)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x195D2BC", Offset = "0x195D2BC", VA = "0x195D2BC")]
		public static Color32 GetColor(string key)
		{
			return default(Color32);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x195D354", Offset = "0x195D354", VA = "0x195D354")]
		public static Color32 GetColor(string key, Color32 defaultValue)
		{
			return default(Color32);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x195D210", Offset = "0x195D210", VA = "0x195D210")]
		private static string EncryptColorValue(string key, uint value)
		{
			return null;
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x195D450", Offset = "0x195D450", VA = "0x195D450")]
		public static void SetRect(string key, Rect value)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x195D678", Offset = "0x195D678", VA = "0x195D678")]
		public static Rect GetRect(string key)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x195D710", Offset = "0x195D710", VA = "0x195D710")]
		public static Rect GetRect(string key, Rect defaultValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x195D500", Offset = "0x195D500", VA = "0x195D500")]
		private static string EncryptRectValue(string key, Rect value)
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x195D81C", Offset = "0x195D81C", VA = "0x195D81C")]
		private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x195DB08", Offset = "0x195DB08", VA = "0x195DB08")]
		public static void SetRawValue(string key, string encryptedValue)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x195DB84", Offset = "0x195DB84", VA = "0x195DB84")]
		public static string GetRawValue(string key)
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x195DBF0", Offset = "0x195DBF0", VA = "0x195DBF0")]
		public static DataType GetRawValueType(string value)
		{
			return default(DataType);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x19588C8", Offset = "0x19588C8", VA = "0x19588C8")]
		public static string EncryptKey(string key)
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x195DE94", Offset = "0x195DE94", VA = "0x195DE94")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x195DF20", Offset = "0x195DF20", VA = "0x195DF20")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x195DFB4", Offset = "0x195DFB4", VA = "0x195DFB4")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x195DFBC", Offset = "0x195DFBC", VA = "0x195DFBC")]
		public static void Save()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1958C50", Offset = "0x1958C50", VA = "0x1958C50")]
		private static string GetEncryptedPrefsString(string key, string encryptedKey)
		{
			return null;
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1958E94", Offset = "0x1958E94", VA = "0x1958E94")]
		private static string EncryptData(string key, byte[] cleanBytes, DataType type)
		{
			return null;
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x19595CC", Offset = "0x19595CC", VA = "0x19595CC")]
		internal static byte[] DecryptData(string key, string encryptedInput)
		{
			return null;
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1958218", Offset = "0x1958218", VA = "0x1958218")]
		private static uint CalculateChecksum(string input)
		{
			return default(uint);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x195E0C4", Offset = "0x195E0C4", VA = "0x195E0C4")]
		private static void SavesTampered()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x195E224", Offset = "0x195E224", VA = "0x195E224")]
		private static void PossibleForeignSavesDetected()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1957F74", Offset = "0x1957F74", VA = "0x1957F74")]
		private static string GetDeviceId()
		{
			return null;
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x195DFC4", Offset = "0x195DFC4", VA = "0x195DFC4")]
		private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key)
		{
			return null;
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1959168", Offset = "0x1959168", VA = "0x1959168")]
		private static string DeprecatedDecryptValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x195E454", Offset = "0x195E454", VA = "0x195E454")]
		private static string DeprecatedCalculateChecksum(string input)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AF")]
	internal class BitconverterExt
	{
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x11DA46C", Offset = "0x11DA46C", VA = "0x11DA46C")]
		public static byte[] GetBytes(decimal dec)
		{
			return null;
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x11DA5C8", Offset = "0x11DA5C8", VA = "0x11DA5C8")]
		public static decimal ToDecimal(byte[] bytes)
		{
			return default(decimal);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x11DA70C", Offset = "0x11DA70C", VA = "0x11DA70C")]
		public BitconverterExt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public struct ObscuredQuaternion
	{
		[Serializable]
		[Token(Token = "0x20000F5")]
		public struct RawEncryptedQuaternion
		{
			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int z;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int w;
		}

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Quaternion identity;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private RawEncryptedQuaternion hiddenValue;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Quaternion fakeValue;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool fakeValueActive;

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x195E620", Offset = "0x195E620", VA = "0x195E620")]
		private ObscuredQuaternion(Quaternion value)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x195E7B4", Offset = "0x195E7B4", VA = "0x195E7B4")]
		public ObscuredQuaternion(float x, float y, float z, float w)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x195EA18", Offset = "0x195EA18", VA = "0x195EA18")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x195E724", Offset = "0x195E724", VA = "0x195E724")]
		public static RawEncryptedQuaternion Encrypt(Quaternion value)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x195EA84", Offset = "0x195EA84", VA = "0x195EA84")]
		public static RawEncryptedQuaternion Encrypt(Quaternion value, int key)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x195E8D8", Offset = "0x195E8D8", VA = "0x195E8D8")]
		public static RawEncryptedQuaternion Encrypt(float x, float y, float z, float w, int key)
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x195EB18", Offset = "0x195EB18", VA = "0x195EB18")]
		public static Quaternion Decrypt(RawEncryptedQuaternion value)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x195EB90", Offset = "0x195EB90", VA = "0x195EB90")]
		public static Quaternion Decrypt(RawEncryptedQuaternion value, int key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x195ECC4", Offset = "0x195ECC4", VA = "0x195ECC4")]
		public static ObscuredQuaternion FromEncrypted(RawEncryptedQuaternion encrypted)
		{
			return default(ObscuredQuaternion);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x195EDD8", Offset = "0x195EDD8", VA = "0x195EDD8")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x195F0E4", Offset = "0x195F0E4", VA = "0x195F0E4")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x195F1BC", Offset = "0x195F1BC", VA = "0x195F1BC")]
		public RawEncryptedQuaternion GetEncrypted()
		{
			return default(RawEncryptedQuaternion);
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x195ED18", Offset = "0x195ED18", VA = "0x195ED18")]
		public void SetEncrypted(RawEncryptedQuaternion encrypted)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x195F1E4", Offset = "0x195F1E4", VA = "0x195F1E4")]
		public Quaternion GetDecrypted()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x195EED0", Offset = "0x195EED0", VA = "0x195EED0")]
		private Quaternion InternalDecrypt()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x195F1E8", Offset = "0x195F1E8", VA = "0x195F1E8")]
		private bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x195F34C", Offset = "0x195F34C", VA = "0x195F34C")]
		public static implicit operator ObscuredQuaternion(Quaternion value)
		{
			return default(ObscuredQuaternion);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x195F364", Offset = "0x195F364", VA = "0x195F364")]
		public static implicit operator Quaternion(ObscuredQuaternion value)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x195F368", Offset = "0x195F368", VA = "0x195F368", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x195F398", Offset = "0x195F398", VA = "0x195F398", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x195F3C8", Offset = "0x195F3C8", VA = "0x195F3C8")]
		public string ToString(string format)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public struct ObscuredSByte : IFormattable, IEquatable<ObscuredSByte>, IComparable<ObscuredSByte>, IComparable<sbyte>, IComparable
	{
		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static sbyte cryptoKey;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private sbyte currentCryptoKey;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private sbyte hiddenValue;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private bool inited;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		private sbyte fakeValue;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private bool fakeValueActive;

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x195F498", Offset = "0x195F498", VA = "0x195F498")]
		private ObscuredSByte(sbyte value)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x195F5AC", Offset = "0x195F5AC", VA = "0x195F5AC")]
		public static void SetNewCryptoKey(sbyte newKey)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x195F544", Offset = "0x195F544", VA = "0x195F544")]
		public static sbyte EncryptDecrypt(sbyte value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x195F618", Offset = "0x195F618", VA = "0x195F618")]
		public static sbyte EncryptDecrypt(sbyte value, sbyte key)
		{
			return default(sbyte);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x195F69C", Offset = "0x195F69C", VA = "0x195F69C")]
		public static ObscuredSByte FromEncrypted(sbyte encrypted)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x195F788", Offset = "0x195F788", VA = "0x195F788")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x195F9A4", Offset = "0x195F9A4", VA = "0x195F9A4")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x195FA60", Offset = "0x195FA60", VA = "0x195FA60")]
		public sbyte GetEncrypted()
		{
			return default(sbyte);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x195F6D4", Offset = "0x195F6D4", VA = "0x195F6D4")]
		public void SetEncrypted(sbyte encrypted)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x195FA84", Offset = "0x195FA84", VA = "0x195FA84")]
		public sbyte GetDecrypted()
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x195F858", Offset = "0x195F858", VA = "0x195F858")]
		private sbyte InternalDecrypt()
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x195FA88", Offset = "0x195FA88", VA = "0x195FA88")]
		public static implicit operator ObscuredSByte(sbyte value)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x195FAC0", Offset = "0x195FAC0", VA = "0x195FAC0")]
		public static implicit operator sbyte(ObscuredSByte value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x195FAEC", Offset = "0x195FAEC", VA = "0x195FAEC")]
		public static ObscuredSByte operator ++(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x195FBAC", Offset = "0x195FBAC", VA = "0x195FBAC")]
		public static ObscuredSByte operator --(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x195FC6C", Offset = "0x195FC6C", VA = "0x195FC6C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x195FC98", Offset = "0x195FC98", VA = "0x195FC98", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x195FCC4", Offset = "0x195FCC4", VA = "0x195FCC4")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x195FCF8", Offset = "0x195FCF8", VA = "0x195FCF8")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x195FD2C", Offset = "0x195FD2C", VA = "0x195FD2C", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x195FD70", Offset = "0x195FD70", VA = "0x195FD70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x195FE04", Offset = "0x195FE04", VA = "0x195FE04", Slot = "5")]
		public bool Equals(ObscuredSByte obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x195FEB4", Offset = "0x195FEB4", VA = "0x195FEB4", Slot = "6")]
		public int CompareTo(ObscuredSByte other)
		{
			return default(int);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x195FEF8", Offset = "0x195FEF8", VA = "0x195FEF8", Slot = "7")]
		public int CompareTo(sbyte other)
		{
			return default(int);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x195FF2C", Offset = "0x195FF2C", VA = "0x195FF2C", Slot = "8")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000B2")]
	public struct ObscuredShort : IFormattable, IEquatable<ObscuredShort>, IComparable<ObscuredShort>, IComparable<short>, IComparable
	{
		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static short cryptoKey;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private short currentCryptoKey;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		[SerializeField]
		private short hiddenValue;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		[SerializeField]
		private short fakeValue;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private bool fakeValueActive;

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x195FFB4", Offset = "0x195FFB4", VA = "0x195FFB4")]
		private ObscuredShort(short value)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x19600C8", Offset = "0x19600C8", VA = "0x19600C8")]
		public static void SetNewCryptoKey(short newKey)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1960060", Offset = "0x1960060", VA = "0x1960060")]
		public static short EncryptDecrypt(short value)
		{
			return default(short);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1960134", Offset = "0x1960134", VA = "0x1960134")]
		public static short EncryptDecrypt(short value, short key)
		{
			return default(short);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x19601B8", Offset = "0x19601B8", VA = "0x19601B8")]
		public static ObscuredShort FromEncrypted(short encrypted)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x19602A0", Offset = "0x19602A0", VA = "0x19602A0")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x19604C0", Offset = "0x19604C0", VA = "0x19604C0")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x196057C", Offset = "0x196057C", VA = "0x196057C")]
		public short GetEncrypted()
		{
			return default(short);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x19601EC", Offset = "0x19601EC", VA = "0x19601EC")]
		public void SetEncrypted(short encrypted)
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x19605A0", Offset = "0x19605A0", VA = "0x19605A0")]
		public short GetDecrypted()
		{
			return default(short);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1960370", Offset = "0x1960370", VA = "0x1960370")]
		private short InternalDecrypt()
		{
			return default(short);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x19605A4", Offset = "0x19605A4", VA = "0x19605A4")]
		public static implicit operator ObscuredShort(short value)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x19605D8", Offset = "0x19605D8", VA = "0x19605D8")]
		public static implicit operator short(ObscuredShort value)
		{
			return default(short);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1960600", Offset = "0x1960600", VA = "0x1960600")]
		public static ObscuredShort operator ++(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x19606B0", Offset = "0x19606B0", VA = "0x19606B0")]
		public static ObscuredShort operator --(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1960760", Offset = "0x1960760", VA = "0x1960760", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x196078C", Offset = "0x196078C", VA = "0x196078C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x19607B8", Offset = "0x19607B8", VA = "0x19607B8")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x19607EC", Offset = "0x19607EC", VA = "0x19607EC")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1960820", Offset = "0x1960820", VA = "0x1960820", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1960864", Offset = "0x1960864", VA = "0x1960864", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x19608F4", Offset = "0x19608F4", VA = "0x19608F4", Slot = "5")]
		public bool Equals(ObscuredShort obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x19609A0", Offset = "0x19609A0", VA = "0x19609A0", Slot = "6")]
		public int CompareTo(ObscuredShort other)
		{
			return default(int);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x19609E0", Offset = "0x19609E0", VA = "0x19609E0", Slot = "7")]
		public int CompareTo(short other)
		{
			return default(int);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1960A14", Offset = "0x1960A14", VA = "0x1960A14", Slot = "8")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000B3")]
	public sealed class ObscuredString : IComparable<ObscuredString>, IComparable<string>, IComparable
	{
		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string cryptoKey;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string currentCryptoKey;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private byte[] hiddenValue;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string fakeValue;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool fakeValueActive;

		[Token(Token = "0x1700005C")]
		public int Length
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x1961368", Offset = "0x1961368", VA = "0x1961368")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1960A9C", Offset = "0x1960A9C", VA = "0x1960A9C")]
		private ObscuredString()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1960AA4", Offset = "0x1960AA4", VA = "0x1960AA4")]
		private ObscuredString(string value)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1960BD4", Offset = "0x1960BD4", VA = "0x1960BD4")]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1960C40", Offset = "0x1960C40", VA = "0x1960C40")]
		public static string EncryptDecrypt(string value)
		{
			return null;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x195DD1C", Offset = "0x195DD1C", VA = "0x195DD1C")]
		public static string EncryptDecrypt(string value, string key)
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1960CBC", Offset = "0x1960CBC", VA = "0x1960CBC")]
		public static ObscuredString FromEncrypted(string encrypted)
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1960E10", Offset = "0x1960E10", VA = "0x1960E10")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x196108C", Offset = "0x196108C", VA = "0x196108C")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x19611D0", Offset = "0x19611D0", VA = "0x19611D0")]
		public string GetEncrypted()
		{
			return null;
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1960D30", Offset = "0x1960D30", VA = "0x1960D30")]
		public void SetEncrypted(string encrypted)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1961364", Offset = "0x1961364", VA = "0x1961364")]
		public string GetDecrypted()
		{
			return null;
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1960B64", Offset = "0x1960B64", VA = "0x1960B64")]
		private static byte[] InternalEncrypt(string value)
		{
			return null;
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1961158", Offset = "0x1961158", VA = "0x1961158")]
		private static byte[] InternalEncrypt(string value, string key)
		{
			return null;
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1960EDC", Offset = "0x1960EDC", VA = "0x1960EDC")]
		private string InternalDecrypt()
		{
			return null;
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1961390", Offset = "0x1961390", VA = "0x1961390")]
		public static implicit operator ObscuredString(string value)
		{
			return null;
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x19613FC", Offset = "0x19613FC", VA = "0x19613FC")]
		public static implicit operator string(ObscuredString value)
		{
			return null;
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1961498", Offset = "0x1961498", VA = "0x1961498")]
		public static bool operator ==(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x1961604", Offset = "0x1961604", VA = "0x1961604")]
		public static bool operator !=(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1961684", Offset = "0x1961684", VA = "0x1961684", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x19616A8", Offset = "0x19616A8", VA = "0x19616A8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x19616AC", Offset = "0x19616AC", VA = "0x19616AC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x1961730", Offset = "0x1961730", VA = "0x1961730")]
		public bool Equals(ObscuredString value)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1961844", Offset = "0x1961844", VA = "0x1961844")]
		public bool Equals(ObscuredString value, StringComparison comparisonType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x1961914", Offset = "0x1961914", VA = "0x1961914", Slot = "4")]
		public int CompareTo(ObscuredString other)
		{
			return default(int);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x1961958", Offset = "0x1961958", VA = "0x1961958", Slot = "5")]
		public int CompareTo(string other)
		{
			return default(int);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1961988", Offset = "0x1961988", VA = "0x1961988", Slot = "6")]
		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x19612D4", Offset = "0x19612D4", VA = "0x19612D4")]
		private static byte[] GetBytes(string str)
		{
			return null;
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x1961240", Offset = "0x1961240", VA = "0x1961240")]
		private static string GetString(byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x1961580", Offset = "0x1961580", VA = "0x1961580")]
		private static bool ArraysEquals(byte[] a1, byte[] a2)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x20000B4")]
	public struct ObscuredUInt : IFormattable, IEquatable<ObscuredUInt>, IComparable<ObscuredUInt>, IComparable<uint>, IComparable
	{
		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint cryptoKey;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private uint currentCryptoKey;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private uint hiddenValue;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private uint fakeValue;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool fakeValueActive;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1961A14", Offset = "0x1961A14", VA = "0x1961A14")]
		private ObscuredUInt(uint value)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x1961B28", Offset = "0x1961B28", VA = "0x1961B28")]
		public static void SetNewCryptoKey(uint newKey)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1961AC0", Offset = "0x1961AC0", VA = "0x1961AC0")]
		public static uint Encrypt(uint value)
		{
			return default(uint);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1961C14", Offset = "0x1961C14", VA = "0x1961C14")]
		public static uint Decrypt(uint value)
		{
			return default(uint);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1961B94", Offset = "0x1961B94", VA = "0x1961B94")]
		public static uint Encrypt(uint value, uint key)
		{
			return default(uint);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1961C7C", Offset = "0x1961C7C", VA = "0x1961C7C")]
		public static uint Decrypt(uint value, uint key)
		{
			return default(uint);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x1961CFC", Offset = "0x1961CFC", VA = "0x1961CFC")]
		public static ObscuredUInt FromEncrypted(uint encrypted)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x1961DF8", Offset = "0x1961DF8", VA = "0x1961DF8")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x1962010", Offset = "0x1962010", VA = "0x1962010")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x19620C8", Offset = "0x19620C8", VA = "0x19620C8")]
		public uint GetEncrypted()
		{
			return default(uint);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1961D44", Offset = "0x1961D44", VA = "0x1961D44")]
		public void SetEncrypted(uint encrypted)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x19620EC", Offset = "0x19620EC", VA = "0x19620EC")]
		public uint GetDecrypted()
		{
			return default(uint);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1961EC8", Offset = "0x1961EC8", VA = "0x1961EC8")]
		private uint InternalDecrypt()
		{
			return default(uint);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1956D30", Offset = "0x1956D30", VA = "0x1956D30")]
		public static implicit operator ObscuredUInt(uint value)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x19620F0", Offset = "0x19620F0", VA = "0x19620F0")]
		public static implicit operator uint(ObscuredUInt value)
		{
			return default(uint);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x19620F4", Offset = "0x19620F4", VA = "0x19620F4")]
		public static explicit operator ObscuredInt(ObscuredUInt value)
		{
			return default(ObscuredInt);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1962180", Offset = "0x1962180", VA = "0x1962180")]
		public static ObscuredUInt operator ++(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1962240", Offset = "0x1962240", VA = "0x1962240")]
		public static ObscuredUInt operator --(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x1962300", Offset = "0x1962300", VA = "0x1962300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x196232C", Offset = "0x196232C", VA = "0x196232C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1962358", Offset = "0x1962358", VA = "0x1962358")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x196238C", Offset = "0x196238C", VA = "0x196238C")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x19623C0", Offset = "0x19623C0", VA = "0x19623C0", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1962404", Offset = "0x1962404", VA = "0x1962404", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x19624A4", Offset = "0x19624A4", VA = "0x19624A4", Slot = "5")]
		public bool Equals(ObscuredUInt obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1962550", Offset = "0x1962550", VA = "0x1962550", Slot = "6")]
		public int CompareTo(ObscuredUInt other)
		{
			return default(int);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x196258C", Offset = "0x196258C", VA = "0x196258C", Slot = "7")]
		public int CompareTo(uint other)
		{
			return default(int);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x19625C0", Offset = "0x19625C0", VA = "0x19625C0", Slot = "8")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000B5")]
	public struct ObscuredULong : IFormattable, IEquatable<ObscuredULong>, IComparable<ObscuredULong>, IComparable<ulong>, IComparable
	{
		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ulong cryptoKey;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ulong currentCryptoKey;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private ulong hiddenValue;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ulong fakeValue;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool fakeValueActive;

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x196264C", Offset = "0x196264C", VA = "0x196264C")]
		private ObscuredULong(ulong value)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1962760", Offset = "0x1962760", VA = "0x1962760")]
		public static void SetNewCryptoKey(ulong newKey)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x19626F8", Offset = "0x19626F8", VA = "0x19626F8")]
		public static ulong Encrypt(ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x196284C", Offset = "0x196284C", VA = "0x196284C")]
		public static ulong Decrypt(ulong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x19627CC", Offset = "0x19627CC", VA = "0x19627CC")]
		public static ulong Encrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x19628B4", Offset = "0x19628B4", VA = "0x19628B4")]
		public static ulong Decrypt(ulong value, ulong key)
		{
			return default(ulong);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1962934", Offset = "0x1962934", VA = "0x1962934")]
		public static ObscuredULong FromEncrypted(ulong encrypted)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x1962A38", Offset = "0x1962A38", VA = "0x1962A38")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x1962C50", Offset = "0x1962C50", VA = "0x1962C50")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1962D08", Offset = "0x1962D08", VA = "0x1962D08")]
		public ulong GetEncrypted()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1962984", Offset = "0x1962984", VA = "0x1962984")]
		public void SetEncrypted(ulong encrypted)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1962D2C", Offset = "0x1962D2C", VA = "0x1962D2C")]
		public ulong GetDecrypted()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1962B08", Offset = "0x1962B08", VA = "0x1962B08")]
		private ulong InternalDecrypt()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1962D30", Offset = "0x1962D30", VA = "0x1962D30")]
		public static implicit operator ObscuredULong(ulong value)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x1962D48", Offset = "0x1962D48", VA = "0x1962D48")]
		public static implicit operator ulong(ObscuredULong value)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1962D4C", Offset = "0x1962D4C", VA = "0x1962D4C")]
		public static ObscuredULong operator ++(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1962E0C", Offset = "0x1962E0C", VA = "0x1962E0C")]
		public static ObscuredULong operator --(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1962ECC", Offset = "0x1962ECC", VA = "0x1962ECC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1962EF8", Offset = "0x1962EF8", VA = "0x1962EF8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x1962F24", Offset = "0x1962F24", VA = "0x1962F24")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1962F58", Offset = "0x1962F58", VA = "0x1962F58")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1962F8C", Offset = "0x1962F8C", VA = "0x1962F8C", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1962FD0", Offset = "0x1962FD0", VA = "0x1962FD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x1963070", Offset = "0x1963070", VA = "0x1963070", Slot = "5")]
		public bool Equals(ObscuredULong obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x196311C", Offset = "0x196311C", VA = "0x196311C", Slot = "6")]
		public int CompareTo(ObscuredULong other)
		{
			return default(int);
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x1963158", Offset = "0x1963158", VA = "0x1963158", Slot = "7")]
		public int CompareTo(ulong other)
		{
			return default(int);
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x196318C", Offset = "0x196318C", VA = "0x196318C", Slot = "8")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	public struct ObscuredUShort : IFormattable, IEquatable<ObscuredUShort>, IComparable<ObscuredUShort>, IComparable<ushort>, IComparable
	{
		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ushort cryptoKey;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort currentCryptoKey;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private ushort hiddenValue;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private bool inited;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		private ushort fakeValue;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool fakeValueActive;

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x1963218", Offset = "0x1963218", VA = "0x1963218")]
		private ObscuredUShort(ushort value)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x196332C", Offset = "0x196332C", VA = "0x196332C")]
		public static void SetNewCryptoKey(ushort newKey)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x19632C4", Offset = "0x19632C4", VA = "0x19632C4")]
		public static ushort EncryptDecrypt(ushort value)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x1963398", Offset = "0x1963398", VA = "0x1963398")]
		public static ushort EncryptDecrypt(ushort value, ushort key)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x196341C", Offset = "0x196341C", VA = "0x196341C")]
		public static ObscuredUShort FromEncrypted(ushort encrypted)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x1963504", Offset = "0x1963504", VA = "0x1963504")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1963724", Offset = "0x1963724", VA = "0x1963724")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x19637E0", Offset = "0x19637E0", VA = "0x19637E0")]
		public ushort GetEncrypted()
		{
			return default(ushort);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1963450", Offset = "0x1963450", VA = "0x1963450")]
		public void SetEncrypted(ushort encrypted)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1963804", Offset = "0x1963804", VA = "0x1963804")]
		public ushort GetDecrypted()
		{
			return default(ushort);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x19635D4", Offset = "0x19635D4", VA = "0x19635D4")]
		private ushort InternalDecrypt()
		{
			return default(ushort);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1963808", Offset = "0x1963808", VA = "0x1963808")]
		public static implicit operator ObscuredUShort(ushort value)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x196383C", Offset = "0x196383C", VA = "0x196383C")]
		public static implicit operator ushort(ObscuredUShort value)
		{
			return default(ushort);
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x1963864", Offset = "0x1963864", VA = "0x1963864")]
		public static ObscuredUShort operator ++(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x196391C", Offset = "0x196391C", VA = "0x196391C")]
		public static ObscuredUShort operator --(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x19639D4", Offset = "0x19639D4", VA = "0x19639D4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x1963A00", Offset = "0x1963A00", VA = "0x1963A00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x1963A2C", Offset = "0x1963A2C", VA = "0x1963A2C")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x1963A60", Offset = "0x1963A60", VA = "0x1963A60")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x1963A94", Offset = "0x1963A94", VA = "0x1963A94", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1963AD8", Offset = "0x1963AD8", VA = "0x1963AD8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x1963B68", Offset = "0x1963B68", VA = "0x1963B68", Slot = "5")]
		public bool Equals(ObscuredUShort obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x1963C14", Offset = "0x1963C14", VA = "0x1963C14", Slot = "6")]
		public int CompareTo(ObscuredUShort other)
		{
			return default(int);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x1963C54", Offset = "0x1963C54", VA = "0x1963C54", Slot = "7")]
		public int CompareTo(ushort other)
		{
			return default(int);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x1963C88", Offset = "0x1963C88", VA = "0x1963C88", Slot = "8")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x95B504", Offset = "0x95B504")]
	public struct ObscuredVector2
	{
		[Serializable]
		[Token(Token = "0x20000F6")]
		public struct RawEncryptedVector2
		{
			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;
		}

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Vector2 zero;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private RawEncryptedVector2 hiddenValue;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector2 fakeValue;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool fakeValueActive;

		[Token(Token = "0x1700005D")]
		public float x
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x1964050", Offset = "0x1964050", VA = "0x1964050")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x19641EC", Offset = "0x19641EC", VA = "0x19641EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public float y
		{
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x1964308", Offset = "0x1964308", VA = "0x1964308")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x19643F8", Offset = "0x19643F8", VA = "0x19643F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public float Item
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x1964454", Offset = "0x1964454", VA = "0x1964454")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x1964500", Offset = "0x1964500", VA = "0x1964500")]
			set
			{
			}
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1963D10", Offset = "0x1963D10", VA = "0x1963D10")]
		private ObscuredVector2(Vector2 value)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x1963E68", Offset = "0x1963E68", VA = "0x1963E68")]
		public ObscuredVector2(float x, float y)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x19645C4", Offset = "0x19645C4", VA = "0x19645C4")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1963DF0", Offset = "0x1963DF0", VA = "0x1963DF0")]
		public static RawEncryptedVector2 Encrypt(Vector2 value)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1964630", Offset = "0x1964630", VA = "0x1964630")]
		public static RawEncryptedVector2 Encrypt(Vector2 value, int key)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1963F68", Offset = "0x1963F68", VA = "0x1963F68")]
		public static RawEncryptedVector2 Encrypt(float x, float y, int key)
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x19646AC", Offset = "0x19646AC", VA = "0x19646AC")]
		public static Vector2 Decrypt(RawEncryptedVector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x1964714", Offset = "0x1964714", VA = "0x1964714")]
		public static Vector2 Decrypt(RawEncryptedVector2 value, int key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1964800", Offset = "0x1964800", VA = "0x1964800")]
		public static ObscuredVector2 FromEncrypted(RawEncryptedVector2 encrypted)
		{
			return default(ObscuredVector2);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x1964900", Offset = "0x1964900", VA = "0x1964900")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1964B88", Offset = "0x1964B88", VA = "0x1964B88")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1964C44", Offset = "0x1964C44", VA = "0x1964C44")]
		public RawEncryptedVector2 GetEncrypted()
		{
			return default(RawEncryptedVector2);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x196484C", Offset = "0x196484C", VA = "0x196484C")]
		public void SetEncrypted(RawEncryptedVector2 encrypted)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1964C68", Offset = "0x1964C68", VA = "0x1964C68")]
		public Vector2 GetDecrypted()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x19649DC", Offset = "0x19649DC", VA = "0x19649DC")]
		private Vector2 InternalDecrypt()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1964C6C", Offset = "0x1964C6C", VA = "0x1964C6C")]
		private bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1964140", Offset = "0x1964140", VA = "0x1964140")]
		private float InternalDecryptField(int encrypted)
		{
			return default(float);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x196424C", Offset = "0x196424C", VA = "0x196424C")]
		private int InternalEncryptField(float encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1964D6C", Offset = "0x1964D6C", VA = "0x1964D6C")]
		public static implicit operator ObscuredVector2(Vector2 value)
		{
			return default(ObscuredVector2);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1964D80", Offset = "0x1964D80", VA = "0x1964D80")]
		public static implicit operator Vector2(ObscuredVector2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1964D84", Offset = "0x1964D84", VA = "0x1964D84")]
		public static implicit operator Vector3(ObscuredVector2 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1964DC0", Offset = "0x1964DC0", VA = "0x1964DC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1964DEC", Offset = "0x1964DEC", VA = "0x1964DEC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1964E18", Offset = "0x1964E18", VA = "0x1964E18")]
		public string ToString(string format)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x95B53C", Offset = "0x95B53C")]
	public struct ObscuredVector2Int
	{
		[Serializable]
		[Token(Token = "0x20000F7")]
		public struct RawEncryptedVector2Int
		{
			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;
		}

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Vector2Int zero;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private RawEncryptedVector2Int hiddenValue;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector2Int fakeValue;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool fakeValueActive;

		[Token(Token = "0x17000060")]
		public int x
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x19651D8", Offset = "0x19651D8", VA = "0x19651D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x1965368", Offset = "0x1965368", VA = "0x1965368")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public int y
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x196547C", Offset = "0x196547C", VA = "0x196547C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x1965574", Offset = "0x1965574", VA = "0x1965574")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public int Item
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x19655F0", Offset = "0x19655F0", VA = "0x19655F0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x196569C", Offset = "0x196569C", VA = "0x196569C")]
			set
			{
			}
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1964ED8", Offset = "0x1964ED8", VA = "0x1964ED8")]
		private ObscuredVector2Int(Vector2Int value)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1965010", Offset = "0x1965010", VA = "0x1965010")]
		public ObscuredVector2Int(int x, int y)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x1965754", Offset = "0x1965754", VA = "0x1965754")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x1964FA8", Offset = "0x1964FA8", VA = "0x1964FA8")]
		public static RawEncryptedVector2Int Encrypt(Vector2Int value)
		{
			return default(RawEncryptedVector2Int);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x19657C0", Offset = "0x19657C0", VA = "0x19657C0")]
		public static RawEncryptedVector2Int Encrypt(Vector2Int value, int key)
		{
			return default(RawEncryptedVector2Int);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1965110", Offset = "0x1965110", VA = "0x1965110")]
		public static RawEncryptedVector2Int Encrypt(int x, int y, int key)
		{
			return default(RawEncryptedVector2Int);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x1965860", Offset = "0x1965860", VA = "0x1965860")]
		public static Vector2Int Decrypt(RawEncryptedVector2Int value)
		{
			return default(Vector2Int);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x19658C8", Offset = "0x19658C8", VA = "0x19658C8")]
		public static Vector2Int Decrypt(RawEncryptedVector2Int value, int key)
		{
			return default(Vector2Int);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x19659AC", Offset = "0x19659AC", VA = "0x19659AC")]
		public static ObscuredVector2Int FromEncrypted(RawEncryptedVector2Int encrypted)
		{
			return default(ObscuredVector2Int);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1965AAC", Offset = "0x1965AAC", VA = "0x1965AAC")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1965D3C", Offset = "0x1965D3C", VA = "0x1965D3C")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1965DF4", Offset = "0x1965DF4", VA = "0x1965DF4")]
		public RawEncryptedVector2Int GetEncrypted()
		{
			return default(RawEncryptedVector2Int);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x19659F8", Offset = "0x19659F8", VA = "0x19659F8")]
		public void SetEncrypted(RawEncryptedVector2Int encrypted)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1965E18", Offset = "0x1965E18", VA = "0x1965E18")]
		public Vector2Int GetDecrypted()
		{
			return default(Vector2Int);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1965B7C", Offset = "0x1965B7C", VA = "0x1965B7C")]
		private Vector2Int InternalDecrypt()
		{
			return default(Vector2Int);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x19652D0", Offset = "0x19652D0", VA = "0x19652D0")]
		private int InternalDecryptField(int encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x19653E4", Offset = "0x19653E4", VA = "0x19653E4")]
		private int InternalEncryptField(int encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1965E1C", Offset = "0x1965E1C", VA = "0x1965E1C")]
		public static implicit operator ObscuredVector2Int(Vector2Int value)
		{
			return default(ObscuredVector2Int);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1965E34", Offset = "0x1965E34", VA = "0x1965E34")]
		public static implicit operator Vector2Int(ObscuredVector2Int value)
		{
			return default(Vector2Int);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1965E38", Offset = "0x1965E38", VA = "0x1965E38")]
		public static implicit operator Vector2(ObscuredVector2Int value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1965EB0", Offset = "0x1965EB0", VA = "0x1965EB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1965EDC", Offset = "0x1965EDC", VA = "0x1965EDC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x95B574", Offset = "0x95B574")]
	public struct ObscuredVector3
	{
		[Serializable]
		[Token(Token = "0x20000F8")]
		public struct RawEncryptedVector3
		{
			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int z;
		}

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Vector3 zero;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private RawEncryptedVector3 hiddenValue;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Vector3 fakeValue;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool fakeValueActive;

		[Token(Token = "0x17000063")]
		public float x
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0xE8E8F8", Offset = "0xE8E8F8", VA = "0xE8E8F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600066B")]
			[Address(RVA = "0xE8EA84", Offset = "0xE8EA84", VA = "0xE8EA84")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public float y
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0xE8EB98", Offset = "0xE8EB98", VA = "0xE8EB98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600066D")]
			[Address(RVA = "0xE8EC88", Offset = "0xE8EC88", VA = "0xE8EC88")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public float z
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0xE8ECF4", Offset = "0xE8ECF4", VA = "0xE8ECF4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600066F")]
			[Address(RVA = "0xE8EDE4", Offset = "0xE8EDE4", VA = "0xE8EDE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public float Item
		{
			[Token(Token = "0x6000670")]
			[Address(RVA = "0xE8EE50", Offset = "0xE8EE50", VA = "0xE8EE50")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000671")]
			[Address(RVA = "0xE8EF18", Offset = "0xE8EF18", VA = "0xE8EF18")]
			set
			{
			}
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xE8E540", Offset = "0xE8E540", VA = "0xE8E540")]
		private ObscuredVector3(Vector3 value)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xE8E6CC", Offset = "0xE8E6CC", VA = "0xE8E6CC")]
		public ObscuredVector3(float x, float y, float z)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xE8F000", Offset = "0xE8F000", VA = "0xE8F000")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xE8E63C", Offset = "0xE8E63C", VA = "0xE8E63C")]
		public static RawEncryptedVector3 Encrypt(Vector3 value)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xE8F06C", Offset = "0xE8F06C", VA = "0xE8F06C")]
		public static RawEncryptedVector3 Encrypt(Vector3 value, int key)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xE8E7FC", Offset = "0xE8E7FC", VA = "0xE8E7FC")]
		public static RawEncryptedVector3 Encrypt(float x, float y, float z, int key)
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xE8F100", Offset = "0xE8F100", VA = "0xE8F100")]
		public static Vector3 Decrypt(RawEncryptedVector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xE8F178", Offset = "0xE8F178", VA = "0xE8F178")]
		public static Vector3 Decrypt(RawEncryptedVector3 value, int key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xE8F268", Offset = "0xE8F268", VA = "0xE8F268")]
		public static ObscuredVector3 FromEncrypted(RawEncryptedVector3 encrypted)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xE8F384", Offset = "0xE8F384", VA = "0xE8F384")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xE8F640", Offset = "0xE8F640", VA = "0xE8F640")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xE8F770", Offset = "0xE8F770", VA = "0xE8F770")]
		public RawEncryptedVector3 GetEncrypted()
		{
			return default(RawEncryptedVector3);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xE8F2C4", Offset = "0xE8F2C4", VA = "0xE8F2C4")]
		public void SetEncrypted(RawEncryptedVector3 encrypted)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xE8F798", Offset = "0xE8F798", VA = "0xE8F798")]
		public Vector3 GetDecrypted()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xE8F474", Offset = "0xE8F474", VA = "0xE8F474")]
		private Vector3 InternalDecrypt()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xE8F79C", Offset = "0xE8F79C", VA = "0xE8F79C")]
		private bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xE8E9E8", Offset = "0xE8E9E8", VA = "0xE8E9E8")]
		private float InternalDecryptField(int encrypted)
		{
			return default(float);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xE8EAF4", Offset = "0xE8EAF4", VA = "0xE8EAF4")]
		private int InternalEncryptField(float encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xE8F8D0", Offset = "0xE8F8D0", VA = "0xE8F8D0")]
		public static implicit operator ObscuredVector3(Vector3 value)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xE8F8E4", Offset = "0xE8F8E4", VA = "0xE8F8E4")]
		public static implicit operator Vector3(ObscuredVector3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xE8F8E8", Offset = "0xE8F8E8", VA = "0xE8F8E8")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xE8FA00", Offset = "0xE8FA00", VA = "0xE8FA00")]
		public static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xE8FB0C", Offset = "0xE8FB0C", VA = "0xE8FB0C")]
		public static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xE8FC18", Offset = "0xE8FC18", VA = "0xE8FC18")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xE8FD30", Offset = "0xE8FD30", VA = "0xE8FD30")]
		public static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xE8FE3C", Offset = "0xE8FE3C", VA = "0xE8FE3C")]
		public static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xE8FF48", Offset = "0xE8FF48", VA = "0xE8FF48")]
		public static ObscuredVector3 operator -(ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xE90034", Offset = "0xE90034", VA = "0xE90034")]
		public static ObscuredVector3 operator *(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xE90128", Offset = "0xE90128", VA = "0xE90128")]
		public static ObscuredVector3 operator *(float d, ObscuredVector3 a)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xE9021C", Offset = "0xE9021C", VA = "0xE9021C")]
		public static ObscuredVector3 operator /(ObscuredVector3 a, float d)
		{
			return default(ObscuredVector3);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xE90310", Offset = "0xE90310", VA = "0xE90310")]
		public static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xE903D8", Offset = "0xE903D8", VA = "0xE903D8")]
		public static bool operator ==(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xE9048C", Offset = "0xE9048C", VA = "0xE9048C")]
		public static bool operator ==(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xE90540", Offset = "0xE90540", VA = "0xE90540")]
		public static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xE90608", Offset = "0xE90608", VA = "0xE90608")]
		public static bool operator !=(Vector3 lhs, ObscuredVector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xE906BC", Offset = "0xE906BC", VA = "0xE906BC")]
		public static bool operator !=(ObscuredVector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xE90770", Offset = "0xE90770", VA = "0xE90770", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xE907B4", Offset = "0xE907B4", VA = "0xE907B4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xE907E4", Offset = "0xE907E4", VA = "0xE907E4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xE90814", Offset = "0xE90814", VA = "0xE90814")]
		public string ToString(string format)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x95B5AC", Offset = "0x95B5AC")]
	public struct ObscuredVector3Int
	{
		[Serializable]
		[Token(Token = "0x20000F9")]
		public struct RawEncryptedVector3Int
		{
			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int x;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int y;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int z;
		}

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Vector3Int zero;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		private RawEncryptedVector3Int hiddenValue;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool inited;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Vector3Int fakeValue;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool fakeValueActive;

		[Token(Token = "0x17000067")]
		public int x
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0xE90C90", Offset = "0xE90C90", VA = "0xE90C90")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600069C")]
			[Address(RVA = "0xE90E24", Offset = "0xE90E24", VA = "0xE90E24")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public int y
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0xE90F58", Offset = "0xE90F58", VA = "0xE90F58")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600069E")]
			[Address(RVA = "0xE91050", Offset = "0xE91050", VA = "0xE91050")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public int z
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0xE910E8", Offset = "0xE910E8", VA = "0xE910E8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0xE911E0", Offset = "0xE911E0", VA = "0xE911E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public int Item
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0xE91278", Offset = "0xE91278", VA = "0xE91278")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xE91340", Offset = "0xE91340", VA = "0xE91340")]
			set
			{
			}
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xE908E4", Offset = "0xE908E4", VA = "0xE908E4")]
		private ObscuredVector3Int(Vector3Int value)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xE90A50", Offset = "0xE90A50", VA = "0xE90A50")]
		public ObscuredVector3Int(int x, int y, int z)
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xE91418", Offset = "0xE91418", VA = "0xE91418")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xE909D0", Offset = "0xE909D0", VA = "0xE909D0")]
		public static RawEncryptedVector3Int Encrypt(Vector3Int value)
		{
			return default(RawEncryptedVector3Int);
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xE91484", Offset = "0xE91484", VA = "0xE91484")]
		public static RawEncryptedVector3Int Encrypt(Vector3Int value, int key)
		{
			return default(RawEncryptedVector3Int);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xE90B9C", Offset = "0xE90B9C", VA = "0xE90B9C")]
		public static RawEncryptedVector3Int Encrypt(int x, int y, int z, int key)
		{
			return default(RawEncryptedVector3Int);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xE91548", Offset = "0xE91548", VA = "0xE91548")]
		public static Vector3Int Decrypt(RawEncryptedVector3Int value)
		{
			return default(Vector3Int);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xE915C8", Offset = "0xE915C8", VA = "0xE915C8")]
		public static Vector3Int Decrypt(RawEncryptedVector3Int value, int key)
		{
			return default(Vector3Int);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xE916EC", Offset = "0xE916EC", VA = "0xE916EC")]
		public static ObscuredVector3Int FromEncrypted(RawEncryptedVector3Int encrypted)
		{
			return default(ObscuredVector3Int);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xE91808", Offset = "0xE91808", VA = "0xE91808")]
		public void ApplyNewCryptoKey()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xE91B04", Offset = "0xE91B04", VA = "0xE91B04")]
		public void RandomizeCryptoKey()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xE91BC0", Offset = "0xE91BC0", VA = "0xE91BC0")]
		public RawEncryptedVector3Int GetEncrypted()
		{
			return default(RawEncryptedVector3Int);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xE91748", Offset = "0xE91748", VA = "0xE91748")]
		public void SetEncrypted(RawEncryptedVector3Int encrypted)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xE91BE8", Offset = "0xE91BE8", VA = "0xE91BE8")]
		public Vector3Int GetDecrypted()
		{
			return default(Vector3Int);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xE918E0", Offset = "0xE918E0", VA = "0xE918E0")]
		private Vector3Int InternalDecrypt()
		{
			return default(Vector3Int);
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xE90D88", Offset = "0xE90D88", VA = "0xE90D88")]
		private int InternalDecryptField(int encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xE90EBC", Offset = "0xE90EBC", VA = "0xE90EBC")]
		private int InternalEncryptField(int encrypted)
		{
			return default(int);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xE91C00", Offset = "0xE91C00", VA = "0xE91C00")]
		public static implicit operator ObscuredVector3Int(Vector3Int value)
		{
			return default(ObscuredVector3Int);
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xE91C20", Offset = "0xE91C20", VA = "0xE91C20")]
		public static implicit operator Vector3Int(ObscuredVector3Int value)
		{
			return default(Vector3Int);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xE91C38", Offset = "0xE91C38", VA = "0xE91C38")]
		public static implicit operator Vector3(ObscuredVector3Int value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xE91CB4", Offset = "0xE91CB4", VA = "0xE91CB4")]
		public static ObscuredVector3Int operator +(ObscuredVector3Int a, ObscuredVector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xE91DA4", Offset = "0xE91DA4", VA = "0xE91DA4")]
		public static ObscuredVector3Int operator +(Vector3Int a, ObscuredVector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xE91E88", Offset = "0xE91E88", VA = "0xE91E88")]
		public static ObscuredVector3Int operator +(ObscuredVector3Int a, Vector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xE91F6C", Offset = "0xE91F6C", VA = "0xE91F6C")]
		public static ObscuredVector3Int operator -(ObscuredVector3Int a, ObscuredVector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xE9205C", Offset = "0xE9205C", VA = "0xE9205C")]
		public static ObscuredVector3Int operator -(Vector3Int a, ObscuredVector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xE92140", Offset = "0xE92140", VA = "0xE92140")]
		public static ObscuredVector3Int operator -(ObscuredVector3Int a, Vector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xE92224", Offset = "0xE92224", VA = "0xE92224")]
		public static ObscuredVector3Int operator *(ObscuredVector3Int a, int d)
		{
			return default(ObscuredVector3Int);
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xE922F8", Offset = "0xE922F8", VA = "0xE922F8")]
		public static bool operator ==(ObscuredVector3Int lhs, ObscuredVector3Int rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xE92398", Offset = "0xE92398", VA = "0xE92398")]
		public static bool operator ==(Vector3Int lhs, ObscuredVector3Int rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xE9242C", Offset = "0xE9242C", VA = "0xE9242C")]
		public static bool operator ==(ObscuredVector3Int lhs, Vector3Int rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xE924C0", Offset = "0xE924C0", VA = "0xE924C0")]
		public static bool operator !=(ObscuredVector3Int lhs, ObscuredVector3Int rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xE92560", Offset = "0xE92560", VA = "0xE92560")]
		public static bool operator !=(Vector3Int lhs, ObscuredVector3Int rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xE925F4", Offset = "0xE925F4", VA = "0xE925F4")]
		public static bool operator !=(ObscuredVector3Int lhs, Vector3Int rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xE92688", Offset = "0xE92688", VA = "0xE92688", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xE926CC", Offset = "0xE926CC", VA = "0xE926CC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xE926FC", Offset = "0xE926FC", VA = "0xE926FC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xE9272C", Offset = "0xE9272C", VA = "0xE9272C")]
		public string ToString(string format)
		{
			return null;
		}
	}
}
namespace CodeStage.AntiCheat.Detectors
{
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95B5E4", Offset = "0x95B5E4")]
	public abstract class ACTkDetectorBase : MonoBehaviour
	{
		[Token(Token = "0x40005C8")]
		protected const string ContainerName = "Anti-Cheat Toolkit Detectors";

		[Token(Token = "0x40005C9")]
		protected const string MenuPath = "Code Stage/Anti-Cheat Toolkit/";

		[Token(Token = "0x40005CA")]
		protected const string GameObjectMenuPath = "GameObject/Create Other/Code Stage/Anti-Cheat Toolkit/";

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static GameObject detectorsContainer;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95C6E8", Offset = "0x95C6E8")]
		public bool autoStart;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95C720", Offset = "0x95C720")]
		public bool keepAlive;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95C758", Offset = "0x95C758")]
		public bool autoDispose;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected UnityEvent detectionEvent;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected bool detectionEventHasListener;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		protected bool started;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		protected bool isRunning;

		[Token(Token = "0x1700006B")]
		public bool IsRunning
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x11C3058", Offset = "0x11C3058", VA = "0x11C3058")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000004")]
		public event Action CheatDetected
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x11C2F10", Offset = "0x11C2F10", VA = "0x11C2F10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D1BC", Offset = "0x95D1BC")]
			add
			{
			}
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x11C2FB4", Offset = "0x11C2FB4", VA = "0x11C2FB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D1CC", Offset = "0x95D1CC")]
			remove
			{
			}
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x11C3060", Offset = "0x11C3060", VA = "0x11C3060")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x11C3168", Offset = "0x11C3168", VA = "0x11C3168")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x11C3174", Offset = "0x11C3174", VA = "0x11C3174")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x11C3180", Offset = "0x11C3180", VA = "0x11C3180")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x11C318C", Offset = "0x11C318C", VA = "0x11C318C", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x11C32B0", Offset = "0x11C32B0", VA = "0x11C32B0", Slot = "5")]
		internal virtual void OnCheatingDetected()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x11C3314", Offset = "0x11C3314", VA = "0x11C3314", Slot = "6")]
		protected virtual bool Init(ACTkDetectorBase instance, string detectorName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x11C3518", Offset = "0x11C3518", VA = "0x11C3518", Slot = "7")]
		protected virtual void DisposeInternal()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x11C3580", Offset = "0x11C3580", VA = "0x11C3580", Slot = "8")]
		protected virtual bool DetectorHasCallbacks()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x11C35A0", Offset = "0x11C35A0", VA = "0x11C35A0", Slot = "9")]
		protected virtual void StopDetectionInternal()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x11C35AC", Offset = "0x11C35AC", VA = "0x11C35AC", Slot = "10")]
		protected virtual void PauseDetector()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x11C35BC", Offset = "0x11C35BC", VA = "0x11C35BC", Slot = "11")]
		protected virtual bool ResumeDetector()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D6")]
		protected abstract void StartDetectionAutomatically();

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x11C3600", Offset = "0x11C3600", VA = "0x11C3600")]
		protected ACTkDetectorBase()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95B61C", Offset = "0x95B61C")]
	public class ActDetectorBase : MonoBehaviour
	{
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x11C3618", Offset = "0x11C3618", VA = "0x11C3618")]
		public ActDetectorBase()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95B658", Offset = "0x95B658")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x95B658", Offset = "0x95B658")]
	public class InjectionDetector : ACTkDetectorBase
	{
		[Token(Token = "0x40005D4")]
		internal const string ComponentName = "Injection Detector";

		[Token(Token = "0x40005D5")]
		internal const string FinalLogPrefix = "[ACTk] Injection Detector: ";

		[Token(Token = "0x1700006C")]
		public static InjectionDetector Instance
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x11C3620", Offset = "0x11C3620", VA = "0x11C3620")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x11C3694", Offset = "0x11C3694", VA = "0x11C3694")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x11C3700", Offset = "0x11C3700", VA = "0x11C3700")]
		public static void StartDetection(Action<string> callback)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x11C376C", Offset = "0x11C376C", VA = "0x11C376C")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x11C37D8", Offset = "0x11C37D8", VA = "0x11C37D8")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x11C3844", Offset = "0x11C3844", VA = "0x11C3844", Slot = "12")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x11C38B0", Offset = "0x11C38B0", VA = "0x11C38B0")]
		public InjectionDetector()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95B6C8", Offset = "0x95B6C8")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x95B6C8", Offset = "0x95B6C8")]
	public class ObscuredCheatingDetector : ACTkDetectorBase
	{
		[Token(Token = "0x40005D6")]
		internal const string ComponentName = "Obscured Cheating Detector";

		[Token(Token = "0x40005D7")]
		internal const string FinalLogPrefix = "[ACTk] Obscured Cheating Detector: ";

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95C7C0", Offset = "0x95C7C0")]
		public double doubleEpsilon;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95C7F8", Offset = "0x95C7F8")]
		public float floatEpsilon;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95C830", Offset = "0x95C830")]
		public float vector2Epsilon;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95C868", Offset = "0x95C868")]
		public float vector3Epsilon;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95C8A0", Offset = "0x95C8A0")]
		public float quaternionEpsilon;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95C8D8", Offset = "0x95C8D8")]
		private static ObscuredCheatingDetector <Instance>k__BackingField;

		[Token(Token = "0x1700006D")]
		public static ObscuredCheatingDetector Instance
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x11C3F50", Offset = "0x11C3F50", VA = "0x11C3F50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D1DC", Offset = "0x95D1DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x11C3FA0", Offset = "0x11C3FA0", VA = "0x11C3FA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D1EC", Offset = "0x95D1EC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		private static ObscuredCheatingDetector GetOrCreateInstance
		{
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x11C38CC", Offset = "0x11C38CC", VA = "0x11C38CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		internal static bool ExistsAndIsRunning
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x11C3FF4", Offset = "0x11C3FF4", VA = "0x11C3FF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x11C38C8", Offset = "0x11C38C8", VA = "0x11C38C8")]
		public static ObscuredCheatingDetector AddToSceneOrGetExisting()
		{
			return null;
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x11C3A7C", Offset = "0x11C3A7C", VA = "0x11C3A7C")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x11C3D2C", Offset = "0x11C3D2C", VA = "0x11C3D2C")]
		public static void StartDetection(Action callback)
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x11C3D58", Offset = "0x11C3D58", VA = "0x11C3D58")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x11C3E54", Offset = "0x11C3E54", VA = "0x11C3E54")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x11C405C", Offset = "0x11C405C", VA = "0x11C405C")]
		private ObscuredCheatingDetector()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x11C4094", Offset = "0x11C4094", VA = "0x11C4094")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x11C41D4", Offset = "0x11C41D4", VA = "0x11C41D4", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x11C4238", Offset = "0x11C4238", VA = "0x11C4238")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x11C3BA4", Offset = "0x11C3BA4", VA = "0x11C3BA4")]
		private void StartDetectionInternal(Action callback)
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x11C432C", Offset = "0x11C432C", VA = "0x11C432C", Slot = "12")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x11C4334", Offset = "0x11C4334", VA = "0x11C4334", Slot = "7")]
		protected override void DisposeInternal()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95B738", Offset = "0x95B738")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x95B738", Offset = "0x95B738")]
	public class SpeedHackDetector : ACTkDetectorBase
	{
		[Token(Token = "0x40005DF")]
		internal const string ComponentName = "Speed Hack Detector";

		[Token(Token = "0x40005E0")]
		internal const string LogPrefix = "[ACTk] Speed Hack Detector: ";

		[Token(Token = "0x40005E1")]
		private const long TicksPerSecond = 10000000L;

		[Token(Token = "0x40005E2")]
		private const int Threshold = 5000000;

		[Token(Token = "0x40005E3")]
		private const float ThresholdFloat = 0.5f;

		[Token(Token = "0x40005E4")]
		private const string RoutinesClassPath = "net.codestage.actk.androidnative.ACTkAndroidRoutines";

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95C8E8", Offset = "0x95C8E8")]
		public float interval;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95C920", Offset = "0x95C920")]
		public byte maxFalsePositives;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95C958", Offset = "0x95C958")]
		public int coolDown;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private byte currentFalsePositives;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int currentCooldownShots;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private long ticksOnStart;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private long vulnerableTicksOnStart;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private long previousTicks;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private long previousIntervalTicks;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float vulnerableTimeOnStart;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AndroidJavaClass routinesClass;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool androidTimeReadAttemptWasMade;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95C990", Offset = "0x95C990")]
		private static SpeedHackDetector <Instance>k__BackingField;

		[Token(Token = "0x17000070")]
		public static SpeedHackDetector Instance
		{
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x11C4BDC", Offset = "0x11C4BDC", VA = "0x11C4BDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D1FC", Offset = "0x95D1FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x11C4C2C", Offset = "0x11C4C2C", VA = "0x11C4C2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D20C", Offset = "0x95D20C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000071")]
		private static SpeedHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x11C4424", Offset = "0x11C4424", VA = "0x11C4424")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x11C4420", Offset = "0x11C4420", VA = "0x11C4420")]
		public static SpeedHackDetector AddToSceneOrGetExisting()
		{
			return null;
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x11C45D4", Offset = "0x11C45D4", VA = "0x11C45D4")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x11C48D8", Offset = "0x11C48D8", VA = "0x11C48D8")]
		public static void StartDetection(Action callback)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x11C4908", Offset = "0x11C4908", VA = "0x11C4908")]
		public static void StartDetection(Action callback, float interval)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x11C4948", Offset = "0x11C4948", VA = "0x11C4948")]
		public static void StartDetection(Action callback, float interval, byte maxFalsePositives)
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x11C4990", Offset = "0x11C4990", VA = "0x11C4990")]
		public static void StartDetection(Action callback, float interval, byte maxFalsePositives, int coolDown)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x11C49E4", Offset = "0x11C49E4", VA = "0x11C49E4")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x11C4AE0", Offset = "0x11C4AE0", VA = "0x11C4AE0")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x11C4C80", Offset = "0x11C4C80", VA = "0x11C4C80")]
		private SpeedHackDetector()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x11C4CB0", Offset = "0x11C4CB0", VA = "0x11C4CB0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x11C4DF0", Offset = "0x11C4DF0", VA = "0x11C4DF0", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x11C4E54", Offset = "0x11C4E54", VA = "0x11C4E54")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x11C4F48", Offset = "0x11C4F48", VA = "0x11C4F48")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x11C4FA0", Offset = "0x11C4FA0", VA = "0x11C4FA0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x11C4708", Offset = "0x11C4708", VA = "0x11C4708")]
		private void StartDetectionInternal(Action callback, float checkInterval, byte falsePositives, int shotsTillCooldown)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x11C5204", Offset = "0x11C5204", VA = "0x11C5204", Slot = "12")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x11C5218", Offset = "0x11C5218", VA = "0x11C5218", Slot = "7")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x11C4F54", Offset = "0x11C4F54", VA = "0x11C4F54")]
		private void ResetStartTicks()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x11C5174", Offset = "0x11C5174", VA = "0x11C5174")]
		private long GetReliableTicks()
		{
			return default(long);
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x11C5330", Offset = "0x11C5330", VA = "0x11C5330")]
		private long TryReadTicksFromAndroidRoutine()
		{
			return default(long);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x11C5314", Offset = "0x11C5314", VA = "0x11C5314")]
		private void ReleaseAndroidClass()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95B7A8", Offset = "0x95B7A8")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x95B7A8", Offset = "0x95B7A8")]
	public class TimeCheatingDetector : ACTkDetectorBase
	{
		[Token(Token = "0x20000FA")]
		public delegate void OnlineTimeCallback(OnlineTimeResult result);

		[Token(Token = "0x20000FB")]
		public delegate void TimeCheatingDetectorEventHandler(CheckResult checkResult, ErrorKind errorKind);

		[Token(Token = "0x20000FC")]
		public struct OnlineTimeResult
		{
			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool success;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string error;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long errorResponseCode;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public double onlineSecondsUtc;

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x11C75C0", Offset = "0x11C75C0", VA = "0x11C75C0")]
			internal void SetTime(double secondsUtc)
			{
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x11C71A0", Offset = "0x11C71A0", VA = "0x11C71A0")]
			internal void SetError(string errorText, long responseCode = -1L)
			{
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x11C9BAC", Offset = "0x11C9BAC", VA = "0x11C9BAC", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x20000FD")]
		public enum CheckResult
		{
			[Token(Token = "0x400075D")]
			Unknown = 0,
			[Token(Token = "0x400075E")]
			CheckPassed = 5,
			[Token(Token = "0x400075F")]
			WrongTimeDetected = 10,
			[Token(Token = "0x4000760")]
			CheatDetected = 15,
			[Token(Token = "0x4000761")]
			Error = 100
		}

		[Token(Token = "0x20000FE")]
		public enum ErrorKind
		{
			[Token(Token = "0x4000763")]
			NoError = 0,
			[Token(Token = "0x4000764")]
			IncorrectUri = 3,
			[Token(Token = "0x4000765")]
			OnlineTimeError = 5,
			[Token(Token = "0x4000766")]
			NotStarted = 10,
			[Token(Token = "0x4000767")]
			AlreadyCheckingForCheat = 15,
			[Token(Token = "0x4000768")]
			Unknown = 100
		}

		[Token(Token = "0x20000FF")]
		public enum RequestMethod
		{
			[Token(Token = "0x400076A")]
			Head,
			[Token(Token = "0x400076B")]
			Get
		}

		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95B950", Offset = "0x95B950")]
		private sealed class <GetOnlineTimeCoroutine>d__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string url;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public OnlineTimeCallback callback;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public RequestMethod method;

			[Token(Token = "0x17000085")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007EE")]
				[Address(RVA = "0x11C8CE0", Offset = "0x11C8CE0", VA = "0x11C8CE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000086")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007F0")]
				[Address(RVA = "0x11C8D48", Offset = "0x11C8D48", VA = "0x11C8D48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x11C6898", Offset = "0x11C6898", VA = "0x11C6898")]
			[DebuggerHidden]
			public <GetOnlineTimeCoroutine>d__59(int <>1__state)
			{
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x11C8C30", Offset = "0x11C8C30", VA = "0x11C8C30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x11C8C34", Offset = "0x11C8C34", VA = "0x11C8C34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x11C8CE8", Offset = "0x11C8CE8", VA = "0x11C8CE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95B960", Offset = "0x95B960")]
		private sealed class <GetOnlineTimeCoroutine>d__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Uri uri;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RequestMethod method;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public OnlineTimeCallback callback;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private OnlineTimeResult <result>5__2;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UnityWebRequest <wr>5__3;

			[Token(Token = "0x17000087")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007F5")]
				[Address(RVA = "0x11C9338", Offset = "0x11C9338", VA = "0x11C9338", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000088")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007F7")]
				[Address(RVA = "0x11C93A0", Offset = "0x11C93A0", VA = "0x11C93A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x11C694C", Offset = "0x11C694C", VA = "0x11C694C")]
			[DebuggerHidden]
			public <GetOnlineTimeCoroutine>d__60(int <>1__state)
			{
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x11C8D50", Offset = "0x11C8D50", VA = "0x11C8D50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x11C8E2C", Offset = "0x11C8E2C", VA = "0x11C8E2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x11C8D6C", Offset = "0x11C8D6C", VA = "0x11C8D6C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x11C9340", Offset = "0x11C9340", VA = "0x11C9340", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[Token(Token = "0x2000102")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95B970", Offset = "0x95B970")]
		private struct <GetOnlineTimeTask>d__61 : IAsyncStateMachine
		{
			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<OnlineTimeResult> <>t__builder;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string url;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RequestMethod method;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<OnlineTimeResult> <>u__1;

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x11C93A8", Offset = "0x11C93A8", VA = "0x11C93A8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x11C95A4", Offset = "0x11C95A4", VA = "0x11C95A4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95B980", Offset = "0x95B980")]
		private struct <GetOnlineTimeTask>d__62 : IAsyncStateMachine
		{
			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<OnlineTimeResult> <>t__builder;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Uri uri;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RequestMethod method;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private OnlineTimeResult <result>5__2;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UnityWebRequest <wr>5__3;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private UnityWebRequestAsyncOperation <asyncOperation>5__4;

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x11C9604", Offset = "0x11C9604", VA = "0x11C9604", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x11C9AAC", Offset = "0x11C9AAC", VA = "0x11C9AAC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95B990", Offset = "0x95B990")]
		private sealed class <ForceCheckEnumerator>d__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TimeCheatingDetector <>4__this;

			[Token(Token = "0x17000089")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007FF")]
				[Address(RVA = "0x11C87F4", Offset = "0x11C87F4", VA = "0x11C87F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000801")]
				[Address(RVA = "0x11C885C", Offset = "0x11C885C", VA = "0x11C885C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x11C7748", Offset = "0x11C7748", VA = "0x11C7748")]
			[DebuggerHidden]
			public <ForceCheckEnumerator>d__68(int <>1__state)
			{
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x11C8674", Offset = "0x11C8674", VA = "0x11C8674", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x11C8678", Offset = "0x11C8678", VA = "0x11C8678", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x11C87FC", Offset = "0x11C87FC", VA = "0x11C87FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95B9A0", Offset = "0x95B9A0")]
		private struct <ForceCheckTask>d__69 : IAsyncStateMachine
		{
			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<CheckResult> <>t__builder;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TimeCheatingDetector <>4__this;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter <>u__1;

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x11C8864", Offset = "0x11C8864", VA = "0x11C8864", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000803")]
			[Address(RVA = "0x11C8BD0", Offset = "0x11C8BD0", VA = "0x11C8BD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95B9B0", Offset = "0x95B9B0")]
		private sealed class <CheckForCheat>d__77 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TimeCheatingDetector <>4__this;

			[Token(Token = "0x1700008B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000807")]
				[Address(RVA = "0x11C8604", Offset = "0x11C8604", VA = "0x11C8604", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000809")]
				[Address(RVA = "0x11C866C", Offset = "0x11C866C", VA = "0x11C866C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x11C7AE4", Offset = "0x11C7AE4", VA = "0x11C7AE4")]
			[DebuggerHidden]
			public <CheckForCheat>d__77(int <>1__state)
			{
			}

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x11C8324", Offset = "0x11C8324", VA = "0x11C8324", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x11C8328", Offset = "0x11C8328", VA = "0x11C8328", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000808")]
			[Address(RVA = "0x11C860C", Offset = "0x11C860C", VA = "0x11C860C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005F3")]
		internal const string ComponentName = "Time Cheating Detector";

		[Token(Token = "0x40005F4")]
		private const string LogPrefix = "[ACTk] Time Cheating Detector: ";

		[Token(Token = "0x40005F5")]
		private const int DefaultTimeoutSeconds = 10;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly WaitForEndOfFrame cachedEndOfFrame;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int instancesInScene;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static bool gettingOnlineTime;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static int sdkLevel;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x95C9B0", Offset = "0x95C9B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95C9B0", Offset = "0x95C9B0")]
		[SerializeField]
		private string requestUrl;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95CA20", Offset = "0x95CA20")]
		public RequestMethod requestMethod;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95CA58", Offset = "0x95CA58")]
		public int timeoutSeconds;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x95CA90", Offset = "0x95CA90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95CA90", Offset = "0x95CA90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95CA90", Offset = "0x95CA90")]
		public float interval;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95CB0C", Offset = "0x95CB0C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x95CB0C", Offset = "0x95CB0C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95CB0C", Offset = "0x95CB0C")]
		public int realCheatThreshold;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95CB88", Offset = "0x95CB88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95CB88", Offset = "0x95CB88")]
		public int wrongTimeThreshold;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95CBE0", Offset = "0x95CBE0")]
		private ErrorKind <LastError>k__BackingField;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95CBF0", Offset = "0x95CBF0")]
		private CheckResult <LastResult>k__BackingField;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95CC00", Offset = "0x95CC00")]
		private bool <IsCheckingForCheat>k__BackingField;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly string onlineOfflineDifferencePrefsKey;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Uri cachedUri;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TimeCheatingDetectorEventHandler cheatChecked;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float timeElapsed;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool updateAfterPause;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private double lastOnlineSecondsUtc;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95CC10", Offset = "0x95CC10")]
		private static TimeCheatingDetector <Instance>k__BackingField;

		[NonSerialized]
		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95CC40", Offset = "0x95CC40")]
		public int threshold;

		[NonSerialized]
		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95CC7C", Offset = "0x95CC7C")]
		public string timeServer;

		[Token(Token = "0x17000072")]
		public string RequestUrl
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x11C574C", Offset = "0x11C574C", VA = "0x11C574C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x11C5754", Offset = "0x11C5754", VA = "0x11C5754")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public ErrorKind LastError
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x11C58C4", Offset = "0x11C58C4", VA = "0x11C58C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D23C", Offset = "0x95D23C")]
			get
			{
				return default(ErrorKind);
			}
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x11C58CC", Offset = "0x11C58CC", VA = "0x11C58CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D24C", Offset = "0x95D24C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public CheckResult LastResult
		{
			[Token(Token = "0x600070E")]
			[Address(RVA = "0x11C58D4", Offset = "0x11C58D4", VA = "0x11C58D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D25C", Offset = "0x95D25C")]
			get
			{
				return default(CheckResult);
			}
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x11C58DC", Offset = "0x11C58DC", VA = "0x11C58DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D26C", Offset = "0x95D26C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public bool IsCheckingForCheat
		{
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x11C58E4", Offset = "0x11C58E4", VA = "0x11C58E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D27C", Offset = "0x95D27C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000711")]
			[Address(RVA = "0x11C58EC", Offset = "0x11C58EC", VA = "0x11C58EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D28C", Offset = "0x95D28C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public static TimeCheatingDetector Instance
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x11C58F8", Offset = "0x11C58F8", VA = "0x11C58F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D29C", Offset = "0x95D29C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x11C5960", Offset = "0x11C5960", VA = "0x11C5960")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D2AC", Offset = "0x95D2AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000077")]
		private static TimeCheatingDetector GetOrCreateInstance
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x11C59CC", Offset = "0x11C59CC", VA = "0x11C59CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000005")]
		public event TimeCheatingDetectorEventHandler CheatChecked
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x11C5604", Offset = "0x11C5604", VA = "0x11C5604")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D21C", Offset = "0x95D21C")]
			add
			{
			}
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x11C56A8", Offset = "0x11C56A8", VA = "0x11C56A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D22C", Offset = "0x95D22C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95D9FC", Offset = "0x95D9FC")]
		public event Action<ErrorKind> Error
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x11C7F38", Offset = "0x11C7F38", VA = "0x11C7F38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D578", Offset = "0x95D578")]
			add
			{
			}
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x11C7FDC", Offset = "0x11C7FDC", VA = "0x11C7FDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D588", Offset = "0x95D588")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95DA38", Offset = "0x95DA38")]
		public event Action CheckPassed
		{
			[Token(Token = "0x6000738")]
			[Address(RVA = "0x11C8080", Offset = "0x11C8080", VA = "0x11C8080")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D598", Offset = "0x95D598")]
			add
			{
			}
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x11C8124", Offset = "0x11C8124", VA = "0x11C8124")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D5A8", Offset = "0x95D5A8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x11C5C3C", Offset = "0x11C5C3C", VA = "0x11C5C3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x11C5DE0", Offset = "0x11C5DE0", VA = "0x11C5DE0", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x11C5EBC", Offset = "0x11C5EBC", VA = "0x11C5EBC")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x11C5FF8", Offset = "0x11C5FF8", VA = "0x11C5FF8")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x11C601C", Offset = "0x11C601C", VA = "0x11C601C")]
		private void Update()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x11C6130", Offset = "0x11C6130", VA = "0x11C6130")]
		public static TimeCheatingDetector AddToSceneOrGetExisting()
		{
			return null;
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x11C618C", Offset = "0x11C618C", VA = "0x11C618C")]
		public static void StartDetection([Optional] TimeCheatingDetectorEventHandler cheatCheckedEventHandler)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x11C64D4", Offset = "0x11C64D4", VA = "0x11C64D4")]
		public static void StartDetection(float interval, [Optional] TimeCheatingDetectorEventHandler cheatCheckedEventHandler)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x11C6554", Offset = "0x11C6554", VA = "0x11C6554")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x11C66B4", Offset = "0x11C66B4", VA = "0x11C66B4")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x11C6814", Offset = "0x11C6814", VA = "0x11C6814")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x95D2BC", Offset = "0x95D2BC")]
		public static IEnumerator GetOnlineTimeCoroutine(string url, OnlineTimeCallback callback, RequestMethod method = RequestMethod.Head)
		{
			return null;
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x11C68C4", Offset = "0x11C68C4", VA = "0x11C68C4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x95D320", Offset = "0x95D320")]
		public static IEnumerator GetOnlineTimeCoroutine(Uri uri, OnlineTimeCallback callback, RequestMethod method = RequestMethod.Head)
		{
			return null;
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x11C6978", Offset = "0x11C6978", VA = "0x11C6978")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x95D384", Offset = "0x95D384")]
		public static Task<OnlineTimeResult> GetOnlineTimeTask(string url, RequestMethod method = RequestMethod.Head)
		{
			return null;
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x11C6AA0", Offset = "0x11C6AA0", VA = "0x11C6AA0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x95D3E8", Offset = "0x95D3E8")]
		public static Task<OnlineTimeResult> GetOnlineTimeTask(Uri uri, RequestMethod method = RequestMethod.Head)
		{
			return null;
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x11C6BB4", Offset = "0x11C6BB4", VA = "0x11C6BB4")]
		private static UnityWebRequest GetWebRequest(Uri uri, RequestMethod method)
		{
			return null;
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x11C6FB0", Offset = "0x11C6FB0", VA = "0x11C6FB0")]
		private static void FillRequestResult(UnityWebRequest request, ref OnlineTimeResult result)
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x11C57F0", Offset = "0x11C57F0", VA = "0x11C57F0")]
		private static Uri UrlToUri(string url)
		{
			return null;
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x11C71B4", Offset = "0x11C71B4", VA = "0x11C71B4")]
		private static bool TryGetDate(string source, out DateTime date)
		{
			return default(bool);
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x11C75D8", Offset = "0x11C75D8", VA = "0x11C75D8")]
		public bool ForceCheck()
		{
			return default(bool);
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x11C76D8", Offset = "0x11C76D8", VA = "0x11C76D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x95D44C", Offset = "0x95D44C")]
		public IEnumerator ForceCheckEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x11C7774", Offset = "0x11C7774", VA = "0x11C7774")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x95D4B0", Offset = "0x95D4B0")]
		public Task<CheckResult> ForceCheckTask()
		{
			return null;
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x11C6398", Offset = "0x11C6398", VA = "0x11C6398")]
		private void StartDetectionInternal(float checkInterval, [Optional] TimeCheatingDetectorEventHandler cheatCheckedEventHandler)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x11C7874", Offset = "0x11C7874", VA = "0x11C7874", Slot = "6")]
		protected override bool Init(ACTkDetectorBase instance, string detectorName)
		{
			return default(bool);
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x11C7930", Offset = "0x11C7930", VA = "0x11C7930", Slot = "12")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x11C793C", Offset = "0x11C793C", VA = "0x11C793C", Slot = "8")]
		protected override bool DetectorHasCallbacks()
		{
			return default(bool);
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x11C796C", Offset = "0x11C796C", VA = "0x11C796C", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x11C7984", Offset = "0x11C7984", VA = "0x11C7984", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x11C7998", Offset = "0x11C7998", VA = "0x11C7998", Slot = "7")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x11C60C0", Offset = "0x11C60C0", VA = "0x11C60C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x95D514", Offset = "0x95D514")]
		private IEnumerator CheckForCheat()
		{
			return null;
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x11C7B10", Offset = "0x11C7B10", VA = "0x11C7B10")]
		private void ReportCheckResult()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x11C7E88", Offset = "0x11C7E88", VA = "0x11C7E88")]
		private void OnOnlineTimeReceived(OnlineTimeResult result)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x11C7EB0", Offset = "0x11C7EB0", VA = "0x11C7EB0")]
		private double GetLocalSecondsUtc()
		{
			return default(double);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x11C6ED4", Offset = "0x11C6ED4", VA = "0x11C6ED4")]
		private static int GetAndroidSDKLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x11C81C8", Offset = "0x11C81C8", VA = "0x11C81C8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95D5B8", Offset = "0x95D5B8")]
		public static double GetOnlineTime(string server)
		{
			return default(double);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x11C81D0", Offset = "0x11C81D0", VA = "0x11C81D0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95D5F4", Offset = "0x95D5F4")]
		public static void SetErrorCallback(Action<ErrorKind> errorCallback)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x11C81D4", Offset = "0x11C81D4", VA = "0x11C81D4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95D630", Offset = "0x95D630")]
		public static void StartDetection(Action detectionCallback, int interval)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x11C81D8", Offset = "0x11C81D8", VA = "0x11C81D8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95D66C", Offset = "0x95D66C")]
		public static void StartDetection(Action detectionCallback, Action<ErrorKind> errorCallback, int interval)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x11C81DC", Offset = "0x11C81DC", VA = "0x11C81DC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x95D6A8", Offset = "0x95D6A8")]
		public static void StartDetection(float interval, Action detectionCallback, Action<ErrorKind> errorCallback, Action checkPassedCallback)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x11C81E0", Offset = "0x11C81E0", VA = "0x11C81E0")]
		public TimeCheatingDetector()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95B818", Offset = "0x95B818")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x95B818", Offset = "0x95B818")]
	public class WallHackDetector : ACTkDetectorBase
	{
		[Token(Token = "0x2000107")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95B9C0", Offset = "0x95B9C0")]
		private sealed class <InitDetector>d__79 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WallHackDetector <>4__this;

			[Token(Token = "0x1700008D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600080D")]
				[Address(RVA = "0x11CD7C0", Offset = "0x11CD7C0", VA = "0x11CD7C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600080F")]
				[Address(RVA = "0x11CD828", Offset = "0x11CD828", VA = "0x11CD828", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600080A")]
			[Address(RVA = "0x11CCC14", Offset = "0x11CCC14", VA = "0x11CCC14")]
			[DebuggerHidden]
			public <InitDetector>d__79(int <>1__state)
			{
			}

			[Token(Token = "0x600080B")]
			[Address(RVA = "0x11CD710", Offset = "0x11CD710", VA = "0x11CD710", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600080C")]
			[Address(RVA = "0x11CD714", Offset = "0x11CD714", VA = "0x11CD714", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600080E")]
			[Address(RVA = "0x11CD7C8", Offset = "0x11CD7C8", VA = "0x11CD7C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95B9D0", Offset = "0x95B9D0")]
		private sealed class <CaptureFrame>d__84 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WallHackDetector <>4__this;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private RenderTexture <previousActive>5__2;

			[Token(Token = "0x1700008F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000813")]
				[Address(RVA = "0x11CD6A0", Offset = "0x11CD6A0", VA = "0x11CD6A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000815")]
				[Address(RVA = "0x11CD708", Offset = "0x11CD708", VA = "0x11CD708", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000810")]
			[Address(RVA = "0x11CD14C", Offset = "0x11CD14C", VA = "0x11CD14C")]
			[DebuggerHidden]
			public <CaptureFrame>d__84(int <>1__state)
			{
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0x11CD2CC", Offset = "0x11CD2CC", VA = "0x11CD2CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000812")]
			[Address(RVA = "0x11CD2D0", Offset = "0x11CD2D0", VA = "0x11CD2D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000814")]
			[Address(RVA = "0x11CD6A8", Offset = "0x11CD6A8", VA = "0x11CD6A8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400060F")]
		internal const string ComponentName = "WallHack Detector";

		[Token(Token = "0x4000610")]
		internal const string FinalLogPrefix = "[ACTk] WallHack Detector: ";

		[Token(Token = "0x4000611")]
		private const string ServiceContainerName = "[WH Detector Service]";

		[Token(Token = "0x4000612")]
		private const string WireframeShaderName = "Hidden/ACTk/WallHackTexture";

		[Token(Token = "0x4000613")]
		private const int ShaderTextureSize = 4;

		[Token(Token = "0x4000614")]
		private const int RenderTextureSize = 4;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private readonly Vector3 rigidPlayerVelocity;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int instancesInScene;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly WaitForEndOfFrame waitForEndOfFrame;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95CCB8", Offset = "0x95CCB8")]
		private bool checkRigidbody;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95CD04", Offset = "0x95CD04")]
		private bool checkController;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95CD50", Offset = "0x95CD50")]
		private bool checkWireframe;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95CD9C", Offset = "0x95CD9C")]
		private bool checkRaycast;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95CDE8", Offset = "0x95CDE8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95CDE8", Offset = "0x95CDE8")]
		public int wireframeDelay;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95CE40", Offset = "0x95CE40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95CE40", Offset = "0x95CE40")]
		public int raycastDelay;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95CE98", Offset = "0x95CE98")]
		public Vector3 spawnPosition;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x95CED0", Offset = "0x95CED0")]
		public byte maxFalsePositives;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject serviceContainer;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject solidWall;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject thinWall;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Camera wfCamera;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private MeshRenderer foregroundRenderer;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private MeshRenderer backgroundRenderer;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Color wfColor1;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Color wfColor2;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Shader wfShader;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Material wfMaterial;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Texture2D shaderTexture;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Texture2D targetTexture;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RenderTexture renderTexture;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int whLayer;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int raycastMask;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Rigidbody rigidPlayer;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private CharacterController charControllerPlayer;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float charControllerVelocity;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private byte rigidbodyDetections;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		private byte controllerDetections;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFE")]
		private byte wireframeDetections;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFF")]
		private byte raycastDetections;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool wireframeDetected;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly RaycastHit[] rayHits;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95CF08", Offset = "0x95CF08")]
		private static WallHackDetector <Instance>k__BackingField;

		[Token(Token = "0x17000078")]
		public bool CheckRigidbody
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x11C9E18", Offset = "0x11C9E18", VA = "0x11C9E18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x11C9E20", Offset = "0x11C9E20", VA = "0x11C9E20")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public bool CheckController
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x11CB2E4", Offset = "0x11CB2E4", VA = "0x11CB2E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x11CB2EC", Offset = "0x11CB2EC", VA = "0x11CB2EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public bool CheckWireframe
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x11CB584", Offset = "0x11CB584", VA = "0x11CB584")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x11CB58C", Offset = "0x11CB58C", VA = "0x11CB58C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public bool CheckRaycast
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x11CB720", Offset = "0x11CB720", VA = "0x11CB720")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x11CB728", Offset = "0x11CB728", VA = "0x11CB728")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public static WallHackDetector Instance
		{
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x11CC050", Offset = "0x11CC050", VA = "0x11CC050")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D6E4", Offset = "0x95D6E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x11CC0A0", Offset = "0x11CC0A0", VA = "0x11CC0A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95D6F4", Offset = "0x95D6F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		private static WallHackDetector GetOrCreateInstance
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x11CB8AC", Offset = "0x11CB8AC", VA = "0x11CB8AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x11CB8A8", Offset = "0x11CB8A8", VA = "0x11CB8A8")]
		public static WallHackDetector AddToSceneOrGetExisting()
		{
			return null;
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x11CBA5C", Offset = "0x11CBA5C", VA = "0x11CBA5C")]
		public static void StartDetection()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x11CBD70", Offset = "0x11CBD70", VA = "0x11CBD70")]
		public static void StartDetection(Action callback)
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x11CBDA4", Offset = "0x11CBDA4", VA = "0x11CBDA4")]
		public static void StartDetection(Action callback, Vector3 spawnPosition)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x11CBDFC", Offset = "0x11CBDFC", VA = "0x11CBDFC")]
		public static void StartDetection(Action callback, Vector3 spawnPosition, byte maxFalsePositives)
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x11CBE58", Offset = "0x11CBE58", VA = "0x11CBE58")]
		public static void StopDetection()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x11CBF54", Offset = "0x11CBF54", VA = "0x11CBF54")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x11CC0F4", Offset = "0x11CC0F4", VA = "0x11CC0F4")]
		private WallHackDetector()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x11CC204", Offset = "0x11CC204", VA = "0x11CC204")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x11CC344", Offset = "0x11CC344", VA = "0x11CC344", Slot = "4")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x11CC4A8", Offset = "0x11CC4A8", VA = "0x11CC4A8")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x11CC59C", Offset = "0x11CC59C", VA = "0x11CC59C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x11CC6DC", Offset = "0x11CC6DC", VA = "0x11CC6DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x11CBB90", Offset = "0x11CBB90", VA = "0x11CBB90")]
		private void StartDetectionInternal(Action callback, Vector3 servicePosition, byte falsePositivesInRow)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x11CC88C", Offset = "0x11CC88C", VA = "0x11CC88C", Slot = "12")]
		protected override void StartDetectionAutomatically()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x11CC8A0", Offset = "0x11CC8A0", VA = "0x11CC8A0", Slot = "10")]
		protected override void PauseDetector()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x11CC8F0", Offset = "0x11CC8F0", VA = "0x11CC8F0", Slot = "11")]
		protected override bool ResumeDetector()
		{
			return default(bool);
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x11CC978", Offset = "0x11CC978", VA = "0x11CC978", Slot = "9")]
		protected override void StopDetectionInternal()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x11CC9B4", Offset = "0x11CC9B4", VA = "0x11CC9B4", Slot = "7")]
		protected override void DisposeInternal()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x11C9ED0", Offset = "0x11C9ED0", VA = "0x11C9ED0")]
		private void UpdateServiceContainer()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x11CC81C", Offset = "0x11CC81C", VA = "0x11CC81C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x95D704", Offset = "0x95D704")]
		private IEnumerator InitDetector()
		{
			return null;
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x11CB03C", Offset = "0x11CB03C", VA = "0x11CB03C")]
		private void StartRigidModule()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x11CB39C", Offset = "0x11CB39C", VA = "0x11CB39C")]
		private void StartControllerModule()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x11CB63C", Offset = "0x11CB63C", VA = "0x11CB63C")]
		private void StartWireframeModule()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x11CD068", Offset = "0x11CD068", VA = "0x11CD068")]
		private void ShootWireframeModule()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x11CD0DC", Offset = "0x11CD0DC", VA = "0x11CD0DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x95D768", Offset = "0x95D768")]
		private IEnumerator CaptureFrame()
		{
			return null;
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x11CB7D8", Offset = "0x11CB7D8", VA = "0x11CB7D8")]
		private void StartRaycastModule()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x11CD178", Offset = "0x11CD178", VA = "0x11CD178")]
		private void ShootRaycastModule()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x11CB21C", Offset = "0x11CB21C", VA = "0x11CB21C")]
		private void StopRigidModule()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x11CB4F8", Offset = "0x11CB4F8", VA = "0x11CB4F8")]
		private void StopControllerModule()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x11CB6CC", Offset = "0x11CB6CC", VA = "0x11CB6CC")]
		private void StopWireframeModule()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x11CB854", Offset = "0x11CB854", VA = "0x11CB854")]
		private void StopRaycastModule()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x11CCD00", Offset = "0x11CCD00", VA = "0x11CCD00")]
		private void InitRigidModule()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x11CCF1C", Offset = "0x11CCF1C", VA = "0x11CCF1C")]
		private void InitControllerModule()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x11CCC40", Offset = "0x11CCC40", VA = "0x11CCC40")]
		private void UninitRigidModule()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x11CCE5C", Offset = "0x11CCE5C", VA = "0x11CCE5C")]
		private void UninitControllerModule()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x11CC680", Offset = "0x11CC680", VA = "0x11CC680")]
		private bool Detect()
		{
			return default(bool);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x11CCAA0", Offset = "0x11CCAA0", VA = "0x11CCAA0")]
		private static Color32 GenerateColor()
		{
			return default(Color32);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x11CCB1C", Offset = "0x11CCB1C", VA = "0x11CCB1C")]
		private static bool ColorsSimilar(Color32 c1, Color32 c2, int tolerance)
		{
			return default(bool);
		}
	}
}
namespace CodeStage.AntiCheat.Common
{
	[Serializable]
	[Token(Token = "0x20000C2")]
	public struct ACTkByte16
	{
		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte b1;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte b2;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte b3;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte b4;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public byte b5;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public byte b6;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public byte b7;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		public byte b8;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte b9;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public byte b10;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public byte b11;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		public byte b12;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public byte b13;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public byte b14;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public byte b15;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		public byte b16;
	}
	[Serializable]
	[Token(Token = "0x20000C3")]
	public struct ACTkByte4
	{
		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte b1;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte b2;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte b3;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte b4;

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x11C2E88", Offset = "0x11C2E88", VA = "0x11C2E88")]
		public void Shuffle()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x11C2E9C", Offset = "0x11C2E9C", VA = "0x11C2E9C")]
		public void UnShuffle()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C4")]
	public struct ACTkByte8
	{
		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte b1;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte b2;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte b3;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte b4;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public byte b5;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
		public byte b6;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public byte b7;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
		public byte b8;

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x11C2EB0", Offset = "0x11C2EB0", VA = "0x11C2EB0")]
		public void Shuffle()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x11C2EDC", Offset = "0x11C2EDC", VA = "0x11C2EDC")]
		public void UnShuffle()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class ACTkConstants
	{
		[Token(Token = "0x4000655")]
		public const string Version = "1.6.7";

		[Token(Token = "0x4000656")]
		public const string LogPrefix = "[ACTk] ";

		[Token(Token = "0x4000657")]
		public const string DocsRootUrl = "http://codestage.net/uas_files/actk/api/";

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x11C2F08", Offset = "0x11C2F08", VA = "0x11C2F08")]
		public ACTkConstants()
		{
		}
	}
}
namespace CodeStage.AntiCheat.Examples
{
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95B888", Offset = "0x95B888")]
	public class ExamplesGUI : MonoBehaviour
	{
		[Token(Token = "0x2000109")]
		private enum ExamplePage
		{
			[Token(Token = "0x4000797")]
			ObscuredTypes,
			[Token(Token = "0x4000798")]
			ObscuredPrefs,
			[Token(Token = "0x4000799")]
			Detectors
		}

		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95B9E0", Offset = "0x95B9E0")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string types;

			[Token(Token = "0x6000816")]
			[Address(RVA = "0x11D6374", Offset = "0x11D6374", VA = "0x11D6374")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0x11D65C0", Offset = "0x11D65C0", VA = "0x11D65C0")]
			internal void <GetAllSimpleObscuredTypes>b__1(Type t)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x95B9F0", Offset = "0x95B9F0")]
		private sealed class <>c
		{
			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Type, bool> <>9__16_0;

			[Token(Token = "0x6000819")]
			[Address(RVA = "0x11D6504", Offset = "0x11D6504", VA = "0x11D6504")]
			public <>c()
			{
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0x11D650C", Offset = "0x11D650C", VA = "0x11D650C")]
			internal bool <GetAllSimpleObscuredTypes>b__16_0(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000658")]
		private const string RedColor = "#FF4040";

		[Token(Token = "0x4000659")]
		private const string YellowColor = "#E9D604";

		[Token(Token = "0x400065A")]
		private const string GreenColor = "#02C85F";

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x95CF18", Offset = "0x95CF18")]
		public ObscuredTypesExamples obscuredTypesExamples;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObscuredPrefsExamples obscuredPrefsExamples;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DetectorsExamples detectorsExamples;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string[] tabs;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ExamplePage currentPage;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string allSimpleObscuredTypes;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ObscuredPrefs.DeviceLockLevel savesLock;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GUIStyle centeredStyle;

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x11CDFD4", Offset = "0x11CDFD4", VA = "0x11CDFD4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x11CE328", Offset = "0x11CE328", VA = "0x11CE328")]
		private void DrawObscuredTypesPage()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x11D02F0", Offset = "0x11D02F0", VA = "0x11D02F0")]
		private void DrawObscuredPrefsPage()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x11D2C08", Offset = "0x11D2C08", VA = "0x11D2C08")]
		private void DrawDetectorsPage()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x11D49A4", Offset = "0x11D49A4", VA = "0x11D49A4")]
		private string GetAllSimpleObscuredTypes()
		{
			return null;
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x11D4BEC", Offset = "0x11D4BEC", VA = "0x11D4BEC")]
		private string GetAllObscuredPrefsDataTypes()
		{
			return null;
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x11D637C", Offset = "0x11D637C", VA = "0x11D637C")]
		public ExamplesGUI()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95B8C0", Offset = "0x95B8C0")]
	public class InfiniteRotator : MonoBehaviour
	{
		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x95CF50", Offset = "0x95CF50")]
		public float speed;

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x11D666C", Offset = "0x11D666C", VA = "0x11D666C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x11D66C4", Offset = "0x11D66C4", VA = "0x11D66C4")]
		public InfiniteRotator()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x95B8F8", Offset = "0x95B8F8")]
	public class ObscuredPerformanceTests : MonoBehaviour
	{
		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool boolTest;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int boolIterations;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool byteTest;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int byteIterations;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool shortTest;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int shortIterations;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool ushortTest;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int ushortIterations;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool intTest;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int intIterations;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool uintTest;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int uintIterations;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool longTest;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int longIterations;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool floatTest;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int floatIterations;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool doubleTest;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int doubleIterations;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool stringTest;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int stringIterations;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool vector3Test;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int vector3Iterations;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool prefsTest;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int prefsIterations;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly StringBuilder logBuilder;

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x11D66D4", Offset = "0x11D66D4", VA = "0x11D66D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x11D672C", Offset = "0x11D672C", VA = "0x11D672C")]
		private void StartTests()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x11D688C", Offset = "0x11D688C", VA = "0x11D688C")]
		private void TestBool()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x11D6B8C", Offset = "0x11D6B8C", VA = "0x11D6B8C")]
		private void TestByte()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x11D6E74", Offset = "0x11D6E74", VA = "0x11D6E74")]
		private void TestShort()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x11D716C", Offset = "0x11D716C", VA = "0x11D716C")]
		private void TestUShort()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x11D81AC", Offset = "0x11D81AC", VA = "0x11D81AC")]
		private void TestDouble()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x11D7E3C", Offset = "0x11D7E3C", VA = "0x11D7E3C")]
		private void TestFloat()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x11D7464", Offset = "0x11D7464", VA = "0x11D7464")]
		private void TestInt()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x11D7AEC", Offset = "0x11D7AEC", VA = "0x11D7AEC")]
		private void TestLong()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x11D8528", Offset = "0x11D8528", VA = "0x11D8528")]
		private void TestString()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x11D77A8", Offset = "0x11D77A8", VA = "0x11D77A8")]
		private void TestUInt()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x11D8888", Offset = "0x11D8888", VA = "0x11D8888")]
		private void TestVector3()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x11D8D00", Offset = "0x11D8D00", VA = "0x11D8D00")]
		private void TestPrefs()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x11D9188", Offset = "0x11D9188", VA = "0x11D9188")]
		public ObscuredPerformanceTests()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class DetectorsExamples : MonoBehaviour
	{
		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal bool injectionDetected;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		internal bool speedHackDetected;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		internal bool wrongTimeDetected;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		internal bool timeCheatingDetected;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal bool obscuredTypeCheatDetected;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		internal bool wallHackCheatDetected;

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x11CD830", Offset = "0x11CD830", VA = "0x11CD830")]
		public void OnSpeedHackDetected()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x11CD8A8", Offset = "0x11CD8A8", VA = "0x11CD8A8")]
		public void OnTimeCheatingDetected()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x11CD920", Offset = "0x11CD920", VA = "0x11CD920")]
		public void OnInjectionDetected()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x11CD998", Offset = "0x11CD998", VA = "0x11CD998")]
		public void OnInjectionDetectedWithCause(string cause)
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x11CDA34", Offset = "0x11CDA34", VA = "0x11CDA34")]
		public void OnObscuredTypeCheatingDetected()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x11CDAAC", Offset = "0x11CDAAC", VA = "0x11CDAAC")]
		public void OnWallHackDetected()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x11CDB24", Offset = "0x11CDB24", VA = "0x11CDB24")]
		public void OnTimeCheatChecked(TimeCheatingDetector.CheckResult checkResult, TimeCheatingDetector.ErrorKind errorKind)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x11CDD18", Offset = "0x11CDD18", VA = "0x11CDD18")]
		private void Start()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x11CDD1C", Offset = "0x11CDD1C", VA = "0x11CDD1C")]
		private void SpeedHackDetectorExample()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x11CDD20", Offset = "0x11CDD20", VA = "0x11CDD20")]
		private void InjectionDetectorExample()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x11CDD24", Offset = "0x11CDD24", VA = "0x11CDD24")]
		private void ObscuredCheatingDetectorExample()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x11CDD28", Offset = "0x11CDD28", VA = "0x11CDD28")]
		private void TimeCheatingDetectorExample()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x11CDE10", Offset = "0x11CDE10", VA = "0x11CDE10")]
		internal void ForceTimeCheatingDetectorCheck()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x11CDFCC", Offset = "0x11CDFCC", VA = "0x11CDFCC")]
		public DetectorsExamples()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class ObscuredPrefsExamples : MonoBehaviour
	{
		[Token(Token = "0x4000683")]
		private const string PrefsString = "name";

		[Token(Token = "0x4000684")]
		private const string PrefsInt = "money";

		[Token(Token = "0x4000685")]
		private const string PrefsFloat = "lifeBar";

		[Token(Token = "0x4000686")]
		private const string PrefsBool = "gameComplete";

		[Token(Token = "0x4000687")]
		private const string PrefsUint = "demoUint";

		[Token(Token = "0x4000688")]
		private const string PrefsLong = "demoLong";

		[Token(Token = "0x4000689")]
		private const string PrefsDouble = "demoDouble";

		[Token(Token = "0x400068A")]
		private const string PrefsVector2 = "demoVector2";

		[Token(Token = "0x400068B")]
		private const string PrefsVector3 = "demoVector3";

		[Token(Token = "0x400068C")]
		private const string PrefsQuaternion = "demoQuaternion";

		[Token(Token = "0x400068D")]
		private const string PrefsRect = "demoRect";

		[Token(Token = "0x400068E")]
		private const string PrefsColor = "demoColor";

		[Token(Token = "0x400068F")]
		private const string PrefsByteArray = "demoByteArray";

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string prefsEncryptionKey;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal string regularPrefs;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal string obscuredPrefs;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal bool savesAlterationDetected;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		internal bool foreignSavesDetected;

		[Token(Token = "0x1700007E")]
		internal bool PreservePlayerPrefs
		{
			[Token(Token = "0x600079E")]
			[Address(RVA = "0x11D9268", Offset = "0x11D9268", VA = "0x11D9268")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600079F")]
			[Address(RVA = "0x11D6224", Offset = "0x11D6224", VA = "0x11D6224")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		internal bool EmergencyMode
		{
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x11D92D0", Offset = "0x11D92D0", VA = "0x11D92D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x11D6294", Offset = "0x11D6294", VA = "0x11D6294")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		internal bool ReadForeignSaves
		{
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x11D9338", Offset = "0x11D9338", VA = "0x11D9338")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x11D6304", Offset = "0x11D6304", VA = "0x11D6304")]
			set
			{
			}
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x11D93A0", Offset = "0x11D93A0", VA = "0x11D93A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x11D94B8", Offset = "0x11D94B8", VA = "0x11D94B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x11D94CC", Offset = "0x11D94CC", VA = "0x11D94CC")]
		private void SavesAlterationDetected()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x11D94D8", Offset = "0x11D94D8", VA = "0x11D94D8")]
		private void ForeignSavesDetected()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x11D4C34", Offset = "0x11D4C34", VA = "0x11D4C34")]
		internal void LoadRegularPrefs()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x11D4E54", Offset = "0x11D4E54", VA = "0x11D4E54")]
		internal void SaveRegularPrefs()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x11D4EE8", Offset = "0x11D4EE8", VA = "0x11D4EE8")]
		internal void DeleteRegularPrefs()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x11D61B8", Offset = "0x11D61B8", VA = "0x11D61B8")]
		internal void LockObscuredPrefsToDevice(ObscuredPrefs.DeviceLockLevel level)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x11D4F64", Offset = "0x11D4F64", VA = "0x11D4F64")]
		internal void LoadObscuredPrefs()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x11D5D8C", Offset = "0x11D5D8C", VA = "0x11D5D8C")]
		internal void SaveObscuredPrefs()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x11D6054", Offset = "0x11D6054", VA = "0x11D6054")]
		internal void DeleteObscuredPrefs()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x11D94E4", Offset = "0x11D94E4", VA = "0x11D94E4")]
		public ObscuredPrefsExamples()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class ObscuredTypesExamples : MonoBehaviour
	{
		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x95CF6C", Offset = "0x95CF6C")]
		public string regularString;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int regularInt;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float regularFloat;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 regularVector3;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x95CFA4", Offset = "0x95CFA4")]
		public ObscuredString obscuredString;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ObscuredInt obscuredInt;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public ObscuredFloat obscuredFloat;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public ObscuredVector3 obscuredVector3;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public ObscuredBool obscuredBool;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public ObscuredLong obscuredLong;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public ObscuredDouble obscuredDouble;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public ObscuredVector2 obscuredVector2;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ObscuredDecimal obscuredDecimal;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public ObscuredVector2Int obscuredVector2Int;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public ObscuredVector3Int obscuredVector3Int;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private readonly StringBuilder logBuilder;

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x11D953C", Offset = "0x11D953C", VA = "0x11D953C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x11D9BFC", Offset = "0x11D9BFC", VA = "0x11D9BFC")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x11D9F50", Offset = "0x11D9F50", VA = "0x11D9F50")]
		private void RandomizeObscuredVars()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x11D9560", Offset = "0x11D9560", VA = "0x11D9560")]
		private void ObscuredStringExample()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x11D9724", Offset = "0x11D9724", VA = "0x11D9724")]
		private void ObscuredIntExample()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x11D9FEC", Offset = "0x11D9FEC", VA = "0x11D9FEC")]
		public ObscuredTypesExamples()
		{
		}
	}
}
