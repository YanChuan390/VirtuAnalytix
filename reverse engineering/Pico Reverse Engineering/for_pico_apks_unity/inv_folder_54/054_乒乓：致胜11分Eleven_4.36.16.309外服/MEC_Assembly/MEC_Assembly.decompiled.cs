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
public static class MECExtensionMethods
{
	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAA64", Offset = "0xAEAA64")]
	private sealed class <Delay>d__0 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float timeToDelay;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700000C")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x195B4B4", Offset = "0x195B4B4", VA = "0x195B4B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x195B4FC", Offset = "0x195B4FC", VA = "0x195B4FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x195B2C4", Offset = "0x195B2C4", VA = "0x195B2C4")]
		[DebuggerHidden]
		public <Delay>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x195B2F0", Offset = "0x195B2F0", VA = "0x195B2F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x195B2F4", Offset = "0x195B2F4", VA = "0x195B2F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x195B4BC", Offset = "0x195B4BC", VA = "0x195B4BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAA74", Offset = "0xAEAA74")]
	private sealed class <Delay>d__1 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700000E")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x195B728", Offset = "0x195B728", VA = "0x195B728", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x195B770", Offset = "0x195B770", VA = "0x195B770", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x195B55C", Offset = "0x195B55C", VA = "0x195B55C")]
		[DebuggerHidden]
		public <Delay>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x195B588", Offset = "0x195B588", VA = "0x195B588", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x195B58C", Offset = "0x195B58C", VA = "0x195B58C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x195B730", Offset = "0x195B730", VA = "0x195B730", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAA84", Offset = "0xAEAA84")]
	private sealed class <Delay>d__2<T> : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Func<T, bool> condition;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T data;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000010")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000134")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000011")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000136")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000131")]
		[DebuggerHidden]
		public <Delay>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000132")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000133")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000135")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAA94", Offset = "0xAEAA94")]
	private sealed class <DelayFrames>d__3 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int framesToDelay;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000012")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x195B984", Offset = "0x195B984", VA = "0x195B984", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000013")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x195B9CC", Offset = "0x195B9CC", VA = "0x195B9CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x195B7D0", Offset = "0x195B7D0", VA = "0x195B7D0")]
		[DebuggerHidden]
		public <DelayFrames>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x195B7FC", Offset = "0x195B7FC", VA = "0x195B7FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x195B800", Offset = "0x195B800", VA = "0x195B800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x195B98C", Offset = "0x195B98C", VA = "0x195B98C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAAA4", Offset = "0xAEAAA4")]
	private sealed class <CancelWith>d__4 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject;

		[Token(Token = "0x17000014")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x195ABC8", Offset = "0x195ABC8", VA = "0x195ABC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000015")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x195AC10", Offset = "0x195AC10", VA = "0x195AC10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x195A95C", Offset = "0x195A95C", VA = "0x195A95C")]
		[DebuggerHidden]
		public <CancelWith>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x195A988", Offset = "0x195A988", VA = "0x195A988", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x195A98C", Offset = "0x195A98C", VA = "0x195A98C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x195ABD0", Offset = "0x195ABD0", VA = "0x195ABD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAAB4", Offset = "0xAEAAB4")]
	private sealed class <CancelWith>d__5 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject1;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gameObject2;

		[Token(Token = "0x17000016")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x195AF1C", Offset = "0x195AF1C", VA = "0x195AF1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x195AF64", Offset = "0x195AF64", VA = "0x195AF64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x195AC70", Offset = "0x195AC70", VA = "0x195AC70")]
		[DebuggerHidden]
		public <CancelWith>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x195AC9C", Offset = "0x195AC9C", VA = "0x195AC9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x195ACA0", Offset = "0x195ACA0", VA = "0x195ACA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x195AF24", Offset = "0x195AF24", VA = "0x195AF24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAAC4", Offset = "0xAEAAC4")]
	private sealed class <CancelWith>d__6 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000018")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x195B21C", Offset = "0x195B21C", VA = "0x195B21C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x195B264", Offset = "0x195B264", VA = "0x195B264", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x195AFC4", Offset = "0x195AFC4", VA = "0x195AFC4")]
		[DebuggerHidden]
		public <CancelWith>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x195AFF0", Offset = "0x195AFF0", VA = "0x195AFF0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x195AFF4", Offset = "0x195AFF4", VA = "0x195AFF4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x195B224", Offset = "0x195B224", VA = "0x195B224", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAAD4", Offset = "0xAEAAD4")]
	private sealed class <PauseWith>d__7 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700001A")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x195BF18", Offset = "0x195BF18", VA = "0x195BF18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x195BF60", Offset = "0x195BF60", VA = "0x195BF60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x195BCA4", Offset = "0x195BCA4", VA = "0x195BCA4")]
		[DebuggerHidden]
		public <PauseWith>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x195BCD0", Offset = "0x195BCD0", VA = "0x195BCD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x195BCD4", Offset = "0x195BCD4", VA = "0x195BCD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x195BF20", Offset = "0x195BF20", VA = "0x195BF20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAAE4", Offset = "0xAEAAE4")]
	private sealed class <PauseWith>d__8 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject1;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject2;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700001C")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x195C278", Offset = "0x195C278", VA = "0x195C278", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x195C2C0", Offset = "0x195C2C0", VA = "0x195C2C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x195BFC0", Offset = "0x195BFC0", VA = "0x195BFC0")]
		[DebuggerHidden]
		public <PauseWith>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x195BFEC", Offset = "0x195BFEC", VA = "0x195BFEC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x195BFF0", Offset = "0x195BFF0", VA = "0x195BFF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x195C280", Offset = "0x195C280", VA = "0x195C280", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAAF4", Offset = "0xAEAAF4")]
	private sealed class <PauseWith>d__9 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700001E")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x195C578", Offset = "0x195C578", VA = "0x195C578", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x195C5C0", Offset = "0x195C5C0", VA = "0x195C5C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x195C320", Offset = "0x195C320", VA = "0x195C320")]
		[DebuggerHidden]
		public <PauseWith>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x195C34C", Offset = "0x195C34C", VA = "0x195C34C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x195C350", Offset = "0x195C350", VA = "0x195C350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x195C580", Offset = "0x195C580", VA = "0x195C580", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAB04", Offset = "0xAEAB04")]
	private sealed class <Append>d__10 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> nextCoroutine;

		[Token(Token = "0x17000020")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x195A674", Offset = "0x195A674", VA = "0x195A674", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x195A6BC", Offset = "0x195A6BC", VA = "0x195A6BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x195A3CC", Offset = "0x195A3CC", VA = "0x195A3CC")]
		[DebuggerHidden]
		public <Append>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x195A3F8", Offset = "0x195A3F8", VA = "0x195A3F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x195A3FC", Offset = "0x195A3FC", VA = "0x195A3FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x195A67C", Offset = "0x195A67C", VA = "0x195A67C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAB14", Offset = "0xAEAB14")]
	private sealed class <Append>d__11 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action onDone;

		[Token(Token = "0x17000022")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x195A8B4", Offset = "0x195A8B4", VA = "0x195A8B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x195A8FC", Offset = "0x195A8FC", VA = "0x195A8FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x195A71C", Offset = "0x195A71C", VA = "0x195A71C")]
		[DebuggerHidden]
		public <Append>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x195A748", Offset = "0x195A748", VA = "0x195A748", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x195A74C", Offset = "0x195A74C", VA = "0x195A74C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x195A8BC", Offset = "0x195A8BC", VA = "0x195A8BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAB24", Offset = "0xAEAB24")]
	private sealed class <Prepend>d__12 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> lastCoroutine;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000024")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x195C8DC", Offset = "0x195C8DC", VA = "0x195C8DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x195C924", Offset = "0x195C924", VA = "0x195C924", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x195C620", Offset = "0x195C620", VA = "0x195C620")]
		[DebuggerHidden]
		public <Prepend>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x195C64C", Offset = "0x195C64C", VA = "0x195C64C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x195C650", Offset = "0x195C650", VA = "0x195C650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x195C8E4", Offset = "0x195C8E4", VA = "0x195C8E4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAB34", Offset = "0xAEAB34")]
	private sealed class <Prepend>d__13 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onStart;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000026")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x195CB2C", Offset = "0x195CB2C", VA = "0x195CB2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x195CB74", Offset = "0x195CB74", VA = "0x195CB74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x195C984", Offset = "0x195C984", VA = "0x195C984")]
		[DebuggerHidden]
		public <Prepend>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x195C9B0", Offset = "0x195C9B0", VA = "0x195C9B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x195C9B4", Offset = "0x195C9B4", VA = "0x195C9B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x195CB34", Offset = "0x195CB34", VA = "0x195CB34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAB44", Offset = "0xAEAB44")]
	private sealed class <Superimpose>d__15 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutineA;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Timing instance;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> coroutineB;

		[Token(Token = "0x17000028")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x195D244", Offset = "0x195D244", VA = "0x195D244", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x195D28C", Offset = "0x195D28C", VA = "0x195D28C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x195CBD4", Offset = "0x195CBD4", VA = "0x195CBD4")]
		[DebuggerHidden]
		public <Superimpose>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x195CC00", Offset = "0x195CC00", VA = "0x195CC00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x195CC04", Offset = "0x195CC04", VA = "0x195CC04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x195D24C", Offset = "0x195D24C", VA = "0x195D24C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAB54", Offset = "0xAEAB54")]
	private sealed class <Hijack>d__16 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<float, float> newReturn;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700002A")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x195BBFC", Offset = "0x195BBFC", VA = "0x195BBFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x195BC44", Offset = "0x195BC44", VA = "0x195BC44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x195BA2C", Offset = "0x195BA2C", VA = "0x195BA2C")]
		[DebuggerHidden]
		public <Hijack>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x195BA58", Offset = "0x195BA58", VA = "0x195BA58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x195BA5C", Offset = "0x195BA5C", VA = "0x195BA5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x195BC04", Offset = "0x195BC04", VA = "0x195BC04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1745E10", Offset = "0x1745E10", VA = "0x1745E10")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEAF0C", Offset = "0xAEAF0C")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, float timeToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1745E98", Offset = "0x1745E98", VA = "0x1745E98")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEAF7C", Offset = "0xAEAF7C")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEAFEC", Offset = "0xAEAFEC")]
	public static IEnumerator<float> Delay<T>(this IEnumerator<float> coroutine, T data, Func<T, bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1745F2C", Offset = "0x1745F2C", VA = "0x1745F2C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB05C", Offset = "0xAEB05C")]
	public static IEnumerator<float> DelayFrames(this IEnumerator<float> coroutine, int framesToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1745FB4", Offset = "0x1745FB4", VA = "0x1745FB4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB0CC", Offset = "0xAEB0CC")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1746048", Offset = "0x1746048", VA = "0x1746048")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB13C", Offset = "0xAEB13C")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x17460F0", Offset = "0x17460F0", VA = "0x17460F0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB1AC", Offset = "0xAEB1AC")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1746184", Offset = "0x1746184", VA = "0x1746184")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB21C", Offset = "0xAEB21C")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1746218", Offset = "0x1746218", VA = "0x1746218")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB28C", Offset = "0xAEB28C")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x17462C0", Offset = "0x17462C0", VA = "0x17462C0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB2FC", Offset = "0xAEB2FC")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1746354", Offset = "0x1746354", VA = "0x1746354")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB36C", Offset = "0xAEB36C")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, IEnumerator<float> nextCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x17463E8", Offset = "0x17463E8", VA = "0x17463E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB3DC", Offset = "0xAEB3DC")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x174647C", Offset = "0x174647C", VA = "0x174647C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB44C", Offset = "0xAEB44C")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, IEnumerator<float> lastCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1746510", Offset = "0x1746510", VA = "0x1746510")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB4BC", Offset = "0xAEB4BC")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, Action onStart)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x17465A4", Offset = "0x17465A4", VA = "0x17465A4")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x17468CC", Offset = "0x17468CC", VA = "0x17468CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB53C", Offset = "0xAEB53C")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB, Timing instance)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1746974", Offset = "0x1746974", VA = "0x1746974")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB5AC", Offset = "0xAEB5AC")]
	public static IEnumerator<float> Hijack(this IEnumerator<float> coroutine, Func<float, float> newReturn)
	{
		return null;
	}
}
namespace MEC;

[Token(Token = "0x2000003")]
public class Timing : MonoBehaviour
{
	[Token(Token = "0x2000018")]
	private struct ProcessIndex : IEquatable<ProcessIndex>
	{
		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Segment seg;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int i;

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x195EF1C", Offset = "0x195EF1C", VA = "0x195EF1C", Slot = "4")]
		public bool Equals(ProcessIndex other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x195EF44", Offset = "0x195EF44", VA = "0x195EF44", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x195EFD8", Offset = "0x195EFD8", VA = "0x195EFD8")]
		public static bool operator ==(ProcessIndex a, ProcessIndex b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x195EFF8", Offset = "0x195EFF8", VA = "0x195EFF8")]
		public static bool operator !=(ProcessIndex a, ProcessIndex b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x195F018", Offset = "0x195F018", VA = "0x195F018", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAB64", Offset = "0xAEAB64")]
	private sealed class <_EOFPumpWatcher>d__116 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Timing <>4__this;

		[Token(Token = "0x1700002C")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x195DD60", Offset = "0x195DD60", VA = "0x195DD60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x195DDA8", Offset = "0x195DDA8", VA = "0x195DDA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x195DCA4", Offset = "0x195DCA4", VA = "0x195DCA4")]
		[DebuggerHidden]
		public <_EOFPumpWatcher>d__116(int <>1__state)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x195DCD0", Offset = "0x195DCD0", VA = "0x195DCD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x195DCD4", Offset = "0x195DCD4", VA = "0x195DCD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x195DD68", Offset = "0x195DD68", VA = "0x195DD68", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAB74", Offset = "0xAEAB74")]
	private sealed class <_EOFPump>d__117 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Timing <>4__this;

		[Token(Token = "0x1700002E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x195DC54", Offset = "0x195DC54", VA = "0x195DC54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x195DC9C", Offset = "0x195DC9C", VA = "0x195DC9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x195D6AC", Offset = "0x195D6AC", VA = "0x195D6AC")]
		[DebuggerHidden]
		public <_EOFPump>d__117(int <>1__state)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x195D6D8", Offset = "0x195D6D8", VA = "0x195D6D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x195D6DC", Offset = "0x195D6DC", VA = "0x195D6DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x195DC5C", Offset = "0x195DC5C", VA = "0x195DC5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAB84", Offset = "0xAEAB84")]
	private sealed class <_StartWhenDone>d__252 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Timing <>4__this;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CoroutineHandle handle;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> proc;

		[Token(Token = "0x17000030")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x195E3F8", Offset = "0x195E3F8", VA = "0x195E3F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000031")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x195E440", Offset = "0x195E440", VA = "0x195E440", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x195E034", Offset = "0x195E034", VA = "0x195E034")]
		[DebuggerHidden]
		public <_StartWhenDone>d__252(int <>1__state)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x195E060", Offset = "0x195E060", VA = "0x195E060", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x195E0B8", Offset = "0x195E0B8", VA = "0x195E0B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x195E08C", Offset = "0x195E08C", VA = "0x195E08C")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x195E400", Offset = "0x195E400", VA = "0x195E400", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAB94", Offset = "0xAEAB94")]
	private sealed class <_StartWhenDone>d__258 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WWW wwwObject;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> pausedProc;

		[Token(Token = "0x17000032")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x195E61C", Offset = "0x195E61C", VA = "0x195E61C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000033")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x195E664", Offset = "0x195E664", VA = "0x195E664", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x195E4A0", Offset = "0x195E4A0", VA = "0x195E4A0")]
		[DebuggerHidden]
		public <_StartWhenDone>d__258(int <>1__state)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x195E4CC", Offset = "0x195E4CC", VA = "0x195E4CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x195E4D0", Offset = "0x195E4D0", VA = "0x195E4D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x195E624", Offset = "0x195E624", VA = "0x195E624", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEABA4", Offset = "0xAEABA4")]
	private sealed class <_StartWhenDone>d__261 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AsyncOperation operation;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> pausedProc;

		[Token(Token = "0x17000034")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x195E840", Offset = "0x195E840", VA = "0x195E840", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000035")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x195E888", Offset = "0x195E888", VA = "0x195E888", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x195E6C4", Offset = "0x195E6C4", VA = "0x195E6C4")]
		[DebuggerHidden]
		public <_StartWhenDone>d__261(int <>1__state)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x195E6F0", Offset = "0x195E6F0", VA = "0x195E6F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x195E6F4", Offset = "0x195E6F4", VA = "0x195E6F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x195E848", Offset = "0x195E848", VA = "0x195E848", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEABB4", Offset = "0xAEABB4")]
	private sealed class <_StartWhenDone>d__264 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CustomYieldInstruction operation;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> pausedProc;

		[Token(Token = "0x17000036")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x195EA68", Offset = "0x195EA68", VA = "0x195EA68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000037")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x195EAB0", Offset = "0x195EAB0", VA = "0x195EAB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x195E8E8", Offset = "0x195E8E8", VA = "0x195E8E8")]
		[DebuggerHidden]
		public <_StartWhenDone>d__264(int <>1__state)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x195E914", Offset = "0x195E914", VA = "0x195E914", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x195E918", Offset = "0x195E918", VA = "0x195E918", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x195EA70", Offset = "0x195EA70", VA = "0x195EA70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEABC4", Offset = "0xAEABC4")]
	private sealed class <_StartWhenDone>d__269 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> evaluatorFunc;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool continueOn;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> pausedProc;

		[Token(Token = "0x17000038")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x195ECB0", Offset = "0x195ECB0", VA = "0x195ECB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x195ECF8", Offset = "0x195ECF8", VA = "0x195ECF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x195EB10", Offset = "0x195EB10", VA = "0x195EB10")]
		[DebuggerHidden]
		public <_StartWhenDone>d__269(int <>1__state)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x195EB3C", Offset = "0x195EB3C", VA = "0x195EB3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x195EB40", Offset = "0x195EB40", VA = "0x195EB40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x195ECB8", Offset = "0x195ECB8", VA = "0x195ECB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEABD4", Offset = "0xAEABD4")]
	private sealed class <_InjectDelay>d__270 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Timing <>4__this;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float waitTime;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> proc;

		[Token(Token = "0x1700003A")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x195DF8C", Offset = "0x195DF8C", VA = "0x195DF8C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x195DFD4", Offset = "0x195DFD4", VA = "0x195DFD4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x195DE08", Offset = "0x195DE08", VA = "0x195DE08")]
		[DebuggerHidden]
		public <_InjectDelay>d__270(int <>1__state)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x195DE34", Offset = "0x195DE34", VA = "0x195DE34", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x195DE38", Offset = "0x195DE38", VA = "0x195DE38", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x195DF94", Offset = "0x195DF94", VA = "0x195DF94", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEABE4", Offset = "0xAEABE4")]
	private sealed class <_DelayedCall>d__295 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Timing <>4__this;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject cancelWith;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action action;

		[Token(Token = "0x1700003C")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x195D604", Offset = "0x195D604", VA = "0x195D604", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x195D64C", Offset = "0x195D64C", VA = "0x195D64C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x195D500", Offset = "0x195D500", VA = "0x195D500")]
		[DebuggerHidden]
		public <_DelayedCall>d__295(int <>1__state)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x195D52C", Offset = "0x195D52C", VA = "0x195D52C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x195D530", Offset = "0x195D530", VA = "0x195D530", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x195D60C", Offset = "0x195D60C", VA = "0x195D60C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEABF4", Offset = "0xAEABF4")]
	private sealed class <_WatchCall>d__312 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Timing <>4__this;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float timeframe;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public CoroutineHandle handle;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onDone;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject gObject;

		[Token(Token = "0x1700003E")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x195EE74", Offset = "0x195EE74", VA = "0x195EE74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x195EEBC", Offset = "0x195EEBC", VA = "0x195EEBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x195ED58", Offset = "0x195ED58", VA = "0x195ED58")]
		[DebuggerHidden]
		public <_WatchCall>d__312(int <>1__state)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x195ED84", Offset = "0x195ED84", VA = "0x195ED84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x195ED88", Offset = "0x195ED88", VA = "0x195ED88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x195EE7C", Offset = "0x195EE7C", VA = "0x195EE7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAC04", Offset = "0xAEAC04")]
	private sealed class <_CallContinuously>d__313 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Timing <>4__this;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float period;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gObject;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action action;

		[Token(Token = "0x17000040")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x195D458", Offset = "0x195D458", VA = "0x195D458", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x195D4A0", Offset = "0x195D4A0", VA = "0x195D4A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x195D2EC", Offset = "0x195D2EC", VA = "0x195D2EC")]
		[DebuggerHidden]
		public <_CallContinuously>d__313(int <>1__state)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x195D318", Offset = "0x195D318", VA = "0x195D318", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x195D31C", Offset = "0x195D31C", VA = "0x195D31C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x195D460", Offset = "0x195D460", VA = "0x195D460", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAC14", Offset = "0xAEAC14")]
	private sealed class <_WatchCall>d__330<T> : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Timing <>4__this;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float timeframe;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CoroutineHandle handle;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> onDone;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject gObject;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T reference;

		[Token(Token = "0x17000042")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001D0")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000043")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D2")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CD")]
		[DebuggerHidden]
		public <_WatchCall>d__330(int <>1__state)
		{
		}

		[Token(Token = "0x60001CE")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CF")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D1")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAC24", Offset = "0xAEAC24")]
	private sealed class <_CallContinuously>d__331<T> : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Timing <>4__this;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float period;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject gObject;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> action;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T reference;

		[Token(Token = "0x17000044")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001D6")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000045")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D8")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D3")]
		[DebuggerHidden]
		public <_CallContinuously>d__331(int <>1__state)
		{
		}

		[Token(Token = "0x60001D4")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D5")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEAC34", Offset = "0xAEAC34")]
	public float TimeBetweenSlowUpdateCalls;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEAC6C", Offset = "0xAEAC6C")]
	public DebugInfoType ProfilerDebugAmount;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEACA4", Offset = "0xAEACA4")]
	public bool AutoTriggerManualTimeframe;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEACDC", Offset = "0xAEACDC")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xAEACDC", Offset = "0xAEACDC")]
	public int UpdateCoroutines;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEAD2C", Offset = "0xAEAD2C")]
	public int FixedUpdateCoroutines;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEAD64", Offset = "0xAEAD64")]
	public int LateUpdateCoroutines;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEAD9C", Offset = "0xAEAD9C")]
	public int SlowUpdateCoroutines;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEADD4", Offset = "0xAEADD4")]
	public int RealtimeUpdateCoroutines;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEAE0C", Offset = "0xAEAE0C")]
	public int EditorUpdateCoroutines;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEAE44", Offset = "0xAEAE44")]
	public int EditorSlowUpdateCoroutines;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEAE7C", Offset = "0xAEAE7C")]
	public int EndOfFrameCoroutines;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEAEB4", Offset = "0xAEAEB4")]
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
	public const float WaitForOneFrame = 0f;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAEFC", Offset = "0xAEAEFC")]
	private static Thread <MainThread>k__BackingField;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static object _tmpRef;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static int _tmpInt;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static bool _tmpBool;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static Segment _tmpSegment;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static CoroutineHandle _tmpHandle;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int _currentUpdateFrame;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int _currentLateUpdateFrame;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int _currentSlowUpdateFrame;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int _currentRealtimeUpdateFrame;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int _currentEndOfFrameFrame;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int _nextUpdateProcessSlot;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int _nextLateUpdateProcessSlot;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int _nextFixedUpdateProcessSlot;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int _nextSlowUpdateProcessSlot;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int _nextRealtimeUpdateProcessSlot;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int _nextEditorUpdateProcessSlot;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int _nextEditorSlowUpdateProcessSlot;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int _nextEndOfFrameProcessSlot;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int _nextManualTimeframeProcessSlot;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int _lastUpdateProcessSlot;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int _lastLateUpdateProcessSlot;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int _lastFixedUpdateProcessSlot;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int _lastSlowUpdateProcessSlot;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int _lastRealtimeUpdateProcessSlot;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private int _lastEndOfFrameProcessSlot;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int _lastManualTimeframeProcessSlot;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private float _lastUpdateTime;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float _lastLateUpdateTime;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float _lastFixedUpdateTime;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float _lastSlowUpdateTime;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private float _lastRealtimeUpdateTime;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float _lastEndOfFrameTime;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float _lastManualTimeframeTime;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float _lastSlowUpdateDeltaTime;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float _lastEditorUpdateDeltaTime;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float _lastEditorSlowUpdateDeltaTime;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private float _lastManualTimeframeDeltaTime;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private ushort _framesSinceUpdate;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
	private ushort _expansions;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private byte _instanceID;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDD")]
	private bool _EOFPumpRan;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> Links;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly WaitForEndOfFrame EofWaitObject;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> _waitingTriggers;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly HashSet<CoroutineHandle> _allWaiting;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly Dictionary<CoroutineHandle, ProcessIndex> _handleToIndex;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly Dictionary<ProcessIndex, CoroutineHandle> _indexToHandle;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly Dictionary<CoroutineHandle, string> _processTags;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly Dictionary<string, HashSet<CoroutineHandle>> _taggedProcesses;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly Dictionary<CoroutineHandle, int> _processLayers;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly Dictionary<int, HashSet<CoroutineHandle>> _layeredProcesses;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private IEnumerator<float>[] UpdateProcesses;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private IEnumerator<float>[] LateUpdateProcesses;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private IEnumerator<float>[] FixedUpdateProcesses;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private IEnumerator<float>[] SlowUpdateProcesses;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private IEnumerator<float>[] RealtimeUpdateProcesses;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private IEnumerator<float>[] EditorUpdateProcesses;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private IEnumerator<float>[] EditorSlowUpdateProcesses;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private IEnumerator<float>[] EndOfFrameProcesses;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private IEnumerator<float>[] ManualTimeframeProcesses;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private bool[] UpdatePaused;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private bool[] LateUpdatePaused;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private bool[] FixedUpdatePaused;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private bool[] SlowUpdatePaused;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private bool[] RealtimeUpdatePaused;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private bool[] EditorUpdatePaused;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private bool[] EditorSlowUpdatePaused;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private bool[] EndOfFramePaused;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private bool[] ManualTimeframePaused;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private CoroutineHandle _eofWatcherHandle;

	[Token(Token = "0x400005A")]
	private const ushort FramesUntilMaintenance = 64;

	[Token(Token = "0x400005B")]
	private const int ProcessArrayChunkSize = 64;

	[Token(Token = "0x400005C")]
	private const int InitialBufferSizeLarge = 256;

	[Token(Token = "0x400005D")]
	private const int InitialBufferSizeMedium = 64;

	[Token(Token = "0x400005E")]
	private const int InitialBufferSizeSmall = 8;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static readonly Dictionary<byte, Timing> ActiveInstances;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static Timing _instance;

	[Token(Token = "0x17000001")]
	public static float LocalTime
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1746A08", Offset = "0x1746A08", VA = "0x1746A08")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000002")]
	public static float DeltaTime
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1746A70", Offset = "0x1746A70", VA = "0x1746A70")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000003")]
	public static Thread MainThread
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1746CC8", Offset = "0x1746CC8", VA = "0x1746CC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB63C", Offset = "0xAEB63C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1746D2C", Offset = "0x1746D2C", VA = "0x1746D2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB64C", Offset = "0xAEB64C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public static Timing Instance
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x174661C", Offset = "0x174661C", VA = "0x174661C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1746D98", Offset = "0x1746D98", VA = "0x1746D98")]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public static event Action OnPreExecute
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1746AD8", Offset = "0x1746AD8", VA = "0x1746AD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB61C", Offset = "0xAEB61C")]
		add
		{
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1746BD0", Offset = "0x1746BD0", VA = "0x1746BD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB62C", Offset = "0xAEB62C")]
		remove
		{
		}
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1746E04", Offset = "0x1746E04", VA = "0x1746E04")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1747134", Offset = "0x1747134", VA = "0x1747134")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x174725C", Offset = "0x174725C", VA = "0x174725C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x17475A4", Offset = "0x17475A4", VA = "0x17475A4")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x174A48C", Offset = "0x174A48C", VA = "0x174A48C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x174A974", Offset = "0x174A974", VA = "0x174A974")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x17487E0", Offset = "0x17487E0", VA = "0x17487E0")]
	public void TriggerManualTimeframeUpdate()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x17472D0", Offset = "0x17472D0", VA = "0x17472D0")]
	private bool OnEditorStart()
	{
		return default(bool);
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x17472D8", Offset = "0x17472D8", VA = "0x17472D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB65C", Offset = "0xAEB65C")]
	private IEnumerator<float> _EOFPumpWatcher()
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x174AE5C", Offset = "0x174AE5C", VA = "0x174AE5C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB6BC", Offset = "0xAEB6BC")]
	private IEnumerator _EOFPump()
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1748D08", Offset = "0x1748D08", VA = "0x1748D08")]
	private void RemoveUnused()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x174B448", Offset = "0x174B448", VA = "0x174B448")]
	private void EditorRemoveUnused()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x174BC40", Offset = "0x174BC40", VA = "0x174BC40")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x174DA7C", Offset = "0x174DA7C", VA = "0x174DA7C")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x174DBE8", Offset = "0x174DBE8", VA = "0x174DBE8")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x174DCD8", Offset = "0x174DCD8", VA = "0x174DCD8")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x174DD98", Offset = "0x174DD98", VA = "0x174DD98")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x174DF08", Offset = "0x174DF08", VA = "0x174DF08")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x174DFFC", Offset = "0x174DFFC", VA = "0x174DFFC")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x174E0BC", Offset = "0x174E0BC", VA = "0x174E0BC")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x174E22C", Offset = "0x174E22C", VA = "0x174E22C")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x174E320", Offset = "0x174E320", VA = "0x174E320")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x174E3EC", Offset = "0x174E3EC", VA = "0x174E3EC")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x174E568", Offset = "0x174E568", VA = "0x174E568")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x174E668", Offset = "0x174E668", VA = "0x174E668")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x174E6D0", Offset = "0x174E6D0", VA = "0x174E6D0")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x174E7E0", Offset = "0x174E7E0", VA = "0x174E7E0")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x174E890", Offset = "0x174E890", VA = "0x174E890")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x174E8FC", Offset = "0x174E8FC", VA = "0x174E8FC")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x174EA18", Offset = "0x174EA18", VA = "0x174EA18")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x174EAD4", Offset = "0x174EAD4", VA = "0x174EAD4")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x174EB40", Offset = "0x174EB40", VA = "0x174EB40")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x174EC5C", Offset = "0x174EC5C", VA = "0x174EC5C")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x174ED18", Offset = "0x174ED18", VA = "0x174ED18")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x174ED90", Offset = "0x174ED90", VA = "0x174ED90")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x174EEB0", Offset = "0x174EEB0", VA = "0x174EEB0")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x174EF70", Offset = "0x174EF70", VA = "0x174EF70")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x174F4A0", Offset = "0x174F4A0", VA = "0x174F4A0")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x174F5A8", Offset = "0x174F5A8", VA = "0x174F5A8")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x175015C", Offset = "0x175015C", VA = "0x175015C")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1750524", Offset = "0x1750524", VA = "0x1750524")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1750644", Offset = "0x1750644", VA = "0x1750644")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1750CD4", Offset = "0x1750CD4", VA = "0x1750CD4")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1750E7C", Offset = "0x1750E7C", VA = "0x1750E7C")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1750F98", Offset = "0x1750F98", VA = "0x1750F98")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x17512B8", Offset = "0x17512B8", VA = "0x17512B8")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1751594", Offset = "0x1751594", VA = "0x1751594")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x17516C0", Offset = "0x17516C0", VA = "0x17516C0")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1751C64", Offset = "0x1751C64", VA = "0x1751C64")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1751E04", Offset = "0x1751E04", VA = "0x1751E04")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1751ECC", Offset = "0x1751ECC", VA = "0x1751ECC")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1747350", Offset = "0x1747350", VA = "0x1747350")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x17526F4", Offset = "0x17526F4", VA = "0x17526F4")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x17527CC", Offset = "0x17527CC", VA = "0x17527CC")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1753050", Offset = "0x1753050", VA = "0x1753050")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1753124", Offset = "0x1753124", VA = "0x1753124")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x17533C8", Offset = "0x17533C8", VA = "0x17533C8")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1753628", Offset = "0x1753628", VA = "0x1753628")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1753714", Offset = "0x1753714", VA = "0x1753714")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x174BCFC", Offset = "0x174BCFC", VA = "0x174BCFC")]
	private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, int? layer, string tag, CoroutineHandle handle, bool prewarm)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1753E40", Offset = "0x1753E40", VA = "0x1753E40")]
	public static int KillCoroutines()
	{
		return default(int);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1753F24", Offset = "0x1753F24", VA = "0x1753F24")]
	public int KillCoroutinesOnInstance()
	{
		return default(int);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1745884", Offset = "0x1745884", VA = "0x1745884")]
	public static int KillCoroutines(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x17485A0", Offset = "0x17485A0", VA = "0x17485A0")]
	public int KillCoroutinesOnInstance(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x17544CC", Offset = "0x17544CC", VA = "0x17544CC")]
	public static int KillCoroutines(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x17545D8", Offset = "0x17545D8", VA = "0x17545D8")]
	public int KillCoroutinesOnInstance(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x174F8BC", Offset = "0x174F8BC", VA = "0x174F8BC")]
	public static int KillCoroutines(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1752164", Offset = "0x1752164", VA = "0x1752164")]
	public int KillCoroutinesOnInstance(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x175042C", Offset = "0x175042C", VA = "0x175042C")]
	public static int KillCoroutines(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1752414", Offset = "0x1752414", VA = "0x1752414")]
	public int KillCoroutinesOnInstance(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x175472C", Offset = "0x175472C", VA = "0x175472C")]
	public static int KillCoroutines(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1754840", Offset = "0x1754840", VA = "0x1754840")]
	public int KillCoroutinesOnInstance(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1750BD4", Offset = "0x1750BD4", VA = "0x1750BD4")]
	public static int KillCoroutines(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1752BFC", Offset = "0x1752BFC", VA = "0x1752BFC")]
	public int KillCoroutinesOnInstance(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1754378", Offset = "0x1754378", VA = "0x1754378")]
	public static Timing GetInstance(byte ID)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1754880", Offset = "0x1754880", VA = "0x1754880")]
	public static float WaitForSeconds(float waitTime)
	{
		return default(float);
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1754908", Offset = "0x1754908", VA = "0x1754908")]
	public float WaitForSecondsOnInstance(float waitTime)
	{
		return default(float);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x17482A8", Offset = "0x17482A8", VA = "0x17482A8")]
	private bool UpdateTimeValues(Segment segment)
	{
		return default(bool);
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x175494C", Offset = "0x175494C", VA = "0x175494C")]
	private float GetSegmentTime(Segment segment)
	{
		return default(float);
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1754A38", Offset = "0x1754A38", VA = "0x1754A38")]
	public static int PauseCoroutines()
	{
		return default(int);
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1754B1C", Offset = "0x1754B1C", VA = "0x1754B1C")]
	public int PauseCoroutinesOnInstance()
	{
		return default(int);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1745BB4", Offset = "0x1745BB4", VA = "0x1745BB4")]
	public static int PauseCoroutines(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1755EB0", Offset = "0x1755EB0", VA = "0x1755EB0")]
	public int PauseCoroutinesOnInstance(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1756EB8", Offset = "0x1756EB8", VA = "0x1756EB8")]
	public static int PauseCoroutines(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1756FB0", Offset = "0x1756FB0", VA = "0x1756FB0")]
	public int PauseCoroutinesOnInstance(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x175739C", Offset = "0x175739C", VA = "0x175739C")]
	public static int PauseCoroutines(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x175705C", Offset = "0x175705C", VA = "0x175705C")]
	public int PauseCoroutinesOnInstance(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1757494", Offset = "0x1757494", VA = "0x1757494")]
	public static int PauseCoroutines(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x175758C", Offset = "0x175758C", VA = "0x175758C")]
	public int PauseCoroutinesOnInstance(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x17578D0", Offset = "0x17578D0", VA = "0x17578D0")]
	public static int PauseCoroutines(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1757E1C", Offset = "0x1757E1C", VA = "0x1757E1C")]
	public int PauseCoroutinesOnInstance(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1757ED0", Offset = "0x1757ED0", VA = "0x1757ED0")]
	public static int PauseCoroutines(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x17579E4", Offset = "0x17579E4", VA = "0x17579E4")]
	public int PauseCoroutinesOnInstance(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1757FD0", Offset = "0x1757FD0", VA = "0x1757FD0")]
	public static int ResumeCoroutines()
	{
		return default(int);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x17580B4", Offset = "0x17580B4", VA = "0x17580B4")]
	public int ResumeCoroutinesOnInstance()
	{
		return default(int);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1745C90", Offset = "0x1745C90", VA = "0x1745C90")]
	public static int ResumeCoroutines(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x17589EC", Offset = "0x17589EC", VA = "0x17589EC")]
	public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1758CD8", Offset = "0x1758CD8", VA = "0x1758CD8")]
	public static int ResumeCoroutines(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x175914C", Offset = "0x175914C", VA = "0x175914C")]
	public int ResumeCoroutinesOnInstance(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x17591F8", Offset = "0x17591F8", VA = "0x17591F8")]
	public static int ResumeCoroutines(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1758DE4", Offset = "0x1758DE4", VA = "0x1758DE4")]
	public int ResumeCoroutinesOnInstance(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x17592F0", Offset = "0x17592F0", VA = "0x17592F0")]
	public static int ResumeCoroutines(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x17593E8", Offset = "0x17593E8", VA = "0x17593E8")]
	public int ResumeCoroutinesOnInstance(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1759754", Offset = "0x1759754", VA = "0x1759754")]
	public static int ResumeCoroutines(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1759CA8", Offset = "0x1759CA8", VA = "0x1759CA8")]
	public int ResumeCoroutinesOnInstance(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1759D5C", Offset = "0x1759D5C", VA = "0x1759D5C")]
	public static int ResumeCoroutines(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1759868", Offset = "0x1759868", VA = "0x1759868")]
	public int ResumeCoroutinesOnInstance(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1744938", Offset = "0x1744938", VA = "0x1744938")]
	public static string GetTag(CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1744CE8", Offset = "0x1744CE8", VA = "0x1744CE8")]
	public static int? GetLayer(CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1745278", Offset = "0x1745278", VA = "0x1745278")]
	public static Segment GetSegment(CoroutineHandle handle)
	{
		return default(Segment);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1744AFC", Offset = "0x1744AFC", VA = "0x1744AFC")]
	public static bool SetTag(CoroutineHandle handle, string newTag, bool overwriteExisting = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x174508C", Offset = "0x174508C", VA = "0x174508C")]
	public static bool SetLayer(CoroutineHandle handle, int newLayer, bool overwriteExisting = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1745404", Offset = "0x1745404", VA = "0x1745404")]
	public static bool SetSegment(CoroutineHandle handle, Segment newSegment)
	{
		return default(bool);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x175A26C", Offset = "0x175A26C", VA = "0x175A26C")]
	public static bool RemoveTag(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1744F54", Offset = "0x1744F54", VA = "0x1744F54")]
	public static bool RemoveLayer(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x17456D4", Offset = "0x17456D4", VA = "0x17456D4")]
	public static bool IsRunning(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x17459C4", Offset = "0x17459C4", VA = "0x17459C4")]
	public static bool IsPaused(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1753B48", Offset = "0x1753B48", VA = "0x1753B48")]
	private void AddTagOnInstance(string tag, CoroutineHandle handle)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1753CC4", Offset = "0x1753CC4", VA = "0x1753CC4")]
	private void AddLayerOnInstance(int layer, CoroutineHandle handle)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1759E5C", Offset = "0x1759E5C", VA = "0x1759E5C")]
	private void RemoveTagOnInstance(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1759FF4", Offset = "0x1759FF4", VA = "0x1759FF4")]
	private void RemoveLayerOnInstance(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x174B18C", Offset = "0x174B18C", VA = "0x174B18C")]
	private void RemoveGraffiti(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x175A18C", Offset = "0x175A18C", VA = "0x175A18C")]
	private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x174AED4", Offset = "0x174AED4", VA = "0x174AED4")]
	private bool CoindexIsNull(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x175A3A0", Offset = "0x175A3A0", VA = "0x175A3A0")]
	private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x175445C", Offset = "0x175445C", VA = "0x175445C")]
	private bool Nullify(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1754610", Offset = "0x1754610", VA = "0x1754610")]
	private bool Nullify(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x175616C", Offset = "0x175616C", VA = "0x175616C")]
	private bool SetPause(ProcessIndex coindex, bool newPausedState = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x175A468", Offset = "0x175A468", VA = "0x175A468")]
	private IEnumerator<float> CreatePause(ProcessIndex coindex, IEnumerator<float> coptr, bool newPausedState = true)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x175A2D4", Offset = "0x175A2D4", VA = "0x175A2D4")]
	private bool CoindexIsPaused(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x175B154", Offset = "0x175B154", VA = "0x175B154")]
	private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x175B264", Offset = "0x175B264", VA = "0x175B264")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine)
	{
		return default(float);
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x175B5B4", Offset = "0x175B5B4", VA = "0x175B5B4")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x175B630", Offset = "0x175B630", VA = "0x175B630")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer)
	{
		return default(float);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x175B6AC", Offset = "0x175B6AC", VA = "0x175B6AC")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x175B730", Offset = "0x175B730", VA = "0x175B730")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment)
	{
		return default(float);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x175B7AC", Offset = "0x175B7AC", VA = "0x175B7AC")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x175B830", Offset = "0x175B830", VA = "0x175B830")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer)
	{
		return default(float);
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x175B8B4", Offset = "0x175B8B4", VA = "0x175B8B4")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x175B948", Offset = "0x175B948", VA = "0x175B948")]
	public static float WaitUntilDone(CoroutineHandle otherCoroutine)
	{
		return default(float);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x175B2D0", Offset = "0x175B2D0", VA = "0x175B2D0")]
	public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
	{
		return default(float);
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x175BA48", Offset = "0x175BA48", VA = "0x175BA48")]
	private IEnumerator<float> WaitUntilDoneWrapper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x174F114", Offset = "0x174F114", VA = "0x174F114")]
	public static void WaitForOtherHandles(CoroutineHandle handle, CoroutineHandle otherHandle, bool warnOnIssue = true)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x174F9B4", Offset = "0x174F9B4", VA = "0x174F9B4")]
	public static void WaitForOtherHandles(CoroutineHandle handle, IEnumerable<CoroutineHandle> otherHandles, bool warnOnIssue = true)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x175B9AC", Offset = "0x175B9AC", VA = "0x175B9AC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB71C", Offset = "0xAEB71C")]
	private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x174AFA4", Offset = "0x174AFA4", VA = "0x174AFA4")]
	private void CloseWaitingProcess(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x175BBE4", Offset = "0x175BBE4", VA = "0x175BBE4")]
	private bool HandleIsInWaitingList(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x175BCDC", Offset = "0x175BCDC", VA = "0x175BCDC")]
	private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x175BD58", Offset = "0x175BD58", VA = "0x175BD58")]
	public static float WaitUntilDone(WWW wwwObject)
	{
		return default(float);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x175BE60", Offset = "0x175BE60", VA = "0x175BE60")]
	private static IEnumerator<float> WaitUntilDoneWwwHelper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x175BF18", Offset = "0x175BF18", VA = "0x175BF18")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB77C", Offset = "0xAEB77C")]
	private static IEnumerator<float> _StartWhenDone(WWW wwwObject, IEnumerator<float> pausedProc)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x175BFAC", Offset = "0x175BFAC", VA = "0x175BFAC")]
	public static float WaitUntilDone(AsyncOperation operation)
	{
		return default(float);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x175C0A4", Offset = "0x175C0A4", VA = "0x175C0A4")]
	private static IEnumerator<float> WaitUntilDoneAscOpHelper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x175C15C", Offset = "0x175C15C", VA = "0x175C15C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB7DC", Offset = "0xAEB7DC")]
	private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x175C1F0", Offset = "0x175C1F0", VA = "0x175C1F0")]
	public static float WaitUntilDone(CustomYieldInstruction operation)
	{
		return default(float);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x175C2EC", Offset = "0x175C2EC", VA = "0x175C2EC")]
	private static IEnumerator<float> WaitUntilDoneCustYieldHelper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x175C3A4", Offset = "0x175C3A4", VA = "0x175C3A4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB83C", Offset = "0xAEB83C")]
	private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x175C438", Offset = "0x175C438", VA = "0x175C438")]
	public static float WaitUntilTrue(Func<bool> evaluatorFunc)
	{
		return default(float);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x175C544", Offset = "0x175C544", VA = "0x175C544")]
	private static IEnumerator<float> WaitUntilTrueHelper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x175C684", Offset = "0x175C684", VA = "0x175C684")]
	public static float WaitUntilFalse(Func<bool> evaluatorFunc)
	{
		return default(float);
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x175C790", Offset = "0x175C790", VA = "0x175C790")]
	private static IEnumerator<float> WaitUntilFalseHelper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x175C5E4", Offset = "0x175C5E4", VA = "0x175C5E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB89C", Offset = "0xAEB89C")]
	private static IEnumerator<float> _StartWhenDone(Func<bool> evaluatorFunc, bool continueOn, IEnumerator<float> pausedProc)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1755E0C", Offset = "0x1755E0C", VA = "0x1755E0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB8FC", Offset = "0xAEB8FC")]
	private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float waitTime)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x175C830", Offset = "0x175C830", VA = "0x175C830")]
	public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x175CA18", Offset = "0x175CA18", VA = "0x175CA18")]
	public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x175CBA0", Offset = "0x175CBA0", VA = "0x175CBA0")]
	public static int LinkCoroutines(CoroutineHandle master, CoroutineHandle slave)
	{
		return default(int);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x175CE44", Offset = "0x175CE44", VA = "0x175CE44")]
	public static int UnlinkCoroutines(CoroutineHandle master, CoroutineHandle slave, bool twoWay = false)
	{
		return default(int);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x175D1DC", Offset = "0x175D1DC", VA = "0x175D1DC")]
	public static float GetMyHandle(Action<CoroutineHandle> reciever)
	{
		return default(float);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x175D2C0", Offset = "0x175D2C0", VA = "0x175D2C0")]
	private static IEnumerator<float> GetHandleHelper(IEnumerator<float> input, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x175D38C", Offset = "0x175D38C", VA = "0x175D38C")]
	public static float SwitchCoroutine(Segment newSegment)
	{
		return default(float);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x175D468", Offset = "0x175D468", VA = "0x175D468")]
	private static IEnumerator<float> SwitchCoroutineRepS(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x175D608", Offset = "0x175D608", VA = "0x175D608")]
	public static float SwitchCoroutine(Segment newSegment, string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x175D700", Offset = "0x175D700", VA = "0x175D700")]
	private static IEnumerator<float> SwitchCoroutineRepST(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x175D89C", Offset = "0x175D89C", VA = "0x175D89C")]
	public static float SwitchCoroutine(Segment newSegment, int newLayer)
	{
		return default(float);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x175D98C", Offset = "0x175D98C", VA = "0x175D98C")]
	private static IEnumerator<float> SwitchCoroutineRepSL(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x175DAD0", Offset = "0x175DAD0", VA = "0x175DAD0")]
	public static float SwitchCoroutine(Segment newSegment, int newLayer, string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x175DBD4", Offset = "0x175DBD4", VA = "0x175DBD4")]
	private static IEnumerator<float> SwitchCoroutineRepSLT(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x175DCEC", Offset = "0x175DCEC", VA = "0x175DCEC")]
	public static float SwitchCoroutine(string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x175DDD0", Offset = "0x175DDD0", VA = "0x175DDD0")]
	private static IEnumerator<float> SwitchCoroutineRepT(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x175DEE8", Offset = "0x175DEE8", VA = "0x175DEE8")]
	public static float SwitchCoroutine(int newLayer)
	{
		return default(float);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x175DFC4", Offset = "0x175DFC4", VA = "0x175DFC4")]
	private static IEnumerator<float> SwitchCoroutineRepL(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x175E060", Offset = "0x175E060", VA = "0x175E060")]
	public static float SwitchCoroutine(int newLayer, string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x175E158", Offset = "0x175E158", VA = "0x175E158")]
	private static IEnumerator<float> SwitchCoroutineRepLT(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x175E294", Offset = "0x175E294", VA = "0x175E294")]
	public static CoroutineHandle CallDelayed(float delay, Action action)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x175E3E4", Offset = "0x175E3E4", VA = "0x175E3E4")]
	public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x175E424", Offset = "0x175E424", VA = "0x175E424")]
	public static CoroutineHandle CallDelayed(float delay, Action action, GameObject gameObject)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x175E4CC", Offset = "0x175E4CC", VA = "0x175E4CC")]
	public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject gameObject)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x175E32C", Offset = "0x175E32C", VA = "0x175E32C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB95C", Offset = "0xAEB95C")]
	private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x175E510", Offset = "0x175E510", VA = "0x175E510")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x175E784", Offset = "0x175E784", VA = "0x175E784")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x175E81C", Offset = "0x175E81C", VA = "0x175E81C")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x175E928", Offset = "0x175E928", VA = "0x175E928")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x175EA2C", Offset = "0x175EA2C", VA = "0x175EA2C")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x175EB2C", Offset = "0x175EB2C", VA = "0x175EB2C")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x175EC30", Offset = "0x175EC30", VA = "0x175EC30")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x175ED50", Offset = "0x175ED50", VA = "0x175ED50")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x175EE60", Offset = "0x175EE60", VA = "0x175EE60")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x175EF5C", Offset = "0x175EF5C", VA = "0x175EF5C")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x175F048", Offset = "0x175F048", VA = "0x175F048")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x175F150", Offset = "0x175F150", VA = "0x175F150")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x175F250", Offset = "0x175F250", VA = "0x175F250")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x175F358", Offset = "0x175F358", VA = "0x175F358")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x175F458", Offset = "0x175F458", VA = "0x175F458")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x175F574", Offset = "0x175F574", VA = "0x175F574")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x175E6BC", Offset = "0x175E6BC", VA = "0x175E6BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB9BC", Offset = "0xAEB9BC")]
	private IEnumerator<float> _WatchCall(float timeframe, CoroutineHandle handle, GameObject gObject, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x175E604", Offset = "0x175E604", VA = "0x175E604")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEBA1C", Offset = "0xAEBA1C")]
	private IEnumerator<float> _CallContinuously(float period, Action action, GameObject gObject)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E9")]
	public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000EA")]
	public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000EB")]
	public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000EC")]
	public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000ED")]
	public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000EE")]
	public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000EF")]
	public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F0")]
	public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F1")]
	public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F2")]
	public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F3")]
	public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F4")]
	public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F5")]
	public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F6")]
	public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F7")]
	public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEBA7C", Offset = "0xAEBA7C")]
	private IEnumerator<float> _WatchCall<T>(T reference, float timeframe, CoroutineHandle handle, GameObject gObject, Action<T> onDone)
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEBADC", Offset = "0xAEBADC")]
	private IEnumerator<float> _CallContinuously<T>(T reference, float period, Action<T> action, GameObject gObject)
	{
		return null;
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x175F680", Offset = "0x175F680", VA = "0x175F680")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBB3C", Offset = "0xAEBB3C")]
	public new Coroutine StartCoroutine(IEnumerator routine)
	{
		return null;
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x175F688", Offset = "0x175F688", VA = "0x175F688")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBB78", Offset = "0xAEBB78")]
	public new Coroutine StartCoroutine(string methodName, object value)
	{
		return null;
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x175F690", Offset = "0x175F690", VA = "0x175F690")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBBB4", Offset = "0xAEBBB4")]
	public new Coroutine StartCoroutine(string methodName)
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x175F698", Offset = "0x175F698", VA = "0x175F698")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBBF0", Offset = "0xAEBBF0")]
	public new Coroutine StartCoroutine_Auto(IEnumerator routine)
	{
		return null;
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x175F6A0", Offset = "0x175F6A0", VA = "0x175F6A0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBC2C", Offset = "0xAEBC2C")]
	public new void StopCoroutine(string methodName)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x175F6A4", Offset = "0x175F6A4", VA = "0x175F6A4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBC68", Offset = "0xAEBC68")]
	public new void StopCoroutine(IEnumerator routine)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x175F6A8", Offset = "0x175F6A8", VA = "0x175F6A8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBCA4", Offset = "0xAEBCA4")]
	public new void StopCoroutine(Coroutine routine)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x175F6AC", Offset = "0x175F6AC", VA = "0x175F6AC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBCE0", Offset = "0xAEBCE0")]
	public new void StopAllCoroutines()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x175F6B0", Offset = "0x175F6B0", VA = "0x175F6B0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBD1C", Offset = "0xAEBD1C")]
	public new static void Destroy(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x175F6B4", Offset = "0x175F6B4", VA = "0x175F6B4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBD58", Offset = "0xAEBD58")]
	public new static void Destroy(UnityEngine.Object obj, float f)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x175F6B8", Offset = "0x175F6B8", VA = "0x175F6B8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBD94", Offset = "0xAEBD94")]
	public static void DestroyObject(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x175F6BC", Offset = "0x175F6BC", VA = "0x175F6BC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBDD0", Offset = "0xAEBDD0")]
	public static void DestroyObject(UnityEngine.Object obj, float f)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x175F6C0", Offset = "0x175F6C0", VA = "0x175F6C0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBE0C", Offset = "0xAEBE0C")]
	public new static void DestroyImmediate(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x175F6C4", Offset = "0x175F6C4", VA = "0x175F6C4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBE48", Offset = "0xAEBE48")]
	public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x175F6C8", Offset = "0x175F6C8", VA = "0x175F6C8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBE84", Offset = "0xAEBE84")]
	public new static void Instantiate(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x175F6CC", Offset = "0x175F6CC", VA = "0x175F6CC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBEC0", Offset = "0xAEBEC0")]
	public new static void Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation)
	{
	}

	[Token(Token = "0x600010A")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBEFC", Offset = "0xAEBEFC")]
	public new static void Instantiate<T>(T original) where T : UnityEngine.Object
	{
	}

	[Token(Token = "0x600010B")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBF38", Offset = "0xAEBF38")]
	public new static T FindObjectOfType<T>() where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x175F6D0", Offset = "0x175F6D0", VA = "0x175F6D0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBF74", Offset = "0xAEBF74")]
	public new static UnityEngine.Object FindObjectOfType(Type t)
	{
		return null;
	}

	[Token(Token = "0x600010D")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBFB0", Offset = "0xAEBFB0")]
	public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x175F6D8", Offset = "0x175F6D8", VA = "0x175F6D8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEBFEC", Offset = "0xAEBFEC")]
	public new static UnityEngine.Object[] FindObjectsOfType(Type t)
	{
		return null;
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x175F6E0", Offset = "0x175F6E0", VA = "0x175F6E0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAEC028", Offset = "0xAEC028")]
	public new static void print(object message)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x175F6E4", Offset = "0x175F6E4", VA = "0x175F6E4")]
	public Timing()
	{
	}
}
[Token(Token = "0x2000004")]
public enum Segment
{
	[Token(Token = "0x4000062")]
	Invalid = -1,
	[Token(Token = "0x4000063")]
	Update,
	[Token(Token = "0x4000064")]
	FixedUpdate,
	[Token(Token = "0x4000065")]
	LateUpdate,
	[Token(Token = "0x4000066")]
	SlowUpdate,
	[Token(Token = "0x4000067")]
	RealtimeUpdate,
	[Token(Token = "0x4000068")]
	EditorUpdate,
	[Token(Token = "0x4000069")]
	EditorSlowUpdate,
	[Token(Token = "0x400006A")]
	EndOfFrame,
	[Token(Token = "0x400006B")]
	ManualTimeframe
}
[Token(Token = "0x2000005")]
public enum DebugInfoType
{
	[Token(Token = "0x400006D")]
	None,
	[Token(Token = "0x400006E")]
	SeperateCoroutines,
	[Token(Token = "0x400006F")]
	SeperateTags
}
[Token(Token = "0x2000006")]
public enum SingletonBehavior
{
	[Token(Token = "0x4000071")]
	Abort,
	[Token(Token = "0x4000072")]
	Overwrite,
	[Token(Token = "0x4000073")]
	Wait
}
[Token(Token = "0x2000007")]
public struct CoroutineHandle : IEquatable<CoroutineHandle>
{
	[Token(Token = "0x4000074")]
	private const byte ReservedSpace = 15;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int[] NextIndex;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly int _id;

	[Token(Token = "0x17000005")]
	public byte Key
	{
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x174472C", Offset = "0x174472C", VA = "0x174472C")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x17000006")]
	public string Tag
	{
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x17448D4", Offset = "0x17448D4", VA = "0x17448D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1744A84", Offset = "0x1744A84", VA = "0x1744A84")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public int? Layer
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1744C84", Offset = "0x1744C84", VA = "0x1744C84")]
		get
		{
			return null;
		}
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1744E64", Offset = "0x1744E64", VA = "0x1744E64")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public Segment Segment
	{
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1745214", Offset = "0x1745214", VA = "0x1745214")]
		get
		{
			return default(Segment);
		}
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1745390", Offset = "0x1745390", VA = "0x1745390")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public bool IsRunning
	{
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1745670", Offset = "0x1745670", VA = "0x1745670")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1745800", Offset = "0x1745800", VA = "0x1745800")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public bool IsPaused
	{
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1745960", Offset = "0x1745960", VA = "0x1745960")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1745B1C", Offset = "0x1745B1C", VA = "0x1745B1C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public bool IsValid
	{
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1745D6C", Offset = "0x1745D6C", VA = "0x1745D6C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x1744738", Offset = "0x1744738", VA = "0x1744738")]
	public CoroutineHandle(byte ind)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x1744820", Offset = "0x1744820", VA = "0x1744820", Slot = "4")]
	public bool Equals(CoroutineHandle other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x1744830", Offset = "0x1744830", VA = "0x1744830", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x17448B4", Offset = "0x17448B4", VA = "0x17448B4")]
	public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x17448C0", Offset = "0x17448C0", VA = "0x17448C0")]
	public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x17448CC", Offset = "0x17448CC", VA = "0x17448CC", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
