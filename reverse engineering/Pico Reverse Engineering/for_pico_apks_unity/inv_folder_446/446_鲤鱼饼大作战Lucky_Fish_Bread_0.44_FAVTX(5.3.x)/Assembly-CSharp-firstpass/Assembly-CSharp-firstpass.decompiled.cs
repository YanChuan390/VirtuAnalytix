using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;
using MEC;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class MECExtensionMethods2
{
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586A24", Offset = "0x586A24")]
	private sealed class <Delay>d__0 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float timeToDelay;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700000E")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x104170C", Offset = "0x104170C", VA = "0x104170C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x1041774", Offset = "0x1041774", VA = "0x1041774", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x103FBA4", Offset = "0x103FBA4", VA = "0x103FBA4")]
		[DebuggerHidden]
		public <Delay>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x104155C", Offset = "0x104155C", VA = "0x104155C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1041560", Offset = "0x1041560", VA = "0x1041560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1041714", Offset = "0x1041714", VA = "0x1041714", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586A34", Offset = "0x586A34")]
	private sealed class <Delay>d__1 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000010")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1041964", Offset = "0x1041964", VA = "0x1041964", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000011")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x10419CC", Offset = "0x10419CC", VA = "0x10419CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x103FC4C", Offset = "0x103FC4C", VA = "0x103FC4C")]
		[DebuggerHidden]
		public <Delay>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x10417D8", Offset = "0x10417D8", VA = "0x10417D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x10417DC", Offset = "0x10417DC", VA = "0x10417DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x104196C", Offset = "0x104196C", VA = "0x104196C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586A44", Offset = "0x586A44")]
	private sealed class <Delay>d__2<T> : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Func<T, bool> condition;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T data;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000012")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600015C")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000013")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600015E")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000159")]
		[DebuggerHidden]
		public <Delay>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x600015A")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600015B")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600015D")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586A54", Offset = "0x586A54")]
	private sealed class <DelayFrames>d__3 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int framesToDelay;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000014")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x1041BB0", Offset = "0x1041BB0", VA = "0x1041BB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000015")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x1041C18", Offset = "0x1041C18", VA = "0x1041C18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x103FCF8", Offset = "0x103FCF8", VA = "0x103FCF8")]
		[DebuggerHidden]
		public <DelayFrames>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1041A30", Offset = "0x1041A30", VA = "0x1041A30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1041A34", Offset = "0x1041A34", VA = "0x1041A34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1041BB8", Offset = "0x1041BB8", VA = "0x1041BB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586A64", Offset = "0x586A64")]
	private sealed class <CancelWith>d__4 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject;

		[Token(Token = "0x17000016")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x1040E84", Offset = "0x1040E84", VA = "0x1040E84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x1040EEC", Offset = "0x1040EEC", VA = "0x1040EEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x103FDA0", Offset = "0x103FDA0", VA = "0x103FDA0")]
		[DebuggerHidden]
		public <CancelWith>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1040C60", Offset = "0x1040C60", VA = "0x1040C60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1040C64", Offset = "0x1040C64", VA = "0x1040C64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1040E8C", Offset = "0x1040E8C", VA = "0x1040E8C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586A74", Offset = "0x586A74")]
	private sealed class <CancelWith>d__5 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject1;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gameObject2;

		[Token(Token = "0x17000018")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x10411B4", Offset = "0x10411B4", VA = "0x10411B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x104121C", Offset = "0x104121C", VA = "0x104121C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x103FE50", Offset = "0x103FE50", VA = "0x103FE50")]
		[DebuggerHidden]
		public <CancelWith>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1040F50", Offset = "0x1040F50", VA = "0x1040F50", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1040F54", Offset = "0x1040F54", VA = "0x1040F54", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x10411BC", Offset = "0x10411BC", VA = "0x10411BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586A84", Offset = "0x586A84")]
	private sealed class <CancelWith>d__6<T> : IEnumerator<float>, IEnumerator, IDisposable where T : MonoBehaviour
	{
		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T script;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GameObject <myGO>5__2;

		[Token(Token = "0x1700001A")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000174")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000176")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000171")]
		[DebuggerHidden]
		public <CancelWith>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000172")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000173")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586A94", Offset = "0x586A94")]
	private sealed class <CancelWith>d__7 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700001C")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x1041490", Offset = "0x1041490", VA = "0x1041490", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x10414F8", Offset = "0x10414F8", VA = "0x10414F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x103FEF8", Offset = "0x103FEF8", VA = "0x103FEF8")]
		[DebuggerHidden]
		public <CancelWith>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1041280", Offset = "0x1041280", VA = "0x1041280", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1041284", Offset = "0x1041284", VA = "0x1041284", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1041498", Offset = "0x1041498", VA = "0x1041498", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586AA4", Offset = "0x586AA4")]
	private sealed class <PauseWith>d__8 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700001E")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x1042614", Offset = "0x1042614", VA = "0x1042614", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x104267C", Offset = "0x104267C", VA = "0x104267C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x103FFA0", Offset = "0x103FFA0", VA = "0x103FFA0")]
		[DebuggerHidden]
		public <PauseWith>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x10423E4", Offset = "0x10423E4", VA = "0x10423E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x10423E8", Offset = "0x10423E8", VA = "0x10423E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x104261C", Offset = "0x104261C", VA = "0x104261C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586AB4", Offset = "0x586AB4")]
	private sealed class <PauseWith>d__9 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject1;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject2;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000020")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x1042950", Offset = "0x1042950", VA = "0x1042950", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x10429B8", Offset = "0x10429B8", VA = "0x10429B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1040050", Offset = "0x1040050", VA = "0x1040050")]
		[DebuggerHidden]
		public <PauseWith>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x10426E0", Offset = "0x10426E0", VA = "0x10426E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x10426E4", Offset = "0x10426E4", VA = "0x10426E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1042958", Offset = "0x1042958", VA = "0x1042958", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586AC4", Offset = "0x586AC4")]
	private sealed class <PauseWith>d__10<T> : IEnumerator<float>, IEnumerator, IDisposable where T : MonoBehaviour
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T script;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GameObject <myGO>5__2;

		[Token(Token = "0x17000022")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600018C")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600018E")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000189")]
		[DebuggerHidden]
		public <PauseWith>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x600018A")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600018B")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586AD4", Offset = "0x586AD4")]
	private sealed class <PauseWith>d__11 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000024")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x1042318", Offset = "0x1042318", VA = "0x1042318", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x1042380", Offset = "0x1042380", VA = "0x1042380", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x10400F8", Offset = "0x10400F8", VA = "0x10400F8")]
		[DebuggerHidden]
		public <PauseWith>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1042108", Offset = "0x1042108", VA = "0x1042108", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x104210C", Offset = "0x104210C", VA = "0x104210C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1042320", Offset = "0x1042320", VA = "0x1042320", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586AE4", Offset = "0x586AE4")]
	private sealed class <KillWith>d__12 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CoroutineHandle otherCoroutine;

		[Token(Token = "0x17000026")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x104203C", Offset = "0x104203C", VA = "0x104203C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x10420A4", Offset = "0x10420A4", VA = "0x10420A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x10401A4", Offset = "0x10401A4", VA = "0x10401A4")]
		[DebuggerHidden]
		public <KillWith>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1041ED8", Offset = "0x1041ED8", VA = "0x1041ED8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1041EDC", Offset = "0x1041EDC", VA = "0x1041EDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1042044", Offset = "0x1042044", VA = "0x1042044", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586AF4", Offset = "0x586AF4")]
	private sealed class <Append>d__13 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> nextCoroutine;

		[Token(Token = "0x17000028")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x1040964", Offset = "0x1040964", VA = "0x1040964", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x10409CC", Offset = "0x10409CC", VA = "0x10409CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x104024C", Offset = "0x104024C", VA = "0x104024C")]
		[DebuggerHidden]
		public <Append>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x10406F0", Offset = "0x10406F0", VA = "0x10406F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x10406F4", Offset = "0x10406F4", VA = "0x10406F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x104096C", Offset = "0x104096C", VA = "0x104096C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586B04", Offset = "0x586B04")]
	private sealed class <Append>d__14 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action onDone;

		[Token(Token = "0x1700002A")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x1040B94", Offset = "0x1040B94", VA = "0x1040B94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x1040BFC", Offset = "0x1040BFC", VA = "0x1040BFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x10402F4", Offset = "0x10402F4", VA = "0x10402F4")]
		[DebuggerHidden]
		public <Append>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1040A30", Offset = "0x1040A30", VA = "0x1040A30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1040A34", Offset = "0x1040A34", VA = "0x1040A34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1040B9C", Offset = "0x1040B9C", VA = "0x1040B9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586B14", Offset = "0x586B14")]
	private sealed class <Prepend>d__15 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> lastCoroutine;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700002C")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x1042CA4", Offset = "0x1042CA4", VA = "0x1042CA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x1042D0C", Offset = "0x1042D0C", VA = "0x1042D0C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x104039C", Offset = "0x104039C", VA = "0x104039C")]
		[DebuggerHidden]
		public <Prepend>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1042A1C", Offset = "0x1042A1C", VA = "0x1042A1C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1042A20", Offset = "0x1042A20", VA = "0x1042A20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1042CAC", Offset = "0x1042CAC", VA = "0x1042CAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586B24", Offset = "0x586B24")]
	private sealed class <Prepend>d__16 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onStart;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700002E")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x1042EE4", Offset = "0x1042EE4", VA = "0x1042EE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x1042F4C", Offset = "0x1042F4C", VA = "0x1042F4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1040444", Offset = "0x1040444", VA = "0x1040444")]
		[DebuggerHidden]
		public <Prepend>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1042D70", Offset = "0x1042D70", VA = "0x1042D70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1042D74", Offset = "0x1042D74", VA = "0x1042D74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1042EEC", Offset = "0x1042EEC", VA = "0x1042EEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586B34", Offset = "0x586B34")]
	private sealed class <Superimpose>d__18 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutineA;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Timing instance;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> coroutineB;

		[Token(Token = "0x17000030")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x104387C", Offset = "0x104387C", VA = "0x104387C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000031")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x10438E4", Offset = "0x10438E4", VA = "0x10438E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1040574", Offset = "0x1040574", VA = "0x1040574")]
		[DebuggerHidden]
		public <Superimpose>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1043268", Offset = "0x1043268", VA = "0x1043268", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x104326C", Offset = "0x104326C", VA = "0x104326C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1043884", Offset = "0x1043884", VA = "0x1043884", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586B44", Offset = "0x586B44")]
	private sealed class <Hijack>d__19 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<float, float> newReturn;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000032")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x1041E0C", Offset = "0x1041E0C", VA = "0x1041E0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000033")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x1041E74", Offset = "0x1041E74", VA = "0x1041E74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x104061C", Offset = "0x104061C", VA = "0x104061C")]
		[DebuggerHidden]
		public <Hijack>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1041C7C", Offset = "0x1041C7C", VA = "0x1041C7C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1041C80", Offset = "0x1041C80", VA = "0x1041C80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1041E14", Offset = "0x1041E14", VA = "0x1041E14", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586B54", Offset = "0x586B54")]
	private sealed class <RerouteExceptions>d__20 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<Exception> exceptionHandler;

		[Token(Token = "0x17000034")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x104319C", Offset = "0x104319C", VA = "0x104319C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000035")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x1043204", Offset = "0x1043204", VA = "0x1043204", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x10406C4", Offset = "0x10406C4", VA = "0x10406C4")]
		[DebuggerHidden]
		public <RerouteExceptions>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1042FB0", Offset = "0x1042FB0", VA = "0x1042FB0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1042FB4", Offset = "0x1042FB4", VA = "0x1042FB4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x10431A4", Offset = "0x10431A4", VA = "0x10431A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x103FB24", Offset = "0x103FB24", VA = "0x103FB24")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x586F44", Offset = "0x586F44")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, float timeToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x103FBD0", Offset = "0x103FBD0", VA = "0x103FBD0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x586FB8", Offset = "0x586FB8")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58702C", Offset = "0x58702C")]
	public static IEnumerator<float> Delay<T>(this IEnumerator<float> coroutine, T data, Func<T, bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x103FC78", Offset = "0x103FC78", VA = "0x103FC78")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5870A0", Offset = "0x5870A0")]
	public static IEnumerator<float> DelayFrames(this IEnumerator<float> coroutine, int framesToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x103FD24", Offset = "0x103FD24", VA = "0x103FD24")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587114", Offset = "0x587114")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x103FDCC", Offset = "0x103FDCC", VA = "0x103FDCC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587188", Offset = "0x587188")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5871FC", Offset = "0x5871FC")]
	public static IEnumerator<float> CancelWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x103FE7C", Offset = "0x103FE7C", VA = "0x103FE7C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587270", Offset = "0x587270")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x103FF24", Offset = "0x103FF24", VA = "0x103FF24")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5872E4", Offset = "0x5872E4")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x103FFCC", Offset = "0x103FFCC", VA = "0x103FFCC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587358", Offset = "0x587358")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5873CC", Offset = "0x5873CC")]
	public static IEnumerator<float> PauseWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x104007C", Offset = "0x104007C", VA = "0x104007C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587440", Offset = "0x587440")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1040124", Offset = "0x1040124", VA = "0x1040124")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5874B4", Offset = "0x5874B4")]
	public static IEnumerator<float> KillWith(this IEnumerator<float> coroutine, CoroutineHandle otherCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x10401D0", Offset = "0x10401D0", VA = "0x10401D0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587528", Offset = "0x587528")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, IEnumerator<float> nextCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1040278", Offset = "0x1040278", VA = "0x1040278")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58759C", Offset = "0x58759C")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1040320", Offset = "0x1040320", VA = "0x1040320")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587610", Offset = "0x587610")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, IEnumerator<float> lastCoroutine)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x10403C8", Offset = "0x10403C8", VA = "0x10403C8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587684", Offset = "0x587684")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, Action onStart)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1040470", Offset = "0x1040470", VA = "0x1040470")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x10404F0", Offset = "0x10404F0", VA = "0x10404F0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587708", Offset = "0x587708")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB, Timing instance)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x10405A0", Offset = "0x10405A0", VA = "0x10405A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58777C", Offset = "0x58777C")]
	public static IEnumerator<float> Hijack(this IEnumerator<float> coroutine, Func<float, float> newReturn)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1040648", Offset = "0x1040648", VA = "0x1040648")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5877F0", Offset = "0x5877F0")]
	public static IEnumerator<float> RerouteExceptions(this IEnumerator<float> coroutine, Action<Exception> exceptionHandler)
	{
		return null;
	}
}
namespace MEC;

[Token(Token = "0x2000003")]
public class Timing : MonoBehaviour
{
	[Token(Token = "0x200001D")]
	private struct ProcessIndex : IEquatable<ProcessIndex>
	{
		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Segment seg;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int i;

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x103FA04", Offset = "0x103FA04", VA = "0x103FA04", Slot = "4")]
		public bool Equals(ProcessIndex other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x103FA2C", Offset = "0x103FA2C", VA = "0x103FA2C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x103FAC4", Offset = "0x103FAC4", VA = "0x103FAC4")]
		public static bool operator ==(ProcessIndex a, ProcessIndex b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x103FAE4", Offset = "0x103FAE4", VA = "0x103FAE4")]
		public static bool operator !=(ProcessIndex a, ProcessIndex b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x103FB04", Offset = "0x103FB04", VA = "0x103FB04", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586B64", Offset = "0x586B64")]
	private sealed class <_EOFPumpWatcher>d__132 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Timing <>4__this;

		[Token(Token = "0x17000036")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x103EA40", Offset = "0x103EA40", VA = "0x103EA40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000037")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x103EAA8", Offset = "0x103EAA8", VA = "0x103EAA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x103E980", Offset = "0x103E980", VA = "0x103E980")]
		[DebuggerHidden]
		public <_EOFPumpWatcher>d__132(int <>1__state)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x103E9AC", Offset = "0x103E9AC", VA = "0x103E9AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x103E9B0", Offset = "0x103E9B0", VA = "0x103E9B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x103EA48", Offset = "0x103EA48", VA = "0x103EA48", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586B74", Offset = "0x586B74")]
	private sealed class <_EOFPump>d__133 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Timing <>4__this;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x103E910", Offset = "0x103E910", VA = "0x103E910", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x103E978", Offset = "0x103E978", VA = "0x103E978", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x103E130", Offset = "0x103E130", VA = "0x103E130")]
		[DebuggerHidden]
		public <_EOFPump>d__133(int <>1__state)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x103E15C", Offset = "0x103E15C", VA = "0x103E15C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x103E160", Offset = "0x103E160", VA = "0x103E160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x103E918", Offset = "0x103E918", VA = "0x103E918", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586B84", Offset = "0x586B84")]
	private sealed class <_StartWhenDone>d__275 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Timing <>4__this;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CoroutineHandle handle;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> proc;

		[Token(Token = "0x1700003A")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x103F0DC", Offset = "0x103F0DC", VA = "0x103F0DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x103F144", Offset = "0x103F144", VA = "0x103F144", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x103ED2C", Offset = "0x103ED2C", VA = "0x103ED2C")]
		[DebuggerHidden]
		public <_StartWhenDone>d__275(int <>1__state)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x103ED58", Offset = "0x103ED58", VA = "0x103ED58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x103EDB0", Offset = "0x103EDB0", VA = "0x103EDB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x103ED84", Offset = "0x103ED84", VA = "0x103ED84")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x103F0E4", Offset = "0x103F0E4", VA = "0x103F0E4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586B94", Offset = "0x586B94")]
	private sealed class <_StartWhenDone>d__280 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AsyncOperation operation;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> pausedProc;

		[Token(Token = "0x1700003C")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x103F2F8", Offset = "0x103F2F8", VA = "0x103F2F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x103F360", Offset = "0x103F360", VA = "0x103F360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x103F1A8", Offset = "0x103F1A8", VA = "0x103F1A8")]
		[DebuggerHidden]
		public <_StartWhenDone>d__280(int <>1__state)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x103F1D4", Offset = "0x103F1D4", VA = "0x103F1D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x103F1D8", Offset = "0x103F1D8", VA = "0x103F1D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x103F300", Offset = "0x103F300", VA = "0x103F300", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586BA4", Offset = "0x586BA4")]
	private sealed class <_StartWhenDone>d__282 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CustomYieldInstruction operation;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> pausedProc;

		[Token(Token = "0x1700003E")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x103F518", Offset = "0x103F518", VA = "0x103F518", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x103F580", Offset = "0x103F580", VA = "0x103F580", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x103F3C4", Offset = "0x103F3C4", VA = "0x103F3C4")]
		[DebuggerHidden]
		public <_StartWhenDone>d__282(int <>1__state)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x103F3F0", Offset = "0x103F3F0", VA = "0x103F3F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x103F3F4", Offset = "0x103F3F4", VA = "0x103F3F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x103F520", Offset = "0x103F520", VA = "0x103F520", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586BB4", Offset = "0x586BB4")]
	private sealed class <_StartWhenDone>d__287 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> evaluatorFunc;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool continueOn;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> pausedProc;

		[Token(Token = "0x17000040")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x103F74C", Offset = "0x103F74C", VA = "0x103F74C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x103F7B4", Offset = "0x103F7B4", VA = "0x103F7B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x103F5E4", Offset = "0x103F5E4", VA = "0x103F5E4")]
		[DebuggerHidden]
		public <_StartWhenDone>d__287(int <>1__state)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x103F610", Offset = "0x103F610", VA = "0x103F610", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x103F614", Offset = "0x103F614", VA = "0x103F614", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x103F754", Offset = "0x103F754", VA = "0x103F754", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586BC4", Offset = "0x586BC4")]
	private sealed class <_InjectDelay>d__288 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Timing <>4__this;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float waitTime;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> proc;

		[Token(Token = "0x17000042")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x103EC60", Offset = "0x103EC60", VA = "0x103EC60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000043")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x103ECC8", Offset = "0x103ECC8", VA = "0x103ECC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x103EB0C", Offset = "0x103EB0C", VA = "0x103EB0C")]
		[DebuggerHidden]
		public <_InjectDelay>d__288(int <>1__state)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x103EB38", Offset = "0x103EB38", VA = "0x103EB38", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x103EB3C", Offset = "0x103EB3C", VA = "0x103EB3C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x103EC68", Offset = "0x103EC68", VA = "0x103EC68", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586BD4", Offset = "0x586BD4")]
	private sealed class <_DelayedCall>d__313 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Timing <>4__this;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject cancelWith;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action action;

		[Token(Token = "0x17000044")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x103E064", Offset = "0x103E064", VA = "0x103E064", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000045")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x103E0CC", Offset = "0x103E0CC", VA = "0x103E0CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x103DF5C", Offset = "0x103DF5C", VA = "0x103DF5C")]
		[DebuggerHidden]
		public <_DelayedCall>d__313(int <>1__state)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x103DF88", Offset = "0x103DF88", VA = "0x103DF88", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x103DF8C", Offset = "0x103DF8C", VA = "0x103DF8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x103E06C", Offset = "0x103E06C", VA = "0x103E06C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586BE4", Offset = "0x586BE4")]
	private sealed class <_WatchCall>d__334 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Timing <>4__this;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float timeframe;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public CoroutineHandle handle;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onDone;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject gObject;

		[Token(Token = "0x17000046")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x103F938", Offset = "0x103F938", VA = "0x103F938", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000047")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x103F9A0", Offset = "0x103F9A0", VA = "0x103F9A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x103F818", Offset = "0x103F818", VA = "0x103F818")]
		[DebuggerHidden]
		public <_WatchCall>d__334(int <>1__state)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x103F844", Offset = "0x103F844", VA = "0x103F844", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x103F848", Offset = "0x103F848", VA = "0x103F848", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x103F940", Offset = "0x103F940", VA = "0x103F940", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586BF4", Offset = "0x586BF4")]
	private sealed class <_CallContinuously>d__335 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Timing <>4__this;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float period;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gObject;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action action;

		[Token(Token = "0x17000048")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x103DE90", Offset = "0x103DE90", VA = "0x103DE90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000049")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x103DEF8", Offset = "0x103DEF8", VA = "0x103DEF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x103DD20", Offset = "0x103DD20", VA = "0x103DD20")]
		[DebuggerHidden]
		public <_CallContinuously>d__335(int <>1__state)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x103DD4C", Offset = "0x103DD4C", VA = "0x103DD4C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x103DD50", Offset = "0x103DD50", VA = "0x103DD50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x103DE98", Offset = "0x103DE98", VA = "0x103DE98", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586C04", Offset = "0x586C04")]
	private sealed class <_WatchCall>d__352<T> : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Timing <>4__this;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float timeframe;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CoroutineHandle handle;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> onDone;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject gObject;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T reference;

		[Token(Token = "0x1700004A")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600020A")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600020C")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000207")]
		[DebuggerHidden]
		public <_WatchCall>d__352(int <>1__state)
		{
		}

		[Token(Token = "0x6000208")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000209")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600020B")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586C14", Offset = "0x586C14")]
	private sealed class <_CallContinuously>d__353<T> : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Timing <>4__this;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float period;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject gObject;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> action;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T reference;

		[Token(Token = "0x1700004C")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000210")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000212")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020D")]
		[DebuggerHidden]
		public <_CallContinuously>d__353(int <>1__state)
		{
		}

		[Token(Token = "0x600020E")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600020F")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000211")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x586C24", Offset = "0x586C24")]
	public float TimeBetweenSlowUpdateCalls;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x586C5C", Offset = "0x586C5C")]
	public DebugInfoType ProfilerDebugAmount;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x586C94", Offset = "0x586C94")]
	public bool AutoTriggerManualTimeframe;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x586CCC", Offset = "0x586CCC")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x586CCC", Offset = "0x586CCC")]
	public int UpdateCoroutines;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x586D1C", Offset = "0x586D1C")]
	public int FixedUpdateCoroutines;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x586D54", Offset = "0x586D54")]
	public int LateUpdateCoroutines;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x586D8C", Offset = "0x586D8C")]
	public int SlowUpdateCoroutines;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x586DC4", Offset = "0x586DC4")]
	public int RealtimeUpdateCoroutines;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x586DFC", Offset = "0x586DFC")]
	public int EditorUpdateCoroutines;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x586E34", Offset = "0x586E34")]
	public int EditorSlowUpdateCoroutines;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x586E6C", Offset = "0x586E6C")]
	public int EndOfFrameCoroutines;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x586EA4", Offset = "0x586EA4")]
	public int ManualTimeframeCoroutines;

	[NonSerialized]
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float localTime;

	[NonSerialized]
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float deltaTime;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Func<float, float> SetManualTimeframeTime;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Func<IEnumerator<float>, CoroutineHandle, IEnumerator<float>> ReplacementFunction;

	[Token(Token = "0x4000012")]
	public const float WaitForOneFrame = float.NegativeInfinity;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586EEC", Offset = "0x586EEC")]
	private static Thread <MainThread>k__BackingField;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586EFC", Offset = "0x586EFC")]
	private CoroutineHandle <currentCoroutine>k__BackingField;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static object _tmpRef;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static int _tmpInt;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static bool _tmpBool;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static Segment _tmpSegment;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static CoroutineHandle _tmpHandle;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int _currentUpdateFrame;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int _currentLateUpdateFrame;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int _currentSlowUpdateFrame;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int _currentRealtimeUpdateFrame;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int _currentEndOfFrameFrame;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int _nextUpdateProcessSlot;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int _nextLateUpdateProcessSlot;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int _nextFixedUpdateProcessSlot;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int _nextSlowUpdateProcessSlot;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int _nextRealtimeUpdateProcessSlot;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int _nextEditorUpdateProcessSlot;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int _nextEditorSlowUpdateProcessSlot;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int _nextEndOfFrameProcessSlot;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int _nextManualTimeframeProcessSlot;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int _lastUpdateProcessSlot;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int _lastLateUpdateProcessSlot;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int _lastFixedUpdateProcessSlot;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int _lastSlowUpdateProcessSlot;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private int _lastRealtimeUpdateProcessSlot;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int _lastEndOfFrameProcessSlot;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private int _lastManualTimeframeProcessSlot;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float _lastUpdateTime;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float _lastLateUpdateTime;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float _lastFixedUpdateTime;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private float _lastSlowUpdateTime;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float _lastRealtimeUpdateTime;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float _lastEndOfFrameTime;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float _lastManualTimeframeTime;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float _lastSlowUpdateDeltaTime;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float _lastEditorUpdateDeltaTime;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private float _lastEditorSlowUpdateDeltaTime;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float _lastManualTimeframeDeltaTime;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private ushort _framesSinceUpdate;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDE")]
	private ushort _expansions;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[HideInInspector]
	private byte _instanceID;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
	private bool _EOFPumpRan;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> Links;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly WaitForEndOfFrame EofWaitObject;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> _waitingTriggers;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly HashSet<CoroutineHandle> _allWaiting;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly Dictionary<CoroutineHandle, ProcessIndex> _handleToIndex;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly Dictionary<ProcessIndex, CoroutineHandle> _indexToHandle;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly Dictionary<CoroutineHandle, string> _processTags;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly Dictionary<string, HashSet<CoroutineHandle>> _taggedProcesses;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly Dictionary<CoroutineHandle, int> _processLayers;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly Dictionary<int, HashSet<CoroutineHandle>> _layeredProcesses;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private IEnumerator<float>[] UpdateProcesses;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private IEnumerator<float>[] LateUpdateProcesses;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private IEnumerator<float>[] FixedUpdateProcesses;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private IEnumerator<float>[] SlowUpdateProcesses;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private IEnumerator<float>[] RealtimeUpdateProcesses;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private IEnumerator<float>[] EditorUpdateProcesses;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private IEnumerator<float>[] EditorSlowUpdateProcesses;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private IEnumerator<float>[] EndOfFrameProcesses;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private IEnumerator<float>[] ManualTimeframeProcesses;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private bool[] UpdatePaused;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private bool[] LateUpdatePaused;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private bool[] FixedUpdatePaused;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private bool[] SlowUpdatePaused;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private bool[] RealtimeUpdatePaused;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private bool[] EditorUpdatePaused;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private bool[] EditorSlowUpdatePaused;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private bool[] EndOfFramePaused;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private bool[] ManualTimeframePaused;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private bool[] UpdateHeld;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private bool[] LateUpdateHeld;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private bool[] FixedUpdateHeld;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private bool[] SlowUpdateHeld;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private bool[] RealtimeUpdateHeld;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private bool[] EditorUpdateHeld;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private bool[] EditorSlowUpdateHeld;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private bool[] EndOfFrameHeld;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private bool[] ManualTimeframeHeld;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private CoroutineHandle _eofWatcherHandle;

	[Token(Token = "0x4000064")]
	private const ushort FramesUntilMaintenance = 64;

	[Token(Token = "0x4000065")]
	private const int ProcessArrayChunkSize = 64;

	[Token(Token = "0x4000066")]
	private const int InitialBufferSizeLarge = 256;

	[Token(Token = "0x4000067")]
	private const int InitialBufferSizeMedium = 64;

	[Token(Token = "0x4000068")]
	private const int InitialBufferSizeSmall = 8;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static Timing[] ActiveInstances;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static Timing _instance;

	[Token(Token = "0x17000001")]
	public static float LocalTime
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0xBF3B40", Offset = "0xBF3B40", VA = "0xBF3B40")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000002")]
	public static float DeltaTime
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0xBF3DE4", Offset = "0xBF3DE4", VA = "0xBF3DE4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000003")]
	public static Thread MainThread
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0xBF4030", Offset = "0xBF4030", VA = "0xBF4030")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x587884", Offset = "0x587884")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001B")]
		[Address(RVA = "0xBF4098", Offset = "0xBF4098", VA = "0xBF4098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x587894", Offset = "0x587894")]
		private set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public static CoroutineHandle CurrentCoroutine
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0xBF4104", Offset = "0xBF4104", VA = "0xBF4104")]
		get
		{
			return default(CoroutineHandle);
		}
	}

	[Token(Token = "0x17000005")]
	public CoroutineHandle currentCoroutine
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0xBF42A0", Offset = "0xBF42A0", VA = "0xBF42A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5878A4", Offset = "0x5878A4")]
		get
		{
			return default(CoroutineHandle);
		}
		[Token(Token = "0x600001E")]
		[Address(RVA = "0xBF42A8", Offset = "0xBF42A8", VA = "0xBF42A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5878B4", Offset = "0x5878B4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public static Timing Instance
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0xBF3BAC", Offset = "0xBF3BAC", VA = "0xBF3BAC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000020")]
		[Address(RVA = "0xBF4508", Offset = "0xBF4508", VA = "0xBF4508")]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public static event Action OnPreExecute
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0xBF3E50", Offset = "0xBF3E50", VA = "0xBF3E50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x587864", Offset = "0x587864")]
		add
		{
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0xBF3F40", Offset = "0xBF3F40", VA = "0xBF3F40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x587874", Offset = "0x587874")]
		remove
		{
		}
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xBF4574", Offset = "0xBF4574", VA = "0xBF4574")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xBF4644", Offset = "0xBF4644", VA = "0xBF4644")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xBF4A78", Offset = "0xBF4A78", VA = "0xBF4A78")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xBF42B0", Offset = "0xBF42B0", VA = "0xBF42B0")]
	private void InitializeInstanceID()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xBF4B4C", Offset = "0xBF4B4C", VA = "0xBF4B4C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xBF8378", Offset = "0xBF8378", VA = "0xBF8378")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xBF8AA4", Offset = "0xBF8AA4", VA = "0xBF8AA4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xBF644C", Offset = "0xBF644C", VA = "0xBF644C")]
	public void TriggerManualTimeframeUpdate()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xBF47AC", Offset = "0xBF47AC", VA = "0xBF47AC")]
	private bool OnEditorStart()
	{
		return default(bool);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xBF47B4", Offset = "0xBF47B4", VA = "0xBF47B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5878C4", Offset = "0x5878C4")]
	private IEnumerator<float> _EOFPumpWatcher()
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xBF91D0", Offset = "0xBF91D0", VA = "0xBF91D0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587928", Offset = "0x587928")]
	private IEnumerator _EOFPump()
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xBF6B9C", Offset = "0xBF6B9C", VA = "0xBF6B9C")]
	private void RemoveUnused()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xBF96D8", Offset = "0xBF96D8", VA = "0xBF96D8")]
	private void EditorRemoveUnused()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xBF06F0", Offset = "0xBF06F0", VA = "0xBF06F0")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xBF0830", Offset = "0xBF0830", VA = "0xBF0830")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xBF0A20", Offset = "0xBF0A20", VA = "0xBF0A20")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xBF0B6C", Offset = "0xBF0B6C", VA = "0xBF0B6C")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xBF0CC0", Offset = "0xBF0CC0", VA = "0xBF0CC0")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xBF0EC4", Offset = "0xBF0EC4", VA = "0xBF0EC4")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xBF1014", Offset = "0xBF1014", VA = "0xBF1014")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xBF1168", Offset = "0xBF1168", VA = "0xBF1168")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xBF136C", Offset = "0xBF136C", VA = "0xBF136C")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xBF14C4", Offset = "0xBF14C4", VA = "0xBF14C4")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xBF162C", Offset = "0xBF162C", VA = "0xBF162C")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xBF1844", Offset = "0xBF1844", VA = "0xBF1844")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xBFC86C", Offset = "0xBFC86C", VA = "0xBFC86C")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xBFC8D8", Offset = "0xBFC8D8", VA = "0xBFC8D8")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xBFCA00", Offset = "0xBFCA00", VA = "0xBFCA00")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xBFCA78", Offset = "0xBFCA78", VA = "0xBFCA78")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xBFCAF0", Offset = "0xBFCAF0", VA = "0xBFCAF0")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xBFCC1C", Offset = "0xBFCC1C", VA = "0xBFCC1C")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xBFCC98", Offset = "0xBFCC98", VA = "0xBFCC98")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xBFCD10", Offset = "0xBFCD10", VA = "0xBFCD10")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xBFCE3C", Offset = "0xBFCE3C", VA = "0xBFCE3C")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xBFCEB8", Offset = "0xBFCEB8", VA = "0xBFCEB8")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xBFCF34", Offset = "0xBFCF34", VA = "0xBFCF34")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xBFD06C", Offset = "0xBFD06C", VA = "0xBFD06C")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xBF19A8", Offset = "0xBF19A8", VA = "0xBF19A8")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xBFD410", Offset = "0xBFD410", VA = "0xBFD410")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xBF1C84", Offset = "0xBF1C84", VA = "0xBF1C84")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xBF2074", Offset = "0xBF2074", VA = "0xBF2074")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xBFE050", Offset = "0xBFE050", VA = "0xBFE050")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xBF2474", Offset = "0xBF2474", VA = "0xBF2474")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xBF2A84", Offset = "0xBF2A84", VA = "0xBF2A84")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xBFE358", Offset = "0xBFE358", VA = "0xBFE358")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xBF2D78", Offset = "0xBF2D78", VA = "0xBF2D78")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xBF3194", Offset = "0xBF3194", VA = "0xBF3194")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xBFE46C", Offset = "0xBFE46C", VA = "0xBFE46C")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xBF35AC", Offset = "0xBF35AC", VA = "0xBF35AC")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xBFE590", Offset = "0xBFE590", VA = "0xBFE590")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xBFE98C", Offset = "0xBFE98C", VA = "0xBFE98C")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xBFEA58", Offset = "0xBFEA58", VA = "0xBFEA58")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xBF4824", Offset = "0xBF4824", VA = "0xBF4824")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xBFF324", Offset = "0xBFF324", VA = "0xBFF324")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xBFF400", Offset = "0xBFF400", VA = "0xBFF400")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xBFFEA0", Offset = "0xBFFEA0", VA = "0xBFFEA0")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xBFFF78", Offset = "0xBFFF78", VA = "0xBFFF78")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xC001D8", Offset = "0xC001D8", VA = "0xC001D8")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xC00438", Offset = "0xC00438", VA = "0xC00438")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xC00528", Offset = "0xC00528", VA = "0xC00528")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xBF9E98", Offset = "0xBF9E98", VA = "0xBF9E98")]
	private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, int layer, bool layerHasValue, string tag, CoroutineHandle handle, bool prewarm)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xC00B1C", Offset = "0xC00B1C", VA = "0xC00B1C")]
	public static int KillCoroutines()
	{
		return default(int);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xC00BF8", Offset = "0xC00BF8", VA = "0xC00BF8")]
	public int KillCoroutinesOnInstance()
	{
		return default(int);
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xBF0080", Offset = "0xBF0080", VA = "0xBF0080")]
	public static int KillCoroutines(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xC0104C", Offset = "0xC0104C", VA = "0xC0104C")]
	public static int KillCoroutines(IEnumerable<CoroutineHandle> handles)
	{
		return default(int);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xBF625C", Offset = "0xBF625C", VA = "0xBF625C")]
	public int KillCoroutinesOnInstance(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xC01350", Offset = "0xC01350", VA = "0xC01350")]
	public static int KillCoroutines(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xC01454", Offset = "0xC01454", VA = "0xC01454")]
	public int KillCoroutinesOnInstance(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xBFD510", Offset = "0xBFD510", VA = "0xBFD510")]
	public static int KillCoroutines(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xBFECAC", Offset = "0xBFECAC", VA = "0xBFECAC")]
	public int KillCoroutinesOnInstance(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xBFDF60", Offset = "0xBFDF60", VA = "0xBFDF60")]
	public static int KillCoroutines(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xBFF0AC", Offset = "0xBFF0AC", VA = "0xBFF0AC")]
	public int KillCoroutinesOnInstance(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xC01598", Offset = "0xC01598", VA = "0xC01598")]
	public static int KillCoroutines(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xC016A4", Offset = "0xC016A4", VA = "0xC016A4")]
	public int KillCoroutinesOnInstance(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xBFE168", Offset = "0xBFE168", VA = "0xBFE168")]
	public static int KillCoroutines(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xBFF784", Offset = "0xBFF784", VA = "0xBFF784")]
	public int KillCoroutinesOnInstance(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xC00FA0", Offset = "0xC00FA0", VA = "0xC00FA0")]
	public static Timing GetInstance(byte ID)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xC016E4", Offset = "0xC016E4", VA = "0xC016E4")]
	public static float WaitForSeconds(float waitTime)
	{
		return default(float);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xC01770", Offset = "0xC01770", VA = "0xC01770")]
	public float WaitForSecondsOnInstance(float waitTime)
	{
		return default(float);
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xBF5F60", Offset = "0xBF5F60", VA = "0xBF5F60")]
	private bool UpdateTimeValues(Segment segment)
	{
		return default(bool);
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xC017B4", Offset = "0xC017B4", VA = "0xC017B4")]
	private float GetSegmentTime(Segment segment)
	{
		return default(float);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xC018A0", Offset = "0xC018A0", VA = "0xC018A0")]
	public static int PauseCoroutines()
	{
		return default(int);
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xC0197C", Offset = "0xC0197C", VA = "0xC0197C")]
	public int PauseCoroutinesOnInstance()
	{
		return default(int);
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xBF03CC", Offset = "0xBF03CC", VA = "0xBF03CC")]
	public static int PauseCoroutines(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xC02C1C", Offset = "0xC02C1C", VA = "0xC02C1C")]
	public int PauseCoroutinesOnInstance(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xC03BB4", Offset = "0xC03BB4", VA = "0xC03BB4")]
	public static int PauseCoroutines(IEnumerable<CoroutineHandle> handles)
	{
		return default(int);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xC03D90", Offset = "0xC03D90", VA = "0xC03D90")]
	public static int PauseCoroutines(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xC03E80", Offset = "0xC03E80", VA = "0xC03E80")]
	public int PauseCoroutinesOnInstance(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xC041FC", Offset = "0xC041FC", VA = "0xC041FC")]
	public static int PauseCoroutines(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xC03F30", Offset = "0xC03F30", VA = "0xC03F30")]
	public int PauseCoroutinesOnInstance(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xC042EC", Offset = "0xC042EC", VA = "0xC042EC")]
	public static int PauseCoroutines(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xC043DC", Offset = "0xC043DC", VA = "0xC043DC")]
	public int PauseCoroutinesOnInstance(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xC046AC", Offset = "0xC046AC", VA = "0xC046AC")]
	public static int PauseCoroutines(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xC04B58", Offset = "0xC04B58", VA = "0xC04B58")]
	public int PauseCoroutinesOnInstance(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xC04C10", Offset = "0xC04C10", VA = "0xC04C10")]
	public static int PauseCoroutines(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xC047B8", Offset = "0xC047B8", VA = "0xC047B8")]
	public int PauseCoroutinesOnInstance(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xC04D08", Offset = "0xC04D08", VA = "0xC04D08")]
	public static int ResumeCoroutines()
	{
		return default(int);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xC04DE4", Offset = "0xC04DE4", VA = "0xC04DE4")]
	public int ResumeCoroutinesOnInstance()
	{
		return default(int);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xBF04DC", Offset = "0xBF04DC", VA = "0xBF04DC")]
	public static int ResumeCoroutines(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xBFD600", Offset = "0xBFD600", VA = "0xBFD600")]
	public static int ResumeCoroutines(IEnumerable<CoroutineHandle> handles)
	{
		return default(int);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xBFE73C", Offset = "0xBFE73C", VA = "0xBFE73C")]
	public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xBFEF00", Offset = "0xBFEF00", VA = "0xBFEF00")]
	public int ResumeCoroutinesOnInstance(IEnumerable<CoroutineHandle> handles)
	{
		return default(int);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xC05318", Offset = "0xC05318", VA = "0xC05318")]
	public static int ResumeCoroutines(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xC056E4", Offset = "0xC056E4", VA = "0xC056E4")]
	public int ResumeCoroutinesOnInstance(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xC05794", Offset = "0xC05794", VA = "0xC05794")]
	public static int ResumeCoroutines(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xC0541C", Offset = "0xC0541C", VA = "0xC0541C")]
	public int ResumeCoroutinesOnInstance(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xC05884", Offset = "0xC05884", VA = "0xC05884")]
	public static int ResumeCoroutines(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xC05974", Offset = "0xC05974", VA = "0xC05974")]
	public int ResumeCoroutinesOnInstance(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xC05C40", Offset = "0xC05C40", VA = "0xC05C40")]
	public static int ResumeCoroutines(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xC05D4C", Offset = "0xC05D4C", VA = "0xC05D4C")]
	public int ResumeCoroutinesOnInstance(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xBFE260", Offset = "0xBFE260", VA = "0xBFE260")]
	public static int ResumeCoroutines(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xBFFB4C", Offset = "0xBFFB4C", VA = "0xBFFB4C")]
	public int ResumeCoroutinesOnInstance(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xBEF028", Offset = "0xBEF028", VA = "0xBEF028")]
	public static string GetTag(CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xBEF148", Offset = "0xBEF148", VA = "0xBEF148")]
	public static int? GetLayer(CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xBEF28C", Offset = "0xBEF28C", VA = "0xBEF28C")]
	public static string GetDebugName(CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xBEFA28", Offset = "0xBEFA28", VA = "0xBEFA28")]
	public static Segment GetSegment(CoroutineHandle handle)
	{
		return default(Segment);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xBEF4AC", Offset = "0xBEF4AC", VA = "0xBEF4AC")]
	public static bool SetTag(CoroutineHandle handle, string newTag, bool overwriteExisting = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xBEF864", Offset = "0xBEF864", VA = "0xBEF864")]
	public static bool SetLayer(CoroutineHandle handle, int newLayer, bool overwriteExisting = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xBEFB98", Offset = "0xBEFB98", VA = "0xBEFB98")]
	public static bool SetSegment(CoroutineHandle handle, Segment newSegment)
	{
		return default(bool);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xC0711C", Offset = "0xC0711C", VA = "0xC0711C")]
	public static bool RemoveTag(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xBEF74C", Offset = "0xBEF74C", VA = "0xBEF74C")]
	public static bool RemoveLayer(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xBEFEEC", Offset = "0xBEFEEC", VA = "0xBEFEEC")]
	public static bool IsRunning(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xBF01F8", Offset = "0xBF01F8", VA = "0xBF01F8")]
	public static bool IsAliveAndPaused(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xC008AC", Offset = "0xC008AC", VA = "0xC008AC")]
	private void AddTagOnInstance(string tag, CoroutineHandle handle)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xC009E4", Offset = "0xC009E4", VA = "0xC009E4")]
	private void AddLayerOnInstance(int layer, CoroutineHandle handle)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xC05ECC", Offset = "0xC05ECC", VA = "0xC05ECC")]
	private void RemoveTagOnInstance(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xC06020", Offset = "0xC06020", VA = "0xC06020")]
	private void RemoveLayerOnInstance(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xBF949C", Offset = "0xBF949C", VA = "0xBF949C")]
	private void RemoveGraffiti(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xC06174", Offset = "0xC06174", VA = "0xC06174")]
	private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xBF9240", Offset = "0xBF9240", VA = "0xBF9240")]
	private bool CoindexIsNull(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xC05E04", Offset = "0xC05E04", VA = "0xC05E04")]
	private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xC012DC", Offset = "0xC012DC", VA = "0xC012DC")]
	private bool Nullify(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xC0148C", Offset = "0xC0148C", VA = "0xC0148C")]
	private bool Nullify(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xC02E70", Offset = "0xC02E70", VA = "0xC02E70")]
	private bool SetPause(ProcessIndex coindex, bool newPausedState)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xC063D8", Offset = "0xC063D8", VA = "0xC063D8")]
	private bool SetHeld(ProcessIndex coindex, bool newHeldState)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xC07188", Offset = "0xC07188", VA = "0xC07188")]
	private IEnumerator<float> CreateHold(ProcessIndex coindex, IEnumerator<float> coptr)
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xC0630C", Offset = "0xC0630C", VA = "0xC0630C")]
	private bool CoindexIsPaused(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xC06240", Offset = "0xC06240", VA = "0xC06240")]
	private bool CoindexIsHeld(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xC07E50", Offset = "0xC07E50", VA = "0xC07E50")]
	private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xC07F4C", Offset = "0xC07F4C", VA = "0xC07F4C")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine)
	{
		return default(float);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xC082A8", Offset = "0xC082A8", VA = "0xC082A8")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xC08344", Offset = "0xC08344", VA = "0xC08344")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer)
	{
		return default(float);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xC083E0", Offset = "0xC083E0", VA = "0xC083E0")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xC0848C", Offset = "0xC0848C", VA = "0xC0848C")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment)
	{
		return default(float);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xC0850C", Offset = "0xC0850C", VA = "0xC0850C")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xC08594", Offset = "0xC08594", VA = "0xC08594")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer)
	{
		return default(float);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xC0861C", Offset = "0xC0861C", VA = "0xC0861C")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xC086B4", Offset = "0xC086B4", VA = "0xC086B4")]
	public static float WaitUntilDone(CoroutineHandle otherCoroutine)
	{
		return default(float);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xC07FE0", Offset = "0xC07FE0", VA = "0xC07FE0")]
	public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
	{
		return default(float);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xBFD0F4", Offset = "0xBFD0F4", VA = "0xBFD0F4")]
	public static void WaitForOtherHandles(CoroutineHandle handle, CoroutineHandle otherHandle, bool warnOnIssue = true)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xBFD7D4", Offset = "0xBFD7D4", VA = "0xBFD7D4")]
	public static void WaitForOtherHandles(CoroutineHandle handle, IEnumerable<CoroutineHandle> otherHandles, bool warnOnIssue = true)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xC087A4", Offset = "0xC087A4", VA = "0xC087A4")]
	private void SwapToLast(CoroutineHandle firstHandle, CoroutineHandle lastHandle)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xC0871C", Offset = "0xC0871C", VA = "0xC0871C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x58798C", Offset = "0x58798C")]
	private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xBF9310", Offset = "0xBF9310", VA = "0xBF9310")]
	private void CloseWaitingProcess(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xC08B1C", Offset = "0xC08B1C", VA = "0xC08B1C")]
	private bool HandleIsInWaitingList(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xC08BE8", Offset = "0xC08BE8", VA = "0xC08BE8")]
	private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xC08C5C", Offset = "0xC08C5C", VA = "0xC08C5C")]
	public static float WaitUntilDone(AsyncOperation operation)
	{
		return default(float);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xC08DD8", Offset = "0xC08DD8", VA = "0xC08DD8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5879F0", Offset = "0x5879F0")]
	private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xC08E54", Offset = "0xC08E54", VA = "0xC08E54")]
	public static float WaitUntilDone(CustomYieldInstruction operation)
	{
		return default(float);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xC08FD4", Offset = "0xC08FD4", VA = "0xC08FD4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587A54", Offset = "0x587A54")]
	private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xC09050", Offset = "0xC09050", VA = "0xC09050")]
	public static float WaitUntilTrue(Func<bool> evaluatorFunc)
	{
		return default(float);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xC09120", Offset = "0xC09120", VA = "0xC09120")]
	private static IEnumerator<float> WaitUntilTrueHelper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xC09244", Offset = "0xC09244", VA = "0xC09244")]
	public static float WaitUntilFalse(Func<bool> evaluatorFunc)
	{
		return default(float);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xC09314", Offset = "0xC09314", VA = "0xC09314")]
	private static IEnumerator<float> WaitUntilFalseHelper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xC091B8", Offset = "0xC091B8", VA = "0xC091B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587AB8", Offset = "0x587AB8")]
	private static IEnumerator<float> _StartWhenDone(Func<bool> evaluatorFunc, bool continueOn, IEnumerator<float> pausedProc)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xC02B8C", Offset = "0xC02B8C", VA = "0xC02B8C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587B1C", Offset = "0x587B1C")]
	private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float waitTime)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xC093AC", Offset = "0xC093AC", VA = "0xC093AC")]
	public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xC09564", Offset = "0xC09564", VA = "0xC09564")]
	public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xC09710", Offset = "0xC09710", VA = "0xC09710")]
	public static int LinkCoroutines(CoroutineHandle master, CoroutineHandle slave)
	{
		return default(int);
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xC09964", Offset = "0xC09964", VA = "0xC09964")]
	public static int UnlinkCoroutines(CoroutineHandle master, CoroutineHandle slave, bool twoWay = false)
	{
		return default(int);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xC09CB8", Offset = "0xC09CB8", VA = "0xC09CB8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x587B80", Offset = "0x587B80")]
	public static float GetMyHandle(Action<CoroutineHandle> reciever)
	{
		return default(float);
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xC09D6C", Offset = "0xC09D6C", VA = "0xC09D6C")]
	private static IEnumerator<float> GetHandleHelper(IEnumerator<float> input, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xC09E24", Offset = "0xC09E24", VA = "0xC09E24")]
	public static float SwitchCoroutine(Segment newSegment)
	{
		return default(float);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xC09ED8", Offset = "0xC09ED8", VA = "0xC09ED8")]
	private static IEnumerator<float> SwitchCoroutineRepS(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xC09F8C", Offset = "0xC09F8C", VA = "0xC09F8C")]
	public static float SwitchCoroutine(Segment newSegment, string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xC0A054", Offset = "0xC0A054", VA = "0xC0A054")]
	private static IEnumerator<float> SwitchCoroutineRepST(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xC0A1B0", Offset = "0xC0A1B0", VA = "0xC0A1B0")]
	public static float SwitchCoroutine(Segment newSegment, int newLayer)
	{
		return default(float);
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xC0A278", Offset = "0xC0A278", VA = "0xC0A278")]
	private static IEnumerator<float> SwitchCoroutineRepSL(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xC0A358", Offset = "0xC0A358", VA = "0xC0A358")]
	public static float SwitchCoroutine(Segment newSegment, int newLayer, string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xC0A42C", Offset = "0xC0A42C", VA = "0xC0A42C")]
	private static IEnumerator<float> SwitchCoroutineRepSLT(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xC0A5A8", Offset = "0xC0A5A8", VA = "0xC0A5A8")]
	public static float SwitchCoroutine(string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xC0A65C", Offset = "0xC0A65C", VA = "0xC0A65C")]
	private static IEnumerator<float> SwitchCoroutineRepT(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xC0A76C", Offset = "0xC0A76C", VA = "0xC0A76C")]
	public static float SwitchCoroutine(int newLayer)
	{
		return default(float);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xC0A820", Offset = "0xC0A820", VA = "0xC0A820")]
	private static IEnumerator<float> SwitchCoroutineRepL(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xC0A8C0", Offset = "0xC0A8C0", VA = "0xC0A8C0")]
	public static float SwitchCoroutine(int newLayer, string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xC0A988", Offset = "0xC0A988", VA = "0xC0A988")]
	private static IEnumerator<float> SwitchCoroutineRepLT(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xC0AABC", Offset = "0xC0AABC", VA = "0xC0AABC")]
	public static CoroutineHandle CallDelayed(float delay, Action action)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xC0ABEC", Offset = "0xC0ABEC", VA = "0xC0ABEC")]
	public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xC0AC2C", Offset = "0xC0AC2C", VA = "0xC0AC2C")]
	public static CoroutineHandle CallDelayed(float delay, Action action, GameObject gameObject)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xC0ACD8", Offset = "0xC0ACD8", VA = "0xC0ACD8")]
	public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject gameObject)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xC0AB58", Offset = "0xC0AB58", VA = "0xC0AB58")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587BBC", Offset = "0x587BBC")]
	private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xC0AD1C", Offset = "0xC0AD1C", VA = "0xC0AD1C")]
	public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xC0ADC8", Offset = "0xC0ADC8", VA = "0xC0ADC8")]
	public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xC0AE14", Offset = "0xC0AE14", VA = "0xC0AE14")]
	public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action, GameObject gameObject)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xC0AEC8", Offset = "0xC0AEC8", VA = "0xC0AEC8")]
	public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action, GameObject gameObject)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xC0AF24", Offset = "0xC0AF24", VA = "0xC0AF24")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xC0B154", Offset = "0xC0B154", VA = "0xC0B154")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xC0B1EC", Offset = "0xC0B1EC", VA = "0xC0B1EC")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xC0B2FC", Offset = "0xC0B2FC", VA = "0xC0B2FC")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xC0B404", Offset = "0xC0B404", VA = "0xC0B404")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xC0B508", Offset = "0xC0B508", VA = "0xC0B508")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xC0B610", Offset = "0xC0B610", VA = "0xC0B610")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xC0B734", Offset = "0xC0B734", VA = "0xC0B734")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xC0B848", Offset = "0xC0B848", VA = "0xC0B848")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xC0B948", Offset = "0xC0B948", VA = "0xC0B948")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xC0BA38", Offset = "0xC0BA38", VA = "0xC0BA38")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xC0BB44", Offset = "0xC0BB44", VA = "0xC0BB44")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xC0BC48", Offset = "0xC0BC48", VA = "0xC0BC48")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xC0BD54", Offset = "0xC0BD54", VA = "0xC0BD54")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xC0BE58", Offset = "0xC0BE58", VA = "0xC0BE58")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xC0BF78", Offset = "0xC0BF78", VA = "0xC0BF78")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xC0B0B0", Offset = "0xC0B0B0", VA = "0xC0B0B0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587C20", Offset = "0x587C20")]
	private IEnumerator<float> _WatchCall(float timeframe, CoroutineHandle handle, GameObject gObject, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xC0B01C", Offset = "0xC0B01C", VA = "0xC0B01C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587C84", Offset = "0x587C84")]
	private IEnumerator<float> _CallContinuously(float period, Action action, GameObject gObject)
	{
		return null;
	}

	[Token(Token = "0x60000F6")]
	public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F7")]
	public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F8")]
	public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F9")]
	public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000FA")]
	public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000FB")]
	public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000FC")]
	public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000FD")]
	public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000FE")]
	public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000FF")]
	public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000100")]
	public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000101")]
	public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000102")]
	public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000103")]
	public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000104")]
	public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000105")]
	public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000106")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587CE8", Offset = "0x587CE8")]
	private IEnumerator<float> _WatchCall<T>(T reference, float timeframe, CoroutineHandle handle, GameObject gObject, Action<T> onDone)
	{
		return null;
	}

	[Token(Token = "0x6000107")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x587D4C", Offset = "0x587D4C")]
	private IEnumerator<float> _CallContinuously<T>(T reference, float period, Action<T> action, GameObject gObject)
	{
		return null;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xC0C088", Offset = "0xC0C088", VA = "0xC0C088")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x587DB0", Offset = "0x587DB0")]
	public new Coroutine StartCoroutine(IEnumerator routine)
	{
		return null;
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xC0C090", Offset = "0xC0C090", VA = "0xC0C090")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x587DEC", Offset = "0x587DEC")]
	public new Coroutine StartCoroutine(string methodName, object value)
	{
		return null;
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xC0C098", Offset = "0xC0C098", VA = "0xC0C098")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x587E28", Offset = "0x587E28")]
	public new Coroutine StartCoroutine(string methodName)
	{
		return null;
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xC0C0A0", Offset = "0xC0C0A0", VA = "0xC0C0A0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x587E64", Offset = "0x587E64")]
	public new Coroutine StartCoroutine_Auto(IEnumerator routine)
	{
		return null;
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xC0C0A8", Offset = "0xC0C0A8", VA = "0xC0C0A8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x587EA0", Offset = "0x587EA0")]
	public new void StopCoroutine(string methodName)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xC0C0AC", Offset = "0xC0C0AC", VA = "0xC0C0AC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x587EDC", Offset = "0x587EDC")]
	public new void StopCoroutine(IEnumerator routine)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xC0C0B0", Offset = "0xC0C0B0", VA = "0xC0C0B0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x587F18", Offset = "0x587F18")]
	public new void StopCoroutine(Coroutine routine)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xC0C0B4", Offset = "0xC0C0B4", VA = "0xC0C0B4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x587F54", Offset = "0x587F54")]
	public new void StopAllCoroutines()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xC0C0B8", Offset = "0xC0C0B8", VA = "0xC0C0B8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x587F90", Offset = "0x587F90")]
	public new static void Destroy(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xC0C0BC", Offset = "0xC0C0BC", VA = "0xC0C0BC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x587FCC", Offset = "0x587FCC")]
	public new static void Destroy(UnityEngine.Object obj, float f)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xC0C0C0", Offset = "0xC0C0C0", VA = "0xC0C0C0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x588008", Offset = "0x588008")]
	public static void DestroyObject(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xC0C0C4", Offset = "0xC0C0C4", VA = "0xC0C0C4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x588044", Offset = "0x588044")]
	public static void DestroyObject(UnityEngine.Object obj, float f)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xC0C0C8", Offset = "0xC0C0C8", VA = "0xC0C0C8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x588080", Offset = "0x588080")]
	public new static void DestroyImmediate(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xC0C0CC", Offset = "0xC0C0CC", VA = "0xC0C0CC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5880BC", Offset = "0x5880BC")]
	public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xC0C0D0", Offset = "0xC0C0D0", VA = "0xC0C0D0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5880F8", Offset = "0x5880F8")]
	public new static void Instantiate(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xC0C0D4", Offset = "0xC0C0D4", VA = "0xC0C0D4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x588134", Offset = "0x588134")]
	public new static void Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation)
	{
	}

	[Token(Token = "0x6000118")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x588170", Offset = "0x588170")]
	public new static void Instantiate<T>(T original) where T : UnityEngine.Object
	{
	}

	[Token(Token = "0x6000119")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5881AC", Offset = "0x5881AC")]
	public new static T FindObjectOfType<T>() where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xC0C0D8", Offset = "0xC0C0D8", VA = "0xC0C0D8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5881E8", Offset = "0x5881E8")]
	public new static UnityEngine.Object FindObjectOfType(Type t)
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x588224", Offset = "0x588224")]
	public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xC0C0E0", Offset = "0xC0C0E0", VA = "0xC0C0E0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x588260", Offset = "0x588260")]
	public new static UnityEngine.Object[] FindObjectsOfType(Type t)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xC0C0E8", Offset = "0xC0C0E8", VA = "0xC0C0E8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x58829C", Offset = "0x58829C")]
	public new static void print(object message)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xC0C0EC", Offset = "0xC0C0EC", VA = "0xC0C0EC")]
	public Timing()
	{
	}
}
[Token(Token = "0x2000004")]
public enum Segment
{
	[Token(Token = "0x400006C")]
	Invalid = -1,
	[Token(Token = "0x400006D")]
	Update,
	[Token(Token = "0x400006E")]
	FixedUpdate,
	[Token(Token = "0x400006F")]
	LateUpdate,
	[Token(Token = "0x4000070")]
	SlowUpdate,
	[Token(Token = "0x4000071")]
	RealtimeUpdate,
	[Token(Token = "0x4000072")]
	EditorUpdate,
	[Token(Token = "0x4000073")]
	EditorSlowUpdate,
	[Token(Token = "0x4000074")]
	EndOfFrame,
	[Token(Token = "0x4000075")]
	ManualTimeframe
}
[Token(Token = "0x2000005")]
public enum DebugInfoType
{
	[Token(Token = "0x4000077")]
	None,
	[Token(Token = "0x4000078")]
	SeperateCoroutines,
	[Token(Token = "0x4000079")]
	SeperateTags
}
[Token(Token = "0x2000006")]
public enum SingletonBehavior
{
	[Token(Token = "0x400007B")]
	Abort,
	[Token(Token = "0x400007C")]
	Overwrite,
	[Token(Token = "0x400007D")]
	Wait,
	[Token(Token = "0x400007E")]
	AbortAndUnpause
}
[Token(Token = "0x2000007")]
public struct CoroutineHandle : IEquatable<CoroutineHandle>
{
	[Token(Token = "0x400007F")]
	private const byte ReservedSpace = 15;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int[] NextIndex;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly int _id;

	[Token(Token = "0x17000007")]
	public byte Key
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0xBEEB2C", Offset = "0xBEEB2C", VA = "0xBEEB2C")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x17000008")]
	public string Tag
	{
		[Token(Token = "0x6000129")]
		[Address(RVA = "0xBEF3C8", Offset = "0xBEF3C8", VA = "0xBEF3C8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600012A")]
		[Address(RVA = "0xBEF430", Offset = "0xBEF430", VA = "0xBEF430")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public int? Layer
	{
		[Token(Token = "0x600012B")]
		[Address(RVA = "0xBEF608", Offset = "0xBEF608", VA = "0xBEF608")]
		get
		{
			return null;
		}
		[Token(Token = "0x600012C")]
		[Address(RVA = "0xBEF670", Offset = "0xBEF670", VA = "0xBEF670")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public Segment Segment
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0xBEF9C0", Offset = "0xBEF9C0", VA = "0xBEF9C0")]
		get
		{
			return default(Segment);
		}
		[Token(Token = "0x600012E")]
		[Address(RVA = "0xBEFB20", Offset = "0xBEFB20", VA = "0xBEFB20")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public bool IsRunning
	{
		[Token(Token = "0x600012F")]
		[Address(RVA = "0xBEFE84", Offset = "0xBEFE84", VA = "0xBEFE84")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000130")]
		[Address(RVA = "0xBEFFF8", Offset = "0xBEFFF8", VA = "0xBEFFF8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public bool IsAliveAndPaused
	{
		[Token(Token = "0x6000131")]
		[Address(RVA = "0xBF0190", Offset = "0xBF0190", VA = "0xBF0190")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000132")]
		[Address(RVA = "0xBF0330", Offset = "0xBF0330", VA = "0xBF0330")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public bool IsValid
	{
		[Token(Token = "0x6000133")]
		[Address(RVA = "0xBF05EC", Offset = "0xBF05EC", VA = "0xBF05EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xBEEB38", Offset = "0xBEEB38", VA = "0xBEEB38")]
	public CoroutineHandle(byte ind)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xBEEC24", Offset = "0xBEEC24", VA = "0xBEEC24")]
	public CoroutineHandle(CoroutineHandle other)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xBEEC2C", Offset = "0xBEEC2C", VA = "0xBEEC2C", Slot = "4")]
	public bool Equals(CoroutineHandle other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xBEEC3C", Offset = "0xBEEC3C", VA = "0xBEEC3C", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xBEECC4", Offset = "0xBEECC4", VA = "0xBEECC4")]
	public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xBEECD0", Offset = "0xBEECD0", VA = "0xBEECD0")]
	public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xBEECDC", Offset = "0xBEECDC", VA = "0xBEECDC", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xBEECE4", Offset = "0xBEECE4", VA = "0xBEECE4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000008")]
public static class MECExtensionMethods1
{
	[Token(Token = "0x6000135")]
	[Address(RVA = "0xBF0684", Offset = "0xBF0684", VA = "0xBF0684")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xBF07B4", Offset = "0xBF07B4", VA = "0xBF07B4")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xBF09A4", Offset = "0xBF09A4", VA = "0xBF09A4")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xBF0AF0", Offset = "0xBF0AF0", VA = "0xBF0AF0")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xBF0C3C", Offset = "0xBF0C3C", VA = "0xBF0C3C")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xBF0E40", Offset = "0xBF0E40", VA = "0xBF0E40")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xBF0F98", Offset = "0xBF0F98", VA = "0xBF0F98")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xBF10E4", Offset = "0xBF10E4", VA = "0xBF10E4")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xBF12E8", Offset = "0xBF12E8", VA = "0xBF12E8")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xBF1440", Offset = "0xBF1440", VA = "0xBF1440")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xBF1598", Offset = "0xBF1598", VA = "0xBF1598")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xBF17B0", Offset = "0xBF17B0", VA = "0xBF17B0")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xBF1924", Offset = "0xBF1924", VA = "0xBF1924")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xBF1B84", Offset = "0xBF1B84", VA = "0xBF1B84")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xBF1F6C", Offset = "0xBF1F6C", VA = "0xBF1F6C")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xBF1FF0", Offset = "0xBF1FF0", VA = "0xBF1FF0")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xBF235C", Offset = "0xBF235C", VA = "0xBF235C")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xBF295C", Offset = "0xBF295C", VA = "0xBF295C")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xBF29F0", Offset = "0xBF29F0", VA = "0xBF29F0")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xBF2C64", Offset = "0xBF2C64", VA = "0xBF2C64")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xBF306C", Offset = "0xBF306C", VA = "0xBF306C")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xBF3100", Offset = "0xBF3100", VA = "0xBF3100")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xBF3488", Offset = "0xBF3488", VA = "0xBF3488")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xBF3AA4", Offset = "0xBF3AA4", VA = "0xBF3AA4")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}
}
