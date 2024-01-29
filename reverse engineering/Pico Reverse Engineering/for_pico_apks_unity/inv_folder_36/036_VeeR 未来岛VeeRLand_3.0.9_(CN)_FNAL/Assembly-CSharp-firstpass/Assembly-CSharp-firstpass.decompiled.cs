using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

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
	[Token(Token = "0x2000004")]
	public delegate void LogCallbackDelegate(string condition, string stackTrace, LogType type);

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string GAME_AGENT_CLASS;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int TYPE_U3D_CRASH;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int GAME_TYPE_UNITY;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x10")]
	private static bool hasSetGameType;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x18")]
	private static AndroidJavaClass _gameAgentClass;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x20")]
	private static string _configChannel;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x28")]
	private static string _configVersion;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x30")]
	private static string _configUser;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x38")]
	private static long _configDelayTime;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x40")]
	private static bool _configCrashReporterPackage;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x50")]
	private static bool _isInitialized;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x54")]
	private static LogSeverity _autoReportLogLevel;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x58")]
	private static int _crashReporterType;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x60")]
	private static string _crashReporterPackage;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x68")]
	private static bool _debugMode;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x69")]
	private static bool _autoQuitApplicationAfterReport;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x6C")]
	private static readonly int EXCEPTION_TYPE_UNCAUGHT;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x70")]
	private static readonly int EXCEPTION_TYPE_CAUGHT;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x78")]
	private static readonly string _pluginVersion;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x80")]
	private static Func<Dictionary<string, string>> _LogCallbackExtrasHandler;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x88")]
	private static bool _uncaughtAutoReportOnce;

	[Token(Token = "0x17000001")]
	public static AndroidJavaClass GameAgent
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1FB0FFC", Offset = "0x1FB0FFC", VA = "0x1FB0FFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public static string PluginVersion
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1FB18C8", Offset = "0x1FB18C8", VA = "0x1FB18C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public static bool IsInitialized
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1FB1920", Offset = "0x1FB1920", VA = "0x1FB1920")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000004")]
	public static bool AutoQuitApplicationAfterReport
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1FB1978", Offset = "0x1FB1978", VA = "0x1FB1978")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000001")]
	private static event LogCallbackDelegate _LogCallbackEventHandler
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1FAE5E0", Offset = "0x1FAE5E0", VA = "0x1FAE5E0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1FAFC38", Offset = "0x1FAFC38", VA = "0x1FAFC38")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1FADA0C", Offset = "0x1FADA0C", VA = "0x1FADA0C")]
	public static void ConfigCrashReporter(int type, int logLevel)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1FADB08", Offset = "0x1FADB08", VA = "0x1FADB08")]
	public static void InitWithAppId(string appId)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1FAE398", Offset = "0x1FAE398", VA = "0x1FAE398")]
	public static void EnableExceptionHandler()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1FAE4E4", Offset = "0x1FAE4E4", VA = "0x1FAE4E4")]
	public static void RegisterLogCallback(LogCallbackDelegate handler)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1FAE6BC", Offset = "0x1FAE6BC", VA = "0x1FAE6BC")]
	public static void SetLogCallbackExtrasHandler(Func<Dictionary<string, string>> handler)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1FAE7B8", Offset = "0x1FAE7B8", VA = "0x1FAE7B8")]
	public static void ReportException(Exception e, string message)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1FAEF44", Offset = "0x1FAEF44", VA = "0x1FAEF44")]
	public static void ReportException(string name, string message, string stackTrace)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1FAFB58", Offset = "0x1FAFB58", VA = "0x1FAFB58")]
	public static void UnregisterLogCallback(LogCallbackDelegate handler)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1FAFD14", Offset = "0x1FAFD14", VA = "0x1FAFD14")]
	public static void SetUserId(string userId)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1FAFFE8", Offset = "0x1FAFFE8", VA = "0x1FAFFE8")]
	public static void SetScene(int sceneId)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1FB030C", Offset = "0x1FB030C", VA = "0x1FB030C")]
	public static void AddSceneData(string key, string value)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1FB0674", Offset = "0x1FB0674", VA = "0x1FB0674")]
	public static void ConfigDebugMode(bool enable)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1FB0968", Offset = "0x1FB0968", VA = "0x1FB0968")]
	public static void ConfigAutoQuitApplication(bool autoQuit)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1FB09C4", Offset = "0x1FB09C4", VA = "0x1FB09C4")]
	public static void ConfigAutoReportLogLevel(LogSeverity level)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1FB0A20", Offset = "0x1FB0A20", VA = "0x1FB0A20")]
	public static void ConfigDefault(string channel, string version, string user, long delay)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1FADCF0", Offset = "0x1FADCF0", VA = "0x1FADCF0")]
	public static void DebugLog(string tag, string format, params object[] args)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1FB0CB0", Offset = "0x1FB0CB0", VA = "0x1FB0CB0")]
	public static void PrintLog(LogSeverity level, string format, params object[] args)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1FB0BFC", Offset = "0x1FB0BFC", VA = "0x1FB0BFC")]
	private static void ConfigDefaultBeforeInit(string channel, string version, string user, long delay)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1FB11E8", Offset = "0x1FB11E8", VA = "0x1FB11E8")]
	private static void ConfigCrashReporterPackage()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1FADDE0", Offset = "0x1FADDE0", VA = "0x1FADDE0")]
	private static void InitBuglyAgent(string appId)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1FB07A8", Offset = "0x1FB07A8", VA = "0x1FB07A8")]
	private static void EnableDebugMode(bool enable)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1FAFE60", Offset = "0x1FAFE60", VA = "0x1FAFE60")]
	private static void SetUserInfo(string userInfo)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1FB139C", Offset = "0x1FB139C", VA = "0x1FB139C")]
	private static void ReportException(int type, string name, string reason, string stackTrace, bool quitProgram)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1FB0158", Offset = "0x1FB0158", VA = "0x1FB0158")]
	private static void SetCurrentScene(int sceneId)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1FB16C4", Offset = "0x1FB16C4", VA = "0x1FB16C4")]
	private static void SetUnityVersion()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1FB0494", Offset = "0x1FB0494", VA = "0x1FB0494")]
	private static void AddKeyAndValueInScene(string key, string value)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1FB18C4", Offset = "0x1FB18C4", VA = "0x1FB18C4")]
	private static void AddExtraDataWithException(string key, string value)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1FB0D50", Offset = "0x1FB0D50", VA = "0x1FB0D50")]
	private static void LogRecord(LogSeverity level, string message)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1FADA60", Offset = "0x1FADA60", VA = "0x1FADA60")]
	private static void _SetCrashReporterType(int type)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1FADB04", Offset = "0x1FADB04", VA = "0x1FADB04")]
	private static void _SetCrashReporterLogLevel(int logLevel)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1FAE140", Offset = "0x1FAE140", VA = "0x1FAE140")]
	private static void _RegisterExceptionHandler()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1FB19D0", Offset = "0x1FB19D0", VA = "0x1FB19D0")]
	private static void _UnregisterExceptionHandler()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1FB1C0C", Offset = "0x1FB1C0C", VA = "0x1FB1C0C")]
	private static void _OnLogCallbackHandler(string condition, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1FB1DA8", Offset = "0x1FB1DA8", VA = "0x1FB1DA8")]
	private static void _OnUncaughtExceptionHandler(object sender, UnhandledExceptionEventArgs args)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1FAE944", Offset = "0x1FAE944", VA = "0x1FAE944")]
	private static void _HandleException(Exception e, string message, bool uncaught)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1FB200C", Offset = "0x1FB200C", VA = "0x1FB200C")]
	private static void _reportException(bool uncaught, string name, string reason, string stackTrace)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1FAF11C", Offset = "0x1FAF11C", VA = "0x1FAF11C")]
	private static void _HandleException(LogSeverity logLevel, string name, string message, string stackTrace, bool uncaught)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1FB2744", Offset = "0x1FB2744", VA = "0x1FB2744")]
	public BuglyAgent()
	{
	}
}
[Token(Token = "0x2000005")]
public abstract class BuglyCallback
{
	[Token(Token = "0x6000032")]
	public abstract void OnApplicationLogCallbackHandler(string condition, string stackTrace, LogType type);

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1FB2A08", Offset = "0x1FB2A08", VA = "0x1FB2A08")]
	protected BuglyCallback()
	{
	}
}
[Token(Token = "0x2000006")]
public class BuglyInit : MonoBehaviour
{
	[Token(Token = "0x400001F")]
	private const string BuglyAppID = "YOUR APP ID GOES HERE";

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1FB2A10", Offset = "0x1FB2A10", VA = "0x1FB2A10")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1FB2BA4", Offset = "0x1FB2BA4", VA = "0x1FB2BA4")]
	private static Dictionary<string, string> MyLogCallbackExtrasHandler()
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1FB3120", Offset = "0x1FB3120", VA = "0x1FB3120")]
	public BuglyInit()
	{
	}
}
