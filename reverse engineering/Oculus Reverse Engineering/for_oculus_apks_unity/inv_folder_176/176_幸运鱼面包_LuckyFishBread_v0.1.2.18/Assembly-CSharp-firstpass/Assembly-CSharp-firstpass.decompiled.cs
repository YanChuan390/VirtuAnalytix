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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6688E4", Offset = "0x6688E4")]
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
			[Address(RVA = "0x129B578", Offset = "0x129B578", VA = "0x129B578", Slot = "4")]
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
			[Address(RVA = "0x129B5E0", Offset = "0x129B5E0", VA = "0x129B5E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1299A10", Offset = "0x1299A10", VA = "0x1299A10")]
		[DebuggerHidden]
		public <Delay>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x129B3C8", Offset = "0x129B3C8", VA = "0x129B3C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x129B3CC", Offset = "0x129B3CC", VA = "0x129B3CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x129B580", Offset = "0x129B580", VA = "0x129B580", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6688F4", Offset = "0x6688F4")]
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
			[Address(RVA = "0x129B7D0", Offset = "0x129B7D0", VA = "0x129B7D0", Slot = "4")]
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
			[Address(RVA = "0x129B838", Offset = "0x129B838", VA = "0x129B838", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1299AB8", Offset = "0x1299AB8", VA = "0x1299AB8")]
		[DebuggerHidden]
		public <Delay>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x129B644", Offset = "0x129B644", VA = "0x129B644", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x129B648", Offset = "0x129B648", VA = "0x129B648", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x129B7D8", Offset = "0x129B7D8", VA = "0x129B7D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668904", Offset = "0x668904")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668914", Offset = "0x668914")]
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
			[Address(RVA = "0x129BA1C", Offset = "0x129BA1C", VA = "0x129BA1C", Slot = "4")]
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
			[Address(RVA = "0x129BA84", Offset = "0x129BA84", VA = "0x129BA84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1299B64", Offset = "0x1299B64", VA = "0x1299B64")]
		[DebuggerHidden]
		public <DelayFrames>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x129B89C", Offset = "0x129B89C", VA = "0x129B89C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x129B8A0", Offset = "0x129B8A0", VA = "0x129B8A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x129BA24", Offset = "0x129BA24", VA = "0x129BA24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668924", Offset = "0x668924")]
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
			[Address(RVA = "0x129ACF0", Offset = "0x129ACF0", VA = "0x129ACF0", Slot = "4")]
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
			[Address(RVA = "0x129AD58", Offset = "0x129AD58", VA = "0x129AD58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1299C0C", Offset = "0x1299C0C", VA = "0x1299C0C")]
		[DebuggerHidden]
		public <CancelWith>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x129AACC", Offset = "0x129AACC", VA = "0x129AACC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x129AAD0", Offset = "0x129AAD0", VA = "0x129AAD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x129ACF8", Offset = "0x129ACF8", VA = "0x129ACF8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668934", Offset = "0x668934")]
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
			[Address(RVA = "0x129B020", Offset = "0x129B020", VA = "0x129B020", Slot = "4")]
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
			[Address(RVA = "0x129B088", Offset = "0x129B088", VA = "0x129B088", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1299CBC", Offset = "0x1299CBC", VA = "0x1299CBC")]
		[DebuggerHidden]
		public <CancelWith>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x129ADBC", Offset = "0x129ADBC", VA = "0x129ADBC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x129ADC0", Offset = "0x129ADC0", VA = "0x129ADC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x129B028", Offset = "0x129B028", VA = "0x129B028", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668944", Offset = "0x668944")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668954", Offset = "0x668954")]
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
			[Address(RVA = "0x129B2FC", Offset = "0x129B2FC", VA = "0x129B2FC", Slot = "4")]
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
			[Address(RVA = "0x129B364", Offset = "0x129B364", VA = "0x129B364", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1299D64", Offset = "0x1299D64", VA = "0x1299D64")]
		[DebuggerHidden]
		public <CancelWith>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x129B0EC", Offset = "0x129B0EC", VA = "0x129B0EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x129B0F0", Offset = "0x129B0F0", VA = "0x129B0F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x129B304", Offset = "0x129B304", VA = "0x129B304", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668964", Offset = "0x668964")]
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
			[Address(RVA = "0x129C480", Offset = "0x129C480", VA = "0x129C480", Slot = "4")]
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
			[Address(RVA = "0x129C4E8", Offset = "0x129C4E8", VA = "0x129C4E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1299E0C", Offset = "0x1299E0C", VA = "0x1299E0C")]
		[DebuggerHidden]
		public <PauseWith>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x129C250", Offset = "0x129C250", VA = "0x129C250", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x129C254", Offset = "0x129C254", VA = "0x129C254", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x129C488", Offset = "0x129C488", VA = "0x129C488", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668974", Offset = "0x668974")]
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
			[Address(RVA = "0x129C7BC", Offset = "0x129C7BC", VA = "0x129C7BC", Slot = "4")]
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
			[Address(RVA = "0x129C824", Offset = "0x129C824", VA = "0x129C824", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1299EBC", Offset = "0x1299EBC", VA = "0x1299EBC")]
		[DebuggerHidden]
		public <PauseWith>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x129C54C", Offset = "0x129C54C", VA = "0x129C54C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x129C550", Offset = "0x129C550", VA = "0x129C550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x129C7C4", Offset = "0x129C7C4", VA = "0x129C7C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668984", Offset = "0x668984")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668994", Offset = "0x668994")]
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
			[Address(RVA = "0x129C184", Offset = "0x129C184", VA = "0x129C184", Slot = "4")]
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
			[Address(RVA = "0x129C1EC", Offset = "0x129C1EC", VA = "0x129C1EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1299F64", Offset = "0x1299F64", VA = "0x1299F64")]
		[DebuggerHidden]
		public <PauseWith>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x129BF74", Offset = "0x129BF74", VA = "0x129BF74", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x129BF78", Offset = "0x129BF78", VA = "0x129BF78", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x129C18C", Offset = "0x129C18C", VA = "0x129C18C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6689A4", Offset = "0x6689A4")]
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
			[Address(RVA = "0x129BEA8", Offset = "0x129BEA8", VA = "0x129BEA8", Slot = "4")]
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
			[Address(RVA = "0x129BF10", Offset = "0x129BF10", VA = "0x129BF10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x129A010", Offset = "0x129A010", VA = "0x129A010")]
		[DebuggerHidden]
		public <KillWith>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x129BD44", Offset = "0x129BD44", VA = "0x129BD44", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x129BD48", Offset = "0x129BD48", VA = "0x129BD48", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x129BEB0", Offset = "0x129BEB0", VA = "0x129BEB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6689B4", Offset = "0x6689B4")]
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
			[Address(RVA = "0x129A7D0", Offset = "0x129A7D0", VA = "0x129A7D0", Slot = "4")]
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
			[Address(RVA = "0x129A838", Offset = "0x129A838", VA = "0x129A838", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x129A0B8", Offset = "0x129A0B8", VA = "0x129A0B8")]
		[DebuggerHidden]
		public <Append>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x129A55C", Offset = "0x129A55C", VA = "0x129A55C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x129A560", Offset = "0x129A560", VA = "0x129A560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x129A7D8", Offset = "0x129A7D8", VA = "0x129A7D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6689C4", Offset = "0x6689C4")]
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
			[Address(RVA = "0x129AA00", Offset = "0x129AA00", VA = "0x129AA00", Slot = "4")]
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
			[Address(RVA = "0x129AA68", Offset = "0x129AA68", VA = "0x129AA68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x129A160", Offset = "0x129A160", VA = "0x129A160")]
		[DebuggerHidden]
		public <Append>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x129A89C", Offset = "0x129A89C", VA = "0x129A89C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x129A8A0", Offset = "0x129A8A0", VA = "0x129A8A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x129AA08", Offset = "0x129AA08", VA = "0x129AA08", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6689D4", Offset = "0x6689D4")]
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
			[Address(RVA = "0x129CB10", Offset = "0x129CB10", VA = "0x129CB10", Slot = "4")]
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
			[Address(RVA = "0x129CB78", Offset = "0x129CB78", VA = "0x129CB78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x129A208", Offset = "0x129A208", VA = "0x129A208")]
		[DebuggerHidden]
		public <Prepend>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x129C888", Offset = "0x129C888", VA = "0x129C888", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x129C88C", Offset = "0x129C88C", VA = "0x129C88C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x129CB18", Offset = "0x129CB18", VA = "0x129CB18", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6689E4", Offset = "0x6689E4")]
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
			[Address(RVA = "0x129CD50", Offset = "0x129CD50", VA = "0x129CD50", Slot = "4")]
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
			[Address(RVA = "0x129CDB8", Offset = "0x129CDB8", VA = "0x129CDB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x129A2B0", Offset = "0x129A2B0", VA = "0x129A2B0")]
		[DebuggerHidden]
		public <Prepend>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x129CBDC", Offset = "0x129CBDC", VA = "0x129CBDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x129CBE0", Offset = "0x129CBE0", VA = "0x129CBE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x129CD58", Offset = "0x129CD58", VA = "0x129CD58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6689F4", Offset = "0x6689F4")]
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
			[Address(RVA = "0x129D6E8", Offset = "0x129D6E8", VA = "0x129D6E8", Slot = "4")]
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
			[Address(RVA = "0x129D750", Offset = "0x129D750", VA = "0x129D750", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x129A3E0", Offset = "0x129A3E0", VA = "0x129A3E0")]
		[DebuggerHidden]
		public <Superimpose>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x129D0D4", Offset = "0x129D0D4", VA = "0x129D0D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x129D0D8", Offset = "0x129D0D8", VA = "0x129D0D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x129D6F0", Offset = "0x129D6F0", VA = "0x129D6F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668A04", Offset = "0x668A04")]
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
			[Address(RVA = "0x129BC78", Offset = "0x129BC78", VA = "0x129BC78", Slot = "4")]
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
			[Address(RVA = "0x129BCE0", Offset = "0x129BCE0", VA = "0x129BCE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x129A488", Offset = "0x129A488", VA = "0x129A488")]
		[DebuggerHidden]
		public <Hijack>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x129BAE8", Offset = "0x129BAE8", VA = "0x129BAE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x129BAEC", Offset = "0x129BAEC", VA = "0x129BAEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x129BC80", Offset = "0x129BC80", VA = "0x129BC80", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668A14", Offset = "0x668A14")]
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
			[Address(RVA = "0x129D008", Offset = "0x129D008", VA = "0x129D008", Slot = "4")]
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
			[Address(RVA = "0x129D070", Offset = "0x129D070", VA = "0x129D070", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x129A530", Offset = "0x129A530", VA = "0x129A530")]
		[DebuggerHidden]
		public <RerouteExceptions>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x129CE1C", Offset = "0x129CE1C", VA = "0x129CE1C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x129CE20", Offset = "0x129CE20", VA = "0x129CE20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x129D010", Offset = "0x129D010", VA = "0x129D010", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1299990", Offset = "0x1299990", VA = "0x1299990")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x668E04", Offset = "0x668E04")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, float timeToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1299A3C", Offset = "0x1299A3C", VA = "0x1299A3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x668E78", Offset = "0x668E78")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x668EEC", Offset = "0x668EEC")]
	public static IEnumerator<float> Delay<T>(this IEnumerator<float> coroutine, T data, Func<T, bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1299AE4", Offset = "0x1299AE4", VA = "0x1299AE4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x668F60", Offset = "0x668F60")]
	public static IEnumerator<float> DelayFrames(this IEnumerator<float> coroutine, int framesToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1299B90", Offset = "0x1299B90", VA = "0x1299B90")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x668FD4", Offset = "0x668FD4")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1299C38", Offset = "0x1299C38", VA = "0x1299C38")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x669048", Offset = "0x669048")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6690BC", Offset = "0x6690BC")]
	public static IEnumerator<float> CancelWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1299CE8", Offset = "0x1299CE8", VA = "0x1299CE8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x669130", Offset = "0x669130")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1299D90", Offset = "0x1299D90", VA = "0x1299D90")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6691A4", Offset = "0x6691A4")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1299E38", Offset = "0x1299E38", VA = "0x1299E38")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x669218", Offset = "0x669218")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x66928C", Offset = "0x66928C")]
	public static IEnumerator<float> PauseWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1299EE8", Offset = "0x1299EE8", VA = "0x1299EE8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x669300", Offset = "0x669300")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1299F90", Offset = "0x1299F90", VA = "0x1299F90")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x669374", Offset = "0x669374")]
	public static IEnumerator<float> KillWith(this IEnumerator<float> coroutine, CoroutineHandle otherCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x129A03C", Offset = "0x129A03C", VA = "0x129A03C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6693E8", Offset = "0x6693E8")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, IEnumerator<float> nextCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x129A0E4", Offset = "0x129A0E4", VA = "0x129A0E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x66945C", Offset = "0x66945C")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x129A18C", Offset = "0x129A18C", VA = "0x129A18C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6694D0", Offset = "0x6694D0")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, IEnumerator<float> lastCoroutine)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x129A234", Offset = "0x129A234", VA = "0x129A234")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x669544", Offset = "0x669544")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, Action onStart)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x129A2DC", Offset = "0x129A2DC", VA = "0x129A2DC")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x129A35C", Offset = "0x129A35C", VA = "0x129A35C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6695C8", Offset = "0x6695C8")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB, Timing instance)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x129A40C", Offset = "0x129A40C", VA = "0x129A40C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x66963C", Offset = "0x66963C")]
	public static IEnumerator<float> Hijack(this IEnumerator<float> coroutine, Func<float, float> newReturn)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x129A4B4", Offset = "0x129A4B4", VA = "0x129A4B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6696B0", Offset = "0x6696B0")]
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
		[Address(RVA = "0x6AA5E4", Offset = "0x6AA5E4", VA = "0x6AA5E4", Slot = "4")]
		public bool Equals(ProcessIndex other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x6AA60C", Offset = "0x6AA60C", VA = "0x6AA60C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1299930", Offset = "0x1299930", VA = "0x1299930")]
		public static bool operator ==(ProcessIndex a, ProcessIndex b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1299950", Offset = "0x1299950", VA = "0x1299950")]
		public static bool operator !=(ProcessIndex a, ProcessIndex b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x6AA614", Offset = "0x6AA614", VA = "0x6AA614", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668A24", Offset = "0x668A24")]
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
			[Address(RVA = "0x12988AC", Offset = "0x12988AC", VA = "0x12988AC", Slot = "4")]
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
			[Address(RVA = "0x1298914", Offset = "0x1298914", VA = "0x1298914", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x12987EC", Offset = "0x12987EC", VA = "0x12987EC")]
		[DebuggerHidden]
		public <_EOFPumpWatcher>d__132(int <>1__state)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1298818", Offset = "0x1298818", VA = "0x1298818", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x129881C", Offset = "0x129881C", VA = "0x129881C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x12988B4", Offset = "0x12988B4", VA = "0x12988B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668A34", Offset = "0x668A34")]
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
			[Address(RVA = "0x129877C", Offset = "0x129877C", VA = "0x129877C", Slot = "4")]
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
			[Address(RVA = "0x12987E4", Offset = "0x12987E4", VA = "0x12987E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1297F9C", Offset = "0x1297F9C", VA = "0x1297F9C")]
		[DebuggerHidden]
		public <_EOFPump>d__133(int <>1__state)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1297FC8", Offset = "0x1297FC8", VA = "0x1297FC8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1297FCC", Offset = "0x1297FCC", VA = "0x1297FCC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1298784", Offset = "0x1298784", VA = "0x1298784", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668A44", Offset = "0x668A44")]
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
			[Address(RVA = "0x1298F48", Offset = "0x1298F48", VA = "0x1298F48", Slot = "4")]
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
			[Address(RVA = "0x1298FB0", Offset = "0x1298FB0", VA = "0x1298FB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1298B98", Offset = "0x1298B98", VA = "0x1298B98")]
		[DebuggerHidden]
		public <_StartWhenDone>d__275(int <>1__state)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1298BC4", Offset = "0x1298BC4", VA = "0x1298BC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1298C1C", Offset = "0x1298C1C", VA = "0x1298C1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1298BF0", Offset = "0x1298BF0", VA = "0x1298BF0")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1298F50", Offset = "0x1298F50", VA = "0x1298F50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668A54", Offset = "0x668A54")]
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
			[Address(RVA = "0x1299164", Offset = "0x1299164", VA = "0x1299164", Slot = "4")]
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
			[Address(RVA = "0x12991CC", Offset = "0x12991CC", VA = "0x12991CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1299014", Offset = "0x1299014", VA = "0x1299014")]
		[DebuggerHidden]
		public <_StartWhenDone>d__280(int <>1__state)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1299040", Offset = "0x1299040", VA = "0x1299040", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1299044", Offset = "0x1299044", VA = "0x1299044", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x129916C", Offset = "0x129916C", VA = "0x129916C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668A64", Offset = "0x668A64")]
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
			[Address(RVA = "0x1299384", Offset = "0x1299384", VA = "0x1299384", Slot = "4")]
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
			[Address(RVA = "0x12993EC", Offset = "0x12993EC", VA = "0x12993EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1299230", Offset = "0x1299230", VA = "0x1299230")]
		[DebuggerHidden]
		public <_StartWhenDone>d__282(int <>1__state)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x129925C", Offset = "0x129925C", VA = "0x129925C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1299260", Offset = "0x1299260", VA = "0x1299260", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x129938C", Offset = "0x129938C", VA = "0x129938C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668A74", Offset = "0x668A74")]
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
			[Address(RVA = "0x12995B8", Offset = "0x12995B8", VA = "0x12995B8", Slot = "4")]
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
			[Address(RVA = "0x1299620", Offset = "0x1299620", VA = "0x1299620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1299450", Offset = "0x1299450", VA = "0x1299450")]
		[DebuggerHidden]
		public <_StartWhenDone>d__287(int <>1__state)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x129947C", Offset = "0x129947C", VA = "0x129947C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1299480", Offset = "0x1299480", VA = "0x1299480", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x12995C0", Offset = "0x12995C0", VA = "0x12995C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668A84", Offset = "0x668A84")]
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
			[Address(RVA = "0x1298ACC", Offset = "0x1298ACC", VA = "0x1298ACC", Slot = "4")]
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
			[Address(RVA = "0x1298B34", Offset = "0x1298B34", VA = "0x1298B34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1298978", Offset = "0x1298978", VA = "0x1298978")]
		[DebuggerHidden]
		public <_InjectDelay>d__288(int <>1__state)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x12989A4", Offset = "0x12989A4", VA = "0x12989A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x12989A8", Offset = "0x12989A8", VA = "0x12989A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1298AD4", Offset = "0x1298AD4", VA = "0x1298AD4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668A94", Offset = "0x668A94")]
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
			[Address(RVA = "0x1297ED0", Offset = "0x1297ED0", VA = "0x1297ED0", Slot = "4")]
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
			[Address(RVA = "0x1297F38", Offset = "0x1297F38", VA = "0x1297F38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1297DC8", Offset = "0x1297DC8", VA = "0x1297DC8")]
		[DebuggerHidden]
		public <_DelayedCall>d__313(int <>1__state)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1297DF4", Offset = "0x1297DF4", VA = "0x1297DF4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1297DF8", Offset = "0x1297DF8", VA = "0x1297DF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1297ED8", Offset = "0x1297ED8", VA = "0x1297ED8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668AA4", Offset = "0x668AA4")]
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
			[Address(RVA = "0x12997A4", Offset = "0x12997A4", VA = "0x12997A4", Slot = "4")]
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
			[Address(RVA = "0x129980C", Offset = "0x129980C", VA = "0x129980C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1299684", Offset = "0x1299684", VA = "0x1299684")]
		[DebuggerHidden]
		public <_WatchCall>d__334(int <>1__state)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x12996B0", Offset = "0x12996B0", VA = "0x12996B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x12996B4", Offset = "0x12996B4", VA = "0x12996B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x12997AC", Offset = "0x12997AC", VA = "0x12997AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668AB4", Offset = "0x668AB4")]
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
			[Address(RVA = "0x1297CFC", Offset = "0x1297CFC", VA = "0x1297CFC", Slot = "4")]
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
			[Address(RVA = "0x1297D64", Offset = "0x1297D64", VA = "0x1297D64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1297B8C", Offset = "0x1297B8C", VA = "0x1297B8C")]
		[DebuggerHidden]
		public <_CallContinuously>d__335(int <>1__state)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1297BB8", Offset = "0x1297BB8", VA = "0x1297BB8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1297BBC", Offset = "0x1297BBC", VA = "0x1297BBC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1297D04", Offset = "0x1297D04", VA = "0x1297D04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668AC4", Offset = "0x668AC4")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668AD4", Offset = "0x668AD4")]
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
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x668AE4", Offset = "0x668AE4")]
	public float TimeBetweenSlowUpdateCalls;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x668B1C", Offset = "0x668B1C")]
	public DebugInfoType ProfilerDebugAmount;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x668B54", Offset = "0x668B54")]
	public bool AutoTriggerManualTimeframe;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x668B8C", Offset = "0x668B8C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x668B8C", Offset = "0x668B8C")]
	public int UpdateCoroutines;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x668BDC", Offset = "0x668BDC")]
	public int FixedUpdateCoroutines;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x668C14", Offset = "0x668C14")]
	public int LateUpdateCoroutines;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x668C4C", Offset = "0x668C4C")]
	public int SlowUpdateCoroutines;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x668C84", Offset = "0x668C84")]
	public int RealtimeUpdateCoroutines;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x668CBC", Offset = "0x668CBC")]
	public int EditorUpdateCoroutines;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x668CF4", Offset = "0x668CF4")]
	public int EditorSlowUpdateCoroutines;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x668D2C", Offset = "0x668D2C")]
	public int EndOfFrameCoroutines;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x668D64", Offset = "0x668D64")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668DAC", Offset = "0x668DAC")]
	private static Thread <MainThread>k__BackingField;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668DBC", Offset = "0x668DBC")]
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
		[Address(RVA = "0xDEC068", Offset = "0xDEC068", VA = "0xDEC068")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000002")]
	public static float DeltaTime
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0xDEC30C", Offset = "0xDEC30C", VA = "0xDEC30C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000003")]
	public static Thread MainThread
	{
		[Token(Token = "0x600001A")]
		[Address(RVA = "0xDEC558", Offset = "0xDEC558", VA = "0xDEC558")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x669744", Offset = "0x669744")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001B")]
		[Address(RVA = "0xDEC5C0", Offset = "0xDEC5C0", VA = "0xDEC5C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x669754", Offset = "0x669754")]
		private set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public static CoroutineHandle CurrentCoroutine
	{
		[Token(Token = "0x600001C")]
		[Address(RVA = "0xDEC62C", Offset = "0xDEC62C", VA = "0xDEC62C")]
		get
		{
			return default(CoroutineHandle);
		}
	}

	[Token(Token = "0x17000005")]
	public CoroutineHandle currentCoroutine
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0xDEC7C8", Offset = "0xDEC7C8", VA = "0xDEC7C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x669764", Offset = "0x669764")]
		get
		{
			return default(CoroutineHandle);
		}
		[Token(Token = "0x600001E")]
		[Address(RVA = "0xDEC7D0", Offset = "0xDEC7D0", VA = "0xDEC7D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x669774", Offset = "0x669774")]
		private set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public static Timing Instance
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0xDEC0D4", Offset = "0xDEC0D4", VA = "0xDEC0D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000020")]
		[Address(RVA = "0xDECA30", Offset = "0xDECA30", VA = "0xDECA30")]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public static event Action OnPreExecute
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0xDEC378", Offset = "0xDEC378", VA = "0xDEC378")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x669724", Offset = "0x669724")]
		add
		{
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0xDEC468", Offset = "0xDEC468", VA = "0xDEC468")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x669734", Offset = "0x669734")]
		remove
		{
		}
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xDECA9C", Offset = "0xDECA9C", VA = "0xDECA9C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xDECB6C", Offset = "0xDECB6C", VA = "0xDECB6C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xDECFA0", Offset = "0xDECFA0", VA = "0xDECFA0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xDEC7D8", Offset = "0xDEC7D8", VA = "0xDEC7D8")]
	private void InitializeInstanceID()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xDED074", Offset = "0xDED074", VA = "0xDED074")]
	private void Update()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xDF08A0", Offset = "0xDF08A0", VA = "0xDF08A0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xDF0FCC", Offset = "0xDF0FCC", VA = "0xDF0FCC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xDEE974", Offset = "0xDEE974", VA = "0xDEE974")]
	public void TriggerManualTimeframeUpdate()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xDECCD4", Offset = "0xDECCD4", VA = "0xDECCD4")]
	private bool OnEditorStart()
	{
		return default(bool);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xDECCDC", Offset = "0xDECCDC", VA = "0xDECCDC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x669784", Offset = "0x669784")]
	private IEnumerator<float> _EOFPumpWatcher()
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xDF16F8", Offset = "0xDF16F8", VA = "0xDF16F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6697E8", Offset = "0x6697E8")]
	private IEnumerator _EOFPump()
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xDEF0C4", Offset = "0xDEF0C4", VA = "0xDEF0C4")]
	private void RemoveUnused()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xDF1C00", Offset = "0xDF1C00", VA = "0xDF1C00")]
	private void EditorRemoveUnused()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xDE8C18", Offset = "0xDE8C18", VA = "0xDE8C18")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xDE8D58", Offset = "0xDE8D58", VA = "0xDE8D58")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xDE8F48", Offset = "0xDE8F48", VA = "0xDE8F48")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xDE9094", Offset = "0xDE9094", VA = "0xDE9094")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xDE91E8", Offset = "0xDE91E8", VA = "0xDE91E8")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xDE93EC", Offset = "0xDE93EC", VA = "0xDE93EC")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xDE953C", Offset = "0xDE953C", VA = "0xDE953C")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xDE9690", Offset = "0xDE9690", VA = "0xDE9690")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xDE9894", Offset = "0xDE9894", VA = "0xDE9894")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xDE99EC", Offset = "0xDE99EC", VA = "0xDE99EC")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xDE9B54", Offset = "0xDE9B54", VA = "0xDE9B54")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xDE9D6C", Offset = "0xDE9D6C", VA = "0xDE9D6C")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xDF4D94", Offset = "0xDF4D94", VA = "0xDF4D94")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xDF4E00", Offset = "0xDF4E00", VA = "0xDF4E00")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xDF4F28", Offset = "0xDF4F28", VA = "0xDF4F28")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xDF4FA0", Offset = "0xDF4FA0", VA = "0xDF4FA0")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xDF5018", Offset = "0xDF5018", VA = "0xDF5018")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xDF5144", Offset = "0xDF5144", VA = "0xDF5144")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xDF51C0", Offset = "0xDF51C0", VA = "0xDF51C0")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xDF5238", Offset = "0xDF5238", VA = "0xDF5238")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xDF5364", Offset = "0xDF5364", VA = "0xDF5364")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xDF53E0", Offset = "0xDF53E0", VA = "0xDF53E0")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xDF545C", Offset = "0xDF545C", VA = "0xDF545C")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xDF5594", Offset = "0xDF5594", VA = "0xDF5594")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xDE9ED0", Offset = "0xDE9ED0", VA = "0xDE9ED0")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xDF5938", Offset = "0xDF5938", VA = "0xDF5938")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xDEA1AC", Offset = "0xDEA1AC", VA = "0xDEA1AC")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xDEA59C", Offset = "0xDEA59C", VA = "0xDEA59C")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xDF6578", Offset = "0xDF6578", VA = "0xDF6578")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xDEA99C", Offset = "0xDEA99C", VA = "0xDEA99C")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xDEAFAC", Offset = "0xDEAFAC", VA = "0xDEAFAC")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xDF6880", Offset = "0xDF6880", VA = "0xDF6880")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xDEB2A0", Offset = "0xDEB2A0", VA = "0xDEB2A0")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xDEB6BC", Offset = "0xDEB6BC", VA = "0xDEB6BC")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xDF6994", Offset = "0xDF6994", VA = "0xDF6994")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xDEBAD4", Offset = "0xDEBAD4", VA = "0xDEBAD4")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xDF6AB8", Offset = "0xDF6AB8", VA = "0xDF6AB8")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xDF6EB4", Offset = "0xDF6EB4", VA = "0xDF6EB4")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xDF6F80", Offset = "0xDF6F80", VA = "0xDF6F80")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xDECD4C", Offset = "0xDECD4C", VA = "0xDECD4C")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xDF784C", Offset = "0xDF784C", VA = "0xDF784C")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xDF7928", Offset = "0xDF7928", VA = "0xDF7928")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xDF83C8", Offset = "0xDF83C8", VA = "0xDF83C8")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xDF84A0", Offset = "0xDF84A0", VA = "0xDF84A0")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xDF8700", Offset = "0xDF8700", VA = "0xDF8700")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xDF8960", Offset = "0xDF8960", VA = "0xDF8960")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xDF8A50", Offset = "0xDF8A50", VA = "0xDF8A50")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xDF23C0", Offset = "0xDF23C0", VA = "0xDF23C0")]
	private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, int layer, bool layerHasValue, string tag, CoroutineHandle handle, bool prewarm)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xDF9044", Offset = "0xDF9044", VA = "0xDF9044")]
	public static int KillCoroutines()
	{
		return default(int);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xDF9120", Offset = "0xDF9120", VA = "0xDF9120")]
	public int KillCoroutinesOnInstance()
	{
		return default(int);
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xDE85A8", Offset = "0xDE85A8", VA = "0xDE85A8")]
	public static int KillCoroutines(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xDF9574", Offset = "0xDF9574", VA = "0xDF9574")]
	public static int KillCoroutines(IEnumerable<CoroutineHandle> handles)
	{
		return default(int);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xDEE784", Offset = "0xDEE784", VA = "0xDEE784")]
	public int KillCoroutinesOnInstance(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xDF9878", Offset = "0xDF9878", VA = "0xDF9878")]
	public static int KillCoroutines(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xDF997C", Offset = "0xDF997C", VA = "0xDF997C")]
	public int KillCoroutinesOnInstance(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xDF5A38", Offset = "0xDF5A38", VA = "0xDF5A38")]
	public static int KillCoroutines(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xDF71D4", Offset = "0xDF71D4", VA = "0xDF71D4")]
	public int KillCoroutinesOnInstance(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xDF6488", Offset = "0xDF6488", VA = "0xDF6488")]
	public static int KillCoroutines(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xDF75D4", Offset = "0xDF75D4", VA = "0xDF75D4")]
	public int KillCoroutinesOnInstance(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xDF9AC0", Offset = "0xDF9AC0", VA = "0xDF9AC0")]
	public static int KillCoroutines(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xDF9BCC", Offset = "0xDF9BCC", VA = "0xDF9BCC")]
	public int KillCoroutinesOnInstance(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xDF6690", Offset = "0xDF6690", VA = "0xDF6690")]
	public static int KillCoroutines(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xDF7CAC", Offset = "0xDF7CAC", VA = "0xDF7CAC")]
	public int KillCoroutinesOnInstance(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xDF94C8", Offset = "0xDF94C8", VA = "0xDF94C8")]
	public static Timing GetInstance(byte ID)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xDF9C0C", Offset = "0xDF9C0C", VA = "0xDF9C0C")]
	public static float WaitForSeconds(float waitTime)
	{
		return default(float);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xDF9C98", Offset = "0xDF9C98", VA = "0xDF9C98")]
	public float WaitForSecondsOnInstance(float waitTime)
	{
		return default(float);
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xDEE488", Offset = "0xDEE488", VA = "0xDEE488")]
	private bool UpdateTimeValues(Segment segment)
	{
		return default(bool);
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xDF9CDC", Offset = "0xDF9CDC", VA = "0xDF9CDC")]
	private float GetSegmentTime(Segment segment)
	{
		return default(float);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xDF9DC8", Offset = "0xDF9DC8", VA = "0xDF9DC8")]
	public static int PauseCoroutines()
	{
		return default(int);
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xDF9EA4", Offset = "0xDF9EA4", VA = "0xDF9EA4")]
	public int PauseCoroutinesOnInstance()
	{
		return default(int);
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xDE88F4", Offset = "0xDE88F4", VA = "0xDE88F4")]
	public static int PauseCoroutines(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xDFB144", Offset = "0xDFB144", VA = "0xDFB144")]
	public int PauseCoroutinesOnInstance(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xDFC0DC", Offset = "0xDFC0DC", VA = "0xDFC0DC")]
	public static int PauseCoroutines(IEnumerable<CoroutineHandle> handles)
	{
		return default(int);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xDFC2B8", Offset = "0xDFC2B8", VA = "0xDFC2B8")]
	public static int PauseCoroutines(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xDFC3A8", Offset = "0xDFC3A8", VA = "0xDFC3A8")]
	public int PauseCoroutinesOnInstance(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xDFC724", Offset = "0xDFC724", VA = "0xDFC724")]
	public static int PauseCoroutines(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xDFC458", Offset = "0xDFC458", VA = "0xDFC458")]
	public int PauseCoroutinesOnInstance(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xDFC814", Offset = "0xDFC814", VA = "0xDFC814")]
	public static int PauseCoroutines(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xDFC904", Offset = "0xDFC904", VA = "0xDFC904")]
	public int PauseCoroutinesOnInstance(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xDFCBD4", Offset = "0xDFCBD4", VA = "0xDFCBD4")]
	public static int PauseCoroutines(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xDFD080", Offset = "0xDFD080", VA = "0xDFD080")]
	public int PauseCoroutinesOnInstance(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xDFD138", Offset = "0xDFD138", VA = "0xDFD138")]
	public static int PauseCoroutines(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xDFCCE0", Offset = "0xDFCCE0", VA = "0xDFCCE0")]
	public int PauseCoroutinesOnInstance(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xDFD230", Offset = "0xDFD230", VA = "0xDFD230")]
	public static int ResumeCoroutines()
	{
		return default(int);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xDFD30C", Offset = "0xDFD30C", VA = "0xDFD30C")]
	public int ResumeCoroutinesOnInstance()
	{
		return default(int);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xDE8A04", Offset = "0xDE8A04", VA = "0xDE8A04")]
	public static int ResumeCoroutines(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xDF5B28", Offset = "0xDF5B28", VA = "0xDF5B28")]
	public static int ResumeCoroutines(IEnumerable<CoroutineHandle> handles)
	{
		return default(int);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xDF6C64", Offset = "0xDF6C64", VA = "0xDF6C64")]
	public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xDF7428", Offset = "0xDF7428", VA = "0xDF7428")]
	public int ResumeCoroutinesOnInstance(IEnumerable<CoroutineHandle> handles)
	{
		return default(int);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xDFD840", Offset = "0xDFD840", VA = "0xDFD840")]
	public static int ResumeCoroutines(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xDFDC0C", Offset = "0xDFDC0C", VA = "0xDFDC0C")]
	public int ResumeCoroutinesOnInstance(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xDFDCBC", Offset = "0xDFDCBC", VA = "0xDFDCBC")]
	public static int ResumeCoroutines(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xDFD944", Offset = "0xDFD944", VA = "0xDFD944")]
	public int ResumeCoroutinesOnInstance(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xDFDDAC", Offset = "0xDFDDAC", VA = "0xDFDDAC")]
	public static int ResumeCoroutines(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xDFDE9C", Offset = "0xDFDE9C", VA = "0xDFDE9C")]
	public int ResumeCoroutinesOnInstance(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xDFE168", Offset = "0xDFE168", VA = "0xDFE168")]
	public static int ResumeCoroutines(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xDFE274", Offset = "0xDFE274", VA = "0xDFE274")]
	public int ResumeCoroutinesOnInstance(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xDF6788", Offset = "0xDF6788", VA = "0xDF6788")]
	public static int ResumeCoroutines(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xDF8074", Offset = "0xDF8074", VA = "0xDF8074")]
	public int ResumeCoroutinesOnInstance(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xDE7550", Offset = "0xDE7550", VA = "0xDE7550")]
	public static string GetTag(CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xDE7670", Offset = "0xDE7670", VA = "0xDE7670")]
	public static int? GetLayer(CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xDE77B4", Offset = "0xDE77B4", VA = "0xDE77B4")]
	public static string GetDebugName(CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xDE7F50", Offset = "0xDE7F50", VA = "0xDE7F50")]
	public static Segment GetSegment(CoroutineHandle handle)
	{
		return default(Segment);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xDE79D4", Offset = "0xDE79D4", VA = "0xDE79D4")]
	public static bool SetTag(CoroutineHandle handle, string newTag, bool overwriteExisting = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xDE7D8C", Offset = "0xDE7D8C", VA = "0xDE7D8C")]
	public static bool SetLayer(CoroutineHandle handle, int newLayer, bool overwriteExisting = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xDE80C0", Offset = "0xDE80C0", VA = "0xDE80C0")]
	public static bool SetSegment(CoroutineHandle handle, Segment newSegment)
	{
		return default(bool);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xDFF644", Offset = "0xDFF644", VA = "0xDFF644")]
	public static bool RemoveTag(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xDE7C74", Offset = "0xDE7C74", VA = "0xDE7C74")]
	public static bool RemoveLayer(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xDE8414", Offset = "0xDE8414", VA = "0xDE8414")]
	public static bool IsRunning(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xDE8720", Offset = "0xDE8720", VA = "0xDE8720")]
	public static bool IsAliveAndPaused(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xDF8DD4", Offset = "0xDF8DD4", VA = "0xDF8DD4")]
	private void AddTagOnInstance(string tag, CoroutineHandle handle)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xDF8F0C", Offset = "0xDF8F0C", VA = "0xDF8F0C")]
	private void AddLayerOnInstance(int layer, CoroutineHandle handle)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xDFE3F4", Offset = "0xDFE3F4", VA = "0xDFE3F4")]
	private void RemoveTagOnInstance(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xDFE548", Offset = "0xDFE548", VA = "0xDFE548")]
	private void RemoveLayerOnInstance(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xDF19C4", Offset = "0xDF19C4", VA = "0xDF19C4")]
	private void RemoveGraffiti(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xDFE69C", Offset = "0xDFE69C", VA = "0xDFE69C")]
	private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xDF1768", Offset = "0xDF1768", VA = "0xDF1768")]
	private bool CoindexIsNull(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xDFE32C", Offset = "0xDFE32C", VA = "0xDFE32C")]
	private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xDF9804", Offset = "0xDF9804", VA = "0xDF9804")]
	private bool Nullify(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xDF99B4", Offset = "0xDF99B4", VA = "0xDF99B4")]
	private bool Nullify(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xDFB398", Offset = "0xDFB398", VA = "0xDFB398")]
	private bool SetPause(ProcessIndex coindex, bool newPausedState)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xDFE900", Offset = "0xDFE900", VA = "0xDFE900")]
	private bool SetHeld(ProcessIndex coindex, bool newHeldState)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xDFF6B0", Offset = "0xDFF6B0", VA = "0xDFF6B0")]
	private IEnumerator<float> CreateHold(ProcessIndex coindex, IEnumerator<float> coptr)
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xDFE834", Offset = "0xDFE834", VA = "0xDFE834")]
	private bool CoindexIsPaused(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xDFE768", Offset = "0xDFE768", VA = "0xDFE768")]
	private bool CoindexIsHeld(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xE00378", Offset = "0xE00378", VA = "0xE00378")]
	private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xE00474", Offset = "0xE00474", VA = "0xE00474")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine)
	{
		return default(float);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xE007D0", Offset = "0xE007D0", VA = "0xE007D0")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xE0086C", Offset = "0xE0086C", VA = "0xE0086C")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer)
	{
		return default(float);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xE00908", Offset = "0xE00908", VA = "0xE00908")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xE009B4", Offset = "0xE009B4", VA = "0xE009B4")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment)
	{
		return default(float);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xE00A34", Offset = "0xE00A34", VA = "0xE00A34")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xE00ABC", Offset = "0xE00ABC", VA = "0xE00ABC")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer)
	{
		return default(float);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xE00B44", Offset = "0xE00B44", VA = "0xE00B44")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xE00BDC", Offset = "0xE00BDC", VA = "0xE00BDC")]
	public static float WaitUntilDone(CoroutineHandle otherCoroutine)
	{
		return default(float);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xE00508", Offset = "0xE00508", VA = "0xE00508")]
	public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
	{
		return default(float);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xDF561C", Offset = "0xDF561C", VA = "0xDF561C")]
	public static void WaitForOtherHandles(CoroutineHandle handle, CoroutineHandle otherHandle, bool warnOnIssue = true)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xDF5CFC", Offset = "0xDF5CFC", VA = "0xDF5CFC")]
	public static void WaitForOtherHandles(CoroutineHandle handle, IEnumerable<CoroutineHandle> otherHandles, bool warnOnIssue = true)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xE00CCC", Offset = "0xE00CCC", VA = "0xE00CCC")]
	private void SwapToLast(CoroutineHandle firstHandle, CoroutineHandle lastHandle)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xE00C44", Offset = "0xE00C44", VA = "0xE00C44")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x66984C", Offset = "0x66984C")]
	private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xDF1838", Offset = "0xDF1838", VA = "0xDF1838")]
	private void CloseWaitingProcess(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xE01044", Offset = "0xE01044", VA = "0xE01044")]
	private bool HandleIsInWaitingList(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xE01110", Offset = "0xE01110", VA = "0xE01110")]
	private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xE01184", Offset = "0xE01184", VA = "0xE01184")]
	public static float WaitUntilDone(AsyncOperation operation)
	{
		return default(float);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xE01300", Offset = "0xE01300", VA = "0xE01300")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6698B0", Offset = "0x6698B0")]
	private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xE0137C", Offset = "0xE0137C", VA = "0xE0137C")]
	public static float WaitUntilDone(CustomYieldInstruction operation)
	{
		return default(float);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xE014FC", Offset = "0xE014FC", VA = "0xE014FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x669914", Offset = "0x669914")]
	private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xE01578", Offset = "0xE01578", VA = "0xE01578")]
	public static float WaitUntilTrue(Func<bool> evaluatorFunc)
	{
		return default(float);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xE01648", Offset = "0xE01648", VA = "0xE01648")]
	private static IEnumerator<float> WaitUntilTrueHelper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xE0176C", Offset = "0xE0176C", VA = "0xE0176C")]
	public static float WaitUntilFalse(Func<bool> evaluatorFunc)
	{
		return default(float);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xE0183C", Offset = "0xE0183C", VA = "0xE0183C")]
	private static IEnumerator<float> WaitUntilFalseHelper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xE016E0", Offset = "0xE016E0", VA = "0xE016E0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x669978", Offset = "0x669978")]
	private static IEnumerator<float> _StartWhenDone(Func<bool> evaluatorFunc, bool continueOn, IEnumerator<float> pausedProc)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xDFB0B4", Offset = "0xDFB0B4", VA = "0xDFB0B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6699DC", Offset = "0x6699DC")]
	private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float waitTime)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xE018D4", Offset = "0xE018D4", VA = "0xE018D4")]
	public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xE01A8C", Offset = "0xE01A8C", VA = "0xE01A8C")]
	public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xE01C38", Offset = "0xE01C38", VA = "0xE01C38")]
	public static int LinkCoroutines(CoroutineHandle master, CoroutineHandle slave)
	{
		return default(int);
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xE01E8C", Offset = "0xE01E8C", VA = "0xE01E8C")]
	public static int UnlinkCoroutines(CoroutineHandle master, CoroutineHandle slave, bool twoWay = false)
	{
		return default(int);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xE021E0", Offset = "0xE021E0", VA = "0xE021E0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x669A40", Offset = "0x669A40")]
	public static float GetMyHandle(Action<CoroutineHandle> reciever)
	{
		return default(float);
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xE02294", Offset = "0xE02294", VA = "0xE02294")]
	private static IEnumerator<float> GetHandleHelper(IEnumerator<float> input, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xE0234C", Offset = "0xE0234C", VA = "0xE0234C")]
	public static float SwitchCoroutine(Segment newSegment)
	{
		return default(float);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xE02400", Offset = "0xE02400", VA = "0xE02400")]
	private static IEnumerator<float> SwitchCoroutineRepS(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xE024B4", Offset = "0xE024B4", VA = "0xE024B4")]
	public static float SwitchCoroutine(Segment newSegment, string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xE0257C", Offset = "0xE0257C", VA = "0xE0257C")]
	private static IEnumerator<float> SwitchCoroutineRepST(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xE026D8", Offset = "0xE026D8", VA = "0xE026D8")]
	public static float SwitchCoroutine(Segment newSegment, int newLayer)
	{
		return default(float);
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xE027A0", Offset = "0xE027A0", VA = "0xE027A0")]
	private static IEnumerator<float> SwitchCoroutineRepSL(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xE02880", Offset = "0xE02880", VA = "0xE02880")]
	public static float SwitchCoroutine(Segment newSegment, int newLayer, string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xE02954", Offset = "0xE02954", VA = "0xE02954")]
	private static IEnumerator<float> SwitchCoroutineRepSLT(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xE02AD0", Offset = "0xE02AD0", VA = "0xE02AD0")]
	public static float SwitchCoroutine(string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xE02B84", Offset = "0xE02B84", VA = "0xE02B84")]
	private static IEnumerator<float> SwitchCoroutineRepT(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xE02C94", Offset = "0xE02C94", VA = "0xE02C94")]
	public static float SwitchCoroutine(int newLayer)
	{
		return default(float);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xE02D48", Offset = "0xE02D48", VA = "0xE02D48")]
	private static IEnumerator<float> SwitchCoroutineRepL(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xE02DE8", Offset = "0xE02DE8", VA = "0xE02DE8")]
	public static float SwitchCoroutine(int newLayer, string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xE02EB0", Offset = "0xE02EB0", VA = "0xE02EB0")]
	private static IEnumerator<float> SwitchCoroutineRepLT(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xE02FE4", Offset = "0xE02FE4", VA = "0xE02FE4")]
	public static CoroutineHandle CallDelayed(float delay, Action action)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xE03114", Offset = "0xE03114", VA = "0xE03114")]
	public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xE03154", Offset = "0xE03154", VA = "0xE03154")]
	public static CoroutineHandle CallDelayed(float delay, Action action, GameObject gameObject)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xE03200", Offset = "0xE03200", VA = "0xE03200")]
	public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject gameObject)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xE03080", Offset = "0xE03080", VA = "0xE03080")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x669A7C", Offset = "0x669A7C")]
	private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xE03244", Offset = "0xE03244", VA = "0xE03244")]
	public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xE032F0", Offset = "0xE032F0", VA = "0xE032F0")]
	public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xE0333C", Offset = "0xE0333C", VA = "0xE0333C")]
	public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action, GameObject gameObject)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xE033F0", Offset = "0xE033F0", VA = "0xE033F0")]
	public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action, GameObject gameObject)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xE0344C", Offset = "0xE0344C", VA = "0xE0344C")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xE0367C", Offset = "0xE0367C", VA = "0xE0367C")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xE03714", Offset = "0xE03714", VA = "0xE03714")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xE03824", Offset = "0xE03824", VA = "0xE03824")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xE0392C", Offset = "0xE0392C", VA = "0xE0392C")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xE03A30", Offset = "0xE03A30", VA = "0xE03A30")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xE03B38", Offset = "0xE03B38", VA = "0xE03B38")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xE03C5C", Offset = "0xE03C5C", VA = "0xE03C5C")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xE03D70", Offset = "0xE03D70", VA = "0xE03D70")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xE03E70", Offset = "0xE03E70", VA = "0xE03E70")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xE03F60", Offset = "0xE03F60", VA = "0xE03F60")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xE0406C", Offset = "0xE0406C", VA = "0xE0406C")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xE04170", Offset = "0xE04170", VA = "0xE04170")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xE0427C", Offset = "0xE0427C", VA = "0xE0427C")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xE04380", Offset = "0xE04380", VA = "0xE04380")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xE044A0", Offset = "0xE044A0", VA = "0xE044A0")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xE035D8", Offset = "0xE035D8", VA = "0xE035D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x669AE0", Offset = "0x669AE0")]
	private IEnumerator<float> _WatchCall(float timeframe, CoroutineHandle handle, GameObject gObject, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xE03544", Offset = "0xE03544", VA = "0xE03544")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x669B44", Offset = "0x669B44")]
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
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x669BA8", Offset = "0x669BA8")]
	private IEnumerator<float> _WatchCall<T>(T reference, float timeframe, CoroutineHandle handle, GameObject gObject, Action<T> onDone)
	{
		return null;
	}

	[Token(Token = "0x6000107")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x669C0C", Offset = "0x669C0C")]
	private IEnumerator<float> _CallContinuously<T>(T reference, float period, Action<T> action, GameObject gObject)
	{
		return null;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xE045B0", Offset = "0xE045B0", VA = "0xE045B0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x669C70", Offset = "0x669C70")]
	public new Coroutine StartCoroutine(IEnumerator routine)
	{
		return null;
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xE045B8", Offset = "0xE045B8", VA = "0xE045B8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x669CAC", Offset = "0x669CAC")]
	public new Coroutine StartCoroutine(string methodName, object value)
	{
		return null;
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xE045C0", Offset = "0xE045C0", VA = "0xE045C0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x669CE8", Offset = "0x669CE8")]
	public new Coroutine StartCoroutine(string methodName)
	{
		return null;
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xE045C8", Offset = "0xE045C8", VA = "0xE045C8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x669D24", Offset = "0x669D24")]
	public new Coroutine StartCoroutine_Auto(IEnumerator routine)
	{
		return null;
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xE045D0", Offset = "0xE045D0", VA = "0xE045D0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x669D60", Offset = "0x669D60")]
	public new void StopCoroutine(string methodName)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xE045D4", Offset = "0xE045D4", VA = "0xE045D4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x669D9C", Offset = "0x669D9C")]
	public new void StopCoroutine(IEnumerator routine)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xE045D8", Offset = "0xE045D8", VA = "0xE045D8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x669DD8", Offset = "0x669DD8")]
	public new void StopCoroutine(Coroutine routine)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xE045DC", Offset = "0xE045DC", VA = "0xE045DC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x669E14", Offset = "0x669E14")]
	public new void StopAllCoroutines()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xE045E0", Offset = "0xE045E0", VA = "0xE045E0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x669E50", Offset = "0x669E50")]
	public new static void Destroy(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xE045E4", Offset = "0xE045E4", VA = "0xE045E4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x669E8C", Offset = "0x669E8C")]
	public new static void Destroy(UnityEngine.Object obj, float f)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xE045E8", Offset = "0xE045E8", VA = "0xE045E8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x669EC8", Offset = "0x669EC8")]
	public static void DestroyObject(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xE045EC", Offset = "0xE045EC", VA = "0xE045EC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x669F04", Offset = "0x669F04")]
	public static void DestroyObject(UnityEngine.Object obj, float f)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xE045F0", Offset = "0xE045F0", VA = "0xE045F0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x669F40", Offset = "0x669F40")]
	public new static void DestroyImmediate(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xE045F4", Offset = "0xE045F4", VA = "0xE045F4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x669F7C", Offset = "0x669F7C")]
	public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xE045F8", Offset = "0xE045F8", VA = "0xE045F8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x669FB8", Offset = "0x669FB8")]
	public new static void Instantiate(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xE045FC", Offset = "0xE045FC", VA = "0xE045FC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x669FF4", Offset = "0x669FF4")]
	public new static void Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation)
	{
	}

	[Token(Token = "0x6000118")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x66A030", Offset = "0x66A030")]
	public new static void Instantiate<T>(T original) where T : UnityEngine.Object
	{
	}

	[Token(Token = "0x6000119")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x66A06C", Offset = "0x66A06C")]
	public new static T FindObjectOfType<T>() where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xE04600", Offset = "0xE04600", VA = "0xE04600")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x66A0A8", Offset = "0x66A0A8")]
	public new static UnityEngine.Object FindObjectOfType(Type t)
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x66A0E4", Offset = "0x66A0E4")]
	public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xE04608", Offset = "0xE04608", VA = "0xE04608")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x66A120", Offset = "0x66A120")]
	public new static UnityEngine.Object[] FindObjectsOfType(Type t)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xE04610", Offset = "0xE04610", VA = "0xE04610")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x66A15C", Offset = "0x66A15C")]
	public new static void print(object message)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xE04614", Offset = "0xE04614", VA = "0xE04614")]
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
		[Address(RVA = "0x692DF0", Offset = "0x692DF0", VA = "0x692DF0")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x17000008")]
	public string Tag
	{
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x692E34", Offset = "0x692E34", VA = "0x692E34")]
		get
		{
			return null;
		}
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x692E3C", Offset = "0x692E3C", VA = "0x692E3C")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public int? Layer
	{
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x692E44", Offset = "0x692E44", VA = "0x692E44")]
		get
		{
			return null;
		}
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x692E4C", Offset = "0x692E4C", VA = "0x692E4C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public Segment Segment
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x692E54", Offset = "0x692E54", VA = "0x692E54")]
		get
		{
			return default(Segment);
		}
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x692E5C", Offset = "0x692E5C", VA = "0x692E5C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public bool IsRunning
	{
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x692E64", Offset = "0x692E64", VA = "0x692E64")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x692E6C", Offset = "0x692E6C", VA = "0x692E6C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public bool IsAliveAndPaused
	{
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x692E78", Offset = "0x692E78", VA = "0x692E78")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x692E80", Offset = "0x692E80", VA = "0x692E80")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public bool IsValid
	{
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x692E8C", Offset = "0x692E8C", VA = "0x692E8C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x692DFC", Offset = "0x692DFC", VA = "0x692DFC")]
	public CoroutineHandle(byte ind)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x692E04", Offset = "0x692E04", VA = "0x692E04")]
	public CoroutineHandle(CoroutineHandle other)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x692E0C", Offset = "0x692E0C", VA = "0x692E0C", Slot = "4")]
	public bool Equals(CoroutineHandle other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x692E1C", Offset = "0x692E1C", VA = "0x692E1C", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xDE71EC", Offset = "0xDE71EC", VA = "0xDE71EC")]
	public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xDE71F8", Offset = "0xDE71F8", VA = "0xDE71F8")]
	public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x692E24", Offset = "0x692E24", VA = "0x692E24", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x692E2C", Offset = "0x692E2C", VA = "0x692E2C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000008")]
public static class MECExtensionMethods1
{
	[Token(Token = "0x6000135")]
	[Address(RVA = "0xDE8BAC", Offset = "0xDE8BAC", VA = "0xDE8BAC")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xDE8CDC", Offset = "0xDE8CDC", VA = "0xDE8CDC")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xDE8ECC", Offset = "0xDE8ECC", VA = "0xDE8ECC")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xDE9018", Offset = "0xDE9018", VA = "0xDE9018")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xDE9164", Offset = "0xDE9164", VA = "0xDE9164")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xDE9368", Offset = "0xDE9368", VA = "0xDE9368")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xDE94C0", Offset = "0xDE94C0", VA = "0xDE94C0")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xDE960C", Offset = "0xDE960C", VA = "0xDE960C")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xDE9810", Offset = "0xDE9810", VA = "0xDE9810")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xDE9968", Offset = "0xDE9968", VA = "0xDE9968")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xDE9AC0", Offset = "0xDE9AC0", VA = "0xDE9AC0")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xDE9CD8", Offset = "0xDE9CD8", VA = "0xDE9CD8")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xDE9E4C", Offset = "0xDE9E4C", VA = "0xDE9E4C")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xDEA0AC", Offset = "0xDEA0AC", VA = "0xDEA0AC")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xDEA494", Offset = "0xDEA494", VA = "0xDEA494")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xDEA518", Offset = "0xDEA518", VA = "0xDEA518")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xDEA884", Offset = "0xDEA884", VA = "0xDEA884")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xDEAE84", Offset = "0xDEAE84", VA = "0xDEAE84")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xDEAF18", Offset = "0xDEAF18", VA = "0xDEAF18")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xDEB18C", Offset = "0xDEB18C", VA = "0xDEB18C")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xDEB594", Offset = "0xDEB594", VA = "0xDEB594")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xDEB628", Offset = "0xDEB628", VA = "0xDEB628")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xDEB9B0", Offset = "0xDEB9B0", VA = "0xDEB9B0")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xDEBFCC", Offset = "0xDEBFCC", VA = "0xDEBFCC")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}
}
