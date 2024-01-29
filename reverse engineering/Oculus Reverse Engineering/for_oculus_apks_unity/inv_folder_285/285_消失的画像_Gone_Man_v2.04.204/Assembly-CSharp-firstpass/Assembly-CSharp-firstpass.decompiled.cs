using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;
using MEC;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class MECExtensionMethods2
{
	[Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class <Delay>d__0 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float timeToDelay;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000001")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0xE8BFB8", Offset = "0xE8BFB8", VA = "0xE8BFB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0xE8C000", Offset = "0xE8C000", VA = "0xE8C000", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xE8B398", Offset = "0xE8B398", VA = "0xE8B398")]
		[DebuggerHidden]
		public <Delay>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xE8BE10", Offset = "0xE8BE10", VA = "0xE8BE10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xE8BE14", Offset = "0xE8BE14", VA = "0xE8BE14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xE8BFC0", Offset = "0xE8BFC0", VA = "0xE8BFC0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class <Delay>d__1 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000003")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0xE8C1DC", Offset = "0xE8C1DC", VA = "0xE8C1DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0xE8C224", Offset = "0xE8C224", VA = "0xE8C224", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xE8B434", Offset = "0xE8B434", VA = "0xE8B434")]
		[DebuggerHidden]
		public <Delay>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xE8C05C", Offset = "0xE8C05C", VA = "0xE8C05C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xE8C060", Offset = "0xE8C060", VA = "0xE8C060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xE8C1E4", Offset = "0xE8C1E4", VA = "0xE8C1E4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class <Delay>d__2<T> : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Func<T, bool> condition;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T data;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000005")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000025")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000027")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000022")]
		[DebuggerHidden]
		public <Delay>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000023")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000024")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000026")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class <DelayFrames>d__3 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int framesToDelay;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000007")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0xE8C3F4", Offset = "0xE8C3F4", VA = "0xE8C3F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0xE8C43C", Offset = "0xE8C43C", VA = "0xE8C43C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xE8B4D4", Offset = "0xE8B4D4", VA = "0xE8B4D4")]
		[DebuggerHidden]
		public <DelayFrames>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xE8C280", Offset = "0xE8C280", VA = "0xE8C280", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xE8C284", Offset = "0xE8C284", VA = "0xE8C284", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xE8C3FC", Offset = "0xE8C3FC", VA = "0xE8C3FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class <CancelWith>d__4 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject;

		[Token(Token = "0x17000009")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0xE8C69C", Offset = "0xE8C69C", VA = "0xE8C69C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0xE8C6E4", Offset = "0xE8C6E4", VA = "0xE8C6E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xE8B570", Offset = "0xE8B570", VA = "0xE8B570")]
		[DebuggerHidden]
		public <CancelWith>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xE8C498", Offset = "0xE8C498", VA = "0xE8C498", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xE8C49C", Offset = "0xE8C49C", VA = "0xE8C49C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xE8C6A4", Offset = "0xE8C6A4", VA = "0xE8C6A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class <CancelWith>d__5 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject1;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gameObject2;

		[Token(Token = "0x1700000B")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0xE8C97C", Offset = "0xE8C97C", VA = "0xE8C97C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0xE8C9C4", Offset = "0xE8C9C4", VA = "0xE8C9C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xE8B614", Offset = "0xE8B614", VA = "0xE8B614")]
		[DebuggerHidden]
		public <CancelWith>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xE8C740", Offset = "0xE8C740", VA = "0xE8C740", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xE8C744", Offset = "0xE8C744", VA = "0xE8C744", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xE8C984", Offset = "0xE8C984", VA = "0xE8C984", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class <CancelWith>d__6<T> : IEnumerator<float>, IEnumerator, IDisposable where T : MonoBehaviour
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T script;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GameObject <myGO>5__2;

		[Token(Token = "0x1700000D")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600003D")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600003F")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003A")]
		[DebuggerHidden]
		public <CancelWith>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600003B")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600003C")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600003E")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class <CancelWith>d__7 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700000F")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0xE8CC0C", Offset = "0xE8CC0C", VA = "0xE8CC0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000010")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0xE8CC54", Offset = "0xE8CC54", VA = "0xE8CC54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xE8B6B0", Offset = "0xE8B6B0", VA = "0xE8B6B0")]
		[DebuggerHidden]
		public <CancelWith>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xE8CA20", Offset = "0xE8CA20", VA = "0xE8CA20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xE8CA24", Offset = "0xE8CA24", VA = "0xE8CA24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xE8CC14", Offset = "0xE8CC14", VA = "0xE8CC14", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class <PauseWith>d__8 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000011")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0xE8CEC8", Offset = "0xE8CEC8", VA = "0xE8CEC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000012")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0xE8CF10", Offset = "0xE8CF10", VA = "0xE8CF10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xE8B74C", Offset = "0xE8B74C", VA = "0xE8B74C")]
		[DebuggerHidden]
		public <PauseWith>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xE8CCB0", Offset = "0xE8CCB0", VA = "0xE8CCB0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xE8CCB4", Offset = "0xE8CCB4", VA = "0xE8CCB4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xE8CED0", Offset = "0xE8CED0", VA = "0xE8CED0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class <PauseWith>d__9 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject1;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject2;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000013")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0xE8D1BC", Offset = "0xE8D1BC", VA = "0xE8D1BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000014")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0xE8D204", Offset = "0xE8D204", VA = "0xE8D204", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xE8B7F0", Offset = "0xE8B7F0", VA = "0xE8B7F0")]
		[DebuggerHidden]
		public <PauseWith>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xE8CF6C", Offset = "0xE8CF6C", VA = "0xE8CF6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xE8CF70", Offset = "0xE8CF70", VA = "0xE8CF70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xE8D1C4", Offset = "0xE8D1C4", VA = "0xE8D1C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class <PauseWith>d__10<T> : IEnumerator<float>, IEnumerator, IDisposable where T : MonoBehaviour
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T script;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GameObject <myGO>5__2;

		[Token(Token = "0x17000015")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000055")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000016")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000057")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000052")]
		[DebuggerHidden]
		public <PauseWith>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x6000053")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000054")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class <PauseWith>d__11 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000017")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0xE8D44C", Offset = "0xE8D44C", VA = "0xE8D44C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000018")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0xE8D494", Offset = "0xE8D494", VA = "0xE8D494", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xE8B88C", Offset = "0xE8B88C", VA = "0xE8B88C")]
		[DebuggerHidden]
		public <PauseWith>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xE8D260", Offset = "0xE8D260", VA = "0xE8D260", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xE8D264", Offset = "0xE8D264", VA = "0xE8D264", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xE8D454", Offset = "0xE8D454", VA = "0xE8D454", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class <KillWith>d__12 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CoroutineHandle otherCoroutine;

		[Token(Token = "0x17000019")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0xE8D6A0", Offset = "0xE8D6A0", VA = "0xE8D6A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0xE8D6E8", Offset = "0xE8D6E8", VA = "0xE8D6E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xE8B92C", Offset = "0xE8B92C", VA = "0xE8B92C")]
		[DebuggerHidden]
		public <KillWith>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xE8D4F0", Offset = "0xE8D4F0", VA = "0xE8D4F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xE8D4F4", Offset = "0xE8D4F4", VA = "0xE8D4F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xE8D6A8", Offset = "0xE8D6A8", VA = "0xE8D6A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class <Append>d__13 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> nextCoroutine;

		[Token(Token = "0x1700001B")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0xE8D984", Offset = "0xE8D984", VA = "0xE8D984", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0xE8D9CC", Offset = "0xE8D9CC", VA = "0xE8D9CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xE8B9C8", Offset = "0xE8B9C8", VA = "0xE8B9C8")]
		[DebuggerHidden]
		public <Append>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xE8D744", Offset = "0xE8D744", VA = "0xE8D744", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xE8D748", Offset = "0xE8D748", VA = "0xE8D748", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xE8D98C", Offset = "0xE8D98C", VA = "0xE8D98C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class <Append>d__14 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action onDone;

		[Token(Token = "0x1700001D")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0xE8DB88", Offset = "0xE8DB88", VA = "0xE8DB88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0xE8DBD0", Offset = "0xE8DBD0", VA = "0xE8DBD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xE8BA64", Offset = "0xE8BA64", VA = "0xE8BA64")]
		[DebuggerHidden]
		public <Append>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xE8DA28", Offset = "0xE8DA28", VA = "0xE8DA28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xE8DA2C", Offset = "0xE8DA2C", VA = "0xE8DA2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xE8DB90", Offset = "0xE8DB90", VA = "0xE8DB90", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class <Prepend>d__15 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> lastCoroutine;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700001F")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0xE8DE80", Offset = "0xE8DE80", VA = "0xE8DE80", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0xE8DEC8", Offset = "0xE8DEC8", VA = "0xE8DEC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xE8BB00", Offset = "0xE8BB00", VA = "0xE8BB00")]
		[DebuggerHidden]
		public <Prepend>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xE8DC2C", Offset = "0xE8DC2C", VA = "0xE8DC2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xE8DC30", Offset = "0xE8DC30", VA = "0xE8DC30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xE8DE88", Offset = "0xE8DE88", VA = "0xE8DE88", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class <Prepend>d__16 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onStart;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000021")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0xE8E094", Offset = "0xE8E094", VA = "0xE8E094", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0xE8E0DC", Offset = "0xE8E0DC", VA = "0xE8E0DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xE8BB9C", Offset = "0xE8BB9C", VA = "0xE8BB9C")]
		[DebuggerHidden]
		public <Prepend>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xE8DF24", Offset = "0xE8DF24", VA = "0xE8DF24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xE8DF28", Offset = "0xE8DF28", VA = "0xE8DF28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xE8E09C", Offset = "0xE8E09C", VA = "0xE8E09C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class <Superimpose>d__18 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutineA;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Timing instance;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> coroutineB;

		[Token(Token = "0x17000023")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0xE8E764", Offset = "0xE8E764", VA = "0xE8E764", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0xE8E7AC", Offset = "0xE8E7AC", VA = "0xE8E7AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xE8BCB0", Offset = "0xE8BCB0", VA = "0xE8BCB0")]
		[DebuggerHidden]
		public <Superimpose>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xE8E138", Offset = "0xE8E138", VA = "0xE8E138", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xE8E13C", Offset = "0xE8E13C", VA = "0xE8E13C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xE8E76C", Offset = "0xE8E76C", VA = "0xE8E76C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class <Hijack>d__19 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<float, float> newReturn;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000025")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0xE8E980", Offset = "0xE8E980", VA = "0xE8E980", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0xE8E9C8", Offset = "0xE8E9C8", VA = "0xE8E9C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xE8BD4C", Offset = "0xE8BD4C", VA = "0xE8BD4C")]
		[DebuggerHidden]
		public <Hijack>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xE8E808", Offset = "0xE8E808", VA = "0xE8E808", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xE8E80C", Offset = "0xE8E80C", VA = "0xE8E80C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xE8E988", Offset = "0xE8E988", VA = "0xE8E988", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class <RerouteExceptions>d__20 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<Exception> exceptionHandler;

		[Token(Token = "0x17000027")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0xE8EC00", Offset = "0xE8EC00", VA = "0xE8EC00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0xE8EC48", Offset = "0xE8EC48", VA = "0xE8EC48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xE8BDE8", Offset = "0xE8BDE8", VA = "0xE8BDE8")]
		[DebuggerHidden]
		public <RerouteExceptions>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xE8EA24", Offset = "0xE8EA24", VA = "0xE8EA24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xE8EA28", Offset = "0xE8EA28", VA = "0xE8EA28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xE8EC08", Offset = "0xE8EC08", VA = "0xE8EC08", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xE8B320", Offset = "0xE8B320", VA = "0xE8B320")]
	[IteratorStateMachine(typeof(<Delay>d__0))]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, float timeToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xE8B3C0", Offset = "0xE8B3C0", VA = "0xE8B3C0")]
	[IteratorStateMachine(typeof(<Delay>d__1))]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[IteratorStateMachine(typeof(<Delay>d__2<>))]
	public static IEnumerator<float> Delay<T>(this IEnumerator<float> coroutine, T data, Func<T, bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xE8B45C", Offset = "0xE8B45C", VA = "0xE8B45C")]
	[IteratorStateMachine(typeof(<DelayFrames>d__3))]
	public static IEnumerator<float> DelayFrames(this IEnumerator<float> coroutine, int framesToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xE8B4FC", Offset = "0xE8B4FC", VA = "0xE8B4FC")]
	[IteratorStateMachine(typeof(<CancelWith>d__4))]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xE8B598", Offset = "0xE8B598", VA = "0xE8B598")]
	[IteratorStateMachine(typeof(<CancelWith>d__5))]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[IteratorStateMachine(typeof(<CancelWith>d__6<>))]
	public static IEnumerator<float> CancelWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xE8B63C", Offset = "0xE8B63C", VA = "0xE8B63C")]
	[IteratorStateMachine(typeof(<CancelWith>d__7))]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xE8B6D8", Offset = "0xE8B6D8", VA = "0xE8B6D8")]
	[IteratorStateMachine(typeof(<PauseWith>d__8))]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xE8B774", Offset = "0xE8B774", VA = "0xE8B774")]
	[IteratorStateMachine(typeof(<PauseWith>d__9))]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[IteratorStateMachine(typeof(<PauseWith>d__10<>))]
	public static IEnumerator<float> PauseWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xE8B818", Offset = "0xE8B818", VA = "0xE8B818")]
	[IteratorStateMachine(typeof(<PauseWith>d__11))]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xE8B8B4", Offset = "0xE8B8B4", VA = "0xE8B8B4")]
	[IteratorStateMachine(typeof(<KillWith>d__12))]
	public static IEnumerator<float> KillWith(this IEnumerator<float> coroutine, CoroutineHandle otherCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xE8B954", Offset = "0xE8B954", VA = "0xE8B954")]
	[IteratorStateMachine(typeof(<Append>d__13))]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, IEnumerator<float> nextCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xE8B9F0", Offset = "0xE8B9F0", VA = "0xE8B9F0")]
	[IteratorStateMachine(typeof(<Append>d__14))]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xE8BA8C", Offset = "0xE8BA8C", VA = "0xE8BA8C")]
	[IteratorStateMachine(typeof(<Prepend>d__15))]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, IEnumerator<float> lastCoroutine)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xE8BB28", Offset = "0xE8BB28", VA = "0xE8BB28")]
	[IteratorStateMachine(typeof(<Prepend>d__16))]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, Action onStart)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xE8BBC4", Offset = "0xE8BBC4", VA = "0xE8BBC4")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xE8BC34", Offset = "0xE8BC34", VA = "0xE8BC34")]
	[IteratorStateMachine(typeof(<Superimpose>d__18))]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB, Timing instance)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xE8BCD8", Offset = "0xE8BCD8", VA = "0xE8BCD8")]
	[IteratorStateMachine(typeof(<Hijack>d__19))]
	public static IEnumerator<float> Hijack(this IEnumerator<float> coroutine, Func<float, float> newReturn)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xE8BD74", Offset = "0xE8BD74", VA = "0xE8BD74")]
	[IteratorStateMachine(typeof(<RerouteExceptions>d__20))]
	public static IEnumerator<float> RerouteExceptions(this IEnumerator<float> coroutine, Action<Exception> exceptionHandler)
	{
		return null;
	}
}
namespace MEC;

[Token(Token = "0x2000017")]
public class Timing : MonoBehaviour
{
	[Token(Token = "0x2000018")]
	private struct ProcessIndex : IEquatable<ProcessIndex>
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Segment seg;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int i;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xE8ECA4", Offset = "0xE8ECA4", VA = "0xE8ECA4", Slot = "4")]
		public bool Equals(ProcessIndex other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xE8ECCC", Offset = "0xE8ECCC", VA = "0xE8ECCC", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xE8ED54", Offset = "0xE8ED54", VA = "0xE8ED54")]
		public static bool operator ==(ProcessIndex a, ProcessIndex b)
		{
			return default(bool);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xE8ED74", Offset = "0xE8ED74", VA = "0xE8ED74")]
		public static bool operator !=(ProcessIndex a, ProcessIndex b)
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xE8ED94", Offset = "0xE8ED94", VA = "0xE8ED94", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class <_EOFPumpWatcher>d__132 : IEnumerator<float>, IEnumerator, IDisposable
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

		[Token(Token = "0x1700002F")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0xE8EE6C", Offset = "0xE8EE6C", VA = "0xE8EE6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0xE8EEB4", Offset = "0xE8EEB4", VA = "0xE8EEB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xE8EDB4", Offset = "0xE8EDB4", VA = "0xE8EDB4")]
		[DebuggerHidden]
		public <_EOFPumpWatcher>d__132(int <>1__state)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xE8EDDC", Offset = "0xE8EDDC", VA = "0xE8EDDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xE8EDE0", Offset = "0xE8EDE0", VA = "0xE8EDE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xE8EE74", Offset = "0xE8EE74", VA = "0xE8EE74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class <_EOFPump>d__133 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Timing <>4__this;

		[Token(Token = "0x17000031")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0xE8F6B8", Offset = "0xE8F6B8", VA = "0xE8F6B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0xE8F700", Offset = "0xE8F700", VA = "0xE8F700", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xE8EF10", Offset = "0xE8EF10", VA = "0xE8EF10")]
		[DebuggerHidden]
		public <_EOFPump>d__133(int <>1__state)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xE8EF38", Offset = "0xE8EF38", VA = "0xE8EF38", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xE8EF3C", Offset = "0xE8EF3C", VA = "0xE8EF3C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xE8F6C0", Offset = "0xE8F6C0", VA = "0xE8F6C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class <_StartWhenDone>d__275 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Timing <>4__this;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CoroutineHandle handle;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> proc;

		[Token(Token = "0x17000033")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0xE8FAD8", Offset = "0xE8FAD8", VA = "0xE8FAD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xE8FB20", Offset = "0xE8FB20", VA = "0xE8FB20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xE8F708", Offset = "0xE8F708", VA = "0xE8F708")]
		[DebuggerHidden]
		public <_StartWhenDone>d__275(int <>1__state)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xE8F730", Offset = "0xE8F730", VA = "0xE8F730", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xE8F75C", Offset = "0xE8F75C", VA = "0xE8F75C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xE8FAAC", Offset = "0xE8FAAC", VA = "0xE8FAAC")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xE8FAE0", Offset = "0xE8FAE0", VA = "0xE8FAE0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class <_StartWhenDone>d__280 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AsyncOperation operation;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> pausedProc;

		[Token(Token = "0x17000035")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xE8FCC8", Offset = "0xE8FCC8", VA = "0xE8FCC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000036")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xE8FD10", Offset = "0xE8FD10", VA = "0xE8FD10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xE8FB7C", Offset = "0xE8FB7C", VA = "0xE8FB7C")]
		[DebuggerHidden]
		public <_StartWhenDone>d__280(int <>1__state)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xE8FBA4", Offset = "0xE8FBA4", VA = "0xE8FBA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xE8FBA8", Offset = "0xE8FBA8", VA = "0xE8FBA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xE8FCD0", Offset = "0xE8FCD0", VA = "0xE8FCD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class <_StartWhenDone>d__282 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CustomYieldInstruction operation;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> pausedProc;

		[Token(Token = "0x17000037")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xE8FEBC", Offset = "0xE8FEBC", VA = "0xE8FEBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000038")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0xE8FF04", Offset = "0xE8FF04", VA = "0xE8FF04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xE8FD6C", Offset = "0xE8FD6C", VA = "0xE8FD6C")]
		[DebuggerHidden]
		public <_StartWhenDone>d__282(int <>1__state)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xE8FD94", Offset = "0xE8FD94", VA = "0xE8FD94", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xE8FD98", Offset = "0xE8FD98", VA = "0xE8FD98", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xE8FEC4", Offset = "0xE8FEC4", VA = "0xE8FEC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class <_StartWhenDone>d__287 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> evaluatorFunc;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool continueOn;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> pausedProc;

		[Token(Token = "0x17000039")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xE900C0", Offset = "0xE900C0", VA = "0xE900C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xE90108", Offset = "0xE90108", VA = "0xE90108", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xE8FF60", Offset = "0xE8FF60", VA = "0xE8FF60")]
		[DebuggerHidden]
		public <_StartWhenDone>d__287(int <>1__state)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xE8FF88", Offset = "0xE8FF88", VA = "0xE8FF88", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xE8FF8C", Offset = "0xE8FF8C", VA = "0xE8FF8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xE900C8", Offset = "0xE900C8", VA = "0xE900C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class <_InjectDelay>d__288 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Timing <>4__this;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float waitTime;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> proc;

		[Token(Token = "0x1700003B")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0xE902B8", Offset = "0xE902B8", VA = "0xE902B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xE90300", Offset = "0xE90300", VA = "0xE90300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xE90164", Offset = "0xE90164", VA = "0xE90164")]
		[DebuggerHidden]
		public <_InjectDelay>d__288(int <>1__state)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xE9018C", Offset = "0xE9018C", VA = "0xE9018C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xE90190", Offset = "0xE90190", VA = "0xE90190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xE902C0", Offset = "0xE902C0", VA = "0xE902C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class <_DelayedCall>d__313 : IEnumerator<float>, IEnumerator, IDisposable
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
		public float delay;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject cancelWith;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action action;

		[Token(Token = "0x1700003D")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0xE90458", Offset = "0xE90458", VA = "0xE90458", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0xE904A0", Offset = "0xE904A0", VA = "0xE904A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xE9035C", Offset = "0xE9035C", VA = "0xE9035C")]
		[DebuggerHidden]
		public <_DelayedCall>d__313(int <>1__state)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xE90384", Offset = "0xE90384", VA = "0xE90384", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xE90388", Offset = "0xE90388", VA = "0xE90388", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xE90460", Offset = "0xE90460", VA = "0xE90460", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class <_WatchCall>d__334 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Timing <>4__this;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float timeframe;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public CoroutineHandle handle;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onDone;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject gObject;

		[Token(Token = "0x1700003F")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0xE90610", Offset = "0xE90610", VA = "0xE90610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000040")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0xE90658", Offset = "0xE90658", VA = "0xE90658", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE904FC", Offset = "0xE904FC", VA = "0xE904FC")]
		[DebuggerHidden]
		public <_WatchCall>d__334(int <>1__state)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE90524", Offset = "0xE90524", VA = "0xE90524", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xE90528", Offset = "0xE90528", VA = "0xE90528", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xE90618", Offset = "0xE90618", VA = "0xE90618", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class <_CallContinuously>d__335 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Timing <>4__this;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float period;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gObject;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action action;

		[Token(Token = "0x17000041")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0xE90800", Offset = "0xE90800", VA = "0xE90800", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000042")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0xE90848", Offset = "0xE90848", VA = "0xE90848", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xE906B4", Offset = "0xE906B4", VA = "0xE906B4")]
		[DebuggerHidden]
		public <_CallContinuously>d__335(int <>1__state)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xE906DC", Offset = "0xE906DC", VA = "0xE906DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xE906E0", Offset = "0xE906E0", VA = "0xE906E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xE90808", Offset = "0xE90808", VA = "0xE90808", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class <_WatchCall>d__352<T> : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Timing <>4__this;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float timeframe;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public CoroutineHandle handle;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> onDone;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject gObject;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T reference;

		[Token(Token = "0x17000043")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001DD")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000044")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001DF")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DA")]
		[DebuggerHidden]
		public <_WatchCall>d__352(int <>1__state)
		{
		}

		[Token(Token = "0x60001DB")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001DC")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DE")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class <_CallContinuously>d__353<T> : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Timing <>4__this;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float period;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public GameObject gObject;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> action;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T reference;

		[Token(Token = "0x17000045")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60001E3")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000046")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E5")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E0")]
		[DebuggerHidden]
		public <_CallContinuously>d__353(int <>1__state)
		{
		}

		[Token(Token = "0x60001E1")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E2")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E4")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("How quickly the SlowUpdate segment ticks.")]
	public float TimeBetweenSlowUpdateCalls;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("How much data should be sent to the profiler window when it's open.")]
	public DebugInfoType ProfilerDebugAmount;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("When using manual timeframe, should it run automatically after the update loop or only when TriggerManualTimframeUpdate is called.")]
	public bool AutoTriggerManualTimeframe;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space(12f)]
	[Tooltip("A count of the number of Update coroutines that are currently running.")]
	public int UpdateCoroutines;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("A count of the number of FixedUpdate coroutines that are currently running.")]
	public int FixedUpdateCoroutines;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("A count of the number of LateUpdate coroutines that are currently running.")]
	public int LateUpdateCoroutines;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("A count of the number of SlowUpdate coroutines that are currently running.")]
	public int SlowUpdateCoroutines;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("A count of the number of RealtimeUpdate coroutines that are currently running.")]
	public int RealtimeUpdateCoroutines;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("A count of the number of EditorUpdate coroutines that are currently running.")]
	public int EditorUpdateCoroutines;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[Tooltip("A count of the number of EditorSlowUpdate coroutines that are currently running.")]
	public int EditorSlowUpdateCoroutines;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("A count of the number of EndOfFrame coroutines that are currently running.")]
	public int EndOfFrameCoroutines;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("A count of the number of ManualTimeframe coroutines that are currently running.")]
	public int ManualTimeframeCoroutines;

	[NonSerialized]
	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float localTime;

	[NonSerialized]
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float deltaTime;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Func<float, float> SetManualTimeframeTime;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Func<IEnumerator<float>, CoroutineHandle, IEnumerator<float>> ReplacementFunction;

	[Token(Token = "0x4000068")]
	public const float WaitForOneFrame = float.NegativeInfinity;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static object _tmpRef;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static int _tmpInt;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static bool _tmpBool;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static Segment _tmpSegment;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static CoroutineHandle _tmpHandle;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int _currentUpdateFrame;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int _currentLateUpdateFrame;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int _currentSlowUpdateFrame;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int _currentRealtimeUpdateFrame;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int _currentEndOfFrameFrame;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int _nextUpdateProcessSlot;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int _nextLateUpdateProcessSlot;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int _nextFixedUpdateProcessSlot;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int _nextSlowUpdateProcessSlot;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int _nextRealtimeUpdateProcessSlot;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int _nextEditorUpdateProcessSlot;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int _nextEditorSlowUpdateProcessSlot;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int _nextEndOfFrameProcessSlot;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int _nextManualTimeframeProcessSlot;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int _lastUpdateProcessSlot;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int _lastLateUpdateProcessSlot;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int _lastFixedUpdateProcessSlot;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int _lastSlowUpdateProcessSlot;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private int _lastRealtimeUpdateProcessSlot;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int _lastEndOfFrameProcessSlot;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private int _lastManualTimeframeProcessSlot;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float _lastUpdateTime;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float _lastLateUpdateTime;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float _lastFixedUpdateTime;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private float _lastSlowUpdateTime;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float _lastRealtimeUpdateTime;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float _lastEndOfFrameTime;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float _lastManualTimeframeTime;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float _lastSlowUpdateDeltaTime;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float _lastEditorUpdateDeltaTime;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private float _lastEditorSlowUpdateDeltaTime;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float _lastManualTimeframeDeltaTime;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private ushort _framesSinceUpdate;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDE")]
	private ushort _expansions;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[HideInInspector]
	[SerializeField]
	private byte _instanceID;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
	private bool _EOFPumpRan;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> Links;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly WaitForEndOfFrame EofWaitObject;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> _waitingTriggers;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly HashSet<CoroutineHandle> _allWaiting;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly Dictionary<CoroutineHandle, ProcessIndex> _handleToIndex;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly Dictionary<ProcessIndex, CoroutineHandle> _indexToHandle;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly Dictionary<CoroutineHandle, string> _processTags;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly Dictionary<string, HashSet<CoroutineHandle>> _taggedProcesses;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly Dictionary<CoroutineHandle, int> _processLayers;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly Dictionary<int, HashSet<CoroutineHandle>> _layeredProcesses;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private IEnumerator<float>[] UpdateProcesses;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private IEnumerator<float>[] LateUpdateProcesses;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private IEnumerator<float>[] FixedUpdateProcesses;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private IEnumerator<float>[] SlowUpdateProcesses;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private IEnumerator<float>[] RealtimeUpdateProcesses;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private IEnumerator<float>[] EditorUpdateProcesses;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private IEnumerator<float>[] EditorSlowUpdateProcesses;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private IEnumerator<float>[] EndOfFrameProcesses;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private IEnumerator<float>[] ManualTimeframeProcesses;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private bool[] UpdatePaused;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private bool[] LateUpdatePaused;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private bool[] FixedUpdatePaused;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private bool[] SlowUpdatePaused;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private bool[] RealtimeUpdatePaused;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private bool[] EditorUpdatePaused;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private bool[] EditorSlowUpdatePaused;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private bool[] EndOfFramePaused;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private bool[] ManualTimeframePaused;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private bool[] UpdateHeld;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private bool[] LateUpdateHeld;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private bool[] FixedUpdateHeld;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private bool[] SlowUpdateHeld;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private bool[] RealtimeUpdateHeld;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private bool[] EditorUpdateHeld;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private bool[] EditorSlowUpdateHeld;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private bool[] EndOfFrameHeld;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private bool[] ManualTimeframeHeld;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	private CoroutineHandle _eofWatcherHandle;

	[Token(Token = "0x40000BA")]
	private const ushort FramesUntilMaintenance = 64;

	[Token(Token = "0x40000BB")]
	private const int ProcessArrayChunkSize = 64;

	[Token(Token = "0x40000BC")]
	private const int InitialBufferSizeLarge = 256;

	[Token(Token = "0x40000BD")]
	private const int InitialBufferSizeMedium = 64;

	[Token(Token = "0x40000BE")]
	private const int InitialBufferSizeSmall = 8;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static Timing[] ActiveInstances;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static Timing _instance;

	[Token(Token = "0x17000029")]
	public static float LocalTime
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0xE6EAD4", Offset = "0xE6EAD4", VA = "0xE6EAD4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700002A")]
	public static float DeltaTime
	{
		[Token(Token = "0x600008F")]
		[Address(RVA = "0xE6ED58", Offset = "0xE6ED58", VA = "0xE6ED58")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700002B")]
	public static Thread MainThread
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0xE6EF6C", Offset = "0xE6EF6C", VA = "0xE6EF6C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000093")]
		[Address(RVA = "0xE6EFC4", Offset = "0xE6EFC4", VA = "0xE6EFC4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	public static CoroutineHandle CurrentCoroutine
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0xE6F020", Offset = "0xE6F020", VA = "0xE6F020")]
		get
		{
			return default(CoroutineHandle);
		}
	}

	[Token(Token = "0x1700002D")]
	public CoroutineHandle currentCoroutine
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0xE6F1A8", Offset = "0xE6F1A8", VA = "0xE6F1A8")]
		[CompilerGenerated]
		get
		{
			return default(CoroutineHandle);
		}
		[Token(Token = "0x6000096")]
		[Address(RVA = "0xE6F1B0", Offset = "0xE6F1B0", VA = "0xE6F1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public static Timing Instance
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0xE6EB30", Offset = "0xE6EB30", VA = "0xE6EB30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000098")]
		[Address(RVA = "0xE6F3E8", Offset = "0xE6F3E8", VA = "0xE6F3E8")]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public static event Action OnPreExecute
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0xE6EDB4", Offset = "0xE6EDB4", VA = "0xE6EDB4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000091")]
		[Address(RVA = "0xE6EE90", Offset = "0xE6EE90", VA = "0xE6EE90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xE6F444", Offset = "0xE6F444", VA = "0xE6F444")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xE6F4F8", Offset = "0xE6F4F8", VA = "0xE6F4F8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xE6F914", Offset = "0xE6F914", VA = "0xE6F914")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xE6F1B8", Offset = "0xE6F1B8", VA = "0xE6F1B8")]
	private void InitializeInstanceID()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xE6F9C0", Offset = "0xE6F9C0", VA = "0xE6F9C0")]
	private void Update()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xE72FF4", Offset = "0xE72FF4", VA = "0xE72FF4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xE736F8", Offset = "0xE736F8", VA = "0xE736F8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xE711E0", Offset = "0xE711E0", VA = "0xE711E0")]
	public void TriggerManualTimeframeUpdate()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xE6F63C", Offset = "0xE6F63C", VA = "0xE6F63C")]
	private bool OnEditorStart()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xE6F644", Offset = "0xE6F644", VA = "0xE6F644")]
	[IteratorStateMachine(typeof(<_EOFPumpWatcher>d__132))]
	private IEnumerator<float> _EOFPumpWatcher()
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xE73DF8", Offset = "0xE73DF8", VA = "0xE73DF8")]
	[IteratorStateMachine(typeof(<_EOFPump>d__133))]
	private IEnumerator _EOFPump()
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xE71904", Offset = "0xE71904", VA = "0xE71904")]
	private void RemoveUnused()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xE743B4", Offset = "0xE743B4", VA = "0xE743B4")]
	private void EditorRemoveUnused()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xE74B98", Offset = "0xE74B98", VA = "0xE74B98")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xE773EC", Offset = "0xE773EC", VA = "0xE773EC")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xE77548", Offset = "0xE77548", VA = "0xE77548")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xE77604", Offset = "0xE77604", VA = "0xE77604")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xE776C0", Offset = "0xE776C0", VA = "0xE776C0")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xE77820", Offset = "0xE77820", VA = "0xE77820")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xE778E8", Offset = "0xE778E8", VA = "0xE778E8")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xE779A4", Offset = "0xE779A4", VA = "0xE779A4")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xE77B04", Offset = "0xE77B04", VA = "0xE77B04")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xE77BCC", Offset = "0xE77BCC", VA = "0xE77BCC")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xE77C94", Offset = "0xE77C94", VA = "0xE77C94")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xE77E00", Offset = "0xE77E00", VA = "0xE77E00")]
	public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xE77ECC", Offset = "0xE77ECC", VA = "0xE77ECC")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xE77F38", Offset = "0xE77F38", VA = "0xE77F38")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xE78044", Offset = "0xE78044", VA = "0xE78044")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xE780B4", Offset = "0xE780B4", VA = "0xE780B4")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xE78124", Offset = "0xE78124", VA = "0xE78124")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xE7823C", Offset = "0xE7823C", VA = "0xE7823C")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xE782B8", Offset = "0xE782B8", VA = "0xE782B8")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xE78328", Offset = "0xE78328", VA = "0xE78328")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xE78440", Offset = "0xE78440", VA = "0xE78440")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xE784BC", Offset = "0xE784BC", VA = "0xE784BC")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xE78538", Offset = "0xE78538", VA = "0xE78538")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xE78654", Offset = "0xE78654", VA = "0xE78654")]
	public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xE786D4", Offset = "0xE786D4", VA = "0xE786D4")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xE78F18", Offset = "0xE78F18", VA = "0xE78F18")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xE78FFC", Offset = "0xE78FFC", VA = "0xE78FFC")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xE79D48", Offset = "0xE79D48", VA = "0xE79D48")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xE7A0F4", Offset = "0xE7A0F4", VA = "0xE7A0F4")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xE7A1F0", Offset = "0xE7A1F0", VA = "0xE7A1F0")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xE7A8DC", Offset = "0xE7A8DC", VA = "0xE7A8DC")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xE7AA8C", Offset = "0xE7AA8C", VA = "0xE7AA8C")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xE7AB84", Offset = "0xE7AB84", VA = "0xE7AB84")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xE7AE74", Offset = "0xE7AE74", VA = "0xE7AE74")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xE7B164", Offset = "0xE7B164", VA = "0xE7B164")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xE7B26C", Offset = "0xE7B26C", VA = "0xE7B26C")]
	public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xE7B79C", Offset = "0xE7B79C", VA = "0xE7B79C")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xE7BBE4", Offset = "0xE7BBE4", VA = "0xE7BBE4")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xE7BCA0", Offset = "0xE7BCA0", VA = "0xE7BCA0")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xE6F6AC", Offset = "0xE6F6AC", VA = "0xE6F6AC")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xE7C460", Offset = "0xE7C460", VA = "0xE7C460")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xE7C52C", Offset = "0xE7C52C", VA = "0xE7C52C")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xE7D138", Offset = "0xE7D138", VA = "0xE7D138")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xE7D200", Offset = "0xE7D200", VA = "0xE7D200")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xE7D46C", Offset = "0xE7D46C", VA = "0xE7D46C")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xE7D6D8", Offset = "0xE7D6D8", VA = "0xE7D6D8")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xE7D7B8", Offset = "0xE7D7B8", VA = "0xE7D7B8")]
	public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xE74C50", Offset = "0xE74C50", VA = "0xE74C50")]
	private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, int layer, bool layerHasValue, string tag, CoroutineHandle handle, bool prewarm)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xE7DEB4", Offset = "0xE7DEB4", VA = "0xE7DEB4")]
	public static int KillCoroutines()
	{
		return default(int);
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xE7DF7C", Offset = "0xE7DF7C", VA = "0xE7DF7C")]
	public int KillCoroutinesOnInstance()
	{
		return default(int);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xE78878", Offset = "0xE78878", VA = "0xE78878")]
	public static int KillCoroutines(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xE7E40C", Offset = "0xE7E40C", VA = "0xE7E40C")]
	public static int KillCoroutines(params CoroutineHandle[] handles)
	{
		return default(int);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xE70FC4", Offset = "0xE70FC4", VA = "0xE70FC4")]
	public int KillCoroutinesOnInstance(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xE7E5FC", Offset = "0xE7E5FC", VA = "0xE7E5FC")]
	public static int KillCoroutines(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xE7E6E0", Offset = "0xE7E6E0", VA = "0xE7E6E0")]
	public int KillCoroutinesOnInstance(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xE792D8", Offset = "0xE792D8", VA = "0xE792D8")]
	public static int KillCoroutines(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xE7BF08", Offset = "0xE7BF08", VA = "0xE7BF08")]
	public int KillCoroutinesOnInstance(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xE7A024", Offset = "0xE7A024", VA = "0xE7A024")]
	public static int KillCoroutines(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xE7C19C", Offset = "0xE7C19C", VA = "0xE7C19C")]
	public int KillCoroutinesOnInstance(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xE7E808", Offset = "0xE7E808", VA = "0xE7E808")]
	public static int KillCoroutines(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xE7E900", Offset = "0xE7E900", VA = "0xE7E900")]
	public int KillCoroutinesOnInstance(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xE7A714", Offset = "0xE7A714", VA = "0xE7A714")]
	public static int KillCoroutines(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xE7C94C", Offset = "0xE7C94C", VA = "0xE7C94C")]
	public int KillCoroutinesOnInstance(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xE7E37C", Offset = "0xE7E37C", VA = "0xE7E37C")]
	public static Timing GetInstance(byte ID)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xE7E93C", Offset = "0xE7E93C", VA = "0xE7E93C")]
	public static float WaitForSeconds(float waitTime)
	{
		return default(float);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xE7E9E4", Offset = "0xE7E9E4", VA = "0xE7E9E4")]
	public float WaitForSecondsOnInstance(float waitTime)
	{
		return default(float);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xE70CE4", Offset = "0xE70CE4", VA = "0xE70CE4")]
	private bool UpdateTimeValues(Segment segment)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xE7EA60", Offset = "0xE7EA60", VA = "0xE7EA60")]
	private float GetSegmentTime(Segment segment)
	{
		return default(float);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xE7EB4C", Offset = "0xE7EB4C", VA = "0xE7EB4C")]
	public static int PauseCoroutines()
	{
		return default(int);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xE7EC14", Offset = "0xE7EC14", VA = "0xE7EC14")]
	public int PauseCoroutinesOnInstance()
	{
		return default(int);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xE7FDD8", Offset = "0xE7FDD8", VA = "0xE7FDD8")]
	public int PauseCoroutinesOnInstance(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xE7FD08", Offset = "0xE7FD08", VA = "0xE7FD08")]
	public static int PauseCoroutines(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xE80C8C", Offset = "0xE80C8C", VA = "0xE80C8C")]
	public static int PauseCoroutines(params CoroutineHandle[] handles)
	{
		return default(int);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xE80E18", Offset = "0xE80E18", VA = "0xE80E18")]
	public static int PauseCoroutines(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xE80EE8", Offset = "0xE80EE8", VA = "0xE80EE8")]
	public int PauseCoroutinesOnInstance(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xE812A4", Offset = "0xE812A4", VA = "0xE812A4")]
	public static int PauseCoroutines(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xE80F88", Offset = "0xE80F88", VA = "0xE80F88")]
	public int PauseCoroutinesOnInstance(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xE81374", Offset = "0xE81374", VA = "0xE81374")]
	public static int PauseCoroutines(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xE81444", Offset = "0xE81444", VA = "0xE81444")]
	public int PauseCoroutinesOnInstance(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xE81764", Offset = "0xE81764", VA = "0xE81764")]
	public static int PauseCoroutines(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xE81C30", Offset = "0xE81C30", VA = "0xE81C30")]
	public int PauseCoroutinesOnInstance(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xE81CD8", Offset = "0xE81CD8", VA = "0xE81CD8")]
	public static int PauseCoroutines(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xE8185C", Offset = "0xE8185C", VA = "0xE8185C")]
	public int PauseCoroutinesOnInstance(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xE81DBC", Offset = "0xE81DBC", VA = "0xE81DBC")]
	public static int ResumeCoroutines()
	{
		return default(int);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xE81E84", Offset = "0xE81E84", VA = "0xE81E84")]
	public int ResumeCoroutinesOnInstance()
	{
		return default(int);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xE78AA0", Offset = "0xE78AA0", VA = "0xE78AA0")]
	public static int ResumeCoroutines(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xE823D8", Offset = "0xE823D8", VA = "0xE823D8")]
	public static int ResumeCoroutines(params CoroutineHandle[] handles)
	{
		return default(int);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xE7B950", Offset = "0xE7B950", VA = "0xE7B950")]
	public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
	{
		return default(int);
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xE793A8", Offset = "0xE793A8", VA = "0xE793A8")]
	public int ResumeCoroutinesOnInstance(IEnumerable<CoroutineHandle> handles)
	{
		return default(int);
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xE82564", Offset = "0xE82564", VA = "0xE82564")]
	public static int ResumeCoroutines(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xE82960", Offset = "0xE82960", VA = "0xE82960")]
	public int ResumeCoroutinesOnInstance(GameObject gameObj)
	{
		return default(int);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xE82A00", Offset = "0xE82A00", VA = "0xE82A00")]
	public static int ResumeCoroutines(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xE82648", Offset = "0xE82648", VA = "0xE82648")]
	public int ResumeCoroutinesOnInstance(int layer)
	{
		return default(int);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xE82AD0", Offset = "0xE82AD0", VA = "0xE82AD0")]
	public static int ResumeCoroutines(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xE82BA0", Offset = "0xE82BA0", VA = "0xE82BA0")]
	public int ResumeCoroutinesOnInstance(string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xE82EBC", Offset = "0xE82EBC", VA = "0xE82EBC")]
	public static int ResumeCoroutines(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xE82FB4", Offset = "0xE82FB4", VA = "0xE82FB4")]
	public int ResumeCoroutinesOnInstance(GameObject gameObj, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xE7A7F8", Offset = "0xE7A7F8", VA = "0xE7A7F8")]
	public static int ResumeCoroutines(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xE7CD74", Offset = "0xE7CD74", VA = "0xE7CD74")]
	public int ResumeCoroutinesOnInstance(int layer, string tag)
	{
		return default(int);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xE8305C", Offset = "0xE8305C", VA = "0xE8305C")]
	public static string GetTag(CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xE831A0", Offset = "0xE831A0", VA = "0xE831A0")]
	public static int? GetLayer(CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xE83314", Offset = "0xE83314", VA = "0xE83314")]
	public static string GetDebugName(CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xE83554", Offset = "0xE83554", VA = "0xE83554")]
	public static Segment GetSegment(CoroutineHandle handle)
	{
		return default(Segment);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xE83664", Offset = "0xE83664", VA = "0xE83664")]
	public static bool SetTag(CoroutineHandle handle, string newTag, bool overwriteExisting = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xE83978", Offset = "0xE83978", VA = "0xE83978")]
	public static bool SetLayer(CoroutineHandle handle, int newLayer, bool overwriteExisting = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xE83C8C", Offset = "0xE83C8C", VA = "0xE83C8C")]
	public static bool SetSegment(CoroutineHandle handle, Segment newSegment)
	{
		return default(bool);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xE84DF0", Offset = "0xE84DF0", VA = "0xE84DF0")]
	public static bool RemoveTag(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xE84E4C", Offset = "0xE84E4C", VA = "0xE84E4C")]
	public static bool RemoveLayer(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xE7897C", Offset = "0xE7897C", VA = "0xE7897C")]
	public static bool IsRunning(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xE84F7C", Offset = "0xE84F7C", VA = "0xE84F7C")]
	public static bool IsAliveAndPaused(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xE7DBD4", Offset = "0xE7DBD4", VA = "0xE7DBD4")]
	private void AddTagOnInstance(string tag, CoroutineHandle handle)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xE7DD44", Offset = "0xE7DD44", VA = "0xE7DD44")]
	private void AddLayerOnInstance(int layer, CoroutineHandle handle)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xE837E4", Offset = "0xE837E4", VA = "0xE837E4")]
	private void RemoveTagOnInstance(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xE83AF8", Offset = "0xE83AF8", VA = "0xE83AF8")]
	private void RemoveLayerOnInstance(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xE74104", Offset = "0xE74104", VA = "0xE74104")]
	private void RemoveGraffiti(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xE83F84", Offset = "0xE83F84", VA = "0xE83F84")]
	private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xE73E60", Offset = "0xE73E60", VA = "0xE73E60")]
	private bool CoindexIsNull(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xE83498", Offset = "0xE83498", VA = "0xE83498")]
	private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xE7E598", Offset = "0xE7E598", VA = "0xE7E598")]
	private bool Nullify(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xE7E70C", Offset = "0xE7E70C", VA = "0xE7E70C")]
	private bool Nullify(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xE80070", Offset = "0xE80070", VA = "0xE80070")]
	private bool SetPause(ProcessIndex coindex, bool newPausedState)
	{
		return default(bool);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xE841D4", Offset = "0xE841D4", VA = "0xE841D4")]
	private bool SetHeld(ProcessIndex coindex, bool newHeldState)
	{
		return default(bool);
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xE850C0", Offset = "0xE850C0", VA = "0xE850C0")]
	private IEnumerator<float> CreateHold(ProcessIndex coindex, IEnumerator<float> coptr)
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xE8410C", Offset = "0xE8410C", VA = "0xE8410C")]
	private bool CoindexIsPaused(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xE84044", Offset = "0xE84044", VA = "0xE84044")]
	private bool CoindexIsHeld(ProcessIndex coindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xE85C7C", Offset = "0xE85C7C", VA = "0xE85C7C")]
	private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xE85D64", Offset = "0xE85D64", VA = "0xE85D64")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine)
	{
		return default(float);
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xE86150", Offset = "0xE86150", VA = "0xE86150")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xE861E0", Offset = "0xE861E0", VA = "0xE861E0")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer)
	{
		return default(float);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xE86270", Offset = "0xE86270", VA = "0xE86270")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xE86310", Offset = "0xE86310", VA = "0xE86310")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment)
	{
		return default(float);
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xE86380", Offset = "0xE86380", VA = "0xE86380")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xE863F8", Offset = "0xE863F8", VA = "0xE863F8")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer)
	{
		return default(float);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xE86470", Offset = "0xE86470", VA = "0xE86470")]
	public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xE864F8", Offset = "0xE864F8", VA = "0xE864F8")]
	public static float WaitUntilDone(CoroutineHandle otherCoroutine)
	{
		return default(float);
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xE85DEC", Offset = "0xE85DEC", VA = "0xE85DEC")]
	public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
	{
		return default(float);
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xE78B70", Offset = "0xE78B70", VA = "0xE78B70")]
	public static void WaitForOtherHandles(CoroutineHandle handle, CoroutineHandle otherHandle, bool warnOnIssue = true)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xE7954C", Offset = "0xE7954C", VA = "0xE7954C")]
	public static void WaitForOtherHandles(CoroutineHandle handle, IEnumerable<CoroutineHandle> otherHandles, bool warnOnIssue = true)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xE865D0", Offset = "0xE865D0", VA = "0xE865D0")]
	private void SwapToLast(CoroutineHandle firstHandle, CoroutineHandle lastHandle)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xE86550", Offset = "0xE86550", VA = "0xE86550")]
	[IteratorStateMachine(typeof(<_StartWhenDone>d__275))]
	private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
	{
		return null;
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xE73F28", Offset = "0xE73F28", VA = "0xE73F28")]
	private void CloseWaitingProcess(CoroutineHandle handle)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xE869E4", Offset = "0xE869E4", VA = "0xE869E4")]
	private bool HandleIsInWaitingList(CoroutineHandle handle)
	{
		return default(bool);
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xE86ACC", Offset = "0xE86ACC", VA = "0xE86ACC")]
	private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xE86B3C", Offset = "0xE86B3C", VA = "0xE86B3C")]
	public static float WaitUntilDone(AsyncOperation operation)
	{
		return default(float);
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xE86CDC", Offset = "0xE86CDC", VA = "0xE86CDC")]
	[IteratorStateMachine(typeof(<_StartWhenDone>d__280))]
	private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
	{
		return null;
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xE86D50", Offset = "0xE86D50", VA = "0xE86D50")]
	public static float WaitUntilDone(CustomYieldInstruction operation)
	{
		return default(float);
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xE86EF4", Offset = "0xE86EF4", VA = "0xE86EF4")]
	[IteratorStateMachine(typeof(<_StartWhenDone>d__282))]
	private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
	{
		return null;
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xE86F68", Offset = "0xE86F68", VA = "0xE86F68")]
	public static float WaitUntilTrue(Func<bool> evaluatorFunc)
	{
		return default(float);
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xE8703C", Offset = "0xE8703C", VA = "0xE8703C")]
	private static IEnumerator<float> WaitUntilTrueHelper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xE87140", Offset = "0xE87140", VA = "0xE87140")]
	public static float WaitUntilFalse(Func<bool> evaluatorFunc)
	{
		return default(float);
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xE87214", Offset = "0xE87214", VA = "0xE87214")]
	private static IEnumerator<float> WaitUntilFalseHelper(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xE870BC", Offset = "0xE870BC", VA = "0xE870BC")]
	[IteratorStateMachine(typeof(<_StartWhenDone>d__287))]
	private static IEnumerator<float> _StartWhenDone(Func<bool> evaluatorFunc, bool continueOn, IEnumerator<float> pausedProc)
	{
		return null;
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xE7FC80", Offset = "0xE7FC80", VA = "0xE7FC80")]
	[IteratorStateMachine(typeof(<_InjectDelay>d__288))]
	private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float waitTime)
	{
		return null;
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xE87294", Offset = "0xE87294", VA = "0xE87294")]
	public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xE874A0", Offset = "0xE874A0", VA = "0xE874A0")]
	public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xE87698", Offset = "0xE87698", VA = "0xE87698")]
	public static int LinkCoroutines(CoroutineHandle master, CoroutineHandle slave)
	{
		return default(int);
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xE878F0", Offset = "0xE878F0", VA = "0xE878F0")]
	public static int UnlinkCoroutines(CoroutineHandle master, CoroutineHandle slave, bool twoWay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xE87BEC", Offset = "0xE87BEC", VA = "0xE87BEC")]
	[Obsolete("Use Timing.CurrentCoroutine instead.", false)]
	public static float GetMyHandle(Action<CoroutineHandle> reciever)
	{
		return default(float);
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xE87CA8", Offset = "0xE87CA8", VA = "0xE87CA8")]
	private static IEnumerator<float> GetHandleHelper(IEnumerator<float> input, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xE87D4C", Offset = "0xE87D4C", VA = "0xE87D4C")]
	public static float SwitchCoroutine(Segment newSegment)
	{
		return default(float);
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xE87E08", Offset = "0xE87E08", VA = "0xE87E08")]
	private static IEnumerator<float> SwitchCoroutineRepS(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xE87EB4", Offset = "0xE87EB4", VA = "0xE87EB4")]
	public static float SwitchCoroutine(Segment newSegment, string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xE87F80", Offset = "0xE87F80", VA = "0xE87F80")]
	private static IEnumerator<float> SwitchCoroutineRepST(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xE880D8", Offset = "0xE880D8", VA = "0xE880D8")]
	public static float SwitchCoroutine(Segment newSegment, int newLayer)
	{
		return default(float);
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xE881A4", Offset = "0xE881A4", VA = "0xE881A4")]
	private static IEnumerator<float> SwitchCoroutineRepSL(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xE8827C", Offset = "0xE8827C", VA = "0xE8827C")]
	public static float SwitchCoroutine(Segment newSegment, int newLayer, string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xE88350", Offset = "0xE88350", VA = "0xE88350")]
	private static IEnumerator<float> SwitchCoroutineRepSLT(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xE884CC", Offset = "0xE884CC", VA = "0xE884CC")]
	public static float SwitchCoroutine(string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xE88588", Offset = "0xE88588", VA = "0xE88588")]
	private static IEnumerator<float> SwitchCoroutineRepT(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xE8869C", Offset = "0xE8869C", VA = "0xE8869C")]
	public static float SwitchCoroutine(int newLayer)
	{
		return default(float);
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xE88758", Offset = "0xE88758", VA = "0xE88758")]
	private static IEnumerator<float> SwitchCoroutineRepL(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xE887F0", Offset = "0xE887F0", VA = "0xE887F0")]
	public static float SwitchCoroutine(int newLayer, string newTag)
	{
		return default(float);
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xE888BC", Offset = "0xE888BC", VA = "0xE888BC")]
	private static IEnumerator<float> SwitchCoroutineRepLT(IEnumerator<float> coptr, CoroutineHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xE889F4", Offset = "0xE889F4", VA = "0xE889F4")]
	public static CoroutineHandle CallDelayed(float delay, Action action)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xE88B0C", Offset = "0xE88B0C", VA = "0xE88B0C")]
	public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xE88B40", Offset = "0xE88B40", VA = "0xE88B40")]
	public static CoroutineHandle CallDelayed(float delay, Action action, GameObject gameObject)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xE88BD4", Offset = "0xE88BD4", VA = "0xE88BD4")]
	public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject gameObject)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xE88A80", Offset = "0xE88A80", VA = "0xE88A80")]
	[IteratorStateMachine(typeof(<_DelayedCall>d__313))]
	private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
	{
		return null;
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xE88C14", Offset = "0xE88C14", VA = "0xE88C14")]
	public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xE88CA8", Offset = "0xE88CA8", VA = "0xE88CA8")]
	public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xE88CF0", Offset = "0xE88CF0", VA = "0xE88CF0")]
	public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action, GameObject gameObject)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xE88D94", Offset = "0xE88D94", VA = "0xE88D94")]
	public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action, GameObject gameObject)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xE88DE4", Offset = "0xE88DE4", VA = "0xE88DE4")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xE88FDC", Offset = "0xE88FDC", VA = "0xE88FDC")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xE89068", Offset = "0xE89068", VA = "0xE89068")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xE89158", Offset = "0xE89158", VA = "0xE89158")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xE89248", Offset = "0xE89248", VA = "0xE89248")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xE8932C", Offset = "0xE8932C", VA = "0xE8932C")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xE8941C", Offset = "0xE8941C", VA = "0xE8941C")]
	public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xE89518", Offset = "0xE89518", VA = "0xE89518")]
	public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xE8961C", Offset = "0xE8961C", VA = "0xE8961C")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xE896F4", Offset = "0xE896F4", VA = "0xE896F4")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xE897D4", Offset = "0xE897D4", VA = "0xE897D4")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xE898C0", Offset = "0xE898C0", VA = "0xE898C0")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xE899AC", Offset = "0xE899AC", VA = "0xE899AC")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xE89A98", Offset = "0xE89A98", VA = "0xE89A98")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xE89B84", Offset = "0xE89B84", VA = "0xE89B84")]
	public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xE89C7C", Offset = "0xE89C7C", VA = "0xE89C7C")]
	public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xE88F40", Offset = "0xE88F40", VA = "0xE88F40")]
	[IteratorStateMachine(typeof(<_WatchCall>d__334))]
	private IEnumerator<float> _WatchCall(float timeframe, CoroutineHandle handle, GameObject gObject, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xE88EB4", Offset = "0xE88EB4", VA = "0xE88EB4")]
	[IteratorStateMachine(typeof(<_CallContinuously>d__335))]
	private IEnumerator<float> _CallContinuously(float period, Action action, GameObject gObject)
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600016F")]
	public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000170")]
	public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000171")]
	public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000172")]
	public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000173")]
	public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000174")]
	public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000175")]
	public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000176")]
	public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000177")]
	public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000178")]
	public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000179")]
	public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600017A")]
	public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600017B")]
	public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600017C")]
	public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600017D")]
	public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600017E")]
	[IteratorStateMachine(typeof(<_WatchCall>d__352<>))]
	private IEnumerator<float> _WatchCall<T>(T reference, float timeframe, CoroutineHandle handle, GameObject gObject, Action<T> onDone)
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[IteratorStateMachine(typeof(<_CallContinuously>d__353<>))]
	private IEnumerator<float> _CallContinuously<T>(T reference, float period, Action<T> action, GameObject gObject)
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xE89D7C", Offset = "0xE89D7C", VA = "0xE89D7C")]
	[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
	public new Coroutine StartCoroutine(IEnumerator routine)
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xE89D84", Offset = "0xE89D84", VA = "0xE89D84")]
	[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
	public new Coroutine StartCoroutine(string methodName, object value)
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xE89D8C", Offset = "0xE89D8C", VA = "0xE89D8C")]
	[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
	public new Coroutine StartCoroutine(string methodName)
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xE89D94", Offset = "0xE89D94", VA = "0xE89D94")]
	[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
	public new Coroutine StartCoroutine_Auto(IEnumerator routine)
	{
		return null;
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xE89D9C", Offset = "0xE89D9C", VA = "0xE89D9C")]
	[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
	public new void StopCoroutine(string methodName)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xE89DA0", Offset = "0xE89DA0", VA = "0xE89DA0")]
	[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
	public new void StopCoroutine(IEnumerator routine)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xE89DA4", Offset = "0xE89DA4", VA = "0xE89DA4")]
	[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
	public new void StopCoroutine(Coroutine routine)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xE89DA8", Offset = "0xE89DA8", VA = "0xE89DA8")]
	[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
	public new void StopAllCoroutines()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xE89DAC", Offset = "0xE89DAC", VA = "0xE89DAC")]
	[Obsolete("Use your own GameObject for this.", true)]
	public new static void Destroy(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xE89DB0", Offset = "0xE89DB0", VA = "0xE89DB0")]
	[Obsolete("Use your own GameObject for this.", true)]
	public new static void Destroy(UnityEngine.Object obj, float f)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xE89DB4", Offset = "0xE89DB4", VA = "0xE89DB4")]
	[Obsolete("Use your own GameObject for this.", true)]
	public new static void DestroyObject(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xE89DB8", Offset = "0xE89DB8", VA = "0xE89DB8")]
	[Obsolete("Use your own GameObject for this.", true)]
	public new static void DestroyObject(UnityEngine.Object obj, float f)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xE89DBC", Offset = "0xE89DBC", VA = "0xE89DBC")]
	[Obsolete("Use your own GameObject for this.", true)]
	public new static void DestroyImmediate(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xE89DC0", Offset = "0xE89DC0", VA = "0xE89DC0")]
	[Obsolete("Use your own GameObject for this.", true)]
	public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xE89DC4", Offset = "0xE89DC4", VA = "0xE89DC4")]
	[Obsolete("Use your own GameObject for this.", true)]
	public new static void Instantiate(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xE89DC8", Offset = "0xE89DC8", VA = "0xE89DC8")]
	[Obsolete("Use your own GameObject for this.", true)]
	public new static void Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation)
	{
	}

	[Token(Token = "0x6000190")]
	[Obsolete("Use your own GameObject for this.", true)]
	public new static void Instantiate<T>(T original) where T : UnityEngine.Object
	{
	}

	[Token(Token = "0x6000191")]
	[Obsolete("Just.. no.", true)]
	public new static T FindObjectOfType<T>() where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xE89DCC", Offset = "0xE89DCC", VA = "0xE89DCC")]
	[Obsolete("Just.. no.", true)]
	public new static UnityEngine.Object FindObjectOfType(Type t)
	{
		return null;
	}

	[Token(Token = "0x6000193")]
	[Obsolete("Just.. no.", true)]
	public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xE89DD4", Offset = "0xE89DD4", VA = "0xE89DD4")]
	[Obsolete("Just.. no.", true)]
	public new static UnityEngine.Object[] FindObjectsOfType(Type t)
	{
		return null;
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xE89DDC", Offset = "0xE89DDC", VA = "0xE89DDC")]
	[Obsolete("Just.. no.", true)]
	public new static void print(object message)
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xE89DE0", Offset = "0xE89DE0", VA = "0xE89DE0")]
	public Timing()
	{
	}
}
[Token(Token = "0x2000025")]
public enum Segment
{
	[Token(Token = "0x4000103")]
	Invalid = -1,
	[Token(Token = "0x4000104")]
	Update,
	[Token(Token = "0x4000105")]
	FixedUpdate,
	[Token(Token = "0x4000106")]
	LateUpdate,
	[Token(Token = "0x4000107")]
	SlowUpdate,
	[Token(Token = "0x4000108")]
	RealtimeUpdate,
	[Token(Token = "0x4000109")]
	EditorUpdate,
	[Token(Token = "0x400010A")]
	EditorSlowUpdate,
	[Token(Token = "0x400010B")]
	EndOfFrame,
	[Token(Token = "0x400010C")]
	ManualTimeframe
}
[Token(Token = "0x2000026")]
public enum DebugInfoType
{
	[Token(Token = "0x400010E")]
	None,
	[Token(Token = "0x400010F")]
	SeperateCoroutines,
	[Token(Token = "0x4000110")]
	SeperateTags
}
[Token(Token = "0x2000027")]
public enum SingletonBehavior
{
	[Token(Token = "0x4000112")]
	Abort,
	[Token(Token = "0x4000113")]
	Overwrite,
	[Token(Token = "0x4000114")]
	Wait,
	[Token(Token = "0x4000115")]
	AbortAndUnpause
}
[Token(Token = "0x2000028")]
public struct CoroutineHandle : IEquatable<CoroutineHandle>
{
	[Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class <_OnDestroy>d__32 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CoroutineHandle watched;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action action;

		[Token(Token = "0x1700004E")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0xE915A8", Offset = "0xE915A8", VA = "0xE915A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0xE915F0", Offset = "0xE915F0", VA = "0xE915F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xE91470", Offset = "0xE91470", VA = "0xE91470")]
		[DebuggerHidden]
		public <_OnDestroy>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xE91544", Offset = "0xE91544", VA = "0xE91544", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xE91548", Offset = "0xE91548", VA = "0xE91548", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xE915B0", Offset = "0xE915B0", VA = "0xE915B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class <_OnDestroy>d__33 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CoroutineHandle watched;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> action;

		[Token(Token = "0x17000050")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0xE917BC", Offset = "0xE917BC", VA = "0xE917BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000051")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0xE91804", Offset = "0xE91804", VA = "0xE91804", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xE91498", Offset = "0xE91498", VA = "0xE91498")]
		[DebuggerHidden]
		public <_OnDestroy>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xE9164C", Offset = "0xE9164C", VA = "0xE9164C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xE91650", Offset = "0xE91650", VA = "0xE91650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xE917C4", Offset = "0xE917C4", VA = "0xE917C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000116")]
	private const byte ReservedSpace = 15;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int[] NextIndex;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly int _id;

	[Token(Token = "0x17000047")]
	public byte Key
	{
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xE908A4", Offset = "0xE908A4", VA = "0xE908A4")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x17000048")]
	public string Tag
	{
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xE90D28", Offset = "0xE90D28", VA = "0xE90D28")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xE90D84", Offset = "0xE90D84", VA = "0xE90D84")]
		set
		{
		}
	}

	[Token(Token = "0x17000049")]
	public int? Layer
	{
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xE90DF4", Offset = "0xE90DF4", VA = "0xE90DF4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xE90E50", Offset = "0xE90E50", VA = "0xE90E50")]
		set
		{
		}
	}

	[Token(Token = "0x1700004A")]
	public Segment Segment
	{
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xE90F2C", Offset = "0xE90F2C", VA = "0xE90F2C")]
		get
		{
			return default(Segment);
		}
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xE90F88", Offset = "0xE90F88", VA = "0xE90F88")]
		set
		{
		}
	}

	[Token(Token = "0x1700004B")]
	public bool IsRunning
	{
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xE8D644", Offset = "0xE8D644", VA = "0xE8D644")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xE90FF4", Offset = "0xE90FF4", VA = "0xE90FF4")]
		set
		{
		}
	}

	[Token(Token = "0x1700004C")]
	public bool IsAliveAndPaused
	{
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xE91068", Offset = "0xE91068", VA = "0xE91068")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xE910C4", Offset = "0xE910C4", VA = "0xE910C4")]
		set
		{
		}
	}

	[Token(Token = "0x1700004D")]
	public bool IsValid
	{
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xE91140", Offset = "0xE91140", VA = "0xE91140")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xE908B0", Offset = "0xE908B0", VA = "0xE908B0")]
	public CoroutineHandle(byte ind)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xE90960", Offset = "0xE90960", VA = "0xE90960")]
	public CoroutineHandle(CoroutineHandle other)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xE90968", Offset = "0xE90968", VA = "0xE90968", Slot = "4")]
	public bool Equals(CoroutineHandle other)
	{
		return default(bool);
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xE90978", Offset = "0xE90978", VA = "0xE90978", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xE909F0", Offset = "0xE909F0", VA = "0xE909F0")]
	public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
	{
		return default(bool);
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xE909FC", Offset = "0xE909FC", VA = "0xE909FC")]
	public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
	{
		return default(bool);
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xE90A08", Offset = "0xE90A08", VA = "0xE90A08", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xE90A10", Offset = "0xE90A10", VA = "0xE90A10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xE91150", Offset = "0xE91150", VA = "0xE91150")]
	public CoroutineHandle OnDestroy(Action action, Segment segment = Segment.Update)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xE912E0", Offset = "0xE912E0", VA = "0xE912E0")]
	public CoroutineHandle OnDestroy(IEnumerator<float> action, Segment segment = Segment.Update)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xE91268", Offset = "0xE91268", VA = "0xE91268")]
	[IteratorStateMachine(typeof(<_OnDestroy>d__32))]
	private static IEnumerator<float> _OnDestroy(CoroutineHandle watched, Action action)
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xE913F8", Offset = "0xE913F8", VA = "0xE913F8")]
	[IteratorStateMachine(typeof(<_OnDestroy>d__33))]
	private static IEnumerator<float> _OnDestroy(CoroutineHandle watched, IEnumerator<float> action)
	{
		return null;
	}
}
[Token(Token = "0x200002B")]
public static class MECExtensionMethods1
{
	[Token(Token = "0x600020B")]
	[Address(RVA = "0xE91860", Offset = "0xE91860", VA = "0xE91860")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xE918C0", Offset = "0xE918C0", VA = "0xE918C0")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xE91930", Offset = "0xE91930", VA = "0xE91930")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xE919A0", Offset = "0xE919A0", VA = "0xE919A0")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xE91A10", Offset = "0xE91A10", VA = "0xE91A10")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xE91A88", Offset = "0xE91A88", VA = "0xE91A88")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xE91B00", Offset = "0xE91B00", VA = "0xE91B00")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xE91B70", Offset = "0xE91B70", VA = "0xE91B70")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xE91BE8", Offset = "0xE91BE8", VA = "0xE91BE8")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, int layer)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xE91C60", Offset = "0xE91C60", VA = "0xE91C60")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xE91CD8", Offset = "0xE91CD8", VA = "0xE91CD8")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xE91D60", Offset = "0xE91D60", VA = "0xE91D60")]
	public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, int layer, string tag)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xE91DE8", Offset = "0xE91DE8", VA = "0xE91DE8")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xE91E60", Offset = "0xE91E60", VA = "0xE91E60")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xE91F4C", Offset = "0xE91F4C", VA = "0xE91F4C")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xE91FC4", Offset = "0xE91FC4", VA = "0xE91FC4")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xE9203C", Offset = "0xE9203C", VA = "0xE9203C")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xE92140", Offset = "0xE92140", VA = "0xE92140")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xE921C8", Offset = "0xE921C8", VA = "0xE921C8")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xE92250", Offset = "0xE92250", VA = "0xE92250")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0xE92350", Offset = "0xE92350", VA = "0xE92350")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0xE923D8", Offset = "0xE923D8", VA = "0xE923D8")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xE92460", Offset = "0xE92460", VA = "0xE92460")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xE92570", Offset = "0xE92570", VA = "0xE92570")]
	public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
	{
		return default(CoroutineHandle);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xE92600", Offset = "0xE92600", VA = "0xE92600")]
	public static float WaitUntilDone(this IEnumerator<float> newCoroutine)
	{
		return default(float);
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xE92658", Offset = "0xE92658", VA = "0xE92658")]
	public static float WaitUntilDone(this IEnumerator<float> newCoroutine, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xE926C0", Offset = "0xE926C0", VA = "0xE926C0")]
	public static float WaitUntilDone(this IEnumerator<float> newCoroutine, int layer)
	{
		return default(float);
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xE92728", Offset = "0xE92728", VA = "0xE92728")]
	public static float WaitUntilDone(this IEnumerator<float> newCoroutine, int layer, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xE92798", Offset = "0xE92798", VA = "0xE92798")]
	public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment)
	{
		return default(float);
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xE92800", Offset = "0xE92800", VA = "0xE92800")]
	public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment, string tag)
	{
		return default(float);
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0xE92870", Offset = "0xE92870", VA = "0xE92870")]
	public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment, int layer)
	{
		return default(float);
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0xE928E0", Offset = "0xE928E0", VA = "0xE928E0")]
	public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
	{
		return default(float);
	}
}
