using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Crosstales.Common.Model.Enum;
using Crosstales.Common.Util;
using Crosstales.OnlineCheck.Data;
using Crosstales.OnlineCheck.Model;
using Crosstales.OnlineCheck.Model.Enum;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using MEC;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class BetterStreamingAssets
{
	[Token(Token = "0x2000003")]
	internal struct ReadInfo
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string readPath;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long size;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long offset;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint crc32;
	}

	[Token(Token = "0x2000004")]
	internal static class ApkImpl
	{
		[Token(Token = "0x2000005")]
		private struct PartInfo
		{
			[Token(Token = "0x4000008")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long size;

			[Token(Token = "0x4000009")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long offset;

			[Token(Token = "0x400000A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint crc32;
		}

		[Token(Token = "0x2000006")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47D68", Offset = "0xC47D68")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400000B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string searchPattern;

			[Token(Token = "0x6000019")]
			[Address(RVA = "0x1F053B4", Offset = "0x1F053B4", VA = "0x1F053B4")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600001A")]
			[Address(RVA = "0x1F11AB0", Offset = "0x1F11AB0", VA = "0x1F11AB0")]
			internal bool <GetFiles>b__0(string x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000007")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47D78", Offset = "0xC47D78")]
		private sealed class <>c__DisplayClass7_1
		{
			[Token(Token = "0x400000C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Regex regex;

			[Token(Token = "0x600001B")]
			[Address(RVA = "0x1F053BC", Offset = "0x1F053BC", VA = "0x1F053BC")]
			public <>c__DisplayClass7_1()
			{
			}

			[Token(Token = "0x600001C")]
			[Address(RVA = "0x1F11AE0", Offset = "0x1F11AE0", VA = "0x1F11AE0")]
			internal bool <GetFiles>b__1(string x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string[] s_paths;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static PartInfo[] s_streamingAssets;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string s_root;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1F04078", Offset = "0x1F04078", VA = "0x1F04078")]
		public static void Initialize(string dataPath, string streamingAssetsPath)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1F04B08", Offset = "0x1F04B08", VA = "0x1F04B08")]
		public static bool TryGetInfo(string path, out ReadInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1F04C80", Offset = "0x1F04C80", VA = "0x1F04C80")]
		public static bool DirectoryExists(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1F04EF8", Offset = "0x1F04EF8", VA = "0x1F04EF8")]
		public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
		{
			return null;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1F053C4", Offset = "0x1F053C4", VA = "0x1F053C4")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1F0568C", Offset = "0x1F0568C", VA = "0x1F0568C")]
		public static Stream OpenRead(string path)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1F04D04", Offset = "0x1F04D04", VA = "0x1F04D04")]
		private static int GetDirectoryIndex(string path)
		{
			return default(int);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1F042B8", Offset = "0x1F042B8", VA = "0x1F042B8")]
		private static void GetStreamingAssetsInfoFromJar(string apkPath, List<string> paths, List<PartInfo> parts)
		{
		}
	}

	[Token(Token = "0x17000001")]
	public static string Root
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1451F54", Offset = "0x1451F54", VA = "0x1451F54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x144D5CC", Offset = "0x144D5CC", VA = "0x144D5CC")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1451FA0", Offset = "0x1451FA0", VA = "0x1451FA0")]
	public static bool FileExists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1451FD0", Offset = "0x1451FD0", VA = "0x1451FD0")]
	public static bool DirectoryExists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1451FD8", Offset = "0x1451FD8", VA = "0x1451FD8")]
	public static AssetBundleCreateRequest LoadAssetBundleAsync(string path, uint crc = 0u)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1452064", Offset = "0x1452064", VA = "0x1452064")]
	public static AssetBundle LoadAssetBundle(string path, uint crc = 0u)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x14520A0", Offset = "0x14520A0", VA = "0x14520A0")]
	public static Stream OpenRead(string path)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1452158", Offset = "0x1452158", VA = "0x1452158")]
	public static StreamReader OpenText(string path)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1452260", Offset = "0x1452260", VA = "0x1452260")]
	public static string ReadAllText(string path)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x14523B0", Offset = "0x14523B0", VA = "0x14523B0")]
	public static string[] ReadAllLines(string path)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x145259C", Offset = "0x145259C", VA = "0x145259C")]
	public static byte[] ReadAllBytes(string path)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x144DBD4", Offset = "0x144DBD4", VA = "0x144DBD4")]
	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1452654", Offset = "0x1452654", VA = "0x1452654")]
	public static string[] GetFiles(string path)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1452664", Offset = "0x1452664", VA = "0x1452664")]
	public static string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1452014", Offset = "0x1452014", VA = "0x1452014")]
	private static ReadInfo GetInfoOrThrow(string path)
	{
		return default(ReadInfo);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1452670", Offset = "0x1452670", VA = "0x1452670")]
	private static void ThrowFileNotFound(string path)
	{
	}
}
[Token(Token = "0x2000008")]
public static class MECExtensionMethods2
{
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47D98", Offset = "0xC47D98")]
	private sealed class <Delay>d__0 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float timeToDelay;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000002")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x1F093C4", Offset = "0x1F093C4", VA = "0x1F093C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000003")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x1F0940C", Offset = "0x1F0940C", VA = "0x1F0940C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1F091D4", Offset = "0x1F091D4", VA = "0x1F091D4")]
		[DebuggerHidden]
		public <Delay>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1F09200", Offset = "0x1F09200", VA = "0x1F09200", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1F09204", Offset = "0x1F09204", VA = "0x1F09204", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1F093CC", Offset = "0x1F093CC", VA = "0x1F093CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47DA8", Offset = "0xC47DA8")]
	private sealed class <Delay>d__1 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000004")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x1F09638", Offset = "0x1F09638", VA = "0x1F09638", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000005")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x1F09680", Offset = "0x1F09680", VA = "0x1F09680", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1F0946C", Offset = "0x1F0946C", VA = "0x1F0946C")]
		[DebuggerHidden]
		public <Delay>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1F09498", Offset = "0x1F09498", VA = "0x1F09498", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1F0949C", Offset = "0x1F0949C", VA = "0x1F0949C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1F09640", Offset = "0x1F09640", VA = "0x1F09640", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47DB8", Offset = "0xC47DB8")]
	private sealed class <Delay>d__2<T> : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Func<T, bool> condition;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T data;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000006")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000041")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000007")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000043")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003E")]
		[DebuggerHidden]
		public <Delay>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x600003F")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000040")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47DC8", Offset = "0xC47DC8")]
	private sealed class <DelayFrames>d__3 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int framesToDelay;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000008")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x1F09894", Offset = "0x1F09894", VA = "0x1F09894", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000009")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x1F098DC", Offset = "0x1F098DC", VA = "0x1F098DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1F096E0", Offset = "0x1F096E0", VA = "0x1F096E0")]
		[DebuggerHidden]
		public <DelayFrames>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1F0970C", Offset = "0x1F0970C", VA = "0x1F0970C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1F09710", Offset = "0x1F09710", VA = "0x1F09710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1F0989C", Offset = "0x1F0989C", VA = "0x1F0989C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47DD8", Offset = "0xC47DD8")]
	private sealed class <CancelWith>d__4 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject;

		[Token(Token = "0x1700000A")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x1F08AD8", Offset = "0x1F08AD8", VA = "0x1F08AD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x1F08B20", Offset = "0x1F08B20", VA = "0x1F08B20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1F0886C", Offset = "0x1F0886C", VA = "0x1F0886C")]
		[DebuggerHidden]
		public <CancelWith>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1F08898", Offset = "0x1F08898", VA = "0x1F08898", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1F0889C", Offset = "0x1F0889C", VA = "0x1F0889C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1F08AE0", Offset = "0x1F08AE0", VA = "0x1F08AE0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47DE8", Offset = "0xC47DE8")]
	private sealed class <CancelWith>d__5 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject1;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gameObject2;

		[Token(Token = "0x1700000C")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x1F08E2C", Offset = "0x1F08E2C", VA = "0x1F08E2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x1F08E74", Offset = "0x1F08E74", VA = "0x1F08E74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1F08B80", Offset = "0x1F08B80", VA = "0x1F08B80")]
		[DebuggerHidden]
		public <CancelWith>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1F08BAC", Offset = "0x1F08BAC", VA = "0x1F08BAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1F08BB0", Offset = "0x1F08BB0", VA = "0x1F08BB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1F08E34", Offset = "0x1F08E34", VA = "0x1F08E34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47DF8", Offset = "0xC47DF8")]
	private sealed class <CancelWith>d__6<T> : IEnumerator<float>, IEnumerator, IDisposable where T : MonoBehaviour
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T script;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GameObject <myGO>5__2;

		[Token(Token = "0x1700000E")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000059")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600005B")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000056")]
		[DebuggerHidden]
		public <CancelWith>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000057")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000058")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600005A")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47E08", Offset = "0xC47E08")]
	private sealed class <CancelWith>d__7 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000010")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x1F0912C", Offset = "0x1F0912C", VA = "0x1F0912C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000011")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x1F09174", Offset = "0x1F09174", VA = "0x1F09174", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1F08ED4", Offset = "0x1F08ED4", VA = "0x1F08ED4")]
		[DebuggerHidden]
		public <CancelWith>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1F08F00", Offset = "0x1F08F00", VA = "0x1F08F00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1F08F04", Offset = "0x1F08F04", VA = "0x1F08F04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1F09134", Offset = "0x1F09134", VA = "0x1F09134", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47E18", Offset = "0xC47E18")]
	private sealed class <PauseWith>d__8 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000012")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x1F0A36C", Offset = "0x1F0A36C", VA = "0x1F0A36C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000013")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x1F0A3B4", Offset = "0x1F0A3B4", VA = "0x1F0A3B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1F0A0F4", Offset = "0x1F0A0F4", VA = "0x1F0A0F4")]
		[DebuggerHidden]
		public <PauseWith>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1F0A120", Offset = "0x1F0A120", VA = "0x1F0A120", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1F0A124", Offset = "0x1F0A124", VA = "0x1F0A124", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1F0A374", Offset = "0x1F0A374", VA = "0x1F0A374", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47E28", Offset = "0xC47E28")]
	private sealed class <PauseWith>d__9 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject1;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject2;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000014")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x1F0A6CC", Offset = "0x1F0A6CC", VA = "0x1F0A6CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000015")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x1F0A714", Offset = "0x1F0A714", VA = "0x1F0A714", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1F0A414", Offset = "0x1F0A414", VA = "0x1F0A414")]
		[DebuggerHidden]
		public <PauseWith>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1F0A440", Offset = "0x1F0A440", VA = "0x1F0A440", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1F0A444", Offset = "0x1F0A444", VA = "0x1F0A444", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1F0A6D4", Offset = "0x1F0A6D4", VA = "0x1F0A6D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47E38", Offset = "0xC47E38")]
	private sealed class <PauseWith>d__10<T> : IEnumerator<float>, IEnumerator, IDisposable where T : MonoBehaviour
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T script;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GameObject <myGO>5__2;

		[Token(Token = "0x17000016")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000071")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000073")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006E")]
		[DebuggerHidden]
		public <PauseWith>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x600006F")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000070")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000072")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47E48", Offset = "0xC47E48")]
	private sealed class <PauseWith>d__11 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000018")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x1F0A04C", Offset = "0x1F0A04C", VA = "0x1F0A04C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x1F0A094", Offset = "0x1F0A094", VA = "0x1F0A094", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1F09DF4", Offset = "0x1F09DF4", VA = "0x1F09DF4")]
		[DebuggerHidden]
		public <PauseWith>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1F09E20", Offset = "0x1F09E20", VA = "0x1F09E20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1F09E24", Offset = "0x1F09E24", VA = "0x1F09E24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1F0A054", Offset = "0x1F0A054", VA = "0x1F0A054", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47E58", Offset = "0xC47E58")]
	private sealed class <KillWith>d__12 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CoroutineHandle otherCoroutine;

		[Token(Token = "0x1700001A")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x1F09D4C", Offset = "0x1F09D4C", VA = "0x1F09D4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x1F09D94", Offset = "0x1F09D94", VA = "0x1F09D94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1F09BB4", Offset = "0x1F09BB4", VA = "0x1F09BB4")]
		[DebuggerHidden]
		public <KillWith>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1F09BE0", Offset = "0x1F09BE0", VA = "0x1F09BE0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1F09BE4", Offset = "0x1F09BE4", VA = "0x1F09BE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1F09D54", Offset = "0x1F09D54", VA = "0x1F09D54", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47E68", Offset = "0xC47E68")]
	private sealed class <Append>d__13 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> nextCoroutine;

		[Token(Token = "0x1700001C")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x1F08584", Offset = "0x1F08584", VA = "0x1F08584", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x1F085CC", Offset = "0x1F085CC", VA = "0x1F085CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1F082DC", Offset = "0x1F082DC", VA = "0x1F082DC")]
		[DebuggerHidden]
		public <Append>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1F08308", Offset = "0x1F08308", VA = "0x1F08308", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1F0830C", Offset = "0x1F0830C", VA = "0x1F0830C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1F0858C", Offset = "0x1F0858C", VA = "0x1F0858C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47E78", Offset = "0xC47E78")]
	private sealed class <Append>d__14 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action onDone;

		[Token(Token = "0x1700001E")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x1F087C4", Offset = "0x1F087C4", VA = "0x1F087C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x1F0880C", Offset = "0x1F0880C", VA = "0x1F0880C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1F0862C", Offset = "0x1F0862C", VA = "0x1F0862C")]
		[DebuggerHidden]
		public <Append>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1F08658", Offset = "0x1F08658", VA = "0x1F08658", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1F0865C", Offset = "0x1F0865C", VA = "0x1F0865C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1F087CC", Offset = "0x1F087CC", VA = "0x1F087CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47E88", Offset = "0xC47E88")]
	private sealed class <Prepend>d__15 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> lastCoroutine;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000020")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x1F0AA30", Offset = "0x1F0AA30", VA = "0x1F0AA30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x1F0AA78", Offset = "0x1F0AA78", VA = "0x1F0AA78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1F0A774", Offset = "0x1F0A774", VA = "0x1F0A774")]
		[DebuggerHidden]
		public <Prepend>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1F0A7A0", Offset = "0x1F0A7A0", VA = "0x1F0A7A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1F0A7A4", Offset = "0x1F0A7A4", VA = "0x1F0A7A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1F0AA38", Offset = "0x1F0AA38", VA = "0x1F0AA38", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47E98", Offset = "0xC47E98")]
	private sealed class <Prepend>d__16 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onStart;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000022")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x1F0AC80", Offset = "0x1F0AC80", VA = "0x1F0AC80", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x1F0ACC8", Offset = "0x1F0ACC8", VA = "0x1F0ACC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1F0AAD8", Offset = "0x1F0AAD8", VA = "0x1F0AAD8")]
		[DebuggerHidden]
		public <Prepend>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1F0AB04", Offset = "0x1F0AB04", VA = "0x1F0AB04", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1F0AB08", Offset = "0x1F0AB08", VA = "0x1F0AB08", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1F0AC88", Offset = "0x1F0AC88", VA = "0x1F0AC88", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47EA8", Offset = "0xC47EA8")]
	private sealed class <Superimpose>d__18 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutineA;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Timing instance;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> coroutineB;

		[Token(Token = "0x17000024")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x1F0B63C", Offset = "0x1F0B63C", VA = "0x1F0B63C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x1F0B684", Offset = "0x1F0B684", VA = "0x1F0B684", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1F0AFF4", Offset = "0x1F0AFF4", VA = "0x1F0AFF4")]
		[DebuggerHidden]
		public <Superimpose>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1F0B020", Offset = "0x1F0B020", VA = "0x1F0B020", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1F0B024", Offset = "0x1F0B024", VA = "0x1F0B024", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1F0B644", Offset = "0x1F0B644", VA = "0x1F0B644", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47EB8", Offset = "0xC47EB8")]
	private sealed class <Hijack>d__19 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<float, float> newReturn;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000026")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x1F09B0C", Offset = "0x1F09B0C", VA = "0x1F09B0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x1F09B54", Offset = "0x1F09B54", VA = "0x1F09B54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1F0993C", Offset = "0x1F0993C", VA = "0x1F0993C")]
		[DebuggerHidden]
		public <Hijack>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1F09968", Offset = "0x1F09968", VA = "0x1F09968", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1F0996C", Offset = "0x1F0996C", VA = "0x1F0996C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1F09B14", Offset = "0x1F09B14", VA = "0x1F09B14", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47EC8", Offset = "0xC47EC8")]
	private sealed class <RerouteExceptions>d__20 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<Exception> exceptionHandler;

		[Token(Token = "0x17000028")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x1F0AF4C", Offset = "0x1F0AF4C", VA = "0x1F0AF4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x1F0AF94", Offset = "0x1F0AF94", VA = "0x1F0AF94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1F0AD28", Offset = "0x1F0AD28", VA = "0x1F0AD28")]
		[DebuggerHidden]
		public <RerouteExceptions>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1F0AD54", Offset = "0x1F0AD54", VA = "0x1F0AD54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1F0AD58", Offset = "0x1F0AD58", VA = "0x1F0AD58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1F0AF54", Offset = "0x1F0AF54", VA = "0x1F0AF54", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1465438", Offset = "0x1465438", VA = "0x1465438")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A1D4", Offset = "0xC4A1D4")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, float timeToDelay)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x14654B4", Offset = "0x14654B4", VA = "0x14654B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A244", Offset = "0xC4A244")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A2B4", Offset = "0xC4A2B4")]
	public static IEnumerator<float> Delay<T>(this IEnumerator<float> coroutine, T data, Func<T, bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x146552C", Offset = "0x146552C", VA = "0x146552C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A324", Offset = "0xC4A324")]
	public static IEnumerator<float> DelayFrames(this IEnumerator<float> coroutine, int framesToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x14655A8", Offset = "0x14655A8", VA = "0x14655A8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A394", Offset = "0xC4A394")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1465620", Offset = "0x1465620", VA = "0x1465620")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A404", Offset = "0xC4A404")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A474", Offset = "0xC4A474")]
	public static IEnumerator<float> CancelWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x14656A0", Offset = "0x14656A0", VA = "0x14656A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A4E4", Offset = "0xC4A4E4")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1465718", Offset = "0x1465718", VA = "0x1465718")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A554", Offset = "0xC4A554")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1465790", Offset = "0x1465790", VA = "0x1465790")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A5C4", Offset = "0xC4A5C4")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A634", Offset = "0xC4A634")]
	public static IEnumerator<float> PauseWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1465810", Offset = "0x1465810", VA = "0x1465810")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A6A4", Offset = "0xC4A6A4")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1465888", Offset = "0x1465888", VA = "0x1465888")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A714", Offset = "0xC4A714")]
	public static IEnumerator<float> KillWith(this IEnumerator<float> coroutine, CoroutineHandle otherCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1465904", Offset = "0x1465904", VA = "0x1465904")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A784", Offset = "0xC4A784")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, IEnumerator<float> nextCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x146597C", Offset = "0x146597C", VA = "0x146597C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A7F4", Offset = "0xC4A7F4")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x14659F4", Offset = "0x14659F4", VA = "0x14659F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A864", Offset = "0xC4A864")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, IEnumerator<float> lastCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1465A6C", Offset = "0x1465A6C", VA = "0x1465A6C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A8D4", Offset = "0xC4A8D4")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, Action onStart)
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1465AE4", Offset = "0x1465AE4", VA = "0x1465AE4")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1465B60", Offset = "0x1465B60", VA = "0x1465B60")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A954", Offset = "0xC4A954")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB, Timing instance)
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1465BE0", Offset = "0x1465BE0", VA = "0x1465BE0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4A9C4", Offset = "0xC4A9C4")]
	public static IEnumerator<float> Hijack(this IEnumerator<float> coroutine, Func<float, float> newReturn)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1465C58", Offset = "0x1465C58", VA = "0x1465C58")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4AA34", Offset = "0xC4AA34")]
	public static IEnumerator<float> RerouteExceptions(this IEnumerator<float> coroutine, Action<Exception> exceptionHandler)
	{
		return null;
	}
}
namespace Crosstales
{
	[Token(Token = "0x200001D")]
	public static class ExtensionMethods
	{
		[Token(Token = "0x200001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47EE8", Offset = "0xC47EE8")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string str;

			[Token(Token = "0x6000120")]
			[Address(RVA = "0x1F07FF0", Offset = "0x1F07FF0", VA = "0x1F07FF0")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000121")]
			[Address(RVA = "0x1F07FF8", Offset = "0x1F07FF8", VA = "0x1F07FF8")]
			internal bool <CTContainsAny>b__0(string searchTerm)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200001F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47EF8", Offset = "0xC47EF8")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string str;

			[Token(Token = "0x6000122")]
			[Address(RVA = "0x1F08074", Offset = "0x1F08074", VA = "0x1F08074")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000123")]
			[Address(RVA = "0x1F0807C", Offset = "0x1F0807C", VA = "0x1F0807C")]
			internal bool <CTContainsAll>b__0(string searchTerm)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47F08", Offset = "0xC47F08")]
		private sealed class <>c__54<T>
		{
			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__54<T> <>9;

			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<T, string> <>9__54_0;

			[Token(Token = "0x6000125")]
			public <>c__54()
			{
			}

			[Token(Token = "0x6000126")]
			internal string <CTToString>b__54_0(T element)
			{
				return null;
			}
		}

		[Token(Token = "0x2000021")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47F18", Offset = "0xC47F18")]
		private sealed class <>c__DisplayClass81_0
		{
			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float uiScaleFactor;

			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<RectTransform, Bounds> <>9__0;

			[Token(Token = "0x6000127")]
			[Address(RVA = "0x1F080F8", Offset = "0x1F080F8", VA = "0x1F080F8")]
			public <>c__DisplayClass81_0()
			{
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x1F08100", Offset = "0x1F08100", VA = "0x1F08100")]
			internal Bounds <CTGetBounds>b__0(RectTransform child)
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 flat;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1450850", Offset = "0x1450850", VA = "0x1450850")]
		public static string CTToTitleCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x145B8FC", Offset = "0x145B8FC", VA = "0x145B8FC")]
		public static string CTReverse(this string str)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x145B93C", Offset = "0x145B93C", VA = "0x145B93C")]
		public static string CTReplace(this string str, string oldString, string newString, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1451F3C", Offset = "0x1451F3C", VA = "0x1451F3C")]
		public static bool CTEquals(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x145B9D4", Offset = "0x145B9D4", VA = "0x145B9D4")]
		public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x145B9F8", Offset = "0x145B9F8", VA = "0x145B9F8")]
		public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x145BB70", Offset = "0x145BB70", VA = "0x145BB70")]
		public static bool CTContainsAll(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x145BCE8", Offset = "0x145BCE8", VA = "0x145BCE8")]
		public static string CTRemoveNewLines(this string str, string replacement = "#nl#", [Optional] string newLine)
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x145BD48", Offset = "0x145BD48", VA = "0x145BD48")]
		public static string CTAddNewLines(this string str, string replacement = "#nl#", [Optional] string newLine)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x145BDF8", Offset = "0x145BDF8", VA = "0x145BDF8")]
		public static bool CTisNumeric(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x145BE80", Offset = "0x145BE80", VA = "0x145BE80")]
		public static bool CTisInteger(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x145BF04", Offset = "0x145BF04", VA = "0x145BF04")]
		public static bool CTisEmail(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x145BF90", Offset = "0x145BF90", VA = "0x145BF90")]
		public static bool CTisWebsite(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x145C01C", Offset = "0x145C01C", VA = "0x145C01C")]
		public static bool CTisCreditcard(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x145C0A8", Offset = "0x145C0A8", VA = "0x145C0A8")]
		public static bool CTisIPv4(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x145C134", Offset = "0x145C134", VA = "0x145C134")]
		public static bool CTisAlphanumeric(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x145C1C0", Offset = "0x145C1C0", VA = "0x145C1C0")]
		public static bool CThasLineEndings(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x145C24C", Offset = "0x145C24C", VA = "0x145C24C")]
		public static bool CThasInvalidChars(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x144F674", Offset = "0x144F674", VA = "0x144F674")]
		public static bool CTStartsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x145C2D8", Offset = "0x145C2D8", VA = "0x145C2D8")]
		public static bool CTEndsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x145C33C", Offset = "0x145C33C", VA = "0x145C33C")]
		public static int CTLastIndexOf(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x145C3E8", Offset = "0x145C3E8", VA = "0x145C3E8")]
		public static int CTIndexOf(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x145C494", Offset = "0x145C494", VA = "0x145C494")]
		public static int CTIndexOf(this string str, string toCheck, int startIndex, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x145C548", Offset = "0x145C548", VA = "0x145C548")]
		public static string CTToBase64(this string str, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x145C674", Offset = "0x145C674", VA = "0x145C674")]
		public static string CTFromBase64(this string str, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x145C728", Offset = "0x145C728", VA = "0x145C728")]
		public static byte[] CTFromBase64ToByteArray(this string str)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x145C7A0", Offset = "0x145C7A0", VA = "0x145C7A0")]
		public static string CTToHex(this string str, bool addPrefix = false)
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x145C904", Offset = "0x145C904", VA = "0x145C904")]
		public static string CTHexToString(this string hexString)
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x145CAFC", Offset = "0x145CAFC", VA = "0x145CAFC")]
		public static Color32 CTHexToColor32(this string hexString)
		{
			return default(Color32);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x145CD94", Offset = "0x145CD94", VA = "0x145CD94")]
		public static Color CTHexToColor(this string hexString)
		{
			return default(Color);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x145CE00", Offset = "0x145CE00", VA = "0x145CE00")]
		public static byte[] CTToByteArray(this string str, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x144F128", Offset = "0x144F128", VA = "0x144F128")]
		public static string CTClearTags(this string str)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x144F240", Offset = "0x144F240", VA = "0x144F240")]
		public static string CTClearSpaces(this string str)
		{
			return null;
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x144F350", Offset = "0x144F350", VA = "0x144F350")]
		public static string CTClearLineEndings(this string str)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		public static void CTShuffle<T>(this T[] array, int seed = 0)
		{
		}

		[Token(Token = "0x60000CD")]
		public static string CTDump<T>(this T[] array, string prefix = "", string postfix = "", bool appendNewLine = true, string delimiter = "; ")
		{
			return null;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x145CE58", Offset = "0x145CE58", VA = "0x145CE58")]
		public static string CTDump(this Quaternion[] array)
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x145D008", Offset = "0x145D008", VA = "0x145D008")]
		public static string CTDump(this Vector2[] array)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x145D168", Offset = "0x145D168", VA = "0x145D168")]
		public static string CTDump(this Vector3[] array)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x145D2F8", Offset = "0x145D2F8", VA = "0x145D2F8")]
		public static string CTDump(this Vector4[] array)
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		public static string[] CTToString<T>(this T[] array)
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x145D4A8", Offset = "0x145D4A8", VA = "0x145D4A8")]
		public static float[] CTToFloatArray(this byte[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x145D654", Offset = "0x145D654", VA = "0x145D654")]
		public static byte[] CTToByteArray(this float[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x145D7AC", Offset = "0x145D7AC", VA = "0x145D7AC")]
		public static Texture2D CTToTexture(this byte[] data)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x145D86C", Offset = "0x145D86C", VA = "0x145D86C")]
		public static Sprite CTToSprite(this byte[] data)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x145D9C8", Offset = "0x145D9C8", VA = "0x145D9C8")]
		public static string CTToString(this byte[] data, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x145C5FC", Offset = "0x145C5FC", VA = "0x145C5FC")]
		public static string CTToBase64(this byte[] data)
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		public static void CTShuffle<T>(this IList<T> list, int seed = 0)
		{
		}

		[Token(Token = "0x60000DA")]
		public static string CTDump<T>(this IList<T> list, string prefix = "", string postfix = "", bool appendNewLine = true, string delimiter = "; ")
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x145DA20", Offset = "0x145DA20", VA = "0x145DA20")]
		public static string CTDump(this IList<Quaternion> list)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x145DE08", Offset = "0x145DE08", VA = "0x145DE08")]
		public static string CTDump(this IList<Vector2> list)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x145E190", Offset = "0x145E190", VA = "0x145E190")]
		public static string CTDump(this IList<Vector3> list)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x145E554", Offset = "0x145E554", VA = "0x145E554")]
		public static string CTDump(this IList<Vector4> list)
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		public static List<string> CTToString<T>(this IList<T> list)
		{
			return null;
		}

		[Token(Token = "0x60000E0")]
		public static string CTDump<K, V>(this IDictionary<K, V> dict, string prefix = "", string postfix = "", bool appendNewLine = true, string delimiter = "; ")
		{
			return null;
		}

		[Token(Token = "0x60000E1")]
		public static void CTAddRange<K, V>(this IDictionary<K, V> dict, IDictionary<K, V> collection)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x145E93C", Offset = "0x145E93C", VA = "0x145E93C")]
		public static byte[] CTReadFully(this Stream input)
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x145EB0C", Offset = "0x145EB0C", VA = "0x145EB0C")]
		public static string CTToHexRGB(this Color32 input)
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x145EBA8", Offset = "0x145EBA8", VA = "0x145EBA8")]
		public static string CTToHexRGB(this Color input)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x145EBB0", Offset = "0x145EBB0", VA = "0x145EBB0")]
		public static string CTToHexRGBA(this Color32 input)
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x145EC4C", Offset = "0x145EC4C", VA = "0x145EC4C")]
		public static string CTToHexRGBA(this Color input)
		{
			return null;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x145EC54", Offset = "0x145EC54", VA = "0x145EC54")]
		public static Vector3 CTVector3(this Color32 color)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x145ECE4", Offset = "0x145ECE4", VA = "0x145ECE4")]
		public static Vector3 CTVector3(this Color color)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x145ECE8", Offset = "0x145ECE8", VA = "0x145ECE8")]
		public static Vector4 CTVector4(this Color32 color)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1453A64", Offset = "0x1453A64", VA = "0x1453A64")]
		public static Vector4 CTVector4(this Color color)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x145ED80", Offset = "0x145ED80", VA = "0x145ED80")]
		public static Vector2 CTMultiply(this Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x145ED8C", Offset = "0x145ED8C", VA = "0x145ED8C")]
		public static Vector3 CTMultiply(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x145ED9C", Offset = "0x145ED9C", VA = "0x145ED9C")]
		public static Vector3 CTFlatten(this Vector3 a)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x145EE2C", Offset = "0x145EE2C", VA = "0x145EE2C")]
		public static Quaternion CTQuaternion(this Vector3 eulerAngle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x145EE34", Offset = "0x145EE34", VA = "0x145EE34")]
		public static Color CTColorRGB(this Vector3 rgb, float alpha = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x145EEC8", Offset = "0x145EEC8", VA = "0x145EEC8")]
		public static Vector4 CTMultiply(this Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x14530CC", Offset = "0x14530CC", VA = "0x14530CC")]
		public static Quaternion CTQuaternion(this Vector4 angle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1453190", Offset = "0x1453190", VA = "0x1453190")]
		public static Color CTColorRGBA(this Vector4 rgba)
		{
			return default(Color);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x145EF08", Offset = "0x145EF08", VA = "0x145EF08")]
		public static Vector3 CTVector3(this Quaternion angle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x14539A0", Offset = "0x14539A0", VA = "0x14539A0")]
		public static Vector4 CTVector4(this Quaternion angle)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x145EF34", Offset = "0x145EF34", VA = "0x145EF34")]
		public static Vector3 CTCorrectLossyScale(this Canvas canvas)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x145F13C", Offset = "0x145F13C", VA = "0x145F13C")]
		public static void CTGetLocalCorners(this RectTransform transform, Vector3[] fourCornersArray, Canvas canvas, float inset = 0f, bool corrected = false)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x145F3D4", Offset = "0x145F3D4", VA = "0x145F3D4")]
		public static Vector3[] CTGetLocalCorners(this RectTransform transform, Canvas canvas, float inset = 0f, bool corrected = false)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x145F490", Offset = "0x145F490", VA = "0x145F490")]
		public static void CTGetScreenCorners(this RectTransform transform, Vector3[] fourCornersArray, Canvas canvas, float inset = 0f, bool corrected = false)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x145F798", Offset = "0x145F798", VA = "0x145F798")]
		public static Vector3[] CTGetScreenCorners(this RectTransform transform, Canvas canvas, float inset = 0f, bool corrected = false)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x145F854", Offset = "0x145F854", VA = "0x145F854")]
		public static Bounds CTGetBounds(this RectTransform transform, float uiScaleFactor = 1f)
		{
			return default(Bounds);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x145FD64", Offset = "0x145FD64", VA = "0x145FD64")]
		public static void CTSetLeft(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x145FE48", Offset = "0x145FE48", VA = "0x145FE48")]
		public static void CTSetRight(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x145FF2C", Offset = "0x145FF2C", VA = "0x145FF2C")]
		public static void CTSetTop(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1460010", Offset = "0x1460010", VA = "0x1460010")]
		public static void CTSetBottom(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x14600F4", Offset = "0x14600F4", VA = "0x14600F4")]
		public static float CTGetLeft(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x14601BC", Offset = "0x14601BC", VA = "0x14601BC")]
		public static float CTGetRight(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1460284", Offset = "0x1460284", VA = "0x1460284")]
		public static float CTGetTop(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1460354", Offset = "0x1460354", VA = "0x1460354")]
		public static float CTGetBottom(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1460424", Offset = "0x1460424", VA = "0x1460424")]
		public static Vector4 CTGetLRTB(this RectTransform transform)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1460554", Offset = "0x1460554", VA = "0x1460554")]
		public static void CTSetLRTB(this RectTransform transform, Vector4 lrtb)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1460658", Offset = "0x1460658", VA = "0x1460658")]
		public static GameObject CTFind(this MonoBehaviour mb, string name)
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		public static T CTFind<T>(this MonoBehaviour mb, string name)
		{
			return (T)null;
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1460894", Offset = "0x1460894", VA = "0x1460894")]
		public static GameObject CTFind(this GameObject go, string name)
		{
			return null;
		}

		[Token(Token = "0x6000108")]
		public static T CTFind<T>(this GameObject go, string name)
		{
			return (T)null;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x14609B4", Offset = "0x14609B4", VA = "0x14609B4")]
		public static Bounds CTGetBounds(this GameObject go)
		{
			return default(Bounds);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1460778", Offset = "0x1460778", VA = "0x1460778")]
		public static Transform CTFind(this Transform transform, string name)
		{
			return null;
		}

		[Token(Token = "0x600010B")]
		public static T CTFind<T>(this Transform transform, string name)
		{
			return (T)null;
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1460F64", Offset = "0x1460F64", VA = "0x1460F64")]
		public static byte[] CTToPNG(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1461128", Offset = "0x1461128", VA = "0x1461128")]
		public static byte[] CTToJPG(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x14612EC", Offset = "0x14612EC", VA = "0x14612EC")]
		public static byte[] CTToTGA(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x14614B0", Offset = "0x14614B0", VA = "0x14614B0")]
		public static byte[] CTToEXR(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1461068", Offset = "0x1461068", VA = "0x1461068")]
		public static byte[] CTToPNG(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x146122C", Offset = "0x146122C", VA = "0x146122C")]
		public static byte[] CTToJPG(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x14613F0", Offset = "0x14613F0", VA = "0x14613F0")]
		public static byte[] CTToTGA(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x14615B4", Offset = "0x14615B4", VA = "0x14615B4")]
		public static byte[] CTToEXR(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1461674", Offset = "0x1461674", VA = "0x1461674")]
		public static Sprite CTToSprite(this Texture2D texture, float pixelsPerUnit = 100f)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x14617AC", Offset = "0x14617AC", VA = "0x14617AC")]
		public static Texture2D CTRotate90(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1461B18", Offset = "0x1461B18", VA = "0x1461B18")]
		public static Texture2D CTRotate180(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1461D4C", Offset = "0x1461D4C", VA = "0x1461D4C")]
		public static Texture2D CTRotate270(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1462038", Offset = "0x1462038", VA = "0x1462038")]
		public static Texture2D CTToTexture2D(this Texture texture)
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1462150", Offset = "0x1462150", VA = "0x1462150")]
		public static Texture2D CTFlipHorizontal(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x146229C", Offset = "0x146229C", VA = "0x146229C")]
		public static Texture2D CTFlipVertical(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x144EFA4", Offset = "0x144EFA4", VA = "0x144EFA4")]
		public static bool CTHasActiveClip(this AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x14623EC", Offset = "0x14623EC", VA = "0x14623EC")]
		public static bool CTIsVisibleFrom(this Renderer renderer, Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1460BD0", Offset = "0x1460BD0", VA = "0x1460BD0")]
		private static Transform deepSearch(Transform parent, string name)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x145D638", Offset = "0x145D638", VA = "0x145D638")]
		private static float bytesToFloat(byte firstByte, byte secondByte)
		{
			return default(float);
		}
	}
}
namespace Crosstales.OnlineCheck
{
	[Serializable]
	[Token(Token = "0x2000022")]
	public class StatusChangeEvent : UnityEvent<bool>
	{
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x19CC59C", Offset = "0x19CC59C", VA = "0x19CC59C")]
		public StatusChangeEvent()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xC47F28", Offset = "0xC47F28")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class OnlineCheck : Singleton<OnlineCheck>
	{
		[Token(Token = "0x2000024")]
		public delegate void OnlineStatusChange(bool isConnected);

		[Token(Token = "0x2000025")]
		public delegate void NetworkReachabilityChange(NetworkReachability networkReachability);

		[Token(Token = "0x2000026")]
		public delegate void OnlineCheckComplete(bool isConnected, NetworkReachability networkReachability);

		[Token(Token = "0x2000027")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47F84", Offset = "0xC47F84")]
		private sealed class <RefreshYield>d__129 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OnlineCheck <>4__this;

			[Token(Token = "0x40000A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool triggerCallbacks;

			[Token(Token = "0x1700003D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000176")]
				[Address(RVA = "0x1F0BA84", Offset = "0x1F0BA84", VA = "0x1F0BA84", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000178")]
				[Address(RVA = "0x1F0BACC", Offset = "0x1F0BACC", VA = "0x1F0BACC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000173")]
			[Address(RVA = "0x1F0B938", Offset = "0x1F0B938", VA = "0x1F0B938")]
			[DebuggerHidden]
			public <RefreshYield>d__129(int <>1__state)
			{
			}

			[Token(Token = "0x6000174")]
			[Address(RVA = "0x1F0B964", Offset = "0x1F0B964", VA = "0x1F0B964", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000175")]
			[Address(RVA = "0x1F0B968", Offset = "0x1F0B968", VA = "0x1F0B968", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000177")]
			[Address(RVA = "0x1F0BA8C", Offset = "0x1F0BA8C", VA = "0x1F0BA8C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000028")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47F94", Offset = "0xC47F94")]
		private sealed class <wwwCheck>d__131 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OnlineCheck <>4__this;

			[Token(Token = "0x40000AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x40000AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool equals;

			[Token(Token = "0x40000AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string data;

			[Token(Token = "0x40000AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int header;

			[Token(Token = "0x40000B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool showError;

			[Token(Token = "0x40000B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string type;

			[Token(Token = "0x40000B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x1700003F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600017D")]
				[Address(RVA = "0x1F0E460", Offset = "0x1F0E460", VA = "0x1F0E460", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000040")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600017F")]
				[Address(RVA = "0x1F0E4A8", Offset = "0x1F0E4A8", VA = "0x1F0E4A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000179")]
			[Address(RVA = "0x1F0DEC4", Offset = "0x1F0DEC4", VA = "0x1F0DEC4")]
			[DebuggerHidden]
			public <wwwCheck>d__131(int <>1__state)
			{
			}

			[Token(Token = "0x600017A")]
			[Address(RVA = "0x1F0DEF0", Offset = "0x1F0DEF0", VA = "0x1F0DEF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600017B")]
			[Address(RVA = "0x1F0DFC8", Offset = "0x1F0DFC8", VA = "0x1F0DFC8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600017C")]
			[Address(RVA = "0x1F0DF0C", Offset = "0x1F0DF0C", VA = "0x1F0DF0C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600017E")]
			[Address(RVA = "0x1F0E468", Offset = "0x1F0E468", VA = "0x1F0E468", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000029")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47FA4", Offset = "0xC47FA4")]
		private sealed class <google204Check>d__132 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OnlineCheck <>4__this;

			[Token(Token = "0x40000B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool showError;

			[Token(Token = "0x40000B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string <url>5__2;

			[Token(Token = "0x40000B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest <www>5__3;

			[Token(Token = "0x17000041")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000184")]
				[Address(RVA = "0x1F0BF94", Offset = "0x1F0BF94", VA = "0x1F0BF94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000042")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000186")]
				[Address(RVA = "0x1F0BFDC", Offset = "0x1F0BFDC", VA = "0x1F0BFDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000180")]
			[Address(RVA = "0x1F0BAD4", Offset = "0x1F0BAD4", VA = "0x1F0BAD4")]
			[DebuggerHidden]
			public <google204Check>d__132(int <>1__state)
			{
			}

			[Token(Token = "0x6000181")]
			[Address(RVA = "0x1F0BB00", Offset = "0x1F0BB00", VA = "0x1F0BB00", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000182")]
			[Address(RVA = "0x1F0BBD8", Offset = "0x1F0BBD8", VA = "0x1F0BBD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000183")]
			[Address(RVA = "0x1F0BB1C", Offset = "0x1F0BB1C", VA = "0x1F0BB1C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000185")]
			[Address(RVA = "0x1F0BF9C", Offset = "0x1F0BF9C", VA = "0x1F0BF9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47FB4", Offset = "0xC47FB4")]
		private sealed class <googleBlankCheck>d__133 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OnlineCheck <>4__this;

			[Token(Token = "0x40000BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool showError;

			[Token(Token = "0x40000BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x17000043")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600018B")]
				[Address(RVA = "0x1F0C4B0", Offset = "0x1F0C4B0", VA = "0x1F0C4B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000044")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600018D")]
				[Address(RVA = "0x1F0C4F8", Offset = "0x1F0C4F8", VA = "0x1F0C4F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000187")]
			[Address(RVA = "0x1F0BFE4", Offset = "0x1F0BFE4", VA = "0x1F0BFE4")]
			[DebuggerHidden]
			public <googleBlankCheck>d__133(int <>1__state)
			{
			}

			[Token(Token = "0x6000188")]
			[Address(RVA = "0x1F0C010", Offset = "0x1F0C010", VA = "0x1F0C010", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000189")]
			[Address(RVA = "0x1F0C0E8", Offset = "0x1F0C0E8", VA = "0x1F0C0E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600018A")]
			[Address(RVA = "0x1F0C02C", Offset = "0x1F0C02C", VA = "0x1F0C02C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600018C")]
			[Address(RVA = "0x1F0C4B8", Offset = "0x1F0C4B8", VA = "0x1F0C4B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200002B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47FC4", Offset = "0xC47FC4")]
		private sealed class <>c__DisplayClass135_0
		{
			[Token(Token = "0x40000BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public OnlineCheck <>4__this;

			[Token(Token = "0x40000BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string url;

			[Token(Token = "0x40000C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string data;

			[Token(Token = "0x40000C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool equals;

			[Token(Token = "0x40000C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string type;

			[Token(Token = "0x40000C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int header;

			[Token(Token = "0x40000C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool showError;

			[Token(Token = "0x600018E")]
			[Address(RVA = "0x1F0B8E8", Offset = "0x1F0B8E8", VA = "0x1F0B8E8")]
			public <>c__DisplayClass135_0()
			{
			}

			[Token(Token = "0x600018F")]
			[Address(RVA = "0x1F0B8F0", Offset = "0x1F0B8F0", VA = "0x1F0B8F0")]
			internal void <startWorker>b__0()
			{
			}
		}

		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47FD4", Offset = "0xC47FD4")]
		private sealed class <startWorker>d__135 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OnlineCheck <>4__this;

			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x40000C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string data;

			[Token(Token = "0x40000CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool equals;

			[Token(Token = "0x40000CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string type;

			[Token(Token = "0x40000CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int header;

			[Token(Token = "0x40000CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool showError;

			[Token(Token = "0x17000045")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000193")]
				[Address(RVA = "0x1F0DE74", Offset = "0x1F0DE74", VA = "0x1F0DE74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000046")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000195")]
				[Address(RVA = "0x1F0DEBC", Offset = "0x1F0DEBC", VA = "0x1F0DEBC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000190")]
			[Address(RVA = "0x1F0DCB4", Offset = "0x1F0DCB4", VA = "0x1F0DCB4")]
			[DebuggerHidden]
			public <startWorker>d__135(int <>1__state)
			{
			}

			[Token(Token = "0x6000191")]
			[Address(RVA = "0x1F0DCE0", Offset = "0x1F0DCE0", VA = "0x1F0DCE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000192")]
			[Address(RVA = "0x1F0DCE4", Offset = "0x1F0DCE4", VA = "0x1F0DCE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000194")]
			[Address(RVA = "0x1F0DE7C", Offset = "0x1F0DE7C", VA = "0x1F0DE7C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200002D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47FE4", Offset = "0xC47FE4")]
		private sealed class <internetCheck>d__136 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OnlineCheck <>4__this;

			[Token(Token = "0x17000047")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000199")]
				[Address(RVA = "0x1F0DC64", Offset = "0x1F0DC64", VA = "0x1F0DC64", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000048")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600019B")]
				[Address(RVA = "0x1F0DCAC", Offset = "0x1F0DCAC", VA = "0x1F0DCAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1F0C500", Offset = "0x1F0C500", VA = "0x1F0C500")]
			[DebuggerHidden]
			public <internetCheck>d__136(int <>1__state)
			{
			}

			[Token(Token = "0x6000197")]
			[Address(RVA = "0x1F0C52C", Offset = "0x1F0C52C", VA = "0x1F0C52C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000198")]
			[Address(RVA = "0x1F0C530", Offset = "0x1F0C530", VA = "0x1F0C530", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600019A")]
			[Address(RVA = "0x1F0DC6C", Offset = "0x1F0DC6C", VA = "0x1F0DC6C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC486E4", Offset = "0xC486E4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xC486E4", Offset = "0xC486E4")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC486E4", Offset = "0xC486E4")]
		private bool endlessMode;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC48778", Offset = "0xC48778")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48778", Offset = "0xC48778")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xC48778", Offset = "0xC48778")]
		[SerializeField]
		private int intervalMin;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC48804", Offset = "0xC48804")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xC48804", Offset = "0xC48804")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48804", Offset = "0xC48804")]
		private int intervalMax;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xC48890", Offset = "0xC48890")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48890", Offset = "0xC48890")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC48890", Offset = "0xC48890")]
		[SerializeField]
		private int timeout;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48918", Offset = "0xC48918")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xC48918", Offset = "0xC48918")]
		[SerializeField]
		private bool forceWWW;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xC48988", Offset = "0xC48988")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0xC48988", Offset = "0xC48988")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48988", Offset = "0xC48988")]
		[SerializeField]
		private CustomCheck customCheck;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48A38", Offset = "0xC48A38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC48A38", Offset = "0xC48A38")]
		private bool microsoft;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48AA8", Offset = "0xC48AA8")]
		[SerializeField]
		private bool google204;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48AF4", Offset = "0xC48AF4")]
		[SerializeField]
		private bool googleBlank;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48B40", Offset = "0xC48B40")]
		[SerializeField]
		private bool apple;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48B8C", Offset = "0xC48B8C")]
		[SerializeField]
		private bool ubuntu;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xC48BD8", Offset = "0xC48BD8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC48BD8", Offset = "0xC48BD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48BD8", Offset = "0xC48BD8")]
		[SerializeField]
		private bool runOnStart;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC48C6C", Offset = "0xC48C6C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xC48C6C", Offset = "0xC48C6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48C6C", Offset = "0xC48C6C")]
		[SerializeField]
		private float delay;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool isFirsttime;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		private bool lastInternetAvailable;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private NetworkReachability lastNetworkReachability;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool isRunning;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float checkTime;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float checkTimeCounter;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float burstTime;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float burstTimeCounter;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool available;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private NetworkReachability networkReachability;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float lastCheckTime;

		[Token(Token = "0x4000082")]
		private const float burstIntervalMin = 2f;

		[Token(Token = "0x4000083")]
		private const float burstIntervalMax = 5f;

		[Token(Token = "0x4000084")]
		private const string microsoftUrl = "http://www.msftncsi.com/ncsi.txt";

		[Token(Token = "0x4000085")]
		private const string appleUrl = "https://www.apple.com/library/test/success.html";

		[Token(Token = "0x4000086")]
		private const string ubuntuUrl = "https://start.ubuntu.com/connectivity-check";

		[Token(Token = "0x4000087")]
		private const string fallbackUrl = "https://crosstales.com/media/downloads/up.txt";

		[Token(Token = "0x4000088")]
		private const int google204HeaderSize = 279;

		[Token(Token = "0x4000089")]
		private const int googleBlankHeaderSize = 831;

		[Token(Token = "0x400008A")]
		private const int microsoftHeaderSize = 170;

		[Token(Token = "0x400008B")]
		private const int appleHeaderSize = 376;

		[Token(Token = "0x400008C")]
		private const int ubuntuHeaderSize = 425;

		[Token(Token = "0x400008D")]
		private const int fallbackHeaderSize = 349;

		[Token(Token = "0x400008E")]
		private const string microsoftText = "Microsoft NCSI";

		[Token(Token = "0x400008F")]
		private const string appleText = "<TITLE>Success</TITLE>";

		[Token(Token = "0x4000090")]
		private const string ubuntuText = "<TITLE>Lorem Ipsum</TITLE>";

		[Token(Token = "0x4000091")]
		private const string fallbackText = "crosstales rulez!";

		[Token(Token = "0x4000092")]
		private const string windowsDesc = "Microsoft";

		[Token(Token = "0x4000093")]
		private const string appleDesc = "Apple";

		[Token(Token = "0x4000094")]
		private const string ubuntuDesc = "Ubuntu";

		[Token(Token = "0x4000095")]
		private const string fallbackDesc = "Fallback (crosstales)";

		[Token(Token = "0x4000096")]
		private const string customDesc = "custom URL";

		[Token(Token = "0x4000097")]
		private const string testingDesc = "Testing the Internet availability with:";

		[Token(Token = "0x4000098")]
		private const bool microsoftEquals = true;

		[Token(Token = "0x4000099")]
		private const bool appleEquals = false;

		[Token(Token = "0x400009A")]
		private const bool ubuntuEquals = false;

		[Token(Token = "0x400009B")]
		private const bool fallbackEquals = true;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Thread worker;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool existsCustomCheck;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48CF8", Offset = "0xC48CF8")]
		private bool <isInternetAvailable>k__BackingField;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48D08", Offset = "0xC48D08")]
		private DateTime <LastCheck>k__BackingField;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48D18", Offset = "0xC48D18")]
		private long <DataDownloaded>k__BackingField;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC48D28", Offset = "0xC48D28")]
		public StatusChangeEvent OnStatusChange;

		[Token(Token = "0x1700002A")]
		public bool EndlessMode
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x1468030", Offset = "0x1468030", VA = "0x1468030")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x1468038", Offset = "0x1468038", VA = "0x1468038")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public int IntervalMin
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x1468050", Offset = "0x1468050", VA = "0x1468050")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x1468070", Offset = "0x1468070", VA = "0x1468070")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public int IntervalMax
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x14680C0", Offset = "0x14680C0", VA = "0x14680C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x14680DC", Offset = "0x14680DC", VA = "0x14680DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public int Timeout
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x1468128", Offset = "0x1468128", VA = "0x1468128")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x1468148", Offset = "0x1468148", VA = "0x1468148")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public bool ForceWWW
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x1468198", Offset = "0x1468198", VA = "0x1468198")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x1468218", Offset = "0x1468218", VA = "0x1468218")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public CustomCheck CustomCheck
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x1468224", Offset = "0x1468224", VA = "0x1468224")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x146822C", Offset = "0x146822C", VA = "0x146822C")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool Google204
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x14682B0", Offset = "0x14682B0", VA = "0x14682B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x14682B8", Offset = "0x14682B8", VA = "0x14682B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public bool GoogleBlank
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x14682C4", Offset = "0x14682C4", VA = "0x14682C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x14682CC", Offset = "0x14682CC", VA = "0x14682CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public bool Microsoft
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x14682D8", Offset = "0x14682D8", VA = "0x14682D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x14682E0", Offset = "0x14682E0", VA = "0x14682E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public bool Apple
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x14682EC", Offset = "0x14682EC", VA = "0x14682EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x14682F4", Offset = "0x14682F4", VA = "0x14682F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public bool Ubuntu
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x1468300", Offset = "0x1468300", VA = "0x1468300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x1468308", Offset = "0x1468308", VA = "0x1468308")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public bool RunOnStart
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x1468314", Offset = "0x1468314", VA = "0x1468314")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x146831C", Offset = "0x146831C", VA = "0x146831C")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public float Delay
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1468328", Offset = "0x1468328", VA = "0x1468328")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x1468330", Offset = "0x1468330", VA = "0x1468330")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public bool isInternetAvailable
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x1468338", Offset = "0x1468338", VA = "0x1468338")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4B814", Offset = "0xC4B814")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x1468340", Offset = "0x1468340", VA = "0x1468340")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4B824", Offset = "0xC4B824")]
			private set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public NetworkReachability NetworkReachability
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x146834C", Offset = "0x146834C", VA = "0x146834C")]
			get
			{
				return default(NetworkReachability);
			}
		}

		[Token(Token = "0x17000039")]
		public string NetworkReachabilityShort
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x1468354", Offset = "0x1468354", VA = "0x1468354")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public DateTime LastCheck
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x14683D8", Offset = "0x14683D8", VA = "0x14683D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4B834", Offset = "0xC4B834")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x14683E0", Offset = "0x14683E0", VA = "0x14683E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4B844", Offset = "0xC4B844")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public long DataDownloaded
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x14683E8", Offset = "0x14683E8", VA = "0x14683E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4B854", Offset = "0xC4B854")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x14683F0", Offset = "0x14683F0", VA = "0x14683F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4B864", Offset = "0xC4B864")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public bool isBusy
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x14683F8", Offset = "0x14683F8", VA = "0x14683F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000001")]
		public event OnlineStatusChange OnOnlineStatusChange
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x1468400", Offset = "0x1468400", VA = "0x1468400")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4B874", Offset = "0xC4B874")]
			add
			{
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x14684A0", Offset = "0x14684A0", VA = "0x14684A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4B884", Offset = "0xC4B884")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event NetworkReachabilityChange OnNetworkReachabilityChange
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x1468540", Offset = "0x1468540", VA = "0x1468540")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4B894", Offset = "0xC4B894")]
			add
			{
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x14685E0", Offset = "0x14685E0", VA = "0x14685E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4B8A4", Offset = "0xC4B8A4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event OnlineCheckComplete OnOnlineCheckComplete
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x1468680", Offset = "0x1468680", VA = "0x1468680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4B8B4", Offset = "0xC4B8B4")]
			add
			{
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x1468720", Offset = "0x1468720", VA = "0x1468720")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4B8C4", Offset = "0xC4B8C4")]
			remove
			{
			}
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x14687C0", Offset = "0x14687C0", VA = "0x14687C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1468A2C", Offset = "0x1468A2C", VA = "0x1468A2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1468AD4", Offset = "0x1468AD4", VA = "0x1468AD4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1468E7C", Offset = "0x1468E7C", VA = "0x1468E7C", Slot = "6")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1468F7C", Offset = "0x1468F7C", VA = "0x1468F7C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1468FFC", Offset = "0x1468FFC", VA = "0x1468FFC")]
		public static void ResetObject()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x146906C", Offset = "0x146906C", VA = "0x146906C")]
		public void Refresh(bool triggerCallbacks = false)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1469164", Offset = "0x1469164", VA = "0x1469164")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4B8D4", Offset = "0xC4B8D4")]
		public IEnumerator RefreshYield(bool triggerCallbacks = false)
		{
			return null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x14691E4", Offset = "0x14691E4", VA = "0x14691E4")]
		private void run()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1469210", Offset = "0x1469210", VA = "0x1469210")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4B934", Offset = "0xC4B934")]
		private IEnumerator wwwCheck(string url, string data, bool equals, string type, int header, bool showError = false)
		{
			return null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x14692C8", Offset = "0x14692C8", VA = "0x14692C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4B994", Offset = "0xC4B994")]
		private IEnumerator google204Check(bool showError = false)
		{
			return null;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1469348", Offset = "0x1469348", VA = "0x1469348")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4B9F4", Offset = "0xC4B9F4")]
		private IEnumerator googleBlankCheck(bool showError = false)
		{
			return null;
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x14693C8", Offset = "0x14693C8", VA = "0x14693C8")]
		private void threadCheck(out bool _available, string url, string data, bool equals, string type, int header, bool showError = false)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1469874", Offset = "0x1469874", VA = "0x1469874")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4BA54", Offset = "0xC4BA54")]
		private IEnumerator startWorker(string url, string data, bool equals, string type, int header, bool showError = false)
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1468E10", Offset = "0x1468E10", VA = "0x1468E10")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4BAB4", Offset = "0xC4BAB4")]
		private IEnumerator internetCheck()
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x146992C", Offset = "0x146992C", VA = "0x146992C")]
		private static string URLAntiCacheRandomizer(string url)
		{
			return null;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x14699C8", Offset = "0x14699C8", VA = "0x14699C8")]
		private void onInternetStatusChange(bool isConnected)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1469B40", Offset = "0x1469B40", VA = "0x1469B40")]
		private void onNetworkReachabilityChange(NetworkReachability _networkReachability)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1469C5C", Offset = "0x1469C5C", VA = "0x1469C5C")]
		private void onInternetCheckComplete(bool isConnected, NetworkReachability _networkReachability)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1469DF0", Offset = "0x1469DF0", VA = "0x1469DF0")]
		public OnlineCheck()
		{
		}
	}
}
namespace Crosstales.OnlineCheck.Util
{
	[Token(Token = "0x200002E")]
	public class CTWebClientNotCached : CTWebClient
	{
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x14540D4", Offset = "0x14540D4", VA = "0x14540D4")]
		public CTWebClientNotCached()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1454104", Offset = "0x1454104", VA = "0x1454104")]
		public CTWebClientNotCached(int timeout, int connectionLimit = 20)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x145413C", Offset = "0x145413C", VA = "0x145413C", Slot = "16")]
		protected override WebRequest GetWebRequest(Uri uri)
		{
			return null;
		}
	}
	[Token(Token = "0x200002F")]
	public static class Config
	{
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DEBUG;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool isLoaded;
	}
	[Token(Token = "0x2000030")]
	public abstract class Constants : BaseConstants
	{
		[Token(Token = "0x40000D3")]
		public const string ASSET_NAME = "Online Check PRO";

		[Token(Token = "0x40000D4")]
		public const string ASSET_NAME_SHORT = "OC PRO";

		[Token(Token = "0x40000D5")]
		public const string ASSET_VERSION = "2021.2.7";

		[Token(Token = "0x40000D6")]
		public const int ASSET_BUILD = 20211230;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly DateTime ASSET_CREATED;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly DateTime ASSET_CHANGED;

		[Token(Token = "0x40000D9")]
		public const string ASSET_PRO_URL = "https://assetstore.unity.com/packages/slug/74688?aid=1011lNGT";

		[Token(Token = "0x40000DA")]
		public const string ASSET_UPDATE_CHECK_URL = "https://www.crosstales.com/media/assets/onlinecheck_versions.txt";

		[Token(Token = "0x40000DB")]
		public const string ASSET_CONTACT = "onlinecheck@crosstales.com";

		[Token(Token = "0x40000DC")]
		public const string ASSET_MANUAL_URL = "https://www.crosstales.com/media/data/assets/OnlineCheck/OnlineCheck-doc.pdf";

		[Token(Token = "0x40000DD")]
		public const string ASSET_API_URL = "https://crosstales.com/media/data/assets/OnlineCheck/api";

		[Token(Token = "0x40000DE")]
		public const string ASSET_FORUM_URL = "https://forum.unity.com/threads/online-check-pro-verify-internet-reachability.472558/";

		[Token(Token = "0x40000DF")]
		public const string ASSET_WEB_URL = "https://www.crosstales.com/en/portfolio/OnlineCheck/";

		[Token(Token = "0x40000E0")]
		public const string ASSET_VIDEO_PROMO = "https://youtu.be/pPvKE-eyxV4?list=PLgtonIOr6Tb41XTMeeZ836tjHlKgOO84S";

		[Token(Token = "0x40000E1")]
		public const string ASSET_VIDEO_TUTORIAL = "https://youtu.be/bNdafUNcs68?list=PLgtonIOr6Tb41XTMeeZ836tjHlKgOO84S";

		[Token(Token = "0x40000E2")]
		public const string KEY_PREFIX = "ONLINECHECK_CFG_";

		[Token(Token = "0x40000E3")]
		public const string KEY_DEBUG = "ONLINECHECK_CFG_DEBUG";

		[Token(Token = "0x40000E4")]
		public const string ONLINECHECK_SCENE_OBJECT_NAME = "OnlineCheck";

		[Token(Token = "0x40000E5")]
		public const string PROXY_SCENE_OBJECT_NAME = "Proxy";

		[Token(Token = "0x40000E6")]
		public const string PINGCHECK_SCENE_OBJECT_NAME = "PingCheck";

		[Token(Token = "0x40000E7")]
		public const string SPEEDTEST_SCENE_OBJECT_NAME = "SpeedTest";

		[Token(Token = "0x40000E8")]
		public const string SPEEDTESTNET_SCENE_OBJECT_NAME = "SpeedTestNET";

		[Token(Token = "0x40000E9")]
		public const string TAB = "\t\t";

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x145426C", Offset = "0x145426C", VA = "0x145426C")]
		protected Constants()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public static class Context
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int NumberOfChecks;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float Runtime;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float Uptime;

		[Token(Token = "0x17000049")]
		public static float ChecksPerMinute
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x145436C", Offset = "0x145436C", VA = "0x145436C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004A")]
		public static float Downtime
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x14543E4", Offset = "0x14543E4", VA = "0x14543E4")]
			get
			{
				return default(float);
			}
		}
	}
	[Token(Token = "0x2000032")]
	public abstract class Helper : BaseHelper
	{
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x14640F0", Offset = "0x14640F0", VA = "0x14640F0")]
		public static void CreateCustomCheck()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x14640F4", Offset = "0x14640F4", VA = "0x14640F4")]
		protected Helper()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public static class NetworkInfo
	{
		[Serializable]
		[Token(Token = "0x2000034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC47FF4", Offset = "0xC47FF4")]
		private sealed class <>c
		{
			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<System.Net.NetworkInformation.NetworkInterface, bool> <>9__9_0;

			[Token(Token = "0x40000F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<byte, string> <>9__9_1;

			[Token(Token = "0x40000F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<UnicastIPAddressInformation, bool> <>9__9_2;

			[Token(Token = "0x40000F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<GatewayIPAddressInformation, IPAddress> <>9__9_3;

			[Token(Token = "0x40000F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<IPAddress, bool> <>9__9_4;

			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x1F0B7B8", Offset = "0x1F0B7B8", VA = "0x1F0B7B8")]
			public <>c()
			{
			}

			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x1F0B7C0", Offset = "0x1F0B7C0", VA = "0x1F0B7C0")]
			internal bool <getNetworkInterfaces>b__9_0(System.Net.NetworkInformation.NetworkInterface ni)
			{
				return default(bool);
			}

			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x1F0B7F0", Offset = "0x1F0B7F0", VA = "0x1F0B7F0")]
			internal string <getNetworkInterfaces>b__9_1(byte val)
			{
				return null;
			}

			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x1F0B884", Offset = "0x1F0B884", VA = "0x1F0B884")]
			internal bool <getNetworkInterfaces>b__9_2(UnicastIPAddressInformation ua)
			{
				return default(bool);
			}

			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x1F0B8BC", Offset = "0x1F0B8BC", VA = "0x1F0B8BC")]
			internal IPAddress <getNetworkInterfaces>b__9_3(GatewayIPAddressInformation g)
			{
				return null;
			}

			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x1F0B8DC", Offset = "0x1F0B8DC", VA = "0x1F0B8DC")]
			internal bool <getNetworkInterfaces>b__9_4(IPAddress a)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<Crosstales.OnlineCheck.Model.NetworkInterface> interfaceCache;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string publicIpCache;

		[Token(Token = "0x1700004B")]
		public static string PublicIP
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x1466FB4", Offset = "0x1466FB4", VA = "0x1466FB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public static List<Crosstales.OnlineCheck.Model.NetworkInterface> LastNetworkInterfaces
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x14673A0", Offset = "0x14673A0", VA = "0x14673A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public static string LastPublicIP
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x1467B50", Offset = "0x1467B50", VA = "0x1467B50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public static bool isPlatformSupported
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x1467C88", Offset = "0x1467C88", VA = "0x1467C88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1467BB0", Offset = "0x1467BB0", VA = "0x1467BB0")]
		public static void Refresh()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1467404", Offset = "0x1467404", VA = "0x1467404")]
		public static List<Crosstales.OnlineCheck.Model.NetworkInterface> getNetworkInterfaces(bool activeOnly = true)
		{
			return null;
		}
	}
	[Token(Token = "0x2000035")]
	public class SetupProject
	{
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x19CAAA4", Offset = "0x19CAAA4", VA = "0x19CAAA4")]
		static SetupProject()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x19CAAA8", Offset = "0x19CAAA8", VA = "0x19CAAA8")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xC4BCF4", Offset = "0xC4BCF4")]
		private static void setup()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x19CAC30", Offset = "0x19CAC30", VA = "0x19CAC30")]
		public SetupProject()
		{
		}
	}
}
namespace Crosstales.OnlineCheck.Model
{
	[Serializable]
	[Token(Token = "0x2000036")]
	public class NetworkInterface
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Id;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string Name;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly NetworkInterfaceType Type;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly IPAddress Address;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly IPAddress Mask;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly string MacAddress;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly IPAddress Gateway;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly long Speed;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly OperationalStatus Status;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1467C08", Offset = "0x1467C08", VA = "0x1467C08")]
		public NetworkInterface(string id, string name, NetworkInterfaceType type, IPAddress address, IPAddress mask, string macAddress, IPAddress gateway, long speed, OperationalStatus status)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1467D04", Offset = "0x1467D04", VA = "0x1467D04", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace Crosstales.OnlineCheck.Model.Enum
{
	[Token(Token = "0x2000037")]
	public enum TestSize
	{
		[Token(Token = "0x40000FF")]
		SMALL,
		[Token(Token = "0x4000100")]
		MEDIUM,
		[Token(Token = "0x4000101")]
		LARGE
	}
}
namespace Crosstales.OnlineCheck.Data
{
	[Serializable]
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xC48004", Offset = "0xC48004")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xC48004", Offset = "0xC48004")]
	public class CustomCheck : ScriptableObject
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48D90", Offset = "0xC48D90")]
		public string URL;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48DC8", Offset = "0xC48DC8")]
		public string ExpectedData;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48E00", Offset = "0xC48E00")]
		public bool DataMustBeEquals;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48E38", Offset = "0xC48E38")]
		public bool UseOnlyCustom;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48E70", Offset = "0xC48E70")]
		public bool ShowErrors;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48EA8", Offset = "0xC48EA8")]
		public int HeaderSize;

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x14552A0", Offset = "0x14552A0", VA = "0x14552A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1455518", Offset = "0x1455518", VA = "0x1455518", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1455690", Offset = "0x1455690", VA = "0x1455690", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x14556E8", Offset = "0x14556E8", VA = "0x14556E8")]
		public CustomCheck()
		{
		}
	}
}
namespace Crosstales.OnlineCheck.Tool
{
	[Serializable]
	[Token(Token = "0x2000039")]
	public class PingCompleteEvent : UnityEvent<float>
	{
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x19C8404", Offset = "0x19C8404", VA = "0x19C8404")]
		public PingCompleteEvent()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xC48080", Offset = "0xC48080")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class PingCheck : Singleton<PingCheck>
	{
		[Token(Token = "0x200003B")]
		public delegate void PingCompleted(string host, string ip, float time);

		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC480DC", Offset = "0xC480DC")]
		private sealed class <ping>d__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PingCheck <>4__this;

			[Token(Token = "0x4000114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string hostname;

			[Token(Token = "0x4000115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string <ip>5__2;

			[Token(Token = "0x4000116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Ping <ping>5__3;

			[Token(Token = "0x4000117")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <elapsed>5__4;

			[Token(Token = "0x17000058")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0x1F0EFA0", Offset = "0x1F0EFA0", VA = "0x1F0EFA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000059")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x1F0EFE8", Offset = "0x1F0EFE8", VA = "0x1F0EFE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x1F0ED90", Offset = "0x1F0ED90", VA = "0x1F0ED90")]
			[DebuggerHidden]
			public <ping>d__41(int <>1__state)
			{
			}

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x1F0EDBC", Offset = "0x1F0EDBC", VA = "0x1F0EDBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x1F0EDC0", Offset = "0x1F0EDC0", VA = "0x1F0EDC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x1F0EFA8", Offset = "0x1F0EFA8", VA = "0x1F0EFA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48EE0", Offset = "0xC48EE0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xC48EE0", Offset = "0xC48EE0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC48EE0", Offset = "0xC48EE0")]
		[SerializeField]
		private string hostName;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xC48F74", Offset = "0xC48F74")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC48F74", Offset = "0xC48F74")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48F74", Offset = "0xC48F74")]
		private float timeout;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC48FFC", Offset = "0xC48FFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC48FFC", Offset = "0xC48FFC")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xC48FFC", Offset = "0xC48FFC")]
		private bool runOnStart;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int lastPingTimeMs;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC49090", Offset = "0xC49090")]
		public PingCompleteEvent OnPingComplete;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC490D8", Offset = "0xC490D8")]
		private string <LastHost>k__BackingField;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC490E8", Offset = "0xC490E8")]
		private string <LastIP>k__BackingField;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC490F8", Offset = "0xC490F8")]
		private bool <isBusy>k__BackingField;

		[Token(Token = "0x1700004F")]
		public string HostName
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x19C7DC0", Offset = "0x19C7DC0", VA = "0x19C7DC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x19C7DC8", Offset = "0x19C7DC8", VA = "0x19C7DC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public float Timeout
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x19C7DD0", Offset = "0x19C7DD0", VA = "0x19C7DD0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x19C7DD8", Offset = "0x19C7DD8", VA = "0x19C7DD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public bool RunOnStart
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x19C7E08", Offset = "0x19C7E08", VA = "0x19C7E08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x19C7E10", Offset = "0x19C7E10", VA = "0x19C7E10")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public string LastHost
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x19C7E1C", Offset = "0x19C7E1C", VA = "0x19C7E1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BD28", Offset = "0xC4BD28")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x19C7E24", Offset = "0x19C7E24", VA = "0x19C7E24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BD38", Offset = "0xC4BD38")]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public string LastIP
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x19C7E2C", Offset = "0x19C7E2C", VA = "0x19C7E2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BD48", Offset = "0xC4BD48")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x19C7E34", Offset = "0x19C7E34", VA = "0x19C7E34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BD58", Offset = "0xC4BD58")]
			private set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public float LastPingTime
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x19C7E3C", Offset = "0x19C7E3C", VA = "0x19C7E3C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000055")]
		public int LastPingTimeMilliseconds
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x19C7E54", Offset = "0x19C7E54", VA = "0x19C7E54")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x19C7E5C", Offset = "0x19C7E5C", VA = "0x19C7E5C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public bool isBusy
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x19C7E94", Offset = "0x19C7E94", VA = "0x19C7E94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BD68", Offset = "0xC4BD68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x19C7E9C", Offset = "0x19C7E9C", VA = "0x19C7E9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BD78", Offset = "0xC4BD78")]
			private set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public bool isPlatformSupported
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x19C7EA8", Offset = "0x19C7EA8", VA = "0x19C7EA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000004")]
		public event PingCompleted OnPingCompleted
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x19C7C80", Offset = "0x19C7C80", VA = "0x19C7C80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BD08", Offset = "0xC4BD08")]
			add
			{
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x19C7D20", Offset = "0x19C7D20", VA = "0x19C7D20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BD18", Offset = "0xC4BD18")]
			remove
			{
			}
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x19C7F10", Offset = "0x19C7F10", VA = "0x19C7F10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x19C800C", Offset = "0x19C800C", VA = "0x19C800C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x19C8090", Offset = "0x19C8090", VA = "0x19C8090")]
		public void Ping()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x19C8098", Offset = "0x19C8098", VA = "0x19C8098")]
		public void Ping(string hostname)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x19C8154", Offset = "0x19C8154", VA = "0x19C8154")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4BD88", Offset = "0xC4BD88")]
		private IEnumerator ping(string hostname)
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x19C81CC", Offset = "0x19C81CC", VA = "0x19C81CC")]
		private void onPingCompleted(string host, string ip, float time)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x19C8368", Offset = "0x19C8368", VA = "0x19C8368")]
		public PingCheck()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xC480EC", Offset = "0xC480EC")]
	public class Proxy : MonoBehaviour
	{
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49108", Offset = "0xC49108")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC49108", Offset = "0xC49108")]
		public string HTTPProxyURL;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC49168", Offset = "0xC49168")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49168", Offset = "0xC49168")]
		public int HTTPProxyPort;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC491C0", Offset = "0xC491C0")]
		public string HTTPProxyUsername;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC491F8", Offset = "0xC491F8")]
		public string HTTPProxyPassword;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49230", Offset = "0xC49230")]
		public string HTTPProxyURLProtocol;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC49268", Offset = "0xC49268")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49268", Offset = "0xC49268")]
		public string HTTPSProxyURL;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC492C8", Offset = "0xC492C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xC492C8", Offset = "0xC492C8")]
		public int HTTPSProxyPort;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49320", Offset = "0xC49320")]
		public string HTTPSProxyUsername;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49358", Offset = "0xC49358")]
		public string HTTPSProxyPassword;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49390", Offset = "0xC49390")]
		public string HTTPSProxyURLProtocol;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC493C8", Offset = "0xC493C8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC493C8", Offset = "0xC493C8")]
		public bool EnableOnAwake;

		[Token(Token = "0x4000123")]
		private const string HTTPProxyEnvVar = "HTTP_PROXY";

		[Token(Token = "0x4000124")]
		private const string HTTPSProxyEnvVar = "HTTPS_PROXY";

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC49428", Offset = "0xC49428")]
		private static bool <hasHTTPProxy>k__BackingField;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC49438", Offset = "0xC49438")]
		private static bool <hasHTTPSProxy>k__BackingField;

		[Token(Token = "0x1700005A")]
		public static bool hasHTTPProxy
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x19C8DC0", Offset = "0x19C8DC0", VA = "0x19C8DC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BE38", Offset = "0xC4BE38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x19C8E24", Offset = "0x19C8E24", VA = "0x19C8E24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BE48", Offset = "0xC4BE48")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public static bool hasHTTPSProxy
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x19C8E90", Offset = "0x19C8E90", VA = "0x19C8E90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BE58", Offset = "0xC4BE58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x19C8EF4", Offset = "0x19C8EF4", VA = "0x19C8EF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BE68", Offset = "0xC4BE68")]
			private set
			{
			}
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x19C8D18", Offset = "0x19C8D18", VA = "0x19C8D18")]
		static Proxy()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x19C8F60", Offset = "0x19C8F60", VA = "0x19C8F60")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x19C90B0", Offset = "0x19C90B0", VA = "0x19C90B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x19C8F90", Offset = "0x19C8F90", VA = "0x19C8F90")]
		public void EnableHTTPProxy()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x19C9020", Offset = "0x19C9020", VA = "0x19C9020")]
		public void EnableHTTPSProxy()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x19C9144", Offset = "0x19C9144", VA = "0x19C9144")]
		public static void EnableHTTPProxy(string url, int port, string username = "", string password = "", string urlProtocol = "")
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x19C95C0", Offset = "0x19C95C0", VA = "0x19C95C0")]
		public static void EnableHTTPSProxy(string url, int port, string username = "", string password = "", string urlProtocol = "")
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x19C9A48", Offset = "0x19C9A48", VA = "0x19C9A48")]
		public static void DisableHTTPProxy()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x19C9BD4", Offset = "0x19C9BD4", VA = "0x19C9BD4")]
		public static void DisableHTTPSProxy()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x19C9A3C", Offset = "0x19C9A3C", VA = "0x19C9A3C")]
		private static bool validPort(int port)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x19C9D60", Offset = "0x19C9D60", VA = "0x19C9D60")]
		public Proxy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003E")]
	public class SpeedTestCompleteEvent : UnityEvent<double, double>
	{
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x19CC550", Offset = "0x19CC550", VA = "0x19CC550")]
		public SpeedTestCompleteEvent()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xC48148", Offset = "0xC48148")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class SpeedTest : Singleton<SpeedTest>
	{
		[Token(Token = "0x2000040")]
		public delegate void TestCompleted(string url, long dataSize, double duration, double speed);

		[Token(Token = "0x2000041")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC481A4", Offset = "0xC481A4")]
		private sealed class <>c__DisplayClass57_0
		{
			[Token(Token = "0x4000134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpeedTest <>4__this;

			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TestSize size;

			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string url;

			[Token(Token = "0x6000217")]
			[Address(RVA = "0x1F0F59C", Offset = "0x1F0F59C", VA = "0x1F0F59C")]
			public <>c__DisplayClass57_0()
			{
			}

			[Token(Token = "0x6000218")]
			[Address(RVA = "0x1F0F5A4", Offset = "0x1F0F5A4", VA = "0x1F0F5A4")]
			internal void <test>b__0()
			{
			}
		}

		[Token(Token = "0x2000042")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC481B4", Offset = "0xC481B4")]
		private sealed class <test>d__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpeedTest <>4__this;

			[Token(Token = "0x400013A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TestSize size;

			[Token(Token = "0x400013B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string url;

			[Token(Token = "0x17000069")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600021C")]
				[Address(RVA = "0x1F0F780", Offset = "0x1F0F780", VA = "0x1F0F780", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600021E")]
				[Address(RVA = "0x1F0F7C8", Offset = "0x1F0F7C8", VA = "0x1F0F7C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000219")]
			[Address(RVA = "0x1F0F5CC", Offset = "0x1F0F5CC", VA = "0x1F0F5CC")]
			[DebuggerHidden]
			public <test>d__57(int <>1__state)
			{
			}

			[Token(Token = "0x600021A")]
			[Address(RVA = "0x1F0F5F8", Offset = "0x1F0F5F8", VA = "0x1F0F5F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600021B")]
			[Address(RVA = "0x1F0F5FC", Offset = "0x1F0F5FC", VA = "0x1F0F5FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0x1F0F788", Offset = "0x1F0F788", VA = "0x1F0F788", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xC49448", Offset = "0xC49448")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49448", Offset = "0xC49448")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC49448", Offset = "0xC49448")]
		private TestSize dataSize;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xC494DC", Offset = "0xC494DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC494DC", Offset = "0xC494DC")]
		[SerializeField]
		private string smallURL;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC4954C", Offset = "0xC4954C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xC4954C", Offset = "0xC4954C")]
		private string mediumURL;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xC495BC", Offset = "0xC495BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC495BC", Offset = "0xC495BC")]
		private string largeURL;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xC4962C", Offset = "0xC4962C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC4962C", Offset = "0xC4962C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC4962C", Offset = "0xC4962C")]
		[SerializeField]
		private bool runOnStart;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Thread worker;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC496C0", Offset = "0xC496C0")]
		public SpeedTestCompleteEvent OnSpeedTestComplete;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC49708", Offset = "0xC49708")]
		private string <LastURL>k__BackingField;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC49718", Offset = "0xC49718")]
		private long <LastDataSize>k__BackingField;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC49728", Offset = "0xC49728")]
		private double <LastDuration>k__BackingField;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC49738", Offset = "0xC49738")]
		private double <LastSpeed>k__BackingField;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC49748", Offset = "0xC49748")]
		private bool <isBusy>k__BackingField;

		[Token(Token = "0x1700005C")]
		public TestSize DataSize
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x19CB808", Offset = "0x19CB808", VA = "0x19CB808")]
			get
			{
				return default(TestSize);
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x19CB810", Offset = "0x19CB810", VA = "0x19CB810")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public string SmallUrl
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x19CB818", Offset = "0x19CB818", VA = "0x19CB818")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x19CB820", Offset = "0x19CB820", VA = "0x19CB820")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public string MediumUrl
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x19CB828", Offset = "0x19CB828", VA = "0x19CB828")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x19CB830", Offset = "0x19CB830", VA = "0x19CB830")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public string LargeUrl
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x19CB838", Offset = "0x19CB838", VA = "0x19CB838")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x19CB840", Offset = "0x19CB840", VA = "0x19CB840")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public bool RunOnStart
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x19CB848", Offset = "0x19CB848", VA = "0x19CB848")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x19CB850", Offset = "0x19CB850", VA = "0x19CB850")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public string LastURL
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x19CB85C", Offset = "0x19CB85C", VA = "0x19CB85C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BE98", Offset = "0xC4BE98")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x19CB864", Offset = "0x19CB864", VA = "0x19CB864")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BEA8", Offset = "0xC4BEA8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public long LastDataSize
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x19CB86C", Offset = "0x19CB86C", VA = "0x19CB86C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BEB8", Offset = "0xC4BEB8")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x19CB874", Offset = "0x19CB874", VA = "0x19CB874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BEC8", Offset = "0xC4BEC8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public double LastDataSizeMB
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x19CB87C", Offset = "0x19CB87C", VA = "0x19CB87C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000064")]
		public double LastDuration
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x19CB8A0", Offset = "0x19CB8A0", VA = "0x19CB8A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BED8", Offset = "0xC4BED8")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x19CB8A8", Offset = "0x19CB8A8", VA = "0x19CB8A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BEE8", Offset = "0xC4BEE8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public double LastSpeed
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x19CB8B0", Offset = "0x19CB8B0", VA = "0x19CB8B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BEF8", Offset = "0xC4BEF8")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x19CB8B8", Offset = "0x19CB8B8", VA = "0x19CB8B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BF08", Offset = "0xC4BF08")]
			private set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public double LastSpeedMBps
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x19CB8C0", Offset = "0x19CB8C0", VA = "0x19CB8C0")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000067")]
		public bool isBusy
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x19CB8E0", Offset = "0x19CB8E0", VA = "0x19CB8E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BF18", Offset = "0xC4BF18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x19CB8E8", Offset = "0x19CB8E8", VA = "0x19CB8E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BF28", Offset = "0xC4BF28")]
			private set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public bool isPlatformSupported
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x19CB8F4", Offset = "0x19CB8F4", VA = "0x19CB8F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000005")]
		public event TestCompleted OnTestCompleted
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x19CB6C8", Offset = "0x19CB6C8", VA = "0x19CB6C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BE78", Offset = "0xC4BE78")]
			add
			{
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x19CB768", Offset = "0x19CB768", VA = "0x19CB768")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4BE88", Offset = "0xC4BE88")]
			remove
			{
			}
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x19CB988", Offset = "0x19CB988", VA = "0x19CB988", Slot = "6")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x19CBA88", Offset = "0x19CBA88", VA = "0x19CBA88")]
		private void Start()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x19CBB0C", Offset = "0x19CBB0C", VA = "0x19CBB0C")]
		public void Test()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x19CBB14", Offset = "0x19CBB14", VA = "0x19CBB14")]
		public void Test(TestSize size)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x19CBC74", Offset = "0x19CBC74", VA = "0x19CBC74")]
		public void Test(string url)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x19CBBF0", Offset = "0x19CBBF0", VA = "0x19CBBF0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4BF38", Offset = "0xC4BF38")]
		private IEnumerator test(TestSize size, string url)
		{
			return null;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x19CBD34", Offset = "0x19CBD34", VA = "0x19CBD34")]
		private void speedTest(TestSize size, string url)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x19CC1B0", Offset = "0x19CC1B0", VA = "0x19CC1B0")]
		private void onTestCompleted(string url, long filesize, double duration, double speed)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x19CC47C", Offset = "0x19CC47C", VA = "0x19CC47C")]
		public SpeedTest()
		{
		}
	}
}
namespace Crosstales.Internal
{
	[Token(Token = "0x2000043")]
	public class WebGLCopyAndPaste : Singleton<WebGLCopyAndPaste>
	{
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1EFFFBC", Offset = "0x1EFFFBC", VA = "0x1EFFFBC")]
		public WebGLCopyAndPaste()
		{
		}
	}
}
namespace Crosstales.Common.Model.Enum
{
	[Token(Token = "0x2000044")]
	public enum Platform
	{
		[Token(Token = "0x400013D")]
		Windows,
		[Token(Token = "0x400013E")]
		OSX,
		[Token(Token = "0x400013F")]
		Linux,
		[Token(Token = "0x4000140")]
		IOS,
		[Token(Token = "0x4000141")]
		Android,
		[Token(Token = "0x4000142")]
		WSA,
		[Token(Token = "0x4000143")]
		Web,
		[Token(Token = "0x4000144")]
		Unsupported
	}
	[Token(Token = "0x2000045")]
	public enum SampleRate
	{
		[Token(Token = "0x4000146")]
		_8000Hz = 8000,
		[Token(Token = "0x4000147")]
		_11025Hz = 11025,
		[Token(Token = "0x4000148")]
		_22050Hz = 22050,
		[Token(Token = "0x4000149")]
		_44100Hz = 44100,
		[Token(Token = "0x400014A")]
		_48000Hz = 48000
	}
}
namespace Crosstales.Common.Util
{
	[Token(Token = "0x2000046")]
	[DisallowMultipleComponent]
	public class CTScreenshot : Singleton<CTScreenshot>
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49758", Offset = "0xC49758")]
		public string Prefix;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49790", Offset = "0xC49790")]
		public int Scale;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC497C8", Offset = "0xC497C8")]
		public KeyCode KeyCode;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49800", Offset = "0xC49800")]
		public bool ShowFileLocation;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Texture2D texture;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool locationShown;

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1453B30", Offset = "0x1453B30", VA = "0x1453B30")]
		private void Update()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1453B6C", Offset = "0x1453B6C", VA = "0x1453B6C")]
		public void Capture()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1453DB4", Offset = "0x1453DB4", VA = "0x1453DB4")]
		public CTScreenshot()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class PlatformController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC481D4", Offset = "0xC481D4")]
		private sealed class <>c
		{
			[Token(Token = "0x4000156")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000157")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<GameObject, bool> <>9__8_0;

			[Token(Token = "0x4000158")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<MonoBehaviour, bool> <>9__9_0;

			[Token(Token = "0x600022A")]
			[Address(RVA = "0x1F0F4C4", Offset = "0x1F0F4C4", VA = "0x1F0F4C4")]
			public <>c()
			{
			}

			[Token(Token = "0x600022B")]
			[Address(RVA = "0x1F0F4CC", Offset = "0x1F0F4CC", VA = "0x1F0F4CC")]
			internal bool <activateGameObjects>b__8_0(GameObject go)
			{
				return default(bool);
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0x1F0F534", Offset = "0x1F0F534", VA = "0x1F0F534")]
			internal bool <activateScripts>b__9_0(MonoBehaviour script)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC49838", Offset = "0xC49838")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49838", Offset = "0xC49838")]
		public List<Platform> Platforms;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49898", Offset = "0xC49898")]
		public bool Active;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC498D0", Offset = "0xC498D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC498D0", Offset = "0xC498D0")]
		public GameObject[] Objects;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49930", Offset = "0xC49930")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xC49930", Offset = "0xC49930")]
		public MonoBehaviour[] Scripts;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Platform currentPlatform;

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x19C8450", Offset = "0x19C8450", VA = "0x19C8450", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x19C84FC", Offset = "0x19C84FC", VA = "0x19C84FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x19C8488", Offset = "0x19C8488", VA = "0x19C8488")]
		protected void selectPlatform()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x19C8500", Offset = "0x19C8500", VA = "0x19C8500")]
		protected void activateGameObjects()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x19C8904", Offset = "0x19C8904", VA = "0x19C8904")]
		protected void activateScripts()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x19C8D08", Offset = "0x19C8D08", VA = "0x19C8D08")]
		public PlatformController()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class RandomColor : MonoBehaviour
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49990", Offset = "0xC49990")]
		public bool UseInterval;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC499C8", Offset = "0xC499C8")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49A00", Offset = "0xC49A00")]
		public Vector2 HueRange;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49A38", Offset = "0xC49A38")]
		public Vector2 SaturationRange;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49A70", Offset = "0xC49A70")]
		public Vector2 ValueRange;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49AA8", Offset = "0xC49AA8")]
		public Vector2 AlphaRange;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49AE0", Offset = "0xC49AE0")]
		public bool GrayScale;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49B18", Offset = "0xC49B18")]
		public Material Material;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49B50", Offset = "0xC49B50")]
		public bool RandomColorAtStart;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float elapsedTime;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float changeTime;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer currentRenderer;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Color32 startColor;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Color32 endColor;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float lerpProgress;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int colorID;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool existsMaterial;

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x19C9E08", Offset = "0x19C9E08", VA = "0x19C9E08")]
		private void Start()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x19CA078", Offset = "0x19CA078", VA = "0x19CA078")]
		private void Update()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x19CA368", Offset = "0x19CA368", VA = "0x19CA368")]
		public RandomColor()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[DisallowMultipleComponent]
	public class RandomRotator : MonoBehaviour
	{
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49B88", Offset = "0xC49B88")]
		public bool UseInterval;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49BC0", Offset = "0xC49BC0")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49BF8", Offset = "0xC49BF8")]
		public Vector3 SpeedMin;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49C30", Offset = "0xC49C30")]
		public Vector3 SpeedMax;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49C68", Offset = "0xC49C68")]
		public bool RandomRotationAtStart;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49CA0", Offset = "0xC49CA0")]
		public bool RandomChangeIntervalPerAxis;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform tf;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 speed;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float elapsedTime;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float changeTime;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 elapsedTimeAxis;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 changeTimeAxis;

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x19CA400", Offset = "0x19CA400", VA = "0x19CA400")]
		private void Start()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x19CA4AC", Offset = "0x19CA4AC", VA = "0x19CA4AC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x19CA7C0", Offset = "0x19CA7C0", VA = "0x19CA7C0")]
		public RandomRotator()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[DisallowMultipleComponent]
	public class RandomScaler : MonoBehaviour
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49CD8", Offset = "0xC49CD8")]
		public bool UseInterval;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49D10", Offset = "0xC49D10")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49D48", Offset = "0xC49D48")]
		public Vector3 ScaleMin;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49D80", Offset = "0xC49D80")]
		public Vector3 ScaleMax;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49DB8", Offset = "0xC49DB8")]
		public bool Uniform;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49DF0", Offset = "0xC49DF0")]
		public bool RandomScaleAtStart;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform tf;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 startScale;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 endScale;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float elapsedTime;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float changeTime;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float lerpTime;

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x19CA818", Offset = "0x19CA818", VA = "0x19CA818")]
		private void Start()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x19CA8F4", Offset = "0x19CA8F4", VA = "0x19CA8F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x19CAA78", Offset = "0x19CAA78", VA = "0x19CAA78")]
		public RandomScaler()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public abstract class BaseConstants
	{
		[Token(Token = "0x4000182")]
		public const string ASSET_AUTHOR = "crosstales LLC";

		[Token(Token = "0x4000183")]
		public const string ASSET_AUTHOR_URL = "https://www.crosstales.com";

		[Token(Token = "0x4000184")]
		public const string ASSET_CT_URL = "https://assetstore.unity.com/lists/crosstales-42213?aid=1011lNGT";

		[Token(Token = "0x4000185")]
		public const string ASSET_SOCIAL_DISCORD = "https://discord.gg/ZbZ2sh4";

		[Token(Token = "0x4000186")]
		public const string ASSET_SOCIAL_FACEBOOK = "https://www.facebook.com/crosstales/";

		[Token(Token = "0x4000187")]
		public const string ASSET_SOCIAL_TWITTER = "https://twitter.com/crosstales";

		[Token(Token = "0x4000188")]
		public const string ASSET_SOCIAL_YOUTUBE = "https://www.youtube.com/c/Crosstales";

		[Token(Token = "0x4000189")]
		public const string ASSET_SOCIAL_LINKEDIN = "https://www.linkedin.com/company/crosstales";

		[Token(Token = "0x400018A")]
		public const string ASSET_3P_PLAYMAKER = "https://assetstore.unity.com/packages/slug/368?aid=1011lNGT";

		[Token(Token = "0x400018B")]
		public const string ASSET_3P_VOLUMETRIC_AUDIO = "https://assetstore.unity.com/packages/slug/17125?aid=1011lNGT";

		[Token(Token = "0x400018C")]
		public const string ASSET_3P_ROCKTOMATE = "https://assetstore.unity.com/packages/slug/156311?aid=1011lNGT";

		[Token(Token = "0x400018D")]
		public const string ASSET_BWF = "https://assetstore.unity.com/packages/slug/26255?aid=1011lNGT";

		[Token(Token = "0x400018E")]
		public const string ASSET_DJ = "https://assetstore.unity.com/packages/slug/41993?aid=1011lNGT";

		[Token(Token = "0x400018F")]
		public const string ASSET_FB = "https://assetstore.unity.com/packages/slug/98713?aid=1011lNGT";

		[Token(Token = "0x4000190")]
		public const string ASSET_OC = "https://assetstore.unity.com/packages/slug/74688?aid=1011lNGT";

		[Token(Token = "0x4000191")]
		public const string ASSET_RADIO = "https://assetstore.unity.com/packages/slug/32034?aid=1011lNGT";

		[Token(Token = "0x4000192")]
		public const string ASSET_RTV = "https://assetstore.unity.com/packages/slug/41068?aid=1011lNGT";

		[Token(Token = "0x4000193")]
		public const string ASSET_TB = "https://assetstore.unity.com/packages/slug/98711?aid=1011lNGT";

		[Token(Token = "0x4000194")]
		public const string ASSET_TPB = "https://assetstore.unity.com/packages/slug/98714?aid=1011lNGT";

		[Token(Token = "0x4000195")]
		public const string ASSET_TPS = "https://assetstore.unity.com/packages/slug/60040?aid=1011lNGT";

		[Token(Token = "0x4000196")]
		public const string ASSET_TR = "https://assetstore.unity.com/packages/slug/61617?aid=1011lNGT";

		[Token(Token = "0x4000197")]
		public const int FACTOR_KB = 1024;

		[Token(Token = "0x4000198")]
		public const int FACTOR_MB = 1048576;

		[Token(Token = "0x4000199")]
		public const int FACTOR_GB = 1073741824;

		[Token(Token = "0x400019A")]
		public const float FLOAT_32768 = 32768f;

		[Token(Token = "0x400019B")]
		public const float FLOAT_TOLERANCE = 0.0001f;

		[Token(Token = "0x400019C")]
		public const string FORMAT_TWO_DECIMAL_PLACES = "0.00";

		[Token(Token = "0x400019D")]
		public const string FORMAT_NO_DECIMAL_PLACES = "0";

		[Token(Token = "0x400019E")]
		public const string FORMAT_PERCENT = "0%";

		[Token(Token = "0x400019F")]
		public const bool DEFAULT_DEBUG = false;

		[Token(Token = "0x40001A0")]
		public const string PATH_DELIMITER_WINDOWS = "\\";

		[Token(Token = "0x40001A1")]
		public const string PATH_DELIMITER_UNIX = "/";

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Regex REGEX_LINEENDINGS;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Regex REGEX_EMAIL;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Regex REGEX_CREDITCARD;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Regex REGEX_URL_WEB;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Regex REGEX_IP_ADDRESS;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly Regex REGEX_INVALID_CHARS;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly Regex REGEX_ALPHANUMERIC;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly Regex REGEX_CLEAN_SPACES;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly Regex REGEX_CLEAN_TAGS;

		[Token(Token = "0x40001AB")]
		public const string LATIN_ABC_UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		[Token(Token = "0x40001AC")]
		public const string LATIN_ABC_LOWERCASE = "abcdefghijklmnopqrstuvwxyz";

		[Token(Token = "0x40001AD")]
		public const string LATIN_ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

		[Token(Token = "0x40001AE")]
		public const string NUMBERS = "0123456789";

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static bool DEV_DEBUG;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string TEXT_TOSTRING_START;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string TEXT_TOSTRING_END;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string TEXT_TOSTRING_DELIMITER;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string TEXT_TOSTRING_DELIMITER_END;

		[Token(Token = "0x40001B4")]
		public const string PREFIX_HTTP = "http://";

		[Token(Token = "0x40001B5")]
		public const string PREFIX_HTTPS = "https://";

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static int PROCESS_KILL_TIME;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string CMD_WINDOWS_PATH;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static bool SHOW_BWF_BANNER;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public static bool SHOW_DJ_BANNER;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		public static bool SHOW_FB_BANNER;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
		public static bool SHOW_OC_BANNER;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static bool SHOW_RADIO_BANNER;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		public static bool SHOW_RTV_BANNER;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
		public static bool SHOW_TB_BANNER;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x87")]
		public static bool SHOW_TPB_BANNER;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static bool SHOW_TPS_BANNER;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public static bool SHOW_TR_BANNER;

		[Token(Token = "0x1700006B")]
		public static string PREFIX_FILE
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x144DF10", Offset = "0x144DF10", VA = "0x144DF10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		public static string APPLICATION_PATH
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x144E04C", Offset = "0x144E04C", VA = "0x144E04C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x144E338", Offset = "0x144E338", VA = "0x144E338")]
		protected BaseConstants()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public abstract class BaseHelper
	{
		[Serializable]
		[Token(Token = "0x200004E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48204", Offset = "0xC48204")]
		private sealed class <>c
		{
			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, IEnumerable<Type>> <>9__70_0;

			[Token(Token = "0x6000269")]
			[Address(RVA = "0x1F0404C", Offset = "0x1F0404C", VA = "0x1F0404C")]
			public <>c()
			{
			}

			[Token(Token = "0x600026A")]
			[Address(RVA = "0x1F04054", Offset = "0x1F04054", VA = "0x1F04054")]
			internal IEnumerable<Type> <InvokeMethod>b__70_0(Assembly assembly)
			{
				return null;
			}
		}

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly CultureInfo BaseCulture;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static readonly System.Random rnd;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static bool ApplicationIsPlaying;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string[] args;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int androidAPILevel;

		[Token(Token = "0x1700006D")]
		public static bool isWindowsPlatform
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x144E69C", Offset = "0x144E69C", VA = "0x144E69C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		public static bool isMacOSPlatform
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x144E6A4", Offset = "0x144E6A4", VA = "0x144E6A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		public static bool isLinuxPlatform
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x144E6AC", Offset = "0x144E6AC", VA = "0x144E6AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		public static bool isStandalonePlatform
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x144E6B4", Offset = "0x144E6B4", VA = "0x144E6B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		public static bool isAndroidPlatform
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x144E740", Offset = "0x144E740", VA = "0x144E740")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000072")]
		public static bool isIOSPlatform
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x144E748", Offset = "0x144E748", VA = "0x144E748")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000073")]
		public static bool isTvOSPlatform
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x144E750", Offset = "0x144E750", VA = "0x144E750")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000074")]
		public static bool isWSAPlatform
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x144E758", Offset = "0x144E758", VA = "0x144E758")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000075")]
		public static bool isXboxOnePlatform
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x144E760", Offset = "0x144E760", VA = "0x144E760")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000076")]
		public static bool isPS4Platform
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x144E768", Offset = "0x144E768", VA = "0x144E768")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		public static bool isWebGLPlatform
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x144E770", Offset = "0x144E770", VA = "0x144E770")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000078")]
		public static bool isWebPlatform
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x144E778", Offset = "0x144E778", VA = "0x144E778")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000079")]
		public static bool isWindowsBasedPlatform
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x144DFA8", Offset = "0x144DFA8", VA = "0x144DFA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007A")]
		public static bool isWSABasedPlatform
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x144E7D4", Offset = "0x144E7D4", VA = "0x144E7D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007B")]
		public static bool isAppleBasedPlatform
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x144E848", Offset = "0x144E848", VA = "0x144E848")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		public static bool isIOSBasedPlatform
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x144E8D4", Offset = "0x144E8D4", VA = "0x144E8D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007D")]
		public static bool isMobilePlatform
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x144E948", Offset = "0x144E948", VA = "0x144E948")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007E")]
		public static bool isEditor
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x144E9A4", Offset = "0x144E9A4", VA = "0x144E9A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007F")]
		public static bool isWindowsEditor
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x144E034", Offset = "0x144E034", VA = "0x144E034")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000080")]
		public static bool isMacOSEditor
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x144E03C", Offset = "0x144E03C", VA = "0x144E03C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000081")]
		public static bool isLinuxEditor
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x144E044", Offset = "0x144E044", VA = "0x144E044")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000082")]
		public static bool isEditorMode
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x144EA30", Offset = "0x144EA30", VA = "0x144EA30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000083")]
		public static bool isIL2CPP
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x144EA90", Offset = "0x144EA90", VA = "0x144EA90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000084")]
		public static Platform CurrentPlatform
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x144EA98", Offset = "0x144EA98", VA = "0x144EA98")]
			get
			{
				return default(Platform);
			}
		}

		[Token(Token = "0x17000085")]
		public static int AndroidAPILevel
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x144EB3C", Offset = "0x144EB3C", VA = "0x144EB3C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x144EC54", Offset = "0x144EC54", VA = "0x144EC54")]
		static BaseHelper()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x144ED34", Offset = "0x144ED34", VA = "0x144ED34")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xC4BFE8", Offset = "0xC4BFE8")]
		private static void initialize()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x144EDAC", Offset = "0x144EDAC", VA = "0x144EDAC")]
		public static string CreateString(string replaceChars, int stringLength)
		{
			return null;
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x144EF44", Offset = "0x144EF44", VA = "0x144EF44")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4BFF8", Offset = "0xC4BFF8")]
		public static bool hasActiveClip(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x144F0C8", Offset = "0x144F0C8", VA = "0x144F0C8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C030", Offset = "0xC4C030")]
		public static string ClearTags(string text)
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x144F1E0", Offset = "0x144F1E0", VA = "0x144F1E0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C068", Offset = "0xC4C068")]
		public static string ClearSpaces(string text)
		{
			return null;
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x144F2F0", Offset = "0x144F2F0", VA = "0x144F2F0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C0A0", Offset = "0xC4C0A0")]
		public static string ClearLineEndings(string text)
		{
			return null;
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x144F408", Offset = "0x144F408", VA = "0x144F408")]
		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true, int skipHeaderLines = 0, int skipFooterLines = 0)
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x144F6D8", Offset = "0x144F6D8", VA = "0x144F6D8")]
		public static string FormatBytesToHRF(long bytes, bool useSI = false)
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x144F9BC", Offset = "0x144F9BC", VA = "0x144F9BC")]
		public static string FormatSecondsToHourMinSec(double seconds)
		{
			return null;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x144FA24", Offset = "0x144FA24", VA = "0x144FA24")]
		public static string FormatSecondsToHRF(double seconds)
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x144FE78", Offset = "0x144FE78", VA = "0x144FE78")]
		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x144FFCC", Offset = "0x144FFCC", VA = "0x144FFCC")]
		public static string GenerateLoremIpsum(int length, int minSentences = 1, int maxSentences = int.MaxValue, int minWords = 1, int maxWords = 15)
		{
			return null;
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x14508FC", Offset = "0x14508FC", VA = "0x14508FC")]
		public static string LanguageToISO639(SystemLanguage language)
		{
			return null;
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1450B30", Offset = "0x1450B30", VA = "0x1450B30")]
		public static SystemLanguage ISO639ToLanguage(string isoCode)
		{
			return default(SystemLanguage);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x145169C", Offset = "0x145169C", VA = "0x145169C")]
		public static object InvokeMethod(string className, string methodName, params object[] parameters)
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1451D24", Offset = "0x1451D24", VA = "0x1451D24")]
		public static string GetArgument(string name)
		{
			return null;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1451E78", Offset = "0x1451E78", VA = "0x1451E78")]
		public static string[] GetArguments()
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x144FDFC", Offset = "0x144FDFC", VA = "0x144FDFC")]
		private static string addLeadingZero(int value)
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1451F4C", Offset = "0x1451F4C", VA = "0x1451F4C")]
		protected BaseHelper()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class CTHelper : MonoBehaviour
	{
		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC49E28", Offset = "0xC49E28")]
		private static CTHelper <Instance>k__BackingField;

		[Token(Token = "0x17000086")]
		public static CTHelper Instance
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x14526CC", Offset = "0x14526CC", VA = "0x14526CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4C0D8", Offset = "0xC4C0D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x1452718", Offset = "0x1452718", VA = "0x1452718")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4C0E8", Offset = "0xC4C0E8")]
			private set
			{
			}
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1452768", Offset = "0x1452768", VA = "0x1452768")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xC4C0F8", Offset = "0xC4C0F8")]
		private static void initialize()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x14527D0", Offset = "0x14527D0", VA = "0x14527D0")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xC4C10C", Offset = "0xC4C10C")]
		private static void create()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x14528D8", Offset = "0x14528D8", VA = "0x14528D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1452928", Offset = "0x1452928", VA = "0x1452928")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x145298C", Offset = "0x145298C", VA = "0x145298C")]
		public CTHelper()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public abstract class CTPlayerPrefs
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1452994", Offset = "0x1452994", VA = "0x1452994")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x14529D4", Offset = "0x14529D4", VA = "0x14529D4")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x14529DC", Offset = "0x14529DC", VA = "0x14529DC")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1452A54", Offset = "0x1452A54", VA = "0x1452A54")]
		public static void Save()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1452A5C", Offset = "0x1452A5C", VA = "0x1452A5C")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1452AD4", Offset = "0x1452AD4", VA = "0x1452AD4")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1452B4C", Offset = "0x1452B4C", VA = "0x1452B4C")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1452BC4", Offset = "0x1452BC4", VA = "0x1452BC4")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1452C64", Offset = "0x1452C64", VA = "0x1452C64")]
		public static DateTime GetDate(string key)
		{
			return default(DateTime);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1452D10", Offset = "0x1452D10", VA = "0x1452D10")]
		public static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1452DF0", Offset = "0x1452DF0", VA = "0x1452DF0")]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1452EF0", Offset = "0x1452EF0", VA = "0x1452EF0")]
		public static Vector4 GetVector4(string key)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1453038", Offset = "0x1453038", VA = "0x1453038")]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x14530FC", Offset = "0x14530FC", VA = "0x14530FC")]
		public static Color GetColor(string key)
		{
			return default(Color);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1453224", Offset = "0x1453224", VA = "0x1453224")]
		public static SystemLanguage GetLanguage(string key)
		{
			return default(SystemLanguage);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1453334", Offset = "0x1453334", VA = "0x1453334")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x14533B4", Offset = "0x14533B4", VA = "0x14533B4")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x145343C", Offset = "0x145343C", VA = "0x145343C")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x14534BC", Offset = "0x14534BC", VA = "0x14534BC")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1453530", Offset = "0x1453530", VA = "0x1453530")]
		public static void SetDate(string key, DateTime value)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x145359C", Offset = "0x145359C", VA = "0x145359C")]
		public static void SetVector2(string key, Vector2 value)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1453654", Offset = "0x1453654", VA = "0x1453654")]
		public static void SetVector3(string key, Vector3 value)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x1453738", Offset = "0x1453738", VA = "0x1453738")]
		public static void SetVector4(string key, Vector4 value)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x145390C", Offset = "0x145390C", VA = "0x145390C")]
		public static void SetQuaternion(string key, Quaternion value)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x14539D0", Offset = "0x14539D0", VA = "0x14539D0")]
		public static void SetColor(string key, Color value)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1453A94", Offset = "0x1453A94", VA = "0x1453A94")]
		public static void SetLanguage(string key, SystemLanguage language)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1453B28", Offset = "0x1453B28", VA = "0x1453B28")]
		protected CTPlayerPrefs()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class CTWebClient : WebClient
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC49E38", Offset = "0xC49E38")]
		private int <Timeout>k__BackingField;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC49E48", Offset = "0xC49E48")]
		private int <ConnectionLimit>k__BackingField;

		[Token(Token = "0x17000087")]
		public int Timeout
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x1453E5C", Offset = "0x1453E5C", VA = "0x1453E5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4C11C", Offset = "0xC4C11C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x1453E64", Offset = "0x1453E64", VA = "0x1453E64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4C12C", Offset = "0xC4C12C")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public int ConnectionLimit
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x1453E6C", Offset = "0x1453E6C", VA = "0x1453E6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4C13C", Offset = "0xC4C13C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x1453E74", Offset = "0x1453E74", VA = "0x1453E74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4C14C", Offset = "0xC4C14C")]
			set
			{
			}
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1453E7C", Offset = "0x1453E7C", VA = "0x1453E7C")]
		public CTWebClient()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1453EAC", Offset = "0x1453EAC", VA = "0x1453EAC")]
		public CTWebClient(int timeout, int connectionLimit = 20)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1453EE4", Offset = "0x1453EE4", VA = "0x1453EE4")]
		public WebRequest CTGetWebRequest(string uri)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1453F60", Offset = "0x1453F60", VA = "0x1453F60", Slot = "16")]
		protected override WebRequest GetWebRequest(Uri uri)
		{
			return null;
		}
	}
	[Token(Token = "0x2000052")]
	public abstract class FileHelper
	{
		[Serializable]
		[Token(Token = "0x2000053")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48214", Offset = "0xC48214")]
		private sealed class <>c
		{
			[Token(Token = "0x40001CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, bool> <>9__9_0;

			[Token(Token = "0x40001CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<string, string> <>9__9_1;

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x1F0823C", Offset = "0x1F0823C", VA = "0x1F0823C")]
			public <>c()
			{
			}

			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x1F08244", Offset = "0x1F08244", VA = "0x1F08244")]
			internal bool <GetFiles>b__9_0(string extension)
			{
				return default(bool);
			}

			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x1F082D4", Offset = "0x1F082D4", VA = "0x1F082D4")]
			internal string <GetFiles>b__9_1(string q)
			{
				return null;
			}
		}

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string applicationDataPath;

		[Token(Token = "0x17000089")]
		public static string StreamingAssetsPath
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x14625AC", Offset = "0x14625AC", VA = "0x14625AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x14626A4", Offset = "0x14626A4", VA = "0x14626A4")]
		static FileHelper()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x14626F8", Offset = "0x14626F8", VA = "0x14626F8")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xC4C15C", Offset = "0xC4C15C")]
		private static void initialize()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x144E0F8", Offset = "0x144E0F8", VA = "0x144E0F8")]
		public static string ValidatePath(string path, bool addEndDelimiter = true, bool preserveFile = true)
		{
			return null;
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1462874", Offset = "0x1462874", VA = "0x1462874")]
		public static string ValidateFile(string path)
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1462B0C", Offset = "0x1462B0C", VA = "0x1462B0C")]
		public static bool PathHasInvalidChars(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1462BA8", Offset = "0x1462BA8", VA = "0x1462BA8")]
		public static bool FileHasInvalidChars(string file)
		{
			return default(bool);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1462C44", Offset = "0x1462C44", VA = "0x1462C44")]
		public static string[] GetFiles(string path, bool isRecursive = false, params string[] extensions)
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1463208", Offset = "0x1463208", VA = "0x1463208")]
		public static string[] GetDirectories(string path, bool isRecursive = false)
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x14634BC", Offset = "0x14634BC", VA = "0x14634BC")]
		public static string[] GetDrives()
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x14636CC", Offset = "0x14636CC", VA = "0x14636CC")]
		public static void CopyPath(string sourcePath, string destPath, bool move = false)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1463C54", Offset = "0x1463C54", VA = "0x1463C54")]
		public static void CopyFile(string sourceFile, string destFile, bool move = false)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1463FD0", Offset = "0x1463FD0", VA = "0x1463FD0")]
		public static void ShowPath(string path)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1453CF4", Offset = "0x1453CF4", VA = "0x1453CF4")]
		public static void ShowFile(string file)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1464028", Offset = "0x1464028", VA = "0x1464028")]
		public static void OpenFile(string file)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1463A6C", Offset = "0x1463A6C", VA = "0x1463A6C")]
		private static void copyAll(DirectoryInfo source, DirectoryInfo target)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x14640E8", Offset = "0x14640E8", VA = "0x14640E8")]
		protected FileHelper()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class MemoryCacheStream : Stream
	{
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] cache;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long writePosition;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long readPosition;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private long length;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int size;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private readonly int maxSize;

		[Token(Token = "0x1700008A")]
		public override bool CanRead
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x1465E14", Offset = "0x1465E14", VA = "0x1465E14", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public override bool CanSeek
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x1465E1C", Offset = "0x1465E1C", VA = "0x1465E1C", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008C")]
		public override bool CanWrite
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x1465E24", Offset = "0x1465E24", VA = "0x1465E24", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008D")]
		public override long Position
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x1465E2C", Offset = "0x1465E2C", VA = "0x1465E2C", Slot = "12")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x1465E34", Offset = "0x1465E34", VA = "0x1465E34", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public override long Length
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x1465EA8", Offset = "0x1465EA8", VA = "0x1465EA8", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1465CD0", Offset = "0x1465CD0", VA = "0x1465CD0")]
		public MemoryCacheStream(int cacheSize = 65536, int maxCacheSize = 67108864)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1465EB0", Offset = "0x1465EB0", VA = "0x1465EB0", Slot = "21")]
		public override void Flush()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1465EB4", Offset = "0x1465EB4", VA = "0x1465EB4", Slot = "29")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1465FB4", Offset = "0x1465FB4", VA = "0x1465FB4", Slot = "30")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1466000", Offset = "0x1466000", VA = "0x1466000", Slot = "31")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x14661C0", Offset = "0x14661C0", VA = "0x14661C0", Slot = "33")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1466104", Offset = "0x1466104", VA = "0x1466104")]
		private int read(byte[] buff, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x14662F4", Offset = "0x14662F4", VA = "0x14662F4")]
		private void write(byte[] buff, int offset, int count)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1465D58", Offset = "0x1465D58", VA = "0x1465D58")]
		private void createCache()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public abstract class NetworkHelper
	{
		[Serializable]
		[Token(Token = "0x2000056")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48224", Offset = "0xC48224")]
		private sealed class <>c
		{
			[Token(Token = "0x40001D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<X509ChainStatus, bool> <>9__5_0;

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x1F0B744", Offset = "0x1F0B744", VA = "0x1F0B744")]
			public <>c()
			{
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x1F0B74C", Offset = "0x1F0B74C", VA = "0x1F0B74C")]
			internal bool <RemoteCertificateValidationCallback>b__5_0(X509ChainStatus t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001D6")]
		protected const string file_prefix = "file://";

		[Token(Token = "0x40001D7")]
		protected const string content_prefix = "content://";

		[Token(Token = "0x1700008F")]
		public static bool isInternetAvailable
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x14663A8", Offset = "0x14663A8", VA = "0x14663A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x14664B0", Offset = "0x14664B0", VA = "0x14664B0")]
		public static bool OpenURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1466570", Offset = "0x1466570", VA = "0x1466570")]
		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1466A84", Offset = "0x1466A84", VA = "0x1466A84")]
		public static string ValidURLFromFilePath(string path)
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1466C28", Offset = "0x1466C28", VA = "0x1466C28")]
		public static string CleanUrl(string url, bool removeProtocol = true, bool removeWWW = true, bool removeSlash = true)
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x146276C", Offset = "0x146276C", VA = "0x146276C")]
		public static bool isValidURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1466DFC", Offset = "0x1466DFC", VA = "0x1466DFC")]
		public static string GetIP(string host)
		{
			return null;
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1466568", Offset = "0x1466568", VA = "0x1466568")]
		private static void openURL(string url)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1466FAC", Offset = "0x1466FAC", VA = "0x1466FAC")]
		protected NetworkHelper()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[DisallowMultipleComponent]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49E58", Offset = "0xC49E58")]
		private bool dontDestroy;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string PrefabPath;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string GameObjectName;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static T instance;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly object lockObj;

		[Token(Token = "0x17000090")]
		public static T Instance
		{
			[Token(Token = "0x60002C5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C6")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public bool DontDestroy
		{
			[Token(Token = "0x60002C7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C8")]
			set
			{
			}
		}

		[Token(Token = "0x60002C9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002CA")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60002CB")]
		protected virtual void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60002CC")]
		public static void CreateInstance(bool searchExistingGameObject = true, bool deleteExistingInstance = false)
		{
		}

		[Token(Token = "0x60002CD")]
		public static void DeleteInstance()
		{
		}

		[Token(Token = "0x60002CE")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class SingletonHelper
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC49EA4", Offset = "0xC49EA4")]
		private static bool <isQuitting>k__BackingField;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool isInitialized;

		[Token(Token = "0x17000092")]
		public static bool isQuitting
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x19CAC38", Offset = "0x19CAC38", VA = "0x19CAC38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4C16C", Offset = "0xC4C16C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x19CAC9C", Offset = "0x19CAC9C", VA = "0x19CAC9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4C17C", Offset = "0xC4C17C")]
			set
			{
			}
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x19CAD08", Offset = "0x19CAD08", VA = "0x19CAD08")]
		static SingletonHelper()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x19CAE08", Offset = "0x19CAE08", VA = "0x19CAE08")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xC4C18C", Offset = "0xC4C18C")]
		private static void initialize()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x19CB1E8", Offset = "0x19CB1E8", VA = "0x19CB1E8")]
		private static void onSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x19CB398", Offset = "0x19CB398", VA = "0x19CB398")]
		private static void onSceneUnloaded(Scene scene)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x19CB548", Offset = "0x19CB548", VA = "0x19CB548")]
		private static void onQuitting()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x19CB6C0", Offset = "0x19CB6C0", VA = "0x19CB6C0")]
		public SingletonHelper()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public abstract class XmlHelper
	{
		[Token(Token = "0x60002D8")]
		public static void SerializeToFile<T>(T obj, string filename)
		{
		}

		[Token(Token = "0x60002D9")]
		public static T DeserializeFromFile<T>(string filename, bool skipBOM = false)
		{
			return (T)null;
		}

		[Token(Token = "0x60002DA")]
		public static string SerializeToString<T>(T obj)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		public static T DeserializeFromString<T>(string xmlAsString, bool skipBOM = true)
		{
			return (T)null;
		}

		[Token(Token = "0x60002DC")]
		public static T DeserializeFromResource<T>(string resourceName, bool skipBOM = true)
		{
			return (T)null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1F00034", Offset = "0x1F00034", VA = "0x1F00034")]
		protected XmlHelper()
		{
		}
	}
}
namespace MEC
{
	[Token(Token = "0x200005A")]
	public class Timing : MonoBehaviour
	{
		[Token(Token = "0x200005B")]
		private struct ProcessIndex : IEquatable<ProcessIndex>
		{
			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Segment seg;

			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int i;

			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x1F11994", Offset = "0x1F11994", VA = "0x1F11994", Slot = "4")]
			public bool Equals(ProcessIndex other)
			{
				return default(bool);
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x1F119BC", Offset = "0x1F119BC", VA = "0x1F119BC", Slot = "0")]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x1F11A50", Offset = "0x1F11A50", VA = "0x1F11A50")]
			public static bool operator ==(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x1F11A70", Offset = "0x1F11A70", VA = "0x1F11A70")]
			public static bool operator !=(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x1F11A90", Offset = "0x1F11A90", VA = "0x1F11A90", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x200005C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48244", Offset = "0xC48244")]
		private sealed class <_EOFPumpWatcher>d__132 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x17000099")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60003F0")]
				[Address(RVA = "0x1F10A30", Offset = "0x1F10A30", VA = "0x1F10A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700009A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003F2")]
				[Address(RVA = "0x1F10A78", Offset = "0x1F10A78", VA = "0x1F10A78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x1F10970", Offset = "0x1F10970", VA = "0x1F10970")]
			[DebuggerHidden]
			public <_EOFPumpWatcher>d__132(int <>1__state)
			{
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x1F1099C", Offset = "0x1F1099C", VA = "0x1F1099C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x1F109A0", Offset = "0x1F109A0", VA = "0x1F109A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x1F10A38", Offset = "0x1F10A38", VA = "0x1F10A38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48254", Offset = "0xC48254")]
		private sealed class <_EOFPump>d__133 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Timing <>4__this;

			[Token(Token = "0x1700009B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003F6")]
				[Address(RVA = "0x1F10920", Offset = "0x1F10920", VA = "0x1F10920", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003F8")]
				[Address(RVA = "0x1F10968", Offset = "0x1F10968", VA = "0x1F10968", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x1F10050", Offset = "0x1F10050", VA = "0x1F10050")]
			[DebuggerHidden]
			public <_EOFPump>d__133(int <>1__state)
			{
			}

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x1F1007C", Offset = "0x1F1007C", VA = "0x1F1007C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x1F10080", Offset = "0x1F10080", VA = "0x1F10080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x1F10928", Offset = "0x1F10928", VA = "0x1F10928", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48264", Offset = "0xC48264")]
		private sealed class <_StartWhenDone>d__275 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000256")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CoroutineHandle handle;

			[Token(Token = "0x4000257")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> proc;

			[Token(Token = "0x1700009D")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60003FD")]
				[Address(RVA = "0x1F110B8", Offset = "0x1F110B8", VA = "0x1F110B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700009E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003FF")]
				[Address(RVA = "0x1F11100", Offset = "0x1F11100", VA = "0x1F11100", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x1F10CF4", Offset = "0x1F10CF4", VA = "0x1F10CF4")]
			[DebuggerHidden]
			public <_StartWhenDone>d__275(int <>1__state)
			{
			}

			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x1F10D20", Offset = "0x1F10D20", VA = "0x1F10D20", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x1F10D78", Offset = "0x1F10D78", VA = "0x1F10D78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x1F10D4C", Offset = "0x1F10D4C", VA = "0x1F10D4C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x1F110C0", Offset = "0x1F110C0", VA = "0x1F110C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48274", Offset = "0xC48274")]
		private sealed class <_StartWhenDone>d__280 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000258")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000259")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400025A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AsyncOperation operation;

			[Token(Token = "0x400025B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x1700009F")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000403")]
				[Address(RVA = "0x1F112D0", Offset = "0x1F112D0", VA = "0x1F112D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000A0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000405")]
				[Address(RVA = "0x1F11318", Offset = "0x1F11318", VA = "0x1F11318", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000400")]
			[Address(RVA = "0x1F11160", Offset = "0x1F11160", VA = "0x1F11160")]
			[DebuggerHidden]
			public <_StartWhenDone>d__280(int <>1__state)
			{
			}

			[Token(Token = "0x6000401")]
			[Address(RVA = "0x1F1118C", Offset = "0x1F1118C", VA = "0x1F1118C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000402")]
			[Address(RVA = "0x1F11190", Offset = "0x1F11190", VA = "0x1F11190", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000404")]
			[Address(RVA = "0x1F112D8", Offset = "0x1F112D8", VA = "0x1F112D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48284", Offset = "0xC48284")]
		private sealed class <_StartWhenDone>d__282 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400025C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400025D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400025E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CustomYieldInstruction operation;

			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x170000A1")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000409")]
				[Address(RVA = "0x1F114EC", Offset = "0x1F114EC", VA = "0x1F114EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000A2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600040B")]
				[Address(RVA = "0x1F11534", Offset = "0x1F11534", VA = "0x1F11534", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000406")]
			[Address(RVA = "0x1F11378", Offset = "0x1F11378", VA = "0x1F11378")]
			[DebuggerHidden]
			public <_StartWhenDone>d__282(int <>1__state)
			{
			}

			[Token(Token = "0x6000407")]
			[Address(RVA = "0x1F113A4", Offset = "0x1F113A4", VA = "0x1F113A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000408")]
			[Address(RVA = "0x1F113A8", Offset = "0x1F113A8", VA = "0x1F113A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600040A")]
			[Address(RVA = "0x1F114F4", Offset = "0x1F114F4", VA = "0x1F114F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000061")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48294", Offset = "0xC48294")]
		private sealed class <_StartWhenDone>d__287 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<bool> evaluatorFunc;

			[Token(Token = "0x4000263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool continueOn;

			[Token(Token = "0x4000264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x170000A3")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x600040F")]
				[Address(RVA = "0x1F11728", Offset = "0x1F11728", VA = "0x1F11728", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000A4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000411")]
				[Address(RVA = "0x1F11770", Offset = "0x1F11770", VA = "0x1F11770", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x1F11594", Offset = "0x1F11594", VA = "0x1F11594")]
			[DebuggerHidden]
			public <_StartWhenDone>d__287(int <>1__state)
			{
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x1F115C0", Offset = "0x1F115C0", VA = "0x1F115C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600040E")]
			[Address(RVA = "0x1F115C4", Offset = "0x1F115C4", VA = "0x1F115C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000410")]
			[Address(RVA = "0x1F11730", Offset = "0x1F11730", VA = "0x1F11730", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000062")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC482A4", Offset = "0xC482A4")]
		private sealed class <_InjectDelay>d__288 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000267")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000268")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float waitTime;

			[Token(Token = "0x4000269")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> proc;

			[Token(Token = "0x170000A5")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000415")]
				[Address(RVA = "0x1F10C4C", Offset = "0x1F10C4C", VA = "0x1F10C4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000A6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000417")]
				[Address(RVA = "0x1F10C94", Offset = "0x1F10C94", VA = "0x1F10C94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000412")]
			[Address(RVA = "0x1F10AD8", Offset = "0x1F10AD8", VA = "0x1F10AD8")]
			[DebuggerHidden]
			public <_InjectDelay>d__288(int <>1__state)
			{
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x1F10B04", Offset = "0x1F10B04", VA = "0x1F10B04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x1F10B08", Offset = "0x1F10B08", VA = "0x1F10B08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000416")]
			[Address(RVA = "0x1F10C54", Offset = "0x1F10C54", VA = "0x1F10C54", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000063")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC482B4", Offset = "0xC482B4")]
		private sealed class <_DelayedCall>d__313 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400026A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400026B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400026C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x400026D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x400026E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject cancelWith;

			[Token(Token = "0x400026F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action action;

			[Token(Token = "0x170000A7")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x600041B")]
				[Address(RVA = "0x1F0FFA8", Offset = "0x1F0FFA8", VA = "0x1F0FFA8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000A8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600041D")]
				[Address(RVA = "0x1F0FFF0", Offset = "0x1F0FFF0", VA = "0x1F0FFF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000418")]
			[Address(RVA = "0x1F0FEA4", Offset = "0x1F0FEA4", VA = "0x1F0FEA4")]
			[DebuggerHidden]
			public <_DelayedCall>d__313(int <>1__state)
			{
			}

			[Token(Token = "0x6000419")]
			[Address(RVA = "0x1F0FED0", Offset = "0x1F0FED0", VA = "0x1F0FED0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600041A")]
			[Address(RVA = "0x1F0FED4", Offset = "0x1F0FED4", VA = "0x1F0FED4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600041C")]
			[Address(RVA = "0x1F0FFB0", Offset = "0x1F0FFB0", VA = "0x1F0FFB0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000064")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC482C4", Offset = "0xC482C4")]
		private sealed class <_WatchCall>d__334 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float timeframe;

			[Token(Token = "0x4000274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public CoroutineHandle handle;

			[Token(Token = "0x4000275")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action onDone;

			[Token(Token = "0x4000276")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject gObject;

			[Token(Token = "0x170000A9")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000421")]
				[Address(RVA = "0x1F118EC", Offset = "0x1F118EC", VA = "0x1F118EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000AA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000423")]
				[Address(RVA = "0x1F11934", Offset = "0x1F11934", VA = "0x1F11934", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600041E")]
			[Address(RVA = "0x1F117D0", Offset = "0x1F117D0", VA = "0x1F117D0")]
			[DebuggerHidden]
			public <_WatchCall>d__334(int <>1__state)
			{
			}

			[Token(Token = "0x600041F")]
			[Address(RVA = "0x1F117FC", Offset = "0x1F117FC", VA = "0x1F117FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0x1F11800", Offset = "0x1F11800", VA = "0x1F11800", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0x1F118F4", Offset = "0x1F118F4", VA = "0x1F118F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000065")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC482D4", Offset = "0xC482D4")]
		private sealed class <_CallContinuously>d__335 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float period;

			[Token(Token = "0x400027B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject gObject;

			[Token(Token = "0x400027C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action action;

			[Token(Token = "0x170000AB")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000427")]
				[Address(RVA = "0x1F0FDFC", Offset = "0x1F0FDFC", VA = "0x1F0FDFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000AC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000429")]
				[Address(RVA = "0x1F0FE44", Offset = "0x1F0FE44", VA = "0x1F0FE44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x1F0FC90", Offset = "0x1F0FC90", VA = "0x1F0FC90")]
			[DebuggerHidden]
			public <_CallContinuously>d__335(int <>1__state)
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x1F0FCBC", Offset = "0x1F0FCBC", VA = "0x1F0FCBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0x1F0FCC0", Offset = "0x1F0FCC0", VA = "0x1F0FCC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x1F0FE04", Offset = "0x1F0FE04", VA = "0x1F0FE04", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000066")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC482E4", Offset = "0xC482E4")]
		private sealed class <_WatchCall>d__352<T> : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float <>2__current;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Timing <>4__this;

			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float timeframe;

			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CoroutineHandle handle;

			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> onDone;

			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameObject gObject;

			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x170000AD")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x600042D")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000AE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600042F")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600042A")]
			[DebuggerHidden]
			public <_WatchCall>d__352(int <>1__state)
			{
			}

			[Token(Token = "0x600042B")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600042C")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600042E")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000067")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC482F4", Offset = "0xC482F4")]
		private sealed class <_CallContinuously>d__353<T> : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float <>2__current;

			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Timing <>4__this;

			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float period;

			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameObject gObject;

			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> action;

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x170000AF")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000433")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000B0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000435")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000430")]
			[DebuggerHidden]
			public <_CallContinuously>d__353(int <>1__state)
			{
			}

			[Token(Token = "0x6000431")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000432")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000434")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49EB4", Offset = "0xC49EB4")]
		public float TimeBetweenSlowUpdateCalls;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49EEC", Offset = "0xC49EEC")]
		public DebugInfoType ProfilerDebugAmount;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49F24", Offset = "0xC49F24")]
		public bool AutoTriggerManualTimeframe;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49F5C", Offset = "0xC49F5C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xC49F5C", Offset = "0xC49F5C")]
		public int UpdateCoroutines;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49FAC", Offset = "0xC49FAC")]
		public int FixedUpdateCoroutines;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC49FE4", Offset = "0xC49FE4")]
		public int LateUpdateCoroutines;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC4A01C", Offset = "0xC4A01C")]
		public int SlowUpdateCoroutines;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC4A054", Offset = "0xC4A054")]
		public int RealtimeUpdateCoroutines;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC4A08C", Offset = "0xC4A08C")]
		public int EditorUpdateCoroutines;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC4A0C4", Offset = "0xC4A0C4")]
		public int EditorSlowUpdateCoroutines;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC4A0FC", Offset = "0xC4A0FC")]
		public int EndOfFrameCoroutines;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xC4A134", Offset = "0xC4A134")]
		public int ManualTimeframeCoroutines;

		[NonSerialized]
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float localTime;

		[NonSerialized]
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float deltaTime;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Func<float, float> SetManualTimeframeTime;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Func<IEnumerator<float>, CoroutineHandle, IEnumerator<float>> ReplacementFunction;

		[Token(Token = "0x40001F2")]
		public const float WaitForOneFrame = float.NegativeInfinity;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4A17C", Offset = "0xC4A17C")]
		private static Thread <MainThread>k__BackingField;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4A18C", Offset = "0xC4A18C")]
		private CoroutineHandle <currentCoroutine>k__BackingField;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static object _tmpRef;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int _tmpInt;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static bool _tmpBool;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Segment _tmpSegment;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static CoroutineHandle _tmpHandle;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _currentUpdateFrame;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _currentLateUpdateFrame;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int _currentSlowUpdateFrame;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _currentRealtimeUpdateFrame;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int _currentEndOfFrameFrame;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _nextUpdateProcessSlot;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int _nextLateUpdateProcessSlot;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _nextFixedUpdateProcessSlot;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int _nextSlowUpdateProcessSlot;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _nextRealtimeUpdateProcessSlot;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int _nextEditorUpdateProcessSlot;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _nextEditorSlowUpdateProcessSlot;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _nextEndOfFrameProcessSlot;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _nextManualTimeframeProcessSlot;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _lastUpdateProcessSlot;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int _lastLateUpdateProcessSlot;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int _lastFixedUpdateProcessSlot;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastSlowUpdateProcessSlot;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int _lastRealtimeUpdateProcessSlot;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _lastEndOfFrameProcessSlot;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int _lastManualTimeframeProcessSlot;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float _lastUpdateTime;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _lastLateUpdateTime;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _lastFixedUpdateTime;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float _lastSlowUpdateTime;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float _lastRealtimeUpdateTime;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float _lastEndOfFrameTime;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _lastManualTimeframeTime;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _lastSlowUpdateDeltaTime;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _lastEditorUpdateDeltaTime;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float _lastEditorSlowUpdateDeltaTime;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float _lastManualTimeframeDeltaTime;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private ushort _framesSinceUpdate;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDE")]
		private ushort _expansions;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[HideInInspector]
		private byte _instanceID;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _EOFPumpRan;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> Links;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly WaitForEndOfFrame EofWaitObject;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> _waitingTriggers;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly HashSet<CoroutineHandle> _allWaiting;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly Dictionary<CoroutineHandle, ProcessIndex> _handleToIndex;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private readonly Dictionary<ProcessIndex, CoroutineHandle> _indexToHandle;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly Dictionary<CoroutineHandle, string> _processTags;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private readonly Dictionary<string, HashSet<CoroutineHandle>> _taggedProcesses;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly Dictionary<CoroutineHandle, int> _processLayers;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private readonly Dictionary<int, HashSet<CoroutineHandle>> _layeredProcesses;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private IEnumerator<float>[] UpdateProcesses;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private IEnumerator<float>[] LateUpdateProcesses;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private IEnumerator<float>[] FixedUpdateProcesses;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private IEnumerator<float>[] SlowUpdateProcesses;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private IEnumerator<float>[] RealtimeUpdateProcesses;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private IEnumerator<float>[] EditorUpdateProcesses;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private IEnumerator<float>[] EditorSlowUpdateProcesses;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private IEnumerator<float>[] EndOfFrameProcesses;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private IEnumerator<float>[] ManualTimeframeProcesses;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool[] UpdatePaused;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private bool[] LateUpdatePaused;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private bool[] FixedUpdatePaused;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private bool[] SlowUpdatePaused;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private bool[] RealtimeUpdatePaused;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private bool[] EditorUpdatePaused;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private bool[] EditorSlowUpdatePaused;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private bool[] EndOfFramePaused;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private bool[] ManualTimeframePaused;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private bool[] UpdateHeld;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool[] LateUpdateHeld;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private bool[] FixedUpdateHeld;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private bool[] SlowUpdateHeld;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private bool[] RealtimeUpdateHeld;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool[] EditorUpdateHeld;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private bool[] EditorSlowUpdateHeld;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private bool[] EndOfFrameHeld;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private bool[] ManualTimeframeHeld;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private CoroutineHandle _eofWatcherHandle;

		[Token(Token = "0x4000244")]
		private const ushort FramesUntilMaintenance = 64;

		[Token(Token = "0x4000245")]
		private const int ProcessArrayChunkSize = 64;

		[Token(Token = "0x4000246")]
		private const int InitialBufferSizeLarge = 256;

		[Token(Token = "0x4000247")]
		private const int InitialBufferSizeMedium = 64;

		[Token(Token = "0x4000248")]
		private const int InitialBufferSizeSmall = 8;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Timing[] ActiveInstances;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static Timing _instance;

		[Token(Token = "0x17000093")]
		public static float LocalTime
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x19CCD14", Offset = "0x19CCD14", VA = "0x19CCD14")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000094")]
		public static float DeltaTime
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x19CCFEC", Offset = "0x19CCFEC", VA = "0x19CCFEC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000095")]
		public static Thread MainThread
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x19CD244", Offset = "0x19CD244", VA = "0x19CD244")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4C1C0", Offset = "0xC4C1C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x19CD2A8", Offset = "0x19CD2A8", VA = "0x19CD2A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4C1D0", Offset = "0xC4C1D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public static CoroutineHandle CurrentCoroutine
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x19CD310", Offset = "0x19CD310", VA = "0x19CD310")]
			get
			{
				return default(CoroutineHandle);
			}
		}

		[Token(Token = "0x17000097")]
		public CoroutineHandle currentCoroutine
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x19CD4CC", Offset = "0x19CD4CC", VA = "0x19CD4CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4C1E0", Offset = "0xC4C1E0")]
			get
			{
				return default(CoroutineHandle);
			}
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x19CD4D4", Offset = "0x19CD4D4", VA = "0x19CD4D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4C1F0", Offset = "0xC4C1F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public static Timing Instance
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x19CCD7C", Offset = "0x19CCD7C", VA = "0x19CCD7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x19CD764", Offset = "0x19CD764", VA = "0x19CD764")]
			set
			{
			}
		}

		[Token(Token = "0x14000006")]
		public static event Action OnPreExecute
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x19CD054", Offset = "0x19CD054", VA = "0x19CD054")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4C1A0", Offset = "0xC4C1A0")]
			add
			{
			}
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x19CD14C", Offset = "0x19CD14C", VA = "0x19CD14C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC4C1B0", Offset = "0xC4C1B0")]
			remove
			{
			}
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x19CD7CC", Offset = "0x19CD7CC", VA = "0x19CD7CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x19CD8A4", Offset = "0x19CD8A4", VA = "0x19CD8A4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x19CDD14", Offset = "0x19CDD14", VA = "0x19CDD14")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x19CD4DC", Offset = "0x19CD4DC", VA = "0x19CD4DC")]
		private void InitializeInstanceID()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x19CDDE4", Offset = "0x19CDDE4", VA = "0x19CDDE4")]
		private void Update()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x19D196C", Offset = "0x19D196C", VA = "0x19D196C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x19D217C", Offset = "0x19D217C", VA = "0x19D217C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x19CF8B8", Offset = "0x19CF8B8", VA = "0x19CF8B8")]
		public void TriggerManualTimeframeUpdate()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x19CDA0C", Offset = "0x19CDA0C", VA = "0x19CDA0C")]
		private bool OnEditorStart()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x19CDA14", Offset = "0x19CDA14", VA = "0x19CDA14")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4C200", Offset = "0xC4C200")]
		private IEnumerator<float> _EOFPumpWatcher()
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x19D298C", Offset = "0x19D298C", VA = "0x19D298C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4C260", Offset = "0xC4C260")]
		private IEnumerator _EOFPump()
		{
			return null;
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x19D00EC", Offset = "0x19D00EC", VA = "0x19D00EC")]
		private void RemoveUnused()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x19D2F6C", Offset = "0x19D2F6C", VA = "0x19D2F6C")]
		private void EditorRemoveUnused()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x19D37AC", Offset = "0x19D37AC", VA = "0x19D37AC")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x19D632C", Offset = "0x19D632C", VA = "0x19D632C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x19D64AC", Offset = "0x19D64AC", VA = "0x19D64AC")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x19D657C", Offset = "0x19D657C", VA = "0x19D657C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x19D664C", Offset = "0x19D664C", VA = "0x19D664C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x19D67D8", Offset = "0x19D67D8", VA = "0x19D67D8")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x19D68AC", Offset = "0x19D68AC", VA = "0x19D68AC")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x19D697C", Offset = "0x19D697C", VA = "0x19D697C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x19D6B08", Offset = "0x19D6B08", VA = "0x19D6B08")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x19D6BDC", Offset = "0x19D6BDC", VA = "0x19D6BDC")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x19D6CB0", Offset = "0x19D6CB0", VA = "0x19D6CB0")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x19D6E40", Offset = "0x19D6E40", VA = "0x19D6E40")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x19D6F20", Offset = "0x19D6F20", VA = "0x19D6F20")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x19D6F90", Offset = "0x19D6F90", VA = "0x19D6F90")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x19D70B8", Offset = "0x19D70B8", VA = "0x19D70B8")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x19D7134", Offset = "0x19D7134", VA = "0x19D7134")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x19D71B0", Offset = "0x19D71B0", VA = "0x19D71B0")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x19D72DC", Offset = "0x19D72DC", VA = "0x19D72DC")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x19D735C", Offset = "0x19D735C", VA = "0x19D735C")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x19D73D8", Offset = "0x19D73D8", VA = "0x19D73D8")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x19D7504", Offset = "0x19D7504", VA = "0x19D7504")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x19D7584", Offset = "0x19D7584", VA = "0x19D7584")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x19D7604", Offset = "0x19D7604", VA = "0x19D7604")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x19D773C", Offset = "0x19D773C", VA = "0x19D773C")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x19D77C8", Offset = "0x19D77C8", VA = "0x19D77C8")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x19D80E4", Offset = "0x19D80E4", VA = "0x19D80E4")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x19D81EC", Offset = "0x19D81EC", VA = "0x19D81EC")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x19D9054", Offset = "0x19D9054", VA = "0x19D9054")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x19D9484", Offset = "0x19D9484", VA = "0x19D9484")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x19D95A4", Offset = "0x19D95A4", VA = "0x19D95A4")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x19D9D20", Offset = "0x19D9D20", VA = "0x19D9D20")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x19D9F04", Offset = "0x19D9F04", VA = "0x19D9F04")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x19DA020", Offset = "0x19DA020", VA = "0x19DA020")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x19DA364", Offset = "0x19DA364", VA = "0x19DA364")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x19DA6A8", Offset = "0x19DA6A8", VA = "0x19DA6A8")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x19DA7D4", Offset = "0x19DA7D4", VA = "0x19DA7D4")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x19DAD60", Offset = "0x19DAD60", VA = "0x19DAD60")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x19DB1E0", Offset = "0x19DB1E0", VA = "0x19DB1E0")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x19DB2A8", Offset = "0x19DB2A8", VA = "0x19DB2A8")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x19CDA80", Offset = "0x19CDA80", VA = "0x19CDA80")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x19DBACC", Offset = "0x19DBACC", VA = "0x19DBACC")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x19DBBA4", Offset = "0x19DBBA4", VA = "0x19DBBA4")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x19DC7FC", Offset = "0x19DC7FC", VA = "0x19DC7FC")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x19DC8D0", Offset = "0x19DC8D0", VA = "0x19DC8D0")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x19DCB70", Offset = "0x19DCB70", VA = "0x19DCB70")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x19DCE10", Offset = "0x19DCE10", VA = "0x19DCE10")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x19DCEFC", Offset = "0x19DCEFC", VA = "0x19DCEFC")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x19D3870", Offset = "0x19D3870", VA = "0x19D3870")]
		private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, int layer, bool layerHasValue, string tag, CoroutineHandle handle, bool prewarm)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x19DD60C", Offset = "0x19DD60C", VA = "0x19DD60C")]
		public static int KillCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x19DD6F0", Offset = "0x19DD6F0", VA = "0x19DD6F0")]
		public int KillCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x19D79A8", Offset = "0x19D79A8", VA = "0x19D79A8")]
		public static int KillCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x19DDBA8", Offset = "0x19DDBA8", VA = "0x19DDBA8")]
		public static int KillCoroutines(params CoroutineHandle[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x19CF678", Offset = "0x19CF678", VA = "0x19CF678")]
		public int KillCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x19DDDD4", Offset = "0x19DDDD4", VA = "0x19DDDD4")]
		public static int KillCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x19DDEE0", Offset = "0x19DDEE0", VA = "0x19DDEE0")]
		public int KillCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x19D8524", Offset = "0x19D8524", VA = "0x19D8524")]
		public static int KillCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x19DB53C", Offset = "0x19DB53C", VA = "0x19DB53C")]
		public int KillCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x19D938C", Offset = "0x19D938C", VA = "0x19D938C")]
		public static int KillCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x19DB7EC", Offset = "0x19DB7EC", VA = "0x19DB7EC")]
		public int KillCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x19DE024", Offset = "0x19DE024", VA = "0x19DE024")]
		public static int KillCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x19DE138", Offset = "0x19DE138", VA = "0x19DE138")]
		public int KillCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x19D9B20", Offset = "0x19D9B20", VA = "0x19D9B20")]
		public static int KillCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x19DBFBC", Offset = "0x19DBFBC", VA = "0x19DBFBC")]
		public int KillCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x19DDB00", Offset = "0x19DDB00", VA = "0x19DDB00")]
		public static Timing GetInstance(byte ID)
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x19DE178", Offset = "0x19DE178", VA = "0x19DE178")]
		public static float WaitForSeconds(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x19DE200", Offset = "0x19DE200", VA = "0x19DE200")]
		public float WaitForSecondsOnInstance(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x19CF380", Offset = "0x19CF380", VA = "0x19CF380")]
		private bool UpdateTimeValues(Segment segment)
		{
			return default(bool);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x19DE244", Offset = "0x19DE244", VA = "0x19DE244")]
		private float GetSegmentTime(Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x19DE330", Offset = "0x19DE330", VA = "0x19DE330")]
		public static int PauseCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x19DE414", Offset = "0x19DE414", VA = "0x19DE414")]
		public int PauseCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x19DF81C", Offset = "0x19DF81C", VA = "0x19DF81C")]
		public int PauseCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x19DF724", Offset = "0x19DF724", VA = "0x19DF724")]
		public static int PauseCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x19E0818", Offset = "0x19E0818", VA = "0x19E0818")]
		public static int PauseCoroutines(params CoroutineHandle[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x19E09D4", Offset = "0x19E09D4", VA = "0x19E09D4")]
		public static int PauseCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x19E0ACC", Offset = "0x19E0ACC", VA = "0x19E0ACC")]
		public int PauseCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x19E0EB8", Offset = "0x19E0EB8", VA = "0x19E0EB8")]
		public static int PauseCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x19E0B78", Offset = "0x19E0B78", VA = "0x19E0B78")]
		public int PauseCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x19E0FB0", Offset = "0x19E0FB0", VA = "0x19E0FB0")]
		public static int PauseCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x19E10A8", Offset = "0x19E10A8", VA = "0x19E10A8")]
		public int PauseCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x19E13EC", Offset = "0x19E13EC", VA = "0x19E13EC")]
		public static int PauseCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x19E1938", Offset = "0x19E1938", VA = "0x19E1938")]
		public int PauseCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x19E19EC", Offset = "0x19E19EC", VA = "0x19E19EC")]
		public static int PauseCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x19E1500", Offset = "0x19E1500", VA = "0x19E1500")]
		public int PauseCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x19E1AEC", Offset = "0x19E1AEC", VA = "0x19E1AEC")]
		public static int ResumeCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x19E1BD0", Offset = "0x19E1BD0", VA = "0x19E1BD0")]
		public int ResumeCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x19D7C14", Offset = "0x19D7C14", VA = "0x19D7C14")]
		public static int ResumeCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x19E216C", Offset = "0x19E216C", VA = "0x19E216C")]
		public static int ResumeCoroutines(params CoroutineHandle[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x19DAF28", Offset = "0x19DAF28", VA = "0x19DAF28")]
		public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x19D861C", Offset = "0x19D861C", VA = "0x19D861C")]
		public int ResumeCoroutinesOnInstance(IEnumerable<CoroutineHandle> handles)
		{
			return default(int);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x19E2328", Offset = "0x19E2328", VA = "0x19E2328")]
		public static int ResumeCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x19E2770", Offset = "0x19E2770", VA = "0x19E2770")]
		public int ResumeCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x19E281C", Offset = "0x19E281C", VA = "0x19E281C")]
		public static int ResumeCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x19E2434", Offset = "0x19E2434", VA = "0x19E2434")]
		public int ResumeCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x19E2914", Offset = "0x19E2914", VA = "0x19E2914")]
		public static int ResumeCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x19E2A0C", Offset = "0x19E2A0C", VA = "0x19E2A0C")]
		public int ResumeCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x19E2D4C", Offset = "0x19E2D4C", VA = "0x19E2D4C")]
		public static int ResumeCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x19E2E60", Offset = "0x19E2E60", VA = "0x19E2E60")]
		public int ResumeCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x19D9C20", Offset = "0x19D9C20", VA = "0x19D9C20")]
		public static int ResumeCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x19DC410", Offset = "0x19DC410", VA = "0x19DC410")]
		public int ResumeCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x19E2F14", Offset = "0x19E2F14", VA = "0x19E2F14")]
		public static string GetTag(CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x19E306C", Offset = "0x19E306C", VA = "0x19E306C")]
		public static int? GetLayer(CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x19E31F4", Offset = "0x19E31F4", VA = "0x19E31F4")]
		public static string GetDebugName(CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x19E3454", Offset = "0x19E3454", VA = "0x19E3454")]
		public static Segment GetSegment(CoroutineHandle handle)
		{
			return default(Segment);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x19E3578", Offset = "0x19E3578", VA = "0x19E3578")]
		public static bool SetTag(CoroutineHandle handle, string newTag, bool overwriteExisting = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x19E38A4", Offset = "0x19E38A4", VA = "0x19E38A4")]
		public static bool SetLayer(CoroutineHandle handle, int newLayer, bool overwriteExisting = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x19E3BD0", Offset = "0x19E3BD0", VA = "0x19E3BD0")]
		public static bool SetSegment(CoroutineHandle handle, Segment newSegment)
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x19E4E90", Offset = "0x19E4E90", VA = "0x19E4E90")]
		public static bool RemoveTag(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x19E4EF8", Offset = "0x19E4EF8", VA = "0x19E4EF8")]
		public static bool RemoveLayer(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x19D7ADC", Offset = "0x19D7ADC", VA = "0x19D7ADC")]
		public static bool IsRunning(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x19E503C", Offset = "0x19E503C", VA = "0x19E503C")]
		public static bool IsAliveAndPaused(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x19DD314", Offset = "0x19DD314", VA = "0x19DD314")]
		private void AddTagOnInstance(string tag, CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x19DD490", Offset = "0x19DD490", VA = "0x19DD490")]
		private void AddLayerOnInstance(int layer, CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x19E370C", Offset = "0x19E370C", VA = "0x19E370C")]
		private void RemoveTagOnInstance(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x19E3A38", Offset = "0x19E3A38", VA = "0x19E3A38")]
		private void RemoveLayerOnInstance(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x19D2CB0", Offset = "0x19D2CB0", VA = "0x19D2CB0")]
		private void RemoveGraffiti(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x19E3EEC", Offset = "0x19E3EEC", VA = "0x19E3EEC")]
		private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x19D29F8", Offset = "0x19D29F8", VA = "0x19D29F8")]
		private bool CoindexIsNull(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x19E338C", Offset = "0x19E338C", VA = "0x19E338C")]
		private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x19DDD64", Offset = "0x19DDD64", VA = "0x19DDD64")]
		private bool Nullify(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x19DDF18", Offset = "0x19DDF18", VA = "0x19DDF18")]
		private bool Nullify(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x19DFAD8", Offset = "0x19DFAD8", VA = "0x19DFAD8")]
		private bool SetPause(ProcessIndex coindex, bool newPausedState)
		{
			return default(bool);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x19E4150", Offset = "0x19E4150", VA = "0x19E4150")]
		private bool SetHeld(ProcessIndex coindex, bool newHeldState)
		{
			return default(bool);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x19E519C", Offset = "0x19E519C", VA = "0x19E519C")]
		private IEnumerator<float> CreateHold(ProcessIndex coindex, IEnumerator<float> coptr)
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x19E4084", Offset = "0x19E4084", VA = "0x19E4084")]
		private bool CoindexIsPaused(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x19E3FB8", Offset = "0x19E3FB8", VA = "0x19E3FB8")]
		private bool CoindexIsHeld(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x19E5E60", Offset = "0x19E5E60", VA = "0x19E5E60")]
		private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x19E5F5C", Offset = "0x19E5F5C", VA = "0x19E5F5C")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x19E6374", Offset = "0x19E6374", VA = "0x19E6374")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x19E6410", Offset = "0x19E6410", VA = "0x19E6410")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x19E64AC", Offset = "0x19E64AC", VA = "0x19E64AC")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x19E6558", Offset = "0x19E6558", VA = "0x19E6558")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x19E65D4", Offset = "0x19E65D4", VA = "0x19E65D4")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x19E6658", Offset = "0x19E6658", VA = "0x19E6658")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x19E66DC", Offset = "0x19E66DC", VA = "0x19E66DC")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x19E6770", Offset = "0x19E6770", VA = "0x19E6770")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x19E5FF0", Offset = "0x19E5FF0", VA = "0x19E5FF0")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
		{
			return default(float);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x19D7D0C", Offset = "0x19D7D0C", VA = "0x19D7D0C")]
		public static void WaitForOtherHandles(CoroutineHandle handle, CoroutineHandle otherHandle, bool warnOnIssue = true)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x19D87DC", Offset = "0x19D87DC", VA = "0x19D87DC")]
		public static void WaitForOtherHandles(CoroutineHandle handle, IEnumerable<CoroutineHandle> otherHandles, bool warnOnIssue = true)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x19E6858", Offset = "0x19E6858", VA = "0x19E6858")]
		private void SwapToLast(CoroutineHandle firstHandle, CoroutineHandle lastHandle)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x19E67D4", Offset = "0x19E67D4", VA = "0x19E67D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4C2C0", Offset = "0xC4C2C0")]
		private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x19D2AC8", Offset = "0x19D2AC8", VA = "0x19D2AC8")]
		private void CloseWaitingProcess(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x19E6C94", Offset = "0x19E6C94", VA = "0x19E6C94")]
		private bool HandleIsInWaitingList(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x19E6D8C", Offset = "0x19E6D8C", VA = "0x19E6D8C")]
		private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x19E6E08", Offset = "0x19E6E08", VA = "0x19E6E08")]
		public static float WaitUntilDone(AsyncOperation operation)
		{
			return default(float);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x19E6FD4", Offset = "0x19E6FD4", VA = "0x19E6FD4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4C320", Offset = "0xC4C320")]
		private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x19E704C", Offset = "0x19E704C", VA = "0x19E704C")]
		public static float WaitUntilDone(CustomYieldInstruction operation)
		{
			return default(float);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x19E721C", Offset = "0x19E721C", VA = "0x19E721C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4C380", Offset = "0xC4C380")]
		private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x19E7294", Offset = "0x19E7294", VA = "0x19E7294")]
		public static float WaitUntilTrue(Func<bool> evaluatorFunc)
		{
			return default(float);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x19E7390", Offset = "0x19E7390", VA = "0x19E7390")]
		private static IEnumerator<float> WaitUntilTrueHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x19E74B8", Offset = "0x19E74B8", VA = "0x19E74B8")]
		public static float WaitUntilFalse(Func<bool> evaluatorFunc)
		{
			return default(float);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x19E75B4", Offset = "0x19E75B4", VA = "0x19E75B4")]
		private static IEnumerator<float> WaitUntilFalseHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x19E7430", Offset = "0x19E7430", VA = "0x19E7430")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4C3E0", Offset = "0xC4C3E0")]
		private static IEnumerator<float> _StartWhenDone(Func<bool> evaluatorFunc, bool continueOn, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x19DF698", Offset = "0x19DF698", VA = "0x19DF698")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4C440", Offset = "0xC4C440")]
		private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float waitTime)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x19E7654", Offset = "0x19E7654", VA = "0x19E7654")]
		public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x19E7880", Offset = "0x19E7880", VA = "0x19E7880")]
		public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x19E7A90", Offset = "0x19E7A90", VA = "0x19E7A90")]
		public static int LinkCoroutines(CoroutineHandle master, CoroutineHandle slave)
		{
			return default(int);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x19E7D40", Offset = "0x19E7D40", VA = "0x19E7D40")]
		public static int UnlinkCoroutines(CoroutineHandle master, CoroutineHandle slave, bool twoWay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x19E80D8", Offset = "0x19E80D8", VA = "0x19E80D8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C4A0", Offset = "0xC4C4A0")]
		public static float GetMyHandle(Action<CoroutineHandle> reciever)
		{
			return default(float);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x19E81AC", Offset = "0x19E81AC", VA = "0x19E81AC")]
		private static IEnumerator<float> GetHandleHelper(IEnumerator<float> input, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x19E8278", Offset = "0x19E8278", VA = "0x19E8278")]
		public static float SwitchCoroutine(Segment newSegment)
		{
			return default(float);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x19E834C", Offset = "0x19E834C", VA = "0x19E834C")]
		private static IEnumerator<float> SwitchCoroutineRepS(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x19E840C", Offset = "0x19E840C", VA = "0x19E840C")]
		public static float SwitchCoroutine(Segment newSegment, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x19E84F4", Offset = "0x19E84F4", VA = "0x19E84F4")]
		private static IEnumerator<float> SwitchCoroutineRepST(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x19E8668", Offset = "0x19E8668", VA = "0x19E8668")]
		public static float SwitchCoroutine(Segment newSegment, int newLayer)
		{
			return default(float);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x19E8750", Offset = "0x19E8750", VA = "0x19E8750")]
		private static IEnumerator<float> SwitchCoroutineRepSL(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x19E883C", Offset = "0x19E883C", VA = "0x19E883C")]
		public static float SwitchCoroutine(Segment newSegment, int newLayer, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x19E8930", Offset = "0x19E8930", VA = "0x19E8930")]
		private static IEnumerator<float> SwitchCoroutineRepSLT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x19E8AC8", Offset = "0x19E8AC8", VA = "0x19E8AC8")]
		public static float SwitchCoroutine(string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x19E8B9C", Offset = "0x19E8B9C", VA = "0x19E8B9C")]
		private static IEnumerator<float> SwitchCoroutineRepT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x19E8CCC", Offset = "0x19E8CCC", VA = "0x19E8CCC")]
		public static float SwitchCoroutine(int newLayer)
		{
			return default(float);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x19E8DA0", Offset = "0x19E8DA0", VA = "0x19E8DA0")]
		private static IEnumerator<float> SwitchCoroutineRepL(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x19E8E44", Offset = "0x19E8E44", VA = "0x19E8E44")]
		public static float SwitchCoroutine(int newLayer, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x19E8F2C", Offset = "0x19E8F2C", VA = "0x19E8F2C")]
		private static IEnumerator<float> SwitchCoroutineRepLT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x19E9080", Offset = "0x19E9080", VA = "0x19E9080")]
		public static CoroutineHandle CallDelayed(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x19E91A8", Offset = "0x19E91A8", VA = "0x19E91A8")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x19E91E8", Offset = "0x19E91E8", VA = "0x19E91E8")]
		public static CoroutineHandle CallDelayed(float delay, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x19E9290", Offset = "0x19E9290", VA = "0x19E9290")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x19E9118", Offset = "0x19E9118", VA = "0x19E9118")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4C4DC", Offset = "0xC4C4DC")]
		private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
		{
			return null;
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x19E92D4", Offset = "0x19E92D4", VA = "0x19E92D4")]
		public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x19E937C", Offset = "0x19E937C", VA = "0x19E937C")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x19E93C8", Offset = "0x19E93C8", VA = "0x19E93C8")]
		public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x19E9478", Offset = "0x19E9478", VA = "0x19E9478")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x19E94D4", Offset = "0x19E94D4", VA = "0x19E94D4")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x19E96F8", Offset = "0x19E96F8", VA = "0x19E96F8")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x19E9790", Offset = "0x19E9790", VA = "0x19E9790")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x19E989C", Offset = "0x19E989C", VA = "0x19E989C")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x19E99A0", Offset = "0x19E99A0", VA = "0x19E99A0")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x19E9AA0", Offset = "0x19E9AA0", VA = "0x19E9AA0")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x19E9BA4", Offset = "0x19E9BA4", VA = "0x19E9BA4")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x19E9CC4", Offset = "0x19E9CC4", VA = "0x19E9CC4")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x19E9DD4", Offset = "0x19E9DD4", VA = "0x19E9DD4")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x19E9ED0", Offset = "0x19E9ED0", VA = "0x19E9ED0")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x19E9FBC", Offset = "0x19E9FBC", VA = "0x19E9FBC")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x19EA0C4", Offset = "0x19EA0C4", VA = "0x19EA0C4")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x19EA1C4", Offset = "0x19EA1C4", VA = "0x19EA1C4")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x19EA2CC", Offset = "0x19EA2CC", VA = "0x19EA2CC")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x19EA3CC", Offset = "0x19EA3CC", VA = "0x19EA3CC")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x19EA4E8", Offset = "0x19EA4E8", VA = "0x19EA4E8")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x19E9658", Offset = "0x19E9658", VA = "0x19E9658")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4C53C", Offset = "0xC4C53C")]
		private IEnumerator<float> _WatchCall(float timeframe, CoroutineHandle handle, GameObject gObject, Action onDone)
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x19E95C8", Offset = "0x19E95C8", VA = "0x19E95C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4C59C", Offset = "0xC4C59C")]
		private IEnumerator<float> _CallContinuously(float period, Action action, GameObject gObject)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003BF")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003C0")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003C1")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003C2")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003C3")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003C4")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003C5")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003C6")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003C7")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003C8")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003C9")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003CA")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003CB")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003CC")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003CD")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60003CE")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4C5FC", Offset = "0xC4C5FC")]
		private IEnumerator<float> _WatchCall<T>(T reference, float timeframe, CoroutineHandle handle, GameObject gObject, Action<T> onDone)
		{
			return null;
		}

		[Token(Token = "0x60003CF")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4C65C", Offset = "0xC4C65C")]
		private IEnumerator<float> _CallContinuously<T>(T reference, float period, Action<T> action, GameObject gObject)
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x19EA5F4", Offset = "0x19EA5F4", VA = "0x19EA5F4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C6BC", Offset = "0xC4C6BC")]
		public new Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x19EA5FC", Offset = "0x19EA5FC", VA = "0x19EA5FC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C6F8", Offset = "0xC4C6F8")]
		public new Coroutine StartCoroutine(string methodName, object value)
		{
			return null;
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x19EA604", Offset = "0x19EA604", VA = "0x19EA604")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C734", Offset = "0xC4C734")]
		public new Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x19EA60C", Offset = "0x19EA60C", VA = "0x19EA60C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C770", Offset = "0xC4C770")]
		public new Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x19EA614", Offset = "0x19EA614", VA = "0x19EA614")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C7AC", Offset = "0xC4C7AC")]
		public new void StopCoroutine(string methodName)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x19EA618", Offset = "0x19EA618", VA = "0x19EA618")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C7E8", Offset = "0xC4C7E8")]
		public new void StopCoroutine(IEnumerator routine)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x19EA61C", Offset = "0x19EA61C", VA = "0x19EA61C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C824", Offset = "0xC4C824")]
		public new void StopCoroutine(Coroutine routine)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x19EA620", Offset = "0x19EA620", VA = "0x19EA620")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C860", Offset = "0xC4C860")]
		public new void StopAllCoroutines()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x19EA624", Offset = "0x19EA624", VA = "0x19EA624")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C89C", Offset = "0xC4C89C")]
		public new static void Destroy(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x19EA628", Offset = "0x19EA628", VA = "0x19EA628")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C8D8", Offset = "0xC4C8D8")]
		public new static void Destroy(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x19EA62C", Offset = "0x19EA62C", VA = "0x19EA62C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C914", Offset = "0xC4C914")]
		public static void DestroyObject(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x19EA630", Offset = "0x19EA630", VA = "0x19EA630")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C950", Offset = "0xC4C950")]
		public static void DestroyObject(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x19EA634", Offset = "0x19EA634", VA = "0x19EA634")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C98C", Offset = "0xC4C98C")]
		public new static void DestroyImmediate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x19EA638", Offset = "0x19EA638", VA = "0x19EA638")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4C9C8", Offset = "0xC4C9C8")]
		public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x19EA63C", Offset = "0x19EA63C", VA = "0x19EA63C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4CA04", Offset = "0xC4CA04")]
		public new static void Instantiate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x19EA640", Offset = "0x19EA640", VA = "0x19EA640")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4CA40", Offset = "0xC4CA40")]
		public new static void Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60003E0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4CA7C", Offset = "0xC4CA7C")]
		public new static void Instantiate<T>(T original) where T : UnityEngine.Object
		{
		}

		[Token(Token = "0x60003E1")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4CAB8", Offset = "0xC4CAB8")]
		public new static T FindObjectOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x19EA644", Offset = "0x19EA644", VA = "0x19EA644")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4CAF4", Offset = "0xC4CAF4")]
		public new static UnityEngine.Object FindObjectOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4CB30", Offset = "0xC4CB30")]
		public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x19EA64C", Offset = "0x19EA64C", VA = "0x19EA64C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4CB6C", Offset = "0xC4CB6C")]
		public new static UnityEngine.Object[] FindObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x19EA654", Offset = "0x19EA654", VA = "0x19EA654")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xC4CBA8", Offset = "0xC4CBA8")]
		public new static void print(object message)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x19EA658", Offset = "0x19EA658", VA = "0x19EA658")]
		public Timing()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public enum Segment
	{
		[Token(Token = "0x400028D")]
		Invalid = -1,
		[Token(Token = "0x400028E")]
		Update,
		[Token(Token = "0x400028F")]
		FixedUpdate,
		[Token(Token = "0x4000290")]
		LateUpdate,
		[Token(Token = "0x4000291")]
		SlowUpdate,
		[Token(Token = "0x4000292")]
		RealtimeUpdate,
		[Token(Token = "0x4000293")]
		EditorUpdate,
		[Token(Token = "0x4000294")]
		EditorSlowUpdate,
		[Token(Token = "0x4000295")]
		EndOfFrame,
		[Token(Token = "0x4000296")]
		ManualTimeframe
	}
	[Token(Token = "0x2000069")]
	public enum DebugInfoType
	{
		[Token(Token = "0x4000298")]
		None,
		[Token(Token = "0x4000299")]
		SeperateCoroutines,
		[Token(Token = "0x400029A")]
		SeperateTags
	}
	[Token(Token = "0x200006A")]
	public enum SingletonBehavior
	{
		[Token(Token = "0x400029C")]
		Abort,
		[Token(Token = "0x400029D")]
		Overwrite,
		[Token(Token = "0x400029E")]
		Wait,
		[Token(Token = "0x400029F")]
		AbortAndUnpause
	}
	[Token(Token = "0x200006B")]
	public struct CoroutineHandle : IEquatable<CoroutineHandle>
	{
		[Token(Token = "0x200006C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48304", Offset = "0xC48304")]
		private sealed class <_OnDestroy>d__32 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CoroutineHandle watched;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action action;

			[Token(Token = "0x170000B8")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x1F05878", Offset = "0x1F05878", VA = "0x1F05878", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000B9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000454")]
				[Address(RVA = "0x1F058C0", Offset = "0x1F058C0", VA = "0x1F058C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600044F")]
			[Address(RVA = "0x1F057E0", Offset = "0x1F057E0", VA = "0x1F057E0")]
			[DebuggerHidden]
			public <_OnDestroy>d__32(int <>1__state)
			{
			}

			[Token(Token = "0x6000450")]
			[Address(RVA = "0x1F0580C", Offset = "0x1F0580C", VA = "0x1F0580C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000451")]
			[Address(RVA = "0x1F05810", Offset = "0x1F05810", VA = "0x1F05810", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x1F05880", Offset = "0x1F05880", VA = "0x1F05880", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200006D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48314", Offset = "0xC48314")]
		private sealed class <_OnDestroy>d__33 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CoroutineHandle watched;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> action;

			[Token(Token = "0x170000BA")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000458")]
				[Address(RVA = "0x1F05AD4", Offset = "0x1F05AD4", VA = "0x1F05AD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000BB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600045A")]
				[Address(RVA = "0x1F05B1C", Offset = "0x1F05B1C", VA = "0x1F05B1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x1F05920", Offset = "0x1F05920", VA = "0x1F05920")]
			[DebuggerHidden]
			public <_OnDestroy>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x1F0594C", Offset = "0x1F0594C", VA = "0x1F0594C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x1F05950", Offset = "0x1F05950", VA = "0x1F05950", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x1F05ADC", Offset = "0x1F05ADC", VA = "0x1F05ADC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002A0")]
		private const byte ReservedSpace = 15;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] NextIndex;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int _id;

		[Token(Token = "0x170000B1")]
		public byte Key
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x1454450", Offset = "0x1454450", VA = "0x1454450")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x170000B2")]
		public string Tag
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x1454984", Offset = "0x1454984", VA = "0x1454984")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x14549EC", Offset = "0x14549EC", VA = "0x14549EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public int? Layer
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x1454A68", Offset = "0x1454A68", VA = "0x1454A68")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x1454AD0", Offset = "0x1454AD0", VA = "0x1454AD0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public Segment Segment
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x1454BC8", Offset = "0x1454BC8", VA = "0x1454BC8")]
			get
			{
				return default(Segment);
			}
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x1454C30", Offset = "0x1454C30", VA = "0x1454C30")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public bool IsRunning
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x1454CA8", Offset = "0x1454CA8", VA = "0x1454CA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x1454D10", Offset = "0x1454D10", VA = "0x1454D10")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public bool IsAliveAndPaused
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x1454D98", Offset = "0x1454D98", VA = "0x1454D98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x1454E00", Offset = "0x1454E00", VA = "0x1454E00")]
			set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public bool IsValid
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x1454EA0", Offset = "0x1454EA0", VA = "0x1454EA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x145445C", Offset = "0x145445C", VA = "0x145445C")]
		public CoroutineHandle(byte ind)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1454544", Offset = "0x1454544", VA = "0x1454544")]
		public CoroutineHandle(CoroutineHandle other)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x145454C", Offset = "0x145454C", VA = "0x145454C", Slot = "4")]
		public bool Equals(CoroutineHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x145455C", Offset = "0x145455C", VA = "0x145455C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x14545E0", Offset = "0x14545E0", VA = "0x14545E0")]
		public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x14545EC", Offset = "0x14545EC", VA = "0x14545EC")]
		public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x14545F8", Offset = "0x14545F8", VA = "0x14545F8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1454600", Offset = "0x1454600", VA = "0x1454600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1454EB0", Offset = "0x1454EB0", VA = "0x1454EB0")]
		public CoroutineHandle OnDestroy(Action action, Segment segment = Segment.Update)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1455060", Offset = "0x1455060", VA = "0x1455060")]
		public CoroutineHandle OnDestroy(IEnumerator<float> action, Segment segment = Segment.Update)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1454FE4", Offset = "0x1454FE4", VA = "0x1454FE4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4CFA4", Offset = "0xC4CFA4")]
		private static IEnumerator<float> _OnDestroy(CoroutineHandle watched, Action action)
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1455194", Offset = "0x1455194", VA = "0x1455194")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4D004", Offset = "0xC4D004")]
		private static IEnumerator<float> _OnDestroy(CoroutineHandle watched, IEnumerator<float> action)
		{
			return null;
		}
	}
	[Token(Token = "0x200006E")]
	public static class MECExtensionMethods1
	{
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1464158", Offset = "0x1464158", VA = "0x1464158")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x14641C4", Offset = "0x14641C4", VA = "0x14641C4")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1464240", Offset = "0x1464240", VA = "0x1464240")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x14642BC", Offset = "0x14642BC", VA = "0x14642BC")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1464338", Offset = "0x1464338", VA = "0x1464338")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x14643BC", Offset = "0x14643BC", VA = "0x14643BC")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1464440", Offset = "0x1464440", VA = "0x1464440")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x14644BC", Offset = "0x14644BC", VA = "0x14644BC")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1464540", Offset = "0x1464540", VA = "0x1464540")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x14645C4", Offset = "0x14645C4", VA = "0x14645C4")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1464648", Offset = "0x1464648", VA = "0x1464648")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x14646DC", Offset = "0x14646DC", VA = "0x14646DC")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1464770", Offset = "0x1464770", VA = "0x1464770")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x14647F4", Offset = "0x14647F4", VA = "0x14647F4")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1464904", Offset = "0x1464904", VA = "0x1464904")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1464988", Offset = "0x1464988", VA = "0x1464988")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1464A0C", Offset = "0x1464A0C", VA = "0x1464A0C")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1464B34", Offset = "0x1464B34", VA = "0x1464B34")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1464BC8", Offset = "0x1464BC8", VA = "0x1464BC8")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1464C5C", Offset = "0x1464C5C", VA = "0x1464C5C")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1464D80", Offset = "0x1464D80", VA = "0x1464D80")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1464E14", Offset = "0x1464E14", VA = "0x1464E14")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1464EA8", Offset = "0x1464EA8", VA = "0x1464EA8")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1464FDC", Offset = "0x1464FDC", VA = "0x1464FDC")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1465078", Offset = "0x1465078", VA = "0x1465078")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x14650DC", Offset = "0x14650DC", VA = "0x14650DC")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1465150", Offset = "0x1465150", VA = "0x1465150")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x14651C4", Offset = "0x14651C4", VA = "0x14651C4")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, int layer, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1465240", Offset = "0x1465240", VA = "0x1465240")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x14652B4", Offset = "0x14652B4", VA = "0x14652B4")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1465330", Offset = "0x1465330", VA = "0x1465330")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x14653AC", Offset = "0x14653AC", VA = "0x14653AC")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
		{
			return default(float);
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x200006F")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x2000070")]
		public static class Utils
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x1F06E64", Offset = "0x1F06E64", VA = "0x1F06E64")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000071")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48344", Offset = "0xC48344")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x1F05E3C", Offset = "0x1F05E3C", VA = "0x1F05E3C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x1F05E44", Offset = "0x1F05E44", VA = "0x1F05E44")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x1F05E60", Offset = "0x1F05E60", VA = "0x1F05E60")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000072")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48354", Offset = "0xC48354")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x1F06104", Offset = "0x1F06104", VA = "0x1F06104")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x1F0610C", Offset = "0x1F0610C", VA = "0x1F0610C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x1F06130", Offset = "0x1F06130", VA = "0x1F06130")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000073")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48364", Offset = "0xC48364")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x1F06518", Offset = "0x1F06518", VA = "0x1F06518")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x1F06520", Offset = "0x1F06520", VA = "0x1F06520")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x1F06544", Offset = "0x1F06544", VA = "0x1F06544")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000074")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48374", Offset = "0xC48374")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x1F06A1C", Offset = "0x1F06A1C", VA = "0x1F06A1C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x1F06A24", Offset = "0x1F06A24", VA = "0x1F06A24")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x1F06A48", Offset = "0x1F06A48", VA = "0x1F06A48")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000075")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48384", Offset = "0xC48384")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x1F06B7C", Offset = "0x1F06B7C", VA = "0x1F06B7C")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x1F06B84", Offset = "0x1F06B84", VA = "0x1F06B84")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x1F06BA8", Offset = "0x1F06BA8", VA = "0x1F06BA8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000076")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48394", Offset = "0xC48394")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x1F06BCC", Offset = "0x1F06BCC", VA = "0x1F06BCC")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x1F06BD4", Offset = "0x1F06BD4", VA = "0x1F06BD4")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x1F06BF0", Offset = "0x1F06BF0", VA = "0x1F06BF0")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000077")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC483A4", Offset = "0xC483A4")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x1F06C0C", Offset = "0x1F06C0C", VA = "0x1F06C0C")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x1F06C14", Offset = "0x1F06C14", VA = "0x1F06C14")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x1F06C78", Offset = "0x1F06C78", VA = "0x1F06C78")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000078")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC483B4", Offset = "0xC483B4")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x1F06CD4", Offset = "0x1F06CD4", VA = "0x1F06CD4")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x1F06CDC", Offset = "0x1F06CDC", VA = "0x1F06CDC")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x1F06D40", Offset = "0x1F06D40", VA = "0x1F06D40")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000079")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC483C4", Offset = "0xC483C4")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x1F06D9C", Offset = "0x1F06D9C", VA = "0x1F06D9C")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x1F06DA4", Offset = "0x1F06DA4", VA = "0x1F06DA4")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x1F06E08", Offset = "0x1F06E08", VA = "0x1F06E08")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200007A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC483D4", Offset = "0xC483D4")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x1F05E7C", Offset = "0x1F05E7C", VA = "0x1F05E7C")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x1F05E84", Offset = "0x1F05E84", VA = "0x1F05E84")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x1F05EA4", Offset = "0x1F05EA4", VA = "0x1F05EA4")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200007B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC483E4", Offset = "0xC483E4")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x40002B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x1F05EC0", Offset = "0x1F05EC0", VA = "0x1F05EC0")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x1F05EC8", Offset = "0x1F05EC8", VA = "0x1F05EC8")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x1F05EE8", Offset = "0x1F05EE8", VA = "0x1F05EE8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200007C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC483F4", Offset = "0xC483F4")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x40002B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x1F05F04", Offset = "0x1F05F04", VA = "0x1F05F04")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x1F05F0C", Offset = "0x1F05F0C", VA = "0x1F05F0C")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x1F05F28", Offset = "0x1F05F28", VA = "0x1F05F28")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200007D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48404", Offset = "0xC48404")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x40002B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x1F05F44", Offset = "0x1F05F44", VA = "0x1F05F44")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x1F05F4C", Offset = "0x1F05F4C", VA = "0x1F05F4C")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x1F05F68", Offset = "0x1F05F68", VA = "0x1F05F68")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200007E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48414", Offset = "0xC48414")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x40002B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x1F05F84", Offset = "0x1F05F84", VA = "0x1F05F84")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x1F05F8C", Offset = "0x1F05F8C", VA = "0x1F05F8C")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x1F05FA8", Offset = "0x1F05FA8", VA = "0x1F05FA8")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200007F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48424", Offset = "0xC48424")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x40002B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x1F05FC4", Offset = "0x1F05FC4", VA = "0x1F05FC4")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x1F05FCC", Offset = "0x1F05FCC", VA = "0x1F05FCC")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x1F05FE8", Offset = "0x1F05FE8", VA = "0x1F05FE8")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000080")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48434", Offset = "0xC48434")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x40002BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x1F06004", Offset = "0x1F06004", VA = "0x1F06004")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x1F0600C", Offset = "0x1F0600C", VA = "0x1F0600C")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x1F06028", Offset = "0x1F06028", VA = "0x1F06028")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000081")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48444", Offset = "0xC48444")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x1F06044", Offset = "0x1F06044", VA = "0x1F06044")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x1F0604C", Offset = "0x1F0604C", VA = "0x1F0604C")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x1F06068", Offset = "0x1F06068", VA = "0x1F06068")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000082")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48454", Offset = "0xC48454")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x1F06084", Offset = "0x1F06084", VA = "0x1F06084")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x1F0608C", Offset = "0x1F0608C", VA = "0x1F0608C")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x1F060A8", Offset = "0x1F060A8", VA = "0x1F060A8")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000083")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48464", Offset = "0xC48464")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x1F060C4", Offset = "0x1F060C4", VA = "0x1F060C4")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x1F060CC", Offset = "0x1F060CC", VA = "0x1F060CC")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x1F060E8", Offset = "0x1F060E8", VA = "0x1F060E8")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000084")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48474", Offset = "0xC48474")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x1F06154", Offset = "0x1F06154", VA = "0x1F06154")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x1F0615C", Offset = "0x1F0615C", VA = "0x1F0615C")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x1F06178", Offset = "0x1F06178", VA = "0x1F06178")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000085")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48484", Offset = "0xC48484")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x1F06194", Offset = "0x1F06194", VA = "0x1F06194")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x1F0619C", Offset = "0x1F0619C", VA = "0x1F0619C")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x1F061B8", Offset = "0x1F061B8", VA = "0x1F061B8")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000086")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48494", Offset = "0xC48494")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x1F061D4", Offset = "0x1F061D4", VA = "0x1F061D4")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x1F061DC", Offset = "0x1F061DC", VA = "0x1F061DC")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x1F061F8", Offset = "0x1F061F8", VA = "0x1F061F8")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000087")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC484A4", Offset = "0xC484A4")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x1F06214", Offset = "0x1F06214", VA = "0x1F06214")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x1F0621C", Offset = "0x1F0621C", VA = "0x1F0621C")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x1F06238", Offset = "0x1F06238", VA = "0x1F06238")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000088")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC484B4", Offset = "0xC484B4")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x1F06254", Offset = "0x1F06254", VA = "0x1F06254")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x1F0625C", Offset = "0x1F0625C", VA = "0x1F0625C")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x1F06278", Offset = "0x1F06278", VA = "0x1F06278")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000089")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC484C4", Offset = "0xC484C4")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x1F06294", Offset = "0x1F06294", VA = "0x1F06294")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x1F0629C", Offset = "0x1F0629C", VA = "0x1F0629C")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x1F062B8", Offset = "0x1F062B8", VA = "0x1F062B8")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200008A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC484D4", Offset = "0xC484D4")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x1F062D4", Offset = "0x1F062D4", VA = "0x1F062D4")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x1F062DC", Offset = "0x1F062DC", VA = "0x1F062DC")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x1F06304", Offset = "0x1F06304", VA = "0x1F06304")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200008B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC484E4", Offset = "0xC484E4")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x1F06320", Offset = "0x1F06320", VA = "0x1F06320")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x1F06328", Offset = "0x1F06328", VA = "0x1F06328")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x1F06350", Offset = "0x1F06350", VA = "0x1F06350")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200008C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC484F4", Offset = "0xC484F4")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x1F0636C", Offset = "0x1F0636C", VA = "0x1F0636C")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x1F06374", Offset = "0x1F06374", VA = "0x1F06374")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x1F0639C", Offset = "0x1F0639C", VA = "0x1F0639C")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48504", Offset = "0xC48504")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x1F063B8", Offset = "0x1F063B8", VA = "0x1F063B8")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x1F063C0", Offset = "0x1F063C0", VA = "0x1F063C0")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x1F063DC", Offset = "0x1F063DC", VA = "0x1F063DC")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x1F063F8", Offset = "0x1F063F8", VA = "0x1F063F8")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x1F0642C", Offset = "0x1F0642C", VA = "0x1F0642C")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x1F06448", Offset = "0x1F06448", VA = "0x1F06448")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000500")]
			[Address(RVA = "0x1F06464", Offset = "0x1F06464", VA = "0x1F06464")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x200008E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48514", Offset = "0xC48514")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000501")]
			[Address(RVA = "0x1F06568", Offset = "0x1F06568", VA = "0x1F06568")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000502")]
			[Address(RVA = "0x1F06570", Offset = "0x1F06570", VA = "0x1F06570")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0x1F065C4", Offset = "0x1F065C4", VA = "0x1F065C4")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200008F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48524", Offset = "0xC48524")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000504")]
			[Address(RVA = "0x1F06610", Offset = "0x1F06610", VA = "0x1F06610")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000505")]
			[Address(RVA = "0x1F06618", Offset = "0x1F06618", VA = "0x1F06618")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000506")]
			[Address(RVA = "0x1F06634", Offset = "0x1F06634", VA = "0x1F06634")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48534", Offset = "0xC48534")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000507")]
			[Address(RVA = "0x1F06650", Offset = "0x1F06650", VA = "0x1F06650")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000508")]
			[Address(RVA = "0x1F06658", Offset = "0x1F06658", VA = "0x1F06658")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000509")]
			[Address(RVA = "0x1F06674", Offset = "0x1F06674", VA = "0x1F06674")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000091")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48544", Offset = "0xC48544")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x600050A")]
			[Address(RVA = "0x1F06690", Offset = "0x1F06690", VA = "0x1F06690")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x600050B")]
			[Address(RVA = "0x1F06698", Offset = "0x1F06698", VA = "0x1F06698")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600050C")]
			[Address(RVA = "0x1F066BC", Offset = "0x1F066BC", VA = "0x1F066BC")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000092")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48554", Offset = "0xC48554")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600050D")]
			[Address(RVA = "0x1F066E0", Offset = "0x1F066E0", VA = "0x1F066E0")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x600050E")]
			[Address(RVA = "0x1F066E8", Offset = "0x1F066E8", VA = "0x1F066E8")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600050F")]
			[Address(RVA = "0x1F0670C", Offset = "0x1F0670C", VA = "0x1F0670C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48564", Offset = "0xC48564")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Text target;

			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool addThousandsSeparator;

			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CultureInfo cInfo;

			[Token(Token = "0x6000510")]
			[Address(RVA = "0x1F06730", Offset = "0x1F06730", VA = "0x1F06730")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000511")]
			[Address(RVA = "0x1F06738", Offset = "0x1F06738", VA = "0x1F06738")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x6000512")]
			[Address(RVA = "0x1F06740", Offset = "0x1F06740", VA = "0x1F06740")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x2000094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48574", Offset = "0xC48574")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x40002D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000513")]
			[Address(RVA = "0x1F067DC", Offset = "0x1F067DC", VA = "0x1F067DC")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000514")]
			[Address(RVA = "0x1F067E4", Offset = "0x1F067E4", VA = "0x1F067E4")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000515")]
			[Address(RVA = "0x1F06808", Offset = "0x1F06808", VA = "0x1F06808")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48584", Offset = "0xC48584")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000516")]
			[Address(RVA = "0x1F0682C", Offset = "0x1F0682C", VA = "0x1F0682C")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000517")]
			[Address(RVA = "0x1F06834", Offset = "0x1F06834", VA = "0x1F06834")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000518")]
			[Address(RVA = "0x1F06858", Offset = "0x1F06858", VA = "0x1F06858")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x2000096")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48594", Offset = "0xC48594")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x6000519")]
			[Address(RVA = "0x1F0687C", Offset = "0x1F0687C", VA = "0x1F0687C")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x600051A")]
			[Address(RVA = "0x1F06884", Offset = "0x1F06884", VA = "0x1F06884")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600051B")]
			[Address(RVA = "0x1F06890", Offset = "0x1F06890", VA = "0x1F06890")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC485A4", Offset = "0xC485A4")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x600051C")]
			[Address(RVA = "0x1F0694C", Offset = "0x1F0694C", VA = "0x1F0694C")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x600051D")]
			[Address(RVA = "0x1F06954", Offset = "0x1F06954", VA = "0x1F06954")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600051E")]
			[Address(RVA = "0x1F06960", Offset = "0x1F06960", VA = "0x1F06960")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC485B4", Offset = "0xC485B4")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x600051F")]
			[Address(RVA = "0x1F06A6C", Offset = "0x1F06A6C", VA = "0x1F06A6C")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000520")]
			[Address(RVA = "0x1F06A74", Offset = "0x1F06A74", VA = "0x1F06A74")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000521")]
			[Address(RVA = "0x1F06A80", Offset = "0x1F06A80", VA = "0x1F06A80")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC485C4", Offset = "0xC485C4")]
		private sealed class <>c__DisplayClass41_0
		{
			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000522")]
			[Address(RVA = "0x1F06B3C", Offset = "0x1F06B3C", VA = "0x1F06B3C")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x6000523")]
			[Address(RVA = "0x1F06B44", Offset = "0x1F06B44", VA = "0x1F06B44")]
			internal Vector2 <DOShapeCircle>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0x1F06B60", Offset = "0x1F06B60", VA = "0x1F06B60")]
			internal void <DOShapeCircle>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1455760", Offset = "0x1455760", VA = "0x1455760")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x14558F8", Offset = "0x14558F8", VA = "0x14558F8")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1455AB8", Offset = "0x1455AB8", VA = "0x1455AB8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1455C50", Offset = "0x1455C50", VA = "0x1455C50")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1455E10", Offset = "0x1455E10", VA = "0x1455E10")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1455FA8", Offset = "0x1455FA8", VA = "0x1455FA8")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1456164", Offset = "0x1456164", VA = "0x1456164")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1456358", Offset = "0x1456358", VA = "0x1456358")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1456510", Offset = "0x1456510", VA = "0x1456510")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x14566C8", Offset = "0x14566C8", VA = "0x14566C8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1456880", Offset = "0x1456880", VA = "0x1456880")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1456A40", Offset = "0x1456A40", VA = "0x1456A40")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1456BD8", Offset = "0x1456BD8", VA = "0x1456BD8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1456D80", Offset = "0x1456D80", VA = "0x1456D80")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1456F38", Offset = "0x1456F38", VA = "0x1456F38")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x14570E8", Offset = "0x14570E8", VA = "0x14570E8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1457298", Offset = "0x1457298", VA = "0x1457298")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1457458", Offset = "0x1457458", VA = "0x1457458")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x145760C", Offset = "0x145760C", VA = "0x145760C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x14577C0", Offset = "0x14577C0", VA = "0x14577C0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1457974", Offset = "0x1457974", VA = "0x1457974")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1457B2C", Offset = "0x1457B2C", VA = "0x1457B2C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1457CE4", Offset = "0x1457CE4", VA = "0x1457CE4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1457E8C", Offset = "0x1457E8C", VA = "0x1457E8C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x1458038", Offset = "0x1458038", VA = "0x1458038")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x14581E4", Offset = "0x14581E4", VA = "0x14581E4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x145839C", Offset = "0x145839C", VA = "0x145839C")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x1458564", Offset = "0x1458564", VA = "0x1458564")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x145874C", Offset = "0x145874C", VA = "0x145874C")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x145893C", Offset = "0x145893C", VA = "0x145893C")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1458D68", Offset = "0x1458D68", VA = "0x1458D68")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1458F14", Offset = "0x1458F14", VA = "0x1458F14")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x14590B0", Offset = "0x14590B0", VA = "0x14590B0")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x145924C", Offset = "0x145924C", VA = "0x145924C")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x14593F4", Offset = "0x14593F4", VA = "0x14593F4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x14595B4", Offset = "0x14595B4", VA = "0x14595B4")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x14597B8", Offset = "0x14597B8", VA = "0x14597B8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1459950", Offset = "0x1459950", VA = "0x1459950")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1459B94", Offset = "0x1459B94", VA = "0x1459B94")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1459DE8", Offset = "0x1459DE8", VA = "0x1459DE8")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x145A03C", Offset = "0x145A03C", VA = "0x145A03C")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x145A290", Offset = "0x145A290", VA = "0x145A290")]
		public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x200009A")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC485E4", Offset = "0xC485E4")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000535")]
			[Address(RVA = "0x1F070A8", Offset = "0x1F070A8", VA = "0x1F070A8")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x1F070B0", Offset = "0x1F070B0", VA = "0x1F070B0")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x1F070D4", Offset = "0x1F070D4", VA = "0x1F070D4")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC485F4", Offset = "0xC485F4")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000538")]
			[Address(RVA = "0x1F070F8", Offset = "0x1F070F8", VA = "0x1F070F8")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000539")]
			[Address(RVA = "0x1F07100", Offset = "0x1F07100", VA = "0x1F07100")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0x1F07124", Offset = "0x1F07124", VA = "0x1F07124")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48604", Offset = "0xC48604")]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600053B")]
			[Address(RVA = "0x1F07148", Offset = "0x1F07148", VA = "0x1F07148", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600053C")]
			[Address(RVA = "0x1F0738C", Offset = "0x1F0738C", VA = "0x1F0738C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200009E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48614", Offset = "0xC48614")]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600053D")]
			[Address(RVA = "0x1F07A9C", Offset = "0x1F07A9C", VA = "0x1F07A9C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600053E")]
			[Address(RVA = "0x1F07D04", Offset = "0x1F07D04", VA = "0x1F07D04", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200009F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48624", Offset = "0xC48624")]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600053F")]
			[Address(RVA = "0x1F075F0", Offset = "0x1F075F0", VA = "0x1F075F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000540")]
			[Address(RVA = "0x1F07820", Offset = "0x1F07820", VA = "0x1F07820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48634", Offset = "0xC48634")]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x40002EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40002F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000541")]
			[Address(RVA = "0x1F07398", Offset = "0x1F07398", VA = "0x1F07398", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000542")]
			[Address(RVA = "0x1F075E4", Offset = "0x1F075E4", VA = "0x1F075E4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48644", Offset = "0xC48644")]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x40002F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000543")]
			[Address(RVA = "0x1F0782C", Offset = "0x1F0782C", VA = "0x1F0782C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0x1F07A90", Offset = "0x1F07A90", VA = "0x1F07A90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48654", Offset = "0xC48654")]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40002F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40002FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40002FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40002FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x1F07D10", Offset = "0x1F07D10", VA = "0x1F07D10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x1F07F48", Offset = "0x1F07F48", VA = "0x1F07F48", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x145A488", Offset = "0x145A488", VA = "0x145A488")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x145A678", Offset = "0x145A678", VA = "0x145A678")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x145A87C", Offset = "0x145A87C", VA = "0x145A87C")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x145A93C", Offset = "0x145A93C", VA = "0x145A93C")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x145A9FC", Offset = "0x145A9FC", VA = "0x145A9FC")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x145AABC", Offset = "0x145AABC", VA = "0x145AABC")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x145AB8C", Offset = "0x145AB8C", VA = "0x145AB8C")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x145AC5C", Offset = "0x145AC5C", VA = "0x145AC5C")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x145AD1C", Offset = "0x145AD1C", VA = "0x145AD1C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x145AF34", Offset = "0x145AF34", VA = "0x145AF34")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x145B14C", Offset = "0x145B14C", VA = "0x145B14C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xC4D644", Offset = "0xC4D644")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x145B250", Offset = "0x145B250", VA = "0x145B250")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xC4D6B4", Offset = "0xC4D6B4")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x145B354", Offset = "0x145B354", VA = "0x145B354")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xC4D724", Offset = "0xC4D724")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x145B458", Offset = "0x145B458", VA = "0x145B458")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xC4D794", Offset = "0xC4D794")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x145B56C", Offset = "0x145B56C", VA = "0x145B56C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xC4D804", Offset = "0xC4D804")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x145B680", Offset = "0x145B680", VA = "0x145B680")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xC4D874", Offset = "0xC4D874")]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A3")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x20000A4")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x40002FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000BC")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000547")]
				[Address(RVA = "0x1F05B7C", Offset = "0x1F05B7C", VA = "0x1F05B7C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0x1F05BB0", Offset = "0x1F05BB0", VA = "0x1F05BB0")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x20000A5")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x40002FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000BD")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000549")]
				[Address(RVA = "0x1F05D4C", Offset = "0x1F05D4C", VA = "0x1F05D4C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600054A")]
			[Address(RVA = "0x1F05DB0", Offset = "0x1F05DB0", VA = "0x1F05DB0")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x20000A6")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x40002FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000BE")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600054B")]
				[Address(RVA = "0x1F05C64", Offset = "0x1F05C64", VA = "0x1F05C64", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x1F05C80", Offset = "0x1F05C80", VA = "0x1F05C80")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x20000A7")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x4000300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x170000BF")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600054D")]
				[Address(RVA = "0x1F05BDC", Offset = "0x1F05BDC", VA = "0x1F05BDC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0x1F05C28", Offset = "0x1F05C28", VA = "0x1F05C28")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x20000A8")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x4000302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x170000C0")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600054F")]
				[Address(RVA = "0x1F05CAC", Offset = "0x1F05CAC", VA = "0x1F05CAC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000550")]
			[Address(RVA = "0x1F05D10", Offset = "0x1F05D10", VA = "0x1F05D10")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x20000A9")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000C1")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000551")]
				[Address(RVA = "0x1F05DDC", Offset = "0x1F05DDC", VA = "0x1F05DDC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0x1F05E10", Offset = "0x1F05E10", VA = "0x1F05E10")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x20000AA")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x20000AB")]
		public static class Physics
		{
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x1F07F54", Offset = "0x1F07F54", VA = "0x1F07F54")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0x1F07F70", Offset = "0x1F07F70", VA = "0x1F07F70")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0x1F07F78", Offset = "0x1F07F78", VA = "0x1F07F78")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000558")]
			[Address(RVA = "0x1F07F80", Offset = "0x1F07F80", VA = "0x1F07F80")]
			[Preserve]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x145B784", Offset = "0x145B784", VA = "0x145B784")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x145B848", Offset = "0x145B848", VA = "0x145B848")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
namespace Better.StreamingAssets
{
	[Token(Token = "0x20000AC")]
	public static class PathUtil
	{
		[Token(Token = "0x20000AD")]
		private enum NormalizeState
		{
			[Token(Token = "0x4000307")]
			PrevSlash,
			[Token(Token = "0x4000308")]
			PrevDot,
			[Token(Token = "0x4000309")]
			PrevDoubleDot,
			[Token(Token = "0x400030A")]
			NothingSpecial
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x19C73F4", Offset = "0x19C73F4", VA = "0x19C73F4")]
		public static bool IsDirectorySeparator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x19C7410", Offset = "0x19C7410", VA = "0x19C7410")]
		public static string FixTrailingDirectorySeparators(string path)
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x19C753C", Offset = "0x19C753C", VA = "0x19C753C")]
		public static string CombineSlash(string a, string b)
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x19C76A4", Offset = "0x19C76A4", VA = "0x19C76A4")]
		public static string NormalizeRelativePath(string relative, bool forceTrailingSlash = false)
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x19C7AD0", Offset = "0x19C7AD0", VA = "0x19C7AD0")]
		public static bool IsValidCharacter(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x19C7B34", Offset = "0x19C7B34", VA = "0x19C7B34")]
		public static Regex WildcardToRegex(string pattern)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AE")]
	internal class SubReadOnlyStream : Stream
	{
		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly long m_offset;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly bool m_leaveOpen;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long? m_length;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Stream m_actualStream;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private long m_position;

		[Token(Token = "0x170000C2")]
		public override long Length
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x19CC7C8", Offset = "0x19CC7C8", VA = "0x19CC7C8", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000C3")]
		public override long Position
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x19CC910", Offset = "0x19CC910", VA = "0x19CC910", Slot = "12")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x19CC93C", Offset = "0x19CC93C", VA = "0x19CC93C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public override bool CanRead
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x19CC980", Offset = "0x19CC980", VA = "0x19CC980", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C5")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x19CC9A0", Offset = "0x19CC9A0", VA = "0x19CC9A0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C6")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x19CC9C0", Offset = "0x19CC9C0", VA = "0x19CC9C0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x19CC5E8", Offset = "0x19CC5E8", VA = "0x19CC5E8")]
		public SubReadOnlyStream(Stream actualStream, bool leaveOpen = false)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x19CC6B8", Offset = "0x19CC6B8", VA = "0x19CC6B8")]
		public SubReadOnlyStream(Stream actualStream, long offset, long length, bool leaveOpen = false)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x19CC9C8", Offset = "0x19CC9C8", VA = "0x19CC9C8", Slot = "31")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x19CCB40", Offset = "0x19CCB40", VA = "0x19CCB40", Slot = "29")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x19CCC08", Offset = "0x19CCC08", VA = "0x19CCC08", Slot = "30")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x19CCC48", Offset = "0x19CCC48", VA = "0x19CCC48", Slot = "33")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x19CCC88", Offset = "0x19CCC88", VA = "0x19CCC88", Slot = "21")]
		public override void Flush()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x19CCCC8", Offset = "0x19CCCC8", VA = "0x19CCCC8", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x19CC888", Offset = "0x19CC888", VA = "0x19CC888")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x19CCAE4", Offset = "0x19CCAE4", VA = "0x19CCAE4")]
		private void ThrowIfCantRead()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class BSA_TestSceneGUI : MonoBehaviour
	{
		[Token(Token = "0x20000B0")]
		private class CoroutineHost : MonoBehaviour
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x1F03EEC", Offset = "0x1F03EEC", VA = "0x1F03EEC")]
			public CoroutineHost()
			{
			}
		}

		[Token(Token = "0x20000B1")]
		private class TestInfo
		{
			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReadMode readMode;

			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public TestType testType;

			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string path;

			[Token(Token = "0x4000320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int attempts;

			[Token(Token = "0x4000321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Exception error;

			[Token(Token = "0x4000322")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public TimeSpan duration;

			[Token(Token = "0x4000323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public long bytesRead;

			[Token(Token = "0x4000324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public long memoryPeak;

			[Token(Token = "0x4000325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public long maxMemoryPeak;

			[Token(Token = "0x600057C")]
			[Address(RVA = "0x1F034CC", Offset = "0x1F034CC", VA = "0x1F034CC")]
			public TestInfo()
			{
			}
		}

		[Token(Token = "0x20000B2")]
		private delegate void TestResultDelegate(TimeSpan avgDuration, long avgBytesRead, long avgMemoryPeak, long maxMemoryPeak, string[] assetNames);

		[Token(Token = "0x20000B3")]
		[Flags]
		private enum ReadMode
		{
			[Token(Token = "0x4000327")]
			BSA = 1,
			[Token(Token = "0x4000328")]
			WWW = 2,
			[Token(Token = "0x4000329")]
			Direct = 0x20,
			[Token(Token = "0x400032A")]
			UnityWebRequest = 0x40
		}

		[Token(Token = "0x20000B4")]
		[Flags]
		private enum TestType
		{
			[Token(Token = "0x400032C")]
			CheckIfExists = 1,
			[Token(Token = "0x400032D")]
			LoadBytes = 2
		}

		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48684", Offset = "0xC48684")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TestInfo testInfo;

			[Token(Token = "0x6000581")]
			[Address(RVA = "0x1F01E08", Offset = "0x1F01E08", VA = "0x1F01E08")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000582")]
			[Address(RVA = "0x1F01E10", Offset = "0x1F01E10", VA = "0x1F01E10")]
			internal void <TestAllCoroutine>b__0(TimeSpan duration, long bytes, long memory, long maxMemory, string[] names)
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x1F01E54", Offset = "0x1F01E54", VA = "0x1F01E54")]
			internal void <TestAllCoroutine>b__1(Exception ex)
			{
			}
		}

		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC48694", Offset = "0xC48694")]
		private sealed class <TestAllCoroutine>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BSA_TestSceneGUI <>4__this;

			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<TestInfo> results;

			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IEnumerable<string> paths;

			[Token(Token = "0x4000334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public ReadMode readModes;

			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public TestType testTypes;

			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int attempts;

			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private <>c__DisplayClass26_0 <>8__1;

			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private string <logPath>5__2;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private IEnumerator<string> <>7__wrap2;

			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private string <path>5__4;

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private IEnumerator <>7__wrap4;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private ReadMode <readMode>5__6;

			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private IEnumerator <>7__wrap6;

			[Token(Token = "0x170000C8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600058B")]
				[Address(RVA = "0x1F034E4", Offset = "0x1F034E4", VA = "0x1F034E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600058D")]
				[Address(RVA = "0x1F0352C", Offset = "0x1F0352C", VA = "0x1F0352C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000584")]
			[Address(RVA = "0x1F02118", Offset = "0x1F02118", VA = "0x1F02118")]
			[DebuggerHidden]
			public <TestAllCoroutine>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0x1F02144", Offset = "0x1F02144", VA = "0x1F02144", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0x1F02AAC", Offset = "0x1F02AAC", VA = "0x1F02AAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0x1F024A0", Offset = "0x1F024A0", VA = "0x1F024A0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0x1F023E4", Offset = "0x1F023E4", VA = "0x1F023E4")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0x1F0231C", Offset = "0x1F0231C", VA = "0x1F0231C")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x600058A")]
			[Address(RVA = "0x1F02254", Offset = "0x1F02254", VA = "0x1F02254")]
			private void <>m__Finally4()
			{
			}

			[Token(Token = "0x600058C")]
			[Address(RVA = "0x1F034EC", Offset = "0x1F034EC", VA = "0x1F034EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC486A4", Offset = "0xC486A4")]
		private sealed class <ErrorCatchingCoroutine>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BSA_TestSceneGUI <>4__this;

			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator inner;

			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<Exception> onError;

			[Token(Token = "0x170000CA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000591")]
				[Address(RVA = "0x1F020C8", Offset = "0x1F020C8", VA = "0x1F020C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000593")]
				[Address(RVA = "0x1F02110", Offset = "0x1F02110", VA = "0x1F02110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0x1F01E70", Offset = "0x1F01E70", VA = "0x1F01E70")]
			[DebuggerHidden]
			public <ErrorCatchingCoroutine>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x600058F")]
			[Address(RVA = "0x1F01E9C", Offset = "0x1F01E9C", VA = "0x1F01E9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000590")]
			[Address(RVA = "0x1F01EA0", Offset = "0x1F01EA0", VA = "0x1F01EA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000592")]
			[Address(RVA = "0x1F020D0", Offset = "0x1F020D0", VA = "0x1F020D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xC486B4", Offset = "0xC486B4")]
		private sealed class <TestHarness>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BSA_TestSceneGUI <>4__this;

			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string path;

			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ReadMode readMode;

			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public TestType testType;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int attempts;

			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public TestResultDelegate callback;

			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Stopwatch <stopwatch>5__2;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private string[] <assetNames>5__3;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private string <streamingAssetsUrl>5__4;

			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private long <bytesRead>5__5;

			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private long <maxMemoryPeak>5__6;

			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private long <totalMemoryPeaks>5__7;

			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private int <i>5__8;

			[Token(Token = "0x4000352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private IDisposable <toDispose>5__9;

			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private long <memoryUnityBefore>5__10;

			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private WWW <www>5__11;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private UnityWebRequest <www>5__12;

			[Token(Token = "0x170000CC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000597")]
				[Address(RVA = "0x1F03E9C", Offset = "0x1F03E9C", VA = "0x1F03E9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000599")]
				[Address(RVA = "0x1F03EE4", Offset = "0x1F03EE4", VA = "0x1F03EE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000594")]
			[Address(RVA = "0x1F03534", Offset = "0x1F03534", VA = "0x1F03534")]
			[DebuggerHidden]
			public <TestHarness>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x6000595")]
			[Address(RVA = "0x1F03560", Offset = "0x1F03560", VA = "0x1F03560", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000596")]
			[Address(RVA = "0x1F03564", Offset = "0x1F03564", VA = "0x1F03564", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0x1F03EA4", Offset = "0x1F03EA4", VA = "0x1F03EA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text InProgressText;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string EditorApkPath;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int RepetitionCount;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool LogToFile;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string m_status;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TestType m_testModes;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private ReadMode m_readModes;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CoroutineHost coroutineHost;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector2 m_assetsScroll;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector2 m_resultsScroll;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string[] m_allStreamingAssets;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<TestInfo> m_results;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private HashSet<string> m_selectedPaths;

		[Token(Token = "0x170000C7")]
		private string StreamingAssetsPath
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x144DBCC", Offset = "0x144DBCC", VA = "0x144DBCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x144B808", Offset = "0x144B808", VA = "0x144B808")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x144B828", Offset = "0x144B828", VA = "0x144B828")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x144B848", Offset = "0x144B848", VA = "0x144B848")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x144D604", Offset = "0x144D604", VA = "0x144D604")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x144D818", Offset = "0x144D818", VA = "0x144D818")]
		private void DoTestTypeToggle(TestType testMode)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x144D9A0", Offset = "0x144D9A0", VA = "0x144D9A0")]
		private void DoReadModeToggle(ReadMode readMode)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x144DB28", Offset = "0x144DB28", VA = "0x144DB28")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4D984", Offset = "0xC4D984")]
		private IEnumerator TestAllCoroutine(IEnumerable<string> paths, int attempts, ReadMode readModes, TestType testTypes, List<TestInfo> results)
		{
			return null;
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x144DBDC", Offset = "0x144DBDC", VA = "0x144DBDC")]
		private void LogWorkProgress(string status)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x144DCBC", Offset = "0x144DCBC", VA = "0x144DCBC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4D9E4", Offset = "0xC4D9E4")]
		private IEnumerator ErrorCatchingCoroutine(IEnumerator inner, Action<Exception> onError)
		{
			return null;
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x144DD3C", Offset = "0x144DD3C", VA = "0x144DD3C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xC4DA44", Offset = "0xC4DA44")]
		private IEnumerator TestHarness(ReadMode readMode, string path, TestType testType, int attempts, TestResultDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x144DDE0", Offset = "0x144DDE0", VA = "0x144DDE0")]
		public BSA_TestSceneGUI()
		{
		}
	}
}
namespace Better.StreamingAssets.ZipArchive
{
	[Token(Token = "0x20000B9")]
	internal struct ZipGenericExtraField
	{
		[Token(Token = "0x4000356")]
		private const int SizeOfHeader = 4;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort _tag;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private ushort _size;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private byte[] _data;

		[Token(Token = "0x170000CE")]
		public ushort Tag
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x1F01AA0", Offset = "0x1F01AA0", VA = "0x1F01AA0")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x170000CF")]
		public ushort Size
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x1F01AA8", Offset = "0x1F01AA8", VA = "0x1F01AA8")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x170000D0")]
		public byte[] Data
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x1F01AB0", Offset = "0x1F01AB0", VA = "0x1F01AB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1F00AD4", Offset = "0x1F00AD4", VA = "0x1F00AD4")]
		public static bool TryReadBlock(BinaryReader reader, long endExtraField, out ZipGenericExtraField field)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000BA")]
	internal struct Zip64ExtraField
	{
		[Token(Token = "0x400035A")]
		public const int OffsetToFirstField = 4;

		[Token(Token = "0x400035B")]
		private const ushort TagConstant = 1;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort _size;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private long? _uncompressedSize;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private long? _compressedSize;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private long? _localHeaderOffset;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int? _startDiskNumber;

		[Token(Token = "0x170000D1")]
		public long? UncompressedSize
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x1F0021C", Offset = "0x1F0021C", VA = "0x1F0021C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x1F00228", Offset = "0x1F00228", VA = "0x1F00228")]
			set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public long? CompressedSize
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x1F002BC", Offset = "0x1F002BC", VA = "0x1F002BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x1F002C8", Offset = "0x1F002C8", VA = "0x1F002C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public long? LocalHeaderOffset
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x1F002D0", Offset = "0x1F002D0", VA = "0x1F002D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x1F002DC", Offset = "0x1F002DC", VA = "0x1F002DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public int? StartDiskNumber
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x1F002E4", Offset = "0x1F002E4", VA = "0x1F002E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1F00230", Offset = "0x1F00230", VA = "0x1F00230")]
		private void UpdateSize()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1F002EC", Offset = "0x1F002EC", VA = "0x1F002EC")]
		public static Zip64ExtraField GetJustZip64Block(Stream extraFieldStream, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber)
		{
			return default(Zip64ExtraField);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1F00534", Offset = "0x1F00534", VA = "0x1F00534")]
		private static bool TryGetZip64BlockFromGenericExtraField(ZipGenericExtraField extraField, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber, out Zip64ExtraField zip64Block)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000BB")]
	internal struct Zip64EndOfCentralDirectoryLocator
	{
		[Token(Token = "0x4000361")]
		public const uint SignatureConstant = 117853008u;

		[Token(Token = "0x4000362")]
		public const int SizeOfBlockWithoutSignature = 16;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint NumberOfDiskWithZip64EOCD;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong OffsetOfZip64EOCD;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint TotalNumberOfDisks;

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1F0003C", Offset = "0x1F0003C", VA = "0x1F0003C")]
		public static bool TryReadBlock(BinaryReader reader, out Zip64EndOfCentralDirectoryLocator zip64EOCDLocator)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000BC")]
	internal struct Zip64EndOfCentralDirectoryRecord
	{
		[Token(Token = "0x4000366")]
		private const uint SignatureConstant = 101075792u;

		[Token(Token = "0x4000367")]
		private const ulong NormalSize = 44uL;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong SizeOfThisRecord;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort VersionMadeBy;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public ushort VersionNeededToExtract;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint NumberOfThisDisk;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint NumberOfDiskWithStartOfCD;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ulong NumberOfEntriesOnThisDisk;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ulong NumberOfEntriesTotal;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ulong SizeOfCentralDirectory;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ulong OffsetOfCentralDirectory;

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1F000E0", Offset = "0x1F000E0", VA = "0x1F000E0")]
		public static bool TryReadBlock(BinaryReader reader, out Zip64EndOfCentralDirectoryRecord zip64EOCDRecord)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000BD")]
	internal struct ZipLocalFileHeader
	{
		[Token(Token = "0x4000371")]
		public const uint DataDescriptorSignature = 134695760u;

		[Token(Token = "0x4000372")]
		public const uint SignatureConstant = 67324752u;

		[Token(Token = "0x4000373")]
		public const int OffsetToCrcFromHeaderStart = 14;

		[Token(Token = "0x4000374")]
		public const int OffsetToBitFlagFromHeaderStart = 6;

		[Token(Token = "0x4000375")]
		public const int SizeOfLocalHeader = 30;

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1F01C7C", Offset = "0x1F01C7C", VA = "0x1F01C7C")]
		public static bool TrySkipBlock(BinaryReader reader)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000BE")]
	internal struct ZipCentralDirectoryFileHeader
	{
		[Token(Token = "0x4000376")]
		public const uint SignatureConstant = 33639248u;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte VersionMadeByCompatibility;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte VersionMadeBySpecification;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public ushort VersionNeededToExtract;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ushort GeneralPurposeBitFlag;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public ushort CompressionMethod;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint LastModified;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint Crc32;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long CompressedSize;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long UncompressedSize;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ushort FilenameLength;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public ushort ExtraFieldLength;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ushort FileCommentLength;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int DiskNumberStart;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ushort InternalFileAttributes;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint ExternalFileAttributes;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public long RelativeOffsetOfLocalHeader;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public byte[] Filename;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public byte[] FileComment;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<ZipGenericExtraField> ExtraFields;

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1F01400", Offset = "0x1F01400", VA = "0x1F01400")]
		public static bool TryReadBlock(BinaryReader reader, out ZipCentralDirectoryFileHeader header)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000BF")]
	internal struct ZipEndOfCentralDirectoryBlock
	{
		[Token(Token = "0x400038A")]
		public const uint SignatureConstant = 101010256u;

		[Token(Token = "0x400038B")]
		public const int SizeOfBlockWithoutSignature = 18;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint Signature;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ushort NumberOfThisDisk;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public ushort NumberOfTheDiskWithTheStartOfTheCentralDirectory;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort NumberOfEntriesInTheCentralDirectoryOnThisDisk;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public ushort NumberOfEntriesInTheCentralDirectory;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint SizeOfCentralDirectory;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint OffsetOfStartOfCentralDirectoryWithRespectToTheStartingDiskNumber;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte[] ArchiveComment;

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1F012D8", Offset = "0x1F012D8", VA = "0x1F012D8")]
		public static bool TryReadBlock(BinaryReader reader, out ZipEndOfCentralDirectoryBlock eocdBlock)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000C0")]
	internal static class ZipHelper
	{
		[Token(Token = "0x4000394")]
		internal const uint Mask32Bit = uint.MaxValue;

		[Token(Token = "0x4000395")]
		internal const ushort Mask16Bit = ushort.MaxValue;

		[Token(Token = "0x4000396")]
		private const int BackwardsSeekingBufferSize = 32;

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1F01AB8", Offset = "0x1F01AB8", VA = "0x1F01AB8")]
		internal static void ReadBytes(Stream stream, byte[] buffer, int bytesToRead)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1F011D4", Offset = "0x1F011D4", VA = "0x1F011D4")]
		internal static bool SeekBackwardsToSignature(Stream stream, uint signatureToFind)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1F019B0", Offset = "0x1F019B0", VA = "0x1F019B0")]
		internal static void AdvanceToPosition(this Stream stream, long position)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1F01B60", Offset = "0x1F01B60", VA = "0x1F01B60")]
		private static bool SeekBackwardsAndRead(Stream stream, byte[] buffer, out int bufferPointer)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000C1")]
	public class ZipArchiveException : Exception
	{
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1F00BB8", Offset = "0x1F00BB8", VA = "0x1F00BB8")]
		public ZipArchiveException(string msg)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1F00C2C", Offset = "0x1F00C2C", VA = "0x1F00C2C")]
		public ZipArchiveException(string msg, Exception inner)
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public static class ZipArchiveUtils
	{
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1F00CA8", Offset = "0x1F00CA8", VA = "0x1F00CA8")]
		public static void ReadEndOfCentralDirectory(Stream stream, BinaryReader reader, out long expectedNumberOfEntries, out long centralDirectoryStart)
		{
		}
	}
}
