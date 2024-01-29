using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Crosstales.Common.Model.Enum;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Crosstales
{
	[Token(Token = "0x2000002")]
	public static class ExtensionMethods
	{
		[Token(Token = "0x2000003")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8E4534", Offset = "0x8E4534")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000001")]
			[FieldOffset(Offset = "0x10")]
			public string str;

			[Token(Token = "0x6000025")]
			[Address(RVA = "0x1E95D78", Offset = "0x1E95D78", VA = "0x1E95D78")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000026")]
			[Address(RVA = "0x1E984CC", Offset = "0x1E984CC", VA = "0x1E984CC")]
			internal bool <CTContainsAny>b__0(string searchTerm)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000004")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8E4544", Offset = "0x8E4544")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000002")]
			[FieldOffset(Offset = "0x10")]
			public string str;

			[Token(Token = "0x6000027")]
			[Address(RVA = "0x1E95F38", Offset = "0x1E95F38", VA = "0x1E95F38")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000028")]
			[Address(RVA = "0x1E984D8", Offset = "0x1E984D8", VA = "0x1E984D8")]
			internal bool <CTContainsAll>b__0(string searchTerm)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000005")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8E4554", Offset = "0x8E4554")]
		private sealed class <>c__29<T>
		{
			[Token(Token = "0x4000003")]
			[FieldOffset(Offset = "0x0")]
			public static readonly <>c__29<T> <>9;

			[Token(Token = "0x4000004")]
			[FieldOffset(Offset = "0x0")]
			public static Func<T, string> <>9__29_0;

			[Token(Token = "0x600002A")]
			public <>c__29()
			{
			}

			[Token(Token = "0x600002B")]
			internal string <CTToString>b__29_0(T element)
			{
				return null;
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1E959E4", Offset = "0x1E959E4", VA = "0x1E959E4")]
		public static string CTToTitleCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1E95AC8", Offset = "0x1E95AC8", VA = "0x1E95AC8")]
		public static string CTReverse(this string str)
		{
			return null;
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1E9369C", Offset = "0x1E9369C", VA = "0x1E9369C")]
		public static string CTReplace(this string str, string oldString, string newString, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1E953F8", Offset = "0x1E953F8", VA = "0x1E953F8")]
		public static bool CTEquals(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1E95B4C", Offset = "0x1E95B4C", VA = "0x1E95B4C")]
		public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1E95BC0", Offset = "0x1E95BC0", VA = "0x1E95BC0")]
		public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x1E95D80", Offset = "0x1E95D80", VA = "0x1E95D80")]
		public static bool CTContainsAll(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1E95F40", Offset = "0x1E95F40", VA = "0x1E95F40")]
		public static bool CTisNumeric(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1E96008", Offset = "0x1E96008", VA = "0x1E96008")]
		public static bool CTisInteger(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1E93C10", Offset = "0x1E93C10", VA = "0x1E93C10")]
		public static bool CTStartsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1E92680", Offset = "0x1E92680", VA = "0x1E92680")]
		public static bool CTEndsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1E9293C", Offset = "0x1E9293C", VA = "0x1E9293C")]
		public static int CTLastIndexOf(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1E935F0", Offset = "0x1E935F0", VA = "0x1E935F0")]
		public static int CTIndexOf(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1E960D4", Offset = "0x1E960D4", VA = "0x1E960D4")]
		public static int CTIndexOf(this string str, string toCheck, int startIndex, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x600000F")]
		public static void CTShuffle<T>(this T[] array, int seed = 0)
		{
		}

		[Token(Token = "0x6000010")]
		public static string CTDump<T>(this T[] array, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1E96188", Offset = "0x1E96188", VA = "0x1E96188")]
		public static string CTDump(this Quaternion[] array)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1E96360", Offset = "0x1E96360", VA = "0x1E96360")]
		public static string CTDump(this Vector2[] array)
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1E964EC", Offset = "0x1E964EC", VA = "0x1E964EC")]
		public static string CTDump(this Vector3[] array)
		{
			return null;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1E966A4", Offset = "0x1E966A4", VA = "0x1E966A4")]
		public static string CTDump(this Vector4[] array)
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		public static string[] CTToString<T>(this T[] array)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1E9687C", Offset = "0x1E9687C", VA = "0x1E9687C")]
		public static float[] CTToFloatArray(this byte[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1E969D8", Offset = "0x1E969D8", VA = "0x1E969D8")]
		public static byte[] CTToByteArray(this float[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		public static void CTShuffle<T>(this IList<T> list, int seed = 0)
		{
		}

		[Token(Token = "0x6000019")]
		public static string CTDump<T>(this IList<T> list, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1E96B30", Offset = "0x1E96B30", VA = "0x1E96B30")]
		public static string CTDump(this IList<Quaternion> list)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1E96F58", Offset = "0x1E96F58", VA = "0x1E96F58")]
		public static string CTDump(this IList<Vector2> list)
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1E97320", Offset = "0x1E97320", VA = "0x1E97320")]
		public static string CTDump(this IList<Vector3> list)
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1E97724", Offset = "0x1E97724", VA = "0x1E97724")]
		public static string CTDump(this IList<Vector4> list)
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		public static List<string> CTToString<T>(this IList<T> list)
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		public static string CTDump<K, V>(this IDictionary<K, V> dict, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		public static void CTAddRange<K, V>(this IDictionary<K, V> dict, IDictionary<K, V> collection)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1E97B4C", Offset = "0x1E97B4C", VA = "0x1E97B4C")]
		public static bool CTIsVisibleFrom(this Renderer renderer, Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1E97CB0", Offset = "0x1E97CB0", VA = "0x1E97CB0")]
		public static Transform CTDeepSearch(Transform parent, string name)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1E98098", Offset = "0x1E98098", VA = "0x1E98098")]
		public static byte[] CTReadFully(this Stream input)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1E969BC", Offset = "0x1E969BC", VA = "0x1E969BC")]
		private static float bytesToFloat(byte firstByte, byte secondByte)
		{
			return default(float);
		}
	}
}
namespace Crosstales.Common.Util
{
	[Token(Token = "0x2000006")]
	public abstract class BaseConstants
	{
		[Token(Token = "0x4000005")]
		public const string ASSET_AUTHOR = "crosstales LLC";

		[Token(Token = "0x4000006")]
		public const string ASSET_AUTHOR_URL = "https://www.crosstales.com";

		[Token(Token = "0x4000007")]
		public const string ASSET_CT_URL = "https://assetstore.unity.com/lists/crosstales-42213?aid=1011lNGT";

		[Token(Token = "0x4000008")]
		public const string ASSET_SOCIAL_DISCORD = "https://discord.gg/ZbZ2sh4";

		[Token(Token = "0x4000009")]
		public const string ASSET_SOCIAL_FACEBOOK = "https://www.facebook.com/crosstales/";

		[Token(Token = "0x400000A")]
		public const string ASSET_SOCIAL_TWITTER = "https://twitter.com/crosstales";

		[Token(Token = "0x400000B")]
		public const string ASSET_SOCIAL_YOUTUBE = "https://www.youtube.com/c/Crosstales";

		[Token(Token = "0x400000C")]
		public const string ASSET_SOCIAL_LINKEDIN = "https://www.linkedin.com/company/crosstales";

		[Token(Token = "0x400000D")]
		public const string ASSET_3P_PLAYMAKER = "https://assetstore.unity.com/packages/slug/368?aid=1011lNGT";

		[Token(Token = "0x400000E")]
		public const string ASSET_3P_VOLUMETRIC_AUDIO = "https://assetstore.unity.com/packages/slug/17125?aid=1011lNGT";

		[Token(Token = "0x400000F")]
		public const string ASSET_3P_ROCKTOMATE = "https://assetstore.unity.com/packages/slug/156311?aid=1011lNGT";

		[Token(Token = "0x4000010")]
		public const string ASSET_BWF = "https://assetstore.unity.com/packages/slug/26255?aid=1011lNGT";

		[Token(Token = "0x4000011")]
		public const string ASSET_DJ = "https://assetstore.unity.com/packages/slug/41993?aid=1011lNGT";

		[Token(Token = "0x4000012")]
		public const string ASSET_FB = "https://assetstore.unity.com/packages/slug/98713?aid=1011lNGT";

		[Token(Token = "0x4000013")]
		public const string ASSET_OC = "https://assetstore.unity.com/packages/slug/74688?aid=1011lNGT";

		[Token(Token = "0x4000014")]
		public const string ASSET_RADIO = "https://assetstore.unity.com/packages/slug/32034?aid=1011lNGT";

		[Token(Token = "0x4000015")]
		public const string ASSET_RTV = "https://assetstore.unity.com/packages/slug/41068?aid=1011lNGT";

		[Token(Token = "0x4000016")]
		public const string ASSET_TB = "https://assetstore.unity.com/packages/slug/98711?aid=1011lNGT";

		[Token(Token = "0x4000017")]
		public const string ASSET_TPB = "https://assetstore.unity.com/packages/slug/98714?aid=1011lNGT";

		[Token(Token = "0x4000018")]
		public const string ASSET_TPS = "https://assetstore.unity.com/packages/slug/60040?aid=1011lNGT";

		[Token(Token = "0x4000019")]
		public const string ASSET_TR = "https://assetstore.unity.com/packages/slug/61617?aid=1011lNGT";

		[Token(Token = "0x400001A")]
		public const int FACTOR_KB = 1024;

		[Token(Token = "0x400001B")]
		public const int FACTOR_MB = 1048576;

		[Token(Token = "0x400001C")]
		public const int FACTOR_GB = 1073741824;

		[Token(Token = "0x400001D")]
		public const float FLOAT_32768 = 32768f;

		[Token(Token = "0x400001E")]
		public const float FLOAT_TOLERANCE = 0.0001f;

		[Token(Token = "0x400001F")]
		public const string FORMAT_TWO_DECIMAL_PLACES = "0.00";

		[Token(Token = "0x4000020")]
		public const string FORMAT_NO_DECIMAL_PLACES = "0";

		[Token(Token = "0x4000021")]
		public const string FORMAT_PERCENT = "0%";

		[Token(Token = "0x4000022")]
		public const bool DEFAULT_DEBUG = false;

		[Token(Token = "0x4000023")]
		public const string PATH_DELIMITER_WINDOWS = "\\";

		[Token(Token = "0x4000024")]
		public const string PATH_DELIMITER_UNIX = "/";

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x0")]
		public static bool DEV_DEBUG;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x8")]
		public static string TEXT_TOSTRING_START;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x10")]
		public static string TEXT_TOSTRING_END;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x18")]
		public static string TEXT_TOSTRING_DELIMITER;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x20")]
		public static string TEXT_TOSTRING_DELIMITER_END;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x28")]
		public static string PREFIX_HTTP;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x30")]
		public static string PREFIX_HTTPS;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x38")]
		public static int PROCESS_KILL_TIME;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x40")]
		public static string CMD_WINDOWS_PATH;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x48")]
		public static bool SHOW_BWF_BANNER;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x49")]
		public static bool SHOW_DJ_BANNER;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x4A")]
		public static bool SHOW_FB_BANNER;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x4B")]
		public static bool SHOW_OC_BANNER;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x4C")]
		public static bool SHOW_RADIO_BANNER;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x4D")]
		public static bool SHOW_RTV_BANNER;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x4E")]
		public static bool SHOW_TB_BANNER;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x4F")]
		public static bool SHOW_TPB_BANNER;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x50")]
		public static bool SHOW_TPS_BANNER;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x51")]
		public static bool SHOW_TR_BANNER;

		[Token(Token = "0x17000001")]
		public static string PREFIX_FILE
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x1E90F0C", Offset = "0x1E90F0C", VA = "0x1E90F0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public static string APPLICATION_PATH
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x1E91048", Offset = "0x1E91048", VA = "0x1E91048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1E91290", Offset = "0x1E91290", VA = "0x1E91290")]
		protected BaseConstants()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public abstract class BaseHelper
	{
		[Serializable]
		[Token(Token = "0x2000008")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8E4564", Offset = "0x8E4564")]
		private sealed class <>c
		{
			[Token(Token = "0x4000040")]
			[FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000041")]
			[FieldOffset(Offset = "0x8")]
			public static Func<X509ChainStatus, bool> <>9__65_0;

			[Token(Token = "0x4000042")]
			[FieldOffset(Offset = "0x10")]
			public static Func<string, bool> <>9__68_0;

			[Token(Token = "0x4000043")]
			[FieldOffset(Offset = "0x18")]
			public static Func<string, string> <>9__68_1;

			[Token(Token = "0x6000069")]
			[Address(RVA = "0x1E98420", Offset = "0x1E98420", VA = "0x1E98420")]
			public <>c()
			{
			}

			[Token(Token = "0x600006A")]
			[Address(RVA = "0x1E98428", Offset = "0x1E98428", VA = "0x1E98428")]
			internal bool <RemoteCertificateValidationCallback>b__65_0(X509ChainStatus t)
			{
				return default(bool);
			}

			[Token(Token = "0x600006B")]
			[Address(RVA = "0x1E98434", Offset = "0x1E98434", VA = "0x1E98434")]
			internal bool <GetFiles>b__68_0(string extension)
			{
				return default(bool);
			}

			[Token(Token = "0x600006C")]
			[Address(RVA = "0x1E984C4", Offset = "0x1E984C4", VA = "0x1E984C4")]
			internal string <GetFiles>b__68_1(string q)
			{
				return null;
			}
		}

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CultureInfo BaseCulture;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x8")]
		protected static readonly Regex lineEndingsRegex;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x10")]
		protected static readonly Regex cleanSpacesRegex;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x18")]
		protected static readonly Regex cleanTagsRegex;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x20")]
		protected static readonly System.Random rnd;

		[Token(Token = "0x400003D")]
		protected const string file_prefix = "file://";

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x28")]
		public static bool ApplicationIsPlaying;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x30")]
		private static string applicationDataPath;

		[Token(Token = "0x17000003")]
		public static bool isInternetAvailable
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x1E91428", Offset = "0x1E91428", VA = "0x1E91428")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000004")]
		public static bool isWindowsPlatform
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x1E91448", Offset = "0x1E91448", VA = "0x1E91448")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000005")]
		public static bool isMacOSPlatform
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x1E91450", Offset = "0x1E91450", VA = "0x1E91450")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000006")]
		public static bool isLinuxPlatform
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x1E91458", Offset = "0x1E91458", VA = "0x1E91458")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000007")]
		public static bool isStandalonePlatform
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x1E91460", Offset = "0x1E91460", VA = "0x1E91460")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public static bool isAndroidPlatform
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x1E914EC", Offset = "0x1E914EC", VA = "0x1E914EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public static bool isIOSPlatform
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1E914F4", Offset = "0x1E914F4", VA = "0x1E914F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		public static bool isTvOSPlatform
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x1E914FC", Offset = "0x1E914FC", VA = "0x1E914FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public static bool isWSAPlatform
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x1E91504", Offset = "0x1E91504", VA = "0x1E91504")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		public static bool isXboxOnePlatform
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x1E9150C", Offset = "0x1E9150C", VA = "0x1E9150C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		public static bool isPS4Platform
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1E91514", Offset = "0x1E91514", VA = "0x1E91514")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		public static bool isWebGLPlatform
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x1E9151C", Offset = "0x1E9151C", VA = "0x1E9151C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		public static bool isWebPlatform
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x1E91524", Offset = "0x1E91524", VA = "0x1E91524")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		public static bool isWindowsBasedPlatform
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x1E90FA4", Offset = "0x1E90FA4", VA = "0x1E90FA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000011")]
		public static bool isWSABasedPlatform
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x1E91580", Offset = "0x1E91580", VA = "0x1E91580")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000012")]
		public static bool isAppleBasedPlatform
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x1E915F4", Offset = "0x1E915F4", VA = "0x1E915F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		public static bool isIOSBasedPlatform
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x1E91680", Offset = "0x1E91680", VA = "0x1E91680")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000014")]
		public static bool isMobilePlatform
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x1E916F4", Offset = "0x1E916F4", VA = "0x1E916F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public static bool isEditor
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x1E91750", Offset = "0x1E91750", VA = "0x1E91750")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000016")]
		public static bool isWindowsEditor
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x1E91030", Offset = "0x1E91030", VA = "0x1E91030")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public static bool isMacOSEditor
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x1E91038", Offset = "0x1E91038", VA = "0x1E91038")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		public static bool isLinuxEditor
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x1E91040", Offset = "0x1E91040", VA = "0x1E91040")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000019")]
		public static bool isEditorMode
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x1E917DC", Offset = "0x1E917DC", VA = "0x1E917DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		public static bool isIL2CPP
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x1E9183C", Offset = "0x1E9183C", VA = "0x1E9183C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		public static Platform CurrentPlatform
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x1E91844", Offset = "0x1E91844", VA = "0x1E91844")]
			get
			{
				return default(Platform);
			}
		}

		[Token(Token = "0x1700001C")]
		public static string StreamingAssetsPath
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x1E918E8", Offset = "0x1E918E8", VA = "0x1E918E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1E919CC", Offset = "0x1E919CC", VA = "0x1E919CC")]
		static BaseHelper()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1E91B7C", Offset = "0x1E91B7C", VA = "0x1E91B7C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x8E47C4", Offset = "0x8E47C4")]
		private static void initialize()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1E91CA8", Offset = "0x1E91CA8", VA = "0x1E91CA8")]
		public static bool OpenURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1E91E94", Offset = "0x1E91E94", VA = "0x1E91E94")]
		public static string CreateString(string replaceChars, int stringLength)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1E9202C", Offset = "0x1E9202C", VA = "0x1E9202C")]
		public static bool hasActiveClip(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1E9216C", Offset = "0x1E9216C", VA = "0x1E9216C")]
		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1E910F0", Offset = "0x1E910F0", VA = "0x1E910F0")]
		public static string ValidatePath(string path, bool addEndDelimiter = true)
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1E9272C", Offset = "0x1E9272C", VA = "0x1E9272C")]
		public static string ValidateFile(string path)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1E929E8", Offset = "0x1E929E8", VA = "0x1E929E8")]
		public static string[] GetFiles(string path, bool isRecursive = false, params string[] extensions)
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1E92F1C", Offset = "0x1E92F1C", VA = "0x1E92F1C")]
		public static string[] GetDirectories(string path, bool isRecursive = false)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1E93140", Offset = "0x1E93140", VA = "0x1E93140")]
		public static string[] GetDrives()
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1E932D8", Offset = "0x1E932D8", VA = "0x1E932D8")]
		public static string ValidURLFromFilePath(string path)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1E9348C", Offset = "0x1E9348C", VA = "0x1E9348C")]
		public static string CleanUrl(string url, bool removeProtocol = true, bool removeWWW = true, bool removeSlash = true)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1E937B0", Offset = "0x1E937B0", VA = "0x1E937B0")]
		public static string ClearTags(string text)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1E93868", Offset = "0x1E93868", VA = "0x1E93868")]
		public static string ClearSpaces(string text)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1E93918", Offset = "0x1E93918", VA = "0x1E93918")]
		public static string ClearLineEndings(string text)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1E939D0", Offset = "0x1E939D0", VA = "0x1E939D0")]
		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true, int skipHeaderLines = 0, int skipFooterLines = 0)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1E93CBC", Offset = "0x1E93CBC", VA = "0x1E93CBC")]
		public static string FormatBytesToHRF(long bytes)
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1E93F0C", Offset = "0x1E93F0C", VA = "0x1E93F0C")]
		public static string FormatSecondsToHourMinSec(double seconds)
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1E94360", Offset = "0x1E94360", VA = "0x1E94360")]
		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1E91D8C", Offset = "0x1E91D8C", VA = "0x1E91D8C")]
		public static bool isValidURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1E944B4", Offset = "0x1E944B4", VA = "0x1E944B4")]
		public static void CopyPath(string sourcePath, string destPath, bool move = false)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1E94A28", Offset = "0x1E94A28", VA = "0x1E94A28")]
		public static void CopyFile(string sourceFile, string destFile, bool move = false)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1E94DA4", Offset = "0x1E94DA4", VA = "0x1E94DA4")]
		public static void ShowPath(string path)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1E94DFC", Offset = "0x1E94DFC", VA = "0x1E94DFC")]
		public static void ShowFile(string file)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1E94EBC", Offset = "0x1E94EBC", VA = "0x1E94EBC")]
		public static void OpenFile(string file)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1E94F7C", Offset = "0x1E94F7C", VA = "0x1E94F7C")]
		public static string getIP(string host)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1E942E4", Offset = "0x1E942E4", VA = "0x1E942E4")]
		private static string addLeadingZero(int value)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1E94840", Offset = "0x1E94840", VA = "0x1E94840")]
		private static void copyAll(DirectoryInfo source, DirectoryInfo target)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1E9512C", Offset = "0x1E9512C", VA = "0x1E9512C")]
		protected BaseHelper()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class HelperCT : MonoBehaviour
	{
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8E4574", Offset = "0x8E4574")]
		private static HelperCT <Instance>k__BackingField;

		[Token(Token = "0x1700001D")]
		public static HelperCT Instance
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x1E98268", Offset = "0x1E98268", VA = "0x1E98268")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8E47D4", Offset = "0x8E47D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x1E982B4", Offset = "0x1E982B4", VA = "0x1E982B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8E47E4", Offset = "0x8E47E4")]
			private set
			{
			}
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1E98304", Offset = "0x1E98304", VA = "0x1E98304")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1E98354", Offset = "0x1E98354", VA = "0x1E98354")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1E983B8", Offset = "0x1E983B8", VA = "0x1E983B8")]
		public HelperCT()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public static class CTPlayerPrefs
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1E95134", Offset = "0x1E95134", VA = "0x1E95134")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1E951AC", Offset = "0x1E951AC", VA = "0x1E951AC")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1E951B4", Offset = "0x1E951B4", VA = "0x1E951B4")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1E9522C", Offset = "0x1E9522C", VA = "0x1E9522C")]
		public static void Save()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1E95234", Offset = "0x1E95234", VA = "0x1E95234")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1E952AC", Offset = "0x1E952AC", VA = "0x1E952AC")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1E95324", Offset = "0x1E95324", VA = "0x1E95324")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1E9539C", Offset = "0x1E9539C", VA = "0x1E9539C")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1E95458", Offset = "0x1E95458", VA = "0x1E95458")]
		public static DateTime GetDate(string key)
		{
			return default(DateTime);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1E95504", Offset = "0x1E95504", VA = "0x1E95504")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1E95584", Offset = "0x1E95584", VA = "0x1E95584")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1E9560C", Offset = "0x1E9560C", VA = "0x1E9560C")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1E9568C", Offset = "0x1E9568C", VA = "0x1E9568C")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1E95700", Offset = "0x1E95700", VA = "0x1E95700")]
		public static void SetDate(string key, DateTime value)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class CTWebClient : WebClient
	{
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8E4584", Offset = "0x8E4584")]
		private int <Timeout>k__BackingField;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8E4594", Offset = "0x8E4594")]
		private int <ConnectionLimit>k__BackingField;

		[Token(Token = "0x1700001E")]
		public int Timeout
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x1E9576C", Offset = "0x1E9576C", VA = "0x1E9576C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8E47F4", Offset = "0x8E47F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x1E95774", Offset = "0x1E95774", VA = "0x1E95774")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8E4804", Offset = "0x8E4804")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public int ConnectionLimit
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x1E9577C", Offset = "0x1E9577C", VA = "0x1E9577C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8E4814", Offset = "0x8E4814")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x1E95784", Offset = "0x1E95784", VA = "0x1E95784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8E4824", Offset = "0x8E4824")]
			set
			{
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1E9578C", Offset = "0x1E9578C", VA = "0x1E9578C")]
		public CTWebClient()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1E957BC", Offset = "0x1E957BC", VA = "0x1E957BC")]
		public CTWebClient(int timeout, int connectionLimit = 20)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1E957F4", Offset = "0x1E957F4", VA = "0x1E957F4")]
		public WebRequest CTGetWebRequest(string uri)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1E95870", Offset = "0x1E95870", VA = "0x1E95870", Slot = "16")]
		protected override WebRequest GetWebRequest(Uri uri)
		{
			return null;
		}
	}
	[Token(Token = "0x200000C")]
	public static class XmlHelper
	{
		[Token(Token = "0x6000088")]
		public static void SerializeToFile<T>(T obj, string filename)
		{
		}

		[Token(Token = "0x6000089")]
		public static T DeserializeFromFile<T>(string filename, bool skipBOM = false)
		{
			return (T)null;
		}

		[Token(Token = "0x600008A")]
		public static string SerializeToString<T>(T obj)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		public static T DeserializeFromString<T>(string xmlAsString, bool skipBOM = true)
		{
			return (T)null;
		}

		[Token(Token = "0x600008C")]
		public static T DeserializeFromResource<T>(string resourceName, bool skipBOM = true)
		{
			return (T)null;
		}
	}
}
namespace Crosstales.Common.Model.Enum
{
	[Token(Token = "0x200000D")]
	public enum Platform
	{
		[Token(Token = "0x4000048")]
		Windows,
		[Token(Token = "0x4000049")]
		OSX,
		[Token(Token = "0x400004A")]
		Linux,
		[Token(Token = "0x400004B")]
		IOS,
		[Token(Token = "0x400004C")]
		Android,
		[Token(Token = "0x400004D")]
		WSA,
		[Token(Token = "0x400004E")]
		Web,
		[Token(Token = "0x400004F")]
		Unsupported
	}
	[Token(Token = "0x200000E")]
	public enum SampleRate
	{
		[Token(Token = "0x4000051")]
		_8000Hz = 8000,
		[Token(Token = "0x4000052")]
		_11025Hz = 11025,
		[Token(Token = "0x4000053")]
		_22050Hz = 22050,
		[Token(Token = "0x4000054")]
		_44100Hz = 44100,
		[Token(Token = "0x4000055")]
		_48000Hz = 48000
	}
}
