using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using Crosstales.Common.Model.Enum;
using Crosstales.Common.Util;
using Crosstales.FB.Wrapper;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Crosstales
{
	[Token(Token = "0x2000002")]
	public static class ExtensionMethods
	{
		[Token(Token = "0x2000003")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74FD64", Offset = "0x74FD64")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000002")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string str;

			[Token(Token = "0x600006C")]
			[Address(RVA = "0x1646378", Offset = "0x1646378", VA = "0x1646378")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x600006D")]
			[Address(RVA = "0x1655EE4", Offset = "0x1655EE4", VA = "0x1655EE4")]
			internal bool <CTContainsAny>b__0(string searchTerm)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000004")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74FD74", Offset = "0x74FD74")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000003")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string str;

			[Token(Token = "0x600006E")]
			[Address(RVA = "0x16464F8", Offset = "0x16464F8", VA = "0x16464F8")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600006F")]
			[Address(RVA = "0x1655F7C", Offset = "0x1655F7C", VA = "0x1655F7C")]
			internal bool <CTContainsAll>b__0(string searchTerm)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000005")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74FD84", Offset = "0x74FD84")]
		private sealed class <>c__51<T>
		{
			[Token(Token = "0x4000004")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__51<T> <>9;

			[Token(Token = "0x4000005")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<T, string> <>9__51_0;

			[Token(Token = "0x6000071")]
			public <>c__51()
			{
			}

			[Token(Token = "0x6000072")]
			internal string <CTToString>b__51_0(T element)
			{
				return null;
			}
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 flat;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x16435EC", Offset = "0x16435EC", VA = "0x16435EC")]
		public static string CTToTitleCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x164619C", Offset = "0x164619C", VA = "0x164619C")]
		public static string CTReverse(this string str)
		{
			return null;
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x164127C", Offset = "0x164127C", VA = "0x164127C")]
		public static string CTReplace(this string str, string oldString, string newString, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x16449D8", Offset = "0x16449D8", VA = "0x16449D8")]
		public static bool CTEquals(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x16461DC", Offset = "0x16461DC", VA = "0x16461DC")]
		public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1646200", Offset = "0x1646200", VA = "0x1646200")]
		public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x1646380", Offset = "0x1646380", VA = "0x1646380")]
		public static bool CTContainsAll(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1646500", Offset = "0x1646500", VA = "0x1646500")]
		public static string CTRemoveNewLines(this string str, string replacement = "#nl#", [Optional] string newLine)
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1646560", Offset = "0x1646560", VA = "0x1646560")]
		public static string CTAddNewLines(this string str, string replacement = "#nl#", [Optional] string newLine)
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1646610", Offset = "0x1646610", VA = "0x1646610")]
		public static bool CTisNumeric(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1646698", Offset = "0x1646698", VA = "0x1646698")]
		public static bool CTisInteger(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x164671C", Offset = "0x164671C", VA = "0x164671C")]
		public static bool CTisEmail(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x16467A8", Offset = "0x16467A8", VA = "0x16467A8")]
		public static bool CTisWebsite(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1646834", Offset = "0x1646834", VA = "0x1646834")]
		public static bool CTisCreditcard(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x16468C0", Offset = "0x16468C0", VA = "0x16468C0")]
		public static bool CTisIPv4(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x164694C", Offset = "0x164694C", VA = "0x164694C")]
		public static bool CTisAlphanumeric(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x16469D8", Offset = "0x16469D8", VA = "0x16469D8")]
		public static bool CThasLineEndings(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1646A64", Offset = "0x1646A64", VA = "0x1646A64")]
		public static bool CThasInvalidChars(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x16417A0", Offset = "0x16417A0", VA = "0x16417A0")]
		public static bool CTStartsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x164009C", Offset = "0x164009C", VA = "0x164009C")]
		public static bool CTEndsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1640398", Offset = "0x1640398", VA = "0x1640398")]
		public static int CTLastIndexOf(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x16411D0", Offset = "0x16411D0", VA = "0x16411D0")]
		public static int CTIndexOf(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1646AF0", Offset = "0x1646AF0", VA = "0x1646AF0")]
		public static int CTIndexOf(this string str, string toCheck, int startIndex, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1646BA4", Offset = "0x1646BA4", VA = "0x1646BA4")]
		public static string CTToBase64(this string str, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1646CD0", Offset = "0x1646CD0", VA = "0x1646CD0")]
		public static string CTFromBase64(this string str, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1646D84", Offset = "0x1646D84", VA = "0x1646D84")]
		public static byte[] CTFromBase64ToByteArray(this string str)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1646DFC", Offset = "0x1646DFC", VA = "0x1646DFC")]
		public static string CTToHex(this string str, bool addPrefix = false)
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1646F60", Offset = "0x1646F60", VA = "0x1646F60")]
		public static string CTHexToString(this string hexString)
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1647158", Offset = "0x1647158", VA = "0x1647158")]
		public static Color32 CTHexToColor32(this string hexString)
		{
			return default(Color32);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x16473F0", Offset = "0x16473F0", VA = "0x16473F0")]
		public static Color CTHexToColor(this string hexString)
		{
			return default(Color);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x164745C", Offset = "0x164745C", VA = "0x164745C")]
		public static byte[] CTToByteArray(this string str, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		public static void CTShuffle<T>(this T[] array, int seed = 0)
		{
		}

		[Token(Token = "0x6000021")]
		public static string CTDump<T>(this T[] array, string prefix = "", string postfix = "", bool appendNewLine = true, string delimiter = "; ")
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x16474B4", Offset = "0x16474B4", VA = "0x16474B4")]
		public static string CTDump(this Quaternion[] array)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1647664", Offset = "0x1647664", VA = "0x1647664")]
		public static string CTDump(this Vector2[] array)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x16477C4", Offset = "0x16477C4", VA = "0x16477C4")]
		public static string CTDump(this Vector3[] array)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1647954", Offset = "0x1647954", VA = "0x1647954")]
		public static string CTDump(this Vector4[] array)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		public static string[] CTToString<T>(this T[] array)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1647B04", Offset = "0x1647B04", VA = "0x1647B04")]
		public static float[] CTToFloatArray(this byte[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1647CB0", Offset = "0x1647CB0", VA = "0x1647CB0")]
		public static byte[] CTToByteArray(this float[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1647E08", Offset = "0x1647E08", VA = "0x1647E08")]
		public static Texture2D CTToTexture(this byte[] data)
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1647EC8", Offset = "0x1647EC8", VA = "0x1647EC8")]
		public static Sprite CTToSprite(this byte[] data)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1648024", Offset = "0x1648024", VA = "0x1648024")]
		public static string CTToByteArray(this byte[] data, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1646C58", Offset = "0x1646C58", VA = "0x1646C58")]
		public static string CTToBase64(this byte[] data)
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		public static void CTShuffle<T>(this IList<T> list, int seed = 0)
		{
		}

		[Token(Token = "0x600002E")]
		public static string CTDump<T>(this IList<T> list, string prefix = "", string postfix = "", bool appendNewLine = true, string delimiter = "; ")
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x164807C", Offset = "0x164807C", VA = "0x164807C")]
		public static string CTDump(this IList<Quaternion> list)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1648464", Offset = "0x1648464", VA = "0x1648464")]
		public static string CTDump(this IList<Vector2> list)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x16487EC", Offset = "0x16487EC", VA = "0x16487EC")]
		public static string CTDump(this IList<Vector3> list)
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1648BB0", Offset = "0x1648BB0", VA = "0x1648BB0")]
		public static string CTDump(this IList<Vector4> list)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		public static List<string> CTToString<T>(this IList<T> list)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		public static string CTDump<K, V>(this IDictionary<K, V> dict, string prefix = "", string postfix = "", bool appendNewLine = true, string delimiter = "; ")
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		public static void CTAddRange<K, V>(this IDictionary<K, V> dict, IDictionary<K, V> collection)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1648F98", Offset = "0x1648F98", VA = "0x1648F98")]
		public static byte[] CTReadFully(this Stream input)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1649168", Offset = "0x1649168", VA = "0x1649168")]
		public static string CTToHexRGB(this Color32 input)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1649204", Offset = "0x1649204", VA = "0x1649204")]
		public static string CTToHexRGB(this Color input)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x164920C", Offset = "0x164920C", VA = "0x164920C")]
		public static string CTToHexRGBA(this Color32 input)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x16492A8", Offset = "0x16492A8", VA = "0x16492A8")]
		public static string CTToHexRGBA(this Color input)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x16492B0", Offset = "0x16492B0", VA = "0x16492B0")]
		public static Vector3 CTVector3(this Color32 color)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1649340", Offset = "0x1649340", VA = "0x1649340")]
		public static Vector3 CTVector3(this Color color)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1649344", Offset = "0x1649344", VA = "0x1649344")]
		public static Vector4 CTVector4(this Color32 color)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x16457E8", Offset = "0x16457E8", VA = "0x16457E8")]
		public static Vector4 CTVector4(this Color color)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x16493DC", Offset = "0x16493DC", VA = "0x16493DC")]
		public static Vector2 CTMultiply(this Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x16493E8", Offset = "0x16493E8", VA = "0x16493E8")]
		public static Vector3 CTMultiply(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x16493F8", Offset = "0x16493F8", VA = "0x16493F8")]
		public static Vector3 CTFlatten(this Vector3 a)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1649488", Offset = "0x1649488", VA = "0x1649488")]
		public static Quaternion CTQuaternion(this Vector3 eulerAngle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1649490", Offset = "0x1649490", VA = "0x1649490")]
		public static Color CTColorRGB(this Vector3 rgb, float alpha = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1649524", Offset = "0x1649524", VA = "0x1649524")]
		public static Vector4 CTMultiply(this Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1644E50", Offset = "0x1644E50", VA = "0x1644E50")]
		public static Quaternion CTQuaternion(this Vector4 angle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1644F14", Offset = "0x1644F14", VA = "0x1644F14")]
		public static Color CTColorRGBA(this Vector4 rgba)
		{
			return default(Color);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1649564", Offset = "0x1649564", VA = "0x1649564")]
		public static Vector3 CTVector3(this Quaternion angle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1645724", Offset = "0x1645724", VA = "0x1645724")]
		public static Vector4 CTVector4(this Quaternion angle)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1649590", Offset = "0x1649590", VA = "0x1649590")]
		public static Vector3 CTCorrectLossyScale(this Canvas canvas)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1649798", Offset = "0x1649798", VA = "0x1649798")]
		public static void CTGetLocalCorners(this RectTransform transform, Vector3[] fourCornersArray, Canvas canvas, float inset = 0f, bool corrected = false)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1649A30", Offset = "0x1649A30", VA = "0x1649A30")]
		public static Vector3[] CTGetLocalCorners(this RectTransform transform, Canvas canvas, float inset = 0f, bool corrected = false)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1649AEC", Offset = "0x1649AEC", VA = "0x1649AEC")]
		public static void CTGetScreenCorners(this RectTransform transform, Vector3[] fourCornersArray, Canvas canvas, float inset = 0f, bool corrected = false)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1649DF4", Offset = "0x1649DF4", VA = "0x1649DF4")]
		public static Vector3[] CTGetScreenCorners(this RectTransform transform, Canvas canvas, float inset = 0f, bool corrected = false)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1649EB0", Offset = "0x1649EB0", VA = "0x1649EB0")]
		public static Bounds CTGetBounds(this RectTransform transform, float uiScaleFactor = 1f)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x164A34C", Offset = "0x164A34C", VA = "0x164A34C")]
		public static void CTSetLeft(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x164A430", Offset = "0x164A430", VA = "0x164A430")]
		public static void CTSetRight(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x164A514", Offset = "0x164A514", VA = "0x164A514")]
		public static void CTSetTop(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x164A5F8", Offset = "0x164A5F8", VA = "0x164A5F8")]
		public static void CTSetBottom(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x164A6DC", Offset = "0x164A6DC", VA = "0x164A6DC")]
		public static float CTGetLeft(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x164A7A4", Offset = "0x164A7A4", VA = "0x164A7A4")]
		public static float CTGetRight(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x164A86C", Offset = "0x164A86C", VA = "0x164A86C")]
		public static float CTGetTop(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x164A93C", Offset = "0x164A93C", VA = "0x164A93C")]
		public static float CTGetBottom(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x164AA0C", Offset = "0x164AA0C", VA = "0x164AA0C")]
		public static Vector4 CTGetLRTB(this RectTransform transform)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x164AB48", Offset = "0x164AB48", VA = "0x164AB48")]
		public static void CTSetLRTB(this RectTransform transform, Vector4 lrtb)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x164AC4C", Offset = "0x164AC4C", VA = "0x164AC4C")]
		public static GameObject CTFind(this MonoBehaviour mb, string name)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		public static T CTFind<T>(this MonoBehaviour mb, string name)
		{
			return (T)null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x164AE88", Offset = "0x164AE88", VA = "0x164AE88")]
		public static GameObject CTFind(this GameObject go, string name)
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		public static T CTFind<T>(this GameObject go, string name)
		{
			return (T)null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x164AFA8", Offset = "0x164AFA8", VA = "0x164AFA8")]
		public static Bounds CTGetBounds(this GameObject go)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x164AD6C", Offset = "0x164AD6C", VA = "0x164AD6C")]
		public static Transform CTFind(this Transform transform, string name)
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		public static T CTFind<T>(this Transform transform, string name)
		{
			return (T)null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x164B558", Offset = "0x164B558", VA = "0x164B558")]
		public static byte[] CTToPNG(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x164B71C", Offset = "0x164B71C", VA = "0x164B71C")]
		public static byte[] CTToJPG(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x164B8E0", Offset = "0x164B8E0", VA = "0x164B8E0")]
		public static byte[] CTToTGA(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x164BAA4", Offset = "0x164BAA4", VA = "0x164BAA4")]
		public static byte[] CTToEXR(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x164B65C", Offset = "0x164B65C", VA = "0x164B65C")]
		public static byte[] CTToPNG(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x164B820", Offset = "0x164B820", VA = "0x164B820")]
		public static byte[] CTToJPG(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x164B9E4", Offset = "0x164B9E4", VA = "0x164B9E4")]
		public static byte[] CTToTGA(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x164BBA8", Offset = "0x164BBA8", VA = "0x164BBA8")]
		public static byte[] CTToEXR(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x164BC68", Offset = "0x164BC68", VA = "0x164BC68")]
		public static bool CTIsVisibleFrom(this Renderer renderer, Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x164B1C4", Offset = "0x164B1C4", VA = "0x164B1C4")]
		private static Transform deepSearch(Transform parent, string name)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1647C94", Offset = "0x1647C94", VA = "0x1647C94")]
		private static float bytesToFloat(byte firstByte, byte secondByte)
		{
			return default(float);
		}
	}
}
namespace Crosstales.FB
{
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x74FD94", Offset = "0x74FD94")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class FileBrowser : Singleton<FileBrowser>
	{
		[Token(Token = "0x2000007")]
		public delegate void OpenFilesStart();

		[Token(Token = "0x2000008")]
		public delegate void OpenFilesComplete(bool selected, string singleFile, string[] files);

		[Token(Token = "0x2000009")]
		public delegate void OpenFoldersStart();

		[Token(Token = "0x200000A")]
		public delegate void OpenFoldersComplete(bool selected, string singleFolder, string[] folders);

		[Token(Token = "0x200000B")]
		public delegate void SaveFileStart();

		[Token(Token = "0x200000C")]
		public delegate void SaveFileComplete(bool selected, string file);

		[Serializable]
		[Token(Token = "0x200000D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74FDF0", Offset = "0x74FDF0")]
		private sealed class <>c
		{
			[Token(Token = "0x4000020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ExtensionFilter, IEnumerable<string>> <>9__146_0;

			[Token(Token = "0x6000100")]
			[Address(RVA = "0x1656074", Offset = "0x1656074", VA = "0x1656074")]
			public <>c()
			{
			}

			[Token(Token = "0x6000101")]
			[Address(RVA = "0x165607C", Offset = "0x165607C", VA = "0x165607C")]
			internal IEnumerable<string> <GetFiles>b__146_0(ExtensionFilter extensionFilter)
			{
				return null;
			}
		}

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FE80", Offset = "0x74FE80")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x74FE80", Offset = "0x74FE80")]
		private BaseCustomFileBrowser customWrapper;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FEF0", Offset = "0x74FEF0")]
		private bool customMode;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x74FF3C", Offset = "0x74FF3C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x74FF3C", Offset = "0x74FF3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FF3C", Offset = "0x74FF3C")]
		[SerializeField]
		private bool legacyFolderBrowser;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74FFD0", Offset = "0x74FFD0")]
		private bool askOverwriteFile;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75001C", Offset = "0x75001C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x75001C", Offset = "0x75001C")]
		private string titleOpenFile;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75008C", Offset = "0x75008C")]
		[SerializeField]
		private string titleOpenFiles;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7500D8", Offset = "0x7500D8")]
		[SerializeField]
		private string titleOpenFolder;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750124", Offset = "0x750124")]
		[SerializeField]
		private string titleOpenFolders;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750170", Offset = "0x750170")]
		[SerializeField]
		private string titleSaveFile;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7501BC", Offset = "0x7501BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7501BC", Offset = "0x7501BC")]
		[SerializeField]
		private string textAllFiles;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75022C", Offset = "0x75022C")]
		private string nameSaveFile;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string lastOpenSingleFile;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string[] lastOpenFiles;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string lastOpenSingleFolder;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string[] lastOpenFolders;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static string lastSaveFile;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private WrapperHolder wrapperHolder;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x750278", Offset = "0x750278")]
		public OnOpenFilesCompleted OnOpenFilesCompleted;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OnOpenFoldersCompleted OnOpenFoldersCompleted;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OnSaveFileCompleted OnSaveFileCompleted;

		[Token(Token = "0x17000001")]
		public BaseCustomFileBrowser CustomWrapper
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x164BE28", Offset = "0x164BE28", VA = "0x164BE28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x164BE30", Offset = "0x164BE30", VA = "0x164BE30")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public bool CustomMode
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x164C1A0", Offset = "0x164C1A0", VA = "0x164C1A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x164C1A8", Offset = "0x164C1A8", VA = "0x164C1A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public bool LegacyFolderBrowser
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x164C228", Offset = "0x164C228", VA = "0x164C228")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x164C230", Offset = "0x164C230", VA = "0x164C230")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public bool AskOverwriteFile
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x164C23C", Offset = "0x164C23C", VA = "0x164C23C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x164C244", Offset = "0x164C244", VA = "0x164C244")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public string TitleOpenFile
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x164C250", Offset = "0x164C250", VA = "0x164C250")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x164C258", Offset = "0x164C258", VA = "0x164C258")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public string TitleOpenFiles
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x164C260", Offset = "0x164C260", VA = "0x164C260")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x164C268", Offset = "0x164C268", VA = "0x164C268")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public string TitleOpenFolder
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x164C270", Offset = "0x164C270", VA = "0x164C270")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x164C278", Offset = "0x164C278", VA = "0x164C278")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public string TitleOpenFolders
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x164C280", Offset = "0x164C280", VA = "0x164C280")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x164C288", Offset = "0x164C288", VA = "0x164C288")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public string TitleSaveFile
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x164C290", Offset = "0x164C290", VA = "0x164C290")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x164C298", Offset = "0x164C298", VA = "0x164C298")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public string TextAllFiles
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x164C2A0", Offset = "0x164C2A0", VA = "0x164C2A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x164C2A8", Offset = "0x164C2A8", VA = "0x164C2A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public string NameSaveFile
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x164C2B0", Offset = "0x164C2B0", VA = "0x164C2B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x164C2B8", Offset = "0x164C2B8", VA = "0x164C2B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public string CurrentOpenSingleFile
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x164C2C0", Offset = "0x164C2C0", VA = "0x164C2C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x164C388", Offset = "0x164C388", VA = "0x164C388")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public string CurrentOpenSingleFileName
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x164C450", Offset = "0x164C450", VA = "0x164C450")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		public string[] CurrentOpenFiles
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x164C520", Offset = "0x164C520", VA = "0x164C520")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x164C5E8", Offset = "0x164C5E8", VA = "0x164C5E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public string CurrentOpenSingleFolder
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x164C6B0", Offset = "0x164C6B0", VA = "0x164C6B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x164C778", Offset = "0x164C778", VA = "0x164C778")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public string CurrentOpenSingleFolderName
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x164C840", Offset = "0x164C840", VA = "0x164C840")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public string[] CurrentOpenFolders
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x164C858", Offset = "0x164C858", VA = "0x164C858")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x164C920", Offset = "0x164C920", VA = "0x164C920")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public string CurrentSaveFile
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x164C9E8", Offset = "0x164C9E8", VA = "0x164C9E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x164CAB0", Offset = "0x164CAB0", VA = "0x164CAB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public string CurrentSaveFileName
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x164CB78", Offset = "0x164CB78", VA = "0x164CB78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public byte[] CurrentOpenSingleFileData
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x164CB90", Offset = "0x164CB90", VA = "0x164CB90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public byte[] CurrentSaveFileData
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x164CC58", Offset = "0x164CC58", VA = "0x164CC58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x164CD20", Offset = "0x164CD20", VA = "0x164CD20")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		private bool canOpenFile
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x164CDE8", Offset = "0x164CDE8", VA = "0x164CDE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		private bool canOpenFolder
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x164CEAC", Offset = "0x164CEAC", VA = "0x164CEAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		private bool canSaveFile
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x164CF74", Offset = "0x164CF74", VA = "0x164CF74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000019")]
		public bool canOpenMultipleFiles
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x164D03C", Offset = "0x164D03C", VA = "0x164D03C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		public bool canOpenMultipleFolders
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x164D104", Offset = "0x164D104", VA = "0x164D104")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		public bool isPlatformSupported
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x164D1CC", Offset = "0x164D1CC", VA = "0x164D1CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001C")]
		public bool isWorkingInEditor
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x164D294", Offset = "0x164D294", VA = "0x164D294")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000001")]
		public event OpenFilesStart OnOpenFilesStart
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x164D35C", Offset = "0x164D35C", VA = "0x164D35C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7511BC", Offset = "0x7511BC")]
			add
			{
			}
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x164D3FC", Offset = "0x164D3FC", VA = "0x164D3FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7511CC", Offset = "0x7511CC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event OpenFilesComplete OnOpenFilesComplete
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x164D49C", Offset = "0x164D49C", VA = "0x164D49C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7511DC", Offset = "0x7511DC")]
			add
			{
			}
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x164D53C", Offset = "0x164D53C", VA = "0x164D53C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7511EC", Offset = "0x7511EC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event OpenFoldersStart OnOpenFoldersStart
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x164D5DC", Offset = "0x164D5DC", VA = "0x164D5DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7511FC", Offset = "0x7511FC")]
			add
			{
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x164D67C", Offset = "0x164D67C", VA = "0x164D67C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75120C", Offset = "0x75120C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event OpenFoldersComplete OnOpenFoldersComplete
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x164D71C", Offset = "0x164D71C", VA = "0x164D71C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75121C", Offset = "0x75121C")]
			add
			{
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x164D7BC", Offset = "0x164D7BC", VA = "0x164D7BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75122C", Offset = "0x75122C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event SaveFileStart OnSaveFileStart
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x164D85C", Offset = "0x164D85C", VA = "0x164D85C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75123C", Offset = "0x75123C")]
			add
			{
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x164D8FC", Offset = "0x164D8FC", VA = "0x164D8FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75124C", Offset = "0x75124C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event SaveFileComplete OnSaveFileComplete
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x164D99C", Offset = "0x164D99C", VA = "0x164D99C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75125C", Offset = "0x75125C")]
			add
			{
			}
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x164DA3C", Offset = "0x164DA3C", VA = "0x164DA3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75126C", Offset = "0x75126C")]
			remove
			{
			}
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x164DADC", Offset = "0x164DADC", VA = "0x164DADC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x164DB54", Offset = "0x164DB54", VA = "0x164DB54")]
		private void Update()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x164E550", Offset = "0x164E550", VA = "0x164E550")]
		public string OpenSingleFile(string extension = "*")
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x164EBF8", Offset = "0x164EBF8", VA = "0x164EBF8")]
		public string OpenSingleFile(string title, string directory, string defaultName, params string[] extensions)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x164E9B0", Offset = "0x164E9B0", VA = "0x164E9B0")]
		public string OpenSingleFile(string title, string directory, string defaultName, params ExtensionFilter[] extensions)
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x164ED90", Offset = "0x164ED90", VA = "0x164ED90")]
		public string[] OpenFiles(string extension = "*")
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x164F0C0", Offset = "0x164F0C0", VA = "0x164F0C0")]
		public string[] OpenFiles(string title, string directory, string defaultName, params string[] extensions)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x164EE74", Offset = "0x164EE74", VA = "0x164EE74")]
		public string[] OpenFiles(string title, string directory, string defaultName, params ExtensionFilter[] extensions)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x164F10C", Offset = "0x164F10C", VA = "0x164F10C")]
		public string OpenSingleFolder()
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x164F178", Offset = "0x164F178", VA = "0x164F178")]
		public string OpenSingleFolder(string title, string directory = "")
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x164F474", Offset = "0x164F474", VA = "0x164F474")]
		public string[] OpenFolders()
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x164F4E0", Offset = "0x164F4E0", VA = "0x164F4E0")]
		public string[] OpenFolders(string title, string directory = "")
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x164F6B4", Offset = "0x164F6B4", VA = "0x164F6B4")]
		public string SaveFile(string defaultName = "", string extension = "*")
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x164FA00", Offset = "0x164FA00", VA = "0x164FA00")]
		public string SaveFile(string title, string directory, string defaultName, params string[] extensions)
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x164F7A4", Offset = "0x164F7A4", VA = "0x164F7A4")]
		public string SaveFile(string title, string directory, string defaultName, params ExtensionFilter[] extensions)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x164FB64", Offset = "0x164FB64", VA = "0x164FB64")]
		public void OpenSingleFileAsync(string extension = "*")
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x164FEEC", Offset = "0x164FEEC", VA = "0x164FEEC")]
		public void OpenSingleFileAsync(string title, string directory, string defaultName, params string[] extensions)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x164FC48", Offset = "0x164FC48", VA = "0x164FC48")]
		public void OpenSingleFileAsync(string title, string directory, string defaultName, params ExtensionFilter[] extensions)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x164FF38", Offset = "0x164FF38", VA = "0x164FF38")]
		public void OpenFilesAsync(bool multiselect = true, params string[] extensions)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1650274", Offset = "0x1650274", VA = "0x1650274")]
		public void OpenFilesAsync(string title, string directory, string defaultName, bool multiselect = true, params string[] extensions)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x164FFBC", Offset = "0x164FFBC", VA = "0x164FFBC")]
		public void OpenFilesAsync(string title, string directory, string defaultName, bool multiselect = true, params ExtensionFilter[] extensions)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x16502D0", Offset = "0x16502D0", VA = "0x16502D0")]
		public void OpenSingleFolderAsync()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x165033C", Offset = "0x165033C", VA = "0x165033C")]
		public void OpenSingleFolderAsync(string title, string directory = "")
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1650568", Offset = "0x1650568", VA = "0x1650568")]
		public void OpenFoldersAsync(bool multiselect = true)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x16505D0", Offset = "0x16505D0", VA = "0x16505D0")]
		public void OpenFoldersAsync(string title, string directory = "", bool multiselect = true)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1650810", Offset = "0x1650810", VA = "0x1650810")]
		public void SaveFileAsync(string defaultName = "", string extension = "*")
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1650BB4", Offset = "0x1650BB4", VA = "0x1650BB4")]
		public void SaveFileAsync(string title, string directory, string defaultName, params string[] extensions)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1650900", Offset = "0x1650900", VA = "0x1650900")]
		public void SaveFileAsync(string title, string directory, string defaultName, params ExtensionFilter[] extensions)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1650C00", Offset = "0x1650C00", VA = "0x1650C00")]
		public string[] GetFiles(string path, bool isRecursive = false, params string[] extensions)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1650C78", Offset = "0x1650C78", VA = "0x1650C78")]
		public string[] GetFiles(string path, bool isRecursive, params ExtensionFilter[] extensions)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1650DE0", Offset = "0x1650DE0", VA = "0x1650DE0")]
		public string[] GetFolders(string path, bool isRecursive = false)
		{
			return null;
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1650E50", Offset = "0x1650E50", VA = "0x1650E50")]
		public string[] GetDrives()
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1650EA8", Offset = "0x1650EA8", VA = "0x1650EA8")]
		public static void CopyFile(string sourceFile, string destFile, bool move = false)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1650F20", Offset = "0x1650F20", VA = "0x1650F20")]
		public static void CopyFolder(string sourcePath, string destPath, bool move = false)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1650F98", Offset = "0x1650F98", VA = "0x1650F98")]
		public static void ShowFile(string file)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1650FF0", Offset = "0x1650FF0", VA = "0x1650FF0")]
		public static void ShowFolder(string path)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1651050", Offset = "0x1651050", VA = "0x1651050")]
		public static void OpenFile(string file)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x16510A8", Offset = "0x16510A8", VA = "0x16510A8")]
		public void OpenFilesAsync(Action<string[]> cb, bool multiselect = true, params string[] extensions)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x16512C4", Offset = "0x16512C4", VA = "0x16512C4")]
		public void OpenFilesAsync(Action<string[]> cb, string title, string directory, string defaultName, bool multiselect = true, params string[] extensions)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1651158", Offset = "0x1651158", VA = "0x1651158")]
		public void OpenFilesAsync(Action<string[]> cb, string title, string directory, string defaultName, bool multiselect = true, params ExtensionFilter[] extensions)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1651328", Offset = "0x1651328", VA = "0x1651328")]
		public void OpenFoldersAsync(Action<string[]> cb, bool multiselect = true)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1651398", Offset = "0x1651398", VA = "0x1651398")]
		public void OpenFoldersAsync(Action<string[]> cb, string title, string directory = "", bool multiselect = true)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x16514E8", Offset = "0x16514E8", VA = "0x16514E8")]
		public void SaveFileAsync(Action<string> cb, string defaultName = "", string extension = "*")
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1651764", Offset = "0x1651764", VA = "0x1651764")]
		public void SaveFileAsync(Action<string> cb, string title, string directory, string defaultName, params string[] extensions)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x16515EC", Offset = "0x16515EC", VA = "0x16515EC")]
		public void SaveFileAsync(Action<string> cb, string title, string directory, string defaultName, params ExtensionFilter[] extensions)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x164C468", Offset = "0x164C468", VA = "0x164C468")]
		private string getNameFromPath(string path)
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x16517C0", Offset = "0x16517C0", VA = "0x16517C0")]
		private void setOpenFiles(params string[] paths)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x165180C", Offset = "0x165180C", VA = "0x165180C")]
		private void setOpenFolders(params string[] paths)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1651858", Offset = "0x1651858", VA = "0x1651858")]
		private void setSaveFile(params string[] paths)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x164E634", Offset = "0x164E634", VA = "0x164E634")]
		private ExtensionFilter[] getFilter(params string[] extensions)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x16518D4", Offset = "0x16518D4", VA = "0x16518D4")]
		private void makeSureInstanceExists()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x164EC44", Offset = "0x164EC44", VA = "0x164EC44")]
		private void onOpenFilesStart()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x164DF0C", Offset = "0x164DF0C", VA = "0x164DF0C")]
		private void onOpenFilesComplete(bool selected, string singleFile, string[] files)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x164F348", Offset = "0x164F348", VA = "0x164F348")]
		private void onOpenFoldersStart()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x164E0D8", Offset = "0x164E0D8", VA = "0x164E0D8")]
		private void onOpenFoldersComplete(bool selected, string singleFolder, string[] folders)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x164FA4C", Offset = "0x164FA4C", VA = "0x164FA4C")]
		private void onSaveFileStart()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x164E2A4", Offset = "0x164E2A4", VA = "0x164E2A4")]
		private void onSaveFileComplete(bool selected, string file)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x16525F4", Offset = "0x16525F4", VA = "0x16525F4")]
		public FileBrowser()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1652738", Offset = "0x1652738", VA = "0x1652738")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75127C", Offset = "0x75127C")]
		private void <SaveFileAsync>b__144_0(string paths)
		{
		}
	}
	[Token(Token = "0x200000E")]
	public struct ExtensionFilter
	{
		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Name;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string[] Extensions;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1645F44", Offset = "0x1645F44", VA = "0x1645F44")]
		public ExtensionFilter(string filterName, params string[] filterExtensions)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1645F4C", Offset = "0x1645F4C", VA = "0x1645F4C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class OnOpenFilesCompleted : UnityEvent<bool, string, string>
	{
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1653348", Offset = "0x1653348", VA = "0x1653348")]
		public OnOpenFilesCompleted()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	public class OnOpenFoldersCompleted : UnityEvent<bool, string, string>
	{
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1653394", Offset = "0x1653394", VA = "0x1653394")]
		public OnOpenFoldersCompleted()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	public class OnSaveFileCompleted : UnityEvent<bool, string>
	{
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x16533E0", Offset = "0x16533E0", VA = "0x16533E0")]
		public OnSaveFileCompleted()
		{
		}
	}
	[Token(Token = "0x2000012")]
	internal class WrapperHolder
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750310", Offset = "0x750310")]
		private IFileBrowser <PlatformWrapper>k__BackingField;

		[Token(Token = "0x1700001D")]
		public IFileBrowser PlatformWrapper
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x1655DC0", Offset = "0x1655DC0", VA = "0x1655DC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75128C", Offset = "0x75128C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x1655DC8", Offset = "0x1655DC8", VA = "0x1655DC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75129C", Offset = "0x75129C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x164BEDC", Offset = "0x164BEDC", VA = "0x164BEDC")]
		public WrapperHolder()
		{
		}
	}
	[Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	public class WrapperExample : BaseCustomFileBrowser
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750320", Offset = "0x750320")]
		private string <CurrentOpenSingleFile>k__BackingField;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750330", Offset = "0x750330")]
		private string[] <CurrentOpenFiles>k__BackingField;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750340", Offset = "0x750340")]
		private string <CurrentOpenSingleFolder>k__BackingField;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750350", Offset = "0x750350")]
		private string[] <CurrentOpenFolders>k__BackingField;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750360", Offset = "0x750360")]
		private string <CurrentSaveFile>k__BackingField;

		[Token(Token = "0x1700001E")]
		public override bool canOpenFile
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x1654F44", Offset = "0x1654F44", VA = "0x1654F44", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public override bool canOpenFolder
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x1654F4C", Offset = "0x1654F4C", VA = "0x1654F4C", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public override bool canSaveFile
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x1654F54", Offset = "0x1654F54", VA = "0x1654F54", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000021")]
		public override bool canOpenMultipleFiles
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x1654F5C", Offset = "0x1654F5C", VA = "0x1654F5C", Slot = "35")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		public override bool canOpenMultipleFolders
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x1654F64", Offset = "0x1654F64", VA = "0x1654F64", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000023")]
		public override bool isPlatformSupported
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x1654F6C", Offset = "0x1654F6C", VA = "0x1654F6C", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000024")]
		public override bool isWorkingInEditor
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x1654F74", Offset = "0x1654F74", VA = "0x1654F74", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000025")]
		public override string CurrentOpenSingleFile
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x1654F7C", Offset = "0x1654F7C", VA = "0x1654F7C", Slot = "39")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7512AC", Offset = "0x7512AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x1654F84", Offset = "0x1654F84", VA = "0x1654F84", Slot = "40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7512BC", Offset = "0x7512BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public override string[] CurrentOpenFiles
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x1654F8C", Offset = "0x1654F8C", VA = "0x1654F8C", Slot = "41")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7512CC", Offset = "0x7512CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x1654F94", Offset = "0x1654F94", VA = "0x1654F94", Slot = "42")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7512DC", Offset = "0x7512DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public override string CurrentOpenSingleFolder
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x1654F9C", Offset = "0x1654F9C", VA = "0x1654F9C", Slot = "43")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7512EC", Offset = "0x7512EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x1654FA4", Offset = "0x1654FA4", VA = "0x1654FA4", Slot = "44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7512FC", Offset = "0x7512FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public override string[] CurrentOpenFolders
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x1654FAC", Offset = "0x1654FAC", VA = "0x1654FAC", Slot = "45")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75130C", Offset = "0x75130C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x1654FB4", Offset = "0x1654FB4", VA = "0x1654FB4", Slot = "46")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75131C", Offset = "0x75131C")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public override string CurrentSaveFile
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x1654FBC", Offset = "0x1654FBC", VA = "0x1654FBC", Slot = "47")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75132C", Offset = "0x75132C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x1654FC4", Offset = "0x1654FC4", VA = "0x1654FC4", Slot = "48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75133C", Offset = "0x75133C")]
			set
			{
			}
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1654FCC", Offset = "0x1654FCC", VA = "0x1654FCC", Slot = "52")]
		public override string[] OpenFiles(string title, string directory, string defaultName, bool multiselect, params ExtensionFilter[] extensions)
		{
			return null;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x16552B4", Offset = "0x16552B4", VA = "0x16552B4", Slot = "53")]
		public override string[] OpenFolders(string title, string directory, bool multiselect)
		{
			return null;
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1655414", Offset = "0x1655414", VA = "0x1655414", Slot = "54")]
		public override string SaveFile(string title, string directory, string defaultName, params ExtensionFilter[] extensions)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1655708", Offset = "0x1655708", VA = "0x1655708", Slot = "55")]
		public override void OpenFilesAsync(string title, string directory, string defaultName, bool multiselect, ExtensionFilter[] extensions, Action<string[]> cb)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x16559B4", Offset = "0x16559B4", VA = "0x16559B4", Slot = "56")]
		public override void OpenFoldersAsync(string title, string directory, bool multiselect, Action<string[]> cb)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1655B70", Offset = "0x1655B70", VA = "0x1655B70", Slot = "57")]
		public override void SaveFileAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1655DB8", Offset = "0x1655DB8", VA = "0x1655DB8")]
		public WrapperExample()
		{
		}
	}
}
namespace Crosstales.FB.Wrapper
{
	[Token(Token = "0x2000014")]
	public abstract class BaseCustomFileBrowser : MonoBehaviour, IFileBrowser
	{
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected byte[] openSingleFileData;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected string lastOpenFile;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750370", Offset = "0x750370")]
		private byte[] <CurrentSaveFileData>k__BackingField;

		[Token(Token = "0x1700002A")]
		public abstract bool canOpenFile
		{
			[Token(Token = "0x6000122")]
			get;
		}

		[Token(Token = "0x1700002B")]
		public abstract bool canOpenFolder
		{
			[Token(Token = "0x6000123")]
			get;
		}

		[Token(Token = "0x1700002C")]
		public abstract bool canSaveFile
		{
			[Token(Token = "0x6000124")]
			get;
		}

		[Token(Token = "0x1700002D")]
		public abstract bool canOpenMultipleFiles
		{
			[Token(Token = "0x6000125")]
			get;
		}

		[Token(Token = "0x1700002E")]
		public abstract bool canOpenMultipleFolders
		{
			[Token(Token = "0x6000126")]
			get;
		}

		[Token(Token = "0x1700002F")]
		public abstract bool isPlatformSupported
		{
			[Token(Token = "0x6000127")]
			get;
		}

		[Token(Token = "0x17000030")]
		public abstract bool isWorkingInEditor
		{
			[Token(Token = "0x6000128")]
			get;
		}

		[Token(Token = "0x17000031")]
		public abstract string CurrentOpenSingleFile
		{
			[Token(Token = "0x6000129")]
			get;
			[Token(Token = "0x600012A")]
			set;
		}

		[Token(Token = "0x17000032")]
		public abstract string[] CurrentOpenFiles
		{
			[Token(Token = "0x600012B")]
			get;
			[Token(Token = "0x600012C")]
			set;
		}

		[Token(Token = "0x17000033")]
		public abstract string CurrentOpenSingleFolder
		{
			[Token(Token = "0x600012D")]
			get;
			[Token(Token = "0x600012E")]
			set;
		}

		[Token(Token = "0x17000034")]
		public abstract string[] CurrentOpenFolders
		{
			[Token(Token = "0x600012F")]
			get;
			[Token(Token = "0x6000130")]
			set;
		}

		[Token(Token = "0x17000035")]
		public abstract string CurrentSaveFile
		{
			[Token(Token = "0x6000131")]
			get;
			[Token(Token = "0x6000132")]
			set;
		}

		[Token(Token = "0x17000036")]
		public virtual byte[] CurrentOpenSingleFileData
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x163E8DC", Offset = "0x163E8DC", VA = "0x163E8DC", Slot = "49")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public virtual byte[] CurrentSaveFileData
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x163EA74", Offset = "0x163EA74", VA = "0x163EA74", Slot = "50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75134C", Offset = "0x75134C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x163EA7C", Offset = "0x163EA7C", VA = "0x163EA7C", Slot = "51")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75135C", Offset = "0x75135C")]
			set
			{
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x163EA84", Offset = "0x163EA84", VA = "0x163EA84", Slot = "24")]
		public string OpenSingleFile(string title, string directory, string defaultName, params ExtensionFilter[] extensions)
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		public abstract string[] OpenFiles(string title, string directory, string defaultName, bool multiselect, params ExtensionFilter[] extensions);

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x163EB40", Offset = "0x163EB40", VA = "0x163EB40", Slot = "26")]
		public string OpenSingleFolder(string title, string directory)
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		public abstract string[] OpenFolders(string title, string directory, bool multiselect);

		[Token(Token = "0x600013A")]
		public abstract string SaveFile(string title, string directory, string defaultName, params ExtensionFilter[] extensions);

		[Token(Token = "0x600013B")]
		public abstract void OpenFilesAsync(string title, string directory, string defaultName, bool multiselect, ExtensionFilter[] extensions, Action<string[]> cb);

		[Token(Token = "0x600013C")]
		public abstract void OpenFoldersAsync(string title, string directory, bool multiselect, Action<string[]> cb);

		[Token(Token = "0x600013D")]
		public abstract void SaveFileAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb);

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x163EBE4", Offset = "0x163EBE4", VA = "0x163EBE4")]
		protected BaseCustomFileBrowser()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public abstract class BaseFileBrowser : IFileBrowser
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected byte[] openSingleFileData;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string lastOpenFile;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750380", Offset = "0x750380")]
		private byte[] <CurrentSaveFileData>k__BackingField;

		[Token(Token = "0x17000038")]
		public abstract bool canOpenFile
		{
			[Token(Token = "0x600013F")]
			get;
		}

		[Token(Token = "0x17000039")]
		public abstract bool canOpenFolder
		{
			[Token(Token = "0x6000140")]
			get;
		}

		[Token(Token = "0x1700003A")]
		public abstract bool canSaveFile
		{
			[Token(Token = "0x6000141")]
			get;
		}

		[Token(Token = "0x1700003B")]
		public abstract bool canOpenMultipleFiles
		{
			[Token(Token = "0x6000142")]
			get;
		}

		[Token(Token = "0x1700003C")]
		public abstract bool canOpenMultipleFolders
		{
			[Token(Token = "0x6000143")]
			get;
		}

		[Token(Token = "0x1700003D")]
		public abstract bool isPlatformSupported
		{
			[Token(Token = "0x6000144")]
			get;
		}

		[Token(Token = "0x1700003E")]
		public abstract bool isWorkingInEditor
		{
			[Token(Token = "0x6000145")]
			get;
		}

		[Token(Token = "0x1700003F")]
		public abstract string CurrentOpenSingleFile
		{
			[Token(Token = "0x6000146")]
			get;
			[Token(Token = "0x6000147")]
			set;
		}

		[Token(Token = "0x17000040")]
		public abstract string[] CurrentOpenFiles
		{
			[Token(Token = "0x6000148")]
			get;
			[Token(Token = "0x6000149")]
			set;
		}

		[Token(Token = "0x17000041")]
		public abstract string CurrentOpenSingleFolder
		{
			[Token(Token = "0x600014A")]
			get;
			[Token(Token = "0x600014B")]
			set;
		}

		[Token(Token = "0x17000042")]
		public abstract string[] CurrentOpenFolders
		{
			[Token(Token = "0x600014C")]
			get;
			[Token(Token = "0x600014D")]
			set;
		}

		[Token(Token = "0x17000043")]
		public abstract string CurrentSaveFile
		{
			[Token(Token = "0x600014E")]
			get;
			[Token(Token = "0x600014F")]
			set;
		}

		[Token(Token = "0x17000044")]
		public virtual byte[] CurrentOpenSingleFileData
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x163EBEC", Offset = "0x163EBEC", VA = "0x163EBEC", Slot = "49")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public virtual byte[] CurrentSaveFileData
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x163ED84", Offset = "0x163ED84", VA = "0x163ED84", Slot = "50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75136C", Offset = "0x75136C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x163ED8C", Offset = "0x163ED8C", VA = "0x163ED8C", Slot = "51")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75137C", Offset = "0x75137C")]
			set
			{
			}
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x163ED94", Offset = "0x163ED94", VA = "0x163ED94", Slot = "24")]
		public string OpenSingleFile(string title, string directory, string defaultName, params ExtensionFilter[] extensions)
		{
			return null;
		}

		[Token(Token = "0x6000154")]
		public abstract string[] OpenFiles(string title, string directory, string defaultName, bool multiselect, params ExtensionFilter[] extensions);

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x163EE50", Offset = "0x163EE50", VA = "0x163EE50", Slot = "26")]
		public string OpenSingleFolder(string title, string directory)
		{
			return null;
		}

		[Token(Token = "0x6000156")]
		public abstract string[] OpenFolders(string title, string directory, bool multiselect);

		[Token(Token = "0x6000157")]
		public abstract string SaveFile(string title, string directory, string defaultName, params ExtensionFilter[] extensions);

		[Token(Token = "0x6000158")]
		public abstract void OpenFilesAsync(string title, string directory, string defaultName, bool multiselect, ExtensionFilter[] extensions, Action<string[]> cb);

		[Token(Token = "0x6000159")]
		public abstract void OpenFoldersAsync(string title, string directory, bool multiselect, Action<string[]> cb);

		[Token(Token = "0x600015A")]
		public abstract void SaveFileAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb);

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x163EEF4", Offset = "0x163EEF4", VA = "0x163EEF4")]
		protected BaseFileBrowser()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class FileBrowserGeneric : BaseFileBrowser
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750390", Offset = "0x750390")]
		private string <CurrentOpenSingleFile>k__BackingField;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7503A0", Offset = "0x7503A0")]
		private string[] <CurrentOpenFiles>k__BackingField;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7503B0", Offset = "0x7503B0")]
		private string <CurrentOpenSingleFolder>k__BackingField;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7503C0", Offset = "0x7503C0")]
		private string[] <CurrentOpenFolders>k__BackingField;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7503D0", Offset = "0x7503D0")]
		private string <CurrentSaveFile>k__BackingField;

		[Token(Token = "0x17000046")]
		public override bool canOpenFile
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x16527D4", Offset = "0x16527D4", VA = "0x16527D4", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		public override bool canOpenFolder
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x16527DC", Offset = "0x16527DC", VA = "0x16527DC", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		public override bool canSaveFile
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x16527E4", Offset = "0x16527E4", VA = "0x16527E4", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		public override bool canOpenMultipleFiles
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x16527EC", Offset = "0x16527EC", VA = "0x16527EC", Slot = "35")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		public override bool canOpenMultipleFolders
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x16527F4", Offset = "0x16527F4", VA = "0x16527F4", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		public override bool isPlatformSupported
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x16527FC", Offset = "0x16527FC", VA = "0x16527FC", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		public override bool isWorkingInEditor
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x1652804", Offset = "0x1652804", VA = "0x1652804", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		public override string CurrentOpenSingleFile
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x165280C", Offset = "0x165280C", VA = "0x165280C", Slot = "39")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75138C", Offset = "0x75138C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x1652814", Offset = "0x1652814", VA = "0x1652814", Slot = "40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75139C", Offset = "0x75139C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public override string[] CurrentOpenFiles
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x165281C", Offset = "0x165281C", VA = "0x165281C", Slot = "41")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7513AC", Offset = "0x7513AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x1652824", Offset = "0x1652824", VA = "0x1652824", Slot = "42")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7513BC", Offset = "0x7513BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public override string CurrentOpenSingleFolder
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x165282C", Offset = "0x165282C", VA = "0x165282C", Slot = "43")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7513CC", Offset = "0x7513CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x1652834", Offset = "0x1652834", VA = "0x1652834", Slot = "44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7513DC", Offset = "0x7513DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public override string[] CurrentOpenFolders
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x165283C", Offset = "0x165283C", VA = "0x165283C", Slot = "45")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7513EC", Offset = "0x7513EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x1652844", Offset = "0x1652844", VA = "0x1652844", Slot = "46")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7513FC", Offset = "0x7513FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public override string CurrentSaveFile
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x165284C", Offset = "0x165284C", VA = "0x165284C", Slot = "47")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75140C", Offset = "0x75140C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x1652854", Offset = "0x1652854", VA = "0x1652854", Slot = "48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75141C", Offset = "0x75141C")]
			set
			{
			}
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x165285C", Offset = "0x165285C", VA = "0x165285C", Slot = "52")]
		public override string[] OpenFiles(string title, string directory, string defaultName, bool multiselect, params ExtensionFilter[] extensions)
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x16528F0", Offset = "0x16528F0", VA = "0x16528F0", Slot = "53")]
		public override string[] OpenFolders(string title, string directory, bool multiselect)
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1652984", Offset = "0x1652984", VA = "0x1652984", Slot = "54")]
		public override string SaveFile(string title, string directory, string defaultName, params ExtensionFilter[] extensions)
		{
			return null;
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1652A1C", Offset = "0x1652A1C", VA = "0x1652A1C", Slot = "55")]
		public override void OpenFilesAsync(string title, string directory, string defaultName, bool multiselect, ExtensionFilter[] extensions, Action<string[]> cb)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1652ACC", Offset = "0x1652ACC", VA = "0x1652ACC", Slot = "56")]
		public override void OpenFoldersAsync(string title, string directory, bool multiselect, Action<string[]> cb)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1652B64", Offset = "0x1652B64", VA = "0x1652B64", Slot = "57")]
		public override void SaveFileAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1652C0C", Offset = "0x1652C0C", VA = "0x1652C0C")]
		public FileBrowserGeneric()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public interface IFileBrowser
	{
		[Token(Token = "0x17000052")]
		bool canOpenFile
		{
			[Token(Token = "0x6000174")]
			get;
		}

		[Token(Token = "0x17000053")]
		bool canOpenFolder
		{
			[Token(Token = "0x6000175")]
			get;
		}

		[Token(Token = "0x17000054")]
		bool canSaveFile
		{
			[Token(Token = "0x6000176")]
			get;
		}

		[Token(Token = "0x17000055")]
		bool canOpenMultipleFiles
		{
			[Token(Token = "0x6000177")]
			get;
		}

		[Token(Token = "0x17000056")]
		bool canOpenMultipleFolders
		{
			[Token(Token = "0x6000178")]
			get;
		}

		[Token(Token = "0x17000057")]
		bool isPlatformSupported
		{
			[Token(Token = "0x6000179")]
			get;
		}

		[Token(Token = "0x17000058")]
		bool isWorkingInEditor
		{
			[Token(Token = "0x600017A")]
			get;
		}

		[Token(Token = "0x17000059")]
		string CurrentOpenSingleFile
		{
			[Token(Token = "0x600017B")]
			get;
			[Token(Token = "0x600017C")]
			set;
		}

		[Token(Token = "0x1700005A")]
		string[] CurrentOpenFiles
		{
			[Token(Token = "0x600017D")]
			get;
			[Token(Token = "0x600017E")]
			set;
		}

		[Token(Token = "0x1700005B")]
		string CurrentOpenSingleFolder
		{
			[Token(Token = "0x600017F")]
			get;
			[Token(Token = "0x6000180")]
			set;
		}

		[Token(Token = "0x1700005C")]
		string[] CurrentOpenFolders
		{
			[Token(Token = "0x6000181")]
			get;
			[Token(Token = "0x6000182")]
			set;
		}

		[Token(Token = "0x1700005D")]
		string CurrentSaveFile
		{
			[Token(Token = "0x6000183")]
			get;
			[Token(Token = "0x6000184")]
			set;
		}

		[Token(Token = "0x1700005E")]
		byte[] CurrentOpenSingleFileData
		{
			[Token(Token = "0x6000185")]
			get;
		}

		[Token(Token = "0x1700005F")]
		byte[] CurrentSaveFileData
		{
			[Token(Token = "0x6000186")]
			get;
			[Token(Token = "0x6000187")]
			set;
		}

		[Token(Token = "0x6000188")]
		string OpenSingleFile(string title, string directory, string defaultName, params ExtensionFilter[] extensions);

		[Token(Token = "0x6000189")]
		string[] OpenFiles(string title, string directory, string defaultName, bool multiselect, params ExtensionFilter[] extensions);

		[Token(Token = "0x600018A")]
		string OpenSingleFolder(string title, string directory);

		[Token(Token = "0x600018B")]
		string[] OpenFolders(string title, string directory, bool multiselect);

		[Token(Token = "0x600018C")]
		string SaveFile(string title, string directory, string defaultName, params ExtensionFilter[] extensions);

		[Token(Token = "0x600018D")]
		void OpenFilesAsync(string title, string directory, string defaultName, bool multiselect, ExtensionFilter[] extensions, Action<string[]> cb);

		[Token(Token = "0x600018E")]
		void OpenFoldersAsync(string title, string directory, bool multiselect, Action<string[]> cb);

		[Token(Token = "0x600018F")]
		void SaveFileAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb);
	}
}
namespace Crosstales.FB.Util
{
	[Token(Token = "0x2000018")]
	public static class Config
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string ASSET_PATH;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool DEBUG;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		public static bool NATIVE_WINDOWS;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public static bool isLoaded;
	}
	[Token(Token = "0x2000019")]
	public abstract class Constants : BaseConstants
	{
		[Token(Token = "0x4000039")]
		public const string ASSET_NAME = "File Browser PRO";

		[Token(Token = "0x400003A")]
		public const string ASSET_NAME_SHORT = "FB PRO";

		[Token(Token = "0x400003B")]
		public const string ASSET_VERSION = "2021.3.0";

		[Token(Token = "0x400003C")]
		public const int ASSET_BUILD = 20210825;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly DateTime ASSET_CREATED;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly DateTime ASSET_CHANGED;

		[Token(Token = "0x400003F")]
		public const string ASSET_PRO_URL = "https://assetstore.unity.com/packages/slug/98713?aid=1011lNGT";

		[Token(Token = "0x4000040")]
		public const string ASSET_UPDATE_CHECK_URL = "https://www.crosstales.com/media/assets/fb_versions.txt";

		[Token(Token = "0x4000041")]
		public const string ASSET_CONTACT = "fb@crosstales.com";

		[Token(Token = "0x4000042")]
		public const string ASSET_MANUAL_URL = "https://www.crosstales.com/media/data/assets/FileBrowser/FileBrowser-doc.pdf";

		[Token(Token = "0x4000043")]
		public const string ASSET_API_URL = "https://www.crosstales.com/media/data/assets/FileBrowser/api/";

		[Token(Token = "0x4000044")]
		public const string ASSET_FORUM_URL = "https://forum.unity.com/threads/file-browser-native-file-browser-for-standalone.510403/";

		[Token(Token = "0x4000045")]
		public const string ASSET_WEB_URL = "https://www.crosstales.com/en/portfolio/FileBrowser/";

		[Token(Token = "0x4000046")]
		public const string ASSET_VIDEO_TUTORIAL = "https://youtu.be/nczXecD0uB0?list=PLgtonIOr6Tb41XTMeeZ836tjHlKgOO84S";

		[Token(Token = "0x4000047")]
		public const string ASSET_3P_RTFB = "https://assetstore.unity.com/packages/slug/113006?aid=1011lNGT";

		[Token(Token = "0x4000048")]
		public const string ASSET_3P_WEBGL = "https://assetstore.unity.com/packages/slug/41902?aid=1011lNGT";

		[Token(Token = "0x4000049")]
		public const string KEY_PREFIX = "FILEBROWSER_CFG_";

		[Token(Token = "0x400004A")]
		public const string KEY_ASSET_PATH = "FILEBROWSER_CFG_ASSET_PATH";

		[Token(Token = "0x400004B")]
		public const string KEY_DEBUG = "FILEBROWSER_CFG_DEBUG";

		[Token(Token = "0x400004C")]
		public const string KEY_NATIVE_WINDOWS = "FILEBROWSER_CFG_NATIVE_WINDOWS";

		[Token(Token = "0x400004D")]
		public const bool DEFAULT_NATIVE_WINDOWS = false;

		[Token(Token = "0x400004E")]
		public const string FB_SCENE_OBJECT_NAME = "FileBrowser";

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1645E44", Offset = "0x1645E44", VA = "0x1645E44")]
		protected Constants()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public abstract class Helper : BaseHelper
	{
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1652C14", Offset = "0x1652C14", VA = "0x1652C14")]
		protected Helper()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class SetupProject
	{
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1654990", Offset = "0x1654990", VA = "0x1654990")]
		static SetupProject()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1654994", Offset = "0x1654994", VA = "0x1654994")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x75142C", Offset = "0x75142C")]
		private static void setup()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1654A34", Offset = "0x1654A34", VA = "0x1654A34")]
		public SetupProject()
		{
		}
	}
}
namespace Crosstales.Common.Model.Enum
{
	[Token(Token = "0x200001C")]
	public enum Platform
	{
		[Token(Token = "0x4000050")]
		Windows,
		[Token(Token = "0x4000051")]
		OSX,
		[Token(Token = "0x4000052")]
		Linux,
		[Token(Token = "0x4000053")]
		IOS,
		[Token(Token = "0x4000054")]
		Android,
		[Token(Token = "0x4000055")]
		WSA,
		[Token(Token = "0x4000056")]
		Web,
		[Token(Token = "0x4000057")]
		Unsupported
	}
	[Token(Token = "0x200001D")]
	public enum SampleRate
	{
		[Token(Token = "0x4000059")]
		_8000Hz = 8000,
		[Token(Token = "0x400005A")]
		_11025Hz = 11025,
		[Token(Token = "0x400005B")]
		_22050Hz = 22050,
		[Token(Token = "0x400005C")]
		_44100Hz = 44100,
		[Token(Token = "0x400005D")]
		_48000Hz = 48000
	}
}
namespace Crosstales.Common.Util
{
	[Token(Token = "0x200001E")]
	[DisallowMultipleComponent]
	public class CTScreenshot : Singleton<CTScreenshot>
	{
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7503E0", Offset = "0x7503E0")]
		public string Prefix;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750418", Offset = "0x750418")]
		public int Scale;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750450", Offset = "0x750450")]
		public KeyCode KeyCode;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750488", Offset = "0x750488")]
		public bool ShowFileLocation;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Texture2D texture;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool locationShown;

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x16458B4", Offset = "0x16458B4", VA = "0x16458B4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x16458F0", Offset = "0x16458F0", VA = "0x16458F0")]
		public void Capture()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1645A78", Offset = "0x1645A78", VA = "0x1645A78")]
		public CTScreenshot()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class PlatformController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74FE20", Offset = "0x74FE20")]
		private sealed class <>c
		{
			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<GameObject, bool> <>9__8_0;

			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<MonoBehaviour, bool> <>9__9_0;

			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x16563E8", Offset = "0x16563E8", VA = "0x16563E8")]
			public <>c()
			{
			}

			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x16563F0", Offset = "0x16563F0", VA = "0x16563F0")]
			internal bool <activateGameObjects>b__8_0(GameObject go)
			{
				return default(bool);
			}

			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x1656458", Offset = "0x1656458", VA = "0x1656458")]
			internal bool <activateScripts>b__9_0(MonoBehaviour script)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7504C0", Offset = "0x7504C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7504C0", Offset = "0x7504C0")]
		public List<Platform> Platforms;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750520", Offset = "0x750520")]
		public bool Active;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x750558", Offset = "0x750558")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750558", Offset = "0x750558")]
		public GameObject[] Objects;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7505B8", Offset = "0x7505B8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7505B8", Offset = "0x7505B8")]
		public MonoBehaviour[] Scripts;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Platform currentPlatform;

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x165342C", Offset = "0x165342C", VA = "0x165342C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x16534D8", Offset = "0x16534D8", VA = "0x16534D8")]
		private void Start()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1653464", Offset = "0x1653464", VA = "0x1653464")]
		protected void selectPlatform()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x16534DC", Offset = "0x16534DC", VA = "0x16534DC")]
		protected void activateGameObjects()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x16538E0", Offset = "0x16538E0", VA = "0x16538E0")]
		protected void activateScripts()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1653CE4", Offset = "0x1653CE4", VA = "0x1653CE4")]
		public PlatformController()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class RandomColor : MonoBehaviour
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750618", Offset = "0x750618")]
		public bool UseInterval;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750650", Offset = "0x750650")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750688", Offset = "0x750688")]
		public Vector2 HueRange;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7506C0", Offset = "0x7506C0")]
		public Vector2 SaturationRange;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7506F8", Offset = "0x7506F8")]
		public Vector2 ValueRange;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750730", Offset = "0x750730")]
		public Vector2 AlphaRange;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750768", Offset = "0x750768")]
		public bool GrayScale;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7507A0", Offset = "0x7507A0")]
		public Material Material;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7507D8", Offset = "0x7507D8")]
		public bool RandomColorAtStart;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float elapsedTime;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float changeTime;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer currentRenderer;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Color32 startColor;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Color32 endColor;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float lerpProgress;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int colorID;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool existsMaterial;

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1653CF4", Offset = "0x1653CF4", VA = "0x1653CF4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1653F64", Offset = "0x1653F64", VA = "0x1653F64")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1654254", Offset = "0x1654254", VA = "0x1654254")]
		public RandomColor()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[DisallowMultipleComponent]
	public class RandomRotator : MonoBehaviour
	{
		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750810", Offset = "0x750810")]
		public bool UseInterval;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750848", Offset = "0x750848")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750880", Offset = "0x750880")]
		public Vector3 SpeedMin;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7508B8", Offset = "0x7508B8")]
		public Vector3 SpeedMax;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7508F0", Offset = "0x7508F0")]
		public bool RandomRotationAtStart;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750928", Offset = "0x750928")]
		public bool RandomChangeIntervalPerAxis;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform tf;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 speed;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float elapsedTime;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float changeTime;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 elapsedTimeAxis;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 changeTimeAxis;

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x16542EC", Offset = "0x16542EC", VA = "0x16542EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1654398", Offset = "0x1654398", VA = "0x1654398")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x16546AC", Offset = "0x16546AC", VA = "0x16546AC")]
		public RandomRotator()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[DisallowMultipleComponent]
	public class RandomScaler : MonoBehaviour
	{
		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750960", Offset = "0x750960")]
		public bool UseInterval;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750998", Offset = "0x750998")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7509D0", Offset = "0x7509D0")]
		public Vector3 ScaleMin;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750A08", Offset = "0x750A08")]
		public Vector3 ScaleMax;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750A40", Offset = "0x750A40")]
		public bool Uniform;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750A78", Offset = "0x750A78")]
		public bool RandomScaleAtStart;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform tf;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 startScale;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 endScale;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float elapsedTime;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float changeTime;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float lerpTime;

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1654704", Offset = "0x1654704", VA = "0x1654704")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x16547E0", Offset = "0x16547E0", VA = "0x16547E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1654964", Offset = "0x1654964", VA = "0x1654964")]
		public RandomScaler()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public abstract class BaseConstants
	{
		[Token(Token = "0x4000095")]
		public const string ASSET_AUTHOR = "crosstales LLC";

		[Token(Token = "0x4000096")]
		public const string ASSET_AUTHOR_URL = "https://www.crosstales.com";

		[Token(Token = "0x4000097")]
		public const string ASSET_CT_URL = "https://assetstore.unity.com/lists/crosstales-42213?aid=1011lNGT";

		[Token(Token = "0x4000098")]
		public const string ASSET_SOCIAL_DISCORD = "https://discord.gg/ZbZ2sh4";

		[Token(Token = "0x4000099")]
		public const string ASSET_SOCIAL_FACEBOOK = "https://www.facebook.com/crosstales/";

		[Token(Token = "0x400009A")]
		public const string ASSET_SOCIAL_TWITTER = "https://twitter.com/crosstales";

		[Token(Token = "0x400009B")]
		public const string ASSET_SOCIAL_YOUTUBE = "https://www.youtube.com/c/Crosstales";

		[Token(Token = "0x400009C")]
		public const string ASSET_SOCIAL_LINKEDIN = "https://www.linkedin.com/company/crosstales";

		[Token(Token = "0x400009D")]
		public const string ASSET_3P_PLAYMAKER = "https://assetstore.unity.com/packages/slug/368?aid=1011lNGT";

		[Token(Token = "0x400009E")]
		public const string ASSET_3P_VOLUMETRIC_AUDIO = "https://assetstore.unity.com/packages/slug/17125?aid=1011lNGT";

		[Token(Token = "0x400009F")]
		public const string ASSET_3P_ROCKTOMATE = "https://assetstore.unity.com/packages/slug/156311?aid=1011lNGT";

		[Token(Token = "0x40000A0")]
		public const string ASSET_BWF = "https://assetstore.unity.com/packages/slug/26255?aid=1011lNGT";

		[Token(Token = "0x40000A1")]
		public const string ASSET_DJ = "https://assetstore.unity.com/packages/slug/41993?aid=1011lNGT";

		[Token(Token = "0x40000A2")]
		public const string ASSET_FB = "https://assetstore.unity.com/packages/slug/98713?aid=1011lNGT";

		[Token(Token = "0x40000A3")]
		public const string ASSET_OC = "https://assetstore.unity.com/packages/slug/74688?aid=1011lNGT";

		[Token(Token = "0x40000A4")]
		public const string ASSET_RADIO = "https://assetstore.unity.com/packages/slug/32034?aid=1011lNGT";

		[Token(Token = "0x40000A5")]
		public const string ASSET_RTV = "https://assetstore.unity.com/packages/slug/41068?aid=1011lNGT";

		[Token(Token = "0x40000A6")]
		public const string ASSET_TB = "https://assetstore.unity.com/packages/slug/98711?aid=1011lNGT";

		[Token(Token = "0x40000A7")]
		public const string ASSET_TPB = "https://assetstore.unity.com/packages/slug/98714?aid=1011lNGT";

		[Token(Token = "0x40000A8")]
		public const string ASSET_TPS = "https://assetstore.unity.com/packages/slug/60040?aid=1011lNGT";

		[Token(Token = "0x40000A9")]
		public const string ASSET_TR = "https://assetstore.unity.com/packages/slug/61617?aid=1011lNGT";

		[Token(Token = "0x40000AA")]
		public const int FACTOR_KB = 1024;

		[Token(Token = "0x40000AB")]
		public const int FACTOR_MB = 1048576;

		[Token(Token = "0x40000AC")]
		public const int FACTOR_GB = 1073741824;

		[Token(Token = "0x40000AD")]
		public const float FLOAT_32768 = 32768f;

		[Token(Token = "0x40000AE")]
		public const float FLOAT_TOLERANCE = 0.0001f;

		[Token(Token = "0x40000AF")]
		public const string FORMAT_TWO_DECIMAL_PLACES = "0.00";

		[Token(Token = "0x40000B0")]
		public const string FORMAT_NO_DECIMAL_PLACES = "0";

		[Token(Token = "0x40000B1")]
		public const string FORMAT_PERCENT = "0%";

		[Token(Token = "0x40000B2")]
		public const bool DEFAULT_DEBUG = false;

		[Token(Token = "0x40000B3")]
		public const string PATH_DELIMITER_WINDOWS = "\\";

		[Token(Token = "0x40000B4")]
		public const string PATH_DELIMITER_UNIX = "/";

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Regex REGEX_LINEENDINGS;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Regex REGEX_EMAIL;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Regex REGEX_CREDITCARD;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Regex REGEX_URL_WEB;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Regex REGEX_IP_ADDRESS;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly Regex REGEX_INVALID_CHARS;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly Regex REGEX_ALPHANUMERIC;

		[Token(Token = "0x40000BC")]
		public const string LATIN_ABC_UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		[Token(Token = "0x40000BD")]
		public const string LATIN_ABC_LOWERCASE = "abcdefghijklmnopqrstuvwxyz";

		[Token(Token = "0x40000BE")]
		public const string LATIN_ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

		[Token(Token = "0x40000BF")]
		public const string NUMBERS = "0123456789";

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static bool DEV_DEBUG;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string TEXT_TOSTRING_START;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string TEXT_TOSTRING_END;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string TEXT_TOSTRING_DELIMITER;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string TEXT_TOSTRING_DELIMITER_END;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string PREFIX_HTTP;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string PREFIX_HTTPS;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static int PROCESS_KILL_TIME;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string CMD_WINDOWS_PATH;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static bool SHOW_BWF_BANNER;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public static bool SHOW_DJ_BANNER;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		public static bool SHOW_FB_BANNER;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
		public static bool SHOW_OC_BANNER;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static bool SHOW_RADIO_BANNER;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		public static bool SHOW_RTV_BANNER;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
		public static bool SHOW_TB_BANNER;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x87")]
		public static bool SHOW_TPB_BANNER;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static bool SHOW_TPS_BANNER;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public static bool SHOW_TR_BANNER;

		[Token(Token = "0x17000060")]
		public static string PREFIX_FILE
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x163E1D4", Offset = "0x163E1D4", VA = "0x163E1D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public static string APPLICATION_PATH
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x163E310", Offset = "0x163E310", VA = "0x163E310")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x163E5A8", Offset = "0x163E5A8", VA = "0x163E5A8")]
		protected BaseConstants()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public abstract class BaseHelper
	{
		[Serializable]
		[Token(Token = "0x2000026")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74FE50", Offset = "0x74FE50")]
		private sealed class <>c
		{
			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<X509ChainStatus, bool> <>9__64_0;

			[Token(Token = "0x40000DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<string, bool> <>9__69_0;

			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<string, string> <>9__69_1;

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x1655E38", Offset = "0x1655E38", VA = "0x1655E38")]
			public <>c()
			{
			}

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x1655E40", Offset = "0x1655E40", VA = "0x1655E40")]
			internal bool <RemoteCertificateValidationCallback>b__64_0(X509ChainStatus t)
			{
				return default(bool);
			}

			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x1655E4C", Offset = "0x1655E4C", VA = "0x1655E4C")]
			internal bool <GetFiles>b__69_0(string extension)
			{
				return default(bool);
			}

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x1655EDC", Offset = "0x1655EDC", VA = "0x1655EDC")]
			internal string <GetFiles>b__69_1(string q)
			{
				return null;
			}
		}

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly CultureInfo BaseCulture;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static readonly Regex cleanSpacesRegex;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static readonly Regex cleanTagsRegex;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected static readonly System.Random rnd;

		[Token(Token = "0x40000D7")]
		protected const string file_prefix = "file://";

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool ApplicationIsPlaying;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static string applicationDataPath;

		[Token(Token = "0x17000062")]
		public static bool isInternetAvailable
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x163EEFC", Offset = "0x163EEFC", VA = "0x163EEFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000063")]
		public static bool isWindowsPlatform
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x163EF1C", Offset = "0x163EF1C", VA = "0x163EF1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		public static bool isMacOSPlatform
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x163EF24", Offset = "0x163EF24", VA = "0x163EF24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		public static bool isLinuxPlatform
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x163EF2C", Offset = "0x163EF2C", VA = "0x163EF2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000066")]
		public static bool isStandalonePlatform
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x163EF34", Offset = "0x163EF34", VA = "0x163EF34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		public static bool isAndroidPlatform
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x163EFC0", Offset = "0x163EFC0", VA = "0x163EFC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		public static bool isIOSPlatform
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x163EFC8", Offset = "0x163EFC8", VA = "0x163EFC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		public static bool isTvOSPlatform
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x163EFD0", Offset = "0x163EFD0", VA = "0x163EFD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		public static bool isWSAPlatform
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x163EFD8", Offset = "0x163EFD8", VA = "0x163EFD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		public static bool isXboxOnePlatform
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x163EFE0", Offset = "0x163EFE0", VA = "0x163EFE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		public static bool isPS4Platform
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x163EFE8", Offset = "0x163EFE8", VA = "0x163EFE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		public static bool isWebGLPlatform
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x163EFF0", Offset = "0x163EFF0", VA = "0x163EFF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		public static bool isWebPlatform
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x163EFF8", Offset = "0x163EFF8", VA = "0x163EFF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		public static bool isWindowsBasedPlatform
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x163E26C", Offset = "0x163E26C", VA = "0x163E26C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		public static bool isWSABasedPlatform
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x163F054", Offset = "0x163F054", VA = "0x163F054")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		public static bool isAppleBasedPlatform
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x163F0C8", Offset = "0x163F0C8", VA = "0x163F0C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000072")]
		public static bool isIOSBasedPlatform
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x163F154", Offset = "0x163F154", VA = "0x163F154")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000073")]
		public static bool isMobilePlatform
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x163F1C8", Offset = "0x163F1C8", VA = "0x163F1C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000074")]
		public static bool isEditor
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x163F224", Offset = "0x163F224", VA = "0x163F224")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000075")]
		public static bool isWindowsEditor
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x163E2F8", Offset = "0x163E2F8", VA = "0x163E2F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000076")]
		public static bool isMacOSEditor
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x163E300", Offset = "0x163E300", VA = "0x163E300")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		public static bool isLinuxEditor
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x163E308", Offset = "0x163E308", VA = "0x163E308")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000078")]
		public static bool isEditorMode
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x163F2B0", Offset = "0x163F2B0", VA = "0x163F2B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000079")]
		public static bool isIL2CPP
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x163F310", Offset = "0x163F310", VA = "0x163F310")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007A")]
		public static Platform CurrentPlatform
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x163F318", Offset = "0x163F318", VA = "0x163F318")]
			get
			{
				return default(Platform);
			}
		}

		[Token(Token = "0x1700007B")]
		public static string StreamingAssetsPath
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x163F3BC", Offset = "0x163F3BC", VA = "0x163F3BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x163F4A0", Offset = "0x163F4A0", VA = "0x163F4A0")]
		static BaseHelper()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x163F618", Offset = "0x163F618", VA = "0x163F618")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x751440", Offset = "0x751440")]
		private static void initialize()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x163F6A4", Offset = "0x163F6A4", VA = "0x163F6A4")]
		public static bool OpenURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x163F8B0", Offset = "0x163F8B0", VA = "0x163F8B0")]
		public static string CreateString(string replaceChars, int stringLength)
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x163FA48", Offset = "0x163FA48", VA = "0x163FA48")]
		public static bool hasActiveClip(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x163FB88", Offset = "0x163FB88", VA = "0x163FB88")]
		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x163E3B8", Offset = "0x163E3B8", VA = "0x163E3B8")]
		public static string ValidatePath(string path, bool addEndDelimiter = true)
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1640100", Offset = "0x1640100", VA = "0x1640100")]
		public static string ValidateFile(string path)
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1640444", Offset = "0x1640444", VA = "0x1640444")]
		public static bool PathHasInvalidChars(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x16404E0", Offset = "0x16404E0", VA = "0x16404E0")]
		public static bool FileHasInvalidChars(string file)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x164057C", Offset = "0x164057C", VA = "0x164057C")]
		public static string[] GetFiles(string path, bool isRecursive = false, params string[] extensions)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1640AA4", Offset = "0x1640AA4", VA = "0x1640AA4")]
		public static string[] GetDirectories(string path, bool isRecursive = false)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1640CBC", Offset = "0x1640CBC", VA = "0x1640CBC")]
		public static string[] GetDrives()
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1640E48", Offset = "0x1640E48", VA = "0x1640E48")]
		public static string ValidURLFromFilePath(string path)
		{
			return null;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1640FFC", Offset = "0x1640FFC", VA = "0x1640FFC")]
		public static string CleanUrl(string url, bool removeProtocol = true, bool removeWWW = true, bool removeSlash = true)
		{
			return null;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1641314", Offset = "0x1641314", VA = "0x1641314")]
		public static string ClearTags(string text)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x16413CC", Offset = "0x16413CC", VA = "0x16413CC")]
		public static string ClearSpaces(string text)
		{
			return null;
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x164147C", Offset = "0x164147C", VA = "0x164147C")]
		public static string ClearLineEndings(string text)
		{
			return null;
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1641534", Offset = "0x1641534", VA = "0x1641534")]
		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true, int skipHeaderLines = 0, int skipFooterLines = 0)
		{
			return null;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1641804", Offset = "0x1641804", VA = "0x1641804")]
		public static string FormatBytesToHRF(long bytes, bool useSI = true)
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1641AE0", Offset = "0x1641AE0", VA = "0x1641AE0")]
		public static string FormatSecondsToHourMinSec(double seconds)
		{
			return null;
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1641B48", Offset = "0x1641B48", VA = "0x1641B48")]
		public static string FormatSecondsToHRF(double seconds)
		{
			return null;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1641F9C", Offset = "0x1641F9C", VA = "0x1641F9C")]
		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x163F7A0", Offset = "0x163F7A0", VA = "0x163F7A0")]
		public static bool isValidURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x16420F0", Offset = "0x16420F0", VA = "0x16420F0")]
		public static void CopyPath(string sourcePath, string destPath, bool move = false)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1642664", Offset = "0x1642664", VA = "0x1642664")]
		public static void CopyFile(string sourceFile, string destFile, bool move = false)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x16429E0", Offset = "0x16429E0", VA = "0x16429E0")]
		public static void ShowPath(string path)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1642A38", Offset = "0x1642A38", VA = "0x1642A38")]
		public static void ShowFile(string file)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1642AF8", Offset = "0x1642AF8", VA = "0x1642AF8")]
		public static void OpenFile(string file)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1642BB8", Offset = "0x1642BB8", VA = "0x1642BB8")]
		public static string getIP(string host)
		{
			return null;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1642D68", Offset = "0x1642D68", VA = "0x1642D68")]
		public static string GenerateLoremIpsum(int length, int minSentences = 1, int maxSentences = int.MaxValue, int minWords = 1, int maxWords = 15)
		{
			return null;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1643698", Offset = "0x1643698", VA = "0x1643698")]
		public static string LanguageToISO639(SystemLanguage language)
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x16438CC", Offset = "0x16438CC", VA = "0x16438CC")]
		public static SystemLanguage ISO639ToLanguage(string isoCode)
		{
			return default(SystemLanguage);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1641F20", Offset = "0x1641F20", VA = "0x1641F20")]
		private static string addLeadingZero(int value)
		{
			return null;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x164247C", Offset = "0x164247C", VA = "0x164247C")]
		private static void copyAll(DirectoryInfo source, DirectoryInfo target)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x163F8A8", Offset = "0x163F8A8", VA = "0x163F8A8")]
		private static void openURL(string url)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1644438", Offset = "0x1644438", VA = "0x1644438")]
		protected BaseHelper()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class CTHelper : MonoBehaviour
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750AB0", Offset = "0x750AB0")]
		private static CTHelper <Instance>k__BackingField;

		[Token(Token = "0x1700007C")]
		public static CTHelper Instance
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x1644440", Offset = "0x1644440", VA = "0x1644440")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x751450", Offset = "0x751450")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x164448C", Offset = "0x164448C", VA = "0x164448C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x751460", Offset = "0x751460")]
			private set
			{
			}
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x16444DC", Offset = "0x16444DC", VA = "0x16444DC")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x751470", Offset = "0x751470")]
		private static void initialize()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1644544", Offset = "0x1644544", VA = "0x1644544")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x751484", Offset = "0x751484")]
		private static void create()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x164464C", Offset = "0x164464C", VA = "0x164464C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x164469C", Offset = "0x164469C", VA = "0x164469C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1644700", Offset = "0x1644700", VA = "0x1644700")]
		public CTHelper()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public abstract class CTPlayerPrefs
	{
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1644708", Offset = "0x1644708", VA = "0x1644708")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1644748", Offset = "0x1644748", VA = "0x1644748")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1644750", Offset = "0x1644750", VA = "0x1644750")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x16447C8", Offset = "0x16447C8", VA = "0x16447C8")]
		public static void Save()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x16447D0", Offset = "0x16447D0", VA = "0x16447D0")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1644848", Offset = "0x1644848", VA = "0x1644848")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x16448C0", Offset = "0x16448C0", VA = "0x16448C0")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1644938", Offset = "0x1644938", VA = "0x1644938")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x16449E8", Offset = "0x16449E8", VA = "0x16449E8")]
		public static DateTime GetDate(string key)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1644A94", Offset = "0x1644A94", VA = "0x1644A94")]
		public static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1644B74", Offset = "0x1644B74", VA = "0x1644B74")]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1644C74", Offset = "0x1644C74", VA = "0x1644C74")]
		public static Vector4 GetVector4(string key)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1644DBC", Offset = "0x1644DBC", VA = "0x1644DBC")]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1644E80", Offset = "0x1644E80", VA = "0x1644E80")]
		public static Color GetColor(string key)
		{
			return default(Color);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1644FA8", Offset = "0x1644FA8", VA = "0x1644FA8")]
		public static SystemLanguage GetLanguage(string key)
		{
			return default(SystemLanguage);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x16450B8", Offset = "0x16450B8", VA = "0x16450B8")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1645138", Offset = "0x1645138", VA = "0x1645138")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x16451C0", Offset = "0x16451C0", VA = "0x16451C0")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1645240", Offset = "0x1645240", VA = "0x1645240")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x16452B4", Offset = "0x16452B4", VA = "0x16452B4")]
		public static void SetDate(string key, DateTime value)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1645320", Offset = "0x1645320", VA = "0x1645320")]
		public static void SetVector2(string key, Vector2 value)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x16453D8", Offset = "0x16453D8", VA = "0x16453D8")]
		public static void SetVector3(string key, Vector3 value)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x16454BC", Offset = "0x16454BC", VA = "0x16454BC")]
		public static void SetVector4(string key, Vector4 value)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1645690", Offset = "0x1645690", VA = "0x1645690")]
		public static void SetQuaternion(string key, Quaternion value)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1645754", Offset = "0x1645754", VA = "0x1645754")]
		public static void SetColor(string key, Color value)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1645818", Offset = "0x1645818", VA = "0x1645818")]
		public static void SetLanguage(string key, SystemLanguage language)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x16458AC", Offset = "0x16458AC", VA = "0x16458AC")]
		protected CTPlayerPrefs()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class CTWebClient : WebClient
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750AC0", Offset = "0x750AC0")]
		private int <Timeout>k__BackingField;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750AD0", Offset = "0x750AD0")]
		private int <ConnectionLimit>k__BackingField;

		[Token(Token = "0x1700007D")]
		public int Timeout
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x1645B20", Offset = "0x1645B20", VA = "0x1645B20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x751494", Offset = "0x751494")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x1645B28", Offset = "0x1645B28", VA = "0x1645B28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7514A4", Offset = "0x7514A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public int ConnectionLimit
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x1645B30", Offset = "0x1645B30", VA = "0x1645B30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7514B4", Offset = "0x7514B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x1645B38", Offset = "0x1645B38", VA = "0x1645B38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7514C4", Offset = "0x7514C4")]
			set
			{
			}
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1645B40", Offset = "0x1645B40", VA = "0x1645B40")]
		public CTWebClient()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1645B70", Offset = "0x1645B70", VA = "0x1645B70")]
		public CTWebClient(int timeout, int connectionLimit = 20)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1645BA8", Offset = "0x1645BA8", VA = "0x1645BA8")]
		public WebRequest CTGetWebRequest(string uri)
		{
			return null;
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1645C20", Offset = "0x1645C20", VA = "0x1645C20", Slot = "9")]
		protected override WebRequest GetWebRequest(Uri uri)
		{
			return null;
		}
	}
	[Token(Token = "0x200002A")]
	public class MemoryCacheStream : Stream
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] cache;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long writePosition;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long readPosition;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private long length;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int size;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private readonly int maxSize;

		[Token(Token = "0x1700007F")]
		public override bool CanRead
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x1652DBC", Offset = "0x1652DBC", VA = "0x1652DBC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000080")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x1652DC4", Offset = "0x1652DC4", VA = "0x1652DC4", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000081")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x1652DCC", Offset = "0x1652DCC", VA = "0x1652DCC", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000082")]
		public override long Position
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x1652DD4", Offset = "0x1652DD4", VA = "0x1652DD4", Slot = "11")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x1652DDC", Offset = "0x1652DDC", VA = "0x1652DDC", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public override long Length
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x1652E50", Offset = "0x1652E50", VA = "0x1652E50", Slot = "10")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1652C78", Offset = "0x1652C78", VA = "0x1652C78")]
		public MemoryCacheStream(int cacheSize = 65536, int maxCacheSize = 67108864)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1652E58", Offset = "0x1652E58", VA = "0x1652E58", Slot = "18")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1652E5C", Offset = "0x1652E5C", VA = "0x1652E5C", Slot = "25")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x1652F58", Offset = "0x1652F58", VA = "0x1652F58", Slot = "26")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1652FA0", Offset = "0x1652FA0", VA = "0x1652FA0", Slot = "27")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1653160", Offset = "0x1653160", VA = "0x1653160", Slot = "29")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x16530A4", Offset = "0x16530A4", VA = "0x16530A4")]
		private int read(byte[] buff, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1653294", Offset = "0x1653294", VA = "0x1653294")]
		private void write(byte[] buff, int offset, int count)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1652D00", Offset = "0x1652D00", VA = "0x1652D00")]
		private void createCache()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[DisallowMultipleComponent]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x750AE0", Offset = "0x750AE0")]
		[SerializeField]
		private bool dontDestroy;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string PrefabPath;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string GameObjectName;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static T instance;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly object lockObj;

		[Token(Token = "0x17000084")]
		public static T Instance
		{
			[Token(Token = "0x600022F")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000230")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public bool DontDestroy
		{
			[Token(Token = "0x6000231")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000232")]
			set
			{
			}
		}

		[Token(Token = "0x6000233")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000234")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000235")]
		protected virtual void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000236")]
		public static void CreateInstance(bool searchExistingGameObject = true, bool deleteExistingInstance = false)
		{
		}

		[Token(Token = "0x6000237")]
		public static void DeleteInstance()
		{
		}

		[Token(Token = "0x6000238")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class SingletonHelper
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x750B2C", Offset = "0x750B2C")]
		private static bool <isQuitting>k__BackingField;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool isInitialized;

		[Token(Token = "0x17000086")]
		public static bool isQuitting
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x1654A3C", Offset = "0x1654A3C", VA = "0x1654A3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7514D4", Offset = "0x7514D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x1654AA0", Offset = "0x1654AA0", VA = "0x1654AA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7514E4", Offset = "0x7514E4")]
			set
			{
			}
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1654B0C", Offset = "0x1654B0C", VA = "0x1654B0C")]
		static SingletonHelper()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1654B10", Offset = "0x1654B10", VA = "0x1654B10")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x7514F4", Offset = "0x7514F4")]
		private static void initialize()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1654CEC", Offset = "0x1654CEC", VA = "0x1654CEC")]
		private static void onSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1654DC4", Offset = "0x1654DC4", VA = "0x1654DC4")]
		private static void onSceneUnloaded(Scene scene)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1654E9C", Offset = "0x1654E9C", VA = "0x1654E9C")]
		private static void onQuitting()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1654F3C", Offset = "0x1654F3C", VA = "0x1654F3C")]
		public SingletonHelper()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public abstract class XmlHelper
	{
		[Token(Token = "0x6000242")]
		public static void SerializeToFile<T>(T obj, string filename)
		{
		}

		[Token(Token = "0x6000243")]
		public static T DeserializeFromFile<T>(string filename, bool skipBOM = false)
		{
			return (T)null;
		}

		[Token(Token = "0x6000244")]
		public static string SerializeToString<T>(T obj)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		public static T DeserializeFromString<T>(string xmlAsString, bool skipBOM = true)
		{
			return (T)null;
		}

		[Token(Token = "0x6000246")]
		public static T DeserializeFromResource<T>(string resourceName, bool skipBOM = true)
		{
			return (T)null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1655DD0", Offset = "0x1655DD0", VA = "0x1655DD0")]
		protected XmlHelper()
		{
		}
	}
}
