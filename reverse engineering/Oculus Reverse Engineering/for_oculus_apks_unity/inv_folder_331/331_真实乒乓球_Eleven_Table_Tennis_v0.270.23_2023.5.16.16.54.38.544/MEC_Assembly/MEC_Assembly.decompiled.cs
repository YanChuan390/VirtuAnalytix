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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EDFC", Offset = "0xE8EDFC")]
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
			[Address(RVA = "0x3C9D2C8", Offset = "0x3C9D2C8", VA = "0x3C9D2C8", Slot = "4")]
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
			[Address(RVA = "0x3C9D310", Offset = "0x3C9D310", VA = "0x3C9D310", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x3C9D0D8", Offset = "0x3C9D0D8", VA = "0x3C9D0D8")]
		[DebuggerHidden]
		public <Delay>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x3C9D104", Offset = "0x3C9D104", VA = "0x3C9D104", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x3C9D108", Offset = "0x3C9D108", VA = "0x3C9D108", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x3C9D2D0", Offset = "0x3C9D2D0", VA = "0x3C9D2D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EE0C", Offset = "0xE8EE0C")]
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
			[Address(RVA = "0x3C9D53C", Offset = "0x3C9D53C", VA = "0x3C9D53C", Slot = "4")]
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
			[Address(RVA = "0x3C9D584", Offset = "0x3C9D584", VA = "0x3C9D584", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x3C9D370", Offset = "0x3C9D370", VA = "0x3C9D370")]
		[DebuggerHidden]
		public <Delay>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x3C9D39C", Offset = "0x3C9D39C", VA = "0x3C9D39C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x3C9D3A0", Offset = "0x3C9D3A0", VA = "0x3C9D3A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x3C9D544", Offset = "0x3C9D544", VA = "0x3C9D544", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EE1C", Offset = "0xE8EE1C")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EE2C", Offset = "0xE8EE2C")]
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
			[Address(RVA = "0x3C9D798", Offset = "0x3C9D798", VA = "0x3C9D798", Slot = "4")]
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
			[Address(RVA = "0x3C9D7E0", Offset = "0x3C9D7E0", VA = "0x3C9D7E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x3C9D5E4", Offset = "0x3C9D5E4", VA = "0x3C9D5E4")]
		[DebuggerHidden]
		public <DelayFrames>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x3C9D610", Offset = "0x3C9D610", VA = "0x3C9D610", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x3C9D614", Offset = "0x3C9D614", VA = "0x3C9D614", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x3C9D7A0", Offset = "0x3C9D7A0", VA = "0x3C9D7A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EE3C", Offset = "0xE8EE3C")]
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
			[Address(RVA = "0x3C9C9DC", Offset = "0x3C9C9DC", VA = "0x3C9C9DC", Slot = "4")]
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
			[Address(RVA = "0x3C9CA24", Offset = "0x3C9CA24", VA = "0x3C9CA24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x3C9C770", Offset = "0x3C9C770", VA = "0x3C9C770")]
		[DebuggerHidden]
		public <CancelWith>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x3C9C79C", Offset = "0x3C9C79C", VA = "0x3C9C79C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x3C9C7A0", Offset = "0x3C9C7A0", VA = "0x3C9C7A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x3C9C9E4", Offset = "0x3C9C9E4", VA = "0x3C9C9E4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EE4C", Offset = "0xE8EE4C")]
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
			[Address(RVA = "0x3C9CD30", Offset = "0x3C9CD30", VA = "0x3C9CD30", Slot = "4")]
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
			[Address(RVA = "0x3C9CD78", Offset = "0x3C9CD78", VA = "0x3C9CD78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x3C9CA84", Offset = "0x3C9CA84", VA = "0x3C9CA84")]
		[DebuggerHidden]
		public <CancelWith>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x3C9CAB0", Offset = "0x3C9CAB0", VA = "0x3C9CAB0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x3C9CAB4", Offset = "0x3C9CAB4", VA = "0x3C9CAB4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x3C9CD38", Offset = "0x3C9CD38", VA = "0x3C9CD38", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EE5C", Offset = "0xE8EE5C")]
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
			[Address(RVA = "0x3C9D030", Offset = "0x3C9D030", VA = "0x3C9D030", Slot = "4")]
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
			[Address(RVA = "0x3C9D078", Offset = "0x3C9D078", VA = "0x3C9D078", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x3C9CDD8", Offset = "0x3C9CDD8", VA = "0x3C9CDD8")]
		[DebuggerHidden]
		public <CancelWith>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x3C9CE04", Offset = "0x3C9CE04", VA = "0x3C9CE04", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x3C9CE08", Offset = "0x3C9CE08", VA = "0x3C9CE08", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x3C9D038", Offset = "0x3C9D038", VA = "0x3C9D038", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EE6C", Offset = "0xE8EE6C")]
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
			[Address(RVA = "0x3C9DD2C", Offset = "0x3C9DD2C", VA = "0x3C9DD2C", Slot = "4")]
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
			[Address(RVA = "0x3C9DD74", Offset = "0x3C9DD74", VA = "0x3C9DD74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x3C9DAB8", Offset = "0x3C9DAB8", VA = "0x3C9DAB8")]
		[DebuggerHidden]
		public <PauseWith>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x3C9DAE4", Offset = "0x3C9DAE4", VA = "0x3C9DAE4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x3C9DAE8", Offset = "0x3C9DAE8", VA = "0x3C9DAE8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x3C9DD34", Offset = "0x3C9DD34", VA = "0x3C9DD34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EE7C", Offset = "0xE8EE7C")]
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
			[Address(RVA = "0x3C9E08C", Offset = "0x3C9E08C", VA = "0x3C9E08C", Slot = "4")]
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
			[Address(RVA = "0x3C9E0D4", Offset = "0x3C9E0D4", VA = "0x3C9E0D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x3C9DDD4", Offset = "0x3C9DDD4", VA = "0x3C9DDD4")]
		[DebuggerHidden]
		public <PauseWith>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x3C9DE00", Offset = "0x3C9DE00", VA = "0x3C9DE00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x3C9DE04", Offset = "0x3C9DE04", VA = "0x3C9DE04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x3C9E094", Offset = "0x3C9E094", VA = "0x3C9E094", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EE8C", Offset = "0xE8EE8C")]
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
			[Address(RVA = "0x3C9E38C", Offset = "0x3C9E38C", VA = "0x3C9E38C", Slot = "4")]
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
			[Address(RVA = "0x3C9E3D4", Offset = "0x3C9E3D4", VA = "0x3C9E3D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x3C9E134", Offset = "0x3C9E134", VA = "0x3C9E134")]
		[DebuggerHidden]
		public <PauseWith>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x3C9E160", Offset = "0x3C9E160", VA = "0x3C9E160", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x3C9E164", Offset = "0x3C9E164", VA = "0x3C9E164", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x3C9E394", Offset = "0x3C9E394", VA = "0x3C9E394", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EE9C", Offset = "0xE8EE9C")]
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
			[Address(RVA = "0x3C9C488", Offset = "0x3C9C488", VA = "0x3C9C488", Slot = "4")]
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
			[Address(RVA = "0x3C9C4D0", Offset = "0x3C9C4D0", VA = "0x3C9C4D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x3C9C1E0", Offset = "0x3C9C1E0", VA = "0x3C9C1E0")]
		[DebuggerHidden]
		public <Append>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x3C9C20C", Offset = "0x3C9C20C", VA = "0x3C9C20C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x3C9C210", Offset = "0x3C9C210", VA = "0x3C9C210", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x3C9C490", Offset = "0x3C9C490", VA = "0x3C9C490", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EEAC", Offset = "0xE8EEAC")]
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
			[Address(RVA = "0x3C9C6C8", Offset = "0x3C9C6C8", VA = "0x3C9C6C8", Slot = "4")]
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
			[Address(RVA = "0x3C9C710", Offset = "0x3C9C710", VA = "0x3C9C710", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x3C9C530", Offset = "0x3C9C530", VA = "0x3C9C530")]
		[DebuggerHidden]
		public <Append>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x3C9C55C", Offset = "0x3C9C55C", VA = "0x3C9C55C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x3C9C560", Offset = "0x3C9C560", VA = "0x3C9C560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x3C9C6D0", Offset = "0x3C9C6D0", VA = "0x3C9C6D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EEBC", Offset = "0xE8EEBC")]
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
			[Address(RVA = "0x3C9E6F0", Offset = "0x3C9E6F0", VA = "0x3C9E6F0", Slot = "4")]
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
			[Address(RVA = "0x3C9E738", Offset = "0x3C9E738", VA = "0x3C9E738", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x3C9E434", Offset = "0x3C9E434", VA = "0x3C9E434")]
		[DebuggerHidden]
		public <Prepend>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x3C9E460", Offset = "0x3C9E460", VA = "0x3C9E460", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x3C9E464", Offset = "0x3C9E464", VA = "0x3C9E464", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x3C9E6F8", Offset = "0x3C9E6F8", VA = "0x3C9E6F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EECC", Offset = "0xE8EECC")]
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
			[Address(RVA = "0x3C9E940", Offset = "0x3C9E940", VA = "0x3C9E940", Slot = "4")]
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
			[Address(RVA = "0x3C9E988", Offset = "0x3C9E988", VA = "0x3C9E988", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x3C9E798", Offset = "0x3C9E798", VA = "0x3C9E798")]
		[DebuggerHidden]
		public <Prepend>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x3C9E7C4", Offset = "0x3C9E7C4", VA = "0x3C9E7C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x3C9E7C8", Offset = "0x3C9E7C8", VA = "0x3C9E7C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x3C9E948", Offset = "0x3C9E948", VA = "0x3C9E948", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EEDC", Offset = "0xE8EEDC")]
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
			[Address(RVA = "0x3C9F058", Offset = "0x3C9F058", VA = "0x3C9F058", Slot = "4")]
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
			[Address(RVA = "0x3C9F0A0", Offset = "0x3C9F0A0", VA = "0x3C9F0A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x3C9E9E8", Offset = "0x3C9E9E8", VA = "0x3C9E9E8")]
		[DebuggerHidden]
		public <Superimpose>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x3C9EA14", Offset = "0x3C9EA14", VA = "0x3C9EA14", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x3C9EA18", Offset = "0x3C9EA18", VA = "0x3C9EA18", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x3C9F060", Offset = "0x3C9F060", VA = "0x3C9F060", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EEEC", Offset = "0xE8EEEC")]
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
			[Address(RVA = "0x3C9DA10", Offset = "0x3C9DA10", VA = "0x3C9DA10", Slot = "4")]
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
			[Address(RVA = "0x3C9DA58", Offset = "0x3C9DA58", VA = "0x3C9DA58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x3C9D840", Offset = "0x3C9D840", VA = "0x3C9D840")]
		[DebuggerHidden]
		public <Hijack>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x3C9D86C", Offset = "0x3C9D86C", VA = "0x3C9D86C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x3C9D870", Offset = "0x3C9D870", VA = "0x3C9D870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x3C9DA18", Offset = "0x3C9DA18", VA = "0x3C9DA18", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2F8D144", Offset = "0x2F8D144", VA = "0x2F8D144")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8F2A4", Offset = "0xE8F2A4")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, float timeToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2F8D1CC", Offset = "0x2F8D1CC", VA = "0x2F8D1CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8F314", Offset = "0xE8F314")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8F384", Offset = "0xE8F384")]
	public static IEnumerator<float> Delay<T>(this IEnumerator<float> coroutine, T data, Func<T, bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2F8D260", Offset = "0x2F8D260", VA = "0x2F8D260")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8F3F4", Offset = "0xE8F3F4")]
	public static IEnumerator<float> DelayFrames(this IEnumerator<float> coroutine, int framesToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2F8D2E8", Offset = "0x2F8D2E8", VA = "0x2F8D2E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8F464", Offset = "0xE8F464")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2F8D37C", Offset = "0x2F8D37C", VA = "0x2F8D37C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8F4D4", Offset = "0xE8F4D4")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2F8D424", Offset = "0x2F8D424", VA = "0x2F8D424")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8F544", Offset = "0xE8F544")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2F8D4B8", Offset = "0x2F8D4B8", VA = "0x2F8D4B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8F5B4", Offset = "0xE8F5B4")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2F8D54C", Offset = "0x2F8D54C", VA = "0x2F8D54C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8F624", Offset = "0xE8F624")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2F8D5F4", Offset = "0x2F8D5F4", VA = "0x2F8D5F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8F694", Offset = "0xE8F694")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2F8D688", Offset = "0x2F8D688", VA = "0x2F8D688")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8F704", Offset = "0xE8F704")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, IEnumerator<float> nextCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2F8D71C", Offset = "0x2F8D71C", VA = "0x2F8D71C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8F774", Offset = "0xE8F774")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2F8D7B0", Offset = "0x2F8D7B0", VA = "0x2F8D7B0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8F7E4", Offset = "0xE8F7E4")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, IEnumerator<float> lastCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2F8D844", Offset = "0x2F8D844", VA = "0x2F8D844")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8F854", Offset = "0xE8F854")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, Action onStart)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2F8D8D8", Offset = "0x2F8D8D8", VA = "0x2F8D8D8")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2F8DC00", Offset = "0x2F8DC00", VA = "0x2F8DC00")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8F8D4", Offset = "0xE8F8D4")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB, Timing instance)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2F8DCA8", Offset = "0x2F8DCA8", VA = "0x2F8DCA8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8F944", Offset = "0xE8F944")]
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
		[Address(RVA = "0x3CA0D30", Offset = "0x3CA0D30", VA = "0x3CA0D30", Slot = "4")]
		public bool Equals(ProcessIndex other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x3CA0D58", Offset = "0x3CA0D58", VA = "0x3CA0D58", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x3CA0DEC", Offset = "0x3CA0DEC", VA = "0x3CA0DEC")]
		public static bool operator ==(ProcessIndex a, ProcessIndex b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x3CA0E0C", Offset = "0x3CA0E0C", VA = "0x3CA0E0C")]
		public static bool operator !=(ProcessIndex a, ProcessIndex b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x3CA0E2C", Offset = "0x3CA0E2C", VA = "0x3CA0E2C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EEFC", Offset = "0xE8EEFC")]
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
			[Address(RVA = "0x3C9FB74", Offset = "0x3C9FB74", VA = "0x3C9FB74", Slot = "4")]
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
			[Address(RVA = "0x3C9FBBC", Offset = "0x3C9FBBC", VA = "0x3C9FBBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x3C9FAB8", Offset = "0x3C9FAB8", VA = "0x3C9FAB8")]
		[DebuggerHidden]
		public <_EOFPumpWatcher>d__116(int <>1__state)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x3C9FAE4", Offset = "0x3C9FAE4", VA = "0x3C9FAE4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x3C9FAE8", Offset = "0x3C9FAE8", VA = "0x3C9FAE8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x3C9FB7C", Offset = "0x3C9FB7C", VA = "0x3C9FB7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EF0C", Offset = "0xE8EF0C")]
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
			[Address(RVA = "0x3C9FA68", Offset = "0x3C9FA68", VA = "0x3C9FA68", Slot = "4")]
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
			[Address(RVA = "0x3C9FAB0", Offset = "0x3C9FAB0", VA = "0x3C9FAB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x3C9F4C0", Offset = "0x3C9F4C0", VA = "0x3C9F4C0")]
		[DebuggerHidden]
		public <_EOFPump>d__117(int <>1__state)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x3C9F4EC", Offset = "0x3C9F4EC", VA = "0x3C9F4EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x3C9F4F0", Offset = "0x3C9F4F0", VA = "0x3C9F4F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x3C9FA70", Offset = "0x3C9FA70", VA = "0x3C9FA70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EF1C", Offset = "0xE8EF1C")]
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
			[Address(RVA = "0x3CA020C", Offset = "0x3CA020C", VA = "0x3CA020C", Slot = "4")]
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
			[Address(RVA = "0x3CA0254", Offset = "0x3CA0254", VA = "0x3CA0254", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x3C9FE48", Offset = "0x3C9FE48", VA = "0x3C9FE48")]
		[DebuggerHidden]
		public <_StartWhenDone>d__252(int <>1__state)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x3C9FE74", Offset = "0x3C9FE74", VA = "0x3C9FE74", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x3C9FECC", Offset = "0x3C9FECC", VA = "0x3C9FECC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x3C9FEA0", Offset = "0x3C9FEA0", VA = "0x3C9FEA0")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x3CA0214", Offset = "0x3CA0214", VA = "0x3CA0214", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EF2C", Offset = "0xE8EF2C")]
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
			[Address(RVA = "0x3CA0430", Offset = "0x3CA0430", VA = "0x3CA0430", Slot = "4")]
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
			[Address(RVA = "0x3CA0478", Offset = "0x3CA0478", VA = "0x3CA0478", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x3CA02B4", Offset = "0x3CA02B4", VA = "0x3CA02B4")]
		[DebuggerHidden]
		public <_StartWhenDone>d__258(int <>1__state)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x3CA02E0", Offset = "0x3CA02E0", VA = "0x3CA02E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x3CA02E4", Offset = "0x3CA02E4", VA = "0x3CA02E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x3CA0438", Offset = "0x3CA0438", VA = "0x3CA0438", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EF3C", Offset = "0xE8EF3C")]
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
			[Address(RVA = "0x3CA0654", Offset = "0x3CA0654", VA = "0x3CA0654", Slot = "4")]
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
			[Address(RVA = "0x3CA069C", Offset = "0x3CA069C", VA = "0x3CA069C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x3CA04D8", Offset = "0x3CA04D8", VA = "0x3CA04D8")]
		[DebuggerHidden]
		public <_StartWhenDone>d__261(int <>1__state)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x3CA0504", Offset = "0x3CA0504", VA = "0x3CA0504", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x3CA0508", Offset = "0x3CA0508", VA = "0x3CA0508", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x3CA065C", Offset = "0x3CA065C", VA = "0x3CA065C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EF4C", Offset = "0xE8EF4C")]
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
			[Address(RVA = "0x3CA087C", Offset = "0x3CA087C", VA = "0x3CA087C", Slot = "4")]
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
			[Address(RVA = "0x3CA08C4", Offset = "0x3CA08C4", VA = "0x3CA08C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x3CA06FC", Offset = "0x3CA06FC", VA = "0x3CA06FC")]
		[DebuggerHidden]
		public <_StartWhenDone>d__264(int <>1__state)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x3CA0728", Offset = "0x3CA0728", VA = "0x3CA0728", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x3CA072C", Offset = "0x3CA072C", VA = "0x3CA072C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x3CA0884", Offset = "0x3CA0884", VA = "0x3CA0884", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EF5C", Offset = "0xE8EF5C")]
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
			[Address(RVA = "0x3CA0AC4", Offset = "0x3CA0AC4", VA = "0x3CA0AC4", Slot = "4")]
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
			[Address(RVA = "0x3CA0B0C", Offset = "0x3CA0B0C", VA = "0x3CA0B0C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x3CA0924", Offset = "0x3CA0924", VA = "0x3CA0924")]
		[DebuggerHidden]
		public <_StartWhenDone>d__269(int <>1__state)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x3CA0950", Offset = "0x3CA0950", VA = "0x3CA0950", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x3CA0954", Offset = "0x3CA0954", VA = "0x3CA0954", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x3CA0ACC", Offset = "0x3CA0ACC", VA = "0x3CA0ACC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EF6C", Offset = "0xE8EF6C")]
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
			[Address(RVA = "0x3C9FDA0", Offset = "0x3C9FDA0", VA = "0x3C9FDA0", Slot = "4")]
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
			[Address(RVA = "0x3C9FDE8", Offset = "0x3C9FDE8", VA = "0x3C9FDE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x3C9FC1C", Offset = "0x3C9FC1C", VA = "0x3C9FC1C")]
		[DebuggerHidden]
		public <_InjectDelay>d__270(int <>1__state)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x3C9FC48", Offset = "0x3C9FC48", VA = "0x3C9FC48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x3C9FC4C", Offset = "0x3C9FC4C", VA = "0x3C9FC4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x3C9FDA8", Offset = "0x3C9FDA8", VA = "0x3C9FDA8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EF7C", Offset = "0xE8EF7C")]
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
			[Address(RVA = "0x3C9F418", Offset = "0x3C9F418", VA = "0x3C9F418", Slot = "4")]
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
			[Address(RVA = "0x3C9F460", Offset = "0x3C9F460", VA = "0x3C9F460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x3C9F314", Offset = "0x3C9F314", VA = "0x3C9F314")]
		[DebuggerHidden]
		public <_DelayedCall>d__295(int <>1__state)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x3C9F340", Offset = "0x3C9F340", VA = "0x3C9F340", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x3C9F344", Offset = "0x3C9F344", VA = "0x3C9F344", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x3C9F420", Offset = "0x3C9F420", VA = "0x3C9F420", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EF8C", Offset = "0xE8EF8C")]
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
			[Address(RVA = "0x3CA0C88", Offset = "0x3CA0C88", VA = "0x3CA0C88", Slot = "4")]
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
			[Address(RVA = "0x3CA0CD0", Offset = "0x3CA0CD0", VA = "0x3CA0CD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x3CA0B6C", Offset = "0x3CA0B6C", VA = "0x3CA0B6C")]
		[DebuggerHidden]
		public <_WatchCall>d__312(int <>1__state)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x3CA0B98", Offset = "0x3CA0B98", VA = "0x3CA0B98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x3CA0B9C", Offset = "0x3CA0B9C", VA = "0x3CA0B9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x3CA0C90", Offset = "0x3CA0C90", VA = "0x3CA0C90", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EF9C", Offset = "0xE8EF9C")]
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
			[Address(RVA = "0x3C9F26C", Offset = "0x3C9F26C", VA = "0x3C9F26C", Slot = "4")]
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
			[Address(RVA = "0x3C9F2B4", Offset = "0x3C9F2B4", VA = "0x3C9F2B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x3C9F100", Offset = "0x3C9F100", VA = "0x3C9F100")]
		[DebuggerHidden]
		public <_CallContinuously>d__313(int <>1__state)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x3C9F12C", Offset = "0x3C9F12C", VA = "0x3C9F12C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x3C9F130", Offset = "0x3C9F130", VA = "0x3C9F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x3C9F274", Offset = "0x3C9F274", VA = "0x3C9F274", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EFAC", Offset = "0xE8EFAC")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8EFBC", Offset = "0xE8EFBC")]
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
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE8EFCC", Offset = "0xE8EFCC")]
	public float TimeBetweenSlowUpdateCalls;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE8F004", Offset = "0xE8F004")]
	public DebugInfoType ProfilerDebugAmount;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE8F03C", Offset = "0xE8F03C")]
	public bool AutoTriggerManualTimeframe;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE8F074", Offset = "0xE8F074")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xE8F074", Offset = "0xE8F074")]
	public int UpdateCoroutines;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE8F0C4", Offset = "0xE8F0C4")]
	public int FixedUpdateCoroutines;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE8F0FC", Offset = "0xE8F0FC")]
	public int LateUpdateCoroutines;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE8F134", Offset = "0xE8F134")]
	public int SlowUpdateCoroutines;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE8F16C", Offset = "0xE8F16C")]
	public int RealtimeUpdateCoroutines;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE8F1A4", Offset = "0xE8F1A4")]
	public int EditorUpdateCoroutines;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE8F1DC", Offset = "0xE8F1DC")]
	public int EditorSlowUpdateCoroutines;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE8F214", Offset = "0xE8F214")]
	public int EndOfFrameCoroutines;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xE8F24C", Offset = "0xE8F24C")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8F294", Offset = "0xE8F294")]
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
		[Address(RVA = "0x2F8DD3C", Offset = "0x2F8DD3C", VA = "0x2F8DD3C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000002")]
	public static float DeltaTime
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2F8DDA4", Offset = "0x2F8DDA4", VA = "0x2F8DDA4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000003")]
	public static Thread MainThread
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2F8DFFC", Offset = "0x2F8DFFC", VA = "0x2F8DFFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8F9D4", Offset = "0xE8F9D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2F8E060", Offset = "0x2F8E060", VA = "0x2F8E060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8F9E4", Offset = "0xE8F9E4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public static Timing Instance
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2F8D950", Offset = "0x2F8D950", VA = "0x2F8D950")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2F8E0CC", Offset = "0x2F8E0CC", VA = "0x2F8E0CC")]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public static event Action OnPreExecute
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2F8DE0C", Offset = "0x2F8DE0C", VA = "0x2F8DE0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8F9B4", Offset = "0xE8F9B4")]
		add
		{
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2F8DF04", Offset = "0x2F8DF04", VA = "0x2F8DF04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xE8F9C4", Offset = "0xE8F9C4")]
		remove
		{
		}
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2F8E138", Offset = "0x2F8E138", VA = "0x2F8E138")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2F8E468", Offset = "0x2F8E468", VA = "0x2F8E468")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2F8E590", Offset = "0x2F8E590", VA = "0x2F8E590")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2F8E8D8", Offset = "0x2F8E8D8", VA = "0x2F8E8D8")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2F917C0", Offset = "0x2F917C0", VA = "0x2F917C0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2F91CA8", Offset = "0x2F91CA8", VA = "0x2F91CA8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2F8FB14", Offset = "0x2F8FB14", VA = "0x2F8FB14")]
	public void TriggerManualTimeframeUpdate()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2F8E604", Offset = "0x2F8E604", VA = "0x2F8E604")]
	private bool OnEditorStart()
	{
		return default(bool);
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2F8E60C", Offset = "0x2F8E60C", VA = "0x2F8E60C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8F9F4", Offset = "0xE8F9F4")]
	private IEnumerator<float> _EOFPumpWatcher()
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2F92190", Offset = "0x2F92190", VA = "0x2F92190")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8FA54", Offset = "0xE8FA54")]
	private IEnumerator _EOFPump()
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2F9003C", Offset = "0x2F9003C", VA = "0x2F9003C")]
	private void RemoveUnused()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2F9277C", Offset = "0x2F9277C", VA = "0x2F9277C")]
	private void EditorRemoveUnused()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2F92F74", Offset = "0x2F92F74", VA = "0x2F92F74")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2F94DB0", Offset = "0x2F94DB0", VA = "0x2F94DB0")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x2F94F1C", Offset = "0x2F94F1C", VA = "0x2F94F1C")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x2F9500C", Offset = "0x2F9500C", VA = "0x2F9500C")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2F950CC", Offset = "0x2F950CC", VA = "0x2F950CC")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2F9523C", Offset = "0x2F9523C", VA = "0x2F9523C")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x2F95330", Offset = "0x2F95330", VA = "0x2F95330")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2F953F0", Offset = "0x2F953F0", VA = "0x2F953F0")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x2F95560", Offset = "0x2F95560", VA = "0x2F95560")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x2F95654", Offset = "0x2F95654", VA = "0x2F95654")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x2F95720", Offset = "0x2F95720", VA = "0x2F95720")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2F9589C", Offset = "0x2F9589C", VA = "0x2F9589C")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2F9599C", Offset = "0x2F9599C", VA = "0x2F9599C")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x2F95A04", Offset = "0x2F95A04", VA = "0x2F95A04")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x2F95B14", Offset = "0x2F95B14", VA = "0x2F95B14")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x2F95BC4", Offset = "0x2F95BC4", VA = "0x2F95BC4")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2F95C30", Offset = "0x2F95C30", VA = "0x2F95C30")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x2F95D4C", Offset = "0x2F95D4C", VA = "0x2F95D4C")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x2F95E08", Offset = "0x2F95E08", VA = "0x2F95E08")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x2F95E74", Offset = "0x2F95E74", VA = "0x2F95E74")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2F95F90", Offset = "0x2F95F90", VA = "0x2F95F90")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x2F9604C", Offset = "0x2F9604C", VA = "0x2F9604C")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2F960C4", Offset = "0x2F960C4", VA = "0x2F960C4")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x2F961E4", Offset = "0x2F961E4", VA = "0x2F961E4")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x2F962A4", Offset = "0x2F962A4", VA = "0x2F962A4")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x2F967D4", Offset = "0x2F967D4", VA = "0x2F967D4")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2F968DC", Offset = "0x2F968DC", VA = "0x2F968DC")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2F97490", Offset = "0x2F97490", VA = "0x2F97490")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2F97858", Offset = "0x2F97858", VA = "0x2F97858")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2F97978", Offset = "0x2F97978", VA = "0x2F97978")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x2F98008", Offset = "0x2F98008", VA = "0x2F98008")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2F981B0", Offset = "0x2F981B0", VA = "0x2F981B0")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2F982CC", Offset = "0x2F982CC", VA = "0x2F982CC")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x2F985EC", Offset = "0x2F985EC", VA = "0x2F985EC")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x2F988C8", Offset = "0x2F988C8", VA = "0x2F988C8")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2F989F4", Offset = "0x2F989F4", VA = "0x2F989F4")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x2F98F98", Offset = "0x2F98F98", VA = "0x2F98F98")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x2F99138", Offset = "0x2F99138", VA = "0x2F99138")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x2F99200", Offset = "0x2F99200", VA = "0x2F99200")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2F8E684", Offset = "0x2F8E684", VA = "0x2F8E684")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x2F99A28", Offset = "0x2F99A28", VA = "0x2F99A28")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x2F99B00", Offset = "0x2F99B00", VA = "0x2F99B00")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2F9A384", Offset = "0x2F9A384", VA = "0x2F9A384")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x2F9A458", Offset = "0x2F9A458", VA = "0x2F9A458")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x2F9A6FC", Offset = "0x2F9A6FC", VA = "0x2F9A6FC")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x2F9A95C", Offset = "0x2F9A95C", VA = "0x2F9A95C")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x2F9AA48", Offset = "0x2F9AA48", VA = "0x2F9AA48")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x2F93030", Offset = "0x2F93030", VA = "0x2F93030")]
	private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, int? layer, string tag, CoroutineHandle handle, bool prewarm)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x2F9B174", Offset = "0x2F9B174", VA = "0x2F9B174")]
	public static int KillCoroutines()
	{
		return default(int);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x2F9B258", Offset = "0x2F9B258", VA = "0x2F9B258")]
	public int KillCoroutinesOnInstance()
	{
		return default(int);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x2F8CBB8", Offset = "0x2F8CBB8", VA = "0x2F8CBB8")]
	public static int KillCoroutines(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x2F8F8D4", Offset = "0x2F8F8D4", VA = "0x2F8F8D4")]
	public int KillCoroutinesOnInstance(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x2F9B800", Offset = "0x2F9B800", VA = "0x2F9B800")]
	public static int KillCoroutines(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x2F9B90C", Offset = "0x2F9B90C", VA = "0x2F9B90C")]
	public int KillCoroutinesOnInstance(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x2F96BF0", Offset = "0x2F96BF0", VA = "0x2F96BF0")]
	public static int KillCoroutines(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x2F99498", Offset = "0x2F99498", VA = "0x2F99498")]
	public int KillCoroutinesOnInstance(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x2F97760", Offset = "0x2F97760", VA = "0x2F97760")]
	public static int KillCoroutines(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x2F99748", Offset = "0x2F99748", VA = "0x2F99748")]
	public int KillCoroutinesOnInstance(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x2F9BA60", Offset = "0x2F9BA60", VA = "0x2F9BA60")]
	public static int KillCoroutines(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x2F9BB74", Offset = "0x2F9BB74", VA = "0x2F9BB74")]
	public int KillCoroutinesOnInstance(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x2F97F08", Offset = "0x2F97F08", VA = "0x2F97F08")]
	public static int KillCoroutines(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x2F99F30", Offset = "0x2F99F30", VA = "0x2F99F30")]
	public int KillCoroutinesOnInstance(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x2F9B6AC", Offset = "0x2F9B6AC", VA = "0x2F9B6AC")]
	public static Timing GetInstance(byte ID)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x2F9BBB4", Offset = "0x2F9BBB4", VA = "0x2F9BBB4")]
	public static float WaitForSeconds(float waitTime)
	{
		return default(float);
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x2F9BC3C", Offset = "0x2F9BC3C", VA = "0x2F9BC3C")]
	public float WaitForSecondsOnInstance(float waitTime)
	{
		return default(float);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x2F8F5DC", Offset = "0x2F8F5DC", VA = "0x2F8F5DC")]
	private bool UpdateTimeValues(Segment segment)
	{
		return default(bool);
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x2F9BC80", Offset = "0x2F9BC80", VA = "0x2F9BC80")]
	private float GetSegmentTime(Segment segment)
	{
		return default(float);
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x2F9BD6C", Offset = "0x2F9BD6C", VA = "0x2F9BD6C")]
	public static int PauseCoroutines()
	{
		return default(int);
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x2F9BE50", Offset = "0x2F9BE50", VA = "0x2F9BE50")]
	public int PauseCoroutinesOnInstance()
	{
		return default(int);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x2F8CEE8", Offset = "0x2F8CEE8", VA = "0x2F8CEE8")]
	public static int PauseCoroutines(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x2F9D1E4", Offset = "0x2F9D1E4", VA = "0x2F9D1E4")]
	public int PauseCoroutinesOnInstance(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x2F9E1EC", Offset = "0x2F9E1EC", VA = "0x2F9E1EC")]
	public static int PauseCoroutines(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x2F9E2E4", Offset = "0x2F9E2E4", VA = "0x2F9E2E4")]
	public int PauseCoroutinesOnInstance(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x2F9E6D0", Offset = "0x2F9E6D0", VA = "0x2F9E6D0")]
	public static int PauseCoroutines(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x2F9E390", Offset = "0x2F9E390", VA = "0x2F9E390")]
	public int PauseCoroutinesOnInstance(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x2F9E7C8", Offset = "0x2F9E7C8", VA = "0x2F9E7C8")]
	public static int PauseCoroutines(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x2F9E8C0", Offset = "0x2F9E8C0", VA = "0x2F9E8C0")]
	public int PauseCoroutinesOnInstance(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x2F9EC04", Offset = "0x2F9EC04", VA = "0x2F9EC04")]
	public static int PauseCoroutines(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x2F9F150", Offset = "0x2F9F150", VA = "0x2F9F150")]
	public int PauseCoroutinesOnInstance(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x2F9F204", Offset = "0x2F9F204", VA = "0x2F9F204")]
	public static int PauseCoroutines(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x2F9ED18", Offset = "0x2F9ED18", VA = "0x2F9ED18")]
	public int PauseCoroutinesOnInstance(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x2F9F304", Offset = "0x2F9F304", VA = "0x2F9F304")]
	public static int ResumeCoroutines()
	{
		return default(int);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2F9F3E8", Offset = "0x2F9F3E8", VA = "0x2F9F3E8")]
	public int ResumeCoroutinesOnInstance()
	{
		return default(int);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x2F8CFC4", Offset = "0x2F8CFC4", VA = "0x2F8CFC4")]
	public static int ResumeCoroutines(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2F9FD20", Offset = "0x2F9FD20", VA = "0x2F9FD20")]
	public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x2FA000C", Offset = "0x2FA000C", VA = "0x2FA000C")]
	public static int ResumeCoroutines(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2FA0480", Offset = "0x2FA0480", VA = "0x2FA0480")]
	public int ResumeCoroutinesOnInstance(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2FA052C", Offset = "0x2FA052C", VA = "0x2FA052C")]
	public static int ResumeCoroutines(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x2FA0118", Offset = "0x2FA0118", VA = "0x2FA0118")]
	public int ResumeCoroutinesOnInstance(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x2FA0624", Offset = "0x2FA0624", VA = "0x2FA0624")]
	public static int ResumeCoroutines(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x2FA071C", Offset = "0x2FA071C", VA = "0x2FA071C")]
	public int ResumeCoroutinesOnInstance(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x2FA0A88", Offset = "0x2FA0A88", VA = "0x2FA0A88")]
	public static int ResumeCoroutines(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x2FA0FDC", Offset = "0x2FA0FDC", VA = "0x2FA0FDC")]
	public int ResumeCoroutinesOnInstance(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x2FA1090", Offset = "0x2FA1090", VA = "0x2FA1090")]
	public static int ResumeCoroutines(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x2FA0B9C", Offset = "0x2FA0B9C", VA = "0x2FA0B9C")]
	public int ResumeCoroutinesOnInstance(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x2F8BC6C", Offset = "0x2F8BC6C", VA = "0x2F8BC6C")]
	public static string GetTag(CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x2F8C01C", Offset = "0x2F8C01C", VA = "0x2F8C01C")]
	public static int? GetLayer(CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x2F8C5AC", Offset = "0x2F8C5AC", VA = "0x2F8C5AC")]
	public static Segment GetSegment(CoroutineHandle handle)
	{
		return default(Segment);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x2F8BE30", Offset = "0x2F8BE30", VA = "0x2F8BE30")]
	public static bool SetTag(CoroutineHandle handle, string newTag, bool overwriteExisting = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x2F8C3C0", Offset = "0x2F8C3C0", VA = "0x2F8C3C0")]
	public static bool SetLayer(CoroutineHandle handle, int newLayer, bool overwriteExisting = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x2F8C738", Offset = "0x2F8C738", VA = "0x2F8C738")]
	public static bool SetSegment(CoroutineHandle handle, Segment newSegment)
	{
		return default(bool);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x2FA15A0", Offset = "0x2FA15A0", VA = "0x2FA15A0")]
	public static bool RemoveTag(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x2F8C288", Offset = "0x2F8C288", VA = "0x2F8C288")]
	public static bool RemoveLayer(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x2F8CA08", Offset = "0x2F8CA08", VA = "0x2F8CA08")]
	public static bool IsRunning(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x2F8CCF8", Offset = "0x2F8CCF8", VA = "0x2F8CCF8")]
	public static bool IsPaused(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x2F9AE7C", Offset = "0x2F9AE7C", VA = "0x2F9AE7C")]
	private void AddTagOnInstance(string tag, CoroutineHandle handle)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x2F9AFF8", Offset = "0x2F9AFF8", VA = "0x2F9AFF8")]
	private void AddLayerOnInstance(int layer, CoroutineHandle handle)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x2FA1190", Offset = "0x2FA1190", VA = "0x2FA1190")]
	private void RemoveTagOnInstance(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x2FA1328", Offset = "0x2FA1328", VA = "0x2FA1328")]
	private void RemoveLayerOnInstance(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x2F924C0", Offset = "0x2F924C0", VA = "0x2F924C0")]
	private void RemoveGraffiti(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x2FA14C0", Offset = "0x2FA14C0", VA = "0x2FA14C0")]
	private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x2F92208", Offset = "0x2F92208", VA = "0x2F92208")]
	private bool CoindexIsNull(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x2FA16D4", Offset = "0x2FA16D4", VA = "0x2FA16D4")]
	private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x2F9B790", Offset = "0x2F9B790", VA = "0x2F9B790")]
	private bool Nullify(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x2F9B944", Offset = "0x2F9B944", VA = "0x2F9B944")]
	private bool Nullify(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x2F9D4A0", Offset = "0x2F9D4A0", VA = "0x2F9D4A0")]
	private bool SetPause(ProcessIndex coindex, bool newPausedState = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x2FA179C", Offset = "0x2FA179C", VA = "0x2FA179C")]
	private IEnumerator<float> CreatePause(ProcessIndex coindex, IEnumerator<float> coptr, bool newPausedState = true)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2FA1608", Offset = "0x2FA1608", VA = "0x2FA1608")]
	private bool CoindexIsPaused(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x2FA2488", Offset = "0x2FA2488", VA = "0x2FA2488")]
	private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x2FA2598", Offset = "0x2FA2598", VA = "0x2FA2598")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine)
	{
		return default(float);
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x2FA28E8", Offset = "0x2FA28E8", VA = "0x2FA28E8")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x2FA2964", Offset = "0x2FA2964", VA = "0x2FA2964")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer)
	{
		return default(float);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x2FA29E0", Offset = "0x2FA29E0", VA = "0x2FA29E0")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x2FA2A64", Offset = "0x2FA2A64", VA = "0x2FA2A64")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment)
	{
		return default(float);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x2FA2AE0", Offset = "0x2FA2AE0", VA = "0x2FA2AE0")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x2FA2B64", Offset = "0x2FA2B64", VA = "0x2FA2B64")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer)
	{
		return default(float);
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x2FA2BE8", Offset = "0x2FA2BE8", VA = "0x2FA2BE8")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x2FA2C7C", Offset = "0x2FA2C7C", VA = "0x2FA2C7C")]
	public static float WaitUntilDone(CoroutineHandle otherCoroutine)
	{
		return default(float);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x2FA2604", Offset = "0x2FA2604", VA = "0x2FA2604")]
	public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
	{
		return default(float);
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x2FA2D7C", Offset = "0x2FA2D7C", VA = "0x2FA2D7C")]
	private IEnumerator<float> WaitUntilDoneWrapper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x2F96448", Offset = "0x2F96448", VA = "0x2F96448")]
	public static void WaitForOtherHandles(CoroutineHandle handle, CoroutineHandle otherHandle, bool warnOnIssue = true)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x2F96CE8", Offset = "0x2F96CE8", VA = "0x2F96CE8")]
	public static void WaitForOtherHandles(CoroutineHandle handle, IEnumerable<CoroutineHandle> otherHandles, bool warnOnIssue = true)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x2FA2CE0", Offset = "0x2FA2CE0", VA = "0x2FA2CE0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8FAB4", Offset = "0xE8FAB4")]
	private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x2F922D8", Offset = "0x2F922D8", VA = "0x2F922D8")]
	private void CloseWaitingProcess(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x2FA2F18", Offset = "0x2FA2F18", VA = "0x2FA2F18")]
	private bool HandleIsInWaitingList(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x2FA3010", Offset = "0x2FA3010", VA = "0x2FA3010")]
	private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x2FA308C", Offset = "0x2FA308C", VA = "0x2FA308C")]
	public static float WaitUntilDone(WWW wwwObject)
	{
		return default(float);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x2FA3194", Offset = "0x2FA3194", VA = "0x2FA3194")]
	private static IEnumerator<float> WaitUntilDoneWwwHelper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x2FA324C", Offset = "0x2FA324C", VA = "0x2FA324C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8FB14", Offset = "0xE8FB14")]
	private static IEnumerator<float> _StartWhenDone(WWW wwwObject, IEnumerator<float> pausedProc)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x2FA32E0", Offset = "0x2FA32E0", VA = "0x2FA32E0")]
	public static float WaitUntilDone(AsyncOperation operation)
	{
		return default(float);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x2FA33D8", Offset = "0x2FA33D8", VA = "0x2FA33D8")]
	private static IEnumerator<float> WaitUntilDoneAscOpHelper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x2FA3490", Offset = "0x2FA3490", VA = "0x2FA3490")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8FB74", Offset = "0xE8FB74")]
	private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x2FA3524", Offset = "0x2FA3524", VA = "0x2FA3524")]
	public static float WaitUntilDone(CustomYieldInstruction operation)
	{
		return default(float);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x2FA3620", Offset = "0x2FA3620", VA = "0x2FA3620")]
	private static IEnumerator<float> WaitUntilDoneCustYieldHelper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x2FA36D8", Offset = "0x2FA36D8", VA = "0x2FA36D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8FBD4", Offset = "0xE8FBD4")]
	private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x2FA376C", Offset = "0x2FA376C", VA = "0x2FA376C")]
	public static float WaitUntilTrue(Func<bool> evaluatorFunc)
	{
		return default(float);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x2FA3878", Offset = "0x2FA3878", VA = "0x2FA3878")]
	private static IEnumerator<float> WaitUntilTrueHelper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x2FA39B8", Offset = "0x2FA39B8", VA = "0x2FA39B8")]
	public static float WaitUntilFalse(Func<bool> evaluatorFunc)
	{
		return default(float);
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x2FA3AC4", Offset = "0x2FA3AC4", VA = "0x2FA3AC4")]
	private static IEnumerator<float> WaitUntilFalseHelper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x2FA3918", Offset = "0x2FA3918", VA = "0x2FA3918")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8FC34", Offset = "0xE8FC34")]
	private static IEnumerator<float> _StartWhenDone(Func<bool> evaluatorFunc, bool continueOn, IEnumerator<float> pausedProc)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x2F9D140", Offset = "0x2F9D140", VA = "0x2F9D140")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8FC94", Offset = "0xE8FC94")]
	private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float waitTime)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x2FA3B64", Offset = "0x2FA3B64", VA = "0x2FA3B64")]
	public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x2FA3D4C", Offset = "0x2FA3D4C", VA = "0x2FA3D4C")]
	public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x2FA3ED4", Offset = "0x2FA3ED4", VA = "0x2FA3ED4")]
	public static int LinkCoroutines(CoroutineHandle master, CoroutineHandle slave)
	{
		return default(int);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x2FA4178", Offset = "0x2FA4178", VA = "0x2FA4178")]
	public static int UnlinkCoroutines(CoroutineHandle master, CoroutineHandle slave, bool twoWay = false)
	{
		return default(int);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x2FA4510", Offset = "0x2FA4510", VA = "0x2FA4510")]
	public static float GetMyHandle(Action<CoroutineHandle> reciever)
	{
		return default(float);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x2FA45F4", Offset = "0x2FA45F4", VA = "0x2FA45F4")]
	private static IEnumerator<float> GetHandleHelper(IEnumerator<float> input, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x2FA46C0", Offset = "0x2FA46C0", VA = "0x2FA46C0")]
	public static float SwitchCoroutine(Segment newSegment)
	{
		return default(float);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x2FA479C", Offset = "0x2FA479C", VA = "0x2FA479C")]
	private static IEnumerator<float> SwitchCoroutineRepS(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x2FA493C", Offset = "0x2FA493C", VA = "0x2FA493C")]
	public static float SwitchCoroutine(Segment newSegment, string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x2FA4A34", Offset = "0x2FA4A34", VA = "0x2FA4A34")]
	private static IEnumerator<float> SwitchCoroutineRepST(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x2FA4BD0", Offset = "0x2FA4BD0", VA = "0x2FA4BD0")]
	public static float SwitchCoroutine(Segment newSegment, int newLayer)
	{
		return default(float);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x2FA4CC0", Offset = "0x2FA4CC0", VA = "0x2FA4CC0")]
	private static IEnumerator<float> SwitchCoroutineRepSL(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x2FA4E04", Offset = "0x2FA4E04", VA = "0x2FA4E04")]
	public static float SwitchCoroutine(Segment newSegment, int newLayer, string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x2FA4F08", Offset = "0x2FA4F08", VA = "0x2FA4F08")]
	private static IEnumerator<float> SwitchCoroutineRepSLT(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x2FA5020", Offset = "0x2FA5020", VA = "0x2FA5020")]
	public static float SwitchCoroutine(string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x2FA5104", Offset = "0x2FA5104", VA = "0x2FA5104")]
	private static IEnumerator<float> SwitchCoroutineRepT(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x2FA521C", Offset = "0x2FA521C", VA = "0x2FA521C")]
	public static float SwitchCoroutine(int newLayer)
	{
		return default(float);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x2FA52F8", Offset = "0x2FA52F8", VA = "0x2FA52F8")]
	private static IEnumerator<float> SwitchCoroutineRepL(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x2FA5394", Offset = "0x2FA5394", VA = "0x2FA5394")]
	public static float SwitchCoroutine(int newLayer, string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x2FA548C", Offset = "0x2FA548C", VA = "0x2FA548C")]
	private static IEnumerator<float> SwitchCoroutineRepLT(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x2FA55C8", Offset = "0x2FA55C8", VA = "0x2FA55C8")]
	public static CoroutineHandle CallDelayed(float delay, Action action)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x2FA5718", Offset = "0x2FA5718", VA = "0x2FA5718")]
	public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x2FA5758", Offset = "0x2FA5758", VA = "0x2FA5758")]
	public static CoroutineHandle CallDelayed(float delay, Action action, GameObject gameObject)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x2FA5800", Offset = "0x2FA5800", VA = "0x2FA5800")]
	public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject gameObject)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x2FA5660", Offset = "0x2FA5660", VA = "0x2FA5660")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8FCF4", Offset = "0xE8FCF4")]
	private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x2FA5844", Offset = "0x2FA5844", VA = "0x2FA5844")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x2FA5AB8", Offset = "0x2FA5AB8", VA = "0x2FA5AB8")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x2FA5B50", Offset = "0x2FA5B50", VA = "0x2FA5B50")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x2FA5C5C", Offset = "0x2FA5C5C", VA = "0x2FA5C5C")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x2FA5D60", Offset = "0x2FA5D60", VA = "0x2FA5D60")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x2FA5E60", Offset = "0x2FA5E60", VA = "0x2FA5E60")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x2FA5F64", Offset = "0x2FA5F64", VA = "0x2FA5F64")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x2FA6084", Offset = "0x2FA6084", VA = "0x2FA6084")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x2FA6194", Offset = "0x2FA6194", VA = "0x2FA6194")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x2FA6290", Offset = "0x2FA6290", VA = "0x2FA6290")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x2FA637C", Offset = "0x2FA637C", VA = "0x2FA637C")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x2FA6484", Offset = "0x2FA6484", VA = "0x2FA6484")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x2FA6584", Offset = "0x2FA6584", VA = "0x2FA6584")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x2FA668C", Offset = "0x2FA668C", VA = "0x2FA668C")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x2FA678C", Offset = "0x2FA678C", VA = "0x2FA678C")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x2FA68A8", Offset = "0x2FA68A8", VA = "0x2FA68A8")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x2FA59F0", Offset = "0x2FA59F0", VA = "0x2FA59F0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8FD54", Offset = "0xE8FD54")]
	private IEnumerator<float> _WatchCall(float timeframe, CoroutineHandle handle, GameObject gObject, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x2FA5938", Offset = "0x2FA5938", VA = "0x2FA5938")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8FDB4", Offset = "0xE8FDB4")]
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
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8FE14", Offset = "0xE8FE14")]
	private IEnumerator<float> _WatchCall<T>(T reference, float timeframe, CoroutineHandle handle, GameObject gObject, Action<T> onDone)
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xE8FE74", Offset = "0xE8FE74")]
	private IEnumerator<float> _CallContinuously<T>(T reference, float period, Action<T> action, GameObject gObject)
	{
		return null;
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x2FA69B4", Offset = "0x2FA69B4", VA = "0x2FA69B4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE8FED4", Offset = "0xE8FED4")]
	public new Coroutine StartCoroutine(IEnumerator routine)
	{
		return null;
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x2FA69BC", Offset = "0x2FA69BC", VA = "0x2FA69BC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE8FF10", Offset = "0xE8FF10")]
	public new Coroutine StartCoroutine(string methodName, object value)
	{
		return null;
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x2FA69C4", Offset = "0x2FA69C4", VA = "0x2FA69C4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE8FF4C", Offset = "0xE8FF4C")]
	public new Coroutine StartCoroutine(string methodName)
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x2FA69CC", Offset = "0x2FA69CC", VA = "0x2FA69CC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE8FF88", Offset = "0xE8FF88")]
	public new Coroutine StartCoroutine_Auto(IEnumerator routine)
	{
		return null;
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x2FA69D4", Offset = "0x2FA69D4", VA = "0x2FA69D4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE8FFC4", Offset = "0xE8FFC4")]
	public new void StopCoroutine(string methodName)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x2FA69D8", Offset = "0x2FA69D8", VA = "0x2FA69D8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE90000", Offset = "0xE90000")]
	public new void StopCoroutine(IEnumerator routine)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x2FA69DC", Offset = "0x2FA69DC", VA = "0x2FA69DC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE9003C", Offset = "0xE9003C")]
	public new void StopCoroutine(Coroutine routine)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x2FA69E0", Offset = "0x2FA69E0", VA = "0x2FA69E0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE90078", Offset = "0xE90078")]
	public new void StopAllCoroutines()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x2FA69E4", Offset = "0x2FA69E4", VA = "0x2FA69E4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE900B4", Offset = "0xE900B4")]
	public new static void Destroy(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x2FA69E8", Offset = "0x2FA69E8", VA = "0x2FA69E8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE900F0", Offset = "0xE900F0")]
	public new static void Destroy(UnityEngine.Object obj, float f)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x2FA69EC", Offset = "0x2FA69EC", VA = "0x2FA69EC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE9012C", Offset = "0xE9012C")]
	public static void DestroyObject(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x2FA69F0", Offset = "0x2FA69F0", VA = "0x2FA69F0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE90168", Offset = "0xE90168")]
	public static void DestroyObject(UnityEngine.Object obj, float f)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x2FA69F4", Offset = "0x2FA69F4", VA = "0x2FA69F4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE901A4", Offset = "0xE901A4")]
	public new static void DestroyImmediate(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x2FA69F8", Offset = "0x2FA69F8", VA = "0x2FA69F8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE901E0", Offset = "0xE901E0")]
	public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x2FA69FC", Offset = "0x2FA69FC", VA = "0x2FA69FC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE9021C", Offset = "0xE9021C")]
	public new static void Instantiate(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x2FA6A00", Offset = "0x2FA6A00", VA = "0x2FA6A00")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE90258", Offset = "0xE90258")]
	public new static void Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation)
	{
	}

	[Token(Token = "0x600010A")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE90294", Offset = "0xE90294")]
	public new static void Instantiate<T>(T original) where T : UnityEngine.Object
	{
	}

	[Token(Token = "0x600010B")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE902D0", Offset = "0xE902D0")]
	public new static T FindObjectOfType<T>() where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x2FA6A04", Offset = "0x2FA6A04", VA = "0x2FA6A04")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE9030C", Offset = "0xE9030C")]
	public new static UnityEngine.Object FindObjectOfType(Type t)
	{
		return null;
	}

	[Token(Token = "0x600010D")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE90348", Offset = "0xE90348")]
	public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x2FA6A0C", Offset = "0x2FA6A0C", VA = "0x2FA6A0C")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE90384", Offset = "0xE90384")]
	public new static UnityEngine.Object[] FindObjectsOfType(Type t)
	{
		return null;
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x2FA6A14", Offset = "0x2FA6A14", VA = "0x2FA6A14")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xE903C0", Offset = "0xE903C0")]
	public new static void print(object message)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x2FA6A18", Offset = "0x2FA6A18", VA = "0x2FA6A18")]
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
		[Address(RVA = "0x2F8BA60", Offset = "0x2F8BA60", VA = "0x2F8BA60")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x17000006")]
	public string Tag
	{
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2F8BC08", Offset = "0x2F8BC08", VA = "0x2F8BC08")]
		get
		{
			return null;
		}
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2F8BDB8", Offset = "0x2F8BDB8", VA = "0x2F8BDB8")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public int? Layer
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2F8BFB8", Offset = "0x2F8BFB8", VA = "0x2F8BFB8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2F8C198", Offset = "0x2F8C198", VA = "0x2F8C198")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public Segment Segment
	{
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2F8C548", Offset = "0x2F8C548", VA = "0x2F8C548")]
		get
		{
			return default(Segment);
		}
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2F8C6C4", Offset = "0x2F8C6C4", VA = "0x2F8C6C4")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public bool IsRunning
	{
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2F8C9A4", Offset = "0x2F8C9A4", VA = "0x2F8C9A4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2F8CB34", Offset = "0x2F8CB34", VA = "0x2F8CB34")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public bool IsPaused
	{
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2F8CC94", Offset = "0x2F8CC94", VA = "0x2F8CC94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2F8CE50", Offset = "0x2F8CE50", VA = "0x2F8CE50")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public bool IsValid
	{
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2F8D0A0", Offset = "0x2F8D0A0", VA = "0x2F8D0A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x2F8BA6C", Offset = "0x2F8BA6C", VA = "0x2F8BA6C")]
	public CoroutineHandle(byte ind)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x2F8BB54", Offset = "0x2F8BB54", VA = "0x2F8BB54", Slot = "4")]
	public bool Equals(CoroutineHandle other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x2F8BB64", Offset = "0x2F8BB64", VA = "0x2F8BB64", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x2F8BBE8", Offset = "0x2F8BBE8", VA = "0x2F8BBE8")]
	public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x2F8BBF4", Offset = "0x2F8BBF4", VA = "0x2F8BBF4")]
	public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x2F8BC00", Offset = "0x2F8BC00", VA = "0x2F8BC00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
