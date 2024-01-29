using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;
using Il2CppDummyDll;
using KunstStoff.ServiceLoader;
using KunstStoff.Services;
using KunstStoff.Utility;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SocialPlatforms;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class DictionaryExtensions
{
	[Token(Token = "0x6000001")]
	public static void AddOrSet<TKey, TValue>(this Dictionary<TKey, TValue> thisList, TKey key, TValue value)
	{
	}

	[Token(Token = "0x6000002")]
	public static void CopyAll<Tkey, TValue>(this Dictionary<Tkey, TValue> thisDict, Dictionary<Tkey, TValue> otherDict)
	{
	}

	[Token(Token = "0x6000003")]
	public static TValue GetValueOrNull<Tkey, TValue>(this Dictionary<Tkey, TValue> thisDict, Tkey value) where TValue : class
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
public static class GameObjectExtensions
{
	[Token(Token = "0x6000004")]
	public static bool HasComponent<T>(this GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	public static T AddOrGetComponent<T>(this GameObject gameObject) where T : Component
	{
		return null;
	}
}
[Token(Token = "0x2000004")]
public static class GameObjectMenuExtension
{
}
[Token(Token = "0x2000005")]
public static class ListExtensions
{
	[Token(Token = "0x6000006")]
	public static bool ContainsNull<T>(this List<T> thisList)
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	public static void QuickSort<T>(this T[] array, Func<T, T, int> comparer)
	{
	}

	[Token(Token = "0x6000008")]
	private static void QuickSort<T>(T[] array, int startIndex, int endIndex, Func<T, T, int> comparer)
	{
	}

	[Token(Token = "0x6000009")]
	public static void QuickSort<T>(this IList<T> array, Func<T, T, int> comparer)
	{
	}

	[Token(Token = "0x600000A")]
	private static void QuickSort<T>(IList<T> array, int startIndex, int endIndex, Func<T, T, int> comparer)
	{
	}

	[Token(Token = "0x600000B")]
	public static void Fill<T>(this List<T> thisList, T with)
	{
	}

	[Token(Token = "0x600000C")]
	public static void FillCapacity<T>(this List<T> thisList) where T : new()
	{
	}

	[Token(Token = "0x600000D")]
	public static void Resize<T>(this List<T> list, int sz, T c)
	{
	}

	[Token(Token = "0x600000E")]
	public static void Resize<T>(this List<T> list, int sz) where T : new()
	{
	}

	[Token(Token = "0x600000F")]
	private static void SwapUnchecked<T>(this IList<T> list, int firstIndex, int secondIndex)
	{
	}

	[Token(Token = "0x6000010")]
	public static void Swap<T>(this IList<T> list, int firstIndex, int secondIndex)
	{
	}
}
[Token(Token = "0x2000006")]
public static class MatrixExtensions
{
	[Token(Token = "0x6000011")]
	public static void CopyTo<T>(this T[,] thisMatrix, T[,] toMatrix)
	{
	}
}
[Token(Token = "0x2000007")]
public static class RectExtensions
{
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x23A09DC", Offset = "0x23A09DC", VA = "0x23A09DC")]
	public static Rect Encapsulate(this Rect rect, Vector2 point)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x23A0A7C", Offset = "0x23A0A7C", VA = "0x23A0A7C")]
	public static Rect Encapsulate(this Rect rect, ref Rect other)
	{
		return default(Rect);
	}
}
[Token(Token = "0x2000008")]
public static class VectorExtensions
{
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x23A4168", Offset = "0x23A4168", VA = "0x23A4168")]
	public static Vector2 XY(this Vector3 v3)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x23A416C", Offset = "0x23A416C", VA = "0x23A416C")]
	public static Vector2 XZ(this Vector3 v3)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x23A4174", Offset = "0x23A4174", VA = "0x23A4174")]
	public static Vector2 YZ(this Vector3 v3)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x23A4180", Offset = "0x23A4180", VA = "0x23A4180")]
	public static Vector2 YX(this Vector3 v3)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x23A4190", Offset = "0x23A4190", VA = "0x23A4190")]
	public static Vector2 ZX(this Vector3 v3)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x23A419C", Offset = "0x23A419C", VA = "0x23A419C")]
	public static Vector2 ZY(this Vector3 v3)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x23A41A4", Offset = "0x23A41A4", VA = "0x23A41A4")]
	public static Vector2 Lerp(Vector2 a, Vector2 b, Vector2 t)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x23A4200", Offset = "0x23A4200", VA = "0x23A4200")]
	public static Vector3 XZY(this Vector3 v3)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x23A4210", Offset = "0x23A4210", VA = "0x23A4210")]
	public static Vector3 YXZ(this Vector3 v3)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x23A4220", Offset = "0x23A4220", VA = "0x23A4220")]
	public static Vector3 ZXY(this Vector3 v3)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x23A4234", Offset = "0x23A4234", VA = "0x23A4234")]
	public static Vector3 YZX(this Vector3 v3)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x23A4248", Offset = "0x23A4248", VA = "0x23A4248")]
	public static Vector3 ZYX(this Vector3 v3)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x23A4258", Offset = "0x23A4258", VA = "0x23A4258")]
	public static float SqrDistance(this Vector3 v3_this, ref Vector3 v3)
	{
		return default(float);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x23A4284", Offset = "0x23A4284", VA = "0x23A4284")]
	public static float SqrDistance(this Vector3 v3_this, Vector3 v3)
	{
		return default(float);
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x23A42A8", Offset = "0x23A42A8", VA = "0x23A42A8")]
	public static bool IsWellDefined(this Vector3 v)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000009")]
public static class Preprocessor
{
	[Token(Token = "0x4000001")]
	public const bool MAP_CHEATS = false;

	[Token(Token = "0x4000002")]
	public const bool MAP_PROFILE = false;

	[Token(Token = "0x4000003")]
	public const bool MAP_RELEASE_STORE_PUBLIC = true;

	[Token(Token = "0x4000004")]
	public const bool MAP_RELEASE_STORE_TEST = false;

	[Token(Token = "0x4000005")]
	public const bool MAP_STEAM = false;
}
namespace KunstStoff
{
	[Token(Token = "0x200000A")]
	public static class Dbg
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2396614", Offset = "0x2396614", VA = "0x2396614")]
		public static string Prefix(string message, [Optional] string channel)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2396B9C", Offset = "0x2396B9C", VA = "0x2396B9C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65664", Offset = "0xA65664")]
		public static void Assert(bool condition)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2396BA0", Offset = "0x2396BA0", VA = "0x2396BA0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA6569C", Offset = "0xA6569C")]
		public static void Assert(bool condition, string message)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2396BA4", Offset = "0x2396BA4", VA = "0x2396BA4")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA656D4", Offset = "0xA656D4")]
		public static void Assert(bool condition, object message)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2396BA8", Offset = "0x2396BA8", VA = "0x2396BA8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA6570C", Offset = "0xA6570C")]
		public static void Assert(bool condition, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2396BAC", Offset = "0x2396BAC", VA = "0x2396BAC")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65744", Offset = "0xA65744")]
		public static void Assert(bool condition, object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2396BB0", Offset = "0x2396BB0", VA = "0x2396BB0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA6577C", Offset = "0xA6577C")]
		public static void Assert(bool condition, string message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2396BB4", Offset = "0x2396BB4", VA = "0x2396BB4")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA657B4", Offset = "0xA657B4")]
		public static void AssertWarning(bool condition, object message)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2396C38", Offset = "0x2396C38", VA = "0x2396C38")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA657EC", Offset = "0xA657EC")]
		public static void AssertWarning(bool condition, object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2396CC4", Offset = "0x2396CC4", VA = "0x2396CC4")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65824", Offset = "0xA65824")]
		public static void AssertFormat(bool condition, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2396CC8", Offset = "0x2396CC8", VA = "0x2396CC8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA6585C", Offset = "0xA6585C")]
		public static void AssertFormat(bool condition, string format, params object[] args)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2396CCC", Offset = "0x2396CCC", VA = "0x2396CCC")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65894", Offset = "0xA65894")]
		public static void AssertFormatWarning(bool condition, UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2396D6C", Offset = "0x2396D6C", VA = "0x2396D6C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA658CC", Offset = "0xA658CC")]
		public static void AssertFormatWarning(bool condition, string format, params object[] args)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2396DF8", Offset = "0x2396DF8", VA = "0x2396DF8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65904", Offset = "0xA65904")]
		public static void Log(object message, [Optional] string channel)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2396E90", Offset = "0x2396E90", VA = "0x2396E90")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA6593C", Offset = "0xA6593C")]
		public static void Log(object message, UnityEngine.Object context, [Optional] string channel)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2396F30", Offset = "0x2396F30", VA = "0x2396F30")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65974", Offset = "0xA65974")]
		public static void LogAssertion(object message, [Optional] string channel)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2396F34", Offset = "0x2396F34", VA = "0x2396F34")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA659AC", Offset = "0xA659AC")]
		public static void LogAssertion(object message, UnityEngine.Object context, [Optional] string channel)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2396F38", Offset = "0x2396F38", VA = "0x2396F38")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA659E4", Offset = "0xA659E4")]
		public static void LogAssertionFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2396F3C", Offset = "0x2396F3C", VA = "0x2396F3C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65A1C", Offset = "0xA65A1C")]
		public static void LogAssertionFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2396F40", Offset = "0x2396F40", VA = "0x2396F40")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65A54", Offset = "0xA65A54")]
		public static void LogFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2396FC8", Offset = "0x2396FC8", VA = "0x2396FC8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65A8C", Offset = "0xA65A8C")]
		public static void LogFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2397058", Offset = "0x2397058", VA = "0x2397058")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65AC4", Offset = "0xA65AC4")]
		public static void LogWarning(object message, [Optional] string channel)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x23970F0", Offset = "0x23970F0", VA = "0x23970F0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65AFC", Offset = "0xA65AFC")]
		public static void LogWarning(object message, UnityEngine.Object context, [Optional] string channel)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2397190", Offset = "0x2397190", VA = "0x2397190")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65B34", Offset = "0xA65B34")]
		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2397218", Offset = "0x2397218", VA = "0x2397218")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65B6C", Offset = "0xA65B6C")]
		public static void LogWarningFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x23972A8", Offset = "0x23972A8", VA = "0x23972A8")]
		public static void LogError(object message, [Optional] string channel)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2397340", Offset = "0x2397340", VA = "0x2397340")]
		public static void LogError(object message, UnityEngine.Object context, [Optional] string channel)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x23973E0", Offset = "0x23973E0", VA = "0x23973E0")]
		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2397468", Offset = "0x2397468", VA = "0x2397468")]
		public static void LogErrorFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class Performance
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Stopwatch watch;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string resultHeader;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<double> resultTimes;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<string> resultDesc;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool resultTotalFirst;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static string DISABLED;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static bool inUse;

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x239FA54", Offset = "0x239FA54", VA = "0x239FA54")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65BA4", Offset = "0xA65BA4")]
		public static void Init()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x239FBD0", Offset = "0x239FBD0", VA = "0x239FBD0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65BDC", Offset = "0xA65BDC")]
		private void StartHelper()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x239FC3C", Offset = "0x239FC3C", VA = "0x239FC3C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65C14", Offset = "0xA65C14")]
		public void Start(string desc, bool totalFirst = false, string header = "")
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x239FCD8", Offset = "0x239FCD8", VA = "0x239FCD8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65C4C", Offset = "0xA65C4C")]
		public void Step(string desc)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x239FDBC", Offset = "0x239FDBC", VA = "0x239FDBC")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65C84", Offset = "0xA65C84")]
		public void Stop(string dummy)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x239FDD8", Offset = "0x239FDD8", VA = "0x239FDD8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65CBC", Offset = "0xA65CBC")]
		private void StopHelper()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x23A0188", Offset = "0x23A0188", VA = "0x23A0188")]
		private void AddSteps(StringBuilder sb)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x23A004C", Offset = "0x23A004C", VA = "0x23A004C")]
		private void AddTotal(StringBuilder sb, double timeTotal)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x23A03E8", Offset = "0x23A03E8", VA = "0x23A03E8")]
		public static void CleanUp()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x23A0464", Offset = "0x23A0464", VA = "0x23A0464")]
		public static double Profile(string description, Action func, double warnDuration = 0.0, int iterations = 1, bool warmup = false)
		{
			return default(double);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x239FA9C", Offset = "0x239FA9C", VA = "0x239FA9C")]
		public Performance()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public interface IFileSystem
	{
		[Token(Token = "0x600004C")]
		IFileSystem Init();

		[Token(Token = "0x600004D")]
		void Done();

		[Token(Token = "0x600004E")]
		bool getLastError();

		[Token(Token = "0x600004F")]
		string BuildPath(string basePath, string pathToFile, string fileName);

		[Token(Token = "0x6000050")]
		bool FileExists(string filename);

		[Token(Token = "0x6000051")]
		string ReadFile(string filename);

		[Token(Token = "0x6000052")]
		void WriteFile(string filename, string data);

		[Token(Token = "0x6000053")]
		void CreatePath(string filename);

		[Token(Token = "0x6000054")]
		void DeleteFile(string filename);
	}
	[Token(Token = "0x200000D")]
	public static class IOUtils
	{
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] invalidFilenameChars;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly char[] invalidPathChars;

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x239E32C", Offset = "0x239E32C", VA = "0x239E32C")]
		static IOUtils()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x239E410", Offset = "0x239E410", VA = "0x239E410")]
		public static string SanitizeFilename(string input, char errorChar)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x239E5B8", Offset = "0x239E5B8", VA = "0x239E5B8")]
		public static string SanitizePath(string input, char errorChar)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x239E48C", Offset = "0x239E48C", VA = "0x239E48C")]
		private static string Sanitize(string input, char[] invalidChars, char errorChar)
		{
			return null;
		}
	}
	[Token(Token = "0x200000E")]
	public class NullFileSystem : IFileSystem
	{
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string Prefix;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x239D310", Offset = "0x239D310", VA = "0x239D310")]
		public NullFileSystem()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x239F6AC", Offset = "0x239F6AC", VA = "0x239F6AC", Slot = "4")]
		public IFileSystem Init()
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x239F6B0", Offset = "0x239F6B0", VA = "0x239F6B0", Slot = "5")]
		public void Done()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x239F6B4", Offset = "0x239F6B4", VA = "0x239F6B4", Slot = "6")]
		public bool getLastError()
		{
			return default(bool);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x239F6BC", Offset = "0x239F6BC", VA = "0x239F6BC", Slot = "7")]
		public string BuildPath(string basePath, string pathToFile, string fileName)
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x239F774", Offset = "0x239F774", VA = "0x239F774", Slot = "8")]
		public bool FileExists(string filename)
		{
			return default(bool);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x239F77C", Offset = "0x239F77C", VA = "0x239F77C", Slot = "9")]
		public string ReadFile(string filename)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x239F7C0", Offset = "0x239F7C0", VA = "0x239F7C0", Slot = "10")]
		public void WriteFile(string filename, string data)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x239F7C4", Offset = "0x239F7C4", VA = "0x239F7C4", Slot = "11")]
		public void CreatePath(string filename)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x239F7C8", Offset = "0x239F7C8", VA = "0x239F7C8", Slot = "12")]
		public void DeleteFile(string filename)
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class P31PrefsFS : IFileSystem
	{
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string Prefix;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool error;

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x239F830", Offset = "0x239F830", VA = "0x239F830")]
		public P31PrefsFS()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x239F838", Offset = "0x239F838", VA = "0x239F838", Slot = "6")]
		public bool getLastError()
		{
			return default(bool);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x239F840", Offset = "0x239F840", VA = "0x239F840", Slot = "4")]
		public IFileSystem Init()
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x239F844", Offset = "0x239F844", VA = "0x239F844", Slot = "5")]
		public void Done()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x239F848", Offset = "0x239F848", VA = "0x239F848", Slot = "7")]
		public string BuildPath(string basePath, string pathToFile, string fileName)
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x239F900", Offset = "0x239F900", VA = "0x239F900", Slot = "8")]
		public bool FileExists(string filename)
		{
			return default(bool);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x239F910", Offset = "0x239F910", VA = "0x239F910", Slot = "9")]
		public string ReadFile(string filename)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x239F998", Offset = "0x239F998", VA = "0x239F998", Slot = "10")]
		public void WriteFile(string filename, string data)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x239F9E8", Offset = "0x239F9E8", VA = "0x239F9E8", Slot = "11")]
		public void CreatePath(string filename)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x239F9D8", Offset = "0x239F9D8", VA = "0x239F9D8", Slot = "12")]
		public void DeleteFile(string filename)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class PlayerPrefsFileSystem : IFileSystem
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string Prefix;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool error;

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x239D308", Offset = "0x239D308", VA = "0x239D308")]
		public PlayerPrefsFileSystem()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x23A04F0", Offset = "0x23A04F0", VA = "0x23A04F0", Slot = "6")]
		public bool getLastError()
		{
			return default(bool);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x23A04F8", Offset = "0x23A04F8", VA = "0x23A04F8", Slot = "4")]
		public IFileSystem Init()
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x23A04FC", Offset = "0x23A04FC", VA = "0x23A04FC", Slot = "5")]
		public void Done()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x23A0500", Offset = "0x23A0500", VA = "0x23A0500", Slot = "7")]
		public string BuildPath(string basePath, string pathToFile, string fileName)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x23A05B8", Offset = "0x23A05B8", VA = "0x23A05B8", Slot = "8")]
		public bool FileExists(string filename)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x23A05C8", Offset = "0x23A05C8", VA = "0x23A05C8", Slot = "9")]
		public string ReadFile(string filename)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x23A0650", Offset = "0x23A0650", VA = "0x23A0650", Slot = "10")]
		public void WriteFile(string filename, string data)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x23A06A0", Offset = "0x23A06A0", VA = "0x23A06A0", Slot = "11")]
		public void CreatePath(string filename)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x23A0690", Offset = "0x23A0690", VA = "0x23A0690", Slot = "12")]
		public void DeleteFile(string filename)
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class StreamFileSystem : IFileSystem
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Encoding _encoding;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool error;

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x239D2D4", Offset = "0x239D2D4", VA = "0x239D2D4")]
		public StreamFileSystem(Encoding encoding)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x23A3780", Offset = "0x23A3780", VA = "0x23A3780", Slot = "4")]
		public IFileSystem Init()
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x23A3788", Offset = "0x23A3788", VA = "0x23A3788", Slot = "5")]
		public void Done()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x23A378C", Offset = "0x23A378C", VA = "0x23A378C", Slot = "6")]
		public bool getLastError()
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x23A3794", Offset = "0x23A3794", VA = "0x23A3794", Slot = "7")]
		public string BuildPath(string basePath, string pathToFile, string fileName)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x23A3810", Offset = "0x23A3810", VA = "0x23A3810", Slot = "8")]
		public bool FileExists(string filename)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x23A3820", Offset = "0x23A3820", VA = "0x23A3820", Slot = "9")]
		public string ReadFile(string filename)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x23A3A84", Offset = "0x23A3A84", VA = "0x23A3A84", Slot = "10")]
		public void WriteFile(string filename, string data)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x23A3CC8", Offset = "0x23A3CC8", VA = "0x23A3CC8", Slot = "11")]
		public void CreatePath(string filename)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x23A3DF0", Offset = "0x23A3DF0", VA = "0x23A3DF0", Slot = "12")]
		public void DeleteFile(string filename)
		{
		}
	}
	[Token(Token = "0x2000012")]
	public static class GameCenterAdapter
	{
		[Token(Token = "0x17000001")]
		public static string ReportProgressResult
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x239E178", Offset = "0x239E178", VA = "0x239E178")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public static bool IsUserAuthenticated
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x239E1BC", Offset = "0x239E1BC", VA = "0x239E1BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000003")]
		public static string UserID
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x239E1C4", Offset = "0x239E1C4", VA = "0x239E1C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public static string UserName
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x239E208", Offset = "0x239E208", VA = "0x239E208")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x239E24C", Offset = "0x239E24C", VA = "0x239E24C")]
		public static void ShowAchievementsUI()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x239E250", Offset = "0x239E250", VA = "0x239E250")]
		public static void Authenticate(Action<bool, string> callback)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x239E254", Offset = "0x239E254", VA = "0x239E254")]
		public static void ReportAchievementProgress(string achievementID, float achievementProgress, Action<bool> callback)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x239E258", Offset = "0x239E258", VA = "0x239E258")]
		public static void ResetAllAchievements(Action<bool> callback)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x239E25C", Offset = "0x239E25C", VA = "0x239E25C")]
		public static void LoadAchievements(Action<IAchievement[]> callback)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x239E260", Offset = "0x239E260", VA = "0x239E260")]
		public static void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000013")]
	public class GrassSystemQuality
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float particleGrassDensityPerChunk;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float fadeStart;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float faseLength;

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x239E31C", Offset = "0x239E31C", VA = "0x239E31C")]
		public GrassSystemQuality()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class TestPerformance : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000015")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA64E1C", Offset = "0xA64E1C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action <>9__0_0;

			[Token(Token = "0x6000092")]
			[Address(RVA = "0x23A54DC", Offset = "0x23A54DC", VA = "0x23A54DC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000093")]
			[Address(RVA = "0x23A54E4", Offset = "0x23A54E4", VA = "0x23A54E4")]
			internal void <Start>b__0_0()
			{
			}
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x23A3F50", Offset = "0x23A3F50", VA = "0x23A3F50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x23A408C", Offset = "0x23A408C", VA = "0x23A408C")]
		public TestPerformance()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public static class SystemActionExtensions
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x23A3F0C", Offset = "0x23A3F0C", VA = "0x23A3F0C")]
		public static void InvokeAndConsume(this Action invokable, ref Action action)
		{
		}

		[Token(Token = "0x6000095")]
		public static void InvokeAndConsume<T>(this Action<T> invokable, ref Action<T> action, T parameter)
		{
		}

		[Token(Token = "0x6000096")]
		public static void InvokeAndConsume<T1, T2>(this Action<T1, T2> invokable, ref Action<T1, T2> action, T1 parameter1, T2 parameter2)
		{
		}
	}
}
namespace KunstStoff.Utility
{
	[Token(Token = "0x2000017")]
	public static class DeviceScreenUtility
	{
		[Token(Token = "0x2000018")]
		public enum DeviceScreenScale
		{
			[Token(Token = "0x400001D")]
			TV2,
			[Token(Token = "0x400001E")]
			TV1,
			[Token(Token = "0x400001F")]
			TV,
			[Token(Token = "0x4000020")]
			PC,
			[Token(Token = "0x4000021")]
			Notebook,
			[Token(Token = "0x4000022")]
			Tablet,
			[Token(Token = "0x4000023")]
			Phablet,
			[Token(Token = "0x4000024")]
			Phone
		}

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int defaultDPI;

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x239CC9C", Offset = "0x239CC9C", VA = "0x239CC9C")]
		public static Vector2 GetDeviceScreenSize()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x239CCD0", Offset = "0x239CCD0", VA = "0x239CCD0")]
		public static float GetDeviceScreenAspectRatio()
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x239CD48", Offset = "0x239CD48", VA = "0x239CD48")]
		public static int GetDeviceScreenDiagonal()
		{
			return default(int);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x239CE28", Offset = "0x239CE28", VA = "0x239CE28")]
		public static DeviceScreenScale GetDeviceScreenScale()
		{
			return default(DeviceScreenScale);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x239CEFC", Offset = "0x239CEFC", VA = "0x239CEFC")]
		public static int GetResolutionIdxOffset()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public class StringEvent : UnityEvent<string>
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x23A3EC0", Offset = "0x23A3EC0", VA = "0x23A3EC0")]
		public StringEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001A")]
	public class BoolEvent : UnityEvent<bool>
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2396104", Offset = "0x2396104", VA = "0x2396104")]
		public BoolEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001B")]
	public class IntEvent : UnityEvent<int>
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x239EDC4", Offset = "0x239EDC4", VA = "0x239EDC4")]
		public IntEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001C")]
	public class FloatEvent : UnityEvent<float>
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x239E12C", Offset = "0x239E12C", VA = "0x239E12C")]
		public FloatEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	public class Vector2Event : UnityEvent<Vector2>
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x23A40D0", Offset = "0x23A40D0", VA = "0x23A40D0")]
		public Vector2Event()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001E")]
	public class Vector3Event : UnityEvent<Vector3>
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x23A411C", Offset = "0x23A411C", VA = "0x23A411C")]
		public Vector3Event()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class WaitForEvent : CustomYieldInstruction
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int lastEvent;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int curEvent;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int eventCount;

		[Token(Token = "0x17000005")]
		public int EventCount
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x23A433C", Offset = "0x23A433C", VA = "0x23A433C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000006")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x23A4344", Offset = "0x23A4344", VA = "0x23A4344", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x23A4360", Offset = "0x23A4360", VA = "0x23A4360")]
		public void EventHandler()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x23A4370", Offset = "0x23A4370", VA = "0x23A4370")]
		public void Clear()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x23A437C", Offset = "0x23A437C", VA = "0x23A437C")]
		public WaitForEvent Yield()
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x23A43A8", Offset = "0x23A43A8", VA = "0x23A43A8")]
		public WaitForEvent()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class WaitForUnityEvent : WaitForEvent
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UnityEvent triggerEvent;

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x23A43B0", Offset = "0x23A43B0", VA = "0x23A43B0")]
		public WaitForUnityEvent()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x23A43B8", Offset = "0x23A43B8", VA = "0x23A43B8")]
		public WaitForUnityEvent(UnityEvent triggerEvent)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x23A43E8", Offset = "0x23A43E8", VA = "0x23A43E8")]
		public void Attach(UnityEvent triggerEvent)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x23A44A0", Offset = "0x23A44A0", VA = "0x23A44A0")]
		public new void Clear()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x23A4550", Offset = "0x23A4550", VA = "0x23A4550")]
		public new WaitForUnityEvent Yield()
		{
			return null;
		}
	}
	[Token(Token = "0x2000021")]
	public class AutoDisable : MonoBehaviour
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool onAwake;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool onStart;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[SerializeField]
		private bool onEnable;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[SerializeField]
		private bool onDisable;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2395A14", Offset = "0x2395A14", VA = "0x2395A14")]
		protected void Awake()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2395A4C", Offset = "0x2395A4C", VA = "0x2395A4C")]
		protected void Start()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2395A5C", Offset = "0x2395A5C", VA = "0x2395A5C")]
		protected void Enable()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2395A6C", Offset = "0x2395A6C", VA = "0x2395A6C")]
		protected void Disable()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2395A24", Offset = "0x2395A24", VA = "0x2395A24")]
		public void Check()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2395A7C", Offset = "0x2395A7C", VA = "0x2395A7C")]
		public AutoDisable()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T instance;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string notInstanciatedErrorMessage;

		[Token(Token = "0x17000007")]
		public static T Instance
		{
			[Token(Token = "0x60000B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		public static bool IsInstantiated
		{
			[Token(Token = "0x60000B5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000B6")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000B7")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000B8")]
		public SingletonMono()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public struct TryOp
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _didSucceed;

		[Token(Token = "0x17000009")]
		public bool Failed
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x23A4094", Offset = "0x23A4094", VA = "0x23A4094")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		public bool Succeeded
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x23A40A4", Offset = "0x23A40A4", VA = "0x23A40A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public static TryOp Failure
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x23A40B8", Offset = "0x23A40B8", VA = "0x23A40B8")]
			get
			{
				return default(TryOp);
			}
		}

		[Token(Token = "0x1700000C")]
		public static TryOp Success
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x23A40C0", Offset = "0x23A40C0", VA = "0x23A40C0")]
			get
			{
				return default(TryOp);
			}
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x23A40AC", Offset = "0x23A40AC", VA = "0x23A40AC")]
		private TryOp(bool success)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x23A40C8", Offset = "0x23A40C8", VA = "0x23A40C8")]
		public static TryOp FromBool(bool result)
		{
			return default(TryOp);
		}
	}
}
namespace KunstStoff.UI
{
	[Token(Token = "0x2000024")]
	public static class RectTransformUtility
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3[] rectCorners;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x23A0B58", Offset = "0x23A0B58", VA = "0x23A0B58")]
		public static Rect RectTransformToWorldRect(RectTransform rectTransform)
		{
			return default(Rect);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x23A0C30", Offset = "0x23A0C30", VA = "0x23A0C30")]
		public static Rect RectTransformToLocalRect(RectTransform rectTransform)
		{
			return default(Rect);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x23A0D08", Offset = "0x23A0D08", VA = "0x23A0D08")]
		public static Rect RectTransformToRelativeRect(RectTransform childTransform, RectTransform parentTransform)
		{
			return default(Rect);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x23A0E3C", Offset = "0x23A0E3C", VA = "0x23A0E3C")]
		public static float GetScaleToFitRectTransform(RectTransform srcTransform, RectTransform dstTransform)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA64E3C", Offset = "0xA64E3C")]
	public class FadeAlpha : MonoBehaviour
	{
		[Token(Token = "0x2000026")]
		public delegate void OnPostFadeFunc();

		[Token(Token = "0x2000027")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA64E9C", Offset = "0xA64E9C")]
		private sealed class <FadeInCoroutine>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FadeAlpha <>4__this;

			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool animateFromCurve;

			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float fadeSeconds;

			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public OnPostFadeFunc postEvent;

			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool <backupInteractable>5__2;

			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <timeProgress>5__3;

			[Token(Token = "0x1700000D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000D7")]
				[Address(RVA = "0x23A4AF8", Offset = "0x23A4AF8", VA = "0x23A4AF8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000D9")]
				[Address(RVA = "0x23A4B40", Offset = "0x23A4B40", VA = "0x23A4B40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x239E070", Offset = "0x239E070", VA = "0x239E070")]
			[DebuggerHidden]
			public <FadeInCoroutine>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x23A48F0", Offset = "0x23A48F0", VA = "0x23A48F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x23A48F4", Offset = "0x23A48F4", VA = "0x23A48F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x23A4B00", Offset = "0x23A4B00", VA = "0x23A4B00", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000028")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA64EAC", Offset = "0xA64EAC")]
		private sealed class <FadeOutCoroutine>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FadeAlpha <>4__this;

			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool animateFromCurve;

			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float fadeSeconds;

			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public OnPostFadeFunc postEvent;

			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool <backupInteractable>5__2;

			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <timeProgress>5__3;

			[Token(Token = "0x1700000F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000DD")]
				[Address(RVA = "0x23A4D7C", Offset = "0x23A4D7C", VA = "0x23A4D7C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000010")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000DF")]
				[Address(RVA = "0x23A4DC4", Offset = "0x23A4DC4", VA = "0x23A4DC4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x239E09C", Offset = "0x239E09C", VA = "0x239E09C")]
			[DebuggerHidden]
			public <FadeOutCoroutine>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x23A4B48", Offset = "0x23A4B48", VA = "0x23A4B48", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x23A4B4C", Offset = "0x23A4B4C", VA = "0x23A4B4C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x23A4D84", Offset = "0x23A4D84", VA = "0x23A4D84", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float defaultFadeSeconds;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool hookActivationChange;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool disableInteraction;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CanvasGroup canvasGroup;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool supressAuto;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Coroutine fadeInCoroutine;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Coroutine fadeOutCoroutine;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve animationCurve;

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x239D824", Offset = "0x239D824", VA = "0x239D824")]
		public void Awake()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x239D880", Offset = "0x239D880", VA = "0x239D880")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x239D9C4", Offset = "0x239D9C4", VA = "0x239D9C4")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x239D8F4", Offset = "0x239D8F4", VA = "0x239D8F4")]
		public void FadeIn(OnPostFadeFunc postEvent)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x239DAE4", Offset = "0x239DAE4", VA = "0x239DAE4")]
		public void FadeIn(OnPostFadeFunc postEvent, float fadeSeconds, bool animateFromCurve = false)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x239DE3C", Offset = "0x239DE3C", VA = "0x239DE3C")]
		public void FadeOut(OnPostFadeFunc postEvent)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x239DF70", Offset = "0x239DF70", VA = "0x239DF70")]
		public void FadeOut(OnPostFadeFunc postEvent, float fadeSeconds, bool animateFromCurve = false)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x239DA34", Offset = "0x239DA34", VA = "0x239DA34")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA65D24", Offset = "0xA65D24")]
		private IEnumerator FadeInCoroutine(OnPostFadeFunc postEvent, float fadeSeconds, bool animateFromCurve = false)
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x239DEC0", Offset = "0x239DEC0", VA = "0x239DEC0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA65D84", Offset = "0xA65D84")]
		private IEnumerator FadeOutCoroutine(OnPostFadeFunc postEvent, float fadeSeconds, bool animateFromCurve = false)
		{
			return null;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x239E0C8", Offset = "0x239E0C8", VA = "0x239E0C8")]
		private void FadeOutDeferred()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x239E114", Offset = "0x239E114", VA = "0x239E114")]
		public FadeAlpha()
		{
		}
	}
}
namespace KunstStoff.Sound
{
	[Token(Token = "0x2000029")]
	public class SoundService : AbstractNeedInitService, INeedInitService, IService
	{
		[Token(Token = "0x17000011")]
		public override string Name
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x23A3670", Offset = "0x23A3670", VA = "0x23A3670", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x23A36B4", Offset = "0x23A36B4", VA = "0x23A36B4", Slot = "10")]
		public override void InitService()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x23A3710", Offset = "0x23A3710", VA = "0x23A3710", Slot = "14")]
		public override void AfterAllInitialized()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x23A3714", Offset = "0x23A3714", VA = "0x23A3714", Slot = "11")]
		public override void Close()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x23A3778", Offset = "0x23A3778", VA = "0x23A3778")]
		public SoundService()
		{
		}
	}
}
namespace KunstStoff.Services
{
	[Token(Token = "0x200002A")]
	public class ServiceLocator : SingletonMono<ServiceLocator>, IServiceLocator
	{
		[Serializable]
		[Token(Token = "0x200002B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA64EBC", Offset = "0xA64EBC")]
		private sealed class <>c__8<T> where T : IService
		{
			[Token(Token = "0x400004E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__8<T> <>9;

			[Token(Token = "0x400004F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Predicate<IService> <>9__8_0;

			[Token(Token = "0x60000F4")]
			public <>c__8()
			{
			}

			[Token(Token = "0x60000F5")]
			internal bool <GetServiceIndex>b__8_0(IService service)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA64ECC", Offset = "0xA64ECC")]
		private sealed class <>c__DisplayClass12_0<T> where T : class, IService
		{
			[Token(Token = "0x4000050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> callback;

			[Token(Token = "0x60000F6")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60000F7")]
			internal void <RequestCallbackOnRegisterService>b__0(IService registeredService)
			{
			}
		}

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<IService> services;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<Type, IService> typeServiceDict;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ServiceLocator instance;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string exceptionMsg;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<Type, List<Action<IService>>> callbackRequests;

		[Token(Token = "0x60000E5")]
		public bool HasServiceRegistered<T>() where T : IService
		{
			return default(bool);
		}

		[Token(Token = "0x60000E6")]
		public T GetService<T>(bool throwError = false) where T : IService
		{
			return (T)null;
		}

		[Token(Token = "0x60000E7")]
		public T GetService<T>(int serviceIndex, bool throwError = false) where T : IService
		{
			return (T)null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x23A0FA8", Offset = "0x23A0FA8", VA = "0x23A0FA8", Slot = "9")]
		public int GetServiceIndex(IService service)
		{
			return default(int);
		}

		[Token(Token = "0x60000E9")]
		public int GetServiceIndex<T>() where T : IService
		{
			return default(int);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x239EC24", Offset = "0x239EC24", VA = "0x239EC24", Slot = "7")]
		public int Register(IService service)
		{
			return default(int);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x23A120C", Offset = "0x23A120C", VA = "0x23A120C", Slot = "8")]
		public bool Deregister(IService service)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EC")]
		public void RequestCallbackOnRegisterService<T>(Action<T> callback) where T : class, IService
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x23A100C", Offset = "0x23A100C", VA = "0x23A100C")]
		private void CallbackOnRegister(IService service)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x23A12EC", Offset = "0x23A12EC", VA = "0x23A12EC")]
		public void SetupFastAccess()
		{
		}

		[Token(Token = "0x60000EF")]
		private T ReturnServiceThrowErrorIfNull<T>(T service) where T : IService
		{
			return (T)null;
		}

		[Token(Token = "0x60000F0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xA65E84", Offset = "0xA65E84")]
		private void ServiceThrowErrorIfNull<T>(T service) where T : IService
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x23A12F0", Offset = "0x23A12F0", VA = "0x23A12F0")]
		public ServiceLocator()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class AsyncProgressReporter
	{
		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA64EDC", Offset = "0xA64EDC")]
		private sealed class <ReportProgressOnAsyncOperation>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncProgressReporter <>4__this;

			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AsyncOperation asyncOperation;

			[Token(Token = "0x17000012")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000102")]
				[Address(RVA = "0x23A47A0", Offset = "0x23A47A0", VA = "0x23A47A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000013")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000104")]
				[Address(RVA = "0x23A47E8", Offset = "0x23A47E8", VA = "0x23A47E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x23959E8", Offset = "0x23959E8", VA = "0x23959E8")]
			[DebuggerHidden]
			public <ReportProgressOnAsyncOperation>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000100")]
			[Address(RVA = "0x23A46E4", Offset = "0x23A46E4", VA = "0x23A46E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000101")]
			[Address(RVA = "0x23A46E8", Offset = "0x23A46E8", VA = "0x23A46E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000103")]
			[Address(RVA = "0x23A47A8", Offset = "0x23A47A8", VA = "0x23A47A8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<float> onProgress;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float baseProgress;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float progressMultiplier;

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2395738", Offset = "0x2395738", VA = "0x2395738")]
		public AsyncProgressReporter(Action<float> p_onProgress)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2395778", Offset = "0x2395778", VA = "0x2395778")]
		public AsyncProgressReporter CreateSubReporterForList(int numElementsInList)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2395870", Offset = "0x2395870", VA = "0x2395870")]
		public void NextListElement(bool alsoReport = false)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x23958FC", Offset = "0x23958FC", VA = "0x23958FC")]
		public void ReportListFinished()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x239590C", Offset = "0x239590C", VA = "0x239590C")]
		public AsyncProgressReporter(float p_baseProgress, float p_progressMultiplier, Action<float> p_onProgress)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2395954", Offset = "0x2395954", VA = "0x2395954")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA65EBC", Offset = "0xA65EBC")]
		public IEnumerator ReportProgressOnAsyncOperation(AsyncOperation asyncOperation)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2395884", Offset = "0x2395884", VA = "0x2395884")]
		public void ReportProgress(float progress)
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class DebugService : AbstractNeedInitService, INeedInitService, IService
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool noCarMovement;

		[Token(Token = "0x17000014")]
		public override string Name
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x23974F8", Offset = "0x23974F8", VA = "0x23974F8", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x239753C", Offset = "0x239753C", VA = "0x239753C", Slot = "10")]
		public override void InitService()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x23980E4", Offset = "0x23980E4", VA = "0x23980E4", Slot = "11")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x23980E8", Offset = "0x23980E8", VA = "0x23980E8", Slot = "14")]
		public override void AfterAllInitialized()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x23976DC", Offset = "0x23976DC", VA = "0x23976DC")]
		public string GetSystemInfo()
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x23980EC", Offset = "0x23980EC", VA = "0x23980EC")]
		public DebugService()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class GameEventService : AbstractNeedInitService, INeedInitService, IService
	{
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent onResolutionOrDPIChanged;

		[Token(Token = "0x17000015")]
		public override string Name
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x239E264", Offset = "0x239E264", VA = "0x239E264", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x239E2A8", Offset = "0x239E2A8", VA = "0x239E2A8", Slot = "11")]
		public override void Close()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x239E2AC", Offset = "0x239E2AC", VA = "0x239E2AC", Slot = "10")]
		public override void InitService()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x239E308", Offset = "0x239E308", VA = "0x239E308")]
		protected void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x239E314", Offset = "0x239E314", VA = "0x239E314")]
		public GameEventService()
		{
		}
	}
}
namespace KunstStoff.ServiceLoader
{
	[Token(Token = "0x2000031")]
	public abstract class AbstractNeedInitQueue : MonoBehaviour, INeedInitQueue
	{
		[Token(Token = "0x6000110")]
		public abstract void AddInitFinishedListener(UnityAction<INeedInitService, bool> onInitFinished);

		[Token(Token = "0x6000111")]
		public abstract void Init(string serviceName);

		[Token(Token = "0x6000112")]
		public abstract void Init(int serviceIndex);

		[Token(Token = "0x6000113")]
		public abstract void InitAll();

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x23952D4", Offset = "0x23952D4", VA = "0x23952D4")]
		protected AbstractNeedInitQueue()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public abstract class AbstractNeedInitService : MonoBehaviour, INeedInitService, IService
	{
		[Token(Token = "0x2000033")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA64EEC", Offset = "0xA64EEC")]
		private sealed class <InitServiceCoroutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AbstractNeedInitService <>4__this;

			[Token(Token = "0x17000019")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000123")]
				[Address(RVA = "0x23A4694", Offset = "0x23A4694", VA = "0x23A4694", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000125")]
				[Address(RVA = "0x23A46DC", Offset = "0x23A46DC", VA = "0x23A46DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000120")]
			[Address(RVA = "0x23954FC", Offset = "0x23954FC", VA = "0x23954FC")]
			[DebuggerHidden]
			public <InitServiceCoroutine>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000121")]
			[Address(RVA = "0x23A457C", Offset = "0x23A457C", VA = "0x23A457C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000122")]
			[Address(RVA = "0x23A4580", Offset = "0x23A4580", VA = "0x23A4580", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000124")]
			[Address(RVA = "0x23A469C", Offset = "0x23A469C", VA = "0x23A469C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[NonSerialized]
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BusyCounter busyCounter;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isBusy;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6501C", Offset = "0xA6501C")]
		private bool <isWaitingForUserInput>k__BackingField;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected InitEvent initFinished;

		[Token(Token = "0x17000016")]
		public bool IsBusy
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x23952DC", Offset = "0x23952DC", VA = "0x23952DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x23952E4", Offset = "0x23952E4", VA = "0x23952E4")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public bool isWaitingForUserInput
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x2395470", Offset = "0x2395470", VA = "0x2395470")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA65F6C", Offset = "0xA65F6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x2395478", Offset = "0x2395478", VA = "0x2395478")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA65F7C", Offset = "0xA65F7C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public abstract string Name
		{
			[Token(Token = "0x6000119")]
			get;
		}

		[Token(Token = "0x600011A")]
		public abstract void InitService();

		[Token(Token = "0x600011B")]
		public abstract void Close();

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2395484", Offset = "0x2395484", VA = "0x2395484", Slot = "12")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA65F8C", Offset = "0xA65F8C")]
		public virtual IEnumerator InitServiceCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2395528", Offset = "0x2395528", VA = "0x2395528", Slot = "13")]
		public virtual void AddInitFinishedListener(UnityAction<INeedInitService, bool> onInitFinished)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x239558C", Offset = "0x239558C", VA = "0x239558C", Slot = "14")]
		public virtual void AfterAllInitialized()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2395590", Offset = "0x2395590", VA = "0x2395590")]
		protected AbstractNeedInitService()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class BusyCounter
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int busyCounter;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Action _callbackWhenDecreasingToNonBusy;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool logChanges;

		[Token(Token = "0x1700001B")]
		public bool IsBusy
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x23965A4", Offset = "0x23965A4", VA = "0x23965A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x23965B4", Offset = "0x23965B4", VA = "0x23965B4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public int busyCount
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x23965B8", Offset = "0x23965B8", VA = "0x23965B8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x23965C0", Offset = "0x23965C0", VA = "0x23965C0")]
		public BusyCounter(Action callbackWhenDecreasingToNonBusy, bool log = true)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x239543C", Offset = "0x239543C", VA = "0x239543C")]
		public void IncBusyCounter()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x239544C", Offset = "0x239544C", VA = "0x239544C")]
		public void DecBusyCounter()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class DontDestroyOnLeaveLvl : MonoBehaviour
	{
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x239D018", Offset = "0x239D018", VA = "0x239D018")]
		private void Awake()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x239D0A0", Offset = "0x239D0A0", VA = "0x239D0A0")]
		public DontDestroyOnLeaveLvl()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000036")]
	public class InitEvent : UnityEvent<INeedInitService, bool>
	{
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x239E634", Offset = "0x239E634", VA = "0x239E634")]
		public InitEvent()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class InitServiceQueue : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000038")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA64EFC", Offset = "0xA64EFC")]
		private sealed class <>c
		{
			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<AbstractNeedInitService> <>9__10_0;

			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<AbstractNeedInitService> <>9__11_0;

			[Token(Token = "0x6000137")]
			[Address(RVA = "0x23A4E7C", Offset = "0x23A4E7C", VA = "0x23A4E7C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000138")]
			[Address(RVA = "0x23A4E84", Offset = "0x23A4E84", VA = "0x23A4E84")]
			internal void <InitializeServices>b__10_0(AbstractNeedInitService serv)
			{
			}

			[Token(Token = "0x6000139")]
			[Address(RVA = "0x23A4EA8", Offset = "0x23A4EA8", VA = "0x23A4EA8")]
			internal void <InitializeServicesCoroutine>b__11_0(AbstractNeedInitService serv)
			{
			}
		}

		[Token(Token = "0x2000039")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA64F0C", Offset = "0xA64F0C")]
		private sealed class <InitializeServicesCoroutine>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action onInitFinished;

			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public InitServiceQueue <>4__this;

			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AsyncProgressReporter <subProgressReporter>5__2;

			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <i>5__3;

			[Token(Token = "0x1700001E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600013D")]
				[Address(RVA = "0x23A52D4", Offset = "0x23A52D4", VA = "0x23A52D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600013F")]
				[Address(RVA = "0x23A531C", Offset = "0x23A531C", VA = "0x23A531C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600013A")]
			[Address(RVA = "0x239ED88", Offset = "0x239ED88", VA = "0x239ED88")]
			[DebuggerHidden]
			public <InitializeServicesCoroutine>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x600013B")]
			[Address(RVA = "0x23A4ECC", Offset = "0x23A4ECC", VA = "0x23A4ECC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600013C")]
			[Address(RVA = "0x23A4ED0", Offset = "0x23A4ED0", VA = "0x23A4ED0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600013E")]
			[Address(RVA = "0x23A52DC", Offset = "0x23A52DC", VA = "0x23A52DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool autoInitializeOnStart;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent initializationFinished;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<AbstractNeedInitService> services;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BusyCounter _busyCounter;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AsyncProgressReporter progressReporter;

		[Token(Token = "0x1700001D")]
		public bool IsBusy
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x239E680", Offset = "0x239E680", VA = "0x239E680")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x239E6A4", Offset = "0x239E6A4", VA = "0x239E6A4")]
		public bool IsWaitingForUserInput()
		{
			return default(bool);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x239E7D8", Offset = "0x239E7D8", VA = "0x239E7D8")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x239E8A8", Offset = "0x239E8A8", VA = "0x239E8A8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x239E8BC", Offset = "0x239E8BC", VA = "0x239E8BC")]
		public void InitializeServices([Optional] Action onInitFinished)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x239ECF4", Offset = "0x239ECF4", VA = "0x239ECF4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA6603C", Offset = "0xA6603C")]
		public IEnumerator InitializeServicesCoroutine([Optional] Action onInitFinished)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x239EDB4", Offset = "0x239EDB4", VA = "0x239EDB4")]
		public InitServiceQueue()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public interface INeedInitQueue
	{
		[Token(Token = "0x6000140")]
		void InitAll();

		[Token(Token = "0x6000141")]
		void Init(int serviceIndex);

		[Token(Token = "0x6000142")]
		void Init(string serviceName);

		[Token(Token = "0x6000143")]
		void AddInitFinishedListener(UnityAction<INeedInitService, bool> onInitFinished);
	}
	[Token(Token = "0x200003B")]
	public interface INeedInitService : IService
	{
		[Token(Token = "0x17000020")]
		string Name
		{
			[Token(Token = "0x6000144")]
			get;
		}

		[Token(Token = "0x6000145")]
		IEnumerator InitServiceCoroutine();

		[Token(Token = "0x6000146")]
		void AfterAllInitialized();

		[Token(Token = "0x6000147")]
		void Close();

		[Token(Token = "0x6000148")]
		void AddInitFinishedListener(UnityAction<INeedInitService, bool> onInitFinished);
	}
	[Token(Token = "0x200003C")]
	public interface IService
	{
	}
	[Token(Token = "0x200003D")]
	public interface IServiceLocator
	{
		[Token(Token = "0x6000149")]
		T GetService<T>(bool throwError = false) where T : IService;

		[Token(Token = "0x600014A")]
		T GetService<T>(int serviceIndex, bool throwError = false) where T : IService;

		[Token(Token = "0x600014B")]
		int Register(IService service);

		[Token(Token = "0x600014C")]
		bool Deregister(IService service);

		[Token(Token = "0x600014D")]
		int GetServiceIndex(IService service);

		[Token(Token = "0x600014E")]
		int GetServiceIndex<T>() where T : IService;
	}
	[Token(Token = "0x200003E")]
	public class NeedInitServiceQueue : AbstractNeedInitQueue, INeedInitQueue
	{
		[Token(Token = "0x200003F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA64F1C", Offset = "0xA64F1C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string serviceName;

			[Token(Token = "0x6000157")]
			[Address(RVA = "0x239F0D8", Offset = "0x239F0D8", VA = "0x239F0D8")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000158")]
			[Address(RVA = "0x23A53B4", Offset = "0x23A53B4", VA = "0x23A53B4")]
			internal bool <Init>b__0(AbstractNeedInitService x)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000040")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA64F2C", Offset = "0xA64F2C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<AbstractNeedInitService> <>9__11_0;

			[Token(Token = "0x600015A")]
			[Address(RVA = "0x23A5388", Offset = "0x23A5388", VA = "0x23A5388")]
			public <>c()
			{
			}

			[Token(Token = "0x600015B")]
			[Address(RVA = "0x23A5390", Offset = "0x23A5390", VA = "0x23A5390")]
			internal void <OnServiceInitFinished>b__11_0(AbstractNeedInitService serv)
			{
			}
		}

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InitEvent initializationFinished;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InitEvent singleServiceInitFinished;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<AbstractNeedInitService> services;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int currentServiceIndex;

		[Token(Token = "0x17000021")]
		public List<AbstractNeedInitService> Services
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x239EE10", Offset = "0x239EE10", VA = "0x239EE10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x239EE18", Offset = "0x239EE18", VA = "0x239EE18", Slot = "8")]
		public override void AddInitFinishedListener(UnityAction<INeedInitService, bool> onInitFinished)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x239EE7C", Offset = "0x239EE7C", VA = "0x239EE7C", Slot = "9")]
		public override void Init(string serviceName)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x239F0E0", Offset = "0x239F0E0", VA = "0x239F0E0", Slot = "10")]
		public override void Init(int serviceIndex)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x239F230", Offset = "0x239F230", VA = "0x239F230", Slot = "11")]
		public override void InitAll()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x239F380", Offset = "0x239F380", VA = "0x239F380")]
		private void OnSingleServiceInitFinished(INeedInitService service, bool initState)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x239F3EC", Offset = "0x239F3EC", VA = "0x239F3EC")]
		private void OnServiceInitFinished(INeedInitService service, bool initState)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x239F6A4", Offset = "0x239F6A4", VA = "0x239F6A4")]
		public NeedInitServiceQueue()
		{
		}
	}
}
namespace KunstStoff.Persistence
{
	[Token(Token = "0x2000041")]
	public abstract class AbstractPersistableSelfSerializable<TSerializer> : AbstractSelfSerializable<TSerializer> where TSerializer : ISerializer, new()
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6508C", Offset = "0xA6508C")]
		private int <Version>k__BackingField;

		[Token(Token = "0x17000022")]
		[XmlIgnore]
		public virtual int Version
		{
			[Token(Token = "0x600015C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA660EC", Offset = "0xA660EC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600015D")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA660FC", Offset = "0xA660FC")]
			set
			{
			}
		}

		[Token(Token = "0x600015E")]
		public void Write(IPersister persister, string key)
		{
		}

		[Token(Token = "0x600015F")]
		public static object Read(IPersister persister, string key)
		{
			return null;
		}

		[Token(Token = "0x6000160")]
		protected AbstractPersistableSelfSerializable()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public abstract class AbstractPersistenceService : AbstractNeedInitService, IPersistenceService
	{
		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6509C", Offset = "0xA6509C")]
		private bool <IsDirty>k__BackingField;

		[Token(Token = "0x17000023")]
		public virtual bool IsDirty
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x2395598", Offset = "0x2395598", VA = "0x2395598", Slot = "18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6610C", Offset = "0xA6610C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x23955A0", Offset = "0x23955A0", VA = "0x23955A0", Slot = "19")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA6611C", Offset = "0xA6611C")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000163")]
		public abstract void Read();

		[Token(Token = "0x6000164")]
		public abstract void Write();

		[Token(Token = "0x6000165")]
		public abstract void Reset();

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x23955AC", Offset = "0x23955AC", VA = "0x23955AC", Slot = "23")]
		public virtual void SetDirty()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x23955C0", Offset = "0x23955C0", VA = "0x23955C0", Slot = "24")]
		public virtual void WriteIfDirty()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2395618", Offset = "0x2395618", VA = "0x2395618")]
		protected AbstractPersistenceService()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public abstract class AbstractSelfSerializable<TSerializer> where TSerializer : ISerializer, new()
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static TSerializer serializer;

		[Token(Token = "0x17000024")]
		private static TSerializer Serializer
		{
			[Token(Token = "0x6000169")]
			get
			{
				return (TSerializer)null;
			}
		}

		[Token(Token = "0x600016A")]
		public virtual string Serialize()
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		public static object Deserialize(string serializedData)
		{
			return null;
		}

		[Token(Token = "0x600016C")]
		protected AbstractSelfSerializable()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class AchievementData : AbstractPersistableSelfSerializable<XMLSerializer<AchievementData>>, IKSSerializationCallbackReceiver
	{
		[Token(Token = "0x2000045")]
		public enum CounterType
		{
			[Token(Token = "0x400007F")]
			MyEvent,
			[Token(Token = "0x4000080")]
			Max
		}

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int version;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "XmlArrayAttribute", RVA = "0xA650AC", Offset = "0xA650AC")]
		public List<int> counter;

		[Token(Token = "0x17000025")]
		[XmlIgnore]
		public List<int> Counter
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x2395620", Offset = "0x2395620", VA = "0x2395620")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x23956E4", Offset = "0x23956E4", VA = "0x23956E4", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x23956E8", Offset = "0x23956E8", VA = "0x23956E8", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x23956EC", Offset = "0x23956EC", VA = "0x23956EC")]
		public AchievementData()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class DeviceCapabilities
	{
		[Serializable]
		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA64F3C", Offset = "0xA64F3C")]
		private sealed class <>c
		{
			[Token(Token = "0x400008E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400008F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Resolution, Resolution, int> <>9__15_0;

			[Token(Token = "0x6000175")]
			[Address(RVA = "0x23A4854", Offset = "0x23A4854", VA = "0x23A4854")]
			public <>c()
			{
			}

			[Token(Token = "0x6000176")]
			[Address(RVA = "0x23A485C", Offset = "0x23A485C", VA = "0x23A485C")]
			internal int <.ctor>b__15_0(Resolution resA, Resolution resB)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SettingsDataQuality.QualityLevelSettings minQualityLevel;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public SettingsDataQuality.QualityLevelSettings maxQualityLevel;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SettingsDataQuality.QualityLevelSettings defaultQualityLevel;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SettingsDataResolution.RenderResolutionIndex defaultRenderResolutionIndex;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool supportsVideoSettingsTab;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool supportsQualityChanges;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool supportsResolutionChanges;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool supportsRenderResolutionChanges;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool supportsDisplayChanges;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool supportsScreenModeChanges;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool supportsAutoDetect;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool supportsShowFramerate;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Resolution[] supportsResolutions;

		[Token(Token = "0x17000026")]
		public Resolution[] SupportsResolutions
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x23980F4", Offset = "0x23980F4", VA = "0x23980F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x23980FC", Offset = "0x23980FC", VA = "0x23980FC")]
		public DeviceCapabilities()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x239881C", Offset = "0x239881C", VA = "0x239881C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000048")]
	public class DeviceModelNames
	{
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2398F24", Offset = "0x2398F24", VA = "0x2398F24")]
		public static string GetModelName(string deviceModel)
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x239CC94", Offset = "0x239CC94", VA = "0x239CC94")]
		public DeviceModelNames()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class EachKeyOneFilePersister : MonoBehaviour, IPersister
	{
		[Token(Token = "0x200004A")]
		public enum FileSystemType
		{
			[Token(Token = "0x4000098")]
			Auto,
			[Token(Token = "0x4000099")]
			NullFileSystem,
			[Token(Token = "0x400009A")]
			StreamFileSystem,
			[Token(Token = "0x400009B")]
			PlayerPrefsFileSystem,
			[Token(Token = "0x400009C")]
			NintendoSwitchFS,
			[Token(Token = "0x400009D")]
			P31PrefsFS,
			[Token(Token = "0x400009E")]
			iCloudKeyValue,
			[Token(Token = "0x400009F")]
			XboxConnectedStorage
		}

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool saveToAppFolder;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		public FileSystemType fileSystemType;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string relativePath;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string fileEnding;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent StartWrite;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent EndWrite;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IFileSystem fileSystem;

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x239D0A8", Offset = "0x239D0A8", VA = "0x239D0A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x239D224", Offset = "0x239D224", VA = "0x239D224")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x239D0B0", Offset = "0x239D0B0", VA = "0x239D0B0")]
		public void InitFileSystem(FileSystemType fst)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x239D318", Offset = "0x239D318", VA = "0x239D318")]
		protected string BasePath()
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x239D330", Offset = "0x239D330", VA = "0x239D330", Slot = "5")]
		public string Read(string key)
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x239D4A4", Offset = "0x239D4A4", VA = "0x239D4A4", Slot = "4")]
		public void Write(string key, string value)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x239D628", Offset = "0x239D628", VA = "0x239D628", Slot = "6")]
		public void Delete(string key)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x239D79C", Offset = "0x239D79C", VA = "0x239D79C")]
		public EachKeyOneFilePersister()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public interface IKSSerializationCallbackReceiver
	{
		[Token(Token = "0x6000181")]
		void OnBeforeSerialize();

		[Token(Token = "0x6000182")]
		void OnAfterDeserialize();
	}
	[Token(Token = "0x200004C")]
	public interface IPersistenceService
	{
		[Token(Token = "0x6000183")]
		void Read();

		[Token(Token = "0x6000184")]
		void Write();

		[Token(Token = "0x6000185")]
		void Reset();
	}
	[Token(Token = "0x200004D")]
	public enum PersistTypes
	{
		[Token(Token = "0x40000A1")]
		Dirty,
		[Token(Token = "0x40000A2")]
		DirtyRead,
		[Token(Token = "0x40000A3")]
		DirtyWrite,
		[Token(Token = "0x40000A4")]
		Clean
	}
	[Token(Token = "0x200004E")]
	public interface IPersister
	{
		[Token(Token = "0x6000186")]
		void Write(string key, string value);

		[Token(Token = "0x6000187")]
		string Read(string key);

		[Token(Token = "0x6000188")]
		void Delete(string key);
	}
	[Token(Token = "0x200004F")]
	public interface ISerializer
	{
		[Token(Token = "0x6000189")]
		string Serialize(object serializableObject);

		[Token(Token = "0x600018A")]
		object Deserialize(string serializedData);
	}
	[Token(Token = "0x2000050")]
	public class BinarySerializer : ISerializer
	{
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BinaryFormatter binFormatter;

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2395B98", Offset = "0x2395B98", VA = "0x2395B98", Slot = "4")]
		public string Serialize(object serializableObject)
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2395E18", Offset = "0x2395E18", VA = "0x2395E18", Slot = "5")]
		public object Deserialize(string serializedData)
		{
			return null;
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2396094", Offset = "0x2396094", VA = "0x2396094")]
		public BinarySerializer()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class JSonSerializer<T> : ISerializer
	{
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool prettyPrint;

		[Token(Token = "0x17000027")]
		public bool PrettyPrint
		{
			[Token(Token = "0x6000191")]
			set
			{
			}
		}

		[Token(Token = "0x600018E")]
		public string Serialize(object serializableObject)
		{
			return null;
		}

		[Token(Token = "0x600018F")]
		public object Deserialize(string serializedData)
		{
			return null;
		}

		[Token(Token = "0x6000190")]
		public void Deserialize(string serializedData, T serializedObject)
		{
		}

		[Token(Token = "0x6000192")]
		public JSonSerializer()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class XMLSerializer<T> : ISerializer
	{
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private XmlSerializer xmlSerializer;

		[Token(Token = "0x6000193")]
		public string Serialize(object serializableObject)
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		public object Deserialize(string serializedData)
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		public XMLSerializer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class SettingsData : AbstractPersistableSelfSerializable<XMLSerializer<SettingsData>>, IKSSerializationCallbackReceiver
	{
		[Token(Token = "0x2000054")]
		public class DeviceScreenSettings
		{
			[Token(Token = "0x40000B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string id;

			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int width;

			[Token(Token = "0x40000BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int height;

			[Token(Token = "0x40000BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int fontScaleIdx;

			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x23A1AC8", Offset = "0x23A1AC8", VA = "0x23A1AC8")]
			public void Apply(string id, int width, int height, int fontScaleIdx)
			{
			}

			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x23A1AB8", Offset = "0x23A1AB8", VA = "0x23A1AB8")]
			public DeviceScreenSettings()
			{
			}
		}

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int version;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool initalized;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<DeviceScreenSettings> deviceScreenSettingsList;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SettingsDataQuality qualitySettings;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SettingsDataResolution resolutionSettings;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SettingsDataFont fontSettings;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SettingsDataAudio audioSettings;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public SettingsDataGameplay gameplaySettings;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SettingsDataLanguage languageSettings;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool showFramerate;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[XmlIgnore]
		public UnityEvent OnApplyResolutionSettings;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[XmlIgnore]
		public UnityEvent OnApplyQualitySettings;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[XmlIgnore]
		public UnityEvent OnApplyVolumeSettings;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[XmlIgnore]
		public UnityEvent OnApplyLanguageSettings;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[XmlIgnore]
		public FloatEvent OnApplyFontSettings;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[XmlIgnore]
		public UnityEvent OnApplyGameplaySettings;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int deviceScreenSettingsIdx;

		[Token(Token = "0x17000028")]
		private SettingsService SettingsService
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x23A14BC", Offset = "0x23A14BC", VA = "0x23A14BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x23A1554", Offset = "0x23A1554", VA = "0x23A1554", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x23A1558", Offset = "0x23A1558", VA = "0x23A1558", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x23A155C", Offset = "0x23A155C", VA = "0x23A155C")]
		public void Init(DeviceCapabilities deviceCapabilities)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x23A1B0C", Offset = "0x23A1B0C", VA = "0x23A1B0C")]
		public DeviceScreenSettings GetDeviceScreenSettings()
		{
			return null;
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x23A1B78", Offset = "0x23A1B78", VA = "0x23A1B78")]
		public void ApplySettings(DeviceCapabilities deviceCapabilities)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x23A1BEC", Offset = "0x23A1BEC", VA = "0x23A1BEC")]
		public void ApplyQualitySettings(DeviceCapabilities deviceCapabilities)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x23A1C30", Offset = "0x23A1C30", VA = "0x23A1C30")]
		public void ApplyResolutionSettings(DeviceCapabilities deviceCapabilities, int width, int height)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x23A2338", Offset = "0x23A2338", VA = "0x23A2338")]
		public void ApplyResolutionSettings(DeviceCapabilities deviceCapabilities, SettingsDataResolution.RenderResolutionIndex renderResolutionIdx)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x23A1C74", Offset = "0x23A1C74", VA = "0x23A1C74")]
		public void ApplyVolumeSettings()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x23A1C9C", Offset = "0x23A1C9C", VA = "0x23A1C9C")]
		public void ApplyLanguageSettings()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x23A1CE0", Offset = "0x23A1CE0", VA = "0x23A1CE0")]
		public void ApplyFontSizeSettings(int fontScaleIdx)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x23A1D6C", Offset = "0x23A1D6C", VA = "0x23A1D6C")]
		public void ApplyGameplaySettings()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x23A26B4", Offset = "0x23A26B4", VA = "0x23A26B4")]
		public SettingsData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class SettingsDataAudio
	{
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float master;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float music;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float sound;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float voice;

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x23A245C", Offset = "0x23A245C", VA = "0x23A245C")]
		public void Apply()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x23A2A04", Offset = "0x23A2A04", VA = "0x23A2A04")]
		public SettingsDataAudio()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class SettingsDataFont
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float[] FONT_SCALE_MAP;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[XmlIgnore]
		public bool disableFontSizeScaling;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float fontScaleAdjustment;

		[Token(Token = "0x17000029")]
		public float FontScaleAdjustment
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x23A2A88", Offset = "0x23A2A88", VA = "0x23A2A88")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x23A2464", Offset = "0x23A2464", VA = "0x23A2464")]
		public void Apply(int fontScaleIdx)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x23A1A00", Offset = "0x23A1A00", VA = "0x23A1A00")]
		public int CalculateFontScaleIdx()
		{
			return default(int);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x23A29F4", Offset = "0x23A29F4", VA = "0x23A29F4")]
		public SettingsDataFont()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class SettingsDataGameplay
	{
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool invertYAxis;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float inputSensitivity;

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x23A25BC", Offset = "0x23A25BC", VA = "0x23A25BC")]
		public void Apply()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x23A2A14", Offset = "0x23A2A14", VA = "0x23A2A14")]
		public SettingsDataGameplay()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class SettingsDataLanguage
	{
		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string languageCode;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool subtitlesOn;

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x23A2460", Offset = "0x23A2460", VA = "0x23A2460")]
		public void Apply()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x23A2B24", Offset = "0x23A2B24", VA = "0x23A2B24")]
		private void ApplyLanguage()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x23A2A24", Offset = "0x23A2A24", VA = "0x23A2A24")]
		public SettingsDataLanguage()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class SettingsDataQuality
	{
		[Token(Token = "0x200005A")]
		public enum QualityLevelSettings
		{
			[Token(Token = "0x40000CD")]
			VERYLOW,
			[Token(Token = "0x40000CE")]
			LOW,
			[Token(Token = "0x40000CF")]
			MEDIUM,
			[Token(Token = "0x40000D0")]
			HIGH,
			[Token(Token = "0x40000D1")]
			VERYHIGH,
			[Token(Token = "0x40000D2")]
			ULTRA,
			[Token(Token = "0x40000D3")]
			MAX
		}

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] QUALITY_LOD;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public QualityLevelSettings qualityLevel;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool autoDetectPending;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool autoDetectWarning;

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x23A1DB0", Offset = "0x23A1DB0", VA = "0x23A1DB0")]
		public void Apply(DeviceCapabilities deviceCapabilities)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x23A29CC", Offset = "0x23A29CC", VA = "0x23A29CC")]
		public SettingsDataQuality()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class SettingsDataResolution
	{
		[Token(Token = "0x200005C")]
		public enum RenderResolutionIndex
		{
			[Token(Token = "0x40000DA")]
			PERCENT_100,
			[Token(Token = "0x40000DB")]
			PERCENT_87,
			[Token(Token = "0x40000DC")]
			PERCENT_75,
			[Token(Token = "0x40000DD")]
			PERCENT_62,
			[Token(Token = "0x40000DE")]
			PERCENT_50,
			[Token(Token = "0x40000DF")]
			MAX
		}

		[Token(Token = "0x200005D")]
		private class ResolutionComparer : IComparer<Resolution>
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x23A53F4", Offset = "0x23A53F4", VA = "0x23A53F4", Slot = "4")]
			public int Compare(Resolution b, Resolution a)
			{
				return default(int);
			}

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x23A2F38", Offset = "0x23A2F38", VA = "0x23A2F38")]
			public ResolutionComparer()
			{
			}
		}

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int minScreenHeight;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float[] RENDER_RESOLUTION_FACTOR;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RenderResolutionIndex renderResolutionIndex;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool isFullscreen;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int renderResolutionIdx;

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x23A1FA0", Offset = "0x23A1FA0", VA = "0x23A1FA0")]
		public void Apply(DeviceCapabilities deviceCapabilities, int width, int height)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x23A2E54", Offset = "0x23A2E54", VA = "0x23A2E54")]
		public float GetRenderResolutionScaleFactor()
		{
			return default(float);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x23A18D4", Offset = "0x23A18D4", VA = "0x23A18D4")]
		public static int ScaleResolution(int size, float scale)
		{
			return default(int);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x23A2EE8", Offset = "0x23A2EE8", VA = "0x23A2EE8")]
		public static float GetAspect(Resolution resolution)
		{
			return default(float);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2398354", Offset = "0x2398354", VA = "0x2398354")]
		public static Resolution[] FilterAvailableResolutions(Resolution[] deviceResolutions, bool keepAspect)
		{
			return null;
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x23A2F40", Offset = "0x23A2F40", VA = "0x23A2F40")]
		public Resolution[] FilterAvailableResolutionsFromScale(Resolution[] deviceResolutions)
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x23A29E4", Offset = "0x23A29E4", VA = "0x23A29E4")]
		public SettingsDataResolution()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xA64F4C", Offset = "0xA64F4C")]
	public class QualityConfig : ScriptableObject
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA6518C", Offset = "0xA6518C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6518C", Offset = "0xA6518C")]
		public float farClipPlane;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA651D8", Offset = "0xA651D8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA651D8", Offset = "0xA651D8")]
		public float detailObjectDensity;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float detailObjectDistance;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA65224", Offset = "0xA65224")]
		public bool drawInstanced;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool castShadows;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA65234", Offset = "0xA65234")]
		public int heightmapPixelError;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int heightmapMaximumLOD;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA65244", Offset = "0xA65244")]
		public int basemapDistance;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA65254", Offset = "0xA65254")]
		public float treeDistance;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float treeBillboardDistance;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float treeCrossFadeLength;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int treeMaximumFullLODCount;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA65264", Offset = "0xA65264")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xA65264", Offset = "0xA65264")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA65264", Offset = "0xA65264")]
		public GrassSystemQuality grassQualityR1;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA652D4", Offset = "0xA652D4")]
		public GrassSystemQuality grassQualityR2;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA652E4", Offset = "0xA652E4")]
		public bool usePostProcessing;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6531C", Offset = "0xA6531C")]
		public bool allowColorGrading;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool allowDepthOfField;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		public bool allowBloom;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool allowGrain;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		public bool allowLensDistortion;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		public bool allowAmbientOcclusion;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		public bool allowAutoExposure;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool allowChromaticAbberation;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool allowMotionBlur;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool allowVignette;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		public bool allowScreenSpaceReflections;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA65354", Offset = "0xA65354")]
		public bool allowAmplifyOcclusion;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		public bool allowAmplifyBloom;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6538C", Offset = "0xA6538C")]
		public PostProcessLayer.Antialiasing antiAliasingMode;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public FastApproximateAntialiasing FXAASettings;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public SubpixelMorphologicalAntialiasing SMAASettings;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TemporalAntialiasing TAASettings;

		[Token(Token = "0x1700002A")]
		private bool isTAA
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x23A070C", Offset = "0x23A070C", VA = "0x23A070C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002B")]
		private bool isSMAA
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x23A071C", Offset = "0x23A071C", VA = "0x23A071C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002C")]
		private bool isFXAA
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x23A072C", Offset = "0x23A072C", VA = "0x23A072C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x23A073C", Offset = "0x23A073C", VA = "0x23A073C")]
		public void ApplyPostFXSettings(PostProcessVolume volume)
		{
		}

		[Token(Token = "0x60001C3")]
		private void OverridePostFX<T>(PostProcessVolume volume, bool overrideEnabled) where T : PostProcessEffectSettings
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x23A097C", Offset = "0x23A097C", VA = "0x23A097C")]
		public QualityConfig()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class SettingsService : AbstractPersistenceService
	{
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private EachKeyOneFilePersister stdPersister;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string settingsPersistenceKey;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xA653E4", Offset = "0xA653E4")]
		private QualityConfig[] qualityConfigs;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private QualityConfig[] qualityConfigs_NSW;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xA6542C", Offset = "0xA6542C")]
		public bool disableFontSizeScaling;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SettingsData settingsData;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isDirty;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public DeviceCapabilities deviceCapabilities;

		[Token(Token = "0x1700002D")]
		public SettingsData Settings
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x23A31E4", Offset = "0x23A31E4", VA = "0x23A31E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public override string Name
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x23A3454", Offset = "0x23A3454", VA = "0x23A3454", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x23A31EC", Offset = "0x23A31EC", VA = "0x23A31EC", Slot = "20")]
		public override void Read()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x23A3374", Offset = "0x23A3374", VA = "0x23A3374", Slot = "21")]
		public override void Write()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x23A33E4", Offset = "0x23A33E4", VA = "0x23A33E4", Slot = "22")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x23A3498", Offset = "0x23A3498", VA = "0x23A3498", Slot = "11")]
		public override void Close()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x23A349C", Offset = "0x23A349C", VA = "0x23A349C", Slot = "10")]
		public override void InitService()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x23A3540", Offset = "0x23A3540", VA = "0x23A3540")]
		public QualityConfig GetCurrentQualityConfig()
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x23A32C8", Offset = "0x23A32C8", VA = "0x23A32C8")]
		private void CreateDefaultSettingsData()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x23A3590", Offset = "0x23A3590", VA = "0x23A3590")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x23A35BC", Offset = "0x23A35BC", VA = "0x23A35BC")]
		protected void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x23A35C8", Offset = "0x23A35C8", VA = "0x23A35C8")]
		public SettingsService()
		{
		}
	}
}
namespace KunstStoff.Extensions
{
	[Token(Token = "0x2000060")]
	public static class ArrayExtensions
	{
		[Token(Token = "0x60001D1")]
		public static void Fill<T>(this T[] thisArray, T with)
		{
		}
	}
	[Token(Token = "0x2000061")]
	public static class IEnumerableExtensions
	{
		[Token(Token = "0x60001D2")]
		public static T PickRandom<T>(this IEnumerable<T> thisList)
		{
			return (T)null;
		}
	}
}
namespace KunstStoff.Debugging
{
	[Token(Token = "0x2000062")]
	public static class BuildVersionInfo
	{
		[Token(Token = "0x1700002F")]
		public static string BuildVersionPath
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x2396150", Offset = "0x2396150", VA = "0x2396150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x23961D8", Offset = "0x23961D8", VA = "0x23961D8")]
		public static string ReadBuildVersion()
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x239628C", Offset = "0x239628C", VA = "0x239628C")]
		public static void WriteBuildVersion()
		{
		}
	}
}
namespace KunstStoff.Utilities
{
	[Token(Token = "0x2000063")]
	public class AutoDisableOrDestroy : MonoBehaviour
	{
		[Token(Token = "0x2000064")]
		public enum Reaction
		{
			[Token(Token = "0x4000115")]
			DISABLE,
			[Token(Token = "0x4000116")]
			DESTROY
		}

		[Token(Token = "0x2000065")]
		public enum Runlevel
		{
			[Token(Token = "0x4000118")]
			AWAKE,
			[Token(Token = "0x4000119")]
			START
		}

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool buildtargetAlways;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool buildtargetCheats;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool buildtargetNoCheats;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool buildtargetDebug;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool buildtargetRelease;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool buildtargetStoreTest;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool buildtargetStorePublic;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
		public bool buildtargetProfile;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool buildtargetNoProfile;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool buildtargetNoConsole;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Reaction reaction;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Runlevel runlevel;

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2395A8C", Offset = "0x2395A8C", VA = "0x2395A8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2395B78", Offset = "0x2395B78", VA = "0x2395B78")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2395A9C", Offset = "0x2395A9C", VA = "0x2395A9C")]
		private void Check()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2395B88", Offset = "0x2395B88", VA = "0x2395B88")]
		public AutoDisableOrDestroy()
		{
		}
	}
}
