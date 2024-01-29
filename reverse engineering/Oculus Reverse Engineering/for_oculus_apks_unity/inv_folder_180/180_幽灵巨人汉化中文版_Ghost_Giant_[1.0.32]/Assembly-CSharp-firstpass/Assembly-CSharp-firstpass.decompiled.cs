using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using Crosstales.Common.Model.Enum;
using Crosstales.Common.Util;
using Crosstales.RTVoice.Model;
using Crosstales.RTVoice.Model.Enum;
using Crosstales.RTVoice.Provider;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Crosstales
{
	[Token(Token = "0x2000002")]
	public static class ExtensionMethods
	{
		[Token(Token = "0x2000158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B7C0", Offset = "0x29B7C0")]
		private sealed class <CTContainsAny>c__AnonStorey0
		{
			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string str;

			[Token(Token = "0x6000999")]
			[Address(RVA = "0x938F08", Offset = "0x938F08", VA = "0x938F08")]
			public <CTContainsAny>c__AnonStorey0()
			{
			}

			[Token(Token = "0x600099A")]
			[Address(RVA = "0x93924C", Offset = "0x93924C", VA = "0x93924C")]
			internal bool <>m__0(string searchTerm)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B7D0", Offset = "0x29B7D0")]
		private sealed class <CTContainsAll>c__AnonStorey1
		{
			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string str;

			[Token(Token = "0x600099B")]
			[Address(RVA = "0x93912C", Offset = "0x93912C", VA = "0x93912C")]
			public <CTContainsAll>c__AnonStorey1()
			{
			}

			[Token(Token = "0x600099C")]
			[Address(RVA = "0x9391B4", Offset = "0x9391B4", VA = "0x9391B4")]
			internal bool <>m__0(string searchTerm)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly System.Random rd;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x938B34", Offset = "0x938B34", VA = "0x938B34")]
		public static string CTToTitleCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x93576C", Offset = "0x93576C", VA = "0x93576C")]
		public static string CTReplace(this string str, string oldString, string newString, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x937008", Offset = "0x937008", VA = "0x937008")]
		public static bool CTEquals(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x938C18", Offset = "0x938C18", VA = "0x938C18")]
		public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x938CEC", Offset = "0x938CEC", VA = "0x938CEC")]
		public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x938F10", Offset = "0x938F10", VA = "0x938F10")]
		public static bool CTContainsAll(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		public static void CTShuffle<T>(this T[] array)
		{
		}

		[Token(Token = "0x6000008")]
		public static string CTDump<T>(this T[] array)
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		public static string[] CTToString<T>(this T[] array)
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		public static void CTShuffle<T>(this IList<T> list)
		{
		}

		[Token(Token = "0x600000B")]
		public static string CTDump<T>(this List<T> list)
		{
			return null;
		}

		[Token(Token = "0x600000C")]
		public static List<string> CTToString<T>(this List<T> list)
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		public static void CTAddRange<T, S>(this Dictionary<T, S> source, Dictionary<T, S> collection)
		{
		}
	}
}
namespace Crosstales.Common.Model.Enum
{
	[Token(Token = "0x2000003")]
	public enum Platform
	{
		[Token(Token = "0x4000003")]
		Windows,
		[Token(Token = "0x4000004")]
		OSX,
		[Token(Token = "0x4000005")]
		Linux,
		[Token(Token = "0x4000006")]
		IOS,
		[Token(Token = "0x4000007")]
		Android,
		[Token(Token = "0x4000008")]
		WSA,
		[Token(Token = "0x4000009")]
		Web,
		[Token(Token = "0x400000A")]
		Unsupported,
		[Token(Token = "0x400000B")]
		MaryTTS
	}
}
namespace Crosstales.Common.Util
{
	[Token(Token = "0x2000004")]
	public class BackgroundController : MonoBehaviour
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29B7E0", Offset = "0x29B7E0")]
		public GameObject[] Objects;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool isFocused;

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x933BD4", Offset = "0x933BD4", VA = "0x933BD4")]
		public BackgroundController()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x933BDC", Offset = "0x933BDC", VA = "0x933BDC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x933BFC", Offset = "0x933BFC", VA = "0x933BFC")]
		public void FixedUpdate()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public abstract class BaseConstants
	{
		[Token(Token = "0x400000E")]
		public const string ASSET_AUTHOR = "crosstales LLC";

		[Token(Token = "0x400000F")]
		public const string ASSET_AUTHOR_URL = "https://www.crosstales.com";

		[Token(Token = "0x4000010")]
		public const string ASSET_CT_URL = "https://www.assetstore.unity3d.com/#!/list/42213-crosstales?aid=1011lNGT";

		[Token(Token = "0x4000011")]
		public const string ASSET_SOCIAL_FACEBOOK = "https://www.facebook.com/crosstales/";

		[Token(Token = "0x4000012")]
		public const string ASSET_SOCIAL_TWITTER = "https://twitter.com/crosstales";

		[Token(Token = "0x4000013")]
		public const string ASSET_SOCIAL_YOUTUBE = "https://www.youtube.com/c/Crosstales";

		[Token(Token = "0x4000014")]
		public const string ASSET_SOCIAL_LINKEDIN = "https://www.linkedin.com/company/crosstales";

		[Token(Token = "0x4000015")]
		public const string ASSET_SOCIAL_XING = "https://www.xing.com/companies/crosstales";

		[Token(Token = "0x4000016")]
		public const string ASSET_3P_PLAYMAKER = "https://www.assetstore.unity3d.com/#!/content/368?aid=1011lNGT";

		[Token(Token = "0x4000017")]
		public const int FACTOR_KB = 1024;

		[Token(Token = "0x4000018")]
		public const int FACTOR_MB = 1048576;

		[Token(Token = "0x4000019")]
		public const int FACTOR_GB = 1073741824;

		[Token(Token = "0x400001A")]
		public const float FLOAT_32768 = 32768f;

		[Token(Token = "0x400001B")]
		public const string FORMAT_TWO_DECIMAL_PLACES = "0.00";

		[Token(Token = "0x400001C")]
		public const string FORMAT_NO_DECIMAL_PLACES = "0";

		[Token(Token = "0x400001D")]
		public const string FORMAT_PERCENT = "0%";

		[Token(Token = "0x400001E")]
		public const bool DEFAULT_DEBUG = false;

		[Token(Token = "0x400001F")]
		public const string PATH_DELIMITER_WINDOWS = "\\";

		[Token(Token = "0x4000020")]
		public const string PATH_DELIMITER_UNIX = "/";

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DEV_DEBUG;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static string TEXT_TOSTRING_END;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string TEXT_TOSTRING_DELIMITER;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static string TEXT_TOSTRING_DELIMITER_END;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string TEXT_TOSTRING_START;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static string PREFIX_HTTP;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string PREFIX_HTTPS;

		[Token(Token = "0x17000001")]
		public static string PREFIX_FILE
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x933EE8", Offset = "0x933EE8", VA = "0x933EE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x933EE0", Offset = "0x933EE0", VA = "0x933EE0")]
		protected BaseConstants()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public abstract class BaseHelper
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Regex lineEndingsRegex;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly Regex cleanSpacesRegex;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Regex cleanTagsRegex;

		[Token(Token = "0x400002B")]
		private const string file_prefix = "file://";

		[Token(Token = "0x17000002")]
		public static bool isInternetAvailable
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x9340CC", Offset = "0x9340CC", VA = "0x9340CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000003")]
		public static bool isWindowsPlatform
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x933F80", Offset = "0x933F80", VA = "0x933F80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000004")]
		public static bool isMacOSPlatform
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x9340EC", Offset = "0x9340EC", VA = "0x9340EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000005")]
		public static bool isLinuxPlatform
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x934130", Offset = "0x934130", VA = "0x934130")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000006")]
		public static bool isStandalonePlatform
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x934174", Offset = "0x934174", VA = "0x934174")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000007")]
		public static bool isAndroidPlatform
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x933E74", Offset = "0x933E74", VA = "0x933E74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public static bool isIOSPlatform
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x933E9C", Offset = "0x933E9C", VA = "0x933E9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public static bool isWSAPlatform
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x934268", Offset = "0x934268", VA = "0x934268")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		public static bool isWebGLPlatform
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x9342D4", Offset = "0x9342D4", VA = "0x9342D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public static bool isWebPlayerPlatform
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x9342FC", Offset = "0x9342FC", VA = "0x9342FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		public static bool isWebPlatform
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x934304", Offset = "0x934304", VA = "0x934304")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		public static bool isWindowsBasedPlatform
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x9343C0", Offset = "0x9343C0", VA = "0x9343C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		public static bool isAppleBasedPlatform
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x934478", Offset = "0x934478", VA = "0x934478")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		public static bool isEditor
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x934530", Offset = "0x934530", VA = "0x934530")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		public static bool isEditorMode
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x934588", Offset = "0x934588", VA = "0x934588")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000011")]
		public static Platform CurrentPlatform
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x934620", Offset = "0x934620", VA = "0x934620")]
			get
			{
				return default(Platform);
			}
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x9340C4", Offset = "0x9340C4", VA = "0x9340C4")]
		protected BaseHelper()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x934830", Offset = "0x934830", VA = "0x934830")]
		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x934AF0", Offset = "0x934AF0", VA = "0x934AF0")]
		public static string ValidatePath(string path, bool addEndDelimiter = true)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x934DC0", Offset = "0x934DC0", VA = "0x934DC0")]
		public static string ValidateFile(string path)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x9350F8", Offset = "0x9350F8", VA = "0x9350F8")]
		public static string ValidURLFromFilePath(string path)
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x935510", Offset = "0x935510", VA = "0x935510")]
		public static string CleanUrl(string url, bool removeProtocol = true, bool removeWWW = true, bool removeSlash = true)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x93581C", Offset = "0x93581C", VA = "0x93581C")]
		public static string ClearTags(string text)
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x93592C", Offset = "0x93592C", VA = "0x93592C")]
		public static string ClearSpaces(string text)
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x935A04", Offset = "0x935A04", VA = "0x935A04")]
		public static string ClearLineEndings(string text)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x935B14", Offset = "0x935B14", VA = "0x935B14")]
		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true, int skipHeaderLines = 0, int skipFooterLines = 0)
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x935EE0", Offset = "0x935EE0", VA = "0x935EE0")]
		public static string FormatBytesToHRF(long bytes)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x936270", Offset = "0x936270", VA = "0x936270")]
		public static string FormatSecondsToHourMinSec(double seconds)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x936B7C", Offset = "0x936B7C", VA = "0x936B7C")]
		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x93536C", Offset = "0x93536C", VA = "0x93536C")]
		public static bool isValidURL(string url)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000007")]
	public static class CTPlayerPrefs
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x936E6C", Offset = "0x936E6C", VA = "0x936E6C")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x936E78", Offset = "0x936E78", VA = "0x936E78")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x936E84", Offset = "0x936E84", VA = "0x936E84")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x936E90", Offset = "0x936E90", VA = "0x936E90")]
		public static void Save()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x936E9C", Offset = "0x936E9C", VA = "0x936E9C")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x936EA8", Offset = "0x936EA8", VA = "0x936EA8")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x936EB4", Offset = "0x936EB4", VA = "0x936EB4")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x936EC0", Offset = "0x936EC0", VA = "0x936EC0")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x9370CC", Offset = "0x9370CC", VA = "0x9370CC")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x9370D8", Offset = "0x9370D8", VA = "0x9370D8")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x9370E4", Offset = "0x9370E4", VA = "0x9370E4")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x9370F0", Offset = "0x9370F0", VA = "0x9370F0")]
		public static void SetBool(string key, bool value)
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class CTWebClient : WebClient
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B814", Offset = "0x29B814")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x29B814", Offset = "0x29B814")]
		private int <Timeout>k__BackingField;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B848", Offset = "0x29B848")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x29B848", Offset = "0x29B848")]
		private int <ConnectionLimit>k__BackingField;

		[Token(Token = "0x17000012")]
		public int Timeout
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x9372B8", Offset = "0x9372B8", VA = "0x9372B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B87C", Offset = "0x29B87C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x9372A8", Offset = "0x9372A8", VA = "0x9372A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B88C", Offset = "0x29B88C")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public int ConnectionLimit
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x9372C0", Offset = "0x9372C0", VA = "0x9372C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B89C", Offset = "0x29B89C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x9372B0", Offset = "0x9372B0", VA = "0x9372B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29B8AC", Offset = "0x29B8AC")]
			set
			{
			}
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x937208", Offset = "0x937208", VA = "0x937208")]
		public CTWebClient()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x937214", Offset = "0x937214", VA = "0x937214")]
		public CTWebClient(int timeout, int connectionLimit = 20)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x9372C8", Offset = "0x9372C8", VA = "0x9372C8")]
		public WebRequest CTGetWebRequest(string uri)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x937354", Offset = "0x937354", VA = "0x937354", Slot = "12")]
		protected override WebRequest GetWebRequest(Uri uri)
		{
			return null;
		}
	}
}
namespace Crosstales.DJ.Demo.Util
{
	[Token(Token = "0x2000009")]
	public class FFTAnalyzer : MonoBehaviour
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float[] Samples;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Channel;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public FFTWindow FFTMode;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x938318", Offset = "0x938318", VA = "0x938318")]
		public FFTAnalyzer()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x9383A0", Offset = "0x9383A0", VA = "0x9383A0")]
		public void Update()
		{
		}
	}
}
namespace Crosstales.Common.Util
{
	[Token(Token = "0x200000A")]
	public class PlatformController : MonoBehaviour
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29B8BC", Offset = "0x29B8BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29B8BC", Offset = "0x29B8BC")]
		public List<Platform> Platforms;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29B91C", Offset = "0x29B91C")]
		public bool Active;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29B950", Offset = "0x29B950")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29B950", Offset = "0x29B950")]
		public GameObject[] Objects;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Platform currentPlatform;

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x937510", Offset = "0x937510", VA = "0x937510")]
		public PlatformController()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x937520", Offset = "0x937520", VA = "0x937520", Slot = "4")]
		public virtual void Start()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x937524", Offset = "0x937524", VA = "0x937524")]
		protected void selectPlatform()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x9375AC", Offset = "0x9375AC", VA = "0x9375AC")]
		protected void activateGO()
		{
		}
	}
	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x29B9B0", Offset = "0x29B9B0")]
	public class RandomColor : MonoBehaviour
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29BA28", Offset = "0x29BA28")]
		public float Saturation;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29BA40", Offset = "0x29BA40")]
		public float Value;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29BA58", Offset = "0x29BA58")]
		public float Opacity;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool ChangeMaterial;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Material Material;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 ColorRange;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool GrayScale;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float elapsedTime;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float changeTime;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Renderer currentRenderer;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color32 startColor;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color32 endColor;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lerpProgress;

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x9376EC", Offset = "0x9376EC", VA = "0x9376EC")]
		public RandomColor()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x937780", Offset = "0x937780", VA = "0x937780")]
		public void Start()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x9378B0", Offset = "0x9378B0", VA = "0x9378B0")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class RandomRotator : MonoBehaviour
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 Speed;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform tf;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 speed;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float elapsedTime;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float changeTime;

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x937C8C", Offset = "0x937C8C", VA = "0x937C8C")]
		public RandomRotator()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x937D20", Offset = "0x937D20", VA = "0x937D20")]
		public void Start()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x937D58", Offset = "0x937D58", VA = "0x937D58")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class RandomScaler : MonoBehaviour
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 ScaleMin;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 ScaleMax;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool Uniform;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform tf;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 endScale;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float elapsedTime;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float changeTime;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 startScale;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lerpTime;

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x937F08", Offset = "0x937F08", VA = "0x937F08")]
		public RandomScaler()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x937FDC", Offset = "0x937FDC", VA = "0x937FDC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x938048", Offset = "0x938048", VA = "0x938048")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class SerializeDeSerialize<T>
	{
		[Token(Token = "0x17000014")]
		private BinaryFormatter binaryFormatter
		{
			[Token(Token = "0x6000058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000057")]
		public SerializeDeSerialize()
		{
		}

		[Token(Token = "0x6000059")]
		public void ToFile(T o, string path)
		{
		}

		[Token(Token = "0x600005A")]
		public MemoryStream ToMemory(T o)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		public byte[] ToByteArray(T o)
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		public T FromFile(string path)
		{
			return (T)null;
		}

		[Token(Token = "0x600005D")]
		public T FromMemory(byte[] data)
		{
			return (T)null;
		}
	}
}
namespace Crosstales.DJ.Demo.Util
{
	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29BA70", Offset = "0x29BA70")]
	public class SpectrumVisualizer : MonoBehaviour
	{
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FFTAnalyzer Analyzer;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject VisualPrefab;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Width;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Gain;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool LeftToRight;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29BAA4", Offset = "0x29BAA4")]
		public float Opacity;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Transform tf;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform[] visualTransforms;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 visualPos;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int samplesPerChannel;

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x9383CC", Offset = "0x9383CC", VA = "0x9383CC")]
		public SpectrumVisualizer()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x93849C", Offset = "0x93849C", VA = "0x93849C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x938A14", Offset = "0x938A14", VA = "0x938A14")]
		public void Update()
		{
		}
	}
}
namespace Crosstales.UI
{
	[Token(Token = "0x2000010")]
	public class Social : MonoBehaviour
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x824218", Offset = "0x824218", VA = "0x824218")]
		public Social()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x824220", Offset = "0x824220", VA = "0x824220")]
		public void Facebook()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x824284", Offset = "0x824284", VA = "0x824284")]
		public void Twitter()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x8242E8", Offset = "0x8242E8", VA = "0x8242E8")]
		public void LinkedIn()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x82434C", Offset = "0x82434C", VA = "0x82434C")]
		public void Xing()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x8243B0", Offset = "0x8243B0", VA = "0x8243B0")]
		public void Youtube()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class StaticManager : MonoBehaviour
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x824414", Offset = "0x824414", VA = "0x824414")]
		public StaticManager()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x82441C", Offset = "0x82441C", VA = "0x82441C")]
		public void Quit()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x824428", Offset = "0x824428", VA = "0x824428")]
		public void OpenCrosstales()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x82448C", Offset = "0x82448C", VA = "0x82448C")]
		public void OpenAssetstore()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class UIDrag : MonoBehaviour
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private float offsetX;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float offsetY;

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x8244F0", Offset = "0x8244F0", VA = "0x8244F0")]
		public UIDrag()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x8244F8", Offset = "0x8244F8", VA = "0x8244F8")]
		public void BeginDrag()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x824618", Offset = "0x824618", VA = "0x824618")]
		public void OnDrag()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class UIFocus : MonoBehaviour
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string CanvasName;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UIWindowManager manager;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Image image;

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x824730", Offset = "0x824730", VA = "0x824730")]
		public UIFocus()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x82479C", Offset = "0x82479C", VA = "0x82479C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x824888", Offset = "0x824888", VA = "0x824888")]
		public void OnPanelEnter()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class UIHint : MonoBehaviour
	{
		[Token(Token = "0x200015A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29BB9C", Offset = "0x29BB9C")]
		private sealed class <fadeTo>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float delay;

			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal float <alpha>__0;

			[Token(Token = "0x400094E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal float <t>__1;

			[Token(Token = "0x400094F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal float aValue;

			[Token(Token = "0x4000950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal float aTime;

			[Token(Token = "0x4000951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal bool destroy;

			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal UIHint $this;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal object $current;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal bool $disposing;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal int $PC;

			[Token(Token = "0x170000F6")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x600099F")]
				[Address(RVA = "0x825088", Offset = "0x825088", VA = "0x825088", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009A0")]
				[Address(RVA = "0x825090", Offset = "0x825090", VA = "0x825090", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600099D")]
			[Address(RVA = "0x824E0C", Offset = "0x824E0C", VA = "0x824E0C")]
			[DebuggerHidden]
			public <fadeTo>c__Iterator0()
			{
			}

			[Token(Token = "0x600099E")]
			[Address(RVA = "0x824E14", Offset = "0x824E14", VA = "0x824E14", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x825098", Offset = "0x825098", VA = "0x825098", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x8250AC", Offset = "0x8250AC", VA = "0x8250AC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BABC", Offset = "0x29BABC")]
		public CanvasGroup Group;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BAF0", Offset = "0x29BAF0")]
		public float Delay;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BB24", Offset = "0x29BB24")]
		public float FadeTime;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BB58", Offset = "0x29BB58")]
		public bool DestroyWhenFinished;

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x824CC4", Offset = "0x824CC4", VA = "0x824CC4")]
		public UIHint()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x824CE0", Offset = "0x824CE0", VA = "0x824CE0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x824D24", Offset = "0x824D24", VA = "0x824D24")]
		[DebuggerHidden]
		private IEnumerator fadeTo(float aValue, float delay, float aTime, bool destroy)
		{
			return null;
		}
	}
	[Token(Token = "0x2000015")]
	public class UIResize : MonoBehaviour, IPointerDownHandler, IDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BBFC", Offset = "0x29BBFC")]
		public Vector2 MinSize;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BC30", Offset = "0x29BC30")]
		public Vector2 MaxSize;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private RectTransform panelRectTransform;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector2 originalLocalPointerPosition;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector2 originalSizeDelta;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector2 originalSize;

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x825130", Offset = "0x825130", VA = "0x825130")]
		public UIResize()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x8251BC", Offset = "0x8251BC", VA = "0x8251BC")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x825330", Offset = "0x825330", VA = "0x825330", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x825450", Offset = "0x825450", VA = "0x825450", Slot = "5")]
		public void OnDrag(PointerEventData data)
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class UIWindowManager : MonoBehaviour
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BC64", Offset = "0x29BC64")]
		public GameObject[] Windows;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Image image;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private GameObject DontTouch;

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x8256FC", Offset = "0x8256FC", VA = "0x8256FC")]
		public UIWindowManager()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x825704", Offset = "0x825704", VA = "0x825704")]
		public void Start()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x8249E0", Offset = "0x8249E0", VA = "0x8249E0")]
		public void ChangeState(GameObject x)
		{
		}
	}
}
namespace Crosstales.UI.Util
{
	[Token(Token = "0x2000017")]
	public class AudioFilterController : MonoBehaviour
	{
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29BC98", Offset = "0x29BC98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BC98", Offset = "0x29BC98")]
		public bool FindAllAudioFiltersOnStart;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioReverbFilter[] ReverbFilters;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AudioChorusFilter[] ChorusFilters;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioEchoFilter[] EchoFilters;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AudioDistortionFilter[] DistortionFilters;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioLowPassFilter[] LowPassFilters;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public AudioHighPassFilter[] HighPassFilters;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29BCF8", Offset = "0x29BCF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BCF8", Offset = "0x29BCF8")]
		public bool ResetAudioFiltersOnStart;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool ChorusFilter;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool EchoFilter;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool DistortionFilter;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float DistortionFilterValue;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool LowpassFilter;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float LowpassFilterValue;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool HighpassFilter;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float HighpassFilterValue;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29BD58", Offset = "0x29BD58")]
		public Dropdown ReverbFilterDropdown;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Text DistortionText;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Text LowpassText;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Text HighpassText;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<AudioReverbPreset> reverbPresets;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initalized;

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x8258A0", Offset = "0x8258A0", VA = "0x8258A0")]
		public AudioFilterController()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x825950", Offset = "0x825950", VA = "0x825950")]
		public void Start()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x825E88", Offset = "0x825E88", VA = "0x825E88")]
		public void Update()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x825F04", Offset = "0x825F04", VA = "0x825F04")]
		public void FindAllAudioFilters()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x826148", Offset = "0x826148", VA = "0x826148")]
		public void ResetAudioFilters()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x8261C0", Offset = "0x8261C0", VA = "0x8261C0")]
		public void ReverbFilterDropdownChanged(int index)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x8262A8", Offset = "0x8262A8", VA = "0x8262A8")]
		public void ChorusFilterEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x82631C", Offset = "0x82631C", VA = "0x82631C")]
		public void EchoFilterEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x826390", Offset = "0x826390", VA = "0x826390")]
		public void DistortionFilterEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x826404", Offset = "0x826404", VA = "0x826404")]
		public void DistortionFilterChanged(float value)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x826558", Offset = "0x826558", VA = "0x826558")]
		public void LowPassFilterEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x8265CC", Offset = "0x8265CC", VA = "0x8265CC")]
		public void LowPassFilterChanged(float value)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x826720", Offset = "0x826720", VA = "0x826720")]
		public void HighPassFilterEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x826794", Offset = "0x826794", VA = "0x826794")]
		public void HighPassFilterChanged(float value)
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class AudioSourceController : MonoBehaviour
	{
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29BD8C", Offset = "0x29BD8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BD8C", Offset = "0x29BD8C")]
		public bool FindAllAudioSourcesOnStart;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BDEC", Offset = "0x29BDEC")]
		public AudioSource[] AudioSources;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29BE20", Offset = "0x29BE20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BE20", Offset = "0x29BE20")]
		public bool ResetAudioSourcesOnStart;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BE80", Offset = "0x29BE80")]
		public bool Mute;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BEB4", Offset = "0x29BEB4")]
		public bool Loop;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BEE8", Offset = "0x29BEE8")]
		public float Volume;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BF1C", Offset = "0x29BF1C")]
		public float Pitch;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BF50", Offset = "0x29BF50")]
		public float StereoPan;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29BF84", Offset = "0x29BF84")]
		public Text VolumeText;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text PitchText;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Text StereoPanText;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool initalized;

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x8268E8", Offset = "0x8268E8", VA = "0x8268E8")]
		public AudioSourceController()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x826908", Offset = "0x826908", VA = "0x826908")]
		public void Update()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x826984", Offset = "0x826984", VA = "0x826984")]
		public void FindAllAudioSources()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x826A74", Offset = "0x826A74", VA = "0x826A74")]
		public void ResetAudioFilters()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x826ABC", Offset = "0x826ABC", VA = "0x826ABC")]
		public void MuteEnabled(bool enabled)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x826B30", Offset = "0x826B30", VA = "0x826B30")]
		public void LoopEnabled(bool enabled)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x826BA4", Offset = "0x826BA4", VA = "0x826BA4")]
		public void VolumeChanged(float value)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x826CF8", Offset = "0x826CF8", VA = "0x826CF8")]
		public void PitchChanged(float value)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x826E4C", Offset = "0x826E4C", VA = "0x826E4C")]
		public void StereoPanChanged(float value)
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class FPSDisplay : MonoBehaviour
	{
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Text FPS;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float deltaTime;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float elapsedTime;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float msec;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float fps;

		[Token(Token = "0x4000096")]
		private const string wait = "<i>...calculating <b>FPS</b>...</i>";

		[Token(Token = "0x4000097")]
		private const string red = "<color=#E57373><b>FPS: {0:0.}</b> ({1:0.0} ms)</color>";

		[Token(Token = "0x4000098")]
		private const string orange = "<color=#FFB74D><b>FPS: {0:0.}</b> ({1:0.0} ms)</color>";

		[Token(Token = "0x4000099")]
		private const string green = "<color=#81C784><b>FPS: {0:0.}</b> ({1:0.0} ms)</color>";

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x826FA0", Offset = "0x826FA0", VA = "0x826FA0")]
		public FPSDisplay()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x826FA8", Offset = "0x826FA8", VA = "0x826FA8")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class ScrollRectHandler : MonoBehaviour
	{
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ScrollRect Scroll;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float WindowsSensitivity;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float MacSensitivity;

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x827300", Offset = "0x827300", VA = "0x827300")]
		public ScrollRectHandler()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x827320", Offset = "0x827320", VA = "0x827320")]
		public void Start()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class TakeScreenshot : MonoBehaviour
	{
		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string Prefix;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Scale;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public KeyCode KeyCode;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Texture2D texture;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x827424", Offset = "0x827424", VA = "0x827424")]
		public TakeScreenshot()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x82749C", Offset = "0x82749C", VA = "0x82749C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x82756C", Offset = "0x82756C", VA = "0x82756C")]
		public void Update()
		{
		}
	}
}
namespace Crosstales.UI
{
	[Token(Token = "0x200001C")]
	public class WindowManager : MonoBehaviour
	{
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BFB8", Offset = "0x29BFB8")]
		public float Speed;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29BFEC", Offset = "0x29BFEC")]
		public GameObject[] Dependencies;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private UIFocus focus;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool open;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool close;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 startPos;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 centerPos;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lerpPos;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float openProgress;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float closeProgress;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject panel;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x827758", Offset = "0x827758", VA = "0x827758")]
		public WindowManager()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x82776C", Offset = "0x82776C", VA = "0x82776C")]
		public void Start()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x82793C", Offset = "0x82793C", VA = "0x82793C")]
		public void Update()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x827C28", Offset = "0x827C28", VA = "0x827C28")]
		public void SwitchPanel()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x827C3C", Offset = "0x827C3C", VA = "0x827C3C")]
		public void OpenPanel()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x8278DC", Offset = "0x8278DC", VA = "0x8278DC")]
		public void ClosePanel()
		{
		}
	}
}
namespace Crosstales.RTVoice.Demo
{
	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29C020", Offset = "0x29C020")]
	public class Dialog : MonoBehaviour
	{
		[Token(Token = "0x200015B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29C164", Offset = "0x29C164")]
		private sealed class <DialogSequence>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Voice <personA>__1;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Voice <personB>__1;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int <index>__1;

			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal Dialog $this;

			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal object $current;

			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal bool $disposing;

			[Token(Token = "0x400095C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int $PC;

			[Token(Token = "0x170000F8")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009A5")]
				[Address(RVA = "0x93B100", Offset = "0x93B100", VA = "0x93B100", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009A6")]
				[Address(RVA = "0x93B108", Offset = "0x93B108", VA = "0x93B108", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x939AE8", Offset = "0x939AE8", VA = "0x939AE8")]
			[DebuggerHidden]
			public <DialogSequence>c__Iterator0()
			{
			}

			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x939FF0", Offset = "0x939FF0", VA = "0x939FF0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x93B110", Offset = "0x93B110", VA = "0x93B110", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x93B124", Offset = "0x93B124", VA = "0x93B124", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C054", Offset = "0x29C054")]
		public string CultureA;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string CultureB;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29C088", Offset = "0x29C088")]
		public float RateA;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29C0A4", Offset = "0x29C0A4")]
		public float RateB;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29C0C0", Offset = "0x29C0C0")]
		public float PitchA;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29C0D8", Offset = "0x29C0D8")]
		public float PitchB;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29C0F0", Offset = "0x29C0F0")]
		public float VolumeA;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29C108", Offset = "0x29C108")]
		public float VolumeB;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public AudioSource AudioPersonA;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioSource AudioPersonB;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C120", Offset = "0x29C120")]
		public string[] DialogPersonA;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string[] DialogPersonB;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public string CurrentDialogA;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string CurrentDialogB;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool Running;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string uidSpeakerA;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private string uidSpeakerB;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool playingA;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool playingB;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x9392E4", Offset = "0x9392E4", VA = "0x9392E4")]
		public Dialog()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x9393D8", Offset = "0x9393D8", VA = "0x9393D8")]
		public void Start()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x939720", Offset = "0x939720", VA = "0x939720")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x939A68", Offset = "0x939A68", VA = "0x939A68")]
		[DebuggerHidden]
		public IEnumerator DialogSequence()
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x939AF0", Offset = "0x939AF0", VA = "0x939AF0")]
		private void speakStartMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x939D70", Offset = "0x939D70", VA = "0x939D70")]
		private void speakCompleteMethod(Wrapper wrapper)
		{
		}
	}
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29C1C4", Offset = "0x29C1C4")]
	public class GUIAudioFilter : MonoBehaviour
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C1F8", Offset = "0x29C1F8")]
		public AudioSource Source;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C22C", Offset = "0x29C22C")]
		public AudioReverbFilter ReverbFilter;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AudioChorusFilter ChorusFilter;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioEchoFilter EchoFilter;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AudioDistortionFilter DistortionFilter;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioLowPassFilter LowPassFilter;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public AudioHighPassFilter HighPassFilter;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C260", Offset = "0x29C260")]
		public Text Distortion;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Text Lowpass;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text Highpass;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Text Volume;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Text Pitch;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Dropdown ReverbFilterDropdown;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<AudioReverbPreset> reverbPresets;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x93B1A8", Offset = "0x93B1A8", VA = "0x93B1A8")]
		public GUIAudioFilter()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x93B234", Offset = "0x93B234", VA = "0x93B234")]
		public void Start()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x93B774", Offset = "0x93B774", VA = "0x93B774")]
		public void ResetFilters()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x93B958", Offset = "0x93B958", VA = "0x93B958")]
		public void ReverbFilterDropdownChanged(int index)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x93B9F8", Offset = "0x93B9F8", VA = "0x93B9F8")]
		public void ChorusFilterEnabled(bool enabled)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x93BA28", Offset = "0x93BA28", VA = "0x93BA28")]
		public void EchoFilterEnabled(bool enabled)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x93BA58", Offset = "0x93BA58", VA = "0x93BA58")]
		public void DistortionFilterEnabled(bool enabled)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x93BA88", Offset = "0x93BA88", VA = "0x93BA88")]
		public void DistortionFilterChanged(float value)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x93BB4C", Offset = "0x93BB4C", VA = "0x93BB4C")]
		public void LowPassFilterEnabled(bool enabled)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x93BB7C", Offset = "0x93BB7C", VA = "0x93BB7C")]
		public void LowPassFilterChanged(float value)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x93BBF4", Offset = "0x93BBF4", VA = "0x93BBF4")]
		public void HighPassFilterEnabled(bool enabled)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x93BC24", Offset = "0x93BC24", VA = "0x93BC24")]
		public void HighPassFilterChanged(float value)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x93BC9C", Offset = "0x93BC9C", VA = "0x93BC9C")]
		public void VolumeChanged(float value)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x93BD60", Offset = "0x93BD60", VA = "0x93BD60")]
		public void PitchChanged(float value)
		{
		}
	}
	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29C294", Offset = "0x29C294")]
	public class GUIDialog : MonoBehaviour
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C2C8", Offset = "0x29C2C8")]
		public Dialog DialogScript;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C2FC", Offset = "0x29C2FC")]
		public Color32 SpeakerColor;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Image PanelPersonA;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Image PanelPersonB;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Text PersonA;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text PersonB;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Color32 baseColorA;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color32 baseColorB;

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x93BE24", Offset = "0x93BE24", VA = "0x93BE24")]
		public GUIDialog()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x93BE78", Offset = "0x93BE78", VA = "0x93BE78")]
		public void Start()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x93C1D4", Offset = "0x93C1D4", VA = "0x93C1D4")]
		public void Update()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x93C854", Offset = "0x93C854", VA = "0x93C854")]
		public void StartDialog()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x93C968", Offset = "0x93C968", VA = "0x93C968")]
		public void Silence()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x93D558", Offset = "0x93D558", VA = "0x93D558")]
		public void ChangeRateA(float value)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x93D584", Offset = "0x93D584", VA = "0x93D584")]
		public void ChangeRateB(float value)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x93D5B0", Offset = "0x93D5B0", VA = "0x93D5B0")]
		public void ChangePitchA(float value)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x93D5DC", Offset = "0x93D5DC", VA = "0x93D5DC")]
		public void ChangePitchB(float value)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x93D608", Offset = "0x93D608", VA = "0x93D608")]
		public void ChangeVolumeA(float value)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x93D634", Offset = "0x93D634", VA = "0x93D634")]
		public void ChangeVolumeB(float value)
		{
		}
	}
	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29C330", Offset = "0x29C330")]
	public class GUIMain : MonoBehaviour
	{
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C364", Offset = "0x29C364")]
		public Text Name;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text Version;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Text Scene;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject NoVoices;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Text Errors;

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x93D660", Offset = "0x93D660", VA = "0x93D660")]
		public GUIMain()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x93D668", Offset = "0x93D668", VA = "0x93D668")]
		public void Start()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x93DFDC", Offset = "0x93DFDC", VA = "0x93DFDC")]
		public void Update()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x93DFEC", Offset = "0x93DFEC", VA = "0x93DFEC")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x93E374", Offset = "0x93E374", VA = "0x93E374")]
		public void OpenAssetURL()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x93E3D8", Offset = "0x93E3D8", VA = "0x93E3D8")]
		public void OpenCTURL()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x93E43C", Offset = "0x93E43C", VA = "0x93E43C")]
		public void Silence()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x93E4B4", Offset = "0x93E4B4", VA = "0x93E4B4")]
		public void Quit()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x93E4E0", Offset = "0x93E4E0", VA = "0x93E4E0")]
		private void onVoicesReady()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x93E6B4", Offset = "0x93E6B4", VA = "0x93E6B4")]
		private void onErrorInfo(Wrapper wrapper, string errorInfo)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x93E778", Offset = "0x93E778", VA = "0x93E778")]
		private void onSpeakStart(Wrapper wrapper)
		{
		}
	}
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29C398", Offset = "0x29C398")]
	public class GUIMultiAudioFilter : MonoBehaviour
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C3CC", Offset = "0x29C3CC")]
		public List<AudioSource> Sources;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C400", Offset = "0x29C400")]
		public List<AudioReverbFilter> ReverbFilters;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public List<AudioChorusFilter> ChorusFilters;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<AudioEchoFilter> EchoFilters;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public List<AudioDistortionFilter> DistortionFilters;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<AudioLowPassFilter> LowPassFilters;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public List<AudioHighPassFilter> HighPassFilters;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C434", Offset = "0x29C434")]
		public Text Distortion;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Text Lowpass;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text Highpass;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Text Volume;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Text Pitch;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Dropdown ReverbFilterDropdown;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<AudioReverbPreset> reverbPresets;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x93E87C", Offset = "0x93E87C", VA = "0x93E87C")]
		public GUIMultiAudioFilter()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x93EA74", Offset = "0x93EA74", VA = "0x93EA74")]
		public void Start()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x93EFAC", Offset = "0x93EFAC", VA = "0x93EFAC")]
		public void ResetFilters()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x93F7B0", Offset = "0x93F7B0", VA = "0x93F7B0")]
		public void ClearFilters()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x93F914", Offset = "0x93F914", VA = "0x93F914")]
		public void ReverbFilterDropdownChanged(int index)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x93FA8C", Offset = "0x93FA8C", VA = "0x93FA8C")]
		public void ChorusFilterEnabled(bool enabled)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x93FBD4", Offset = "0x93FBD4", VA = "0x93FBD4")]
		public void EchoFilterEnabled(bool enabled)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x93FD1C", Offset = "0x93FD1C", VA = "0x93FD1C")]
		public void DistortionFilterEnabled(bool enabled)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x93FE64", Offset = "0x93FE64", VA = "0x93FE64")]
		public void DistortionFilterChanged(float value)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x940000", Offset = "0x940000", VA = "0x940000")]
		public void LowPassFilterEnabled(bool enabled)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x940148", Offset = "0x940148", VA = "0x940148")]
		public void LowPassFilterChanged(float value)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x9402D4", Offset = "0x9402D4", VA = "0x9402D4")]
		public void HighPassFilterEnabled(bool enabled)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x94041C", Offset = "0x94041C", VA = "0x94041C")]
		public void HighPassFilterChanged(float value)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x9405A8", Offset = "0x9405A8", VA = "0x9405A8")]
		public void VolumeChanged(float value)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x940744", Offset = "0x940744", VA = "0x940744")]
		public void PitchChanged(float value)
		{
		}
	}
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29C468", Offset = "0x29C468")]
	public class GUIScenes : MonoBehaviour
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29C49C", Offset = "0x29C49C")]
		public string PreviousScene;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29C4D0", Offset = "0x29C4D0")]
		public string NextScene;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x9408E0", Offset = "0x9408E0", VA = "0x9408E0")]
		public GUIScenes()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x9408E8", Offset = "0x9408E8", VA = "0x9408E8")]
		public void LoadPrevoiusScene()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x940974", Offset = "0x940974", VA = "0x940974")]
		public void LoadNextScene()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29C504", Offset = "0x29C504")]
	public class GUISpeech : MonoBehaviour
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C538", Offset = "0x29C538")]
		public bool StartAsNative;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GUIMultiAudioFilter AudioFilter;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C56C", Offset = "0x29C56C")]
		public GameObject ItemPrefab;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Target;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Scrollbar Scroll;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int ColumnCount;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 SpaceWidth;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector2 SpaceHeight;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C5A0", Offset = "0x29C5A0")]
		public InputField Input;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InputField Culture;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Text Cultures;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Toggle MaryToogle;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Text Voices;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float Rate;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float Pitch;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float Volume;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static bool isNative;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string lastCulture;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private List<SpeakWrapper> wrappers;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x940A00", Offset = "0x940A00", VA = "0x940A00")]
		public GUISpeech()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x940B08", Offset = "0x940B08", VA = "0x940B08")]
		public void Start()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x941E28", Offset = "0x941E28", VA = "0x941E28")]
		public void Update()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x942FBC", Offset = "0x942FBC", VA = "0x942FBC")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x943260", Offset = "0x943260", VA = "0x943260")]
		public void Silence()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x9432D8", Offset = "0x9432D8", VA = "0x9432D8")]
		public void ChangeRate(float rate)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x943374", Offset = "0x943374", VA = "0x943374")]
		public void ChangeVolume(float volume)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x943410", Offset = "0x943410", VA = "0x943410")]
		public void ChangePitch(float pitch)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x9434AC", Offset = "0x9434AC", VA = "0x9434AC")]
		public void ChangeNative(bool native)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x94353C", Offset = "0x94353C", VA = "0x94353C")]
		public void ChangeMaryTTS(bool maryTTS)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x9435BC", Offset = "0x9435BC", VA = "0x9435BC")]
		private void onVoicesReady()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x943888", Offset = "0x943888", VA = "0x943888")]
		private void onProviderChange(string provider)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x94395C", Offset = "0x94395C", VA = "0x94395C")]
		private void clearVoicesList()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x941F30", Offset = "0x941F30", VA = "0x941F30")]
		private void buildVoicesList()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29C5D4", Offset = "0x29C5D4")]
	public class NativeAudio : MonoBehaviour
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string SpeechText;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool PlayOnStart;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Delay;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x94404C", Offset = "0x94404C", VA = "0x94404C")]
		public NativeAudio()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x9440C0", Offset = "0x9440C0", VA = "0x9440C0")]
		public void Start()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x9441E4", Offset = "0x9441E4", VA = "0x9441E4")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x9442DC", Offset = "0x9442DC", VA = "0x9442DC")]
		public void StartTTS()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x944518", Offset = "0x944518", VA = "0x944518")]
		public void Silence()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x944590", Offset = "0x944590", VA = "0x944590")]
		private void play(Wrapper wrapper)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x944668", Offset = "0x944668", VA = "0x944668")]
		private void stop(Wrapper wrapper)
		{
		}
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29C608", Offset = "0x29C608")]
	public class PreGeneratedAudio : MonoBehaviour
	{
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string SpeechText;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool PlayOnStart;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private AudioSource audioSource;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isPlayed;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x944740", Offset = "0x944740", VA = "0x944740")]
		public PreGeneratedAudio()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x9447AC", Offset = "0x9447AC", VA = "0x9447AC")]
		public void Start()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x944A74", Offset = "0x944A74", VA = "0x944A74")]
		public void Update()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x944B5C", Offset = "0x944B5C", VA = "0x944B5C")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x944D3C", Offset = "0x944D3C", VA = "0x944D3C")]
		public void Play()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x944DF4", Offset = "0x944DF4", VA = "0x944DF4")]
		public void Silence()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x944AC0", Offset = "0x944AC0", VA = "0x944AC0")]
		public void Stop()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x944E1C", Offset = "0x944E1C", VA = "0x944E1C")]
		private void speakAudioGenerationCompleteMethod(Wrapper wrapper)
		{
		}
	}
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29C63C", Offset = "0x29C63C")]
	public class SendMessage : MonoBehaviour
	{
		[Token(Token = "0x200015C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29C6A0", Offset = "0x29C6A0")]
		private sealed class <SpeakerB>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal SendMessage $this;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x170000FA")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009AB")]
				[Address(RVA = "0x945538", Offset = "0x945538", VA = "0x945538", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009AC")]
				[Address(RVA = "0x945540", Offset = "0x945540", VA = "0x945540", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x9451F8", Offset = "0x9451F8", VA = "0x9451F8")]
			[DebuggerHidden]
			public <SpeakerB>c__Iterator0()
			{
			}

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x945284", Offset = "0x945284", VA = "0x945284", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x945548", Offset = "0x945548", VA = "0x945548", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x94555C", Offset = "0x94555C", VA = "0x94555C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0x29C670", Offset = "0x29C670")]
		public string TextA;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0x29C680", Offset = "0x29C680")]
		public string TextB;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float DelayTextB;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool PlayOnStart;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private GameObject receiver;

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x944E2C", Offset = "0x944E2C", VA = "0x944E2C")]
		public SendMessage()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x944EB8", Offset = "0x944EB8", VA = "0x944EB8")]
		public void Start()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x944F38", Offset = "0x944F38", VA = "0x944F38")]
		public void Play()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x94503C", Offset = "0x94503C", VA = "0x94503C")]
		public void SpeakerA()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x945178", Offset = "0x945178", VA = "0x945178")]
		[DebuggerHidden]
		public IEnumerator SpeakerB()
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x945200", Offset = "0x945200", VA = "0x945200")]
		public void Silence()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29C700", Offset = "0x29C700")]
	public class SequenceCaller : MonoBehaviour
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public GameObject receiver;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int NumberOfSequences;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float SequenceDelay;

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x9455E0", Offset = "0x9455E0", VA = "0x9455E0")]
		public SequenceCaller()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x9455F0", Offset = "0x9455F0", VA = "0x9455F0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x94568C", Offset = "0x94568C", VA = "0x94568C")]
		private void playNextSequence()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29C734", Offset = "0x29C734")]
	public class Simple : MonoBehaviour
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C768", Offset = "0x29C768")]
		public AudioSource SourceA;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource SourceB;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29C79C", Offset = "0x29C79C")]
		public float RateSpeakerA;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29C7B8", Offset = "0x29C7B8")]
		public float RateSpeakerB;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool PlayOnStart;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C7D4", Offset = "0x29C7D4")]
		public Text TextSpeakerA;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Text TextSpeakerB;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text PhonemeSpeakerA;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Text PhonemeSpeakerB;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text VisemeSpeakerA;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Text VisemeSpeakerB;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string uidSpeakerA;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private string uidSpeakerB;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string textA;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private string textB;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x945704", Offset = "0x945704", VA = "0x945704")]
		public Simple()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x94579C", Offset = "0x94579C", VA = "0x94579C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x9460B4", Offset = "0x9460B4", VA = "0x9460B4")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x945F70", Offset = "0x945F70", VA = "0x945F70")]
		public void Play()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x94678C", Offset = "0x94678C", VA = "0x94678C")]
		public void SpeakerA()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x9468C0", Offset = "0x9468C0", VA = "0x9468C0")]
		public void SpeakerB()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x9469F4", Offset = "0x9469F4", VA = "0x9469F4")]
		public void Silence()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x946CE0", Offset = "0x946CE0", VA = "0x946CE0")]
		private void speakAudioGenerationStartMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x946DB8", Offset = "0x946DB8", VA = "0x946DB8")]
		private void speakAudioGenerationCompleteMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x947280", Offset = "0x947280", VA = "0x947280")]
		private void speakStartMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x9474B8", Offset = "0x9474B8", VA = "0x9474B8")]
		private void speakCompleteMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x947F30", Offset = "0x947F30", VA = "0x947F30")]
		private void speakCurrentWordMethod(Wrapper wrapper, string[] speechTextArray, int wordIndex)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x9481C0", Offset = "0x9481C0", VA = "0x9481C0")]
		private void speakCurrentPhonemeMethod(Wrapper wrapper, string phoneme)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x9483E0", Offset = "0x9483E0", VA = "0x9483E0")]
		private void speakCurrentVisemeMethod(Wrapper wrapper, string viseme)
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29C808", Offset = "0x29C808")]
	public class SimpleNative : MonoBehaviour
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C83C", Offset = "0x29C83C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29C83C", Offset = "0x29C83C")]
		public float RateSpeakerA;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29C890", Offset = "0x29C890")]
		public float RateSpeakerB;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29C8AC", Offset = "0x29C8AC")]
		public float RateSpeakerC;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool PlayOnStart;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29C8C8", Offset = "0x29C8C8")]
		public Text TextSpeakerA;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text TextSpeakerB;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Text TextSpeakerC;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text PhonemeSpeakerA;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Text PhonemeSpeakerB;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text PhonemeSpeakerC;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Text VisemeSpeakerA;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Text VisemeSpeakerB;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Text VisemeSpeakerC;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string uidSpeakerA;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private string uidSpeakerB;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string uidSpeakerC;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private string textA;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string textB;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private string textC;

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x948600", Offset = "0x948600", VA = "0x948600")]
		public SimpleNative()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x9486B8", Offset = "0x9486B8", VA = "0x9486B8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x948BE4", Offset = "0x948BE4", VA = "0x948BE4")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x948A28", Offset = "0x948A28", VA = "0x948A28")]
		public void Play()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x948D9C", Offset = "0x948D9C", VA = "0x948D9C")]
		public void SpeakerA()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x948EA0", Offset = "0x948EA0", VA = "0x948EA0")]
		public void SpeakerB()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x948FA4", Offset = "0x948FA4", VA = "0x948FA4")]
		public void SpeakerC()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x9490A8", Offset = "0x9490A8", VA = "0x9490A8")]
		public void Silence()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x94938C", Offset = "0x94938C", VA = "0x94938C")]
		private void speakStartMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x94965C", Offset = "0x94965C", VA = "0x94965C")]
		private void speakCompleteMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x949D4C", Offset = "0x949D4C", VA = "0x949D4C")]
		private void speakCurrentWordMethod(Wrapper wrapper, string[] speechTextArray, int wordIndex)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x94A084", Offset = "0x94A084", VA = "0x94A084")]
		private void speakCurrentPhonemeMethod(Wrapper wrapper, string phoneme)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x94A330", Offset = "0x94A330", VA = "0x94A330")]
		private void speakCurrentVisemeMethod(Wrapper wrapper, string viseme)
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x29C8FC", Offset = "0x29C8FC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29C8FC", Offset = "0x29C8FC")]
	public class SpeakWrapper : MonoBehaviour
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Voice SpeakerVoice;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InputField Input;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Text Label;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioSource Audio;

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x94A5DC", Offset = "0x94A5DC", VA = "0x94A5DC")]
		public SpeakWrapper()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x94A5E4", Offset = "0x94A5E4", VA = "0x94A5E4")]
		public void Start()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x94A64C", Offset = "0x94A64C", VA = "0x94A64C")]
		public void Speak()
		{
		}
	}
}
namespace Crosstales.RTVoice.Demo.Util
{
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29C99C", Offset = "0x29C99C")]
	public class iOSController : MonoBehaviour
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x94A898", Offset = "0x94A898", VA = "0x94A898")]
		public iOSController()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x94A8A0", Offset = "0x94A8A0", VA = "0x94A8A0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x94A964", Offset = "0x94A964", VA = "0x94A964")]
		public void OnDestroy()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29C9D0", Offset = "0x29C9D0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x29C9D0", Offset = "0x29C9D0")]
	public class MaterialChanger : MonoBehaviour
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AudioSource Source;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material ActiveMaterial;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Material inactiveMaterial;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Renderer myRenderer;

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x94A9F4", Offset = "0x94A9F4", VA = "0x94A9F4")]
		public MaterialChanger()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x94A9FC", Offset = "0x94A9FC", VA = "0x94A9FC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x94AA84", Offset = "0x94AA84", VA = "0x94AA84")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29CA70", Offset = "0x29CA70")]
	public class NativeController : MonoBehaviour
	{
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29CAA4", Offset = "0x29CAA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CAA4", Offset = "0x29CAA4")]
		public bool Active;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29CB04", Offset = "0x29CB04")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CB04", Offset = "0x29CB04")]
		public GameObject[] Objects;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x94AADC", Offset = "0x94AADC", VA = "0x94AADC")]
		public NativeController()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x94AAEC", Offset = "0x94AAEC", VA = "0x94AAEC")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29CB64", Offset = "0x29CB64")]
	public class PlatformController : Crosstales.Common.Util.PlatformController
	{
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x94AC20", Offset = "0x94AC20", VA = "0x94AC20")]
		public PlatformController()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x94AC30", Offset = "0x94AC30", VA = "0x94AC30", Slot = "4")]
		public override void Start()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x94AE30", Offset = "0x94AE30", VA = "0x94AE30")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x94AD1C", Offset = "0x94AD1C", VA = "0x94AD1C")]
		private void onProviderChange(string provider)
		{
		}
	}
}
namespace Crosstales.RTVoice
{
	[Token(Token = "0x200002F")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29CB98", Offset = "0x29CB98")]
	public class LiveSpeaker : MonoBehaviour
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static char[] splitChar;

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x94AEE8", Offset = "0x94AEE8", VA = "0x94AEE8")]
		public LiveSpeaker()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x94AEF0", Offset = "0x94AEF0", VA = "0x94AEF0")]
		public void SpeakNative(Wrapper wrapper)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x94B068", Offset = "0x94B068", VA = "0x94B068")]
		public void SpeakNative(string args)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x94B1B0", Offset = "0x94B1B0", VA = "0x94B1B0")]
		public void SpeakNative(string[] args)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x94BBFC", Offset = "0x94BBFC", VA = "0x94BBFC")]
		public void Speak(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x94BD74", Offset = "0x94BD74", VA = "0x94BD74")]
		public void Speak(string args)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x94BEBC", Offset = "0x94BEBC", VA = "0x94BEBC")]
		public void Speak(string[] args)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x94C454", Offset = "0x94C454", VA = "0x94C454")]
		public void Silence()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x94C4CC", Offset = "0x94C4CC", VA = "0x94C4CC")]
		public void SetVoices(string voices)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x94C5BC", Offset = "0x94C5BC", VA = "0x94C5BC")]
		public void WordSpoken(string word)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x94C638", Offset = "0x94C638", VA = "0x94C638")]
		public void SetState(string state)
		{
		}
	}
}
namespace Crosstales.RTVoice.Model.Enum
{
	[Token(Token = "0x2000030")]
	public enum MaryTTSType
	{
		[Token(Token = "0x400013A")]
		RAWMARYXML,
		[Token(Token = "0x400013B")]
		EMOTIONML,
		[Token(Token = "0x400013C")]
		SSML,
		[Token(Token = "0x400013D")]
		TEXT
	}
	[Token(Token = "0x2000031")]
	public enum ProviderType
	{
		[Token(Token = "0x400013F")]
		Windows,
		[Token(Token = "0x4000140")]
		macOS,
		[Token(Token = "0x4000141")]
		Android,
		[Token(Token = "0x4000142")]
		iOS,
		[Token(Token = "0x4000143")]
		WSA,
		[Token(Token = "0x4000144")]
		MaryTTS
	}
	[Token(Token = "0x2000032")]
	public enum SpeakMode
	{
		[Token(Token = "0x4000146")]
		Speak,
		[Token(Token = "0x4000147")]
		SpeakNative
	}
}
namespace Crosstales.RTVoice.Model
{
	[Serializable]
	[Token(Token = "0x2000033")]
	public class Sequence
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CBF0", Offset = "0x29CBF0")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0x29CBF0", Offset = "0x29CBF0")]
		public string Text;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CC38", Offset = "0x29CC38")]
		public string RTVoiceNameWindows;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CC6C", Offset = "0x29CC6C")]
		public string RTVoiceNameMac;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CCA0", Offset = "0x29CCA0")]
		public string RTVoiceNameAndroid;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CCD4", Offset = "0x29CCD4")]
		public string RTVoiceNameIOS;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CD08", Offset = "0x29CD08")]
		public string RTVoiceNameWSA;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CD3C", Offset = "0x29CD3C")]
		public SpeakMode Mode;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29CD70", Offset = "0x29CD70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CD70", Offset = "0x29CD70")]
		public AudioSource Source;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CDD0", Offset = "0x29CDD0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29CDD0", Offset = "0x29CDD0")]
		public float Rate;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CE24", Offset = "0x29CE24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29CE24", Offset = "0x29CE24")]
		public float Pitch;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CE74", Offset = "0x29CE74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29CE74", Offset = "0x29CE74")]
		public float Volume;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public bool initalized;

		[Token(Token = "0x17000015")]
		public string RTVoiceName
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x94C874", Offset = "0x94C874", VA = "0x94C874")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x94C768", Offset = "0x94C768", VA = "0x94C768")]
		public Sequence()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x94C9C8", Offset = "0x94C9C8", VA = "0x94C9C8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000034")]
	public class Voice
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CED4", Offset = "0x29CED4")]
		public string Name;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CF08", Offset = "0x29CF08")]
		public string Description;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CF3C", Offset = "0x29CF3C")]
		public string Gender;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CF70", Offset = "0x29CF70")]
		public string Age;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29CFA4", Offset = "0x29CFA4")]
		public string Culture;

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x94D054", Offset = "0x94D054", VA = "0x94D054")]
		public Voice(string name, string description, string gender, string age, string culture)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x94D158", Offset = "0x94D158", VA = "0x94D158")]
		public Voice(string name, string description, string culture)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x94D24C", Offset = "0x94D24C", VA = "0x94D24C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000035")]
	public class Wrapper
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Uid;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AudioSource Source;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Voice Voice;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool SpeakImmediately;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string OutputFile;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private string text;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float rate;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float pitch;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float volume;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DateTime created;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string cachedString;

		[Token(Token = "0x17000016")]
		public string Text
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x9479A0", Offset = "0x9479A0", VA = "0x9479A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x94D7EC", Offset = "0x94D7EC", VA = "0x94D7EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public float Rate
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x94DB84", Offset = "0x94DB84", VA = "0x94DB84")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x94D7FC", Offset = "0x94D7FC", VA = "0x94D7FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public float Pitch
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x94DB8C", Offset = "0x94DB8C", VA = "0x94DB8C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x94D8A4", Offset = "0x94D8A4", VA = "0x94D8A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public float Volume
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x94DB94", Offset = "0x94DB94", VA = "0x94DB94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x94D948", Offset = "0x94D948", VA = "0x94D948")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public DateTime Created
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x94DB9C", Offset = "0x94DB9C", VA = "0x94DB9C")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x94D670", Offset = "0x94D670", VA = "0x94D670")]
		public Wrapper()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x94BA10", Offset = "0x94BA10", VA = "0x94BA10")]
		public Wrapper(string text, [Optional] Voice voice, float rate = 1f, float pitch = 1f, float volume = 1f, [Optional] AudioSource source, bool speakImmediately = true, string outputFile = "")
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x94D9EC", Offset = "0x94D9EC", VA = "0x94D9EC")]
		public Wrapper(string uid, string text, [Optional] Voice voice, float rate = 1f, float pitch = 1f, float volume = 1f, [Optional] AudioSource source, bool speakImmediately = true, string outputFile = "")
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x94DBB0", Offset = "0x94DBB0", VA = "0x94DBB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace Crosstales.RTVoice.Provider
{
	[Token(Token = "0x2000036")]
	public abstract class BaseVoiceProvider
	{
		[Token(Token = "0x2000037")]
		public delegate void VoicesReady();

		[Token(Token = "0x2000038")]
		public delegate void SpeakStart(Wrapper wrapper);

		[Token(Token = "0x2000039")]
		public delegate void SpeakComplete(Wrapper wrapper);

		[Token(Token = "0x200003A")]
		public delegate void SpeakCurrentWord(Wrapper wrapper, string[] speechTextArray, int wordIndex);

		[Token(Token = "0x200003B")]
		public delegate void SpeakCurrentPhoneme(Wrapper wrapper, string phoneme);

		[Token(Token = "0x200003C")]
		public delegate void SpeakCurrentViseme(Wrapper wrapper, string viseme);

		[Token(Token = "0x200003D")]
		public delegate void SpeakAudioGenerationStart(Wrapper wrapper);

		[Token(Token = "0x200003E")]
		public delegate void SpeakAudioGenerationComplete(Wrapper wrapper);

		[Token(Token = "0x200003F")]
		public delegate void ErrorInfo(Wrapper wrapper, string info);

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected Dictionary<string, Process> processes;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		protected bool silence;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static char[] splitCharWords;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected MonoBehaviour speakerObj;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static VoicesReady _onVoicesReady;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static SpeakStart _onSpeakStart;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static SpeakComplete _onSpeakComplete;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static SpeakCurrentWord _onSpeakCurrentWord;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static SpeakCurrentPhoneme _onSpeakCurrentPhoneme;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static SpeakCurrentViseme _onSpeakCurrentViseme;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static SpeakAudioGenerationStart _onSpeakAudioGenerationStart;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static SpeakAudioGenerationComplete _onSpeakAudioGenerationComplete;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static ErrorInfo _onErrorInfo;

		[Token(Token = "0x1700001B")]
		public abstract string AudioFileExtension
		{
			[Token(Token = "0x600014C")]
			get;
		}

		[Token(Token = "0x1700001C")]
		public abstract List<Voice> Voices
		{
			[Token(Token = "0x600014D")]
			get;
		}

		[Token(Token = "0x14000001")]
		public static event VoicesReady OnVoicesReady
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x94E390", Offset = "0x94E390", VA = "0x94E390")]
			add
			{
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x94E4B8", Offset = "0x94E4B8", VA = "0x94E4B8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public static event SpeakStart OnSpeakStart
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x94E5E0", Offset = "0x94E5E0", VA = "0x94E5E0")]
			add
			{
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x94E708", Offset = "0x94E708", VA = "0x94E708")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public static event SpeakComplete OnSpeakComplete
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x94E830", Offset = "0x94E830", VA = "0x94E830")]
			add
			{
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x94E958", Offset = "0x94E958", VA = "0x94E958")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public static event SpeakCurrentWord OnSpeakCurrentWord
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x94EA80", Offset = "0x94EA80", VA = "0x94EA80")]
			add
			{
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x94EBA8", Offset = "0x94EBA8", VA = "0x94EBA8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public static event SpeakCurrentPhoneme OnSpeakCurrentPhoneme
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x94ECD0", Offset = "0x94ECD0", VA = "0x94ECD0")]
			add
			{
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x94EDF8", Offset = "0x94EDF8", VA = "0x94EDF8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public static event SpeakCurrentViseme OnSpeakCurrentViseme
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x94EF20", Offset = "0x94EF20", VA = "0x94EF20")]
			add
			{
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x94F048", Offset = "0x94F048", VA = "0x94F048")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public static event SpeakAudioGenerationStart OnSpeakAudioGenerationStart
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x94F170", Offset = "0x94F170", VA = "0x94F170")]
			add
			{
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x94F298", Offset = "0x94F298", VA = "0x94F298")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public static event SpeakAudioGenerationComplete OnSpeakAudioGenerationComplete
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x94F3C0", Offset = "0x94F3C0", VA = "0x94F3C0")]
			add
			{
			}
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x94F4E8", Offset = "0x94F4E8", VA = "0x94F4E8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public static event ErrorInfo OnErrorInfo
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x94F610", Offset = "0x94F610", VA = "0x94F610")]
			add
			{
			}
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x94F738", Offset = "0x94F738", VA = "0x94F738")]
			remove
			{
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x94E2FC", Offset = "0x94E2FC", VA = "0x94E2FC")]
		public BaseVoiceProvider(MonoBehaviour obj)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x94F860", Offset = "0x94F860", VA = "0x94F860", Slot = "6")]
		public virtual void Silence()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x94F86C", Offset = "0x94F86C", VA = "0x94F86C", Slot = "7")]
		public virtual void Silence(string uid)
		{
		}

		[Token(Token = "0x6000162")]
		public abstract IEnumerator SpeakNative(Wrapper wrapper);

		[Token(Token = "0x6000163")]
		public abstract IEnumerator Speak(Wrapper wrapper);

		[Token(Token = "0x6000164")]
		public abstract IEnumerator Generate(Wrapper wrapper);

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x94F870", Offset = "0x94F870", VA = "0x94F870")]
		protected static void fileCopy(string inputFile, string outputFile, bool move = false)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x94FC74", Offset = "0x94FC74", VA = "0x94FC74")]
		protected static void onVoicesReady()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x94FFE8", Offset = "0x94FFE8", VA = "0x94FFE8")]
		protected static void onSpeakStart(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x95054C", Offset = "0x95054C", VA = "0x95054C")]
		protected static void onSpeakComplete(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x950AB0", Offset = "0x950AB0", VA = "0x950AB0")]
		protected static void onSpeakCurrentWord(Wrapper wrapper, string[] speechTextArray, int wordIndex)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x95149C", Offset = "0x95149C", VA = "0x95149C")]
		protected static void onSpeakCurrentPhoneme(Wrapper wrapper, string phoneme)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x951BA0", Offset = "0x951BA0", VA = "0x951BA0")]
		protected static void onSpeakCurrentViseme(Wrapper wrapper, string viseme)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x9522A4", Offset = "0x9522A4", VA = "0x9522A4")]
		protected static void onSpeakAudioGenerationStart(Wrapper wrapper)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x952808", Offset = "0x952808", VA = "0x952808")]
		protected static void onSpeakAudioGenerationComplete(Wrapper wrapper)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x952D6C", Offset = "0x952D6C", VA = "0x952D6C")]
		protected static void onErrorInfo(Wrapper wrapper, string info)
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class VoiceProviderAndroid : BaseVoiceProvider
	{
		[Token(Token = "0x200015D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D018", Offset = "0x29D018")]
		private sealed class <SpeakNative>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Wrapper wrapper;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal string <voiceName>__1;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal VoiceProviderAndroid $this;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal object $current;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal bool $disposing;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal int $PC;

			[Token(Token = "0x170000FC")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009B1")]
				[Address(RVA = "0x957D08", Offset = "0x957D08", VA = "0x957D08", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009B2")]
				[Address(RVA = "0x957D10", Offset = "0x957D10", VA = "0x957D10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x953BF8", Offset = "0x953BF8", VA = "0x953BF8")]
			[DebuggerHidden]
			public <SpeakNative>c__Iterator0()
			{
			}

			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x9574C4", Offset = "0x9574C4", VA = "0x9574C4", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x957D18", Offset = "0x957D18", VA = "0x957D18", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x957D2C", Offset = "0x957D2C", VA = "0x957D2C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x200015E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D078", Offset = "0x29D078")]
		private sealed class <Speak>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Wrapper wrapper;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal string <voiceName>__1;

			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string <outputFile>__1;

			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal WWW <www>__2;

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal AudioClip <ac>__3;

			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal VoiceProviderAndroid $this;

			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal object $current;

			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal bool $disposing;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int $PC;

			[Token(Token = "0x170000FE")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009B7")]
				[Address(RVA = "0x957404", Offset = "0x957404", VA = "0x957404", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009B8")]
				[Address(RVA = "0x95740C", Offset = "0x95740C", VA = "0x95740C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x953C98", Offset = "0x953C98", VA = "0x953C98")]
			[DebuggerHidden]
			public <Speak>c__Iterator1()
			{
			}

			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x955B74", Offset = "0x955B74", VA = "0x955B74", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x957414", Offset = "0x957414", VA = "0x957414", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x957440", Offset = "0x957440", VA = "0x957440", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x957334", Offset = "0x957334", VA = "0x957334")]
			private void <>__Finally0()
			{
			}
		}

		[Token(Token = "0x200015F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D0D8", Offset = "0x29D0D8")]
		private sealed class <Generate>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Wrapper wrapper;

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal string <voiceName>__1;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string <outputFile>__1;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal VoiceProviderAndroid $this;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal object $current;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal bool $disposing;

			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int $PC;

			[Token(Token = "0x17000100")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009BE")]
				[Address(RVA = "0x955208", Offset = "0x955208", VA = "0x955208", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000101")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009BF")]
				[Address(RVA = "0x955210", Offset = "0x955210", VA = "0x955210", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x953D38", Offset = "0x953D38", VA = "0x953D38")]
			[DebuggerHidden]
			public <Generate>c__Iterator2()
			{
			}

			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x954210", Offset = "0x954210", VA = "0x954210", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x955218", Offset = "0x955218", VA = "0x955218", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x95522C", Offset = "0x95522C", VA = "0x95522C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D138", Offset = "0x29D138")]
		private sealed class <getVoices>c__Iterator3 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal VoiceProviderAndroid $this;

			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x17000102")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009C4")]
				[Address(RVA = "0x955ACC", Offset = "0x955ACC", VA = "0x955ACC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000103")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009C5")]
				[Address(RVA = "0x955AD4", Offset = "0x955AD4", VA = "0x955AD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x953F0C", Offset = "0x953F0C", VA = "0x953F0C")]
			[DebuggerHidden]
			public <getVoices>c__Iterator3()
			{
			}

			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x9552B0", Offset = "0x9552B0", VA = "0x9552B0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x955ADC", Offset = "0x955ADC", VA = "0x955ADC", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x955AF0", Offset = "0x955AF0", VA = "0x955AF0", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<Voice> cachedVoices;

		[Token(Token = "0x4000172")]
		private const string extension = ".wav";

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static bool isInitialized;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static AndroidJavaObject TtsHandler;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private readonly WaitForSeconds wfs;

		[Token(Token = "0x1700001D")]
		public override string AudioFileExtension
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x953A78", Offset = "0x953A78", VA = "0x953A78", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public override List<Voice> Voices
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x953AD4", Offset = "0x953AD4", VA = "0x953AD4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x953720", Offset = "0x953720", VA = "0x953720")]
		public VoiceProviderAndroid(MonoBehaviour obj)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x953B60", Offset = "0x953B60", VA = "0x953B60", Slot = "8")]
		[DebuggerHidden]
		public override IEnumerator SpeakNative(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x953C00", Offset = "0x953C00", VA = "0x953C00", Slot = "9")]
		[DebuggerHidden]
		public override IEnumerator Speak(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x953CA0", Offset = "0x953CA0", VA = "0x953CA0", Slot = "10")]
		[DebuggerHidden]
		public override IEnumerator Generate(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x953D40", Offset = "0x953D40", VA = "0x953D40", Slot = "6")]
		public override void Silence()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x953E2C", Offset = "0x953E2C", VA = "0x953E2C")]
		public void ShutdownTTS()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x9539F8", Offset = "0x9539F8", VA = "0x9539F8")]
		[DebuggerHidden]
		private IEnumerator getVoices()
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x95384C", Offset = "0x95384C", VA = "0x95384C")]
		private void initializeTTS()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x953F14", Offset = "0x953F14", VA = "0x953F14")]
		private string getVoiceName(Wrapper wrapper)
		{
			return null;
		}
	}
	[Token(Token = "0x2000041")]
	public class VoiceProviderIOS : BaseVoiceProvider
	{
		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D1D8", Offset = "0x29D1D8")]
		private sealed class <SpeakNative>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Wrapper wrapper;

			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal VoiceProviderIOS $this;

			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object $current;

			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int $PC;

			[Token(Token = "0x17000104")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009CA")]
				[Address(RVA = "0x958BB0", Offset = "0x958BB0", VA = "0x958BB0", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000105")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009CB")]
				[Address(RVA = "0x958BB8", Offset = "0x958BB8", VA = "0x958BB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x957FB8", Offset = "0x957FB8", VA = "0x957FB8")]
			[DebuggerHidden]
			public <SpeakNative>c__Iterator0()
			{
			}

			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x958B30", Offset = "0x958B30", VA = "0x958B30", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x958BC0", Offset = "0x958BC0", VA = "0x958BC0", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x958BD4", Offset = "0x958BD4", VA = "0x958BD4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000162")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D238", Offset = "0x29D238")]
		private sealed class <Speak>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Wrapper wrapper;

			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal VoiceProviderIOS $this;

			[Token(Token = "0x4000982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object $current;

			[Token(Token = "0x4000983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			[Token(Token = "0x4000984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int $PC;

			[Token(Token = "0x17000106")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009D0")]
				[Address(RVA = "0x958980", Offset = "0x958980", VA = "0x958980", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000107")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009D1")]
				[Address(RVA = "0x958988", Offset = "0x958988", VA = "0x958988", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x958058", Offset = "0x958058", VA = "0x958058")]
			[DebuggerHidden]
			public <Speak>c__Iterator1()
			{
			}

			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x958900", Offset = "0x958900", VA = "0x958900", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x958990", Offset = "0x958990", VA = "0x958990", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x9589A4", Offset = "0x9589A4", VA = "0x9589A4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000163")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D298", Offset = "0x29D298")]
		private sealed class <Generate>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object $current;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool $disposing;

			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $PC;

			[Token(Token = "0x17000108")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009D6")]
				[Address(RVA = "0x958858", Offset = "0x958858", VA = "0x958858", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000109")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009D7")]
				[Address(RVA = "0x958860", Offset = "0x958860", VA = "0x958860", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x9580CC", Offset = "0x9580CC", VA = "0x9580CC")]
			[DebuggerHidden]
			public <Generate>c__Iterator2()
			{
			}

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x958768", Offset = "0x958768", VA = "0x958768", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x958868", Offset = "0x958868", VA = "0x958868", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x95887C", Offset = "0x95887C", VA = "0x95887C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D2F8", Offset = "0x29D2F8")]
		private sealed class <speak>c__Iterator3 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object $current;

			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool $disposing;

			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $PC;

			[Token(Token = "0x1700010A")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009DC")]
				[Address(RVA = "0x958A88", Offset = "0x958A88", VA = "0x958A88", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009DD")]
				[Address(RVA = "0x958A90", Offset = "0x958A90", VA = "0x958A90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x95814C", Offset = "0x95814C", VA = "0x95814C")]
			[DebuggerHidden]
			public <speak>c__Iterator3()
			{
			}

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x958A28", Offset = "0x958A28", VA = "0x958A28", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x958A98", Offset = "0x958A98", VA = "0x958A98", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x958AAC", Offset = "0x958AAC", VA = "0x958AAC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<Voice> cachedVoices;

		[Token(Token = "0x4000177")]
		private const string extension = "none";

		[Token(Token = "0x1700001F")]
		public override string AudioFileExtension
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x957E38", Offset = "0x957E38", VA = "0x957E38", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public override List<Voice> Voices
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x957E94", Offset = "0x957E94", VA = "0x957E94", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x957DB0", Offset = "0x957DB0", VA = "0x957DB0")]
		public VoiceProviderIOS(MonoBehaviour obj)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x94C544", Offset = "0x94C544", VA = "0x94C544")]
		public static void SetVoices(string voicesText)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x94C6B0", Offset = "0x94C6B0", VA = "0x94C6B0")]
		public static void SetState(string state)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x94C634", Offset = "0x94C634", VA = "0x94C634")]
		public static void WordSpoken()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x957F20", Offset = "0x957F20", VA = "0x957F20", Slot = "8")]
		[DebuggerHidden]
		public override IEnumerator SpeakNative(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x957FC0", Offset = "0x957FC0", VA = "0x957FC0", Slot = "9")]
		[DebuggerHidden]
		public override IEnumerator Speak(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x958060", Offset = "0x958060", VA = "0x958060", Slot = "10")]
		[DebuggerHidden]
		public override IEnumerator Generate(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x9580D4", Offset = "0x9580D4", VA = "0x9580D4", Slot = "6")]
		public override void Silence()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x9580E0", Offset = "0x9580E0", VA = "0x9580E0")]
		[DebuggerHidden]
		private IEnumerator speak(Wrapper wrapper, bool isNative)
		{
			return null;
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x958154", Offset = "0x958154", VA = "0x958154")]
		private static float calculateRate(float rate)
		{
			return default(float);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x95847C", Offset = "0x95847C", VA = "0x95847C")]
		private string getVoiceName(Wrapper wrapper)
		{
			return null;
		}
	}
	[Token(Token = "0x2000042")]
	public class VoiceProviderMacOS : BaseVoiceProvider
	{
		[Token(Token = "0x2000165")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D398", Offset = "0x29D398")]
		private sealed class <SpeakNative>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object $current;

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool $disposing;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $PC;

			[Token(Token = "0x1700010C")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009E2")]
				[Address(RVA = "0x9597EC", Offset = "0x9597EC", VA = "0x9597EC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009E3")]
				[Address(RVA = "0x9597F4", Offset = "0x9597F4", VA = "0x9597F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x958F00", Offset = "0x958F00", VA = "0x958F00")]
			[DebuggerHidden]
			public <SpeakNative>c__Iterator0()
			{
			}

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x95978C", Offset = "0x95978C", VA = "0x95978C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x9597FC", Offset = "0x9597FC", VA = "0x9597FC", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x959810", Offset = "0x959810", VA = "0x959810", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000166")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D3F8", Offset = "0x29D3F8")]
		private sealed class <Speak>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400098E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object $current;

			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool $disposing;

			[Token(Token = "0x4000990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $PC;

			[Token(Token = "0x1700010E")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009E8")]
				[Address(RVA = "0x9596E4", Offset = "0x9596E4", VA = "0x9596E4", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009E9")]
				[Address(RVA = "0x9596EC", Offset = "0x9596EC", VA = "0x9596EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x958F74", Offset = "0x958F74", VA = "0x958F74")]
			[DebuggerHidden]
			public <Speak>c__Iterator1()
			{
			}

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x959684", Offset = "0x959684", VA = "0x959684", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x9596F4", Offset = "0x9596F4", VA = "0x9596F4", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x959708", Offset = "0x959708", VA = "0x959708", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000167")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D458", Offset = "0x29D458")]
		private sealed class <Generate>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object $current;

			[Token(Token = "0x4000992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool $disposing;

			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $PC;

			[Token(Token = "0x17000110")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009EE")]
				[Address(RVA = "0x959458", Offset = "0x959458", VA = "0x959458", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000111")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009EF")]
				[Address(RVA = "0x959460", Offset = "0x959460", VA = "0x959460", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x958FE8", Offset = "0x958FE8", VA = "0x958FE8")]
			[DebuggerHidden]
			public <Generate>c__Iterator2()
			{
			}

			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x9593F8", Offset = "0x9593F8", VA = "0x9593F8", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x959468", Offset = "0x959468", VA = "0x959468", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x95947C", Offset = "0x95947C", VA = "0x95947C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D4B8", Offset = "0x29D4B8")]
		private sealed class <getVoices>c__Iterator3 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object $current;

			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool $disposing;

			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $PC;

			[Token(Token = "0x17000112")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009F4")]
				[Address(RVA = "0x9595DC", Offset = "0x9595DC", VA = "0x9595DC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000113")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009F5")]
				[Address(RVA = "0x9595E4", Offset = "0x9595E4", VA = "0x9595E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x958FF0", Offset = "0x958FF0", VA = "0x958FF0")]
			[DebuggerHidden]
			public <getVoices>c__Iterator3()
			{
			}

			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x959500", Offset = "0x959500", VA = "0x959500", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x9595EC", Offset = "0x9595EC", VA = "0x9595EC", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x959600", Offset = "0x959600", VA = "0x959600", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<Voice> cachedVoices;

		[Token(Token = "0x4000179")]
		private const int defaultRate = 175;

		[Token(Token = "0x400017A")]
		private const string extension = ".aiff";

		[Token(Token = "0x17000021")]
		public override string AudioFileExtension
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x958DAC", Offset = "0x958DAC", VA = "0x958DAC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		public override List<Voice> Voices
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x958E08", Offset = "0x958E08", VA = "0x958E08", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x958C58", Offset = "0x958C58", VA = "0x958C58")]
		public VoiceProviderMacOS(MonoBehaviour obj)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x958E94", Offset = "0x958E94", VA = "0x958E94", Slot = "8")]
		[DebuggerHidden]
		public override IEnumerator SpeakNative(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x958F08", Offset = "0x958F08", VA = "0x958F08", Slot = "9")]
		[DebuggerHidden]
		public override IEnumerator Speak(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x958F7C", Offset = "0x958F7C", VA = "0x958F7C", Slot = "10")]
		[DebuggerHidden]
		public override IEnumerator Generate(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x958D40", Offset = "0x958D40", VA = "0x958D40")]
		[DebuggerHidden]
		private IEnumerator getVoices()
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x958FF8", Offset = "0x958FF8", VA = "0x958FF8")]
		private static int calculateRate(float rate)
		{
			return default(int);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x959360", Offset = "0x959360", VA = "0x959360")]
		private void getVoicesInEditor()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class VoiceProviderMary : BaseVoiceProvider
	{
		[Token(Token = "0x2000169")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D568", Offset = "0x29D568")]
		private sealed class <SpeakNative>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Wrapper wrapper;

			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal VoiceProviderMary $this;

			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object $current;

			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int $PC;

			[Token(Token = "0x17000114")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x60009FA")]
				[Address(RVA = "0x960AC0", Offset = "0x960AC0", VA = "0x960AC0", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000115")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009FB")]
				[Address(RVA = "0x960AC8", Offset = "0x960AC8", VA = "0x960AC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x959E98", Offset = "0x959E98", VA = "0x959E98")]
			[DebuggerHidden]
			public <SpeakNative>c__Iterator0()
			{
			}

			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x960A34", Offset = "0x960A34", VA = "0x960A34", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x960AD0", Offset = "0x960AD0", VA = "0x960AD0", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x960AE4", Offset = "0x960AE4", VA = "0x960AE4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x200016A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D5C8", Offset = "0x29D5C8")]
		private sealed class <Speak>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x400099C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Wrapper wrapper;

			[Token(Token = "0x400099D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal VoiceProviderMary $this;

			[Token(Token = "0x400099E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object $current;

			[Token(Token = "0x400099F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int $PC;

			[Token(Token = "0x17000116")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A00")]
				[Address(RVA = "0x95E6EC", Offset = "0x95E6EC", VA = "0x95E6EC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000117")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A01")]
				[Address(RVA = "0x95E6F4", Offset = "0x95E6F4", VA = "0x95E6F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x959F38", Offset = "0x959F38", VA = "0x959F38")]
			[DebuggerHidden]
			public <Speak>c__Iterator1()
			{
			}

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x95E660", Offset = "0x95E660", VA = "0x95E660", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x95E6FC", Offset = "0x95E6FC", VA = "0x95E6FC", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x95E710", Offset = "0x95E710", VA = "0x95E710", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x200016B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D628", Offset = "0x29D628")]
		private sealed class <Generate>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Wrapper wrapper;

			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal string <voiceCulture>__1;

			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string <voiceName>__1;

			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal StringBuilder <sbXML>__1;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal string <request>__1;

			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal WWW <www>__2;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal VoiceProviderMary $this;

			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal object $current;

			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal bool $disposing;

			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal int $PC;

			[Token(Token = "0x17000118")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A06")]
				[Address(RVA = "0x95D3A4", Offset = "0x95D3A4", VA = "0x95D3A4", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000119")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A07")]
				[Address(RVA = "0x95D3AC", Offset = "0x95D3AC", VA = "0x95D3AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x959FD8", Offset = "0x959FD8", VA = "0x959FD8")]
			[DebuggerHidden]
			public <Generate>c__Iterator2()
			{
			}

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x95B9B0", Offset = "0x95B9B0", VA = "0x95B9B0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x95D3B4", Offset = "0x95D3B4", VA = "0x95D3B4", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x95D3D4", Offset = "0x95D3D4", VA = "0x95D3D4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x95D2D4", Offset = "0x95D2D4", VA = "0x95D2D4")]
			private void <>__Finally0()
			{
			}
		}

		[Token(Token = "0x200016C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D688", Offset = "0x29D688")]
		private sealed class <speak>c__Iterator3 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Wrapper wrapper;

			[Token(Token = "0x40009AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal string <voiceCulture>__1;

			[Token(Token = "0x40009AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string <voiceName>__1;

			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool isNative;

			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal StringBuilder <sbXML>__1;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal string <request>__1;

			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal WWW <www>__2;

			[Token(Token = "0x40009B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal AudioClip <ac>__3;

			[Token(Token = "0x40009B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal VoiceProviderMary $this;

			[Token(Token = "0x40009B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal object $current;

			[Token(Token = "0x40009B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal bool $disposing;

			[Token(Token = "0x40009B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal int $PC;

			[Token(Token = "0x1700011A")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A0D")]
				[Address(RVA = "0x96097C", Offset = "0x96097C", VA = "0x96097C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A0E")]
				[Address(RVA = "0x960984", Offset = "0x960984", VA = "0x960984", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x95A098", Offset = "0x95A098", VA = "0x95A098")]
			[DebuggerHidden]
			public <speak>c__Iterator3()
			{
			}

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x95E794", Offset = "0x95E794", VA = "0x95E794", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x96098C", Offset = "0x96098C", VA = "0x96098C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x9609B0", Offset = "0x9609B0", VA = "0x9609B0", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x9608AC", Offset = "0x9608AC", VA = "0x9608AC")]
			private void <>__Finally0()
			{
			}
		}

		[Token(Token = "0x200016D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D6E8", Offset = "0x29D6E8")]
		private sealed class <getVoices>c__Iterator4 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal List<string[]> <serverVoicesResponse>__0;

			[Token(Token = "0x40009B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal WWW <www>__1;

			[Token(Token = "0x40009B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal VoiceProviderMary $this;

			[Token(Token = "0x40009BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal object $current;

			[Token(Token = "0x40009BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal bool $disposing;

			[Token(Token = "0x40009BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal int $PC;

			[Token(Token = "0x1700011C")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A14")]
				[Address(RVA = "0x95E5AC", Offset = "0x95E5AC", VA = "0x95E5AC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A15")]
				[Address(RVA = "0x95E5B4", Offset = "0x95E5B4", VA = "0x95E5B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x95A0A0", Offset = "0x95A0A0", VA = "0x95A0A0")]
			[DebuggerHidden]
			public <getVoices>c__Iterator4()
			{
			}

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x95D458", Offset = "0x95D458", VA = "0x95D458", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x95E5BC", Offset = "0x95E5BC", VA = "0x95E5BC", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x95E5DC", Offset = "0x95E5DC", VA = "0x95E5DC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}

			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x95E4DC", Offset = "0x95E4DC", VA = "0x95E4DC")]
			private void <>__Finally0()
			{
			}
		}

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<Voice> cachedVoices;

		[Token(Token = "0x400017C")]
		private const string extension = ".wav";

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private string uri;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private byte[] rawData;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Dictionary<string, string> headers;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MaryTTSType type;

		[Token(Token = "0x17000023")]
		public override string AudioFileExtension
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x959D18", Offset = "0x959D18", VA = "0x959D18", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public override List<Voice> Voices
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x959D74", Offset = "0x959D74", VA = "0x959D74", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x959894", Offset = "0x959894", VA = "0x959894")]
		public VoiceProviderMary(MonoBehaviour obj, string url, int port, string user, string password, MaryTTSType type)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x959E00", Offset = "0x959E00", VA = "0x959E00", Slot = "8")]
		[DebuggerHidden]
		public override IEnumerator SpeakNative(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x959EA0", Offset = "0x959EA0", VA = "0x959EA0", Slot = "9")]
		[DebuggerHidden]
		public override IEnumerator Speak(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x959F40", Offset = "0x959F40", VA = "0x959F40", Slot = "10")]
		[DebuggerHidden]
		public override IEnumerator Generate(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x959FE0", Offset = "0x959FE0", VA = "0x959FE0", Slot = "6")]
		public override void Silence()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x959FEC", Offset = "0x959FEC", VA = "0x959FEC")]
		[DebuggerHidden]
		private IEnumerator speak(Wrapper wrapper, bool isNative)
		{
			return null;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x959C98", Offset = "0x959C98", VA = "0x959C98")]
		[DebuggerHidden]
		private IEnumerator getVoices()
		{
			return null;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x95A0A8", Offset = "0x95A0A8", VA = "0x95A0A8")]
		private static string prepareProsody(string text, float rate, float pitch)
		{
			return null;
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x95A3F0", Offset = "0x95A3F0", VA = "0x95A3F0")]
		private string getVoiceName(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x95A648", Offset = "0x95A648", VA = "0x95A648")]
		private string getVoiceCulture(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x95A7CC", Offset = "0x95A7CC", VA = "0x95A7CC")]
		private void getVoicesInEditor()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class VoiceProviderWindows : BaseVoiceProvider
	{
		[Token(Token = "0x200016E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D788", Offset = "0x29D788")]
		private sealed class <SpeakNative>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object $current;

			[Token(Token = "0x40009BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool $disposing;

			[Token(Token = "0x40009BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $PC;

			[Token(Token = "0x1700011E")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A1B")]
				[Address(RVA = "0x961ED4", Offset = "0x961ED4", VA = "0x961ED4", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A1C")]
				[Address(RVA = "0x961EDC", Offset = "0x961EDC", VA = "0x961EDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x960E20", Offset = "0x960E20", VA = "0x960E20")]
			[DebuggerHidden]
			public <SpeakNative>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x961E74", Offset = "0x961E74", VA = "0x961E74", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x961EE4", Offset = "0x961EE4", VA = "0x961EE4", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x961EF8", Offset = "0x961EF8", VA = "0x961EF8", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x200016F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D7E8", Offset = "0x29D7E8")]
		private sealed class <Speak>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object $current;

			[Token(Token = "0x40009C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool $disposing;

			[Token(Token = "0x40009C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $PC;

			[Token(Token = "0x17000120")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A21")]
				[Address(RVA = "0x961DCC", Offset = "0x961DCC", VA = "0x961DCC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000121")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A22")]
				[Address(RVA = "0x961DD4", Offset = "0x961DD4", VA = "0x961DD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x960E94", Offset = "0x960E94", VA = "0x960E94")]
			[DebuggerHidden]
			public <Speak>c__Iterator1()
			{
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x961D6C", Offset = "0x961D6C", VA = "0x961D6C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x961DDC", Offset = "0x961DDC", VA = "0x961DDC", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x961DF0", Offset = "0x961DF0", VA = "0x961DF0", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D848", Offset = "0x29D848")]
		private sealed class <Generate>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object $current;

			[Token(Token = "0x40009C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool $disposing;

			[Token(Token = "0x40009C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $PC;

			[Token(Token = "0x17000122")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A27")]
				[Address(RVA = "0x961B40", Offset = "0x961B40", VA = "0x961B40", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000123")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A28")]
				[Address(RVA = "0x961B48", Offset = "0x961B48", VA = "0x961B48", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x960F08", Offset = "0x960F08", VA = "0x960F08")]
			[DebuggerHidden]
			public <Generate>c__Iterator2()
			{
			}

			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x961AE0", Offset = "0x961AE0", VA = "0x961AE0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x961B50", Offset = "0x961B50", VA = "0x961B50", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x961B64", Offset = "0x961B64", VA = "0x961B64", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000171")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D8A8", Offset = "0x29D8A8")]
		private sealed class <getVoices>c__Iterator3 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object $current;

			[Token(Token = "0x40009C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool $disposing;

			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $PC;

			[Token(Token = "0x17000124")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A2D")]
				[Address(RVA = "0x961CC4", Offset = "0x961CC4", VA = "0x961CC4", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000125")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A2E")]
				[Address(RVA = "0x961CCC", Offset = "0x961CCC", VA = "0x961CCC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x960F10", Offset = "0x960F10", VA = "0x960F10")]
			[DebuggerHidden]
			public <getVoices>c__Iterator3()
			{
			}

			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x961BE8", Offset = "0x961BE8", VA = "0x961BE8", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x961CD4", Offset = "0x961CD4", VA = "0x961CD4", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x961CE8", Offset = "0x961CE8", VA = "0x961CE8", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<Voice> cachedVoices;

		[Token(Token = "0x4000182")]
		private const string extension = ".wav";

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private string dataPath;

		[Token(Token = "0x17000025")]
		public override string AudioFileExtension
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x960CCC", Offset = "0x960CCC", VA = "0x960CCC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public override List<Voice> Voices
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x960D28", Offset = "0x960D28", VA = "0x960D28", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x960B68", Offset = "0x960B68", VA = "0x960B68")]
		public VoiceProviderWindows(MonoBehaviour obj)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x960DB4", Offset = "0x960DB4", VA = "0x960DB4", Slot = "8")]
		[DebuggerHidden]
		public override IEnumerator SpeakNative(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x960E28", Offset = "0x960E28", VA = "0x960E28", Slot = "9")]
		[DebuggerHidden]
		public override IEnumerator Speak(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x960E9C", Offset = "0x960E9C", VA = "0x960E9C", Slot = "10")]
		[DebuggerHidden]
		public override IEnumerator Generate(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x960C60", Offset = "0x960C60", VA = "0x960C60")]
		[DebuggerHidden]
		private IEnumerator getVoices()
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x960F18", Offset = "0x960F18", VA = "0x960F18")]
		private string applicationName()
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x9610D4", Offset = "0x9610D4", VA = "0x9610D4")]
		private static string prepareText(string text, float pitch)
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x96136C", Offset = "0x96136C", VA = "0x96136C")]
		private static int calculateVolume(float volume)
		{
			return default(int);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x961428", Offset = "0x961428", VA = "0x961428")]
		private static int calculateRate(float rate)
		{
			return default(int);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x961A4C", Offset = "0x961A4C", VA = "0x961A4C")]
		private void getVoicesInEditor()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class VoiceProviderWSA : BaseVoiceProvider
	{
		[Token(Token = "0x2000172")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D958", Offset = "0x29D958")]
		private sealed class <SpeakNative>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Wrapper wrapper;

			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal VoiceProviderWSA $this;

			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object $current;

			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			[Token(Token = "0x40009CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int $PC;

			[Token(Token = "0x17000126")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A33")]
				[Address(RVA = "0x962BE0", Offset = "0x962BE0", VA = "0x962BE0", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000127")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A34")]
				[Address(RVA = "0x962BE8", Offset = "0x962BE8", VA = "0x962BE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x962218", Offset = "0x962218", VA = "0x962218")]
			[DebuggerHidden]
			public <SpeakNative>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x962B60", Offset = "0x962B60", VA = "0x962B60", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x962BF0", Offset = "0x962BF0", VA = "0x962BF0", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x962C04", Offset = "0x962C04", VA = "0x962C04", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000173")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29D9B8", Offset = "0x29D9B8")]
		private sealed class <Speak>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Wrapper wrapper;

			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal VoiceProviderWSA $this;

			[Token(Token = "0x40009D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal object $current;

			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal bool $disposing;

			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int $PC;

			[Token(Token = "0x17000128")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A39")]
				[Address(RVA = "0x9629B0", Offset = "0x9629B0", VA = "0x9629B0", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000129")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A3A")]
				[Address(RVA = "0x9629B8", Offset = "0x9629B8", VA = "0x9629B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x9622B8", Offset = "0x9622B8", VA = "0x9622B8")]
			[DebuggerHidden]
			public <Speak>c__Iterator1()
			{
			}

			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x962930", Offset = "0x962930", VA = "0x962930", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x9629C0", Offset = "0x9629C0", VA = "0x9629C0", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x9629D4", Offset = "0x9629D4", VA = "0x9629D4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DA18", Offset = "0x29DA18")]
		private sealed class <Generate>c__Iterator2 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object $current;

			[Token(Token = "0x40009D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool $disposing;

			[Token(Token = "0x40009D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $PC;

			[Token(Token = "0x1700012A")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A3F")]
				[Address(RVA = "0x962704", Offset = "0x962704", VA = "0x962704", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A40")]
				[Address(RVA = "0x96270C", Offset = "0x96270C", VA = "0x96270C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x96232C", Offset = "0x96232C", VA = "0x96232C")]
			[DebuggerHidden]
			public <Generate>c__Iterator2()
			{
			}

			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x9626A4", Offset = "0x9626A4", VA = "0x9626A4", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x962714", Offset = "0x962714", VA = "0x962714", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x962728", Offset = "0x962728", VA = "0x962728", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000175")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DA78", Offset = "0x29DA78")]
		private sealed class <getVoices>c__Iterator3 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object $current;

			[Token(Token = "0x40009D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool $disposing;

			[Token(Token = "0x40009D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $PC;

			[Token(Token = "0x1700012C")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A45")]
				[Address(RVA = "0x962888", Offset = "0x962888", VA = "0x962888", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A46")]
				[Address(RVA = "0x962890", Offset = "0x962890", VA = "0x962890", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x962340", Offset = "0x962340", VA = "0x962340")]
			[DebuggerHidden]
			public <getVoices>c__Iterator3()
			{
			}

			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x9627AC", Offset = "0x9627AC", VA = "0x9627AC", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x962898", Offset = "0x962898", VA = "0x962898", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x9628AC", Offset = "0x9628AC", VA = "0x9628AC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000176")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DAD8", Offset = "0x29DAD8")]
		private sealed class <speak>c__Iterator4 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal object $current;

			[Token(Token = "0x40009DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal bool $disposing;

			[Token(Token = "0x40009DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal int $PC;

			[Token(Token = "0x1700012E")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A4B")]
				[Address(RVA = "0x962AB8", Offset = "0x962AB8", VA = "0x962AB8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A4C")]
				[Address(RVA = "0x962AC0", Offset = "0x962AC0", VA = "0x962AC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x9623B4", Offset = "0x9623B4", VA = "0x9623B4")]
			[DebuggerHidden]
			public <speak>c__Iterator4()
			{
			}

			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x962A58", Offset = "0x962A58", VA = "0x962A58", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x962AC8", Offset = "0x962AC8", VA = "0x962AC8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x962ADC", Offset = "0x962ADC", VA = "0x962ADC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<Voice> cachedVoices;

		[Token(Token = "0x4000185")]
		private const string extension = ".wav";

		[Token(Token = "0x17000027")]
		public override string AudioFileExtension
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x962098", Offset = "0x962098", VA = "0x962098", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public override List<Voice> Voices
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x9620F4", Offset = "0x9620F4", VA = "0x9620F4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x961F7C", Offset = "0x961F7C", VA = "0x961F7C")]
		public VoiceProviderWSA(MonoBehaviour obj)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x962180", Offset = "0x962180", VA = "0x962180", Slot = "8")]
		[DebuggerHidden]
		public override IEnumerator SpeakNative(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x962220", Offset = "0x962220", VA = "0x962220", Slot = "9")]
		[DebuggerHidden]
		public override IEnumerator Speak(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x9622C0", Offset = "0x9622C0", VA = "0x9622C0", Slot = "10")]
		[DebuggerHidden]
		public override IEnumerator Generate(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x962334", Offset = "0x962334", VA = "0x962334", Slot = "6")]
		public override void Silence()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x96202C", Offset = "0x96202C", VA = "0x96202C")]
		[DebuggerHidden]
		private IEnumerator getVoices()
		{
			return null;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x962348", Offset = "0x962348", VA = "0x962348")]
		[DebuggerHidden]
		private IEnumerator speak(Wrapper wrapper, bool isNative)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x9623BC", Offset = "0x9623BC", VA = "0x9623BC")]
		private string getVoiceName(Wrapper wrapper)
		{
			return null;
		}
	}
}
namespace Crosstales.RTVoice
{
	[Token(Token = "0x2000046")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29DB38", Offset = "0x29DB38")]
	public class Speaker : MonoBehaviour
	{
		[Token(Token = "0x2000047")]
		public delegate void VoicesReady();

		[Token(Token = "0x2000048")]
		public delegate void SpeakStart(Wrapper wrapper);

		[Token(Token = "0x2000049")]
		public delegate void SpeakComplete(Wrapper wrapper);

		[Token(Token = "0x200004A")]
		public delegate void SpeakCurrentWord(Wrapper wrapper, string[] speechTextArray, int wordIndex);

		[Token(Token = "0x200004B")]
		public delegate void SpeakCurrentPhoneme(Wrapper wrapper, string phoneme);

		[Token(Token = "0x200004C")]
		public delegate void SpeakCurrentViseme(Wrapper wrapper, string viseme);

		[Token(Token = "0x200004D")]
		public delegate void SpeakAudioGenerationStart(Wrapper wrapper);

		[Token(Token = "0x200004E")]
		public delegate void SpeakAudioGenerationComplete(Wrapper wrapper);

		[Token(Token = "0x200004F")]
		public delegate void ProviderChange(string provider);

		[Token(Token = "0x2000050")]
		public delegate void ErrorInfo(Wrapper wrapper, string info);

		[Token(Token = "0x2000177")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DF68", Offset = "0x29DF68")]
		private sealed class <VoicesForCulture>c__AnonStorey0
		{
			[Token(Token = "0x40009DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal string culture;

			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x81B8D8", Offset = "0x81B8D8", VA = "0x81B8D8")]
			public <VoicesForCulture>c__AnonStorey0()
			{
			}

			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x81B8E0", Offset = "0x81B8E0", VA = "0x81B8E0")]
			internal bool <>m__0(Voice s)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29DB90", Offset = "0x29DB90")]
		public bool MaryTTSMode;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29DBC4", Offset = "0x29DBC4")]
		public string MaryTTSUrl;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29DBF8", Offset = "0x29DBF8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29DBF8", Offset = "0x29DBF8")]
		public int MaryTTSPort;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29DC4C", Offset = "0x29DC4C")]
		public string MaryTTSUser;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29DC80", Offset = "0x29DC80")]
		public string MaryTTSPassword;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29DCB4", Offset = "0x29DCB4")]
		public MaryTTSType MaryTTSType;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29DCE8", Offset = "0x29DCE8")]
		public bool AutoClearTags;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29DD1C", Offset = "0x29DD1C")]
		public bool SilenceOnDisable;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29DD50", Offset = "0x29DD50")]
		public bool SilenceOnFocustLost;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29DD84", Offset = "0x29DD84")]
		public bool DontDestroy;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, AudioSource> removeSources;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float cleanUpTimer;

		[Token(Token = "0x4000192")]
		private const float cleanUpTime = 5f;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static BaseVoiceProvider voiceProvider;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static Speaker speaker;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool initalized;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static Dictionary<string, AudioSource> genericSources;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<string, AudioSource> providedSources;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static GameObject go;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool loggedVPIsNull;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private static bool loggedOnlyOneInstance;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static char[] splitCharWords;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int speakCounter;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static VoicesReady _onVoicesReady;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static SpeakStart _onSpeakStart;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static SpeakComplete _onSpeakComplete;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static SpeakCurrentWord _onSpeakCurrentWord;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static SpeakCurrentPhoneme _onSpeakCurrentPhoneme;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static SpeakCurrentViseme _onSpeakCurrentViseme;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static SpeakAudioGenerationStart _onSpeakAudioGenerationStart;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static SpeakAudioGenerationComplete _onSpeakAudioGenerationComplete;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static ProviderChange _onProviderChange;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static ErrorInfo _onErrorInfo;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DDB8", Offset = "0x29DDB8")]
		private static Func<Voice, string> <>f__am$cache0;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DDC8", Offset = "0x29DDC8")]
		private static Func<IGrouping<string, Voice>, Voice> <>f__mg$cache0;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DDD8", Offset = "0x29DDD8")]
		private static Func<Voice, string> <>f__am$cache1;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DDE8", Offset = "0x29DDE8")]
		private static Func<Voice, string> <>f__am$cache2;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DDF8", Offset = "0x29DDF8")]
		private static BaseVoiceProvider.VoicesReady <>f__mg$cache1;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DE08", Offset = "0x29DE08")]
		private static BaseVoiceProvider.SpeakStart <>f__mg$cache2;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DE18", Offset = "0x29DE18")]
		private static BaseVoiceProvider.SpeakComplete <>f__mg$cache3;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DE28", Offset = "0x29DE28")]
		private static BaseVoiceProvider.SpeakCurrentWord <>f__mg$cache4;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DE38", Offset = "0x29DE38")]
		private static BaseVoiceProvider.SpeakCurrentPhoneme <>f__mg$cache5;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DE48", Offset = "0x29DE48")]
		private static BaseVoiceProvider.SpeakCurrentViseme <>f__mg$cache6;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DE58", Offset = "0x29DE58")]
		private static BaseVoiceProvider.SpeakAudioGenerationStart <>f__mg$cache7;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DE68", Offset = "0x29DE68")]
		private static BaseVoiceProvider.SpeakAudioGenerationComplete <>f__mg$cache8;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DE78", Offset = "0x29DE78")]
		private static BaseVoiceProvider.ErrorInfo <>f__mg$cache9;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DE88", Offset = "0x29DE88")]
		private static BaseVoiceProvider.VoicesReady <>f__mg$cacheA;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DE98", Offset = "0x29DE98")]
		private static BaseVoiceProvider.SpeakStart <>f__mg$cacheB;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DEA8", Offset = "0x29DEA8")]
		private static BaseVoiceProvider.SpeakComplete <>f__mg$cacheC;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DEB8", Offset = "0x29DEB8")]
		private static BaseVoiceProvider.SpeakCurrentWord <>f__mg$cacheD;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DEC8", Offset = "0x29DEC8")]
		private static BaseVoiceProvider.SpeakCurrentPhoneme <>f__mg$cacheE;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DED8", Offset = "0x29DED8")]
		private static BaseVoiceProvider.SpeakCurrentViseme <>f__mg$cacheF;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DEE8", Offset = "0x29DEE8")]
		private static BaseVoiceProvider.SpeakAudioGenerationStart <>f__mg$cache10;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DEF8", Offset = "0x29DEF8")]
		private static BaseVoiceProvider.SpeakAudioGenerationComplete <>f__mg$cache11;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DF08", Offset = "0x29DF08")]
		private static BaseVoiceProvider.ErrorInfo <>f__mg$cache12;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DF18", Offset = "0x29DF18")]
		private static Func<Voice, string> <>f__am$cache3;

		[Token(Token = "0x17000029")]
		public static bool isMaryMode
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x941CF0", Offset = "0x941CF0", VA = "0x941CF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x93C03C", Offset = "0x93C03C", VA = "0x93C03C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public static string MaryUrl
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x962E18", Offset = "0x962E18", VA = "0x962E18")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x962F54", Offset = "0x962F54", VA = "0x962F54")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public static int MaryPort
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x963080", Offset = "0x963080", VA = "0x963080")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x9631B0", Offset = "0x9631B0", VA = "0x9631B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public static string MaryUser
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x9632DC", Offset = "0x9632DC", VA = "0x9632DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x96344C", Offset = "0x96344C", VA = "0x96344C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public static string MaryPassword
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x963578", Offset = "0x963578", VA = "0x963578")]
			private get
			{
				return null;
			}
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x9636E8", Offset = "0x9636E8", VA = "0x9636E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public static MaryTTSType MaryType
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x963814", Offset = "0x963814", VA = "0x963814")]
			private get
			{
				return default(MaryTTSType);
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x963944", Offset = "0x963944", VA = "0x963944")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public static bool isAutoClearTags
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x94DA4C", Offset = "0x94DA4C", VA = "0x94DA4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x963A70", Offset = "0x963A70", VA = "0x963A70")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public static bool isSilenceOnDisable
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x963B9C", Offset = "0x963B9C", VA = "0x963B9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x963CD4", Offset = "0x963CD4", VA = "0x963CD4")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public static bool isSilenceOnFocustLost
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x963E00", Offset = "0x963E00", VA = "0x963E00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x963F38", Offset = "0x963F38", VA = "0x963F38")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public static string AudioFileExtension
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x964064", Offset = "0x964064", VA = "0x964064")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public static List<Voice> Voices
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x93DD64", Offset = "0x93DD64", VA = "0x93DD64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public static List<string> Cultures
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x9415C4", Offset = "0x9415C4", VA = "0x9415C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public static bool isTTSAvailable
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x96435C", Offset = "0x96435C", VA = "0x96435C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000036")]
		public static bool isSpeaking
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x9644AC", Offset = "0x9644AC", VA = "0x9644AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1400000A")]
		public static event VoicesReady OnVoicesReady
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x93DB14", Offset = "0x93DB14", VA = "0x93DB14")]
			add
			{
			}
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x93E124", Offset = "0x93E124", VA = "0x93E124")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public static event SpeakStart OnSpeakStart
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x9394D0", Offset = "0x9394D0", VA = "0x9394D0")]
			add
			{
			}
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x939818", Offset = "0x939818", VA = "0x939818")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public static event SpeakComplete OnSpeakComplete
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x9395F8", Offset = "0x9395F8", VA = "0x9395F8")]
			add
			{
			}
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x939940", Offset = "0x939940", VA = "0x939940")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public static event SpeakCurrentWord OnSpeakCurrentWord
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x945BF8", Offset = "0x945BF8", VA = "0x945BF8")]
			add
			{
			}
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x946414", Offset = "0x946414", VA = "0x946414")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public static event SpeakCurrentPhoneme OnSpeakCurrentPhoneme
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x945D20", Offset = "0x945D20", VA = "0x945D20")]
			add
			{
			}
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x94653C", Offset = "0x94653C", VA = "0x94653C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public static event SpeakCurrentViseme OnSpeakCurrentViseme
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x945E48", Offset = "0x945E48", VA = "0x945E48")]
			add
			{
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x946664", Offset = "0x946664", VA = "0x946664")]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public static event SpeakAudioGenerationStart OnSpeakAudioGenerationStart
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x945AD0", Offset = "0x945AD0", VA = "0x945AD0")]
			add
			{
			}
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x9462EC", Offset = "0x9462EC", VA = "0x9462EC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public static event SpeakAudioGenerationComplete OnSpeakAudioGenerationComplete
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x94494C", Offset = "0x94494C", VA = "0x94494C")]
			add
			{
			}
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x944C14", Offset = "0x944C14", VA = "0x944C14")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public static event ProviderChange OnProviderChange
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x94149C", Offset = "0x94149C", VA = "0x94149C")]
			add
			{
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x943138", Offset = "0x943138", VA = "0x943138")]
			remove
			{
			}
		}

		[Token(Token = "0x14000013")]
		public static event ErrorInfo OnErrorInfo
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x93DC3C", Offset = "0x93DC3C", VA = "0x93DC3C")]
			add
			{
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x93E24C", Offset = "0x93E24C", VA = "0x93E24C")]
			remove
			{
			}
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x962C88", Offset = "0x962C88", VA = "0x962C88")]
		public Speaker()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x964544", Offset = "0x964544", VA = "0x964544")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x965A48", Offset = "0x965A48", VA = "0x965A48")]
		public void Update()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x966718", Offset = "0x966718", VA = "0x966718")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x9667A0", Offset = "0x9667A0", VA = "0x9667A0")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x967280", Offset = "0x967280", VA = "0x967280")]
		public void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x967490", Offset = "0x967490", VA = "0x967490")]
		public void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x967540", Offset = "0x967540", VA = "0x967540")]
		public static float ApproximateSpeechLength(string text, float rate = 1f, float wordsPerMinute = 175f, float timeFactor = 0.9f)
		{
			return default(float);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x967CC0", Offset = "0x967CC0", VA = "0x967CC0")]
		public static bool isVoiceForCultureAvailable(string culture)
		{
			return default(bool);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x943B90", Offset = "0x943B90", VA = "0x943B90")]
		public static List<Voice> VoicesForCulture(string culture)
		{
			return null;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x93A8A4", Offset = "0x93A8A4", VA = "0x93A8A4")]
		public static Voice VoiceForCulture(string culture, int index = 0, string fallbackCulture = "")
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x967D78", Offset = "0x967D78", VA = "0x967D78")]
		public static bool isVoiceForNameAvailable(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x94B748", Offset = "0x94B748", VA = "0x94B748")]
		public static Voice VoiceForName(string name)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x9443DC", Offset = "0x9443DC", VA = "0x9443DC")]
		public static string SpeakNative(string text, [Optional] Voice voice, float rate = 1f, float pitch = 1f, float volume = 1f)
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x967E00", Offset = "0x967E00", VA = "0x967E00")]
		public static void SpeakNativeWithUID(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x94AF70", Offset = "0x94AF70", VA = "0x94AF70")]
		public static string SpeakNative(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x93B008", Offset = "0x93B008", VA = "0x93B008")]
		public static string Speak(string text, [Optional] AudioSource source, [Optional] Voice voice, bool speakImmediately = true, float rate = 1f, float pitch = 1f, float volume = 1f, string outputFile = "")
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x9684A8", Offset = "0x9684A8", VA = "0x9684A8")]
		public static void SpeakWithUID(Wrapper wrapper)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x94BC7C", Offset = "0x94BC7C", VA = "0x94BC7C")]
		public static string Speak(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x946EC4", Offset = "0x946EC4", VA = "0x946EC4")]
		public static void SpeakMarkedWordsWithUID(Wrapper wrapper)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x968A94", Offset = "0x968A94", VA = "0x968A94")]
		public static void SpeakMarkedWordsWithUID(string uid, string text, AudioSource source, [Optional] Voice voice, float rate = 1f, float pitch = 1f)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x968BC4", Offset = "0x968BC4", VA = "0x968BC4")]
		public static string Generate(Wrapper wrapper)
		{
			return null;
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x968E20", Offset = "0x968E20", VA = "0x968E20")]
		public static string Generate(string text, string outputFile, [Optional] Voice voice, float rate = 1f, float pitch = 1f, float volume = 1f)
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x93CE04", Offset = "0x93CE04", VA = "0x93CE04")]
		public static void Silence()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x968F08", Offset = "0x968F08", VA = "0x968F08")]
		public static void Silence(string uid)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x962D9C", Offset = "0x962D9C", VA = "0x962D9C")]
		public static void ReloadProvider()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x965584", Offset = "0x965584", VA = "0x965584")]
		private static void initProvider()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x969434", Offset = "0x969434", VA = "0x969434")]
		private static void initOSProvider()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x9683DC", Offset = "0x9683DC", VA = "0x9683DC")]
		private static void logWrapperIsNull()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x9641BC", Offset = "0x9641BC", VA = "0x9641BC")]
		private static void logVPIsNull()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x9698A0", Offset = "0x9698A0", VA = "0x9698A0")]
		private static void onVoicesReady()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x969984", Offset = "0x969984", VA = "0x969984")]
		private static void onSpeakStart(Wrapper wrapper)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x969ABC", Offset = "0x969ABC", VA = "0x969ABC")]
		private static void onSpeakComplete(Wrapper wrapper)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x969BF4", Offset = "0x969BF4", VA = "0x969BF4")]
		private static void onSpeakCurrentWord(Wrapper wrapper, string[] speechTextArray, int wordIndex)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x969CFC", Offset = "0x969CFC", VA = "0x969CFC")]
		private static void onSpeakCurrentPhoneme(Wrapper wrapper, string phoneme)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x969DF0", Offset = "0x969DF0", VA = "0x969DF0")]
		private static void onSpeakCurrentViseme(Wrapper wrapper, string viseme)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x969EE4", Offset = "0x969EE4", VA = "0x969EE4")]
		private static void onSpeakAudioGenerationStart(Wrapper wrapper)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x969FD0", Offset = "0x969FD0", VA = "0x969FD0")]
		private static void onSpeakAudioGenerationComplete(Wrapper wrapper)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x9697AC", Offset = "0x9697AC", VA = "0x9697AC")]
		private static void onErrorInfo(Wrapper wrapper, string errorInfo)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x96A210", Offset = "0x96A210", VA = "0x96A210")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DF28", Offset = "0x29DF28")]
		private static string <get_Voices>m__0(Voice s)
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x96A230", Offset = "0x96A230", VA = "0x96A230")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DF38", Offset = "0x29DF38")]
		private static string <get_Cultures>m__1(Voice cul)
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x96A250", Offset = "0x96A250", VA = "0x96A250")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DF48", Offset = "0x29DF48")]
		private static string <get_Cultures>m__2(Voice s)
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x96A270", Offset = "0x96A270", VA = "0x96A270")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29DF58", Offset = "0x29DF58")]
		private static string <VoicesForCulture>m__3(Voice s)
		{
			return null;
		}
	}
}
namespace Crosstales.RTVoice.Tool
{
	[Token(Token = "0x2000051")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29DF78", Offset = "0x29DF78")]
	public class AudioFileGenerator : MonoBehaviour
	{
		[Token(Token = "0x2000178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29E038", Offset = "0x29E038")]
		private sealed class <generate>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal TextAsset[] $locvar0;

			[Token(Token = "0x40009DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal int $locvar1;

			[Token(Token = "0x40009DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal TextAsset <textFile>__1;

			[Token(Token = "0x40009E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal List<string> <speeches>__2;

			[Token(Token = "0x40009E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal List<string>.Enumerator $locvar2;

			[Token(Token = "0x40009E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal string <speech>__3;

			[Token(Token = "0x40009E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal string[] <args>__4;

			[Token(Token = "0x40009E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Wrapper <wrapper>__5;

			[Token(Token = "0x40009E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal string <uid>__5;

			[Token(Token = "0x40009E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal AudioFileGenerator $this;

			[Token(Token = "0x40009E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal object $current;

			[Token(Token = "0x40009E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal bool $disposing;

			[Token(Token = "0x40009E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal int $PC;

			[Token(Token = "0x17000130")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A53")]
				[Address(RVA = "0x81F1A4", Offset = "0x81F1A4", VA = "0x81F1A4", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000131")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A54")]
				[Address(RVA = "0x81F1AC", Offset = "0x81F1AC", VA = "0x81F1AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x81E460", Offset = "0x81E460", VA = "0x81E460")]
			[DebuggerHidden]
			public <generate>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x81EB44", Offset = "0x81EB44", VA = "0x81EB44", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x81F1B4", Offset = "0x81F1B4", VA = "0x81F1B4", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x81F240", Offset = "0x81F240", VA = "0x81F240", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29DFC0", Offset = "0x29DFC0")]
		public TextAsset[] TextFiles;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29DFF4", Offset = "0x29DFF4")]
		public bool FileInsideAssets;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static char[] splitChar;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private string lastUid;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isGenerate;

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x81E070", Offset = "0x81E070", VA = "0x81E070")]
		public AudioFileGenerator()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x81E118", Offset = "0x81E118", VA = "0x81E118")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x81E21C", Offset = "0x81E21C", VA = "0x81E21C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x81E320", Offset = "0x81E320", VA = "0x81E320")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x81E324", Offset = "0x81E324", VA = "0x81E324")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x81E3E0", Offset = "0x81E3E0", VA = "0x81E3E0")]
		[DebuggerHidden]
		public IEnumerator generate()
		{
			return null;
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x81E468", Offset = "0x81E468", VA = "0x81E468")]
		private void convert(string outputFile)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x81E46C", Offset = "0x81E46C", VA = "0x81E46C")]
		private Wrapper prepare(string[] args, string speech)
		{
			return null;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x81E950", Offset = "0x81E950", VA = "0x81E950")]
		private void onVoicesReady()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x81E954", Offset = "0x81E954", VA = "0x81E954")]
		private void onSpeakAudioGenerationComplete(Wrapper wrapper)
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x29E098", Offset = "0x29E098")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29E098", Offset = "0x29E098")]
	public class Loudspeaker : MonoBehaviour
	{
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E138", Offset = "0x29E138")]
		public AudioSource Source;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E16C", Offset = "0x29E16C")]
		public bool Synchronized;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E1A0", Offset = "0x29E1A0")]
		public bool SilenceSource;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private AudioSource audioSource;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool stopped;

		[Token(Token = "0x17000037")]
		public bool isSynchronized
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x81F2D8", Offset = "0x81F2D8", VA = "0x81F2D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x81F2E0", Offset = "0x81F2E0", VA = "0x81F2E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool isSilenceSource
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x81F2E8", Offset = "0x81F2E8", VA = "0x81F2E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x81F2F0", Offset = "0x81F2F0", VA = "0x81F2F0")]
			set
			{
			}
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x81F2C4", Offset = "0x81F2C4", VA = "0x81F2C4")]
		public Loudspeaker()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x81F2F8", Offset = "0x81F2F8", VA = "0x81F2F8")]
		public void Awake()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x81F39C", Offset = "0x81F39C", VA = "0x81F39C")]
		public void Start()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x81F47C", Offset = "0x81F47C", VA = "0x81F47C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x81F6D0", Offset = "0x81F6D0", VA = "0x81F6D0")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x81F844", Offset = "0x81F844", VA = "0x81F844")]
		public void OnDisable()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29E1D4", Offset = "0x29E1D4")]
	public class Sequencer : MonoBehaviour
	{
		[Token(Token = "0x2000179")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29E2E8", Offset = "0x29E2E8")]
		private sealed class <playMe>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Sequence seq;

			[Token(Token = "0x40009EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Voice <voice>__0;

			[Token(Token = "0x40009EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Sequencer $this;

			[Token(Token = "0x40009ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal object $current;

			[Token(Token = "0x40009EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal bool $disposing;

			[Token(Token = "0x40009EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal int $PC;

			[Token(Token = "0x17000132")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A59")]
				[Address(RVA = "0x820430", Offset = "0x820430", VA = "0x820430", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000133")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A5A")]
				[Address(RVA = "0x820438", Offset = "0x820438", VA = "0x820438", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x820014", Offset = "0x820014", VA = "0x820014")]
			[DebuggerHidden]
			public <playMe>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x82001C", Offset = "0x82001C", VA = "0x82001C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x820440", Offset = "0x820440", VA = "0x820440", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x820454", Offset = "0x820454", VA = "0x820454", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E208", Offset = "0x29E208")]
		public Sequence[] Sequences;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E23C", Offset = "0x29E23C")]
		public string Culture;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E270", Offset = "0x29E270")]
		public float Delay;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E2A4", Offset = "0x29E2A4")]
		public bool PlayOnStart;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int currentIndex;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string uidCurrentSpeaker;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool playAllSequences;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		private bool played;

		[Token(Token = "0x17000039")]
		public string CurrentCulture
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x81F8A0", Offset = "0x81F8A0", VA = "0x81F8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x81F8A8", Offset = "0x81F8A8", VA = "0x81F8A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public Sequence CurrentSequence
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x81F8B0", Offset = "0x81F8B0", VA = "0x81F8B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x81F898", Offset = "0x81F898", VA = "0x81F898")]
		public Sequencer()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x81F8F0", Offset = "0x81F8F0", VA = "0x81F8F0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x81FAEC", Offset = "0x81FAEC", VA = "0x81FAEC")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x81FBF0", Offset = "0x81FBF0", VA = "0x81FBF0")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x81FC74", Offset = "0x81FC74", VA = "0x81FC74")]
		public void PlaySequence(int index = 0)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x81FEB8", Offset = "0x81FEB8", VA = "0x81FEB8")]
		public void PlayNextSequence()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x81FEC0", Offset = "0x81FEC0", VA = "0x81FEC0")]
		public void PlayAllSequences()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x81FEE8", Offset = "0x81FEE8", VA = "0x81FEE8")]
		public void StopAllSequences()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x81FF80", Offset = "0x81FF80", VA = "0x81FF80")]
		private void speakCompleteMethod(Wrapper wrapper)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x820010", Offset = "0x820010", VA = "0x820010")]
		private void onVoicesReady()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x81F9FC", Offset = "0x81F9FC", VA = "0x81F9FC")]
		private void play()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x81FE20", Offset = "0x81FE20", VA = "0x81FE20")]
		[DebuggerHidden]
		private IEnumerator playMe(Sequence seq)
		{
			return null;
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29E348", Offset = "0x29E348")]
	public class SpeechText : MonoBehaviour
	{
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E37C", Offset = "0x29E37C")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0x29E37C", Offset = "0x29E37C")]
		public string Text;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E3C4", Offset = "0x29E3C4")]
		public string RTVoiceNameWindows;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E3F8", Offset = "0x29E3F8")]
		public string RTVoiceNameMac;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E42C", Offset = "0x29E42C")]
		public string RTVoiceNameAndroid;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E460", Offset = "0x29E460")]
		public string RTVoiceNameIOS;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E494", Offset = "0x29E494")]
		public string RTVoiceNameWSA;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E4C8", Offset = "0x29E4C8")]
		public string RTVoiceNameMaryTTS;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E4FC", Offset = "0x29E4FC")]
		public SpeakMode Mode;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29E530", Offset = "0x29E530")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E530", Offset = "0x29E530")]
		public string Culture;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E590", Offset = "0x29E590")]
		public AudioSource Source;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E5C4", Offset = "0x29E5C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29E5C4", Offset = "0x29E5C4")]
		public float Rate;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E618", Offset = "0x29E618")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29E618", Offset = "0x29E618")]
		public float Pitch;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E668", Offset = "0x29E668")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29E668", Offset = "0x29E668")]
		public float Volume;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29E6B8", Offset = "0x29E6B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E6B8", Offset = "0x29E6B8")]
		public bool PlayOnStart;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E718", Offset = "0x29E718")]
		public float Delay;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29E74C", Offset = "0x29E74C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E74C", Offset = "0x29E74C")]
		public bool GenerateAudioFile;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E7AC", Offset = "0x29E7AC")]
		public string FilePath;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E7E0", Offset = "0x29E7E0")]
		public string FileName;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E814", Offset = "0x29E814")]
		public bool FileInsideAssets;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string uid;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool played;

		[Token(Token = "0x1700003B")]
		public string CurrentText
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x82064C", Offset = "0x82064C", VA = "0x82064C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x820654", Offset = "0x820654", VA = "0x820654")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public string CurrentCulture
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x82065C", Offset = "0x82065C", VA = "0x82065C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x820664", Offset = "0x820664", VA = "0x820664")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public float CurrentRate
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x82066C", Offset = "0x82066C", VA = "0x82066C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x820674", Offset = "0x820674", VA = "0x820674")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public float CurrentPitch
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x82067C", Offset = "0x82067C", VA = "0x82067C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x820684", Offset = "0x820684", VA = "0x820684")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public float CurrentVolume
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x82068C", Offset = "0x82068C", VA = "0x82068C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x820694", Offset = "0x820694", VA = "0x820694")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public string RTVoiceName
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x82069C", Offset = "0x82069C", VA = "0x82069C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x8204D8", Offset = "0x8204D8", VA = "0x8204D8")]
		public SpeechText()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x820850", Offset = "0x820850", VA = "0x820850")]
		public void Start()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x820A10", Offset = "0x820A10", VA = "0x820A10")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x820AD0", Offset = "0x820AD0", VA = "0x820AD0")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x820C4C", Offset = "0x820C4C", VA = "0x820C4C")]
		public void Speak()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x821034", Offset = "0x821034", VA = "0x821034")]
		public void Silence()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x820918", Offset = "0x820918", VA = "0x820918")]
		private void play()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x82113C", Offset = "0x82113C", VA = "0x82113C")]
		private void onVoicesReady()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29E848", Offset = "0x29E848")]
	public class TextFileSpeaker : MonoBehaviour
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E87C", Offset = "0x29E87C")]
		public TextAsset[] TextFiles;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E8B0", Offset = "0x29E8B0")]
		public string RTVoiceNameWindows;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E8E4", Offset = "0x29E8E4")]
		public string RTVoiceNameMac;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E918", Offset = "0x29E918")]
		public string RTVoiceNameAndroid;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E94C", Offset = "0x29E94C")]
		public string RTVoiceNameIOS;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E980", Offset = "0x29E980")]
		public string RTVoiceNameWSA;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E9B4", Offset = "0x29E9B4")]
		public string RTVoiceNameMaryTTS;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29E9E8", Offset = "0x29E9E8")]
		public SpeakMode Mode;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29EA1C", Offset = "0x29EA1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29EA1C", Offset = "0x29EA1C")]
		public bool PlayOnStart;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29EA7C", Offset = "0x29EA7C")]
		public float Delay;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x29EAB0", Offset = "0x29EAB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29EAB0", Offset = "0x29EAB0")]
		public string Culture;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29EB10", Offset = "0x29EB10")]
		public AudioSource Source;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29EB44", Offset = "0x29EB44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29EB44", Offset = "0x29EB44")]
		public float Rate;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29EB98", Offset = "0x29EB98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29EB98", Offset = "0x29EB98")]
		public float Pitch;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29EBE8", Offset = "0x29EBE8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29EBE8", Offset = "0x29EBE8")]
		public float Volume;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Random rnd;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string uid;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool played;

		[Token(Token = "0x17000041")]
		public string CurrentCulture
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x821268", Offset = "0x821268", VA = "0x821268")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x821270", Offset = "0x821270", VA = "0x821270")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public float CurrentRate
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x821278", Offset = "0x821278", VA = "0x821278")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x821280", Offset = "0x821280", VA = "0x821280")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public float CurrentPitch
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x821288", Offset = "0x821288", VA = "0x821288")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x821290", Offset = "0x821290", VA = "0x821290")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public float CurrentVolume
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x821298", Offset = "0x821298", VA = "0x821298")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x8212A0", Offset = "0x8212A0", VA = "0x8212A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public string RTVoiceName
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x8212A8", Offset = "0x8212A8", VA = "0x8212A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x821140", Offset = "0x821140", VA = "0x821140")]
		public TextFileSpeaker()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x82145C", Offset = "0x82145C", VA = "0x82145C")]
		public void Start()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x82161C", Offset = "0x82161C", VA = "0x82161C")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x8216DC", Offset = "0x8216DC", VA = "0x8216DC")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x821780", Offset = "0x821780", VA = "0x821780")]
		public void Speak()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x8218AC", Offset = "0x8218AC", VA = "0x8218AC")]
		public string SpeakText(int index = -1)
		{
			return null;
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x8217A4", Offset = "0x8217A4", VA = "0x8217A4")]
		public void Silence()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x821524", Offset = "0x821524", VA = "0x821524")]
		private void play()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x822244", Offset = "0x822244", VA = "0x822244")]
		private void onVoicesReady()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x29EC38", Offset = "0x29EC38")]
	public class VoiceInitalizer : MonoBehaviour
	{
		[Token(Token = "0x200017A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29ED4C", Offset = "0x29ED4C")]
		private sealed class <initalizeVoices>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal List<Voice>.Enumerator $locvar0;

			[Token(Token = "0x40009F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Voice <voice>__1;

			[Token(Token = "0x40009F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal string[] $locvar1;

			[Token(Token = "0x40009F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int $locvar2;

			[Token(Token = "0x40009F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal string <voiceName>__2;

			[Token(Token = "0x40009F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Voice <voice>__3;

			[Token(Token = "0x40009F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal VoiceInitalizer $this;

			[Token(Token = "0x40009F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal object $current;

			[Token(Token = "0x40009F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal bool $disposing;

			[Token(Token = "0x40009F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal int $PC;

			[Token(Token = "0x17000134")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A5F")]
				[Address(RVA = "0x822F30", Offset = "0x822F30", VA = "0x822F30", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000135")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A60")]
				[Address(RVA = "0x822F38", Offset = "0x822F38", VA = "0x822F38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x82272C", Offset = "0x82272C", VA = "0x82272C")]
			[DebuggerHidden]
			public <initalizeVoices>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x8229D4", Offset = "0x8229D4", VA = "0x8229D4", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x822F40", Offset = "0x822F40", VA = "0x822F40", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x822FC0", Offset = "0x822FC0", VA = "0x822FC0", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29EC6C", Offset = "0x29EC6C")]
		public ProviderType Provider;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29ECA0", Offset = "0x29ECA0")]
		public string[] VoiceNames;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29ECD4", Offset = "0x29ECD4")]
		public bool AllVoices;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29ED08", Offset = "0x29ED08")]
		public bool DestroyWhenFinished;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string activeUid;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private string completedUid;

		[Token(Token = "0x40001FD")]
		private const string text = "crosstales";

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x8222C8", Offset = "0x8222C8", VA = "0x8222C8")]
		public VoiceInitalizer()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x822394", Offset = "0x822394", VA = "0x822394")]
		public void Start()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x8224A4", Offset = "0x8224A4", VA = "0x8224A4")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x8225A8", Offset = "0x8225A8", VA = "0x8225A8")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x8226AC", Offset = "0x8226AC", VA = "0x8226AC")]
		[DebuggerHidden]
		private IEnumerator initalizeVoices()
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x822734", Offset = "0x822734", VA = "0x822734")]
		private void onVoicesReady()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x8229AC", Offset = "0x8229AC", VA = "0x8229AC")]
		private void onSpeakComplete(Wrapper wrapper)
		{
		}
	}
}
namespace Crosstales.RTVoice.Util
{
	[Token(Token = "0x2000057")]
	public static class Config
	{
		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string ASSET_PATH;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static bool DEBUG;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string AUDIOFILE_PATH;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static bool AUDIOFILE_AUTOMATIC_DELETE;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public static bool ENFORCE_32BIT_WINDOWS;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string TTS_WINDOWS_BUILD;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static string TTS_MACOS;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool isLoaded;

		[Token(Token = "0x17000046")]
		public static string TTS_WINDOWS_EDITOR
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x823044", Offset = "0x823044", VA = "0x823044")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public static string TTS_WINDOWS_EDITOR_x86
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x823154", Offset = "0x823154", VA = "0x823154")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x823264", Offset = "0x823264", VA = "0x823264")]
		public static void Reset()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x8233A4", Offset = "0x8233A4", VA = "0x8233A4")]
		public static void Load()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x8236DC", Offset = "0x8236DC", VA = "0x8236DC")]
		public static void Save()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public abstract class Constants : BaseConstants
	{
		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly bool isPro;

		[Token(Token = "0x4000207")]
		public const string ASSET_NAME = "RTVoice PRO";

		[Token(Token = "0x4000208")]
		public const string ASSET_VERSION = "2.9.5";

		[Token(Token = "0x4000209")]
		public const int ASSET_BUILD = 295;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly DateTime ASSET_CREATED;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly DateTime ASSET_CHANGED;

		[Token(Token = "0x400020C")]
		public const string ASSET_PRO_URL = "https://www.assetstore.unity3d.com/#!/content/41068?aid=1011lNGT&pubref=RTVoice PRO";

		[Token(Token = "0x400020D")]
		public const string ASSET_3P_URL = "https://www.assetstore.unity3d.com/#!/list/42209-rt-voice-friends?aid=1011lNGT&pubref=RTVoice PRO";

		[Token(Token = "0x400020E")]
		public const string ASSET_UPDATE_CHECK_URL = "https://www.crosstales.com/media/assets/rtvoice_versions.txt";

		[Token(Token = "0x400020F")]
		public const string ASSET_CONTACT = "rtvoice@crosstales.com";

		[Token(Token = "0x4000210")]
		public const string ASSET_MANUAL_URL = "https://www.crosstales.com/media/data/assets/rtvoice/RTVoice-doc.pdf";

		[Token(Token = "0x4000211")]
		public const string ASSET_API_URL = "http://goo.gl/6w4Fy0";

		[Token(Token = "0x4000212")]
		public const string ASSET_FORUM_URL = "http://goo.gl/Z6MZMl";

		[Token(Token = "0x4000213")]
		public const string ASSET_WEB_URL = "https://www.crosstales.com/en/portfolio/rtvoice/";

		[Token(Token = "0x4000214")]
		public const string ASSET_VIDEO_PROMO = "https://youtu.be/iVhTWDLY7g8?list=PLgtonIOr6Tb41XTMeeZ836tjHlKgOO84S";

		[Token(Token = "0x4000215")]
		public const string ASSET_VIDEO_TUTORIAL = "https://youtu.be/OJyVgCmX3wU?list=PLgtonIOr6Tb41XTMeeZ836tjHlKgOO84S";

		[Token(Token = "0x4000216")]
		public const string ASSET_3P_ADVENTURE_CREATOR = "https://www.assetstore.unity3d.com/#!/content/11896?aid=1011lNGT&pubref=RTVoice PRO";

		[Token(Token = "0x4000217")]
		public const string ASSET_3P_CINEMA_DIRECTOR = "https://www.assetstore.unity3d.com/#!/content/19779?aid=1011lNGT&pubref=RTVoice PRO";

		[Token(Token = "0x4000218")]
		public const string ASSET_3P_DIALOG_SYSTEM = "https://www.assetstore.unity3d.com/#!/content/11672?aid=1011lNGT&pubref=RTVoice PRO";

		[Token(Token = "0x4000219")]
		public const string ASSET_3P_LOCALIZED_DIALOGS = "https://www.assetstore.unity3d.com/#!/content/5020?aid=1011lNGT&pubref=RTVoice PRO";

		[Token(Token = "0x400021A")]
		public const string ASSET_3P_LIPSYNC = "https://www.assetstore.unity3d.com/#!/content/32117?aid=1011lNGT&pubref=RTVoice PRO";

		[Token(Token = "0x400021B")]
		public const string ASSET_3P_NPC_CHAT = "https://www.assetstore.unity3d.com/#!/content/9723?aid=1011lNGT&pubref=RTVoice PRO";

		[Token(Token = "0x400021C")]
		public const string ASSET_3P_QUEST_SYSTEM = "https://www.assetstore.unity3d.com/#!/content/63460?aid=1011lNGT&pubref=RTVoice PRO";

		[Token(Token = "0x400021D")]
		public const string ASSET_3P_SALSA = "https://www.assetstore.unity3d.com/#!/content/16944?aid=1011lNGT&pubref=RTVoice PRO";

		[Token(Token = "0x400021E")]
		public const string ASSET_3P_SLATE = "https://www.assetstore.unity3d.com/#!/content/56558?aid=1011lNGT&pubref=RTVoice PRO";

		[Token(Token = "0x400021F")]
		public const string ASSET_3P_DIALOGUE_ENGINE = "https://www.assetstore.unity3d.com/#!/content/42467?aid=1011lNGT&pubref=RTVoice PRO";

		[Token(Token = "0x4000220")]
		public const string ASSET_3P_USEQUENCER = "https://www.assetstore.unity3d.com/#!/content/3666?aid=1011lNGT&pubref=RTVoice PRO";

		[Token(Token = "0x4000221")]
		public const string KEY_PREFIX = "RTVOICE_CFG_";

		[Token(Token = "0x4000222")]
		public const string KEY_ASSET_PATH = "RTVOICE_CFG_ASSET_PATH";

		[Token(Token = "0x4000223")]
		public const string KEY_DEBUG = "RTVOICE_CFG_DEBUG";

		[Token(Token = "0x4000224")]
		public const string KEY_AUDIOFILE_PATH = "RTVOICE_CFG_AUDIOFILE_PATH";

		[Token(Token = "0x4000225")]
		public const string KEY_AUDIOFILE_AUTOMATIC_DELETE = "RTVOICE_CFG_AUDIOFILE_AUTOMATIC_DELETE";

		[Token(Token = "0x4000226")]
		public const string KEY_ENFORCE_32BIT_WINDOWS = "RTVOICE_CFG_ENFORCE_32BIT_WINDOWS";

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly string DEFAULT_AUDIOFILE_PATH;

		[Token(Token = "0x4000228")]
		public const bool DEFAULT_AUDIOFILE_AUTOMATIC_DELETE = true;

		[Token(Token = "0x4000229")]
		public const bool DEFAULT_ENFORCE_32BIT_WINDOWS = false;

		[Token(Token = "0x400022A")]
		public const string DEFAULT_TTS_WINDOWS_BUILD = "/RTVoiceTTSWrapper.exe";

		[Token(Token = "0x400022B")]
		public const string DEFAULT_TTS_MACOS = "say";

		[Token(Token = "0x400022C")]
		public const int DEFAULT_TTS_KILL_TIME = 7000;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static string TTS_WINDOWS_SUBPATH;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string TTS_WINDOWS_x86_SUBPATH;

		[Token(Token = "0x400022F")]
		public const string RTVOICE_SCENE_OBJECT_NAME = "RTVoice";

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x823950", Offset = "0x823950", VA = "0x823950")]
		protected Constants()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public abstract class Helper : BaseHelper
	{
		[Token(Token = "0x17000048")]
		public static bool hasBuiltInTTS
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x823B98", Offset = "0x823B98", VA = "0x823B98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		public static ProviderType CurrentProviderType
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x822810", Offset = "0x822810", VA = "0x822810")]
			get
			{
				return default(ProviderType);
			}
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x823B14", Offset = "0x823B14", VA = "0x823B14")]
		protected Helper()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x823D24", Offset = "0x823D24", VA = "0x823D24")]
		public static string CleanText(string text, bool removeTags = true, bool clearSpaces = true, bool clearLineEndings = true)
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x823E58", Offset = "0x823E58", VA = "0x823E58")]
		public static string MarkSpokenText(string[] speechTextArray, int wordIndex, bool markAllSpokenWords = false, string markPrefix = "<color=green><b>", string markPostfix = "</b></color>")
		{
			return null;
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x200005A")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AimIK aimIK;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform pin;

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x8341B4", Offset = "0x8341B4", VA = "0x8341B4")]
		public AimBoxing()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x8341BC", Offset = "0x8341BC", VA = "0x8341BC")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AimIK ik;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29EDAC", Offset = "0x29EDAC")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x834298", Offset = "0x834298", VA = "0x834298")]
		public AimSwing()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x834340", Offset = "0x834340", VA = "0x834340")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29EDE0", Offset = "0x29EDE0")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29EE14", Offset = "0x29EE14")]
		public AimIK aim;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29EE48", Offset = "0x29EE48")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29EE7C", Offset = "0x29EE7C")]
		public Animator animator;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29EEB0", Offset = "0x29EEB0")]
		public float crossfadeTime;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29EEE4", Offset = "0x29EEE4")]
		public float minAimDistance;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x84CFE4", Offset = "0x84CFE4", VA = "0x84CFE4")]
		public SimpleAimingSystem()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x84D000", Offset = "0x84D000", VA = "0x84D000")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x84D050", Offset = "0x84D050", VA = "0x84D050")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x84D210", Offset = "0x84D210", VA = "0x84D210")]
		private void Pose()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x84D4B8", Offset = "0x84D4B8", VA = "0x84D4B8")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x84D750", Offset = "0x84D750", VA = "0x84D750")]
		private void DirectCrossFade(string state, float target)
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AimIK aimIK;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 raycastOffset;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float min;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float max;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float lerpSpeed;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private RaycastHit hit;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 offset;

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xBE19D0", Offset = "0xBE19D0", VA = "0xBE19D0")]
		public TerrainOffset()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xBE1A48", Offset = "0xBE1A48", VA = "0xBE1A48")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xBE1D78", Offset = "0xBE1D78", VA = "0xBE1D78")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200005E")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x29EF18", Offset = "0x29EF18")]
		public Animator animator;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x29EF4C", Offset = "0x29EF4C")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29EF80", Offset = "0x29EF80")]
		public float lookAtWeight;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29EF98", Offset = "0x29EF98")]
		public float lookAtBodyWeight;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29EFB0", Offset = "0x29EFB0")]
		public float lookAtHeadWeight;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29EFC8", Offset = "0x29EFC8")]
		public float lookAtEyesWeight;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29EFE0", Offset = "0x29EFE0")]
		public float lookAtClampWeight;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29EFF8", Offset = "0x29EFF8")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29F010", Offset = "0x29F010")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x29F028", Offset = "0x29F028")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29F05C", Offset = "0x29F05C")]
		public float footPositionWeight;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29F074", Offset = "0x29F074")]
		public float footRotationWeight;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x29F08C", Offset = "0x29F08C")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29F0C0", Offset = "0x29F0C0")]
		public float handPositionWeight;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29F0D8", Offset = "0x29F0D8")]
		public float handRotationWeight;

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x836D28", Offset = "0x836D28", VA = "0x836D28")]
		public BipedIKvsAnimatorIK()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x836D54", Offset = "0x836D54", VA = "0x836D54")]
		private void OnAnimatorIK(int layer)
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float scale;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform body;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float legRotationWeight;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rootPositionSpeed;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rootRotationSpeed;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float breatheSpeed;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float breatheMagnitude;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float height;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minHeight;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float raycastHeight;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float raycastDistance;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float sine;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private RaycastHit rootHit;

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x845250", Offset = "0x845250", VA = "0x845250")]
		public MechSpider()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x8452B4", Offset = "0x8452B4", VA = "0x8452B4")]
		private void Update()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x846100", Offset = "0x846100", VA = "0x846100")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x845C84", Offset = "0x845C84", VA = "0x845C84")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000060")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform cameraTransform;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float speed;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float turnSpeed;

		[Token(Token = "0x1700004A")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x846354", Offset = "0x846354", VA = "0x846354")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x846334", Offset = "0x846334", VA = "0x846334")]
		public MechSpiderController()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x846438", Offset = "0x846438", VA = "0x846438")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x200017B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29F100", Offset = "0x29F100")]
		private sealed class <Step>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x40009FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Vector3 stepStartPosition;

			[Token(Token = "0x40009FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal Vector3 targetPosition;

			[Token(Token = "0x40009FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal MechSpiderLeg $this;

			[Token(Token = "0x40009FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal object $current;

			[Token(Token = "0x40009FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal bool $disposing;

			[Token(Token = "0x40009FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal int $PC;

			[Token(Token = "0x17000136")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A65")]
				[Address(RVA = "0x847A5C", Offset = "0x847A5C", VA = "0x847A5C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000137")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A66")]
				[Address(RVA = "0x847A64", Offset = "0x847A64", VA = "0x847A64", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x847484", Offset = "0x847484", VA = "0x847484")]
			[DebuggerHidden]
			public <Step>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x84748C", Offset = "0x84748C", VA = "0x84748C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x847A6C", Offset = "0x847A6C", VA = "0x847A6C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x847A80", Offset = "0x847A80", VA = "0x847A80", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public MechSpider mechSpider;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 offset;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minDelay;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float maxOffset;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float stepSpeed;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float footHeight;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float velocityPrediction;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float raycastFocus;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public ParticleSystem sand;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IK ik;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float stepProgress;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastStepTime;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RaycastHit hit;

		[Token(Token = "0x1700004B")]
		public bool isStepping
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x846844", Offset = "0x846844", VA = "0x846844")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		public Vector3 position
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x8462D8", Offset = "0x8462D8", VA = "0x8462D8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x846864", Offset = "0x846864", VA = "0x846864")]
			set
			{
			}
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x8467E4", Offset = "0x8467E4", VA = "0x8467E4")]
		public MechSpiderLeg()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x8468D4", Offset = "0x8468D4", VA = "0x8468D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x846B50", Offset = "0x846B50", VA = "0x846B50")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x8470E8", Offset = "0x8470E8", VA = "0x8470E8")]
		private void Update()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x8473B0", Offset = "0x8473B0", VA = "0x8473B0")]
		[DebuggerHidden]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}
	}
	[Token(Token = "0x2000062")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ParticleSystem particles;

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x847B04", Offset = "0x847B04", VA = "0x847B04")]
		public MechSpiderParticles()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x847B0C", Offset = "0x847B0C", VA = "0x847B0C")]
		private void Start()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x847C28", Offset = "0x847C28", VA = "0x847C28")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000064")]
		public struct Warp
		{
			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F218", Offset = "0x29F218")]
			public int animationLayer;

			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F24C", Offset = "0x29F24C")]
			public string animationState;

			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F280", Offset = "0x29F280")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F2B4", Offset = "0x29F2B4")]
			public Transform warpFrom;

			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F2E8", Offset = "0x29F2E8")]
			public Transform warpTo;

			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F31C", Offset = "0x29F31C")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x2000065")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000289")]
			PositionOffset,
			[Token(Token = "0x400028A")]
			Position
		}

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F160", Offset = "0x29F160")]
		public Animator animator;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F194", Offset = "0x29F194")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x29F1C8", Offset = "0x29F1C8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F1C8", Offset = "0x29F1C8")]
		public Warp[] warps;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private EffectorMode lastMode;

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x8344B8", Offset = "0x8344B8", VA = "0x8344B8")]
		public AnimationWarping()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x8344C0", Offset = "0x8344C0", VA = "0x8344C0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x8344E0", Offset = "0x8344E0", VA = "0x8344E0")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x8347D4", Offset = "0x8347D4", VA = "0x8347D4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x834D90", Offset = "0x834D90", VA = "0x834D90")]
		private void OnDisable()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x29F350", Offset = "0x29F350")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float rotateSpeed;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float blendSpeed;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maxAngle;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float moveSpeed;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rootMotionWeight;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Animator animator;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected Vector3 velocity;

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x834E9C", Offset = "0x834E9C", VA = "0x834E9C")]
		public AnimatorController3rdPerson()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x834ED0", Offset = "0x834ED0", VA = "0x834ED0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x834F38", Offset = "0x834F38", VA = "0x834F38")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x835214", Offset = "0x835214", VA = "0x835214", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x29F3C8", Offset = "0x29F3C8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x29F3C8", Offset = "0x29F3C8")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29F46C", Offset = "0x29F46C")]
		public float headLookWeight;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Recoil recoil;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AimIK aim;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 headLookAxis;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 aimTarget;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x835584", Offset = "0x835584", VA = "0x835584")]
		public AnimatorController3rdPersonIK()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x8355C0", Offset = "0x8355C0", VA = "0x8355C0", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x835844", Offset = "0x835844", VA = "0x835844", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x8358BC", Offset = "0x8358BC", VA = "0x8358BC")]
		private void Read()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x835AD4", Offset = "0x835AD4", VA = "0x835AD4")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x835B40", Offset = "0x835B40", VA = "0x835B40")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x836460", Offset = "0x836460", VA = "0x836460")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x836180", Offset = "0x836180", VA = "0x836180")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x836904", Offset = "0x836904", VA = "0x836904")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x29F484", Offset = "0x29F484")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x838C40", Offset = "0x838C40", VA = "0x838C40")]
		public CharacterAnimationThirdPersonIK()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x838C80", Offset = "0x838C80", VA = "0x838C80", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x838CF0", Offset = "0x838CF0", VA = "0x838CF0", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x839048", Offset = "0x839048", VA = "0x839048")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x29F4FC", Offset = "0x29F4FC")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x1700004D")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x83A4E0", Offset = "0x83A4E0", VA = "0x83A4E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004E")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x83A5C4", Offset = "0x83A5C4", VA = "0x83A5C4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x83A134", Offset = "0x83A134", VA = "0x83A134")]
		public CharacterController3rdPerson()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x83A13C", Offset = "0x83A13C", VA = "0x83A13C")]
		private void Start()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x83A1C4", Offset = "0x83A1C4", VA = "0x83A1C4")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29F584", Offset = "0x29F584")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 bodyOffset;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x83DD74", Offset = "0x83DD74", VA = "0x83DD74")]
		public EffectorOffset()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x83DD7C", Offset = "0x83DD7C", VA = "0x83DD7C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public SimpleLocomotion character;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float forceMlp;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float upForce;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public AnimationCurve scale;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float weight;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody r;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x83E800", Offset = "0x83E800", VA = "0x83E800")]
		public ExplosionDemo()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x83E8B8", Offset = "0x83E8B8", VA = "0x83E8B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x83E99C", Offset = "0x83E99C", VA = "0x83E99C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x83F108", Offset = "0x83F108", VA = "0x83F108")]
		private void SetEffectorWeights(float w)
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200006D")]
		public class Limb
		{
			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float mappingWeight;

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x83F5B4", Offset = "0x83F5B4", VA = "0x83F5B4")]
			public Limb()
			{
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x83F444", Offset = "0x83F444", VA = "0x83F444")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}
		}

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool disableAfterStart;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Limb leftArm;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Limb rightArm;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Limb leftLeg;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Limb rightLeg;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rootPin;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x83F228", Offset = "0x83F228", VA = "0x83F228")]
		public FBBIKSettings()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x83F238", Offset = "0x83F238", VA = "0x83F238")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x83F4F8", Offset = "0x83F4F8", VA = "0x83F4F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x83F5B0", Offset = "0x83F5B0", VA = "0x83F5B0")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float weight;

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x83F5C4", Offset = "0x83F5C4", VA = "0x83F5C4")]
		public FBIKBendGoal()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x83F5CC", Offset = "0x83F5CC", VA = "0x83F5CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x83F65C", Offset = "0x83F65C", VA = "0x83F65C")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F59C", Offset = "0x29F59C")]
		public Transform target;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F5D0", Offset = "0x29F5D0")]
		public Transform pin;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F604", Offset = "0x29F604")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F638", Offset = "0x29F638")]
		public AimIK aim;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F66C", Offset = "0x29F66C")]
		public float weight;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F6A0", Offset = "0x29F6A0")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F6D4", Offset = "0x29F6D4")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator animator;

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x83F798", Offset = "0x83F798", VA = "0x83F798")]
		public FBIKBoxing()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x83F7A0", Offset = "0x83F7A0", VA = "0x83F7A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x83F808", Offset = "0x83F808", VA = "0x83F808")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool leftHanded;

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x83FAB0", Offset = "0x83FAB0", VA = "0x83FAB0")]
		public FBIKHandsOnProp()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x83FAB8", Offset = "0x83FAB8", VA = "0x83FAB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x83FBF8", Offset = "0x83FBF8", VA = "0x83FBF8")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x83FCB4", Offset = "0x83FCB4", VA = "0x83FCB4")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x840404", Offset = "0x840404", VA = "0x840404")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29F708", Offset = "0x29F708")]
		public float aimWeight;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29F720", Offset = "0x29F720")]
		public float sightWeight;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29F738", Offset = "0x29F738")]
		public float maxAngle;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29F7C4", Offset = "0x29F7C4")]
		private float cameraRecoilWeight;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool updateFrame;

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x840590", Offset = "0x840590", VA = "0x840590")]
		public FPSAiming()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x8405B8", Offset = "0x8405B8", VA = "0x8405B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x8407D4", Offset = "0x8407D4", VA = "0x8407D4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x8407E0", Offset = "0x8407E0", VA = "0x8407E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x840C90", Offset = "0x840C90", VA = "0x840C90")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x840F08", Offset = "0x840F08", VA = "0x840F08")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x840920", Offset = "0x840920", VA = "0x840920")]
		private void RotateCharacter()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x29F7FC", Offset = "0x29F7FC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x29F7FC", Offset = "0x29F7FC")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29F8A0", Offset = "0x29F8A0")]
		public float walkSpeed;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float sVel;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Animator animator;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x84201C", Offset = "0x84201C", VA = "0x84201C")]
		public FPSCharacter()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x84202C", Offset = "0x84202C", VA = "0x84202C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x8420B0", Offset = "0x8420B0", VA = "0x8420B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x842290", Offset = "0x842290", VA = "0x842290")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private string colliderName;

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x8425E0", Offset = "0x8425E0", VA = "0x8425E0")]
		public HitReactionTrigger()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x8425F0", Offset = "0x8425F0", VA = "0x8425F0")]
		private void Update()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x842880", Offset = "0x842880", VA = "0x842880")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform rightHandTarget;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftHandTarget;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float crossFade;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speed;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x842E20", Offset = "0x842E20", VA = "0x842E20")]
		public HoldingHands()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x842E34", Offset = "0x842E34", VA = "0x842E34")]
		private void Start()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x8430A0", Offset = "0x8430A0", VA = "0x8430A0")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public InteractionSystem character1;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractionSystem character2;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public InteractionObject handShake;

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x843664", Offset = "0x843664", VA = "0x843664")]
		public InteractionC2CDemo()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x84366C", Offset = "0x84366C", VA = "0x84366C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x84376C", Offset = "0x84376C", VA = "0x84376C")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool interrupt;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public InteractionObject ball;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionObject benchMain;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public InteractionObject benchHands;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionObject button;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public InteractionObject cigarette;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject door;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool isSitting;

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x843964", Offset = "0x843964", VA = "0x843964")]
		public InteractionDemo()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x84396C", Offset = "0x84396C", VA = "0x84396C")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x29F8D8", Offset = "0x29F8D8")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F950", Offset = "0x29F950")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F998", Offset = "0x29F998")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x843F54", Offset = "0x843F54", VA = "0x843F54")]
		public InteractionSystemTestGUI()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x843F5C", Offset = "0x843F5C", VA = "0x843F5C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x843FC4", Offset = "0x843FC4", VA = "0x843FC4")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000079")]
		public class Partner
		{
			[Token(Token = "0x4000301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform mouth;

			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform mouthTarget;

			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float neckRotationWeight;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float headTiltAngle;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Quaternion neckRotation;

			[Token(Token = "0x1700004F")]
			private Transform neck
			{
				[Token(Token = "0x600032D")]
				[Address(RVA = "0x845198", Offset = "0x845198", VA = "0x845198")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600032A")]
			[Address(RVA = "0x844EF0", Offset = "0x844EF0", VA = "0x844EF0")]
			public Partner()
			{
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x844384", Offset = "0x844384", VA = "0x844384")]
			public void Initiate()
			{
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0x844428", Offset = "0x844428", VA = "0x844428")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x600032E")]
			[Address(RVA = "0x844F24", Offset = "0x844F24", VA = "0x844F24")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}
		}

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Partner partner1;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Partner partner2;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float weight;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int iterations;

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x844334", Offset = "0x844334", VA = "0x844334")]
		public KissingRig()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x844344", Offset = "0x844344", VA = "0x844344")]
		private void Start()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x8443B0", Offset = "0x8443B0", VA = "0x8443B0")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200007B")]
		public enum Mode
		{
			[Token(Token = "0x4000314")]
			Position,
			[Token(Token = "0x4000315")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x200007C")]
		public class Absorber
		{
			[Token(Token = "0x4000316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29FAB0", Offset = "0x29FAB0")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29FAE4", Offset = "0x29FAE4")]
			public float weight;

			[Token(Token = "0x4000318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector3 position;

			[Token(Token = "0x4000319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion rotation;

			[Token(Token = "0x400031A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private IKEffector e;

			[Token(Token = "0x6000335")]
			[Address(RVA = "0x848A54", Offset = "0x848A54", VA = "0x848A54")]
			public Absorber()
			{
			}

			[Token(Token = "0x6000336")]
			[Address(RVA = "0x8481EC", Offset = "0x8481EC", VA = "0x8481EC")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000337")]
			[Address(RVA = "0x8484AC", Offset = "0x8484AC", VA = "0x8484AC")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0x848500", Offset = "0x848500", VA = "0x848500")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000339")]
			[Address(RVA = "0x84876C", Offset = "0x84876C", VA = "0x84876C")]
			public void SetRotation(float w)
			{
			}
		}

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29F9E0", Offset = "0x29F9E0")]
		public Mode mode;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29FA14", Offset = "0x29FA14")]
		public Absorber[] absorbers;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29FA48", Offset = "0x29FA48")]
		public AnimationCurve falloff;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29FA7C", Offset = "0x29FA7C")]
		public float falloffSpeed;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float timer;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float w;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Mode initialMode;

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x847FD0", Offset = "0x847FD0", VA = "0x847FD0")]
		public MotionAbsorb()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x847FE0", Offset = "0x847FE0", VA = "0x847FE0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x848134", Offset = "0x848134", VA = "0x848134")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x848334", Offset = "0x848334", VA = "0x848334", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x8486B8", Offset = "0x8486B8", VA = "0x8486B8")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x8488BC", Offset = "0x8488BC", VA = "0x8488BC", Slot = "6")]
		protected override void OnDestroy()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Animator animator;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform cube;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cubeRandomPosition;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x848B04", Offset = "0x848B04", VA = "0x848B04")]
		public MotionAbsorbCharacter()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x848B18", Offset = "0x848B18", VA = "0x848B18")]
		private void Start()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x848BC4", Offset = "0x848BC4", VA = "0x848BC4")]
		private void Update()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x848C90", Offset = "0x848C90", VA = "0x848C90")]
		private void SwingStart()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200007F")]
		public class EffectorLink
		{
			[Token(Token = "0x4000324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float weightMultiplier;

			[Token(Token = "0x4000326")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000341")]
			[Address(RVA = "0x84939C", Offset = "0x84939C", VA = "0x84939C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x848E80", Offset = "0x848E80", VA = "0x848E80")]
		public OffsetEffector()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x848E88", Offset = "0x848E88", VA = "0x848E88", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x849020", Offset = "0x849020", VA = "0x849020", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}
	}
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x29FB28", Offset = "0x29FB28")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29FBA0", Offset = "0x29FBA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29FBA0", Offset = "0x29FBA0")]
		public float weight;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29FBF0", Offset = "0x29FBF0")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29FC24", Offset = "0x29FC24")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29FC6C", Offset = "0x29FC6C")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float lastWeight;

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x8493AC", Offset = "0x8493AC", VA = "0x8493AC")]
		public PendulumExample()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x849468", Offset = "0x849468", VA = "0x849468")]
		private void Start()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x849928", Offset = "0x849928", VA = "0x849928")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public InteractionObject obj;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pivot;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Transform holdPoint;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float pickUpTime;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float holdWeight;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float holdWeightVel;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000050")]
		private bool holding
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x84A6E8", Offset = "0x84A6E8", VA = "0x84A6E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x84A460", Offset = "0x84A460", VA = "0x84A460")]
		protected PickUp2Handed()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x84A474", Offset = "0x84A474", VA = "0x84A474")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000347")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x84A714", Offset = "0x84A714", VA = "0x84A714")]
		private void Start()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x84A9EC", Offset = "0x84A9EC", VA = "0x84A9EC")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x84AC28", Offset = "0x84AC28", VA = "0x84AC28")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x84AD54", Offset = "0x84AD54", VA = "0x84AD54")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x84AEF8", Offset = "0x84AEF8", VA = "0x84AEF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x84B174", Offset = "0x84B174", VA = "0x84B174")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x84B498", Offset = "0x84B498", VA = "0x84B498")]
		public PickUpBox()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x84B4AC", Offset = "0x84B4AC", VA = "0x84B4AC", Slot = "4")]
		protected override void RotatePivot()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x84B790", Offset = "0x84B790", VA = "0x84B790")]
		public PickUpSphere()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x84B7A4", Offset = "0x84B7A4", VA = "0x84B7A4", Slot = "4")]
		protected override void RotatePivot()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x84C480", Offset = "0x84C480", VA = "0x84C480")]
		public RagdollUtilityDemo()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x84C488", Offset = "0x84C488", VA = "0x84C488")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x84C518", Offset = "0x84C518", VA = "0x84C518")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x29FD54", Offset = "0x29FD54")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float magnitude;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Recoil recoil;

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x84C7D0", Offset = "0x84C7D0", VA = "0x84C7D0")]
		public RecoilTest()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x84C7E0", Offset = "0x84C7E0", VA = "0x84C7E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x84C848", Offset = "0x84C848", VA = "0x84C848")]
		private void Update()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x84C94C", Offset = "0x84C94C", VA = "0x84C94C")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x200017C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29FDDC", Offset = "0x29FDDC")]
		private sealed class <ResetObject>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000A00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float resetTime;

			[Token(Token = "0x4000A01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Poser <poser>__0;

			[Token(Token = "0x4000A02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal ResetInteractionObject $this;

			[Token(Token = "0x4000A03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal object $current;

			[Token(Token = "0x4000A04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal bool $disposing;

			[Token(Token = "0x4000A05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal int $PC;

			[Token(Token = "0x17000138")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A6B")]
				[Address(RVA = "0x84CF3C", Offset = "0x84CF3C", VA = "0x84CF3C", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000139")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A6C")]
				[Address(RVA = "0x84CF44", Offset = "0x84CF44", VA = "0x84CF44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x84CBEC", Offset = "0x84CBEC", VA = "0x84CBEC")]
			[DebuggerHidden]
			public <ResetObject>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x84CBF4", Offset = "0x84CBF4", VA = "0x84CBF4", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x84CF4C", Offset = "0x84CF4C", VA = "0x84CF4C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x84CF60", Offset = "0x84CF60", VA = "0x84CF60", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float resetDelay;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Transform defaultParent;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x84C9DC", Offset = "0x84C9DC", VA = "0x84C9DC")]
		public ResetInteractionObject()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x84C9EC", Offset = "0x84C9EC", VA = "0x84C9EC")]
		private void Start()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x84CAFC", Offset = "0x84CAFC", VA = "0x84CAFC")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x84CB48", Offset = "0x84CB48", VA = "0x84CB48")]
		[DebuggerHidden]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x29FE3C", Offset = "0x29FE3C")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x200017D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29FEC4", Offset = "0x29FEC4")]
		private sealed class <ResetDelayed>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000A06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal SoccerDemo $this;

			[Token(Token = "0x4000A07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x4000A08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x4000A09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x1700013A")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A71")]
				[Address(RVA = "0xBE1928", Offset = "0xBE1928", VA = "0xBE1928", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A72")]
				[Address(RVA = "0xBE1930", Offset = "0xBE1930", VA = "0xBE1930", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0xBE1720", Offset = "0xBE1720", VA = "0xBE1720")]
			[DebuggerHidden]
			public <ResetDelayed>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A70")]
			[Address(RVA = "0xBE1728", Offset = "0xBE1728", VA = "0xBE1728", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A73")]
			[Address(RVA = "0xBE1938", Offset = "0xBE1938", VA = "0xBE1938", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A74")]
			[Address(RVA = "0xBE194C", Offset = "0xBE194C", VA = "0xBE194C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Animator animator;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xBE159C", Offset = "0xBE159C", VA = "0xBE159C")]
		public SoccerDemo()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xBE15A4", Offset = "0xBE15A4", VA = "0xBE15A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xBE16A0", Offset = "0xBE16A0", VA = "0xBE16A0")]
		[DebuggerHidden]
		private IEnumerator ResetDelayed()
		{
			return null;
		}
	}
	[Token(Token = "0x2000088")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000089")]
		public class EffectorLink
		{
			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool enabled;

			[Token(Token = "0x4000352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float spherecastRadius;

			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float minDistance;

			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float lerpSpeed;

			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float minSwitchTime;

			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float releaseDistance;

			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool sliding;

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float raycastDistance;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private bool inTouch;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private RaycastHit hit;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private bool initiated;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private float nextSwitchTime;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private float speedF;

			[Token(Token = "0x6000365")]
			[Address(RVA = "0xBE3478", Offset = "0xBE3478", VA = "0xBE3478")]
			public EffectorLink()
			{
			}

			[Token(Token = "0x6000366")]
			[Address(RVA = "0xBE20E4", Offset = "0xBE20E4", VA = "0xBE20E4")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000367")]
			[Address(RVA = "0xBE34E0", Offset = "0xBE34E0", VA = "0xBE34E0")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000368")]
			[Address(RVA = "0xBE268C", Offset = "0xBE268C", VA = "0xBE268C")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000369")]
			[Address(RVA = "0xBE35B8", Offset = "0xBE35B8", VA = "0xBE35B8")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600036A")]
			[Address(RVA = "0xBE37D4", Offset = "0xBE37D4", VA = "0xBE37D4")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600036B")]
			[Address(RVA = "0xBE3884", Offset = "0xBE3884", VA = "0xBE3884")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600036C")]
			[Address(RVA = "0xBE3934", Offset = "0xBE3934", VA = "0xBE3934")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x600036D")]
			[Address(RVA = "0xBE319C", Offset = "0xBE319C", VA = "0xBE319C")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}
		}

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xBE2068", Offset = "0xBE2068", VA = "0xBE2068")]
		public TouchWalls()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xBE2070", Offset = "0xBE2070", VA = "0xBE2070")]
		private void Start()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xBE2604", Offset = "0xBE2604", VA = "0xBE2604")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xBE308C", Offset = "0xBE308C", VA = "0xBE308C")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29FF24", Offset = "0x29FF24")]
		public Transform to;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29FF58", Offset = "0x29FF58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x29FF58", Offset = "0x29FF58")]
		public float transferMotion;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Vector3 lastPosition;

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xBE39E4", Offset = "0xBE39E4", VA = "0xBE39E4")]
		public TransferMotion()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xBE39F8", Offset = "0xBE39F8", VA = "0xBE39F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xBE3A44", Offset = "0xBE3A44", VA = "0xBE3A44")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x29FFA8", Offset = "0x29FFA8")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xBE3DFC", Offset = "0xBE3DFC", VA = "0xBE3DFC")]
		public TwoHandedProp()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xBE3E04", Offset = "0xBE3E04", VA = "0xBE3E04")]
		private void Start()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xBE40B8", Offset = "0xBE40B8", VA = "0xBE40B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xBE44FC", Offset = "0xBE44FC", VA = "0xBE44FC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xBE4680", Offset = "0xBE4680", VA = "0xBE4680")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xBE4B50", Offset = "0xBE4B50", VA = "0xBE4B50")]
		public UserControlInteractions()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xBE4B94", Offset = "0xBE4B94", VA = "0xBE4B94", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xBE5250", Offset = "0xBE5250", VA = "0xBE5250")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public GameObject[] characters;

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x842388", Offset = "0x842388", VA = "0x842388")]
		public GrounderDemo()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x842390", Offset = "0x842390", VA = "0x842390")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x84254C", Offset = "0x84254C", VA = "0x84254C")]
		public void Activate(int index)
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x200017E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A001C", Offset = "0x2A001C")]
		private sealed class <SwitchRotation>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000A0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float <angle>__1;

			[Token(Token = "0x4000A0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Vector3 <axis>__1;

			[Token(Token = "0x4000A0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal PlatformRotator $this;

			[Token(Token = "0x4000A0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal object $current;

			[Token(Token = "0x4000A0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal bool $disposing;

			[Token(Token = "0x4000A0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal int $PC;

			[Token(Token = "0x1700013C")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A77")]
				[Address(RVA = "0x84C3D8", Offset = "0x84C3D8", VA = "0x84C3D8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A78")]
				[Address(RVA = "0x84C3E0", Offset = "0x84C3E0", VA = "0x84C3E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x84BF4C", Offset = "0x84BF4C", VA = "0x84BF4C")]
			[DebuggerHidden]
			public <SwitchRotation>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A76")]
			[Address(RVA = "0x84C1BC", Offset = "0x84C1BC", VA = "0x84C1BC", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x84C3E8", Offset = "0x84C3E8", VA = "0x84C3E8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x84C3FC", Offset = "0x84C3FC", VA = "0x84C3FC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float maxAngle;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float switchRotationTime;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float random;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSpeed;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 movePosition;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float moveSpeed;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int characterLayer;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion targetRotation;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 targetPosition;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 velocity;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody r;

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x84BA38", Offset = "0x84BA38", VA = "0x84BA38")]
		public PlatformRotator()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x84BA70", Offset = "0x84BA70", VA = "0x84BA70")]
		private void Start()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x84BC50", Offset = "0x84BC50", VA = "0x84BC50")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x84BBD0", Offset = "0x84BBD0", VA = "0x84BBD0")]
		[DebuggerHidden]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x84BF54", Offset = "0x84BF54", VA = "0x84BF54")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x84C08C", Offset = "0x84C08C", VA = "0x84C08C")]
		private void OnCollisionExit(Collision collision)
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public LimbIK limbIK;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A007C", Offset = "0x2A007C")]
		public float weight;

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x836B74", Offset = "0x836B74", VA = "0x836B74")]
		public BendGoal()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x836B84", Offset = "0x836B84", VA = "0x836B84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x836C14", Offset = "0x836C14", VA = "0x836C14")]
		private void LateUpdate()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000091")]
		public class Part
		{
			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000387")]
			[Address(RVA = "0xBE3DF4", Offset = "0xBE3DF4", VA = "0xBE3DF4")]
			public Part()
			{
			}

			[Token(Token = "0x6000388")]
			[Address(RVA = "0xBE3C80", Offset = "0xBE3C80", VA = "0xBE3C80")]
			public void AimAt(Transform target)
			{
			}
		}

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform target;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Part[] parts;

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xBE3C04", Offset = "0xBE3C04", VA = "0xBE3C04")]
		public Turret()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xBE3C0C", Offset = "0xBE3C0C", VA = "0xBE3C0C")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private HitReactionVRIK hitReaction;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private string colliderName;

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x842A00", Offset = "0x842A00", VA = "0x842A00")]
		public HitReactionVRIKTrigger()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x842A10", Offset = "0x842A10", VA = "0x842A10")]
		private void Update()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x842CA0", Offset = "0x842CA0", VA = "0x842CA0")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A00B4", Offset = "0x2A00B4")]
		public VRIK ik;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A00E8", Offset = "0x2A00E8")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A011C", Offset = "0x2A011C")]
		public Transform headTracker;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0150", Offset = "0x2A0150")]
		public Transform bodyTracker;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0184", Offset = "0x2A0184")]
		public Transform leftHandTracker;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A01B8", Offset = "0x2A01B8")]
		public Transform rightHandTracker;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A01EC", Offset = "0x2A01EC")]
		public Transform leftFootTracker;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0220", Offset = "0x2A0220")]
		public Transform rightFootTracker;

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xBE558C", Offset = "0xBE558C", VA = "0xBE558C")]
		public VRIKCalibrationController()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xBE5594", Offset = "0xBE5594", VA = "0xBE5594")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xBE5658", Offset = "0xBE5658", VA = "0xBE5658")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A0254", Offset = "0x2A0254")]
		private void Calibrate()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public VRIK ik;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Quaternion lastRotation;

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xBE56A0", Offset = "0xBE56A0", VA = "0xBE56A0")]
		public VRIKPlatform()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xBE5748", Offset = "0xBE5748", VA = "0xBE5748")]
		private void Start()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xBE57D0", Offset = "0xBE57D0", VA = "0xBE57D0")]
		private void Update()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000095")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform pelvisTarget;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform rightFootTarget;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 pelvisTargetRight;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private VRIK ik;

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x114AFF4", Offset = "0x114AFF4", VA = "0x114AFF4")]
		public VRIKRootController()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x114AFFC", Offset = "0x114AFFC", VA = "0x114AFFC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x114ACE0", Offset = "0x114ACE0", VA = "0x114ACE0")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x114B158", Offset = "0x114B158", VA = "0x114B158")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x114B6F8", Offset = "0x114B6F8", VA = "0x114B6F8")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A0288", Offset = "0x2A0288")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A0288", Offset = "0x2A0288")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BipedReferences references;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xBE80D8", Offset = "0xBE80D8", VA = "0xBE80D8")]
		public BipedIK()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xBE82D8", Offset = "0xBE82D8", VA = "0xBE82D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A02E8", Offset = "0x2A02E8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xBE833C", Offset = "0xBE833C", VA = "0xBE833C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A031C", Offset = "0x2A031C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xBE83A0", Offset = "0xBE83A0", VA = "0xBE83A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A0350", Offset = "0x2A0350")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xBE8404", Offset = "0xBE8404", VA = "0xBE8404")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A0384", Offset = "0x2A0384")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xBE8468", Offset = "0xBE8468", VA = "0xBE8468")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xBE8534", Offset = "0xBE8534", VA = "0xBE8534")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xBE8560", Offset = "0xBE8560", VA = "0xBE8560")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xBE8594", Offset = "0xBE8594", VA = "0xBE8594")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xBE85C8", Offset = "0xBE85C8", VA = "0xBE85C8")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xBE8618", Offset = "0xBE8618", VA = "0xBE8618")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xBE8670", Offset = "0xBE8670", VA = "0xBE8670")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xBE86B4", Offset = "0xBE86B4", VA = "0xBE86B4")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xBE86F0", Offset = "0xBE86F0", VA = "0xBE86F0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xBE8774", Offset = "0xBE8774", VA = "0xBE8774")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xBE87D0", Offset = "0xBE87D0", VA = "0xBE87D0")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xBE882C", Offset = "0xBE882C", VA = "0xBE882C")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xBE8494", Offset = "0xBE8494", VA = "0xBE8494")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xBE886C", Offset = "0xBE886C", VA = "0xBE886C")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xBE887C", Offset = "0xBE887C", VA = "0xBE887C")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xBE888C", Offset = "0xBE888C", VA = "0xBE888C")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xBE8CF4", Offset = "0xBE8CF4", VA = "0xBE8CF4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xBE8DE4", Offset = "0xBE8DE4", VA = "0xBE8DE4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xBE937C", Offset = "0xBE937C", VA = "0xBE937C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xBE9AB4", Offset = "0xBE9AB4", VA = "0xBE9AB4")]
		public void LogWarning(string message)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000097")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverAim aim;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Constraints pelvis;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000051")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0xBE8B24", Offset = "0xBE8B24", VA = "0xBE8B24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0xBE9AF8", Offset = "0xBE9AF8", VA = "0xBE9AF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xBE8174", Offset = "0xBE8174", VA = "0xBE8174")]
		public BipedIKSolvers()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xBE90C0", Offset = "0xBE90C0", VA = "0xBE90C0")]
		public void AssignReferences(BipedReferences references)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000098")]
	public abstract class Constraint
	{
		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform transform;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float weight;

		[Token(Token = "0x17000053")]
		public bool isValid
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0xBEA31C", Offset = "0xBEA31C", VA = "0xBEA31C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xBEA314", Offset = "0xBEA314", VA = "0xBEA314")]
		protected Constraint()
		{
		}

		[Token(Token = "0x60003B6")]
		public abstract void UpdateConstraint();
	}
	[Serializable]
	[Token(Token = "0x2000099")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xBEA3AC", Offset = "0xBEA3AC", VA = "0xBEA3AC")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xBEA3B4", Offset = "0xBEA3B4", VA = "0xBEA3B4")]
		public ConstraintPosition(Transform transform)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xBEA3D4", Offset = "0xBEA3D4", VA = "0xBEA3D4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009A")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 offset;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x17000054")]
		private bool positionChanged
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0xBEA7B0", Offset = "0xBEA7B0", VA = "0xBEA7B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xBEA500", Offset = "0xBEA500", VA = "0xBEA500")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xBEA508", Offset = "0xBEA508", VA = "0xBEA508")]
		public ConstraintPositionOffset(Transform transform)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xBEA528", Offset = "0xBEA528", VA = "0xBEA528", Slot = "4")]
		public override void UpdateConstraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009B")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Quaternion rotation;

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xBEA87C", Offset = "0xBEA87C", VA = "0xBEA87C")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xBEA884", Offset = "0xBEA884", VA = "0xBEA884")]
		public ConstraintRotation(Transform transform)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xBEA8A4", Offset = "0xBEA8A4", VA = "0xBEA8A4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009C")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Quaternion offset;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool initiated;

		[Token(Token = "0x17000055")]
		private bool rotationChanged
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0xBEAC94", Offset = "0xBEAC94", VA = "0xBEAC94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xBEA9E0", Offset = "0xBEA9E0", VA = "0xBEA9E0")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xBEA9E8", Offset = "0xBEA9E8", VA = "0xBEA9E8")]
		public ConstraintRotationOffset(Transform transform)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xBEAA08", Offset = "0xBEAA08", VA = "0xBEAA08", Slot = "4")]
		public override void UpdateConstraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009D")]
	public class Constraints
	{
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform transform;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform target;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 positionOffset;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A03B8", Offset = "0x2A03B8")]
		public float positionWeight;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 rotation;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A03D0", Offset = "0x2A03D0")]
		public float rotationWeight;

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xBE9AF0", Offset = "0xBE9AF0", VA = "0xBE9AF0")]
		public Constraints()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xBEAD6C", Offset = "0xBEAD6C", VA = "0xBEAD6C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xBE9308", Offset = "0xBE9308", VA = "0xBE9308")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xBE9608", Offset = "0xBE9608", VA = "0xBE9608")]
		public void Update()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009E")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x200009F")]
		public enum DOF
		{
			[Token(Token = "0x40003C8")]
			One,
			[Token(Token = "0x40003C9")]
			Three
		}

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A03E8", Offset = "0x2A03E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A03E8", Offset = "0x2A03E8")]
		public float weight;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0438", Offset = "0x2A0438")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A0438", Offset = "0x2A0438")]
		public float rotationWeight;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0488", Offset = "0x2A0488")]
		public DOF rotationDOF;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A04BC", Offset = "0x2A04BC")]
		public Transform bone1;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A04F0", Offset = "0x2A04F0")]
		public Transform bone2;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0524", Offset = "0x2A0524")]
		public Transform bone3;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0558", Offset = "0x2A0558")]
		public Transform tip;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A058C", Offset = "0x2A058C")]
		public Transform target;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A05C0", Offset = "0x2A05C0")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A05C0", Offset = "0x2A05C0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private IKSolverLimb solver;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 bone1Axis;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 tipAxis;

		[Token(Token = "0x17000056")]
		public bool initiated
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0xBF7328", Offset = "0xBF7328", VA = "0xBF7328")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A05F4", Offset = "0x2A05F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0xBF7330", Offset = "0xBF7330", VA = "0xBF7330")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A0604", Offset = "0x2A0604")]
			private set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0xBF7338", Offset = "0xBF7338", VA = "0xBF7338")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0xBF7364", Offset = "0xBF7364", VA = "0xBF7364")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0xBF7398", Offset = "0xBF7398", VA = "0xBF7398")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0xBF73C4", Offset = "0xBF73C4", VA = "0xBF73C4")]
			set
			{
			}
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xBF7314", Offset = "0xBF7314", VA = "0xBF7314")]
		public Finger()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xBF7400", Offset = "0xBF7400", VA = "0xBF7400")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xBF7554", Offset = "0xBF7554", VA = "0xBF7554")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xBF7B98", Offset = "0xBF7B98", VA = "0xBF7B98")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xBF7CD0", Offset = "0xBF7CD0", VA = "0xBF7CD0")]
		public void Update(float masterWeight)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0614", Offset = "0x2A0614")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A0614", Offset = "0x2A0614")]
		public float weight;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Finger[] fingers;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A0664", Offset = "0x2A0664")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A0664", Offset = "0x2A0664")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000059")]
		public bool initiated
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0xBF830C", Offset = "0xBF830C", VA = "0xBF830C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A0698", Offset = "0x2A0698")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0xBF8314", Offset = "0xBF8314", VA = "0xBF8314")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A06A8", Offset = "0x2A06A8")]
			private set
			{
			}
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xBF8284", Offset = "0xBF8284", VA = "0xBF8284")]
		public FingerRig()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xBF831C", Offset = "0xBF831C", VA = "0xBF831C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xBF8398", Offset = "0xBF8398", VA = "0xBF8398")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A06B8", Offset = "0x2A06B8")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xBF8834", Offset = "0xBF8834", VA = "0xBF8834")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xBF8A50", Offset = "0xBF8A50", VA = "0xBF8A50")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xBF86F4", Offset = "0xBF86F4", VA = "0xBF86F4")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xBF8C50", Offset = "0xBF8C50", VA = "0xBF8C50", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xBF8D34", Offset = "0xBF8D34", VA = "0xBF8D34")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xBF8DC0", Offset = "0xBF8DC0", VA = "0xBF8DC0")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xBF8E28", Offset = "0xBF8E28", VA = "0xBF8E28", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xBF8E2C", Offset = "0xBF8E2C", VA = "0xBF8E2C", Slot = "6")]
		protected override void FixTransforms()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x20000A2")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A06EC", Offset = "0x2A06EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A06EC", Offset = "0x2A06EC")]
		public float weight;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A073C", Offset = "0x2A073C")]
		public Grounding solver;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected bool initiated;

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xBFA3B0", Offset = "0xBFA3B0", VA = "0xBFA3B0")]
		protected Grounder()
		{
		}

		[Token(Token = "0x60003E2")]
		public abstract void ResetPosition();

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xBFA51C", Offset = "0xBFA51C", VA = "0xBFA51C")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xBFA8F0", Offset = "0xBFA8F0", VA = "0xBFA8F0")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xBFA6BC", Offset = "0xBFA6BC", VA = "0xBFA6BC")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xBFA92C", Offset = "0xBFA92C", VA = "0xBFA92C")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E7")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60003E8")]
		protected abstract void OpenScriptReference();
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A0770", Offset = "0x2A0770")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A0770", Offset = "0x2A0770")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A07D0", Offset = "0x2A07D0")]
		public BipedIK ik;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0804", Offset = "0x2A0804")]
		public float spineBend;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0838", Offset = "0x2A0838")]
		public float spineSpeed;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Transform[] feet;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 spineOffset;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float lastWeight;

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xBFAE4C", Offset = "0xBFAE4C", VA = "0xBFAE4C")]
		public GrounderBipedIK()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xBFAF08", Offset = "0xBFAF08", VA = "0xBFAF08", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A086C", Offset = "0x2A086C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xBFAF6C", Offset = "0xBFAF6C", VA = "0xBFAF6C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A08A0", Offset = "0x2A08A0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xBFAFD0", Offset = "0xBFAFD0", VA = "0xBFAFD0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xBFB11C", Offset = "0xBFB11C", VA = "0xBFB11C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xBFB23C", Offset = "0xBFB23C", VA = "0xBFB23C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xBFB328", Offset = "0xBFB328", VA = "0xBFB328")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xBFBB8C", Offset = "0xBFBB8C", VA = "0xBFBB8C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xBFBC18", Offset = "0xBFBC18", VA = "0xBFBC18")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xBFC74C", Offset = "0xBFC74C", VA = "0xBFC74C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xBFC964", Offset = "0xBFC964", VA = "0xBFC964")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xBFCC0C", Offset = "0xBFCC0C", VA = "0xBFCC0C")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A08D4", Offset = "0x2A08D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A08D4", Offset = "0x2A08D4")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000A5")]
		public class SpineEffector
		{
			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0A6C", Offset = "0x2A0A6C")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0AA0", Offset = "0x2A0AA0")]
			public float horizontalWeight;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0AD4", Offset = "0x2A0AD4")]
			public float verticalWeight;

			[Token(Token = "0x6000407")]
			[Address(RVA = "0xBFE34C", Offset = "0xBFE34C", VA = "0xBFE34C")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000408")]
			[Address(RVA = "0xBFE35C", Offset = "0xBFE35C", VA = "0xBFE35C")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0934", Offset = "0x2A0934")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0968", Offset = "0x2A0968")]
		public float spineBend;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A099C", Offset = "0x2A099C")]
		public float spineSpeed;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public SpineEffector[] spine;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform[] feet;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 spineOffset;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool firstSolve;

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xBFCEA8", Offset = "0xBFCEA8", VA = "0xBFCEA8")]
		public GrounderFBBIK()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xBFCF60", Offset = "0xBFCF60", VA = "0xBFCF60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A09D0", Offset = "0x2A09D0")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xBFCFC4", Offset = "0xBFCFC4", VA = "0xBFCFC4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A0A04", Offset = "0x2A0A04")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xBFD028", Offset = "0xBFD028", VA = "0xBFD028", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A0A38", Offset = "0x2A0A38")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xBFD08C", Offset = "0xBFD08C", VA = "0xBFD08C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xBFD140", Offset = "0xBFD140", VA = "0xBFD140")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xBFD208", Offset = "0xBFD208", VA = "0xBFD208")]
		private void Update()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xBFD66C", Offset = "0xBFD66C", VA = "0xBFD66C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xBFD678", Offset = "0xBFD678", VA = "0xBFD678")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xBFD2FC", Offset = "0xBFD2FC", VA = "0xBFD2FC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xBFD684", Offset = "0xBFD684", VA = "0xBFD684")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xBFDD6C", Offset = "0xBFDD6C", VA = "0xBFDD6C")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xBFE020", Offset = "0xBFE020", VA = "0xBFE020")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xBFE1B4", Offset = "0xBFE1B4", VA = "0xBFE1B4")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A0B08", Offset = "0x2A0B08")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A0B08", Offset = "0x2A0B08")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IK[] legs;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0B68", Offset = "0x2A0B68")]
		public Transform pelvis;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0B9C", Offset = "0x2A0B9C")]
		public Transform characterRoot;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0BD0", Offset = "0x2A0BD0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A0BD0", Offset = "0x2A0BD0")]
		public float rootRotationWeight;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0C20", Offset = "0x2A0C20")]
		public float rootRotationSpeed;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0C54", Offset = "0x2A0C54")]
		public float maxRootRotationAngle;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform[] feet;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int solvedFeet;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool solved;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float lastWeight;

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xBFE398", Offset = "0xBFE398", VA = "0xBFE398")]
		public GrounderIK()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xBFE454", Offset = "0xBFE454", VA = "0xBFE454", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A0C88", Offset = "0x2A0C88")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xBFE4B8", Offset = "0xBFE4B8", VA = "0xBFE4B8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A0CBC", Offset = "0x2A0CBC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xBFE51C", Offset = "0xBFE51C", VA = "0xBFE51C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xBFE540", Offset = "0xBFE540", VA = "0xBFE540")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xBFE7A8", Offset = "0xBFE7A8", VA = "0xBFE7A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xBFE908", Offset = "0xBFE908", VA = "0xBFE908")]
		private void Update()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xBFF16C", Offset = "0xBFF16C", VA = "0xBFF16C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xBFF7E4", Offset = "0xBFF7E4", VA = "0xBFF7E4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xBFFAEC", Offset = "0xBFFAEC", VA = "0xBFFAEC")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xC00070", Offset = "0xC00070", VA = "0xC00070")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xC00320", Offset = "0xC00320", VA = "0xC00320")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A0CF0", Offset = "0x2A0CF0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A0CF0", Offset = "0x2A0CF0")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x20000A8")]
		public struct Foot
		{
			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Transform transform;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Quaternion rotation;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Grounding.Leg leg;

			[Token(Token = "0x6000427")]
			[Address(RVA = "0xC03690", Offset = "0xC03690", VA = "0xC03690")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0D50", Offset = "0x2A0D50")]
		public Grounding forelegSolver;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0D84", Offset = "0x2A0D84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A0D84", Offset = "0x2A0D84")]
		public float rootRotationWeight;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0DD4", Offset = "0x2A0DD4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A0DD4", Offset = "0x2A0DD4")]
		public float minRootRotation;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0E28", Offset = "0x2A0E28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A0E28", Offset = "0x2A0E28")]
		public float maxRootRotation;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0E7C", Offset = "0x2A0E7C")]
		public float rootRotationSpeed;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0EB0", Offset = "0x2A0EB0")]
		public float maxLegOffset;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0EE4", Offset = "0x2A0EE4")]
		public float maxForeLegOffset;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0F18", Offset = "0x2A0F18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A0F18", Offset = "0x2A0F18")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0F68", Offset = "0x2A0F68")]
		public Transform characterRoot;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0F9C", Offset = "0x2A0F9C")]
		public Transform pelvis;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A0FD0", Offset = "0x2A0FD0")]
		public Transform lastSpineBone;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A1004", Offset = "0x2A1004")]
		public Transform head;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public IK[] legs;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public IK[] forelegs;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Foot[] feet;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int solvedFeet;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool solved;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float angle;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Transform forefeetRoot;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion headRotation;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float lastWeight;

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xC00638", Offset = "0xC00638", VA = "0xC00638")]
		public GrounderQuadruped()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xC007C0", Offset = "0xC007C0", VA = "0xC007C0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1048", Offset = "0x2A1048")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xC00824", Offset = "0xC00824", VA = "0xC00824", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A107C", Offset = "0x2A107C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xC00888", Offset = "0xC00888", VA = "0xC00888", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xC008C8", Offset = "0xC008C8", VA = "0xC008C8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xC00A58", Offset = "0xC00A58", VA = "0xC00A58")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xC00C4C", Offset = "0xC00C4C", VA = "0xC00C4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xC00D10", Offset = "0xC00D10", VA = "0xC00D10")]
		private void Update()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xC00E00", Offset = "0xC00E00", VA = "0xC00E00")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xC01218", Offset = "0xC01218", VA = "0xC01218")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xC0177C", Offset = "0xC0177C", VA = "0xC0177C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xC018F8", Offset = "0xC018F8", VA = "0xC018F8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xC01DD8", Offset = "0xC01DD8", VA = "0xC01DD8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xC02914", Offset = "0xC02914", VA = "0xC02914")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xC02CE0", Offset = "0xC02CE0", VA = "0xC02CE0")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xC02E88", Offset = "0xC02E88", VA = "0xC02E88")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xC032FC", Offset = "0xC032FC", VA = "0xC032FC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xC03330", Offset = "0xC03330", VA = "0xC03330")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A10B0", Offset = "0x2A10B0")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A10E4", Offset = "0x2A10E4")]
		public VRIK ik;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Transform[] feet;

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xC03698", Offset = "0xC03698", VA = "0xC03698")]
		public GrounderVRIK()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xC03714", Offset = "0xC03714", VA = "0xC03714")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1118", Offset = "0x2A1118")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xC03718", Offset = "0xC03718", VA = "0xC03718", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A114C", Offset = "0x2A114C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xC0371C", Offset = "0xC0371C", VA = "0xC0371C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1180", Offset = "0x2A1180")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xC03720", Offset = "0xC03720", VA = "0xC03720", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xC03744", Offset = "0xC03744", VA = "0xC03744")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xC0380C", Offset = "0xC0380C", VA = "0xC0380C")]
		private void Update()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xC038F8", Offset = "0xC038F8", VA = "0xC038F8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xC03C8C", Offset = "0xC03C8C", VA = "0xC03C8C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xC0409C", Offset = "0xC0409C", VA = "0xC0409C")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xC041E8", Offset = "0xC041E8", VA = "0xC041E8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xC04530", Offset = "0xC04530", VA = "0xC04530")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xC046C4", Offset = "0xC046C4", VA = "0xC046C4")]
		private void OnDestroy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AA")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x20000AB")]
		public enum Quality
		{
			[Token(Token = "0x400042C")]
			Fastest,
			[Token(Token = "0x400042D")]
			Simple,
			[Token(Token = "0x400042E")]
			Best
		}

		[Token(Token = "0x20000AC")]
		public class Leg
		{
			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1738", Offset = "0x2A1738")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A1738", Offset = "0x2A1738")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A176C", Offset = "0x2A176C")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A176C", Offset = "0x2A176C")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A17A0", Offset = "0x2A17A0")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A17A0", Offset = "0x2A17A0")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A17D4", Offset = "0x2A17D4")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A17D4", Offset = "0x2A17D4")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1808", Offset = "0x2A1808")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A1808", Offset = "0x2A1808")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A183C", Offset = "0x2A183C")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A183C", Offset = "0x2A183C")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1870", Offset = "0x2A1870")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A1870", Offset = "0x2A1870")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool invertFootCenter;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Grounding grounding;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float deltaTime;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Quaternion toHitNormal;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Quaternion r;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private RaycastHit heelHit;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private Vector3 up;

			[Token(Token = "0x17000062")]
			public bool isGrounded
			{
				[Token(Token = "0x600044E")]
				[Address(RVA = "0xC060BC", Offset = "0xC060BC", VA = "0xC060BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A18A4", Offset = "0x2A18A4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600044F")]
				[Address(RVA = "0xC06B84", Offset = "0xC06B84", VA = "0xC06B84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A18B4", Offset = "0x2A18B4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0xBFABE0", Offset = "0xBFABE0", VA = "0xBFABE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A18C4", Offset = "0x2A18C4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000451")]
				[Address(RVA = "0xC06B8C", Offset = "0xC06B8C", VA = "0xC06B8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A18D4", Offset = "0x2A18D4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			public bool initiated
			{
				[Token(Token = "0x6000452")]
				[Address(RVA = "0xC06B98", Offset = "0xC06B98", VA = "0xC06B98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A18E4", Offset = "0x2A18E4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000453")]
				[Address(RVA = "0xC06BA0", Offset = "0xC06BA0", VA = "0xC06BA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A18F4", Offset = "0x2A18F4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000065")]
			public float heightFromGround
			{
				[Token(Token = "0x6000454")]
				[Address(RVA = "0xC06BA8", Offset = "0xC06BA8", VA = "0xC06BA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1904", Offset = "0x2A1904")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000455")]
				[Address(RVA = "0xC06BB0", Offset = "0xC06BB0", VA = "0xC06BB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1914", Offset = "0x2A1914")]
				private set
				{
				}
			}

			[Token(Token = "0x17000066")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000456")]
				[Address(RVA = "0xC06BB8", Offset = "0xC06BB8", VA = "0xC06BB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1924", Offset = "0x2A1924")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000457")]
				[Address(RVA = "0xC06BC8", Offset = "0xC06BC8", VA = "0xC06BC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1934", Offset = "0x2A1934")]
				private set
				{
				}
			}

			[Token(Token = "0x17000067")]
			public Transform transform
			{
				[Token(Token = "0x6000458")]
				[Address(RVA = "0xBFABF0", Offset = "0xBFABF0", VA = "0xBFABF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1944", Offset = "0x2A1944")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000459")]
				[Address(RVA = "0xC06BD4", Offset = "0xC06BD4", VA = "0xC06BD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1954", Offset = "0x2A1954")]
				private set
				{
				}
			}

			[Token(Token = "0x17000068")]
			public float IKOffset
			{
				[Token(Token = "0x600045A")]
				[Address(RVA = "0xC060B4", Offset = "0xC060B4", VA = "0xC060B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1964", Offset = "0x2A1964")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600045B")]
				[Address(RVA = "0xC06BDC", Offset = "0xC06BDC", VA = "0xC06BDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1974", Offset = "0x2A1974")]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000460")]
				[Address(RVA = "0xC0780C", Offset = "0xC0780C", VA = "0xC0780C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700006A")]
			private float rootYOffset
			{
				[Token(Token = "0x6000469")]
				[Address(RVA = "0xC07BF4", Offset = "0xC07BF4", VA = "0xC07BF4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0xC05040", Offset = "0xC05040", VA = "0xC05040")]
			public Leg()
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0xC05148", Offset = "0xC05148", VA = "0xC05148")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0xC06BE4", Offset = "0xC06BE4", VA = "0xC06BE4")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0xC06564", Offset = "0xC06564", VA = "0xC06564")]
			public void Reset()
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0xC052C0", Offset = "0xC052C0", VA = "0xC052C0")]
			public void Process()
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0xC0731C", Offset = "0xC0731C", VA = "0xC0731C")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0xC06C44", Offset = "0xC06C44", VA = "0xC06C44")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0xC07A28", Offset = "0xC07A28", VA = "0xC07A28")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0xC06F70", Offset = "0xC06F70", VA = "0xC06F70")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0xC07068", Offset = "0xC07068", VA = "0xC07068")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0xC07B68", Offset = "0xC07B68", VA = "0xC07B68")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0xC078E4", Offset = "0xC078E4", VA = "0xC078E4")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0xC07D74", Offset = "0xC07D74", VA = "0xC07D74")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000AD")]
		public class Pelvis
		{
			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1984", Offset = "0x2A1984")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A1984", Offset = "0x2A1984")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A19B8", Offset = "0x2A19B8")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A19B8", Offset = "0x2A19B8")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Grounding grounding;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float damperF;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private bool initiated;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float lastTime;

			[Token(Token = "0x1700006B")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x600046B")]
				[Address(RVA = "0xBFC73C", Offset = "0xBFC73C", VA = "0xBFC73C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A19EC", Offset = "0x2A19EC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600046C")]
				[Address(RVA = "0xC07F00", Offset = "0xC07F00", VA = "0xC07F00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A19FC", Offset = "0x2A19FC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006C")]
			public float heightOffset
			{
				[Token(Token = "0x600046D")]
				[Address(RVA = "0xC02CD8", Offset = "0xC02CD8", VA = "0xC02CD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1A0C", Offset = "0x2A1A0C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600046E")]
				[Address(RVA = "0xC07F0C", Offset = "0xC07F0C", VA = "0xC07F0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1A1C", Offset = "0x2A1A1C")]
				private set
				{
				}
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0xC05140", Offset = "0xC05140", VA = "0xC05140")]
			public Pelvis()
			{
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0xC05284", Offset = "0xC05284", VA = "0xC05284")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0xC06458", Offset = "0xC06458", VA = "0xC06458")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0xC07F14", Offset = "0xC07F14", VA = "0xC07F14")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0xC060C4", Offset = "0xC060C4", VA = "0xC060C4")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}
		}

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A11B4", Offset = "0x2A11B4")]
		public LayerMask layers;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A11E8", Offset = "0x2A11E8")]
		public float maxStep;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A121C", Offset = "0x2A121C")]
		public float heightOffset;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A1250", Offset = "0x2A1250")]
		public float footSpeed;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A1284", Offset = "0x2A1284")]
		public float footRadius;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A12B8", Offset = "0x2A12B8")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A1300", Offset = "0x2A1300")]
		public float prediction;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A1334", Offset = "0x2A1334")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A1334", Offset = "0x2A1334")]
		public float footRotationWeight;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A1384", Offset = "0x2A1384")]
		public float footRotationSpeed;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A13B8", Offset = "0x2A13B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A13B8", Offset = "0x2A13B8")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A140C", Offset = "0x2A140C")]
		public bool rotateSolver;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A1440", Offset = "0x2A1440")]
		public float pelvisSpeed;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A1474", Offset = "0x2A1474")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A1474", Offset = "0x2A1474")]
		public float pelvisDamper;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A14C4", Offset = "0x2A14C4")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A14F8", Offset = "0x2A14F8")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A152C", Offset = "0x2A152C")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A1560", Offset = "0x2A1560")]
		public Quality quality;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1594", Offset = "0x2A1594")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A1594", Offset = "0x2A1594")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A15C8", Offset = "0x2A15C8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A15C8", Offset = "0x2A15C8")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A15FC", Offset = "0x2A15FC")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A15FC", Offset = "0x2A15FC")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1630", Offset = "0x2A1630")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A1630", Offset = "0x2A1630")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1664", Offset = "0x2A1664")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A1664", Offset = "0x2A1664")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool initiated;

		[Token(Token = "0x1700005A")]
		public Leg[] legs
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0xBFA6B4", Offset = "0xBFA6B4", VA = "0xBFA6B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1698", Offset = "0x2A1698")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000437")]
			[Address(RVA = "0xC04940", Offset = "0xC04940", VA = "0xC04940")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A16A8", Offset = "0x2A16A8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0xBFC734", Offset = "0xBFC734", VA = "0xBFC734")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A16B8", Offset = "0x2A16B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000439")]
			[Address(RVA = "0xC04948", Offset = "0xC04948", VA = "0xC04948")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A16C8", Offset = "0x2A16C8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public bool isGrounded
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0xC04950", Offset = "0xC04950", VA = "0xC04950")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A16D8", Offset = "0x2A16D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600043B")]
			[Address(RVA = "0xC04958", Offset = "0xC04958", VA = "0xC04958")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A16E8", Offset = "0x2A16E8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public Transform root
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0xBFABD8", Offset = "0xBFABD8", VA = "0xBFABD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A16F8", Offset = "0x2A16F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600043D")]
			[Address(RVA = "0xC04960", Offset = "0xC04960", VA = "0xC04960")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1708", Offset = "0x2A1708")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0xC01DBC", Offset = "0xC01DBC", VA = "0xC01DBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1718", Offset = "0x2A1718")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600043F")]
			[Address(RVA = "0xC04968", Offset = "0xC04968", VA = "0xC04968")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A1728", Offset = "0x2A1728")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0xC049AC", Offset = "0xC049AC", VA = "0xC049AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000060")]
		public Vector3 up
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0xBFC878", Offset = "0xBFC878", VA = "0xBFC878")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000061")]
		private bool useRootRotation
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0xC06678", Offset = "0xC06678", VA = "0xC06678")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xBFA4A4", Offset = "0xBFA4A4", VA = "0xBFA4A4")]
		public Grounding()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xC04A08", Offset = "0xC04A08", VA = "0xC04A08")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xC04F24", Offset = "0xC04F24", VA = "0xC04F24")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xBFB80C", Offset = "0xBFB80C", VA = "0xBFB80C")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xBFC448", Offset = "0xBFC448", VA = "0xBFC448")]
		public void Update()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xBFEE70", Offset = "0xBFEE70", VA = "0xBFEE70")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xBFB084", Offset = "0xBFB084", VA = "0xBFB084")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xC05294", Offset = "0xC05294", VA = "0xC05294")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xC06764", Offset = "0xC06764", VA = "0xC06764")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xC068F4", Offset = "0xC068F4", VA = "0xC068F4")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xC06A30", Offset = "0xC06A30", VA = "0xC06A30")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A1A2C", Offset = "0x2A1A2C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A1A2C", Offset = "0x2A1A2C")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverAim solver;

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xBE6F1C", Offset = "0xBE6F1C", VA = "0xBE6F1C")]
		public AimIK()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xBE6FA0", Offset = "0xBE6FA0", VA = "0xBE6FA0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1A8C", Offset = "0x2A1A8C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xBE7004", Offset = "0xBE7004", VA = "0xBE7004", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1AC0", Offset = "0x2A1AC0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xBE7068", Offset = "0xBE7068", VA = "0xBE7068")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1AF4", Offset = "0x2A1AF4")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xBE70CC", Offset = "0xBE70CC", VA = "0xBE70CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1B28", Offset = "0x2A1B28")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xBE7130", Offset = "0xBE7130", VA = "0xBE7130")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1B5C", Offset = "0x2A1B5C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xBE7194", Offset = "0xBE7194", VA = "0xBE7194", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A1B90", Offset = "0x2A1B90")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A1B90", Offset = "0x2A1B90")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverCCD solver;

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xBEA100", Offset = "0xBEA100", VA = "0xBEA100")]
		public CCDIK()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xBEA17C", Offset = "0xBEA17C", VA = "0xBEA17C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1BF0", Offset = "0x2A1BF0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xBEA1E0", Offset = "0xBEA1E0", VA = "0xBEA1E0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1C24", Offset = "0x2A1C24")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xBEA244", Offset = "0xBEA244", VA = "0xBEA244")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1C58", Offset = "0x2A1C58")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xBEA2A8", Offset = "0xBEA2A8", VA = "0xBEA2A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1C8C", Offset = "0x2A1C8C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xBEA30C", Offset = "0xBEA30C", VA = "0xBEA30C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A1CC0", Offset = "0x2A1CC0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A1CC0", Offset = "0x2A1CC0")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xBEADFC", Offset = "0xBEADFC", VA = "0xBEADFC")]
		public FABRIK()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xBEAE78", Offset = "0xBEAE78", VA = "0xBEAE78", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1D20", Offset = "0x2A1D20")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xBEAEDC", Offset = "0xBEAEDC", VA = "0xBEAEDC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1D54", Offset = "0x2A1D54")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xBEAF40", Offset = "0xBEAF40", VA = "0xBEAF40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1D88", Offset = "0x2A1D88")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xBEAFA4", Offset = "0xBEAFA4", VA = "0xBEAFA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1DBC", Offset = "0x2A1DBC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xBEB008", Offset = "0xBEB008", VA = "0xBEB008", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A1DF0", Offset = "0x2A1DF0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A1DF0", Offset = "0x2A1DF0")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xBEB9AC", Offset = "0xBEB9AC", VA = "0xBEB9AC")]
		public FABRIKRoot()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xBEBA28", Offset = "0xBEBA28", VA = "0xBEBA28", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1E50", Offset = "0x2A1E50")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xBEBA8C", Offset = "0xBEBA8C", VA = "0xBEBA8C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1E84", Offset = "0x2A1E84")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xBEBAF0", Offset = "0xBEBAF0", VA = "0xBEBAF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1EB8", Offset = "0x2A1EB8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xBEBB54", Offset = "0xBEBB54", VA = "0xBEBB54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1EEC", Offset = "0x2A1EEC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xBEBBB8", Offset = "0xBEBBB8", VA = "0xBEBBB8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A1F20", Offset = "0x2A1F20")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A1F20", Offset = "0x2A1F20")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BipedReferences references;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xBF8E30", Offset = "0xBF8E30", VA = "0xBF8E30")]
		public FullBodyBipedIK()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xBF8ED0", Offset = "0xBF8ED0", VA = "0xBF8ED0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1F80", Offset = "0x2A1F80")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xBF8F34", Offset = "0xBF8F34", VA = "0xBF8F34", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1FB4", Offset = "0x2A1FB4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xBF8F98", Offset = "0xBF8F98", VA = "0xBF8F98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A1FE8", Offset = "0x2A1FE8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xBF8FFC", Offset = "0xBF8FFC", VA = "0xBF8FFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A201C", Offset = "0x2A201C")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xBF9060", Offset = "0xBF9060", VA = "0xBF9060")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A2050", Offset = "0x2A2050")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xBF90C4", Offset = "0xBF90C4", VA = "0xBF90C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A2084", Offset = "0x2A2084")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xBF9128", Offset = "0xBF9128", VA = "0xBF9128")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xBF9164", Offset = "0xBF9164", VA = "0xBF9164", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xBF916C", Offset = "0xBF916C", VA = "0xBF916C")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xBF93F8", Offset = "0xBF93F8", VA = "0xBF93F8")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xBF987C", Offset = "0xBF987C", VA = "0xBF987C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A20B8", Offset = "0x2A20B8")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xBF98B0", Offset = "0xBF98B0", VA = "0xBF98B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A20EC", Offset = "0x2A20EC")]
		private void AutoDetectReferences()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000499")]
		[Address(RVA = "0xBE6F98", Offset = "0xBE6F98", VA = "0xBE6F98")]
		protected IK()
		{
		}

		[Token(Token = "0x600049A")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xC0B7E0", Offset = "0xC0B7E0", VA = "0xC0B7E0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xC0B8A4", Offset = "0xC0B8A4", VA = "0xC0B8A4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xC0B930", Offset = "0xC0B930", VA = "0xC0B930", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600049E")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600049F")]
		protected abstract void OpenScriptReference();
	}
	[Token(Token = "0x20000B4")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2120", Offset = "0x2A2120")]
		public IK[] IKComponents;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2154", Offset = "0x2A2154")]
		public Animator animator;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool fixedFrame;

		[Token(Token = "0x1700006D")]
		private bool animatePhysics
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xC0F350", Offset = "0xC0F350", VA = "0xC0F350")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xC0F348", Offset = "0xC0F348", VA = "0xC0F348")]
		public IKExecutionOrder()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xC0F418", Offset = "0xC0F418", VA = "0xC0F418")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xC0F4A0", Offset = "0xC0F4A0", VA = "0xC0F4A0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xC0F5B8", Offset = "0xC0F5B8", VA = "0xC0F5B8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xC0F5E8", Offset = "0xC0F5E8", VA = "0xC0F5E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xC0F4C4", Offset = "0xC0F4C4", VA = "0xC0F4C4")]
		private void FixTransforms()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A2188", Offset = "0x2A2188")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLeg solver;

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x113960C", Offset = "0x113960C", VA = "0x113960C")]
		public LegIK()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1139688", Offset = "0x1139688", VA = "0x1139688", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A21BC", Offset = "0x2A21BC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1139718", Offset = "0x1139718", VA = "0x1139718", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A21F0", Offset = "0x2A21F0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x11397A8", Offset = "0x11397A8", VA = "0x11397A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A2224", Offset = "0x2A2224")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x113980C", Offset = "0x113980C", VA = "0x113980C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A2258", Offset = "0x2A2258")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1139870", Offset = "0x1139870", VA = "0x1139870", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A228C", Offset = "0x2A228C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A228C", Offset = "0x2A228C")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLimb solver;

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1139878", Offset = "0x1139878", VA = "0x1139878")]
		public LimbIK()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x11398F4", Offset = "0x11398F4", VA = "0x11398F4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A22EC", Offset = "0x2A22EC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1139958", Offset = "0x1139958", VA = "0x1139958", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A2320", Offset = "0x2A2320")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x11399BC", Offset = "0x11399BC", VA = "0x11399BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A2354", Offset = "0x2A2354")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1139A20", Offset = "0x1139A20", VA = "0x1139A20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A2388", Offset = "0x2A2388")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x1139A84", Offset = "0x1139A84", VA = "0x1139A84", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A23BC", Offset = "0x2A23BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A23BC", Offset = "0x2A23BC")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1139A8C", Offset = "0x1139A8C", VA = "0x1139A8C")]
		public LookAtIK()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1139B08", Offset = "0x1139B08", VA = "0x1139B08", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A241C", Offset = "0x2A241C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1139B6C", Offset = "0x1139B6C", VA = "0x1139B6C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A2450", Offset = "0x2A2450")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1139BD0", Offset = "0x1139BD0", VA = "0x1139BD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A2484", Offset = "0x2A2484")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1139C34", Offset = "0x1139C34", VA = "0x1139C34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A24B8", Offset = "0x2A24B8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1139C98", Offset = "0x1139C98", VA = "0x1139C98", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
	[Token(Token = "0x20000B8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A24EC", Offset = "0x2A24EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A24EC", Offset = "0x2A24EC")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x11450E8", Offset = "0x11450E8", VA = "0x11450E8")]
		public TrigonometricIK()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1145164", Offset = "0x1145164", VA = "0x1145164", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A254C", Offset = "0x2A254C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x11451C8", Offset = "0x11451C8", VA = "0x11451C8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A2580", Offset = "0x2A2580")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x114522C", Offset = "0x114522C", VA = "0x114522C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A25B4", Offset = "0x2A25B4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1145290", Offset = "0x1145290", VA = "0x1145290")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A25E8", Offset = "0x2A25E8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x11452F4", Offset = "0x11452F4", VA = "0x11452F4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A261C", Offset = "0x2A261C")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000BA")]
		public class References
		{
			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform root;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform pelvis;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform spine;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Transform chest;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform neck;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Transform head;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform leftShoulder;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Transform leftUpperArm;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform leftForearm;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Transform leftHand;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform rightShoulder;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Transform rightUpperArm;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform rightForearm;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Transform rightHand;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform leftThigh;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Transform leftCalf;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftFoot;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Transform leftToes;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform rightThigh;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Transform rightCalf;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform rightFoot;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Transform rightToes;

			[Token(Token = "0x1700006E")]
			public bool isFilled
			{
				[Token(Token = "0x60004C9")]
				[Address(RVA = "0x11471E0", Offset = "0x11471E0", VA = "0x11471E0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006F")]
			public bool isEmpty
			{
				[Token(Token = "0x60004CA")]
				[Address(RVA = "0x1146B08", Offset = "0x1146B08", VA = "0x1146B08")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x11462CC", Offset = "0x11462CC", VA = "0x11462CC")]
			public References()
			{
			}

			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x11476F0", Offset = "0x11476F0", VA = "0x11476F0")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x114647C", Offset = "0x114647C", VA = "0x114647C")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x2A2650", Offset = "0x2A2650")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2650", Offset = "0x2A2650")]
		public References references;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A26C8", Offset = "0x2A26C8")]
		public IKSolverVR solver;

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x114622C", Offset = "0x114622C", VA = "0x114622C")]
		public VRIK()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x11462D4", Offset = "0x11462D4", VA = "0x11462D4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A26FC", Offset = "0x2A26FC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1146364", Offset = "0x1146364", VA = "0x1146364", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A2730", Offset = "0x2A2730")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x11463F4", Offset = "0x11463F4", VA = "0x11463F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A2764", Offset = "0x2A2764")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1146458", Offset = "0x1146458", VA = "0x1146458")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A2798", Offset = "0x2A2798")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1146A30", Offset = "0x1146A30", VA = "0x1146A30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A27CC", Offset = "0x2A27CC")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1146A64", Offset = "0x1146A64", VA = "0x1146A64", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1146A6C", Offset = "0x1146A6C", VA = "0x1146A6C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BB")]
	public class FABRIKChain
	{
		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public FABRIK ik;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A2800", Offset = "0x2A2800")]
		public float pull;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A2818", Offset = "0x2A2818")]
		public float pin;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int[] children;

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xBEB010", Offset = "0xBEB010", VA = "0xBEB010")]
		public FABRIKChain()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xBEB09C", Offset = "0xBEB09C", VA = "0xBEB09C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xBEB18C", Offset = "0xBEB18C", VA = "0xBEB18C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xBEB1B8", Offset = "0xBEB1B8", VA = "0xBEB1B8")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xBEB7F0", Offset = "0xBEB7F0", VA = "0xBEB7F0")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xBEB320", Offset = "0xBEB320", VA = "0xBEB320")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000BC")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool initiated;

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xBEBBC0", Offset = "0xBEBBC0", VA = "0xBEBBC0")]
		public FBBIKArmBending()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xBEBBC8", Offset = "0xBEBBC8", VA = "0xBEBBC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xBEC478", Offset = "0xBEC478", VA = "0xBEC478")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xBEC778", Offset = "0xBEC778", VA = "0xBEC778")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BE")]
		public class BendBone
		{
			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2E30", Offset = "0x2A2E30")]
			public Transform transform;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2E64", Offset = "0x2A2E64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A2E64", Offset = "0x2A2E64")]
			public float weight;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0xBF160C", Offset = "0xBF160C", VA = "0xBF160C")]
			public BendBone()
			{
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0xBF16BC", Offset = "0xBF16BC", VA = "0xBF16BC")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0xBED8A4", Offset = "0xBED8A4", VA = "0xBED8A4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0xBEDED8", Offset = "0xBEDED8", VA = "0xBEDED8")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2830", Offset = "0x2A2830")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2A2864", Offset = "0x2A2864")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2864", Offset = "0x2A2864")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A2864", Offset = "0x2A2864")]
		public float positionWeight;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A28DC", Offset = "0x2A28DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A28DC", Offset = "0x2A28DC")]
		public float bodyWeight;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A292C", Offset = "0x2A292C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A292C", Offset = "0x2A292C")]
		public float thighWeight;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A297C", Offset = "0x2A297C")]
		public bool handsPullBody;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2A29B0", Offset = "0x2A29B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A29B0", Offset = "0x2A29B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A29B0", Offset = "0x2A29B0")]
		public float rotationWeight;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2A28", Offset = "0x2A2A28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A2A28", Offset = "0x2A2A28")]
		public float bodyClampWeight;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2A78", Offset = "0x2A2A78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A2A78", Offset = "0x2A2A78")]
		public float headClampWeight;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2AC8", Offset = "0x2A2AC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A2AC8", Offset = "0x2A2AC8")]
		public float bendWeight;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2B18", Offset = "0x2A2B18")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2A2B4C", Offset = "0x2A2B4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2B4C", Offset = "0x2A2B4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A2B4C", Offset = "0x2A2B4C")]
		public float CCDWeight;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2BC4", Offset = "0x2A2BC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A2BC4", Offset = "0x2A2BC4")]
		public float roll;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2C14", Offset = "0x2A2C14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A2C14", Offset = "0x2A2C14")]
		public float damper;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2C68", Offset = "0x2A2C68")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2A2C9C", Offset = "0x2A2C9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2C9C", Offset = "0x2A2C9C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A2C9C", Offset = "0x2A2C9C")]
		public float postStretchWeight;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2D14", Offset = "0x2A2D14")]
		public float maxStretch;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2D48", Offset = "0x2A2D48")]
		public float stretchDamper;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2D7C", Offset = "0x2A2D7C")]
		public bool fixHead;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A2DB0", Offset = "0x2A2DB0")]
		public Transform[] stretchBones;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x2A2DE4", Offset = "0x2A2DE4")]
		public Vector3 chestDirection;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A2E18", Offset = "0x2A2E18")]
		public float chestDirectionWeight;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform[] chestBones;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 offset;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 headToBody;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float shoulderDist;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float leftShoulderDist;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float rightShoulderDist;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion chestRotation;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private int bendBonesCount;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private int ccdBonesCount;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int stretchBonesCount;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int chestBonesCount;

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xBEC904", Offset = "0xBEC904", VA = "0xBEC904")]
		public FBBIKHeadEffector()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xBECB34", Offset = "0xBECB34", VA = "0xBECB34")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xBED130", Offset = "0xBED130", VA = "0xBED130")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xBED8E8", Offset = "0xBED8E8", VA = "0xBED8E8")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xBEDF2C", Offset = "0xBEDF2C", VA = "0xBEDF2C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xBEECF0", Offset = "0xBEECF0", VA = "0xBEECF0")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xBEF1EC", Offset = "0xBEF1EC", VA = "0xBEF1EC")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xBEF7A4", Offset = "0xBEF7A4", VA = "0xBEF7A4")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xBF0810", Offset = "0xBF0810", VA = "0xBF0810")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xBEE924", Offset = "0xBEE924", VA = "0xBEE924")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xBF0B10", Offset = "0xBF0B10", VA = "0xBF0B10")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xBF0668", Offset = "0xBF0668", VA = "0xBF0668")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xBF047C", Offset = "0xBF047C", VA = "0xBF047C")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xBF10F0", Offset = "0xBF10F0", VA = "0xBF10F0")]
		private void OnDestroy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BF")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000C0")]
		public class ChildConstraint
		{
			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float pushElasticity;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float pullElasticity;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A2F70", Offset = "0x2A2F70")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A2F70", Offset = "0x2A2F70")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A2FA4", Offset = "0x2A2FA4")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A2FA4", Offset = "0x2A2FA4")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float crossFade;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float inverseCrossFade;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int chain1Index;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int chain2Index;

			[Token(Token = "0x17000070")]
			public float nominalDistance
			{
				[Token(Token = "0x60004FD")]
				[Address(RVA = "0xBF72F4", Offset = "0xBF72F4", VA = "0xBF72F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A2FD8", Offset = "0x2A2FD8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004FE")]
				[Address(RVA = "0xBF72FC", Offset = "0xBF72FC", VA = "0xBF72FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A2FE8", Offset = "0x2A2FE8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000071")]
			public bool isRigid
			{
				[Token(Token = "0x60004FF")]
				[Address(RVA = "0xBF7304", Offset = "0xBF7304", VA = "0xBF7304")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A2FF8", Offset = "0x2A2FF8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000500")]
				[Address(RVA = "0xBF730C", Offset = "0xBF730C", VA = "0xBF730C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3008", Offset = "0x2A3008")]
				private set
				{
				}
			}

			[Token(Token = "0x60004FC")]
			[Address(RVA = "0xBF72BC", Offset = "0xBF72BC", VA = "0xBF72BC")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000501")]
			[Address(RVA = "0xBF2ADC", Offset = "0xBF2ADC", VA = "0xBF2ADC")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000502")]
			[Address(RVA = "0xBF3860", Offset = "0xBF3860", VA = "0xBF3860")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0xBF6DC4", Offset = "0xBF6DC4", VA = "0xBF6DC4")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C1")]
		public enum Smoothing
		{
			[Token(Token = "0x40004CB")]
			None,
			[Token(Token = "0x40004CC")]
			Exponential,
			[Token(Token = "0x40004CD")]
			Cubic
		}

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A2EB4", Offset = "0x2A2EB4")]
		public float pin;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A2ECC", Offset = "0x2A2ECC")]
		public float pull;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A2EE4", Offset = "0x2A2EE4")]
		public float push;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A2EFC", Offset = "0x2A2EFC")]
		public float pushParent;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A2F18", Offset = "0x2A2F18")]
		public float reach;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int[] children;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float rootLength;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool initiated;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float length;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float distance;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private IKSolver.Point p;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float reachForce;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float pullParentSum;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[] crossFades;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float sqrMag1;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float sqrMag2;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float sqrMagDif;

		[Token(Token = "0x40004BF")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xBF1788", Offset = "0xBF1788", VA = "0xBF1788")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xBF194C", Offset = "0xBF194C", VA = "0xBF194C")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xBF1AA0", Offset = "0xBF1AA0", VA = "0xBF1AA0")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xBF1BF8", Offset = "0xBF1BF8", VA = "0xBF1BF8")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xBF1D04", Offset = "0xBF1D04", VA = "0xBF1D04")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xBF1E38", Offset = "0xBF1E38", VA = "0xBF1E38")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xBF2F24", Offset = "0xBF2F24", VA = "0xBF2F24")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xBF20DC", Offset = "0xBF20DC", VA = "0xBF20DC")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xBF3B70", Offset = "0xBF3B70", VA = "0xBF3B70")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xBF4158", Offset = "0xBF4158", VA = "0xBF4158")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xBF47D0", Offset = "0xBF47D0", VA = "0xBF47D0")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xBF591C", Offset = "0xBF591C", VA = "0xBF591C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xBF6478", Offset = "0xBF6478", VA = "0xBF6478")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xBF6914", Offset = "0xBF6914", VA = "0xBF6914")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xBF6328", Offset = "0xBF6328", VA = "0xBF6328")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xBF56AC", Offset = "0xBF56AC", VA = "0xBF56AC")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xBF62A0", Offset = "0xBF62A0", VA = "0xBF62A0")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xBF6B0C", Offset = "0xBF6B0C", VA = "0xBF6B0C")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xBF6098", Offset = "0xBF6098", VA = "0xBF6098")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xBF668C", Offset = "0xBF668C", VA = "0xBF668C")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C2")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform bone1;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform bone2;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone3;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform bendGoal;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 direction;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3018", Offset = "0x2A3018")]
		public float weight;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float clampF;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int chainIndex1;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int nodeIndex1;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int chainIndex2;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int nodeIndex2;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int chainIndex3;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int nodeIndex3;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3030", Offset = "0x2A3030")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A3030", Offset = "0x2A3030")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000072")]
		public bool initiated
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0xBF4D8C", Offset = "0xBF4D8C", VA = "0xBF4D8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3064", Offset = "0x2A3064")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000508")]
			[Address(RVA = "0xC0BDE4", Offset = "0xC0BDE4", VA = "0xC0BDE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3074", Offset = "0x2A3074")]
			private set
			{
			}
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xBF1898", Offset = "0xBF1898", VA = "0xBF1898")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xC0B9B0", Offset = "0xC0B9B0", VA = "0xC0B9B0")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xC0BA7C", Offset = "0xC0BA7C", VA = "0xC0BA7C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xBF2B44", Offset = "0xBF2B44", VA = "0xBF2B44")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xBF2B50", Offset = "0xBF2B50", VA = "0xBF2B50")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xC0C104", Offset = "0xC0C104", VA = "0xC0C104")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xC0C3EC", Offset = "0xC0C3EC", VA = "0xC0C3EC")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xBF4D94", Offset = "0xBF4D94", VA = "0xBF4D94")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xC0BDEC", Offset = "0xC0BDEC", VA = "0xC0BDEC")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xC0BF78", Offset = "0xC0BF78", VA = "0xC0BF78")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000C3")]
	public class IKEffector
	{
		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform bone;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform target;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3084", Offset = "0x2A3084")]
		public float positionWeight;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A309C", Offset = "0x2A309C")]
		public float rotationWeight;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 position;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Quaternion rotation;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 positionOffset;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A30B4", Offset = "0x2A30B4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A30B4", Offset = "0x2A30B4")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool effectChildNodes;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A30E8", Offset = "0x2A30E8")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform[] childBones;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Transform planeBone1;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform planeBone2;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Transform planeBone3;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float posW;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float rotW;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] localPositions;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool usePlaneNodes;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 animatedPosition;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool firstUpdate;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int chainIndex;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int nodeIndex;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int plane1ChainIndex;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int plane1NodeIndex;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int plane2ChainIndex;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int plane2NodeIndex;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int plane3ChainIndex;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private int plane3NodeIndex;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int[] childChainIndexes;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000073")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0xC0CE58", Offset = "0xC0CE58", VA = "0xC0CE58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3100", Offset = "0x2A3100")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000514")]
			[Address(RVA = "0xC0CE60", Offset = "0xC0CE60", VA = "0xC0CE60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3110", Offset = "0x2A3110")]
			private set
			{
			}
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xC0CA70", Offset = "0xC0CA70", VA = "0xC0CA70")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xC0CC5C", Offset = "0xC0CC5C", VA = "0xC0CC5C")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xBF105C", Offset = "0xBF105C", VA = "0xBF105C")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xC0CE68", Offset = "0xC0CE68", VA = "0xC0CE68")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xC0CF8C", Offset = "0xC0CF8C", VA = "0xC0CF8C")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xC0D54C", Offset = "0xC0D54C", VA = "0xC0D54C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xC0D9C0", Offset = "0xC0D9C0", VA = "0xC0D9C0")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xC0DB98", Offset = "0xC0DB98", VA = "0xC0DB98")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xC0DC94", Offset = "0xC0DC94", VA = "0xC0DC94")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xC0E67C", Offset = "0xC0E67C", VA = "0xC0E67C")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xC0E718", Offset = "0xC0E718", VA = "0xC0E718")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xC0EA00", Offset = "0xC0EA00", VA = "0xC0EA00")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xC0EEE8", Offset = "0xC0EEE8", VA = "0xC0EEE8")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000C4")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000C5")]
		public class BoneMap
		{
			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int chainIndex;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int nodeIndex;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 planePosition;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Quaternion maintainRotation;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public float length;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			public Quaternion animatedRotation;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Transform planeBone1;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Transform planeBone2;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private Transform planeBone3;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private int plane1ChainIndex;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private int plane1NodeIndex;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private int plane2NodeIndex;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000074")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x6000526")]
				[Address(RVA = "0xC0FA28", Offset = "0xC0FA28", VA = "0xC0FA28")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000075")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000529")]
				[Address(RVA = "0xC0FC08", Offset = "0xC0FC08", VA = "0xC0FC08")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000076")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x600053D")]
				[Address(RVA = "0xC10348", Offset = "0xC10348", VA = "0xC10348")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0xC0F9A0", Offset = "0xC0F9A0", VA = "0xC0F9A0")]
			public BoneMap()
			{
			}

			[Token(Token = "0x6000525")]
			[Address(RVA = "0xC0F9D8", Offset = "0xC0F9D8", VA = "0xC0F9D8")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000527")]
			[Address(RVA = "0xC0FB04", Offset = "0xC0FB04", VA = "0xC0FB04")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000528")]
			[Address(RVA = "0xC0FB78", Offset = "0xC0FB78", VA = "0xC0FB78")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x600052A")]
			[Address(RVA = "0xC0FC1C", Offset = "0xC0FC1C", VA = "0xC0FC1C")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x600052B")]
			[Address(RVA = "0xC0FD10", Offset = "0xC0FD10", VA = "0xC0FD10")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x600052C")]
			[Address(RVA = "0xC0FD18", Offset = "0xC0FD18", VA = "0xC0FD18")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x600052D")]
			[Address(RVA = "0xC0FEE0", Offset = "0xC0FEE0", VA = "0xC0FEE0")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x600052E")]
			[Address(RVA = "0xC10040", Offset = "0xC10040", VA = "0xC10040")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x600052F")]
			[Address(RVA = "0xC10130", Offset = "0xC10130", VA = "0xC10130")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000530")]
			[Address(RVA = "0xC105F4", Offset = "0xC105F4", VA = "0xC105F4")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000531")]
			[Address(RVA = "0xC10638", Offset = "0xC10638", VA = "0xC10638")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000532")]
			[Address(RVA = "0xC1067C", Offset = "0xC1067C", VA = "0xC1067C")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0xC106C4", Offset = "0xC106C4", VA = "0xC106C4")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0xC10868", Offset = "0xC10868", VA = "0xC10868")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0xC10C78", Offset = "0xC10C78", VA = "0xC10C78")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000536")]
			[Address(RVA = "0xC10CC0", Offset = "0xC10CC0", VA = "0xC10CC0")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0xC10E8C", Offset = "0xC10E8C", VA = "0xC10E8C")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0xC10F00", Offset = "0xC10F00", VA = "0xC10F00")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000539")]
			[Address(RVA = "0xC111E8", Offset = "0xC111E8", VA = "0xC111E8")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0xC114B0", Offset = "0xC114B0", VA = "0xC114B0")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x600053B")]
			[Address(RVA = "0xC115D8", Offset = "0xC115D8", VA = "0xC115D8")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600053C")]
			[Address(RVA = "0xC109CC", Offset = "0xC109CC", VA = "0xC109CC")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xC0F6AC", Offset = "0xC0F6AC", VA = "0xC0F6AC")]
		public IKMapping()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xC0F6B4", Offset = "0xC0F6B4", VA = "0xC0F6B4", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xC0F6BC", Offset = "0xC0F6BC", VA = "0xC0F6BC", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xC0F6C0", Offset = "0xC0F6C0", VA = "0xC0F6C0")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xC0F850", Offset = "0xC0F850", VA = "0xC0F850")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000C6")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform bone;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3120", Offset = "0x2A3120")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BoneMap boneMap;

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xC11804", Offset = "0xC11804", VA = "0xC11804")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xC118A8", Offset = "0xC118A8", VA = "0xC118A8")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xC11954", Offset = "0xC11954", VA = "0xC11954", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xC11A10", Offset = "0xC11A10", VA = "0xC11A10")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xC11A34", Offset = "0xC11A34", VA = "0xC11A34")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xC11A5C", Offset = "0xC11A5C", VA = "0xC11A5C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xC11B30", Offset = "0xC11B30", VA = "0xC11B30")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xC11B54", Offset = "0xC11B54", VA = "0xC11B54")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C7")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000C8")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000523")]
			Parent,
			[Token(Token = "0x4000524")]
			Bone1,
			[Token(Token = "0x4000525")]
			Bone2,
			[Token(Token = "0x4000526")]
			Bone3
		}

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform parentBone;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform bone1;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone2;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform bone3;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3138", Offset = "0x2A3138")]
		public float maintainRotationWeight;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3150", Offset = "0x2A3150")]
		public float weight;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xC11B90", Offset = "0xC11B90", VA = "0xC11B90")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xC11CD0", Offset = "0xC11CD0", VA = "0xC11CD0")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xC11E48", Offset = "0xC11E48", VA = "0xC11E48", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xC11EC8", Offset = "0xC11EC8", VA = "0xC11EC8")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xC11FD8", Offset = "0xC11FD8", VA = "0xC11FD8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xC11E34", Offset = "0xC11E34", VA = "0xC11E34")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xC1242C", Offset = "0xC1242C", VA = "0xC1242C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xC12524", Offset = "0xC12524", VA = "0xC12524")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xC1262C", Offset = "0xC1262C", VA = "0xC1262C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xC129D8", Offset = "0xC129D8", VA = "0xC129D8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xC12ADC", Offset = "0xC12ADC", VA = "0xC12ADC")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C9")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform[] spineBones;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform leftThighBone;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform rightThighBone;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3168", Offset = "0x2A3168")]
		public int iterations;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3184", Offset = "0x2A3184")]
		public float twistWeight;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int rootNodeIndex;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private BoneMap[] spine;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool useFABRIK;

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xC12D3C", Offset = "0xC12D3C", VA = "0xC12D3C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xC12EAC", Offset = "0xC12EAC", VA = "0xC12EAC")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xC13068", Offset = "0xC13068", VA = "0xC13068", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xC1304C", Offset = "0xC1304C", VA = "0xC1304C")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xC1346C", Offset = "0xC1346C", VA = "0xC1346C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xC134EC", Offset = "0xC134EC", VA = "0xC134EC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xC135A0", Offset = "0xC135A0", VA = "0xC135A0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xC13FDC", Offset = "0xC13FDC", VA = "0xC13FDC")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xC1401C", Offset = "0xC1401C", VA = "0xC1401C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xC144B0", Offset = "0xC144B0", VA = "0xC144B0")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xC14B40", Offset = "0xC14B40", VA = "0xC14B40")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xC14D58", Offset = "0xC14D58", VA = "0xC14D58")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xC14F54", Offset = "0xC14F54", VA = "0xC14F54")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CA")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000CB")]
		public class Point
		{
			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3280", Offset = "0x2A3280")]
			public float weight;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000574")]
			[Address(RVA = "0x11E6FD4", Offset = "0x11E6FD4", VA = "0x11E6FD4")]
			public Point()
			{
			}

			[Token(Token = "0x6000575")]
			[Address(RVA = "0x11E823C", Offset = "0x11E823C", VA = "0x11E823C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0x11E82B0", Offset = "0x11E82B0", VA = "0x11E82B0")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0x11E8480", Offset = "0x11E8480", VA = "0x11E8480")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000578")]
			[Address(RVA = "0x11E84C4", Offset = "0x11E84C4", VA = "0x11E84C4")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0x11E8508", Offset = "0x11E8508", VA = "0x11E8508")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x600057A")]
			[Address(RVA = "0x11E857C", Offset = "0x11E857C", VA = "0x11E857C")]
			public void UpdateSolverLocalState()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CC")]
		public class Bone : Point
		{
			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool isLimited;

			[Token(Token = "0x17000078")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600057E")]
				[Address(RVA = "0x11E7248", Offset = "0x11E7248", VA = "0x11E7248")]
				get
				{
					return null;
				}
				[Token(Token = "0x600057F")]
				[Address(RVA = "0x11E7370", Offset = "0x11E7370", VA = "0x11E7370")]
				set
				{
				}
			}

			[Token(Token = "0x600057B")]
			[Address(RVA = "0x11E6F04", Offset = "0x11E6F04", VA = "0x11E6F04")]
			public Bone()
			{
			}

			[Token(Token = "0x600057C")]
			[Address(RVA = "0x11E7084", Offset = "0x11E7084", VA = "0x11E7084")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600057D")]
			[Address(RVA = "0x11E715C", Offset = "0x11E715C", VA = "0x11E715C")]
			public Bone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000580")]
			[Address(RVA = "0x11E7408", Offset = "0x11E7408", VA = "0x11E7408")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000581")]
			[Address(RVA = "0x11E775C", Offset = "0x11E775C", VA = "0x11E775C")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000582")]
			[Address(RVA = "0x11E7C14", Offset = "0x11E7C14", VA = "0x11E7C14")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x11E7ED4", Offset = "0x11E7ED4", VA = "0x11E7ED4")]
			public void SetToSolverPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CD")]
		public class Node : Point
		{
			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float effectorPositionWeight;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public float effectorRotationWeight;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 offset;

			[Token(Token = "0x6000584")]
			[Address(RVA = "0x11E81F8", Offset = "0x11E81F8", VA = "0x11E81F8")]
			public Node()
			{
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0x11E81FC", Offset = "0x11E81FC", VA = "0x11E81FC")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0x11E8218", Offset = "0x11E8218", VA = "0x11E8218")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000CE")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000CF")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A31AC", Offset = "0x2A31AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A31AC", Offset = "0x2A31AC")]
		public float IKPositionWeight;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A31FC", Offset = "0x2A31FC")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A31FC", Offset = "0x2A31FC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		protected bool firstInitiation;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000077")]
		public bool initiated
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x11E64D0", Offset = "0x11E64D0", VA = "0x11E64D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3260", Offset = "0x2A3260")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x11E645C", Offset = "0x11E645C", VA = "0x11E645C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3270", Offset = "0x2A3270")]
			private set
			{
			}
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x11E5FB0", Offset = "0x11E5FB0", VA = "0x11E5FB0")]
		protected IKSolver()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x11E5FC8", Offset = "0x11E5FC8", VA = "0x11E5FC8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000560")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x11E6084", Offset = "0x11E6084", VA = "0x11E6084")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x11E6464", Offset = "0x11E6464", VA = "0x11E6464")]
		public void Update()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x11E64D8", Offset = "0x11E64D8", VA = "0x11E64D8", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x11E64E8", Offset = "0x11E64E8", VA = "0x11E64E8")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x11E64F4", Offset = "0x11E64F4", VA = "0x11E64F4")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x11E64FC", Offset = "0x11E64FC", VA = "0x11E64FC")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x11E65A0", Offset = "0x11E65A0", VA = "0x11E65A0")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x600056A")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x600056B")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x600056C")]
		public abstract void FixTransforms();

		[Token(Token = "0x600056D")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x600056E")]
		protected abstract void OnInitiate();

		[Token(Token = "0x600056F")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x11E65A8", Offset = "0x11E65A8", VA = "0x11E65A8")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x11E65D4", Offset = "0x11E65D4", VA = "0x11E65D4")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x11E6764", Offset = "0x11E6764", VA = "0x11E6764")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x11E6818", Offset = "0x11E6818", VA = "0x11E6818")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}
	}
	[Serializable]
	[Token(Token = "0x20000D0")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform transform;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 axis;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 polePosition;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3298", Offset = "0x2A3298")]
		public float poleWeight;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Transform poleTarget;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A32B0", Offset = "0x2A32B0")]
		public float clampWeight;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A32C8", Offset = "0x2A32C8")]
		public int clampSmoothing;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float step;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform lastTransform;

		[Token(Token = "0x17000079")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x11E88C4", Offset = "0x11E88C4", VA = "0x11E88C4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007A")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x11E89A0", Offset = "0x11E89A0", VA = "0x11E89A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700007B")]
		protected override int minBones
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x11E9CD0", Offset = "0x11E9CD0", VA = "0x11E9CD0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700007C")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x11EA534", Offset = "0x11EA534", VA = "0x11EA534", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x11E8648", Offset = "0x11E8648", VA = "0x11E8648")]
		public IKSolverAim()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x11E87BC", Offset = "0x11E87BC", VA = "0x11E87BC")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x11E8A7C", Offset = "0x11E8A7C", VA = "0x11E8A7C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x11E8E08", Offset = "0x11E8E08", VA = "0x11E8E08", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x11E9B18", Offset = "0x11E9B18", VA = "0x11E9B18")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x11E960C", Offset = "0x11E960C", VA = "0x11E960C")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x11E9CD8", Offset = "0x11E9CD8", VA = "0x11E9CD8")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D1")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x11EA61C", Offset = "0x11EA61C", VA = "0x11EA61C")]
		public IKSolverCCD()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x11EA620", Offset = "0x11EA620", VA = "0x11EA620")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x11EA758", Offset = "0x11EA758", VA = "0x11EA758", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x11EB0D8", Offset = "0x11EB0D8", VA = "0x11EB0D8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x11EBB80", Offset = "0x11EBB80", VA = "0x11EBB80")]
		private void Solve(Vector3 targetPosition)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D2")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool[] limitedBones;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700007D")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x11EE430", Offset = "0x11EE430", VA = "0x11EE430", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x11EC73C", Offset = "0x11EC73C", VA = "0x11EC73C")]
		public IKSolverFABRIK()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x11EC7E0", Offset = "0x11EC7E0", VA = "0x11EC7E0")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x11ED424", Offset = "0x11ED424", VA = "0x11ED424")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x11ED588", Offset = "0x11ED588", VA = "0x11ED588", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x11ED654", Offset = "0x11ED654", VA = "0x11ED654", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x11EDF1C", Offset = "0x11EDF1C", VA = "0x11EDF1C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x11EE438", Offset = "0x11EE438", VA = "0x11EE438")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x11EC8B4", Offset = "0x11EC8B4", VA = "0x11EC8B4")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x11ED52C", Offset = "0x11ED52C", VA = "0x11ED52C")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x11EE3B0", Offset = "0x11EE3B0", VA = "0x11EE3B0")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x11ED094", Offset = "0x11ED094", VA = "0x11ED094")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x11EF204", Offset = "0x11EF204", VA = "0x11EF204")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x11EF33C", Offset = "0x11EF33C", VA = "0x11EF33C")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x11EF4D0", Offset = "0x11EF4D0", VA = "0x11EF4D0")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x11EF650", Offset = "0x11EF650", VA = "0x11EF650")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x11EDB3C", Offset = "0x11EDB3C", VA = "0x11EDB3C")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x11EDD2C", Offset = "0x11EDD2C", VA = "0x11EDD2C")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x11EF924", Offset = "0x11EF924", VA = "0x11EF924")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x11EE924", Offset = "0x11EE924", VA = "0x11EE924")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x11ED4FC", Offset = "0x11ED4FC", VA = "0x11ED4FC")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x11F0638", Offset = "0x11F0638", VA = "0x11F0638")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x11EFB68", Offset = "0x11EFB68", VA = "0x11EFB68")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x11EE5A0", Offset = "0x11EE5A0", VA = "0x11EE5A0")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x11EE764", Offset = "0x11EE764", VA = "0x11EE764")]
		private void MapToSolverPositionsLimited()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D3")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int iterations;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A32E0", Offset = "0x2A32E0")]
		public float rootPin;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool[] isRoot;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x11F0834", Offset = "0x11F0834", VA = "0x11F0834")]
		public IKSolverFABRIKRoot()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x11F08CC", Offset = "0x11F08CC", VA = "0x11F08CC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x11F1A74", Offset = "0x11F1A74", VA = "0x11F1A74", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x11F1B54", Offset = "0x11F1B54", VA = "0x11F1B54", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x11F1C48", Offset = "0x11F1C48", VA = "0x11F1C48", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x11F1DBC", Offset = "0x11F1DBC", VA = "0x11F1DBC")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x11F1ED4", Offset = "0x11F1ED4", VA = "0x11F1ED4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x11F26B4", Offset = "0x11F26B4", VA = "0x11F26B4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x11F2950", Offset = "0x11F2950", VA = "0x11F2950", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x11F279C", Offset = "0x11F279C", VA = "0x11F279C")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x11F2230", Offset = "0x11F2230", VA = "0x11F2230")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000D4")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A32F8", Offset = "0x2A32F8")]
		public int iterations;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool FABRIKPass;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x11F2A08", Offset = "0x11F2A08", VA = "0x11F2A08")]
		public IKSolverFullBody()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x11F2B40", Offset = "0x11F2B40", VA = "0x11F2B40")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x11F2C74", Offset = "0x11F2C74", VA = "0x11F2C74")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x11F2CC8", Offset = "0x11F2CC8", VA = "0x11F2CC8")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x11F2E70", Offset = "0x11F2E70", VA = "0x11F2E70")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x11F2EF0", Offset = "0x11F2EF0", VA = "0x11F2EF0")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x11F2F78", Offset = "0x11F2F78", VA = "0x11F2F78", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x11F31C4", Offset = "0x11F31C4", VA = "0x11F31C4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x11F33D8", Offset = "0x11F33D8", VA = "0x11F33D8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x11F3694", Offset = "0x11F3694", VA = "0x11F3694", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x11F37BC", Offset = "0x11F37BC", VA = "0x11F37BC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x11F3900", Offset = "0x11F3900", VA = "0x11F3900", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x11F3AEC", Offset = "0x11F3AEC", VA = "0x11F3AEC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x11F3D58", Offset = "0x11F3D58", VA = "0x11F3D58", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x11F4174", Offset = "0x11F4174", VA = "0x11F4174", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x11F473C", Offset = "0x11F473C", VA = "0x11F473C", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x11F4798", Offset = "0x11F4798", VA = "0x11F4798", Slot = "15")]
		protected virtual void WritePose()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D5")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000574")]
		Body,
		[Token(Token = "0x4000575")]
		LeftShoulder,
		[Token(Token = "0x4000576")]
		RightShoulder,
		[Token(Token = "0x4000577")]
		LeftThigh,
		[Token(Token = "0x4000578")]
		RightThigh,
		[Token(Token = "0x4000579")]
		LeftHand,
		[Token(Token = "0x400057A")]
		RightHand,
		[Token(Token = "0x400057B")]
		LeftFoot,
		[Token(Token = "0x400057C")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x20000D6")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x400057E")]
		LeftArm,
		[Token(Token = "0x400057F")]
		RightArm,
		[Token(Token = "0x4000580")]
		LeftLeg,
		[Token(Token = "0x4000581")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x20000D7")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rootNode;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3314", Offset = "0x2A3314")]
		public float spineStiffness;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A332C", Offset = "0x2A332C")]
		public float pullBodyVertical;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3348", Offset = "0x2A3348")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3364", Offset = "0x2A3364")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A3364", Offset = "0x2A3364")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 offset;

		[Token(Token = "0x1700007E")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x11F4900", Offset = "0x11F4900", VA = "0x11F4900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x11F4B0C", Offset = "0x11F4B0C", VA = "0x11F4B0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x11F4B14", Offset = "0x11F4B14", VA = "0x11F4B14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x11F4B1C", Offset = "0x11F4B1C", VA = "0x11F4B1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x11F4B24", Offset = "0x11F4B24", VA = "0x11F4B24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x11F4B2C", Offset = "0x11F4B2C", VA = "0x11F4B2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x11F4B34", Offset = "0x11F4B34", VA = "0x11F4B34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x11F4B3C", Offset = "0x11F4B3C", VA = "0x11F4B3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x11F4B44", Offset = "0x11F4B44", VA = "0x11F4B44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x11F4B4C", Offset = "0x11F4B4C", VA = "0x11F4B4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x11F4B84", Offset = "0x11F4B84", VA = "0x11F4B84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x11F4BBC", Offset = "0x11F4BBC", VA = "0x11F4BBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x11F4BF4", Offset = "0x11F4BF4", VA = "0x11F4BF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x11F4C2C", Offset = "0x11F4C2C", VA = "0x11F4C2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x11F4C64", Offset = "0x11F4C64", VA = "0x11F4C64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x11F4C9C", Offset = "0x11F4C9C", VA = "0x11F4C9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x11F4CD4", Offset = "0x11F4CD4", VA = "0x11F4CD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x11F4D0C", Offset = "0x11F4D0C", VA = "0x11F4D0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x11F8314", Offset = "0x11F8314", VA = "0x11F8314")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3398", Offset = "0x2A3398")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x11F8324", Offset = "0x11F8324", VA = "0x11F8324")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A33A8", Offset = "0x2A33A8")]
			private set
			{
			}
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x11F48F0", Offset = "0x11F48F0", VA = "0x11F48F0")]
		public IKSolverFullBodyBiped()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x11F4D44", Offset = "0x11F4D44", VA = "0x11F4D44")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x11F4EA8", Offset = "0x11F4EA8", VA = "0x11F4EA8")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x11F4DA8", Offset = "0x11F4DA8", VA = "0x11F4DA8")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x11F4FB8", Offset = "0x11F4FB8", VA = "0x11F4FB8")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x11F4908", Offset = "0x11F4908", VA = "0x11F4908")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x11F50FC", Offset = "0x11F50FC", VA = "0x11F50FC")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x11F51FC", Offset = "0x11F51FC", VA = "0x11F51FC")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x11F52FC", Offset = "0x11F52FC", VA = "0x11F52FC")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x11F5410", Offset = "0x11F5410", VA = "0x11F5410")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x11F5418", Offset = "0x11F5418", VA = "0x11F5418")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x11F5450", Offset = "0x11F5450", VA = "0x11F5450")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x11F5560", Offset = "0x11F5560", VA = "0x11F5560", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x11F5848", Offset = "0x11F5848", VA = "0x11F5848")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x11F78A4", Offset = "0x11F78A4", VA = "0x11F78A4")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x11F7FC0", Offset = "0x11F7FC0", VA = "0x11F7FC0")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x11F806C", Offset = "0x11F806C", VA = "0x11F806C")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x11F7D78", Offset = "0x11F7D78", VA = "0x11F7D78")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x11F7E9C", Offset = "0x11F7E9C", VA = "0x11F7E9C")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x11F8330", Offset = "0x11F8330", VA = "0x11F8330")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x11F8410", Offset = "0x11F8410", VA = "0x11F8410", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x11F8638", Offset = "0x11F8638", VA = "0x11F8638")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x11F8848", Offset = "0x11F8848", VA = "0x11F8848")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x11F8AA8", Offset = "0x11F8AA8", VA = "0x11F8AA8")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x11F8DB0", Offset = "0x11F8DB0", VA = "0x11F8DB0", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x11F9354", Offset = "0x11F9354", VA = "0x11F9354", Slot = "15")]
		protected override void WritePose()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D8")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform target;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float tolerance;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int maxIterations;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useRotationLimits;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool XY;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Bone[] bones;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected float chainLength;

		[Token(Token = "0x17000091")]
		protected virtual int minBones
		{
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x11FA020", Offset = "0x11FA020", VA = "0x11FA020", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000092")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x11FA028", Offset = "0x11FA028", VA = "0x11FA028", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000093")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x11FA030", Offset = "0x11FA030", VA = "0x11FA030", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000094")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x11FA040", Offset = "0x11FA040", VA = "0x11FA040", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000095")]
		protected float positionOffset
		{
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x11EBAA0", Offset = "0x11EBAA0", VA = "0x11EBAA0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x11E8720", Offset = "0x11E8720", VA = "0x11E8720")]
		public IKSolverHeuristic()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x11F949C", Offset = "0x11F949C", VA = "0x11F949C")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x11F96BC", Offset = "0x11F96BC", VA = "0x11F96BC")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x11F9878", Offset = "0x11F9878", VA = "0x11F9878", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x11F98F8", Offset = "0x11F98F8", VA = "0x11F98F8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x11F9990", Offset = "0x11F9990", VA = "0x11F9990", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x11F9EE4", Offset = "0x11F9EE4", VA = "0x11F9EE4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x11F9EEC", Offset = "0x11F9EEC", VA = "0x11F9EEC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x11FA038", Offset = "0x11FA038", VA = "0x11FA038", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x11FA03C", Offset = "0x11FA03C", VA = "0x11FA03C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x11EA808", Offset = "0x11EA808", VA = "0x11EA808")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x11EB584", Offset = "0x11EB584", VA = "0x11EB584")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x11FA21C", Offset = "0x11FA21C", VA = "0x11FA21C")]
		private bool SingularityDetected()
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x20000D9")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A33B8", Offset = "0x2A33B8")]
		public float IKRotationWeight;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Point pelvis;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Point thigh;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Point calf;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Point foot;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Point toe;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3[] positions;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x11FA5D8", Offset = "0x11FA5D8", VA = "0x11FA5D8")]
		public IKSolverLeg()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x11FA878", Offset = "0x11FA878", VA = "0x11FA878", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x11FAE08", Offset = "0x11FAE08", VA = "0x11FAE08")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x11FAEA4", Offset = "0x11FAEA4", VA = "0x11FAEA4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x11FB0A4", Offset = "0x11FB0A4", VA = "0x11FB0A4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x11FB2E8", Offset = "0x11FB2E8", VA = "0x11FB2E8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x11FB358", Offset = "0x11FB358", VA = "0x11FB358", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x11FB3D4", Offset = "0x11FB3D4", VA = "0x11FB3D4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x11FBA14", Offset = "0x11FBA14", VA = "0x11FBA14", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x11FBA38", Offset = "0x11FBA38", VA = "0x11FBA38")]
		private void Solve()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x11FB470", Offset = "0x11FB470", VA = "0x11FB470")]
		private void Read()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x11FBB98", Offset = "0x11FBB98", VA = "0x11FBB98")]
		private void Write()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000DA")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000DB")]
		public enum BendModifier
		{
			[Token(Token = "0x40005AC")]
			Animation,
			[Token(Token = "0x40005AD")]
			Target,
			[Token(Token = "0x40005AE")]
			Parent,
			[Token(Token = "0x40005AF")]
			Arm,
			[Token(Token = "0x40005B0")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000DC")]
		public struct AxisDirection
		{
			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x11FE3C8", Offset = "0x11FE3C8", VA = "0x11FE3C8")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public AvatarIKGoal goal;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public BendModifier bendModifier;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A33D0", Offset = "0x2A33D0")]
		public float maintainRotationWeight;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A33E8", Offset = "0x2A33E8")]
		public float bendModifierWeight;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Transform bendGoal;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 animationNormal;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000096")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x11FE33C", Offset = "0x11FE33C", VA = "0x11FE33C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x11FC310", Offset = "0x11FC310", VA = "0x11FC310")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x11FC508", Offset = "0x11FC508", VA = "0x11FC508")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x11FC5B0", Offset = "0x11FC5B0", VA = "0x11FC5B0")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x11FC618", Offset = "0x11FC618", VA = "0x11FC618")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x11FC748", Offset = "0x11FC748", VA = "0x11FC748", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x11FCF74", Offset = "0x11FCF74", VA = "0x11FCF74", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x11FE1C0", Offset = "0x11FE1C0", VA = "0x11FE1C0", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x11FCC04", Offset = "0x11FCC04", VA = "0x11FCC04")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x11FD134", Offset = "0x11FD134", VA = "0x11FD134")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000DD")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000DE")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x1700009D")]
			public Vector3 forward
			{
				[Token(Token = "0x6000649")]
				[Address(RVA = "0x1201038", Offset = "0x1201038", VA = "0x1201038")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x11FE654", Offset = "0x11FE654", VA = "0x11FE654")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x11FFE58", Offset = "0x11FFE58", VA = "0x11FFE58")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x12003C4", Offset = "0x12003C4", VA = "0x12003C4")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x1201604", Offset = "0x1201604", VA = "0x1201604")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform target;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public LookAtBone[] spine;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public LookAtBone head;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3400", Offset = "0x2A3400")]
		public float bodyWeight;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3418", Offset = "0x2A3418")]
		public float headWeight;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3430", Offset = "0x2A3430")]
		public float eyesWeight;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3448", Offset = "0x2A3448")]
		public float clampWeight;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3460", Offset = "0x2A3460")]
		public float clampWeightHead;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3478", Offset = "0x2A3478")]
		public float clampWeightEyes;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3490", Offset = "0x2A3490")]
		public int clampSmoothing;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] spineForwards;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3[] headForwards;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] eyeForward;

		[Token(Token = "0x17000097")]
		private bool spineIsValid
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x11FF234", Offset = "0x11FF234", VA = "0x11FF234")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000098")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x11FF504", Offset = "0x11FF504", VA = "0x11FF504")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000099")]
		private bool headIsValid
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x11FF394", Offset = "0x11FF394", VA = "0x11FF394")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009A")]
		private bool headIsEmpty
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x11FF530", Offset = "0x11FF530", VA = "0x11FF530")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009B")]
		private bool eyesIsValid
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x11FF3A4", Offset = "0x11FF3A4", VA = "0x11FF3A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009C")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x11FF5D0", Offset = "0x11FF5D0", VA = "0x11FF5D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x11FE3F8", Offset = "0x11FE3F8", VA = "0x11FE3F8")]
		public IKSolverLookAt()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x11FE658", Offset = "0x11FE658", VA = "0x11FE658")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x11FE6FC", Offset = "0x11FE6FC", VA = "0x11FE6FC")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x11FE7C0", Offset = "0x11FE7C0", VA = "0x11FE7C0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x11FE8A4", Offset = "0x11FE8A4", VA = "0x11FE8A4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x11FE9B0", Offset = "0x11FE9B0", VA = "0x11FE9B0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x11FEAE4", Offset = "0x11FEAE4", VA = "0x11FEAE4")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x11FEC50", Offset = "0x11FEC50", VA = "0x11FEC50", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x11FEDF0", Offset = "0x11FEDF0", VA = "0x11FEDF0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x11FEFA8", Offset = "0x11FEFA8", VA = "0x11FEFA8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x11FF5FC", Offset = "0x11FF5FC", VA = "0x11FF5FC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x11FF950", Offset = "0x11FF950", VA = "0x11FF950", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x11FFB50", Offset = "0x11FFB50", VA = "0x11FFB50")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x11FFE74", Offset = "0x11FFE74", VA = "0x11FFE74", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x120053C", Offset = "0x120053C", VA = "0x120053C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1200684", Offset = "0x1200684", VA = "0x1200684")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1200988", Offset = "0x1200988", VA = "0x1200988")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1200CD8", Offset = "0x1200CD8", VA = "0x1200CD8")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1201114", Offset = "0x1201114", VA = "0x1201114")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x11FFBF8", Offset = "0x11FFBF8", VA = "0x11FFBF8")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000DF")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000E0")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x12017A4", Offset = "0x12017A4", VA = "0x12017A4")]
			public TrigonometricBone()
			{
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x1203528", Offset = "0x1203528", VA = "0x1203528")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x12045F8", Offset = "0x12045F8", VA = "0x12045F8")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0x11FC66C", Offset = "0x11FC66C", VA = "0x11FC66C")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform target;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A34A8", Offset = "0x2A34A8")]
		public float IKRotationWeight;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 bendNormal;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected bool directHierarchy;

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x11FC3B0", Offset = "0x11FC3B0", VA = "0x11FC3B0")]
		public IKSolverTrigonometric()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x12017A8", Offset = "0x12017A8", VA = "0x12017A8")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1201A18", Offset = "0x1201A18", VA = "0x1201A18")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1201C40", Offset = "0x1201C40", VA = "0x1201C40")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1201C50", Offset = "0x1201C50", VA = "0x1201C50")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x1201CF4", Offset = "0x1201CF4", VA = "0x1201CF4")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1201D08", Offset = "0x1201D08", VA = "0x1201D08")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1201D10", Offset = "0x1201D10", VA = "0x1201D10", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x1201E78", Offset = "0x1201E78", VA = "0x1201E78", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x1201FF4", Offset = "0x1201FF4", VA = "0x1201FF4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x120204C", Offset = "0x120204C", VA = "0x120204C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x12020B0", Offset = "0x12020B0", VA = "0x12020B0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1202674", Offset = "0x1202674", VA = "0x1202674")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x12026E0", Offset = "0x12026E0", VA = "0x12026E0")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1202EB0", Offset = "0x1202EB0", VA = "0x1202EB0")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1203120", Offset = "0x1203120", VA = "0x1203120", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x12033C0", Offset = "0x12033C0", VA = "0x12033C0")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x12032D8", Offset = "0x12032D8", VA = "0x12032D8")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1203760", Offset = "0x1203760", VA = "0x1203760", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1204708", Offset = "0x1204708", VA = "0x1204708", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x120470C", Offset = "0x120470C", VA = "0x120470C", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1204710", Offset = "0x1204710", VA = "0x1204710", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1204248", Offset = "0x1204248", VA = "0x1204248")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000E1")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000E2")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20000E3")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x400060C")]
				YawPitch,
				[Token(Token = "0x400060D")]
				FromTo
			}

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A3690", Offset = "0x2A3690")]
			public Transform target;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A36C4", Offset = "0x2A36C4")]
			public Transform bendGoal;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A36F8", Offset = "0x2A36F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A36F8", Offset = "0x2A36F8")]
			public float positionWeight;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A3748", Offset = "0x2A3748")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3748", Offset = "0x2A3748")]
			public float rotationWeight;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A3798", Offset = "0x2A3798")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A37CC", Offset = "0x2A37CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A37CC", Offset = "0x2A37CC")]
			public float shoulderRotationWeight;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A381C", Offset = "0x2A381C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A381C", Offset = "0x2A381C")]
			public float bendGoalWeight;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A386C", Offset = "0x2A386C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A386C", Offset = "0x2A386C")]
			public float swivelOffset;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A38C4", Offset = "0x2A38C4")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A38F8", Offset = "0x2A38F8")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A392C", Offset = "0x2A392C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A392C", Offset = "0x2A392C")]
			public float armLengthMlp;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A3980", Offset = "0x2A3980")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A39F4", Offset = "0x2A39F4")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A39F4", Offset = "0x2A39F4")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3A28", Offset = "0x2A3A28")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A3A28", Offset = "0x2A3A28")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private bool hasShoulder;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
			private Vector3 chestForward;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			private Vector3 chestUp;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000609")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x400060A")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x1700009F")]
			public Vector3 position
			{
				[Token(Token = "0x6000684")]
				[Address(RVA = "0x12111C4", Offset = "0x12111C4", VA = "0x12111C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3A5C", Offset = "0x2A3A5C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000685")]
				[Address(RVA = "0x12111D4", Offset = "0x12111D4", VA = "0x12111D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3A6C", Offset = "0x2A3A6C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A0")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000686")]
				[Address(RVA = "0x12111E0", Offset = "0x12111E0", VA = "0x12111E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3A7C", Offset = "0x2A3A7C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000687")]
				[Address(RVA = "0x12111F4", Offset = "0x12111F4", VA = "0x12111F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3A8C", Offset = "0x2A3A8C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A1")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000688")]
				[Address(RVA = "0x1211204", Offset = "0x1211204", VA = "0x1211204")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A2")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000689")]
				[Address(RVA = "0x121123C", Offset = "0x121123C", VA = "0x121123C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600068A")]
				[Address(RVA = "0x1211274", Offset = "0x1211274", VA = "0x1211274")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			private VirtualBone hand
			{
				[Token(Token = "0x600068B")]
				[Address(RVA = "0x12112AC", Offset = "0x12112AC", VA = "0x12112AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x1204BC4", Offset = "0x1204BC4", VA = "0x1204BC4")]
			public Arm()
			{
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0x12112E4", Offset = "0x12112E4", VA = "0x12112E4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x1211FB4", Offset = "0x1211FB4", VA = "0x1211FB4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x12122B0", Offset = "0x12122B0", VA = "0x12122B0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0x1212378", Offset = "0x1212378", VA = "0x1212378")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x120E520", Offset = "0x120E520", VA = "0x120E520")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x12135EC", Offset = "0x12135EC", VA = "0x12135EC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x1213688", Offset = "0x1213688", VA = "0x1213688", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x12129E4", Offset = "0x12129E4", VA = "0x12129E4")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x1212B10", Offset = "0x1212B10", VA = "0x1212B10")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x1213A40", Offset = "0x1213A40", VA = "0x1213A40")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public abstract class BodyPart
		{
			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3A9C", Offset = "0x2A3A9C")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A3A9C", Offset = "0x2A3A9C")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3AD0", Offset = "0x2A3AD0")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A3AD0", Offset = "0x2A3AD0")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			protected bool initiated;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			protected int index;

			[Token(Token = "0x170000A5")]
			public float sqrMag
			{
				[Token(Token = "0x600069C")]
				[Address(RVA = "0x1213BB8", Offset = "0x1213BB8", VA = "0x1213BB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3B14", Offset = "0x2A3B14")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600069D")]
				[Address(RVA = "0x1213BC0", Offset = "0x1213BC0", VA = "0x1213BC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3B24", Offset = "0x2A3B24")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			public float mag
			{
				[Token(Token = "0x600069E")]
				[Address(RVA = "0x1212B08", Offset = "0x1212B08", VA = "0x1212B08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3B34", Offset = "0x2A3B34")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600069F")]
				[Address(RVA = "0x1213BC8", Offset = "0x1213BC8", VA = "0x1213BC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3B44", Offset = "0x2A3B44")]
				private set
				{
				}
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x12110F0", Offset = "0x12110F0", VA = "0x12110F0")]
			protected BodyPart()
			{
			}

			[Token(Token = "0x6000697")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);

			[Token(Token = "0x6000698")]
			public abstract void PreSolve();

			[Token(Token = "0x6000699")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x600069A")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x600069B")]
			public abstract void ResetOffsets();

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x11FC1F0", Offset = "0x11FC1F0", VA = "0x11FC1F0")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x1213BD0", Offset = "0x1213BD0", VA = "0x1213BD0")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x1213DBC", Offset = "0x1213DBC", VA = "0x1213DBC")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x1213EC0", Offset = "0x1213EC0", VA = "0x1213EC0")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x120E270", Offset = "0x120E270", VA = "0x120E270")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x1213388", Offset = "0x1213388", VA = "0x1213388")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x1213EF4", Offset = "0x1213EF4", VA = "0x1213EF4")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x1214098", Offset = "0x1214098", VA = "0x1214098")]
			public void Visualize()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E5")]
		public class Footstep
		{
			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float stepSpeed;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 position;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion rotation;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool isSupportLeg;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3B54", Offset = "0x2A3B54")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A3B54", Offset = "0x2A3B54")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Vector3 stepFrom;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 stepTo;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public Quaternion stepFromRot;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private float supportLegW;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private float supportLegWV;

			[Token(Token = "0x170000A7")]
			public bool isStepping
			{
				[Token(Token = "0x60006A9")]
				[Address(RVA = "0x1214450", Offset = "0x1214450", VA = "0x1214450")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A8")]
			public float stepProgress
			{
				[Token(Token = "0x60006AA")]
				[Address(RVA = "0x1214470", Offset = "0x1214470", VA = "0x1214470")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3B88", Offset = "0x2A3B88")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006AB")]
				[Address(RVA = "0x1214478", Offset = "0x1214478", VA = "0x1214478")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3B98", Offset = "0x2A3B98")]
				private set
				{
				}
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x12140D8", Offset = "0x12140D8", VA = "0x12140D8")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x1214288", Offset = "0x1214288", VA = "0x1214288")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x1214480", Offset = "0x1214480", VA = "0x1214480")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x12145C0", Offset = "0x12145C0", VA = "0x12145C0")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x1214808", Offset = "0x1214808", VA = "0x1214808")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x1214A50", Offset = "0x1214A50", VA = "0x1214A50")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E6")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A3BA8", Offset = "0x2A3BA8")]
			public Transform target;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A3BDC", Offset = "0x2A3BDC")]
			public Transform bendGoal;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A3C10", Offset = "0x2A3C10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3C10", Offset = "0x2A3C10")]
			public float positionWeight;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A3C60", Offset = "0x2A3C60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3C60", Offset = "0x2A3C60")]
			public float rotationWeight;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A3CB0", Offset = "0x2A3CB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3CB0", Offset = "0x2A3CB0")]
			public float bendGoalWeight;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A3D00", Offset = "0x2A3D00")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3D00", Offset = "0x2A3D00")]
			public float swivelOffset;

			[NonSerialized]
			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3DB8", Offset = "0x2A3DB8")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A3DB8", Offset = "0x2A3DB8")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3DEC", Offset = "0x2A3DEC")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A3DEC", Offset = "0x2A3DEC")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3E20", Offset = "0x2A3E20")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A3E20", Offset = "0x2A3E20")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3E54", Offset = "0x2A3E54")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A3E54", Offset = "0x2A3E54")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private Vector3 footPosition;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			private Quaternion footRotation;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			private Vector3 bendNormal;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x170000A9")]
			public Vector3 position
			{
				[Token(Token = "0x60006B2")]
				[Address(RVA = "0x120E044", Offset = "0x120E044", VA = "0x120E044")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3E88", Offset = "0x2A3E88")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006B3")]
				[Address(RVA = "0x1214CF4", Offset = "0x1214CF4", VA = "0x1214CF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3E98", Offset = "0x2A3E98")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AA")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006B4")]
				[Address(RVA = "0x1214D00", Offset = "0x1214D00", VA = "0x1214D00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3EA8", Offset = "0x2A3EA8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006B5")]
				[Address(RVA = "0x1214D14", Offset = "0x1214D14", VA = "0x1214D14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3EB8", Offset = "0x2A3EB8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AB")]
			public bool hasToes
			{
				[Token(Token = "0x60006B6")]
				[Address(RVA = "0x1214D24", Offset = "0x1214D24", VA = "0x1214D24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3EC8", Offset = "0x2A3EC8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006B7")]
				[Address(RVA = "0x1214D2C", Offset = "0x1214D2C", VA = "0x1214D2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3ED8", Offset = "0x2A3ED8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AC")]
			public VirtualBone thigh
			{
				[Token(Token = "0x60006B8")]
				[Address(RVA = "0x1214D34", Offset = "0x1214D34", VA = "0x1214D34")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AD")]
			private VirtualBone calf
			{
				[Token(Token = "0x60006B9")]
				[Address(RVA = "0x1214D6C", Offset = "0x1214D6C", VA = "0x1214D6C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private VirtualBone foot
			{
				[Token(Token = "0x60006BA")]
				[Address(RVA = "0x1214DA4", Offset = "0x1214DA4", VA = "0x1214DA4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			private VirtualBone toes
			{
				[Token(Token = "0x60006BB")]
				[Address(RVA = "0x1214DDC", Offset = "0x1214DDC", VA = "0x1214DDC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x60006BC")]
				[Address(RVA = "0x120E000", Offset = "0x120E000", VA = "0x120E000")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B1")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60006BD")]
				[Address(RVA = "0x1214E14", Offset = "0x1214E14", VA = "0x1214E14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3EE8", Offset = "0x2A3EE8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006BE")]
				[Address(RVA = "0x1214E24", Offset = "0x1214E24", VA = "0x1214E24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3EF8", Offset = "0x2A3EF8")]
				private set
				{
				}
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x11FA774", Offset = "0x11FA774", VA = "0x11FA774")]
			public Leg()
			{
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x1214E30", Offset = "0x1214E30", VA = "0x1214E30", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x1215600", Offset = "0x1215600", VA = "0x1215600", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1215F98", Offset = "0x1215F98", VA = "0x1215F98", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x1215E70", Offset = "0x1215E70", VA = "0x1215E70")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1215B70", Offset = "0x1215B70", VA = "0x1215B70")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x11FBD74", Offset = "0x11FBD74", VA = "0x11FBD74")]
			public void Solve()
			{
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x1216784", Offset = "0x1216784", VA = "0x1216784", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x121695C", Offset = "0x121695C", VA = "0x121695C", Slot = "8")]
			public override void ResetOffsets()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E7")]
		public class Locomotion
		{
			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A3F08", Offset = "0x2A3F08")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A3F08", Offset = "0x2A3F08")]
			public float weight;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A3F58", Offset = "0x2A3F58")]
			public float footDistance;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A3F8C", Offset = "0x2A3F8C")]
			public float stepThreshold;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A3FC0", Offset = "0x2A3FC0")]
			public float angleThreshold;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A3FF4", Offset = "0x2A3FF4")]
			public float comAngleMlp;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4028", Offset = "0x2A4028")]
			public float maxVelocity;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A405C", Offset = "0x2A405C")]
			public float velocityFactor;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4090", Offset = "0x2A4090")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A4090", Offset = "0x2A4090")]
			public float maxLegStretch;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A40E4", Offset = "0x2A40E4")]
			public float rootSpeed;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4118", Offset = "0x2A4118")]
			public float stepSpeed;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A414C", Offset = "0x2A414C")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4180", Offset = "0x2A4180")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A41B4", Offset = "0x2A41B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A41B4", Offset = "0x2A41B4")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4208", Offset = "0x2A4208")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A423C", Offset = "0x2A423C")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4270", Offset = "0x2A4270")]
			public Vector3 offset;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A42E4", Offset = "0x2A42E4")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4318", Offset = "0x2A4318")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A434C", Offset = "0x2A434C")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A434C", Offset = "0x2A434C")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Footstep[] footsteps;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private int leftFootIndex;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private int rightFootIndex;

			[Token(Token = "0x170000B2")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60006C8")]
				[Address(RVA = "0x1216A64", Offset = "0x1216A64", VA = "0x1216A64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4380", Offset = "0x2A4380")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006C9")]
				[Address(RVA = "0x1216A74", Offset = "0x1216A74", VA = "0x1216A74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4390", Offset = "0x2A4390")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B3")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60006CF")]
				[Address(RVA = "0x1216F90", Offset = "0x1216F90", VA = "0x1216F90")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B4")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60006D0")]
				[Address(RVA = "0x1216FE4", Offset = "0x1216FE4", VA = "0x1216FE4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B5")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60006D1")]
				[Address(RVA = "0x1217038", Offset = "0x1217038", VA = "0x1217038")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000B6")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60006D2")]
				[Address(RVA = "0x121708C", Offset = "0x121708C", VA = "0x121708C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1204D44", Offset = "0x1204D44", VA = "0x1204D44")]
			public Locomotion()
			{
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x120B0E0", Offset = "0x120B0E0", VA = "0x120B0E0")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x1207E18", Offset = "0x1207E18", VA = "0x1207E18")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x1206D8C", Offset = "0x1206D8C", VA = "0x1206D8C")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x1206B5C", Offset = "0x1206B5C", VA = "0x1206B5C")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x120BD5C", Offset = "0x120BD5C", VA = "0x120BD5C")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x1216AC0", Offset = "0x1216AC0", VA = "0x1216AC0")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x1216CA8", Offset = "0x1216CA8", VA = "0x1216CA8")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x1216D3C", Offset = "0x1216D3C", VA = "0x1216D3C")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000E8")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A43A0", Offset = "0x2A43A0")]
			public Transform headTarget;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A43D4", Offset = "0x2A43D4")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4408", Offset = "0x2A4408")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A4408", Offset = "0x2A4408")]
			public float positionWeight;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4458", Offset = "0x2A4458")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A4458", Offset = "0x2A4458")]
			public float rotationWeight;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A44A8", Offset = "0x2A44A8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A44A8", Offset = "0x2A44A8")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A44F8", Offset = "0x2A44F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A44F8", Offset = "0x2A44F8")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4548", Offset = "0x2A4548")]
			public Transform chestGoal;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A457C", Offset = "0x2A457C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A457C", Offset = "0x2A457C")]
			public float chestGoalWeight;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A45CC", Offset = "0x2A45CC")]
			public float minHeadHeight;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4600", Offset = "0x2A4600")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A4600", Offset = "0x2A4600")]
			public float bodyPosStiffness;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4650", Offset = "0x2A4650")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A4650", Offset = "0x2A4650")]
			public float bodyRotStiffness;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A46A0", Offset = "0x2A46A0")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x2A46A0", Offset = "0x2A46A0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A46A0", Offset = "0x2A46A0")]
			public float neckStiffness;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4718", Offset = "0x2A4718")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A4718", Offset = "0x2A4718")]
			public float rotateChestByHands;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4768", Offset = "0x2A4768")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A4768", Offset = "0x2A4768")]
			public float chestClampWeight;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A47B8", Offset = "0x2A47B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A47B8", Offset = "0x2A47B8")]
			public float headClampWeight;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4808", Offset = "0x2A4808")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A483C", Offset = "0x2A483C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A483C", Offset = "0x2A483C")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A488C", Offset = "0x2A488C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A488C", Offset = "0x2A488C")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A49C0", Offset = "0x2A49C0")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A49C0", Offset = "0x2A49C0")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			private Quaternion headRotation;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private int pelvisIndex;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private int spineIndex;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			private int chestIndex;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private int neckIndex;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private int headIndex;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private float length;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			private bool hasChest;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
			private bool hasNeck;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private float headHeight;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private float sizeMlp;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			private Vector3 chestForward;

			[Token(Token = "0x170000B7")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x60006D7")]
				[Address(RVA = "0x1208244", Offset = "0x1208244", VA = "0x1208244")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x60006D8")]
				[Address(RVA = "0x12170E0", Offset = "0x12170E0", VA = "0x12170E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			public VirtualBone chest
			{
				[Token(Token = "0x60006D9")]
				[Address(RVA = "0x120E4D4", Offset = "0x120E4D4", VA = "0x120E4D4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private VirtualBone neck
			{
				[Token(Token = "0x60006DA")]
				[Address(RVA = "0x1217120", Offset = "0x1217120", VA = "0x1217120")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BB")]
			public VirtualBone head
			{
				[Token(Token = "0x60006DB")]
				[Address(RVA = "0x1216A80", Offset = "0x1216A80", VA = "0x1216A80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x60006DC")]
				[Address(RVA = "0x1217160", Offset = "0x1217160", VA = "0x1217160")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A49F4", Offset = "0x2A49F4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006DD")]
				[Address(RVA = "0x1217174", Offset = "0x1217174", VA = "0x1217174")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4A04", Offset = "0x2A4A04")]
				private set
				{
				}
			}

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x1204960", Offset = "0x1204960", VA = "0x1204960")]
			public Spine()
			{
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x1217184", Offset = "0x1217184", VA = "0x1217184", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x1218260", Offset = "0x1218260", VA = "0x1218260", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x1218554", Offset = "0x1218554", VA = "0x1218554", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x1218C3C", Offset = "0x1218C3C", VA = "0x1218C3C")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x120B560", Offset = "0x120B560", VA = "0x120B560")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x1219984", Offset = "0x1219984", VA = "0x1219984")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x121A338", Offset = "0x121A338", VA = "0x121A338")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x121A8D8", Offset = "0x121A8D8", VA = "0x121A8D8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x121AC80", Offset = "0x121AC80", VA = "0x121AC80", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x1218ED0", Offset = "0x1218ED0", VA = "0x1218ED0")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x120E054", Offset = "0x120E054", VA = "0x120E054")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x1219410", Offset = "0x1219410", VA = "0x1219410")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x121ADD8", Offset = "0x121ADD8", VA = "0x121ADD8")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x121A000", Offset = "0x121A000", VA = "0x121A000")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x1219C7C", Offset = "0x1219C7C", VA = "0x1219C7C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E9")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000687")]
			Pelvis,
			[Token(Token = "0x4000688")]
			Chest,
			[Token(Token = "0x4000689")]
			Head,
			[Token(Token = "0x400068A")]
			LeftHand,
			[Token(Token = "0x400068B")]
			RightHand,
			[Token(Token = "0x400068C")]
			LeftFoot,
			[Token(Token = "0x400068D")]
			RightFoot,
			[Token(Token = "0x400068E")]
			LeftHeel,
			[Token(Token = "0x400068F")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000EA")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000691")]
			Pelvis,
			[Token(Token = "0x4000692")]
			Chest,
			[Token(Token = "0x4000693")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000EB")]
		public class VirtualBone
		{
			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 readPosition;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Quaternion readRotation;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float length;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float sqrMag;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 axis;

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x11277F4", Offset = "0x11277F4", VA = "0x11277F4")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x1127850", Offset = "0x1127850", VA = "0x1127850")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x112787C", Offset = "0x112787C", VA = "0x112787C")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x1127C94", Offset = "0x1127C94", VA = "0x1127C94")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x11281FC", Offset = "0x11281FC", VA = "0x11281FC")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x11284C4", Offset = "0x11284C4", VA = "0x11284C4")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x112882C", Offset = "0x112882C", VA = "0x112882C")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x1128BE8", Offset = "0x1128BE8", VA = "0x1128BE8")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x1128E90", Offset = "0x1128E90", VA = "0x1128E90")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x11297A0", Offset = "0x11297A0", VA = "0x11297A0")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x1129A10", Offset = "0x1129A10", VA = "0x1129A10")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x112A154", Offset = "0x112A154", VA = "0x112A154")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x112A2A4", Offset = "0x112A2A4", VA = "0x112A2A4")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool hasChest;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool hasNeck;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool hasShoulders;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		private bool hasToes;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3[] readPositions;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 rootV;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int supportLegIndex;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A34C0", Offset = "0x2A34C0")]
		public bool plantFeet;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A34F4", Offset = "0x2A34F4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A34F4", Offset = "0x2A34F4")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A3528", Offset = "0x2A3528")]
		public Spine spine;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A355C", Offset = "0x2A355C")]
		public Arm leftArm;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A3590", Offset = "0x2A3590")]
		public Arm rightArm;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A35C4", Offset = "0x2A35C4")]
		public Leg leftLeg;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A35F8", Offset = "0x2A35F8")]
		public Leg rightLeg;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A362C", Offset = "0x2A362C")]
		public Locomotion locomotion;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Leg[] legs;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Arm[] arms;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headPosition;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 lastOffset;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 debugPos1;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 debugPos2;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Vector3 debugPos3;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3 debugPos4;

		[Token(Token = "0x1700009E")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x1207E10", Offset = "0x1207E10", VA = "0x1207E10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3660", Offset = "0x2A3660")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x120B0D8", Offset = "0x120B0D8", VA = "0x120B0D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A3670", Offset = "0x2A3670")]
			private set
			{
			}
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1204714", Offset = "0x1204714", VA = "0x1204714")]
		public IKSolverVR()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1204E78", Offset = "0x1204E78", VA = "0x1204E78")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x120544C", Offset = "0x120544C", VA = "0x120544C")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1205250", Offset = "0x1205250", VA = "0x1205250")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1206208", Offset = "0x1206208", VA = "0x1206208")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x1206654", Offset = "0x1206654", VA = "0x1206654")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x1206724", Offset = "0x1206724", VA = "0x1206724")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1206984", Offset = "0x1206984", VA = "0x1206984")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x12072DC", Offset = "0x12072DC", VA = "0x12072DC")]
		public void Reset()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x1208284", Offset = "0x1208284", VA = "0x1208284", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x12084A8", Offset = "0x12084A8", VA = "0x12084A8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x12086E4", Offset = "0x12086E4", VA = "0x12086E4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1208778", Offset = "0x1208778", VA = "0x1208778", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x120880C", Offset = "0x120880C", VA = "0x120880C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1208AE4", Offset = "0x1208AE4", VA = "0x1208AE4")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1205874", Offset = "0x1205874", VA = "0x1205874")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1205AA4", Offset = "0x1205AA4", VA = "0x1205AA4")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x1206088", Offset = "0x1206088", VA = "0x1206088")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x12074BC", Offset = "0x12074BC", VA = "0x12074BC")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1208F30", Offset = "0x1208F30", VA = "0x1208F30", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1208F90", Offset = "0x1208F90", VA = "0x1208F90", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x120AD4C", Offset = "0x120AD4C", VA = "0x120AD4C")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x12076DC", Offset = "0x12076DC", VA = "0x12076DC")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1209024", Offset = "0x1209024", VA = "0x1209024")]
		private void Solve()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x120B03C", Offset = "0x120B03C", VA = "0x120B03C")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x120B08C", Offset = "0x120B08C", VA = "0x120B08C")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x120AB68", Offset = "0x120AB68", VA = "0x120AB68")]
		private void Write()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x12107C8", Offset = "0x12107C8", VA = "0x12107C8")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000EC")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public IK ik;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4A14", Offset = "0x2A4A14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A4A14", Offset = "0x2A4A14")]
		public float weight;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4A64", Offset = "0x2A4A64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A4A64", Offset = "0x2A4A64")]
		public float parentChildCrossfade;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4AB4", Offset = "0x2A4AB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A4AB4", Offset = "0x2A4AB4")]
		public float twistAngleOffset;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 twistAxis;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 axis;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Transform parent;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform child;

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x11452FC", Offset = "0x11452FC", VA = "0x11452FC")]
		public TwistRelaxer()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x11453D4", Offset = "0x11453D4", VA = "0x11453D4")]
		public void Relax()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x114598C", Offset = "0x114598C", VA = "0x114598C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1145F4C", Offset = "0x1145F4C", VA = "0x1145F4C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1145FEC", Offset = "0x1145FEC", VA = "0x1145FEC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x114608C", Offset = "0x114608C", VA = "0x114608C")]
		private void OnDestroy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000ED")]
	public class InteractionEffector
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4B0C", Offset = "0x2A4B0C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A4B0C", Offset = "0x2A4B0C")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4B40", Offset = "0x2A4B40")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A4B40", Offset = "0x2A4B40")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4B74", Offset = "0x2A4B74")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A4B74", Offset = "0x2A4B74")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Poser poser;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IKEffector effector;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float timer;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float length;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float weight;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float fadeInSpeed;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float defaultPositionWeight;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float defaultRotationWeight;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float defaultPull;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float defaultReach;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float defaultPush;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPushParent;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float resetTimer;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool positionWeightUsed;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		private bool pullUsed;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		private bool reachUsed;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool pushUsed;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		private bool pushParentUsed;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		private bool pickedUp;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		private bool defaults;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform target;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private List<bool> triggered;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool started;

		[Token(Token = "0x170000BD")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x112B020", Offset = "0x112B020", VA = "0x112B020")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4BA8", Offset = "0x2A4BA8")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000702")]
			[Address(RVA = "0x112B018", Offset = "0x112B018", VA = "0x112B018")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4BB8", Offset = "0x2A4BB8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public bool isPaused
		{
			[Token(Token = "0x6000703")]
			[Address(RVA = "0x112B028", Offset = "0x112B028", VA = "0x112B028")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4BC8", Offset = "0x2A4BC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000704")]
			[Address(RVA = "0x112B030", Offset = "0x112B030", VA = "0x112B030")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4BD8", Offset = "0x2A4BD8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0x112B038", Offset = "0x112B038", VA = "0x112B038")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4BE8", Offset = "0x2A4BE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000706")]
			[Address(RVA = "0x112B040", Offset = "0x112B040", VA = "0x112B040")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4BF8", Offset = "0x2A4BF8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public bool inInteraction
		{
			[Token(Token = "0x6000707")]
			[Address(RVA = "0x112B048", Offset = "0x112B048", VA = "0x112B048")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C1")]
		public float progress
		{
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x112F01C", Offset = "0x112F01C", VA = "0x112F01C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x112AF84", Offset = "0x112AF84", VA = "0x112AF84")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x112B0D8", Offset = "0x112B0D8", VA = "0x112B0D8")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x112B1C8", Offset = "0x112B1C8", VA = "0x112B1C8")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x112B400", Offset = "0x112B400", VA = "0x112B400")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x112BA8C", Offset = "0x112BA8C", VA = "0x112BA8C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x112BEB4", Offset = "0x112BEB4", VA = "0x112BEB4")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x112BF3C", Offset = "0x112BF3C", VA = "0x112BF3C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x112CFE8", Offset = "0x112CFE8", VA = "0x112CFE8")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x112E210", Offset = "0x112E210", VA = "0x112E210")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x112E6DC", Offset = "0x112E6DC", VA = "0x112E6DC")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x112EE2C", Offset = "0x112EE2C", VA = "0x112EE2C")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x112F514", Offset = "0x112F514", VA = "0x112F514")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EE")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4C08", Offset = "0x2A4C08")]
		public LookAtIK ik;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4C3C", Offset = "0x2A4C3C")]
		public float lerpSpeed;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4C70", Offset = "0x2A4C70")]
		public float weightSpeed;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform lookAtTarget;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float stopLookTime;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float weight;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x112F8C0", Offset = "0x112F8C0", VA = "0x112F8C0")]
		public InteractionLookAt()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x112F8DC", Offset = "0x112F8DC", VA = "0x112F8DC")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x112FB10", Offset = "0x112FB10", VA = "0x112FB10")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x112FBFC", Offset = "0x112FBFC", VA = "0x112FBFC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x11303AC", Offset = "0x11303AC", VA = "0x11303AC")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x113055C", Offset = "0x113055C", VA = "0x113055C")]
		public void SolveHead()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A4CB4", Offset = "0x2A4CB4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A4CB4", Offset = "0x2A4CB4")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F0")]
		public class InteractionEvent
		{
			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4FF8", Offset = "0x2A4FF8")]
			public float time;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A502C", Offset = "0x2A502C")]
			public bool pause;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5060", Offset = "0x2A5060")]
			public bool pickUp;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5094", Offset = "0x2A5094")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A50C8", Offset = "0x2A50C8")]
			public Message[] messages;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A50FC", Offset = "0x2A50FC")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x1132200", Offset = "0x1132200", VA = "0x1132200")]
			public InteractionEvent()
			{
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x112F05C", Offset = "0x112F05C", VA = "0x112F05C")]
			public void Activate(Transform t)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F1")]
		public class Message
		{
			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5130", Offset = "0x2A5130")]
			public string function;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5164", Offset = "0x2A5164")]
			public GameObject recipient;

			[Token(Token = "0x40006E0")]
			private const string empty = "";

			[Token(Token = "0x6000738")]
			[Address(RVA = "0x113239C", Offset = "0x113239C", VA = "0x113239C")]
			public Message()
			{
			}

			[Token(Token = "0x6000739")]
			[Address(RVA = "0x1132208", Offset = "0x1132208", VA = "0x1132208")]
			public void Send(Transform t)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F2")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5198", Offset = "0x2A5198")]
			public Animator animator;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A51CC", Offset = "0x2A51CC")]
			public Animation animation;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5200", Offset = "0x2A5200")]
			public string animationState;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5234", Offset = "0x2A5234")]
			public float crossfadeTime;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5268", Offset = "0x2A5268")]
			public int layer;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A529C", Offset = "0x2A529C")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40006E7")]
			private const string empty = "";

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x1131E34", Offset = "0x1131E34", VA = "0x1131E34")]
			public AnimatorEvent()
			{
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x1131E48", Offset = "0x1131E48", VA = "0x1131E48")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x600073C")]
			[Address(RVA = "0x1131F70", Offset = "0x1131F70", VA = "0x1131F70")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x113208C", Offset = "0x113208C", VA = "0x113208C")]
			private void Activate(Animation animation)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F3")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20000F4")]
			public enum Type
			{
				[Token(Token = "0x40006EB")]
				PositionWeight,
				[Token(Token = "0x40006EC")]
				RotationWeight,
				[Token(Token = "0x40006ED")]
				PositionOffsetX,
				[Token(Token = "0x40006EE")]
				PositionOffsetY,
				[Token(Token = "0x40006EF")]
				PositionOffsetZ,
				[Token(Token = "0x40006F0")]
				Pull,
				[Token(Token = "0x40006F1")]
				Reach,
				[Token(Token = "0x40006F2")]
				RotateBoneWeight,
				[Token(Token = "0x40006F3")]
				Push,
				[Token(Token = "0x40006F4")]
				PushParent,
				[Token(Token = "0x40006F5")]
				PoserWeight
			}

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A52D0", Offset = "0x2A52D0")]
			public Type type;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5304", Offset = "0x2A5304")]
			public AnimationCurve curve;

			[Token(Token = "0x600073E")]
			[Address(RVA = "0x11323B4", Offset = "0x11323B4", VA = "0x11323B4")]
			public WeightCurve()
			{
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x1131194", Offset = "0x1131194", VA = "0x1131194")]
			public float GetValue(float timer)
			{
				return default(float);
			}
		}

		[Serializable]
		[Token(Token = "0x20000F5")]
		public class Multiplier
		{
			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5338", Offset = "0x2A5338")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A536C", Offset = "0x2A536C")]
			public float multiplier;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A53A0", Offset = "0x2A53A0")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x11323A4", Offset = "0x11323A4", VA = "0x11323A4")]
			public Multiplier()
			{
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x1131C84", Offset = "0x1131C84", VA = "0x1131C84")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}
		}

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4D14", Offset = "0x2A4D14")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4D48", Offset = "0x2A4D48")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A4D7C", Offset = "0x2A4D7C")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionEvent[] events;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4DB0", Offset = "0x2A4DB0")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A4DB0", Offset = "0x2A4DB0")]
		private float <length>k__BackingField;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4DE4", Offset = "0x2A4DE4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A4DE4", Offset = "0x2A4DE4")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private InteractionTarget[] targets;

		[Token(Token = "0x170000C2")]
		public float length
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x112C90C", Offset = "0x112C90C", VA = "0x112C90C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4F50", Offset = "0x2A4F50")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x113097C", Offset = "0x113097C", VA = "0x113097C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4F60", Offset = "0x2A4F60")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1130984", Offset = "0x1130984", VA = "0x1130984")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4F70", Offset = "0x2A4F70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x113098C", Offset = "0x113098C", VA = "0x113098C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A4F80", Offset = "0x2A4F80")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x1130CB4", Offset = "0x1130CB4", VA = "0x1130CB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		public Transform targetsRoot
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x112F390", Offset = "0x112F390", VA = "0x112F390")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x11306A4", Offset = "0x11306A4", VA = "0x11306A4")]
		public InteractionObject()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x1130724", Offset = "0x1130724", VA = "0x1130724")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A4E18", Offset = "0x2A4E18")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x1130788", Offset = "0x1130788", VA = "0x1130788")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A4E4C", Offset = "0x2A4E4C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x11307EC", Offset = "0x11307EC", VA = "0x11307EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A4E80", Offset = "0x2A4E80")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1130850", Offset = "0x1130850", VA = "0x1130850")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A4EB4", Offset = "0x2A4EB4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x11308B4", Offset = "0x11308B4", VA = "0x11308B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A4EE8", Offset = "0x2A4EE8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x1130918", Offset = "0x1130918", VA = "0x1130918")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A4F1C", Offset = "0x2A4F1C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x1130994", Offset = "0x1130994", VA = "0x1130994")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1130D5C", Offset = "0x1130D5C", VA = "0x1130D5C")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x112C838", Offset = "0x112C838", VA = "0x112C838")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x1130FF0", Offset = "0x1130FF0", VA = "0x1130FF0")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x112C5C4", Offset = "0x112C5C4", VA = "0x112C5C4")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x112C830", Offset = "0x112C830", VA = "0x112C830")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x112DAA4", Offset = "0x112DAA4", VA = "0x112DAA4")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x112E9FC", Offset = "0x112E9FC", VA = "0x112E9FC")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x1131CD8", Offset = "0x1131CD8", VA = "0x1131CD8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x11311C4", Offset = "0x11311C4", VA = "0x11311C4")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x1130FF8", Offset = "0x1130FF8", VA = "0x1130FF8")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x1131BF4", Offset = "0x1131BF4", VA = "0x1131BF4")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x1131CDC", Offset = "0x1131CDC", VA = "0x1131CDC")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x1131D6C", Offset = "0x1131D6C", VA = "0x1131D6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A4F90", Offset = "0x2A4F90")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x1131DD0", Offset = "0x1131DD0", VA = "0x1131DD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A4FC4", Offset = "0x2A4FC4")]
		private void OpenScriptReference()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A53D4", Offset = "0x2A53D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A53D4", Offset = "0x2A53D4")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000F7")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000F8")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5434", Offset = "0x2A5434")]
		public string targetTag;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5468", Offset = "0x2A5468")]
		public float fadeInTime;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A549C", Offset = "0x2A549C")]
		public float speed;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A54D0", Offset = "0x2A54D0")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2A5504", Offset = "0x2A5504")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5504", Offset = "0x2A5504")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x2A5504", Offset = "0x2A5504")]
		public Collider characterCollider;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A558C", Offset = "0x2A558C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x2A558C", Offset = "0x2A558C")]
		public Transform FPSCamera;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A55EC", Offset = "0x2A55EC")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5620", Offset = "0x2A5620")]
		public float camRaycastDistance;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A5654", Offset = "0x2A5654")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A5654", Offset = "0x2A5654")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RaycastHit raycastHit;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x2A5688", Offset = "0x2A5688")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5688", Offset = "0x2A5688")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A56E8", Offset = "0x2A56E8")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool initiated;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Collider lastCollider;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Collider c;

		[Token(Token = "0x170000C6")]
		public bool inInteraction
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x1132B4C", Offset = "0x1132B4C", VA = "0x1132B4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C7")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000763")]
			[Address(RVA = "0x112B1C0", Offset = "0x112B1C0", VA = "0x112B1C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x1135530", Offset = "0x1135530", VA = "0x1135530")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000765")]
			[Address(RVA = "0x1133F30", Offset = "0x1133F30", VA = "0x1133F30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A5854", Offset = "0x2A5854")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x1135538", Offset = "0x1135538", VA = "0x1135538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A5864", Offset = "0x2A5864")]
			private set
			{
			}
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x11323BC", Offset = "0x11323BC", VA = "0x11323BC")]
		public InteractionSystem()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x11328F4", Offset = "0x11328F4", VA = "0x11328F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A571C", Offset = "0x2A571C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x1132958", Offset = "0x1132958", VA = "0x1132958")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A5750", Offset = "0x2A5750")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x11329BC", Offset = "0x11329BC", VA = "0x11329BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A5784", Offset = "0x2A5784")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x1132A20", Offset = "0x1132A20", VA = "0x1132A20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A57B8", Offset = "0x2A57B8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x1132A84", Offset = "0x1132A84", VA = "0x1132A84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A57EC", Offset = "0x2A57EC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x1132AE8", Offset = "0x1132AE8", VA = "0x1132AE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A5820", Offset = "0x2A5820")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x1132D48", Offset = "0x1132D48", VA = "0x1132D48")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x1132E78", Offset = "0x1132E78", VA = "0x1132E78")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x1132FA4", Offset = "0x1132FA4", VA = "0x1132FA4")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x113308C", Offset = "0x113308C", VA = "0x113308C")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x11331F0", Offset = "0x11331F0", VA = "0x11331F0")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x1133398", Offset = "0x1133398", VA = "0x1133398")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x113347C", Offset = "0x113347C", VA = "0x113347C")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1133560", Offset = "0x1133560", VA = "0x1133560")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1133644", Offset = "0x1133644", VA = "0x1133644")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x11336D4", Offset = "0x11336D4", VA = "0x11336D4")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1133764", Offset = "0x1133764", VA = "0x1133764")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x11337E4", Offset = "0x11337E4", VA = "0x11337E4")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x11338C4", Offset = "0x11338C4", VA = "0x11338C4")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x11339CC", Offset = "0x11339CC", VA = "0x11339CC")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1133B08", Offset = "0x1133B08", VA = "0x1133B08")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1133F38", Offset = "0x1133F38", VA = "0x1133F38")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x11341FC", Offset = "0x11341FC", VA = "0x11341FC")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1134610", Offset = "0x1134610", VA = "0x1134610")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x1134A38", Offset = "0x1134A38", VA = "0x1134A38")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x1134A94", Offset = "0x1134A94", VA = "0x1134A94")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x1134B78", Offset = "0x1134B78", VA = "0x1134B78")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x1134D00", Offset = "0x1134D00", VA = "0x1134D00")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1134EEC", Offset = "0x1134EEC", VA = "0x1134EEC")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x11353B8", Offset = "0x11353B8", VA = "0x11353B8")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x113475C", Offset = "0x113475C", VA = "0x113475C")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1135540", Offset = "0x1135540", VA = "0x1135540", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x1136050", Offset = "0x1136050", VA = "0x1136050")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1136074", Offset = "0x1136074", VA = "0x1136074")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1136098", Offset = "0x1136098", VA = "0x1136098")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x11360BC", Offset = "0x11360BC", VA = "0x11360BC")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1136140", Offset = "0x1136140", VA = "0x1136140")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x11362B0", Offset = "0x11362B0", VA = "0x11362B0")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x11363EC", Offset = "0x11363EC", VA = "0x11363EC")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x113689C", Offset = "0x113689C", VA = "0x113689C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x11369CC", Offset = "0x11369CC", VA = "0x11369CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1136D34", Offset = "0x1136D34", VA = "0x1136D34")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x1135C98", Offset = "0x1135C98", VA = "0x1135C98")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1136E7C", Offset = "0x1136E7C", VA = "0x1136E7C")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x1137028", Offset = "0x1137028", VA = "0x1137028")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x113711C", Offset = "0x113711C", VA = "0x113711C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1137274", Offset = "0x1137274", VA = "0x1137274")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1137298", Offset = "0x1137298", VA = "0x1137298")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1132C34", Offset = "0x1132C34", VA = "0x1132C34")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1133DC4", Offset = "0x1133DC4", VA = "0x1133DC4")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x113787C", Offset = "0x113787C", VA = "0x113787C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A5874", Offset = "0x2A5874")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x11378E0", Offset = "0x11378E0", VA = "0x11378E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A58A8", Offset = "0x2A58A8")]
		private void OpenScriptReference()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A58DC", Offset = "0x2A58DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A58DC", Offset = "0x2A58DC")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FA")]
		public class Multiplier
		{
			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5C7C", Offset = "0x2A5C7C")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5CB0", Offset = "0x2A5CB0")]
			public float multiplier;

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x1138094", Offset = "0x1138094", VA = "0x1138094")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A593C", Offset = "0x2A593C")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5970", Offset = "0x2A5970")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A59A4", Offset = "0x2A59A4")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A59D8", Offset = "0x2A59D8")]
		public Transform pivot;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5A0C", Offset = "0x2A5A0C")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5A40", Offset = "0x2A5A40")]
		public float twistWeight;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5A74", Offset = "0x2A5A74")]
		public float swingWeight;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5AA8", Offset = "0x2A5AA8")]
		public bool rotateOnce;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Transform lastPivot;

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1137AC0", Offset = "0x1137AC0", VA = "0x1137AC0")]
		public InteractionTarget()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1137B78", Offset = "0x1137B78", VA = "0x1137B78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A5ADC", Offset = "0x2A5ADC")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1137BDC", Offset = "0x1137BDC", VA = "0x1137BDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A5B10", Offset = "0x2A5B10")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1137C40", Offset = "0x1137C40", VA = "0x1137C40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A5B44", Offset = "0x2A5B44")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1137CA4", Offset = "0x1137CA4", VA = "0x1137CA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A5B78", Offset = "0x2A5B78")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1137D08", Offset = "0x1137D08", VA = "0x1137D08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A5BAC", Offset = "0x2A5BAC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1137D6C", Offset = "0x1137D6C", VA = "0x1137D6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A5BE0", Offset = "0x2A5BE0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x11310C0", Offset = "0x11310C0", VA = "0x11310C0")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x112F438", Offset = "0x112F438", VA = "0x112F438")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x112C914", Offset = "0x112C914", VA = "0x112C914")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1137FCC", Offset = "0x1137FCC", VA = "0x1137FCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A5C14", Offset = "0x2A5C14")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1138030", Offset = "0x1138030", VA = "0x1138030")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A5C48", Offset = "0x2A5C48")]
		private void OpenScriptReference()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A5CE4", Offset = "0x2A5CE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A5CE4", Offset = "0x2A5CE4")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FC")]
		public class CharacterPosition
		{
			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5E14", Offset = "0x2A5E14")]
			public bool use;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5E48", Offset = "0x2A5E48")]
			public Vector2 offset;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5E7C", Offset = "0x2A5E7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A5E7C", Offset = "0x2A5E7C")]
			public float angleOffset;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5ED4", Offset = "0x2A5ED4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A5ED4", Offset = "0x2A5ED4")]
			public float maxAngle;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5F28", Offset = "0x2A5F28")]
			public float radius;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5F5C", Offset = "0x2A5F5C")]
			public bool orbit;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5F90", Offset = "0x2A5F90")]
			public bool fixYAxis;

			[Token(Token = "0x170000C9")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000798")]
				[Address(RVA = "0x1138AE4", Offset = "0x1138AE4", VA = "0x1138AE4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000CA")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000799")]
				[Address(RVA = "0x1138B20", Offset = "0x1138B20", VA = "0x1138B20")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x1138AC8", Offset = "0x1138AC8", VA = "0x1138AC8")]
			public CharacterPosition()
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x1138C4C", Offset = "0x1138C4C", VA = "0x1138C4C")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000FD")]
		public class CameraPosition
		{
			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5FC4", Offset = "0x2A5FC4")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5FF8", Offset = "0x2A5FF8")]
			public Vector3 direction;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A602C", Offset = "0x2A602C")]
			public float maxDistance;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6060", Offset = "0x2A6060")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A6060", Offset = "0x2A6060")]
			public float maxAngle;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A60B4", Offset = "0x2A60B4")]
			public bool fixYAxis;

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x11383F4", Offset = "0x11383F4", VA = "0x11383F4")]
			public CameraPosition()
			{
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x11384CC", Offset = "0x11384CC", VA = "0x11384CC")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x1138708", Offset = "0x1138708", VA = "0x1138708")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000FE")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000FF")]
			public class Interaction
			{
				[Token(Token = "0x400072F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A61E4", Offset = "0x2A61E4")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000730")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6218", Offset = "0x2A6218")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60007A0")]
				[Address(RVA = "0x1139604", Offset = "0x1139604", VA = "0x1139604")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6148", Offset = "0x2A6148")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A617C", Offset = "0x2A617C")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A61B0", Offset = "0x2A61B0")]
			public Interaction[] interactions;

			[Token(Token = "0x600079E")]
			[Address(RVA = "0x11395F4", Offset = "0x11395F4", VA = "0x11395F4")]
			public Range()
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x113824C", Offset = "0x113824C", VA = "0x113824C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A5D44", Offset = "0x2A5D44")]
		public Range[] ranges;

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x113809C", Offset = "0x113809C", VA = "0x113809C")]
		public InteractionTrigger()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x113811C", Offset = "0x113811C", VA = "0x113811C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A5D78", Offset = "0x2A5D78")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1138180", Offset = "0x1138180", VA = "0x1138180")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A5DAC", Offset = "0x2A5DAC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x11381E4", Offset = "0x11381E4", VA = "0x11381E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A5DE0", Offset = "0x2A5DE0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1138248", Offset = "0x1138248", VA = "0x1138248")]
		private void Start()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x113666C", Offset = "0x113666C", VA = "0x113666C")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000100")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x2000101")]
		public class Map
		{
			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform bone;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform target;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0xBF9E14", Offset = "0xBF9E14", VA = "0xBF9E14")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0xBFA33C", Offset = "0xBFA33C", VA = "0xBFA33C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0xBFA2BC", Offset = "0xBFA2BC", VA = "0xBFA2BC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0xBFA024", Offset = "0xBFA024", VA = "0xBFA024")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Map[] maps;

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xBF99D4", Offset = "0xBF99D4", VA = "0xBF99D4")]
		public GenericPoser()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xBF99DC", Offset = "0xBF99DC", VA = "0xBF99DC", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A624C", Offset = "0x2A624C")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xBF9EC4", Offset = "0xBF9EC4", VA = "0xBF9EC4", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xBF9EC8", Offset = "0xBF9EC8", VA = "0xBF9EC8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xBFA23C", Offset = "0xBFA23C", VA = "0xBFA23C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xBF9E44", Offset = "0xBF9E44", VA = "0xBF9E44")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xBF9CF0", Offset = "0xBF9CF0", VA = "0xBF9CF0")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}
	}
	[Token(Token = "0x2000102")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _poseRoot;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Transform[] children;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xC07FA0", Offset = "0xC07FA0", VA = "0xC07FA0")]
		public HandPoser()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xC07FA8", Offset = "0xC07FA8", VA = "0xC07FA8", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xC0809C", Offset = "0xC0809C", VA = "0xC0809C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xC08348", Offset = "0xC08348", VA = "0xC08348", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xC08498", Offset = "0xC08498", VA = "0xC08498", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xC0810C", Offset = "0xC0810C", VA = "0xC0810C")]
		private void StoreDefaultState()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Transform poseRoot;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A6280", Offset = "0x2A6280")]
		public float weight;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A6298", Offset = "0x2A6298")]
		public float localRotationWeight;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A62B0", Offset = "0x2A62B0")]
		public float localPositionWeight;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool initiated;

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x113B56C", Offset = "0x113B56C", VA = "0x113B56C")]
		protected Poser()
		{
		}

		[Token(Token = "0x60007B3")]
		public abstract void AutoMapping();

		[Token(Token = "0x60007B4")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60007B5")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60007B6")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x113B598", Offset = "0x113B598", VA = "0x113B598", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x113B5E8", Offset = "0x113B5E8", VA = "0x113B5E8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x113B620", Offset = "0x113B620", VA = "0x113B620", Slot = "6")]
		protected override void FixTransforms()
		{
		}
	}
	[Token(Token = "0x2000104")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2A62C8", Offset = "0x2A62C8")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x2000105")]
		public class Rigidbone
		{
			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Rigidbody r;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Transform t;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Collider collider;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Joint joint;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody c;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool updateAnchor;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float deltaTime;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vector3 lastPosition;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Quaternion lastRotation;

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x113BEF0", Offset = "0x113BEF0", VA = "0x113BEF0")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x113CF34", Offset = "0x113CF34", VA = "0x113CF34")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x113CC08", Offset = "0x113CC08", VA = "0x113CC08")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x2000106")]
		public class Child
		{
			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform t;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 localPosition;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Quaternion localRotation;

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x113C0DC", Offset = "0x113C0DC", VA = "0x113C0DC")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x113D160", Offset = "0x113D160", VA = "0x113D160")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x113D0EC", Offset = "0x113D0EC", VA = "0x113D0EC")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x2000181")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A6454", Offset = "0x2A6454")]
		private sealed class <DisableRagdollSmooth>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000A11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal RagdollUtility $this;

			[Token(Token = "0x4000A12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x4000A13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x4000A14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x1700013E")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A7D")]
				[Address(RVA = "0x113D9C8", Offset = "0x113D9C8", VA = "0x113D9C8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A7E")]
				[Address(RVA = "0x113D9D0", Offset = "0x113D9D0", VA = "0x113D9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x113C15C", Offset = "0x113C15C", VA = "0x113C15C")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x113D54C", Offset = "0x113D54C", VA = "0x113D54C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x113D9D8", Offset = "0x113D9D8", VA = "0x113D9D8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x113D9EC", Offset = "0x113D9EC", VA = "0x113D9EC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6340", Offset = "0x2A6340")]
		public IK ik;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6374", Offset = "0x2A6374")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A63A8", Offset = "0x2A63A8")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A63DC", Offset = "0x2A63DC")]
		public float applyVelocity;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6410", Offset = "0x2A6410")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Child[] children;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private IK[] allIKComponents;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool[] fixTransforms;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float ragdollWeight;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float ragdollWeightV;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool fixedFrame;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x170000CB")]
		private bool isRagdoll
		{
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x113B798", Offset = "0x113B798", VA = "0x113B798")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CC")]
		private bool ikUsed
		{
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x113C638", Offset = "0x113C638", VA = "0x113C638")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x113B63C", Offset = "0x113B63C", VA = "0x113B63C")]
		public RagdollUtility()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x113B768", Offset = "0x113B768", VA = "0x113B768")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x113B82C", Offset = "0x113B82C", VA = "0x113B82C")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x113B95C", Offset = "0x113B95C", VA = "0x113B95C")]
		public void Start()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x113B8DC", Offset = "0x113B8DC", VA = "0x113B8DC")]
		[DebuggerHidden]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x113C164", Offset = "0x113C164", VA = "0x113C164")]
		private void Update()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x113C4D0", Offset = "0x113C4D0", VA = "0x113C4D0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x113C578", Offset = "0x113C578", VA = "0x113C578")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x113C824", Offset = "0x113C824", VA = "0x113C824")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x113C604", Offset = "0x113C604", VA = "0x113C604")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x113C7F0", Offset = "0x113C7F0", VA = "0x113C7F0")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x113C8B0", Offset = "0x113C8B0", VA = "0x113C8B0")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x113C848", Offset = "0x113C848", VA = "0x113C848")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x113B874", Offset = "0x113B874", VA = "0x113B874")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x113C508", Offset = "0x113C508", VA = "0x113C508")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x113D3AC", Offset = "0x113D3AC", VA = "0x113D3AC")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 axis;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool initiated;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool applicationQuit;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x170000CD")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x113FED8", Offset = "0x113FED8", VA = "0x113FED8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000CE")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x113FF14", Offset = "0x113FF14", VA = "0x113FF14")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x113F9A4", Offset = "0x113F9A4", VA = "0x113F9A4")]
		protected RotationLimit()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x113FA4C", Offset = "0x113FA4C", VA = "0x113FA4C")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x113FAA0", Offset = "0x113FAA0", VA = "0x113FAA0")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x113FDFC", Offset = "0x113FDFC", VA = "0x113FDFC")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x113FEA8", Offset = "0x113FEA8", VA = "0x113FEA8")]
		public void Disable()
		{
		}

		[Token(Token = "0x60007D9")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x113FCD8", Offset = "0x113FCD8", VA = "0x113FCD8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x113FFEC", Offset = "0x113FFEC", VA = "0x113FFEC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x113FFF0", Offset = "0x113FFF0", VA = "0x113FFF0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x1140020", Offset = "0x1140020", VA = "0x1140020")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x1140148", Offset = "0x1140148", VA = "0x1140148")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x114048C", Offset = "0x114048C", VA = "0x114048C")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000108")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A64C4", Offset = "0x2A64C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A64C4", Offset = "0x2A64C4")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A6524", Offset = "0x2A6524")]
		public float limit;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A6540", Offset = "0x2A6540")]
		public float twistLimit;

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1140594", Offset = "0x1140594", VA = "0x1140594")]
		public RotationLimitAngle()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x11405B0", Offset = "0x11405B0", VA = "0x11405B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A655C", Offset = "0x2A655C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x1140614", Offset = "0x1140614", VA = "0x1140614")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A6590", Offset = "0x2A6590")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1140678", Offset = "0x1140678", VA = "0x1140678")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A65C4", Offset = "0x2A65C4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x11406DC", Offset = "0x11406DC", VA = "0x11406DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A65F8", Offset = "0x2A65F8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x1140740", Offset = "0x1140740", VA = "0x1140740", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x11407EC", Offset = "0x11407EC", VA = "0x11407EC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000109")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A662C", Offset = "0x2A662C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A662C", Offset = "0x2A662C")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool useLimits;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float min;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float max;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Quaternion lastRotation;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1140B40", Offset = "0x1140B40", VA = "0x1140B40")]
		public RotationLimitHinge()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1140C04", Offset = "0x1140C04", VA = "0x1140C04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A669C", Offset = "0x2A669C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1140C68", Offset = "0x1140C68", VA = "0x1140C68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A66D0", Offset = "0x2A66D0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x1140CCC", Offset = "0x1140CCC", VA = "0x1140CCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A6704", Offset = "0x2A6704")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1140D30", Offset = "0x1140D30", VA = "0x1140D30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A6738", Offset = "0x2A6738")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1140D94", Offset = "0x1140D94", VA = "0x1140D94", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1140DE4", Offset = "0x1140DE4", VA = "0x1140DE4")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x200010A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A676C", Offset = "0x2A676C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A676C", Offset = "0x2A676C")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x200010B")]
		public class ReachCone
		{
			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float volume;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 S;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 B;

			[Token(Token = "0x170000CF")]
			public Vector3 o
			{
				[Token(Token = "0x60007FF")]
				[Address(RVA = "0x1143E0C", Offset = "0x1143E0C", VA = "0x1143E0C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D0")]
			public Vector3 a
			{
				[Token(Token = "0x6000800")]
				[Address(RVA = "0x1143E50", Offset = "0x1143E50", VA = "0x1143E50")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D1")]
			public Vector3 b
			{
				[Token(Token = "0x6000801")]
				[Address(RVA = "0x1143E94", Offset = "0x1143E94", VA = "0x1143E94")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D2")]
			public Vector3 c
			{
				[Token(Token = "0x6000802")]
				[Address(RVA = "0x1143ED8", Offset = "0x1143ED8", VA = "0x1143ED8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D3")]
			public bool isValid
			{
				[Token(Token = "0x6000803")]
				[Address(RVA = "0x1142A58", Offset = "0x1142A58", VA = "0x1142A58")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x11433C8", Offset = "0x11433C8", VA = "0x11433C8")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x11435AC", Offset = "0x11435AC", VA = "0x11435AC")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200010C")]
		public class LimitPoint
		{
			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 point;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float tangentWeight;

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x1142A70", Offset = "0x1142A70", VA = "0x1142A70")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A67CC", Offset = "0x2A67CC")]
		public float twistLimit;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A67E8", Offset = "0x2A67E8")]
		public int smoothIterations;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x11411C0", Offset = "0x11411C0", VA = "0x11411C0")]
		public RotationLimitPolygonal()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x1141248", Offset = "0x1141248", VA = "0x1141248")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A6894", Offset = "0x2A6894")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x11412AC", Offset = "0x11412AC", VA = "0x11412AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A68C8", Offset = "0x2A68C8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x1141310", Offset = "0x1141310", VA = "0x1141310")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A68FC", Offset = "0x2A68FC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x1141374", Offset = "0x1141374", VA = "0x1141374")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A6930", Offset = "0x2A6930")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x11413D8", Offset = "0x11413D8", VA = "0x11413D8")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x1141B4C", Offset = "0x1141B4C", VA = "0x1141B4C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1141C2C", Offset = "0x1141C2C", VA = "0x1141C2C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x11424C4", Offset = "0x11424C4", VA = "0x11424C4")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x1141488", Offset = "0x1141488", VA = "0x1141488")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x1142B1C", Offset = "0x1142B1C", VA = "0x1142B1C")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x11437C8", Offset = "0x11437C8", VA = "0x11437C8")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x1143834", Offset = "0x1143834", VA = "0x1143834")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x11439BC", Offset = "0x11439BC", VA = "0x11439BC")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x1142050", Offset = "0x1142050", VA = "0x1142050")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x1143B88", Offset = "0x1143B88", VA = "0x1143B88")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200010D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x2A6964", Offset = "0x2A6964")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2A6964", Offset = "0x2A6964")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A69C4", Offset = "0x2A69C4")]
		public float twistLimit;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x1143F1C", Offset = "0x1143F1C", VA = "0x1143F1C")]
		public RotationLimitSpline()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x1143F2C", Offset = "0x1143F2C", VA = "0x1143F2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A6A10", Offset = "0x2A6A10")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1143F90", Offset = "0x1143F90", VA = "0x1143F90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A6A44", Offset = "0x2A6A44")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x1143FF4", Offset = "0x1143FF4", VA = "0x1143FF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A6A78", Offset = "0x2A6A78")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x1144058", Offset = "0x1144058", VA = "0x1144058")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x2A6AAC", Offset = "0x2A6AAC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x11440BC", Offset = "0x11440BC", VA = "0x11440BC")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x11440EC", Offset = "0x11440EC", VA = "0x11440EC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x1144198", Offset = "0x1144198", VA = "0x1144198")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x200010E")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6AE0", Offset = "0x2A6AE0")]
		public AimIK ik;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6B14", Offset = "0x2A6B14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A6B14", Offset = "0x2A6B14")]
		public float weight;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2A6B64", Offset = "0x2A6B64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6B64", Offset = "0x2A6B64")]
		public Transform target;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6BC4", Offset = "0x2A6BC4")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6BF8", Offset = "0x2A6BF8")]
		public float weightSmoothTime;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2A6C2C", Offset = "0x2A6C2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6C2C", Offset = "0x2A6C2C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6C8C", Offset = "0x2A6C8C")]
		public float maxRadiansDelta;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6CC0", Offset = "0x2A6CC0")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6CF4", Offset = "0x2A6CF4")]
		public float slerpSpeed;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6D28", Offset = "0x2A6D28")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6D5C", Offset = "0x2A6D5C")]
		public float minDistance;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6D90", Offset = "0x2A6D90")]
		public Vector3 offset;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2A6DC4", Offset = "0x2A6DC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6DC4", Offset = "0x2A6DC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A6DC4", Offset = "0x2A6DC4")]
		public float maxRootAngle;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2A6E40", Offset = "0x2A6E40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6E40", Offset = "0x2A6E40")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6EA0", Offset = "0x2A6EA0")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastTarget;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float switchWeight;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float switchWeightV;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float weightV;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 lastPosition;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 dir;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000D4")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0xBE5CBC", Offset = "0xBE5CBC", VA = "0xBE5CBC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xBE5A70", Offset = "0xBE5A70", VA = "0xBE5A70")]
		public AimController()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xBE5B78", Offset = "0xBE5B78", VA = "0xBE5B78")]
		private void Start()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xBE5E50", Offset = "0xBE5E50", VA = "0xBE5E50")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xBE6914", Offset = "0xBE6914", VA = "0xBE6914")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xBE6B18", Offset = "0xBE6B18", VA = "0xBE6B18")]
		private void RootRotation()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000110")]
		public class Pose
		{
			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool visualize;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public string name;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 direction;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float yaw;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float pitch;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float angleBuffer;

			[Token(Token = "0x6000817")]
			[Address(RVA = "0xBE77EC", Offset = "0xBE77EC", VA = "0xBE77EC")]
			public Pose()
			{
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0xBE7358", Offset = "0xBE7358", VA = "0xBE7358")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0xBE77E4", Offset = "0xBE77E4", VA = "0xBE77E4")]
			public void SetAngleBuffer(float value)
			{
			}
		}

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float angleBuffer;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Pose[] poses;

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xBE719C", Offset = "0xBE719C", VA = "0xBE719C")]
		public AimPoser()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xBE7228", Offset = "0xBE7228", VA = "0xBE7228")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xBE771C", Offset = "0xBE771C", VA = "0xBE771C")]
		public void SetPoseActive(Pose pose)
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000112")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000113")]
			public class EffectorLink
			{
				[Token(Token = "0x40007A0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7040", Offset = "0x2A7040")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40007A1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7074", Offset = "0x2A7074")]
				public float weight;

				[Token(Token = "0x600081F")]
				[Address(RVA = "0xBE80D0", Offset = "0xBE80D0", VA = "0xBE80D0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6F08", Offset = "0x2A6F08")]
			public Transform transform;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6F3C", Offset = "0x2A6F3C")]
			public Transform relativeTo;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6F70", Offset = "0x2A6F70")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6FA4", Offset = "0x2A6FA4")]
			public float verticalWeight;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6FD8", Offset = "0x2A6FD8")]
			public float horizontalWeight;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A700C", Offset = "0x2A700C")]
			public float speed;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool firstUpdate;

			[Token(Token = "0x600081C")]
			[Address(RVA = "0xBE807C", Offset = "0xBE807C", VA = "0xBE807C")]
			public Body()
			{
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0xBE7980", Offset = "0xBE7980", VA = "0xBE7980")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0xBE809C", Offset = "0xBE809C", VA = "0xBE809C")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A6ED4", Offset = "0x2A6ED4")]
		public Body[] bodies;

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xBE7814", Offset = "0xBE7814", VA = "0xBE7814")]
		public Amplifier()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xBE781C", Offset = "0xBE781C", VA = "0xBE781C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A70A8", Offset = "0x2A70A8")]
		public float tiltSpeed;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A70DC", Offset = "0x2A70DC")]
		public float tiltSensitivity;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7110", Offset = "0x2A7110")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7144", Offset = "0x2A7144")]
		public OffsetPose poseRight;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float tiltAngle;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xBE9DAC", Offset = "0xBE9DAC", VA = "0xBE9DAC")]
		public BodyTilt()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xBE9DCC", Offset = "0xBE9DCC", VA = "0xBE9DCC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xBE9E24", Offset = "0xBE9E24", VA = "0xBE9E24", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000116")]
		public abstract class HitPoint
		{
			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A71E0", Offset = "0x2A71E0")]
			public string name;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7214", Offset = "0x2A7214")]
			public Collider collider;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7248", Offset = "0x2A7248")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A7290", Offset = "0x2A7290")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A7290", Offset = "0x2A7290")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A72C4", Offset = "0x2A72C4")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A72C4", Offset = "0x2A72C4")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A72F8", Offset = "0x2A72F8")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A72F8", Offset = "0x2A72F8")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A732C", Offset = "0x2A732C")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A732C", Offset = "0x2A732C")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float length;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float crossFadeSpeed;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000D6")]
			public bool inProgress
			{
				[Token(Token = "0x6000828")]
				[Address(RVA = "0xC08AAC", Offset = "0xC08AAC", VA = "0xC08AAC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000D7")]
			protected float crossFader
			{
				[Token(Token = "0x6000829")]
				[Address(RVA = "0xC091BC", Offset = "0xC091BC", VA = "0xC091BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A7360", Offset = "0x2A7360")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600082A")]
				[Address(RVA = "0xC091C4", Offset = "0xC091C4", VA = "0xC091C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A7370", Offset = "0x2A7370")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D8")]
			protected float timer
			{
				[Token(Token = "0x600082B")]
				[Address(RVA = "0xC091B4", Offset = "0xC091B4", VA = "0xC091B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A7380", Offset = "0x2A7380")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600082C")]
				[Address(RVA = "0xC091CC", Offset = "0xC091CC", VA = "0xC091CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A7390", Offset = "0x2A7390")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D9")]
			protected Vector3 force
			{
				[Token(Token = "0x600082D")]
				[Address(RVA = "0xC091D4", Offset = "0xC091D4", VA = "0xC091D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A73A0", Offset = "0x2A73A0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600082E")]
				[Address(RVA = "0xC091E4", Offset = "0xC091E4", VA = "0xC091E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A73B0", Offset = "0x2A73B0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DA")]
			protected Vector3 point
			{
				[Token(Token = "0x600082F")]
				[Address(RVA = "0xC091F0", Offset = "0xC091F0", VA = "0xC091F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A73C0", Offset = "0x2A73C0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000830")]
				[Address(RVA = "0xC09200", Offset = "0xC09200", VA = "0xC09200")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A73D0", Offset = "0x2A73D0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000827")]
			[Address(RVA = "0xC091A0", Offset = "0xC091A0", VA = "0xC091A0")]
			protected HitPoint()
			{
			}

			[Token(Token = "0x6000831")]
			[Address(RVA = "0xC09040", Offset = "0xC09040", VA = "0xC09040")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000832")]
			[Address(RVA = "0xC08BD8", Offset = "0xC08BD8", VA = "0xC08BD8")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000833")]
			protected abstract float GetLength();

			[Token(Token = "0x6000834")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000835")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);
		}

		[Serializable]
		[Token(Token = "0x2000117")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x2000118")]
			public class EffectorLink
			{
				[Token(Token = "0x40007B7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A747C", Offset = "0x2A747C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40007B8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A74B0", Offset = "0x2A74B0")]
				public float weight;

				[Token(Token = "0x40007B9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Vector3 lastValue;

				[Token(Token = "0x40007BA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Vector3 current;

				[Token(Token = "0x600083A")]
				[Address(RVA = "0xC0A008", Offset = "0xC0A008", VA = "0xC0A008")]
				public EffectorLink()
				{
				}

				[Token(Token = "0x600083B")]
				[Address(RVA = "0xC09E68", Offset = "0xC09E68", VA = "0xC09E68")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600083C")]
				[Address(RVA = "0xC09BB4", Offset = "0xC09BB4", VA = "0xC09BB4")]
				public void CrossFadeStart()
				{
				}
			}

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A73E0", Offset = "0x2A73E0")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7414", Offset = "0x2A7414")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7448", Offset = "0x2A7448")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000836")]
			[Address(RVA = "0xC09910", Offset = "0xC09910", VA = "0xC09910")]
			public HitPointEffector()
			{
			}

			[Token(Token = "0x6000837")]
			[Address(RVA = "0xC09924", Offset = "0xC09924", VA = "0xC09924", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000838")]
			[Address(RVA = "0xC09B44", Offset = "0xC09B44", VA = "0xC09B44", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000839")]
			[Address(RVA = "0xC09BC8", Offset = "0xC09BC8", VA = "0xC09BC8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000119")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x200011A")]
			public class BoneLink
			{
				[Token(Token = "0x40007BE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A754C", Offset = "0x2A754C")]
				public Transform bone;

				[Token(Token = "0x40007BF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7580", Offset = "0x2A7580")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A7580", Offset = "0x2A7580")]
				public float weight;

				[Token(Token = "0x40007C0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Quaternion lastValue;

				[Token(Token = "0x40007C1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private Quaternion current;

				[Token(Token = "0x6000841")]
				[Address(RVA = "0xC09848", Offset = "0xC09848", VA = "0xC09848")]
				public BoneLink()
				{
				}

				[Token(Token = "0x6000842")]
				[Address(RVA = "0xC09670", Offset = "0xC09670", VA = "0xC09670")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000843")]
				[Address(RVA = "0xC09358", Offset = "0xC09358", VA = "0xC09358")]
				public void CrossFadeStart()
				{
				}
			}

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A74E4", Offset = "0x2A74E4")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7518", Offset = "0x2A7518")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600083D")]
			[Address(RVA = "0xC0920C", Offset = "0xC0920C", VA = "0xC0920C")]
			public HitPointBone()
			{
			}

			[Token(Token = "0x600083E")]
			[Address(RVA = "0xC09220", Offset = "0xC09220", VA = "0xC09220", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600083F")]
			[Address(RVA = "0xC092E8", Offset = "0xC092E8", VA = "0xC092E8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0xC0936C", Offset = "0xC0936C", VA = "0xC0936C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}
		}

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7178", Offset = "0x2A7178")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A71AC", Offset = "0x2A71AC")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000D5")]
		public bool inProgress
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0xC089CC", Offset = "0xC089CC", VA = "0xC089CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xC089C4", Offset = "0xC089C4", VA = "0xC089C4")]
		public HitReaction()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xC08AC8", Offset = "0xC08AC8", VA = "0xC08AC8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xC08D6C", Offset = "0xC08D6C", VA = "0xC08D6C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x200011C")]
		public abstract class Offset
		{
			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7638", Offset = "0x2A7638")]
			public string name;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A766C", Offset = "0x2A766C")]
			public Collider collider;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A76A0", Offset = "0x2A76A0")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A76E8", Offset = "0x2A76E8")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A76E8", Offset = "0x2A76E8")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A771C", Offset = "0x2A771C")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A771C", Offset = "0x2A771C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A7750", Offset = "0x2A7750")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A7750", Offset = "0x2A7750")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A7784", Offset = "0x2A7784")]
			[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A7784", Offset = "0x2A7784")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float length;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float crossFadeSpeed;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000DB")]
			protected float crossFader
			{
				[Token(Token = "0x6000848")]
				[Address(RVA = "0xC0A724", Offset = "0xC0A724", VA = "0xC0A724")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A77B8", Offset = "0x2A77B8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000849")]
				[Address(RVA = "0xC0A72C", Offset = "0xC0A72C", VA = "0xC0A72C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A77C8", Offset = "0x2A77C8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DC")]
			protected float timer
			{
				[Token(Token = "0x600084A")]
				[Address(RVA = "0xC0A734", Offset = "0xC0A734", VA = "0xC0A734")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A77D8", Offset = "0x2A77D8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600084B")]
				[Address(RVA = "0xC0A73C", Offset = "0xC0A73C", VA = "0xC0A73C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A77E8", Offset = "0x2A77E8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DD")]
			protected Vector3 force
			{
				[Token(Token = "0x600084C")]
				[Address(RVA = "0xC0A744", Offset = "0xC0A744", VA = "0xC0A744")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A77F8", Offset = "0x2A77F8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600084D")]
				[Address(RVA = "0xC0A754", Offset = "0xC0A754", VA = "0xC0A754")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A7808", Offset = "0x2A7808")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DE")]
			protected Vector3 point
			{
				[Token(Token = "0x600084E")]
				[Address(RVA = "0xC0A760", Offset = "0xC0A760", VA = "0xC0A760")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A7818", Offset = "0x2A7818")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600084F")]
				[Address(RVA = "0xC0A770", Offset = "0xC0A770", VA = "0xC0A770")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A7828", Offset = "0x2A7828")]
				private set
				{
				}
			}

			[Token(Token = "0x6000847")]
			[Address(RVA = "0xC0A710", Offset = "0xC0A710", VA = "0xC0A710")]
			protected Offset()
			{
			}

			[Token(Token = "0x6000850")]
			[Address(RVA = "0xC0A5A8", Offset = "0xC0A5A8", VA = "0xC0A5A8")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0xC0A128", Offset = "0xC0A128", VA = "0xC0A128")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000852")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000853")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000854")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);
		}

		[Serializable]
		[Token(Token = "0x200011D")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x200011E")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x40007D2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A78D4", Offset = "0x2A78D4")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x40007D3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7908", Offset = "0x2A7908")]
				public float weight;

				[Token(Token = "0x40007D4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Vector3 lastValue;

				[Token(Token = "0x40007D5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Vector3 current;

				[Token(Token = "0x6000859")]
				[Address(RVA = "0xC0AF98", Offset = "0xC0AF98", VA = "0xC0AF98")]
				public PositionOffsetLink()
				{
				}

				[Token(Token = "0x600085A")]
				[Address(RVA = "0xC0AE28", Offset = "0xC0AE28", VA = "0xC0AE28")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600085B")]
				[Address(RVA = "0xC0AB1C", Offset = "0xC0AB1C", VA = "0xC0AB1C")]
				public void CrossFadeStart()
				{
				}
			}

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7838", Offset = "0x2A7838")]
			public int forceDirCurveIndex;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A786C", Offset = "0x2A786C")]
			public int upDirCurveIndex;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A78A0", Offset = "0x2A78A0")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000855")]
			[Address(RVA = "0xC0A77C", Offset = "0xC0A77C", VA = "0xC0A77C")]
			public PositionOffset()
			{
			}

			[Token(Token = "0x6000856")]
			[Address(RVA = "0xC0A798", Offset = "0xC0A798", VA = "0xC0A798", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0xC0AAAC", Offset = "0xC0AAAC", VA = "0xC0AAAC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000858")]
			[Address(RVA = "0xC0AB30", Offset = "0xC0AB30", VA = "0xC0AB30", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200011F")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x2000120")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x40007D9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A79A4", Offset = "0x2A79A4")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x40007DA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A79D8", Offset = "0x2A79D8")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A79D8", Offset = "0x2A79D8")]
				public float weight;

				[Token(Token = "0x40007DB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private Quaternion lastValue;

				[Token(Token = "0x40007DC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private Quaternion current;

				[Token(Token = "0x6000860")]
				[Address(RVA = "0xC0B718", Offset = "0xC0B718", VA = "0xC0B718")]
				public RotationOffsetLink()
				{
				}

				[Token(Token = "0x6000861")]
				[Address(RVA = "0xC0B56C", Offset = "0xC0B56C", VA = "0xC0B56C")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000862")]
				[Address(RVA = "0xC0B168", Offset = "0xC0B168", VA = "0xC0B168")]
				public void CrossFadeStart()
				{
				}
			}

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A793C", Offset = "0x2A793C")]
			public int curveIndex;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7970", Offset = "0x2A7970")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600085C")]
			[Address(RVA = "0xC0AFA0", Offset = "0xC0AFA0", VA = "0xC0AFA0")]
			public RotationOffset()
			{
			}

			[Token(Token = "0x600085D")]
			[Address(RVA = "0xC0AFB4", Offset = "0xC0AFB4", VA = "0xC0AFB4", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0xC0B0F8", Offset = "0xC0B0F8", VA = "0xC0B0F8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600085F")]
			[Address(RVA = "0xC0B17C", Offset = "0xC0B17C", VA = "0xC0B17C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}
		}

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A75D0", Offset = "0x2A75D0")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7604", Offset = "0x2A7604")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xC0A010", Offset = "0xC0A010", VA = "0xC0A010")]
		public HitReactionVRIK()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xC0A018", Offset = "0xC0A018", VA = "0xC0A018", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xC0A2BC", Offset = "0xC0A2BC", VA = "0xC0A2BC")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000122")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000123")]
			public class EffectorLink
			{
				[Token(Token = "0x40007EA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7BE4", Offset = "0x2A7BE4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40007EB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7C18", Offset = "0x2A7C18")]
				public float weight;

				[Token(Token = "0x6000869")]
				[Address(RVA = "0x112AF7C", Offset = "0x112AF7C", VA = "0x112AF7C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7A90", Offset = "0x2A7A90")]
			public Transform transform;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7AC4", Offset = "0x2A7AC4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7AF8", Offset = "0x2A7AF8")]
			public float speed;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7B2C", Offset = "0x2A7B2C")]
			public float acceleration;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7B60", Offset = "0x2A7B60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A7B60", Offset = "0x2A7B60")]
			public float matchVelocity;

			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7BB0", Offset = "0x2A7BB0")]
			public float gravity;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 delta;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3 direction;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 lastPosition;

			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private bool firstUpdate;

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x112AF54", Offset = "0x112AF54", VA = "0x112AF54")]
			public Body()
			{
			}

			[Token(Token = "0x6000867")]
			[Address(RVA = "0x112A6B4", Offset = "0x112A6B4", VA = "0x112A6B4")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000868")]
			[Address(RVA = "0x112A8EC", Offset = "0x112A8EC", VA = "0x112A8EC")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}
		}

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7A28", Offset = "0x2A7A28")]
		public Body[] bodies;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7A5C", Offset = "0x2A7A5C")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x112A618", Offset = "0x112A618", VA = "0x112A618")]
		public Inertia()
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x112A638", Offset = "0x112A638", VA = "0x112A638")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x112A7FC", Offset = "0x112A7FC", VA = "0x112A7FC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000125")]
		public class OffsetLimits
		{
			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7CC4", Offset = "0x2A7CC4")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7CF8", Offset = "0x2A7CF8")]
			public float spring;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7D2C", Offset = "0x2A7D2C")]
			public bool x;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7D60", Offset = "0x2A7D60")]
			public bool y;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7D94", Offset = "0x2A7D94")]
			public bool z;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7DC8", Offset = "0x2A7DC8")]
			public float minX;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7DFC", Offset = "0x2A7DFC")]
			public float maxX;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7E30", Offset = "0x2A7E30")]
			public float minY;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7E64", Offset = "0x2A7E64")]
			public float maxY;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7E98", Offset = "0x2A7E98")]
			public float minZ;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7ECC", Offset = "0x2A7ECC")]
			public float maxZ;

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x113A630", Offset = "0x113A630", VA = "0x113A630")]
			public OffsetLimits()
			{
			}

			[Token(Token = "0x6000873")]
			[Address(RVA = "0x1139EB0", Offset = "0x1139EB0", VA = "0x1139EB0")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000874")]
			[Address(RVA = "0x113A638", Offset = "0x113A638", VA = "0x113A638")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000875")]
			[Address(RVA = "0x113A694", Offset = "0x113A694", VA = "0x113A694")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}
		}

		[Token(Token = "0x2000182")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A7F00", Offset = "0x2A7F00")]
		private sealed class <Initiate>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000A15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal OffsetModifier $this;

			[Token(Token = "0x4000A16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x4000A17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x4000A18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x17000140")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A83")]
				[Address(RVA = "0x113A588", Offset = "0x113A588", VA = "0x113A588", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000141")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A84")]
				[Address(RVA = "0x113A590", Offset = "0x113A590", VA = "0x113A590", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x1139D44", Offset = "0x1139D44", VA = "0x1139D44")]
			[DebuggerHidden]
			public <Initiate>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x113A358", Offset = "0x113A358", VA = "0x113A358", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x113A598", Offset = "0x113A598", VA = "0x113A598", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x113A5AC", Offset = "0x113A5AC", VA = "0x113A5AC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7C4C", Offset = "0x2A7C4C")]
		public float weight;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7C80", Offset = "0x2A7C80")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected float lastTime;

		[Token(Token = "0x170000DF")]
		protected float deltaTime
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0x112A8C0", Offset = "0x112A8C0", VA = "0x112A8C0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x112A628", Offset = "0x112A628", VA = "0x112A628")]
		protected OffsetModifier()
		{
		}

		[Token(Token = "0x600086C")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x1139CA0", Offset = "0x1139CA0", VA = "0x1139CA0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x1139CC4", Offset = "0x1139CC4", VA = "0x1139CC4")]
		[DebuggerHidden]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x1139D4C", Offset = "0x1139D4C", VA = "0x1139D4C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x112AE58", Offset = "0x112AE58", VA = "0x112AE58")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x113A1CC", Offset = "0x113A1CC", VA = "0x113A1CC", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000183")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A7FD8", Offset = "0x2A7FD8")]
		private sealed class <Initiate>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000A19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal OffsetModifierVRIK $this;

			[Token(Token = "0x4000A1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal object $current;

			[Token(Token = "0x4000A1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal bool $disposing;

			[Token(Token = "0x4000A1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal int $PC;

			[Token(Token = "0x17000142")]
			private object System.Collections.Generic.IEnumerator<object>.Current
			{
				[Token(Token = "0x6000A89")]
				[Address(RVA = "0x113ADBC", Offset = "0x113ADBC", VA = "0x113ADBC", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000143")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A8A")]
				[Address(RVA = "0x113ADC4", Offset = "0x113ADC4", VA = "0x113ADC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x113A894", Offset = "0x113A894", VA = "0x113A894")]
			[DebuggerHidden]
			public <Initiate>c__Iterator0()
			{
			}

			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x113AB8C", Offset = "0x113AB8C", VA = "0x113AB8C", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x113ADCC", Offset = "0x113ADCC", VA = "0x113ADCC", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x113ADE0", Offset = "0x113ADE0", VA = "0x113ADE0", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7F60", Offset = "0x2A7F60")]
		public float weight;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A7F94", Offset = "0x2A7F94")]
		public VRIK ik;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float lastTime;

		[Token(Token = "0x170000E0")]
		protected float deltaTime
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x113A7C4", Offset = "0x113A7C4", VA = "0x113A7C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x113A7B4", Offset = "0x113A7B4", VA = "0x113A7B4")]
		protected OffsetModifierVRIK()
		{
		}

		[Token(Token = "0x6000878")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x113A7F0", Offset = "0x113A7F0", VA = "0x113A7F0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x113A814", Offset = "0x113A814", VA = "0x113A814")]
		[DebuggerHidden]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x113A89C", Offset = "0x113A89C", VA = "0x113A89C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x113AA00", Offset = "0x113AA00", VA = "0x113AA00", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000128")]
		public class EffectorLink
		{
			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 offset;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 pin;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000880")]
			[Address(RVA = "0x113B564", Offset = "0x113B564", VA = "0x113B564")]
			public EffectorLink()
			{
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0x113AFC8", Offset = "0x113AFC8", VA = "0x113AFC8")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}
		}

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x113AE64", Offset = "0x113AE64", VA = "0x113AE64")]
		public OffsetPose()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x113AEE4", Offset = "0x113AEE4", VA = "0x113AEE4")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x113B4AC", Offset = "0x113B4AC", VA = "0x113B4AC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200012A")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x200012B")]
			public class EffectorLink
			{
				[Token(Token = "0x400081F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8358", Offset = "0x2A8358")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000820")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A838C", Offset = "0x2A838C")]
				public float weight;

				[Token(Token = "0x6000891")]
				[Address(RVA = "0x113F99C", Offset = "0x113F99C", VA = "0x113F99C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A826C", Offset = "0x2A826C")]
			public Vector3 offset;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A82A0", Offset = "0x2A82A0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A82A0", Offset = "0x2A82A0")]
			public float additivity;

			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A82F0", Offset = "0x2A82F0")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8324", Offset = "0x2A8324")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 additiveOffset;

			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600088E")]
			[Address(RVA = "0x113F980", Offset = "0x113F980", VA = "0x113F980")]
			public RecoilOffset()
			{
			}

			[Token(Token = "0x600088F")]
			[Address(RVA = "0x113DE34", Offset = "0x113DE34", VA = "0x113DE34")]
			public void Start()
			{
			}

			[Token(Token = "0x6000890")]
			[Address(RVA = "0x113F050", Offset = "0x113F050", VA = "0x113F050")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200012C")]
		public enum Handedness
		{
			[Token(Token = "0x4000822")]
			Right,
			[Token(Token = "0x4000823")]
			Left
		}

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8038", Offset = "0x2A8038")]
		public AimIK aimIK;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A806C", Offset = "0x2A806C")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A80A0", Offset = "0x2A80A0")]
		public Handedness handedness;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A80D4", Offset = "0x2A80D4")]
		public bool twoHanded;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8108", Offset = "0x2A8108")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A813C", Offset = "0x2A813C")]
		public float magnitudeRandom;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8170", Offset = "0x2A8170")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A81A4", Offset = "0x2A81A4")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A81D8", Offset = "0x2A81D8")]
		public float blendTime;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x2A820C", Offset = "0x2A820C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A820C", Offset = "0x2A820C")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float magnitudeMlp;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float endTime;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion handRotation;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float length;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool initiated;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float blendWeight;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float w;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool handRotationsSet;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000E1")]
		public bool isFinished
		{
			[Token(Token = "0x6000883")]
			[Address(RVA = "0x113DB60", Offset = "0x113DB60", VA = "0x113DB60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E2")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000889")]
			[Address(RVA = "0x113F404", Offset = "0x113F404", VA = "0x113F404")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E3")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x600088A")]
			[Address(RVA = "0x113F450", Offset = "0x113F450", VA = "0x113F450")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E4")]
		private Transform primaryHand
		{
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x113F3BC", Offset = "0x113F3BC", VA = "0x113F3BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600088C")]
			[Address(RVA = "0x113F3E0", Offset = "0x113F3E0", VA = "0x113F3E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x113DA70", Offset = "0x113DA70", VA = "0x113DA70")]
		public Recoil()
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x113DB98", Offset = "0x113DB98", VA = "0x113DB98")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x113DBE0", Offset = "0x113DBE0", VA = "0x113DBE0")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x113DF30", Offset = "0x113DF30", VA = "0x113DF30", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x113F49C", Offset = "0x113F49C", VA = "0x113F49C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x113F65C", Offset = "0x113F65C", VA = "0x113F65C")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x113F6B0", Offset = "0x113F6B0", VA = "0x113F6B0", Slot = "6")]
		protected override void OnDestroy()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A83C0", Offset = "0x2A83C0")]
		public float weight;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A83F4", Offset = "0x2A83F4")]
		public float offset;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool skip;

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x11445F8", Offset = "0x11445F8", VA = "0x11445F8")]
		public ShoulderRotator()
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x1144614", Offset = "0x1144614", VA = "0x1144614")]
		private void Start()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x1144770", Offset = "0x1144770", VA = "0x1144770")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x11448B8", Offset = "0x11448B8", VA = "0x11448B8")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x1144EFC", Offset = "0x1144EFC", VA = "0x1144EFC")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x1144F5C", Offset = "0x1144F5C", VA = "0x1144F5C")]
		private void OnDestroy()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x200012F")]
		public class Settings
		{
			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8428", Offset = "0x2A8428")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A845C", Offset = "0x2A845C")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8490", Offset = "0x2A8490")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A84C4", Offset = "0x2A84C4")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A84F8", Offset = "0x2A84F8")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A852C", Offset = "0x2A852C")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8560", Offset = "0x2A8560")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8594", Offset = "0x2A8594")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x2A85C8", Offset = "0x2A85C8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A85C8", Offset = "0x2A85C8")]
			public Vector3 headOffset;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8618", Offset = "0x2A8618")]
			public Vector3 handOffset;

			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A864C", Offset = "0x2A864C")]
			public float footForwardOffset;

			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8680", Offset = "0x2A8680")]
			public float footInwardOffset;

			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A86B4", Offset = "0x2A86B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A86B4", Offset = "0x2A86B4")]
			public float footHeadingOffset;

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x114AE6C", Offset = "0x114AE6C", VA = "0x114AE6C")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x1147DFC", Offset = "0x1147DFC", VA = "0x1147DFC")]
		public static void Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x114A08C", Offset = "0x114A08C", VA = "0x114A08C")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000130")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000131")]
		public enum UpdateMode
		{
			[Token(Token = "0x400085B")]
			Update,
			[Token(Token = "0x400085C")]
			FixedUpdate,
			[Token(Token = "0x400085D")]
			LateUpdate,
			[Token(Token = "0x400085E")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform target;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform rotationSpace;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool lockCursor;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2A870C", Offset = "0x2A870C")]
		public bool smoothFollow;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float followSpeed;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2A8740", Offset = "0x2A8740")]
		public float rotationSensitivity;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yMinLimit;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float yMaxLimit;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool rotateAlways;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2A8774", Offset = "0x2A8774")]
		public float distance;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float minDistance;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxDistance;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float zoomSpeed;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float zoomSensitivity;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2A87A8", Offset = "0x2A87A8")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float blockingRadius;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float blockingSmoothTime;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A87DC", Offset = "0x2A87DC")]
		public float blockedOffset;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A87F4", Offset = "0x2A87F4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A87F4", Offset = "0x2A87F4")]
		private float <x>k__BackingField;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A8828", Offset = "0x2A8828")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A8828", Offset = "0x2A8828")]
		private float <y>k__BackingField;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A885C", Offset = "0x2A885C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A885C", Offset = "0x2A885C")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 targetDistance;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 position;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion rotation;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 smoothPosition;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Camera cam;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool fixedFrame;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Quaternion r;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 lastUp;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blockedDistance;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float blockedDistanceV;

		[Token(Token = "0x170000E6")]
		public float x
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x832CB0", Offset = "0x832CB0", VA = "0x832CB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A8890", Offset = "0x2A8890")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x832CB8", Offset = "0x832CB8", VA = "0x832CB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A88A0", Offset = "0x2A88A0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public float y
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0x832CC0", Offset = "0x832CC0", VA = "0x832CC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A88B0", Offset = "0x2A88B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600089F")]
			[Address(RVA = "0x832CC8", Offset = "0x832CC8", VA = "0x832CC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A88C0", Offset = "0x2A88C0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public float distanceTarget
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x832CD0", Offset = "0x832CD0", VA = "0x832CD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A88D0", Offset = "0x2A88D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x832CD8", Offset = "0x832CD8", VA = "0x832CD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A88E0", Offset = "0x2A88E0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		private float zoomAdd
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x833C0C", Offset = "0x833C0C", VA = "0x833C0C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x832B2C", Offset = "0x832B2C", VA = "0x832B2C")]
		public CameraController()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x832CE0", Offset = "0x832CE0", VA = "0x832CE0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x832EB8", Offset = "0x832EB8", VA = "0x832EB8", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x832F14", Offset = "0x832F14", VA = "0x832F14", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x832F78", Offset = "0x832F78", VA = "0x832F78", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x832FE0", Offset = "0x832FE0", VA = "0x832FE0")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x832EEC", Offset = "0x832EEC", VA = "0x832EEC")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x8332A4", Offset = "0x8332A4", VA = "0x8332A4")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x833B30", Offset = "0x833B30", VA = "0x833B30")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000132")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float rotationSensitivity;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float yMinLimit;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float yMaxLimit;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float x;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float y;

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x833CCC", Offset = "0x833CCC", VA = "0x833CCC")]
		public CameraControllerFPS()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x833CF4", Offset = "0x833CF4", VA = "0x833CF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x833D40", Offset = "0x833D40", VA = "0x833D40")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x833F80", Offset = "0x833F80", VA = "0x833F80")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000133")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool smoothFollow;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected bool animatePhysics;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 localPosition;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion localRotation;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000EA")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x837664", Offset = "0x837664", VA = "0x837664", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x83760C", Offset = "0x83760C", VA = "0x83760C")]
		protected CharacterAnimationBase()
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x837628", Offset = "0x837628", VA = "0x837628", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x83766C", Offset = "0x83766C", VA = "0x83766C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x837760", Offset = "0x837760", VA = "0x837760", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x837AD0", Offset = "0x837AD0", VA = "0x837AD0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x837E44", Offset = "0x837E44", VA = "0x837E44", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x837AE0", Offset = "0x837AE0", VA = "0x837AE0")]
		private void SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000134")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2A88F0", Offset = "0x2A88F0")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Animator animator;

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x837E54", Offset = "0x837E54", VA = "0x837E54")]
		public CharacterAnimationSimple()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x837E70", Offset = "0x837E70", VA = "0x837E70", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x837EE0", Offset = "0x837EE0", VA = "0x837EE0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x838044", Offset = "0x838044", VA = "0x838044")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000135")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2A8998", Offset = "0x2A8998")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2A8A40", Offset = "0x2A8A40")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected Animator animator;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 lastForward;

		[Token(Token = "0x4000876")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000877")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float deltaAngle;

		[Token(Token = "0x170000EB")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x83837C", Offset = "0x83837C", VA = "0x83837C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x83825C", Offset = "0x83825C", VA = "0x83825C")]
		public CharacterAnimationThirdPerson()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x83829C", Offset = "0x83829C", VA = "0x83829C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x83834C", Offset = "0x83834C", VA = "0x83834C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x8384B0", Offset = "0x8384B0", VA = "0x8384B0", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x838A38", Offset = "0x838A38", VA = "0x838A38")]
		private void OnAnimatorMove()
		{
		}
	}
	[Token(Token = "0x2000136")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2A8A80", Offset = "0x2A8A80")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2A8A80", Offset = "0x2A8A80")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2A8B24", Offset = "0x2A8B24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8B24", Offset = "0x2A8B24")]
		public Transform gravityTarget;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8B84", Offset = "0x2A8B84")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Rigidbody r;

		[Token(Token = "0x4000883")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected float originalHeight;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x839278", Offset = "0x839278", VA = "0x839278")]
		protected CharacterBase()
		{
		}

		[Token(Token = "0x60008C2")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x8392B4", Offset = "0x8392B4", VA = "0x8392B4")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x839494", Offset = "0x839494", VA = "0x839494", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x83969C", Offset = "0x83969C", VA = "0x83969C", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x8399D8", Offset = "0x8399D8", VA = "0x8399D8")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x839ACC", Offset = "0x839ACC", VA = "0x839ACC")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x839D54", Offset = "0x839D54", VA = "0x839D54")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x839F84", Offset = "0x839F84", VA = "0x839F84")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x839FB4", Offset = "0x839FB4", VA = "0x839FB4")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x839FE4", Offset = "0x839FE4", VA = "0x839FE4")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000137")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000138")]
		public enum MoveMode
		{
			[Token(Token = "0x40008BB")]
			Directional,
			[Token(Token = "0x40008BC")]
			Strafe
		}

		[Token(Token = "0x2000139")]
		public struct AnimState
		{
			[Token(Token = "0x40008BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x40008BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x40008BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x40008C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x40008C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x40008C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;
		}

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2A8C1C", Offset = "0x2A8C1C")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public CameraController cam;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2A8C50", Offset = "0x2A8C50")]
		public MoveMode moveMode;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool smoothPhysics;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float smoothAccelerationTime;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float platformFriction;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float groundStickyEffect;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2A8C84", Offset = "0x2A8C84")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float turnSpeed;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2A8CB8", Offset = "0x2A8CB8")]
		public float airSpeed;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float airControl;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float jumpPower;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2A8CEC", Offset = "0x2A8CEC")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float wallRunMaxLength;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2A8D34", Offset = "0x2A8D34")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A8D68", Offset = "0x2A8D68")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A8D68", Offset = "0x2A8D68")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public AnimState animState;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Animator animator;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 normal;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private RaycastHit hit;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private float jumpLeg;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private float jumpEndTime;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float forwardMlp;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float groundDistance;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float lastAirTime;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private float stickyForce;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 wallNormal;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float wallRunWeight;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private bool fixedFrame;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private float wallRunEndTime;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private Vector3 gravity;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float velocityY;

		[Token(Token = "0x170000EC")]
		public bool onGround
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x83A87C", Offset = "0x83A87C", VA = "0x83A87C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A8D9C", Offset = "0x2A8D9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x83A884", Offset = "0x83A884", VA = "0x83A884")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A8DAC", Offset = "0x2A8DAC")]
			private set
			{
			}
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x83A6A8", Offset = "0x83A6A8", VA = "0x83A6A8")]
		public CharacterThirdPerson()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x83A88C", Offset = "0x83A88C", VA = "0x83A88C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x83AA60", Offset = "0x83AA60", VA = "0x83AA60")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x83AAEC", Offset = "0x83AAEC", VA = "0x83AAEC", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x83AC44", Offset = "0x83AC44", VA = "0x83AC44")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x83C160", Offset = "0x83C160", VA = "0x83C160", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x83C61C", Offset = "0x83C61C", VA = "0x83C61C", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x83B36C", Offset = "0x83B36C", VA = "0x83B36C")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x83C764", Offset = "0x83C764", VA = "0x83C764")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x83CFC0", Offset = "0x83CFC0", VA = "0x83CFC0")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x83C278", Offset = "0x83C278", VA = "0x83C278")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x83D088", Offset = "0x83D088", VA = "0x83D088", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x83D664", Offset = "0x83D664", VA = "0x83D664")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x83DA44", Offset = "0x83DA44", VA = "0x83DA44", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x83BBC0", Offset = "0x83BBC0", VA = "0x83BBC0")]
		private void GroundCheck()
		{
		}
	}
	[Token(Token = "0x200013A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2A8DBC", Offset = "0x2A8DBC")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200013B")]
		public enum RotationMode
		{
			[Token(Token = "0x40008D1")]
			Smooth,
			[Token(Token = "0x40008D2")]
			Linear
		}

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8E34", Offset = "0x2A8E34")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8E7C", Offset = "0x2A8E7C")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8EC4", Offset = "0x2A8EC4")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8F0C", Offset = "0x2A8F0C")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8F54", Offset = "0x2A8F54")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A8F9C", Offset = "0x2A8F9C")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A8FE4", Offset = "0x2A8FE4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x2A8FE4", Offset = "0x2A8FE4")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animator animator;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float speed;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float angleVel;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float speedVel;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private CharacterController characterController;

		[Token(Token = "0x170000ED")]
		public bool isGrounded
		{
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x83F100", Offset = "0x83F100", VA = "0x83F100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A9018", Offset = "0x2A9018")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x84D89C", Offset = "0x84D89C", VA = "0x84D89C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A9028", Offset = "0x2A9028")]
			private set
			{
			}
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x84D870", Offset = "0x84D870", VA = "0x84D870")]
		public SimpleLocomotion()
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x84D8A4", Offset = "0x84D8A4", VA = "0x84D8A4")]
		private void Start()
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x84D948", Offset = "0x84D948", VA = "0x84D948")]
		private void Update()
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x84E30C", Offset = "0x84E30C", VA = "0x84E30C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x84D9B8", Offset = "0x84D9B8", VA = "0x84D9B8")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x84DF0C", Offset = "0x84DF0C", VA = "0x84DF0C")]
		private void Move()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x84E35C", Offset = "0x84E35C", VA = "0x84E35C")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x84E4BC", Offset = "0x84E4BC", VA = "0x84E4BC")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200013C")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform moveTarget;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float stoppingDistance;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stoppingThreshold;

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xBE480C", Offset = "0xBE480C", VA = "0xBE480C")]
		public UserControlAI()
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xBE487C", Offset = "0xBE487C", VA = "0xBE487C", Slot = "4")]
		protected override void Update()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x200013E")]
		public struct State
		{
			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool walkByDefault;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public bool canCrouch;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public bool canJump;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public State state;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform cam;

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0xBE484C", Offset = "0xBE484C", VA = "0xBE484C")]
		public UserControlThirdPerson()
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xBE54B8", Offset = "0xBE54B8", VA = "0xBE54B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0xBE4D24", Offset = "0xBE4D24", VA = "0xBE4D24", Slot = "4")]
		protected virtual void Update()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x836A90", Offset = "0x836A90", VA = "0x836A90")]
		public ApplicationQuit()
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x836A98", Offset = "0x836A98", VA = "0x836A98")]
		private void Update()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xBE13B4", Offset = "0xBE13B4", VA = "0xBE13B4")]
		public SlowMo()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0xBE13C8", Offset = "0xBE13C8", VA = "0xBE13C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0xBE13FC", Offset = "0xBE13FC", VA = "0xBE13FC")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}
	}
}
namespace RootMotion
{
	[Serializable]
	[Token(Token = "0x2000141")]
	public enum Axis
	{
		[Token(Token = "0x40008E5")]
		X,
		[Token(Token = "0x40008E6")]
		Y,
		[Token(Token = "0x40008E7")]
		Z
	}
	[Token(Token = "0x2000142")]
	public class AxisTools
	{
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x827DB0", Offset = "0x827DB0", VA = "0x827DB0")]
		public AxisTools()
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x827DB8", Offset = "0x827DB8", VA = "0x827DB8")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x827EC8", Offset = "0x827EC8", VA = "0x827EC8")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x827FA4", Offset = "0x827FA4", VA = "0x827FA4")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x8281F4", Offset = "0x8281F4", VA = "0x8281F4")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x828104", Offset = "0x828104", VA = "0x828104")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x828354", Offset = "0x828354", VA = "0x828354")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000143")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000144")]
		public class LimbOrientation
		{
			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x828AA4", Offset = "0x828AA4", VA = "0x828AA4")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x170000EE")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x82871C", Offset = "0x82871C", VA = "0x82871C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EF")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x828AFC", Offset = "0x828AFC", VA = "0x828AFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x8286E4", Offset = "0x8286E4", VA = "0x8286E4")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000145")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000146")]
		public enum BoneType
		{
			[Token(Token = "0x4000902")]
			Unassigned,
			[Token(Token = "0x4000903")]
			Spine,
			[Token(Token = "0x4000904")]
			Head,
			[Token(Token = "0x4000905")]
			Arm,
			[Token(Token = "0x4000906")]
			Leg,
			[Token(Token = "0x4000907")]
			Tail,
			[Token(Token = "0x4000908")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000147")]
		public enum BoneSide
		{
			[Token(Token = "0x400090A")]
			Center,
			[Token(Token = "0x400090B")]
			Left,
			[Token(Token = "0x400090C")]
			Right
		}

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static string[] typeRight;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeSpine;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static string[] typeHead;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeArm;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static string[] typeLeg;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeTail;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static string[] typeEye;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeExclude;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static string[] pelvis;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] hand;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static string[] foot;

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x828E84", Offset = "0x828E84", VA = "0x828E84")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x829280", Offset = "0x829280", VA = "0x829280")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x829568", Offset = "0x829568", VA = "0x829568")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x829600", Offset = "0x829600", VA = "0x829600")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x8296B8", Offset = "0x8296B8", VA = "0x8296B8")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x8290A4", Offset = "0x8290A4", VA = "0x8290A4")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x8294A0", Offset = "0x8294A0", VA = "0x8294A0")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x82A264", Offset = "0x82A264", VA = "0x82A264")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x829EEC", Offset = "0x829EEC", VA = "0x829EEC")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x82A0A8", Offset = "0x82A0A8", VA = "0x82A0A8")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x82991C", Offset = "0x82991C", VA = "0x82991C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x829A14", Offset = "0x829A14", VA = "0x829A14")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x829B0C", Offset = "0x829B0C", VA = "0x829B0C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x829C04", Offset = "0x829C04", VA = "0x829C04")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x829CFC", Offset = "0x829CFC", VA = "0x829CFC")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x829DF4", Offset = "0x829DF4", VA = "0x829DF4")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x82A55C", Offset = "0x82A55C", VA = "0x82A55C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x829804", Offset = "0x829804", VA = "0x829804")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x82A4DC", Offset = "0x82A4DC", VA = "0x82A4DC")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x82A5F4", Offset = "0x82A5F4", VA = "0x82A5F4")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x82A6CC", Offset = "0x82A6CC", VA = "0x82A6CC")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x82A408", Offset = "0x82A408", VA = "0x82A408")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x82A30C", Offset = "0x82A30C", VA = "0x82A30C")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000148")]
	public class BipedReferences
	{
		[Token(Token = "0x2000149")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x170000F2")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x600092D")]
				[Address(RVA = "0x832B24", Offset = "0x832B24", VA = "0x832B24")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0x832B18", Offset = "0x832B18", VA = "0x832B18")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform root;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Transform pelvis;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform leftThigh;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Transform leftCalf;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftFoot;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Transform rightThigh;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightCalf;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Transform rightFoot;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Transform leftForearm;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHand;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightForearm;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Transform rightHand;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform head;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Transform[] spine;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform[] eyes;

		[Token(Token = "0x170000F0")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000915")]
			[Address(RVA = "0x82DD70", Offset = "0x82DD70", VA = "0x82DD70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F1")]
		public bool isEmpty
		{
			[Token(Token = "0x6000916")]
			[Address(RVA = "0x82E348", Offset = "0x82E348", VA = "0x82E348")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x82DCD4", Offset = "0x82DCD4", VA = "0x82DCD4")]
		public BipedReferences()
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x82E35C", Offset = "0x82E35C", VA = "0x82E35C", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x82E990", Offset = "0x82E990", VA = "0x82E990", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x82EF98", Offset = "0x82EF98", VA = "0x82EF98")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x82F834", Offset = "0x82F834", VA = "0x82F834")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x82F22C", Offset = "0x82F22C", VA = "0x82F22C")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x8304E4", Offset = "0x8304E4", VA = "0x8304E4")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x830604", Offset = "0x830604", VA = "0x830604")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x830CF4", Offset = "0x830CF4", VA = "0x830CF4")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x830A78", Offset = "0x830A78", VA = "0x830A78")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x830848", Offset = "0x830848", VA = "0x830848")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x8306E0", Offset = "0x8306E0", VA = "0x8306E0")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x830BC4", Offset = "0x830BC4", VA = "0x830BC4")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x830E2C", Offset = "0x830E2C", VA = "0x830E2C")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x832048", Offset = "0x832048", VA = "0x832048")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x831738", Offset = "0x831738", VA = "0x831738")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x832490", Offset = "0x832490", VA = "0x832490")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x831D40", Offset = "0x831D40", VA = "0x831D40")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x832498", Offset = "0x832498", VA = "0x832498")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x8324A0", Offset = "0x8324A0", VA = "0x8324A0")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x8326C4", Offset = "0x8326C4", VA = "0x8326C4")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x83297C", Offset = "0x83297C", VA = "0x83297C")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200014A")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "MultilineAttribute", RVA = "0x2A9098", Offset = "0x2A9098")]
		public string text;

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x83405C", Offset = "0x83405C", VA = "0x83405C")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200014B")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string text;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color color;

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x834064", Offset = "0x834064", VA = "0x834064")]
		public DemoGUIMessage()
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x8340A4", Offset = "0x8340A4", VA = "0x8340A4")]
		private void OnGUI()
		{
		}
	}
	[Token(Token = "0x200014C")]
	public class Hierarchy
	{
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x114B884", Offset = "0x114B884", VA = "0x114B884")]
		public Hierarchy()
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x114B88C", Offset = "0x114B88C", VA = "0x114B88C")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x114BB14", Offset = "0x114BB14", VA = "0x114BB14")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x114B918", Offset = "0x114B918", VA = "0x114B918")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x114BC74", Offset = "0x114BC74", VA = "0x114BC74")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x114BDC4", Offset = "0x114BDC4", VA = "0x114BDC4")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x114C11C", Offset = "0x114C11C", VA = "0x114C11C")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x114C294", Offset = "0x114C294", VA = "0x114C294")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x114C4C0", Offset = "0x114C4C0", VA = "0x114C4C0")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x114C988", Offset = "0x114C988", VA = "0x114C988")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x114C69C", Offset = "0x114C69C", VA = "0x114C69C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x200014D")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000924")]
		None,
		[Token(Token = "0x4000925")]
		InOutCubic,
		[Token(Token = "0x4000926")]
		InOutQuintic,
		[Token(Token = "0x4000927")]
		InOutSine,
		[Token(Token = "0x4000928")]
		InQuintic,
		[Token(Token = "0x4000929")]
		InQuartic,
		[Token(Token = "0x400092A")]
		InCubic,
		[Token(Token = "0x400092B")]
		InQuadratic,
		[Token(Token = "0x400092C")]
		InElastic,
		[Token(Token = "0x400092D")]
		InElasticSmall,
		[Token(Token = "0x400092E")]
		InElasticBig,
		[Token(Token = "0x400092F")]
		InSine,
		[Token(Token = "0x4000930")]
		InBack,
		[Token(Token = "0x4000931")]
		OutQuintic,
		[Token(Token = "0x4000932")]
		OutQuartic,
		[Token(Token = "0x4000933")]
		OutCubic,
		[Token(Token = "0x4000934")]
		OutInCubic,
		[Token(Token = "0x4000935")]
		OutInQuartic,
		[Token(Token = "0x4000936")]
		OutElastic,
		[Token(Token = "0x4000937")]
		OutElasticSmall,
		[Token(Token = "0x4000938")]
		OutElasticBig,
		[Token(Token = "0x4000939")]
		OutSine,
		[Token(Token = "0x400093A")]
		OutBack,
		[Token(Token = "0x400093B")]
		OutBackCubic,
		[Token(Token = "0x400093C")]
		OutBackQuartic,
		[Token(Token = "0x400093D")]
		BackInCubic,
		[Token(Token = "0x400093E")]
		BackInQuartic
	}
	[Token(Token = "0x200014E")]
	public class Interp
	{
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x114CBB4", Offset = "0x114CBB4", VA = "0x114CBB4")]
		public Interp()
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x112FF4C", Offset = "0x112FF4C", VA = "0x112FF4C")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x114D524", Offset = "0x114D524", VA = "0x114D524")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x114D65C", Offset = "0x114D65C", VA = "0x114D65C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x114CBBC", Offset = "0x114CBBC", VA = "0x114CBBC")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x114CBD8", Offset = "0x114CBD8", VA = "0x114CBD8")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x114CC18", Offset = "0x114CC18", VA = "0x114CC18")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x114CC70", Offset = "0x114CC70", VA = "0x114CC70")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x114CC98", Offset = "0x114CC98", VA = "0x114CC98")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x114CCBC", Offset = "0x114CCBC", VA = "0x114CCBC")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x114CCE0", Offset = "0x114CCE0", VA = "0x114CCE0")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x114CD00", Offset = "0x114CD00", VA = "0x114CD00")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x114CD64", Offset = "0x114CD64", VA = "0x114CD64")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x114CDB4", Offset = "0x114CDB4", VA = "0x114CDB4")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x114CDF0", Offset = "0x114CDF0", VA = "0x114CDF0")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x114D7A0", Offset = "0x114D7A0", VA = "0x114D7A0")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x114CE40", Offset = "0x114CE40", VA = "0x114CE40")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x114CE80", Offset = "0x114CE80", VA = "0x114CE80")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x114CEC4", Offset = "0x114CEC4", VA = "0x114CEC4")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x114CF14", Offset = "0x114CF14", VA = "0x114CF14")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x114CF78", Offset = "0x114CF78", VA = "0x114CF78")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x114CFF0", Offset = "0x114CFF0", VA = "0x114CFF0")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x114D068", Offset = "0x114D068", VA = "0x114D068")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x114D0D0", Offset = "0x114D0D0", VA = "0x114D0D0")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x114D138", Offset = "0x114D138", VA = "0x114D138")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x114D1F0", Offset = "0x114D1F0", VA = "0x114D1F0")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x114D2A4", Offset = "0x114D2A4", VA = "0x114D2A4")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x114D7F0", Offset = "0x114D7F0", VA = "0x114D7F0")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x114D370", Offset = "0x114D370", VA = "0x114D370")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x114D48C", Offset = "0x114D48C", VA = "0x114D48C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x114D4CC", Offset = "0x114D4CC", VA = "0x114D4CC")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200014F")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string name;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string color;

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x114D914", Offset = "0x114D914", VA = "0x114D914")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x114D990", Offset = "0x114D990", VA = "0x114D990")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000150")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x114DA0C", Offset = "0x114DA0C", VA = "0x114DA0C")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x114DA5C", Offset = "0x114DA5C", VA = "0x114DA5C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x114DB0C", Offset = "0x114DB0C", VA = "0x114DB0C")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x114DA60", Offset = "0x114DA60", VA = "0x114DA60")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x114DB10", Offset = "0x114DB10", VA = "0x114DB10")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x114DBA8", Offset = "0x114DBA8", VA = "0x114DBA8")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x114DBD0", Offset = "0x114DBD0", VA = "0x114DBD0")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x114DC18", Offset = "0x114DC18", VA = "0x114DC18")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x114DC84", Offset = "0x114DC84", VA = "0x114DC84")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x114DDD8", Offset = "0x114DDD8", VA = "0x114DDD8")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x114DECC", Offset = "0x114DECC", VA = "0x114DECC")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x114DF30", Offset = "0x114DF30", VA = "0x114DF30")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000151")]
	public static class QuaTools
	{
		[Token(Token = "0x6000969")]
		[Address(RVA = "0x114DFCC", Offset = "0x114DFCC", VA = "0x114DFCC")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x114E0F8", Offset = "0x114E0F8", VA = "0x114E0F8")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x114E224", Offset = "0x114E224", VA = "0x114E224")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x114E378", Offset = "0x114E378", VA = "0x114E378")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x1137DD0", Offset = "0x1137DD0", VA = "0x1137DD0")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x114E4CC", Offset = "0x114E4CC", VA = "0x114E4CC")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x1128CD8", Offset = "0x1128CD8", VA = "0x1128CD8")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x114E5E0", Offset = "0x114E5E0", VA = "0x114E5E0")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x114E954", Offset = "0x114E954", VA = "0x114E954")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x114EC14", Offset = "0x114EC14", VA = "0x114EC14")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x1149EDC", Offset = "0x1149EDC", VA = "0x1149EDC")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000152")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x170000F3")]
		public static T instance
		{
			[Token(Token = "0x6000975")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000974")]
		protected Singleton()
		{
		}

		[Token(Token = "0x6000976")]
		protected virtual void Awake()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2A9188", Offset = "0x2A9188")]
		public bool fixTransforms;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Animator animator;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Animation legacy;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool updateFrame;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool componentInitiated;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		private bool skipSolverUpdate;

		[Token(Token = "0x170000F4")]
		private bool animatePhysics
		{
			[Token(Token = "0x600097F")]
			[Address(RVA = "0x114EF34", Offset = "0x114EF34", VA = "0x114EF34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F5")]
		private bool isAnimated
		{
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x114F344", Offset = "0x114F344", VA = "0x114F344")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x113B588", Offset = "0x113B588", VA = "0x113B588")]
		public SolverManager()
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x114EDEC", Offset = "0x114EDEC", VA = "0x114EDEC")]
		public void Disable()
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x114EEA4", Offset = "0x114EEA4", VA = "0x114EEA4", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x114EEA8", Offset = "0x114EEA8", VA = "0x114EEA8", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x114EEAC", Offset = "0x114EEAC", VA = "0x114EEAC", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x114EEB0", Offset = "0x114EEB0", VA = "0x114EEB0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x114EF30", Offset = "0x114EF30", VA = "0x114EF30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x114EEDC", Offset = "0x114EEDC", VA = "0x114EEDC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x114F2F4", Offset = "0x114F2F4", VA = "0x114F2F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x114F06C", Offset = "0x114F06C", VA = "0x114F06C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x114F428", Offset = "0x114F428", VA = "0x114F428")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x114F484", Offset = "0x114F484", VA = "0x114F484")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x114F4E4", Offset = "0x114F4E4", VA = "0x114F4E4")]
		public void UpdateSolverExternal()
		{
		}
	}
	[Token(Token = "0x2000154")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public GameObject target;

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x114F520", Offset = "0x114F520", VA = "0x114F520")]
		public TriggerEventBroadcaster()
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x114F528", Offset = "0x114F528", VA = "0x114F528")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x114F604", Offset = "0x114F604", VA = "0x114F604")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x114F6E0", Offset = "0x114F6E0", VA = "0x114F6E0")]
		private void OnTriggerExit(Collider collider)
		{
		}
	}
	[Token(Token = "0x2000155")]
	public static class V3Tools
	{
		[Token(Token = "0x600098B")]
		[Address(RVA = "0x114F7BC", Offset = "0x114F7BC", VA = "0x114F7BC")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x114F8D0", Offset = "0x114F8D0", VA = "0x114F8D0")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x114F9E4", Offset = "0x114F9E4", VA = "0x114F9E4")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x114FB28", Offset = "0x114FB28", VA = "0x114FB28")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x114FC9C", Offset = "0x114FC9C", VA = "0x114FC9C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x114FF74", Offset = "0x114FF74", VA = "0x114FF74")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x1150248", Offset = "0x1150248", VA = "0x1150248")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x115047C", Offset = "0x115047C", VA = "0x115047C")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000156")]
	public static class Warning
	{
		[Token(Token = "0x2000157")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x11506C0", Offset = "0x11506C0", VA = "0x11506C0")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x112ED40", Offset = "0x112ED40", VA = "0x112ED40")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
